Imports System.Drawing.Printing

Public Class repPaySlip

  Private pPaySlipItems As colPaySlipItems
  Private pEmployee As RTIS.ERPCore.dmEmployee
  Private pStartDate As DateTime
  Private pEndDate As DateTime
  Private pPayPeriodType As ePayPeriodType
  Private pSalary As Decimal


  Public Shared Sub OpenReportPrintPreview(ByRef rPaySlipItems As colPaySlipItems, ByRef rEmployee As RTIS.ERPCore.dmEmployee, ByVal vStartDate As DateTime, ByVal vEndDate As DateTime, ByVal vPayPeriodType As ePayPeriodType, ByVal vSalary As Decimal)
    Dim mRep As repPaySlip
    Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool


    mRep = New repPaySlip
    mRep.pPaySlipItems = rPaySlipItems
    mRep.DataSource = mRep.pPaySlipItems
    mRep.pEmployee = rEmployee
    mRep.pStartDate = vStartDate
    mRep.pEndDate = vEndDate
    mRep.pPayPeriodType = vPayPeriodType
    mRep.pSalary = vSalary

    mRep.CreateDocument()

    mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    mTool.ShowPreviewDialog()

  End Sub

  Private Sub repPaySlip_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpBindings()

    xrlPeriodStartDate.Text = Me.pStartDate.ToString("MMMM")
    xrlStartDate.Text = pStartDate
    xrlFinishDate.Text = pEndDate
    xrlEmployeeName.Text = pEmployee.FullName

    Select Case pPayPeriodType
      Case 1
        xrlPeriodType.Text = "Mensual"
      Case 2
        xrlPeriodType.Text = "Quincenal"
      Case Else
        xrlPeriodType.Text = ""
    End Select

  End Sub

  Private Sub SetUpBindings()
    xrtcItemDate.DataBindings.Add("Text", Me.DataSource, "ItemDate", "{0:M/d/yyyy}") '', "{0:dd/MM/yy}")
    xtcStartTime.DataBindings.Add("Text", Me.DataSource, "StartTime", "{0:t}")
    xtcEndTime.DataBindings.Add("Text", Me.DataSource, "EndTime", "{0:t}")
    xtcStandardHours.DataBindings.Add("Text", Me.DataSource, "StandardHours")
    xtcStdPayment.DataBindings.Add("Text", Me.DataSource, "StdPayment", "C$ {0:n}")
    xtcOverTimeHours.DataBindings.Add("Text", Me.DataSource, "OverTimeHours")
    xtcOverTimePayment.DataBindings.Add("Text", Me.DataSource, "OverTimePayment", "C$ {0:n}")
    xtcTotalPayment.DataBindings.Add("Text", Me.DataSource, "TotalPayment", "C$ {0:n}")
  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint



  End Sub

  Private Sub Detail_AfterPrint(sender As Object, e As EventArgs) Handles Detail.AfterPrint

  End Sub
End Class