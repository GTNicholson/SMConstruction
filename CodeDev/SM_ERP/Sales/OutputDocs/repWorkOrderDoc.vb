Public Class repWorkOrderDoc
  Private pWorkOrder As dmWorkOrder

  Public Shared Function GenerateReport(ByRef rWorkOrder As dmWorkOrder) As repWorkOrderDoc
    Dim mRep As New repWorkOrderDoc
    mRep.pWorkOrder = rWorkOrder
    mRep.CreateDocument()
    Return mRep
  End Function

End Class