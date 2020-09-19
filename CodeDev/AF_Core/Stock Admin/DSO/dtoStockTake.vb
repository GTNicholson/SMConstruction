''DTO Definition - StockTake (to StockTake)'Generated from Table:StockTake

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockTake : Inherits dtoBase
  Private pStockTake As dmStockTake

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockTake"
    pKeyFieldName = "StockTakeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockTake.StockTakeID
    End Get
    Set(ByVal value As Integer)
      pStockTake.StockTakeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockTake.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockTake.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockTakeID", pStockTake.StockTakeID)
    End If
    With pStockTake
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockTakeTypeID", .StockTakeTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockTakeDate", DateToDBValue(.StockTakeDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CreatedDate", DateToDBValue(.CreatedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SnapshotDateTime", DateToDBValue(.SnapshotDateTime))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateCommitted", DateToDBValue(.DateCommitted))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RangeStockCodeStart", StringToDBValue(.RangeStockCodeStart))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RangeStockCodeEnd", StringToDBValue(.RangeStockCodeEnd))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateSystemQty", DateToDBValue(.DateSystemQty))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockTake Is Nothing Then SetObjectToNew()
      With pStockTake
        .StockTakeID = DBReadInt32(rDataReader, "StockTakeID")
        .StockTakeTypeID = DBReadByte(rDataReader, "StockTakeTypeID")
        .Description = DBReadString(rDataReader, "Description")
        .StockTakeDate = DBReadDateTime(rDataReader, "StockTakeDate")
        .CreatedDate = DBReadDateTime(rDataReader, "CreatedDate")
        .SnapshotDateTime = DBReadDateTime(rDataReader, "SnapshotDateTime")
        .DateCommitted = DBReadDateTime(rDataReader, "DateCommitted")
        .RangeStockCodeStart = DBReadString(rDataReader, "RangeStockCodeStart")
        .RangeStockCodeEnd = DBReadString(rDataReader, "RangeStockCodeEnd")
        .DateSystemQty = DBReadDateTime(rDataReader, "DateSystemQty")
        pStockTake.IsDirty = False
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
    pStockTake = New dmStockTake ' Or .NewBlankStockTake
    Return pStockTake

  End Function


  Public Function LoadStockTake(ByRef rStockTake As dmStockTake, ByVal vStockTakeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockTakeID)
    If mOK Then
      rStockTake = pStockTake
    Else
      rStockTake = Nothing
    End If
    pStockTake = Nothing
    Return mOK
  End Function


  Public Function SaveStockTake(ByRef rStockTake As dmStockTake) As Boolean
    Dim mOK As Boolean
    pStockTake = rStockTake
    mOK = SaveObject()
    pStockTake = Nothing
    Return mOK
  End Function


  Public Function LoadStockTakeCollection(ByRef rStockTakes As colStockTakes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rStockTakes, mParams, "StockTakeID")
    rStockTakes.TrackDeleted = True
    If mOK Then rStockTakes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockTakeCollection(ByRef rCollection As colStockTakes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockTake In rCollection
      ''    If pStockTake.StockTakeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockTake.StockTakeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockTake In rCollection.DeletedItems
          If pStockTake.StockTakeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockTake.StockTakeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockTake In rCollection
        If pStockTake.IsDirty Or pStockTake.StockTakeID = 0 Then 'Or pStockTake.StockTakeID = 0

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


