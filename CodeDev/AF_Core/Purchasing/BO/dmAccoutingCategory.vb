''Class Definition - AccoutingCategory (to AccoutingCategory)'Generated from Table:AccoutingCategory
Imports RTIS.CommonVB

Public Class dmAccoutingCategory : Inherits dmBase
  Implements iValueItem

  Private pAccoutingCategoryID As Int32
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
    AccoutingCategoryID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmAccoutingCategory)
      .AccoutingCategoryID = AccoutingCategoryID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property AccoutingCategoryID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pAccoutingCategoryID
    End Get
    Set(ByVal value As Int32)
      If pAccoutingCategoryID <> value Then IsDirty = True
      pAccoutingCategoryID = value
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



''Collection Definition - AccoutingCategory (to AccoutingCategory)'Generated from Table:AccoutingCategory

'Private pAccoutingCategorys As colAccoutingCategorys
'Public Property AccoutingCategorys() As colAccoutingCategorys
'  Get
'    Return pAccoutingCategorys
'  End Get
'  Set(ByVal value As colAccoutingCategorys)
'    pAccoutingCategorys = value
'  End Set
'End Property

'  pAccoutingCategorys = New colAccoutingCategorys 'Add to New
'  pAccoutingCategorys = Nothing 'Add to Finalize
'  .AccoutingCategorys = AccoutingCategorys.Clone 'Add to CloneTo
'  AccoutingCategorys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = AccoutingCategorys.IsDirty 'Add to IsAnyDirty

Public Class colAccoutingCategorys : Inherits colBase(Of dmAccoutingCategory)

  Public Overrides Function IndexFromKey(ByVal vAccoutingCategoryID As Integer) As Integer
    Dim mItem As dmAccoutingCategory
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.AccoutingCategoryID = vAccoutingCategoryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmAccoutingCategory))
    MyBase.New(vList)
  End Sub

End Class

