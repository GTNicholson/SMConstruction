Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
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
      If pController.DBConn.RTISUser.IsSecurityAllowAll = False Then
        XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
      End If

      pController.SetInitialDefaultValues()
      pController.LoadTimeSheetEntrys()
      pController.LoadTimeSheetEntryUIs()
      grdTimeSheet.DataSource = pController.TimeSheetEntryUIs
      grdTimeSheetEntries.DataSource = pController.TimeSheetEntrys
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
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
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
    timTimeStart.EditValue = New Date(1, 1, 1, pController.StartTime.Hour, pController.StartTime.Minute, pController.StartTime.Second)
    timTimeEnd.EditValue = New Date(1, 1, 1, pController.EndTime.Hour, pController.EndTime.Minute, pController.EndTime.Second)
    radgrpWorkCentreID.EditValue = pController.WorkCentreID
  End Sub

  Private Sub UpdateObjects()
    Dim mTime As DateTime
    pController.WCDate = datWeekCommencing.DateTime.Date
    mTime = New Date
    mTime = mTime.AddHours(timTimeStart.Time.Hour)
    mTime = mTime.AddMinutes(timTimeStart.Time.Minute)
    mTime = mTime.AddSeconds(timTimeStart.Time.Second)
    pController.StartTime = mTime
    mTime = New Date
    mTime = mTime.AddHours(timTimeEnd.Time.Hour)
    mTime = mTime.AddMinutes(timTimeEnd.Time.Minute)
    mTime = mTime.AddSeconds(timTimeEnd.Time.Second)
    pController.EndTime = mTime

  End Sub

  Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    Try

      UpdateObjects()

      pController.LoadTimeSheetEntrys()
      pController.LoadTimeSheetEntryUIs()
      grdTimeSheet.DataSource = pController.TimeSheetEntryUIs
      grdTimeSheetEntries.DataSource = pController.TimeSheetEntrys
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


      UpdateObjects()
      pController.SetCurrentEmployee(clsDEControlLoading.GetDEComboValue(cboEmployee))
      pController.LoadTimeSheetEntrys()
      pController.LoadTimeSheetEntryUIs()
      grdTimeSheet.DataSource = pController.TimeSheetEntryUIs
      grdTimeSheetEntries.DataSource = pController.TimeSheetEntrys

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

  Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
    gvTimeSheetEntries.RefreshData()
  End Sub

  Private Sub cboEmployee_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboEmployee.Validating

  End Sub



  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObjects()
    'pFormController.SaveObjects()
    If pController.IsDirty() Then
      If rOption Then
        mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
        Select Case mResponse
          Case MsgBoxResult.Yes
            mSaveRequired = True
            mRetVal = False

          Case MsgBoxResult.No
            mSaveRequired = False
            mRetVal = True

          Case MsgBoxResult.Cancel
            mSaveRequired = False
            mRetVal = False
        End Select
      Else

        mSaveRequired = True
        mRetVal = False
      End If
    Else

      mSaveRequired = False
      mRetVal = True
    End If

    If mSaveRequired Then

      pController.SaveTimeSheetEntrys()
      mRetVal = True

    End If
    CheckSave = mRetVal

    ''If mSaveRequired Then
    ''  ''Dim mValidate As clsValidate
    ''  ''mValidate = pFormController.ValidateObject
    ''  ''If mValidate.ValOk Then
    ''  pFormController.SaveObjects()
    ''  ''Else
    ''  '' MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
    ''  ''mRetVal = False
    ''  ''End If
    ''End If
    ''CheckSave = mRetVal
  End Function

  Private Sub cboEmployee_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles cboEmployee.EditValueChanging
    Try

      If CheckSave(True) Then
      Else
        cboEmployee.EditValue = e.OldValue
        e.Cancel = True
        cboEmployee.Refresh()
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub gpTimeSheetEntries_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gpTimeSheetEntries.CustomButtonClick
    Dim mShift As dmShift
    Dim mShifts As colShifts
    mShifts = AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Shift)
    mShift = mShifts(0)

    For Each mTSE As dmTimeSheetEntry In pController.TimeSheetEntrys
      mTSE.OverTimeMinutes = clsTimeSheetSharedFuncs.getOverTimeMinutes(mTSE, mShift)
    Next
    gvTimeSheetEntries.RefreshData()
  End Sub
End Class