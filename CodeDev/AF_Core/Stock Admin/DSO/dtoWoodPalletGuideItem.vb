''DTO Definition - WoodPalletGuideItem (to WoodPalletGuideItem)'Generated from Table:WoodPalletGuideItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodPalletGuideItem : Inherits dtoBase
  Private pWoodPalletGuideItem As dmWoodPalletGuideItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodPalletGuideItem"
    pKeyFieldName = "WoodPalletGuideItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodPalletGuideItem.WoodPalletGuideItemID
    End Get
    Set(ByVal value As Integer)
      pWoodPalletGuideItem.WoodPalletGuideItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodPalletGuideItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodPalletGuideItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodPalletGuideItemID", pWoodPalletGuideItem.WoodPalletGuideItemID)
    End If
    With pWoodPalletGuideItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PalletID", .PalletID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SpeciesID", .SpeciesID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Width", .Width)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Length", .Length)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Thickness", .Thickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VolumeM3", .VolumeM3)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodPalletGuideItem Is Nothing Then SetObjectToNew()
      With pWoodPalletGuideItem
        .WoodPalletGuideItemID = DBReadInt32(rDataReader, "WoodPalletGuideItemID")
        .PalletID = DBReadInt32(rDataReader, "PalletID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .SpeciesID = DBReadInt32(rDataReader, "SpeciesID")
        .Width = DBReadDecimal(rDataReader, "Width")
        .Length = DBReadDecimal(rDataReader, "Length")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .Description = DBReadString(rDataReader, "Description")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        .VolumeM3 = DBReadDecimal(rDataReader, "VolumeM3")
        pWoodPalletGuideItem.IsDirty = False
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
    pWoodPalletGuideItem = New dmWoodPalletGuideItem ' Or .NewBlankWoodPalletGuideItem
    Return pWoodPalletGuideItem

  End Function


  Public Function LoadWoodPalletGuideItem(ByRef rWoodPalletGuideItem As dmWoodPalletGuideItem, ByVal vWoodPalletGuideItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodPalletGuideItemID)
    If mOK Then
      rWoodPalletGuideItem = pWoodPalletGuideItem
    Else
      rWoodPalletGuideItem = Nothing
    End If
    pWoodPalletGuideItem = Nothing
    Return mOK
  End Function


  Public Function SaveWoodPalletGuideItem(ByRef rWoodPalletGuideItem As dmWoodPalletGuideItem) As Boolean
    Dim mOK As Boolean
    pWoodPalletGuideItem = rWoodPalletGuideItem
    mOK = SaveObject()
    pWoodPalletGuideItem = Nothing
    Return mOK
  End Function


  Public Function LoadWoodPalletGuideItemCollection(ByRef rWoodPalletGuideItems As colWoodPalletGuideItems, ByVal vPalletID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@PalletID", vPalletID)
    mOK = MyBase.LoadCollection(rWoodPalletGuideItems, mParams, "WoodPalletGuideItemID")
    rWoodPalletGuideItems.TrackDeleted = True
    If mOK Then rWoodPalletGuideItems.IsDirty = False
    Return mOK
  End Function


  Public Function SaveWoodPalletGuideItemCollection(ByRef rCollection As colWoodPalletGuideItems, ByVal vPalletID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@PalletID", vPalletID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodPalletGuideItem In rCollection
      ''    If pWoodPalletGuideItem.WoodPalletGuideItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodPalletGuideItem.WoodPalletGuideItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodPalletGuideItem In rCollection.DeletedItems
          If pWoodPalletGuideItem.WoodPalletGuideItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodPalletGuideItem.WoodPalletGuideItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodPalletGuideItem In rCollection
        If pWoodPalletGuideItem.IsDirty Or pWoodPalletGuideItem.PalletID <> vPalletID Or pWoodPalletGuideItem.WoodPalletGuideItemID = 0 Then 'Or pWoodPalletGuideItem.WoodPalletGuideItemID = 0
          pWoodPalletGuideItem.PalletID = vPalletID
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

