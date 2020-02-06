Imports RTIS.CommonVB


Public Class clsPurchasingSharedFuncs



  Public Shared Sub SetDelDetails(ByVal vPurchaseOrder As dmPurchaseOrder, ByVal vSalesOrder As dmSalesOrder)
    Dim mRTISGlobal As AppRTISGlobal = AppRTISGlobal.GetInstance

    'If vPurchaseOrder.DirectDelivery Then
    '  If vSalesOrder IsNot Nothing AndAlso vSalesOrder.SalesProject IsNot Nothing Then
    '    vPurchaseOrder.DeliveryAddress = vSalesOrder.DeliveryAddress
    '    '  vPurchaseOrder.DeliveryCompanyName = vSalesOrder.SalesProject.ProjectRef
    '    vPurchaseOrder.DeliveryContact = vSalesOrder.ContactName
    '    vPurchaseOrder.DeliveryEmail = vSalesOrder.ContactEmail
    '    vPurchaseOrder.DeliveryTel = vSalesOrder.ContactTel
    '  End If
    ' Else
    '  vPurchaseOrder.DeliveryCompanyName = mRTISGlobal.HostCompany.CompanyName

  End Sub


  'Public Shared Function NominalCodeFromStockItemCategory(ByVal vStockItemCategory As Integer) As String
  '  Dim mRetVal As String = ""
  '  Dim mVIs As colValueItems
  '  mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.StockItemCategoryNominalCodes)
  '  mRetVal = mVIs.ItemValueToDisplayValue(vStockItemCategory)
  '  Return mRetVal
  'End Function

  Public Shared Sub ApplyPOItemUnitPrice(ByVal vPurchaseOrder As dmPurchaseOrder, ByVal vPOItem As dmPurchaseOrderItem, ByVal vValue As Decimal)

    'Dim mPreExtraDiscountPrice As Decimal = vValue / (1 - vPurchaseOrder.ExtraDiscount)
    'Dim mPreMainDiscountPrice As Decimal = mPreExtraDiscountPrice / (1 - vPurchaseOrder.MainDiscount)

    'vPOItem.ListPrice = mPreMainDiscountPrice
    vPOItem.UnitPrice = vValue

  End Sub

  'Public Shared Sub ApplyPOItemListPrice(ByVal vPurchaseOrder As dmPurchaseOrder, ByVal vPOItem As dmPOItem, ByVal vValue As Decimal)

  '  Dim mMainDiscountedPrice As Decimal = vValue * (1 - vPurchaseOrder.MainDiscount)
  '  Dim mExtraDiscountedPrice As Decimal = mMainDiscountedPrice * (1 - vPurchaseOrder.ExtraDiscount)

  '  vPOItem.ListPrice = vValue
  '  vPOItem.UnitPrice = mExtraDiscountedPrice

  'End Sub

End Class

