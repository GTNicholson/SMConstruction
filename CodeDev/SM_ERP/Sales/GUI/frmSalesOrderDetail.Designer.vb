<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesOrderDetail
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
    Me.components = New System.ComponentModel.Container()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.txtMainTown = New DevExpress.XtraEditors.TextEdit()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.txtPaymentTermsType = New DevExpress.XtraEditors.TextEdit()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.CustomerStatusID = New DevExpress.XtraEditors.TextEdit()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.txtAccountRef = New DevExpress.XtraEditors.TextEdit()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txtSalesAreaID = New DevExpress.XtraEditors.TextEdit()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btnedCustomer = New DevExpress.XtraEditors.ButtonEdit()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtVisibleNotes = New DevExpress.XtraEditors.MemoEdit()
    Me.dteDueTime = New DevExpress.XtraEditors.DateEdit()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.dteFinishDate = New DevExpress.XtraEditors.DateEdit()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.dteDateEntered = New DevExpress.XtraEditors.DateEdit()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboEstatusENUM = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cboOrderTypeID = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtSalesOrderID = New DevExpress.XtraEditors.TextEdit()
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
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.txtMainTown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPaymentTermsType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CustomerStatusID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAccountRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSalesAreaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.btnedCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtVisibleNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDueTime.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDueTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteFinishDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteFinishDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDateEntered.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteDateEntered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboEstatusENUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboOrderTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSalesOrderID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSave})
    Me.BarManager1.MaxItemId = 1
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave)})
    Me.Bar1.Text = "Tools"
    '
    'bbtnSave
    '
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
    Me.barDockControlTop.Size = New System.Drawing.Size(1191, 29)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 735)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1191, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 706)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1191, 29)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 706)
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
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1191, 706)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'GroupControl1
    '
    Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl1.AppearanceCaption.Options.UseFont = True
    Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl1.Controls.Add(Me.GroupControl2)
    Me.GroupControl1.Controls.Add(Me.Label9)
    Me.GroupControl1.Controls.Add(Me.txtVisibleNotes)
    Me.GroupControl1.Controls.Add(Me.dteDueTime)
    Me.GroupControl1.Controls.Add(Me.Label8)
    Me.GroupControl1.Controls.Add(Me.dteFinishDate)
    Me.GroupControl1.Controls.Add(Me.Label7)
    Me.GroupControl1.Controls.Add(Me.dteDateEntered)
    Me.GroupControl1.Controls.Add(Me.Label6)
    Me.GroupControl1.Controls.Add(Me.cboEstatusENUM)
    Me.GroupControl1.Controls.Add(Me.Label5)
    Me.GroupControl1.Controls.Add(Me.cboOrderTypeID)
    Me.GroupControl1.Controls.Add(Me.Label4)
    Me.GroupControl1.Controls.Add(Me.txtProjectName)
    Me.GroupControl1.Controls.Add(Me.Label3)
    Me.GroupControl1.Controls.Add(Me.Label2)
    Me.GroupControl1.Controls.Add(Me.txtSalesOrderID)
    Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(1185, 286)
    Me.GroupControl1.TabIndex = 13
    Me.GroupControl1.Text = "Detalles Generales"
    '
    'GroupControl2
    '
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.Controls.Add(Me.txtMainTown)
    Me.GroupControl2.Controls.Add(Me.Label14)
    Me.GroupControl2.Controls.Add(Me.txtPaymentTermsType)
    Me.GroupControl2.Controls.Add(Me.Label13)
    Me.GroupControl2.Controls.Add(Me.CustomerStatusID)
    Me.GroupControl2.Controls.Add(Me.Label12)
    Me.GroupControl2.Controls.Add(Me.txtAccountRef)
    Me.GroupControl2.Controls.Add(Me.Label11)
    Me.GroupControl2.Controls.Add(Me.txtSalesAreaID)
    Me.GroupControl2.Controls.Add(Me.Label10)
    Me.GroupControl2.Controls.Add(Me.btnedCustomer)
    Me.GroupControl2.Controls.Add(Me.Label1)
    Me.GroupControl2.Location = New System.Drawing.Point(9, 124)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(663, 133)
    Me.GroupControl2.TabIndex = 36
    Me.GroupControl2.Text = "Detalles de Cliente"
    '
    'txtMainTown
    '
    Me.txtMainTown.Location = New System.Drawing.Point(72, 99)
    Me.txtMainTown.MenuManager = Me.BarManager1
    Me.txtMainTown.Name = "txtMainTown"
    Me.txtMainTown.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMainTown.Properties.Appearance.Options.UseFont = True
    Me.txtMainTown.Properties.ReadOnly = True
    Me.txtMainTown.Size = New System.Drawing.Size(187, 20)
    Me.txtMainTown.TabIndex = 45
    Me.txtMainTown.Tag = "c"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label14.Location = New System.Drawing.Point(9, 102)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(45, 14)
    Me.Label14.TabIndex = 44
    Me.Label14.Tag = "c"
    Me.Label14.Text = "Ciudad"
    '
    'txtPaymentTermsType
    '
    Me.txtPaymentTermsType.Location = New System.Drawing.Point(469, 99)
    Me.txtPaymentTermsType.MenuManager = Me.BarManager1
    Me.txtPaymentTermsType.Name = "txtPaymentTermsType"
    Me.txtPaymentTermsType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPaymentTermsType.Properties.Appearance.Options.UseFont = True
    Me.txtPaymentTermsType.Properties.ReadOnly = True
    Me.txtPaymentTermsType.Size = New System.Drawing.Size(187, 20)
    Me.txtPaymentTermsType.TabIndex = 43
    Me.txtPaymentTermsType.Tag = "c"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label13.Location = New System.Drawing.Point(360, 102)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(103, 14)
    Me.Label13.TabIndex = 42
    Me.Label13.Tag = "c"
    Me.Label13.Text = "Téminos de Pago"
    '
    'CustomerStatusID
    '
    Me.CustomerStatusID.Location = New System.Drawing.Point(469, 28)
    Me.CustomerStatusID.MenuManager = Me.BarManager1
    Me.CustomerStatusID.Name = "CustomerStatusID"
    Me.CustomerStatusID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CustomerStatusID.Properties.Appearance.Options.UseFont = True
    Me.CustomerStatusID.Properties.ReadOnly = True
    Me.CustomerStatusID.Size = New System.Drawing.Size(187, 20)
    Me.CustomerStatusID.TabIndex = 41
    Me.CustomerStatusID.Tag = "c"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label12.Location = New System.Drawing.Point(360, 31)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(48, 14)
    Me.Label12.TabIndex = 40
    Me.Label12.Tag = "c"
    Me.Label12.Text = "Estatus"
    '
    'txtAccountRef
    '
    Me.txtAccountRef.Location = New System.Drawing.Point(469, 64)
    Me.txtAccountRef.MenuManager = Me.BarManager1
    Me.txtAccountRef.Name = "txtAccountRef"
    Me.txtAccountRef.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAccountRef.Properties.Appearance.Options.UseFont = True
    Me.txtAccountRef.Properties.ReadOnly = True
    Me.txtAccountRef.Size = New System.Drawing.Size(187, 20)
    Me.txtAccountRef.TabIndex = 39
    Me.txtAccountRef.Tag = "c"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label11.Location = New System.Drawing.Point(360, 67)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(55, 14)
    Me.Label11.TabIndex = 38
    Me.Label11.Tag = "c"
    Me.Label11.Text = "# Cuenta"
    '
    'txtSalesAreaID
    '
    Me.txtSalesAreaID.Location = New System.Drawing.Point(72, 64)
    Me.txtSalesAreaID.MenuManager = Me.BarManager1
    Me.txtSalesAreaID.Name = "txtSalesAreaID"
    Me.txtSalesAreaID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSalesAreaID.Properties.Appearance.Options.UseFont = True
    Me.txtSalesAreaID.Properties.ReadOnly = True
    Me.txtSalesAreaID.Size = New System.Drawing.Size(187, 20)
    Me.txtSalesAreaID.TabIndex = 37
    Me.txtSalesAreaID.Tag = "c"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label10.Location = New System.Drawing.Point(9, 67)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(30, 14)
    Me.Label10.TabIndex = 36
    Me.Label10.Tag = "c"
    Me.Label10.Text = "País"
    '
    'btnedCustomer
    '
    Me.btnedCustomer.Location = New System.Drawing.Point(72, 28)
    Me.btnedCustomer.MenuManager = Me.BarManager1
    Me.btnedCustomer.Name = "btnedCustomer"
    Me.btnedCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btnedCustomer.Size = New System.Drawing.Size(187, 20)
    Me.btnedCustomer.TabIndex = 35
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(9, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 14)
    Me.Label1.TabIndex = 19
    Me.Label1.Tag = "c"
    Me.Label1.Text = "Cliente"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label9.Location = New System.Drawing.Point(761, 188)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(38, 14)
    Me.Label9.TabIndex = 34
    Me.Label9.Tag = "c"
    Me.Label9.Text = "Notas"
    '
    'txtVisibleNotes
    '
    Me.txtVisibleNotes.Location = New System.Drawing.Point(865, 172)
    Me.txtVisibleNotes.MenuManager = Me.BarManager1
    Me.txtVisibleNotes.Name = "txtVisibleNotes"
    Me.txtVisibleNotes.Size = New System.Drawing.Size(194, 85)
    Me.txtVisibleNotes.TabIndex = 33
    '
    'dteDueTime
    '
    Me.dteDueTime.EditValue = Nothing
    Me.dteDueTime.Location = New System.Drawing.Point(865, 135)
    Me.dteDueTime.MenuManager = Me.BarManager1
    Me.dteDueTime.Name = "dteDueTime"
    Me.dteDueTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDueTime.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDueTime.Size = New System.Drawing.Size(194, 20)
    Me.dteDueTime.TabIndex = 32
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label8.Location = New System.Drawing.Point(761, 138)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(97, 14)
    Me.Label8.TabIndex = 31
    Me.Label8.Tag = "c"
    Me.Label8.Text = "Fecha Entregada"
    '
    'dteFinishDate
    '
    Me.dteFinishDate.EditValue = Nothing
    Me.dteFinishDate.Location = New System.Drawing.Point(865, 84)
    Me.dteFinishDate.MenuManager = Me.BarManager1
    Me.dteFinishDate.Name = "dteFinishDate"
    Me.dteFinishDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteFinishDate.Size = New System.Drawing.Size(194, 20)
    Me.dteFinishDate.TabIndex = 30
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label7.Location = New System.Drawing.Point(761, 87)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(98, 14)
    Me.Label7.TabIndex = 29
    Me.Label7.Tag = "c"
    Me.Label7.Text = "Fecha Requerida"
    '
    'dteDateEntered
    '
    Me.dteDateEntered.EditValue = Nothing
    Me.dteDateEntered.Location = New System.Drawing.Point(865, 32)
    Me.dteDateEntered.MenuManager = Me.BarManager1
    Me.dteDateEntered.Name = "dteDateEntered"
    Me.dteDateEntered.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDateEntered.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDateEntered.Size = New System.Drawing.Size(194, 20)
    Me.dteDateEntered.TabIndex = 28
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label6.Location = New System.Drawing.Point(735, 35)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(120, 14)
    Me.Label6.TabIndex = 27
    Me.Label6.Tag = "c"
    Me.Label6.Text = "Fecha de Realización"
    '
    'cboEstatusENUM
    '
    Me.cboEstatusENUM.Location = New System.Drawing.Point(478, 82)
    Me.cboEstatusENUM.MenuManager = Me.BarManager1
    Me.cboEstatusENUM.Name = "cboEstatusENUM"
    Me.cboEstatusENUM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboEstatusENUM.Size = New System.Drawing.Size(194, 20)
    Me.cboEstatusENUM.TabIndex = 26
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label5.Location = New System.Drawing.Point(348, 85)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(44, 14)
    Me.Label5.TabIndex = 25
    Me.Label5.Tag = "c"
    Me.Label5.Text = "Estado"
    '
    'cboOrderTypeID
    '
    Me.cboOrderTypeID.Location = New System.Drawing.Point(478, 32)
    Me.cboOrderTypeID.MenuManager = Me.BarManager1
    Me.cboOrderTypeID.Name = "cboOrderTypeID"
    Me.cboOrderTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboOrderTypeID.Size = New System.Drawing.Size(194, 20)
    Me.cboOrderTypeID.TabIndex = 24
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(348, 35)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(82, 14)
    Me.Label4.TabIndex = 23
    Me.Label4.Tag = "c"
    Me.Label4.Text = "Tipo de Venta"
    '
    'txtProjectName
    '
    Me.txtProjectName.Location = New System.Drawing.Point(81, 79)
    Me.txtProjectName.MenuManager = Me.BarManager1
    Me.txtProjectName.Name = "txtProjectName"
    Me.txtProjectName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtProjectName.Properties.Appearance.Options.UseFont = True
    Me.txtProjectName.Size = New System.Drawing.Size(187, 20)
    Me.txtProjectName.TabIndex = 22
    Me.txtProjectName.Tag = "c"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label3.Location = New System.Drawing.Point(9, 82)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(56, 14)
    Me.Label3.TabIndex = 21
    Me.Label3.Tag = "c"
    Me.Label3.Text = "Proyecto"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label2.Location = New System.Drawing.Point(9, 35)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 14)
    Me.Label2.TabIndex = 17
    Me.Label2.Tag = "c"
    Me.Label2.Text = "Referencia"
    '
    'txtSalesOrderID
    '
    Me.txtSalesOrderID.Location = New System.Drawing.Point(81, 32)
    Me.txtSalesOrderID.MenuManager = Me.BarManager1
    Me.txtSalesOrderID.Name = "txtSalesOrderID"
    Me.txtSalesOrderID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSalesOrderID.Properties.Appearance.Options.UseFont = True
    Me.txtSalesOrderID.Size = New System.Drawing.Size(187, 20)
    Me.txtSalesOrderID.TabIndex = 16
    Me.txtSalesOrderID.Tag = "c"
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.GridControl3)
    Me.PanelControl1.Controls.Add(Me.GridControl2)
    Me.PanelControl1.Controls.Add(Me.GridControl1)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(3, 301)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1185, 402)
    Me.PanelControl1.TabIndex = 14
    '
    'GridControl3
    '
    Me.GridControl3.Location = New System.Drawing.Point(581, 161)
    Me.GridControl3.MainView = Me.GridView3
    Me.GridControl3.MenuManager = Me.BarManager1
    Me.GridControl3.Name = "GridControl3"
    Me.GridControl3.Size = New System.Drawing.Size(599, 200)
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
    Me.GridControl2.Location = New System.Drawing.Point(0, 161)
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
    Me.GridControl1.Location = New System.Drawing.Point(9, 5)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.MenuManager = Me.BarManager1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(1175, 150)
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
    Me.ClientSize = New System.Drawing.Size(1191, 735)
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
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    Me.GroupControl2.PerformLayout()
    CType(Me.txtMainTown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPaymentTermsType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CustomerStatusID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAccountRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSalesAreaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.btnedCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtVisibleNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDueTime.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDueTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteFinishDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteFinishDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDateEntered.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteDateEntered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboEstatusENUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboOrderTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSalesOrderID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents Label9 As Label
  Friend WithEvents txtVisibleNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents dteDueTime As DevExpress.XtraEditors.DateEdit
  Friend WithEvents Label8 As Label
  Friend WithEvents dteFinishDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents Label7 As Label
  Friend WithEvents dteDateEntered As DevExpress.XtraEditors.DateEdit
  Friend WithEvents Label6 As Label
  Friend WithEvents cboEstatusENUM As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label5 As Label
  Friend WithEvents cboOrderTypeID As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label4 As Label
  Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label3 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents txtSalesOrderID As DevExpress.XtraEditors.TextEdit
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents btnedCustomer As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents txtAccountRef As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label11 As Label
  Friend WithEvents txtSalesAreaID As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label10 As Label
  Friend WithEvents txtMainTown As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label14 As Label
  Friend WithEvents txtPaymentTermsType As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label13 As Label
  Friend WithEvents CustomerStatusID As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label12 As Label
End Class
