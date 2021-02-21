Public Class frmStockAdjust


  Public Property TransactionType As eTransactionType
  Public Property SelectedDate As DateTime
  Public Property Notes As String
  Public Property SelectedQty As Decimal
  Public Property CurrentExchangeRate As Decimal


  Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
    Me.SelectedDate = datSelectedDate.DateTime + datSelectedTime.Time.TimeOfDay
    Me.Notes = memNotes.Text
    Me.SelectedQty = spnStockAdjustQty.EditValue
    Select Case radgrpStockAdjustType.EditValue
      Case 1
        TransactionType = eTransactionType.Adjustment
      Case 2
        TransactionType = eTransactionType.Amendment
    End Select

    Me.DialogResult = DialogResult.OK
    Me.Close()
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.SelectedDate = DateTime.MinValue
    Me.Notes = String.Empty
    Me.SelectedQty = 0

    Me.DialogResult = DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub frmStockAdjust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    radgrpStockAdjustType.EditValue = CInt(1)
    datSelectedDate.DateTime = DateTime.Today
    datSelectedTime.Time = DateTime.Now
  End Sub

  Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

  End Sub
End Class