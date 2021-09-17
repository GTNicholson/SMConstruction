<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickWoodMaterial
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
    Me.components = New System.ComponentModel.Container()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickWoodMaterial))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSelectWorkOrder = New DevExpress.XtraEditors.ButtonEdit()
        Me.gcPurchaseOrderItemAllocationID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcProductionBatchID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcReceivedQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcLength = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcWidth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcThickness = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpPOPicking = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWorkOrderDescription = New DevExpress.XtraEditors.TextEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.grdWoodPalletItems = New DevExpress.XtraEditors.GroupControl()
        Me.grdPurchaseOrderItemInfo = New DevExpress.XtraGrid.GridControl()
        Me.gvWoodPalletItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcQtyToProcess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtWoodPalletRef = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWoodPalletDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.btnSelectWorkOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPOPicking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPOPicking.SuspendLayout()
        CType(Me.txtWorkOrderDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdWoodPalletItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdWoodPalletItems.SuspendLayout()
        CType(Me.grdPurchaseOrderItemInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWoodPalletItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtWoodPalletRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWoodPalletDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(6, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "# OT"
        '
        'btnSelectWorkOrder
        '
        Me.btnSelectWorkOrder.Location = New System.Drawing.Point(42, 38)
        Me.btnSelectWorkOrder.Name = "btnSelectWorkOrder"
        Me.btnSelectWorkOrder.Properties.AccessibleName = "btnSelectPurchaseOrder"
        Me.btnSelectWorkOrder.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnSelectWorkOrder.Properties.Appearance.Options.UseFont = True
        Me.btnSelectWorkOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnSelectWorkOrder.Size = New System.Drawing.Size(95, 20)
        Me.btnSelectWorkOrder.TabIndex = 0
        '
        'gcPurchaseOrderItemAllocationID
        '
        Me.gcPurchaseOrderItemAllocationID.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcPurchaseOrderItemAllocationID.AppearanceCell.Options.UseBackColor = True
        Me.gcPurchaseOrderItemAllocationID.Caption = "PurchaseOrderItemAllocationID"
        Me.gcPurchaseOrderItemAllocationID.FieldName = "PurchaseOrderItemAllocationID"
        Me.gcPurchaseOrderItemAllocationID.Name = "gcPurchaseOrderItemAllocationID"
        Me.gcPurchaseOrderItemAllocationID.OptionsColumn.ReadOnly = True
        '
        'gcProductionBatchID
        '
        Me.gcProductionBatchID.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcProductionBatchID.AppearanceCell.Options.UseBackColor = True
        Me.gcProductionBatchID.Caption = "ProductionBatchID"
        Me.gcProductionBatchID.FieldName = "StockItemID"
        Me.gcProductionBatchID.Name = "gcProductionBatchID"
        Me.gcProductionBatchID.OptionsColumn.ReadOnly = True
        Me.gcProductionBatchID.Visible = True
        Me.gcProductionBatchID.VisibleIndex = 6
        '
        'gcQuantity
        '
        Me.gcQuantity.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcQuantity.AppearanceCell.Options.UseBackColor = True
        Me.gcQuantity.Caption = "Quantity"
        Me.gcQuantity.FieldName = "Quantity"
        Me.gcQuantity.Name = "gcQuantity"
        Me.gcQuantity.OptionsColumn.ReadOnly = True
        Me.gcQuantity.Visible = True
        Me.gcQuantity.VisibleIndex = 7
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "Stock Code"
        Me.GridColumn1.FieldName = "StockCode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 90
        '
        'gcCategory
        '
        Me.gcCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcCategory.AppearanceCell.Options.UseBackColor = True
        Me.gcCategory.Caption = "Category"
        Me.gcCategory.FieldName = "Category"
        Me.gcCategory.Name = "gcCategory"
        Me.gcCategory.OptionsColumn.ReadOnly = True
        Me.gcCategory.Visible = True
        Me.gcCategory.VisibleIndex = 2
        Me.gcCategory.Width = 136
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.Caption = "Description"
        Me.GridColumn2.FieldName = "STOCKDESCRIPTION"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 216
        '
        'gcReceivedQty
        '
        Me.gcReceivedQty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcReceivedQty.AppearanceCell.Options.UseBackColor = True
        Me.gcReceivedQty.Caption = "Received Qty"
        Me.gcReceivedQty.DisplayFormat.FormatString = "###.000"
        Me.gcReceivedQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcReceivedQty.FieldName = "ReceivedQty"
        Me.gcReceivedQty.Name = "gcReceivedQty"
        Me.gcReceivedQty.OptionsColumn.ReadOnly = True
        Me.gcReceivedQty.Visible = True
        Me.gcReceivedQty.VisibleIndex = 3
        Me.gcReceivedQty.Width = 109
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn9.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn9.Caption = "Pending Qty"
        Me.GridColumn9.DisplayFormat.FormatString = "###.000"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "QtyOS"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 88
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Qty To Process"
        Me.GridColumn5.DisplayFormat.FormatString = "###.000"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "ToProcessQty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 123
        '
        'gcLength
        '
        Me.gcLength.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcLength.AppearanceCell.Options.UseBackColor = True
        Me.gcLength.Caption = "Length"
        Me.gcLength.FieldName = "Length"
        Me.gcLength.Name = "gcLength"
        Me.gcLength.OptionsColumn.ReadOnly = True
        Me.gcLength.Visible = True
        Me.gcLength.VisibleIndex = 8
        '
        'gcWidth
        '
        Me.gcWidth.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcWidth.AppearanceCell.Options.UseBackColor = True
        Me.gcWidth.Caption = "Width"
        Me.gcWidth.FieldName = "Width"
        Me.gcWidth.Name = "gcWidth"
        Me.gcWidth.OptionsColumn.ReadOnly = True
        Me.gcWidth.Visible = True
        Me.gcWidth.VisibleIndex = 9
        '
        'gcThickness
        '
        Me.gcThickness.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcThickness.AppearanceCell.Options.UseBackColor = True
        Me.gcThickness.Caption = "Thickness"
        Me.gcThickness.FieldName = "Thickness"
        Me.gcThickness.Name = "gcThickness"
        Me.gcThickness.OptionsColumn.ReadOnly = True
        Me.gcThickness.Visible = True
        Me.gcThickness.VisibleIndex = 10
        '
        'grpPOPicking
        '
        Me.grpPOPicking.AllowTouchScroll = True
        Me.grpPOPicking.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPOPicking.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpPOPicking.AppearanceCaption.Options.UseFont = True
        Me.grpPOPicking.AppearanceCaption.Options.UseForeColor = True
        Me.grpPOPicking.Controls.Add(Me.LabelControl2)
        Me.grpPOPicking.Controls.Add(Me.txtWorkOrderDescription)
        Me.grpPOPicking.Controls.Add(Me.LabelControl1)
        Me.grpPOPicking.Controls.Add(Me.btnSelectWorkOrder)
        Me.grpPOPicking.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpPOPicking.FireScrollEventOnMouseWheel = True
        Me.grpPOPicking.Location = New System.Drawing.Point(9, 4)
        Me.grpPOPicking.Name = "grpPOPicking"
        Me.grpPOPicking.Size = New System.Drawing.Size(471, 86)
        Me.grpPOPicking.TabIndex = 11
        Me.grpPOPicking.Text = "Información General de O.C."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(144, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Descripción"
        '
        'txtWorkOrderDescription
        '
        Me.txtWorkOrderDescription.Location = New System.Drawing.Point(224, 38)
        Me.txtWorkOrderDescription.Name = "txtWorkOrderDescription"
        Me.txtWorkOrderDescription.Properties.ReadOnly = True
        Me.txtWorkOrderDescription.Size = New System.Drawing.Size(231, 20)
        Me.txtWorkOrderDescription.TabIndex = 14
        '
        'grdWoodPalletItems
        '
        Me.grdWoodPalletItems.AllowTouchScroll = True
        Me.grdWoodPalletItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdWoodPalletItems.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdWoodPalletItems.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grdWoodPalletItems.AppearanceCaption.Options.UseFont = True
        Me.grdWoodPalletItems.AppearanceCaption.Options.UseForeColor = True
        Me.grdWoodPalletItems.Controls.Add(Me.grdPurchaseOrderItemInfo)
        Me.grdWoodPalletItems.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Procesar", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, False, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Process To Timber", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, False, 2, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Seleccionar Pendiente", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, False, 3, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Imprimir Recepción", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, False, CType(4, Short), -1)})
        Me.grdWoodPalletItems.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grdWoodPalletItems.FireScrollEventOnMouseWheel = True
        Me.grdWoodPalletItems.Location = New System.Drawing.Point(9, 108)
        Me.grdWoodPalletItems.Name = "grdWoodPalletItems"
        Me.grdWoodPalletItems.Size = New System.Drawing.Size(1285, 445)
        Me.grdWoodPalletItems.TabIndex = 13
        Me.grdWoodPalletItems.Text = "Lista de Madera del Pallet"
        '
        'grdPurchaseOrderItemInfo
        '
        Me.grdPurchaseOrderItemInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPurchaseOrderItemInfo.Location = New System.Drawing.Point(2, 25)
        Me.grdPurchaseOrderItemInfo.MainView = Me.gvWoodPalletItems
        Me.grdPurchaseOrderItemInfo.Name = "grdPurchaseOrderItemInfo"
        Me.grdPurchaseOrderItemInfo.Size = New System.Drawing.Size(1281, 418)
        Me.grdPurchaseOrderItemInfo.TabIndex = 0
        Me.grdPurchaseOrderItemInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWoodPalletItems})
        '
        'gvWoodPalletItems
        '
        Me.gvWoodPalletItems.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.gvWoodPalletItems.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvWoodPalletItems.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
        Me.gvWoodPalletItems.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWoodPalletItems.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvWoodPalletItems.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvWoodPalletItems.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.gvWoodPalletItems.Appearance.Row.Options.UseFont = True
        Me.gvWoodPalletItems.ColumnPanelRowHeight = 40
        Me.gvWoodPalletItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn10, Me.GridColumn3, Me.GridColumn11, Me.GridColumn12, Me.gcQtyToProcess, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn17, Me.GridColumn4, Me.GridColumn16})
        Me.gvWoodPalletItems.GridControl = Me.grdPurchaseOrderItemInfo
        Me.gvWoodPalletItems.Name = "gvWoodPalletItems"
        Me.gvWoodPalletItems.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.Caption = "Cantidad"
        Me.GridColumn6.DisplayFormat.FormatString = "N2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "QuantityUI"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        Me.GridColumn6.Width = 69
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.Caption = "Código"
        Me.GridColumn7.FieldName = "WoodPalletItem.StockCode"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.Caption = "Tipo"
        Me.GridColumn8.FieldName = "ItemTypeDesc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 94
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.Caption = "Descripción"
        Me.GridColumn10.FieldName = "WoodPalletItem.Description"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 137
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.Caption = "Cant. Rec. por Recep."
        Me.GridColumn3.DisplayFormat.FormatString = "n2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "DelItemQty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn11.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.Caption = "Cant. Total Recibida"
        Me.GridColumn11.DisplayFormat.FormatString = "N2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "ReceivedQty"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Width = 77
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn12.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.Caption = "Cant. Pend."
        Me.GridColumn12.DisplayFormat.FormatString = "N2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Balance"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 78
        '
        'gcQtyToProcess
        '
        Me.gcQtyToProcess.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gcQtyToProcess.AppearanceCell.Options.UseFont = True
        Me.gcQtyToProcess.Caption = "Cant. a Procesar"
        Me.gcQtyToProcess.DisplayFormat.FormatString = "N2"
        Me.gcQtyToProcess.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcQtyToProcess.FieldName = "ToProcessQty"
        Me.gcQtyToProcess.Name = "gcQtyToProcess"
        Me.gcQtyToProcess.Width = 64
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn13.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.Caption = "Largo"
        Me.GridColumn13.DisplayFormat.FormatString = "N0"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "WoodPalletItem.Length"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 51
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn14.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn14.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn14.AppearanceCell.Options.UseFont = True
        Me.GridColumn14.Caption = "Ancho"
        Me.GridColumn14.DisplayFormat.FormatString = "N0"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "WoodPalletItem.Width"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.GridColumn14.Width = 43
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn15.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn15.AppearanceCell.Options.UseFont = True
        Me.GridColumn15.Caption = "Grosor"
        Me.GridColumn15.DisplayFormat.FormatString = "N0"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "WoodPalletItem.Thickness"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.GridColumn15.Width = 76
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn17.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridColumn17.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn17.AppearanceCell.Options.UseFont = True
        Me.GridColumn17.Caption = "Ref. Etapa"
        Me.GridColumn17.FieldName = "JobNo"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Width = 91
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.Caption = "Especie"
        Me.GridColumn4.FieldName = "SpeciesDesc"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn16.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn16.Caption = "Pies Tablas"
        Me.GridColumn16.DisplayFormat.FormatString = "n2"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "TotalBoardFeet"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 9
        '
        'GroupControl1
        '
        Me.GroupControl1.AllowTouchScroll = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtWoodPalletRef)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtWoodPalletDescription)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl1.FireScrollEventOnMouseWheel = True
        Me.GroupControl1.Location = New System.Drawing.Point(941, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(351, 86)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Información General del Pallet de Madera"
        '
        'txtWoodPalletRef
        '
        Me.txtWoodPalletRef.Location = New System.Drawing.Point(48, 38)
        Me.txtWoodPalletRef.Name = "txtWoodPalletRef"
        Me.txtWoodPalletRef.Properties.ReadOnly = True
        Me.txtWoodPalletRef.Size = New System.Drawing.Size(72, 20)
        Me.txtWoodPalletRef.TabIndex = 16
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(157, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Origen"
        '
        'txtWoodPalletDescription
        '
        Me.txtWoodPalletDescription.Location = New System.Drawing.Point(206, 38)
        Me.txtWoodPalletDescription.Name = "txtWoodPalletDescription"
        Me.txtWoodPalletDescription.Properties.ReadOnly = True
        Me.txtWoodPalletDescription.Size = New System.Drawing.Size(137, 20)
        Me.txtWoodPalletDescription.TabIndex = 14
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(6, 40)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "# Ref."
        '
        'GroupControl2
        '
        Me.GroupControl2.AllowTouchScroll = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txtCustomerName)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.txtProjectName)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.FireScrollEventOnMouseWheel = True
        Me.GroupControl2.Location = New System.Drawing.Point(486, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(449, 86)
        Me.GroupControl2.TabIndex = 15
        Me.GroupControl2.Text = "Información General del Proyecto"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(56, 38)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Properties.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(156, 20)
        Me.txtCustomerName.TabIndex = 16
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(225, 40)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "Proyecto"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(288, 38)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Properties.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(156, 20)
        Me.txtProjectName.TabIndex = 14
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(5, 40)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = "Cliente"
        '
        'frmPickWoodMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1296, 565)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grdWoodPalletItems)
        Me.Controls.Add(Me.grpPOPicking)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPickWoodMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Despacho de Madera para Producción"
        CType(Me.btnSelectWorkOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPOPicking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPOPicking.ResumeLayout(False)
        Me.grpPOPicking.PerformLayout()
        CType(Me.txtWorkOrderDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdWoodPalletItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdWoodPalletItems.ResumeLayout(False)
        CType(Me.grdPurchaseOrderItemInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWoodPalletItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtWoodPalletRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWoodPalletDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnSelectWorkOrder As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents gcPurchaseOrderItemAllocationID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProductionBatchID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQuantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcReceivedQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcWidth As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcThickness As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents grpPOPicking As DevExpress.XtraEditors.GroupControl
  Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents grdWoodPalletItems As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPurchaseOrderItemInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvWoodPalletItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcQtyToProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWorkOrderDescription As DevExpress.XtraEditors.TextEdit
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWoodPalletDescription As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWoodPalletRef As DevExpress.XtraEditors.TextEdit
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
End Class
