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
    Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.txtCompanyName = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.btnSelectOT = New DevExpress.XtraEditors.ButtonEdit()
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
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.grdMaterialRequirementInfo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.GroupControl1.Controls.Add(Me.SimpleButton1)
    Me.GroupControl1.Controls.Add(Me.LabelControl2)
    Me.GroupControl1.Controls.Add(Me.txtCompanyName)
    Me.GroupControl1.Controls.Add(Me.LabelControl1)
    Me.GroupControl1.Controls.Add(Me.btnSelectOT)
    Me.GroupControl1.Location = New System.Drawing.Point(2, 12)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(1066, 73)
    Me.GroupControl1.TabIndex = 0
    Me.GroupControl1.Text = "Orden de Trabajo"
    '
    'SimpleButton1
    '
    Me.SimpleButton1.Location = New System.Drawing.Point(718, 41)
    Me.SimpleButton1.Name = "SimpleButton1"
    Me.SimpleButton1.Size = New System.Drawing.Size(75, 31)
    Me.SimpleButton1.TabIndex = 4
    Me.SimpleButton1.Text = "SimpleButton1"
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.Options.UseFont = True
    Me.LabelControl2.Location = New System.Drawing.Point(273, 41)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(45, 16)
    Me.LabelControl2.TabIndex = 3
    Me.LabelControl2.Text = "Cliente"
    '
    'txtCompanyName
    '
    Me.txtCompanyName.Location = New System.Drawing.Point(324, 40)
    Me.txtCompanyName.Name = "txtCompanyName"
    Me.txtCompanyName.Size = New System.Drawing.Size(218, 20)
    Me.txtCompanyName.TabIndex = 2
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.Options.UseFont = True
    Me.LabelControl1.Location = New System.Drawing.Point(10, 41)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(112, 16)
    Me.LabelControl1.TabIndex = 1
    Me.LabelControl1.Text = "Orden de Trabajo"
    '
    'btnSelectOT
    '
    Me.btnSelectOT.Location = New System.Drawing.Point(141, 38)
    Me.btnSelectOT.Name = "btnSelectOT"
    Me.btnSelectOT.Properties.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.btnSelectOT.Properties.Appearance.Options.UseFont = True
    Me.btnSelectOT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btnSelectOT.Size = New System.Drawing.Size(111, 22)
    Me.btnSelectOT.TabIndex = 0
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
    Me.GroupControl2.Location = New System.Drawing.Point(2, 91)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(1066, 430)
    Me.GroupControl2.TabIndex = 1
    Me.GroupControl2.Text = "Materiales"
    '
    'grdMaterialRequirementInfo
    '
    Me.grdMaterialRequirementInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdMaterialRequirementInfo.Location = New System.Drawing.Point(2, 25)
    Me.grdMaterialRequirementInfo.MainView = Me.gvMaterialRequirementInfos
    Me.grdMaterialRequirementInfo.Name = "grdMaterialRequirementInfo"
    Me.grdMaterialRequirementInfo.Size = New System.Drawing.Size(1062, 403)
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
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 88
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Categoria"
    Me.GridColumn3.FieldName = "Category"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 121
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Description"
    Me.GridColumn2.FieldName = "Description"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 208
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "UdM"
    Me.GridColumn8.FieldName = "UoM"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 3
    Me.GridColumn8.Width = 132
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Cant. Req."
    Me.GridColumn6.FieldName = "Quantity"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 6
    Me.GridColumn6.Width = 121
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Cant. Sacado"
    Me.GridColumn7.FieldName = "PickedQty"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 7
    Me.GridColumn7.Width = 121
    '
    'gcAreaID
    '
    Me.gcAreaID.Caption = "Área"
    Me.gcAreaID.FieldName = "AreaID"
    Me.gcAreaID.Name = "gcAreaID"
    Me.gcAreaID.Visible = True
    Me.gcAreaID.VisibleIndex = 4
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Núm. Parte"
    Me.GridColumn4.FieldName = "PartNo"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 5
    '
    'frmPickMaterials
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1080, 533)
    Me.Controls.Add(Me.GroupControl2)
    Me.Controls.Add(Me.GroupControl1)
    Me.Name = "frmPickMaterials"
    Me.Text = "frmPickMaterials"
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.btnSelectOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    CType(Me.grdMaterialRequirementInfo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvMaterialRequirementInfos, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents gcAreaID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
