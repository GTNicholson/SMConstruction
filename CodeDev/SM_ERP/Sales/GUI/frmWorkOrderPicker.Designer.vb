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
    Me.repbtnSelectOt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.grdWorkOrder = New DevExpress.XtraGrid.GridControl()
    Me.gvWorkOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepbtnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'repbtnSelectOt
    '
    Me.repbtnSelectOt.AutoHeight = False
    Me.repbtnSelectOt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
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
    Me.grdWorkOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepbtnSelect, Me.RepositoryItemDateEdit1})
    Me.grdWorkOrder.Size = New System.Drawing.Size(876, 358)
    Me.grdWorkOrder.TabIndex = 3
    Me.grdWorkOrder.UseEmbeddedNavigator = True
    Me.grdWorkOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrder})
    '
    'gvWorkOrder
    '
    Me.gvWorkOrder.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvWorkOrder.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvWorkOrder.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvWorkOrder.Appearance.Row.Options.UseFont = True
    Me.gvWorkOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.GridColumn7})
    Me.gvWorkOrder.GridControl = Me.grdWorkOrder
    Me.gvWorkOrder.Name = "gvWorkOrder"
    Me.gvWorkOrder.OptionsView.ShowAutoFilterRow = True
    Me.gvWorkOrder.OptionsView.ShowGroupPanel = False
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "OT #"
    Me.GridColumn6.ColumnEdit = Me.repbtnSelectOt
    Me.GridColumn6.FieldName = "WorkOrderNo"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 0
    Me.GridColumn6.Width = 102
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Cliente"
    Me.GridColumn1.FieldName = "CompanyName"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 1
    Me.GridColumn1.Width = 85
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Project Name"
    Me.GridColumn2.FieldName = "ProjectName"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 2
    Me.GridColumn2.Width = 272
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "ProductionBatchID"
    Me.GridColumn5.FieldName = "WorkOrderID"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Width = 108
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Despatch Status"
    Me.GridColumn7.FieldName = "DespatchStatus"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 3
    Me.GridColumn7.Width = 107
    '
    'RepbtnSelect
    '
    Me.RepbtnSelect.AutoHeight = False
    Me.RepbtnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.RepbtnSelect.Name = "RepbtnSelect"
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    '
    'frmWorkOrderPicker
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(876, 358)
    Me.Controls.Add(Me.grdWorkOrder)
    Me.Name = "frmWorkOrderPicker"
    Me.Text = "frmWorkOrderPicker"
    CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents grdWorkOrder As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorkOrder As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepbtnSelects As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents repbtnSelectOt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents RepbtnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
