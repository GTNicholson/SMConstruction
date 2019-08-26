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
    Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrtcStockCode = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtcDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtcQuantity = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'XrTable2
    '
    Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(819.9495!, 26.04167!)
    Me.XrTable2.StylePriority.UseBorders = False
    Me.XrTable2.StylePriority.UseFont = False
    '
    'XrTableRow2
    '
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtcStockCode, Me.xrtcDescription, Me.xrtcQuantity, Me.XrTableCell4, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell13, Me.XrTableCell15, Me.XrTableCell17})
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Weight = 1.0R
    '
    'xrtcStockCode
    '
    Me.xrtcStockCode.Name = "xrtcStockCode"
    Me.xrtcStockCode.StylePriority.UseTextAlignment = False
    Me.xrtcStockCode.Text = "xrtcStockCode"
    Me.xrtcStockCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtcStockCode.Weight = 0.7963594884351135R
    '
    'xrtcDescription
    '
    Me.xrtcDescription.Name = "xrtcDescription"
    Me.xrtcDescription.Text = "xrtcDescription"
    Me.xrtcDescription.Weight = 1.2209352900935859R
    '
    'xrtcQuantity
    '
    Me.xrtcQuantity.Name = "xrtcQuantity"
    Me.xrtcQuantity.Text = "xrtcQuantity"
    Me.xrtcQuantity.Weight = 0.55063066036282382R
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 7.0!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 2.0!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.ReportHeader.HeightF = 27.08333!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrTable1
    '
    Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
    Me.XrTable1.BackColor = System.Drawing.Color.Black
    Me.XrTable1.BorderColor = System.Drawing.Color.White
    Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTable1.ForeColor = System.Drawing.Color.White
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.041667!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(819.9496!, 26.04166!)
    Me.XrTable1.StylePriority.UseBackColor = False
    Me.XrTable1.StylePriority.UseBorderColor = False
    Me.XrTable1.StylePriority.UseBorders = False
    Me.XrTable1.StylePriority.UseFont = False
    Me.XrTable1.StylePriority.UseForeColor = False
    Me.XrTable1.StylePriority.UseTextAlignment = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell12, Me.XrTableCell14, Me.XrTableCell16})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.CanGrow = False
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.Text = "Codigo"
    Me.XrTableCell1.Weight = 0.79635945603302316R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.CanGrow = False
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.Text = "Descripcion"
    Me.XrTableCell2.Weight = 1.2209352840482985R
    '
    'XrTableCell3
    '
    Me.XrTableCell3.CanGrow = False
    Me.XrTableCell3.Name = "XrTableCell3"
    Me.XrTableCell3.Text = "Piezas Un"
    Me.XrTableCell3.Weight = 0.550631256404663R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.Text = "XrTableCell4"
    Me.XrTableCell4.Weight = 0.71140241521868575R
    '
    'XrTableCell5
    '
    Me.XrTableCell5.CanGrow = False
    Me.XrTableCell5.Name = "XrTableCell5"
    Me.XrTableCell5.Text = "Total Piezas"
    Me.XrTableCell5.Weight = 0.71140249312270232R
    '
    'XrTableCell6
    '
    Me.XrTableCell6.CanGrow = False
    Me.XrTableCell6.Name = "XrTableCell6"
    Me.XrTableCell6.Text = "Grosor N (cm)"
    Me.XrTableCell6.Weight = 0.85207864119849752R
    '
    'XrTableCell7
    '
    Me.XrTableCell7.CanGrow = False
    Me.XrTableCell7.Name = "XrTableCell7"
    Me.XrTableCell7.Text = "Ancho N (cm)"
    Me.XrTableCell7.Weight = 0.831982080157146R
    '
    'XrTableCell8
    '
    Me.XrTableCell8.CanGrow = False
    Me.XrTableCell8.Name = "XrTableCell8"
    Me.XrTableCell8.Text = "Largo N (cm)"
    Me.XrTableCell8.Weight = 0.7716918818649755R
    '
    'XrTableCell9
    '
    Me.XrTableCell9.Name = "XrTableCell9"
    Me.XrTableCell9.Text = "XrTableCell9"
    Me.XrTableCell9.Weight = 0.85207922792806079R
    '
    'XrTableCell10
    '
    Me.XrTableCell10.Name = "XrTableCell10"
    Me.XrTableCell10.Text = "XrTableCell10"
    Me.XrTableCell10.Weight = 0.831982077798201R
    '
    'XrTableCell11
    '
    Me.XrTableCell11.Name = "XrTableCell11"
    Me.XrTableCell11.Text = "XrTableCell11"
    Me.XrTableCell11.Weight = 0.77169202572210416R
    '
    'XrTableCell12
    '
    Me.XrTableCell12.CanGrow = False
    Me.XrTableCell12.Name = "XrTableCell12"
    Me.XrTableCell12.Text = "PT Neto"
    Me.XrTableCell12.Weight = 0.7716918818649755R
    '
    'XrTableCell13
    '
    Me.XrTableCell13.Name = "XrTableCell13"
    Me.XrTableCell13.Text = "XrTableCell13"
    Me.XrTableCell13.Weight = 0.77169202572210416R
    '
    'XrTableCell14
    '
    Me.XrTableCell14.CanGrow = False
    Me.XrTableCell14.Name = "XrTableCell14"
    Me.XrTableCell14.Text = "Especie"
    Me.XrTableCell14.Weight = 0.70135406974793435R
    '
    'XrTableCell15
    '
    Me.XrTableCell15.Name = "XrTableCell15"
    Me.XrTableCell15.Text = "XrTableCell15"
    Me.XrTableCell15.Weight = 0.70135362685472213R
    '
    'XrTableCell16
    '
    Me.XrTableCell16.CanGrow = False
    Me.XrTableCell16.Name = "XrTableCell16"
    Me.XrTableCell16.Text = "Calidad"
    Me.XrTableCell16.Weight = 0.70135406974793435R
    '
    'XrTableCell17
    '
    Me.XrTableCell17.Name = "XrTableCell17"
    Me.XrTableCell17.Text = "XrTableCell17"
    Me.XrTableCell17.Weight = 0.70135362685472213R
    '
    'srepMaterials
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Margins = New System.Drawing.Printing.Margins(0, 25, 7, 2)
    Me.Version = "17.1"
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtcStockCode As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtcDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtcQuantity As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
End Class
