<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockItemInfo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.grpItemDetail = New DevExpress.XtraEditors.GroupControl()
        Me.popupMaterialRequirement = New DevExpress.XtraEditors.PopupContainerControl()
        Me.grdStockItemAllocations = New DevExpress.XtraGrid.GridControl()
        Me.gvStockItemAllocations = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.popupAllocated = New DevExpress.XtraEditors.PopupContainerControl()
        Me.grdPOItemInfo = New DevExpress.XtraGrid.GridControl()
        Me.gvPOItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcProdStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repProdStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdStockItemInfos = New DevExpress.XtraGrid.GridControl()
        Me.gvStockItemInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcStockItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repitbtCurrentInventory = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopuMaterialRequirement = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopupPOAllocationItems = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItemDetail.SuspendLayout()
        CType(Me.popupMaterialRequirement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupMaterialRequirement.SuspendLayout()
        CType(Me.grdStockItemAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStockItemAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupAllocated.SuspendLayout()
        CType(Me.grdPOItemInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repProdStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repProdStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStockItemInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStockItemInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repitbtCurrentInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopuMaterialRequirement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupPOAllocationItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grpItemDetail.Controls.Add(Me.popupMaterialRequirement)
        Me.grpItemDetail.Controls.Add(Me.popupAllocated)
        Me.grpItemDetail.Controls.Add(Me.grdStockItemInfos)
        Me.grpItemDetail.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Exportar a Excel", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Export", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Recargar Inv.", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Reload", -1)})
        Me.grpItemDetail.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpItemDetail.Location = New System.Drawing.Point(3, 12)
        Me.grpItemDetail.Name = "grpItemDetail"
        Me.grpItemDetail.Size = New System.Drawing.Size(1362, 709)
        Me.grpItemDetail.TabIndex = 95
        Me.grpItemDetail.Text = "Stock Items"
        '
        'popupMaterialRequirement
        '
        Me.popupMaterialRequirement.Controls.Add(Me.grdStockItemAllocations)
        Me.popupMaterialRequirement.Location = New System.Drawing.Point(425, 342)
        Me.popupMaterialRequirement.Name = "popupMaterialRequirement"
        Me.popupMaterialRequirement.Size = New System.Drawing.Size(583, 139)
        Me.popupMaterialRequirement.TabIndex = 9
        '
        'grdStockItemAllocations
        '
        Me.grdStockItemAllocations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdStockItemAllocations.Location = New System.Drawing.Point(0, 0)
        Me.grdStockItemAllocations.MainView = Me.gvStockItemAllocations
        Me.grdStockItemAllocations.Name = "grdStockItemAllocations"
        Me.grdStockItemAllocations.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdStockItemAllocations.Size = New System.Drawing.Size(583, 139)
        Me.grdStockItemAllocations.TabIndex = 1
        Me.grdStockItemAllocations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItemAllocations})
        '
        'gvStockItemAllocations
        '
        Me.gvStockItemAllocations.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvStockItemAllocations.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemAllocations.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvStockItemAllocations.Appearance.EvenRow.Options.UseFont = True
        Me.gvStockItemAllocations.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStockItemAllocations.Appearance.GroupPanel.Options.UseFont = True
        Me.gvStockItemAllocations.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.gvStockItemAllocations.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvStockItemAllocations.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStockItemAllocations.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvStockItemAllocations.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvStockItemAllocations.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemAllocations.Appearance.OddRow.Options.UseBackColor = True
        Me.gvStockItemAllocations.Appearance.OddRow.Options.UseFont = True
        Me.gvStockItemAllocations.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemAllocations.Appearance.Row.Options.UseFont = True
        Me.gvStockItemAllocations.Appearance.Row.Options.UseTextOptions = True
        Me.gvStockItemAllocations.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvStockItemAllocations.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemAllocations.Appearance.ViewCaption.Options.UseFont = True
        Me.gvStockItemAllocations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.gvStockItemAllocations.DetailHeight = 200
        Me.gvStockItemAllocations.GridControl = Me.grdStockItemAllocations
        Me.gvStockItemAllocations.Name = "gvStockItemAllocations"
        Me.gvStockItemAllocations.OptionsBehavior.ReadOnly = True
        Me.gvStockItemAllocations.OptionsView.EnableAppearanceEvenRow = True
        Me.gvStockItemAllocations.OptionsView.EnableAppearanceOddRow = True
        Me.gvStockItemAllocations.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "# OT"
        Me.GridColumn13.FieldName = "WorkOrderNo"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 72
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Fecha Entrega"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn14.DisplayFormat.FormatString = "d"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn14.FieldName = "PlannedDeliverDate"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        Me.GridColumn14.Width = 89
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(2020, 3, 11, 18, 39, 42, 987)
        Me.RepositoryItemDateEdit1.NullText = "''"
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.Caption = "Cant. Pend."
        Me.GridColumn15.DisplayFormat.FormatString = "#,###.#"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "OSQty"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 5
        Me.GridColumn15.Width = 74
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Cliente"
        Me.GridColumn16.FieldName = "CompanyName"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 1
        Me.GridColumn16.Width = 132
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Fecha  Prod."
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn17.FieldName = "PlannedStartDate"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 4
        Me.GridColumn17.Width = 76
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Proyecto"
        Me.GridColumn18.FieldName = "ProjectName"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 2
        Me.GridColumn18.Width = 122
        '
        'popupAllocated
        '
        Me.popupAllocated.Controls.Add(Me.grdPOItemInfo)
        Me.popupAllocated.Location = New System.Drawing.Point(425, 173)
        Me.popupAllocated.Name = "popupAllocated"
        Me.popupAllocated.Size = New System.Drawing.Size(598, 163)
        Me.popupAllocated.TabIndex = 8
        '
        'grdPOItemInfo
        '
        Me.grdPOItemInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPOItemInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPOItemInfo.MainView = Me.gvPOItem
        Me.grdPOItemInfo.Name = "grdPOItemInfo"
        Me.grdPOItemInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repProdStartDate})
        Me.grdPOItemInfo.Size = New System.Drawing.Size(598, 163)
        Me.grdPOItemInfo.TabIndex = 1
        Me.grdPOItemInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOItem})
        '
        'gvPOItem
        '
        Me.gvPOItem.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvPOItem.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOItem.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPOItem.Appearance.EvenRow.Options.UseFont = True
        Me.gvPOItem.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPOItem.Appearance.GroupPanel.Options.UseFont = True
        Me.gvPOItem.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.gvPOItem.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPOItem.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPOItem.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPOItem.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPOItem.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOItem.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPOItem.Appearance.OddRow.Options.UseFont = True
        Me.gvPOItem.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOItem.Appearance.Row.Options.UseFont = True
        Me.gvPOItem.Appearance.Row.Options.UseTextOptions = True
        Me.gvPOItem.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPOItem.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOItem.Appearance.ViewCaption.Options.UseFont = True
        Me.gvPOItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.gcProdStartDate, Me.GridColumn4, Me.GridColumn7, Me.GridColumn19, Me.GridColumn20})
        Me.gvPOItem.DetailHeight = 200
        Me.gvPOItem.GridControl = Me.grdPOItemInfo
        Me.gvPOItem.Name = "gvPOItem"
        Me.gvPOItem.OptionsBehavior.ReadOnly = True
        Me.gvPOItem.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPOItem.OptionsView.EnableAppearanceOddRow = True
        Me.gvPOItem.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "# O.C. "
        Me.GridColumn3.FieldName = "PONum"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 90
        '
        'gcProdStartDate
        '
        Me.gcProdStartDate.Caption = "ETA"
        Me.gcProdStartDate.ColumnEdit = Me.repProdStartDate
        Me.gcProdStartDate.DisplayFormat.FormatString = "d"
        Me.gcProdStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcProdStartDate.FieldName = "RequiredDate"
        Me.gcProdStartDate.Name = "gcProdStartDate"
        Me.gcProdStartDate.OptionsColumn.ReadOnly = True
        Me.gcProdStartDate.Visible = True
        Me.gcProdStartDate.VisibleIndex = 2
        Me.gcProdStartDate.Width = 72
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
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Cant. Req."
        Me.GridColumn4.DisplayFormat.FormatString = "#,###.#"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Quantity"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 76
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Proyecto"
        Me.GridColumn7.FieldName = "ProjectName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 161
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn19.Caption = "Cant. Recibida"
        Me.GridColumn19.DisplayFormat.FormatString = "#,###.#"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "ReceivedQty"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 4
        Me.GridColumn19.Width = 95
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Cant. Pend"
        Me.GridColumn20.DisplayFormat.FormatString = "#,###.#"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "OutStandingQty"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 5
        '
        'grdStockItemInfos
        '
        Me.grdStockItemInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdStockItemInfos.Location = New System.Drawing.Point(2, 26)
        Me.grdStockItemInfos.MainView = Me.gvStockItemInfos
        Me.grdStockItemInfos.Name = "grdStockItemInfos"
        Me.grdStockItemInfos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitbtCurrentInventory, Me.repoPopupPOAllocationItems, Me.repoPopuMaterialRequirement})
        Me.grdStockItemInfos.Size = New System.Drawing.Size(1358, 681)
        Me.grdStockItemInfos.TabIndex = 6
        Me.grdStockItemInfos.UseEmbeddedNavigator = True
        Me.grdStockItemInfos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItemInfos})
        '
        'gvStockItemInfos
        '
        Me.gvStockItemInfos.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvStockItemInfos.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemInfos.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvStockItemInfos.Appearance.EvenRow.Options.UseFont = True
        Me.gvStockItemInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStockItemInfos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvStockItemInfos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvStockItemInfos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvStockItemInfos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvStockItemInfos.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemInfos.Appearance.OddRow.Options.UseBackColor = True
        Me.gvStockItemInfos.Appearance.OddRow.Options.UseFont = True
        Me.gvStockItemInfos.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemInfos.Appearance.Row.Options.UseFont = True
        Me.gvStockItemInfos.ColumnPanelRowHeight = 34
        Me.gvStockItemInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcStockItemID, Me.GridColumn8, Me.GridColumn1, Me.GridColumn6, Me.gcCategory, Me.gcItemType, Me.GridColumn5, Me.gcSupplier, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.gcStdCost, Me.GridColumn2})
        Me.gvStockItemInfos.CustomizationFormBounds = New System.Drawing.Rectangle(1156, 318, 210, 270)
        Me.gvStockItemInfos.GridControl = Me.grdStockItemInfos
        Me.gvStockItemInfos.Name = "gvStockItemInfos"
        Me.gvStockItemInfos.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvStockItemInfos.OptionsView.EnableAppearanceEvenRow = True
        Me.gvStockItemInfos.OptionsView.EnableAppearanceOddRow = True
        Me.gvStockItemInfos.OptionsView.ShowAutoFilterRow = True
        Me.gvStockItemInfos.OptionsView.ShowDetailButtons = False
        Me.gvStockItemInfos.OptionsView.ShowFooter = True
        Me.gvStockItemInfos.OptionsView.ShowGroupPanel = False
        '
        'gcStockItemID
        '
        Me.gcStockItemID.Caption = "StockItemID"
        Me.gcStockItemID.FieldName = "StockItemId"
        Me.gcStockItemID.Name = "gcStockItemID"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Código ASIS"
        Me.GridColumn8.FieldName = "ASISID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 59
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "StockCode"
        Me.GridColumn1.FieldName = "StockCode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 72
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripción"
        Me.GridColumn6.FieldName = "Description"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 254
        '
        'gcCategory
        '
        Me.gcCategory.Caption = "Categoría"
        Me.gcCategory.FieldName = "Category"
        Me.gcCategory.Name = "gcCategory"
        Me.gcCategory.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.gcCategory.Visible = True
        Me.gcCategory.VisibleIndex = 2
        Me.gcCategory.Width = 115
        '
        'gcItemType
        '
        Me.gcItemType.Caption = "Sub Categoría"
        Me.gcItemType.FieldName = "gc"
        Me.gcItemType.Name = "gcItemType"
        Me.gcItemType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcItemType.Visible = True
        Me.gcItemType.VisibleIndex = 3
        Me.gcItemType.Width = 115
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Núm. Parte"
        Me.GridColumn5.FieldName = "PartNo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 90
        '
        'gcSupplier
        '
        Me.gcSupplier.Caption = "Proveedor"
        Me.gcSupplier.FieldName = "DefaultSupplier"
        Me.gcSupplier.Name = "gcSupplier"
        Me.gcSupplier.Visible = True
        Me.gcSupplier.VisibleIndex = 7
        Me.gcSupplier.Width = 128
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn9.Caption = "Inv. Actual"
        Me.GridColumn9.ColumnEdit = Me.repitbtCurrentInventory
        Me.GridColumn9.DisplayFormat.FormatString = "N2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "CurrentInventory"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'repitbtCurrentInventory
        '
        Me.repitbtCurrentInventory.AutoHeight = False
        Me.repitbtCurrentInventory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repitbtCurrentInventory.Name = "repitbtCurrentInventory"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn10.Caption = "Inv. Req"
        Me.GridColumn10.ColumnEdit = Me.repoPopuMaterialRequirement
        Me.GridColumn10.DisplayFormat.FormatString = "N2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "RequiredInventory"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'repoPopuMaterialRequirement
        '
        Me.repoPopuMaterialRequirement.AutoHeight = False
        Me.repoPopuMaterialRequirement.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopuMaterialRequirement.Name = "repoPopuMaterialRequirement"
        Me.repoPopuMaterialRequirement.PopupControl = Me.popupMaterialRequirement
        Me.repoPopuMaterialRequirement.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn11.Caption = "Cant. Pedidas"
        Me.GridColumn11.ColumnEdit = Me.repoPopupPOAllocationItems
        Me.GridColumn11.DisplayFormat.FormatString = "N2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "OrderQty"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'repoPopupPOAllocationItems
        '
        Me.repoPopupPOAllocationItems.AutoHeight = False
        Me.repoPopupPOAllocationItems.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopupPOAllocationItems.Name = "repoPopupPOAllocationItems"
        Me.repoPopupPOAllocationItems.PopupControl = Me.popupAllocated
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Inv. Final"
        Me.GridColumn12.DisplayFormat.FormatString = "N2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Balance"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 81
        '
        'gcStdCost
        '
        Me.gcStdCost.Caption = "Costo Unitario"
        Me.gcStdCost.DisplayFormat.FormatString = "C$#,##0.00;;#"
        Me.gcStdCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcStdCost.FieldName = "StdCost"
        Me.gcStdCost.Name = "gcStdCost"
        Me.gcStdCost.Visible = True
        Me.gcStdCost.VisibleIndex = 6
        Me.gcStdCost.Width = 82
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Valor Actual"
        Me.GridColumn2.DisplayFormat.FormatString = "C$#,##0.00;;#"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "ActualValueInventory"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ActualValueInventory", "{0:C$#,##0.00;;#}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 12
        Me.GridColumn2.Width = 120
        '
        'frmStockItemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 733)
        Me.Controls.Add(Me.grpItemDetail)
        Me.Name = "frmStockItemInfo"
        Me.Text = "Información de Inventario"
        CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItemDetail.ResumeLayout(False)
        CType(Me.popupMaterialRequirement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupMaterialRequirement.ResumeLayout(False)
        CType(Me.grdStockItemAllocations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStockItemAllocations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupAllocated.ResumeLayout(False)
        CType(Me.grdPOItemInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repProdStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repProdStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStockItemInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStockItemInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repitbtCurrentInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopuMaterialRequirement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupPOAllocationItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpItemDetail As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdStockItemInfos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStockItemInfos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStockItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcItemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repitbtCurrentInventory As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents gcStdCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popupAllocated As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents grdPOItemInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPOItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcProdStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repProdStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoPopupPOAllocationItems As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents popupMaterialRequirement As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents grdStockItemAllocations As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStockItemAllocations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoPopuMaterialRequirement As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
End Class
