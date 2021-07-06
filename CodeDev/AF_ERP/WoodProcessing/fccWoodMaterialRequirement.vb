Imports RTIS.CommonVB

Public Class fccWoodMaterialRequirement
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pMatReqItemProcessors As colMaterialRequirementProcessors
  Private pSalesOrderPhaseID As Integer
  Private pStockItemRegister As colStockItems
  Private pSalesOrder As dmSalesOrder
  Private pMatRequirements As colMaterialRequirements


  Public Enum eItemSelectedType
    NoneDirectDel = 1
    DirectDel = 2
    Mixed = 3
  End Enum


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

  Public Property SalesOrderPhaseID As Integer
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(value As Integer)
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property MatReqItemProcessors As colMaterialRequirementProcessors
    Get
      Return pMatReqItemProcessors
    End Get
    Set(value As colMaterialRequirementProcessors)
      pMatReqItemProcessors = value
    End Set
  End Property

  Public ReadOnly Property StockItemRegister As colStockItems
    Get
      Return pStockItemRegister
    End Get
  End Property

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property

  Public Sub LoadMatReqs()
    Dim mWhere As String = String.Empty
    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    Dim mdsoPurchaseOrder As New dsoPurchasing(pDBConn)
    Dim mMaterialRequirementInfos As New colMaterialRequirementInfos
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mStockItemIDs As New List(Of Integer)
    Dim mSalesOrderID As Integer
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemTransactions As New colStockItemTransactionLogs
    Dim mRemove As Boolean

    Try

      pMatReqItemProcessors = New colMaterialRequirementProcessors
      pStockItemRegister = New colStockItems


      If pSalesOrderPhaseID <> 0 Then

        mSalesOrderID = mdsoSalesOrder.GetSalesOrderIDFromSalesOrderPhaseID(pSalesOrderPhaseID)
        If mSalesOrderID <> 0 Then
          mdsoSalesOrder.LoadSalesOrderDown(pSalesOrder, mSalesOrderID)

        End If
        mWhere = "OSQty<>0 and SalesOrderPhaseID = " & pSalesOrderPhaseID & "MaterialRequirementType = " & CInt(eMaterialRequirementType.Wood)
        mdsoSalesOrder.LoadPhaseMatReqProcessors(pMatReqItemProcessors, mWhere)

      Else

        mWhere &= "MaterialRequirementType = " & CInt(eMaterialRequirementType.Wood) & " and OSQty<>0"
        mWhere &= " and WorkOrderID in (Select WorkOrderID from WorkOrder where Status = " & CInt(eWorkOrderStatus.Raised) & ")"

        mdsoSalesOrder.LoadPhaseMatReqProcessors(pMatReqItemProcessors, mWhere)

      End If

      pDBConn.Connect()

      For Each mMatReqProc As clsMaterialRequirementProcessor In pMatReqItemProcessors

        If mMatReqProc.StockItem.StockItemID <> 0 AndAlso mStockItemIDs.Contains(mMatReqProc.StockItem.StockItemID) = False AndAlso pStockItemRegister.ItemFromKey(mMatReqProc.StockItem.StockItemID) Is Nothing Then
          mStockItemIDs.Add(mMatReqProc.StockItem.StockItemID)
        End If
        '// Load allocations
        mWhere = "StockItemID = " & mMatReqProc.StockItem.StockItemID & " and CallOffID = " & mMatReqProc.SalesOrderPhaseID & " and (POstatus <>" & CInt(ePurchaseOrderDueDateStatus.Cancelled) & " and POstatus <> " & CInt(ePurchaseOrderDueDateStatus.Received) & ")"
        mWhere &= " and BalanceQty<>0"
        If mMatReqProc.SalesOrderPhaseID > 0 Then
          mdsoPurchaseOrder.LoadPurchaseOrderItemAllocationInfos(mMatReqProc.POItemAllocationInfos, mWhere)


          mMatReqProc.PickedQty = mMatReqProc.PickedQty 'mdsoStock.GetPhaseMatReqPickedQtyConnected(mMatReqProc.SalesOrderPhaseID, mMatReqProc.MaterialRequirement.StockItemID)
          mMatReqProc.StockItemLocationsQty = mdsoStock.GetCurrentInventory(mMatReqProc.StockItem.StockItemID)
          mMatReqProc.QuantityRequired = mMatReqProc.Quantity 'mdsoStock.GetPhaseMatReqRequiredQtyConnected(mMatReqProc.SalesOrderPhaseID, mMatReqProc.MaterialRequirement.StockItemID)
          mMatReqProc.QtyOrdered = mdsoStock.GetPhaseMatReqOrderedQtyConnected(mMatReqProc.SalesOrderPhaseID, mMatReqProc.MaterialRequirement.StockItemID)

        End If
      Next

      If pDBConn.IsConnected Then
        pDBConn.Disconnect()
      End If


      For mIndex As Integer = pMatReqItemProcessors.Count - 1 To 0 Step -1
        mRemove = False
        Dim mMatReqProc As clsMaterialRequirementProcessor = pMatReqItemProcessors(mIndex)


        If mMatReqProc.QuantityRequired - mMatReqProc.QtyReceived - mMatReqProc.FromStock <= 0 Then
          mRemove = True
        End If

        If mMatReqProc.QuantityRequired - mMatReqProc.PickedQty - mMatReqProc.FromStock <= 0 Then
          mRemove = True
        End If

        If mRemove = True Then
          pMatReqItemProcessors.RemoveAt(mIndex)
        End If

      Next


      If mStockItemIDs.Count > 0 Then
        mdsoStock.LoadStockItemsByWhere(pStockItemRegister, "StockItemID IN (" & String.Join(",", mStockItemIDs.ToArray) & ")")
        mdsoStock.LoadStockItemLocationsByWhere(mStockItemLocations, "StockItemID IN (" & String.Join(",", mStockItemIDs.ToArray) & ")")
      End If

      For Each mMRP As clsMaterialRequirementProcessor In pMatReqItemProcessors
        mMRP.StockItem = pStockItemRegister.ItemFromKey(mMRP.StockItem.StockItemID)
        mMRP.StockItemLocations = mStockItemLocations.ItemsFromStockItemID(mMRP.StockItem.StockItemID)
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function UpdateMaterialRequirementFromStockQty(ByVal vMatReq As dmMaterialRequirement) As Boolean
    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    Dim mOK As Boolean
    Try
      mOK = mdsoSalesOrder.UpdateMaterialRequirementFromStockQty(vMatReq)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function

  Public Function ProcessFromStock() As Integer
    Dim mCount As Integer = 0

    Try

      For Each mMRProcessor As clsMaterialRequirementProcessor In pMatReqItemProcessors

        If mMRProcessor.FromStock <> 0 Then
          mMRProcessor.MaterialRequirement.FromStockQty += mMRProcessor.FromStock
          mMRProcessor.FromStock = 0

          If UpdateMaterialRequirementFromStockQty(mMRProcessor.MaterialRequirement) Then
            mCount += 1
          End If
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mCount
  End Function

  Public Sub SetQtyFromStock(rMatReqItemProcessor As clsMaterialRequirementProcessor)
    rMatReqItemProcessor.ToOrder = 0
    rMatReqItemProcessor.FromStock = Math.Max(0.0, rMatReqItemProcessor.QuantityRequired - rMatReqItemProcessor.QtyOrdered - rMatReqItemProcessor.MaterialRequirement.FromStockQty)
  End Sub

  Public Sub ClearMatReqProcs()
    For Each mMatReqProc As clsMaterialRequirementProcessor In pMatReqItemProcessors
      mMatReqProc.ToOrder = 0
      mMatReqProc.FromStock = 0
    Next
  End Sub

  Public Sub SetBalQtyToOrder(ByRef rMatReqItemProcessor As clsMaterialRequirementProcessor)
    rMatReqItemProcessor.ToOrder = Math.Max(0.0, rMatReqItemProcessor.QuantityRequired - rMatReqItemProcessor.QtyOrdered - rMatReqItemProcessor.FromStock)
  End Sub

  Public Sub LoadTransactions(ByVal vMatReqProc As clsMaterialRequirementProcessor)
    Dim mWhere As String
    Dim mdsoStock As New dsoStockTransactions(pDBConn)
    Try

      mWhere = String.Format("RefObjectType = {0}  AND RefObjectID ={1}", CInt(eObjectType.MaterialRequirement), vMatReqProc.MaterialRequirement.MaterialRequirementID)
      mWhere &= " and SalesOrderPhaseID = " & vMatReqProc.SalesOrderPhaseID & " AND StockItemID = " & vMatReqProc.StockItem.StockItemID

      mdsoStock.LoadStockItemTransactionsByWhere(vMatReqProc.StockItemTransactionInfoss, mWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub



End Class
