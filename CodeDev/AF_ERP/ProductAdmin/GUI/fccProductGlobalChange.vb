Imports RTIS.DataLayer

Public Class fccProductGlobalChange
  Private pDBConn As clsDBConnBase
  Private pSelectedItems As colProductBOMs
  Private pOKVal As Boolean
  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property SelectedItems As colProductBOMs
    Get
      Return pSelectedItems
    End Get
    Set(value As colProductBOMs)
      pSelectedItems = value
    End Set
  End Property

  Public Property OKVal As Boolean
    Get
      Return pOKVal
    End Get
    Set(value As Boolean)
      pOKVal = value
    End Set
  End Property

  Public Sub New(ByRef rDBConnBase As clsDBConnBase, ByRef rSelectedItems As colProductBOMs)
    pDBConn = rDBConnBase
    pSelectedItems = rSelectedItems
    pOKVal = True
  End Sub

  Public Sub ChangeSpeciesForSelectedWoodItems(ByVal vNewSpecies As Integer)
    Dim mSIOrig As dmStockItem
    Dim mSITemp As dmStockItem
    Dim mSINew As dmStockItem

    For Each mMatReq As dmProductBOM In pSelectedItems
      mSIOrig = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mMatReq.StockItemID)
      mSITemp = mSIOrig.Clone
      mSITemp.Species = vNewSpecies

      mSINew = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromSameSpec(mSITemp)


      If mSINew Is Nothing Then
        mSINew = mSITemp
        mSINew.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mSINew)
        mSINew.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mSINew, DBConn)
        mSINew.ClearKeys()
        AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mSINew)
      End If

      mMatReq.StockItemID = mSINew.StockItemID
      mMatReq.StockCode = mSINew.StockCode
      mMatReq.WoodSpecie = mSINew.Species

      mMatReq.UoM = mSINew.UoM
      mMatReq.TmpSelectedItem = False
      mMatReq.NetThickness = Math.Round((mSINew.Thickness * clsConstants.CMToInches), 0, MidpointRounding.AwayFromZero)
    Next
  End Sub


End Class
