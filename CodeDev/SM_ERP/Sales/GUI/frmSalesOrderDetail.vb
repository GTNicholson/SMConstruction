Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
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

  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmSalesOrderDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmSalesOrderDetail
      mfrm.pFormController = New fccSalesOrderDetail(rDBConn)
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
      grdWorkOrders.DataSource = pFormController.SalesOrder.WorkOrders
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
      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
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
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboOrderTypeID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.OrderType))
    mVIs = clsEnumsConstants.EnumToVIs(GetType(eSalesOrderstatus))
    RTIS.Elements.clsDEControlLoading.FillDEComboVI(cboEstatusENUM, mVIs)
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
        btneSalesOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.SalesOrder, eDocumentType.SalesOrder, eFileType.PDF)


        RTIS.Elements.clsDEControlLoading.SetDECombo(cboOrderTypeID, .OrderTypeID)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboEstatusENUM, .OrderStatusENUM)



        If .Customer Is Nothing Then
          btnedCustomer.Text = ""
        Else
          FillCustomerDetail()

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
      .OrderTypeID = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboOrderTypeID)
      .OrderStatusENUM = RTIS.Elements.clsDEControlLoading.GetDEComboValue(cboEstatusENUM)
      gvWorkOrders.CloseEditor()
      gvWorkOrders.UpdateCurrentRow()



    End With
  End Sub

  Private Sub btnedCustomer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnedCustomer.ButtonClick
    Try
      Dim mCustomerPicker As clsPickerCustomer
      Dim mcustomer As dmCustomer
      UpdateObjects()
      mCustomerPicker = New clsPickerCustomer(pFormController.GetCustomerList)
      mcustomer = frmPickerCustomer.OpenPickerSingle(mCustomerPicker)
      If mcustomer Is Nothing Then
        pFormController.SalesOrder.CustomerID = 0
        pFormController.SalesOrder.Customer = Nothing
      Else
        pFormController.SalesOrder.CustomerID = mcustomer.CustomerID
        pFormController.SalesOrder.Customer = mcustomer
        FillCustomerDetail()

      End If
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
        txtPaymentTermsType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Tenders).ItemValueToDisplayValue(.Customer.PaymentTermsType)

        'CustomerStatusID.Text = clsEnumsConstants.EnumToVIs(GetType(eCustomerStatus)).ItemValueToDisplayValue(.Customer.CustomerStatusID)
        CustomerStatusID.Text = clsEnumsConstants.GetEnumDescription(GetType(eCustomerStatus), CType(.Customer.CustomerStatusID, eCustomerStatus))

        'CustomerStatusID.Text = .Customer.CustomerStatusID

      End With

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub grpWorkOrders_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWorkOrders.CustomButtonClick
    Dim mWO As dmWorkOrder
    Select Case e.Button.Properties.Tag
      Case eWorkOrderGroupButtonTags.Add
        pFormController.AddWorkOrder(eProductType.ProductFurniture)
      Case eWorkOrderGroupButtonTags.Delete
        mWO = TryCast(gvWorkOrders.GetFocusedRow, dmWorkOrder)
        If mWO IsNot Nothing Then
          If MsgBox("Eliminar este Orden de Trabajo?", vbYesNo) = vbYes Then
            pFormController.DeleteWorkOrder(mWO)
          End If
        End If
    End Select
    gvWorkOrders.RefreshData()
  End Sub

  Private Sub repitbtWorkOrder_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repitbtWorkOrder.ButtonClick
    Dim mWO As dmWorkOrder
    Try
      mWO = TryCast(gvWorkOrders.GetFocusedRow, dmWorkOrder)
      If mWO IsNot Nothing Then
        frmWorkOrderDetail.OpenFormModal(mWO.WorkOrderID, pFormController.DBConn, AppRTISGlobal.GetInstance)
      End If
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
    pFormController.SaveObjects()
    If pFormController.IsDirty() Then
      If rOption Then
        mResponse = MsgBox("Changes have been made. Do you wish to save them?", MsgBoxStyle.YesNoCancel)
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
      ''Dim mValidate As clsValidate
      ''mValidate = pFormController.ValidateObject
      ''If mValidate.ValOk Then
      pFormController.SaveObjects()
      ''Else
      '' MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
      ''mRetVal = False
      ''End If
    End If
    CheckSave = mRetVal
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
      '  End If
    Else
      MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
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
      If vOverride = False Then If MsgBox("Please confirm you wish to recreate the PDF", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
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
End Class