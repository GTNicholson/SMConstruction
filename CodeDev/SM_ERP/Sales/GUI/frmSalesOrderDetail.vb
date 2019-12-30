Imports System.Environment
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB

Public Class frmSalesOrderDetail
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pFormController As fccSalesOrderDetail

  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


  Private Enum eOrderItemGroupButtonTags
    Add = 1
    Delete = 2
  End Enum

  Private Enum eWorkOrderGroupButtonTags
    Add = 1
    Delete = 2
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
    Dim mfrm As frmSalesOrderDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmSalesOrderDetail
      mfrm.pFormController = New fccSalesOrderDetail(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmSalesOrderDetail
    Dim mfrmWanted As frmSalesOrderDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmSalesOrderDetail
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

  Public ReadOnly Property FormController As fccSalesOrderDetail
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
      grdOrderItem.DataSource = pFormController.SalesOrder.SalesOrderItems
      grdWorkOrders.DataSource = pFormController.SOWorkOrders
      LoadCombos()
      RefreshControls()
      If mOK Then RefreshControls()

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

    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboEstatusENUM, mVIs)

    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboSalesDelAreaID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboContractManagerID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees))

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodSpecie)
    RTIS.Elements.clsDEControlLoading.LoadGridLookUpEditiVI(grdOrderItem, gcWoodSpecie, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodFinish)
    RTIS.Elements.clsDEControlLoading.LoadGridLookUpEditiVI(grdOrderItem, gcWoodFinish, mVIs)

    LoadCustomerContactCombo()

  End Sub
  Private Sub LoadCustomerContactCombo()

    If pFormController.SalesOrder.Customer IsNot Nothing Then
      RTIS.Elements.clsDEControlLoading.FillDEComboVIi(cboCustomerDelContacID, pFormController.SalesOrder.Customer.CustomerContacts)
    End If
  End Sub



  Private Sub RefreshControls()
    Try

      With pFormController.SalesOrder
        lblSalesOrderID.Text = "ID: " & .SalesOrderID.ToString("0000")
        txtSalesOrderID.Text = .OrderNo
        txtProjectName.Text = .ProjectName
        'dteDateEntered.EditValue = .DateEntered
        dteDateEntered.EditValue = clsGeneralA.DateToDBValue(.DateEntered)
        dteFinishDate.EditValue = clsGeneralA.DateToDBValue(.FinishDate)
        dteDueTime.EditValue = clsGeneralA.DateToDBValue(.DueTime)
        txtVisibleNotes.Text = .VisibleNotes
        txtDelAddress1.Text = .DelAddress1
        btneSalesOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)
        txtDelAddress2.Text = .DelAddress2
        txtCustomerContact.Text = .CustomerContactID
        txtShippingCost.Text = .ShippingCost
        txtVersion.Text = .Version
        btnePodio.EditValue = .PodioPath

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
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboContractManagerID, .ContractManagerID)

        If .Customer Is Nothing Then
          btnedCustomer.Text = ""
        Else
          FillCustomerDetail()

        End If

        If pFormController.SalesOrder.WorkOrdersIssued Then
          For Each mbtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpWorkOrders.CustomHeaderButtons
            Select Case Val(mbtn.Tag)
              Case 1
                mbtn.Visible = False
              Case 0
                mbtn.Visible = True
            End Select
          Next
        Else
          For Each mbtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpWorkOrders.CustomHeaderButtons
            Select Case Val(mbtn.Tag)
              Case 1
                mbtn.Visible = True
              Case 0
                mbtn.Visible = False
            End Select
          Next
        End If

      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub



  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try

      UpdateObjects()
      pFormController.SaveObjects()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try



  End Sub

  Private Sub UpdateObjects()
    With pFormController.SalesOrder
      .OrderNo = txtSalesOrderID.Text
      .ProjectName = txtProjectName.Text
      .DateEntered = dteDateEntered.DateTime
      .DueTime = dteDueTime.DateTime
      .FinishDate = dteFinishDate.DateTime
      .VisibleNotes = txtVisibleNotes.Text
      .DelAddress1 = txtDelAddress1.Text
      .DelAddress2 = txtDelAddress2.Text
      .OrderTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboOrderTypeID)
      .OrderStatusENUM = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboEstatusENUM)
      .SalesDelAreaID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboSalesDelAreaID)
      .CustomerDelContactID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboCustomerDelContacID)
      .ContractManagerID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboContractManagerID)
      .ShippingCost = txtShippingCost.Text
      .Version = txtVersion.Text
      .PodioPath = btnePodio.EditValue
      gvOrderItem.CloseEditor()
      gvOrderItem.UpdateCurrentRow()

      gvWorkOrders.CloseEditor()
      gvWorkOrders.UpdateCurrentRow()



    End With
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
        txtAccountRef.Text = .Customer.AccountRef
        txtMainTown.Text = .Customer.MainTown
        txtPaymentTermsType.Text = .Customer.PaymentTermsType
        'txtSalesAreaID.Text = .Customer.SalesAreaID
        txtSalesAreaID.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Country).ItemValueToDisplayValue(.Customer.SalesAreaID)
        txtPaymentTermsType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType).ItemValueToDisplayValue(.Customer.PaymentTermsType)

        'CustomerStatusID.Text = clsEnumsConstants.EnumToVIs(GetType(eCustomerStatus)).ItemValueToDisplayValue(.Customer.CustomerStatusID)
        CustomerStatusID.Text = clsEnumsConstants.GetEnumDescription(GetType(eCustomerStatus), CType(.Customer.CustomerStatusID, eCustomerStatus))

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
    Dim mWOI As clsWorkOrderInfo
    Try
      Select Case e.Button.Kind
        Case ButtonPredefines.Ellipsis
          mWOI = TryCast(gvWorkOrders.GetFocusedRow, clsWorkOrderInfo)
          If mWOI IsNot Nothing Then
            UpdateObjects()
            pFormController.SaveObjects()
            frmWorkOrderDetail.OpenFormModalWithObjects(mWOI.WorkOrder, pFormController.SalesOrder, pFormController.DBConn, AppRTISGlobal.GetInstance, False)
            '// in one work order form it is possible
            pFormController.RefreshWorkOrderNos(mWOI.WorkOrder.ParentSalesOrderItem)
            RefreshControls()
          End If
          gvWorkOrders.RefreshData()
        Case ButtonPredefines.Plus
          Dim mWOSOI As dmSalesOrderItem = Nothing
          If MsgBox("Agregar un OT addicional por este articulo?", vbYesNo) = vbYes Then
            mWOI = TryCast(gvWorkOrders.GetFocusedRow, clsWorkOrderInfo)
            mWOSOI = mWOI.WorkOrder.ParentSalesOrderItem
            If mWOSOI IsNot Nothing Then
              pFormController.AddWorkOrder(mWOSOI, eProductType.ProductFurniture)
              pFormController.RefreshSOWorkOrders()
              gvWorkOrders.RefreshData()
            End If
            '// in one work order form it is possible to affect the wo numbers of it's sister wo's
            pFormController.RefreshWorkOrderNos(mWOSOI)
            gvWorkOrders.RefreshData()
            RefreshControls()
          End If
        Case ButtonPredefines.Delete
          Dim mWOSOI As dmSalesOrderItem = Nothing
          mWOI = TryCast(gvWorkOrders.GetFocusedRow, clsWorkOrderInfo)
          mWOSOI = mWOI.WorkOrder.ParentSalesOrderItem
          If mWOSOI.WorkOrders.Count <= 1 Then
            MsgBox("No se puede eliminar el ultimo O.T por un articulo")
          Else
            If MsgBox("Eliminar este Orden de Trabajo?", vbYesNo) = vbYes Then
              mWOSOI.WorkOrders.Remove(mWOI.WorkOrder)
              pFormController.RefreshSOWorkOrders()
              gvWorkOrders.RefreshData()
              RefreshControls()
            End If
          End If

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
    FormController.ClearObjects()
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
    If IsNothing(pFormController.SalesOrder.Customer) Then
      MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
      Return
    End If

    Try
      Dim mFilePath As String = String.Empty
      UpdateObjects()
      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
          AddSalesOrderDocument()
          RefreshControls()
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete
          DeleteSalesOrderDocument()
          RefreshControls()
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis
          ViewSalesOrderDocument()
          RefreshControls()
      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub AddSalesOrderDocument()
    Dim mValidate As clsValidate
    Dim mReport As repSalesOrder
    Dim mFilePath As String

    mValidate = pFormController.ValidateObject()
    If mValidate.ValOk Then

      CheckSave(False)

      mReport = GetReport(eDocumentType.SalesOrder)

      CreateReportPDF(eParentType.SalesOrder, eDocumentType.SalesOrder, True, mReport)

      CheckSave(False)

      mFilePath = pFormController.SalesOrder.OutputDocuments.GetFilePath(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)

      RefreshControls()
      If IO.File.Exists(mFilePath) Then
        frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
      End If
      mReport.ClearImages
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

  Public Function GetReport(ByVal vDocType As eDocumentType) As DevExpress.XtraReports.UI.XtraReport
    Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing
    Dim mWOs As New colSalesOrders

    Select Case vDocType
      Case eDocumentType.SalesOrder

        If pFormController.SalesOrder IsNot Nothing Then
          mRetVal = repSalesOrder.GenerateReport(pFormController.SalesOrder)
        End If

    End Select

    Return mRetVal
  End Function

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.SalesOrder.SalesOrderID

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

      pFormController.SalesOrder.OutputDocuments.SetFilePath(eParentType.SalesOrder, vDocumentType, eFileType.PDF, mFilePath)

    End If

  End Sub

  Private Sub btnedCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles btnedCustomer.EditValueChanged

  End Sub

  Private Sub grpOrderItem_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpOrderItem.CustomButtonClick
    Dim mSOI As dmSalesOrderItem
    Try


      Select Case e.Button.Properties.Tag
        Case eOrderItemGroupButtonTags.Add
          UpdateObjects()
          pFormController.AddSalesOrderItem(eProductType.ProductFurniture)
          pFormController.RefreshSOWorkOrders()
          gvWorkOrders.RefreshData()
          RefreshControls()
        Case eOrderItemGroupButtonTags.Delete
          mSOI = TryCast(gvOrderItem.GetFocusedRow, dmSalesOrderItem)
          If mSOI IsNot Nothing Then
            If MsgBox("Eliminar este Articulo?", vbYesNo) = vbYes Then
              UpdateObjects()
              pFormController.DeleteSalesOrderItem(mSOI)
              pFormController.RefreshSOWorkOrders()
              gvWorkOrders.RefreshData()
              RefreshControls()
            End If
          End If
      End Select
      gvWorkOrders.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvWorkOrders_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWorkOrders.CustomUnboundColumnData
    Dim mWOI As clsWorkOrderInfo
    Dim mFound As Boolean = False
    Select Case e.Column.Name
      Case "gcWOSOItemNumber"
        If e.IsGetData Then
          mWOI = TryCast(e.Row, clsWorkOrderInfo)
          If mWOI IsNot Nothing Then
            e.Value = mWOI.WorkOrder.ParentSalesOrderItem.ItemNumber
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

  Private Sub grpWorkOrders_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWorkOrders.CustomButtonClick
    Dim mSOI As dmSalesOrderItem
    Try
      Dim mResult = New MsgBoxResult

      Select Case Val(e.Button.Properties.Tag)
        Case 1
          mResult = MsgBox("¿Está seguro que desea generar los números de OT?")
          If mResult = MsgBoxResult.Ok Then
            pFormController.GenerateWorkOrders()
          End If

        Case 0
          mResult = MsgBox("¿Está seguro que desea limpiar los números de OT?")
          If mResult = MsgBoxResult.Ok Then
            pFormController.RecallWorkOrders()
          End If

      End Select
      gvWorkOrders.RefreshData()
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

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
    gvWorkOrders.RefreshData()
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
End Class