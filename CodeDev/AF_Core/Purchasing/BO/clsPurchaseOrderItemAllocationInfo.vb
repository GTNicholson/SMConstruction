Imports RTIS.CommonVB

Public Class clsPurchaseOrderItemAllocationInfo
  Private pStockItem As dmStockItem
  Private pPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation
  Private pPurchaseOrderItem As dmPurchaseOrderItem
  Private pPurchaseOrder As dmPurchaseOrder
  Private pCompanyName As String
  Private pPONum As String
  Private pRequiredDates As Date
  Private pPurchaseOrderID As Int32
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrder As dmSalesOrder
  Public Sub New()
    MyBase.New()
    pStockItem = New dmStockItem
    pPurchaseOrderItem = New dmPurchaseOrderItem
    pPurchaseOrderItemAllocation = New dmPurchaseOrderItemAllocation
    pPurchaseOrder = New dmPurchaseOrder
    pWorkOrder = New dmWorkOrder
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrder = New dmSalesOrder
  End Sub

  Public Sub New(ByRef rPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation)
    pPurchaseOrderItemAllocation = rPurchaseOrderItemAllocation
    pPurchaseOrderItem = New dmPurchaseOrderItem
    pStockItem = New dmStockItem
    pPurchaseOrder = New dmPurchaseOrder
    pWorkOrder = New dmWorkOrder
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrder = New dmSalesOrder
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Property PurchaseOrder() As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(ByVal value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property
  Public Property StockItem() As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(ByVal value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public ReadOnly Property QtyOS As Decimal
    Get
      Return OutStandingQty
    End Get
  End Property

  Public Property WorkOrder() As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(ByVal value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property SalesOrderPhase() As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(ByVal value As dmSalesOrderPhase)
      pSalesOrderPhase = value
    End Set
  End Property

  Public Property PurchaseOrderItem() As dmPurchaseOrderItem
    Get
      Return pPurchaseOrderItem
    End Get
    Set(ByVal value As dmPurchaseOrderItem)
      pPurchaseOrderItem = value
    End Set
  End Property


  Public Property PurchaseOrderItemAllocation() As dmPurchaseOrderItemAllocation
    Get
      Return pPurchaseOrderItemAllocation
    End Get
    Set(ByVal value As dmPurchaseOrderItemAllocation)
      pPurchaseOrderItemAllocation = value
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

  Public ReadOnly Property StockItemID() As Integer
    Get
      Return pStockItem.StockItemID
    End Get

  End Property

  Public ReadOnly Property StockCode() As String
    Get
      Return pStockItem.StockCode
    End Get

  End Property

  Public Property JobNo() As String
    Get
      Return pSalesOrderPhase.JobNo
    End Get
    Set(value As String)
      pSalesOrderPhase.JobNo = value
    End Set

  End Property



  Public Property PONum() As String
    Get
      Return pPONum
    End Get
    Set(value As String)
      pPONum = value
    End Set

  End Property

  Public Property PurchaseOrderID() As Int32
    Get
      Return pPurchaseOrderID
    End Get
    Set(value As Int32)
      pPurchaseOrderID = value
    End Set

  End Property

  Public Property POStatus() As Byte
    Get
      Return pPurchaseOrder.Status
    End Get
    Set(value As Byte)
      pPurchaseOrder.Status = value
    End Set

  End Property

  Public ReadOnly Property POStatusDesc() As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePurchaseOrderDueDateStatus), CType(pPurchaseOrder.Status, ePurchaseOrderDueDateStatus))
    End Get

  End Property
  Public Property RequiredDate() As Date
    Get
      Return pRequiredDates
    End Get
    Set(value As Date)
      pRequiredDates = value
    End Set

  End Property

  Public ReadOnly Property ItemRef As String
    Get
      Return pPurchaseOrderItemAllocation.ItemRef
    End Get
  End Property


  Public ReadOnly Property ReplacementQty As Decimal
    Get
      Return pPurchaseOrderItemAllocation.ReplacementQty
    End Get
  End Property


  Public Property SUPPLIERCOMPANYNAME() As String
    Get
      Return pCompanyName
    End Get
    Set(value As String)
      pCompanyName = value
    End Set

  End Property


  Public ReadOnly Property STOCKDESCRIPTION() As String
    Get
      If Not String.IsNullOrEmpty(pStockItem.Description) Then
        Return pStockItem.Description
      Else
        Return pPurchaseOrderItem.Description
      End If
    End Get

  End Property

  Public ReadOnly Property StockCategory() As String
    Get
      Return pStockItem.Category
    End Get

  End Property

  Public ReadOnly Property UoMDescription() As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(pPurchaseOrderItem.UoM, eUoM))
    End Get

  End Property

  Public ReadOnly Property StockCategoryDesc() As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pStockItem.Category, eStockItemCategory))
    End Get

  End Property


  Public ReadOnly Property PurchaseOrderItemAllocationID() As Integer
    Get
      Return pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID
    End Get

  End Property

  Public ReadOnly Property Quantity() As Decimal
    Get
      Return pPurchaseOrderItemAllocation.Quantity
    End Get

  End Property

  Public ReadOnly Property ReceivedQty() As Decimal
    Get
      Return pPurchaseOrderItemAllocation.ReceivedQty
    End Get

  End Property


  Public ReadOnly Property PurchaseOrderItemID() As Int32
    Get
      Return pPurchaseOrderItem.PurchaseOrderItemID
    End Get

  End Property


  Public ReadOnly Property Status() As Byte
    Get
      Return pPurchaseOrderItem.Status
    End Get

  End Property

  Public ReadOnly Property Description() As String
    Get
      Return pPurchaseOrderItem.Description
    End Get

  End Property

  Public ReadOnly Property UnitPrice() As Decimal
    Get
      Return pPurchaseOrderItem.UnitPrice
    End Get

  End Property

  Public ReadOnly Property QtyRequired() As Decimal
    Get
      Return pPurchaseOrderItem.QtyRequired
    End Get

  End Property

  Public ReadOnly Property Lenght() As Decimal
    Get
      Return pPurchaseOrderItem.Length
    End Get

  End Property

  Public ReadOnly Property Width() As Decimal
    Get
      Return pPurchaseOrderItem.Width
    End Get

  End Property

  Public ReadOnly Property Thickness() As Decimal
    Get
      Return pPurchaseOrderItem.Thickness
    End Get

  End Property


  Public ReadOnly Property OutStandingQty() As Decimal
    Get
      Return pPurchaseOrderItem.QtyRequired - pPurchaseOrderItemAllocation.ReceivedQty
    End Get

  End Property


  Public ReadOnly Property SubmissionDate As Date
    Get
      Return pPurchaseOrder.SubmissionDate
    End Get
  End Property


  Public ReadOnly Property WODESCRIPTION As String
    Get
      Return pWorkOrder.WorkOrderNo & ": " & pWorkOrder.Description
    End Get
  End Property

  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property
  Public ReadOnly Property WorkOrderNo() As String
    Get
      Return pWorkOrder.WorkOrderNo
    End Get

  End Property

  Public ReadOnly Property ReceivedValue() As Decimal
    Get
      Return UnitPrice * ReceivedQty
    End Get

  End Property



End Class



Public Class colPurchaseOrderItemAllocationInfo : Inherits List(Of clsPurchaseOrderItemAllocationInfo)

End Class