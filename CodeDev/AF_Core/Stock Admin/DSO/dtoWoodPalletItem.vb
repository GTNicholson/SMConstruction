''DTO Definition - WoodPalletItem (to WoodPalletItem)'Generated from Table:WoodPalletItem

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoWoodPalletItem : Inherits dtoBase
  Private pWoodPalletItem As dmWoodPalletItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "WoodPalletItem"
    pKeyFieldName = "WoodPalletItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWoodPalletItem.WoodPalletItemID
    End Get
    Set(ByVal value As Integer)
      pWoodPalletItem.WoodPalletItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pWoodPalletItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pWoodPalletItem.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "WoodPalletItemID", pWoodPalletItem.WoodPalletItemID)
    End If
    With pWoodPalletItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodPalletID", .WoodPalletID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Width", .Width)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Length", .Length)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QuantityUsed", .QuantityUsed)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Thickness", .Thickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OutstandingQty", .OutstandingQty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "VolumeM3", .VolumeM3)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TrozaRef", StringToDBValue(.TrozaRef))


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pWoodPalletItem Is Nothing Then SetObjectToNew()
      With pWoodPalletItem
        .WoodPalletItemID = DBReadInt32(rDataReader, "WoodPalletItemID")
        .WoodPalletID = DBReadInt32(rDataReader, "WoodPalletID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .Width = DBReadDecimal(rDataReader, "Width")
        .Length = DBReadDecimal(rDataReader, "Length")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .QuantityUsed = DBReadDecimal(rDataReader, "QuantityUsed")
        .Description = DBReadString(rDataReader, "Description")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        .OutstandingQty = DBReadDecimal(rDataReader, "OutstandingQty")
        .VolumeM3 = DBReadDecimal(rDataReader, "VolumeM3")
        .TrozaRef = DBReadString(rDataReader, "TrozaRef")
        pWoodPalletItem.IsDirty = False
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
    pWoodPalletItem = New dmWoodPalletItem ' Or .NewBlankWoodPalletItem
    Return pWoodPalletItem

  End Function


  Public Function LoadWoodPalletItem(ByRef rWoodPalletItem As dmWoodPalletItem, ByVal vWoodPalletItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vWoodPalletItemID)
    If mOK Then
      rWoodPalletItem = pWoodPalletItem
    Else
      rWoodPalletItem = Nothing
    End If
    pWoodPalletItem = Nothing
    Return mOK
  End Function


  Public Function SaveWoodPalletItem(ByRef rWoodPalletItem As dmWoodPalletItem) As Boolean
    Dim mOK As Boolean
    pWoodPalletItem = rWoodPalletItem
    mOK = SaveObject()
    pWoodPalletItem = Nothing
    Return mOK
  End Function


  Public Function LoadWoodPalletItemCollection(ByRef rWoodPalletItems As colWoodPalletItems, ByVal vWoodPalletID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@WoodPalletID", vWoodPalletID)
    mOK = MyBase.LoadCollection(rWoodPalletItems, mParams, "WoodPalletItemID")
    rWoodPalletItems.TrackDeleted = True
    If mOK Then rWoodPalletItems.IsDirty = False
    Return mOK
  End Function

  Public Function LoadWoodPalletItemCollectionByStockItemIDLocationID(ByRef rWoodPalletItems As colWoodPalletItems, ByVal vStockItemID As Integer, ByVal vLocationID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    Dim mSQL As String

    mSQL = "Select * from WoodPalletItem WPI "
    mSQL = mSQL & " Inner Join WoodPallet WP on WP.WoodPalletID = WPI.WoodPalletID "
    mSQL = mSQL & " Where LocationID = {0} And StockItemID = {1} And Archive <> 1"
    mSQL = String.Format(mSQL, vLocationID, vStockItemID)
    pDefinedSelectSQL = mSQL

    mOK = MyBase.LoadCollection(rWoodPalletItems, mParams, "WoodPalletItemID")
    rWoodPalletItems.TrackDeleted = True
    If mOK Then rWoodPalletItems.IsDirty = False

    Return mOK
  End Function

  Public Function SaveWoodPalletItemCollection(ByRef rCollection As colWoodPalletItems, ByVal vWoodPalletID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@WoodPalletID", vWoodPalletID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pWoodPalletItem In rCollection
      ''    If pWoodPalletItem.WoodPalletItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pWoodPalletItem.WoodPalletItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pWoodPalletItem In rCollection.DeletedItems
          If pWoodPalletItem.WoodPalletItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pWoodPalletItem.WoodPalletItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pWoodPalletItem In rCollection
        If pWoodPalletItem.IsDirty Or pWoodPalletItem.WoodPalletID <> vWoodPalletID Or pWoodPalletItem.WoodPalletItemID = 0 Then 'Or pWoodPalletItem.WoodPalletItemID = 0
          pWoodPalletItem.WoodPalletID = vWoodPalletID
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
