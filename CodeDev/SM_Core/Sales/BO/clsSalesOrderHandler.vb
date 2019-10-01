Imports RTIS.CommonVB

Public Class clsSalesOrderHandler
  Private pSalesOrder As dmSalesOrder

  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder
  End Sub

  Public Function AddSalesOrderItem(ByVal vProductType As eProductType) As dmSalesOrderItem
    Dim mNewSOI As dmSalesOrderItem = Nothing
    Dim mNewWO As dmWorkOrder
    Try
      mNewSOI = New dmSalesOrderItem
      mNewSOI.SalesOrderID = pSalesOrder.SalesOrderID
      mNewSOI.ItemNumber = pSalesOrder.SalesOrderItems.GetNextItemNumber

      mNewWO = New dmWorkOrder
      mNewWO.SalesOrderID = pSalesOrder.SalesOrderID
      mNewWO.ProductTypeID = vProductType
      mNewWO.DateCreated = Now.Date
      mNewWO.Product = clsProductSharedFuncs.NewProductInstance(mNewWO.ProductTypeID)

      ''pSalesOrder.WorkOrders.Add(mNewWO)
      mNewSOI.WorkOrders.Add(mNewWO)

      pSalesOrder.SalesOrderItems.Add(mNewSOI)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewSOI
  End Function

  Public Function AddWorkOrder(ByRef rSOI As dmSalesOrderItem, ByVal vProductType As eProductType) As dmWorkOrder
    Dim mNewWO As dmWorkOrder = Nothing
    Try
      mNewWO = New dmWorkOrder
      mNewWO.SalesOrderID = pSalesOrder.SalesOrderID
      mNewWO.ProductTypeID = vProductType
      mNewWO.DateCreated = Now.Date
      mNewWO.Product = clsProductSharedFuncs.NewProductInstance(mNewWO.ProductTypeID)

      'pSalesOrder.WorkOrders.Add(mNewWO)

      rSOI.WorkOrders.Add(mNewWO)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewWO
  End Function

  Public Sub RemoveWorkOrder(ByRef rWorkOrder As dmWorkOrder)
    Try
      For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems
        If mSOI.WorkOrders.Contains(rWorkOrder) Then
          mSOI.WorkOrders.Remove(rWorkOrder)
        End If
      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub RemoveSalesOrderItem(ByRef rSalesOrderItem As dmSalesOrderItem)
    Try
      pSalesOrder.SalesOrderItems.Remove(rSalesOrderItem)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class
