''Class Definition - StockItem (to StockItem)'Generated from Table:StockItem
Imports RTIS.CommonVB

Public Class dmStockItem : Inherits dmBase
  Private pStockItemID As Int32
  Private pStockCode As String
  Private pCategory As Byte
  Private pItemType As Byte
  Private pSpecies As Int32
  Private pColour As String
  Private pPartNo As String
  Private pLength As Decimal
  Private pWidth As Decimal
  Private pThickness As Decimal
  Private pDescription As String
  Private pStockQuantity As Decimal
  Private pDefaultSupplier As Int32
  Private pFinish As Byte
  Private pShortDescription As String
  Private pSubItemType As Int32
  Private pStockFinanceCategoryID As Int32
  Private pExtraInfo As String
  Private pHanding As Byte
  Private pOppositeStockItemID As Int32
  Private pIsGeneric As Boolean
  Private pTemplateStockItemID As Int32
  Private pInactive As Boolean
  Private pInterdenStockItemID As Int32
  Private pProjectID As Int32
  Private ptmpIsFullyLoadedDown As Boolean

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
    StockItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStockItem)
      .StockItemID = StockItemID
      .StockCode = StockCode
      .Category = Category
      .ItemType = ItemType
      .Species = Species
      .Colour = Colour
      .PartNo = PartNo
      .Length = Length
      .Width = Width
      .Thickness = Thickness
      .Description = Description
      .StockQuantity = StockQuantity
      .DefaultSupplier = DefaultSupplier
      .Finish = Finish
      .ShortDescription = ShortDescription
      .SubItemType = SubItemType
      .StockFinanceCategoryID = StockFinanceCategoryID
      .ExtraInfo = ExtraInfo
      .Handing = Handing
      .OppositeStockItemID = OppositeStockItemID
      .IsGeneric = IsGeneric
      .TemplateStockItemID = TemplateStockItemID
      .Inactive = Inactive
      .InterdenStockItemID = InterdenStockItemID
      .ProjectID = ProjectID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property StockCode() As String
    Get
      Return pStockCode
    End Get
    Set(ByVal value As String)
      If pStockCode <> value Then IsDirty = True
      pStockCode = value
    End Set
  End Property

  Public Property Category() As Byte
    Get
      Return pCategory
    End Get
    Set(ByVal value As Byte)
      If pCategory <> value Then IsDirty = True
      pCategory = value
    End Set
  End Property

  Public Property ItemType() As Byte
    Get
      Return pItemType
    End Get
    Set(ByVal value As Byte)
      If pItemType <> value Then IsDirty = True
      pItemType = value
    End Set
  End Property

  Public Property Species() As Int32
    Get
      Return pSpecies
    End Get
    Set(ByVal value As Int32)
      If pSpecies <> value Then IsDirty = True
      pSpecies = value
    End Set
  End Property

  Public Property Colour() As String
    Get
      Return pColour
    End Get
    Set(ByVal value As String)
      If pColour <> value Then IsDirty = True
      pColour = value
    End Set
  End Property

  Public Property PartNo() As String
    Get
      Return pPartNo
    End Get
    Set(ByVal value As String)
      If pPartNo <> value Then IsDirty = True
      pPartNo = value
    End Set
  End Property

  Public Property Length() As Decimal
    Get
      Return pLength
    End Get
    Set(ByVal value As Decimal)
      If pLength <> value Then IsDirty = True
      pLength = value
    End Set
  End Property

  Public Property Width() As Decimal
    Get
      Return pWidth
    End Get
    Set(ByVal value As Decimal)
      If pWidth <> value Then IsDirty = True
      pWidth = value
    End Set
  End Property

  Public Property Thickness() As Decimal
    Get
      Return pThickness
    End Get
    Set(ByVal value As Decimal)
      If pThickness <> value Then IsDirty = True
      pThickness = value
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

  Public Property StockQuantity() As Decimal
    Get
      Return pStockQuantity
    End Get
    Set(ByVal value As Decimal)
      If pStockQuantity <> value Then IsDirty = True
      pStockQuantity = value
    End Set
  End Property

  Public Property DefaultSupplier() As Int32
    Get
      Return pDefaultSupplier
    End Get
    Set(ByVal value As Int32)
      If pDefaultSupplier <> value Then IsDirty = True
      pDefaultSupplier = value
    End Set
  End Property

  Public Property Finish() As Byte
    Get
      Return pFinish
    End Get
    Set(ByVal value As Byte)
      If pFinish <> value Then IsDirty = True
      pFinish = value
    End Set
  End Property

  Public Property ShortDescription() As String
    Get
      Return pShortDescription
    End Get
    Set(ByVal value As String)
      If pShortDescription <> value Then IsDirty = True
      pShortDescription = value
    End Set
  End Property

  Public Property SubItemType() As Int32
    Get
      Return pSubItemType
    End Get
    Set(ByVal value As Int32)
      If pSubItemType <> value Then IsDirty = True
      pSubItemType = value
    End Set
  End Property

  Public Property StockFinanceCategoryID() As Int32
    Get
      Return pStockFinanceCategoryID
    End Get
    Set(ByVal value As Int32)
      If pStockFinanceCategoryID <> value Then IsDirty = True
      pStockFinanceCategoryID = value
    End Set
  End Property

  Public Property ExtraInfo() As String
    Get
      Return pExtraInfo
    End Get
    Set(ByVal value As String)
      If pExtraInfo <> value Then IsDirty = True
      pExtraInfo = value
    End Set
  End Property

  Public Property Handing() As Byte
    Get
      Return pHanding
    End Get
    Set(ByVal value As Byte)
      If pHanding <> value Then IsDirty = True
      pHanding = value
    End Set
  End Property

  Public Property OppositeStockItemID() As Int32
    Get
      Return pOppositeStockItemID
    End Get
    Set(ByVal value As Int32)
      If pOppositeStockItemID <> value Then IsDirty = True
      pOppositeStockItemID = value
    End Set
  End Property

  Public Property IsGeneric() As Boolean
    Get
      Return pIsGeneric
    End Get
    Set(ByVal value As Boolean)
      If pIsGeneric <> value Then IsDirty = True
      pIsGeneric = value
    End Set
  End Property

  Public Property TemplateStockItemID() As Int32
    Get
      Return pTemplateStockItemID
    End Get
    Set(ByVal value As Int32)
      If pTemplateStockItemID <> value Then IsDirty = True
      pTemplateStockItemID = value
    End Set
  End Property

  Public Property Inactive() As Boolean
    Get
      Return pInactive
    End Get
    Set(ByVal value As Boolean)
      If pInactive <> value Then IsDirty = True
      pInactive = value
    End Set
  End Property

  Public Property InterdenStockItemID() As Int32
    Get
      Return pInterdenStockItemID
    End Get
    Set(ByVal value As Int32)
      If pInterdenStockItemID <> value Then IsDirty = True
      pInterdenStockItemID = value
    End Set
  End Property

  Public Property ProjectID() As Int32
    Get
      Return pProjectID
    End Get
    Set(ByVal value As Int32)
      If pProjectID <> value Then IsDirty = True
      pProjectID = value
    End Set
  End Property

  Public Property tmpIsFullyLoadedDown() As Boolean
    Get
      tmpIsFullyLoadedDown = ptmpIsFullyLoadedDown
    End Get
    Set(ByVal value As Boolean)
      ptmpIsFullyLoadedDown = value
    End Set
  End Property
End Class



''Collection Definition - StockItem (to StockItem)'Generated from Table:StockItem

'Private pStockItems As colStockItems
'Public Property StockItems() As colStockItems
'  Get
'    Return pStockItems
'  End Get
'  Set(ByVal value As colStockItems)
'    pStockItems = value
'  End Set
'End Property

'  pStockItems = New colStockItems 'Add to New
'  pStockItems = Nothing 'Add to Finalize
'  .StockItems = StockItems.Clone 'Add to CloneTo
'  StockItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StockItems.IsDirty 'Add to IsAnyDirty

Public Class colStockItems : Inherits colBase(Of dmStockItem)

  Public Overrides Function IndexFromKey(ByVal vStockItemID As Integer) As Integer
    Dim mItem As dmStockItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StockItemID = vStockItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStockItem))
    MyBase.New(vList)
  End Sub

End Class




