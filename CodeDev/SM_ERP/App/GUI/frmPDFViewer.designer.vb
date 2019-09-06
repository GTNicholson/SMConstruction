<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDFViewer
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
    Me.PdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.PdfCommandBar1 = New DevExpress.XtraPdfViewer.Bars.PdfCommandBar()
    Me.PdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
    Me.barbtSaveAs = New DevExpress.XtraBars.BarButtonItem()
    Me.PdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
    Me.PdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
    Me.PdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
    Me.PdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
    Me.PdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
    Me.PdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
    Me.PdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
    Me.PdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
    Me.PdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
    Me.PdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
    Me.PdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
    Me.PdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
    Me.PdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
    Me.PdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
    Me.PdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
    Me.PdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
    Me.PdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
    Me.PdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
    Me.PdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
    Me.PdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.PdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController()
    Me.PdfViewer1.SuspendLayout()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PdfViewer1
    '
    Me.PdfViewer1.Controls.Add(Me.barDockControlLeft)
    Me.PdfViewer1.Controls.Add(Me.barDockControlRight)
    Me.PdfViewer1.Controls.Add(Me.barDockControlBottom)
    Me.PdfViewer1.Controls.Add(Me.barDockControlTop)
    Me.PdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PdfViewer1.Location = New System.Drawing.Point(0, 0)
    Me.PdfViewer1.Name = "PdfViewer1"
    Me.PdfViewer1.Size = New System.Drawing.Size(1135, 812)
    Me.PdfViewer1.TabIndex = 0
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 781)
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.PdfCommandBar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me.PdfViewer1
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.PdfFileOpenBarItem1, Me.PdfFilePrintBarItem1, Me.PdfPreviousPageBarItem1, Me.PdfNextPageBarItem1, Me.PdfZoomOutBarItem1, Me.PdfZoomInBarItem1, Me.PdfExactZoomListBarSubItem1, Me.PdfZoom10CheckItem1, Me.PdfZoom25CheckItem1, Me.PdfZoom50CheckItem1, Me.PdfZoom75CheckItem1, Me.PdfZoom100CheckItem1, Me.PdfZoom125CheckItem1, Me.PdfZoom150CheckItem1, Me.PdfZoom200CheckItem1, Me.PdfZoom400CheckItem1, Me.PdfZoom500CheckItem1, Me.PdfSetActualSizeZoomModeCheckItem1, Me.PdfSetPageLevelZoomModeCheckItem1, Me.PdfSetFitWidthZoomModeCheckItem1, Me.PdfSetFitVisibleZoomModeCheckItem1, Me.barbtSaveAs})
    Me.BarManager1.MaxItemId = 22
    '
    'PdfCommandBar1
    '
    Me.PdfCommandBar1.Control = Me.PdfViewer1
    Me.PdfCommandBar1.DockCol = 0
    Me.PdfCommandBar1.DockRow = 0
    Me.PdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.PdfCommandBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFileOpenBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtSaveAs), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFilePrintBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfPreviousPageBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfNextPageBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoomOutBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoomInBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfExactZoomListBarSubItem1)})
    '
    'PdfFileOpenBarItem1
    '
    Me.PdfFileOpenBarItem1.Id = 0
    Me.PdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
    Me.PdfFileOpenBarItem1.Name = "PdfFileOpenBarItem1"
    '
    'barbtSaveAs
    '
    Me.barbtSaveAs.Caption = "Save As"
    Me.barbtSaveAs.Id = 21
    Me.barbtSaveAs.Name = "barbtSaveAs"
    '
    'PdfFilePrintBarItem1
    '
    Me.PdfFilePrintBarItem1.Id = 1
    Me.PdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
    Me.PdfFilePrintBarItem1.Name = "PdfFilePrintBarItem1"
    '
    'PdfPreviousPageBarItem1
    '
    Me.PdfPreviousPageBarItem1.Id = 2
    Me.PdfPreviousPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageUp)
    Me.PdfPreviousPageBarItem1.Name = "PdfPreviousPageBarItem1"
    '
    'PdfNextPageBarItem1
    '
    Me.PdfNextPageBarItem1.Id = 3
    Me.PdfNextPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageDown)
    Me.PdfNextPageBarItem1.Name = "PdfNextPageBarItem1"
    '
    'PdfZoomOutBarItem1
    '
    Me.PdfZoomOutBarItem1.Id = 4
    Me.PdfZoomOutBarItem1.Name = "PdfZoomOutBarItem1"
    '
    'PdfZoomInBarItem1
    '
    Me.PdfZoomInBarItem1.Id = 5
    Me.PdfZoomInBarItem1.Name = "PdfZoomInBarItem1"
    '
    'PdfExactZoomListBarSubItem1
    '
    Me.PdfExactZoomListBarSubItem1.Id = 6
    Me.PdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom10CheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom25CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom50CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom75CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom100CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom125CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom150CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom200CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom400CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom500CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetActualSizeZoomModeCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetPageLevelZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitWidthZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitVisibleZoomModeCheckItem1)})
    Me.PdfExactZoomListBarSubItem1.Name = "PdfExactZoomListBarSubItem1"
    Me.PdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
    '
    'PdfZoom10CheckItem1
    '
    Me.PdfZoom10CheckItem1.Id = 7
    Me.PdfZoom10CheckItem1.Name = "PdfZoom10CheckItem1"
    '
    'PdfZoom25CheckItem1
    '
    Me.PdfZoom25CheckItem1.Id = 8
    Me.PdfZoom25CheckItem1.Name = "PdfZoom25CheckItem1"
    '
    'PdfZoom50CheckItem1
    '
    Me.PdfZoom50CheckItem1.Id = 9
    Me.PdfZoom50CheckItem1.Name = "PdfZoom50CheckItem1"
    '
    'PdfZoom75CheckItem1
    '
    Me.PdfZoom75CheckItem1.Id = 10
    Me.PdfZoom75CheckItem1.Name = "PdfZoom75CheckItem1"
    '
    'PdfZoom100CheckItem1
    '
    Me.PdfZoom100CheckItem1.Id = 11
    Me.PdfZoom100CheckItem1.Name = "PdfZoom100CheckItem1"
    '
    'PdfZoom125CheckItem1
    '
    Me.PdfZoom125CheckItem1.Id = 12
    Me.PdfZoom125CheckItem1.Name = "PdfZoom125CheckItem1"
    '
    'PdfZoom150CheckItem1
    '
    Me.PdfZoom150CheckItem1.Id = 13
    Me.PdfZoom150CheckItem1.Name = "PdfZoom150CheckItem1"
    '
    'PdfZoom200CheckItem1
    '
    Me.PdfZoom200CheckItem1.Id = 14
    Me.PdfZoom200CheckItem1.Name = "PdfZoom200CheckItem1"
    '
    'PdfZoom400CheckItem1
    '
    Me.PdfZoom400CheckItem1.Id = 15
    Me.PdfZoom400CheckItem1.Name = "PdfZoom400CheckItem1"
    '
    'PdfZoom500CheckItem1
    '
    Me.PdfZoom500CheckItem1.Id = 16
    Me.PdfZoom500CheckItem1.Name = "PdfZoom500CheckItem1"
    '
    'PdfSetActualSizeZoomModeCheckItem1
    '
    Me.PdfSetActualSizeZoomModeCheckItem1.Id = 17
    Me.PdfSetActualSizeZoomModeCheckItem1.Name = "PdfSetActualSizeZoomModeCheckItem1"
    '
    'PdfSetPageLevelZoomModeCheckItem1
    '
    Me.PdfSetPageLevelZoomModeCheckItem1.Id = 18
    Me.PdfSetPageLevelZoomModeCheckItem1.Name = "PdfSetPageLevelZoomModeCheckItem1"
    '
    'PdfSetFitWidthZoomModeCheckItem1
    '
    Me.PdfSetFitWidthZoomModeCheckItem1.Id = 19
    Me.PdfSetFitWidthZoomModeCheckItem1.Name = "PdfSetFitWidthZoomModeCheckItem1"
    '
    'PdfSetFitVisibleZoomModeCheckItem1
    '
    Me.PdfSetFitVisibleZoomModeCheckItem1.Id = 20
    Me.PdfSetFitVisibleZoomModeCheckItem1.Name = "PdfSetFitVisibleZoomModeCheckItem1"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(1135, 31)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 812)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(1135, 0)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(1135, 31)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 781)
    '
    'PdfBarController1
    '
    Me.PdfBarController1.BarItems.Add(Me.PdfFileOpenBarItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfFilePrintBarItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfPreviousPageBarItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfNextPageBarItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoomOutBarItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoomInBarItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfExactZoomListBarSubItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom10CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom25CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom50CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom75CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom100CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom125CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom150CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom200CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom400CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfZoom500CheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfSetActualSizeZoomModeCheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfSetPageLevelZoomModeCheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfSetFitWidthZoomModeCheckItem1)
    Me.PdfBarController1.BarItems.Add(Me.PdfSetFitVisibleZoomModeCheckItem1)
    Me.PdfBarController1.Control = Me.PdfViewer1
    '
    'frmPDFViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1135, 812)
    Me.Controls.Add(Me.PdfViewer1)
    Me.Name = "frmPDFViewer"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Visualizador de PDF"
    Me.PdfViewer1.ResumeLayout(False)
    Me.PdfViewer1.PerformLayout()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PdfBarAndDockingController1 As DevExpress.XtraPdfViewer.Bars.PdfBarAndDockingController
  Friend WithEvents PdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents PdfCommandBar1 As DevExpress.XtraPdfViewer.Bars.PdfCommandBar
  Friend WithEvents PdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
  Friend WithEvents PdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
  Friend WithEvents PdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
  Friend WithEvents PdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
  Friend WithEvents PdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
  Friend WithEvents PdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
  Friend WithEvents PdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
  Friend WithEvents PdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
  Friend WithEvents PdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
  Friend WithEvents PdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
  Friend WithEvents PdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
  Friend WithEvents PdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
  Friend WithEvents PdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
  Friend WithEvents PdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
  Friend WithEvents PdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
  Friend WithEvents PdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
  Friend WithEvents PdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
  Friend WithEvents PdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
  Friend WithEvents PdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
  Friend WithEvents PdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
  Friend WithEvents PdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
  Friend WithEvents PdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
  Friend WithEvents barbtSaveAs As DevExpress.XtraBars.BarButtonItem
End Class
