Public Class clsMaterialRequirementProcessor : Inherits clsMaterialRequirementInfo

  Public StockItemTransactions As Object
  Private pToProcessQty As Decimal
  Private pReferenceNo As String
  Private pPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos
  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    MyBase.New(rMaterialRequirement)

    pPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfos
  End Sub

  Public Property ToProcessQty As Decimal
    Get
      Return pToProcessQty
    End Get
    Set(value As Decimal)
      pToProcessQty = value
    End Set
  End Property

  Public Property ReferenceNo As String
    Get
      Return pReferenceNo
    End Get
    Set(value As String)
      pReferenceNo = value
    End Set
  End Property

  Public Property POItemAllocationInfos As colPurchaseOrderItemAllocationInfos
    Get
      Return pPOItemAllocationInfos
    End Get
    Set(value As colPurchaseOrderItemAllocationInfos)
      pPOItemAllocationInfos = value
    End Set
  End Property

  Public Property QtyReceived As Decimal
  Public Property FromStock As Decimal
  Public Property StockItemLocations As Object
  Public Property ToOrder As Integer
  Public Property QuantityRequired As Integer
  Public Property QtyOrdered As Integer
  Public Property POCOItemAllocationInfos As Object
End Class

Public Class colMaterialRequirementProcessors : Inherits List(Of clsMaterialRequirementProcessor)

End Class


