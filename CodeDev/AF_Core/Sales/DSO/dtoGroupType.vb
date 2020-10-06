''DTO Definition - GroupType (to GroupType)'Generated from Table:GroupType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoGroupType : Inherits dtoBase
  Private pGroupType As dmGroupType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "GroupType"
    pKeyFieldName = "GroupTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pGroupType.GroupTypeID
    End Get
    Set(ByVal value As Integer)
      pGroupType.GroupTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pGroupType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pGroupType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "GroupTypeID", pGroupType.GroupTypeID)
    End If
    With pGroupType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Name", StringToDBValue(.Name))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pGroupType Is Nothing Then SetObjectToNew()
      With pGroupType
        .GroupTypeID = DBReadInt32(rDataReader, "GroupTypeID")
        .Name = DBReadString(rDataReader, "Name")
        pGroupType.IsDirty = False
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
    pGroupType = New dmGroupType ' Or .NewBlankGroupType
    Return pGroupType

  End Function


  Public Function LoadGroupType(ByRef rGroupType As dmGroupType, ByVal vGroupTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vGroupTypeID)
    If mOK Then
      rGroupType = pGroupType
    Else
      rGroupType = Nothing
    End If
    pGroupType = Nothing
    Return mOK
  End Function


  Public Function SaveGroupType(ByRef rGroupType As dmGroupType) As Boolean
    Dim mOK As Boolean
    pGroupType = rGroupType
    mOK = SaveObject()
    pGroupType = Nothing
    Return mOK
  End Function


  Public Function LoadGroupTypeCollection(ByRef rGroupTypes As colGroupTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rGroupTypes, mParams, "GroupTypeID")
    rGroupTypes.TrackDeleted = True
    If mOK Then rGroupTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveGroupTypeCollection(ByRef rCollection As colGroupTypes) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pGroupType In rCollection
      ''    If pGroupType.GroupTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pGroupType.GroupTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pGroupType In rCollection.DeletedItems
          If pGroupType.GroupTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pGroupType.GroupTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pGroupType In rCollection
        If pGroupType.IsDirty Or pGroupType.GroupTypeID = 0 Then 'Or pGroupType.GroupTypeID = 0
          ''pGroupType.ParentID = vParentID
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


