''DTO Definition - WoodGuideItemSummary (to WoodGuideItemSummary)'Generated from Table:WoodGuideItemSummary

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodGuideItemSummary : Inherits dtoBase
  Private pWoodGuideItemSummary As dmWoodGuideItemSummary

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodGuideItemSummary"
    pKeyFieldName = "WoodGuideItemSummaryID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodGuideItemSummary.WoodGuideItemSummaryID
    End Get
    Set(ByVal value As Integer)
      pWoodGuideItemSummary.WoodGuideItemSummaryID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodGuideItemSummary.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodGuideItemSummary.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodGuideItemSummaryID", pWoodGuideItemSummary.WoodGuideItemSummaryID)
    End If
    With pWoodGuideItemSummary
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodReceptionID", .WoodReceptionID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpeciesID", .SpeciesID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AverageDiameter", .AverageDiameter)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Length", .Length)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VolumeM3", .VolumeM3)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodGuideItemSummary Is Nothing Then SetObjectToNew()
      With pWoodGuideItemSummary
        .WoodGuideItemSummaryID = DBReadInt32(rDataReader, "WoodGuideItemSummaryID")
        .WoodReceptionID = DBReadInt32(rDataReader, "WoodReceptionID")
        .SpeciesID = DBReadInt32(rDataReader, "SpeciesID")
        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .AverageDiameter = DBReadDecimal(rDataReader, "AverageDiameter")
        .Length = DBReadDecimal(rDataReader, "Length")
        .VolumeM3 = DBReadDecimal(rDataReader, "VolumeM3")
        pWoodGuideItemSummary.IsDirty = False
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
    pWoodGuideItemSummary = New dmWoodGuideItemSummary ' Or .NewBlankWoodGuideItemSummary
    Return pWoodGuideItemSummary

  End Function


  Public Function LoadWoodGuideItemSummary(ByRef rWoodGuideItemSummary As dmWoodGuideItemSummary, ByVal vWoodGuideItemSummaryID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodGuideItemSummaryID)
    If mOK Then
      rWoodGuideItemSummary = pWoodGuideItemSummary
    Else
      rWoodGuideItemSummary = Nothing
    End If
    pWoodGuideItemSummary = Nothing
    Return mOK
  End Function


  Public Function SaveWoodGuideItemSummary(ByRef rWoodGuideItemSummary As dmWoodGuideItemSummary) As Boolean
    Dim mOK As Boolean
    pWoodGuideItemSummary = rWoodGuideItemSummary
    mOK = SaveObject()
    pWoodGuideItemSummary = Nothing
    Return mOK
  End Function


  Public Function LoadWoodGuideItemSummaryCollection(ByRef rWoodGuideItemSummarys As colWoodGuideItemSummarys, ByVal vWoodReceptionID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WoodReceptionID", vWoodReceptionID)
    mOK = MyBase.LoadCollection(rWoodGuideItemSummarys, mParams, "WoodGuideItemSummaryID")
    rWoodGuideItemSummarys.TrackDeleted = True
    If mOK Then rWoodGuideItemSummarys.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWoodGuideItemSummaryCollection(ByRef rCollection As colWoodGuideItemSummarys, ByVal vWoodReceptionID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WoodReceptionID", vWoodReceptionID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodGuideItemSummary In rCollection
      ''    If pWoodGuideItemSummary.WoodGuideItemSummaryID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodGuideItemSummary.WoodGuideItemSummaryID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodGuideItemSummary In rCollection.DeletedItems
          If pWoodGuideItemSummary.WoodGuideItemSummaryID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodGuideItemSummary.WoodGuideItemSummaryID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodGuideItemSummary In rCollection
        If pWoodGuideItemSummary.IsDirty Or pWoodGuideItemSummary.WoodReceptionID <> vWoodReceptionID Or pWoodGuideItemSummary.WoodGuideItemSummaryID = 0 Then 'Or pWoodGuideItemSummary.WoodGuideItemSummaryID = 0
          pWoodGuideItemSummary.WoodReceptionID = vWoodReceptionID
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


