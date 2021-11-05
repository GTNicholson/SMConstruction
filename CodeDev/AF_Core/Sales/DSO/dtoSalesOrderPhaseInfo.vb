Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase

Public Class dtoSalesOrderPhaseInfo : Inherits dtoBase
  Private pSalesOrderPhaseInfo As clsSalesOrderPhaseInfo


  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwSalesOrderPhaseInfo"

  End Sub

  Public Overrides Property IsDirtyValue As Boolean
    Get
      Return False
    End Get
    Set(value As Boolean)
    End Set
  End Property

  Public Overrides Property ObjectKeyFieldValue As Integer
    Get
      Return pSalesOrderPhaseInfo.SalesOrderPhaseID
    End Get
    Set(value As Integer)
    End Set
  End Property

  Public Overrides Property RowVersionValue As ULong
    Get
      Return 0
    End Get
    Set(value As ULong)
    End Set
  End Property

  Public Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As IDataParameterCollection, vSetList As Boolean)
  End Sub


  Public Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pSalesOrderPhaseInfo Is Nothing Then SetObjectToNew()

      With pSalesOrderPhaseInfo
        .FirstDatePlanned = DBReadDate(rDataReader, "PlannedStartDate")
        .QtyOT = DBReadInt32(rDataReader, "QtyOT")
      End With

      With pSalesOrderPhaseInfo.SalesOrderPhase
        .SalesOrderPhaseID = DBReadInt32(rDataReader, "SalesOrderPhaseID")
        .DateRequired = DBReadDate(rDataReader, "DateRequired")
        .QuantityItems = DBReadInt32(rDataReader, "QuantityItems")
        .PhaseNumber = DBReadInt32(rDataReader, "PhaseNumber")
        .DespatchStatus = DBReadByte(rDataReader, "DespatchStatus")
        .InvoiceStatus = DBReadByte(rDataReader, "InvoiceStatus")
        .ProductionStatus = DBReadByte(rDataReader, "ProductionStatus")
        .MatReqStatus = DBReadByte(rDataReader, "MatReqStatus")
        .DateCreated = DBReadDate(rDataReader, "DateCreated")
        .DateCommitted = DBReadDate(rDataReader, "DateCommitted")
        .CommittedBy = DBReadInt32(rDataReader, "CommittedBy")
        .JobNo = DBReadString(rDataReader, "SOPJobNo")
        .OrderReceivedDate = DBReadDate(rDataReader, "OrderReceivedDate")
        .ManReqDays = DBReadInt32(rDataReader, "ManReqDays")
        .TotalPrice = DBReadDecimal(rDataReader, "TotalPrice")

      End With
      With pSalesOrderPhaseInfo.SalesOrder
        .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .ContractManagerID = DBReadInt32(rDataReader, "ContractManagerID")
        .DateEntered = DBReadDate(rDataReader, "DateEntered")
        .OrderStatusENUM = DBReadInt32(rDataReader, "OrderStatusENUM")
        .OrderTypeID = DBReadInt32(rDataReader, "OrderTypeID")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
      End With
      With pSalesOrderPhaseInfo.Customer
        .CompanyName = DBReadString(rDataReader, "CompanyName")
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
    pSalesOrderPhaseInfo = New clsSalesOrderPhaseInfo
    Return pSalesOrderPhaseInfo
  End Function

  Public Function LoadSOPCollectionByWhere(ByRef rSalesOrderPhaseInfos As colSalesOrderPhaseInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean

    mOK = MyBase.LoadCollection(rSalesOrderPhaseInfos, mParams, "SalesOrderPhaseID", vWhere)

    Return mOK
  End Function



End Class
