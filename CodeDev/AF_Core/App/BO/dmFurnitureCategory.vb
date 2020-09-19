''Class Definition - FurnitureCategory (to FurnitureCategory)'Generated from Table:FurnitureCategory
Imports RTIS.CommonVB

Public Class dmFurnitureCategory : Inherits dmBase
  Implements RTIS.CommonVB.iValueItem

  Private pFurnitureCategoryID As Int32
  Private pEnglishDescription As String
  Private pSpanishDescription As String

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
    FurnitureCategoryID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmFurnitureCategory)
      .FurnitureCategoryID = FurnitureCategoryID
      .EnglishDescription = EnglishDescription
      .SpanishDescription = SpanishDescription
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property FurnitureCategoryID() As Int32
    Get
      Return pFurnitureCategoryID
    End Get
    Set(ByVal value As Int32)
      If pFurnitureCategoryID <> value Then IsDirty = True
      pFurnitureCategoryID = value
    End Set
  End Property

  Public Property EnglishDescription() As String
    Get
      Return pEnglishDescription
    End Get
    Set(ByVal value As String)
      If pEnglishDescription <> value Then IsDirty = True
      pEnglishDescription = value
    End Set
  End Property

  Public Property SpanishDescription() As String
    Get
      Return pSpanishDescription
    End Get
    Set(ByVal value As String)
      If pSpanishDescription <> value Then IsDirty = True
      pSpanishDescription = value
    End Set
  End Property

  Public Property ItemValue As Integer Implements iValueItem.ItemValue
    Get
      Return pFurnitureCategoryID
    End Get
    Set(value As Integer)

    End Set
  End Property

  Public Property DisplayValue As String Implements iValueItem.DisplayValue
    Get
      Return pEnglishDescription
    End Get
    Set(value As String)

    End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get
      Return False
    End Get
    Set(value As Boolean)

    End Set
  End Property
End Class



''Collection Definition - FurnitureCategory (to FurnitureCategory)'Generated from Table:FurnitureCategory

'Private pFurnitureCategorys As colFurnitureCategorys
'Public Property FurnitureCategorys() As colFurnitureCategorys
'  Get
'    Return pFurnitureCategorys
'  End Get
'  Set(ByVal value As colFurnitureCategorys)
'    pFurnitureCategorys = value
'  End Set
'End Property

'  pFurnitureCategorys = New colFurnitureCategorys 'Add to New
'  pFurnitureCategorys = Nothing 'Add to Finalize
'  .FurnitureCategorys = FurnitureCategorys.Clone 'Add to CloneTo
'  FurnitureCategorys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = FurnitureCategorys.IsDirty 'Add to IsAnyDirty

Public Class colFurnitureCategorys : Inherits colBase(Of dmFurnitureCategory)

  Public Overrides Function IndexFromKey(ByVal vFurnitureCategoryID As Integer) As Integer
    Dim mItem As dmFurnitureCategory
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.FurnitureCategoryID = vFurnitureCategoryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmFurnitureCategory))
    MyBase.New(vList)
  End Sub

End Class





