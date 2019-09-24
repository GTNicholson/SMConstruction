''Class Definition - WorkOrderBatch (to WorkOrderBatch)'Generated from Table:WorkOrderBatch
Imports RTIS.CommonVB

Public Class dmWorkOrderBatch : Inherits dmBase
  Private pWorkOrderBatchID As Int32
  Private pWorkOrderID As Int32
  Private pQuantity As Int32
  Private pRef As String
  Private pPlannedStartDate As DateTime

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
    WorkOrderBatchID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrderBatch)
      .WorkOrderBatchID = WorkOrderBatchID
      .WorkOrderID = WorkOrderID
      .Quantity = Quantity
      .Ref = Ref
      .PlannedStartDate = PlannedStartDate
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkOrderBatchID() As Int32
    Get
      Return pWorkOrderBatchID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderBatchID <> value Then IsDirty = True
      pWorkOrderBatchID = value
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

  Public Property Quantity() As Int32
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Int32)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property Ref() As String
    Get
      Return pRef
    End Get
    Set(ByVal value As String)
      If pRef <> value Then IsDirty = True
      pRef = value
    End Set
  End Property

  Public Property PlannedStartDate() As DateTime
    Get
      Return pPlannedStartDate
    End Get
    Set(ByVal value As DateTime)
      If pPlannedStartDate <> value Then IsDirty = True
      pPlannedStartDate = value
    End Set
  End Property


End Class



''Collection Definition - WorkOrderBatch (to WorkOrderBatch)'Generated from Table:WorkOrderBatch

'Private pWorkOrderBatchs As colWorkOrderBatchs
'Public Property WorkOrderBatchs() As colWorkOrderBatchs
'  Get
'    Return pWorkOrderBatchs
'  End Get
'  Set(ByVal value As colWorkOrderBatchs)
'    pWorkOrderBatchs = value
'  End Set
'End Property

'  pWorkOrderBatchs = New colWorkOrderBatchs 'Add to New
'  pWorkOrderBatchs = Nothing 'Add to Finalize
'  .WorkOrderBatchs = WorkOrderBatchs.Clone 'Add to CloneTo
'  WorkOrderBatchs.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WorkOrderBatchs.IsDirty 'Add to IsAnyDirty

Public Class colWorkOrderBatchs : Inherits colBase(Of dmWorkOrderBatch)

  Public Overrides Function IndexFromKey(ByVal vWorkOrderBatchID As Integer) As Integer
    Dim mItem As dmWorkOrderBatch
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderBatchID = vWorkOrderBatchID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWorkOrderBatch))
    MyBase.New(vList)
  End Sub

End Class

