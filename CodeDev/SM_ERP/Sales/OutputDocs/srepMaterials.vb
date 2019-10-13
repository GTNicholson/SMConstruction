Imports System.Drawing.Printing

Public Class srepMaterials
  Private pWorkOrder As dmWorkOrder

  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Private Sub SetBindings()
    xrtcStockCode.DataBindings.Add("Text", Me.DataSource, "StockCode")
    xrtcDescription.DataBindings.Add("Text", Me.DataSource, "Description")
    xrtcQuantity.DataBindings.Add("Text", Me.DataSource, "Quantity")
  End Sub

  Private Sub srepMaterials_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetBindings()
  End Sub
End Class