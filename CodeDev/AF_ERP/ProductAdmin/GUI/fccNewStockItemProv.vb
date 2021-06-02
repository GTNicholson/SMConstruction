Imports RTIS.DataLayer

Public Class fccNewStockItemProv
  Private pDBConn As clsDBConnBase
  Private pStockItem As dmStockItem

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    Me.pDBConn = rDBConn

  End Sub

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Sub CreateNewProvStockItem()
    Dim mdso As New dsoStock(pDBConn)

    If pStockItem Is Nothing Then
      pStockItem = New dmStockItem
    End If
    pStockItem.IsProvisional = True

    If pStockItem.Description <> "" And pStockItem.Category > 0 Then
      AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(pStockItem)
    Else
      MessageBox.Show("Ingrese una descripción o categoría válida")
      pStockItem = Nothing
    End If
  End Sub
End Class
