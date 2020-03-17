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
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
    Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(12, 21)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(1181, 130)
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsLayout.Columns.StoreAllOptions = True
    Me.GridView1.OptionsLayout.StoreAllOptions = True
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "InvoiceID"
    Me.GridColumn3.FieldName = "InvoiceID"
    Me.GridColumn3.Name = "GridColumn3"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "SalesOrderID"
    Me.GridColumn1.FieldName = "SalesOrderID"
    Me.GridColumn1.Name = "GridColumn1"
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Fecha de Facturación"
    Me.GridColumn2.FieldName = "InvoiceDate"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 3
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Fecha de Creación"
    Me.GridColumn4.FieldName = "CreatedDate"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Valor Neto"
    Me.GridColumn5.DisplayFormat.FormatString = "$#,##0.00;;#"
    Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn5.FieldName = "NetValue"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 1
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Estado"
    Me.GridColumn6.FieldName = "InvoiceStatus"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 4
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "CustomerPurchaseOrder"
    Me.GridColumn7.FieldName = "CustomerPurchaseOrder"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 5
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Núm. Factura"
    Me.GridColumn8.FieldName = "InvoiceNo"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 0
    '
    'PivotGridControl1
    '
    Me.PivotGridControl1.Appearance.Cell.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.PivotGridControl1.Appearance.Cell.Options.UseFont = True
    Me.PivotGridControl1.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = True
    Me.PivotGridControl1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.CustomTotalCell.Options.UseFont = True
    Me.PivotGridControl1.Appearance.DataHeaderArea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = True
    Me.PivotGridControl1.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.FieldHeader.Options.UseFont = True
    Me.PivotGridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.FieldValue.Options.UseFont = True
    Me.PivotGridControl1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.FieldValueGrandTotal.Options.UseFont = True
    Me.PivotGridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.FieldValueTotal.Options.UseFont = True
    Me.PivotGridControl1.Appearance.FilterHeaderArea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.FilterHeaderArea.Options.UseFont = True
    Me.PivotGridControl1.Appearance.FilterSeparator.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.FilterSeparator.Options.UseFont = True
    Me.PivotGridControl1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.GrandTotalCell.Options.UseFont = True
    Me.PivotGridControl1.Appearance.HeaderArea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.HeaderArea.Options.UseFont = True
    Me.PivotGridControl1.Appearance.HeaderFilterButton.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.PivotGridControl1.Appearance.HeaderFilterButton.Options.UseFont = True
    Me.PivotGridControl1.Appearance.HeaderFilterButtonActive.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.PivotGridControl1.Appearance.HeaderFilterButtonActive.Options.UseFont = True
    Me.PivotGridControl1.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseFont = True
    Me.PivotGridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.RowHeaderArea.Options.UseFont = True
    Me.PivotGridControl1.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.PivotGridControl1.Appearance.TotalCell.Options.UseFont = True
    Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField9, Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17})
    Me.PivotGridControl1.Location = New System.Drawing.Point(50, 187)
    Me.PivotGridControl1.Name = "PivotGridControl1"
    Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
    Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
    Me.PivotGridControl1.Size = New System.Drawing.Size(1002, 200)
    Me.PivotGridControl1.TabIndex = 1
    '
    'PivotGridField9
    '
    Me.PivotGridField9.AreaIndex = 0
    Me.PivotGridField9.Caption = "MaterialRequirementID"
    Me.PivotGridField9.FieldName = "MaterialRequirementID"
    Me.PivotGridField9.Name = "PivotGridField9"
    Me.PivotGridField9.Visible = False
    '
    'PivotGridField1
    '
    Me.PivotGridField1.AreaIndex = 0
    Me.PivotGridField1.FieldName = "Description"
    Me.PivotGridField1.Name = "PivotGridField1"
    '
    'PivotGridField2
    '
    Me.PivotGridField2.AreaIndex = 1
    Me.PivotGridField2.Caption = "UnitPiece"
    Me.PivotGridField2.FieldName = "UnitPiece"
    Me.PivotGridField2.Name = "PivotGridField2"
    '
    'PivotGridField3
    '
    Me.PivotGridField3.AreaIndex = 12
    Me.PivotGridField3.FieldName = "PiecesPerComponent"
    Me.PivotGridField3.Name = "PivotGridField3"
    '
    'PivotGridField4
    '
    Me.PivotGridField4.AreaIndex = 2
    Me.PivotGridField4.FieldName = "NetLenght"
    Me.PivotGridField4.Name = "PivotGridField4"
    '
    'PivotGridField5
    '
    Me.PivotGridField5.AreaIndex = 3
    Me.PivotGridField5.FieldName = "NetWidth"
    Me.PivotGridField5.Name = "PivotGridField5"
    '
    'PivotGridField6
    '
    Me.PivotGridField6.AreaIndex = 4
    Me.PivotGridField6.FieldName = "NetThickness"
    Me.PivotGridField6.Name = "PivotGridField6"
    '
    'PivotGridField7
    '
    Me.PivotGridField7.AreaIndex = 6
    Me.PivotGridField7.FieldName = "QualityType"
    Me.PivotGridField7.Name = "PivotGridField7"
    '
    'PivotGridField8
    '
    Me.PivotGridField8.AreaIndex = 5
    Me.PivotGridField8.FieldName = "WoodSpecie"
    Me.PivotGridField8.Name = "PivotGridField8"
    '
    'PivotGridField10
    '
    Me.PivotGridField10.AreaIndex = 13
    Me.PivotGridField10.FieldName = "ProductFurnitureID"
    Me.PivotGridField10.Name = "PivotGridField10"
    '
    'PivotGridField11
    '
    Me.PivotGridField11.AreaIndex = 7
    Me.PivotGridField11.FieldName = "WODescription"
    Me.PivotGridField11.Name = "PivotGridField11"
    '
    'PivotGridField12
    '
    Me.PivotGridField12.AreaIndex = 9
    Me.PivotGridField12.FieldName = "PlannedStartDate"
    Me.PivotGridField12.Name = "PivotGridField12"
    '
    'PivotGridField13
    '
    Me.PivotGridField13.AreaIndex = 8
    Me.PivotGridField13.FieldName = "WorkOrderNo"
    Me.PivotGridField13.Name = "PivotGridField13"
    '
    'PivotGridField14
    '
    Me.PivotGridField14.AreaIndex = 11
    Me.PivotGridField14.FieldName = "Quantity"
    Me.PivotGridField14.Name = "PivotGridField14"
    '
    'PivotGridField15
    '
    Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.PivotGridField15.AreaIndex = 0
    Me.PivotGridField15.FieldName = "ProjectName"
    Me.PivotGridField15.Name = "PivotGridField15"
    '
    'PivotGridField16
    '
    Me.PivotGridField16.AreaIndex = 10
    Me.PivotGridField16.FieldName = "CompanyName"
    Me.PivotGridField16.Name = "PivotGridField16"
    '
    'PivotGridField17
    '
    Me.PivotGridField17.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField17.AreaIndex = 0
    Me.PivotGridField17.FieldName = "TotalBoardFeetReport"
    Me.PivotGridField17.Name = "PivotGridField17"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1205, 514)
    Me.Controls.Add(Me.PivotGridControl1)
    Me.Controls.Add(Me.GridControl1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
  Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
