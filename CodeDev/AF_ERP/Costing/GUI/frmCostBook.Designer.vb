<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCostBook
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
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.pgfDoorFacingBandID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.gcDoorCoreBand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barbtnSaveExit = New DevExpress.XtraBars.BarButtonItem()
        Me.barbt_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.barbt_Exit = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bcboCostBookID = New DevExpress.XtraBars.BarEditItem()
        Me.repoCostBook = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.dteDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCostBookName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboIsDefault = New DevExpress.XtraEditors.CheckEdit()
        Me.pgfDoorDimsID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfDoorThickness = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfPrice = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.gcCost = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboStockItemType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnLoadStockItem = New DevExpress.XtraEditors.SimpleButton()
        Me.grdCostBookEntry = New DevExpress.XtraGrid.GridControl()
        Me.gvCostBookEntry = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCostUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSpecies = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoCostUnit = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoCostBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostBookName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboIsDefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cboStockItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCostBookEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCostBookEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoCostUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'pgfDoorFacingBandID
        '
        Me.pgfDoorFacingBandID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfDoorFacingBandID.AreaIndex = 0
        Me.pgfDoorFacingBandID.FieldName = "DoorFacingBand"
        Me.pgfDoorFacingBandID.Name = "pgfDoorFacingBandID"
        Me.pgfDoorFacingBandID.Width = 164
        '
        'gcDoorCoreBand
        '
        Me.gcDoorCoreBand.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.gcDoorCoreBand.AreaIndex = 1
        Me.gcDoorCoreBand.Caption = "Door Core"
        Me.gcDoorCoreBand.FieldName = "DoorCoreBand"
        Me.gcDoorCoreBand.Name = "gcDoorCoreBand"
        Me.gcDoorCoreBand.UnboundFieldName = "gcDoorCoreBand"
        Me.gcDoorCoreBand.Width = 120
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbt_Exit, Me.barbt_Save, Me.bcboCostBookID, Me.BarStaticItem1, Me.barbtnSaveExit})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoCostBook})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSaveExit), New DevExpress.XtraBars.LinkPersistInfo(Me.barbt_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.barbt_Exit)})
        Me.Bar1.Text = "Tools"
        '
        'barbtnSaveExit
        '
        Me.barbtnSaveExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbtnSaveExit.Caption = "Guardar && Salir"
        Me.barbtnSaveExit.Id = 4
        Me.barbtnSaveExit.Name = "barbtnSaveExit"
        '
        'barbt_Save
        '
        Me.barbt_Save.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbt_Save.Caption = "Guardar"
        Me.barbt_Save.Id = 1
        Me.barbt_Save.Name = "barbt_Save"
        '
        'barbt_Exit
        '
        Me.barbt_Exit.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.barbt_Exit.Caption = "Cerrar"
        Me.barbt_Exit.Id = 0
        Me.barbt_Exit.Name = "barbt_Exit"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1350, 30)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 648)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1350, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 618)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1350, 30)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 618)
        '
        'bcboCostBookID
        '
        Me.bcboCostBookID.Caption = "Cost Book"
        Me.bcboCostBookID.Edit = Me.repoCostBook
        Me.bcboCostBookID.Id = 2
        Me.bcboCostBookID.Name = "bcboCostBookID"
        '
        'repoCostBook
        '
        Me.repoCostBook.AutoHeight = False
        Me.repoCostBook.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoCostBook.Name = "repoCostBook"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarStaticItem1.Caption = "Cost Book"
        Me.BarStaticItem1.Id = 3
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'dteDate
        '
        Me.dteDate.EditValue = Nothing
        Me.dteDate.Location = New System.Drawing.Point(399, 44)
        Me.dteDate.MenuManager = Me.BarManager1
        Me.dteDate.Name = "dteDate"
        Me.dteDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dteDate.Properties.Appearance.Options.UseFont = True
        Me.dteDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDate.Properties.NullDate = New Date(CType(0, Long))
        Me.dteDate.Size = New System.Drawing.Size(159, 22)
        Me.dteDate.TabIndex = 3
        '
        'txtCostBookName
        '
        Me.txtCostBookName.Location = New System.Drawing.Point(73, 43)
        Me.txtCostBookName.MenuManager = Me.BarManager1
        Me.txtCostBookName.Name = "txtCostBookName"
        Me.txtCostBookName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCostBookName.Properties.Appearance.Options.UseFont = True
        Me.txtCostBookName.Size = New System.Drawing.Size(164, 22)
        Me.txtCostBookName.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(17, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl1.TabIndex = 128
        Me.LabelControl1.Text = "Nombre"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(350, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl2.TabIndex = 129
        Me.LabelControl2.Text = "Fecha"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.cboIsDefault)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtCostBookName)
        Me.GroupControl1.Controls.Add(Me.dteDate)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 30)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1350, 103)
        Me.GroupControl1.TabIndex = 137
        Me.GroupControl1.Text = "Cost Book Detail"
        '
        'cboIsDefault
        '
        Me.cboIsDefault.Location = New System.Drawing.Point(664, 45)
        Me.cboIsDefault.MenuManager = Me.BarManager1
        Me.cboIsDefault.Name = "cboIsDefault"
        Me.cboIsDefault.Properties.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cboIsDefault.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboIsDefault.Properties.Appearance.Options.UseFont = True
        Me.cboIsDefault.Properties.Appearance.Options.UseForeColor = True
        Me.cboIsDefault.Properties.Caption = "Por Defecto?"
        Me.cboIsDefault.Size = New System.Drawing.Size(184, 20)
        Me.cboIsDefault.TabIndex = 132
        '
        'pgfDoorDimsID
        '
        Me.pgfDoorDimsID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.pgfDoorDimsID.AreaIndex = 0
        Me.pgfDoorDimsID.Caption = "Dims"
        Me.pgfDoorDimsID.FieldName = "DoorDims"
        Me.pgfDoorDimsID.Name = "pgfDoorDimsID"
        '
        'pgfDoorThickness
        '
        Me.pgfDoorThickness.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfDoorThickness.AreaIndex = 2
        Me.pgfDoorThickness.Caption = "Thickness"
        Me.pgfDoorThickness.FieldName = "ThicknessDims"
        Me.pgfDoorThickness.Name = "pgfDoorThickness"
        Me.pgfDoorThickness.ValueFormat.FormatString = "f0"
        Me.pgfDoorThickness.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pgfDoorThickness.Width = 120
        '
        'pgfPrice
        '
        Me.pgfPrice.FieldEdit = Me.RepositoryItemTextEdit1
        Me.pgfPrice.FieldName = "Price"
        Me.pgfPrice.Name = "pgfPrice"
        Me.pgfPrice.Visible = False
        Me.pgfPrice.Width = 140
        '
        'gcCost
        '
        Me.gcCost.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.gcCost.AreaIndex = 0
        Me.gcCost.FieldEdit = Me.RepositoryItemTextEdit1
        Me.gcCost.FieldName = "Cost"
        Me.gcCost.Name = "gcCost"
        Me.gcCost.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.XtraTabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 487)
        Me.Panel1.TabIndex = 143
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XtraTabControl1.AppearancePage.Header.ForeColor = System.Drawing.Color.Maroon
        Me.XtraTabControl1.AppearancePage.Header.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1350, 487)
        Me.XtraTabControl1.TabIndex = 142
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.cboStockItemType)
        Me.XtraTabPage2.Controls.Add(Me.btnLoadStockItem)
        Me.XtraTabPage2.Controls.Add(Me.grdCostBookEntry)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1342, 452)
        Me.XtraTabPage2.Text = "Lista de Artículos de Madera"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(18, 28)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(109, 16)
        Me.LabelControl4.TabIndex = 131
        Me.LabelControl4.Text = "Tipo de Producto"
        '
        'cboStockItemType
        '
        Me.cboStockItemType.Location = New System.Drawing.Point(133, 25)
        Me.cboStockItemType.MenuManager = Me.BarManager1
        Me.cboStockItemType.Name = "cboStockItemType"
        Me.cboStockItemType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cboStockItemType.Properties.Appearance.Options.UseFont = True
        Me.cboStockItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStockItemType.Size = New System.Drawing.Size(179, 22)
        Me.cboStockItemType.TabIndex = 130
        '
        'btnLoadStockItem
        '
        Me.btnLoadStockItem.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadStockItem.Appearance.Options.UseFont = True
        Me.btnLoadStockItem.Location = New System.Drawing.Point(332, 24)
        Me.btnLoadStockItem.Name = "btnLoadStockItem"
        Me.btnLoadStockItem.Size = New System.Drawing.Size(92, 25)
        Me.btnLoadStockItem.TabIndex = 1
        Me.btnLoadStockItem.Text = "Cargar Datos"
        '
        'grdCostBookEntry
        '
        Me.grdCostBookEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCostBookEntry.Location = New System.Drawing.Point(4, 70)
        Me.grdCostBookEntry.MainView = Me.gvCostBookEntry
        Me.grdCostBookEntry.MenuManager = Me.BarManager1
        Me.grdCostBookEntry.Name = "grdCostBookEntry"
        Me.grdCostBookEntry.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoCostUnit})
        Me.grdCostBookEntry.Size = New System.Drawing.Size(1332, 381)
        Me.grdCostBookEntry.TabIndex = 0
        Me.grdCostBookEntry.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCostBookEntry, Me.GridView2})
        '
        'gvCostBookEntry
        '
        Me.gvCostBookEntry.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.CustomizationFormHint.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.DetailTip.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.DetailTip.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.DetailTip.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.DetailTip.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.Empty.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.Empty.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.Empty.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.EvenRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.FilterPanel.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.FilterPanel.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.FixedLine.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.FixedLine.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.FixedLine.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvCostBookEntry.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.FocusedCell.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvCostBookEntry.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.FocusedRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.FooterPanel.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.FooterPanel.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.GroupButton.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.GroupButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.GroupButton.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.GroupFooter.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.GroupFooter.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.GroupPanel.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.GroupRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.GroupRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gvCostBookEntry.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.HorzLine.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.HorzLine.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.HorzLine.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.OddRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.OddRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.OddRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.Preview.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.Preview.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.Preview.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.Preview.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.Row.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.Row.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.Row.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.RowSeparator.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.RowSeparator.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.RowSeparator.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.SelectedRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.TopNewRow.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.TopNewRow.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.VertLine.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.VertLine.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.VertLine.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.VertLine.Options.UseFont = True
        Me.gvCostBookEntry.Appearance.ViewCaption.BackColor = System.Drawing.Color.Transparent
        Me.gvCostBookEntry.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvCostBookEntry.Appearance.ViewCaption.Options.UseBackColor = True
        Me.gvCostBookEntry.Appearance.ViewCaption.Options.UseFont = True
        Me.gvCostBookEntry.ColumnPanelRowHeight = 30
        Me.gvCostBookEntry.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.gcCostUnit, Me.GridColumn9, Me.gcSpecies, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn8})
        Me.gvCostBookEntry.DetailHeight = 380
        Me.gvCostBookEntry.GridControl = Me.grdCostBookEntry
        Me.gvCostBookEntry.Name = "gvCostBookEntry"
        Me.gvCostBookEntry.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvCostBookEntry.OptionsView.ShowAutoFilterRow = True
        Me.gvCostBookEntry.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gvCostBookEntry.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.Caption = "CostBookEntryID"
        Me.GridColumn1.FieldName = "CostBookEntryID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.Caption = "CostBookID"
        Me.GridColumn2.FieldName = "CostBookID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.Caption = "StockItemID"
        Me.GridColumn3.FieldName = "StockItemID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.Caption = "Costo"
        Me.GridColumn4.DisplayFormat.FormatString = "f2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Cost"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        Me.GridColumn4.Width = 88
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.Caption = "Descripción"
        Me.GridColumn5.FieldName = "SIDescription"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 245
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.Caption = "Código"
        Me.GridColumn6.FieldName = "SIStockCode"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 122
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.Caption = "Categoría"
        Me.GridColumn7.FieldName = "StockItemCategoryDesc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 325
        '
        'gcCostUnit
        '
        Me.gcCostUnit.Caption = "Unidad de Costeo"
        Me.gcCostUnit.FieldName = "CostUnit"
        Me.gcCostUnit.Name = "gcCostUnit"
        Me.gcCostUnit.OptionsColumn.ReadOnly = True
        Me.gcCostUnit.Visible = True
        Me.gcCostUnit.VisibleIndex = 5
        Me.gcCostUnit.Width = 116
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Costo Min."
        Me.GridColumn9.DisplayFormat.FormatString = "f2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "MinCost"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 93
        '
        'gcSpecies
        '
        Me.gcSpecies.Caption = "Especie"
        Me.gcSpecies.FieldName = "SpeciesDesc"
        Me.gcSpecies.Name = "gcSpecies"
        Me.gcSpecies.OptionsColumn.ReadOnly = True
        Me.gcSpecies.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcSpecies.Visible = True
        Me.gcSpecies.VisibleIndex = 3
        Me.gcSpecies.Width = 178
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Largo"
        Me.GridColumn24.DisplayFormat.FormatString = "N0"
        Me.GridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn24.FieldName = "Length"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Width = 62
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Ancho"
        Me.GridColumn25.DisplayFormat.FormatString = "N0"
        Me.GridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn25.FieldName = "Width"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.Width = 64
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Grosor"
        Me.GridColumn26.DisplayFormat.FormatString = "N2"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "Thickness"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 4
        Me.GridColumn26.Width = 49
        '
        'repoCostUnit
        '
        Me.repoCostUnit.AutoHeight = False
        Me.repoCostUnit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoCostUnit.Name = "repoCostUnit"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdCostBookEntry
        Me.GridView2.Name = "GridView2"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Costo Gerencia"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 100
        '
        'frmCostBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 648)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "frmCostBook"
        Me.Text = "Libro de Costo de Insumos"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoCostBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostBookName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboIsDefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cboStockItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCostBookEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCostBookEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoCostUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barbt_Exit As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbt_Save As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents bcboCostBookID As DevExpress.XtraBars.BarEditItem
  Friend WithEvents repoCostBook As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents barbtnSaveExit As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents Panel1 As Panel
  Friend WithEvents pgfDoorDimsID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents pgfDoorThickness As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents pgfPrice As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcCost As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcDoorCoreBand As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCostBookName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents dteDate As DevExpress.XtraEditors.DateEdit
  Private WithEvents pgfDoorFacingBandID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents cboIsDefault As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboStockItemType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnLoadStockItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdCostBookEntry As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCostBookEntry As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCostUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSpecies As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoCostUnit As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
