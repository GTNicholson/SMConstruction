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

  Private pCustomer As dmCustomer
  Private pWorkOrders As colWorkOrders

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pWorkOrders = New colWorkOrders
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    SalesOrderID = 0
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
      .Duetime = DueTime
      'Add entries here for each collection and class property

      'Entries for object management
      .WorkOrders = WorkOrders.Clone

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
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

  Public Property CustomerContactID() As Int32
    Get
      Return pCustomerContactID
    End Get
    Set(ByVal value As Int32)
      If pCustomerContactID <> value Then IsDirty = True
      pCustomerContactID = value
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

  Public Property WorkOrders As colWorkOrders
    Get
      Return pWorkOrders
    End Get
    Set(value As colWorkOrders)
      pWorkOrders = value
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


