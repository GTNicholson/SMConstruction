Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class frmHomeManagement

  Private pFormController As fccHomeManagement
  Private Shared sActiveForms As Collection

  Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

  End Sub

  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByRef rUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmHomeManagement = Nothing
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    '' Add code here if need to check if a Detail Form for this ID is already open
    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmHomeManagement
      mfrm.pFormController = New fccHomeManagement
      mfrm.pFormController.DBConn = rUserSession.CreateMainDBConn
      mfrm.pFormController.RTISGlobal = rRTISGlobal

      mfrm.MdiParent = rParentForm 'My.Application.MenuMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmHomeManagement
    Dim mfrmWanted As frmHomeManagement = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmHomeManagement
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmHomeManagement Then
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

  Private Sub frmHomeManagement_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

  End Sub

  Private Sub LoadData()
    lblUserName.Text = My.Application.RTISUserSession.UserName


    pFormController.LoadSalesOrderProgressInfo()


    grdSalesTracking.DataSource = pFormController.SalesOrderProgressInfos
    chtCompanyDays.DataSource = pFormController.CompanyDays
    chtInvoice.DataSource = pFormController.InvoiceInfos


    pFormController.LoadWorkOrderProgressInfos()
    grdWorkOrderInfo.DataSource = pFormController.WorkOrderInfos


  End Sub

  Private Sub frmHomeManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
    LoadData()
  End Sub



  Private Sub gvWorkOrderInfo_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvWorkOrderInfo.RowCellStyle
    Try
      Select Case e.Column.Name
        Case gcIngenieria.Name, gcMetal.Name, gcTapizado.Name, gcDespacho.Name
          Dim mRow As clsWorkOrderTracking = gvWorkOrderInfo.GetRow(e.RowHandle)
          Dim mStatus As dmWorkOrderMilestoneStatus
          Dim mStatusID As Integer
          If mRow IsNot Nothing Then

            mStatus = mRow.MileStones.ItemFromMilestoneENUM(e.Column.Tag)

            If mStatus Is Nothing Then
              mStatusID = eMilestoneStatus.Pending
            Else
              mStatusID = mStatus.Status
            End If
            Select Case mStatusID
              Case eMilestoneStatus.Pending, eMilestoneStatus.PartComplete
                If mStatus Is Nothing Then
                  If RTIS.CommonVB.clsGeneralA.IsBlankDate(mRow.FinishDate) Then
                    e.Appearance.BackColor = Color.White
                  Else
                    If Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.FinishDate).AddDays(-7) Then
                      e.Appearance.BackColor = Color.Tomato
                    ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mRow.FinishDate) Then
                      e.Appearance.BackColor = Color.Gold
                    Else
                      e.Appearance.BackColor = Color.White
                    End If
                  End If
                Else
                  If Now >= mStatus.TargetDate Then
                    e.Appearance.BackColor = Color.Tomato
                  ElseIf Now >= RTIS.CommonVB.libDateTime.MondayOfWeek(mStatus.TargetDate) Then
                    e.Appearance.BackColor = Color.Gold
                  Else
                    e.Appearance.BackColor = Color.White
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

  Private Sub btnRefreshData_Click(sender As Object, e As EventArgs) Handles btnRefreshData.Click
    pFormController.LoadSalesOrderProgressInfo()
    pFormController.LoadWorkOrderProgressInfos()
    grdSalesTracking.DataSource = pFormController.SalesOrderProgressInfos
    chtCompanyDays.DataSource = pFormController.CompanyDays
    chtInvoice.DataSource = pFormController.InvoiceInfos

    grdWorkOrderInfo.DataSource = pFormController.WorkOrderInfos
  End Sub

  Private Sub gvWorkOrderInfo_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWorkOrderInfo.CustomUnboundColumnData
    Dim mWorkOrderTracking As clsWorkOrderTracking
    Dim mMileStone As eMilestoneStatus
    Dim mWorkOrderMileStoneStatus As dmWorkOrderMilestoneStatus
    Dim mColTag As Object
    Dim mText As String = ""
    Dim mPickText As String = ""

    Try
      If e.IsGetData Then

        mColTag = e.Column.Tag
        If IsNumeric(mColTag) Then
          mMileStone = CType(mColTag, eMilestoneStatus)
          mWorkOrderTracking = CType(e.Row, clsWorkOrderTracking)

          mWorkOrderMileStoneStatus = mWorkOrderTracking.MileStones.ItemFromMilestoneENUM(mMileStone)
          If mWorkOrderMileStoneStatus IsNot Nothing Then
            Select Case mWorkOrderMileStoneStatus.Status
              Case eMilestoneStatus.NotRequired
                mText = "-"
              Case eMilestoneStatus.Pending
                If clsGeneralA.IsBlankDate(mWorkOrderMileStoneStatus.TargetDate) = False Then
                  mText = mWorkOrderMileStoneStatus.TargetDate.ToString("dd-MMM")
                Else
                  mText = ""
                End If
              Case eMilestoneStatus.PartComplete
                If clsGeneralA.IsBlankDate(mWorkOrderMileStoneStatus.TargetDate) = False Then
                  mText = mWorkOrderMileStoneStatus.TargetDate.ToString("dd-MMM")
                Else
                  mText = ""
                End If
              Case eMilestoneStatus.Complete
                mText = mWorkOrderMileStoneStatus.ActualDate.ToString("dd-MMM")
                If clsGeneralA.IsBlankDate(mWorkOrderMileStoneStatus.TargetDate) = False Then
                  ''mText &= DateDiff(DateInterval.Day, mWorkOrderMileStoneStatus.TargetDate, mWorkOrderMileStoneStatus.ActualDate).ToString("+0;-#")
                Else
                  mText = ""

                End If
            End Select
            If Not String.IsNullOrWhiteSpace(mWorkOrderMileStoneStatus.Notes) Then
              mText &= " (*)"
            End If
            e.Value = mText

            If Not String.IsNullOrWhiteSpace(mWorkOrderMileStoneStatus.Notes) Then
              mText &= " (*)"
            End If
          End If
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class