Public Class clsWoodPalletSharedFuncs

  Public Shared Function GetWoodPalletItemVolume(ByRef rWoodPalletItem As dmWoodPalletItem) As Decimal
    Dim mRetVal As Decimal
    Dim mTempStockItem As dmStockItem = Nothing
    mTempStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(rWoodPalletItem.StockItemID)

    If mTempStockItem IsNot Nothing Then

      Select Case mTempStockItem.ItemType
        Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
          mRetVal = rWoodPalletItem.Quantity

        Case Else
          mRetVal = Math.Round(((rWoodPalletItem.Thickness * rWoodPalletItem.Width * rWoodPalletItem.Length) / 12) * rWoodPalletItem.Quantity, 4)

      End Select
    End If

    Return mRetVal
  End Function

  Public Shared Function GetStockItemQtys(ByRef rWoodPallet As dmWoodPallet) As Dictionary(Of Integer, Decimal)
    Dim mRetVal As New Dictionary(Of Integer, Decimal)
    Dim mVol As Decimal

    For Each mPI As dmWoodPalletItem In rWoodPallet.WoodPalletItems
      mVol = GetWoodPalletItemVolume(mPI)
      If mRetVal.ContainsKey(mPI.StockItemID) Then
        mRetVal(mPI.StockItemID) = mRetVal(mPI.StockItemID) + mVol
      Else
        mRetVal.Add(mPI.StockItemID, mVol)
      End If
    Next
    Return mRetVal
  End Function

End Class
