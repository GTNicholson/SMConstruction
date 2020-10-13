
''DTO Definition - ProductCostBookEntry (to ProductCostBookEntry)'Generated from Table:ProductCostBookEntry

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductCostBookEntry : Inherits dtoBase
  Private pProductCostBookEntry As dmProductCostBookEntry

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductCostBookEntry"
    pKeyFieldName = "ProductCostBookEntryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductCostBookEntry.ProductCostBookEntryID
    End Get
    Set(ByVal value As Integer)
      pProductCostBookEntry.ProductCostBookEntryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductCostBookEntry.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductCostBookEntry.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductCostBookEntryID", pProductCostBookEntry.ProductCostBookEntryID)
    End If
    With pProductCostBookEntry
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostBookID", .CostBookID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductTypeID", .ProductTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Cost", .Cost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostUnit", .CostUnit)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MinCost", .MinCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "RetailPrice", .RetailPrice)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductCostBookEntry Is Nothing Then SetObjectToNew()
      With pProductCostBookEntry
        .ProductCostBookEntryID = DBReadInt32(rDataReader, "ProductCostBookEntryID")
        .CostBookID = DBReadInt32(rDataReader, "CostBookID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .ProductTypeID = DBReadInt32(rDataReader, "ProductTypeID")
        .Cost = DBReadDecimal(rDataReader, "Cost")
        .CostUnit = DBReadInt32(rDataReader, "CostUnit")
        .MinCost = DBReadDecimal(rDataReader, "MinCost")
        .RetailPrice = DBReadDecimal(rDataReader, "RetailPrice")
        pProductCostBookEntry.IsDirty = False
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
    pProductCostBookEntry = New dmProductCostBookEntry ' Or .NewBlankProductCostBookEntry
    Return pProductCostBookEntry

  End Function


  Public Function LoadProductCostBookEntry(ByRef rProductCostBookEntry As dmProductCostBookEntry, ByVal vProductCostBookEntryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductCostBookEntryID)
    If mOK Then
      rProductCostBookEntry = pProductCostBookEntry
    Else
      rProductCostBookEntry = Nothing
    End If
    pProductCostBookEntry = Nothing
    Return mOK
  End Function


  Public Function SaveProductCostBookEntry(ByRef rProductCostBookEntry As dmProductCostBookEntry) As Boolean
    Dim mOK As Boolean
    pProductCostBookEntry = rProductCostBookEntry
    mOK = SaveObject()
    pProductCostBookEntry = Nothing
    Return mOK
  End Function


  Public Function LoadProductCostBookEntryCollection(ByRef rProductCostBookEntrys As colProductCostBookEntrys, ByVal vCostBookID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@CostBookID", vCostBookID)
    mOK = MyBase.LoadCollection(rProductCostBookEntrys, mParams, "ProductCostBookEntryID")
    rProductCostBookEntrys.TrackDeleted = True
    If mOK Then rProductCostBookEntrys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveProductCostBookEntryCollection(ByRef rCollection As colProductCostBookEntrys, ByVal vCostBookID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@CostBookID", vCostBookID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductCostBookEntry In rCollection
      ''    If pProductCostBookEntry.ProductCostBookEntryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductCostBookEntry.ProductCostBookEntryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductCostBookEntry In rCollection.DeletedItems
          If pProductCostBookEntry.ProductCostBookEntryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductCostBookEntry.ProductCostBookEntryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductCostBookEntry In rCollection
        If pProductCostBookEntry.IsDirty Or pProductCostBookEntry.CostBookID <> vCostBookID Or pProductCostBookEntry.ProductCostBookEntryID = 0 Then 'Or pProductCostBookEntry.ProductCostBookEntryID = 0
          pProductCostBookEntry.CostBookID = vCostBookID
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


