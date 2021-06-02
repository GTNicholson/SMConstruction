<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewStockItemProv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewStockItemProv))
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bbtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAccept = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboUoM = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUoM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(99, 9)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(265, 20)
        Me.txtDescription.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 14)
        Me.LabelControl2.TabIndex = 136
        Me.LabelControl2.Text = "Descripción"
        '
        'cboCategory
        '
        Me.cboCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCategory.Location = New System.Drawing.Point(99, 39)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboCategory.Properties.Appearance.Options.UseFont = True
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Size = New System.Drawing.Size(127, 20)
        Me.cboCategory.TabIndex = 137
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl1.TabIndex = 138
        Me.LabelControl1.Text = "Categoría"
        '
        'bbtnCancel
        '
        Me.bbtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bbtnCancel.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bbtnCancel.Appearance.Options.UseFont = True
        Me.bbtnCancel.Location = New System.Drawing.Point(289, 104)
        Me.bbtnCancel.Name = "bbtnCancel"
        Me.bbtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.bbtnCancel.TabIndex = 139
        Me.bbtnCancel.Text = "Cancelar"
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAccept.Appearance.Options.UseFont = True
        Me.btnAccept.Location = New System.Drawing.Point(208, 104)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 140
        Me.btnAccept.Text = "Aceptar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 68)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 14)
        Me.LabelControl3.TabIndex = 142
        Me.LabelControl3.Text = "UdM"
        '
        'cboUoM
        '
        Me.cboUoM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUoM.Location = New System.Drawing.Point(99, 65)
        Me.cboUoM.Name = "cboUoM"
        Me.cboUoM.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboUoM.Properties.Appearance.Options.UseFont = True
        Me.cboUoM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUoM.Size = New System.Drawing.Size(127, 20)
        Me.cboUoM.TabIndex = 141
        '
        'frmNewStockItemProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 132)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cboUoM)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.bbtnCancel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDescription)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewStockItemProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Item Provisional"
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUoM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAccept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUoM As DevExpress.XtraEditors.ComboBoxEdit
End Class
