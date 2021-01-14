''Class Definition - CostBook (to CostBook)'Generated from Table:CostBook
Imports RTIS.CommonVB

Public Class dmCostBook : Inherits dmBase
  Implements iValueItem

  Private pCostBookID As Int32
  Private pCostBookName As String
  Private pCostBookDate As DateTime
  Private pIsDefault As Boolean
  Private pDirectLabourCost As Decimal
  Private pDirectLabourMarkUp As Decimal
  Private pOverheadperItem As Decimal

  Private pCostBookEntrys As colCostBookEntrys
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pCostBookEntrys = New colCostBookEntrys
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pCostBookEntrys = Nothing
    MyBase.Finalize()

  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pCostBookEntrys.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    CostBookID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmCostBook)
      .CostBookID = CostBookID
      .CostBookName = CostBookName
      .CostBookDate = CostBookDate
      .IsDefault = IsDefault
      .DirectLabourCost = DirectLabourCost
      .DirectLabourMarkUp = DirectLabourMarkUp
      .OverheadperItem = OverheadperItem
      .CostBookEntrys = CostBookEntrys
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property CostBookID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pCostBookID
    End Get
    Set(ByVal value As Int32)
      If pCostBookID <> value Then IsDirty = True
      pCostBookID = value
    End Set
  End Property

  Public Property CostBookName() As String Implements iValueItem.DisplayValue
    Get
      Return pCostBookName
    End Get
    Set(ByVal value As String)
      If pCostBookName <> value Then IsDirty = True
      pCostBookName = value
    End Set
  End Property

  Public Property CostBookDate() As DateTime
    Get
      Return pCostBookDate
    End Get
    Set(ByVal value As DateTime)
      If pCostBookDate <> value Then IsDirty = True
      pCostBookDate = value
    End Set
  End Property

  Public Property IsDefault() As Boolean
    Get
      Return pIsDefault
    End Get
    Set(ByVal value As Boolean)
      If pIsDefault <> value Then IsDirty = True
      pIsDefault = value
    End Set
  End Property

  Public Property DirectLabourCost() As Decimal
    Get
      Return pDirectLabourCost
    End Get
    Set(ByVal value As Decimal)
      If pDirectLabourCost <> value Then IsDirty = True
      pDirectLabourCost = value
    End Set
  End Property

  Public Property DirectLabourMarkUp() As Decimal
    Get
      Return pDirectLabourMarkUp
    End Get
    Set(ByVal value As Decimal)
      If pDirectLabourMarkUp <> value Then IsDirty = True
      pDirectLabourMarkUp = value
    End Set
  End Property

  Public Property OverheadperItem() As Decimal
    Get
      Return pOverheadperItem
    End Get
    Set(ByVal value As Decimal)
      If pOverheadperItem <> value Then IsDirty = True
      pOverheadperItem = value
    End Set
  End Property

  Public Property CostBookEntrys As colCostBookEntrys
    Get
      Return pCostBookEntrys
    End Get
    Set(value As colCostBookEntrys)
      pCostBookEntrys = value
    End Set
  End Property





  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - CostBook (to CostBook)'Generated from Table:CostBook

'Private pCostBooks As colCostBooks
'Public Property CostBooks() As colCostBooks
'  Get
'    Return pCostBooks
'  End Get
'  Set(ByVal value As colCostBooks)
'    pCostBooks = value
'  End Set
'End Property

'  pCostBooks = New colCostBooks 'Add to New
'  pCostBooks = Nothing 'Add to Finalize
'  .CostBooks = CostBooks.Clone 'Add to CloneTo
'  CostBooks.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = CostBooks.IsDirty 'Add to IsAnyDirty

Public Class colCostBooks : Inherits colBase(Of dmCostBook)

  Public Overrides Function IndexFromKey(ByVal vCostBookID As Integer) As Integer
    Dim mItem As dmCostBook
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.CostBookID = vCostBookID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmCostBook))
    MyBase.New(vList)
  End Sub

End Class


