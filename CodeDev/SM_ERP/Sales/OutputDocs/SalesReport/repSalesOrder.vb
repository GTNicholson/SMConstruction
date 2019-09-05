Public Class repSalesOrder


  Private pSalesOrder As dmSalesOrder


  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder) As repSalesOrder
    Dim mRep As New repSalesOrder
    mRep.pSalesOrder = rSalesOrder
    mRep.DataSource = mRep.pSalesOrder.WorkOrders
    mRep.CreateDocument()

    Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    mpt.ShowPreviewDialog()


    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode

    Dim mWO As dmWorkOrder

    '// Head informatio from pWorkOrder
    'XrSalesNo.DataBindings.Add("Text", pSalesOrder, "SalesOrderID")
    xrlSalesOrderNo.DataBindings.Add("Text", pSalesOrder, "OrderNo")


    xrtcWODescription.DataBindings.Add("Text", DataSource, "Description")
    xrtQuantity.DataBindings.Add("Text", DataSource, "Quantity")
    xrtUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice")



  End Sub

  Private Sub repSalesOrder_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
    SetUpDataBindings()
    xrlCompanyName.Text = pSalesOrder.Customer.CompanyName
    xrlMainAddress1.Text = pSalesOrder.Customer.MainAddress1
    XrlEmail.Text = pSalesOrder.Customer.Email
    XrlTelNo.Text = pSalesOrder.Customer.TelNo
    xrlDateEntered.Text = pSalesOrder.DateEntered.ToShortDateString
    XrlDueTime.Text = pSalesOrder.DueTime.ToShortDateString
    xrlPaymentType.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCustomerStatus), CType(pSalesOrder.Customer.PaymentTermsType, eCustomerStatus))
    xrlSalesOrderNo.Text = pSalesOrder.OrderNo
    xrlSalesPerson.Text = pSalesOrder.Customer.SalesEmployeeID
    XrSalesNo.Text = pSalesOrder.OrderNo
    xrlProjectName.Text = pSalesOrder.ProjectName
  End Sub
End Class