Imports RTIS.ERPStock

Public Class clsPickerPurchaseOrder : Inherits clsPickerBase
  Public Sub New(ByVal vDataSource As colPurchaseOrders)
    MyBase.New
    DataSource = vDataSource
  End Sub

  ''AR: Adapted the new passing as parameter a colPurchaseOrderInfos
  Public Sub New(ByVal vDataSource As colPurchaseOrderInfos)
    MyBase.New
    DataSource = vDataSource
  End Sub
End Class
