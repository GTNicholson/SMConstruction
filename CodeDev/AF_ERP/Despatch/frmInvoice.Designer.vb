<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoice
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
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnGenerateInvoice = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.cboInvoiceStatus = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtTaxValue = New DevExpress.XtraEditors.TextEdit()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtNetValue = New DevExpress.XtraEditors.TextEdit()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dteInvoiceDate = New DevExpress.XtraEditors.DateEdit()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dteCreatedDate = New DevExpress.XtraEditors.DateEdit()
    Me.txtInvoiceID = New System.Windows.Forms.Label()
    Me.txtInvoiceNo = New DevExpress.XtraEditors.TextEdit()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btneSelectSO = New DevExpress.XtraEditors.ButtonEdit()
    Me.txtCustomerPurchaseOrder = New DevExpress.XtraEditors.TextEdit()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtCompanyName = New DevExpress.XtraEditors.TextEdit()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtOrderNo = New DevExpress.XtraEditors.TextEdit()
    Me.gpSOI = New DevExpress.XtraEditors.GroupControl()
    Me.grdSOI = New DevExpress.XtraGrid.GridControl()
    Me.gvSOI = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcSalesItemID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repocboSelectSOI = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.cboInvoiceStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTaxValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNetValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteCreatedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dteCreatedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.btneSelectSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomerPurchaseOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtOrderNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gpSOI, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpSOI.SuspendLayout()
    CType(Me.grdSOI, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvSOI, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repocboSelectSOI, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveAndClose, Me.bbtnSave, Me.btnClose, Me.bbtnGenerateInvoice})
    Me.BarManager1.MaxItemId = 4
    '
    'Bar1
    '
    Me.Bar1.BarName = "Herramientas"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.FloatLocation = New System.Drawing.Point(123, 136)
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnGenerateInvoice)})
    Me.Bar1.Text = "Herramientas"
    '
    'btnSaveAndClose
    '
    Me.btnSaveAndClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.btnSaveAndClose.Caption = "Guardar y Cerrar"
    Me.btnSaveAndClose.Id = 0
    Me.btnSaveAndClose.Name = "btnSaveAndClose"
    '
    'bbtnSave
    '
    Me.bbtnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnSave.Caption = "Guardar"
    Me.bbtnSave.Id = 1
    Me.bbtnSave.Name = "bbtnSave"
    '
    'btnClose
    '
    Me.btnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.btnClose.Caption = "Cerrar"
    Me.btnClose.Id = 2
    Me.btnClose.Name = "btnClose"
    '
    'bbtnGenerateInvoice
    '
    Me.bbtnGenerateInvoice.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnGenerateInvoice.Caption = "Generar Factura"
    Me.bbtnGenerateInvoice.Id = 3
    Me.bbtnGenerateInvoice.Name = "bbtnGenerateInvoice"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1164, 33)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 521)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1164, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 488)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1164, 33)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 488)
    '
    'GroupControl1
    '
    Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl1.AppearanceCaption.Options.UseFont = True
    Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl1.Controls.Add(Me.cboInvoiceStatus)
    Me.GroupControl1.Controls.Add(Me.Label4)
    Me.GroupControl1.Controls.Add(Me.txtTaxValue)
    Me.GroupControl1.Controls.Add(Me.Label3)
    Me.GroupControl1.Controls.Add(Me.txtNetValue)
    Me.GroupControl1.Controls.Add(Me.Label2)
    Me.GroupControl1.Controls.Add(Me.dteInvoiceDate)
    Me.GroupControl1.Controls.Add(Me.Label1)
    Me.GroupControl1.Controls.Add(Me.dteCreatedDate)
    Me.GroupControl1.Controls.Add(Me.txtInvoiceID)
    Me.GroupControl1.Controls.Add(Me.txtInvoiceNo)
    Me.GroupControl1.Controls.Add(Me.Label12)
    Me.GroupControl1.Controls.Add(Me.Label8)
    Me.GroupControl1.Location = New System.Drawing.Point(452, 39)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(700, 118)
    Me.GroupControl1.TabIndex = 4
    Me.GroupControl1.Text = "Información General"
    '
    'cboInvoiceStatus
    '
    Me.cboInvoiceStatus.Location = New System.Drawing.Point(583, 81)
    Me.cboInvoiceStatus.MenuManager = Me.BarManager1
    Me.cboInvoiceStatus.Name = "cboInvoiceStatus"
    Me.cboInvoiceStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboInvoiceStatus.Size = New System.Drawing.Size(100, 20)
    Me.cboInvoiceStatus.TabIndex = 28
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(508, 84)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(44, 14)
    Me.Label4.TabIndex = 27
    Me.Label4.Text = "Estado"
    '
    'txtTaxValue
    '
    Me.txtTaxValue.Location = New System.Drawing.Point(583, 32)
    Me.txtTaxValue.Name = "txtTaxValue"
    Me.txtTaxValue.Properties.MaxLength = 15
    Me.txtTaxValue.Size = New System.Drawing.Size(98, 20)
    Me.txtTaxValue.TabIndex = 26
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label3.Location = New System.Drawing.Point(508, 35)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(69, 14)
    Me.Label3.TabIndex = 25
    Me.Label3.Text = "Impuesto $"
    '
    'txtNetValue
    '
    Me.txtNetValue.Location = New System.Drawing.Point(364, 81)
    Me.txtNetValue.Name = "txtNetValue"
    Me.txtNetValue.Properties.MaxLength = 15
    Me.txtNetValue.Size = New System.Drawing.Size(113, 20)
    Me.txtNetValue.TabIndex = 24
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label2.Location = New System.Drawing.Point(252, 84)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 14)
    Me.Label2.TabIndex = 23
    Me.Label2.Text = "Valor Neto $"
    '
    'dteInvoiceDate
    '
    Me.dteInvoiceDate.EditValue = Nothing
    Me.dteInvoiceDate.Location = New System.Drawing.Point(364, 32)
    Me.dteInvoiceDate.MenuManager = Me.BarManager1
    Me.dteInvoiceDate.Name = "dteInvoiceDate"
    Me.dteInvoiceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteInvoiceDate.Properties.NullDate = New Date(CType(0, Long))
    Me.dteInvoiceDate.Size = New System.Drawing.Size(113, 20)
    Me.dteInvoiceDate.TabIndex = 22
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(252, 35)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(105, 14)
    Me.Label1.TabIndex = 21
    Me.Label1.Text = "Fecha Facturación"
    '
    'dteCreatedDate
    '
    Me.dteCreatedDate.EditValue = Nothing
    Me.dteCreatedDate.Location = New System.Drawing.Point(104, 81)
    Me.dteCreatedDate.MenuManager = Me.BarManager1
    Me.dteCreatedDate.Name = "dteCreatedDate"
    Me.dteCreatedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteCreatedDate.Properties.NullDate = New Date(CType(0, Long))
    Me.dteCreatedDate.Size = New System.Drawing.Size(113, 20)
    Me.dteCreatedDate.TabIndex = 20
    '
    'txtInvoiceID
    '
    Me.txtInvoiceID.AutoSize = True
    Me.txtInvoiceID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInvoiceID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.txtInvoiceID.Location = New System.Drawing.Point(466, 3)
    Me.txtInvoiceID.Name = "txtInvoiceID"
    Me.txtInvoiceID.Size = New System.Drawing.Size(56, 14)
    Me.txtInvoiceID.TabIndex = 19
    Me.txtInvoiceID.Text = "InvoiceID"
    '
    'txtInvoiceNo
    '
    Me.txtInvoiceNo.Location = New System.Drawing.Point(104, 32)
    Me.txtInvoiceNo.Name = "txtInvoiceNo"
    Me.txtInvoiceNo.Properties.MaxLength = 15
    Me.txtInvoiceNo.Size = New System.Drawing.Size(113, 20)
    Me.txtInvoiceNo.TabIndex = 0
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label12.Location = New System.Drawing.Point(33, 35)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(56, 14)
    Me.Label12.TabIndex = 18
    Me.Label12.Text = "# Factura"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label8.Location = New System.Drawing.Point(7, 84)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(91, 14)
    Me.Label8.TabIndex = 17
    Me.Label8.Text = "Fecha Creación"
    '
    'GroupControl2
    '
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl2.Controls.Add(Me.Label10)
    Me.GroupControl2.Controls.Add(Me.btneSelectSO)
    Me.GroupControl2.Controls.Add(Me.txtCustomerPurchaseOrder)
    Me.GroupControl2.Controls.Add(Me.Label9)
    Me.GroupControl2.Controls.Add(Me.txtCompanyName)
    Me.GroupControl2.Controls.Add(Me.Label7)
    Me.GroupControl2.Controls.Add(Me.Label6)
    Me.GroupControl2.Controls.Add(Me.txtProjectName)
    Me.GroupControl2.Controls.Add(Me.Label5)
    Me.GroupControl2.Controls.Add(Me.txtOrderNo)
    Me.GroupControl2.Location = New System.Drawing.Point(3, 39)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(443, 118)
    Me.GroupControl2.TabIndex = 9
    Me.GroupControl2.Text = "Detalles de Ventas"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label10.Location = New System.Drawing.Point(9, 32)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(74, 14)
    Me.Label10.TabIndex = 32
    Me.Label10.Text = "Selec. Venta"
    '
    'btneSelectSO
    '
    Me.btneSelectSO.Location = New System.Drawing.Point(89, 32)
    Me.btneSelectSO.MenuManager = Me.BarManager1
    Me.btneSelectSO.Name = "btneSelectSO"
    Me.btneSelectSO.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
    Me.btneSelectSO.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btneSelectSO.Properties.Appearance.Options.UseBackColor = True
    Me.btneSelectSO.Properties.Appearance.Options.UseFont = True
    Me.btneSelectSO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btneSelectSO.Size = New System.Drawing.Size(139, 20)
    Me.btneSelectSO.TabIndex = 19
    '
    'txtCustomerPurchaseOrder
    '
    Me.txtCustomerPurchaseOrder.Location = New System.Drawing.Point(330, 64)
    Me.txtCustomerPurchaseOrder.Name = "txtCustomerPurchaseOrder"
    Me.txtCustomerPurchaseOrder.Properties.MaxLength = 15
    Me.txtCustomerPurchaseOrder.Properties.ReadOnly = True
    Me.txtCustomerPurchaseOrder.Size = New System.Drawing.Size(97, 20)
    Me.txtCustomerPurchaseOrder.TabIndex = 31
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label9.Location = New System.Drawing.Point(241, 67)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(83, 14)
    Me.Label9.TabIndex = 30
    Me.Label9.Text = "Orden Cliente"
    '
    'txtCompanyName
    '
    Me.txtCompanyName.Location = New System.Drawing.Point(89, 93)
    Me.txtCompanyName.Name = "txtCompanyName"
    Me.txtCompanyName.Properties.MaxLength = 15
    Me.txtCompanyName.Properties.ReadOnly = True
    Me.txtCompanyName.Size = New System.Drawing.Size(338, 20)
    Me.txtCompanyName.TabIndex = 29
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label7.Location = New System.Drawing.Point(9, 99)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(46, 14)
    Me.Label7.TabIndex = 28
    Me.Label7.Text = "Cliente"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label6.Location = New System.Drawing.Point(9, 67)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(56, 14)
    Me.Label6.TabIndex = 27
    Me.Label6.Text = "Proyecto"
    '
    'txtProjectName
    '
    Me.txtProjectName.Location = New System.Drawing.Point(89, 64)
    Me.txtProjectName.Name = "txtProjectName"
    Me.txtProjectName.Properties.MaxLength = 15
    Me.txtProjectName.Properties.ReadOnly = True
    Me.txtProjectName.Size = New System.Drawing.Size(139, 20)
    Me.txtProjectName.TabIndex = 26
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label5.Location = New System.Drawing.Point(241, 35)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(37, 14)
    Me.Label5.TabIndex = 25
    Me.Label5.Text = "# Ref."
    '
    'txtOrderNo
    '
    Me.txtOrderNo.Location = New System.Drawing.Point(330, 29)
    Me.txtOrderNo.Name = "txtOrderNo"
    Me.txtOrderNo.Properties.MaxLength = 15
    Me.txtOrderNo.Properties.ReadOnly = True
    Me.txtOrderNo.Size = New System.Drawing.Size(97, 20)
    Me.txtOrderNo.TabIndex = 24
    '
    'gpSOI
    '
    Me.gpSOI.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpSOI.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.gpSOI.AppearanceCaption.Options.UseFont = True
    Me.gpSOI.AppearanceCaption.Options.UseForeColor = True
    Me.gpSOI.Controls.Add(Me.grdSOI)
    Me.gpSOI.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Agregar", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Add", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Delete", -1)})
    Me.gpSOI.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.gpSOI.Location = New System.Drawing.Point(3, 181)
    Me.gpSOI.Name = "gpSOI"
    Me.gpSOI.Size = New System.Drawing.Size(1152, 313)
    Me.gpSOI.TabIndex = 14
    Me.gpSOI.Text = "Detalles de Ítems de Facturación"
    '
    'grdSOI
    '
    Me.grdSOI.Location = New System.Drawing.Point(12, 26)
    Me.grdSOI.MainView = Me.gvSOI
    Me.grdSOI.MenuManager = Me.BarManager1
    Me.grdSOI.Name = "grdSOI"
    Me.grdSOI.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repocboSelectSOI})
    Me.grdSOI.Size = New System.Drawing.Size(1135, 271)
    Me.grdSOI.TabIndex = 0
    Me.grdSOI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSOI})
    '
    'gvSOI
    '
    Me.gvSOI.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvSOI.Appearance.FilterPanel.Options.UseFont = True
    Me.gvSOI.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvSOI.Appearance.FocusedCell.Options.UseFont = True
    Me.gvSOI.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvSOI.Appearance.FooterPanel.Options.UseFont = True
    Me.gvSOI.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvSOI.Appearance.GroupPanel.Options.UseFont = True
    Me.gvSOI.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvSOI.Appearance.GroupRow.Options.UseFont = True
    Me.gvSOI.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvSOI.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvSOI.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvSOI.Appearance.Row.Options.UseFont = True
    Me.gvSOI.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvSOI.Appearance.SelectedRow.Options.UseFont = True
    Me.gvSOI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcSalesItemID, Me.GridColumn3, Me.GridColumn4, Me.gcUnitPrice, Me.gcTotal})
    Me.gvSOI.GridControl = Me.grdSOI
    Me.gvSOI.Name = "gvSOI"
    Me.gvSOI.OptionsView.ShowFooter = True
    Me.gvSOI.OptionsView.ShowGroupPanel = False
    '
    'gcSalesItemID
    '
    Me.gcSalesItemID.Caption = "SalesItemID"
    Me.gcSalesItemID.ColumnEdit = Me.repocboSelectSOI
    Me.gcSalesItemID.FieldName = "SalesItemID"
    Me.gcSalesItemID.Name = "gcSalesItemID"
    Me.gcSalesItemID.Visible = True
    Me.gcSalesItemID.VisibleIndex = 0
    '
    'repocboSelectSOI
    '
    Me.repocboSelectSOI.AutoHeight = False
    Me.repocboSelectSOI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repocboSelectSOI.Name = "repocboSelectSOI"
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "InvoiceID"
    Me.GridColumn3.FieldName = "InvoiceID"
    Me.GridColumn3.Name = "GridColumn3"
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Cantidad"
    Me.GridColumn4.DisplayFormat.FormatString = "N2"
    Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn4.FieldName = "Quantity"
    Me.GridColumn4.GroupFormat.FormatString = "{0:#,##0.00;;#}"
    Me.GridColumn4.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#,##0.00;;#}")})
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    '
    'gcUnitPrice
    '
    Me.gcUnitPrice.Caption = "UnitPrice"
    Me.gcUnitPrice.DisplayFormat.FormatString = "$#,##0.00;;#"
    Me.gcUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcUnitPrice.FieldName = "uUnitPrice"
    Me.gcUnitPrice.GroupFormat.FormatString = "$#,##0.00;;#"
    Me.gcUnitPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcUnitPrice.Name = "gcUnitPrice"
    Me.gcUnitPrice.OptionsColumn.ReadOnly = True
    Me.gcUnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gcUnitPrice", "{$#,##0.00;;#}")})
    Me.gcUnitPrice.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcUnitPrice.Visible = True
    Me.gcUnitPrice.VisibleIndex = 2
    '
    'gcTotal
    '
    Me.gcTotal.Caption = "Total"
    Me.gcTotal.DisplayFormat.FormatString = "$#,##0.00;;#"
    Me.gcTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcTotal.FieldName = "ubTotal"
    Me.gcTotal.GroupFormat.FormatString = "{$#,##0.00;;#}"
    Me.gcTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.gcTotal.Name = "gcTotal"
    Me.gcTotal.OptionsColumn.ReadOnly = True
    Me.gcTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ubTotal", "{$#,##0.00;;#}")})
    Me.gcTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcTotal.Visible = True
    Me.gcTotal.VisibleIndex = 3
    '
    'frmInvoice
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1164, 521)
    Me.Controls.Add(Me.gpSOI)
    Me.Controls.Add(Me.GroupControl2)
    Me.Controls.Add(Me.GroupControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmInvoice"
    Me.Text = "Detalle de Facturas"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.cboInvoiceStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTaxValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNetValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteCreatedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dteCreatedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    Me.GroupControl2.PerformLayout()
    CType(Me.btneSelectSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomerPurchaseOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtOrderNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gpSOI, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gpSOI.ResumeLayout(False)
    CType(Me.grdSOI, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvSOI, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repocboSelectSOI, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents txtInvoiceNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label12 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents txtInvoiceID As Label
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents txtCustomerPurchaseOrder As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label9 As Label
  Friend WithEvents txtCompanyName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label5 As Label
  Friend WithEvents txtOrderNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents cboInvoiceStatus As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label4 As Label
  Friend WithEvents txtTaxValue As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label3 As Label
  Friend WithEvents txtNetValue As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label2 As Label
  Friend WithEvents dteInvoiceDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents Label1 As Label
  Friend WithEvents dteCreatedDate As DevExpress.XtraEditors.DateEdit
  Friend WithEvents gpSOI As DevExpress.XtraEditors.GroupControl
  Friend WithEvents Label10 As Label
  Friend WithEvents btneSelectSO As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents grdSOI As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSOI As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcSalesItemID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repocboSelectSOI As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents gcUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents bbtnGenerateInvoice As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents gcTotal As DevExpress.XtraGrid.Columns.GridColumn
End Class
