''DTO Definition - CostBookEntry (to CostBookEntry)'Generated from Table:CostBookEntry

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoCostBookEntry : Inherits dtoBase
  Private pCostBookEntry As dmCostBookEntry

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "CostBookEntry"
    pKeyFieldName = "CostBookEntryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pCostBookEntry.CostBookEntryID
    End Get
    Set(ByVal value As Integer)
      pCostBookEntry.CostBookEntryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pCostBookEntry.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pCostBookEntry.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "CostBookEntryID", pCostBookEntry.CostBookEntryID)
    End If
    With pCostBookEntry
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostBookID", .CostBookID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Cost", .Cost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostUnit", .CostUnit)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MinCost", .MinCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RetailPrice", .RetailPrice)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pCostBookEntry Is Nothing Then SetObjectToNew()
      With pCostBookEntry
        .CostBookEntryID = DBReadInt32(rDataReader, "CostBookEntryID")
        .CostBookID = DBReadInt32(rDataReader, "CostBookID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .Cost = DBReadDecimal(rDataReader, "Cost")
        .CostUnit = DBReadInt32(rDataReader, "CostUnit")
        .MinCost = DBReadDecimal(rDataReader, "MinCost")
        .RetailPrice = DBReadDecimal(rDataReader, "RetailPrice")
        pCostBookEntry.IsDirty = False
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

  Public Function LoadCostBookEntryCollectionByWhere(ByRef rCostBookEntrys As colCostBookEntrys, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rCostBookEntrys, mParams, "CostBookEntryID", vWhere)
    rCostBookEntrys.TrackDeleted = True
    If mOK Then rCostBookEntrys.IsDirty = False
    Return mOK

  End Function

  Protected Overrides Function SetObjectToNew() As Object
    pCostBookEntry = New dmCostBookEntry ' Or .NewBlankCostBookEntry
    Return pCostBookEntry

  End Function


  Public Function LoadCostBookEntry(ByRef rCostBookEntry As dmCostBookEntry, ByVal vCostBookEntryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vCostBookEntryID)
    If mOK Then
      rCostBookEntry = pCostBookEntry
    Else
      rCostBookEntry = Nothing
    End If
    pCostBookEntry = Nothing
    Return mOK
  End Function


  Public Function SaveCostBookEntry(ByRef rCostBookEntry As dmCostBookEntry) As Boolean
    Dim mOK As Boolean
    pCostBookEntry = rCostBookEntry
    mOK = SaveObject()
    pCostBookEntry = Nothing
    Return mOK
  End Function


  Public Function LoadCostBookEntryCollection(ByRef rCostBookEntrys As colCostBookEntrys, ByVal vCostBookID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@CostBookID", vCostBookID)
    mOK = MyBase.LoadCollection(rCostBookEntrys, mParams, "CostBookEntryID")
    rCostBookEntrys.TrackDeleted = True
    If mOK Then rCostBookEntrys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveCostBookEntryCollection(ByRef rCollection As colCostBookEntrys, ByVal vCostBookID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vCostBookID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pCostBookEntry In rCollection
      ''    If pCostBookEntry.CostBookEntryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pCostBookEntry.CostBookEntryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pCostBookEntry In rCollection.DeletedItems
          If pCostBookEntry.CostBookEntryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pCostBookEntry.CostBookEntryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pCostBookEntry In rCollection
        If pCostBookEntry.IsDirty Or pCostBookEntry.CostBookID <> vCostBookID Or pCostBookEntry.CostBookEntryID = 0 Then 'Or pCostBookEntry.CostBookEntryID = 0
          pCostBookEntry.CostBookID = vCostBookID
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
