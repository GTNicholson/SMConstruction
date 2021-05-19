Imports RTIS.DataLayer

Public Class clsWoodPalletSharedFuncs

  Public Shared Function GetWoodPalletItemVolumeBoardFeet(ByRef rWoodPalletItem As dmWoodPalletItem, ByRef rStockItem As dmStockItem, ByVal vQuantity As Decimal) As Decimal
    Dim mRetVal As Decimal


    If rStockItem IsNot Nothing Then

      Select Case rStockItem.ItemType
        Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
          ' mRetVal = rWoodPalletItem.Quantity
          mRetVal = Math.Round(Math.PI * Math.Pow(rWoodPalletItem.Thickness / 200, 2) * rWoodPalletItem.Length * vQuantity, 4, MidpointRounding.AwayFromZero) * clsConstants.BoardFeetPerM3
        Case Else
          mRetVal = Math.Round(((rWoodPalletItem.Thickness * rWoodPalletItem.Width * rWoodPalletItem.Length) / 12) * vQuantity, 4, MidpointRounding.AwayFromZero)

      End Select
    End If

    Return mRetVal
  End Function



  Public Shared Function GetWoodPalletItemVolumeBoardFeetWithDifferenceValue(ByRef rWoodPalletItem As dmWoodPalletItem, ByRef rStockItem As dmStockItem) As Decimal
    Dim mRetVal As Decimal


    If rStockItem IsNot Nothing Then

      Select Case rStockItem.ItemType
        Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
          ' mRetVal = rWoodPalletItem.Quantity''rWoodPalletItem.Quantity
          mRetVal = Math.Round(Math.PI * Math.Pow(rWoodPalletItem.Thickness / 200, 2) * rWoodPalletItem.Length * rWoodPalletItem.DifferenceTranQty, 4, MidpointRounding.AwayFromZero) * clsConstants.BoardFeetPerM3
        Case Else
          mRetVal = Math.Round(((rWoodPalletItem.Thickness * rWoodPalletItem.Width * rWoodPalletItem.Length) / 12) * rWoodPalletItem.DifferenceTranQty, 4, MidpointRounding.AwayFromZero)

      End Select
    End If

    Return mRetVal
  End Function

  Public Shared Function GetWoodPalletItemVolumeBoardFeet(ByRef rWoodPalletItem As dmWoodPalletItem, ByRef rStockItem As dmStockItem) As Decimal
    Dim mRetVal As Decimal


    If rStockItem IsNot Nothing Then

      Select Case rStockItem.ItemType
        Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
          ' mRetVal = rWoodPalletItem.Quantity''rWoodPalletItem.Quantity
          mRetVal = Math.Round(Math.PI * Math.Pow(rWoodPalletItem.Thickness / 200, 2) * rWoodPalletItem.Length * rWoodPalletItem.Quantity, 4, MidpointRounding.AwayFromZero) * clsConstants.BoardFeetPerM3
        Case Else
          mRetVal = Math.Round(((rWoodPalletItem.Thickness * rWoodPalletItem.Width * rWoodPalletItem.Length) / 12) * rWoodPalletItem.Quantity, 4, MidpointRounding.AwayFromZero)

      End Select
    End If

    Return mRetVal
  End Function

  Public Shared Function GetWoodPalletItemVolumeM3(ByRef rWoodPalletItem As dmWoodPalletItem, ByRef rStockItem As dmStockItem) As Decimal
    Dim mRetVal As Decimal


    If rStockItem IsNot Nothing Then

      Select Case rStockItem.ItemType
        Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
          ' mRetVal = rWoodPalletItem.Quantity
          mRetVal = Math.Round(Math.PI * Math.Pow(rWoodPalletItem.Thickness / 200, 2) * rWoodPalletItem.Length * rWoodPalletItem.Quantity, 4, MidpointRounding.AwayFromZero)
        Case Else

          mRetVal = Math.Round(((rWoodPalletItem.Thickness * rWoodPalletItem.Width * rWoodPalletItem.Length) / 12) * rWoodPalletItem.Quantity, 4, MidpointRounding.AwayFromZero) / clsConstants.BoardFeetPerM3

      End Select
    End If

    Return mRetVal
  End Function

  Public Shared Function BoardFeetToM3(ByVal vPieTabla As Decimal) As Decimal
    Dim mRetVal As Decimal
    mRetVal = vPieTabla / clsConstants.BoardFeetPerM3
    Return mRetVal
  End Function

  Public Shared Function M3ToBoardFeet(ByVal vM3 As Decimal) As Decimal
    Dim mRetVal As Decimal
    mRetVal = vM3 * clsConstants.BoardFeetPerM3
    Return mRetVal
  End Function


  Public Shared Function GetStockItemQtys(ByRef rWoodPallet As dmWoodPallet, ByVal vWithDifferenceQty As Boolean) As Dictionary(Of Integer, Decimal)
    Dim mRetVal As New Dictionary(Of Integer, Decimal)
    Dim mVol As Decimal
    Dim mSI As dmStockItem

    For Each mPI As dmWoodPalletItem In rWoodPallet.WoodPalletItems
      mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPI.StockItemID)

      If vWithDifferenceQty Then
        mVol = GetWoodPalletItemVolumeBoardFeetWithDifferenceValue(mPI, mSI)
      Else
        mVol = GetWoodPalletItemVolumeBoardFeet(mPI, mSI)
      End If
      If mRetVal.ContainsKey(mPI.StockItemID) Then
        mRetVal(mPI.StockItemID) = mRetVal(mPI.StockItemID) + mVol
      Else
        mRetVal.Add(mPI.StockItemID, mVol)
      End If
    Next
    Return mRetVal
  End Function

  Public Shared Function GetTotalBoardFeet(rWoodPallet As dmWoodPallet) As Decimal
    Dim mRetVal As Decimal
    Dim mStockItem As dmStockItem

    For Each mWPI As dmWoodPalletItem In rWoodPallet.WoodPalletItems


      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPI.StockItemID)

      If mStockItem IsNot Nothing Then
        mRetVal += GetWoodPalletItemVolumeBoardFeet(mWPI, mStockItem)
      End If

    Next

    Return mRetVal
  End Function

  Public Shared Function GetSpeciesQty(ByRef rWoodPallets As colWoodPallets) As List(Of Integer)
    Dim mRetVal As New List(Of Integer)
    Dim mSI As dmStockItem

    For Each mWP As dmWoodPallet In rWoodPallets
      For Each mPI As dmWoodPalletItem In mWP.WoodPalletItems
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPI.StockItemID)

        If mSI IsNot Nothing Then
          If Not mRetVal.Contains(mSI.Species) Then

            mRetVal.Add(mSI.Species)
          End If
        End If

      Next
    Next
    Return mRetVal
  End Function


  Public Shared Function GetWoodPalletContentDescription(ByVal vWoodPalletItems As colWoodPalletItems) As String
    Dim mRetVal As String = ""
    Dim mListString As New List(Of String)
    Dim mFeetBoard As Decimal = 0
    Dim mStockItem As dmStockItem

    If vWoodPalletItems IsNot Nothing And vWoodPalletItems.Count > 0 Then
      For Each mWPI As dmWoodPalletItem In vWoodPalletItems

        If Not mListString.Contains(mWPI.Description) Then
          mListString.Add(mWPI.Description)

          If mWPI.Thickness > 0 Then
            mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPI.StockItemID)
            If mStockItem IsNot Nothing Then
              mFeetBoard = vWoodPalletItems.GetTotalBoardFeet(mStockItem.StockItemID)
            End If
            If mFeetBoard > 0 Then
              mRetVal &= mWPI.Description & " con " & mFeetBoard.ToString("N3") & " PT "
            Else
                mRetVal &= mWPI.Description & " : "
              End If

            Else
              If mWPI.Quantity > 0 Then
              mRetVal &= mWPI.Description & " con " & (mWPI.Quantity - mWPI.QuantityUsed).ToString("0") & " m3,"

            Else
              mRetVal &= mWPI.Description & " ,"

            End If
          End If
        End If

      Next
      'mRetVal = mRetVal.Substring(0, mRetVal.Length - 1)


    End If
    Return mRetVal
  End Function

  Public Shared Function GetWoodPalletsDescription(ByVal vWoodPallets As colWoodPallets) As String
    Dim mRetVal As String = ""

    For Each mWP In vWoodPallets
      If mRetVal <> "" Then mRetVal &= "/ "
      mRetVal = mWP.PalletRef
    Next

    Return mRetVal
  End Function
  Public Shared Sub GetNextWoodPalletRefConnected(ByRef rWoodPallet As dmWoodPallet, ByRef rDBConn As clsDBConnBase)
    Dim mdsoGeneral As New dsoGeneral(rDBConn)
    Dim mRef As String = ""

    If rWoodPallet.PalletRef = "" Then
      Select Case rWoodPallet.PalletType
        Case eStockItemTypeTimberWood.Arbol
          mRef = "BLT-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.Aserrado
          mRef = "BLT-ASE" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.Primera
          mRef = "BLT-PRI-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.Segunda
          mRef = "BLT-SEG-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.Tercera
          mRef = "BLT-TER-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.ClasificadoZ
          mRef = "BLT-Z-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.MAS
          mRef = "BLT-MAS-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")

        Case eStockItemTypeTimberWood.MAV
          mRef = "BLT-MAV-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")


        Case eStockItemTypeTimberWood.CepilladoPrimera
          mRef = "BLT-CPR-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

        Case eStockItemTypeTimberWood.CepilladoSegunda
          mRef = "BLT-CSE-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

        Case eStockItemTypeTimberWood.CepilladoTercera
          mRef = "BLT-CTE-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

        Case eStockItemTypeTimberWood.Rollo
          Dim mCardNumber As Integer = Val(rWoodPallet.CardNumber)
          If mCardNumber > 0 Then
            mRef = "RST-ROL-" & mCardNumber.ToString("0000")

          Else

            mRef = "RST-ROL-" & mdsoGeneral.GetNextTallyWoodPalletConnected().ToString("0000")
          End If
      End Select


      rWoodPallet.PalletRef = mRef
    End If

  End Sub
  Public Shared Sub GetNextWoodPalletRef(ByRef rWoodPallet As dmWoodPallet, ByRef rDBConn As clsDBConnBase)
    Dim mdsoGeneral As New dsoGeneral(rDBConn)
    Dim mRef As String = ""

    If rWoodPallet.PalletRef = "" Then
      If rDBConn.Connect Then
        Select Case rWoodPallet.PalletType

          Case eStockItemTypeTimberWood.Arbol
            mRef = "BLT-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.Aserrado
            mRef = "BLT-ASE" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.Primera
            mRef = "BLT-PRI-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.Segunda
            mRef = "BLT-SEG-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.Tercera
            mRef = "BLT-TER-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.ClasificadoZ
            mRef = "BLT-Z-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.MAS
            mRef = "BLT-MAS-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.MAV
            mRef = "BLT-MAV-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")


          Case eStockItemTypeTimberWood.CepilladoPrimera
            mRef = "BLT-CPR-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.CepilladoSegunda
            mRef = "BLT-CSE-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.CepilladoTercera
            mRef = "BLT-CTE-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

          Case eStockItemTypeTimberWood.Rollo
            mRef = "RST-ROL-" & mdsoGeneral.GetNextTallyWoodPallet().ToString("0000")

        End Select
      End If


      rWoodPallet.PalletRef = mRef
    End If
  End Sub

  Public Shared Function GetTrunkVolume(ByVal vLength As Decimal, ByVal vThickness As Decimal) As Decimal
    Dim mRetVal As Decimal
    mRetVal = Math.Round(Math.PI * Math.Pow(vThickness / 2 / 100, 2) * vLength, 4, MidpointRounding.AwayFromZero)
    Return mRetVal
  End Function
End Class
