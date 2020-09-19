''Class Definition - SalesItemAssembly (to SalesItemAssembly)'Generated from Table:SalesItemAssembly
Imports RTIS.CommonVB

Public Class dmSalesItemAssembly : Inherits dmBase
  Private pSalesItemAssemblyID As Int32
  Private pSalesOrderID As Int32
  Private pSalesOrderItemID As Int32
  Private pRef As String
  Private pDescription As String
  Private pHouseTypeID As Integer
  Private pQuantity As Integer
  Private pPricePerUnit As Decimal
  Private pTotalPrice As Decimal

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
    SalesItemAssemblyID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesItemAssembly)
      .SalesItemAssemblyID = SalesItemAssemblyID
      .SalesOrderID = SalesOrderID
      .SalesOrderItemID = SalesOrderItemID
      .Ref = Ref
      .Description = Description
      .HouseTypeID = HouseTypeID
      .Quantity = Quantity
      .PricePerUnit = PricePerUnit
      .TotalPrice = TotalPrice
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesItemAssemblyID() As Int32
    Get
      Return pSalesItemAssemblyID
    End Get
    Set(ByVal value As Int32)
      If pSalesItemAssemblyID <> value Then IsDirty = True
      pSalesItemAssemblyID = value
    End Set
  End Property

  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
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

  Public Property Ref() As String
    Get
      Return pRef
    End Get
    Set(ByVal value As String)
      If pRef <> value Then IsDirty = True
      pRef = value
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

  Public Property HouseTypeID() As Integer
    Get
      Return pHouseTypeID
    End Get
    Set(ByVal value As Integer)
      If pHouseTypeID <> value Then IsDirty = True
      pHouseTypeID = value
    End Set
  End Property

  Public Property Quantity() As Integer
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Integer)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property PricePerUnit() As Decimal
    Get
      Return pPricePerUnit
    End Get
    Set(ByVal value As Decimal)
      If pPricePerUnit <> value Then IsDirty = True
      pPricePerUnit = value
    End Set
  End Property

  Public Property TotalPrice() As Decimal
    Get
      Return pTotalPrice
    End Get
    Set(ByVal value As Decimal)
      If pTotalPrice <> value Then IsDirty = True
      pTotalPrice = value
    End Set
  End Property

End Class



''Collection Definition - SalesItemAssembly (to SalesItemAssembly)'Generated from Table:SalesItemAssembly

'Private pSalesItemAssemblys As colSalesItemAssemblys
'Public Property SalesItemAssemblys() As colSalesItemAssemblys
'  Get
'    Return pSalesItemAssemblys
'  End Get
'  Set(ByVal value As colSalesItemAssemblys)
'    pSalesItemAssemblys = value
'  End Set
'End Property

'  pSalesItemAssemblys = New colSalesItemAssemblys 'Add to New
'  pSalesItemAssemblys = Nothing 'Add to Finalize
'  .SalesItemAssemblys = SalesItemAssemblys.Clone 'Add to CloneTo
'  SalesItemAssemblys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesItemAssemblys.IsDirty 'Add to IsAnyDirty

Public Class colSalesItemAssemblys : Inherits colBase(Of dmSalesItemAssembly)

  Public Overrides Function IndexFromKey(ByVal vSalesItemAssemblyID As Integer) As Integer
    Dim mItem As dmSalesItemAssembly
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesItemAssemblyID = vSalesItemAssemblyID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesItemAssembly))
    MyBase.New(vList)
  End Sub

End Class


