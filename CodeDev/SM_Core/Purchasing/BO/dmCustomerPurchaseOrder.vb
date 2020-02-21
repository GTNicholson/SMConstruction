''Class Definition - CustomerPurchaseOrder (to CustomerPurchaseOrder)'Generated from Table:CustomerPurchaseOrder
Imports RTIS.CommonVB

Public Class dmCustomerPurchaseOrder : Inherits dmBase
  Private pCustomerPurchaseOrderID As Int32
  Private pSalesOrderID As Int32
  Private pOrderNo As String
  Private pOrderDate As DateTime
  Private pOrderValue As Decimal

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
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
    CustomerPurchaseOrderID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmCustomerPurchaseOrder)
      .CustomerPurchaseOrderID = CustomerPurchaseOrderID
      .SalesOrderID = SalesOrderID
      .OrderNo = OrderNo
      .OrderDate = OrderDate
      .OrderValue = OrderValue
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property CustomerPurchaseOrderID() As Int32
    Get
      Return pCustomerPurchaseOrderID
    End Get
    Set(ByVal value As Int32)
      If pCustomerPurchaseOrderID <> value Then IsDirty = True
      pCustomerPurchaseOrderID = value
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

  Public Property OrderNo() As String
    Get
      Return pOrderNo
    End Get
    Set(ByVal value As String)
      If pOrderNo <> value Then IsDirty = True
      pOrderNo = value
    End Set
  End Property

  Public Property OrderDate() As DateTime
    Get
      Return pOrderDate
    End Get
    Set(ByVal value As DateTime)
      If pOrderDate <> value Then IsDirty = True
      pOrderDate = value
    End Set
  End Property

  Public Property OrderValue() As Decimal
    Get
      Return pOrderValue
    End Get
    Set(ByVal value As Decimal)
      If pOrderValue <> value Then IsDirty = True
      pOrderValue = value
    End Set
  End Property


End Class



''Collection Definition - CustomerPurchaseOrder (to CustomerPurchaseOrder)'Generated from Table:CustomerPurchaseOrder

'Private pCustomerPurchaseOrders As colCustomerPurchaseOrders
'Public Property CustomerPurchaseOrders() As colCustomerPurchaseOrders
'  Get
'    Return pCustomerPurchaseOrders
'  End Get
'  Set(ByVal value As colCustomerPurchaseOrders)
'    pCustomerPurchaseOrders = value
'  End Set
'End Property

'  pCustomerPurchaseOrders = New colCustomerPurchaseOrders 'Add to New
'  pCustomerPurchaseOrders = Nothing 'Add to Finalize
'  .CustomerPurchaseOrders = CustomerPurchaseOrders.Clone 'Add to CloneTo
'  CustomerPurchaseOrders.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = CustomerPurchaseOrders.IsDirty 'Add to IsAnyDirty

Public Class colCustomerPurchaseOrders : Inherits colBase(Of dmCustomerPurchaseOrder)

  Public Overrides Function IndexFromKey(ByVal vCustomerPurchaseOrderID As Integer) As Integer
    Dim mItem As dmCustomerPurchaseOrder
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.CustomerPurchaseOrderID = vCustomerPurchaseOrderID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmCustomerPurchaseOrder))
    MyBase.New(vList)
  End Sub

End Class


''DTO Definition - CustomerPurchaseOrder (to CustomerPurchaseOrder)'Generated from Table:CustomerPurchaseOrder

