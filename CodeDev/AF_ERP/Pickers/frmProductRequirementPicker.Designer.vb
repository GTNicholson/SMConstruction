<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductRequirementPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductRequirementPicker))
        Me.grdSalesOrderPhaseItemInfo = New DevExpress.XtraGrid.GridControl()
        Me.gvSalesOrderPhaseItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcItemNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepbtnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repbtnUnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.repitTextOnly = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnConfirmSelection = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdSalesOrderPhaseItemInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSalesOrderPhaseItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbtnUnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repitTextOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdSalesOrderPhaseItemInfo
        '
        Me.grdSalesOrderPhaseItemInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSalesOrderPhaseItemInfo.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdSalesOrderPhaseItemInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdSalesOrderPhaseItemInfo.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdSalesOrderPhaseItemInfo.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdSalesOrderPhaseItemInfo.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdSalesOrderPhaseItemInfo.Location = New System.Drawing.Point(-1, 1)
        Me.grdSalesOrderPhaseItemInfo.MainView = Me.gvSalesOrderPhaseItem
        Me.grdSalesOrderPhaseItemInfo.Name = "grdSalesOrderPhaseItemInfo"
        Me.grdSalesOrderPhaseItemInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepbtnSelect, Me.RepositoryItemDateEdit1, Me.repbtnUnSelect, Me.repitTextOnly})
        Me.grdSalesOrderPhaseItemInfo.Size = New System.Drawing.Size(1271, 534)
        Me.grdSalesOrderPhaseItemInfo.TabIndex = 2
        Me.grdSalesOrderPhaseItemInfo.UseEmbeddedNavigator = True
        Me.grdSalesOrderPhaseItemInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesOrderPhaseItem})
        '
        'gvSalesOrderPhaseItem
        '
        Me.gvSalesOrderPhaseItem.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvSalesOrderPhaseItem.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSalesOrderPhaseItem.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrderPhaseItem.Appearance.Row.Options.UseFont = True
        Me.gvSalesOrderPhaseItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcOrderNo, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn3, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.gcItemNumber, Me.GridColumn10})
        Me.gvSalesOrderPhaseItem.GridControl = Me.grdSalesOrderPhaseItemInfo
        Me.gvSalesOrderPhaseItem.Name = "gvSalesOrderPhaseItem"
        Me.gvSalesOrderPhaseItem.OptionsView.ShowAutoFilterRow = True
        Me.gvSalesOrderPhaseItem.OptionsView.ShowGroupPanel = False
        '
        'gcOrderNo
        '
        Me.gcOrderNo.Caption = "OrderNo"
        Me.gcOrderNo.FieldName = "OrderNo"
        Me.gcOrderNo.Name = "gcOrderNo"
        Me.gcOrderNo.Visible = True
        Me.gcOrderNo.VisibleIndex = 0
        Me.gcOrderNo.Width = 89
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proyecto"
        Me.GridColumn1.FieldName = "ProjectName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 186
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cantidad"
        Me.GridColumn2.FieldName = "Quantity"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 253
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Requerida"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn4.FieldName = "DateRequired"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        Me.GridColumn4.Width = 73
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "SOPID"
        Me.GridColumn5.FieldName = "SalesOrderPhaseItemID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 108
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "SalesOrderPhaseID"
        Me.GridColumn6.FieldName = "SalesOrderPhaseID"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "CompanyName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 230
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "SalesOrderItemID"
        Me.GridColumn7.FieldName = "SalesOrderItemID"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Descripción"
        Me.GridColumn8.FieldName = "Description"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 379
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "# OT"
        Me.GridColumn9.FieldName = "WorkOrderNo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 100
        '
        'gcItemNumber
        '
        Me.gcItemNumber.Caption = "Núm. Item"
        Me.gcItemNumber.ColumnEdit = Me.RepbtnSelect
        Me.gcItemNumber.FieldName = "ItemNumberRef"
        Me.gcItemNumber.Name = "gcItemNumber"
        Me.gcItemNumber.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcItemNumber.Visible = True
        Me.gcItemNumber.VisibleIndex = 1
        Me.gcItemNumber.Width = 80
        '
        'RepbtnSelect
        '
        Me.RepbtnSelect.AutoHeight = False
        Me.RepbtnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Select", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepbtnSelect.Name = "RepbtnSelect"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Casa"
        Me.GridColumn10.FieldName = "AssemblyRef"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 116
        '
        'repbtnUnSelect
        '
        Me.repbtnUnSelect.AutoHeight = False
        Me.repbtnUnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Unselect", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repbtnUnSelect.Name = "repbtnUnSelect"
        '
        'repitTextOnly
        '
        Me.repitTextOnly.AutoHeight = False
        Me.repitTextOnly.Name = "repitTextOnly"
        Me.repitTextOnly.ReadOnly = True
        '
        'btnConfirmSelection
        '
        Me.btnConfirmSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmSelection.Location = New System.Drawing.Point(1126, 541)
        Me.btnConfirmSelection.Name = "btnConfirmSelection"
        Me.btnConfirmSelection.Size = New System.Drawing.Size(133, 23)
        Me.btnConfirmSelection.TabIndex = 3
        Me.btnConfirmSelection.Text = "Aceptar Selección"
        '
        'frmProductRequirementPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 576)
        Me.Controls.Add(Me.btnConfirmSelection)
        Me.Controls.Add(Me.grdSalesOrderPhaseItemInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductRequirementPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Requerimientos de Productos"
        CType(Me.grdSalesOrderPhaseItemInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSalesOrderPhaseItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbtnUnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repitTextOnly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdSalesOrderPhaseItemInfo As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSalesOrderPhaseItem As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepbtnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOrderNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnConfirmSelection As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents repbtnUnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repitTextOnly As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcItemNumber As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
End Class
