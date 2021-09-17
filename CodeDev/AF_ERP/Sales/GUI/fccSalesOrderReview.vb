Imports RTIS.DataLayer

Public Class fccSalesOrderReview
  Private pInvoiceInfos As colInvoiceInfos
  Private pCustomerPOInfos As colCustomerPurchaseOrders
  Private pPOItemWOAllocationInfos As colPurchaseOrderItemAllocationInfos
  Private pOtherCategoriesPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos
  Private pHonorariosPOIAllocationInfos As colPurchaseOrderItemAllocationInfos

  Private pWoodPalletItemInfosPicked As colWoodPalletItemInfos
  Private pSOPItemInfos As colSalesOrderPhaseItemInfos
  Private pWorkOrderInfos As colWorkOrderInfos
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos

  Private pSalesOrder As dmSalesOrder
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rSalesOrder As dmSalesOrder, ByRef rDBConn As clsDBConnBase)
    pSalesOrder = rSalesOrder
    pDBConn = rDBConn
  End Sub

  Public Function LoadDataRef() As Boolean
    Dim mOK As Boolean
    Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    Dim mWOAs As New colWorkOrderAllocations
    Dim mWhere As String = ""
    Dim mWOA As dmWorkOrderAllocation
    Dim mCostBookEntrys As New colCostBookEntrys
    Dim mdsoCostBook As New dsoCostBook(pDBConn)
    Dim mStockItem As dmStockItem
    Dim mExchangeRate As Decimal
    Dim mWherePOCategories As String = ""
    pPOItemWOAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pOtherCategoriesPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pHonorariosPOIAllocationInfos = New colPurchaseOrderItemAllocationInfos

    pWoodPalletItemInfosPicked = New colWoodPalletItemInfos
    pWorkOrderInfos = New colWorkOrderInfos
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos

    ''Load Insumos Purchasing
    mWhere = String.Format("SalesOrderID = {0} and  POStatus not in ({1})", pSalesOrder.SalesOrderID, CInt(ePurchaseOrderDueDateStatus.Cancelled))

    For Each mVI In RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories))
      Select Case mVI.ItemValue
        Case ePurchaseCategories.ConsumibleProduccion, ePurchaseCategories.InsumosProduccion,
        ePurchaseCategories.PatioYAserrio


          If mWherePOCategories <> "" Then mWherePOCategories &= ","
          mWherePOCategories &= mVI.ItemValue
      End Select
    Next

    mWhere &= String.Format(" and PO_CATEGORY in ({0})", mWherePOCategories)



    mdsoPurchasing.LoadPurchaseOrderItemAllocationWorkOrderInfos(pPOItemWOAllocationInfos, mWhere)

    For Each mPOIAI As clsPurchaseOrderItemAllocationInfo In pPOItemWOAllocationInfos

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOIAI.StockItemID)

      If mStockItem IsNot Nothing Then


        If mPOIAI.ExchangeRateValue > 0 Then
          mPOIAI.StdCost = (mPOIAI.Quantity * mStockItem.AverageCost) / mPOIAI.ExchangeRateValue


        End If

      End If
    Next


    ''Load other categories for the Purchase Orders
    mWhere = String.Format("SalesOrderID = {0} and  POStatus not in ({1})", pSalesOrder.SalesOrderID, CInt(ePurchaseOrderDueDateStatus.Cancelled))
    mWherePOCategories = ""
    For Each mVI In RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories))
      Select Case mVI.ItemValue
        Case ePurchaseCategories.ConsumibleProduccion, ePurchaseCategories.InsumosProduccion,
        ePurchaseCategories.PatioYAserrio

        Case Else
          If mWherePOCategories <> "" Then mWherePOCategories &= ","
          mWherePOCategories &= mVI.ItemValue
      End Select
    Next

    mWhere &= String.Format(" and PO_CATEGORY in ({0})", mWherePOCategories)

    mWhere &= " and AccoutingCategoryID<>1" ''1-- this is honorarios in the AccoutingCategory table


    mdsoPurchasing.LoadPurchaseOrderItemAllocationInfos(pOtherCategoriesPOItemAllocationInfos, mWhere)

    For Each mPOIAI As clsPurchaseOrderItemAllocationInfo In pOtherCategoriesPOItemAllocationInfos

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOIAI.StockItemID)

      If mStockItem IsNot Nothing Then


        If mPOIAI.ExchangeRateValue > 0 Then
          mPOIAI.StdCost = (mPOIAI.Quantity * mStockItem.AverageCost) / mPOIAI.ExchangeRateValue


        End If

      End If
    Next


    ''Load Honorarios Purchasings

    mWhere = String.Format("SalesOrderID = {0} and  POStatus not in ({1})", pSalesOrder.SalesOrderID, CInt(ePurchaseOrderDueDateStatus.Cancelled))
    mWherePOCategories = ""
    For Each mVI In RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(ePurchaseCategories))
      Select Case mVI.ItemValue
        Case ePurchaseCategories.ConsumibleProduccion, ePurchaseCategories.InsumosProduccion,
        ePurchaseCategories.PatioYAserrio

        Case Else
          If mWherePOCategories <> "" Then mWherePOCategories &= ","
          mWherePOCategories &= mVI.ItemValue
      End Select
    Next

    mWhere &= String.Format(" and PO_CATEGORY in ({0})", mWherePOCategories)

    mWhere &= " and AccoutingCategoryID=1" ''1-- this is honorarios in the AccoutingCategory table


    mdsoPurchasing.LoadPurchaseOrderItemAllocationInfos(pHonorariosPOIAllocationInfos, mWhere)

    For Each mPOIAI As clsPurchaseOrderItemAllocationInfo In pHonorariosPOIAllocationInfos

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOIAI.StockItemID)

      If mStockItem IsNot Nothing Then


        If mPOIAI.ExchangeRateValue > 0 Then
          mPOIAI.StdCost = (mPOIAI.Quantity * mStockItem.AverageCost) / mPOIAI.ExchangeRateValue


        End If

      End If
    Next


    ''Load SalesItems
    mdsoSalesOrder.LoadWorkOrderAllocationsByWhere(mWOAs, "")
    mWhere = ""

    For Each mSOPI As dmSalesOrderPhaseItem In pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems
      mWOA = mWOAs.ItemFromSalesOrderPhaseItemID(mSOPI.SalesOrderPhaseItemID)

      If mWOA IsNot Nothing Then
        mWhere &= mWOA.WorkOrderID & ","
      End If
    Next

    If mWhere.Length > 0 Then
      mWhere = mWhere.Substring(0, mWhere.Length - 1)

      mWhere = String.Concat("WorkOrderID in (", mWhere)

      mWhere &= ")"
      mdsoSalesOrder.LoadWorkOrderInfos(pWorkOrderInfos, mWhere, dtoWorkOrderInfo.eMode.WorkOrderTracking)

    End If


    ''Load WoodPalletItem picked
    If mWhere <> "" Then
      mdsoStock.LoadWoodPalletItemInfosByWhere(pWoodPalletItemInfosPicked, mWhere)
    End If



    mWhere = "SalesOrderID =" & pSalesOrder.SalesOrderID
    mdsoSalesOrder.LoadSalesOrderPhaseItemsMatReqByWhere(pSalesOrderPhaseItemInfos, mWhere)

    ''Update SOPII value Cordobas to Dollar

    For Each mSOPII As clsSalesOrderPhaseItemInfo In pSalesOrderPhaseItemInfos

      If mSOPII.DateCommitted = Date.MinValue Then
        mSOPII.TempDateExchange = mSOPII.DateEntered
      Else
        mSOPII.TempDateExchange = mSOPII.DateCommitted
      End If
      If mSOPII.TempDateExchange = Date.MinValue Then mSOPII.TempDateExchange = Now
      mSOPII.ExchangeRate = GetExchangeRate(mSOPII.TempDateExchange, eCurrency.Cordobas)
      If mSOPII.ExchangeRate > 0 Then
        mSOPII.SOPIStockItemMatReqDollarValue = mSOPII.SOPItemMatReqCost / mSOPII.ExchangeRate
        mSOPII.SOPIPickDollarValue = mSOPII.SOPItemPickMatReqCost / mSOPII.ExchangeRate

      End If
    Next




    ''Load the WoodCost per SOPIinfo
    mdsoCostBook.LoadCostBookEntry(mCostBookEntrys, pSalesOrder.ProductCostBookID)
    mdsoSalesOrder.LoadSalesOrderPhaseItemInfoWoodCosts(pSalesOrderPhaseItemInfos, mCostBookEntrys)

    ''Update cost in Wood Consume
    For Each mWPII As clsWoodPalletItemInfo In WoodPalletItemInfosPicked

      If mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID) IsNot Nothing Then

        mWPII.UnitCost = mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID).Cost

      End If

    Next

    Return mOK
  End Function

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(DBConn)
    Dim mExchangeRate As Decimal = 0

    If vDate <> Date.MinValue Then
      mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(vDate, vCurrency)

    Else
      mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, vCurrency)

    End If

    Return mExchangeRate
  End Function

  Public ReadOnly Property Invoices As colInvoices
    Get
      Return pSalesOrder.Invoices
    End Get
  End Property

  Public ReadOnly Property PaymentAccounts As colPaymentOnAccounts
    Get
      Return pSalesOrder.PaymentAccounts
    End Get
  End Property

  Public ReadOnly Property SalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
    Get
      Return pSalesOrderPhaseItemInfos
    End Get
  End Property

  Public ReadOnly Property HonorariosPOIAllocationInfos As colPurchaseOrderItemAllocationInfos
    Get
      Return pHonorariosPOIAllocationInfos
    End Get
  End Property

  Public ReadOnly Property CustomerPOInfos As colCustomerPurchaseOrders
    Get
      Return pSalesOrder.CustomerPurchaseOrder
    End Get
  End Property

  Public ReadOnly Property POItemWOAllocationInfos As colPurchaseOrderItemAllocationInfos
    Get
      Return pPOItemWOAllocationInfos
    End Get
  End Property

  Public ReadOnly Property OtherCategoriesPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos
    Get
      Return pOtherCategoriesPOItemAllocationInfos
    End Get
  End Property

  Public ReadOnly Property WoodPalletItemInfosPicked As colWoodPalletItemInfos
    Get
      Return pWoodPalletItemInfosPicked
    End Get
  End Property

  Public ReadOnly Property SOPItemInfos As colSalesOrderPhaseItemInfos
    Get
      Return pSOPItemInfos
    End Get
  End Property

  Public ReadOnly Property WorkOrderInfos As colWorkOrderInfos
    Get
      Return pWorkOrderInfos
    End Get
  End Property

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property



End Class
