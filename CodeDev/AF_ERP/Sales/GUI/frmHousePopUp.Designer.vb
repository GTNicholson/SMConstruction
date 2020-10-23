<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHousePopUp
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
        Me.btnGenerate = New DevExpress.XtraEditors.SimpleButton()
        Me.UctHouseTypeOptions1 = New AgroForestal.uctHouseTypeOptions()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(91, 241)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generar"
        '
        'UctHouseTypeOptions1
        '
        Me.UctHouseTypeOptions1.Location = New System.Drawing.Point(12, 12)
        Me.UctHouseTypeOptions1.Name = "UctHouseTypeOptions1"
        Me.UctHouseTypeOptions1.Size = New System.Drawing.Size(224, 223)
        Me.UctHouseTypeOptions1.TabIndex = 0
        '
        'frmHousePopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 276)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.UctHouseTypeOptions1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmHousePopUp"
        Me.Text = "Lista de Opciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UctHouseTypeOptions1 As uctHouseTypeOptions
    Friend WithEvents btnGenerate As DevExpress.XtraEditors.SimpleButton
End Class
