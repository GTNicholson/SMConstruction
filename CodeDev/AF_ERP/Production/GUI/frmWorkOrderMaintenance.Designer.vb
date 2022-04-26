<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrderMaintenance
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkOrderMaintenance))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpMaintenanceItems = New DevExpress.XtraEditors.GroupControl()
        Me.grdMaitenanceItems = New DevExpress.XtraGrid.GridControl()
        Me.gvMaintenanceItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repbtnSubstituteMatReq = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.gcMatReqOtherDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStockItemUoM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcAreaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDuplicateSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoDuplicateSI = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoChkSelectedSI = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDuration = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnMaintenanceWorkOrderDocument = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEquipmentID = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboWorkCentreID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPriority = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtePlannedDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEmployeeID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMaintenanceType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.btnMaintOrderNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bbtnEditProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnCreateCopy = New DevExpress.XtraBars.BarButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.grpMaintenanceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaintenanceItems.SuspendLayout()
        CType(Me.grdMaitenanceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMaintenanceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbtnSubstituteMatReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDuplicateSI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoChkSelectedSI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDuration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaintenanceWorkOrderDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEquipmentID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboWorkCentreID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePlannedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePlannedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmployeeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaintenanceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaintOrderNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpMaintenanceItems)
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1353, 616)
        Me.Panel1.TabIndex = 0
        '
        'grpMaintenanceItems
        '
        Me.grpMaintenanceItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMaintenanceItems.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.grpMaintenanceItems.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpMaintenanceItems.AppearanceCaption.Options.UseFont = True
        Me.grpMaintenanceItems.AppearanceCaption.Options.UseForeColor = True
        Me.grpMaintenanceItems.Controls.Add(Me.grdMaitenanceItems)
        Me.grpMaintenanceItems.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Item", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "AddItems", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar Item", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "DeleteItems", -1)})
        Me.grpMaintenanceItems.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpMaintenanceItems.Location = New System.Drawing.Point(3, 196)
        Me.grpMaintenanceItems.Name = "grpMaintenanceItems"
        Me.grpMaintenanceItems.Size = New System.Drawing.Size(1347, 417)
        Me.grpMaintenanceItems.TabIndex = 4
        Me.grpMaintenanceItems.Text = "Insumos Estimados"
        '
        'grdMaitenanceItems
        '
        Me.grdMaitenanceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMaitenanceItems.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdMaitenanceItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdMaitenanceItems.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdMaitenanceItems.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdMaitenanceItems.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdMaitenanceItems.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdMaitenanceItems.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.grdMaitenanceItems.Location = New System.Drawing.Point(2, 24)
        Me.grdMaitenanceItems.MainView = Me.gvMaintenanceItems
        Me.grdMaitenanceItems.Name = "grdMaitenanceItems"
        Me.grdMaitenanceItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbtnSubstituteMatReq, Me.RepositoryItemSpinEdit3, Me.repoChkSelectedSI, Me.repoDuplicateSI})
        Me.grdMaitenanceItems.Size = New System.Drawing.Size(1343, 391)
        Me.grdMaitenanceItems.TabIndex = 1
        Me.grdMaitenanceItems.UseEmbeddedNavigator = True
        Me.grdMaitenanceItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaintenanceItems})
        '
        'gvMaintenanceItems
        '
        Me.gvMaintenanceItems.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvMaintenanceItems.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvMaintenanceItems.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvMaintenanceItems.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMaintenanceItems.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvMaintenanceItems.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvMaintenanceItems.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvMaintenanceItems.Appearance.OddRow.Options.UseBackColor = True
        Me.gvMaintenanceItems.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvMaintenanceItems.Appearance.Row.Options.UseFont = True
        Me.gvMaintenanceItems.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvMaintenanceItems.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
        Me.gvMaintenanceItems.Appearance.ViewCaption.Options.UseFont = True
        Me.gvMaintenanceItems.Appearance.ViewCaption.Options.UseForeColor = True
        Me.gvMaintenanceItems.ColumnPanelRowHeight = 35
        Me.gvMaintenanceItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcStockCode, Me.gcMatReqOtherDescription, Me.gcStockItemUoM, Me.GridColumn18, Me.gcAreaID, Me.gcDuplicateSI, Me.GridColumn15, Me.GridColumn10, Me.GridColumn1, Me.GridColumn2})
        Me.gvMaintenanceItems.GridControl = Me.grdMaitenanceItems
        Me.gvMaintenanceItems.Name = "gvMaintenanceItems"
        Me.gvMaintenanceItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvMaintenanceItems.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMaintenanceItems.OptionsView.EnableAppearanceOddRow = True
        Me.gvMaintenanceItems.OptionsView.ShowGroupPanel = False
        Me.gvMaintenanceItems.ViewCaption = "Lista de Materiales Requeridos (LMR)"
        '
        'gcStockCode
        '
        Me.gcStockCode.Caption = "Código Interno"
        Me.gcStockCode.ColumnEdit = Me.repbtnSubstituteMatReq
        Me.gcStockCode.FieldName = "StockCode"
        Me.gcStockCode.Name = "gcStockCode"
        Me.gcStockCode.OptionsColumn.ReadOnly = True
        Me.gcStockCode.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcStockCode.Visible = True
        Me.gcStockCode.VisibleIndex = 0
        Me.gcStockCode.Width = 110
        '
        'repbtnSubstituteMatReq
        '
        Me.repbtnSubstituteMatReq.AutoHeight = False
        Me.repbtnSubstituteMatReq.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.repbtnSubstituteMatReq.Name = "repbtnSubstituteMatReq"
        '
        'gcMatReqOtherDescription
        '
        Me.gcMatReqOtherDescription.Caption = "Descripción de Materiales"
        Me.gcMatReqOtherDescription.FieldName = "StockDescription"
        Me.gcMatReqOtherDescription.Name = "gcMatReqOtherDescription"
        Me.gcMatReqOtherDescription.Visible = True
        Me.gcMatReqOtherDescription.VisibleIndex = 1
        Me.gcMatReqOtherDescription.Width = 497
        '
        'gcStockItemUoM
        '
        Me.gcStockItemUoM.Caption = "UdM"
        Me.gcStockItemUoM.FieldName = "UoMDesc"
        Me.gcStockItemUoM.Name = "gcStockItemUoM"
        Me.gcStockItemUoM.OptionsColumn.ReadOnly = True
        Me.gcStockItemUoM.Visible = True
        Me.gcStockItemUoM.VisibleIndex = 2
        Me.gcStockItemUoM.Width = 49
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Cantidad Estimada"
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemSpinEdit3
        Me.GridColumn18.DisplayFormat.FormatString = "n1"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "Quantity"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 3
        Me.GridColumn18.Width = 125
        '
        'RepositoryItemSpinEdit3
        '
        Me.RepositoryItemSpinEdit3.AutoHeight = False
        Me.RepositoryItemSpinEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemSpinEdit3.MaskSettings.Set("mask", "n1")
        Me.RepositoryItemSpinEdit3.Name = "RepositoryItemSpinEdit3"
        '
        'gcAreaID
        '
        Me.gcAreaID.Caption = "Área"
        Me.gcAreaID.FieldName = "AreaID"
        Me.gcAreaID.Name = "gcAreaID"
        Me.gcAreaID.Width = 83
        '
        'gcDuplicateSI
        '
        Me.gcDuplicateSI.Caption = "Dupl."
        Me.gcDuplicateSI.ColumnEdit = Me.repoDuplicateSI
        Me.gcDuplicateSI.Name = "gcDuplicateSI"
        Me.gcDuplicateSI.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcDuplicateSI.Width = 62
        '
        'repoDuplicateSI
        '
        Me.repoDuplicateSI.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.repoDuplicateSI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoDuplicateSI.Name = "repoDuplicateSI"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Comentarios"
        Me.GridColumn15.FieldName = "Comments"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.GridColumn15.Width = 350
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Selec."
        Me.GridColumn10.ColumnEdit = Me.repoChkSelectedSI
        Me.GridColumn10.FieldName = "TmpSelectedItem"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 50
        '
        'repoChkSelectedSI
        '
        Me.repoChkSelectedSI.AutoHeight = False
        Me.repoChkSelectedSI.Name = "repoChkSelectedSI"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Costo"
        Me.GridColumn1.DisplayFormat.FormatString = "n2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "UnitCost"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Costo Total"
        Me.GridColumn2.DisplayFormat.FormatString = "n2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "TotalCost"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtDuration)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.btnMaintenanceWorkOrderDocument)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.btnEquipmentID)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.cboStatus)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.cboWorkCentreID)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.cboPriority)
        Me.GroupControl1.Controls.Add(Me.txtNotes)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.dtePlannedDate)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.cboEmployeeID)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.cboMaintenanceType)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.txtDescription)
        Me.GroupControl1.Controls.Add(Me.btnMaintOrderNo)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1347, 184)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Detalles Generales"
        '
        'txtDuration
        '
        Me.txtDuration.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDuration.Location = New System.Drawing.Point(686, 113)
        Me.txtDuration.MenuManager = Me.BarManager1
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Properties.MaskSettings.Set("mask", "f")
        Me.txtDuration.Properties.UseMaskAsDisplayFormat = True
        Me.txtDuration.Size = New System.Drawing.Size(50, 20)
        Me.txtDuration.TabIndex = 183
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSave, Me.btnSaveAndClose, Me.btnClose, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 10
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
        Me.Bar1.Text = "Tools"
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSaveAndClose.Caption = "Guardar y Cerrar"
        Me.btnSaveAndClose.Id = 1
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        '
        'bbtnSave
        '
        Me.bbtnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnSave.Caption = "Guardar"
        Me.bbtnSave.Id = 0
        Me.bbtnSave.Name = "bbtnSave"
        '
        'btnClose
        '
        Me.btnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnClose.Caption = "Cerrar"
        Me.btnClose.Id = 2
        Me.btnClose.Name = "btnClose"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1353, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 644)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1353, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 616)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1353, 28)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 616)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.BarButtonItem2.Caption = "Print"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(742, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 14)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "(hr)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(625, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 14)
        Me.Label11.TabIndex = 180
        Me.Label11.Text = "Duración"
        '
        'btnMaintenanceWorkOrderDocument
        '
        Me.btnMaintenanceWorkOrderDocument.Location = New System.Drawing.Point(846, 68)
        Me.btnMaintenanceWorkOrderDocument.MenuManager = Me.BarManager1
        Me.btnMaintenanceWorkOrderDocument.Name = "btnMaintenanceWorkOrderDocument"
        Me.btnMaintenanceWorkOrderDocument.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.btnMaintenanceWorkOrderDocument.Size = New System.Drawing.Size(190, 20)
        Me.btnMaintenanceWorkOrderDocument.TabIndex = 179
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(742, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 14)
        Me.Label10.TabIndex = 178
        Me.Label10.Text = "Gen. Documento"
        '
        'btnEquipmentID
        '
        Me.btnEquipmentID.Location = New System.Drawing.Point(299, 68)
        Me.btnEquipmentID.MenuManager = Me.BarManager1
        Me.btnEquipmentID.Name = "btnEquipmentID"
        Me.btnEquipmentID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.btnEquipmentID.Size = New System.Drawing.Size(220, 20)
        Me.btnEquipmentID.TabIndex = 177
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(455, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 14)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.Location = New System.Drawing.Point(504, 113)
        Me.cboStatus.MenuManager = Me.BarManager1
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Size = New System.Drawing.Size(100, 20)
        Me.cboStatus.TabIndex = 175
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(863, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 14)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Área"
        '
        'cboWorkCentreID
        '
        Me.cboWorkCentreID.Location = New System.Drawing.Point(902, 25)
        Me.cboWorkCentreID.MenuManager = Me.BarManager1
        Me.cboWorkCentreID.Name = "cboWorkCentreID"
        Me.cboWorkCentreID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboWorkCentreID.Size = New System.Drawing.Size(134, 20)
        Me.cboWorkCentreID.TabIndex = 173
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1059, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 14)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "Observaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Prioridad"
        '
        'cboPriority
        '
        Me.cboPriority.Location = New System.Drawing.Point(85, 113)
        Me.cboPriority.MenuManager = Me.BarManager1
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPriority.Size = New System.Drawing.Size(125, 20)
        Me.cboPriority.TabIndex = 170
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(1062, 45)
        Me.txtNotes.MenuManager = Me.BarManager1
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(276, 120)
        Me.txtNotes.TabIndex = 169
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(225, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 14)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "F. Estimada Inicio"
        '
        'dtePlannedDate
        '
        Me.dtePlannedDate.EditValue = Nothing
        Me.dtePlannedDate.Location = New System.Drawing.Point(331, 113)
        Me.dtePlannedDate.MenuManager = Me.BarManager1
        Me.dtePlannedDate.Name = "dtePlannedDate"
        Me.dtePlannedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePlannedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePlannedDate.Properties.NullDate = New Date(CType(0, Long))
        Me.dtePlannedDate.Size = New System.Drawing.Size(100, 20)
        Me.dtePlannedDate.TabIndex = 167
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(525, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Responsable"
        '
        'cboEmployeeID
        '
        Me.cboEmployeeID.Location = New System.Drawing.Point(610, 68)
        Me.cboEmployeeID.MenuManager = Me.BarManager1
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEmployeeID.Size = New System.Drawing.Size(126, 20)
        Me.cboEmployeeID.TabIndex = 165
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(225, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Maquinaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Tipo Mant."
        '
        'cboMaintenanceType
        '
        Me.cboMaintenanceType.Location = New System.Drawing.Point(85, 68)
        Me.cboMaintenanceType.MenuManager = Me.BarManager1
        Me.cboMaintenanceType.Name = "cboMaintenanceType"
        Me.cboMaintenanceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMaintenanceType.Size = New System.Drawing.Size(125, 20)
        Me.cboMaintenanceType.TabIndex = 161
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(220, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Descripción"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(298, 25)
        Me.txtDescription.MenuManager = Me.BarManager1
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(545, 20)
        Me.txtDescription.TabIndex = 159
        '
        'btnMaintOrderNo
        '
        Me.btnMaintOrderNo.Location = New System.Drawing.Point(85, 25)
        Me.btnMaintOrderNo.MenuManager = Me.BarManager1
        Me.btnMaintOrderNo.Name = "btnMaintOrderNo"
        Me.btnMaintOrderNo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintOrderNo.Properties.Appearance.Options.UseFont = True
        Me.btnMaintOrderNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.btnMaintOrderNo.Properties.ReadOnly = True
        Me.btnMaintOrderNo.Size = New System.Drawing.Size(125, 20)
        Me.btnMaintOrderNo.TabIndex = 158
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 14)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Núm O.T."
        '
        'bbtnEditProduct
        '
        Me.bbtnEditProduct.Name = "bbtnEditProduct"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Generar Req. Mat."
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'bbtnCreateCopy
        '
        Me.bbtnCreateCopy.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnCreateCopy.Caption = "Crear Copia"
        Me.bbtnCreateCopy.Id = 8
        Me.bbtnCreateCopy.Name = "bbtnCreateCopy"
        '
        'frmWorkOrderMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWorkOrderMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orden de Mantenimiento Interno"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grpMaintenanceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaintenanceItems.ResumeLayout(False)
        CType(Me.grdMaitenanceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMaintenanceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbtnSubstituteMatReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDuplicateSI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoChkSelectedSI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDuration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaintenanceWorkOrderDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEquipmentID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboWorkCentreID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePlannedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePlannedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmployeeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaintenanceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaintOrderNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnEditProduct As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnCreateCopy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grpMaintenanceItems As DevExpress.XtraEditors.GroupControl
  Friend WithEvents btnEquipmentID As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents Label9 As Label
  Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label8 As Label
  Friend WithEvents cboWorkCentreID As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents cboPriority As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents Label5 As Label
  Friend WithEvents dtePlannedDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents Label4 As Label
  Friend WithEvents cboEmployeeID As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents cboMaintenanceType As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label1 As Label
  Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
  Friend WithEvents btnMaintOrderNo As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents Label12 As Label
  Friend WithEvents grdMaitenanceItems As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMaintenanceItems As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcStockCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repbtnSubstituteMatReq As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcMatReqOtherDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockItemUoM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents gcAreaID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDuplicateSI As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoDuplicateSI As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoChkSelectedSI As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnMaintenanceWorkOrderDocument As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents Label10 As Label
  Friend WithEvents Label13 As Label
  Friend WithEvents Label11 As Label
  Friend WithEvents txtDuration As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
End Class
