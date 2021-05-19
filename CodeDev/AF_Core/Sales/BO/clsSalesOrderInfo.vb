Public Class clsSalesOrderInfo
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer

  Private pTotalValue As Decimal

  Public Sub New()

    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer

  End Sub

  Public Property TotalValue As Decimal
    Get
      Return pTotalValue
    End Get
    Set(value As Decimal)
      pTotalValue = value
    End Set
  End Property

  Public ReadOnly Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
  End Property

  Public ReadOnly Property CustomerName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property



  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property
  Public ReadOnly Property SalesOrderID As Integer
    Get
      Return pSalesOrder.SalesOrderID
    End Get
  End Property

  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property
  Public ReadOnly Property ContractManagerID As Integer
    Get
      Return pSalesOrder.ContractManagerID
    End Get
  End Property


  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property OrderStatusENUM As Integer
    Get
      Return pSalesOrder.OrderStatusENUM
    End Get
  End Property


  Public ReadOnly Property OrderTypeID As Integer
    Get
      Return pSalesOrder.OrderTypeID
    End Get
  End Property

  Public ReadOnly Property DateEntered As Date
    Get
      Return pSalesOrder.DateEntered
    End Get
  End Property
  Public ReadOnly Property FinishDate As Date
    Get
      Return pSalesOrder.FinishDate
    End Get
  End Property

  Public ReadOnly Property FinishDateWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pSalesOrder.FinishDate)
    End Get
  End Property

  Public ReadOnly Property FinishDateMC As DateTime
    Get
      Return New Date(Year(pSalesOrder.FinishDate), Month(pSalesOrder.FinishDate), 1)
    End Get
  End Property

End Class

Public Class colSalesOrderInfos : Inherits List(Of clsSalesOrderInfo)

End Class