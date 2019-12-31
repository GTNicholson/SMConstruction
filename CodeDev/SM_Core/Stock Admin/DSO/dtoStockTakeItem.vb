
''DTO Definition - StockTakeItem (to StockTakeItem)'Generated from Table:StockTakeItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockTakeItem : Inherits dtoBase
  Private pStockTakeItem As dmStockTakeItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockTakeItem"
    pKeyFieldName = "StockTakeItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockTakeItem.StockTakeItemID
    End Get
    Set(ByVal value As Integer)
      pStockTakeItem.StockTakeItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockTakeItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockTakeItem.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockTakeItemID", pStockTakeItem.StockTakeItemID)
    End If
    With pStockTakeItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockTakeID", .StockTakeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemLocationID", .StockItemLocationID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SalesOrderPhaseID", .SalesOrderPhaseID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SnapshotQty", .SnapshotQty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CountedQty", .CountedQty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CreatedDate", DateToDBValue(.CreatedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalValue", .TotalValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsCounted", .IsCounted)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SnapShotStockQty", .SnapShotStockQty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SnapShotCostingQuantity", .SnapShotCostingQuantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SnapShotUnitCost", .SnapShotUnitCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemCategoryID", .StockItemCategoryID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockTakeSheetID", .StockTakeSheetID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SystemTotalValue", .SystemTotalValue)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CountedTotalValue", .CountedTotalValue)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockTakeItem Is Nothing Then SetObjectToNew()
      With pStockTakeItem
        .StockTakeItemID = DBReadInt32(rDataReader, "StockTakeItemID")
        .StockTakeID = DBReadInt32(rDataReader, "StockTakeID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .StockItemLocationID = DBReadByte(rDataReader, "StockItemLocationID")
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .SnapshotQty = DBReadDecimal(rDataReader, "SnapshotQty")
        .CountedQty = DBReadDecimal(rDataReader, "CountedQty")
        .CreatedDate = DBReadDateTime(rDataReader, "CreatedDate")
        .TotalValue = DBReadDecimal(rDataReader, "TotalValue")
        .IsCounted = DBReadBoolean(rDataReader, "IsCounted")
        .SnapShotStockQty = DBReadDecimal(rDataReader, "SnapShotStockQty")
        .SnapShotCostingQuantity = DBReadDecimal(rDataReader, "SnapShotCostingQuantity")
        .SnapShotUnitCost = DBReadDecimal(rDataReader, "SnapShotUnitCost")
        .StockItemCategoryID = DBReadInt32(rDataReader, "StockItemCategoryID")
        .StockTakeSheetID = DBReadInt32(rDataReader, "StockTakeSheetID")
        .SystemTotalValue = DBReadDecimal(rDataReader, "SystemTotalValue")
        .CountedTotalValue = DBReadDecimal(rDataReader, "CountedTotalValue")
        pStockTakeItem.IsDirty = False
      End With
      mOK = True
    Catch Ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      ' or raise an error ?
      mOK = False
    Finally

    End Try
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    pStockTakeItem = New dmStockTakeItem ' Or .NewBlankStockTakeItem
    Return pStockTakeItem

  End Function


  Public Function LoadStockTakeItem(ByRef rStockTakeItem As dmStockTakeItem, ByVal vStockTakeItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockTakeItemID)
    If mOK Then
      rStockTakeItem = pStockTakeItem
    Else
      rStockTakeItem = Nothing
    End If
    pStockTakeItem = Nothing
    Return mOK
  End Function


  Public Function SaveStockTakeItem(ByRef rStockTakeItem As dmStockTakeItem) As Boolean
    Dim mOK As Boolean
    pStockTakeItem = rStockTakeItem
    mOK = SaveObject()
    pStockTakeItem = Nothing
    Return mOK
  End Function


  Public Function LoadStockTakeItemCollection(ByRef rStockTakeItems As colStockTakeItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@StockTakeID", vParentID)
    mOK = MyBase.LoadCollection(rStockTakeItems, mParams, "StockTakeItemID")
    rStockTakeItems.TrackDeleted = True
    If mOK Then rStockTakeItems.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockTakeItemCollection(ByRef rCollection As colStockTakeItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@StockTakeID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockTakeItem In rCollection
      ''    If pStockTakeItem.StockTakeItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockTakeItem.StockTakeItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockTakeItem In rCollection.DeletedItems
          If pStockTakeItem.StockTakeItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockTakeItem.StockTakeItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockTakeItem In rCollection
        If pStockTakeItem.IsDirty Or pStockTakeItem.StockTakeID <> vParentID Or pStockTakeItem.StockTakeItemID = 0 Then 'Or pStockTakeItem.StockTakeItemID = 0
          pStockTakeItem.StockTakeID = vParentID
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

End Class

