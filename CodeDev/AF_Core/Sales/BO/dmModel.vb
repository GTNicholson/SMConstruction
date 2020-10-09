''Class Definition - Model (to Model)'Generated from Table:Model
Imports RTIS.CommonVB

Public Class dmModel : Inherits dmBase
  Implements iValueItem

  Private pModelID As Int32
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
    ModelID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmModel)
      .ModelID = ModelID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ModelID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pModelID
    End Get
    Set(ByVal value As Int32)
      If pModelID <> value Then IsDirty = True
      pModelID = value
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



''Collection Definition - Model (to Model)'Generated from Table:Model

'Private pModels As colModels
'Public Property Models() As colModels
'  Get
'    Return pModels
'  End Get
'  Set(ByVal value As colModels)
'    pModels = value
'  End Set
'End Property

'  pModels = New colModels 'Add to New
'  pModels = Nothing 'Add to Finalize
'  .Models = Models.Clone 'Add to CloneTo
'  Models.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Models.IsDirty 'Add to IsAnyDirty

Public Class colModels : Inherits colBase(Of dmModel)

  Public Overrides Function IndexFromKey(ByVal vModelID As Integer) As Integer
    Dim mItem As dmModel
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ModelID = vModelID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmModel))
    MyBase.New(vList)
  End Sub

End Class


