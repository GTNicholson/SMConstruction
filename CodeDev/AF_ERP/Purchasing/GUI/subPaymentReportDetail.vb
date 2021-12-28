Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class subPaymentReportDetail
  Public Property PurchaseOrderInfo As clsPurchaseOrderInfo
  Public Property PurchaseItemInfos As colPOItemInfos

  Private Sub subPaymentReportDetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint


    DataSource = PurchaseItemInfos

    xrtPOItemUI.DataBindings.Add("Text", Me.DataSource, "DisplayReportPOIDesc")

    xtcAccountingCenter.Text = PurchaseOrderInfo.CategoryDesc
    xtcAccountingCategory.Text = PurchaseOrderInfo.AccoutingCategoryDesc
    'xtcPOIAllocationDesc.DataBindings.Add("Text", Me.DataSource, "PurchaseOrderItemAllocations.ItemRef")

    Dim mInteger As Integer



  End Sub



  Private Sub Detail_AfterPrint(sender As Object, e As EventArgs) Handles Detail.AfterPrint

  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mPOItemInfo As clsPOItemInfo
    Dim mPOIADetailReport As New repPOIADetail
    mPOItemInfo = TryCast(GetCurrentRow(), clsPOItemInfo)
    If mPOItemInfo IsNot Nothing Then


      mPOIADetailReport.PurchaseOrderItemAllocations = mPOItemInfo.PurchaseOrderItemAllocations
      mPOIADetailReport.DataSource = mPOItemInfo.PurchaseOrderItemAllocations
      'm.DataAdapter = "PurchaseOrderItemAllocations"
      xrsubrepPOItemBreakdown.ReportSource = mPOIADetailReport
    End If
  End Sub


  Private Sub DetailReport_BeforePrint(sender As Object, e As PrintEventArgs)

  End Sub

  Private Sub XrSubreport1_BeforePrint(sender As Object, e As PrintEventArgs) Handles xrsubrepPOItemBreakdown.BeforePrint



  End Sub
End Class