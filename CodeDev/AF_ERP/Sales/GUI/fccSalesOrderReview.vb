Public Class fccSalesOrderReview
  Private pInvoiceInfos As colInvoiceInfos
  Private pCustomerPOInfos As colCustomerPurchaseOrders
  Private pPOItemAllocationInfos As colPurchaseOrderItemAllocationInfo
  Private pWoodRequirementInfos As colMaterialRequirementInfos
  Private pSOPItemInfos As colSalesOrderPhaseItemInfos
  Private pWorkOrderAllocationInfos As colWorkOrderAllocationEditors

  Public Sub New()
    TempDemoLoad
  End Sub

  Public ReadOnly Property InvoiceInfos As colInvoiceInfos
    Get
      Return pInvoiceInfos
    End Get
  End Property

  Public ReadOnly Property CustomerPOInfos As colCustomerPurchaseOrders
    Get
      Return pCustomerPOInfos
    End Get
  End Property

  Public ReadOnly Property POItemAllocationInfos As colPurchaseOrderItemAllocationInfo
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

  Public ReadOnly Property WorkOrderAllocationInfos As colWorkOrderAllocationEditors
    Get
      Return pWorkOrderAllocationInfos
    End Get
  End Property


  Private Sub TempDemoLoad()
    Dim mInvInf As clsInvoiceInfo
    Dim mCustPO As dmCustomerPurchaseOrder
    Dim mPOIAI As clsPurchaseOrderItemAllocationInfo
    Dim mMRI As clsMaterialRequirementInfo
    Dim mSOPII As clsSalesOrderPhaseItemInfo
    Dim mWOAI As clsWorkOrderAllocationEditor

    pInvoiceInfos = New colInvoiceInfos
    pCustomerPOInfos = New colCustomerPurchaseOrders
    pPOItemAllocationInfos = New colPurchaseOrderItemAllocationInfo
    pWoodRequirementInfos = New colMaterialRequirementInfos
    pSOPItemInfos = New colSalesOrderPhaseItemInfos
    pWorkOrderAllocationInfos = New colWorkOrderAllocationEditors

    '// Invoices
    mInvInf = New clsInvoiceInfo
    mInvInf.Invoice.InvoiceNo = "21-1012"
    mInvInf.Invoice.InvoiceDate = Now.Date.AddDays(-27)
    mInvInf.Invoice.NetValue = 4500
    pInvoiceInfos.Add(mInvInf)

    mInvInf = New clsInvoiceInfo
    mInvInf.Invoice.InvoiceNo = "21-1030"
    mInvInf.Invoice.InvoiceDate = Now.Date.AddDays(-2)
    mInvInf.Invoice.NetValue = 3500
    pInvoiceInfos.Add(mInvInf)

    '//  Customer POs
    mCustPO = New dmCustomerPurchaseOrder
    mCustPO.OrderNo = "V3271-1"
    mCustPO.OrderValue = 27340
    mCustPO.OrderDate = Now.Date.AddDays(-46)
    pCustomerPOInfos.Add(mCustPO)

    mCustPO = New dmCustomerPurchaseOrder
    mCustPO.OrderNo = "V3271-1a"
    mCustPO.OrderValue = 750
    mCustPO.OrderDate = Now.Date.AddDays(-39)
    pCustomerPOInfos.Add(mCustPO)

    '// POItemAllocationInfos
    mPOIAI = New clsPurchaseOrderItemAllocationInfo
    mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
    mPOIAI.PONum = "P00142"
    mPOIAI.PurchaseOrderItem.Description = "Banda Gates 040500"
    mPOIAI.PurchaseOrderItem.QtyRequired = "12"
    mPOIAI.PurchaseOrderItemAllocation.Quantity = "12"
    mPOIAI.PurchaseOrderItem.UnitPrice = "1.56"
    mPOIAI.RequiredDate = Now.Date.AddDays(-41)
    pPOItemAllocationInfos.Add(mPOIAI)

    mPOIAI = New clsPurchaseOrderItemAllocationInfo
    mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
    mPOIAI.PONum = "P00142"
    mPOIAI.PurchaseOrderItem.Description = "Carbon para Pulidora 5740NB"
    mPOIAI.PurchaseOrderItem.QtyRequired = "22"
    mPOIAI.PurchaseOrderItemAllocation.Quantity = "22"
    mPOIAI.PurchaseOrderItem.UnitPrice = "4.16"
    mPOIAI.RequiredDate = Now.Date.AddDays(-41)
    pPOItemAllocationInfos.Add(mPOIAI)

    mPOIAI = New clsPurchaseOrderItemAllocationInfo
    mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
    mPOIAI.PONum = "P00142"
    mPOIAI.PurchaseOrderItem.Description = "Duro Tint Cenizaro"
    mPOIAI.PurchaseOrderItem.QtyRequired = "4"
    mPOIAI.PurchaseOrderItemAllocation.Quantity = "4"
    mPOIAI.PurchaseOrderItem.UnitPrice = "21.00"
    mPOIAI.RequiredDate = Now.Date.AddDays(-41)
    pPOItemAllocationInfos.Add(mPOIAI)

    mPOIAI = New clsPurchaseOrderItemAllocationInfo
    mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
    mPOIAI.PONum = "P00150"
    mPOIAI.PurchaseOrderItem.Description = "Tornillo Gypson 1 1/4 punta broca"
    mPOIAI.PurchaseOrderItem.QtyRequired = "12"
    mPOIAI.PurchaseOrderItemAllocation.Quantity = "12"
    mPOIAI.PurchaseOrderItem.UnitPrice = "1.56"
    mPOIAI.RequiredDate = Now.Date.AddDays(-31)
    pPOItemAllocationInfos.Add(mPOIAI)

    mPOIAI = New clsPurchaseOrderItemAllocationInfo
    mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
    mPOIAI.PONum = "P00151"
    mPOIAI.PurchaseOrderItem.Description = "Plywood Corriente 3/4"
    mPOIAI.PurchaseOrderItem.QtyRequired = "7"
    mPOIAI.PurchaseOrderItemAllocation.Quantity = "7"
    mPOIAI.PurchaseOrderItem.UnitPrice = "7.91"
    mPOIAI.RequiredDate = Now.Date.AddDays(-20)
    pPOItemAllocationInfos.Add(mPOIAI)

    mPOIAI = New clsPurchaseOrderItemAllocationInfo
    mPOIAI.PurchaseOrder.DefaultCurrency = eCurrency.Dollar
    mPOIAI.PONum = "P00156"
    mPOIAI.PurchaseOrderItem.Description = "Tapon de polietileno redondo de 1 negro"
    mPOIAI.PurchaseOrderItem.QtyRequired = "1"
    mPOIAI.PurchaseOrderItemAllocation.Quantity = "1"
    mPOIAI.PurchaseOrderItem.UnitPrice = "11.40"
    mPOIAI.RequiredDate = Now.Date.AddDays(-14)
    pPOItemAllocationInfos.Add(mPOIAI)



    '// Wood Requirements
    mMRI = New clsMaterialRequirementInfo

    mMRI.MaterialRequirement.Description = "Laurel"
    mMRI.WorkOrder.Description = "A"
    mMRI.MaterialRequirement.NetThickness = 2
    mMRI.MaterialRequirement.Quantity = 121
    pWoodRequirementInfos.Add(mMRI)

    '// Sales order phase items
    mSOPII = New clsSalesOrderPhaseItemInfo

    pSOPItemInfos.Add(mSOPII)

    '// Work Order Allocations
    mWOAI = New clsWorkOrderAllocationEditor

    pWorkOrderAllocationInfos.Add(mWOAI)

  End Sub
End Class
