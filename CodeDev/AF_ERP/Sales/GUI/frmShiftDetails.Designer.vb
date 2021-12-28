<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShiftDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShiftDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdShiftDetails = New DevExpress.XtraGrid.GridControl()
        Me.gvShiftDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcDayWeek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoTime = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.RepositoryItemTimeSpanEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit()
        Me.Panel1.SuspendLayout()
        CType(Me.grdShiftDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvShiftDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoTime.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeSpanEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdShiftDetails)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 237)
        Me.Panel1.TabIndex = 0
        '
        'grdShiftDetails
        '
        Me.grdShiftDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdShiftDetails.Location = New System.Drawing.Point(0, 0)
        Me.grdShiftDetails.MainView = Me.gvShiftDetails
        Me.grdShiftDetails.Name = "grdShiftDetails"
        Me.grdShiftDetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoTime, Me.RepositoryItemTimeEdit1, Me.RepositoryItemTimeSpanEdit1, Me.RepositoryItemTimeEdit2})
        Me.grdShiftDetails.Size = New System.Drawing.Size(497, 237)
        Me.grdShiftDetails.TabIndex = 0
        Me.grdShiftDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvShiftDetails})
        '
        'gvShiftDetails
        '
        Me.gvShiftDetails.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvShiftDetails.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.gvShiftDetails.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvShiftDetails.Appearance.EvenRow.Options.UseFont = True
        Me.gvShiftDetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.gvShiftDetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvShiftDetails.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvShiftDetails.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.gvShiftDetails.Appearance.OddRow.Options.UseBackColor = True
        Me.gvShiftDetails.Appearance.OddRow.Options.UseFont = True
        Me.gvShiftDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcDayWeek, Me.GridColumn2, Me.GridColumn3})
        Me.gvShiftDetails.GridControl = Me.grdShiftDetails
        Me.gvShiftDetails.Name = "gvShiftDetails"
        Me.gvShiftDetails.OptionsView.EnableAppearanceEvenRow = True
        Me.gvShiftDetails.OptionsView.EnableAppearanceOddRow = True
        Me.gvShiftDetails.OptionsView.ShowDetailButtons = False
        Me.gvShiftDetails.OptionsView.ShowGroupPanel = False
        '
        'gcDayWeek
        '
        Me.gcDayWeek.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.gcDayWeek.AppearanceCell.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.gcDayWeek.AppearanceCell.Options.UseBackColor = True
        Me.gcDayWeek.AppearanceCell.Options.UseFont = True
        Me.gcDayWeek.AppearanceCell.Options.UseTextOptions = True
        Me.gcDayWeek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDayWeek.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcDayWeek.AppearanceHeader.Options.UseTextOptions = True
        Me.gcDayWeek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDayWeek.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcDayWeek.Caption = "Día"
        Me.gcDayWeek.FieldName = "gcDayWeek"
        Me.gcDayWeek.Name = "gcDayWeek"
        Me.gcDayWeek.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.gcDayWeek.Visible = True
        Me.gcDayWeek.VisibleIndex = 0
        Me.gcDayWeek.Width = 137
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.Caption = "Hora Inicio"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTimeEdit2
        Me.GridColumn2.DisplayFormat.FormatString = "T"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "StartTime"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 169
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeEdit2.DisplayFormat.FormatString = "G"
        Me.RepositoryItemTimeEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeEdit2.EditFormat.FormatString = "G"
        Me.RepositoryItemTimeEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        Me.RepositoryItemTimeEdit2.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.Caption = "Hora Fin"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTimeEdit2
        Me.GridColumn3.DisplayFormat.FormatString = "T"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "EndTime"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 172
        '
        'repoTime
        '
        Me.repoTime.AutoHeight = False
        Me.repoTime.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoTime.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repoTime.CalendarTimeProperties.EditFormat.FormatString = "d"
        Me.repoTime.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repoTime.DisplayFormat.FormatString = "g"
        Me.repoTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repoTime.EditFormat.FormatString = "g"
        Me.repoTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repoTime.Name = "repoTime"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeEdit1.DisplayFormat.FormatString = "T"
        Me.RepositoryItemTimeEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeEdit1.EditFormat.FormatString = "T"
        Me.RepositoryItemTimeEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemTimeSpanEdit1
        '
        Me.RepositoryItemTimeSpanEdit1.AutoHeight = False
        Me.RepositoryItemTimeSpanEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeSpanEdit1.DisplayFormat.FormatString = "G"
        Me.RepositoryItemTimeSpanEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeSpanEdit1.EditFormat.FormatString = "G"
        Me.RepositoryItemTimeSpanEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeSpanEdit1.Name = "RepositoryItemTimeSpanEdit1"
        '
        'frmShiftDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 237)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShiftDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horario Laboral"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdShiftDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvShiftDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoTime.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeSpanEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grdShiftDetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvShiftDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcDayWeek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoTime As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemTimeSpanEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
End Class
