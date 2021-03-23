Imports RTIS.CommonVB

Public Class clsWorkOrderHandler
  Private pWorkOrder As dmWorkOrder

  Public Sub New(ByRef rWorkOrder As dmWorkOrder)
    pWorkOrder = rWorkOrder
  End Sub

  Public Shared Function CreateInternalWorkOrder(ByVal vProductType As eProductType) As dmWorkOrder
    Dim mRetVal As dmWorkOrder
    mRetVal = New dmWorkOrder
    mRetVal.isInternal = True
    mRetVal.ProductTypeID = vProductType
    mRetVal.DateCreated = Now.Date
    mRetVal.Product = clsProductSharedFuncs.NewProductInstance(mRetVal.ProductTypeID)
    mRetVal.PlannedStartDate = Now.Date
    Return mRetVal
  End Function

  Public Shared Function CreateFromSalesOrderPhaseItems(ByRef rSalesOrderPhaseItems As List(Of clsSalesOrderPhaseItemInfo), ByVal vProductType As eProductType) As dmWorkOrder
    Dim mRetVal As dmWorkOrder
    Dim mWOA As dmWorkOrderAllocation
    mRetVal = New dmWorkOrder
    mRetVal.DateCreated = Now.Date
    mRetVal.Product = clsProductSharedFuncs.NewProductInstance(vProductType)
    mRetVal.ProductTypeID = vProductType
    mRetVal.isInternal = True
    If rSalesOrderPhaseItems IsNot Nothing Then

      If rSalesOrderPhaseItems.Count > 0 Then
        mRetVal.Product = rSalesOrderPhaseItems(0).Product
      End If
    End If

    For Each mSalesOrderPhaseItem In rSalesOrderPhaseItems
      mWOA = New dmWorkOrderAllocation
      mWOA.SalesOrderPhaseItemID = mSalesOrderPhaseItem.SalesOrderPhaseItemID
      mWOA.QuantityRequired = mSalesOrderPhaseItem.Qty
      mRetVal.WorkOrderAllocations.Add(mWOA)
    Next

    Return mRetVal
  End Function


End Class
