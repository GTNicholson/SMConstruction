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
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
    Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.txtCustomerReference = New DevExpress.XtraEditors.TextEdit()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.txtMainAddress1 = New DevExpress.XtraEditors.TextEdit()
    Me.Label8 = New System.Windows.Forms.Label()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.txtCustomerReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMainAddress1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveAndClose, Me.bbtnSave, Me.btnClose})
    Me.BarManager1.MaxItemId = 3
    '
    'Bar1
    '
    Me.Bar1.BarName = "Herramientas"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.FloatLocation = New System.Drawing.Point(123, 136)
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
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
    Me.GroupControl1.Controls.Add(Me.txtCustomerReference)
    Me.GroupControl1.Controls.Add(Me.Label12)
    Me.GroupControl1.Controls.Add(Me.txtMainAddress1)
    Me.GroupControl1.Controls.Add(Me.Label8)
    Me.GroupControl1.Location = New System.Drawing.Point(12, 39)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(620, 314)
    Me.GroupControl1.TabIndex = 4
    Me.GroupControl1.Text = "Detalles del Cliente"
    '
    'txtCustomerReference
    '
    Me.txtCustomerReference.Location = New System.Drawing.Point(141, 29)
    Me.txtCustomerReference.Name = "txtCustomerReference"
    Me.txtCustomerReference.Properties.MaxLength = 15
    Me.txtCustomerReference.Size = New System.Drawing.Size(155, 20)
    Me.txtCustomerReference.TabIndex = 0
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label12.Location = New System.Drawing.Point(5, 32)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(75, 14)
    Me.Label12.TabIndex = 18
    Me.Label12.Text = "# Referencia"
    '
    'txtMainAddress1
    '
    Me.txtMainAddress1.Location = New System.Drawing.Point(456, 29)
    Me.txtMainAddress1.Name = "txtMainAddress1"
    Me.txtMainAddress1.Properties.MaxLength = 100
    Me.txtMainAddress1.Size = New System.Drawing.Size(155, 20)
    Me.txtMainAddress1.TabIndex = 6
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label8.Location = New System.Drawing.Point(342, 32)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(108, 14)
    Me.Label8.TabIndex = 17
    Me.Label8.Text = "Dirección principal"
    '
    'frmInvoice
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1164, 521)
    Me.Controls.Add(Me.GroupControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "frmInvoice"
    Me.Text = "frmInvoice"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.txtCustomerReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMainAddress1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents txtCustomerReference As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label12 As Label
  Friend WithEvents txtMainAddress1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents Label8 As Label
End Class
