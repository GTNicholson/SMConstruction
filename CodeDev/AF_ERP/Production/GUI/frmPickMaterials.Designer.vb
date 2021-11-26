<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickMaterials
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickMaterials))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnLoadMatReq = New DevExpress.XtraEditors.SimpleButton()
        Me.cboArea = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPlannedDate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWOQty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSelectOT = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtWODescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompanyName = New DevExpress.XtraEditors.TextEdit()
        Me.grpMaterialRequirements = New DevExpress.XtraEditors.GroupControl()
        Me.grdMaterialRequirementInfo = New DevExpress.XtraGrid.GridControl()
        Me.gvMaterialRequirementInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.StockCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoFormatNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAreaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMaterialRequirementID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.txtFinishDate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReference = New DevExpress.XtraEditors.TextEdit()
        Me.btnPrintRequisa = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRequisas = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlannedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWOQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWODescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaterialRequirements.SuspendLayout()
        CType(Me.grdMaterialRequirementInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoFormatNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinishDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cboRequisas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.btnLoadMatReq)
        Me.GroupControl1.Controls.Add(Me.cboArea)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtPlannedDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtWOQty)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnSelectOT)
        Me.GroupControl1.Controls.Add(Me.txtWODescription)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(576, 128)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos Generales de Orden de Trabajo"
        '
        'btnLoadMatReq
        '
        Me.btnLoadMatReq.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLoadMatReq.Appearance.Options.UseFont = True
        Me.btnLoadMatReq.Location = New System.Drawing.Point(353, 34)
        Me.btnLoadMatReq.Name = "btnLoadMatReq"
        Me.btnLoadMatReq.Size = New System.Drawing.Size(87, 23)
        Me.btnLoadMatReq.TabIndex = 14
        Me.btnLoadMatReq.Text = "Cargar Datos"
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(227, 35)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboArea.Properties.Appearance.Options.UseFont = True
        Me.cboArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboArea.Size = New System.Drawing.Size(120, 20)
        Me.cboArea.TabIndex = 13
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(191, 37)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl9.TabIndex = 12
        Me.LabelControl9.Text = "Área"
        '
        'txtPlannedDate
        '
        Me.txtPlannedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlannedDate.Location = New System.Drawing.Point(497, 76)
        Me.txtPlannedDate.Name = "txtPlannedDate"
        Me.txtPlannedDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPlannedDate.Properties.Appearance.Options.UseFont = True
        Me.txtPlannedDate.Properties.ReadOnly = True
        Me.txtPlannedDate.Size = New System.Drawing.Size(74, 20)
        Me.txtPlannedDate.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(446, 78)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "F. Plan"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(347, 78)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Cant."
        '
        'txtWOQty
        '
        Me.txtWOQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWOQty.Location = New System.Drawing.Point(386, 76)
        Me.txtWOQty.Name = "txtWOQty"
        Me.txtWOQty.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtWOQty.Properties.Appearance.Options.UseFont = True
        Me.txtWOQty.Properties.ReadOnly = True
        Me.txtWOQty.Size = New System.Drawing.Size(54, 20)
        Me.txtWOQty.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(8, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Descripción"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "# OT"
        '
        'btnSelectOT
        '
        Me.btnSelectOT.Location = New System.Drawing.Point(43, 34)
        Me.btnSelectOT.Name = "btnSelectOT"
        Me.btnSelectOT.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnSelectOT.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnSelectOT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnSelectOT.Size = New System.Drawing.Size(142, 22)
        Me.btnSelectOT.TabIndex = 0
        '
        'txtWODescription
        '
        Me.txtWODescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWODescription.Location = New System.Drawing.Point(88, 76)
        Me.txtWODescription.Name = "txtWODescription"
        Me.txtWODescription.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtWODescription.Properties.Appearance.Options.UseFont = True
        Me.txtWODescription.Properties.ReadOnly = True
        Me.txtWODescription.Size = New System.Drawing.Size(253, 20)
        Me.txtWODescription.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(193, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Cliente"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(244, 35)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCompanyName.Properties.Appearance.Options.UseFont = True
        Me.txtCompanyName.Properties.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(246, 20)
        Me.txtCompanyName.TabIndex = 2
        '
        'grpMaterialRequirements
        '
        Me.grpMaterialRequirements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMaterialRequirements.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMaterialRequirements.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpMaterialRequirements.AppearanceCaption.Options.UseFont = True
        Me.grpMaterialRequirements.AppearanceCaption.Options.UseForeColor = True
        Me.grpMaterialRequirements.Controls.Add(Me.grdMaterialRequirementInfo)
        Me.grpMaterialRequirements.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Articulos", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 2, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Despachar a Producción", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Devolver de Producción", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 4, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Exportar", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 3, -1)})
        Me.grpMaterialRequirements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpMaterialRequirements.Location = New System.Drawing.Point(2, 142)
        Me.grpMaterialRequirements.Name = "grpMaterialRequirements"
        Me.grpMaterialRequirements.Size = New System.Drawing.Size(1459, 424)
        Me.grpMaterialRequirements.TabIndex = 1
        Me.grpMaterialRequirements.Text = "Materiales"
        '
        'grdMaterialRequirementInfo
        '
        Me.grdMaterialRequirementInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMaterialRequirementInfo.Location = New System.Drawing.Point(2, 26)
        Me.grdMaterialRequirementInfo.MainView = Me.gvMaterialRequirementInfos
        Me.grdMaterialRequirementInfo.Name = "grdMaterialRequirementInfo"
        Me.grdMaterialRequirementInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoExEdit1, Me.repoFormatNumber})
        Me.grdMaterialRequirementInfo.Size = New System.Drawing.Size(1455, 396)
        Me.grdMaterialRequirementInfo.TabIndex = 0
        Me.grdMaterialRequirementInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterialRequirementInfos})
        '
        'gvMaterialRequirementInfos
        '
        Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
        Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMaterialRequirementInfos.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.gvMaterialRequirementInfos.Appearance.Row.Options.UseFont = True
        Me.gvMaterialRequirementInfos.ColumnPanelRowHeight = 38
        Me.gvMaterialRequirementInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.StockCode, Me.gcCategory, Me.GridColumn2, Me.GridColumn8, Me.GridColumn6, Me.GridColumn7, Me.gcAreaID, Me.GridColumn4, Me.GridColumn9, Me.GridColumn5, Me.gcMaterialRequirementID, Me.gcStdCost, Me.gcTotalAmount, Me.GridColumn1, Me.GridColumn3, Me.GridColumn10})
        Me.gvMaterialRequirementInfos.GridControl = Me.grdMaterialRequirementInfo
        Me.gvMaterialRequirementInfos.GroupCount = 1
        Me.gvMaterialRequirementInfos.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", Me.gcTotalAmount, "{0:C$#,##0.00;;#}")})
        Me.gvMaterialRequirementInfos.Name = "gvMaterialRequirementInfos"
        Me.gvMaterialRequirementInfos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gvMaterialRequirementInfos.OptionsView.ShowAutoFilterRow = True
        Me.gvMaterialRequirementInfos.OptionsView.ShowFooter = True
        Me.gvMaterialRequirementInfos.OptionsView.ShowGroupPanel = False
        Me.gvMaterialRequirementInfos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcAreaID, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'StockCode
        '
        Me.StockCode.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.StockCode.AppearanceCell.Options.UseBackColor = True
        Me.StockCode.AppearanceHeader.Options.UseTextOptions = True
        Me.StockCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.StockCode.Caption = "Código"
        Me.StockCode.FieldName = "StockCode"
        Me.StockCode.Name = "StockCode"
        Me.StockCode.OptionsColumn.ReadOnly = True
        Me.StockCode.Visible = True
        Me.StockCode.VisibleIndex = 0
        Me.StockCode.Width = 83
        '
        'gcCategory
        '
        Me.gcCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcCategory.AppearanceCell.Options.UseBackColor = True
        Me.gcCategory.AppearanceHeader.Options.UseTextOptions = True
        Me.gcCategory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcCategory.Caption = "Categoria"
        Me.gcCategory.FieldName = "Category"
        Me.gcCategory.Name = "gcCategory"
        Me.gcCategory.OptionsColumn.ReadOnly = True
        Me.gcCategory.Visible = True
        Me.gcCategory.VisibleIndex = 2
        Me.gcCategory.Width = 77
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 372
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn8.Caption = "UoM"
        Me.GridColumn8.FieldName = "UoMDescUI"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 61
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn6.Caption = "Cant. Req."
        Me.GridColumn6.ColumnEdit = Me.repoFormatNumber
        Me.GridColumn6.DisplayFormat.FormatString = "###.000"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Quantity"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 93
        '
        'repoFormatNumber
        '
        Me.repoFormatNumber.AutoHeight = False
        Me.repoFormatNumber.EditFormat.FormatString = "N3"
        Me.repoFormatNumber.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoFormatNumber.Name = "repoFormatNumber"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn7.Caption = "Cant. Despachada"
        Me.GridColumn7.ColumnEdit = Me.repoFormatNumber
        Me.GridColumn7.DisplayFormat.FormatString = "###.000"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "PickedQty"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 105
        '
        'gcAreaID
        '
        Me.gcAreaID.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcAreaID.AppearanceCell.Options.UseBackColor = True
        Me.gcAreaID.Caption = "Área"
        Me.gcAreaID.FieldName = "AreaID"
        Me.gcAreaID.Name = "gcAreaID"
        Me.gcAreaID.OptionsColumn.ReadOnly = True
        Me.gcAreaID.Visible = True
        Me.gcAreaID.VisibleIndex = 4
        Me.gcAreaID.Width = 105
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn4.Caption = "Núm. Parte"
        Me.GridColumn4.FieldName = "PartNo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn9.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn9.Caption = "Cant. Pendiente"
        Me.GridColumn9.ColumnEdit = Me.repoFormatNumber
        Me.GridColumn9.DisplayFormat.FormatString = "###.000"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "QtyOS"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 11
        Me.GridColumn9.Width = 94
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.Caption = "A Procesar"
        Me.GridColumn5.DisplayFormat.FormatString = "###.000"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "ToProcessQty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 12
        Me.GridColumn5.Width = 114
        '
        'gcMaterialRequirementID
        '
        Me.gcMaterialRequirementID.Caption = "MaterialRequirementID"
        Me.gcMaterialRequirementID.FieldName = "MaterialRequirementID"
        Me.gcMaterialRequirementID.Name = "gcMaterialRequirementID"
        '
        'gcStdCost
        '
        Me.gcStdCost.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcStdCost.AppearanceCell.Options.UseBackColor = True
        Me.gcStdCost.AppearanceCell.Options.UseTextOptions = True
        Me.gcStdCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcStdCost.AppearanceHeader.Options.UseTextOptions = True
        Me.gcStdCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcStdCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcStdCost.Caption = "Costo Unit"
        Me.gcStdCost.ColumnEdit = Me.repoFormatNumber
        Me.gcStdCost.DisplayFormat.FormatString = "C$#,##0.00;;#"
        Me.gcStdCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcStdCost.FieldName = "AverageCost"
        Me.gcStdCost.Name = "gcStdCost"
        Me.gcStdCost.Visible = True
        Me.gcStdCost.VisibleIndex = 5
        Me.gcStdCost.Width = 82
        '
        'gcTotalAmount
        '
        Me.gcTotalAmount.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcTotalAmount.AppearanceCell.Options.UseBackColor = True
        Me.gcTotalAmount.AppearanceCell.Options.UseTextOptions = True
        Me.gcTotalAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcTotalAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.gcTotalAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcTotalAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcTotalAmount.Caption = "Valor Total Espec."
        Me.gcTotalAmount.ColumnEdit = Me.repoFormatNumber
        Me.gcTotalAmount.DisplayFormat.FormatString = "C$#,##0.00;;#"
        Me.gcTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcTotalAmount.FieldName = "TotalAmount"
        Me.gcTotalAmount.Name = "gcTotalAmount"
        Me.gcTotalAmount.OptionsColumn.ReadOnly = True
        Me.gcTotalAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "{0:C$#,##0.00;;#}")})
        Me.gcTotalAmount.Visible = True
        Me.gcTotalAmount.VisibleIndex = 13
        Me.gcTotalAmount.Width = 143
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.Caption = "Comentarios"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn1.FieldName = "Comments"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 96
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn3.Caption = "De Inventario"
        Me.GridColumn3.ColumnEdit = Me.repoFormatNumber
        Me.GridColumn3.DisplayFormat.FormatString = "###.000"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "FromStockQty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 10
        Me.GridColumn3.Width = 86
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn10.Caption = "Cant. Devolución"
        Me.GridColumn10.ColumnEdit = Me.repoFormatNumber
        Me.GridColumn10.DisplayFormat.FormatString = "###.000"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "ReturnQty"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 84
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'txtFinishDate
        '
        Me.txtFinishDate.Location = New System.Drawing.Point(396, 76)
        Me.txtFinishDate.Name = "txtFinishDate"
        Me.txtFinishDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtFinishDate.Properties.Appearance.Options.UseFont = True
        Me.txtFinishDate.Properties.ReadOnly = True
        Me.txtFinishDate.Size = New System.Drawing.Size(94, 20)
        Me.txtFinishDate.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(312, 78)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "F. Requerida"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(6, 77)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Proyecto"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(77, 76)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProjectName.Properties.Appearance.Options.UseFont = True
        Me.txtProjectName.Properties.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(229, 20)
        Me.txtProjectName.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(6, 37)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "# Proforma"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(82, 35)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtReference.Properties.Appearance.Options.UseFont = True
        Me.txtReference.Properties.ReadOnly = True
        Me.txtReference.Size = New System.Drawing.Size(100, 20)
        Me.txtReference.TabIndex = 4
        '
        'btnPrintRequisa
        '
        Me.btnPrintRequisa.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrintRequisa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnPrintRequisa.Appearance.Options.UseFont = True
        Me.btnPrintRequisa.Appearance.Options.UseForeColor = True
        Me.btnPrintRequisa.Location = New System.Drawing.Point(280, 25)
        Me.btnPrintRequisa.Name = "btnPrintRequisa"
        Me.btnPrintRequisa.Size = New System.Drawing.Size(73, 23)
        Me.btnPrintRequisa.TabIndex = 8
        Me.btnPrintRequisa.Text = "Imprimir"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.cboRequisas)
        Me.GroupControl2.Controls.Add(Me.btnPrintRequisa)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(1094, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(358, 128)
        Me.GroupControl2.TabIndex = 9
        Me.GroupControl2.Text = "Impresión de Requisas"
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl4.Controls.Add(Me.LabelControl12)
        Me.GroupControl4.Controls.Add(Me.LabelControl13)
        Me.GroupControl4.Location = New System.Drawing.Point(8, 56)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(345, 68)
        Me.GroupControl4.TabIndex = 16
        Me.GroupControl4.Text = "LEYENDA"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseBackColor = True
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseTextOptions = True
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl12.Location = New System.Drawing.Point(36, 23)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl12.TabIndex = 6
        Me.LabelControl12.Text = "Despachado"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.BackColor = System.Drawing.Color.LightGreen
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseBackColor = True
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseTextOptions = True
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl13.Location = New System.Drawing.Point(140, 23)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl13.TabIndex = 5
        Me.LabelControl13.Text = "A Despachar"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(17, 29)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(111, 16)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = "Lista de Requisas"
        '
        'cboRequisas
        '
        Me.cboRequisas.Location = New System.Drawing.Point(134, 27)
        Me.cboRequisas.Name = "cboRequisas"
        Me.cboRequisas.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboRequisas.Properties.Appearance.Options.UseFont = True
        Me.cboRequisas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRequisas.Size = New System.Drawing.Size(140, 20)
        Me.cboRequisas.TabIndex = 14
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1455, 134)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.txtFinishDate)
        Me.GroupControl3.Controls.Add(Me.txtReference)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.txtProjectName)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.txtCompanyName)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(585, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(503, 128)
        Me.GroupControl3.TabIndex = 11
        Me.GroupControl3.Text = "Impresión de Requisas"
        '
        'frmPickMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1473, 578)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grpMaterialRequirements)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPickMaterials"
        Me.Text = "Salida de Materiales"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlannedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWOQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWODescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaterialRequirements.ResumeLayout(False)
        CType(Me.grdMaterialRequirementInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoFormatNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinishDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.cboRequisas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnSelectOT As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents grpMaterialRequirements As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdMaterialRequirementInfo As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMaterialRequirementInfos As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCompanyName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents gcAreaID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtPlannedDate As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWOQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWODescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinishDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StockCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMaterialRequirementID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStdCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTotalAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoFormatNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrintRequisa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadMatReq As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboArea As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRequisas As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
End Class
