Imports RTIS.CommonVB

Public Class clsProductRegistry

  Protected pProductsDict As Dictionary(Of Integer, dmProductBase)
  Protected pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pProductsDict = New Dictionary(Of Integer, dmProductBase)
    pDBConn = rDBConn
  End Sub

  Public Property ProductsDict As Dictionary(Of Integer, dmProductBase)
    Get
      Return pProductsDict
    End Get
    Set(value As Dictionary(Of Integer, dmProductBase))
      pProductsDict = value
    End Set
  End Property


  Public Function GetProductFromTypeAndID(ByVal vProductType As eProductType, ByVal vProductID As Integer) As dmProductBase
    Dim mRetVal As dmProductBase = Nothing
    Dim mKey As Integer
    mKey = GetDictKey(vProductType, vProductID)
    If ProductsDict.ContainsKey(mKey) Then mRetVal = ProductsDict.Item(mKey)
    Return mRetVal
  End Function

  Public Function GetDictKey(ByVal vProductType As eProductType, ByVal vProductID As Integer) As Integer
    Dim mRetVal As Integer
    mRetVal = vProductType * 10000000 + vProductID
    Return mRetVal
  End Function


  Public Sub RemoveContextSpecific()

  End Sub

  ''Public Sub LoadByParams(ByRef rParams As Hashtable)
  ''  Dim mdto As intdtoStockItem
  ''  Try

  ''    mdto = CreateDtoStockItem()
  ''    mdto.LoadStockItemsDictByParams(pStockItemsDict, rParams)
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try
  ''End Sub

  Public Sub LoadInitial()
    Dim mdtoS As dtoProductStructure
    Dim mdtoI As dtoProductInstallation
    Dim mProductsS As New colProductStructures
    Dim mProductsI As New colProductInstallations

    mdtoS = New dtoProductStructure(pDBConn)
    mdtoS.LoadProductStructureCollection(mProductsS)
    For Each mProdS As dmProductStructure In mProductsS
      pProductsDict.Add(GetDictKey(eProductType.StructureAF, mProdS.ProductStructureID), mProdS)
    Next

    mdtoI = New dtoProductInstallation(pDBConn)
    mdtoI.LoadProductInstallationCollection(mProductsI)
    For Each mProdI As dmProductInstallation In mProductsI
      pProductsDict.Add(GetDictKey(eProductType.ProductInstallation, mProdI.ProductInstallationID), mProdI)
    Next

  End Sub


  ''Public Sub RefreshStockItem(ByVal vStockItemID As Integer)
  ''  Dim mdto As intdtoStockItem
  ''  Dim mStockItem As New dmStockItem
  ''  Try
  ''    If pStockItemsDict.ContainsKey(vStockItemID) Then
  ''      pDBConn.Connect()
  ''      mdto = CreateDtoStockItem()
  ''      mdto.LoadStockItem(mStockItem, vStockItemID)
  ''      pStockItemsDict(vStockItemID) = mStockItem
  ''    End If
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try
  ''End Sub


  ''Public Sub LoadByID(ByVal vStockItemID As Integer)
  ''  Dim mdto As intdtoStockItem
  ''  Dim mStockItem As New dmStockItem
  ''  Try
  ''    mdto = CreateDtoStockItem()
  ''    pDBConn.Connect()
  ''    mdto.LoadStockItem(mStockItem, vStockItemID)
  ''    pStockItemsDict.Add(vStockItemID, mStockItem)
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try
  ''End Sub

  ''Public Function CreateClone() As clsProductRegistry
  ''  Dim mRetVal As clsProductRegistry
  ''  mRetVal = New clsProductRegistry(pDBConn)
  ''  For Each mKVP As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pStockItemsDict
  ''    mRetVal.pStockItemsDict.Add(mKVP.Key, mKVP.Value)
  ''  Next
  ''  Return mRetVal
  ''End Function


End Class
