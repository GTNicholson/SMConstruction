''Class Definition - ProductStructure (to ProductStructure)'Generated from Table:ProductStructure
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dmProductStructure : Inherits dmBase
  Implements RTIS.ERPCore.intItemSpecCore

  Private pProductStructureID As Int32
  Private pDescription As String
  Private pProductStructureTypeID As Int32
  Private pNotes As String

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

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean Implements intItemSpecCore.IsAnyDirty
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys() Implements intItemSpecCore.ClearKeys
    'Set Key Values = 0
    ProductStructureID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductStructure)
      .ProductStructureID = ProductStructureID
      .Description = Description
      .ProductStructureTypeID = ProductStructureTypeID
      .Notes = Notes
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Sub CalculateCostAndPrice() Implements intItemSpecCore.CalculateCostAndPrice
    Throw New NotImplementedException()
  End Sub

  Private Function intItemSpecCore_Clone() As Object Implements intItemSpecCore.Clone
    Throw New NotImplementedException()
  End Function


  Public Property ProductStructureID() As Int32
    Get
      Return pProductStructureID
    End Get
    Set(ByVal value As Int32)
      If pProductStructureID <> value Then IsDirty = True
      pProductStructureID = value
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

  Public Property ItemType As Integer Implements intItemSpecCore.ItemType
    Get
      Return eProductType.StructureAF
    End Get
    Set(value As Integer)

    End Set
  End Property

  Public Property MaterialCost As Decimal Implements intItemSpecCore.MaterialCost
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Decimal)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property ProcessCost As Decimal Implements intItemSpecCore.ProcessCost
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Decimal)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property Leadtime As Decimal Implements intItemSpecCore.Leadtime
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Decimal)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property SalesPrice As Decimal Implements intItemSpecCore.SalesPrice
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Decimal)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property Margin As Decimal Implements intItemSpecCore.Margin
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Decimal)
      Throw New NotImplementedException()
    End Set
  End Property

  Public Property ParentID As Integer Implements intItemSpecCore.ParentID
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property

  Private ReadOnly Property intItemSpecCore_IsAnyDirty As Boolean
    Get
      Throw New NotImplementedException()
    End Get
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


