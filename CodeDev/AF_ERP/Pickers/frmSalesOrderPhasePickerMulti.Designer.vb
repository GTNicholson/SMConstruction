<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesOrderPhasePickerMulti
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
    Me.grdWorkOrder = New DevExpress.XtraGrid.GridControl()
    Me.gvWorkOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcCallOffNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepbtnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repbtnUnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.repitTextOnly = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.btnConfirmSelection = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbtnUnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repitTextOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdWorkOrder
        '
        Me.grdWorkOrder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdWorkOrder.Location = New System.Drawing.Point(-1, 1)
        Me.grdWorkOrder.MainView = Me.gvWorkOrder
        Me.grdWorkOrder.Name = "grdWorkOrder"
        Me.grdWorkOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepbtnSelect, Me.RepositoryItemDateEdit1, Me.repbtnUnSelect, Me.repitTextOnly})
        Me.grdWorkOrder.Size = New System.Drawing.Size(1033, 534)
        Me.grdWorkOrder.TabIndex = 2
        Me.grdWorkOrder.UseEmbeddedNavigator = True
        Me.grdWorkOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrder})
        '
        'gvWorkOrder
        '
        Me.gvWorkOrder.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWorkOrder.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWorkOrder.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrder.Appearance.Row.Options.UseFont = True
        Me.gvWorkOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcCallOffNo, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn3, Me.GridColumn7})
        Me.gvWorkOrder.GridControl = Me.grdWorkOrder
        Me.gvWorkOrder.Name = "gvWorkOrder"
        Me.gvWorkOrder.OptionsView.ShowAutoFilterRow = True
        Me.gvWorkOrder.OptionsView.ShowGroupPanel = False
        '
        'gcCallOffNo
        '
        Me.gcCallOffNo.Caption = "Ref. Fase"
        Me.gcCallOffNo.ColumnEdit = Me.RepbtnSelect
        Me.gcCallOffNo.FieldName = "SOPJobNo"
        Me.gcCallOffNo.Name = "gcCallOffNo"
        Me.gcCallOffNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcCallOffNo.Visible = True
        Me.gcCallOffNo.VisibleIndex = 0
        Me.gcCallOffNo.Width = 128
        '
        'RepbtnSelect
        '
        Me.RepbtnSelect.AutoHeight = False
        Me.RepbtnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Select", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepbtnSelect.Name = "RepbtnSelect"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proyecto"
        Me.GridColumn1.FieldName = "ProjectName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 347
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
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 139
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
        Me.GridColumn5.FieldName = "SalesOrderPhaseID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 108
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "CompanyName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 302
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Enviada"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn7.FieldName = "DateCommitted"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 149
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
        Me.btnConfirmSelection.Location = New System.Drawing.Point(888, 541)
        Me.btnConfirmSelection.Name = "btnConfirmSelection"
        Me.btnConfirmSelection.Size = New System.Drawing.Size(133, 23)
        Me.btnConfirmSelection.TabIndex = 3
        Me.btnConfirmSelection.Text = "Aceptar Selección"
        '
        'frmSalesOrderPhasePickerMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 576)
        Me.Controls.Add(Me.btnConfirmSelection)
        Me.Controls.Add(Me.grdWorkOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSalesOrderPhasePickerMulti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Fases"
        CType(Me.grdWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbtnUnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repitTextOnly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdWorkOrder As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorkOrder As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepbtnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCallOffNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnConfirmSelection As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents repbtnUnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repitTextOnly As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
