<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrderMilestoneStatus
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
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.radgrpWOStatusSetting = New DevExpress.XtraEditors.RadioGroup()
    Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
    Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
    Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
    Me.dtePlannedDate = New DevExpress.XtraEditors.DateEdit()
    Me.dteActualDate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.radgrpWOStatusSetting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePlannedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePlannedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteActualDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteActualDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(419, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 14)
        Me.LabelControl2.TabIndex = 122
        Me.LabelControl2.Text = "Fecha Planificado"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(6, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 14)
        Me.LabelControl1.TabIndex = 121
        Me.LabelControl1.Text = "Estatus"
        '
        'radgrpWOStatusSetting
        '
        Me.radgrpWOStatusSetting.EditValue = 0
        Me.radgrpWOStatusSetting.Location = New System.Drawing.Point(72, 30)
        Me.radgrpWOStatusSetting.Name = "radgrpWOStatusSetting"
        Me.radgrpWOStatusSetting.Properties.AllowMouseWheel = False
        Me.radgrpWOStatusSetting.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radgrpWOStatusSetting.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radgrpWOStatusSetting.Properties.Appearance.Options.UseFont = True
        Me.radgrpWOStatusSetting.Properties.Appearance.Options.UseForeColor = True
        Me.radgrpWOStatusSetting.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "No Requerido"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "En Proceso"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Completo")})
        Me.radgrpWOStatusSetting.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.radgrpWOStatusSetting.Size = New System.Drawing.Size(328, 25)
        Me.radgrpWOStatusSetting.TabIndex = 120
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(426, 56)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(87, 14)
        Me.LabelControl21.TabIndex = 118
        Me.LabelControl21.Text = "Fecha Realizado"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(7, 63)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl22.TabIndex = 117
        Me.LabelControl22.Text = "Notas"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(7, 79)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(606, 75)
        Me.txtNotes.TabIndex = 116
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseForeColor = True
        Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitle.Location = New System.Drawing.Point(7, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(475, 23)
        Me.lblTitle.TabIndex = 115
        Me.lblTitle.Text = "Estatus para O.T. :"
        '
        'dtePlannedDate
        '
        Me.dtePlannedDate.EditValue = Nothing
        Me.dtePlannedDate.Location = New System.Drawing.Point(519, 27)
        Me.dtePlannedDate.Name = "dtePlannedDate"
        Me.dtePlannedDate.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dtePlannedDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePlannedDate.Properties.Appearance.Options.UseBackColor = True
        Me.dtePlannedDate.Properties.Appearance.Options.UseFont = True
        Me.dtePlannedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePlannedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePlannedDate.Properties.DisplayFormat.FormatString = ""
        Me.dtePlannedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtePlannedDate.Properties.EditFormat.FormatString = ""
        Me.dtePlannedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtePlannedDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtePlannedDate.Properties.NullDate = New Date(CType(0, Long))
        Me.dtePlannedDate.Size = New System.Drawing.Size(94, 20)
        Me.dtePlannedDate.TabIndex = 123
        '
        'dteActualDate
        '
        Me.dteActualDate.EditValue = Nothing
        Me.dteActualDate.Location = New System.Drawing.Point(519, 53)
        Me.dteActualDate.Name = "dteActualDate"
        Me.dteActualDate.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteActualDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteActualDate.Properties.Appearance.Options.UseBackColor = True
        Me.dteActualDate.Properties.Appearance.Options.UseFont = True
        Me.dteActualDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteActualDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteActualDate.Properties.DisplayFormat.FormatString = ""
        Me.dteActualDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteActualDate.Properties.EditFormat.FormatString = ""
        Me.dteActualDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteActualDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteActualDate.Properties.NullDate = New Date(CType(0, Long))
        Me.dteActualDate.Size = New System.Drawing.Size(94, 20)
        Me.dteActualDate.TabIndex = 119
        '
        'frmWorkOrderMilestoneStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 163)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.radgrpWOStatusSetting)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dtePlannedDate)
        Me.Controls.Add(Me.dteActualDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkOrderMilestoneStatus"
        Me.Text = "Estatus de Orden de Trabajo"
        CType(Me.radgrpWOStatusSetting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePlannedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePlannedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteActualDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteActualDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents radgrpWOStatusSetting As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
  Friend WithEvents dtePlannedDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents dteActualDate As DevExpress.XtraEditors.DateEdit
End Class
