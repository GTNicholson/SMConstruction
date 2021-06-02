<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickerPurchaseOrder
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickerPurchaseOrder))
        Me.grdItemList = New DevExpress.XtraGrid.GridControl()
        Me.gvItemList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPONum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoItemSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.gcRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoOpenPO = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoOpenPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdItemList
        '
        Me.grdItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdItemList.Location = New System.Drawing.Point(0, 0)
        Me.grdItemList.MainView = Me.gvItemList
        Me.grdItemList.Name = "grdItemList"
        Me.grdItemList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoItemSelect, Me.RepositoryItemDateEdit1, Me.repoOpenPO})
        Me.grdItemList.Size = New System.Drawing.Size(1227, 465)
        Me.grdItemList.TabIndex = 98
        Me.grdItemList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemList})
        '
        'gvItemList
        '
        Me.gvItemList.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvItemList.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvItemList.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvItemList.Appearance.EvenRow.Options.UseFont = True
        Me.gvItemList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvItemList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvItemList.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvItemList.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvItemList.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvItemList.Appearance.OddRow.Options.UseBackColor = True
        Me.gvItemList.Appearance.OddRow.Options.UseFont = True
        Me.gvItemList.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemList.Appearance.Row.Options.UseFont = True
        Me.gvItemList.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemList.Appearance.SelectedRow.Options.UseFont = True
        Me.gvItemList.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemList.Appearance.TopNewRow.Options.UseFont = True
        Me.gvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcPONum, Me.gcRequiredDate, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gvItemList.GridControl = Me.grdItemList
        Me.gvItemList.HorzScrollStep = 20
        Me.gvItemList.Name = "gvItemList"
        Me.gvItemList.OptionsFind.AlwaysVisible = True
        Me.gvItemList.OptionsView.EnableAppearanceEvenRow = True
        Me.gvItemList.OptionsView.EnableAppearanceOddRow = True
        Me.gvItemList.OptionsView.ShowAutoFilterRow = True
        Me.gvItemList.OptionsView.ShowDetailButtons = False
        Me.gvItemList.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "PurchaseOrderID"
        Me.gcID.Name = "gcID"
        Me.gcID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcID.Width = 82
        '
        'gcPONum
        '
        Me.gcPONum.Caption = "# O.C."
        Me.gcPONum.ColumnEdit = Me.repoItemSelect
        Me.gcPONum.FieldName = "PONum"
        Me.gcPONum.Name = "gcPONum"
        Me.gcPONum.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcPONum.Visible = True
        Me.gcPONum.VisibleIndex = 0
        Me.gcPONum.Width = 136
        '
        'repoItemSelect
        '
        Me.repoItemSelect.AutoHeight = False
        Me.repoItemSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoItemSelect.Name = "repoItemSelect"
        '
        'gcRequiredDate
        '
        Me.gcRequiredDate.Caption = "Fecha Requerida"
        Me.gcRequiredDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.gcRequiredDate.FieldName = "RequiredDate"
        Me.gcRequiredDate.Name = "gcRequiredDate"
        Me.gcRequiredDate.OptionsColumn.ReadOnly = True
        Me.gcRequiredDate.Visible = True
        Me.gcRequiredDate.VisibleIndex = 3
        Me.gcRequiredDate.Width = 116
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ref. Mat."
        Me.GridColumn1.FieldName = "RefMatType"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 109
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Estado"
        Me.GridColumn2.FieldName = "PurchaseStateDes"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 98
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Categoría"
        Me.GridColumn3.FieldName = "CategoryDesc"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 226
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Proveedor"
        Me.GridColumn4.FieldName = "CompanyName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 308
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ver OC."
        Me.GridColumn5.ColumnEdit = Me.repoOpenPO
        Me.GridColumn5.FieldName = "FileName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        Me.GridColumn5.Width = 216
        '
        'repoOpenPO
        '
        Me.repoOpenPO.AutoHeight = False
        Me.repoOpenPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, " Abrir", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoOpenPO.Name = "repoOpenPO"
        '
        'frmPickerPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 465)
        Me.Controls.Add(Me.grdItemList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPickerPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccionar Orden de Compra"
        CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoOpenPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdItemList As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvItemList As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPONum As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repoItemSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoOpenPO As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
