Imports RTIS.CommonVB
Imports RTIS.DataLayer
Public Class dsoPurchasing
  Private pDBConn As clsDBConnBase

  Public Sub New(ByVal vDBConn As clsDBConnBase)
    pDBConn = vDBConn
  End Sub


  Public Function SavePurchaseOrderDown(ByRef rPurchaseOrder As dmPurchaseOrder) As Boolean
    Dim mRetVal As Boolean
    Dim mdtoPO As dtoPurchaseOrder
    Dim mdtoPOI As dtoPurchaseOrderItem
    Dim mdtoPOIA As dtoPurchaseOrderItemAllocation

    Try
      pDBConn.Connect()
      mdtoPO = New dtoPurchaseOrder(pDBConn)
      mdtoPO.SavePurchaseOrder(rPurchaseOrder)

      mdtoPOI = New dtoPurchaseOrderItem(pDBConn)
      mdtoPOI.SavePurchaseOrderItemCollection(rPurchaseOrder.PurchaseOrderItems, rPurchaseOrder.PurchaseOrderID)


      mdtoPOIA = New dtoPurchaseOrderItemAllocation(pDBConn)
      For Each mPOI As dmPurchaseOrderItem In rPurchaseOrder.PurchaseOrderItems
        mdtoPOIA.SavePurchaseOrderItemAllocationCollection(mPOI.PurchaseOrderItemAllocations, mPOI.PurchaseOrderItemID)
      Next

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
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



  End Function

  Public Function SavePurchaseOrderDownNEW(ByRef rPurchaseOrder As dmPurchaseOrder) As Boolean

  End Function

  Public Function GetNextPurchaseOrderNo() As String

  End Function


End Class
