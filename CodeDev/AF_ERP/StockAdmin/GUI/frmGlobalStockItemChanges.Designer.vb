<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGlobalStockItemChanges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGlobalStockItemChanges))
        Me.btnGenerateDescription = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGenrateStockCode = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSetObsolete = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'btnGenerateDescription
        '
        Me.btnGenerateDescription.Location = New System.Drawing.Point(5, 12)
        Me.btnGenerateDescription.Name = "btnGenerateDescription"
        Me.btnGenerateDescription.Size = New System.Drawing.Size(209, 23)
        Me.btnGenerateDescription.TabIndex = 0
        Me.btnGenerateDescription.Text = "Generar Descripción"
        '
        'btnGenrateStockCode
        '
        Me.btnGenrateStockCode.Location = New System.Drawing.Point(5, 52)
        Me.btnGenrateStockCode.Name = "btnGenrateStockCode"
        Me.btnGenrateStockCode.Size = New System.Drawing.Size(209, 23)
        Me.btnGenrateStockCode.TabIndex = 1
        Me.btnGenrateStockCode.Text = "Generar Códigos"
        '
        'btnSetObsolete
        '
        Me.btnSetObsolete.Location = New System.Drawing.Point(5, 92)
        Me.btnSetObsolete.Name = "btnSetObsolete"
        Me.btnSetObsolete.Size = New System.Drawing.Size(209, 23)
        Me.btnSetObsolete.TabIndex = 2
        Me.btnSetObsolete.Text = "Obsoleto"
        '
        'frmGlobalStockItemChanges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 140)
        Me.Controls.Add(Me.btnSetObsolete)
        Me.Controls.Add(Me.btnGenrateStockCode)
        Me.Controls.Add(Me.btnGenerateDescription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGlobalStockItemChanges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambios Globales"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerateDescription As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnGenrateStockCode As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnSetObsolete As DevExpress.XtraEditors.SimpleButton
End Class
