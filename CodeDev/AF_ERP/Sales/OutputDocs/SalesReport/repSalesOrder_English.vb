Imports System.Drawing.Printing

Public Class repSalesOrder_English

  Private pSalesOrder As dmSalesOrder
  Private pImageList As List(Of Image)
  Private pTotalAmount As Decimal
  Private pHandler As clsSalesOrderHandler
  Private pIsVat As Boolean
  Private pSalesHouseID As Integer

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    pTotalAmount = 0
    ' Add any initialization after the InitializeComponent() call.

    pImageList = New List(Of Image)

  End Sub

  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByRef rSalesItemEditors As colSalesItemEditors, ByVal vIsVAT As Boolean, ByVal vLanguageOption As Integer, ByVal vSalesHouseID As Integer) As repSalesOrder_English
    Dim mRep As New repSalesOrder_English
    mRep.pSalesOrder = rSalesOrder
    mRep.pHandler = New clsSalesOrderHandler(rSalesOrder)
    mRep.pIsVat = vIsVAT
    mRep.DataSource = rSalesItemEditors
    mRep.pSalesHouseID = vSalesHouseID
    mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()

    mRep.ClearImages()
    Return mRep
  End Function

  Private Sub FillCompanyInfo()
    Dim mCompanyInfo As String
    mCompanyInfo = "AGROFORESTAL S.A." & vbCrLf
    mCompanyInfo &= "RUC: J0310000096279" & vbCrLf
    mCompanyInfo &= "KM 12,5 Carretera nueva a Leon, Empalme a Xiloa 200 mts al Este" & vbCrLf
    mCompanyInfo &= "al Este." & vbCrLf
    mCompanyInfo &= "Managua, Nicaragua. P: +(505) 7831-1200" & vbCrLf
    mCompanyInfo &= "www.agroforestal.co"


    xrlCompanyInformation.Text = mCompanyInfo
  End Sub

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode

    '// Head informatio from pWorkOrder
    'XrSalesNo.DataBindings.Add("Text", pSalesOrder, "SalesOrderID")
    xrlSalesOrderNo.DataBindings.Add("Text", pSalesOrder.SalesOrderHouses.ItemFromKey(pSalesHouseID), "Ref")


    xrtcWODescription.DataBindings.Add("Text", DataSource, "Description")
    xtcQuantity.DataBindings.Add("Text", DataSource, "Quantity", "{0:#,##0.00;;#}")
    xtcUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice", "{0:$#,##0.00;;#}")
    xtcUoM.DataBindings.Add("Text", DataSource, "UoMDesc")
    xtcTotalAmount.DataBindings.Add("Text", DataSource, "TotalAmount", "{0:$#,##0.00;;#}")
    'xrtImageFile.DataBindings.Add("Text", DataSource, "ImageFile")

    xtcItemRef.DataBindings.Add("Text", DataSource, "ItemNumber")
    xtcComments.DataBindings.Add("Text", DataSource, "Comments")


  End Sub

  Private Sub repSalesOrder_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
    Dim mcust As dmCustomer
    Dim mCustCont As dmCustomerContact
    Dim mEmp As dmEmployeeSM

    SetUpDataBindings()
    FillCompanyInfo()
    xtcDateEntered.Text = pSalesOrder.DateEntered.ToShortDateString
    xrlNotes.Text = pSalesOrder.VisibleNotes
    xtcProjectName.Text = pSalesOrder.ProjectName
    xtcPaymentTerms.Text = pSalesOrder.PaymentTermDesc
    xtcSalesPerson.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pSalesOrder.ContractManagerID)
    xtcDeliveryToCompany.Text = pSalesOrder.Customer.CompanyName
    'xtcProjectRef.Text = pSalesOrder.ProjectName
    xtcNumQuotation.Text = pSalesOrder.SalesOrderHouses(pSalesHouseID).Ref
    xtcCustAccountRef.Text = pSalesOrder.Customer.AccountRef
    xtcClientName.Text = pSalesOrder.Customer.CompanyName
    xtcCustomerName.Text = pSalesOrder.Customer.CompanyName
    xtcCustomerAddress.Text = pSalesOrder.Customer.MainAddress1
    xtcCustomerEmail.Text = pSalesOrder.Customer.Email
    If pSalesOrder.Customer.MainPostCode <> "" Then
      xtcCustomerTown.Text = pSalesOrder.Customer.MainTown & " / " & pSalesOrder.Customer.MainPostCode
    Else
      xtcCustomerTown.Text = pSalesOrder.Customer.MainTown
    End If
    mCustCont = pSalesOrder.Customer.CustomerContacts.ItemFromKey(pSalesOrder.CustomerDelContactID)

    If mCustCont IsNot Nothing Then
      xtcContact.Text = mCustCont.FirstName & " " & mCustCont.LastName

    End If
    xtcTelphoneCustomer.Text = pSalesOrder.Customer.TelNo
    xtcCustomerEmail.Text = pSalesOrder.Customer.Email

    xtcFinishDate.Text = pSalesOrder.SalesOrderPhases(0).DateRequired.ToShortDateString
    xtcCustAccountRef.Text = pSalesOrder.Customer.CustomerReference

    mCustCont = pSalesOrder.Customer.CustomerContacts.ItemFromKey(pSalesOrder.CustomerDelContactID)
    If mCustCont IsNot Nothing Then
      xtcDeliveryCustomerName.Text = mCustCont.FirstName & " " & mCustCont.LastName
      xtcDelvieryTelephone.Text = mCustCont.TelNo
      xtcDelEmail.Text = mCustCont.Email

    End If

    'xtcDeliveryToCompany.Text = pSalesOrder.Customer.CompanyName
    xtcDeliveryAddress.Text = pSalesOrder.DelAddress1 & vbCrLf
    xtcDeliveryCity.Text = pSalesOrder.DelAddress2
    xrlSalesOrderNo.Text = pSalesOrder.SalesOrderHouses.ItemFromKey(pSalesHouseID).Ref


    SetupValues()

  End Sub

  Private Sub SetupValues()
    Dim pVAT As Decimal = 0

    xrtSubTotalAmount.Text = pHandler.GetTotalValueBySalesHouseID(pSalesHouseID).ToString("$#,##0.00;;#") '"C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xtcShipping.Text = (pHandler.GetCostShippingBySalesHouseID(pSalesHouseID)).ToString("$#,##0.00;;#") '"C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))


    If pIsVat Then
      pVAT = pHandler.GetTotalValueBySalesHouseID(pSalesHouseID) * clsConstants.VATRATE
    End If

    xtcVAT.Text = (pVAT).ToString("$#,##0.00;;#") '"C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xtcNetValueWithVAT.Text = (pHandler.GetTotalValueBySalesHouseID(pSalesHouseID) + pVAT).ToString("$#,##0.00;;#") '"C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))

    xrtGrandTotal.Text = (pHandler.GetTotalValueBySalesHouseID(pSalesHouseID) + pVAT + pHandler.GetCostShippingBySalesHouseID(pSalesHouseID)).ToString("$#,##0.00;;#") '"C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))

  End Sub



  Public Sub ClearImages()
    For Each mImage As Image In pImageList
      mImage.Dispose()
    Next
  End Sub

  Protected Overrides Sub Finalize()
    ClearImages()
    MyBase.Finalize()
  End Sub



End Class