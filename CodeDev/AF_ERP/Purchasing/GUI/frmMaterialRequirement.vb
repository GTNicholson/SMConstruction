Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmMaterialRequirement
  Private pForceExit As Boolean
  Private pIsActive As Boolean
  Private pFormController As fccMaterialRequirements
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

  Public Shared Sub OpenFormAsMDIChild(ByRef rMDI As Windows.Forms.Form, ByRef rRTISGlobal As AppRTISGlobal, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vSalesOrderPhaseID As Integer, ByVal vConsoleOptionView As ePOConsoleOption)
    Dim mfrm As frmMaterialRequirement = Nothing

    mfrm = GetFormIfLoaded(rMDI)
    If mfrm Is Nothing Then
      mfrm = New frmMaterialRequirement
      mfrm.pFormController = New fccMaterialRequirements()
      mfrm.pFormController.RTISGlobal = rRTISGlobal
      mfrm.pFormController.DBConn = rDBConn
      mfrm.pFormController.SalesOrderPhaseID = vSalesOrderPhaseID
      mfrm.pFormController.pConsoleOptionView = vConsoleOptionView
      mfrm.MdiParent = rMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vMdi As Windows.Forms.Form) As frmMaterialRequirement
    Dim mfrmWanted As frmMaterialRequirement = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmMaterialRequirement
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmMaterialRequirement And mfrm.MdiParent Is vMdi Then
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


  Public Property FormController() As fccMaterialRequirements
    Get
      Return pFormController
    End Get
    Set(value As fccMaterialRequirements)
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

  Private Sub frmMaterialRequirements_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False

    Try
      mOK = True

      'If pFormController.ViewMode = fccMaterialRequirements.eViewMode.ViewOnly Then
      '  Bar1.Visible = False
      '  gcMatReqFromStock.Visible = False
      '  gcMatReqToOrder.Visible = False
      '  grpMaterialRequirements.CustomHeaderButtons(0).Properties.Visible = True
      '  Me.Text = "Live Contracts Stock Overview"

      '  gcFromStock.Visible = False
      'End If
      pFormController.OptionView = fccMaterialRequirements.eMatReqOptionView.Hide
      cheOptionViews.EditValue = CType(pFormController.OptionView, System.Int32)

      Select Case pFormController.pConsoleOptionView
        Case ePOConsoleOption.Furniture
          gcWODescription.Visible = True
          gcWODescription.GroupIndex = 1
          gcSOIDescription.Visible = False
        Case ePOConsoleOption.Housing
          gcSOIDescription.Visible = True
          gcSOIDescription.GroupIndex = 1
          gcWODescription.Visible = False
      End Select

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
      ReloadRequirements()
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
    Dim mdso As New dsoPurchasing(pFormController.DBConn)
    Dim mwhere As String

    mRow = TryCast(gvMaterialRequirements.GetFocusedRow, clsMaterialRequirementProcessor)

    If mRow IsNot Nothing Then
      mwhere = String.Format("StockItemID ={0} and WorkOrderID = {1}", mRow.StockItem.StockItemID, mRow.MaterialRequirement.ObjectID)

      mdso.LoadPurchaseOrderItemAllocationInfos(mRow.POItemAllocationInfos, mwhere)

      grdOnOrderOSQty.DataSource = mRow.POItemAllocationInfos
    Else
      grdOnOrderOSQty.DataSource = Nothing
    End If
  End Sub


  Private Sub gvMaterialRequirements_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvMaterialRequirements.CustomDrawCell
    Dim mFocusedRow As clsMaterialRequirementProcessor
    Dim mCurrentRow As clsMaterialRequirementProcessor


    If gvMaterialRequirements.IsDataRow(e.RowHandle) Then

      If (e.Column.Name <> gcFromStock.Name Or e.Column.Name <> gcMatReqToOrder.Name) Then
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

      If (e.Column.Name = gcIsFromStockValidated.Name) Then
        mCurrentRow = TryCast(gvMaterialRequirements.GetRow(e.RowHandle), clsMaterialRequirementProcessor)

        If mCurrentRow IsNot Nothing Then

          If mCurrentRow.IsFromStockValidated Then

            e.Appearance.BackColor = Color.LightGreen

          Else
            e.Appearance.BackColor = Color.LightYellow
          End If
        End If

      End If

    End If
  End Sub

  Private Sub grpMaterialRequirements_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpMaterialRequirements.CustomButtonClick
    ReloadRequirements()
  End Sub

  Private Sub frmMaterialRequirement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    Try

      If sActiveForms.Contains(Me.pMySharedIndex.ToString) Then
        sActiveForms.Remove(Me.pMySharedIndex.ToString)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub frmMaterialRequirement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

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

  Private Sub repoItemPopupImage_Popup(sender As Object, e As EventArgs) Handles repoItemPopupImage.Popup
    Dim mRow As clsMaterialRequirementProcessor
    Dim mFileName As String
    Dim mSelectedStockItem As dmStockItem
    Dim mImage As Image = Nothing

    mRow = TryCast(gvMaterialRequirements.GetFocusedRow, clsMaterialRequirementProcessor)

    If mRow IsNot Nothing Then
      If mRow.StockItem.StockItemID > 0 Then

        mSelectedStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mRow.StockItem.StockItemID)

        If mSelectedStockItem IsNot Nothing Then
          If Not String.IsNullOrEmpty(mSelectedStockItem.ImageFile) Then

            mFileName = clsSMSharedFuncs.GetStockItemImageFileName(mSelectedStockItem)
            If IO.File.Exists(mFileName) Then
              mImage = Image.FromStream(New IO.MemoryStream(IO.File.ReadAllBytes(mFileName)))
              ''  mImage = Drawing.Image.FromFile(mFileName)

            Else
              mImage = Nothing

            End If

          End If
        End If

      End If
      peImage.Image = mImage
    Else


    End If
  End Sub


  Private Sub repoMatReqOptionView_EditValueChanged(sender As Object, e As EventArgs) Handles repoMatReqOptionView.EditValueChanged


  End Sub

  Private Sub repoMatReqOptionView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repoMatReqOptionView.SelectedIndexChanged
    Try
      Dim mviewOption As Integer
      Dim mItem As RadioGroup = TryCast(sender, RadioGroup)

      If pFormController IsNot Nothing Then

        mviewOption = mItem.EditValue
        pFormController.OptionView = mviewOption
        ReloadRequirements()


      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub

  Private Sub bbtnPickOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnPickOrder.ItemClick

  End Sub

  Private Sub repoChkIsFromStockValidated_CheckedChanged(sender As Object, e As EventArgs) Handles repoChkIsFromStockValidated.CheckedChanged
    Dim mRow As clsMaterialRequirementProcessor
    Dim mCheckedValue As Boolean

    If pIsActive Then

      If pFormController IsNot Nothing Then
        gvMaterialRequirements.CloseEditor()

        mRow = gvMaterialRequirements.GetFocusedRow

        If mRow IsNot Nothing Then
          mCheckedValue = repoChkIsFromStockValidated.ValueChecked
          pFormController.UpdateMaterialRequirementValidatedFromStock(mCheckedValue, mRow.MaterialRequirementID)

        End If

      End If

    End If
  End Sub

  Private Sub gvMaterialRequirements_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvMaterialRequirements.CustomUnboundColumnData
    Dim mRow As clsMaterialRequirementProcessor
    Try

      mRow = e.Row
      Select Case e.Column.Name
        Case gcStockItemLocationsQty.Name

          If mRow IsNot Nothing Then
            If e.IsGetData Then

              e.Value = mRow.StockItemLocationsQty - pFormController.MatReqItemProcessors.GetFromStockQty(mRow.MaterialRequirement.StockItemID)

            End If
          End If

        Case gcTotalFromStock.Name

          If mRow IsNot Nothing Then
            If e.IsGetData Then

              e.Value = pFormController.MatReqItemProcessors.GetFromStockQty(mRow.MaterialRequirement.StockItemID)

            End If
          End If
      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub

  Private Sub repoOpenPO_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoOpenPO.ButtonClick
    Dim mRow As clsPurchaseOrderItemAllocationInfo

    Try
      mRow = TryCast(gvOnOrderOSQty.GetFocusedRow, clsPurchaseOrderItemAllocationInfo)

      If mRow IsNot Nothing Then
        'Me.Hide()

        If mRow.PurchaseOrder.MaterialRequirementTypeWorkOrderID <> 0 Then
          frmManPurchaseOrderDetail.OpenFormMDI(gvOnOrderOSQty.GetFocusedRowCellValue(gvOnOrderOSQty.Columns("PurchaseOrderID")), pFormController.DBConn, AppRTISGlobal.GetInstance, ParentForm, ePODetailOption.ManPO)
        ElseIf mRow.PurchaseOrder.MaterialRequirementTypeID <> 0 Then

          frmNonManPurchaseOrder.OpenFormMDI(gvOnOrderOSQty.GetFocusedRowCellValue(gvOnOrderOSQty.Columns("PurchaseOrderID")), pFormController.DBConn, AppRTISGlobal.GetInstance, ParentForm, ePODetailOption.NonManPO)


        End If

        'Me.Show()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try
  End Sub
End Class