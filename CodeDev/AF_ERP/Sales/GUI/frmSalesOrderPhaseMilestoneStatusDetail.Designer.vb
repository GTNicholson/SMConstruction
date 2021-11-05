<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesOrderPhaseMilestoneStatusDetail
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrderPhaseMilestoneStatusDetail))
    Me.radgrpPUStatusSetting = New DevExpress.XtraEditors.RadioGroup()
    Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
    Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
    Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.dtePlannedDate = New DevExpress.XtraEditors.DateEdit()
    Me.dteActualDate = New DevExpress.XtraEditors.DateEdit()
    Me.bbtnUpdateInCascade = New DevExpress.XtraEditors.SimpleButton()
        Me.lblStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.dteStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtReqManDays = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.radgrpPUStatusSetting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePlannedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePlannedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteActualDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteActualDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqManDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radgrpPUStatusSetting
        '
        Me.radgrpPUStatusSetting.EditValue = 0
        Me.radgrpPUStatusSetting.Location = New System.Drawing.Point(110, 32)
        Me.radgrpPUStatusSetting.Name = "radgrpPUStatusSetting"
        Me.radgrpPUStatusSetting.Properties.AllowMouseWheel = False
        Me.radgrpPUStatusSetting.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radgrpPUStatusSetting.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radgrpPUStatusSetting.Properties.Appearance.Options.UseFont = True
        Me.radgrpPUStatusSetting.Properties.Appearance.Options.UseForeColor = True
        Me.radgrpPUStatusSetting.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "No Requerido"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Parte Completado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Completo")})
        Me.radgrpPUStatusSetting.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.radgrpPUStatusSetting.Size = New System.Drawing.Size(362, 25)
        Me.radgrpPUStatusSetting.TabIndex = 107
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(500, 90)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(101, 14)
        Me.LabelControl21.TabIndex = 105
        Me.LabelControl21.Text = "Fecha Completada"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(12, 120)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl22.TabIndex = 104
        Me.LabelControl22.Text = "Notas"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(12, 140)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(695, 86)
        Me.txtNotes.TabIndex = 102
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
        Me.lblTitle.Location = New System.Drawing.Point(12, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(706, 23)
        Me.lblTitle.TabIndex = 101
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 14)
        Me.LabelControl1.TabIndex = 112
        Me.LabelControl1.Text = "Estatus de Etapa"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(500, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 14)
        Me.LabelControl2.TabIndex = 113
        Me.LabelControl2.Text = "Fecha Planificada"
        '
        'dtePlannedDate
        '
        Me.dtePlannedDate.EditValue = Nothing
        Me.dtePlannedDate.Location = New System.Drawing.Point(613, 29)
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
        Me.dtePlannedDate.Size = New System.Drawing.Size(94, 20)
        Me.dtePlannedDate.TabIndex = 114
        '
        'dteActualDate
        '
        Me.dteActualDate.EditValue = Nothing
        Me.dteActualDate.Location = New System.Drawing.Point(613, 87)
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
        Me.dteActualDate.Size = New System.Drawing.Size(94, 20)
        Me.dteActualDate.TabIndex = 106
        '
        'bbtnUpdateInCascade
        '
        Me.bbtnUpdateInCascade.Location = New System.Drawing.Point(580, 4)
        Me.bbtnUpdateInCascade.Name = "bbtnUpdateInCascade"
        Me.bbtnUpdateInCascade.Size = New System.Drawing.Size(127, 23)
        Me.bbtnUpdateInCascade.TabIndex = 115
        Me.bbtnUpdateInCascade.Text = "Actualizar en Cascada"
        '
        'lblStartDate
        '
        Me.lblStartDate.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStartDate.Appearance.Options.UseFont = True
        Me.lblStartDate.Appearance.Options.UseForeColor = True
        Me.lblStartDate.Location = New System.Drawing.Point(500, 61)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(55, 14)
        Me.lblStartDate.TabIndex = 116
        Me.lblStartDate.Text = "Inicio Real"
        '
        'dteStartDate
        '
        Me.dteStartDate.EditValue = Nothing
        Me.dteStartDate.Location = New System.Drawing.Point(613, 58)
        Me.dteStartDate.Name = "dteStartDate"
        Me.dteStartDate.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteStartDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteStartDate.Properties.Appearance.Options.UseBackColor = True
        Me.dteStartDate.Properties.Appearance.Options.UseFont = True
        Me.dteStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteStartDate.Properties.DisplayFormat.FormatString = ""
        Me.dteStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteStartDate.Properties.EditFormat.FormatString = ""
        Me.dteStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteStartDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteStartDate.Size = New System.Drawing.Size(94, 20)
        Me.dteStartDate.TabIndex = 117
        '
        'txtReqManDays
        '
        Me.txtReqManDays.Location = New System.Drawing.Point(118, 66)
        Me.txtReqManDays.Name = "txtReqManDays"
        Me.txtReqManDays.Properties.DisplayFormat.FormatString = "N0"
        Me.txtReqManDays.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtReqManDays.Properties.Mask.EditMask = "N0"
        Me.txtReqManDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtReqManDays.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtReqManDays.Size = New System.Drawing.Size(43, 20)
        Me.txtReqManDays.TabIndex = 118
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(11, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(101, 14)
        Me.LabelControl3.TabIndex = 119
        Me.LabelControl3.Text = "Núm. Días Hombre"
        '
        'frmSalesOrderPhaseMilestoneStatusDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 238)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtReqManDays)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.dteStartDate)
        Me.Controls.Add(Me.bbtnUpdateInCascade)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.radgrpPUStatusSetting)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dtePlannedDate)
        Me.Controls.Add(Me.dteActualDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesOrderPhaseMilestoneStatusDetail"
        Me.Text = "Detalle de Etapa"
        CType(Me.radgrpPUStatusSetting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePlannedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePlannedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteActualDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteActualDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqManDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radgrpPUStatusSetting As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents dtePlannedDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents dteActualDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents bbtnUpdateInCascade As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtReqManDays As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
