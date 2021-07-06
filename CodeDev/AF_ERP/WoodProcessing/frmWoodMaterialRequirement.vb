Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmWoodMaterialRequirement
  Private pForceExit As Boolean
  Private pIsActive As Boolean
  Private pFormController As fccWoodMaterialRequirement
  Private pSpinEnter As Boolean
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer


  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenFormAsMDIChild(ByRef rMDI As Windows.Forms.Form, ByRef rRTISGlobal As AppRTISGlobal, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vSalesOrderPhaseID As Integer)
    Dim mfrm As frmWoodMaterialRequirement = Nothing

    mfrm = GetFormIfLoaded(rMDI)
    If mfrm Is Nothing Then
      mfrm = New frmWoodMaterialRequirement
      mfrm.pFormController = New fccWoodMaterialRequirement()
      mfrm.pFormController.RTISGlobal = rRTISGlobal
      mfrm.pFormController.DBConn = rDBConn
      mfrm.pFormController.SalesOrderPhaseID = vSalesOrderPhaseID
      mfrm.MdiParent = rMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vMdi As Windows.Forms.Form) As frmWoodMaterialRequirement
    Dim mfrmWanted As frmWoodMaterialRequirement = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWoodMaterialRequirement
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmWoodMaterialRequirement And mfrm.MdiParent Is vMdi Then
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


  Public Property FormController() As fccWoodMaterialRequirement
    Get
      Return pFormController
    End Get
    Set(value As fccWoodMaterialRequirement)
      pFormController = value
    End Set
  End Property

  Private Sub ReloadRequirements()
    Try
      pFormController.LoadMatReqs()
      grdMaterialRequirements.DataSource = pFormController.MatReqItemProcessors
    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmWoodMaterialRequirements_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False

    Try
      mOK = True

      'If pFormController.ViewMode = fccWoodMaterialRequirement.eViewMode.ViewOnly Then
      '  Bar1.Visible = False
      '  gcMatReqFromStock.Visible = False
      '  gcMatReqToOrder.Visible = False
      '  grpMaterialRequirements.CustomHeaderButtons(0).Properties.Visible = True
      '  Me.Text = "Live Contracts Stock Overview"

      '  gcFromStock.Visible = False
      'End If

      SetPermissions()
      LoadCombos()
      ReloadRequirements()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockitemTrans, gcSITranTranType, clsEnumsConstants.EnumToVIs(GetType(eTransactionType)))
    '  clsDEControlLoading.LoadGridLookUpEditiVI(grdStockitemTrans, gcSITranUserID, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.UserList))
  End Sub

  Private Sub SetPermissions()
    Dim mPermissionCode As ePermissionCode = pFormController.DBConn.RTISUser.ActivityPermission(eActivityCode.SetFromStockQty)

    If mPermissionCode = ePermissionCode.ePC_Full Then
    Else
      gcFromStock.Visible = False
      gcQuantityFromStock.Visible = False

      bbtnSetAllFromStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      bbtnProcessFromStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End If

  End Sub

  Private Sub UpdateObject()

    'Make sure all grid controls etc. finished current edit
    Try

      Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView

      mGridView = grdMaterialRequirements.MainView

      If mGridView IsNot Nothing Then
        mGridView.CloseEditor()
        mGridView.UpdateCurrentRow()
      End If

    Catch Ex As Exception
      If Debugger.IsAttached Then MsgBox("UpdateObject-Focus: " & Ex.Message)
    End Try



  End Sub

  Private Sub bbtnClearToOrderFromStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnClearToOrderFromStock.ItemClick
    UpdateObject()
    pFormController.ClearMatReqProcs()
    gvMaterialRequirements.RefreshData()
  End Sub


  Private Sub bbtnSetAllFromStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSetAllFromStock.ItemClick
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mRowHandle As Integer

    UpdateObject()

    mGridView = gvMaterialRequirements

    For mItemCount As Integer = 0 To mGridView.RowCount - 1
      mRowHandle = mGridView.GetVisibleRowHandle(mItemCount)
      If mGridView.IsDataRow(mRowHandle) Then
        pFormController.SetQtyFromStock(mGridView.GetRow(mRowHandle))
      End If
    Next

    If mGridView IsNot Nothing Then
      mGridView.RefreshData()
    End If

  End Sub

  Private Sub bbtnSetAllToOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSetAllToOrder.ItemClick
    Dim mGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Dim mRowHandle As Integer

    UpdateObject()

    mGridView = gvMaterialRequirements

    For mItemCount As Integer = 0 To mGridView.RowCount - 1
      mRowHandle = mGridView.GetVisibleRowHandle(mItemCount)
      If mGridView.IsDataRow(mRowHandle) Then
        pFormController.SetBalQtyToOrder(mGridView.GetRow(mRowHandle))
      End If
    Next

    If mGridView IsNot Nothing Then
      mGridView.RefreshData()
    End If
  End Sub
  Private Sub bbtnProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnProcessFromStock.ItemClick
    Dim mCount As Integer
    Try
      UpdateObject()
      mCount = pFormController.ProcessFromStock()
      gvMaterialRequirements.RefreshData()
      MsgBox(mCount & " Artículos de cantidad de inventario actualizados.")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repItemSelected_EditValueChanged(sender As Object, e As EventArgs)
    UpdateObject()
    pFormController.LoadMatReqs()
    grdMaterialRequirements.DataSource = pFormController.MatReqItemProcessors
  End Sub

  Private Sub repItemQty_Enter(sender As Object, e As EventArgs) Handles repItemQty.Enter
    pSpinEnter = True
  End Sub

  Private Sub repItemQty_MouseUp(sender As Object, e As MouseEventArgs) Handles repItemQty.MouseUp
    If pSpinEnter Then sender.SelectAll()
    pSpinEnter = False
  End Sub

  Private Sub bbtnReloadRequirements_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnReloadRequirements.ItemClick
    ReloadRequirements()
  End Sub

  Private Sub barbtnExcelExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExcelExport.ItemClick
    Try
      Dim mFileName As String = String.Empty
      If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName, "ExcelExport", String.Empty, "Excel |*.xls") = DialogResult.OK Then
        grdMaterialRequirements.ExportToXls(mFileName)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub RepositoryItemPopupContainerEditOrderedQty_Popup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEditOrderedQty.ButtonClick
    Dim mRow As clsMaterialRequirementProcessor
    mRow = TryCast(gvMaterialRequirements.GetFocusedRow, clsMaterialRequirementProcessor)

    If mRow IsNot Nothing Then
      grdOnOrderOSQty.DataSource = mRow.POItemAllocationInfos
    Else
      grdOnOrderOSQty.DataSource = Nothing
    End If
  End Sub


  Private Sub gvMaterialRequirements_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvMaterialRequirements.CustomDrawCell
    If gvMaterialRequirements.IsDataRow(e.RowHandle) Then

      If (e.Column.Name <> gcFromStock.Name Or e.Column.Name <> gcMatReqToOrder.Name) Then
        Dim mFocusedRow As clsMaterialRequirementProcessor
        Dim mCurrentRow As clsMaterialRequirementProcessor
        mFocusedRow = TryCast(gvMaterialRequirements.GetFocusedRow, clsMaterialRequirementProcessor)
        mCurrentRow = TryCast(gvMaterialRequirements.GetRow(e.RowHandle), clsMaterialRequirementProcessor)
        If mCurrentRow IsNot Nothing AndAlso mFocusedRow IsNot Nothing Then
          If gvMaterialRequirements.FocusedRowHandle <> e.RowHandle Then
            If mCurrentRow.StockItem.StockItemID = mFocusedRow.StockItem.StockItemID Then
              e.Appearance.BackColor = Color.LightBlue
              e.Appearance.ForeColor = Color.Black
            Else
              e.Appearance.BackColor = Color.Empty
            End If

            If e.Column.Name = gcComments.Name Then
              If mCurrentRow.Comments <> String.Empty Then
                e.Appearance.BackColor = Color.LightYellow
                e.Appearance.ForeColor = Color.Black
              Else
                e.Appearance.BackColor = Color.Empty
              End If

            End If

          End If



        End If


      End If


      If (e.Column.Name = gcFromStock.Name Or e.Column.Name = gcMatReqToOrder.Name) Then
        e.Appearance.BackColor = Color.LightCyan
        e.Appearance.ForeColor = Color.Black
      End If



    End If
  End Sub

  Private Sub grpMaterialRequirements_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpMaterialRequirements.CustomButtonClick
    ReloadRequirements()
  End Sub

  Private Sub frmWoodMaterialRequirement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    Try

      If sActiveForms.Contains(Me.pMySharedIndex.ToString) Then
        sActiveForms.Remove(Me.pMySharedIndex.ToString)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub frmWoodMaterialRequirement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

  End Sub

  Private Sub bsubitProcessToPO_Popup(sender As Object, e As EventArgs) Handles bsubitProcessToPO.Popup
    Dim mPO As dmPurchaseOrder


    gvMaterialRequirements.CloseEditor()


    For Each mItem As DevExpress.XtraBars.BarButtonItemLink In bsubitProcessToPO.ItemLinks
      mPO = TryCast(mItem.Item.Tag, dmPurchaseOrder)
      If mPO IsNot Nothing Then

        mItem.Item.Enabled = True


        If mPO.Status <> ePurchaseOrderDueDateStatus.Confirmed Or mPO.PurchaseOrderID = 0 Then
          mItem.Item.Enabled = False
          pFormController.LoadMatReqs()
          grdMaterialRequirements.DataSource = pFormController.MatReqItemProcessors
          gvMaterialRequirements.RefreshData()
        End If
      End If
    Next
  End Sub

  Private Sub barbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnClose.ItemClick
    CloseForm()

  End Sub
  Private Sub ReposItemPopupContainerEditSITrans_Popup(sender As Object, e As EventArgs) Handles ReposItemPopupContainerEditSITrans.Popup
    Dim mRow As clsMaterialRequirementProcessor
    mRow = TryCast(gvMaterialRequirements.GetFocusedRow, clsMaterialRequirementProcessor)

    If mRow IsNot Nothing Then
      If mRow.StockItemTransactionInfoss.Count = 0 Then

        pFormController.LoadTransactions(mRow)
      End If
      grdStockitemTrans.DataSource = mRow.StockItemTransactionInfoss
    Else
      grdStockitemTrans.DataSource = Nothing
    End If
  End Sub


End Class