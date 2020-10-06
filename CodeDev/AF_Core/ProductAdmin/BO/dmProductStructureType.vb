''Class Definition - ProductStructureType (to ProductStructureType)'Generated from Table:ProductStructureType
Imports RTIS.CommonVB

Public Class dmProductStructureType : Inherits dmBase
  Implements iValueItem

  Private pProductStructureTypeID As Int32
  Private pDescription As String

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
    ProductStructureTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductStructureType)
      .ProductStructureTypeID = ProductStructureTypeID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductStructureTypeID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pProductStructureTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductStructureTypeID <> value Then IsDirty = True
      pProductStructureTypeID = value
    End Set
  End Property

  Public Property Description() As String Implements iValueItem.DisplayValue
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property


  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - ProductStructureType (to ProductStructureType)'Generated from Table:ProductStructureType

'Private pProductStructureTypes As colProductStructureTypes
'Public Property ProductStructureTypes() As colProductStructureTypes
'  Get
'    Return pProductStructureTypes
'  End Get
'  Set(ByVal value As colProductStructureTypes)
'    pProductStructureTypes = value
'  End Set
'End Property

'  pProductStructureTypes = New colProductStructureTypes 'Add to New
'  pProductStructureTypes = Nothing 'Add to Finalize
'  .ProductStructureTypes = ProductStructureTypes.Clone 'Add to CloneTo
'  ProductStructureTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductStructureTypes.IsDirty 'Add to IsAnyDirty

Public Class colProductStructureTypes : Inherits colBase(Of dmProductStructureType)

  Public Overrides Function IndexFromKey(ByVal vProductStructureTypeID As Integer) As Integer
    Dim mItem As dmProductStructureType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductStructureTypeID = vProductStructureTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductStructureType))
    MyBase.New(vList)
  End Sub

End Class


