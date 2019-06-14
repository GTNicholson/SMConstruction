Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder

  Public Shared Function GenerateReport(ByRef rWorkOrders As colWorkOrders) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.DataSource = rWorkOrders
    mRep.CreateDocument()
    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    xrlWorkOrderNo.DataBindings.Add("Text", Me.DataSource, "WorkOrderNo")
  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpDataBindings()

  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mrepProductFurniture As repProductFurniture

    mrepProductFurniture = New repProductFurniture

    mrepProductFurniture.ProductFurniture = CType(Me.GetCurrentRow, dmWorkOrder).Product

    subrepProduct.ReportSource = mrepProductFurniture

  End Sub
End Class