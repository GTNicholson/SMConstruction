Public Class clsPurchaseHandler




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
