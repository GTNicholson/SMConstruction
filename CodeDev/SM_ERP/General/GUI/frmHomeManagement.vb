Imports RTIS.DataLayer

Public Class frmHomeManagement

  Private pFormController As fccHomeManagement
  Private Shared sActiveForms As Collection

  Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

  End Sub

  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByRef rUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmHomeManagement = Nothing
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    '' Add code here if need to check if a Detail Form for this ID is already open
    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmHomeManagement
      mfrm.pFormController = New fccHomeManagement
      mfrm.pFormController.DBConn = rUserSession.CreateMainDBConn
      mfrm.pFormController.RTISGlobal = rRTISGlobal

      mfrm.MdiParent = rParentForm 'My.Application.MenuMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmHomeManagement
    Dim mfrmWanted As frmHomeManagement = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmHomeManagement
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmHomeManagement Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function
End Class