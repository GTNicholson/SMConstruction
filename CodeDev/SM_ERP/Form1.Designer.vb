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
    Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
    Me.fieldStockCategoryDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockItemTypeDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockCode = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStdCost = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransferValue = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockItemTransactionLogID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransType = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransDate = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransDateMC = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcTotalValue = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcRequisaNo = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcWorkOrderNo = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcAreaDescription = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcRefNo2 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcRefInfo2 = New DevExpress.XtraPivotGrid.PivotGridField()
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn1, Me.GridColumn8, Me.gcRequiredDate})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "ID"
    Me.GridColumn5.FieldName = "PurchaseOrderID"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.OptionsColumn.ReadOnly = True
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "# O.C."
    Me.GridColumn1.FieldName = "PONum"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 79
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Proveedor"
    Me.GridColumn8.FieldName = "SupplierID"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.OptionsColumn.ReadOnly = True
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 1
    Me.GridColumn8.Width = 113
    '
    'gcRequiredDate
    '
    Me.gcRequiredDate.Caption = "Fecha Requerida"
    Me.gcRequiredDate.FieldName = "RequiredDate"
    Me.gcRequiredDate.Name = "gcRequiredDate"
    Me.gcRequiredDate.Visible = True
    Me.gcRequiredDate.VisibleIndex = 2
    '
    'PivotGridControl1
    '
    Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldStockCategoryDesc, Me.fieldStockItemTypeDesc, Me.fieldStockCode, Me.fieldStockDesc, Me.fieldStdCost, Me.fieldTransferValue, Me.fieldStockItemTransactionLogID, Me.fieldTransQuantity, Me.fieldTransType, Me.fieldTransDate, Me.fieldTransDateMC, Me.gcTotalValue, Me.gcRequisaNo, Me.gcWorkOrderNo, Me.gcAreaDescription, Me.gcRefNo2, Me.gcRefInfo2})
    PivotGridGroup1.Fields.Add(Me.fieldStockCategoryDesc)
    PivotGridGroup1.Hierarchy = Nothing
    PivotGridGroup1.ShowNewValues = True
    Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
    Me.PivotGridControl1.Location = New System.Drawing.Point(50, 187)
    Me.PivotGridControl1.Name = "PivotGridControl1"
    Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
    Me.PivotGridControl1.OptionsData.CaseSensitive = False
    Me.PivotGridControl1.OptionsDataField.ColumnValueLineCount = 2
    Me.PivotGridControl1.OptionsDataField.RowValueLineCount = 2
    Me.PivotGridControl1.Size = New System.Drawing.Size(1002, 200)
    Me.PivotGridControl1.TabIndex = 1
    '
    'fieldStockCategoryDesc
    '
    Me.fieldStockCategoryDesc.AreaIndex = 4
    Me.fieldStockCategoryDesc.Caption = "Categoría"
    Me.fieldStockCategoryDesc.FieldName = "StockCategoryDesc"
    Me.fieldStockCategoryDesc.Name = "fieldStockCategoryDesc"
    Me.fieldStockCategoryDesc.Options.AllowRunTimeSummaryChange = True
    Me.fieldStockCategoryDesc.Width = 155
    '
    'fieldStockItemTypeDesc
    '
    Me.fieldStockItemTypeDesc.AreaIndex = 3
    Me.fieldStockItemTypeDesc.Caption = "Tipo de Producto"
    Me.fieldStockItemTypeDesc.FieldName = "StockItemTypeDesc"
    Me.fieldStockItemTypeDesc.Name = "fieldStockItemTypeDesc"
    Me.fieldStockItemTypeDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStockCode
    '
    Me.fieldStockCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldStockCode.AreaIndex = 2
    Me.fieldStockCode.Caption = "Código de Producto"
    Me.fieldStockCode.FieldName = "StockCode"
    Me.fieldStockCode.Name = "fieldStockCode"
    Me.fieldStockCode.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStockDesc
    '
    Me.fieldStockDesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldStockDesc.AreaIndex = 3
    Me.fieldStockDesc.Caption = "Descripción del Producto"
    Me.fieldStockDesc.FieldName = "StockDesc"
    Me.fieldStockDesc.Name = "fieldStockDesc"
    Me.fieldStockDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStdCost
    '
    Me.fieldStdCost.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.fieldStdCost.AreaIndex = 1
    Me.fieldStdCost.Caption = "Costo Std."
    Me.fieldStdCost.ColumnValueLineCount = 2
    Me.fieldStdCost.FieldName = "StdCost"
    Me.fieldStdCost.Name = "fieldStdCost"
    Me.fieldStdCost.Options.AllowRunTimeSummaryChange = True
    Me.fieldStdCost.RowValueLineCount = 2
    '
    'fieldTransferValue
    '
    Me.fieldTransferValue.AreaIndex = 1
    Me.fieldTransferValue.Caption = "Valor de Transferencia"
    Me.fieldTransferValue.CellFormat.FormatString = "#,##0.00"
    Me.fieldTransferValue.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.fieldTransferValue.ColumnValueLineCount = 2
    Me.fieldTransferValue.FieldName = "TransferValue"
    Me.fieldTransferValue.Name = "fieldTransferValue"
    Me.fieldTransferValue.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransferValue.RowValueLineCount = 2
    Me.fieldTransferValue.Width = 87
    '
    'fieldStockItemTransactionLogID
    '
    Me.fieldStockItemTransactionLogID.AreaIndex = 2
    Me.fieldStockItemTransactionLogID.Caption = "Conteo de Transf."
    Me.fieldStockItemTransactionLogID.CellFormat.FormatString = "#,##0"
    Me.fieldStockItemTransactionLogID.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.fieldStockItemTransactionLogID.ColumnValueLineCount = 2
    Me.fieldStockItemTransactionLogID.FieldName = "StockItemTransactionLogID"
    Me.fieldStockItemTransactionLogID.Name = "fieldStockItemTransactionLogID"
    Me.fieldStockItemTransactionLogID.Options.AllowRunTimeSummaryChange = True
    Me.fieldStockItemTransactionLogID.RowValueLineCount = 2
    Me.fieldStockItemTransactionLogID.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
    Me.fieldStockItemTransactionLogID.Width = 59
    '
    'fieldTransQuantity
    '
    Me.fieldTransQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.fieldTransQuantity.AreaIndex = 0
    Me.fieldTransQuantity.Caption = "Cantidad de Transf"
    Me.fieldTransQuantity.CellFormat.FormatString = "#,##0.#"
    Me.fieldTransQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.fieldTransQuantity.ColumnValueLineCount = 2
    Me.fieldTransQuantity.FieldName = "TransQuantity"
    Me.fieldTransQuantity.Name = "fieldTransQuantity"
    Me.fieldTransQuantity.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransQuantity.RowValueLineCount = 2
    Me.fieldTransQuantity.Width = 79
    '
    'fieldTransType
    '
    Me.fieldTransType.AreaIndex = 0
    Me.fieldTransType.Caption = "Tipo de Transf."
    Me.fieldTransType.FieldName = "TransType"
    Me.fieldTransType.Name = "fieldTransType"
    Me.fieldTransType.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTransDate
    '
    Me.fieldTransDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldTransDate.AreaIndex = 0
    Me.fieldTransDate.Caption = "Fecha Detalle"
    Me.fieldTransDate.FieldName = "TransDate"
    Me.fieldTransDate.Name = "fieldTransDate"
    Me.fieldTransDate.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransDate.ValueFormat.FormatString = "dd-MM-yy"
    Me.fieldTransDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
    '
    'fieldTransDateMC
    '
    Me.fieldTransDateMC.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
    Me.fieldTransDateMC.AreaIndex = 0
    Me.fieldTransDateMC.Caption = "Fecha Corta"
    Me.fieldTransDateMC.FieldName = "TransDateMC"
    Me.fieldTransDateMC.Name = "fieldTransDateMC"
    Me.fieldTransDateMC.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransDateMC.ValueFormat.FormatString = "MMM-yy"
    Me.fieldTransDateMC.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
    '
    'gcTotalValue
    '
    Me.gcTotalValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.gcTotalValue.AreaIndex = 2
    Me.gcTotalValue.Caption = "Valor Total"
    Me.gcTotalValue.ColumnValueLineCount = 2
    Me.gcTotalValue.FieldName = "TotalValue"
    Me.gcTotalValue.Name = "gcTotalValue"
    Me.gcTotalValue.RowValueLineCount = 2
    '
    'gcRequisaNo
    '
    Me.gcRequisaNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.gcRequisaNo.AreaIndex = 1
    Me.gcRequisaNo.Caption = "Doc. Refer."
    Me.gcRequisaNo.FieldName = "ReferenceNo"
    Me.gcRequisaNo.Name = "gcRequisaNo"
    '
    'gcWorkOrderNo
    '
    Me.gcWorkOrderNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.gcWorkOrderNo.AreaIndex = 4
    Me.gcWorkOrderNo.Caption = "OT Num"
    Me.gcWorkOrderNo.FieldName = "WorkOrderNo"
    Me.gcWorkOrderNo.Name = "gcWorkOrderNo"
    '
    'gcAreaDescription
    '
    Me.gcAreaDescription.AreaIndex = 7
    Me.gcAreaDescription.Caption = "Área"
    Me.gcAreaDescription.FieldName = "AreaDescription"
    Me.gcAreaDescription.Name = "gcAreaDescription"
    '
    'gcRefNo2
    '
    Me.gcRefNo2.AreaIndex = 5
    Me.gcRefNo2.Caption = "RefInfo2"
    Me.gcRefNo2.FieldName = "RefInfo2"
    Me.gcRefNo2.Name = "gcRefNo2"
    '
    'gcRefInfo2
    '
    Me.gcRefInfo2.AreaIndex = 6
    Me.gcRefInfo2.Caption = "RefInfo3"
    Me.gcRefInfo2.FieldName = "RefInfo2"
    Me.gcRefInfo2.Name = "gcRefInfo2"
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
  Friend WithEvents fieldStockCategoryDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockItemTypeDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockCode As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStdCost As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransferValue As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockItemTransactionLogID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransQuantity As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransType As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransDate As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransDateMC As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcTotalValue As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcRequisaNo As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcWorkOrderNo As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcAreaDescription As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcRefNo2 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcRefInfo2 As DevExpress.XtraPivotGrid.PivotGridField
End Class
