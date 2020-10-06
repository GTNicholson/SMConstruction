<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickerStockItem
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
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grdItemList = New DevExpress.XtraGrid.GridControl()
        Me.gvItemList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoItemSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.gcDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSystemQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUoM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoItemRemove = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbtnNewStockItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.xtabCategories = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoItemRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtabCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabCategories.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdItemList
        '
        Me.grdItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdItemList.Location = New System.Drawing.Point(0, 0)
        Me.grdItemList.MainView = Me.gvItemList
        Me.grdItemList.Name = "grdItemList"
        Me.grdItemList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoItemSelect, Me.repoItemRemove})
        Me.grdItemList.Size = New System.Drawing.Size(991, 429)
        Me.grdItemList.TabIndex = 98
        Me.grdItemList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemList})
        '
        'gvItemList
        '
        Me.gvItemList.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvItemList.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvItemList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvItemList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvItemList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvItemList.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvItemList.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvItemList.Appearance.OddRow.Options.UseBackColor = True
        Me.gvItemList.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvItemList.Appearance.Row.Options.UseFont = True
        Me.gvItemList.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvItemList.Appearance.SelectedRow.Options.UseFont = True
        Me.gvItemList.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gvItemList.Appearance.TopNewRow.Options.UseFont = True
        Me.gvItemList.ColumnPanelRowHeight = 34
        Me.gvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcStockCode, Me.gcDescription, Me.gcCategory, Me.gcItemType, Me.gcPartNo, Me.gcSystemQty, Me.gcUoM})
        Me.gvItemList.GridControl = Me.grdItemList
        Me.gvItemList.HorzScrollStep = 20
        Me.gvItemList.Name = "gvItemList"
        Me.gvItemList.OptionsView.EnableAppearanceEvenRow = True
        Me.gvItemList.OptionsView.EnableAppearanceOddRow = True
        Me.gvItemList.OptionsView.ShowAutoFilterRow = True
        Me.gvItemList.OptionsView.ShowDetailButtons = False
        Me.gvItemList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvItemList.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "StockItemID"
        Me.gcID.Name = "gcID"
        Me.gcID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcID.Width = 82
        '
        'gcStockCode
        '
        Me.gcStockCode.Caption = "Código"
        Me.gcStockCode.ColumnEdit = Me.repoItemSelect
        Me.gcStockCode.FieldName = "StockCode"
        Me.gcStockCode.Name = "gcStockCode"
        Me.gcStockCode.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcStockCode.Visible = True
        Me.gcStockCode.VisibleIndex = 0
        Me.gcStockCode.Width = 168
        '
        'repoItemSelect
        '
        Me.repoItemSelect.AutoHeight = False
        Me.repoItemSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoItemSelect.Name = "repoItemSelect"
        Me.repoItemSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'gcDescription
        '
        Me.gcDescription.Caption = "Descripción"
        Me.gcDescription.FieldName = "Description"
        Me.gcDescription.Name = "gcDescription"
        Me.gcDescription.OptionsColumn.ReadOnly = True
        Me.gcDescription.Visible = True
        Me.gcDescription.VisibleIndex = 1
        Me.gcDescription.Width = 258
        '
        'gcCategory
        '
        Me.gcCategory.Caption = "Categoría"
        Me.gcCategory.FieldName = "Category"
        Me.gcCategory.Name = "gcCategory"
        Me.gcCategory.Width = 225
        '
        'gcItemType
        '
        Me.gcItemType.Caption = "Sub Categoría"
        Me.gcItemType.FieldName = "gc"
        Me.gcItemType.Name = "gcItemType"
        Me.gcItemType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcItemType.Visible = True
        Me.gcItemType.VisibleIndex = 3
        Me.gcItemType.Width = 124
        '
        'gcPartNo
        '
        Me.gcPartNo.Caption = "Número Parte"
        Me.gcPartNo.FieldName = "PartNo"
        Me.gcPartNo.Name = "gcPartNo"
        Me.gcPartNo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcPartNo.Visible = True
        Me.gcPartNo.VisibleIndex = 4
        Me.gcPartNo.Width = 79
        '
        'gcSystemQty
        '
        Me.gcSystemQty.Caption = "Cantidad Disp."
        Me.gcSystemQty.Name = "gcSystemQty"
        Me.gcSystemQty.Visible = True
        Me.gcSystemQty.VisibleIndex = 5
        Me.gcSystemQty.Width = 62
        '
        'gcUoM
        '
        Me.gcUoM.Caption = "UdM"
        Me.gcUoM.FieldName = "SupplierUoM"
        Me.gcUoM.Name = "gcUoM"
        Me.gcUoM.OptionsColumn.ReadOnly = True
        Me.gcUoM.Visible = True
        Me.gcUoM.VisibleIndex = 2
        '
        'repoItemRemove
        '
        Me.repoItemRemove.AutoHeight = False
        Me.repoItemRemove.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Remove", -1, True, True, True, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoItemRemove.Name = "repoItemRemove"
        Me.repoItemRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1083, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnNewStockItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 1
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnNewStockItem)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'bbtnNewStockItem
        '
        Me.bbtnNewStockItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnNewStockItem.Caption = "Agregar Nuevo Producto"
        Me.bbtnNewStockItem.Id = 0
        Me.bbtnNewStockItem.Name = "bbtnNewStockItem"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(1083, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 461)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1083, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 435)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1083, 26)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 435)
        '
        'xtabCategories
        '
        Me.xtabCategories.AppearancePage.Header.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtabCategories.AppearancePage.Header.Options.UseFont = True
        Me.xtabCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtabCategories.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.xtabCategories.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtabCategories.Location = New System.Drawing.Point(0, 26)
        Me.xtabCategories.Name = "xtabCategories"
        Me.xtabCategories.SelectedTabPage = Me.XtraTabPage1
        Me.xtabCategories.Size = New System.Drawing.Size(1083, 435)
        Me.xtabCategories.TabIndex = 104
        Me.xtabCategories.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.grdItemList)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(991, 429)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'frmPickerStockItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 461)
        Me.Controls.Add(Me.xtabCategories)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "frmPickerStockItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Artículos de Inventario"
        CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoItemRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtabCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabCategories.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdItemList As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvItemList As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoItemSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPartNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoItemRemove As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcSystemQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnNewStockItem As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents xtabCategories As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcUoM As DevExpress.XtraGrid.Columns.GridColumn
End Class
