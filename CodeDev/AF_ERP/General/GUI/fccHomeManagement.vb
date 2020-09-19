Imports RTIS.CommonVB

Public Class fccHomeManagement
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pSalesOrderProgressInfos As colSalesOrderProgressInfos
  Private pTimeSheetInfoChartSource As colTimeSheetEntryInfos
  Private pCompanyDays As colCompanyDays
  Private pInvoiceInfos As colInvoiceInfos
  Private pWorkOrderInfos As colWorkOrderInfos

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

  Public ReadOnly Property WorkOrderInfos As colWorkOrderInfos
    Get
      Return pWorkOrderInfos
    End Get
  End Property
  Public ReadOnly Property CompanyDays As colCompanyDays
    Get
      Return pCompanyDays
    End Get
  End Property


  Public Sub LoadWorkOrderProgressInfos()
    Dim mdso As dsoProduction
    Dim mwhere As String = ""
    Try

      ''mwhere = "WorkOrderID Not In (select Distinct WorkOrderID from WorkOrderMilestoneStatus Where MilestoneENUM = 10 and Status = 3)"
      mwhere += "WorkOrderID in (select WorkOrderID from vwWorkOrderInfo) or WorkOrderId in (select WorkOrderID from vwWorkOrderInternalInfo)"

      mdso = New dsoProduction(pDBConn)
      pWorkOrderInfos = New colWorkOrderInfos
      mdso.LoadWorkOrderTrackings(pWorkOrderInfos, mwhere)
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

    mdsoSalesOrder.LoadSalesOrderProgressInfos(pSalesOrderProgressInfos, "")
    mdsoCompanyDays.LoadCompanyDays(pCompanyDays, mStartDate, mEndDate)
    mdsoSalesOrder.LoadInvoiceInfosGraph(pInvoiceInfos)
  End Sub




End Class
