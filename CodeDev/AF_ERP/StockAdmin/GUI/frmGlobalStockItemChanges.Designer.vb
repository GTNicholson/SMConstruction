<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGlobalStockItemChanges
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.bbtnApplyChanges = New DevExpress.XtraEditors.SimpleButton()
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.cboUoM = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.cboCategory = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.cboSpecies = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.cboItemType = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.cboUoM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboSpecies.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.cboItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'bbtnApplyChanges
    '
    Me.bbtnApplyChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.bbtnApplyChanges.Location = New System.Drawing.Point(211, 175)
    Me.bbtnApplyChanges.Name = "bbtnApplyChanges"
    Me.bbtnApplyChanges.Size = New System.Drawing.Size(88, 23)
    Me.bbtnApplyChanges.TabIndex = 1
    Me.bbtnApplyChanges.Text = "Aplicar Cambios"
    '
    'GroupControl2
    '
    Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.Maroon
    Me.GroupControl2.Appearance.Options.UseBackColor = True
    Me.GroupControl2.AppearanceCaption.BackColor = System.Drawing.SystemColors.Control
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
    Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl2.AppearanceCaption.Options.UseBackColor = True
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl2.Controls.Add(Me.cboItemType)
    Me.GroupControl2.Controls.Add(Me.LabelControl4)
    Me.GroupControl2.Controls.Add(Me.cboUoM)
    Me.GroupControl2.Controls.Add(Me.LabelControl3)
    Me.GroupControl2.Controls.Add(Me.cboCategory)
    Me.GroupControl2.Controls.Add(Me.LabelControl2)
    Me.GroupControl2.Controls.Add(Me.cboSpecies)
    Me.GroupControl2.Controls.Add(Me.LabelControl1)
    Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(292, 160)
    Me.GroupControl2.TabIndex = 2
    Me.GroupControl2.Text = "Cambios Globales a Madera"
    '
    'cboUoM
    '
    Me.cboUoM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboUoM.Location = New System.Drawing.Point(78, 109)
    Me.cboUoM.Name = "cboUoM"
    Me.cboUoM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboUoM.Size = New System.Drawing.Size(209, 20)
    Me.cboUoM.TabIndex = 5
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Appearance.Options.UseForeColor = True
    Me.LabelControl3.Location = New System.Drawing.Point(14, 112)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(24, 14)
    Me.LabelControl3.TabIndex = 4
    Me.LabelControl3.Text = "UdM"
    '
    'cboCategory
    '
    Me.cboCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboCategory.Location = New System.Drawing.Point(78, 25)
    Me.cboCategory.Name = "cboCategory"
    Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboCategory.Size = New System.Drawing.Size(209, 20)
    Me.cboCategory.TabIndex = 3
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Appearance.Options.UseForeColor = True
    Me.LabelControl2.Location = New System.Drawing.Point(14, 28)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(53, 14)
    Me.LabelControl2.TabIndex = 2
    Me.LabelControl2.Text = "Categoría"
    '
    'cboSpecies
    '
    Me.cboSpecies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboSpecies.Location = New System.Drawing.Point(78, 81)
    Me.cboSpecies.Name = "cboSpecies"
    Me.cboSpecies.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboSpecies.Size = New System.Drawing.Size(209, 20)
    Me.cboSpecies.TabIndex = 1
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(14, 84)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(50, 14)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "Especies"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.GroupControl2, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 3)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(298, 166)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'cboItemType
    '
    Me.cboItemType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboItemType.Location = New System.Drawing.Point(97, 53)
    Me.cboItemType.Name = "cboItemType"
    Me.cboItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboItemType.Size = New System.Drawing.Size(190, 20)
    Me.cboItemType.TabIndex = 7
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl4.Appearance.Options.UseFont = True
    Me.LabelControl4.Appearance.Options.UseForeColor = True
    Me.LabelControl4.Location = New System.Drawing.Point(14, 56)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(77, 14)
    Me.LabelControl4.TabIndex = 6
    Me.LabelControl4.Text = "Tipo Producto"
    '
    'frmGlobalStockItemChanges
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(314, 210)
    Me.Controls.Add(Me.bbtnApplyChanges)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmGlobalStockItemChanges"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Cambios Globales"
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    Me.GroupControl2.PerformLayout()
    CType(Me.cboUoM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboSpecies.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.cboItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents bbtnApplyChanges As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents cboSpecies As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents cboUoM As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboCategory As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboItemType As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
