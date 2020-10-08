Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports RTIS.ERPCore

Public Class repPurchaseOrder

  Private pPurchaseOrder As dmPurchaseOrder
  Private pHandler As clsPurchaseHandler
  Private pPOInfo As clsPurchaseOrderInfo
  Private pBuyer As dmEmployee
  Private pFormatCordobas As String = "{0:C$#,##0.00;;#}"
  Private pFormatDollar As String = "{0:$#,##0.00;;#}"
  Private pToStringCordobas As String = "C$#,##0.00;;#"
  Private pToStringDollar As String = "$#,##0.00;;#"
  Private pCurrency As eCurrency

  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreateReport(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vPreview As Boolean, ByVal vCurrency As eCurrency) As XtraReport
    Dim mRep As New repPurchaseOrder(rPOInfo, rBuyer, vCurrency)
    Dim mPrintTool As ReportPrintTool
    mRep.CreateDocument()
    If vPreview Then
      mPrintTool = New ReportPrintTool(mRep)
      mPrintTool.ShowPreviewDialog()
      mPrintTool.Dispose()
      mPrintTool = Nothing
    End If
    Return mRep
  End Function

  Public Sub New(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vCurrency As eCurrency)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pCurrency = vCurrency
    pPOInfo = rPOInfo
    pBuyer = rBuyer
    DataSource = rPOInfo.POItemInfos
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repPurchaseOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"

    xrPurchaseOrderNo.Text = pPOInfo.PONum
    xrSupplierOrderRef.Text = pPOInfo.PurchaseOrder.SupplierRef
    xrDeleiveryAddress.Text = pPOInfo.DeliveryAddress
    xrOrderDate.Text = pPOInfo.SubmissionDate.ToString("dd/MM/yyyy")
    xrRequiredDate.Text = pPOInfo.RequiredDate.ToString("dd/MM/yyyy")
    xrSupplierOrderRef.Text = pPOInfo.PurchaseOrder.SupplierRef
    xrSupplier.Text = pPOInfo.PurchaseOrder.Supplier.CompanyName
    xrSupplierAddress.Text = pPOInfo.PurchaseOrder.Supplier.MainAddress1 & vbCrLf & pPOInfo.PurchaseOrder.Supplier.MainAddress2

    xrQuantity.DataBindings.Add("Text", DataSource, "Qty", "{0:0.###}")
    xrtcStockCode.DataBindings.Add("Text", DataSource, "StockCode")
    xrtcRefCodes.DataBindings.Add("Text", DataSource, "PurchaseRefCodes")
    xrDescription.DataBindings.Add("Text", DataSource, "UoMDesc")




    xrtcUoM.DataBindings.Add("Text", DataSource, "Description")


    Select Case pCurrency
      Case eCurrency.Cordobas
        mCurrentFormat = pFormatCordobas
        mToString = pToStringCordobas

      Case eCurrency.Dollar
        mCurrentFormat = pFormatDollar
        mToString = pToStringDollar
    End Select

    xrUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice", mCurrentFormat)
    xrNetTotal.DataBindings.Add("Text", DataSource, "Price", mCurrentFormat)
    xrGrossTotal.Text = pPOInfo.TotalGrossValue.ToString(mToString)
    xrTotalNetTotal.Text = pPOInfo.TotalNetValue.ToString(mToString)

    xrCarriage.Text = pPOInfo.Carriage.ToString(mToString)

    xrTotalVAT.Text = pPOInfo.TotalVAT.ToString(mToString)





  End Sub


End Class