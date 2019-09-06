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
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(12, 21)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(1181, 343)
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn6, Me.GridColumn10, Me.GridColumn3, Me.Quantity, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn8, Me.GridColumn13, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "ID"
    Me.GridColumn12.FieldName = "WorkOrderID"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.OptionsColumn.ReadOnly = True
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "# Orden de Compra"
    Me.GridColumn6.FieldName = "OrderNo"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.ReadOnly = True
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 0
    Me.GridColumn6.Width = 124
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Cliente"
    Me.GridColumn10.FieldName = "CompanyName"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.OptionsColumn.ReadOnly = True
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 1
    Me.GridColumn10.Width = 123
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Descripcion"
    Me.GridColumn3.FieldName = "Description"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 4
    Me.GridColumn3.Width = 117
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "# Orden de Trabajo"
    Me.GridColumn1.FieldName = "WorkOrderNo"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 3
    Me.GridColumn1.Width = 122
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tipo de OT"
    Me.GridColumn2.FieldName = "WorkOrderType"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 7
    Me.GridColumn2.Width = 74
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Responsable"
    Me.GridColumn8.FieldName = "EmployeeName"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 8
    Me.GridColumn8.Width = 88
    '
    'Quantity
    '
    Me.Quantity.Caption = "Cantidad"
    Me.Quantity.FieldName = "Quantity"
    Me.Quantity.Name = "Quantity"
    Me.Quantity.OptionsColumn.ReadOnly = True
    Me.Quantity.Visible = True
    Me.Quantity.VisibleIndex = 5
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Proyecto"
    Me.GridColumn4.FieldName = "ProjectName"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.OptionsColumn.ReadOnly = True
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    Me.GridColumn4.Width = 118
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Precio"
    Me.GridColumn13.FieldName = "UnitPrice"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.OptionsColumn.ReadOnly = True
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 6
    Me.GridColumn13.Width = 64
    '
    'GridColumn16
    '
    Me.GridColumn16.Caption = "Fecha Ingresada"
    Me.GridColumn16.FieldName = "PlannedStartDate"
    Me.GridColumn16.Name = "GridColumn16"
    Me.GridColumn16.OptionsColumn.ReadOnly = True
    Me.GridColumn16.Visible = True
    Me.GridColumn16.VisibleIndex = 9
    Me.GridColumn16.Width = 100
    '
    'GridColumn17
    '
    Me.GridColumn17.Caption = "Fecha de Compromiso"
    Me.GridColumn17.FieldName = "DueTime"
    Me.GridColumn17.Name = "GridColumn17"
    Me.GridColumn17.OptionsColumn.ReadOnly = True
    Me.GridColumn17.Visible = True
    Me.GridColumn17.VisibleIndex = 10
    Me.GridColumn17.Width = 135
    '
    'GridColumn18
    '
    Me.GridColumn18.Caption = "Fecha Despachada"
    Me.GridColumn18.FieldName = "FinishDate"
    Me.GridColumn18.Name = "GridColumn18"
    Me.GridColumn18.OptionsColumn.ReadOnly = True
    Me.GridColumn18.Visible = True
    Me.GridColumn18.VisibleIndex = 11
    Me.GridColumn18.Width = 111
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1205, 514)
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
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Quantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
End Class
