''Class Definition - SalesOrderHouse (to SalesOrderHouse)'Generated from Table:SalesOrderHouse
Imports RTIS.CommonVB

Public Class dmSalesOrderHouse : Inherits dmBase
  Private pSalesOrderHouseID As Int32
  Private pSalesOrderID As Int32
  Private pHouseTypeID As Int32
  Private pRef As String
  Private pDescription As String
  Private pQuantity As Int32
  Private pPricePerUnit As Decimal
  Private pTotalPrice As Decimal
  Private pFilename As String
  Private pOutputDocuments As colOutputDocuments
  Private pShippingCost As Decimal
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pOutputDocuments = New colOutputDocuments
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    pOutputDocuments = Nothing
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections

      If mAnyDirty = False Then mAnyDirty = pOutputDocuments.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    SalesOrderHouseID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderHouse)
      .SalesOrderHouseID = SalesOrderHouseID
      .SalesOrderID = SalesOrderID
      .HouseTypeID = HouseTypeID
      .Ref = Ref
      .Description = Description
      .Quantity = Quantity
      .PricePerUnit = PricePerUnit
      .TotalPrice = TotalPrice
      .Filename = Filename
      .ShippingCost = ShippingCost
      .OutputDocuments = OutputDocuments.Clone
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderHouseID() As Int32
    Get
      Return pSalesOrderHouseID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderHouseID <> value Then IsDirty = True
      pSalesOrderHouseID = value
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

  Public Property HouseTypeID() As Int32
    Get
      Return pHouseTypeID
    End Get
    Set(ByVal value As Int32)
      If pHouseTypeID <> value Then IsDirty = True
      pHouseTypeID = value
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

  Public Property Quantity() As Int32
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Int32)
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

  Public Property Filename As String
    Get
      Return pFilename
    End Get
    Set(value As String)
      If pFilename <> value Then IsDirty = True
      pFilename = value
    End Set
  End Property

  Public Property OutputDocuments As colOutputDocuments
    Get
      Return pOutputDocuments
    End Get
    Set(value As colOutputDocuments)
      pOutputDocuments = value
    End Set
  End Property

  Public Property ShippingCost As Decimal
    Get
      Return pShippingCost
    End Get
    Set(value As Decimal)
      If pShippingCost <> value Then IsDirty = True
      pShippingCost = value
    End Set
  End Property
End Class



''Collection Definition - SalesOrderHouse (to SalesOrderHouse)'Generated from Table:SalesOrderHouse

'Private pSalesOrderHouses As colSalesOrderHouses
'Public Property SalesOrderHouses() As colSalesOrderHouses
'  Get
'    Return pSalesOrderHouses
'  End Get
'  Set(ByVal value As colSalesOrderHouses)
'    pSalesOrderHouses = value
'  End Set
'End Property

'  pSalesOrderHouses = New colSalesOrderHouses 'Add to New
'  pSalesOrderHouses = Nothing 'Add to Finalize
'  .SalesOrderHouses = SalesOrderHouses.Clone 'Add to CloneTo
'  SalesOrderHouses.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderHouses.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderHouses : Inherits colBase(Of dmSalesOrderHouse)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderHouseID As Integer) As Integer
    Dim mItem As dmSalesOrderHouse
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderHouseID = vSalesOrderHouseID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderHouse))
    MyBase.New(vList)
  End Sub

  Public Function GetTotalShippingCost() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem In Me.Items
      mRetVal += mItem.ShippingCost
    Next

    Return mRetVal
  End Function
End Class


