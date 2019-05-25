<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(12, 21)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(749, 225)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.GridView1.Appearance.Row.Options.UseFont = True
    Me.GridView1.ColumnPanelRowHeight = 34
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn1, Me.GridColumn2, Me.Quantity, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "# Orden de Trabajo"
    Me.GridColumn1.FieldName = "WorkOrderNo"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 87
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tipo de Producto"
    Me.GridColumn2.FieldName = "ProductTypeID"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 7
    Me.GridColumn2.Width = 178
    '
    'Quantity
    '
    Me.Quantity.Caption = "Cantidad"
    Me.Quantity.Name = "Quantity"
    Me.Quantity.Visible = True
    Me.Quantity.VisibleIndex = 8
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Descripcion"
    Me.GridColumn3.FieldName = "Description"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 9
    Me.GridColumn3.Width = 178
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Proyecto"
    Me.GridColumn4.FieldName = "ProjectName"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 5
    Me.GridColumn4.Width = 176
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Estatus"
    Me.GridColumn5.FieldName = "OrderStatusEnum"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 2
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Numero Orden"
    Me.GridColumn6.FieldName = "OrderNo"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Ref. del Cliente"
    Me.GridColumn7.FieldName = "CustomerRef"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 10
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Responsable"
    Me.GridColumn8.FieldName = "ContractManagerID"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 11
    Me.GridColumn8.Width = 80
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Sector"
    Me.GridColumn9.FieldName = "BusinessSectorID"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 6
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Cliente"
    Me.GridColumn10.FieldName = "CompanyName"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 3
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Region"
    Me.GridColumn11.FieldName = "SalesAreaID"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 4
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "ID"
    Me.GridColumn12.FieldName = "WorkOrderID"
    Me.GridColumn12.Name = "GridColumn12"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(821, 512)
    Me.Controls.Add(Me.GridControl1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Quantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
