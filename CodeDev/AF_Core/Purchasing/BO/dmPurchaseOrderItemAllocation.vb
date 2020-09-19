''Class Definition - PurchaseOrderItemAllocation (to PurchaseOrderItemAllocation)'Generated from Table:PurchaseOrderItemAllocation
Imports RTIS.CommonVB

Public Class dmPurchaseOrderItemAllocation : Inherits dmBase
  Private pPurchaseOrderItemAllocationID As Int32
  Private pPurchaseOrderItemID As Int32
  Private pSalesOrderPhaseID As Int32
  Private pQuantity As Decimal
  Private pReceivedQty As Decimal
  Private pWorkOrderID As Int32
  Private pReplacementQty As Decimal
  Private pQtyRejected As Decimal
  Private pItemRef As String
  Private pJobNoTmp As String
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
    PurchaseOrderItemAllocationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPurchaseOrderItemAllocation)
      .PurchaseOrderItemAllocationID = PurchaseOrderItemAllocationID
      .PurchaseOrderItemID = PurchaseOrderItemID
      .CallOffID = CallOffID
      .Quantity = Quantity
      .ReceivedQty = ReceivedQty
      'Add entries here for each collection and class property
      .WorkOrderID = WorkOrderID
      .ReplacementQty = ReplacementQty
      .QtyRejected = QtyRejected
      .ItemRef = ItemRef
      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub
  Public Property QtyRejected() As Decimal
    Get
      Return pQtyRejected
    End Get
    Set(ByVal value As Decimal)
      If pQtyRejected <> value Then IsDirty = True
      pQtyRejected = value
    End Set
  End Property

  Public Property ReplacementQty() As Decimal
    Get
      Return pReplacementQty
    End Get
    Set(ByVal value As Decimal)
      If pReplacementQty <> value Then IsDirty = True
      pReplacementQty = value
    End Set
  End Property


  Public Property ItemRef() As String
    Get
      Return pItemRef
    End Get
    Set(ByVal value As String)
      If pItemRef <> value Then IsDirty = True
      pItemRef = value
    End Set
  End Property

  Public Property PurchaseOrderItemAllocationID() As Int32
    Get
      Return pPurchaseOrderItemAllocationID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderItemAllocationID <> value Then IsDirty = True
      pPurchaseOrderItemAllocationID = value
    End Set
  End Property

  Public Property WorkOrderID() As Int32
    Get
      Return pWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderID <> value Then IsDirty = True
      pWorkOrderID = value
    End Set
  End Property


  Public Property PurchaseOrderItemID() As Int32
    Get
      Return pPurchaseOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderItemID <> value Then IsDirty = True
      pPurchaseOrderItemID = value
    End Set
  End Property
  Public Sub SetReceivedQty(ByVal vNewValue As Decimal)
    pReceivedQty = vNewValue
  End Sub
  Public Property ReceivedQty() As Decimal
    Get
      Return pReceivedQty
    End Get
    Set(ByVal value As Decimal)
      If pReceivedQty <> value Then IsDirty = True
      pReceivedQty = value
    End Set
  End Property

  Public Property CallOffID() As Int32
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseID <> value Then IsDirty = True
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property JobNoTmp As String
    Get
      Return pJobNoTmp
    End Get
    Set(value As String)
      pJobNoTmp = value
    End Set
  End Property
End Class



''Collection Definition - PurchaseOrderItemAllocation (to PurchaseOrderItemAllocation)'Generated from Table:PurchaseOrderItemAllocation

'Private pPurchaseOrderItemAllocations As colPurchaseOrderItemAllocations
'Public Property PurchaseOrderItemAllocations() As colPurchaseOrderItemAllocations
'  Get
'    Return pPurchaseOrderItemAllocations
'  End Get
'  Set(ByVal value As colPurchaseOrderItemAllocations)
'    pPurchaseOrderItemAllocations = value
'  End Set
'End Property

'  pPurchaseOrderItemAllocations = New colPurchaseOrderItemAllocations 'Add to New
'  pPurchaseOrderItemAllocations = Nothing 'Add to Finalize
'  .PurchaseOrderItemAllocations = PurchaseOrderItemAllocations.Clone 'Add to CloneTo
'  PurchaseOrderItemAllocations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PurchaseOrderItemAllocations.IsDirty 'Add to IsAnyDirty

Public Class colPurchaseOrderItemAllocations : Inherits colBase(Of dmPurchaseOrderItemAllocation)

  Public Overrides Function IndexFromKey(ByVal vPurchaseOrderItemAllocationID As Integer) As Integer
    Dim mItem As dmPurchaseOrderItemAllocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PurchaseOrderItemAllocationID = vPurchaseOrderItemAllocationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPurchaseOrderItemAllocation))
    MyBase.New(vList)
  End Sub

  Public Function TotalQuantityAllocated() As Decimal
    Dim mRetVal As Decimal

    For Each mPOIAllocation As dmPurchaseOrderItemAllocation In MyBase.Items
      mRetVal += mPOIAllocation.Quantity
    Next

    Return mRetVal
  End Function

  Public Function TotalQuantityAllocatedReceived() As Decimal
    Dim mRetVal As Decimal

    For Each mPOIAllocation As dmPurchaseOrderItemAllocation In MyBase.Items
      mRetVal += mPOIAllocation.ReceivedQty
    Next

    Return mRetVal
  End Function


End Class


