Public NotInheritable Class frmRTISSplash

  Private Sub frmRTISSplash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.Escape Then
      Me.Close()
    End If
  End Sub


  'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
  '  of the Project Designer ("Properties" under the "Project" menu).

  Private Sub frmRTISSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Set up the dialog text at runtime according to the application's assembly information.  
    Dim mCLOption As String = ""
    'TODO: Customize the application's assembly information in the "Application" pane of the project 
    '  properties dialog (under the "Project" menu).
    Dim mRect As System.Drawing.Rectangle

    'Application title
    ''mCLOption = "" 'My.Application.RTISGlobal.AppTitle
    If My.Application.CommandLineArgs.Count > 0 Then
      mCLOption = RTIS.CommonVB.clsRTISVersionUpdate.GetCommandLineParam(My.Application.CommandLineArgs, appInit.cCLP_AppSuffix) & ""
      ' mCLOption = My.Application.CommandLineArgs(0)
      ''If mCLOption.Trim.Length > 0 Then

      ''  If InStr(mCLOption, RTIS.CommonVB.clsRTISVersionUpdate.cUpdateCommandLineKey) > 0 Or InStr(mCLOption, RTIS.CommonVB.clsRTISVersionUpdate.cUpdateMessagesCommandLineKey) > 0 Then
      ''    mCLOption = ""
      ''  End If

      ''End If
    End If
    If My.Application.Info.Title <> "" Then
      If Not String.IsNullOrEmpty(mCLOption) Then
        ApplicationTitle.Text = My.Application.Info.Title & " (" & mCLOption & ")"
      Else
        ApplicationTitle.Text = My.Application.Info.Title
      End If
    Else
      'If the application title is missing, use the application name, without the extension
      ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
    End If
    mRect = My.Computer.Screen.Bounds
    Me.Left = CInt((mRect.Width - Me.Width) / 2)
    Me.Top = 100

    'Format the version information using the text set into the Version control at design time as the
    '  formatting string.  This allows for effective localization if desired.
    '  Build and revision information could be included by using the following code and changing the 
    '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
    '  String.Format() in Help for more information.
    '
    '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

    'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Revision)
    Version.Text = "Version: " & My.Application.Info.Version.ToString()
    'Copyright info
    Copyright.Text = My.Application.Info.Copyright
    'ebug.Print("Splash Load End")

  End Sub


  Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    Me.Close()
  End Sub

  Private Sub ApplicationTitle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationTitle.Click
    Me.Close()
  End Sub

  Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click
    Me.Close()
  End Sub

  Private Sub Copyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copyright.Click
    Me.Close()
  End Sub

  Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    Me.Close()
  End Sub

  Private Sub frmRTISSplash_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
    Me.Close()
  End Sub
End Class
