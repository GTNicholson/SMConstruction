''Class Definition - StockItemType (to StockItemType)'Generated from Table:StockItemType
Imports RTIS.CommonVB

Public Class dmStockItemType : Inherits dmBase
  Private pStockItemTypeID As Int32
  Private pDisplayOrder As Int32
  Private pAbbreviation As String
  Private pDescription As String
  Private pValue As Int32
  Private pArchiveOnly As Boolean
  Private pCategory As Int32

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
    StockItemTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItemType)
      .StockItemTypeID = StockItemTypeID
      .DisplayOrder = DisplayOrder
      .Abbreviation = Abbreviation
      .Description = Description
      .Value = Value
      .ArchiveOnly = ArchiveOnly
      .Category = Category
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemTypeID() As Int32
    Get
      Return pStockItemTypeID
    End Get
    Set(ByVal value As Int32)
      If pStockItemTypeID <> value Then IsDirty = True
      pStockItemTypeID = value
    End Set
  End Property

  Public Property DisplayOrder() As Int32
    Get
      Return pDisplayOrder
    End Get
    Set(ByVal value As Int32)
      If pDisplayOrder <> value Then IsDirty = True
      pDisplayOrder = value
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

  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property Value() As Int32
    Get
      Return pValue
    End Get
    Set(ByVal value As Int32)
      If pValue <> value Then IsDirty = True
      pValue = value
    End Set
  End Property

  Public Property ArchiveOnly() As Boolean
    Get
      Return pArchiveOnly
    End Get
    Set(ByVal value As Boolean)
      If pArchiveOnly <> value Then IsDirty = True
      pArchiveOnly = value
    End Set
  End Property

  Public Property Category() As Int32
    Get
      Return pCategory
    End Get
    Set(ByVal value As Int32)
      If pCategory <> value Then IsDirty = True
      pCategory = value
    End Set
  End Property


End Class



''Collection Definition - StockItemType (to StockItemType)'Generated from Table:StockItemType

'Private pStockItemTypes As colStockItemTypes
'Public Property StockItemTypes() As colStockItemTypes
'  Get
'    Return pStockItemTypes
'  End Get
'  Set(ByVal value As colStockItemTypes)
'    pStockItemTypes = value
'  End Set
'End Property

'  pStockItemTypes = New colStockItemTypes 'Add to New
'  pStockItemTypes = Nothing 'Add to Finalize
'  .StockItemTypes = StockItemTypes.Clone 'Add to CloneTo
'  StockItemTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItemTypes.IsDirty 'Add to IsAnyDirty

Public Class colStockItemTypes : Inherits colBase(Of dmStockItemType)

  Public Overrides Function IndexFromKey(ByVal vStockItemTypeID As Integer) As Integer
    Dim mItem As dmStockItemType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemTypeID = vStockItemTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItemType))
    MyBase.New(vList)
  End Sub

End Class


