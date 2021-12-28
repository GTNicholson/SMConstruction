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
  Private pCompanyOption As eCompanyOption

  Public Enum eCompanyOption
    Agro = 1
    Other = 2
  End Enum
  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreateReport(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vPreview As Boolean, ByVal vCurrency As eCurrency, ByVal vCompanyOption As eCompanyOption) As XtraReport
    Dim mRep As New repPurchaseOrder(rPOInfo, rBuyer, vCurrency, vCompanyOption)
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

  Public Sub New(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vCurrency As eCurrency, ByVal vCompanyOption As eCompanyOption)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pCurrency = vCurrency
    pPOInfo = rPOInfo
    pBuyer = rBuyer
    DataSource = rPOInfo.POItemInfos
    pCompanyOption = vCompanyOption
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repPurchaseOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"

    If pCompanyOption = eCompanyOption.Agro Then
      xrlCompanyName.Text = "AgroForestal S.A."
      xrlNumRuc.Text = "Núm RUC J0310000096279"
      xrlAddress.Text = "Km 13 carretera nueva a león, Empalme Xiloa 300 mts al este. Ciudad Sandino, Managua."

    Else
      xrlCompanyName.Text = "HYESS, S.A"
      xrlNumRuc.Text = "Núm RUC J0110000226033"
      xrlAddress.Text = "Km 13 carretera nueva a león, Empalme Xiloa 300 mts al este. Ciudad Sandino, Managua."
      xrLogo.Visible = False
    End If

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

    xrTotalRetention.Text = (pPOInfo.TotalRetention * -1).ToString(mToString)




  End Sub


End Class