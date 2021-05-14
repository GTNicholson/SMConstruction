Imports RTIS.DataLayer

Public Class fccSalesOrderReview
  Private pInvoiceInfos As colInvoiceInfos
  Private pCustomerPOInfos As colCustomerPurchaseOrders
  Private pPOItemAllocationInfos As colPurchaseOrderItemAllocationInfos
  Private pWoodRequirementInfos As colMaterialRequirementInfos
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

    pPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfos
    pWoodRequirementInfos = New colMaterialRequirementInfos
    pWorkOrderInfos = New colWorkOrderInfos
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos


    mWhere = String.Format("SalesOrderID = {0} and  POStatus not in ({1})", pSalesOrder.SalesOrderID, CInt(ePurchaseOrderDueDateStatus.Cancelled))

    mdsoPurchasing.LoadPurchaseOrderItemAllocationInfos(pPOItemAllocationInfos, mWhere)

    For Each mPOIAI As clsPurchaseOrderItemAllocationInfo In pPOItemAllocationInfos

      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPOIAI.StockItemID)

      If mStockItem IsNot Nothing Then


        If mPOIAI.ExchangeRateValue > 0 Then
            mPOIAI.StdCost = (mPOIAI.Quantity * mStockItem.AverageCost) / mPOIAI.ExchangeRateValue


        End If

      End If
    Next


    mWhere = "SalesOrderID = " & pSalesOrder.SalesOrderID

    mdsoStock.LoadWoodMaterialRequirementInfosByWhere(pWoodRequirementInfos, mWhere, dtoMaterialRequirementInfo.eMode.WoodMat)

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

  Public ReadOnly Property SalesOrderPhaseItemInfo As colSalesOrderPhaseItemInfos
    Get
      Return pSalesOrderPhaseItemInfos
    End Get
  End Property

  Public ReadOnly Property CustomerPOInfos As colCustomerPurchaseOrders
    Get
      Return pSalesOrder.CustomerPurchaseOrder
    End Get
  End Property

  Public ReadOnly Property POItemAllocationInfos As colPurchaseOrderItemAllocationInfos
    Get
      Return pPOItemAllocationInfos
    End Get
  End Property

  Public ReadOnly Property WoodRequirementInfos As colMaterialRequirementInfos
    Get
      Return pWoodRequirementInfos
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
  'Private Sub TempDemoLoad()
  '  Dim mInvInf As clsInvoiceInfo
  '  Dim mCustPO As dmCustomerPurchaseOrder
  '  Dim mPOIAI As clsPurchaseOrderItemAllocationInfo
  '  Dim mMRI As clsMaterialRequirementInfo
  '  Dim mSOPII As clsSalesOrderPhaseItemInfo
  '  Dim mWOAI As clsWorkOrderAllocationEditor

  '  pInvoiceInfos = New colInvoiceInfos
  '  pCustomerPOInfos = New colCustomerPurchaseOrders
  '  pPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfo
  '  pWoodRequirementInfos = New colMaterialRequirementInfos
  '  pSOPItemInfos = New colSalesOrderPhaseItemInfos
  '  pWorkOrderAllocationInfos = New colWorkOrderAllocationEditors

  '  '// Invoices
  '  mInvInf = New clsInvoiceInfo
  '  mInvInf.Invoice.InvoiceNo = "21-1012"
  '  mInvInf.Invoice.InvoiceDate = Now.Date.AddDays(-27)
  '  mInvInf.Invoice.NetValue = 4500
  '  pInvoiceInfos.Add(mInvInf)

  '  mInvInf = New clsInvoiceInfo
  '  mInvInf.Invoice.InvoiceNo = "21-1030"
  '  mInvInf.Invoice.InvoiceDate = Now.Date.AddDays(-2)
  '  mInvInf.Invoice.NetValue = 3500
  '  pInvoiceInfos.Add(mInvInf)

  '  '//  Customer POs
  '  mCustPO = New dmCustomerPurchaseOrder
  '  mCustPO.OrderNo = "V3271-1"
  '  mCustPO.OrderValue = 27340
  '  mCustPO.OrderDate = Now.Date.AddDays(-46)
  '  pCustomerPOInfos.Add(mCustPO)

  '  mCustPO = New dmCustomerPurchaseOrder
  '  mCustPO.OrderNo = "V3271-1a"
  '  mCustPO.OrderValue = 750
  '  mCustPO.OrderDate = Now.Date.AddDays(-39)
  '  pCustomerPOInfos.Add(mCustPO)

  '  '// POItemAllocationInfos
  '  mPOIAI = New clsPurchaseOrderItemAllocationInfo
  '  mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
  '  mPOIAI.PONum = "P00142"
  '  mPOIAI.PurchaseOrderItem.Description = "Banda Gates 040500"
  '  mPOIAI.PurchaseOrderItem.QtyRequired = "12"
  '  mPOIAI.PurchaseOrderItemAllocation.Quantity = "12"
  '  mPOIAI.PurchaseOrderItem.UnitPrice = "1.56"
  '  mPOIAI.RequiredDate = Now.Date.AddDays(-41)
  '  pPOItemAllocationInfos.Add(mPOIAI)

  '  mPOIAI = New clsPurchaseOrderItemAllocationInfo
  '  mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
  '  mPOIAI.PONum = "P00142"
  '  mPOIAI.PurchaseOrderItem.Description = "Carbon para Pulidora 5740NB"
  '  mPOIAI.PurchaseOrderItem.QtyRequired = "22"
  '  mPOIAI.PurchaseOrderItemAllocation.Quantity = "22"
  '  mPOIAI.PurchaseOrderItem.UnitPrice = "4.16"
  '  mPOIAI.RequiredDate = Now.Date.AddDays(-41)
  '  pPOItemAllocationInfos.Add(mPOIAI)

  '  mPOIAI = New clsPurchaseOrderItemAllocationInfo
  '  mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
  '  mPOIAI.PONum = "P00142"
  '  mPOIAI.PurchaseOrderItem.Description = "Duro Tint Cenizaro"
  '  mPOIAI.PurchaseOrderItem.QtyRequired = "4"
  '  mPOIAI.PurchaseOrderItemAllocation.Quantity = "4"
  '  mPOIAI.PurchaseOrderItem.UnitPrice = "21.00"
  '  mPOIAI.RequiredDate = Now.Date.AddDays(-41)
  '  pPOItemAllocationInfos.Add(mPOIAI)

  '  mPOIAI = New clsPurchaseOrderItemAllocationInfo
  '  mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
  '  mPOIAI.PONum = "P00150"
  '  mPOIAI.PurchaseOrderItem.Description = "Tornillo Gypson 1 1/4 punta broca"
  '  mPOIAI.PurchaseOrderItem.QtyRequired = "12"
  '  mPOIAI.PurchaseOrderItemAllocation.Quantity = "12"
  '  mPOIAI.PurchaseOrderItem.UnitPrice = "1.56"
  '  mPOIAI.RequiredDate = Now.Date.AddDays(-31)
  '  pPOItemAllocationInfos.Add(mPOIAI)

  '  mPOIAI = New clsPurchaseOrderItemAllocationInfo
  '  mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
  '  mPOIAI.PONum = "P00151"
  '  mPOIAI.PurchaseOrderItem.Description = "Plywood Corriente 3/4"
  '  mPOIAI.PurchaseOrderItem.QtyRequired = "7"
  '  mPOIAI.PurchaseOrderItemAllocation.Quantity = "7"
  '  mPOIAI.PurchaseOrderItem.UnitPrice = "7.91"
  '  mPOIAI.RequiredDate = Now.Date.AddDays(-20)
  '  pPOItemAllocationInfos.Add(mPOIAI)

  '  mPOIAI = New clsPurchaseOrderItemAllocationInfo
  '  mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
  '  mPOIAI.PONum = "P00156"
  '  mPOIAI.PurchaseOrderItem.Description = "Tapon de polietileno redondo de 1 negro"
  '  mPOIAI.PurchaseOrderItem.QtyRequired = "1"
  '  mPOIAI.PurchaseOrderItemAllocation.Quantity = "1"
  '  mPOIAI.PurchaseOrderItem.UnitPrice = "11.40"
  '  mPOIAI.RequiredDate = Now.Date.AddDays(-14)
  '  pPOItemAllocationInfos.Add(mPOIAI)



  '  '// Wood Requirements
  '  mMRI = New clsMaterialRequirementInfo

  '  mMRI.MaterialRequirement.Description = "Laurel"
  '  mMRI.WorkOrder.Description = "A"
  '  mMRI.MaterialRequirement.NetThickness = 2
  '  mMRI.MaterialRequirement.Quantity = 121
  '  pWoodRequirementInfos.Add(mMRI)

  '  '// Sales order phase items
  '  mSOPII = New clsSalesOrderPhaseItemInfo

  '  pSOPItemInfos.Add(mSOPII)

  '  '// Work Order Allocations
  '  mWOAI = New clsWorkOrderAllocationEditor

  '  pWorkOrderAllocationInfos.Add(mWOAI)

  'End Sub
End Class
