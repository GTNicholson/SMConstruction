Public Class clsWorkOrderCostingSummaryInfo
  Public Property WorkOrderID As Integer
  Public Property WorkOrderNo As String
  Public Property ProjectName As String
  Public Property OrderNo As String
  Public Property CustomerName As String
  Public Property ManPowerCostUSD As Decimal
  Public Property MaterialCostUSD As Decimal
  Public Property PickedWoodCostUSD As Decimal
  Public Property OtherExpensesCostUSD As Decimal

End Class

Public Class colWorkOrderCostingSummaryInfos : Inherits List(Of clsWorkOrderCostingSummaryInfo)

End Class

