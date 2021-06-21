<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRichTextEmail
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRichTextEmail))
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.barbtnClose = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnAttachFile = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnSaveAttachment = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnSend = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnSpool = New DevExpress.XtraBars.BarButtonItem()
    Me.barbtnProperties = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.recMessageBody = New DevExpress.XtraRichEdit.RichEditControl()
    Me.imgListAttach = New DevExpress.XtraEditors.ImageListBoxControl()
    Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
    Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
    Me.txtBcc = New DevExpress.XtraEditors.TextEdit()
    Me.lblBcc = New DevExpress.XtraEditors.LabelControl()
    Me.txtCc = New DevExpress.XtraEditors.TextEdit()
    Me.lblCc = New DevExpress.XtraEditors.LabelControl()
    Me.txtFrom = New DevExpress.XtraEditors.TextEdit()
    Me.lblFrom = New DevExpress.XtraEditors.LabelControl()
    Me.lblTo = New DevExpress.XtraEditors.LabelControl()
    Me.txtTo = New DevExpress.XtraEditors.ButtonEdit()
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.imgListAttach, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'BarManager1
    '
    Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
    Me.BarManager1.DockControls.Add(Me.barDockControlTop)
    Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.BarManager1.DockControls.Add(Me.barDockControlRight)
    Me.BarManager1.Form = Me
    Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barbtnClose, Me.barbtnSend, Me.barbtnSpool, Me.barbtnAttachFile, Me.barbtnProperties, Me.barbtnSaveAttachment})
    Me.BarManager1.MaxItemId = 6
    '
    'Bar1
    '
    Me.Bar1.BarName = "Tools"
    Me.Bar1.DockCol = 0
    Me.Bar1.DockRow = 0
    Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnAttachFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSaveAttachment, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSend, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnSpool), New DevExpress.XtraBars.LinkPersistInfo(Me.barbtnProperties, True)})
    Me.Bar1.OptionsBar.AllowQuickCustomization = False
    Me.Bar1.OptionsBar.DrawDragBorder = False
    Me.Bar1.OptionsBar.UseWholeRow = True
    Me.Bar1.Text = "Tools"
    '
    'barbtnClose
    '
    Me.barbtnClose.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnClose.Caption = "Close"
    Me.barbtnClose.Id = 0
    Me.barbtnClose.Name = "barbtnClose"
    '
    'barbtnAttachFile
    '
    Me.barbtnAttachFile.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnAttachFile.Caption = "Attach File"
    Me.barbtnAttachFile.Id = 3
    Me.barbtnAttachFile.Name = "barbtnAttachFile"
    '
    'barbtnSaveAttachment
    '
    Me.barbtnSaveAttachment.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnSaveAttachment.Caption = "Save Attachment"
    Me.barbtnSaveAttachment.Id = 5
    Me.barbtnSaveAttachment.Name = "barbtnSaveAttachment"
    '
    'barbtnSend
    '
    Me.barbtnSend.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnSend.Caption = "Send"
    Me.barbtnSend.Id = 1
    Me.barbtnSend.Name = "barbtnSend"
    '
    'barbtnSpool
    '
    Me.barbtnSpool.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnSpool.Caption = "Spool"
    Me.barbtnSpool.Id = 2
    Me.barbtnSpool.Name = "barbtnSpool"
    '
    'barbtnProperties
    '
    Me.barbtnProperties.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
    Me.barbtnProperties.Caption = "Properties"
    Me.barbtnProperties.Id = 4
    Me.barbtnProperties.Name = "barbtnProperties"
    '
    'barDockControlTop
    '
    Me.barDockControlTop.CausesValidation = False
    Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
    Me.barDockControlTop.Manager = Me.BarManager1
    Me.barDockControlTop.Size = New System.Drawing.Size(817, 33)
    '
    'barDockControlBottom
    '
    Me.barDockControlBottom.CausesValidation = False
    Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.barDockControlBottom.Location = New System.Drawing.Point(0, 532)
    Me.barDockControlBottom.Manager = Me.BarManager1
    Me.barDockControlBottom.Size = New System.Drawing.Size(817, 0)
    '
    'barDockControlLeft
    '
    Me.barDockControlLeft.CausesValidation = False
    Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
    Me.barDockControlLeft.Manager = Me.BarManager1
    Me.barDockControlLeft.Size = New System.Drawing.Size(0, 499)
    '
    'barDockControlRight
    '
    Me.barDockControlRight.CausesValidation = False
    Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.barDockControlRight.Location = New System.Drawing.Point(817, 33)
    Me.barDockControlRight.Manager = Me.BarManager1
    Me.barDockControlRight.Size = New System.Drawing.Size(0, 499)
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.recMessageBody)
    Me.PanelControl1.Controls.Add(Me.imgListAttach)
    Me.PanelControl1.Controls.Add(Me.txtSubject)
    Me.PanelControl1.Controls.Add(Me.lblSubject)
    Me.PanelControl1.Controls.Add(Me.txtBcc)
    Me.PanelControl1.Controls.Add(Me.lblBcc)
    Me.PanelControl1.Controls.Add(Me.txtCc)
    Me.PanelControl1.Controls.Add(Me.lblCc)
    Me.PanelControl1.Controls.Add(Me.txtFrom)
    Me.PanelControl1.Controls.Add(Me.lblFrom)
    Me.PanelControl1.Controls.Add(Me.lblTo)
    Me.PanelControl1.Controls.Add(Me.txtTo)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControl1.Location = New System.Drawing.Point(0, 33)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(817, 499)
    Me.PanelControl1.TabIndex = 24
    '
    'recMessageBody
    '
    Me.recMessageBody.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
    Me.recMessageBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.recMessageBody.Appearance.Text.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.recMessageBody.Appearance.Text.Options.UseFont = True
    Me.recMessageBody.Location = New System.Drawing.Point(5, 170)
    Me.recMessageBody.MenuManager = Me.BarManager1
    Me.recMessageBody.Name = "recMessageBody"
    Me.recMessageBody.Size = New System.Drawing.Size(807, 324)
    Me.recMessageBody.TabIndex = 31
    '
    'imgListAttach
    '
    Me.imgListAttach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.imgListAttach.Cursor = System.Windows.Forms.Cursors.Default
    Me.imgListAttach.Location = New System.Drawing.Point(5, 113)
    Me.imgListAttach.Name = "imgListAttach"
    Me.imgListAttach.Size = New System.Drawing.Size(807, 51)
    Me.imgListAttach.TabIndex = 30
    '
    'txtSubject
    '
    Me.txtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtSubject.Location = New System.Drawing.Point(54, 87)
    Me.txtSubject.Name = "txtSubject"
    Me.txtSubject.Size = New System.Drawing.Size(758, 20)
    Me.txtSubject.TabIndex = 29
    '
    'lblSubject
    '
    Me.lblSubject.Location = New System.Drawing.Point(5, 91)
    Me.lblSubject.Name = "lblSubject"
    Me.lblSubject.Size = New System.Drawing.Size(40, 13)
    Me.lblSubject.TabIndex = 28
    Me.lblSubject.Text = "Subject:"
    '
    'txtBcc
    '
    Me.txtBcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtBcc.Location = New System.Drawing.Point(54, 61)
    Me.txtBcc.Name = "txtBcc"
    Me.txtBcc.Size = New System.Drawing.Size(758, 20)
    Me.txtBcc.TabIndex = 27
    '
    'lblBcc
    '
    Me.lblBcc.Location = New System.Drawing.Point(5, 65)
    Me.lblBcc.Name = "lblBcc"
    Me.lblBcc.Size = New System.Drawing.Size(20, 13)
    Me.lblBcc.TabIndex = 26
    Me.lblBcc.Text = "Bcc:"
    '
    'txtCc
    '
    Me.txtCc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtCc.Location = New System.Drawing.Point(54, 35)
    Me.txtCc.Name = "txtCc"
    Me.txtCc.Size = New System.Drawing.Size(758, 20)
    Me.txtCc.TabIndex = 25
    '
    'lblCc
    '
    Me.lblCc.Location = New System.Drawing.Point(5, 39)
    Me.lblCc.Name = "lblCc"
    Me.lblCc.Size = New System.Drawing.Size(16, 13)
    Me.lblCc.TabIndex = 24
    Me.lblCc.Text = "Cc:"
    '
    'txtFrom
    '
    Me.txtFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtFrom.Location = New System.Drawing.Point(464, 9)
    Me.txtFrom.Name = "txtFrom"
    Me.txtFrom.Size = New System.Drawing.Size(348, 20)
    Me.txtFrom.TabIndex = 23
    '
    'lblFrom
    '
    Me.lblFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblFrom.Location = New System.Drawing.Point(430, 13)
    Me.lblFrom.Name = "lblFrom"
    Me.lblFrom.Size = New System.Drawing.Size(28, 13)
    Me.lblFrom.TabIndex = 22
    Me.lblFrom.Text = "From:"
    '
    'lblTo
    '
    Me.lblTo.Location = New System.Drawing.Point(5, 13)
    Me.lblTo.Name = "lblTo"
    Me.lblTo.Size = New System.Drawing.Size(16, 13)
    Me.lblTo.TabIndex = 20
    Me.lblTo.Text = "To:"
    '
    'txtTo
    '
    Me.txtTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTo.Location = New System.Drawing.Point(54, 9)
    Me.txtTo.Name = "txtTo"
    Me.txtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
    Me.txtTo.Size = New System.Drawing.Size(370, 20)
    Me.txtTo.TabIndex = 21
    '
    'frmRichTextEmail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(817, 532)
    Me.Controls.Add(Me.PanelControl1)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)

    Me.Name = "frmRichTextEmail"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Email Message"
    CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    CType(Me.imgListAttach, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents barbtnClose As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnAttachFile As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnSend As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barbtnSpool As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barbtnProperties As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents recMessageBody As DevExpress.XtraRichEdit.RichEditControl
  Friend WithEvents imgListAttach As DevExpress.XtraEditors.ImageListBoxControl
  Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblSubject As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtBcc As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblBcc As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCc As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblCc As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtFrom As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lblFrom As DevExpress.XtraEditors.LabelControl
  Friend WithEvents lblTo As DevExpress.XtraEditors.LabelControl
  Friend WithEvents barbtnSaveAttachment As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents txtTo As DevExpress.XtraEditors.ButtonEdit
End Class
