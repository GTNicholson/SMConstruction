<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repoListToStockTake
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
    Me.xrtStockCode = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtStockDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtCategory = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtItemType = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtPartNo = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtSystemQtys = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.Detail.HeightF = 26.60418!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable1
    '
    Me.XrTable1.BackColor = System.Drawing.Color.White
    Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(821.0!, 26.60418!)
    Me.XrTable1.StylePriority.UseBackColor = False
    Me.XrTable1.StylePriority.UseBorders = False
    Me.XrTable1.StylePriority.UseFont = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtStockCode, Me.xrtStockDescription, Me.xrtCategory, Me.xrtItemType, Me.xrtPartNo, Me.xrtSystemQtys, Me.XrTableCell9})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'xrtStockCode
    '
    Me.xrtStockCode.BackColor = System.Drawing.Color.Transparent
    Me.xrtStockCode.BorderColor = System.Drawing.Color.Black
    Me.xrtStockCode.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
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
    Me.xrtStockDescription.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
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
    Me.xrtStockDescription.Weight = 2.6856514972547711R
    '
    'xrtCategory
    '
    Me.xrtCategory.BackColor = System.Drawing.Color.Transparent
    Me.xrtCategory.BorderColor = System.Drawing.Color.Black
    Me.xrtCategory.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtCategory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xrtCategory.ForeColor = System.Drawing.Color.Black
    Me.xrtCategory.Name = "xrtCategory"
    Me.xrtCategory.StylePriority.UseBackColor = False
    Me.xrtCategory.StylePriority.UseBorderColor = False
    Me.xrtCategory.StylePriority.UseBorders = False
    Me.xrtCategory.StylePriority.UseFont = False
    Me.xrtCategory.StylePriority.UseForeColor = False
    Me.xrtCategory.StylePriority.UseTextAlignment = False
    Me.xrtCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtCategory.Weight = 1.3797844209189143R
    '
    'xrtItemType
    '
    Me.xrtItemType.BackColor = System.Drawing.Color.Transparent
    Me.xrtItemType.BorderColor = System.Drawing.Color.Black
    Me.xrtItemType.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtItemType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xrtItemType.ForeColor = System.Drawing.Color.Black
    Me.xrtItemType.Name = "xrtItemType"
    Me.xrtItemType.StylePriority.UseBackColor = False
    Me.xrtItemType.StylePriority.UseBorderColor = False
    Me.xrtItemType.StylePriority.UseBorders = False
    Me.xrtItemType.StylePriority.UseFont = False
    Me.xrtItemType.StylePriority.UseForeColor = False
    Me.xrtItemType.StylePriority.UseTextAlignment = False
    Me.xrtItemType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtItemType.Weight = 1.1165911161378963R
    '
    'xrtPartNo
    '
    Me.xrtPartNo.BackColor = System.Drawing.Color.Transparent
    Me.xrtPartNo.BorderColor = System.Drawing.Color.Black
    Me.xrtPartNo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtPartNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xrtPartNo.ForeColor = System.Drawing.Color.Black
    Me.xrtPartNo.Name = "xrtPartNo"
    Me.xrtPartNo.StylePriority.UseBackColor = False
    Me.xrtPartNo.StylePriority.UseBorderColor = False
    Me.xrtPartNo.StylePriority.UseBorders = False
    Me.xrtPartNo.StylePriority.UseFont = False
    Me.xrtPartNo.StylePriority.UseForeColor = False
    Me.xrtPartNo.StylePriority.UseTextAlignment = False
    Me.xrtPartNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtPartNo.Weight = 0.78083739178149059R
    '
    'xrtSystemQtys
    '
    Me.xrtSystemQtys.BackColor = System.Drawing.Color.Transparent
    Me.xrtSystemQtys.BorderColor = System.Drawing.Color.Black
    Me.xrtSystemQtys.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtSystemQtys.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.xrtSystemQtys.ForeColor = System.Drawing.Color.Black
    Me.xrtSystemQtys.Name = "xrtSystemQtys"
    Me.xrtSystemQtys.StylePriority.UseBackColor = False
    Me.xrtSystemQtys.StylePriority.UseBorderColor = False
    Me.xrtSystemQtys.StylePriority.UseBorders = False
    Me.xrtSystemQtys.StylePriority.UseFont = False
    Me.xrtSystemQtys.StylePriority.UseForeColor = False
    Me.xrtSystemQtys.StylePriority.UseTextAlignment = False
    Me.xrtSystemQtys.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtSystemQtys.Weight = 1.1220071832725647R
    '
    'XrTableCell9
    '
    Me.XrTableCell9.BackColor = System.Drawing.Color.Transparent
    Me.XrTableCell9.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
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
    Me.XrTableCell9.Weight = 1.207559164182388R
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
    Me.BottomMargin.HeightF = 23.22909!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrLabel1})
    Me.ReportHeader.HeightF = 102.0833!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrTable3
    '
    Me.XrTable3.Font = New System.Drawing.Font("Arial", 9.0!)
    Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 55.06248!)
    Me.XrTable3.Name = "XrTable3"
    Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow15})
    Me.XrTable3.SizeF = New System.Drawing.SizeF(821.0!, 47.02084!)
    Me.XrTable3.StylePriority.UseFont = False
    Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrTableRow15
    '
    Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell4, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7})
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
    Me.XrTableCell4.Weight = 2.6856516872693521R
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
    Me.XrTableCell2.Weight = 1.3797842327914758R
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
    Me.XrTableCell3.Text = "SUB CATEGORÍA"
    Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell3.Weight = 1.1165918301297386R
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
    Me.XrTableCell5.Text = "NÚM. PARTE"
    Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell5.Weight = 0.78083678669480827R
    '
    'XrTableCell6
    '
    Me.XrTableCell6.BackColor = System.Drawing.Color.Black
    Me.XrTableCell6.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell6.ForeColor = System.Drawing.Color.White
    Me.XrTableCell6.Name = "XrTableCell6"
    Me.XrTableCell6.StylePriority.UseBackColor = False
    Me.XrTableCell6.StylePriority.UseBorderColor = False
    Me.XrTableCell6.StylePriority.UseBorders = False
    Me.XrTableCell6.StylePriority.UseFont = False
    Me.XrTableCell6.StylePriority.UseForeColor = False
    Me.XrTableCell6.StylePriority.UseTextAlignment = False
    Me.XrTableCell6.Text = "CANT. SISTEMA"
    Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell6.Weight = 1.1220079853347613R
    '
    'XrTableCell7
    '
    Me.XrTableCell7.BackColor = System.Drawing.Color.Black
    Me.XrTableCell7.BorderColor = System.Drawing.Color.Black
    Me.XrTableCell7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell7.ForeColor = System.Drawing.Color.White
    Me.XrTableCell7.Name = "XrTableCell7"
    Me.XrTableCell7.StylePriority.UseBackColor = False
    Me.XrTableCell7.StylePriority.UseBorderColor = False
    Me.XrTableCell7.StylePriority.UseBorders = False
    Me.XrTableCell7.StylePriority.UseFont = False
    Me.XrTableCell7.StylePriority.UseForeColor = False
    Me.XrTableCell7.StylePriority.UseTextAlignment = False
    Me.XrTableCell7.Text = "CANT. REAL"
    Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell7.Weight = 1.2075590255581625R
    '
    'XrLabel1
    '
    Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(217.0834!, 0!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(385.1506!, 36.44698!)
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "CONTEO DE INVENTARIO"
    '
    'repoListToStockTake
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Margins = New System.Drawing.Printing.Margins(10, 19, 6, 23)
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtStockCode As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtStockDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtCategory As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtItemType As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtPartNo As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrtSystemQtys As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
End Class
