Public Class fccWorkOrderWoodProcess
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pWorkOrderID As Integer

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWorkOrderID As Integer)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pWorkOrderID = vWorkOrderID
  End Sub
End Class
