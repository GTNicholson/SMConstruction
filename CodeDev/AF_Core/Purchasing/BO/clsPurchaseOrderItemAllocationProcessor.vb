Public Class clsPurchaseOrderItemAllocationProcessor : Inherits clsPurchaseOrderItemAllocationInfo
  Private pPODeliveryItem As dmPODeliveryItem

  Private pToProcessQty As Decimal
  Private pToProcessReplacementQty As Decimal
  Private pToProcessAllQty As Decimal
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



  Public Property ToProcessReplacementQty As Decimal
    Get
      Return pToProcessReplacementQty
    End Get
    Set(value As Decimal)
      pToProcessReplacementQty = value
    End Set
  End Property

  Public Property PODeliveryItem As dmPODeliveryItem
    Get
      Return pPODeliveryItem
    End Get
    Set(value As dmPODeliveryItem)
      pPODeliveryItem = value
    End Set
  End Property

  Public ReadOnly Property DelItemQty As Decimal
    Get
      Dim mRetVal As Decimal = 0
      If pPODeliveryItem IsNot Nothing Then
        mRetVal = pPODeliveryItem.QtyReceived
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalPrice() As Decimal
    Get
      Return UnitPrice * ToProcessQty
    End Get

  End Property
End Class

Public Class colPurchaseOrderItemAllocationProcessor : Inherits List(Of clsPurchaseOrderItemAllocationProcessor)

End Class



