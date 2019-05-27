Imports DevExpress.XtraBars
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmWorkOrderDetail
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Private pIsActive As Boolean

  Private pFormController As fccWorkOrderDetail

  Public ExitMode As Windows.Forms.DialogResult

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
    Dim mfrm As frmWorkOrderDetail = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderDetail
      mfrm.pFormController = New fccWorkOrderDetail(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmWorkOrderDetail
    Dim mfrmWanted As frmWorkOrderDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWorkOrderDetail
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

  Public ReadOnly Property FormController As fccWorkOrderDetail
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmWorkOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pIsActive = False
    pFormController.LoadObjects()

    LoadCombos()

    grdTimeSheetEntries.DataSource = pFormController.TimeSheetEntrys
    RefreshProductTabPages()
    RefreshControls()
    pIsActive = True
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()

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
            ExitMode = Windows.Forms.DialogResult.No
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
        mRetVal = pFormController.SaveObjects()
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  Private Sub LoadCombos()
    Dim mVIs As colValueItems
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eProductType))
    clsDEControlLoading.FillDEComboVI(cboProductType, mVIs)
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcTSArea, mVIs)
    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcTSEmployee, mVIs)
  End Sub

  Private Sub RefreshProductTabPages()
    tabProductSpec.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
    For mLoop = tabProductSpec.TabPages.Count - 1 To 0 Step -1
      If tabProductSpec.TabPages(mLoop).Tag <> pFormController.WorkOrder.ProductTypeID Then
        tabProductSpec.TabPages(mLoop).PageVisible = False
      End If
    Next
  End Sub

  Private Sub RefreshControls()
    Dim mIsActive As Boolean
    mIsActive = pIsActive

    With pFormController.WorkOrder
      If .WorkOrderNo = "" Then
        Me.Text = "O.T. Nuevo"
      Else
        Me.Text = "O.T. " & .WorkOrderNo
      End If
      btnWorkOrderNumber.EditValue = .WorkOrderNo
      txtDescription.Text = .Description

      clsDEControlLoading.SetDECombo(cboProductType, .ProductTypeID)

      RefreshProductControls()

    End With
    pIsActive = mIsActive
  End Sub

  Private Sub RefreshProductControls()
    Select Case pFormController.WorkOrder.ProductTypeID
      Case eProductType.ProductFurniture
        RefreshProductControlsFurniture()
    End Select
  End Sub

  Private Sub RefreshProductControlsFurniture()
    Dim mPF As dmProductFurniture
    mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)
    If mPF IsNot Nothing Then
      With mPF
        memPFNotes.EditValue = .Notes
      End With
    End If
  End Sub

  Private Sub UpdateObject()
    With pFormController.WorkOrder
      .Description = txtDescription.Text
    End With
    UpdateProductControls()
  End Sub

  Private Sub UpdateProductControls()
    Select Case pFormController.WorkOrder.ProductTypeID
      Case eProductType.ProductFurniture
        UpdateProductControlsFurniture()
    End Select
  End Sub

  Private Sub UpdateProductControlsFurniture()
    Dim mPF As dmProductFurniture
    mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)
    If mPF IsNot Nothing Then
      With mPF
        .Notes = memPFNotes.Text
      End With
    End If
  End Sub

  Private Sub frmWorkOrderDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub btneWorkOrderDocument_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btneWorkOrderDocument.ButtonClick
    Try
      Dim mFilePath As String = String.Empty
      UpdateObject()
      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
          AddWorkOrderDocument()

        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete
          DeleteWorkOrderDocument()
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis
          ViewWorkOrderDocument()
      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Public Sub AddWorkOrderDocument()
    Dim mValidate As clsValidate
    Dim mReport As repWorkOrderDoc
    Dim mFilePath As String

    mValidate = pFormController.ValidateObject()
    If mValidate.ValOk Then

      CheckSave(False)

      mReport = GetReport(eDocumentType.WorkOrderDoc)

      CreateReportPDF(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, True, mReport)

      CheckSave(False)

      mFilePath = pFormController.WorkOrder.OutputDocuments.GetFilePath(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

      RefreshControls()
      If IO.File.Exists(mFilePath) Then
        frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
      End If
      '  End If
    Else
      MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
    End If

  End Sub

  Public Sub DeleteWorkOrderDocument()

    pFormController.WorkOrder.OutputDocuments.DeleteOutputDoc(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

    RefreshControls()
  End Sub

  Public Sub ViewWorkOrderDocument()
    Dim mFilePath As String
    mFilePath = pFormController.WorkOrder.OutputDocuments.GetFilePath(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

    If IO.File.Exists(mFilePath) Then
      frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
    End If

  End Sub

  Public Function GetReport(ByVal vDocType As eDocumentType) As DevExpress.XtraReports.UI.XtraReport
    Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing

    Select Case vDocType
      Case eDocumentType.WorkOrderDoc

        If pFormController.WorkOrder IsNot Nothing Then
          mRetVal = repWorkOrderDoc.GenerateReport(pFormController.WorkOrder)
        End If

    End Select

    Return mRetVal
  End Function

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport
    Dim mExportOptions As DevExpress.XtraPrinting.PdfExportOptions

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.WorkOrder.WorkOrderID

    mExportDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolder, pFormController.WorkOrder.DateCreated.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderNo))

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
      mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
      mExportOptions.ConvertImagesToJpeg = False

      vReport.ExportToPdf(mFilePath, mExportOptions)


      vReport.Dispose()
      'vReport = Nothing

      pFormController.WorkOrder.OutputDocuments.SetFilePath(eParentType.WorkOrder, vDocumentType, eFileType.PDF, mFilePath)

    End If

  End Sub

  Private Sub btnWorkOrderNumber_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnWorkOrderNumber.ButtonClick
    pFormController.RaiseWorkOrderNo()
    RefreshControls()
  End Sub

  Private Sub bbtnSave_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try
      UpdateObject()
      CheckSave(False)
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub cboProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductType.SelectedIndexChanged
    Try
      If pIsActive Then
        UpdateObject()
        pFormController.SetProductType(clsDEControlLoading.GetDEComboValue(cboProductType))
        RefreshProductTabPages()
        RefreshControls()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class