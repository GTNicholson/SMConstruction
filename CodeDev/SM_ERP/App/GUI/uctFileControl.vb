Imports RTIS.CommonVB
Imports System.IO
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid

Public Class uctFileControl

  Private WithEvents pUserController As uccFileControl

  Public Property UserController() As uccFileControl
    Get
      Return pUserController
    End Get
    Set(ByVal value As uccFileControl)
      pUserController = value
    End Set
  End Property

  Public Sub LoadControls()
    pUserController.SynchroniseFiles()
    grdFiles.DataSource = pUserController.FileTrackers
  End Sub

  Public Sub RefreshControls()
    gvFiles.RefreshData()
    bbtnOpenFolder.Caption = pUserController.Directory
  End Sub

  Public Sub UpdateObject()
  End Sub

  Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click

    Try
      Dim mFileTracker As dmFileTracker = gvFiles.GetFocusedRow
      Dim mFileName As String = mFileTracker.FileName

      If Not String.IsNullOrEmpty(mFileName) Then
        Dim mVal As clsValidate = pUserController.OpenFile(mFileName)

        If Not mVal.ValOk Then
          MsgBox(mVal.Msg)
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub UserController_RequestRefresh(sender As Object, e As EventArgs) Handles pUserController.RequestControlRefresh
    RefreshControls()
  End Sub

  Private Sub grdFiles_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles grdFiles.EmbeddedNavigator.ButtonClick
    Select Case e.Button.ButtonType
      Case DevExpress.XtraEditors.NavigatorButtonType.Append
        AddFile()
        e.Handled = True
      Case DevExpress.XtraEditors.NavigatorButtonType.Remove
        RemoveFile()
        e.Handled = True
    End Select
  End Sub

  Private Sub AddFile()
    Try
      Dim openFileDialog1 As New OpenFileDialog

      openFileDialog1.InitialDirectory = "c:\"
      openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
      openFileDialog1.FilterIndex = 2
      openFileDialog1.RestoreDirectory = True

      If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        Dim mFilePath As String = openFileDialog1.FileName

        If pUserController.FileAlreadyExists(mFilePath) Then

          If MsgBox("A file with this name already exists do you wish to override?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            pUserController.CopyFile(mFilePath)
          End If

        Else
          If pUserController.FileSystemWatcherEnabled Then
            pUserController.CopyFile(mFilePath)
          Else
            Dim mVal As clsValidate = pUserController.AddFile(mFilePath, True)

            If Not mVal.ValOk Then
              MsgBox(mVal.Msg)
            End If
          End If

        End If

        RefreshControls()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub RemoveFile()
    Try
      Dim mFileTracker As dmFileTracker = gvFiles.GetFocusedRow

      If mFileTracker IsNot Nothing Then

        If MsgBox("Deleting will also delete the attached file, do you wish to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
          pUserController.DeleteFile(mFileTracker.FileName)
        End If

        RefreshControls()
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnOpenFolder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnOpenFolder.ItemClick
    Try
      pUserController.OpenFolder()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  ''Private Sub gvFiles_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvFiles.CustomDrawCell
  ''  Try
  ''    Dim mFileTracker As dmFileTracker = gvFiles.GetRow(e.RowHandle)

  ''    If mFileTracker IsNot Nothing Then
  ''      If mFileTracker.LocationValidated Then
  ''        e.Appearance.BackColor = Color.Empty
  ''      Else
  ''        e.Appearance.BackColor = Color.Tomato
  ''      End If
  ''    End If

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''  End Try
  ''End Sub

  Private Sub barbtnSearchForNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSearch.ItemClick
    Try
      pUserController.SearchForNewFiles()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvFiles_ShownEditor(sender As Object, e As EventArgs) Handles gvFiles.ShownEditor
    Try
      Dim mView As DevExpress.XtraGrid.Views.Base.ColumnView = CType(sender, DevExpress.XtraGrid.Views.Base.ColumnView)

      If TypeOf (mView.ActiveEditor) Is DevExpress.XtraEditors.MemoExEdit Then
        Dim mEdit As DevExpress.XtraEditors.MemoExEdit = CType(mView.ActiveEditor, DevExpress.XtraEditors.MemoExEdit)
        mEdit.Properties.PopupFormMinSize = New Size(mEdit.Width, 0)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub grdFiles_DragEnter(sender As Object, e As DragEventArgs) Handles grdFiles.DragEnter
    If (e.Data.GetDataPresent("FileGroupDescriptor")) Or (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
      e.Effect = DragDropEffects.Copy
    End If
  End Sub

  Private Sub grdFiles_DragDrop(sender As Object, e As DragEventArgs) Handles grdFiles.DragDrop
    Try
      If e.Data.GetDataPresent(DataFormats.FileDrop) Then
        Dim mFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        For Each mLine As String In mFiles
          If IO.File.Exists(mLine) And Not pUserController.FileAlreadyExists(mLine) Then

            If pUserController.FileSystemWatcherEnabled Then
              pUserController.CopyFile(mLine)
            Else
              Dim mVal As clsValidate = pUserController.AddFile(mLine, True)
            End If

          End If
        Next

      End If

      If e.Data.GetDataPresent("FileGroupDescriptor") Then

        Dim mStream As Stream = CType(e.Data.GetData("FileGroupDescriptor"), Stream)

        Dim mFileGroupDescriptor(512) As Byte

        mStream.Read(mFileGroupDescriptor, 0, 512)

        Dim mStrBuilder As New System.Text.StringBuilder("")

        Dim mCount As Integer = 76

        While mFileGroupDescriptor(mCount) <> 0 And mCount < 513

          mStrBuilder.Append(Convert.ToChar(mFileGroupDescriptor(mCount)))

          mCount += 1
        End While

        mStream.Close()

        Dim mFilePath As String = IO.Path.Combine(pUserController.Directory, mStrBuilder.ToString())

        Dim mMem = CType(e.Data.GetData("FileContents", True), MemoryStream)

        Dim mFileContents(mMem.Length) As Byte

        mMem.Position = 0
        mMem.Read(mFileContents, 0, CInt(mMem.Length))

        Dim mFileStream As New FileStream(mFilePath, FileMode.Create)

        mFileStream.Write(mFileContents, 0, CInt(mMem.Length))

        mFileStream.Close()

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub

  Private Function GetNextFileName(ByVal vFileName As String) As String
    Dim mFileName As String = vFileName
    Dim mCount As Integer = 0

    While IO.File.Exists(mFileName)
      Dim mFilenameWithoutEx As String = IO.Path.GetFileNameWithoutExtension(vFileName)
      Dim mEx As String = IO.Path.GetExtension(vFileName)

      mCount += 1

      mFileName = String.Format("{0} ({1}){2}", mFilenameWithoutEx, mCount, mEx)

    End While

    Return mFileName
  End Function

  Private Sub gvFiles_ShowingEditor(sender As Object, e As CancelEventArgs) Handles gvFiles.ShowingEditor
    Dim mFile As dmFileTracker
    If gvFiles.FocusedColumn.FieldName = "IncludeInPack" Then
      mFile = TryCast(gvFiles.GetFocusedRow, dmFileTracker)
      If mFile IsNot Nothing Then
        If mFile.FileType IsNot Nothing Then
          If mFile.FileType.ToUpper = ".PDF" Then
            e.Cancel = False
          Else
            e.Cancel = True
          End If
        Else
          e.Cancel = True
        End If
      End If
    End If
  End Sub

  Private Sub gvFiles_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvFiles.RowCellStyle
    Dim mFileTracker As dmFileTracker
    Select Case e.Column.Name
      Case "gcIncludeInPack"
        mFileTracker = gvFiles.GetRow(e.RowHandle)
        If mFileTracker.LocationValidated And mFileTracker.FileType.ToString.ToUpper = ".PDF" Then
          e.Appearance.BackColor = Color.White
        Else
          e.Appearance.BackColor = Color.Lavender
        End If
    End Select
  End Sub

  Private Sub gvFiles_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gvFiles.RowStyle
    Try
      Dim mFileTracker As dmFileTracker = gvFiles.GetRow(e.RowHandle)

      If mFileTracker IsNot Nothing Then
        If mFileTracker.LocationValidated Then
          e.Appearance.BackColor = Color.Empty
        Else
          e.Appearance.BackColor = Color.Tomato
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  'Private Sub uctQuoteFileControl_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter

  'End Sub

  'Private Sub uctQuoteFileControl_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
  '  Dim file As String = e.Data. 'DataFormats.GetFormat(0).Name ' e.Data.GetData(DataFormats.GetFormat(0))
  '  'MsgBox(file)
  'End Sub


End Class
