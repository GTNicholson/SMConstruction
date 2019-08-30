Imports System.Drawing.Printing

Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder

  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.DataSource = CType(rWorkOrder.Product, dmProductFurniture).MaterialRequirments
    mRep.CreateDocument()
    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode
    '// Head informatio from pWorkOrder
    xrlWorkOrderNo.DataBindings.Add("Text", pWorkOrder, "WorkOrderNo")

    '// Detail information from Datasorce (MaterialRequirements)
    xrtcStockCode.DataBindings.Add("Text", Me.DataSource, "StockCode")
  End Sub

  Private Sub repWorkOrderDoc_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    SetUpDataBindings()

  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint

  End Sub
End Class