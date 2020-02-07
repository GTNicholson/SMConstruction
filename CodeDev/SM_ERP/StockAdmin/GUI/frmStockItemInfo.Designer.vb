<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockItemInfo
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
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.grpItemDetail = New DevExpress.XtraEditors.GroupControl()
    Me.grdStockItemInfos = New DevExpress.XtraGrid.GridControl()
    Me.gvStockItemInfos = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcStockItemID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcItemType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitbtCurrentInventory = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpItemDetail.SuspendLayout()
    CType(Me.grdStockItemInfos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockItemInfos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitbtCurrentInventory, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grpItemDetail
    '
    Me.grpItemDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpItemDetail.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpItemDetail.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.grpItemDetail.Appearance.Options.UseFont = True
    Me.grpItemDetail.Appearance.Options.UseForeColor = True
    Me.grpItemDetail.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpItemDetail.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpItemDetail.AppearanceCaption.Options.UseFont = True
    Me.grpItemDetail.AppearanceCaption.Options.UseForeColor = True
    Me.grpItemDetail.Controls.Add(Me.grdStockItemInfos)
    Me.grpItemDetail.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Select All", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "SelectAll", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Clear Selection", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "ClearSelection", -1)})
    Me.grpItemDetail.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpItemDetail.Location = New System.Drawing.Point(3, 12)
    Me.grpItemDetail.Name = "grpItemDetail"
    Me.grpItemDetail.Size = New System.Drawing.Size(1362, 509)
    Me.grpItemDetail.TabIndex = 95
    Me.grpItemDetail.Text = "Stock Items"
    '
    'grdStockItemInfos
    '
    Me.grdStockItemInfos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockItemInfos.Location = New System.Drawing.Point(2, 26)
    Me.grdStockItemInfos.MainView = Me.gvStockItemInfos
    Me.grdStockItemInfos.Name = "grdStockItemInfos"
    Me.grdStockItemInfos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitbtCurrentInventory})
    Me.grdStockItemInfos.Size = New System.Drawing.Size(1358, 481)
    Me.grdStockItemInfos.TabIndex = 6
    Me.grdStockItemInfos.UseEmbeddedNavigator = True
    Me.grdStockItemInfos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockItemInfos})
    '
    'gvStockItemInfos
    '
    Me.gvStockItemInfos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvStockItemInfos.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockItemInfos.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvStockItemInfos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockItemInfos.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvStockItemInfos.Appearance.Row.Options.UseFont = True
    Me.gvStockItemInfos.ColumnPanelRowHeight = 34
    Me.gvStockItemInfos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcStockItemID, Me.GridColumn8, Me.GridColumn1, Me.GridColumn6, Me.gcCategory, Me.gcItemType, Me.GridColumn5, Me.GridColumn7, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.gcStdCost})
    Me.gvStockItemInfos.CustomizationFormBounds = New System.Drawing.Rectangle(1156, 318, 210, 270)
    Me.gvStockItemInfos.GridControl = Me.grdStockItemInfos
    Me.gvStockItemInfos.Name = "gvStockItemInfos"
    Me.gvStockItemInfos.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvStockItemInfos.OptionsView.ShowAutoFilterRow = True
    Me.gvStockItemInfos.OptionsView.ShowDetailButtons = False
    Me.gvStockItemInfos.OptionsView.ShowGroupPanel = False
    '
    'gcStockItemID
    '
    Me.gcStockItemID.Caption = "StockItemID"
    Me.gcStockItemID.FieldName = "StockItemId"
    Me.gcStockItemID.Name = "gcStockItemID"
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Código ASIS"
    Me.GridColumn8.FieldName = "ASISID"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 1
    Me.GridColumn8.Width = 33
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "StockCode"
    Me.GridColumn1.FieldName = "StockCode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 40
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Descripción"
    Me.GridColumn6.FieldName = "Description"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    Me.GridColumn6.Width = 133
    '
    'gcCategory
    '
    Me.gcCategory.Caption = "Categoría"
    Me.gcCategory.FieldName = "Category"
    Me.gcCategory.Name = "gcCategory"
    Me.gcCategory.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
    Me.gcCategory.Visible = True
    Me.gcCategory.VisibleIndex = 2
    Me.gcCategory.Width = 63
    '
    'gcItemType
    '
    Me.gcItemType.Caption = "Sub Categoría"
    Me.gcItemType.FieldName = "gc"
    Me.gcItemType.Name = "gcItemType"
    Me.gcItemType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcItemType.Visible = True
    Me.gcItemType.VisibleIndex = 3
    Me.gcItemType.Width = 63
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Núm. Parte"
    Me.GridColumn5.FieldName = "PartNo"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    Me.GridColumn5.Width = 50
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Supplier"
    Me.GridColumn7.FieldName = "DefaultSupplier"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 7
    Me.GridColumn7.Width = 103
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Inv. Actual"
    Me.GridColumn9.ColumnEdit = Me.repitbtCurrentInventory
    Me.GridColumn9.FieldName = "CurrentInventory"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 8
    Me.GridColumn9.Width = 36
    '
    'repitbtCurrentInventory
    '
    Me.repitbtCurrentInventory.AutoHeight = False
    Me.repitbtCurrentInventory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.repitbtCurrentInventory.Name = "repitbtCurrentInventory"
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Inv. Req"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 9
    Me.GridColumn10.Width = 36
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Cant. Pedidas"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 10
    Me.GridColumn11.Width = 36
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Balance"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 11
    Me.GridColumn12.Width = 53
    '
    'gcStdCost
    '
    Me.gcStdCost.Caption = "Costo Unitario"
    Me.gcStdCost.FieldName = "StdCost"
    Me.gcStdCost.Name = "gcStdCost"
    Me.gcStdCost.Visible = True
    Me.gcStdCost.VisibleIndex = 6
    Me.gcStdCost.Width = 46
    '
    'frmStockItemInfo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1370, 533)
    Me.Controls.Add(Me.grpItemDetail)
    Me.Name = "frmStockItemInfo"
    Me.Text = "Información de Inventario"
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpItemDetail.ResumeLayout(False)
    CType(Me.grdStockItemInfos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockItemInfos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitbtCurrentInventory, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents grpItemDetail As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdStockItemInfos As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockItemInfos As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockItemID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitbtCurrentInventory As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcStdCost As DevExpress.XtraGrid.Columns.GridColumn
End Class
