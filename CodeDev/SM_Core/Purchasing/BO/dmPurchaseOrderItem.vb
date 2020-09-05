''Class Definition - PurchaseOrderItem (to PurchaseOrderItem)'Generated from Table:PurchaseOrderItem
Imports RTIS.CommonVB

Public Class dmPurchaseOrderItem : Inherits dmBase
  Private pPurchaseOrderItemID As Int32
  Private pPurchaseOrderID As Int32
  Private pStockItemID As Int32
  Private pStockCode As String
  Private pStatus As Byte
  Private pDescription As String
  Private pPartNo As String
  Private pUnitPrice As Decimal
  Private pPricingMethod As Byte
  Private pPricingUnit As Byte
  Private pLength As Decimal
  Private pWidth As Decimal
  Private pThickness As Decimal
  Private pLineNumber As Int32
  Private pStockItemPartID As Int32
  Private pCoCType As Byte
  Private pQtyRequired As Decimal
  Private pSupplierCode As String
  Private pNominalAccountCode As String
  Private pNominalCostCentre As String
  Private pVatRateCode As Byte
  Private pVatValue As Decimal
  Private pNotes As String
  Private pAverageInvoicePrice As Decimal
  Private pDensity As Decimal
  Private pPickedQty As Decimal
  Private pReplacementQty As Decimal
  Private pQtyReceived As Decimal
  Private pPurchaseOrderItemAllocations As colPurchaseOrderItemAllocations
  Private pParent As dmPurchaseOrder
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pPurchaseOrderItemAllocations = New colPurchaseOrderItemAllocations
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    pPurchaseOrderItemAllocations = Nothing
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If Not mAnyDirty Then mAnyDirty = PurchaseOrderItemAllocations.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    PurchaseOrderItemID = 0
    PurchaseOrderItemAllocations.ClearKeys()
  End Sub

  Public Property PurchaseOrderItemAllocations As colPurchaseOrderItemAllocations
    Get
      Return pPurchaseOrderItemAllocations
    End Get
    Set(value As colPurchaseOrderItemAllocations)
      pPurchaseOrderItemAllocations = value
    End Set
  End Property

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPurchaseOrderItem)
      .PurchaseOrderItemID = PurchaseOrderItemID
      .PurchaseOrderID = PurchaseOrderID
      .StockItemID = StockItemID
      .StockCode = StockCode
      .Status = Status
      .Description = Description
      .PartNo = PartNo
      .UnitPrice = UnitPrice
      .PricingMethod = PricingMethod
      .PricingUnit = PricingUnit
      .Length = Length
      .Width = Width
      .Thickness = Thickness
      .LineNumber = LineNumber
      .StockItemPartID = StockItemPartID
      .CoCType = CoCType
      .QtyRequired = QtyRequired
      .SupplierCode = SupplierCode
      .NominalAccountCode = NominalAccountCode
      .NominalCostCentre = NominalCostCentre
      .VatRateCode = VatRateCode
      .VatValue = VatValue
      .AverageInvoicePrice = AverageInvoicePrice
      .Density = Density
      .ReplacementQty = ReplacementQty
      'Add entries here for each collection and class property
      .PurchaseOrderItemAllocations = PurchaseOrderItemAllocations.Clone
      .PickedQty = PickedQty
      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PurchaseOrderItemID() As Int32
    Get
      Return pPurchaseOrderItemID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderItemID <> value Then IsDirty = True
      pPurchaseOrderItemID = value
    End Set
  End Property

  Public Property PickedQty() As Decimal
    Get
      Return pPickedQty
    End Get
    Set(ByVal value As Decimal)
      If pPickedQty <> value Then IsDirty = True
      pPickedQty = value
    End Set
  End Property
  Public Sub SetPickedQty(ByVal vNewValue As Decimal)
    pPickedQty = vNewValue
  End Sub
  Public Property PurchaseOrderID() As Int32
    Get
      Return pPurchaseOrderID
    End Get
    Set(ByVal value As Int32)
      If pPurchaseOrderID <> value Then IsDirty = True
      pPurchaseOrderID = value
    End Set
  End Property

  Public Property StockItemID() As Int32
    Get
      Return pStockItemID
    End Get
    Set(ByVal value As Int32)
      If pStockItemID <> value Then IsDirty = True
      pStockItemID = value
    End Set
  End Property

  Public Property StockCode() As String
    Get
      Return pStockCode
    End Get
    Set(ByVal value As String)
      If pStockCode <> value Then IsDirty = True
      pStockCode = value
    End Set
  End Property

  Public Property Status() As Byte
    Get
      Return pStatus
    End Get
    Set(ByVal value As Byte)
      If pStatus <> value Then IsDirty = True
      pStatus = value
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

  Public Property PartNo() As String
    Get
      Return pPartNo
    End Get
    Set(ByVal value As String)
      If pPartNo <> value Then IsDirty = True
      pPartNo = value
    End Set
  End Property

  Public Property UnitPrice() As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(ByVal value As Decimal)
      If pUnitPrice <> Math.Round(value, 2, MidpointRounding.AwayFromZero) Then IsDirty = True
      pUnitPrice = Math.Round(value, 2, MidpointRounding.AwayFromZero)
    End Set
  End Property

  Public Property PricingMethod() As Byte
    Get
      Return pPricingMethod
    End Get
    Set(ByVal value As Byte)
      If pPricingMethod <> value Then IsDirty = True
      pPricingMethod = value
    End Set
  End Property

  Public Property PricingUnit() As Byte
    Get
      Return pPricingUnit
    End Get
    Set(ByVal value As Byte)
      If pPricingUnit <> value Then IsDirty = True
      pPricingUnit = value
    End Set
  End Property

  Public Property Length() As Decimal
    Get
      Return pLength
    End Get
    Set(ByVal value As Decimal)
      If pLength <> value Then IsDirty = True
      pLength = value
    End Set
  End Property

  Public Property Width() As Decimal
    Get
      Return pWidth
    End Get
    Set(ByVal value As Decimal)
      If pWidth <> value Then IsDirty = True
      pWidth = value
    End Set
  End Property

  Public Property Thickness() As Decimal
    Get
      Return pThickness
    End Get
    Set(ByVal value As Decimal)
      If pThickness <> value Then IsDirty = True
      pThickness = value
    End Set
  End Property

  Public Property LineNumber() As Int32
    Get
      Return pLineNumber
    End Get
    Set(ByVal value As Int32)
      If pLineNumber <> value Then IsDirty = True
      pLineNumber = value
    End Set
  End Property

  Public Property StockItemPartID() As Int32
    Get
      Return pStockItemPartID
    End Get
    Set(ByVal value As Int32)
      If pStockItemPartID <> value Then IsDirty = True
      pStockItemPartID = value
    End Set
  End Property

  Public Property CoCType() As Byte
    Get
      Return pCoCType
    End Get
    Set(ByVal value As Byte)
      If pCoCType <> value Then IsDirty = True
      pCoCType = value
    End Set
  End Property



  Public Property QtyRequired() As Decimal
    Get
      Return pQtyRequired
    End Get
    Set(ByVal value As Decimal)
      If pQtyRequired <> value Then IsDirty = True
      pQtyRequired = value
    End Set
  End Property

  Public Property SupplierCode() As String
    Get
      Return pSupplierCode
    End Get
    Set(ByVal value As String)
      If pSupplierCode <> value Then IsDirty = True
      pSupplierCode = value
    End Set
  End Property

  Public Property NominalAccountCode() As String
    Get
      Return pNominalAccountCode
    End Get
    Set(ByVal value As String)
      If pNominalAccountCode <> value Then IsDirty = True
      pNominalAccountCode = value
    End Set
  End Property

  Public Property NominalCostCentre() As String
    Get
      Return pNominalCostCentre
    End Get
    Set(ByVal value As String)
      If pNominalCostCentre <> value Then IsDirty = True
      pNominalCostCentre = value
    End Set
  End Property

  Public Property VatRateCode() As Byte
    Get
      Return pVatRateCode
    End Get
    Set(ByVal value As Byte)
      If pVatRateCode <> value Then IsDirty = True
      pVatRateCode = value
    End Set
  End Property

  Public Property VatValue() As Decimal
    Get
      Return pVatValue
    End Get
    Set(ByVal value As Decimal)
      Dim mValue As Decimal = Math.Round(value, 4, MidpointRounding.AwayFromZero)
      If pVatValue <> mValue Then IsDirty = True
      pVatValue = mValue
    End Set
  End Property

  Public ReadOnly Property UnitPricePlusVAT As Decimal
    Get
      Dim mRetVal As Decimal
      mRetVal = pUnitPrice + pVatValue
      Return mRetVal
    End Get
  End Property

  Public Function CalculateVATValue(ByVal vPercent As Decimal) As Decimal
    Dim mRetVal As Decimal
    mRetVal = Math.Round(UnitPrice * (vPercent / 100), 2, MidpointRounding.AwayFromZero)
    Return mRetVal
  End Function

  Public Property Notes As String
    Get
      Return pNotes
    End Get
    Set(value As String)
      If pNotes <> value Then IsDirty = True
      pNotes = value
    End Set
  End Property

  Public Property AverageInvoicePrice() As Decimal
    Get
      Return pAverageInvoicePrice
    End Get
    Set(ByVal value As Decimal)
      If pAverageInvoicePrice <> value Then IsDirty = True
      pAverageInvoicePrice = value
    End Set
  End Property

  Public Property Density() As Decimal
    Get
      Return pDensity
    End Get
    Set(ByVal value As Decimal)
      If pDensity <> value Then IsDirty = True
      pDensity = value
    End Set
  End Property

  Public Property ReplacementQty() As Decimal
    Get
      Return pReplacementQty
    End Get
    Set(ByVal value As Decimal)
      If pReplacementQty <> value Then IsDirty = True
      pReplacementQty = value
    End Set
  End Property

  Public ReadOnly Property NetAmount As Decimal
    Get
      Return pUnitPrice * pQtyRequired
    End Get
  End Property

  Public ReadOnly Property VATAmount As Decimal
    Get
      Return pVatValue * pQtyRequired
    End Get
  End Property


  Public ReadOnly Property GrossAmount As Decimal
    Get
      Return UnitPricePlusVAT * pQtyRequired
    End Get
  End Property

  Public Property Parent As dmPurchaseOrder
    Get
      Return pParent
    End Get
    Set(value As dmPurchaseOrder)
      pParent = value
    End Set
  End Property

  Public Property TotalQuantityAllocated As Decimal
    Get
      Return pPurchaseOrderItemAllocations.TotalQuantityAllocated
    End Get
    Set(value As Decimal)
      If pPurchaseOrderItemAllocations.Count = 0 Then
        '// Add an allowcation and editor
        pPurchaseOrderItemAllocations.AddNew()
      End If

      If pPurchaseOrderItemAllocations.Count = 1 Then
        pPurchaseOrderItemAllocations(0).Quantity = value

      End If
      pQtyRequired = pPurchaseOrderItemAllocations.TotalQuantityAllocated
    End Set
  End Property

  Public Property TotalQuantityAllocatedReceived As Decimal
    Get
      Return pPurchaseOrderItemAllocations.TotalQuantityAllocatedReceived
    End Get
    Set(value As Decimal)

      pQtyRequired = pPurchaseOrderItemAllocations.TotalQuantityAllocatedReceived
    End Set
  End Property

  Public ReadOnly Property TotalValueReceived As Decimal
    Get
      Return pUnitPrice * TotalQuantityAllocatedReceived
    End Get
  End Property

End Class



''Collection Definition - PurchaseOrderItem (to PurchaseOrderItem)'Generated from Table:PurchaseOrderItem

'Private pPurchaseOrderItems As colPurchaseOrderItems
'Public Property PurchaseOrderItems() As colPurchaseOrderItems
'  Get
'    Return pPurchaseOrderItems
'  End Get
'  Set(ByVal value As colPurchaseOrderItems)
'    pPurchaseOrderItems = value
'  End Set
'End Property

'  pPurchaseOrderItems = New colPurchaseOrderItems 'Add to New
'  pPurchaseOrderItems = Nothing 'Add to Finalize
'  .PurchaseOrderItems = PurchaseOrderItems.Clone 'Add to CloneTo
'  PurchaseOrderItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PurchaseOrderItems.IsDirty 'Add to IsAnyDirty

Public Class colPurchaseOrderItems : Inherits colBase(Of dmPurchaseOrderItem)

  Private pParent As dmPurchaseOrder

  Protected Overrides Sub InsertItem(index As Integer, item As dmPurchaseOrderItem)
    MyBase.InsertItem(index, item)
    If pParent IsNot Nothing Then item.Parent = pParent
  End Sub

  Public Sub New(ByRef rParent As dmPurchaseOrder)
    MyBase.New()
    MyBase.TrackDeleted = True
    Me.DeletedItems = New List(Of dmPurchaseOrderItem)
    pParent = rParent
  End Sub

  Public Overrides Function IndexFromKey(ByVal vPurchaseOrderItemID As Integer) As Integer
    Dim mItem As dmPurchaseOrderItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PurchaseOrderItemID = vPurchaseOrderItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  'Public Sub New()
  '  MyBase.New()
  'End Sub

  Public Sub New(ByVal vList As List(Of dmPurchaseOrderItem), ByRef rParent As dmPurchaseOrder)
    MyBase.New(vList)
    pParent = rParent
  End Sub

  Public Overrides Function Clone() As Object
    Dim mCol As New colPurchaseOrderItems(pParent)

    For Each mItem As ICloneable In MyBase.Items
      mCol.Add(CType(mItem.Clone, dmPurchaseOrderItem))
    Next
    mCol.IsDirty = IsDirty
    mCol.SomeRemoved = SomeRemoved
    mCol.SomeDeleted = SomeDeleted
    ''mCol.DeletedItems = DeletedItems 'TODO - Clone ??
    If TrackDeleted AndAlso DeletedItems IsNot Nothing Then
      For mIndex As Integer = 0 To (DeletedItems.Count - 1) 'To 0 Step -1
        mCol.DeletedItems.Add(CType(DeletedItems(mIndex), dmPurchaseOrderItem).Clone)
      Next
    Else
      mCol.DeletedItems = Nothing
    End If
    mCol.LoadStatus = LoadStatus
    Return mCol
  End Function

  Public Function ItemByStockItemID(ByVal vStockItemID As Integer) As dmPurchaseOrderItem
    Dim mRetVal As dmPurchaseOrderItem = Nothing

    For Each mItem As dmPurchaseOrderItem In MyBase.Items
      If mItem.StockItemID = vStockItemID Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function

  Public Function ItemByStockItemDescription(ByVal vStockItemDescription As String) As dmPurchaseOrderItem
    Dim mRetVal As dmPurchaseOrderItem = Nothing

    For Each mItem As dmPurchaseOrderItem In MyBase.Items
      If mItem.Description = vStockItemDescription Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function

  Public Function POItemsMinusAllocatedItem() As colPurchaseOrderItems
    Dim mRetVal As New colPurchaseOrderItems(pParent)
    For Each mPOItem As dmPurchaseOrderItem In MyBase.Items
      If mPOItem.PurchaseOrderItemAllocations.Count = 0 Or String.IsNullOrEmpty(mPOItem.Description) = False Then
        mRetVal.Add(mPOItem)
      End If
    Next
    Return mRetVal
  End Function

End Class




