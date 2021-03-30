Public Class frmSalesOrderReview
  Private pController As fccSalesOrderReview

  Public Shared Sub OpenModal()
    Dim mfrm As frmSalesOrderReview
    mfrm = New frmSalesOrderReview
    mfrm.pController = New fccSalesOrderReview
    mfrm.ShowDialog()
  End Sub

  Private Sub frmSalesOrderReview_Load(sender As Object, e As EventArgs) Handles Me.Load
    LoadGrids
  End Sub

  Private Sub LoadGrids()
    grdCustomerPOs.DataSource = pController.CustomerPOInfos
    grdInvoices.DataSource = pController.InvoiceInfos
    grdPOItemAllocations.DataSource = pController.POItemAllocationInfos
    grdWoodUsage.DataSource = pController.WoodRequirementInfos
  End Sub
End Class