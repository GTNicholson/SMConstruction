<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurchaseManagement
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
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barbtnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.barbt_ExportToExcel = New DevExpress.XtraBars.BarButtonItem()
    Me.btogIncludeRecentlyCompleted = New DevExpress.XtraBars.BarToggleSwitchItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
    Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
    Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.grdSOPMatReqStatuses = New DevExpress.XtraGrid.GridControl()
    Me.gvSOPMatReqStatuses = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOTDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcJobNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcQtyCol = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSpecStatusDesc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcProducyCategory = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcDoorBlanks = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
    Me.gcAbrasivos = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcBrickwork = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPlumbing = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcHerrajes = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcVidrioEspejos = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatElect = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatVarios = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatEmpa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcLamina = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcEpp = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcHerramientas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcProcurementGroupDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdSOPMatReqStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSOPMatReqStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnRefresh, Me.barbt_ExportToExcel, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.btogIncludeRecentlyCompleted})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.barbt_ExportToExcel, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btogIncludeRecentlyCompleted)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'barbtnRefresh
        '
        Me.barbtnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbtnRefresh.Caption = "Refrescar"
        Me.barbtnRefresh.Id = 0
        Me.barbtnRefresh.Name = "barbtnRefresh"
        '
        'barbt_ExportToExcel
        '
        Me.barbt_ExportToExcel.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbt_ExportToExcel.Caption = "Exportar a Excel"
        Me.barbt_ExportToExcel.Id = 1
        Me.barbt_ExportToExcel.Name = "barbt_ExportToExcel"
        '
        'btogIncludeRecentlyCompleted
        '
        Me.btogIncludeRecentlyCompleted.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btogIncludeRecentlyCompleted.Caption = "Include Recently Completed"
        Me.btogIncludeRecentlyCompleted.Id = 5
        Me.btogIncludeRecentlyCompleted.Name = "btogIncludeRecentlyCompleted"
        Me.btogIncludeRecentlyCompleted.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1445, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 734)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1445, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 705)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1445, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 705)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Not Required"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "From Stock"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "To Place"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 29)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1445, 705)
        Me.XtraTabControl1.TabIndex = 91
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1437, 676)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.grdSOPMatReqStatuses)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1437, 676)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl26)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(779, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(652, 68)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "LEYENDA"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Pink
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Location = New System.Drawing.Point(341, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "A Ordenar"
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.Options.UseBackColor = True
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Appearance.Options.UseTextOptions = True
        Me.LabelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl26.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl26.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl26.Location = New System.Drawing.Point(237, 24)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl26.TabIndex = 7
        Me.LabelControl26.Text = "De Inventario"
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
        Me.LabelControl1.Location = New System.Drawing.Point(133, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 22)
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
        Me.LabelControl10.Location = New System.Drawing.Point(549, 24)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl10.TabIndex = 5
        Me.LabelControl10.Text = "Recibido"
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
        Me.LabelControl6.Location = New System.Drawing.Point(445, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Ordenes Pedidas"
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
        Me.LabelControl3.Location = New System.Drawing.Point(29, 24)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Pendiente"
        '
        'grdSOPMatReqStatuses
        '
        Me.grdSOPMatReqStatuses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSOPMatReqStatuses.Location = New System.Drawing.Point(2, 2)
        Me.grdSOPMatReqStatuses.MainView = Me.gvSOPMatReqStatuses
        Me.grdSOPMatReqStatuses.Name = "grdSOPMatReqStatuses"
        Me.grdSOPMatReqStatuses.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2, Me.RepositoryItemMemoEdit1})
        Me.grdSOPMatReqStatuses.Size = New System.Drawing.Size(1433, 674)
        Me.grdSOPMatReqStatuses.TabIndex = 85
        Me.grdSOPMatReqStatuses.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSOPMatReqStatuses})
        '
        'gvSOPMatReqStatuses
        '
        Me.gvSOPMatReqStatuses.Appearance.GroupFooter.Options.UseTextOptions = True
        Me.gvSOPMatReqStatuses.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvSOPMatReqStatuses.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvSOPMatReqStatuses.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSOPMatReqStatuses.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvSOPMatReqStatuses.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvSOPMatReqStatuses.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvSOPMatReqStatuses.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSOPMatReqStatuses.Appearance.Row.Options.UseFont = True
        Me.gvSOPMatReqStatuses.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvSOPMatReqStatuses.Appearance.ViewCaption.Options.UseFont = True
        Me.gvSOPMatReqStatuses.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvSOPMatReqStatuses.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvSOPMatReqStatuses.ColumnPanelRowHeight = 45
        Me.gvSOPMatReqStatuses.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn7, Me.GridColumn6, Me.GridColumn1, Me.gcOTDescription, Me.GridColumn2, Me.GridColumn4, Me.gcJobNo, Me.GridColumn5, Me.gcQtyCol, Me.GridColumn8, Me.GridColumn13, Me.gcSpecStatusDesc, Me.gcOrderStatus, Me.gcProducyCategory, Me.gcDoorBlanks, Me.gcAbrasivos, Me.gcBrickwork, Me.gcPlumbing, Me.gcHerrajes, Me.gcVidrioEspejos, Me.gcMatElect, Me.gcMatVarios, Me.gcMatEmpa, Me.gcLamina, Me.gcEpp, Me.gcHerramientas, Me.gcProcurementGroupDate})
        Me.gvSOPMatReqStatuses.GridControl = Me.grdSOPMatReqStatuses
        Me.gvSOPMatReqStatuses.GroupCount = 1
        Me.gvSOPMatReqStatuses.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "QtySetsLeavesFrames", Me.gcQtyCol, "")})
        Me.gvSOPMatReqStatuses.Name = "gvSOPMatReqStatuses"
        Me.gvSOPMatReqStatuses.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvSOPMatReqStatuses.OptionsView.ColumnAutoWidth = False
        Me.gvSOPMatReqStatuses.OptionsView.ShowAutoFilterRow = True
        Me.gvSOPMatReqStatuses.OptionsView.ShowDetailButtons = False
        Me.gvSOPMatReqStatuses.OptionsView.ShowGroupPanel = False
        Me.gvSOPMatReqStatuses.OptionsView.ShowViewCaption = True
        Me.gvSOPMatReqStatuses.RowHeight = 34
        Me.gvSOPMatReqStatuses.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcProcurementGroupDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvSOPMatReqStatuses.ViewCaption = "Interfaz de Gestión de Compras"
        Me.gvSOPMatReqStatuses.ViewCaptionHeight = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.Caption = "Date Required"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn3.FieldName = "DateRequired"
        Me.GridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn3.Name = "GridColumn3"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.NullDate = New Date(CType(0, Long))
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.Caption = "Fecha Inicio OT."
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn7.FieldName = "PlannedStartDate"
        Me.GridColumn7.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.Caption = "Fecha Req. Compra"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn6.FieldName = "PurchasingDate"
        Me.GridColumn6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.Caption = "# O.T."
        Me.GridColumn1.FieldName = "WorkOrderNo"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 140
        '
        'gcOTDescription
        '
        Me.gcOTDescription.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcOTDescription.AppearanceCell.Options.UseBackColor = True
        Me.gcOTDescription.Caption = "Descripción"
        Me.gcOTDescription.FieldName = "Description"
        Me.gcOTDescription.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcOTDescription.Name = "gcOTDescription"
        Me.gcOTDescription.OptionsColumn.ReadOnly = True
        Me.gcOTDescription.Visible = True
        Me.gcOTDescription.VisibleIndex = 1
        Me.gcOTDescription.Width = 202
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.Caption = "Factory Lister"
        Me.GridColumn2.FieldName = "ContractLister"
        Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Width = 85
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.Caption = "Proyecto"
        Me.GridColumn4.FieldName = "ProjectName"
        Me.GridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 179
        '
        'gcJobNo
        '
        Me.gcJobNo.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcJobNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gcJobNo.AppearanceCell.Options.UseBackColor = True
        Me.gcJobNo.AppearanceCell.Options.UseFont = True
        Me.gcJobNo.Caption = "# Venta"
        Me.gcJobNo.FieldName = "OrderNo"
        Me.gcJobNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcJobNo.Name = "gcJobNo"
        Me.gcJobNo.OptionsColumn.ReadOnly = True
        Me.gcJobNo.Visible = True
        Me.gcJobNo.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.Caption = "Valor"
        Me.GridColumn5.DisplayFormat.FormatString = "c2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "TotalPrice"
        Me.GridColumn5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn5.GroupFormat.FormatString = "C2"
        Me.GridColumn5.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.OptionsFilter.PopupExcelFilterNumericValuesTabFilterType = DevExpress.XtraGrid.Columns.ExcelFilterNumericValuesTabFilterType.List
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 67
        '
        'gcQtyCol
        '
        Me.gcQtyCol.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcQtyCol.AppearanceCell.Options.UseBackColor = True
        Me.gcQtyCol.AppearanceCell.Options.UseTextOptions = True
        Me.gcQtyCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcQtyCol.AppearanceHeader.Options.UseTextOptions = True
        Me.gcQtyCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcQtyCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcQtyCol.Caption = "Qty Sets / Leaves / Frames"
        Me.gcQtyCol.FieldName = "QtySetsLeavesFrames"
        Me.gcQtyCol.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcQtyCol.Name = "gcQtyCol"
        Me.gcQtyCol.OptionsColumn.AllowEdit = False
        Me.gcQtyCol.OptionsColumn.ReadOnly = True
        Me.gcQtyCol.Width = 104
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.Caption = "Due Date"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn8.FieldName = "CompletionDueDate"
        Me.GridColumn8.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn13.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn13.Caption = "Enc. Proyecto"
        Me.GridColumn13.FieldName = "ContractManagerDesc"
        Me.GridColumn13.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 80
        '
        'gcSpecStatusDesc
        '
        Me.gcSpecStatusDesc.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcSpecStatusDesc.AppearanceCell.Options.UseBackColor = True
        Me.gcSpecStatusDesc.Caption = "Proj. Mgnt."
        Me.gcSpecStatusDesc.FieldName = "SpecStatusDesc"
        Me.gcSpecStatusDesc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcSpecStatusDesc.Name = "gcSpecStatusDesc"
        '
        'gcOrderStatus
        '
        Me.gcOrderStatus.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcOrderStatus.AppearanceCell.Options.UseBackColor = True
        Me.gcOrderStatus.Caption = "Order Status"
        Me.gcOrderStatus.FieldName = "OrderStatusDesc"
        Me.gcOrderStatus.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcOrderStatus.Name = "gcOrderStatus"
        '
        'gcProducyCategory
        '
        Me.gcProducyCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcProducyCategory.AppearanceCell.Options.UseBackColor = True
        Me.gcProducyCategory.Caption = "Prod. Category"
        Me.gcProducyCategory.FieldName = "ProductCategoryDesc"
        Me.gcProducyCategory.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcProducyCategory.Name = "gcProducyCategory"
        '
        'gcDoorBlanks
        '
        Me.gcDoorBlanks.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcDoorBlanks.AppearanceCell.Options.UseBackColor = True
        Me.gcDoorBlanks.AppearanceCell.Options.UseTextOptions = True
        Me.gcDoorBlanks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDoorBlanks.Caption = "Sist. Fijación"
        Me.gcDoorBlanks.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcDoorBlanks.FieldName = "DoorBlanksMatReqStatus"
        Me.gcDoorBlanks.Name = "gcDoorBlanks"
        Me.gcDoorBlanks.OptionsColumn.AllowEdit = False
        Me.gcDoorBlanks.Tag = 2
        Me.gcDoorBlanks.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcDoorBlanks.Visible = True
        Me.gcDoorBlanks.VisibleIndex = 8
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'gcAbrasivos
        '
        Me.gcAbrasivos.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcAbrasivos.AppearanceCell.Options.UseBackColor = True
        Me.gcAbrasivos.AppearanceCell.Options.UseTextOptions = True
        Me.gcAbrasivos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAbrasivos.Caption = "Abrasivos"
        Me.gcAbrasivos.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcAbrasivos.FieldName = "FacingMatReqStatus"
        Me.gcAbrasivos.Name = "gcAbrasivos"
        Me.gcAbrasivos.OptionsColumn.AllowEdit = False
        Me.gcAbrasivos.Tag = 1
        Me.gcAbrasivos.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcAbrasivos.Visible = True
        Me.gcAbrasivos.VisibleIndex = 9
        '
        'gcBrickwork
        '
        Me.gcBrickwork.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcBrickwork.AppearanceCell.Options.UseBackColor = True
        Me.gcBrickwork.AppearanceCell.Options.UseTextOptions = True
        Me.gcBrickwork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcBrickwork.Caption = "Albañilería"
        Me.gcBrickwork.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcBrickwork.FieldName = "IronmongeryMatReqStatus"
        Me.gcBrickwork.Name = "gcBrickwork"
        Me.gcBrickwork.OptionsColumn.AllowEdit = False
        Me.gcBrickwork.Tag = 17
        Me.gcBrickwork.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcBrickwork.Visible = True
        Me.gcBrickwork.VisibleIndex = 10
        '
        'gcPlumbing
        '
        Me.gcPlumbing.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcPlumbing.AppearanceCell.Options.UseBackColor = True
        Me.gcPlumbing.AppearanceCell.Options.UseTextOptions = True
        Me.gcPlumbing.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcPlumbing.Caption = "Plomería"
        Me.gcPlumbing.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcPlumbing.FieldName = "GlassMatReqStatus"
        Me.gcPlumbing.Name = "gcPlumbing"
        Me.gcPlumbing.OptionsColumn.AllowEdit = False
        Me.gcPlumbing.Tag = 16
        Me.gcPlumbing.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcPlumbing.Visible = True
        Me.gcPlumbing.VisibleIndex = 11
        '
        'gcHerrajes
        '
        Me.gcHerrajes.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcHerrajes.AppearanceCell.Options.UseBackColor = True
        Me.gcHerrajes.AppearanceCell.Options.UseTextOptions = True
        Me.gcHerrajes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcHerrajes.Caption = "Herrajes"
        Me.gcHerrajes.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcHerrajes.FieldName = "IntumescentMatReqStatus"
        Me.gcHerrajes.Name = "gcHerrajes"
        Me.gcHerrajes.OptionsColumn.AllowEdit = False
        Me.gcHerrajes.Tag = 4
        Me.gcHerrajes.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcHerrajes.Visible = True
        Me.gcHerrajes.VisibleIndex = 12
        '
        'gcVidrioEspejos
        '
        Me.gcVidrioEspejos.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcVidrioEspejos.AppearanceCell.Options.UseBackColor = True
        Me.gcVidrioEspejos.AppearanceCell.Options.UseTextOptions = True
        Me.gcVidrioEspejos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcVidrioEspejos.Caption = "Vidrios y Espejos"
        Me.gcVidrioEspejos.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcVidrioEspejos.FieldName = "BeadMatReqStatus"
        Me.gcVidrioEspejos.Name = "gcVidrioEspejos"
        Me.gcVidrioEspejos.OptionsColumn.AllowEdit = False
        Me.gcVidrioEspejos.Tag = 14
        Me.gcVidrioEspejos.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcVidrioEspejos.Visible = True
        Me.gcVidrioEspejos.VisibleIndex = 13
        '
        'gcMatElect
        '
        Me.gcMatElect.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcMatElect.AppearanceCell.Options.UseBackColor = True
        Me.gcMatElect.AppearanceCell.Options.UseTextOptions = True
        Me.gcMatElect.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMatElect.Caption = "Mat. Elect."
        Me.gcMatElect.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcMatElect.FieldName = "FinishMatReqStatus"
        Me.gcMatElect.Name = "gcMatElect"
        Me.gcMatElect.OptionsColumn.AllowEdit = False
        Me.gcMatElect.Tag = 6
        Me.gcMatElect.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMatElect.Visible = True
        Me.gcMatElect.VisibleIndex = 14
        '
        'gcMatVarios
        '
        Me.gcMatVarios.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcMatVarios.AppearanceCell.Options.UseBackColor = True
        Me.gcMatVarios.AppearanceCell.Options.UseTextOptions = True
        Me.gcMatVarios.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMatVarios.Caption = "Mat. Varios"
        Me.gcMatVarios.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcMatVarios.FieldName = "DoorLipMatReqStatus"
        Me.gcMatVarios.Name = "gcMatVarios"
        Me.gcMatVarios.OptionsColumn.AllowEdit = False
        Me.gcMatVarios.Tag = 8
        Me.gcMatVarios.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMatVarios.Visible = True
        Me.gcMatVarios.VisibleIndex = 15
        '
        'gcMatEmpa
        '
        Me.gcMatEmpa.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcMatEmpa.AppearanceCell.Options.UseBackColor = True
        Me.gcMatEmpa.AppearanceCell.Options.UseTextOptions = True
        Me.gcMatEmpa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMatEmpa.Caption = "Mat. Empaque"
        Me.gcMatEmpa.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcMatEmpa.FieldName = "DoorProductsMatReqStatus"
        Me.gcMatEmpa.Name = "gcMatEmpa"
        Me.gcMatEmpa.OptionsColumn.AllowEdit = False
        Me.gcMatEmpa.Tag = 7
        Me.gcMatEmpa.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMatEmpa.Visible = True
        Me.gcMatEmpa.VisibleIndex = 16
        '
        'gcLamina
        '
        Me.gcLamina.AppearanceCell.Options.UseTextOptions = True
        Me.gcLamina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcLamina.Caption = "Laminas"
        Me.gcLamina.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcLamina.FieldName = "TimberComponentMatReqStatus"
        Me.gcLamina.Name = "gcLamina"
        Me.gcLamina.OptionsColumn.AllowEdit = False
        Me.gcLamina.Tag = 11
        Me.gcLamina.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcLamina.Visible = True
        Me.gcLamina.VisibleIndex = 18
        '
        'gcEpp
        '
        Me.gcEpp.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcEpp.AppearanceCell.Options.UseBackColor = True
        Me.gcEpp.AppearanceCell.Options.UseTextOptions = True
        Me.gcEpp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEpp.Caption = "EPP"
        Me.gcEpp.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcEpp.FieldName = "SubstrateMatReqStatus"
        Me.gcEpp.Name = "gcEpp"
        Me.gcEpp.OptionsColumn.AllowEdit = False
        Me.gcEpp.Tag = 3
        Me.gcEpp.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcEpp.Visible = True
        Me.gcEpp.VisibleIndex = 17
        '
        'gcHerramientas
        '
        Me.gcHerramientas.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.gcHerramientas.AppearanceCell.Options.UseBackColor = True
        Me.gcHerramientas.AppearanceCell.Options.UseTextOptions = True
        Me.gcHerramientas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcHerramientas.Caption = "Herramientas"
        Me.gcHerramientas.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gcHerramientas.FieldName = "Herramientas"
        Me.gcHerramientas.Name = "gcHerramientas"
        Me.gcHerramientas.OptionsColumn.AllowEdit = False
        Me.gcHerramientas.Tag = 5
        Me.gcHerramientas.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcHerramientas.Visible = True
        Me.gcHerramientas.VisibleIndex = 19
        Me.gcHerramientas.Width = 87
        '
        'gcProcurementGroupDate
        '
        Me.gcProcurementGroupDate.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcProcurementGroupDate.AppearanceCell.Options.UseBackColor = True
        Me.gcProcurementGroupDate.Caption = "Semana del Plan:"
        Me.gcProcurementGroupDate.FieldName = "ProcurementGroupDate"
        Me.gcProcurementGroupDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcProcurementGroupDate.Name = "gcProcurementGroupDate"
        Me.gcProcurementGroupDate.Visible = True
        Me.gcProcurementGroupDate.VisibleIndex = 4
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(1443, 680)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'frmPurchaseManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1204, 700)
        Me.ClientSize = New System.Drawing.Size(1445, 734)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPurchaseManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Compras"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdSOPMatReqStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSOPMatReqStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barbtnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents grdSOPMatReqStatuses As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSOPMatReqStatuses As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOTDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQtyCol As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbt_ExportToExcel As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProducyCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDoorBlanks As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcAbrasivos As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcBrickwork As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPlumbing As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcHerrajes As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcVidrioEspejos As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatElect As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatVarios As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatEmpa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcEpp As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents gcLamina As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents gcProcurementGroupDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents gcJobNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
  Friend WithEvents gcSpecStatusDesc As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btogIncludeRecentlyCompleted As DevExpress.XtraBars.BarToggleSwitchItem
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcHerramientas As DevExpress.XtraGrid.Columns.GridColumn
End Class
