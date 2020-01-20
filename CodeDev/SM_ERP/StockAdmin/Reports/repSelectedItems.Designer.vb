<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repSelectedItems
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repSelectedItems))
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrtStockCode = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtStockDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.Detail.HeightF = 31.25!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable1
    '
    Me.XrTable1.BackColor = System.Drawing.Color.White
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(784.8203!, 19.93752!)
    Me.XrTable1.StylePriority.UseBackColor = False
    Me.XrTable1.StylePriority.UseFont = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtStockCode, Me.xrtStockDescription, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'xrtStockCode
    '
    Me.xrtStockCode.BackColor = System.Drawing.Color.Transparent
    Me.xrtStockCode.BorderColor = System.Drawing.Color.Black
    Me.xrtStockCode.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtStockCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xrtStockCode.ForeColor = System.Drawing.Color.Black
    Me.xrtStockCode.Name = "xrtStockCode"
    Me.xrtStockCode.StylePriority.UseBackColor = False
    Me.xrtStockCode.StylePriority.UseBorderColor = False
    Me.xrtStockCode.StylePriority.UseBorders = False
    Me.xrtStockCode.StylePriority.UseFont = False
    Me.xrtStockCode.StylePriority.UseForeColor = False
    Me.xrtStockCode.StylePriority.UseTextAlignment = False
    Me.xrtStockCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtStockCode.Weight = 0.97993947384380364R
    '
    'xrtStockDescription
    '
    Me.xrtStockDescription.BackColor = System.Drawing.Color.Transparent
    Me.xrtStockDescription.BorderColor = System.Drawing.Color.Black
    Me.xrtStockDescription.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtStockDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xrtStockDescription.ForeColor = System.Drawing.Color.Black
    Me.xrtStockDescription.Name = "xrtStockDescription"
    Me.xrtStockDescription.StylePriority.UseBackColor = False
    Me.xrtStockDescription.StylePriority.UseBorderColor = False
    Me.xrtStockDescription.StylePriority.UseBorders = False
    Me.xrtStockDescription.StylePriority.UseFont = False
    Me.xrtStockDescription.StylePriority.UseForeColor = False
    Me.xrtStockDescription.StylePriority.UseTextAlignment = False
    Me.xrtStockDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtStockDescription.Weight = 2.4738890829568456R
    '
    'XrTableCell8
    '
    Me.XrTableCell8.BackColor = System.Drawing.Color.Transparent
    Me.XrTableCell8.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell8.ForeColor = System.Drawing.Color.Black
    Me.XrTableCell8.Name = "XrTableCell8"
    Me.XrTableCell8.StylePriority.UseBackColor = False
    Me.XrTableCell8.StylePriority.UseBorderColor = False
    Me.XrTableCell8.StylePriority.UseBorders = False
    Me.XrTableCell8.StylePriority.UseFont = False
    Me.XrTableCell8.StylePriority.UseForeColor = False
    Me.XrTableCell8.StylePriority.UseTextAlignment = False
    Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell8.Weight = 1.5915473584156836R
    '
    'XrTableCell9
    '
    Me.XrTableCell9.BackColor = System.Drawing.Color.Transparent
    Me.XrTableCell9.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell9.ForeColor = System.Drawing.Color.Black
    Me.XrTableCell9.Name = "XrTableCell9"
    Me.XrTableCell9.StylePriority.UseBackColor = False
    Me.XrTableCell9.StylePriority.UseBorderColor = False
    Me.XrTableCell9.StylePriority.UseBorders = False
    Me.XrTableCell9.StylePriority.UseFont = False
    Me.XrTableCell9.StylePriority.UseForeColor = False
    Me.XrTableCell9.StylePriority.UseTextAlignment = False
    Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell9.Weight = 1.9091906368854279R
    '
    'XrTableCell10
    '
    Me.XrTableCell10.BackColor = System.Drawing.Color.Transparent
    Me.XrTableCell10.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell10.ForeColor = System.Drawing.Color.Black
    Me.XrTableCell10.Name = "XrTableCell10"
    Me.XrTableCell10.StylePriority.UseBackColor = False
    Me.XrTableCell10.StylePriority.UseBorderColor = False
    Me.XrTableCell10.StylePriority.UseBorders = False
    Me.XrTableCell10.StylePriority.UseFont = False
    Me.XrTableCell10.StylePriority.UseForeColor = False
    Me.XrTableCell10.StylePriority.UseTextAlignment = False
    Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell10.Weight = 1.9091906368854279R
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 6.0!
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
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrTable3, Me.XrLabel1})
    Me.ReportHeader.HeightF = 192.7083!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrPictureBox1
    '
    Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
    Me.XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
    Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(256.4865!, 0!)
    Me.XrPictureBox1.Name = "XrPictureBox1"
    Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(257.8603!, 50.25003!)
    Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
    '
    'XrTable3
    '
    Me.XrTable3.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 172.7708!)
    Me.XrTable3.Name = "XrTable3"
    Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow15})
    Me.XrTable3.SizeF = New System.Drawing.SizeF(784.8203!, 19.93752!)
    Me.XrTable3.StylePriority.UseFont = False
    Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrTableRow15
    '
    Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell4, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell5})
    Me.XrTableRow15.Name = "XrTableRow15"
    Me.XrTableRow15.Weight = 1.0R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.BackColor = System.Drawing.Color.Black
    Me.XrTableCell1.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell1.ForeColor = System.Drawing.Color.White
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.StylePriority.UseBackColor = False
    Me.XrTableCell1.StylePriority.UseBorderColor = False
    Me.XrTableCell1.StylePriority.UseBorders = False
    Me.XrTableCell1.StylePriority.UseFont = False
    Me.XrTableCell1.StylePriority.UseForeColor = False
    Me.XrTableCell1.StylePriority.UseTextAlignment = False
    Me.XrTableCell1.Text = "CÓDIGO"
    Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell1.Weight = 0.97993947384380364R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.BackColor = System.Drawing.Color.Black
    Me.XrTableCell4.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell4.ForeColor = System.Drawing.Color.White
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.StylePriority.UseBackColor = False
    Me.XrTableCell4.StylePriority.UseBorderColor = False
    Me.XrTableCell4.StylePriority.UseBorders = False
    Me.XrTableCell4.StylePriority.UseFont = False
    Me.XrTableCell4.StylePriority.UseForeColor = False
    Me.XrTableCell4.StylePriority.UseTextAlignment = False
    Me.XrTableCell4.Text = "DESCRIPCIÓN"
    Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell4.Weight = 2.4738890829568456R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.BackColor = System.Drawing.Color.Black
    Me.XrTableCell2.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell2.ForeColor = System.Drawing.Color.White
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.StylePriority.UseBackColor = False
    Me.XrTableCell2.StylePriority.UseBorderColor = False
    Me.XrTableCell2.StylePriority.UseBorders = False
    Me.XrTableCell2.StylePriority.UseFont = False
    Me.XrTableCell2.StylePriority.UseForeColor = False
    Me.XrTableCell2.StylePriority.UseTextAlignment = False
    Me.XrTableCell2.Text = "CATEGORÍA"
    Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell2.Weight = 1.5915473584156836R
    '
    'XrTableCell3
    '
    Me.XrTableCell3.BackColor = System.Drawing.Color.Black
    Me.XrTableCell3.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell3.ForeColor = System.Drawing.Color.White
    Me.XrTableCell3.Name = "XrTableCell3"
    Me.XrTableCell3.StylePriority.UseBackColor = False
    Me.XrTableCell3.StylePriority.UseBorderColor = False
    Me.XrTableCell3.StylePriority.UseBorders = False
    Me.XrTableCell3.StylePriority.UseFont = False
    Me.XrTableCell3.StylePriority.UseForeColor = False
    Me.XrTableCell3.StylePriority.UseTextAlignment = False
    Me.XrTableCell3.Text = "CANT. SISTEMA"
    Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell3.Weight = 1.9091906368854279R
    '
    'XrTableCell5
    '
    Me.XrTableCell5.BackColor = System.Drawing.Color.Black
    Me.XrTableCell5.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell5.ForeColor = System.Drawing.Color.White
    Me.XrTableCell5.Name = "XrTableCell5"
    Me.XrTableCell5.StylePriority.UseBackColor = False
    Me.XrTableCell5.StylePriority.UseBorderColor = False
    Me.XrTableCell5.StylePriority.UseBorders = False
    Me.XrTableCell5.StylePriority.UseFont = False
    Me.XrTableCell5.StylePriority.UseForeColor = False
    Me.XrTableCell5.StylePriority.UseTextAlignment = False
    Me.XrTableCell5.Text = "CANT. CONTADA"
    Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell5.Weight = 1.9091906368854279R
    '
    'XrLabel1
    '
    Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(203.5417!, 69.74999!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(385.1506!, 45.91666!)
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "CONTEDO DE INVENTARIO"
    '
    'repSelectedItems
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Margins = New System.Drawing.Printing.Margins(10, 29, 6, 100)
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtStockCode As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtStockDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
