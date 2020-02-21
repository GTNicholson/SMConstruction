Imports RTIS.CommonVB

Public Class clsStockItemInfo
  Private pStockItem As dmStockItem
  Private pCurrentInventory As Decimal
  Private pRequiredInventory As Decimal
  Private pOrderQty As Decimal
  Private pBalance As Decimal
  Private pQty As Decimal
  Private pPOStockItem As dmPurchaseOrderItem
  Private pSupplier As dmSupplier

  Public Sub New(ByRef rPurchaseOrderItem As dmPurchaseOrderItem)
    pPOStockItem = rPurchaseOrderItem

    pStockItem = New dmStockItem
    pSupplier = New dmSupplier

  End Sub


  Public Sub New()
    MyBase.New()
    pStockItem = New dmStockItem
    pPOStockItem = New dmPurchaseOrderItem
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Property CurrentInventory() As Decimal
    Get
      Return pCurrentInventory
    End Get
    Set(ByVal value As Decimal)
      pCurrentInventory = value
    End Set
  End Property

  Public Property RequiredInventory() As Decimal
    Get
      Return pRequiredInventory
    End Get
    Set(ByVal value As Decimal)
      pRequiredInventory = value
    End Set
  End Property

  Public Property OrderQty() As Decimal
    Get
      Return pOrderQty
    End Get
    Set(ByVal value As Decimal)
      pOrderQty = value
    End Set
  End Property

  Public Property Balance() As Decimal
    Get
      Return pCurrentInventory + pOrderQty - pRequiredInventory
    End Get
    Set(ByVal value As Decimal)
      pBalance = value
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

  Public ReadOnly Property StockItemCategoryDesc As String
    Get
      Dim mRetVal As String = ""
      If pStockItem IsNot Nothing Then
        mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pStockItem.Category, eStockItemCategory))
      End If
      Return mRetVal
    End Get
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

  Public Property DefaultSupplier() As Int32
    Get
      Return pStockItem.DefaultSupplier
    End Get
    Set(value As Int32)
      pStockItem.DefaultSupplier = value
    End Set
  End Property



  Public ReadOnly Property Category() As Integer
    Get
      Return pStockItem.Category
    End Get

  End Property
  Public ReadOnly Property ItemType() As Integer
    Get
      Return pStockItem.ItemType
    End Get

  End Property

  Public ReadOnly Property Species() As Int32
    Get
      Return pStockItem.Species
    End Get

  End Property
  Public ReadOnly Property Colour() As String
    Get
      Return pStockItem.Colour
    End Get

  End Property
  Public ReadOnly Property PartNo() As String
    Get
      Return pStockItem.PartNo
    End Get

  End Property

  Public ReadOnly Property ASISID() As Int32
    Get
      Return pStockItem.ASISID
    End Get

  End Property

  Public ReadOnly Property Description() As String
    Get
      Return pStockItem.Description
    End Get

  End Property

  Public ReadOnly Property Length() As Decimal
    Get
      Return pStockItem.Length
    End Get

  End Property
  Public ReadOnly Property Width() As Decimal
    Get
      Return pStockItem.Length
    End Get

  End Property
  Public ReadOnly Property Thickness() As Decimal
    Get
      Return pStockItem.Thickness
    End Get

  End Property

  Public ReadOnly Property StdCost() As Decimal
    Get
      Return pStockItem.StdCost
    End Get

  End Property

  Public ReadOnly Property qty() As Decimal
    Get
      Return pQty
    End Get

  End Property

End Class





Public Class colStockItemInfos : Inherits List(Of clsStockItemInfo)

End Class