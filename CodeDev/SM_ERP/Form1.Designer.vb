<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSupplierStatusID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcParentSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAccountCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcTelNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSalesAreaID = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcSupplierID, Me.gcCompanyName, Me.gcSupplierStatusID, Me.gcParentSupplierID, Me.gcAccountCode, Me.gcTelNo, Me.gcSalesAreaID})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'gcSupplierID
    '
    Me.gcSupplierID.Caption = "SupplierID"
    Me.gcSupplierID.FieldName = "SupplierID"
    Me.gcSupplierID.Name = "gcSupplierID"
    Me.gcSupplierID.OptionsColumn.ReadOnly = True
    '
    'gcCompanyName
    '
    Me.gcCompanyName.Caption = "Company Name"
    Me.gcCompanyName.FieldName = "CompanyName"
    Me.gcCompanyName.Name = "gcCompanyName"
    Me.gcCompanyName.Visible = True
    Me.gcCompanyName.VisibleIndex = 0
    Me.gcCompanyName.Width = 123
    '
    'gcSupplierStatusID
    '
    Me.gcSupplierStatusID.Caption = "Status"
    Me.gcSupplierStatusID.FieldName = "SupplierStatusID"
    Me.gcSupplierStatusID.Name = "gcSupplierStatusID"
    Me.gcSupplierStatusID.Visible = True
    Me.gcSupplierStatusID.VisibleIndex = 1
    Me.gcSupplierStatusID.Width = 156
    '
    'gcParentSupplierID
    '
    Me.gcParentSupplierID.Caption = "Parent Supplier"
    Me.gcParentSupplierID.FieldName = "ParentSupplierID"
    Me.gcParentSupplierID.Name = "gcParentSupplierID"
    Me.gcParentSupplierID.Visible = True
    Me.gcParentSupplierID.VisibleIndex = 2
    Me.gcParentSupplierID.Width = 117
    '
    'gcAccountCode
    '
    Me.gcAccountCode.Caption = "Account Code"
    Me.gcAccountCode.FieldName = "AccountCode"
    Me.gcAccountCode.Name = "gcAccountCode"
    Me.gcAccountCode.Visible = True
    Me.gcAccountCode.VisibleIndex = 3
    Me.gcAccountCode.Width = 123
    '
    'gcTelNo
    '
    Me.gcTelNo.Caption = "Te lNo"
    Me.gcTelNo.FieldName = "TelNo"
    Me.gcTelNo.Name = "gcTelNo"
    Me.gcTelNo.Visible = True
    Me.gcTelNo.VisibleIndex = 4
    Me.gcTelNo.Width = 141
    '
    'gcSalesAreaID
    '
    Me.gcSalesAreaID.Caption = "País"
    Me.gcSalesAreaID.FieldName = "SalesAreaID"
    Me.gcSalesAreaID.Name = "gcSalesAreaID"
    Me.gcSalesAreaID.Visible = True
    Me.gcSalesAreaID.VisibleIndex = 5
    Me.gcSalesAreaID.Width = 139
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
  Friend WithEvents gcSupplierID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCompanyName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSupplierStatusID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcParentSupplierID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcAccountCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcTelNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSalesAreaID As DevExpress.XtraGrid.Columns.GridColumn
End Class
