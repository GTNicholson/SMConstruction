<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrderTracking
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.grdWorksOrders = New DevExpress.XtraGrid.GridControl()
    Me.gvWorksOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.gcDiseno = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcInginiero = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMachining = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAssembly = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSanding = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcPainting = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMetalWork = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcUpholstery = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.grdWorksOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvWorksOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdWorksOrders
    '
    Me.grdWorksOrders.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdWorksOrders.Location = New System.Drawing.Point(0, 29)
    Me.grdWorksOrders.MainView = Me.gvWorksOrders
    Me.grdWorksOrders.Name = "grdWorksOrders"
    Me.grdWorksOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
    Me.grdWorksOrders.Size = New System.Drawing.Size(1221, 597)
    Me.grdWorksOrders.TabIndex = 0
    Me.grdWorksOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorksOrders})
    '
    'gvWorksOrders
    '
    Me.gvWorksOrders.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvWorksOrders.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvWorksOrders.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvWorksOrders.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvWorksOrders.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvWorksOrders.Appearance.Row.Options.UseFont = True
    Me.gvWorksOrders.Appearance.Row.Options.UseTextOptions = True
    Me.gvWorksOrders.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvWorksOrders.ColumnPanelRowHeight = 34
    Me.gvWorksOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn10, Me.GridColumn5, Me.GridColumn6, Me.gcDiseno, Me.gcInginiero, Me.gcMachining, Me.gcAssembly, Me.gcSanding, Me.gcPainting, Me.gcMetalWork, Me.gcUpholstery})
    Me.gvWorksOrders.GridControl = Me.grdWorksOrders
    Me.gvWorksOrders.GroupCount = 1
    Me.gvWorksOrders.GroupRowHeight = 28
    Me.gvWorksOrders.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalValue", Nothing, "{0:0.##}")})
    Me.gvWorksOrders.Name = "gvWorksOrders"
    Me.gvWorksOrders.OptionsBehavior.AutoExpandAllGroups = True
    Me.gvWorksOrders.OptionsView.ColumnAutoWidth = False
    Me.gvWorksOrders.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
    Me.gvWorksOrders.OptionsView.ShowAutoFilterRow = True
    Me.gvWorksOrders.OptionsView.ShowGroupPanel = False
    Me.gvWorksOrders.RowHeight = 34
    Me.gvWorksOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Semana de Produccion"
    Me.GridColumn7.DisplayFormat.FormatString = "dd / MM"
    Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GridColumn7.FieldName = "PlannedStartDateWC"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 11
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn1.Caption = "Núm. O.T."
    Me.GridColumn1.FieldName = "WorkOrderNo"
    Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 94
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn2.Caption = "Descripción"
    Me.GridColumn2.FieldName = "Description"
    Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 112
    '
    'GridColumn3
    '
    Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn3.Caption = "Cantidad"
    Me.GridColumn3.FieldName = "Quantity"
    Me.GridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 62
    '
    'GridColumn4
    '
    Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn4.Caption = "Orden"
    Me.GridColumn4.FieldName = "OrderNo"
    Me.GridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.OptionsColumn.ReadOnly = True
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    Me.GridColumn4.Width = 65
    '
    'GridColumn10
    '
    Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn10.Caption = "Proyecto"
    Me.GridColumn10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.OptionsColumn.ReadOnly = True
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 4
    Me.GridColumn10.Width = 94
    '
    'GridColumn5
    '
    Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn5.Caption = "Fecha de Prod."
    Me.GridColumn5.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn5.FieldName = "PlannedStartDate"
    Me.GridColumn5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 5
    Me.GridColumn5.Width = 76
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
    '
    'gcDiseno
    '
    Me.gcDiseno.AppearanceCell.Options.UseTextOptions = True
    Me.gcDiseno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcDiseno.AppearanceHeader.Options.UseTextOptions = True
    Me.gcDiseno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcDiseno.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcDiseno.Caption = "Ingeniería"
    Me.gcDiseno.FieldName = "GridColumn5"
    Me.gcDiseno.Name = "gcDiseno"
    Me.gcDiseno.OptionsColumn.AllowEdit = False
    Me.gcDiseno.OptionsColumn.ReadOnly = True
    Me.gcDiseno.Tag = 1
    Me.gcDiseno.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcDiseno.Visible = True
    Me.gcDiseno.VisibleIndex = 7
    '
    'gcInginiero
    '
    Me.gcInginiero.AppearanceCell.Options.UseTextOptions = True
    Me.gcInginiero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcInginiero.AppearanceHeader.Options.UseTextOptions = True
    Me.gcInginiero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcInginiero.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcInginiero.Caption = "Dimensionado"
    Me.gcInginiero.FieldName = "GridColumn7"
    Me.gcInginiero.Name = "gcInginiero"
    Me.gcInginiero.OptionsColumn.AllowEdit = False
    Me.gcInginiero.OptionsColumn.ReadOnly = True
    Me.gcInginiero.Tag = 2
    Me.gcInginiero.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcInginiero.Visible = True
    Me.gcInginiero.VisibleIndex = 8
    Me.gcInginiero.Width = 89
    '
    'gcMachining
    '
    Me.gcMachining.AppearanceCell.Options.UseTextOptions = True
    Me.gcMachining.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcMachining.AppearanceHeader.Options.UseTextOptions = True
    Me.gcMachining.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcMachining.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcMachining.Caption = "Maquinado"
    Me.gcMachining.FieldName = "GridColumn8"
    Me.gcMachining.Name = "gcMachining"
    Me.gcMachining.OptionsColumn.AllowEdit = False
    Me.gcMachining.OptionsColumn.ReadOnly = True
    Me.gcMachining.Tag = 3
    Me.gcMachining.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcMachining.Visible = True
    Me.gcMachining.VisibleIndex = 9
    '
    'gcAssembly
    '
    Me.gcAssembly.AppearanceCell.Options.UseTextOptions = True
    Me.gcAssembly.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcAssembly.AppearanceHeader.Options.UseTextOptions = True
    Me.gcAssembly.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gcAssembly.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gcAssembly.Caption = "Ensamble"
    Me.gcAssembly.FieldName = "GridColumn9"
    Me.gcAssembly.Name = "gcAssembly"
    Me.gcAssembly.OptionsColumn.AllowEdit = False
    Me.gcAssembly.OptionsColumn.ReadOnly = True
    Me.gcAssembly.Tag = 4
    Me.gcAssembly.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcAssembly.Visible = True
    Me.gcAssembly.VisibleIndex = 10
    '
    'gcSanding
    '
    Me.gcSanding.Caption = "Lija"
    Me.gcSanding.FieldName = "gc"
    Me.gcSanding.Name = "gcSanding"
    Me.gcSanding.OptionsColumn.AllowEdit = False
    Me.gcSanding.OptionsColumn.ReadOnly = True
    Me.gcSanding.Tag = "5"
    Me.gcSanding.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcSanding.Visible = True
    Me.gcSanding.VisibleIndex = 11
    '
    'gcPainting
    '
    Me.gcPainting.Caption = "Pintura"
    Me.gcPainting.FieldName = "gcPainting"
    Me.gcPainting.Name = "gcPainting"
    Me.gcPainting.OptionsColumn.AllowEdit = False
    Me.gcPainting.OptionsColumn.ReadOnly = True
    Me.gcPainting.Tag = "6"
    Me.gcPainting.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcPainting.Visible = True
    Me.gcPainting.VisibleIndex = 12
    '
    'gcMetalWork
    '
    Me.gcMetalWork.Caption = "Metal"
    Me.gcMetalWork.FieldName = "Metal"
    Me.gcMetalWork.Name = "gcMetalWork"
    Me.gcMetalWork.OptionsColumn.AllowEdit = False
    Me.gcMetalWork.OptionsColumn.ReadOnly = True
    Me.gcMetalWork.Tag = "7"
    Me.gcMetalWork.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcMetalWork.Visible = True
    Me.gcMetalWork.VisibleIndex = 13
    '
    'gcUpholstery
    '
    Me.gcUpholstery.Caption = "Tapizado"
    Me.gcUpholstery.FieldName = "gcUpholstery"
    Me.gcUpholstery.Name = "gcUpholstery"
    Me.gcUpholstery.OptionsColumn.AllowEdit = False
    Me.gcUpholstery.OptionsColumn.ReadOnly = True
    Me.gcUpholstery.Tag = "8"
    Me.gcUpholstery.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.gcUpholstery.Visible = True
    Me.gcUpholstery.VisibleIndex = 14
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.MaxItemId = 0
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.Text = "Tools"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1221, 29)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 626)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1221, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 597)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1221, 29)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 597)
    '
    'GridColumn6
    '
    Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Lavender
    Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
    Me.GridColumn6.Caption = "Fecha Requerida"
    Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn6.FieldName = "FinishDate"
    Me.GridColumn6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 6
    '
    'frmWorkOrderTracking
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1221, 626)
    Me.Controls.Add(Me.grdWorksOrders)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmWorkOrderTracking"
    Me.Text = "Progreso de los O,T.s"
    CType(Me.grdWorksOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvWorksOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents grdWorksOrders As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorksOrders As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDiseno As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcInginiero As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMachining As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcAssembly As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents gcSanding As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcPainting As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMetalWork As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcUpholstery As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
