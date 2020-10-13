''Class Definition - ProductCostBook (to ProductCostBook)'Generated from Table:ProductCostBook
Imports RTIS.CommonVB

Public Class dmProductCostBook : Inherits dmBase
  Private pProductCostBookID As Int32
  Private pCostBookName As String
  Private pCostBookDate As DateTime
  Private pIsDefault As Boolean
  Private pDirectLabourCost As Decimal
  Private pDirectMaterialCost As Decimal
  Private pDirectTransportationAndEquipment As Decimal
  Private pOutsourcingCost As Decimal

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
    ProductCostBookID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductCostBook)
      .ProductCostBookID = ProductCostBookID
      .CostBookName = CostBookName
      .CostBookDate = CostBookDate
      .IsDefault = IsDefault
      .DirectLabourCost = DirectLabourCost
      .DirectMaterialCost = DirectMaterialCost
      .DirectTransportationAndEquipment = DirectTransportationAndEquipment
      .OutsourcingCost = OutsourcingCost
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductCostBookID() As Int32
    Get
      Return pProductCostBookID
    End Get
    Set(ByVal value As Int32)
      If pProductCostBookID <> value Then IsDirty = True
      pProductCostBookID = value
    End Set
  End Property

  Public Property CostBookName() As String
    Get
      Return pCostBookName
    End Get
    Set(ByVal value As String)
      If pCostBookName <> value Then IsDirty = True
      pCostBookName = value
    End Set
  End Property

  Public Property CostBookDate() As DateTime
    Get
      Return pCostBookDate
    End Get
    Set(ByVal value As DateTime)
      If pCostBookDate <> value Then IsDirty = True
      pCostBookDate = value
    End Set
  End Property

  Public Property IsDefault() As Boolean
    Get
      Return pIsDefault
    End Get
    Set(ByVal value As Boolean)
      If pIsDefault <> value Then IsDirty = True
      pIsDefault = value
    End Set
  End Property

  Public Property DirectLabourCost() As Decimal
    Get
      Return pDirectLabourCost
    End Get
    Set(ByVal value As Decimal)
      If pDirectLabourCost <> value Then IsDirty = True
      pDirectLabourCost = value
    End Set
  End Property

  Public Property DirectMaterialCost() As Decimal
    Get
      Return pDirectMaterialCost
    End Get
    Set(ByVal value As Decimal)
      If pDirectMaterialCost <> value Then IsDirty = True
      pDirectMaterialCost = value
    End Set
  End Property

  Public Property DirectTransportationAndEquipment() As Decimal
    Get
      Return pDirectTransportationAndEquipment
    End Get
    Set(ByVal value As Decimal)
      If pDirectTransportationAndEquipment <> value Then IsDirty = True
      pDirectTransportationAndEquipment = value
    End Set
  End Property

  Public Property OutsourcingCost() As Decimal
    Get
      Return pOutsourcingCost
    End Get
    Set(ByVal value As Decimal)
      If pOutsourcingCost <> value Then IsDirty = True
      pOutsourcingCost = value
    End Set
  End Property


End Class



''Collection Definition - ProductCostBook (to ProductCostBook)'Generated from Table:ProductCostBook

'Private pProductCostBooks As colProductCostBooks
'Public Property ProductCostBooks() As colProductCostBooks
'  Get
'    Return pProductCostBooks
'  End Get
'  Set(ByVal value As colProductCostBooks)
'    pProductCostBooks = value
'  End Set
'End Property

'  pProductCostBooks = New colProductCostBooks 'Add to New
'  pProductCostBooks = Nothing 'Add to Finalize
'  .ProductCostBooks = ProductCostBooks.Clone 'Add to CloneTo
'  ProductCostBooks.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductCostBooks.IsDirty 'Add to IsAnyDirty

Public Class colProductCostBooks : Inherits colBase(Of dmProductCostBook)

  Public Overrides Function IndexFromKey(ByVal vProductCostBookID As Integer) As Integer
    Dim mItem As dmProductCostBook
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductCostBookID = vProductCostBookID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductCostBook))
    MyBase.New(vList)
  End Sub

End Class


''DTO Definition - ProductCostBook (to ProductCostBook)'Generated from Table:ProductCostBook

