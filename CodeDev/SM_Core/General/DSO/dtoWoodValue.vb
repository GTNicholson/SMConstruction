
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodValue : Inherits dtoBase
  Private pWoodValue As dmWoodValue

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodValue"
    pKeyFieldName = "WoodValueID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodValue.WoodValueID
    End Get
    Set(ByVal value As Integer)
      pWoodValue.WoodValueID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodValue.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodValue.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodValueID", pWoodValue.WoodValueID)
    End If
    With pWoodValue
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpeciesID", .SpeciesID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodValueDate", DateToDBValue(.WoodValueDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodValueBF", .WoodValueBF)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodValue Is Nothing Then SetObjectToNew()
      With pWoodValue
        .WoodValueID = DBReadInt32(rDataReader, "WoodValueID")
        .SpeciesID = DBReadInt32(rDataReader, "SpeciesID")
        .WoodValueDate = DBReadDateTime(rDataReader, "WoodValueDate")
        .WoodValueBF = DBReadDecimal(rDataReader, "WoodValueBF")
        pWoodValue.IsDirty = False
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
    pWoodValue = New dmWoodValue ' Or .NewBlankWoodValue
    Return pWoodValue

  End Function


  Public Function LoadWoodValue(ByRef rWoodValue As dmWoodValue, ByVal vWoodValueID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodValueID)
    If mOK Then
      rWoodValue = pWoodValue
    Else
      rWoodValue = Nothing
    End If
    pWoodValue = Nothing
    Return mOK
  End Function


  Public Function SaveWoodValue(ByRef rWoodValue As dmWoodValue) As Boolean
    Dim mOK As Boolean
    pWoodValue = rWoodValue
    mOK = SaveObject()
    pWoodValue = Nothing
    Return mOK
  End Function


  Public Function LoadWoodValueCollection(ByRef rWoodValues As colWoodValues, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@SpeciesID", vParentID)
    mOK = MyBase.LoadCollection(rWoodValues, mParams, "WoodValueID")
    rWoodValues.TrackDeleted = True
    If mOK Then rWoodValues.IsDirty = False
    Return mOK
  End Function

  Public Function LoadWoodValueCollectionRefList(ByRef rWoodValues As colWoodValues) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rWoodValues, mParams, "WoodValueID")
    rWoodValues.TrackDeleted = True
    If mOK Then rWoodValues.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWoodValueCollection(ByRef rCollection As colWoodValues, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@SpeciesID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodValue In rCollection
      ''    If pWoodValue.WoodValueID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodValue.WoodValueID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodValue In rCollection.DeletedItems
          If pWoodValue.WoodValueID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodValue.WoodValueID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodValue In rCollection
        If pWoodValue.IsDirty Or pWoodValue.SpeciesID <> vParentID Or pWoodValue.WoodValueID = 0 Then 'Or pWoodValue.WoodValueID = 0
          pWoodValue.SpeciesID = vParentID
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


