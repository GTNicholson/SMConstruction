Imports System.Drawing.Printing

Public Class repPOIADetail
  Public Property PurchaseOrderItemAllocations As colPurchaseOrderItemAllocations

  Private Sub repPOIADetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    'xtcPOIDesc.DataBindings.Add("Text", Me.DataSource, "DisplayReportPOIDesc")
    xtcQuantity.DataBindings.Add("Text", Me.DataSource, "Quantity", "{0:#,##0.000;;#}")
    xtcProject.DataBindings.Add("Text", Me.DataSource, "ProjectRef")
    xtcOTNumber.DataBindings.Add("Text", Me.DataSource, "OTAndDescription")
    xtcPOICost.DataBindings.Add("Text", Me.DataSource, "TempTotalValue")


  End Sub


End Class