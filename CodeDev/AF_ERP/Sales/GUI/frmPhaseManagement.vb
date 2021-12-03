Imports RTIS.Elements
Imports RTIS.CommonVB
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils.Menu
Imports System.Reflection
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering

Public Class frmPhaseManagement
  Private pController As fccPhaseManagement
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private WithEvents pStatusGridMenu As GridViewMenu

  Public Enum eViewOptions
    All = 0
    BriefView = 1
    StandardView = 2
  End Enum
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
    Dim mfrm As frmPhaseManagement = Nothing

    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmPhaseManagement
      mfrm.pController = New fccPhaseManagement(vDBConn)
      mfrm.MdiParent = vMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmPhaseManagement
    Dim mfrmWanted As frmPhaseManagement = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmPhaseManagement
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmPhaseManagement Then
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

    'Create_GridMenu()

    pController.LoadObject()
    grdSOPMilestoneStatuses.DataSource = pController.SalesOrderPhaseInfos


    Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

  End Sub

  Private Sub LoadCombos()
    Dim mAllEmployees As RTIS.ERPCore.colEmployees = CType(AppRTISGlobal.GetInstance, iRefListHolder).RefLists.RefIList(appRefLists.Employees)
    Dim mOfficeEmployees As New RTIS.ERPCore.colEmployees

    '  clsDEControlLoading.FillDEComboVIi(cboProcessMinuteStatus, clsEnumsConstants.EnumToVIs(GetType(eProcessMinuteStatus)))
    repitcboColour.Items.Add("Green")
    repitcboColour.Items.Add("Grey")
    repitcboColour.Items.Add("Red")
    repitcboColour.Items.Add("White")
    repitcboColour.Items.Add("Yellow")




  End Sub


  Private Sub frmProductionTracking_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    'FormController.ClearObjects()

    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub


  Private Sub gvOrderPhase_CustomDrawGroupRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gvSOPMilestoneStatuses.CustomDrawGroupRow
    Dim mView As DevExpress.XtraGrid.Views.Grid.GridView = sender
    Dim mInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)

    If IsDate(mView.GetGroupRowValue(e.RowHandle, mInfo.Column)) Then
      Dim mVal As DateTime = mView.GetGroupRowValue(e.RowHandle, mInfo.Column)

      If RTIS.CommonVB.clsGeneralA.IsBlankDate(mVal) Then
        mInfo.GroupText = "No Planificado"
      Else
        mInfo.GroupText = "Semana: " & mVal.ToString("dd/MM/yyyy")
      End If
    End If

  End Sub

  Private Sub barbtnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      pController.LoadObject()

      grdSOPMilestoneStatuses.DataSource = pController.SalesOrderPhaseInfos
      gvSOPMilestoneStatuses.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private pProcessQtyRequired As Integer
  Private pProcessQtyComplete As Integer

  Private pQtyDoorsetsInt As Integer
  Private pQtyDoorLeavesInt As Integer
  Private pQtyDoorFramesInt As Integer

  Private pQtyDoorsetsExt As Integer
  Private pQtyDoorLeavesExt As Integer
  Private pQtyDoorFramesExt As Integer


  Private Sub gvProductionBatch_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles gvSOPMilestoneStatuses.CustomSummaryCalculate


    If (e.Item.ShowInGroupColumnFooterName = "gcQtyCol") Then

      If (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start) Then
        pQtyDoorsetsInt = 0
        pQtyDoorLeavesInt = 0
        pQtyDoorFramesInt = 0
        e.TotalValue = 0
      ElseIf e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
        Dim mRow As clsSalesOrderPhaseInfo = TryCast(e.Row, clsSalesOrderPhaseInfo)

        If mRow IsNot Nothing Then

          'pQtyDoorsetsInt += mRow.QtyDoorSetsInternal
          'pQtyDoorLeavesInt += mRow.QtyDoorLeavesInternal
          'pQtyDoorFramesInt += mRow.QtyFramesInternal

        End If

      ElseIf (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize) Then

        If (pQtyDoorsetsInt > 0 Or pQtyDoorLeavesInt > 0 Or pQtyDoorFramesInt > 0) Then
          e.TotalValue = String.Format("{0} / {1} / {2}", pQtyDoorsetsInt, pQtyDoorLeavesInt, pQtyDoorFramesInt)
        Else
          e.TotalValue = String.Empty
        End If

      End If
    ElseIf (e.Item.ShowInGroupColumnFooterName = "gcQtyColExt") Then

      If (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start) Then
        pQtyDoorsetsExt = 0
        pQtyDoorLeavesExt = 0
        pQtyDoorFramesExt = 0
        e.TotalValue = 0
      ElseIf e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
        Dim mRow As clsSalesOrderPhaseInfo = TryCast(e.Row, clsSalesOrderPhaseInfo)

        If mRow IsNot Nothing Then

          'pQtyDoorsetsExt += mRow.QtyDoorSetsExternal
          'pQtyDoorLeavesExt += mRow.QtyDoorLeavesExternal
          'pQtyDoorFramesExt += mRow.QtyFramesExternal

        End If

      ElseIf (e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize) Then

        If (pQtyDoorsetsExt > 0 Or pQtyDoorLeavesExt > 0 Or pQtyDoorFramesExt > 0) Then
          e.TotalValue = String.Format("{0} / {1} / {2}", pQtyDoorsetsExt, pQtyDoorLeavesExt, pQtyDoorFramesExt)
        Else
          e.TotalValue = String.Empty
        End If

      End If
    End If



  End Sub

  Private Sub barbt_ExportToExcel_ItemClick(sender As Object, e As ItemClickEventArgs)
    Dim mOptions As DevExpress.XtraPrinting.XlsxExportOptions
    Dim mOptionsEx As DevExpress.XtraPrinting.XlsxExportOptionsEx
    Dim mFileName As String

    Try

      Cursor = Cursors.WaitCursor

      mOptions = New DevExpress.XtraPrinting.XlsxExportOptions
      mOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx

      mOptionsEx.ExportType = DevExpress.Export.ExportType.WYSIWYG

      mFileName = "Milestone_Tracking" & "_" & Format(Date.Now, "yyyyMMdd_HHmm")
      clsGeneralA.GetSaveFileName(mFileName, "Export Grid To Excel", , "Excel Files (*.xlsx)|*.xlsx", , , , "*.xlsx")

      Me.grdSOPMilestoneStatuses.ExportToXlsx(mFileName, mOptionsEx)

      Cursor = Cursors.Default

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvSOPMilestoneStatuses_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvSOPMilestoneStatuses.RowCellStyle
    Try
      Dim mRow As clsSalesOrderPhaseInfo

      Select Case e.Column.Name
        Case gcOrderReceived.Name, gcHandover.Name, gcConfirmationOrder.Name, gcEngineering.Name, gcInstallation.Name,
              gcCarpinteria.Name, gcTapizado.Name, gcEmpaque.Name, gcMadera.Name, gcTejido.Name, gcAcabado.Name, gcLija.Name,
          gcMetal.Name, gcPurchasing.Name,
             gcDeliveryToSiteDate.Name
          'gcRFIMeetingArranged.Name,
          mRow = gvSOPMilestoneStatuses.GetRow(e.RowHandle)
          Dim mStatus As dmSalesOrderPhaseMilestoneStatus
          Dim mStatusID As Integer
          If mRow IsNot Nothing Then


            mStatus = mRow.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(e.Column.Tag)


            If mStatus Is Nothing Then
              mStatusID = eMilestoneStatus.Pending
            Else
              mStatusID = mStatus.Status
            End If
            Select Case mStatusID
              Case eMilestoneStatus.Pending
                If mStatus Is Nothing Then
                  If RTIS.CommonVB.clsGeneralA.IsBlankDate(mRow.DateRequired) Then
                    e.Appearance.BackColor = Color.White
                  Else
                    If Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.DateRequired).AddDays(-7) Then
                      e.Appearance.BackColor = Color.Tomato
                    ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.DateRequired) Then
                      e.Appearance.BackColor = Color.Gold
                    Else
                      e.Appearance.BackColor = Color.White
                    End If
                  End If
                Else
                  If Now >= mStatus.TargetDate Then
                    e.Appearance.BackColor = Color.Tomato
                  ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mStatus.TargetDate) Then
                    e.Appearance.BackColor = Color.Tomato
                  Else
                    e.Appearance.BackColor = Color.White
                  End If

                  'If mStatus.StartDate <> Date.MinValue Then
                  '  e.Appearance.BackColor = Color.Gold

                  'End If

                End If

              Case eMilestoneStatus.PartComplete

                If mStatus Is Nothing Then
                  If RTIS.CommonVB.clsGeneralA.IsBlankDate(mRow.DateRequired) Then
                    e.Appearance.BackColor = Color.White
                  Else


                    If Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.DateRequired).AddDays(-7) Then
                      e.Appearance.BackColor = Color.Gold
                    ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.DateRequired) Then
                      e.Appearance.BackColor = Color.Gold
                    Else
                      e.Appearance.BackColor = Color.White
                    End If


                  End If
                Else

                  If mStatus.StartDate <> Date.MinValue Then


                    If mStatus.TargetDate > mStatus.StartDate Then ''overdue
                      e.Appearance.BackColor = Color.Gold

                    ElseIf mStatus.TargetDate < mStatus.StartDate Then
                      e.Appearance.BackColor = Color.Gold


                    ElseIf Now >= mStatus.StartDate Then
                      e.Appearance.BackColor = Color.Gold

                    ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mStatus.StartDate) Then
                      e.Appearance.BackColor = Color.Gold
                    Else
                      e.Appearance.BackColor = Color.White

                    End If



                  Else

                    If Now >= mStatus.TargetDate Then
                      e.Appearance.BackColor = Color.Gold
                    ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mStatus.TargetDate) Then
                      e.Appearance.BackColor = Color.Gold
                    Else
                      e.Appearance.BackColor = Color.White
                    End If

                  End If

                End If

              Case eMilestoneStatus.NotRequired
                e.Appearance.BackColor = Color.Lavender
              'Case eMilestoneStatus.PartComplete
              '  e.Appearance.BackColor = Color.Gold
              Case eMilestoneStatus.Complete
                e.Appearance.BackColor = Color.YellowGreen
            End Select








          End If
          e.Appearance.ForeColor = Color.Black


      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvSOPMatReqStatuses_DoubleClick(sender As Object, e As EventArgs) Handles gvSOPMilestoneStatuses.DoubleClick
    Dim mSalesOrderPhaseInfo As clsSalesOrderPhaseInfo
    Dim mSalesOrderPhaseID As Integer
    Dim mMilestoneEnum As Integer
    Dim mSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus
    Dim mColTag As Object

    Try

      If gvSOPMilestoneStatuses.FocusedRowHandle >= 0 Then
        mColTag = gvSOPMilestoneStatuses.FocusedColumn.Tag
        If IsNumeric(mColTag) Then
          mMilestoneEnum = CType(mColTag, Integer)
          mSalesOrderPhaseInfo = CType(gvSOPMilestoneStatuses.GetFocusedRow, clsSalesOrderPhaseInfo)
          mSalesOrderPhaseID = mSalesOrderPhaseInfo.SalesOrderPhaseID

          mSalesOrderPhaseMilestoneStatus = mSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(mMilestoneEnum)
          If mSalesOrderPhaseMilestoneStatus Is Nothing Then
            mSalesOrderPhaseMilestoneStatus = New dmSalesOrderPhaseMilestoneStatus
            mSalesOrderPhaseMilestoneStatus.MilestoneENUM = mMilestoneEnum
            mSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID = mSalesOrderPhaseID
            mSalesOrderPhaseMilestoneStatus.Status = eMilestoneStatus.Pending
            mSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.Add(mSalesOrderPhaseMilestoneStatus)
          End If

          Select Case mMilestoneEnum
            Case eSalesOrderPhaseMileStone.Handover, eSalesOrderPhaseMileStone.ConfirmationOrder
              frmSalesOrderPhaseMilestoneStatusDetail_Handover.OpenForm(Me, pController.DBConn, mSalesOrderPhaseMilestoneStatus, mSalesOrderPhaseID, mMilestoneEnum)


            Case Else
              frmSalesOrderPhaseMilestoneStatusDetail.OpenForm(Me, pController.DBConn, mSalesOrderPhaseMilestoneStatus, mSalesOrderPhaseID, mMilestoneEnum)

              'If mMilestoneEnum = eSalesOrderPhaseMileStone.DeliveryToSiteDate Or mMilestoneEnum = eSalesOrderPhaseMileStone.Metales Or mMilestoneEnum = eSalesOrderPhaseMileStone.Handover Then

              '  pController.ReloadMilestonesForSalesOrderPhase(mSalesOrderPhaseInfo)


              'End If



          End Select

          gvSOPMilestoneStatuses.RefreshRow(gvSOPMilestoneStatuses.FocusedRowHandle)
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gvSOPMatReqStatuses_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvSOPMilestoneStatuses.CustomUnboundColumnData
    Dim mSalesOrderPhaseInfo As clsSalesOrderPhaseInfo
    Dim mMileStone As eMilestoneStatus
    Dim mSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus
    Dim mColTag As Object
    Dim mText As String = ""
    Dim mPickText As String = ""

    Try
      If e.IsGetData Then

        mColTag = e.Column.Tag
        If IsNumeric(mColTag) Then
          mMileStone = CType(mColTag, eMilestoneStatus)
          mSalesOrderPhaseInfo = CType(e.Row, clsSalesOrderPhaseInfo)

          mSalesOrderPhaseMilestoneStatus = mSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(mMileStone)
          If mSalesOrderPhaseMilestoneStatus IsNot Nothing Then

            Select Case mSalesOrderPhaseMilestoneStatus.Status
              Case eMilestoneStatus.NotRequired
                mText = "-"

              Case eMilestoneStatus.Pending

                If mSalesOrderPhaseMilestoneStatus.StartDate <> Date.MinValue Then

                  If clsGeneralA.IsBlankDate(mSalesOrderPhaseMilestoneStatus.TargetDate) = False Then
                    mText = mSalesOrderPhaseMilestoneStatus.TargetDate.ToString("dd-MMM")
                    mText = mText & vbCrLf
                    mText = mText & "Inic.:" & mSalesOrderPhaseMilestoneStatus.StartDate.ToString("dd-MMM")
                  Else
                    mText = "-"
                  End If

                Else
                  If clsGeneralA.IsBlankDate(mSalesOrderPhaseMilestoneStatus.TargetDate) = False Then
                    mText = mSalesOrderPhaseMilestoneStatus.TargetDate.ToString("dd-MMM")
                  Else
                    mText = "-"
                  End If

                End If

              Case eMilestoneStatus.PartComplete
                If mSalesOrderPhaseMilestoneStatus.StartDate <> Date.MinValue Then

                  If clsGeneralA.IsBlankDate(mSalesOrderPhaseMilestoneStatus.TargetDate) = False Then
                    mText = mSalesOrderPhaseMilestoneStatus.TargetDate.ToString("dd-MMM")
                    mText = mText & vbCrLf
                    mText = mText & "Inic.:" & mSalesOrderPhaseMilestoneStatus.StartDate.ToString("dd-MMM")
                  Else
                    mText = "-"
                  End If

                Else
                  If clsGeneralA.IsBlankDate(mSalesOrderPhaseMilestoneStatus.TargetDate) = False Then
                    mText = mSalesOrderPhaseMilestoneStatus.TargetDate.ToString("dd-MMM")
                  Else
                    mText = "-"
                  End If

                End If

              Case eMilestoneStatus.Complete

                If clsGeneralA.IsBlankDate(mSalesOrderPhaseMilestoneStatus.TargetDate) = False Then
                  mText = mSalesOrderPhaseMilestoneStatus.TargetDate.ToString("dd-MMM")
                  mText = mText & vbCrLf
                  mText = mText & "Comp.:" & mSalesOrderPhaseMilestoneStatus.ActualDate.ToString("dd-MMM")
                  mText &= vbCrLf & DateDiff(DateInterval.Day, mSalesOrderPhaseMilestoneStatus.TargetDate, mSalesOrderPhaseMilestoneStatus.ActualDate).ToString("+0;-#")
                End If

            End Select

            ' End Select



            'If mSalesOrderPhaseMilestoneStatus.MilestoneENUM = eSalesOrderPhaseMileStone.Metales Then
            '  mText = pController.GetCurrentTargetScheduleApprovedColumnInfo(mSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID)

            'End If

            'If mSalesOrderPhaseMilestoneStatus.MilestoneENUM = eSalesOrderPhaseMileStone.ThirddPartyOrdersPlaced Then
            '  mText = pController.GetCurrentTargetThirdPartyOrdersPlacedColumnInfo(mSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID)

            'End If

            'If mSalesOrderPhaseMilestoneStatus.MilestoneENUM = eSalesOrderPhaseMileStone.IronmongeryOrdered Then
            '  mText = pController.GetCurrentTargetIronmongeryOrderedColumnInfo(mSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID)

            'End If

            If Not String.IsNullOrWhiteSpace(mSalesOrderPhaseMilestoneStatus.Notes) Then
              mText &= " (*)"
            End If
            e.Value = mText
          Else

          End If
        End If
      End If

      If e.Column.Name = gcOrderReceivedDate.Name Then


        If e.IsSetData Then
          mSalesOrderPhaseInfo = e.Row

          If mSalesOrderPhaseInfo IsNot Nothing Then
            mSalesOrderPhaseInfo.OrderReceivedDateMileStone = e.Value
            mSalesOrderPhaseInfo.SalesOrderPhase.DateCreated = e.Value
            ''Update the Order Received Date for the Sales Order Phase selected
            If mSalesOrderPhaseInfo.OrderReceivedDateMileStone <> Date.MinValue Then

              pController.UpdateOrderReceivedDate(mSalesOrderPhaseInfo.OrderReceivedDateMileStone, mSalesOrderPhaseInfo.SalesOrderPhaseID)

              CreateUpdateMilesStoneOrderReceivedOnly(mSalesOrderPhaseInfo, mSalesOrderPhaseInfo.OrderReceivedDateMileStone)

              mSalesOrderPhaseMilestoneStatus = mSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(eSalesOrderPhaseMileStone.ConfirmationOrder)

              If mSalesOrderPhaseMilestoneStatus IsNot Nothing Then
                clsMilestoneHandler.UpdateSalesOrderPhaseMileStones(pController.DBConn, mSalesOrderPhaseInfo.SalesOrderPhaseID, mSalesOrderPhaseMilestoneStatus.MilestoneENUM, mSalesOrderPhaseInfo.OrderReceivedDateMileStone, mSalesOrderPhaseInfo.SalesOrderPhase.ManReqDays)
                pController.ReloadMilestonesForSalesOrderPhase(mSalesOrderPhaseInfo)
                gvSOPMilestoneStatuses.RefreshRow(gvSOPMilestoneStatuses.FocusedRowHandle)
              End If


            End If

          End If

        ElseIf e.IsGetData Then
          mSalesOrderPhaseInfo = e.Row
          e.Value = mSalesOrderPhaseInfo.OrderReceivedDateMileStone
        End If



      End If

      If e.Column.Name = gcAdvance.Name Then

        If e.IsGetData Then
          Dim mVal As Decimal
          Dim mSOPI As clsSalesOrderPhaseInfo

          mSOPI = e.Row

          If mSOPI IsNot Nothing Then

            mVal = mSOPI.SalesOrderPhaseMilestoneStatuss.GetAdvancePercentage()

          End If

          e.Value = mVal


        End If

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub



  Private Sub CreateUpdateMilesStoneOrderReceivedOnly(ByRef rSalesOrderPhaseInfo As clsSalesOrderPhaseInfo, ByVal vTargetDate As Date)
    Dim mSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus

    If rSalesOrderPhaseInfo IsNot Nothing Then
      mSalesOrderPhaseMilestoneStatus = rSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(eSalesOrderPhaseMileStone.ConfirmationOrder)
      If mSalesOrderPhaseMilestoneStatus Is Nothing Then
        mSalesOrderPhaseMilestoneStatus = New dmSalesOrderPhaseMilestoneStatus
        mSalesOrderPhaseMilestoneStatus.MilestoneENUM = eSalesOrderPhaseMileStone.ConfirmationOrder
        mSalesOrderPhaseMilestoneStatus.SalesOrderPhaseID = rSalesOrderPhaseInfo.SalesOrderPhaseID
        mSalesOrderPhaseMilestoneStatus.Status = eMilestoneStatus.Pending
        mSalesOrderPhaseMilestoneStatus.TargetDate = vTargetDate
        rSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss.Add(mSalesOrderPhaseMilestoneStatus)
        pController.SaveSalesOrderPhaseMileStone(mSalesOrderPhaseMilestoneStatus)

      Else
        mSalesOrderPhaseMilestoneStatus.TargetDate = vTargetDate
        pController.SaveSalesOrderPhaseMileStone(mSalesOrderPhaseMilestoneStatus)
      End If

    End If

  End Sub


  Private Sub gvSOPMilestoneStatuses_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvSOPMilestoneStatuses.CustomDrawCell
    Dim mSOPI As clsSalesOrderPhaseInfo
    Dim mMileStoneEnum As Integer
    Dim mMileStone As dmSalesOrderPhaseMilestoneStatus
    Dim mRefMileStone As dmSalesOrderPhaseMilestoneStatus

    If e.RowHandle >= 0 Then
      ''If gvSOPMilestoneStatuses.GetRow(e.RowHandle).IsDataRow Then
      If IsNumeric(e.Column.Tag) Then
        mMileStoneEnum = CInt(e.Column.Tag)
        Select Case e.Column.Tag
          Case eSalesOrderPhaseMileStone.Empaque
            mSOPI = CType(gvSOPMilestoneStatuses.GetRow(e.RowHandle), clsSalesOrderPhaseInfo)
            mMileStone = mSOPI.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(mMileStoneEnum)
            mRefMileStone = mSOPI.SalesOrderPhaseMilestoneStatuss.ItemFromMilestoneENUM(eSalesOrderPhaseMileStone.Metales)
            If mRefMileStone IsNot Nothing Then
              If clsGeneralA.IsBlankDate(mRefMileStone.ActualDate) Then
                e.Appearance.FontStyleDelta = FontStyle.Italic
              End If
            End If
        End Select
      End If
      ''End If
    End If
  End Sub

  Private Sub bbtnReload_Click(sender As Object, e As EventArgs) Handles bbtnReload.Click
    Dim mContractManagerID As Integer

    pController.LoadObject()
    grdSOPMilestoneStatuses.DataSource = pController.SalesOrderPhaseInfos
    gvSOPMilestoneStatuses.RefreshRow(gvSOPMilestoneStatuses.FocusedRowHandle)
  End Sub

  Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    Dim mOptions As New DevExpress.XtraPrinting.XlsxExportOptionsEx
    Dim mFileName As String = ""
    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = vbOK Then
      mOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG
      mFileName = mFileName & ".xlsx"
      gvSOPMilestoneStatuses.ExportToXlsx(mFileName, mOptions)
    End If
  End Sub





End Class