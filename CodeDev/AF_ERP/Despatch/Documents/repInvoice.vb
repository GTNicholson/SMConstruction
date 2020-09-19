Imports System.Drawing.Printing

Public Class repInvoice

  Private pInvoice As dmInvoice

  Private pHandler As clsSalesOrderHandler
  Private i As Integer = 0
  Public Sub New()
    InitializeComponent()

  End Sub

  Public Shared Function GenerateReport(ByRef rInvoice As dmInvoice) As repInvoice
    Dim mRep As New repInvoice
    mRep.pInvoice = rInvoice
    mRep.pHandler = New clsSalesOrderHandler(rInvoice)
    mRep.DataSource = mRep.pInvoice.InvoiceItems

    mRep.CreateDocument()

    Return mRep
  End Function
  Private Sub SetUpDataBindings()
    xrtInvoiceNo.DataBindings.Add("Text", pInvoice, "InvoiceNo")


    xrtInvoiceDate.DataBindings.Add("Text", pInvoice, "InvoiceDate")
    xrlSalesOrderNo.DataBindings.Add("Text", pInvoice.SalesOrder, "OrderNo")

    xrlCompanyName.DataBindings.Add("Text", pInvoice.SalesOrder.Customer, "CompanyName")
    xrlCustomerID.DataBindings.Add("Text", pInvoice.SalesOrder.Customer, "CustomerReference")


    xrlCustomerAddress.DataBindings.Add("Text", pInvoice.SalesOrder.Customer, "MainAddress1")

    xrlCustomerTel.DataBindings.Add("Text", pInvoice.SalesOrder.Customer, "TelNo")

    ''xrtSalesItemCode.DataBindings.Add("Text", pInvoice.SalesOrder.SalesOrderItems(i), "ItemNumber")
    '' xrtSalesItemDescription.DataBindings.Add("Text", pInvoice.SalesOrder.SalesOrderItems(i), "Description")

  End Sub
  Private Sub repInvoice_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    SetUpDataBindings()



  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mII As dmInvoiceItem
    Dim mSOI As dmSalesOrderItem

    mII = Me.GetCurrentRow

    mSOI = pInvoice.SalesOrder.SalesOrderItems.ItemFromKey(mII.SalesItemID)



    xrtSalesItemDescription.Text = pInvoice.SalesOrder.SalesOrderItems(i).Description
    xrtSalesItemCode.Text = pInvoice.SalesOrder.SalesOrderItems(i).ItemNumber
    xrtQuantity.Text = pInvoice.InvoiceItems(i).Quantity
    xrtUnitPrice.Text = pInvoice.SalesOrder.SalesOrderItems(i).UnitPrice
    i = i + 1
  End Sub
End Class