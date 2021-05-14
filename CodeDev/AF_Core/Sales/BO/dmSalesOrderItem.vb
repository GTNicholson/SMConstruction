''Class Definition - SalesOrderItem (to SalesOrderItem)'Generated from Table:SalesOrderItem
Imports RTIS.CommonVB

Public Class dmSalesOrderItem : Inherits dmBase
  Implements iValueItem
  Private pSalesOrderItemID As Int32
  Private pSalesOrderID As Int32
  Private pItemNumber As String
  Private pDescription As String
  Private pQuantity As Int32
  Private pUnitPrice As Decimal
  Private pImageFile As String
  Private pWoodSpecieID As Int32
  Private pWoodFinish As Int32
  Private pQtyInvoiced As Int32
  Private pProductTypeID As eProductType
  Private pProductID As Integer

  Private pWorkOrders As colWorkOrders
  Private pSalesOrderItem As dmSalesOrderItem

  Private pSalesItemAssemblyID As Integer
  Private pHouseTypeID As Integer
  Private pSalesOrderStageID As Integer

  Private pSalesSubItemType As Integer
  Private pSalesItemType As Integer

  Private pProductConstructionType As Int32
  Private pComments As String
  Private pUoM As Integer

  Private pWoodCost As Decimal
  Private pStockItemCost As Decimal
  Private pTransportationCost As Decimal
  Private pManpowerCost As Decimal
  Private pSubContractCost As Decimal

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pWorkOrders = New colWorkOrders(Me)

    pWorkOrders.TrackDeleted = True
    pSalesOrderItem = Me

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
      If mAnyDirty = False Then mAnyDirty = pWorkOrders.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    SalesOrderItemID = 0

  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderItem)
      .SalesOrderItemID = SalesOrderItemID
      .SalesOrderID = SalesOrderID
      .ItemNumber = ItemNumber
      .Description = Description
      .Quantity = Quantity
      .UnitPrice = UnitPrice
      .ImageFile = ImageFile
      'Add entries here for each collection and class property
      .WorkOrders = WorkOrders.Clone
      .WoodFinish = WoodFinish
      .WoodSpecieID = WoodSpecieID
      .QtyInvoiced = QtyInvoiced
      .SalesItemAssemblyID = SalesItemAssemblyID
      .HouseTypeID = HouseTypeID
      .ProductID = ProductID
      .SalesItemType = SalesItemType
      .SalesSubItemType = SalesSubItemType
      .SalesOrderStageID = SalesOrderStageID
      .ProductConstructionType = ProductConstructionType
      .Comments = Comments
      .UoM = UoM
      .WoodCost = WoodCost
      .StockItemCost = StockItemCost
      .TransportationCost = TransportationCost
      .ManpowerCost = ManpowerCost
      .SubContractCost = SubContractCost
      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ProductTypeID() As eProductType
    Get
      Return pProductTypeID
    End Get
    Set(ByVal value As eProductType)
      If pProductTypeID <> value Then IsDirty = True
      pProductTypeID = value
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

  Public Property SalesItemType() As Int32
    Get
      Return pSalesItemType
    End Get
    Set(ByVal value As Int32)
      If pSalesItemType <> value Then IsDirty = True
      pSalesItemType = value
    End Set
  End Property
  Public Property SalesSubItemType() As Int32
    Get
      Return pSalesSubItemType
    End Get
    Set(ByVal value As Int32)
      If pSalesSubItemType <> value Then IsDirty = True
      pSalesSubItemType = value
    End Set
  End Property

  Public Property SalesOrderStageID() As Int32
    Get
      Return pSalesOrderStageID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderStageID <> value Then IsDirty = True
      pSalesOrderStageID = value
    End Set
  End Property

  Public Property SalesItemAssemblyID() As Int32
    Get
      Return pSalesItemAssemblyID
    End Get
    Set(ByVal value As Int32)
      If pSalesItemAssemblyID <> value Then IsDirty = True
      pSalesItemAssemblyID = value
    End Set
  End Property

  Public Property SalesOrderItemID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pSalesOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderItemID <> value Then IsDirty = True
      pSalesOrderItemID = value
    End Set
  End Property

  Public Property QtyInvoiced() As Int32
    Get
      Return pQtyInvoiced
    End Get
    Set(ByVal value As Int32)
      If pQtyInvoiced <> value Then IsDirty = True
      pQtyInvoiced = value
    End Set
  End Property

  Public Property WoodSpecieID() As Int32
    Get
      Return pWoodSpecieID
    End Get
    Set(ByVal value As Int32)
      If pWoodSpecieID <> value Then IsDirty = True
      pWoodSpecieID = value
    End Set
  End Property

  Public Property WoodFinish() As Int32
    Get
      Return pWoodFinish
    End Get
    Set(ByVal value As Int32)
      If pWoodFinish <> value Then IsDirty = True
      pWoodFinish = value
    End Set
  End Property

  Public Property ImageFile() As String
    Get
      Return pImageFile
    End Get
    Set(ByVal value As String)
      If pImageFile <> value Then IsDirty = True
      pImageFile = value
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

  Public Property ItemNumber() As String
    Get
      Return pItemNumber
    End Get
    Set(ByVal value As String)
      If pItemNumber <> value Then IsDirty = True
      pItemNumber = value
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

  Public Property UnitPrice() As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(ByVal value As Decimal)
      If pUnitPrice <> value Then IsDirty = True
      pUnitPrice = value
    End Set
  End Property

  Public Property ProductConstructionType() As Int32
    Get
      Return pProductConstructionType
    End Get
    Set(ByVal value As Int32)
      If pProductConstructionType <> value Then IsDirty = True
      pProductConstructionType = value
    End Set
  End Property



  Public Property WorkOrders As colWorkOrders
    Get
      Return pWorkOrders
    End Get
    Set(value As colWorkOrders)
      pWorkOrders = value
    End Set
  End Property


  Public Property Comments As String
    Get
      Return pComments
    End Get
    Set(value As String)
      If pComments <> value Then IsDirty = True
      pComments = value
    End Set
  End Property

  Public Property UoM As Integer
    Get
      Return pUoM
    End Get
    Set(value As Integer)
      If pUoM <> value Then IsDirty = True
      pUoM = value
    End Set
  End Property

  Public ReadOnly Property UoMDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(UoM, eUoM))
    End Get
  End Property
  Public Property DisplayValue As String Implements iValueItem.DisplayValue
    Get
      Return pItemNumber & " - " & pDescription
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

  Public Property HouseTypeID As Integer
    Get
      Return pHouseTypeID
    End Get
    Set(value As Integer)
      pHouseTypeID = value
    End Set
  End Property

  Public ReadOnly Property TotalAmount() As Decimal
    Get
      Return UnitPrice * Quantity
    End Get
  End Property

  Public ReadOnly Property DescriptionPrintout As String
    Get
      Dim mRetVal As String = ""

      mRetVal = Description
      mRetVal &= vbCrLf
      mRetVal &= Comments

      Return mRetVal
    End Get
  End Property


  Public Property WoodCost As Decimal
    Get
      Return pWoodCost
    End Get
    Set(value As Decimal)
      If pWoodCost <> value Then IsDirty = True
      pWoodCost = value
    End Set
  End Property

  Public Property StockItemCost As Decimal
    Get
      Return pStockItemCost
    End Get
    Set(value As Decimal)
      If pStockItemCost <> value Then IsDirty = True
      pStockItemCost = value
    End Set
  End Property

  Public Property TransportationCost As Decimal
    Get
      Return pTransportationCost
    End Get
    Set(value As Decimal)
      If pTransportationCost <> value Then IsDirty = True
      pTransportationCost = value
    End Set
  End Property

  Public Property ManpowerCost As Decimal
    Get
      Return pManpowerCost
    End Get
    Set(value As Decimal)
      If pManpowerCost <> value Then IsDirty = True
      pManpowerCost = value
    End Set
  End Property

  Public Property SubContractCost As Decimal
    Get
      Return pSubContractCost
    End Get
    Set(value As Decimal)
      If pSubContractCost <> value Then IsDirty = True
      pSubContractCost = value
    End Set
  End Property



End Class



''Collection Definition - SalesOrderItem (to SalesOrderItem)'Generated from Table:SalesOrderItem

'Private pSalesOrderItems As colSalesOrderItems
'Public Property SalesOrderItems() As colSalesOrderItems
'  Get
'    Return pSalesOrderItems
'  End Get
'  Set(ByVal value As colSalesOrderItems)
'    pSalesOrderItems = value
'  End Set
'End Property

'  pSalesOrderItems = New colSalesOrderItems 'Add to New
'  pSalesOrderItems = Nothing 'Add to Finalize
'  .SalesOrderItems = SalesOrderItems.Clone 'Add to CloneTo
'  SalesOrderItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderItems.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderItems : Inherits colBase(Of dmSalesOrderItem)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderItemID As Integer) As Integer
    Dim mItem As dmSalesOrderItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderItemID = vSalesOrderItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemFromProductID_ItemType_SubItemType(ByVal vProductID As Integer, ByVal vItemType As Integer, ByVal vSubItemType As Integer) As dmSalesOrderItem
    Dim mItem As dmSalesOrderItem
    Dim mRetVal As dmSalesOrderItem = Nothing

    For Each mItem In MyBase.Items

      If mItem.ProductID = vProductID And mItem.SalesItemType = vItemType And mItem.SalesSubItemType = vSubItemType Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderItem))
    MyBase.New(vList)
  End Sub

  Public Function GetNextItemNumber() As Integer
    Dim mRetVal As Integer = 0
    For Each mItem As dmSalesOrderItem In Me.Items
      If mItem.ItemNumber > mRetVal Then mRetVal = mItem.ItemNumber
    Next
    mRetVal = mRetVal + 1
    Return mRetVal
  End Function

  Public Function GetTotalValue() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem As dmSalesOrderItem In Me.Items

      mRetVal += mItem.Quantity * mItem.UnitPrice

    Next

    Return mRetVal


  End Function

  Public Function GetTotalStockItemMatReqBudget() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem As dmSalesOrderItem In Me.Items

      mRetVal += mItem.StockItemCost * mItem.Quantity

    Next

    Return mRetVal
  End Function

  Public Function GetTotalWoodMatReqBudget() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem As dmSalesOrderItem In Me.Items

      mRetVal += mItem.WoodCost * mItem.Quantity

    Next

    Return mRetVal
  End Function

  Public Function GetTotalMOBudget() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem As dmSalesOrderItem In Me.Items

      mRetVal += mItem.ManpowerCost * mItem.Quantity

    Next

    Return mRetVal
  End Function

  Public Function GetTotalOutsourcingBudget() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mItem As dmSalesOrderItem In Me.Items

      mRetVal += mItem.SubContractCost * mItem.Quantity

    Next

    Return mRetVal
  End Function
End Class





