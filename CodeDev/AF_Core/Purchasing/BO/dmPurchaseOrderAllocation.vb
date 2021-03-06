﻿''Class Definition - PurchaseOrderAllocation (to PurchaseOrderAllocation)'Generated from Table:PurchaseOrderAllocation
Imports RTIS.CommonVB

Public Class dmPurchaseOrderAllocation : Inherits dmBase
  Private pPurchaseOrderAllocationID As Int32
  Private pPurchaseOrderID As Int32
  Private pCallOffID As Int32
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
    PurchaseOrderAllocationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPurchaseOrderAllocation)
      .PurchaseOrderAllocationID = PurchaseOrderAllocationID
      .PurchaseOrderID = PurchaseOrderID
      .CallOffID = CallOffID
      .WorkOrderID = WorkOrderID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PurchaseOrderAllocationID() As Int32
    Get
      Return pPurchaseOrderAllocationID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderAllocationID <> value Then IsDirty = True
      pPurchaseOrderAllocationID = value
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

  Public Property PurchaseOrderID() As Int32
    Get
      Return pPurchaseOrderID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderID <> value Then IsDirty = True
      pPurchaseOrderID = value
    End Set
  End Property

  Public Property CallOffID() As Int32
    Get
      Return pCallOffID
    End Get
    Set(ByVal value As Int32)
      If pCallOffID <> value Then IsDirty = True
      pCallOffID = value
    End Set
  End Property


End Class



''Collection Definition - PurchaseOrderAllocation (to PurchaseOrderAllocation)'Generated from Table:PurchaseOrderAllocation

'Private pPurchaseOrderAllocations As colPurchaseOrderAllocations
'Public Property PurchaseOrderAllocations() As colPurchaseOrderAllocations
'  Get
'    Return pPurchaseOrderAllocations
'  End Get
'  Set(ByVal value As colPurchaseOrderAllocations)
'    pPurchaseOrderAllocations = value
'  End Set
'End Property

'  pPurchaseOrderAllocations = New colPurchaseOrderAllocations 'Add to New
'  pPurchaseOrderAllocations = Nothing 'Add to Finalize
'  .PurchaseOrderAllocations = PurchaseOrderAllocations.Clone 'Add to CloneTo
'  PurchaseOrderAllocations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PurchaseOrderAllocations.IsDirty 'Add to IsAnyDirty

Public Class colPurchaseOrderAllocations : Inherits colBase(Of dmPurchaseOrderAllocation)

  Public Overrides Function IndexFromKey(ByVal vPurchaseOrderAllocationID As Integer) As Integer
    Dim mItem As dmPurchaseOrderAllocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PurchaseOrderAllocationID = vPurchaseOrderAllocationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPurchaseOrderAllocation))
    MyBase.New(vList)
  End Sub

  Public Function IndexFromWorkOrderID(ByVal vWorkOrderID As Integer) As Integer
    Dim mItem As dmPurchaseOrderAllocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderID = vWorkOrderID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function IndexFromCallOffID(ByVal vCallOffID As Integer) As Integer
    Dim mItem As dmPurchaseOrderAllocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.CallOffID = vCallOffID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemFromSalesOrderPhaseID(ByVal vSalesOrderPhaseID As Integer) As dmPurchaseOrderAllocation
    Dim mItem As dmPurchaseOrderAllocation
    Dim mRetVal As dmPurchaseOrderAllocation = Nothing

    For Each mItem In MyBase.Items

      If mItem.CallOffID = vSalesOrderPhaseID Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function
End Class






