Imports RTIS.CommonVB

Public Class frmPDFViewer
  Public ExitMode As eFormMode
  Private pFileName As String
  Private pStream As System.IO.MemoryStream

  Private pIsActive As Boolean
  Private pLoadError As Boolean

  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByVal vFileName As String)
    Dim mfrm As frmPDFViewer = Nothing

    If mfrm Is Nothing Then
      'mfrm = OpenForm(vFileName)
      mfrm = New frmPDFViewer
      mfrm.pFileName = vFileName
      mfrm.MdiParent = rParentForm
      mfrm.Show()
    Else
      'bring to the front
      mfrm.pFileName = vFileName
      mfrm.Focus()
    End If
  End Sub

  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByVal vFileName As String)
    Dim mfrm As frmPDFViewer

    'mfrm = OpenForm(vFileName)
    mfrm = New frmPDFViewer
    mfrm.Owner = rParentForm
    mfrm.pFileName = vFileName
    mfrm.ShowDialog()

    mfrm.Close()
    mfrm.Dispose()
    mfrm = Nothing

  End Sub

  Public Shared Sub OpenFormAsModal(ByRef rParentForm As Windows.Forms.Form, ByVal vStream As System.IO.MemoryStream)
    Dim mfrm As frmPDFViewer

    'mfrm = OpenForm(vFileName)
    mfrm = New frmPDFViewer
    mfrm.Owner = rParentForm
    mfrm.pStream = vStream
    mfrm.ShowDialog()

    mfrm.Close()
    mfrm.Dispose()
    mfrm = Nothing

  End Sub

  Private Shared Function OpenForm(ByVal vFileName As String) As frmPDFViewer
    Dim mfrm As frmPDFViewer

    mfrm = New frmPDFViewer()

    Return mfrm
  End Function

  Private Sub frmPDFViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""

    ''  Dim mColSQItemRefs As colSalesItemRefs

    pIsActive = False
    pLoadError = False

    Try

      If pStream IsNot Nothing Then
        PdfViewer1.LoadDocument(pStream)
      Else
        PdfViewer1.LoadDocument(pFileName)
        Me.Text = System.IO.Path.GetFileName(pFileName)
      End If

    Catch ex As Exception
      mOK = False

    End Try

    If Not mOK Then
      MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True
  End Sub

  Private Sub CloseForm()

  End Sub

  Private Sub barbtSaveAs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtSaveAs.ItemClick
    Dim mFileName As String
    Dim mPath As String

    Try
      mFileName = System.IO.Path.GetFileName(pFileName)

      mPath = IO.Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), mFileName)
      RTIS.CommonVB.clsGeneralA.GetSaveFileName(mPath,,, "PDF (*.pdf)|*.pdf|All Files (*.*)|*.*",)

      If IO.Path.GetExtension(mPath) = "" Then
        mPath &= ".pdf"
      End If

      System.IO.File.Copy(pFileName, mPath)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class