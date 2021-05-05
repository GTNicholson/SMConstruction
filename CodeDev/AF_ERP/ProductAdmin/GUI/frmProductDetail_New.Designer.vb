<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductDetail_New
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uctProductDetail = New AgroForestal.uctProductBaseDetail()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnCreateCopy = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnCreateCopySelected = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnChangeSpecies = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Panel1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.uctProductDetail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1376, 598)
        Me.Panel1.TabIndex = 1
        '
        'uctProductDetail
        '
        Me.uctProductDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uctProductDetail.FormController = Nothing
        Me.uctProductDetail.ItemsSelected = 0
        Me.uctProductDetail.Location = New System.Drawing.Point(0, 0)
        Me.uctProductDetail.Name = "uctProductDetail"
        Me.uctProductDetail.Size = New System.Drawing.Size(1376, 598)
        Me.uctProductDetail.TabIndex = 0
        Me.uctProductDetail.TempInWoodStock = 0
        Me.uctProductDetail.WoodItemsSelected = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnSaveAndClose, Me.bbtnSave, Me.bbtnClose, Me.bbtnCreateCopy, Me.bbtnCreateCopySelected, Me.bbtnChangeSpecies})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSaveAndClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnCreateCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnCreateCopySelected)})
        Me.Bar1.Text = "Tools"
        '
        'bbtnSaveAndClose
        '
        Me.bbtnSaveAndClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnSaveAndClose.Caption = "Guardar y Cerrar"
        Me.bbtnSaveAndClose.Id = 0
        Me.bbtnSaveAndClose.Name = "bbtnSaveAndClose"
        '
        'bbtnSave
        '
        Me.bbtnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnSave.Caption = "Guardar"
        Me.bbtnSave.Id = 1
        Me.bbtnSave.Name = "bbtnSave"
        '
        'bbtnClose
        '
        Me.bbtnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnClose.Caption = "Cerrar"
        Me.bbtnClose.Id = 2
        Me.bbtnClose.Name = "bbtnClose"
        '
        'bbtnCreateCopy
        '
        Me.bbtnCreateCopy.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnCreateCopy.Caption = "Crear Copia"
        Me.bbtnCreateCopy.Id = 3
        Me.bbtnCreateCopy.Name = "bbtnCreateCopy"
        '
        'bbtnCreateCopySelected
        '
        Me.bbtnCreateCopySelected.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnCreateCopySelected.Caption = "Crear Copia de Selección"
        Me.bbtnCreateCopySelected.Id = 4
        Me.bbtnCreateCopySelected.Name = "bbtnCreateCopySelected"
        '
        'bbtnChangeSpecies
        '
        Me.bbtnChangeSpecies.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnChangeSpecies.Caption = "Cambiar Especie de Selección"
        Me.bbtnChangeSpecies.Id = 5
        Me.bbtnChangeSpecies.Name = "bbtnChangeSpecies"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1376, 33)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 631)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1376, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 598)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1376, 33)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 598)
        '
        'frmProductDetail_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 654)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmProductDetail_New"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Productos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents uctProductDetail As uctProductBaseDetail
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtnSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbtnCreateCopy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnCreateCopySelected As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnChangeSpecies As DevExpress.XtraBars.BarButtonItem
End Class
