Imports RTIS.CommonVB
Imports RTIS.DataLayer
Public Class dsoPurchasing
  Private pDBConn As clsDBConnBase

  Public Sub New(ByVal vDBConn As clsDBConnBase)
    pDBConn = vDBConn
  End Sub



  Public Function LoadPurchaseOrderInfos(ByRef rPurchaseOrderInfos As colPurchaseOrderInfos, ByVal vWhere As String) As Boolean
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

  Public Function LoadSuppliers(ByRef rSuppliers As colSuppliers) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSupplier

    Try

      pDBConn.Connect()
      mdto = New dtoSupplier(pDBConn)
      mdto.LoadSupplierCollection(rSuppliers)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
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

    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        Try
          pDBConn.ConnectionBeginTrans()

          If String.IsNullOrEmpty(rPurchaseOrder.PONum) Then
            rPurchaseOrder.PONum = GetNextPurchaseOrderNo()
          End If

          mOK = mdtoPO.SavePurchaseOrder(rPurchaseOrder)
          If mOK Then mOK = mdtoPOItem.SavePurchaseOrderItemCollection(rPurchaseOrder.PurchaseOrderItems, rPurchaseOrder.PurchaseOrderID)

          For Each mPOItem As dmPurchaseOrderItem In rPurchaseOrder.PurchaseOrderItems
            If mOK Then
              mOK = mdtoPOItemAllocation.SavePurchaseOrderItemAllocationCollection(mPOItem.PurchaseOrderItemAllocations, mPOItem.PurchaseOrderItemID)
            End If
          Next
          If mOK Then mOK = mdtoPOAllocation.SavePurchaseOrderAllocationCollection(rPurchaseOrder.PurchaseOrderAllocations, rPurchaseOrder.PurchaseOrderID)

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


  Public Function LoadSOPPurchaseOrdersByForProcessing(ByRef rPurchaseOrders As colPurchaseOrders) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoPurchaseOrder
    Dim mSQL As String
    Dim mdtoPOItem As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtOPOItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)
    Try
      mdto = New dtoPurchaseOrder(pDBConn)

      pDBConn.Connect()

      mSQL = "PurchaseOrderID In (Select Distinct PO.PurchaseOrderID"
      mSQL = mSQL & " From PurchaseOrder PO"
      mSQL = mSQL & " Inner Join PurchaseOrderItem POI on POI.PurchaseOrderID = PO.PurchaseOrderID"
      mSQL = mSQL & " Inner Join PurchaseOrderItemAllocation POIA on POIA.PurchaseOrderItemID = POI.PurchaseOrderItemID"
      mSQL = mSQL & " Where POIA.CallOffID IN (SELECT ProductionBatchID FROM ProductionBatch WHERE Status <> 4) "
      mSQL = mSQL & ")"

      mdto.LoadPurchaseOrderCollection(rPurchaseOrders, mSQL)
      For Each mPO As dmPurchaseOrder In rPurchaseOrders
        mdtoPOItem.LoadPurchaseOrderItemCollection(mPO.PurchaseOrderItems, mPO.PurchaseOrderID)
        For Each mPOItem As dmPurchaseOrderItem In mPO.PurchaseOrderItems
          mdtOPOItemAllocation.LoadPurchaseOrderItemAllocationCollection(mPOItem.PurchaseOrderItemAllocations, mPOItem.PurchaseOrderItemID)
        Next
      Next
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

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

  Public Function LoadPurchaseOrderDown(ByRef rPurchaseOrder As dmPurchaseOrder, ByVal vPurchaseOrderID As Integer) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoPurchaseOrder
    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    Dim mdtoPOIs As New dtoPurchaseOrderItem(pDBConn)
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoPOAllocation As New dtoPurchaseOrderAllocation(pDBConn)
    Dim mdtoSupplierContact As New dtoSupplierContact(pDBConn)
    Dim mdtoPOItemAllocation As New dtoPurchaseOrderItemAllocation(pDBConn)

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


      mdtoOutputDocs = New dtoOutputDocument(pDBConn)

      pDBConn.Disconnect()

      mRetVal = True
    Catch ex As Exception

    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdtoPOAllocation = Nothing
    End Try


    Return mRetVal

  End Function


  Public Function GetNextPurchaseOrderNo() As String
    Dim mInvoiceNo As String = String.Empty
    Dim mNewConnection As Boolean
    Try
      If pDBConn.Connect(mNewConnection) Then
        mInvoiceNo = pDBConn.NextTally(eTallyIDs.PurchaseOrderNo)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected And mNewConnection Then pDBConn.Disconnect()
    End Try

    Return mInvoiceNo
  End Function


End Class
