Public Class repWorkOrderMatReqsWood

  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder, ByRef rSalesOrder As dmSalesOrder) As repWorkOrderMatReqsWood
    Dim mRep As New repWorkOrderMatReqsWood
    ''mRep.pWorkOrder = rWorkOrder
    ''mRep.pFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
    ''mRep.pSalesOrder = rSalesOrder
    ''mRep.DataSource = mRep.pFurniture.MaterialRequirments
    ''mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()


    Return mRep
  End Function

End Class