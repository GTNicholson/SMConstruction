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



End Class
