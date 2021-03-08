<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomeManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim StackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grdSalesTracking = New DevExpress.XtraGrid.GridControl()
        Me.gvSalesTracking = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcStockItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.chtWoodInventorySpecieChart = New DevExpress.XtraCharts.ChartControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grdPODeliveryItem = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldTotalReceivedAmountUSD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCategoryDesc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField348 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRefreshData = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.fieldReceivedQty = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSubmissionDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSubmissionDateWC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSubmissionDateMC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalPurchaseOrderItemAmountUSD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pivotTotalPurchaseOrderItemAmountUSD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.grdSalesTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSalesTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.chtWoodInventorySpecieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grdPODeliveryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.7723!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.2277!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.35057!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.64943!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1197, 671)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(718, 410)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(476, 258)
        Me.PanelControl5.TabIndex = 4
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.grdSalesTracking)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(3, 410)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(709, 258)
        Me.PanelControl4.TabIndex = 3
        '
        'grdSalesTracking
        '
        Me.grdSalesTracking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSalesTracking.Location = New System.Drawing.Point(2, 2)
        Me.grdSalesTracking.MainView = Me.gvSalesTracking
        Me.grdSalesTracking.Name = "grdSalesTracking"
        Me.grdSalesTracking.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoDate})
        Me.grdSalesTracking.Size = New System.Drawing.Size(705, 254)
        Me.grdSalesTracking.TabIndex = 1
        Me.grdSalesTracking.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesTracking})
        '
        'gvSalesTracking
        '
        Me.gvSalesTracking.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvSalesTracking.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSalesTracking.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvSalesTracking.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvSalesTracking.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesTracking.Appearance.Row.Options.UseFont = True
        Me.gvSalesTracking.ColumnPanelRowHeight = 34
        Me.gvSalesTracking.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcStockItemID, Me.GridColumn6, Me.gcStdCost, Me.GridColumn7, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn10, Me.GridColumn5, Me.GridColumn8, Me.GridColumn9})
        Me.gvSalesTracking.GridControl = Me.grdSalesTracking
        Me.gvSalesTracking.Name = "gvSalesTracking"
        Me.gvSalesTracking.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvSalesTracking.OptionsBehavior.ReadOnly = True
        Me.gvSalesTracking.OptionsView.ShowAutoFilterRow = True
        Me.gvSalesTracking.OptionsView.ShowDetailButtons = False
        Me.gvSalesTracking.OptionsView.ShowGroupPanel = False
        '
        'gcStockItemID
        '
        Me.gcStockItemID.Caption = "SalesOrderID"
        Me.gcStockItemID.FieldName = "SalesOrderID"
        Me.gcStockItemID.Name = "gcStockItemID"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Cliente"
        Me.GridColumn6.FieldName = "CompanyName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 227
        '
        'gcStdCost
        '
        Me.gcStdCost.Caption = "Proyecto"
        Me.gcStdCost.FieldName = "ProjectName"
        Me.gcStdCost.Name = "gcStdCost"
        Me.gcStdCost.Visible = True
        Me.gcStdCost.VisibleIndex = 1
        Me.gcStdCost.Width = 184
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Pactada Desp."
        Me.GridColumn7.ColumnEdit = Me.repoDate
        Me.GridColumn7.FieldName = "FinishDate"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'repoDate
        '
        Me.repoDate.AutoHeight = False
        Me.repoDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDate.Name = "repoDate"
        Me.repoDate.NullDate = New Date(CType(0, Long))
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Días en Piso"
        Me.GridColumn2.DisplayFormat.FormatString = "0.##;;#"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "TimeSheetEntryDays"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 58
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cant OTs"
        Me.GridColumn3.DisplayFormat.FormatString = "0.##;;#"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "QtyWOs"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 43
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cant. OTs Liberadas por Ing."
        Me.GridColumn4.DisplayFormat.FormatString = "0.##;;#"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "EngineeringCompleteQty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 84
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cant Despachos"
        Me.GridColumn10.DisplayFormat.FormatString = "0.##;;#"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "DespatchCompleteQty"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 67
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cant. Salidas de Material"
        Me.GridColumn5.DisplayFormat.FormatString = "0.##;;#"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "WOsMROtherPicked"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 111
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Valor Neto Facturado"
        Me.GridColumn8.DisplayFormat.FormatString = "$#,##0.00;;#"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "SumInvoiceItem"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumInvoiceItem", "{0:$#,##0.00;;#}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Valor Neto Orden Cliente"
        Me.GridColumn9.DisplayFormat.FormatString = "$#,##0.00;;#"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "SumCustomerOrderNetValue"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumCustomerOrderNetValue", "{0:$#,##0.00;;#}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.chtWoodInventorySpecieChart)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(718, 55)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(476, 349)
        Me.PanelControl3.TabIndex = 2
        '
        'chtWoodInventorySpecieChart
        '
        Me.chtWoodInventorySpecieChart.DataBindings = Nothing
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.chtWoodInventorySpecieChart.Diagram = XyDiagram1
        Me.chtWoodInventorySpecieChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chtWoodInventorySpecieChart.Legend.Name = "Default Legend"
        Me.chtWoodInventorySpecieChart.Location = New System.Drawing.Point(2, 2)
        Me.chtWoodInventorySpecieChart.Name = "chtWoodInventorySpecieChart"
        Me.chtWoodInventorySpecieChart.SeriesDataMember = "StockItemTypeDesc"
        Me.chtWoodInventorySpecieChart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.chtWoodInventorySpecieChart.SeriesTemplate.ArgumentDataMember = "SpeciesDesc"
        Me.chtWoodInventorySpecieChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        StackedBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chtWoodInventorySpecieChart.SeriesTemplate.Label = StackedBarSeriesLabel1
        Me.chtWoodInventorySpecieChart.SeriesTemplate.SummaryFunction = "SUM([Quantity])"
        Me.chtWoodInventorySpecieChart.SeriesTemplate.View = StackedBarSeriesView1
        Me.chtWoodInventorySpecieChart.Size = New System.Drawing.Size(472, 345)
        Me.chtWoodInventorySpecieChart.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.grdPODeliveryItem)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(3, 55)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(709, 349)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(9, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(320, 18)
        Me.LabelControl3.TabIndex = 42
        Me.LabelControl3.Text = "Recepciones de este mes"
        '
        'grdPODeliveryItem
        '
        Me.grdPODeliveryItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPODeliveryItem.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPODeliveryItem.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.grdPODeliveryItem.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPODeliveryItem.Appearance.FieldValueGrandTotal.Options.UseFont = True
        Me.grdPODeliveryItem.Appearance.TotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPODeliveryItem.Appearance.TotalCell.Options.UseFont = True
        Me.grdPODeliveryItem.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldTotalReceivedAmountUSD, Me.fieldCategoryDesc, Me.PivotGridField348})
        Me.grdPODeliveryItem.Location = New System.Drawing.Point(5, 31)
        Me.grdPODeliveryItem.Name = "grdPODeliveryItem"
        Me.grdPODeliveryItem.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.grdPODeliveryItem.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
        Me.grdPODeliveryItem.OptionsDataField.Caption = "Datos del Periodo"
        Me.grdPODeliveryItem.OptionsDataField.RowHeaderWidth = 400
        Me.grdPODeliveryItem.OptionsView.ShowColumnGrandTotalHeader = False
        Me.grdPODeliveryItem.OptionsView.ShowTotalsForSingleValues = True
        Me.grdPODeliveryItem.Size = New System.Drawing.Size(699, 313)
        Me.grdPODeliveryItem.TabIndex = 0
        '
        'fieldTotalReceivedAmountUSD
        '
        Me.fieldTotalReceivedAmountUSD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTotalReceivedAmountUSD.AreaIndex = 0
        Me.fieldTotalReceivedAmountUSD.Caption = "Valor Neto Recibido USD"
        Me.fieldTotalReceivedAmountUSD.CellFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalReceivedAmountUSD.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalReceivedAmountUSD.FieldName = "TotalReceivedAmountUSD"
        Me.fieldTotalReceivedAmountUSD.GrandTotalCellFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalReceivedAmountUSD.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalReceivedAmountUSD.Name = "fieldTotalReceivedAmountUSD"
        Me.fieldTotalReceivedAmountUSD.Options.AllowRunTimeSummaryChange = True
        Me.fieldTotalReceivedAmountUSD.TotalCellFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalReceivedAmountUSD.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalReceivedAmountUSD.TotalValueFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalReceivedAmountUSD.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalReceivedAmountUSD.ValueFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalReceivedAmountUSD.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalReceivedAmountUSD.Width = 158
        '
        'fieldCategoryDesc
        '
        Me.fieldCategoryDesc.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fieldCategoryDesc.Appearance.Header.Options.UseFont = True
        Me.fieldCategoryDesc.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCategoryDesc.AreaIndex = 0
        Me.fieldCategoryDesc.Caption = "Categoría Compra"
        Me.fieldCategoryDesc.FieldName = "CategoryDesc"
        Me.fieldCategoryDesc.Name = "fieldCategoryDesc"
        Me.fieldCategoryDesc.Options.AllowRunTimeSummaryChange = True
        '
        'PivotGridField348
        '
        Me.PivotGridField348.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField348.Appearance.Header.Options.UseFont = True
        Me.PivotGridField348.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField348.AreaIndex = 0
        Me.PivotGridField348.Caption = "Proyecto"
        Me.PivotGridField348.FieldName = "ProjectName"
        Me.PivotGridField348.Name = "PivotGridField348"
        Me.PivotGridField348.Options.AllowRunTimeSummaryChange = True
        Me.PivotGridField348.Width = 194
        '
        'PanelControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PanelControl1, 2)
        Me.PanelControl1.Controls.Add(Me.btnRefreshData)
        Me.PanelControl1.Controls.Add(Me.lblUserName)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1191, 46)
        Me.PanelControl1.TabIndex = 0
        '
        'btnRefreshData
        '
        Me.btnRefreshData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshData.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefreshData.Appearance.Options.UseFont = True
        Me.btnRefreshData.Location = New System.Drawing.Point(1080, 9)
        Me.btnRefreshData.Name = "btnRefreshData"
        Me.btnRefreshData.Size = New System.Drawing.Size(109, 23)
        Me.btnRefreshData.TabIndex = 42
        Me.btnRefreshData.Text = "Refrescar Datos"
        '
        'lblUserName
        '
        Me.lblUserName.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserName.Appearance.Options.UseFont = True
        Me.lblUserName.Appearance.Options.UseForeColor = True
        Me.lblUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUserName.Location = New System.Drawing.Point(429, 16)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(320, 18)
        Me.lblUserName.TabIndex = 41
        Me.lblUserName.Text = "UserName"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl2.Location = New System.Drawing.Point(233, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(190, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Administración General"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.Location = New System.Drawing.Point(9, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(121, 22)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "AgroForestal"
        '
        'fieldReceivedQty
        '
        Me.fieldReceivedQty.AreaIndex = 9
        Me.fieldReceivedQty.Caption = "Cant. Recibida"
        Me.fieldReceivedQty.FieldName = "ReceivedQty"
        Me.fieldReceivedQty.Name = "fieldReceivedQty"
        Me.fieldReceivedQty.Options.AllowRunTimeSummaryChange = True
        '
        'fieldSubmissionDate
        '
        Me.fieldSubmissionDate.AreaIndex = 2
        Me.fieldSubmissionDate.Caption = "Fecha Creación"
        Me.fieldSubmissionDate.FieldName = "SubmissionDate"
        Me.fieldSubmissionDate.Name = "fieldSubmissionDate"
        Me.fieldSubmissionDate.Options.AllowRunTimeSummaryChange = True
        '
        'fieldSubmissionDateWC
        '
        Me.fieldSubmissionDateWC.AreaIndex = 3
        Me.fieldSubmissionDateWC.Caption = "Fecha Creación (Semana)"
        Me.fieldSubmissionDateWC.FieldName = "SubmissionDateWC"
        Me.fieldSubmissionDateWC.Name = "fieldSubmissionDateWC"
        Me.fieldSubmissionDateWC.Options.AllowRunTimeSummaryChange = True
        '
        'fieldSubmissionDateMC
        '
        Me.fieldSubmissionDateMC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSubmissionDateMC.AreaIndex = 0
        Me.fieldSubmissionDateMC.Caption = "Fecha Creación (Mes)"
        Me.fieldSubmissionDateMC.FieldName = "SubmissionDateMC"
        Me.fieldSubmissionDateMC.Name = "fieldSubmissionDateMC"
        Me.fieldSubmissionDateMC.Options.AllowRunTimeSummaryChange = True
        '
        'fieldTotalPurchaseOrderItemAmountUSD
        '
        Me.fieldTotalPurchaseOrderItemAmountUSD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTotalPurchaseOrderItemAmountUSD.AreaIndex = 0
        Me.fieldTotalPurchaseOrderItemAmountUSD.Caption = "Valor Neto Comprado (USD)"
        Me.fieldTotalPurchaseOrderItemAmountUSD.CellFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalPurchaseOrderItemAmountUSD.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalPurchaseOrderItemAmountUSD.FieldName = "TotalPurchaseOrderItemAmountUSD"
        Me.fieldTotalPurchaseOrderItemAmountUSD.GrandTotalCellFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalPurchaseOrderItemAmountUSD.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalPurchaseOrderItemAmountUSD.Name = "fieldTotalPurchaseOrderItemAmountUSD"
        Me.fieldTotalPurchaseOrderItemAmountUSD.Options.AllowRunTimeSummaryChange = True
        Me.fieldTotalPurchaseOrderItemAmountUSD.TotalCellFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalPurchaseOrderItemAmountUSD.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalPurchaseOrderItemAmountUSD.TotalValueFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalPurchaseOrderItemAmountUSD.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalPurchaseOrderItemAmountUSD.ValueFormat.FormatString = "$#,##0.00;;#"
        Me.fieldTotalPurchaseOrderItemAmountUSD.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalPurchaseOrderItemAmountUSD.Width = 222
        '
        'pivotTotalPurchaseOrderItemAmountUSD
        '
        Me.pivotTotalPurchaseOrderItemAmountUSD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pivotTotalPurchaseOrderItemAmountUSD.AreaIndex = 1
        Me.pivotTotalPurchaseOrderItemAmountUSD.Caption = "Valor Neto Comprado USD"
        Me.pivotTotalPurchaseOrderItemAmountUSD.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pivotTotalPurchaseOrderItemAmountUSD.FieldName = "TotalPurchaseOrderItemAmountUSD"
        Me.pivotTotalPurchaseOrderItemAmountUSD.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pivotTotalPurchaseOrderItemAmountUSD.Name = "pivotTotalPurchaseOrderItemAmountUSD"
        Me.pivotTotalPurchaseOrderItemAmountUSD.Options.AllowRunTimeSummaryChange = True
        Me.pivotTotalPurchaseOrderItemAmountUSD.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pivotTotalPurchaseOrderItemAmountUSD.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pivotTotalPurchaseOrderItemAmountUSD.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pivotTotalPurchaseOrderItemAmountUSD.Width = 153
        '
        'frmHomeManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmHomeManagement"
        Me.Text = "Pantalla Principal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.grdSalesTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSalesTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtWoodInventorySpecieChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grdPODeliveryItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdSalesTracking As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSalesTracking As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chtWoodInventorySpecieChart As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStockItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStdCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents repoDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnRefreshData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdPODeliveryItem As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldTotalReceivedAmountUSD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCategoryDesc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField348 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldReceivedQty As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubmissionDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubmissionDateWC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubmissionDateMC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTotalPurchaseOrderItemAmountUSD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pivotTotalPurchaseOrderItemAmountUSD As DevExpress.XtraPivotGrid.PivotGridField
End Class
