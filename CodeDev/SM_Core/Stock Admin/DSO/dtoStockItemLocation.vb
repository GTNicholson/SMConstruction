
''DTO Definition - StockItemLocation (to StockItemLocation)'Generated from Table:StockItemLocation

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemLocation : Inherits dtoBase
  Private pStockItemLocation As dmStockItemLocation

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItemLocation"
    pKeyFieldName = "StockItemLocationID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemLocation.StockItemLocationID
    End Get
    Set(ByVal value As Integer)
      pStockItemLocation.StockItemLocationID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItemLocation.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItemLocation.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemLocationID", pStockItemLocation.StockItemLocationID)
    End If
    With pStockItemLocation
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LocationID", .LocationID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Qty", .Qty)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemLocation Is Nothing Then SetObjectToNew()
      With pStockItemLocation
        .StockItemLocationID = DBReadInt32(rDataReader, "StockItemLocationID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .LocationID = DBReadByte(rDataReader, "LocationID")
        .QtyValueTracker.SetDecValue(DBReadDecimal(rDataReader, "Qty"))
        pStockItemLocation.IsDirty = False
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
    pStockItemLocation = New dmStockItemLocation ' Or .NewBlankStockItemLocation
    Return pStockItemLocation

  End Function


  Public Function LoadStockItemLocation(ByRef rStockItemLocation As dmStockItemLocation, ByVal vStockItemLocationID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemLocationID)
    If mOK Then
      rStockItemLocation = pStockItemLocation
    Else
      rStockItemLocation = Nothing
    End If
    pStockItemLocation = Nothing
    Return mOK
  End Function


  Public Function SaveStockItemLocation(ByRef rStockItemLocation As dmStockItemLocation) As Boolean
    Dim mOK As Boolean
    pStockItemLocation = rStockItemLocation
    mOK = SaveObject()
    pStockItemLocation = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemLocationCollectionByStockItemID(ByRef rStockItemLocations As colStockItemLocations, ByVal vStockItemID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@StockItemID", vStockItemID)
    mOK = MyBase.LoadCollection(rStockItemLocations, mParams, "StockItemLocationID")
    rStockItemLocations.TrackDeleted = True
    If mOK Then rStockItemLocations.IsDirty = False
    Return mOK
  End Function

  Public Function LoadStockItemLocationByStockItemIDLocationID(ByVal vStockItemID As Integer, ByVal vLocationID As Integer) As dmStockItemLocation
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    Dim mRetVal As dmStockItemLocation = Nothing
    Dim mStockItemLocations As New colStockItemLocations
    '// Should only find one!
    mParams.Add("@StockItemID", vStockItemID)
    mParams.Add("@LocationID", vLocationID)
    mOK = MyBase.LoadCollection(mStockItemLocations, mParams, "StockItemLocationID")
    If mOK = True And mStockItemLocations.Count = 1 Then
      mRetVal = mStockItemLocations(0)
    End If
    Return mRetVal
  End Function


  Public Function SaveStockItemLocationCollection(ByRef rCollection As colStockItemLocations) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mIDs As String = ""
    If rCollection.IsDirty Then


      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItemLocation In rCollection.DeletedItems
          If pStockItemLocation.StockItemLocationID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItemLocation.StockItemLocationID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItemLocation In rCollection
        If pStockItemLocation.IsDirty Or pStockItemLocation.StockItemLocationID = 0 Then 'Or pStockItemLocation.StockItemLocationID = 0
          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

  Public Function LoadStockItemLocationCollectionByWhere(ByRef rStockItemLocations As colStockItemLocations, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rStockItemLocations, mParams, "StockItemLocationID", vWhere)
    rStockItemLocations.TrackDeleted = True
    If mOK Then rStockItemLocations.IsDirty = False
    Return mOK
  End Function

End Class

