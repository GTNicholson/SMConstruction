Imports RTIS.CommonVB


Public Class frmSalesOrderPhasePicker

  Private pPicker As clsPickerSalesOrderPhase


  Public Shared Function OpenPickerSingle(ByVal vSalesOrderPhasePicker As clsPickerSalesOrderPhase) As clsSalesOrderPhaseInfo
    Dim mfrm As New frmSalesOrderPhasePicker
    Dim mRetVal As clsSalesOrderPhaseInfo = Nothing

    mfrm.pPicker = vSalesOrderPhasePicker
    mfrm.ShowDialog()

    If mfrm.pPicker.SelectedObjects IsNot Nothing AndAlso mfrm.pPicker.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPicker.SelectedObjects(0)
    End If

    mfrm.Dispose()
    mfrm = Nothing

    Return mRetVal
  End Function

  Private Sub frmPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try

      RefreshControls()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema cargando el formulario... Por favor, intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub RefreshControls()
    grdSalesOrderPhases.DataSource = pPicker.DataSource
  End Sub

  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepbtnSelect.ButtonClick
    Try
      Dim mItem As clsSalesOrderPhaseInfo
      mItem = TryCast(gvSalesOrderPhase.GetFocusedRow, clsSalesOrderPhaseInfo)
      If mItem IsNot Nothing Then
        pPicker.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class