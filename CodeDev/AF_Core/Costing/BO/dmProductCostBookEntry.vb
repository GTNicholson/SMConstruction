''Class Definition - ProductCostBookEntry (to ProductCostBookEntry)'Generated from Table:ProductCostBookEntry
Imports RTIS.CommonVB

Public Class dmProductCostBookEntry : Inherits dmBase
  Private pProductCostBookEntryID As Int32
  Private pCostBookID As Int32
  Private pProductID As Int32
  Private pProductTypeID As Int32
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
    ProductCostBookEntryID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductCostBookEntry)
      .ProductCostBookEntryID = ProductCostBookEntryID
      .CostBookID = CostBookID
      .ProductID = ProductID
      .ProductTypeID = ProductTypeID
      .Cost = Cost
      .CostUnit = CostUnit
      .MinCost = MinCost
      .RetailPrice = RetailPrice

      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductCostBookEntryID() As Int32
    Get
      Return pProductCostBookEntryID
    End Get
    Set(ByVal value As Int32)
      If pProductCostBookEntryID <> value Then IsDirty = True
      pProductCostBookEntryID = value
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

  Public Property ProductID() As Int32
    Get
      Return pProductID
    End Get
    Set(ByVal value As Int32)
      If pProductID <> value Then IsDirty = True
      pProductID = value
    End Set
  End Property




  Public Property ProductTypeID() As Int32
    Get
      Return pProductTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductTypeID <> value Then IsDirty = True
      pProductTypeID = value
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



''Collection Definition - ProductCostBookEntry (to ProductCostBookEntry)'Generated from Table:ProductCostBookEntry

'Private pProductCostBookEntrys As colProductCostBookEntrys
'Public Property ProductCostBookEntrys() As colProductCostBookEntrys
'  Get
'    Return pProductCostBookEntrys
'  End Get
'  Set(ByVal value As colProductCostBookEntrys)
'    pProductCostBookEntrys = value
'  End Set
'End Property

'  pProductCostBookEntrys = New colProductCostBookEntrys 'Add to New
'  pProductCostBookEntrys = Nothing 'Add to Finalize
'  .ProductCostBookEntrys = ProductCostBookEntrys.Clone 'Add to CloneTo
'  ProductCostBookEntrys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductCostBookEntrys.IsDirty 'Add to IsAnyDirty

Public Class colProductCostBookEntrys : Inherits colBase(Of dmProductCostBookEntry)

  Public Function IndexFromProductID_ItemTypeID(vProductID As Integer, ByVal vItemTypeID As Integer) As Integer
    Dim mItem As dmProductCostBookEntry
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1

      If mItem.ProductID = vProductID And mItem.ProductTypeID = vItemTypeID Then
        mIndex = mCount
        Exit For
      End If

    Next
    Return mIndex
  End Function

  Public Overrides Function IndexFromKey(ByVal vProductCostBookEntryID As Integer) As Integer
    Dim mItem As dmProductCostBookEntry
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductCostBookEntryID = vProductCostBookEntryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductCostBookEntry))
    MyBase.New(vList)
  End Sub

End Class

