Imports System.ComponentModel
Imports RTIS.CommonVB

Public Class frmWorkOrderMilestoneStatus
  Private pController As fccWorkOrderMilestoneStatus
  Public Shared Sub OpenForm(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus)
    Dim mfrm As frmWorkOrderMilestoneStatus

    mfrm = New frmWorkOrderMilestoneStatus
    mfrm.StartPosition = FormStartPosition.CenterParent

    mfrm.pController = New fccWorkOrderMilestoneStatus(rDBConn, rWorkOrderMilestoneStatus)
    mfrm.ShowDialog(rParentForm)


  End Sub

  Private Sub frmWorkOrderMilestoneStatus_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Try
      UpdateObject()
      pController.SaveObject()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub frmWorkOrderMilestoneStatus_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mMsg As String
    Dim mOK As Boolean
    Dim mErrorDisplayed As Boolean
    Try


      RefreshControls()

      mOK = True

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

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub RefreshControls()
    Try
      With pController.WorkOrderMilestoneStatus
        radgrpWOStatusSetting.EditValue = CInt(.Status)

        dtePlannedDate.EditValue = .TargetDate
        dteActualDate.DateTime = .ActualDate
        txtNotes.Text = .Notes
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub UpdateObject()
    Try
      With pController.WorkOrderMilestoneStatus
        .Status = radgrpWOStatusSetting.EditValue
        .TargetDate = dtePlannedDate.DateTime
        .ActualDate = dteActualDate.DateTime
        .Notes = txtNotes.Text
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

End Class