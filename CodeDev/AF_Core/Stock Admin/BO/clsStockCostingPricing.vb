Public Class clsStockCostingPricing
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pStockItemRegistry As clsStockItemRegistryComp
  Private pCostBook As dmCostBook

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rStockItemRegistry As clsStockItemRegistryComp, ByRef rCostBook As dmCostBook)
    pDBConn = rDBConn
    pStockItemRegistry = rStockItemRegistry
    pCostBook = rCostBook
  End Sub

  Public Sub UpdateStockItemLocationMoneytaryValue(ByRef rStockItem As dmStockItem, ByRef rStockItemLocation As dmStockItemLocation)
    Select Case rStockItem.Category
      Case eStockItemCategory.Timber
        Select Case rStockItem.ItemType
          Case eStockItemTypeTimberWood.Rollo
            UpdateStockItemLocationMoneytaryValueRollo(rStockItem, rStockItemLocation)
        End Select
    End Select
  End Sub

  Public Sub UpdateStockItemLocationMoneytaryValueRollo(ByRef rStockItem As dmStockItem, ByRef rStockItemLocation As dmStockItemLocation)
    Dim mDSO As dsoStock
    Dim mCBE As dmCostBookEntry
    Dim mWPIs As New colWoodPalletItems
    Dim mM3 As Decimal
    Dim mTotalValue As Decimal = 0
    Dim mSIWithThickness As dmStockItem
    Dim mSICosting As dmStockItem
    Dim mSIs As colStockItems

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

      mCBE = pCostBook.CostBookEntrys.ItemFromStockItemID(mSICosting.StockItemID)
      If mCBE IsNot Nothing Then
        mM3 = clsWoodPalletSharedFuncs.BoardFeetToM3(clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPI, rStockItem))
        mTotalValue = mTotalValue + (mCBE.Cost * mM3)
      End If
    Next

    rStockItemLocation.MonetaryValue = mTotalValue

  End Sub

End Class
