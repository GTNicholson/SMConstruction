''Class Definition - PhaseItemComponent (to PhaseItemComponent)'Generated from Table:PhaseItemComponent
Imports RTIS.CommonVB

Public Class dmPhaseItemComponent : Inherits dmBase
  Private pPhaseItemComponentID As Int32
  Private pSalesOrderPhaseID As Int32
  Private pQuantity As Int32

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
    PhaseItemComponentID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPhaseItemComponent)
      .PhaseItemComponentID = PhaseItemComponentID
      .SalesOrderPhaseID = SalesOrderPhaseID
      .Quantity = Quantity
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PhaseItemComponentID() As Int32
    Get
      Return pPhaseItemComponentID
    End Get
    Set(ByVal value As Int32)
      If pPhaseItemComponentID <> value Then IsDirty = True
      pPhaseItemComponentID = value
    End Set
  End Property

  Public Property SalesOrderPhaseID() As Int32
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseID <> value Then IsDirty = True
      pSalesOrderPhaseID = value
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


End Class



''Collection Definition - PhaseItemComponent (to PhaseItemComponent)'Generated from Table:PhaseItemComponent

'Private pPhaseItemComponents As colPhaseItemComponents
'Public Property PhaseItemComponents() As colPhaseItemComponents
'  Get
'    Return pPhaseItemComponents
'  End Get
'  Set(ByVal value As colPhaseItemComponents)
'    pPhaseItemComponents = value
'  End Set
'End Property

'  pPhaseItemComponents = New colPhaseItemComponents 'Add to New
'  pPhaseItemComponents = Nothing 'Add to Finalize
'  .PhaseItemComponents = PhaseItemComponents.Clone 'Add to CloneTo
'  PhaseItemComponents.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PhaseItemComponents.IsDirty 'Add to IsAnyDirty

Public Class colPhaseItemComponents : Inherits colBase(Of dmPhaseItemComponent)

  Public Overrides Function IndexFromKey(ByVal vPhaseItemComponentID As Integer) As Integer
    Dim mItem As dmPhaseItemComponent
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PhaseItemComponentID = vPhaseItemComponentID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPhaseItemComponent))
    MyBase.New(vList)
  End Sub

End Class



