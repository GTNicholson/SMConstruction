Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoStockItemInfo : Inherits dtoBase

  Private pStockItemInfo As clsStockItemInfo


  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwStockItemInfo"
    pKeyFieldName = "StockItemId"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pStockItemInfo.StockItemID
    End Get
    Set(ByVal value As Integer)
      'pStockItemTransactionLogInfo.StockCode = value
    End Set
  End Property

  Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = False
    End Get
    Set(ByVal value As Boolean)
    End Set
  End Property

  Overrides Property RowVersionValue() As ULong
    Get
      Return Nothing
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

  End Sub


  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pStockItemInfo Is Nothing Then SetObjectToNew()
      With pStockItemInfo

        .CurrentInventory = DBReadDecimal(rDataReader, "Qty")
        '' .RequiredInventory = DBReadDecimal(rDataReader, "RequiredInventory")
        ''.OrderQty = DBReadDecimal(rDataReader, "OrderQty")
        ''.Balance = DBReadDecimal(rDataReader, "Balance")
      End With
      With pStockItemInfo.StockItem
        .StockItemID = DBReadInteger(rDataReader, "StockItemID")
        .Category = DBReadByte(rDataReader, "Category")
        .ItemType = DBReadByte(rDataReader, "ItemType")
        .StockCode = DBReadString(rDataReader, "StockCode")
        .Description = DBReadString(rDataReader, "Description")
        .ASISID = DBReadInt32(rDataReader, "ASISID")
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
    pStockItemInfo = New clsStockItemInfo
    Return pStockItemInfo

  End Function


  Public Function LoadStockItemLogInfoCollection(ByRef rStockItemInfos As colStockItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "StockItemID", vWhere)
    Return mOK
  End Function

  Public Function LoadStockItemCollection(ByRef rStockItemInfos As colStockItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    If vWhere <> "" Then
      mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "StockItemID", vWhere)
    Else
      mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "StockItemID")
    End If

    Return mOK


  End Function

End Class

