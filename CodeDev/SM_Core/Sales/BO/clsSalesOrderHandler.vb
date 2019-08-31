Imports RTIS.CommonVB

Public Class clsSalesOrderHandler
  Private pSalesOrder As dmSalesOrder

  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder
  End Sub

  Public Sub AddWorkOrder(ByVal vProductType As eProductType)
    Dim mNewWO As dmWorkOrder
    Try
      mNewWO = New dmWorkOrder
      mNewWO.SalesOrderID = pSalesOrder.SalesOrderID
      mNewWO.ProductTypeID = vProductType

      mNewWO.Product = clsProductSharedFuncs.NewProductInstance(mNewWO.ProductTypeID)

      pSalesOrder.WorkOrders.Add(mNewWO)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub RemoveWorkOrder(ByRef rWorkOrder As dmWorkOrder)
    Try
      pSalesOrder.WorkOrders.Remove(rWorkOrder)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class
