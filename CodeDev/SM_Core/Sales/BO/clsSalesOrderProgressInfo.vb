Imports RTIS.CommonVB

Public Class clsSalesOrderProgressInfo
  Private pSalesOrder As dmSalesOrder
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderItem As dmSalesOrderItem
  Private pQtyWOs As Int32
  Private pEngineeringCompleteQty As Int32
  Private pDespatchCompleteQty As Int32
  Private pWOsMROtherPicked As Int32
  Private pTimeSheetEntryDays As Decimal

  Public Sub New()
    MyBase.New()
    pSalesOrder = New dmSalesOrder
    pWorkOrder = New dmWorkOrder
    pSalesOrderItem = New dmSalesOrderItem
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub


  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
    Set(value As dmSalesOrderItem)
      pSalesOrderItem = value
    End Set
  End Property
  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
    Set(value As String)
      pSalesOrder.ProjectName = value
    End Set

  End Property

  Public Property FinishDate As Date
    Get
      Return pSalesOrder.FinishDate
    End Get
    Set(value As Date)
      pSalesOrder.FinishDate = value
    End Set

  End Property

  Public Property CompanyName As String
    Get
      Return pSalesOrder.Customer.CompanyName
    End Get
    Set(value As String)
      pSalesOrder.Customer.CompanyName = value
    End Set

  End Property

  Public Property SalesOrderID As String
    Get
      Return pSalesOrder.SalesOrderID
    End Get
    Set(value As String)
      pSalesOrder.SalesOrderID = value
    End Set

  End Property
  Public Property QtyWOs As Int32
    Get
      Return pQtyWOs
    End Get
    Set(value As Int32)
      pQtyWOs = value
    End Set

  End Property

  Public Property EngineeringCompleteQty As Int32
    Get
      Return pEngineeringCompleteQty
    End Get
    Set(value As Int32)
      pEngineeringCompleteQty = value
    End Set

  End Property

  Public Property DespatchCompleteQty As Int32
    Get
      Return pDespatchCompleteQty
    End Get
    Set(value As Int32)
      pDespatchCompleteQty = value
    End Set

  End Property

  Public Property WOsMROtherPicked As Int32
    Get
      Return pWOsMROtherPicked
    End Get
    Set(value As Int32)
      pWOsMROtherPicked = value
    End Set

  End Property


  Public Property TimeSheetEntryDays As Decimal
    Get
      Return pTimeSheetEntryDays
    End Get
    Set(value As Decimal)
      pTimeSheetEntryDays = value
    End Set

  End Property



End Class





Public Class colSalesOrderProgressInfos : Inherits List(Of clsSalesOrderProgressInfo)

End Class