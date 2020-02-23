Imports System.Drawing.Printing

Public Class repPaySlip

  Private pPaySlipItems As colPaySlipItems
  Private pEmployee As RTIS.ERPCore.dmEmployee
  Private pStartDate As DateTime
  Private pEndDate As DateTime


  Public Shared Sub OpenReportPrintPreview(ByRef rPaySlipItems As colPaySlipItems, ByRef rEmployee As RTIS.ERPCore.dmEmployee, ByVal vStartDate As DateTime, ByVal vEndDate As DateTime)
    Dim mRep As repPaySlip
    Dim mTool As DevExpress.XtraReports.UI.ReportPrintTool

    mRep = New repPaySlip
    mRep.DataSource = rPaySlipItems
    mRep.pEmployee = rEmployee
    mRep.pStartDate = vStartDate
    mRep.pEndDate = vEndDate

    mRep.CreateDocument()

    mTool = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    mTool.ShowPreviewDialog()

  End Sub

  Private Sub repPaySlip_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpBindings
  End Sub

  Private Sub SetUpBindings()
    xrtcItemDate.DataBindings.Add("Text", Me.DataSource, "ItemDate") '', "{0:dd/MM/yy}")
  End Sub

End Class