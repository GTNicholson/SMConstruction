<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderDetail
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
    Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
    Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
    Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
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
    Me.barDockControlTop.Size = New System.Drawing.Size(1191, 29)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 633)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1191, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 604)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1191, 29)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 604)
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.GroupControl1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 29)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1191, 604)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'GroupControl1
    '
    Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl1.AppearanceCaption.Options.UseFont = True
    Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl1.Controls.Add(Me.Label1)
    Me.GroupControl1.Controls.Add(Me.TextEdit2)
    Me.GroupControl1.Controls.Add(Me.Label2)
    Me.GroupControl1.Controls.Add(Me.TextEdit1)
    Me.GroupControl1.Controls.Add(Me.GridControl4)
    Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(1185, 164)
    Me.GroupControl1.TabIndex = 13
    Me.GroupControl1.Text = "Detalles Generales"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(207, 32)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(120, 14)
    Me.Label1.TabIndex = 19
    Me.Label1.Tag = "c"
    Me.Label1.Text = "Nombre de Proyecto"
    '
    'TextEdit2
    '
    Me.TextEdit2.Location = New System.Drawing.Point(333, 29)
    Me.TextEdit2.MenuManager = Me.BarManager1
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextEdit2.Properties.Appearance.Options.UseFont = True
    Me.TextEdit2.Size = New System.Drawing.Size(247, 20)
    Me.TextEdit2.TabIndex = 18
    Me.TextEdit2.Tag = "c"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label2.Location = New System.Drawing.Point(5, 32)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 14)
    Me.Label2.TabIndex = 17
    Me.Label2.Tag = "c"
    Me.Label2.Text = "Referencia"
    '
    'TextEdit1
    '
    Me.TextEdit1.Location = New System.Drawing.Point(77, 29)
    Me.TextEdit1.MenuManager = Me.BarManager1
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextEdit1.Properties.Appearance.Options.UseFont = True
    Me.TextEdit1.Size = New System.Drawing.Size(111, 20)
    Me.TextEdit1.TabIndex = 16
    Me.TextEdit1.Tag = "c"
    '
    'GridControl4
    '
    Me.GridControl4.Location = New System.Drawing.Point(771, 26)
    Me.GridControl4.MainView = Me.GridView4
    Me.GridControl4.MenuManager = Me.BarManager1
    Me.GridControl4.Name = "GridControl4"
    Me.GridControl4.Size = New System.Drawing.Size(405, 133)
    Me.GridControl4.TabIndex = 14
    Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
    '
    'GridView4
    '
    Me.GridView4.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView4.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView4.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView4.Appearance.Row.Options.UseFont = True
    Me.GridView4.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView4.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GridView4.Appearance.ViewCaption.Options.UseFont = True
    Me.GridView4.Appearance.ViewCaption.Options.UseForeColor = True
    Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
    Me.GridView4.GridControl = Me.GridControl4
    Me.GridView4.Name = "GridView4"
    Me.GridView4.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Referencia de Orden"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Fecha"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Valor"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.GridControl3)
    Me.PanelControl1.Controls.Add(Me.GridControl2)
    Me.PanelControl1.Controls.Add(Me.GridControl1)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(3, 173)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1185, 428)
    Me.PanelControl1.TabIndex = 14
    '
    'GridControl3
    '
    Me.GridControl3.Location = New System.Drawing.Point(597, 223)
    Me.GridControl3.MainView = Me.GridView3
    Me.GridControl3.MenuManager = Me.BarManager1
    Me.GridControl3.Name = "GridControl3"
    Me.GridControl3.Size = New System.Drawing.Size(583, 200)
    Me.GridControl3.TabIndex = 13
    Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
    '
    'GridView3
    '
    Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView3.Appearance.Row.Options.UseFont = True
    Me.GridView3.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView3.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GridView3.Appearance.ViewCaption.Options.UseFont = True
    Me.GridView3.Appearance.ViewCaption.Options.UseForeColor = True
    Me.GridView3.GridControl = Me.GridControl3
    Me.GridView3.Name = "GridView3"
    Me.GridView3.OptionsView.ShowGroupPanel = False
    Me.GridView3.OptionsView.ShowViewCaption = True
    Me.GridView3.ViewCaption = "Facturas"
    '
    'GridControl2
    '
    Me.GridControl2.Location = New System.Drawing.Point(5, 223)
    Me.GridControl2.MainView = Me.GridView2
    Me.GridControl2.MenuManager = Me.BarManager1
    Me.GridControl2.Name = "GridControl2"
    Me.GridControl2.Size = New System.Drawing.Size(575, 200)
    Me.GridControl2.TabIndex = 12
    Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
    '
    'GridView2
    '
    Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView2.Appearance.Row.Options.UseFont = True
    Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView2.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GridView2.Appearance.ViewCaption.Options.UseFont = True
    Me.GridView2.Appearance.ViewCaption.Options.UseForeColor = True
    Me.GridView2.GridControl = Me.GridControl2
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.OptionsView.ShowViewCaption = True
    Me.GridView2.ViewCaption = "Despachos"
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(5, 5)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.MenuManager = Me.BarManager1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(1175, 200)
    Me.GridControl1.TabIndex = 11
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView1.Appearance.Row.Options.UseFont = True
    Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
    Me.GridView1.Appearance.ViewCaption.Options.UseForeColor = True
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.OptionsView.ShowViewCaption = True
    Me.GridView1.ViewCaption = "Ordenes de Trabajo"
    '
    'frmSalesOrderDetail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1191, 633)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmSalesOrderDetail"
    Me.Text = "Detalles de Venta"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents Label1 As Label
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label2 As Label
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
