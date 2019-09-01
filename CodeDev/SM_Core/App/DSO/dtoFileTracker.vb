

''DTO Definition - FileTracker (to FileTracker)'Generated from Table:FileTracker

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoFileTracker : Inherits dtoBase
  Private pFileTracker As dmFileTracker

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "FileTracker"
    pKeyFieldName = "FileID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pFileTracker.FileID
    End Get
    Set(ByVal value As Integer)
      pFileTracker.FileID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pFileTracker.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pFileTracker.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "FileID", pFileTracker.FileID)
    End If
    With pFileTracker
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FileName", StringToDBValue(.FileName))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FileType", StringToDBValue(.FileType))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateReceived", DateToDBValue(.DateReceived))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentID", .ParentID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentType", .ParentType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IncludeInPack", .IncludeInPack)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pFileTracker Is Nothing Then SetObjectToNew()
      With pFileTracker
        .FileID = DBReadInt32(rDataReader, "FileID")
        .FileName = DBReadString(rDataReader, "FileName")
        .FileType = DBReadString(rDataReader, "FileType")
        .DateReceived = DBReadDateTime(rDataReader, "DateReceived")
        .ParentID = DBReadInt32(rDataReader, "ParentID")
        .ParentType = DBReadInt32(rDataReader, "ParentType")
        .Description = DBReadString(rDataReader, "Description")
        .IncludeInPack = DBReadBoolean(rDataReader, "IncludeInPack")
        pFileTracker.IsDirty = False
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
    pFileTracker = New dmFileTracker ' Or .NewBlankFileTracker
    Return pFileTracker

  End Function


  Public Function LoadFileTracker(ByRef rFileTracker As dmFileTracker, ByVal vFileID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vFileID)
    If mOK Then
      rFileTracker = pFileTracker
    Else
      rFileTracker = Nothing
    End If
    pFileTracker = Nothing
    Return mOK
  End Function


  Public Function SaveFileTracker(ByRef rFileTracker As dmFileTracker) As Boolean
    Dim mOK As Boolean
    pFileTracker = rFileTracker
    mOK = SaveObject()
    pFileTracker = Nothing
    Return mOK
  End Function


  Public Function LoadFileTrackerCollection(ByRef rFileTrackers As colFileTrackers, ByVal vParentType As Integer, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mParams.Add("@ParentType", vParentType)
    mOK = MyBase.LoadCollection(rFileTrackers, mParams, "FileID")
    If mOK Then rFileTrackers.IsDirty = False
    Return mOK
  End Function


  Public Function SaveFileTrackerCollection(ByRef rCollection As colFileTrackers, ByVal vParentType As Integer, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""

    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''mParams.Add("@ParentType", vParentType)
      ''''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pFileTracker In rCollection
      ''    If pFileTracker.FileID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''      mIDs = mIDs & pFileTracker.FileID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''  mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each pFileTracker In rCollection.DeletedItems
          If pFileTracker.FileID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pFileTracker.FileID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pFileTracker In rCollection
          If pFileTracker.IsDirty Or pFileTracker.ParentID <> vParentID Or pFileTracker.FileID = 0 Then 'Or pFileTracker.FileID = 0
            pFileTracker.ParentID = vParentID
            pFileTracker.ParentType = vParentType

            Try
              SaveObject()
            Catch ex As Exception
              mAllOK = False
              clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyAppService)
            End Try

          End If
        Next
        If mAllOK Then rCollection.IsDirty = False
      Else
        mAllOK = True
    End If

    Return mAllOK
  End Function

End Class
