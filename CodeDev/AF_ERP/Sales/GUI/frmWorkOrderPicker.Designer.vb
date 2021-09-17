<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkOrderPicker
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkOrderPicker))
        Me.repbtnSelectOt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grdWorkOrder = New DevExpress.XtraGrid.GridControl()
        Me.gvWorkOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcWorkOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoItemSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepoItemButtonEditRemove = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.repoSelectItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemButtonEditRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoSelectItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repbtnSelectOt
        '
        Me.repbtnSelectOt.AutoHeight = False
        Me.repbtnSelectOt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repbtnSelectOt.Name = "repbtnSelectOt"
        '
        'grdWorkOrder
        '
        Me.grdWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdWorkOrder.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdWorkOrder.Location = New System.Drawing.Point(0, 0)
        Me.grdWorkOrder.MainView = Me.gvWorkOrder
        Me.grdWorkOrder.Name = "grdWorkOrder"
        Me.grdWorkOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoItemSelect, Me.RepositoryItemDateEdit1, Me.RepoItemButtonEditRemove, Me.repoSelectItem})
        Me.grdWorkOrder.Size = New System.Drawing.Size(1051, 347)
        Me.grdWorkOrder.TabIndex = 3
        Me.grdWorkOrder.UseEmbeddedNavigator = True
        Me.grdWorkOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrder})
        '
        'gvWorkOrder
        '
        Me.gvWorkOrder.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvWorkOrder.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrder.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvWorkOrder.Appearance.EvenRow.Options.UseFont = True
        Me.gvWorkOrder.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWorkOrder.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWorkOrder.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvWorkOrder.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrder.Appearance.OddRow.Options.UseBackColor = True
        Me.gvWorkOrder.Appearance.OddRow.Options.UseFont = True
        Me.gvWorkOrder.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrder.Appearance.Row.Options.UseFont = True
        Me.gvWorkOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcWorkOrderID, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.gvWorkOrder.GridControl = Me.grdWorkOrder
        Me.gvWorkOrder.Name = "gvWorkOrder"
        Me.gvWorkOrder.OptionsView.EnableAppearanceEvenRow = True
        Me.gvWorkOrder.OptionsView.EnableAppearanceOddRow = True
        Me.gvWorkOrder.OptionsView.ShowAutoFilterRow = True
        Me.gvWorkOrder.OptionsView.ShowGroupPanel = False
        '
        'gcWorkOrderID
        '
        Me.gcWorkOrderID.Caption = "OT #"
        Me.gcWorkOrderID.ColumnEdit = Me.repoSelectItem
        Me.gcWorkOrderID.FieldName = "WorkOrderNo"
        Me.gcWorkOrderID.Name = "gcWorkOrderID"
        Me.gcWorkOrderID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcWorkOrderID.Visible = True
        Me.gcWorkOrderID.VisibleIndex = 0
        Me.gcWorkOrderID.Width = 180
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Descripción"
        Me.GridColumn1.FieldName = "Description"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 314
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Proyecto"
        Me.GridColumn2.FieldName = "ProjectName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 309
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "CustomerName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 229
        '
        'repoItemSelect
        '
        Me.repoItemSelect.AutoHeight = False
        Me.repoItemSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoItemSelect.Name = "repoItemSelect"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepoItemButtonEditRemove
        '
        Me.RepoItemButtonEditRemove.AutoHeight = False
        Me.RepoItemButtonEditRemove.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Remover", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepoItemButtonEditRemove.Name = "RepoItemButtonEditRemove"
        '
        'repoSelectItem
        '
        Me.repoSelectItem.AutoHeight = False
        Me.repoSelectItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoSelectItem.Name = "repoSelectItem"
        '
        'frmWorkOrderPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 347)
        Me.Controls.Add(Me.grdWorkOrder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWorkOrderPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccionador de OT"
        Me.TopMost = True
        CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemButtonEditRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoSelectItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdWorkOrder As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorkOrder As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcWorkOrderID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepbtnSelects As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repbtnSelectOt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repoItemSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoItemButtonEditRemove As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents repoSelectItem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
