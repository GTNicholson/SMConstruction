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
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.grdWorksOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvWorksOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdWorksOrders
    '
    Me.grdWorksOrders.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdWorksOrders.Location = New System.Drawing.Point(0, 29)
    Me.grdWorksOrders.MainView = Me.gvWorksOrders
    Me.grdWorksOrders.Name = "grdWorksOrders"
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
    Me.gvWorksOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn4, Me.GridColumn10, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
    Me.gvWorksOrders.GridControl = Me.grdWorksOrders
    Me.gvWorksOrders.Name = "gvWorksOrders"
    Me.gvWorksOrders.OptionsView.ColumnAutoWidth = False
    Me.gvWorksOrders.OptionsView.ShowAutoFilterRow = True
    Me.gvWorksOrders.OptionsView.ShowGroupPanel = False
    Me.gvWorksOrders.RowHeight = 34
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Numero de O.T."
    Me.GridColumn1.FieldName = "WorkOrderNo"
    Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Descripcion"
    Me.GridColumn2.FieldName = "Description"
    Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 328
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Cantidad"
    Me.GridColumn3.FieldName = "Quantity"
    Me.GridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 62
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Tipo de Producto"
    Me.GridColumn6.FieldName = "ProductType"
    Me.GridColumn6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 3
    Me.GridColumn6.Width = 138
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Orden"
    Me.GridColumn4.FieldName = "OrderNo"
    Me.GridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 4
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Diseno"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 6
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
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Inginiero"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 7
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Compa de Materiales"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 8
    '
    'GridColumn9
    '
    Me.GridColumn9.Caption = "Compra de Madera"
    Me.GridColumn9.Name = "GridColumn9"
    Me.GridColumn9.Visible = True
    Me.GridColumn9.VisibleIndex = 9
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Proyecto"
    Me.GridColumn10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 5
    Me.GridColumn10.Width = 106
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
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
End Class
