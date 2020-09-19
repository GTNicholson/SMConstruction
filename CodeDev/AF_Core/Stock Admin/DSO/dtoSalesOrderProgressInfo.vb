Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports RTIS.CommonVB

Public Class dtoSalesOrderProgressInfo : Inherits dtoBase

  Private pSalesOrderProgressInfo As clsSalesOrderProgressInfo


  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwSalesOrderProgressInfo"
    pKeyFieldName = "SalesOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.OverwriteChanges
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderProgressInfo.SalesOrder.SalesOrderID
    End Get
    Set(ByVal value As Integer)

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
      If pSalesOrderProgressInfo Is Nothing Then SetObjectToNew()
      With pSalesOrderProgressInfo

        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
        .FinishDate = DBReadDate(rDataReader, "FinishDate")
        .QtyWOs = DBReadInteger(rDataReader, "QtyWOs")
        .EngineeringCompleteQty = DBReadInteger(rDataReader, "EngineeringCompleteQty")
        .DespatchCompleteQty = DBReadInteger(rDataReader, "DespatchCompleteQty")
        .WOsMROtherPicked = DBReadInteger(rDataReader, "WOsMROtherPicked")
        .TimeSheetEntryDays = DBReadDecimal(rDataReader, "TimeSheetEntryDays")
        .CompanyName = DBReadString(rDataReader, "CompanyName")

        .SumCustomerOrderNetValue = DBReadDecimal(rDataReader, "SumCustomerOrderNetValue")

        .SumInvoiceItem = DBReadDecimal(rDataReader, "SumInvoiceItem")
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
    pSalesOrderProgressInfo = New clsSalesOrderProgressInfo
    Return pSalesOrderProgressInfo

  End Function


  Public Function LoadSalesOrderProgressInfoCollection(ByRef rStockItemInfos As colStockItemInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "StockItemID", vWhere)
    Return mOK
  End Function

  Public Function LoadSalesOrderProgressCollection(ByRef rStockItemInfos As colSalesOrderProgressInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    ''mParams.Add("@ParentID", vParentID)
    If vWhere <> "" Then
      mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "SalesOrderID", vWhere)
    Else
      mOK = MyBase.LoadCollection(rStockItemInfos, mParams, "SalesOrderID")
    End If

    Return mOK


  End Function

End Class

