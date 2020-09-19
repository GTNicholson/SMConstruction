<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repStdAndOverTime
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repStdAndOverTime))
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xtcDate = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtStartTime = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtExitTime = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtTotalHour = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtWONo = New DevExpress.XtraReports.UI.XRTableCell()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
    Me.Detail.HeightF = 100.0!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 4.0!
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
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrPictureBox1, Me.XrLabel1})
    Me.ReportHeader.HeightF = 180.2083!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrPictureBox1
    '
    Me.XrPictureBox1.BorderWidth = 0!
    Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
    Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
    Me.XrPictureBox1.Name = "XrPictureBox1"
    Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(249.2566!, 66.21494!)
    Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    Me.XrPictureBox1.StylePriority.UseBorderWidth = False
    '
    'XrLabel1
    '
    Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(291.9167!, 24.58334!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(364.5834!, 32.50662!)
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "REPORTE DE JORNADA LABORAL"
    '
    'PageHeader
    '
    Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrTable2})
    Me.PageHeader.HeightF = 100.0!
    Me.PageHeader.Name = "PageHeader"
    '
    'XrTable1
    '
    Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 120.2083!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(570.8333!, 50.0!)
    Me.XrTable1.StylePriority.UseBorders = False
    Me.XrTable1.StylePriority.UseTextAlignment = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell13, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.Text = "Cod. Trab."
    Me.XrTableCell1.Weight = 1.0R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.Text = "Sueldo Básico"
    Me.XrTableCell2.Weight = 1.0R
    '
    'XrTableCell3
    '
    Me.XrTableCell3.Name = "XrTableCell3"
    Me.XrTableCell3.Text = "Horas Extras Totales"
    Me.XrTableCell3.Weight = 1.3541665649414063R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.Text = "Centro de Costo"
    Me.XrTableCell4.Weight = 1.3541665649414063R
    '
    'XrTableRow2
    '
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell14, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8})
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Weight = 1.0R
    '
    'XrTableCell5
    '
    Me.XrTableCell5.Name = "XrTableCell5"
    Me.XrTableCell5.Weight = 1.0R
    '
    'XrTableCell6
    '
    Me.XrTableCell6.Name = "XrTableCell6"
    Me.XrTableCell6.Weight = 1.0R
    '
    'XrTableCell7
    '
    Me.XrTableCell7.Name = "XrTableCell7"
    Me.XrTableCell7.Weight = 1.3541665649414063R
    '
    'XrTableCell8
    '
    Me.XrTableCell8.Name = "XrTableCell8"
    Me.XrTableCell8.Weight = 1.3541665649414063R
    '
    'XrTable2
    '
    Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 75.0!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(606.25!, 25.0!)
    Me.XrTable2.StylePriority.UseBorders = False
    Me.XrTable2.StylePriority.UseTextAlignment = False
    Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow3
    '
    Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell15, Me.XrTableCell12})
    Me.XrTableRow3.Name = "XrTableRow3"
    Me.XrTableRow3.Weight = 1.0R
    '
    'XrTableCell9
    '
    Me.XrTableCell9.Name = "XrTableCell9"
    Me.XrTableCell9.Text = "Fecha"
    Me.XrTableCell9.Weight = 1.0R
    '
    'XrTableCell10
    '
    Me.XrTableCell10.Name = "XrTableCell10"
    Me.XrTableCell10.Text = "Hora Entrada"
    Me.XrTableCell10.Weight = 1.0R
    '
    'XrTableCell11
    '
    Me.XrTableCell11.Name = "XrTableCell11"
    Me.XrTableCell11.Text = "Hora Salida"
    Me.XrTableCell11.Weight = 1.3541665649414063R
    '
    'XrTableCell12
    '
    Me.XrTableCell12.Name = "XrTableCell12"
    Me.XrTableCell12.Text = "Cant. H.Extras"
    Me.XrTableCell12.Weight = 1.3541665649414063R
    '
    'XrLabel2
    '
    Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(234.625!, 0!)
    Me.XrLabel2.Name = "XrLabel2"
    Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel2.SizeF = New System.Drawing.SizeF(518.75!, 32.50662!)
    Me.XrLabel2.StylePriority.UseFont = False
    Me.XrLabel2.Text = "DETALLE DE HORA EXTRA"
    '
    'XrTableCell13
    '
    Me.XrTableCell13.Name = "XrTableCell13"
    Me.XrTableCell13.Text = "Trabajador"
    Me.XrTableCell13.Weight = 1.0R
    '
    'XrTableCell14
    '
    Me.XrTableCell14.Name = "XrTableCell14"
    Me.XrTableCell14.Weight = 1.0R
    '
    'XrTable3
    '
    Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable3.Name = "XrTable3"
    Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
    Me.XrTable3.SizeF = New System.Drawing.SizeF(606.25!, 25.0!)
    Me.XrTable3.StylePriority.UseBorders = False
    Me.XrTable3.StylePriority.UseTextAlignment = False
    Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow4
    '
    Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcDate, Me.xrtStartTime, Me.xrtExitTime, Me.xrtWONo, Me.xrtTotalHour})
    Me.XrTableRow4.Name = "XrTableRow4"
    Me.XrTableRow4.Weight = 1.0R
    '
    'xtcDate
    '
    Me.xtcDate.Name = "xtcDate"
    Me.xtcDate.Weight = 1.0R
    '
    'xrtStartTime
    '
    Me.xrtStartTime.Name = "xrtStartTime"
    Me.xrtStartTime.Weight = 1.0R
    '
    'xrtExitTime
    '
    Me.xrtExitTime.Name = "xrtExitTime"
    Me.xrtExitTime.Weight = 1.3541665649414063R
    '
    'xrtTotalHour
    '
    Me.xrtTotalHour.Name = "xrtTotalHour"
    Me.xrtTotalHour.Weight = 1.3541665649414063R
    '
    'XrTableCell15
    '
    Me.XrTableCell15.Name = "XrTableCell15"
    Me.XrTableCell15.Text = "O.T #"
    Me.XrTableCell15.Weight = 1.3541665649414063R
    '
    'xrtWONo
    '
    Me.xrtWONo.Name = "xrtWONo"
    Me.xrtWONo.Weight = 1.3541665649414063R
    '
    'repStdAndOverTime
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
    Me.Landscape = True
    Me.Margins = New System.Drawing.Printing.Margins(31, 100, 4, 100)
    Me.PageHeight = 850
    Me.PageWidth = 1100
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xtcDate As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtStartTime As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtExitTime As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtWONo As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtTotalHour As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
  Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
End Class
