<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetail
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
    Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustomerID = New DevExpress.XtraEditors.TextEdit()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
    Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
    Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.Label2 = New System.Windows.Forms.Label()
    CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtCustomerName
    '
    Me.txtCustomerName.Location = New System.Drawing.Point(209, 57)
    Me.txtCustomerName.Name = "txtCustomerName"
    Me.txtCustomerName.Size = New System.Drawing.Size(163, 20)
    Me.txtCustomerName.TabIndex = 0
    '
    'txtCustomerID
    '
    Me.txtCustomerID.Location = New System.Drawing.Point(48, 57)
    Me.txtCustomerID.Name = "txtCustomerID"
    Me.txtCustomerID.Size = New System.Drawing.Size(71, 20)
    Me.txtCustomerID.TabIndex = 1
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSave})
    Me.BarManager1.MaxItemId = 1
    '
    'Bar1
    '
    Me.Bar1.BarName = "Herramientas"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave)})
    Me.Bar1.Text = "Herramientas"
    '
    'bbtnSave
    '
    Me.bbtnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnSave.Caption = "Guardar"
    Me.bbtnSave.Id = 0
    Me.bbtnSave.Name = "bbtnSave"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1011, 33)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 402)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1011, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 369)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1011, 33)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 369)
    '
    'TextEdit1
    '
    Me.TextEdit1.Location = New System.Drawing.Point(188, 195)
    Me.TextEdit1.MenuManager = Me.BarManager1
    Me.TextEdit1.Name = "TextEdit1"
    Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextEdit1.Properties.Appearance.Options.UseFont = True
    Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
    Me.TextEdit1.TabIndex = 6
    '
    'DateEdit1
    '
    Me.DateEdit1.EditValue = Nothing
    Me.DateEdit1.Location = New System.Drawing.Point(208, 134)
    Me.DateEdit1.MenuManager = Me.BarManager1
    Me.DateEdit1.Name = "DateEdit1"
    Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DateEdit1.Properties.Appearance.Options.UseFont = True
    Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
    Me.DateEdit1.TabIndex = 7
    '
    'ComboBoxEdit1
    '
    Me.ComboBoxEdit1.Location = New System.Drawing.Point(208, 242)
    Me.ComboBoxEdit1.MenuManager = Me.BarManager1
    Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
    Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
    Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.ComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
    Me.ComboBoxEdit1.TabIndex = 8
    '
    'MemoEdit1
    '
    Me.MemoEdit1.Location = New System.Drawing.Point(29, 285)
    Me.MemoEdit1.MenuManager = Me.BarManager1
    Me.MemoEdit1.Name = "MemoEdit1"
    Me.MemoEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MemoEdit1.Properties.Appearance.Options.UseFont = True
    Me.MemoEdit1.Size = New System.Drawing.Size(226, 96)
    Me.MemoEdit1.TabIndex = 9
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(351, 137)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.MenuManager = Me.BarManager1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(400, 200)
    Me.GridControl1.TabIndex = 10
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
    Me.GridView1.ViewCaption = "Contacts"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(80, 137)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 14)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Label1"
    '
    'GroupControl1
    '
    Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl1.AppearanceCaption.Options.UseFont = True
    Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl1.Location = New System.Drawing.Point(770, 179)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(200, 138)
    Me.GroupControl1.TabIndex = 12
    Me.GroupControl1.Text = "GroupControl1"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.Maroon
    Me.Label2.Location = New System.Drawing.Point(80, 105)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(51, 16)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "Label2"
    '
    'frmCustomerDetail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1011, 402)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.GroupControl1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GridControl1)
    Me.Controls.Add(Me.MemoEdit1)
    Me.Controls.Add(Me.ComboBoxEdit1)
    Me.Controls.Add(Me.DateEdit1)
    Me.Controls.Add(Me.TextEdit1)
    Me.Controls.Add(Me.txtCustomerID)
    Me.Controls.Add(Me.txtCustomerName)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.DoubleBuffered = True
    Me.Name = "frmCustomerDetail"
    Me.Text = "frmCustomerDetail"
    CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtCustomerID As DevExpress.XtraEditors.TextEdit
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents Label2 As Label
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents Label1 As Label
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
