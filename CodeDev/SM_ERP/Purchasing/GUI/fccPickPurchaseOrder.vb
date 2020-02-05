Imports RTIS.CommonVB

Public Class fccPickPurchaseOrder

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pPurchaseOrderInfos As colPurchaseOrderInfos
  Private pPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor
  Private pFormController As fccPickPurchaseOrder
  Private pCurrentPurchaseOrderItemAllocationInfo As clsPurchaseOrderItemAllocationInfo
  Private pPurchaseOrderInfo As clsPurchaseOrderInfo
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pPurchaseOrderProcessors = New colPurchaseOrderItemAllocationProcessor
    pCurrentPurchaseOrderItemAllocationInfo = New clsPurchaseOrderItemAllocationInfo
    pPurchaseOrderInfo = New clsPurchaseOrderInfo


  End Sub

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property PurchaseOrderInfos() As colPurchaseOrderInfos
    Get
      PurchaseOrderInfos = pPurchaseOrderInfos
    End Get
    Set(ByVal value As colPurchaseOrderInfos)
      pPurchaseOrderInfos = value
    End Set
  End Property

  Public Property PurchaseOrderInfo() As clsPurchaseOrderInfo
    Get
      PurchaseOrderInfo = pPurchaseOrderInfo
    End Get
    Set(ByVal value As clsPurchaseOrderInfo)
      pPurchaseOrderInfo = value
    End Set
  End Property

  Public Property CurrentPurchaseOrderItemAllocationInfo() As clsPurchaseOrderItemAllocationInfo
    Get
      CurrentPurchaseOrderItemAllocationInfo = pCurrentPurchaseOrderItemAllocationInfo
    End Get
    Set(ByVal value As clsPurchaseOrderItemAllocationInfo)
      pCurrentPurchaseOrderItemAllocationInfo = value
    End Set
  End Property

  Public Property PurchaseOrderProcessors() As colPurchaseOrderItemAllocationProcessor
    Get
      PurchaseOrderProcessors = pPurchaseOrderProcessors
    End Get
    Set(ByVal value As colPurchaseOrderItemAllocationProcessor)
      pPurchaseOrderProcessors = value
    End Set
  End Property

  Public Sub LoadPurchaseOrderItemAllocationInfos(ByRef rcolPurchaseOrderItemAllocationInfo As colPurchaseOrderItemAllocationInfo)


    Dim mdto As dtoPurchaseOrderItemAllocationInfo
    Dim mwhere As String = ""

    Try

      pDBConn.Connect()
      mdto = New dtoPurchaseOrderItemAllocationInfo(DBConn)
      mdto.LoadPurchaseOrderItemAllocationProgressProcessorCollection(rcolPurchaseOrderItemAllocationInfo, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


  End Sub


  Public Sub LoadPurchaseOrderInfos(ByRef rcolPurchaseOrderInfo As colPurchaseOrderInfos)


    Dim mdto As dtoPurchaseOrderInfo
    Dim mwhere As String = ""

    Try

      pDBConn.Connect()
      mdto = New dtoPurchaseOrderInfo(DBConn)
      mdto.LoadPurchaseOrderInfoCollection(rcolPurchaseOrderInfo, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


  End Sub


  Public Sub LoadPurchaseOrderItemAllocationProcessorss()

    Dim mdto As dtoPurchaseOrderItemAllocationInfo
    Dim mWhere As String = " PurchaseOrderID =" & pPurchaseOrderInfo.PurchaseOrderID
    pPurchaseOrderProcessors.Clear()
    Try

      pDBConn.Connect()
      mdto = New dtoPurchaseOrderItemAllocationInfo(DBConn, dtoPurchaseOrderItemAllocationInfo.eMode.Processor)

      mdto.LoadPurchaseOrderItemAllocationProcessorsByWhere(pPurchaseOrderProcessors, mWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub



  Public Sub ProcessPicks()
    Try
      Dim mdsoTran As dsoStockTransactions
      Dim mMatReq As dtoPurchaseorderItemInfo

      Dim mdsoStock As dsoStock
      Dim mSIL As dmStockItemLocation

      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)

      For Each mPOP As clsPurchaseOrderItemAllocationProcessor In pPurchaseOrderProcessors
        If mPOP.ToProcessQty <> 0 Then
          If mPOP.StockItem.StockItemID <> 0 Then
            mSIL = mdsoStock.GetOrCreateStockItemLocation(mPOP.StockItem.StockItemID, 1)
          Else
            mSIL = Nothing
          End If
          mPOP.ToProcessQty = 0
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class
