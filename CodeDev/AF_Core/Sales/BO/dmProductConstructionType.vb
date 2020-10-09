''Class Definition - ProductConstructionType (to ProductConstructionType)'Generated from Table:ProductConstructionType
Imports RTIS.CommonVB

Public Class dmProductConstructionType : Inherits dmBase
  Implements iValueItem

  Private pProductConstructionTypeID As Int32
  Private pDescription As String
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
    ProductConstructionTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductConstructionType)
      .ProductConstructionTypeID = ProductConstructionTypeID
      .Description = Description
      .Abbreviation = Abbreviation
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductConstructionTypeID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pProductConstructionTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductConstructionTypeID <> value Then IsDirty = True
      pProductConstructionTypeID = value
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



''Collection Definition - ProductConstructionType (to ProductConstructionType)'Generated from Table:ProductConstructionType

'Private pProductConstructionTypes As colProductConstructionTypes
'Public Property ProductConstructionTypes() As colProductConstructionTypes
'  Get
'    Return pProductConstructionTypes
'  End Get
'  Set(ByVal value As colProductConstructionTypes)
'    pProductConstructionTypes = value
'  End Set
'End Property

'  pProductConstructionTypes = New colProductConstructionTypes 'Add to New
'  pProductConstructionTypes = Nothing 'Add to Finalize
'  .ProductConstructionTypes = ProductConstructionTypes.Clone 'Add to CloneTo
'  ProductConstructionTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductConstructionTypes.IsDirty 'Add to IsAnyDirty

Public Class colProductConstructionTypes : Inherits colBase(Of dmProductConstructionType)

  Public Overrides Function IndexFromKey(ByVal vProductConstructionTypeID As Integer) As Integer
    Dim mItem As dmProductConstructionType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductConstructionTypeID = vProductConstructionTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductConstructionType))
    MyBase.New(vList)
  End Sub

End Class


