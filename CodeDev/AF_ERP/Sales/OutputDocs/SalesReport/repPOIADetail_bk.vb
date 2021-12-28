Imports System.Drawing.Printing

Public Class repPOIADetail_bk
  Public Property PurchaseOrderItemAllocations As colPurchaseOrderItemAllocations

  Private Sub repPOIADetail_bk_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    'xtcPOIDesc.DataBindings.Add("Text", Me.DataSource, "DisplayReportPOIDesc")
    xrPOIADesc.DataBindings.Add("Text", Me.DataSource, "DisplayReportUI")

  End Sub


  Private Sub PageHeader_BeforePrint(sender As Object, e As PrintEventArgs)


  End Sub
End Class