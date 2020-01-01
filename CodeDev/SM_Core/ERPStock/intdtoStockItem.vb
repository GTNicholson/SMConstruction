Public Interface intdtoStockItem

  ReadOnly Property KeyFieldName As String

  Function LoadStockItem(ByRef rStockItem As dmStockItem, ByVal vStockItemID As Integer) As Boolean

  Function LoadStockItemsDictByParams(ByRef rStockItemsDict As Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef), ByRef rParams As Hashtable) As Boolean

End Interface
