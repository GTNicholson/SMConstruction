Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmWorkOrderDetail
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pForceExit As Boolean = False
  Private pLoadError As Boolean
  Private pIsActive As Boolean
  Private pFormController As fccWorkOrderDetail
  Public ExitMode As Windows.Forms.DialogResult
  Public pSOI As dmSalesOrderItem

  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)
    pSOI = New dmSalesOrderItem()
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

  Public Shared Sub OpenFormModalWithObjects(ByRef rWorkOrder As dmWorkOrder, ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmWorkOrderDetail = Nothing


    mfrm = New frmWorkOrderDetail
    mfrm.pFormController = New fccWorkOrderDetail(rDBConn, rRTISGlobal)
    mfrm.pFormController.WorkOrder = rWorkOrder
    mfrm.pFormController.SalesOrder = rSalesOrder
    mfrm.FormController.PrimaryKeyID = rWorkOrder.WorkOrderID
    ''mfrm.ParentForm = rParent
    mfrm.ShowDialog()

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
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required
    pLoadError = False
    pIsActive = False

    Try

      pFormController.LoadObjects()
      ConfigureFileControl()
      LoadCombos()
      grdWorkOrderBatches.DataSource = pFormController.WorkOrder.WorkOrderBatches
      grdTimeSheetEntries.DataSource = pFormController.TimeSheetEntrys
      RefreshProductTabPages()
      RefreshControls()
      pIsActive = True

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

  Private Sub ConfigureFileControl()
    Dim mFileDirectory As String
    mFileDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderUsr, pFormController.SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))

    UctFileControl1.UserController = New uccFileControl(Me)
    UctFileControl1.UserController.Directory = mFileDirectory
    UctFileControl1.UserController.FileTrackers = pFormController.WorkOrder.WOFiles
    UctFileControl1.UserController.ConfigSystemWatcher()

  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()

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
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  Private Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eProductType))
    clsDEControlLoading.FillDEComboVI(cboProductType, mVIs)


    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees)
    clsDEControlLoading.FillDEComboVI(cboEmployee, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.FurnitureCategory)
    clsDEControlLoading.FillDEComboVI(cboFurnitureCategory, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Material)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirements, gcMaterialTypeID, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodSpecie)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirements, gcWoodSpecie, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Quality)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirements, gcQuality, mVIs)


    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcAreaID, mVIs)

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcTSArea, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcTSEmployee, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodFinish)
    clsDEControlLoading.FillDEComboVI(cboWoodFinish, mVIs)

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
      lblWorkOrderID.Text = "ID:" & .WorkOrderID.ToString("00000")
      If .WorkOrderNo = "" Then
        Me.Text = "O.T. Nuevo"
      Else
        Me.Text = "O.T. " & .WorkOrderNo
      End If

      txtQtyPerSalesItem.Text = .QtyPerSalesItem

      'txtQuantity.Text = .Quantity

      btnWorkOrderNumber.EditValue = .WorkOrderNo
      txtDescription.Text = .Description

      dtePlannedStartDate.DateTime = .PlannedStartDate

      clsDEControlLoading.SetDECombo(cboProductType, .ProductTypeID)
      clsDEControlLoading.SetDECombo(cboWoodFinish, .WoodFinish)
      clsDEControlLoading.SetDECombo(cboFurnitureCategory, .FurnitureCategoryID)
      clsDEControlLoading.SetDECombo(cboEmployee, .EmployeeID)


      ceMaquinado.Checked = .Machining
      ceCostura.Checked = .Upholstery
      ceEnsamble.Checked = .Assembley
      ceLija.Checked = .Sanding
      ceMetal.Checked = .MetalWork
      ceSub.Checked = .SubContract
      cePintura.Checked = .Painting

      btneWorkOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

      bteImage.Text = .ImageFile

      UctFileControl1.LoadControls()
      UctFileControl1.RefreshControls()
      RefreshProductControls()
      RefreshSalesControls()

    End With

    With pFormController.SalesOrderItem
      txtPrice.Text = .UnitPrice
    End With


    pIsActive = mIsActive
  End Sub

  Private Sub RefreshSalesControls()
    With pFormController.SalesOrder
      txtSalesOrderID.Text = .OrderNo
      txtProjectName.Text = .ProjectName
      txtDueTime.Text = .DueTime
      If .Customer IsNot Nothing Then
        txtCompanyName.Text = .Customer.CompanyName
      End If
    End With
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

        grdMaterialRequirements.DataSource = mPF.MaterialRequirments
        grdMaterialRequirementOthers.DataSource = mPF.MaterialRequirmentOthers

      End With
    End If
  End Sub

  Private Sub UpdateObject()

    Dim mActiveControl As Control = Me.ActiveControl
    lblWorkOrderID.Focus()
    If mActiveControl IsNot Nothing Then
      mActiveControl.Focus()
    End If


    With pFormController.WorkOrder
      ''.Quantity = txtQuantity.Text
      .Description = txtDescription.Text.ToUpper

      .PlannedStartDate = dtePlannedStartDate.DateTime
      .UnitPrice = Val(txtPrice.Text)

      .WoodFinish = clsDEControlLoading.GetDEComboValue(cboWoodFinish)
      .FurnitureCategoryID = clsDEControlLoading.GetDEComboValue(cboFurnitureCategory)
      .EmployeeID = clsDEControlLoading.GetDEComboValue(cboEmployee)

      .WorkcentreID = getCheckValue()

      .Machining = ceMaquinado.Checked
      .Upholstery = ceCostura.Checked
      .Assembley = ceEnsamble.Checked
      .Sanding = ceLija.Checked
      .MetalWork = ceMetal.Checked
      .SubContract = ceSub.Checked
      .Painting = cePintura.Checked

    End With
    UpdateProductControls()
  End Sub


  Private Function getCheckValue() As Int32
    Dim mVal As Int32



    Return mVal
  End Function
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
        .Notes = memPFNotes.Text.ToUpper
      End With
    End If
  End Sub

  Private Sub frmWorkOrderDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub btneWorkOrderDocument_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btneWorkOrderDocument.ButtonClick

    If IsNothing(pFormController.SalesOrder.Customer) Then
      MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
      Return

    End If
    Try
      Dim mFilePath As String = String.Empty
      UpdateObject()
      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
          AddWorkOrderDocument()
          RefreshControls()
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete
          DeleteWorkOrderDocument()
          RefreshControls()
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
    Dim mReportMRP As repWorkOrderMatReqsWood
    Dim mOtherMaterialReport As repOtherMaterials
    Dim mFilePath As String
    Dim mRepMerge As New DevExpress.XtraReports.UI.XtraReport

    Dim mMatReqInfos As New colMaterialRequirementInfos

    If IsNothing(pFormController.SalesOrder.Customer) Then
      MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
      Return
    End If


    'Dim mMatReqInfos As New colMaterialRequirementInfos



    mValidate = pFormController.ValidateObject()
    If mValidate.ValOk Then

      CheckSave(False)

      mReport = GetReport(eDocumentType.WorkOrderDoc)

      For Each mRepPage As DevExpress.XtraPrinting.Page In mReport.Pages
        mRepMerge.Pages.Add(mRepPage)
      Next

      ''Creating Wood Requirements Report
      mMatReqInfos = pFormController.GetMaterialRequirementInfos
      mReportMRP = repWorkOrderMatReqsWood.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos)

      For Each mRepPage As DevExpress.XtraPrinting.Page In mReportMRP.Pages
        mRepMerge.Pages.Add(mRepPage)
      Next

      ''Creating Other Materials Report
      mMatReqInfos = pFormController.GetMaterialRequirementOtherInfos
      mOtherMaterialReport = repOtherMaterials.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos)

      For Each mRepPage As DevExpress.XtraPrinting.Page In mOtherMaterialReport.Pages
        mRepMerge.Pages.Add(mRepPage)
      Next

      CreateReportPDF(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, True, mRepMerge)

      CheckSave(False)

      mFilePath = pFormController.WorkOrder.OutputDocuments.GetFilePath(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

      RefreshControls()
      If IO.File.Exists(mFilePath) Then
        frmPDFViewer.OpenFormAsModal(Me.ParentForm, mFilePath)
      End If
      '  End If
    Else
      MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
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
          mRetVal = repWorkOrderDoc.GenerateReport(pFormController.WorkOrder, pFormController.SalesOrder)
        End If

    End Select

    Return mRetVal
  End Function

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.WorkOrder.WorkOrderID

    mExportDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, pFormController.SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))

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
      pFormController.CreateWorkOrderPack(vReport, mFilePath)

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

  Private Sub btnSaveAndClose_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnClose_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btneWorkOrderDocument_EditValueChanged(sender As Object, e As EventArgs) Handles btneWorkOrderDocument.EditValueChanged

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

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub frmWorkOrderDetail_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    Dim mMatReqInfos As New colMaterialRequirementInfos
    If IsNothing(pFormController.SalesOrder.Customer) Then
      MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
      Return
    End If

    mMatReqInfos = pFormController.GetMaterialRequirementInfos
    repWorkOrderMatReqsWood.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos)

  End Sub

  Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
    Dim mMatReqInfos As New colMaterialRequirementInfos

    If IsNothing(pFormController.SalesOrder.Customer) Then
      MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
      Return
    End If

    mMatReqInfos = pFormController.GetMaterialRequirementOtherInfos
    repOtherMaterials.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos)
  End Sub

  Private Sub bteImage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteImage.ButtonClick
    Try
      Dim mFileName As String = ""
      If RTIS.CommonVB.clsGeneralA.GetOpenFileName(mFileName, "Selecionar Imagen") = DialogResult.OK Then
        If pFormController.CreateWOImageFile(mFileName) = False Then
          MsgBox("¡No Funcionó!")
        End If
      End If
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvWorkOrderBatches_RowCountChanged(sender As Object, e As EventArgs) Handles gvWorkOrderBatches.RowCountChanged
    Try
      Dim mWOH As clsWorkOrderHandler
      mWOH = New clsWorkOrderHandler(pFormController.WorkOrder)
      mWOH.AssignWOBatchRefs()
      txtQuantity.Text = pFormController.WorkOrder.Quantity

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvWorkOrderBatches_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles gvWorkOrderBatches.ValidateRow
    Try
      Dim mWOH As clsWorkOrderHandler
      mWOH = New clsWorkOrderHandler(pFormController.WorkOrder)
      txtQuantity.Text = pFormController.WorkOrder.Quantity

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmWorkOrderDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

  End Sub

  Private Sub frmWorkOrderDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

  End Sub

  Private Sub txtQtyPerSalesItem_Validated(sender As Object, e As EventArgs) Handles txtQtyPerSalesItem.Validated
    pFormController.UpdateWorkOrderQtyPerSalesItem(Val(txtQtyPerSalesItem.Text))
    'RefreshControls()
    UpdateObject()

  End Sub

  Private Sub gvMaterialRequirements_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvMaterialRequirements.CustomUnboundColumnData
    Dim mMatReq As dmMaterialRequirement

    mMatReq = TryCast(e.Row, dmMaterialRequirement)
    If mMatReq IsNot Nothing Then
      Select Case e.Column.Name
        Case gcTotalQuantity.Name
          If e.IsGetData Then
            e.Value = mMatReq.UnitPiece * pFormController.WorkOrder.Quantity
          End If
        Case gcQtyBoardFeet.Name
          Dim mValue As Decimal
          Dim mQty As Integer
          If e.IsGetData Then
            mQty = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity)
            mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)
            mValue = mValue
            e.Value = mValue
          End If
      End Select
    End If
  End Sub
End Class