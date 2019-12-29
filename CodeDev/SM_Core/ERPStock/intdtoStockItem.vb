Public Interface intdtoStockItem
  Function LoadStockItemsDictByParams(ByRef rStockItemsDict As Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef), ByRef rParams As Hashtable) As Boolean
End Interface
