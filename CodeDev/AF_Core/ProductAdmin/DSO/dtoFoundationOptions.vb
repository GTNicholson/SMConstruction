''DTO Definition - FoundationOptions (to FoundationOptions)'Generated from Table:FoundationOptions

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoFoundationOptions : Inherits dtoBase
  Private pFoundationOptions As dmFoundationOptions

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "FoundationOptions"
    pKeyFieldName = "FoundationOptionsID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pFoundationOptions.FoundationOptionsID
    End Get
    Set(ByVal value As Integer)
      pFoundationOptions.FoundationOptionsID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pFoundationOptions.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pFoundationOptions.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "FoundationOptionsID", pFoundationOptions.FoundationOptionsID)
    End If
    With pFoundationOptions
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pFoundationOptions Is Nothing Then SetObjectToNew()
      With pFoundationOptions
        .FoundationOptionsID = DBReadInt32(rDataReader, "FoundationOptionsID")
        .Description = DBReadString(rDataReader, "Description")
        pFoundationOptions.IsDirty = False
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
    pFoundationOptions = New dmFoundationOptions ' Or .NewBlankFoundationOptions
    Return pFoundationOptions

  End Function


  Public Function LoadFoundationOptions(ByRef rFoundationOptions As dmFoundationOptions, ByVal vFoundationOptionsID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vFoundationOptionsID)
    If mOK Then
      rFoundationOptions = pFoundationOptions
    Else
      rFoundationOptions = Nothing
    End If
    pFoundationOptions = Nothing
    Return mOK
  End Function


  Public Function SaveFoundationOptions(ByRef rFoundationOptions As dmFoundationOptions) As Boolean
    Dim mOK As Boolean
    pFoundationOptions = rFoundationOptions
    mOK = SaveObject()
    pFoundationOptions = Nothing
    Return mOK
  End Function


  Public Function LoadFoundationOptionsCollection(ByRef rFoundationOptionss As colFoundationOptionss) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rFoundationOptionss, mParams, "FoundationOptionsID")
    rFoundationOptionss.TrackDeleted = True
    If mOK Then rFoundationOptionss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveFoundationOptionsCollection(ByRef rCollection As colFoundationOptionss) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      '' mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pFoundationOptions In rCollection
      ''    If pFoundationOptions.FoundationOptionsID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pFoundationOptions.FoundationOptionsID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pFoundationOptions In rCollection.DeletedItems
          If pFoundationOptions.FoundationOptionsID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pFoundationOptions.FoundationOptionsID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pFoundationOptions In rCollection
        If pFoundationOptions.IsDirty Or pFoundationOptions.FoundationOptionsID = 0 Then 'Or pFoundationOptions.FoundationOptionsID = 0
          ''pFoundationOptions.ParentID = vParentID
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
