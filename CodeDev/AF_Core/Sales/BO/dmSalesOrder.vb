''Class Definition - SalesOrder (to SalesOrder)'Generated from Table:SalesOrder
Imports RTIS.CommonVB

Public Class dmSalesOrder : Inherits dmBase
  Private pSalesOrderID As Int32
  Private pCustomerID As Int32
  Private pCustomerContactID As Int32
  Private pProjectName As String
  Private pEstimatorEmployeeID As Int32
  Private pOrderTypeID As Int32
  Private pOrderStatusENUM As Int32
  Private pOrderNo As String
  Private pDateEntered As DateTime
  Private pInternalComments As String
  Private pVisibleNotes As String
  Private pCustomerRef As String
  Private pContractManagerID As Int32
  Private pSalesAreaID As Int32
  Private pDelAddress1 As String
  Private pDelAddress2 As String
  Private pHostCompanyID As Int32
  Private pBusinessSectorID As Int32
  Private pClientInfo As String
  Private pFinishDate As DateTime
  Private pDueTime As DateTime
  Private pSalesDelAreaID As Int32
  Private pCustomerDelContactID As Int32
  Private pShippingCost As Decimal
  Private pWorkOrdersIssued As Boolean
  Private pPodioPath As String



  Private pVersion As String
  Private pOrderPhaseType As eOrderPhaseType

  Private pCustomer As dmCustomer
  Private pInvoices As colInvoices
  Private pCustomerPurchaseOrder As colCustomerPurchaseOrders
  Private pPaymentAccounts As colPaymentOnAccounts
  Private pSalesOrderItems As colSalesOrderItems


  Private pOutputDocuments As colOutputDocuments
  Private pSOFiles As colFileTrackers

  Private pSalesOrderPhasess As colSalesOrderPhases
  Private pSalesOrderStages As colSalesOrderStages

  Private pSalesOrderHouses As colSalesOrderHouses
  Private pSalesItemAssemblys As colSalesItemAssemblys

  Private pProductCostBookID As Int32
  Private pPaymentTermDesc As String

  Private pWoodPalletID As Integer
  Private pWoodPalletType As Integer
  Private pIsDepatch As Boolean

  Private pCIFValue As Decimal
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    ''pWorkOrders = New colWorkOrders
    pSalesOrderItems = New colSalesOrderItems
    pOutputDocuments = New colOutputDocuments
    pCustomer = New dmCustomer
    pInvoices = New colInvoices
    pPaymentAccounts = New colPaymentOnAccounts
    pCustomerPurchaseOrder = New colCustomerPurchaseOrders
    pSalesOrderPhasess = New colSalesOrderPhases
    pSalesOrderStages = New colSalesOrderStages
    pSalesItemAssemblys = New colSalesItemAssemblys
    pSalesOrderHouses = New colSalesOrderHouses
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pSalesOrderPhasess = Nothing
    pSalesOrderStages = Nothing
    pPaymentAccounts = Nothing
    MyBase.Finalize()
  End Sub



  Public Property SalesOrderStages As colSalesOrderStages
    Get
      Return pSalesOrderStages
    End Get
    Set(value As colSalesOrderStages)
      pSalesOrderStages = value
    End Set
  End Property

  Public Property SOFiles As colFileTrackers
    Get
      Return pSOFiles
    End Get
    Set(value As colFileTrackers)
      pSOFiles = value
    End Set
  End Property


  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pSalesOrderItems.IsDirty
      If mAnyDirty = False Then mAnyDirty = pOutputDocuments.IsDirty



      If mAnyDirty = False Then mAnyDirty = pInvoices.IsDirty


      If mAnyDirty = False Then mAnyDirty = pCustomerPurchaseOrder.IsDirty

      If mAnyDirty = False Then mAnyDirty = pSalesOrderPhasess.IsDirty

      If mAnyDirty = False Then mAnyDirty = pSalesOrderStages.IsDirty

      If mAnyDirty = False Then mAnyDirty = pSalesOrderHouses.IsDirty

      If mAnyDirty = False Then mAnyDirty = pSalesItemAssemblys.IsDirty

      If mAnyDirty = False Then mAnyDirty = pPaymentAccounts.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    SalesOrderID = 0
    pSalesItemAssemblys = Nothing
    pSalesOrderHouses = Nothing
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrder)
      .SalesOrderID = SalesOrderID
      .CustomerID = CustomerID
      .CustomerContactID = CustomerContactID
      .ProjectName = ProjectName
      .EstimatorEmployeeID = EstimatorEmployeeID
      .OrderTypeID = OrderTypeID
      .OrderStatusENUM = OrderStatusENUM
      .OrderNo = OrderNo
      .DateEntered = DateEntered
      .InternalComments = InternalComments
      .VisibleNotes = VisibleNotes
      .CustomerRef = CustomerRef
      .ContractManagerID = ContractManagerID
      .SalesAreaID = SalesAreaID
      .DelAddress1 = DelAddress1
      .DelAddress2 = DelAddress2
      .HostCompanyID = HostCompanyID
      .BusinessSectorID = BusinessSectorID
      .ClientInfo = ClientInfo
      .FinishDate = FinishDate
      .DueTime = DueTime
      .SalesDelAreaID = SalesDelAreaID
      .CustomerDelContactID = CustomerDelContactID
      .ShippingCost = ShippingCost
      .WorkOrdersIssued = WorkOrdersIssued
      .PodioPath = PodioPath
      .Version = Version
      .OrderPhaseType = OrderPhaseType
      .ProductCostBookID = ProductCostBookID
      .SalesOrderStages = SalesOrderStages
      .PaymentTermDesc = PaymentTermDesc
      .WoodPalletID = WoodPalletID
      .IsDepatch = IsDepatch
      .CIFValue = CIFValue
      'Add entries here for each collection and class property

      'Entries for object management
      ''.WorkOrders = WorkOrders.Clone
      .Customer = Customer.Clone
      .SalesOrderItems = SalesOrderItems.Clone
      .Invoices = Invoices.Clone
      .CustomerPurchaseOrder = CustomerPurchaseOrder.Clone
      .SalesOrderPhases = SalesOrderPhases.Clone
      .SalesOrderHouses = SalesOrderHouses.Clone
      .SalesItemAssemblys = SalesItemAssemblys.Clone
      .PaymentAccounts = PaymentAccounts.Clone

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesItemAssemblys As colSalesItemAssemblys
    Get
      Return pSalesItemAssemblys
    End Get
    Set(value As colSalesItemAssemblys)
      pSalesItemAssemblys = value
    End Set
  End Property

  Public Property SalesOrderHouses As colSalesOrderHouses
    Get
      Return pSalesOrderHouses
    End Get
    Set(value As colSalesOrderHouses)
      pSalesOrderHouses = value
    End Set
  End Property

  Public Property Version() As String
    Get
      Return pVersion
    End Get
    Set(ByVal value As String)
      If pVersion <> value Then IsDirty = True
      pVersion = value
    End Set
  End Property

  Public Property OrderPhaseType() As eOrderPhaseType
    Get
      Return pOrderPhaseType
    End Get
    Set(ByVal value As eOrderPhaseType)
      If pOrderPhaseType <> value Then IsDirty = True
      pOrderPhaseType = value
    End Set
  End Property


  Public Property ProductCostBookID() As Int32
    Get
      Return pProductCostBookID
    End Get
    Set(ByVal value As Int32)
      If pProductCostBookID <> value Then IsDirty = True
      pProductCostBookID = value
    End Set
  End Property


  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
    End Set
  End Property

  Public Property PodioPath() As String
    Get
      Return pPodioPath
    End Get
    Set(ByVal value As String)
      If pPodioPath <> value Then IsDirty = True
      pPodioPath = value
    End Set
  End Property

  Public Property WorkOrdersIssued() As Boolean
    Get
      Return pWorkOrdersIssued
    End Get
    Set(ByVal value As Boolean)
      If pWorkOrdersIssued <> value Then IsDirty = True
      pWorkOrdersIssued = value
    End Set
  End Property

  Public Property CustomerID() As Int32
    Get
      Return pCustomerID
    End Get
    Set(ByVal value As Int32)
      If pCustomerID <> value Then IsDirty = True
      pCustomerID = value
    End Set
  End Property

  Public Property ShippingCost() As Decimal
    Get
      Return pShippingCost
    End Get
    Set(ByVal value As Decimal)
      If pShippingCost <> value Then IsDirty = True
      pShippingCost = value
    End Set
  End Property

  Public Property SalesDelAreaID() As Int32
    Get
      Return pSalesDelAreaID
    End Get
    Set(ByVal value As Int32)
      If pSalesDelAreaID <> value Then IsDirty = True
      pSalesDelAreaID = value
    End Set
  End Property

  Public Property CustomerContactID() As Int32
    Get
      Return pCustomerContactID
    End Get
    Set(ByVal value As Int32)
      If pCustomerContactID <> value Then IsDirty = True
      pCustomerContactID = value
    End Set
  End Property

  Public Property CustomerDelContactID() As Int32
    Get
      Return pCustomerDelContactID
    End Get
    Set(ByVal value As Int32)
      If pCustomerDelContactID <> value Then IsDirty = True
      pCustomerDelContactID = value
    End Set
  End Property

  Public Property ProjectName() As String
    Get
      Return pProjectName
    End Get
    Set(ByVal value As String)
      If pProjectName <> value Then IsDirty = True
      pProjectName = value
    End Set
  End Property

  Public Property EstimatorEmployeeID() As Int32
    Get
      Return pEstimatorEmployeeID
    End Get
    Set(ByVal value As Int32)
      If pEstimatorEmployeeID <> value Then IsDirty = True
      pEstimatorEmployeeID = value
    End Set
  End Property

  Public Property OrderTypeID() As Int32
    Get
      Return pOrderTypeID
    End Get
    Set(ByVal value As Int32)
      If pOrderTypeID <> value Then IsDirty = True
      pOrderTypeID = value
    End Set
  End Property

  Public Property OrderStatusENUM() As Int32
    Get
      Return pOrderStatusENUM
    End Get
    Set(ByVal value As Int32)
      If pOrderStatusENUM <> value Then IsDirty = True
      pOrderStatusENUM = value
    End Set
  End Property

  Public Property OrderNo() As String
    Get
      Return pOrderNo
    End Get
    Set(ByVal value As String)
      If pOrderNo <> value Then IsDirty = True
      pOrderNo = value
    End Set
  End Property

  Public Property DateEntered() As DateTime
    Get
      Return pDateEntered
    End Get
    Set(ByVal value As DateTime)
      If pDateEntered <> value Then IsDirty = True
      pDateEntered = value
    End Set
  End Property

  Public Property InternalComments() As String
    Get
      Return pInternalComments
    End Get
    Set(ByVal value As String)
      If pInternalComments <> value Then IsDirty = True
      pInternalComments = value
    End Set
  End Property

  Public Property VisibleNotes() As String
    Get
      Return pVisibleNotes
    End Get
    Set(ByVal value As String)
      If pVisibleNotes <> value Then IsDirty = True
      pVisibleNotes = value
    End Set
  End Property

  Public Property CustomerRef() As String
    Get
      Return pCustomerRef
    End Get
    Set(ByVal value As String)
      If pCustomerRef <> value Then IsDirty = True
      pCustomerRef = value
    End Set
  End Property

  Public Property ContractManagerID() As Int32
    Get
      Return pContractManagerID
    End Get
    Set(ByVal value As Int32)
      If pContractManagerID <> value Then IsDirty = True
      pContractManagerID = value
    End Set
  End Property

  Public Property SalesAreaID() As Int32
    Get
      Return pSalesAreaID
    End Get
    Set(ByVal value As Int32)
      If pSalesAreaID <> value Then IsDirty = True
      pSalesAreaID = value
    End Set
  End Property

  Public Property DelAddress1() As String
    Get
      Return pDelAddress1
    End Get
    Set(ByVal value As String)
      If pDelAddress1 <> value Then IsDirty = True
      pDelAddress1 = value
    End Set
  End Property

  Public Property DelAddress2() As String
    Get
      Return pDelAddress2
    End Get
    Set(ByVal value As String)
      If pDelAddress2 <> value Then IsDirty = True
      pDelAddress2 = value
    End Set
  End Property

  Public Property HostCompanyID() As Int32
    Get
      Return pHostCompanyID
    End Get
    Set(ByVal value As Int32)
      If pHostCompanyID <> value Then IsDirty = True
      pHostCompanyID = value
    End Set
  End Property

  Public Property BusinessSectorID() As Int32
    Get
      Return pBusinessSectorID
    End Get
    Set(ByVal value As Int32)
      If pBusinessSectorID <> value Then IsDirty = True
      pBusinessSectorID = value
    End Set
  End Property

  Public Property ClientInfo() As String
    Get
      Return pClientInfo
    End Get
    Set(ByVal value As String)
      If pClientInfo <> value Then IsDirty = True
      pClientInfo = value
    End Set
  End Property

  Public Property FinishDate() As DateTime
    Get
      Return pFinishDate
    End Get
    Set(ByVal value As DateTime)
      If pFinishDate <> value Then IsDirty = True
      pFinishDate = value
    End Set
  End Property

  Public Property DueTime() As DateTime
    Get
      Return pDueTime
    End Get
    Set(ByVal value As DateTime)
      If pDueTime <> value Then IsDirty = True
      pDueTime = value
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

  Public Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
    Set(value As String)
      pCustomer.CompanyName = value
    End Set
  End Property

  Public Property PaymentTermDesc As String
    Get
      Return pPaymentTermDesc
    End Get
    Set(value As String)
      If pPaymentTermDesc <> value Then IsDirty = True
      pPaymentTermDesc = value
    End Set
  End Property

  Public Property Invoices As colInvoices
    Get
      Return pInvoices
    End Get
    Set(value As colInvoices)
      pInvoices = value
    End Set
  End Property
  Public Property SalesOrderPhases As colSalesOrderPhases
    Get
      Return pSalesOrderPhasess
    End Get
    Set(value As colSalesOrderPhases)
      pSalesOrderPhasess = value
    End Set
  End Property

  Public Property PaymentAccounts As colPaymentOnAccounts
    Get
      Return pPaymentAccounts
    End Get
    Set(value As colPaymentOnAccounts)
      pPaymentAccounts = value
    End Set
  End Property

  Public Property IsDepatch As Boolean
    Get
      Return pIsDepatch
    End Get
    Set(value As Boolean)
      If pIsDepatch <> value Then IsDirty = True
      pIsDepatch = value
    End Set
  End Property


  ''Public Property WorkOrders As colWorkOrders
  ''  Get
  ''    Return pWorkOrders
  ''  End Get
  ''  Set(value As colWorkOrders)
  ''    pWorkOrders = value
  ''  End Set
  ''End Property

  Public Property SalesOrderItems As colSalesOrderItems
    Get
      Return pSalesOrderItems
    End Get
    Set(value As colSalesOrderItems)
      pSalesOrderItems = value
    End Set
  End Property


  Public Property CustomerPurchaseOrder As colCustomerPurchaseOrders
    Get
      Return pCustomerPurchaseOrder
    End Get
    Set(value As colCustomerPurchaseOrders)
      pCustomerPurchaseOrder = value
    End Set
  End Property


  Public Property OutputDocuments As colOutputDocuments
    Get
      Return pOutputDocuments
    End Get
    Set(value As colOutputDocuments)
      pOutputDocuments = value
    End Set
  End Property


  Public Function GetTotalValueWithCarriage() As Decimal

    Dim mRetVal As Decimal
    mRetVal = pSalesOrderItems.GetTotalValue
    mRetVal = mRetVal + ShippingCost

    Return mRetVal


  End Function

  Public Function GetTotalInvoiceValue() As Decimal
    Dim mRetVal As Decimal
    mRetVal = pInvoices.GetTotalValue


    Return mRetVal
  End Function


  Public Property WoodPalletID As Integer
    Get
      Return pWoodPalletID
    End Get
    Set(value As Integer)
      If pWoodPalletID <> value Then IsDirty = True
      pWoodPalletID = value
    End Set
  End Property

  Public Property WoodPalletType As Integer
    Get
      Return pWoodPalletType
    End Get
    Set(value As Integer)
      If pWoodPalletType <> value Then IsDirty = True
      pWoodPalletType = value
    End Set
  End Property

  Public Property CIFValue As Decimal
    Get
      Return pCIFValue
    End Get
    Set(value As Decimal)
      If pCIFValue <> value Then IsDirty = True
      pCIFValue = value
    End Set
  End Property
End Class



''Collection Definition - SalesOrder (to SalesOrder)'Generated from Table:SalesOrder

'Private pSalesOrders As colSalesOrders
'Public Property SalesOrders() As colSalesOrders
'  Get
'    Return pSalesOrders
'  End Get
'  Set(ByVal value As colSalesOrders)
'    pSalesOrders = value
'  End Set
'End Property

'  pSalesOrders = New colSalesOrders 'Add to New
'  pSalesOrders = Nothing 'Add to Finalize
'  .SalesOrders = SalesOrders.Clone 'Add to CloneTo
'  SalesOrders.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrders.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrders : Inherits colBase(Of dmSalesOrder)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderID As Integer) As Integer
    Dim mItem As dmSalesOrder
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderID = vSalesOrderID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrder))
    MyBase.New(vList)
  End Sub

End Class


