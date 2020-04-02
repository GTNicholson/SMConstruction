Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB

Public Class frmInvoice
  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pFormController As fccInvoice

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False



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
    Dim mfrm As frmInvoice = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmInvoice
      mfrm.pFormController = New fccInvoice(rDBConn)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub


  Public Shared Sub OpenFormModal(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmInvoice = Nothing

    mfrm = New frmInvoice
    mfrm.pFormController = New fccInvoice(rDBConn)
    mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
    mfrm.ShowDialog()

  End Sub

  Public Shared Function GetNewInvoice(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase) As dmInvoice
    Dim mfrm As frmInvoice = Nothing
    Dim mRetVal As dmInvoice = Nothing
    mfrm = New frmInvoice
    mfrm.pFormController = New fccInvoice(rDBConn)
    mfrm.FormController.PrimaryKeyID = 0
    mfrm.ShowDialog()

    If mfrm.FormController.Invoice.InvoiceID <> 0 Then
      mRetVal = mfrm.pFormController.Invoice
    End If

    Return mRetVal
  End Function

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmInvoice
    Dim mfrmWanted As frmInvoice = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmInvoice
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


  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Public ReadOnly Property FormController As fccInvoice
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmInvoiceDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try


      pFormController.LoadObjects()
      grdSOI.DataSource = pFormController.Invoice.InvoiceItems
      LoadCombos()

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


  Private Sub LoadCombos()
    Try
      'RTIS.Elements.clsDEControlLoading.FillDEComboVIi(cboInvoiceStatus, pFormController.SalesOrder.SalesOrderItems)
      RTIS.Elements.clsDEControlLoading.LoadGridLookUpEditiVI(grdSOI, gcSalesItemID, pFormController.Invoice.SalesOrder.SalesOrderItems)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

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
  End Function

  'Here put the fields
  Private Sub RefreshControls()
    With pFormController.Invoice

      txtInvoiceNo.Text = .InvoiceNo
      txtInvoiceID.Text = .InvoiceID
      dteCreatedDate.EditValue = .CreatedDate
      dteInvoiceDate.EditValue = .InvoiceDate
      txtNetValue.Text = .NetValue
      txtTaxValue.Text = .TaxValue
      cboInvoiceStatus.EditValue = .InvoiceStatus


    End With


    With pFormController.Invoice.SalesOrder
      btneSelectSO.Text = .OrderNo
      txtOrderNo.Text = .OrderNo
      txtProjectName.Text = .ProjectName
      txtCompanyName.Text = .Customer.CompanyName

    End With


  End Sub

  'Change the fields
  Private Sub UpdateObjects()
    With pFormController.Invoice

      .InvoiceNo = txtInvoiceNo.Text
      .SalesOrderID = pFormController.Invoice.SalesOrder.SalesOrderID
      .CreatedDate = dteCreatedDate.EditValue
      .InvoiceDate = dteInvoiceDate.EditValue
      gvSOI.CloseEditor()
      gvSOI.UpdateCurrentRow()
    End With



  End Sub

  Private Sub frmInvoiceDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick

    Try
      UpdateObjects()
      pFormController.SaveObjects()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub

  Private Sub frmInvoiceDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If



  End Sub

  Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
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

  Private Sub frmCustomerDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

  End Sub

  Private Sub btneSelectSO_Click(sender As Object, e As EventArgs) Handles btneSelectSO.Click
    Dim mSOPicker As clsPickerSalesOrder
    Dim mSOs As New colSalesOrders

    pFormController.LoadSalesOrders(mSOs)

    mSOPicker = New clsPickerSalesOrder(mSOs, pFormController.DBConn)

    Dim mSO As dmSalesOrder
    mSO = frmSalesOrderPicker.OpenPickerSingle(mSOPicker)

    If mSO IsNot Nothing Then
      pFormController.Invoice.SalesOrder = mSO
      RefreshControls()

    End If
  End Sub

  Private Sub gpSOI_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gpSOI.CustomButtonClick
    Dim mSOI As dmInvoiceItem
    Try


      Select Case e.Button.Properties.Tag
        Case "Add"
          UpdateObjects()
          pFormController.AddInvoiceSalesOrderItem()

          RefreshControls()
        Case "Delete"
          mSOI = TryCast(gvSOI.GetFocusedRow, dmInvoiceItem)
          If mSOI IsNot Nothing Then
            If MsgBox("Eliminar este Articulo?", vbYesNo) = vbYes Then
              UpdateObjects()
              pFormController.DeleteInvoiceSalesOrderItem(mSOI)
              RefreshControls()
            End If
          End If
      End Select
      gvSOI.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbtnGenerateInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnGenerateInvoice.ItemClick
    If IsNothing(pFormController.Invoice) Then
      MessageBox.Show("No existe dato para generar el documento", "Error al ingresar la información")
      Return
    End If

    Try
      Dim mFilePath As String = String.Empty
      UpdateObjects()

      AddInoviceDocument()
      RefreshControls()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub AddInoviceDocument()
    Dim mValidate As clsValidate
    Dim mReport As repInvoice
    Dim mFilePath As String

    mValidate = pFormController.ValidateObject()
    If mValidate.ValOk Then

      CheckSave(False)

      mReport = GetReport(eDocumentType.Invoice)

      CreateReportPDF(eParentType.Invoice, eDocumentType.Invoice, True, mReport)

      CheckSave(False)

      mFilePath = pFormController.SalesOrder.OutputDocuments.GetFilePath(eParentType.PurchaseOrder, eDocumentType.PurchaseOrder, eFileType.PDF)

      RefreshControls()
      If IO.File.Exists(mFilePath) Then
        frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
      Else
        ViewSalesOrderDocument()
      End If

      mReport.Dispose()
    Else
      MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
    End If

  End Sub
  Public Sub ViewSalesOrderDocument()
    Dim mFilePath As String
    mFilePath = pFormController.Invoice.OutputDocuments.GetFilePath(eParentType.Invoice, eDocumentType.Invoice, eFileType.PDF)

    If IO.File.Exists(mFilePath) Then
      frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
    End If

  End Sub
  Public Function GetReport(ByVal vDocType As eDocumentType) As DevExpress.XtraReports.UI.XtraReport
    Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing

    Select Case vDocType
      Case eDocumentType.Invoice

        If pFormController.Invoice IsNot Nothing Then
          mRetVal = repInvoice.GenerateReport(pFormController.Invoice)
        End If

    End Select

    Return mRetVal
  End Function

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.Invoice.InvoiceID & "_" & pFormController.Invoice.SalesOrderID

    mExportDirectory = IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.InvoiceOrderFileFolderSys, pFormController.Invoice.CreatedDate.Year, clsGeneralA.GetFileSafeName(pFormController.Invoice.InvoiceID.ToString("00000")))

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
      pFormController.CreateInvoiceOrderPack(vReport, mFilePath)

      vReport.Dispose()
      'vReport = Nothing

      pFormController.Invoice.OutputDocuments.SetFilePath(eParentType.Invoice, vDocumentType, eFileType.PDF, mFilePath)

    End If

  End Sub

  Private Sub gvSOI_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvSOI.CustomUnboundColumnData
    Dim mInvoiceItem As dmInvoiceItem
    Dim mSOI As New dmSalesOrderItem
    mInvoiceItem = TryCast(e.Row, dmInvoiceItem)
    If mInvoiceItem IsNot Nothing Then

      Select Case e.Column.Name
        Case gcUnitPrice.Name
          If e.IsGetData Then

            mSOI = pFormController.Invoice.SalesOrder.SalesOrderItems.ItemFromKey(mInvoiceItem.SalesItemID)
            If mSOI IsNot Nothing Then

              e.Value = mSOI.UnitPrice
              mInvoiceItem.UnitPrice = e.Value
            End If
          End If

          If e.IsSetData Then
            pFormController.Invoice.InvoiceItem.UnitPrice = e.Value
          End If

        Case gcTotal.Name
          If e.IsGetData Then
            e.Value = mInvoiceItem.Quantity * mInvoiceItem.UnitPrice
          End If
      End Select
    End If
  End Sub
End Class