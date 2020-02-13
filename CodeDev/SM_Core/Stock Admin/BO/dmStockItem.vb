''Class Definition - StockItem (to StockItem)'Generated from Table:StockItem
Imports RTIS.CommonVB
Imports RTIS.ERPStock

Public Class dmStockItem : Inherits dmBase
  Implements RTIS.ERPStock.intStockItemDef

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
  Private pStdCost As Decimal
  Private pStdImportCost As Decimal
  Private pImageFile As String
  Private pASISID As Integer
  Private pSupplier As dmSupplier

  Private ptmpIsFullyLoadedDown As Boolean
  Private pOutputDocuments As colOutputDocuments

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    pSupplier = New dmSupplier
    pOutputDocuments = New colOutputDocuments
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Property OutputDocuments As colOutputDocuments
    Get
      Return pOutputDocuments
    End Get
    Set(value As colOutputDocuments)
      pOutputDocuments = value
    End Set
  End Property

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pOutputDocuments.IsDirty

      IsAnyDirty = mAnyDirty

    End Get
  End Property

  Public Property Supplier As dmSupplier
    Get
      Return pSupplier
    End Get
    Set(value As dmSupplier)
      pSupplier = value
    End Set
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
      .StdCost = StdCost
      .StdImportCost = StdImportCost
      .ImageFile = ImageFile

      Supplier = Supplier.Clone
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Function SIDefSpecEquals(vStockItemDef As intStockItemDef) As Boolean Implements intStockItemDef.SIDefSpecEquals
    Throw New NotImplementedException()
  End Function

  Public Property StockItemID() As Int32 Implements intStockItemDef.StockItemID
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property StdImportCost() As Decimal
    Get
      Return pStdImportCost
    End Get
    Set(ByVal value As Decimal)
      If pStdImportCost <> value Then IsDirty = True
      pStdImportCost = value
    End Set
  End Property

  Public Property ImageFile() As String
    Get
      Return pImageFile
    End Get
    Set(ByVal value As String)
      If pImageFile <> value Then IsDirty = True
      pImageFile = value
    End Set
  End Property

  Public Property ASISID() As Integer
    Get
      Return pASISID
    End Get
    Set(ByVal value As Integer)
      If pASISID <> value Then IsDirty = True
      pASISID = value
    End Set
  End Property


  Public Property StockCode() As String Implements intStockItemDef.StockCode
    Get
      Return pStockCode
    End Get
    Set(ByVal value As String)
      If pStockCode <> value Then IsDirty = True
      pStockCode = value
    End Set
  End Property

  Public Property Category() As Integer Implements intStockItemDef.StockCategory
    Get
      Return pCategory
    End Get
    Set(ByVal value As Integer)
      If pCategory <> value Then IsDirty = True
      pCategory = value
    End Set
  End Property

  Public Property ItemType() As Short Implements intStockItemDef.StockItemType
    Get
      Return pItemType
    End Get
    Set(ByVal value As Short)
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

  Public Property Length() As Decimal Implements intStockItemDef.Length
    Get
      Return pLength
    End Get
    Set(ByVal value As Decimal)
      If pLength <> value Then IsDirty = True
      pLength = value
    End Set
  End Property

  Public Property Width() As Decimal Implements intStockItemDef.Width
    Get
      Return pWidth
    End Get
    Set(ByVal value As Decimal)
      If pWidth <> value Then IsDirty = True
      pWidth = value
    End Set
  End Property

  Public Property Thickness() As Decimal Implements intStockItemDef.Thickness
    Get
      Return pThickness
    End Get
    Set(ByVal value As Decimal)
      If pThickness <> value Then IsDirty = True
      pThickness = value
    End Set
  End Property

  Public Property Description() As String Implements intStockItemDef.SIDescription
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



  Public Property ComponentType As Short Implements intStockItemDef.ComponentType
    Get
     '' Throw New NotImplementedException()
    End Get
    Set(value As Short)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property StockSubCategory As Integer Implements intStockItemDef.StockSubCategory
    Get
     '' Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property


  Public Property AuxCode As String Implements intStockItemDef.AuxCode
    Get
      '' Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property


  Public Property AttributeID As Integer Implements intStockItemDef.AttributeID
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property AttributeValue As String Implements intStockItemDef.AttributeValue
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property OwnerID As Integer Implements intStockItemDef.OwnerID
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property MaterialID As Integer Implements intStockItemDef.MaterialID
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property StockUnitTypeENUM As Integer Implements intStockItemDef.StockUnitTypeENUM
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property DefaultStockLocation As String Implements intStockItemDef.DefaultStockLocation
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property DateStart As Date Implements intStockItemDef.DateStart
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Date)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property DateEnd As Date Implements intStockItemDef.DateEnd
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Date)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property DateEntered As Date Implements intStockItemDef.DateEntered
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Date)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property DateAmended As Date Implements intStockItemDef.DateAmended
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Date)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property StockItemStatus As Byte Implements intStockItemDef.StockItemStatus
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Byte)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property SerialNo As String Implements intStockItemDef.SerialNo
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property IsProvisional As Boolean Implements intStockItemDef.IsProvisional
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Boolean)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property PricingUnit As Byte Implements intStockItemDef.PricingUnit
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Byte)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property StdCost As Decimal Implements intStockItemDef.StdCost
    Get
      Return pStdCost
    End Get
    Set(value As Decimal)
      If pStdCost <> value Then pIsDirty = True
      pStdCost = value
    End Set
  End Property

  Public Property StdPrice As Decimal Implements intStockItemDef.StdPrice
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Decimal)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property IsTemplate As Boolean Implements intStockItemDef.IsTemplate
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Boolean)
      Throw New NotImplementedException()
    End Set
  End Property

  Private Property intStockItemDef_TemplateStockItemID As Integer Implements intStockItemDef.TemplateStockItemID
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property Notes As String Implements intStockItemDef.Notes
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property IsNonDefaultMatReq As Boolean Implements intStockItemDef.IsNonDefaultMatReq
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Boolean)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property ProcessItemOperations As IList Implements intStockItemDef.ProcessItemOperations
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As IList)
      Throw New NotImplementedException()
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




