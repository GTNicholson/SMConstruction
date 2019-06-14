<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class srepMaterials
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
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
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
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
    Me.Detail.HeightF = 26.04167!
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
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.ReportHeader.HeightF = 48.95833!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrTable1
    '
    Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.91667!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(233.3334!, 26.04166!)
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.CanGrow = False
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.Text = "XrTableCell1"
    Me.XrTableCell1.Weight = 1.0R
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
    Me.XrTableCell3.Weight = 1.0R
    '
    'XrTable2
    '
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(233.3334!, 26.04167!)
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
    'srepMaterials
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Margins = New System.Drawing.Printing.Margins(100, 515, 100, 100)
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
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
End Class
