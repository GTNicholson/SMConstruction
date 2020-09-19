<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayError
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayError))
    Me.textErrorDetails = New System.Windows.Forms.TextBox()
    Me.btnCopyToClipboard = New System.Windows.Forms.Button()
    Me.lblContext = New System.Windows.Forms.Label()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.lblErrorMessage = New System.Windows.Forms.TextBox()
    Me.btnInformrealtime = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'textErrorDetails
    '
    Me.textErrorDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.textErrorDetails.BackColor = System.Drawing.Color.White
    Me.textErrorDetails.Location = New System.Drawing.Point(12, 127)
    Me.textErrorDetails.Multiline = True
    Me.textErrorDetails.Name = "textErrorDetails"
    Me.textErrorDetails.ReadOnly = True
    Me.textErrorDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.textErrorDetails.Size = New System.Drawing.Size(667, 224)
    Me.textErrorDetails.TabIndex = 1
    '
    'btnCopyToClipboard
    '
    Me.btnCopyToClipboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnCopyToClipboard.Location = New System.Drawing.Point(12, 357)
    Me.btnCopyToClipboard.Name = "btnCopyToClipboard"
    Me.btnCopyToClipboard.Size = New System.Drawing.Size(106, 22)
    Me.btnCopyToClipboard.TabIndex = 2
    Me.btnCopyToClipboard.Text = "Copiar el Error"
    Me.btnCopyToClipboard.UseVisualStyleBackColor = True
    '
    'lblContext
    '
    Me.lblContext.AutoSize = True
    Me.lblContext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblContext.ForeColor = System.Drawing.Color.Gainsboro
    Me.lblContext.Location = New System.Drawing.Point(12, 9)
    Me.lblContext.Name = "lblContext"
    Me.lblContext.Size = New System.Drawing.Size(49, 16)
    Me.lblContext.TabIndex = 3
    Me.lblContext.Text = "Label2"
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnClose.Location = New System.Drawing.Point(573, 357)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(106, 22)
    Me.btnClose.TabIndex = 4
    Me.btnClose.Text = "OK"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'lblErrorMessage
    '
    Me.lblErrorMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblErrorMessage.BackColor = System.Drawing.Color.White
    Me.lblErrorMessage.Location = New System.Drawing.Point(12, 44)
    Me.lblErrorMessage.Multiline = True
    Me.lblErrorMessage.Name = "lblErrorMessage"
    Me.lblErrorMessage.ReadOnly = True
    Me.lblErrorMessage.Size = New System.Drawing.Size(667, 64)
    Me.lblErrorMessage.TabIndex = 5
    '
    'btnInformrealtime
    '
    Me.btnInformrealtime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnInformrealtime.Location = New System.Drawing.Point(296, 357)
    Me.btnInformrealtime.Name = "btnInformrealtime"
    Me.btnInformrealtime.Size = New System.Drawing.Size(122, 21)
    Me.btnInformrealtime.TabIndex = 6
    Me.btnInformrealtime.Text = "Informar a Realtime"
    Me.btnInformrealtime.UseVisualStyleBackColor = True
    Me.btnInformrealtime.Visible = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
    Me.Label1.Location = New System.Drawing.Point(12, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 13)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Mensaje de Error"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
    Me.Label2.Location = New System.Drawing.Point(12, 111)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(55, 13)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Call Stack"
    '
    'frmDisplayError
    '
    Me.AcceptButton = Me.btnClose
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Teal
    Me.ClientSize = New System.Drawing.Size(691, 383)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnInformrealtime)
    Me.Controls.Add(Me.lblErrorMessage)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.lblContext)
    Me.Controls.Add(Me.btnCopyToClipboard)
    Me.Controls.Add(Me.textErrorDetails)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmDisplayError"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Problema de la Aplicación"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents textErrorDetails As System.Windows.Forms.TextBox
  Friend WithEvents btnCopyToClipboard As System.Windows.Forms.Button
  Friend WithEvents lblContext As System.Windows.Forms.Label
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents lblErrorMessage As System.Windows.Forms.TextBox
  Friend WithEvents btnInformrealtime As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
