Imports DevExpress.XtraGauges.Core.Model
Imports RTIS.CommonVB

Public Class fccPickWoodMaterial

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pPickWoodMaterialtemProcessors As colPickWoodMaterialItemProcessors
  Private pFormController As fccPickWoodMaterial
  Private pCurrentPurchaseOrderItemAllocationInfo As clsPurchaseOrderItemAllocationInfo
  Private pWoodPallet As dmWoodPallet
  Private pPickWoodMaterialRequirement As dmPickWoodMaterialRequirement
  Private pPrimaryKey As Integer
  Private pWoodPalletID As Integer
  Private pReprintOption As Boolean
  Private pWorkOrderInfo As clsWorkOrderInfo
  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pPickWoodMaterialtemProcessors = New colPickWoodMaterialItemProcessors
    pCurrentPurchaseOrderItemAllocationInfo = New clsPurchaseOrderItemAllocationInfo
    pWoodPallet = New dmWoodPallet
    pPickWoodMaterialRequirement = New dmPickWoodMaterialRequirement

  End Sub

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Property WoodPallet() As dmWoodPallet
    Get
      Return pWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pWoodPallet = value
    End Set
  End Property
  Public Property WorkOrderInfo() As clsWorkOrderInfo
    Get
      Return pWorkOrderInfo
    End Get
    Set(ByVal value As clsWorkOrderInfo)
      pWorkOrderInfo = value
    End Set
  End Property

  Public Property PickWoodMaterialRequirement() As dmPickWoodMaterialRequirement
    Get
      Return pPickWoodMaterialRequirement
    End Get
    Set(ByVal value As dmPickWoodMaterialRequirement)
      pPickWoodMaterialRequirement = value
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

  Public Property WoodPalletID As Integer
    Get
      Return pWoodPalletID
    End Get
    Set(value As Integer)
      pWoodPalletID = value
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

  Public Property PurchaseOrderProcessors() As colPickWoodMaterialItemProcessors
    Get
      PurchaseOrderProcessors = pPickWoodMaterialtemProcessors
    End Get
    Set(ByVal value As colPickWoodMaterialItemProcessors)
      pPickWoodMaterialtemProcessors = value
    End Set
  End Property

  Public Sub LoadObjects()
    Dim mDSO As dsoProduction

    Try
      If pPrimaryKey = 0 Then
        pPickWoodMaterialRequirement = Nothing

        If pWoodPalletID <> 0 Then
          mDSO = New dsoProduction(pDBConn)
          pPickWoodMaterialRequirement = New dmPickWoodMaterialRequirement

          pPickWoodMaterialRequirement.WoodPalletID = pWoodPalletID
          pPickWoodMaterialRequirement.DateCreated = Now

          mDSO.LoadPickWoodMaterialItemProcessorss(pPickWoodMaterialtemProcessors, pWoodPalletID)

          RefreshPOItemAllocationProcessorPODelItems()

        End If

      Else
        mDSO = New dsoPurchasing(pDBConn)
        pPickWoodMaterialRequirement = New dmPODelivery
        mDSO.LoadPODeliveryDown(pPickWoodMaterialRequirement, pPrimaryKey)

        pWoodPalletID = pPickWoodMaterialRequirement.PurchaseOrderID
        mDSO.LoadPurchaseOrderInfo(pWorkOrderInfo, pPickWoodMaterialRequirement.PurchaseOrderID)
        '//LoadPurchaseOrderItemAllocationProcessorss
        mDSO.LoadPurchaseOrderItemAllocationProcessorss(pPickWoodMaterialtemProcessors, pWoodPalletID)

        RefreshPOItemAllocationProcessorPODelItems()


      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Sub RefreshPOItemAllocationProcessorPODelItems()

    If PickWoodMaterialRequirement IsNot Nothing Then

      For Each mPickWoodMaterialItem As dmPickWoodMaterialItem In pPickWoodMaterialRequirement.PickWoodMaterialItems
        For Each mPickWoodMaterialItemProcessor As clsPickWoodMaterialItemProcessor In pPickWoodMaterialtemProcessors
          If mPickWoodMaterialItem.WoodPalletItemID = mPickWoodMaterialItemProcessor.WoodPalletItemID Then
            mPickWoodMaterialItemProcessor.PickWoodMaterialItem = mPickWoodMaterialItem
            Exit For
          End If
        Next
      Next
    End If

  End Sub

  Public Function GetWorkOrderInfos() As colWorkOrderInfos
    Dim mRetVal As colWorkOrderInfos = New colWorkOrderInfos
    Dim mdso As dsoSales
    Dim mWhere As String
    ' mWhere = "Status<> " & ePurchaseOrderDueDateStatus.Cancelled
    mdso = New dsoSales(pDBConn)
    mdso.LoadWorkOrderInfos(mRetVal, "", dtoWorkOrderInfo.eMode.WorkOrderInfoInternal)
    Return mRetVal
  End Function

  Public Sub LoadPurchaseOrderItemAllocationProcessorss()
    Dim mdso As dsoPurchasing
    Try

      If pWorkOrderInfo IsNot Nothing Then
        mdso = New dsoPurchasing(pDBConn)
        pPickWoodMaterialtemProcessors.Clear()

        mdso.LoadPurchaseOrderItemAllocationProcessorss(pPickWoodMaterialtemProcessors, pWorkOrderInfo.PurchaseOrderID)
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
      mIsDirty = pPickWoodMaterialRequirement.IsAnyDirty
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

  Public Function ProcessDeliveryQtys(ByVal vCreateTimberPack As Boolean) As Boolean
    Dim mRetVal As Boolean = True
    Dim mdsoTran As dsoStockTransactions
    Dim mDeliveryItem As dmPODeliveryItem


    Dim mdsoStock As dsoStock
    Dim mSIL As dmStockItemLocation
    Dim mDialogResult As DialogResult

    Try

      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)

      For Each mPOP As clsPurchaseOrderItemAllocationProcessor In pPickWoodMaterialtemProcessors


        If mPOP.ToProcessQty <> 0 Then

          If mPOP.OutStandingQty <= 0 Or mPOP.ToProcessQty > mPOP.Quantity Then

            mDialogResult = MessageBox.Show("La cantidad a procesar es mayor a la cantidad pedida, ¿Desea continuar?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If mDialogResult = DialogResult.No Then
              mRetVal = False
              Return mRetVal
            End If
          End If


          If mPOP.StockItem.StockItemID <> 0 Then
            mSIL = mdsoStock.GetOrCreateStockItemLocation(mPOP.StockItem.StockItemID, 1)
          Else
            mSIL = Nothing
          End If


          If mPOP.PODeliveryItem Is Nothing Then


            mDeliveryItem = New dmPODeliveryItem
            mDeliveryItem.PODeliveryID = pPickWoodMaterialRequirement.PODeliveryID
            mDeliveryItem.POItemAllocationID = mPOP.PurchaseOrderItemAllocationID
            pPickWoodMaterialRequirement.PODeliveryItems.Add(mDeliveryItem)
            mPOP.PODeliveryItem = mDeliveryItem

          End If
          ''If vCreateTimberPack Then
          ''  mdsoTran.UpdateDeliveryStockItemLocationQty(mPOP.StockItemID, 1, mPOP.ToProcessQty, 1, mPOP.PODeliveryItem, Now, mPOP.PurchaseOrderItemAllocation, mPOP.ItemRef, True)

          ''Else
          mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOP.StockItemID, 1, mPOP.ToProcessQty, 1, mPOP.PODeliveryItem, Now, mPOP.PurchaseOrderItemAllocation, mPOP.ItemRef, False, pWorkOrderInfo.DefaultCurrency, mPOP.UnitPrice, pWorkOrderInfo.ExchangeRateValue)
          ''End If
          mPOP.ToProcessQty = 0
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Function GetPickWoodMaterialByWorkOrderID(ByVal vPurchaseOrderID As Integer) As Integer
    'Dim mdso As New dsoPurchasing(pDBConn)
    'Dim mRetVal As Integer

    'mRetVal = mdso.getPODeliverysByPurchaseOrderID(vPurchaseOrderID)

    'Return mRetVal

  End Function

  Friend Function GetReceivedValue() As Decimal

    'Dim mdso As New dsoPurchasing(Me.DBConn)
    'Dim mTotalPOValue As Decimal = 0

    'If PODelivery.PODeliveryID > 0 Then
    '  mTotalPOValue = mdso.GetTotalPODeliveryValueByID(Me.PODelivery.PODeliveryID)

    'End If

    'Return mTotalPOValue
  End Function


  Public Sub RaisePickingNumber()
    'Dim mdso As dsoPurchasing
    'Dim mdsoGeneral As New dsoGeneral(pDBConn)


    'pPickWoodMaterialRequirement = New dmPODelivery

    'pPickWoodMaterialRequirement.GRNumber = mdsoGeneral.getNextTally(eTallyIDs.GRNNumber)
    'If pWoodPallet IsNot Nothing Then
    '  PODelivery.PurchaseOrderID = pWoodPallet.PurchaseOrderID
    'End If
    'mdso = New dsoPurchasing(pDBConn)
    'mdso.SavePODelivery(pPickWoodMaterialRequirement)
  End Sub

  Public Function SavePickWoodMaterialRequirement() As Boolean
    Dim mdso As dsoProduction
    Dim mOK As Boolean = False
    Try
      mdso = New dsoProduction(pDBConn)



      mOK = mdso.SavePickWoodMaterialRequirement(pPickWoodMaterialRequirement)

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdso = Nothing
    End Try
    Return mOK
  End Function

  Public Sub CreatePurchaseOrderPDF(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery, ByVal vReprintOption As Boolean)
    'Dim mReportPath As String
    'pReprintOption = vReprintOption
    'mReportPath = CreateWoodMatPickingReport(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery)
    'pPickWoodMaterialRequirement.FileExport = mReportPath
  End Sub

  Public Function CreateWoodMatPickingReport(ByRef rPurchaseOrderInfo As clsPurchaseOrderInfo, ByRef rPurchaseOrderProcessors As colPurchaseOrderItemAllocationProcessor, ByRef rPODelivery As dmPODelivery) As String
    'Dim mFileName As String
    'Dim mDirectory As String
    'Dim mExportFilename As String
    'Dim mRep As repPODelivery

    'Try
    '  mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.PODeliveryFileFolderSys)
    '  If System.IO.Directory.Exists(mDirectory) = False Then
    '    System.IO.Directory.CreateDirectory(mDirectory)
    '  End If
    '  mFileName = String.Format("PODelivery_{0}_{1}_{2}.pdf", rPODelivery.PODeliveryID, rPODelivery.GRNumber, Today.ToString("yyyyMMdd_HHmm"))
    '  mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)

    '  mRep = repPODelivery.CreatePODeliveryReport(rPurchaseOrderInfo, rPurchaseOrderProcessors, rPODelivery, pReprintOption)

    '  mRep.ExportToPdf(mExportFilename)

    '  Return mExportFilename
    'Catch ex As Exception
    '  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    'End Try
  End Function
End Class
