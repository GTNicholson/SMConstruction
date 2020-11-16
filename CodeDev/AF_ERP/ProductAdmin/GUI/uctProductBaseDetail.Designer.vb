<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctProductBaseDetail
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpProductBOM = New DevExpress.XtraTab.XtraTabPage()
        Me.gpProductBOM = New DevExpress.XtraEditors.GroupControl()
        Me.grdProductBOMs = New DevExpress.XtraGrid.GridControl()
        Me.gvProductBOMs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpStockItemList = New DevExpress.XtraTab.XtraTabPage()
        Me.gpStockItemBOM = New DevExpress.XtraEditors.GroupControl()
        Me.grdStockItemBOM = New DevExpress.XtraGrid.GridControl()
        Me.gvStockItemBOM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpWoodBOM = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.bteDrawing = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboUoM = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnGenerateCode = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSubItemType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.cboProductItemType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockCode = New DevExpress.XtraEditors.TextEdit()
        Me.chkIsGeneric = New DevExpress.XtraEditors.CheckEdit()
        Me.lblStockItemID = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.xtpProductBOM.SuspendLayout()
        CType(Me.gpProductBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpProductBOM.SuspendLayout()
        CType(Me.grdProductBOMs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductBOMs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpStockItemList.SuspendLayout()
        CType(Me.gpStockItemBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpStockItemBOM.SuspendLayout()
        CType(Me.grdStockItemBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStockItemBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpWoodBOM.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bteDrawing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUoM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProductItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsGeneric.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(376, 61)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.xtpProductBOM
        Me.XtraTabControl2.Size = New System.Drawing.Size(609, 240)
        Me.XtraTabControl2.TabIndex = 145
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpProductBOM, Me.xtpStockItemList, Me.xtpWoodBOM})
        '
        'xtpProductBOM
        '
        Me.xtpProductBOM.Controls.Add(Me.gpProductBOM)
        Me.xtpProductBOM.Name = "xtpProductBOM"
        Me.xtpProductBOM.Size = New System.Drawing.Size(603, 212)
        Me.xtpProductBOM.Text = "Lista de Componentes"
        '
        'gpProductBOM
        '
        Me.gpProductBOM.Controls.Add(Me.grdProductBOMs)
        Me.gpProductBOM.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Add", -1)})
        Me.gpProductBOM.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gpProductBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpProductBOM.Location = New System.Drawing.Point(0, 0)
        Me.gpProductBOM.Name = "gpProductBOM"
        Me.gpProductBOM.Size = New System.Drawing.Size(603, 212)
        Me.gpProductBOM.TabIndex = 0
        '
        'grdProductBOMs
        '
        Me.grdProductBOMs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdProductBOMs.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdProductBOMs.Location = New System.Drawing.Point(2, 26)
        Me.grdProductBOMs.MainView = Me.gvProductBOMs
        Me.grdProductBOMs.Name = "grdProductBOMs"
        Me.grdProductBOMs.Size = New System.Drawing.Size(599, 184)
        Me.grdProductBOMs.TabIndex = 130
        Me.grdProductBOMs.UseEmbeddedNavigator = True
        Me.grdProductBOMs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductBOMs})
        '
        'gvProductBOMs
        '
        Me.gvProductBOMs.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvProductBOMs.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvProductBOMs.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvProductBOMs.Appearance.EvenRow.Options.UseFont = True
        Me.gvProductBOMs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvProductBOMs.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvProductBOMs.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvProductBOMs.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvProductBOMs.Appearance.OddRow.Options.UseBackColor = True
        Me.gvProductBOMs.Appearance.OddRow.Options.UseFont = True
        Me.gvProductBOMs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn1})
        Me.gvProductBOMs.GridControl = Me.grdProductBOMs
        Me.gvProductBOMs.Name = "gvProductBOMs"
        Me.gvProductBOMs.OptionsView.EnableAppearanceEvenRow = True
        Me.gvProductBOMs.OptionsView.EnableAppearanceOddRow = True
        Me.gvProductBOMs.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "ParentID"
        Me.GridColumn10.FieldName = "ParentID"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "ProductID"
        Me.GridColumn11.FieldName = "ProductID"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Cantidad"
        Me.GridColumn12.FieldName = "Quantity"
        Me.GridColumn12.GroupFormat.FormatString = "N0"
        Me.GridColumn12.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 102
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Descripción"
        Me.GridColumn1.FieldName = "Description"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 481
        '
        'xtpStockItemList
        '
        Me.xtpStockItemList.Controls.Add(Me.gpStockItemBOM)
        Me.xtpStockItemList.Name = "xtpStockItemList"
        Me.xtpStockItemList.Size = New System.Drawing.Size(603, 212)
        Me.xtpStockItemList.Text = "Lista de Insumo"
        '
        'gpStockItemBOM
        '
        Me.gpStockItemBOM.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpStockItemBOM.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.gpStockItemBOM.AppearanceCaption.Options.UseFont = True
        Me.gpStockItemBOM.AppearanceCaption.Options.UseForeColor = True
        Me.gpStockItemBOM.Controls.Add(Me.grdStockItemBOM)
        Me.gpStockItemBOM.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Add", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Delete", -1)})
        Me.gpStockItemBOM.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gpStockItemBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpStockItemBOM.Enabled = False
        Me.gpStockItemBOM.Location = New System.Drawing.Point(0, 0)
        Me.gpStockItemBOM.Name = "gpStockItemBOM"
        Me.gpStockItemBOM.Size = New System.Drawing.Size(603, 212)
        Me.gpStockItemBOM.TabIndex = 128
        Me.gpStockItemBOM.Text = "Lista de Artículos de Inventario"
        '
        'grdStockItemBOM
        '
        Me.grdStockItemBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdStockItemBOM.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.grdStockItemBOM.Location = New System.Drawing.Point(2, 26)
        Me.grdStockItemBOM.MainView = Me.gvStockItemBOM
        Me.grdStockItemBOM.Name = "grdStockItemBOM"
        Me.grdStockItemBOM.Size = New System.Drawing.Size(599, 184)
        Me.grdStockItemBOM.TabIndex = 128
        Me.grdStockItemBOM.UseEmbeddedNavigator = True
        Me.grdStockItemBOM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItemBOM})
        '
        'gvStockItemBOM
        '
        Me.gvStockItemBOM.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvStockItemBOM.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemBOM.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvStockItemBOM.Appearance.EvenRow.Options.UseFont = True
        Me.gvStockItemBOM.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStockItemBOM.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvStockItemBOM.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvStockItemBOM.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvStockItemBOM.Appearance.OddRow.Options.UseBackColor = True
        Me.gvStockItemBOM.Appearance.OddRow.Options.UseFont = True
        Me.gvStockItemBOM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn8, Me.GridColumn9})
        Me.gvStockItemBOM.GridControl = Me.grdStockItemBOM
        Me.gvStockItemBOM.Name = "gvStockItemBOM"
        Me.gvStockItemBOM.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Código"
        Me.GridColumn6.FieldName = "StockCode"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Descripción"
        Me.GridColumn8.FieldName = "Description"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Cantidad"
        Me.GridColumn9.FieldName = "Quantity"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'xtpWoodBOM
        '
        Me.xtpWoodBOM.Controls.Add(Me.GroupControl2)
        Me.xtpWoodBOM.Name = "xtpWoodBOM"
        Me.xtpWoodBOM.Size = New System.Drawing.Size(603, 212)
        Me.xtpWoodBOM.Text = "Lista de Madera"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(603, 212)
        Me.GroupControl2.TabIndex = 129
        Me.GroupControl2.Text = "Lista de Artículos de Madera"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 21)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(599, 189)
        Me.GridControl2.TabIndex = 128
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(624, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(26, 14)
        Me.LabelControl4.TabIndex = 144
        Me.LabelControl4.Text = "Plano"
        '
        'bteDrawing
        '
        Me.bteDrawing.Location = New System.Drawing.Point(656, 23)
        Me.bteDrawing.Name = "bteDrawing"
        Me.bteDrawing.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bteDrawing.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteDrawing.Properties.Appearance.Options.UseBackColor = True
        Me.bteDrawing.Properties.Appearance.Options.UseFont = True
        Me.bteDrawing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.bteDrawing.Size = New System.Drawing.Size(329, 20)
        Me.bteDrawing.TabIndex = 143
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(9, 122)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(21, 14)
        Me.LabelControl3.TabIndex = 142
        Me.LabelControl3.Text = "UdM"
        '
        'cboUoM
        '
        Me.cboUoM.Location = New System.Drawing.Point(99, 119)
        Me.cboUoM.Name = "cboUoM"
        Me.cboUoM.Properties.AllowMouseWheel = False
        Me.cboUoM.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUoM.Properties.Appearance.Options.UseFont = True
        Me.cboUoM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUoM.Properties.ReadOnly = True
        Me.cboUoM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUoM.Size = New System.Drawing.Size(242, 20)
        Me.cboUoM.TabIndex = 141
        '
        'btnGenerateCode
        '
        Me.btnGenerateCode.Location = New System.Drawing.Point(255, 70)
        Me.btnGenerateCode.Name = "btnGenerateCode"
        Me.btnGenerateCode.Size = New System.Drawing.Size(86, 23)
        Me.btnGenerateCode.TabIndex = 140
        Me.btnGenerateCode.Text = "Generar Código"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(9, 218)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 14)
        Me.LabelControl2.TabIndex = 139
        Me.LabelControl2.Text = "Sub Tipo de Producto"
        '
        'cboSubItemType
        '
        Me.cboSubItemType.Location = New System.Drawing.Point(118, 215)
        Me.cboSubItemType.Name = "cboSubItemType"
        Me.cboSubItemType.Properties.AllowMouseWheel = False
        Me.cboSubItemType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubItemType.Properties.Appearance.Options.UseFont = True
        Me.cboSubItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSubItemType.Properties.ReadOnly = True
        Me.cboSubItemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSubItemType.Size = New System.Drawing.Size(223, 20)
        Me.cboSubItemType.TabIndex = 138
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(9, 170)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl22.TabIndex = 137
        Me.LabelControl22.Text = "Tipo Producto"
        '
        'cboProductItemType
        '
        Me.cboProductItemType.Location = New System.Drawing.Point(99, 167)
        Me.cboProductItemType.Name = "cboProductItemType"
        Me.cboProductItemType.Properties.AllowMouseWheel = False
        Me.cboProductItemType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductItemType.Properties.Appearance.Options.UseFont = True
        Me.cboProductItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProductItemType.Properties.ReadOnly = True
        Me.cboProductItemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboProductItemType.Size = New System.Drawing.Size(242, 20)
        Me.cboProductItemType.TabIndex = 136
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(9, 26)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl8.TabIndex = 133
        Me.LabelControl8.Text = "Descripción"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(9, 74)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl1.TabIndex = 135
        Me.LabelControl1.Text = "Código"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(99, 23)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(512, 20)
        Me.txtDescription.TabIndex = 132
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(99, 71)
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockCode.Properties.Appearance.Options.UseFont = True
        Me.txtStockCode.Properties.MaxLength = 25
        Me.txtStockCode.Properties.ReadOnly = True
        Me.txtStockCode.Size = New System.Drawing.Size(150, 20)
        Me.txtStockCode.TabIndex = 134
        '
        'chkIsGeneric
        '
        Me.chkIsGeneric.Location = New System.Drawing.Point(7, 266)
        Me.chkIsGeneric.Name = "chkIsGeneric"
        Me.chkIsGeneric.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.chkIsGeneric.Properties.Appearance.Options.UseForeColor = True
        Me.chkIsGeneric.Properties.Caption = "¿Es Generico?"
        Me.chkIsGeneric.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkIsGeneric.Size = New System.Drawing.Size(124, 19)
        Me.chkIsGeneric.TabIndex = 146
        '
        'lblStockItemID
        '
        Me.lblStockItemID.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblStockItemID.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStockItemID.Appearance.Options.UseFont = True
        Me.lblStockItemID.Appearance.Options.UseForeColor = True
        Me.lblStockItemID.Appearance.Options.UseTextOptions = True
        Me.lblStockItemID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblStockItemID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStockItemID.Location = New System.Drawing.Point(817, 3)
        Me.lblStockItemID.Name = "lblStockItemID"
        Me.lblStockItemID.Size = New System.Drawing.Size(168, 14)
        Me.lblStockItemID.TabIndex = 147
        Me.lblStockItemID.Text = "ID:"
        '
        'uctProductBaseDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblStockItemID)
        Me.Controls.Add(Me.chkIsGeneric)
        Me.Controls.Add(Me.XtraTabControl2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.bteDrawing)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cboUoM)
        Me.Controls.Add(Me.btnGenerateCode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboSubItemType)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.cboProductItemType)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtStockCode)
        Me.Name = "uctProductBaseDetail"
        Me.Size = New System.Drawing.Size(1000, 315)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.xtpProductBOM.ResumeLayout(False)
        CType(Me.gpProductBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpProductBOM.ResumeLayout(False)
        CType(Me.grdProductBOMs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductBOMs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpStockItemList.ResumeLayout(False)
        CType(Me.gpStockItemBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpStockItemBOM.ResumeLayout(False)
        CType(Me.grdStockItemBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStockItemBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpWoodBOM.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bteDrawing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUoM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProductItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsGeneric.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpProductBOM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpStockItemList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gpStockItemBOM As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdStockItemBOM As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStockItemBOM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpWoodBOM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bteDrawing As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUoM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnGenerateCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSubItemType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboProductItemType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkIsGeneric As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblStockItemID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpProductBOM As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdProductBOMs As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductBOMs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
