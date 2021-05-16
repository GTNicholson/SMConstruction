Imports System.Environment
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmWoodSalesOrder

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pFormController As fccWoodSalesOrder

  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Public ReadOnly Property FormController As fccWoodSalesOrder
    Get
      Return pFormController
    End Get
  End Property

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
    Dim mfrm As frmWoodSalesOrder = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmWoodSalesOrder
      mfrm.pFormController = New fccWoodSalesOrder(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmWoodSalesOrder
    Dim mfrmWanted As frmWoodSalesOrder = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWoodSalesOrder
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
  Private Sub frmWoodSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()
      LoadCombos()
      LoadGrids()

      If mOK Then RefreshControls()
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

  Private Sub RefreshControls()
    Try

      With pFormController.SalesOrder

        If .OrderPhaseType = eOrderPhaseType.SinglePhase Then
          If .SalesOrderPhases IsNot Nothing And .SalesOrderPhases.Count > 0 Then
            With .SalesOrderPhases
              dteFinishedDate.EditValue = .Item(0).DateRequired

            End With
          End If

        End If

        lblSalesOrderID.Text = "ID: " & .SalesOrderID.ToString("0000")
        txtSalesOrderID.Text = .OrderNo

        txtVisibleNotes.Text = .VisibleNotes
        btneSalesOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)
        txtCustomerContact.Text = .CustomerContactID

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
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboProjectOwner, .ContractManagerID)


        If .Customer Is Nothing Then
          btnedCustomer.Text = ""
        Else
          FillCustomerDetail()

        End If





      End With

      ''LoadOrderPhases()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub FillCustomerDetail()

    Try
      With pFormController.SalesOrder
        btnedCustomer.Text = .Customer.CompanyName
        txtAccountRef.Text = .Customer.AccountRef
        txtMainTown.Text = .Customer.MainTown
        txtPaymentTermsType.Text = .Customer.PaymentTermsType
        txtSalesAreaID.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country).ItemValueToDisplayValue(.Customer.SalesAreaID)
        txtPaymentTermsType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType).ItemValueToDisplayValue(.Customer.PaymentTermsType)

        CustomerStatusID.Text = clsEnumsConstants.GetEnumDescription(GetType(eCustomerStatus), CType(.Customer.CustomerStatusID, eCustomerStatus))


      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub LoadGrids()
    grdSalesOrderItems.DataSource = pFormController.SalesOrder.SalesOrderItems

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub


  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    ''RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboOrderTypeID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.OrderType))

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eOrderType))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboProjectOwner, mVIs)

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboEstatusENUM, mVIs)

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eOrderType))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboOrderTypeID, mVIs)
  End Sub


  Private Sub bbtnAddStockItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnAddStockItem.ItemClick
    Dim mPicker As clsPickerWoodPallet
    Dim mListWPIToCreateSI As New colWoodPalletItems
    pFormController.LoadDataRef()
    pFormController.SaveObjects()


    mPicker = New clsPickerWoodPallet(pFormController.WoodPallets, pFormController.DBConn, 0, True)
    frmWoodPalletPicker.OpenPickerSingle(mPicker)

    If mPicker.SelectedObjects IsNot Nothing Then
      If mPicker.SelectedObjects(0) IsNot Nothing Then
        pFormController.CurrentWooodPallet = mPicker.SelectedObjects(0)


        pFormController.CreateSalesItems(mPicker.SelectedObjects)




      End If




    End If
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

          End If
          RefreshControls()
        Case ButtonPredefines.Ellipsis
          frmCustomerDetail.OpenFormModal(pFormController.SalesOrder.CustomerID, pFormController.DBConn)
          If pFormController.SalesOrder.CustomerID <> 0 Then
            pFormController.ReloadCustomer()
            FillCustomerDetail()

          End If
          RefreshControls()
      End Select

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub UpdateObjects()

    If pFormController.SalesOrder IsNot Nothing Then

      With pFormController.SalesOrder


        .OrderNo = txtSalesOrderID.Text
        .FinishDate = dteFinishedDate.DateTime

        .VisibleNotes = txtVisibleNotes.Text
        .OrderTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboOrderTypeID)
        .OrderStatusENUM = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboEstatusENUM)
        .EstimatorEmployeeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboProjectOwner)
        .ContractManagerID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboProjectOwner)
        .WoodPalletID = pFormController.CurrentWooodPallet.WoodPalletID

        gvSalesOrderItems.CloseEditor()
        gvSalesOrderItems.UpdateCurrentRow()

      End With

    End If
  End Sub

  Private Sub barbtnSaveExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSaveExit.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSave.ItemClick
    Try

      UpdateObjects()
      pFormController.SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub barbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnClose.ItemClick
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

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean
    RefreshControls()

    UpdateObjects()

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


  End Function

End Class