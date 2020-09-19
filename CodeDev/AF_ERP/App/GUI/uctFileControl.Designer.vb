<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctFileControl
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.grdFiles = New DevExpress.XtraGrid.GridControl()
    Me.gvFiles = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcFileName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcDescription = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.repDescription = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
    Me.gcDateReceived = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcOpen = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.gcIncludeInPack = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar1 = New DevExpress.XtraBars.Bar()
    Me.bbtnOpenFolder = New DevExpress.XtraBars.BarButtonItem()
    Me.bbtnSearch = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.grdFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdFiles
        '
        Me.grdFiles.AllowDrop = True
        Me.grdFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFiles.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdFiles.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdFiles.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdFiles.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdFiles.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdFiles.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdFiles.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdFiles.Location = New System.Drawing.Point(0, 33)
        Me.grdFiles.MainView = Me.gvFiles
        Me.grdFiles.Margin = New System.Windows.Forms.Padding(5)
        Me.grdFiles.Name = "grdFiles"
        Me.grdFiles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemButtonEdit1, Me.repDescription})
        Me.grdFiles.Size = New System.Drawing.Size(499, 114)
        Me.grdFiles.TabIndex = 1
        Me.grdFiles.UseEmbeddedNavigator = True
        Me.grdFiles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFiles})
        '
        'gvFiles
        '
        Me.gvFiles.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvFiles.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvFiles.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvFiles.Appearance.EvenRow.Options.UseFont = True
        Me.gvFiles.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvFiles.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvFiles.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvFiles.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvFiles.Appearance.OddRow.Options.UseBackColor = True
        Me.gvFiles.Appearance.OddRow.Options.UseFont = True
        Me.gvFiles.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gvFiles.Appearance.Row.Options.UseFont = True
        Me.gvFiles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFileName, Me.gcDescription, Me.gcDateReceived, Me.gcOpen, Me.gcIncludeInPack})
        Me.gvFiles.GridControl = Me.grdFiles
        Me.gvFiles.Name = "gvFiles"
        Me.gvFiles.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvFiles.OptionsView.EnableAppearanceEvenRow = True
        Me.gvFiles.OptionsView.EnableAppearanceOddRow = True
        Me.gvFiles.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gvFiles.OptionsView.ShowGroupPanel = False
        '
        'gcFileName
        '
        Me.gcFileName.Caption = "Nombre del Archivo"
        Me.gcFileName.FieldName = "FileName"
        Me.gcFileName.Name = "gcFileName"
        Me.gcFileName.OptionsColumn.ReadOnly = True
        Me.gcFileName.Visible = True
        Me.gcFileName.VisibleIndex = 0
        Me.gcFileName.Width = 142
        '
        'gcDescription
        '
        Me.gcDescription.Caption = "Descripción"
        Me.gcDescription.ColumnEdit = Me.repDescription
        Me.gcDescription.FieldName = "Description"
        Me.gcDescription.Name = "gcDescription"
        Me.gcDescription.Visible = True
        Me.gcDescription.VisibleIndex = 2
        Me.gcDescription.Width = 200
        '
        'repDescription
        '
        Me.repDescription.AutoHeight = False
        Me.repDescription.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDescription.Name = "repDescription"
        Me.repDescription.ShowIcon = False
        '
        'gcDateReceived
        '
        Me.gcDateReceived.Caption = "Tipo"
        Me.gcDateReceived.FieldName = "FileType"
        Me.gcDateReceived.Name = "gcDateReceived"
        Me.gcDateReceived.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.gcDateReceived.Visible = True
        Me.gcDateReceived.VisibleIndex = 1
        Me.gcDateReceived.Width = 46
        '
        'gcOpen
        '
        Me.gcOpen.Caption = "Abrir"
        Me.gcOpen.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.gcOpen.Name = "gcOpen"
        Me.gcOpen.Visible = True
        Me.gcOpen.VisibleIndex = 4
        Me.gcOpen.Width = 44
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'gcIncludeInPack
        '
        Me.gcIncludeInPack.Caption = "Pub."
        Me.gcIncludeInPack.FieldName = "IncludeInPack"
        Me.gcIncludeInPack.Name = "gcIncludeInPack"
        Me.gcIncludeInPack.Visible = True
        Me.gcIncludeInPack.VisibleIndex = 3
        Me.gcIncludeInPack.Width = 49
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtnOpenFolder, Me.bbtnSearch})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnOpenFolder), New DevExpress.XtraBars.LinkPersistInfo(Me.bbtnSearch)})
        Me.Bar1.Text = "Tools"
        '
        'bbtnOpenFolder
        '
        Me.bbtnOpenFolder.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnOpenFolder.Caption = "Abrir Carpeta"
        Me.bbtnOpenFolder.Id = 0
        Me.bbtnOpenFolder.Name = "bbtnOpenFolder"
        '
        'bbtnSearch
        '
        Me.bbtnSearch.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.bbtnSearch.Caption = "Buscar Nuevo"
        Me.bbtnSearch.Id = 1
        Me.bbtnSearch.Name = "bbtnSearch"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(499, 33)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 147)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(499, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 33)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 114)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(499, 33)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 114)
        '
        'uctFileControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdFiles)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "uctFileControl"
        Me.Size = New System.Drawing.Size(499, 147)
        CType(Me.grdFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdFiles As DevExpress.XtraGrid.GridControl
  Friend WithEvents gvFiles As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcFileName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcDescription As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents repDescription As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
  Friend WithEvents gcDateReceived As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents gcOpen As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents gcIncludeInPack As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
  Friend WithEvents bbtnOpenFolder As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents bbtnSearch As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
