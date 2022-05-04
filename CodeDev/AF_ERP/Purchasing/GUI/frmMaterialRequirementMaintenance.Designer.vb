<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialRequirementMaintenance
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
    Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialRequirementMaintenance))
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.cheOptionViews = New DevExpress.XtraBars.BarEditItem()
    Me.repoMatReqOptionView = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
    Me.barbtnClose = New DevExpress.XtraBars.BarButtonItem()
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
    Me.bbtnPickOrder = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnClearOrders = New DevExpress.XtraBars.BarButtonItem()
    Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
    Me.bbtnPrintMiscPickingLists = New DevExpress.XtraBars.BarButtonItem()
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.grdMaterialRequirements = New DevExpress.XtraGrid.GridControl()
    Me.gvMaterialRequirements = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoItemPopupImage = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.popupImageContainer = New DevExpress.XtraEditors.PopupContainerControl()
    Me.peImage = New DevExpress.XtraEditors.PictureEdit()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoFormat = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.gcInvReserved = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ReposItemPopupContainerEditSITrans = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.pccStockItemTrans = New DevExpress.XtraEditors.PopupContainerControl()
    Me.grdStockitemTrans = New DevExpress.XtraGrid.GridControl()
    Me.gcStockItemTrans = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoDateFormat = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.gcSITranTranType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSITranUserID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.repoOpenPO = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMatReqToOrder = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repItemQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStockItemLocationsQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcFromStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcQuantityFromStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSOIDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcComments = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
    Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcWODescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcIsFromStockValidated = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoChkIsFromStockValidated = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.gcTotalFromStock = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcArea = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcChangeDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.repo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.repoOpenImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.grpMaterialRequirements = New DevExpress.XtraEditors.GroupControl()
    Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoMatReqOptionView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoItemPopupImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupImageContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupImageContainer.SuspendLayout()
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposItemPopupContainerEditSITrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pccStockItemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccStockItemTrans.SuspendLayout()
        CType(Me.grdStockitemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcStockItemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDateFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDateFormat.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEditOrderedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puccOnOrderOSQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.puccOnOrderOSQty.SuspendLayout()
        CType(Me.grdOnOrderOSQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOnOrderOSQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoOpenPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repItemQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoChkIsFromStockValidated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoOpenImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnPickOrder, Me.bbtnReloadRequirements, Me.bbtnClearOrders, Me.bbtnSetAllToOrder, Me.bbtnSetAllFromStock, Me.bbtnProcessFromStock, Me.bbtnClearToOrderFromStock, Me.bsubitProcessToPO, Me.BarSubItem1, Me.bbtnPrintMiscPickingLists, Me.barbtnExcelExport, Me.barbtnClose, Me.cheOptionViews, Me.BarStaticItem1})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoMatReqOptionView})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cheOptionViews, "", False, True, True, 279, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Caption), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbtnReloadRequirements, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSetAllToOrder, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSetAllFromStock), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnClearToOrderFromStock), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnProcessFromStock, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsubitProcessToPO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barbtnExcelExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'cheOptionViews
        '
        Me.cheOptionViews.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.cheOptionViews.Caption = "Vistas"
        Me.cheOptionViews.Edit = Me.repoMatReqOptionView
        Me.cheOptionViews.Id = 13
        Me.cheOptionViews.Name = "cheOptionViews"
        '
        'repoMatReqOptionView
        '
        Me.repoMatReqOptionView.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repoMatReqOptionView.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Ocultar Art. Recibido."), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Ver OTs en Progreso")})
        Me.repoMatReqOptionView.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.repoMatReqOptionView.Name = "repoMatReqOptionView"
        '
        'barbtnClose
        '
        Me.barbtnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbtnClose.Caption = "Cerrar"
        Me.barbtnClose.Id = 12
        Me.barbtnClose.Name = "barbtnClose"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1502, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 683)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1502, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 655)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1502, 28)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 655)
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
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Vista"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'grdMaterialRequirements
        '
        Me.grdMaterialRequirements.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grdMaterialRequirements.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdMaterialRequirements.Location = New System.Drawing.Point(2, 22)
        Me.grdMaterialRequirements.MainView = Me.gvMaterialRequirements
        Me.grdMaterialRequirements.Name = "grdMaterialRequirements"
        Me.grdMaterialRequirements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemQty, Me.RepositoryItemPopupContainerEditOrderedQty, Me.ReposItemPopupContainerEditSITrans, Me.RepositoryItemDateEdit2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit1, Me.repo, Me.repoChkIsFromStockValidated, Me.repoFormat, Me.repoOpenImage, Me.repoItemPopupImage})
        Me.grdMaterialRequirements.Size = New System.Drawing.Size(1498, 631)
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
        Me.gvMaterialRequirements.ColumnPanelRowHeight = 40
        Me.gvMaterialRequirements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn7, Me.gcMatDescription, Me.GridColumn13, Me.gcInvReserved, Me.GridColumn14, Me.GridColumn23, Me.GridColumn36, Me.GridColumn15, Me.GridColumn16, Me.gcMatReqToOrder, Me.GridColumn1, Me.GridColumn32, Me.GridColumn19, Me.gcStockItemLocationsQty, Me.GridColumn9, Me.gcFromStock, Me.gcQuantityFromStock, Me.GridColumn33, Me.gcSOIDescription, Me.GridColumn12, Me.gcComments, Me.GridColumn37, Me.gcWODescription, Me.gcIsFromStockValidated, Me.gcTotalFromStock, Me.GridColumn17, Me.gcArea, Me.GridColumn6, Me.GridColumn8, Me.gcChangeDate})
        Me.gvMaterialRequirements.GridControl = Me.grdMaterialRequirements
        Me.gvMaterialRequirements.GroupCount = 2
        Me.gvMaterialRequirements.Name = "gvMaterialRequirements"
        Me.gvMaterialRequirements.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvMaterialRequirements.OptionsView.ShowAutoFilterRow = True
        Me.gvMaterialRequirements.OptionsView.ShowDetailButtons = False
        Me.gvMaterialRequirements.OptionsView.ShowFooter = True
        Me.gvMaterialRequirements.OptionsView.ShowGroupPanel = False
        Me.gvMaterialRequirements.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn32, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcSOIDescription, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcMatDescription, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvMaterialRequirements.ViewCaption = "Material Requirements"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Código"
        Me.GridColumn5.ColumnEdit = Me.repoItemPopupImage
        Me.GridColumn5.DisplayFormat.FormatString = "#"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "StockCode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'repoItemPopupImage
        '
        Me.repoItemPopupImage.AutoHeight = False
        Me.repoItemPopupImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoItemPopupImage.Name = "repoItemPopupImage"
        Me.repoItemPopupImage.PopupControl = Me.popupImageContainer
        '
        'popupImageContainer
        '
        Me.popupImageContainer.Controls.Add(Me.peImage)
        Me.popupImageContainer.Location = New System.Drawing.Point(108, 82)
        Me.popupImageContainer.Name = "popupImageContainer"
        Me.popupImageContainer.Size = New System.Drawing.Size(455, 211)
        Me.popupImageContainer.TabIndex = 102
        '
        'peImage
        '
        Me.peImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.peImage.Location = New System.Drawing.Point(0, 0)
        Me.peImage.MenuManager = Me.BarManager1
        Me.peImage.Name = "peImage"
        Me.peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.peImage.Size = New System.Drawing.Size(455, 211)
        Me.peImage.TabIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Categoría"
        Me.GridColumn7.FieldName = "CategoryDesc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 70
        '
        'gcMatDescription
        '
        Me.gcMatDescription.Caption = "Descripción"
        Me.gcMatDescription.FieldName = "Description"
        Me.gcMatDescription.Name = "gcMatDescription"
        Me.gcMatDescription.OptionsColumn.ReadOnly = True
        Me.gcMatDescription.Visible = True
        Me.gcMatDescription.VisibleIndex = 5
        Me.gcMatDescription.Width = 105
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Cant. Req. x Área"
        Me.GridColumn13.ColumnEdit = Me.repoFormat
        Me.GridColumn13.DisplayFormat.FormatString = "#.###"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "Quantity"
        Me.GridColumn13.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        Me.GridColumn13.Width = 63
        '
        'repoFormat
        '
        Me.repoFormat.AutoHeight = False
        Me.repoFormat.EditFormat.FormatString = "n3"
        Me.repoFormat.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoFormat.Name = "repoFormat"
        '
        'gcInvReserved
        '
        Me.gcInvReserved.Caption = "Cant. Res. Inv."
        Me.gcInvReserved.ColumnEdit = Me.repoFormat
        Me.gcInvReserved.DisplayFormat.FormatString = "#.###"
        Me.gcInvReserved.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcInvReserved.FieldName = "FromStockQty"
        Me.gcInvReserved.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gcInvReserved.Name = "gcInvReserved"
        Me.gcInvReserved.OptionsColumn.ReadOnly = True
        Me.gcInvReserved.Visible = True
        Me.gcInvReserved.VisibleIndex = 17
        Me.gcInvReserved.Width = 61
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
        Me.GridColumn14.FieldName = "PickedQtyMinusReturn"
        Me.GridColumn14.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 16
        Me.GridColumn14.Width = 72
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
        Me.pccStockItemTrans.Location = New System.Drawing.Point(778, 194)
        Me.pccStockItemTrans.Name = "pccStockItemTrans"
        Me.pccStockItemTrans.Size = New System.Drawing.Size(440, 242)
        Me.pccStockItemTrans.TabIndex = 101
        '
        'grdStockitemTrans
        '
        Me.grdStockitemTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdStockitemTrans.Location = New System.Drawing.Point(0, 0)
        Me.grdStockitemTrans.MainView = Me.gcStockItemTrans
        Me.grdStockitemTrans.MenuManager = Me.BarManager1
        Me.grdStockitemTrans.Name = "grdStockitemTrans"
        Me.grdStockitemTrans.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.repoDateFormat})
        Me.grdStockitemTrans.Size = New System.Drawing.Size(440, 242)
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
        Me.gcStockItemTrans.OptionsView.ShowFooter = True
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
        Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransQuantity", "{0:0.##}")})
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 4
        Me.GridColumn21.Width = 98
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Fecha Despacho"
        Me.GridColumn24.ColumnEdit = Me.repoDateFormat
        Me.GridColumn24.FieldName = "TransDate"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 2
        Me.GridColumn24.Width = 99
        '
        'repoDateFormat
        '
        Me.repoDateFormat.AutoHeight = False
        Me.repoDateFormat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDateFormat.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDateFormat.Name = "repoDateFormat"
        Me.repoDateFormat.NullDate = New Date(CType(0, Long))
        '
        'gcSITranTranType
        '
        Me.gcSITranTranType.Caption = "Tipo Trans."
        Me.gcSITranTranType.FieldName = "TransType"
        Me.gcSITranTranType.Name = "gcSITranTranType"
        Me.gcSITranTranType.Visible = True
        Me.gcSITranTranType.VisibleIndex = 1
        Me.gcSITranTranType.Width = 81
        '
        'gcSITranUserID
        '
        Me.gcSITranUserID.Caption = "Usuario"
        Me.gcSITranUserID.FieldName = "UserName"
        Me.gcSITranUserID.Name = "gcSITranUserID"
        Me.gcSITranUserID.Visible = True
        Me.gcSITranUserID.VisibleIndex = 0
        Me.gcSITranUserID.Width = 65
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
        Me.GridColumn22.VisibleIndex = 3
        Me.GridColumn22.Width = 78
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
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Fecha Creada"
        Me.GridColumn23.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn23.FieldName = "DateCreated"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.Width = 31
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy hh:mm:ss"
        Me.RepositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.NullDate = New Date(CType(0, Long))
        Me.RepositoryItemDateEdit2.ReadOnly = True
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Fecha Req. Compra"
        Me.GridColumn36.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn36.FieldName = "PurchasingDate"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.ReadOnly = True
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 2
        Me.GridColumn36.Width = 57
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn15.Caption = "Cant. Comprada"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemPopupContainerEditOrderedQty
        Me.GridColumn15.DisplayFormat.FormatString = "#.###"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "CurrentOrderQty"
        Me.GridColumn15.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        Me.GridColumn15.Width = 74
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
        Me.grdOnOrderOSQty.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoOpenPO})
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
        Me.gvOnOrderOSQty.OptionsView.ShowFooter = True
        Me.gvOnOrderOSQty.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cant. Pedida"
        Me.GridColumn2.DisplayFormat.FormatString = "0.##"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Quantity"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")})
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
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReceivedQty", "{0:0.##}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 67
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "# O.C."
        Me.GridColumn11.FieldName = "PONum"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
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
        Me.GridColumn35.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutStandingQty", "{0:0.##}")})
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 5
        Me.GridColumn35.Width = 63
        '
        'repoOpenPO
        '
        Me.repoOpenPO.AutoHeight = False
        Me.repoOpenPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoOpenPO.Name = "repoOpenPO"
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
        Me.gcMatReqToOrder.DisplayFormat.FormatString = "#.###"
        Me.gcMatReqToOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcMatReqToOrder.FieldName = "ToOrder"
        Me.gcMatReqToOrder.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gcMatReqToOrder.Name = "gcMatReqToOrder"
        Me.gcMatReqToOrder.Visible = True
        Me.gcMatReqToOrder.VisibleIndex = 18
        Me.gcMatReqToOrder.Width = 86
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
        Me.GridColumn1.Caption = "Pend. a Comprar"
        Me.GridColumn1.ColumnEdit = Me.repoFormat
        Me.GridColumn1.DisplayFormat.FormatString = "#.###"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "OrderedOutstandingQty"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 15
        Me.GridColumn1.Width = 86
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Tipo Mant."
        Me.GridColumn32.FieldName = "MaintenanceTypeDesc"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.ReadOnly = True
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 4
        Me.GridColumn32.Width = 92
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "# Venta"
        Me.GridColumn19.FieldName = "OrderNo"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Width = 43
        '
        'gcStockItemLocationsQty
        '
        Me.gcStockItemLocationsQty.Caption = "Cantidad Disponible"
        Me.gcStockItemLocationsQty.ColumnEdit = Me.repoFormat
        Me.gcStockItemLocationsQty.DisplayFormat.FormatString = "#.###"
        Me.gcStockItemLocationsQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcStockItemLocationsQty.FieldName = "gcStockItemLocationsQty"
        Me.gcStockItemLocationsQty.Name = "gcStockItemLocationsQty"
        Me.gcStockItemLocationsQty.OptionsColumn.ReadOnly = True
        Me.gcStockItemLocationsQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.gcStockItemLocationsQty.Visible = True
        Me.gcStockItemLocationsQty.VisibleIndex = 11
        Me.gcStockItemLocationsQty.Width = 70
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "UdM"
        Me.GridColumn9.FieldName = "UoMDesc"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 44
        '
        'gcFromStock
        '
        Me.gcFromStock.AppearanceCell.BackColor = System.Drawing.Color.LightCyan
        Me.gcFromStock.AppearanceCell.Options.UseBackColor = True
        Me.gcFromStock.AppearanceCell.Options.UseTextOptions = True
        Me.gcFromStock.Caption = "De Inventario"
        Me.gcFromStock.DisplayFormat.FormatString = "#.###"
        Me.gcFromStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcFromStock.FieldName = "FromStock"
        Me.gcFromStock.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gcFromStock.Name = "gcFromStock"
        Me.gcFromStock.Visible = True
        Me.gcFromStock.VisibleIndex = 19
        Me.gcFromStock.Width = 74
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
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Cliente"
        Me.GridColumn33.FieldName = "CompanyName"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.ReadOnly = True
        Me.GridColumn33.Width = 35
        '
        'gcSOIDescription
        '
        Me.gcSOIDescription.Caption = "Etapa"
        Me.gcSOIDescription.FieldName = "SOIDescription"
        Me.gcSOIDescription.Name = "gcSOIDescription"
        Me.gcSOIDescription.OptionsColumn.ReadOnly = True
        Me.gcSOIDescription.Visible = True
        Me.gcSOIDescription.VisibleIndex = 1
        Me.gcSOIDescription.Width = 118
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "# O.T."
        Me.GridColumn12.FieldName = "MaintenanceWorkOrderNo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 62
        '
        'gcComments
        '
        Me.gcComments.Caption = "Comentarios"
        Me.gcComments.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.gcComments.FieldName = "Comments"
        Me.gcComments.Name = "gcComments"
        Me.gcComments.Visible = True
        Me.gcComments.VisibleIndex = 8
        Me.gcComments.Width = 55
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Tipo"
        Me.GridColumn37.FieldName = "MaintenanceTypeDesc"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.ReadOnly = True
        Me.GridColumn37.Width = 60
        '
        'gcWODescription
        '
        Me.gcWODescription.Caption = "Desc. OT"
        Me.gcWODescription.FieldName = "MaintenanceDescription"
        Me.gcWODescription.Name = "gcWODescription"
        Me.gcWODescription.OptionsColumn.ReadOnly = True
        '
        'gcIsFromStockValidated
        '
        Me.gcIsFromStockValidated.AppearanceCell.BackColor = System.Drawing.Color.LightCyan
        Me.gcIsFromStockValidated.AppearanceCell.Options.UseBackColor = True
        Me.gcIsFromStockValidated.Caption = "Válido"
        Me.gcIsFromStockValidated.ColumnEdit = Me.repoChkIsFromStockValidated
        Me.gcIsFromStockValidated.FieldName = "IsFromStockValidated"
        Me.gcIsFromStockValidated.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gcIsFromStockValidated.Name = "gcIsFromStockValidated"
        Me.gcIsFromStockValidated.Visible = True
        Me.gcIsFromStockValidated.VisibleIndex = 20
        Me.gcIsFromStockValidated.Width = 94
        '
        'repoChkIsFromStockValidated
        '
        Me.repoChkIsFromStockValidated.AutoHeight = False
        Me.repoChkIsFromStockValidated.Name = "repoChkIsFromStockValidated"
        '
        'gcTotalFromStock
        '
        Me.gcTotalFromStock.Caption = "Inv. Total Reservado"
        Me.gcTotalFromStock.ColumnEdit = Me.repoFormat
        Me.gcTotalFromStock.DisplayFormat.FormatString = "#.###"
        Me.gcTotalFromStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcTotalFromStock.FieldName = "OutstandingFromStockQty"
        Me.gcTotalFromStock.Name = "gcTotalFromStock"
        Me.gcTotalFromStock.OptionsColumn.ReadOnly = True
        Me.gcTotalFromStock.Visible = True
        Me.gcTotalFromStock.VisibleIndex = 10
        Me.gcTotalFromStock.Width = 45
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Cantidad en Inventario"
        Me.GridColumn17.ColumnEdit = Me.repoFormat
        Me.GridColumn17.DisplayFormat.FormatString = "#.###"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "StockItemLocationsQty"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 9
        Me.GridColumn17.Width = 50
        '
        'gcArea
        '
        Me.gcArea.Caption = "Área"
        Me.gcArea.FieldName = "AreaDesc"
        Me.gcArea.Name = "gcArea"
        Me.gcArea.OptionsColumn.ReadOnly = True
        Me.gcArea.Visible = True
        Me.gcArea.VisibleIndex = 1
        Me.gcArea.Width = 47
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "MaterialRequirementID"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cantitad Total x O.T."
        Me.GridColumn8.ColumnEdit = Me.repoFormat
        Me.GridColumn8.DisplayFormat.FormatString = "#.###"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "TotalOTQuantity"
        Me.GridColumn8.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 13
        Me.GridColumn8.Width = 69
        '
        'gcChangeDate
        '
        Me.gcChangeDate.Caption = "Fecha Generada"
        Me.gcChangeDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.gcChangeDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm"
        Me.gcChangeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcChangeDate.FieldName = "DateChange"
        Me.gcChangeDate.Name = "gcChangeDate"
        Me.gcChangeDate.Visible = True
        Me.gcChangeDate.VisibleIndex = 3
        Me.gcChangeDate.Width = 60
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'repo
        '
        Me.repo.AutoHeight = False
        Me.repo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repo.Name = "repo"
        '
        'repoOpenImage
        '
        Me.repoOpenImage.AutoHeight = False
        Me.repoOpenImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoOpenImage.Name = "repoOpenImage"
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
        Me.grpMaterialRequirements.Controls.Add(Me.popupImageContainer)
        Me.grpMaterialRequirements.Controls.Add(Me.pccStockItemTrans)
        Me.grpMaterialRequirements.Controls.Add(Me.puccOnOrderOSQty)
        Me.grpMaterialRequirements.Controls.Add(Me.grdMaterialRequirements)
        Me.grpMaterialRequirements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpMaterialRequirements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMaterialRequirements.Location = New System.Drawing.Point(0, 28)
        Me.grpMaterialRequirements.Name = "grpMaterialRequirements"
        Me.grpMaterialRequirements.Size = New System.Drawing.Size(1502, 655)
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
        'frmMaterialRequirementMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 683)
        Me.Controls.Add(Me.grpMaterialRequirements)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaterialRequirementMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Requerimientos de Mantenimiento"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoMatReqOptionView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoItemPopupImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupImageContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupImageContainer.ResumeLayout(False)
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposItemPopupContainerEditSITrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pccStockItemTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccStockItemTrans.ResumeLayout(False)
        CType(Me.grdStockitemTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcStockItemTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDateFormat.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDateFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEditOrderedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puccOnOrderOSQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.puccOnOrderOSQty.ResumeLayout(False)
        CType(Me.grdOnOrderOSQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOnOrderOSQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoOpenPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repItemQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoChkIsFromStockValidated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoOpenImage, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents gcInvReserved As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bsubitProcessToPO As DevExpress.XtraBars.BarSubItem
  Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
  Friend WithEvents bbtnPrintMiscPickingLists As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents repItemQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents grpMaterialRequirements As DevExpress.XtraEditors.GroupControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbtnExcelExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RepositoryItemPopupContainerEditOrderedQty As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockItemLocationsQty As DevExpress.XtraGrid.Columns.GridColumn
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
  Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSITranTranType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSITranUserID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barbtnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcFromStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQuantityFromStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSOIDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents gcComments As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
  Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoDateFormat As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents cheOptionViews As DevExpress.XtraBars.BarEditItem
  Friend WithEvents repoMatReqOptionView As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
  Friend WithEvents gcWODescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents repo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcIsFromStockValidated As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoChkIsFromStockValidated As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents gcTotalFromStock As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoFormat As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents repoOpenPO As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repoOpenImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents popupImageContainer As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents peImage As DevExpress.XtraEditors.PictureEdit
  Friend WithEvents repoItemPopupImage As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents gcArea As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcChangeDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
