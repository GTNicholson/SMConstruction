Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI


Public Class repWorkOrderStockItemMaterialRequirement
  Private pMaterialRequirementInfos As colMaterialRequirementInfos




  Private Sub sreprepWorkOrderWoodMaterialRequirement_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    SetUpBindings()



  End Sub

  Private Sub SetUpBindings()


    xtcDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xtcQuantity.DataBindings.Add("Text", Me.DataSource, "QuantityFraction")
    xtcUoM.DataBindings.Add("Text", Me.DataSource, "UoMDesc")

    xtcComments.DataBindings.Add("Text", DataSource, "Comment")
    xtcCurrentInventory.DataBindings.Add("Text", DataSource, "TempAllocatedQty", "{0:#.#}")

  End Sub


  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mCurrentInventory As Decimal


  End Sub
End Class