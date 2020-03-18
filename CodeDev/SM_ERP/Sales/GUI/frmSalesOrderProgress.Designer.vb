<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesOrderProgress
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
    Me.grpItemDetail = New DevExpress.XtraEditors.GroupControl()
    Me.grdSalesOrderProgress = New DevExpress.XtraGrid.GridControl()
    Me.gvSalesOrderProgress = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcStockItemID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcStdCost = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitbtCurrentInventory = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpItemDetail.SuspendLayout()
    CType(Me.grdSalesOrderProgress, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvSalesOrderProgress, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitbtCurrentInventory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grpItemDetail
    '
    Me.grpItemDetail.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpItemDetail.Appearance.ForeColor = System.Drawing.Color.Maroon
    Me.grpItemDetail.Appearance.Options.UseFont = True
    Me.grpItemDetail.Appearance.Options.UseForeColor = True
    Me.grpItemDetail.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpItemDetail.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpItemDetail.AppearanceCaption.Options.UseFont = True
    Me.grpItemDetail.AppearanceCaption.Options.UseForeColor = True
    Me.grpItemDetail.Controls.Add(Me.grdSalesOrderProgress)
    Me.grpItemDetail.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpItemDetail.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpItemDetail.Location = New System.Drawing.Point(0, 0)
    Me.grpItemDetail.Name = "grpItemDetail"
    Me.grpItemDetail.Size = New System.Drawing.Size(939, 320)
    Me.grpItemDetail.TabIndex = 96
    Me.grpItemDetail.Text = "Lista de Proyectos en Curso"
    '
    'grdSalesOrderProgress
    '
    Me.grdSalesOrderProgress.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdSalesOrderProgress.Location = New System.Drawing.Point(2, 21)
    Me.grdSalesOrderProgress.MainView = Me.gvSalesOrderProgress
    Me.grdSalesOrderProgress.Name = "grdSalesOrderProgress"
    Me.grdSalesOrderProgress.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitbtCurrentInventory, Me.RepositoryItemDateEdit1})
    Me.grdSalesOrderProgress.Size = New System.Drawing.Size(935, 297)
    Me.grdSalesOrderProgress.TabIndex = 6
    Me.grdSalesOrderProgress.UseEmbeddedNavigator = True
    Me.grdSalesOrderProgress.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesOrderProgress})
    '
    'gvSalesOrderProgress
    '
    Me.gvSalesOrderProgress.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvSalesOrderProgress.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvSalesOrderProgress.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvSalesOrderProgress.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvSalesOrderProgress.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvSalesOrderProgress.Appearance.Row.Options.UseFont = True
    Me.gvSalesOrderProgress.ColumnPanelRowHeight = 34
    Me.gvSalesOrderProgress.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcStockItemID, Me.GridColumn6, Me.gcStdCost, Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
    Me.gvSalesOrderProgress.CustomizationFormBounds = New System.Drawing.Rectangle(1156, 318, 210, 270)
    Me.gvSalesOrderProgress.GridControl = Me.grdSalesOrderProgress
    Me.gvSalesOrderProgress.Name = "gvSalesOrderProgress"
    Me.gvSalesOrderProgress.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvSalesOrderProgress.OptionsBehavior.ReadOnly = True
    Me.gvSalesOrderProgress.OptionsView.ShowAutoFilterRow = True
    Me.gvSalesOrderProgress.OptionsView.ShowDetailButtons = False
    Me.gvSalesOrderProgress.OptionsView.ShowGroupPanel = False
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
    Me.GridColumn7.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn7.FieldName = "FinishDate"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 2
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Días en Piso"
    Me.GridColumn1.DisplayFormat.FormatString = "0.##;;#"
    Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn1.FieldName = "TimeSheetEntryDays"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 3
    Me.GridColumn1.Width = 58
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Cant OTs"
    Me.GridColumn2.DisplayFormat.FormatString = "0.##;;#"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn2.FieldName = "QtyWOs"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 4
    Me.GridColumn2.Width = 43
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Cant. OTs Liberadas por Ing."
    Me.GridColumn3.DisplayFormat.FormatString = "0.##;;#"
    Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn3.FieldName = "EngineeringCompleteQty"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 5
    Me.GridColumn3.Width = 84
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Cant Despachos"
    Me.GridColumn4.DisplayFormat.FormatString = "0.##;;#"
    Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn4.FieldName = "DespatchCompleteQty"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 6
    Me.GridColumn4.Width = 67
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
    'repitbtCurrentInventory
    '
    Me.repitbtCurrentInventory.AutoHeight = False
    Me.repitbtCurrentInventory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.repitbtCurrentInventory.Name = "repitbtCurrentInventory"
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
    '
    'frmSalesOrderProgress
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(939, 320)
    Me.Controls.Add(Me.grpItemDetail)
    Me.Name = "frmSalesOrderProgress"
    Me.Text = "frmSalesOrderProgress"
    CType(Me.grpItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpItemDetail.ResumeLayout(False)
    CType(Me.grdSalesOrderProgress, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvSalesOrderProgress, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitbtCurrentInventory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents grpItemDetail As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdSalesOrderProgress As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSalesOrderProgress As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcStockItemID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcStdCost As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitbtCurrentInventory As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
