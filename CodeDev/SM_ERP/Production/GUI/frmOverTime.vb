Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmOverTime
  Private pController As fccTimeSheetEntry
  Private pTimeSheetEntryInfos As clsTimeSheetEntryInfo
  Private pIsActive As Boolean

  Public Shared Sub OpenFormMDI(ByRef rMDI As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mfrm As frmOverTime
    mfrm = New frmOverTime
    mfrm.pController = New fccTimeSheetEntry(rDBConn, rRTISGlobal)
    mfrm.MdiParent = rMDI
    mfrm.Show()
  End Sub

  Private Sub frmOverTime_Load(sender As Object, e As EventArgs) Handles Me.Load

    pIsActive = False
    pController.LoadTimeSheetEntryUIs()

    grdTimeSheetInfos.DataSource = pController.TimeSheetEntryUIs

    pIsActive = True

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

End Class