<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickerCustomer
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
    Me.grdItemList = New DevExpress.XtraGrid.GridControl()
    Me.gvItemList = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCustomerType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAddress = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcAccountCode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repItemSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.bbtnNewCustomer = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdItemList
    '
    Me.grdItemList.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grdItemList.Location = New System.Drawing.Point(0, 33)
    Me.grdItemList.MainView = Me.gvItemList
    Me.grdItemList.Name = "grdItemList"
    Me.grdItemList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemSelect})
    Me.grdItemList.Size = New System.Drawing.Size(733, 367)
    Me.grdItemList.TabIndex = 0
    Me.grdItemList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemList})
    '
    'gvItemList
    '
    Me.gvItemList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gvItemList.Appearance.HeaderPanel.Options.UseFont = True
    Me.gvItemList.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.gvItemList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
    Me.gvItemList.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.gvItemList.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvItemList.Appearance.Row.Options.UseFont = True
    Me.gvItemList.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.gvItemList.Appearance.SelectedRow.Options.UseFont = True
    Me.gvItemList.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.gvItemList.Appearance.TopNewRow.Options.UseFont = True
    Me.gvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcCompanyName, Me.gcCustomerType, Me.gcAddress, Me.gcAccountCode})
    Me.gvItemList.GridControl = Me.grdItemList
    Me.gvItemList.HorzScrollStep = 20
    Me.gvItemList.Name = "gvItemList"
    Me.gvItemList.OptionsFind.AlwaysVisible = True
    Me.gvItemList.OptionsView.ShowAutoFilterRow = True
    Me.gvItemList.OptionsView.ShowDetailButtons = False
    Me.gvItemList.OptionsView.ShowGroupPanel = False
    '
    'gcID
    '
    Me.gcID.Caption = "ID"
    Me.gcID.FieldName = "CustomerID"
    Me.gcID.Name = "gcID"
    Me.gcID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcID.Width = 82
    '
    'gcCompanyName
    '
    Me.gcCompanyName.Caption = "Nombre de Compañía"
    Me.gcCompanyName.FieldName = "CompanyName"
    Me.gcCompanyName.Name = "gcCompanyName"
    Me.gcCompanyName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcCompanyName.Visible = True
    Me.gcCompanyName.VisibleIndex = 1
    Me.gcCompanyName.Width = 208
    '
    'gcCustomerType
    '
    Me.gcCustomerType.Caption = "Tipo de Cliente"
    Me.gcCustomerType.FieldName = "CustomerTypeID"
    Me.gcCustomerType.Name = "gcCustomerType"
    Me.gcCustomerType.Visible = True
    Me.gcCustomerType.VisibleIndex = 2
    Me.gcCustomerType.Width = 105
    '
    'gcAddress
    '
    Me.gcAddress.Caption = "Dirección"
    Me.gcAddress.FieldName = "MainAddress.FullAddress"
    Me.gcAddress.Name = "gcAddress"
    Me.gcAddress.Visible = True
    Me.gcAddress.VisibleIndex = 3
    Me.gcAddress.Width = 311
    '
    'gcAccountCode
    '
    Me.gcAccountCode.Caption = "Código de Cuenta"
    Me.gcAccountCode.ColumnEdit = Me.repItemSelect
    Me.gcAccountCode.FieldName = "AccountCode"
    Me.gcAccountCode.Name = "gcAccountCode"
    Me.gcAccountCode.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    Me.gcAccountCode.Visible = True
    Me.gcAccountCode.VisibleIndex = 0
    Me.gcAccountCode.Width = 90
    '
    'repItemSelect
    '
    Me.repItemSelect.AutoHeight = False
    Me.repItemSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.repItemSelect.Name = "repItemSelect"
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnNewCustomer})
    Me.BarManager1.MaxItemId = 1
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(733, 33)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 400)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(733, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 367)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(733, 33)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 367)
    '
    'Bar1
    '
    Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Arial", 8.25!)
    Me.Bar1.BarAppearance.Normal.Options.UseFont = True
    Me.Bar1.BarName = "Herramientas"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnNewCustomer)})
    Me.Bar1.Text = "Herramientas"
    '
    'bbtnNewCustomer
    '
    Me.bbtnNewCustomer.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnNewCustomer.Caption = "Nuevo Cliente"
    Me.bbtnNewCustomer.Id = 0
    Me.bbtnNewCustomer.Name = "bbtnNewCustomer"
    '
    'frmPickerCustomer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(733, 400)
    Me.Controls.Add(Me.grdItemList)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmPickerCustomer"
    Me.Text = "Selección de Cliente"
    CType(Me.grdItemList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents grdItemList As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvItemList As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCompanyName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCustomerType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcAddress As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcAccountCode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repItemSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnNewCustomer As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
