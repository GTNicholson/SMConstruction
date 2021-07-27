Imports System.Environment
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmSalesOrderDetailHouses
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pFormController As fccSalesOrderDetailHouses

  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


  Private Enum eOrderItemGroupButtonTags
    Add = 1
    Delete = 2
    AddFromPicker = 3
    GenerateSequence = 4
  End Enum

  Private Enum eWorkOrderGroupButtonTags
    Add = 1
    Delete = 2
  End Enum
  Private Enum eLanguageReportOption
    Spanish = 1
    English = 2
  End Enum
  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmSalesOrderDetailHouses = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmSalesOrderDetailHouses
      mfrm.pFormController = New fccSalesOrderDetailHouses(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmSalesOrderDetailHouses
    Dim mfrmWanted As frmSalesOrderDetailHouses = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmSalesOrderDetailHouses
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.FormController.PrimaryKeyID = vPrimaryKeyID Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Public ReadOnly Property FormController As fccSalesOrderDetailHouses
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmSalesOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()
      SetupPermissions()
      LoadGrids()
      rgLanguageOptions.SelectedIndex = 0
      RefreshHouseTabs()
      xtcOrderType.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
      LoadCombos()
      RefreshControls()

      If pFormController.SalesOrder.OrderNo <> "" Then
        Me.Text = "Detalle de Venta - " & pFormController.SalesOrder.OrderNo

      End If
      ''If mOK Then SetupUserPermissions()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True




  End Sub

  Private Sub SetupPermissions()
    Dim mStockItemManagerPermission As ePermissionCode = My.Application.RTISUserSession.ActivityPermission(eActivityCode.StructureWorkOrder)

  End Sub

  Private Sub LoadGrids()
    grdOrderItem.DataSource = pFormController.SalesItemEditors ' SalesOrder.SalesOrderItems
    grdInvoices.DataSource = pFormController.Invoices
    grdPaymentAccounts.DataSource = pFormController.PaymentAccounts

    grdCustomerPurchaseOrder.DataSource = pFormController.CustomerPurchaseOrders

    grdSalesOrderPhases.DataSource = pFormController.SalesOrder.SalesOrderPhases
    grdProductsRequired.DataSource = pFormController.ProductRequirementProcessors

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub


  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    ''RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboOrderTypeID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.OrderType))

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eOrderType))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboOrderTypeID, mVIs)


    mVIs = clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus))

    clsDEControlLoading.FillDEComboVI(cboEstatusENUM, mVIs)




    clsDEControlLoading.FillDEComboVI(cboSalesDelAreaID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))
    clsDEControlLoading.FillDEComboVI(cboContractManagerID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees))
    clsDEControlLoading.FillDEComboVI(cboProjectOwner, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees))



    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodSpecie)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdOrderItem, gcWoodSpecie, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodFinish)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdOrderItem, gcWoodFinish, mVIs)

    clsDEControlLoading.LoadGridLookUpEditiVI(grdOrderItem, gcUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))

    clsDEControlLoading.LoadGridLookUpEditiVI(grdInvoices, gcInvoiceStatus, clsEnumsConstants.EnumToVIs(GetType(eInvoiceStatus)))

    LoadCustomerContactCombo()


    clsDEControlLoading.FillDEComboVI(cboCostBook, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.CostBook))

  End Sub



  Private Sub LoadCustomerContactCombo()

    If pFormController.SalesOrder.Customer IsNot Nothing Then
      RTIS.Elements.clsDEControlLoading.FillDEComboVIi(cboCustomerDelContacID, pFormController.SalesOrder.Customer.CustomerContacts)
    End If
  End Sub



  Private Sub RefreshControls()
    Try

      With pFormController.SalesOrder

        If .OrderPhaseType = eOrderPhaseType.SinglePhase Then
          If .SalesOrderPhases IsNot Nothing And .SalesOrderPhases.Count > 0 Then
            With .SalesOrderPhases
              dteFinishDate.EditValue = .Item(0).DateRequired
              dteDueTime.EditValue = .Item(0).DateCommitted
            End With
          End If

        End If

        lblSalesOrderID.Text = "ID: " & .SalesOrderID.ToString("0000")
        txtSalesOrderID.Text = .OrderNo
        txtProjectName.Text = .ProjectName
        'dteDateEntered.EditValue = .DateEntered
        dteDateEntered.EditValue = clsGeneralA.DateToDBValue(.DateEntered)

        txtVisibleNotes.Text = .VisibleNotes
        txtDelAddress1.Text = .DelAddress1
        txtDelAddress2.Text = .DelAddress2
        txtCustomerContact.Text = .CustomerContactID
        ' txtShippingCost.Text = .ShippingCost
        txtVersion.Text = .Version
        btnePodio.EditValue = .PodioPath
        dteDateRequiredSO.EditValue = clsGeneralA.DateToDBValue(.FinishDate)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboCostBook, .ProductCostBookID)

        If pFormController.SalesOrder.Customer IsNot Nothing Then

          If pFormController.SalesOrder.Customer.CustomerContacts.Count > 0 Then
            txtCustomerContact.Text = pFormController.SalesOrder.Customer.CustomerContacts(0).FirstName & " " & pFormController.SalesOrder.Customer.CustomerContacts(0).LastName
          Else
            txtCustomerContact.Text = ""
          End If
        Else
          txtCustomerContact.Text = ""
        End If
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboOrderTypeID, .OrderTypeID)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboEstatusENUM, .OrderStatusENUM)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboSalesDelAreaID, .SalesDelAreaID)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboCustomerDelContacID, .CustomerDelContactID)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboContractManagerID, .EstimatorEmployeeID)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboProjectOwner, .ContractManagerID)
        txtPaymentTerm.Text = .PaymentTermDesc
        If .Customer Is Nothing Then
          btnedCustomer.Text = ""
        Else
          FillCustomerDetail()

        End If


        Select Case .OrderPhaseType
          Case eOrderPhaseType.SinglePhase
            gcPhases.CustomHeaderButtons(0).Properties.Checked = True
            gcPhases.CustomHeaderButtons(1).Properties.Checked = False
          Case eOrderPhaseType.MultiPhase
            gcPhases.CustomHeaderButtons(0).Properties.Checked = False
            gcPhases.CustomHeaderButtons(1).Properties.Checked = True
        End Select


      End With

      ''LoadOrderPhases()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub



  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try

      'UpdateObjects()
      'UpdateSalesItemAssembly()
      'UpdateSalesOrderHouse()
      CheckSave(False)
      pFormController.SaveObjects()
      RefreshHouseTabs()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try



  End Sub

  Private Sub UpdateObjects()

    If pFormController.SalesOrder IsNot Nothing Then

      With pFormController.SalesOrder

        If .OrderPhaseType = eOrderPhaseType.SinglePhase Then

          If .SalesOrderPhases IsNot Nothing And .SalesOrderPhases.Count > 0 Then ''Ensure an SOP
            With .SalesOrderPhases
              .Item(0).JobNo = txtSalesOrderID.Text
              .Item(0).DateCommitted = dteDueTime.DateTime
              .Item(0).DateRequired = dteFinishDate.DateTime
              UpdateSalesOrderPhaseItem(.Item(0))
            End With
          End If

        End If

        .OrderNo = txtSalesOrderID.Text
        .ProjectName = txtProjectName.Text
        .DateEntered = dteDateEntered.DateTime
        .FinishDate = dteDateRequiredSO.DateTime
        .ShippingCost = pFormController.SalesOrder.SalesOrderHouses.GetTotalShippingCost
        .VisibleNotes = txtVisibleNotes.Text
        .DelAddress1 = txtDelAddress1.Text
        .DelAddress2 = txtDelAddress2.Text
        .OrderTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboOrderTypeID)
        .OrderStatusENUM = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboEstatusENUM)
        .SalesDelAreaID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboSalesDelAreaID)
        .CustomerDelContactID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboCustomerDelContacID)
        .EstimatorEmployeeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboContractManagerID)
        .ContractManagerID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboProjectOwner)

        .PaymentTermDesc = txtPaymentTerm.Text
        '.ShippingCost = txtShippingCost.Text
        .Version = txtVersion.Text
        .PodioPath = btnePodio.EditValue
        .ProductCostBookID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboCostBook)
        gvOrderItem.CloseEditor()
        gvOrderItem.UpdateCurrentRow()

        gvProductsRequired.CloseEditor()
        gvProductsRequired.UpdateCurrentRow()

        gvInvoices.CloseEditor()
        gvInvoices.UpdateCurrentRow()


        gvCustomerPurchaseOrder.CloseEditor()
        gvCustomerPurchaseOrder.UpdateCurrentRow()

        UpdateSalesItemEditorSalesOrderItems()
        UpdateSalesOrderItemProductRequirement()

      End With

    End If
  End Sub

  Private Sub UpdateSalesItemEditorSalesOrderItems()

    For Each mSIE As clsSalesItemEditor In pFormController.SalesItemEditors

      Dim mSalesItem As dmSalesOrderItem

      mSalesItem = pFormController.SalesOrder.SalesOrderItems.ItemFromKey(mSIE.SalesOrderItem.SalesOrderItemID)

      If mSalesItem IsNot Nothing Then
        mSalesItem.MaterialCost = mSIE.MaterialCost
        mSalesItem.ManpowerCost = mSIE.ManpowerCost
        mSalesItem.SubContractCost = mSIE.SubContractCost
        mSalesItem.TransportationCost = mSIE.TransportationCost
        mSalesItem.LineValue = mSIE.Quantity * mSIE.UnitPrice
      End If

    Next

  End Sub

  Private Sub UpdateSalesOrderItemProductRequirement()
    For Each mPRP As clsProductRequirementProcessor In pFormController.ProductRequirementProcessors
      mPRP.ProductRequirement.AllocatedQty = mPRP.ToProcessQty
      pFormController.SaveProductRequirement(mPRP.ProductRequirement)
    Next
  End Sub

  Public Sub UpdateSalesOrderPhaseItem(ByRef rSalesOrderPhase As dmSalesOrderPhase)
    Dim mSOI As dmSalesOrderItem
    Dim mSOPI As dmSalesOrderPhaseItem
    If pFormController.SalesOrder.SalesOrderItems IsNot Nothing Then

      If pFormController.SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.Count = 0 Then
        For Each mSOITemp As dmSalesOrderItem In pFormController.SalesOrder.SalesOrderItems

          pFormController.CreateSalesOrderPhaseItem(pFormController.SalesOrder.SalesOrderPhases(0), pFormController.SalesOrder.SalesOrderID)

        Next
      Else
        For Each mSalesItem As dmSalesOrderItem In pFormController.SalesOrder.SalesOrderItems

          mSOPI = rSalesOrderPhase.SalesOrderPhaseItems.ItemFromSalesItemKey(mSalesItem.SalesOrderItemID)

          If mSOPI IsNot Nothing Then
            mSOPI.Qty = mSalesItem.Quantity
          Else
            pFormController.CreateSalesOrderPhaseItem(pFormController.SalesOrder.SalesOrderPhases(0), pFormController.SalesOrder.SalesOrderID)

          End If

        Next
      End If

    End If
    pFormController.SaveObjects()

  End Sub

  Private Sub btnedCustomer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnedCustomer.ButtonClick
    Try
      Select Case e.Button.Kind
        Case ButtonPredefines.Combo
          Dim mCustomerPicker As clsPickerCustomer
          Dim mcustomer As dmCustomer
          UpdateObjects()
          mCustomerPicker = New clsPickerCustomer(pFormController.GetCustomerList, pFormController.DBConn)
          mcustomer = frmPickerCustomer.OpenPickerSingle(mCustomerPicker)
          If mcustomer IsNot Nothing Then
            pFormController.SalesOrder.CustomerID = mcustomer.CustomerID
            pFormController.SalesOrder.Customer = mcustomer
            pFormController.ReloadCustomer()
            FillCustomerDetail()
            LoadCustomerContactCombo()
          End If
          RefreshControls()
        Case ButtonPredefines.Ellipsis
          frmCustomerDetail.OpenFormModal(pFormController.SalesOrder.CustomerID, pFormController.DBConn)
          If pFormController.SalesOrder.CustomerID <> 0 Then
            pFormController.ReloadCustomer()
            FillCustomerDetail()
            LoadCustomerContactCombo()
          End If
          RefreshControls()
      End Select

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub FillCustomerDetail()

    Try
      With pFormController.SalesOrder
        btnedCustomer.Text = .Customer.CompanyName

        txtMainTown.Text = .Customer.MainTown
        'txtSalesAreaID.Text = .Customer.SalesAreaID
        txtSalesAreaID.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country).ItemValueToDisplayValue(.Customer.SalesAreaID)

        'CustomerStatusID.Text = clsEnumsConstants.EnumToVIs(GetType(eCustomerStatus)).ItemValueToDisplayValue(.Customer.CustomerStatusID)

        'CustomerStatusID.Text = .Customer.CustomerStatusID

      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  ''Private Sub grpWorkOrders_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWorkOrders.CustomButtonClick
  ''  Dim mWO As dmWorkOrder
  ''  Select Case e.Button.Properties.Tag
  ''    Case eWorkOrderGroupButtonTags.Add
  ''      UpdateObjects()
  ''      pFormController.AddWorkOrder(eProductType.ProductFurniture)
  ''      RefreshControls()
  ''    Case eWorkOrderGroupButtonTags.Delete
  ''      mWO = TryCast(gvWorkOrders.GetFocusedRow, dmWorkOrder)
  ''      If mWO IsNot Nothing Then
  ''        If MsgBox("Eliminar este Orden de Trabajo?", vbYesNo) = vbYes Then
  ''          UpdateObjects()
  ''          pFormController.DeleteWorkOrder(mWO)
  ''          RefreshControls()
  ''        End If
  ''      End If
  ''  End Select
  ''  gvWorkOrders.RefreshData()
  ''End Sub

  Private Sub repitbtWorkOrder_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repitbtWorkOrder.ButtonClick
    Dim mProductReqProc As clsProductRequirementProcessor
    Dim mWorkOrder As dmWorkOrder = Nothing
    Dim mWorkOrderInfos As colWorkOrderInfos
    Dim mWOPicker As clsPickerWorkOrder
    Dim mWOInfo As clsWorkOrderInfo
    Dim mPRP As clsProductRequirementProcessor

    Try


      Select Case e.Button.Tag
        Case "EditOT"
          mProductReqProc = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)
          gvProductsRequired.CloseEditor()
          If mProductReqProc IsNot Nothing Then

            mWorkOrder = pFormController.GetWorkOrderByWorkOrderOrderAllocationID(mProductReqProc.WorkOrderAllocationID)



            If mWorkOrder IsNot Nothing Then

              frmWorkOrderDetailConstruction.OpenFormModalWithObjects(mWorkOrder, pFormController.SalesOrder, pFormController.DBConn, AppRTISGlobal.GetInstance, True)

              gvProductsRequired.RefreshData()

            End If

          End If

        Case "Create"
          Dim mTotalQuantityToProcess As Integer

          gvProductsRequired.CloseEditor()

          If MsgBox("¿Desea crear una OT para este producto?", vbYesNo) = vbYes Then
            mProductReqProc = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)


            If mProductReqProc IsNot Nothing Then

              If pFormController.CurrentSalesOrderHouse IsNot Nothing Then
                mTotalQuantityToProcess = mProductReqProc.ToProcessQty * pFormController.CurrentSalesOrderHouse.Quantity

              Else
                mTotalQuantityToProcess = mProductReqProc.ToProcessQty

              End If
              If pFormController.SalesOrder.SalesOrderPhases(0) IsNot Nothing Then
                If pFormController.SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems IsNot Nothing Then
                  If pFormController.SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.Count < 1 Then
                    pFormController.CreateSalesOrderPhaseItem(pFormController.SalesOrder.SalesOrderPhases(0), pFormController.SalesOrder.SalesOrderID)
                  End If
                End If
              End If
              pFormController.AddProductWorkOrder(mProductReqProc.ProductRequirement.SalesOrderItemID, eProductType.StructureAF, mProductReqProc.ProductRequirement.ProductID, mTotalQuantityToProcess)

              If mProductReqProc.ToProcessQty > 0 Then
                mProductReqProc.ProductRequirement.AllocatedQty = mProductReqProc.ToProcessQty
                pFormController.SaveProductRequirement(mProductReqProc.ProductRequirement)
              End If
              gvProductsRequired.RefreshData()
            End If
            '// in one work order form it is possible to affect the wo numbers of it's sister wo's
            pFormController.LoadProductRequirement()
            gvProductsRequired.RefreshData()
            RefreshControls()
          End If
        Case "Delete"


        Case "Search"

          mPRP = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)
          gvProductsRequired.CloseEditor()

          If mPRP IsNot Nothing Then

            If mPRP.ProductRequirement.ProductID > 0 Then
              mWorkOrderInfos = pFormController.GetWorkOrderInfosFilteredByProductID(mPRP.ProductRequirement.ProductID)

              mWOPicker = New clsPickerWorkOrder(mWorkOrderInfos, pFormController.DBConn)


              mWOInfo = frmWorkOrderPicker.OpenPickerSingle(mWOPicker)

              If mWOInfo IsNot Nothing Then


                pFormController.LoadWorkOrderByWorkOrderID(mWorkOrder, mWOInfo.WorkOrderID)

                If mWorkOrder IsNot Nothing Then
                  UpdateSalesOrderPhaseItem(pFormController.SalesOrder.SalesOrderPhases(0))
                  pFormController.CreateWorkOrderAllocation(mPRP.ProductRequirement.SalesOrderItemID, mWorkOrder, mPRP.ProductRequirement.ProductID, mPRP.ToProcessQty)


                  pFormController.LoadProductRequirement()

                  grdProductsRequired.DataSource = pFormController.ProductRequirementProcessors

                End If
              End If
            Else
              MessageBox.Show("No se ha seleccionado un producto válido")
            End If
          End If

          gvProductsRequired.RefreshData()
          RefreshControls()


      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmSalesOrderDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean
    'RefreshControls()

    UpdateObjects()
    UpdateSalesItemAssembly()
    UpdateSalesOrderHouse()
    'pFormController.SaveObjects()
    If pFormController.IsDirty() Then
      If rOption Then
        mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
        Select Case mResponse
          Case MsgBoxResult.Yes
            mSaveRequired = True
            mRetVal = False
            ExitMode = Windows.Forms.DialogResult.Yes
          Case MsgBoxResult.No
            mSaveRequired = False
            mRetVal = True
            ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
          Case MsgBoxResult.Cancel
            mSaveRequired = False
            mRetVal = False
        End Select
      Else
        ExitMode = Windows.Forms.DialogResult.Yes
        mSaveRequired = True
        mRetVal = False
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.Ignore
      mSaveRequired = False
      mRetVal = True
    End If

    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then
        pFormController.SaveObjects()
        mRetVal = True
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal

    ''If mSaveRequired Then
    ''  ''Dim mValidate As clsValidate
    ''  ''mValidate = pFormController.ValidateObject
    ''  ''If mValidate.ValOk Then
    ''  pFormController.SaveObjects()
    ''  ''Else
    ''  '' MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
    ''  ''mRetVal = False
    ''  ''End If
    ''End If
    ''CheckSave = mRetVal
  End Function

  Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmSalesOrderDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    'FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If vWithCheck Then
      If CheckSave(True) Then 'Changed from False 20150206 !!!
        CloseForm()
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.No
      CloseForm()
    End If
  End Sub

  Private Sub btneSalesOrderDocument_Click(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btneSalesOrderDocument.ButtonClick
    Dim mLanguageOption As Integer

    If IsNothing(pFormController.SalesOrder.Customer) Then
      MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
      Return
    End If

    Try
      Dim mFilePath As String = String.Empty
      mLanguageOption = rgLanguageOptions.EditValue
      'UpdateObjects()
      'UpdateSalesOrderHouse()

      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
          AddSalesOrderDocument(mLanguageOption)
          ViewSalesOrderDocument()
          RefreshControls()
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete
          DeleteSalesOrderDocument()
          RefreshControls()
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis
          ViewSalesOrderDocument()
          RefreshControls()
      End Select
      RefreshSalesOrderHouse()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub AddSalesOrderDocument(ByVal vLanguageOption As Integer)
    Dim mValidate As clsValidate
    Dim mReport As DevExpress.XtraReports.UI.XtraReport = Nothing
    Dim mFilePath As String

    mValidate = pFormController.ValidateObject()
    If mValidate.ValOk Then

      CheckSave(False)

      mReport = GetReport(eDocumentType.SalesOrder, vLanguageOption)

      CreateReportPDF(eParentType.SalesOrder, eDocumentType.SalesOrder, True, mReport)

      'CheckSave(False)

      'mFilePath = pFormController.SalesOrder.OutputDocuments.GetFilePath(eParentType.PurchaseOrder, eDocumentType.PurchaseOrder, eFileType.PDF)
      mFilePath = pFormController.CurrentSalesOrderHouse.OutputDocuments.GetFilePath(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)

      RefreshControls()
      If IO.File.Exists(mFilePath) Then
        frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
      End If

      mReport.Dispose()
    Else
      MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
    End If

  End Sub

  Public Sub DeleteSalesOrderDocument()

    pFormController.SalesOrder.OutputDocuments.DeleteOutputDoc(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)

    RefreshControls()
  End Sub

  Public Sub ViewSalesOrderDocument()
    Dim mFilePath As String
    mFilePath = pFormController.SalesOrder.OutputDocuments.GetFilePath(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)

    If IO.File.Exists(mFilePath) Then
      frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
    End If

  End Sub

  Public Function GetReport(ByVal vDocType As eDocumentType, ByVal vLanguageOption As Integer) As DevExpress.XtraReports.UI.XtraReport
    Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing
    Dim mWOs As New colSalesOrders

    Select Case vDocType
      Case eDocumentType.SalesOrder

        If pFormController.SalesOrder IsNot Nothing Then
          pFormController.IsVAT = cheIsVAT.EditValue

          Select Case vLanguageOption
            Case eLanguageReportOption.Spanish
              mRetVal = repSalesOrder_Spanish.GenerateReport(pFormController.SalesOrder, pFormController.SalesItemEditors, pFormController.IsVAT, vLanguageOption, pFormController.CurrentSalesOrderHouse.SalesOrderHouseID)

            Case eLanguageReportOption.English
              mRetVal = repSalesOrder_English.GenerateReport(pFormController.SalesOrder, pFormController.SalesItemEditors, pFormController.IsVAT, vLanguageOption, pFormController.CurrentSalesOrderHouse.SalesOrderHouseID)

          End Select
        End If

    End Select

    Return mRetVal
  End Function

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.CurrentSalesOrderHouse.SalesOrderID & "_" & pFormController.CurrentSalesOrderHouse.Ref

    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.SalesOrderFileFolderSys, pFormController.SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pFormController.SalesOrder.SalesOrderID.ToString("00000")))

    mFileName &= ".pdf"
    mFileName = clsGeneralA.GetFileSafeName(mFileName)

    mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
    If IO.Directory.Exists(mExportDirectory) = False Then
      IO.Directory.CreateDirectory(mExportDirectory)
    End If

    mFilePath = IO.Path.Combine(mExportDirectory, mFileName)
    If IO.File.Exists(mFilePath) Then
      If vOverride = False Then If MsgBox("Por favor, confirme que desea volver a crear el PDF", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    End If

    ' mReport = CreateReport(vDocumentType)
    If vReport IsNot Nothing Then


      ''vReport.ExportToPdf(mFilePath, mExportOptions)
      pFormController.CreateSalesOrderPack(vReport, mFilePath)

      vReport.Dispose()
      'vReport = Nothing

      'pFormController.SalesOrder.OutputDocuments.SetFilePath(eParentType.SalesOrder, vDocumentType, eFileType.PDF, mFilePath)
      pFormController.CurrentSalesOrderHouse.OutputDocuments.SetFilePath(eParentType.SalesOrder, vDocumentType, eFileType.PDF, mFilePath)
    End If

  End Sub

  Private Sub btnedCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles btnedCustomer.EditValueChanged

  End Sub

  Private Sub grpOrderItem_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpOrderItem.CustomButtonClick
    Dim mSOI As clsSalesItemEditor
    Dim mOTCount As Integer
    Try


      Select Case e.Button.Properties.Tag
        Case eOrderItemGroupButtonTags.Add
          UpdateObjects()


          pFormController.AddSalesOrderItem(pFormController.CurrentSalesOrderHouse.SalesOrderHouseID)
          pFormController.RefreshCurrentSalesItemEditors()
          gvProductsRequired.RefreshData()
          RefreshControls()
        Case eOrderItemGroupButtonTags.Delete
          mSOI = TryCast(gvOrderItem.GetFocusedRow, clsSalesItemEditor)
          If mSOI IsNot Nothing Then
            If MsgBox("Eliminar este Articulo?", vbYesNo) = vbYes Then

              mOTCount = pFormController.GetWOsInSalesItemCount(mSOI.SalesOrderItem.SalesOrderItemID)

              If mOTCount > 0 Then
                MessageBox.Show("No es posible eliminar este artículo de venta por que ya existe una O.T. relacionado a este")

              Else
                UpdateObjects()
                Dim mSalesItemToDelete As dmSalesOrderItem
                mSalesItemToDelete = pFormController.SalesOrder.SalesOrderItems.ItemFromKey(mSOI.SalesOrderItem.SalesOrderItemID)
                pFormController.DeleteSalesOrderItem(mSalesItemToDelete)

                RefreshControls()
                pFormController.RefreshCurrentSalesItemEditors()
                gvProductsRequired.RefreshData()
              End If

            End If
          End If
      End Select
      gvProductsRequired.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvProductsRequired_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvProductsRequired.CustomUnboundColumnData
    Dim mPRP As clsProductRequirementProcessor
    Dim mFound As Boolean = False
    Select Case e.Column.Name
      Case "gcWOSOItemNumber"
        If e.IsGetData Then
          mPRP = TryCast(e.Row, clsProductRequirementProcessor)
          If mPRP IsNot Nothing Then
            e.Value = mPRP.ItemNumber
          End If
        End If
    End Select
  End Sub

  Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick
    Dim mSOI As dmSalesOrderItem
    '// get explorer for file name
    ''mSOI.ImageFile = 

    Try

      mSOI = TryCast(gvOrderItem.GetFocusedRow, dmSalesOrderItem)
      If mSOI IsNot Nothing Then


        Dim mFileName As String = ""
        If RTIS.CommonVB.clsGeneralA.GetOpenFileName(mFileName, "Selecionar Imagen") = DialogResult.OK Then

          If pFormController.CreateSOItemImageFile(mSOI, mFileName) = False Then
            MsgBox("¡No Funcionó!")
          End If
        End If
        RefreshControls()
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try



    ''Try
    ''  Dim mFileName As String = ""
    ''  If RTIS.CommonVB.clsGeneralA.GetOpenFileName(mFileName, "Seleciona Imagen") = DialogResult.OK Then
    ''    If pFormController.CreateWOImageFile(mFileName) = False Then
    ''      MsgBox("No Funciono!")
    ''    End If
    ''  End If
    ''  RefreshControls()
    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    ''End Try



  End Sub

  Private Sub grpOrderItem_Paint(sender As Object, e As PaintEventArgs) Handles grpOrderItem.Paint

  End Sub







  Private Sub gvOrderItem_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvOrderItem.RowUpdated
    '// Update the work order qtys
    Dim mSOItem As dmSalesOrderItem
    mSOItem = TryCast(e.Row, dmSalesOrderItem)
    If mSOItem IsNot Nothing Then
      For Each mWO In mSOItem.WorkOrders
        mWO.Quantity = mSOItem.Quantity * mWO.QtyPerSalesItem
      Next
    End If
    gvProductsRequired.RefreshData()
  End Sub

  Private Sub btnExportToPodio_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnePodio.ButtonClick
    Try
      Dim mFilePath As String = String.Empty
      Dim mInitDir As String = String.Empty
      Dim mSourceFile As String

      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus

          mSourceFile = pFormController.SalesOrder.OutputDocuments.GetFilePath(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)
          If IO.File.Exists(mSourceFile) Then
            mInitDir = IO.Path.Combine(Environment.GetFolderPath(SpecialFolder.UserProfile), AppRTISGlobal.GetInstance.PodioPath)
            mFilePath = "OrdenDeVenta" & pFormController.SalesOrder.OrderNo & ".pdf"
            mFilePath = RTIS.CommonVB.clsGeneralA.GetFileSafeName(mFilePath)
            If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFilePath, "Guardar Archivo en Podio", mInitDir) = DialogResult.OK Then
              IO.File.Copy(mSourceFile, mFilePath, True)
              pFormController.SalesOrder.PodioPath = mFilePath
            End If
            RefreshControls()
          End If

        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete

        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis

      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


    ''Dim mSourceFile As String = ""
    ''Dim mTargetFile As String = ""
    ''Dim mTargetPath As String = ""

    ''Try

    ''  Dim menum As Integer


    ''  RTIS.CommonVB.clsGeneralA.GetOpenFileName(mSourceFile, "SourceFile")
    ''  mTargetPath = IO.Path.Combine(Environment.GetFolderPath(SpecialFolder.UserProfile), "Dropbox", "MADE")
    ''  mTargetFile = IO.Path.GetFileName(mSourceFile)
    ''  RTIS.CommonVB.clsGeneralA.GetSaveFileName(mTargetFile, "TargetFile", mTargetPath)

    ''  IO.File.Copy(mSourceFile, mTargetFile)

    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    ''End Try

  End Sub

  Private Sub gcPhases_CustomButtonChecked(sender As Object, e As BaseButtonEventArgs) Handles gcPhases.CustomButtonChecked
    Try
      Dim mSalesOrderPhase As dmSalesOrderPhase

      gvSalesOrderPhases.CloseEditor()
      gvSalesOrderPhases.UpdateCurrentRow()



      Select Case e.Button.Properties.Tag


        Case eOrderPhaseType.SinglePhase
          If e.Button.Properties.IsChecked Then
            pFormController.SalesOrder.OrderPhaseType = eOrderPhaseType.SinglePhase

            For mLoop = pFormController.SalesOrder.SalesOrderPhases.Count - 1 To 0 Step -1
              pFormController.SalesOrder.SalesOrderPhases.RemoveAt(mLoop)
            Next

            gcPhases.CustomHeaderButtons.Item(0).Properties.Checked = True
            gcPhases.CustomHeaderButtons.Item(1).Properties.Checked = False

            dteDueTime.EditValue = Date.MinValue
            dteFinishDate.EditValue = Date.MinValue


            mSalesOrderPhase = New dmSalesOrderPhase
            mSalesOrderPhase.JobNo = txtSalesOrderID.Text
            mSalesOrderPhase.DateRequired = dteFinishDate.EditValue
            mSalesOrderPhase.DateCommitted = dteDueTime.EditValue
            mSalesOrderPhase.SalesOrderID = pFormController.PrimaryKeyID
            mSalesOrderPhase.SalesOrderNo = pFormController.SalesOrder.OrderNo
            mSalesOrderPhase.DateCreated = Now
            pFormController.SalesOrder.SalesOrderPhases.Add(mSalesOrderPhase)




          End If



        Case eOrderPhaseType.MultiPhase
          pFormController.SalesOrder.OrderPhaseType = eOrderPhaseType.MultiPhase
          gcPhases.CustomHeaderButtons.Item(0).Properties.Checked = False
          gcPhases.CustomHeaderButtons.Item(1).Properties.Checked = True




        Case Else
          pFormController.SalesOrder.OrderPhaseType = eOrderPhaseType.SinglePhase
          gcPhases.CustomHeaderButtons.Item(0).Properties.Checked = True
          gcPhases.CustomHeaderButtons.Item(1).Properties.Checked = False
      End Select
      UpdateObjects()
      RefreshControls()

      ShowHideTabs()


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub ShowHideTabs()
    ''Dim mCurrentTabPage As DevExpress.XtraTab.XtraTabPage

    ''mCurrentTabPage = xtcOrderType.SelectedTabPage

    ''''xtabPOReqType.Visible = False
    ''For Each mPg As DevExpress.XtraTab.XtraTabPage In xtcOrderType.TabPages
    ''  mPg.PageVisible = False
    ''Next
    ''If pFormController.SalesOrder IsNot Nothing Then
    ''  Select Case pFormController.SalesOrder.OrderPhaseType
    ''    Case eOrderPhaseType.SinglePhase
    ''      xtpSingle.PageVisible = True
    ''      xtpMultiple.PageVisible = False

    ''    Case eOrderPhaseType.MultiPhase

    ''      xtpSingle.PageVisible = False
    ''      xtpMultiple.PageVisible = True
    ''    Case Else

    ''      xtpSingle.PageVisible = True
    ''      xtpMultiple.PageVisible = False
    ''  End Select
    ''End If
    ''If mCurrentTabPage IsNot Nothing Then
    ''  If mCurrentTabPage.PageVisible = True Then
    ''    xtcOrderType.SelectedTabPage = mCurrentTabPage
    ''  End If
    ''End If


    If pFormController.SalesOrder IsNot Nothing Then
      Select Case pFormController.SalesOrder.OrderPhaseType
        Case eOrderPhaseType.SinglePhase
          xtcOrderType.SelectedTabPage = xtpSingle
        Case eOrderPhaseType.MultiPhase
          xtcOrderType.SelectedTabPage = xtpMultiple
        Case Else
          xtcOrderType.SelectedTabPage = xtpSingle
      End Select
    End If

  End Sub


  Private Sub xtraTabHouseType_CustomHeaderButtonClick(sender As Object, e As DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs) Handles xtraTabHouseType.CustomHeaderButtonClick

    Try

      Select Case e.Button.Kind
        Case ButtonPredefines.Plus

          ''If pFormController.SalesOrder IsNot Nothing Then
          ''  For Each mSOIA As dmSalesItemAssembly In pFormController.SalesOrder.SalesItemAssemblys
          ''    Dim mTabPage As New DevExpress.XtraTab.XtraTabPage

          ''    mTabPage.Tag = mSOIA
          ''    mTabPage.Text = String.Format("Modelo de Casa #: {0} \", pFormController.SalesOrder.OrderNo)

          ''    xtraTabHouseType.TabPages.Insert(xtraTabHouseType.TabPages.Count, mTabPage)


          ''  Next
          ''End If
          Dim mSOH As New dmSalesOrderHouse
          mSOH.SalesOrderID = pFormController.SalesOrder.SalesOrderID
          mSOH.Quantity = 1
          pFormController.SalesOrder.SalesOrderHouses.Add(mSOH)
          pFormController.SaveObjects()

          RefreshHouseTabs()
        Case ButtonPredefines.Delete
          If xtraTabHouseType.SelectedTabPage.Tag IsNot Nothing Then

            If pFormController.ProductRequirementProcessors.Count > 0 Then
              MessageBox.Show("No es posible eliminar esta casa porque existen elementos relacionados a este")
            Else
              pFormController.RemoveSalesOrderHouse(xtraTabHouseType.SelectedTabPage.Tag)

            End If


            RefreshHouseTabs()
          End If

      End Select


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private Sub RefreshHouseTabs()
    Try


      ''For mCount As Integer = tabctrlProductionBatches.TabPages.Count - 2 To 1 Step -1
      For mCount As Integer = xtraTabHouseType.TabPages.Count To 1 Step -1
        xtraTabHouseType.TabPages.RemoveAt(mCount - 1)
      Next

      If pFormController.SalesOrder IsNot Nothing Then
        For Each mSOH As dmSalesOrderHouse In pFormController.SalesOrder.SalesOrderHouses
          Dim mTabPage As New DevExpress.XtraTab.XtraTabPage

          mTabPage.Tag = mSOH

          If mSOH.Description = "" Then
            mTabPage.Text = "Casa Modelo"

          Else
            mTabPage.Text = String.Format("{0}/{1}", mSOH.Description, mSOH.Ref)

          End If

          xtraTabHouseType.TabPages.Insert(xtraTabHouseType.TabPages.Count, mTabPage)

        Next
      End If

      If xtraTabHouseType.TabPages.Count >= 1 Then
        xtraTabHouseType.SelectedTabPageIndex = 0
        pFormController.SetCurrentSalesOrderHouse(xtraTabHouseType.SelectedTabPage.Tag)
      Else
        pFormController.SetCurrentSalesOrderHouse(Nothing)
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private Sub xtraTabHouseType_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabHouseType.SelectedPageChanged
    Try

      ''pFormController.CurrentProductionBatch = e.Page.Tag ''this delete



      UpdateSalesItemAssembly()
      UpdateSalesOrderHouse()

      If e.Page IsNot Nothing Then
        If e.Page.Tag IsNot Nothing Then
          pnlHouseDetail.Parent = e.Page
          pFormController.SetCurrentSalesOrderHouse(e.Page.Tag)
        Else
          pFormController.SetCurrentSalesOrderHouse(Nothing)
        End If
      Else
        pFormController.SetCurrentSalesOrderHouse(Nothing)
      End If


      RefreshSalesOrderHouse()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub RefreshSalesOrderHouse()
    Dim mStartActive As Boolean = pIsActive
    pIsActive = False


    If pFormController.CurrentSalesOrderHouse IsNot Nothing Then

      If pFormController.CurrentSalesOrderHouse.SalesOrderHouseID > 0 Then
        With pFormController.CurrentSalesOrderHouse

          txtSOARef.Text = .Ref
          txtShippingCost.Text = .ShippingCost
          btneSalesOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)

          txtSalesItemAssemblyDescription.Text = .Description
          spnHouseQuantity.EditValue = .Quantity

          txtTotalPrice.Text = (pFormController.SalesOrder.SalesOrderItems.GetTotalValueByHouseTypeID(.SalesOrderHouseID) * .Quantity)
          grdOrderItem.RefreshDataSource()

        End With
      Else

      End If
      ''here


    End If
    pIsActive = mStartActive
  End Sub

  ''Private Sub RefreshSalesOrderAssembly()
  ''  Dim mStartActive As Boolean = pIsActive
  ''  Dim mHouseTypeInfos As New colHouseTypeInfos
  ''  Dim mdso As dsoProductAdmin

  ''  pIsActive = False


  ''  If pFormController.CurrentSalesItemAssembly IsNot Nothing Then

  ''    If pFormController.CurrentSalesItemAssembly.SalesItemAssemblyID > 0 Then
  ''      With pFormController.CurrentSalesItemAssembly

  ''        txtSOARef.Text = .Ref


  ''        ''txtTotalPrice.EditValue = .TotalPrice
  ''        txtSalesItemAssemblyDescription.Text = .Description
  ''        txtQuantity.Text = .Quantity
  ''        txtPricePerUnit.Text = .PricePerUnit
  ''        txtTotalPrice.Text = .TotalPrice

  ''        grdOrderItem.RefreshDataSource()

  ''      End With
  ''    Else

  ''    End If
  ''    ''here


  ''  End If
  ''  pIsActive = mStartActive
  ''End Sub

  Private Sub UpdateSalesOrderHouse()


    If pFormController.CurrentSalesOrderHouse IsNot Nothing Then


      With pFormController.CurrentSalesOrderHouse

        .Ref = txtSOARef.Text
        .ShippingCost = Decimal.Parse(txtShippingCost.Text)
        .TotalPrice = pFormController.SalesOrder.SalesOrderItems.GetTotalValueByHouseTypeID(.HouseTypeID)
        .Filename = btneSalesOrderDocument.Text
        .Quantity = spnHouseQuantity.EditValue
        .Description = txtSalesItemAssemblyDescription.Text



      End With

    End If

  End Sub

  Private Sub UpdateSalesItemAssembly()


    If pFormController.CurrentSalesItemAssembly IsNot Nothing AndAlso pFormController.CurrentSalesOrderHouse IsNot Nothing Then


      With pFormController.CurrentSalesItemAssembly

        .Ref = txtSOARef.Text

        If pFormController.CurrentSalesOrderHouse IsNot Nothing Then
          .HouseTypeID = pFormController.CurrentSalesOrderHouse.SalesOrderHouseID

        End If

        .TotalPrice = pFormController.SalesOrder.SalesOrderItems.GetTotalValueByHouseTypeID(pFormController.CurrentSalesOrderHouse.SalesOrderHouseID)

        .Quantity = spnHouseQuantity.EditValue
        .Description = txtSalesItemAssemblyDescription.Text


      End With

    End If

  End Sub





  Private Sub gvSSalesItemsEditor_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs)
    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
    If view Is Nothing Then
      Return
    End If
    If view.IsGroupRow(e.FocusedRowHandle) Then
      Dim expanded As Boolean = view.GetRowExpanded(e.FocusedRowHandle)
      view.SetRowExpanded(e.FocusedRowHandle, Not expanded)
    End If
  End Sub

  Private Sub repoAddProduct_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoAddProduct.ButtonClick
    Dim mProductStructure As dmProductStructure = Nothing
    Dim mSIE As clsSalesItemEditor


    If MsgBox("Agregar un Producto para este articulo?", vbYesNo) = vbYes Then

      CheckSave(False)

      mSIE = TryCast(gvOrderItem.GetFocusedRow, clsSalesItemEditor)

      mProductStructure = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
      If mProductStructure IsNot Nothing Then
        pFormController.AddProductRequirement(mProductStructure, mSIE.SalesOrderItem)

        gvProductsRequired.RefreshData()
      End If
      '// in one work order form it is possible to affect the wo numbers of it's sister wo's
      gvProductsRequired.RefreshData()
      RefreshControls()
    End If
  End Sub

  Private Sub repoProductOption_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoProductOption.ButtonClick

    Dim mProductPicker As clsPickerProductItem
    Dim mProducts As New colProductBaseInfos
    Dim mProductBaseInfo As clsProductBaseInfo
    Dim mPRP As clsProductRequirementProcessor
    Dim mNewProductID As Integer
    Dim mOldProductID As Integer

    Try

      Select Case e.Button.Tag

        Case "Search"
          mProducts = pFormController.GetProductInfos()

          mProductPicker = New clsPickerProductItem(mProducts, pFormController.DBConn, pFormController.RTISGlobal)


          mProductBaseInfo = frmProductPicker.OpenPickerSingle(mProductPicker)

          If mProductBaseInfo IsNot Nothing Then
            mPRP = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)

            If mPRP IsNot Nothing Then

              mPRP.Product = mProductBaseInfo.Product
              mPRP.ProductRequirement.ProductID = mProductBaseInfo.Product.ID
              mPRP.Description = mProductBaseInfo.Product.Description
              mPRP.ProductRequirement.SalesOrderItemID = mPRP.SalesOrderItemID
              mPRP.ProductCode = mProductBaseInfo.Product.Code
              pFormController.SaveProductRequirement(mPRP.ProductRequirement)

              RefreshControls()

            End If

          End If

          gvProductsRequired.RefreshData()
          RefreshControls()

        Case "EditProduct"
          Dim mDialogResult As DialogResult


          mDialogResult = MessageBox.Show("¿Desea editar la información de este producto?", "Edición de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

          If mDialogResult = DialogResult.Yes Then

            mPRP = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)

            If mPRP IsNot Nothing Then


              mNewProductID = frmProductDetail_New.OpenFormModal(mPRP.ProductRequirement.ProductID, pFormController.DBConn)

              If mNewProductID = mPRP.ProductRequirement.ProductID Then
                If mPRP.ProductRequirement.ProductID <> 0 Then
                  pFormController.LoadProductRequirement()
                  RefreshControls()
                End If

              Else
                mOldProductID = mPRP.ProductRequirement.ProductID
                mPRP.ProductRequirement.ProductID = mNewProductID
                pFormController.DeleteOldWorkOrderAllocation(mPRP.WorkOrderAllocationID, mPRP.SalesOrderItemID)
                pFormController.SaveProductRequirement(mPRP.ProductRequirement)
                pFormController.LoadProductRequirement()
                RefreshControls()
              End If



            End If
          End If

        Case "Create"
          Dim mDialogResult As DialogResult

          mDialogResult = MessageBox.Show("¿Desea crear un nuevo producto?", "Creación de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

          If mDialogResult = DialogResult.Yes Then

            mPRP = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)

            If mPRP IsNot Nothing Then


              mNewProductID = frmProductDetail_New.OpenFormModal(0, pFormController.DBConn)
              If mNewProductID <> 0 Then
                mPRP.ProductRequirement.ProductID = mNewProductID
                pFormController.SaveProductRequirement(mPRP.ProductRequirement)

                pFormController.LoadProductRequirement()
                RefreshControls()
              End If


            End If
          End If
      End Select


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub grpProductsRequired_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpProductsRequired.CustomButtonClick
    Dim mProductReqProc As clsProductRequirementProcessor
    Try

      mProductReqProc = TryCast(gvProductsRequired.GetFocusedRow, clsProductRequirementProcessor)

      If mProductReqProc IsNot Nothing Then
        pFormController.RemoveProductRequirement(mProductReqProc.ProductRequirement)
        pFormController.ProductRequirementProcessors.Remove(mProductReqProc)
        pFormController.LoadProductRequirement()
        grdProductsRequired.DataSource = pFormController.ProductRequirementProcessors
        gvProductsRequired.RefreshData()
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub cheIsVAT_CheckedChanged(sender As Object, e As EventArgs) Handles cheIsVAT.CheckedChanged
    pFormController.IsVAT = cheIsVAT.EditValue
  End Sub

  Private Sub grdOrderItem_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdOrderItem.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvOrderItem.MoveNext()
    End If
  End Sub

  Private Sub bbtnViewSummary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnViewSummary.ItemClick
    frmSalesOrderReview.OpenModal(pFormController.SalesOrder, pFormController.DBConn)

  End Sub

  Private Sub dteDateRequiredSO_EditValueChanged(sender As Object, e As EventArgs) Handles dteDateRequiredSO.EditValueChanged


    If pFormController IsNot Nothing Then
      dteFinishDate.EditValue = dteDateRequiredSO.EditValue
    End If
  End Sub
End Class