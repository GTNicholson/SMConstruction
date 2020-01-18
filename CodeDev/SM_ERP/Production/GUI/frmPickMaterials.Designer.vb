<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickMaterials
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
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.grdMaterialRequirementInfo = New DevExpress.XtraGrid.GridControl()
    Me.gvMaterialRequirementInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAreaID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
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
    Me.GroupControl1.Size = New System.Drawing.Size(543, 117)
    Me.GroupControl1.TabIndex = 0
    Me.GroupControl1.Text = "Datos Generales de Orden de Trabajo"
    '
    'TextEdit2
    '
    Me.TextEdit2.Location = New System.Drawing.Point(307, 84)
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Properties.ReadOnly = True
    Me.TextEdit2.Size = New System.Drawing.Size(167, 20)
    Me.TextEdit2.TabIndex = 11
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl5.Appearance.Options.UseFont = True
    Me.LabelControl5.Location = New System.Drawing.Point(194, 86)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(107, 16)
    Me.LabelControl5.TabIndex = 10
    Me.LabelControl5.Text = "Fech Planificada"
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Appearance.Options.UseFont = True
    Me.LabelControl4.Location = New System.Drawing.Point(6, 86)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(57, 16)
    Me.LabelControl4.TabIndex = 9
    Me.LabelControl4.Text = "Cantidad"
    '
    'txtWOQty
    '
    Me.txtWOQty.Location = New System.Drawing.Point(69, 84)
    Me.txtWOQty.Name = "txtWOQty"
    Me.txtWOQty.Properties.ReadOnly = True
    Me.txtWOQty.Size = New System.Drawing.Size(95, 20)
    Me.txtWOQty.TabIndex = 8
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl3.Appearance.Options.UseFont = True
    Me.LabelControl3.Location = New System.Drawing.Point(227, 41)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(74, 16)
    Me.LabelControl3.TabIndex = 7
    Me.LabelControl3.Text = "Descripción"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Location = New System.Drawing.Point(34, 41)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(29, 16)
    Me.LabelControl1.TabIndex = 1
    Me.LabelControl1.Text = "# OT"
    '
    'btnSelectOT
    '
    Me.btnSelectOT.Location = New System.Drawing.Point(69, 38)
    Me.btnSelectOT.Name = "btnSelectOT"
    Me.btnSelectOT.Properties.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.btnSelectOT.Properties.Appearance.Options.UseFont = True
    Me.btnSelectOT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btnSelectOT.Size = New System.Drawing.Size(95, 22)
    Me.btnSelectOT.TabIndex = 0
    '
    'txtWODescription
    '
    Me.txtWODescription.Location = New System.Drawing.Point(307, 39)
    Me.txtWODescription.Name = "txtWODescription"
    Me.txtWODescription.Properties.ReadOnly = True
    Me.txtWODescription.Size = New System.Drawing.Size(167, 20)
    Me.txtWODescription.TabIndex = 6
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Location = New System.Drawing.Point(44, 86)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(45, 16)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Cliente"
    '
    'txtCompanyName
    '
    Me.txtCompanyName.Location = New System.Drawing.Point(95, 84)
    Me.txtCompanyName.Name = "txtCompanyName"
    Me.txtCompanyName.Properties.ReadOnly = True
    Me.txtCompanyName.Size = New System.Drawing.Size(149, 20)
    Me.txtCompanyName.TabIndex = 2
    '
    'GroupControl2
    '
    Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl2.Controls.Add(Me.grdMaterialRequirementInfo)
    Me.GroupControl2.Location = New System.Drawing.Point(2, 142)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(1150, 424)
    Me.GroupControl2.TabIndex = 1
    Me.GroupControl2.Text = "Materiales"
    '
    'grdMaterialRequirementInfo
    '
    Me.grdMaterialRequirementInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdMaterialRequirementInfo.Location = New System.Drawing.Point(2, 25)
    Me.grdMaterialRequirementInfo.MainView = Me.gvMaterialRequirementInfos
    Me.grdMaterialRequirementInfo.Name = "grdMaterialRequirementInfo"
    Me.grdMaterialRequirementInfo.Size = New System.Drawing.Size(1146, 397)
    Me.grdMaterialRequirementInfo.TabIndex = 0
    Me.grdMaterialRequirementInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterialRequirementInfos})
    '
    'gvMaterialRequirementInfos
    '
    Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvMaterialRequirementInfos.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvMaterialRequirementInfos.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvMaterialRequirementInfos.Appearance.Row.Options.UseFont = True
    Me.gvMaterialRequirementInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.GridColumn8, Me.GridColumn6, Me.GridColumn7, Me.gcAreaID, Me.GridColumn4})
    Me.gvMaterialRequirementInfos.GridControl = Me.grdMaterialRequirementInfo
    Me.gvMaterialRequirementInfos.Name = "gvMaterialRequirementInfos"
    Me.gvMaterialRequirementInfos.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Codigo"
    Me.GridColumn1.FieldName = "StockCode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 88
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Categoria"
    Me.GridColumn3.FieldName = "Category"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 121
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Description"
    Me.GridColumn2.FieldName = "Description"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 208
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "UdM"
    Me.GridColumn8.FieldName = "UoM"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 3
    Me.GridColumn8.Width = 132
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Cant. Req."
    Me.GridColumn6.FieldName = "Quantity"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.ReadOnly = True
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 6
    Me.GridColumn6.Width = 121
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Cant. Sacado"
    Me.GridColumn7.FieldName = "PickedQty"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.OptionsColumn.ReadOnly = True
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 7
    Me.GridColumn7.Width = 121
    '
    'gcAreaID
    '
    Me.gcAreaID.Caption = "Área"
    Me.gcAreaID.FieldName = "AreaID"
    Me.gcAreaID.Name = "gcAreaID"
    Me.gcAreaID.OptionsColumn.ReadOnly = True
    Me.gcAreaID.Visible = True
    Me.gcAreaID.VisibleIndex = 4
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Núm. Parte"
    Me.GridColumn4.FieldName = "PartNo"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.OptionsColumn.ReadOnly = True
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 5
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
    Me.GroupControl3.Location = New System.Drawing.Point(553, 5)
    Me.GroupControl3.Name = "GroupControl3"
    Me.GroupControl3.Size = New System.Drawing.Size(599, 117)
    Me.GroupControl3.TabIndex = 7
    Me.GroupControl3.Text = "Datos Generales de Orden de Venta"
    '
    'txtFinishDate
    '
    Me.txtFinishDate.Location = New System.Drawing.Point(382, 84)
    Me.txtFinishDate.Name = "txtFinishDate"
    Me.txtFinishDate.Properties.ReadOnly = True
    Me.txtFinishDate.Size = New System.Drawing.Size(168, 20)
    Me.txtFinishDate.TabIndex = 9
    '
    'LabelControl8
    '
    Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl8.Appearance.Options.UseFont = True
    Me.LabelControl8.Location = New System.Drawing.Point(267, 86)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(109, 16)
    Me.LabelControl8.TabIndex = 8
    Me.LabelControl8.Text = "Fecha Requerida"
    '
    'LabelControl7
    '
    Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl7.Appearance.Options.UseFont = True
    Me.LabelControl7.Location = New System.Drawing.Point(320, 41)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(56, 16)
    Me.LabelControl7.TabIndex = 7
    Me.LabelControl7.Text = "Proyecto"
    '
    'txtProjectName
    '
    Me.txtProjectName.Location = New System.Drawing.Point(382, 39)
    Me.txtProjectName.Name = "txtProjectName"
    Me.txtProjectName.Properties.ReadOnly = True
    Me.txtProjectName.Size = New System.Drawing.Size(168, 20)
    Me.txtProjectName.TabIndex = 6
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl6.Appearance.Options.UseFont = True
    Me.LabelControl6.Location = New System.Drawing.Point(19, 41)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(70, 16)
    Me.LabelControl6.TabIndex = 5
    Me.LabelControl6.Text = "# Proforma"
    '
    'txtReference
    '
    Me.txtReference.Location = New System.Drawing.Point(95, 39)
    Me.txtReference.Name = "txtReference"
    Me.txtReference.Properties.ReadOnly = True
    Me.txtReference.Size = New System.Drawing.Size(149, 20)
    Me.txtReference.TabIndex = 4
    '
    'frmPickMaterials
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1164, 578)
    Me.Controls.Add(Me.GroupControl3)
    Me.Controls.Add(Me.GroupControl2)
    Me.Controls.Add(Me.GroupControl1)
    Me.Name = "frmPickMaterials"
    Me.Text = "frmPickMaterials"
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtWOQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtWODescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
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
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdMaterialRequirementInfo As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvMaterialRequirementInfos As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
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
End Class
