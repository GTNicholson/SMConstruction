Imports System.Drawing.Printing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraReports.UI
Imports RTIS.ERPCore

Public Class repCheckPaymentOrder

  Private pPurchaseOrder As dmPurchaseOrder
  Private pHandler As clsPurchaseHandler
  Private pPOInfo As clsPurchaseOrderInfo
  Private pBuyer As dmEmployee
  Private pFormatCordobas As String = "{0:C$#,##0.00;;#}"
  Private pFormatDollar As String = "{0:$#,##0.00;;#}"
  Private pToStringCordobas As String = "C$#,##0.00;;#"
  Private pToStringDollar As String = "$#,##0.00;;#"
  Private pCurrency As eCurrency
  Private pProjectName As String
  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreateReport(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vPreview As Boolean, ByVal vCurrency As eCurrency, ByVal vProjectName As String) As XtraReport
    Dim mRep As New repCheckPaymentOrder(rPOInfo, rBuyer, vCurrency, vProjectName)
    Dim mPrintTool As ReportPrintTool
    mRep.CreateDocument()
    ''If vPreview Then
    ''  mPrintTool = New ReportPrintTool(mRep)
    ''  '' mPrintTool.ShowPreviewDialog()
    ''  mPrintTool.Dispose()
    ''  mPrintTool = Nothing
    ''End If

    Return mRep
  End Function

  Public Sub New(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vCurrency As eCurrency, ByVal vProjectName As String)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pCurrency = vCurrency
    pPOInfo = rPOInfo
    pBuyer = rBuyer
    DataSource = rPOInfo.POItemInfos
    pProjectName = vProjectName
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repCheckPaymentOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"
    Dim mNumalet As New Numalet

    xrtSupplierName.Text = pPOInfo.CompanyName

    xrtAccountNumber.Text = pPOInfo.PurchaseOrder.Supplier.AccountCode

    Select Case pCurrency
      Case eCurrency.Cordobas
        mCurrentFormat = pFormatCordobas
        mToString = pToStringCordobas
        mNumalet.SeparadorDecimalSalida = "Córdobas con"
      Case eCurrency.Dollar
        mCurrentFormat = pFormatDollar
        mToString = pToStringDollar
        mNumalet.SeparadorDecimalSalida = "Dólares con"
    End Select

    xrtTotalAmount.Text = pPOInfo.TotalGrossValue.ToString(mToString)
    xrtDateCreated.Text = pPOInfo.SubmissionDate
    xrtPaymentMethod.Text = pPOInfo.PaymentMethodDes
    xrtBankName.Text = pPOInfo.BankName
    xrtPONo.Text = pPOInfo.PONum
    ''xrCarriage.Text = pPOInfo.Carriage.ToString(mToString)

    ''xrTotalVAT.Text = pPOInfo.TotalVAT.ToString(mToString)
    mNumalet.MascaraSalidaDecimal = "centavos"
    mNumalet.LetraCapital = True

    xrtValueInLetter.Text = mNumalet.ToCustomCardinal(pPOInfo.TotalGrossValue.ToString)

    Dim mText As String = "Compra de"

    For Each mPOI As clsPOItemInfo In pPOInfo.POItemInfos
      mText &= " " & vbCrLf
      mText &= " " & mPOI.Qty.ToString("N2") & " " & mPOI.Description
    Next


    mText &= vbCrLf & "Con cargo al proyecto " & pProjectName
    xrtDescriptionPOItem.Text = mText
  End Sub


End Class