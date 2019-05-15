Public Class clsWorkOrderInfo
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer


  Public Sub New()
    pWorkOrder = New dmWorkOrder
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
  End Sub

  Public ReadOnly Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
  End Property

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property

  Public ReadOnly Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
  End Property

  Public ReadOnly Property WorkOrderID
    Get
      Return pWorkOrder.WorkOrderID
    End Get
  End Property

  Public ReadOnly Property Quantity As Decimal
    Get
      Return pWorkOrder.Quantity
    End Get
  End Property

  Public ReadOnly Property ProductType As Integer
    Get
      Return pWorkOrder.ProductTypeID
    End Get
  End Property

  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property

  Public ReadOnly Property BusinessSector As Integer
    Get
      Return pSalesOrder.BusinessSectorID
    End Get
  End Property

  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property CustomerName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property

End Class

Public Class colWorkOrderInfos : Inherits List(Of clsWorkOrderInfo)

End Class