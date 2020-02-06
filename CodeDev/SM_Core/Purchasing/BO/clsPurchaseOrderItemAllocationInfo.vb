Imports RTIS.CommonVB

Public Class clsPurchaseOrderItemAllocationInfo
  Private pStockItem As dmStockItem
  Private pPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation
  Private pPurchaseOrderItem As dmPurchaseOrderItem
  Private pPurchaseOrderInfo As clsPurchaseOrderInfo

  Public Sub New()
    MyBase.New()
    pStockItem = New dmStockItem
    pPurchaseOrderItem = New dmPurchaseOrderItem
    pPurchaseOrderItemAllocation = New dmPurchaseOrderItemAllocation
    pPurchaseOrderInfo = New clsPurchaseOrderInfo
  End Sub

  Public Sub New(ByRef rPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation)
    pPurchaseOrderItemAllocation = rPurchaseOrderItemAllocation
    pPurchaseOrderItem = New dmPurchaseOrderItem
    pStockItem = New dmStockItem
    pPurchaseOrderInfo = New clsPurchaseOrderInfo
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Property PurchaseOrder() As clsPurchaseOrderInfo
    Get
      Return pPurchaseOrderInfo
    End Get
    Set(ByVal value As clsPurchaseOrderInfo)
      pPurchaseOrderInfo = value
    End Set
  End Property
  Public Property StockItem() As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(ByVal value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property PurchaseOrderItem() As dmPurchaseOrderItem
    Get
      Return pPurchaseOrderItem
    End Get
    Set(ByVal value As dmPurchaseOrderItem)
      pPurchaseOrderItem = value
    End Set
  End Property

  Public Property PurchaseOrderInfo() As clsPurchaseOrderInfo
    Get
      Return pPurchaseOrderInfo
    End Get
    Set(ByVal value As clsPurchaseOrderInfo)
      pPurchaseOrderInfo = value
    End Set
  End Property

  Public Property PurchaseOrderItemAllocation() As dmPurchaseOrderItemAllocation
    Get
      Return pPurchaseOrderItemAllocation
    End Get
    Set(ByVal value As dmPurchaseOrderItemAllocation)
      pPurchaseOrderItemAllocation = value
    End Set
  End Property


  Public ReadOnly Property StockItemID() As Integer
    Get
      Return pStockItem.StockItemID
    End Get

  End Property

  Public ReadOnly Property StockCode() As String
    Get
      Return pStockItem.StockCode
    End Get

  End Property

  Public ReadOnly Property STOCKDESCRIPTION() As String
    Get
      Return pStockItem.Description
    End Get

  End Property


  Public ReadOnly Property PurchaseOrderItemAllocationID() As Integer
    Get
      Return pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID
    End Get

  End Property

  Public ReadOnly Property Quantity() As Decimal
    Get
      Return pPurchaseOrderItemAllocation.Quantity
    End Get

  End Property

  Public ReadOnly Property ReceivedQty() As Decimal
    Get
      Return pPurchaseOrderItemAllocation.ReceivedQty
    End Get

  End Property


  Public ReadOnly Property PurchaseOrderItemID() As Int32
    Get
      Return pPurchaseOrderItem.PurchaseOrderItemID
    End Get

  End Property


  Public ReadOnly Property Status() As Byte
    Get
      Return pPurchaseOrderItem.Status
    End Get

  End Property

  Public ReadOnly Property Description() As String
    Get
      Return pPurchaseOrderItem.Description
    End Get

  End Property

  Public ReadOnly Property UnitPrice() As Decimal
    Get
      Return pPurchaseOrderItem.UnitPrice
    End Get

  End Property

  Public ReadOnly Property QtyRequired() As Decimal
    Get
      Return pPurchaseOrderItem.QtyRequired
    End Get

  End Property

  Public ReadOnly Property Lenght() As Decimal
    Get
      Return pPurchaseOrderItem.Length
    End Get

  End Property

  Public ReadOnly Property Width() As Decimal
    Get
      Return pPurchaseOrderItem.Width
    End Get

  End Property

  Public ReadOnly Property Thickness() As Decimal
    Get
      Return pPurchaseOrderItem.Thickness
    End Get

  End Property


End Class





Public Class colPurchaseOrderItemAllocationInfo : Inherits List(Of clsPurchaseOrderItemAllocationInfo)

End Class