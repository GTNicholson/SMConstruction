﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockItemPurchasing
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockItemPurchasing))
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
    Me.grdStockItems = New DevExpress.XtraGrid.GridControl()
    Me.gvStockItems = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStdPrice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPricingUnit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcItemType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCurrentStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOnOrderQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStockItemID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcToOrder = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepoItemSpinEditQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.gcProposedQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barbtnLoad = New DevExpress.XtraBars.BarButtonItem()
    Me.bsubitProcessToPO = New DevExpress.XtraBars.BarSubItem()
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.bcboCategory = New DevExpress.XtraBars.BarEditItem()
    Me.repCategory = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.bbiExportToExcel = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.bargCategory = New DevExpress.XtraBars.BarEditItem()
    Me.RepoItemRadioGroupCategory = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
    Me.bbiGenerateSupplierPos = New DevExpress.XtraBars.BarButtonItem()
    Me.bbiAssingToSupplierPOs = New DevExpress.XtraBars.BarButtonItem()
    Me.repitOpenStockItemTransactionHistory = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.Bar2 = New DevExpress.XtraBars.Bar()
    Me.bbtnSetAllToOrder = New DevExpress.XtraBars.BarButtonItem()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    CType(Me.grdStockItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemSpinEditQty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repCategory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemRadioGroupCategory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitOpenStockItemTransactionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.SplitContainerControl1)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(0, 33)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1362, 708)
    Me.PanelControl1.TabIndex = 0
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
    Me.SplitContainerControl1.Horizontal = False
    Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
    Me.SplitContainerControl1.Name = "SplitContainerControl1"
    Me.SplitContainerControl1.Panel1.Controls.Add(Me.grdStockItems)
    Me.SplitContainerControl1.Panel1.Text = "Panel1"
    Me.SplitContainerControl1.Panel2.Text = "Panel2"
    Me.SplitContainerControl1.Size = New System.Drawing.Size(1358, 704)
    Me.SplitContainerControl1.SplitterPosition = 27
    Me.SplitContainerControl1.TabIndex = 0
    Me.SplitContainerControl1.Text = "SplitContainerControl1"
    '
    'grdStockItems
    '
    Me.grdStockItems.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockItems.EmbeddedNavigator.Buttons.Append.Enabled = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.Append.Visible = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.Edit.Enabled = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.Edit.Visible = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.EndEdit.Visible = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.Remove.Enabled = False
    Me.grdStockItems.EmbeddedNavigator.Buttons.Remove.Visible = False
    Me.grdStockItems.Location = New System.Drawing.Point(0, 0)
    Me.grdStockItems.MainView = Me.gvStockItems
    Me.grdStockItems.MenuManager = Me.BarManager1
    Me.grdStockItems.Name = "grdStockItems"
    Me.grdStockItems.Size = New System.Drawing.Size(1358, 672)
    Me.grdStockItems.TabIndex = 0
    Me.grdStockItems.UseEmbeddedNavigator = True
    Me.grdStockItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItems})
    '
    'gvStockItems
    '
    Me.gvStockItems.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.gvStockItems.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockItems.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvStockItems.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockItems.ColumnPanelRowHeight = 38
    Me.gvStockItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.gcStdPrice, Me.gcStdCost, Me.gcPricingUnit, Me.gcCategory, Me.gcItemType, Me.gcPartNo, Me.gcCurrentStock, Me.gcOnOrderQty, Me.gcStockItemID, Me.gcToOrder, Me.gcProposedQty, Me.gcSupplier, Me.GridColumn3})
    Me.gvStockItems.GridControl = Me.grdStockItems
    Me.gvStockItems.Name = "gvStockItems"
    Me.gvStockItems.OptionsView.ShowAutoFilterRow = True
    Me.gvStockItems.OptionsView.ShowDetailButtons = False
    Me.gvStockItems.OptionsView.ShowGroupPanel = False
    Me.gvStockItems.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcSupplier, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn1.Caption = "Descripción"
    Me.GridColumn1.FieldName = "Description"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    Me.GridColumn1.Width = 262
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn2.Caption = "Código SMM"
    Me.GridColumn2.FieldName = "StockCode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    Me.GridColumn2.Width = 106
    '
    'gcStdPrice
    '
    Me.gcStdPrice.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcStdPrice.AppearanceCell.Options.UseBackColor = True
    Me.gcStdPrice.Caption = "Price"
    Me.gcStdPrice.DisplayFormat.FormatString = "c2"
    Me.gcStdPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcStdPrice.FieldName = "StdPrice"
    Me.gcStdPrice.Name = "gcStdPrice"
    Me.gcStdPrice.OptionsColumn.AllowEdit = False
    Me.gcStdPrice.OptionsColumn.ReadOnly = True
    Me.gcStdPrice.Width = 67
    '
    'gcStdCost
    '
    Me.gcStdCost.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcStdCost.AppearanceCell.Options.UseBackColor = True
    Me.gcStdCost.Caption = "Cost"
    Me.gcStdCost.DisplayFormat.FormatString = "c2"
    Me.gcStdCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcStdCost.FieldName = "StdCost"
    Me.gcStdCost.Name = "gcStdCost"
    Me.gcStdCost.OptionsColumn.AllowEdit = False
    Me.gcStdCost.OptionsColumn.ReadOnly = True
    Me.gcStdCost.Width = 67
    '
    'gcPricingUnit
    '
    Me.gcPricingUnit.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcPricingUnit.AppearanceCell.Options.UseBackColor = True
    Me.gcPricingUnit.Caption = "Unit"
    Me.gcPricingUnit.FieldName = "PricingUnit"
    Me.gcPricingUnit.Name = "gcPricingUnit"
    Me.gcPricingUnit.OptionsColumn.AllowEdit = False
    Me.gcPricingUnit.OptionsColumn.ReadOnly = True
    Me.gcPricingUnit.Width = 51
    '
    'gcCategory
    '
    Me.gcCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcCategory.AppearanceCell.Options.UseBackColor = True
    Me.gcCategory.Caption = "Categoría"
    Me.gcCategory.FieldName = "Category"
    Me.gcCategory.Name = "gcCategory"
    Me.gcCategory.OptionsColumn.AllowEdit = False
    Me.gcCategory.OptionsColumn.ReadOnly = True
    Me.gcCategory.Visible = True
    Me.gcCategory.VisibleIndex = 3
    Me.gcCategory.Width = 103
    '
    'gcItemType
    '
    Me.gcItemType.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcItemType.AppearanceCell.Options.UseBackColor = True
    Me.gcItemType.Caption = "Item Type"
    Me.gcItemType.FieldName = "UBItemType"
    Me.gcItemType.Name = "gcItemType"
    Me.gcItemType.OptionsColumn.AllowEdit = False
    Me.gcItemType.OptionsColumn.ReadOnly = True
    Me.gcItemType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcItemType.Width = 107
    '
    'gcPartNo
    '
    Me.gcPartNo.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcPartNo.AppearanceCell.Options.UseBackColor = True
    Me.gcPartNo.Caption = "Código Proveedor"
    Me.gcPartNo.FieldName = "PartNo"
    Me.gcPartNo.Name = "gcPartNo"
    Me.gcPartNo.OptionsColumn.AllowEdit = False
    Me.gcPartNo.OptionsColumn.ReadOnly = True
    Me.gcPartNo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcPartNo.Visible = True
    Me.gcPartNo.VisibleIndex = 1
    Me.gcPartNo.Width = 92
    '
    'gcCurrentStock
    '
    Me.gcCurrentStock.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcCurrentStock.AppearanceCell.Options.UseBackColor = True
    Me.gcCurrentStock.AppearanceCell.Options.UseTextOptions = True
    Me.gcCurrentStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcCurrentStock.Caption = "Inv. Actual"
    Me.gcCurrentStock.DisplayFormat.FormatString = "#.##"
    Me.gcCurrentStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcCurrentStock.FieldName = "CurrentInventory"
    Me.gcCurrentStock.Name = "gcCurrentStock"
    Me.gcCurrentStock.OptionsColumn.ReadOnly = True
    Me.gcCurrentStock.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcCurrentStock.Visible = True
    Me.gcCurrentStock.VisibleIndex = 5
    Me.gcCurrentStock.Width = 54
    '
    'gcOnOrderQty
    '
    Me.gcOnOrderQty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcOnOrderQty.AppearanceCell.Options.UseBackColor = True
    Me.gcOnOrderQty.AppearanceCell.Options.UseTextOptions = True
    Me.gcOnOrderQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcOnOrderQty.Caption = "Cant. Pedida"
    Me.gcOnOrderQty.DisplayFormat.FormatString = "#.##"
    Me.gcOnOrderQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcOnOrderQty.FieldName = "OrderedQty"
    Me.gcOnOrderQty.Name = "gcOnOrderQty"
    Me.gcOnOrderQty.OptionsColumn.ReadOnly = True
    Me.gcOnOrderQty.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcOnOrderQty.Visible = True
    Me.gcOnOrderQty.VisibleIndex = 7
    Me.gcOnOrderQty.Width = 67
    '
    'gcStockItemID
    '
    Me.gcStockItemID.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcStockItemID.AppearanceCell.Options.UseBackColor = True
    Me.gcStockItemID.Caption = "StockItemID"
    Me.gcStockItemID.FieldName = "StockItemID"
    Me.gcStockItemID.Name = "gcStockItemID"
    Me.gcStockItemID.OptionsColumn.AllowEdit = False
    Me.gcStockItemID.OptionsColumn.ReadOnly = True
    '
    'gcToOrder
    '
    Me.gcToOrder.AppearanceCell.BackColor = System.Drawing.Color.LightCyan
    Me.gcToOrder.AppearanceCell.Options.UseBackColor = True
    Me.gcToOrder.AppearanceCell.Options.UseTextOptions = True
    Me.gcToOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcToOrder.Caption = "A procesar"
    Me.gcToOrder.ColumnEdit = Me.RepoItemSpinEditQty
    Me.gcToOrder.DisplayFormat.FormatString = "#"
    Me.gcToOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcToOrder.FieldName = "TempQty"
    Me.gcToOrder.Name = "gcToOrder"
    Me.gcToOrder.Visible = True
    Me.gcToOrder.VisibleIndex = 9
    Me.gcToOrder.Width = 76
    '
    'RepoItemSpinEditQty
    '
    Me.RepoItemSpinEditQty.AutoHeight = False
    Me.RepoItemSpinEditQty.Name = "RepoItemSpinEditQty"
    '
    'gcProposedQty
    '
    Me.gcProposedQty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcProposedQty.AppearanceCell.Options.UseBackColor = True
    Me.gcProposedQty.AppearanceCell.Options.UseTextOptions = True
    Me.gcProposedQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcProposedQty.Caption = "Cant. Propuesta"
    Me.gcProposedQty.DisplayFormat.FormatString = "#"
    Me.gcProposedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcProposedQty.FieldName = "ProposedQty"
    Me.gcProposedQty.Name = "gcProposedQty"
    Me.gcProposedQty.OptionsColumn.ReadOnly = True
    Me.gcProposedQty.Visible = True
    Me.gcProposedQty.VisibleIndex = 8
    Me.gcProposedQty.Width = 49
    '
    'gcSupplier
    '
    Me.gcSupplier.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcSupplier.AppearanceCell.Options.UseBackColor = True
    Me.gcSupplier.Caption = "Proveedor"
    Me.gcSupplier.FieldName = "DefaultSupplier"
    Me.gcSupplier.Name = "gcSupplier"
    Me.gcSupplier.OptionsColumn.ReadOnly = True
    Me.gcSupplier.Visible = True
    Me.gcSupplier.VisibleIndex = 4
    Me.gcSupplier.Width = 78
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bargCategory, Me.barbtnLoad, Me.bsubitProcessToPO, Me.bbiExportToExcel, Me.bbiGenerateSupplierPos, Me.bbiAssingToSupplierPOs, Me.bcboCategory, Me.BarStaticItem1})
    Me.BarManager1.MaxItemId = 20
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoItemRadioGroupCategory, Me.repCategory})
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnLoad, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bsubitProcessToPO, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.bcboCategory, "", False, True, True, 149), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportToExcel)})
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.OptionsBar.UseWholeRow = True
    Me.Bar1.Text = "Tools"
    '
    'barbtnLoad
    '
    Me.barbtnLoad.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnLoad.Caption = "Cargar"
    Me.barbtnLoad.Id = 8
    Me.barbtnLoad.Name = "barbtnLoad"
    '
    'bsubitProcessToPO
    '
    Me.bsubitProcessToPO.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bsubitProcessToPO.Caption = "Procesar a O.C."
    Me.bsubitProcessToPO.Id = 14
    Me.bsubitProcessToPO.Name = "bsubitProcessToPO"
    '
    'BarStaticItem1
    '
    Me.BarStaticItem1.Caption = "Category"
    Me.BarStaticItem1.Id = 19
    Me.BarStaticItem1.Name = "BarStaticItem1"
    '
    'bcboCategory
    '
    Me.bcboCategory.Caption = "Category"
    Me.bcboCategory.Edit = Me.repCategory
    Me.bcboCategory.Id = 18
    Me.bcboCategory.Name = "bcboCategory"
    '
    'repCategory
    '
    Me.repCategory.AutoHeight = False
    Me.repCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repCategory.Name = "repCategory"
    '
    'bbiExportToExcel
    '
    Me.bbiExportToExcel.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbiExportToExcel.Caption = "Exportar a Excel"
    Me.bbiExportToExcel.Id = 15
    Me.bbiExportToExcel.Name = "bbiExportToExcel"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1362, 33)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 741)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1362, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 708)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1362, 33)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 708)
    '
    'bargCategory
    '
    Me.bargCategory.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bargCategory.Caption = "Category"
    Me.bargCategory.Edit = Me.RepoItemRadioGroupCategory
    Me.bargCategory.EditValue = CType(0, Byte)
    Me.bargCategory.Id = 4
    Me.bargCategory.Name = "bargCategory"
    Me.bargCategory.Size = New System.Drawing.Size(623, 0)
    '
    'RepoItemRadioGroupCategory
    '
    Me.RepoItemRadioGroupCategory.AllowMouseWheel = False
    Me.RepoItemRadioGroupCategory.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Byte), "All"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Timber"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(4, Byte), "Ironmongery"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(10, Byte), "Doorblank"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(5, Byte), "Intumescent"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(6, Byte), "Glass"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Facing"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(9, Byte), "Breading"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Byte), "Lips"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(7, Byte), "Misc")})
    Me.RepoItemRadioGroupCategory.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
    Me.RepoItemRadioGroupCategory.Name = "RepoItemRadioGroupCategory"
    '
    'bbiGenerateSupplierPos
    '
    Me.bbiGenerateSupplierPos.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbiGenerateSupplierPos.Caption = "Generate Supplier POs"
    Me.bbiGenerateSupplierPos.Id = 16
    Me.bbiGenerateSupplierPos.Name = "bbiGenerateSupplierPos"
    '
    'bbiAssingToSupplierPOs
    '
    Me.bbiAssingToSupplierPOs.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbiAssingToSupplierPOs.Caption = "Assign To Supplier POs"
    Me.bbiAssingToSupplierPOs.Id = 17
    Me.bbiAssingToSupplierPOs.Name = "bbiAssingToSupplierPOs"
    '
    'repitOpenStockItemTransactionHistory
    '
    Me.repitOpenStockItemTransactionHistory.AutoHeight = False
    Me.repitOpenStockItemTransactionHistory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.repitOpenStockItemTransactionHistory.Name = "repitOpenStockItemTransactionHistory"
    '
    'RepositoryItemComboBox1
    '
    Me.RepositoryItemComboBox1.AllowMouseWheel = False
    Me.RepositoryItemComboBox1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.RepositoryItemComboBox1.Appearance.Options.UseFont = True
    Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
    Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'Bar2
    '
    Me.Bar2.BarName = "Tools"
    Me.Bar2.DockCol = 0
    Me.Bar2.DockRow = 0
    Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar2.OptionsBar.AllowQuickCustomization = False
    Me.Bar2.OptionsBar.DrawDragBorder = False
    Me.Bar2.Text = "Tools"
    '
    'bbtnSetAllToOrder
    '
    Me.bbtnSetAllToOrder.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnSetAllToOrder.Caption = "Set All Bal Qty To Order"
    Me.bbtnSetAllToOrder.Id = 3
    Me.bbtnSetAllToOrder.Name = "bbtnSetAllToOrder"
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Inventario Req."
    Me.GridColumn3.FieldName = "RequiredInventory"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 6
    '
    'frmStockItemPurchasing
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1362, 741)
    Me.Controls.Add(Me.PanelControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmStockItemPurchasing"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Admon. de Artículos de Inventario"
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    CType(Me.grdStockItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemSpinEditQty, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repCategory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemRadioGroupCategory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitOpenStockItemTransactionHistory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
  Friend WithEvents grdStockItems As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockItems As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStdPrice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStdCost As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPricingUnit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPartNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bargCategory As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepoItemRadioGroupCategory As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
  Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents gcOnOrderQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCurrentStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockItemID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbtnLoad As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RepoItemSpinEditQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnSetAllToOrder As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bsubitProcessToPO As DevExpress.XtraBars.BarSubItem
  Friend WithEvents gcProposedQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSupplier As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbiExportToExcel As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents gcToOrder As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbiGenerateSupplierPos As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbiAssingToSupplierPOs As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents repitOpenStockItemTransactionHistory As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents bcboCategory As DevExpress.XtraBars.BarEditItem
  Friend WithEvents repCategory As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
