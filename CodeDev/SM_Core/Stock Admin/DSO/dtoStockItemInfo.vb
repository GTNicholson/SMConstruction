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
      ObjectKeyFieldValue = pStockItemInfo.StockItemId
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
        .StockItemId = DBReadInt32(rDataReader, "StockItemId")
        .Category = DBReadInt32(rDataReader, "Category")
        .ItemType = DBReadInt32(rDataReader, "ItemType")
        .Species = DBReadInt32(rDataReader, "Species")
        .Colour = DBReadString(rDataReader, "Colour")
        .PartNo = DBReadString(rDataReader, "PartNo")
        .Length = DBReadDecimal(rDataReader, "Length")
        .Width = DBReadDecimal(rDataReader, "Width")
        .Thickness = DBReadDecimal(rDataReader, "Thickness")
        .Description = DBReadString(rDataReader, "Description")
        .StdCosT = DBReadDecimal(rDataReader, "StdCosT")

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

    mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "StockItemId", vWhere)
    Return mOK
  End Function

End Class

