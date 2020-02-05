Public Class clsPurchaseOrderItemAllocationProcessor : Inherits clsPurchaseOrderItemAllocationInfo

  Private pToProcessQty As Decimal

  Private pReferenceNo As String

  Public Sub New(ByRef rPurchaseOrder As dmPurchaseOrderItemAllocation)
    MyBase.New(rPurchaseOrder)
  End Sub

  Public Property ToProcessQty As Decimal
    Get
      Return pToProcessQty
    End Get
    Set(value As Decimal)
      pToProcessQty = value
    End Set
  End Property

End Class

Public Class colPurchaseOrderItemAllocationProcessor : Inherits List(Of clsPurchaseOrderItemAllocationProcessor)

End Class



