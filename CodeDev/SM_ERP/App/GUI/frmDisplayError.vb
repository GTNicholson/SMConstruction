Imports RTIS.CommonVB

Public Class frmDisplayError
  ''Private pDisplayExceptionDelegate As dgDisplayException

  ''Delegate Sub dgDisplayException(ByRef rException As Exception)

  Public Shared Sub DisplayErrorDetails(ByRef rException As Exception, ByVal rContext As String)
    Dim mFrm As New frmDisplayError
    mFrm.Text = "Application Error"
    mFrm.lblErrorMessage.Text = rException.Message
    If rException.InnerException IsNot Nothing Then
      mFrm.textErrorDetails.Text = rException.Source & Environment.NewLine & rException.StackTrace & Environment.NewLine & Environment.NewLine & rException.InnerException.ToString
    Else
      mFrm.textErrorDetails.Text = rException.Source & Environment.NewLine & rException.StackTrace
    End If
    mFrm.lblContext.Text = rContext
    mFrm.ShowDialog()
    mFrm = Nothing
  End Sub

  Private Sub btnCopyToClipboard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopyToClipboard.Click
    Dim mCopyString As String
    mCopyString = lblContext.Text & Environment.NewLine
    mCopyString = mCopyString & lblErrorMessage.Text & Environment.NewLine
    mCopyString = mCopyString & textErrorDetails.Text
    Clipboard.SetDataObject(mCopyString, True)
  End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub

End Class