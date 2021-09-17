
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB

Public Class dtoWorkOrderAllocationInfo : Inherits dtoBase
  Private pWorkOrderAllocationInfo As clsWorkOrderAllocationInfo
  Private pMode As eMode

  Public Enum eMode
    WorkOrderAllocationInfo = 1
  End Enum

  Public Sub New(ByRef rDBSource As clsDBConnBase, ByVal vmode As eMode)
    MyBase.New(rDBSource)
    pMode = vmode
    SetTableDetails()
  End Sub


  Protected Overrides Sub SetTableDetails()
    Select Case pMode
      Case eMode.WorkOrderAllocationInfo
        pTableName = "vwWorkOrderAllocationInfo"
        pKeyFieldName = "WorkOrderAllocationID"
    End Select
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
  End Sub

  Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pWorkOrderAllocationInfo.WorkOrderAllocation.WorkOrderAllocationID
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
      If pWorkOrderAllocationInfo Is Nothing Then SetObjectToNew()


      Select Case pMode
        Case eMode.WorkOrderAllocationInfo

          With pWorkOrderAllocationInfo.WorkOrderAllocation
            .WorkOrderAllocationID = DBReadInt32(rDataReader, "WorkOrderAllocationID")
            .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
            .QuantityRequired = DBReadInt32(rDataReader, "QuantityRequired")
            .QuantityDone = DBReadInt32(rDataReader, "QuantityDone")
            .SalesOrderPhaseItemID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")

          End With

          With pWorkOrderAllocationInfo.WorkOrder
            .WorkOrderID = DBReadInt32(rDataReader, "WorkOrderID")
            .Description = DBReadString(rDataReader, "Description")
            .WorkOrderNo = DBReadString(rDataReader, "WorkOrderNo")
            .ProductID = DBReadInt32(rDataReader, "ProductID")
            .PlannedStartDate = DBReadDate(rDataReader, "PlannedStartDate")
            .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
            .DateCreated = DBReadDate(rDataReader, "DateCreated")
            .Comments = DBReadString(rDataReader, "Comments")
            .PurchasingDate = DBReadDate(rDataReader, "PurchasingDate")
          End With

          With pWorkOrderAllocationInfo.SalesOrderPhaseItem
            .SalesOrderPhaseItemID = DBReadInt32(rDataReader, "SalesOrderPhaseItemID")
          End With

          With pWorkOrderAllocationInfo.SalesOrderItem
            .SalesOrderItemID = DBReadInt32(rDataReader, "SalesOrderItemID")
            .ItemNumber = DBReadString(rDataReader, "ItemNumber")
          End With

          With pWorkOrderAllocationInfo.SalesOrder
            .SalesOrderID = DBReadInt32(rDataReader, "SalesOrderID")
            .OrderNo = DBReadString(rDataReader, "OrderNo")
            .ProjectName = DBReadString(rDataReader, "ProjectName")
          End With

          With pWorkOrderAllocationInfo.Customer
            .CustomerID = DBReadInt32(rDataReader, "CustomerID")
            .CompanyName = DBReadString(rDataReader, "CompanyName")
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
      Case eMode.WorkOrderAllocationInfo
        pWorkOrderAllocationInfo = New clsWorkOrderAllocationInfo
    End Select
    Return pWorkOrderAllocationInfo

  End Function



  Public Function LoadWorkOrderAllocationInfoCollectionByWhere(ByRef rWorkOrderAllocationInfos As colWorkOrderAllocationInfos, ByVal vWhere As String) As Boolean
    Dim mParams As New Hashtable
    Dim mOK As Boolean
    '    mParams.Add("@SupplierID", vWhere)
    mOK = MyBase.LoadCollection(rWorkOrderAllocationInfos, mParams, "WorkOrderAllocationID", vWhere)
    '  If mOK Then rPurchaseInvoiceTranCodeInfos.IsDirty = False
    Return mOK
  End Function


End Class
