Public Class frmTimeSheetEntry
  Private pController As fccTimeSheetEntry

  Public Shared Sub OpenFormModal(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmTimeSheetEntry
    mfrm = New frmTimeSheetEntry

    mfrm.pController = New fccTimeSheetEntry(rDBConn)

    mfrm.ShowDialog()
  End Sub

End Class