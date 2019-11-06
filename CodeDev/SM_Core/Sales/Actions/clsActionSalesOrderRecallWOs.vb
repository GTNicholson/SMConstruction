Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class clsActionSalesOrderRecallWOs : Inherits clsDomainAction
  Private pSalesOrderActionHandler As clsSalesOrderActionsHandler
  Public Sub New(ByRef rHandler As clsDomainActionHandler, ByVal vActionID As Integer)
    MyBase.New(rHandler, vActionID)
    pSalesOrderActionHandler = CType(rHandler, clsSalesOrderActionsHandler)
  End Sub
  Protected Overrides Sub RefreshActionPermission()

  End Sub

  Protected Overrides Sub RefreshActionValidation()

  End Sub

  Public Overrides Function ActionPerform() As clsValWarn
    Dim mRetVal As New clsValWarn
    Dim mDSO As New dsoSales(pSalesOrderActionHandler.DBConn)

    '// Generate WO numbers

    For Each mSOI As dmSalesOrderItem In pSalesOrderActionHandler.SalesOrder.SalesOrderItems
      For Each mWO As dmWorkOrder In mSOI.WorkOrders
        mWO.WorkOrderNo = ""
      Next
      mDSO.SaveSalesOrderItemWithWOs(mSOI)
    Next
    pSalesOrderActionHandler.SalesOrder.WorkOrdersIssued = False
    Return mRetVal
  End Function
End Class
