''Class Definition - SalesOrderPhaseItem (to SalesOrderPhaseItem)'Generated from Table:SalesOrderPhaseItem
Imports RTIS.CommonVB

Public Class dmSalesOrderPhaseItem : Inherits dmBase
  Private pSalesOrderPhaseItemID As Int32
  Private pSalesOrderID As Int32
  Private pSalesOrderPhaseID As Int32
  Private pSalesItemID As Int32
  Private pQty As Int32

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
    SalesOrderPhaseItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderPhaseItem)
      .SalesOrderPhaseItemID = SalesOrderPhaseItemID
      .SalesOrderID = SalesOrderID
      .SalesOrderPhaseID = SalesOrderPhaseID
      .SalesItemID = SalesItemID
      .Qty = Qty
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderPhaseItemID() As Int32
    Get
      Return pSalesOrderPhaseItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseItemID <> value Then IsDirty = True
      pSalesOrderPhaseItemID = value
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

  Public Property SalesOrderPhaseID() As Int32
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseID <> value Then IsDirty = True
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property SalesItemID() As Int32
    Get
      Return pSalesItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesItemID <> value Then IsDirty = True
      pSalesItemID = value
    End Set
  End Property

  Public Property Qty() As Int32
    Get
      Return pQty
    End Get
    Set(ByVal value As Int32)
      If pQty <> value Then IsDirty = True
      pQty = value
    End Set
  End Property


End Class



''Collection Definition - SalesOrderPhaseItem (to SalesOrderPhaseItem)'Generated from Table:SalesOrderPhaseItem

'Private pSalesOrderPhaseItems As colSalesOrderPhaseItems
'Public Property SalesOrderPhaseItems() As colSalesOrderPhaseItems
'  Get
'    Return pSalesOrderPhaseItems
'  End Get
'  Set(ByVal value As colSalesOrderPhaseItems)
'    pSalesOrderPhaseItems = value
'  End Set
'End Property

'  pSalesOrderPhaseItems = New colSalesOrderPhaseItems 'Add to New
'  pSalesOrderPhaseItems = Nothing 'Add to Finalize
'  .SalesOrderPhaseItems = SalesOrderPhaseItems.Clone 'Add to CloneTo
'  SalesOrderPhaseItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderPhaseItems.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderPhaseItems : Inherits colBase(Of dmSalesOrderPhaseItem)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderPhaseItemID As Integer) As Integer
    Dim mItem As dmSalesOrderPhaseItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderPhaseItemID = vSalesOrderPhaseItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderPhaseItem))
    MyBase.New(vList)
  End Sub

  Public Function ItemFromSalesItemKey(ByVal vSalesOrderID As Integer) As dmSalesOrderPhaseItem
    Dim mItem As dmSalesOrderPhaseItem
    Dim mRetVal As dmSalesOrderPhaseItem = Nothing


    For Each mItem In Me

      If mItem.SalesItemID = vSalesOrderID Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

End Class

