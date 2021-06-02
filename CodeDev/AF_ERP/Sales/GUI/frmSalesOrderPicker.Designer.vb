<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrderPicker))
        Me.repbtnSelectOt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grdSalesOrder = New DevExpress.XtraGrid.GridControl()
        Me.gvSalesOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepbtnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grdSalesOrder
        '
        Me.grdSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSalesOrder.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdSalesOrder.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdSalesOrder.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdSalesOrder.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdSalesOrder.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdSalesOrder.Location = New System.Drawing.Point(0, 0)
        Me.grdSalesOrder.MainView = Me.gvSalesOrder
        Me.grdSalesOrder.Name = "grdSalesOrder"
        Me.grdSalesOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepbtnSelect, Me.RepositoryItemDateEdit1})
        Me.grdSalesOrder.Size = New System.Drawing.Size(876, 358)
        Me.grdSalesOrder.TabIndex = 4
        Me.grdSalesOrder.UseEmbeddedNavigator = True
        Me.grdSalesOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesOrder})
        '
        'gvSalesOrder
        '
        Me.gvSalesOrder.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvSalesOrder.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrder.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvSalesOrder.Appearance.EvenRow.Options.UseFont = True
        Me.gvSalesOrder.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvSalesOrder.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSalesOrder.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvSalesOrder.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrder.Appearance.OddRow.Options.UseBackColor = True
        Me.gvSalesOrder.Appearance.OddRow.Options.UseFont = True
        Me.gvSalesOrder.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrder.Appearance.Row.Options.UseFont = True
        Me.gvSalesOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.GridColumn7, Me.GridColumn3})
        Me.gvSalesOrder.GridControl = Me.grdSalesOrder
        Me.gvSalesOrder.Name = "gvSalesOrder"
        Me.gvSalesOrder.OptionsView.EnableAppearanceEvenRow = True
        Me.gvSalesOrder.OptionsView.EnableAppearanceOddRow = True
        Me.gvSalesOrder.OptionsView.ShowAutoFilterRow = True
        Me.gvSalesOrder.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "OT #"
        Me.GridColumn6.ColumnEdit = Me.repbtnSelectOt
        Me.GridColumn6.FieldName = "OrderNo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 102
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proyecto"
        Me.GridColumn1.FieldName = "ProjectName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Ingresada"
        Me.GridColumn2.FieldName = "DateEntered"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 272
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "SalesOrderID"
        Me.GridColumn5.FieldName = "SalesOrderID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 108
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Entrega"
        Me.GridColumn7.FieldName = "FinishDate"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 107
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "CompanyName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
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
        'frmSalesOrderPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 358)
        Me.Controls.Add(Me.grdSalesOrder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalesOrderPicker"
        Me.Text = "Seleccionador de Orden de Venta"
        CType(Me.repbtnSelectOt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents repbtnSelectOt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents grdSalesOrder As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSalesOrder As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepbtnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
