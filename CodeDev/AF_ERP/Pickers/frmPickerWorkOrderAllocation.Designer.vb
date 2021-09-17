<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPickerWorkOrderAllocation
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickerWorkOrderAllocation))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.repbtnSelectOt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grdWorkOrderAllocation = New DevExpress.XtraGrid.GridControl()
        Me.gvWorkOrderAllocation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcWorkOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoItemSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepoItemButtonEditRemove = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdWorkOrderAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWorkOrderAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoItemButtonEditRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repbtnSelectOt
        '
        Me.repbtnSelectOt.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.repbtnSelectOt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repbtnSelectOt.Name = "repbtnSelectOt"
        '
        'grdWorkOrderAllocation
        '
        Me.grdWorkOrderAllocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorkOrderAllocation.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdWorkOrderAllocation.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdWorkOrderAllocation.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdWorkOrderAllocation.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdWorkOrderAllocation.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdWorkOrderAllocation.Location = New System.Drawing.Point(0, 0)
        Me.grdWorkOrderAllocation.MainView = Me.gvWorkOrderAllocation
        Me.grdWorkOrderAllocation.Name = "grdWorkOrderAllocation"
        Me.grdWorkOrderAllocation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoItemSelect, Me.RepositoryItemDateEdit1, Me.RepoItemButtonEditRemove})
        Me.grdWorkOrderAllocation.Size = New System.Drawing.Size(1029, 358)
        Me.grdWorkOrderAllocation.TabIndex = 3
        Me.grdWorkOrderAllocation.UseEmbeddedNavigator = True
        Me.grdWorkOrderAllocation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrderAllocation})
        '
        'gvWorkOrderAllocation
        '
        Me.gvWorkOrderAllocation.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvWorkOrderAllocation.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrderAllocation.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvWorkOrderAllocation.Appearance.EvenRow.Options.UseFont = True
        Me.gvWorkOrderAllocation.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvWorkOrderAllocation.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvWorkOrderAllocation.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvWorkOrderAllocation.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrderAllocation.Appearance.OddRow.Options.UseBackColor = True
        Me.gvWorkOrderAllocation.Appearance.OddRow.Options.UseFont = True
        Me.gvWorkOrderAllocation.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvWorkOrderAllocation.Appearance.Row.Options.UseFont = True
        Me.gvWorkOrderAllocation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcWorkOrderNo, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gvWorkOrderAllocation.GridControl = Me.grdWorkOrderAllocation
        Me.gvWorkOrderAllocation.Name = "gvWorkOrderAllocation"
        Me.gvWorkOrderAllocation.OptionsView.EnableAppearanceEvenRow = True
        Me.gvWorkOrderAllocation.OptionsView.EnableAppearanceOddRow = True
        Me.gvWorkOrderAllocation.OptionsView.ShowAutoFilterRow = True
        Me.gvWorkOrderAllocation.OptionsView.ShowGroupPanel = False
        '
        'gcWorkOrderNo
        '
        Me.gcWorkOrderNo.Caption = "# OT"
        Me.gcWorkOrderNo.ColumnEdit = Me.repbtnSelectOt
        Me.gcWorkOrderNo.FieldName = "WorkOrderNo"
        Me.gcWorkOrderNo.Name = "gcWorkOrderNo"
        Me.gcWorkOrderNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gcWorkOrderNo.Visible = True
        Me.gcWorkOrderNo.VisibleIndex = 0
        Me.gcWorkOrderNo.Width = 205
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ref"
        Me.GridColumn1.FieldName = "Description"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 118
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Proyecto"
        Me.GridColumn2.FieldName = "ProjectName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 223
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Descripción"
        Me.GridColumn3.FieldName = "Description"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 259
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Req."
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn4.FieldName = "PlannedStartDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 125
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cliente"
        Me.GridColumn5.FieldName = "CompanyName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 198
        '
        'repoItemSelect
        '
        Me.repoItemSelect.AutoHeight = False
        Me.repoItemSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repoItemSelect.Name = "repoItemSelect"
        '
        'RepoItemButtonEditRemove
        '
        Me.RepoItemButtonEditRemove.AutoHeight = False
        Me.RepoItemButtonEditRemove.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepoItemButtonEditRemove.Name = "RepoItemButtonEditRemove"
        '
        'frmPickerWorkOrderAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 358)
        Me.Controls.Add(Me.grdWorkOrderAllocation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPickerWorkOrderAllocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccionador de OT"
        CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdWorkOrderAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWorkOrderAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoItemButtonEditRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdWorkOrderAllocation As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorkOrderAllocation As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcWorkOrderNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepbtnSelects As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents repbtnSelectOt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents repoItemSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepoItemButtonEditRemove As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
