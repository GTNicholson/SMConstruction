''Class Definition - FoundationOptions (to FoundationOptions)'Generated from Table:FoundationOptions
Imports RTIS.CommonVB

Public Class dmFoundationOptions : Inherits dmBase
  Implements iValueItem

  Private pFoundationOptionsID As Int32
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
    FoundationOptionsID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmFoundationOptions)
      .FoundationOptionsID = FoundationOptionsID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property FoundationOptionsID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pFoundationOptionsID
    End Get
    Set(ByVal value As Int32)
      If pFoundationOptionsID <> value Then IsDirty = True
      pFoundationOptionsID = value
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



''Collection Definition - FoundationOptions (to FoundationOptions)'Generated from Table:FoundationOptions

'Private pFoundationOptionss As colFoundationOptionss
'Public Property FoundationOptionss() As colFoundationOptionss
'  Get
'    Return pFoundationOptionss
'  End Get
'  Set(ByVal value As colFoundationOptionss)
'    pFoundationOptionss = value
'  End Set
'End Property

'  pFoundationOptionss = New colFoundationOptionss 'Add to New
'  pFoundationOptionss = Nothing 'Add to Finalize
'  .FoundationOptionss = FoundationOptionss.Clone 'Add to CloneTo
'  FoundationOptionss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = FoundationOptionss.IsDirty 'Add to IsAnyDirty

Public Class colFoundationOptionss : Inherits colBase(Of dmFoundationOptions)

  Public Overrides Function IndexFromKey(ByVal vFoundationOptionsID As Integer) As Integer
    Dim mItem As dmFoundationOptions
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.FoundationOptionsID = vFoundationOptionsID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmFoundationOptions))
    MyBase.New(vList)
  End Sub

End Class




