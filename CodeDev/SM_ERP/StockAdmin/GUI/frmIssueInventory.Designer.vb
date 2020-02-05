<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueInventory
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtRequisaNo = New DevExpress.XtraEditors.SpinEdit()
    Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
    Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.memNotes = New DevExpress.XtraEditors.MemoEdit()
    Me.datSelectedDate = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.txtRequisaNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.memNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datSelectedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datSelectedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.LabelControl2)
    Me.PanelControl1.Controls.Add(Me.txtRequisaNo)
    Me.PanelControl1.Controls.Add(Me.btnCancel)
    Me.PanelControl1.Controls.Add(Me.btnConfirm)
    Me.PanelControl1.Controls.Add(Me.LabelControl1)
    Me.PanelControl1.Controls.Add(Me.memNotes)
    Me.PanelControl1.Controls.Add(Me.datSelectedDate)
    Me.PanelControl1.Controls.Add(Me.LabelControl7)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(320, 179)
    Me.PanelControl1.TabIndex = 1
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Appearance.Options.UseForeColor = True
    Me.LabelControl2.Location = New System.Drawing.Point(12, 16)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(53, 14)
    Me.LabelControl2.TabIndex = 148
    Me.LabelControl2.Text = "# Requisa"
    '
    'txtRequisaNo
    '
    Me.txtRequisaNo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtRequisaNo.Location = New System.Drawing.Point(71, 14)
    Me.txtRequisaNo.Name = "txtRequisaNo"
    Me.txtRequisaNo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRequisaNo.Properties.Appearance.Options.UseFont = True
    Me.txtRequisaNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, EditorButtonImageOptions1)})
    Me.txtRequisaNo.Properties.DisplayFormat.FormatString = "0.##"
    Me.txtRequisaNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtRequisaNo.Properties.ValidateOnEnterKey = True
    Me.txtRequisaNo.Size = New System.Drawing.Size(50, 20)
    Me.txtRequisaNo.TabIndex = 147
    '
    'btnCancel
    '
    Me.btnCancel.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.Appearance.Options.UseFont = True
    Me.btnCancel.Location = New System.Drawing.Point(238, 139)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(66, 23)
    Me.btnCancel.TabIndex = 58
    Me.btnCancel.Text = "Cancelar"
    '
    'btnConfirm
    '
    Me.btnConfirm.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnConfirm.Appearance.Options.UseFont = True
    Me.btnConfirm.Location = New System.Drawing.Point(71, 139)
    Me.btnConfirm.Name = "btnConfirm"
    Me.btnConfirm.Size = New System.Drawing.Size(73, 23)
    Me.btnConfirm.TabIndex = 57
    Me.btnConfirm.Text = "Confirmar"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(12, 69)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(31, 14)
    Me.LabelControl1.TabIndex = 50
    Me.LabelControl1.Text = "Notas"
    '
    'memNotes
    '
    Me.memNotes.Location = New System.Drawing.Point(71, 68)
    Me.memNotes.Name = "memNotes"
    Me.memNotes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.memNotes.Properties.Appearance.Options.UseFont = True
    Me.memNotes.Size = New System.Drawing.Size(242, 57)
    Me.memNotes.TabIndex = 49
    '
    'datSelectedDate
    '
    Me.datSelectedDate.EditValue = Nothing
    Me.datSelectedDate.Location = New System.Drawing.Point(71, 40)
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
    Me.LabelControl7.Location = New System.Drawing.Point(12, 43)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(32, 14)
    Me.LabelControl7.TabIndex = 47
    Me.LabelControl7.Text = "Fecha"
    '
    'frmIssueInventory
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(320, 179)
    Me.Controls.Add(Me.PanelControl1)
    Me.Name = "frmIssueInventory"
    Me.Text = "Salida de Inventario"
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    CType(Me.txtRequisaNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.memNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datSelectedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datSelectedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtRequisaNo As DevExpress.XtraEditors.SpinEdit
  Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents memNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents datSelectedDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
