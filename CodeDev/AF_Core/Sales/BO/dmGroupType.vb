''Class Definition - GroupType (to GroupType)'Generated from Table:GroupType
Imports RTIS.CommonVB

Public Class dmGroupType : Inherits dmBase
  Implements iValueItem

  Private pGroupTypeID As Int32
  Private pName As String

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
    GroupTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmGroupType)
      .GroupTypeID = GroupTypeID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property GroupTypeID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pGroupTypeID
    End Get
    Set(ByVal value As Int32)
      If pGroupTypeID <> value Then IsDirty = True
      pGroupTypeID = value
    End Set
  End Property

  Public Property Description() As String Implements iValueItem.DisplayValue
    Get
      Return pName
    End Get
    Set(ByVal value As String)
      If pName <> value Then IsDirty = True
      pName = value
    End Set
  End Property



  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get

    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - GroupType (to GroupType)'Generated from Table:GroupType

'Private pGroupTypes As colGroupTypes
'Public Property GroupTypes() As colGroupTypes
'  Get
'    Return pGroupTypes
'  End Get
'  Set(ByVal value As colGroupTypes)
'    pGroupTypes = value
'  End Set
'End Property

'  pGroupTypes = New colGroupTypes 'Add to New
'  pGroupTypes = Nothing 'Add to Finalize
'  .GroupTypes = GroupTypes.Clone 'Add to CloneTo
'  GroupTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = GroupTypes.IsDirty 'Add to IsAnyDirty

Public Class colGroupTypes : Inherits colBase(Of dmGroupType)

  Public Overrides Function IndexFromKey(ByVal vGroupTypeID As Integer) As Integer
    Dim mItem As dmGroupType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.GroupTypeID = vGroupTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmGroupType))
    MyBase.New(vList)
  End Sub

End Class


