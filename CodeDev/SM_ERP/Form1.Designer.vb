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
    Me.colTimeSheetEntry = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWorkOrder = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTimeSheetEntryID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTimeSheetEntryTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTimeSheetEntryTypeDesc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWorkOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTimeSheetDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTimeSheetDateWC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTimeSheetDateMC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWorkCentreID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWorkCentreDesc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWorkOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTimeSheetEntry, Me.colWorkOrder, Me.colTimeSheetEntryID, Me.colTimeSheetEntryTypeID, Me.colTimeSheetEntryTypeDesc, Me.colEmployeeID, Me.colEmployeeName, Me.colWorkOrderID, Me.colStartTime, Me.colTimeSheetDate, Me.colTimeSheetDateWC, Me.colTimeSheetDateMC, Me.colEndTime, Me.colDuration, Me.colNote, Me.colWorkCentreID, Me.colWorkCentreDesc, Me.colWorkOrderNo, Me.colDescription, Me.colCompanyName, Me.colProjectName})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'colTimeSheetEntry
    '
    Me.colTimeSheetEntry.FieldName = "TimeSheetEntry"
    Me.colTimeSheetEntry.Name = "colTimeSheetEntry"
    Me.colTimeSheetEntry.OptionsColumn.ReadOnly = True
    Me.colTimeSheetEntry.Visible = True
    Me.colTimeSheetEntry.VisibleIndex = 0
    '
    'colWorkOrder
    '
    Me.colWorkOrder.FieldName = "WorkOrder"
    Me.colWorkOrder.Name = "colWorkOrder"
    Me.colWorkOrder.OptionsColumn.ReadOnly = True
    Me.colWorkOrder.Visible = True
    Me.colWorkOrder.VisibleIndex = 1
    '
    'colTimeSheetEntryID
    '
    Me.colTimeSheetEntryID.FieldName = "TimeSheetEntryID"
    Me.colTimeSheetEntryID.Name = "colTimeSheetEntryID"
    Me.colTimeSheetEntryID.OptionsColumn.ReadOnly = True
    Me.colTimeSheetEntryID.Visible = True
    Me.colTimeSheetEntryID.VisibleIndex = 2
    '
    'colTimeSheetEntryTypeID
    '
    Me.colTimeSheetEntryTypeID.FieldName = "TimeSheetEntryTypeID"
    Me.colTimeSheetEntryTypeID.Name = "colTimeSheetEntryTypeID"
    Me.colTimeSheetEntryTypeID.OptionsColumn.ReadOnly = True
    Me.colTimeSheetEntryTypeID.Visible = True
    Me.colTimeSheetEntryTypeID.VisibleIndex = 3
    '
    'colTimeSheetEntryTypeDesc
    '
    Me.colTimeSheetEntryTypeDesc.FieldName = "TimeSheetEntryTypeDesc"
    Me.colTimeSheetEntryTypeDesc.Name = "colTimeSheetEntryTypeDesc"
    Me.colTimeSheetEntryTypeDesc.OptionsColumn.ReadOnly = True
    Me.colTimeSheetEntryTypeDesc.Visible = True
    Me.colTimeSheetEntryTypeDesc.VisibleIndex = 4
    '
    'colEmployeeID
    '
    Me.colEmployeeID.FieldName = "EmployeeID"
    Me.colEmployeeID.Name = "colEmployeeID"
    Me.colEmployeeID.OptionsColumn.ReadOnly = True
    Me.colEmployeeID.Visible = True
    Me.colEmployeeID.VisibleIndex = 5
    '
    'colEmployeeName
    '
    Me.colEmployeeName.FieldName = "EmployeeName"
    Me.colEmployeeName.Name = "colEmployeeName"
    Me.colEmployeeName.OptionsColumn.ReadOnly = True
    Me.colEmployeeName.Visible = True
    Me.colEmployeeName.VisibleIndex = 6
    '
    'colWorkOrderID
    '
    Me.colWorkOrderID.FieldName = "WorkOrderID"
    Me.colWorkOrderID.Name = "colWorkOrderID"
    Me.colWorkOrderID.OptionsColumn.ReadOnly = True
    Me.colWorkOrderID.Visible = True
    Me.colWorkOrderID.VisibleIndex = 7
    '
    'colStartTime
    '
    Me.colStartTime.FieldName = "StartTime"
    Me.colStartTime.Name = "colStartTime"
    Me.colStartTime.OptionsColumn.ReadOnly = True
    Me.colStartTime.Visible = True
    Me.colStartTime.VisibleIndex = 8
    '
    'colTimeSheetDate
    '
    Me.colTimeSheetDate.FieldName = "TimeSheetDate"
    Me.colTimeSheetDate.Name = "colTimeSheetDate"
    Me.colTimeSheetDate.OptionsColumn.ReadOnly = True
    Me.colTimeSheetDate.Visible = True
    Me.colTimeSheetDate.VisibleIndex = 9
    '
    'colTimeSheetDateWC
    '
    Me.colTimeSheetDateWC.FieldName = "TimeSheetDateWC"
    Me.colTimeSheetDateWC.Name = "colTimeSheetDateWC"
    Me.colTimeSheetDateWC.OptionsColumn.ReadOnly = True
    Me.colTimeSheetDateWC.Visible = True
    Me.colTimeSheetDateWC.VisibleIndex = 10
    '
    'colTimeSheetDateMC
    '
    Me.colTimeSheetDateMC.FieldName = "TimeSheetDateMC"
    Me.colTimeSheetDateMC.Name = "colTimeSheetDateMC"
    Me.colTimeSheetDateMC.OptionsColumn.ReadOnly = True
    Me.colTimeSheetDateMC.Visible = True
    Me.colTimeSheetDateMC.VisibleIndex = 11
    '
    'colEndTime
    '
    Me.colEndTime.FieldName = "EndTime"
    Me.colEndTime.Name = "colEndTime"
    Me.colEndTime.OptionsColumn.ReadOnly = True
    Me.colEndTime.Visible = True
    Me.colEndTime.VisibleIndex = 12
    '
    'colDuration
    '
    Me.colDuration.FieldName = "Duration"
    Me.colDuration.Name = "colDuration"
    Me.colDuration.OptionsColumn.ReadOnly = True
    Me.colDuration.Visible = True
    Me.colDuration.VisibleIndex = 13
    '
    'colNote
    '
    Me.colNote.FieldName = "Note"
    Me.colNote.Name = "colNote"
    Me.colNote.OptionsColumn.ReadOnly = True
    Me.colNote.Visible = True
    Me.colNote.VisibleIndex = 14
    '
    'colWorkCentreID
    '
    Me.colWorkCentreID.FieldName = "WorkCentreID"
    Me.colWorkCentreID.Name = "colWorkCentreID"
    Me.colWorkCentreID.OptionsColumn.ReadOnly = True
    Me.colWorkCentreID.Visible = True
    Me.colWorkCentreID.VisibleIndex = 15
    '
    'colWorkCentreDesc
    '
    Me.colWorkCentreDesc.FieldName = "WorkCentreDesc"
    Me.colWorkCentreDesc.Name = "colWorkCentreDesc"
    Me.colWorkCentreDesc.OptionsColumn.ReadOnly = True
    Me.colWorkCentreDesc.Visible = True
    Me.colWorkCentreDesc.VisibleIndex = 16
    '
    'colWorkOrderNo
    '
    Me.colWorkOrderNo.FieldName = "WorkOrderNo"
    Me.colWorkOrderNo.Name = "colWorkOrderNo"
    Me.colWorkOrderNo.OptionsColumn.ReadOnly = True
    Me.colWorkOrderNo.Visible = True
    Me.colWorkOrderNo.VisibleIndex = 17
    '
    'colDescription
    '
    Me.colDescription.FieldName = "Description"
    Me.colDescription.Name = "colDescription"
    Me.colDescription.OptionsColumn.ReadOnly = True
    Me.colDescription.Visible = True
    Me.colDescription.VisibleIndex = 18
    '
    'colCompanyName
    '
    Me.colCompanyName.Caption = "Cliente"
    Me.colCompanyName.FieldName = "CompanyName"
    Me.colCompanyName.Name = "colCompanyName"
    Me.colCompanyName.Visible = True
    Me.colCompanyName.VisibleIndex = 19
    '
    'colProjectName
    '
    Me.colProjectName.Caption = "Nombre de Proyecto"
    Me.colProjectName.FieldName = "ProjectName"
    Me.colProjectName.Name = "colProjectName"
    Me.colProjectName.Visible = True
    Me.colProjectName.VisibleIndex = 20
    '
    'PivotGridControl1
    '
    Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldTimeSheetEntry, Me.fieldWorkOrder, Me.fieldTimeSheetEntryID, Me.fieldTimeSheetEntryTypeID, Me.fieldTimeSheetEntryTypeDesc, Me.fieldEmployeeID, Me.fieldEmployeeName, Me.fieldWorkOrderID, Me.fieldStartTime, Me.fieldTimeSheetDate, Me.fieldTimeSheetDateWC, Me.fieldTimeSheetDateMC, Me.fieldEndTime, Me.fieldDuration, Me.fieldNote, Me.fieldWorkCentreID, Me.fieldWorkCentreDesc, Me.fieldWorkOrderNo, Me.fieldDescription, Me.fieldCustomerName, Me.fieldProjectName, Me.gcOverTimeMinutes})
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
    '
    'fieldWorkOrder
    '
    Me.fieldWorkOrder.AreaIndex = 1
    Me.fieldWorkOrder.FieldName = "WorkOrder"
    Me.fieldWorkOrder.Name = "fieldWorkOrder"
    Me.fieldWorkOrder.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetEntryID
    '
    Me.fieldTimeSheetEntryID.AreaIndex = 2
    Me.fieldTimeSheetEntryID.FieldName = "TimeSheetEntryID"
    Me.fieldTimeSheetEntryID.Name = "fieldTimeSheetEntryID"
    Me.fieldTimeSheetEntryID.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetEntryTypeID
    '
    Me.fieldTimeSheetEntryTypeID.AreaIndex = 3
    Me.fieldTimeSheetEntryTypeID.FieldName = "TimeSheetEntryTypeID"
    Me.fieldTimeSheetEntryTypeID.Name = "fieldTimeSheetEntryTypeID"
    Me.fieldTimeSheetEntryTypeID.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetEntryTypeDesc
    '
    Me.fieldTimeSheetEntryTypeDesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldTimeSheetEntryTypeDesc.AreaIndex = 1
    Me.fieldTimeSheetEntryTypeDesc.FieldName = "TimeSheetEntryTypeDesc"
    Me.fieldTimeSheetEntryTypeDesc.Name = "fieldTimeSheetEntryTypeDesc"
    Me.fieldTimeSheetEntryTypeDesc.Options.AllowRunTimeSummaryChange = True
    '
    'fieldEmployeeID
    '
    Me.fieldEmployeeID.AreaIndex = 4
    Me.fieldEmployeeID.Caption = "ID Empleado"
    Me.fieldEmployeeID.FieldName = "EmployeeID"
    Me.fieldEmployeeID.Name = "fieldEmployeeID"
    Me.fieldEmployeeID.Options.AllowRunTimeSummaryChange = True
    '
    'fieldEmployeeName
    '
    Me.fieldEmployeeName.AreaIndex = 5
    Me.fieldEmployeeName.Caption = "Empleado"
    Me.fieldEmployeeName.FieldName = "EmployeeName"
    Me.fieldEmployeeName.Name = "fieldEmployeeName"
    Me.fieldEmployeeName.Options.AllowRunTimeSummaryChange = True
    '
    'fieldWorkOrderID
    '
    Me.fieldWorkOrderID.AreaIndex = 6
    Me.fieldWorkOrderID.FieldName = "WorkOrderID"
    Me.fieldWorkOrderID.Name = "fieldWorkOrderID"
    Me.fieldWorkOrderID.Options.AllowRunTimeSummaryChange = True
    '
    'fieldStartTime
    '
    Me.fieldStartTime.AreaIndex = 7
    Me.fieldStartTime.Caption = "Hora Inicio"
    Me.fieldStartTime.FieldName = "StartTime"
    Me.fieldStartTime.Name = "fieldStartTime"
    Me.fieldStartTime.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetDate
    '
    Me.fieldTimeSheetDate.AreaIndex = 8
    Me.fieldTimeSheetDate.FieldName = "TimeSheetDate"
    Me.fieldTimeSheetDate.Name = "fieldTimeSheetDate"
    Me.fieldTimeSheetDate.Options.AllowRunTimeSummaryChange = True
    '
    'fieldTimeSheetDateWC
    '
    Me.fieldTimeSheetDateWC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    Me.fieldTimeSheetDateWC.AreaIndex = 0
    Me.fieldTimeSheetDateWC.Caption = "Semana"
    Me.fieldTimeSheetDateWC.CellFormat.FormatString = "dd/MM"
    Me.fieldTimeSheetDateWC.FieldName = "TimeSheetDateWC"
    Me.fieldTimeSheetDateWC.Name = "fieldTimeSheetDateWC"
    Me.fieldTimeSheetDateWC.Options.AllowRunTimeSummaryChange = True
    Me.fieldTimeSheetDateWC.ValueFormat.FormatString = "dd/MM"
    Me.fieldTimeSheetDateWC.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    '
    'fieldTimeSheetDateMC
    '
    Me.fieldTimeSheetDateMC.AreaIndex = 9
    Me.fieldTimeSheetDateMC.FieldName = "TimeSheetDateMC"
    Me.fieldTimeSheetDateMC.Name = "fieldTimeSheetDateMC"
    Me.fieldTimeSheetDateMC.Options.AllowRunTimeSummaryChange = True
    '
    'fieldEndTime
    '
    Me.fieldEndTime.AreaIndex = 10
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
    Me.fieldNote.AreaIndex = 11
    Me.fieldNote.FieldName = "Note"
    Me.fieldNote.Name = "fieldNote"
    Me.fieldNote.Options.AllowRunTimeSummaryChange = True
    '
    'fieldWorkCentreID
    '
    Me.fieldWorkCentreID.AreaIndex = 12
    Me.fieldWorkCentreID.FieldName = "WorkCentreID"
    Me.fieldWorkCentreID.Name = "fieldWorkCentreID"
    Me.fieldWorkCentreID.Options.AllowRunTimeSummaryChange = True
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
    Me.fieldWorkOrderNo.AreaIndex = 16
    Me.fieldWorkOrderNo.Caption = "Núm. OT"
    Me.fieldWorkOrderNo.FieldName = "WorkOrderNo"
    Me.fieldWorkOrderNo.Name = "fieldWorkOrderNo"
    Me.fieldWorkOrderNo.Options.AllowRunTimeSummaryChange = True
    '
    'fieldDescription
    '
    Me.fieldDescription.AreaIndex = 13
    Me.fieldDescription.Caption = "Descripción de Producto"
    Me.fieldDescription.FieldName = "Description"
    Me.fieldDescription.Name = "fieldDescription"
    Me.fieldDescription.Options.AllowRunTimeSummaryChange = True
    '
    'fieldCustomerName
    '
    Me.fieldCustomerName.AreaIndex = 15
    Me.fieldCustomerName.Caption = "Cliente"
    Me.fieldCustomerName.FieldName = "CustomerName"
    Me.fieldCustomerName.Name = "fieldCustomerName"
    Me.fieldCustomerName.Options.AllowRunTimeSummaryChange = True
    '
    'fieldProjectName
    '
    Me.fieldProjectName.AreaIndex = 14
    Me.fieldProjectName.Caption = "Proyecto"
    Me.fieldProjectName.FieldName = "ProjectName"
    Me.fieldProjectName.Name = "fieldProjectName"
    Me.fieldProjectName.Options.AllowRunTimeSummaryChange = True
    '
    'gcOverTimeMinutes
    '
    Me.gcOverTimeMinutes.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
    Me.gcOverTimeMinutes.AreaIndex = 1
    Me.gcOverTimeMinutes.FieldName = "OverTimeMinutes"
    Me.gcOverTimeMinutes.Name = "gcOverTimeMinutes"
    Me.gcOverTimeMinutes.Options.AllowRunTimeSummaryChange = True
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
  Friend WithEvents colTimeSheetEntry As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWorkOrder As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTimeSheetEntryID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTimeSheetEntryTypeID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTimeSheetEntryTypeDesc As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWorkOrderID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStartTime As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTimeSheetDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTimeSheetDateWC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTimeSheetDateMC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colEndTime As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWorkCentreID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWorkCentreDesc As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWorkOrderNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
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
End Class
