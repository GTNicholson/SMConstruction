Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItem : Inherits dtoBase
  Implements intdtoStockItem

  Private pStockItem As dmStockItem

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Function SetObjectToNew() As Object
    pStockItem = New dmStockItem ' Or .NewBlankStockTake
    Return pStockItem

  End Function

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItem"
    pKeyFieldName = "StockItemID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Public Function LoadStockItemsByWhere(rStockItems As colStockItems, vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rStockItems, mParams, "StockItemID", vWhere)
    If mOK Then rStockItems.IsDirty = False
    Return mOK
  End Function

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItem.StockItemID
    End Get
    Set(ByVal value As Integer)
      pStockItem.StockItemID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItem.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItem.IsDirty = value
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property

  Public ReadOnly Property KeyFieldName As String Implements intdtoStockItem.KeyFieldName
    Get
      Return pKeyFieldName
    End Get
  End Property

  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

    Dim mDummy As String = ""
    Dim mDummy2 As String = ""
    If vSetList Then
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemID", pStockItem.StockItemID)
    End If
    With pStockItem
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Category", .Category)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ItemType", .ItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Species", .Species)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Colour", StringToDBValue(.Colour))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PartNo", StringToDBValue(.PartNo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Length", .Length)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Width", .Width)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Thickness", .Thickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockQuantity", .StockQuantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DefaultSupplier", .DefaultSupplier)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Finish", .Finish)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ShortDescription", StringToDBValue(.ShortDescription))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SubItemType", .SubItemType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockFinanceCategoryID", .StockFinanceCategoryID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ExtraInfo", StringToDBValue(.ExtraInfo))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Handing", .Handing)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "OppositeStockItemID", .OppositeStockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsGeneric", .IsGeneric)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TemplateStockItemID", .TemplateStockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Inactive", .Inactive)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "InterdenStockItemID", .InterdenStockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProjectID", .ProjectID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StdCost", .StdCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StdImportCost", .StdImportCost)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ASISID", .ASISID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ImageFile", StringToDBValue(.ImageFile))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostQty", .CostQty)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "LasUsedDate", DateToDBValue(.LastUsedDate))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AuxCode", StringToDBValue(.AuxCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UoM", .UoM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierUoM", .SupplierUoM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "CostUoM", .CostUoM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "IsCostingOnly", .IsCostingOnly)
      '// Not in write as it is updated elsewuere
      '// DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AverageCost", .AverageCost)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItem Is Nothing Then SetObjectToNew()
      With pStockItem
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Category = DBReadByte(rDataReader, "Category")
        .ItemType = DBReadByte(rDataReader, "ItemType")
        .Species = DBReadInt32(rDataReader, "Species")
        .Colour = DBReadString(rDataReader, "Colour")
        .PartNo = DBReadString(rDataReader, "PartNo")
        .Length = DBReadDecimal(rDataReader, "Length")
        .Width = DBReadDecimal(rDataReader, "Width")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        .Description = DBReadString(rDataReader, "Description")
        .StockQuantity = DBReadDecimal(rDataReader, "StockQuantity")
        .DefaultSupplier = DBReadInt32(rDataReader, "DefaultSupplier")
        .Finish = DBReadByte(rDataReader, "Finish")
        .ShortDescription = DBReadString(rDataReader, "ShortDescription")
        .SubItemType = DBReadInt32(rDataReader, "SubItemType")
        .StockFinanceCategoryID = DBReadInt32(rDataReader, "StockFinanceCategoryID")
        .ExtraInfo = DBReadString(rDataReader, "ExtraInfo")
        .Handing = DBReadByte(rDataReader, "Handing")
        .OppositeStockItemID = DBReadInt32(rDataReader, "OppositeStockItemID")
        .IsGeneric = DBReadBoolean(rDataReader, "IsGeneric")
        .TemplateStockItemID = DBReadInt32(rDataReader, "TemplateStockItemID")
        .Inactive = DBReadBoolean(rDataReader, "Inactive")
        .InterdenStockItemID = DBReadInt32(rDataReader, "InterdenStockItemID")
        .ProjectID = DBReadInt32(rDataReader, "ProjectID")
        .StdCost = DBReadDecimal(rDataReader, "StdCost")
        .StdImportCost = DBReadDecimal(rDataReader, "StdImportCost")
        .ASISID = DBReadInt32(rDataReader, "ASISID")
        .ImageFile = DBReadString(rDataReader, "ImageFile")
        .CostQty = DBReadDecimal(rDataReader, "CostQty")
        .LastUsedDate = DBReadDateTime(rDataReader, "LastUsedDate")
        .AuxCode = DBReadString(rDataReader, "AuxCode")
        .UoM = DBReadInt32(rDataReader, "UoM")
        .SupplierUoM = DBReadInt32(rDataReader, "SupplierUoM")
        .CostUoM = DBReadByte(rDataReader, "CostUoM")
        .IsCostingOnly = DBReadBoolean(rDataReader, "IsCostingOnly")
        .AverageCost = DBReadBoolean(rDataReader, "AverageCost")
        pStockItem.IsDirty = False
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

  Public Function LoadStockItem(ByRef rStockItem As dmStockItem, ByVal vStockItemID As Integer) As Boolean Implements intdtoStockItem.LoadStockItem
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemID)
    If mOK Then
      rStockItem = pStockItem
    Else
      rStockItem = Nothing
    End If
    pStockItem = Nothing
    Return mOK
  End Function


  Public Function SaveStockItem(ByRef rStockItem As dmStockItem) As Boolean
    Dim mOK As Boolean
    pStockItem = rStockItem
    mOK = SaveObject()
    pStockItem = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemCollection(ByRef rStockItems As colStockItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rStockItems, mParams, "StockItemID")
    rStockItems.TrackDeleted = True
    If mOK Then rStockItems.IsDirty = False
    Return mOK
  End Function
  Public Function LoadStockItemCollectionByWhere(ByRef rStockItems As colStockItems, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mOK = MyBase.LoadCollection(rStockItems, mParams, "StockItemID", vWhere)
    If mOK Then rStockItems.IsDirty = False
    Return mOK
  End Function

  Public Function SaveStockItemCollection(ByRef rCollection As colStockItems, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockItem In rCollection
      ''    If pStockItem.StockItemID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockItem.StockItemID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItem In rCollection.DeletedItems
          If pStockItem.StockItemID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItem.StockItemID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItem In rCollection
        If pStockItem.IsDirty Or pStockItem.StockItemID = 0 Then 'Or pStockItem.StockItemID = 0

          If mAllOK Then mAllOK = SaveObject()
        End If
      Next
      If mAllOK Then rCollection.IsDirty = False
    Else
      mAllOK = True
    End If

    Return mAllOK
  End Function

  Public Function LoadStockItemsDictByParams(ByRef rStockItemsDict As Dictionary(Of Integer, RTIS.ERPStock.intStockItemDef), ByRef rParams As Hashtable) As Boolean Implements intdtoStockItem.LoadStockItemsDictByParams
    Dim mParams As New Hashtable
    Dim mStockItems As New colStockItems
    Dim mOK As Boolean
    For Each mItem As KeyValuePair(Of String, Object) In rParams
      mParams.Add(mItem.Key, mItem.Value)
    Next
    mOK = MyBase.LoadCollection(mStockItems, mParams, pKeyFieldName)
    For Each mSI As dmStockItem In mStockItems
      If rStockItemsDict.ContainsKey(mSI.StockItemID) = False Then
        rStockItemsDict.Add(mSI.StockItemID, mSI)
      End If
    Next
    Return mOK
  End Function

End Class