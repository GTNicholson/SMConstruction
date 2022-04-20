''Class Definition - StockItemManufacturer (to StockItemManufacturer)'Generated from Table:StockItemManufacturer
Imports RTIS.CommonVB

Public Class dmStockItemManufacturer : Inherits dmBase
  Implements iValueItem

  Private pStockItemManufacturerID As Int32
  Private pName As String
  Private pAbbreviation As String

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
    StockItemManufacturerID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItemManufacturer)
      .StockItemManufacturerID = StockItemManufacturerID
      .Name = Name
      .Abbreviation = Abbreviation
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemManufacturerID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pStockItemManufacturerID
    End Get
    Set(ByVal value As Int32)
      If pStockItemManufacturerID <> value Then IsDirty = True
      pStockItemManufacturerID = value
    End Set
  End Property

  Public Property Name() As String Implements iValueItem.DisplayValue
    Get
      Return pName
    End Get
    Set(ByVal value As String)
      If pName <> value Then IsDirty = True
      pName = value
    End Set
  End Property

  Public Property Abbreviation() As String
    Get
      Return pAbbreviation
    End Get
    Set(ByVal value As String)
      If pAbbreviation <> value Then IsDirty = True
      pAbbreviation = value
    End Set
  End Property


  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - StockItemManufacturer (to StockItemManufacturer)'Generated from Table:StockItemManufacturer

'Private pStockItemManufacturers As colStockItemManufacturers
'Public Property StockItemManufacturers() As colStockItemManufacturers
'  Get
'    Return pStockItemManufacturers
'  End Get
'  Set(ByVal value As colStockItemManufacturers)
'    pStockItemManufacturers = value
'  End Set
'End Property

'  pStockItemManufacturers = New colStockItemManufacturers 'Add to New
'  pStockItemManufacturers = Nothing 'Add to Finalize
'  .StockItemManufacturers = StockItemManufacturers.Clone 'Add to CloneTo
'  StockItemManufacturers.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItemManufacturers.IsDirty 'Add to IsAnyDirty

Public Class colStockItemManufacturers : Inherits colBase(Of dmStockItemManufacturer)

  Public Overrides Function IndexFromKey(ByVal vStockItemManufacturerID As Integer) As Integer
    Dim mItem As dmStockItemManufacturer
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemManufacturerID = vStockItemManufacturerID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItemManufacturer))
    MyBase.New(vList)
  End Sub

End Class



