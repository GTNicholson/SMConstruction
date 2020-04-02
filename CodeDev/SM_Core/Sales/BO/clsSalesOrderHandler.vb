Imports RTIS.CommonVB

Public Class clsSalesOrderHandler
  Private pSalesOrder As dmSalesOrder
  Private pInvoice As dmInvoice

  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder

  End Sub

  Public Sub New(ByRef rInvoice As dmInvoice)
    pInvoice = rInvoice

  End Sub

  Public Function AddInvoiceSalesOrderItem() As dmInvoiceItem
    Dim mNewInvoiceSOI As dmInvoiceItem = Nothing
    Try
      mNewInvoiceSOI = New dmInvoiceItem
      mNewInvoiceSOI.InvoiceID = pInvoice.InvoiceID


      ''mNewSOI.ItemNumber = pSalesOrder.SalesOrderItems.GetNextItemNumber
      pInvoice.InvoiceItems.Add(mNewInvoiceSOI)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewInvoiceSOI
  End Function

  Public Function AddSalesOrderItem(ByVal vProductType As eProductType) As dmSalesOrderItem
    Dim mNewSOI As dmSalesOrderItem = Nothing
    Try
      mNewSOI = New dmSalesOrderItem
      mNewSOI.SalesOrderID = pSalesOrder.SalesOrderID
      ''mNewSOI.ItemNumber = pSalesOrder.SalesOrderItems.GetNextItemNumber

      AddWorkOrder(mNewSOI, vProductType)

      pSalesOrder.SalesOrderItems.Add(mNewSOI)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewSOI
  End Function

  Public Function AddWorkOrder(ByRef rSOI As dmSalesOrderItem, ByVal vProductType As eProductType) As dmWorkOrder
    Dim mNewWO As dmWorkOrder = Nothing
    Dim mWOHandler As clsWorkOrderHandler

    Try
      mNewWO = New dmWorkOrder
      mNewWO.SalesOrderID = pSalesOrder.SalesOrderID
      mNewWO.ProductTypeID = vProductType
      mNewWO.DateCreated = Now.Date
      mNewWO.Product = clsProductSharedFuncs.NewProductInstance(mNewWO.ProductTypeID)

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

  Public Sub RemoveInvoiceSalesOrderItem(ByRef rInvoiceSalesOrderItem As dmInvoiceItem)
    Try
      pInvoice.InvoiceItems.Remove(rInvoiceSalesOrderItem)
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
