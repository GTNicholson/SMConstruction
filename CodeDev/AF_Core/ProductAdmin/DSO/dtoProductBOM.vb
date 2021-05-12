''DTO Definition - ProductBOM (to ProductBOM)'Generated from Table:ProductBOM

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoProductBOM : Inherits dtoBase
  Private pProductBOM As dmProductBOM

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "ProductBOM"
    pKeyFieldName = "ProductBOMID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pProductBOM.ProductBOMID
    End Get
    Set(ByVal value As Integer)
      pProductBOM.ProductBOMID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pProductBOM.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pProductBOM.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "ProductBOMID", pProductBOM.ProductBOMID)
    End If
    With pProductBOM
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ParentID", .ParentID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaterialRequirementType", .MaterialRequirementType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPiece", .UnitPiece)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetThickness", .NetThickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetWidth", .NetWidth)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetLenght", .NetLenght)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QualityType", .QualityType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaterialTypeID", .MaterialTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodSpecie", .WoodSpecie)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodFinish", .WoodFinish)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UoM", .UoM)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AreaID", .AreaID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierStockCode", StringToDBValue(.SupplierStockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comments", StringToDBValue(.Comments))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PiecesPerComponent", .PiecesPerComponent)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalPieces", .TotalPieces)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateChange", DateToDBValue(.DateChange))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateOtherMaterial", DateToDBValue(.DateOtherMaterial))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ComponentDescription", StringToDBValue(.ComponentDescription))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectType", .ObjectType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemThickness", .StockItemThickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodItemType", .WoodItemType)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pProductBOM Is Nothing Then SetObjectToNew()
      With pProductBOM
        .ProductBOMID = DBReadInt32(rDataReader, "ProductBOMID")
        .ParentID = DBReadInt32(rDataReader, "ParentID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Description = DBReadString(rDataReader, "Description")
        .MaterialRequirementType = DBReadByte(rDataReader, "MaterialRequirementType")
        .UnitPiece = DBReadInt32(rDataReader, "UnitPiece")
        .NetThickness = DBReadDecimal(rDataReader, "NetThickness")
        .NetWidth = DBReadDecimal(rDataReader, "NetWidth")
        .NetLenght = DBReadDecimal(rDataReader, "NetLenght")
        .QualityType = DBReadInt32(rDataReader, "QualityType")
        .MaterialTypeID = DBReadInt32(rDataReader, "MaterialTypeID")
        .WoodSpecie = DBReadInt32(rDataReader, "WoodSpecie")
        .WoodFinish = DBReadInt32(rDataReader, "WoodFinish")
        .UoM = DBReadInt32(rDataReader, "UoM")
        .AreaID = DBReadInt32(rDataReader, "AreaID")
        .SupplierStockCode = DBReadString(rDataReader, "SupplierStockCode")
        .Comments = DBReadString(rDataReader, "Comments")
        .PiecesPerComponent = DBReadDecimal(rDataReader, "PiecesPerComponent")
        .TotalPieces = DBReadDecimal(rDataReader, "TotalPieces")
        .DateChange = DBReadDateTime(rDataReader, "DateChange")
        .DateOtherMaterial = DBReadDateTime(rDataReader, "DateOtherMaterial")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .ComponentDescription = DBReadString(rDataReader, "ComponentDescription")
        .ObjectType = DBReadByte(rDataReader, "ObjectType")
        .StockItemThickness = DBReadInt32(rDataReader, "StockItemThickness")
        .WoodItemType = DBReadInt32(rDataReader, "WoodItemType")
        pProductBOM.IsDirty = False
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
    pProductBOM = New dmProductBOM ' Or .NewBlankProductBOM
    Return pProductBOM

  End Function


  Public Function LoadProductBOM(ByRef rProductBOM As dmProductBOM, ByVal vProductBOMID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductBOMID)
    If mOK Then
      rProductBOM = pProductBOM
    Else
      rProductBOM = Nothing
    End If
    pProductBOM = Nothing
    Return mOK
  End Function


  Public Function SaveProductBOM(ByRef rProductBOM As dmProductBOM) As Boolean
    Dim mOK As Boolean
    pProductBOM = rProductBOM
    mOK = SaveObject()
    pProductBOM = Nothing
    Return mOK
  End Function


  Public Function LoadProductBOMCollection(ByRef rProductBOMs As colProductBOMs, ByVal vProductID As Integer, ByVal vObjectType As Byte) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ProductID", vProductID)
    mParams.Add("@ObjectType", vObjectType)

    mOK = MyBase.LoadCollection(rProductBOMs, mParams, "ProductBOMID")
    rProductBOMs.TrackDeleted = True
    If mOK Then rProductBOMs.IsDirty = False
    Return mOK
  End Function
  Public Function LoadProductBOMAllCollectionByWhere(ByRef rProductBOMs As colProductBOMs, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rProductBOMs, mParams, "ProductBOMID", vWhere)
    rProductBOMs.TrackDeleted = True
    If mOK Then rProductBOMs.IsDirty = False
    Return mOK
  End Function

  Public Function SaveProductBOMCollection(ByRef rCollection As colProductBOMs, ByVal vProductID As Integer, ByVal vObjectType As Byte) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ProductID", vProductID)
      mParams.Add("@ObjectType", vObjectType)

      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pProductBOM In rCollection
      ''    If pProductBOM.ProductBOMID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pProductBOM.ProductBOMID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pProductBOM In rCollection.DeletedItems
          If pProductBOM.ProductBOMID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pProductBOM.ProductBOMID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pProductBOM In rCollection
        If pProductBOM.IsDirty Or pProductBOM.ProductID <> vProductID Or pProductBOM.ProductBOMID = 0 Then 'Or pProductBOM.ProductBOMID = 0
          pProductBOM.ProductID = vProductID
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