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

  Public Sub LoadByParams(ByVal vWhere As String)
    Dim mdto As intdtoStockItem
    Dim mParams As New Hashtable
    mdto = CreateDtoStockItem()
    mdto.LoadStockItemsDictByParams(pStockItemsDict, mParams)
  End Sub

  Public MustOverride Sub LoadInitial()

  Public Sub LoadByID(ByVal vStockItemID As Integer)

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
