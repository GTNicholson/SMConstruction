
''DTO Definition - TimeSheetEntry (to TimeSheetEntry)'Generated from Table:TimeSheetEntry

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoTimeSheetEntry : Inherits dtoBase
  Private pTimeSheetEntry As dmTimeSheetEntry

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "TimeSheetEntry"
    pKeyFieldName = "TimeSheetEntryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pTimeSheetEntry.TimeSheetEntryID
    End Get
    Set(ByVal value As Integer)
      pTimeSheetEntry.TimeSheetEntryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pTimeSheetEntry.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pTimeSheetEntry.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "TimeSheetEntryID", pTimeSheetEntry.TimeSheetEntryID)
    End If
    With pTimeSheetEntry
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TimeSheetEntryTypeID", .TimeSheetEntryTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EmployeeID", .EmployeeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WorkOrderID", .WorkOrderID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StartTime", DateToDBValue(.StartTime))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EndTime", DateToDBValue(.EndTime))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pTimeSheetEntry Is Nothing Then SetObjectToNew()
      With pTimeSheetEntry
        .TimeSheetEntryID = DBReadInt32(rDataReader, "TimeSheetEntryID")
        .TimeSheetEntryTypeID = DBReadInt32(rDataReader, "TimeSheetEntryTypeID")
        .EmployeeID = DBReadInt32(rDataReader, "EmployeeID")
        .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
        .StartTime = DBReadDateTime(rDataReader, "StartTime")
        .EndTime = DBReadDateTime(rDataReader, "EndTime")
        pTimeSheetEntry.IsDirty = False
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
    pTimeSheetEntry = New dmTimeSheetEntry ' Or .NewBlankTimeSheetEntry
    Return pTimeSheetEntry

  End Function


  Public Function LoadTimeSheetEntry(ByRef rTimeSheetEntry As dmTimeSheetEntry, ByVal vTimeSheetEntryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vTimeSheetEntryID)
    If mOK Then
      rTimeSheetEntry = pTimeSheetEntry
    Else
      rTimeSheetEntry = Nothing
    End If
    pTimeSheetEntry = Nothing
    Return mOK
  End Function


  Public Function SaveTimeSheetEntry(ByRef rTimeSheetEntry As dmTimeSheetEntry) As Boolean
    Dim mOK As Boolean
    pTimeSheetEntry = rTimeSheetEntry
    mOK = SaveObject()
    pTimeSheetEntry = Nothing
    Return mOK
  End Function


  Public Function LoadTimeSheetEntryCollection(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rTimeSheetEntrys, mParams, "TimeSheetEntryID")
    rTimeSheetEntrys.TrackDeleted = True
    If mOK Then rTimeSheetEntrys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveTimeSheetEntryCollection(ByRef rCollection As colTimeSheetEntrys, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pTimeSheetEntry In rCollection
      ''    If pTimeSheetEntry.TimeSheetEntryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pTimeSheetEntry.TimeSheetEntryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pTimeSheetEntry In rCollection.DeletedItems
          If pTimeSheetEntry.TimeSheetEntryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pTimeSheetEntry.TimeSheetEntryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pTimeSheetEntry In rCollection
        If pTimeSheetEntry.IsDirty Or pTimeSheetEntry.EmployeeID <> vParentID Or pTimeSheetEntry.TimeSheetEntryID = 0 Then 'Or pTimeSheetEntry.TimeSheetEntryID = 0
          pTimeSheetEntry.EmployeeID = vParentID
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




