
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB

Public Class dtoWorkOrderInfo : Inherits dtoBase
  Private pWorkOrderInfo As clsWorkOrderInfo
  Private pMode As eMode

  Public Enum eMode
    WorkOrderInfo = 1
    WorkOrderInfoInternal = 2
    WorkOrderTracking = 3
  End Enum

  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vmode As eMode)
    MyBase.New(rDBSource)
    pMode = vmode
    SetTableDetails()
  End Sub


  Protected Overrides Sub SetTableDetails()
    Select Case pMode
      Case eMode.WorkOrderInfo
        pTableName = "vwWorkOrderInfo"
        pKeyFieldName = "WorkOrderID"
      Case eMode.WorkOrderInfoInternal
        pTableName = "vwWorkOrderInternalInfo"   '// Axel this is a new query
        pKeyFieldName = "WorkOrderID"
      Case eMode.WorkOrderTracking
        pTableName = "vwWorkOrderTracking"
        pKeyFieldName = "WorkOrderID"


    End Select
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
        .Quantity = DBReadInteger(rDataReader, "Quantity")
        .Description = DBReadString(rDataReader, "Description")
        .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
        .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
        .WorkOrderType = DBReadInt32(rDataReader, "WorkOrderType")
        .EmployeeID = DBReadInteger(rDataReader, "EmployeeID")
        .ProductTypeID = DBReadInteger(rDataReader, "ProductTypeID")


        .PlannedDeliverDate = DBReadDate(rDataReader, "PlannedDeliverDate")
      End With

      Select Case pMode
        Case eMode.WorkOrderInfo, eMode.WorkOrderTracking

          With pWorkOrderInfo.SalesOrder
            .OrderNo = DBReadString(rDataReader, "OrderNo")
            .ProjectName = DBReadString(rDataReader, "ProjectName")
            .DueTime = DBReadDate(rDataReader, "DueTime")
            .FinishDate = DBReadDate(rDataReader, "FinishDate")
          End With

          With pWorkOrderInfo.Customer
            .CompanyName = DBReadString(rDataReader, "CompanyName")
          End With

        Case eMode.WorkOrderInfoInternal

          With pWorkOrderInfo.WorkOrder
            .PlannedDeliverDate = DBReadDate(rDataReader, "PlannedDeliverDate")
            .ProductTypeID = DBReadInteger(rDataReader, "ProductTypeID")
            .UnitPrice = DBReadDecimal(rDataReader, "UnitPrice")
            .WorkOrderWoodType = DBReadInt32(rDataReader, "WorkOrderWoodType")
          End With
        Case Else
          With pWorkOrderInfo.WorkOrder
            .SalesOrderItemWOIndex = DBReadInteger(rDataReader, "SalesOrderItemWOIndex")
          End With
      End Select

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
      Case eMode.WorkOrderInfo, eMode.WorkOrderInfoInternal
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
