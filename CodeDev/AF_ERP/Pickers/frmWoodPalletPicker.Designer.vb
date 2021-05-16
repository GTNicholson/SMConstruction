<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWoodPalletPicker
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
        Me.grdWoodPallet = New DevExpress.XtraGrid.GridControl()
        Me.gvWoodPallets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcWoodPalletRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepbtnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFarm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repbtnUnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.repitTextOnly = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnConfirmSelection = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdWoodPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWoodPallets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbtnUnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repitTextOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdWoodPallet
        '
        Me.grdWoodPallet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdWoodPallet.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdWoodPallet.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdWoodPallet.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdWoodPallet.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdWoodPallet.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdWoodPallet.Location = New System.Drawing.Point(-1, 1)
        Me.grdWoodPallet.MainView = Me.gvWoodPallets
        Me.grdWoodPallet.Name = "grdWoodPallet"
        Me.grdWoodPallet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepbtnSelect, Me.RepositoryItemDateEdit1, Me.repbtnUnSelect, Me.repitTextOnly})
        Me.grdWoodPallet.Size = New System.Drawing.Size(1271, 534)
        Me.grdWoodPallet.TabIndex = 2
        Me.grdWoodPallet.UseEmbeddedNavigator = True
        Me.grdWoodPallet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWoodPallets})
        '
        'gvWoodPallets
        '
        Me.gvWoodPallets.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWoodPallets.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWoodPallets.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWoodPallets.Appearance.Row.Options.UseFont = True
        Me.gvWoodPallets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcWoodPalletRef, Me.GridColumn4, Me.GridColumn5, Me.GridColumn3, Me.GridColumn9, Me.GridColumn1, Me.GridColumn2, Me.gcFarm})
        Me.gvWoodPallets.GridControl = Me.grdWoodPallet
        Me.gvWoodPallets.Name = "gvWoodPallets"
        Me.gvWoodPallets.OptionsView.ShowAutoFilterRow = True
        Me.gvWoodPallets.OptionsView.ShowGroupPanel = False
        '
        'gcWoodPalletRef
        '
        Me.gcWoodPalletRef.Caption = "Ref. Pallet"
        Me.gcWoodPalletRef.ColumnEdit = Me.RepbtnSelect
        Me.gcWoodPalletRef.FieldName = "PalletRef"
        Me.gcWoodPalletRef.Name = "gcWoodPalletRef"
        Me.gcWoodPalletRef.OptionsColumn.ReadOnly = True
        Me.gcWoodPalletRef.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcWoodPalletRef.Visible = True
        Me.gcWoodPalletRef.VisibleIndex = 0
        Me.gcWoodPalletRef.Width = 89
        '
        'RepbtnSelect
        '
        Me.RepbtnSelect.AutoHeight = False
        Me.RepbtnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Select", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepbtnSelect.Name = "RepbtnSelect"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.Caption = "Fecha Creada"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn4.FieldName = "CreatedDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
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
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.Caption = "WoodPalletID"
        Me.GridColumn5.FieldName = "WoodPalletID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Width = 108
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.Caption = "Descripción"
        Me.GridColumn3.FieldName = "Description"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 230
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn9.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn9.Caption = "Contenido"
        Me.GridColumn9.FieldName = "PalletTypeDesc"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 100
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "Ubicación Actual"
        Me.GridColumn1.FieldName = "LocationDesc"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.Caption = "Núm. Tarjeta"
        Me.GridColumn2.FieldName = "CardNumber"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'gcFarm
        '
        Me.gcFarm.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcFarm.AppearanceCell.Options.UseBackColor = True
        Me.gcFarm.Caption = "Finca"
        Me.gcFarm.FieldName = "FarmDesc"
        Me.gcFarm.Name = "gcFarm"
        Me.gcFarm.OptionsColumn.ReadOnly = True
        Me.gcFarm.Visible = True
        Me.gcFarm.VisibleIndex = 6
        '
        'repbtnUnSelect
        '
        Me.repbtnUnSelect.AutoHeight = False
        Me.repbtnUnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Remover", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
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
        Me.btnConfirmSelection.Location = New System.Drawing.Point(987, 541)
        Me.btnConfirmSelection.Name = "btnConfirmSelection"
        Me.btnConfirmSelection.Size = New System.Drawing.Size(133, 23)
        Me.btnConfirmSelection.TabIndex = 3
        Me.btnConfirmSelection.Text = "Aceptar Selección"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(1126, 541)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Salir"
        '
        'frmWoodPalletPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 576)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnConfirmSelection)
        Me.Controls.Add(Me.grdWoodPallet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmWoodPalletPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Pallets de Madera"
        CType(Me.grdWoodPallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWoodPallets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbtnUnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repitTextOnly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdWoodPallet As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWoodPallets As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents RepbtnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcWoodPalletRef As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnConfirmSelection As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents repbtnUnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repitTextOnly As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcFarm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
