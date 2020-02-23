<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaySlipDetails
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
    Me.components = New System.ComponentModel.Container()
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.grdPaySlipItems = New DevExpress.XtraGrid.GridControl()
    Me.gvPaySlipItems = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStandardHrs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStandardPay = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOTHrs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOTPay = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcTotalPay = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
    Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.grpPeriodAndEmployee = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.datEndDateOT = New DevExpress.XtraEditors.DateEdit()
    Me.datStartDateOT = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.datEndDateStd = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.datStartDateStd = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.radPayPeriodType = New DevExpress.XtraEditors.RadioGroup()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.datPeriodStart = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.grdPaySlipItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvPaySlipItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpPeriodAndEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpPeriodAndEmployee.SuspendLayout()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datEndDateOT.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datEndDateOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datStartDateOT.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datStartDateOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datEndDateStd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datEndDateStd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datStartDateStd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datStartDateStd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.radPayPeriodType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datPeriodStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datPeriodStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.GroupControl2, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.grpPeriodAndEmployee, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(963, 557)
    Me.TableLayoutPanel1.TabIndex = 9
    '
    'GroupControl2
    '
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl2.Controls.Add(Me.grdPaySlipItems)
    Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupControl2.Location = New System.Drawing.Point(3, 113)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(957, 441)
    Me.GroupControl2.TabIndex = 3
    Me.GroupControl2.Text = "Detalles del Periodo"
    '
    'grdPaySlipItems
    '
    Me.grdPaySlipItems.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdPaySlipItems.Location = New System.Drawing.Point(2, 23)
    Me.grdPaySlipItems.MainView = Me.gvPaySlipItems
    Me.grdPaySlipItems.MenuManager = Me.BarManager1
    Me.grdPaySlipItems.Name = "grdPaySlipItems"
    Me.grdPaySlipItems.Size = New System.Drawing.Size(953, 416)
    Me.grdPaySlipItems.TabIndex = 0
    Me.grdPaySlipItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPaySlipItems})
    '
    'gvPaySlipItems
    '
    Me.gvPaySlipItems.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvPaySlipItems.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvPaySlipItems.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvPaySlipItems.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvPaySlipItems.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvPaySlipItems.Appearance.Row.Options.UseFont = True
    Me.gvPaySlipItems.ColumnPanelRowHeight = 34
    Me.gvPaySlipItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.gcStandardHrs, Me.gcStandardPay, Me.gcOTHrs, Me.gcOTPay, Me.gcTotalPay})
    Me.gvPaySlipItems.GridControl = Me.grdPaySlipItems
    Me.gvPaySlipItems.Name = "gvPaySlipItems"
    Me.gvPaySlipItems.OptionsBehavior.Editable = False
    Me.gvPaySlipItems.OptionsSelection.EnableAppearanceFocusedRow = False
    Me.gvPaySlipItems.OptionsView.ShowFooter = True
    Me.gvPaySlipItems.OptionsView.ShowGroupPanel = False
    Me.gvPaySlipItems.OptionsView.ShowIndicator = False
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold
    Me.GridColumn1.AppearanceCell.Options.UseFont = True
    Me.GridColumn1.Caption = "Fecha"
    Me.GridColumn1.DisplayFormat.FormatString = "d"
    Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn1.FieldName = "ItemDate"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 105
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Dia"
    Me.GridColumn2.DisplayFormat.FormatString = "dddd"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.GridColumn2.FieldName = "ItemDate"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 97
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Codigo"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 55
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Hora de Entrada"
    Me.GridColumn4.DisplayFormat.FormatString = "T"
    Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn4.FieldName = "StartTime"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    Me.GridColumn4.Width = 94
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Hora de Salida"
    Me.GridColumn5.DisplayFormat.FormatString = "T"
    Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn5.FieldName = "EndTime"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    Me.GridColumn5.Width = 94
    '
    'gcStandardHrs
    '
    Me.gcStandardHrs.AppearanceCell.Options.UseTextOptions = True
    Me.gcStandardHrs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcStandardHrs.AppearanceHeader.Options.UseTextOptions = True
    Me.gcStandardHrs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcStandardHrs.Caption = "Horas Estandar"
    Me.gcStandardHrs.DisplayFormat.FormatString = "#.##"
    Me.gcStandardHrs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.gcStandardHrs.FieldName = "StandardHours"
    Me.gcStandardHrs.Name = "gcStandardHrs"
    Me.gcStandardHrs.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StandardHours", "{0:0.##}")})
    Me.gcStandardHrs.Visible = True
    Me.gcStandardHrs.VisibleIndex = 5
    Me.gcStandardHrs.Width = 94
    '
    'gcStandardPay
    '
    Me.gcStandardPay.AppearanceCell.Options.UseTextOptions = True
    Me.gcStandardPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcStandardPay.AppearanceHeader.Options.UseTextOptions = True
    Me.gcStandardPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcStandardPay.Caption = "Pago Estandar"
    Me.gcStandardPay.Name = "gcStandardPay"
    Me.gcStandardPay.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.##}")})
    Me.gcStandardPay.Visible = True
    Me.gcStandardPay.VisibleIndex = 6
    Me.gcStandardPay.Width = 94
    '
    'gcOTHrs
    '
    Me.gcOTHrs.AppearanceCell.Options.UseTextOptions = True
    Me.gcOTHrs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcOTHrs.AppearanceHeader.Options.UseTextOptions = True
    Me.gcOTHrs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcOTHrs.Caption = "Horas Extra"
    Me.gcOTHrs.DisplayFormat.FormatString = "#.##"
    Me.gcOTHrs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.gcOTHrs.FieldName = "OverTimeHours"
    Me.gcOTHrs.Name = "gcOTHrs"
    Me.gcOTHrs.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OvertimeHours", "{0:0.##}")})
    Me.gcOTHrs.Visible = True
    Me.gcOTHrs.VisibleIndex = 7
    Me.gcOTHrs.Width = 94
    '
    'gcOTPay
    '
    Me.gcOTPay.AppearanceCell.Options.UseTextOptions = True
    Me.gcOTPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcOTPay.AppearanceHeader.Options.UseTextOptions = True
    Me.gcOTPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcOTPay.Caption = "Pago Extra"
    Me.gcOTPay.Name = "gcOTPay"
    Me.gcOTPay.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.##}")})
    Me.gcOTPay.Visible = True
    Me.gcOTPay.VisibleIndex = 8
    Me.gcOTPay.Width = 107
    '
    'gcTotalPay
    '
    Me.gcTotalPay.AppearanceCell.Options.UseTextOptions = True
    Me.gcTotalPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcTotalPay.AppearanceHeader.Options.UseTextOptions = True
    Me.gcTotalPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcTotalPay.Caption = "Total"
    Me.gcTotalPay.Name = "gcTotalPay"
    Me.gcTotalPay.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.##}")})
    Me.gcTotalPay.Visible = True
    Me.gcTotalPay.VisibleIndex = 9
    Me.gcTotalPay.Width = 119
    '
    'BarManager1
    '
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarHeaderItem1, Me.BarEditItem1, Me.BarStaticItem2, Me.BarStaticItem4, Me.BarEditItem5})
    Me.BarManager1.MaxItemId = 12
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemTextEdit3, Me.RepositoryItemComboBox3})
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1051, 0)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 557)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1051, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 557)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1051, 0)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 557)
    '
    'BarStaticItem1
    '
    Me.BarStaticItem1.Caption = "Còdigo Empleado"
    Me.BarStaticItem1.Id = 0
    Me.BarStaticItem1.Name = "BarStaticItem1"
    '
    'BarHeaderItem1
    '
    Me.BarHeaderItem1.Caption = "BarHeaderItem1"
    Me.BarHeaderItem1.Id = 1
    Me.BarHeaderItem1.Name = "BarHeaderItem1"
    '
    'BarEditItem1
    '
    Me.BarEditItem1.Caption = "BarEditItem1"
    Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
    Me.BarEditItem1.Id = 2
    Me.BarEditItem1.Name = "BarEditItem1"
    '
    'RepositoryItemTextEdit1
    '
    Me.RepositoryItemTextEdit1.AutoHeight = False
    Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
    '
    'BarStaticItem2
    '
    Me.BarStaticItem2.Caption = "Nombre de Empleado"
    Me.BarStaticItem2.Id = 3
    Me.BarStaticItem2.Name = "BarStaticItem2"
    '
    'BarStaticItem4
    '
    Me.BarStaticItem4.Caption = "de"
    Me.BarStaticItem4.Id = 7
    Me.BarStaticItem4.Name = "BarStaticItem4"
    '
    'BarEditItem5
    '
    Me.BarEditItem5.Caption = "BarEditItem5"
    Me.BarEditItem5.Edit = Me.RepositoryItemTextEdit3
    Me.BarEditItem5.Id = 10
    Me.BarEditItem5.Name = "BarEditItem5"
    '
    'RepositoryItemTextEdit3
    '
    Me.RepositoryItemTextEdit3.AutoHeight = False
    Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
    '
    'RepositoryItemTextEdit2
    '
    Me.RepositoryItemTextEdit2.AutoHeight = False
    Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
    '
    'RepositoryItemComboBox1
    '
    Me.RepositoryItemComboBox1.AutoHeight = False
    Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
    '
    'RepositoryItemComboBox2
    '
    Me.RepositoryItemComboBox2.AutoHeight = False
    Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
    '
    'RepositoryItemComboBox3
    '
    Me.RepositoryItemComboBox3.AutoHeight = False
    Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
    '
    'grpPeriodAndEmployee
    '
    Me.grpPeriodAndEmployee.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpPeriodAndEmployee.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpPeriodAndEmployee.AppearanceCaption.Options.UseFont = True
    Me.grpPeriodAndEmployee.AppearanceCaption.Options.UseForeColor = True
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl10)
    Me.grpPeriodAndEmployee.Controls.Add(Me.TextEdit3)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl9)
    Me.grpPeriodAndEmployee.Controls.Add(Me.TextEdit2)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl6)
    Me.grpPeriodAndEmployee.Controls.Add(Me.TextEdit1)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl7)
    Me.grpPeriodAndEmployee.Controls.Add(Me.datEndDateOT)
    Me.grpPeriodAndEmployee.Controls.Add(Me.datStartDateOT)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl5)
    Me.grpPeriodAndEmployee.Controls.Add(Me.datEndDateStd)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl4)
    Me.grpPeriodAndEmployee.Controls.Add(Me.datStartDateStd)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl3)
    Me.grpPeriodAndEmployee.Controls.Add(Me.radPayPeriodType)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl2)
    Me.grpPeriodAndEmployee.Controls.Add(Me.datPeriodStart)
    Me.grpPeriodAndEmployee.Controls.Add(Me.LabelControl1)
    Me.grpPeriodAndEmployee.Controls.Add(Me.ComboBoxEdit1)
    Me.grpPeriodAndEmployee.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Imprimir", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Print", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Cargar", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Load", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Reiniciar", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Reset", -1)})
    Me.grpPeriodAndEmployee.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpPeriodAndEmployee.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpPeriodAndEmployee.Location = New System.Drawing.Point(3, 3)
    Me.grpPeriodAndEmployee.Name = "grpPeriodAndEmployee"
    Me.grpPeriodAndEmployee.Size = New System.Drawing.Size(957, 104)
    Me.grpPeriodAndEmployee.TabIndex = 2
    Me.grpPeriodAndEmployee.Text = "Periodo y Empleado"
    '
    'LabelControl10
    '
    Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl10.Appearance.Options.UseFont = True
    Me.LabelControl10.Appearance.Options.UseForeColor = True
    Me.LabelControl10.Location = New System.Drawing.Point(697, 76)
    Me.LabelControl10.Name = "LabelControl10"
    Me.LabelControl10.Size = New System.Drawing.Size(27, 14)
    Me.LabelControl10.TabIndex = 20
    Me.LabelControl10.Text = "Extra"
    '
    'TextEdit3
    '
    Me.TextEdit3.Location = New System.Drawing.Point(730, 73)
    Me.TextEdit3.MenuManager = Me.BarManager1
    Me.TextEdit3.Name = "TextEdit3"
    Me.TextEdit3.Size = New System.Drawing.Size(63, 20)
    Me.TextEdit3.TabIndex = 19
    '
    'LabelControl9
    '
    Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl9.Appearance.Options.UseFont = True
    Me.LabelControl9.Appearance.Options.UseForeColor = True
    Me.LabelControl9.Location = New System.Drawing.Point(559, 76)
    Me.LabelControl9.Name = "LabelControl9"
    Me.LabelControl9.Size = New System.Drawing.Size(49, 14)
    Me.LabelControl9.TabIndex = 18
    Me.LabelControl9.Text = "Estandar"
    '
    'TextEdit2
    '
    Me.TextEdit2.Location = New System.Drawing.Point(610, 73)
    Me.TextEdit2.MenuManager = Me.BarManager1
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Size = New System.Drawing.Size(55, 20)
    Me.TextEdit2.TabIndex = 16
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl6.Appearance.Options.UseFont = True
    Me.LabelControl6.Appearance.Options.UseForeColor = True
    Me.LabelControl6.Location = New System.Drawing.Point(405, 76)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(37, 14)
    Me.LabelControl6.TabIndex = 15
    Me.LabelControl6.Text = "Salario"
    '
    'TextEdit1
    '
    Me.TextEdit1.Location = New System.Drawing.Point(460, 73)
    Me.TextEdit1.MenuManager = Me.BarManager1
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Size = New System.Drawing.Size(89, 20)
    Me.TextEdit1.TabIndex = 14
    '
    'LabelControl7
    '
    Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl7.Appearance.Options.UseFont = True
    Me.LabelControl7.Appearance.Options.UseForeColor = True
    Me.LabelControl7.Location = New System.Drawing.Point(830, 41)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(6, 14)
    Me.LabelControl7.TabIndex = 13
    Me.LabelControl7.Text = "a"
    '
    'datEndDateOT
    '
    Me.datEndDateOT.EditValue = Nothing
    Me.datEndDateOT.Location = New System.Drawing.Point(851, 38)
    Me.datEndDateOT.MenuManager = Me.BarManager1
    Me.datEndDateOT.Name = "datEndDateOT"
    Me.datEndDateOT.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datEndDateOT.Properties.Appearance.Options.UseFont = True
    Me.datEndDateOT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datEndDateOT.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datEndDateOT.Properties.NullDate = New Date(CType(0, Long))
    Me.datEndDateOT.Size = New System.Drawing.Size(90, 20)
    Me.datEndDateOT.TabIndex = 12
    '
    'datStartDateOT
    '
    Me.datStartDateOT.EditValue = Nothing
    Me.datStartDateOT.Location = New System.Drawing.Point(730, 38)
    Me.datStartDateOT.MenuManager = Me.BarManager1
    Me.datStartDateOT.Name = "datStartDateOT"
    Me.datStartDateOT.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datStartDateOT.Properties.Appearance.Options.UseFont = True
    Me.datStartDateOT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datStartDateOT.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datStartDateOT.Properties.NullDate = New Date(CType(0, Long))
    Me.datStartDateOT.Size = New System.Drawing.Size(90, 20)
    Me.datStartDateOT.TabIndex = 10
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl5.Appearance.Options.UseFont = True
    Me.LabelControl5.Appearance.Options.UseForeColor = True
    Me.LabelControl5.Location = New System.Drawing.Point(697, 41)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(27, 14)
    Me.LabelControl5.TabIndex = 9
    Me.LabelControl5.Text = "Extra"
    '
    'datEndDateStd
    '
    Me.datEndDateStd.EditValue = Nothing
    Me.datEndDateStd.Location = New System.Drawing.Point(575, 38)
    Me.datEndDateStd.MenuManager = Me.BarManager1
    Me.datEndDateStd.Name = "datEndDateStd"
    Me.datEndDateStd.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datEndDateStd.Properties.Appearance.Options.UseFont = True
    Me.datEndDateStd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datEndDateStd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datEndDateStd.Properties.NullDate = New Date(CType(0, Long))
    Me.datEndDateStd.Size = New System.Drawing.Size(90, 20)
    Me.datEndDateStd.TabIndex = 8
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl4.Appearance.Options.UseFont = True
    Me.LabelControl4.Appearance.Options.UseForeColor = True
    Me.LabelControl4.Location = New System.Drawing.Point(559, 41)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(6, 14)
    Me.LabelControl4.TabIndex = 7
    Me.LabelControl4.Text = "a"
    '
    'datStartDateStd
    '
    Me.datStartDateStd.EditValue = Nothing
    Me.datStartDateStd.Location = New System.Drawing.Point(460, 38)
    Me.datStartDateStd.MenuManager = Me.BarManager1
    Me.datStartDateStd.Name = "datStartDateStd"
    Me.datStartDateStd.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datStartDateStd.Properties.Appearance.Options.UseFont = True
    Me.datStartDateStd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datStartDateStd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datStartDateStd.Properties.NullDate = New Date(CType(0, Long))
    Me.datStartDateStd.Size = New System.Drawing.Size(90, 20)
    Me.datStartDateStd.TabIndex = 6
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Appearance.Options.UseForeColor = True
    Me.LabelControl3.Location = New System.Drawing.Point(405, 41)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(49, 14)
    Me.LabelControl3.TabIndex = 5
    Me.LabelControl3.Text = "Estandar"
    '
    'radPayPeriodType
    '
    Me.radPayPeriodType.Location = New System.Drawing.Point(216, 38)
    Me.radPayPeriodType.MenuManager = Me.BarManager1
    Me.radPayPeriodType.Name = "radPayPeriodType"
    Me.radPayPeriodType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.radPayPeriodType.Properties.Appearance.Options.UseFont = True
    Me.radPayPeriodType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quincena")})
    Me.radPayPeriodType.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
    Me.radPayPeriodType.Size = New System.Drawing.Size(129, 21)
    Me.radPayPeriodType.TabIndex = 4
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Appearance.Options.UseForeColor = True
    Me.LabelControl2.Location = New System.Drawing.Point(9, 41)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(92, 14)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Inicio de Periodo"
    '
    'datPeriodStart
    '
    Me.datPeriodStart.EditValue = Nothing
    Me.datPeriodStart.Location = New System.Drawing.Point(108, 38)
    Me.datPeriodStart.MenuManager = Me.BarManager1
    Me.datPeriodStart.Name = "datPeriodStart"
    Me.datPeriodStart.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datPeriodStart.Properties.Appearance.Options.UseFont = True
    Me.datPeriodStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datPeriodStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datPeriodStart.Properties.NullDate = New Date(CType(0, Long))
    Me.datPeriodStart.Size = New System.Drawing.Size(90, 20)
    Me.datPeriodStart.TabIndex = 2
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(9, 76)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(54, 14)
    Me.LabelControl1.TabIndex = 1
    Me.LabelControl1.Text = "Empleado"
    '
    'ComboBoxEdit1
    '
    Me.ComboBoxEdit1.Location = New System.Drawing.Point(108, 73)
    Me.ComboBoxEdit1.MenuManager = Me.BarManager1
    Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
    Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
    Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.ComboBoxEdit1.Size = New System.Drawing.Size(237, 20)
    Me.ComboBoxEdit1.TabIndex = 0
    '
    'frmPaySlipDetails
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1051, 557)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmPaySlipDetails"
    Me.Text = "Hoja de Pago"
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    CType(Me.grdPaySlipItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvPaySlipItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpPeriodAndEmployee, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpPeriodAndEmployee.ResumeLayout(False)
    Me.grpPeriodAndEmployee.PerformLayout()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datEndDateOT.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datEndDateOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datStartDateOT.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datStartDateOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datEndDateStd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datEndDateStd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datStartDateStd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datStartDateStd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.radPayPeriodType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datPeriodStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datPeriodStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
  Friend WithEvents BarEditItem5 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdPaySlipItems As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvPaySlipItems As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStandardHrs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStandardPay As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOTHrs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOTPay As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcTotalPay As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents grpPeriodAndEmployee As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents datEndDateOT As DevExpress.XtraEditors.DateEdit
  Friend WithEvents datStartDateOT As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents datEndDateStd As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents datStartDateStd As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents radPayPeriodType As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents datPeriodStart As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
End Class
