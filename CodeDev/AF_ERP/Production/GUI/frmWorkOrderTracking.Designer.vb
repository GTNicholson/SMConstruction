<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrderTracking
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkOrderTracking))
        Me.grdWorksOrders = New DevExpress.XtraGrid.GridControl()
        Me.gvWorksOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.gcCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcWood = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInsumos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcEngineering = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPurchasing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSelection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDimensionado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCarpitry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSanding = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFinishing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMetalWork = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMetalFinishing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPackaging = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDespatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTapizado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTejido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInstallation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bchkHideDespatched = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.bbtnReLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnExportToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grdWorksOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorksOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdWorksOrders
        '
        Me.grdWorksOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorksOrders.Location = New System.Drawing.Point(0, 28)
        Me.grdWorksOrders.MainView = Me.gvWorksOrders
        Me.grdWorksOrders.Name = "grdWorksOrders"
        Me.grdWorksOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdWorksOrders.Size = New System.Drawing.Size(1924, 598)
        Me.grdWorksOrders.TabIndex = 0
        Me.grdWorksOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorksOrders})
        '
        'gvWorksOrders
        '
        Me.gvWorksOrders.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvWorksOrders.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorksOrders.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvWorksOrders.Appearance.EvenRow.Options.UseFont = True
        Me.gvWorksOrders.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWorksOrders.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWorksOrders.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvWorksOrders.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvWorksOrders.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvWorksOrders.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorksOrders.Appearance.OddRow.Options.UseBackColor = True
        Me.gvWorksOrders.Appearance.OddRow.Options.UseFont = True
        Me.gvWorksOrders.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorksOrders.Appearance.Row.Options.UseFont = True
        Me.gvWorksOrders.Appearance.Row.Options.UseTextOptions = True
        Me.gvWorksOrders.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvWorksOrders.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.gvWorksOrders.Appearance.ViewCaption.Options.UseFont = True
        Me.gvWorksOrders.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvWorksOrders.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvWorksOrders.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvWorksOrders.ColumnPanelRowHeight = 34
        Me.gvWorksOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn10, Me.GridColumn5, Me.gcCustomer, Me.GridColumn6, Me.gcWood, Me.gcInsumos, Me.gcEngineering, Me.gcPurchasing, Me.gcSelection, Me.gcDimensionado, Me.gcCarpitry, Me.gcSanding, Me.gcFinishing, Me.gcMetalWork, Me.gcMetalFinishing, Me.gcPackaging, Me.gcDespatch, Me.gcTapizado, Me.gcTejido, Me.gcInstallation})
        Me.gvWorksOrders.GridControl = Me.grdWorksOrders
        Me.gvWorksOrders.GroupCount = 1
        Me.gvWorksOrders.GroupRowHeight = 28
        Me.gvWorksOrders.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalValue", Nothing, "{0:0.##}")})
        Me.gvWorksOrders.Name = "gvWorksOrders"
        Me.gvWorksOrders.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvWorksOrders.OptionsView.ColumnAutoWidth = False
        Me.gvWorksOrders.OptionsView.EnableAppearanceEvenRow = True
        Me.gvWorksOrders.OptionsView.EnableAppearanceOddRow = True
        Me.gvWorksOrders.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gvWorksOrders.OptionsView.ShowAutoFilterRow = True
        Me.gvWorksOrders.OptionsView.ShowGroupPanel = False
        Me.gvWorksOrders.OptionsView.ShowViewCaption = True
        Me.gvWorksOrders.RowHeight = 34
        Me.gvWorksOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvWorksOrders.ViewCaption = "Interfaz de Seguimiento de OTs"
        Me.gvWorksOrders.ViewCaptionHeight = 80
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Semana de Produccion"
        Me.GridColumn7.DisplayFormat.FormatString = "dd / MM"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.FieldName = "PlannedStartDateWC"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 11
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "Núm. O.T."
        Me.GridColumn1.FieldName = "WorkOrderNo"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 166
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 112
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.Caption = "Cantidad"
        Me.GridColumn3.FieldName = "Quantity"
        Me.GridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 62
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.Caption = "Orden de Venta"
        Me.GridColumn4.FieldName = "OrderNo"
        Me.GridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 73
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn10.Caption = "Proyecto"
        Me.GridColumn10.FieldName = "ProjectName"
        Me.GridColumn10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 138
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.Caption = "Fecha de Prod."
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn5.FieldName = "PlannedStartDate"
        Me.GridColumn5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        Me.GridColumn5.Width = 76
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'gcCustomer
        '
        Me.gcCustomer.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcCustomer.AppearanceCell.Options.UseBackColor = True
        Me.gcCustomer.Caption = "Cliente"
        Me.gcCustomer.FieldName = "CustomerName"
        Me.gcCustomer.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcCustomer.Name = "gcCustomer"
        Me.gcCustomer.OptionsColumn.ReadOnly = True
        Me.gcCustomer.Visible = True
        Me.gcCustomer.VisibleIndex = 3
        Me.gcCustomer.Width = 92
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.Caption = "Fecha Requerida"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn6.FieldName = "FinishDate"
        Me.GridColumn6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'gcWood
        '
        Me.gcWood.AppearanceCell.Options.UseTextOptions = True
        Me.gcWood.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcWood.AppearanceHeader.Options.UseTextOptions = True
        Me.gcWood.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcWood.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcWood.Caption = "Madera"
        Me.gcWood.FieldName = "GridColumn5"
        Me.gcWood.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcWood.Name = "gcWood"
        Me.gcWood.OptionsColumn.AllowEdit = False
        Me.gcWood.OptionsColumn.ReadOnly = True
        Me.gcWood.Tag = 1
        Me.gcWood.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcWood.Width = 126
        '
        'gcInsumos
        '
        Me.gcInsumos.AppearanceCell.Options.UseTextOptions = True
        Me.gcInsumos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcInsumos.AppearanceHeader.Options.UseTextOptions = True
        Me.gcInsumos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcInsumos.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcInsumos.Caption = "Compras"
        Me.gcInsumos.FieldName = "GridColumn7"
        Me.gcInsumos.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcInsumos.Name = "gcInsumos"
        Me.gcInsumos.OptionsColumn.AllowEdit = False
        Me.gcInsumos.OptionsColumn.ReadOnly = True
        Me.gcInsumos.Tag = 2
        Me.gcInsumos.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcInsumos.Visible = True
        Me.gcInsumos.VisibleIndex = 9
        Me.gcInsumos.Width = 119
        '
        'gcEngineering
        '
        Me.gcEngineering.AppearanceCell.Options.UseTextOptions = True
        Me.gcEngineering.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEngineering.AppearanceHeader.Options.UseTextOptions = True
        Me.gcEngineering.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEngineering.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcEngineering.Caption = "Ingeniería"
        Me.gcEngineering.FieldName = "GridColumn8"
        Me.gcEngineering.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcEngineering.Name = "gcEngineering"
        Me.gcEngineering.OptionsColumn.AllowEdit = False
        Me.gcEngineering.OptionsColumn.ReadOnly = True
        Me.gcEngineering.Tag = 3
        Me.gcEngineering.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcEngineering.Visible = True
        Me.gcEngineering.VisibleIndex = 8
        Me.gcEngineering.Width = 94
        '
        'gcPurchasing
        '
        Me.gcPurchasing.AppearanceCell.Options.UseTextOptions = True
        Me.gcPurchasing.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcPurchasing.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPurchasing.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcPurchasing.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPurchasing.Caption = "Compras"
        Me.gcPurchasing.FieldName = "GridColumn9"
        Me.gcPurchasing.Name = "gcPurchasing"
        Me.gcPurchasing.OptionsColumn.AllowEdit = False
        Me.gcPurchasing.OptionsColumn.ReadOnly = True
        Me.gcPurchasing.Tag = 4
        Me.gcPurchasing.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcPurchasing.Width = 101
        '
        'gcSelection
        '
        Me.gcSelection.Caption = "Seleccionado"
        Me.gcSelection.FieldName = "gc"
        Me.gcSelection.Name = "gcSelection"
        Me.gcSelection.OptionsColumn.AllowEdit = False
        Me.gcSelection.OptionsColumn.ReadOnly = True
        Me.gcSelection.Tag = "5"
        Me.gcSelection.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcSelection.Visible = True
        Me.gcSelection.VisibleIndex = 10
        Me.gcSelection.Width = 87
        '
        'gcDimensionado
        '
        Me.gcDimensionado.Caption = "Dimensionado"
        Me.gcDimensionado.FieldName = "gcDimensionado"
        Me.gcDimensionado.Name = "gcDimensionado"
        Me.gcDimensionado.OptionsColumn.AllowEdit = False
        Me.gcDimensionado.OptionsColumn.ReadOnly = True
        Me.gcDimensionado.Tag = "6"
        Me.gcDimensionado.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcDimensionado.Visible = True
        Me.gcDimensionado.VisibleIndex = 11
        Me.gcDimensionado.Width = 87
        '
        'gcCarpitry
        '
        Me.gcCarpitry.Caption = "Carpintería"
        Me.gcCarpitry.FieldName = "gcCarpitry"
        Me.gcCarpitry.Name = "gcCarpitry"
        Me.gcCarpitry.OptionsColumn.AllowEdit = False
        Me.gcCarpitry.OptionsColumn.ReadOnly = True
        Me.gcCarpitry.Tag = "7"
        Me.gcCarpitry.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcCarpitry.Visible = True
        Me.gcCarpitry.VisibleIndex = 12
        '
        'gcSanding
        '
        Me.gcSanding.Caption = "Lija"
        Me.gcSanding.FieldName = "gcSanding"
        Me.gcSanding.Name = "gcSanding"
        Me.gcSanding.OptionsColumn.AllowEdit = False
        Me.gcSanding.OptionsColumn.ReadOnly = True
        Me.gcSanding.Tag = "8"
        Me.gcSanding.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcSanding.Visible = True
        Me.gcSanding.VisibleIndex = 13
        '
        'gcFinishing
        '
        Me.gcFinishing.Caption = "Acabado"
        Me.gcFinishing.FieldName = "gFinishing"
        Me.gcFinishing.Name = "gcFinishing"
        Me.gcFinishing.OptionsColumn.AllowEdit = False
        Me.gcFinishing.OptionsColumn.ReadOnly = True
        Me.gcFinishing.Tag = "9"
        Me.gcFinishing.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcFinishing.Visible = True
        Me.gcFinishing.VisibleIndex = 14
        '
        'gcMetalWork
        '
        Me.gcMetalWork.Caption = "Metal"
        Me.gcMetalWork.FieldName = "gcMetalwork"
        Me.gcMetalWork.Name = "gcMetalWork"
        Me.gcMetalWork.OptionsColumn.AllowEdit = False
        Me.gcMetalWork.OptionsColumn.ReadOnly = True
        Me.gcMetalWork.Tag = "10"
        Me.gcMetalWork.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMetalWork.Visible = True
        Me.gcMetalWork.VisibleIndex = 16
        '
        'gcMetalFinishing
        '
        Me.gcMetalFinishing.Caption = "Acabado Metal"
        Me.gcMetalFinishing.FieldName = "gcMetalFinishing"
        Me.gcMetalFinishing.Name = "gcMetalFinishing"
        Me.gcMetalFinishing.OptionsColumn.AllowEdit = False
        Me.gcMetalFinishing.OptionsColumn.ReadOnly = True
        Me.gcMetalFinishing.Tag = "11"
        Me.gcMetalFinishing.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcMetalFinishing.Visible = True
        Me.gcMetalFinishing.VisibleIndex = 15
        '
        'gcPackaging
        '
        Me.gcPackaging.Caption = "Empaque"
        Me.gcPackaging.FieldName = "gcPackaging"
        Me.gcPackaging.Name = "gcPackaging"
        Me.gcPackaging.OptionsColumn.AllowEdit = False
        Me.gcPackaging.OptionsColumn.ReadOnly = True
        Me.gcPackaging.Tag = "12"
        Me.gcPackaging.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcPackaging.Visible = True
        Me.gcPackaging.VisibleIndex = 19
        '
        'gcDespatch
        '
        Me.gcDespatch.Caption = "Despacho"
        Me.gcDespatch.FieldName = "gcDespatch"
        Me.gcDespatch.Name = "gcDespatch"
        Me.gcDespatch.OptionsColumn.AllowEdit = False
        Me.gcDespatch.OptionsColumn.ReadOnly = True
        Me.gcDespatch.Tag = "13"
        Me.gcDespatch.Visible = True
        Me.gcDespatch.VisibleIndex = 20
        '
        'gcTapizado
        '
        Me.gcTapizado.Caption = "Tapizado"
        Me.gcTapizado.FieldName = "gcTapizado"
        Me.gcTapizado.Name = "gcTapizado"
        Me.gcTapizado.OptionsColumn.AllowEdit = False
        Me.gcTapizado.OptionsColumn.ReadOnly = True
        Me.gcTapizado.Tag = "18"
        Me.gcTapizado.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcTapizado.Visible = True
        Me.gcTapizado.VisibleIndex = 17
        '
        'gcTejido
        '
        Me.gcTejido.Caption = "Tejido"
        Me.gcTejido.FieldName = "gcTejido"
        Me.gcTejido.Name = "gcTejido"
        Me.gcTejido.OptionsColumn.AllowEdit = False
        Me.gcTejido.OptionsColumn.ReadOnly = True
        Me.gcTejido.Tag = "19"
        Me.gcTejido.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcTejido.Visible = True
        Me.gcTejido.VisibleIndex = 18
        Me.gcTejido.Width = 100
        '
        'gcInstallation
        '
        Me.gcInstallation.Caption = "Instalación"
        Me.gcInstallation.FieldName = "gcInstallation"
        Me.gcInstallation.Name = "gcInstallation"
        Me.gcInstallation.OptionsColumn.AllowEdit = False
        Me.gcInstallation.OptionsColumn.ReadOnly = True
        Me.gcInstallation.Tag = 20
        Me.gcInstallation.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcInstallation.Visible = True
        Me.gcInstallation.VisibleIndex = 21
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnExportToExcel, Me.bbtnReLoad, Me.bchkHideDespatched})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.bchkHideDespatched, "", False, True, True, 34, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnReLoad), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnExportToExcel)})
        Me.Bar1.Text = "Tools"
        '
        'bchkHideDespatched
        '
        Me.bchkHideDespatched.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bchkHideDespatched.Caption = "Ocultar Despachados"
        Me.bchkHideDespatched.Edit = Me.RepositoryItemCheckEdit1
        Me.bchkHideDespatched.Id = 3
        Me.bchkHideDespatched.Name = "bchkHideDespatched"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'bbtnReLoad
        '
        Me.bbtnReLoad.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnReLoad.Caption = "Recargar"
        Me.bbtnReLoad.Id = 1
        Me.bbtnReLoad.Name = "bbtnReLoad"
        '
        'bbtnExportToExcel
        '
        Me.bbtnExportToExcel.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnExportToExcel.Caption = "Exportar a Excel"
        Me.bbtnExportToExcel.Id = 0
        Me.bbtnExportToExcel.Name = "bbtnExportToExcel"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1924, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 626)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1924, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 598)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1924, 28)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 598)
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
        Me.GroupControl1.Location = New System.Drawing.Point(1477, 36)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(447, 68)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "LEYENDA"
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
        Me.LabelControl10.Location = New System.Drawing.Point(341, 24)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl10.TabIndex = 5
        Me.LabelControl10.Text = "Completado"
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
        Me.LabelControl6.Location = New System.Drawing.Point(237, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "En Progreso"
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
        'frmWorkOrderTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 626)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grdWorksOrders)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWorkOrderTracking"
        Me.Text = "Progreso de los O,T.s"
        CType(Me.grdWorksOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorksOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdWorksOrders As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorksOrders As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcWood As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcInsumos As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcEngineering As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPurchasing As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents gcSelection As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDimensionado As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCarpitry As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSanding As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCustomer As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcFinishing As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMetalWork As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbtnExportToExcel As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bchkHideDespatched As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents bbtnReLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcMetalFinishing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPackaging As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDespatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTapizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTejido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInstallation As DevExpress.XtraGrid.Columns.GridColumn
End Class
