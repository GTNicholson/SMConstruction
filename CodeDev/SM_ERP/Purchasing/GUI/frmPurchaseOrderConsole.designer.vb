<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurchaseOrderConsole
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
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.bbtnExit = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnCreateNewPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnOpenExistingPO = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.barEditMaterialGroup = New DevExpress.XtraBars.BarEditItem()
    Me.repcboMaterialGroup = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.repcboMaterialGroup, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnOpenExistingPO, Me.bbtnCreateNewPurchaseOrder, Me.barEditMaterialGroup, Me.bbtnExit})
    Me.BarManager1.MaxItemId = 8
    Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repcboMaterialGroup})
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnExit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnCreateNewPurchaseOrder), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnOpenExistingPO)})
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.Text = "Tools"
    '
    'bbtnExit
    '
    Me.bbtnExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnExit.Caption = "Salir"
    Me.bbtnExit.Id = 6
    Me.bbtnExit.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bbtnExit.ItemAppearance.Normal.Options.UseFont = True
    Me.bbtnExit.Name = "bbtnExit"
    '
    'bbtnCreateNewPurchaseOrder
    '
    Me.bbtnCreateNewPurchaseOrder.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnCreateNewPurchaseOrder.Caption = "Crear Nueva O.C."
    Me.bbtnCreateNewPurchaseOrder.Id = 1
    Me.bbtnCreateNewPurchaseOrder.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
    Me.bbtnCreateNewPurchaseOrder.ItemAppearance.Normal.Options.UseFont = True
    Me.bbtnCreateNewPurchaseOrder.Name = "bbtnCreateNewPurchaseOrder"
    '
    'bbtnOpenExistingPO
    '
    Me.bbtnOpenExistingPO.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.bbtnOpenExistingPO.Caption = "Abrir C.O."
    Me.bbtnOpenExistingPO.Id = 0
    Me.bbtnOpenExistingPO.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
    Me.bbtnOpenExistingPO.ItemAppearance.Normal.Options.UseFont = True
    Me.bbtnOpenExistingPO.Name = "bbtnOpenExistingPO"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1362, 32)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 741)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1362, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 32)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 709)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1362, 32)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 709)
    '
    'barEditMaterialGroup
    '
    Me.barEditMaterialGroup.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barEditMaterialGroup.Caption = "Material Group"
    Me.barEditMaterialGroup.Edit = Me.repcboMaterialGroup
    Me.barEditMaterialGroup.EditWidth = 210
    Me.barEditMaterialGroup.Id = 3
    Me.barEditMaterialGroup.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.barEditMaterialGroup.ItemAppearance.Normal.Options.UseFont = True
    Me.barEditMaterialGroup.Name = "barEditMaterialGroup"
    '
    'repcboMaterialGroup
    '
    Me.repcboMaterialGroup.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.repcboMaterialGroup.Appearance.Options.UseFont = True
    Me.repcboMaterialGroup.AutoHeight = False
    Me.repcboMaterialGroup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.repcboMaterialGroup.Name = "repcboMaterialGroup"
    '
    'XtraTabbedMdiManager1
    '
    Me.XtraTabbedMdiManager1.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = True
    Me.XtraTabbedMdiManager1.MdiParent = Me
    '
    'frmPurchaseOrderConsole
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1362, 741)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.IsMdiContainer = True
    Me.Name = "frmPurchaseOrderConsole"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Administrador de Órden de Compra"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.repcboMaterialGroup, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barEditMaterialGroup As DevExpress.XtraBars.BarEditItem
  Friend WithEvents repcboMaterialGroup As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents bbtnOpenExistingPO As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnCreateNewPurchaseOrder As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
  Friend WithEvents bbtnExit As DevExpress.XtraBars.BarButtonItem
End Class
