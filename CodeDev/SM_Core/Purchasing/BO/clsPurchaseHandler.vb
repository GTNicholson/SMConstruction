Public Class clsPurchaseHandler


  Public Function CreateSOPMatReqCatDefaultPO(ByVal vSalesOrderPhaseID As Integer, ByVal vSupplierID As Integer, ByVal vCategory As ePurchaseCategories) As dmPurchaseOrder
    Dim mPurchaseOrder As New dmPurchaseOrder
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOItemAllocation As dmPurchaseOrderItemAllocation

    mPurchaseOrder.SupplierID = vSupplierID
    mPurchaseOrder.Category = vCategory

    mPOItem = New dmPurchaseOrderItem
    mPurchaseOrder.PurchaseOrderItems.Add(mPOItem)


    mPOItemAllocation = New dmPurchaseOrderItemAllocation
    mPOItemAllocation.Quantity = 1
    mPOItemAllocation.CallOffID = vSalesOrderPhaseID
    mPOItem.PurchaseOrderItemAllocations.Add(mPOItemAllocation)

    Return mPurchaseOrder
  End Function

  Public Sub AddMatReqCatToPO(ByRef rPurchaseOrder As dmPurchaseOrder, ByVal vSalesOrderPhaseID As Integer)

    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOItemAllocation As dmPurchaseOrderItemAllocation


    mPOItem = New dmPurchaseOrderItem
    rPurchaseOrder.PurchaseOrderItems.Add(mPOItem)


    mPOItemAllocation = New dmPurchaseOrderItemAllocation
    mPOItemAllocation.Quantity = 1
    mPOItemAllocation.CallOffID = vSalesOrderPhaseID
    mPOItem.PurchaseOrderItemAllocations.Add(mPOItemAllocation)


  End Sub

  Public Shared Function AddPOItem(ByRef rPurchaseOrder As dmPurchaseOrder) As dmPurchaseOrderItem
    Dim mRetVal As New dmPurchaseOrderItem
    Dim mMRSI As New dmMaterialRequirement
    With mRetVal
      .PurchaseOrderID = rPurchaseOrder.PurchaseOrderID
      .VatRateCode = 1
    End With

    ''If rPurchaseOrder.CallOffType = eCallOffMode.SingleCO And rPurchaseOrder.POCallOffs IsNot Nothing AndAlso rPurchaseOrder.POCallOffs.Count > 0 Then
    ''  mMRSI.POItem = mRetVal
    ''  rPurchaseOrder.POCallOffs(0).POCallOffItems.Add(mMRSI)
    ''End If
    rPurchaseOrder.PurchaseOrderItems.Add(mRetVal)
    Return mRetVal
  End Function



End Class
