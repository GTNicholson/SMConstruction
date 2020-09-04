''Class Definition - SalesItemComponent (to SalesItemComponent)'Generated from Table:SalesItemComponent
Imports RTIS.CommonVB

Public Class dmSalesItemComponent : Inherits dmBase
  Private pSalesItemComponentID As Int32
  Private pSalesOrderItemID As Int32
  Private pProductID As Int32
  Private pSalesOrderStageID As Int32
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
    SalesItemComponentID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesItemComponent)
      .SalesItemComponentID = SalesItemComponentID
      .SalesOrderItemID = SalesOrderItemID
      .ProductID = ProductID
      .SalesOrderStageID = SalesOrderStageID
      .Quantity = Quantity
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesItemComponentID() As Int32
    Get
      Return pSalesItemComponentID
    End Get
    Set(ByVal value As Int32)
      If pSalesItemComponentID <> value Then IsDirty = True
      pSalesItemComponentID = value
    End Set
  End Property

  Public Property SalesOrderItemID() As Int32
    Get
      Return pSalesOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemID <> value Then IsDirty = True
      pSalesOrderItemID = value
    End Set
  End Property

  Public Property ProductID() As Int32
    Get
      Return pProductID
    End Get
    Set(ByVal value As Int32)
      If pProductID <> value Then IsDirty = True
      pProductID = value
    End Set
  End Property

  Public Property SalesOrderStageID() As Int32
    Get
      Return pSalesOrderStageID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderStageID <> value Then IsDirty = True
      pSalesOrderStageID = value
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



''Collection Definition - SalesItemComponent (to SalesItemComponent)'Generated from Table:SalesItemComponent

'Private pSalesItemComponents As colSalesItemComponents
'Public Property SalesItemComponents() As colSalesItemComponents
'  Get
'    Return pSalesItemComponents
'  End Get
'  Set(ByVal value As colSalesItemComponents)
'    pSalesItemComponents = value
'  End Set
'End Property

'  pSalesItemComponents = New colSalesItemComponents 'Add to New
'  pSalesItemComponents = Nothing 'Add to Finalize
'  .SalesItemComponents = SalesItemComponents.Clone 'Add to CloneTo
'  SalesItemComponents.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesItemComponents.IsDirty 'Add to IsAnyDirty

Public Class colSalesItemComponents : Inherits colBase(Of dmSalesItemComponent)

  Public Overrides Function IndexFromKey(ByVal vSalesItemComponentID As Integer) As Integer
    Dim mItem As dmSalesItemComponent
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesItemComponentID = vSalesItemComponentID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesItemComponent))
    MyBase.New(vList)
  End Sub

End Class


