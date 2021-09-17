Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class subPaymentReportDetail
  Public Property PurchaseOrderInfo As clsPurchaseOrderInfo
  Public Property PurchaseOrderInfos As colPOItemInfos

  Private Sub subPaymentReportDetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint


    DataSource = PurchaseOrderInfos

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
    Dim m As New repPOIADetail
    mPOItemInfo = TryCast(GetCurrentRow(), clsPOItemInfo)
    If mPOItemInfo IsNot Nothing Then
      m.PurchaseOrderItemAllocations = mPOItemInfo.PurchaseOrderItemAllocations
      m.DataSource = mPOItemInfo.PurchaseOrderItemAllocations
      'm.DataAdapter = "PurchaseOrderItemAllocations"
      XrSubreport1.ReportSource = m
    End If
  End Sub


  Private Sub DetailReport_BeforePrint(sender As Object, e As PrintEventArgs)

  End Sub

  Private Sub XrSubreport1_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrSubreport1.BeforePrint



  End Sub
End Class