
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB



Public Class dtoSalesOrderInfo : Inherits dtoBase
  Private pSalesOrderInfo As clsSalesOrderInfo

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwSalesOrderInfo"
    pKeyFieldName = "SalesOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pSalesOrderInfo.SalesOrder.SalesOrderID
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
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property


  Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

  End Sub



  Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderInfo Is Nothing Then SetObjectToNew()

      With pSalesOrderInfo
        .TotalValue = DBReadDecimal(rDataReader, "TotalValue")
      End With

      With pSalesOrderInfo.SalesOrder
        .SalesOrderID = DBReadInteger(rDataReader, "SalesOrderID")
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .ContractManagerID = DBReadInt32(rDataReader, "ContractManagerID")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
        .OrderStatusENUM = DBReadInt32(rDataReader, "OrderStatusENUM")
        .OrderTypeID = DBReadInt32(rDataReader, "OrderTypeID")
        .DateEntered = DBReadDate(rDataReader, "DateEntered")
        .FinishDate = DBReadDate(rDataReader, "FinishDate")

      End With

      With pSalesOrderInfo.Customer
        .CompanyName = DBReadString(rDataReader, "CompanyName")
        .SalesAreaID = DBReadInt32(rDataReader, "SalesAreaID")
      End With



      mOK = True
    Catch Ex As Exception
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      mOK = False
    Finally

    End Try
    Return mOK
  End Function


  Protected Overrides Function SetObjectToNew() As Object
    pSalesOrderInfo = New clsSalesOrderInfo ' Or .NewBlankPurchaseInvoice
    Return pSalesOrderInfo

  End Function



  Public Function LoadSalesOrderInfoInfoCollectionByWhere(ByRef rSalesOrderInfoInfos As colSalesOrderInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rSalesOrderInfoInfos, mParams, "SalesOrderID", vWhere)
    Return mOK
  End Function



End Class
