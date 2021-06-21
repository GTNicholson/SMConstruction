Public Class clsPurchaseHandler




  Public Shared Function AddPOItem(ByRef rPurchaseOrder As dmPurchaseOrder) As dmPurchaseOrderItem
    Dim mRetVal As New dmPurchaseOrderItem
    Dim mMRSI As New dmMaterialRequirement
    With mRetVal
      .PurchaseOrderID = rPurchaseOrder.PurchaseOrderID
      .VatRateCode = 1
    End With

    rPurchaseOrder.PurchaseOrderItems.Add(mRetVal)
    Return mRetVal
  End Function

  Public Function CreateSOPMatReqCatDefaultPO(ByVal vSalesOrderPhaseID As Integer, ByVal vSupplierID As Integer, ByVal vCategory As eStockItemCategory) As dmPurchaseOrder
    Dim mPurchaseOrder As New dmPurchaseOrder
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOItemAllocation As dmPurchaseOrderItemAllocation
    Dim mPOA As dmPurchaseOrderAllocation

    mPurchaseOrder.SupplierID = vSupplierID
    mPurchaseOrder.Category = vCategory


    mPOA = New dmPurchaseOrderAllocation
    mPOA.CallOffID = vSalesOrderPhaseID
    mPurchaseOrder.PurchaseOrderAllocations.Add(mPOA)
    Return mPurchaseOrder
  End Function



  Public Sub RefreshWorkOrderMatRecCategoryStatusInfo(ByRef rWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus, ByRef rPurchaseOrders As colPurchaseOrders)
    Dim mMaxDate As Date
    Dim mMaxCompletedDate As Date
    Dim mAllReceived As Boolean = True

    For Each mPO In rPurchaseOrders
      Select Case mPO.Status
        Case ePurchaseOrderDueDateStatus.Received
        Case Else
          mAllReceived = False
      End Select
      If mPO.SubmissionDate > mMaxCompletedDate Then mMaxCompletedDate = mPO.SubmissionDate
      If mPO.SubmissionDate > mMaxDate Then mMaxDate = mPO.SubmissionDate
      If mPO.RequiredDate > mMaxDate Then mMaxDate = mPO.RequiredDate
    Next
    If rPurchaseOrders.Count > 0 Then
      If mAllReceived Then
        rWorkOrderMatReqCategoryStatus.Status = eMatReqCategoryStatus.Received
        If mMaxDate > mMaxCompletedDate Then mMaxDate = mMaxCompletedDate
      Else
        rWorkOrderMatReqCategoryStatus.Status = eMatReqCategoryStatus.Ordered
      End If
      rWorkOrderMatReqCategoryStatus.LastDate = mMaxDate
    Else
      rWorkOrderMatReqCategoryStatus.LastDate = New Date
    End If

  End Sub

End Class
