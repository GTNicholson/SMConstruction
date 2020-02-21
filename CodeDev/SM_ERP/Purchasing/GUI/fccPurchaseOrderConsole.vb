Imports RTIS.CommonVB

Public Class fccPurchaseOrderConsole
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pMaterialRequirementGroup As Integer
  Private pOpenPOs As colPurchaseOrders
  Private pRefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker

  Private pSubSuppliersRefList As colSuppliers

  Public Sub New()
    pMaterialRequirementGroup = 1
    pSubSuppliersRefList = New colSuppliers
    pRefreshTracker = New RTIS.Elements.clsBasicBrowseRefreshTracker
  End Sub

  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  ''Public Property RefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker
  ''  Get
  ''    Return pRefreshTracker
  ''  End Get
  ''  Set(value As RTIS.Elements.clsBasicBrowseRefreshTracker)
  ''    pRefreshTracker = value
  ''  End Set
  ''End Property

  ''Public Property MaterialRequirementGroup() As Integer
  ''  Get
  ''    Return pMaterialRequirementGroup
  ''  End Get
  ''  Set(value As Integer)
  ''    pMaterialRequirementGroup = value
  ''  End Set
  ''End Property

  Public ReadOnly Property IsDirty As Boolean
    Get
      ''MsgBox("todo")
    End Get
  End Property

  Public Property OpenPOs As colPurchaseOrders
    Get
      Return pOpenPOs
    End Get
    Set(value As colPurchaseOrders)
      pOpenPOs = value
    End Set
  End Property

  Public Function SaveObject() As Boolean

  End Function

  ''Public Function LoadObject() As Boolean
  ''  Return True
  ''End Function

  ''Public Function LoadRefData() As Boolean
  ''  Return True
  ''End Function

  Public Function ProcessMatReqToPO(ByRef rMatReqProcs As colMaterialRequirementProcessors, ByRef rPO As dmPurchaseOrder) As Integer
    Dim mCount As Integer
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOIAllocation As dmPurchaseOrderItemAllocation
    Dim mExistingAllocation As dmPurchaseOrderItemAllocation = Nothing
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)


    For Each mMatReqProc As clsMaterialRequirementProcessor In rMatReqProcs

      If mMatReqProc.ToProcessQty > 0 Then

        '// Look for POitem on PO
        '' mPOItem = rPO.PurchaseOrderItems.ItemByStockItemID(mMatReqProc.StockItemID)

        '// If we didn't find one then create a new
        If mPOItem Is Nothing Then

          mPOItem = New dmPurchaseOrderItem
          '' mPOItem.StockItemID = mMatReqProc.StockItemID
          ''mPOItem.Description = mMatReqProc.StockItemDescription

          mPOIAllocation = New dmPurchaseOrderItemAllocation
          '' mPOIAllocation.CallOffID = mMatReqProc.MaterialRequirement.ParentID
          mPOIAllocation.Quantity = mMatReqProc.ToProcessQty

          mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

          rPO.PurchaseOrderItems.Add(mPOItem)
        Else
          '// There is an existing POItem for this stock code
          '// look for an allocation for this call off
          For Each mAlloc As dmPurchaseOrderItemAllocation In mPOItem.PurchaseOrderItemAllocations
            ''If mAlloc.CallOffID = mMatReqProc.ParentID Then
            ''  mExistingAllocation = mAlloc
            ''  Exit For
            ''End If
          Next
          If mExistingAllocation Is Nothing Then '//add a new allocation to the exiting po item
            mPOIAllocation = New dmPurchaseOrderItemAllocation
            ''  mPOIAllocation.CallOffID = mMatReqProc.MaterialRequirement.ParentID
            mPOIAllocation.Quantity = mMatReqProc.ToProcessQty

            mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

          Else '// update the allocation
            mExistingAllocation.Quantity = mExistingAllocation.Quantity + mMatReqProc.ToProcessQty
          End If
        End If


      End If
    Next
    ''   If mCount > 0 Then mdsoPurchaseOrder.SavePurchaseOrderDown(rPO)

    Return mCount
  End Function

  Public Function ProcessStockItemToPO(ByRef rStockItemProcessor As colStockItemProcessors, ByRef rPO As dmPurchaseOrder) As Integer
    Dim mCount As Integer
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOIAllocation As dmPurchaseOrderItemAllocation
    Dim mExistingAllocation As dmPurchaseOrderItemAllocation = Nothing
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)


    For Each mStockItemProcessor As clsStockItemProcessor In rStockItemProcessor

      If mStockItemProcessor.ToProcessQty > 0 Then

        '// Look for POitem on PO
        mPOItem = rPO.PurchaseOrderItems.ItemByStockItemID(mStockItemProcessor.StockItemID)

        '// If we didn't find one then create a new
        If mPOItem Is Nothing Then

          mPOItem = New dmPurchaseOrderItem
          mPOItem.StockItemID = mStockItemProcessor.StockItemID
          mPOItem.Description = mStockItemProcessor.Description

          mPOIAllocation = New dmPurchaseOrderItemAllocation
          mPOIAllocation.CallOffID = 0 ''this 0 is for Stock
          mPOIAllocation.Quantity = mStockItemProcessor.ToProcessQty

          mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

          rPO.PurchaseOrderItems.Add(mPOItem)
        Else
          '// There is an existing POItem for this stock code
          '// look for an allocation for this call off
          For Each mAlloc As dmPurchaseOrderItemAllocation In mPOItem.PurchaseOrderItemAllocations
            If mAlloc.CallOffID = 0 Then
              mExistingAllocation = mAlloc
              Exit For
            End If
          Next
          If mExistingAllocation Is Nothing Then '//add a new allocation to the exiting po item
            mPOIAllocation = New dmPurchaseOrderItemAllocation
            mPOIAllocation.CallOffID = 0
            mPOIAllocation.Quantity = mStockItemProcessor.ToProcessQty

            mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

          Else '// update the allocation
            mExistingAllocation.Quantity = mExistingAllocation.Quantity + mStockItemProcessor.ToProcessQty
          End If
        End If


      End If
    Next
    If mCount > 0 Then mdsoPurchaseOrder.SavePurchaseOrderDownNEW(rPO)

    Return mCount
  End Function

  ''Public Function ProcessStockItemSingleToPO(ByRef rStockItemProcessor As clsSICurrentStockProcessor, ByRef rPO As dmPurchaseOrder) As Integer
  ''  Dim mCount As Integer
  ''  Dim mPOItem As dmPurchaseOrderItem
  ''  Dim mPOCOIAllocation As dmPOCallOffItemAllocation
  ''  Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
  ''  'Dim mPOCallOffItem As dmPOCallOffItem


  ''  If rStockItemProcessor.ToOrder > 0 Then

  ''    '// Look for POitem on PO
  ''    mPOItem = rPO.PurchaseOrderItems.ItemByStockItemID(rStockItemProcessor.StockItemID, rStockItemProcessor.Brand)
  ''    '// If we didn't find one then create a new
  ''    If mPOItem Is Nothing Then
  ''      mPOItem = New dmPurchaseOrderItem

  ''      With mPOItem
  ''        .PurchaseOrderID = rPO.PurchaseOrderID
  ''        .Quantity = rStockItemProcessor.ToOrder
  ''        .ActualQuantity = rStockItemProcessor.ToOrder
  ''        .Description = rStockItemProcessor.Description '' mMatReqProc.OrderID.ToString
  ''        .StockItemID = rStockItemProcessor.StockItemID
  ''        .Brand = rStockItemProcessor.Brand
  ''        .DueDate = rPO.DateRequired
  ''        .PromisedDate = rPO.DatePromised

  ''        '  .PartNo = mSIProc.StockCode
  ''        '.VatRateCode = rPO.VatRateCode
  ''        '  If mSIProc.StockItem IsNot Nothing Then .PricingUnit = mSIProc.StockItem.PricingUnit
  ''        '// Set Price


  ''        Dim mUnitPrice As Decimal
  ''        If rStockItemProcessor.StockItem IsNot Nothing Then

  ''          mUnitPrice = rStockItemProcessor.PurchaseCost

  ''          .ItemPrice = mUnitPrice
  ''        Else
  ''          mUnitPrice = rStockItemProcessor.PurchaseCost
  ''        End If
  ''        '
  ''      End With


  ''    End If

  ''    If mPOItem.PurchaseOrderItemID <> 0 Then
  ''      '// POItem exists, UPDATE alter allocation req qty
  ''      mPOItem.Quantity += rStockItemProcessor.ToOrder


  ''      'If rPO.CallOffMode = eCallOffMode.SingleCO Then
  ''      '  '// Try find the call off item
  ''      '  mPOCallOffItem = rPO.POCallOffs(0).POCallOffItems.ItemByPOItem(mPOItem)
  ''      '  If mPOCallOffItem IsNot Nothing Then
  ''      '    '// UPDATE COItem
  ''      '    mPOCallOffItem.QtyRequired += mSIProc.ToOrder
  ''      '    If mPOCallOffItem.POCallOffItemAllocations IsNot Nothing Then
  ''      '      mPOCOIAllocation = mPOCallOffItem.POCallOffItemAllocations.ItemBySalesOrdeIDPhaseIDMatReqID(0, 0, 0)
  ''      '      If mPOCOIAllocation IsNot Nothing Then
  ''      '        mPOCOIAllocation.QuantityAllocated += mSIProc.ToOrder
  ''      '      Else
  ''      mPOCOIAllocation = New dmPOCallOffItemAllocation
  ''      mPOCOIAllocation.QuantityAllocated = rStockItemProcessor.ToOrder
  ''      mPOItem.POCallOffItemAllocations.Add(mPOCOIAllocation)
  ''      '        mPOCallOffItem.POCallOffItemAllocations.Add(mPOCOIAllocation)
  ''      '      End If
  ''      '    End If
  ''      '  Else
  ''      '    '// New COItem
  ''      '    mPOCallOffItem = New dmPOCallOffItem
  ''      '    mPOCallOffItem.POItem = mPOItem
  ''      '    mPOCallOffItem.QtyRequired = mSIProc.ToOrder
  ''      '    rPO.POCallOffs(0).POCallOffItems.Add(mPOCallOffItem)
  ''      '  End If
  ''      'End If
  ''    Else


  ''      '// new Call off Item
  ''      'If rPO.CallOffMode = eCallOffMode.SingleCO Then
  ''      '  mPOCallOffItem = New dmPOCallOffItem
  ''      '  mPOCallOffItem.POItem = mPOItem
  ''      '  mPOCallOffItem.QtyRequired = mSIProc.ToOrder

  ''      mPOCOIAllocation = New dmPOCallOffItemAllocation
  ''      mPOCOIAllocation.QuantityAllocated = rStockItemProcessor.ToOrder
  ''      mPOItem.POCallOffItemAllocations.Add(mPOCOIAllocation)
  ''      '  mPOCallOffItem.POCallOffItemAllocations.Add(mPOCOIAllocation)

  ''      '  rPO.POCallOffs(0).POCallOffItems.Add(mPOCallOffItem)
  ''      'End If

  ''      rPO.PurchaseOrderItems.Add(mPOItem)
  ''    End If

  ''    mCount += 1
  ''  End If

  ''  If mCount > 0 Then mdsoPurchaseOrder.SavePurchaseOrder(rPO, False)
  ''  Return mCount
  ''End Function

  ''Public Property SubSuppliersRefList As colSuppliers
  ''  Get
  ''    Return pSubSuppliersRefList
  ''  End Get
  ''  Set(value As colSuppliers)
  ''    pSubSuppliersRefList = value
  ''  End Set
  ''End Property

  Public Function LoadPurchaseOrderInfos(ByVal vWhere As String) As colPurchaseOrderInfos
    Dim mPOInfos As New colPurchaseOrderInfos
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
    Try
      ''mdsoPurchaseOrder.LoadPurchaseOrderInfos(mPOInfos, vWhere, "PurchaseOrderID")
      mdsoPurchaseOrder.LoadPurchaseOrderInfos(mPOInfos, vWhere) ''Adapted according to HallAndTawse
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoPurchaseOrder = Nothing
    End Try

    Return mPOInfos
  End Function

  ''Public Function FindCreateDefaultPO(ByVal vSupplierID As Integer) As dmPurchaseOrder
  ''  Dim mPO As dmPurchaseOrder
  ''  Dim mFound As Boolean
  ''  Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
  ''  Dim mRetVal As dmPurchaseOrder = Nothing
  ''  If pOpenPOs Is Nothing Then pOpenPOs = New colPurchaseOrders
  ''  For Each mPO In pOpenPOs
  ''    If mPO.SupplierID = vSupplierID Then
  ''      mFound = True
  ''      mRetVal = mPO
  ''      Exit For
  ''    End If
  ''  Next

  ''  If Not mFound Then
  ''    'Create and save a new Purchase Order
  ''    mPO = New dmPurchaseOrder
  ''    mPO.Status = ePurchaseOrderStatus.ePOSOutstanding
  ''    mPO.SupplierID = vSupplierID
  ''    mPO.DateSubmitted = Today
  ''    mPO.CreatedInERP = True

  ''    mdsoPurchasing.SavePurchaseOrder(mPO, False)

  ''    mRetVal = mPO

  ''  End If

  ''  Return mRetVal

  ''End Function

End Class
