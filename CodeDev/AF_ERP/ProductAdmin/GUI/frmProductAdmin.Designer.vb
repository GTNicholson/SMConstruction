<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductAdmin
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
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grdProductBase = New DevExpress.XtraGrid.GridControl()
        Me.gvProductBase = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoSelectedItem = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtnmnuAddProduct = New DevExpress.XtraBars.BarSubItem()
        Me.bbtnAddProductFurniture = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnAddStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnAddProductInstallation = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAddBasicItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barbtnAddLockItem = New DevExpress.XtraBars.BarButtonItem()
        Me.bargCostingOnly = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.barbtnAddStockItem = New DevExpress.XtraBars.BarButtonItem()
        Me.df = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.barbtnAddStockItemCats = New DevExpress.XtraBars.BarSubItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.barbtnAddStockItemCat = New DevExpress.XtraBars.BarSubItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.beCategory = New DevExpress.XtraBars.BarEditItem()
        Me.repoCategory = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnAddStockItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
        Me.repoIsTemplate = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.rgbStockItemOptions = New DevExpress.XtraBars.BarEditItem()
        Me.repoStockItemOption = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.btnSelectAll = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSelectVisible = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGenerateDescriptionItem = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnGlobalChanges = New DevExpress.XtraBars.BarButtonItem()
        Me.RepoItemRadioGroupCategory = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.grpStockItemDetail = New DevExpress.XtraEditors.GroupControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.uctProductDetail = New AgroForestal.uctProductBaseDetail()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grdProductBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoSelectedItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoIsTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoStockItemOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemRadioGroupCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpStockItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStockItemDetail.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SplitContainerControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 33)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1485, 895)
        Me.PanelControl1.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grdProductBase)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grpStockItemDetail)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1481, 891)
        Me.SplitContainerControl1.SplitterPosition = 645
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'grdProductBase
        '
        Me.grdProductBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProductBase.Location = New System.Drawing.Point(0, 0)
        Me.grdProductBase.MainView = Me.gvProductBase
        Me.grdProductBase.MenuManager = Me.BarManager1
        Me.grdProductBase.Name = "grdProductBase"
        Me.grdProductBase.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoSelectedItem})
        Me.grdProductBase.Size = New System.Drawing.Size(1481, 241)
        Me.grdProductBase.TabIndex = 0
        Me.grdProductBase.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductBase})
        '
        'gvProductBase
        '
        Me.gvProductBase.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvProductBase.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvProductBase.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvProductBase.Appearance.EvenRow.Options.UseFont = True
        Me.gvProductBase.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvProductBase.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvProductBase.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvProductBase.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvProductBase.Appearance.OddRow.Options.UseBackColor = True
        Me.gvProductBase.Appearance.OddRow.Options.UseFont = True
        Me.gvProductBase.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvProductBase.Appearance.Row.Options.UseBackColor = True
        Me.gvProductBase.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn2, Me.gcCategory, Me.GridColumn7, Me.GridColumn3, Me.GridColumn5})
        Me.gvProductBase.GridControl = Me.grdProductBase
        Me.gvProductBase.GroupCount = 1
        Me.gvProductBase.Name = "gvProductBase"
        Me.gvProductBase.OptionsView.EnableAppearanceEvenRow = True
        Me.gvProductBase.OptionsView.EnableAppearanceOddRow = True
        Me.gvProductBase.OptionsView.ShowAutoFilterRow = True
        Me.gvProductBase.OptionsView.ShowDetailButtons = False
        Me.gvProductBase.OptionsView.ShowGroupPanel = False
        Me.gvProductBase.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Categoria"
        Me.GridColumn4.FieldName = "CategoryDesc"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 113
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Descripción"
        Me.GridColumn1.FieldName = "Description"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 610
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Código"
        Me.GridColumn2.FieldName = "Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 196
        '
        'gcCategory
        '
        Me.gcCategory.Caption = "Tipo de Producto"
        Me.gcCategory.FieldName = "ItemTypeDesc"
        Me.gcCategory.Name = "gcCategory"
        Me.gcCategory.OptionsColumn.ReadOnly = True
        Me.gcCategory.Visible = True
        Me.gcCategory.VisibleIndex = 2
        Me.gcCategory.Width = 136
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = " "
        Me.GridColumn7.ColumnEdit = Me.repoSelectedItem
        Me.GridColumn7.FieldName = "SelectTmp"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 44
        '
        'repoSelectedItem
        '
        Me.repoSelectedItem.AutoHeight = False
        Me.repoSelectedItem.Name = "repoSelectedItem"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Sub Item Product"
        Me.GridColumn3.FieldName = "SubItemTypeDesc"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 142
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "GridColumn5"
        Me.GridColumn5.FieldName = "DrawingFileName"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.barbtnAddBasicItem, Me.barbtnAddLockItem, Me.bargCostingOnly, Me.barbtnAddStockItem, Me.df, Me.barbtnAddStockItemCats, Me.BarEditItem1, Me.barbtnAddStockItemCat, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarEditItem2, Me.beCategory, Me.btnAddStockItem, Me.BarEditItem3, Me.BarEditItem4, Me.BarStaticItem3, Me.BarCheckItem1, Me.BarEditItem5, Me.rgbStockItemOptions, Me.btnSelectAll, Me.btnSelectVisible, Me.btnClear, Me.btnGenerateDescriptionItem, Me.bbtnGlobalChanges, Me.bbtnmnuAddProduct, Me.bbtnAddProductFurniture, Me.bbtnAddStructure, Me.bbtnAddProductInstallation})
        Me.BarManager1.MaxItemId = 30
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoItemRadioGroupCategory, Me.RepositoryItemComboBox1, Me.RepositoryItemTextEdit1, Me.repoCategory, Me.RepositoryItemCheckEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemRadioGroup1, Me.repoIsTemplate, Me.repoStockItemOption})
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnmnuAddProduct)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'bbtnmnuAddProduct
        '
        Me.bbtnmnuAddProduct.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnmnuAddProduct.Caption = "Agregar Producto"
        Me.bbtnmnuAddProduct.Id = 26
        Me.bbtnmnuAddProduct.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnAddProductFurniture), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnAddStructure), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnAddProductInstallation)})
        Me.bbtnmnuAddProduct.Name = "bbtnmnuAddProduct"
        '
        'bbtnAddProductFurniture
        '
        Me.bbtnAddProductFurniture.Caption = "Mueble"
        Me.bbtnAddProductFurniture.Id = 27
        Me.bbtnAddProductFurniture.Name = "bbtnAddProductFurniture"
        '
        'bbtnAddStructure
        '
        Me.bbtnAddStructure.Caption = "Estructura"
        Me.bbtnAddStructure.Id = 28
        Me.bbtnAddStructure.Name = "bbtnAddStructure"
        '
        'bbtnAddProductInstallation
        '
        Me.bbtnAddProductInstallation.Caption = "Instalación"
        Me.bbtnAddProductInstallation.Id = 29
        Me.bbtnAddProductInstallation.Name = "bbtnAddProductInstallation"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1485, 33)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 928)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1485, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 895)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1485, 33)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 895)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barbtnAddBasicItem
        '
        Me.barbtnAddBasicItem.Caption = "Basic Item"
        Me.barbtnAddBasicItem.Id = 2
        Me.barbtnAddBasicItem.Name = "barbtnAddBasicItem"
        '
        'barbtnAddLockItem
        '
        Me.barbtnAddLockItem.Caption = "Lock Item"
        Me.barbtnAddLockItem.Id = 3
        Me.barbtnAddLockItem.Name = "barbtnAddLockItem"
        '
        'bargCostingOnly
        '
        Me.bargCostingOnly.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bargCostingOnly.Caption = "Is Costing Only?"
        Me.bargCostingOnly.Edit = Me.RepositoryItemCheckEdit1
        Me.bargCostingOnly.EditValue = CType(0, Byte)
        Me.bargCostingOnly.Id = 4
        Me.bargCostingOnly.Name = "bargCostingOnly"
        Me.bargCostingOnly.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'barbtnAddStockItem
        '
        Me.barbtnAddStockItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbtnAddStockItem.Caption = "Add Stock Item"
        Me.barbtnAddStockItem.Id = 5
        Me.barbtnAddStockItem.Name = "barbtnAddStockItem"
        '
        'df
        '
        Me.df.ActAsDropDown = True
        Me.df.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.df.Caption = "Add Stock Item"
        Me.df.DropDownControl = Me.PopupMenu1
        Me.df.Id = 6
        Me.df.Name = "df"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'barbtnAddStockItemCats
        '
        Me.barbtnAddStockItemCats.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbtnAddStockItemCats.Caption = "Categories"
        Me.barbtnAddStockItemCats.Id = 7
        Me.barbtnAddStockItemCats.Name = "barbtnAddStockItemCats"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Category"
        Me.BarEditItem1.Edit = Me.RepositoryItemComboBox1
        Me.BarEditItem1.Id = 8
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'barbtnAddStockItemCat
        '
        Me.barbtnAddStockItemCat.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbtnAddStockItemCat.Caption = "Category"
        Me.barbtnAddStockItemCat.Id = 9
        Me.barbtnAddStockItemCat.Name = "barbtnAddStockItemCat"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 10
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Tipo de Producto"
        Me.BarStaticItem2.Id = 11
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "BarEditItem2"
        Me.BarEditItem2.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem2.Id = 12
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'beCategory
        '
        Me.beCategory.Edit = Me.repoCategory
        Me.beCategory.Id = 13
        Me.beCategory.Name = "beCategory"
        '
        'repoCategory
        '
        Me.repoCategory.AutoHeight = False
        Me.repoCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoCategory.Name = "repoCategory"
        '
        'btnAddStockItem
        '
        Me.btnAddStockItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAddStockItem.Caption = "Agregar Producto"
        Me.btnAddStockItem.Id = 14
        Me.btnAddStockItem.Name = "btnAddStockItem"
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "fsdf"
        Me.BarEditItem3.Edit = Me.RepositoryItemButtonEdit1
        Me.BarEditItem3.Id = 15
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'BarEditItem4
        '
        Me.BarEditItem4.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.BarEditItem4.Caption = "tiempo"
        Me.BarEditItem4.Edit = Me.RepositoryItemRadioGroup1
        Me.BarEditItem4.Id = 16
        Me.BarEditItem4.Name = "BarEditItem4"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "dg")})
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Is Template?"
        Me.BarStaticItem3.Id = 17
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "BarCheckItem1"
        Me.BarCheckItem1.Id = 18
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarEditItem5
        '
        Me.BarEditItem5.Caption = "Is Template?"
        Me.BarEditItem5.Edit = Me.repoIsTemplate
        Me.BarEditItem5.Id = 19
        Me.BarEditItem5.Name = "BarEditItem5"
        '
        'repoIsTemplate
        '
        Me.repoIsTemplate.AutoHeight = False
        Me.repoIsTemplate.Name = "repoIsTemplate"
        '
        'rgbStockItemOptions
        '
        Me.rgbStockItemOptions.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.rgbStockItemOptions.Edit = Me.repoStockItemOption
        Me.rgbStockItemOptions.Id = 20
        Me.rgbStockItemOptions.Name = "rgbStockItemOptions"
        '
        'repoStockItemOption
        '
        Me.repoStockItemOption.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "All", True, "All"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Instalación", True, "ProductInstallation"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Estructura", True, "ProductStructure")})
        Me.repoStockItemOption.Name = "repoStockItemOption"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSelectAll.Caption = "Select All"
        Me.btnSelectAll.Id = 21
        Me.btnSelectAll.Name = "btnSelectAll"
        '
        'btnSelectVisible
        '
        Me.btnSelectVisible.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSelectVisible.Caption = "Select Visible"
        Me.btnSelectVisible.Id = 22
        Me.btnSelectVisible.Name = "btnSelectVisible"
        '
        'btnClear
        '
        Me.btnClear.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnClear.Caption = "Clear"
        Me.btnClear.Id = 23
        Me.btnClear.Name = "btnClear"
        '
        'btnGenerateDescriptionItem
        '
        Me.btnGenerateDescriptionItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnGenerateDescriptionItem.Caption = "Generate Description"
        Me.btnGenerateDescriptionItem.Id = 24
        Me.btnGenerateDescriptionItem.Name = "btnGenerateDescriptionItem"
        '
        'bbtnGlobalChanges
        '
        Me.bbtnGlobalChanges.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnGlobalChanges.Caption = "Global Changes"
        Me.bbtnGlobalChanges.Id = 25
        Me.bbtnGlobalChanges.Name = "bbtnGlobalChanges"
        '
        'RepoItemRadioGroupCategory
        '
        Me.RepoItemRadioGroupCategory.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepoItemRadioGroupCategory.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "All"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Ironmongery"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(4, Short), "Glass"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(5, Short), "Intumescents"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(6, Short), "Frame Component"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(8, Short), "Beading"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(9, Short), "LeafSet Bespoke"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(10, Short), "LeafSet Product")})
        Me.RepoItemRadioGroupCategory.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.RepoItemRadioGroupCategory.Name = "RepoItemRadioGroupCategory"
        '
        'grpStockItemDetail
        '
        Me.grpStockItemDetail.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStockItemDetail.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.grpStockItemDetail.Appearance.Options.UseFont = True
        Me.grpStockItemDetail.Appearance.Options.UseForeColor = True
        Me.grpStockItemDetail.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStockItemDetail.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpStockItemDetail.AppearanceCaption.Options.UseFont = True
        Me.grpStockItemDetail.AppearanceCaption.Options.UseForeColor = True
        Me.grpStockItemDetail.Controls.Add(Me.uctProductDetail)
        Me.grpStockItemDetail.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Guardar", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, CType(1, Short), -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Editar", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, CType(2, Short), -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Create Duplicates", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, CType(3, Short), -1)})
        Me.grpStockItemDetail.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpStockItemDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpStockItemDetail.Location = New System.Drawing.Point(0, 0)
        Me.grpStockItemDetail.Name = "grpStockItemDetail"
        Me.grpStockItemDetail.Size = New System.Drawing.Size(1481, 645)
        Me.grpStockItemDetail.TabIndex = 95
        Me.grpStockItemDetail.Text = "Detalles del Producto"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'uctProductDetail
        '
        Me.uctProductDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uctProductDetail.FormController = Nothing
        Me.uctProductDetail.Location = New System.Drawing.Point(2, 26)
        Me.uctProductDetail.Name = "uctProductDetail"
        Me.uctProductDetail.Size = New System.Drawing.Size(1477, 617)
        Me.uctProductDetail.TabIndex = 0
        '
        'frmProductAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 928)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmProductAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grdProductBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoSelectedItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoIsTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoStockItemOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemRadioGroupCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpStockItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStockItemDetail.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdProductBase As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductBase As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barbtnAddBasicItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barbtnAddLockItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bargCostingOnly As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepoItemRadioGroupCategory As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents barbtnAddStockItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents df As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents barbtnAddStockItemCats As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents barbtnAddStockItemCat As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents beCategory As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repoCategory As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnAddStockItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarEditItem5 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repoIsTemplate As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BarEditItem4 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents rgbStockItemOptions As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repoStockItemOption As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSelectAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSelectVisible As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGenerateDescriptionItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents repoSelectedItem As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bbtnGlobalChanges As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbtnmnuAddProduct As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbtnAddProductFurniture As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnAddStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnAddProductInstallation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpStockItemDetail As DevExpress.XtraEditors.GroupControl
    Friend WithEvents uctProductDetail As uctProductBaseDetail
End Class
