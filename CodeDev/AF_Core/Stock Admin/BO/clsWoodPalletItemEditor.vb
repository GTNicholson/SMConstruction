﻿Imports System.ComponentModel

Public Class clsWoodPalletItemEditor : Inherits dmWoodPalletItem


  Private pWoodPallet As dmWoodPallet
  Private pWoodPalletItem As dmWoodPalletItem
  Private pStockItem As dmStockItem
  Private pToProcessQty As Decimal

  Public Sub New(ByVal vWoodPallet As dmWoodPallet, ByVal vWoodPalletItem As dmWoodPalletItem)
    pWoodPallet = vWoodPallet
    pWoodPalletItem = vWoodPalletItem
    pStockItem = New dmStockItem
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
          mRetVal = mSpecies.SpanishDescription

        End If

      End If

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property OutStandingQty() As Decimal
    Get
      Return pWoodPalletItem.Quantity - pWoodPalletItem.QuantityUsed
    End Get

  End Property

  Public ReadOnly Property TotalBoardFeetFromInches() As Decimal
    Get
      Dim mRetVal As Decimal

      If pWoodPalletItem IsNot Nothing Then
        mRetVal = (ToProcessQty * WoodPalletItem.Thickness * WoodPalletItem.Width * WoodPalletItem.Length) / 12

      End If
      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property TotalCentimeterCubic
End Class

Public Class colWoodPalletItemEditors : Inherits BindingList(Of clsWoodPalletItemEditor)




End Class