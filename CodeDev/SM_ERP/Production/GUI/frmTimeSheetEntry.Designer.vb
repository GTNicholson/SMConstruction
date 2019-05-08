<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSheetEntry
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
    Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
    Me.grdTimeSheet = New DevExpress.XtraGrid.GridControl()
    Me.gvTimeSheet = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
    Me.TimeEdit2 = New DevExpress.XtraEditors.TimeEdit()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl2.SuspendLayout()
    CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdTimeSheet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvTimeSheet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.PanelControl2, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 690)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.grdTimeSheet)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(3, 64)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(978, 623)
    Me.PanelControl1.TabIndex = 0
    '
    'PanelControl2
    '
    Me.PanelControl2.Controls.Add(Me.LabelControl3)
    Me.PanelControl2.Controls.Add(Me.TimeEdit2)
    Me.PanelControl2.Controls.Add(Me.TimeEdit1)
    Me.PanelControl2.Controls.Add(Me.LabelControl2)
    Me.PanelControl2.Controls.Add(Me.LabelControl1)
    Me.PanelControl2.Controls.Add(Me.DateEdit1)
    Me.PanelControl2.Controls.Add(Me.ComboBoxEdit1)
    Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl2.Location = New System.Drawing.Point(3, 3)
    Me.PanelControl2.Name = "PanelControl2"
    Me.PanelControl2.Size = New System.Drawing.Size(978, 55)
    Me.PanelControl2.TabIndex = 1
    '
    'ComboBoxEdit1
    '
    Me.ComboBoxEdit1.Location = New System.Drawing.Point(106, 14)
    Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
    Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
    Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.ComboBoxEdit1.Size = New System.Drawing.Size(276, 24)
    Me.ComboBoxEdit1.TabIndex = 0
    '
    'DateEdit1
    '
    Me.DateEdit1.EditValue = Nothing
    Me.DateEdit1.Location = New System.Drawing.Point(536, 14)
    Me.DateEdit1.Name = "DateEdit1"
    Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DateEdit1.Properties.Appearance.Options.UseFont = True
    Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.DateEdit1.Size = New System.Drawing.Size(126, 24)
    Me.DateEdit1.TabIndex = 1
    '
    'grdTimeSheet
    '
    Me.grdTimeSheet.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdTimeSheet.Location = New System.Drawing.Point(2, 2)
    Me.grdTimeSheet.MainView = Me.gvTimeSheet
    Me.grdTimeSheet.Name = "grdTimeSheet"
    Me.grdTimeSheet.Size = New System.Drawing.Size(974, 619)
    Me.grdTimeSheet.TabIndex = 0
    Me.grdTimeSheet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTimeSheet})
    '
    'gvTimeSheet
    '
    Me.gvTimeSheet.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvTimeSheet.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvTimeSheet.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvTimeSheet.Appearance.Row.Options.UseFont = True
    Me.gvTimeSheet.ColumnPanelRowHeight = 30
    Me.gvTimeSheet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.gvTimeSheet.GridControl = Me.grdTimeSheet
    Me.gvTimeSheet.Name = "gvTimeSheet"
    Me.gvTimeSheet.OptionsView.ShowGroupPanel = False
    Me.gvTimeSheet.OptionsView.ShowIndicator = False
    Me.gvTimeSheet.RowHeight = 25
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(10, 17)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(70, 18)
    Me.LabelControl1.TabIndex = 2
    Me.LabelControl1.Text = "Empleado"
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Appearance.Options.UseForeColor = True
    Me.LabelControl2.Location = New System.Drawing.Point(438, 17)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(78, 18)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Semana de"
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn1.Caption = "Hora"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Lunes"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Martes"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Miercoles"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Jueves"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Viernes"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Sabado"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 6
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Domingo"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 7
    '
    'TimeEdit1
    '
    Me.TimeEdit1.EditValue = New Date(2019, 5, 8, 0, 0, 0, 0)
    Me.TimeEdit1.Location = New System.Drawing.Point(724, 16)
    Me.TimeEdit1.Name = "TimeEdit1"
    Me.TimeEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TimeEdit1.Properties.Appearance.Options.UseFont = True
    Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.TimeEdit1.Size = New System.Drawing.Size(108, 22)
    Me.TimeEdit1.TabIndex = 4
    '
    'TimeEdit2
    '
    Me.TimeEdit2.EditValue = New Date(2019, 5, 8, 0, 0, 0, 0)
    Me.TimeEdit2.Location = New System.Drawing.Point(865, 15)
    Me.TimeEdit2.Name = "TimeEdit2"
    Me.TimeEdit2.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TimeEdit2.Properties.Appearance.Options.UseFont = True
    Me.TimeEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.TimeEdit2.Size = New System.Drawing.Size(108, 22)
    Me.TimeEdit2.TabIndex = 5
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Appearance.Options.UseForeColor = True
    Me.LabelControl3.Location = New System.Drawing.Point(843, 17)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(8, 18)
    Me.LabelControl3.TabIndex = 6
    Me.LabelControl3.Text = "a"
    '
    'frmTimeSheetEntry
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(984, 690)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmTimeSheetEntry"
    Me.Text = "Entrada de Horas Laborales"
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl2.ResumeLayout(False)
    Me.PanelControl2.PerformLayout()
    CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdTimeSheet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvTimeSheet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TimeEdit2 As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents grdTimeSheet As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvTimeSheet As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
