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
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
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
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAreaID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMaterialRequirementID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
    Me.txtFinishDate = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.txtReference = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWOQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWODescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaterialRequirements.SuspendLayout()
        CType(Me.grdMaterialRequirementInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtFinishDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtWOQty)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnSelectOT)
        Me.GroupControl1.Controls.Add(Me.txtWODescription)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(980, 117)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos Generales de Orden de Trabajo"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(346, 83)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(212, 20)
        Me.TextEdit2.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(225, 85)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(115, 16)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Fecha Planificada"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(8, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Cantidad"
        '
        'txtWOQty
        '
        Me.txtWOQty.Location = New System.Drawing.Point(69, 83)
        Me.txtWOQty.Name = "txtWOQty"
        Me.txtWOQty.Properties.ReadOnly = True
        Me.txtWOQty.Size = New System.Drawing.Size(140, 20)
        Me.txtWOQty.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(225, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Descripción"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "# OT"
        '
        'btnSelectOT
        '
        Me.btnSelectOT.Location = New System.Drawing.Point(69, 38)
        Me.btnSelectOT.Name = "btnSelectOT"
        Me.btnSelectOT.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnSelectOT.Properties.Appearance.Options.UseFont = True
        Me.btnSelectOT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnSelectOT.Size = New System.Drawing.Size(140, 20)
        Me.btnSelectOT.TabIndex = 0
        '
        'txtWODescription
        '
        Me.txtWODescription.Location = New System.Drawing.Point(346, 38)
        Me.txtWODescription.Name = "txtWODescription"
        Me.txtWODescription.Properties.ReadOnly = True
        Me.txtWODescription.Size = New System.Drawing.Size(212, 20)
        Me.txtWODescription.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(19, 85)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Cliente"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(95, 83)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Properties.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(217, 20)
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
        Me.grpMaterialRequirements.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Procesar", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.grpMaterialRequirements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.grpMaterialRequirements.Location = New System.Drawing.Point(2, 142)
        Me.grpMaterialRequirements.Name = "grpMaterialRequirements"
        Me.grpMaterialRequirements.Size = New System.Drawing.Size(1587, 424)
        Me.grpMaterialRequirements.TabIndex = 1
        Me.grpMaterialRequirements.Text = "Materiales"
        '
        'grdMaterialRequirementInfo
        '
        Me.grdMaterialRequirementInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMaterialRequirementInfo.Location = New System.Drawing.Point(2, 26)
        Me.grdMaterialRequirementInfo.MainView = Me.gvMaterialRequirementInfos
        Me.grdMaterialRequirementInfo.Name = "grdMaterialRequirementInfo"
        Me.grdMaterialRequirementInfo.Size = New System.Drawing.Size(1583, 396)
        Me.grdMaterialRequirementInfo.TabIndex = 0
        Me.grdMaterialRequirementInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterialRequirementInfos})
        '
        'gvMaterialRequirementInfos
        '
        Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
        Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMaterialRequirementInfos.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.gvMaterialRequirementInfos.Appearance.Row.Options.UseFont = True
        Me.gvMaterialRequirementInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.StockCode, Me.gcCategory, Me.GridColumn2, Me.GridColumn8, Me.GridColumn6, Me.GridColumn7, Me.gcAreaID, Me.GridColumn4, Me.GridColumn9, Me.GridColumn5, Me.gcMaterialRequirementID, Me.gcStdCost, Me.gcTotalAmount})
        Me.gvMaterialRequirementInfos.GridControl = Me.grdMaterialRequirementInfo
        Me.gvMaterialRequirementInfos.Name = "gvMaterialRequirementInfos"
        Me.gvMaterialRequirementInfos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gvMaterialRequirementInfos.OptionsView.ShowFooter = True
        Me.gvMaterialRequirementInfos.OptionsView.ShowGroupPanel = False
        '
        'StockCode
        '
        Me.StockCode.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.StockCode.AppearanceCell.Options.UseBackColor = True
        Me.StockCode.Caption = "Código"
        Me.StockCode.FieldName = "StockCode"
        Me.StockCode.Name = "StockCode"
        Me.StockCode.OptionsColumn.ReadOnly = True
        Me.StockCode.Visible = True
        Me.StockCode.VisibleIndex = 0
        '
        'gcCategory
        '
        Me.gcCategory.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcCategory.AppearanceCell.Options.UseBackColor = True
        Me.gcCategory.Caption = "Categoria"
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
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 216
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.Caption = "UdM"
        Me.GridColumn8.FieldName = "UoM"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 103
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.Caption = "Cant. Req."
        Me.GridColumn6.DisplayFormat.FormatString = "###.000"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Quantity"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        Me.GridColumn6.Width = 83
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.Caption = "Cant. Despachada"
        Me.GridColumn7.DisplayFormat.FormatString = "###.000"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "PickedQty"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        Me.GridColumn7.Width = 109
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
        Me.gcAreaID.Width = 91
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.Caption = "Núm. Parte"
        Me.GridColumn4.FieldName = "PartNo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 91
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn9.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn9.Caption = "Cant. Pendiente"
        Me.GridColumn9.DisplayFormat.FormatString = "0.##;;#"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "QtyOS"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 88
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "A Procesar"
        Me.GridColumn5.DisplayFormat.FormatString = "###.000"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "ToProcessQty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 10
        Me.GridColumn5.Width = 123
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
        Me.gcStdCost.Caption = "Costo Unit"
        Me.gcStdCost.DisplayFormat.FormatString = "C$#,##0.00;;#"
        Me.gcStdCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcStdCost.FieldName = "StdCost"
        Me.gcStdCost.Name = "gcStdCost"
        Me.gcStdCost.Visible = True
        Me.gcStdCost.VisibleIndex = 6
        '
        'gcTotalAmount
        '
        Me.gcTotalAmount.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcTotalAmount.AppearanceCell.Options.UseBackColor = True
        Me.gcTotalAmount.Caption = "Valor Total"
        Me.gcTotalAmount.DisplayFormat.FormatString = "C$#,##0.00;;#"
        Me.gcTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcTotalAmount.FieldName = "TotalAmount"
        Me.gcTotalAmount.Name = "gcTotalAmount"
        Me.gcTotalAmount.OptionsColumn.ReadOnly = True
        Me.gcTotalAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "{0:C$#,##0.00;;#}")})
        Me.gcTotalAmount.Visible = True
        Me.gcTotalAmount.VisibleIndex = 11
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.txtFinishDate)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.txtProjectName)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.txtReference)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.txtCompanyName)
        Me.GroupControl3.Location = New System.Drawing.Point(612, 5)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(977, 117)
        Me.GroupControl3.TabIndex = 7
        Me.GroupControl3.Text = "Datos Generales de Orden de Venta"
        '
        'txtFinishDate
        '
        Me.txtFinishDate.Location = New System.Drawing.Point(463, 83)
        Me.txtFinishDate.Name = "txtFinishDate"
        Me.txtFinishDate.Properties.ReadOnly = True
        Me.txtFinishDate.Size = New System.Drawing.Size(236, 20)
        Me.txtFinishDate.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(348, 85)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(109, 16)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "Fecha Requerida"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(348, 40)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Proyecto"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(463, 38)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Properties.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(236, 20)
        Me.txtProjectName.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(19, 40)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "# Proforma"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(95, 38)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Properties.ReadOnly = True
        Me.txtReference.Size = New System.Drawing.Size(217, 20)
        Me.txtReference.TabIndex = 4
        '
        'frmPickMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1601, 578)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.grpMaterialRequirements)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmPickMaterials"
        Me.Text = "Salida de Materiales"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWOQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWODescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMaterialRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaterialRequirements.ResumeLayout(False)
        CType(Me.grdMaterialRequirementInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtFinishDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWOQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtWODescription As DevExpress.XtraEditors.TextEdit
  Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
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
End Class
