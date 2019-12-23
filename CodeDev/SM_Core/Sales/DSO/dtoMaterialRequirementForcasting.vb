''DTO Definition - MaterialRequirementForcasting (to MaterialRequirementForcasting)'Generated from Table:MaterialRequirementForcasting

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoMaterialRequirementForcasting : Inherits dtoBase
  Private pMaterialRequirementForcasting As dmMaterialRequirementForcasting

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "MaterialRequirementForcasting"
    pKeyFieldName = "MaterialRequirementForcastingID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pMaterialRequirementForcasting.MaterialRequirementForcastingID
    End Get
    Set(ByVal value As Integer)
      pMaterialRequirementForcasting.MaterialRequirementForcastingID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pMaterialRequirementForcasting.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pMaterialRequirementForcasting.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "MaterialRequirementForcastingID", pMaterialRequirementForcasting.MaterialRequirementForcastingID)
    End If
    With pMaterialRequirementForcasting
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectType", .ObjectType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ObjectID", .ObjectID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaterialRequirementType", .MaterialRequirementType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UnitPiece", .UnitPiece)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetThickness", .NetThickness)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetWidth", .NetWidth)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "NetLenght", .NetLenght)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "QualityType", .QualityType)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "MaterialTypeID", .MaterialTypeID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodSpecie", .WoodSpecie)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "WoodFinish", .WoodFinish)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "UoM", StringToDBValue(.UoM))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "AreaID", .AreaID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "SupplierStockCode", StringToDBValue(.SupplierStockCode))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Comments", StringToDBValue(.Comments))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "PiecesPerComponent", .PiecesPerComponent)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "TotalPieces", .TotalPieces)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateChange", DateToDBValue(.DateChange))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "DateOtherMaterial", DateToDBValue(.DateOtherMaterial))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)


    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pMaterialRequirementForcasting Is Nothing Then SetObjectToNew()
      With pMaterialRequirementForcasting
        .MaterialRequirementForcastingID = DBReadInt32(rDataReader, "MaterialRequirementForcastingID")
        .ObjectType = DBReadByte(rDataReader, "ObjectType")
        .ObjectID = DBReadInt32(rDataReader, "ObjectID")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Description = DBReadString(rDataReader, "Description")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .MaterialRequirementType = DBReadByte(rDataReader, "MaterialRequirementType")
        .UnitPiece = DBReadInt32(rDataReader, "UnitPiece")
        .NetThickness = DBReadDecimal(rDataReader, "NetThickness")
        .NetWidth = DBReadDecimal(rDataReader, "NetWidth")
        .NetLenght = DBReadDecimal(rDataReader, "NetLenght")
        .QualityType = DBReadInt32(rDataReader, "QualityType")
        .MaterialTypeID = DBReadInt32(rDataReader, "MaterialTypeID")
        .WoodSpecie = DBReadInt32(rDataReader, "WoodSpecie")
        .WoodFinish = DBReadInt32(rDataReader, "WoodFinish")
        .UoM = DBReadString(rDataReader, "UoM")
        .AreaID = DBReadInt32(rDataReader, "AreaID")
        .SupplierStockCode = DBReadString(rDataReader, "SupplierStockCode")
        .Comments = DBReadString(rDataReader, "Comments")
        .PiecesPerComponent = DBReadDecimal(rDataReader, "PiecesPerComponent")
        .TotalPieces = DBReadDecimal(rDataReader, "TotalPieces")
        .DateChange = DBReadDateTime(rDataReader, "DateChange")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .DateOtherMaterial = DBReadDateTime(rDataReader, "DateOtherMaterial")
        pMaterialRequirementForcasting.IsDirty = False
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
    pMaterialRequirementForcasting = New dmMaterialRequirementForcasting ' Or .NewBlankMaterialRequirementForcasting
    Return pMaterialRequirementForcasting

  End Function


  Public Function LoadMaterialRequirementForcasting(ByRef rMaterialRequirementForcasting As dmMaterialRequirementForcasting, ByVal vMaterialRequirementForcastingID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vMaterialRequirementForcastingID)
    If mOK Then
      rMaterialRequirementForcasting = pMaterialRequirementForcasting
    Else
      rMaterialRequirementForcasting = Nothing
    End If
    pMaterialRequirementForcasting = Nothing
    Return mOK
  End Function


  Public Function SaveMaterialRequirementForcasting(ByRef rMaterialRequirementForcasting As dmMaterialRequirementForcasting) As Boolean
    Dim mOK As Boolean
    pMaterialRequirementForcasting = rMaterialRequirementForcasting
    mOK = SaveObject()
    pMaterialRequirementForcasting = Nothing
    Return mOK
  End Function


  Public Function LoadMaterialRequirementForcastingCollection(ByRef rMaterialRequirementForcastings As colMaterialRequirementForcastings, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ParentID", vParentID)
    mOK = MyBase.LoadCollection(rMaterialRequirementForcastings, mParams, "MaterialRequirementForcastingID")
    rMaterialRequirementForcastings.TrackDeleted = True
    If mOK Then rMaterialRequirementForcastings.IsDirty = False
    Return mOK
  End Function


  Public Function SaveMaterialRequirementForcastingCollection(ByRef rCollection As colMaterialRequirementForcastings, ByVal vParentID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ParentID", vParentID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pMaterialRequirementForcasting In rCollection
      ''    If pMaterialRequirementForcasting.MaterialRequirementForcastingID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pMaterialRequirementForcasting.MaterialRequirementForcastingID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pMaterialRequirementForcasting In rCollection.DeletedItems
          If pMaterialRequirementForcasting.MaterialRequirementForcastingID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pMaterialRequirementForcasting.MaterialRequirementForcastingID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pMaterialRequirementForcasting In rCollection
        If pMaterialRequirementForcasting.IsDirty Or pMaterialRequirementForcasting.ObjectID <> vParentID Or pMaterialRequirementForcasting.MaterialRequirementForcastingID = 0 Then 'Or pMaterialRequirementForcasting.MaterialRequirementForcastingID = 0
          pMaterialRequirementForcasting.ObjectID = vParentID
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



