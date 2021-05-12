''DTO Definition - WoodTypeValue (to WoodTypeValue)'Generated from Table:WoodTypeValue

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodTypeValue : Inherits dtoBase
  Private pWoodTypeValue As dmWoodTypeValue

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodTypeValue"
    pKeyFieldName = "WoodTypeValueID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodTypeValue.WoodTypeValueID
    End Get
    Set(ByVal value As Integer)
      pWoodTypeValue.WoodTypeValueID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodTypeValue.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodTypeValue.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodTypeValueID", pWoodTypeValue.WoodTypeValueID)
    End If
    With pWoodTypeValue
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodTypeValue Is Nothing Then SetObjectToNew()
      With pWoodTypeValue
        .WoodTypeValueID = DBReadInt32(rDataReader, "WoodTypeValueID")
        .Description = DBReadString(rDataReader, "Description")
        pWoodTypeValue.IsDirty = False
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
    pWoodTypeValue = New dmWoodTypeValue ' Or .NewBlankWoodTypeValue
    Return pWoodTypeValue

  End Function


  Public Function LoadWoodTypeValue(ByRef rWoodTypeValue As dmWoodTypeValue, ByVal vWoodTypeValueID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodTypeValueID)
    If mOK Then
      rWoodTypeValue = pWoodTypeValue
    Else
      rWoodTypeValue = Nothing
    End If
    pWoodTypeValue = Nothing
    Return mOK
  End Function


  Public Function SaveWoodTypeValue(ByRef rWoodTypeValue As dmWoodTypeValue) As Boolean
    Dim mOK As Boolean
    pWoodTypeValue = rWoodTypeValue
    mOK = SaveObject()
    pWoodTypeValue = Nothing
    Return mOK
  End Function


  Public Function LoadWoodTypeValueCollection(ByRef rWoodTypeValues As colWoodTypeValues) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rWoodTypeValues, mParams, "WoodTypeValueID")
    rWoodTypeValues.TrackDeleted = True
    If mOK Then rWoodTypeValues.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWoodTypeValueCollection(ByRef rCollection As colWoodTypeValues) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodTypeValue In rCollection
      ''    If pWoodTypeValue.WoodTypeValueID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodTypeValue.WoodTypeValueID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodTypeValue In rCollection.DeletedItems
          If pWoodTypeValue.WoodTypeValueID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodTypeValue.WoodTypeValueID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodTypeValue In rCollection
        If pWoodTypeValue.IsDirty Or pWoodTypeValue.WoodTypeValueID = 0 Then 'Or pWoodTypeValue.WoodTypeValueID = 0

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
