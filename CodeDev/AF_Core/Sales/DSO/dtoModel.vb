''DTO Definition - Model (to Model)'Generated from Table:Model

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoModel : Inherits dtoBase
  Private pModel As dmModel

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "Model"
    pKeyFieldName = "ModelID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pModel.ModelID
    End Get
    Set(ByVal value As Integer)
      pModel.ModelID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pModel.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pModel.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ModelID", pModel.ModelID)
    End If
    With pModel
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pModel Is Nothing Then SetObjectToNew()
      With pModel
        .ModelID = DBReadInt32(rDataReader, "ModelID")
        .Description = DBReadString(rDataReader, "Description")
        pModel.IsDirty = False
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
    pModel = New dmModel ' Or .NewBlankModel
    Return pModel

  End Function


  Public Function LoadModel(ByRef rModel As dmModel, ByVal vModelID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vModelID)
    If mOK Then
      rModel = pModel
    Else
      rModel = Nothing
    End If
    pModel = Nothing
    Return mOK
  End Function


  Public Function SaveModel(ByRef rModel As dmModel) As Boolean
    Dim mOK As Boolean
    pModel = rModel
    mOK = SaveObject()
    pModel = Nothing
    Return mOK
  End Function


  Public Function LoadModelCollection(ByRef rModels As colModels) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '' mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rModels, mParams, "ModelID")
    rModels.TrackDeleted = True
    If mOK Then rModels.IsDirty = False
    Return mOK
  End Function


  Public Function SaveModelCollection(ByRef rCollection As colModels) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''  mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pModel In rCollection
      ''    If pModel.ModelID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pModel.ModelID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pModel In rCollection.DeletedItems
          If pModel.ModelID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pModel.ModelID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pModel In rCollection
        If pModel.IsDirty Or pModel.ModelID = 0 Then 'Or pModel.ModelID = 0
          '' pModel.ParentID = vParentID
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


