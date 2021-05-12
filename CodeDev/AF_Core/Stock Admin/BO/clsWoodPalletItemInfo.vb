Imports RTIS.CommonVB

Public Class clsWoodPalletItemInfo
  Private pWoodPalletItem As dmWoodPalletItem
  Private pWoodPallet As dmWoodPallet
  Private pStockItem As dmStockItem
  Private pCostValue As Decimal


  Public Sub New()
    pWoodPalletItem = New dmWoodPalletItem
    pWoodPallet = New dmWoodPallet
    pStockItem = New dmStockItem
  End Sub


  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public Property WoodPalletItem As dmWoodPalletItem
    Get
      Return pWoodPalletItem
    End Get
    Set(value As dmWoodPalletItem)
      pWoodPalletItem = value
    End Set
  End Property

  Public Property WoodPallet As dmWoodPallet
    Get
      Return pWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pWoodPallet = value
    End Set
  End Property


  Public ReadOnly Property WoodPalletItemID As Integer
    Get
      Return pWoodPalletItem.WoodPalletItemID
    End Get

  End Property

  Public ReadOnly Property Width As Decimal
    Get
      Return pWoodPalletItem.Width
    End Get

  End Property

  Public ReadOnly Property Length As Decimal
    Get
      Return pWoodPalletItem.Length
    End Get

  End Property


  Public ReadOnly Property OutstandingQty As Decimal
    Get
      Return pWoodPalletItem.OutstandingQty
    End Get
  End Property
  Public ReadOnly Property Quantity As Decimal
    Get
      Return pWoodPalletItem.Quantity
    End Get
  End Property

  Public ReadOnly Property QuantityUsed As Integer
    Get
      Return pWoodPalletItem.QuantityUsed
    End Get
  End Property
  Public ReadOnly Property WoodPalletID As Integer
    Get
      Return pWoodPallet.WoodPalletID
    End Get

  End Property

  Public ReadOnly Property PalletRef As String
    Get
      Return pWoodPallet.PalletRef
    End Get

  End Property


  Public ReadOnly Property RefPalletOutside As String
    Get
      Return pWoodPallet.RefPalletOutside
    End Get

  End Property

  Public ReadOnly Property CreatedDate As Date
    Get
      Return pWoodPallet.CreatedDate
    End Get

  End Property

  Public ReadOnly Property LocationID As Integer
    Get
      Return pWoodPallet.LocationID
    End Get

  End Property


  Public ReadOnly Property LocationDesc As String
    Get
      Return pWoodPallet.LocationDesc
    End Get

  End Property

  Public ReadOnly Property StockItemID As Integer
    Get
      Return pStockItem.StockItemID
    End Get

  End Property

  Public ReadOnly Property StockCode As String
    Get
      Return pStockItem.StockCode
    End Get

  End Property

  Public ReadOnly Property Description As String
    Get
      Return pStockItem.Description
    End Get

  End Property

  Public ReadOnly Property Category As Int32
    Get
      Return pStockItem.Category
    End Get

  End Property

  Public ReadOnly Property CategoryDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(StockItem.Category, eStockItemCategory))
    End Get

  End Property


  Public ReadOnly Property StockItemType As Int32
    Get
      Return pStockItem.ItemType
    End Get
  End Property

  Public ReadOnly Property StockItemTypeDesc As String
    Get
      Dim mRetVal = ""

      If KilnStartDate <> Date.MinValue And KilnEndDate = Date.MinValue Then
        mRetVal = "En Horno"

      Else
        mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTimberWood), CType(pStockItem.ItemType, eStockItemTypeTimberWood.eStockItemTimberWood))
        mRetVal = mRetVal.Trim
        Return mRetVal
      End If

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property KilnNumber As Integer
    Get

      Return pWoodPallet.KilnNumber
    End Get
  End Property

  Public ReadOnly Property KilnNumberDesc As String
    Get
      Dim mRetVal As String

      If KilnStartDate <> Date.MinValue And KilnEndDate = Date.MinValue Then
        mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eKilns), CType(pWoodPallet.KilnNumber, eKilns))

      Else
        mRetVal = ""
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property Thickness As Decimal
    Get
      Return pWoodPalletItem.Thickness
    End Get
  End Property


  Public ReadOnly Property Species As Integer
    Get
      Return pStockItem.Species
    End Get
  End Property


  Public ReadOnly Property SpeciesDesc As String
    Get
      Dim mRetVal = ""

      mRetVal = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie).DisplayValueString(pStockItem.Species)
      mRetVal = mRetVal.Trim
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalBoardFeet
    Get
      Dim mRetVal As Decimal = 0
      Dim mBalance As Decimal
      mBalance = (pWoodPalletItem.Quantity - pWoodPalletItem.QuantityUsed)
      If mBalance > 0 Then
        mRetVal = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(pWoodPalletItem, pStockItem)
      End If

      Return mRetVal

    End Get

  End Property

  Public ReadOnly Property TotalCubicMeter
    Get
      If TotalBoardFeet = 0 Then
        Return 0
      Else
        Return TotalBoardFeet / clsConstants.BoardFeetPerM3
      End If

    End Get
  End Property

  Public Property UnitCost As Decimal
    Get
      Return pCostValue
    End Get
    Set(value As Decimal)
      pCostValue = value
    End Set
  End Property

  Public ReadOnly Property TotalCostBoardFeet As Decimal
    Get

      Return pCostValue * TotalBoardFeet
    End Get
  End Property

  Public ReadOnly Property TotalCostCubicMeter As Decimal
    Get

      Return pCostValue * TotalCubicMeter
    End Get
  End Property

  Public ReadOnly Property Balance As Decimal
    Get
      Dim mRetVal As Decimal
      Select Case pStockItem.ItemType
        Case eStockItemTypeTimberWood.Rollo, eStockItemTypeTimberWood.Arbol
          mRetVal = pWoodPalletItem.OutstandingQty
        Case Else
          mRetVal = pWoodPalletItem.OutstandingQty * (pWoodPalletItem.Thickness * pWoodPalletItem.Length * pWoodPalletItem.Width / 12)
      End Select

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property Radius As Decimal
    Get
      Return pWoodPalletItem.Thickness / 2
    End Get
  End Property


  Public ReadOnly Property KilnStartDate As Date
    Get
      Return pWoodPallet.KilnStartDate
    End Get
  End Property

  Public ReadOnly Property KilnEndDate As Date
    Get
      Return pWoodPallet.KilnEndDate
    End Get
  End Property

End Class

Public Class colWoodPalletItemInfos : Inherits List(Of clsWoodPalletItemInfo)

End Class

