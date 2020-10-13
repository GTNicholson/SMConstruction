''Class Definition - WallOptions (to WallOptions)'Generated from Table:WallOptions
Imports RTIS.CommonVB

Public Class dmWallOptions : Inherits dmBase
  Implements iValueItem

  Private pWallOptionsID As Int32
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
    WallOptionsID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWallOptions)
      .WallOptionsID = WallOptionsID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WallOptionsID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pWallOptionsID
    End Get
    Set(ByVal value As Int32)
      If pWallOptionsID <> value Then IsDirty = True
      pWallOptionsID = value
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



''Collection Definition - WallOptions (to WallOptions)'Generated from Table:WallOptions

'Private pWallOptionss As colWallOptionss
'Public Property WallOptionss() As colWallOptionss
'  Get
'    Return pWallOptionss
'  End Get
'  Set(ByVal value As colWallOptionss)
'    pWallOptionss = value
'  End Set
'End Property

'  pWallOptionss = New colWallOptionss 'Add to New
'  pWallOptionss = Nothing 'Add to Finalize
'  .WallOptionss = WallOptionss.Clone 'Add to CloneTo
'  WallOptionss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WallOptionss.IsDirty 'Add to IsAnyDirty

Public Class colWallOptionss : Inherits colBase(Of dmWallOptions)

  Public Overrides Function IndexFromKey(ByVal vWallOptionsID As Integer) As Integer
    Dim mItem As dmWallOptions
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WallOptionsID = vWallOptionsID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWallOptions))
    MyBase.New(vList)
  End Sub

End Class



