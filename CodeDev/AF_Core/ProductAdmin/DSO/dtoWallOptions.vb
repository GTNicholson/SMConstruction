''DTO Definition - WallOptions (to WallOptions)'Generated from Table:WallOptions

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWallOptions : Inherits dtoBase
  Private pWallOptions As dmWallOptions

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WallOptions"
    pKeyFieldName = "WallOptionsID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWallOptions.WallOptionsID
    End Get
    Set(ByVal value As Integer)
      pWallOptions.WallOptionsID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWallOptions.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWallOptions.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WallOptionsID", pWallOptions.WallOptionsID)
    End If
    With pWallOptions
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWallOptions Is Nothing Then SetObjectToNew()
      With pWallOptions
        .WallOptionsID = DBReadInt32(rDataReader, "WallOptionsID")
        .Description = DBReadString(rDataReader, "Description")
        pWallOptions.IsDirty = False
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
    pWallOptions = New dmWallOptions ' Or .NewBlankWallOptions
    Return pWallOptions

  End Function


  Public Function LoadWallOptions(ByRef rWallOptions As dmWallOptions, ByVal vWallOptionsID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWallOptionsID)
    If mOK Then
      rWallOptions = pWallOptions
    Else
      rWallOptions = Nothing
    End If
    pWallOptions = Nothing
    Return mOK
  End Function


  Public Function SaveWallOptions(ByRef rWallOptions As dmWallOptions) As Boolean
    Dim mOK As Boolean
    pWallOptions = rWallOptions
    mOK = SaveObject()
    pWallOptions = Nothing
    Return mOK
  End Function


  Public Function LoadWallOptionsCollection(ByRef rWallOptionss As colWallOptionss) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rWallOptionss, mParams, "WallOptionsID")
    rWallOptionss.TrackDeleted = True
    If mOK Then rWallOptionss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWallOptionsCollection(ByRef rCollection As colWallOptionss, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWallOptions In rCollection
      ''    If pWallOptions.WallOptionsID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWallOptions.WallOptionsID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWallOptions In rCollection.DeletedItems
          If pWallOptions.WallOptionsID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWallOptions.WallOptionsID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWallOptions In rCollection
        If pWallOptions.IsDirty Or pWallOptions.WallOptionsID = 0 Then 'Or pWallOptions.WallOptionsID = 0
          '' pWallOptions.ParentID = vParentID
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

