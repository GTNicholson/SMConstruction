Imports RTIS.CommonVB

Public Class clsWorkOrderAllocationInfo
  Private pWorkOrderAllocation As dmWorkOrderAllocation
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderPhaseItem As dmSalesOrderPhaseItem
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrderItem As dmSalesOrderItem

  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer
  Private pPurchaseOrderItemID As Integer
  Public Property TempPurchaseOrderItemID As Integer
    Get
      Return pPurchaseOrderItemID
    End Get
    Set(value As Integer)
      pPurchaseOrderItemID = value
    End Set
  End Property
  Public Sub New()
    pWorkOrderAllocation = New dmWorkOrderAllocation
    pWorkOrder = New dmWorkOrder
    pSalesOrderPhaseItem = New dmSalesOrderPhaseItem
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrderItem = New dmSalesOrderItem

    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
  End Sub

  Public Property WorkOrderAllocation As dmWorkOrderAllocation
    Get
      Return pWorkOrderAllocation
    End Get
    Set(value As dmWorkOrderAllocation)
      pWorkOrderAllocation = value
    End Set
  End Property

  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property SalesOrderPhaseItem As dmSalesOrderPhaseItem
    Get
      Return pSalesOrderPhaseItem
    End Get
    Set(value As dmSalesOrderPhaseItem)
      pSalesOrderPhaseItem = value
    End Set
  End Property

  Public Property SalesOrderPhase As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(value As dmSalesOrderPhase)
      pSalesOrderPhase = value
    End Set
  End Property
  Public Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
    Set(value As dmSalesOrderItem)
      pSalesOrderItem = value
    End Set
  End Property
  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
    Set(value As dmCustomer)
      pCustomer = value
    End Set
  End Property

  Public ReadOnly Property WorkOrderAllocationID As Integer
    Get
      Return pWorkOrderAllocation.WorkOrderAllocationID
    End Get
  End Property
  Public ReadOnly Property QuantityRequired As Integer
    Get
      Return pWorkOrderAllocation.QuantityRequired
    End Get
  End Property

  Public ReadOnly Property QuantityDone As Integer
    Get
      Return pWorkOrderAllocation.QuantityDone
    End Get
  End Property

  Public ReadOnly Property WorkOrderID As Integer
    Get
      Return pWorkOrderAllocation.WorkOrderID
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pWorkOrder.Description
    End Get
  End Property

  Public ReadOnly Property PurchasingDate As Date
    Get
      Return pWorkOrder.PurchasingDate
    End Get
  End Property

  Public ReadOnly Property WorkOrderNo As String
    Get
      Return pWorkOrder.WorkOrderNo
    End Get
  End Property

  Public ReadOnly Property ProductID As Integer
    Get
      Return pWorkOrder.ProductID
    End Get
  End Property


  Public ReadOnly Property PlannedStartDate As Date
    Get
      Return pWorkOrder.PlannedStartDate
    End Get

  End Property

  Public ReadOnly Property PlannedStartDateWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pWorkOrder.PlannedStartDate)
    End Get
  End Property

  Public ReadOnly Property DateCreated As Date
    Get
      Return pWorkOrder.DateCreated
    End Get

  End Property

  Public ReadOnly Property Comments As String
    Get
      Return pWorkOrder.Comments
    End Get

  End Property


  Public ReadOnly Property ItemNumber As String
    Get
      Return pSalesOrderItem.ItemNumber
    End Get
  End Property


  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property
  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get

  End Property


  Public ReadOnly Property CustomerID As String
    Get
      Return pCustomer.CustomerID
    End Get

  End Property

  Public ReadOnly Property ProjectNameAndCustomer As String
    Get
      Return ProjectName & "-" & CompanyName
    End Get
  End Property
End Class


Public Class colWorkOrderAllocationInfos : Inherits List(Of clsWorkOrderAllocationInfo)

  Public Function IndexFromWorkOrderAllocationID(ByVal vWorkOrderAllocationID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mWO As clsWorkOrderAllocationInfo In Me
      mIndex += 1
      If mWO.WorkOrderAllocation.WorkOrderAllocationID = vWorkOrderAllocationID Then
        mRetVal = mIndex
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromWorkOrderAllocationID(ByVal vWorkOrderAllocationID As Integer) As clsWorkOrderAllocationInfo
    Dim mRetVal As clsWorkOrderAllocationInfo = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromWorkOrderAllocationID(vWorkOrderAllocationID)
    If mIndex <> -1 Then
      mRetVal = Me(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function ItemFromWorkOrderIDAndSalesOrderPhaseItemID(ByVal vWorkOrderID As Integer, ByVal vSalesOrderPhaseItemID As Integer) As clsWorkOrderAllocationInfo
    Dim mRetVal As clsWorkOrderAllocationInfo = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromWorkOrderIDAndSalesOrderPhaseItemID(vWorkOrderID, vSalesOrderPhaseItemID)
    If mIndex <> -1 Then
      mRetVal = Me(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromWorkOrderIDAndSalesOrderPhaseItemID(ByVal vWorkOrderID As Integer, ByVal vSalesorderPhaseItemID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mWO As clsWorkOrderAllocationInfo In Me
      mIndex += 1
      If mWO.WorkOrderAllocation.WorkOrderID = vWorkOrderID And mWO.WorkOrderAllocation.SalesOrderPhaseItemID = vSalesorderPhaseItemID Then
        mRetVal = mIndex
      End If
    Next
    Return mRetVal

  End Function
  Public Function ItemFromTempPurchaseOrderItemID(ByVal vPurchaseOrderItemID As Integer) As clsWorkOrderAllocationInfo
    Dim mRetVal As clsWorkOrderAllocationInfo = Nothing

    For Each mWO As clsWorkOrderAllocationInfo In Me

      If mWO.TempPurchaseOrderItemID = vPurchaseOrderItemID Then
        mRetVal = mWO
      End If

    Next

    Return mRetVal
  End Function
  Public Function ItemFromWorkOrderID(ByVal vWorkOrderID As Integer) As clsWorkOrderAllocationInfo
    Dim mRetVal As clsWorkOrderAllocationInfo = Nothing

    For Each mWO As clsWorkOrderAllocationInfo In Me

      If mWO.WorkOrder.WorkOrderID = vWorkOrderID Then
        mRetVal = mWO
      End If

    Next

    Return mRetVal
  End Function
End Class