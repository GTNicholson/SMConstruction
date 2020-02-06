Public Class frmIssueInventory
  Public Property SelectedDate As DateTime
  Public Property Notes As String
  Public Property ReferenceNo As Decimal

  Private Sub frmIssueInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
    datSelectedDate.DateTime = DateTime.Today
    txtRequisaNo.EditValue = 0

  End Sub

  Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
    Me.SelectedDate = datSelectedDate.DateTime
    Me.Notes = memNotes.Text
    Me.ReferenceNo = txtRequisaNo.EditValue
    Me.DialogResult = DialogResult.OK
    Me.Close()
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.SelectedDate = DateTime.MinValue
    Me.Notes = String.Empty
    Me.ReferenceNo = 0

    Me.DialogResult = DialogResult.Cancel
    Me.Close()
  End Sub
End Class