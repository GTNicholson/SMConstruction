Imports RTIS.CommonVB
Imports RTIS.DataLayer
Public Class dsoPurchasing
  Private pDBConn As clsDBConnBase

  Public Sub New(ByVal vDBConn As clsDBConnBase)
    pDBConn = vDBConn
  End Sub

  Public Function LoadPurchaseOrderInfosOnly(ByRef rPurchaseOrderInfos As colPurchaseOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdtoPurchaseOrderInfo As New dtoPurchaseOrderInfo(pDBConn)

    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdtoPurchaseOrderInfo.LoadPurchaseOrderInfoCollection(rPurchaseOrderInfos, vWhere)



    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function


  Public Function LoadPurchaseOrderInfosDown(ByRef rPurchaseOrderInfos As colPurchaseOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdtoPurchaseOrderInfo As New dtoPurchaseOrderInfo(pDBConn)
    Dim mPOItemInfos As colPOItemInfos
    Dim mdtoPurchaseOrderItem As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtoPurchaseOrderAllocation As New dtoPurchaseOrderAllocation(pDBConn)
    Dim mdtoSalesOrderPhaseInfo As New dtoSalesOrderPhaseInfo(pDBConn)

    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdtoPurchaseOrderInfo.LoadPurchaseOrderInfoCollection(rPurchaseOrderInfos, vWhere)

      If rPurchaseOrderInfos IsNot Nothing Then




        For Each mPurchaseOrderInfo As clsPurchaseOrderInfo In rPurchaseOrderInfos


          mdtoPurchaseOrderAllocation.LoadPurchaseOrderAllocationCollection(mPurchaseOrderInfo.PurchaseOrder.PurchaseOrderAllocations, mPurchaseOrderInfo.PurchaseOrder.PurchaseOrderID)


          ''//Loading PO Allocations
          mPOItemInfos = New colPOItemInfos

          mdtoPurchaseOrderItem.LoadPurchaseOrderItemCollection(mPurchaseOrderInfo.PurchaseOrder.PurchaseOrderItems, mPurchaseOrderInfo.PurchaseOrder.PurchaseOrderID)


          ''//Loading SalesOrderPhases
          mdtoSalesOrderPhaseInfo.LoadSOPCollectionByWhere(mPurchaseOrderInfo.SalesOrderPhaseInfos, "")

          ''//Loading POItems

          If mPurchaseOrderInfo.PurchaseOrder.PurchaseOrderItems IsNot Nothing Then
            For Each mPOItem As dmPurchaseOrderItem In mPurchaseOrderInfo.PurchaseOrder.PurchaseOrderItems
              If String.IsNullOrEmpty(mPOItem.Description) = False Then

                mPOItemInfos.Add(New clsPOItemInfo(mPOItem, Nothing))
              End If
            Next
            mPurchaseOrderInfo.POItemInfos = mPOItemInfos
          End If



        Next

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function




  Public Function LoadSupplierDown(ByRef rSupplier As dmSupplier, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSupplier
    Dim mdtoSC As dtoSupplierContact

    Try

      pDBConn.Connect()
      mdto = New dtoSupplier(pDBConn)
      mdto.LoadSupplier(rSupplier, vID)
      mdtoSC = New dtoSupplierContact(pDBConn)
      mdtoSC.LoadSupplierContactCollection(rSupplier.SupplierContacts, rSupplier.SupplierID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Sub LoadPODeliveryItemInfoByWhere(ByRef rPODeliveryItemInfos As colPODeliveryItemInfos, ByVal vWhere As String)
    Dim mdto As dtoPODeliveryItemInfo

    Try


      pDBConn.Connect()
      mdto = New dtoPODeliveryItemInfo(pDBConn)


      mdto.LoadPODeliveryItemInfoCollectionByWhere(rPODeliveryItemInfos, vWhere)



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function LoadWorkOrderPurchaseOrdersDownByWorkOrderIDAndCategory(ByRef rPurchaseOrders As colPurchaseOrders, ByVal vWorkOrderID As Integer, ByVal vCategory As eMatReqCategoryStatus) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoPurchaseOrder
    Dim mSQL As String
    Try
      mdto = New dtoPurchaseOrder(pDBConn)
      pDBConn.Connect()

      mSQL = "PurchaseOrderID In (Select Distinct PO.PurchaseOrderID "
      mSQL &= "From PurchaseOrder PO Inner Join PurchaseOrderAllocation POA on POA.PurchaseOrderID = PO.PurchaseOrderID "
      mSQL &= " inner Join SalesOrderPhaseItem SOPI on SOPI.SalesOrderPhaseID=POA.CallOffID "
      mSQL &= "inner Join WorkOrderAllocation WOA on WOA.SalesOrderPhaseItemID=sopi.SalesOrderPhaseItemID "
      mSQL = mSQL & " Where WOA.WorkOrderID = " & vWorkOrderID
      mSQL = mSQL & " And PO.Category = " & vCategory
      mSQL = mSQL & ")"

      mdto.LoadPurchaseOrderCollection(rPurchaseOrders, mSQL)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadSuppliersByWhere(ByRef rSuppliers As colSuppliers, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSupplier

    Try

      pDBConn.Connect()
      mdto = New dtoSupplier(pDBConn)
      mdto.LoadSupplierCollectionByWhere(rSuppliers, vWhere)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function UpdateWorkOrderPickStatusNotRequireds(ByVal vWorkOrderID As Integer, ByVal vMatReqCategory As Byte, ByVal vMatCatStatus As eMatReqCategoryStatus) As Boolean
    Dim mSQL As String
    Dim mOK As Boolean

    Try
      mOK = True

      pDBConn.Connect()

      If vMatCatStatus = eMatReqCategoryStatus.NotRequired Then
        '// update the production batches that are on pending to Not Required
        mSQL = String.Format("UPDATE WorkOrderPickStatus SET PickStatus = {0} WHERE PickStatus = {1} And MatReqCategory = {2} AND WorkOrderID IN (SELECT WorkOrderID FROM WorkOrder WHERE WorkOrderID = {3})", CInt(eStatusNonePartComplete.NotRequired), CInt(eStatusNonePartComplete.None), vMatReqCategory, vWorkOrderID)
        pDBConn.ExecuteCommand(mSQL)
      Else
        '// Update the production batches that are on Not Required to pending
        mSQL = String.Format("UPDATE WorkOrderPickStatus SET PickStatus = {0} WHERE PickStatus = {1} And MatReqCategory = {2} AND WorkOrderID IN (SELECT WorkOrderID FROM WorkOrder WHERE WorkOrderID = {3})", CInt(eStatusNonePartComplete.None), CInt(eStatusNonePartComplete.NotRequired), vMatReqCategory, vWorkOrderID)
        pDBConn.ExecuteCommand(mSQL)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      mOK = False
    End Try

    Return mOK
  End Function


  ''Public Function SavePurchaseOrderDown(ByRef rPurchaseOrder As dmPurchaseOrder) As Boolean
  ''  Dim mRetVal As Boolean
  ''  Dim mdtoPO As dtoPurchaseOrder
  ''  Dim mdtoPOI As dtoPurchaseOrderItem
  ''  Dim mdtoPOIA As dtoPurchaseOrderItemAllocation

  ''  Try
  ''    pDBConn.Connect()
  ''    mdtoPO = New dtoPurchaseOrder(pDBConn)
  ''    mdtoPO.SavePurchaseOrder(rPurchaseOrder)

  ''    mdtoPOI = New dtoPurchaseOrderItem(pDBConn)
  ''    mdtoPOI.SavePurchaseOrderItemCollection(rPurchaseOrder.PurchaseOrderItems, rPurchaseOrder.PurchaseOrderID)


  ''    mdtoPOIA = New dtoPurchaseOrderItemAllocation(pDBConn)
  ''    For Each mPOI As dmPurchaseOrderItem In rPurchaseOrder.PurchaseOrderItems
  ''      mdtoPOIA.SavePurchaseOrderItemAllocationCollection(mPOI.PurchaseOrderItemAllocations, mPOI.PurchaseOrderItemID)
  ''    Next

  ''    mRetVal = True
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try

  ''  Return mRetVal
  ''End Function

  Public Function SavePurchaseOrderDownNEW(ByRef rPurchaseOrder As dmPurchaseOrder) As Boolean
    Dim mdtoPO As New dtoPurchaseOrder(pDBConn)
    Dim mdtoPOItem As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtoPOAllocation As New dtoPurchaseOrderAllocation(pDBConn)
    Dim mdtoPOItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)
    Dim mdtoSupplier As New dtoSupplier(pDBConn)

    Dim mOK As Boolean
    Dim mdtoPOFiles As dtoFileTracker
    Try
      If pDBConn.Connect() Then
        Try
          pDBConn.ConnectionBeginTrans()

          If String.IsNullOrEmpty(rPurchaseOrder.PONum) Then
            rPurchaseOrder.PONum = GetNextPurchaseOrderNo()
          End If

          mOK = mdtoPO.SavePurchaseOrder(rPurchaseOrder)
          If mOK Then mOK = mdtoSupplier.SaveSupplier(rPurchaseOrder.Supplier)


          If mOK Then mOK = mdtoPOItem.SavePurchaseOrderItemCollection(rPurchaseOrder.PurchaseOrderItems, rPurchaseOrder.PurchaseOrderID)

          For Each mPOItem As dmPurchaseOrderItem In rPurchaseOrder.PurchaseOrderItems
            If mOK Then
              mOK = mdtoPOItemAllocation.SavePurchaseOrderItemAllocationCollection(mPOItem.PurchaseOrderItemAllocations, mPOItem.PurchaseOrderItemID)
            End If
          Next
          If mOK Then mOK = mdtoPOAllocation.SavePurchaseOrderAllocationCollection(rPurchaseOrder.PurchaseOrderAllocations, rPurchaseOrder.PurchaseOrderID)

          mdtoPOFiles = New dtoFileTracker(pDBConn)
          mdtoPOFiles.LoadFileTrackerCollection(rPurchaseOrder.POFiles, eObjectType.StockItemAmmendmentLog, rPurchaseOrder.PurchaseOrderID)


        Catch ex As Exception
          mOK = False
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
        Finally

          If mOK Then
            pDBConn.ConnectionCommitTrans()
          Else
            pDBConn.ConnectionRollBackTrans()
          End If
        End Try
      Else
        mOK = False
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdtoPO = Nothing
      mdtoPOItem = Nothing

      ''mdtoPODelivery = Nothing
      ''mdtoPODeliveryItem = Nothing
    End Try

    Return mOK
  End Function

  Public Sub LoadPODeliveryInfoByWhere(ByRef rPODeliveryInfos As colPODeliveryInfos, ByVal vWhere As String)

    Dim mdto As New dtoPODeliveryInfo(pDBConn)
    Try

      pDBConn.Connect()

      mdto.LoadPODeliveryInfoCollectionByWhere(rPODeliveryInfos, vWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing

    End Try
  End Sub

  Public Function LoadPODeliveryDT(ByRef rTable As DataTable, ByVal vWhere As String) As Boolean
    Dim mOK As Boolean
    Dim mDataTable As New DataTable
    Dim mSQL As String
    Try

      mSQL = "Select * from vwPODeliveryInfo " & vWhere
      If pDBConn.Connect() Then
        mDataTable = pDBConn.CreateDataTable(mSQL)
        If mDataTable Is Nothing Then
          mOK = False
        Else
          mOK = True
        End If

      Else
        mOK = False
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    rTable = mDataTable
    Return mOK
  End Function
  Public Function LoadPODeliveryDown(ByRef rPODelivery As dmPODelivery, ByVal vPrimaryKey As Int32) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoPODelivery
    Dim mdtoItems As dtoPODeliveryItem

    Try
      pDBConn.Connect()
      mdto = New dtoPODelivery(pDBConn)
      mdto.LoadPODelivery(rPODelivery, vPrimaryKey)
      mdtoItems = New dtoPODeliveryItem(pDBConn)
      mdtoItems.LoadPODeliveryItemCollection(rPODelivery.PODeliveryItems, rPODelivery.PODeliveryID)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Sub LoadPurchaseOrderItemAllocationInfoByWhere(ByRef rPOItemAllocationProcessors As colPurchaseOrderItemAllocationInfos, ByVal vWhere As String)

    Dim mdto As dtoPurchaseOrderItemAllocationInfo
    Dim mdtoPODI As dtoPODeliveryItem


    Try
      mdto = New dtoPurchaseOrderItemAllocationInfo(pDBConn, dtoPurchaseOrderItemAllocationInfo.eMode.Processor)

      pDBConn.Connect()

      mdto.LoadPurchaseOrderItemAllocationInfos(rPOItemAllocationProcessors, vWhere)

      mdtoPODI = New dtoPODeliveryItem(pDBConn)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Sub LoadPurchaseOrderItemAllocationProcessorss(ByRef rPOItemAllocationProcessors As colPurchaseOrderItemAllocationProcessor, ByVal vPurchaseOrderID As Integer)

    Dim mdto As dtoPurchaseOrderItemAllocationInfo
    Dim mdtoPODI As dtoPODeliveryItem
    Dim mPODIs As colPODeliveryItems
    Dim mPOIA As clsPurchaseOrderItemAllocationProcessor
    Dim mWhere As String

    Try
      mdto = New dtoPurchaseOrderItemAllocationInfo(pDBConn, dtoPurchaseOrderItemAllocationInfo.eMode.Processor)

      pDBConn.Connect()

      mWhere = "PurchaseOrderID = " & vPurchaseOrderID
      mdto.LoadPurchaseOrderItemAllocationProcessorsByWhere(rPOItemAllocationProcessors, mWhere)

      mdtoPODI = New dtoPODeliveryItem(pDBConn)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Function getPODeliverysByPurchaseOrderID(ByVal vPurchaseOrderID As Integer) As Integer
    Dim mRetVal As Integer
    Dim mSql As String
    mSql = "select COUNT(*) from PODelivery where PurchaseOrderID=" & vPurchaseOrderID


    Try
      pDBConn.Connect()
      mRetVal = CInt(pDBConn.ExecuteScalar(mSql))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


    Return mRetVal
  End Function

  Public Function LoadPurchaseOrderInfo(ByRef rvwPurchaseOrder As clsPurchaseOrderInfo, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoPurchaseOrderInfo


    Try
      pDBConn.Connect()
      mdto = New dtoPurchaseOrderInfo(pDBConn)
      mdto.LoadPurchaseOrderInfo(rvwPurchaseOrder, vPurchaseOrderID)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetTotalPODeliveryValueByID(ByVal vPODeliveryID As Integer) As Decimal
    Dim mRetVal As Decimal = 0
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.ExecuteScalar("select * from vwTotalValueSUMPODeliveryItem where PODeliveryID = " & vPODeliveryID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadPurchaseOrderItemAllocationInfos(ByRef rPOIA As colPurchaseOrderItemAllocationInfos, ByVal vWhere As String) As Boolean
    Dim mdto As New dtoPurchaseOrderItemAllocationInfo(pDBConn, dtoPurchaseOrderItemAllocationInfo.eMode.Info)
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdto.LoadPurchaseOrderItemAllocationInfos(rPOIA, vWhere)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Sub DeletePuchaseOrder(ByRef rPurchaseOrder As dmPurchaseOrder)
    Try
      pDBConn.Connect()
      pDBConn.ExecuteNonQuery("Delete From PurchaseOrder Where PurchaseOrderID = " & rPurchaseOrder.PurchaseOrderID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub




  Public Function SaveSupplierDown(ByRef rSupplier As dmSupplier) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSupplier
    Dim mdtoCC As dtoSupplierContact

    Try

      pDBConn.Connect()
      mdto = New dtoSupplier(pDBConn)
      mdto.SaveSupplier(rSupplier)
      mdtoCC = New dtoSupplierContact(pDBConn)
      mdtoCC.SaveSupplierContactCollection(rSupplier.SupplierContacts, rSupplier.SupplierID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SavePODelivery(ByRef rPODelivery As dmPODelivery) As Boolean
    Dim mdto As dtoPODelivery
    Dim mdtoItems As dtoPODeliveryItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()

      mdto = New dtoPODelivery(pDBConn)
      ''rPODelivery.MKReference = ""
      ''rPODelivery.DateCreated = Now
      mOK = mdto.SavePODelivery(rPODelivery)

      mdtoItems = New dtoPODeliveryItem(pDBConn)
      mdtoItems.SavePODeliveryItemCollection(rPODelivery.PODeliveryItems, rPODelivery.PODeliveryID)


    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Sub LoadPOItemInfos(ByRef rPOItemInfos As colPOItemInfos, ByRef rPurchaseOrder As dmPurchaseOrder)
    Dim mdtoPurchaseOrderItem As New dtoPurchaseOrderItem(pDBConn)
    Dim mPurchaseOrderItems As New colPurchaseOrderItems(rPurchaseOrder)


    Try
      pDBConn.Connect()
      mdtoPurchaseOrderItem.LoadPurchaseOrderItemCollection(mPurchaseOrderItems, rPurchaseOrder.PurchaseOrderID)
      If rPOItemInfos IsNot Nothing Then
        For Each mPOItem As dmPurchaseOrderItem In mPurchaseOrderItems
          If String.IsNullOrEmpty(mPOItem.Description) = False Then

            rPOItemInfos.Add(New clsPOItemInfo(mPOItem, Nothing))
          End If
        Next
      End If

    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function LoadPurchaseOrder(ByRef rPurchaseOrder As dmPurchaseOrder, ByVal vPurchaseOrderID As Integer) As Boolean
    Dim mdtoPurchaseOrder As New dtoPurchaseOrder(pDBConn)
    Dim mdtoPurchaseORderItem As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtoPurchaseOrderItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdtoPurchaseOrder.LoadPurchaseOrder(rPurchaseOrder, vPurchaseOrderID)
      mOK = mOK AndAlso mdtoPurchaseORderItem.LoadPurchaseOrderItemCollection(rPurchaseOrder.PurchaseOrderItems, vPurchaseOrderID)
      For Each mPurchaseOrderItem As dmPurchaseOrderItem In rPurchaseOrder.PurchaseOrderItems
        mOK = mOK AndAlso mdtoPurchaseOrderItemAllocation.LoadPurchaseOrderItemAllocationCollection(mPurchaseOrderItem.PurchaseOrderItemAllocations, mPurchaseOrderItem.PurchaseOrderItemID)
      Next
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function ReloadPurchaseOrderItems(ByRef rPurchaseOrderItems As colPurchaseOrderItems, ByVal vPurchaseOrderID As Integer) As Boolean

    Dim mdtoPOItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)
    Dim mdtoPOIs As New dtoPurchaseOrderItem(pDBConn)
    Dim mOK As Boolean = True
    Try
      pDBConn.Connect()

      If mOK Then mOK = mdtoPOIs.LoadPurchaseOrderItemCollection(rPurchaseOrderItems, vPurchaseOrderID)


      For Each mPOItem As dmPurchaseOrderItem In rPurchaseOrderItems
        If mOK Then
          mOK = mdtoPOItemAllocation.LoadPurchaseOrderItemAllocationCollection(mPOItem.PurchaseOrderItemAllocations, mPOItem.PurchaseOrderItemID)
        End If
      Next
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LoadPurchaseOrderDown(ByRef rPurchaseOrder As dmPurchaseOrder, ByVal vPurchaseOrderID As Integer) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoPurchaseOrder
    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    Dim mdtoPOIs As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoPOAllocation As New dtoPurchaseOrderAllocation(pDBConn)
    Dim mdtoSupplierContact As New dtoSupplierContact(pDBConn)
    Dim mdtoPOItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)
    Dim mdtoPOFileTracker As dtoFileTracker

    Dim mdtoWorkOrder As New dtoWorkOrder(pDBConn)
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoPurchaseOrder(pDBConn)
      mOK = mdto.LoadPurchaseOrder(rPurchaseOrder, vPurchaseOrderID)
      If mOK Then mOK = mdtoPOIs.LoadPurchaseOrderItemCollection(rPurchaseOrder.PurchaseOrderItems, vPurchaseOrderID)

      If rPurchaseOrder.SupplierID <> 0 Then
        If mOK Then
          mOK = mdtoSupplier.LoadSupplier(rPurchaseOrder.Supplier, rPurchaseOrder.SupplierID)
          If mOK Then mOK = mdtoSupplierContact.LoadSupplierContactCollection(rPurchaseOrder.Supplier.SupplierContacts, rPurchaseOrder.SupplierID)
        End If
      End If

      For Each mPOItem As dmPurchaseOrderItem In rPurchaseOrder.PurchaseOrderItems
        If mOK Then
          mOK = mdtoPOItemAllocation.LoadPurchaseOrderItemAllocationCollection(mPOItem.PurchaseOrderItemAllocations, mPOItem.PurchaseOrderItemID)
        End If
      Next
      If mOK Then mOK = mdtoPOAllocation.LoadPurchaseOrderAllocationCollection(rPurchaseOrder.PurchaseOrderAllocations, vPurchaseOrderID)



      mdtoPOFileTracker = New dtoFileTracker(pDBConn)
      mdtoPOFileTracker.LoadFileTrackerCollection(rPurchaseOrder.POFiles, eObjectType.PurchaseOrder, rPurchaseOrder.PurchaseOrderID)


      pDBConn.Disconnect()

      mRetVal = True
    Catch ex As Exception

    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdtoPOAllocation = Nothing
    End Try


    Return mRetVal

  End Function

  Public Function SaveWorkOrderPhaseMatReqCategoryStatus(ByRef rSalesOrderPhaseMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrderMatReqCategoryStatus
    Try
      mdto = New dtoWorkOrderMatReqCategoryStatus(pDBConn)
      pDBConn.Connect()
      mdto.SaveWorkOrderMatReqCategoryStatus(rSalesOrderPhaseMatReqCategoryStatus)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetNextPurchaseOrderNo() As String
    Dim mPONum As String = String.Empty
    Dim mNewConnection As Boolean
    Try
      If pDBConn.Connect(mNewConnection) Then
        mPONum = pDBConn.NextTally(eTallyIDs.PurchaseOrderNo).ToString("00000")
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected And mNewConnection Then pDBConn.Disconnect()
    End Try

    Return mPONum
  End Function

  Public Function LoadPurchaseOrderCollectionDown(ByRef rPurchaseOrders As colPurchaseOrders, ByVal vWhere As String) As Boolean
    Dim mdtoPurchaseOrder As New dtoPurchaseOrder(pDBConn)
    Dim mdtoPurchaseORderItem As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtoPurchaseOrderItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = mdtoPurchaseOrder.LoadPurchaseOrderCollection(rPurchaseOrders, vWhere)

      If mOK Then
        For Each mPO As dmPurchaseOrder In rPurchaseOrders

          mOK = mdtoPurchaseORderItem.LoadPurchaseOrderItemCollection(mPO.PurchaseOrderItems, mPO.PurchaseOrderID)

          For Each mPOI As dmPurchaseOrderItem In mPO.PurchaseOrderItems

            If mPOI IsNot Nothing Then

              mdtoPurchaseOrderItemAllocation.LoadPurchaseOrderItemAllocationCollection(mPOI.PurchaseOrderItemAllocations, mPOI.PurchaseOrderItemID)
            End If
          Next

        Next
      End If



    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

End Class
