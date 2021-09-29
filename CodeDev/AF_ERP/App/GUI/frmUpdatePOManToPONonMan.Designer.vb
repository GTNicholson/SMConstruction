<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePOManToPONonMan
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPONum = New DevExpress.XtraEditors.TextEdit()
        Me.btnSOPItemPicker = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblItem = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpdateNonManToMan = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtPONum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSOPItemPicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "PO Num."
        '
        'txtPONum
        '
        Me.txtPONum.Location = New System.Drawing.Point(71, 18)
        Me.txtPONum.Name = "txtPONum"
        Me.txtPONum.Size = New System.Drawing.Size(190, 20)
        Me.txtPONum.TabIndex = 1
        '
        'btnSOPItemPicker
        '
        Me.btnSOPItemPicker.Location = New System.Drawing.Point(360, 18)
        Me.btnSOPItemPicker.Name = "btnSOPItemPicker"
        Me.btnSOPItemPicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnSOPItemPicker.Size = New System.Drawing.Size(192, 20)
        Me.btnSOPItemPicker.TabIndex = 2
        '
        'lblItem
        '
        Me.lblItem.Location = New System.Drawing.Point(309, 21)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(45, 13)
        Me.lblItem.TabIndex = 3
        Me.lblItem.Text = "SOP Item"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(415, 74)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(137, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Manu To NonMan"
        '
        'btnUpdateNonManToMan
        '
        Me.btnUpdateNonManToMan.Location = New System.Drawing.Point(415, 74)
        Me.btnUpdateNonManToMan.Name = "btnUpdateNonManToMan"
        Me.btnUpdateNonManToMan.Size = New System.Drawing.Size(137, 23)
        Me.btnUpdateNonManToMan.TabIndex = 5
        Me.btnUpdateNonManToMan.Text = "Update Non Manu To Manu"
        '
        'frmUpdatePOManToPONonMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 115)
        Me.Controls.Add(Me.btnUpdateNonManToMan)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnSOPItemPicker)
        Me.Controls.Add(Me.txtPONum)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmUpdatePOManToPONonMan"
        Me.Text = "frmUpdatePOManToPONonMan"
        CType(Me.txtPONum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSOPItemPicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPONum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSOPItemPicker As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdateNonManToMan As DevExpress.XtraEditors.SimpleButton
End Class
