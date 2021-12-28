Public Class clsMaterialRequirementProcessor : Inherits clsMaterialRequirementInfo

  Private pStockItemTransactions As colStockItemTransactionLogInfos
  Private pToProcessQty As Decimal
  Private pReferenceNo As String
  Private pPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos
  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    MyBase.New(rMaterialRequirement)

    pPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pStockItemTransactions = New colStockItemTransactionLogInfos
  End Sub

  Public Property StockItemTransactionInfoss As colStockItemTransactionLogInfos
    Get
      Return pStockItemTransactions
    End Get
    Set(value As colStockItemTransactionLogInfos)
      pStockItemTransactions = value
    End Set
  End Property
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



  Public Property FromStock As Decimal
  Public Property StockItemLocations As dmStockItemLocation
  Public Property ToOrder As Decimal


End Class

Public Class colMaterialRequirementProcessors : Inherits List(Of clsMaterialRequirementProcessor)

  Public Function GetFromStockQty(ByVal vStockItemID As Integer) As Decimal

    Dim mRetVal As Decimal

    For Each mItem In Me

      If mItem.MaterialRequirement.StockItemID = vStockItemID Then
        mRetVal = mRetVal + mItem.MaterialRequirement.FromStockQty
      End If
    Next

    Return mRetVal
  End Function

  Public Function GetTotalItemsToProcess() As Integer
    Dim mRetVal As Integer
    For Each mItem In Me

      If mItem.ToProcessQty > 0 Then
        mRetVal = mRetVal + 1
      End If
    Next
    Return mRetVal
  End Function
End Class


