
Imports RTIS.CommonVB

Public Class clsWoodPalletItemContent
  Private pWoodPalletID As Integer
  Private pStockItemID As Integer
  Private pDescription As String
  Private pStockCode As String
  Private pPalletRef As String
  Private pLocationID As Integer
  Private pSUMQuantity As Decimal
  Private pSUMQuantityUsed As Decimal
  Private pWoodPalletItemID As Integer
  Private pThickness As Decimal
  Private pLength As Decimal
  Private pWidth As Decimal
  Private pPalletType As Integer

  Private pWoodPalletItems As colWoodPalletItemInfos
  Public Sub New()

    pWoodPalletItems = New colWoodPalletItemInfos
  End Sub


  Public Property WoodPalletItems As colWoodPalletItemInfos
    Get
      Return pWoodPalletItems
    End Get
    Set(value As colWoodPalletItemInfos)
      pWoodPalletItems = value
    End Set
  End Property
  Public Property WoodPalletID As Int32
    Get
      Return pWoodPalletID
    End Get
    Set(value As Int32)
      pWoodPalletID = value
    End Set
  End Property

  Public Property StockItemID As Int32
    Get
      Return pStockItemID
    End Get
    Set(value As Int32)
      pStockItemID = value
    End Set
  End Property



  Public Property PalletRef As String
    Get
      Return pPalletRef
    End Get
    Set(value As String)
      pPalletRef = value
    End Set
  End Property

  Public Property LocationID As Int32
    Get
      Return pLocationID
    End Get
    Set(value As Int32)
      pLocationID = value
    End Set
  End Property
  Public ReadOnly Property Balance As Decimal
    Get
      Dim mRetVal As Decimal = 0


      mRetVal = pSUMQuantity - pSUMQuantityUsed

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property LocationDesc As String
    Get
      Dim mRetVal As String = ""

      If LocationID > 0 Then
        mRetVal = clsEnumsConstants.GetEnumDescription(GetType(eLocations), CType(LocationID, eLocations))
      End If
      Return mRetVal
    End Get

  End Property

  Public Property SUMQuantity As Decimal
    Get
      Return pSUMQuantity
    End Get
    Set(value As Decimal)
      pSUMQuantity = value
    End Set
  End Property

  Public Property SUMQuantityUsed As Decimal
    Get
      Return pSUMQuantityUsed
    End Get
    Set(value As Decimal)
      pSUMQuantityUsed = value
    End Set
  End Property

  Public Property PalletType As Int32
    Get
      Return pPalletType
    End Get
    Set(value As Int32)
      pPalletType = value
    End Set
  End Property




  Public ReadOnly Property TotalBoardFeet As Decimal
    Get
      Dim mRetVal As Decimal = 0

      If pWoodPalletItems.Count > 0 Then
        For Each mWoodPalletItemInfo As clsWoodPalletItemInfo In pWoodPalletItems


          Select Case PalletType
            Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
              mRetVal += Math.Round(Math.PI * Math.Pow(mWoodPalletItemInfo.Thickness / 200, 2) * mWoodPalletItemInfo.WoodPalletItem.Length * mWoodPalletItemInfo.Balance, 4, MidpointRounding.AwayFromZero) * 423.77
            Case Else
              mRetVal += Math.Round(((mWoodPalletItemInfo.Thickness * mWoodPalletItemInfo.Width * mWoodPalletItemInfo.Length) / 12) * Balance, 4, MidpointRounding.AwayFromZero)

          End Select

        Next

      End If



      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property BoardFeetToM3() As Decimal
    Get
      Dim mRetVal As Decimal
      mRetVal = TotalBoardFeet / 423.77
      Return mRetVal

    End Get
  End Property
  Public ReadOnly Property M3ToBoardFeet() As Decimal
    Get
      Dim mRetVal As Decimal
      mRetVal = BoardFeetToM3 * 423.77
      Return mRetVal

    End Get
  End Property

End Class



Public Class colWoodPalletItemContents : Inherits List(Of clsWoodPalletItemContent)


End Class
