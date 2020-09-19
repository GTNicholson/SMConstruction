Imports RTIS.ERPCore

Public Class clsSalesOrderActionsHandler : Inherits clsDomainActionHandler
  Private pSalesOrder As dmSalesOrder
  Public Property SalesOrder() As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(ByVal value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Enum eSalesOrderAction
    GenerateWorkOrders = 1
    RecallWorkOrders = 2
  End Enum

  Public Sub New(ByRef rRTISUser As RTIS.DataLayer.clsRTISUser, ByVal vDBConn As RTIS.DataLayer.clsDBConnBase)
    MyBase.New(rRTISUser, vDBConn)
    '// should be in base class?
    pDomainActions = New List(Of clsDomainAction)

    pDomainActions.Add(New clsActionSalesOrderGenerateWOs(Me, eSalesOrderAction.GenerateWorkOrders))
    pDomainActions.Add(New clsActionSalesOrderRecallWOs(Me, eSalesOrderAction.RecallWorkOrders))

  End Sub

  Protected Overrides Sub DoInitMainObject()

  End Sub

  Protected Overrides Sub InitExtended()

  End Sub
End Class
