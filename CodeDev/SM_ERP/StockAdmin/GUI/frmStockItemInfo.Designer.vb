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
    Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockItemInfo))
    Me.grpItemDetail = New DevExpress.XtraEditors.GroupControl()
    Me.grdStockItemInfos = New DevExpress.XtraGrid.GridControl()
    Me.gvStockCheckItem = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcStockItemID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitPUStockItemValuationHistorys = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
    Me.RepositoryItemSpinEditCounted = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.repitbtStockItemRefresh = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpItemDetail.SuspendLayout()
    CType(Me.grdStockItemInfos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvStockCheckItem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitPUStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSpinEditCounted, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitbtStockItemRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.grpItemDetail.Location = New System.Drawing.Point(12, 12)
    Me.grpItemDetail.Name = "grpItemDetail"
    Me.grpItemDetail.Size = New System.Drawing.Size(1346, 279)
    Me.grpItemDetail.TabIndex = 95
    Me.grpItemDetail.Text = "Stock Items"
    '
    'grdStockItemInfos
    '
    Me.grdStockItemInfos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdStockItemInfos.Location = New System.Drawing.Point(2, 26)
    Me.grdStockItemInfos.MainView = Me.gvStockCheckItem
    Me.grdStockItemInfos.Name = "grdStockItemInfos"
    Me.grdStockItemInfos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitPUStockItemValuationHistorys, Me.RepositoryItemSpinEditCounted, Me.repitbtStockItemRefresh})
    Me.grdStockItemInfos.Size = New System.Drawing.Size(1342, 251)
    Me.grdStockItemInfos.TabIndex = 6
    Me.grdStockItemInfos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockCheckItem})
    '
    'gvStockCheckItem
    '
    Me.gvStockCheckItem.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvStockCheckItem.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvStockCheckItem.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvStockCheckItem.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvStockCheckItem.Appearance.Row.BackColor = System.Drawing.Color.Lavender
    Me.gvStockCheckItem.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvStockCheckItem.Appearance.Row.Options.UseBackColor = True
    Me.gvStockCheckItem.Appearance.Row.Options.UseFont = True
    Me.gvStockCheckItem.ColumnPanelRowHeight = 34
    Me.gvStockCheckItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcStockItemID, Me.GridColumn8, Me.GridColumn1, Me.GridColumn6, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
    Me.gvStockCheckItem.CustomizationFormBounds = New System.Drawing.Rectangle(1156, 318, 210, 270)
    Me.gvStockCheckItem.GridControl = Me.grdStockItemInfos
    Me.gvStockCheckItem.Name = "gvStockCheckItem"
    Me.gvStockCheckItem.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvStockCheckItem.OptionsDetail.EnableMasterViewMode = False
    Me.gvStockCheckItem.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
    Me.gvStockCheckItem.OptionsView.ShowAutoFilterRow = True
    Me.gvStockCheckItem.OptionsView.ShowFooter = True
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
    Me.GridColumn8.VisibleIndex = 6
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "StockCode"
    Me.GridColumn1.FieldName = "StockCode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Descripción"
    Me.GridColumn6.FieldName = "Description"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 4
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Categoría"
    Me.GridColumn3.FieldName = "Category"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 1
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Sub Categoría"
    Me.GridColumn4.FieldName = "ItemType"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Núm. Parte"
    Me.GridColumn5.FieldName = "PartNo"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 3
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Supplier"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 5
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Inv. Actual"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 7
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Inv. Req"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 8
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Cant. Pedidas"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 9
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Balance"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 10
    '
    'repitPUStockItemValuationHistorys
    '
    Me.repitPUStockItemValuationHistorys.Appearance.Options.UseTextOptions = True
    Me.repitPUStockItemValuationHistorys.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.repitPUStockItemValuationHistorys.AutoHeight = False
    Me.repitPUStockItemValuationHistorys.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repitPUStockItemValuationHistorys.DisplayFormat.FormatString = "N2"
    Me.repitPUStockItemValuationHistorys.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.repitPUStockItemValuationHistorys.EditFormat.FormatString = "N2"
    Me.repitPUStockItemValuationHistorys.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.repitPUStockItemValuationHistorys.Name = "repitPUStockItemValuationHistorys"
    '
    'RepositoryItemSpinEditCounted
    '
    Me.RepositoryItemSpinEditCounted.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
    Me.RepositoryItemSpinEditCounted.AutoHeight = False
    Me.RepositoryItemSpinEditCounted.DisplayFormat.FormatString = "#.##"
    Me.RepositoryItemSpinEditCounted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemSpinEditCounted.EditFormat.FormatString = "#.##"
    Me.RepositoryItemSpinEditCounted.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.RepositoryItemSpinEditCounted.Name = "RepositoryItemSpinEditCounted"
    '
    'repitbtStockItemRefresh
    '
    Me.repitbtStockItemRefresh.AutoHeight = False
    EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
    Me.repitbtStockItemRefresh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
    Me.repitbtStockItemRefresh.Name = "repitbtStockItemRefresh"
    '
    'frmStockItemInfo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1370, 533)
    Me.Controls.Add(Me.grpItemDetail)
    Me.Name = "frmStockItemInfo"
    Me.Text = "frmStockItemInfo"
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpItemDetail.ResumeLayout(False)
    CType(Me.grdStockItemInfos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvStockCheckItem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitPUStockItemValuationHistorys, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSpinEditCounted, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitbtStockItemRefresh, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents grpItemDetail As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdStockItemInfos As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvStockCheckItem As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitPUStockItemValuationHistorys As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
  Friend WithEvents RepositoryItemSpinEditCounted As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents repitbtStockItemRefresh As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcStockItemID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
