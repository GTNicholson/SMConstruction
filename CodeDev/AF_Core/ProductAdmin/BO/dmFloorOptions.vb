''Class Definition - FloorOptions (to FloorOptions)'Generated from Table:FloorOptions
Imports RTIS.CommonVB

Public Class dmFloorOptions : Inherits dmBase
  Implements iValueItem

  Private pFloorOptionsID As Int32
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
    FloorOptionsID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmFloorOptions)
      .FloorOptionsID = FloorOptionsID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property FloorOptionsID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pFloorOptionsID
    End Get
    Set(ByVal value As Int32)
      If pFloorOptionsID <> value Then IsDirty = True
      pFloorOptionsID = value
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



''Collection Definition - FloorOptions (to FloorOptions)'Generated from Table:FloorOptions

'Private pFloorOptionss As colFloorOptionss
'Public Property FloorOptionss() As colFloorOptionss
'  Get
'    Return pFloorOptionss
'  End Get
'  Set(ByVal value As colFloorOptionss)
'    pFloorOptionss = value
'  End Set
'End Property

'  pFloorOptionss = New colFloorOptionss 'Add to New
'  pFloorOptionss = Nothing 'Add to Finalize
'  .FloorOptionss = FloorOptionss.Clone 'Add to CloneTo
'  FloorOptionss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = FloorOptionss.IsDirty 'Add to IsAnyDirty

Public Class colFloorOptionss : Inherits colBase(Of dmFloorOptions)

  Public Overrides Function IndexFromKey(ByVal vFloorOptionsID As Integer) As Integer
    Dim mItem As dmFloorOptions
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.FloorOptionsID = vFloorOptionsID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmFloorOptions))
    MyBase.New(vList)
  End Sub

End Class



