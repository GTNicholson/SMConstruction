Imports System.ComponentModel

Public Class clsWoodPalletItemEditor : Inherits dmWoodPalletItem


  Private pWoodPallet As dmWoodPallet
  Private pWoodPalletItem As dmWoodPalletItem
  Private pStockItem As dmStockItem
  Private pToProcessQty As Decimal
  Private pIsSelected As Boolean

  Public Sub New(ByVal vWoodPalletItem As dmWoodPalletItem, ByVal vStockItem As dmStockItem)
    pWoodPalletItem = vWoodPalletItem
    pStockItem = vStockItem
  End Sub

  Public Sub New()
    pWoodPallet = New dmWoodPallet
    pWoodPalletItem = New dmWoodPalletItem

    pStockItem = New dmStockItem
  End Sub

  Public Property WoodPalletItem As dmWoodPalletItem
    Get
      Return pWoodPalletItem
    End Get
    Set(value As dmWoodPalletItem)
      pWoodPalletItem = value
    End Set
  End Property

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
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

  Public ReadOnly Property ItemTypeDesc As String
    Get
      Dim mRetVal As String = ""
      If StockItem IsNot Nothing Then
        mRetVal = clsStockItemSharedFuncs.GetStockItemTypeDescription(StockItem)

      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property SpeciesDesc As String
    Get
      Dim mRetVal As String = ""
      Dim mSpecies As dmWoodSpecie
      If StockItem IsNot Nothing Then
        mSpecies = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies).ItemFromKey(StockItem.Species)

        If mSpecies IsNot Nothing Then
          If mSpecies.SpanishDescription = "" Then
            mRetVal = mSpecies.EnglishDescription.Trim
          Else
            mRetVal = mSpecies.SpanishDescription.Trim

          End If

        End If

      End If

      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property TotalBoardFeet As Decimal
    Get
      Dim mRetVal As Decimal
      mRetVal = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(pWoodPalletItem, pStockItem)
      Return Math.Round(mRetVal, 2, MidpointRounding.AwayFromZero)
    End Get
  End Property

  Public ReadOnly Property Totalm3 As Decimal
    Get
      Dim mRetVal As Decimal
      If pStockItem IsNot Nothing Then
        If pStockItem.ItemType = eStockItemTypeTimberWood.Rollo Then
          mRetVal = clsWoodPalletSharedFuncs.BoardFeetToM3(TotalBoardFeet) ' pWoodPalletItem.Quantity
        Else
          mRetVal = clsWoodPalletSharedFuncs.BoardFeetToM3(TotalBoardFeet)

        End If
      End If
      Return mRetVal
    End Get
  End Property

  Public Property QuantityUI As Decimal
    Get
      Dim mRetVal As Decimal
      Select Case pStockItem.ItemType
        Case eStockItemTypeTimberWood.Rollo, eStockItemTypeTimberWood.Arbol
          mRetVal = pWoodPalletItem.Quantity 'clsWoodPalletSharedFuncs.BoardFeetToM3(pWoodPalletItem.Quantity)
        Case Else
          mRetVal = pWoodPalletItem.Quantity
      End Select

      Return mRetVal
    End Get
    Set(value As Decimal)
      pWoodPalletItem.Quantity = value
    End Set
  End Property

  Public ReadOnly Property QuantityUsedUI As Decimal
    Get
      Dim mRetVal As Decimal
      Select Case pStockItem.ItemType
        Case eStockItemTypeTimberWood.Rollo, eStockItemTypeTimberWood.Arbol
          mRetVal = pWoodPalletItem.QuantityUsed 'clsWoodPalletSharedFuncs.BoardFeetToM3(pWoodPalletItem.QuantityUsed)
        Case Else
          mRetVal = pWoodPalletItem.QuantityUsed
      End Select

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property ToProcessBoardFeet() As Decimal
    Get
      Dim mRetVal As Decimal

      If pWoodPalletItem IsNot Nothing Then
        mRetVal = (ToProcessQty * WoodPalletItem.Thickness * WoodPalletItem.Width * WoodPalletItem.Length) / 12

      End If
      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property DescriptionWPI As String
    Get
      Return pWoodPalletItem.Description
    End Get
  End Property

  Public ReadOnly Property Balance As Decimal
    Get
      Return pWoodPalletItem.Quantity - pWoodPalletItem.QuantityUsed
    End Get
  End Property

  Public Property IsSelected As Boolean
    Get
      Return pIsSelected
    End Get
    Set(value As Boolean)
      pIsSelected = value
    End Set
  End Property

End Class

Public Class colWoodPalletItemEditors : Inherits BindingList(Of clsWoodPalletItemEditor)




  End Class