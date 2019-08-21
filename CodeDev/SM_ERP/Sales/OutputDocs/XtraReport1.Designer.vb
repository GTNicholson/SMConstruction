<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
  Inherits DevExpress.XtraReports.UI.XtraReport

  'XtraReport overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Designer
  'It can be modified using the Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
    Me.Detail.HeightF = 100.0!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 100.0!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 100.0!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'PageHeader
    '
    Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.PageHeader.HeightF = 100.0!
    Me.PageHeader.Name = "PageHeader"
    '
    'XrTable1
    '
    Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(243.75!, 75.0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(296.875!, 25.0!)
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell7, Me.XrTableCell3})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.CanGrow = False
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.Text = "XrTableCell1"
    Me.XrTableCell1.Weight = 2.7769241118482659R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.CanGrow = False
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.Text = "XrTableCell2"
    Me.XrTableCell2.Weight = 1.0R
    '
    'XrTableCell3
    '
    Me.XrTableCell3.CanGrow = False
    Me.XrTableCell3.Name = "XrTableCell3"
    Me.XrTableCell3.Text = "XrTableCell3"
    Me.XrTableCell3.Weight = 0.5R
    '
    'XrTable2
    '
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(243.75!, 0!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(307.2917!, 33.33333!)
    '
    'XrTableRow2
    '
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Weight = 1.0R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.Text = "XrTableCell4"
    Me.XrTableCell4.Weight = 1.0R
    '
    'XrTableCell5
    '
    Me.XrTableCell5.Name = "XrTableCell5"
    Me.XrTableCell5.Text = "XrTableCell5"
    Me.XrTableCell5.Weight = 1.0R
    '
    'XrTableCell6
    '
    Me.XrTableCell6.Name = "XrTableCell6"
    Me.XrTableCell6.Text = "XrTableCell6"
    Me.XrTableCell6.Weight = 1.0R
    '
    'XrTableCell7
    '
    Me.XrTableCell7.CanGrow = False
    Me.XrTableCell7.Name = "XrTableCell7"
    Me.XrTableCell7.Text = "XrTableCell7"
    Me.XrTableCell7.Weight = 0.5R
    '
    'XtraReport1
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
  Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
End Class
