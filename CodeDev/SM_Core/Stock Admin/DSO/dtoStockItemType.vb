''DTO Definition - StockItemType (to StockItemType)'Generated from Table:StockItemType

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemType : Inherits dtoBase
  Private pStockItemType As dmStockItemType

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItemType"
    pKeyFieldName = "StockItemTypeID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemType.StockItemTypeID
    End Get
    Set(ByVal value As Integer)
      pStockItemType.StockItemTypeID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItemType.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItemType.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemTypeID", pStockItemType.StockItemTypeID)
    End If
    With pStockItemType
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DisplayOrder", .DisplayOrder)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Abbreviation", StringToDBValue(.Abbreviation))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Value", .Value)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ArchiveOnly", .ArchiveOnly)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Category", .Category)
    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemType Is Nothing Then SetObjectToNew()
      With pStockItemType
        .StockItemTypeID = DBReadInt32(rDataReader, "StockItemTypeID")
        .DisplayOrder = DBReadInt32(rDataReader, "DisplayOrder")
        .Abbreviation = DBReadString(rDataReader, "Abbreviation")
        .Description = DBReadString(rDataReader, "Description")
        .Value = DBReadInt32(rDataReader, "Value")
        .ArchiveOnly = DBReadBoolean(rDataReader, "ArchiveOnly")
        .Category = DBReadInt32(rDataReader, "Category")
        pStockItemType.IsDirty = False
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
    pStockItemType = New dmStockItemType ' Or .NewBlankStockItemType
    Return pStockItemType

  End Function


  Public Function LoadStockItemType(ByRef rStockItemType As dmStockItemType, ByVal vStockItemTypeID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemTypeID)
    If mOK Then
      rStockItemType = pStockItemType
    Else
      rStockItemType = Nothing
    End If
    pStockItemType = Nothing
    Return mOK
  End Function


  Public Function SaveStockItemType(ByRef rStockItemType As dmStockItemType) As Boolean
    Dim mOK As Boolean
    pStockItemType = rStockItemType
    mOK = SaveObject()
    pStockItemType = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemTypeCollection(ByRef rStockItemTypes As colStockItemTypes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rStockItemTypes, mParams, "StockItemTypeID")
    rStockItemTypes.TrackDeleted = True
    If mOK Then rStockItemTypes.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockItemTypeCollection(ByRef rCollection As colStockItemTypes, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockItemType In rCollection
      ''    If pStockItemType.StockItemTypeID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockItemType.StockItemTypeID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItemType In rCollection.DeletedItems
          If pStockItemType.StockItemTypeID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItemType.StockItemTypeID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItemType In rCollection
        If pStockItemType.IsDirty Or pStockItemType.StockItemTypeID = 0 Then 'Or pStockItemType.StockItemTypeID = 0

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


