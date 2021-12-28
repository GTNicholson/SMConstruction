<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repPOIADetail_bk
  Inherits DevExpress.XtraReports.UI.XtraReport

  'XtraReport overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrPOIADesc = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
    Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.Detail.Dpi = 254.0!
    Me.Detail.HeightF = 56.62082!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    Me.Detail.StylePriority.UseBorderColor = False
    Me.Detail.StylePriority.UseBorders = False
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable1
    '
    Me.XrTable1.BorderColor = System.Drawing.Color.Transparent
    Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrTable1.Dpi = 254.0!
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTable1.KeepTogether = True
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 0, 254.0!)
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(1976.0!, 56.62082!)
    Me.XrTable1.StylePriority.UseBorderColor = False
    Me.XrTable1.StylePriority.UsePadding = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrPOIADesc})
    Me.XrTableRow1.Dpi = 254.0!
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 0.891666574578528R
    '
    'xrPOIADesc
    '
    Me.xrPOIADesc.Dpi = 254.0!
    Me.xrPOIADesc.Font = New System.Drawing.Font("Times New Roman", 8.75!)
    Me.xrPOIADesc.Name = "xrPOIADesc"
    Me.xrPOIADesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 5, 5, 5, 254.0!)
    Me.xrPOIADesc.StylePriority.UsePadding = False
    Me.xrPOIADesc.Weight = 1.0446883764648594R
    '
    'TopMargin
    '
    Me.TopMargin.Dpi = 254.0!
    Me.TopMargin.HeightF = 0!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.Dpi = 254.0!
    Me.BottomMargin.HeightF = 0!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrControlStyle1
    '
    Me.XrControlStyle1.BackColor = System.Drawing.Color.WhiteSmoke
    Me.XrControlStyle1.Name = "XrControlStyle1"
    Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    '
    'ReportFooter
    '
    Me.ReportFooter.Dpi = 254.0!
    Me.ReportFooter.HeightF = 0!
    Me.ReportFooter.Name = "ReportFooter"
    '
    'repPOIADetail_bk
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
    Me.Dpi = 254.0!
    Me.Font = New System.Drawing.Font("Arial", 9.75!)
    Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
    Me.PageHeight = 2969
    Me.PageWidth = 1976
    Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
    Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.SnapGridSize = 25.0!
    Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrPOIADesc As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
