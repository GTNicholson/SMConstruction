Imports RTIS.CommonVB

Public Class clsStockItemTransactionLogInfo
  Private pCurrentStockItem As dmStockItem
  Private pWorkOrder As dmWorkOrder
  Private pMaterialRequirement As dmMaterialRequirement
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer

  Private pStockItemTransactionLogID As Integer
  Private pPONum As String
  Private pReferenceNo As String
  Private pAreaDescription As String
  Private pWorkOrderNo As String
  Private pWODescription As String
  Private pSupplierName As String
  Private pGRNumber As String
  Private pTransQty As Decimal
  Private pPrevValue As Decimal
  Private pNewValue As Decimal
  Private pTransType As eTransactionType
  Private pTransDate As DateTime
  Private pIsManagedStock As Boolean
  Private pRefObjectType As eObjectType
  Private pRefObjectID As Integer
  Private pSalesOrderNo As String
  Private pSalesOrderPhaseID As Integer
  Private pSalesOrderPhaseNo As Integer
  Private pInternalOrderNo As String
  Private pProductionBatchNo As Integer
  Private pCustomerName As String
  Private pChangeDetails As String
  Private pUserName As String
  Private pTransactionValuation As Decimal
  Private pStockValuation As Decimal
  Private pStockTakeDesc As String
  Private pStockCheckDesc As String
  Private pTransactionValuationDollar As Decimal

  Private pTotalValue As Decimal
  Private pExchangeRate As Decimal

  Private pPalletRef As String
  Private pPalletOutsideRef As String
  Private pLocationID As Byte
  Public Sub New()
    MyBase.New()
    pCurrentStockItem = New dmStockItem
    pWorkOrder = New dmWorkOrder
    pMaterialRequirement = New dmMaterialRequirement
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Property CurrentStockItem() As dmStockItem
    Get
      Return pCurrentStockItem
    End Get
    Set(ByVal value As dmStockItem)
      pCurrentStockItem = value
    End Set
  End Property



  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(ByVal value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property MaterialRequirement As dmMaterialRequirement
    Get
      Return pMaterialRequirement
    End Get
    Set(ByVal value As dmMaterialRequirement)
      pMaterialRequirement = value
    End Set
  End Property

  Public ReadOnly Property WorkOrderNo As String
    Get
      Return pWorkOrder.WorkOrderNo
    End Get
  End Property

  Public ReadOnly Property WODESCRIPTION As String
    Get
      Return pWorkOrder.Description
    End Get
  End Property

  Public Property PalletRef As String
    Get
      Return pPalletRef
    End Get
    Set(value As String)
      pPalletRef = value
    End Set
  End Property

  Public Property LocationID As Byte
    Get
      Return pLocationID
    End Get
    Set(value As Byte)
      pLocationID = value
    End Set
  End Property
  Public Property PalletOutsideRef As String
    Get
      Return pPalletOutsideRef
    End Get
    Set(value As String)
      pPalletOutsideRef = value
    End Set
  End Property

  Public ReadOnly Property AverageCost As Decimal
    Get
      Dim mRetVal As Decimal = 0

      If TransQuantity > 0 Then

        mRetVal = pTransactionValuationDollar / TransQuantity
      End If

      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property TotalValue As Decimal
    Get
      Dim mRetVal As Decimal
      If pCurrentStockItem IsNot Nothing Then
        mRetVal = clsStockItemSharedFuncs.getStockItemValue(pCurrentStockItem, TransQuantity)
      End If
      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property StockCategoryDesc As String
    Get
      Dim mRetVal As String
      mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pCurrentStockItem.Category, eStockItemCategory))
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property AreaDescription As String
    Get
      Dim mRetVal As String
      mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eWorkCentre), CType(pMaterialRequirement.AreaID, eWorkCentre))
      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property StockItemTypeDesc As String
    Get
      Dim mRetVal As String = ""
      Select Case pCurrentStockItem.Category
        Case eStockItemCategory.Abrasivos
          mRetVal = eStockItemTypeAbrasivos.GetInstance.DisplayValueFromKey(pCurrentStockItem.ItemType)
      End Select
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property StockCode As String
    Get
      Return pCurrentStockItem.StockCode
    End Get
  End Property

  Public ReadOnly Property StockDesc As String
    Get
      Return pCurrentStockItem.Description
    End Get
  End Property

  Public Property ExchangeRate As Decimal
    Get
      Return pExchangeRate
    End Get
    Set(value As Decimal)
      pExchangeRate = value
    End Set
  End Property
  Public Property TransactionValuationDollar As Decimal
    Get

      Return pTransactionValuationDollar
    End Get
    Set(value As Decimal)
      pTransactionValuationDollar = value
    End Set
  End Property

  Public ReadOnly Property StdCost As Decimal
    Get
      Return pCurrentStockItem.StdCost
    End Get
  End Property

  Public ReadOnly Property TotalStdTransaction As Decimal
    Get
      Return pCurrentStockItem.StdCost * pTransQty
    End Get
  End Property

  Public Property StockItemTransactionLogID As Integer
    Get
      Return pStockItemTransactionLogID
    End Get
    Set(value As Integer)
      pStockItemTransactionLogID = value
    End Set
  End Property

  Public Property TransQuantity As Decimal
    Get
      Return pTransQty
    End Get
    Set(value As Decimal)
      pTransQty = value
    End Set
  End Property

  Public Property PrevValue As Decimal
    Get
      Return pPrevValue
    End Get
    Set(value As Decimal)
      pPrevValue = value
    End Set
  End Property

  Public Property NewValue As Decimal
    Get
      Return pNewValue
    End Get
    Set(value As Decimal)
      pNewValue = value
    End Set
  End Property

  Public Property TransactionValuation As Decimal
    Get
      Return pTransactionValuation
    End Get
    Set(value As Decimal)
      pTransactionValuation = value
    End Set
  End Property

  Public Property StockValuation As Decimal
    Get
      Return pStockValuation
    End Get
    Set(value As Decimal)
      pStockValuation = value
    End Set
  End Property

  Public ReadOnly Property StockQtyChange As Decimal
    Get
      Return pNewValue - pPrevValue
    End Get
  End Property

  Public Property PONum As String
    Get
      Return pPONum
    End Get
    Set(value As String)
      pPONum = value
    End Set
  End Property

  Public Property SupplierName As String
    Get
      Return pSupplierName
    End Get
    Set(value As String)
      pSupplierName = value
    End Set
  End Property

  Public Property GRNumber As String
    Get
      Return pGRNumber
    End Get
    Set(value As String)
      pGRNumber = value
    End Set
  End Property

  Public Property SalesOrderNo As String
    Get
      Return pSalesOrderNo
    End Get
    Set(value As String)
      pSalesOrderNo = value
    End Set
  End Property

  Public Property SalesOrderPhaseID As Integer
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(value As Integer)
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property ReferenceNo As String
    Get
      Return pReferenceNo
    End Get
    Set(value As String)
      pReferenceNo = value
    End Set
  End Property

  Public Property SalesOrderPhaseNo As Integer
    Get
      Return pSalesOrderPhaseNo
    End Get
    Set(value As Integer)
      pSalesOrderPhaseNo = value
    End Set
  End Property

  Public Property InternalOrderNo As String
    Get
      Return pInternalOrderNo
    End Get
    Set(value As String)
      pInternalOrderNo = value
    End Set
  End Property

  Public Property ProductionBatchNo As Integer
    Get
      Return pProductionBatchNo
    End Get
    Set(value As Integer)
      pProductionBatchNo = value
    End Set
  End Property

  Public Property CustomerName As String
    Get
      Return pCustomerName
    End Get
    Set(value As String)
      pCustomerName = value
    End Set
  End Property


  Public Property ChangeDetails As String
    Get
      Return pChangeDetails
    End Get
    Set(value As String)
      pChangeDetails = value
    End Set
  End Property

  Public Property UserName As String
    Get
      Return pUserName
    End Get
    Set(value As String)
      pUserName = value
    End Set
  End Property


  Public Property TransType As eTransactionType
    Get
      Return pTransType
    End Get
    Set(value As eTransactionType)
      pTransType = value
    End Set
  End Property

  Public Property TransTime As DateTime
    Get
      Return pTransDate
    End Get
    Set(value As DateTime)
      pTransDate = value
    End Set
  End Property

  Public Property TransDate As DateTime
    Get
      Return pTransDate
    End Get
    Set(value As DateTime)
      pTransDate = value
    End Set
  End Property

  Public ReadOnly Property TransDateWC As DateTime
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pTransDate)
    End Get
  End Property

  Public ReadOnly Property TransDateMC As DateTime
    Get
      Return New Date(Year(pTransDate), Month(pTransDate), 1)
    End Get
  End Property


  Public Property StockTakeDesc As String
    Get
      Return pStockCheckDesc
    End Get
    Set(value As String)
      pStockCheckDesc = value
    End Set
  End Property

  Public Property RefObjectType As eObjectType
    Get
      Return pRefObjectType
    End Get
    Set(value As eObjectType)
      pRefObjectType = value
    End Set
  End Property

  Public Property RefObjectID As Integer
    Get
      Return pRefObjectID
    End Get
    Set(value As Integer)
      pRefObjectID = value
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

  Public ReadOnly Property RefInfo1 As String
    Get
      Dim mRetVal As String = ""
      Select Case pRefObjectType
        Case eObjectType.StockTake
          mRetVal = pStockTakeDesc
        Case eObjectType.MaterialRequirement
          mRetVal = pWorkOrder.WorkOrderNo
        Case eObjectType.PODeliveryItem
          mRetVal = "" ''GRN Number
        Case eObjectType.WoodPallet
          mRetVal = PalletRef

        Case eObjectType.WorkOrder
          mRetVal = pWorkOrder.Description


      End Select
      Return mRetVal
    End Get
  End Property

  Public Property LocationDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eLocations), CType(pLocationID, eLocations))
    End Get
    Set(value As String)

    End Set
  End Property
  Public ReadOnly Property RefInfo2 As String
    Get
      Dim mRetVal As String = ""
      Select Case pRefObjectType

        Case eObjectType.MaterialRequirement
          mRetVal = pSalesOrder.ProjectName
        Case eObjectType.PODeliveryItem
          mRetVal = "" ''PO Num
        Case eObjectType.WoodPallet
          mRetVal = clsEnumsConstants.GetEnumDescription(GetType(eLocations), CType(LocationID, eLocations))


      End Select
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property RefInfo3 As String
    Get
      Dim mRetVal As String = ""
      Select Case pRefObjectType

        Case eObjectType.MaterialRequirement
          mRetVal = pCustomer.CompanyName

        Case eObjectType.PODeliveryItem
          mRetVal = "" ''Supplier
      End Select
      Return mRetVal
    End Get
  End Property

End Class

Public Class colStockItemTransactionLogInfos : Inherits List(Of clsStockItemTransactionLogInfo)

End Class