Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmTimeSheetEntry
  Private pController As fccTimeSheetEntry

  Public Shared Sub OpenFormModal(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmTimeSheetEntry
    mfrm = New frmTimeSheetEntry

    mfrm.pController = New fccTimeSheetEntry(rDBConn, rRTISGlobal)

    mfrm.ShowDialog()
  End Sub

  Private Sub frmTimeSheetEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mErrorDisplayed As Boolean
    Dim mMsg As String = ""

    Try

      pController.SetInitialDefaultValues()
      pController.LoadTimeSheetEntrys()
      pController.LoadTimeSheetEntryUIs()
      grdTimeSheet.DataSource = pController.TimeSheetEntryUIs

      pController.LoadRefs()
      LoadCombos()

      RefreshControls()

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))
    End If

  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboEmployee, pController.RTISGlobal.RefLists.RefListVI(appRefLists.Employees))
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub RefreshControls()
    datWeekCommencing.DateTime = pController.WCDate.Date
    timTimeStart.EditValue = pController.StartTime.TimeOfDay
    timTimeEnd.EditValue = pController.EndTime.TimeOfDay
    radgrpWorkCentreID.EditValue = pController.WorkCentreID
  End Sub

  Private Sub UpdateObjects()
    pController.WCDate = datWeekCommencing.DateTime.Date
    pController.StartTime = New Date + timTimeStart.EditValue
  End Sub

  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try

      UpdateObjects()

      pController.LoadTimeSheetEntrys()
      pController.LoadTimeSheetEntryUIs()
      grdTimeSheet.DataSource = pController.TimeSheetEntryUIs

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    Try
      pController.SaveTimeSheetEntrys()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub cboEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployee.SelectedIndexChanged
    Try
      pController.SetCurrentEmployee(clsDEControlLoading.GetDEComboValue(cboEmployee))
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvTimeSheet_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvTimeSheet.CustomDrawCell
    Dim mTSUI As clsTimeSheetEntryUI
    Dim mCode As clsTimeSheetCode = Nothing

    mTSUI = gvTimeSheet.GetRow(e.RowHandle)
    Select Case e.Column.FieldName
      Case "Monday"
        mCode = mTSUI.GetTimeSheetEntryCode(0)
      Case "Tuesday"
        mCode = mTSUI.GetTimeSheetEntryCode(1)
      Case "Wednesday"
        mCode = mTSUI.GetTimeSheetEntryCode(2)
      Case "Thursday"
        mCode = mTSUI.GetTimeSheetEntryCode(3)
      Case "Friday"
        mCode = mTSUI.GetTimeSheetEntryCode(4)
      Case "Saturday"
        mCode = mTSUI.GetTimeSheetEntryCode(5)
      Case "Sunday"
        mCode = mTSUI.GetTimeSheetEntryCode(6)
    End Select
    If mCode IsNot Nothing Then
      e.Appearance.BackColor = mCode.Colour
      If mCode.PropertyENUM = clsTimeSheetCode.cWorkOrder Then
        e.Appearance.Font = New Font("Arial", 8)
      End If
    End If


  End Sub

  Private Sub gvTimeSheet_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvTimeSheet.CellValueChanged
    gvTimeSheet.CloseEditor()
    gvTimeSheet.UpdateCurrentRow()
    gvTimeSheet.RefreshData()
  End Sub

  Private Sub radgrpWorkCentreID_EditValueChanged(sender As Object, e As EventArgs) Handles radgrpWorkCentreID.EditValueChanged
    pController.WorkCentreID = radgrpWorkCentreID.EditValue
  End Sub

End Class