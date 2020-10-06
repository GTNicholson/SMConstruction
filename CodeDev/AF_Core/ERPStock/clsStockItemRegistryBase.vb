Imports RTIS.CommonVB

Public MustInherit Class clsStockItemRegistryBase
  Protected pStockItemsDict As Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef)
  Protected pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pStockItemsDict = New Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef)
    pDBConn = rDBConn
  End Sub

  Public Property StockItemsDict As Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef)
    Get
      Return pStockItemsDict
    End Get
    Set(value As Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef))
      pStockItemsDict = value
    End Set
  End Property


  Public Function GetStockItemFromID(ByVal vStockItemID As Integer) As dmStockItem
    Dim mRetVal As dmStockItem = Nothing
    If pStockItemsDict.ContainsKey(vStockItemID) Then mRetVal = pStockItemsDict.Item(vStockItemID)
    Return mRetVal
  End Function

  Public Sub RemoveContextSpecific()

  End Sub

  Public Sub LoadByParams(ByRef rParams As Hashtable)
    Dim mdto As intdtoStockItem
    Try

      mdto = CreateDtoStockItem()
      mdto.LoadStockItemsDictByParams(pStockItemsDict, rParams)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public MustOverride Sub LoadInitial()

  Public Sub RefreshStockItem(ByVal vStockItemID As Integer)
    Dim mdto As intdtoStockItem
    Dim mStockItem As New dmStockItem
    Try
      If pStockItemsDict.ContainsKey(vStockItemID) Then
        pDBConn.Connect()
        mdto = CreateDtoStockItem()
        mdto.LoadStockItem(mStockItem, vStockItemID)
        pStockItemsDict(vStockItemID) = mStockItem
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub


  Public Sub LoadByID(ByVal vStockItemID As Integer)
    Dim mdto As intdtoStockItem
    Dim mStockItem As New dmStockItem
    Try
      mdto = CreateDtoStockItem()
      pDBConn.Connect()
      mdto.LoadStockItem(mStockItem, vStockItemID)
      pStockItemsDict.Add(vStockItemID, mStockItem)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function CreateClone() As clsStockItemRegistryComp
    Dim mRetVal As clsStockItemRegistryComp
    mRetVal = New clsStockItemRegistryComp(pDBConn)
    For Each mKVP As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pStockItemsDict
      mRetVal.pStockItemsDict.Add(mKVP.Key, mKVP.Value)
    Next
    Return mRetVal
  End Function

  Public MustOverride Function CreateDtoStockItem() As intdtoStockItem


End Class
