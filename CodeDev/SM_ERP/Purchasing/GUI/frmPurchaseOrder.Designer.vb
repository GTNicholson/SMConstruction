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
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions5 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions6 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
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
        Me.btnSendPOEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPODelivery = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpnlPOItems = New DevExpress.XtraEditors.GroupControl()
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grdWorkOrderItem = New DevExpress.XtraGrid.GridControl()
        Me.gvWorkOrderItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopPutWorkOrderQty = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.grdPurchaseOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.gvPurchaseOrderItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPOIDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPOIUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEditUnitValue = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcPOINetValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcVATRateCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopupWorkOrder = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.gcCoCType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoItemPopupContainerEditPOItemAllocation = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepoItemButtonEditStockItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepoItemPopupContainerEditQtyReceived = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.grdPODeliveryInfos = New DevExpress.XtraGrid.GridControl()
        Me.gvPODeliveryInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.grpPOMaterialType = New DevExpress.XtraEditors.GroupControl()
        Me.xtabPOReqType = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpInventory = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpSingle = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.dteDateRequired = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit()
        Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
        Me.btedSOPhase = New DevExpress.XtraEditors.ButtonEdit()
        Me.xtpMultiple = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btnManageCOs = New DevExpress.XtraEditors.SimpleButton()
        Me.grdWOs = New DevExpress.XtraGrid.GridControl()
        Me.gvWOs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcCallOff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnReloadPODeliveryInfos = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.uctDeliveryAddress = New SimplementeMadera.uctAddress()
        Me.txtNetValue = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPaymentStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.UctAddress1 = New SimplementeMadera.uctAddress()
        Me.lblExchangeRate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExchangeValue = New DevExpress.XtraEditors.TextEdit()
        Me.rgDefaultCurrency = New DevExpress.XtraEditors.RadioGroup()
        Me.btePONum = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.btedSupplier = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCarriage = New DevExpress.XtraEditors.TextEdit()
        Me.dteDateOfOrder = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnEditPurchaseOrderPDF = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboBuyer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dteDueDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupplierRef = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpnlPOItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpnlPOItems.SuspendLayout()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grdWorkOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorkOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopPutWorkOrderQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPurchaseOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEditUnitValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemPopupContainerEditPOItemAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemButtonEditStockItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemPopupContainerEditQtyReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grdPODeliveryInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPODeliveryInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPOMaterialType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPOMaterialType.SuspendLayout()
        CType(Me.xtabPOReqType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabPOReqType.SuspendLayout()
        Me.xtpInventory.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.xtpSingle.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.dteDateRequired.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDateRequired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btedSOPhase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMultiple.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grdWOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNetValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtExchangeValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgDefaultCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btePONum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btedSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarriage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDateOfOrder.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDateOfOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditPurchaseOrderPDF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSave, Me.btnSaveAndClose, Me.btnClose, Me.btnSendPOEmail, Me.btnPODelivery})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar3
        '
        Me.Bar3.BarName = "Tools"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSendPOEmail), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPODelivery)})
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
        'btnSendPOEmail
        '
        Me.btnSendPOEmail.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSendPOEmail.Caption = "Enviar O.C. por Correo"
        Me.btnSendPOEmail.Id = 3
        Me.btnSendPOEmail.Name = "btnSendPOEmail"
        '
        'btnPODelivery
        '
        Me.btnPODelivery.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPODelivery.Caption = "Recibir Compra"
        Me.btnPODelivery.Id = 4
        Me.btnPODelivery.Name = "btnPODelivery"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1570, 33)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 804)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1570, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 771)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1570, 33)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 771)
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'gpnlPOItems
        '
        Me.gpnlPOItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpnlPOItems.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpnlPOItems.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.gpnlPOItems.Appearance.Options.UseFont = True
        Me.gpnlPOItems.Appearance.Options.UseForeColor = True
        Me.gpnlPOItems.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpnlPOItems.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.gpnlPOItems.AppearanceCaption.Options.UseFont = True
        Me.gpnlPOItems.AppearanceCaption.Options.UseForeColor = True
        Me.gpnlPOItems.ButtonInterval = 2
        Me.gpnlPOItems.Controls.Add(Me.PopupContainerControl1)
        Me.gpnlPOItems.Controls.Add(Me.grdPurchaseOrderItems)
        ButtonImageOptions4.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ButtonImageOptions5.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ButtonImageOptions6.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        Me.gpnlPOItems.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Artículo", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "AddStockItem", 0), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Item Manual", True, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "ManualItem", 3), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar Artículo", True, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "DeleteItem", 2)})
        Me.gpnlPOItems.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gpnlPOItems.Location = New System.Drawing.Point(6, 429)
        Me.gpnlPOItems.Name = "gpnlPOItems"
        Me.gpnlPOItems.Size = New System.Drawing.Size(1552, 363)
        Me.gpnlPOItems.TabIndex = 243
        Me.gpnlPOItems.Text = "Artículos de Compra"
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.PanelControl2)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(530, 116)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(407, 171)
        Me.PopupContainerControl1.TabIndex = 268
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grdWorkOrderItem)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(407, 171)
        Me.PanelControl2.TabIndex = 0
        '
        'grdWorkOrderItem
        '
        Me.grdWorkOrderItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.grdWorkOrderItem.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdWorkOrderItem.Location = New System.Drawing.Point(2, 2)
        Me.grdWorkOrderItem.MainView = Me.gvWorkOrderItem
        Me.grdWorkOrderItem.MenuManager = Me.BarManager1
        Me.grdWorkOrderItem.Name = "grdWorkOrderItem"
        Me.grdWorkOrderItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoPopPutWorkOrderQty})
        Me.grdWorkOrderItem.Size = New System.Drawing.Size(403, 167)
        Me.grdWorkOrderItem.TabIndex = 0
        Me.grdWorkOrderItem.UseEmbeddedNavigator = True
        Me.grdWorkOrderItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrderItem})
        '
        'gvWorkOrderItem
        '
        Me.gvWorkOrderItem.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWorkOrderItem.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWorkOrderItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn9, Me.GridColumn4})
        Me.gvWorkOrderItem.GridControl = Me.grdWorkOrderItem
        Me.gvWorkOrderItem.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.GridColumn7, "N2")})
        Me.gvWorkOrderItem.Name = "gvWorkOrderItem"
        Me.gvWorkOrderItem.OptionsView.ShowFooter = True
        Me.gvWorkOrderItem.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "OT Núm"
        Me.GridColumn6.FieldName = "WorkOrderID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 83
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cant."
        Me.GridColumn7.DisplayFormat.FormatString = "N2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Quantity"
        Me.GridColumn7.GroupFormat.FormatString = "N2"
        Me.GridColumn7.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 67
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ref. Item"
        Me.GridColumn9.FieldName = "ItemRef"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 68
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Descripción"
        Me.GridColumn4.FieldName = "Description"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 167
        '
        'repoPopPutWorkOrderQty
        '
        Me.repoPopPutWorkOrderQty.AutoHeight = False
        Me.repoPopPutWorkOrderQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopPutWorkOrderQty.EditFormat.FormatString = "N0"
        Me.repoPopPutWorkOrderQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoPopPutWorkOrderQty.Name = "repoPopPutWorkOrderQty"
        '
        'grdPurchaseOrderItems
        '
        Me.grdPurchaseOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdPurchaseOrderItems.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        GridLevelNode1.RelationName = "Level1"
        Me.grdPurchaseOrderItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdPurchaseOrderItems.Location = New System.Drawing.Point(2, 26)
        Me.grdPurchaseOrderItems.MainView = Me.gvPurchaseOrderItems
        Me.grdPurchaseOrderItems.MenuManager = Me.BarManager1
        Me.grdPurchaseOrderItems.Name = "grdPurchaseOrderItems"
        Me.grdPurchaseOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoItemPopupContainerEditPOItemAllocation, Me.RepoItemButtonEditStockItem, Me.RepositoryItemSpinEditUnitValue, Me.RepoItemPopupContainerEditQtyReceived, Me.repoPopupWorkOrder})
        Me.grdPurchaseOrderItems.Size = New System.Drawing.Size(1548, 335)
        Me.grdPurchaseOrderItems.TabIndex = 86
        Me.grdPurchaseOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderItems})
        '
        'gvPurchaseOrderItems
        '
        Me.gvPurchaseOrderItems.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvPurchaseOrderItems.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPurchaseOrderItems.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPurchaseOrderItems.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPurchaseOrderItems.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPurchaseOrderItems.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPurchaseOrderItems.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPurchaseOrderItems.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPurchaseOrderItems.ColumnPanelRowHeight = 35
        Me.gvPurchaseOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.gcPOIDescription, Me.gcPOIUnitPrice, Me.gcPOINetValue, Me.GridColumn11, Me.gcVATRateCode, Me.GridColumn1, Me.GridColumn3, Me.gcCoCType, Me.GridColumn8, Me.GridColumn10, Me.GridColumn12, Me.GridColumn16, Me.GridColumn15})
        Me.gvPurchaseOrderItems.GridControl = Me.grdPurchaseOrderItems
        Me.gvPurchaseOrderItems.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", Me.gcPOINetValue, "")})
        Me.gvPurchaseOrderItems.Name = "gvPurchaseOrderItems"
        Me.gvPurchaseOrderItems.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPurchaseOrderItems.OptionsView.EnableAppearanceOddRow = True
        Me.gvPurchaseOrderItems.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gvPurchaseOrderItems.OptionsView.ShowDetailButtons = False
        Me.gvPurchaseOrderItems.OptionsView.ShowFooter = True
        Me.gvPurchaseOrderItems.OptionsView.ShowGroupPanel = False
        Me.gvPurchaseOrderItems.ViewCaption = "Purchase Order Items"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Núm. Parte"
        Me.GridColumn2.FieldName = "PartNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 87
        '
        'gcPOIDescription
        '
        Me.gcPOIDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPOIDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPOIDescription.Caption = "Descripción"
        Me.gcPOIDescription.FieldName = "Description"
        Me.gcPOIDescription.Name = "gcPOIDescription"
        Me.gcPOIDescription.OptionsColumn.ReadOnly = True
        Me.gcPOIDescription.Visible = True
        Me.gcPOIDescription.VisibleIndex = 2
        Me.gcPOIDescription.Width = 270
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
        Me.gcPOIUnitPrice.DisplayFormat.FormatString = "c2"
        Me.gcPOIUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPOIUnitPrice.FieldName = "UnitPrice"
        Me.gcPOIUnitPrice.Name = "gcPOIUnitPrice"
        Me.gcPOIUnitPrice.Visible = True
        Me.gcPOIUnitPrice.VisibleIndex = 6
        Me.gcPOIUnitPrice.Width = 76
        '
        'RepositoryItemSpinEditUnitValue
        '
        Me.RepositoryItemSpinEditUnitValue.AutoHeight = False
        Me.RepositoryItemSpinEditUnitValue.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEditUnitValue.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEditUnitValue.Name = "RepositoryItemSpinEditUnitValue"
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
        Me.gcPOINetValue.Caption = "Valor Neto"
        Me.gcPOINetValue.DisplayFormat.FormatString = "c2"
        Me.gcPOINetValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPOINetValue.FieldName = "NetAmount"
        Me.gcPOINetValue.Name = "gcPOINetValue"
        Me.gcPOINetValue.OptionsColumn.AllowEdit = False
        Me.gcPOINetValue.OptionsColumn.ReadOnly = True
        Me.gcPOINetValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetAmount", "{0:c}")})
        Me.gcPOINetValue.Visible = True
        Me.gcPOINetValue.VisibleIndex = 9
        Me.gcPOINetValue.Width = 118
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn11.Caption = "Notes"
        Me.GridColumn11.FieldName = "Notes"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 12
        Me.GridColumn11.Width = 179
        '
        'gcVATRateCode
        '
        Me.gcVATRateCode.Caption = "V.A.T Code"
        Me.gcVATRateCode.FieldName = "UBVatRateCode"
        Me.gcVATRateCode.Name = "gcVATRateCode"
        Me.gcVATRateCode.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.gcVATRateCode.Visible = True
        Me.gcVATRateCode.VisibleIndex = 7
        Me.gcVATRateCode.Width = 109
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "PurchaseOrderID"
        Me.GridColumn1.FieldName = "PurchaseOrderID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cantidad Requerida"
        Me.GridColumn3.ColumnEdit = Me.repoPopupWorkOrder
        Me.GridColumn3.DisplayFormat.FormatString = "N2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "QtyRequired"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 118
        '
        'repoPopupWorkOrder
        '
        Me.repoPopupWorkOrder.AutoHeight = False
        Me.repoPopupWorkOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopupWorkOrder.Name = "repoPopupWorkOrder"
        Me.repoPopupWorkOrder.PopupControl = Me.PopupContainerControl1
        Me.repoPopupWorkOrder.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'gcCoCType
        '
        Me.gcCoCType.Caption = "Tipo Certificación"
        Me.gcCoCType.FieldName = "CoCType"
        Me.gcCoCType.Name = "gcCoCType"
        Me.gcCoCType.Visible = True
        Me.gcCoCType.VisibleIndex = 5
        Me.gcCoCType.Width = 76
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Código Proveedor"
        Me.GridColumn8.FieldName = "SupplierCode"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 107
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cantidad Recibida"
        Me.GridColumn10.DisplayFormat.FormatString = "N2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "TotalQuantityAllocatedReceived"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 79
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn12.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.Caption = "Valor Recibido"
        Me.GridColumn12.DisplayFormat.FormatString = "c2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "TotalValueReceived"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalValueReceived", "{0:c}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 123
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Valor IVA"
        Me.GridColumn16.DisplayFormat.FormatString = "C2"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "VatValue"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VatValue", "{0:C2}")})
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 8
        Me.GridColumn16.Width = 87
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.Caption = "Valor Total"
        Me.GridColumn15.DisplayFormat.FormatString = "N2"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "GrossAmount"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossAmount", "{0:c2}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 11
        Me.GridColumn15.Width = 103
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
        'RepoItemButtonEditStockItem
        '
        Me.RepoItemButtonEditStockItem.AutoHeight = False
        Me.RepoItemButtonEditStockItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.RepoItemButtonEditStockItem.Name = "RepoItemButtonEditStockItem"
        '
        'RepoItemPopupContainerEditQtyReceived
        '
        Me.RepoItemPopupContainerEditQtyReceived.AutoHeight = False
        Me.RepoItemPopupContainerEditQtyReceived.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepoItemPopupContainerEditQtyReceived.DisplayFormat.FormatString = "0.##"
        Me.RepoItemPopupContainerEditQtyReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepoItemPopupContainerEditQtyReceived.Name = "RepoItemPopupContainerEditQtyReceived"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.GroupControl7)
        Me.GroupControl3.Controls.Add(Me.grpPOMaterialType)
        Me.GroupControl3.Controls.Add(Me.btnReloadPODeliveryInfos)
        Me.GroupControl3.Controls.Add(Me.LabelControl15)
        Me.GroupControl3.Controls.Add(Me.GroupControl1)
        Me.GroupControl3.Controls.Add(Me.txtNetValue)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.cboPaymentStatus)
        Me.GroupControl3.Controls.Add(Me.GroupControl2)
        Me.GroupControl3.Controls.Add(Me.lblExchangeRate)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txtExchangeValue)
        Me.GroupControl3.Controls.Add(Me.rgDefaultCurrency)
        Me.GroupControl3.Controls.Add(Me.btePONum)
        Me.GroupControl3.Controls.Add(Me.lblTitle)
        Me.GroupControl3.Controls.Add(Me.btedSupplier)
        Me.GroupControl3.Controls.Add(Me.LabelControl13)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.txtCarriage)
        Me.GroupControl3.Controls.Add(Me.dteDateOfOrder)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Controls.Add(Me.cboCategory)
        Me.GroupControl3.Controls.Add(Me.btnEditPurchaseOrderPDF)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.cboStatus)
        Me.GroupControl3.Controls.Add(Me.cboBuyer)
        Me.GroupControl3.Controls.Add(Me.dteDueDate)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.txtSupplierRef)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Location = New System.Drawing.Point(6, 39)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1552, 357)
        Me.GroupControl3.TabIndex = 248
        Me.GroupControl3.Text = "Detalles del Proveedor"
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.BackColor = System.Drawing.Color.Maroon
        Me.GroupControl7.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl7.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl7.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl7.AppearanceCaption.Options.UseFont = True
        Me.GroupControl7.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.grdPODeliveryInfos)
        Me.GroupControl7.Location = New System.Drawing.Point(1220, 26)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(327, 282)
        Me.GroupControl7.TabIndex = 278
        Me.GroupControl7.Text = "Detalles de Ubicación"
        '
        'grdPODeliveryInfos
        '
        Me.grdPODeliveryInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPODeliveryInfos.Location = New System.Drawing.Point(2, 23)
        Me.grdPODeliveryInfos.MainView = Me.gvPODeliveryInfos
        Me.grdPODeliveryInfos.MenuManager = Me.BarManager1
        Me.grdPODeliveryInfos.Name = "grdPODeliveryInfos"
        Me.grdPODeliveryInfos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdPODeliveryInfos.Size = New System.Drawing.Size(323, 257)
        Me.grdPODeliveryInfos.TabIndex = 268
        Me.grdPODeliveryInfos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPODeliveryInfos})
        '
        'gvPODeliveryInfos
        '
        Me.gvPODeliveryInfos.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvPODeliveryInfos.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPODeliveryInfos.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPODeliveryInfos.Appearance.EvenRow.Options.UseFont = True
        Me.gvPODeliveryInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPODeliveryInfos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPODeliveryInfos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPODeliveryInfos.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPODeliveryInfos.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPODeliveryInfos.Appearance.OddRow.Options.UseFont = True
        Me.gvPODeliveryInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14})
        Me.gvPODeliveryInfos.GridControl = Me.grdPODeliveryInfos
        Me.gvPODeliveryInfos.Name = "gvPODeliveryInfos"
        Me.gvPODeliveryInfos.OptionsBehavior.ReadOnly = True
        Me.gvPODeliveryInfos.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPODeliveryInfos.OptionsView.EnableAppearanceOddRow = True
        Me.gvPODeliveryInfos.OptionsView.ShowDetailButtons = False
        Me.gvPODeliveryInfos.OptionsView.ShowGroupPanel = False
        Me.gvPODeliveryInfos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn13, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "# Recepción"
        Me.GridColumn13.FieldName = "GRNumber"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 97
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Fecha de Recepción"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn14.FieldName = "DateCreated"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 227
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'grpPOMaterialType
        '
        Me.grpPOMaterialType.AppearanceCaption.BackColor = System.Drawing.Color.Maroon
        Me.grpPOMaterialType.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpPOMaterialType.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpPOMaterialType.AppearanceCaption.Options.UseBackColor = True
        Me.grpPOMaterialType.AppearanceCaption.Options.UseFont = True
        Me.grpPOMaterialType.AppearanceCaption.Options.UseForeColor = True
        Me.grpPOMaterialType.Controls.Add(Me.xtabPOReqType)
        Me.grpPOMaterialType.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Inv.", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Senc.", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, CType(2, Short), -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Mult.", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, 3, -1)})
        Me.grpPOMaterialType.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpPOMaterialType.Location = New System.Drawing.Point(802, 26)
        Me.grpPOMaterialType.Name = "grpPOMaterialType"
        Me.grpPOMaterialType.Size = New System.Drawing.Size(414, 282)
        Me.grpPOMaterialType.TabIndex = 277
        Me.grpPOMaterialType.Text = "Referencia de Compra"
        '
        'xtabPOReqType
        '
        Me.xtabPOReqType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtabPOReqType.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtabPOReqType.Location = New System.Drawing.Point(2, 26)
        Me.xtabPOReqType.Name = "xtabPOReqType"
        Me.xtabPOReqType.SelectedTabPage = Me.xtpInventory
        Me.xtabPOReqType.Size = New System.Drawing.Size(410, 254)
        Me.xtabPOReqType.TabIndex = 272
        Me.xtabPOReqType.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpInventory, Me.xtpSingle, Me.xtpMultiple})
        '
        'xtpInventory
        '
        Me.xtpInventory.Controls.Add(Me.PanelControl1)
        Me.xtpInventory.Name = "xtpInventory"
        Me.xtpInventory.Size = New System.Drawing.Size(381, 248)
        Me.xtpInventory.Text = "Inv."
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(381, 248)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(20, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(265, 14)
        Me.LabelControl6.TabIndex = 277
        Me.LabelControl6.Text = "Materiales de esta Compra directos a Inventario"
        '
        'xtpSingle
        '
        Me.xtpSingle.Controls.Add(Me.GroupControl5)
        Me.xtpSingle.Name = "xtpSingle"
        Me.xtpSingle.Size = New System.Drawing.Size(381, 248)
        Me.xtpSingle.Text = "Senc."
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl5.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.dteDateRequired)
        Me.GroupControl5.Controls.Add(Me.LabelControl17)
        Me.GroupControl5.Controls.Add(Me.LabelControl16)
        Me.GroupControl5.Controls.Add(Me.LabelControl8)
        Me.GroupControl5.Controls.Add(Me.LabelControl7)
        Me.GroupControl5.Controls.Add(Me.txtCustomerName)
        Me.GroupControl5.Controls.Add(Me.txtProjectName)
        Me.GroupControl5.Controls.Add(Me.btedSOPhase)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.ShowCaption = False
        Me.GroupControl5.Size = New System.Drawing.Size(381, 248)
        Me.GroupControl5.TabIndex = 268
        Me.GroupControl5.Text = "Admon. OTs"
        '
        'dteDateRequired
        '
        Me.dteDateRequired.EditValue = Nothing
        Me.dteDateRequired.Location = New System.Drawing.Point(140, 152)
        Me.dteDateRequired.MenuManager = Me.BarManager1
        Me.dteDateRequired.Name = "dteDateRequired"
        Me.dteDateRequired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDateRequired.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDateRequired.Properties.NullDate = New Date(CType(0, Long))
        Me.dteDateRequired.Properties.ReadOnly = True
        Me.dteDateRequired.Size = New System.Drawing.Size(155, 20)
        Me.dteDateRequired.TabIndex = 281
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(21, 155)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(82, 14)
        Me.LabelControl17.TabIndex = 280
        Me.LabelControl17.Text = "Fecha Requerida"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(21, 111)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl16.TabIndex = 279
        Me.LabelControl16.Text = "Cliente"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(21, 67)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl8.TabIndex = 278
        Me.LabelControl8.Text = "Proyecto"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(21, 23)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(108, 14)
        Me.LabelControl7.TabIndex = 277
        Me.LabelControl7.Text = "Referencia de Etapa"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(140, 108)
        Me.txtCustomerName.MenuManager = Me.BarManager1
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCustomerName.Properties.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(155, 20)
        Me.txtCustomerName.TabIndex = 263
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(140, 64)
        Me.txtProjectName.MenuManager = Me.BarManager1
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtProjectName.Properties.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(155, 20)
        Me.txtProjectName.TabIndex = 262
        '
        'btedSOPhase
        '
        Me.btedSOPhase.Location = New System.Drawing.Point(140, 19)
        Me.btedSOPhase.MenuManager = Me.BarManager1
        Me.btedSOPhase.Name = "btedSOPhase"
        Me.btedSOPhase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btedSOPhase.Properties.ReadOnly = True
        Me.btedSOPhase.Size = New System.Drawing.Size(155, 20)
        Me.btedSOPhase.TabIndex = 246
        '
        'xtpMultiple
        '
        Me.xtpMultiple.Controls.Add(Me.GroupControl4)
        Me.xtpMultiple.Name = "xtpMultiple"
        Me.xtpMultiple.Size = New System.Drawing.Size(381, 248)
        Me.xtpMultiple.Text = "Mult."
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.btnManageCOs)
        Me.GroupControl4.Controls.Add(Me.grdWOs)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(381, 248)
        Me.GroupControl4.TabIndex = 267
        Me.GroupControl4.Text = "Admon. OTs"
        '
        'btnManageCOs
        '
        Me.btnManageCOs.Location = New System.Drawing.Point(5, 194)
        Me.btnManageCOs.Name = "btnManageCOs"
        Me.btnManageCOs.Size = New System.Drawing.Size(125, 23)
        Me.btnManageCOs.TabIndex = 267
        Me.btnManageCOs.Text = "Seleccionar Fases"
        '
        'grdWOs
        '
        Me.grdWOs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdWOs.Location = New System.Drawing.Point(5, 5)
        Me.grdWOs.MainView = Me.gvWOs
        Me.grdWOs.MenuManager = Me.BarManager1
        Me.grdWOs.Name = "grdWOs"
        Me.grdWOs.Size = New System.Drawing.Size(371, 180)
        Me.grdWOs.TabIndex = 266
        Me.grdWOs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWOs})
        '
        'gvWOs
        '
        Me.gvWOs.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvWOs.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWOs.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvWOs.Appearance.EvenRow.Options.UseFont = True
        Me.gvWOs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWOs.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWOs.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvWOs.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWOs.Appearance.OddRow.Options.UseBackColor = True
        Me.gvWOs.Appearance.OddRow.Options.UseFont = True
        Me.gvWOs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcCallOff, Me.GridColumn5})
        Me.gvWOs.GridControl = Me.grdWOs
        Me.gvWOs.Name = "gvWOs"
        Me.gvWOs.OptionsBehavior.ReadOnly = True
        Me.gvWOs.OptionsView.EnableAppearanceEvenRow = True
        Me.gvWOs.OptionsView.EnableAppearanceOddRow = True
        Me.gvWOs.OptionsView.ShowDetailButtons = False
        Me.gvWOs.OptionsView.ShowGroupPanel = False
        Me.gvWOs.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcCallOff, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gcCallOff
        '
        Me.gcCallOff.Caption = "OT Núm."
        Me.gcCallOff.FieldName = "WorkOrderNo"
        Me.gcCallOff.Name = "gcCallOff"
        Me.gcCallOff.Visible = True
        Me.gcCallOff.VisibleIndex = 0
        Me.gcCallOff.Width = 97
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Descripción"
        Me.GridColumn5.FieldName = "Description"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 227
        '
        'btnReloadPODeliveryInfos
        '
        Me.btnReloadPODeliveryInfos.Location = New System.Drawing.Point(1019, 329)
        Me.btnReloadPODeliveryInfos.Name = "btnReloadPODeliveryInfos"
        Me.btnReloadPODeliveryInfos.Size = New System.Drawing.Size(119, 23)
        Me.btnReloadPODeliveryInfos.TabIndex = 267
        Me.btnReloadPODeliveryInfos.Text = "Cargar Recepciones"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(262, 39)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl15.TabIndex = 276
        Me.LabelControl15.Text = "Valor Neto"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.BackColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.uctDeliveryAddress)
        Me.GroupControl1.Location = New System.Drawing.Point(494, 169)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(302, 139)
        Me.GroupControl1.TabIndex = 254
        Me.GroupControl1.Text = "Datos de Entrega"
        '
        'uctDeliveryAddress
        '
        Me.uctDeliveryAddress.Address = Nothing
        Me.uctDeliveryAddress.ControlsReadOnly = False
        Me.uctDeliveryAddress.Location = New System.Drawing.Point(5, 26)
        Me.uctDeliveryAddress.MainLabel = Nothing
        Me.uctDeliveryAddress.Name = "uctDeliveryAddress"
        Me.uctDeliveryAddress.Size = New System.Drawing.Size(292, 106)
        Me.uctDeliveryAddress.TabIndex = 1
        Me.uctDeliveryAddress.ThirdAddressLine = False
        '
        'txtNetValue
        '
        Me.txtNetValue.EditValue = ""
        Me.txtNetValue.Location = New System.Drawing.Point(352, 32)
        Me.txtNetValue.MenuManager = Me.BarManager1
        Me.txtNetValue.Name = "txtNetValue"
        Me.txtNetValue.Properties.ReadOnly = True
        Me.txtNetValue.Size = New System.Drawing.Size(128, 20)
        Me.txtNetValue.TabIndex = 275
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(17, 244)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(77, 14)
        Me.LabelControl14.TabIndex = 273
        Me.LabelControl14.Text = "Estado del Pago"
        '
        'cboPaymentStatus
        '
        Me.cboPaymentStatus.Location = New System.Drawing.Point(107, 241)
        Me.cboPaymentStatus.MenuManager = Me.BarManager1
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPaymentStatus.Size = New System.Drawing.Size(128, 20)
        Me.cboPaymentStatus.TabIndex = 274
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.BackColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.UctAddress1)
        Me.GroupControl2.Location = New System.Drawing.Point(494, 28)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(302, 140)
        Me.GroupControl2.TabIndex = 253
        Me.GroupControl2.Text = "Detalles de Ubicación"
        '
        'UctAddress1
        '
        Me.UctAddress1.Address = Nothing
        Me.UctAddress1.BackColor = System.Drawing.Color.White
        Me.UctAddress1.ControlsReadOnly = True
        Me.UctAddress1.Location = New System.Drawing.Point(5, 25)
        Me.UctAddress1.MainLabel = Nothing
        Me.UctAddress1.Name = "UctAddress1"
        Me.UctAddress1.Size = New System.Drawing.Size(292, 110)
        Me.UctAddress1.TabIndex = 1
        Me.UctAddress1.ThirdAddressLine = False
        '
        'lblExchangeRate
        '
        Me.lblExchangeRate.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblExchangeRate.Appearance.Options.UseFont = True
        Me.lblExchangeRate.Location = New System.Drawing.Point(258, 247)
        Me.lblExchangeRate.Name = "lblExchangeRate"
        Me.lblExchangeRate.Size = New System.Drawing.Size(77, 14)
        Me.lblExchangeRate.TabIndex = 271
        Me.lblExchangeRate.Text = "Tasa de Cambio"
        Me.lblExchangeRate.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(258, 220)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl9.TabIndex = 270
        Me.LabelControl9.Text = "Moneda"
        '
        'txtExchangeValue
        '
        Me.txtExchangeValue.Location = New System.Drawing.Point(352, 244)
        Me.txtExchangeValue.MenuManager = Me.BarManager1
        Me.txtExchangeValue.Name = "txtExchangeValue"
        Me.txtExchangeValue.Properties.Mask.EditMask = "n4"
        Me.txtExchangeValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExchangeValue.Size = New System.Drawing.Size(128, 20)
        Me.txtExchangeValue.TabIndex = 269
        Me.txtExchangeValue.Visible = False
        '
        'rgDefaultCurrency
        '
        Me.rgDefaultCurrency.Location = New System.Drawing.Point(352, 216)
        Me.rgDefaultCurrency.Name = "rgDefaultCurrency"
        Me.rgDefaultCurrency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.rgDefaultCurrency.Properties.Appearance.Options.UseBackColor = True
        Me.rgDefaultCurrency.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "USD"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "C$")})
        Me.rgDefaultCurrency.Size = New System.Drawing.Size(128, 22)
        Me.rgDefaultCurrency.TabIndex = 268
        '
        'btePONum
        '
        Me.btePONum.Location = New System.Drawing.Point(107, 32)
        Me.btePONum.Name = "btePONum"
        Me.btePONum.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btePONum.Properties.Appearance.Options.UseFont = True
        Me.btePONum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.btePONum.Properties.ReadOnly = True
        Me.btePONum.Size = New System.Drawing.Size(128, 20)
        Me.btePONum.TabIndex = 265
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseForeColor = True
        Me.lblTitle.Location = New System.Drawing.Point(17, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(43, 18)
        Me.lblTitle.TabIndex = 244
        Me.lblTitle.Text = "# O.C."
        '
        'btedSupplier
        '
        Me.btedSupplier.Location = New System.Drawing.Point(107, 70)
        Me.btedSupplier.MenuManager = Me.BarManager1
        Me.btedSupplier.Name = "btedSupplier"
        Me.btedSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btedSupplier.Size = New System.Drawing.Size(128, 20)
        Me.btedSupplier.TabIndex = 245
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(258, 115)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl13.TabIndex = 262
        Me.LabelControl13.Text = "Transporte"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(17, 74)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl1.TabIndex = 246
        Me.LabelControl1.Text = "Proveedor"
        '
        'txtCarriage
        '
        Me.txtCarriage.Location = New System.Drawing.Point(352, 108)
        Me.txtCarriage.MenuManager = Me.BarManager1
        Me.txtCarriage.Name = "txtCarriage"
        Me.txtCarriage.Properties.Mask.EditMask = "n2"
        Me.txtCarriage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCarriage.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCarriage.Size = New System.Drawing.Size(128, 20)
        Me.txtCarriage.TabIndex = 261
        '
        'dteDateOfOrder
        '
        Me.dteDateOfOrder.EditValue = Nothing
        Me.dteDateOfOrder.Location = New System.Drawing.Point(352, 70)
        Me.dteDateOfOrder.MenuManager = Me.BarManager1
        Me.dteDateOfOrder.Name = "dteDateOfOrder"
        Me.dteDateOfOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDateOfOrder.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDateOfOrder.Size = New System.Drawing.Size(128, 20)
        Me.dteDateOfOrder.TabIndex = 253
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(17, 145)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 14)
        Me.LabelControl2.TabIndex = 247
        Me.LabelControl2.Text = "Categoría"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(17, 211)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl12.TabIndex = 260
        Me.LabelControl12.Text = "Generar O.C."
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(107, 138)
        Me.cboCategory.MenuManager = Me.BarManager1
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Size = New System.Drawing.Size(128, 20)
        Me.cboCategory.TabIndex = 248
        '
        'btnEditPurchaseOrderPDF
        '
        Me.btnEditPurchaseOrderPDF.Location = New System.Drawing.Point(107, 204)
        Me.btnEditPurchaseOrderPDF.Name = "btnEditPurchaseOrderPDF"
        Me.btnEditPurchaseOrderPDF.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPurchaseOrderPDF.Properties.Appearance.Options.UseFont = True
        Me.btnEditPurchaseOrderPDF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnEditPurchaseOrderPDF.Properties.ReadOnly = True
        Me.btnEditPurchaseOrderPDF.Size = New System.Drawing.Size(128, 20)
        Me.btnEditPurchaseOrderPDF.TabIndex = 259
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(17, 178)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl3.TabIndex = 249
        Me.LabelControl3.Text = "Estado"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(258, 183)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl11.TabIndex = 258
        Me.LabelControl11.Text = "Comprador"
        '
        'cboStatus
        '
        Me.cboStatus.Location = New System.Drawing.Point(107, 171)
        Me.cboStatus.MenuManager = Me.BarManager1
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Size = New System.Drawing.Size(128, 20)
        Me.cboStatus.TabIndex = 250
        '
        'cboBuyer
        '
        Me.cboBuyer.Location = New System.Drawing.Point(352, 180)
        Me.cboBuyer.MenuManager = Me.BarManager1
        Me.cboBuyer.Name = "cboBuyer"
        Me.cboBuyer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuyer.Size = New System.Drawing.Size(128, 20)
        Me.cboBuyer.TabIndex = 257
        '
        'dteDueDate
        '
        Me.dteDueDate.EditValue = Nothing
        Me.dteDueDate.Location = New System.Drawing.Point(352, 143)
        Me.dteDueDate.MenuManager = Me.BarManager1
        Me.dteDueDate.Name = "dteDueDate"
        Me.dteDueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDueDate.Size = New System.Drawing.Size(128, 20)
        Me.dteDueDate.TabIndex = 251
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(17, 112)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(48, 14)
        Me.LabelControl10.TabIndex = 256
        Me.LabelControl10.Text = "Ref. Prov."
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(258, 150)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 14)
        Me.LabelControl4.TabIndex = 252
        Me.LabelControl4.Text = "Fecha Requerida"
        '
        'txtSupplierRef
        '
        Me.txtSupplierRef.EditValue = ""
        Me.txtSupplierRef.Location = New System.Drawing.Point(107, 105)
        Me.txtSupplierRef.MenuManager = Me.BarManager1
        Me.txtSupplierRef.Name = "txtSupplierRef"
        Me.txtSupplierRef.Size = New System.Drawing.Size(128, 20)
        Me.txtSupplierRef.TabIndex = 255
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(258, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 14)
        Me.LabelControl5.TabIndex = 254
        Me.LabelControl5.Text = "Fecha de Órden"
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1570, 804)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.gpnlPOItems)
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
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpnlPOItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpnlPOItems.ResumeLayout(False)
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grdWorkOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorkOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopPutWorkOrderQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPurchaseOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEditUnitValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemPopupContainerEditPOItemAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemButtonEditStockItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemPopupContainerEditQtyReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grdPODeliveryInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPODeliveryInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPOMaterialType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPOMaterialType.ResumeLayout(False)
        CType(Me.xtabPOReqType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabPOReqType.ResumeLayout(False)
        Me.xtpInventory.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.xtpSingle.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.dteDateRequired.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDateRequired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btedSOPhase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMultiple.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grdWOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtNetValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtExchangeValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgDefaultCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btePONum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btedSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarriage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDateOfOrder.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDateOfOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditPurchaseOrderPDF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gpnlPOItems As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPurchaseOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPurchaseOrderItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPOIDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPOIUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEditUnitValue As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents gcPOINetValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcVATRateCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoItemPopupContainerEditPOItemAllocation As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepoItemButtonEditStockItem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepoItemPopupContainerEditQtyReceived As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btePONum As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btedSupplier As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCarriage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteDateOfOrder As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnEditPurchaseOrderPDF As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboBuyer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dteDueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcCoCType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdWorkOrderItem As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvWorkOrderItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoPopPutWorkOrderQty As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdWOs As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvWOs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcCallOff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnManageCOs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repoPopupWorkOrder As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSendPOEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblExchangeRate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExchangeValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgDefaultCurrency As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents xtabPOReqType As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpMultiple As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpSingle As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents uctDeliveryAddress As uctAddress
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPaymentStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNetValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPODelivery As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnReloadPODeliveryInfos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdPODeliveryInfos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPODeliveryInfos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents UctAddress1 As uctAddress
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpPOMaterialType As DevExpress.XtraEditors.GroupControl
    Friend WithEvents xtpInventory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btedSOPhase As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dteDateRequired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
