Imports System.Drawing.Printing

Public Class repSalesOrder


  Private pSalesOrder As dmSalesOrder


  Public Shared Function GenerateReport(ByRef rSalesOrder As dmSalesOrder) As repSalesOrder
    Dim mRep As New repSalesOrder
    mRep.pSalesOrder = rSalesOrder
    mRep.DataSource = mRep.pSalesOrder.WorkOrders

    mRep.CreateDocument()

    ''Dim mpt As DevExpress.XtraReports.UI.ReportPrintTool
    ''mpt = New DevExpress.XtraReports.UI.ReportPrintTool(mRep)
    ''mpt.ShowPreviewDialog()


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
    xrtStockCode.DataBindings.Add("Text", DataSource, "Species")

    xrtQuantity.DataBindings.Add("Text", DataSource, "Quantity")
    xrtUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice")



  End Sub

  Private Sub repSalesOrder_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
    SetUpDataBindings()
    Dim mcust As dmCustomer
    Dim mCustCont As dmCustomerContact
    Dim mEmp As dmEmployeeSM

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

      mEmp = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Employees), RTIS.ERPCore.colEmployees).ItemFromKey(pSalesOrder.Customer.SalesEmployeeID)
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
    End If






  End Sub

  Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
    Dim mText As String
    Dim mWorkOrder As dmWorkOrder

    mWorkOrder = Me.GetCurrentRow

    If mWorkOrder IsNot Nothing Then
      mText = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).ItemValueToDisplayValue(mWorkOrder.WoodSpecieID)
      mText = mText & "/ " & AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodFinish).ItemValueToDisplayValue(mWorkOrder.WoodFinish)
      xrtWood.Text = mText
    End If

  End Sub
End Class