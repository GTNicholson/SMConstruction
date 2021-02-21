Imports RTIS.CommonVB

Public Class fccHomePurchasing
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pSalesOrderProgressInfos As colSalesOrderProgressInfos
  Private pTimeSheetInfoChartSource As colTimeSheetEntryInfos
  Private pCompanyDays As colCompanyDays
  Private pInvoiceInfos As colInvoiceInfos
  Private pPurchaseOrderInfos As colPurchaseOrderInfos

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public ReadOnly Property CostLabourChartSource As colTimeSheetEntryInfos
    Get
      Return pTimeSheetInfoChartSource
    End Get
  End Property

  Public ReadOnly Property InvoiceInfos As colInvoiceInfos
    Get
      Return pInvoiceInfos
    End Get
  End Property

  Public ReadOnly Property SalesOrderProgressInfos As colSalesOrderProgressInfos
    Get
      Return pSalesOrderProgressInfos
    End Get
  End Property

  Public ReadOnly Property PurchaseOrderInfos As colPurchaseOrderInfos
    Get
      Return pPurchaseOrderInfos
    End Get
  End Property
  Public ReadOnly Property CompanyDays As colCompanyDays
    Get
      Return pCompanyDays
    End Get
  End Property

  Public Sub LoadPurchaseOrderInfosThisYear()
    Dim mdso As dsoPurchasing
    Dim mwhere As String = ""
    Dim StartDate As Date = New Date(Now.Year, 1, 1)
    Dim EndDate As Date = New Date(Now.Year, 12, 31)
    Try

      mwhere += String.Format("SubmissionDate between {0} and {1} and status not in ({2},{3})", StartDate, EndDate, ePurchaseOrderDueDateStatus.Cancelled, ePurchaseOrderDueDateStatus.Received)

      mdso = New dsoPurchasing(pDBConn)
      pPurchaseOrderInfos = New colPurchaseOrderInfos
      mdso.LoadPurchaseOrderInfosDown(pPurchaseOrderInfos, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub


  Public Sub LoadSalesOrderProgressInfo()
    Dim mdsoSalesOrder As New dsoSales(pDBConn)
    Dim mdsoCompanyDays As New dsoCompanyDay(pDBConn)
    Dim mMonth As Integer = 0
    Dim mYear As Int32 = 0
    Dim mStartDate As Date
    Dim mEndDate As Date

    mMonth = Now.Month

    If mMonth < 6 Then
      mYear = Now.Year - 1
      mMonth = mMonth + 7 ''the last 6 months

      mStartDate = New Date(mYear, mMonth, 1)


    Else
      mYear = Now.Year
      mMonth = Now.Month - 5

      mStartDate = New Date(mYear, mMonth, 1)

    End If

    mEndDate = New Date(Now.Year, Now.Month, Now.Day)

    pSalesOrderProgressInfos = New colSalesOrderProgressInfos
    pCompanyDays = New colCompanyDays
    pInvoiceInfos = New colInvoiceInfos

    mdsoSalesOrder.LoadSalesOrderProgressInfos(pSalesOrderProgressInfos, "OrderNo<>''")
    mdsoCompanyDays.LoadCompanyDays(pCompanyDays, mStartDate, mEndDate)
    mdsoSalesOrder.LoadInvoiceInfosGraph(pInvoiceInfos)
  End Sub




End Class
