''Class Definition - StockItemLocation (to StockItemLocation)'Generated from Table:StockItemLocation
Imports RTIS.CommonVB

Public Class dmStockItemLocation : Inherits dmBase
  Private pStockItemLocationID As Int32
  Private pStockItemID As Int32
  Private pLocationID As Byte
  Private pQty As Decimal

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
    StockItemLocationID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItemLocation)
      .StockItemLocationID = StockItemLocationID
      .StockItemID = StockItemID
      .LocationID = LocationID
      .Qty = Qty
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemLocationID() As Int32
    Get
      Return pStockItemLocationID
    End Get
    Set(ByVal value As Int32)
      If pStockItemLocationID <> value Then IsDirty = True
      pStockItemLocationID = value
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

  Public Property LocationID() As Byte
    Get
      Return pLocationID
    End Get
    Set(ByVal value As Byte)
      If pLocationID <> value Then IsDirty = True
      pLocationID = value
    End Set
  End Property

  Public Property Qty() As Decimal
    Get
      Return pQty
    End Get
    Set(ByVal value As Decimal)
      If pQty <> value Then IsDirty = True
      pQty = value
    End Set
  End Property


End Class



''Collection Definition - StockItemLocation (to StockItemLocation)'Generated from Table:StockItemLocation

'Private pStockItemLocations As colStockItemLocations
'Public Property StockItemLocations() As colStockItemLocations
'  Get
'    Return pStockItemLocations
'  End Get
'  Set(ByVal value As colStockItemLocations)
'    pStockItemLocations = value
'  End Set
'End Property

'  pStockItemLocations = New colStockItemLocations 'Add to New
'  pStockItemLocations = Nothing 'Add to Finalize
'  .StockItemLocations = StockItemLocations.Clone 'Add to CloneTo
'  StockItemLocations.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItemLocations.IsDirty 'Add to IsAnyDirty

Public Class colStockItemLocations : Inherits colBase(Of dmStockItemLocation)

  Public Overrides Function IndexFromKey(ByVal vStockItemLocationID As Integer) As Integer
    Dim mItem As dmStockItemLocation
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemLocationID = vStockItemLocationID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItemLocation))
    MyBase.New(vList)
  End Sub

End Class


