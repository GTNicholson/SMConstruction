<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repPaySlip
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repPaySlip))
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrtcItemDate = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcStartTime = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcEndTime = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcStandardHours = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcStdPayment = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcOverTimeHours = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcOverTimePayment = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcTotalPayment = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlStartDate = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlFinishDate = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlEmployeeName = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlPeriodType = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlType = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlPeriodStartDate = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
    Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
    Me.Detail.HeightF = 23.95833!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable2
    '
    Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable2.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(745.0!, 23.95833!)
    Me.XrTable2.StylePriority.UseBorders = False
    Me.XrTable2.StylePriority.UseFont = False
    Me.XrTable2.StylePriority.UseTextAlignment = False
    Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow2
    '
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtcItemDate, Me.xtcStartTime, Me.xtcEndTime, Me.xtcStandardHours, Me.xtcStdPayment, Me.xtcOverTimeHours, Me.xtcOverTimePayment, Me.xtcTotalPayment})
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Weight = 1.0R
    '
    'xrtcItemDate
    '
    Me.xrtcItemDate.Name = "xrtcItemDate"
    Me.xrtcItemDate.Weight = 1.0R
    '
    'xtcStartTime
    '
    Me.xtcStartTime.Name = "xtcStartTime"
    Me.xtcStartTime.Weight = 1.1578947266977586R
    '
    'xtcEndTime
    '
    Me.xtcEndTime.Name = "xtcEndTime"
    Me.xtcEndTime.Weight = 1.1763143647001977R
    '
    'xtcStandardHours
    '
    Me.xtcStandardHours.Name = "xtcStandardHours"
    Me.xtcStandardHours.Weight = 1.2740416019453122R
    '
    'xtcStdPayment
    '
    Me.xtcStdPayment.Name = "xtcStdPayment"
    Me.xtcStdPayment.Weight = 0.97069560992138615R
    '
    'xtcOverTimeHours
    '
    Me.xtcOverTimeHours.Name = "xtcOverTimeHours"
    Me.xtcOverTimeHours.Weight = 1.2105279084518974R
    '
    'xtcOverTimePayment
    '
    Me.xtcOverTimePayment.Name = "xtcOverTimePayment"
    Me.xtcOverTimePayment.Weight = 1.2631578135820689R
    '
    'xtcTotalPayment
    '
    Me.xtcTotalPayment.Name = "xtcTotalPayment"
    Me.xtcTotalPayment.Weight = 1.3578936858877926R
    '
    'XrTable1
    '
    Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
    Me.XrTable1.BackColor = System.Drawing.Color.MidnightBlue
    Me.XrTable1.BorderColor = System.Drawing.Color.White
    Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrTable1.ForeColor = System.Drawing.Color.White
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 283.3333!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(745.0!, 20.83334!)
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
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.CanGrow = False
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.Text = "Fecha"
    Me.XrTableCell1.Weight = 1.0R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.CanGrow = False
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.Text = "Hora Entrada"
    Me.XrTableCell2.Weight = 1.1578947153378305R
    '
    'XrTableCell3
    '
    Me.XrTableCell3.CanGrow = False
    Me.XrTableCell3.Name = "XrTableCell3"
    Me.XrTableCell3.Text = "Hora Salida"
    Me.XrTableCell3.Weight = 1.1763138701586153R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.CanGrow = False
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.Text = "Horas Std"
    Me.XrTableCell4.Weight = 1.27404080290934R
    '
    'XrTableCell7
    '
    Me.XrTableCell7.CanGrow = False
    Me.XrTableCell7.Name = "XrTableCell7"
    Me.XrTableCell7.Text = "Pago Std"
    Me.XrTableCell7.Weight = 0.970697438250289R
    '
    'XrTableCell8
    '
    Me.XrTableCell8.CanGrow = False
    Me.XrTableCell8.Name = "XrTableCell8"
    Me.XrTableCell8.Text = "Horas Extras"
    Me.XrTableCell8.Weight = 1.2105278022143566R
    '
    'XrTableCell9
    '
    Me.XrTableCell9.CanGrow = False
    Me.XrTableCell9.Name = "XrTableCell9"
    Me.XrTableCell9.Text = "Pago Extras"
    Me.XrTableCell9.Weight = 1.2631577035580053R
    '
    'XrTableCell10
    '
    Me.XrTableCell10.CanGrow = False
    Me.XrTableCell10.Name = "XrTableCell10"
    Me.XrTableCell10.Text = "Total"
    Me.XrTableCell10.Weight = 1.3578927017062652R
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 16.79166!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 35.41667!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.xrlStartDate, Me.XrLabel7, Me.xrlFinishDate, Me.xrlEmployeeName, Me.XrLabel3, Me.xrlPeriodType, Me.xrlType, Me.xrlPeriodStartDate, Me.XrLabel2, Me.XrPictureBox1, Me.XrTable1, Me.XrLabel1})
    Me.ReportHeader.HeightF = 304.1667!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrLabel5
    '
    Me.XrLabel5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 193.75!)
    Me.XrLabel5.Name = "XrLabel5"
    Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel5.SizeF = New System.Drawing.SizeF(115.0!, 22.99998!)
    Me.XrLabel5.StylePriority.UseFont = False
    Me.XrLabel5.StylePriority.UseTextAlignment = False
    Me.XrLabel5.Text = "Período Inicial:"
    Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'xrlStartDate
    '
    Me.xrlStartDate.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlStartDate.LocationFloat = New DevExpress.Utils.PointFloat(275.2364!, 193.75!)
    Me.xrlStartDate.Name = "xrlStartDate"
    Me.xrlStartDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlStartDate.SizeF = New System.Drawing.SizeF(89.5834!, 22.99998!)
    Me.xrlStartDate.StylePriority.UseFont = False
    Me.xrlStartDate.StylePriority.UseTextAlignment = False
    Me.xrlStartDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'XrLabel7
    '
    Me.XrLabel7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(364.8198!, 193.75!)
    Me.XrLabel7.Name = "XrLabel7"
    Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel7.SizeF = New System.Drawing.SizeF(98.95834!, 22.99998!)
    Me.XrLabel7.StylePriority.UseFont = False
    Me.XrLabel7.StylePriority.UseTextAlignment = False
    Me.XrLabel7.Text = "Período Final:"
    Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'xrlFinishDate
    '
    Me.xrlFinishDate.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlFinishDate.LocationFloat = New DevExpress.Utils.PointFloat(491.9032!, 193.75!)
    Me.xrlFinishDate.Name = "xrlFinishDate"
    Me.xrlFinishDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlFinishDate.SizeF = New System.Drawing.SizeF(108.3334!, 23.0!)
    Me.xrlFinishDate.StylePriority.UseFont = False
    Me.xrlFinishDate.StylePriority.UseTextAlignment = False
    Me.xrlFinishDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'xrlEmployeeName
    '
    Me.xrlEmployeeName.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlEmployeeName.LocationFloat = New DevExpress.Utils.PointFloat(317.0832!, 250.0!)
    Me.xrlEmployeeName.Name = "xrlEmployeeName"
    Me.xrlEmployeeName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlEmployeeName.SizeF = New System.Drawing.SizeF(283.1534!, 23.0!)
    Me.xrlEmployeeName.StylePriority.UseFont = False
    Me.xrlEmployeeName.StylePriority.UseTextAlignment = False
    Me.xrlEmployeeName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'XrLabel3
    '
    Me.XrLabel3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 250.0!)
    Me.XrLabel3.Name = "XrLabel3"
    Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel3.SizeF = New System.Drawing.SizeF(164.3749!, 22.99998!)
    Me.XrLabel3.StylePriority.UseFont = False
    Me.XrLabel3.StylePriority.UseTextAlignment = False
    Me.XrLabel3.Text = "Nombre del Trabajador:"
    Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'xrlPeriodType
    '
    Me.xrlPeriodType.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlPeriodType.LocationFloat = New DevExpress.Utils.PointFloat(491.9032!, 137.5!)
    Me.xrlPeriodType.Name = "xrlPeriodType"
    Me.xrlPeriodType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlPeriodType.SizeF = New System.Drawing.SizeF(108.3334!, 23.0!)
    Me.xrlPeriodType.StylePriority.UseFont = False
    Me.xrlPeriodType.StylePriority.UseTextAlignment = False
    Me.xrlPeriodType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'xrlType
    '
    Me.xrlType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.xrlType.LocationFloat = New DevExpress.Utils.PointFloat(364.8198!, 137.5!)
    Me.xrlType.Name = "xrlType"
    Me.xrlType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlType.SizeF = New System.Drawing.SizeF(115.6251!, 22.99998!)
    Me.xrlType.StylePriority.UseFont = False
    Me.xrlType.StylePriority.UseTextAlignment = False
    Me.xrlType.Text = "Tipo de Reporte:"
    Me.xrlType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'xrlPeriodStartDate
    '
    Me.xrlPeriodStartDate.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlPeriodStartDate.LocationFloat = New DevExpress.Utils.PointFloat(275.2364!, 137.5!)
    Me.xrlPeriodStartDate.Name = "xrlPeriodStartDate"
    Me.xrlPeriodStartDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlPeriodStartDate.SizeF = New System.Drawing.SizeF(89.5834!, 22.99998!)
    Me.xrlPeriodStartDate.StylePriority.UseFont = False
    Me.xrlPeriodStartDate.StylePriority.UseTextAlignment = False
    Me.xrlPeriodStartDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'XrLabel2
    '
    Me.XrLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 137.5!)
    Me.XrLabel2.Name = "XrLabel2"
    Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel2.SizeF = New System.Drawing.SizeF(115.0!, 22.99998!)
    Me.XrLabel2.StylePriority.UseFont = False
    Me.XrLabel2.StylePriority.UseTextAlignment = False
    Me.XrLabel2.Text = "Período a Pagar:"
    Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'XrPictureBox1
    '
    Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
    Me.XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
    Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(215.8615!, 0!)
    Me.XrPictureBox1.Name = "XrPictureBox1"
    Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(282.8603!, 75.25002!)
    Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
    '
    'XrLabel1
    '
    Me.XrLabel1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(134.375!, 98.79169!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(480.2083!, 23.0!)
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "REPORTE DE PAGO DE PERSONAL DE PLANILLA"
    '
    'ReportFooter
    '
    Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel4, Me.XrLine2, Me.XrLine1})
    Me.ReportFooter.HeightF = 110.4167!
    Me.ReportFooter.Name = "ReportFooter"
    '
    'XrLabel6
    '
    Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(550.0003!, 82.33331!)
    Me.XrLabel6.Name = "XrLabel6"
    Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel6.SizeF = New System.Drawing.SizeF(89.58313!, 22.99998!)
    Me.XrLabel6.StylePriority.UseFont = False
    Me.XrLabel6.Text = "Firma de RRHH"
    '
    'XrLabel4
    '
    Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(81.25001!, 82.33331!)
    Me.XrLabel4.Name = "XrLabel4"
    Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel4.SizeF = New System.Drawing.SizeF(116.0417!, 22.99998!)
    Me.XrLabel4.StylePriority.UseFont = False
    Me.XrLabel4.Text = "Firma del Empleado"
    '
    'XrLine2
    '
    Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(27.70832!, 59.33332!)
    Me.XrLine2.Name = "XrLine2"
    Me.XrLine2.SizeF = New System.Drawing.SizeF(250.0001!, 23.0!)
    '
    'XrLine1
    '
    Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(469.7917!, 59.33332!)
    Me.XrLine1.Name = "XrLine1"
    Me.XrLine1.SizeF = New System.Drawing.SizeF(250.0001!, 23.0!)
    '
    'repPaySlip
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
    Me.Margins = New System.Drawing.Printing.Margins(42, 63, 17, 35)
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
  Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtcItemDate As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcStartTime As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcEndTime As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrlPeriodType As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlType As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlPeriodStartDate As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlEmployeeName As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlStartDate As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlFinishDate As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcStandardHours As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcStdPayment As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcOverTimeHours As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcOverTimePayment As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xtcTotalPayment As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
