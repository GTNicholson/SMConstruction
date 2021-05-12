Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmPurchaseOrderConsole
  'Public ExitMode As Windows.Forms.DialogResult

  'Private pFormController As fccPurchaseOrderConsole

  'Private Shared sSingleInstance As frmPurchaseOrderConsole
  'Private Shared sActiveForms As Collection
  'Private Shared sFormIndex As Integer
  'Private pMySharedIndex As Integer

  'Private pForceExit As Boolean = False
  'Private pIsActive As Boolean
  'Private pLoadError As Boolean




  'Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal)
  '  Dim mfrm As New frmPurchaseOrderConsole
  '  If sSingleInstance Is Nothing Then
  '    mfrm.FormController = New fccPurchaseOrderConsole()
  '    mfrm.FormController.DBConn = rDBConn
  '    mfrm.FormController.RTISGlobal = rRTISGlobal
  '    mfrm.Owner = rParentForm
  '    sSingleInstance = mfrm
  '  End If
  '  sSingleInstance.Show()
  '  sSingleInstance.WindowState = FormWindowState.Normal
  'End Sub



  'Public Property FormController As fccPurchaseOrderConsole
  '  Get
  '    Return pFormController
  '  End Get
  '  Set(value As fccPurchaseOrderConsole)
  '    pFormController = value
  '  End Set
  'End Property

  'Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean)
  '  If vWithCheck Then
  '    If CheckSave(False) Then
  '      CloseForm()
  '    End If
  '  Else
  '    ExitMode = Windows.Forms.DialogResult.No
  '    CloseForm()
  '  End If

  'End Sub

  'Private Sub InitiateSaveExit()

  '  'If CheckSave(False) Then
  '  CloseForm()
  '  'End If

  'End Sub

  'Private Sub bbtnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnExit.ItemClick
  '  Try
  '    InitiateSaveExit()
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try
  'End Sub

  'Private Sub CloseForm() 'Needs exit mode set first
  '  pForceExit = True
  '  Me.Close()
  'End Sub

  'Private Sub UpdateObject()

  'End Sub

  'Private Function CheckSave(ByVal rOption As Boolean) As Boolean
  '  Dim mSaveRequired As Boolean
  '  Dim mResponse As MsgBoxResult
  '  Dim mRetVal As Boolean

  '  UpdateObject()

  '  If pFormController.IsDirty() Then
  '    If rOption Then
  '      mResponse = MsgBox("Changes have been made. Do you wish to save them?", MsgBoxStyle.YesNoCancel)
  '      Select Case mResponse
  '        Case MsgBoxResult.Yes
  '          mSaveRequired = True
  '          mRetVal = False
  '          ExitMode = Windows.Forms.DialogResult.Yes
  '        Case MsgBoxResult.No
  '          mSaveRequired = False
  '          mRetVal = True
  '          ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
  '        Case MsgBoxResult.Cancel
  '          mSaveRequired = False
  '          mRetVal = False
  '      End Select
  '    Else
  '      ExitMode = Windows.Forms.DialogResult.Yes
  '      mSaveRequired = True
  '      mRetVal = False
  '    End If
  '  Else
  '    ExitMode = Windows.Forms.DialogResult.Ignore
  '    mSaveRequired = False
  '    mRetVal = True
  '  End If
  '  If mSaveRequired Then
  '    ''Dim mValidate As clsValidate
  '    ''mValidate = pFormController.ValidateObject
  '    ''If mValidate.ValOk Then
  '    mRetVal = pFormController.SaveObject()
  '    ''Else
  '    ''  MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
  '    ''  mRetVal = False
  '    ''End If
  '  End If
  '  CheckSave = mRetVal
  'End Function

  'Private Sub bbtnCreateNewPurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnCreateNewPurchaseOrder.ItemClick
  '  Try
  '    frmPurchaseOrder.OpenFormAsMDIChild(Me, pFormController.DBConn, pFormController.DBConn.RTISUser, pFormController.RTISGlobal, 0, eFormMode.eFMFormModeAdd)
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try
  'End Sub

  'Public Sub New()

  '  ' This call is required by the Windows Form Designer.
  '  InitializeComponent()

  '  ' Add any initialization after the InitializeComponent() call.
  '  sFormIndex = sFormIndex + 1
  '  Me.pMySharedIndex = sFormIndex
  '  If sActiveForms Is Nothing Then sActiveForms = New Collection
  '  sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  'End Sub

  'Private Sub frmProcessingToPurchaseOrder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

  '  pFormController = Nothing
  '  sSingleInstance = Nothing
  '  sActiveForms.Remove(Me.pMySharedIndex.ToString)
  '  For Each mfrm As Form In Me.MdiChildren
  '    mfrm.Close()
  '  Next
  '  Me.Dispose()

  'End Sub

  'Private Sub frmProcessingToPurchaseOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
  '  If Not pForceExit Then
  '    If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
  '      e.Cancel = Not CheckSave(True)
  '    End If
  '  End If
  'End Sub

  'Private Sub LoadCombos()
  '  ''Dim mVIs As colValueItems

  '  ''mVIs = pFormController.RTISGlobal.RefLists(appRefLists.PurchMatReqCategories).ListAsValueItems()
  '  ''clsDEControlLoading.FillDERepComboVI(repcboMaterialGroup, mVIs)

  '  clsDEControlLoading.FillDERepComboVI(repcboMaterialGroup, clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory)))
  'End Sub

  'Private Sub RefreshControls()

  'End Sub

  'Private Sub SetUpUserPermissions()

  'End Sub

  'Private Sub SetDefaultForm()




  '  frmStockItemPurchasing.OpenAsMDI(Me, pFormController.DBConn, pFormController.RTISGlobal, True, False)
  '  frmMaterialRequirement.OpenFormAsMDIChild(Me, pFormController.RTISGlobal, pFormController.DBConn, 0)

  '  XtraTabbedMdiManager1.Pages(0).ShowCloseButton = DevExpress.Utils.DefaultBoolean.False
  '  ''XtraTabbedMdiManager1.Pages(1).ShowCloseButton = DevExpress.Utils.DefaultBoolean.False
  '  Me.MdiChildren(0).Focus()
  'End Sub

  'Private Sub frmProcessingToPurchaseOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
  '  Dim mOK As Boolean = True
  '  Dim mMsg As String = ""
  '  Dim mErrorDisplayed As Boolean = False

  '  ''Resize if required

  '  pIsActive = False
  '  pLoadError = False

  '  Try
  '    If mOK Then mOK = pFormController.LoadObject()

  '    If mOK Then mOK = pFormController.LoadRefData()

  '    LoadCombos()

  '    'If mOK Then LoadExtensionControls()

  '    If mOK Then RefreshControls()

  '    If mOK Then SetUpUserPermissions()

  '    If mOK Then SetDefaultForm()

  '    SetMaterialGroup(pFormController.MaterialRequirementGroup)

  '  Catch ex As Exception
  '    mMsg = ex.Message
  '    mOK = False
  '    mErrorDisplayed = True
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try

  '  If Not mOK Then
  '    If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
  '    pLoadError = True
  '    ExitMode = Windows.Forms.DialogResult.Abort
  '    BeginInvoke(New MethodInvoker(AddressOf CloseForm))

  '  End If

  '  pIsActive = True
  'End Sub


  'Private Sub repcboMaterialGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repcboMaterialGroup.SelectedIndexChanged
  '  Dim mComboBox As DevExpress.XtraEditors.ComboBoxEdit
  '  Dim mMatReqGroup As Integer

  '  Try
  '    If pIsActive Then
  '      mComboBox = CType(sender, DevExpress.XtraEditors.ComboBoxEdit)
  '      mMatReqGroup = clsDEControlLoading.GetDEComboValue(mComboBox)
  '      pFormController.MaterialRequirementGroup = mMatReqGroup
  '      SetMaterialGroup(mMatReqGroup)

  '      RefreshControls()
  '    End If
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try
  'End Sub

  'Public Sub SetMaterialGroup(ByVal vMatReqGroup As Integer)
  '  Dim mForm As Windows.Forms.Form
  '  Dim mfrmMaterialRequirements As frmMaterialRequirement
  '  Dim mTabbedPage As DevExpress.XtraTabbedMdi.XtraMdiTabPage

  '  For Each mTabbedPage In XtraTabbedMdiManager1.Pages
  '    mForm = mTabbedPage.MdiChild
  '    If mForm.GetType Is GetType(frmMaterialRequirement) Then
  '      mfrmMaterialRequirements = mForm
  '      'mfrmMaterialRequirements.FormController.MaterialRequirementGroup = vMatReqGroup
  '      '  mfrmMaterialRequirements.SetMaterialGroup(vMatReqGroup)
  '    End If
  '  Next

  'End Sub

  'Private Sub bbtnOpenExistingPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnOpenExistingPO.ItemClick
  '  Dim mPOInfo As clsPurchaseOrderInfo
  '  Dim mPicker As clsPickerPurchaseOrder
  '  Dim mPOInfos As colPurchaseOrderInfos

  '  mPOInfos = pFormController.LoadPurchaseOrderInfos()
  '  mPicker = New clsPickerPurchaseOrder(mPOInfos)
  '  Try
  '    mPOInfo = frmPickerPurchaseOrder.OpenPickerSingle(mPicker)
  '    If mPOInfo IsNot Nothing Then
  '      frmPurchaseOrder.OpenFormAsMDIChild(Me, pFormController.DBConn, pFormController.DBConn.RTISUser, pFormController.RTISGlobal, mPOInfo.PurchaseOrderID, eFormMode.eFMFormModeEdit)
  '    End If
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try
  'End Sub



  'Public Sub RefreshPOs()
  '  Dim mfrmPO As frmPurchaseOrder
  '  Dim mfrmSIPurchasing As frmStockItemPurchasing = Nothing
  '  Dim mfrmMR As frmMaterialRequirement = Nothing
  '  Dim mCaptionText As String
  '  ''  Dim mSubSupp As clsSupplier

  '  If pFormController Is Nothing Then
  '    Exit Sub
  '  End If

  '  pFormController.OpenPOs = New colPurchaseOrders
  '  For Each mForm As Windows.Forms.Form In MdiChildren
  '    If mfrmSIPurchasing Is Nothing Then
  '      If mForm.GetType() = GetType(frmStockItemPurchasing) Then
  '        mfrmSIPurchasing = CType(mForm, frmStockItemPurchasing)
  '      End If
  '    End If
  '    If mfrmMR Is Nothing Then
  '      If mForm.GetType() = GetType(frmMaterialRequirement) Then
  '        mfrmMR = CType(mForm, frmMaterialRequirement)
  '      End If
  '    End If
  '    If mForm.GetType() = GetType(frmPurchaseOrder) Then
  '      mfrmPO = CType(mForm, frmPurchaseOrder)
  '      mfrmPO.lblTitle.Focus()

  '      If mfrmPO IsNot Nothing AndAlso mfrmPO.FormController IsNot Nothing AndAlso mfrmPO.FormController.PurchaseOrder IsNot Nothing Then
  '        pFormController.OpenPOs.Add(mfrmPO.FormController.PurchaseOrder)
  '      End If
  '    End If
  '  Next

  '  If mfrmSIPurchasing IsNot Nothing Then mfrmSIPurchasing.bsubitProcessToPO.ClearLinks()
  '  If mfrmMR IsNot Nothing Then mfrmMR.bsubitProcessToPO.ClearLinks()

  '  For Each mPO As dmPurchaseOrder In pFormController.OpenPOs

  '    Dim mItem As New DevExpress.XtraBars.BarButtonItem()
  '    mCaptionText = ""
  '    If mPO.SupplierID > 0 Then
  '      mCaptionText = mPO.Supplier.CompanyName
  '    End If
  '    mItem.Caption = "Add to " & mPO.PONum & " " & mCaptionText
  '    mItem.Tag = mPO
  '    If mPO.Status = ePurchaseOrderDueDateStatus.InProcess Then
  '      mfrmMR.bsubitProcessToPO.Enabled = True
  '      mItem.Enabled = True
  '    End If
  '    AddHandler mItem.ItemClick, AddressOf ProcessToPOFromMatReq
  '    If mfrmMR IsNot Nothing Then mfrmMR.bsubitProcessToPO.AddItem(mItem)
  '  Next

  '  For Each mPO As dmPurchaseOrder In pFormController.OpenPOs

  '    Dim mItem As New DevExpress.XtraBars.BarButtonItem()
  '    mCaptionText = ""
  '    If mPO.SupplierID > 0 Then
  '      mCaptionText = mPO.Supplier.CompanyName
  '    End If
  '    mItem.Caption = "Add to " & mPO.PONum & " " & mCaptionText
  '    mItem.Tag = mPO
  '    If mPO.Status = ePurchaseOrderDueDateStatus.InProcess Then
  '      mItem.Enabled = True
  '      mfrmSIPurchasing.bsubitProcessToPO.Enabled = True
  '    End If
  '    AddHandler mItem.ItemClick, AddressOf ProcessToPOFromSI
  '    If mfrmSIPurchasing IsNot Nothing Then mfrmSIPurchasing.bsubitProcessToPO.AddItem(mItem)
  '  Next


  'End Sub

  'Private Function GetfrmPurchaseOrderByPOID(ByVal vPOID As Integer) As frmPurchaseOrder
  '  Dim mRetVal As frmPurchaseOrder = Nothing
  '  Dim mfrmPO As frmPurchaseOrder
  '  For Each mForm As Windows.Forms.Form In MdiChildren
  '    If mForm.GetType() = GetType(frmPurchaseOrder) Then
  '      mfrmPO = CType(mForm, frmPurchaseOrder)
  '      If mfrmPO.FormController.PurchaseOrder.PurchaseOrderID = vPOID Then
  '        mRetVal = mForm
  '        Exit For
  '      End If
  '    End If
  '  Next
  '  Return mRetVal
  'End Function

  'Private Sub ProcessToPOFromMatReq(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
  '  Try
  '    Dim mfrmPO As frmPurchaseOrder
  '    Dim mfrmMR As frmMaterialRequirement
  '    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
  '    Dim mCountProcessed As Integer
  '    Dim mPO As dmPurchaseOrder

  '    ''    pFormController.OpenPOs = New colPurchaseOrders

  '    '// Find the relevent source form (frmMaterialRequirement)
  '    For Each mForm As Windows.Forms.Form In MdiChildren
  '      If mForm.GetType() = GetType(frmMaterialRequirement) Then
  '        mfrmMR = CType(mForm, frmMaterialRequirement)
  '        Exit For
  '      End If
  '    Next

  '    '//Force any un written updates
  '    If mfrmMR IsNot Nothing Then
  '      mGridView = mfrmMR.grdMaterialRequirements.MainView
  '      If mGridView IsNot Nothing Then
  '        mGridView.CloseEditor()
  '      End If
  '    End If

  '    '// Find the relevent source form (frmPurchaseOrder)
  '    For Each mForm As Windows.Forms.Form In MdiChildren
  '      If mForm.GetType() = GetType(frmPurchaseOrder) Then
  '        mfrmPO = CType(mForm, frmPurchaseOrder)
  '        Exit For
  '      End If
  '    Next

  '    '//Force any un written updates
  '    If mfrmPO IsNot Nothing Then
  '      mGridView = mfrmPO.grdPurchaseOrderItems.MainView
  '      If mGridView IsNot Nothing Then
  '        mGridView.CloseEditor()
  '      End If
  '    End If



  '    If TryCast(e.Item.Tag, dmPurchaseOrder) IsNot Nothing Then
  '      mPO = e.Item.Tag
  '      mCountProcessed = pFormController.ProcessMatReqToPO(mfrmMR.FormController.MatReqItemProcessors, mPO)
  '      mfrmMR.FormController.LoadMatReqs()
  '      mfrmMR.grdMaterialRequirements.DataSource = mfrmMR.FormController.MatReqItemProcessors
  '      mfrmMR.gvMaterialRequirements.RefreshData()

  '      mfrmPO.FormController.LoadObject()
  '      mfrmPO.grdPurchaseOrderItems.DataSource = mfrmPO.FormController.PurchaseOrder.PurchaseOrderItems.POItemsMinusAllocatedItem
  '      mfrmPO.gvPurchaseOrderItems.RefreshData()
  '    End If
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try
  'End Sub

  'Private Sub ProcessToPOFromSI(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
  '  Try
  '    Try
  '      Dim mfrmPO As frmPurchaseOrder
  '      Dim mfrmSI As frmStockItemPurchasing
  '      Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
  '      Dim mCountProcessed As Integer
  '      Dim mPO As dmPurchaseOrder


  '      For Each mForm As Windows.Forms.Form In MdiChildren
  '        If mForm.GetType() = GetType(frmStockItemPurchasing) Then
  '          mfrmSI = CType(mForm, frmStockItemPurchasing)
  '          Exit For
  '        End If
  '      Next


  '      If mfrmSI IsNot Nothing Then
  '        mGridView = mfrmSI.grdStockItems.MainView
  '        If mGridView IsNot Nothing Then
  '          mGridView.CloseEditor()
  '        End If
  '      End If


  '      If TryCast(e.Item.Tag, dmPurchaseOrder) IsNot Nothing Then
  '        mPO = e.Item.Tag
  '        mCountProcessed = pFormController.ProcessStockItemToPO(mfrmSI.FormController.StockItemProcessors, mPO)

  '        If mCountProcessed <> 0 Then

  '          mfrmPO = GetfrmPurchaseOrderByPOID(mPO.PurchaseOrderID)
  '          If mfrmPO IsNot Nothing Then
  '            If mfrmPO.CheckSave(False) Then
  '              'mfrmPO.FormController.LoadObject()
  '              mfrmPO.gvPurchaseOrderItems.RefreshData()
  '            End If
  '          End If

  '          ' pFormController.RefreshTracker.ObjectType = DSONet.colCotswoldObjectTypes.PurchaseOrder
  '          ' pFormController.RefreshTracker.AddPrimaryKey(CType(e.Item.Tag, clsPOCallOff).PurchaseOrderID)

  '          With mfrmSI
  '            .gvStockItems.BeginDataUpdate()
  '            '.FormController.LoadStockItems()
  '            '.FormController.LoadObject()
  '            .gvStockItems.EndDataUpdate()
  '            .grdStockItems.DataSource = .FormController.StockItemProcessors
  '            MsgBox("Processing complete, " & mCountProcessed & " Item(s) added to PO: " & mPO.PONum, MsgBoxStyle.OkOnly, "Processing onto Purchase Order")
  '          End With
  '        End If


  '      End If
  '    Catch ex As Exception
  '      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '    End Try
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  '  End Try
  'End Sub



  'Private Sub XtraTabbedMdiManager1_SelectedPageChanged(sender As Object, e As EventArgs) Handles XtraTabbedMdiManager1.SelectedPageChanged

  '  If pIsActive Then
  '    ''If XtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() = GetType(frmMaterialRequirements) Then
  '    ''RefreshSubSuppliersRefList()
  '    RefreshPOs()
  '    '' End If
  '  End If

  'End Sub

  'Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
  '  If pIsActive Then
  '    ''If XtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() = GetType(frmMaterialRequirements) Then
  '    ''RefreshSubSuppliersRefList()
  '    RefreshPOs()
  '    '' End If
  '  End If
  'End Sub

End Class