Public Class clsSalesOrderManager

  Private pSalesOrder As dmSalesOrder

  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder
  End Sub

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property



  Public Sub AddProducts(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProducts As List(Of clsProductBaseInfo))
    For Each mProduct As clsProductBaseInfo In rProducts
      AddProduct(rSalesItemAssembly, mProduct)
    Next

  End Sub

  Public Sub AddProduct(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProduct As clsProductBaseInfo)
    Dim mSalesItem As dmSalesOrderItem
    mSalesItem = New dmSalesOrderItem
    mSalesItem.SalesOrderID = pSalesOrder.SalesOrderID
    mSalesItem.ProductID = rProduct.ID
    mSalesItem.ProductTypeID = rProduct.ProductTypeID
    mSalesItem.SalesItemAssemblyID = rSalesItemAssembly.SalesItemAssemblyID
    mSalesItem.Description = rProduct.Description
    pSalesOrder.SalesOrderItems.Add(mSalesItem)

  End Sub
End Class
