Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoOutputDocument : Inherits dtoBase
  Private pOutputDocument As dmOutputDocument

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "OutputDocument"
    pKeyFieldName = "OutputDocumentID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pOutputDocument.OutputDocumentID
    End Get
    Set(ByVal value As Integer)
      pOutputDocument.OutputDocumentID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pOutputDocument.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pOutputDocument.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
      Return Nothing
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "OutputDocumentID", pOutputDocument.OutputDocumentID)
    End If
    With pOutputDocument
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentID", .ParentID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentTypeID", .ParentTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DocumentTypeID", .DocumentTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FileTypeID", .FileTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "FilePath", StringToDBValue(.FilePath))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VersionRef", StringToDBValue(.VersionRef))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateCreated", DateToDBValue(.DateCreated))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pOutputDocument Is Nothing Then SetObjectToNew()
      With pOutputDocument
        .OutputDocumentID = DBReadInt32(rDataReader, "OutputDocumentID")
        .ParentID = DBReadInt32(rDataReader, "ParentID")
        .ParentTypeID = DBReadByte(rDataReader, "ParentTypeID")
        .DocumentTypeID = DBReadByte(rDataReader, "DocumentTypeID")
        .FileTypeID = DBReadByte(rDataReader, "FileTypeID")
        .FilePath = DBReadString(rDataReader, "FilePath")
        .VersionRef = DBReadString(rDataReader, "VersionRef")
        .DateCreated = DBReadDateTime(rDataReader, "DateCreated")
        pOutputDocument.IsDirty = False
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
    pOutputDocument = New dmOutputDocument ' Or .NewBlankProdBatchOutputDocument
    Return pOutputDocument

  End Function


  Public Function LoadOutputDocument(ByRef rOutputDocument As dmOutputDocument, ByVal vID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vID)
    If mOK Then
      rOutputDocument = pOutputDocument
    Else
      rOutputDocument = Nothing
    End If
    pOutputDocument = Nothing
    Return mOK
  End Function


  Public Function SaveOutputDocument(ByRef rOutputDocument As dmOutputDocument) As Boolean
    Dim mOK As Boolean
    pOutputDocument = rOutputDocument
    mOK = SaveObject()
    pOutputDocument = Nothing
    Return mOK
  End Function


  Public Function LoadOutputDocumentCollection(ByRef rOutputDocuments As colOutputDocuments, ByVal vParentID As Integer, ByVal vParentTypeID As eParentType) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mParams.Add("@ParentTypeID", vParentTypeID)
    mOK = MyBase.LoadCollection(rOutputDocuments, mParams, "OutputDocumentID")
    If mOK Then rOutputDocuments.IsDirty = False
    Return mOK
  End Function


  Public Function SaveOutputDocumentCollection(ByRef rCollection As colOutputDocuments, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pOutputDocument In rCollection
      ''    If pOutputDocument.ID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pOutputDocument.ID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pOutputDocument In rCollection.DeletedItems
          If pOutputDocument.OutputDocumentID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pOutputDocument.OutputDocumentID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pOutputDocument In rCollection
        If pOutputDocument.IsDirty Or pOutputDocument.ParentID <> vParentID Or pOutputDocument.OutputDocumentID = 0 Then 'Or pOutputDocument.ID = 0
          pOutputDocument.ParentID = vParentID
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




