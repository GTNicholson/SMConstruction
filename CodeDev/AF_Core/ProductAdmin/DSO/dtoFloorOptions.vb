''DTO Definition - FloorOptions (to FloorOptions)'Generated from Table:FloorOptions

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoFloorOptions : Inherits dtoBase
  Private pFloorOptions As dmFloorOptions

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "FloorOptions"
    pKeyFieldName = "FloorOptionsID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pFloorOptions.FloorOptionsID
    End Get
    Set(ByVal value As Integer)
      pFloorOptions.FloorOptionsID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pFloorOptions.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pFloorOptions.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "FloorOptionsID", pFloorOptions.FloorOptionsID)
    End If
    With pFloorOptions
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pFloorOptions Is Nothing Then SetObjectToNew()
      With pFloorOptions
        .FloorOptionsID = DBReadInt32(rDataReader, "FloorOptionsID")
        .Description = DBReadString(rDataReader, "Description")
        pFloorOptions.IsDirty = False
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
    pFloorOptions = New dmFloorOptions ' Or .NewBlankFloorOptions
    Return pFloorOptions

  End Function


  Public Function LoadFloorOptions(ByRef rFloorOptions As dmFloorOptions, ByVal vFloorOptionsID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vFloorOptionsID)
    If mOK Then
      rFloorOptions = pFloorOptions
    Else
      rFloorOptions = Nothing
    End If
    pFloorOptions = Nothing
    Return mOK
  End Function


  Public Function SaveFloorOptions(ByRef rFloorOptions As dmFloorOptions) As Boolean
    Dim mOK As Boolean
    pFloorOptions = rFloorOptions
    mOK = SaveObject()
    pFloorOptions = Nothing
    Return mOK
  End Function


  Public Function LoadFloorOptionsCollection(ByRef rFloorOptionss As colFloorOptionss) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rFloorOptionss, mParams, "FloorOptionsID")
    rFloorOptionss.TrackDeleted = True
    If mOK Then rFloorOptionss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveFloorOptionsCollection(ByRef rCollection As colFloorOptionss, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pFloorOptions In rCollection
      ''    If pFloorOptions.FloorOptionsID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pFloorOptions.FloorOptionsID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pFloorOptions In rCollection.DeletedItems
          If pFloorOptions.FloorOptionsID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pFloorOptions.FloorOptionsID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pFloorOptions In rCollection
        If pFloorOptions.IsDirty Or pFloorOptions.FloorOptionsID = 0 Then 'Or pFloorOptions.FloorOptionsID = 0
          ''pFloorOptions.ParentID = vParentID
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

