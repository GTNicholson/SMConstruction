<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctAddress
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboCountry = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblCounty = New DevExpress.XtraEditors.LabelControl()
        Me.lblTown = New DevExpress.XtraEditors.LabelControl()
        Me.txtTown = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblMainLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.Controls.Add(Me.cboCountry)
        Me.GroupControl1.Controls.Add(Me.lblCounty)
        Me.GroupControl1.Controls.Add(Me.lblTown)
        Me.GroupControl1.Controls.Add(Me.txtTown)
        Me.GroupControl1.Controls.Add(Me.txtAdd2)
        Me.GroupControl1.Controls.Add(Me.txtAdd1)
        Me.GroupControl1.Controls.Add(Me.lblMainLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(354, 144)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'cboCountry
        '
        Me.cboCountry.Location = New System.Drawing.Point(56, 106)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCountry.Size = New System.Drawing.Size(197, 20)
        Me.cboCountry.TabIndex = 29
        '
        'lblCounty
        '
        Me.lblCounty.Appearance.Options.UseTextOptions = True
        Me.lblCounty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblCounty.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCounty.Location = New System.Drawing.Point(3, 109)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(19, 13)
        Me.lblCounty.TabIndex = 22
        Me.lblCounty.Text = "Pa�s"
        '
        'lblTown
        '
        Me.lblTown.Appearance.Options.UseTextOptions = True
        Me.lblTown.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblTown.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblTown.Location = New System.Drawing.Point(3, 65)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(33, 13)
        Me.lblTown.TabIndex = 20
        Me.lblTown.Text = "Ciudad"
        '
        'txtTown
        '
        Me.txtTown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTown.Location = New System.Drawing.Point(56, 62)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(293, 20)
        Me.txtTown.TabIndex = 19
        '
        'txtAdd2
        '
        Me.txtAdd2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdd2.Location = New System.Drawing.Point(56, 31)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(293, 20)
        Me.txtAdd2.TabIndex = 18
        '
        'txtAdd1
        '
        Me.txtAdd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdd1.Location = New System.Drawing.Point(56, 4)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(293, 20)
        Me.txtAdd1.TabIndex = 17
        '
        'lblMainLabel
        '
        Me.lblMainLabel.Appearance.Options.UseTextOptions = True
        Me.lblMainLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblMainLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblMainLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblMainLabel.Location = New System.Drawing.Point(3, 8)
        Me.lblMainLabel.Name = "lblMainLabel"
        Me.lblMainLabel.Size = New System.Drawing.Size(46, 13)
        Me.lblMainLabel.TabIndex = 16
        Me.lblMainLabel.Text = "Direcci�n"
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit1.Location = New System.Drawing.Point(51, 106)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit1.Size = New System.Drawing.Size(278, 20)
        Me.ButtonEdit1.TabIndex = 27
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.Location = New System.Drawing.Point(51, 45)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(278, 20)
        Me.TextEdit1.TabIndex = 28
        '
        'uctAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "uctAddress"
        Me.Size = New System.Drawing.Size(354, 144)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCounty As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTown As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTown As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMainLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboCountry As DevExpress.XtraEditors.ComboBoxEdit
End Class
