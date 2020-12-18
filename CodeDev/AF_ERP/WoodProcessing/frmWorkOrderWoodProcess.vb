Public Class frmWorkOrderWoodProcess
  Private pController As fccWorkOrderWoodProcess

  Public Shared Sub OpenForm(ByRef rMDIForm As frmTabbedMDI, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWorkOrderID As Integer)
    Dim mfrm As frmWorkOrderWoodProcess

    mfrm = New frmWorkOrderWoodProcess
    mfrm.pController = New fccWorkOrderWoodProcess(rDBConn, rRTISGlobal, vWorkOrderID)

    mfrm.MdiParent = rMDIForm
    mfrm.Show()

  End Sub

End Class