Imports RTIS.CommonVB

Public Class clsSalesOrderHandler
  Private pSalesOrder As dmSalesOrder

  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder
  End Sub

  Public Function AddSalesOrderItem(ByVal vProductType As eProductType) As dmSalesOrderItem
    Dim mNewSOI As dmSalesOrderItem = Nothing
    Try
      mNewSOI = New dmSalesOrderItem
      mNewSOI.SalesOrderID = pSalesOrder.SalesOrderID
      mNewSOI.ItemNumber = pSalesOrder.SalesOrderItems.GetNextItemNumber

      AddWorkOrder(mNewSOI, vProductType)

      pSalesOrder.SalesOrderItems.Add(mNewSOI)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewSOI
  End Function

  Public Function AddWorkOrder(ByRef rSOI As dmSalesOrderItem, ByVal vProductType As eProductType) As dmWorkOrder
    Dim mNewWO As dmWorkOrder = Nothing
    Dim mWOB As dmWorkOrderBatch
    Dim mWOHandler As clsWorkOrderHandler

    Try
      mNewWO = New dmWorkOrder
      mNewWO.SalesOrderID = pSalesOrder.SalesOrderID
      mNewWO.ProductTypeID = vProductType
      mNewWO.DateCreated = Now.Date
      mNewWO.Product = clsProductSharedFuncs.NewProductInstance(mNewWO.ProductTypeID)

      mWOB = New dmWorkOrderBatch
      mNewWO.WorkOrderBatches.Add(mWOB)

      mWOHandler = New clsWorkOrderHandler(mNewWO)
      mWOHandler.AssignWOBatchRefs()

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

  Public Function GetTotalValue() As Decimal
    Dim mRetVal As Decimal
    For Each mSalesOrderOrderItem In pSalesOrder.SalesOrderItems
      mRetVal = mRetVal + (mSalesOrderOrderItem.Quantity * mSalesOrderOrderItem.UnitPrice)

    Next
    Return mRetVal
  End Function

  Public Function GetCostShipping() As Decimal
    Return pSalesOrder.ShippingCost
  End Function

End Class
