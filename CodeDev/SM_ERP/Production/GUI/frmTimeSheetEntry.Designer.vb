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
    Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.radgrpWorkCentreID = New DevExpress.XtraEditors.RadioGroup()
    Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
    Me.btnReload = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.timTimeEnd = New DevExpress.XtraEditors.TimeEdit()
    Me.timTimeStart = New DevExpress.XtraEditors.TimeEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.datWeekCommencing = New DevExpress.XtraEditors.DateEdit()
    Me.cboEmployee = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
    Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
    Me.grdTimeSheet = New DevExpress.XtraGrid.GridControl()
    Me.gvTimeSheet = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitmemTSEntry = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
    Me.grdTimeSheetEntries = New DevExpress.XtraGrid.GridControl()
    Me.gvTimeSheetEntries = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl2.SuspendLayout()
    CType(Me.radgrpWorkCentreID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.timTimeEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.timTimeStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datWeekCommencing.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datWeekCommencing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.XtraTabControl1.SuspendLayout()
    Me.XtraTabPage1.SuspendLayout()
    CType(Me.grdTimeSheet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvTimeSheet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitmemTSEntry, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.XtraTabPage2.SuspendLayout()
    CType(Me.grdTimeSheetEntries, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvTimeSheetEntries, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1164, 521)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'PanelControl2
    '
    Me.PanelControl2.Controls.Add(Me.LabelControl4)
    Me.PanelControl2.Controls.Add(Me.radgrpWorkCentreID)
    Me.PanelControl2.Controls.Add(Me.btnSave)
    Me.PanelControl2.Controls.Add(Me.btnReload)
    Me.PanelControl2.Controls.Add(Me.LabelControl3)
    Me.PanelControl2.Controls.Add(Me.timTimeEnd)
    Me.PanelControl2.Controls.Add(Me.timTimeStart)
    Me.PanelControl2.Controls.Add(Me.LabelControl2)
    Me.PanelControl2.Controls.Add(Me.LabelControl1)
    Me.PanelControl2.Controls.Add(Me.datWeekCommencing)
    Me.PanelControl2.Controls.Add(Me.cboEmployee)
    Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl2.Location = New System.Drawing.Point(3, 3)
    Me.PanelControl2.Name = "PanelControl2"
    Me.PanelControl2.Size = New System.Drawing.Size(1158, 80)
    Me.PanelControl2.TabIndex = 1
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl4.Appearance.Options.UseFont = True
    Me.LabelControl4.Appearance.Options.UseForeColor = True
    Me.LabelControl4.Location = New System.Drawing.Point(10, 48)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(32, 18)
    Me.LabelControl4.TabIndex = 10
    Me.LabelControl4.Text = "Area"
    '
    'radgrpWorkCentreID
    '
    Me.radgrpWorkCentreID.Location = New System.Drawing.Point(98, 44)
    Me.radgrpWorkCentreID.Name = "radgrpWorkCentreID"
    Me.radgrpWorkCentreID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.radgrpWorkCentreID.Properties.Appearance.Options.UseFont = True
    Me.radgrpWorkCentreID.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Optimización"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Maquinado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Ensamble"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Lija"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Metal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(6, "Tapizado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(7, "Pintura"), New DevExpress.XtraEditors.Controls.RadioGroupItem(8, "Empaque"), New DevExpress.XtraEditors.Controls.RadioGroupItem(9, "Despacho")})
    Me.radgrpWorkCentreID.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
    Me.radgrpWorkCentreID.Size = New System.Drawing.Size(695, 26)
    Me.radgrpWorkCentreID.TabIndex = 9
    '
    'btnSave
    '
    Me.btnSave.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSave.Appearance.Options.UseFont = True
    Me.btnSave.Location = New System.Drawing.Point(896, 12)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(82, 23)
    Me.btnSave.TabIndex = 8
    Me.btnSave.Text = "Guardar"
    '
    'btnReload
    '
    Me.btnReload.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReload.Appearance.Options.UseFont = True
    Me.btnReload.Location = New System.Drawing.Point(808, 12)
    Me.btnReload.Name = "btnReload"
    Me.btnReload.Size = New System.Drawing.Size(82, 23)
    Me.btnReload.TabIndex = 7
    Me.btnReload.Text = "Actualizar"
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Appearance.Options.UseForeColor = True
    Me.LabelControl3.Location = New System.Drawing.Point(708, 14)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(8, 18)
    Me.LabelControl3.TabIndex = 6
    Me.LabelControl3.Text = "a"
    '
    'timTimeEnd
    '
    Me.timTimeEnd.EditValue = New Date(2019, 5, 8, 0, 0, 0, 0)
    Me.timTimeEnd.Location = New System.Drawing.Point(722, 12)
    Me.timTimeEnd.Name = "timTimeEnd"
    Me.timTimeEnd.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.timTimeEnd.Properties.Appearance.Options.UseFont = True
    Me.timTimeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.timTimeEnd.Properties.Mask.EditMask = "HH:mm"
    Me.timTimeEnd.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.timTimeEnd.Size = New System.Drawing.Size(71, 22)
    Me.timTimeEnd.TabIndex = 5
    '
    'timTimeStart
    '
    Me.timTimeStart.EditValue = New Date(2019, 5, 8, 0, 0, 0, 0)
    Me.timTimeStart.Location = New System.Drawing.Point(627, 13)
    Me.timTimeStart.Name = "timTimeStart"
    Me.timTimeStart.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.timTimeStart.Properties.Appearance.Options.UseFont = True
    Me.timTimeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.timTimeStart.Properties.Mask.EditMask = "HH:mm"
    Me.timTimeStart.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.timTimeStart.Size = New System.Drawing.Size(75, 22)
    Me.timTimeStart.TabIndex = 4
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Appearance.Options.UseForeColor = True
    Me.LabelControl2.Location = New System.Drawing.Point(401, 16)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(78, 18)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Semana de"
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
    'datWeekCommencing
    '
    Me.datWeekCommencing.EditValue = Nothing
    Me.datWeekCommencing.Location = New System.Drawing.Point(485, 13)
    Me.datWeekCommencing.Name = "datWeekCommencing"
    Me.datWeekCommencing.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datWeekCommencing.Properties.Appearance.Options.UseFont = True
    Me.datWeekCommencing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datWeekCommencing.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datWeekCommencing.Size = New System.Drawing.Size(126, 24)
    Me.datWeekCommencing.TabIndex = 1
    '
    'cboEmployee
    '
    Me.cboEmployee.Location = New System.Drawing.Point(97, 14)
    Me.cboEmployee.Name = "cboEmployee"
    Me.cboEmployee.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboEmployee.Properties.Appearance.Options.UseFont = True
    Me.cboEmployee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboEmployee.Size = New System.Drawing.Size(276, 24)
    Me.cboEmployee.TabIndex = 0
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.XtraTabControl1)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(3, 89)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1158, 429)
    Me.PanelControl1.TabIndex = 0
    '
    'XtraTabControl1
    '
    Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
    Me.XtraTabControl1.Name = "XtraTabControl1"
    Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
    Me.XtraTabControl1.Size = New System.Drawing.Size(1154, 425)
    Me.XtraTabControl1.TabIndex = 1
    Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
    '
    'XtraTabPage1
    '
    Me.XtraTabPage1.Controls.Add(Me.grdTimeSheet)
    Me.XtraTabPage1.Name = "XtraTabPage1"
    Me.XtraTabPage1.Size = New System.Drawing.Size(1146, 396)
    Me.XtraTabPage1.Text = "XtraTabPage1"
    '
    'grdTimeSheet
    '
    Me.grdTimeSheet.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdTimeSheet.Location = New System.Drawing.Point(0, 0)
    Me.grdTimeSheet.MainView = Me.gvTimeSheet
    Me.grdTimeSheet.Name = "grdTimeSheet"
    Me.grdTimeSheet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitmemTSEntry})
    Me.grdTimeSheet.Size = New System.Drawing.Size(1146, 396)
    Me.grdTimeSheet.TabIndex = 0
    Me.grdTimeSheet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTimeSheet})
    '
    'gvTimeSheet
    '
    Me.gvTimeSheet.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvTimeSheet.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvTimeSheet.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvTimeSheet.Appearance.Row.Options.UseFont = True
    Me.gvTimeSheet.Appearance.Row.Options.UseTextOptions = True
    Me.gvTimeSheet.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.gvTimeSheet.ColumnPanelRowHeight = 30
    Me.gvTimeSheet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.gvTimeSheet.GridControl = Me.grdTimeSheet
    Me.gvTimeSheet.Name = "gvTimeSheet"
    Me.gvTimeSheet.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
    Me.gvTimeSheet.OptionsDetail.EnableMasterViewMode = False
    Me.gvTimeSheet.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.gvTimeSheet.OptionsSelection.EnableAppearanceFocusedRow = False
    Me.gvTimeSheet.OptionsView.ShowGroupPanel = False
    Me.gvTimeSheet.OptionsView.ShowIndicator = False
    Me.gvTimeSheet.RowHeight = 34
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn1.Caption = "Hora"
    Me.GridColumn1.DisplayFormat.FormatString = "t"
    Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn1.FieldName = "StartTime"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn2.Caption = "Lunes"
    Me.GridColumn2.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn2.FieldName = "Monday"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'repitmemTSEntry
    '
    Me.repitmemTSEntry.AcceptsReturn = False
    Me.repitmemTSEntry.Appearance.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.repitmemTSEntry.Appearance.Options.UseFont = True
    Me.repitmemTSEntry.Appearance.Options.UseTextOptions = True
    Me.repitmemTSEntry.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.repitmemTSEntry.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.repitmemTSEntry.Name = "repitmemTSEntry"
    Me.repitmemTSEntry.ValidateOnEnterKey = True
    '
    'GridColumn3
    '
    Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn3.Caption = "Martes"
    Me.GridColumn3.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn3.FieldName = "Tuesday"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn4.Caption = "Miercoles"
    Me.GridColumn4.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn4.FieldName = "Wednesday"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn5.Caption = "Jueves"
    Me.GridColumn5.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn5.FieldName = "Thursday"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'GridColumn6
    '
    Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn6.Caption = "Viernes"
    Me.GridColumn6.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn6.FieldName = "Friday"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'GridColumn7
    '
    Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn7.Caption = "Sabado"
    Me.GridColumn7.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn7.FieldName = "Saturday"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 6
    '
    'GridColumn8
    '
    Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn8.Caption = "Domingo"
    Me.GridColumn8.ColumnEdit = Me.repitmemTSEntry
    Me.GridColumn8.FieldName = "Sunday"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 7
    '
    'XtraTabPage2
    '
    Me.XtraTabPage2.Controls.Add(Me.grdTimeSheetEntries)
    Me.XtraTabPage2.Name = "XtraTabPage2"
    Me.XtraTabPage2.Size = New System.Drawing.Size(1146, 396)
    Me.XtraTabPage2.Text = "XtraTabPage2"
    '
    'grdTimeSheetEntries
    '
    Me.grdTimeSheetEntries.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdTimeSheetEntries.Location = New System.Drawing.Point(0, 0)
    Me.grdTimeSheetEntries.MainView = Me.gvTimeSheetEntries
    Me.grdTimeSheetEntries.Name = "grdTimeSheetEntries"
    Me.grdTimeSheetEntries.Size = New System.Drawing.Size(1146, 396)
    Me.grdTimeSheetEntries.TabIndex = 0
    Me.grdTimeSheetEntries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTimeSheetEntries})
    '
    'gvTimeSheetEntries
    '
    Me.gvTimeSheetEntries.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvTimeSheetEntries.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvTimeSheetEntries.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvTimeSheetEntries.Appearance.Row.Options.UseFont = True
    Me.gvTimeSheetEntries.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn18, Me.GridColumn17})
    Me.gvTimeSheetEntries.GridControl = Me.grdTimeSheetEntries
    Me.gvTimeSheetEntries.Name = "gvTimeSheetEntries"
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "ID"
    Me.GridColumn9.FieldName = "TimeSheetEntryID"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 0
    Me.GridColumn9.Width = 82
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Type"
    Me.GridColumn10.FieldName = "TimeSheetEntryTypeID"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 1
    Me.GridColumn10.Width = 68
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "EmployeeID"
    Me.GridColumn11.FieldName = "EmployeeID"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 2
    Me.GridColumn11.Width = 100
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "WorkOrderID"
    Me.GridColumn12.FieldName = "WorkOrderID"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 3
    Me.GridColumn12.Width = 123
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "StartDate"
    Me.GridColumn13.DisplayFormat.FormatString = "d"
    Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn13.FieldName = "StartTime"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 4
    Me.GridColumn13.Width = 204
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "Time"
    Me.GridColumn14.DisplayFormat.FormatString = "HH:mm"
    Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn14.FieldName = "StartTime"
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.Visible = True
    Me.GridColumn14.VisibleIndex = 5
    Me.GridColumn14.Width = 204
    '
    'GridColumn15
    '
    Me.GridColumn15.Caption = "EndDate"
    Me.GridColumn15.DisplayFormat.FormatString = "d"
    Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn15.FieldName = "EndTime"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 6
    Me.GridColumn15.Width = 204
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "Time"
    Me.GridColumn16.DisplayFormat.FormatString = "HH:mm"
    Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn16.FieldName = "EndTime"
    Me.GridColumn16.Name = "GridColumn16"
    Me.GridColumn16.Visible = True
    Me.GridColumn16.VisibleIndex = 7
    Me.GridColumn16.Width = 204
    '
    'GridColumn18
    '
    Me.GridColumn18.Caption = "Note"
    Me.GridColumn18.FieldName = "Note"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.Visible = True
    Me.GridColumn18.VisibleIndex = 8
    Me.GridColumn18.Width = 204
    '
    'GridColumn17
    '
    Me.GridColumn17.Caption = "WorkcentreID"
    Me.GridColumn17.FieldName = "WorkcentreID"
    Me.GridColumn17.Name = "GridColumn17"
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 9
    Me.GridColumn17.Width = 229
    '
    'frmTimeSheetEntry
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1164, 521)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "frmTimeSheetEntry"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Entrada de Horas Laborales"
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl2.ResumeLayout(False)
    Me.PanelControl2.PerformLayout()
    CType(Me.radgrpWorkCentreID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.timTimeEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.timTimeStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datWeekCommencing.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datWeekCommencing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.XtraTabControl1.ResumeLayout(False)
    Me.XtraTabPage1.ResumeLayout(False)
    CType(Me.grdTimeSheet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvTimeSheet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitmemTSEntry, System.ComponentModel.ISupportInitialize).EndInit()
    Me.XtraTabPage2.ResumeLayout(False)
    CType(Me.grdTimeSheetEntries, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvTimeSheetEntries, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents cboEmployee As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents timTimeEnd As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents timTimeStart As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents datWeekCommencing As DevExpress.XtraEditors.DateEdit
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
  Friend WithEvents btnReload As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents repitmemTSEntry As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents radgrpWorkCentreID As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents grdTimeSheetEntries As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvTimeSheetEntries As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
End Class
