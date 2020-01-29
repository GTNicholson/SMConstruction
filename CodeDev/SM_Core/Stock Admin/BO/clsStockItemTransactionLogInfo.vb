Imports RTIS.CommonVB

Public Class clsStockItemTransactionLogInfo
  Private pCurrentStockItem As dmStockItem

  Private pStockItemTransactionLogID As Integer
  Private pPONum As String
  Private pReferenceNo As String
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


  Public Sub New()
    MyBase.New()
    pCurrentStockItem = New dmStockItem
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

  Public ReadOnly Property StockCategoryDesc As String
    Get
      Dim mRetVal As String
      mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pCurrentStockItem.Category, eStockItemCategory))
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

  Public ReadOnly Property StdCost As Decimal
    Get
      Return pCurrentStockItem.StdCost
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

  Public ReadOnly Property RefInfo1 As String
    Get
      Dim mRetVal As String = ""
      Select Case pRefObjectType
        Case eObjectType.StockTake
          mRetVal = pStockTakeDesc
      End Select
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property RefInfo2 As String
    Get
      Dim mRetVal As String = ""
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property RefInfo3 As String
    Get
      Dim mRetVal As String = ""
      Return mRetVal
    End Get
  End Property


End Class

Public Class colStockItemTransactionLogInfos : Inherits List(Of clsStockItemTransactionLogInfo)

End Class