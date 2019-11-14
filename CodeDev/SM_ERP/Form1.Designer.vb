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
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOrderStatusEnum = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcShippingCost = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn1, Me.GridColumn8, Me.GridColumn3, Me.gcOrderStatusEnum, Me.GridColumn6, Me.GridColumn7, Me.GridColumn11, Me.GridColumn9, Me.GridColumn10, Me.GridColumn2, Me.GridColumn12, Me.gcShippingCost})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "Empleado"
    Me.GridColumn12.FieldName = "FirstName"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.OptionsColumn.ReadOnly = True
    Me.GridColumn12.Visible = True
    Me.GridColumn12.VisibleIndex = 11
    Me.GridColumn12.Width = 131
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Tipo de Venta"
    Me.GridColumn6.FieldName = "OrderTypeID"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.ReadOnly = True
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    Me.GridColumn6.Width = 78
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Referencia de Cuenta"
    Me.GridColumn10.FieldName = "AccountRef"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.OptionsColumn.ReadOnly = True
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 4
    Me.GridColumn10.Width = 115
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Nombre de Proyecto"
    Me.GridColumn3.FieldName = "ProjectName"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 1
    Me.GridColumn3.Width = 125
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "# Referencia"
    Me.GridColumn1.FieldName = "OrderNo"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 79
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Código Empleado"
    Me.GridColumn2.FieldName = "ContractManagerID"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 10
    Me.GridColumn2.Width = 91
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "ID"
    Me.GridColumn5.FieldName = "SalesOrderID"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.OptionsColumn.ReadOnly = True
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Nombre de Cliente"
    Me.GridColumn8.FieldName = "CompanyName"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 2
    Me.GridColumn8.Width = 113
    '
    'gcOrderStatusEnum
    '
    Me.gcOrderStatusEnum.Caption = "Estado de Orden"
    Me.gcOrderStatusEnum.FieldName = "OrderStatusENUM"
    Me.gcOrderStatusEnum.Name = "gcOrderStatusEnum"
    Me.gcOrderStatusEnum.OptionsColumn.ReadOnly = True
    Me.gcOrderStatusEnum.Visible = True
    Me.gcOrderStatusEnum.VisibleIndex = 8
    Me.gcOrderStatusEnum.Width = 97
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Fecha de Ingreso"
    Me.GridColumn7.FieldName = "DateEntered"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.OptionsColumn.ReadOnly = True
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 6
    Me.GridColumn7.Width = 92
    '
    'GridColumn11
    '
    Me.GridColumn11.Caption = "Fecha Requerida"
    Me.GridColumn11.FieldName = "FinishDate"
    Me.GridColumn11.Name = "GridColumn11"
    Me.GridColumn11.OptionsColumn.ReadOnly = True
    Me.GridColumn11.Visible = True
    Me.GridColumn11.VisibleIndex = 7
    Me.GridColumn11.Width = 98
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "País"
    Me.GridColumn9.FieldName = "SalesAreaID"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.OptionsColumn.ReadOnly = True
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 3
    Me.GridColumn9.Width = 64
    '
    'gcShippingCost
    '
    Me.gcShippingCost.Caption = "Costo de Envío"
    Me.gcShippingCost.FieldName = "ShippingCost"
    Me.gcShippingCost.Name = "gcShippingCost"
    Me.gcShippingCost.Visible = True
    Me.gcShippingCost.VisibleIndex = 9
    Me.gcShippingCost.Width = 78
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
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOrderStatusEnum As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcShippingCost As DevExpress.XtraGrid.Columns.GridColumn
End Class
