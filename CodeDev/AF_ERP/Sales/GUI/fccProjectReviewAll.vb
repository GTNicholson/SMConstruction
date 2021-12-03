Imports RTIS.DataLayer

Public Class fccProjectReviewAll
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
  Private pDBConn As clsDBConnBase
  Private pSalesOrderProjectReviews As colSalesProjectReviewCosts
  Private pWoodPalletItemInfosPicked As colWoodPalletItemInfos
  Private pTimeSheetProjects As colTimeSheetEntryInfos
  Private pMaterialsByCategories As New colMaterialRequirementInfos
  Private pOtherCategoriesPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos
  Private pHonorariosPOIAllocationInfos As colPurchaseOrderItemAllocationInfos

  Public Sub New(ByRef rDBConnBase As clsDBConnBase)

    pDBConn = rDBConnBase
  End Sub

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property
  Public Property SalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
    Get
      Return pSalesOrderPhaseItemInfos
    End Get
    Set(value As colSalesOrderPhaseItemInfos)
      pSalesOrderPhaseItemInfos = value
    End Set
  End Property

  Public Property SalesOrderProjectReviews As colSalesProjectReviewCosts
    Get
      Return pSalesOrderProjectReviews
    End Get
    Set(value As colSalesProjectReviewCosts)
      pSalesOrderProjectReviews = value
    End Set
  End Property

  Public Property WoodPalletItemInfosPicked As colWoodPalletItemInfos
    Get
      Return pWoodPalletItemInfosPicked
    End Get
    Set(value As colWoodPalletItemInfos)
      pWoodPalletItemInfosPicked = value
    End Set
  End Property

  Public Property TimeSheetProjects As colTimeSheetEntryInfos
    Get
      Return pTimeSheetProjects
    End Get
    Set(value As colTimeSheetEntryInfos)
      pTimeSheetProjects = value
    End Set
  End Property

  Public Property MaterialsByCategories As colMaterialRequirementInfos
    Get
      Return pMaterialsByCategories
    End Get
    Set(value As colMaterialRequirementInfos)
      pMaterialsByCategories = value
    End Set
  End Property

  Public Property StartDate As Date
  Public Property EndDate As Date
  Public Property OrderType As eOrderType
  Public Property OrderStatus As Byte

  Public Sub LoadDataRef()

    Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
    Dim mAllPOAllocationInfos As New colPurchaseOrderItemAllocationInfos
    Dim mWhere As String = ""
    Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
    Dim mStockItem As dmStockItem
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mCostBookEntrys As New colCostBookEntrys
    Dim mdsoCostBook As New dsoCostBook(pDBConn)
    Dim mdsoTimeSheet As New dsoProduction(pDBConn)



    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
    pSalesOrderProjectReviews = New colSalesProjectReviewCosts
    pWoodPalletItemInfosPicked = New colWoodPalletItemInfos
    pTimeSheetProjects = New colTimeSheetEntryInfos
    pMaterialsByCategories = New colMaterialRequirementInfos
    pOtherCategoriesPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pHonorariosPOIAllocationInfos = New colPurchaseOrderItemAllocationInfos



    ''Load all Purchasing
    mWhere = String.Format("POStatus not in ({0}) and OrderStatusENUM not in ({1})", CInt(ePurchaseOrderDueDateStatus.Cancelled), CInt(eSalesOrderstatus.Cancelada))


    If OrderType > 0 Then
      mWhere &= " and OrderTypeID=" & CInt(OrderType)

    End If

    If StartDate <> Date.MinValue And EndDate <> Date.MinValue Then

      mWhere &= String.Format(" and DateEntered between '{0}' and '{1}'", Format(StartDate, "yyyyMMdd"), Format(EndDate, "yyyyMMdd"))


    End If

    Select Case OrderStatus
      Case eSalesOrderstatus.EnProgreso
        mWhere &= " and OrderStatusEnum in (0, " & OrderStatus & ")"

      Case eSalesOrderstatus.Completed
        mWhere &= " and OrderStatusEnum = " & OrderStatus

    End Select




    mdsoPurchasing.LoadPurchaseOrderItemAllocationWorkOrderInfos(mAllPOAllocationInfos, mWhere)



    For Each mPOIAI As clsPurchaseOrderItemAllocationInfo In mAllPOAllocationInfos

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOIAI.StockItemID)

      If mStockItem IsNot Nothing Then


        If mPOIAI.ExchangeRateValue > 0 Then
          mPOIAI.StdCost = (mPOIAI.Quantity * mStockItem.AverageCost) / mPOIAI.ExchangeRateValue


        End If

      End If
    Next


    mWhere = String.Format(" OrderStatusENUM NOT IN (3) AND  DateEntered between '{0}' and '{1}'", Format(StartDate, "yyyyMMdd"), Format(EndDate, "yyyyMMdd"))

    If OrderType > 0 Then
      mWhere &= " and OrderTypeID=" & CInt(OrderType)

    End If


    Select Case OrderStatus
      Case eSalesOrderstatus.EnProgreso
        mWhere &= " and OrderStatusEnum in (0, " & OrderStatus & ")"

      Case eSalesOrderstatus.Completed
        mWhere &= " and OrderStatusEnum = " & OrderStatus

    End Select


    mdsoSalesOrder.LoadSalesOrderPhaseItemsMatReqByWhere(pSalesOrderPhaseItemInfos, mWhere)

    ''Update SOPII value Cordobas to Dollar
    mdsoCostBook.LoadCostBookEntry(mCostBookEntrys, mdsoSalesOrder.GetDefaultCostBook)
    mdsoSalesOrder.LoadSalesOrderPhaseItemInfoWoodCosts(pSalesOrderPhaseItemInfos, mCostBookEntrys, False)

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
        mSOPII.ManPowerActualTotalCostUSD = mSOPII.ManPowerActualTotalCost ' / mSOPII.ExchangeRate
        mSOPII.SOPIItemOutsourcingCost = mAllPOAllocationInfos.GetTotalPurchaseOrderItemOutsourcingValueUSDBySOPItemID(mSOPII.SalesOrderPhaseItemID, mSOPII.ExchangeRate)

      End If

      If mSOPII.IsGeneral Then
        mSOPII.SOPIPickDollarValue = mAllPOAllocationInfos.GetTotalPurchaseOrderItemAmountUSDBySOPItemID(mSOPII.SalesOrderPhaseItemID)
      End If



    Next


    mWhere = "WorkOrderID >0 and OrderStatusENUM NOT IN (3) and OrderTypeID=" & CInt(OrderType)

    If StartDate <> Date.MinValue And EndDate <> Date.MinValue Then

      mWhere &= String.Format(" and DateEntered between '{0}' and '{1}'", Format(StartDate, "yyyyMMdd"), Format(EndDate, "yyyyMMdd"))


    End If


    Select Case OrderStatus
      Case eSalesOrderstatus.EnProgreso
        mWhere &= " and OrderStatusEnum in (0, " & OrderStatus & ")"

      Case eSalesOrderstatus.Completed
        mWhere &= " and OrderStatusEnum = " & OrderStatus

    End Select



    mdsoStock.LoadWoodPalletItemInfosByWhere(pWoodPalletItemInfosPicked, mWhere)



    ''Update cost in Wood Consume
    For Each mWPII As clsWoodPalletItemInfo In WoodPalletItemInfosPicked

      If mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID) IsNot Nothing Then


        'If CostingMethod Then

        '  mWPII.UnitCost = mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID).CostIncludeRecovery

        'Else
        mWPII.UnitCost = mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID).Cost

        'End If

      End If

    Next



    ''Load the SalesOrderProject for the chart

    Dim mColSalesOrder As New colSalesOrders
    mWhere = String.Format(" OrderStatusENUM NOT IN (3) AND  DateEntered between '{0}' and '{1}'", Format(StartDate, "yyyyMMdd"), Format(EndDate, "yyyyMMdd"))

    If OrderType > 0 Then
      mWhere &= " and OrderTypeID=" & CInt(OrderType)

    End If

    Select Case OrderStatus
      Case eSalesOrderstatus.EnProgreso
        mWhere &= " and OrderStatusEnum in (0, " & OrderStatus & ")"

      Case eSalesOrderstatus.Completed
        mWhere &= " and OrderStatusEnum = " & OrderStatus

    End Select


    ''Load the SalesOrderProject for the chart
    mdsoSalesOrder.LoadSalesOrdersCollectionByWhere(mColSalesOrder, mWhere)

    For Each mSO In mColSalesOrder
      Dim mSalesProjectReview As New clsSalesProjectReviewCost(mSO)
      pSalesOrderProjectReviews.Add(mSalesProjectReview)
    Next

    For Each mSPR In pSalesOrderProjectReviews

      mSPR.ManPowerCost = pSalesOrderPhaseItemInfos.GetTotalActualManPowerValueBySalesOrderID(mSPR.SalesOrderID)
      mSPR.POIAOutsourcingSum = pSalesOrderPhaseItemInfos.GetTotalOutsourcingRealValueBySalesOrderID(mSPR.SalesOrderID)
      mSPR.SOPItemPickMatReqCost = pSalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickRealBySalesOrderID(mSPR.SalesOrderID)
      mSPR.SOPIPickWoodMatReqCost = pSalesOrderPhaseItemInfos.GetTotalWoodMatReqPickedBySalesOrderID(mSPR.SalesOrderID)
      mSPR.LineValue = pSalesOrderPhaseItemInfos.GetTotalLineValueBySalesOrderID(mSPR.SalesOrderID)

    Next

    ''//TimeSheet
    mWhere = "OrderStatusEnum not in (3) and IsNull(WorkOrderID,0)<>0 and OrderTypeID = " & CInt(OrderType)

    If StartDate <> Date.MinValue And EndDate <> Date.MinValue Then

      mWhere &= String.Format(" and DateEntered between '{0}' and '{1}'", Format(StartDate, "yyyyMMdd"), Format(EndDate, "yyyyMMdd"))


    End If


    Select Case OrderStatus
      Case eSalesOrderstatus.EnProgreso
        mWhere &= " and OrderStatusEnum in (0, " & OrderStatus & ")"

      Case eSalesOrderstatus.Completed
        mWhere &= " and OrderStatusEnum = " & OrderStatus

    End Select

    mdsoTimeSheet.LoadTimeSheetInfosByWhere(pTimeSheetProjects, mWhere)


    For Each mPOIA In mAllPOAllocationInfos

      Select Case mPOIA.PurchaseOrder.AccoutingCategoryID
        Case 1
          pHonorariosPOIAllocationInfos.Add(mPOIA)
        Case Else
          Select Case mPOIA.PurchaseOrder.Category


            Case ePurchaseCategories.InsumosProduccion, ePurchaseCategories.ConsumibleProduccion

            Case Else
              pOtherCategoriesPOItemAllocationInfos.Add(mPOIA)

          End Select
      End Select



    Next



    ''Load Material Requirements
    mWhere = "SalesOrderID>0 and OrderStatusEnum not in (3) and MaterialRequirementType = " & CInt(eMaterialRequirementType.StockItems) & " and OrderTypeID=" & CInt(OrderType)
    If StartDate <> Date.MinValue And EndDate <> Date.MinValue Then

      mWhere &= String.Format(" and DateEntered between '{0}' and '{1}'", Format(StartDate, "yyyyMMdd"), Format(EndDate, "yyyyMMdd"))


    End If


    Select Case OrderStatus
      Case eSalesOrderstatus.EnProgreso
        mWhere &= " and OrderStatusEnum in (0, " & OrderStatus & ")"

      Case eSalesOrderstatus.Completed
        mWhere &= " and OrderStatusEnum = " & OrderStatus

    End Select


    mdsoSalesOrder.LoadWorkOrderMatReqInfosByWhere(pMaterialsByCategories, mWhere)

    ''Update the ExchangeRate
    For Each mMaterialRequirementInfo In pMaterialsByCategories
      mMaterialRequirementInfo.ExchangeRate = GetExchangeRate(Now.Date, eCurrency.Cordobas)


      If mMaterialRequirementInfo.DateCommitted = Date.MinValue Then
        mMaterialRequirementInfo.TempDateExchange = mMaterialRequirementInfo.DateEntered
      Else
        mMaterialRequirementInfo.TempDateExchange = mMaterialRequirementInfo.DateCommitted
      End If
      If mMaterialRequirementInfo.TempDateExchange = Date.MinValue Then mMaterialRequirementInfo.TempDateExchange = Now
      mMaterialRequirementInfo.ExchangeRate = GetExchangeRate(mMaterialRequirementInfo.TempDateExchange, eCurrency.Cordobas)

    Next

    ''Load Material Requirements Other Expenses
    For Each mPOIAI In pHonorariosPOIAllocationInfos
      Dim mOtherExpenses As New clsMaterialRequirementInfo
      mOtherExpenses.StockItem.Category = 255
      mOtherExpenses.PickedQty = 1
      mOtherExpenses.ExchangeRate = mPOIAI.ExchangeRateValue

      Select Case mPOIAI.DefaultCurrency
        Case eCurrency.Cordobas
          mOtherExpenses.AverageCost = mPOIAI.Quantity * mPOIAI.UnitPrice

        Case eCurrency.Dollar
          If mPOIAI.ExchangeRateValue > 0 Then
            mOtherExpenses.AverageCost = (mPOIAI.Quantity * mPOIAI.UnitPrice) * mPOIAI.ExchangeRateValue
          Else
            mOtherExpenses.AverageCost = 0
          End If

      End Select

      pMaterialsByCategories.Add(mOtherExpenses)
    Next

    For Each mPOIAI In pOtherCategoriesPOItemAllocationInfos
      Dim mOtherExpenses As New clsMaterialRequirementInfo
      mOtherExpenses.StockItem.Category = 255
      mOtherExpenses.PickedQty = 1
      mOtherExpenses.ExchangeRate = mPOIAI.ExchangeRateValue

      Select Case mPOIAI.DefaultCurrency
        Case eCurrency.Cordobas
          mOtherExpenses.AverageCost = mPOIAI.Quantity * mPOIAI.UnitPrice

        Case eCurrency.Dollar
          If mPOIAI.ExchangeRateValue > 0 Then
            mOtherExpenses.AverageCost = (mPOIAI.Quantity * mPOIAI.UnitPrice) * mPOIAI.ExchangeRateValue
          Else
            mOtherExpenses.AverageCost = 0
          End If

      End Select




      pMaterialsByCategories.Add(mOtherExpenses)
    Next


  End Sub
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
End Class
