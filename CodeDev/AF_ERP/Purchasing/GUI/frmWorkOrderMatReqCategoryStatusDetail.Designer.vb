<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkOrderMatReqCategoryStatusDetail
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
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.grdMaterialRequirements = New DevExpress.XtraGrid.GridControl()
        Me.gvMaterialRequirements = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMatReqCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn75 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.radgrpPUStatusSetting = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLastDate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.grdPOs = New DevExpress.XtraGrid.GridControl()
        Me.gvPOs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCostCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repbtnSupplierPicker = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.grpRelatedPurchaseOrders = New DevExpress.XtraEditors.GroupControl()
        Me.btnExportMG = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblPickStatus = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grdMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radgrpPUStatusSetting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbtnSupplierPicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRelatedPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRelatedPurchaseOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdMaterialRequirements
        '
        Me.grdMaterialRequirements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdMaterialRequirements.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdMaterialRequirements.Location = New System.Drawing.Point(12, 61)
        Me.grdMaterialRequirements.MainView = Me.gvMaterialRequirements
        Me.grdMaterialRequirements.Name = "grdMaterialRequirements"
        Me.grdMaterialRequirements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.RepositoryItemMemoExEdit2})
        Me.grdMaterialRequirements.Size = New System.Drawing.Size(573, 279)
        Me.grdMaterialRequirements.TabIndex = 108
        Me.grdMaterialRequirements.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterialRequirements})
        '
        'gvMaterialRequirements
        '
        Me.gvMaterialRequirements.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvMaterialRequirements.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvMaterialRequirements.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvMaterialRequirements.Appearance.EvenRow.Options.UseFont = True
        Me.gvMaterialRequirements.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvMaterialRequirements.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMaterialRequirements.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvMaterialRequirements.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvMaterialRequirements.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvMaterialRequirements.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvMaterialRequirements.Appearance.OddRow.Options.UseBackColor = True
        Me.gvMaterialRequirements.Appearance.OddRow.Options.UseFont = True
        Me.gvMaterialRequirements.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvMaterialRequirements.Appearance.Row.Options.UseFont = True
        Me.gvMaterialRequirements.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvMaterialRequirements.Appearance.ViewCaption.Options.UseFont = True
        Me.gvMaterialRequirements.ColumnPanelRowHeight = 37
        Me.gvMaterialRequirements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn28, Me.gcMatReqCategory, Me.GridColumn31, Me.GridColumn47, Me.GridColumn75, Me.GridColumn33, Me.gcComments, Me.GridColumn35, Me.GridColumn36})
        Me.gvMaterialRequirements.GridControl = Me.grdMaterialRequirements
        Me.gvMaterialRequirements.Name = "gvMaterialRequirements"
        Me.gvMaterialRequirements.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvMaterialRequirements.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMaterialRequirements.OptionsView.EnableAppearanceOddRow = True
        Me.gvMaterialRequirements.OptionsView.ShowGroupPanel = False
        Me.gvMaterialRequirements.OptionsView.ShowViewCaption = True
        Me.gvMaterialRequirements.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn31, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvMaterialRequirements.ViewCaption = "Requerimientos de Materiales"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "ID"
        Me.GridColumn28.FieldName = "MaterialRequirementID"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Width = 77
        '
        'gcMatReqCategory
        '
        Me.gcMatReqCategory.Caption = "Category"
        Me.gcMatReqCategory.FieldName = "Category"
        Me.gcMatReqCategory.Name = "gcMatReqCategory"
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Type"
        Me.GridColumn31.FieldName = "ItemTypeSubType"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Width = 155
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "Código"
        Me.GridColumn47.FieldName = "StockCode"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 0
        Me.GridColumn47.Width = 61
        '
        'GridColumn75
        '
        Me.GridColumn75.Caption = "Sage Stock Code"
        Me.GridColumn75.FieldName = "SageCode"
        Me.GridColumn75.Name = "GridColumn75"
        Me.GridColumn75.Width = 55
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Descripción"
        Me.GridColumn33.FieldName = "Description"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 1
        Me.GridColumn33.Width = 163
        '
        'gcComments
        '
        Me.gcComments.Caption = "Comentarios"
        Me.gcComments.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.gcComments.FieldName = "Comments"
        Me.gcComments.Name = "gcComments"
        Me.gcComments.Visible = True
        Me.gcComments.VisibleIndex = 2
        Me.gcComments.Width = 135
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'GridColumn35
        '
        Me.GridColumn35.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn35.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn35.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn35.Caption = "Dims"
        Me.GridColumn35.FieldName = "Dims"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Width = 97
        '
        'GridColumn36
        '
        Me.GridColumn36.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn36.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn36.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn36.Caption = "Cant. Req."
        Me.GridColumn36.DisplayFormat.FormatString = "N"
        Me.GridColumn36.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn36.FieldName = "Quantity"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 3
        Me.GridColumn36.Width = 44
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.NullDate = New Date(CType(0, Long))
        '
        'radgrpPUStatusSetting
        '
        Me.radgrpPUStatusSetting.EditValue = 0
        Me.radgrpPUStatusSetting.Location = New System.Drawing.Point(97, 32)
        Me.radgrpPUStatusSetting.Name = "radgrpPUStatusSetting"
        Me.radgrpPUStatusSetting.Properties.AllowMouseWheel = False
        Me.radgrpPUStatusSetting.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radgrpPUStatusSetting.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radgrpPUStatusSetting.Properties.Appearance.Options.UseFont = True
        Me.radgrpPUStatusSetting.Properties.Appearance.Options.UseForeColor = True
        Me.radgrpPUStatusSetting.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "No Req."), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "De Inventario"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "A Ordenar"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Orden Pedida"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Recibido")})
        Me.radgrpPUStatusSetting.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.radgrpPUStatusSetting.Size = New System.Drawing.Size(488, 25)
        Me.radgrpPUStatusSetting.TabIndex = 107
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(1144, 40)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl21.TabIndex = 105
        Me.LabelControl21.Text = "Última Fecha"
        '
        'txtLastDate
        '
        Me.txtLastDate.Location = New System.Drawing.Point(1219, 37)
        Me.txtLastDate.Name = "txtLastDate"
        Me.txtLastDate.Properties.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.txtLastDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtLastDate.Properties.Appearance.Options.UseFont = True
        Me.txtLastDate.Size = New System.Drawing.Size(94, 20)
        Me.txtLastDate.TabIndex = 106
        '
        'LabelControl22
        '
        Me.LabelControl22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(593, 231)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl22.TabIndex = 104
        Me.LabelControl22.Text = "Notes"
        '
        'grdPOs
        '
        Me.grdPOs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPOs.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdPOs.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdPOs.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdPOs.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdPOs.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdPOs.Location = New System.Drawing.Point(2, 26)
        Me.grdPOs.MainView = Me.gvPOs
        Me.grdPOs.Name = "grdPOs"
        Me.grdPOs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.repbtnSupplierPicker, Me.RepositoryItemMemoExEdit1})
        Me.grdPOs.Size = New System.Drawing.Size(720, 136)
        Me.grdPOs.TabIndex = 103
        Me.grdPOs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOs})
        '
        'gvPOs
        '
        Me.gvPOs.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvPOs.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOs.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPOs.Appearance.EvenRow.Options.UseFont = True
        Me.gvPOs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvPOs.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPOs.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPOs.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPOs.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPOs.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOs.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPOs.Appearance.OddRow.Options.UseFont = True
        Me.gvPOs.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOs.Appearance.Row.Options.UseFont = True
        Me.gvPOs.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPOs.Appearance.ViewCaption.Options.UseFont = True
        Me.gvPOs.ColumnPanelRowHeight = 34
        Me.gvPOs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17, Me.GridColumn2, Me.GridColumn18, Me.GridColumn1, Me.gcStatus, Me.gcCostCategory, Me.GridColumn3, Me.GridColumn4})
        Me.gvPOs.GridControl = Me.grdPOs
        Me.gvPOs.Name = "gvPOs"
        Me.gvPOs.OptionsDetail.EnableMasterViewMode = False
        Me.gvPOs.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPOs.OptionsView.EnableAppearanceOddRow = True
        Me.gvPOs.OptionsView.ShowDetailButtons = False
        Me.gvPOs.OptionsView.ShowGroupPanel = False
        Me.gvPOs.ViewCaption = "Related Purchase Orders"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "# O.C."
        Me.GridColumn16.FieldName = "PONum"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        Me.GridColumn16.Width = 63
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Proveedor"
        Me.GridColumn17.FieldName = "UBSupplierID"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        Me.GridColumn17.Width = 117
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ad Hoc Supplier"
        Me.GridColumn2.FieldName = "AdHocSupplier"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 97
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Fecha Req."
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn18.FieldName = "RequiredDate"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 2
        Me.GridColumn18.Width = 81
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Fecha Compl."
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn1.FieldName = "SubmissionDate"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 92
        '
        'gcStatus
        '
        Me.gcStatus.Caption = "Estado"
        Me.gcStatus.FieldName = "Status"
        Me.gcStatus.Name = "gcStatus"
        Me.gcStatus.Visible = True
        Me.gcStatus.VisibleIndex = 4
        Me.gcStatus.Width = 59
        '
        'gcCostCategory
        '
        Me.gcCostCategory.Caption = "Comentarios"
        Me.gcCostCategory.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.gcCostCategory.FieldName = "Comments"
        Me.gcCostCategory.Name = "gcCostCategory"
        Me.gcCostCategory.Visible = True
        Me.gcCostCategory.VisibleIndex = 5
        Me.gcCostCategory.Width = 74
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Valor Neto"
        Me.GridColumn3.DisplayFormat.FormatString = "n2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "TotalNetValue"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 56
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Remedial"
        Me.GridColumn4.FieldName = "IsRemedial"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 64
        '
        'repbtnSupplierPicker
        '
        Me.repbtnSupplierPicker.AllowMouseWheel = False
        Me.repbtnSupplierPicker.AutoHeight = False
        Me.repbtnSupplierPicker.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repbtnSupplierPicker.Name = "repbtnSupplierPicker"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Location = New System.Drawing.Point(593, 245)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(720, 95)
        Me.txtNotes.TabIndex = 102
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseForeColor = True
        Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitle.Location = New System.Drawing.Point(12, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(737, 23)
        Me.lblTitle.TabIndex = 101
        Me.lblTitle.Text = "Grupo de Req. Mat. para O.T. 1"
        '
        'grpRelatedPurchaseOrders
        '
        Me.grpRelatedPurchaseOrders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpRelatedPurchaseOrders.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRelatedPurchaseOrders.AppearanceCaption.Options.UseFont = True
        Me.grpRelatedPurchaseOrders.Controls.Add(Me.grdPOs)
        Me.grpRelatedPurchaseOrders.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar O.C.", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 3, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Nueva O.C.", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Recibir O.C. Existente", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 2, -1)})
        Me.grpRelatedPurchaseOrders.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpRelatedPurchaseOrders.Location = New System.Drawing.Point(591, 61)
        Me.grpRelatedPurchaseOrders.Name = "grpRelatedPurchaseOrders"
        Me.grpRelatedPurchaseOrders.Size = New System.Drawing.Size(724, 164)
        Me.grpRelatedPurchaseOrders.TabIndex = 109
        Me.grpRelatedPurchaseOrders.Text = "Ordenes de Compras Relacionadas"
        '
        'btnExportMG
        '
        Me.btnExportMG.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnExportMG.Appearance.Options.UseFont = True
        Me.btnExportMG.Location = New System.Drawing.Point(491, 65)
        Me.btnExportMG.Name = "btnExportMG"
        Me.btnExportMG.Size = New System.Drawing.Size(91, 21)
        Me.btnExportMG.TabIndex = 110
        Me.btnExportMG.Text = "Exportar a Excel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 14)
        Me.LabelControl1.TabIndex = 112
        Me.LabelControl1.Text = "Estado de O.C."
        '
        'lblPickStatus
        '
        Me.lblPickStatus.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPickStatus.Appearance.Options.UseFont = True
        Me.lblPickStatus.Appearance.Options.UseForeColor = True
        Me.lblPickStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPickStatus.Location = New System.Drawing.Point(593, 38)
        Me.lblPickStatus.Name = "lblPickStatus"
        Me.lblPickStatus.Size = New System.Drawing.Size(190, 17)
        Me.lblPickStatus.TabIndex = 113
        Me.lblPickStatus.Text = "Estado de Recepción"
        '
        'frmWorkOrderMatReqCategoryStatusDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 348)
        Me.Controls.Add(Me.lblPickStatus)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnExportMG)
        Me.Controls.Add(Me.grpRelatedPurchaseOrders)
        Me.Controls.Add(Me.grdMaterialRequirements)
        Me.Controls.Add(Me.radgrpPUStatusSetting)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.txtLastDate)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkOrderMatReqCategoryStatusDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimientos de Materiales"
        CType(Me.grdMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radgrpPUStatusSetting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbtnSupplierPicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRelatedPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRelatedPurchaseOrders.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdMaterialRequirements As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMaterialRequirements As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents radgrpPUStatusSetting As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtLastDate As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents grdPOs As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvPOs As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents gcStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
  Friend WithEvents grpRelatedPurchaseOrders As DevExpress.XtraEditors.GroupControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMatReqCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn75 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcComments As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repbtnSupplierPicker As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents btnExportMG As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents lblPickStatus As DevExpress.XtraEditors.LabelControl
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCostCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
