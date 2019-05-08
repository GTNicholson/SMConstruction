Public Class frmTimeSheetEntry
  Private pController As fccTimeSheetEntry

  Public Shared Sub OpenFormModal(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmTimeSheetEntry
    mfrm = New frmTimeSheetEntry

    mfrm.pController = New fccTimeSheetEntry(rDBConn)

    mfrm.ShowDialog()
  End Sub

  Private Sub frmTimeSheetEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
    pController.SetInitialDefaultValues()
    pController.LoadTimeSheetEntrys
    grdTimeSheet.DataSource = pController.TimeSheetEntrys
  End Sub
End Class