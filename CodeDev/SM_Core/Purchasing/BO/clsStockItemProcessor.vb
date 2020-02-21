Public Class clsStockItemProcessor : Inherits clsStockItemInfo
  Private pToProcessQty As Decimal


  Public Sub New(ByRef rPurchaseOrderItem As dmPurchaseOrderItem)
    MyBase.New(rPurchaseOrderItem)
  End Sub

  Public Property ToProcessQty As Decimal
    Get
      Return pToProcessQty
    End Get
    Set(value As Decimal)
      pToProcessQty = value
    End Set
  End Property

End Class

Public Class colStockItemProcessors : Inherits List(Of clsStockItemProcessor)

End Class
