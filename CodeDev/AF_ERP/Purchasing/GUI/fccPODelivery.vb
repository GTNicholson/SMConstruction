﻿Imports DevExpress.XtraGauges.Core.Model
Imports RTIS.CommonVB

Public Class fccPODelivery

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pPurchaseOrderInfos As colPurchaseOrderInfos
  Private pPOItemProcessors As colPurchaseOrderItemAllocationProcessor
  Private pFormController As fccPODelivery
  Private pCurrentPurchaseOrderItemAllocationInfo As clsPurchaseOrderItemAllocationInfo
  Private pPurchaseOrderInfo As clsPurchaseOrderInfo
  Private pPODelivery As dmPODelivery
  Private pPurchaseOrder As dmPurchaseOrder
  Private pPrimaryKey As Integer
  Private pPurchaseOrderID As Integer
  Private pReprintOption As Boolean

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pPOItemProcessors = New colPurchaseOrderItemAllocationProcessor
    pCurrentPurchaseOrderItemAllocationInfo = New clsPurchaseOrderItemAllocationInfo
    pPurchaseOrderInfo = New clsPurchaseOrderInfo
    pPurchaseOrderInfos = New colPurchaseOrderInfos
    pPODelivery = New dmPODelivery
    pPurchaseOrder = New dmPurchaseOrder
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
      Return pPurchaseOrderInfos
    End Get
    Set(ByVal value As colPurchaseOrderInfos)
      pPurchaseOrderInfos = value
    End Set
  End Property
  Public Property PurchaseOrder() As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property
  Public Property PurchaseOrderInfo() As clsPurchaseOrderInfo
    Get
      Return pPurchaseOrderInfo
    End Get
    Set(ByVal value As clsPurchaseOrderInfo)
      pPurchaseOrderInfo = value
    End Set
  End Property

  Public Property PODelivery() As dmPODelivery
    Get
      Return pPODelivery
    End Get
    Set(ByVal value As dmPODelivery)
      pPODelivery = value
    End Set
  End Property


  Public Property PrimaryKey As Integer
    Get
      Return pPrimaryKey
    End Get
    Set(value As Integer)
      pPrimaryKey = value
    End Set
  End Property

  Public Property PurchaseOrderID As Integer
    Get
      Return pPurchaseOrderID
    End Get
    Set(value As Integer)
      pPurchaseOrderID = value
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
      PurchaseOrderProcessors = pPOItemProcessors
    End Get
    Set(ByVal value As colPurchaseOrderItemAllocationProcessor)
      pPOItemProcessors = value
    End Set
  End Property

  Public Sub LoadPurchaseOrderItemAllocationInfos(ByRef rcolPurchaseOrderItemAllocationInfo As colPurchaseOrderItemAllocationInfos)


    Dim mdto As dtoPurchaseOrderItemAllocationInfo
    Dim mwhere As String = ""

    Try

      pDBConn.Connect()
      mdto = New dtoPurchaseOrderItemAllocationInfo(DBConn, dtoPurchaseOrderItemAllocationInfo.eMode.Info)
      mdto.LoadPurchaseOrderItemAllocationInfos(rcolPurchaseOrderItemAllocationInfo, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


  End Sub

  Public Sub LoadObjects()
    Dim mDSO As dsoPurchasing

    Try
      If pPrimaryKey = 0 Then
        pPurchaseOrderInfo = Nothing
        pPODelivery = Nothing

        If pPurchaseOrderID <> 0 Then
          mDSO = New dsoPurchasing(pDBConn)
          pPurchaseOrderInfo = New clsPurchaseOrderInfo
          pPODelivery = New dmPODelivery

          pPODelivery.PurchaseOrderID = pPurchaseOrderID
          pPODelivery.DateCreated = Now
          mDSO.LoadPurchaseOrderInfo(pPurchaseOrderInfo, pPODelivery.PurchaseOrderID)
          '//LoadPurchaseOrderItemAllocationProcessorss
          mDSO.LoadPurchaseOrderItemAllocationProcessorss(pPOItemProcessors, pPurchaseOrderID)

          RefreshPOItemAllocationProcessorPODelItems()

        End If

      Else
        mDSO = New dsoPurchasing(pDBConn)
        pPODelivery = New dmPODelivery
        mDSO.LoadPODeliveryDown(pPODelivery, pPrimaryKey)

        pPurchaseOrderID = pPODelivery.PurchaseOrderID
        mDSO.LoadPurchaseOrderInfo(pPurchaseOrderInfo, pPODelivery.PurchaseOrderID)
        '//LoadPurchaseOrderItemAllocationProcessorss
        mDSO.LoadPurchaseOrderItemAllocationProcessorss(pPOItemProcessors, pPurchaseOrderID)

        RefreshPOItemAllocationProcessorPODelItems()


      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Sub RefreshPOItemAllocationProcessorPODelItems()

    If PODelivery IsNot Nothing Then

      For Each mPODelItem As dmPODeliveryItem In pPODelivery.PODeliveryItems
        For Each mPOIP As clsPurchaseOrderItemAllocationProcessor In pPOItemProcessors
          If mPODelItem.POItemAllocationID = mPOIP.PurchaseOrderItemAllocationID Then
            mPOIP.PODeliveryItem = mPODelItem
            Exit For
          End If
        Next
      Next
    End If

  End Sub

  Public Function GetPurchaseOrderInfos() As colPurchaseOrderInfos
    Dim mRetVal As colPurchaseOrderInfos = New colPurchaseOrderInfos
    Dim mdso As dsoPurchasing
    Dim mWhere As String
    mWhere = "Status<> " & ePurchaseOrderDueDateStatus.Cancelled
    mdso = New dsoPurchasing(pDBConn)
    mdso.LoadPurchaseOrderInfosOnly(mRetVal, mWhere)
    Return mRetVal
  End Function

  Public Sub LoadPurchaseOrderItemAllocationProcessorss()
    Dim mdso As dsoPurchasing
    Try

      If pPurchaseOrderInfo IsNot Nothing Then
        mdso = New dsoPurchasing(pDBConn)
        pPOItemProcessors.Clear()

        mdso.LoadPurchaseOrderItemAllocationProcessorss(pPOItemProcessors, pPurchaseOrderInfo.PurchaseOrderID)
        RefreshPOItemAllocationProcessorPODelItems()
        '// Load any deliveryitems into matechde purchaseorderitemprocessors

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    If Not PODelivery Is Nothing Then
      mIsDirty = pPODelivery.IsAnyDirty
    Else
      mIsDirty = False
    End If
    Return mIsDirty
  End Function

  Public Function ValidateObject() As clsValidate
    Dim mValidate As New clsValidate
    mValidate.ValOk = True
    If False Then '' Change to perform validation checks
      mValidate.ValOk = False
      mValidate.AddMsgLine("Check failed details")
    End If
    Return mValidate
  End Function

  Public Function ProcessDeliveryQtys() As Boolean
    Dim mRetVal As Boolean = True
    Dim mdsoTran As dsoStockTransactions
    Dim mDeliveryItem As dmPODeliveryItem
    Dim mReceivedValue As Decimal

    Dim mdsoStock As dsoStock
    Dim mSIL As dmStockItemLocation
    Dim mDialogResult As DialogResult
    Dim mExchangeRate As Decimal = 0
    Dim mdsoGeneral As dsoGeneral
    Dim mTempSI As dmStockItem
    Try

      mdsoTran = New dsoStockTransactions(pDBConn)
      mdsoGeneral = New dsoGeneral(pDBConn)
      mdsoStock = New dsoStock(pDBConn)

      For Each mPOP As clsPurchaseOrderItemAllocationProcessor In pPOItemProcessors



        If mPOP.ToProcessQty <> 0 Then



            If mPOP.OutStandingQty <= 0 Or mPOP.ToProcessQty > mPOP.Quantity Then

              mDialogResult = MessageBox.Show("La cantidad a procesar es mayor a la cantidad pedida, ¿Desea continuar?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

              If mDialogResult = DialogResult.No Then
                mRetVal = False
                Return mRetVal
              End If
            End If

          mTempSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOP.StockItemID)

          If mTempSI IsNot Nothing Then
            If mPOP.StockItem.StockItemID <> 0 And mTempSI.IsTracked = False Then
              mSIL = mdsoStock.GetOrCreateStockItemLocation(mPOP.StockItem.StockItemID, 1)
            Else
              mSIL = Nothing
            End If
          End If

          If mPOP.PODeliveryItem Is Nothing Then


              mDeliveryItem = New dmPODeliveryItem
              mDeliveryItem.PODeliveryID = pPODelivery.PODeliveryID
              mDeliveryItem.POItemAllocationID = mPOP.PurchaseOrderItemAllocationID
              pPODelivery.PODeliveryItems.Add(mDeliveryItem)
              mPOP.PODeliveryItem = mDeliveryItem

            End If


            '// Work out the value of the received qty of the item for Average Stock Value purposes
            mReceivedValue = mPOP.PurchaseOrderItem.UnitPrice * mPOP.ToProcessQty '// Todo include logic for pricing unit

            ''//Check the valuation mode
            If pPurchaseOrderInfo.ValuationMode = eValuationMode.ForAdvanced Then
              If pPurchaseOrderInfo.ExchangeRateValue = 0 Then
                mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, eCurrency.Cordobas)
              Else
                mExchangeRate = pPurchaseOrderInfo.ExchangeRateValue
              End If
              mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOP.StockItemID, 1, mPOP.ToProcessQty, mReceivedValue, 1, mPOP.PODeliveryItem, Now, mPOP.PurchaseOrderItemAllocation, mPOP.ItemRef, False, pPurchaseOrderInfo.DefaultCurrency, mPOP.UnitPrice, mExchangeRate)

            ElseIf pPurchaseOrderInfo.ValuationMode = eValuationMode.BookIn Then
              mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, eCurrency.Cordobas)
              If mExchangeRate > 0 Then
                mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOP.StockItemID, 1, mPOP.ToProcessQty, mReceivedValue, 1, mPOP.PODeliveryItem, Now, mPOP.PurchaseOrderItemAllocation, mPOP.ItemRef, False, pPurchaseOrderInfo.DefaultCurrency, mPOP.UnitPrice, mExchangeRate)

              End If

            Else ''//Decide how to do if the business can get credit from their suppliers
              mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOP.StockItemID, 1, mPOP.ToProcessQty, mReceivedValue, 1, mPOP.PODeliveryItem, Now, mPOP.PurchaseOrderItemAllocation, mPOP.ItemRef, False, pPurchaseOrderInfo.DefaultCurrency, mPOP.UnitPrice, pPurchaseOrderInfo.ExchangeRateValue)


            End If

            ''//Refresh StockItemRegistry avoiding close and open the system
            If mPOP.StockItem.StockItemID > 0 Then
              AppRTISGlobal.GetInstance.StockItemRegistry.RefreshStockItem(mPOP.StockItem.StockItemID)
            End If
            mPOP.ToProcessQty = 0
          End If


      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Function GetPODeliverysByPurchaseOrderID(ByVal vPurchaseOrderID As Integer) As Integer
    Dim mdso As New dsoPurchasing(pDBConn)
    Dim mRetVal As Integer

    mRetVal = mdso.getPODeliverysByPurchaseOrderID(vPurchaseOrderID)

    Return mRetVal

  End Function

  Friend Function GetReceivedValue() As Decimal

    Dim mdso As New dsoPurchasing(Me.DBConn)
    Dim mTotalPOValue As Decimal = 0

    If PODelivery.PODeliveryID > 0 Then
      mTotalPOValue = mdso.GetTotalPODeliveryValueByID(Me.PODelivery.PODeliveryID)

    End If

    Return mTotalPOValue
  End Function

  Public Sub ProcessDeliveryAllPendingQtys()



  End Sub


  Public Sub RaisePODelivery()
    Dim mdso As dsoPurchasing
    Dim mdsoGeneral As New dsoGeneral(pDBConn)


    pPODelivery = New dmPODelivery

    pPODelivery.GRNumber = mdsoGeneral.getNextTally(eTallyIDs.GRNNumber)
    If pPurchaseOrder IsNot Nothing Then
      PODelivery.PurchaseOrderID = pPurchaseOrder.PurchaseOrderID
    End If
    mdso = New dsoPurchasing(pDBConn)
    mdso.SavePODelivery(pPODelivery)
  End Sub

  Public Function SavePODelivery() As Boolean
    Dim mdso As dsoPurchasing
    Dim mOK As Boolean = False
    Dim mSQL As String = ""

    Try
      mdso = New dsoPurchasing(pDBConn)



      mOK = mdso.SavePODelivery(pPODelivery)

      ''//Update the status for the PO
      If mOK Then

        Select Case PODelivery.Status
          Case ePODelivery.Received
            mSQL = String.Format("Update PurchaseOrder set Status = {0}  where PurchaseOrderID in (select PurchaseOrderID from PODelivery where PurchaseOrderID={1})", CInt(ePurchaseOrderDueDateStatus.Received), pPODelivery.PurchaseOrderID)

            If DBConn.Connect Then
              pDBConn.ExecuteNonQuery(mSQL)

            End If

          Case ePODelivery.Pending
            mSQL = String.Format("Update PurchaseOrder set Status = {0}  where PurchaseOrderID in (select PurchaseOrderID from PODelivery where PurchaseOrderID={1})", CInt(ePurchaseOrderDueDateStatus.PartDelivered), pPODelivery.PurchaseOrderID)

            If DBConn.Connect Then
              pDBConn.ExecuteNonQuery(mSQL)

            End If
        End Select

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdso = Nothing
      If DBConn.IsConnected Then DBConn.Disconnect()

    End Try
    Return mOK
  End Function

  Public Sub CreatePurchaseOrderPDF(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery, ByVal vReprintOption As Boolean)
    Dim mReportPath As String
    pReprintOption = vReprintOption

    mReportPath = CreatePODeliveryReport(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery)
    pPODelivery.FileExport = mReportPath
  End Sub


  Public Function CreatePODeliveryReport(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery) As String
    Dim mFileName As String
    Dim mDirectory As String
    Dim mExportFilename As String
    Dim mRep As repPODelivery

    Try
      mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.PODeliveryFileFolderSys)
      If System.IO.Directory.Exists(mDirectory) = False Then
        System.IO.Directory.CreateDirectory(mDirectory)
      End If
      mFileName = String.Format("PODelivery_{0}_{1}_{2}.pdf", rPODelivery.PODeliveryID, rPODelivery.GRNumber, Today.ToString("yyyyMMdd_HHmm"))
      mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)


      rPurchaseOrderInfo.POItemInfos = GetPOItemInfos(rPurchaseOrderInfo.PurchaseOrder)

      mRep = repPODelivery.CreatePODeliveryReport(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery, pReprintOption)

      mRep.ExportToPdf(mExportFilename)

      Return mExportFilename
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Function

  Private Function GetPOItemInfos(ByRef rPurchaseOrder As dmPurchaseOrder) As colPOItemInfos
    Dim mPOItemInfos As colPOItemInfos
    Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
    mPOItemInfos = New colPOItemInfos

    mdsoPurchasing.LoadPOItemInfos(mPOItemInfos, rPurchaseOrder)


    Return mPOItemInfos
  End Function
End Class
