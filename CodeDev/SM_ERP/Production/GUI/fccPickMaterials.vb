Public Class fccPickMaterials
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrder As clsWorkOrderInfo
  Private pMaterialRequirementProcessors As colMaterialRequirementInfos

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

End Class
