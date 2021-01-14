''Class Definition - CostBookEntry (to CostBookEntry)'Generated from Table:CostBookEntry
Imports RTIS.CommonVB

Public Class dmCostBookEntry : Inherits dmBase
  Private pCostBookEntryID As Int32
  Private pCostBookID As Int32
  Private pStockItemID As Int32
  Private pCost As Decimal
  Private pCostUnit As Int32
  Private pMinCost As Decimal
  Private pRetailPrice As Decimal

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
    CostBookEntryID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmCostBookEntry)
      .CostBookEntryID = CostBookEntryID
      .CostBookID = CostBookID
      .StockItemID = StockItemID
      .Cost = Cost
      .CostUnit = CostUnit
      .MinCost = MinCost
      .RetailPrice = RetailPrice
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property CostBookEntryID() As Int32
    Get
      Return pCostBookEntryID
    End Get
    Set(ByVal value As Int32)
      If pCostBookEntryID <> value Then IsDirty = True
      pCostBookEntryID = value
    End Set
  End Property

  Public Property CostBookID() As Int32
    Get
      Return pCostBookID
    End Get
    Set(ByVal value As Int32)
      If pCostBookID <> value Then IsDirty = True
      pCostBookID = value
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

  Public Property Cost() As Decimal
    Get
      Return pCost
    End Get
    Set(ByVal value As Decimal)
      If pCost <> value Then IsDirty = True
      pCost = value
    End Set
  End Property

  Public Property CostUnit() As Int32
    Get
      Return pCostUnit
    End Get
    Set(ByVal value As Int32)
      If pCostUnit <> value Then IsDirty = True
      pCostUnit = value
    End Set
  End Property

  Public Property MinCost() As Decimal
    Get
      Return pMinCost
    End Get
    Set(ByVal value As Decimal)
      If pMinCost <> value Then IsDirty = True
      pMinCost = value
    End Set
  End Property

  Public Property RetailPrice() As Decimal
    Get
      Return pRetailPrice
    End Get
    Set(ByVal value As Decimal)
      If pRetailPrice <> value Then IsDirty = True
      pRetailPrice = value
    End Set
  End Property


End Class



''Collection Definition - CostBookEntry (to CostBookEntry)'Generated from Table:CostBookEntry

'Private pCostBookEntrys As colCostBookEntrys
'Public Property CostBookEntrys() As colCostBookEntrys
'  Get
'    Return pCostBookEntrys
'  End Get
'  Set(ByVal value As colCostBookEntrys)
'    pCostBookEntrys = value
'  End Set
'End Property

'  pCostBookEntrys = New colCostBookEntrys 'Add to New
'  pCostBookEntrys = Nothing 'Add to Finalize
'  .CostBookEntrys = CostBookEntrys.Clone 'Add to CloneTo
'  CostBookEntrys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = CostBookEntrys.IsDirty 'Add to IsAnyDirty

Public Class colCostBookEntrys : Inherits colBase(Of dmCostBookEntry)

  Public Overrides Function IndexFromKey(ByVal vCostBookEntryID As Integer) As Integer
    Dim mItem As dmCostBookEntry
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.CostBookEntryID = vCostBookEntryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmCostBookEntry))
    MyBase.New(vList)
  End Sub


  Public Function IndexFromStockItemID(vStockItemID As Integer) As Integer
    Dim mItem As dmCostBookEntry
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1

      If mItem.StockItemID = vStockItemID Then
        mIndex = mCount
        Exit For
      End If

    Next
    Return mIndex
  End Function

  Public Function ItemFromStockItemID(ByVal vStockItemID As Integer) As dmCostBookEntry
    Dim mItem As dmCostBookEntry
    Dim mretval As dmCostBookEntry = Nothing

    For Each mItem In MyBase.Items
      If mItem.StockItemID = vStockItemID Then
        mretval = mItem
        Exit For
      End If
    Next
    Return mretval
  End Function
End Class




