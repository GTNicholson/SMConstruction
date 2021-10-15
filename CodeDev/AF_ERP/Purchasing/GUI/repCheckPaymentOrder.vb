Imports System.Drawing.Printing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraReports.UI
Imports RTIS.DataLayer
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
  Private pAccountCode As String
  Private pDBConn As clsDBConnBase
  Private pPurchaseOrderInfos As colPurchaseOrderInfos
  Private pCompanyOption As repPurchaseOrder.eCompanyOption
  Public Sub New()

    InitializeComponent()


  End Sub



  Public Shared Function CreateReport(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vPreview As Boolean, ByVal vCurrency As eCurrency, ByVal vProjectName As String, ByVal vAccountCode As String, ByRef rDBConn As clsDBConnBase, ByVal vCompanyOption As repPurchaseOrder.eCompanyOption) As XtraReport
    Dim mRep As New repCheckPaymentOrder(rPOInfo, rBuyer, vCurrency, vProjectName, vAccountCode, rDBConn, vCompanyOption)
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

  Public Sub New(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vCurrency As eCurrency, ByVal vProjectName As String, ByVal vAccountCode As String, ByRef rDBConn As clsDBConnBase, ByVal vCompanyOption As repPurchaseOrder.eCompanyOption)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    pCurrency = vCurrency
    pPOInfo = rPOInfo
    pBuyer = rBuyer
    pPurchaseOrderInfos = New colPurchaseOrderInfos
    pPurchaseOrderInfos.Add(rPOInfo)
    DataSource = pPurchaseOrderInfos 'rPOInfo.POItemInfos
    pProjectName = vProjectName
    pAccountCode = vAccountCode
    pDBConn = rDBConn
    pCompanyOption = vCompanyOption
  End Sub


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub repCheckPaymentOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
    Dim mCurrentFormat As String = "N2"
    Dim mToString As String = "N2"
    Dim mNumalet As New Numalet
    Dim mPOAII As New colPurchaseOrderItemAllocationInfos
    Dim mdso As New dsoPurchasing(pDBConn)


    Dim mWhere As String

    If pCompanyOption = repPurchaseOrder.eCompanyOption.Agro Then
      xrCompanyname.Text = "AGROFORESTAL, S,A."
    Else
      xrCompanyname.Text = "HYESS, S.A."
      xrLogo.Visible = False
    End If

    xrtSupplierName.Text = pPOInfo.CompanyName

    xrtAccountNumber.Text = pAccountCode

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

    xrtTotalAmount.Text = Math.Round(pPOInfo.TotalGrossValue, 2, MidpointRounding.AwayFromZero).ToString(mToString)

    xrtDateCreated.Text = pPOInfo.SubmissionDate
    xrtPaymentMethod.Text = pPOInfo.PaymentMethodDes
    xrtBankName.Text = pPOInfo.BankName
    xrtPONo.Text = pPOInfo.PONum

    mNumalet.MascaraSalidaDecimal = "centavos"
    mNumalet.LetraCapital = True

    xrtValueInLetter.Text = mNumalet.ToCustomCardinal(Math.Round(pPOInfo.TotalGrossValue, 2, MidpointRounding.AwayFromZero).ToString())
    txtComment.Text = pPOInfo.Comments

    Dim mText As String = "Compra de"


    If pPOInfo.isBigTaxPayer Then
      xrtcIsBigTaxPayer.Visible = True
    Else
      xrtcIsBigTaxPayer.Visible = False
    End If

    mWhere = "PONum = " & pPOInfo.PONum
    mdso.LoadPurchaseOrderItemAllocationInfos(mPOAII, mWhere)




    'Select Case pPOInfo.MaterialRequirementTypeWorkOrderID
    '  Case ePOMaterialRequirementType.Multiple

    '    For Each mPOI As clsPOItemInfo In pPOInfo.POItemInfos

    '      mText &= String.Format("Compra de {0} {1} de {2} con cargo al centro de costo: {3} / Categoría Contable: {4}", mPOI.Qty, mPOI.UoMDesc,
    '                             mPOI.Description, pPOInfo.CategoryDesc, pPOInfo.AccoutingCategoryDesc) & vbCrLf

    '      For Each mPOIA As dmPurchaseOrderItemAllocation In mPOI.PurchaseOrderItemAllocations
    '        mText &= String.Format("{0} {1} ")
    '      Next


    '    Next


    'End Select




    'If mPOAII IsNot Nothing Then
    '  Dim mString As String = ""

    '  If mPOAII.Count = 1 Then
    '    For Each mPOI As clsPOItemInfo In pPOInfo.POItemInfos
    '      mText &= " " & vbCrLf
    '      mText &= " " & mPOI.Qty.ToString("N2") & " " & mPOI.UoMDesc & " de " & mPOI.Description

    '      'If mPOAII(0).ProjectName = "" Then
    '      '  mText &= vbCrLf & "Con cargo al centro de costo: " & pPOInfo.CategoryDesc & " / Categoría Contable: " & pPOInfo.AccoutingCategoryDesc

    '      'Else

    '      '  If mPOI.PurchaseOrderItemAllocations.Count > 0 Then
    '      '    mText &= vbCrLf & "Con cargo al proyecto " & mPOI.
    '      '  End If
    '      '  xrtDescriptionPOItem.Text = mText
    '    Next





    '  Else
    '    If mPOAII.Count > 0 Then



    '      For Each mPOAI In mPOAII
    '        'mString &= "Cantidad : " & mPOAI.Quantity.ToString("n2") & mPOAI.UoMDescription & " Destinado al proyecto : " & mPOAI.ProjectName & vbCrLf
    '        mText &= " " & vbCrLf
    '        mText &= " " & mPOAI.Quantity.ToString("N2") & " " & mPOAI.UoMDesc & " de " & mPOAI.Description

    '        If mPOAI.ProjectName = "" Then
    '          mText &= vbCrLf & "Con cargo al centro de costo: " & pPOInfo.CategoryDesc & " / Categoría Contable: " & pPOInfo.AccoutingCategoryDesc

    '        Else

    '          mText &= vbCrLf & "Con cargo al proyecto " & mPOAI.ProjectName
    '        End If

    '        xrtDescriptionPOItem.Text = mText

    '      Next

    '    Else
    '      mText &= vbCrLf & "Con cargo al centro de costo: " & pPOInfo.CategoryDesc & " / Categoría Contable: " & pPOInfo.AccoutingCategoryDesc
    '      xrtDescriptionPOItem.Text = mText

    '    End If

    '  End If

    '  End If
    Dim mPaymentReportDetail As subPaymentReportDetail

    mPaymentReportDetail = New subPaymentReportDetail
    Dim mNew As New colPurchaseOrderInfos
    mNew.Add(pPOInfo)
    mPaymentReportDetail.PurchaseOrderInfo = pPOInfo
    mPaymentReportDetail.PurchaseItemInfos = pPOInfo.POItemInfos

    xsubrepPOIAllocationDetail.ReportSource = mPaymentReportDetail
  End Sub

  Private Sub repCheckPaymentOrder_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint

  End Sub

  Private Sub ReportHeader_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportHeader.BeforePrint

  End Sub


End Class