﻿Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock

Public Class frmWorkOrderDetail
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pForceExit As Boolean = False
  Private pLoadError As Boolean
  Private pIsActive As Boolean
  Private pFormController As fccWorkOrderDetail
  Public ExitMode As Windows.Forms.DialogResult
  Public IsInternal As New Boolean
  Public pSOI As dmSalesOrderItem
  Public pDBCon As RTIS.DataLayer.clsDBConnBase
  Public pAppRTISGlobal As AppRTISGlobal

  Private Enum eMaterialRequirementsButtons
    Copy = 1
    Paste = 2
    ExportList = 3
    AddInv = 4
    CopyChange = 5
    PasteChange = 6
  End Enum

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

  Public Property DBCon As clsDBConnBase
    Get
      Return pDBCon
    End Get
    Set(value As clsDBConnBase)
      pDBCon = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pAppRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pAppRTISGlobal = value
    End Set
  End Property



  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI, ByVal vIsInternal As Boolean)
    Dim mfrm As frmWorkOrderDetail = Nothing


    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderDetail
      mfrm.pFormController = New fccWorkOrderDetail(rDBConn, rRTISGlobal, vIsInternal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.DBCon = rDBConn
      mfrm.RTISGlobal = rRTISGlobal
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Public Shared Sub OpenFormModalWithObjects(ByRef rWorkOrder As dmWorkOrder, ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsInternal As Boolean)
    Dim mfrm As frmWorkOrderDetail = Nothing


    mfrm = New frmWorkOrderDetail
    mfrm.pFormController = New fccWorkOrderDetail(rDBConn, rRTISGlobal, vIsInternal)
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


    If pFormController.WorkOrder.isInternal Then
      UctFileControl1.Enabled = False
    Else
      mFileDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderUsr, pFormController.SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))

      UctFileControl1.UserController = New uccFileControl(Me)
      UctFileControl1.UserController.Directory = mFileDirectory
      UctFileControl1.UserController.FileTrackers = pFormController.WorkOrder.WOFiles
      UctFileControl1.UserController.ConfigSystemWatcher()
    End If

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


    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Material)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementsChanges, gcMaterialChanges, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodSpecie)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementsChanges, gcSpecieChanges, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Quality)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementsChanges, gcQualityChanges, mVIs)

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementOthers, gcAreaID, mVIs)

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdMaterialRequirementOthersChange, gcAreaIDChange, mVIs)


    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eWorkCentre))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcTSArea, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdTimeSheetEntries, gcTSEmployee, mVIs)

    ''mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodFinish)
    ''clsDEControlLoading.FillDEComboVI(cboWoodFinish, mVIs)

  End Sub

  Private Sub RefreshProductTabPages()
    ''tabProductSpec.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
    ''For mLoop = tabProductSpec.TabPages.Count - 1 To 0 Step -1
    ''  If tabProductSpec.TabPages(mLoop).Tag <> pFormController.WorkOrder.ProductTypeID Then
    ''    tabProductSpec.TabPages(mLoop).PageVisible = False
    ''  End If
    ''Next
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

      txtQuantity.Text = .Quantity
      txtUnitCost.Text = .UnitPrice

      btnWorkOrderNumber.EditValue = .WorkOrderNo
      txtDescription.Text = .Description

      dtePlannedStartDate.DateTime = .PlannedStartDate
      dtePlannedDeliverDate.DateTime = .PlannedDeliverDate
      dteDrawingDate.DateTime = .DrawingDate


      clsDEControlLoading.SetDECombo(cboProductType, .ProductTypeID)
      ''clsDEControlLoading.SetDECombo(cboWoodFinish, .WoodFinish)
      clsDEControlLoading.SetDECombo(cboFurnitureCategory, .FurnitureCategoryID)
      clsDEControlLoading.SetDECombo(cboEmployee, .EmployeeID)


      ''ceMaquinado.Checked = .Machining
      ''ceCostura.Checked = .Upholstery
      ''ceEnsamble.Checked = .Assembley
      ''ceLija.Checked = .Sanding
      ''ceMetal.Checked = .MetalWork
      ''ceSub.Checked = .SubContract
      ''cePintura.Checked = .Painting

      btneWorkOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

      bteImage.Text = .ImageFile

      RefreshProductControls()

      If pFormController.WorkOrder.isInternal = False Then
        UctFileControl1.LoadControls()
        UctFileControl1.RefreshControls()
        RefreshSalesControls()
        With pFormController.SalesOrderItem
          txtPrice.Text = .UnitPrice
          txtSalesQuantity.Text = .Quantity
        End With
      End If

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

        ''Grids for the changes
        grdMaterialRequirementsChanges.DataSource = mPF.MaterialRequirmentsChanges
        grdMaterialRequirementOthersChange.DataSource = mPF.MaterialRequirmentOthersChanges


        grdPackingComponents.DataSource = mPF.ProductFurnitureComponents

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
      .PlannedDeliverDate = dtePlannedDeliverDate.DateTime

      .DrawingDate = dteDrawingDate.DateTime

      .UnitPrice = Val(txtUnitCost.Text)

      ''.WoodFinish = clsDEControlLoading.GetDEComboValue(cboWoodFinish)
      .FurnitureCategoryID = clsDEControlLoading.GetDEComboValue(cboFurnitureCategory)
      .EmployeeID = clsDEControlLoading.GetDEComboValue(cboEmployee)

      .WorkcentreID = getCheckValue()

      ''.Machining = ceMaquinado.Checked
      ''.Upholstery = ceCostura.Checked
      ''.Assembley = ceEnsamble.Checked
      ''.Sanding = ceLija.Checked
      ''.MetalWork = ceMetal.Checked
      ''.SubContract = ceSub.Checked
      ''.Painting = cePintura.Checked

      If cboEmployee.EditValue = "" Then
        '' MsgBox("Se debe de ingresar el dibujante en la OT")
        ''.EmployeeID = clsRTISGlobal.
      End If

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
    Dim mFilePath As String = String.Empty
    Dim mOK As Boolean = True

    Try
      If pFormController.WorkOrder.isInternal = False Then
        If pFormController.SalesOrder IsNot Nothing Then
          If pFormController.SalesOrder.Customer Is Nothing Then
            MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
            mOK = False
          End If
        End If
      End If
      If mOK Then
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
      End If
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
    Dim mMatReqInfoChanges As New colMaterialRequirementInfos
    Dim mOtherMatInfoChanges As New colMaterialRequirementInfos

    ''If IsNothing(pFormController.SalesOrder.Customer) Then
    ''  MessageBox.Show("Un cliente debe de estar enlazado a la Orden de Venta", "Error al ingresar la información")
    ''  Return
    ''End If


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
      mMatReqInfoChanges = pFormController.GetMaterialRequirementInfosChanges
      mReportMRP = repWorkOrderMatReqsWood.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos, mMatReqInfoChanges)

      For Each mRepPage As DevExpress.XtraPrinting.Page In mReportMRP.Pages
        mRepMerge.Pages.Add(mRepPage)
      Next

      ''Creating Other Materials Report
      mMatReqInfos = pFormController.GetMaterialRequirementOtherInfos
      mOtherMatInfoChanges = pFormController.GetMaterialOtherMaterialChanges
      mOtherMaterialReport = repOtherMaterials.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos, mOtherMatInfoChanges)

      For Each mRepPage As DevExpress.XtraPrinting.Page In mOtherMaterialReport.Pages
        mRepMerge.Pages.Add(mRepPage)
      Next


      ''Creating Wood Requirments Changes Report
      ''mMatReqInfos = pFormController.GetMaterialRequirementInfosChanges
      ''mReportMRP = repWorkOrderMatReqsWood.GenerateReport(pFormController.SalesOrder, pFormController.WorkOrder, mMatReqInfos)

      ''For Each mRepPage As DevExpress.XtraPrinting.Page In mReportMRP.Pages
      ''  mRepMerge.Pages.Add(mRepPage)
      ''Next


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

      Case eDocumentType.InternalWorkOrder

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

    If pFormController.WorkOrder.isInternal = False Then
      mExportDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, pFormController.SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))
    Else
      mExportDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, pFormController.WorkOrder.DateCreated.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))
    End If

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


  Private Sub bteImage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteImage.ButtonClick
    Try
      UpdateObject()
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


  Private Sub gvWorkOrderBatches_ValidateRow(sender As Object, e As ValidateRowEventArgs)
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
            If mMatReq.PiecesPerComponent <> 0 Then
              If pFormController.IsInternal = False Then
                e.Value = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / mMatReq.PiecesPerComponent
              Else

              End If


            End If
          End If
          If e.IsSetData Then
            mMatReq.PiecesPerComponent = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / e.Value
          End If
        Case gcQtyBoardFeet.Name
          Dim mValue As Decimal
          Dim mQty As Integer
          If e.IsGetData Then
            Try

              If IsNumeric(mMatReq.PiecesPerComponent) And mMatReq.PiecesPerComponent > 0 Then
                mQty = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / mMatReq.PiecesPerComponent
                mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)

                ''mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mMatReq.TotalPieces, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)
                mValue = mValue
                e.Value = mValue
              End If

            Catch ex As Exception
              If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
            End Try

          End If
      End Select
    End If
  End Sub



  Private Sub gvMaterialRequirements_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles gvMaterialRequirements.InitNewRow
    Dim mMatReq As dmMaterialRequirement
    mMatReq = gvMaterialRequirements.GetRow(e.RowHandle)
    mMatReq.PiecesPerComponent = 1
  End Sub

  Private Sub grpLabels_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpLabels.CustomButtonClick

    Dim mlabelDef As New AF_Core.clsLabelDefinition
    Dim mDso As New AF_Core.dsoLabelDefinition(My.Application.RTISUserSession.CreateMainDBConn())

    Try

      mlabelDef.LabelDefinitionID = 1
      mDso.LoadLabelDefinition(mlabelDef)

      repFGLabel.PrintWorkOrderLabels(pFormController.WorkOrder, pFormController.SalesOrder, mlabelDef)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvPackingComponents_KeyDown(sender As Object, e As KeyEventArgs) Handles gvPackingComponents.KeyDown
    Select Case e.KeyCode
      Case Keys.Delete
        gvPackingComponents.DeleteSelectedRows()
    End Select
  End Sub


  Private Sub grpMaterialRequirements_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaterialRequirements.CustomButtonClick
    Select Case e.Button.Properties.Tag
      Case eMaterialRequirementsButtons.Copy
        Dim mMatReqs As colMaterialRequirements
        mMatReqs = grdMaterialRequirements.DataSource



        pFormController.RTISGlobal.ClipBoard.AddObjectsToClipBoard(mMatReqs)
      Case eMaterialRequirementsButtons.Paste
        Dim mPF As dmProductFurniture
        mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)
        If mPF IsNot Nothing Then

          If pFormController.RTISGlobal.ClipBoard.ClipObjectType Is GetType(dmMaterialRequirement) Then
            For Each mMatReq As dmMaterialRequirement In pFormController.RTISGlobal.ClipBoard.ClipObjects
              mMatReq.ClearKeys()
              mMatReq.ObjectID = mPF.ProductFurnitureID
              mPF.MaterialRequirments.Add(mMatReq)
            Next
          End If
        End If

      Case eMaterialRequirementsButtons.ExportList
        Dim mFileName As String = "Exportar MRP " + pFormController.WorkOrder.WorkOrderNo & ".xlsx"
        If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
          gvMaterialRequirements.ExportToXlsx(mFileName)
        End If
    End Select
  End Sub

  Private Sub btnWorkOrderNumber_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnWorkOrderNumber.ButtonClick
    Dim mNewWO As String
    Try

      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Undo

          UpdateObject()
          mNewWO = pFormController.WorkOrder.WorkOrderNo
          mNewWO = InputBox("Modificar el Numero de OT",, mNewWO)
          If mNewWO <> "" Then
            pFormController.WorkOrder.WorkOrderNo = mNewWO
          End If
          pFormController.SaveObjects()
          RefreshControls()

        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis
          If pFormController.WorkOrder.WorkOrderNo = "" Then
            pFormController.GetNextWONumber()
          End If

          RefreshControls()
      End Select


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvRequirmentMaterialsChanges_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvRequirmentMaterialsChanges.CustomUnboundColumnData
    Dim mMatReq As dmMaterialRequirement



    mMatReq = TryCast(e.Row, dmMaterialRequirement)
    If mMatReq IsNot Nothing Then
      Select Case e.Column.Name
        Case gcTotalQuantityChanges.Name
          If e.IsGetData Then
            If mMatReq.PiecesPerComponent <> 0 Then
              e.Value = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / mMatReq.PiecesPerComponent
            End If
          End If

          If e.IsSetData Then
            mMatReq.PiecesPerComponent = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / e.Value
          End If

        Case gcBoardTableChanges.Name
          Dim mValue As Decimal
          Dim mQty As Integer
          If e.IsGetData Then
            Try

              If IsNumeric(mMatReq.PiecesPerComponent) And mMatReq.PiecesPerComponent > 0 Then
                mQty = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / mMatReq.PiecesPerComponent
                mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)
                mValue = mValue
                e.Value = mValue
              End If

            Catch ex As Exception
              If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
            End Try

          End If
      End Select
    End If
  End Sub

  Private Sub grpMaterialRequirementOthers_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaterialRequirementOthers.CustomButtonClick
    Select Case e.Button.Properties.Tag
      Case eMaterialRequirementsButtons.Copy
        Dim mMatReqs As colMaterialRequirements
        mMatReqs = grdMaterialRequirementOthers.DataSource

        pFormController.RTISGlobal.ClipBoard.AddObjectsToClipBoard(mMatReqs)
      Case eMaterialRequirementsButtons.Paste
        Dim mPF As dmProductFurniture
        mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)
        If mPF IsNot Nothing Then

          If pFormController.RTISGlobal.ClipBoard.ClipObjectType Is GetType(dmMaterialRequirement) Then
            For Each mMatReq As dmMaterialRequirement In pFormController.RTISGlobal.ClipBoard.ClipObjects
              mMatReq.ClearKeys()
              mMatReq.ObjectID = mPF.ProductFurnitureID
              mPF.MaterialRequirmentOthers.Add(mMatReq)
            Next
          End If
        End If
      Case eMaterialRequirementsButtons.AddInv
        Dim mSIs As New colStockItems
        Dim mPicker As clsPickerStockItem
        Dim mSelectedSI As dmStockItem

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
          mSIs.Add(mItem.Value)
        Next

        mPicker = New clsPickerStockItem(mSIs, pFormController.DBConn, pFormController.RTISGlobal)

        Dim mPF As dmProductFurniture
        mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)

        For Each mMR As dmMaterialRequirement In mPF.MaterialRequirmentOthers
          mSelectedSI = mSIs.ItemFromKey(mMR.StockItemID)
          If mSelectedSI IsNot Nothing Then
            If mPicker.SelectedObjects.Contains(mSelectedSI) = false Then
              mPicker.SelectedObjects.Add(mSelectedSI)
            End If
          End If
        Next

        frmPickerStockItem.OpenPickerMulti(mPicker, True, DBCon, RTISGlobal)

        pFormController.syncronizedMaterialRequirment(mPicker.SelectedObjects)

        RefreshProductControls()
      Case eMaterialRequirementsButtons.ExportList
        Dim mFileName As String = "Exportar LMR " + pFormController.WorkOrder.WorkOrderNo & ".xlsx"
        If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
          gvMaterialRequirementOthers.ExportToXlsx(mFileName)
        End If
    End Select
  End Sub

  Private Sub gvMaterialRequirementOthers_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvMaterialRequirementOthers.CustomUnboundColumnData
    Dim mMatReq As dmMaterialRequirement
    Dim mSI As dmStockItem

    mMatReq = CType(e.Row, dmMaterialRequirement)

    If mMatReq.StockItemID = 0 Then


      Select Case e.Column.Name
        Case gcMatReqOtherDescription.Name
          If e.IsGetData Then
            e.Value = mMatReq.Description
          ElseIf e.IsSetData Then
            mMatReq.Description = e.Value
          End If
        Case gcStockCode.Name
          If e.IsGetData Then
            e.Value = mMatReq.StockCode
          ElseIf e.IsSetData Then
            mMatReq.StockCode = e.Value
          End If

        Case gcPartNo.Name
          If e.IsGetData Then
            e.Value = mMatReq.SupplierStockCode
          ElseIf e.IsSetData Then
            mMatReq.SupplierStockCode = e.Value
          End If
      End Select
    Else
      mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMatReq.StockItemID)
      If mSI IsNot Nothing Then

        Select Case e.Column.Name
          Case gcMatReqOtherDescription.Name
            If e.IsGetData Then
              If String.IsNullOrEmpty(mSI.ShortDescription) Then
                e.Value = mSI.Description
              Else
                e.Value = mSI.ShortDescription
              End If


            End If
          Case gcStockCode.Name
            If e.IsGetData Then
              e.Value = mSI.StockCode

            End If

          Case gcPartNo.Name
            If e.IsGetData Then
              e.Value = mSI.PartNo

            End If
        End Select
      End If
    End If
  End Sub

  Private Sub grpMaterialRequirementsOtherChanges_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaterialRequirementsOtherChanges.CustomButtonClick
    Select Case e.Button.Properties.Tag

      ''Case eMaterialRequirementsButtons.CopyChange
      ''  Dim mMatReqs As colMaterialRequirements
      ''  mMatReqs = grdMaterialRequirementOthersChange.DataSource

      ''  pFormController.RTISGlobal.ClipBoard.AddObjectsToClipBoard(mMatReqs)
      ''Case eMaterialRequirementsButtons.PasteChange
      ''  Dim mPF As dmProductFurniture
      ''  mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)
      ''  If mPF IsNot Nothing Then

      ''    If pFormController.RTISGlobal.ClipBoard.ClipObjectType Is GetType(dmMaterialRequirement) Then
      ''      For Each mMatReq As dmMaterialRequirement In pFormController.RTISGlobal.ClipBoard.ClipObjects
      ''        mMatReq.ClearKeys()
      ''        mMatReq.ObjectID = mPF.ProductFurnitureID
      ''        mPF.MaterialRequirmentOthersChanges.Add(mMatReq)
      ''      Next
      ''    End If
      ''  End If

      Case eMaterialRequirementsButtons.AddInv
        Dim mSIs As New colStockItems
        Dim mPicker As clsPickerStockItem
        Dim mSelectedSI As dmStockItem

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
          mSIs.Add(mItem.Value)
        Next

        mPicker = New clsPickerStockItem(mSIs, pFormController.DBConn, pFormController.RTISGlobal)

        Dim mPF As dmProductFurniture
        mPF = TryCast(pFormController.WorkOrder.Product, dmProductFurniture)

        For Each mMR As dmMaterialRequirement In mPF.MaterialRequirmentOthersChanges
          mSelectedSI = mSIs.ItemFromKey(mMR.StockItemID)
          If mSelectedSI IsNot Nothing Then
            If mPicker.SelectedObjects.Contains(mSelectedSI) = False Then
              mPicker.SelectedObjects.Add(mSelectedSI)
            End If
          End If
        Next

        frmPickerStockItem.OpenPickerMulti(mPicker, True, DBCon, RTISGlobal)

        pFormController.syncronizedMaterialRequirmentChanges(mPicker.SelectedObjects)

        RefreshProductControls()

      Case eMaterialRequirementsButtons.ExportList
        Dim mFileName As String = "Exportar LMR de Cambios " + pFormController.WorkOrder.WorkOrderNo & ".xlsx"
        If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
          gvMaterialRequirmentOtherChanges.ExportToXlsx(mFileName)
        End If

    End Select
  End Sub

  Private Sub gvMaterialRequirmentOtherChanges_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvMaterialRequirmentOtherChanges.CustomUnboundColumnData
    Dim mMatReq As dmMaterialRequirement
    Dim mSI As dmStockItem

    mMatReq = CType(e.Row, dmMaterialRequirement)

    If mMatReq.StockItemID = 0 Then


      Select Case e.Column.Name
        Case gcMatReqOtherDescriptionChange.Name
          If e.IsGetData Then
            e.Value = mMatReq.Description
          ElseIf e.IsSetData Then
            mMatReq.Description = e.Value
          End If
        Case gcStockCodeChange.Name
          If e.IsGetData Then
            e.Value = mMatReq.StockCode
          ElseIf e.IsSetData Then
            mMatReq.StockCode = e.Value
          End If

        Case gcPartNoChange.Name
          If e.IsGetData Then
            e.Value = mMatReq.SupplierStockCode
          ElseIf e.IsSetData Then
            mMatReq.StockCode = e.Value
          End If
      End Select
    Else
      mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMatReq.StockItemID)
      If mSI IsNot Nothing Then

        Select Case e.Column.Name
          Case gcMatReqOtherDescriptionChange.Name
            If e.IsGetData Then
              e.Value = mSI.Description

            End If
          Case gcStockCodeChange.Name
            If e.IsGetData Then
              e.Value = mSI.StockCode

            End If

          Case gcPartNoChange.Name
            If e.IsGetData Then
              e.Value = mSI.PartNo

            End If
        End Select
      End If
    End If
  End Sub

  Private Sub grpMaterialRequirementChanges_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaterialRequirementChanges.CustomButtonClick
    Select Case e.Button.Properties.Tag

      Case eMaterialRequirementsButtons.ExportList
        Dim mFileName As String = "Exportar MRP de Cambios " + pFormController.WorkOrder.WorkOrderNo & ".xlsx"
        If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
          gvRequirmentMaterialsChanges.ExportToXlsx(mFileName)
        End If
    End Select
  End Sub

  Private Sub repbtnSubstituteMatReq_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repbtnSubstituteMatReq.ButtonClick
    Dim mSI As dmStockItem
    Dim mMR As dmMaterialRequirement
    Dim mSIs As New colStockItems
    Dim mPicker As clsPickerStockItem

    For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
      mSIs.Add(mItem.Value)
    Next

    mPicker = New clsPickerStockItem(mSIs, pFormController.DBConn, pFormController.RTISGlobal)

    mSI = frmPickerStockItem.OpenPickerSingle(mPicker)

    If mSI IsNot Nothing Then
      mMR = gvMaterialRequirementOthers.GetFocusedRow
      mMR.Description = ""
      mMR.StockItemID = mSI.StockItemID
    End If
    gvMaterialRequirementOthers.CloseEditor()
    gvMaterialRequirementOthers.UpdateCurrentRow()

  End Sub

End Class