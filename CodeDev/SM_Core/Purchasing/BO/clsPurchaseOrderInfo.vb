Public Class clsPurchaseOrderInfo
  Private pPurchaseOrder As dmPurchaseOrder

  Private pPOItemInfos As colPOItemInfos
  Private pPOItem As dmPurchaseOrderItem
  Private pStockItem As dmStockItem
  Private pBuyerName As String
  Private pSupplierContactName As String

  Public Sub New()
    pPurchaseOrder = New dmPurchaseOrder
    pPOItem = New dmPurchaseOrderItem
  End Sub

  Public Sub New(ByRef rPurchaseOrder As dmPurchaseOrder)
    rPurchaseOrder = rPurchaseOrder

    pPOItem = New dmPurchaseOrderItem

  End Sub

  Public Property BuyerName As String
    Get
      Return pBuyerName
    End Get
    Set(value As String)
      pBuyerName = value
    End Set
  End Property

  Public Property SupplierContactName As String
    Get
      Return pSupplierContactName
    End Get
    Set(value As String)
      pSupplierContactName = value
    End Set
  End Property


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

  Public Property SubmissionDate() As DateTime
    Get
      Return pPurchaseOrder.SubmissionDate
    End Get
    Set(value As DateTime)
      pPurchaseOrder.SubmissionDate = value
    End Set
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

  Public Property RequiredDate() As DateTime
    Get
      Return pPurchaseOrder.RequiredDate
    End Get
    Set(value As DateTime)
      pPurchaseOrder.RequiredDate = value
    End Set
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


  Public ReadOnly Property PaymentStatus As Integer
    Get
      Return pPurchaseOrder.PaymentStatus
    End Get
  End Property
  Public ReadOnly Property DeliveryAddress As String
    Get
      Return pPurchaseOrder.DeliveryAddress.FullAddress(vbCrLf)
    End Get
  End Property

  Public Property CompanyName() As String
    Get
      Return pPurchaseOrder.Supplier.CompanyName
    End Get
    Set(value As String)
      pPurchaseOrder.Supplier.CompanyName = value
    End Set
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

  Public ReadOnly Property AnyCoC As Boolean
    Get
      Dim mRetVal As Boolean = False
      For Each mPOItem As dmPurchaseOrderItem In pPurchaseOrder.PurchaseOrderItems
        If mPOItem.CoCType <> eCOCType.None And mPOItem.CoCType <> eCOCType.Uncertified Then
          mRetVal = True
          Exit For
        End If
      Next
      Return mRetVal
    End Get
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


  Public ReadOnly Property PurchaseRefCodes As String
    Get
      Dim mRetVal As String = ""
      mRetVal = pPOItem.PartNo
      If pPOItem.SupplierCode <> "" Then
        If mRetVal <> "" Then mRetVal &= " / "
        mRetVal = mRetVal & pPOItem.SupplierCode
      End If
      Return mRetVal
    End Get
  End Property


  Public Property StockCode As String
    Get
      Return pPOItem.StockCode
    End Get
    Set(value As String)
      pPOItem.StockCode = value
    End Set
  End Property

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

  Public ReadOnly Property CoCType As String
    Get
      Return RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eCOCType), CType(pPOItem.CoCType, eCOCType))
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

  Public ReadOnly Property AllocationItemRefSummary As String
    Get
      Dim mRetVal As String = ""

      For Each mPOIA As dmPurchaseOrderItemAllocation In pPOItem.PurchaseOrderItemAllocations
        If mRetVal = "" Then mRetVal &= vbCrLf

        mRetVal &= mPOIA.ItemRef & " / " & mPOIA.Quantity.ToString("N2") & vbCrLf

      Next

      Return Description & vbCrLf & mRetVal
    End Get
  End Property

End Class

Public Class colPOItemInfos : Inherits List(Of clsPOItemInfo)

End Class
