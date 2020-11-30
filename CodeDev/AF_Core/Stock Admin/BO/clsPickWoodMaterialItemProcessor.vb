Public Class clsPickWoodMaterialItemProcessor : Inherits dmPickWoodMaterialItem
  Private pPickWoodMaterialItem As dmPickWoodMaterialItem
  Private pWoodPalletItem As dmWoodPalletItem
  Private pToProcessQty As Decimal
  Private pToProcessReplacementQty As Decimal
  Private pToProcessAllQty As Decimal
  Private pReferenceNo As String

  Public Sub New(ByRef rWoodPalletItem As dmWoodPalletItem)
    pWoodPalletItem = rWoodPalletItem
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

  Public Property PickWoodMaterialItem As dmPickWoodMaterialItem
    Get
      Return pPickWoodMaterialItem
    End Get
    Set(value As dmPickWoodMaterialItem)
      pPickWoodMaterialItem = value
    End Set
  End Property

  Public ReadOnly Property PickedItemQty As Decimal
    Get
      Dim mRetVal As Decimal = 0
      If pPickWoodMaterialItem IsNot Nothing Then
        mRetVal = pPickWoodMaterialItem.QtyPicked
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalPrice() As Decimal
    Get
      '  Return UnitPrice * ToProcessQty
      Return 0
    End Get

  End Property

  Public ReadOnly Property TotalPriceByDelItemQty() As Decimal
    Get
      'Return UnitPrice * PickedItemQty
      Return 0

    End Get

  End Property

End Class

Public Class colPickWoodMaterialItemProcessors : Inherits List(Of clsPickWoodMaterialItemProcessor)

End Class



