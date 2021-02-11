Public Class clsStockCostingPricing
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pStockItemRegistry As clsStockItemRegistryComp
  Private pCostBook As dmCostBook

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rStockItemRegistry As clsStockItemRegistryComp, ByRef rCostBook As dmCostBook)
    pDBConn = rDBConn
    pStockItemRegistry = rStockItemRegistry
    pCostBook = rCostBook
  End Sub

  Public Function GetStockItemLocationMoneytaryValue(ByRef rStockItem As dmStockItem, ByRef rStockItemLocation As dmStockItemLocation) As Decimal
    Dim mRetVal As Decimal = 0
    Select Case rStockItem.Category
      Case eStockItemCategory.Timber
        Select Case rStockItem.ItemType
          Case eStockItemTypeTimberWood.Rollo
            mRetVal = GetStockItemLocationMoneytaryValueRollo(rStockItem, rStockItemLocation)
        End Select
    End Select
    Return mRetVal
  End Function

  Public Function GetStockItemLocationMoneytaryValueRollo(ByRef rStockItem As dmStockItem, ByRef rStockItemLocation As dmStockItemLocation) As Decimal
    Dim mDSO As dsoStock
    Dim mCBE As dmCostBookEntry
    Dim mWPIs As New colWoodPalletItems
    Dim mM3 As Decimal
    Dim mTotalValue As Decimal = 0
    Dim mSIWithThickness As dmStockItem
    Dim mSICosting As dmStockItem
    Dim mSIs As colStockItems
    Dim mRetVal As Decimal = 0
    '// Load up all the remaining WoodPalletItem entries for this stock item for this location
    mDSO = New dsoStock(pDBConn)
    mDSO.LoadWoodPalletItemsByStockItemIDLocationIDConnected(mWPIs, rStockItem.StockItemID, rStockItemLocation.LocationID)

    '// For each item identify the Costing Only entry, and the current m3 value in the Cost book
    mSIs = pStockItemRegistry.GetStockItemCollectionCategoryTypeCostingOnly(eStockItemCategory.Timber, eStockItemTypeTimberWood.Rollo, True)
    For Each mWPI As dmWoodPalletItem In mWPIs
      '// Find the costing only entry for this diameter
      mSIWithThickness = rStockItem.Clone
      mSIWithThickness.Thickness = mWPI.Thickness
      mSICosting = clsStockItemFinders.FindTimberRolloCostingItem(mSIWithThickness, mSIs)

      If mSICosting IsNot Nothing Then
        mCBE = pCostBook.CostBookEntrys.ItemFromStockItemID(mSICosting.StockItemID)
        If mCBE IsNot Nothing Then
          mM3 = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeM3(mWPI, rStockItem)
          mTotalValue = mTotalValue + (mCBE.Cost * mM3)
        End If

      End If
    Next

    mRetVal = mTotalValue

    Return mRetVal

  End Function

End Class
