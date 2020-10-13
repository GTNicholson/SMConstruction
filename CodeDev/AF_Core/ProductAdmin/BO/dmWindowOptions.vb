''Class Definition - WindowOptions (to WindowOptions)'Generated from Table:WindowOptions
Imports RTIS.CommonVB

Public Class dmWindowOptions : Inherits dmBase
  Implements iValueItem

  Private pWindowOptionsID As Int32
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
    WindowOptionsID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWindowOptions)
      .WindowOptionsID = WindowOptionsID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WindowOptionsID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pWindowOptionsID
    End Get
    Set(ByVal value As Int32)
      If pWindowOptionsID <> value Then IsDirty = True
      pWindowOptionsID = value
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



''Collection Definition - WindowOptions (to WindowOptions)'Generated from Table:WindowOptions

'Private pWindowOptionss As colWindowOptionss
'Public Property WindowOptionss() As colWindowOptionss
'  Get
'    Return pWindowOptionss
'  End Get
'  Set(ByVal value As colWindowOptionss)
'    pWindowOptionss = value
'  End Set
'End Property

'  pWindowOptionss = New colWindowOptionss 'Add to New
'  pWindowOptionss = Nothing 'Add to Finalize
'  .WindowOptionss = WindowOptionss.Clone 'Add to CloneTo
'  WindowOptionss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WindowOptionss.IsDirty 'Add to IsAnyDirty

Public Class colWindowOptionss : Inherits colBase(Of dmWindowOptions)

  Public Overrides Function IndexFromKey(ByVal vWindowOptionsID As Integer) As Integer
    Dim mItem As dmWindowOptions
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WindowOptionsID = vWindowOptionsID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWindowOptions))
    MyBase.New(vList)
  End Sub

End Class


