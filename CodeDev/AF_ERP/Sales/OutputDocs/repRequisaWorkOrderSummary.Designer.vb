<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repRequisaWorkOrderSummary
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repRequisaWorkOrderSummary))
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xtcStockCode = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcUoM = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcRequiredQty = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcReturnQty = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcPickedQty = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
    Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcWorkOrderNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xtcProyectName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable12 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FilteringUIContext1 = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrSignaturejpeg = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xtcArea = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilteringUIContext1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.HeightF = 30.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable3
        '
        Me.XrTable3.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(777.9995!, 30.0!)
        Me.XrTable3.StylePriority.UseBorderColor = False
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UsePadding = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcStockCode, Me.xtcDescription, Me.xtcUoM, Me.xtcRequiredQty, Me.xtcReturnQty, Me.xtcPickedQty})
        Me.XrTableRow5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.StylePriority.UseFont = False
        Me.XrTableRow5.Weight = 1.60000101725325R
        '
        'xtcStockCode
        '
        Me.xtcStockCode.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcStockCode.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcStockCode.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xtcStockCode.ForeColor = System.Drawing.Color.Black
        Me.xtcStockCode.Name = "xtcStockCode"
        Me.xtcStockCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcStockCode.StylePriority.UseBorderColor = False
        Me.xtcStockCode.StylePriority.UseBorders = False
        Me.xtcStockCode.StylePriority.UseFont = False
        Me.xtcStockCode.StylePriority.UseForeColor = False
        Me.xtcStockCode.StylePriority.UsePadding = False
        Me.xtcStockCode.StylePriority.UseTextAlignment = False
        Me.xtcStockCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xtcStockCode.Weight = 0.7165358377487886R
        '
        'xtcDescription
        '
        Me.xtcDescription.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcDescription.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcDescription.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xtcDescription.ForeColor = System.Drawing.Color.Black
        Me.xtcDescription.Name = "xtcDescription"
        Me.xtcDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcDescription.StylePriority.UseBorderColor = False
        Me.xtcDescription.StylePriority.UseBorders = False
        Me.xtcDescription.StylePriority.UseFont = False
        Me.xtcDescription.StylePriority.UseForeColor = False
        Me.xtcDescription.StylePriority.UsePadding = False
        Me.xtcDescription.StylePriority.UseTextAlignment = False
        Me.xtcDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xtcDescription.Weight = 1.980272263212588R
        '
        'xtcUoM
        '
        Me.xtcUoM.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcUoM.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcUoM.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xtcUoM.ForeColor = System.Drawing.Color.Black
        Me.xtcUoM.Name = "xtcUoM"
        Me.xtcUoM.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcUoM.StylePriority.UseBorderColor = False
        Me.xtcUoM.StylePriority.UseBorders = False
        Me.xtcUoM.StylePriority.UseFont = False
        Me.xtcUoM.StylePriority.UseForeColor = False
        Me.xtcUoM.StylePriority.UsePadding = False
        Me.xtcUoM.StylePriority.UseTextAlignment = False
        Me.xtcUoM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xtcUoM.Weight = 0.3548817575445975R
        '
        'xtcRequiredQty
        '
        Me.xtcRequiredQty.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcRequiredQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcRequiredQty.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xtcRequiredQty.ForeColor = System.Drawing.Color.Black
        Me.xtcRequiredQty.Multiline = True
        Me.xtcRequiredQty.Name = "xtcRequiredQty"
        Me.xtcRequiredQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcRequiredQty.StylePriority.UseBorderColor = False
        Me.xtcRequiredQty.StylePriority.UseBorders = False
        Me.xtcRequiredQty.StylePriority.UseFont = False
        Me.xtcRequiredQty.StylePriority.UseForeColor = False
        Me.xtcRequiredQty.StylePriority.UsePadding = False
        Me.xtcRequiredQty.StylePriority.UseTextAlignment = False
        Me.xtcRequiredQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xtcRequiredQty.Weight = 0.49145656872511573R
        '
        'xtcReturnQty
        '
        Me.xtcReturnQty.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcReturnQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcReturnQty.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xtcReturnQty.ForeColor = System.Drawing.Color.Black
        Me.xtcReturnQty.Name = "xtcReturnQty"
        Me.xtcReturnQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcReturnQty.StylePriority.UseBorderColor = False
        Me.xtcReturnQty.StylePriority.UseBorders = False
        Me.xtcReturnQty.StylePriority.UseFont = False
        Me.xtcReturnQty.StylePriority.UseForeColor = False
        Me.xtcReturnQty.StylePriority.UsePadding = False
        Me.xtcReturnQty.StylePriority.UseTextAlignment = False
        Me.xtcReturnQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xtcReturnQty.Weight = 0.48710426699860554R
        '
        'xtcPickedQty
        '
        Me.xtcPickedQty.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcPickedQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcPickedQty.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xtcPickedQty.ForeColor = System.Drawing.Color.Black
        Me.xtcPickedQty.Name = "xtcPickedQty"
        Me.xtcPickedQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcPickedQty.StylePriority.UseBorderColor = False
        Me.xtcPickedQty.StylePriority.UseBorders = False
        Me.xtcPickedQty.StylePriority.UseFont = False
        Me.xtcPickedQty.StylePriority.UseForeColor = False
        Me.xtcPickedQty.StylePriority.UsePadding = False
        Me.xtcPickedQty.StylePriority.UseTextAlignment = False
        Me.xtcPickedQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xtcPickedQty.Weight = 0.594429213400471R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 16.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 12.96881!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrTable7, Me.XrPictureBox1, Me.XrTable6, Me.XrTable12})
        Me.ReportHeader.HeightF = 185.9029!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPanel1
        '
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 164.7918!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(777.9995!, 21.11111!)
        '
        'XrTable7
        '
        Me.XrTable7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 62.28123!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(777.9995!, 29.99999!)
        Me.XrTable7.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTableRow1.StylePriority.UsePadding = False
        Me.XrTableRow1.Weight = 0.295943447658734R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Resumen de Salidas de Bodegas de Insumos"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 0.92348521218732R
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(607.1667!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(170.8333!, 56.33332!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrTable6
        '
        Me.XrTable6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 104.7918!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9, Me.XrTableRow2})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(778.0!, 59.99996!)
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UsePadding = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow9
        '
        Me.XrTableRow9.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.xtcWorkOrderNo})
        Me.XrTableRow9.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableRow9.StylePriority.UseBorderColor = False
        Me.XrTableRow9.StylePriority.UseFont = False
        Me.XrTableRow9.StylePriority.UsePadding = False
        Me.XrTableRow9.Weight = 1.2R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell10.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseForeColor = False
        Me.XrTableCell10.Text = "# OT"
        Me.XrTableCell10.Weight = 0.810427933393899R
        '
        'xtcWorkOrderNo
        '
        Me.xtcWorkOrderNo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcWorkOrderNo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.xtcWorkOrderNo.ForeColor = System.Drawing.Color.Black
        Me.xtcWorkOrderNo.Name = "xtcWorkOrderNo"
        Me.xtcWorkOrderNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0!)
        Me.xtcWorkOrderNo.StylePriority.UseBorders = False
        Me.xtcWorkOrderNo.StylePriority.UseFont = False
        Me.xtcWorkOrderNo.StylePriority.UseForeColor = False
        Me.xtcWorkOrderNo.StylePriority.UsePadding = False
        Me.xtcWorkOrderNo.Weight = 3.5081558464300091R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.xtcProyectName})
        Me.XrTableRow2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableRow2.StylePriority.UseBorderColor = False
        Me.XrTableRow2.StylePriority.UseFont = False
        Me.XrTableRow2.StylePriority.UsePadding = False
        Me.XrTableRow2.Weight = 1.2R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.Text = "Proyecto"
        Me.XrTableCell2.Weight = 0.810427933393899R
        '
        'xtcProyectName
        '
        Me.xtcProyectName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xtcProyectName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.xtcProyectName.ForeColor = System.Drawing.Color.Black
        Me.xtcProyectName.Name = "xtcProyectName"
        Me.xtcProyectName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0!)
        Me.xtcProyectName.StylePriority.UseBorders = False
        Me.xtcProyectName.StylePriority.UseFont = False
        Me.xtcProyectName.StylePriority.UseForeColor = False
        Me.xtcProyectName.StylePriority.UsePadding = False
        Me.xtcProyectName.Weight = 3.50815584643001R
        '
        'XrTable12
        '
        Me.XrTable12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable12.LocationFloat = New DevExpress.Utils.PointFloat(260.6247!, 10.00001!)
        Me.XrTable12.Name = "XrTable12"
        Me.XrTable12.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow25})
        Me.XrTable12.SizeF = New System.Drawing.SizeF(294.875!, 29.99999!)
        Me.XrTable12.StylePriority.UseBorders = False
        '
        'XrTableRow25
        '
        Me.XrTableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5})
        Me.XrTableRow25.Name = "XrTableRow25"
        Me.XrTableRow25.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTableRow25.StylePriority.UsePadding = False
        Me.XrTableRow25.Weight = 0.295943447658734R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "AGROFORESTAL S.A."
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell5.Weight = 0.92348521218732R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.ReportFooter.HeightF = 68.21964!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.PrintAtBottom = True
        '
        'XrTable4
        '
        Me.XrTable4.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow18, Me.XrTableRow6})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(365.7613!, 67.74615!)
        Me.XrTable4.StylePriority.UseBorderColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UsePadding = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell26})
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 1.02856992449079R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell26.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseForeColor = False
        Me.XrTableCell26.Text = "Recibido por Producción:"
        Me.XrTableCell26.Weight = 0.450471380522288R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrSignaturejpeg})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.StylePriority.UseBorders = False
        Me.XrTableRow6.Weight = 2.05714148385184R
        '
        'xrSignaturejpeg
        '
        Me.xrSignaturejpeg.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.xrSignaturejpeg.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrSignaturejpeg.ForeColor = System.Drawing.Color.Black
        Me.xrSignaturejpeg.Name = "xrSignaturejpeg"
        Me.xrSignaturejpeg.StylePriority.UseFont = False
        Me.xrSignaturejpeg.StylePriority.UseForeColor = False
        Me.xrSignaturejpeg.Weight = 0.450471380522288R
        '
        'XrLine1
        '
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 12.16411!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(345.7613!, 23.0!)
        Me.XrLine1.StylePriority.UseBorders = False
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable8})
        Me.GroupHeader1.HeightF = 41.11111!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrTable8
        '
        Me.XrTable8.BackColor = System.Drawing.Color.DarkGray
        Me.XrTable8.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable8.ForeColor = System.Drawing.Color.White
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(0.0005086262!, 0!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow13})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(777.9995!, 41.11111!)
        Me.XrTable8.StylePriority.UseBackColor = False
        Me.XrTable8.StylePriority.UseBorderColor = False
        Me.XrTable8.StylePriority.UseBorders = False
        Me.XrTable8.StylePriority.UseFont = False
        Me.XrTable8.StylePriority.UseForeColor = False
        Me.XrTable8.StylePriority.UsePadding = False
        Me.XrTable8.StylePriority.UseTextAlignment = False
        Me.XrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow13
        '
        Me.XrTableRow13.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow13.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell3, Me.XrTableCell9, Me.XrTableCell6, Me.XrTableCell4, Me.XrTableCell1})
        Me.XrTableRow13.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.StylePriority.UseBackColor = False
        Me.XrTableRow13.StylePriority.UseBorderColor = False
        Me.XrTableRow13.StylePriority.UseForeColor = False
        Me.XrTableRow13.Weight = 1.9489721899770522R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableCell11.StylePriority.UseBorderColor = False
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.Text = "Código Agro"
        Me.XrTableCell11.Weight = 0.68063552813026451R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableCell3.StylePriority.UseBorderColor = False
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.Text = "Descripción"
        Me.XrTableCell3.Weight = 1.8810550469842235R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorderColor = False
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "UdM"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.3371013715901261R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableCell6.StylePriority.UseBorderColor = False
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseForeColor = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Cant. Requerida"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell6.Weight = 0.46683328665749235R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableCell4.StylePriority.UseBorderColor = False
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseForeColor = False
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Cant. Devuelta"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell4.Weight = 0.4626990570132089R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.XrTableCell1.StylePriority.UseBorderColor = False
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Cant. Despachada"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 0.5646466644367617R
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.HeightF = 35.43591!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "Pág. {0} de {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(678.0001!, 12.43591!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.DarkGray
        Me.XrTable1.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.ForeColor = System.Drawing.Color.White
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.69444!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(778.0!, 25.83333!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseForeColor = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow4.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcArea})
        Me.XrTableRow4.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.StylePriority.UseBackColor = False
        Me.XrTableRow4.StylePriority.UseBorderColor = False
        Me.XrTableRow4.StylePriority.UseForeColor = False
        Me.XrTableRow4.Weight = 1.9489720091320675R
        '
        'xtcArea
        '
        Me.xtcArea.BorderColor = System.Drawing.Color.DarkGray
        Me.xtcArea.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.xtcArea.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtcArea.ForeColor = System.Drawing.Color.Black
        Me.xtcArea.Name = "xtcArea"
        Me.xtcArea.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100.0!)
        Me.xtcArea.StylePriority.UseBorderColor = False
        Me.xtcArea.StylePriority.UseBorders = False
        Me.xtcArea.StylePriority.UseFont = False
        Me.xtcArea.StylePriority.UseForeColor = False
        Me.xtcArea.StylePriority.UsePadding = False
        Me.xtcArea.StylePriority.UseTextAlignment = False
        Me.xtcArea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xtcArea.Weight = 0.5646466644367617R
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel2, Me.XrTable1})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("AreaDesc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 36.52777!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.RepeatEveryPage = True
        '
        'XrPanel2
        '
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(777.9996!, 10.69444!)
        '
        'repRequisaWorkOrderSummary
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter, Me.GroupHeader1, Me.PageFooter, Me.GroupHeader2})
        Me.Margins = New System.Drawing.Printing.Margins(25, 47, 16, 13)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilteringUIContext1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents FilteringUIContext1 As DevExpress.Utils.Filtering.FilteringUIContext
  Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
  Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xtcRequiredQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcWorkOrderNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable12 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow25 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrSignaturejpeg As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcProyectName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcStockCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcPickedQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcReturnQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcUoM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xtcArea As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
End Class
