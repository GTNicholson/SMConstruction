Imports RTIS.CommonVB

Public Class frmWorkOrderTracking
  Private pController As fccWorkOrderTracking

  Public Shared Sub OpenFormMDI(ByRef rMDI As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mfrm As frmWorkOrderTracking
    mfrm = New frmWorkOrderTracking
    mfrm.pController = New fccWorkOrderTracking(rDBConn)
    mfrm.MdiParent = rMDI
    mfrm.Show()
  End Sub

  Private Sub frmWorkOrderTracking_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mMsg As String
    Dim mOK As Boolean
    Dim mErrorDisplayed As Boolean
    Try

      pController.LoadObjects()
      grdWorksOrders.DataSource = pController.WorkOrderTrackings
      mOK = True

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


  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub
End Class