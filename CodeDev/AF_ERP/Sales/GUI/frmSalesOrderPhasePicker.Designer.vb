<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderPhasePicker
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
        Me.grdSalesOrderPhases = New DevExpress.XtraGrid.GridControl()
        Me.gvSalesOrderPhase = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepbtnSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.grdSalesOrderPhases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSalesOrderPhase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdSalesOrderPhases
        '
        Me.grdSalesOrderPhases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSalesOrderPhases.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdSalesOrderPhases.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdSalesOrderPhases.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdSalesOrderPhases.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdSalesOrderPhases.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdSalesOrderPhases.Location = New System.Drawing.Point(0, 0)
        Me.grdSalesOrderPhases.MainView = Me.gvSalesOrderPhase
        Me.grdSalesOrderPhases.Name = "grdSalesOrderPhases"
        Me.grdSalesOrderPhases.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepbtnSelect, Me.RepositoryItemDateEdit1})
        Me.grdSalesOrderPhases.Size = New System.Drawing.Size(876, 358)
        Me.grdSalesOrderPhases.TabIndex = 5
        Me.grdSalesOrderPhases.UseEmbeddedNavigator = True
        Me.grdSalesOrderPhases.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesOrderPhase})
        '
        'gvSalesOrderPhase
        '
        Me.gvSalesOrderPhase.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvSalesOrderPhase.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrderPhase.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvSalesOrderPhase.Appearance.EvenRow.Options.UseFont = True
        Me.gvSalesOrderPhase.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvSalesOrderPhase.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSalesOrderPhase.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvSalesOrderPhase.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrderPhase.Appearance.OddRow.Options.UseBackColor = True
        Me.gvSalesOrderPhase.Appearance.OddRow.Options.UseFont = True
        Me.gvSalesOrderPhase.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvSalesOrderPhase.Appearance.Row.Options.UseFont = True
        Me.gvSalesOrderPhase.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn4, Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.GridColumn7, Me.GridColumn3})
        Me.gvSalesOrderPhase.GridControl = Me.grdSalesOrderPhases
        Me.gvSalesOrderPhase.Name = "gvSalesOrderPhase"
        Me.gvSalesOrderPhase.OptionsView.EnableAppearanceEvenRow = True
        Me.gvSalesOrderPhase.OptionsView.EnableAppearanceOddRow = True
        Me.gvSalesOrderPhase.OptionsView.ShowAutoFilterRow = True
        Me.gvSalesOrderPhase.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ref. Etapa"
        Me.GridColumn6.ColumnEdit = Me.RepbtnSelect
        Me.GridColumn6.FieldName = "SOPJobNo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 102
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "# Fase"
        Me.GridColumn4.FieldName = "PhaseNumber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "TotalPrice"
        Me.GridColumn1.FieldName = "TotalPrice"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Requerida"
        Me.GridColumn2.FieldName = "DateRequired"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 272
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "SalesOrderPhaseID"
        Me.GridColumn5.FieldName = "SalesOrderPhaseID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 108
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Proyecto"
        Me.GridColumn7.FieldName = "ProjectName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 107
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "CompanyName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        '
        'RepbtnSelect
        '
        Me.RepbtnSelect.AutoHeight = False
        Me.RepbtnSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepbtnSelect.Name = "RepbtnSelect"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'frmSalesOrderPhasePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 358)
        Me.Controls.Add(Me.grdSalesOrderPhases)
        Me.Name = "frmSalesOrderPhasePicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Order Phase Picker"
        CType(Me.grdSalesOrderPhases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSalesOrderPhase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdSalesOrderPhases As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSalesOrderPhase As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepbtnSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
