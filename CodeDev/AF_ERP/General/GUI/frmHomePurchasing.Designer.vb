<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomePurchasing
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
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel2 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesView3 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesView4 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim StackedBarSeriesLabel3 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView5 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel4 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView6 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.repoDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.chtInvoice = New DevExpress.XtraCharts.ChartControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grdSalesTracking = New DevExpress.XtraGrid.GridControl()
        Me.gvSalesTracking = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.chrPurchaseOrderCategory = New DevExpress.XtraCharts.ChartControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grdPurchaseOrderUnpaid = New DevExpress.XtraGrid.GridControl()
        Me.gvPurchaseOrderInfoUnpaid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcPONumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonOpenPO = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.gcCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPOProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCategoryDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSubmissionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositoryDateFinished = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.gcRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTotalGrossValueUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRefreshData = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.repoDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.chtInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.grdSalesTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSalesTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.chrPurchaseOrderCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grdPurchaseOrderUnpaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderInfoUnpaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonOpenPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryDateFinished, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryDateFinished.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'repoDate
        '
        Me.repoDate.AutoHeight = False
        Me.repoDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoDate.Name = "repoDate"
        Me.repoDate.NullDate = New Date(CType(0, Long))
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1054, 654)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.chtInvoice)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(633, 356)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(418, 295)
        Me.PanelControl5.TabIndex = 4
        '
        'chtInvoice
        '
        Me.chtInvoice.AppearanceNameSerializable = "Light"
        Me.chtInvoice.DataBindings = Nothing
        XyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.chtInvoice.Diagram = XyDiagram1
        Me.chtInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chtInvoice.Legend.Name = "Default Legend"
        Me.chtInvoice.Location = New System.Drawing.Point(2, 2)
        Me.chtInvoice.Name = "chtInvoice"
        Me.chtInvoice.PaletteName = "Pastel Kit"
        Series1.ArgumentDataMember = "InvoiceDateMC"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("InvoicePredictedType", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        StackedBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = StackedBarSeriesLabel1
        Series1.Name = "Factura"
        Series1.SummaryFunction = "SUM([NetValue])"
        Series1.View = StackedBarSeriesView1
        Series2.ArgumentDataMember = "InvoiceDateMC"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("InvoicePredictedType", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2)})
        StackedBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Label = StackedBarSeriesLabel2
        Series2.Name = "Empacado"
        Series2.ValueDataMembersSerializable = "NetValue"
        Series2.View = StackedBarSeriesView2
        Series3.ArgumentDataMember = "InvoiceDateMC"
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("InvoicePredictedType", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 3)})
        Series3.Name = "Ingenieria"
        Series3.ValueDataMembersSerializable = "NetValue"
        Series3.View = StackedBarSeriesView3
        Series4.ArgumentDataMember = "InvoiceDateMC"
        Series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series4.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("InvoicePredictedType", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 4)})
        Series4.Name = "Faltante"
        Series4.ValueDataMembersSerializable = "NetValue"
        Series4.View = StackedBarSeriesView4
        Me.chtInvoice.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4}
        StackedBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chtInvoice.SeriesTemplate.Label = StackedBarSeriesLabel3
        Me.chtInvoice.SeriesTemplate.View = StackedBarSeriesView5
        Me.chtInvoice.Size = New System.Drawing.Size(414, 291)
        Me.chtInvoice.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.grdSalesTracking)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(3, 356)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(624, 295)
        Me.PanelControl4.TabIndex = 3
        '
        'grdSalesTracking
        '
        Me.grdSalesTracking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSalesTracking.Location = New System.Drawing.Point(2, 2)
        Me.grdSalesTracking.MainView = Me.gvSalesTracking
        Me.grdSalesTracking.Name = "grdSalesTracking"
        Me.grdSalesTracking.Size = New System.Drawing.Size(620, 291)
        Me.grdSalesTracking.TabIndex = 1
        Me.grdSalesTracking.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesTracking})
        '
        'gvSalesTracking
        '
        Me.gvSalesTracking.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvSalesTracking.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesTracking.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvSalesTracking.Appearance.EvenRow.Options.UseFont = True
        Me.gvSalesTracking.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvSalesTracking.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSalesTracking.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvSalesTracking.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvSalesTracking.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvSalesTracking.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesTracking.Appearance.OddRow.Options.UseBackColor = True
        Me.gvSalesTracking.Appearance.OddRow.Options.UseFont = True
        Me.gvSalesTracking.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesTracking.Appearance.Row.Options.UseFont = True
        Me.gvSalesTracking.ColumnPanelRowHeight = 34
        Me.gvSalesTracking.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.gcComments, Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.gvSalesTracking.GridControl = Me.grdSalesTracking
        Me.gvSalesTracking.Name = "gvSalesTracking"
        Me.gvSalesTracking.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvSalesTracking.OptionsBehavior.ReadOnly = True
        Me.gvSalesTracking.OptionsView.EnableAppearanceEvenRow = True
        Me.gvSalesTracking.OptionsView.EnableAppearanceOddRow = True
        Me.gvSalesTracking.OptionsView.ShowAutoFilterRow = True
        Me.gvSalesTracking.OptionsView.ShowDetailButtons = False
        Me.gvSalesTracking.OptionsView.ShowGroupPanel = False
        Me.gvSalesTracking.OptionsView.ShowViewCaption = True
        Me.gvSalesTracking.ViewCaption = "Recepciones hechas en la semana"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "O.C."
        Me.GridColumn6.FieldName = "PONum"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 49
        '
        'gcComments
        '
        Me.gcComments.Caption = "Comentarios"
        Me.gcComments.FieldName = "Comments"
        Me.gcComments.Name = "gcComments"
        Me.gcComments.Visible = True
        Me.gcComments.VisibleIndex = 5
        Me.gcComments.Width = 180
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Requerida"
        Me.GridColumn7.ColumnEdit = Me.repoDate
        Me.GridColumn7.FieldName = "RequiredDate"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 71
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proveedor"
        Me.GridColumn1.FieldName = "CompanyName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 157
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Recibida"
        Me.GridColumn2.FieldName = "DateCreated"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 83
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "# Recepción"
        Me.GridColumn3.FieldName = "GRNumber"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 62
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.chrPurchaseOrderCategory)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(633, 55)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(418, 295)
        Me.PanelControl3.TabIndex = 2
        '
        'chrPurchaseOrderCategory
        '
        Me.chrPurchaseOrderCategory.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
        Me.chrPurchaseOrderCategory.AppearanceNameSerializable = "Light"
        Me.chrPurchaseOrderCategory.AutoLayout = False
        Me.chrPurchaseOrderCategory.DataBindings = Nothing
        XyDiagram2.AxisX.Title.Text = "Categoría Compra"
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Label.TextPattern = "{V:$0}"
        XyDiagram2.AxisY.Title.Text = "Valor Bruto USD"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.chrPurchaseOrderCategory.Diagram = XyDiagram2
        Me.chrPurchaseOrderCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrPurchaseOrderCategory.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch
        Me.chrPurchaseOrderCategory.IndicatorsPaletteName = "Blue II"
        Me.chrPurchaseOrderCategory.Legend.MaxHorizontalPercentage = 30.0R
        Me.chrPurchaseOrderCategory.Legend.Name = "Default Legend"
        Me.chrPurchaseOrderCategory.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chrPurchaseOrderCategory.Location = New System.Drawing.Point(2, 2)
        Me.chrPurchaseOrderCategory.Name = "chrPurchaseOrderCategory"
        Me.chrPurchaseOrderCategory.PaletteName = "Slipstream"
        Series5.ArgumentDataMember = "CategoryDesc"
        Series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series5.Name = "Valor USD"
        Series5.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
        Series5.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Series5.SummaryFunction = "SUM([TotalGrossValueUSD])"
        Me.chrPurchaseOrderCategory.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5}
        Me.chrPurchaseOrderCategory.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.chrPurchaseOrderCategory.SeriesTemplate.ArgumentDataMember = "CategoryDesc"
        Me.chrPurchaseOrderCategory.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        StackedBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chrPurchaseOrderCategory.SeriesTemplate.Label = StackedBarSeriesLabel4
        Me.chrPurchaseOrderCategory.SeriesTemplate.LegendTextPattern = "{A}"
        Me.chrPurchaseOrderCategory.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
        Me.chrPurchaseOrderCategory.SeriesTemplate.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Me.chrPurchaseOrderCategory.SeriesTemplate.SummaryFunction = "SUM([TotalGrossValueUSD])"
        Me.chrPurchaseOrderCategory.SeriesTemplate.View = StackedBarSeriesView6
        Me.chrPurchaseOrderCategory.Size = New System.Drawing.Size(414, 291)
        Me.chrPurchaseOrderCategory.TabIndex = 0
        ChartTitle1.Text = "Compras por Categoría USD"
        Me.chrPurchaseOrderCategory.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grdPurchaseOrderUnpaid)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(3, 55)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(624, 295)
        Me.PanelControl2.TabIndex = 1
        '
        'grdPurchaseOrderUnpaid
        '
        Me.grdPurchaseOrderUnpaid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPurchaseOrderUnpaid.EmbeddedNavigator.Appearance.Options.UseTextOptions = True
        Me.grdPurchaseOrderUnpaid.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.grdPurchaseOrderUnpaid.Location = New System.Drawing.Point(2, 2)
        Me.grdPurchaseOrderUnpaid.MainView = Me.gvPurchaseOrderInfoUnpaid
        Me.grdPurchaseOrderUnpaid.Name = "grdPurchaseOrderUnpaid"
        Me.grdPurchaseOrderUnpaid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryDateFinished, Me.RepositoryItemButtonOpenPO})
        Me.grdPurchaseOrderUnpaid.Size = New System.Drawing.Size(620, 291)
        Me.grdPurchaseOrderUnpaid.TabIndex = 0
        Me.grdPurchaseOrderUnpaid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderInfoUnpaid})
        '
        'gvPurchaseOrderInfoUnpaid
        '
        Me.gvPurchaseOrderInfoUnpaid.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPurchaseOrderInfoUnpaid.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPurchaseOrderInfoUnpaid.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvPurchaseOrderInfoUnpaid.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPurchaseOrderInfoUnpaid.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.EvenRow.Options.UseFont = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPurchaseOrderInfoUnpaid.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPurchaseOrderInfoUnpaid.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvPurchaseOrderInfoUnpaid.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvPurchaseOrderInfoUnpaid.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPurchaseOrderInfoUnpaid.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPurchaseOrderInfoUnpaid.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.OddRow.Options.UseFont = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPurchaseOrderInfoUnpaid.Appearance.Row.Options.UseFont = True
        Me.gvPurchaseOrderInfoUnpaid.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gvPurchaseOrderInfoUnpaid.Appearance.ViewCaption.Options.UseFont = True
        Me.gvPurchaseOrderInfoUnpaid.ColumnPanelRowHeight = 34
        Me.gvPurchaseOrderInfoUnpaid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPONumber, Me.gcCompanyName, Me.gcPOProjectName, Me.gcCategoryDesc, Me.gcSubmissionDate, Me.gcRequiredDate, Me.gcTotalGrossValueUSD})
        Me.gvPurchaseOrderInfoUnpaid.DetailHeight = 300
        Me.gvPurchaseOrderInfoUnpaid.GridControl = Me.grdPurchaseOrderUnpaid
        Me.gvPurchaseOrderInfoUnpaid.Name = "gvPurchaseOrderInfoUnpaid"
        Me.gvPurchaseOrderInfoUnpaid.OptionsBehavior.ReadOnly = True
        Me.gvPurchaseOrderInfoUnpaid.OptionsDetail.EnableMasterViewMode = False
        Me.gvPurchaseOrderInfoUnpaid.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPurchaseOrderInfoUnpaid.OptionsView.EnableAppearanceOddRow = True
        Me.gvPurchaseOrderInfoUnpaid.OptionsView.ShowFooter = True
        Me.gvPurchaseOrderInfoUnpaid.OptionsView.ShowGroupPanel = False
        Me.gvPurchaseOrderInfoUnpaid.OptionsView.ShowIndicator = False
        Me.gvPurchaseOrderInfoUnpaid.OptionsView.ShowViewCaption = True
        Me.gvPurchaseOrderInfoUnpaid.RowHeight = 10
        Me.gvPurchaseOrderInfoUnpaid.ViewCaption = "Ordenes de Compras no Pagadas"
        '
        'gcPONumber
        '
        Me.gcPONumber.AppearanceCell.Options.UseTextOptions = True
        Me.gcPONumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPONumber.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPONumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPONumber.Caption = "# O.C."
        Me.gcPONumber.ColumnEdit = Me.RepositoryItemButtonOpenPO
        Me.gcPONumber.FieldName = "PONum"
        Me.gcPONumber.Name = "gcPONumber"
        Me.gcPONumber.OptionsColumn.ReadOnly = True
        Me.gcPONumber.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.gcPONumber.Visible = True
        Me.gcPONumber.VisibleIndex = 0
        Me.gcPONumber.Width = 184
        '
        'RepositoryItemButtonOpenPO
        '
        Me.RepositoryItemButtonOpenPO.AutoHeight = False
        Me.RepositoryItemButtonOpenPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Abrir", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonOpenPO.Name = "RepositoryItemButtonOpenPO"
        '
        'gcCompanyName
        '
        Me.gcCompanyName.AppearanceCell.Options.UseTextOptions = True
        Me.gcCompanyName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcCompanyName.AppearanceHeader.Options.UseTextOptions = True
        Me.gcCompanyName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcCompanyName.Caption = "Proveedor"
        Me.gcCompanyName.FieldName = "CompanyName"
        Me.gcCompanyName.Name = "gcCompanyName"
        Me.gcCompanyName.OptionsColumn.ReadOnly = True
        Me.gcCompanyName.Visible = True
        Me.gcCompanyName.VisibleIndex = 1
        Me.gcCompanyName.Width = 271
        '
        'gcPOProjectName
        '
        Me.gcPOProjectName.AppearanceCell.Options.UseTextOptions = True
        Me.gcPOProjectName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPOProjectName.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPOProjectName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcPOProjectName.Caption = "Proyecto"
        Me.gcPOProjectName.FieldName = "ProjectName"
        Me.gcPOProjectName.Name = "gcPOProjectName"
        Me.gcPOProjectName.OptionsColumn.ReadOnly = True
        Me.gcPOProjectName.Visible = True
        Me.gcPOProjectName.VisibleIndex = 2
        Me.gcPOProjectName.Width = 339
        '
        'gcCategoryDesc
        '
        Me.gcCategoryDesc.AppearanceCell.Options.UseTextOptions = True
        Me.gcCategoryDesc.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcCategoryDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.gcCategoryDesc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcCategoryDesc.Caption = "Categoría"
        Me.gcCategoryDesc.FieldName = "CategoryDesc"
        Me.gcCategoryDesc.Name = "gcCategoryDesc"
        Me.gcCategoryDesc.OptionsColumn.ReadOnly = True
        Me.gcCategoryDesc.Visible = True
        Me.gcCategoryDesc.VisibleIndex = 3
        Me.gcCategoryDesc.Width = 244
        '
        'gcSubmissionDate
        '
        Me.gcSubmissionDate.AppearanceCell.Options.UseTextOptions = True
        Me.gcSubmissionDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcSubmissionDate.AppearanceHeader.Options.UseTextOptions = True
        Me.gcSubmissionDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcSubmissionDate.Caption = "Fecha del Pedido"
        Me.gcSubmissionDate.ColumnEdit = Me.repositoryDateFinished
        Me.gcSubmissionDate.FieldName = "SubmissionDate"
        Me.gcSubmissionDate.Name = "gcSubmissionDate"
        Me.gcSubmissionDate.OptionsColumn.ReadOnly = True
        Me.gcSubmissionDate.Visible = True
        Me.gcSubmissionDate.VisibleIndex = 4
        Me.gcSubmissionDate.Width = 189
        '
        'repositoryDateFinished
        '
        Me.repositoryDateFinished.AutoHeight = False
        Me.repositoryDateFinished.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryDateFinished.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryDateFinished.Name = "repositoryDateFinished"
        Me.repositoryDateFinished.NullDate = New Date(CType(0, Long))
        '
        'gcRequiredDate
        '
        Me.gcRequiredDate.AppearanceCell.Options.UseTextOptions = True
        Me.gcRequiredDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcRequiredDate.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRequiredDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcRequiredDate.Caption = "Fecha Requerida"
        Me.gcRequiredDate.ColumnEdit = Me.repositoryDateFinished
        Me.gcRequiredDate.FieldName = "RequiredDate"
        Me.gcRequiredDate.Name = "gcRequiredDate"
        Me.gcRequiredDate.OptionsColumn.ReadOnly = True
        Me.gcRequiredDate.Visible = True
        Me.gcRequiredDate.VisibleIndex = 5
        Me.gcRequiredDate.Width = 216
        '
        'gcTotalGrossValueUSD
        '
        Me.gcTotalGrossValueUSD.AppearanceCell.Options.UseTextOptions = True
        Me.gcTotalGrossValueUSD.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gcTotalGrossValueUSD.Caption = "Monto Total (USD)"
        Me.gcTotalGrossValueUSD.DisplayFormat.FormatString = "$#,##0.00;;#"
        Me.gcTotalGrossValueUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcTotalGrossValueUSD.FieldName = "TotalGrossValueUSD"
        Me.gcTotalGrossValueUSD.Name = "gcTotalGrossValueUSD"
        Me.gcTotalGrossValueUSD.OptionsColumn.ReadOnly = True
        Me.gcTotalGrossValueUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalGrossValueUSD", "{0:$#,##0.00;;#}")})
        Me.gcTotalGrossValueUSD.Visible = True
        Me.gcTotalGrossValueUSD.VisibleIndex = 6
        Me.gcTotalGrossValueUSD.Width = 179
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
        Me.PanelControl1.Size = New System.Drawing.Size(1048, 46)
        Me.PanelControl1.TabIndex = 0
        '
        'btnRefreshData
        '
        Me.btnRefreshData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshData.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefreshData.Appearance.Options.UseFont = True
        Me.btnRefreshData.Location = New System.Drawing.Point(937, 9)
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
        Me.lblUserName.Location = New System.Drawing.Point(466, 16)
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
        Me.LabelControl2.Location = New System.Drawing.Point(160, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(263, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Administración de Compras"
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
        'frmHomePurchasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 654)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmHomePurchasing"
        Me.Text = "Pantalla Principal"
        CType(Me.repoDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.grdSalesTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSalesTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrPurchaseOrderCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grdPurchaseOrderUnpaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderInfoUnpaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonOpenPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryDateFinished.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryDateFinished, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdPurchaseOrderUnpaid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPurchaseOrderInfoUnpaid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chtInvoice As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPONumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPOProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCategoryDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRefreshData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcSubmissionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTotalGrossValueUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repositoryDateFinished As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemButtonOpenPO As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents chrPurchaseOrderCategory As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
