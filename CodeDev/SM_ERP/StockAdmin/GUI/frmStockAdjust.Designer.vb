<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAdjust
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
    Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockAdjust))
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.spnStockAdjustQty = New DevExpress.XtraEditors.SpinEdit()
    Me.datSelectedTime = New DevExpress.XtraEditors.TimeEdit()
    Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
    Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.memNotes = New DevExpress.XtraEditors.MemoEdit()
    Me.datSelectedDate = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.radgrpStockAdjustType = New DevExpress.XtraEditors.RadioGroup()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.spnStockAdjustQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datSelectedTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.memNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datSelectedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datSelectedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.radgrpStockAdjustType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.radgrpStockAdjustType)
    Me.PanelControl1.Controls.Add(Me.LabelControl2)
    Me.PanelControl1.Controls.Add(Me.spnStockAdjustQty)
    Me.PanelControl1.Controls.Add(Me.datSelectedTime)
    Me.PanelControl1.Controls.Add(Me.btnCancel)
    Me.PanelControl1.Controls.Add(Me.btnConfirm)
    Me.PanelControl1.Controls.Add(Me.LabelControl1)
    Me.PanelControl1.Controls.Add(Me.memNotes)
    Me.PanelControl1.Controls.Add(Me.datSelectedDate)
    Me.PanelControl1.Controls.Add(Me.LabelControl7)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(321, 196)
    Me.PanelControl1.TabIndex = 0
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Appearance.Options.UseForeColor = True
    Me.LabelControl2.Location = New System.Drawing.Point(14, 43)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(45, 14)
    Me.LabelControl2.TabIndex = 148
    Me.LabelControl2.Text = "Quantity"
    '
    'spnStockAdjustQty
    '
    Me.spnStockAdjustQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.spnStockAdjustQty.Location = New System.Drawing.Point(64, 41)
    Me.spnStockAdjustQty.Name = "spnStockAdjustQty"
    Me.spnStockAdjustQty.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.spnStockAdjustQty.Properties.Appearance.Options.UseFont = True
    Me.spnStockAdjustQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, EditorButtonImageOptions1)})
    Me.spnStockAdjustQty.Properties.DisplayFormat.FormatString = "0.##"
    Me.spnStockAdjustQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.spnStockAdjustQty.Properties.ValidateOnEnterKey = True
    Me.spnStockAdjustQty.Size = New System.Drawing.Size(50, 20)
    Me.spnStockAdjustQty.TabIndex = 147
    '
    'datSelectedTime
    '
    Me.datSelectedTime.EditValue = New Date(2019, 4, 2, 0, 0, 0, 0)
    Me.datSelectedTime.Location = New System.Drawing.Point(169, 67)
    Me.datSelectedTime.Name = "datSelectedTime"
    Me.datSelectedTime.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datSelectedTime.Properties.Appearance.Options.UseFont = True
    Me.datSelectedTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datSelectedTime.Size = New System.Drawing.Size(87, 20)
    Me.datSelectedTime.TabIndex = 59
    '
    'btnCancel
    '
    Me.btnCancel.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.Appearance.Options.UseFont = True
    Me.btnCancel.Location = New System.Drawing.Point(251, 167)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(55, 23)
    Me.btnCancel.TabIndex = 58
    Me.btnCancel.Text = "Cancel"
    '
    'btnConfirm
    '
    Me.btnConfirm.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnConfirm.Appearance.Options.UseFont = True
    Me.btnConfirm.Location = New System.Drawing.Point(190, 167)
    Me.btnConfirm.Name = "btnConfirm"
    Me.btnConfirm.Size = New System.Drawing.Size(55, 23)
    Me.btnConfirm.TabIndex = 57
    Me.btnConfirm.Text = "Confirm"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(14, 96)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(32, 14)
    Me.LabelControl1.TabIndex = 50
    Me.LabelControl1.Text = "Notes"
    '
    'memNotes
    '
    Me.memNotes.Location = New System.Drawing.Point(64, 95)
    Me.memNotes.Name = "memNotes"
    Me.memNotes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.memNotes.Properties.Appearance.Options.UseFont = True
    Me.memNotes.Size = New System.Drawing.Size(242, 57)
    Me.memNotes.TabIndex = 49
    '
    'datSelectedDate
    '
    Me.datSelectedDate.EditValue = Nothing
    Me.datSelectedDate.Location = New System.Drawing.Point(64, 67)
    Me.datSelectedDate.Name = "datSelectedDate"
    Me.datSelectedDate.Properties.AllowMouseWheel = False
    Me.datSelectedDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datSelectedDate.Properties.Appearance.Options.UseFont = True
    Me.datSelectedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datSelectedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datSelectedDate.Properties.NullDate = New Date(CType(0, Long))
    Me.datSelectedDate.Size = New System.Drawing.Size(99, 20)
    Me.datSelectedDate.TabIndex = 48
    '
    'LabelControl7
    '
    Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl7.Appearance.Options.UseFont = True
    Me.LabelControl7.Appearance.Options.UseForeColor = True
    Me.LabelControl7.Location = New System.Drawing.Point(14, 70)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(24, 14)
    Me.LabelControl7.TabIndex = 47
    Me.LabelControl7.Text = "Date"
    '
    'radgrpStockAdjustType
    '
    Me.radgrpStockAdjustType.Location = New System.Drawing.Point(64, 9)
    Me.radgrpStockAdjustType.Name = "radgrpStockAdjustType"
    Me.radgrpStockAdjustType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.radgrpStockAdjustType.Properties.Appearance.Options.UseFont = True
    Me.radgrpStockAdjustType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Adjust Stock By"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Reset Stock To")})
    Me.radgrpStockAdjustType.Size = New System.Drawing.Size(242, 26)
    Me.radgrpStockAdjustType.TabIndex = 149
    '
    'frmStockAdjust
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(321, 196)
    Me.Controls.Add(Me.PanelControl1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmStockAdjust"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Stock Adjustment"
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    CType(Me.spnStockAdjustQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datSelectedTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.memNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datSelectedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datSelectedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.radgrpStockAdjustType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents memNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents datSelectedDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents datSelectedTime As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents spnStockAdjustQty As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents radgrpStockAdjustType As DevExpress.XtraEditors.RadioGroup
End Class
