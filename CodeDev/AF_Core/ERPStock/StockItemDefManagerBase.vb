Public MustInherit Class StockItemDefManagerBase
  Protected pStockItem As RTIS.ERPStock.intStockItemDef

  Public Sub New(ByRef rStockItem As RTIS.ERPStock.intStockItemDef)
    pStockItem = rStockItem
  End Sub

  Public MustOverride Function GenerateStockCode() As String

  Public MustOverride Function GenerateDescription() As String

  Public MustOverride Function ValidateStockItem() As RTIS.CommonVB.clsValidate

End Class
