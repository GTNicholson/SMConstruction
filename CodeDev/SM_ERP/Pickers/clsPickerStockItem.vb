Public Class clsPickerStockItem : Inherits clsPickerBase(Of dmStockItem)
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Public Sub New(ByVal vDataSource As colStockItems)
    MyBase.New
    DataSource = vDataSource
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property
End Class
