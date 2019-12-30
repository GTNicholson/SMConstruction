''Class Definition - StockTakeItem (to StockTakeItem)'Generated from Table:StockTakeItem
Imports RTIS.CommonVB

Public Class dmStockTakeItem : Inherits dmBase
  Private pStockTakeItemID As Int32
  Private pStockTakeID As Int32
  Private pStockItemID As Int32
  Private pStockItemLocationID As Byte
  Private pSalesOrderPhaseID As Int32
  Private pSnapshotQty As Decimal
  Private pCountedQty As Decimal
  Private pCreatedDate As DateTime
  Private pTotalValue As Decimal
  Private pIsCounted As Boolean
  Private pSnapShotStockQty As Decimal
  Private pSnapShotCostingQuantity As Decimal
  Private pSnapShotUnitCost As Decimal
  Private pStockItemCategoryID As Int32
  Private pStockTakeSheetID As Int32
  Private pSystemTotalValue As Decimal
  Private pCountedTotalValue As Decimal

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
    StockTakeItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockTakeItem)
      .StockTakeItemID = StockTakeItemID
      .StockTakeID = StockTakeID
      .StockItemID = StockItemID
      .StockItemLocationID = StockItemLocationID
      .SalesOrderPhaseID = SalesOrderPhaseID
      .SnapshotQty = SnapshotQty
      .CountedQty = CountedQty
      .CreatedDate = CreatedDate
      .TotalValue = TotalValue
      .IsCounted = IsCounted
      .SnapShotStockQty = SnapShotStockQty
      .SnapShotCostingQuantity = SnapShotCostingQuantity
      .SnapShotUnitCost = SnapShotUnitCost
      .StockItemCategoryID = StockItemCategoryID
      .StockTakeSheetID = StockTakeSheetID
      .SystemTotalValue = SystemTotalValue
      .CountedTotalValue = CountedTotalValue
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockTakeItemID() As Int32
    Get
      Return pStockTakeItemID
    End Get
    Set(ByVal value As Int32)
      If pStockTakeItemID <> value Then IsDirty = True
      pStockTakeItemID = value
    End Set
  End Property

  Public Property StockTakeID() As Int32
    Get
      Return pStockTakeID
    End Get
    Set(ByVal value As Int32)
      If pStockTakeID <> value Then IsDirty = True
      pStockTakeID = value
    End Set
  End Property

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property StockItemLocationID() As Byte
    Get
      Return pStockItemLocationID
    End Get
    Set(ByVal value As Byte)
      If pStockItemLocationID <> value Then IsDirty = True
      pStockItemLocationID = value
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

  Public Property SnapshotQty() As Decimal
    Get
      Return pSnapshotQty
    End Get
    Set(ByVal value As Decimal)
      If pSnapshotQty <> value Then IsDirty = True
      pSnapshotQty = value
    End Set
  End Property

  Public Property CountedQty() As Decimal
    Get
      Return pCountedQty
    End Get
    Set(ByVal value As Decimal)
      If pCountedQty <> value Then IsDirty = True
      pCountedQty = value
    End Set
  End Property

  Public Property CreatedDate() As DateTime
    Get
      Return pCreatedDate
    End Get
    Set(ByVal value As DateTime)
      If pCreatedDate <> value Then IsDirty = True
      pCreatedDate = value
    End Set
  End Property

  Public Property TotalValue() As Decimal
    Get
      Return pTotalValue
    End Get
    Set(ByVal value As Decimal)
      If pTotalValue <> value Then IsDirty = True
      pTotalValue = value
    End Set
  End Property

  Public Property IsCounted() As Boolean
    Get
      Return pIsCounted
    End Get
    Set(ByVal value As Boolean)
      If pIsCounted <> value Then IsDirty = True
      pIsCounted = value
    End Set
  End Property

  Public Property SnapShotStockQty() As Decimal
    Get
      Return pSnapShotStockQty
    End Get
    Set(ByVal value As Decimal)
      If pSnapShotStockQty <> value Then IsDirty = True
      pSnapShotStockQty = value
    End Set
  End Property

  Public Property SnapShotCostingQuantity() As Decimal
    Get
      Return pSnapShotCostingQuantity
    End Get
    Set(ByVal value As Decimal)
      If pSnapShotCostingQuantity <> value Then IsDirty = True
      pSnapShotCostingQuantity = value
    End Set
  End Property

  Public Property SnapShotUnitCost() As Decimal
    Get
      Return pSnapShotUnitCost
    End Get
    Set(ByVal value As Decimal)
      If pSnapShotUnitCost <> value Then IsDirty = True
      pSnapShotUnitCost = value
    End Set
  End Property

  Public Property StockItemCategoryID() As Int32
    Get
      Return pStockItemCategoryID
    End Get
    Set(ByVal value As Int32)
      If pStockItemCategoryID <> value Then IsDirty = True
      pStockItemCategoryID = value
    End Set
  End Property

  Public Property StockTakeSheetID() As Int32
    Get
      Return pStockTakeSheetID
    End Get
    Set(ByVal value As Int32)
      If pStockTakeSheetID <> value Then IsDirty = True
      pStockTakeSheetID = value
    End Set
  End Property

  Public Property SystemTotalValue() As Decimal
    Get
      Return pSystemTotalValue
    End Get
    Set(ByVal value As Decimal)
      If pSystemTotalValue <> value Then IsDirty = True
      pSystemTotalValue = value
    End Set
  End Property

  Public Property CountedTotalValue() As Decimal
    Get
      Return pCountedTotalValue
    End Get
    Set(ByVal value As Decimal)
      If pCountedTotalValue <> value Then IsDirty = True
      pCountedTotalValue = value
    End Set
  End Property


End Class



''Collection Definition - StockTakeItem (to StockTakeItem)'Generated from Table:StockTakeItem

'Private pStockTakeItems As colStockTakeItems
'Public Property StockTakeItems() As colStockTakeItems
'  Get
'    Return pStockTakeItems
'  End Get
'  Set(ByVal value As colStockTakeItems)
'    pStockTakeItems = value
'  End Set
'End Property

'  pStockTakeItems = New colStockTakeItems 'Add to New
'  pStockTakeItems = Nothing 'Add to Finalize
'  .StockTakeItems = StockTakeItems.Clone 'Add to CloneTo
'  StockTakeItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockTakeItems.IsDirty 'Add to IsAnyDirty

Public Class colStockTakeItems : Inherits colBase(Of dmStockTakeItem)

  Public Overrides Function IndexFromKey(ByVal vStockTakeItemID As Integer) As Integer
    Dim mItem As dmStockTakeItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockTakeItemID = vStockTakeItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockTakeItem))
    MyBase.New(vList)
  End Sub

  Public Function IndexFromStockItemIDLocationID(vStockItemID As Integer, vLocationID As Integer) As Integer
    Dim mItem As dmStockTakeItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemID = vStockItemID And mItem.StockItemLocationID = vLocationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemFromStockItemIDLocationID(vStockItemID As Integer, vLocationID As Integer) As dmStockTakeItem
    Dim mRetVal As dmStockTakeItem = Nothing
    Dim mIndex As Integer

    mIndex = IndexFromStockItemIDLocationID(vStockItemID, vLocationID)
    If mIndex <> -1 Then
      mRetVal = Me.Items(mIndex)
    End If
    Return mRetVal
  End Function

End Class


