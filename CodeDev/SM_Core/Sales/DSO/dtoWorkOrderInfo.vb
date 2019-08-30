
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB

Public Class dtoWorkOrderInfo : Inherits dtoBase
  Private pWorkOrderInfo As clsWorkOrderInfo
  Private pMode As eMode

  Public Enum eMode
    WorkOrderInfo = 1
    WorkOrderTracking = 2
  End Enum

  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vmode As eMode)
    MyBase.New(rDBSource)
    pMode = vmode
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "vwWorkOrderInfo"
    pKeyFieldName = "WorkOrderID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderInfo.WorkOrder.WorkOrderID
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
      If pWorkOrderInfo Is Nothing Then SetObjectToNew()

      With pWorkOrderInfo.WorkOrder
        .WorkOrderID = DBReadInteger(rDataReader, "WorkOrderID")
        .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
        .Quantity = DBReadDouble(rDataReader, "Quantity")
        .Description = DBReadString(rDataReader, "Description")
        .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        .WorkOrderType = DBReadInt32(rDataReader, "WorkOrderType")
        .EmployeeName = DBReadString(rDataReader, "EmployeeName")
      End With

      With pWorkOrderInfo.SalesOrder
        .OrderNo = DBReadString(rDataReader, "OrderNo")
        .ProjectName = DBReadString(rDataReader, "ProjectName")
        .DueTime = DBReadDate(rDataReader, "DueTime")
      End With

      With pWorkOrderInfo.Customer
        .CompanyName = DBReadString(rDataReader, "CompanyName")
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
    Select Case pMode
      Case eMode.WorkOrderInfo
        pWorkOrderInfo = New clsWorkOrderInfo
      Case eMode.WorkOrderTracking
        pWorkOrderInfo = New clsWorkOrderTracking
    End Select
    Return pWorkOrderInfo

  End Function



  Public Function LoadWorkOrderInfoCollectionByWhere(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '    mParams.Add("@SupplierID", vWhere)
    mOK = MyBase.LoadCollection(rWorkOrderInfos, mParams, "WorkOrderID", vWhere)
    '  If mOK Then rPurchaseInvoiceTranCodeInfos.IsDirty = False
    Return mOK
  End Function


End Class
