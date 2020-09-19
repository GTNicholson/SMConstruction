<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRTISSplash
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRTISSplash))
    Me.Version = New System.Windows.Forms.Label()
    Me.Copyright = New System.Windows.Forms.Label()
    Me.ApplicationTitle = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Version
    '
    Me.Version.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Version.BackColor = System.Drawing.Color.Transparent
    Me.Version.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Version.Location = New System.Drawing.Point(12, 290)
    Me.Version.Name = "Version"
    Me.Version.Size = New System.Drawing.Size(202, 20)
    Me.Version.TabIndex = 9
    Me.Version.Text = "Version {0}.{1:00}.{0}"
    '
    'Copyright
    '
    Me.Copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Copyright.BackColor = System.Drawing.Color.Transparent
    Me.Copyright.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Copyright.Location = New System.Drawing.Point(220, 290)
    Me.Copyright.Name = "Copyright"
    Me.Copyright.Size = New System.Drawing.Size(258, 20)
    Me.Copyright.TabIndex = 10
    Me.Copyright.Text = "2013"
    '
    'ApplicationTitle
    '
    Me.ApplicationTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
    Me.ApplicationTitle.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ApplicationTitle.Location = New System.Drawing.Point(9, 254)
    Me.ApplicationTitle.Name = "ApplicationTitle"
    Me.ApplicationTitle.Size = New System.Drawing.Size(474, 36)
    Me.ApplicationTitle.TabIndex = 8
    Me.ApplicationTitle.Text = "Application"
    Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(10, 0)
    Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(204, 68)
    Me.PictureBox1.TabIndex = 7
    Me.PictureBox1.TabStop = False
    '
    'PictureBox2
    '
    Me.PictureBox2.Enabled = False
    Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
    Me.PictureBox2.InitialImage = Nothing
    Me.PictureBox2.Location = New System.Drawing.Point(0, 68)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(500, 183)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.PictureBox2.TabIndex = 11
    Me.PictureBox2.TabStop = False
    '
    'frmRTISSplash
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(498, 319)
    Me.ControlBox = False
    Me.Controls.Add(Me.PictureBox2)
    Me.Controls.Add(Me.Version)
    Me.Controls.Add(Me.Copyright)
    Me.Controls.Add(Me.ApplicationTitle)
    Me.Controls.Add(Me.PictureBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmRTISSplash"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.TopMost = True
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Version As System.Windows.Forms.Label
  Friend WithEvents Copyright As System.Windows.Forms.Label
  Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
