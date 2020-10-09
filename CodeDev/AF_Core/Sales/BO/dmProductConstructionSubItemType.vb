''Class Definition - ProductConstructionSubType (to ProductConstructionSubType)'Generated from Table:ProductConstructionSubType
Imports RTIS.CommonVB

Public Class dmProductConstructionSubType : Inherits dmBase
  Implements iValueItem

  Private pProductConstructionSubTypeID As Int32
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
    ProductConstructionSubTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductConstructionSubType)
      .ProductConstructionSubTypeID = ProductConstructionSubTypeID
      .ProductConstructionTypeID = ProductConstructionTypeID
      .Description = Description
      .Abbreviation = Abbreviation
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductConstructionSubTypeID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pProductConstructionSubTypeID
    End Get
    Set(ByVal value As Int32)
      If pProductConstructionSubTypeID <> value Then IsDirty = True
      pProductConstructionSubTypeID = value
    End Set
  End Property

  Public Property ProductConstructionTypeID() As Int32
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



''Collection Definition - ProductConstructionSubType (to ProductConstructionSubType)'Generated from Table:ProductConstructionSubType

'Private pProductConstructionSubTypes As colProductConstructionSubTypes
'Public Property ProductConstructionSubTypes() As colProductConstructionSubTypes
'  Get
'    Return pProductConstructionSubTypes
'  End Get
'  Set(ByVal value As colProductConstructionSubTypes)
'    pProductConstructionSubTypes = value
'  End Set
'End Property

'  pProductConstructionSubTypes = New colProductConstructionSubTypes 'Add to New
'  pProductConstructionSubTypes = Nothing 'Add to Finalize
'  .ProductConstructionSubTypes = ProductConstructionSubTypes.Clone 'Add to CloneTo
'  ProductConstructionSubTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductConstructionSubTypes.IsDirty 'Add to IsAnyDirty

Public Class colProductConstructionSubTypes : Inherits colBase(Of dmProductConstructionSubType)

  Public Overrides Function IndexFromKey(ByVal vProductConstructionSubTypeID As Integer) As Integer
    Dim mItem As dmProductConstructionSubType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductConstructionSubTypeID = vProductConstructionSubTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductConstructionSubType))
    MyBase.New(vList)
  End Sub

End Class