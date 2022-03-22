Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI


Public Class repCoverWOPack




  Private Sub sreprepWorkOrderWoodMaterialRequirement_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    SetUpBindings()



  End Sub

  Private Sub SetUpBindings()


    xtcDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xtcQuantity.DataBindings.Add("Text", Me.DataSource, "QuantityFraction")
  End Sub


End Class