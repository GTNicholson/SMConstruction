Imports RTIS.DataLayer

Public Class fccGlobalStockItemChange
  Private pDBConn As clsDBConnBase
  Private pSelectedItems As colStockItems

  Public Sub New(rDBConn As clsDBConnBase, rSelectedItems As colStockItems)
    Me.pDBConn = rDBConn
    Me.pSelectedItems = rSelectedItems
  End Sub

  Public Sub ApplyGlobalChanges(ByVal vCategory As Integer, ByVal vSpeciesID As Integer, ByVal vUoM As Integer, ByVal vItemType As Integer)
    Dim mdso As New dsoStock(pDBConn)

    For Each mSI As dmStockItem In pSelectedItems

      If mSI.IsSelected Then
        mSI.Category = vCategory
        mSI.Species = vSpeciesID
        mSI.ItemType = vItemType
        mSI.UoM = vUoM
        mSI.SupplierUoM = vUoM
        mSI.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mSI, pDBConn)
        mdso.SaveStockItem(mSI)
        mSI.IsSelected = False
      End If
    Next
  End Sub
End Class
