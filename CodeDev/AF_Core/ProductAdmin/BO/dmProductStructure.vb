''Class Definition - ProductStructure (to ProductStructure)'Generated from Table:ProductStructure
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dmProductStructure : Inherits dmProductBase

  Private pProductStructureID As Int32
  Private pProductStructureTypeID As Int32
  Private pNotes As String
  Private pStockItemBOMs As colStockItemBOMs
  Private pProductBOMs As colProductBOMs

  Private pMaterialRequirements As colMaterialRequirements
  Private pWoodMaterialRequirements As colMaterialRequirements

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pStockItemBOMs = New colStockItemBOMs
    pProductBOMs = New colProductBOMs
    pMaterialRequirements = New colMaterialRequirements
    pWoodMaterialRequirements = New colMaterialRequirements
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pStockItemBOMs = Nothing
    pMaterialRequirements = Nothing
    pWoodMaterialRequirements = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pStockItemBOMs.IsDirty

      If mAnyDirty = False Then mAnyDirty = pMaterialRequirements.IsDirty

      If mAnyDirty = False Then mAnyDirty = pWoodMaterialRequirements.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    ProductStructureID = 0
    pStockItemBOMs = Nothing
    pMaterialRequirements = Nothing
    pWoodMaterialRequirements = Nothing
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductStructure)
      .ProductStructureID = ProductStructureID
      .Description = Description
      .Code = Code
      .ProductStructureTypeID = ProductStructureTypeID
      .Notes = Notes
      .SubItemType = SubItemType
      .DrawingFileName = DrawingFileName
      .StockItemBOMs = StockItemBOMs
      .IsGeneric = IsGeneric
      .SalesOrderID = SalesOrderID
      .FullyDefined = FullyDefined


      .ProductBOMs = ProductBOMs
      .WoodMaterialRequirements = WoodMaterialRequirements.Clone
      .MaterialRequirements = MaterialRequirements.Clone
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Overrides Function Clone() As Object
    Dim mRetVal As New dmProductStructure
    CloneTo(mRetVal)
    Return mRetVal
  End Function

  Public Overrides Sub CalculateCostAndPrice()

  End Sub

  Public Property ProductStructureID() As Int32
    Get
      Return pID
    End Get
    Set(ByVal value As Int32)
      If pID <> value Then IsDirty = True
      pID = value
    End Set
  End Property

  Public Overrides Property ID As Integer
    Get
      Return ProductStructureID
    End Get
    Set(ByVal value As Int32)
      ProductStructureID = value
    End Set
  End Property


  Public Property ProductStructureTypeID() As Int32
    Get
      Return pProductStructureTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductStructureTypeID <> value Then IsDirty = True
      pProductStructureTypeID = value
    End Set
  End Property

  Public Property Notes() As String
    Get
      Return pNotes
    End Get
    Set(ByVal value As String)
      If pNotes <> value Then IsDirty = True
      pNotes = value
    End Set
  End Property


  Private ReadOnly Property intItemSpecCore_IsAnyDirty As Boolean
    Get
      Throw New NotImplementedException()
    End Get
  End Property


  Public Overrides Property ProductTypeID As Integer
    Get
      Return eProductType.StructureAF
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Overrides Property StockItemBOMs As colStockItemBOMs
    Get
      Return pStockItemBOMs
    End Get
    Set(value As colStockItemBOMs)
      pStockItemBOMs = value
    End Set
  End Property

  Public Overrides Property ProductBOMs As colProductBOMs
    Get
      Return pProductBOMs
    End Get
    Set(value As colProductBOMs)
      pProductBOMs = value
    End Set
  End Property

  Public Property MaterialRequirements As colMaterialRequirements
    Get
      Return pMaterialRequirements
    End Get
    Set(value As colMaterialRequirements)
      pMaterialRequirements = value
    End Set
  End Property
  Public Property WoodMaterialRequirements As colMaterialRequirements
    Get
      Return pWoodMaterialRequirements
    End Get
    Set(value As colMaterialRequirements)
      pWoodMaterialRequirements = value
    End Set
  End Property

End Class



''Collection Definition - ProductStructure (to ProductStructure)'Generated from Table:ProductStructure

'Private pProductStructures As colProductStructures
'Public Property ProductStructures() As colProductStructures
'  Get
'    Return pProductStructures
'  End Get
'  Set(ByVal value As colProductStructures)
'    pProductStructures = value
'  End Set
'End Property

'  pProductStructures = New colProductStructures 'Add to New
'  pProductStructures = Nothing 'Add to Finalize
'  .ProductStructures = ProductStructures.Clone 'Add to CloneTo
'  ProductStructures.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductStructures.IsDirty 'Add to IsAnyDirty

Public Class colProductStructures : Inherits colBase(Of dmProductStructure)

  Public Overrides Function IndexFromKey(ByVal vProductStructureID As Integer) As Integer
    Dim mItem As dmProductStructure
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductStructureID = vProductStructureID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductStructure))
    MyBase.New(vList)
  End Sub

End Class


