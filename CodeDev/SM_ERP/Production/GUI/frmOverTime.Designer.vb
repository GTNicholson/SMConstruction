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
    Me.grdTimeSheetInfos = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSalary = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOverTime = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcMileStone = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
    Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.BarEditItem6 = New DevExpress.XtraBars.BarEditItem()
    Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    CType(Me.grdTimeSheetInfos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdTimeSheetInfos
    '
    Me.grdTimeSheetInfos.Location = New System.Drawing.Point(3, 3)
    Me.grdTimeSheetInfos.MainView = Me.GridView1
    Me.grdTimeSheetInfos.Name = "grdTimeSheetInfos"
    Me.grdTimeSheetInfos.Size = New System.Drawing.Size(900, 102)
    Me.grdTimeSheetInfos.TabIndex = 0
    Me.grdTimeSheetInfos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcEmployeeID, Me.gcEmployeeName, Me.gcSalary, Me.gcOverTime, Me.gcMileStone, Me.GridColumn6})
    Me.GridView1.GridControl = Me.grdTimeSheetInfos
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'gcEmployeeID
    '
    Me.gcEmployeeID.Caption = "Código Empl"
    Me.gcEmployeeID.FieldName = "EmployeeID"
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
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Pago de Hr Extra"
    Me.GridColumn6.FieldName = "OverTimeMinutes"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.GridControl2, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.grdTimeSheetInfos, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 83)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.91029!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.08971!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(906, 322)
    Me.TableLayoutPanel1.TabIndex = 9
    '
    'GridControl2
    '
    Me.GridControl2.Location = New System.Drawing.Point(3, 150)
    Me.GridControl2.MainView = Me.GridView2
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
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarHeaderItem1, Me.BarEditItem1, Me.BarStaticItem2, Me.BarEditItem2, Me.BarStaticItem3, Me.BarEditItem3, Me.BarStaticItem4, Me.BarEditItem4, Me.BarStaticItem5, Me.BarEditItem5, Me.BarEditItem6})
    Me.BarManager1.MaxItemId = 12
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemTextEdit3, Me.RepositoryItemComboBox3})
    Me.BarManager1.StatusBar = Me.Bar3
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(906, 29)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 382)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(906, 23)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 353)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(906, 29)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 353)
    '
    'Bar1
    '
    Me.Bar1.BarName = "Herramientas"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem3, "", False, True, True, 42), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem6)})
    Me.Bar1.Text = "Herramientas"
    '
    'Bar3
    '
    Me.Bar3.BarName = "Barra de estado"
    Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
    Me.Bar3.DockCol = 0
    Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
    Me.Bar3.OptionsBar.AllowQuickCustomization = False
    Me.Bar3.OptionsBar.DrawDragBorder = False
    Me.Bar3.OptionsBar.UseWholeRow = True
    Me.Bar3.Text = "Barra de estado"
    '
    'BarStaticItem1
    '
    Me.BarStaticItem1.Caption = "Còdigo Empleado"
    Me.BarStaticItem1.Id = 0
    Me.BarStaticItem1.Name = "BarStaticItem1"
    '
    'BarHeaderItem1
    '
    Me.BarHeaderItem1.Caption = "BarHeaderItem1"
    Me.BarHeaderItem1.Id = 1
    Me.BarHeaderItem1.Name = "BarHeaderItem1"
    '
    'BarEditItem1
    '
    Me.BarEditItem1.Caption = "BarEditItem1"
    Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
    Me.BarEditItem1.Id = 2
    Me.BarEditItem1.Name = "BarEditItem1"
    '
    'RepositoryItemTextEdit1
    '
    Me.RepositoryItemTextEdit1.AutoHeight = False
    Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
    '
    'BarStaticItem2
    '
    Me.BarStaticItem2.Caption = "Nombre de Empleado"
    Me.BarStaticItem2.Id = 3
    Me.BarStaticItem2.Name = "BarStaticItem2"
    '
    'BarEditItem2
    '
    Me.BarEditItem2.Caption = "BarEditItem2"
    Me.BarEditItem2.Edit = Me.RepositoryItemTextEdit2
    Me.BarEditItem2.Id = 4
    Me.BarEditItem2.Name = "BarEditItem2"
    '
    'RepositoryItemTextEdit2
    '
    Me.RepositoryItemTextEdit2.AutoHeight = False
    Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
    '
    'BarStaticItem3
    '
    Me.BarStaticItem3.Caption = "Quincena"
    Me.BarStaticItem3.Id = 5
    Me.BarStaticItem3.Name = "BarStaticItem3"
    '
    'BarEditItem3
    '
    Me.BarEditItem3.Caption = "Quincena"
    Me.BarEditItem3.Edit = Me.RepositoryItemComboBox1
    Me.BarEditItem3.Id = 6
    Me.BarEditItem3.Name = "BarEditItem3"
    '
    'RepositoryItemComboBox1
    '
    Me.RepositoryItemComboBox1.AutoHeight = False
    Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
    '
    'BarStaticItem4
    '
    Me.BarStaticItem4.Caption = "de"
    Me.BarStaticItem4.Id = 7
    Me.BarStaticItem4.Name = "BarStaticItem4"
    '
    'BarEditItem4
    '
    Me.BarEditItem4.Caption = "BarEditItem4"
    Me.BarEditItem4.Edit = Me.RepositoryItemComboBox2
    Me.BarEditItem4.Id = 8
    Me.BarEditItem4.Name = "BarEditItem4"
    '
    'RepositoryItemComboBox2
    '
    Me.RepositoryItemComboBox2.AutoHeight = False
    Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
    '
    'BarStaticItem5
    '
    Me.BarStaticItem5.Caption = "año"
    Me.BarStaticItem5.Id = 9
    Me.BarStaticItem5.Name = "BarStaticItem5"
    '
    'BarEditItem5
    '
    Me.BarEditItem5.Caption = "BarEditItem5"
    Me.BarEditItem5.Edit = Me.RepositoryItemTextEdit3
    Me.BarEditItem5.Id = 10
    Me.BarEditItem5.Name = "BarEditItem5"
    '
    'RepositoryItemTextEdit3
    '
    Me.RepositoryItemTextEdit3.AutoHeight = False
    Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
    '
    'BarEditItem6
    '
    Me.BarEditItem6.Caption = "BarEditItem6"
    Me.BarEditItem6.Edit = Me.RepositoryItemComboBox3
    Me.BarEditItem6.Id = 11
    Me.BarEditItem6.Name = "BarEditItem6"
    '
    'RepositoryItemComboBox3
    '
    Me.RepositoryItemComboBox3.AutoHeight = False
    Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
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
    CType(Me.grdTimeSheetInfos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grdTimeSheetInfos As DevExpress.XtraGrid.GridControl
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
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem4 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarEditItem6 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
  Friend WithEvents BarEditItem5 As DevExpress.XtraBars.BarEditItem
  Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
