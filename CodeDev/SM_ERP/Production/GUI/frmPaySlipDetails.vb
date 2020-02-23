Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmPaySlipDetails
  Private pController As fccPaySlipDetails
  Private pIsActive As Boolean

  Public Shared Sub OpenFormMDI(ByRef rMDI As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mfrm As frmPaySlipDetails
    mfrm = New frmPaySlipDetails
    mfrm.pController = New fccPaySlipDetails(rDBConn, rRTISGlobal)
    mfrm.MdiParent = rMDI
    mfrm.Show()
  End Sub

  Private Sub RefreshControls()
    Dim mIsActive As Boolean

    mIsActive = pIsActive
    pIsActive = False

    datPeriodStart.DateTime = pController.PeriodStartDate
    radPayPeriodType.EditValue = CInt(pController.PeriodType)
    datStartDateStd.DateTime = pController.StandardStartDate
    datEndDateStd.DateTime = pController.StandardEndDate
    datStartDateOT.DateTime = pController.OverTimeStartDate
    datEndDateOT.DateTime = pController.OverTimeEndDate
    pIsActive = mIsActive
  End Sub

  Private Sub UpdateObjects()
    pController.PeriodStartDate = datPeriodStart.DateTime
    pController.PeriodType = radPayPeriodType.EditValue
    pController.StandardStartDate = datStartDateStd.DateTime
    pController.StandardEndDate = datEndDateStd.DateTime
    pController.OverTimeStartDate = datStartDateOT.DateTime
    pController.OverTimeEndDate = datEndDateOT.DateTime

    pController.SetCurrentEmployee(1021)

  End Sub

  Private Sub frmOverTime_Load(sender As Object, e As EventArgs) Handles Me.Load

    pIsActive = False
    pController.PeriodType = ePayPeriodType.Quincena
    grdPaySlipItems.DataSource = pController.PaySlipItems
    RefreshControls()
    pIsActive = True

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles grdPaySlipItems.Click

  End Sub

  Private Sub grpPeriodAndEmployee_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpPeriodAndEmployee.CustomButtonClick
    Select Case e.Button.Properties.Tag
      Case "Load"
        UpdateObjects()
        pController.LoadPaySlipItems()
        gvPaySlipItems.RefreshData()
      Case "Print"
        repPaySlip.OpenReportPrintPreview(pController.PaySlipItems, pController.Employee, pController.StandardStartDate, pController.StandardEndDate)
    End Select
  End Sub

  Private Sub gvPaySlipItems_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gvPaySlipItems.RowStyle
    Dim mPSI As clsPaySlipItem
    mPSI = TryCast(gvPaySlipItems.GetRow(e.RowHandle), clsPaySlipItem)
    If mPSI IsNot Nothing Then
      Select Case mPSI.ItemDate.DayOfWeek
        Case DayOfWeek.Saturday, DayOfWeek.Sunday
          e.Appearance.BackColor = Color.WhiteSmoke
      End Select
    End If
  End Sub

  Private Sub datPeriodStart_EditValueChanged(sender As Object, e As EventArgs) Handles datPeriodStart.EditValueChanged
    Try
      If pIsActive Then
        UpdateObjects()
        pController.ResetDefaultDates()
        RefreshControls()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvPaySlipItems_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvPaySlipItems.RowCellStyle
    Dim mPSI As clsPaySlipItem
    mPSI = TryCast(gvPaySlipItems.GetRow(e.RowHandle), clsPaySlipItem)
    If mPSI IsNot Nothing Then
      Select Case e.Column.Name
        Case gcStandardHrs.Name, gcStandardPay.Name
          If mPSI.InStandardRange = False Then
            e.Appearance.BackColor = Color.DarkGray
          End If
        Case gcOTHrs.Name, gcOTPay.Name
          If mPSI.InOverTimeRange = False Then
            e.Appearance.BackColor = Color.DarkGray
          End If
        Case gcTotalPay.Name
          If mPSI.InStandardRange = False And mPSI.InOverTimeRange = False Then
            e.Appearance.BackColor = Color.DarkGray
          End If
      End Select
    End If
  End Sub

  Private Sub radPayPeriodType_EditValueChanged(sender As Object, e As EventArgs) Handles radPayPeriodType.EditValueChanged
    Try
      If pIsActive Then
        UpdateObjects()
        pController.ResetDefaultDates()
        RefreshControls()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class