<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickerStockItem
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
    Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
    Me.grdItemList = New DevExpress.XtraGrid.GridControl()
    Me.gvItemList = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoItemSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.gcDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcItemType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSubItemType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repoItemRemove = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repoItemRemove, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdItemList
    '
    Me.grdItemList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grdItemList.Location = New System.Drawing.Point(12, 12)
    Me.grdItemList.MainView = Me.gvItemList
    Me.grdItemList.Name = "grdItemList"
    Me.grdItemList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoItemSelect, Me.repoItemRemove})
    Me.grdItemList.Size = New System.Drawing.Size(939, 437)
    Me.grdItemList.TabIndex = 98
    Me.grdItemList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemList})
    '
    'gvItemList
    '
    Me.gvItemList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvItemList.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvItemList.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvItemList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.gvItemList.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvItemList.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvItemList.Appearance.Row.Options.UseFont = True
    Me.gvItemList.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvItemList.Appearance.SelectedRow.Options.UseFont = True
    Me.gvItemList.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvItemList.Appearance.TopNewRow.Options.UseFont = True
    Me.gvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcStockCode, Me.gcDescription, Me.gcCategory, Me.gcItemType, Me.gcSubItemType})
    Me.gvItemList.GridControl = Me.grdItemList
    Me.gvItemList.HorzScrollStep = 20
    Me.gvItemList.Name = "gvItemList"
    Me.gvItemList.OptionsFind.AlwaysVisible = True
    Me.gvItemList.OptionsView.ShowAutoFilterRow = True
    Me.gvItemList.OptionsView.ShowDetailButtons = False
    Me.gvItemList.OptionsView.ShowGroupPanel = False
    '
    'gcID
    '
    Me.gcID.Caption = "ID"
    Me.gcID.FieldName = "StockItemID"
    Me.gcID.Name = "gcID"
    Me.gcID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcID.Width = 82
    '
    'gcStockCode
    '
    Me.gcStockCode.ColumnEdit = Me.repoItemSelect
    Me.gcStockCode.FieldName = "StockCode"
    Me.gcStockCode.Name = "gcStockCode"
    Me.gcStockCode.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcStockCode.Visible = True
    Me.gcStockCode.VisibleIndex = 0
    Me.gcStockCode.Width = 126
    '
    'repoItemSelect
    '
    Me.repoItemSelect.AutoHeight = False
    Me.repoItemSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "  Select  ", -1, True, True, True, EditorButtonImageOptions1)})
    Me.repoItemSelect.Name = "repoItemSelect"
    Me.repoItemSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'gcDescription
    '
    Me.gcDescription.FieldName = "Description"
    Me.gcDescription.Name = "gcDescription"
    Me.gcDescription.OptionsColumn.ReadOnly = True
    Me.gcDescription.Visible = True
    Me.gcDescription.VisibleIndex = 1
    Me.gcDescription.Width = 470
    '
    'gcCategory
    '
    Me.gcCategory.Caption = "Category"
    Me.gcCategory.FieldName = "Category"
    Me.gcCategory.Name = "gcCategory"
    Me.gcCategory.Visible = True
    Me.gcCategory.VisibleIndex = 2
    Me.gcCategory.Width = 95
    '
    'gcItemType
    '
    Me.gcItemType.Caption = "Item Type"
    Me.gcItemType.FieldName = "ItemType"
    Me.gcItemType.Name = "gcItemType"
    Me.gcItemType.Visible = True
    Me.gcItemType.VisibleIndex = 3
    Me.gcItemType.Width = 103
    '
    'gcSubItemType
    '
    Me.gcSubItemType.Caption = "Sub Item Type"
    Me.gcSubItemType.FieldName = "UBSubItemType"
    Me.gcSubItemType.Name = "gcSubItemType"
    Me.gcSubItemType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcSubItemType.Visible = True
    Me.gcSubItemType.VisibleIndex = 4
    Me.gcSubItemType.Width = 127
    '
    'repoItemRemove
    '
    Me.repoItemRemove.AutoHeight = False
    Me.repoItemRemove.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Remove", -1, True, True, True, EditorButtonImageOptions2)})
    Me.repoItemRemove.Name = "repoItemRemove"
    Me.repoItemRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'frmPickerStockItem
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(963, 461)
    Me.Controls.Add(Me.grdItemList)
    Me.Name = "frmPickerStockItem"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Picker"
    CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repoItemRemove, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents grdItemList As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvItemList As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStockCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoItemSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcCategory As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSubItemType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoItemRemove As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
