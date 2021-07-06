<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWoodMaterialRequirement
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
    Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barbtnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnPickOrder = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnClearOrders = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnReloadRequirements = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSetAllToOrder = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSetAllFromStock = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnClearToOrderFromStock = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnProcessFromStock = New DevExpress.XtraBars.BarButtonItem()
    Me.bsubitProcessToPO = New DevExpress.XtraBars.BarSubItem()
    Me.barbtnExcelExport = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.bbtnPrintMiscPickingLists = New DevExpress.XtraBars.BarButtonItem()
    Me.grdMaterialRequirements = New DevExpress.XtraGrid.GridControl()
    Me.gvMaterialRequirements = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ReposItemPopupContainerEditSITrans = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.pccStockItemTrans = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdStockitemTrans = New DevExpress.XtraGrid.GridControl()
    Me.gcStockItemTrans = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.gcSITranTranType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSITranUserID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemPopupContainerEditOrderedQty = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.puccOnOrderOSQty = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdOnOrderOSQty = New DevExpress.XtraGrid.GridControl()
    Me.gvOnOrderOSQty = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatReqToOrder = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repItemQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcFromStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcQuantityFromStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcIMLeadtime = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.gcComments = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
    Me.grpMaterialRequirements = New DevExpress.XtraEditors.GroupControl()
    Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ReposItemPopupContainerEditSITrans, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pccStockItemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pccStockItemTrans.SuspendLayout()
    CType(Me.grdStockitemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gcStockItemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemPopupContainerEditOrderedQty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.puccOnOrderOSQty, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.puccOnOrderOSQty.SuspendLayout()
    CType(Me.grdOnOrderOSQty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvOnOrderOSQty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repItemQty, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpMaterialRequirements.SuspendLayout()
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
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnPickOrder, Me.bbtnReloadRequirements, Me.bbtnClearOrders, Me.bbtnSetAllToOrder, Me.bbtnSetAllFromStock, Me.bbtnProcessFromStock, Me.bbtnClearToOrderFromStock, Me.bsubitProcessToPO, Me.BarSubItem1, Me.bbtnPrintMiscPickingLists, Me.barbtnExcelExport, Me.barbtnClose})
    Me.BarManager1.MaxItemId = 13
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnPickOrder), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnClearOrders), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbtnReloadRequirements, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSetAllToOrder, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSetAllFromStock), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnClearToOrderFromStock), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnProcessFromStock, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsubitProcessToPO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExcelExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.Text = "Tools"
    '
    'barbtnClose
    '
    Me.barbtnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnClose.Caption = "Cerrar"
    Me.barbtnClose.Id = 12
    Me.barbtnClose.Name = "barbtnClose"
    '
    'bbtnPickOrder
    '
    Me.bbtnPickOrder.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnPickOrder.Caption = "Dar Salida a OT"
    Me.bbtnPickOrder.Id = 0
    Me.bbtnPickOrder.Name = "bbtnPickOrder"
    Me.bbtnPickOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'bbtnClearOrders
    '
    Me.bbtnClearOrders.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnClearOrders.Caption = "Limpiar OT"
    Me.bbtnClearOrders.Id = 2
    Me.bbtnClearOrders.Name = "bbtnClearOrders"
    Me.bbtnClearOrders.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'bbtnReloadRequirements
    '
    Me.bbtnReloadRequirements.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnReloadRequirements.Caption = "Recargar"
    Me.bbtnReloadRequirements.Id = 1
    Me.bbtnReloadRequirements.Name = "bbtnReloadRequirements"
    '
    'bbtnSetAllToOrder
    '
    Me.bbtnSetAllToOrder.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnSetAllToOrder.Caption = "A Pedir = Pend. a Ordenar"
    Me.bbtnSetAllToOrder.Id = 3
    Me.bbtnSetAllToOrder.Name = "bbtnSetAllToOrder"
    '
    'bbtnSetAllFromStock
    '
    Me.bbtnSetAllFromStock.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnSetAllFromStock.Caption = "De Inventario = Pend. a Ordenar"
    Me.bbtnSetAllFromStock.Id = 4
    Me.bbtnSetAllFromStock.Name = "bbtnSetAllFromStock"
    '
    'bbtnClearToOrderFromStock
    '
    Me.bbtnClearToOrderFromStock.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnClearToOrderFromStock.Caption = "Limpiar Cant."
    Me.bbtnClearToOrderFromStock.Id = 6
    Me.bbtnClearToOrderFromStock.Name = "bbtnClearToOrderFromStock"
    '
    'bbtnProcessFromStock
    '
    Me.bbtnProcessFromStock.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bbtnProcessFromStock.Caption = "Procesar De Inventario"
    Me.bbtnProcessFromStock.Id = 5
    Me.bbtnProcessFromStock.Name = "bbtnProcessFromStock"
    '
    'bsubitProcessToPO
    '
    Me.bsubitProcessToPO.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Me.bsubitProcessToPO.Caption = "Procesar a O.C. "
    Me.bsubitProcessToPO.Id = 8
    Me.bsubitProcessToPO.Name = "bsubitProcessToPO"
    '
    'barbtnExcelExport
    '
    Me.barbtnExcelExport.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnExcelExport.Caption = "Exportar a Excel"
    Me.barbtnExcelExport.Id = 11
    Me.barbtnExcelExport.Name = "barbtnExcelExport"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1246, 30)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 683)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1246, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 653)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1246, 30)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 653)
    '
    'BarSubItem1
    '
    Me.BarSubItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.BarSubItem1.Caption = "Printouts"
    Me.BarSubItem1.Id = 9
    Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnPrintMiscPickingLists)})
    Me.BarSubItem1.Name = "BarSubItem1"
    '
    'bbtnPrintMiscPickingLists
    '
    Me.bbtnPrintMiscPickingLists.Caption = "Misc Picking List"
    Me.bbtnPrintMiscPickingLists.Id = 10
    Me.bbtnPrintMiscPickingLists.Name = "bbtnPrintMiscPickingLists"
    '
    'grdMaterialRequirements
    '
    Me.grdMaterialRequirements.Dock = System.Windows.Forms.DockStyle.Fill
    GridLevelNode1.RelationName = "Level1"
    Me.grdMaterialRequirements.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
    Me.grdMaterialRequirements.Location = New System.Drawing.Point(2, 24)
    Me.grdMaterialRequirements.MainView = Me.gvMaterialRequirements
    Me.grdMaterialRequirements.Name = "grdMaterialRequirements"
    Me.grdMaterialRequirements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemQty, Me.RepositoryItemPopupContainerEditOrderedQty, Me.ReposItemPopupContainerEditSITrans, Me.RepositoryItemDateEdit2, Me.RepositoryItemMemoExEdit1})
    Me.grdMaterialRequirements.Size = New System.Drawing.Size(1242, 627)
    Me.grdMaterialRequirements.TabIndex = 5
    Me.grdMaterialRequirements.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterialRequirements})
    '
    'gvMaterialRequirements
    '
    Me.gvMaterialRequirements.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvMaterialRequirements.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvMaterialRequirements.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvMaterialRequirements.Appearance.Row.BackColor = System.Drawing.Color.Lavender
    Me.gvMaterialRequirements.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvMaterialRequirements.Appearance.Row.Options.UseBackColor = True
    Me.gvMaterialRequirements.Appearance.Row.Options.UseFont = True
    Me.gvMaterialRequirements.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvMaterialRequirements.Appearance.ViewCaption.Options.UseFont = True
    Me.gvMaterialRequirements.ColumnPanelRowHeight = 34
    Me.gvMaterialRequirements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn7, Me.gcMatDescription, Me.GridColumn8, Me.GridColumn13, Me.GridColumn6, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.gcMatReqToOrder, Me.GridColumn1, Me.GridColumn32, Me.GridColumn19, Me.GridColumn17, Me.GridColumn9, Me.GridColumn18, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn31, Me.gcFromStock, Me.gcQuantityFromStock, Me.gcIMLeadtime, Me.GridColumn33, Me.GridColumn34, Me.GridColumn12, Me.GridColumn23, Me.gcComments})
    Me.gvMaterialRequirements.GridControl = Me.grdMaterialRequirements
    Me.gvMaterialRequirements.GroupCount = 1
    Me.gvMaterialRequirements.Name = "gvMaterialRequirements"
    Me.gvMaterialRequirements.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvMaterialRequirements.OptionsView.ShowAutoFilterRow = True
    Me.gvMaterialRequirements.OptionsView.ShowDetailButtons = False
    Me.gvMaterialRequirements.OptionsView.ShowFooter = True
    Me.gvMaterialRequirements.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn34, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcMatDescription, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
    Me.gvMaterialRequirements.ViewCaption = "Material Requirements"
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Código"
    Me.GridColumn5.DisplayFormat.FormatString = "#"
    Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn5.FieldName = "StockCode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.OptionsColumn.ReadOnly = True
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 5
    Me.GridColumn5.Width = 44
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Categoría"
    Me.GridColumn7.FieldName = "CategoryDesc"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.OptionsColumn.ReadOnly = True
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 7
    Me.GridColumn7.Width = 60
    '
    'gcMatDescription
    '
    Me.gcMatDescription.Caption = "Descripción"
    Me.gcMatDescription.FieldName = "Description"
    Me.gcMatDescription.Name = "gcMatDescription"
    Me.gcMatDescription.OptionsColumn.ReadOnly = True
    Me.gcMatDescription.Visible = True
    Me.gcMatDescription.VisibleIndex = 6
    Me.gcMatDescription.Width = 195
    '
    'GridColumn8
    '
    Me.GridColumn8.FieldName = "Dims"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Width = 42
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Cant. Req."
    Me.GridColumn13.DisplayFormat.FormatString = "#.###"
    Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn13.FieldName = "QuantityRequired"
    Me.GridColumn13.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.OptionsColumn.ReadOnly = True
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 11
    Me.GridColumn13.Width = 67
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Cant. Res. Inv."
    Me.GridColumn6.DisplayFormat.FormatString = "#.##"
    Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn6.FieldName = "FromStockQty"
    Me.GridColumn6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.ReadOnly = True
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 14
    Me.GridColumn6.Width = 68
    '
    'GridColumn14
    '
    Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn14.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn14.Caption = "Cant. Despachada."
    Me.GridColumn14.ColumnEdit = Me.ReposItemPopupContainerEditSITrans
    Me.GridColumn14.DisplayFormat.FormatString = "#.###"
    Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn14.FieldName = "PickedQty"
    Me.GridColumn14.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn14.Visible = True
    Me.GridColumn14.VisibleIndex = 13
    Me.GridColumn14.Width = 103
    '
    'ReposItemPopupContainerEditSITrans
    '
    Me.ReposItemPopupContainerEditSITrans.AutoHeight = False
    Me.ReposItemPopupContainerEditSITrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.ReposItemPopupContainerEditSITrans.DisplayFormat.FormatString = "#.##"
    Me.ReposItemPopupContainerEditSITrans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.ReposItemPopupContainerEditSITrans.EditFormat.FormatString = "#.##"
    Me.ReposItemPopupContainerEditSITrans.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.ReposItemPopupContainerEditSITrans.Name = "ReposItemPopupContainerEditSITrans"
    Me.ReposItemPopupContainerEditSITrans.PopupControl = Me.pccStockItemTrans
    '
    'pccStockItemTrans
    '
    Me.pccStockItemTrans.Controls.Add(Me.grdStockitemTrans)
    Me.pccStockItemTrans.Location = New System.Drawing.Point(899, 194)
    Me.pccStockItemTrans.Name = "pccStockItemTrans"
    Me.pccStockItemTrans.Size = New System.Drawing.Size(319, 270)
    Me.pccStockItemTrans.TabIndex = 101
    '
    'grdStockitemTrans
    '
    Me.grdStockitemTrans.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockitemTrans.Location = New System.Drawing.Point(0, 0)
    Me.grdStockitemTrans.MainView = Me.gcStockItemTrans
    Me.grdStockitemTrans.MenuManager = Me.BarManager1
    Me.grdStockitemTrans.Name = "grdStockitemTrans"
    Me.grdStockitemTrans.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
    Me.grdStockitemTrans.Size = New System.Drawing.Size(319, 270)
    Me.grdStockitemTrans.TabIndex = 98
    Me.grdStockitemTrans.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gcStockItemTrans})
    '
    'gcStockItemTrans
    '
    Me.gcStockItemTrans.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gcStockItemTrans.Appearance.HeaderPanel.Options.UseFont = True
    Me.gcStockItemTrans.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gcStockItemTrans.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.gcStockItemTrans.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcStockItemTrans.Appearance.Row.BackColor = System.Drawing.Color.Lavender
    Me.gcStockItemTrans.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gcStockItemTrans.Appearance.Row.Options.UseBackColor = True
    Me.gcStockItemTrans.Appearance.Row.Options.UseFont = True
    Me.gcStockItemTrans.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gcStockItemTrans.Appearance.SelectedRow.Options.UseFont = True
    Me.gcStockItemTrans.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.gcStockItemTrans.Appearance.TopNewRow.Options.UseFont = True
    Me.gcStockItemTrans.ColumnPanelRowHeight = 36
    Me.gcStockItemTrans.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn20, Me.GridColumn21, Me.GridColumn24, Me.gcSITranTranType, Me.gcSITranUserID, Me.GridColumn22})
    Me.gcStockItemTrans.GridControl = Me.grdStockitemTrans
    Me.gcStockItemTrans.HorzScrollStep = 20
    Me.gcStockItemTrans.Name = "gcStockItemTrans"
    Me.gcStockItemTrans.OptionsBehavior.ReadOnly = True
    Me.gcStockItemTrans.OptionsView.ShowGroupPanel = False
    '
    'GridColumn20
    '
    Me.GridColumn20.FieldName = "pStockItemTransactionLogID"
    Me.GridColumn20.Name = "GridColumn20"
    '
    'GridColumn21
    '
    Me.GridColumn21.Caption = "Cant. Despachada"
    Me.GridColumn21.DisplayFormat.FormatString = "0.##"
    Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn21.FieldName = "TransQuantity"
    Me.GridColumn21.Name = "GridColumn21"
    Me.GridColumn21.Visible = True
    Me.GridColumn21.VisibleIndex = 3
    Me.GridColumn21.Width = 111
    '
    'GridColumn24
    '
    Me.GridColumn24.Caption = "Fecha Despacho"
    Me.GridColumn24.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn24.FieldName = "TransDate"
    Me.GridColumn24.Name = "GridColumn24"
    Me.GridColumn24.Visible = True
    Me.GridColumn24.VisibleIndex = 1
    Me.GridColumn24.Width = 82
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "hh:mm"
    Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.RepositoryItemDateEdit1.EditFormat.FormatString = "hh:mm"
    Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
    '
    'gcSITranTranType
    '
    Me.gcSITranTranType.Caption = "Tran Type"
    Me.gcSITranTranType.FieldName = "TransactionType"
    Me.gcSITranTranType.Name = "gcSITranTranType"
    Me.gcSITranTranType.Width = 76
    '
    'gcSITranUserID
    '
    Me.gcSITranUserID.Caption = "Usuario"
    Me.gcSITranUserID.FieldName = "UserName"
    Me.gcSITranUserID.Name = "gcSITranUserID"
    Me.gcSITranUserID.Visible = True
    Me.gcSITranUserID.VisibleIndex = 0
    Me.gcSITranUserID.Width = 50
    '
    'GridColumn22
    '
    Me.GridColumn22.Caption = "Hora"
    Me.GridColumn22.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn22.DisplayFormat.FormatString = "hh:mm"
    Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn22.FieldName = "TransDate"
    Me.GridColumn22.Name = "GridColumn22"
    Me.GridColumn22.Visible = True
    Me.GridColumn22.VisibleIndex = 2
    Me.GridColumn22.Width = 58
    '
    'GridColumn15
    '
    Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn15.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn15.Caption = "Cant. Pedidas"
    Me.GridColumn15.ColumnEdit = Me.RepositoryItemPopupContainerEditOrderedQty
    Me.GridColumn15.DisplayFormat.FormatString = "#.###"
    Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn15.FieldName = "QtyOrdered"
    Me.GridColumn15.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 12
    Me.GridColumn15.Width = 73
    '
    'RepositoryItemPopupContainerEditOrderedQty
    '
    Me.RepositoryItemPopupContainerEditOrderedQty.AutoHeight = False
    Me.RepositoryItemPopupContainerEditOrderedQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemPopupContainerEditOrderedQty.DisplayFormat.FormatString = "#.###"
    Me.RepositoryItemPopupContainerEditOrderedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemPopupContainerEditOrderedQty.EditFormat.FormatString = "#.###"
    Me.RepositoryItemPopupContainerEditOrderedQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemPopupContainerEditOrderedQty.Name = "RepositoryItemPopupContainerEditOrderedQty"
    Me.RepositoryItemPopupContainerEditOrderedQty.PopupControl = Me.puccOnOrderOSQty
    '
    'puccOnOrderOSQty
    '
    Me.puccOnOrderOSQty.Controls.Add(Me.grdOnOrderOSQty)
    Me.puccOnOrderOSQty.Location = New System.Drawing.Point(150, 319)
    Me.puccOnOrderOSQty.Name = "puccOnOrderOSQty"
    Me.puccOnOrderOSQty.Size = New System.Drawing.Size(540, 249)
    Me.puccOnOrderOSQty.TabIndex = 100
    '
    'grdOnOrderOSQty
    '
    Me.grdOnOrderOSQty.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdOnOrderOSQty.Location = New System.Drawing.Point(0, 0)
    Me.grdOnOrderOSQty.MainView = Me.gvOnOrderOSQty
    Me.grdOnOrderOSQty.MenuManager = Me.BarManager1
    Me.grdOnOrderOSQty.Name = "grdOnOrderOSQty"
    Me.grdOnOrderOSQty.Size = New System.Drawing.Size(540, 249)
    Me.grdOnOrderOSQty.TabIndex = 98
    Me.grdOnOrderOSQty.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOnOrderOSQty})
    '
    'gvOnOrderOSQty
    '
    Me.gvOnOrderOSQty.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvOnOrderOSQty.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvOnOrderOSQty.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvOnOrderOSQty.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.gvOnOrderOSQty.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvOnOrderOSQty.Appearance.Row.BackColor = System.Drawing.Color.Lavender
    Me.gvOnOrderOSQty.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvOnOrderOSQty.Appearance.Row.Options.UseBackColor = True
    Me.gvOnOrderOSQty.Appearance.Row.Options.UseFont = True
    Me.gvOnOrderOSQty.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvOnOrderOSQty.Appearance.SelectedRow.Options.UseFont = True
    Me.gvOnOrderOSQty.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvOnOrderOSQty.Appearance.TopNewRow.Options.UseFont = True
    Me.gvOnOrderOSQty.ColumnPanelRowHeight = 38
    Me.gvOnOrderOSQty.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn10, Me.GridColumn11, Me.GridColumn3, Me.GridColumn4, Me.GridColumn35})
    Me.gvOnOrderOSQty.GridControl = Me.grdOnOrderOSQty
    Me.gvOnOrderOSQty.HorzScrollStep = 20
    Me.gvOnOrderOSQty.Name = "gvOnOrderOSQty"
    Me.gvOnOrderOSQty.OptionsBehavior.ReadOnly = True
    Me.gvOnOrderOSQty.OptionsView.ShowGroupPanel = False
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Cant. Ordenada"
    Me.GridColumn2.DisplayFormat.FormatString = "0.##"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn2.FieldName = "Quantity"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 3
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Cant. Recibida"
    Me.GridColumn10.DisplayFormat.FormatString = "0.##"
    Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn10.FieldName = "ReceivedQty"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.OptionsColumn.ReadOnly = True
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 4
    Me.GridColumn10.Width = 67
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "# OC."
    Me.GridColumn11.FieldName = "PONum"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.OptionsColumn.ReadOnly = True
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 0
    Me.GridColumn11.Width = 67
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Proveedor"
    Me.GridColumn3.FieldName = "SUPPLIERCOMPANYNAME"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 181
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Fecha Req."
    Me.GridColumn4.FieldName = "RequiredDate"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.OptionsColumn.ReadOnly = True
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 69
    '
    'GridColumn35
    '
    Me.GridColumn35.Caption = "Cant. Pend."
    Me.GridColumn35.DisplayFormat.FormatString = "0.##"
    Me.GridColumn35.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn35.FieldName = "OutStandingQty"
    Me.GridColumn35.Name = "GridColumn35"
    Me.GridColumn35.OptionsColumn.ReadOnly = True
    Me.GridColumn35.Visible = True
    Me.GridColumn35.VisibleIndex = 5
    Me.GridColumn35.Width = 63
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "Cant. Rec."
    Me.GridColumn16.DisplayFormat.FormatString = "#.##"
    Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn16.FieldName = "QtyReceived"
    Me.GridColumn16.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.GridColumn16.Name = "GridColumn16"
    Me.GridColumn16.OptionsColumn.ReadOnly = True
    Me.GridColumn16.Width = 58
    '
    'gcMatReqToOrder
    '
    Me.gcMatReqToOrder.AppearanceCell.BackColor = System.Drawing.Color.LightCyan
    Me.gcMatReqToOrder.AppearanceCell.Options.UseBackColor = True
    Me.gcMatReqToOrder.AppearanceCell.Options.UseTextOptions = True
    Me.gcMatReqToOrder.Caption = "A Ordernar"
    Me.gcMatReqToOrder.ColumnEdit = Me.repItemQty
    Me.gcMatReqToOrder.DisplayFormat.FormatString = "#.##"
    Me.gcMatReqToOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcMatReqToOrder.FieldName = "ToOrder"
    Me.gcMatReqToOrder.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.gcMatReqToOrder.Name = "gcMatReqToOrder"
    Me.gcMatReqToOrder.Visible = True
    Me.gcMatReqToOrder.VisibleIndex = 15
    Me.gcMatReqToOrder.Width = 69
    '
    'repItemQty
    '
    Me.repItemQty.AutoHeight = False
    Me.repItemQty.DisplayFormat.FormatString = "#.##"
    Me.repItemQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.repItemQty.EditFormat.FormatString = "#.##"
    Me.repItemQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.repItemQty.Name = "repItemQty"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Pend. a Ordenar"
    Me.GridColumn1.DisplayFormat.FormatString = "#.###"
    Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn1.FieldName = "QtyOutStandingToOrder"
    Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Width = 93
    '
    'GridColumn32
    '
    Me.GridColumn32.Caption = "Proyecto"
    Me.GridColumn32.FieldName = "ProjectName"
    Me.GridColumn32.Name = "GridColumn32"
    Me.GridColumn32.OptionsColumn.ReadOnly = True
    Me.GridColumn32.Visible = True
    Me.GridColumn32.VisibleIndex = 2
    Me.GridColumn32.Width = 92
    '
    'GridColumn19
    '
    Me.GridColumn19.Caption = "# Venta"
    Me.GridColumn19.FieldName = "OrderNo"
    Me.GridColumn19.Name = "GridColumn19"
    Me.GridColumn19.OptionsColumn.ReadOnly = True
    Me.GridColumn19.Visible = True
    Me.GridColumn19.VisibleIndex = 1
    Me.GridColumn19.Width = 38
    '
    'GridColumn17
    '
    Me.GridColumn17.Caption = "Inventario Hoy"
    Me.GridColumn17.DisplayFormat.FormatString = "#.###"
    Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn17.FieldName = "StockItemLocationsQty"
    Me.GridColumn17.Name = "GridColumn17"
    Me.GridColumn17.OptionsColumn.ReadOnly = True
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 10
    Me.GridColumn17.Width = 53
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "UdM"
    Me.GridColumn9.FieldName = "UoMDesc"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 8
    Me.GridColumn9.Width = 39
    '
    'GridColumn18
    '
    Me.GridColumn18.Caption = "Código Barra"
    Me.GridColumn18.FieldName = "BarCode"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.OptionsColumn.ReadOnly = True
    Me.GridColumn18.Width = 97
    '
    'GridColumn25
    '
    Me.GridColumn25.FieldName = "MaterialRequirementID"
    Me.GridColumn25.Name = "GridColumn25"
    '
    'GridColumn26
    '
    Me.GridColumn26.Caption = "Default Supplier"
    Me.GridColumn26.FieldName = "DefaultSupplierDesc"
    Me.GridColumn26.Name = "GridColumn26"
    Me.GridColumn26.Width = 87
    '
    'GridColumn27
    '
    Me.GridColumn27.Caption = "Free Stock"
    Me.GridColumn27.DisplayFormat.FormatString = "#.###"
    Me.GridColumn27.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn27.FieldName = "FreeStockQty"
    Me.GridColumn27.Name = "GridColumn27"
    Me.GridColumn27.Width = 95
    '
    'GridColumn28
    '
    Me.GridColumn28.FieldName = "PhaseDateRequired"
    Me.GridColumn28.Name = "GridColumn28"
    Me.GridColumn28.Width = 167
    '
    'GridColumn31
    '
    Me.GridColumn31.Caption = "Int. Sales Order"
    Me.GridColumn31.FieldName = "AccountSalesOrderRef"
    Me.GridColumn31.Name = "GridColumn31"
    Me.GridColumn31.Width = 48
    '
    'gcFromStock
    '
    Me.gcFromStock.AppearanceCell.BackColor = System.Drawing.Color.LightCyan
    Me.gcFromStock.AppearanceCell.Options.UseBackColor = True
    Me.gcFromStock.AppearanceCell.Options.UseTextOptions = True
    Me.gcFromStock.Caption = "De Inventario"
    Me.gcFromStock.DisplayFormat.FormatString = "#.##"
    Me.gcFromStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcFromStock.FieldName = "FromStock"
    Me.gcFromStock.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.gcFromStock.Name = "gcFromStock"
    Me.gcFromStock.Visible = True
    Me.gcFromStock.VisibleIndex = 16
    Me.gcFromStock.Width = 90
    '
    'gcQuantityFromStock
    '
    Me.gcQuantityFromStock.Caption = "Cant. De Inventario"
    Me.gcQuantityFromStock.DisplayFormat.FormatString = "#.###"
    Me.gcQuantityFromStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcQuantityFromStock.FieldName = "PickedFromStock"
    Me.gcQuantityFromStock.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    Me.gcQuantityFromStock.Name = "gcQuantityFromStock"
    Me.gcQuantityFromStock.Width = 104
    '
    'gcIMLeadtime
    '
    Me.gcIMLeadtime.Caption = "Lead Time"
    Me.gcIMLeadtime.DisplayFormat.FormatString = "##.#"
    Me.gcIMLeadtime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcIMLeadtime.FieldName = "LeadTime"
    Me.gcIMLeadtime.Name = "gcIMLeadtime"
    Me.gcIMLeadtime.Width = 29
    '
    'GridColumn33
    '
    Me.GridColumn33.Caption = "Cliente"
    Me.GridColumn33.FieldName = "CompanyName"
    Me.GridColumn33.Name = "GridColumn33"
    Me.GridColumn33.Visible = True
    Me.GridColumn33.VisibleIndex = 3
    Me.GridColumn33.Width = 70
    '
    'GridColumn34
    '
    Me.GridColumn34.Caption = "Desc. OT."
    Me.GridColumn34.FieldName = "WODescription"
    Me.GridColumn34.Name = "GridColumn34"
    Me.GridColumn34.Visible = True
    Me.GridColumn34.VisibleIndex = 1
    Me.GridColumn34.Width = 118
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "# O.T."
    Me.GridColumn12.FieldName = "WorkOrderNo"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 0
    Me.GridColumn12.Width = 38
    '
    'GridColumn23
    '
    Me.GridColumn23.Caption = "Fecha Req."
    Me.GridColumn23.ColumnEdit = Me.RepositoryItemDateEdit2
    Me.GridColumn23.FieldName = "PlannedStartDate"
    Me.GridColumn23.Name = "GridColumn23"
    Me.GridColumn23.OptionsColumn.ReadOnly = True
    Me.GridColumn23.Visible = True
    Me.GridColumn23.VisibleIndex = 4
    Me.GridColumn23.Width = 40
    '
    'RepositoryItemDateEdit2
    '
    Me.RepositoryItemDateEdit2.AutoHeight = False
    Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
    Me.RepositoryItemDateEdit2.NullDate = New Date(CType(0, Long))
    '
    'gcComments
    '
    Me.gcComments.Caption = "Comentarios"
    Me.gcComments.ColumnEdit = Me.RepositoryItemMemoExEdit1
    Me.gcComments.FieldName = "Comments"
    Me.gcComments.Name = "gcComments"
    Me.gcComments.Visible = True
    Me.gcComments.VisibleIndex = 9
    Me.gcComments.Width = 84
    '
    'RepositoryItemMemoExEdit1
    '
    Me.RepositoryItemMemoExEdit1.AutoHeight = False
    Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
    '
    'grpMaterialRequirements
    '
    Me.grpMaterialRequirements.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpMaterialRequirements.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.grpMaterialRequirements.Appearance.Options.UseFont = True
    Me.grpMaterialRequirements.Appearance.Options.UseForeColor = True
    Me.grpMaterialRequirements.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpMaterialRequirements.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpMaterialRequirements.AppearanceCaption.Options.UseFont = True
    Me.grpMaterialRequirements.AppearanceCaption.Options.UseForeColor = True
    Me.grpMaterialRequirements.Controls.Add(Me.pccStockItemTrans)
    Me.grpMaterialRequirements.Controls.Add(Me.puccOnOrderOSQty)
    Me.grpMaterialRequirements.Controls.Add(Me.grdMaterialRequirements)
    Me.grpMaterialRequirements.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Reload", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1)})
    Me.grpMaterialRequirements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpMaterialRequirements.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpMaterialRequirements.Location = New System.Drawing.Point(0, 30)
    Me.grpMaterialRequirements.Name = "grpMaterialRequirements"
    Me.grpMaterialRequirements.Size = New System.Drawing.Size(1246, 653)
    Me.grpMaterialRequirements.TabIndex = 94
    Me.grpMaterialRequirements.Text = "Artículos Requeridos por Proyecto"
    '
    'GridColumn29
    '
    Me.GridColumn29.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
    Me.GridColumn29.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn29.Caption = "XRef"
    Me.GridColumn29.FieldName = "XRef"
    Me.GridColumn29.Name = "GridColumn29"
    Me.GridColumn29.OptionsColumn.ReadOnly = True
    Me.GridColumn29.Visible = True
    Me.GridColumn29.VisibleIndex = 2
    Me.GridColumn29.Width = 53
    '
    'GridColumn30
    '
    Me.GridColumn30.Caption = "Int. Order No."
    Me.GridColumn30.FieldName = "AccountSalesOrderRef"
    Me.GridColumn30.Name = "GridColumn30"
    Me.GridColumn30.Visible = True
    Me.GridColumn30.VisibleIndex = 2
    Me.GridColumn30.Width = 74
    '
    'frmWoodMaterialRequirement
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1246, 683)
    Me.Controls.Add(Me.grpMaterialRequirements)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmWoodMaterialRequirement"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Requerimientos de Proyectos"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ReposItemPopupContainerEditSITrans, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pccStockItemTrans, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pccStockItemTrans.ResumeLayout(False)
    CType(Me.grdStockitemTrans, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gcStockItemTrans, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemPopupContainerEditOrderedQty, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.puccOnOrderOSQty, System.ComponentModel.ISupportInitialize).EndInit()
    Me.puccOnOrderOSQty.ResumeLayout(False)
    CType(Me.grdOnOrderOSQty, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvOnOrderOSQty, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repItemQty, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpMaterialRequirements.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents bbtnPickOrder As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnReloadRequirements As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents grdMaterialRequirements As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMaterialRequirements As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents bbtnClearOrders As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatReqToOrder As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbtnSetAllToOrder As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnSetAllFromStock As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnClearToOrderFromStock As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnProcessFromStock As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bsubitProcessToPO As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents bbtnPrintMiscPickingLists As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents repItemQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents grpMaterialRequirements As DevExpress.XtraEditors.GroupControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbtnExcelExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RepositoryItemPopupContainerEditOrderedQty As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents puccOnOrderOSQty As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents grdOnOrderOSQty As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvOnOrderOSQty As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents pccStockItemTrans As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents grdStockitemTrans As DevExpress.XtraGrid.GridControl
  Friend WithEvents gcStockItemTrans As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents ReposItemPopupContainerEditSITrans As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSITranTranType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSITranUserID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbtnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcFromStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQuantityFromStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcIMLeadtime As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents gcComments As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
