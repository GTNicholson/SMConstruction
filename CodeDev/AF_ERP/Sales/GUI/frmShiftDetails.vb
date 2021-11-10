Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmShiftDetails
  Private pFormController As fccShiftDetails
  Private Shared sSingleInstance As frmShiftDetails
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer


  Public Property FormController As fccShiftDetails
    Get
      Return pFormController
    End Get
    Set(value As fccShiftDetails)
      pFormController = value
    End Set
  End Property
  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mfrm As New frmShiftDetails
    If sSingleInstance Is Nothing Then
      mfrm.FormController = New fccShiftDetails(rDBConn)
      mfrm.FormController.DBConn = rDBConn
      mfrm.Owner = rParentForm
      sSingleInstance = mfrm
    End If
    sSingleInstance.Show()
    sSingleInstance.WindowState = FormWindowState.Normal
  End Sub


  Private Sub frmShiftDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    pFormController.LoadObject()
    grdShiftDetails.DataSource = pFormController.ShiftDetails

  End Sub

  Private Sub frmShiftDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    pFormController = Nothing
    sSingleInstance = Nothing

    Me.Dispose()

  End Sub

  Private Sub gvShiftDetails_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvShiftDetails.CustomUnboundColumnData
    Dim mRow As dmShiftDetails
    Try

      mRow = TryCast(e.Row, dmShiftDetails)

      If mRow IsNot Nothing Then

        Select Case e.Column.Name
          Case gcDayWeek.Name

            If e.IsGetData Then
              Dim mRetVal As String = ""
              mRetVal = DateAndTime.WeekdayName(mRow.DayOfWeek, False, FirstDayOfWeek.Monday)

              e.Value = mRetVal

            End If

            If e.IsSetData Then

            End If

        End Select

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub frmShiftDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    gvShiftDetails.CloseEditForm()


    pFormController.SaveObjects()

  End Sub
End Class