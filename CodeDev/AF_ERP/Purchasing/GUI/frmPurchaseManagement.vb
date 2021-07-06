Imports RTIS.Elements
Imports RTIS.CommonVB
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu

Public Class frmPurchaseManagement
  Private pFormController As fccPurchaseManagement
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private WithEvents pStatusGridMenu As GridViewMenu
  Private pProcessQtyRequired As Integer
  Private pProcessQtyComplete As Integer

  Private pQtyDoorsets As Integer
  Private pQtyDoorLeaves As Integer
  Private pQtyDoorFrames As Integer


  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Shared Sub OpenForm(ByVal vRTISGlobal As AppRTISGlobal, ByVal vDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vMDIForm As Form)
    Dim mfrm As frmPurchaseManagement = Nothing

    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmPurchaseManagement
      mfrm.pFormController = New fccPurchaseManagement(vDBConn)
      mfrm.MdiParent = vMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmPurchaseManagement
    Dim mfrmWanted As frmPurchaseManagement = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPurchaseManagement
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPurchaseManagement Then
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

  Private Sub frmProductionTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadCombos()

    Create_GridMenu()

    pFormController.LoadObject()
    grdSOPMatReqStatuses.DataSource = pFormController.WorkOrderInfos


    Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

  End Sub

  Private Sub LoadCombos()
    '  clsDEControlLoading.FillDEComboVIi(cboProcessMinuteStatus, clsEnumsConstants.EnumToVIs(GetType(eProcessMinuteStatus)))

  End Sub

  Private Sub frmProductionTracking_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    'FormController.ClearObjects()

    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub


  Private Function ProcessFromColumn(ByVal vColumn As DevExpress.XtraGrid.Columns.GridColumn) As Integer
    Dim mProcess As Integer = -1

    'Select Case vColumn.FieldName
    '  Case gcBeamSawProgress.FieldName
    '    mProcess = CInt(eProductionProcess.BeamSaw)
    '  Case gcEgeBanderProgress.FieldName
    '    mProcess = CInt(eProductionProcess.EdgeBander)
    '  Case gcPressProgress.FieldName
    '    mProcess = CInt(eProductionProcess.Press)
    '  Case gcDoorCNCProgress.FieldName
    '    mProcess = CInt(eProductionProcess.DoorCNC)
    '  Case gcDoorSprayShopProgress.FieldName
    '    mProcess = CInt(eProductionProcess.DoorSprayShop)
    '  Case gcFrameComponentsProgress.FieldName
    '    mProcess = CInt(eProductionProcess.FrameComponents)
    '  Case gcFrameMachiningProgress.FieldName
    '    mProcess = CInt(eProductionProcess.FrameMachining)
    '  Case gcFrameSprayShopProgress.FieldName
    '    mProcess = CInt(eProductionProcess.FrameSprayShop)
    '  Case gcAssemblyProgress.FieldName
    '    mProcess = CInt(eProductionProcess.Assembly)
    '  Case gcDespatchProgress.FieldName
    '    mProcess = CInt(eProductionProcess.Despatch)

    'End Select

    Return mProcess
  End Function

  Private Sub gvOrderPhase_CustomDrawGroupRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gvSOPMatReqStatuses.CustomDrawGroupRow
    Dim mView As DevExpress.XtraGrid.Views.Grid.GridView = sender
    Dim mInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)

    If IsDate(mView.GetGroupRowValue(e.RowHandle, mInfo.Column)) Then
      Dim mVal As DateTime = mView.GetGroupRowValue(e.RowHandle, mInfo.Column)

      If RTIS.CommonVB.clsGeneralA.IsBlankDate(mVal) Then
        mInfo.GroupText = "No Planificada"
      Else
        mInfo.GroupText = "Semana: " & mVal.ToString("dd/MM/yyyy")
      End If
    End If

  End Sub

  Private Sub barbtnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnRefresh.ItemClick
    Try
      pFormController.LoadObject()

      grdSOPMatReqStatuses.DataSource = pFormController.WorkOrderInfos
      gvSOPMatReqStatuses.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub gvProductionBatch_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles gvSOPMatReqStatuses.CustomSummaryCalculate


    If (e.Item.ShowInGroupColumnFooterName = "gcQtyCol") Then

      If (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start) Then
        pQtyDoorsets = 0
        pQtyDoorLeaves = 0
        pQtyDoorFrames = 0
        e.TotalValue = 0
      End If

      If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
        Dim mRow As clsWorkOrderInfo = TryCast(e.Row, clsWorkOrderInfo)

        If mRow IsNot Nothing Then

          'pQtyDoorsets += mRow.QtyDoorSets
          'pQtyDoorLeaves += mRow.QtyDoorLeaves
          'pQtyDoorFrames += mRow.QtyFrames

        End If

      End If

      If (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize) Then

        If (pQtyDoorsets > 0 Or pQtyDoorLeaves > 0 Or pQtyDoorFrames > 0) Then
          e.TotalValue = String.Format("{0} / {1} / {2}", pQtyDoorsets, pQtyDoorLeaves, pQtyDoorFrames)
        Else
          e.TotalValue = String.Empty
        End If

      End If

    Else

      If (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start) Then
        pProcessQtyRequired = 0
        pProcessQtyComplete = 0
        e.TotalValue = 0
      End If

      If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
        Dim mRow As clsWorkOrderInfo = TryCast(e.Row, clsWorkOrderInfo)
        Dim mCol As DevExpress.XtraGrid.Columns.GridColumn = gvSOPMatReqStatuses.Columns.ColumnByName(e.Item.ShowInGroupColumnFooterName)

        'If mRow IsNot Nothing AndAlso mCol IsNot Nothing Then
        '  Dim mProcessID As Integer = ProcessFromColumn(mCol)

        '  Dim mRouteStep As dmRouteStep = mRow.RouteSteps.ItemFromProcessID(mProcessID)

        '  If mRouteStep IsNot Nothing Then

        '    If mRouteStep.Status <> eRouteStepStatus.NotRequired Then
        '      pProcessQtyRequired += mRouteStep.Minutes
        '    End If

        '    Select Case mRouteStep.Status
        '      Case eRouteStepStatus.PartialComplete
        '        pProcessQtyComplete += (Math.Ceiling(mRouteStep.Minutes / 2))
        '      Case eRouteStepStatus.Complete
        '        pProcessQtyComplete += mRouteStep.Minutes
        '    End Select

        '  End If

        'End If

      End If

      If (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize) Then

        If (pProcessQtyRequired > 0 Or pProcessQtyComplete > 0) Then
          e.TotalValue = String.Format("{0} / {1}", pProcessQtyComplete, pProcessQtyRequired)
        Else
          e.TotalValue = String.Empty
        End If

      End If

    End If



  End Sub

  Private Sub barbt_ExportToExcel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbt_ExportToExcel.ItemClick
    Dim mOptions As DevExpress.XtraPrinting.XlsxExportOptions
    Dim mOptionsEx As DevExpress.XtraPrinting.XlsxExportOptionsEx
    Dim mFileName As String

    Try

      Cursor = Cursors.WaitCursor

      mOptions = New DevExpress.XtraPrinting.XlsxExportOptions
      mOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx

      mOptionsEx.ExportType = DevExpress.Export.ExportType.WYSIWYG

      mFileName = "Production_Tracking" & "_" & Format(Date.Now, "yyyyMMdd_HHmm")
      clsGeneralA.GetSaveFileName(mFileName, "Export Grid To Excel", , "Excel Files (*.xlsx)|*.xlsx", , , , "*.xlsx")

      Me.grdSOPMatReqStatuses.ExportToXlsx(mFileName, mOptionsEx)

      Cursor = Cursors.Default

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvProductionBatch_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvSOPMatReqStatuses.RowCellStyle
    Dim mPOCountRealsed As Integer

    Try
      Select Case e.Column.Name
        Case gcVidrioEspejos.Name, gcDoorBlanks.Name, gcMatVarios.Name, gcMatEmpa.Name, gcAbrasivos.Name,
             gcMatElect.Name, gcPlumbing.Name, gcHerrajes.Name, gcBrickwork.Name, gcEpp.Name, gcLamina.Name, gcHerramientas.Name
          Dim mRow As clsWorkOrderInfo = gvSOPMatReqStatuses.GetRow(e.RowHandle)
          Dim mStatus As dmWorkOrderMatReqCategoryStatus

          Dim mStatusID As Integer
          If mRow IsNot Nothing Then

            'mPOCountRealsed = pFormController.PurchaseOrderInfos.GetLivePOCountByCategory(e.Column.Tag, mRow.sale)
            mStatus = mRow.WorkOrder.WorkOrderMatReqCategoryStatuss.ItemFromCategory(e.Column.Tag)

            If mStatus Is Nothing Then
              mStatusID = eMatReqCategoryStatus.Pending
            Else
              mStatusID = mStatus.Status
            End If
            Select Case mStatusID
              Case eMatReqCategoryStatus.Pending
                If RTIS.CommonVB.clsGeneralA.IsBlankDate(mRow.PlannedStartDate) Then
                  e.Appearance.BackColor = Color.White
                Else
                  If Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.PlannedStartDate).AddDays(-21) Then
                    e.Appearance.BackColor = Color.Tomato
                  Else
                    e.Appearance.BackColor = Color.White
                  End If
                End If
              Case eMatReqCategoryStatus.NotRequired
                e.Appearance.BackColor = Color.Lavender
              Case eMatReqCategoryStatus.Stock
                e.Appearance.BackColor = Color.LightSkyBlue
              Case eMatReqCategoryStatus.ToPlace
                e.Appearance.BackColor = Color.Pink
              Case eMatReqCategoryStatus.Ordered
                e.Appearance.BackColor = Color.Gold
              Case eMatReqCategoryStatus.Received
                e.Appearance.BackColor = Color.YellowGreen
            End Select

          End If
          e.Appearance.ForeColor = Color.Black
      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvSOPMatReqStatuses_DoubleClick(sender As Object, e As EventArgs) Handles gvSOPMatReqStatuses.DoubleClick
    Dim mWorkOrderInfo As clsWorkOrderInfo
    Dim mworkOrderID As Integer
    Dim mCategory As eStockItemCategory
    Dim mSalesOrderPhaseMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus
    Dim mColTag As Object

    Try

      If gvSOPMatReqStatuses.FocusedRowHandle >= 0 Then
        mColTag = gvSOPMatReqStatuses.FocusedColumn.Tag
        If IsNumeric(mColTag) Then
          mCategory = CType(mColTag, eStockItemCategory)
          mWorkOrderInfo = CType(gvSOPMatReqStatuses.GetFocusedRow, clsWorkOrderInfo)
          mworkOrderID = mWorkOrderInfo.WorkOrderID

          mSalesOrderPhaseMatReqCategoryStatus = mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.ItemFromCategory(mCategory)
          If mSalesOrderPhaseMatReqCategoryStatus Is Nothing Then
            mSalesOrderPhaseMatReqCategoryStatus = pFormController.GetSOPMatReqCategoryStatus(mworkOrderID, mCategory)
            If mSalesOrderPhaseMatReqCategoryStatus Is Nothing Then
              mSalesOrderPhaseMatReqCategoryStatus = New dmWorkOrderMatReqCategoryStatus
            End If
            mSalesOrderPhaseMatReqCategoryStatus.MatReqCategory = mCategory
            mSalesOrderPhaseMatReqCategoryStatus.WorkOrderID = mworkOrderID
            mSalesOrderPhaseMatReqCategoryStatus.Status = eMatReqCategoryStatus.Pending
            mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.Add(mSalesOrderPhaseMatReqCategoryStatus)
          End If

          If mWorkOrderInfo.FinishDate = Date.MinValue Then
            frmWorkOrderMatReqCategoryStatusDetail.OpenForm(Me, pFormController.DBConn, mSalesOrderPhaseMatReqCategoryStatus, mworkOrderID, mCategory, frmWorkOrderMatReqCategoryStatusDetail.eForm.ReadWriteForm)

          Else

            frmWorkOrderMatReqCategoryStatusDetail.OpenForm(Me, pFormController.DBConn, mSalesOrderPhaseMatReqCategoryStatus, mworkOrderID, mCategory, frmWorkOrderMatReqCategoryStatusDetail.eForm.ReadOnlyForm)

          End If

          gvSOPMatReqStatuses.RefreshRow(gvSOPMatReqStatuses.FocusedRowHandle)
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvSOPMatReqStatuses_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvSOPMatReqStatuses.CustomUnboundColumnData
    Dim mWorkOrderInfo As clsWorkOrderInfo
    Dim mCategory As eStockItemCategory
    Dim mSalesOrderPhaseMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus
    Dim mColTag As Object
    Dim mText As String = ""
    Dim mPickText As String = ""

    Try
      If e.IsGetData Then

        mColTag = e.Column.Tag
        If IsNumeric(mColTag) Then
          mCategory = CType(mColTag, eStockItemCategory)
          mWorkOrderInfo = CType(e.Row, clsWorkOrderInfo)

          mSalesOrderPhaseMatReqCategoryStatus = mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.ItemFromCategory(mCategory)
          If mSalesOrderPhaseMatReqCategoryStatus IsNot Nothing Then
            Select Case mSalesOrderPhaseMatReqCategoryStatus.Status
              Case eMatReqCategoryStatus.NotRequired
                mText = "-"
              Case eMatReqCategoryStatus.Stock
                mText = "De Inventario"
              Case eMatReqCategoryStatus.ToPlace
                mText = "A Pedir"
              Case eMatReqCategoryStatus.Pending
                mText = ""
              Case eMatReqCategoryStatus.Ordered
                If mSalesOrderPhaseMatReqCategoryStatus.LastDate = Date.MinValue Then
                  mText = ""
                Else
                  mText = mSalesOrderPhaseMatReqCategoryStatus.LastDate.ToString("dd/MM/yyyy")
                End If

              Case eMatReqCategoryStatus.Received
                If mSalesOrderPhaseMatReqCategoryStatus.LastDate = Date.MinValue Then
                  mText = ""
                Else
                  mText = mSalesOrderPhaseMatReqCategoryStatus.LastDate.ToString("dd/MM/yyyy")
                End If

            End Select
            Select Case CInt(mSalesOrderPhaseMatReqCategoryStatus.PickStatus)
              Case eStatusNonePartComplete.Part
                mPickText = "Recibido Parcial"
              Case eStatusNonePartComplete.Complete
                mPickText = "Recibido"
            End Select
            If mPickText <> "" Then
              If mText <> "" Then mText &= vbCrLf
              mText &= mPickText
            End If
            e.Value = mText
          Else

          End If
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvSOPMatReqStatuses_MouseUp(sender As Object, e As MouseEventArgs) Handles gvSOPMatReqStatuses.MouseUp

    Try


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub Create_GridMenu()
    Dim mMenuItem As DevExpress.Utils.Menu.DXMenuItem

    AddHandler gvSOPMatReqStatuses.PopupMenuShowing, AddressOf gvSOPMatReqStatuses_PopupMenuShowing

    pStatusGridMenu = New GridViewMenu(gvSOPMatReqStatuses)

    mMenuItem = New DevExpress.Utils.Menu.DXMenuItem("Not Required")
    mMenuItem.Tag = 1
    pStatusGridMenu.Items.Add(mMenuItem)
    mMenuItem = New DevExpress.Utils.Menu.DXMenuItem("From Stock")
    mMenuItem.Tag = 2
    pStatusGridMenu.Items.Add(mMenuItem)
    mMenuItem = New DevExpress.Utils.Menu.DXMenuItem("To Place")
    mMenuItem.Tag = 3
    pStatusGridMenu.Items.Add(mMenuItem)

  End Sub


  Private Sub gvSOPMatReqStatuses_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
    Dim mWorkOrderInfo As clsWorkOrderInfo
    Dim mSalesOrderPhaseMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus
    Dim mColTag As Object
    Dim mCategory As Int32
    Dim mAllow As Boolean

    Try

      If gvSOPMatReqStatuses.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle Then
        Exit Sub
      End If

      mColTag = gvSOPMatReqStatuses.FocusedColumn.Tag
      If IsNumeric(mColTag) Then
        mCategory = CType(Val(mColTag), System.Int32)
      Else
        mCategory = 0
      End If
      If mCategory > 0 And mCategory < 12 Then
        mWorkOrderInfo = gvSOPMatReqStatuses.GetRow(gvSOPMatReqStatuses.FocusedRowHandle)

        If mWorkOrderInfo IsNot Nothing Then
          mSalesOrderPhaseMatReqCategoryStatus = mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.ItemFromCategory(mCategory)
          If mSalesOrderPhaseMatReqCategoryStatus IsNot Nothing Then
            Select Case mSalesOrderPhaseMatReqCategoryStatus.Status
              Case eMatReqCategoryStatus.Pending, eMatReqCategoryStatus.NotRequired, eMatReqCategoryStatus.Stock, eMatReqCategoryStatus.ToPlace
                mAllow = True
              Case Else
                mAllow = False
            End Select
          Else
            mAllow = True
          End If
        End If
      End If

      e.Allow = mAllow
      e.Menu = pStatusGridMenu

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub pStatusGridMenu_ItemClick(sender As Object, e As DXMenuItemEventArgs) Handles pStatusGridMenu.ItemClick
    Dim mdso As dsoPurchasing
    Dim mWorkOrderInfo As clsWorkOrderInfo
    Dim mworkOrderID As Int32
    Dim mCategory As eStockItemCategory
    Dim mStatus As eMatReqCategoryStatus
    Dim mSalesOrderPhaseMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus
    Dim mColTag As Object
    Dim mTagNo As Int32
    Dim mMenuTag As Object
    Dim mMenuTagNo As Int32
    Dim mCaption As String

    Try
      mColTag = gvSOPMatReqStatuses.FocusedColumn.Tag
      If IsNumeric(mColTag) Then
        mTagNo = CType(Val(mColTag), System.Int32)
        mCategory = mTagNo
      Else
        mTagNo = 0
        Exit Sub
      End If

      mMenuTag = e.Item.Tag
      mMenuTagNo = CType(Val(mMenuTag), System.Int32)
      mCaption = e.Item.Caption

      mWorkOrderInfo = CType(gvSOPMatReqStatuses.GetFocusedRow, clsWorkOrderInfo)
      mworkOrderID = mWorkOrderInfo.WorkOrderID

      Select Case mMenuTagNo
        Case 1
          mStatus = eMatReqCategoryStatus.NotRequired
        Case 2
          mStatus = eMatReqCategoryStatus.Stock
        Case 3
          mStatus = eMatReqCategoryStatus.ToPlace
        Case Else
          mStatus = eMatReqCategoryStatus.NotRequired
      End Select


      mSalesOrderPhaseMatReqCategoryStatus = mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.ItemFromCategory(mCategory)
      If mSalesOrderPhaseMatReqCategoryStatus Is Nothing Then
        mSalesOrderPhaseMatReqCategoryStatus = pFormController.GetSOPMatReqCategoryStatus(mworkOrderID, mCategory)
        If mSalesOrderPhaseMatReqCategoryStatus Is Nothing Then
          mSalesOrderPhaseMatReqCategoryStatus = New dmWorkOrderMatReqCategoryStatus
        End If
        mSalesOrderPhaseMatReqCategoryStatus.MatReqCategory = mCategory
        mSalesOrderPhaseMatReqCategoryStatus.WorkOrderID = mworkOrderID
        mSalesOrderPhaseMatReqCategoryStatus.Status = mStatus
        mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.Add(mSalesOrderPhaseMatReqCategoryStatus)
      Else
        mSalesOrderPhaseMatReqCategoryStatus.Status = mStatus
      End If


      mdso = New dsoPurchasing(pFormController.DBConn)
      mdso.SaveWorkOrderPhaseMatReqCategoryStatus(mSalesOrderPhaseMatReqCategoryStatus)

      gvSOPMatReqStatuses.RefreshRow(gvSOPMatReqStatuses.FocusedRowHandle)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btogIncludeRecentlyCompleted_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles btogIncludeRecentlyCompleted.CheckedChanged
    Dim mItem As BarToggleSwitchItem

    Try
      mItem = CType(sender, BarToggleSwitchItem)
      pFormController.IncludeRecentlyCompleted = mItem.Checked

      pFormController.LoadObject()

      grdSOPMatReqStatuses.DataSource = pFormController.WorkOrderInfos
      gvSOPMatReqStatuses.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub
End Class