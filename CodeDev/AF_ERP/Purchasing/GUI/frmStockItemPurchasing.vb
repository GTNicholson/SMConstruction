Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmStockItemPurchasing
  Dim pFormController As fccStockItemPurchasing

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pSpinEnter As Boolean


  Public Sub New()

    InitializeComponent()

    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsBulkOrdering As Boolean)
    Dim mfrm As frmStockItemPurchasing = Nothing

    mfrm = GetFormIfLoaded(vIsBulkOrdering, rMDIParent)
    If mfrm Is Nothing Then
      mfrm = New frmStockItemPurchasing
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStockItemPurchasing(rDBConn, rRTISGlobal)
      mfrm.pFormController.IsBulkOrdering = vIsBulkOrdering

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Public ReadOnly Property FormController As fccStockItemPurchasing
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmStockItemPurchasing_Load(sender As Object, e As EventArgs) Handles Me.Load
    pIsActive = False

    repProdStartDate.NullDate = DateTime.MinValue
    repProdStartDate.NullText = String.Empty

    repoETA.NullDate = DateTime.MinValue
    repoETA.NullText = String.Empty

    LoadCombos()
    pFormController.LoadObject()
    LoadGrids()

    SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

    pIsActive = True
  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vIsBulkOrdering As Boolean, ByVal rMDIParent As Form) As frmStockItemPurchasing
    Dim mfrmWanted As frmStockItemPurchasing = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmStockItemPurchasing

    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmStockItemPurchasing Then
        If mfrm.FormController.IsBulkOrdering = vIsBulkOrdering And mfrm.MdiParent Is rMDIParent Then

          mfrmWanted = mfrm
          mFound = True
          Exit For
        End If
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Private Sub LoadCombos()

    Dim mVIs As colValueItems

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.StockItemType)
    clsDEControlLoading.FillDERepComboVI(repCategory, mVIs)


    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItems, gcCategory, pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.StockItemCategory))

  End Sub

  Private Sub LoadGrids()
    grdStockItems.DataSource = pFormController.StockItemProcessors
  End Sub

  Private Sub barbtnLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnLoad.ItemClick
    Dim mStartActiveState As Boolean = pIsActive
    Dim mVI As clsValueItem
    mVI = bcboCategory.EditValue

    pIsActive = False
    gvStockItems.BeginDataUpdate()
    ''UpdateObject()
    If mVI IsNot Nothing Then
      pFormController.LoadStockItems(mVI.ItemValue)
    End If

    gvStockItems.EndDataUpdate()
    LoadGrids()
    ''RefreshControls()

    pIsActive = mStartActiveState
  End Sub

  Private Sub repitpucAllocations_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repitpucAllocations.QueryPopUp
    Dim mAllocations As New colMaterialRequirementInfos

    Dim mStockItemID As Integer
    Dim mSIP As clsStockItemProcessor

    mSIP = gvStockItems.GetFocusedRow
    mStockItemID = mSIP.StockItemID

    pFormController.LoadMatReqInfos(mAllocations, mStockItemID)
    grdStockItemAllocations.DataSource = mAllocations



  End Sub

  Private Sub repitpucOrders_QueryPopUp(sender As Object, e As CancelEventArgs) Handles repitpucOrders.QueryPopUp
    Dim mPOIAInfos As New colPurchaseOrderItemAllocationInfos
    Dim mStockItemID As Integer
    Dim mSIP As clsStockItemProcessor

    mSIP = gvStockItems.GetFocusedRow
    mStockItemID = mSIP.StockItemID
    pFormController.LoadPurchaseOrderItemAllocationInfos(mPOIAInfos, mStockItemID)
    grdOrders.DataSource = mPOIAInfos
  End Sub

  Private Sub bsubitProcessToPO_Popup(sender As Object, e As EventArgs) Handles bsubitProcessToPO.Popup
    Dim mPO As dmPurchaseOrder

    gvStockItems.CloseEditor()

    For Each mItem As DevExpress.XtraBars.BarButtonItemLink In bsubitProcessToPO.ItemLinks
      mPO = TryCast(mItem.Item.Tag, dmPurchaseOrder)
      If mPO IsNot Nothing Then
        If mPO.Status <> ePurchaseOrderDueDateStatus.Confirmed Or mPO.PurchaseOrderID = 0 Then
          mItem.Item.Enabled = False
        End If
      End If
    Next
  End Sub

  Private Sub gvStockItems_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvStockItems.CustomDrawCell
    If gvStockItems.IsDataRow(e.RowHandle) AndAlso (e.Column.Name <> gcToOrder.Name) Then
      Dim mFocusedRow As clsStockItemProcessor
      Dim mCurrentRow As clsStockItemProcessor
      mFocusedRow = TryCast(gvStockItems.GetFocusedRow, clsStockItemProcessor)
      mCurrentRow = TryCast(gvStockItems.GetRow(e.RowHandle), clsStockItemProcessor)
      If mCurrentRow IsNot Nothing AndAlso mFocusedRow IsNot Nothing Then
        If gvStockItems.FocusedRowHandle <> e.RowHandle Then
          If mCurrentRow.StockItemID = mFocusedRow.StockItemID Then
            e.Appearance.BackColor = Color.LightSteelBlue
            e.Appearance.ForeColor = Color.Black
          Else
            e.Appearance.BackColor = Color.Empty
          End If
        End If
      End If
    End If
  End Sub

End Class