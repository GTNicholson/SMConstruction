''Class Definition - ProductRequirement (to ProductRequirement)'Generated from Table:ProductRequirement
Imports RTIS.CommonVB

Public Class dmProductRequirement : Inherits dmBase
  Private pProductRequirementID As Int32
  Private pSalesOrderPhaseItemID As Int32
  Private pProductID As Int32
  Private pAllocatedQty As Decimal

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
    ProductRequirementID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmProductRequirement)
      .ProductRequirementID = ProductRequirementID
      .SalesOrderPhaseItemID = SalesOrderPhaseItemID
      .ProductID = ProductID
      .AllocatedQty = AllocatedQty
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductRequirementID() As Int32
    Get
      Return pProductRequirementID
    End Get
    Set(ByVal value As Int32)
      If pProductRequirementID <> value Then IsDirty = True
      pProductRequirementID = value
    End Set
  End Property

  Public Property SalesOrderPhaseItemID() As Int32
    Get
      Return pSalesOrderPhaseItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseItemID <> value Then IsDirty = True
      pSalesOrderPhaseItemID = value
    End Set
  End Property

  Public Property ProductID() As Int32
    Get
      Return pProductID
    End Get
    Set(ByVal value As Int32)
      If pProductID <> value Then IsDirty = True
      pProductID = value
    End Set
  End Property

  Public Property AllocatedQty() As Decimal
    Get
      Return pAllocatedQty
    End Get
    Set(ByVal value As Decimal)
      If pAllocatedQty <> value Then IsDirty = True
      pAllocatedQty = value
    End Set
  End Property


End Class



''Collection Definition - ProductRequirement (to ProductRequirement)'Generated from Table:ProductRequirement

'Private pProductRequirements As colProductRequirements
'Public Property ProductRequirements() As colProductRequirements
'  Get
'    Return pProductRequirements
'  End Get
'  Set(ByVal value As colProductRequirements)
'    pProductRequirements = value
'  End Set
'End Property

'  pProductRequirements = New colProductRequirements 'Add to New
'  pProductRequirements = Nothing 'Add to Finalize
'  .ProductRequirements = ProductRequirements.Clone 'Add to CloneTo
'  ProductRequirements.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ProductRequirements.IsDirty 'Add to IsAnyDirty

Public Class colProductRequirements : Inherits colBase(Of dmProductRequirement)

  Public Overrides Function IndexFromKey(ByVal vProductRequirementID As Integer) As Integer
    Dim mItem As dmProductRequirement
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ProductRequirementID = vProductRequirementID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmProductRequirement))
    MyBase.New(vList)
  End Sub

End Class




