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
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcProductType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn1, Me.gcProductType, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
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
    'GridColumn12
    '
    Me.GridColumn12.Caption = "ID"
    Me.GridColumn12.FieldName = "WorkOrderID"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.OptionsColumn.ReadOnly = True
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Número de OT"
    Me.GridColumn1.FieldName = "WorkOrderNo"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 123
    '
    'gcProductType
    '
    Me.gcProductType.Caption = "Tipo de Producto"
    Me.gcProductType.FieldName = "ProductTypeID"
    Me.gcProductType.Name = "gcProductType"
    Me.gcProductType.Visible = True
    Me.gcProductType.VisibleIndex = 1
    Me.gcProductType.Width = 156
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Cantidad"
    Me.GridColumn3.FieldName = "Quantity"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 117
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Descripción"
    Me.GridColumn4.FieldName = "Description"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    Me.GridColumn4.Width = 123
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Fecha Plan. Inicio"
    Me.GridColumn5.FieldName = "PlannedStartDate"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    Me.GridColumn5.Width = 141
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Fecha Plan. Entrega"
    Me.GridColumn6.FieldName = "PlannedDeliverDate"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    Me.GridColumn6.Width = 139
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Costo Est. de OT"
    Me.GridColumn7.DisplayFormat.FormatString = "N2"
    Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn7.FieldName = "UnitPrice"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 6
    Me.GridColumn7.Width = 143
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
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcProductType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
