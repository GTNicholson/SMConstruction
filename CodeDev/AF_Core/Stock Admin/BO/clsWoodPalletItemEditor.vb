Imports System.ComponentModel

Public Class clsWoodPalletItemEditor

  Private pWoodPallet As dmWoodPallet
  Private pWoodPalletItem As dmWoodPalletItem
  Private pStockItem As dmStockItem


  Public Sub New(ByVal vWoodPallet As dmWoodPallet, ByVal vWoodPalletItem As dmWoodPalletItem)
    pWoodPallet = vWoodPallet
    pWoodPalletItem = vWoodPalletItem


  End Sub

  Public Sub New()
    pWoodPallet = New dmWoodPallet
    pWoodPalletItem = New dmWoodPalletItem


  End Sub

  Public ReadOnly Property WoodPalletItem As dmWoodPalletItem
    Get
      Return pWoodPalletItem
    End Get
  End Property


  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property Quantity As Int32
    Get
      Return pWoodPalletItem.Quantity
    End Get
    Set(value As Int32)
      pWoodPalletItem.Quantity = value
    End Set
  End Property

  Public Property QuantityUsed As Int32
    Get
      Return pWoodPalletItem.QuantityUsed
    End Get
    Set(value As Int32)
      pWoodPalletItem.QuantityUsed = value
    End Set
  End Property

End Class

Public Class colWoodPalletItemEditors : Inherits BindingList(Of clsWoodPalletItemEditor)




End Class