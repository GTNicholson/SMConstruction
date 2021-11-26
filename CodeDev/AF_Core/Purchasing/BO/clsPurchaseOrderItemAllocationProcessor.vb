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

  Public ReadOnly Property TotalPriceByDelItemQty() As Decimal
    Get
      Return UnitPrice * DelItemQty
    End Get

  End Property




End Class

Public Class colPurchaseOrderItemAllocationProcessor : Inherits List(Of clsPurchaseOrderItemAllocationProcessor)

  Public Function TotalNetValue() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem In Me
      mRetVal = mRetVal + mItem.TotalPriceByDelItemQty
    Next

    Return mRetVal
  End Function

  Public Function TotalVAT() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem In Me
      If mItem.ReceivedQty > 0 Then
        Dim mPrice As Decimal = mItem.UnitPrice
        Dim mVATValue As Decimal = mItem.PurchaseOrderItem.VatValue * mItem.Quantity
        mRetVal = mRetVal + mVATValue
      End If

    Next

    Return mRetVal
  End Function

  Public ReadOnly Property TotalGrossValue As Decimal
    Get
      Dim mRetVal As Decimal
      Dim mPO As dmPurchaseOrder
      For Each mItem As clsPurchaseOrderItemAllocationProcessor In Me
        If mItem.ReceivedQty > 0 Then
          mRetVal += (mItem.ReceivedQty * mItem.UnitPrice) + TotalVAT()
          mPO = mItem.PurchaseOrder
        End If
      Next

      Return mRetVal
    End Get
  End Property

  Public Function TotalRetention() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem In Me
      If mItem.ReceivedQty > 0 Then
        Dim mPrice As Decimal = mItem.UnitPrice
        Dim mVATValue As Decimal = mItem.TotalPriceByDelItemQty * mItem.PurchaseOrderItem.TempPercentageRetention
        mRetVal = mRetVal + mVATValue
      End If

    Next

    Return mRetVal
  End Function
End Class



