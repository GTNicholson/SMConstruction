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
  Private pViewOnly As Boolean

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsViewOnly As Boolean, ByVal vIsBulkOrdering As Boolean)
    Dim mfrm As frmStockItemPurchasing = Nothing

    mfrm = GetFormIfLoaded(vIsBulkOrdering, rMDIParent)
    If mfrm Is Nothing Then
      mfrm = New frmStockItemPurchasing
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStockItemPurchasing(rDBConn, rRTISGlobal)
      mfrm.pFormController.IsBulkOrdering = vIsBulkOrdering
      mfrm.pViewOnly = vIsViewOnly
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
    LoadCombos()
    pFormController.LoadObject()
    LoadGrids()
    ''RefreshCurrentCategory()
    ''RefreshCategoryRadioButton()
    SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
    ''RefreshControls()
    pIsActive = True
  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vIsBulkOrdering As Boolean, ByVal rMDIParent As Form) As frmStockItemPurchasing
    Dim mfrmWanted As frmStockItemPurchasing = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmStockItemPurchasing
    'Check if exisits already
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
    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItems, gcCategory, mVIs)

    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.Supplier)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItems, gcSupplier, mVIs)

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

    pFormController.LoadStockItems()


    gvStockItems.EndDataUpdate()
    LoadGrids()
    ''RefreshControls()

    pIsActive = mStartActiveState
  End Sub


End Class