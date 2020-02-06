<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickingPurchaseOrder
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
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.btnSelectPurchaseOrder = New DevExpress.XtraEditors.ButtonEdit()
    Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
    Me.grpMaterialRequirements = New DevExpress.XtraEditors.GroupControl()
    Me.grdPurchaseOrderItemInfo = New DevExpress.XtraGrid.GridControl()
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
    Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
    CType(Me.btnSelectPurchaseOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpMaterialRequirements.SuspendLayout()
    CType(Me.grdPurchaseOrderItemInfo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSupplierCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRequiredDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpPOPicking, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpPOPicking.SuspendLayout()
    CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Location = New System.Drawing.Point(687, 39)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(57, 16)
    Me.LabelControl3.TabIndex = 7
    Me.LabelControl3.Text = "Category"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Location = New System.Drawing.Point(6, 39)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(30, 16)
    Me.LabelControl1.TabIndex = 1
    Me.LabelControl1.Text = "# PO"
    '
    'btnSelectPurchaseOrder
    '
    Me.btnSelectPurchaseOrder.Location = New System.Drawing.Point(47, 37)
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
    Me.txtCategory.Location = New System.Drawing.Point(755, 37)
    Me.txtCategory.Name = "txtCategory"
    Me.txtCategory.Properties.ReadOnly = True
    Me.txtCategory.Size = New System.Drawing.Size(90, 20)
    Me.txtCategory.TabIndex = 6
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
    Me.grpMaterialRequirements.Controls.Add(Me.grdPurchaseOrderItemInfo)
    Me.grpMaterialRequirements.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Process", True, ButtonImageOptions1)})
    Me.grpMaterialRequirements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpMaterialRequirements.Location = New System.Drawing.Point(7, 180)
    Me.grpMaterialRequirements.Name = "grpMaterialRequirements"
    Me.grpMaterialRequirements.Size = New System.Drawing.Size(1150, 390)
    Me.grpMaterialRequirements.TabIndex = 12
    Me.grpMaterialRequirements.Text = "Purchase Order Items"
    '
    'grdPurchaseOrderItemInfo
    '
    Me.grdPurchaseOrderItemInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdPurchaseOrderItemInfo.Location = New System.Drawing.Point(2, 26)

    Me.grdPurchaseOrderItemInfo.Name = "grdPurchaseOrderItemInfo"
    Me.grdPurchaseOrderItemInfo.Size = New System.Drawing.Size(1146, 362)
    Me.grdPurchaseOrderItemInfo.TabIndex = 0
    '
    'gvMaterialRequirementInfos

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
    Me.LabelControl7.Location = New System.Drawing.Point(153, 39)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(101, 16)
    Me.LabelControl7.TabIndex = 7
    Me.LabelControl7.Text = "Company Name"
    '
    'txtSupplierCompanyName
    '
    Me.txtSupplierCompanyName.Location = New System.Drawing.Point(265, 37)
    Me.txtSupplierCompanyName.Name = "txtSupplierCompanyName"
    Me.txtSupplierCompanyName.Properties.ReadOnly = True
    Me.txtSupplierCompanyName.Size = New System.Drawing.Size(149, 20)
    Me.txtSupplierCompanyName.TabIndex = 4
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Location = New System.Drawing.Point(425, 39)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(91, 16)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Required Date"
    '
    'txtRequiredDate
    '
    Me.txtRequiredDate.Location = New System.Drawing.Point(527, 37)
    Me.txtRequiredDate.Name = "txtRequiredDate"
    Me.txtRequiredDate.Properties.ReadOnly = True
    Me.txtRequiredDate.Size = New System.Drawing.Size(149, 20)
    Me.txtRequiredDate.TabIndex = 2
    '
    'grpPOPicking
    '
    Me.grpPOPicking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpPOPicking.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpPOPicking.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpPOPicking.AppearanceCaption.Options.UseFont = True
    Me.grpPOPicking.AppearanceCaption.Options.UseForeColor = True
    Me.grpPOPicking.Controls.Add(Me.LabelControl7)
    Me.grpPOPicking.Controls.Add(Me.txtSupplierCompanyName)
    Me.grpPOPicking.Controls.Add(Me.LabelControl3)
    Me.grpPOPicking.Controls.Add(Me.LabelControl1)
    Me.grpPOPicking.Controls.Add(Me.txtRequiredDate)
    Me.grpPOPicking.Controls.Add(Me.LabelControl2)
    Me.grpPOPicking.Controls.Add(Me.btnSelectPurchaseOrder)
    Me.grpPOPicking.Controls.Add(Me.txtCategory)
    Me.grpPOPicking.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Generate GRN", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, CType(1, Short), -1)})
    Me.grpPOPicking.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpPOPicking.Location = New System.Drawing.Point(9, 9)
    Me.grpPOPicking.Name = "grpPOPicking"
    Me.grpPOPicking.Size = New System.Drawing.Size(1148, 165)
    Me.grpPOPicking.TabIndex = 11
    Me.grpPOPicking.Text = "PO  General Information"
    '
    'GroupControl2
    '
    Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl2.Controls.Add(Me.TextEdit4)
    Me.GroupControl2.Controls.Add(Me.LabelControl4)
    Me.GroupControl2.Controls.Add(Me.TextEdit1)
    Me.GroupControl2.Controls.Add(Me.LabelControl5)
    Me.GroupControl2.Controls.Add(Me.LabelControl6)
    Me.GroupControl2.Controls.Add(Me.TextEdit2)
    Me.GroupControl2.Controls.Add(Me.LabelControl8)
    Me.GroupControl2.Controls.Add(Me.TextEdit3)
    Me.GroupControl2.Location = New System.Drawing.Point(14, 91)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(1149, 74)
    Me.GroupControl2.TabIndex = 12
    Me.GroupControl2.Text = "PO  Delivery Information"
    '
    'TextEdit4
    '
    Me.TextEdit4.Location = New System.Drawing.Point(73, 38)
    Me.TextEdit4.Name = "TextEdit4"
    Me.TextEdit4.Properties.ReadOnly = True
    Me.TextEdit4.Size = New System.Drawing.Size(74, 20)
    Me.TextEdit4.TabIndex = 8
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Appearance.Options.UseFont = True
    Me.LabelControl4.Location = New System.Drawing.Point(162, 39)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(92, 16)
    Me.LabelControl4.TabIndex = 7
    Me.LabelControl4.Text = "Received Date"
    '
    'TextEdit1
    '
    Me.TextEdit1.Location = New System.Drawing.Point(265, 37)
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Properties.ReadOnly = True
    Me.TextEdit1.Size = New System.Drawing.Size(149, 20)
    Me.TextEdit1.TabIndex = 4
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl5.Appearance.Options.UseFont = True
    Me.LabelControl5.Location = New System.Drawing.Point(707, 39)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(55, 16)
    Me.LabelControl5.TabIndex = 7
    Me.LabelControl5.Text = "Supplier"
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl6.Appearance.Options.UseFont = True
    Me.LabelControl6.Location = New System.Drawing.Point(6, 39)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(61, 16)
    Me.LabelControl6.TabIndex = 1
    Me.LabelControl6.Text = "GRN Num"
    '
    'TextEdit2
    '
    Me.TextEdit2.Location = New System.Drawing.Point(537, 36)
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Properties.ReadOnly = True
    Me.TextEdit2.Size = New System.Drawing.Size(149, 20)
    Me.TextEdit2.TabIndex = 2
    '
    'LabelControl8
    '
    Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl8.Appearance.Options.UseFont = True
    Me.LabelControl8.Location = New System.Drawing.Point(425, 39)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(106, 16)
    Me.LabelControl8.TabIndex = 3
    Me.LabelControl8.Text = "Delivery Address"
    '
    'TextEdit3
    '
    Me.TextEdit3.Location = New System.Drawing.Point(768, 38)
    Me.TextEdit3.Name = "TextEdit3"
    Me.TextEdit3.Properties.ReadOnly = True
    Me.TextEdit3.Size = New System.Drawing.Size(90, 20)
    Me.TextEdit3.TabIndex = 6
    '
    'frmPickingPurchaseOrder
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1164, 578)
    Me.Controls.Add(Me.GroupControl2)
    Me.Controls.Add(Me.grpMaterialRequirements)
    Me.Controls.Add(Me.grpPOPicking)
    Me.Name = "frmPickingPurchaseOrder"
    Me.Text = "Picking Purchase Order"
    CType(Me.btnSelectPurchaseOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpMaterialRequirements.ResumeLayout(False)
    CType(Me.grdPurchaseOrderItemInfo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSupplierCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRequiredDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpPOPicking, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpPOPicking.ResumeLayout(False)
    Me.grpPOPicking.PerformLayout()
    CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    Me.GroupControl2.PerformLayout()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnSelectPurchaseOrder As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
  Friend WithEvents grpMaterialRequirements As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdPurchaseOrderItemInfo As DevExpress.XtraGrid.GridControl
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
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
End Class
