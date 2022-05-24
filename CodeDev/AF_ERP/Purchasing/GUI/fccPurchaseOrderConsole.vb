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

  Public Property RefreshTracker As RTIS.Elements.clsBasicBrowseRefreshTracker
    Get
      Return pRefreshTracker
    End Get
    Set(value As RTIS.Elements.clsBasicBrowseRefreshTracker)
      pRefreshTracker = value
    End Set
  End Property

  Public Property MaterialRequirementGroup() As Integer
    Get
      Return pMaterialRequirementGroup
    End Get
    Set(value As Integer)
      pMaterialRequirementGroup = value
    End Set
  End Property

  Public ReadOnly Property IsDirty As Boolean
    Get
      Return False
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
    Return True
  End Function

  Public Function LoadObject() As Boolean
    Return True
  End Function

  Public Function LoadRefData() As Boolean
    Return True
  End Function

  Public Function ProcessMatReqToPO(ByRef rMatReqProcs As colMaterialRequirementProcessors, ByRef rPO As dmPurchaseOrder, ByVal vPOConsoleOption As Integer) As Integer
    Dim mCount As Integer
    Dim mPOItem As dmPurchaseOrderItem
    Dim mPOIAllocation As dmPurchaseOrderItemAllocation
    Dim mExistingAllocation As dmPurchaseOrderItemAllocation = Nothing
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)


    For Each mMatReqProc As clsMaterialRequirementProcessor In rMatReqProcs

      If mMatReqProc.ToOrder > 0 Then

        '// Look for POitem on PO
        mPOItem = rPO.PurchaseOrderItems.ItemByStockItemID(mMatReqProc.StockItem.StockItemID)

        '// If we didn't find one then create a new
        If mPOItem Is Nothing Then

          mPOItem = New dmPurchaseOrderItem
          mPOItem.StockItemID = mMatReqProc.StockItem.StockItemID
          mPOItem.Description = mMatReqProc.StockItem.Description
          mPOItem.QtyRequired = mMatReqProc.ToOrder
          mPOItem.UoM = mMatReqProc.StockItem.UoM

          mPOIAllocation = New dmPurchaseOrderItemAllocation

          If vPOConsoleOption = ePOConsoleOption.MaintenanceWorkOrder Then
            mPOIAllocation.MaintenanceWorkOrderID = mMatReqProc.MaterialRequirement.ObjectID
          Else
            mPOIAllocation.WorkOrderID = mMatReqProc.MaterialRequirement.ObjectID

          End If

          mPOIAllocation.Quantity = mMatReqProc.ToOrder
          mPOIAllocation.ProjectRef = mMatReqProc.ProjectName
          mPOIAllocation.ItemRef = mMatReqProc.WorkOrder.WorkOrderNo
          mPOIAllocation.ItemRef2 = mMatReqProc.WorkOrder.Description
          mPOIAllocation.ProjectRef = mMatReqProc.ProjectName

          mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)



          rPO.PurchaseOrderItems.Add(mPOItem)


        Else
          '// There is an existing POItem for this stock code
          '// look for an allocation for this call off
          For Each mAlloc As dmPurchaseOrderItemAllocation In mPOItem.PurchaseOrderItemAllocations

            If vPOConsoleOption = ePOConsoleOption.MaintenanceWorkOrder Then
              If mAlloc.MaintenanceWorkOrderID = mMatReqProc.MaterialRequirement.ObjectID Then
                mExistingAllocation = mAlloc
                Exit For
              Else
                mExistingAllocation = Nothing
              End If
            Else
              If mAlloc.WorkOrderID = mMatReqProc.MaterialRequirement.ObjectID Then
                mExistingAllocation = mAlloc
                Exit For
              Else
                mExistingAllocation = Nothing
              End If
            End If


          Next
          If mExistingAllocation Is Nothing Then '//add a new allocation to the exiting po item
              mPOIAllocation = New dmPurchaseOrderItemAllocation
            mPOIAllocation.Quantity = mMatReqProc.ToOrder
            If vPOConsoleOption = ePOConsoleOption.MaintenanceWorkOrder Then
              mPOIAllocation.MaintenanceWorkOrderID = mMatReqProc.MaterialRequirement.ObjectID

            Else
              mPOIAllocation.WorkOrderID = mMatReqProc.MaterialRequirement.ObjectID

            End If


            mPOIAllocation.ItemRef = mMatReqProc.WorkOrder.WorkOrderNo
            mPOIAllocation.ItemRef2 = mMatReqProc.WorkOrder.Description
              mPOIAllocation.ProjectRef = mMatReqProc.ProjectName

              mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

            Else '// update the allocation
              mExistingAllocation.Quantity = mExistingAllocation.Quantity + mMatReqProc.ToOrder
            End If
          End If
          mCount += 1
          Dim mPOA As dmPurchaseOrderAllocation

        If vPOConsoleOption = ePOConsoleOption.MaintenanceWorkOrder Then
          mPOA = rPO.PurchaseOrderAllocations.ItemFromMaintenanceWorkOrderID(mMatReqProc.MaterialRequirement.ObjectID)


        Else
          mPOA = rPO.PurchaseOrderAllocations.ItemFromWorkOrderID(mMatReqProc.MaterialRequirement.ObjectID)

        End If

        If mPOA Is Nothing Then
          mPOA = New dmPurchaseOrderAllocation
          mPOA.PurchaseOrderID = rPO.PurchaseOrderID

          If vPOConsoleOption = ePOConsoleOption.MaintenanceWorkOrder Then
            mPOA.MaintenanceWorkOrderID = mMatReqProc.MaterialRequirement.ObjectID

          Else
            mPOA.WorkOrderID = mMatReqProc.MaterialRequirement.ObjectID

          End If


          rPO.PurchaseOrderAllocations.Add(mPOA)
        End If

      End If

    Next

    If mCount > 0 Then

      Select Case vPOConsoleOption
        Case ePOConsoleOption.MaintenanceWorkOrder
          If rPO.PurchaseOrderAllocations.Count = 1 Then
            rPO.MaterialRequirementTypeMaintenanceID = ePOMaterialRequirementType.Sencillo

          ElseIf rPO.PurchaseOrderAllocations.Count > 1 Then
            rPO.MaterialRequirementTypeMaintenanceID = ePOMaterialRequirementType.Multiple
          Else
            If rPO.PurchaseOrderAllocations.Count = 0 Then
              rPO.MaterialRequirementTypeMaintenanceID = ePOMaterialRequirementType.Inventario
            End If
          End If


        Case Else
          If rPO.PurchaseOrderAllocations.Count = 1 Then
            rPO.MaterialRequirementTypeWorkOrderID = ePOMaterialRequirementType.Sencillo

          ElseIf rPO.PurchaseOrderAllocations.Count > 1 Then
            rPO.MaterialRequirementTypeWorkOrderID = ePOMaterialRequirementType.Multiple
          Else
            If rPO.PurchaseOrderAllocations.Count = 0 Then
              rPO.MaterialRequirementTypeWorkOrderID = ePOMaterialRequirementType.Inventario
            End If
          End If
      End Select



      ''Update Qtys from all POIA
      For Each mPOI As dmPurchaseOrderItem In rPO.PurchaseOrderItems

        mPOI.QtyRequired = mPOI.PurchaseOrderItemAllocations.TotalQuantityAllocated()
      Next
      mdsoPurchaseOrder.SavePurchaseOrderDownNEW(rPO)
    End If

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
          mPOItem.UoM = mStockItemProcessor.UoM

          mPOIAllocation = New dmPurchaseOrderItemAllocation
          mPOIAllocation.CallOffID = 0 ''this 0 is for Stock
          mPOIAllocation.Quantity = mStockItemProcessor.ToProcessQty
          mPOIAllocation.WorkOrderID = 0
          mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

          rPO.PurchaseOrderItems.Add(mPOItem)
        Else
          '// There is an existing POItem for this stock code
          '// look for an allocation for this call off
          For Each mAlloc As dmPurchaseOrderItemAllocation In mPOItem.PurchaseOrderItemAllocations
            If mAlloc.WorkOrderID = 0 Then
              mExistingAllocation = mAlloc
              Exit For
            End If
          Next
          If mExistingAllocation Is Nothing Then '//add a new allocation to the exiting po item
            mPOIAllocation = New dmPurchaseOrderItemAllocation
            mPOIAllocation.CallOffID = 0
            mPOIAllocation.Quantity = mStockItemProcessor.ToProcessQty
            mPOIAllocation.WorkOrderID = 0

            mPOItem.PurchaseOrderItemAllocations.Add(mPOIAllocation)

          Else '// update the allocation
            mExistingAllocation.Quantity = mExistingAllocation.Quantity + mStockItemProcessor.ToProcessQty
          End If
        End If

        mCount += 1
      End If

    Next
    mdsoPurchaseOrder.SavePurchaseOrderDownNEW(rPO)

    Return mCount
  End Function

  Public Property SubSuppliersRefList As colSuppliers
    Get
      Return pSubSuppliersRefList
    End Get
    Set(value As colSuppliers)
      pSubSuppliersRefList = value
    End Set
  End Property

  Public Property OptionConsole As ePOConsoleOption

  Public Function LoadPurchaseOrderInfos() As colPurchaseOrderInfos
    Dim mPOInfos As New colPurchaseOrderInfos
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
    Dim mWhere As String = ""
    Try
      mWhere = String.Format("Status not in ({0},{1})", CInt(ePurchaseOrderDueDateStatus.Received), CInt(ePurchaseOrderDueDateStatus.Cancelled))
      mdsoPurchaseOrder.LoadPurchaseOrderInfosOnly(mPOInfos, mWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoPurchaseOrder = Nothing
    End Try

    Return mPOInfos
  End Function

End Class
