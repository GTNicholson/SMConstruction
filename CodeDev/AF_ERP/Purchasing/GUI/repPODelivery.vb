Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports RTIS.ERPCore

Public Class repPODelivery

  Private pPurchaseOrder As dmPurchaseOrder
  Private pHandler As clsPurchaseHandler
  Private pPOInfo As clsPurchaseOrderInfo
  Private pPODelivery As dmPODelivery
  Private pFormatCordobas As String = "{0:C$#,##0.00;;#}"
  Private pFormatDollar As String = "{0:$#,##0.00;;#}"
  Private pToStringCordobas As String = "C$#,##0.00;;#"
  Private pToStringDollar As String = "$#,##0.00;;#"
  Private pReprintOption As Boolean
  Private pDataSource As colPurchaseOrderItemAllocationProcessor
  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreatePODeliveryReport(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery, ByVal vReprintOption As Boolean) As XtraReport
    Dim mRep As New repPODelivery(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery)
    Dim mPrintTool As ReportPrintTool
    mRep.pReprintOption = vReprintOption
    mRep.pDataSource = rPurchaseOrderProcessors
    mRep.CreateDocument()


    mPrintTool = New ReportPrintTool(mRep)
    mPrintTool.ShowPreviewDialog()
    mPrintTool.Dispose()
    mPrintTool = Nothing


    Return mRep
  End Function

  Public Sub New(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pPOInfo = rPOInfo
    pPODelivery = rPODelivery
    DataSource = rPurchaseOrderProcessors
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repPODelivery_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"


    Select Case pPOInfo.DefaultCurrency
      Case eCurrency.Cordobas
        mCurrentFormat = pFormatCordobas
        mToString = pToStringCordobas

      Case eCurrency.Dollar
        mCurrentFormat = pFormatDollar
        mToString = pToStringDollar
    End Select

    xrUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice", mCurrentFormat)
    xrtVATAmount.DataBindings.Add("Text", DataSource, "VATAmount", mCurrentFormat)



    xrPurchaseOrderNo.Text = pPOInfo.PONum
    xrInvoiceRef.Text = pPODelivery.RefSupplierDoc
    xrOrderDate.Text = pPOInfo.SubmissionDate.ToString("dd/MM/yyyy")
    xrCreatedDate.Text = pPODelivery.DateCreated.ToString("dd/MM/yyyy")
    xrSupplier.Text = pPOInfo.PurchaseOrder.Supplier.CompanyName
    xrGRNNumber.Text = pPODelivery.GRNumber


    xrQuantity.DataBindings.Add("Text", DataSource, "DelItemQty", "{0:0.###}")

    xrNetTotal.DataBindings.Add("Text", DataSource, "TotalPriceByDelItemQty", mCurrentFormat)


    xrtcStockCode.DataBindings.Add("Text", DataSource, "StockCode")
    xrtcRefCodes.DataBindings.Add("Text", DataSource, "PurchaseRefCodes")
    xrUoM.DataBindings.Add("Text", DataSource, "UoMDescription")




    xrtcDescription.DataBindings.Add("Text", DataSource, "Description")

    xrGrossTotal.Text = pDataSource.TotalGrossValue.ToString(mToString)
    xrTotalNetTotal.Text = pDataSource.TotalNetValue.ToString(mToString)
    xrTotalVAT.Text = pDataSource.TotalVAT.ToString(mToString)

  End Sub


End Class