''Class Definition - StockTake (to StockTake)'Generated from Table:StockTake
Imports RTIS.CommonVB

Public Class dmStockTake : Inherits dmBase
  Private pStockTakeID As Int32
  Private pStockTakeTypeID As Byte
  Private pDescription As String
  Private pStockTakeDate As DateTime
  Private pCreatedDate As DateTime
  Private pSnapshotDateTime As DateTime
  Private pDateCommitted As DateTime
  Private pRangeStockCodeStart As String
  Private pRangeStockCodeEnd As String
  Private pDateSystemQty As DateTime


  Private pStockTakeItems As colStockTakeItems

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pStockTakeItems = New colStockTakeItems
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pStockTakeItems = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pStockTakeItems.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    StockTakeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockTake)
      .StockTakeID = StockTakeID
      .StockTakeTypeID = StockTakeTypeID
      .Description = Description
      .StockTakeDate = StockTakeDate
      .CreatedDate = CreatedDate
      .SnapshotDateTime = SnapshotDateTime
      .DateCommitted = DateCommitted
      .RangeStockCodeStart = RangeStockCodeStart
      .RangeStockCodeEnd = RangeStockCodeEnd
      .DateSystemQty = DateSystemQty

      'Add entries here for each collection and class property
      StockTakeItems = StockTakeItems.Clone

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockTakeID() As Int32
    Get
      Return pStockTakeID
    End Get
    Set(ByVal value As Int32)
      If pStockTakeID <> value Then IsDirty = True
      pStockTakeID = value
    End Set
  End Property

  Public Property StockTakeTypeID() As Byte
    Get
      Return pStockTakeTypeID
    End Get
    Set(ByVal value As Byte)
      If pStockTakeTypeID <> value Then IsDirty = True
      pStockTakeTypeID = value
    End Set
  End Property

  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property StockTakeDate() As DateTime
    Get
      Return pStockTakeDate
    End Get
    Set(ByVal value As DateTime)
      If pStockTakeDate <> value Then IsDirty = True
      pStockTakeDate = value
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

  Public Property SnapshotDateTime() As DateTime
    Get
      Return pSnapshotDateTime
    End Get
    Set(ByVal value As DateTime)
      If pSnapshotDateTime <> value Then IsDirty = True
      pSnapshotDateTime = value
    End Set
  End Property

  Public Property DateCommitted() As DateTime
    Get
      Return pDateCommitted
    End Get
    Set(ByVal value As DateTime)
      If pDateCommitted <> value Then IsDirty = True
      pDateCommitted = value
    End Set
  End Property

  Public Property RangeStockCodeStart() As String
    Get
      Return pRangeStockCodeStart
    End Get
    Set(ByVal value As String)
      If pRangeStockCodeStart <> value Then IsDirty = True
      pRangeStockCodeStart = value
    End Set
  End Property

  Public Property RangeStockCodeEnd() As String
    Get
      Return pRangeStockCodeEnd
    End Get
    Set(ByVal value As String)
      If pRangeStockCodeEnd <> value Then IsDirty = True
      pRangeStockCodeEnd = value
    End Set
  End Property

  Public Property DateSystemQty() As DateTime
    Get
      Return pDateSystemQty
    End Get
    Set(ByVal value As DateTime)
      If pDateSystemQty <> value Then IsDirty = True
      pDateSystemQty = value
    End Set
  End Property

  Public Property StockTakeItems As colStockTakeItems
    Get
      Return pStockTakeItems
    End Get
    Set(value As colStockTakeItems)
      pStockTakeItems = value
    End Set
  End Property

End Class



''Collection Definition - StockTake (to StockTake)'Generated from Table:StockTake

'Private pStockTakes As colStockTakes
'Public Property StockTakes() As colStockTakes
'  Get
'    Return pStockTakes
'  End Get
'  Set(ByVal value As colStockTakes)
'    pStockTakes = value
'  End Set
'End Property

'  pStockTakes = New colStockTakes 'Add to New
'  pStockTakes = Nothing 'Add to Finalize
'  .StockTakes = StockTakes.Clone 'Add to CloneTo
'  StockTakes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockTakes.IsDirty 'Add to IsAnyDirty

Public Class colStockTakes : Inherits colBase(Of dmStockTake)

  Public Overrides Function IndexFromKey(ByVal vStockTakeID As Integer) As Integer
    Dim mItem As dmStockTake
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockTakeID = vStockTakeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockTake))
    MyBase.New(vList)
  End Sub

End Class


