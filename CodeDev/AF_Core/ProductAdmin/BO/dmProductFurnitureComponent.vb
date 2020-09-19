''Class Definition - ProductFurnitureComponent (to ProductFurnitureComponent)'Generated from Table:ProductFurnitureComponent
Imports RTIS.CommonVB

Public Class dmProductFurnitureComponent : Inherits dmBase
  Private pProductFurnitureComponentID As Int32
  Private pProductFurnitureID As Int32
  Private pDescription As String
  Private pSpecies As Int32
  Private pQty As Double
  Private pDimensions As String

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
    ProductFurnitureComponentID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductFurnitureComponent)
      .ProductFurnitureComponentID = ProductFurnitureComponentID
      .ProductFurnitureID = ProductFurnitureID
      .Description = Description
      .Species = Species
      .Qty = Qty
      .Dimensions = Dimensions
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductFurnitureComponentID() As Int32
    Get
      Return pProductFurnitureComponentID
    End Get
    Set(ByVal value As Int32)
      If pProductFurnitureComponentID <> value Then IsDirty = True
      pProductFurnitureComponentID = value
    End Set
  End Property

  Public Property ProductFurnitureID() As Int32
    Get
      Return pProductFurnitureID
    End Get
    Set(ByVal value As Int32)
      If pProductFurnitureID <> value Then IsDirty = True
      pProductFurnitureID = value
    End Set
  End Property

  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property Species() As Int32
    Get
      Return pSpecies
    End Get
    Set(ByVal value As Int32)
      If pSpecies <> value Then IsDirty = True
      pSpecies = value
    End Set
  End Property

  Public Property Qty() As Double
    Get
      Return pQty
    End Get
    Set(ByVal value As Double)
      If pQty <> value Then IsDirty = True
      pQty = value
    End Set
  End Property

  Public Property Dimensions() As String
    Get
      Return pDimensions
    End Get
    Set(ByVal value As String)
      If pDimensions <> value Then IsDirty = True
      pDimensions = value
    End Set
  End Property


End Class



''Collection Definition - ProductFurnitureComponent (to ProductFurnitureComponent)'Generated from Table:ProductFurnitureComponent

'Private pProductFurnitureComponents As colProductFurnitureComponents
'Public Property ProductFurnitureComponents() As colProductFurnitureComponents
'  Get
'    Return pProductFurnitureComponents
'  End Get
'  Set(ByVal value As colProductFurnitureComponents)
'    pProductFurnitureComponents = value
'  End Set
'End Property

'  pProductFurnitureComponents = New colProductFurnitureComponents 'Add to New
'  pProductFurnitureComponents = Nothing 'Add to Finalize
'  .ProductFurnitureComponents = ProductFurnitureComponents.Clone 'Add to CloneTo
'  ProductFurnitureComponents.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductFurnitureComponents.IsDirty 'Add to IsAnyDirty

Public Class colProductFurnitureComponents : Inherits colBase(Of dmProductFurnitureComponent)

  Public Overrides Function IndexFromKey(ByVal vProductFurnitureComponentID As Integer) As Integer
    Dim mItem As dmProductFurnitureComponent
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductFurnitureComponentID = vProductFurnitureComponentID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductFurnitureComponent))
    MyBase.New(vList)
  End Sub

End Class





