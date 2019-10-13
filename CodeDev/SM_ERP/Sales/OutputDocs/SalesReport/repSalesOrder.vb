Imports System.Drawing.Printing

Public Class repSalesOrder

  Private i As Integer = 0
  Private pSalesOrder As dmSalesOrder
  Private pImageList As List(Of Image)
  Private pTotalAmount As Decimal
  Private pHandler As clsSalesOrderHandler

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    pTotalAmount = 0
    ' Add any initialization after the InitializeComponent() call.

    pImageList = New List(Of Image)

  End Sub

  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder) As repSalesOrder
    Dim mRep As New repSalesOrder
    mRep.pSalesOrder = rSalesOrder
    mRep.pHandler = New clsSalesOrderHandler(rSalesOrder)
    mRep.DataSource = mRep.pSalesOrder.SalesOrderItems

    mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()


    Return mRep
  End Function

  Private Sub SetUpDataBindings()
    ''Dim m As dmMaterialRequirement
    ''m.StockCode

    '// Head informatio from pWorkOrder
    'XrSalesNo.DataBindings.Add("Text", pSalesOrder, "SalesOrderID")
    xrlSalesOrderNo.DataBindings.Add("Text", pSalesOrder, "OrderNo")


    xrtcWODescription.DataBindings.Add("Text", DataSource, "Description")
    xrtStockCode.DataBindings.Add("Text", DataSource, "Species")

    xrtQuantity.DataBindings.Add("Text", DataSource, "Quantity")
    'xrtUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice")


    xrtImageFile.DataBindings.Add("Text", DataSource, "ImageFile")

    xrtStockCode.DataBindings.Add("Text", DataSource, "ItemNumber")



  End Sub

  Private Sub repSalesOrder_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
    Dim mcust As dmCustomer
    Dim mCustCont As dmCustomerContact
    Dim mEmp As dmEmployeeSM

    SetUpDataBindings()

    xrlNotes.Text = pSalesOrder.VisibleNotes
    xrlCompanyName.Text = pSalesOrder.Customer.CompanyName
    xrlMainAddress1.Text = pSalesOrder.Customer.MainAddress1
    XrlEmail.Text = pSalesOrder.Customer.Email
    XrlTelNo.Text = pSalesOrder.Customer.TelNo
    xrlDateEntered.Text = pSalesOrder.DateEntered.ToShortDateString
    XrlDueTime.Text = pSalesOrder.DueTime.ToShortDateString
    'xrlPaymentType.Text = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCustomerStatus), CType(pSalesOrder.Customer.PaymentTermsType, eCustomerStatus))
    xrlPaymentType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.PaymentTermsType).
                                        ItemValueToDisplayValue(pSalesOrder.Customer.PaymentTermsType)

    xrtSalesTermsType.Text = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.SalesTermType).
                                        ItemValueToDisplayValue(pSalesOrder.Customer.SalesTermsType)
    xrlDelAddress1.Text = pSalesOrder.DelAddress1

    xrlSalesOrderNo.Text = pSalesOrder.OrderNo
    XrSalesNo.Text = pSalesOrder.OrderNo
    xrlProjectName.Text = pSalesOrder.ProjectName

    If pSalesOrder.Customer IsNot Nothing Then
      mcust = pSalesOrder.Customer
      xrlDelCompanyName.Text = mcust.CompanyName

      mEmp = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Employees), RTIS.ERPCore.colEmployees).ItemFromKey(pSalesOrder.ContractManagerID)

      If mEmp IsNot Nothing Then
        xrlSalesPerson.Text = mEmp.FullName
      End If

      If mcust.CustomerContacts.Count <> 0 Then
        XrlCompanyContact.Text = mcust.CustomerContacts(0).FirstName & " " & mcust.CustomerContacts(0).LastName


      End If
    End If

    mCustCont = mcust.CustomerContacts.ItemFromKey(pSalesOrder.CustomerDelContactID)
    If mCustCont IsNot Nothing Then
      xrtCustomerDelContactID.Text = mCustCont.FirstName & " " & mCustCont.LastName
      xrtPhoneDelCustomerContact.Text = mCustCont.TelNo
      xrtEmailContact.Text = mCustCont.Email
    End If



  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mWoodAndFinish As String
    Dim mSOI As dmSalesOrderItem
    Dim mFileName As String
    Dim mImage As Image

    mSOI = Me.GetCurrentRow
    xrtAmount.Text = mSOI.TotalAmount.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xrtUnitPrice.Text = mSOI.UnitPrice.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    pTotalAmount += Val(xrtAmount.Text)



    If mSOI IsNot Nothing Then
      ''mText = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).ItemValueToDisplayValue(mWorkOrder.WoodSpecieID)
      ''mText = mText & "/ " & AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodFinish).ItemValueToDisplayValue(mWorkOrder.WoodFinish)
      ''xrtWood.Text = mText
      mFileName = clsSMSharedFuncs.GetSOItemImageFileName(pSalesOrder, mSOI)
      mWoodAndFinish = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).
                                        ItemValueToDisplayValue(mSOI.WoodSpecieID) & " / " &
                                        AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodFinish).
                                        ItemValueToDisplayValue(mSOI.WoodFinish)



      xrtWoodSpecieAndFinish.Text = mWoodAndFinish


      If IO.File.Exists(mFileName) Then
        mImage = Drawing.Image.FromFile(mFileName)
        pImageList.Add(mImage)
        xrtImageFile.Image = mImage

      Else
        xrtImageFile.Image = Nothing
      End If


    End If



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

  Private Sub XrTableCell12_BeforePrint(sender As Object, e As PrintEventArgs) Handles xrtTotalAmount.BeforePrint

  End Sub

  Private Sub ReportFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportFooter.BeforePrint
    xrtSubTotalAmount.Text = pHandler.GetTotalValue.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xrtTax.Text = (clsConstants.TaxRate * pHandler.GetTotalValue).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    xrtTotalAmount.Text = ((1 + clsConstants.TaxRate) * pHandler.GetTotalValue).ToString("C", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
  End Sub
End Class