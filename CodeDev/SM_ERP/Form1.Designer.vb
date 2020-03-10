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
    Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
    Me.fieldTimeSheetEntry = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldWorkOrder = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTimeSheetEntryID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTimeSheetEntryTypeID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTimeSheetEntryTypeDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldEmployeeID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldEmployeeName = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldWorkOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldStartTime = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTimeSheetDate = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTimeSheetDateWC = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldTimeSheetDateMC = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldEndTime = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldDuration = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldNote = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldWorkCentreID = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldWorkCentreDesc = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldWorkOrderNo = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldDescription = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldCustomerName = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.fieldProjectName = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.gcOverTimeMinutes = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
    Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
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
    Me.GridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.GridView1.Appearance.ColumnFilterButton.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.GridView1.Appearance.Row.Options.UseFont = True
    Me.GridView1.ColumnPanelRowHeight = 40
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
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
    Me.GridColumn13.Caption = "CompanyDayDateWC"
    Me.GridColumn13.DisplayFormat.FormatString = "d"
    Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn13.FieldName = "CompanyDayDateWC"
    Me.GridColumn13.Name = "GridColumn13"
    Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CompanyDayDateWC", "{0:N2}")})
    Me.GridColumn13.Visible = True
    Me.GridColumn13.VisibleIndex = 1
    Me.GridColumn13.Width = 91
    '
    'GridColumn14
    '
    Me.GridColumn14.Caption = "CompanyDayDateMC"
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
    Me.GridColumn1.FieldName = "ValuePacked"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 3
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "LabcourCostStd"
    Me.GridColumn2.FieldName = "LabcourCostStd"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 4
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "LabcourCostOT"
    Me.GridColumn3.FieldName = "LabcourCostOT"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 5
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "MatOtherCost"
    Me.GridColumn4.FieldName = "MatOtherCost"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 6
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
    Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldTimeSheetEntry, Me.fieldWorkOrder, Me.fieldTimeSheetEntryID, Me.fieldTimeSheetEntryTypeID, Me.fieldTimeSheetEntryTypeDesc, Me.fieldEmployeeID, Me.fieldEmployeeName, Me.fieldWorkOrderID, Me.fieldStartTime, Me.fieldTimeSheetDate, Me.fieldTimeSheetDateWC, Me.fieldTimeSheetDateMC, Me.fieldEndTime, Me.fieldDuration, Me.fieldNote, Me.fieldWorkCentreID, Me.fieldWorkCentreDesc, Me.fieldWorkOrderNo, Me.fieldDescription, Me.fieldCustomerName, Me.fieldProjectName, Me.gcOverTimeMinutes, Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4})
    Me.PivotGridControl1.Location = New System.Drawing.Point(50, 187)
    Me.PivotGridControl1.Name = "PivotGridControl1"
    Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
    Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
    Me.PivotGridControl1.Size = New System.Drawing.Size(1002, 200)
    Me.PivotGridControl1.TabIndex = 1
    '
    'fieldTimeSheetEntry
    '
    Me.fieldTimeSheetEntry.AreaIndex = 0
    Me.fieldTimeSheetEntry.FieldName = "TimeSheetEntry"
    Me.fieldTimeSheetEntry.Name = "fieldTimeSheetEntry"
    Me.fieldTimeSheetEntry.Options.AllowRunTimeSummaryChange = True
    Me.fieldTimeSheetEntry.Visible = False
    '
    'fieldWorkOrder
    '
    Me.fieldWorkOrder.AreaIndex = 0
    Me.fieldWorkOrder.FieldName = "WorkOrder"
    Me.fieldWorkOrder.Name = "fieldWorkOrder"
    Me.fieldWorkOrder.Options.AllowRunTimeSummaryChange = True
    Me.fieldWorkOrder.Visible = False
    '
    'fieldTimeSheetEntryID
    '
    Me.fieldTimeSheetEntryID.AreaIndex = 0
    Me.fieldTimeSheetEntryID.FieldName = "TimeSheetEntryID"
    Me.fieldTimeSheetEntryID.Name = "fieldTimeSheetEntryID"
    Me.fieldTimeSheetEntryID.Options.AllowRunTimeSummaryChange = True
    Me.fieldTimeSheetEntryID.Visible = False
    '
    'fieldTimeSheetEntryTypeID
    '
    Me.fieldTimeSheetEntryTypeID.AreaIndex = 0
    Me.fieldTimeSheetEntryTypeID.Caption = "Tipo de Entrada"
    Me.fieldTimeSheetEntryTypeID.FieldName = "TimeSheetEntryTypeID"
    Me.fieldTimeSheetEntryTypeID.Name = "fieldTimeSheetEntryTypeID"
    Me.fieldTimeSheetEntryTypeID.Options.AllowRunTimeSummaryChange = True
    Me.fieldTimeSheetEntryTypeID.Visible = False
    '
    'fieldTimeSheetEntryTypeDesc
    '
    Me.fieldTimeSheetEntryTypeDesc.AreaIndex = 11
    Me.fieldTimeSheetEntryTypeDesc.Caption = "Tipo de Entrada"
    Me.fieldTimeSheetEntryTypeDesc.FieldName = "TimeSheetEntryTypeDesc"
    Me.fieldTimeSheetEntryTypeDesc.Name = "fieldTimeSheetEntryTypeDesc"
    Me.fieldTimeSheetEntryTypeDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldEmployeeID
    '
    Me.fieldEmployeeID.AreaIndex = 0
    Me.fieldEmployeeID.FieldName = "EmployeeID"
    Me.fieldEmployeeID.Name = "fieldEmployeeID"
    Me.fieldEmployeeID.Options.AllowRunTimeSummaryChange = True
    Me.fieldEmployeeID.Visible = False
    '
    'fieldEmployeeName
    '
    Me.fieldEmployeeName.AreaIndex = 0
    Me.fieldEmployeeName.Caption = "Empleado"
    Me.fieldEmployeeName.FieldName = "EmployeeName"
    Me.fieldEmployeeName.Name = "fieldEmployeeName"
    Me.fieldEmployeeName.Options.AllowRunTimeSummaryChange = True
    '
    'fieldWorkOrderID
    '
    Me.fieldWorkOrderID.AreaIndex = 1
    Me.fieldWorkOrderID.FieldName = "WorkOrderID"
    Me.fieldWorkOrderID.Name = "fieldWorkOrderID"
    Me.fieldWorkOrderID.Options.AllowRunTimeSummaryChange = True
    Me.fieldWorkOrderID.Visible = False
    '
    'fieldStartTime
    '
    Me.fieldStartTime.AreaIndex = 1
    Me.fieldStartTime.Caption = "Hora de Inicio"
    Me.fieldStartTime.FieldName = "StartTime"
    Me.fieldStartTime.Name = "fieldStartTime"
    Me.fieldStartTime.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetDate
    '
    Me.fieldTimeSheetDate.AreaIndex = 10
    Me.fieldTimeSheetDate.Caption = "Fecha"
    Me.fieldTimeSheetDate.FieldName = "TimeSheetDate"
    Me.fieldTimeSheetDate.Name = "fieldTimeSheetDate"
    Me.fieldTimeSheetDate.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetDateWC
    '
    Me.fieldTimeSheetDateWC.AreaIndex = 12
    Me.fieldTimeSheetDateWC.Caption = "Fecha Corta"
    Me.fieldTimeSheetDateWC.CellFormat.FormatString = "dd/MM"
    Me.fieldTimeSheetDateWC.FieldName = "TimeSheetDateWC"
    Me.fieldTimeSheetDateWC.Name = "fieldTimeSheetDateWC"
    Me.fieldTimeSheetDateWC.Options.AllowRunTimeSummaryChange = True
    Me.fieldTimeSheetDateWC.ValueFormat.FormatString = "dd/MM"
    Me.fieldTimeSheetDateWC.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    '
    'fieldTimeSheetDateMC
    '
    Me.fieldTimeSheetDateMC.AreaIndex = 2
    Me.fieldTimeSheetDateMC.Caption = "Fecha Mensual"
    Me.fieldTimeSheetDateMC.FieldName = "TimeSheetDateMC"
    Me.fieldTimeSheetDateMC.Name = "fieldTimeSheetDateMC"
    Me.fieldTimeSheetDateMC.Options.AllowRunTimeSummaryChange = True
    '
    'fieldEndTime
    '
    Me.fieldEndTime.AreaIndex = 3
    Me.fieldEndTime.Caption = "Hora Fin"
    Me.fieldEndTime.FieldName = "EndTime"
    Me.fieldEndTime.Name = "fieldEndTime"
    Me.fieldEndTime.Options.AllowRunTimeSummaryChange = True
    '
    'fieldDuration
    '
    Me.fieldDuration.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.fieldDuration.AreaIndex = 0
    Me.fieldDuration.Caption = "Duración"
    Me.fieldDuration.CellFormat.FormatString = "N0"
    Me.fieldDuration.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.fieldDuration.FieldName = "Duration"
    Me.fieldDuration.Name = "fieldDuration"
    Me.fieldDuration.Options.AllowRunTimeSummaryChange = True
    '
    'fieldNote
    '
    Me.fieldNote.AreaIndex = 4
    Me.fieldNote.Caption = "Notas"
    Me.fieldNote.FieldName = "Note"
    Me.fieldNote.Name = "fieldNote"
    Me.fieldNote.Options.AllowRunTimeSummaryChange = True
    '
    'fieldWorkCentreID
    '
    Me.fieldWorkCentreID.AreaIndex = 5
    Me.fieldWorkCentreID.FieldName = "WorkCentreID"
    Me.fieldWorkCentreID.Name = "fieldWorkCentreID"
    Me.fieldWorkCentreID.Options.AllowRunTimeSummaryChange = True
    Me.fieldWorkCentreID.Visible = False
    '
    'fieldWorkCentreDesc
    '
    Me.fieldWorkCentreDesc.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
    Me.fieldWorkCentreDesc.AreaIndex = 0
    Me.fieldWorkCentreDesc.Caption = "Centro de Trabajo"
    Me.fieldWorkCentreDesc.FieldName = "WorkCentreDesc"
    Me.fieldWorkCentreDesc.Name = "fieldWorkCentreDesc"
    Me.fieldWorkCentreDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldWorkOrderNo
    '
    Me.fieldWorkOrderNo.AreaIndex = 7
    Me.fieldWorkOrderNo.Caption = "Núm. OT"
    Me.fieldWorkOrderNo.FieldName = "WorkOrderNo"
    Me.fieldWorkOrderNo.Name = "fieldWorkOrderNo"
    Me.fieldWorkOrderNo.Options.AllowRunTimeSummaryChange = True
    '
    'fieldDescription
    '
    Me.fieldDescription.AreaIndex = 5
    Me.fieldDescription.Caption = "Descripción OT"
    Me.fieldDescription.FieldName = "Description"
    Me.fieldDescription.Name = "fieldDescription"
    Me.fieldDescription.Options.AllowRunTimeSummaryChange = True
    '
    'fieldCustomerName
    '
    Me.fieldCustomerName.AreaIndex = 6
    Me.fieldCustomerName.Caption = "Cliente"
    Me.fieldCustomerName.FieldName = "CustomerName"
    Me.fieldCustomerName.Name = "fieldCustomerName"
    Me.fieldCustomerName.Options.AllowRunTimeSummaryChange = True
    '
    'fieldProjectName
    '
    Me.fieldProjectName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldProjectName.AreaIndex = 0
    Me.fieldProjectName.Caption = "Proyecto"
    Me.fieldProjectName.FieldName = "ProjectName"
    Me.fieldProjectName.Name = "fieldProjectName"
    Me.fieldProjectName.Options.AllowRunTimeSummaryChange = True
    '
    'gcOverTimeMinutes
    '
    Me.gcOverTimeMinutes.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.gcOverTimeMinutes.AreaIndex = 2
    Me.gcOverTimeMinutes.Caption = "Tiempo Extra (minutos)"
    Me.gcOverTimeMinutes.CellFormat.FormatString = "N0"
    Me.gcOverTimeMinutes.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcOverTimeMinutes.FieldName = "OverTimeMinutes"
    Me.gcOverTimeMinutes.Name = "gcOverTimeMinutes"
    Me.gcOverTimeMinutes.Options.AllowRunTimeSummaryChange = True
    '
    'PivotGridField1
    '
    Me.PivotGridField1.AreaIndex = 8
    Me.PivotGridField1.Caption = "Tasa Hr. Std"
    Me.PivotGridField1.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField1.FieldName = "StandardRate"
    Me.PivotGridField1.Name = "PivotGridField1"
    '
    'PivotGridField2
    '
    Me.PivotGridField2.AreaIndex = 9
    Me.PivotGridField2.Caption = "Tasa T. Extra"
    Me.PivotGridField2.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField2.FieldName = "OverTimeRate"
    Me.PivotGridField2.Name = "PivotGridField2"
    '
    'PivotGridField3
    '
    Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField3.AreaIndex = 1
    Me.PivotGridField3.Caption = "Monto Total (Std)"
    Me.PivotGridField3.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField3.FieldName = "TotalStandardValue"
    Me.PivotGridField3.Name = "PivotGridField3"
    '
    'PivotGridField4
    '
    Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    Me.PivotGridField4.AreaIndex = 3
    Me.PivotGridField4.Caption = "Monto Total (T. Extra)"
    Me.PivotGridField4.CellFormat.FormatString = "C$#,##0.00;;#"
    Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.PivotGridField4.FieldName = "TotalOverTimeValue"
    Me.PivotGridField4.Name = "PivotGridField4"
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
  Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents fieldTimeSheetEntry As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldWorkOrder As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTimeSheetEntryID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTimeSheetEntryTypeID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTimeSheetEntryTypeDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldEmployeeID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldEmployeeName As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldWorkOrderID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldStartTime As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTimeSheetDate As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTimeSheetDateWC As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldTimeSheetDateMC As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldEndTime As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldDuration As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldNote As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldWorkCentreID As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldWorkCentreDesc As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldWorkOrderNo As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldDescription As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldCustomerName As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents fieldProjectName As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents gcOverTimeMinutes As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
  Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
End Class
