Public Class clsSalesProjectReviewCost

  Private pSalesOrder As dmSalesOrder
  Private pManPowerCost As Decimal
  Private pPOIAOutsourcingSum As Decimal
  Private pSOPItemPickMatReqCost As Decimal

  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder
  End Sub

  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.OrderNo & " / " & pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property SalesOrderID As Integer
    Get
      Return pSalesOrder.SalesOrderID
    End Get
  End Property

  Public ReadOnly Property DateEntered As Date
    Get
      Return pSalesOrder.DateEntered
    End Get
  End Property

  Public ReadOnly Property OrderStatusEnum As Integer
    Get
      Return pSalesOrder.OrderStatusENUM
    End Get
  End Property

  Public Property SOPItemPickMatReqCost As Decimal
    Get
      Return pSOPItemPickMatReqCost
    End Get
    Set(value As Decimal)
      pSOPItemPickMatReqCost = value
    End Set
  End Property

  Public Property POIAOutsourcingSum As Decimal
    Get
      Return pPOIAOutsourcingSum
    End Get
    Set(value As Decimal)
      pPOIAOutsourcingSum = value
    End Set
  End Property

  Public Property ManPowerCost As Decimal
    Get
      Return pManPowerCost
    End Get
    Set(value As Decimal)
      pManPowerCost = value
    End Set
  End Property

  Public Property SOPIPickWoodMatReqCost As Decimal
  Public Property LineValue As Decimal

End Class

Public Class colSalesProjectReviewCosts : Inherits List(Of clsSalesProjectReviewCost)

  Public Sub New()


  End Sub

End Class
