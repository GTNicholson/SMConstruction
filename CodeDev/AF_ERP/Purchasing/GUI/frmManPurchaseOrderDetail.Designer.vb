﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManPurchaseOrderDetail
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
        Dim ButtonImageOptions5 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions6 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions7 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions8 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManPurchaseOrderDetail))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
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
        Me.popupPOI = New DevExpress.XtraEditors.PopupContainerControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grdPOIWorkOrderAllocation = New DevExpress.XtraGrid.GridControl()
        Me.gvPOIWorkOrderInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcPOItemCallOff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcItemQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcWOAItemRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoSelectWOAllocation = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.gcWorkOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcItemRef2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSalesOrderPhaseItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdPurchaseOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.gvPurchaseOrderItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcPartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPOIDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPOIUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEditUnitValue = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcPOINetValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gcNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcVATRateCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRequiredQuantityMultiple = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopupWorkOrder = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.gcCoCType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcReceivedQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRequiredQuantitySimple = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repitQtyReqSimp = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gcUoM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRetentionValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRequiredQuantitySimpleWO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRequiredQuantityMultipleWO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPopupPOItem = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepoItemPopupContainerEditPOItemAllocation = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepoItemButtonEditStockItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepoItemPopupContainerEditQtyReceived = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repoPopupWorkOrderAllocation = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.repoWOAllocationSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.repoPopupWOAllocationSelect = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.rgCompanyOption = New DevExpress.XtraEditors.RadioGroup()
        Me.grpWorkOrderType = New DevExpress.XtraEditors.GroupControl()
        Me.xtabPOReqTypeWO = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpInventoryWO = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpSingleWO = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.grdPurchaseOrderWorkOrderBudget = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dteRequiredDateWO = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCustomerNameWO = New DevExpress.XtraEditors.TextEdit()
        Me.txtProjectNameWO = New DevExpress.XtraEditors.TextEdit()
        Me.btnSelectWorkOrder = New DevExpress.XtraEditors.ButtonEdit()
        Me.xtpMultipleWO = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSelectMultipleWO = New DevExpress.XtraEditors.SimpleButton()
        Me.grdPOIWorkOrderInfo = New DevExpress.XtraGrid.GridControl()
        Me.gvWorkOrderInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.dtePaymentDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.cboValuationMode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtRetentionPercentage = New DevExpress.XtraEditors.TextEdit()
        Me.lblRetention = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.cboStage = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.cboAccountingCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckeAccountOrder = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtratabPODelivery = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.grdPODeliveryInfos = New DevExpress.XtraGrid.GridControl()
        Me.gvPODeliveryInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoPODelivery = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.gcPODeliveryValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtraTabAppendDoc = New DevExpress.XtraTab.XtraTabPage()
        Me.UctFileControl1 = New AgroForestal.uctFileControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPaymentMethod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.uctDeliveryAddress = New AgroForestal.uctAddress()
        Me.txtNetValue = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.UctAddress1 = New AgroForestal.uctAddress()
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
        CType(Me.popupPOI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupPOI.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.grdPOIWorkOrderAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOIWorkOrderInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoSelectWOAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPurchaseOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEditUnitValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repitQtyReqSimp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupPOItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemPopupContainerEditPOItemAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemButtonEditStockItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemPopupContainerEditQtyReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupWorkOrderAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoWOAllocationSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPopupWOAllocationSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.rgCompanyOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpWorkOrderType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWorkOrderType.SuspendLayout()
        CType(Me.xtabPOReqTypeWO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabPOReqTypeWO.SuspendLayout()
        Me.xtpInventoryWO.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.xtpSingleWO.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.grdPurchaseOrderWorkOrderBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteRequiredDateWO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteRequiredDateWO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerNameWO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectNameWO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelectWorkOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMultipleWO.SuspendLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.grdPOIWorkOrderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorkOrderInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePaymentDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtePaymentDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboValuationMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetentionPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAccountingCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeAccountOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtratabPODelivery.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grdPODeliveryInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPODeliveryInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoPODelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtraTabAppendDoc.SuspendLayout()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPaymentMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNetValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1841, 33)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 804)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1841, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1841, 33)
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
        Me.gpnlPOItems.Controls.Add(Me.popupPOI)
        Me.gpnlPOItems.Controls.Add(Me.grdPurchaseOrderItems)
        ButtonImageOptions5.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ButtonImageOptions6.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ButtonImageOptions7.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        Me.gpnlPOItems.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Artículo", True, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "AddStockItem", 0), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar Item Manual", True, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "ManualItem", 3), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar Artículo", True, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "DeleteItem", 2), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Recibir Item Manual", True, ButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "ProcessManualItem", -1)})
        Me.gpnlPOItems.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gpnlPOItems.Location = New System.Drawing.Point(6, 417)
        Me.gpnlPOItems.Name = "gpnlPOItems"
        Me.gpnlPOItems.Size = New System.Drawing.Size(1647, 375)
        Me.gpnlPOItems.TabIndex = 243
        Me.gpnlPOItems.Text = "Artículos de Compra"
        '
        'popupPOI
        '
        Me.popupPOI.Controls.Add(Me.PanelControl4)
        Me.popupPOI.Location = New System.Drawing.Point(359, 120)
        Me.popupPOI.Name = "popupPOI"
        Me.popupPOI.Size = New System.Drawing.Size(345, 171)
        Me.popupPOI.TabIndex = 269
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.grdPOIWorkOrderAllocation)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(345, 171)
        Me.PanelControl4.TabIndex = 0
        '
        'grdPOIWorkOrderAllocation
        '
        Me.grdPOIWorkOrderAllocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.grdPOIWorkOrderAllocation.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdPOIWorkOrderAllocation.Location = New System.Drawing.Point(2, 2)
        Me.grdPOIWorkOrderAllocation.MainView = Me.gvPOIWorkOrderInfos
        Me.grdPOIWorkOrderAllocation.MenuManager = Me.BarManager1
        Me.grdPOIWorkOrderAllocation.Name = "grdPOIWorkOrderAllocation"
        Me.grdPOIWorkOrderAllocation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoSelectWOAllocation})
        Me.grdPOIWorkOrderAllocation.Size = New System.Drawing.Size(341, 167)
        Me.grdPOIWorkOrderAllocation.TabIndex = 0
        Me.grdPOIWorkOrderAllocation.UseEmbeddedNavigator = True
        Me.grdPOIWorkOrderAllocation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOIWorkOrderInfos})
        '
        'gvPOIWorkOrderInfos
        '
        Me.gvPOIWorkOrderInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPOIWorkOrderInfos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPOIWorkOrderInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPOItemCallOff, Me.gcItemQuantity, Me.GridColumn24, Me.gcWOAItemRef, Me.gcWorkOrderID, Me.gcItemRef2, Me.gcSalesOrderPhaseItemID})
        Me.gvPOIWorkOrderInfos.GridControl = Me.grdPOIWorkOrderAllocation
        Me.gvPOIWorkOrderInfos.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.gcItemQuantity, "N2")})
        Me.gvPOIWorkOrderInfos.Name = "gvPOIWorkOrderInfos"
        Me.gvPOIWorkOrderInfos.OptionsView.ShowFooter = True
        Me.gvPOIWorkOrderInfos.OptionsView.ShowGroupPanel = False
        '
        'gcPOItemCallOff
        '
        Me.gcPOItemCallOff.Caption = "Sales Order Phase"
        Me.gcPOItemCallOff.FieldName = "CallOffID"
        Me.gcPOItemCallOff.Name = "gcPOItemCallOff"
        Me.gcPOItemCallOff.Width = 128
        '
        'gcItemQuantity
        '
        Me.gcItemQuantity.Caption = "Cantidad"
        Me.gcItemQuantity.DisplayFormat.FormatString = "n3"
        Me.gcItemQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcItemQuantity.FieldName = "gcItemQuantity"
        Me.gcItemQuantity.GroupFormat.FormatString = "n3"
        Me.gcItemQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcItemQuantity.Name = "gcItemQuantity"
        Me.gcItemQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")})
        Me.gcItemQuantity.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.gcItemQuantity.Visible = True
        Me.gcItemQuantity.VisibleIndex = 1
        Me.gcItemQuantity.Width = 131
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Proyecto"
        Me.GridColumn24.FieldName = "ProjectRef"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Width = 140
        '
        'gcWOAItemRef
        '
        Me.gcWOAItemRef.Caption = "#O.T."
        Me.gcWOAItemRef.ColumnEdit = Me.repoSelectWOAllocation
        Me.gcWOAItemRef.FieldName = "WorkOrderID"
        Me.gcWOAItemRef.Name = "gcWOAItemRef"
        Me.gcWOAItemRef.Width = 86
        '
        'repoSelectWOAllocation
        '
        Me.repoSelectWOAllocation.AutoHeight = False
        Me.repoSelectWOAllocation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.repoSelectWOAllocation.Name = "repoSelectWOAllocation"
        '
        'gcWorkOrderID
        '
        Me.gcWorkOrderID.Caption = "#O.T."
        Me.gcWorkOrderID.FieldName = "WorkOrderID"
        Me.gcWorkOrderID.Name = "gcWorkOrderID"
        Me.gcWorkOrderID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcWorkOrderID.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcWorkOrderID.Visible = True
        Me.gcWorkOrderID.VisibleIndex = 0
        Me.gcWorkOrderID.Width = 191
        '
        'gcItemRef2
        '
        Me.gcItemRef2.Caption = "Descripción"
        Me.gcItemRef2.FieldName = "gcItemRef2"
        Me.gcItemRef2.Name = "gcItemRef2"
        Me.gcItemRef2.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcItemRef2.Width = 205
        '
        'gcSalesOrderPhaseItemID
        '
        Me.gcSalesOrderPhaseItemID.Caption = "GridColumn6"
        Me.gcSalesOrderPhaseItemID.FieldName = "SalesOrderPhaseItemID"
        Me.gcSalesOrderPhaseItemID.Name = "gcSalesOrderPhaseItemID"
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
        Me.grdPurchaseOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoItemPopupContainerEditPOItemAllocation, Me.RepoItemButtonEditStockItem, Me.RepositoryItemSpinEditUnitValue, Me.RepoItemPopupContainerEditQtyReceived, Me.repoPopupWorkOrder, Me.repitQtyReqSimp, Me.RepositoryItemTextEdit1, Me.repoPopupWorkOrderAllocation, Me.repoWOAllocationSelect, Me.repoPopupWOAllocationSelect, Me.repoPopupPOItem, Me.RepositoryItemTextEdit2})
        Me.grdPurchaseOrderItems.Size = New System.Drawing.Size(1643, 347)
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
        Me.gvPurchaseOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPartNo, Me.gcPOIDescription, Me.gcPOIUnitPrice, Me.gcPOINetValue, Me.gcNotes, Me.gcVATRateCode, Me.GridColumn1, Me.gcRequiredQuantityMultiple, Me.gcCoCType, Me.gcSupplierCode, Me.gcReceivedQuantity, Me.GridColumn12, Me.GridColumn16, Me.GridColumn15, Me.gcStockCode, Me.gcRequiredQuantitySimple, Me.gcUoM, Me.gcRetentionValue, Me.gcRequiredQuantitySimpleWO, Me.gcRequiredQuantityMultipleWO})
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
        'gcPartNo
        '
        Me.gcPartNo.Caption = "Núm. Parte"
        Me.gcPartNo.FieldName = "PartNo"
        Me.gcPartNo.Name = "gcPartNo"
        Me.gcPartNo.Visible = True
        Me.gcPartNo.VisibleIndex = 2
        Me.gcPartNo.Width = 84
        '
        'gcPOIDescription
        '
        Me.gcPOIDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPOIDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPOIDescription.Caption = "Descripción"
        Me.gcPOIDescription.FieldName = "Description"
        Me.gcPOIDescription.Name = "gcPOIDescription"
        Me.gcPOIDescription.Visible = True
        Me.gcPOIDescription.VisibleIndex = 3
        Me.gcPOIDescription.Width = 267
        '
        'gcPOIUnitPrice
        '
        Me.gcPOIUnitPrice.AppearanceCell.Options.UseTextOptions = True
        Me.gcPOIUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcPOIUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPOIUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcPOIUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPOIUnitPrice.Caption = "Precio Unitario"
        Me.gcPOIUnitPrice.ColumnEdit = Me.RepositoryItemSpinEditUnitValue
        Me.gcPOIUnitPrice.DisplayFormat.FormatString = "c2"
        Me.gcPOIUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPOIUnitPrice.FieldName = "UnitPrice"
        Me.gcPOIUnitPrice.Name = "gcPOIUnitPrice"
        Me.gcPOIUnitPrice.Visible = True
        Me.gcPOIUnitPrice.VisibleIndex = 8
        Me.gcPOIUnitPrice.Width = 82
        '
        'RepositoryItemSpinEditUnitValue
        '
        Me.RepositoryItemSpinEditUnitValue.AutoHeight = False
        Me.RepositoryItemSpinEditUnitValue.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemSpinEditUnitValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEditUnitValue.EditFormat.FormatString = "n2"
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
        Me.gcPOINetValue.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.gcPOINetValue.DisplayFormat.FormatString = "C2"
        Me.gcPOINetValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPOINetValue.FieldName = "NetAmount"
        Me.gcPOINetValue.Name = "gcPOINetValue"
        Me.gcPOINetValue.OptionsColumn.AllowEdit = False
        Me.gcPOINetValue.OptionsColumn.ReadOnly = True
        Me.gcPOINetValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetAmount", "{0:n2}")})
        Me.gcPOINetValue.Visible = True
        Me.gcPOINetValue.VisibleIndex = 12
        Me.gcPOINetValue.Width = 106
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.EditFormat.FormatString = "n2"
        Me.RepositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'gcNotes
        '
        Me.gcNotes.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNotes.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcNotes.Caption = "Notes"
        Me.gcNotes.FieldName = "Notes"
        Me.gcNotes.Name = "gcNotes"
        Me.gcNotes.Width = 179
        '
        'gcVATRateCode
        '
        Me.gcVATRateCode.Caption = "V.A.T Code"
        Me.gcVATRateCode.FieldName = "UBVatRateCode"
        Me.gcVATRateCode.Name = "gcVATRateCode"
        Me.gcVATRateCode.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.gcVATRateCode.Visible = True
        Me.gcVATRateCode.VisibleIndex = 9
        Me.gcVATRateCode.Width = 96
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "PurchaseOrderID"
        Me.GridColumn1.FieldName = "PurchaseOrderID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'gcRequiredQuantityMultiple
        '
        Me.gcRequiredQuantityMultiple.Caption = "Cantidad Requerida"
        Me.gcRequiredQuantityMultiple.ColumnEdit = Me.repoPopupWorkOrder
        Me.gcRequiredQuantityMultiple.DisplayFormat.FormatString = "N2"
        Me.gcRequiredQuantityMultiple.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRequiredQuantityMultiple.FieldName = "QtyRequired"
        Me.gcRequiredQuantityMultiple.Name = "gcRequiredQuantityMultiple"
        Me.gcRequiredQuantityMultiple.Width = 111
        '
        'repoPopupWorkOrder
        '
        Me.repoPopupWorkOrder.AutoHeight = False
        Me.repoPopupWorkOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopupWorkOrder.Name = "repoPopupWorkOrder"
        Me.repoPopupWorkOrder.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'gcCoCType
        '
        Me.gcCoCType.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.gcCoCType.AppearanceCell.Options.UseBackColor = True
        Me.gcCoCType.Caption = "Tipo Certificación"
        Me.gcCoCType.FieldName = "CoCType"
        Me.gcCoCType.Name = "gcCoCType"
        Me.gcCoCType.Width = 65
        '
        'gcSupplierCode
        '
        Me.gcSupplierCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.gcSupplierCode.AppearanceCell.Options.UseBackColor = True
        Me.gcSupplierCode.Caption = "Código Proveedor"
        Me.gcSupplierCode.FieldName = "SupplierCode"
        Me.gcSupplierCode.Name = "gcSupplierCode"
        Me.gcSupplierCode.Visible = True
        Me.gcSupplierCode.VisibleIndex = 1
        Me.gcSupplierCode.Width = 106
        '
        'gcReceivedQuantity
        '
        Me.gcReceivedQuantity.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcReceivedQuantity.AppearanceCell.Options.UseBackColor = True
        Me.gcReceivedQuantity.Caption = "Cantidad Recibida"
        Me.gcReceivedQuantity.DisplayFormat.FormatString = "N2"
        Me.gcReceivedQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcReceivedQuantity.FieldName = "TotalQuantityAllocatedReceived"
        Me.gcReceivedQuantity.Name = "gcReceivedQuantity"
        Me.gcReceivedQuantity.OptionsColumn.ReadOnly = True
        Me.gcReceivedQuantity.Visible = True
        Me.gcReceivedQuantity.VisibleIndex = 6
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
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn12.DisplayFormat.FormatString = "c2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "TotalValueReceived"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalValueReceived", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 13
        Me.GridColumn12.Width = 130
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn16.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn16.Caption = "Valor IVA"
        Me.GridColumn16.ColumnEdit = Me.RepositoryItemSpinEditUnitValue
        Me.GridColumn16.DisplayFormat.FormatString = "n2"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "VATAmount"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VATAmount", "{0:n2}")})
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 10
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
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn15.DisplayFormat.FormatString = "N2"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "GrossAmount"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossAmount", "{0:n2}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        Me.GridColumn15.Width = 144
        '
        'gcStockCode
        '
        Me.gcStockCode.Caption = "Código Agro"
        Me.gcStockCode.FieldName = "gcStockCode"
        Me.gcStockCode.Name = "gcStockCode"
        Me.gcStockCode.OptionsColumn.ReadOnly = True
        Me.gcStockCode.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.gcStockCode.Visible = True
        Me.gcStockCode.VisibleIndex = 0
        '
        'gcRequiredQuantitySimple
        '
        Me.gcRequiredQuantitySimple.Caption = "Cantidad Requerida"
        Me.gcRequiredQuantitySimple.ColumnEdit = Me.repitQtyReqSimp
        Me.gcRequiredQuantitySimple.DisplayFormat.FormatString = "N2"
        Me.gcRequiredQuantitySimple.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRequiredQuantitySimple.FieldName = "QtyRequired"
        Me.gcRequiredQuantitySimple.Name = "gcRequiredQuantitySimple"
        Me.gcRequiredQuantitySimple.Visible = True
        Me.gcRequiredQuantitySimple.VisibleIndex = 5
        Me.gcRequiredQuantitySimple.Width = 93
        '
        'repitQtyReqSimp
        '
        Me.repitQtyReqSimp.AutoHeight = False
        Me.repitQtyReqSimp.DisplayFormat.FormatString = "N3"
        Me.repitQtyReqSimp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repitQtyReqSimp.Mask.EditMask = "N3"
        Me.repitQtyReqSimp.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repitQtyReqSimp.Name = "repitQtyReqSimp"
        '
        'gcUoM
        '
        Me.gcUoM.Caption = "UdM"
        Me.gcUoM.FieldName = "UoM"
        Me.gcUoM.Name = "gcUoM"
        Me.gcUoM.Visible = True
        Me.gcUoM.VisibleIndex = 4
        Me.gcUoM.Width = 87
        '
        'gcRetentionValue
        '
        Me.gcRetentionValue.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcRetentionValue.AppearanceCell.Options.UseBackColor = True
        Me.gcRetentionValue.Caption = "Valor Retención"
        Me.gcRetentionValue.ColumnEdit = Me.RepositoryItemSpinEditUnitValue
        Me.gcRetentionValue.DisplayFormat.FormatString = "N2"
        Me.gcRetentionValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRetentionValue.FieldName = "RetentionValue"
        Me.gcRetentionValue.Name = "gcRetentionValue"
        Me.gcRetentionValue.OptionsColumn.ReadOnly = True
        Me.gcRetentionValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RetentionValue", "{0:N2}")})
        Me.gcRetentionValue.Visible = True
        Me.gcRetentionValue.VisibleIndex = 11
        Me.gcRetentionValue.Width = 73
        '
        'gcRequiredQuantitySimpleWO
        '
        Me.gcRequiredQuantitySimpleWO.Caption = "gcRequiredQuantitySimpleWO"
        Me.gcRequiredQuantitySimpleWO.Name = "gcRequiredQuantitySimpleWO"
        '
        'gcRequiredQuantityMultipleWO
        '
        Me.gcRequiredQuantityMultipleWO.Caption = "Cantidad Requerida"
        Me.gcRequiredQuantityMultipleWO.ColumnEdit = Me.repoPopupPOItem
        Me.gcRequiredQuantityMultipleWO.DisplayFormat.FormatString = "N3"
        Me.gcRequiredQuantityMultipleWO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRequiredQuantityMultipleWO.FieldName = "gcRequiredQuantityMultipleWO"
        Me.gcRequiredQuantityMultipleWO.Name = "gcRequiredQuantityMultipleWO"
        Me.gcRequiredQuantityMultipleWO.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.gcRequiredQuantityMultipleWO.Visible = True
        Me.gcRequiredQuantityMultipleWO.VisibleIndex = 7
        '
        'repoPopupPOItem
        '
        Me.repoPopupPOItem.AutoHeight = False
        Me.repoPopupPOItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopupPOItem.Name = "repoPopupPOItem"
        Me.repoPopupPOItem.PopupControl = Me.popupPOI
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
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "n3"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n3"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'repoPopupWorkOrderAllocation
        '
        Me.repoPopupWorkOrderAllocation.AutoHeight = False
        Me.repoPopupWorkOrderAllocation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopupWorkOrderAllocation.Name = "repoPopupWorkOrderAllocation"
        '
        'repoWOAllocationSelect
        '
        Me.repoWOAllocationSelect.AutoHeight = False
        Me.repoWOAllocationSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repoWOAllocationSelect.Name = "repoWOAllocationSelect"
        '
        'repoPopupWOAllocationSelect
        '
        Me.repoPopupWOAllocationSelect.AutoHeight = False
        Me.repoPopupWOAllocationSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoPopupWOAllocationSelect.Name = "repoPopupWOAllocationSelect"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.rgCompanyOption)
        Me.GroupControl3.Controls.Add(Me.grpWorkOrderType)
        Me.GroupControl3.Controls.Add(Me.dtePaymentDate)
        Me.GroupControl3.Controls.Add(Me.LabelControl22)
        Me.GroupControl3.Controls.Add(Me.LabelControl21)
        Me.GroupControl3.Controls.Add(Me.cboValuationMode)
        Me.GroupControl3.Controls.Add(Me.txtRetentionPercentage)
        Me.GroupControl3.Controls.Add(Me.lblRetention)
        Me.GroupControl3.Controls.Add(Me.LabelControl20)
        Me.GroupControl3.Controls.Add(Me.cboStage)
        Me.GroupControl3.Controls.Add(Me.LabelControl19)
        Me.GroupControl3.Controls.Add(Me.cboAccountingCategory)
        Me.GroupControl3.Controls.Add(Me.ckeAccountOrder)
        Me.GroupControl3.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl18)
        Me.GroupControl3.Controls.Add(Me.txtComments)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.cboPaymentMethod)
        Me.GroupControl3.Controls.Add(Me.LabelControl15)
        Me.GroupControl3.Controls.Add(Me.GroupControl1)
        Me.GroupControl3.Controls.Add(Me.txtNetValue)
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
        Me.GroupControl3.Size = New System.Drawing.Size(1647, 352)
        Me.GroupControl3.TabIndex = 248
        Me.GroupControl3.Text = "Detalles del Proveedor"
        '
        'rgCompanyOption
        '
        Me.rgCompanyOption.EditValue = 1
        Me.rgCompanyOption.Location = New System.Drawing.Point(207, 205)
        Me.rgCompanyOption.MenuManager = Me.BarManager1
        Me.rgCompanyOption.Name = "rgCompanyOption"
        Me.rgCompanyOption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Agro"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Hyess")})
        Me.rgCompanyOption.Size = New System.Drawing.Size(106, 27)
        Me.rgCompanyOption.TabIndex = 297
        '
        'grpWorkOrderType
        '
        Me.grpWorkOrderType.AppearanceCaption.BackColor = System.Drawing.Color.Maroon
        Me.grpWorkOrderType.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpWorkOrderType.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpWorkOrderType.AppearanceCaption.Options.UseBackColor = True
        Me.grpWorkOrderType.AppearanceCaption.Options.UseFont = True
        Me.grpWorkOrderType.AppearanceCaption.Options.UseForeColor = True
        Me.grpWorkOrderType.Controls.Add(Me.xtabPOReqTypeWO)
        Me.grpWorkOrderType.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Inv.", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Senc.", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, CType(2, Short), -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Mult.", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, 3, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Orden Trabajo", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, False, 4, -1)})
        Me.grpWorkOrderType.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpWorkOrderType.Location = New System.Drawing.Point(509, 26)
        Me.grpWorkOrderType.Name = "grpWorkOrderType"
        Me.grpWorkOrderType.Size = New System.Drawing.Size(467, 326)
        Me.grpWorkOrderType.TabIndex = 296
        Me.grpWorkOrderType.Text = "Referencia de O.T."
        '
        'xtabPOReqTypeWO
        '
        Me.xtabPOReqTypeWO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtabPOReqTypeWO.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtabPOReqTypeWO.Location = New System.Drawing.Point(2, 26)
        Me.xtabPOReqTypeWO.Name = "xtabPOReqTypeWO"
        Me.xtabPOReqTypeWO.SelectedTabPage = Me.xtpInventoryWO
        Me.xtabPOReqTypeWO.Size = New System.Drawing.Size(463, 298)
        Me.xtabPOReqTypeWO.TabIndex = 272
        Me.xtabPOReqTypeWO.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpInventoryWO, Me.xtpSingleWO, Me.xtpMultipleWO})
        '
        'xtpInventoryWO
        '
        Me.xtpInventoryWO.Controls.Add(Me.PanelControl3)
        Me.xtpInventoryWO.Name = "xtpInventoryWO"
        Me.xtpInventoryWO.Size = New System.Drawing.Size(434, 292)
        Me.xtpInventoryWO.Text = "Inv."
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl27)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(434, 292)
        Me.PanelControl3.TabIndex = 0
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.Location = New System.Drawing.Point(20, 19)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(265, 14)
        Me.LabelControl27.TabIndex = 277
        Me.LabelControl27.Text = "Materiales de esta Compra directos a Inventario"
        '
        'xtpSingleWO
        '
        Me.xtpSingleWO.Controls.Add(Me.GroupControl8)
        Me.xtpSingleWO.Name = "xtpSingleWO"
        Me.xtpSingleWO.Size = New System.Drawing.Size(434, 292)
        Me.xtpSingleWO.Text = "Senc."
        '
        'GroupControl8
        '
        Me.GroupControl8.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl8.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl8.AppearanceCaption.Options.UseFont = True
        Me.GroupControl8.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl8.Controls.Add(Me.grdPurchaseOrderWorkOrderBudget)
        Me.GroupControl8.Controls.Add(Me.dteRequiredDateWO)
        Me.GroupControl8.Controls.Add(Me.LabelControl28)
        Me.GroupControl8.Controls.Add(Me.LabelControl29)
        Me.GroupControl8.Controls.Add(Me.LabelControl30)
        Me.GroupControl8.Controls.Add(Me.LabelControl31)
        Me.GroupControl8.Controls.Add(Me.txtCustomerNameWO)
        Me.GroupControl8.Controls.Add(Me.txtProjectNameWO)
        Me.GroupControl8.Controls.Add(Me.btnSelectWorkOrder)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl8.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.ShowCaption = False
        Me.GroupControl8.Size = New System.Drawing.Size(434, 292)
        Me.GroupControl8.TabIndex = 268
        Me.GroupControl8.Text = "Admon. OTs"
        '
        'grdPurchaseOrderWorkOrderBudget
        '
        Me.grdPurchaseOrderWorkOrderBudget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPurchaseOrderWorkOrderBudget.Location = New System.Drawing.Point(5, 117)
        Me.grdPurchaseOrderWorkOrderBudget.MainView = Me.GridView2
        Me.grdPurchaseOrderWorkOrderBudget.Name = "grdPurchaseOrderWorkOrderBudget"
        Me.grdPurchaseOrderWorkOrderBudget.Size = New System.Drawing.Size(424, 170)
        Me.grdPurchaseOrderWorkOrderBudget.TabIndex = 282
        Me.grdPurchaseOrderWorkOrderBudget.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.grdPurchaseOrderWorkOrderBudget.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView2.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseFont = True
        Me.GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView2.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView2.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView2.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19, Me.GridColumn21})
        Me.GridView2.GridControl = Me.grdPurchaseOrderWorkOrderBudget
        Me.GridView2.GroupRowHeight = 40
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowViewCaption = True
        Me.GridView2.ViewCaption = "Presupuesto de Insumos"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "#"
        Me.GridColumn18.FieldName = "ItemNumber"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        Me.GridColumn18.Width = 265
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Descripción"
        Me.GridColumn19.FieldName = "Description"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        Me.GridColumn19.Width = 650
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Costo Ins. Est."
        Me.GridColumn21.DisplayFormat.FormatString = "$#,##0.00;;#"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "StockItemCost"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StockItemCost", "{0:$#,##0.00;;#}")})
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 2
        Me.GridColumn21.Width = 706
        '
        'dteRequiredDateWO
        '
        Me.dteRequiredDateWO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dteRequiredDateWO.EditValue = Nothing
        Me.dteRequiredDateWO.Location = New System.Drawing.Point(93, 87)
        Me.dteRequiredDateWO.MenuManager = Me.BarManager1
        Me.dteRequiredDateWO.Name = "dteRequiredDateWO"
        Me.dteRequiredDateWO.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dteRequiredDateWO.Properties.Appearance.Options.UseFont = True
        Me.dteRequiredDateWO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteRequiredDateWO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteRequiredDateWO.Properties.NullDate = New Date(CType(0, Long))
        Me.dteRequiredDateWO.Properties.ReadOnly = True
        Me.dteRequiredDateWO.Size = New System.Drawing.Size(318, 20)
        Me.dteRequiredDateWO.TabIndex = 281
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Location = New System.Drawing.Point(5, 90)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(82, 14)
        Me.LabelControl28.TabIndex = 280
        Me.LabelControl28.Text = "Fecha Requerida"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Location = New System.Drawing.Point(5, 63)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl29.TabIndex = 279
        Me.LabelControl29.Text = "Cliente"
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl30.Appearance.Options.UseFont = True
        Me.LabelControl30.Location = New System.Drawing.Point(5, 36)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl30.TabIndex = 278
        Me.LabelControl30.Text = "Proyecto"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.Location = New System.Drawing.Point(5, 9)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl31.TabIndex = 277
        Me.LabelControl31.Text = "# O.T."
        '
        'txtCustomerNameWO
        '
        Me.txtCustomerNameWO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCustomerNameWO.Location = New System.Drawing.Point(93, 60)
        Me.txtCustomerNameWO.MenuManager = Me.BarManager1
        Me.txtCustomerNameWO.Name = "txtCustomerNameWO"
        Me.txtCustomerNameWO.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCustomerNameWO.Properties.Appearance.Options.UseFont = True
        Me.txtCustomerNameWO.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCustomerNameWO.Properties.ReadOnly = True
        Me.txtCustomerNameWO.Size = New System.Drawing.Size(318, 20)
        Me.txtCustomerNameWO.TabIndex = 263
        '
        'txtProjectNameWO
        '
        Me.txtProjectNameWO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjectNameWO.Location = New System.Drawing.Point(93, 33)
        Me.txtProjectNameWO.MenuManager = Me.BarManager1
        Me.txtProjectNameWO.Name = "txtProjectNameWO"
        Me.txtProjectNameWO.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProjectNameWO.Properties.Appearance.Options.UseFont = True
        Me.txtProjectNameWO.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtProjectNameWO.Properties.ReadOnly = True
        Me.txtProjectNameWO.Size = New System.Drawing.Size(318, 20)
        Me.txtProjectNameWO.TabIndex = 262
        '
        'btnSelectWorkOrder
        '
        Me.btnSelectWorkOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectWorkOrder.Location = New System.Drawing.Point(93, 6)
        Me.btnSelectWorkOrder.MenuManager = Me.BarManager1
        Me.btnSelectWorkOrder.Name = "btnSelectWorkOrder"
        Me.btnSelectWorkOrder.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnSelectWorkOrder.Properties.Appearance.Image = CType(resources.GetObject("btnSelectWorkOrder.Properties.Appearance.Image"), System.Drawing.Image)
        Me.btnSelectWorkOrder.Properties.Appearance.Options.UseFont = True
        Me.btnSelectWorkOrder.Properties.Appearance.Options.UseImage = True
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnSelectWorkOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnSelectWorkOrder.Properties.ReadOnly = True
        Me.btnSelectWorkOrder.Size = New System.Drawing.Size(318, 22)
        Me.btnSelectWorkOrder.TabIndex = 246
        '
        'xtpMultipleWO
        '
        Me.xtpMultipleWO.Controls.Add(Me.GroupControl9)
        Me.xtpMultipleWO.Name = "xtpMultipleWO"
        Me.xtpMultipleWO.Size = New System.Drawing.Size(434, 292)
        Me.xtpMultipleWO.Text = "Mult."
        '
        'GroupControl9
        '
        Me.GroupControl9.AppearanceCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl9.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl9.AppearanceCaption.Options.UseFont = True
        Me.GroupControl9.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl9.Controls.Add(Me.btnSelectMultipleWO)
        Me.GroupControl9.Controls.Add(Me.grdPOIWorkOrderInfo)
        Me.GroupControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl9.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.ShowCaption = False
        Me.GroupControl9.Size = New System.Drawing.Size(434, 292)
        Me.GroupControl9.TabIndex = 267
        Me.GroupControl9.Text = "Admon. OTs"
        '
        'btnSelectMultipleWO
        '
        Me.btnSelectMultipleWO.Location = New System.Drawing.Point(5, 222)
        Me.btnSelectMultipleWO.Name = "btnSelectMultipleWO"
        Me.btnSelectMultipleWO.Size = New System.Drawing.Size(125, 23)
        Me.btnSelectMultipleWO.TabIndex = 267
        Me.btnSelectMultipleWO.Text = "Seleccionar OTs"
        '
        'grdPOIWorkOrderInfo
        '
        Me.grdPOIWorkOrderInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPOIWorkOrderInfo.Location = New System.Drawing.Point(5, 5)
        Me.grdPOIWorkOrderInfo.MainView = Me.gvWorkOrderInfos
        Me.grdPOIWorkOrderInfo.MenuManager = Me.BarManager1
        Me.grdPOIWorkOrderInfo.Name = "grdPOIWorkOrderInfo"
        Me.grdPOIWorkOrderInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2})
        Me.grdPOIWorkOrderInfo.Size = New System.Drawing.Size(424, 206)
        Me.grdPOIWorkOrderInfo.TabIndex = 266
        Me.grdPOIWorkOrderInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrderInfos})
        '
        'gvWorkOrderInfos
        '
        Me.gvWorkOrderInfos.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvWorkOrderInfos.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrderInfos.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvWorkOrderInfos.Appearance.EvenRow.Options.UseFont = True
        Me.gvWorkOrderInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWorkOrderInfos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWorkOrderInfos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvWorkOrderInfos.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrderInfos.Appearance.OddRow.Options.UseBackColor = True
        Me.gvWorkOrderInfos.Appearance.OddRow.Options.UseFont = True
        Me.gvWorkOrderInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn22, Me.GridColumn23, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5})
        Me.gvWorkOrderInfos.GridControl = Me.grdPOIWorkOrderInfo
        Me.gvWorkOrderInfos.Name = "gvWorkOrderInfos"
        Me.gvWorkOrderInfos.OptionsBehavior.ReadOnly = True
        Me.gvWorkOrderInfos.OptionsView.EnableAppearanceEvenRow = True
        Me.gvWorkOrderInfos.OptionsView.EnableAppearanceOddRow = True
        Me.gvWorkOrderInfos.OptionsView.ShowDetailButtons = False
        Me.gvWorkOrderInfos.OptionsView.ShowGroupPanel = False
        Me.gvWorkOrderInfos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn22, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "# O.T."
        Me.GridColumn22.FieldName = "WorkOrderNo"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 0
        Me.GridColumn22.Width = 70
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Descripción"
        Me.GridColumn23.FieldName = "Description"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 1
        Me.GridColumn23.Width = 102
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Proyecto"
        Me.GridColumn2.FieldName = "ProjectNameAndCustomer"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 92
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cliente"
        Me.GridColumn4.FieldName = "CompanyName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 59
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Compra"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn5.FieldName = "PurchasingDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 67
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.NullDate = New Date(CType(0, Long))
        '
        'dtePaymentDate
        '
        Me.dtePaymentDate.EditValue = Nothing
        Me.dtePaymentDate.Location = New System.Drawing.Point(405, 256)
        Me.dtePaymentDate.MenuManager = Me.BarManager1
        Me.dtePaymentDate.Name = "dtePaymentDate"
        Me.dtePaymentDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dtePaymentDate.Properties.Appearance.Options.UseFont = True
        Me.dtePaymentDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtePaymentDate.Properties.NullDate = New Date(CType(0, Long))
        Me.dtePaymentDate.Size = New System.Drawing.Size(98, 20)
        Me.dtePaymentDate.TabIndex = 294
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Location = New System.Drawing.Point(319, 259)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl22.TabIndex = 295
        Me.LabelControl22.Text = "Fecha Pago"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(319, 235)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl21.TabIndex = 292
        Me.LabelControl21.Text = "Valuación Inv."
        '
        'cboValuationMode
        '
        Me.cboValuationMode.Location = New System.Drawing.Point(405, 232)
        Me.cboValuationMode.MenuManager = Me.BarManager1
        Me.cboValuationMode.Name = "cboValuationMode"
        Me.cboValuationMode.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboValuationMode.Properties.Appearance.Options.UseFont = True
        Me.cboValuationMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboValuationMode.Size = New System.Drawing.Size(98, 20)
        Me.cboValuationMode.TabIndex = 293
        '
        'txtRetentionPercentage
        '
        Me.txtRetentionPercentage.Location = New System.Drawing.Point(98, 235)
        Me.txtRetentionPercentage.MenuManager = Me.BarManager1
        Me.txtRetentionPercentage.Name = "txtRetentionPercentage"
        Me.txtRetentionPercentage.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtRetentionPercentage.Properties.Appearance.Options.UseFont = True
        Me.txtRetentionPercentage.Properties.Mask.EditMask = "p"
        Me.txtRetentionPercentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRetentionPercentage.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRetentionPercentage.Size = New System.Drawing.Size(107, 20)
        Me.txtRetentionPercentage.TabIndex = 291
        '
        'lblRetention
        '
        Me.lblRetention.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRetention.Appearance.Options.UseFont = True
        Me.lblRetention.Location = New System.Drawing.Point(8, 238)
        Me.lblRetention.Name = "lblRetention"
        Me.lblRetention.Size = New System.Drawing.Size(61, 14)
        Me.lblRetention.TabIndex = 290
        Me.lblRetention.Text = "% Retención"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(319, 188)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(67, 14)
        Me.LabelControl20.TabIndex = 288
        Me.LabelControl20.Text = "Etapa Compra"
        '
        'cboStage
        '
        Me.cboStage.Location = New System.Drawing.Point(405, 185)
        Me.cboStage.MenuManager = Me.BarManager1
        Me.cboStage.Name = "cboStage"
        Me.cboStage.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboStage.Properties.Appearance.Options.UseFont = True
        Me.cboStage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStage.Size = New System.Drawing.Size(98, 20)
        Me.cboStage.TabIndex = 289
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(8, 116)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(91, 14)
        Me.LabelControl19.TabIndex = 286
        Me.LabelControl19.Text = "Categoría Contable"
        '
        'cboAccountingCategory
        '
        Me.cboAccountingCategory.Location = New System.Drawing.Point(105, 113)
        Me.cboAccountingCategory.MenuManager = Me.BarManager1
        Me.cboAccountingCategory.Name = "cboAccountingCategory"
        Me.cboAccountingCategory.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboAccountingCategory.Properties.Appearance.Options.UseFont = True
        Me.cboAccountingCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAccountingCategory.Size = New System.Drawing.Size(100, 20)
        Me.cboAccountingCategory.TabIndex = 287
        '
        'ckeAccountOrder
        '
        Me.ckeAccountOrder.EditValue = True
        Me.ckeAccountOrder.Location = New System.Drawing.Point(207, 186)
        Me.ckeAccountOrder.MenuManager = Me.BarManager1
        Me.ckeAccountOrder.Name = "ckeAccountOrder"
        Me.ckeAccountOrder.Properties.Appearance.Font = New System.Drawing.Font("Arial", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ckeAccountOrder.Properties.Appearance.Options.UseFont = True
        Me.ckeAccountOrder.Properties.Caption = "Con Orden Pago?"
        Me.ckeAccountOrder.Size = New System.Drawing.Size(106, 19)
        Me.ckeAccountOrder.TabIndex = 285
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(1252, 26)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtratabPODelivery
        Me.XtraTabControl1.Size = New System.Drawing.Size(386, 321)
        Me.XtraTabControl1.TabIndex = 283
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtratabPODelivery, Me.xtraTabAppendDoc})
        '
        'xtratabPODelivery
        '
        Me.xtratabPODelivery.Appearance.Header.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.xtratabPODelivery.Appearance.Header.ForeColor = System.Drawing.Color.Maroon
        Me.xtratabPODelivery.Appearance.Header.Options.UseFont = True
        Me.xtratabPODelivery.Appearance.Header.Options.UseForeColor = True
        Me.xtratabPODelivery.Controls.Add(Me.GroupControl7)
        Me.xtratabPODelivery.Name = "xtratabPODelivery"
        Me.xtratabPODelivery.Size = New System.Drawing.Size(380, 291)
        Me.xtratabPODelivery.Text = "Detalles de Recepción"
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
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl7.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.ShowCaption = False
        Me.GroupControl7.Size = New System.Drawing.Size(380, 291)
        Me.GroupControl7.TabIndex = 278
        '
        'grdPODeliveryInfos
        '
        Me.grdPODeliveryInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPODeliveryInfos.Location = New System.Drawing.Point(2, 2)
        Me.grdPODeliveryInfos.MainView = Me.gvPODeliveryInfos
        Me.grdPODeliveryInfos.MenuManager = Me.BarManager1
        Me.grdPODeliveryInfos.Name = "grdPODeliveryInfos"
        Me.grdPODeliveryInfos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.repoPODelivery})
        Me.grdPODeliveryInfos.Size = New System.Drawing.Size(376, 287)
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
        Me.gvPODeliveryInfos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPODeliveryInfos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPODeliveryInfos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPODeliveryInfos.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPODeliveryInfos.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPODeliveryInfos.Appearance.OddRow.Options.UseFont = True
        Me.gvPODeliveryInfos.ColumnPanelRowHeight = 40
        Me.gvPODeliveryInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.gcPODeliveryValue, Me.GridColumn3, Me.GridColumn8})
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
        Me.GridColumn13.ColumnEdit = Me.repoPODelivery
        Me.GridColumn13.FieldName = "GRNumber"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 60
        '
        'repoPODelivery
        '
        Me.repoPODelivery.AutoHeight = False
        Me.repoPODelivery.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repoPODelivery.Name = "repoPODelivery"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Fecha Recep."
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn14.FieldName = "DateCreated"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 48
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'gcPODeliveryValue
        '
        Me.gcPODeliveryValue.Caption = "Valor de Rec."
        Me.gcPODeliveryValue.DisplayFormat.FormatString = "c2"
        Me.gcPODeliveryValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPODeliveryValue.FieldName = "PODeliveryValue"
        Me.gcPODeliveryValue.Name = "gcPODeliveryValue"
        Me.gcPODeliveryValue.OptionsColumn.ReadOnly = True
        Me.gcPODeliveryValue.Visible = True
        Me.gcPODeliveryValue.VisibleIndex = 3
        Me.gcPODeliveryValue.Width = 53
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "T.C."
        Me.GridColumn3.FieldName = "ExchangeRateValue"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 46
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Estado de Recepción"
        Me.GridColumn8.FieldName = "PODeliveryStatusDesc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 73
        '
        'xtraTabAppendDoc
        '
        Me.xtraTabAppendDoc.Appearance.Header.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.xtraTabAppendDoc.Appearance.Header.ForeColor = System.Drawing.Color.Maroon
        Me.xtraTabAppendDoc.Appearance.Header.Options.UseFont = True
        Me.xtraTabAppendDoc.Appearance.Header.Options.UseForeColor = True
        Me.xtraTabAppendDoc.Controls.Add(Me.UctFileControl1)
        Me.xtraTabAppendDoc.Name = "xtraTabAppendDoc"
        Me.xtraTabAppendDoc.Size = New System.Drawing.Size(380, 291)
        Me.xtraTabAppendDoc.Text = "Documentos Adjuntos"
        '
        'UctFileControl1
        '
        Me.UctFileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UctFileControl1.Location = New System.Drawing.Point(0, 0)
        Me.UctFileControl1.Name = "UctFileControl1"
        Me.UctFileControl1.Size = New System.Drawing.Size(380, 291)
        Me.UctFileControl1.TabIndex = 1
        Me.UctFileControl1.UserController = Nothing
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(8, 279)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl18.TabIndex = 282
        Me.LabelControl18.Text = "Comentarios"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(97, 281)
        Me.txtComments.MenuManager = Me.BarManager1
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(406, 66)
        Me.txtComments.TabIndex = 281
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(8, 212)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(47, 14)
        Me.LabelControl14.TabIndex = 279
        Me.LabelControl14.Text = "Mét. Pago"
        '
        'cboPaymentMethod
        '
        Me.cboPaymentMethod.Location = New System.Drawing.Point(98, 209)
        Me.cboPaymentMethod.MenuManager = Me.BarManager1
        Me.cboPaymentMethod.Name = "cboPaymentMethod"
        Me.cboPaymentMethod.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboPaymentMethod.Properties.Appearance.Options.UseFont = True
        Me.cboPaymentMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPaymentMethod.Size = New System.Drawing.Size(107, 20)
        Me.cboPaymentMethod.TabIndex = 280
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(323, 38)
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
        Me.GroupControl1.Location = New System.Drawing.Point(982, 193)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 154)
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
        Me.uctDeliveryAddress.Size = New System.Drawing.Size(253, 123)
        Me.uctDeliveryAddress.TabIndex = 1
        Me.uctDeliveryAddress.ThirdAddressLine = False
        '
        'txtNetValue
        '
        Me.txtNetValue.EditValue = ""
        Me.txtNetValue.Location = New System.Drawing.Point(405, 35)
        Me.txtNetValue.MenuManager = Me.BarManager1
        Me.txtNetValue.Name = "txtNetValue"
        Me.txtNetValue.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtNetValue.Properties.Appearance.Options.UseFont = True
        Me.txtNetValue.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNetValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNetValue.Properties.ReadOnly = True
        Me.txtNetValue.Size = New System.Drawing.Size(98, 20)
        Me.txtNetValue.TabIndex = 275
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
        Me.GroupControl2.Location = New System.Drawing.Point(982, 26)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(263, 164)
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
        Me.UctAddress1.Size = New System.Drawing.Size(258, 134)
        Me.UctAddress1.TabIndex = 1
        Me.UctAddress1.ThirdAddressLine = False
        '
        'lblExchangeRate
        '
        Me.lblExchangeRate.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblExchangeRate.Appearance.Options.UseFont = True
        Me.lblExchangeRate.Location = New System.Drawing.Point(319, 212)
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
        Me.LabelControl9.Location = New System.Drawing.Point(319, 164)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl9.TabIndex = 270
        Me.LabelControl9.Text = "Moneda"
        '
        'txtExchangeValue
        '
        Me.txtExchangeValue.Location = New System.Drawing.Point(405, 209)
        Me.txtExchangeValue.MenuManager = Me.BarManager1
        Me.txtExchangeValue.Name = "txtExchangeValue"
        Me.txtExchangeValue.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtExchangeValue.Properties.Appearance.Options.UseFont = True
        Me.txtExchangeValue.Properties.Mask.EditMask = "n4"
        Me.txtExchangeValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExchangeValue.Size = New System.Drawing.Size(98, 20)
        Me.txtExchangeValue.TabIndex = 269
        Me.txtExchangeValue.Visible = False
        '
        'rgDefaultCurrency
        '
        Me.rgDefaultCurrency.Location = New System.Drawing.Point(405, 160)
        Me.rgDefaultCurrency.Name = "rgDefaultCurrency"
        Me.rgDefaultCurrency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.rgDefaultCurrency.Properties.Appearance.Options.UseBackColor = True
        Me.rgDefaultCurrency.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "USD"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "C$")})
        Me.rgDefaultCurrency.Size = New System.Drawing.Size(98, 22)
        Me.rgDefaultCurrency.TabIndex = 268
        '
        'btePONum
        '
        Me.btePONum.Location = New System.Drawing.Point(97, 35)
        Me.btePONum.Name = "btePONum"
        Me.btePONum.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btePONum.Properties.Appearance.Options.UseFont = True
        Me.btePONum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.btePONum.Properties.ReadOnly = True
        Me.btePONum.Size = New System.Drawing.Size(107, 20)
        Me.btePONum.TabIndex = 265
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseForeColor = True
        Me.lblTitle.Location = New System.Drawing.Point(8, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(43, 18)
        Me.lblTitle.TabIndex = 244
        Me.lblTitle.Text = "# O.C."
        '
        'btedSupplier
        '
        Me.btedSupplier.Location = New System.Drawing.Point(97, 63)
        Me.btedSupplier.MenuManager = Me.BarManager1
        Me.btedSupplier.Name = "btedSupplier"
        Me.btedSupplier.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btedSupplier.Properties.Appearance.Options.UseFont = True
        Me.btedSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btedSupplier.Size = New System.Drawing.Size(107, 20)
        Me.btedSupplier.TabIndex = 245
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(319, 92)
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
        Me.LabelControl1.Location = New System.Drawing.Point(8, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl1.TabIndex = 246
        Me.LabelControl1.Text = "Proveedor"
        '
        'txtCarriage
        '
        Me.txtCarriage.Location = New System.Drawing.Point(405, 89)
        Me.txtCarriage.MenuManager = Me.BarManager1
        Me.txtCarriage.Name = "txtCarriage"
        Me.txtCarriage.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCarriage.Properties.Appearance.Options.UseFont = True
        Me.txtCarriage.Properties.Mask.EditMask = "n2"
        Me.txtCarriage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCarriage.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCarriage.Size = New System.Drawing.Size(98, 20)
        Me.txtCarriage.TabIndex = 261
        '
        'dteDateOfOrder
        '
        Me.dteDateOfOrder.EditValue = Nothing
        Me.dteDateOfOrder.Location = New System.Drawing.Point(405, 63)
        Me.dteDateOfOrder.MenuManager = Me.BarManager1
        Me.dteDateOfOrder.Name = "dteDateOfOrder"
        Me.dteDateOfOrder.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dteDateOfOrder.Properties.Appearance.Options.UseFont = True
        Me.dteDateOfOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDateOfOrder.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDateOfOrder.Size = New System.Drawing.Size(98, 20)
        Me.dteDateOfOrder.TabIndex = 253
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(8, 140)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 14)
        Me.LabelControl2.TabIndex = 247
        Me.LabelControl2.Text = "Categoría"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(8, 188)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl12.TabIndex = 260
        Me.LabelControl12.Text = "Generar O.C."
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(97, 137)
        Me.cboCategory.MenuManager = Me.BarManager1
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboCategory.Properties.Appearance.Options.UseFont = True
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Size = New System.Drawing.Size(107, 20)
        Me.cboCategory.TabIndex = 248
        '
        'btnEditPurchaseOrderPDF
        '
        Me.btnEditPurchaseOrderPDF.Location = New System.Drawing.Point(97, 185)
        Me.btnEditPurchaseOrderPDF.Name = "btnEditPurchaseOrderPDF"
        Me.btnEditPurchaseOrderPDF.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnEditPurchaseOrderPDF.Properties.Appearance.Options.UseFont = True
        Me.btnEditPurchaseOrderPDF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.btnEditPurchaseOrderPDF.Properties.ReadOnly = True
        Me.btnEditPurchaseOrderPDF.Size = New System.Drawing.Size(107, 20)
        Me.btnEditPurchaseOrderPDF.TabIndex = 259
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(8, 164)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl3.TabIndex = 249
        Me.LabelControl3.Text = "Estado"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(319, 140)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl11.TabIndex = 258
        Me.LabelControl11.Text = "Comprador"
        '
        'cboStatus
        '
        Me.cboStatus.Location = New System.Drawing.Point(97, 161)
        Me.cboStatus.MenuManager = Me.BarManager1
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboStatus.Properties.Appearance.Options.UseFont = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Size = New System.Drawing.Size(107, 20)
        Me.cboStatus.TabIndex = 250
        '
        'cboBuyer
        '
        Me.cboBuyer.Location = New System.Drawing.Point(405, 137)
        Me.cboBuyer.MenuManager = Me.BarManager1
        Me.cboBuyer.Name = "cboBuyer"
        Me.cboBuyer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboBuyer.Properties.Appearance.Options.UseFont = True
        Me.cboBuyer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuyer.Size = New System.Drawing.Size(98, 20)
        Me.cboBuyer.TabIndex = 257
        '
        'dteDueDate
        '
        Me.dteDueDate.EditValue = Nothing
        Me.dteDueDate.Location = New System.Drawing.Point(405, 113)
        Me.dteDueDate.MenuManager = Me.BarManager1
        Me.dteDueDate.Name = "dteDueDate"
        Me.dteDueDate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dteDueDate.Properties.Appearance.Options.UseFont = True
        Me.dteDueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDueDate.Size = New System.Drawing.Size(98, 20)
        Me.dteDueDate.TabIndex = 251
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(8, 92)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(48, 14)
        Me.LabelControl10.TabIndex = 256
        Me.LabelControl10.Text = "Ref. Prov."
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(319, 116)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 14)
        Me.LabelControl4.TabIndex = 252
        Me.LabelControl4.Text = "Fecha Requerida"
        '
        'txtSupplierRef
        '
        Me.txtSupplierRef.EditValue = ""
        Me.txtSupplierRef.Location = New System.Drawing.Point(97, 89)
        Me.txtSupplierRef.MenuManager = Me.BarManager1
        Me.txtSupplierRef.Name = "txtSupplierRef"
        Me.txtSupplierRef.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtSupplierRef.Properties.Appearance.Options.UseFont = True
        Me.txtSupplierRef.Size = New System.Drawing.Size(107, 20)
        Me.txtSupplierRef.TabIndex = 255
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(319, 66)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 14)
        Me.LabelControl5.TabIndex = 254
        Me.LabelControl5.Text = "Fecha de Órden"
        '
        'frmManPurchaseOrderDetail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1841, 804)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.gpnlPOItems)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManPurchaseOrderDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Órden de Compra"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpnlPOItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpnlPOItems.ResumeLayout(False)
        CType(Me.popupPOI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupPOI.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.grdPOIWorkOrderAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOIWorkOrderInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoSelectWOAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPurchaseOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEditUnitValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repitQtyReqSimp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupPOItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemPopupContainerEditPOItemAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemButtonEditStockItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemPopupContainerEditQtyReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupWorkOrderAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoWOAllocationSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPopupWOAllocationSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.rgCompanyOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpWorkOrderType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWorkOrderType.ResumeLayout(False)
        CType(Me.xtabPOReqTypeWO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabPOReqTypeWO.ResumeLayout(False)
        Me.xtpInventoryWO.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.xtpSingleWO.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout()
        CType(Me.grdPurchaseOrderWorkOrderBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteRequiredDateWO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteRequiredDateWO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerNameWO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectNameWO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelectWorkOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMultipleWO.ResumeLayout(False)
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        CType(Me.grdPOIWorkOrderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorkOrderInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePaymentDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtePaymentDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboValuationMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetentionPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAccountingCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeAccountOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtratabPODelivery.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grdPODeliveryInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPODeliveryInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoPODelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtraTabAppendDoc.ResumeLayout(False)
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPaymentMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtNetValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents gcPartNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPOIDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPOIUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemSpinEditUnitValue As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents gcPOINetValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNotes As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcVATRateCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredQuantityMultiple As DevExpress.XtraGrid.Columns.GridColumn
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
  Friend WithEvents repoPopupWorkOrder As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents gcSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSendPOEmail As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents lblExchangeRate As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtExchangeValue As DevExpress.XtraEditors.TextEdit
  Friend WithEvents rgDefaultCurrency As DevExpress.XtraEditors.RadioGroup
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents uctDeliveryAddress As uctAddress
  Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNetValue As DevExpress.XtraEditors.TextEdit
  Friend WithEvents btnPODelivery As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents gcReceivedQuantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents grdPODeliveryInfos As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvPODeliveryInfos As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents UctAddress1 As uctAddress
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents gcStockCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredQuantitySimple As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitQtyReqSimp As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents gcPODeliveryValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoPODelivery As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboPaymentMethod As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents gcUoM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents xtratabPODelivery As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents xtraTabAppendDoc As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents UctFileControl1 As uctFileControl
  Friend WithEvents ckeAccountOrder As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboAccountingCategory As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboStage As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents txtRetentionPercentage As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblRetention As DevExpress.XtraEditors.LabelControl
  Friend WithEvents gcRetentionValue As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents cboValuationMode As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents dtePaymentDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents grpWorkOrderType As DevExpress.XtraEditors.GroupControl
  Friend WithEvents xtabPOReqTypeWO As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents xtpInventoryWO As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents xtpSingleWO As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdPurchaseOrderWorkOrderBudget As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents dteRequiredDateWO As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCustomerNameWO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtProjectNameWO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents btnSelectWorkOrder As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents xtpMultipleWO As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents btnSelectMultipleWO As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents grdPOIWorkOrderInfo As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorkOrderInfos As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredQuantitySimpleWO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredQuantityMultipleWO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoPopupWorkOrderAllocation As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents repoPopupWOAllocationSelect As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents repoWOAllocationSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents popupPOI As DevExpress.XtraEditors.PopupContainerControl
  Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents grdPOIWorkOrderAllocation As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvPOIWorkOrderInfos As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcPOItemCallOff As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemQuantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcWOAItemRef As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoSelectWOAllocation As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repoPopupPOItem As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents gcWorkOrderID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemRef2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents gcSalesOrderPhaseItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rgCompanyOption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class