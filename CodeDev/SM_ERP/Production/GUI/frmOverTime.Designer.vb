<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverTime
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
    Me.Bar2 = New DevExpress.XtraBars.Bar()
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.bbtnLoadData = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSalary = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOverTime = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMileStone = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarEditItem1, Me.BarStaticItem2, Me.BarEditItem2, Me.bbtnLoadData})
    Me.BarManager1.MainMenu = Me.Bar2
    Me.BarManager1.MaxItemId = 5
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
    '
    'Bar2
    '
    Me.Bar2.BarName = "Menú principal"
    Me.Bar2.DockCol = 0
    Me.Bar2.DockRow = 0
    Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem1, "", False, True, True, 56), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem2, "", False, True, True, 115), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnLoadData)})
    Me.Bar2.OptionsBar.MultiLine = True
    Me.Bar2.OptionsBar.UseWholeRow = True
    Me.Bar2.Text = "Menú principal"
    '
    'BarStaticItem1
    '
    Me.BarStaticItem1.Caption = "Código Empleado"
    Me.BarStaticItem1.Id = 0
    Me.BarStaticItem1.Name = "BarStaticItem1"
    '
    'BarEditItem1
    '
    Me.BarEditItem1.Caption = "BarEditItem1"
    Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
    Me.BarEditItem1.Id = 1
    Me.BarEditItem1.Name = "BarEditItem1"
    '
    'RepositoryItemTextEdit1
    '
    Me.RepositoryItemTextEdit1.AutoHeight = False
    Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
    '
    'BarStaticItem2
    '
    Me.BarStaticItem2.Caption = "Nombre Empleado"
    Me.BarStaticItem2.Id = 2
    Me.BarStaticItem2.Name = "BarStaticItem2"
    '
    'BarEditItem2
    '
    Me.BarEditItem2.Caption = "BarEditItem2"
    Me.BarEditItem2.Edit = Me.RepositoryItemTextEdit2
    Me.BarEditItem2.Id = 3
    Me.BarEditItem2.Name = "BarEditItem2"
    '
    'RepositoryItemTextEdit2
    '
    Me.RepositoryItemTextEdit2.AutoHeight = False
    Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
    '
    'bbtnLoadData
    '
    Me.bbtnLoadData.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnLoadData.Caption = "Cargar Datos"
    Me.bbtnLoadData.Id = 4
    Me.bbtnLoadData.Name = "bbtnLoadData"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(906, 26)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 405)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(906, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 379)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(906, 26)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 379)
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(3, 3)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.MenuManager = Me.BarManager1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(900, 160)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcEmployeeID, Me.gcEmployeeName, Me.gcSalary, Me.gcOverTime, Me.gcMileStone, Me.GridColumn6})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'gcEmployeeID
    '
    Me.gcEmployeeID.Caption = "Código Empl"
    Me.gcEmployeeID.Name = "gcEmployeeID"
    Me.gcEmployeeID.Visible = True
    Me.gcEmployeeID.VisibleIndex = 0
    '
    'gcEmployeeName
    '
    Me.gcEmployeeName.Caption = "Nombre Empleado"
    Me.gcEmployeeName.Name = "gcEmployeeName"
    Me.gcEmployeeName.Visible = True
    Me.gcEmployeeName.VisibleIndex = 1
    '
    'gcSalary
    '
    Me.gcSalary.Caption = "Salario"
    Me.gcSalary.Name = "gcSalary"
    Me.gcSalary.Visible = True
    Me.gcSalary.VisibleIndex = 2
    '
    'gcOverTime
    '
    Me.gcOverTime.Caption = "Horas Extras"
    Me.gcOverTime.Name = "gcOverTime"
    Me.gcOverTime.Visible = True
    Me.gcOverTime.VisibleIndex = 3
    '
    'gcMileStone
    '
    Me.gcMileStone.Caption = "Centro de Costo"
    Me.gcMileStone.Name = "gcMileStone"
    Me.gcMileStone.Visible = True
    Me.gcMileStone.VisibleIndex = 4
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.GridControl2, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.GridControl1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 26)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.91029!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.08971!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(906, 379)
    Me.TableLayoutPanel1.TabIndex = 9
    '
    'GridControl2
    '
    Me.GridControl2.Location = New System.Drawing.Point(3, 176)
    Me.GridControl2.MainView = Me.GridView2
    Me.GridControl2.MenuManager = Me.BarManager1
    Me.GridControl2.Name = "GridControl2"
    Me.GridControl2.Size = New System.Drawing.Size(900, 160)
    Me.GridControl2.TabIndex = 1
    Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
    Me.GridView2.GridControl = Me.GridControl2
    Me.GridView2.Name = "GridView2"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Fecha"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Hora Entrada"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Hora Salida"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Hora Extra"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "# OT"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Pago de Hr Extra"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'frmOverTime
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(906, 405)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmOverTime"
    Me.Text = "frmOverTime"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents bbtnLoadData As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSalary As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcOverTime As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcMileStone As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
