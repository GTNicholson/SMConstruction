''Class Definition - ProductFurniture (to ProductFurniture)'Generated from Table:ProductFurniture
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dmProductFurniture : Inherits dmProductBase

  Private pProductFurnitureID As Int32
  Private pDescription As String
  Private pFurnitureType As Int32
  Private pNotes As String

  Private pMaterialRequirements As colMaterialRequirements
  Private pMaterialRequirementOthers As colMaterialRequirements

  Private pMaterialRequirementsChanges As colMaterialRequirements
  Private pMaterialRequirementOthersChanges As colMaterialRequirements

  Private pProductFurnitureComponent As colProductFurnitureComponents


  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pMaterialRequirements = New colMaterialRequirements
    pMaterialRequirementOthers = New colMaterialRequirements

    pMaterialRequirementsChanges = New colMaterialRequirements
    pMaterialRequirementOthersChanges = New colMaterialRequirements


    pProductFurnitureComponent = New colProductFurnitureComponents
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    ''Get
    ''  Dim mAnyDirty = IsDirty
    ''  '' Check Objects and Collections
    ''  If mAnyDirty = False Then mAnyDirty = pMaterialRequirements.IsDirty
    ''  IsAnyDirty = mAnyDirty
    ''End Get

    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pMaterialRequirements.IsDirty
      If mAnyDirty = False Then mAnyDirty = pMaterialRequirementOthers.IsDirty
      If mAnyDirty = False Then mAnyDirty = pMaterialRequirementsChanges.IsDirty
      If mAnyDirty = False Then mAnyDirty = pMaterialRequirementOthersChanges.IsDirty

      If mAnyDirty = False Then mAnyDirty = pProductFurnitureComponent.IsDirty
      IsAnyDirty = mAnyDirty
    End Get


  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    ProductFurnitureID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductFurniture)
      .ProductFurnitureID = ProductFurnitureID
      .Description = Description
      .Notes = Notes
      .FurnitureType = FurnitureType
      .MaterialRequirments = MaterialRequirments.Clone
      .MaterialRequirmentOthers = MaterialRequirmentOthers

      .MaterialRequirmentsChanges = MaterialRequirmentsChanges.Clone
      .MaterialRequirmentOthersChanges = MaterialRequirmentOthersChanges


      .ProductFurnitureComponents = ProductFurnitureComponents.Clone


      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Overrides Sub CalculateCostAndPrice()
    Throw New NotImplementedException()
  End Sub

  Public Overrides Function Clone() As Object
    Dim mRetVal As New dmProductFurniture
    Me.CloneTo(mRetVal)
    Return mRetVal
  End Function

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

  Public Property Notes() As String
    Get
      Return pNotes
    End Get
    Set(ByVal value As String)
      If pNotes <> value Then IsDirty = True
      pNotes = value
    End Set
  End Property

  Public Property FurnitureType() As Int32
    Get
      Return pFurnitureType
    End Get
    Set(ByVal value As Int32)
      If pFurnitureType <> value Then IsDirty = True
      pFurnitureType = value
    End Set
  End Property




  Public Property MaterialRequirments As colMaterialRequirements
    Get
      Return pMaterialRequirements
    End Get
    Set(value As colMaterialRequirements)
      pMaterialRequirements = value
    End Set
  End Property

  Public Property MaterialRequirmentOthers As colMaterialRequirements
    Get
      Return pMaterialRequirementOthers
    End Get
    Set(value As colMaterialRequirements)
      pMaterialRequirementOthers = value
    End Set
  End Property

  Public Property MaterialRequirmentsChanges As colMaterialRequirements
    Get
      Return pMaterialRequirementsChanges
    End Get
    Set(value As colMaterialRequirements)
      pMaterialRequirementsChanges = value
    End Set
  End Property

  Public Property MaterialRequirmentOthersChanges As colMaterialRequirements
    Get
      Return pMaterialRequirementOthersChanges
    End Get
    Set(value As colMaterialRequirements)
      pMaterialRequirementOthersChanges = value
    End Set
  End Property

  Public Property ProductFurnitureComponents As colProductFurnitureComponents
    Get
      Return pProductFurnitureComponent
    End Get
    Set(value As colProductFurnitureComponents)
      pProductFurnitureComponent = value
    End Set
  End Property

  Public Overrides Property ItemType As Integer
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As Integer)
      Throw New NotImplementedException()
    End Set
  End Property
End Class



''Collection Definition - ProductFurniture (to ProductFurniture)'Generated from Table:ProductFurniture

'Private pProductFurnitures As colProductFurnitures
'Public Property ProductFurnitures() As colProductFurnitures
'  Get
'    Return pProductFurnitures
'  End Get
'  Set(ByVal value As colProductFurnitures)
'    pProductFurnitures = value
'  End Set
'End Property

'  pProductFurnitures = New colProductFurnitures 'Add to New
'  pProductFurnitures = Nothing 'Add to Finalize
'  .ProductFurnitures = ProductFurnitures.Clone 'Add to CloneTo
'  ProductFurnitures.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductFurnitures.IsDirty 'Add to IsAnyDirty

Public Class colProductFurnitures : Inherits colBase(Of dmProductFurniture)

  Public Overrides Function IndexFromKey(ByVal vProductFurnitureID As Integer) As Integer
    Dim mItem As dmProductFurniture
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductFurnitureID = vProductFurnitureID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductFurniture))
    MyBase.New(vList)
  End Sub

End Class

