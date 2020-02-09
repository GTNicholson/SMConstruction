<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurchaseOrder
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
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
    Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.Bar2 = New DevExpress.XtraBars.Bar()
    Me.Bar5 = New DevExpress.XtraBars.Bar()
    Me.Bar6 = New DevExpress.XtraBars.Bar()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.Bar4 = New DevExpress.XtraBars.Bar()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
    Me.txtCarriage = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
    Me.btnEditPurchaseOrderPDF = New DevExpress.XtraEditors.ButtonEdit()
    Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
    Me.cboBuyer = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.txtSupplierRef = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.dteDateOfOrder = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.dteDueDate = New DevExpress.XtraEditors.DateEdit()
    Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.cboCategory = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.btedSupplier = New DevExpress.XtraEditors.ButtonEdit()
    Me.txtPONum = New DevExpress.XtraEditors.TextEdit()
    Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
    Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
    Me.xtpPOItems = New DevExpress.XtraTab.XtraTabPage()
    Me.gpnlPOItems = New DevExpress.XtraEditors.GroupControl()
    Me.grdPurchaseOrderItems = New DevExpress.XtraGrid.GridControl()
    Me.gvPurchaseOrderItems = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPOIDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepoItemPopupContainerEditPOItemAllocation = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.gcPOIUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemSpinEditUnitValue = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.gcPOIUnit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPOINetValue = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcQtyReceived = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepoItemPopupContainerEditQtyReceived = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepoItemButtonEditStockItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.gcSuppCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStdOrderQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSupplierItem = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNominalAccountCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNominalCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcVATRateCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcVATValue = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPOINominalAccountCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPOINominalCostCentre = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCoCType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcDensity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xtpCallOffs = New DevExpress.XtraTab.XtraTabPage()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCarriage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.btnEditPurchaseOrderPDF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboBuyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSupplierRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDateOfOrder.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDateOfOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.btedSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPONum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.XtraTabControl1.SuspendLayout()
    Me.xtpPOItems.SuspendLayout()
    CType(Me.gpnlPOItems, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpnlPOItems.SuspendLayout()
    CType(Me.grdPurchaseOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvPurchaseOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemPopupContainerEditPOItemAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSpinEditUnitValue, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemPopupContainerEditQtyReceived, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepoItemButtonEditStockItem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DisableClose = True
    Me.Bar1.OptionsBar.DisableCustomization = True
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.OptionsBar.UseWholeRow = True
    Me.Bar1.Text = "Tools"
    '
    'Bar2
    '
    Me.Bar2.BarName = "Tools"
    Me.Bar2.DockCol = 0
    Me.Bar2.DockRow = 0
    Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar2.OptionsBar.AllowQuickCustomization = False
    Me.Bar2.OptionsBar.DisableClose = True
    Me.Bar2.OptionsBar.DisableCustomization = True
    Me.Bar2.OptionsBar.DrawDragBorder = False
    Me.Bar2.OptionsBar.UseWholeRow = True
    Me.Bar2.Text = "Tools"
    '
    'Bar5
    '
    Me.Bar5.BarName = "Tools"
    Me.Bar5.DockCol = 0
    Me.Bar5.DockRow = 0
    Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar5.OptionsBar.AllowQuickCustomization = False
    Me.Bar5.OptionsBar.DisableClose = True
    Me.Bar5.OptionsBar.DisableCustomization = True
    Me.Bar5.OptionsBar.DrawDragBorder = False
    Me.Bar5.OptionsBar.UseWholeRow = True
    Me.Bar5.Text = "Tools"
    '
    'Bar6
    '
    Me.Bar6.BarName = "Tools"
    Me.Bar6.DockCol = 0
    Me.Bar6.DockRow = 0
    Me.Bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar6.OptionsBar.AllowQuickCustomization = False
    Me.Bar6.OptionsBar.DisableClose = True
    Me.Bar6.OptionsBar.DisableCustomization = True
    Me.Bar6.OptionsBar.DrawDragBorder = False
    Me.Bar6.OptionsBar.UseWholeRow = True
    Me.Bar6.Text = "Tools"
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.BarButtonItem1.Caption = "Save && Exit"
    Me.BarButtonItem1.Id = 0
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'Bar4
    '
    Me.Bar4.BarName = "Tools"
    Me.Bar4.DockCol = 0
    Me.Bar4.DockRow = 0
    Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar4.Text = "Tools"
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSave, Me.btnSaveAndClose, Me.btnClose})
    Me.BarManager1.MaxItemId = 3
    '
    'Bar3
    '
    Me.Bar3.BarName = "Tools"
    Me.Bar3.DockCol = 0
    Me.Bar3.DockRow = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
    Me.Bar3.Text = "Tools"
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
    Me.barDockControlTop.Size = New System.Drawing.Size(1164, 30)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 578)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1164, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 548)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1164, 30)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 548)
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.GroupControl1)
    Me.PanelControl1.Controls.Add(Me.LabelControl13)
    Me.PanelControl1.Controls.Add(Me.txtCarriage)
    Me.PanelControl1.Controls.Add(Me.LabelControl12)
    Me.PanelControl1.Controls.Add(Me.btnEditPurchaseOrderPDF)
    Me.PanelControl1.Controls.Add(Me.LabelControl11)
    Me.PanelControl1.Controls.Add(Me.cboBuyer)
    Me.PanelControl1.Controls.Add(Me.LabelControl10)
    Me.PanelControl1.Controls.Add(Me.txtSupplierRef)
    Me.PanelControl1.Controls.Add(Me.LabelControl5)
    Me.PanelControl1.Controls.Add(Me.dteDateOfOrder)
    Me.PanelControl1.Controls.Add(Me.LabelControl4)
    Me.PanelControl1.Controls.Add(Me.dteDueDate)
    Me.PanelControl1.Controls.Add(Me.cboStatus)
    Me.PanelControl1.Controls.Add(Me.LabelControl3)
    Me.PanelControl1.Controls.Add(Me.cboCategory)
    Me.PanelControl1.Controls.Add(Me.LabelControl2)
    Me.PanelControl1.Controls.Add(Me.LabelControl1)
    Me.PanelControl1.Controls.Add(Me.btedSupplier)
    Me.PanelControl1.Controls.Add(Me.txtPONum)
    Me.PanelControl1.Controls.Add(Me.lblTitle)
    Me.PanelControl1.Location = New System.Drawing.Point(0, 39)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1152, 218)
    Me.PanelControl1.TabIndex = 4
    '
    'GroupControl1
    '
    Me.GroupControl1.Controls.Add(Me.TextEdit5)
    Me.GroupControl1.Controls.Add(Me.LabelControl8)
    Me.GroupControl1.Controls.Add(Me.TextEdit4)
    Me.GroupControl1.Controls.Add(Me.LabelControl7)
    Me.GroupControl1.Controls.Add(Me.TextEdit3)
    Me.GroupControl1.Controls.Add(Me.TextEdit2)
    Me.GroupControl1.Controls.Add(Me.LabelControl6)
    Me.GroupControl1.Controls.Add(Me.TextEdit1)
    Me.GroupControl1.Location = New System.Drawing.Point(445, 5)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(379, 202)
    Me.GroupControl1.TabIndex = 240
    Me.GroupControl1.Text = "Detalles del Proveedor"
    '
    'TextEdit5
    '
    Me.TextEdit5.EditValue = ""
    Me.TextEdit5.Location = New System.Drawing.Point(267, 110)
    Me.TextEdit5.MenuManager = Me.BarManager1
    Me.TextEdit5.Name = "TextEdit5"
    Me.TextEdit5.Size = New System.Drawing.Size(107, 20)
    Me.TextEdit5.TabIndex = 240
    '
    'LabelControl8
    '
    Me.LabelControl8.Location = New System.Drawing.Point(242, 113)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(19, 13)
    Me.LabelControl8.TabIndex = 239
    Me.LabelControl8.Text = "País"
    '
    'TextEdit4
    '
    Me.TextEdit4.EditValue = ""
    Me.TextEdit4.Location = New System.Drawing.Point(64, 110)
    Me.TextEdit4.MenuManager = Me.BarManager1
    Me.TextEdit4.Name = "TextEdit4"
    Me.TextEdit4.Size = New System.Drawing.Size(107, 20)
    Me.TextEdit4.TabIndex = 238
    '
    'LabelControl7
    '
    Me.LabelControl7.Location = New System.Drawing.Point(15, 113)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
    Me.LabelControl7.TabIndex = 237
    Me.LabelControl7.Text = "Ciudad"
    '
    'TextEdit3
    '
    Me.TextEdit3.EditValue = ""
    Me.TextEdit3.Location = New System.Drawing.Point(64, 74)
    Me.TextEdit3.MenuManager = Me.BarManager1
    Me.TextEdit3.Name = "TextEdit3"
    Me.TextEdit3.Size = New System.Drawing.Size(310, 20)
    Me.TextEdit3.TabIndex = 236
    '
    'TextEdit2
    '
    Me.TextEdit2.EditValue = ""
    Me.TextEdit2.Location = New System.Drawing.Point(64, 50)
    Me.TextEdit2.MenuManager = Me.BarManager1
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Size = New System.Drawing.Size(310, 20)
    Me.TextEdit2.TabIndex = 235
    '
    'LabelControl6
    '
    Me.LabelControl6.Location = New System.Drawing.Point(15, 28)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(43, 13)
    Me.LabelControl6.TabIndex = 234
    Me.LabelControl6.Text = "Dirección"
    '
    'TextEdit1
    '
    Me.TextEdit1.EditValue = ""
    Me.TextEdit1.Location = New System.Drawing.Point(64, 26)
    Me.TextEdit1.MenuManager = Me.BarManager1
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Size = New System.Drawing.Size(310, 20)
    Me.TextEdit1.TabIndex = 233
    '
    'LabelControl13
    '
    Me.LabelControl13.Location = New System.Drawing.Point(260, 34)
    Me.LabelControl13.Name = "LabelControl13"
    Me.LabelControl13.Size = New System.Drawing.Size(53, 13)
    Me.LabelControl13.TabIndex = 239
    Me.LabelControl13.Text = "Transporte"
    '
    'txtCarriage
    '
    Me.txtCarriage.Location = New System.Drawing.Point(317, 31)
    Me.txtCarriage.MenuManager = Me.BarManager1
    Me.txtCarriage.Name = "txtCarriage"
    Me.txtCarriage.Properties.Mask.EditMask = "c"
    Me.txtCarriage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtCarriage.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtCarriage.Size = New System.Drawing.Size(100, 20)
    Me.txtCarriage.TabIndex = 238
    '
    'LabelControl12
    '
    Me.LabelControl12.Location = New System.Drawing.Point(14, 190)
    Me.LabelControl12.Name = "LabelControl12"
    Me.LabelControl12.Size = New System.Drawing.Size(65, 13)
    Me.LabelControl12.TabIndex = 237
    Me.LabelControl12.Text = "Generar O.C."
    '
    'btnEditPurchaseOrderPDF
    '
    Me.btnEditPurchaseOrderPDF.Location = New System.Drawing.Point(104, 187)
    Me.btnEditPurchaseOrderPDF.Name = "btnEditPurchaseOrderPDF"
    Me.btnEditPurchaseOrderPDF.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditPurchaseOrderPDF.Properties.Appearance.Options.UseFont = True
    Me.btnEditPurchaseOrderPDF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btnEditPurchaseOrderPDF.Properties.ReadOnly = True
    Me.btnEditPurchaseOrderPDF.Size = New System.Drawing.Size(109, 20)
    Me.btnEditPurchaseOrderPDF.TabIndex = 236
    '
    'LabelControl11
    '
    Me.LabelControl11.Location = New System.Drawing.Point(17, 164)
    Me.LabelControl11.Name = "LabelControl11"
    Me.LabelControl11.Size = New System.Drawing.Size(53, 13)
    Me.LabelControl11.TabIndex = 235
    Me.LabelControl11.Text = "Comprador"
    '
    'cboBuyer
    '
    Me.cboBuyer.Location = New System.Drawing.Point(104, 161)
    Me.cboBuyer.MenuManager = Me.BarManager1
    Me.cboBuyer.Name = "cboBuyer"
    Me.cboBuyer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboBuyer.Size = New System.Drawing.Size(109, 20)
    Me.cboBuyer.TabIndex = 234
    '
    'LabelControl10
    '
    Me.LabelControl10.Location = New System.Drawing.Point(14, 60)
    Me.LabelControl10.Name = "LabelControl10"
    Me.LabelControl10.Size = New System.Drawing.Size(50, 13)
    Me.LabelControl10.TabIndex = 233
    Me.LabelControl10.Text = "Ref. Prov."
    '
    'txtSupplierRef
    '
    Me.txtSupplierRef.EditValue = ""
    Me.txtSupplierRef.Location = New System.Drawing.Point(104, 57)
    Me.txtSupplierRef.MenuManager = Me.BarManager1
    Me.txtSupplierRef.Name = "txtSupplierRef"
    Me.txtSupplierRef.Size = New System.Drawing.Size(109, 20)
    Me.txtSupplierRef.TabIndex = 232
    '
    'LabelControl5
    '
    Me.LabelControl5.Location = New System.Drawing.Point(234, 8)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(77, 13)
    Me.LabelControl5.TabIndex = 231
    Me.LabelControl5.Text = "Fecha de Órden"
    '
    'dteDateOfOrder
    '
    Me.dteDateOfOrder.EditValue = Nothing
    Me.dteDateOfOrder.Location = New System.Drawing.Point(317, 5)
    Me.dteDateOfOrder.MenuManager = Me.BarManager1
    Me.dteDateOfOrder.Name = "dteDateOfOrder"
    Me.dteDateOfOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDateOfOrder.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDateOfOrder.Size = New System.Drawing.Size(100, 20)
    Me.dteDateOfOrder.TabIndex = 230
    '
    'LabelControl4
    '
    Me.LabelControl4.Location = New System.Drawing.Point(17, 138)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(81, 13)
    Me.LabelControl4.TabIndex = 227
    Me.LabelControl4.Text = "Fecha Requerida"
    '
    'dteDueDate
    '
    Me.dteDueDate.EditValue = Nothing
    Me.dteDueDate.Location = New System.Drawing.Point(104, 135)
    Me.dteDueDate.MenuManager = Me.BarManager1
    Me.dteDueDate.Name = "dteDueDate"
    Me.dteDueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDueDate.Size = New System.Drawing.Size(109, 20)
    Me.dteDueDate.TabIndex = 226
    '
    'cboStatus
    '
    Me.cboStatus.Location = New System.Drawing.Point(104, 109)
    Me.cboStatus.MenuManager = Me.BarManager1
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboStatus.Size = New System.Drawing.Size(109, 20)
    Me.cboStatus.TabIndex = 225
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(17, 112)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
    Me.LabelControl3.TabIndex = 224
    Me.LabelControl3.Text = "Estado"
    '
    'cboCategory
    '
    Me.cboCategory.Location = New System.Drawing.Point(104, 83)
    Me.cboCategory.MenuManager = Me.BarManager1
    Me.cboCategory.Name = "cboCategory"
    Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboCategory.Size = New System.Drawing.Size(109, 20)
    Me.cboCategory.TabIndex = 223
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(17, 86)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
    Me.LabelControl2.TabIndex = 222
    Me.LabelControl2.Text = "Categoría"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Appearance.Options.UseForeColor = True
    Me.LabelControl1.Location = New System.Drawing.Point(14, 33)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(77, 18)
    Me.LabelControl1.TabIndex = 221
    Me.LabelControl1.Text = "Proveedor"
    '
    'btedSupplier
    '
    Me.btedSupplier.Location = New System.Drawing.Point(104, 31)
    Me.btedSupplier.MenuManager = Me.BarManager1
    Me.btedSupplier.Name = "btedSupplier"
    Me.btedSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btedSupplier.Size = New System.Drawing.Size(109, 20)
    Me.btedSupplier.TabIndex = 220
    '
    'txtPONum
    '
    Me.txtPONum.Location = New System.Drawing.Point(104, 5)
    Me.txtPONum.MenuManager = Me.BarManager1
    Me.txtPONum.Name = "txtPONum"
    Me.txtPONum.Size = New System.Drawing.Size(109, 20)
    Me.txtPONum.TabIndex = 219
    '
    'lblTitle
    '
    Me.lblTitle.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitle.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.lblTitle.Appearance.Options.UseFont = True
    Me.lblTitle.Appearance.Options.UseForeColor = True
    Me.lblTitle.Location = New System.Drawing.Point(14, 5)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(43, 18)
    Me.lblTitle.TabIndex = 218
    Me.lblTitle.Text = "# O.C."
    '
    'XtraTabControl1
    '
    Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.XtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.XtraTabControl1.Location = New System.Drawing.Point(0, 263)
    Me.XtraTabControl1.Name = "XtraTabControl1"
    Me.XtraTabControl1.SelectedTabPage = Me.xtpPOItems
    Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
    Me.XtraTabControl1.Size = New System.Drawing.Size(1152, 314)
    Me.XtraTabControl1.TabIndex = 206
    Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPOItems, Me.xtpCallOffs})
    '
    'xtpPOItems
    '
    Me.xtpPOItems.Controls.Add(Me.gpnlPOItems)
    Me.xtpPOItems.Name = "xtpPOItems"
    Me.xtpPOItems.Size = New System.Drawing.Size(1144, 306)
    Me.xtpPOItems.Text = "PO Items"
    '
    'gpnlPOItems
    '
    Me.gpnlPOItems.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpnlPOItems.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.gpnlPOItems.Appearance.Options.UseFont = True
    Me.gpnlPOItems.Appearance.Options.UseForeColor = True
    Me.gpnlPOItems.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpnlPOItems.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.gpnlPOItems.AppearanceCaption.Options.UseFont = True
    Me.gpnlPOItems.AppearanceCaption.Options.UseForeColor = True
    Me.gpnlPOItems.ButtonInterval = 2
    Me.gpnlPOItems.Controls.Add(Me.grdPurchaseOrderItems)
    ButtonImageOptions1.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
    ButtonImageOptions2.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
    Me.gpnlPOItems.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Artículo", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "AddStockItem", 0), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar Artículo", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "DeleteItem", 2)})
    Me.gpnlPOItems.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.gpnlPOItems.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gpnlPOItems.Location = New System.Drawing.Point(0, 0)
    Me.gpnlPOItems.Name = "gpnlPOItems"
    Me.gpnlPOItems.Size = New System.Drawing.Size(1144, 306)
    Me.gpnlPOItems.TabIndex = 204
    Me.gpnlPOItems.Text = "Artículos de Compra"
    '
    'grdPurchaseOrderItems
    '
    Me.grdPurchaseOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.Edit.Visible = False
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.EndEdit.Visible = False
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.First.Visible = False
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.Last.Visible = False
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.NextPage.Visible = False
    Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.PrevPage.Visible = False
    GridLevelNode1.RelationName = "Level1"
    Me.grdPurchaseOrderItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
    Me.grdPurchaseOrderItems.Location = New System.Drawing.Point(2, 24)
    Me.grdPurchaseOrderItems.MainView = Me.gvPurchaseOrderItems
    Me.grdPurchaseOrderItems.MenuManager = Me.BarManager1
    Me.grdPurchaseOrderItems.Name = "grdPurchaseOrderItems"
    Me.grdPurchaseOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoItemPopupContainerEditPOItemAllocation, Me.RepoItemButtonEditStockItem, Me.RepositoryItemSpinEditUnitValue, Me.RepoItemPopupContainerEditQtyReceived})
    Me.grdPurchaseOrderItems.Size = New System.Drawing.Size(1140, 280)
    Me.grdPurchaseOrderItems.TabIndex = 86
    Me.grdPurchaseOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderItems})
    '
    'gvPurchaseOrderItems
    '
    Me.gvPurchaseOrderItems.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvPurchaseOrderItems.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvPurchaseOrderItems.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvPurchaseOrderItems.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvPurchaseOrderItems.ColumnPanelRowHeight = 35
    Me.gvPurchaseOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.gcPOIDescription, Me.gcQuantity, Me.gcPOIUnitPrice, Me.gcPOIUnit, Me.gcPOINetValue, Me.gcQtyReceived, Me.GridColumn7, Me.gcStockCode, Me.gcSuppCode, Me.GridColumn11, Me.gcStdOrderQty, Me.gcUnitName, Me.GridColumn13, Me.gcSupplierItem, Me.gcNominalAccountCode, Me.gcNominalCostCentre, Me.gcVATRateCode, Me.gcVATValue, Me.GridColumn9, Me.GridColumn10, Me.gcPOINominalAccountCode, Me.gcPOINominalCostCentre, Me.GridColumn22, Me.gcCoCType, Me.gcDensity})
    Me.gvPurchaseOrderItems.GridControl = Me.grdPurchaseOrderItems
    Me.gvPurchaseOrderItems.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", Me.gcPOINetValue, "")})
    Me.gvPurchaseOrderItems.Name = "gvPurchaseOrderItems"
    Me.gvPurchaseOrderItems.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gvPurchaseOrderItems.OptionsView.ShowDetailButtons = False
    Me.gvPurchaseOrderItems.OptionsView.ShowFooter = True
    Me.gvPurchaseOrderItems.OptionsView.ShowGroupPanel = False
    Me.gvPurchaseOrderItems.ViewCaption = "Purchase Order Items"
    '
    'GridColumn12
    '
    Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridColumn12.Caption = "Item"
    Me.GridColumn12.FieldName = "ItemNo"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.OptionsColumn.AllowEdit = False
    Me.GridColumn12.OptionsColumn.ReadOnly = True
    Me.GridColumn12.Width = 49
    '
    'gcPOIDescription
    '
    Me.gcPOIDescription.AppearanceHeader.Options.UseTextOptions = True
    Me.gcPOIDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcPOIDescription.Caption = "Description"
    Me.gcPOIDescription.FieldName = "Description"
    Me.gcPOIDescription.Name = "gcPOIDescription"
    Me.gcPOIDescription.Visible = True
    Me.gcPOIDescription.VisibleIndex = 1
    Me.gcPOIDescription.Width = 279
    '
    'gcQuantity
    '
    Me.gcQuantity.AppearanceCell.Options.UseTextOptions = True
    Me.gcQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcQuantity.AppearanceHeader.Options.UseTextOptions = True
    Me.gcQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcQuantity.Caption = "Quantity"
    Me.gcQuantity.ColumnEdit = Me.RepoItemPopupContainerEditPOItemAllocation
    Me.gcQuantity.DisplayFormat.FormatString = "0.##"
    Me.gcQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcQuantity.FieldName = "TotalQuantityAllocated"
    Me.gcQuantity.Name = "gcQuantity"
    Me.gcQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyRequired", "{0:0.####}")})
    Me.gcQuantity.Visible = True
    Me.gcQuantity.VisibleIndex = 5
    Me.gcQuantity.Width = 54
    '
    'RepoItemPopupContainerEditPOItemAllocation
    '
    Me.RepoItemPopupContainerEditPOItemAllocation.AutoHeight = False
    Me.RepoItemPopupContainerEditPOItemAllocation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepoItemPopupContainerEditPOItemAllocation.EditFormat.FormatString = "0.##"
    Me.RepoItemPopupContainerEditPOItemAllocation.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepoItemPopupContainerEditPOItemAllocation.Name = "RepoItemPopupContainerEditPOItemAllocation"
    Me.RepoItemPopupContainerEditPOItemAllocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
    '
    'gcPOIUnitPrice
    '
    Me.gcPOIUnitPrice.AppearanceCell.Options.UseTextOptions = True
    Me.gcPOIUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcPOIUnitPrice.AppearanceHeader.Options.UseTextOptions = True
    Me.gcPOIUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcPOIUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcPOIUnitPrice.Caption = "Unit Price"
    Me.gcPOIUnitPrice.ColumnEdit = Me.RepositoryItemSpinEditUnitValue
    Me.gcPOIUnitPrice.DisplayFormat.FormatString = "c"
    Me.gcPOIUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcPOIUnitPrice.FieldName = "UnitPrice"
    Me.gcPOIUnitPrice.Name = "gcPOIUnitPrice"
    Me.gcPOIUnitPrice.Visible = True
    Me.gcPOIUnitPrice.VisibleIndex = 8
    Me.gcPOIUnitPrice.Width = 57
    '
    'RepositoryItemSpinEditUnitValue
    '
    Me.RepositoryItemSpinEditUnitValue.AutoHeight = False
    Me.RepositoryItemSpinEditUnitValue.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemSpinEditUnitValue.Mask.EditMask = "n2"
    Me.RepositoryItemSpinEditUnitValue.Name = "RepositoryItemSpinEditUnitValue"
    '
    'gcPOIUnit
    '
    Me.gcPOIUnit.AppearanceCell.Options.UseTextOptions = True
    Me.gcPOIUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcPOIUnit.AppearanceHeader.Options.UseTextOptions = True
    Me.gcPOIUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcPOIUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcPOIUnit.Caption = "Unit"
    Me.gcPOIUnit.FieldName = "PricingUnit"
    Me.gcPOIUnit.Name = "gcPOIUnit"
    Me.gcPOIUnit.Visible = True
    Me.gcPOIUnit.VisibleIndex = 6
    Me.gcPOIUnit.Width = 54
    '
    'gcPOINetValue
    '
    Me.gcPOINetValue.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcPOINetValue.AppearanceCell.Options.UseBackColor = True
    Me.gcPOINetValue.AppearanceCell.Options.UseTextOptions = True
    Me.gcPOINetValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcPOINetValue.AppearanceHeader.Options.UseTextOptions = True
    Me.gcPOINetValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcPOINetValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcPOINetValue.Caption = "Net Value"
    Me.gcPOINetValue.DisplayFormat.FormatString = "c"
    Me.gcPOINetValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcPOINetValue.FieldName = "NetAmount"
    Me.gcPOINetValue.Name = "gcPOINetValue"
    Me.gcPOINetValue.OptionsColumn.AllowEdit = False
    Me.gcPOINetValue.OptionsColumn.ReadOnly = True
    Me.gcPOINetValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetAmount", "{0:c}")})
    Me.gcPOINetValue.Visible = True
    Me.gcPOINetValue.VisibleIndex = 9
    Me.gcPOINetValue.Width = 122
    '
    'gcQtyReceived
    '
    Me.gcQtyReceived.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcQtyReceived.AppearanceCell.Options.UseBackColor = True
    Me.gcQtyReceived.AppearanceCell.Options.UseTextOptions = True
    Me.gcQtyReceived.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcQtyReceived.AppearanceHeader.Options.UseTextOptions = True
    Me.gcQtyReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.gcQtyReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcQtyReceived.Caption = "Qty Received"
    Me.gcQtyReceived.ColumnEdit = Me.RepoItemPopupContainerEditQtyReceived
    Me.gcQtyReceived.DisplayFormat.FormatString = "0.##"
    Me.gcQtyReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcQtyReceived.FieldName = "QtyReceived"
    Me.gcQtyReceived.Name = "gcQtyReceived"
    Me.gcQtyReceived.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyReceived", "{0:0.#}")})
    Me.gcQtyReceived.Width = 76
    '
    'RepoItemPopupContainerEditQtyReceived
    '
    Me.RepoItemPopupContainerEditQtyReceived.AutoHeight = False
    Me.RepoItemPopupContainerEditQtyReceived.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepoItemPopupContainerEditQtyReceived.DisplayFormat.FormatString = "0.##"
    Me.RepoItemPopupContainerEditQtyReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepoItemPopupContainerEditQtyReceived.Name = "RepoItemPopupContainerEditQtyReceived"
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
    Me.GridColumn7.Caption = "Qty Outstanding"
    Me.GridColumn7.DisplayFormat.FormatString = "0.####"
    Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn7.FieldName = "QtyOutstanding"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.OptionsColumn.AllowEdit = False
    Me.GridColumn7.OptionsColumn.ReadOnly = True
    Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtyOutstanding", "{0:0.#}")})
    Me.GridColumn7.Width = 79
    '
    'gcStockCode
    '
    Me.gcStockCode.AppearanceHeader.Options.UseTextOptions = True
    Me.gcStockCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcStockCode.Caption = "Part No"
    Me.gcStockCode.ColumnEdit = Me.RepoItemButtonEditStockItem
    Me.gcStockCode.FieldName = "PartNo"
    Me.gcStockCode.Name = "gcStockCode"
    Me.gcStockCode.Width = 140
    '
    'RepoItemButtonEditStockItem
    '
    Me.RepoItemButtonEditStockItem.AutoHeight = False
    Me.RepoItemButtonEditStockItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
    Me.RepoItemButtonEditStockItem.Name = "RepoItemButtonEditStockItem"
    '
    'gcSuppCode
    '
    Me.gcSuppCode.AppearanceHeader.Options.UseTextOptions = True
    Me.gcSuppCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcSuppCode.Caption = "Supplier Code"
    Me.gcSuppCode.FieldName = "SupplierCode"
    Me.gcSuppCode.Name = "gcSuppCode"
    Me.gcSuppCode.Visible = True
    Me.gcSuppCode.VisibleIndex = 0
    Me.gcSuppCode.Width = 97
    '
    'GridColumn11
    '
    Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridColumn11.Caption = "Notes"
    Me.GridColumn11.FieldName = "Notes"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 2
    Me.GridColumn11.Width = 101
    '
    'gcStdOrderQty
    '
    Me.gcStdOrderQty.AppearanceHeader.Options.UseTextOptions = True
    Me.gcStdOrderQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcStdOrderQty.Caption = "Std Order Qty"
    Me.gcStdOrderQty.DisplayFormat.FormatString = "0.#"
    Me.gcStdOrderQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcStdOrderQty.FieldName = "gcStdOrderQty"
    Me.gcStdOrderQty.Name = "gcStdOrderQty"
    Me.gcStdOrderQty.OptionsColumn.ReadOnly = True
    Me.gcStdOrderQty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcStdOrderQty.Width = 67
    '
    'gcUnitName
    '
    Me.gcUnitName.AppearanceHeader.Options.UseTextOptions = True
    Me.gcUnitName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcUnitName.Caption = "Unit Name"
    Me.gcUnitName.FieldNameSortGroup = "CostUnitType"
    Me.gcUnitName.Name = "gcUnitName"
    Me.gcUnitName.Width = 67
    '
    'GridColumn13
    '
    Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn13.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridColumn13.Caption = "Stock Multiple"
    Me.GridColumn13.FieldName = "PurchaseMultiple"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.OptionsColumn.ReadOnly = True
    Me.GridColumn13.Width = 55
    '
    'gcSupplierItem
    '
    Me.gcSupplierItem.AppearanceHeader.Options.UseTextOptions = True
    Me.gcSupplierItem.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcSupplierItem.Caption = "Supplier Item"
    Me.gcSupplierItem.FieldName = "SupplierPriced"
    Me.gcSupplierItem.Name = "gcSupplierItem"
    Me.gcSupplierItem.OptionsColumn.ReadOnly = True
    Me.gcSupplierItem.Width = 86
    '
    'gcNominalAccountCode
    '
    Me.gcNominalAccountCode.Caption = "Nominal Code"
    Me.gcNominalAccountCode.FieldName = "gcNominalAccountCode"
    Me.gcNominalAccountCode.Name = "gcNominalAccountCode"
    Me.gcNominalAccountCode.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
    Me.gcNominalAccountCode.Width = 82
    '
    'gcNominalCostCentre
    '
    Me.gcNominalCostCentre.Caption = "Cost Centre"
    Me.gcNominalCostCentre.FieldName = "gcNominalCostCentre"
    Me.gcNominalCostCentre.Name = "gcNominalCostCentre"
    Me.gcNominalCostCentre.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
    Me.gcNominalCostCentre.Width = 69
    '
    'gcVATRateCode
    '
    Me.gcVATRateCode.Caption = "V.A.T Code"
    Me.gcVATRateCode.FieldName = "UBVatRateCode"
    Me.gcVATRateCode.Name = "gcVATRateCode"
    Me.gcVATRateCode.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
    Me.gcVATRateCode.Visible = True
    Me.gcVATRateCode.VisibleIndex = 7
    Me.gcVATRateCode.Width = 84
    '
    'gcVATValue
    '
    Me.gcVATValue.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.gcVATValue.AppearanceCell.Options.UseBackColor = True
    Me.gcVATValue.Caption = "Unit V.A.T"
    Me.gcVATValue.DisplayFormat.FormatString = "C2"
    Me.gcVATValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcVATValue.FieldName = "VatValue"
    Me.gcVATValue.Name = "gcVATValue"
    Me.gcVATValue.OptionsColumn.AllowEdit = False
    Me.gcVATValue.OptionsColumn.ReadOnly = True
    Me.gcVATValue.Width = 67
    '
    'GridColumn9
    '
    Me.GridColumn9.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn9.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn9.Caption = "Barcode"
    Me.GridColumn9.FieldName = "Barcode"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.OptionsColumn.ReadOnly = True
    Me.GridColumn9.Width = 71
    '
    'GridColumn10
    '
    Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
    Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn10.Caption = "Sage Code"
    Me.GridColumn10.FieldName = "SageCode"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Width = 71
    '
    'gcPOINominalAccountCode
    '
    Me.gcPOINominalAccountCode.Caption = "Nominal Code"
    Me.gcPOINominalAccountCode.FieldName = "NominalAccountCode"
    Me.gcPOINominalAccountCode.Name = "gcPOINominalAccountCode"
    Me.gcPOINominalAccountCode.Width = 66
    '
    'gcPOINominalCostCentre
    '
    Me.gcPOINominalCostCentre.Caption = "Cost Centre"
    Me.gcPOINominalCostCentre.FieldName = "NominalCostCentre"
    Me.gcPOINominalCostCentre.Name = "gcPOINominalCostCentre"
    Me.gcPOINominalCostCentre.Width = 52
    '
    'GridColumn22
    '
    Me.GridColumn22.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn22.Caption = "Pack Qty"
    Me.GridColumn22.DisplayFormat.FormatString = "0.##;;#"
    Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn22.FieldName = "PackQuantity"
    Me.GridColumn22.Name = "GridColumn22"
    Me.GridColumn22.Width = 58
    '
    'gcCoCType
    '
    Me.gcCoCType.Caption = "CoC Type"
    Me.gcCoCType.FieldName = "CoCType"
    Me.gcCoCType.Name = "gcCoCType"
    Me.gcCoCType.Visible = True
    Me.gcCoCType.VisibleIndex = 4
    '
    'gcDensity
    '
    Me.gcDensity.Caption = "Density"
    Me.gcDensity.DisplayFormat.FormatString = "0.###"
    Me.gcDensity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcDensity.FieldName = "Density"
    Me.gcDensity.Name = "gcDensity"
    Me.gcDensity.Visible = True
    Me.gcDensity.VisibleIndex = 3
    '
    'xtpCallOffs
    '
    Me.xtpCallOffs.Name = "xtpCallOffs"
    Me.xtpCallOffs.PageEnabled = False
    Me.xtpCallOffs.PageVisible = False
    Me.xtpCallOffs.Size = New System.Drawing.Size(1146, 308)
    Me.xtpCallOffs.Text = "Call Offs"
    '
    'frmPurchaseOrder
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.ClientSize = New System.Drawing.Size(1164, 578)
    Me.Controls.Add(Me.XtraTabControl1)
    Me.Controls.Add(Me.PanelControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmPurchaseOrder"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Órden de Compra"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCarriage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.btnEditPurchaseOrderPDF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboBuyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSupplierRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDateOfOrder.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDateOfOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.btedSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPONum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.XtraTabControl1.ResumeLayout(False)
    Me.xtpPOItems.ResumeLayout(False)
    CType(Me.gpnlPOItems, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gpnlPOItems.ResumeLayout(False)
    CType(Me.grdPurchaseOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvPurchaseOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemPopupContainerEditPOItemAllocation, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSpinEditUnitValue, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemPopupContainerEditQtyReceived, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepoItemButtonEditStockItem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
  Friend WithEvents Bar6 As DevExpress.XtraBars.Bar
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents xtpPOItems As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents gpnlPOItems As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdPurchaseOrderItems As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvPurchaseOrderItems As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPOIDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQuantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepoItemPopupContainerEditPOItemAllocation As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents gcPOIUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemSpinEditUnitValue As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents gcPOIUnit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPOINetValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQtyReceived As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepoItemPopupContainerEditQtyReceived As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepoItemButtonEditStockItem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcSuppCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStdOrderQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcUnitName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSupplierItem As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNominalAccountCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNominalCostCentre As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcVATRateCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcVATValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPOINominalAccountCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPOINominalCostCentre As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCoCType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDensity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xtpCallOffs As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCarriage As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnEditPurchaseOrderPDF As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboBuyer As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtSupplierRef As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents dteDateOfOrder As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents dteDueDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboCategory As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btedSupplier As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents txtPONum As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
End Class
