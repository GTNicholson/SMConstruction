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
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
    Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.gvContacts = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.grdContacts = New DevExpress.XtraGrid.GridControl()
    Me.cboSales = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.chkStatus = New DevExpress.XtraEditors.CheckEdit()
    Me.datDate = New DevExpress.XtraEditors.DateEdit()
    Me.memNotas = New DevExpress.XtraEditors.MemoEdit()
    Me.txtRucNumber = New DevExpress.XtraEditors.TextEdit()
    Me.Label5 = New System.Windows.Forms.Label()
    CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.datDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.memNotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRucNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtCustomerName
    '
    Me.txtCustomerName.Location = New System.Drawing.Point(137, 26)
    Me.txtCustomerName.Name = "txtCustomerName"
    Me.txtCustomerName.Size = New System.Drawing.Size(163, 20)
    Me.txtCustomerName.TabIndex = 0
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
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(5, 29)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(126, 14)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Nombre de Compañía"
    '
    'GroupControl1
    '
    Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl1.AppearanceCaption.Options.UseFont = True
    Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl1.Controls.Add(Me.TextEdit4)
    Me.GroupControl1.Controls.Add(Me.Label4)
    Me.GroupControl1.Controls.Add(Me.TextEdit3)
    Me.GroupControl1.Controls.Add(Me.Label2)
    Me.GroupControl1.Controls.Add(Me.TextEdit2)
    Me.GroupControl1.Controls.Add(Me.Label3)
    Me.GroupControl1.Controls.Add(Me.txtCustomerName)
    Me.GroupControl1.Controls.Add(Me.Label1)
    Me.GroupControl1.Location = New System.Drawing.Point(12, 39)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(942, 111)
    Me.GroupControl1.TabIndex = 12
    Me.GroupControl1.Text = "Detalles Contables"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label3.Location = New System.Drawing.Point(372, 29)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(55, 14)
    Me.Label3.TabIndex = 18
    Me.Label3.Text = "# Cuenta"
    '
    'TextEdit2
    '
    Me.TextEdit2.Location = New System.Drawing.Point(433, 26)
    Me.TextEdit2.Name = "TextEdit2"
    Me.TextEdit2.Size = New System.Drawing.Size(343, 20)
    Me.TextEdit2.TabIndex = 18
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label2.Location = New System.Drawing.Point(337, 64)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 14)
    Me.Label2.TabIndex = 19
    Me.Label2.Text = "Tipo de Cliente"
    '
    'TextEdit3
    '
    Me.TextEdit3.Location = New System.Drawing.Point(433, 61)
    Me.TextEdit3.Name = "TextEdit3"
    Me.TextEdit3.Size = New System.Drawing.Size(163, 20)
    Me.TextEdit3.TabIndex = 20
    '
    'TextEdit4
    '
    Me.TextEdit4.Location = New System.Drawing.Point(137, 61)
    Me.TextEdit4.Name = "TextEdit4"
    Me.TextEdit4.Size = New System.Drawing.Size(163, 20)
    Me.TextEdit4.TabIndex = 22
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(101, 67)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(30, 14)
    Me.Label4.TabIndex = 21
    Me.Label4.Text = "País"
    '
    'gvContacts
    '
    Me.gvContacts.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvContacts.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvContacts.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvContacts.Appearance.Row.Options.UseFont = True
    Me.gvContacts.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gvContacts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
    Me.gvContacts.Appearance.ViewCaption.Options.UseFont = True
    Me.gvContacts.Appearance.ViewCaption.Options.UseForeColor = True
    Me.gvContacts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
    Me.gvContacts.GridControl = Me.grdContacts
    Me.gvContacts.Name = "gvContacts"
    Me.gvContacts.OptionsView.ShowGroupPanel = False
    Me.gvContacts.OptionsView.ShowViewCaption = True
    Me.gvContacts.ViewCaption = "Contacts"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Nombre"
    Me.GridColumn1.FieldName = "FirstName"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Appellido"
    Me.GridColumn2.FieldName = "LastName"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Tel."
    Me.GridColumn3.FieldName = "TelNo"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "EMail"
    Me.GridColumn4.FieldName = "Email"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Cel."
    Me.GridColumn5.FieldName = "Mobile"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    '
    'grdContacts
    '
    Me.grdContacts.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
    Me.grdContacts.EmbeddedNavigator.Buttons.Edit.Visible = False
    Me.grdContacts.EmbeddedNavigator.Buttons.EndEdit.Visible = False
    Me.grdContacts.EmbeddedNavigator.Buttons.First.Visible = False
    Me.grdContacts.EmbeddedNavigator.Buttons.Last.Visible = False
    Me.grdContacts.EmbeddedNavigator.Buttons.NextPage.Visible = False
    Me.grdContacts.EmbeddedNavigator.Buttons.PrevPage.Visible = False
    Me.grdContacts.Location = New System.Drawing.Point(12, 190)
    Me.grdContacts.MainView = Me.gvContacts
    Me.grdContacts.MenuManager = Me.BarManager1
    Me.grdContacts.Name = "grdContacts"
    Me.grdContacts.Size = New System.Drawing.Size(400, 200)
    Me.grdContacts.TabIndex = 10
    Me.grdContacts.UseEmbeddedNavigator = True
    Me.grdContacts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContacts})
    '
    'cboSales
    '
    Me.cboSales.Location = New System.Drawing.Point(574, 155)
    Me.cboSales.MenuManager = Me.BarManager1
    Me.cboSales.Name = "cboSales"
    Me.cboSales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboSales.Size = New System.Drawing.Size(100, 20)
    Me.cboSales.TabIndex = 18
    '
    'chkStatus
    '
    Me.chkStatus.Location = New System.Drawing.Point(574, 210)
    Me.chkStatus.MenuManager = Me.BarManager1
    Me.chkStatus.Name = "chkStatus"
    Me.chkStatus.Properties.Caption = "CheckEdit1"
    Me.chkStatus.Size = New System.Drawing.Size(75, 19)
    Me.chkStatus.TabIndex = 19
    '
    'datDate
    '
    Me.datDate.EditValue = Nothing
    Me.datDate.Location = New System.Drawing.Point(574, 271)
    Me.datDate.MenuManager = Me.BarManager1
    Me.datDate.Name = "datDate"
    Me.datDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.datDate.Size = New System.Drawing.Size(100, 20)
    Me.datDate.TabIndex = 20
    '
    'memNotas
    '
    Me.memNotas.Location = New System.Drawing.Point(738, 173)
    Me.memNotas.MenuManager = Me.BarManager1
    Me.memNotas.Name = "memNotas"
    Me.memNotas.Size = New System.Drawing.Size(100, 96)
    Me.memNotas.TabIndex = 21
    '
    'txtRucNumber
    '
    Me.txtRucNumber.Location = New System.Drawing.Point(638, 332)
    Me.txtRucNumber.Name = "txtRucNumber"
    Me.txtRucNumber.Size = New System.Drawing.Size(163, 20)
    Me.txtRucNumber.TabIndex = 24
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label5.Location = New System.Drawing.Point(602, 338)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(29, 14)
    Me.Label5.TabIndex = 23
    Me.Label5.Text = "RUC"
    '
    'frmCustomerDetail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1011, 402)
    Me.Controls.Add(Me.txtRucNumber)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.memNotas)
    Me.Controls.Add(Me.datDate)
    Me.Controls.Add(Me.chkStatus)
    Me.Controls.Add(Me.cboSales)
    Me.Controls.Add(Me.GroupControl1)
    Me.Controls.Add(Me.grdContacts)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.DoubleBuffered = True
    Me.Name = "frmCustomerDetail"
    Me.Text = "frmCustomerDetail"
    CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvContacts, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.datDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.memNotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRucNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents Label1 As Label
  Friend WithEvents txtRucNumber As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label5 As Label
  Friend WithEvents memNotas As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents datDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents cboSales As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label4 As Label
  Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label2 As Label
  Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label3 As Label
  Friend WithEvents grdContacts As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvContacts As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
