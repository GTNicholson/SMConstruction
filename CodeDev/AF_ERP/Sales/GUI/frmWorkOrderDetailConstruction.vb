
Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPStock

Public Class frmWorkOrderDetailConstruction
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pForceExit As Boolean = False
  Private pLoadError As Boolean
  Private pIsActive As Boolean
  Private pFormController As fccWorkOrderDetailConstruction
  Private pInitialSalesOrderPhaseItems As List(Of clsSalesOrderPhaseItemInfo)
  Public ExitMode As Windows.Forms.DialogResult
  Public pDBCon As RTIS.DataLayer.clsDBConnBase
  Public pAppRTISGlobal As AppRTISGlobal

  Private pCreateMode As eCreateMode
  Private pCurrentDetailMode As eEditMode


  Private Enum eCreateMode
    None = 0
    SalesRequirements = 1
    Inventory = 2
  End Enum


  Private Enum eAllocationsButtons
    Add = 1

  End Enum

  Public Enum eEditMode

    ProductEdtit = 1
    eView = 2
    SelectProduct = 3
    CreateProduct = 4
    Save = 5
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



  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI, ByVal vIsInternal As Boolean, ByVal vProductType As eProductType)
    Dim mfrm As frmWorkOrderDetailConstruction = Nothing


    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderDetailConstruction
      mfrm.pFormController = New fccWorkOrderDetailConstruction(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.DBCon = rDBConn
      mfrm.RTISGlobal = rRTISGlobal
      mfrm.FormController.ProductType = vProductType
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Public Shared Sub OpenFormMDINewSalesRequirements(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByRef rParentMDI As frmTabbedMDI, ByVal vProductType As eProductType)
    Dim mfrm As frmWorkOrderDetailConstruction = Nothing

    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderDetailConstruction
      mfrm.pFormController = New fccWorkOrderDetailConstruction(rDBConn, rRTISGlobal)
      mfrm.FormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.FormController.ProductType = vProductType
      mfrm.MdiParent = rParentMDI
      mfrm.DBCon = rDBConn
      mfrm.RTISGlobal = rRTISGlobal
      mfrm.pCreateMode = eCreateMode.SalesRequirements
      'mfrm.pInitialSalesOrderPhaseItems = rSalesOrderPhaseItems
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Public Shared Sub OpenFormModalWithObjects(ByRef rWorkOrder As dmWorkOrder, ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsInternal As Boolean)
    Dim mfrm As frmWorkOrderDetailConstruction = Nothing


    mfrm = New frmWorkOrderDetailConstruction
    mfrm.pFormController = New fccWorkOrderDetailConstruction(rDBConn, rRTISGlobal)
    mfrm.pFormController.WorkOrder = rWorkOrder
    mfrm.pFormController.SalesOrder = rSalesOrder
    mfrm.FormController.PrimaryKeyID = rWorkOrder.WorkOrderID
    ''mfrm.ParentForm = rParent
    mfrm.ShowDialog()

  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmWorkOrderDetailConstruction
    Dim mfrmWanted As frmWorkOrderDetailConstruction = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWorkOrderDetailConstruction
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

  Public ReadOnly Property FormController As fccWorkOrderDetailConstruction
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmWorkOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False
    Dim mProductInfo As New clsProductBaseInfo
    ''Resize if required
    pLoadError = False
    pIsActive = False

    Try

      Select Case pCreateMode
        Case eCreateMode.None
          pFormController.LoadObjects()
        Case eCreateMode.SalesRequirements
          pFormController.LoadObjects()
          'pFormController.CreateFromSalesOrderPhaseItems(pInitialSalesOrderPhaseItems, pFormController.ProductType)
        Case eCreateMode.Inventory
      End Select

      pFormController.LoadRefData()
      ConfigureFileControl()

      mProductInfo.Product = pFormController.CurrentProduct
      uctProductDetail.SetCurrentProductBaseInfo(mProductInfo)
      uctProductDetail.FormController.ReloadProduct(pFormController.WorkOrder.ProductID)

      uctProductDetail.ConfigureBrowseFilesControl(pFormController.DBConn, pFormController.RTISGlobal)
      LoadCombos()
      pCurrentDetailMode = eEditMode.eView

      RefreshProductTabPages()
      RefreshControls()
      pFormController.RefreshCurrentWorkOrderAllocationEditors()
      grdWorkOrderAllocationsInfos.DataSource = pFormController.WorkOrderAllocationEditors

      grdStockItemMatReq.DataSource = pFormController.WorkOrder.StockItemMaterialRequirements
      grdWoodMatReq.DataSource = pFormController.WorkOrder.WoodMaterialRequirements
      pIsActive = True

      If mOK Then RefreshControls()
      RefreshDetailButtons()
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

    uctProductDetail.ConfigureControl(pFormController.DBConn, pFormController.RTISGlobal)

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


    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees)
    clsDEControlLoading.FillDEComboVI(cboElaboratedBy, mVIs)


    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItemMatReq, gcSIUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))

    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItemMatReq, gcArea, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WorkCentre))


    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Material)

    clsDEControlLoading.LoadGridLookUpEditiVI(grdWoodMatReq, gcMaterialType, mVIs)

    clsDEControlLoading.FillDEComboVI(cboStatus, clsEnumsConstants.EnumToVIs(GetType(eWorkOrderStatus)))

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

    If pFormController.WorkOrder IsNot Nothing Then
      With pFormController.WorkOrder
        lblWorkOrderID.Text = "ID:" & .WorkOrderID.ToString("00000")
        If .WorkOrderNo = "" Then
          Me.Text = "O.T. Nuevo"
        Else
          Me.Text = "O.T. " & .WorkOrderNo
        End If


        txtQuantity.Text = .WorkOrderAllocations.GetTotalQuantity

        btnWorkOrderNumber.EditValue = .WorkOrderNo
        txtDescription.Text = .Description
        dteCreatedDate.EditValue = .DateCreated
        dteDueDate.EditValue = .PlannedDeliverDate
        dtePurchasingDate.EditValue = .PurchasingDate
        dtePlannedStartDate.EditValue = .PlannedStartDate
        memPFNotes.EditValue = .Comments

        ''clsDEControlLoading.SetDECombo(cboWoodFinish, .WoodFinish)
        clsDEControlLoading.SetDECombo(cboElaboratedBy, .EmployeeID)
        clsDEControlLoading.SetDECombo(cboStatus, .Status)


        ''ceMaquinado.Checked = .Machining
        ''ceCostura.Checked = .Upholstery
        ''ceEnsamble.Checked = .Assembley
        ''ceLija.Checked = .Sanding
        ''ceMetal.Checked = .MetalWork
        ''ceSub.Checked = .SubContract
        ''cePintura.Checked = .Painting

        btneWorkOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)


        RefreshProductControls()



      End With

    End If

    If pCurrentDetailMode = eEditMode.eView Or pCurrentDetailMode = eEditMode.Save Then
      uctProductDetail.SetDetailsControlsReadonly(True)
      SetDetailsWorkOrderControlsReadonly(False)
    ElseIf pCurrentDetailMode = eEditMode.ProductEdtit Then
      uctProductDetail.SetDetailsControlsReadonly(False)
      SetDetailsWorkOrderControlsReadonly(True)
    Else
      uctProductDetail.SetDetailsControlsReadonly(False)
      SetDetailsWorkOrderControlsReadonly(True)

    End If


    pIsActive = mIsActive
  End Sub

  Private Sub RefreshProductControls()
    Select Case pFormController.WorkOrder.ProductTypeID
      Case eProductType.StructureAF
        uctProductDetail.LoadCombos()
        uctProductDetail.RefreshControls()

    End Select
  End Sub



  Private Sub UpdateObject()

    Dim mActiveControl As Control = Me.ActiveControl
    lblWorkOrderID.Focus()
    If mActiveControl IsNot Nothing Then
      mActiveControl.Focus()
    End If

    If pFormController.WorkOrder IsNot Nothing Then
      With pFormController.WorkOrder
        .Quantity = txtQuantity.Text
        .Description = txtDescription.Text.ToUpper
        .DateCreated = dteCreatedDate.EditValue
        .Comments = memPFNotes.EditValue
        .PurchasingDate = dtePurchasingDate.EditValue

        .PlannedStartDate = dtePlannedStartDate.EditValue
        .PlannedDeliverDate = dteDueDate.EditValue
        ''.WoodFinish = clsDEControlLoading.GetDEComboValue(cboWoodFinish)
        .EmployeeID = clsDEControlLoading.GetDEComboValue(cboElaboratedBy)
        .Status = clsDEControlLoading.GetDEComboValue(cboStatus)
        .WorkcentreID = getCheckValue()

        ''.Machining = ceMaquinado.Checked
        ''.Upholstery = ceCostura.Checked
        ''.Assembley = ceEnsamble.Checked
        ''.Sanding = ceLija.Checked
        ''.MetalWork = ceMetal.Checked
        ''.SubContract = ceSub.Checked
        ''.Painting = cePintura.Checked

        '' MsgBox("Se debe de ingresar el dibujante en la OT")
        ''.EmployeeID = clsRTISGlobal.

      End With
      UpdateProductControls()
    End If

  End Sub


  Private Function getCheckValue() As Int32
    Dim mVal As Int32



    Return mVal
  End Function
  Private Sub UpdateProductControls()
    If pFormController.CurrentProduct IsNot Nothing Then
      With pFormController.CurrentProduct
        .Notes = memPFNotes.Text.ToUpper

      End With
    End If
  End Sub

  Private Sub UpdateProductControlsFurniture()
    'Dim mPF As dmProductFurniture
    'If mPF IsNot Nothing Then
    '  With mPF
    '    .Notes = memPFNotes.Text.ToUpper
    '  End With
    'End If
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
    Dim mProductStructure As dmProductStructure
    Dim mFinishDate As DateTime

    Select Case vDocType
      Case eDocumentType.WorkOrderDoc


        If pFormController.WorkOrder IsNot Nothing Then
          mProductStructure = pFormController.GetCurrentProduct
          If mProductStructure IsNot Nothing Then
            Dim mProjectName As String = ""
            Dim mCustomerName As String = ""
            Dim mOrderNo As String = ""

            If pFormController.WorkOrderAllocationEditors.Count > 0 Then
              mProjectName = pFormController.WorkOrderAllocationEditors(0).ProjectName
              mCustomerName = pFormController.WorkOrderAllocationEditors(0).ClientName
              mOrderNo = pFormController.WorkOrderAllocationEditors(0).SalesOrderNo
              mFinishDate = pFormController.WorkOrderAllocationEditors(0).FinishDate
            End If
            UpdateTempInStockQty()
            UpdateTempThickness()

            mRetVal = repWorkOrderDoc.GenerateReport(pFormController.WorkOrder, mProjectName, mCustomerName, mOrderNo, mFinishDate)

          End If
        End If

      Case eDocumentType.InternalWorkOrder

        If pFormController.WorkOrder IsNot Nothing Then
          'mRetVal = repWorkOrderDoc.GenerateReport(pFormController.WorkOrder, pFormController.WorkOrderAllocationEditors)
        End If

    End Select

    Return mRetVal
  End Function

  Private Sub UpdateTempThickness()
    Dim mWoodMatReq As dmMaterialRequirement

    Dim mdso As New dsoStock(pFormController.DBConn)
    Dim mstockitem As dmStockItem


    For Each mWoodMatReq In pFormController.WorkOrder.WoodMaterialRequirements

      If mWoodMatReq.StockItemID > 0 Then

        mstockitem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWoodMatReq.StockItemID)

        If mstockitem IsNot Nothing Then
          mWoodMatReq.ThicknessInch = mstockitem.Thickness
        End If

      End If

    Next



  End Sub

  Private Sub UpdateTempInStockQty()
    Dim mStockItemMatReq As dmMaterialRequirement

    Dim mStockItemLocations As New colStockItemLocations

    Dim mdso As New dsoStock(pFormController.DBConn)

    mdso.LoadStockItemLocationsByWhere(mStockItemLocations, "")

    For Each mSIL As dmStockItemLocation In mStockItemLocations

      mStockItemMatReq = pFormController.WorkOrder.StockItemMaterialRequirements.ItemFromStockItemID(mSIL.StockItemID)

      If mStockItemMatReq IsNot Nothing Then
        mStockItemMatReq.TempAllocatedQty = mSIL.Qty

      End If


    Next



  End Sub

  Public Sub CreateReportPDF(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mProductFiles As colFileTrackers = Nothing
    Dim mProductStruscture As dmProductStructure

    ' Dim mReport As DevExpress.XtraReports.UI.XtraReport

    mFileName = clsEnumsConstants.GetEnumDescription(GetType(eDocumentType), vDocumentType) & "_" & pFormController.WorkOrder.WorkOrderID

    If pFormController.WorkOrder.isInternal = False Then
      ''mExportDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, pFormController.SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))
      mExportDirectory = IO.Path.Combine(pFormController.RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, pFormController.WorkOrder.DateCreated.Year, clsGeneralA.GetFileSafeName(pFormController.WorkOrder.WorkOrderID.ToString("00000")))

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

      If uctProductDetail IsNot Nothing Then

        If uctProductDetail.FormController IsNot Nothing Then
          If uctProductDetail.FormController.CurrentProductInfo IsNot Nothing Then
            mProductStruscture = TryCast(uctProductDetail.FormController.CurrentProductInfo.Product, dmProductStructure)

            If mProductStruscture IsNot Nothing Then

              mProductFiles = mProductStruscture.POFiles
            End If
          End If
        End If
      End If

      pFormController.CreateWorkOrderPack(vReport, mFilePath, mProductFiles)

      vReport.Dispose()
      'vReport = Nothing

      pFormController.WorkOrder.OutputDocuments.SetFilePath(eParentType.WorkOrder, vDocumentType, eFileType.PDF, mFilePath)

    End If

  End Sub



  Private Sub bbtnSave_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try
      UpdateObject()
      uctProductDetail.UpdateObject()
      pFormController.CurrentProduct = uctProductDetail.FormController.CurrentProductInfo.Product
      pFormController.SaveProduct()
      CheckSave(False)
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub cboProductType_SelectedIndexChanged(sender As Object, e As EventArgs)
    Try
      If pIsActive Then
        UpdateObject()
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
      uctProductDetail.UpdateObject()
      pFormController.CurrentProduct = uctProductDetail.FormController.CurrentProductInfo.Product
      pFormController.SaveProduct()

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


  Private Sub bteImage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
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


  Private Sub gvWorkOrderAllocationsInfos_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles gvWorkOrderAllocationsInfos.ValidateRow
    Try
      If pFormController.WorkOrder IsNot Nothing Then
        txtQuantity.Text = pFormController.WorkOrder.WorkOrderAllocations.GetTotalQuantity
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub grpLabels_CustomButtonClick(sender As Object, e As BaseButtonEventArgs)

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

        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
          If pFormController.WorkOrder.WorkOrderNo = "" Then
            pFormController.GetNextWONumber()
          End If

          RefreshControls()
      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub








  Private Sub bteProductPicker_ButtonClick(sender As Object, e As ButtonPressedEventArgs)

    Dim mDialogResult As DialogResult

    Try
      Select Case e.Button.Kind
        Case ButtonPredefines.Ellipsis
          mDialogResult = MessageBox.Show("¿Desea editar la información de este producto?", "Edición de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

          If mDialogResult = DialogResult.Yes Then
            frmProductDetail_New.OpenFormModal(pFormController.CurrentProduct.ID, pFormController.DBConn)
            If pFormController.CurrentProduct.ID <> 0 Then
              uctProductDetail.FormController.ReloadProduct(pFormController.CurrentProduct.ID)

              'FillCustomerDetail()
              RefreshControls()
            End If
          Else

          End If
      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try



  End Sub

  Private Sub grpWorkOrderAllocations_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWorkOrderAllocations.CustomButtonClick
    Dim mPicker As clsPickerSalesOrderPhase
    Dim mSelectedSalesOrderPhaseInfos As New colSalesOrderPhaseInfos
    Dim mSalesOrderPhaseInfo As clsSalesOrderPhaseInfo
    Dim mSelectedSOPI As clsSalesOrderPhaseInfo
    Dim mWorkderAllocation As dmWorkOrderAllocation
    Dim mCurrentProductID As Integer

    Dim mSOI As New dmSalesOrderItem



    Try
      Select Case e.Button.Properties.Tag
        Case eAllocationsButtons.Add

          pFormController.SalesOrderPhaseInfos.Clear()
          ''//Load the Sales Order Phases
          pFormController.LoadSalesOrderPhaseByWhere(pFormController.SalesOrderPhaseInfos, "")


          If pFormController.CurrentProduct IsNot Nothing Then
            mCurrentProductID = pFormController.CurrentProduct.ID
          End If
          mPicker = New clsPickerSalesOrderPhase(pFormController.SalesOrderPhaseInfos, pFormController.DBConn)

          For Each mWorkderAllocation In pFormController.WorkOrder.WorkOrderAllocations
            If mWorkderAllocation.SalesOrderPhaseItemID > 0 Then
              mSalesOrderPhaseInfo = pFormController.SalesOrderPhaseInfos.ItemBySalesOrderPhaseID(mWorkderAllocation.SalesOrderPhaseItemID)

              If Not mPicker.SelectedObjects.Contains(mSalesOrderPhaseInfo) Then
                mPicker.SelectedObjects.Add(mSalesOrderPhaseInfo)
              End If
            End If
          Next

          mSelectedSalesOrderPhaseInfos = frmSalesOrderPhasePicker.OpenPickerMulti(mPicker, True)

          If pFormController.SalesOrder Is Nothing Then ''check if the SO doest exists, this is a solution for the old OTs
            If mSelectedSalesOrderPhaseInfos IsNot Nothing Then

              If mSelectedSalesOrderPhaseInfos.Count > 0 Then
                pFormController.LoadSalesOrderDown(mSelectedSalesOrderPhaseInfos(0).SalesOrderID)

              End If
            End If
            End If
            If mSelectedSalesOrderPhaseInfos.Count > 0 Then
            For Each mSelectedSOPI In mPicker.SelectedObjects
              If mSelectedSOPI IsNot Nothing Then
                mWorkderAllocation = pFormController.WorkOrder.WorkOrderAllocations.ItemFromSalesOrderPhaseItemID(mSelectedSOPI.SalesOrderPhaseID)
                If mWorkderAllocation Is Nothing Then
                  mWorkderAllocation = New dmWorkOrderAllocation
                  mWorkderAllocation.WorkOrderID = pFormController.WorkOrder.WorkOrderID
                  mWorkderAllocation.SalesOrderPhaseItemID = mSelectedSOPI.SalesOrderPhaseID
                  pFormController.WorkOrder.WorkOrderAllocations.Add(mWorkderAllocation)
                End If
              End If
            Next
          End If


          For mindex As Integer = pFormController.WorkOrder.WorkOrderAllocations.Count - 1 To 0 Step -1
            mWorkderAllocation = pFormController.WorkOrder.WorkOrderAllocations(mindex)
            If mWorkderAllocation.SalesOrderPhaseItemID > 0 Then
              mSalesOrderPhaseInfo = mSelectedSalesOrderPhaseInfos.ItemBySalesOrderPhaseID(mWorkderAllocation.SalesOrderPhaseItemID)

              If Not mPicker.SelectedObjects.Contains(mSalesOrderPhaseInfo) Then
                pFormController.WorkOrder.WorkOrderAllocations.Remove(mWorkderAllocation)
              End If
            End If
          Next
          pFormController.SaveObjects()
          pFormController.RefreshCurrentWorkOrderAllocationEditors()
          pFormController.LoadObjects()

          gvWorkOrderAllocationsInfos.RefreshData()




      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub





  'Private Sub btnSelectProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSelectProduct.ItemClick
  '  Dim mProducts As colProductBaseInfos
  '  Dim mProductPicker As clsPickerProductItem
  '  Dim mProductBaseInfo As clsProductBaseInfo

  '  mProducts = pFormController.GetProductInfos()

  '  mProductPicker = New clsPickerProductItem(mProducts, pFormController.DBConn, pFormController.RTISGlobal)


  '  mProductBaseInfo = frmProductPicker.OpenPickerSingle(mProductPicker)

  '  If mProductBaseInfo IsNot Nothing Then
  '    pFormController.WorkOrder.Product = mProductBaseInfo.Product
  '    pFormController.WorkOrder.ProductTypeID = mProductBaseInfo.ProductTypeID
  '    pFormController.WorkOrder.ProductID = mProductBaseInfo.ID
  '    pFormController.CurrentProduct = mProductBaseInfo.Product
  '    pCurrentDetailMode = eEditMode.SelectProduct

  '    'txtProductDescription.Text = mProductBaseInfo.Description
  '    bteProductPicker.Text = mProductBaseInfo.Description
  '    UpdateObject()
  '    pFormController.SaveObjects()


  '    pFormController.ReloadProduct()
  '    grdWoodMaterialRequirements.DataSource = pFormController.CurrentProduct.WoodMaterialRequirements
  '    grdWoodMaterialRequirements.RefreshDataSource()
  '    gvWoodMaterialRequirements.RefreshData()

  '    grdStockItemsMaterialRequirement.DataSource = pFormController.CurrentProduct.MaterialRequirements
  '    grdStockItemsMaterialRequirement.RefreshDataSource()
  '    gvStockItemMaterialRequirements.RefreshData()
  '    RefreshControls()
  '  End If
  'End Sub

  Private Sub RefreshDetailButtons()
    Select Case pCurrentDetailMode
      Case eEditMode.ProductEdtit
        For Each mBtn As BarButtonItemLink In BarManager1.Bars(1).ItemLinks
          If mBtn.Item.Tag = eEditMode.ProductEdtit Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.SelectProduct Then mBtn.Item.Enabled = True
          If mBtn.Item.Tag = eEditMode.CreateProduct Then mBtn.Item.Enabled = True
          If mBtn.Item.Tag = eEditMode.Save Then mBtn.Item.Enabled = True

        Next
      Case eEditMode.eView
        For Each mBtn As BarButtonItemLink In BarManager1.Bars(1).ItemLinks
          If mBtn.Item.Tag = eEditMode.ProductEdtit Then mBtn.Item.Enabled = True
          If mBtn.Item.Tag = eEditMode.SelectProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.CreateProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.Save Then mBtn.Item.Enabled = False
        Next

      Case eEditMode.SelectProduct
        For Each mBtn As BarButtonItemLink In BarManager1.Bars(1).ItemLinks
          If mBtn.Item.Tag = eEditMode.ProductEdtit Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.SelectProduct Then mBtn.Item.Enabled = True
          If mBtn.Item.Tag = eEditMode.CreateProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.Save Then mBtn.Item.Enabled = True


        Next
      Case eEditMode.CreateProduct
        For Each mBtn As BarButtonItemLink In BarManager1.Bars(1).ItemLinks
          If mBtn.Item.Tag = eEditMode.ProductEdtit Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.SelectProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.CreateProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.Save Then mBtn.Item.Enabled = True


        Next

      Case eEditMode.Save
        For Each mBtn As BarButtonItemLink In BarManager1.Bars(1).ItemLinks
          If mBtn.Item.Tag = eEditMode.ProductEdtit Then mBtn.Item.Enabled = True
          If mBtn.Item.Tag = eEditMode.SelectProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.CreateProduct Then mBtn.Item.Enabled = False
          If mBtn.Item.Tag = eEditMode.Save Then mBtn.Item.Enabled = False


        Next
    End Select
  End Sub

  Private Sub bbtnEditProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnEditProduct.ItemClick
    Dim mDialogResult As DialogResult
    If pFormController.CurrentProduct IsNot Nothing Then




      pCurrentDetailMode = eEditMode.ProductEdtit
      'SetDetailsControlsReadonly(False)
      RefreshControls()
      RefreshDetailButtons()
      SetDetailsWorkOrderControlsReadonly(True)
      uctProductDetail.SetDetailsControlsReadonly(False)
    End If
  End Sub


  Private Sub SetDetailsWorkOrderControlsReadonly(ByVal vReadOnly As Boolean)
    txtDescription.ReadOnly = vReadOnly
    btnWorkOrderNumber.ReadOnly = vReadOnly
    dteCreatedDate.ReadOnly = vReadOnly
    dtePurchasingDate.ReadOnly = vReadOnly
    dteDueDate.ReadOnly = vReadOnly
    dtePlannedStartDate.ReadOnly = vReadOnly
    cboElaboratedBy.ReadOnly = vReadOnly
    txtQuantity.ReadOnly = vReadOnly
    grpWorkOrderAllocations.Enabled = Not vReadOnly
    memPFNotes.ReadOnly = vReadOnly
    btnGenerateMatReq.Enabled = Not vReadOnly
  End Sub



  Private Sub bbtnSaveProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnSaveProduct.ItemClick
    uctProductDetail.UpdateObject()
    pFormController.CurrentProduct = uctProductDetail.FormController.CurrentProductInfo.Product
    pFormController.SaveProduct()

    pCurrentDetailMode = eEditMode.Save

    uctProductDetail.FormController.ReloadProduct(pFormController.CurrentProduct.ID)
    pFormController.WorkOrder.ProductID = pFormController.CurrentProduct.ID
    RefreshDetailButtons()
    RefreshControls()
  End Sub

  Private Sub bbtnCreateNewProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnCreateNewProduct.ItemClick
    pCurrentDetailMode = eEditMode.CreateProduct
    Dim mNewProductInfo As New clsProductBaseInfo


    mNewProductInfo.Product = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
    uctProductDetail.SetCurrentProductBaseInfo(mNewProductInfo)

    uctProductDetail.RefreshControls()
    RefreshDetailButtons()
    RefreshControls()
  End Sub

  Private Sub btnSelectProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSelectProduct.ItemClick
    Dim mProducts As colProductBaseInfos
    Dim mProductPicker As clsPickerProductItem
    Dim mProductBaseInfo As clsProductBaseInfo

    mProducts = pFormController.GetProductInfos()

    mProductPicker = New clsPickerProductItem(mProducts, pFormController.DBConn, pFormController.RTISGlobal)


    mProductBaseInfo = frmProductPicker.OpenPickerSingle(mProductPicker)

    If mProductBaseInfo IsNot Nothing Then
      pFormController.WorkOrder.Product = mProductBaseInfo.Product
      pFormController.WorkOrder.ProductTypeID = mProductBaseInfo.ProductTypeID
      pFormController.WorkOrder.ProductID = mProductBaseInfo.ID
      pFormController.CurrentProduct = mProductBaseInfo.Product
      pCurrentDetailMode = eEditMode.SelectProduct

      UpdateObject()
      pFormController.SaveObjects()
      uctProductDetail.SetCurrentProductBaseInfo(mProductBaseInfo)
      uctProductDetail.FormController.ReloadProduct(pFormController.WorkOrder.ProductID)


      uctProductDetail.RefreshControls()

      RefreshControls()
    End If
  End Sub

  Private Sub btnGenerateMatReq_Click(sender As Object, e As EventArgs) Handles btnGenerateMatReq.Click
    Dim mProductStructure As dmProductStructure
    Dim mDialogResult As DialogResult

    mDialogResult = MessageBox.Show("¿Está seguro que desea generar los requerimientos de materiales para esta O.T.?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

    If mDialogResult = DialogResult.Yes Then
      mProductStructure = TryCast(uctProductDetail.FormController.CurrentProductInfo.Product, dmProductStructure)

      CheckSave(False)
      pFormController.GenerateMatReq(mProductStructure)



      grdStockItemMatReq.DataSource = pFormController.WorkOrder.StockItemMaterialRequirements
      gvStockItemMatReq.RefreshData()

      grdWoodMatReq.DataSource = pFormController.WorkOrder.WoodMaterialRequirements
      gvWoodMatReq.RefreshData()

      pFormController.SaveObjects()
    End If

  End Sub

  Private Sub gvStockItemMatReq_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWoodMatReq.CustomUnboundColumnData
    Dim mMatReq As dmMaterialRequirement

    mMatReq = TryCast(e.Row, dmMaterialRequirement)
    If mMatReq IsNot Nothing Then
      Select Case e.Column.Name
        Case gcTotalQuantity.Name
          If e.IsGetData Then
            e.Value = (mMatReq.UnitPiece * pFormController.WorkOrder.WorkOrderAllocations.GetTotalQuantity)

          End If
          If e.IsSetData Then
            'mMatReq.PiecesPerComponent = (mMatReq.UnitPiece * pFormController.WorkOrder.Quantity) / e.Value
          End If
        Case gcQtyBoardFeet.Name
          Dim mValue As Decimal
          Dim mQty As Integer
          If e.IsGetData Then
            Try

              mQty = (mMatReq.UnitPiece * pFormController.WorkOrder.WorkOrderAllocations.GetTotalQuantity)

              mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mQty, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)

              ''mValue = clsSMSharedFuncs.BoardFeetFromCMAndQty(mMatReq.TotalPieces, mMatReq.NetLenght, mMatReq.NetWidth, mMatReq.NetThickness)
              mValue = mValue
              e.Value = mValue


            Catch ex As Exception
              If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
            End Try

          End If
      End Select
    End If
  End Sub


  Private Sub grdStockItemMatReq_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdStockItemMatReq.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvStockItemMatReq.MoveNext()
    End If
  End Sub

  Private Sub grdWoodMatReq_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdWoodMatReq.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvWoodMatReq.MoveNext()
    End If
  End Sub

  Private Sub repoChangeSpecie_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles repoChangeSpecie.ButtonPressed
    Dim mWoodMatReq As dmMaterialRequirement
    Dim mSI As dmStockItem
    Dim mPicker As clsPickerStockItem
    Dim mStockItemsForPickers As New colStockItems

    Try
      mWoodMatReq = TryCast(gvWoodMatReq.GetFocusedRow, dmMaterialRequirement)

      If mWoodMatReq IsNot Nothing Then
        pFormController.LoadWoodStockItemsForPicker(mStockItemsForPickers)
        mPicker = New clsPickerStockItem(mStockItemsForPickers, pFormController.DBConn, pFormController.RTISGlobal)
        mSI = frmPickerStockItem.OpenPickerSingle(mPicker, True)

        If mSI IsNot Nothing Then
          mWoodMatReq.StockItemID = mSI.StockItemID
          mWoodMatReq.WoodSpecie = mSI.Species

        End If

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub grpMaterialRequirementInsumos_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaterialRequirementInsumos.CustomButtonClick
    Dim mPicker As clsPickerStockItem
    Dim mStockItemsForPickers As New colStockItems
    Dim mdso As New dsoStock(pFormController.DBConn)
    Dim mSI As dmStockItem
    Dim mStockItemMatReq As dmMaterialRequirement

    Try

      Select Case e.Button.Properties.Tag
        Case "AddItem"
          mdso.LoadStockItemsByWhere(mStockItemsForPickers, "IsNull(Inactive,0) = 0")
          mPicker = New clsPickerStockItem(mStockItemsForPickers, pFormController.DBConn, pFormController.RTISGlobal)
          mSI = frmPickerStockItem.OpenPickerSingle(mPicker, False)

          If mSI IsNot Nothing Then
            gvStockItemMatReq.CloseEditor()

            mStockItemMatReq = pFormController.GetNewStockitemMatReq(mSI)
            pFormController.WorkOrder.StockItemMaterialRequirements.Add(mStockItemMatReq)

            gvStockItemMatReq.RefreshData()
          End If

        Case "Export"
          Dim mFileName As String = "Exportar Lista de Insumos de " + pFormController.WorkOrder.WorkOrderNo & ".xlsx"
          If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
            gvStockItemMatReq.ExportToXlsx(mFileName)
          End If
      End Select


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub grpWOMatReqWood_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWOMatReqWood.CustomButtonClick
    Dim mFileName As String = "Exportar Lista de Madera de " + pFormController.WorkOrder.WorkOrderNo & ".xlsx"
    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
      gvWoodMatReq.ExportToXlsx(mFileName)
    End If
  End Sub

  Private Sub gvStockItemMatReq_CustomUnboundColumnData_1(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItemMatReq.CustomUnboundColumnData

    Dim mMatReq As dmMaterialRequirement
    Dim mSI As dmStockItem

    mMatReq = TryCast(e.Row, dmMaterialRequirement)
    If mMatReq IsNot Nothing Then
      Select Case e.Column.Name
        Case gcSIStockCode.Name
          If e.IsGetData Then
            mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMatReq.StockItemID)

            If mSI IsNot Nothing Then
              e.Value = mSI.StockCode
            End If

          End If

        Case gcSIDescription.Name
          If e.IsGetData Then
            mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMatReq.StockItemID)

            If mSI IsNot Nothing Then
              e.Value = mSI.Description
            End If

          End If

      End Select
    End If

  End Sub

  Private Sub btnPickOrder_Click(sender As Object, e As EventArgs) Handles btnPickOrder.Click
    Try
      Dim mMateiralRequirementProcessors As New colMaterialRequirementProcessors
      Dim mCountToProcess As Integer

      mMateiralRequirementProcessors = pFormController.GetMaterialRequirementProcessors()

      mCountToProcess = mMateiralRequirementProcessors.Count

      If mCountToProcess > 0 Then
        pFormController.ProcessPicksAutomatically(mMateiralRequirementProcessors)

        MessageBox.Show(String.Format("{0} artículos despachados automáticamente", mCountToProcess))
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub
End Class