<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPODelivery
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions5 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions6 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions7 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.btnSelectPurchaseOrder = New DevExpress.XtraEditors.ButtonEdit()
    Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
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
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.txtSupplierCompanyName = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtRequiredDate = New DevExpress.XtraEditors.TextEdit()
    Me.grpPOPicking = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
    Me.txtExchangeRate = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.txtDefaultCurrency = New DevExpress.XtraEditors.TextEdit()
    Me.grpGRN = New DevExpress.XtraEditors.GroupControl()
    Me.dteReceived = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
    Me.txtRefDocSupplier = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.txtReceivedValue = New DevExpress.XtraEditors.TextEdit()
    Me.txtGRNNumber = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
    Me.grpMaterialRequirements = New DevExpress.XtraEditors.GroupControl()
    Me.grdPurchaseOrderItemInfo = New DevExpress.XtraGrid.GridControl()
    Me.gvMaterialRequirementInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
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
    CType(Me.btnSelectPurchaseOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSupplierCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRequiredDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpPOPicking, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpPOPicking.SuspendLayout()
    CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDefaultCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpGRN, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpGRN.SuspendLayout()
    CType(Me.dteReceived.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteReceived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRefDocSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtReceivedValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGRNNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpMaterialRequirements.SuspendLayout()
    CType(Me.grdPurchaseOrderItemInfo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Location = New System.Drawing.Point(590, 39)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(99, 16)
    Me.LabelControl3.TabIndex = 7
    Me.LabelControl3.Text = "Cat. de Compra"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Location = New System.Drawing.Point(6, 39)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(30, 16)
    Me.LabelControl1.TabIndex = 1
    Me.LabelControl1.Text = "# OC"
    '
    'btnSelectPurchaseOrder
    '
    Me.btnSelectPurchaseOrder.Location = New System.Drawing.Point(42, 37)
    Me.btnSelectPurchaseOrder.Name = "btnSelectPurchaseOrder"
    Me.btnSelectPurchaseOrder.Properties.AccessibleName = "btnSelectPurchaseOrder"
    Me.btnSelectPurchaseOrder.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.btnSelectPurchaseOrder.Properties.Appearance.Options.UseFont = True
    Me.btnSelectPurchaseOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btnSelectPurchaseOrder.Size = New System.Drawing.Size(95, 20)
    Me.btnSelectPurchaseOrder.TabIndex = 0
    '
    'txtCategory
    '
    Me.txtCategory.Location = New System.Drawing.Point(698, 37)
    Me.txtCategory.Name = "txtCategory"
    Me.txtCategory.Properties.ReadOnly = True
    Me.txtCategory.Size = New System.Drawing.Size(113, 20)
    Me.txtCategory.TabIndex = 6
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
    'LabelControl7
    '
    Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl7.Appearance.Options.UseFont = True
    Me.LabelControl7.Location = New System.Drawing.Point(148, 39)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(67, 16)
    Me.LabelControl7.TabIndex = 7
    Me.LabelControl7.Text = "Proveedor"
    '
    'txtSupplierCompanyName
    '
    Me.txtSupplierCompanyName.Location = New System.Drawing.Point(220, 37)
    Me.txtSupplierCompanyName.Name = "txtSupplierCompanyName"
    Me.txtSupplierCompanyName.Properties.ReadOnly = True
    Me.txtSupplierCompanyName.Size = New System.Drawing.Size(149, 20)
    Me.txtSupplierCompanyName.TabIndex = 4
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Location = New System.Drawing.Point(377, 39)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(72, 16)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Fecha Req."
    '
    'txtRequiredDate
    '
    Me.txtRequiredDate.Location = New System.Drawing.Point(455, 37)
    Me.txtRequiredDate.Name = "txtRequiredDate"
    Me.txtRequiredDate.Properties.ReadOnly = True
    Me.txtRequiredDate.Size = New System.Drawing.Size(125, 20)
    Me.txtRequiredDate.TabIndex = 2
    '
    'grpPOPicking
    '
    Me.grpPOPicking.AllowTouchScroll = True
    Me.grpPOPicking.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpPOPicking.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpPOPicking.AppearanceCaption.Options.UseFont = True
    Me.grpPOPicking.AppearanceCaption.Options.UseForeColor = True
    Me.grpPOPicking.Controls.Add(Me.LabelControl9)
    Me.grpPOPicking.Controls.Add(Me.txtExchangeRate)
    Me.grpPOPicking.Controls.Add(Me.LabelControl8)
    Me.grpPOPicking.Controls.Add(Me.txtDefaultCurrency)
    Me.grpPOPicking.Controls.Add(Me.grpGRN)
    Me.grpPOPicking.Controls.Add(Me.LabelControl7)
    Me.grpPOPicking.Controls.Add(Me.txtSupplierCompanyName)
    Me.grpPOPicking.Controls.Add(Me.LabelControl3)
    Me.grpPOPicking.Controls.Add(Me.LabelControl1)
    Me.grpPOPicking.Controls.Add(Me.txtRequiredDate)
    Me.grpPOPicking.Controls.Add(Me.LabelControl2)
    Me.grpPOPicking.Controls.Add(Me.btnSelectPurchaseOrder)
    Me.grpPOPicking.Controls.Add(Me.txtCategory)
    Me.grpPOPicking.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpPOPicking.FireScrollEventOnMouseWheel = True
    Me.grpPOPicking.Location = New System.Drawing.Point(9, 4)
    Me.grpPOPicking.Name = "grpPOPicking"
    Me.grpPOPicking.Size = New System.Drawing.Size(1283, 170)
    Me.grpPOPicking.TabIndex = 11
    Me.grpPOPicking.Text = "Información General de O.C."
    '
    'LabelControl9
    '
    Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl9.Appearance.Options.UseFont = True
    Me.LabelControl9.Location = New System.Drawing.Point(1005, 39)
    Me.LabelControl9.Name = "LabelControl9"
    Me.LabelControl9.Size = New System.Drawing.Size(103, 16)
    Me.LabelControl9.TabIndex = 17
    Me.LabelControl9.Text = "Tasa de Cambio"
    '
    'txtExchangeRate
    '
    Me.txtExchangeRate.Location = New System.Drawing.Point(1118, 37)
    Me.txtExchangeRate.Name = "txtExchangeRate"
    Me.txtExchangeRate.Properties.ReadOnly = True
    Me.txtExchangeRate.Size = New System.Drawing.Size(107, 20)
    Me.txtExchangeRate.TabIndex = 16
    '
    'LabelControl8
    '
    Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl8.Appearance.Options.UseFont = True
    Me.LabelControl8.Location = New System.Drawing.Point(820, 39)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(51, 16)
    Me.LabelControl8.TabIndex = 15
    Me.LabelControl8.Text = "Moneda"
    '
    'txtDefaultCurrency
    '
    Me.txtDefaultCurrency.Location = New System.Drawing.Point(883, 37)
    Me.txtDefaultCurrency.Name = "txtDefaultCurrency"
    Me.txtDefaultCurrency.Properties.ReadOnly = True
    Me.txtDefaultCurrency.Size = New System.Drawing.Size(107, 20)
    Me.txtDefaultCurrency.TabIndex = 14
    '
    'grpGRN
    '
    Me.grpGRN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpGRN.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpGRN.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpGRN.AppearanceCaption.Options.UseFont = True
    Me.grpGRN.AppearanceCaption.Options.UseForeColor = True
    Me.grpGRN.Controls.Add(Me.dteReceived)
    Me.grpGRN.Controls.Add(Me.LabelControl11)
    Me.grpGRN.Controls.Add(Me.txtRefDocSupplier)
    Me.grpGRN.Controls.Add(Me.LabelControl10)
    Me.grpGRN.Controls.Add(Me.cboStatus)
    Me.grpGRN.Controls.Add(Me.LabelControl5)
    Me.grpGRN.Controls.Add(Me.txtReceivedValue)
    Me.grpGRN.Controls.Add(Me.txtGRNNumber)
    Me.grpGRN.Controls.Add(Me.LabelControl4)
    Me.grpGRN.Controls.Add(Me.LabelControl6)
    Me.grpGRN.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Generar # Recep.", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Raise", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Editar", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, False, "Edit", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Guardar", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Save", -1)})
    Me.grpGRN.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpGRN.Location = New System.Drawing.Point(0, 86)
    Me.grpGRN.Name = "grpGRN"
    Me.grpGRN.Size = New System.Drawing.Size(1278, 74)
    Me.grpGRN.TabIndex = 13
    Me.grpGRN.Text = "Información de Recepción de O.C."
    '
    'dteReceived
    '
    Me.dteReceived.EditValue = New Date(2020, 10, 28, 10, 51, 22, 313)
    Me.dteReceived.Location = New System.Drawing.Point(324, 38)
    Me.dteReceived.Name = "dteReceived"
    Me.dteReceived.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteReceived.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteReceived.Properties.DisplayFormat.FormatString = "G"
    Me.dteReceived.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.dteReceived.Properties.Mask.EditMask = "G"
    Me.dteReceived.Size = New System.Drawing.Size(165, 20)
    Me.dteReceived.TabIndex = 280
    '
    'LabelControl11
    '
    Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl11.Appearance.Options.UseFont = True
    Me.LabelControl11.Location = New System.Drawing.Point(763, 40)
    Me.LabelControl11.Name = "LabelControl11"
    Me.LabelControl11.Size = New System.Drawing.Size(69, 16)
    Me.LabelControl11.TabIndex = 279
    Me.LabelControl11.Text = "Referencia"
    '
    'txtRefDocSupplier
    '
    Me.txtRefDocSupplier.Location = New System.Drawing.Point(838, 38)
    Me.txtRefDocSupplier.Name = "txtRefDocSupplier"
    Me.txtRefDocSupplier.Properties.ReadOnly = True
    Me.txtRefDocSupplier.Size = New System.Drawing.Size(149, 20)
    Me.txtRefDocSupplier.TabIndex = 278
    '
    'LabelControl10
    '
    Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl10.Appearance.Options.UseFont = True
    Me.LabelControl10.Location = New System.Drawing.Point(1054, 39)
    Me.LabelControl10.Name = "LabelControl10"
    Me.LabelControl10.Size = New System.Drawing.Size(46, 16)
    Me.LabelControl10.TabIndex = 277
    Me.LabelControl10.Text = "Estado "
    '
    'cboStatus
    '
    Me.cboStatus.Location = New System.Drawing.Point(1106, 38)
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboStatus.Properties.ReadOnly = True
    Me.cboStatus.Size = New System.Drawing.Size(115, 20)
    Me.cboStatus.TabIndex = 276
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl5.Appearance.Options.UseFont = True
    Me.LabelControl5.Location = New System.Drawing.Point(495, 40)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(125, 16)
    Me.LabelControl5.TabIndex = 10
    Me.LabelControl5.Text = "Valor de Recepción"
    '
    'txtReceivedValue
    '
    Me.txtReceivedValue.Location = New System.Drawing.Point(625, 38)
    Me.txtReceivedValue.Name = "txtReceivedValue"
    Me.txtReceivedValue.Properties.Mask.EditMask = "n2"
    Me.txtReceivedValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtReceivedValue.Properties.ReadOnly = True
    Me.txtReceivedValue.Size = New System.Drawing.Size(131, 20)
    Me.txtReceivedValue.TabIndex = 9
    '
    'txtGRNNumber
    '
    Me.txtGRNNumber.Location = New System.Drawing.Point(90, 38)
    Me.txtGRNNumber.Name = "txtGRNNumber"
    Me.txtGRNNumber.Properties.ReadOnly = True
    Me.txtGRNNumber.Size = New System.Drawing.Size(89, 20)
    Me.txtGRNNumber.TabIndex = 8
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Appearance.Options.UseFont = True
    Me.LabelControl4.Location = New System.Drawing.Point(188, 40)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(130, 16)
    Me.LabelControl4.TabIndex = 7
    Me.LabelControl4.Text = "Fecha de Recepción"
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl6.Appearance.Options.UseFont = True
    Me.LabelControl6.Location = New System.Drawing.Point(6, 40)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(78, 16)
    Me.LabelControl6.TabIndex = 1
    Me.LabelControl6.Text = "# Recepción"
    '
    'grpMaterialRequirements
    '
    Me.grpMaterialRequirements.AllowTouchScroll = True
    Me.grpMaterialRequirements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpMaterialRequirements.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpMaterialRequirements.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpMaterialRequirements.AppearanceCaption.Options.UseFont = True
    Me.grpMaterialRequirements.AppearanceCaption.Options.UseForeColor = True
    Me.grpMaterialRequirements.Controls.Add(Me.grdPurchaseOrderItemInfo)
    Me.grpMaterialRequirements.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Procesar", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Process To Timber", True, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, False, 2, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Seleccionar Pendiente", True, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 3, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Imprimir Recepción", True, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, CType(4, Short), -1)})
    Me.grpMaterialRequirements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpMaterialRequirements.FireScrollEventOnMouseWheel = True
    Me.grpMaterialRequirements.Location = New System.Drawing.Point(9, 180)
    Me.grpMaterialRequirements.Name = "grpMaterialRequirements"
    Me.grpMaterialRequirements.Size = New System.Drawing.Size(1285, 373)
    Me.grpMaterialRequirements.TabIndex = 13
    Me.grpMaterialRequirements.Text = "Artículos de la Compra"
    '
    'grdPurchaseOrderItemInfo
    '
    Me.grdPurchaseOrderItemInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdPurchaseOrderItemInfo.Location = New System.Drawing.Point(2, 26)
    Me.grdPurchaseOrderItemInfo.MainView = Me.gvMaterialRequirementInfos
    Me.grdPurchaseOrderItemInfo.Name = "grdPurchaseOrderItemInfo"
    Me.grdPurchaseOrderItemInfo.Size = New System.Drawing.Size(1281, 345)
    Me.grdPurchaseOrderItemInfo.TabIndex = 0
    Me.grdPurchaseOrderItemInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterialRequirementInfos})
    '
    'gvMaterialRequirementInfos
    '
    Me.gvMaterialRequirementInfos.Appearance.GroupPanel.Options.UseTextOptions = True
    Me.gvMaterialRequirementInfos.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
    Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvMaterialRequirementInfos.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.75!)
    Me.gvMaterialRequirementInfos.Appearance.Row.Options.UseFont = True
    Me.gvMaterialRequirementInfos.ColumnPanelRowHeight = 40
    Me.gvMaterialRequirementInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn10, Me.GridColumn3, Me.GridColumn11, Me.GridColumn12, Me.gcQtyToProcess, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn17})
    Me.gvMaterialRequirementInfos.GridControl = Me.grdPurchaseOrderItemInfo
    Me.gvMaterialRequirementInfos.Name = "gvMaterialRequirementInfos"
    Me.gvMaterialRequirementInfos.OptionsView.ShowGroupPanel = False
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
    Me.GridColumn6.FieldName = "Quantity"
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
    Me.GridColumn7.FieldName = "StockCode"
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
    Me.GridColumn8.Caption = "Categoría"
    Me.GridColumn8.FieldName = "StockCategoryDesc"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 3
    Me.GridColumn8.Width = 94
    '
    'GridColumn10
    '
    Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn10.AppearanceCell.Options.UseFont = True
    Me.GridColumn10.Caption = "Descripción"
    Me.GridColumn10.FieldName = "STOCKDESCRIPTION"
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
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 9
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
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 8
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
    Me.GridColumn12.FieldName = "OutStandingQty"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.OptionsColumn.ReadOnly = True
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 10
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
    Me.gcQtyToProcess.Visible = True
    Me.gcQtyToProcess.VisibleIndex = 11
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
    Me.GridColumn13.FieldName = "Length"
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
    Me.GridColumn14.FieldName = "Width"
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
    Me.GridColumn15.FieldName = "Thickness"
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
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 2
    Me.GridColumn17.Width = 91
    '
    'frmPODelivery
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoScroll = True
    Me.ClientSize = New System.Drawing.Size(1296, 565)
    Me.Controls.Add(Me.grpMaterialRequirements)
    Me.Controls.Add(Me.grpPOPicking)
    Me.Name = "frmPODelivery"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Entrada de Materiales"
    CType(Me.btnSelectPurchaseOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSupplierCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRequiredDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpPOPicking, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpPOPicking.ResumeLayout(False)
    Me.grpPOPicking.PerformLayout()
    CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDefaultCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpGRN, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpGRN.ResumeLayout(False)
    Me.grpGRN.PerformLayout()
    CType(Me.dteReceived.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteReceived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRefDocSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtReceivedValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGRNNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpMaterialRequirements.ResumeLayout(False)
    CType(Me.grdPurchaseOrderItemInfo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnSelectPurchaseOrder As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierCompanyName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequiredDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpPOPicking As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents grpGRN As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtGRNNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpMaterialRequirements As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPurchaseOrderItemInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMaterialRequirementInfos As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReceivedValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDefaultCurrency As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExchangeRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefDocSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteReceived As DevExpress.XtraEditors.DateEdit
End Class
