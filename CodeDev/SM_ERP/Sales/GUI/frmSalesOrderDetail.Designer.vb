﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
    Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.cboContractManagerID = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
    Me.txtShippingCost = New DevExpress.XtraEditors.TextEdit()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.cboSalesDelAreaID = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.cboCustomerDelContacID = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.txtDelAddress2 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDelAddress1 = New DevExpress.XtraEditors.TextEdit()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.btneSalesOrderDocument = New DevExpress.XtraEditors.ButtonEdit()
    Me.lblSalesOrderID = New System.Windows.Forms.Label()
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.txtCustomerContact = New DevExpress.XtraEditors.TextEdit()
    Me.Label20 = New System.Windows.Forms.Label()
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
    Me.grpOrderItem = New DevExpress.XtraEditors.GroupControl()
    Me.grdOrderItem = New DevExpress.XtraGrid.GridControl()
    Me.gvOrderItem = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.gcQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcWoodSpecie = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.gcWoodFinish = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.grpWorkOrders = New DevExpress.XtraEditors.GroupControl()
    Me.grdWorkOrders = New DevExpress.XtraGrid.GridControl()
    Me.gvWorkOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcWOSOItemNumber = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repitbtWorkOrder = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
    Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.cboContractManagerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl3.SuspendLayout()
    CType(Me.txtShippingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboSalesDelAreaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cboCustomerDelContacID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDelAddress2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDelAddress1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.btneSalesOrderDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.txtCustomerContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
    CType(Me.grpOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpOrderItem.SuspendLayout()
    CType(Me.grdOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grpWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpWorkOrders.SuspendLayout()
    CType(Me.grdWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repitbtWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSave, Me.btnClose, Me.btnSaveAndClose})
    Me.BarManager1.MaxItemId = 3
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
    Me.Bar1.Text = "Tools"
    '
    'btnSaveAndClose
    '
    Me.btnSaveAndClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.btnSaveAndClose.Caption = "Guardar y Cerrar"
    Me.btnSaveAndClose.Id = 2
    Me.btnSaveAndClose.Name = "btnSaveAndClose"
    '
    'bbtnSave
    '
    Me.bbtnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnSave.Caption = "Guardar"
    Me.bbtnSave.Id = 0
    Me.bbtnSave.Name = "bbtnSave"
    '
    'btnClose
    '
    Me.btnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.btnClose.Caption = "Cerrar"
    Me.btnClose.Id = 1
    Me.btnClose.Name = "btnClose"
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
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 729)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1164, 0)
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
    Me.barDockControlRight.Location = New System.Drawing.Point(1164, 33)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 696)
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.GroupControl1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 33)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1164, 696)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'GroupControl1
    '
    Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.GroupControl1.AppearanceCaption.Options.UseFont = True
    Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
    Me.GroupControl1.Controls.Add(Me.cboContractManagerID)
    Me.GroupControl1.Controls.Add(Me.Label19)
    Me.GroupControl1.Controls.Add(Me.GroupControl3)
    Me.GroupControl1.Controls.Add(Me.Label15)
    Me.GroupControl1.Controls.Add(Me.btneSalesOrderDocument)
    Me.GroupControl1.Controls.Add(Me.lblSalesOrderID)
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
    Me.GroupControl1.Size = New System.Drawing.Size(1149, 298)
    Me.GroupControl1.TabIndex = 0
    Me.GroupControl1.Text = "Detalles Generales"
    '
    'cboContractManagerID
    '
    Me.cboContractManagerID.Location = New System.Drawing.Point(131, 242)
    Me.cboContractManagerID.MenuManager = Me.BarManager1
    Me.cboContractManagerID.Name = "cboContractManagerID"
    Me.cboContractManagerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboContractManagerID.Size = New System.Drawing.Size(130, 20)
    Me.cboContractManagerID.TabIndex = 8
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label19.Location = New System.Drawing.Point(9, 245)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(70, 14)
    Me.Label19.TabIndex = 39
    Me.Label19.Tag = "c"
    Me.Label19.Text = "Enc. Ventas"
    '
    'GroupControl3
    '
    Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl3.AppearanceCaption.Options.UseFont = True
    Me.GroupControl3.Controls.Add(Me.txtShippingCost)
    Me.GroupControl3.Controls.Add(Me.Label22)
    Me.GroupControl3.Controls.Add(Me.cboSalesDelAreaID)
    Me.GroupControl3.Controls.Add(Me.cboCustomerDelContacID)
    Me.GroupControl3.Controls.Add(Me.Label18)
    Me.GroupControl3.Controls.Add(Me.txtDelAddress2)
    Me.GroupControl3.Controls.Add(Me.txtDelAddress1)
    Me.GroupControl3.Controls.Add(Me.Label17)
    Me.GroupControl3.Controls.Add(Me.Label16)
    Me.GroupControl3.Controls.Add(Me.Label21)
    Me.GroupControl3.Location = New System.Drawing.Point(578, 28)
    Me.GroupControl3.Name = "GroupControl3"
    Me.GroupControl3.Size = New System.Drawing.Size(241, 265)
    Me.GroupControl3.TabIndex = 11
    Me.GroupControl3.Text = "Detalles de Envio del Cliente"
    '
    'txtShippingCost
    '
    Me.txtShippingCost.EditValue = ""
    Me.txtShippingCost.Location = New System.Drawing.Point(102, 198)
    Me.txtShippingCost.MenuManager = Me.BarManager1
    Me.txtShippingCost.Name = "txtShippingCost"
    Me.txtShippingCost.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtShippingCost.Properties.Appearance.Options.UseFont = True
    Me.txtShippingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtShippingCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtShippingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtShippingCost.Properties.MaxLength = 15
    Me.txtShippingCost.Size = New System.Drawing.Size(130, 20)
    Me.txtShippingCost.TabIndex = 17
    Me.txtShippingCost.Tag = "c"
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label22.Location = New System.Drawing.Point(7, 201)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(72, 14)
    Me.Label22.TabIndex = 18
    Me.Label22.Tag = "c"
    Me.Label22.Text = "Costo Envío"
    '
    'cboSalesDelAreaID
    '
    Me.cboSalesDelAreaID.Location = New System.Drawing.Point(102, 157)
    Me.cboSalesDelAreaID.MenuManager = Me.BarManager1
    Me.cboSalesDelAreaID.Name = "cboSalesDelAreaID"
    Me.cboSalesDelAreaID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboSalesDelAreaID.Size = New System.Drawing.Size(130, 20)
    Me.cboSalesDelAreaID.TabIndex = 4
    '
    'cboCustomerDelContacID
    '
    Me.cboCustomerDelContacID.Location = New System.Drawing.Point(102, 34)
    Me.cboCustomerDelContacID.MenuManager = Me.BarManager1
    Me.cboCustomerDelContacID.Name = "cboCustomerDelContacID"
    Me.cboCustomerDelContacID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboCustomerDelContacID.Size = New System.Drawing.Size(130, 20)
    Me.cboCustomerDelContacID.TabIndex = 1
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label18.Location = New System.Drawing.Point(7, 37)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(56, 14)
    Me.Label18.TabIndex = 16
    Me.Label18.Tag = "c"
    Me.Label18.Text = "Contacto"
    '
    'txtDelAddress2
    '
    Me.txtDelAddress2.Location = New System.Drawing.Point(102, 116)
    Me.txtDelAddress2.MenuManager = Me.BarManager1
    Me.txtDelAddress2.Name = "txtDelAddress2"
    Me.txtDelAddress2.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDelAddress2.Properties.Appearance.Options.UseFont = True
    Me.txtDelAddress2.Size = New System.Drawing.Size(130, 20)
    Me.txtDelAddress2.TabIndex = 3
    Me.txtDelAddress2.Tag = "c"
    '
    'txtDelAddress1
    '
    Me.txtDelAddress1.Location = New System.Drawing.Point(102, 75)
    Me.txtDelAddress1.MenuManager = Me.BarManager1
    Me.txtDelAddress1.Name = "txtDelAddress1"
    Me.txtDelAddress1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDelAddress1.Properties.Appearance.Options.UseFont = True
    Me.txtDelAddress1.Size = New System.Drawing.Size(130, 20)
    Me.txtDelAddress1.TabIndex = 2
    Me.txtDelAddress1.Tag = "c"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label17.Location = New System.Drawing.Point(7, 119)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(45, 14)
    Me.Label17.TabIndex = 4
    Me.Label17.Tag = "c"
    Me.Label17.Text = "Ciudad"
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label16.Location = New System.Drawing.Point(7, 78)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(58, 14)
    Me.Label16.TabIndex = 14
    Me.Label16.Tag = "c"
    Me.Label16.Text = "Dirección"
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label21.Location = New System.Drawing.Point(7, 160)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(30, 14)
    Me.Label21.TabIndex = 2
    Me.Label21.Tag = "c"
    Me.Label21.Text = "País"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label15.Location = New System.Drawing.Point(9, 275)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(78, 14)
    Me.Label15.TabIndex = 16
    Me.Label15.Tag = "c"
    Me.Label15.Text = "Generar Doc."
    '
    'btneSalesOrderDocument
    '
    Me.btneSalesOrderDocument.Location = New System.Drawing.Point(131, 272)
    Me.btneSalesOrderDocument.MenuManager = Me.BarManager1
    Me.btneSalesOrderDocument.Name = "btneSalesOrderDocument"
    Me.btneSalesOrderDocument.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
    Me.btneSalesOrderDocument.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btneSalesOrderDocument.Properties.Appearance.Options.UseBackColor = True
    Me.btneSalesOrderDocument.Properties.Appearance.Options.UseFont = True
    Me.btneSalesOrderDocument.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
    Me.btneSalesOrderDocument.Size = New System.Drawing.Size(130, 20)
    Me.btneSalesOrderDocument.TabIndex = 9
    '
    'lblSalesOrderID
    '
    Me.lblSalesOrderID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblSalesOrderID.AutoSize = True
    Me.lblSalesOrderID.BackColor = System.Drawing.Color.Transparent
    Me.lblSalesOrderID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSalesOrderID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.lblSalesOrderID.Location = New System.Drawing.Point(1078, 0)
    Me.lblSalesOrderID.Name = "lblSalesOrderID"
    Me.lblSalesOrderID.Size = New System.Drawing.Size(44, 14)
    Me.lblSalesOrderID.TabIndex = 37
    Me.lblSalesOrderID.Tag = "c"
    Me.lblSalesOrderID.Text = "ID:0000"
    Me.lblSalesOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'GroupControl2
    '
    Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupControl2.AppearanceCaption.Options.UseFont = True
    Me.GroupControl2.Controls.Add(Me.txtCustomerContact)
    Me.GroupControl2.Controls.Add(Me.Label20)
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
    Me.GroupControl2.Location = New System.Drawing.Point(293, 28)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(270, 265)
    Me.GroupControl2.TabIndex = 10
    Me.GroupControl2.Text = "Detalles de Facturación del Cliente"
    '
    'txtCustomerContact
    '
    Me.txtCustomerContact.Location = New System.Drawing.Point(102, 232)
    Me.txtCustomerContact.MenuManager = Me.BarManager1
    Me.txtCustomerContact.Name = "txtCustomerContact"
    Me.txtCustomerContact.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCustomerContact.Properties.Appearance.Options.UseFont = True
    Me.txtCustomerContact.Properties.ReadOnly = True
    Me.txtCustomerContact.Size = New System.Drawing.Size(130, 20)
    Me.txtCustomerContact.TabIndex = 7
    Me.txtCustomerContact.Tag = "c"
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label20.Location = New System.Drawing.Point(9, 235)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(56, 14)
    Me.Label20.TabIndex = 18
    Me.Label20.Tag = "c"
    Me.Label20.Text = "Contacto"
    '
    'txtMainTown
    '
    Me.txtMainTown.Location = New System.Drawing.Point(102, 96)
    Me.txtMainTown.MenuManager = Me.BarManager1
    Me.txtMainTown.Name = "txtMainTown"
    Me.txtMainTown.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMainTown.Properties.Appearance.Options.UseFont = True
    Me.txtMainTown.Properties.ReadOnly = True
    Me.txtMainTown.Size = New System.Drawing.Size(130, 20)
    Me.txtMainTown.TabIndex = 3
    Me.txtMainTown.Tag = "c"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label14.Location = New System.Drawing.Point(9, 99)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(45, 14)
    Me.Label14.TabIndex = 4
    Me.Label14.Tag = "c"
    Me.Label14.Text = "Ciudad"
    '
    'txtPaymentTermsType
    '
    Me.txtPaymentTermsType.Location = New System.Drawing.Point(102, 130)
    Me.txtPaymentTermsType.MenuManager = Me.BarManager1
    Me.txtPaymentTermsType.Name = "txtPaymentTermsType"
    Me.txtPaymentTermsType.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPaymentTermsType.Properties.Appearance.Options.UseFont = True
    Me.txtPaymentTermsType.Properties.ReadOnly = True
    Me.txtPaymentTermsType.Size = New System.Drawing.Size(130, 20)
    Me.txtPaymentTermsType.TabIndex = 4
    Me.txtPaymentTermsType.Tag = "c"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label13.Location = New System.Drawing.Point(9, 133)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(87, 14)
    Me.Label13.TabIndex = 6
    Me.Label13.Tag = "c"
    Me.Label13.Text = "Térm. de Pago"
    '
    'CustomerStatusID
    '
    Me.CustomerStatusID.Location = New System.Drawing.Point(102, 198)
    Me.CustomerStatusID.MenuManager = Me.BarManager1
    Me.CustomerStatusID.Name = "CustomerStatusID"
    Me.CustomerStatusID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CustomerStatusID.Properties.Appearance.Options.UseFont = True
    Me.CustomerStatusID.Properties.ReadOnly = True
    Me.CustomerStatusID.Size = New System.Drawing.Size(130, 20)
    Me.CustomerStatusID.TabIndex = 6
    Me.CustomerStatusID.Tag = "c"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label12.Location = New System.Drawing.Point(9, 201)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(48, 14)
    Me.Label12.TabIndex = 10
    Me.Label12.Tag = "c"
    Me.Label12.Text = "Estatus"
    '
    'txtAccountRef
    '
    Me.txtAccountRef.Location = New System.Drawing.Point(102, 164)
    Me.txtAccountRef.MenuManager = Me.BarManager1
    Me.txtAccountRef.Name = "txtAccountRef"
    Me.txtAccountRef.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAccountRef.Properties.Appearance.Options.UseFont = True
    Me.txtAccountRef.Properties.ReadOnly = True
    Me.txtAccountRef.Size = New System.Drawing.Size(130, 20)
    Me.txtAccountRef.TabIndex = 5
    Me.txtAccountRef.Tag = "c"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label11.Location = New System.Drawing.Point(9, 167)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(55, 14)
    Me.Label11.TabIndex = 8
    Me.Label11.Tag = "c"
    Me.Label11.Text = "# Cuenta"
    '
    'txtSalesAreaID
    '
    Me.txtSalesAreaID.Location = New System.Drawing.Point(102, 62)
    Me.txtSalesAreaID.MenuManager = Me.BarManager1
    Me.txtSalesAreaID.Name = "txtSalesAreaID"
    Me.txtSalesAreaID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSalesAreaID.Properties.Appearance.Options.UseFont = True
    Me.txtSalesAreaID.Properties.ReadOnly = True
    Me.txtSalesAreaID.Size = New System.Drawing.Size(130, 20)
    Me.txtSalesAreaID.TabIndex = 2
    Me.txtSalesAreaID.Tag = "c"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label10.Location = New System.Drawing.Point(9, 65)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(30, 14)
    Me.Label10.TabIndex = 2
    Me.Label10.Tag = "c"
    Me.Label10.Text = "País"
    '
    'btnedCustomer
    '
    Me.btnedCustomer.Location = New System.Drawing.Point(102, 28)
    Me.btnedCustomer.MenuManager = Me.BarManager1
    Me.btnedCustomer.Name = "btnedCustomer"
    Me.btnedCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.btnedCustomer.Size = New System.Drawing.Size(130, 20)
    Me.btnedCustomer.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(9, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 14)
    Me.Label1.TabIndex = 0
    Me.Label1.Tag = "c"
    Me.Label1.Text = "Cliente"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label9.Location = New System.Drawing.Point(837, 153)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(38, 14)
    Me.Label9.TabIndex = 18
    Me.Label9.Tag = "c"
    Me.Label9.Text = "Notas"
    '
    'txtVisibleNotes
    '
    Me.txtVisibleNotes.Location = New System.Drawing.Point(881, 35)
    Me.txtVisibleNotes.MenuManager = Me.BarManager1
    Me.txtVisibleNotes.Name = "txtVisibleNotes"
    Me.txtVisibleNotes.Size = New System.Drawing.Size(263, 251)
    Me.txtVisibleNotes.TabIndex = 12
    '
    'dteDueTime
    '
    Me.dteDueTime.EditValue = Nothing
    Me.dteDueTime.Location = New System.Drawing.Point(131, 152)
    Me.dteDueTime.MenuManager = Me.BarManager1
    Me.dteDueTime.Name = "dteDueTime"
    Me.dteDueTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDueTime.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDueTime.Size = New System.Drawing.Size(130, 20)
    Me.dteDueTime.TabIndex = 5
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label8.Location = New System.Drawing.Point(9, 155)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(97, 14)
    Me.Label8.TabIndex = 8
    Me.Label8.Tag = "c"
    Me.Label8.Text = "Fecha Entregada"
    '
    'dteFinishDate
    '
    Me.dteFinishDate.EditValue = Nothing
    Me.dteFinishDate.Location = New System.Drawing.Point(131, 122)
    Me.dteFinishDate.MenuManager = Me.BarManager1
    Me.dteFinishDate.Name = "dteFinishDate"
    Me.dteFinishDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteFinishDate.Size = New System.Drawing.Size(130, 20)
    Me.dteFinishDate.TabIndex = 4
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label7.Location = New System.Drawing.Point(9, 125)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(98, 14)
    Me.Label7.TabIndex = 6
    Me.Label7.Tag = "c"
    Me.Label7.Text = "Fecha Requerida"
    '
    'dteDateEntered
    '
    Me.dteDateEntered.EditValue = Nothing
    Me.dteDateEntered.Location = New System.Drawing.Point(131, 92)
    Me.dteDateEntered.MenuManager = Me.BarManager1
    Me.dteDateEntered.Name = "dteDateEntered"
    Me.dteDateEntered.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDateEntered.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.dteDateEntered.Size = New System.Drawing.Size(130, 20)
    Me.dteDateEntered.TabIndex = 3
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label6.Location = New System.Drawing.Point(9, 95)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(120, 14)
    Me.Label6.TabIndex = 4
    Me.Label6.Tag = "c"
    Me.Label6.Text = "Fecha de Realización"
    '
    'cboEstatusENUM
    '
    Me.cboEstatusENUM.Location = New System.Drawing.Point(131, 212)
    Me.cboEstatusENUM.MenuManager = Me.BarManager1
    Me.cboEstatusENUM.Name = "cboEstatusENUM"
    Me.cboEstatusENUM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboEstatusENUM.Size = New System.Drawing.Size(130, 20)
    Me.cboEstatusENUM.TabIndex = 7
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label5.Location = New System.Drawing.Point(9, 215)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(44, 14)
    Me.Label5.TabIndex = 12
    Me.Label5.Tag = "c"
    Me.Label5.Text = "Estado"
    '
    'cboOrderTypeID
    '
    Me.cboOrderTypeID.Location = New System.Drawing.Point(131, 182)
    Me.cboOrderTypeID.MenuManager = Me.BarManager1
    Me.cboOrderTypeID.Name = "cboOrderTypeID"
    Me.cboOrderTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cboOrderTypeID.Size = New System.Drawing.Size(130, 20)
    Me.cboOrderTypeID.TabIndex = 6
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(9, 185)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(82, 14)
    Me.Label4.TabIndex = 10
    Me.Label4.Tag = "c"
    Me.Label4.Text = "Tipo de Venta"
    '
    'txtProjectName
    '
    Me.txtProjectName.Location = New System.Drawing.Point(131, 62)
    Me.txtProjectName.MenuManager = Me.BarManager1
    Me.txtProjectName.Name = "txtProjectName"
    Me.txtProjectName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtProjectName.Properties.Appearance.Options.UseFont = True
    Me.txtProjectName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtProjectName.Size = New System.Drawing.Size(130, 20)
    Me.txtProjectName.TabIndex = 2
    Me.txtProjectName.Tag = "c"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label3.Location = New System.Drawing.Point(9, 65)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(56, 14)
    Me.Label3.TabIndex = 2
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
    Me.Label2.TabIndex = 0
    Me.Label2.Tag = "c"
    Me.Label2.Text = "Referencia"
    '
    'txtSalesOrderID
    '
    Me.txtSalesOrderID.Location = New System.Drawing.Point(131, 32)
    Me.txtSalesOrderID.MenuManager = Me.BarManager1
    Me.txtSalesOrderID.Name = "txtSalesOrderID"
    Me.txtSalesOrderID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSalesOrderID.Properties.Appearance.Options.UseFont = True
    Me.txtSalesOrderID.Size = New System.Drawing.Size(130, 20)
    Me.txtSalesOrderID.TabIndex = 1
    Me.txtSalesOrderID.Tag = "c"
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.grpOrderItem)
    Me.PanelControl1.Controls.Add(Me.grpWorkOrders)
    Me.PanelControl1.Controls.Add(Me.GridControl3)
    Me.PanelControl1.Controls.Add(Me.GridControl2)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(3, 307)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1158, 386)
    Me.PanelControl1.TabIndex = 14
    '
    'grpOrderItem
    '
    Me.grpOrderItem.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpOrderItem.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpOrderItem.AppearanceCaption.Options.UseFont = True
    Me.grpOrderItem.AppearanceCaption.Options.UseForeColor = True
    Me.grpOrderItem.Controls.Add(Me.grdOrderItem)
    Me.grpOrderItem.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Aggregar", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 1, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Eliminar", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, 2, -1)})
    Me.grpOrderItem.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpOrderItem.Location = New System.Drawing.Point(0, 5)
    Me.grpOrderItem.Name = "grpOrderItem"
    Me.grpOrderItem.Size = New System.Drawing.Size(563, 191)
    Me.grpOrderItem.TabIndex = 0
    Me.grpOrderItem.Text = "Articulos"
    '
    'grdOrderItem
    '
    Me.grdOrderItem.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdOrderItem.Location = New System.Drawing.Point(2, 26)
    Me.grdOrderItem.MainView = Me.gvOrderItem
    Me.grdOrderItem.MenuManager = Me.BarManager1
    Me.grdOrderItem.Name = "grdOrderItem"
    Me.grdOrderItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemCalcEdit1})
    Me.grdOrderItem.Size = New System.Drawing.Size(559, 163)
    Me.grdOrderItem.TabIndex = 0
    Me.grdOrderItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOrderItem})
    '
    'gvOrderItem
    '
    Me.gvOrderItem.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvOrderItem.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvOrderItem.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvOrderItem.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvOrderItem.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvOrderItem.Appearance.Row.Options.UseFont = True
    Me.gvOrderItem.ColumnPanelRowHeight = 34
    Me.gvOrderItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn10, Me.gcQuantity, Me.gcUnitPrice, Me.gcTotalAmount, Me.gcWoodSpecie, Me.gcWoodFinish})
    Me.gvOrderItem.GridControl = Me.grdOrderItem
    Me.gvOrderItem.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", Me.gcTotalAmount, "(Precio: SUMA={0:#.##})")})
    Me.gvOrderItem.Name = "gvOrderItem"
    Me.gvOrderItem.OptionsDetail.EnableMasterViewMode = False
    Me.gvOrderItem.OptionsView.ShowGroupPanel = False
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "ID"
    Me.GridColumn4.FieldName = "WorkOrderID"
    Me.GridColumn4.Name = "GridColumn4"
    '
    'GridColumn5
    '
    Me.GridColumn5.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold
    Me.GridColumn5.AppearanceCell.Options.UseFont = True
    Me.GridColumn5.Caption = "#"
    Me.GridColumn5.FieldName = "ItemNumber"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 0
    Me.GridColumn5.Width = 33
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Descripción"
    Me.GridColumn7.FieldName = "Description"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 1
    Me.GridColumn7.Width = 118
    '
    'GridColumn10
    '
    Me.GridColumn10.Caption = "Imagen"
    Me.GridColumn10.ColumnEdit = Me.RepositoryItemButtonEdit2
    Me.GridColumn10.FieldName = "ImageFile"
    Me.GridColumn10.Name = "GridColumn10"
    Me.GridColumn10.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn10.Visible = True
    Me.GridColumn10.VisibleIndex = 7
    Me.GridColumn10.Width = 131
    '
    'RepositoryItemButtonEdit2
    '
    Me.RepositoryItemButtonEdit2.AutoHeight = False
    Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
    '
    'gcQuantity
    '
    Me.gcQuantity.Caption = "Cantidad"
    Me.gcQuantity.FieldName = "Quantity"
    Me.gcQuantity.Name = "gcQuantity"
    Me.gcQuantity.Visible = True
    Me.gcQuantity.VisibleIndex = 4
    Me.gcQuantity.Width = 66
    '
    'gcUnitPrice
    '
    Me.gcUnitPrice.Caption = "Precio"
    Me.gcUnitPrice.FieldName = "UnitPrice"
    Me.gcUnitPrice.Name = "gcUnitPrice"
    Me.gcUnitPrice.Visible = True
    Me.gcUnitPrice.VisibleIndex = 5
    Me.gcUnitPrice.Width = 63
    '
    'gcTotalAmount
    '
    Me.gcTotalAmount.Caption = "Total"
    Me.gcTotalAmount.FieldName = "gcTotalAmount"
    Me.gcTotalAmount.Name = "gcTotalAmount"
    Me.gcTotalAmount.UnboundExpression = "[Quantity] * [UnitPrice]"
    Me.gcTotalAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.gcTotalAmount.Visible = True
    Me.gcTotalAmount.VisibleIndex = 6
    Me.gcTotalAmount.Width = 57
    '
    'gcWoodSpecie
    '
    Me.gcWoodSpecie.Caption = "Madera"
    Me.gcWoodSpecie.ColumnEdit = Me.RepositoryItemLookUpEdit1
    Me.gcWoodSpecie.FieldName = "WoodSpecieID"
    Me.gcWoodSpecie.Name = "gcWoodSpecie"
    Me.gcWoodSpecie.Visible = True
    Me.gcWoodSpecie.VisibleIndex = 2
    Me.gcWoodSpecie.Width = 61
    '
    'RepositoryItemLookUpEdit1
    '
    Me.RepositoryItemLookUpEdit1.AutoHeight = False
    Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
    '
    'gcWoodFinish
    '
    Me.gcWoodFinish.Caption = "Acabado"
    Me.gcWoodFinish.ColumnEdit = Me.RepositoryItemLookUpEdit2
    Me.gcWoodFinish.FieldName = "WoodFinish"
    Me.gcWoodFinish.Name = "gcWoodFinish"
    Me.gcWoodFinish.Visible = True
    Me.gcWoodFinish.VisibleIndex = 3
    Me.gcWoodFinish.Width = 59
    '
    'RepositoryItemLookUpEdit2
    '
    Me.RepositoryItemLookUpEdit2.AutoHeight = False
    Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
    '
    'RepositoryItemButtonEdit1
    '
    Me.RepositoryItemButtonEdit1.AutoHeight = False
    Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
    '
    'RepositoryItemCalcEdit1
    '
    Me.RepositoryItemCalcEdit1.AutoHeight = False
    Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
    '
    'grpWorkOrders
    '
    Me.grpWorkOrders.AppearanceCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpWorkOrders.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
    Me.grpWorkOrders.AppearanceCaption.Options.UseFont = True
    Me.grpWorkOrders.AppearanceCaption.Options.UseForeColor = True
    Me.grpWorkOrders.Controls.Add(Me.grdWorkOrders)
    Me.grpWorkOrders.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
    Me.grpWorkOrders.Location = New System.Drawing.Point(578, 5)
    Me.grpWorkOrders.Name = "grpWorkOrders"
    Me.grpWorkOrders.Size = New System.Drawing.Size(571, 193)
    Me.grpWorkOrders.TabIndex = 1
    Me.grpWorkOrders.Text = "Ordenes de Trabajo"
    '
    'grdWorkOrders
    '
    Me.grdWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdWorkOrders.Location = New System.Drawing.Point(2, 23)
    Me.grdWorkOrders.MainView = Me.gvWorkOrders
    Me.grdWorkOrders.MenuManager = Me.BarManager1
    Me.grdWorkOrders.Name = "grdWorkOrders"
    Me.grdWorkOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repitbtWorkOrder})
    Me.grdWorkOrders.Size = New System.Drawing.Size(567, 168)
    Me.grdWorkOrders.TabIndex = 0
    Me.grdWorkOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWorkOrders})
    '
    'gvWorkOrders
    '
    Me.gvWorkOrders.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvWorkOrders.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvWorkOrders.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvWorkOrders.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvWorkOrders.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvWorkOrders.Appearance.Row.Options.UseFont = True
    Me.gvWorkOrders.ColumnPanelRowHeight = 34
    Me.gvWorkOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.gcWOSOItemNumber, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.Quantity, Me.GridColumn8})
    Me.gvWorkOrders.GridControl = Me.grdWorkOrders
    Me.gvWorkOrders.Name = "gvWorkOrders"
    Me.gvWorkOrders.OptionsDetail.EnableMasterViewMode = False
    Me.gvWorkOrders.OptionsView.AllowCellMerge = True
    Me.gvWorkOrders.OptionsView.ShowGroupPanel = False
    '
    'GridColumn12
    '
    Me.GridColumn12.Caption = "ID"
    Me.GridColumn12.FieldName = "WorkOrderID"
    Me.GridColumn12.Name = "GridColumn12"
    Me.GridColumn12.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
    '
    'gcWOSOItemNumber
    '
    Me.gcWOSOItemNumber.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold
    Me.gcWOSOItemNumber.AppearanceCell.Options.UseFont = True
    Me.gcWOSOItemNumber.Caption = "#"
    Me.gcWOSOItemNumber.FieldName = "ub_ItemNumber"
    Me.gcWOSOItemNumber.Name = "gcWOSOItemNumber"
    Me.gcWOSOItemNumber.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
    Me.gcWOSOItemNumber.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcWOSOItemNumber.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
    Me.gcWOSOItemNumber.Visible = True
    Me.gcWOSOItemNumber.VisibleIndex = 0
    Me.gcWOSOItemNumber.Width = 47
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Num. O.T."
    Me.GridColumn1.ColumnEdit = Me.repitbtWorkOrder
    Me.GridColumn1.FieldName = "WorkOrderNo"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
    Me.GridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 1
    Me.GridColumn1.Width = 101
    '
    'repitbtWorkOrder
    '
    Me.repitbtWorkOrder.AutoHeight = False
    Me.repitbtWorkOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete), New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.repitbtWorkOrder.Name = "repitbtWorkOrder"
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tipo de OT"
    Me.GridColumn2.FieldName = "WorkOrderType"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 2
    Me.GridColumn2.Width = 68
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Descripción"
    Me.GridColumn3.FieldName = "Description"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 3
    Me.GridColumn3.Width = 201
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Cantidad Por Articulo"
    Me.GridColumn6.FieldName = "QtyPerSalesItem"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 4
    Me.GridColumn6.Width = 74
    '
    'Quantity
    '
    Me.Quantity.Caption = "Cantidad Total"
    Me.Quantity.FieldName = "Quantity"
    Me.Quantity.Name = "Quantity"
    Me.Quantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
    Me.Quantity.Visible = True
    Me.Quantity.VisibleIndex = 5
    Me.Quantity.Width = 60
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "CostoUnitario"
    Me.GridColumn8.FieldName = "UnitPrice"
    Me.GridColumn8.Name = "GridColumn8"
    '
    'GridControl3
    '
    Me.GridControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.GridControl3.Location = New System.Drawing.Point(580, 204)
    Me.GridControl3.MainView = Me.GridView3
    Me.GridControl3.MenuManager = Me.BarManager1
    Me.GridControl3.Name = "GridControl3"
    Me.GridControl3.Size = New System.Drawing.Size(569, 173)
    Me.GridControl3.TabIndex = 3
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
    Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.GridControl2.Location = New System.Drawing.Point(0, 204)
    Me.GridControl2.MainView = Me.GridView2
    Me.GridControl2.MenuManager = Me.BarManager1
    Me.GridControl2.Name = "GridControl2"
    Me.GridControl2.Size = New System.Drawing.Size(563, 173)
    Me.GridControl2.TabIndex = 2
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
    'frmSalesOrderDetail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1164, 729)
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
    CType(Me.cboContractManagerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl3.ResumeLayout(False)
    Me.GroupControl3.PerformLayout()
    CType(Me.txtShippingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboSalesDelAreaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cboCustomerDelContacID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDelAddress2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDelAddress1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.btneSalesOrderDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    Me.GroupControl2.PerformLayout()
    CType(Me.txtCustomerContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    CType(Me.grpOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpOrderItem.ResumeLayout(False)
    CType(Me.grdOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grpWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpWorkOrders.ResumeLayout(False)
    CType(Me.grdWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repitbtWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents grdWorkOrders As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvWorkOrders As DevExpress.XtraGrid.Views.Grid.GridView
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
  Friend WithEvents grpWorkOrders As DevExpress.XtraEditors.GroupControl
  Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repitbtWorkOrder As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Quantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents lblSalesOrderID As Label
  Friend WithEvents Label15 As Label
  Friend WithEvents btneSalesOrderDocument As DevExpress.XtraEditors.ButtonEdit
  Friend WithEvents txtDelAddress1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label16 As Label
  Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents cboCustomerDelContacID As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label18 As Label
  Friend WithEvents txtDelAddress2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label17 As Label
  Friend WithEvents Label21 As Label
  Friend WithEvents txtCustomerContact As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label20 As Label
  Friend WithEvents cboSalesDelAreaID As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents grpOrderItem As DevExpress.XtraEditors.GroupControl
  Friend WithEvents grdOrderItem As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvOrderItem As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcQuantity As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcTotalAmount As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcWOSOItemNumber As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents cboContractManagerID As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents Label19 As Label
  Friend WithEvents gcWoodSpecie As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcWoodFinish As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtShippingCost As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label22 As Label
  Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
