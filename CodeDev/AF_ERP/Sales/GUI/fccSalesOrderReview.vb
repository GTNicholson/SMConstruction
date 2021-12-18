Imports DevExpress.Spreadsheet
Imports RTIS.CommonVB
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
  Private pMaterialsByCategories As colMaterialRequirementInfos 'colPurchaseOrderItemAllocationInfos
  Private pTimeSheetProjects As New colTimeSheetEntryInfos

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
    Dim mWherePOCategories As String = ""
    Dim mAllPOAllocationInfos As New colPurchaseOrderItemAllocationInfos
    Dim mdsoTimeSheet As New dsoProduction(pDBConn)

    pMaterialsByCategories = New colMaterialRequirementInfos
    pPOItemWOAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pOtherCategoriesPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pHonorariosPOIAllocationInfos = New colPurchaseOrderItemAllocationInfos

    pWoodPalletItemInfosPicked = New colWoodPalletItemInfos
    pWorkOrderInfos = New colWorkOrderInfos
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
    pTimeSheetProjects = New colTimeSheetEntryInfos


    ''Load all Purchasing
    mWhere = String.Format("SalesOrderID = {0} and  POStatus not in ({1})", pSalesOrder.SalesOrderID, CInt(ePurchaseOrderDueDateStatus.Cancelled))
    mdsoPurchasing.LoadPurchaseOrderItemAllocationWorkOrderInfos(mAllPOAllocationInfos, mWhere)


    mdsoPurchasing.LoadPurchaseOrderItemAllocationInfos(mAllPOAllocationInfos, mWhere)

    For Each mPOIAI As clsPurchaseOrderItemAllocationInfo In mAllPOAllocationInfos

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOIAI.StockItemID)

      If mStockItem IsNot Nothing Then


        If mPOIAI.ExchangeRateValue > 0 Then
          mPOIAI.StdCost = (mPOIAI.Quantity * mStockItem.AverageCost) / mPOIAI.ExchangeRateValue


        End If

      End If
    Next


    For Each mPOIA In mAllPOAllocationInfos

      Select Case mPOIA.PurchaseOrder.AccoutingCategoryID
        Case 1
          pHonorariosPOIAllocationInfos.Add(mPOIA)
        Case Else
          Select Case mPOIA.PurchaseOrder.Category


            Case ePurchaseCategories.InsumosProduccion, ePurchaseCategories.ConsumibleProduccion

              pPOItemWOAllocationInfos.Add(mPOIA)
            Case Else
              pOtherCategoriesPOItemAllocationInfos.Add(mPOIA)

          End Select
      End Select



    Next

    ''Load Material Requirements
    mdsoSalesOrder.LoadWorkOrderMatReqInfosByWhere(pMaterialsByCategories, "SalesOrderID = " & pSalesOrder.SalesOrderID & " and MaterialRequirementType = " & CInt(eMaterialRequirementType.StockItems))

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
    'pPOItemWOAllocationInfos = mAllPOAllocationInfos



    ''Load SalesItems
    mdsoSalesOrder.LoadWorkOrderAllocationsByWhere(mWOAs, " WorkOrderID In (Select WorkOrderID from WorkOrder where Status In(1,2,4))")
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
        mSOPII.ManPowerActualTotalCostUSD = mSOPII.ManPowerActualTotalCost ' / mSOPII.ExchangeRate
        mSOPII.SOPIItemOutsourcingCost = mAllPOAllocationInfos.GetTotalPurchaseOrderItemOutsourcingValueUSDBySOPItemID(mSOPII.SalesOrderPhaseItemID, mSOPII.ExchangeRate)

      End If

      If mSOPII.IsGeneral Then
        mSOPII.SOPIPickDollarValue = mAllPOAllocationInfos.GetTotalPurchaseOrderItemAmountUSDBySOPItemID(mSOPII.SalesOrderPhaseItemID)
      End If



    Next




    ''Load the WoodCost per SOPIinfo
    mdsoCostBook.LoadCostBookEntry(mCostBookEntrys, pSalesOrder.ProductCostBookID)
    mdsoSalesOrder.LoadSalesOrderPhaseItemInfoWoodCosts(pSalesOrderPhaseItemInfos, mCostBookEntrys, CostingMethod)

    ''Update cost in Wood Consume
    For Each mWPII As clsWoodPalletItemInfo In WoodPalletItemInfosPicked

      If mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID) IsNot Nothing Then


        If CostingMethod Then

          mWPII.UnitCost = mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID).CostIncludeRecovery

        Else
          mWPII.UnitCost = mCostBookEntrys.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID).Cost

        End If

      End If

    Next

    ''//TimeSheet
    mWhere = "SalesOrderID = " & pSalesOrder.SalesOrderID & " and IsNull(WorkOrderID,0)<>0"
    mdsoTimeSheet.LoadTimeSheetInfosByWhere(pTimeSheetProjects, mWhere)



    ''Load CIF
    TotalIndirectCost = pSalesOrder.CIFValue


    Return mOK
  End Function

  Public Function GetTotalWOCompleteValue() As Decimal
    Dim mRetVal As Object
    Dim mSql As String = ""
    Dim mRetValDecimal As Decimal
    Dim mExchangeRateToday As Decimal
    Try



      mExchangeRateToday = GetExchangeRate(Now, eCurrency.Cordobas)

      pDBConn.Connect()
      mSql = "Select TotalWOCompleteValue from vwTotalWOCompleteValue where SalesOrderID = " & pSalesOrder.SalesOrderID
      mRetVal = pDBConn.ExecuteScalar(mSql)

      If mRetVal IsNot Nothing Then
        mRetValDecimal = mRetVal / mExchangeRateToday
      Else
        mRetValDecimal = 0
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetValDecimal
  End Function

  Public Function GetTotalWOInProcessValue() As Decimal
    Dim mRetVal As Object
    Dim mSql As String = ""
    Dim mRetValDecimal As Decimal
    Dim mExchangeRateToday As Decimal


    Try

      mExchangeRateToday = GetExchangeRate(Now, eCurrency.Cordobas)
      pDBConn.Connect()

      mSql = "Select TotalWOCompleteValue from vwTotalWOInProcessValue where SalesOrderID = " & pSalesOrder.SalesOrderID
      mRetVal = pDBConn.ExecuteScalar(mSql)

      If mRetVal IsNot Nothing Then
        mRetValDecimal = mRetVal
        mRetValDecimal = mRetVal / mExchangeRateToday

      Else
        mRetValDecimal = 0
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetValDecimal
  End Function

  Friend Sub CreateExcelProjectReview(ByRef vWorkBook As Workbook)
    ' Dim mWB As DevExpress.Spreadsheet.Workbook
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String

    mFileName = "Sales Project Review" & "_" & SalesOrder.OrderNo & ".xls"



    mFileName = clsGeneralA.GetFileSafeName(mFileName)

    mExportDirectory = IO.Path.Combine(CType(AppRTISGlobal.GetInstance, AppRTISGlobal).DefaultExportPath, clsConstants.SalesOrderFileFolderUsr, SalesOrder.DateEntered.Year, SalesOrder.SalesOrderID)
    mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
    If IO.Directory.Exists(mExportDirectory) = False Then
      IO.Directory.CreateDirectory(mExportDirectory)
    End If

    PreparePrintSpreadSheet(vWorkBook.Worksheets(0))

    mFilePath = IO.Path.Combine(mExportDirectory, mFileName)
    vWorkBook.SaveDocument(mFilePath, DevExpress.Spreadsheet.DocumentFormat.Xls)


    pSalesOrder.OutputDocuments.SetFilePath(eParentType.InternalWorkOrder, eDocumentType.SalesProjectReview, eFileType.Excel, mFilePath)

  End Sub

  Public Sub PreparePrintSpreadSheet(ByRef rWorkSheet As DevExpress.Spreadsheet.Worksheet)
    Dim mRange As DevExpress.Spreadsheet.Range
    With rWorkSheet
      .DefinedNames.Remove("_xlnm.Print_Area")
      mRange = .GetUsedRange
      .DefinedNames.Add("_xlnm.Print_Area", mRange.ToString)
      .DefinedNames(0).Range = mRange
      .ActiveView.PaperKind = System.Drawing.Printing.PaperKind.A3
      .ActiveView.Orientation = DevExpress.Spreadsheet.PageOrientation.Landscape
      .ActiveView.Margins.Top = 70
      .ActiveView.Margins.Left = 70
      .ActiveView.Margins.Right = 70
      .ActiveView.Margins.Bottom = 70
      .ActiveView.Zoom = 90                 '// MDH 05/11/20

      .PrintOptions.FitToPage = True
      .PrintOptions.FitToWidth = 1
      .PrintOptions.FitToHeight = 0
    End With
  End Sub


  Public Function GetExcelSalesProjectReviewDetail(ByRef rSalesOrder As dmSalesOrder, ByVal vSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos) As Workbook
    Dim mWB As DevExpress.Spreadsheet.Workbook = Nothing
    Dim mSOProjectExcelReview As clsExcelSalesOrderReview_Detail
    Dim mDT As New Data.DataTable

    mSOProjectExcelReview = New clsExcelSalesOrderReview_Detail(rSalesOrder, vSalesOrderPhaseItemInfos, pWoodPalletItemInfosPicked, pMaterialsByCategories, pTimeSheetProjects)


    mSOProjectExcelReview.CreateSummarisedExport()

    mWB = mSOProjectExcelReview.WorkBook
    Return mWB
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

  Public ReadOnly Property TimeSheetProjects As colTimeSheetEntryInfos
    Get
      Return pTimeSheetProjects
    End Get
  End Property
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


  Public ReadOnly Property MaterialsByCategories As colMaterialRequirementInfos
    Get
      Return pMaterialsByCategories
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

  Public Property CostingMethod As Boolean
  Public Property TotalIndirectCost As Decimal

  Public Sub UpdateIndirectCost()
    Try
      Dim mWhere As String = "Update SalesOrder set CIFValue = " & TotalIndirectCost & " where SalesOrderID = " & pSalesOrder.SalesOrderID
      pDBConn.Connect()

      pDBConn.ExecuteNonQuery(mWhere)

      pSalesOrder.CIFValue = TotalIndirectCost
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub
End Class
