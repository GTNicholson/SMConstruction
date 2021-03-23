''Class Definition - SalesOrderItemProductRequirement (to SalesOrderItemProductRequirement)'Generated from Table:SalesOrderItemProductRequirement
Imports RTIS.CommonVB

Public Class dmSalesOrderItemProductRequirement : Inherits dmBase
  Private pSalesOrderItemProductRequirementID As Int32
  Private pSalesOrderItemID As Int32
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
    SalesOrderItemProductRequirementID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderItemProductRequirement)
      .SalesOrderItemProductRequirementID = SalesOrderItemProductRequirementID
      .SalesOrderItemID = SalesOrderItemID
      .ProductID = ProductID
      .AllocatedQty = AllocatedQty
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderItemProductRequirementID() As Int32
    Get
      Return pSalesOrderItemProductRequirementID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemProductRequirementID <> value Then IsDirty = True
      pSalesOrderItemProductRequirementID = value
    End Set
  End Property

  Public Property SalesOrderItemID() As Int32
    Get
      Return pSalesOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemID <> value Then IsDirty = True
      pSalesOrderItemID = value
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



''Collection Definition - SalesOrderItemProductRequirement (to SalesOrderItemProductRequirement)'Generated from Table:SalesOrderItemProductRequirement

'Private pSalesOrderItemProductRequirements As colSalesOrderItemProductRequirements
'Public Property SalesOrderItemProductRequirements() As colSalesOrderItemProductRequirements
'  Get
'    Return pSalesOrderItemProductRequirements
'  End Get
'  Set(ByVal value As colSalesOrderItemProductRequirements)
'    pSalesOrderItemProductRequirements = value
'  End Set
'End Property

'  pSalesOrderItemProductRequirements = New colSalesOrderItemProductRequirements 'Add to New
'  pSalesOrderItemProductRequirements = Nothing 'Add to Finalize
'  .SalesOrderItemProductRequirements = SalesOrderItemProductRequirements.Clone 'Add to CloneTo
'  SalesOrderItemProductRequirements.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderItemProductRequirements.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderItemProductRequirements : Inherits colBase(Of dmSalesOrderItemProductRequirement)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderItemProductRequirementID As Integer) As Integer
    Dim mItem As dmSalesOrderItemProductRequirement
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderItemProductRequirementID = vSalesOrderItemProductRequirementID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderItemProductRequirement))
    MyBase.New(vList)
  End Sub

End Class


