﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplierDetail))
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grdSupplierContact = New DevExpress.XtraGrid.GridControl()
        Me.gvSupplierContacts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbtnSavenAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.cboPurchaseTermsType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.cboPaymentTermsType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtABA = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.rgPrintAccountOption = New DevExpress.XtraEditors.RadioGroup()
        Me.txtAccountSecondaryNumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboBankName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSwift = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBancoIntermediario = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAcountRef = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSupplierReference = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rgEstatus = New DevExpress.XtraEditors.RadioGroup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtWebUrl = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRucNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustomerNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtCompanyName = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ckeIsBigTaxPayer = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeIsRetention = New DevExpress.XtraEditors.CheckEdit()
        Me.UctAddress1 = New AgroForestal.uctAddress()
        Me.rgDefaultCurrency = New DevExpress.XtraEditors.RadioGroup()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grdPOInfo = New DevExpress.XtraGrid.GridControl()
        Me.gvPOInfo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grdSupplierContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSupplierContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPurchaseTermsType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPaymentTermsType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.rgPrintAccountOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountSecondaryNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBankName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSwift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBancoIntermediario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcountRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgEstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ckeIsBigTaxPayer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeIsRetention.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgDefaultCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grdPOInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1419, 33)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 488)
        '
        'grdSupplierContact
        '
        Me.grdSupplierContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdSupplierContact.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdSupplierContact.Location = New System.Drawing.Point(12, 342)
        Me.grdSupplierContact.MainView = Me.gvSupplierContacts
        Me.grdSupplierContact.MenuManager = Me.BarManager2
        Me.grdSupplierContact.Name = "grdSupplierContact"
        Me.grdSupplierContact.Size = New System.Drawing.Size(1402, 167)
        Me.grdSupplierContact.TabIndex = 10
        Me.grdSupplierContact.UseEmbeddedNavigator = True
        Me.grdSupplierContact.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSupplierContacts})
        '
        'gvSupplierContacts
        '
        Me.gvSupplierContacts.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSupplierContacts.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSupplierContacts.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSupplierContacts.Appearance.Row.Options.UseFont = True
        Me.gvSupplierContacts.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSupplierContacts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon
        Me.gvSupplierContacts.Appearance.ViewCaption.Options.UseFont = True
        Me.gvSupplierContacts.Appearance.ViewCaption.Options.UseForeColor = True
        Me.gvSupplierContacts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvSupplierContacts.GridControl = Me.grdSupplierContact
        Me.gvSupplierContacts.Name = "gvSupplierContacts"
        Me.gvSupplierContacts.OptionsView.ShowGroupPanel = False
        Me.gvSupplierContacts.OptionsView.ShowViewCaption = True
        Me.gvSupplierContacts.ViewCaption = "Contactos"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nombre"
        Me.GridColumn6.FieldName = "FirstName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Apellido"
        Me.GridColumn7.FieldName = "LastName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tel."
        Me.GridColumn8.FieldName = "TelNo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "EMail"
        Me.GridColumn9.FieldName = "Email"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cel."
        Me.GridColumn10.FieldName = "Mobile"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.DockControls.Add(Me.BarDockControl5)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btSave, Me.btnClose, Me.bbtnSavenAndClose})
        Me.BarManager2.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSavenAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.btSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
        Me.Bar2.Text = "Herramientas"
        '
        'bbtnSavenAndClose
        '
        Me.bbtnSavenAndClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnSavenAndClose.Caption = "Guardar y Cerrar"
        Me.bbtnSavenAndClose.Id = 2
        Me.bbtnSavenAndClose.Name = "bbtnSavenAndClose"
        '
        'btSave
        '
        Me.btSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btSave.Caption = "Guardar"
        Me.btSave.Id = 0
        Me.btSave.Name = "btSave"
        '
        'btnClose
        '
        Me.btnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnClose.Caption = "Cerrar"
        Me.btnClose.Id = 1
        Me.btnClose.Name = "btnClose"
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1419, 33)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 521)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(1419, 0)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl4.Location = New System.Drawing.Point(0, 33)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 488)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl5.Location = New System.Drawing.Point(1419, 33)
        Me.BarDockControl5.Manager = Me.BarManager2
        Me.BarDockControl5.Size = New System.Drawing.Size(0, 488)
        '
        'cboPurchaseTermsType
        '
        Me.cboPurchaseTermsType.Location = New System.Drawing.Point(357, 55)
        Me.cboPurchaseTermsType.MenuManager = Me.BarManager2
        Me.cboPurchaseTermsType.Name = "cboPurchaseTermsType"
        Me.cboPurchaseTermsType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPurchaseTermsType.Size = New System.Drawing.Size(136, 20)
        Me.cboPurchaseTermsType.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(263, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 14)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Térm. Compras"
        '
        'lblSupplierID
        '
        Me.lblSupplierID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplierID.AutoSize = True
        Me.lblSupplierID.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplierID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSupplierID.Location = New System.Drawing.Point(668, 3)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(47, 14)
        Me.lblSupplierID.TabIndex = 19
        Me.lblSupplierID.Text = "ID: 0000"
        Me.lblSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPaymentTermsType
        '
        Me.cboPaymentTermsType.Location = New System.Drawing.Point(357, 29)
        Me.cboPaymentTermsType.MenuManager = Me.BarManager2
        Me.cboPaymentTermsType.Name = "cboPaymentTermsType"
        Me.cboPaymentTermsType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPaymentTermsType.Size = New System.Drawing.Size(136, 20)
        Me.cboPaymentTermsType.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(261, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 14)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Térm. Pago"
        '
        'txtABA
        '
        Me.txtABA.Location = New System.Drawing.Point(575, 31)
        Me.txtABA.Name = "txtABA"
        Me.txtABA.Properties.MaxLength = 15
        Me.txtABA.Size = New System.Drawing.Size(150, 20)
        Me.txtABA.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(499, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 14)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Código ABA"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.rgPrintAccountOption)
        Me.GroupControl2.Controls.Add(Me.txtAccountSecondaryNumber)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.cboBankName)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.cboPurchaseTermsType)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.lblSupplierID)
        Me.GroupControl2.Controls.Add(Me.cboPaymentTermsType)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.txtABA)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.txtSwift)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.txtBancoIntermediario)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.txtAcountRef)
        Me.GroupControl2.Controls.Add(Me.Label20)
        Me.GroupControl2.Location = New System.Drawing.Point(684, 36)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(730, 114)
        Me.GroupControl2.TabIndex = 9
        Me.GroupControl2.Text = "Detalles de la Cuenta"
        '
        'rgPrintAccountOption
        '
        Me.rgPrintAccountOption.Location = New System.Drawing.Point(512, 83)
        Me.rgPrintAccountOption.Name = "rgPrintAccountOption"
        Me.rgPrintAccountOption.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgPrintAccountOption.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rgPrintAccountOption.Properties.Appearance.Options.UseBackColor = True
        Me.rgPrintAccountOption.Properties.Appearance.Options.UseFont = True
        Me.rgPrintAccountOption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Cuenta Pred."), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Cuenta Sec.")})
        Me.rgPrintAccountOption.Size = New System.Drawing.Size(218, 25)
        Me.rgPrintAccountOption.TabIndex = 37
        '
        'txtAccountSecondaryNumber
        '
        Me.txtAccountSecondaryNumber.Location = New System.Drawing.Point(119, 55)
        Me.txtAccountSecondaryNumber.Name = "txtAccountSecondaryNumber"
        Me.txtAccountSecondaryNumber.Properties.MaxLength = 25
        Me.txtAccountSecondaryNumber.Size = New System.Drawing.Size(136, 20)
        Me.txtAccountSecondaryNumber.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 14)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Núm. Cuenta Sec."
        '
        'cboBankName
        '
        Me.cboBankName.Location = New System.Drawing.Point(575, 57)
        Me.cboBankName.MenuManager = Me.BarManager2
        Me.cboBankName.Name = "cboBankName"
        Me.cboBankName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBankName.Properties.Items.AddRange(New Object() {"BAC", "BANCENTRO", "BANPRO", "BDF", "FICOSA", "LAFISE", "INTERBANCO GUATEMALA"})
        Me.cboBankName.Size = New System.Drawing.Size(150, 20)
        Me.cboBankName.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(534, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Banco"
        '
        'txtSwift
        '
        Me.txtSwift.Location = New System.Drawing.Point(357, 86)
        Me.txtSwift.Name = "txtSwift"
        Me.txtSwift.Properties.MaxLength = 15
        Me.txtSwift.Size = New System.Drawing.Size(136, 20)
        Me.txtSwift.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(263, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 14)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Código SWIFT"
        '
        'txtBancoIntermediario
        '
        Me.txtBancoIntermediario.Location = New System.Drawing.Point(119, 86)
        Me.txtBancoIntermediario.Name = "txtBancoIntermediario"
        Me.txtBancoIntermediario.Properties.MaxLength = 100
        Me.txtBancoIntermediario.Size = New System.Drawing.Size(136, 20)
        Me.txtBancoIntermediario.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(4, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 14)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Banco Intermediario"
        '
        'txtAcountRef
        '
        Me.txtAcountRef.Location = New System.Drawing.Point(119, 29)
        Me.txtAcountRef.Name = "txtAcountRef"
        Me.txtAcountRef.Properties.MaxLength = 25
        Me.txtAcountRef.Size = New System.Drawing.Size(136, 20)
        Me.txtAcountRef.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(4, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Núm. Cuenta Pred."
        '
        'txtSupplierReference
        '
        Me.txtSupplierReference.Location = New System.Drawing.Point(141, 27)
        Me.txtSupplierReference.Name = "txtSupplierReference"
        Me.txtSupplierReference.Properties.MaxLength = 15
        Me.txtSupplierReference.Size = New System.Drawing.Size(155, 20)
        Me.txtSupplierReference.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(5, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "# Referencia"
        '
        'rgEstatus
        '
        Me.rgEstatus.Location = New System.Drawing.Point(141, 210)
        Me.rgEstatus.MenuManager = Me.BarManager2
        Me.rgEstatus.Name = "rgEstatus"
        Me.rgEstatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.rgEstatus.Properties.Appearance.Options.UseBackColor = True
        Me.rgEstatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Activo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Inactivo")})
        Me.rgEstatus.Size = New System.Drawing.Size(155, 31)
        Me.rgEstatus.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(5, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Estado"
        '
        'txtWebUrl
        '
        Me.txtWebUrl.Location = New System.Drawing.Point(141, 183)
        Me.txtWebUrl.Name = "txtWebUrl"
        Me.txtWebUrl.Properties.MaxLength = 64
        Me.txtWebUrl.Size = New System.Drawing.Size(155, 20)
        Me.txtWebUrl.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(5, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 14)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Página Web"
        '
        'txtRucNumber
        '
        Me.txtRucNumber.Location = New System.Drawing.Point(141, 105)
        Me.txtRucNumber.Name = "txtRucNumber"
        Me.txtRucNumber.Size = New System.Drawing.Size(155, 20)
        Me.txtRucNumber.TabIndex = 3
        '
        'txtCustomerNotes
        '
        Me.txtCustomerNotes.Location = New System.Drawing.Point(5, 26)
        Me.txtCustomerNotes.MenuManager = Me.BarManager2
        Me.txtCustomerNotes.Name = "txtCustomerNotes"
        Me.txtCustomerNotes.Size = New System.Drawing.Size(331, 72)
        Me.txtCustomerNotes.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.txtCustomerNotes)
        Me.GroupControl3.Location = New System.Drawing.Point(305, 183)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(341, 112)
        Me.GroupControl3.TabIndex = 11
        Me.GroupControl3.Text = "Notas del Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Número RUC/NIT"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(141, 79)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(155, 20)
        Me.txtRazonSocial.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Razón Social"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(141, 157)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.MaxLength = 64
        Me.txtEmail.Size = New System.Drawing.Size(155, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(141, 53)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Properties.MaxLength = 64
        Me.txtCompanyName.Size = New System.Drawing.Size(155, 20)
        Me.txtCompanyName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email"
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(141, 131)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Properties.MaxLength = 32
        Me.txtTelNo.Size = New System.Drawing.Size(155, 20)
        Me.txtTelNo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre de Compañía"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.ckeIsBigTaxPayer)
        Me.GroupControl1.Controls.Add(Me.ckeIsRetention)
        Me.GroupControl1.Controls.Add(Me.UctAddress1)
        Me.GroupControl1.Controls.Add(Me.rgDefaultCurrency)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Controls.Add(Me.txtSupplierReference)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.rgEstatus)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txtWebUrl)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txtRucNumber)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txtRazonSocial)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtTelNo)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txtCompanyName)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 36)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(657, 300)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "Detalles del Proveedor"
        '
        'ckeIsBigTaxPayer
        '
        Me.ckeIsBigTaxPayer.Location = New System.Drawing.Point(141, 252)
        Me.ckeIsBigTaxPayer.MenuManager = Me.BarManager2
        Me.ckeIsBigTaxPayer.Name = "ckeIsBigTaxPayer"
        Me.ckeIsBigTaxPayer.Properties.Caption = "Grande Contribuyente?"
        Me.ckeIsBigTaxPayer.Size = New System.Drawing.Size(110, 19)
        Me.ckeIsBigTaxPayer.TabIndex = 29
        '
        'ckeIsRetention
        '
        Me.ckeIsRetention.Location = New System.Drawing.Point(8, 252)
        Me.ckeIsRetention.MenuManager = Me.BarManager2
        Me.ckeIsRetention.Name = "ckeIsRetention"
        Me.ckeIsRetention.Properties.Caption = "Con Retención"
        Me.ckeIsRetention.Size = New System.Drawing.Size(110, 19)
        Me.ckeIsRetention.TabIndex = 28
        '
        'UctAddress1
        '
        Me.UctAddress1.Address = Nothing
        Me.UctAddress1.ControlsReadOnly = False
        Me.UctAddress1.Location = New System.Drawing.Point(302, 26)
        Me.UctAddress1.MainLabel = Nothing
        Me.UctAddress1.Name = "UctAddress1"
        Me.UctAddress1.Size = New System.Drawing.Size(344, 104)
        Me.UctAddress1.TabIndex = 26
        Me.UctAddress1.ThirdAddressLine = False
        '
        'rgDefaultCurrency
        '
        Me.rgDefaultCurrency.Location = New System.Drawing.Point(359, 138)
        Me.rgDefaultCurrency.MenuManager = Me.BarManager2
        Me.rgDefaultCurrency.Name = "rgDefaultCurrency"
        Me.rgDefaultCurrency.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgDefaultCurrency.Properties.Appearance.Options.UseBackColor = True
        Me.rgDefaultCurrency.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "USD"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "C$")})
        Me.rgDefaultCurrency.Size = New System.Drawing.Size(287, 31)
        Me.rgDefaultCurrency.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(302, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 14)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Moneda"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.grdPOInfo)
        Me.GroupControl4.Location = New System.Drawing.Point(684, 156)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(730, 180)
        Me.GroupControl4.TabIndex = 21
        Me.GroupControl4.Text = "Ordenes de Compras: Activas y Recientes"
        '
        'grdPOInfo
        '
        Me.grdPOInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPOInfo.Location = New System.Drawing.Point(2, 23)
        Me.grdPOInfo.MainView = Me.gvPOInfo
        Me.grdPOInfo.Name = "grdPOInfo"
        Me.grdPOInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdPOInfo.Size = New System.Drawing.Size(726, 155)
        Me.grdPOInfo.TabIndex = 0
        Me.grdPOInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOInfo})
        '
        'gvPOInfo
        '
        Me.gvPOInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvPOInfo.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOInfo.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPOInfo.Appearance.EvenRow.Options.UseFont = True
        Me.gvPOInfo.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvPOInfo.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPOInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPOInfo.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvPOInfo.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPOInfo.Appearance.OddRow.Options.UseFont = True
        Me.gvPOInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.gvPOInfo.GridControl = Me.grdPOInfo
        Me.gvPOInfo.Name = "gvPOInfo"
        Me.gvPOInfo.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPOInfo.OptionsView.EnableAppearanceOddRow = True
        Me.gvPOInfo.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "#O.C."
        Me.GridColumn1.FieldName = "PONum"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 110
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Categoría"
        Me.GridColumn2.FieldName = "Category"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 124
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ID"
        Me.GridColumn3.FieldName = "PurchaseOrderID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Estado"
        Me.GridColumn4.FieldName = "Status"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 130
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Requerida"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn5.FieldName = "RequiredDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 169
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(CType(0, Long))
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Valor Neto"
        Me.GridColumn11.DisplayFormat.FormatString = "c2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "TotalNetValue"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 6
        Me.GridColumn11.Width = 225
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Ref"
        Me.GridColumn12.FieldName = "SupplierRef"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 155
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Estado del Pago"
        Me.GridColumn13.FieldName = "PaymentStatus"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 152
        '
        'frmSupplierDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1419, 521)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.grdSupplierContact)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSupplierDetail"
        Me.Text = "Detalles de Proveedor"
        CType(Me.grdSupplierContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSupplierContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPurchaseTermsType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPaymentTermsType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.rgPrintAccountOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountSecondaryNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBankName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSwift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBancoIntermediario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcountRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgEstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ckeIsBigTaxPayer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeIsRetention.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgDefaultCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grdPOInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdSupplierContact As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvSupplierContacts As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnSavenAndClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btSave As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents cboPurchaseTermsType As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label10 As Label
  Friend WithEvents lblSupplierID As Label
  Friend WithEvents cboPaymentTermsType As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label13 As Label
  Friend WithEvents txtABA As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label14 As Label
  Friend WithEvents txtSwift As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label16 As Label
  Friend WithEvents txtBancoIntermediario As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label17 As Label
  Friend WithEvents txtAcountRef As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label20 As Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCustomerNotes As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents txtSupplierReference As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label12 As Label
    Friend WithEvents rgEstatus As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label11 As Label
    Friend WithEvents txtWebUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRucNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRazonSocial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCompanyName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents rgDefaultCurrency As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label15 As Label
    Friend WithEvents UctAddress1 As uctAddress
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPOInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPOInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBankName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAccountSecondaryNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents rgPrintAccountOption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ckeIsRetention As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeIsBigTaxPayer As DevExpress.XtraEditors.CheckEdit
End Class
