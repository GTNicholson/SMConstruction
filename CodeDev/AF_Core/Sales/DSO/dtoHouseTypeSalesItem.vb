''DTO Definition - HouseTypeSalesItems (to HouseTypeSalesItems)'Generated from Table:HouseTypeSalesItems

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoHouseTypeSalesItem : Inherits dtoBase
  Private pHouseTypeSalesItems As dmHouseTypeSalesItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "HouseTypeSalesItem"
    pKeyFieldName = "HouseTypeSalesItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pHouseTypeSalesItems.HouseTypeSalesItemID
    End Get
    Set(ByVal value As Integer)
      pHouseTypeSalesItems.HouseTypeSalesItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pHouseTypeSalesItems.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pHouseTypeSalesItems.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "HouseTypeSalesItemID", pHouseTypeSalesItems.HouseTypeSalesItemID)
    End If
    With pHouseTypeSalesItems
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HouseTypeID", .HouseTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ItemNumber", StringToDBValue(.ItemNumber))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductTypeID", .ProductTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ImageFile", StringToDBValue(.ImageFile))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodSpeciesID", .WoodSpeciesID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodFinish", .WoodFinish)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "HouseTypeSalesItemAssemblyID", .HouseTypeSalesItemAssemblyID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ConditionString", StringToDBValue(.ConditionString))

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pHouseTypeSalesItems Is Nothing Then SetObjectToNew()
      With pHouseTypeSalesItems
        .HouseTypeSalesItemID = DBReadInt32(rDataReader, "HouseTypeSalesItemID")
        .HouseTypeID = DBReadInt32(rDataReader, "HouseTypeID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .ProductTypeID = DBReadByte(rDataReader, "ProductTypeID")
        .ItemNumber = DBReadString(rDataReader, "ItemNumber")
        .Description = DBReadString(rDataReader, "Description")
        .ConditionString = DBReadString(rDataReader, "ConditionString")

        .Quantity = DBReadInt32(rDataReader, "Quantity")
        .ImageFile = DBReadString(rDataReader, "ImageFile")
        .WoodSpeciesID = DBReadInt32(rDataReader, "WoodSpeciesID")
        .WoodFinish = DBReadInt32(rDataReader, "WoodFinish")
        .HouseTypeSalesItemAssemblyID = DBReadInt32(rDataReader, "HouseTypeSalesItemAssemblyID")

        pHouseTypeSalesItems.IsDirty = False
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
    pHouseTypeSalesItems = New dmHouseTypeSalesItem ' Or .NewBlankHouseTypeSalesItems
    Return pHouseTypeSalesItems

  End Function


  Public Function LoadHouseTypeSalesItems(ByRef rHouseTypeSalesItems As dmHouseTypeSalesItem, ByVal vHouseTypeSalesItemID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vHouseTypeSalesItemID)
    If mOK Then
      rHouseTypeSalesItems = pHouseTypeSalesItems
    Else
      rHouseTypeSalesItems = Nothing
    End If
    pHouseTypeSalesItems = Nothing
    Return mOK
  End Function


  Public Function SaveHouseTypeSalesItems(ByRef rHouseTypeSalesItems As dmHouseTypeSalesItem) As Boolean
    Dim mOK As Boolean
    pHouseTypeSalesItems = rHouseTypeSalesItems
    mOK = SaveObject()
    pHouseTypeSalesItems = Nothing
    Return mOK
  End Function
  Public Function LoadHouseTypeSalesItemsCollectionByWhere(ByRef rHouseTypeSalesItemss As colHouseTypeSalesItems, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@HouseTypeID", vHouseTypeID)
    mOK = MyBase.LoadCollection(rHouseTypeSalesItemss, mParams, "HouseTypeSalesItemID", vWhere)
    rHouseTypeSalesItemss.TrackDeleted = True
    If mOK Then rHouseTypeSalesItemss.IsDirty = False
    Return mOK
  End Function


  Public Function LoadHouseTypeSalesItemsCollection(ByRef rHouseTypeSalesItemss As colHouseTypeSalesItems, ByVal vHouseTypeID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@HouseTypeID", vHouseTypeID)
    mOK = MyBase.LoadCollection(rHouseTypeSalesItemss, mParams, "HouseTypeSalesItemID")
    rHouseTypeSalesItemss.TrackDeleted = True
    If mOK Then rHouseTypeSalesItemss.IsDirty = False
    Return mOK
  End Function


  Public Function SaveHouseTypeSalesItemsCollection(ByRef rCollection As colHouseTypeSalesItems, ByVal vHouseTypeID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@HouseTypeID", vHouseTypeID)


      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pHouseTypeSalesItems In rCollection.DeletedItems
          If pHouseTypeSalesItems.HouseTypeSalesItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pHouseTypeSalesItems.HouseTypeSalesItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pHouseTypeSalesItems In rCollection
        If pHouseTypeSalesItems.IsDirty Or pHouseTypeSalesItems.HouseTypeID <> vHouseTypeID Or pHouseTypeSalesItems.HouseTypeSalesItemID = 0 Then 'Or pHouseTypeSalesItems.HouseTypeSalesItemID = 0
          pHouseTypeSalesItems.HouseTypeID = vHouseTypeID
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

