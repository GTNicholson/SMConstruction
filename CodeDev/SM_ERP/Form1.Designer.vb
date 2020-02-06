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
    Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
    Me.fieldCurrentStockItem = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockCategoryDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockItemTypeDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockCode = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStdCost = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransferValue = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStockItemTransactionLogID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldPrevValue = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldNewValue = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldPONum = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldSupplierName = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldGRNumber = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldSalesOrderNo = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldSalesOrderPhaseNo = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldProductionBatchNo = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldCustomerName = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransType = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransTime = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransDate = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransDateWC = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTransDateMC = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldIsManagedStock = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldRefObjectType = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldRefObjectID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldRefInfo1 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldRefInfo2 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldRefInfo3 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
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
    'PivotGridControl1
    '
    Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCurrentStockItem, Me.fieldStockCategoryDesc, Me.fieldStockItemTypeDesc, Me.fieldStockCode, Me.fieldStockDesc, Me.fieldStdCost, Me.fieldTransferValue, Me.fieldStockItemTransactionLogID, Me.fieldTransQuantity, Me.fieldPrevValue, Me.fieldNewValue, Me.fieldPONum, Me.fieldSupplierName, Me.fieldGRNumber, Me.fieldSalesOrderNo, Me.fieldSalesOrderPhaseNo, Me.fieldProductionBatchNo, Me.fieldCustomerName, Me.fieldTransType, Me.fieldTransTime, Me.fieldTransDate, Me.fieldTransDateWC, Me.fieldTransDateMC, Me.fieldIsManagedStock, Me.fieldRefObjectType, Me.fieldRefObjectID, Me.fieldRefInfo1, Me.fieldRefInfo2, Me.fieldRefInfo3, Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3})
    Me.PivotGridControl1.Location = New System.Drawing.Point(50, 187)
    Me.PivotGridControl1.Name = "PivotGridControl1"
    Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
    Me.PivotGridControl1.OptionsData.CaseSensitive = False
    Me.PivotGridControl1.OptionsDataField.ColumnValueLineCount = 2
    Me.PivotGridControl1.OptionsDataField.RowValueLineCount = 2
    Me.PivotGridControl1.Size = New System.Drawing.Size(1002, 200)
    Me.PivotGridControl1.TabIndex = 1
    '
    'fieldCurrentStockItem
    '
    Me.fieldCurrentStockItem.AreaIndex = 0
    Me.fieldCurrentStockItem.FieldName = "CurrentStockItem"
    Me.fieldCurrentStockItem.Name = "fieldCurrentStockItem"
    Me.fieldCurrentStockItem.Options.AllowRunTimeSummaryChange = True
    Me.fieldCurrentStockItem.Visible = False
    '
    'fieldStockCategoryDesc
    '
    Me.fieldStockCategoryDesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldStockCategoryDesc.AreaIndex = 0
    Me.fieldStockCategoryDesc.Caption = "Descripción de Producto"
    Me.fieldStockCategoryDesc.FieldName = "StockCategoryDesc"
    Me.fieldStockCategoryDesc.Name = "fieldStockCategoryDesc"
    Me.fieldStockCategoryDesc.Options.AllowRunTimeSummaryChange = True
    Me.fieldStockCategoryDesc.Width = 155
    '
    'fieldStockItemTypeDesc
    '
    Me.fieldStockItemTypeDesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldStockItemTypeDesc.AreaIndex = 1
    Me.fieldStockItemTypeDesc.Caption = "Tipo de Producto"
    Me.fieldStockItemTypeDesc.FieldName = "StockItemTypeDesc"
    Me.fieldStockItemTypeDesc.Name = "fieldStockItemTypeDesc"
    Me.fieldStockItemTypeDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStockCode
    '
    Me.fieldStockCode.AreaIndex = 2
    Me.fieldStockCode.Caption = "Código de Producto"
    Me.fieldStockCode.FieldName = "StockCode"
    Me.fieldStockCode.Name = "fieldStockCode"
    Me.fieldStockCode.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStockDesc
    '
    Me.fieldStockDesc.AreaIndex = 4
    Me.fieldStockDesc.Caption = "Descripción del Producto"
    Me.fieldStockDesc.FieldName = "StockDesc"
    Me.fieldStockDesc.Name = "fieldStockDesc"
    Me.fieldStockDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStdCost
    '
    Me.fieldStdCost.AreaIndex = 5
    Me.fieldStdCost.Caption = "Costo Std."
    Me.fieldStdCost.FieldName = "StdCost"
    Me.fieldStdCost.Name = "fieldStdCost"
    Me.fieldStdCost.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTransferValue
    '
    Me.fieldTransferValue.AreaIndex = 19
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
    Me.fieldStockItemTransactionLogID.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.fieldStockItemTransactionLogID.AreaIndex = 0
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
    Me.fieldTransQuantity.AreaIndex = 17
    Me.fieldTransQuantity.Caption = "Cantidad de Transf"
    Me.fieldTransQuantity.CellFormat.FormatString = "#,##0.#"
    Me.fieldTransQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.fieldTransQuantity.FieldName = "TransQuantity"
    Me.fieldTransQuantity.Name = "fieldTransQuantity"
    Me.fieldTransQuantity.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransQuantity.Width = 79
    '
    'fieldPrevValue
    '
    Me.fieldPrevValue.AreaIndex = 6
    Me.fieldPrevValue.Caption = "Valor Previo"
    Me.fieldPrevValue.FieldName = "PrevValue"
    Me.fieldPrevValue.Name = "fieldPrevValue"
    Me.fieldPrevValue.Options.AllowRunTimeSummaryChange = True
    '
    'fieldNewValue
    '
    Me.fieldNewValue.AreaIndex = 7
    Me.fieldNewValue.Caption = "Nuevo Valor"
    Me.fieldNewValue.FieldName = "NewValue"
    Me.fieldNewValue.Name = "fieldNewValue"
    Me.fieldNewValue.Options.AllowRunTimeSummaryChange = True
    '
    'fieldPONum
    '
    Me.fieldPONum.AreaIndex = 8
    Me.fieldPONum.Caption = "# Venta"
    Me.fieldPONum.FieldName = "PONum"
    Me.fieldPONum.Name = "fieldPONum"
    Me.fieldPONum.Options.AllowRunTimeSummaryChange = True
    '
    'fieldSupplierName
    '
    Me.fieldSupplierName.AreaIndex = 7
    Me.fieldSupplierName.FieldName = "SupplierName"
    Me.fieldSupplierName.Name = "fieldSupplierName"
    Me.fieldSupplierName.Options.AllowRunTimeSummaryChange = True
    Me.fieldSupplierName.Visible = False
    '
    'fieldGRNumber
    '
    Me.fieldGRNumber.AreaIndex = 7
    Me.fieldGRNumber.FieldName = "GRNumber"
    Me.fieldGRNumber.Name = "fieldGRNumber"
    Me.fieldGRNumber.Options.AllowRunTimeSummaryChange = True
    Me.fieldGRNumber.Visible = False
    '
    'fieldSalesOrderNo
    '
    Me.fieldSalesOrderNo.AreaIndex = 7
    Me.fieldSalesOrderNo.FieldName = "SalesOrderNo"
    Me.fieldSalesOrderNo.Name = "fieldSalesOrderNo"
    Me.fieldSalesOrderNo.Options.AllowRunTimeSummaryChange = True
    Me.fieldSalesOrderNo.Visible = False
    '
    'fieldSalesOrderPhaseNo
    '
    Me.fieldSalesOrderPhaseNo.AreaIndex = 7
    Me.fieldSalesOrderPhaseNo.FieldName = "SalesOrderPhaseNo"
    Me.fieldSalesOrderPhaseNo.Name = "fieldSalesOrderPhaseNo"
    Me.fieldSalesOrderPhaseNo.Options.AllowRunTimeSummaryChange = True
    Me.fieldSalesOrderPhaseNo.Visible = False
    '
    'fieldProductionBatchNo
    '
    Me.fieldProductionBatchNo.AreaIndex = 9
    Me.fieldProductionBatchNo.FieldName = "ProductionBatchNo"
    Me.fieldProductionBatchNo.Name = "fieldProductionBatchNo"
    Me.fieldProductionBatchNo.Options.AllowRunTimeSummaryChange = True
    '
    'fieldCustomerName
    '
    Me.fieldCustomerName.AreaIndex = 10
    Me.fieldCustomerName.Caption = "Cliente"
    Me.fieldCustomerName.FieldName = "CustomerName"
    Me.fieldCustomerName.Name = "fieldCustomerName"
    Me.fieldCustomerName.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTransType
    '
    Me.fieldTransType.AreaIndex = 11
    Me.fieldTransType.FieldName = "TransType"
    Me.fieldTransType.Name = "fieldTransType"
    Me.fieldTransType.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTransTime
    '
    Me.fieldTransTime.AreaIndex = 14
    Me.fieldTransTime.FieldName = "TransTime"
    Me.fieldTransTime.Name = "fieldTransTime"
    Me.fieldTransTime.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransTime.Visible = False
    '
    'fieldTransDate
    '
    Me.fieldTransDate.AreaIndex = 12
    Me.fieldTransDate.FieldName = "TransDate"
    Me.fieldTransDate.Name = "fieldTransDate"
    Me.fieldTransDate.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransDate.ValueFormat.FormatString = "d"
    Me.fieldTransDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    '
    'fieldTransDateWC
    '
    Me.fieldTransDateWC.AreaIndex = 13
    Me.fieldTransDateWC.FieldName = "TransDateWC"
    Me.fieldTransDateWC.Name = "fieldTransDateWC"
    Me.fieldTransDateWC.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransDateWC.ValueFormat.FormatString = "dd-MM-yy"
    Me.fieldTransDateWC.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
    '
    'fieldTransDateMC
    '
    Me.fieldTransDateMC.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
    Me.fieldTransDateMC.AreaIndex = 0
    Me.fieldTransDateMC.FieldName = "TransDateMC"
    Me.fieldTransDateMC.Name = "fieldTransDateMC"
    Me.fieldTransDateMC.Options.AllowRunTimeSummaryChange = True
    Me.fieldTransDateMC.ValueFormat.FormatString = "MMM-yy"
    Me.fieldTransDateMC.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
    '
    'fieldIsManagedStock
    '
    Me.fieldIsManagedStock.AreaIndex = 14
    Me.fieldIsManagedStock.FieldName = "IsManagedStock"
    Me.fieldIsManagedStock.Name = "fieldIsManagedStock"
    Me.fieldIsManagedStock.Options.AllowRunTimeSummaryChange = True
    '
    'fieldRefObjectType
    '
    Me.fieldRefObjectType.AreaIndex = 15
    Me.fieldRefObjectType.FieldName = "RefObjectType"
    Me.fieldRefObjectType.Name = "fieldRefObjectType"
    Me.fieldRefObjectType.Options.AllowRunTimeSummaryChange = True
    '
    'fieldRefObjectID
    '
    Me.fieldRefObjectID.AreaIndex = 16
    Me.fieldRefObjectID.FieldName = "RefObjectID"
    Me.fieldRefObjectID.Name = "fieldRefObjectID"
    Me.fieldRefObjectID.Options.AllowRunTimeSummaryChange = True
    '
    'fieldRefInfo1
    '
    Me.fieldRefInfo1.AreaIndex = 18
    Me.fieldRefInfo1.FieldName = "RefInfo1"
    Me.fieldRefInfo1.Name = "fieldRefInfo1"
    Me.fieldRefInfo1.Options.AllowRunTimeSummaryChange = True
    '
    'fieldRefInfo2
    '
    Me.fieldRefInfo2.AreaIndex = 20
    Me.fieldRefInfo2.FieldName = "RefInfo2"
    Me.fieldRefInfo2.Name = "fieldRefInfo2"
    Me.fieldRefInfo2.Options.AllowRunTimeSummaryChange = True
    '
    'fieldRefInfo3
    '
    Me.fieldRefInfo3.AreaIndex = 21
    Me.fieldRefInfo3.FieldName = "RefInfo3"
    Me.fieldRefInfo3.Name = "fieldRefInfo3"
    Me.fieldRefInfo3.Options.AllowRunTimeSummaryChange = True
    '
    'PivotGridField1
    '
    Me.PivotGridField1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
    Me.PivotGridField1.AreaIndex = 1
    Me.PivotGridField1.Caption = "Qty Change"
    Me.PivotGridField1.CellFormat.FormatString = "#,##0.#"
    Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField1.ColumnValueLineCount = 2
    Me.PivotGridField1.FieldName = "StockQtyChange"
    Me.PivotGridField1.Name = "PivotGridField1"
    Me.PivotGridField1.Options.ReadOnly = True
    Me.PivotGridField1.RowValueLineCount = 2
    Me.PivotGridField1.Width = 62
    '
    'PivotGridField2
    '
    Me.PivotGridField2.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea
    Me.PivotGridField2.AreaIndex = 3
    Me.PivotGridField2.Caption = "Value Change"
    Me.PivotGridField2.ColumnValueLineCount = 2
    Me.PivotGridField2.FieldName = "ValueChange"
    Me.PivotGridField2.Name = "PivotGridField2"
    Me.PivotGridField2.Options.ReadOnly = True
    Me.PivotGridField2.RowValueLineCount = 2
    Me.PivotGridField2.Width = 70
    '
    'PivotGridField3
    '
    Me.PivotGridField3.AreaIndex = 0
    Me.PivotGridField3.Caption = "Barcode"
    Me.PivotGridField3.FieldName = "Barcode"
    Me.PivotGridField3.Name = "PivotGridField3"
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
  Friend WithEvents fieldCustomerName As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldCurrentStockItem As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockCategoryDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockItemTypeDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockCode As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStdCost As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransferValue As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStockItemTransactionLogID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransQuantity As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldPrevValue As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldNewValue As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldPONum As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldSupplierName As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldGRNumber As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldSalesOrderNo As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldSalesOrderPhaseNo As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldProductionBatchNo As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransType As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransTime As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransDate As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransDateWC As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTransDateMC As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldIsManagedStock As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldRefObjectType As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldRefObjectID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldRefInfo1 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldRefInfo2 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldRefInfo3 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
