Imports System.Drawing.Printing

Public Class repSalesOrder

  Private i As Integer = 0
  Private pSalesOrder As dmSalesOrder
  Private pImageList As List(Of Image)
  Private pTotalAmount As Decimal
  Private pHandler As clsSalesOrderHandler
  Private pIsVat As Boolean

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    pTotalAmount = 0
    ' Add any initialization after the InitializeComponent() call.

    pImageList = New List(Of Image)

  End Sub

  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder, ByVal vIsVAT As Boolean) As repSalesOrder
    Dim mRep As New repSalesOrder
    mRep.pSalesOrder = rSalesOrder
    mRep.pHandler = New clsSalesOrderHandler(rSalesOrder)
    mRep.pIsVat = vIsVAT
    mRep.DataSource = mRep.pSalesOrder.SalesOrderItems

    mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()


    Return mRep
  End Function

  Private Sub FillCompanyInfo()
    Dim mCompanyInfo As String
    mCompanyInfo = "AGROFORESTAL S.A." & vbCrLf
    mCompanyInfo &= "RUC: J0310000096279" & vbCrLf
    mCompanyInfo &= "Design Center: KM 12,5 Carretera nueva a Leon, Empalme a Xiloa 200 mts" & vbCrLf
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
    xrlSalesOrderNo.DataBindings.Add("Text", pSalesOrder, "OrderNo")


    xrtcWODescription.DataBindings.Add("Text", DataSource, "Description")
    xtcQuantity.DataBindings.Add("Text", DataSource, "Quantity")
    xtcUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice")
    xtcUoM.DataBindings.Add("Text", DataSource, "UoMDesc")
    xtcTotalAmount.DataBindings.Add("Text", DataSource, "TotalAmount")
    'xrtImageFile.DataBindings.Add("Text", DataSource, "ImageFile")

    xrtStockCode.DataBindings.Add("Text", DataSource, "ItemNumber")
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
    xtcProjectRef.Text = pSalesOrder.ProjectName
    xtcCustomerInfo.Text = pSalesOrder.Customer.CompanyName
    xtcCustomerName.Text = pSalesOrder.Customer.CompanyName
    xtcCustomerAddress.Text = pSalesOrder.Customer.MainAddress1
    xtcCustomerEmail.Text = pSalesOrder.Customer.Email
    If pSalesOrder.Customer.MainPostCode <> "" Then
      xtcCustomerTown.Text = pSalesOrder.Customer.MainTown & " / " & pSalesOrder.Customer.MainPostCode
    Else
      xtcCustomerTown.Text = pSalesOrder.Customer.MainTown
    End If
    mCustCont = pSalesOrder.Customer.CustomerContacts.ItemFromKey(pSalesOrder.CustomerContactID)

    If mCustCont IsNot Nothing Then
      xtcContact.Text = mCustCont.FirstName & " " & mCustCont.LastName

    End If
    xtcTelphoneCustomer.Text = pSalesOrder.Customer.TelNo
    xtcCustomerEmail.Text = pSalesOrder.Customer.Email

    xtcFinishDate.Text = pSalesOrder.SalesOrderPhases(0).DateRequired.ToShortDateString
    xtcCustomerInfo.Text = pSalesOrder.Customer.CustomerReference

    mCustCont = pSalesOrder.Customer.CustomerContacts.ItemFromKey(pSalesOrder.CustomerDelContactID)
    If mCustCont IsNot Nothing Then
      xtcDeliveryCustomerName.Text = mCustCont.FirstName & " " & mCustCont.LastName
      xtcDelvieryTelephone.Text = mCustCont.TelNo
      xtcDelEmail.Text = mCustCont.Email

    End If
    xtcPlannedDespatch.Text = pSalesOrder.FinishDate
    xtcDeliveryToCompany.Text = pSalesOrder.Customer.CompanyName
    xtcDeliveryAddress.Text = pSalesOrder.DelAddress1 & vbCrLf
    xtcDeliveryCity.Text = pSalesOrder.DelAddress2
    'xrlMainAddress1.Text = pSalesOrder.Customer.MainAddress1
    'XrlEmail.Text = pSalesOrder.Customer.Email
    'XrlTelNo.Text = pSalesOrder.Customer.TelNo
    'xrlDateEntered.Text = pSalesOrder.DateEntered.ToShortDateString
    'XrlDueTime.Text = pSalesOrder.FinishDate.ToShortDateString
    ''xrlPaymentType.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCustomerStatus), CType(pSalesOrder.Customer.PaymentTermsType, eCustomerStatus))
    'xrlPaymentType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType).
    '                                    ItemValueToDisplayValue(pSalesOrder.Customer.PaymentTermsType)

    'xrtSalesTermsType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.SalesTermType).
    '                                    ItemValueToDisplayValue(pSalesOrder.Customer.SalesTermsType)
    'xrlDelAddress1.Text = pSalesOrder.DelAddress1

    xrlSalesOrderNo.Text = pSalesOrder.OrderNo
    'XrSalesNo.Text = pSalesOrder.OrderNo
    'xrlProjectName.Text = pSalesOrder.ProjectName

    'If pSalesOrder.Customer IsNot Nothing Then
    '  mcust = pSalesOrder.Customer
    '  xrlDelCompanyName.Text = mcust.CompanyName

    '  mEmp = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Employees), RTIS.ERPCore.colEmployees).ItemFromKey(pSalesOrder.ContractManagerID)

    '  If mEmp IsNot Nothing Then
    '    xrlSalesPerson.Text = mEmp.FullName
    '  End If

    '  If mcust.CustomerContacts.Count <> 0 Then
    '    XrlCompanyContact.Text = mcust.CustomerContacts(0).FirstName & " " & mcust.CustomerContacts(0).LastName


    '  End If
    'End If

    'mCustCont = mcust.CustomerContacts.ItemFromKey(pSalesOrder.CustomerDelContactID)
    'If mCustCont IsNot Nothing Then
    '  xrtCustomerDelContactID.Text = mCustCont.FirstName & " " & mCustCont.LastName
    '  xrtPhoneDelCustomerContact.Text = mCustCont.TelNo
    '  xrtEmailContact.Text = mCustCont.Email
    'End If



  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mWoodAndFinish As String
    Dim mSOI As dmSalesOrderItem
    Dim mFileName As String
    Dim mImage As Image

    mSOI = Me.GetCurrentRow





    'If mSOI IsNot Nothing Then
    ''mText = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).ItemValueToDisplayValue(mWorkOrder.WoodSpecieID)
    ''mText = mText & "/ " & AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodFinish).ItemValueToDisplayValue(mWorkOrder.WoodFinish)
    ''xrtWood.Text = mText
    'xrtAmount.Text = mSOI.TotalAmount.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    'xrtUnitPrice.Text = mSOI.UnitPrice.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    'pTotalAmount += Val(xrtAmount.Text)

    'mFileName = clsSMSharedFuncs.GetSOItemImageFileName(pSalesOrder, mSOI)


    '  xrtWoodSpecieAndFinish.Text = mWoodAndFinish


    '  If IO.File.Exists(mFileName) Then
    '    mImage = Drawing.Image.FromFile(mFileName)
    '    pImageList.Add(mImage)
    '    xrtImageFile.Image = mImage

    '  Else
    '    xrtImageFile.Image = Nothing
    '  End If


    'End If



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

  Private Sub XrTableCell12_BeforePrint(sender As Object, e As PrintEventArgs)

  End Sub


  Private Sub ReportFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportFooter.BeforePrint
    Dim pVAT As Decimal = 0

    xrtSubTotalAmount.Text = pHandler.GetTotalValue.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xtcShipping.Text = (pHandler.GetCostShipping).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))

    xrtTotalAmount.Text = (pHandler.GetCostShipping + pHandler.GetTotalValue).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))


    If pIsVat Then
      pVAT = (pHandler.GetCostShipping + pHandler.GetTotalValue) * clsConstants.VATRATE
    End If

    xtcVAT.Text = (pVAT).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xtcGrandTotal.Text = (pHandler.GetCostShipping + pHandler.GetTotalValue + pVAT).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))

  End Sub
End Class