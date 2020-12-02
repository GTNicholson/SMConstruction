<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovementTransaction
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLocations = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnProcessMovement = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cboLocations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mover Hacia: "
        '
        'cboLocations
        '
        Me.cboLocations.Location = New System.Drawing.Point(113, 19)
        Me.cboLocations.Name = "cboLocations"
        Me.cboLocations.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboLocations.Properties.Appearance.Options.UseFont = True
        Me.cboLocations.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLocations.Size = New System.Drawing.Size(178, 20)
        Me.cboLocations.TabIndex = 1
        '
        'btnProcessMovement
        '
        Me.btnProcessMovement.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnProcessMovement.Appearance.Options.UseFont = True
        Me.btnProcessMovement.Location = New System.Drawing.Point(23, 51)
        Me.btnProcessMovement.Name = "btnProcessMovement"
        Me.btnProcessMovement.Size = New System.Drawing.Size(75, 23)
        Me.btnProcessMovement.TabIndex = 11
        Me.btnProcessMovement.Text = "Procesar"
        '
        'frmMovementTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 86)
        Me.Controls.Add(Me.btnProcessMovement)
        Me.Controls.Add(Me.cboLocations)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmMovementTransaction"
        Me.Text = "Movimiento de Inventario de Madera"
        CType(Me.cboLocations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLocations As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnProcessMovement As DevExpress.XtraEditors.SimpleButton
End Class
