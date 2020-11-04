''DTO Definition - StockItemBOM (to StockItemBOM)'Generated from Table:StockItemBOM

Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemBOM : Inherits dtoBase
  Private pStockItemBOM As dmStockItemBOM

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "StockItemBOM"
    pKeyFieldName = "StockItemBOMID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemBOM.StockItemBOMID
    End Get
    Set(ByVal value As Integer)
      pStockItemBOM.StockItemBOMID = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = pStockItemBOM.IsDirty
    End Get
    Set(ByVal value As Boolean)
      pStockItemBOM.IsDirty = value
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
      DBSource.AddParamPropertyInfo(rParameterValues, mDummy, mDummy2, vSetList, "StockItemBOMID", pStockItemBOM.StockItemBOMID)
    End If
    With pStockItemBOM
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "ProductID", .ProductID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockItemID", .StockItemID)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Quantity", .Quantity)
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "Description", StringToDBValue(.Description))
      DBSource.AddParamPropertyInfo(rParameterValues, rFieldList, rParamList, vSetList, "StockCode", StringToDBValue(.StockCode))

    End With

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemBOM Is Nothing Then SetObjectToNew()
      With pStockItemBOM
        .StockItemBOMID = DBReadInt32(rDataReader, "StockItemBOMID")
        .ProductID = DBReadInt32(rDataReader, "ProductID")
        .StockItemID = DBReadInt32(rDataReader, "StockItemID")
        .Quantity = DBReadDecimal(rDataReader, "Quantity")
        .Description = DBReadString(rDataReader, "Description")
        .StockCode = DBReadString(rDataReader, "StockCode")
        pStockItemBOM.IsDirty = False
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
    pStockItemBOM = New dmStockItemBOM ' Or .NewBlankStockItemBOM
    Return pStockItemBOM

  End Function


  Public Function LoadStockItemBOM(ByRef rStockItemBOM As dmStockItemBOM, ByVal vStockItemBOMID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vStockItemBOMID)
    If mOK Then
      rStockItemBOM = pStockItemBOM
    Else
      rStockItemBOM = Nothing
    End If
    pStockItemBOM = Nothing
    Return mOK
  End Function


  Public Function SaveStockItemBOM(ByRef rStockItemBOM As dmStockItemBOM) As Boolean
    Dim mOK As Boolean
    pStockItemBOM = rStockItemBOM
    mOK = SaveObject()
    pStockItemBOM = Nothing
    Return mOK
  End Function


  Public Function LoadStockItemBOMCollection(ByRef rStockItemBOMs As colStockItemBOMs, ByVal vProductID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    mParams.Add("@ProductID", vProductID)
    mOK = MyBase.LoadCollection(rStockItemBOMs, mParams, "StockItemBOMID")
    rStockItemBOMs.TrackDeleted = True
    If mOK Then rStockItemBOMs.IsDirty = False
    Return mOK
  End Function


  Public Function SaveStockItemBOMCollection(ByRef rCollection As colStockItemBOMs, ByVal vProductID As Integer) As Boolean
    Dim mParams As New Hashtable
    Dim mAllOK As Boolean
    Dim mCount As Integer
    Dim mIDs As String = ""
    If rCollection.IsDirty Then
      mParams.Add("@ProductID", vProductID)
      ''Approach where delete items not found in the collection
      ''If rCollection.SomeRemoved Then
      ''  For Each Me.pStockItemBOM In rCollection
      ''    If pStockItemBOM.StockItemBOMID <> 0 Then
      ''      mCount = mCount + 1
      ''      If mCount > 1 Then mIDs = mIDs & ", "
      ''       mIDs = mIDs & pStockItemBOM.StockItemBOMID.ToString
      ''    End If
      ''  Next
      ''  mAllOK = MyBase.CollectionDeleteMissingItems(mParams, mIDs)
      ''Else
      ''   mAllOK = True
      ''End If

      ''Alternative Approach - where maintain collection of deleted items
      If rCollection.SomeDeleted Then
        mAllOK = True
        For Each Me.pStockItemBOM In rCollection.DeletedItems
          If pStockItemBOM.StockItemBOMID <> 0 Then
            If mAllOK Then mAllOK = MyBase.DeleteDBRecord(pStockItemBOM.StockItemBOMID)
          End If
        Next
      Else
        mAllOK = True
      End If

      For Each Me.pStockItemBOM In rCollection
        If pStockItemBOM.IsDirty Or pStockItemBOM.ProductID <> vProductID Or pStockItemBOM.StockItemBOMID = 0 Then 'Or pStockItemBOM.StockItemBOMID = 0
          pStockItemBOM.ProductID = vProductID
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