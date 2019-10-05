Imports RTIS.CommonVB

Public Class clsWorkOrderHandler
  Private pWorkOrder As dmWorkOrder

  Public Sub New(ByRef rWorkOrder As dmWorkOrder)
    pWorkOrder = rWorkOrder
  End Sub

  Public Sub AssignWOBatchRefs()
    Dim mRefAsciiVal As Integer

    If pWorkOrder.WorkOrderBatches.Count >= 2 Then
      mRefAsciiVal = Asc("A")
      For Each mWOBatch As dmWorkOrderBatch In pWorkOrder.WorkOrderBatches
        mWOBatch.Ref = Chr(mRefAsciiVal)
        mRefAsciiVal += 1
      Next
    Else
      If pWorkOrder.WorkOrderBatches.Count = 1 Then
        pWorkOrder.WorkOrderBatches(0).Ref = ""
      End If
    End If

  End Sub

  Public Sub RefreshQty()
    Dim mQty As Integer = 0
    For Each mWOB As dmWorkOrderBatch In pWorkOrder.WorkOrderBatches
      mQty += mWOB.Quantity
    Next
    pWorkOrder.Quantity = mQty
  End Sub

End Class
