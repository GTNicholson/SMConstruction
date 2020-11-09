

''DTO Definition - WoodSpecie (to WoodSpecie)'Generated from Table:WoodSpecie

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodSpecie : Inherits dtoBase
  Private pWoodSpecie As dmWoodSpecie

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodSpecie"
    pKeyFieldName = "WoodSpecieID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodSpecie.WoodSpecieID
    End Get
    Set(ByVal value As Integer)
      pWoodSpecie.WoodSpecieID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodSpecie.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodSpecie.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodSpecieID", pWoodSpecie.WoodSpecieID)
    End If
    With pWoodSpecie
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "EnglishDescription", StringToDBValue(.EnglishDescription))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpanishDescription", StringToDBValue(.SpanishDescription))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Density", .Density)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PriceBracket", .PriceBracket)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Abbreviation", StringToDBValue(.Abbreviation))

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodSpecie Is Nothing Then SetObjectToNew()
      With pWoodSpecie
        .WoodSpecieID = DBReadInt32(rDataReader, "WoodSpecieID")
        .EnglishDescription = DBReadString(rDataReader, "EnglishDescription")
        .SpanishDescription = DBReadString(rDataReader, "SpanishDescription")
        .Density = DBReadDouble(rDataReader, "Density")
        .PriceBracket = DBReadByte(rDataReader, "PriceBracket")
        .Abbreviation = DBReadString(rDataReader, "Abbreviation")

        pWoodSpecie.IsDirty = False
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
    pWoodSpecie = New dmWoodSpecie ' Or .NewBlankWoodSpecie
    Return pWoodSpecie

  End Function


  Public Function LoadWoodSpecie(ByRef rWoodSpecie As dmWoodSpecie, ByVal vWoodSpecieID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodSpecieID)
    If mOK Then
      rWoodSpecie = pWoodSpecie
    Else
      rWoodSpecie = Nothing
    End If
    pWoodSpecie = Nothing
    Return mOK
  End Function


  Public Function SaveWoodSpecie(ByRef rWoodSpecie As dmWoodSpecie) As Boolean
    Dim mOK As Boolean
    pWoodSpecie = rWoodSpecie
    mOK = SaveObject()
    pWoodSpecie = Nothing
    Return mOK
  End Function


  Public Function LoadWoodSpecieCollection(ByRef rWoodSpecies As colWoodSpecies) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rWoodSpecies, mParams, "WoodSpecieID")
    rWoodSpecies.TrackDeleted = True
    If mOK Then rWoodSpecies.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWoodSpecieCollection(ByRef rCollection As colWoodSpecies) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      ''mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodSpecie In rCollection
      ''    If pWoodSpecie.WoodSpecieID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodSpecie.WoodSpecieID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodSpecie In rCollection.DeletedItems
          If pWoodSpecie.WoodSpecieID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodSpecie.WoodSpecieID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodSpecie In rCollection
        If pWoodSpecie.IsDirty Or pWoodSpecie.WoodSpecieID = 0 Then 'Or pWoodSpecie.WoodSpecieID = 0
          ''pWoodSpecie.ParentID = vParentID
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

