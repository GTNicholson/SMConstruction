<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhaseManagement
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
    Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhaseManagement))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.bbtnReload = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grdSOPMilestoneStatuses = New DevExpress.XtraGrid.GridControl()
        Me.gvSOPMilestoneStatuses = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.gcPlannedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcQtyOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOrderReceivedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.gcProducyCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcProcurementGroupDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDespatchStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOrderReceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gcConfirmationOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcHandover = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcEngineering = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCarpinteria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMetal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTapizado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcEmpaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDeliveryUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDeliveryToSiteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPurchasing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAdvance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMadera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTejido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAcabado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcLija = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInstallation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repitcboColour = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdSOPMilestoneStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSOPMilestoneStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repitcboColour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1470, 734)
        Me.XtraTabControl1.TabIndex = 91
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1462, 705)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.bbtnReload)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.grdSOPMilestoneStatuses)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1462, 705)
        Me.PanelControl1.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Location = New System.Drawing.Point(980, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(62, 23)
        Me.btnExport.TabIndex = 156
        Me.btnExport.Text = "Exportar"
        '
        'bbtnReload
        '
        Me.bbtnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bbtnReload.Location = New System.Drawing.Point(912, 13)
        Me.bbtnReload.Name = "bbtnReload"
        Me.bbtnReload.Size = New System.Drawing.Size(62, 23)
        Me.bbtnReload.TabIndex = 155
        Me.bbtnReload.Text = "Recargar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(1048, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(408, 41)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "KEY"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl1.Location = New System.Drawing.Point(121, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 22)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "No Requerido"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.Color.YellowGreen
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseBackColor = True
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl10.Location = New System.Drawing.Point(309, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 22)
        Me.LabelControl10.TabIndex = 5
        Me.LabelControl10.Text = "Completo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Gold
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl6.Location = New System.Drawing.Point(215, 9)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(88, 22)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "En Proceso"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Tomato
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Location = New System.Drawing.Point(26, 9)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 22)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Atrasado"
        '
        'grdSOPMilestoneStatuses
        '
        Me.grdSOPMilestoneStatuses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSOPMilestoneStatuses.Location = New System.Drawing.Point(2, 2)
        Me.grdSOPMilestoneStatuses.MainView = Me.gvSOPMilestoneStatuses
        Me.grdSOPMilestoneStatuses.Name = "grdSOPMilestoneStatuses"
        Me.grdSOPMilestoneStatuses.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2, Me.RepositoryItemMemoEdit1, Me.repitcboColour, Me.RepositoryItemDateEdit1})
        Me.grdSOPMilestoneStatuses.Size = New System.Drawing.Size(1458, 703)
        Me.grdSOPMilestoneStatuses.TabIndex = 85
        Me.grdSOPMilestoneStatuses.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSOPMilestoneStatuses})
        '
        'gvSOPMilestoneStatuses
        '
        Me.gvSOPMilestoneStatuses.Appearance.GroupFooter.Options.UseTextOptions = True
        Me.gvSOPMilestoneStatuses.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvSOPMilestoneStatuses.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvSOPMilestoneStatuses.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSOPMilestoneStatuses.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvSOPMilestoneStatuses.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvSOPMilestoneStatuses.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvSOPMilestoneStatuses.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSOPMilestoneStatuses.Appearance.Row.Options.UseFont = True
        Me.gvSOPMilestoneStatuses.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvSOPMilestoneStatuses.Appearance.ViewCaption.Options.UseFont = True
        Me.gvSOPMilestoneStatuses.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvSOPMilestoneStatuses.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvSOPMilestoneStatuses.ColumnPanelRowHeight = 45
        Me.gvSOPMilestoneStatuses.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcDueDate, Me.gcPlannedDate, Me.GridColumn1, Me.gcProjectName, Me.gcCustomer, Me.gcValue, Me.gcQtyOT, Me.gcOrderStatus, Me.gcOrderReceivedDate, Me.gcProducyCategory, Me.gcProcurementGroupDate, Me.gcDespatchStatus, Me.gcOrderReceived, Me.gcConfirmationOrder, Me.gcHandover, Me.gcEngineering, Me.gcCarpinteria, Me.gcMetal, Me.gcTapizado, Me.gcEmpaque, Me.gcDeliveryUpdate, Me.gcDeliveryToSiteDate, Me.gcPurchasing, Me.gcAdvance, Me.gcMadera, Me.gcTejido, Me.gcAcabado, Me.gcLija, Me.gcInstallation})
        Me.gvSOPMilestoneStatuses.DetailHeight = 400
        Me.gvSOPMilestoneStatuses.GridControl = Me.grdSOPMilestoneStatuses
        Me.gvSOPMilestoneStatuses.GroupCount = 1
        Me.gvSOPMilestoneStatuses.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", Me.gcValue, "{0:c2}")})
        Me.gvSOPMilestoneStatuses.Name = "gvSOPMilestoneStatuses"
        Me.gvSOPMilestoneStatuses.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvSOPMilestoneStatuses.OptionsView.ColumnAutoWidth = False
        Me.gvSOPMilestoneStatuses.OptionsView.ShowAutoFilterRow = True
        Me.gvSOPMilestoneStatuses.OptionsView.ShowDetailButtons = False
        Me.gvSOPMilestoneStatuses.OptionsView.ShowGroupPanel = False
        Me.gvSOPMilestoneStatuses.OptionsView.ShowViewCaption = True
        Me.gvSOPMilestoneStatuses.RowHeight = 45
        Me.gvSOPMilestoneStatuses.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcProducyCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvSOPMilestoneStatuses.ViewCaption = "Interfaz de Seguimiento de Proyecto"
        Me.gvSOPMilestoneStatuses.ViewCaptionHeight = 50
        '
        'gcDueDate
        '
        Me.gcDueDate.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcDueDate.AppearanceCell.Options.UseBackColor = True
        Me.gcDueDate.Caption = "Fecha Requerida"
        Me.gcDueDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.gcDueDate.FieldName = "DateRequired"
        Me.gcDueDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcDueDate.Name = "gcDueDate"
        Me.gcDueDate.Visible = True
        Me.gcDueDate.VisibleIndex = 4
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.NullDate = New Date(CType(0, Long))
        '
        'gcPlannedDate
        '
        Me.gcPlannedDate.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcPlannedDate.AppearanceCell.Options.UseBackColor = True
        Me.gcPlannedDate.Caption = "Fecha Planificada"
        Me.gcPlannedDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.gcPlannedDate.FieldName = "FirstDatePlanned"
        Me.gcPlannedDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcPlannedDate.Name = "gcPlannedDate"
        Me.gcPlannedDate.OptionsColumn.AllowEdit = False
        Me.gcPlannedDate.OptionsColumn.ReadOnly = True
        Me.gcPlannedDate.Visible = True
        Me.gcPlannedDate.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "# Orden"
        Me.GridColumn1.FieldName = "OrderNo"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 83
        '
        'gcProjectName
        '
        Me.gcProjectName.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcProjectName.AppearanceCell.Options.UseBackColor = True
        Me.gcProjectName.Caption = "Proyecto"
        Me.gcProjectName.FieldName = "ProjectName"
        Me.gcProjectName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcProjectName.Name = "gcProjectName"
        Me.gcProjectName.OptionsColumn.AllowEdit = False
        Me.gcProjectName.OptionsColumn.ReadOnly = True
        Me.gcProjectName.Visible = True
        Me.gcProjectName.VisibleIndex = 1
        Me.gcProjectName.Width = 220
        '
        'gcCustomer
        '
        Me.gcCustomer.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcCustomer.AppearanceCell.Options.UseBackColor = True
        Me.gcCustomer.Caption = "Cliente"
        Me.gcCustomer.FieldName = "CompanyName"
        Me.gcCustomer.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcCustomer.Name = "gcCustomer"
        Me.gcCustomer.Visible = True
        Me.gcCustomer.VisibleIndex = 2
        Me.gcCustomer.Width = 92
        '
        'gcValue
        '
        Me.gcValue.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcValue.AppearanceCell.Options.UseBackColor = True
        Me.gcValue.Caption = "Valor Venta"
        Me.gcValue.DisplayFormat.FormatString = "c2"
        Me.gcValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValue.FieldName = "TotalPrice"
        Me.gcValue.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcValue.GroupFormat.FormatString = "C2"
        Me.gcValue.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValue.Name = "gcValue"
        Me.gcValue.OptionsColumn.AllowEdit = False
        Me.gcValue.OptionsColumn.ReadOnly = True
        Me.gcValue.OptionsFilter.PopupExcelFilterNumericValuesTabFilterType = DevExpress.XtraGrid.Columns.ExcelFilterNumericValuesTabFilterType.List
        Me.gcValue.Width = 67
        '
        'gcQtyOT
        '
        Me.gcQtyOT.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcQtyOT.AppearanceCell.Options.UseBackColor = True
        Me.gcQtyOT.Caption = "Cant. OTs"
        Me.gcQtyOT.DisplayFormat.FormatString = "N0"
        Me.gcQtyOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcQtyOT.FieldName = "QtyOT"
        Me.gcQtyOT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcQtyOT.GroupFormat.FormatString = "N0"
        Me.gcQtyOT.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcQtyOT.Name = "gcQtyOT"
        Me.gcQtyOT.OptionsColumn.AllowEdit = False
        Me.gcQtyOT.OptionsColumn.ReadOnly = True
        Me.gcQtyOT.OptionsFilter.PopupExcelFilterNumericValuesTabFilterType = DevExpress.XtraGrid.Columns.ExcelFilterNumericValuesTabFilterType.List
        Me.gcQtyOT.Visible = True
        Me.gcQtyOT.VisibleIndex = 5
        '
        'gcOrderStatus
        '
        Me.gcOrderStatus.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcOrderStatus.AppearanceCell.Options.UseBackColor = True
        Me.gcOrderStatus.Caption = "PM Status"
        Me.gcOrderStatus.FieldName = "OrderStatusDesc"
        Me.gcOrderStatus.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcOrderStatus.Name = "gcOrderStatus"
        '
        'gcOrderReceivedDate
        '
        Me.gcOrderReceivedDate.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcOrderReceivedDate.AppearanceCell.Options.UseBackColor = True
        Me.gcOrderReceivedDate.Caption = "Orden Recibida"
        Me.gcOrderReceivedDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.gcOrderReceivedDate.FieldName = "gcOrderReceivedDate"
        Me.gcOrderReceivedDate.Name = "gcOrderReceivedDate"
        Me.gcOrderReceivedDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'gcProducyCategory
        '
        Me.gcProducyCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcProducyCategory.AppearanceCell.Options.UseBackColor = True
        Me.gcProducyCategory.Caption = "Tipo de Venta"
        Me.gcProducyCategory.FieldName = "OrderTypeDesc"
        Me.gcProducyCategory.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcProducyCategory.Name = "gcProducyCategory"
        Me.gcProducyCategory.Visible = True
        Me.gcProducyCategory.VisibleIndex = 4
        '
        'gcProcurementGroupDate
        '
        Me.gcProcurementGroupDate.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcProcurementGroupDate.AppearanceCell.Options.UseBackColor = True
        Me.gcProcurementGroupDate.Caption = "Semana"
        Me.gcProcurementGroupDate.FieldName = "MilestoneGroupDate"
        Me.gcProcurementGroupDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcProcurementGroupDate.Name = "gcProcurementGroupDate"
        '
        'gcDespatchStatus
        '
        Me.gcDespatchStatus.Caption = "Desp. Status"
        Me.gcDespatchStatus.FieldName = "DespatchStatusDesc"
        Me.gcDespatchStatus.Name = "gcDespatchStatus"
        '
        'gcOrderReceived
        '
        Me.gcOrderReceived.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcOrderReceived.AppearanceCell.Options.UseBackColor = True
        Me.gcOrderReceived.AppearanceCell.Options.UseTextOptions = True
        Me.gcOrderReceived.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcOrderReceived.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcOrderReceived.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcOrderReceived.Caption = "Order Received"
        Me.gcOrderReceived.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcOrderReceived.DisplayFormat.FormatString = "dd-MM"
        Me.gcOrderReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcOrderReceived.FieldName = "ubTechAssessmentComplete"
        Me.gcOrderReceived.Name = "gcOrderReceived"
        Me.gcOrderReceived.OptionsColumn.AllowEdit = False
        Me.gcOrderReceived.OptionsFilter.AllowAutoFilter = False
        Me.gcOrderReceived.OptionsFilter.AllowFilter = False
        Me.gcOrderReceived.Tag = 1
        Me.gcOrderReceived.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcOrderReceived.Width = 76
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'gcConfirmationOrder
        '
        Me.gcConfirmationOrder.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcConfirmationOrder.AppearanceCell.Options.UseBackColor = True
        Me.gcConfirmationOrder.AppearanceCell.Options.UseTextOptions = True
        Me.gcConfirmationOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcConfirmationOrder.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcConfirmationOrder.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcConfirmationOrder.Caption = "Confirmación de Orden"
        Me.gcConfirmationOrder.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcConfirmationOrder.DisplayFormat.FormatString = "dd-MM"
        Me.gcConfirmationOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcConfirmationOrder.FieldName = "ub_gcConfirmationOrder"
        Me.gcConfirmationOrder.Name = "gcConfirmationOrder"
        Me.gcConfirmationOrder.OptionsColumn.AllowEdit = False
        Me.gcConfirmationOrder.OptionsFilter.AllowAutoFilter = False
        Me.gcConfirmationOrder.Tag = 2
        Me.gcConfirmationOrder.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcConfirmationOrder.Visible = True
        Me.gcConfirmationOrder.VisibleIndex = 7
        Me.gcConfirmationOrder.Width = 94
        '
        'gcHandover
        '
        Me.gcHandover.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcHandover.AppearanceCell.Options.UseBackColor = True
        Me.gcHandover.AppearanceCell.Options.UseTextOptions = True
        Me.gcHandover.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcHandover.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcHandover.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcHandover.Caption = "Entrega Información"
        Me.gcHandover.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcHandover.DisplayFormat.FormatString = "dd-MM"
        Me.gcHandover.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcHandover.FieldName = "ub_Handover"
        Me.gcHandover.Name = "gcHandover"
        Me.gcHandover.OptionsColumn.AllowEdit = False
        Me.gcHandover.OptionsFilter.AllowAutoFilter = False
        Me.gcHandover.Tag = 3
        Me.gcHandover.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcHandover.Visible = True
        Me.gcHandover.VisibleIndex = 8
        Me.gcHandover.Width = 93
        '
        'gcEngineering
        '
        Me.gcEngineering.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcEngineering.AppearanceCell.Options.UseBackColor = True
        Me.gcEngineering.AppearanceCell.Options.UseTextOptions = True
        Me.gcEngineering.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEngineering.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcEngineering.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcEngineering.Caption = "Ingeniería"
        Me.gcEngineering.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcEngineering.DisplayFormat.FormatString = "dd-MM"
        Me.gcEngineering.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcEngineering.FieldName = "ub_gcEngineering"
        Me.gcEngineering.Name = "gcEngineering"
        Me.gcEngineering.OptionsColumn.AllowEdit = False
        Me.gcEngineering.OptionsFilter.AllowAutoFilter = False
        Me.gcEngineering.Tag = 4
        Me.gcEngineering.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcEngineering.Visible = True
        Me.gcEngineering.VisibleIndex = 9
        Me.gcEngineering.Width = 83
        '
        'gcCarpinteria
        '
        Me.gcCarpinteria.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcCarpinteria.AppearanceCell.Options.UseBackColor = True
        Me.gcCarpinteria.AppearanceCell.Options.UseTextOptions = True
        Me.gcCarpinteria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcCarpinteria.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcCarpinteria.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcCarpinteria.Caption = "Carpintería"
        Me.gcCarpinteria.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcCarpinteria.DisplayFormat.FormatString = "dd-MM"
        Me.gcCarpinteria.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcCarpinteria.FieldName = "ub_gcCarpinteria"
        Me.gcCarpinteria.Name = "gcCarpinteria"
        Me.gcCarpinteria.OptionsColumn.AllowEdit = False
        Me.gcCarpinteria.OptionsFilter.AllowAutoFilter = False
        Me.gcCarpinteria.Tag = 6
        Me.gcCarpinteria.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcCarpinteria.Visible = True
        Me.gcCarpinteria.VisibleIndex = 12
        Me.gcCarpinteria.Width = 87
        '
        'gcMetal
        '
        Me.gcMetal.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcMetal.AppearanceCell.Options.UseBackColor = True
        Me.gcMetal.AppearanceCell.Options.UseTextOptions = True
        Me.gcMetal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMetal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcMetal.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcMetal.Caption = "Metales"
        Me.gcMetal.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcMetal.DisplayFormat.FormatString = "dd-MM"
        Me.gcMetal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcMetal.FieldName = "ub_gcMetal"
        Me.gcMetal.Name = "gcMetal"
        Me.gcMetal.OptionsColumn.AllowEdit = False
        Me.gcMetal.OptionsFilter.AllowAutoFilter = False
        Me.gcMetal.Tag = CType(7, Short)
        Me.gcMetal.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMetal.Visible = True
        Me.gcMetal.VisibleIndex = 13
        Me.gcMetal.Width = 89
        '
        'gcTapizado
        '
        Me.gcTapizado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcTapizado.AppearanceCell.Options.UseBackColor = True
        Me.gcTapizado.AppearanceCell.Options.UseTextOptions = True
        Me.gcTapizado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTapizado.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcTapizado.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcTapizado.Caption = "Tapizado"
        Me.gcTapizado.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcTapizado.DisplayFormat.FormatString = "dd-MM"
        Me.gcTapizado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcTapizado.FieldName = "ub_Tapizado"
        Me.gcTapizado.Name = "gcTapizado"
        Me.gcTapizado.OptionsColumn.AllowEdit = False
        Me.gcTapizado.OptionsFilter.AllowAutoFilter = False
        Me.gcTapizado.Tag = CType(8, Short)
        Me.gcTapizado.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcTapizado.Visible = True
        Me.gcTapizado.VisibleIndex = 14
        Me.gcTapizado.Width = 103
        '
        'gcEmpaque
        '
        Me.gcEmpaque.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcEmpaque.AppearanceCell.Options.UseBackColor = True
        Me.gcEmpaque.AppearanceCell.Options.UseTextOptions = True
        Me.gcEmpaque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEmpaque.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcEmpaque.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcEmpaque.Caption = "Empaque"
        Me.gcEmpaque.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcEmpaque.DisplayFormat.FormatString = "dd-MM"
        Me.gcEmpaque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcEmpaque.FieldName = "ub_NBSSpec"
        Me.gcEmpaque.Name = "gcEmpaque"
        Me.gcEmpaque.OptionsColumn.AllowEdit = False
        Me.gcEmpaque.OptionsFilter.AllowAutoFilter = False
        Me.gcEmpaque.Tag = 9
        Me.gcEmpaque.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcEmpaque.Visible = True
        Me.gcEmpaque.VisibleIndex = 18
        Me.gcEmpaque.Width = 79
        '
        'gcDeliveryUpdate
        '
        Me.gcDeliveryUpdate.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcDeliveryUpdate.AppearanceCell.Options.UseBackColor = True
        Me.gcDeliveryUpdate.AppearanceCell.Options.UseTextOptions = True
        Me.gcDeliveryUpdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDeliveryUpdate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcDeliveryUpdate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcDeliveryUpdate.Caption = "Delivery Update"
        Me.gcDeliveryUpdate.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcDeliveryUpdate.DisplayFormat.FormatString = "dd-MM"
        Me.gcDeliveryUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcDeliveryUpdate.FieldName = "ub_DeliveryUpdate"
        Me.gcDeliveryUpdate.Name = "gcDeliveryUpdate"
        Me.gcDeliveryUpdate.OptionsColumn.AllowEdit = False
        Me.gcDeliveryUpdate.OptionsFilter.AllowAutoFilter = False
        Me.gcDeliveryUpdate.Tag = CType(15, Short)
        Me.gcDeliveryUpdate.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcDeliveryUpdate.Width = 115
        '
        'gcDeliveryToSiteDate
        '
        Me.gcDeliveryToSiteDate.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcDeliveryToSiteDate.AppearanceCell.Options.UseBackColor = True
        Me.gcDeliveryToSiteDate.AppearanceCell.Options.UseTextOptions = True
        Me.gcDeliveryToSiteDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDeliveryToSiteDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcDeliveryToSiteDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcDeliveryToSiteDate.Caption = "Entrega al Cliente"
        Me.gcDeliveryToSiteDate.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcDeliveryToSiteDate.DisplayFormat.FormatString = "dd-MM"
        Me.gcDeliveryToSiteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcDeliveryToSiteDate.FieldName = "ub_DeliveryToSite"
        Me.gcDeliveryToSiteDate.Name = "gcDeliveryToSiteDate"
        Me.gcDeliveryToSiteDate.OptionsColumn.AllowEdit = False
        Me.gcDeliveryToSiteDate.OptionsFilter.AllowAutoFilter = False
        Me.gcDeliveryToSiteDate.Tag = CType(19, Short)
        Me.gcDeliveryToSiteDate.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'gcPurchasing
        '
        Me.gcPurchasing.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcPurchasing.AppearanceCell.Options.UseBackColor = True
        Me.gcPurchasing.AppearanceCell.Options.UseTextOptions = True
        Me.gcPurchasing.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcPurchasing.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcPurchasing.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPurchasing.Caption = "Compras"
        Me.gcPurchasing.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcPurchasing.DisplayFormat.FormatString = "dd-MM"
        Me.gcPurchasing.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcPurchasing.FieldName = "ub_gcPurchasing"
        Me.gcPurchasing.Name = "gcPurchasing"
        Me.gcPurchasing.OptionsColumn.AllowEdit = False
        Me.gcPurchasing.OptionsFilter.AllowAutoFilter = False
        Me.gcPurchasing.Tag = 5
        Me.gcPurchasing.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcPurchasing.Visible = True
        Me.gcPurchasing.VisibleIndex = 10
        Me.gcPurchasing.Width = 83
        '
        'gcAdvance
        '
        Me.gcAdvance.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcAdvance.AppearanceCell.Options.UseBackColor = True
        Me.gcAdvance.Caption = "% Avance"
        Me.gcAdvance.DisplayFormat.FormatString = "P2"
        Me.gcAdvance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcAdvance.FieldName = "gcAdvance"
        Me.gcAdvance.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcAdvance.Name = "gcAdvance"
        Me.gcAdvance.OptionsColumn.AllowEdit = False
        Me.gcAdvance.OptionsColumn.ReadOnly = True
        Me.gcAdvance.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.gcAdvance.Visible = True
        Me.gcAdvance.VisibleIndex = 6
        '
        'gcMadera
        '
        Me.gcMadera.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcMadera.AppearanceCell.Options.UseBackColor = True
        Me.gcMadera.AppearanceCell.Options.UseTextOptions = True
        Me.gcMadera.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMadera.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcMadera.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcMadera.Caption = "Madera"
        Me.gcMadera.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcMadera.DisplayFormat.FormatString = "dd-MM"
        Me.gcMadera.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcMadera.FieldName = "gcMadera"
        Me.gcMadera.Name = "gcMadera"
        Me.gcMadera.OptionsColumn.AllowEdit = False
        Me.gcMadera.OptionsFilter.AllowAutoFilter = False
        Me.gcMadera.Tag = 10
        Me.gcMadera.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMadera.Visible = True
        Me.gcMadera.VisibleIndex = 11
        '
        'gcTejido
        '
        Me.gcTejido.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcTejido.AppearanceCell.Options.UseBackColor = True
        Me.gcTejido.AppearanceCell.Options.UseTextOptions = True
        Me.gcTejido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTejido.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcTejido.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcTejido.Caption = "Tejido"
        Me.gcTejido.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcTejido.DisplayFormat.FormatString = "dd-MM"
        Me.gcTejido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcTejido.FieldName = "gcTejido"
        Me.gcTejido.Name = "gcTejido"
        Me.gcTejido.OptionsColumn.AllowEdit = False
        Me.gcTejido.OptionsFilter.AllowAutoFilter = False
        Me.gcTejido.Tag = 11
        Me.gcTejido.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcTejido.Visible = True
        Me.gcTejido.VisibleIndex = 15
        Me.gcTejido.Width = 70
        '
        'gcAcabado
        '
        Me.gcAcabado.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcAcabado.AppearanceCell.Options.UseBackColor = True
        Me.gcAcabado.AppearanceCell.Options.UseTextOptions = True
        Me.gcAcabado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAcabado.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcAcabado.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcAcabado.Caption = "Acabado"
        Me.gcAcabado.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcAcabado.DisplayFormat.FormatString = "dd-MM"
        Me.gcAcabado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcAcabado.FieldName = "gcAcabado"
        Me.gcAcabado.Name = "gcAcabado"
        Me.gcAcabado.OptionsColumn.AllowEdit = False
        Me.gcAcabado.OptionsFilter.AllowAutoFilter = False
        Me.gcAcabado.Tag = 12
        Me.gcAcabado.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcAcabado.Visible = True
        Me.gcAcabado.VisibleIndex = 17
        Me.gcAcabado.Width = 65
        '
        'gcLija
        '
        Me.gcLija.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcLija.AppearanceCell.Options.UseBackColor = True
        Me.gcLija.AppearanceCell.Options.UseTextOptions = True
        Me.gcLija.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcLija.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcLija.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcLija.Caption = "Lija"
        Me.gcLija.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcLija.DisplayFormat.FormatString = "dd-MM"
        Me.gcLija.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcLija.FieldName = "gcLija"
        Me.gcLija.Name = "gcLija"
        Me.gcLija.OptionsColumn.AllowEdit = False
        Me.gcLija.OptionsFilter.AllowAutoFilter = False
        Me.gcLija.Tag = 13
        Me.gcLija.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcLija.Visible = True
        Me.gcLija.VisibleIndex = 16
        Me.gcLija.Width = 55
        '
        'gcInstallation
        '
        Me.gcInstallation.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcInstallation.AppearanceCell.Options.UseBackColor = True
        Me.gcInstallation.Caption = "Instalación"
        Me.gcInstallation.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcInstallation.DisplayFormat.FormatString = "dd-MM"
        Me.gcInstallation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcInstallation.FieldName = "gcInstallation"
        Me.gcInstallation.Name = "gcInstallation"
        Me.gcInstallation.OptionsColumn.AllowEdit = False
        Me.gcInstallation.OptionsFilter.AllowAutoFilter = False
        Me.gcInstallation.Tag = 14
        Me.gcInstallation.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcInstallation.Visible = True
        Me.gcInstallation.VisibleIndex = 19
        '
        'repitcboColour
        '
        Me.repitcboColour.AutoHeight = False
        Me.repitcboColour.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repitcboColour.Name = "repitcboColour"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(1468, 709)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'frmPhaseManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1204, 700)
        Me.ClientSize = New System.Drawing.Size(1470, 734)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPhaseManagement"
        Me.Text = "Phase Milestone Management"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdSOPMilestoneStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSOPMilestoneStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repitcboColour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents grdSOPMilestoneStatuses As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSOPMilestoneStatuses As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProjectName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPlannedDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents gcDueDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProducyCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOrderReceived As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCarpinteria As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcEngineering As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcConfirmationOrder As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProcurementGroupDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
  Friend WithEvents gcCustomer As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDespatchStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitcboColour As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents gcHandover As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMetal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcTapizado As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcEmpaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDeliveryUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDeliveryToSiteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bbtnReload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcPurchasing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcOrderReceivedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents gcQtyOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents gcAdvance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcMadera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTejido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAcabado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcLija As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInstallation As DevExpress.XtraGrid.Columns.GridColumn
End Class
