Imports RTIS.CommonVB

Public Class fccPurchaseOrderConsole
  'Private pDBConn As RTIS.DataLayer.clsDBConnBase
  'Private pRTISGlobal As AppRTISGlobal
  'Private pMaterialRequirementGroup As Integer
  'Private pOpenPOs As colPurchaseOrders
  'Private pRefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker

  'Private pSubSuppliersRefList As colSuppliers

  'Public Sub New()
  '  pMaterialRequirementGroup = 1
  '  pSubSuppliersRefList = New colSuppliers
  '  pRefreshTracker = New RTIS.Elements.clsBasicBrowseRefreshTracker
  'End Sub

  'Public Property DBConn As RTIS.DataLayer.clsDBConnBase
  '  Get
  '    Return pDBConn
  '  End Get
  '  Set(value As RTIS.DataLayer.clsDBConnBase)
  '    pDBConn = value
  '  End Set
  'End Property

  'Public Property RTISGlobal As AppRTISGlobal
  '  Get
  '    Return pRTISGlobal
  '  End Get
  '  Set(value As AppRTISGlobal)
  '    pRTISGlobal = value
  '  End Set
  'End Property

  'Public Property RefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker
  '  Get
  '    Return pRefreshTracker
  '  End Get
  '  Set(value As RTIS.Elements.clsBasicBrowseRefreshTracker)
  '    pRefreshTracker = value
  '  End Set
  'End Property

  'Public Property MaterialRequirementGroup() As Integer
  '  Get
  '    Return pMaterialRequirementGroup
  '  End Get
  '  Set(value As Integer)
  '    pMaterialRequirementGroup = value
  '  End Set
  'End Property

  'Public ReadOnly Property IsDirty As Boolean
  '  Get
  '    Return False
  '  End Get
  'End Property

  'Public Property OpenPOs As colPurchaseOrders
  '  Get
  '    Return pOpenPOs
  '  End Get
  '  Set(value As colPurchaseOrders)
  '    pOpenPOs = value
  '  End Set
  'End Property

  'Public Function SaveObject() As Boolean
  '  Return True
  'End Function

  'Public Function LoadObject() As Boolean
  '  Return True
  'End Function

  'Public Function LoadRefData() As Boolean
  '  Return True
  'End Function

  'Public Function ProcessMatReqToPO(ByRef rMatReqProcs As colMaterialRequirementProcessors, ByRef rPO As dmPurchaseOrder) As Integer
  '  Dim mCount As Integer
  '  Dim mPOItem As dmPurchaseOrderItem
  '  Dim mPOIAllocation As dmPurchaseOrderItemAllocation
  '  Dim mExistingAllocation As dmPurchaseOrderItemAllocation = Nothing
  '  Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)


  '  For Each mMatReqProc As clsMaterialRequirementProcessor In rMatReqProcs

  '    If mMatReqProc.ToOrder > 0 Then

  '      '// Look for POitem on PO
  '      mPOItem = rPO.PurchaseOrderItems.ItemByStockItemID(mMatReqProc.StockItem.StockItemID)

  '      '// If we didn't find one then create a new
  '      If mPOItem Is Nothing Then

  '        mPOItem = New dmPurchaseOrderItem
  '        mPOItem.StockItemID = mMatReqProc.StockItem.StockItemID
  '        mPOItem.Description = mMatReqProc.StockItem.Description
  '        mPOItem.QtyRequired = mMatReqProc.ToOrder

  '        mPOIAllocation = New dmPurchaseOrderItemAllocation
  '        mPOIAllocation.CallOffID = mMatReqProc.MaterialRequirement.ParentID
  '        mPOIAllocation.Quantity = mMatReqProc.ToOrder

  '        mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

  '        rPO.PurchaseOrderItems.Add(mPOItem)
  '      Else
  '        '// There is an existing POItem for this stock code
  '        '// look for an allocation for this call off
  '        For Each mAlloc As dmPurchaseOrderItemAllocation In mPOItem.PurchaseOrderItemAllocations
  '          If mAlloc.CallOffID = mMatReqProc.SalesOrderPhaseID Then
  '            mExistingAllocation = mAlloc
  '            Exit For
  '          End If
  '        Next
  '        If mExistingAllocation Is Nothing Then '//add a new allocation to the exiting po item
  '          mPOIAllocation = New dmPurchaseOrderItemAllocation
  '          mPOIAllocation.CallOffID = mMatReqProc.MaterialRequirement.ParentID
  '          mPOIAllocation.Quantity = mMatReqProc.ToOrder

  '          mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

  '        Else '// update the allocation
  '          mExistingAllocation.Quantity = mExistingAllocation.Quantity + mMatReqProc.ToOrder
  '        End If
  '      End If
  '      mCount += 1

  '    End If

  '  Next
  '  If mCount > 0 Then mdsoPurchaseOrder.SavePurchaseOrderDown(rPO)

  '  Return mCount
  'End Function

  'Public Function ProcessStockItemToPO(ByRef rStockItemProcessor As colStockItemProcessors, ByRef rPO As dmPurchaseOrder) As Integer
  '  Dim mCount As Integer
  '  Dim mPOItem As dmPurchaseOrderItem
  '  Dim mPOIAllocation As dmPurchaseOrderItemAllocation
  '  Dim mExistingAllocation As dmPurchaseOrderItemAllocation = Nothing
  '  Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)


  '  For Each mStockItemProcessor As clsStockItemProcessor In rStockItemProcessor

  '    If mStockItemProcessor.ToProcessQty > 0 Then

  '      '// Look for POitem on PO
  '      mPOItem = rPO.PurchaseOrderItems.ItemByStockItemID(mStockItemProcessor.StockItemID)

  '      '// If we didn't find one then create a new
  '      If mPOItem Is Nothing Then

  '        mPOItem = New dmPurchaseOrderItem
  '        mPOItem.StockItemID = mStockItemProcessor.StockItemID
  '        mPOItem.Description = mStockItemProcessor.Description

  '        mPOIAllocation = New dmPurchaseOrderItemAllocation
  '        mPOIAllocation.CallOffID = 0 ''this 0 is for Stock
  '        mPOIAllocation.Quantity = mStockItemProcessor.ToProcessQty

  '        mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

  '        rPO.PurchaseOrderItems.Add(mPOItem)
  '      Else
  '        '// There is an existing POItem for this stock code
  '        '// look for an allocation for this call off
  '        For Each mAlloc As dmPurchaseOrderItemAllocation In mPOItem.PurchaseOrderItemAllocations
  '          If mAlloc.CallOffID = 0 Then
  '            mExistingAllocation = mAlloc
  '            Exit For
  '          End If
  '        Next
  '        If mExistingAllocation Is Nothing Then '//add a new allocation to the exiting po item
  '          mPOIAllocation = New dmPurchaseOrderItemAllocation
  '          mPOIAllocation.CallOffID = 0
  '          mPOIAllocation.Quantity = mStockItemProcessor.ToProcessQty

  '          mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

  '        Else '// update the allocation
  '          mExistingAllocation.Quantity = mExistingAllocation.Quantity + mStockItemProcessor.ToProcessQty
  '        End If
  '      End If

  '      mCount += 1
  '    End If

  '  Next
  '  mdsoPurchaseOrder.SavePurchaseOrderDown(rPO)

  '  Return mCount
  'End Function

  'Public Property SubSuppliersRefList As colSuppliers
  '  Get
  '    Return pSubSuppliersRefList
  '  End Get
  '  Set(value As colSuppliers)
  '    pSubSuppliersRefList = value
  '  End Set
  'End Property

  'Public Function LoadPurchaseOrderInfos() As colPurchaseOrderInfos
  '  Dim mPOInfos As New colPurchaseOrderInfos
  '  Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)

  '  Try

  '    mdsoPurchaseOrder.LoadPurchaseOrderInfos(mPOInfos, "")
  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  '  Finally
  '    mdsoPurchaseOrder = Nothing
  '  End Try

  '  Return mPOInfos
  'End Function

End Class
