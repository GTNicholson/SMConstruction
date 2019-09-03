Public Class repSalesOrder


  Private pSalesOrder As dmSalesOrder


  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder) As repSalesOrder
    Dim mRep As New repSalesOrder
    mRep.pSalesOrder = rSalesOrder
    mRep.DataSource = mRep.pSalesOrder
    mRep.CreateDocument()

    Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    mpt.ShowPreviewDialog()


    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode

    '// Head informatio from pWorkOrder
    'XrSalesNo.DataBindings.Add("Text", pSalesOrder, "SalesOrderID")


  End Sub

  Private Sub repSalesOrder_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
    SetUpDataBindings()
    xrlCompanyName.Text = pSalesOrder.Customer.CompanyName

  End Sub
End Class