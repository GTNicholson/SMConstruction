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
    Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.repitDateDefault = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
    Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitDateDefault, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitDateDefault.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(12, 21)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.repitDateDefault, Me.RepositoryItemDateEdit4, Me.RepositoryItemDateEdit5})
    Me.GridControl1.Size = New System.Drawing.Size(1181, 130)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.GridView1.Appearance.ColumnFilterButton.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.GridView1.Appearance.Row.Options.UseFont = True
    Me.GridView1.ColumnPanelRowHeight = 40
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.HorzScrollStep = 3
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsBehavior.Editable = False
    Me.GridView1.OptionsLayout.Columns.StoreAllOptions = True
    Me.GridView1.OptionsLayout.StoreAllOptions = True
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowFooter = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn13
    '
    Me.GridColumn13.Caption = "Fecha Semanal"
    Me.GridColumn13.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn13.DisplayFormat.FormatString = "d"
    Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn13.FieldName = "CompanyDayDateWC"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CompanyDayDateWC", "{0:N2}")})
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 1
    Me.GridColumn13.Width = 91
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "Fecha Mensual"
    Me.GridColumn14.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn14.DisplayFormat.FormatString = "d"
    Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn14.FieldName = "CompanyDayDateMC"
    Me.GridColumn14.Name = "GridColumn14"
    Me.GridColumn14.Visible = True
    Me.GridColumn14.VisibleIndex = 0
    Me.GridColumn14.Width = 65
    '
    'GridColumn15
    '
    Me.GridColumn15.Caption = "ValueEngineered"
    Me.GridColumn15.FieldName = "ValueEngineered"
    Me.GridColumn15.Name = "GridColumn15"
    Me.GridColumn15.Visible = True
    Me.GridColumn15.VisibleIndex = 2
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "ValuePacked"
    Me.GridColumn1.DisplayFormat.FormatString = "C$#,##0.00;;#"
    Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn1.FieldName = "ValuePacked"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 3
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Costo de Tiempo Std."
    Me.GridColumn2.DisplayFormat.FormatString = "C$#,##0.00;;#"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn2.FieldName = "LabourCostStd"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 4
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Costo de Tiempo Extra"
    Me.GridColumn3.DisplayFormat.FormatString = "C$#,##0.00;;#"
    Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn3.FieldName = "LabourCostOT"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 5
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Costo de Picking"
    Me.GridColumn4.DisplayFormat.FormatString = "C$#,##0.00;;#"
    Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn4.FieldName = "MatOtherCost"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 6
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Costo de PT"
    Me.GridColumn5.DisplayFormat.FormatString = "C$#,##0.00;;#"
    Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn5.FieldName = "WoodMatReqCost"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 7
    '
    'RepositoryItemDateEdit2
    '
    Me.RepositoryItemDateEdit2.AutoHeight = False
    Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
    Me.RepositoryItemDateEdit2.NullDate = New Date(CType(0, Long))
    '
    'repitDateDefault
    '
    Me.repitDateDefault.AutoHeight = False
    Me.repitDateDefault.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repitDateDefault.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repitDateDefault.Name = "repitDateDefault"
    Me.repitDateDefault.NullDate = New Date(CType(0, Long))
    '
    'RepositoryItemDateEdit4
    '
    Me.RepositoryItemDateEdit4.AutoHeight = False
    Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
    Me.RepositoryItemDateEdit4.NullDate = New Date(CType(0, Long))
    Me.RepositoryItemDateEdit4.NullText = " "
    '
    'RepositoryItemDateEdit5
    '
    Me.RepositoryItemDateEdit5.AutoHeight = False
    Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
    Me.RepositoryItemDateEdit5.NullDate = New Date(CType(0, Long))
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
    Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField2})
    Me.PivotGridControl1.Location = New System.Drawing.Point(50, 187)
    Me.PivotGridControl1.Name = "PivotGridControl1"
    Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
    Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
    Me.PivotGridControl1.OptionsDataField.Caption = "Datos del Periodo"
    Me.PivotGridControl1.OptionsDataField.RowHeaderWidth = 400
    Me.PivotGridControl1.Size = New System.Drawing.Size(1002, 200)
    Me.PivotGridControl1.TabIndex = 1
    '
    'PivotGridField1
    '
    Me.PivotGridField1.AreaIndex = 0
    Me.PivotGridField1.Caption = "Fecha Diaria"
    Me.PivotGridField1.CellFormat.FormatString = "ddd"
    Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.PivotGridField1.FieldName = "CompanyDayDate"
    Me.PivotGridField1.Name = "PivotGridField1"
    '
    'PivotGridField3
    '
    Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.PivotGridField3.AreaIndex = 0
    Me.PivotGridField3.Caption = "Fecha Semana"
    Me.PivotGridField3.CellFormat.FormatString = "mm"
    Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.PivotGridField3.FieldName = "CompanyDayDateWC"
    Me.PivotGridField3.Name = "PivotGridField3"
    '
    'PivotGridField4
    '
    Me.PivotGridField4.AreaIndex = 1
    Me.PivotGridField4.Caption = "Fecha Mensual"
    Me.PivotGridField4.CellFormat.FormatString = "yyyy"
    Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.PivotGridField4.FieldName = "CompanyDayDateMC"
    Me.PivotGridField4.Name = "PivotGridField4"
    '
    'PivotGridField5
    '
    Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField5.AreaIndex = 0
    Me.PivotGridField5.Caption = "Valor en Ingeniería"
    Me.PivotGridField5.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField5.FieldName = "ValueEngineered"
    Me.PivotGridField5.Name = "PivotGridField5"
    '
    'PivotGridField6
    '
    Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField6.AreaIndex = 1
    Me.PivotGridField6.Caption = "Valor Empacado"
    Me.PivotGridField6.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField6.FieldName = "ValuePacked"
    Me.PivotGridField6.Name = "PivotGridField6"
    '
    'PivotGridField7
    '
    Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField7.AreaIndex = 3
    Me.PivotGridField7.Caption = "Costo Tiempo Std."
    Me.PivotGridField7.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField7.FieldName = "LabourCostStd"
    Me.PivotGridField7.Name = "PivotGridField7"
    '
    'PivotGridField8
    '
    Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField8.AreaIndex = 4
    Me.PivotGridField8.Caption = "Costo Tiempo Extra"
    Me.PivotGridField8.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField8.FieldName = "LabourCostOT"
    Me.PivotGridField8.Name = "PivotGridField8"
    '
    'PivotGridField9
    '
    Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField9.AreaIndex = 2
    Me.PivotGridField9.Caption = "Costo Picking"
    Me.PivotGridField9.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField9.FieldName = "MatOtherCost"
    Me.PivotGridField9.Name = "PivotGridField9"
    '
    'PivotGridField2
    '
    Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField2.AreaIndex = 5
    Me.PivotGridField2.Caption = "Costo de Madera"
    Me.PivotGridField2.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField2.FieldName = "WoodMatReqCost"
    Me.PivotGridField2.Name = "PivotGridField2"
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
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitDateDefault.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitDateDefault, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitDateDefault As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
End Class
