<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.RadioGroup2 = New DevExpress.XtraEditors.RadioGroup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWebUrl = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMainAddress1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SalesAreaID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRucNumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gvContacts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdContacts = New DevExpress.XtraGrid.GridControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtABA = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSwift = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBancoIntermediario = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAcountRef = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RadioGroup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainAddress1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAreaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtABA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSwift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBancoIntermediario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcountRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(148, 32)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(230, 20)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1344, 33)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 729)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1344, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 696)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1344, 33)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 696)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 35)
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
        Me.GroupControl1.Controls.Add(Me.RadioGroup2)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.RadioGroup1)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txtWebUrl)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txtMainAddress1)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.SalesAreaID)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txtRucNumber)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txtRazonSocial)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtTelNo)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txtCustomerName)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 39)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(791, 249)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Detalles del Cliente"
        '
        'RadioGroup2
        '
        Me.RadioGroup2.Location = New System.Drawing.Point(549, 198)
        Me.RadioGroup2.MenuManager = Me.BarManager1
        Me.RadioGroup2.Name = "RadioGroup2"
        Me.RadioGroup2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.RadioGroup2.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Activo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Desactivado")})
        Me.RadioGroup2.Size = New System.Drawing.Size(230, 31)
        Me.RadioGroup2.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(466, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 14)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Estado"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(549, 153)
        Me.RadioGroup1.MenuManager = Me.BarManager1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Aplica"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "No Aplica")})
        Me.RadioGroup1.Size = New System.Drawing.Size(230, 31)
        Me.RadioGroup1.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(466, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 14)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "IVA"
        '
        'txtWebUrl
        '
        Me.txtWebUrl.Location = New System.Drawing.Point(549, 116)
        Me.txtWebUrl.Name = "txtWebUrl"
        Me.txtWebUrl.Size = New System.Drawing.Size(230, 20)
        Me.txtWebUrl.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(466, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 14)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Página Web"
        '
        'txtMainAddress1
        '
        Me.txtMainAddress1.Location = New System.Drawing.Point(148, 200)
        Me.txtMainAddress1.Name = "txtMainAddress1"
        Me.txtMainAddress1.Size = New System.Drawing.Size(230, 20)
        Me.txtMainAddress1.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Dirección principal"
        '
        'SalesAreaID
        '
        Me.SalesAreaID.Location = New System.Drawing.Point(148, 155)
        Me.SalesAreaID.MenuManager = Me.BarManager1
        Me.SalesAreaID.Name = "SalesAreaID"
        Me.SalesAreaID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SalesAreaID.Size = New System.Drawing.Size(230, 20)
        Me.SalesAreaID.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 14)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "País de Origen"
        '
        'txtRucNumber
        '
        Me.txtRucNumber.Location = New System.Drawing.Point(148, 116)
        Me.txtRucNumber.Name = "txtRucNumber"
        Me.txtRucNumber.Size = New System.Drawing.Size(230, 20)
        Me.txtRucNumber.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Número RUC/NIT"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(148, 74)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(230, 20)
        Me.txtRazonSocial.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Razón Social"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(549, 74)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 20)
        Me.txtEmail.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(466, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Email"
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(549, 32)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(230, 20)
        Me.txtTelNo.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(466, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Teléfono"
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
        Me.grdContacts.Location = New System.Drawing.Point(12, 329)
        Me.grdContacts.MainView = Me.gvContacts
        Me.grdContacts.MenuManager = Me.BarManager1
        Me.grdContacts.Name = "grdContacts"
        Me.grdContacts.Size = New System.Drawing.Size(1320, 200)
        Me.grdContacts.TabIndex = 10
        Me.grdContacts.UseEmbeddedNavigator = True
        Me.grdContacts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContacts})
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txtABA)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.txtSwift)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.txtBancoIntermediario)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.txtAcountRef)
        Me.GroupControl2.Controls.Add(Me.Label20)
        Me.GroupControl2.Location = New System.Drawing.Point(834, 39)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(498, 249)
        Me.GroupControl2.TabIndex = 29
        Me.GroupControl2.Text = "Detalles de la Cuenta"
        '
        'txtABA
        '
        Me.txtABA.Location = New System.Drawing.Point(148, 149)
        Me.txtABA.Name = "txtABA"
        Me.txtABA.Size = New System.Drawing.Size(230, 20)
        Me.txtABA.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 14)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Código ABA"
        '
        'txtSwift
        '
        Me.txtSwift.Location = New System.Drawing.Point(148, 110)
        Me.txtSwift.Name = "txtSwift"
        Me.txtSwift.Size = New System.Drawing.Size(230, 20)
        Me.txtSwift.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(16, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 14)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Código SWIFT"
        '
        'txtBancoIntermediario
        '
        Me.txtBancoIntermediario.Location = New System.Drawing.Point(148, 71)
        Me.txtBancoIntermediario.Name = "txtBancoIntermediario"
        Me.txtBancoIntermediario.Size = New System.Drawing.Size(230, 20)
        Me.txtBancoIntermediario.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(16, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 14)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Banco Intermediario"
        '
        'txtAcountRef
        '
        Me.txtAcountRef.Location = New System.Drawing.Point(148, 32)
        Me.txtAcountRef.Name = "txtAcountRef"
        Me.txtAcountRef.Size = New System.Drawing.Size(230, 20)
        Me.txtAcountRef.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(16, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Número de Cuenta"
        '
        'frmCustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grdContacts)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.Name = "frmCustomerDetail"
        Me.Text = "Detalles de Cliente"
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.RadioGroup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainAddress1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAreaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtABA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSwift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBancoIntermediario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcountRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtRazonSocial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents grdContacts As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvContacts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWebUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMainAddress1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents SalesAreaID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRucNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtABA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSwift As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBancoIntermediario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As Label
    Friend WithEvents txtAcountRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As Label
    Friend WithEvents RadioGroup2 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
End Class
