''Class Definition - WorkOrderAllocation (to WorkOrderAllocation)'Generated from Table:WorkOrderAllocation
Imports RTIS.CommonVB

Public Class dmWorkOrderAllocation : Inherits dmBase
  Private pWorkOrderAllocationID As Int32
  Private pWorkOrderID As Int32
  Private pPhaseItemComponentID As Int32

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
    WorkOrderAllocationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrderAllocation)
      .WorkOrderAllocationID = WorkOrderAllocationID
      .WorkOrderID = WorkOrderID
      .PhaseItemComponentID = PhaseItemComponentID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkOrderAllocationID() As Int32
    Get
      Return pWorkOrderAllocationID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderAllocationID <> value Then IsDirty = True
      pWorkOrderAllocationID = value
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

  Public Property PhaseItemComponentID() As Int32
    Get
      Return pPhaseItemComponentID
    End Get
    Set(ByVal value As Int32)
      If pPhaseItemComponentID <> value Then IsDirty = True
      pPhaseItemComponentID = value
    End Set
  End Property


End Class



''Collection Definition - WorkOrderAllocation (to WorkOrderAllocation)'Generated from Table:WorkOrderAllocation

'Private pWorkOrderAllocations As colWorkOrderAllocations
'Public Property WorkOrderAllocations() As colWorkOrderAllocations
'  Get
'    Return pWorkOrderAllocations
'  End Get
'  Set(ByVal value As colWorkOrderAllocations)
'    pWorkOrderAllocations = value
'  End Set
'End Property

'  pWorkOrderAllocations = New colWorkOrderAllocations 'Add to New
'  pWorkOrderAllocations = Nothing 'Add to Finalize
'  .WorkOrderAllocations = WorkOrderAllocations.Clone 'Add to CloneTo
'  WorkOrderAllocations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WorkOrderAllocations.IsDirty 'Add to IsAnyDirty

Public Class colWorkOrderAllocations : Inherits colBase(Of dmWorkOrderAllocation)

  Public Overrides Function IndexFromKey(ByVal vWorkOrderAllocationID As Integer) As Integer
    Dim mItem As dmWorkOrderAllocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderAllocationID = vWorkOrderAllocationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWorkOrderAllocation))
    MyBase.New(vList)
  End Sub

End Class


