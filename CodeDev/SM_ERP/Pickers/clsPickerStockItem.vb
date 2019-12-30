Public Class clsPickerStockItem : Inherits clsPickerBase(Of dmStockItem)

  Public Sub New(ByVal vDataSource As colStockItems)
    MyBase.New
    DataSource = vDataSource
  End Sub


End Class
