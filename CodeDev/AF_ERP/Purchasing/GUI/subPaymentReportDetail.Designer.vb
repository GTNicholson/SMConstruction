<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class subPaymentReportDetail
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
    Me.components = New System.ComponentModel.Container()
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrtPOItemUI = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.FilteringUIContext1 = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
    Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
    Me.XrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcAccountingCategory = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcAccountingCenter = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.FilteringUIContext1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrTable1})
    Me.Detail.Dpi = 254.0!
    Me.Detail.HeightF = 116.6283!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable1
    '
    Me.XrTable1.Dpi = 254.0!
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.00008074442!, 0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(1976.0!, 63.5!)
    '
    'XrTableRow3
    '
    Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtPOItemUI})
    Me.XrTableRow3.Dpi = 254.0!
    Me.XrTableRow3.Name = "XrTableRow3"
    Me.XrTableRow3.Weight = 1.0R
    '
    'xrtPOItemUI
    '
    Me.xrtPOItemUI.BackColor = System.Drawing.Color.WhiteSmoke
    Me.xrtPOItemUI.BorderColor = System.Drawing.Color.Black
    Me.xrtPOItemUI.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrtPOItemUI.Dpi = 254.0!
    Me.xrtPOItemUI.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrtPOItemUI.Name = "xrtPOItemUI"
    Me.xrtPOItemUI.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 254.0!)
    Me.xrtPOItemUI.StylePriority.UseBackColor = False
    Me.xrtPOItemUI.StylePriority.UseBorderColor = False
    Me.xrtPOItemUI.StylePriority.UseBorders = False
    Me.xrtPOItemUI.StylePriority.UseFont = False
    Me.xrtPOItemUI.StylePriority.UsePadding = False
    Me.xrtPOItemUI.StylePriority.UseTextAlignment = False
    Me.xrtPOItemUI.Text = "xtcPOIDescUI"
    Me.xrtPOItemUI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    Me.xrtPOItemUI.Weight = 1.0R
    '
    'XrSubreport1
    '
    Me.XrSubreport1.Dpi = 254.0!
    Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 63.5!)
    Me.XrSubreport1.Name = "XrSubreport1"
    Me.XrSubreport1.SizeF = New System.Drawing.SizeF(1976.0!, 53.1283!)
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
    Me.XrControlStyle1.BackColor = System.Drawing.Color.White
    Me.XrControlStyle1.Name = "XrControlStyle1"
    Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    '
    'XrControlStyle2
    '
    Me.XrControlStyle2.BackColor = System.Drawing.Color.WhiteSmoke
    Me.XrControlStyle2.Name = "XrControlStyle2"
    Me.XrControlStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
    '
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrTable2})
    Me.ReportHeader.Dpi = 254.0!
    Me.ReportHeader.HeightF = 207.8334!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrTable2
    '
    Me.XrTable2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable2.Dpi = 254.0!
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 52.91667!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.XrTableRow4})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(1976.0!, 141.6875!)
    Me.XrTable2.StylePriority.UseBorders = False
    '
    'XrTableRow2
    '
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.xtcAccountingCategory})
    Me.XrTableRow2.Dpi = 254.0!
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Weight = 1.0R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.XrTableCell4.Dpi = 254.0!
    Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254.0!)
    Me.XrTableCell4.StylePriority.UseBorders = False
    Me.XrTableCell4.StylePriority.UseFont = False
    Me.XrTableCell4.StylePriority.UsePadding = False
    Me.XrTableCell4.Text = "Categoría Contable"
    Me.XrTableCell4.Weight = 1.592111943736082R
    '
    'xtcAccountingCategory
    '
    Me.xtcAccountingCategory.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.xtcAccountingCategory.Dpi = 254.0!
    Me.xtcAccountingCategory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xtcAccountingCategory.Name = "xtcAccountingCategory"
    Me.xtcAccountingCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254.0!)
    Me.xtcAccountingCategory.StylePriority.UseBorders = False
    Me.xtcAccountingCategory.StylePriority.UseFont = False
    Me.xtcAccountingCategory.StylePriority.UsePadding = False
    Me.xtcAccountingCategory.Text = "XrTableCell2"
    Me.xtcAccountingCategory.Weight = 2.4130970463165813R
    '
    'XrTableRow4
    '
    Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.xtcAccountingCenter})
    Me.XrTableRow4.Dpi = 254.0!
    Me.XrTableRow4.Name = "XrTableRow4"
    Me.XrTableRow4.Weight = 1.0R
    '
    'XrTableCell5
    '
    Me.XrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.XrTableCell5.Dpi = 254.0!
    Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell5.Name = "XrTableCell5"
    Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254.0!)
    Me.XrTableCell5.StylePriority.UseBorders = False
    Me.XrTableCell5.StylePriority.UseFont = False
    Me.XrTableCell5.StylePriority.UsePadding = False
    Me.XrTableCell5.Text = "Centro de Costo"
    Me.XrTableCell5.Weight = 1.5921118822087017R
    '
    'xtcAccountingCenter
    '
    Me.xtcAccountingCenter.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.xtcAccountingCenter.Dpi = 254.0!
    Me.xtcAccountingCenter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xtcAccountingCenter.Name = "xtcAccountingCenter"
    Me.xtcAccountingCenter.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254.0!)
    Me.xtcAccountingCenter.StylePriority.UseBorders = False
    Me.xtcAccountingCenter.StylePriority.UseFont = False
    Me.xtcAccountingCenter.StylePriority.UsePadding = False
    Me.xtcAccountingCenter.Text = "xtcAccountingCenter"
    Me.xtcAccountingCenter.Weight = 2.4130971078439618R
    '
    'XrPanel1
    '
    Me.XrPanel1.Dpi = 254.0!
    Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrPanel1.Name = "XrPanel1"
    Me.XrPanel1.SizeF = New System.Drawing.SizeF(1976.0!, 52.91667!)
    '
    'subPaymentReportDetail
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Dpi = 254.0!
    Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
    Me.PageHeight = 1794
    Me.PageWidth = 1976
    Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
    Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.SnapGridSize = 25.0!
    Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1, Me.XrControlStyle2})
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.FilteringUIContext1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents FilteringUIContext1 As DevExpress.Utils.Filtering.FilteringUIContext
  Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
  Friend WithEvents XrControlStyle2 As DevExpress.XtraReports.UI.XRControlStyle
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcAccountingCategory As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcAccountingCenter As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtPOItemUI As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
End Class
