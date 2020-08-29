Public Class clsPurchaseOrderInfo
  Private pPurchaseOrder As dmPurchaseOrder

  Private pPOItemInfos As colPOItemInfos
  Private pPOItem As dmPurchaseOrderItem
  Private pStockItem As dmStockItem
  Public Sub New()
    pPurchaseOrder = New dmPurchaseOrder
    pPOItem = New dmPurchaseOrderItem
  End Sub

  Public Sub New(ByRef rPurchaseOrder As dmPurchaseOrder)
    rPurchaseOrder = rPurchaseOrder

    pPOItem = New dmPurchaseOrderItem

  End Sub

  Public ReadOnly Property PurchaseOrderItem As dmPurchaseOrderItem
    Get
      Return pPOItem
    End Get
  End Property
  Public ReadOnly Property PurchaseOrderItemID As Int32
    Get
      Return pPOItem.PurchaseOrderItemID
    End Get
  End Property

  Public Property PurchaseOrder As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property


  Public Property POItemInfos As colPOItemInfos
    Get
      Return pPOItemInfos
    End Get
    Set(value As colPOItemInfos)
      pPOItemInfos = value
    End Set
  End Property

  Public Property PurchaseOrderID() As Int32
    Get
      Return pPurchaseOrder.PurchaseOrderID
    End Get
    Set(value As Int32)
      pPurchaseOrder.PurchaseOrderID = value
    End Set

  End Property

  Public Property PONum() As String
    Get
      Return pPurchaseOrder.PONum
    End Get
    Set(value As String)
      pPurchaseOrder.PONum = value
    End Set
  End Property

  Public ReadOnly Property SupplierContactName() As String
    Get
      Return pPurchaseOrder.SupplierContactName
    End Get

  End Property

  Public ReadOnly Property SupplierContactTel() As String
    Get
      Return pPurchaseOrder.SupplierContactTel
    End Get

  End Property

  Public ReadOnly Property Category() As Byte
    Get
      Return pPurchaseOrder.Category
    End Get

  End Property

  Public ReadOnly Property SubmissionDate() As DateTime
    Get
      Return pPurchaseOrder.SubmissionDate
    End Get
  End Property

  Public ReadOnly Property Status() As Byte
    Get
      Return pPurchaseOrder.Status
    End Get
  End Property

  Public ReadOnly Property DelStatus() As Byte
    Get
      Return pPurchaseOrder.DelStatus
    End Get
  End Property

  Public ReadOnly Property Instructions() As String
    Get
      Return pPurchaseOrder.Instructions
    End Get
  End Property

  Public ReadOnly Property Comments() As String
    Get
      Return pPurchaseOrder.Comments
    End Get
  End Property

  Public ReadOnly Property BuyerID() As Byte
    Get
      Return pPurchaseOrder.BuyerID
    End Get
  End Property

  Public ReadOnly Property AcknowledgementNo() As String
    Get
      Return pPurchaseOrder.AcknowledgementNo
    End Get
  End Property

  Public ReadOnly Property OrderType() As Byte
    Get
      Return pPurchaseOrder.OrderType
    End Get
  End Property

  Public ReadOnly Property Carriage() As Double
    Get
      Return pPurchaseOrder.Carriage
    End Get
  End Property

  Public ReadOnly Property VatRate() As Decimal
    Get
      Return pPurchaseOrder.VatRate
    End Get
  End Property

  Public ReadOnly Property RequiredDate() As DateTime
    Get
      Return pPurchaseOrder.RequiredDate
    End Get
  End Property

  Public ReadOnly Property PurchaseCategory() As Byte
    Get
      Return pPurchaseOrder.PurchaseCategory
    End Get
  End Property

  Public ReadOnly Property CoCOrder() As Boolean
    Get
      Return pPurchaseOrder.CoCOrder
    End Get
  End Property

  Public ReadOnly Property CoCType() As Byte
    Get
      Return pPurchaseOrder.CoCType
    End Get
  End Property

  Public ReadOnly Property PriceGross() As Decimal
    Get
      Return pPurchaseOrder.PriceGross
    End Get
  End Property

  Public ReadOnly Property TotalPrice() As Decimal
    Get
      Return pPurchaseOrder.TotalPrice
    End Get
  End Property

  Public ReadOnly Property DeliveryAddress As String
    Get
      Return pPurchaseOrder.DeliveryAddress.FullAddress(vbCrLf)
    End Get
  End Property

  Public ReadOnly Property CompanyName() As String
    Get
      Return pPurchaseOrder.Supplier.CompanyName
    End Get
  End Property

  Public ReadOnly Property TotalVAT As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += mPOItemInfo.VATAmount
      Next
      mRetVal += pPurchaseOrder.CarriageVAT()
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalNetValue As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += mPOItemInfo.Price
      Next
      mRetVal += pPurchaseOrder.Carriage
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalGrossValue As Decimal
    Get
      Dim mRetVal As Decimal
      For Each mPOItemInfo As clsPOItemInfo In pPOItemInfos
        mRetVal += mPOItemInfo.GrossPrice
      Next
      mRetVal += (pPurchaseOrder.Carriage + pPurchaseOrder.CarriageVAT)
      Return mRetVal
    End Get
  End Property





  Public Property StockItemCode As String
    Get
      Return pStockItem.StockCode
    End Get
    Set(value As String)
      pStockItem.StockCode = value
    End Set
  End Property


  Public Property STOCKDESCRIPTION As String
    Get
      Return pStockItem.Description
    End Get
    Set(value As String)
      pStockItem.Description = value
    End Set
  End Property
  Public Property StockItemID As Int32
    Get
      Return pStockItem.StockItemID
    End Get
    Set(value As Int32)
      pStockItem.StockItemID = value
    End Set
  End Property

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

End Class

Public Class colPurchaseOrderInfos : Inherits List(Of clsPurchaseOrderInfo)

End Class

Public Class clsPOItemInfo
  Private pPOItem As dmPurchaseOrderItem
  Private pStockItem As dmStockItem

  Public Sub New(ByRef rPOItem As dmPurchaseOrderItem, ByRef rStockItem As dmStockItem)
    pPOItem = rPOItem
    pStockItem = rStockItem
  End Sub

  Public ReadOnly Property Qty As Decimal
    Get
      Return pPOItem.QtyRequired
    End Get
  End Property

  Public ReadOnly Property SupplierCode As String
    Get
      Return pPOItem.SupplierCode
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pPOItem.Description
    End Get
  End Property

  Public ReadOnly Property UnitPrice As Decimal
    Get
      Return pPOItem.UnitPrice
    End Get
  End Property

  Public ReadOnly Property Density As Decimal
    Get
      Return pPOItem.Density
    End Get
  End Property



  Public ReadOnly Property Price As Decimal
    Get
      Return pPOItem.NetAmount
    End Get
  End Property

  Public ReadOnly Property VATAmount As Decimal
    Get
      Return pPOItem.VATAmount
    End Get

  End Property

  Public ReadOnly Property GrossPrice As Decimal
    Get
      Return pPOItem.GrossAmount
    End Get
  End Property
End Class

Public Class colPOItemInfos : Inherits List(Of clsPOItemInfo)

End Class
