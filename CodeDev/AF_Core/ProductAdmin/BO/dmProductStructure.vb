﻿''Class Definition - ProductStructure (to ProductStructure)'Generated from Table:ProductStructure
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dmProductStructure : Inherits dmProductBase

  Private pProductStructureID As Int32
  Private pProductStructureTypeID As Int32
  Private pNotes As String
  Private pProductBOMs As colProductBOMs

  Private pProductStockItemBOMs As colProductBOMs
  Private pProductWoodBOMs As colProductBOMs
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here

    pProductBOMs = New colProductBOMs
    pProductStockItemBOMs = New colProductBOMs
    pProductWoodBOMs = New colProductBOMs
    pPOFiles = New colFileTrackers

  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()

    pProductStockItemBOMs = Nothing
    pProductWoodBOMs = Nothing
    pPOFiles = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections


      If mAnyDirty = False Then mAnyDirty = pProductStockItemBOMs.IsDirty

      If mAnyDirty = False Then mAnyDirty = pProductWoodBOMs.IsDirty

      If mAnyDirty = False Then mAnyDirty = pPOFiles.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    ProductStructureID = 0

    pProductStockItemBOMs = Nothing
    pProductWoodBOMs = Nothing
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
      .IsGeneric = IsGeneric
      .SalesOrderID = SalesOrderID
      .FullyDefined = FullyDefined
      .Status = Status
      .ProductWoodBOMs = ProductWoodBOMs.Clone
      .ProductStockItemBOMs = ProductStockItemBOMs.Clone
      .POFiles = POFiles.Clone
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

    End Get
  End Property


  Public Overrides Property ProductTypeID As Integer
    Get
      Return eProductType.StructureAF
    End Get
    Set(value As Integer)

    End Set
  End Property



  Public Property ProductStockItemBOMs As colProductBOMs
    Get
      Return pProductStockItemBOMs
    End Get
    Set(value As colProductBOMs)
      pProductStockItemBOMs = value
    End Set
  End Property
  Public Property ProductWoodBOMs As colProductBOMs
    Get
      Return pProductWoodBOMs
    End Get
    Set(value As colProductBOMs)
      pProductWoodBOMs = value
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


