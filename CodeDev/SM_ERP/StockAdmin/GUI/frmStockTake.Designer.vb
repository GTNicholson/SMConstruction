<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockTake
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockTake))
    Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.puccStockItemValuationHistorys = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdStockItemValuationHistorys = New DevExpress.XtraGrid.GridControl()
    Me.gvStockItemValuationHistorys = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barbtnSaveExit = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnExcelExport = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnRefreshStockItems = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnRefreshSystemQty = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnFIFOSystemValue = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnFIFOCountedValue = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnAplicarCantidadesContado = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.bbtnStockValuation = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnLoadDespatchedQty = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnRefreshWIPItems = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnGoodsInInvoiced = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnCommitStockTake = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnPrintCountSheet = New DevExpress.XtraBars.BarButtonItem()
    Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitbtStockItemRefresh = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gvStockCheckItem = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCountedQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemSpinEditCounted = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcIsCounted = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcDiscrepency = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStockTakeSheet = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcWriteOffQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.grdStockCheckItem = New DevExpress.XtraGrid.GridControl()
    Me.repitPUStockItemValuationHistorys = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.grpDetail = New DevExpress.XtraEditors.GroupControl()
    Me.btnAutoCreateSheets = New DevExpress.XtraEditors.SimpleButton()
    Me.btnDeselectAll = New DevExpress.XtraEditors.SimpleButton()
    Me.lblViewMode = New DevExpress.XtraEditors.LabelControl()
    Me.btnDeselectVisible = New DevExpress.XtraEditors.SimpleButton()
    Me.radGRNMode = New DevExpress.XtraEditors.RadioGroup()
    Me.btnSelectVisible = New DevExpress.XtraEditors.SimpleButton()
    Me.pceStockTakeSheets = New DevExpress.XtraEditors.PopupContainerEdit()
    Me.pccStockTakeSheets = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdStockTakeSheets = New DevExpress.XtraGrid.GridControl()
    Me.gvStockTakeSheets = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNoOfItems = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repDateFormat = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repbtnViewSheet = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.btnAddToNextSheet = New DevExpress.XtraEditors.SimpleButton()
    Me.datDateSystemQty = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.btnClearSystemQty = New DevExpress.XtraEditors.SimpleButton()
    Me.btnClearRange = New DevExpress.XtraEditors.SimpleButton()
    Me.btnApplyRange = New DevExpress.XtraEditors.SimpleButton()
    Me.lblRangeEnd = New DevExpress.XtraEditors.LabelControl()
    Me.lblRangeStart = New DevExpress.XtraEditors.LabelControl()
    Me.txtRangeStockCodeEnd = New DevExpress.XtraEditors.TextEdit()
    Me.lblRange = New DevExpress.XtraEditors.LabelControl()
    Me.txtRangeStockCodeStart = New DevExpress.XtraEditors.TextEdit()
    Me.dateStockCheck = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.txtStockCheckDesc = New DevExpress.XtraEditors.TextEdit()
    Me.grpItemDetail = New DevExpress.XtraEditors.GroupControl()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    CType(Me.puccStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.puccStockItemValuationHistorys.SuspendLayout()
    CType(Me.grdStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitbtStockItemRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockCheckItem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSpinEditCounted, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdStockCheckItem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitPUStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpDetail.SuspendLayout()
    CType(Me.radGRNMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pceStockTakeSheets.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pccStockTakeSheets, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pccStockTakeSheets.SuspendLayout()
    CType(Me.grdStockTakeSheets, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockTakeSheets, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repDateFormat, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repDateFormat.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repbtnViewSheet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datDateSystemQty.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datDateSystemQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRangeStockCodeEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRangeStockCodeStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dateStockCheck.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dateStockCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStockCheckDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpItemDetail.SuspendLayout()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    Me.SuspendLayout()
    '
    'puccStockItemValuationHistorys
    '
    Me.puccStockItemValuationHistorys.Controls.Add(Me.grdStockItemValuationHistorys)
    Me.puccStockItemValuationHistorys.Location = New System.Drawing.Point(338, 256)
    Me.puccStockItemValuationHistorys.Name = "puccStockItemValuationHistorys"
    Me.puccStockItemValuationHistorys.Size = New System.Drawing.Size(510, 220)
    Me.puccStockItemValuationHistorys.TabIndex = 7
    '
    'grdStockItemValuationHistorys
    '
    Me.grdStockItemValuationHistorys.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockItemValuationHistorys.Location = New System.Drawing.Point(0, 0)
    Me.grdStockItemValuationHistorys.MainView = Me.gvStockItemValuationHistorys
    Me.grdStockItemValuationHistorys.MenuManager = Me.BarManager1
    Me.grdStockItemValuationHistorys.Name = "grdStockItemValuationHistorys"
    Me.grdStockItemValuationHistorys.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
    Me.grdStockItemValuationHistorys.Size = New System.Drawing.Size(510, 220)
    Me.grdStockItemValuationHistorys.TabIndex = 0
    Me.grdStockItemValuationHistorys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItemValuationHistorys})
    '
    'gvStockItemValuationHistorys
    '
    Me.gvStockItemValuationHistorys.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvStockItemValuationHistorys.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockItemValuationHistorys.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvStockItemValuationHistorys.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockItemValuationHistorys.Appearance.Row.BackColor = System.Drawing.Color.Lavender
    Me.gvStockItemValuationHistorys.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvStockItemValuationHistorys.Appearance.Row.Options.UseBackColor = True
    Me.gvStockItemValuationHistorys.Appearance.Row.Options.UseFont = True
    Me.gvStockItemValuationHistorys.ColumnPanelRowHeight = 34
    Me.gvStockItemValuationHistorys.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn16, Me.GridColumn13, Me.GridColumn7, Me.GridColumn17, Me.GridColumn14, Me.GridColumn15})
    Me.gvStockItemValuationHistorys.GridControl = Me.grdStockItemValuationHistorys
    Me.gvStockItemValuationHistorys.Name = "gvStockItemValuationHistorys"
    Me.gvStockItemValuationHistorys.OptionsBehavior.ReadOnly = True
    Me.gvStockItemValuationHistorys.OptionsView.ShowFooter = True
    Me.gvStockItemValuationHistorys.OptionsView.ShowGroupPanel = False
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Ref."
    Me.GridColumn12.FieldName = "RefInfo"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 0
    Me.GridColumn12.Width = 71
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "Received Date"
    Me.GridColumn16.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn16.FieldName = "ReceivedDate"
    Me.GridColumn16.Name = "GridColumn16"
    Me.GridColumn16.Visible = True
    Me.GridColumn16.VisibleIndex = 1
    Me.GridColumn16.Width = 64
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Unit Cost"
    Me.GridColumn13.DisplayFormat.FormatString = "c2"
    Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn13.FieldName = "UnitCost"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 2
    Me.GridColumn13.Width = 58
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Inv. Price"
    Me.GridColumn7.DisplayFormat.FormatString = "c2"
    Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn7.FieldName = "AverageInvoicePrice"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 3
    '
    'GridColumn17
    '
    Me.GridColumn17.Caption = "Received Qty"
    Me.GridColumn17.DisplayFormat.FormatString = "N2"
    Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn17.FieldName = "ReceivedQty"
    Me.GridColumn17.Name = "GridColumn17"
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 4
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "Calc Qty"
    Me.GridColumn14.DisplayFormat.FormatString = "N2"
    Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn14.FieldName = "Quantity"
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.Visible = True
    Me.GridColumn14.VisibleIndex = 5
    '
    'GridColumn15
    '
    Me.GridColumn15.Caption = "Total Cost"
    Me.GridColumn15.DisplayFormat.FormatString = "c2"
    Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn15.FieldName = "TotalCost"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total Cost", "{0:N2}")})
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 6
    Me.GridColumn15.Width = 91
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnSaveExit, Me.barbtnClose, Me.barbtnSave, Me.barbtnExcelExport, Me.bbtnStockValuation, Me.barbtnLoadDespatchedQty, Me.bbtnRefreshWIPItems, Me.bbtnGoodsInInvoiced, Me.bbtnRefreshStockItems, Me.barbtnRefreshSystemQty, Me.barbtnCommitStockTake, Me.barbtnPrintCountSheet, Me.barbtnFIFOSystemValue, Me.barbtnFIFOCountedValue, Me.bbtnAplicarCantidadesContado})
    Me.BarManager1.MaxItemId = 23
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSaveExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnExcelExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnRefreshStockItems, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnRefreshSystemQty), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnFIFOSystemValue, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnFIFOCountedValue), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnAplicarCantidadesContado, True)})
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DisableClose = True
    Me.Bar1.OptionsBar.DisableCustomization = True
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.OptionsBar.UseWholeRow = True
    Me.Bar1.Text = "Tools"
    '
    'barbtnSaveExit
    '
    Me.barbtnSaveExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnSaveExit.Caption = "Guardar && Salir"
    Me.barbtnSaveExit.Id = 0
    Me.barbtnSaveExit.ImageOptions.Image = CType(resources.GetObject("barbtnSaveExit.ImageOptions.Image"), System.Drawing.Image)
    Me.barbtnSaveExit.ImageOptions.LargeImage = CType(resources.GetObject("barbtnSaveExit.ImageOptions.LargeImage"), System.Drawing.Image)
    Me.barbtnSaveExit.Name = "barbtnSaveExit"
    '
    'barbtnSave
    '
    Me.barbtnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnSave.Caption = "Guardar"
    Me.barbtnSave.Id = 2
    Me.barbtnSave.ImageOptions.Image = CType(resources.GetObject("barbtnSave.ImageOptions.Image"), System.Drawing.Image)
    Me.barbtnSave.ImageOptions.LargeImage = CType(resources.GetObject("barbtnSave.ImageOptions.LargeImage"), System.Drawing.Image)
    Me.barbtnSave.Name = "barbtnSave"
    '
    'barbtnClose
    '
    Me.barbtnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnClose.Caption = "Cerrar"
    Me.barbtnClose.Id = 1
    Me.barbtnClose.ImageOptions.Image = CType(resources.GetObject("barbtnClose.ImageOptions.Image"), System.Drawing.Image)
    Me.barbtnClose.ImageOptions.LargeImage = CType(resources.GetObject("barbtnClose.ImageOptions.LargeImage"), System.Drawing.Image)
    Me.barbtnClose.Name = "barbtnClose"
    '
    'barbtnExcelExport
    '
    Me.barbtnExcelExport.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
    Me.barbtnExcelExport.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnExcelExport.Caption = "Excel Export"
    Me.barbtnExcelExport.Id = 4
    Me.barbtnExcelExport.Name = "barbtnExcelExport"
    '
    'bbtnRefreshStockItems
    '
    Me.bbtnRefreshStockItems.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnRefreshStockItems.Caption = "Refrescar Artículos"
    Me.bbtnRefreshStockItems.Id = 16
    Me.bbtnRefreshStockItems.Name = "bbtnRefreshStockItems"
    '
    'barbtnRefreshSystemQty
    '
    Me.barbtnRefreshSystemQty.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnRefreshSystemQty.Caption = "Refrescar Cantidad de Sistema"
    Me.barbtnRefreshSystemQty.Id = 17
    Me.barbtnRefreshSystemQty.Name = "barbtnRefreshSystemQty"
    '
    'barbtnFIFOSystemValue
    '
    Me.barbtnFIFOSystemValue.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnFIFOSystemValue.Caption = "Valor de Sistema PEPS"
    Me.barbtnFIFOSystemValue.Id = 20
    Me.barbtnFIFOSystemValue.Name = "barbtnFIFOSystemValue"
    '
    'barbtnFIFOCountedValue
    '
    Me.barbtnFIFOCountedValue.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnFIFOCountedValue.Caption = "Valor contado PEPS"
    Me.barbtnFIFOCountedValue.Id = 21
    Me.barbtnFIFOCountedValue.Name = "barbtnFIFOCountedValue"
    '
    'bbtnAplicarCantidadesContado
    '
    Me.bbtnAplicarCantidadesContado.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnAplicarCantidadesContado.Caption = "Aplicar Cantidades Contado"
    Me.bbtnAplicarCantidadesContado.Id = 22
    Me.bbtnAplicarCantidadesContado.Name = "bbtnAplicarCantidadesContado"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1370, 35)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 711)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1370, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 35)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 676)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1370, 35)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 676)
    '
    'bbtnStockValuation
    '
    Me.bbtnStockValuation.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
    Me.bbtnStockValuation.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnStockValuation.Caption = "FIFO Stock Valuation"
    Me.bbtnStockValuation.Id = 6
    Me.bbtnStockValuation.Name = "bbtnStockValuation"
    '
    'barbtnLoadDespatchedQty
    '
    Me.barbtnLoadDespatchedQty.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
    Me.barbtnLoadDespatchedQty.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnLoadDespatchedQty.Caption = "Refresh Inv / Desp Qty"
    Me.barbtnLoadDespatchedQty.Id = 8
    Me.barbtnLoadDespatchedQty.Name = "barbtnLoadDespatchedQty"
    '
    'bbtnRefreshWIPItems
    '
    Me.bbtnRefreshWIPItems.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnRefreshWIPItems.Caption = "Refresh WIP Items"
    Me.bbtnRefreshWIPItems.Id = 14
    Me.bbtnRefreshWIPItems.Name = "bbtnRefreshWIPItems"
    '
    'bbtnGoodsInInvoiced
    '
    Me.bbtnGoodsInInvoiced.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
    Me.bbtnGoodsInInvoiced.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnGoodsInInvoiced.Caption = "Refresh Goods In Invoiced Qty"
    Me.bbtnGoodsInInvoiced.Id = 15
    Me.bbtnGoodsInInvoiced.Name = "bbtnGoodsInInvoiced"
    '
    'barbtnCommitStockTake
    '
    Me.barbtnCommitStockTake.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnCommitStockTake.Caption = "Commit Stock Take"
    Me.barbtnCommitStockTake.Id = 18
    Me.barbtnCommitStockTake.Name = "barbtnCommitStockTake"
    '
    'barbtnPrintCountSheet
    '
    Me.barbtnPrintCountSheet.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnPrintCountSheet.Caption = "Print Count Sheet"
    Me.barbtnPrintCountSheet.Id = 19
    Me.barbtnPrintCountSheet.Name = "barbtnPrintCountSheet"
    '
    'RepositoryItemComboBox1
    '
    Me.RepositoryItemComboBox1.AutoHeight = False
    Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Descripción"
    Me.GridColumn6.FieldName = "SIDescription"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.ReadOnly = True
    Me.GridColumn6.OptionsColumn.TabStop = False
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 7
    Me.GridColumn6.Width = 67
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Sub Categoría"
    Me.GridColumn5.FieldName = "StockItemTypeDesc"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.OptionsColumn.ReadOnly = True
    Me.GridColumn5.OptionsColumn.TabStop = False
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 5
    Me.GridColumn5.Width = 37
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Categoría"
    Me.GridColumn4.FieldName = "StockItemCategoryDesc"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.OptionsColumn.ReadOnly = True
    Me.GridColumn4.OptionsColumn.TabStop = False
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 4
    Me.GridColumn4.Width = 46
    '
    'gcStockCode
    '
    Me.gcStockCode.Caption = "Código Inventario"
    Me.gcStockCode.ColumnEdit = Me.repitbtStockItemRefresh
    Me.gcStockCode.FieldName = "SIStockCode"
    Me.gcStockCode.Name = "gcStockCode"
    Me.gcStockCode.OptionsColumn.ReadOnly = True
    Me.gcStockCode.OptionsColumn.TabStop = False
    Me.gcStockCode.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcStockCode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StockCode", "{0}")})
    Me.gcStockCode.Visible = True
    Me.gcStockCode.VisibleIndex = 1
    Me.gcStockCode.Width = 50
    '
    'repitbtStockItemRefresh
    '
    Me.repitbtStockItemRefresh.AutoHeight = False
    EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
    Me.repitbtStockItemRefresh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
    Me.repitbtStockItemRefresh.Name = "repitbtStockItemRefresh"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Código de Barra"
    Me.GridColumn1.FieldName = "Barcode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.OptionsColumn.TabStop = False
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    Me.GridColumn1.Width = 46
    '
    'gvStockCheckItem
    '
    Me.gvStockCheckItem.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvStockCheckItem.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockCheckItem.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvStockCheckItem.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockCheckItem.Appearance.Row.BackColor = System.Drawing.Color.Lavender
    Me.gvStockCheckItem.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvStockCheckItem.Appearance.Row.Options.UseBackColor = True
    Me.gvStockCheckItem.Appearance.Row.Options.UseFont = True
    Me.gvStockCheckItem.ColumnPanelRowHeight = 34
    Me.gvStockCheckItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.gcStockCode, Me.GridColumn23, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.gcCountedQty, Me.GridColumn20, Me.gcIsCounted, Me.gcDiscrepency, Me.GridColumn2, Me.gcStockTakeSheet, Me.GridColumn9, Me.GridColumn3, Me.GridColumn21, Me.GridColumn24, Me.GridColumn22, Me.gcWriteOffQuantity})
    Me.gvStockCheckItem.CustomizationFormBounds = New System.Drawing.Rectangle(1156, 318, 210, 270)
    Me.gvStockCheckItem.GridControl = Me.grdStockCheckItem
    Me.gvStockCheckItem.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, Nothing, Me.gcStockCode, "")})
    Me.gvStockCheckItem.Name = "gvStockCheckItem"
    Me.gvStockCheckItem.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvStockCheckItem.OptionsDetail.EnableMasterViewMode = False
    Me.gvStockCheckItem.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
    Me.gvStockCheckItem.OptionsView.ShowAutoFilterRow = True
    Me.gvStockCheckItem.OptionsView.ShowFooter = True
    Me.gvStockCheckItem.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcStockCode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn23
    '
    Me.GridColumn23.Caption = "Código ASIS"
    Me.GridColumn23.FieldName = "ASISID"
    Me.GridColumn23.Name = "GridColumn23"
    Me.GridColumn23.Visible = True
    Me.GridColumn23.VisibleIndex = 3
    Me.GridColumn23.Width = 35
    '
    'gcCountedQty
    '
    Me.gcCountedQty.AppearanceCell.BackColor = System.Drawing.Color.White
    Me.gcCountedQty.AppearanceCell.Options.UseBackColor = True
    Me.gcCountedQty.Caption = "Cantidad Contada"
    Me.gcCountedQty.ColumnEdit = Me.RepositoryItemSpinEditCounted
    Me.gcCountedQty.DisplayFormat.FormatString = "0.##;;0"
    Me.gcCountedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcCountedQty.FieldName = "gcCountedQty"
    Me.gcCountedQty.Name = "gcCountedQty"
    Me.gcCountedQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gcCountedQty", "{0:0.##;;0}")})
    Me.gcCountedQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcCountedQty.Visible = True
    Me.gcCountedQty.VisibleIndex = 10
    Me.gcCountedQty.Width = 37
    '
    'RepositoryItemSpinEditCounted
    '
    Me.RepositoryItemSpinEditCounted.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
    Me.RepositoryItemSpinEditCounted.AutoHeight = False
    Me.RepositoryItemSpinEditCounted.DisplayFormat.FormatString = "#.##"
    Me.RepositoryItemSpinEditCounted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemSpinEditCounted.EditFormat.FormatString = "#.##"
    Me.RepositoryItemSpinEditCounted.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemSpinEditCounted.Name = "RepositoryItemSpinEditCounted"
    '
    'GridColumn20
    '
    Me.GridColumn20.Caption = "Número Parte"
    Me.GridColumn20.FieldName = "PartNo"
    Me.GridColumn20.Name = "GridColumn20"
    Me.GridColumn20.OptionsColumn.ReadOnly = True
    Me.GridColumn20.OptionsColumn.TabStop = False
    Me.GridColumn20.Visible = True
    Me.GridColumn20.VisibleIndex = 6
    Me.GridColumn20.Width = 42
    '
    'gcIsCounted
    '
    Me.gcIsCounted.AppearanceCell.BackColor = System.Drawing.Color.White
    Me.gcIsCounted.AppearanceCell.Options.UseBackColor = True
    Me.gcIsCounted.Caption = "Conteo"
    Me.gcIsCounted.FieldName = "IsCounted"
    Me.gcIsCounted.Name = "gcIsCounted"
    Me.gcIsCounted.Visible = True
    Me.gcIsCounted.VisibleIndex = 9
    Me.gcIsCounted.Width = 36
    '
    'gcDiscrepency
    '
    Me.gcDiscrepency.Caption = "Diferencia"
    Me.gcDiscrepency.DisplayFormat.FormatString = "0.##;;#"
    Me.gcDiscrepency.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcDiscrepency.FieldName = "gcDiscrepency"
    Me.gcDiscrepency.Name = "gcDiscrepency"
    Me.gcDiscrepency.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gcDiscrepency", "{0:0.##;;#}")})
    Me.gcDiscrepency.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcDiscrepency.Visible = True
    Me.gcDiscrepency.VisibleIndex = 12
    Me.gcDiscrepency.Width = 39
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Cantidad en Sistema"
    Me.GridColumn2.DisplayFormat.FormatString = "0.##;;#"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn2.FieldName = "SnapshotQty"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SnapshotQty", "{0:0.##;;#}")})
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 8
    Me.GridColumn2.Width = 37
    '
    'gcStockTakeSheet
    '
    Me.gcStockTakeSheet.Caption = "Hoja"
    Me.gcStockTakeSheet.FieldName = "gcStockTakeSheet"
    Me.gcStockTakeSheet.Name = "gcStockTakeSheet"
    Me.gcStockTakeSheet.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcStockTakeSheet.Visible = True
    Me.gcStockTakeSheet.VisibleIndex = 17
    Me.gcStockTakeSheet.Width = 20
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Seleccionar"
    Me.GridColumn9.FieldName = "TempSelected"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 0
    Me.GridColumn9.Width = 20
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Valor de Sistema"
    Me.GridColumn3.DisplayFormat.FormatString = "£#,##0.00;;#"
    Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn3.FieldName = "SystemTotalValue"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SystemTotalValue", "{0:£#,##0.00;;#}")})
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 13
    Me.GridColumn3.Width = 32
    '
    'GridColumn21
    '
    Me.GridColumn21.Caption = "Valor Contado"
    Me.GridColumn21.DisplayFormat.FormatString = "£#,##0.00;;#"
    Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn21.FieldName = "CountedTotalValue"
    Me.GridColumn21.Name = "GridColumn21"
    Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CountedTotalValue", "{0:£#,##0.00;;#}")})
    Me.GridColumn21.Visible = True
    Me.GridColumn21.VisibleIndex = 14
    Me.GridColumn21.Width = 29
    '
    'GridColumn24
    '
    Me.GridColumn24.Caption = "Valor de Desechos"
    Me.GridColumn24.DisplayFormat.FormatString = "£#,##0.00;;#"
    Me.GridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn24.FieldName = "WriteOffValue"
    Me.GridColumn24.Name = "GridColumn24"
    Me.GridColumn24.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WriteOffValue", "{0:£#,##0.00;;#}")})
    Me.GridColumn24.Visible = True
    Me.GridColumn24.VisibleIndex = 15
    Me.GridColumn24.Width = 33
    '
    'GridColumn22
    '
    Me.GridColumn22.Caption = "Valor de Diferencia"
    Me.GridColumn22.DisplayFormat.FormatString = "£#,##0.00;;#"
    Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn22.FieldName = "ValueDescrepency"
    Me.GridColumn22.Name = "GridColumn22"
    Me.GridColumn22.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValueDescrepency", "{0:£#,##0.00;;#}")})
    Me.GridColumn22.Visible = True
    Me.GridColumn22.VisibleIndex = 16
    Me.GridColumn22.Width = 27
    '
    'gcWriteOffQuantity
    '
    Me.gcWriteOffQuantity.AppearanceCell.BackColor = System.Drawing.Color.White
    Me.gcWriteOffQuantity.AppearanceCell.Options.UseBackColor = True
    Me.gcWriteOffQuantity.Caption = "Cantidad Desechos"
    Me.gcWriteOffQuantity.ColumnEdit = Me.RepositoryItemSpinEditCounted
    Me.gcWriteOffQuantity.FieldName = "gcWriteOffQuantity"
    Me.gcWriteOffQuantity.Name = "gcWriteOffQuantity"
    Me.gcWriteOffQuantity.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcWriteOffQuantity.Visible = True
    Me.gcWriteOffQuantity.VisibleIndex = 11
    Me.gcWriteOffQuantity.Width = 59
    '
    'grdStockCheckItem
    '
    Me.grdStockCheckItem.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockCheckItem.Location = New System.Drawing.Point(2, 26)
    Me.grdStockCheckItem.MainView = Me.gvStockCheckItem
    Me.grdStockCheckItem.Name = "grdStockCheckItem"
    Me.grdStockCheckItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitPUStockItemValuationHistorys, Me.RepositoryItemSpinEditCounted, Me.repitbtStockItemRefresh})
    Me.grdStockCheckItem.Size = New System.Drawing.Size(1355, 518)
    Me.grdStockCheckItem.TabIndex = 6
    Me.grdStockCheckItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockCheckItem})
    '
    'repitPUStockItemValuationHistorys
    '
    Me.repitPUStockItemValuationHistorys.Appearance.Options.UseTextOptions = True
    Me.repitPUStockItemValuationHistorys.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.repitPUStockItemValuationHistorys.AutoHeight = False
    Me.repitPUStockItemValuationHistorys.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repitPUStockItemValuationHistorys.DisplayFormat.FormatString = "N2"
    Me.repitPUStockItemValuationHistorys.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.repitPUStockItemValuationHistorys.EditFormat.FormatString = "N2"
    Me.repitPUStockItemValuationHistorys.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.repitPUStockItemValuationHistorys.Name = "repitPUStockItemValuationHistorys"
    Me.repitPUStockItemValuationHistorys.PopupControl = Me.puccStockItemValuationHistorys
    '
    'grpDetail
    '
    Me.grpDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpDetail.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpDetail.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpDetail.AppearanceCaption.Options.UseFont = True
    Me.grpDetail.AppearanceCaption.Options.UseForeColor = True
    Me.grpDetail.Controls.Add(Me.btnAutoCreateSheets)
    Me.grpDetail.Controls.Add(Me.btnDeselectAll)
    Me.grpDetail.Controls.Add(Me.lblViewMode)
    Me.grpDetail.Controls.Add(Me.btnDeselectVisible)
    Me.grpDetail.Controls.Add(Me.radGRNMode)
    Me.grpDetail.Controls.Add(Me.btnSelectVisible)
    Me.grpDetail.Controls.Add(Me.pceStockTakeSheets)
    Me.grpDetail.Controls.Add(Me.btnAddToNextSheet)
    Me.grpDetail.Controls.Add(Me.datDateSystemQty)
    Me.grpDetail.Controls.Add(Me.LabelControl1)
    Me.grpDetail.Controls.Add(Me.btnClearSystemQty)
    Me.grpDetail.Controls.Add(Me.btnClearRange)
    Me.grpDetail.Controls.Add(Me.btnApplyRange)
    Me.grpDetail.Controls.Add(Me.lblRangeEnd)
    Me.grpDetail.Controls.Add(Me.lblRangeStart)
    Me.grpDetail.Controls.Add(Me.txtRangeStockCodeEnd)
    Me.grpDetail.Controls.Add(Me.lblRange)
    Me.grpDetail.Controls.Add(Me.txtRangeStockCodeStart)
    Me.grpDetail.Controls.Add(Me.dateStockCheck)
    Me.grpDetail.Controls.Add(Me.LabelControl7)
    Me.grpDetail.Controls.Add(Me.LabelControl8)
    Me.grpDetail.Controls.Add(Me.txtStockCheckDesc)
    Me.grpDetail.Location = New System.Drawing.Point(6, 6)
    Me.grpDetail.Name = "grpDetail"
    Me.grpDetail.Size = New System.Drawing.Size(1359, 113)
    Me.grpDetail.TabIndex = 95
    Me.grpDetail.Text = "Captura de Inentario"
    '
    'btnAutoCreateSheets
    '
    Me.btnAutoCreateSheets.Location = New System.Drawing.Point(1030, 44)
    Me.btnAutoCreateSheets.Name = "btnAutoCreateSheets"
    Me.btnAutoCreateSheets.Size = New System.Drawing.Size(109, 23)
    Me.btnAutoCreateSheets.TabIndex = 206
    Me.btnAutoCreateSheets.Text = "Auto crear Hojas"
    '
    'btnDeselectAll
    '
    Me.btnDeselectAll.Location = New System.Drawing.Point(289, 86)
    Me.btnDeselectAll.Name = "btnDeselectAll"
    Me.btnDeselectAll.Size = New System.Drawing.Size(105, 23)
    Me.btnDeselectAll.TabIndex = 68
    Me.btnDeselectAll.Text = "Deseleccionar Todo"
    '
    'lblViewMode
    '
    Me.lblViewMode.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblViewMode.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.lblViewMode.Appearance.Options.UseFont = True
    Me.lblViewMode.Appearance.Options.UseForeColor = True
    Me.lblViewMode.Location = New System.Drawing.Point(406, 88)
    Me.lblViewMode.Name = "lblViewMode"
    Me.lblViewMode.Size = New System.Drawing.Size(79, 14)
    Me.lblViewMode.TabIndex = 205
    Me.lblViewMode.Text = "Modo de Vista"
    '
    'btnDeselectVisible
    '
    Me.btnDeselectVisible.Location = New System.Drawing.Point(172, 85)
    Me.btnDeselectVisible.Name = "btnDeselectVisible"
    Me.btnDeselectVisible.Size = New System.Drawing.Size(111, 23)
    Me.btnDeselectVisible.TabIndex = 66
    Me.btnDeselectVisible.Text = "Deseleccionar Visible"
    '
    'radGRNMode
    '
    Me.radGRNMode.EditValue = CType(2, Byte)
    Me.radGRNMode.Location = New System.Drawing.Point(491, 85)
    Me.radGRNMode.Name = "radGRNMode"
    Me.radGRNMode.Properties.AllowMouseWheel = False
    Me.radGRNMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.radGRNMode.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.radGRNMode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.radGRNMode.Properties.Appearance.Options.UseBackColor = True
    Me.radGRNMode.Properties.Appearance.Options.UseFont = True
    Me.radGRNMode.Properties.Appearance.Options.UseForeColor = True
    Me.radGRNMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.radGRNMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Byte), "Todo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Byte), "No Asignado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Byte), "Conteo")})
    Me.radGRNMode.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
    Me.radGRNMode.Size = New System.Drawing.Size(275, 20)
    Me.radGRNMode.TabIndex = 204
    '
    'btnSelectVisible
    '
    Me.btnSelectVisible.Location = New System.Drawing.Point(63, 85)
    Me.btnSelectVisible.Name = "btnSelectVisible"
    Me.btnSelectVisible.Size = New System.Drawing.Size(103, 23)
    Me.btnSelectVisible.TabIndex = 65
    Me.btnSelectVisible.Text = "Seleccionar Visible"
    '
    'pceStockTakeSheets
    '
    Me.pceStockTakeSheets.Location = New System.Drawing.Point(924, 46)
    Me.pceStockTakeSheets.MenuManager = Me.BarManager1
    Me.pceStockTakeSheets.Name = "pceStockTakeSheets"
    Me.pceStockTakeSheets.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.pceStockTakeSheets.Properties.PopupControl = Me.pccStockTakeSheets
    Me.pceStockTakeSheets.Size = New System.Drawing.Size(100, 20)
    Me.pceStockTakeSheets.TabIndex = 64
    '
    'pccStockTakeSheets
    '
    Me.pccStockTakeSheets.Controls.Add(Me.grdStockTakeSheets)
    Me.pccStockTakeSheets.Location = New System.Drawing.Point(942, 256)
    Me.pccStockTakeSheets.Name = "pccStockTakeSheets"
    Me.pccStockTakeSheets.Size = New System.Drawing.Size(501, 220)
    Me.pccStockTakeSheets.TabIndex = 206
    '
    'grdStockTakeSheets
    '
    Me.grdStockTakeSheets.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockTakeSheets.Location = New System.Drawing.Point(0, 0)
    Me.grdStockTakeSheets.MainView = Me.gvStockTakeSheets
    Me.grdStockTakeSheets.MenuManager = Me.BarManager1
    Me.grdStockTakeSheets.Name = "grdStockTakeSheets"
    Me.grdStockTakeSheets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repDateFormat, Me.repbtnViewSheet})
    Me.grdStockTakeSheets.Size = New System.Drawing.Size(501, 220)
    Me.grdStockTakeSheets.TabIndex = 0
    Me.grdStockTakeSheets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockTakeSheets})
    '
    'gvStockTakeSheets
    '
    Me.gvStockTakeSheets.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvStockTakeSheets.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockTakeSheets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.gcNoOfItems, Me.GridColumn10, Me.GridColumn11, Me.GridColumn18, Me.GridColumn19})
    Me.gvStockTakeSheets.GridControl = Me.grdStockTakeSheets
    Me.gvStockTakeSheets.Name = "gvStockTakeSheets"
    Me.gvStockTakeSheets.OptionsView.ShowGroupPanel = False
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Sheet No"
    Me.GridColumn8.FieldName = "SheetNo"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 1
    Me.GridColumn8.Width = 164
    '
    'gcNoOfItems
    '
    Me.gcNoOfItems.Caption = "Number of Items"
    Me.gcNoOfItems.DisplayFormat.FormatString = "#"
    Me.gcNoOfItems.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcNoOfItems.FieldName = "gcNoOfItems"
    Me.gcNoOfItems.Name = "gcNoOfItems"
    Me.gcNoOfItems.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
    Me.gcNoOfItems.Visible = True
    Me.gcNoOfItems.VisibleIndex = 3
    Me.gcNoOfItems.Width = 201
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Description"
    Me.GridColumn10.FieldName = "Description"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 2
    Me.GridColumn10.Width = 266
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Issued"
    Me.GridColumn11.ColumnEdit = Me.repDateFormat
    Me.GridColumn11.FieldName = "DateIssued"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 4
    Me.GridColumn11.Width = 153
    '
    'repDateFormat
    '
    Me.repDateFormat.AutoHeight = False
    Me.repDateFormat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions1)})
    Me.repDateFormat.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repDateFormat.Name = "repDateFormat"
    Me.repDateFormat.NullDate = New Date(CType(0, Long))
    '
    'GridColumn18
    '
    Me.GridColumn18.Caption = "Processed"
    Me.GridColumn18.ColumnEdit = Me.repDateFormat
    Me.GridColumn18.FieldName = "DateProcessed"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.Visible = True
    Me.GridColumn18.VisibleIndex = 5
    Me.GridColumn18.Width = 160
    '
    'GridColumn19
    '
    Me.GridColumn19.Caption = " "
    Me.GridColumn19.ColumnEdit = Me.repbtnViewSheet
    Me.GridColumn19.Name = "GridColumn19"
    Me.GridColumn19.Visible = True
    Me.GridColumn19.VisibleIndex = 0
    Me.GridColumn19.Width = 86
    '
    'repbtnViewSheet
    '
    Me.repbtnViewSheet.AutoHeight = False
    Me.repbtnViewSheet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "View", -1, True, True, False, EditorButtonImageOptions2)})
    Me.repbtnViewSheet.Name = "repbtnViewSheet"
    Me.repbtnViewSheet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
    '
    'btnAddToNextSheet
    '
    Me.btnAddToNextSheet.Location = New System.Drawing.Point(809, 44)
    Me.btnAddToNextSheet.Name = "btnAddToNextSheet"
    Me.btnAddToNextSheet.Size = New System.Drawing.Size(109, 23)
    Me.btnAddToNextSheet.TabIndex = 63
    Me.btnAddToNextSheet.Text = "Asignación de Hoja"
    '
    'datDateSystemQty
    '
    Me.datDateSystemQty.EditValue = Nothing
    Me.datDateSystemQty.Location = New System.Drawing.Point(1253, 40)
    Me.datDateSystemQty.MenuManager = Me.BarManager1
    Me.datDateSystemQty.Name = "datDateSystemQty"
    Me.datDateSystemQty.Properties.AllowMouseWheel = False
    Me.datDateSystemQty.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.datDateSystemQty.Properties.Appearance.Options.UseFont = True
    Me.datDateSystemQty.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datDateSystemQty.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
    Me.datDateSystemQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.datDateSystemQty.Properties.NullDate = New Date(CType(0, Long))
    Me.datDateSystemQty.Properties.ReadOnly = True
    Me.datDateSystemQty.Size = New System.Drawing.Size(99, 22)
    Me.datDateSystemQty.TabIndex = 62
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(1141, 43)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(106, 15)
    Me.LabelControl1.TabIndex = 61
    Me.LabelControl1.Text = "Cant. Sistema para"
    '
    'btnClearSystemQty
    '
    Me.btnClearSystemQty.Location = New System.Drawing.Point(809, 86)
    Me.btnClearSystemQty.Name = "btnClearSystemQty"
    Me.btnClearSystemQty.Size = New System.Drawing.Size(108, 23)
    Me.btnClearSystemQty.TabIndex = 59
    Me.btnClearSystemQty.Text = "Limpiar Cantidad"
    Me.btnClearSystemQty.Visible = False
    '
    'btnClearRange
    '
    Me.btnClearRange.Location = New System.Drawing.Point(923, 86)
    Me.btnClearRange.Name = "btnClearRange"
    Me.btnClearRange.Size = New System.Drawing.Size(150, 23)
    Me.btnClearRange.TabIndex = 56
    Me.btnClearRange.Text = "Limpiar Cantidad Contada"
    '
    'btnApplyRange
    '
    Me.btnApplyRange.Location = New System.Drawing.Point(682, 44)
    Me.btnApplyRange.Name = "btnApplyRange"
    Me.btnApplyRange.Size = New System.Drawing.Size(49, 23)
    Me.btnApplyRange.TabIndex = 55
    Me.btnApplyRange.Text = "Seleccionar"
    '
    'lblRangeEnd
    '
    Me.lblRangeEnd.Appearance.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblRangeEnd.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.lblRangeEnd.Appearance.Options.UseFont = True
    Me.lblRangeEnd.Appearance.Options.UseForeColor = True
    Me.lblRangeEnd.Location = New System.Drawing.Point(580, 33)
    Me.lblRangeEnd.Name = "lblRangeEnd"
    Me.lblRangeEnd.Size = New System.Drawing.Size(88, 12)
    Me.lblRangeEnd.TabIndex = 54
    Me.lblRangeEnd.Text = "Código de Inv. Final "
    '
    'lblRangeStart
    '
    Me.lblRangeStart.Appearance.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblRangeStart.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.lblRangeStart.Appearance.Options.UseFont = True
    Me.lblRangeStart.Appearance.Options.UseForeColor = True
    Me.lblRangeStart.Location = New System.Drawing.Point(476, 33)
    Me.lblRangeStart.Name = "lblRangeStart"
    Me.lblRangeStart.Size = New System.Drawing.Size(89, 12)
    Me.lblRangeStart.TabIndex = 53
    Me.lblRangeStart.Text = "Código de Inv. Inicial"
    '
    'txtRangeStockCodeEnd
    '
    Me.txtRangeStockCodeEnd.Location = New System.Drawing.Point(578, 45)
    Me.txtRangeStockCodeEnd.MenuManager = Me.BarManager1
    Me.txtRangeStockCodeEnd.Name = "txtRangeStockCodeEnd"
    Me.txtRangeStockCodeEnd.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRangeStockCodeEnd.Properties.Appearance.Options.UseFont = True
    Me.txtRangeStockCodeEnd.Size = New System.Drawing.Size(98, 22)
    Me.txtRangeStockCodeEnd.TabIndex = 52
    '
    'lblRange
    '
    Me.lblRange.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblRange.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.lblRange.Appearance.Options.UseFont = True
    Me.lblRange.Appearance.Options.UseForeColor = True
    Me.lblRange.Location = New System.Drawing.Point(409, 47)
    Me.lblRange.Name = "lblRange"
    Me.lblRange.Size = New System.Drawing.Size(37, 15)
    Me.lblRange.TabIndex = 51
    Me.lblRange.Text = "Rango"
    '
    'txtRangeStockCodeStart
    '
    Me.txtRangeStockCodeStart.Location = New System.Drawing.Point(474, 45)
    Me.txtRangeStockCodeStart.MenuManager = Me.BarManager1
    Me.txtRangeStockCodeStart.Name = "txtRangeStockCodeStart"
    Me.txtRangeStockCodeStart.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRangeStockCodeStart.Properties.Appearance.Options.UseFont = True
    Me.txtRangeStockCodeStart.Size = New System.Drawing.Size(98, 22)
    Me.txtRangeStockCodeStart.TabIndex = 50
    '
    'dateStockCheck
    '
    Me.dateStockCheck.EditValue = Nothing
    Me.dateStockCheck.Location = New System.Drawing.Point(303, 44)
    Me.dateStockCheck.MenuManager = Me.BarManager1
    Me.dateStockCheck.Name = "dateStockCheck"
    Me.dateStockCheck.Properties.AllowMouseWheel = False
    Me.dateStockCheck.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dateStockCheck.Properties.Appearance.Options.UseFont = True
    Me.dateStockCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dateStockCheck.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dateStockCheck.Properties.NullDate = New Date(CType(0, Long))
    Me.dateStockCheck.Size = New System.Drawing.Size(91, 22)
    Me.dateStockCheck.TabIndex = 46
    '
    'LabelControl7
    '
    Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl7.Appearance.Options.UseFont = True
    Me.LabelControl7.Appearance.Options.UseForeColor = True
    Me.LabelControl7.Location = New System.Drawing.Point(263, 47)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(34, 15)
    Me.LabelControl7.TabIndex = 43
    Me.LabelControl7.Text = "Fecha"
    '
    'LabelControl8
    '
    Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.LabelControl8.Appearance.Options.UseFont = True
    Me.LabelControl8.Appearance.Options.UseForeColor = True
    Me.LabelControl8.Location = New System.Drawing.Point(9, 47)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(66, 15)
    Me.LabelControl8.TabIndex = 41
    Me.LabelControl8.Text = "Descripción"
    '
    'txtStockCheckDesc
    '
    Me.txtStockCheckDesc.Location = New System.Drawing.Point(78, 44)
    Me.txtStockCheckDesc.MenuManager = Me.BarManager1
    Me.txtStockCheckDesc.Name = "txtStockCheckDesc"
    Me.txtStockCheckDesc.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtStockCheckDesc.Properties.Appearance.Options.UseFont = True
    Me.txtStockCheckDesc.Size = New System.Drawing.Size(178, 22)
    Me.txtStockCheckDesc.TabIndex = 40
    '
    'grpItemDetail
    '
    Me.grpItemDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpItemDetail.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpItemDetail.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.grpItemDetail.Appearance.Options.UseFont = True
    Me.grpItemDetail.Appearance.Options.UseForeColor = True
    Me.grpItemDetail.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpItemDetail.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpItemDetail.AppearanceCaption.Options.UseFont = True
    Me.grpItemDetail.AppearanceCaption.Options.UseForeColor = True
    Me.grpItemDetail.Controls.Add(Me.pccStockTakeSheets)
    Me.grpItemDetail.Controls.Add(Me.puccStockItemValuationHistorys)
    Me.grpItemDetail.Controls.Add(Me.grdStockCheckItem)
    Me.grpItemDetail.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Seleccionar Todo", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "SelectAll", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Limpiar Selección", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "ClearSelection", -1)})
    Me.grpItemDetail.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpItemDetail.Location = New System.Drawing.Point(6, 125)
    Me.grpItemDetail.Name = "grpItemDetail"
    Me.grpItemDetail.Size = New System.Drawing.Size(1359, 546)
    Me.grpItemDetail.TabIndex = 94
    Me.grpItemDetail.Text = "Stock Items"
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.grpDetail)
    Me.PanelControl1.Controls.Add(Me.grpItemDetail)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(0, 35)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1370, 676)
    Me.PanelControl1.TabIndex = 10
    '
    'frmStockTake
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1370, 711)
    Me.Controls.Add(Me.PanelControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmStockTake"
    Me.Text = "Captura de Inventario"
    CType(Me.puccStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).EndInit()
    Me.puccStockItemValuationHistorys.ResumeLayout(False)
    CType(Me.grdStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitbtStockItemRefresh, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockCheckItem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSpinEditCounted, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdStockCheckItem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitPUStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpDetail, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpDetail.ResumeLayout(False)
    Me.grpDetail.PerformLayout()
    CType(Me.radGRNMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pceStockTakeSheets.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pccStockTakeSheets, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pccStockTakeSheets.ResumeLayout(False)
    CType(Me.grdStockTakeSheets, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockTakeSheets, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repDateFormat.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repDateFormat, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repbtnViewSheet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datDateSystemQty.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datDateSystemQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRangeStockCodeEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRangeStockCodeStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dateStockCheck.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dateStockCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStockCheckDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpItemDetail.ResumeLayout(False)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents puccStockItemValuationHistorys As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents grdStockItemValuationHistorys As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockItemValuationHistorys As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barbtnSaveExit As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnGoodsInInvoiced As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnLoadDespatchedQty As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnStockValuation As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnExcelExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnRefreshWIPItems As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnRefreshStockItems As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents grpDetail As DevExpress.XtraEditors.GroupControl
  Friend WithEvents btnClearSystemQty As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnClearRange As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnApplyRange As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents lblRangeEnd As DevExpress.XtraEditors.LabelControl
  Friend WithEvents lblRangeStart As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtRangeStockCodeEnd As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblRange As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtRangeStockCodeStart As DevExpress.XtraEditors.TextEdit
  Friend WithEvents dateStockCheck As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtStockCheckDesc As DevExpress.XtraEditors.TextEdit
  Friend WithEvents grpItemDetail As DevExpress.XtraEditors.GroupControl
  Friend WithEvents lblViewMode As DevExpress.XtraEditors.LabelControl
  Friend WithEvents radGRNMode As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents grdStockCheckItem As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockCheckItem As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCountedQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemSpinEditCounted As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents repitPUStockItemValuationHistorys As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcIsCounted As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents barbtnRefreshSystemQty As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnCommitStockTake As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnPrintCountSheet As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents gcDiscrepency As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents datDateSystemQty As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnAddToNextSheet As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents gcStockTakeSheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents pceStockTakeSheets As DevExpress.XtraEditors.PopupContainerEdit
  Friend WithEvents pccStockTakeSheets As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents grdStockTakeSheets As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockTakeSheets As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNoOfItems As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSelectVisible As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnDeselectVisible As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnDeselectAll As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repDateFormat As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repbtnViewSheet As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents btnAutoCreateSheets As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents barbtnFIFOSystemValue As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnFIFOCountedValue As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbtnAplicarCantidadesContado As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitbtStockItemRefresh As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcWriteOffQuantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
End Class
