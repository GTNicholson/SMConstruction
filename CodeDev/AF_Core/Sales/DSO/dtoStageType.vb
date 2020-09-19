
''DTO Definition - StageType (to StageType)'Generated from Table:StageType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStageType : Inherits dtoBase
  Private pStageType As dmStageType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StageType"
    pKeyFieldName = "StageTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStageType.StageTypeID
    End Get
    Set(ByVal value As Integer)
      pStageType.StageTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStageType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStageType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StageTypeID", pStageType.StageTypeID)
    End If
    With pStageType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStageType Is Nothing Then SetObjectToNew()
      With pStageType
        .StageTypeID = DBReadInt32(rDataReader, "StageTypeID")
        .Description = DBReadString(rDataReader, "Description")
        pStageType.IsDirty = False
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
    pStageType = New dmStageType ' Or .NewBlankStageType
    Return pStageType

  End Function


  Public Function LoadStageType(ByRef rStageType As dmStageType, ByVal vStageTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStageTypeID)
    If mOK Then
      rStageType = pStageType
    Else
      rStageType = Nothing
    End If
    pStageType = Nothing
    Return mOK
  End Function


  Public Function SaveStageType(ByRef rStageType As dmStageType) As Boolean
    Dim mOK As Boolean
    pStageType = rStageType
    mOK = SaveObject()
    pStageType = Nothing
    Return mOK
  End Function


  Public Function LoadStageTypeCollection(ByRef rStageTypes As colStageTypes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rStageTypes, mParams, "StageTypeID")
    rStageTypes.TrackDeleted = True
    If mOK Then rStageTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStageTypeCollection(ByRef rCollection As colStageTypes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStageType In rCollection
      ''    If pStageType.StageTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStageType.StageTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStageType In rCollection.DeletedItems
          If pStageType.StageTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStageType.StageTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStageType In rCollection
        If pStageType.IsDirty Or pStageType.StageTypeID = 0 Then 'Or pStageType.StageTypeID = 0

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
