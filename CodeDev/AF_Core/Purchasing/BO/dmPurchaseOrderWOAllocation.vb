''Class Definition - PurchaseOrderWOAllocation (to PurchaseOrderWOAllocation)'Generated from Table:PurchaseOrderWOAllocation
Imports RTIS.CommonVB

Public Class dmPurchaseOrderWOAllocation : Inherits dmBase
  Private pPurchaseOrderWOAllocationID As Int32
  Private pPurchaseOrderID As Int32
  Private pWorkOrderID As Int32

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
    PurchaseOrderWOAllocationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPurchaseOrderWOAllocation)
      .PurchaseOrderWOAllocationID = PurchaseOrderWOAllocationID
      .PurchaseOrderID = PurchaseOrderID
      .WorkOrderID = WorkOrderID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PurchaseOrderWOAllocationID() As Int32
    Get
      Return pPurchaseOrderWOAllocationID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderWOAllocationID <> value Then IsDirty = True
      pPurchaseOrderWOAllocationID = value
    End Set
  End Property

  Public Property PurchaseOrderID() As Int32
    Get
      Return pPurchaseOrderID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderID <> value Then IsDirty = True
      pPurchaseOrderID = value
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


End Class



''Collection Definition - PurchaseOrderWOAllocation (to PurchaseOrderWOAllocation)'Generated from Table:PurchaseOrderWOAllocation

'Private pPurchaseOrderWOAllocations As colPurchaseOrderWOAllocations
'Public Property PurchaseOrderWOAllocations() As colPurchaseOrderWOAllocations
'  Get
'    Return pPurchaseOrderWOAllocations
'  End Get
'  Set(ByVal value As colPurchaseOrderWOAllocations)
'    pPurchaseOrderWOAllocations = value
'  End Set
'End Property

'  pPurchaseOrderWOAllocations = New colPurchaseOrderWOAllocations 'Add to New
'  pPurchaseOrderWOAllocations = Nothing 'Add to Finalize
'  .PurchaseOrderWOAllocations = PurchaseOrderWOAllocations.Clone 'Add to CloneTo
'  PurchaseOrderWOAllocations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PurchaseOrderWOAllocations.IsDirty 'Add to IsAnyDirty

Public Class colPurchaseOrderWOAllocations : Inherits colBase(Of dmPurchaseOrderWOAllocation)

  Public Overrides Function IndexFromKey(ByVal vPurchaseOrderWOAllocationID As Integer) As Integer
    Dim mItem As dmPurchaseOrderWOAllocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PurchaseOrderWOAllocationID = vPurchaseOrderWOAllocationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPurchaseOrderWOAllocation))
    MyBase.New(vList)
  End Sub

End Class


