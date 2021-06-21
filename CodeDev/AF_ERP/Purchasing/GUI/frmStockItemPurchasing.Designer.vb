Imports DevExpress.XtraGrid.Views

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
    Me.pucOrders = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdOrders = New DevExpress.XtraGrid.GridControl()
    Me.gvOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoETA = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barbtnLoad = New DevExpress.XtraBars.BarButtonItem()
    Me.bsubitProcessToPO = New DevExpress.XtraBars.BarSubItem()
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.bcboCategory = New DevExpress.XtraBars.BarEditItem()
    Me.repCategory = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.bbiExportToExcel = New DevExpress.XtraBars.BarButtonItem()
    Me.bbiGenerateSupplierPos = New DevExpress.XtraBars.BarButtonItem()
    Me.bbiAssingToSupplierPOs = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.bargCategory = New DevExpress.XtraBars.BarEditItem()
    Me.RepoItemRadioGroupCategory = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
    Me.pucAllocations = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdStockItemAllocations = New DevExpress.XtraGrid.GridControl()
    Me.gvStockItemAllocations = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repProdStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.grdStockItems = New DevExpress.XtraGrid.GridControl()
    Me.gvStockItems = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCurrentStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAllocatedQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitpucAllocations = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.gcOnOrderQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitpucOrders = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.gcToOrder = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepoItemSpinEditQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcProposedQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPurchasingCategory = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitOpenStockItemTransactionHistory = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.Bar2 = New DevExpress.XtraBars.Bar()
    Me.bbtnSetAllToOrder = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    CType(Me.pucOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pucOrders.SuspendLayout()
    CType(Me.grdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repoETA, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repoETA.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repCategory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemRadioGroupCategory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pucAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pucAllocations.SuspendLayout()
    CType(Me.grdStockItemAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockItemAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repProdStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repProdStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdStockItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitpucAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitpucOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemSpinEditQty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitOpenStockItemTransactionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.SplitContainerControl1)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(0, 30)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1362, 711)
    Me.PanelControl1.TabIndex = 0
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
    Me.SplitContainerControl1.Horizontal = False
    Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
    Me.SplitContainerControl1.Name = "SplitContainerControl1"
    Me.SplitContainerControl1.Panel1.Controls.Add(Me.pucOrders)
    Me.SplitContainerControl1.Panel1.Controls.Add(Me.pucAllocations)
    Me.SplitContainerControl1.Panel1.Controls.Add(Me.grdStockItems)
    Me.SplitContainerControl1.Panel1.Text = "Panel1"
    Me.SplitContainerControl1.Panel2.Text = "Panel2"
    Me.SplitContainerControl1.Size = New System.Drawing.Size(1358, 707)
    Me.SplitContainerControl1.SplitterPosition = 27
    Me.SplitContainerControl1.TabIndex = 0
    Me.SplitContainerControl1.Text = "SplitContainerControl1"
    '
    'pucOrders
    '
    Me.pucOrders.Controls.Add(Me.grdOrders)
    Me.pucOrders.Location = New System.Drawing.Point(827, 176)
    Me.pucOrders.Name = "pucOrders"
    Me.pucOrders.Size = New System.Drawing.Size(386, 289)
    Me.pucOrders.TabIndex = 2
    '
    'grdOrders
    '
    Me.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdOrders.Location = New System.Drawing.Point(0, 0)
    Me.grdOrders.MainView = Me.gvOrders
    Me.grdOrders.MenuManager = Me.BarManager1
    Me.grdOrders.Name = "grdOrders"
    Me.grdOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoETA})
    Me.grdOrders.Size = New System.Drawing.Size(386, 289)
    Me.grdOrders.TabIndex = 1
    Me.grdOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOrders})
    '
    'gvOrders
    '
    Me.gvOrders.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvOrders.Appearance.GroupPanel.Options.UseFont = True
    Me.gvOrders.Appearance.GroupPanel.Options.UseTextOptions = True
    Me.gvOrders.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvOrders.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvOrders.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvOrders.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvOrders.Appearance.Row.Options.UseFont = True
    Me.gvOrders.Appearance.Row.Options.UseTextOptions = True
    Me.gvOrders.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
    Me.gvOrders.DetailHeight = 200
    Me.gvOrders.GridControl = Me.grdOrders
    Me.gvOrders.Name = "gvOrders"
    Me.gvOrders.OptionsBehavior.ReadOnly = True
    Me.gvOrders.OptionsView.ShowFooter = True
    Me.gvOrders.OptionsView.ShowGroupPanel = False
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "PO No."
    Me.GridColumn7.FieldName = "PONum"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 0
    Me.GridColumn7.Width = 144
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "ETA"
    Me.GridColumn8.ColumnEdit = Me.repoETA
    Me.GridColumn8.DisplayFormat.FormatString = "d"
    Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn8.FieldName = "RequiredDates"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 2
    Me.GridColumn8.Width = 178
    '
    'repoETA
    '
    Me.repoETA.AutoHeight = False
    Me.repoETA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repoETA.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repoETA.Name = "repoETA"
    Me.repoETA.NullDate = "01/01/0001"
    Me.repoETA.NullText = " "
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Qty"
    Me.GridColumn9.DisplayFormat.FormatString = "N2"
    Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn9.FieldName = "Quantity"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 3
    Me.GridColumn9.Width = 133
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Supplier"
    Me.GridColumn10.FieldName = "SUPPLIERCOMPANYNAME"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 1
    Me.GridColumn10.Width = 195
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "OutStand. Qty"
    Me.GridColumn11.DisplayFormat.FormatString = "N2"
    Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn11.FieldName = "OutStandingQty"
    Me.GridColumn11.GroupFormat.FormatString = "N2"
    Me.GridColumn11.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutStandingQty", "{0:N2}")})
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 4
    Me.GridColumn11.Width = 199
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "PurchaseOrderID"
    Me.GridColumn12.FieldName = "PurchaseOrderID"
    Me.GridColumn12.Name = "GridColumn12"
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
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnLoad, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bsubitProcessToPO, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.bcboCategory, "", False, True, True, 149), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportToExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGenerateSupplierPos), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAssingToSupplierPOs)})
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.OptionsBar.UseWholeRow = True
    Me.Bar1.Text = "Tools"
    '
    'barbtnLoad
    '
    Me.barbtnLoad.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnLoad.Caption = "Load"
    Me.barbtnLoad.Id = 8
    Me.barbtnLoad.Name = "barbtnLoad"
    '
    'bsubitProcessToPO
    '
    Me.bsubitProcessToPO.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bsubitProcessToPO.Caption = "Process to open Purchase Order"
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
    Me.bbiExportToExcel.Caption = "Export To Excel"
    Me.bbiExportToExcel.Id = 15
    Me.bbiExportToExcel.Name = "bbiExportToExcel"
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
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1362, 30)
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
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 711)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1362, 30)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 711)
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
    'pucAllocations
    '
    Me.pucAllocations.Controls.Add(Me.grdStockItemAllocations)
    Me.pucAllocations.Location = New System.Drawing.Point(343, 134)
    Me.pucAllocations.Name = "pucAllocations"
    Me.pucAllocations.Size = New System.Drawing.Size(459, 331)
    Me.pucAllocations.TabIndex = 1
    '
    'grdStockItemAllocations
    '
    Me.grdStockItemAllocations.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockItemAllocations.Location = New System.Drawing.Point(0, 0)
    Me.grdStockItemAllocations.MainView = Me.gvStockItemAllocations
    Me.grdStockItemAllocations.MenuManager = Me.BarManager1
    Me.grdStockItemAllocations.Name = "grdStockItemAllocations"
    Me.grdStockItemAllocations.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repProdStartDate})
    Me.grdStockItemAllocations.Size = New System.Drawing.Size(459, 331)
    Me.grdStockItemAllocations.TabIndex = 0
    Me.grdStockItemAllocations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItemAllocations})
    '
    'gvStockItemAllocations
    '
    Me.gvStockItemAllocations.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvStockItemAllocations.Appearance.GroupPanel.Options.UseFont = True
    Me.gvStockItemAllocations.Appearance.GroupPanel.Options.UseTextOptions = True
    Me.gvStockItemAllocations.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockItemAllocations.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvStockItemAllocations.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockItemAllocations.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvStockItemAllocations.Appearance.Row.Options.UseFont = True
    Me.gvStockItemAllocations.Appearance.Row.Options.UseTextOptions = True
    Me.gvStockItemAllocations.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockItemAllocations.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvStockItemAllocations.Appearance.ViewCaption.Options.UseFont = True
    Me.gvStockItemAllocations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
    Me.gvStockItemAllocations.DetailHeight = 200
    Me.gvStockItemAllocations.GridControl = Me.grdStockItemAllocations
    Me.gvStockItemAllocations.Name = "gvStockItemAllocations"
    Me.gvStockItemAllocations.OptionsBehavior.ReadOnly = True
    Me.gvStockItemAllocations.OptionsView.ShowFooter = True
    Me.gvStockItemAllocations.OptionsView.ShowGroupPanel = False
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Phase No. Ref"
    Me.GridColumn3.FieldName = "PhaseNoAndRef"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 93
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Req. Date"
    Me.GridColumn4.ColumnEdit = Me.repProdStartDate
    Me.GridColumn4.DisplayFormat.FormatString = "d"
    Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn4.FieldName = "DateRequired"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    Me.GridColumn4.Width = 97
    '
    'repProdStartDate
    '
    Me.repProdStartDate.AutoHeight = False
    Me.repProdStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repProdStartDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repProdStartDate.Name = "repProdStartDate"
    Me.repProdStartDate.NullDate = New Date(2020, 3, 11, 18, 39, 42, 987)
    Me.repProdStartDate.NullText = "''"
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Qty"
    Me.GridColumn5.DisplayFormat.FormatString = "N2"
    Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn5.FieldName = "QuantityRequired"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:N2}")})
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 3
    Me.GridColumn5.Width = 77
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "CustomerName"
    Me.GridColumn6.FieldName = "CompanyName"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
    Me.GridColumn6.Width = 174
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
    Me.grdStockItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitpucAllocations, Me.repitpucOrders})
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
    Me.gvStockItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.gcCategory, Me.gcCurrentStock, Me.gcAllocatedQty, Me.gcOnOrderQty, Me.gcToOrder, Me.GridColumn18, Me.gcProposedQty, Me.GridColumn22, Me.gcPurchasingCategory, Me.GridColumn19, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
    Me.gvStockItems.GridControl = Me.grdStockItems
    Me.gvStockItems.Name = "gvStockItems"
    Me.gvStockItems.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
    Me.gvStockItems.OptionsView.ShowAutoFilterRow = True
    Me.gvStockItems.OptionsView.ShowDetailButtons = False
    Me.gvStockItems.OptionsView.ShowGroupPanel = False
    Me.gvStockItems.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn22, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn1.Caption = "Description"
    Me.GridColumn1.FieldName = "Description"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 5
    Me.GridColumn1.Width = 507
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn2.Caption = "Stock Code"
    Me.GridColumn2.FieldName = "StockCode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    Me.GridColumn2.Width = 96
    '
    'gcCategory
    '
    Me.gcCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcCategory.AppearanceCell.Options.UseBackColor = True
    Me.gcCategory.Caption = "Category"
    Me.gcCategory.FieldName = "Category"
    Me.gcCategory.Name = "gcCategory"
    Me.gcCategory.OptionsColumn.AllowEdit = False
    Me.gcCategory.Visible = True
    Me.gcCategory.VisibleIndex = 2
    Me.gcCategory.Width = 128
    '
    'gcCurrentStock
    '
    Me.gcCurrentStock.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcCurrentStock.AppearanceCell.Options.UseBackColor = True
    Me.gcCurrentStock.AppearanceCell.Options.UseTextOptions = True
    Me.gcCurrentStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcCurrentStock.Caption = "In Stock"
    Me.gcCurrentStock.DisplayFormat.FormatString = "N1"
    Me.gcCurrentStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcCurrentStock.FieldName = "CurrentInventory"
    Me.gcCurrentStock.Name = "gcCurrentStock"
    Me.gcCurrentStock.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcCurrentStock.Visible = True
    Me.gcCurrentStock.VisibleIndex = 7
    Me.gcCurrentStock.Width = 70
    '
    'gcAllocatedQty
    '
    Me.gcAllocatedQty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcAllocatedQty.AppearanceCell.Options.UseBackColor = True
    Me.gcAllocatedQty.AppearanceCell.Options.UseTextOptions = True
    Me.gcAllocatedQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcAllocatedQty.Caption = "Allocated Qty"
    Me.gcAllocatedQty.ColumnEdit = Me.repitpucAllocations
    Me.gcAllocatedQty.DisplayFormat.FormatString = "N1"
    Me.gcAllocatedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcAllocatedQty.FieldName = "AllocatedQty"
    Me.gcAllocatedQty.Name = "gcAllocatedQty"
    Me.gcAllocatedQty.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcAllocatedQty.Visible = True
    Me.gcAllocatedQty.VisibleIndex = 9
    Me.gcAllocatedQty.Width = 80
    '
    'repitpucAllocations
    '
    Me.repitpucAllocations.AutoHeight = False
    Me.repitpucAllocations.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repitpucAllocations.Name = "repitpucAllocations"
    Me.repitpucAllocations.PopupControl = Me.pucAllocations
    '
    'gcOnOrderQty
    '
    Me.gcOnOrderQty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcOnOrderQty.AppearanceCell.Options.UseBackColor = True
    Me.gcOnOrderQty.AppearanceCell.Options.UseTextOptions = True
    Me.gcOnOrderQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcOnOrderQty.Caption = "On Order O/S Qty"
    Me.gcOnOrderQty.ColumnEdit = Me.repitpucOrders
    Me.gcOnOrderQty.DisplayFormat.FormatString = "N1"
    Me.gcOnOrderQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcOnOrderQty.FieldName = "OrderedQty"
    Me.gcOnOrderQty.Name = "gcOnOrderQty"
    Me.gcOnOrderQty.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcOnOrderQty.Visible = True
    Me.gcOnOrderQty.VisibleIndex = 10
    Me.gcOnOrderQty.Width = 99
    '
    'repitpucOrders
    '
    Me.repitpucOrders.AutoHeight = False
    Me.repitpucOrders.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repitpucOrders.Name = "repitpucOrders"
    Me.repitpucOrders.PopupControl = Me.pucOrders
    '
    'gcToOrder
    '
    Me.gcToOrder.AppearanceCell.BackColor = System.Drawing.Color.LightCyan
    Me.gcToOrder.AppearanceCell.Options.UseBackColor = True
    Me.gcToOrder.AppearanceCell.Options.UseTextOptions = True
    Me.gcToOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcToOrder.Caption = "To Process Qty"
    Me.gcToOrder.ColumnEdit = Me.RepoItemSpinEditQty
    Me.gcToOrder.DisplayFormat.FormatString = "N1"
    Me.gcToOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcToOrder.FieldName = "ToProcessQty"
    Me.gcToOrder.Name = "gcToOrder"
    Me.gcToOrder.Visible = True
    Me.gcToOrder.VisibleIndex = 12
    Me.gcToOrder.Width = 104
    '
    'RepoItemSpinEditQty
    '
    Me.RepoItemSpinEditQty.AutoHeight = False
    Me.RepoItemSpinEditQty.Name = "RepoItemSpinEditQty"
    '
    'GridColumn18
    '
    Me.GridColumn18.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn18.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn18.Caption = "Min Stock Qty"
    Me.GridColumn18.DisplayFormat.FormatString = "N1"
    Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn18.FieldName = "MinQty"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.Visible = True
    Me.GridColumn18.VisibleIndex = 8
    Me.GridColumn18.Width = 65
    '
    'gcProposedQty
    '
    Me.gcProposedQty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcProposedQty.AppearanceCell.Options.UseBackColor = True
    Me.gcProposedQty.AppearanceCell.Options.UseTextOptions = True
    Me.gcProposedQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcProposedQty.Caption = "Proposed Qty"
    Me.gcProposedQty.DisplayFormat.FormatString = "N1"
    Me.gcProposedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcProposedQty.FieldName = "ProposedQty"
    Me.gcProposedQty.Name = "gcProposedQty"
    Me.gcProposedQty.Visible = True
    Me.gcProposedQty.VisibleIndex = 11
    Me.gcProposedQty.Width = 65
    '
    'GridColumn22
    '
    Me.GridColumn22.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn22.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn22.Caption = "Default Supplier"
    Me.GridColumn22.FieldName = "DefaultSupplier"
    Me.GridColumn22.Name = "GridColumn22"
    Me.GridColumn22.Visible = True
    Me.GridColumn22.VisibleIndex = 6
    Me.GridColumn22.Width = 105
    '
    'gcPurchasingCategory
    '
    Me.gcPurchasingCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcPurchasingCategory.AppearanceCell.Options.UseBackColor = True
    Me.gcPurchasingCategory.Caption = "Purchasing Category"
    Me.gcPurchasingCategory.FieldName = "PurchasingCategory"
    Me.gcPurchasingCategory.Name = "gcPurchasingCategory"
    Me.gcPurchasingCategory.OptionsColumn.ReadOnly = True
    '
    'GridColumn19
    '
    Me.GridColumn19.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn19.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn19.Caption = "Box Qty"
    Me.GridColumn19.DisplayFormat.FormatString = "N1"
    Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn19.FieldName = "POBatchSize"
    Me.GridColumn19.Name = "GridColumn19"
    '
    'GridColumn13
    '
    Me.GridColumn13.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn13.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn13.Caption = "Part No"
    Me.GridColumn13.FieldName = "PartNo"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.OptionsColumn.ReadOnly = True
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 3
    Me.GridColumn13.Width = 82
    '
    'GridColumn14
    '
    Me.GridColumn14.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn14.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn14.Caption = "Imported Stock Code"
    Me.GridColumn14.FieldName = "ImportedStockCode"
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.OptionsColumn.ReadOnly = True
    Me.GridColumn14.Visible = True
    Me.GridColumn14.VisibleIndex = 1
    Me.GridColumn14.Width = 104
    '
    'GridColumn15
    '
    Me.GridColumn15.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn15.Caption = "Commodity Code"
    Me.GridColumn15.FieldName = "CommodityCode"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.OptionsColumn.ReadOnly = True
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 4
    Me.GridColumn15.Width = 101
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
    Me.Name = "frmStockItemPurchasing"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Managed Stock Items"
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    CType(Me.pucOrders, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pucOrders.ResumeLayout(False)
    CType(Me.grdOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repoETA.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repoETA, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repCategory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemRadioGroupCategory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pucAllocations, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pucAllocations.ResumeLayout(False)
    CType(Me.grdStockItemAllocations, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockItemAllocations, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repProdStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repProdStartDate, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdStockItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitpucAllocations, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitpucOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemSpinEditQty, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bargCategory As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepoItemRadioGroupCategory As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
  Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents gcAllocatedQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOnOrderQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCurrentStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbtnLoad As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RepoItemSpinEditQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnSetAllToOrder As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bsubitProcessToPO As DevExpress.XtraBars.BarSubItem
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProposedQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPurchasingCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbiExportToExcel As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcToOrder As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbiGenerateSupplierPos As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbiAssingToSupplierPOs As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents repitOpenStockItemTransactionHistory As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents bcboCategory As DevExpress.XtraBars.BarEditItem
  Friend WithEvents repCategory As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents pucAllocations As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents grdStockItemAllocations As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockItemAllocations As Grid.GridView
  Friend WithEvents repitpucAllocations As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents pucOrders As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents grdOrders As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvOrders As Grid.GridView
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitpucOrders As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repProdStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents repoETA As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
End Class
