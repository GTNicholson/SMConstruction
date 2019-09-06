<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLookupTableList
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
    Me.grdLookUpList = New DevExpress.XtraGrid.GridControl()
    Me.gvLookUpTable = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcLookUpTableID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.gcLookUpDesc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcLookUpTableName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcLookupSectionCode = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.grdLookUpList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvLookUpTable, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdLookUpList
    '
    Me.grdLookUpList.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdLookUpList.Location = New System.Drawing.Point(0, 0)
    Me.grdLookUpList.MainView = Me.gvLookUpTable
    Me.grdLookUpList.Name = "grdLookUpList"
    Me.grdLookUpList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemButtonEdit})
    Me.grdLookUpList.Size = New System.Drawing.Size(679, 853)
    Me.grdLookUpList.TabIndex = 77
    Me.grdLookUpList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLookUpTable})
    '
    'gvLookUpTable
    '
    Me.gvLookUpTable.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.gvLookUpTable.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvLookUpTable.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvLookUpTable.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.gvLookUpTable.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvLookUpTable.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.gvLookUpTable.Appearance.Row.Options.UseFont = True
    Me.gvLookUpTable.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.gvLookUpTable.Appearance.SelectedRow.Options.UseFont = True
    Me.gvLookUpTable.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.gvLookUpTable.Appearance.TopNewRow.Options.UseFont = True
    Me.gvLookUpTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcLookUpTableID, Me.gcLookUpDesc, Me.gcLookUpTableName, Me.gcLookupSectionCode})
    Me.gvLookUpTable.GridControl = Me.grdLookUpList
    Me.gvLookUpTable.GroupCount = 1
    Me.gvLookUpTable.HorzScrollStep = 20
    Me.gvLookUpTable.Name = "gvLookUpTable"
    Me.gvLookUpTable.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvLookUpTable.OptionsView.ShowGroupPanel = False
    Me.gvLookUpTable.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcLookupSectionCode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'gcLookUpTableID
    '
    Me.gcLookUpTableID.Caption = "Editar"
    Me.gcLookUpTableID.ColumnEdit = Me.RepItemButtonEdit
    Me.gcLookUpTableID.FieldName = "LookUpTableID"
    Me.gcLookUpTableID.Name = "gcLookUpTableID"
    Me.gcLookUpTableID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcLookUpTableID.Visible = True
    Me.gcLookUpTableID.VisibleIndex = 0
    Me.gcLookUpTableID.Width = 79
    '
    'RepItemButtonEdit
    '
    Me.RepItemButtonEdit.AutoHeight = False
    SerializableAppearanceObject1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    SerializableAppearanceObject1.Options.UseFont = True
    SerializableAppearanceObject2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    SerializableAppearanceObject2.Options.UseFont = True
    SerializableAppearanceObject3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    SerializableAppearanceObject3.Options.UseFont = True
    SerializableAppearanceObject4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    SerializableAppearanceObject4.Options.UseFont = True
    Me.RepItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "  Edit  ", 50, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing)})
    Me.RepItemButtonEdit.Name = "RepItemButtonEdit"
    Me.RepItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
    '
    'gcLookUpDesc
    '
    Me.gcLookUpDesc.Caption = "Descripción"
    Me.gcLookUpDesc.FieldName = "LookUpTableDescription"
    Me.gcLookUpDesc.Name = "gcLookUpDesc"
    Me.gcLookUpDesc.Visible = True
    Me.gcLookUpDesc.VisibleIndex = 1
    Me.gcLookUpDesc.Width = 393
    '
    'gcLookUpTableName
    '
    Me.gcLookUpTableName.Caption = "Tabla"
    Me.gcLookUpTableName.FieldName = "TableName"
    Me.gcLookUpTableName.Name = "gcLookUpTableName"
    Me.gcLookUpTableName.Width = 188
    '
    'gcLookupSectionCode
    '
    Me.gcLookupSectionCode.Caption = "Grupo"
    Me.gcLookupSectionCode.FieldName = "SelectionCode"
    Me.gcLookupSectionCode.Name = "gcLookupSectionCode"
    Me.gcLookupSectionCode.Visible = True
    Me.gcLookupSectionCode.VisibleIndex = 3
    '
    'frmLookupTableList
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(679, 853)
    Me.Controls.Add(Me.grdLookUpList)
    Me.Name = "frmLookupTableList"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Lista de Opciones"
    CType(Me.grdLookUpList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvLookUpTable, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents grdLookUpList As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvLookUpTable As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcLookUpTableID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcLookUpDesc As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcLookUpTableName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcLookupSectionCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
