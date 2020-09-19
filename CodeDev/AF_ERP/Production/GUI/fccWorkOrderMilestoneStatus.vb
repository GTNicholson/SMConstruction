Public Class fccWorkOrderMilestoneStatus
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus)
    pDBConn = rDBConn
    pWorkOrderMilestoneStatus = rWorkOrderMilestoneStatus
  End Sub

  Public ReadOnly Property WorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus
    Get
      Return pWorkOrderMilestoneStatus
    End Get
  End Property

  Public Sub SaveObject()
    Dim mdso As dsoProduction
    mdso = New dsoProduction(pDBConn)
    mdso.SaveWorkOrderTracking(pWorkOrderMilestoneStatus)
  End Sub

End Class
