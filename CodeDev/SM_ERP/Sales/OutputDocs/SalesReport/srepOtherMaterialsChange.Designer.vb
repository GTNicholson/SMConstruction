<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class srepOtherMaterialsChange
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
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrtMaterialDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtUoM = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtMaterialQuantity = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtAreaID = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtSupplierStockCode = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtComments = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtDateChange = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.Detail.HeightF = 25.72304!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable1
    '
    Me.XrTable1.BackColor = System.Drawing.Color.Transparent
    Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Top
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.XrTable1.ForeColor = System.Drawing.Color.Black
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(1054.0!, 25.72304!)
    Me.XrTable1.StylePriority.UseBackColor = False
    Me.XrTable1.StylePriority.UseBorders = False
    Me.XrTable1.StylePriority.UseFont = False
    Me.XrTable1.StylePriority.UseForeColor = False
    Me.XrTable1.StylePriority.UseTextAlignment = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow1
    '
    Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtMaterialDescription, Me.xrtUoM, Me.xrtMaterialQuantity, Me.xrtAreaID, Me.xrtSupplierStockCode, Me.xrtComments, Me.XrTableCell12, Me.xrtDateChange})
    Me.XrTableRow1.Name = "XrTableRow1"
    Me.XrTableRow1.Weight = 1.0R
    '
    'xrtMaterialDescription
    '
    Me.xrtMaterialDescription.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtMaterialDescription.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtMaterialDescription.Name = "xrtMaterialDescription"
    Me.xrtMaterialDescription.StylePriority.UseBorders = False
    Me.xrtMaterialDescription.StylePriority.UseFont = False
    Me.xrtMaterialDescription.StylePriority.UseTextAlignment = False
    Me.xrtMaterialDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtMaterialDescription.Weight = 2.4298434723018505R
    '
    'xrtUoM
    '
    Me.xrtUoM.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtUoM.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtUoM.Name = "xrtUoM"
    Me.xrtUoM.StylePriority.UseBorders = False
    Me.xrtUoM.StylePriority.UseFont = False
    Me.xrtUoM.StylePriority.UseTextAlignment = False
    Me.xrtUoM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtUoM.Weight = 0.7149887238569812R
    '
    'xrtMaterialQuantity
    '
    Me.xrtMaterialQuantity.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtMaterialQuantity.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtMaterialQuantity.Name = "xrtMaterialQuantity"
    Me.xrtMaterialQuantity.StylePriority.UseBorders = False
    Me.xrtMaterialQuantity.StylePriority.UseFont = False
    Me.xrtMaterialQuantity.StylePriority.UseTextAlignment = False
    Me.xrtMaterialQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtMaterialQuantity.Weight = 0.90301096371734568R
    '
    'xrtAreaID
    '
    Me.xrtAreaID.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtAreaID.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtAreaID.Name = "xrtAreaID"
    Me.xrtAreaID.StylePriority.UseBorders = False
    Me.xrtAreaID.StylePriority.UseFont = False
    Me.xrtAreaID.StylePriority.UseTextAlignment = False
    Me.xrtAreaID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtAreaID.Weight = 1.0163147132079495R
    '
    'xrtSupplierStockCode
    '
    Me.xrtSupplierStockCode.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtSupplierStockCode.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtSupplierStockCode.Name = "xrtSupplierStockCode"
    Me.xrtSupplierStockCode.StylePriority.UseBorders = False
    Me.xrtSupplierStockCode.StylePriority.UseFont = False
    Me.xrtSupplierStockCode.StylePriority.UseTextAlignment = False
    Me.xrtSupplierStockCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtSupplierStockCode.Weight = 1.059628785262773R
    '
    'xrtComments
    '
    Me.xrtComments.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtComments.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtComments.Name = "xrtComments"
    Me.xrtComments.StylePriority.UseBorders = False
    Me.xrtComments.StylePriority.UseFont = False
    Me.xrtComments.StylePriority.UseTextAlignment = False
    Me.xrtComments.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtComments.Weight = 2.0150585161330672R
    '
    'XrTableCell12
    '
    Me.XrTableCell12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.XrTableCell12.Name = "XrTableCell12"
    Me.XrTableCell12.StylePriority.UseBorders = False
    Me.XrTableCell12.StylePriority.UseFont = False
    Me.XrTableCell12.StylePriority.UseTextAlignment = False
    Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell12.Weight = 2.4980654161685094R
    '
    'xrtDateChange
    '
    Me.xrtDateChange.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrtDateChange.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.xrtDateChange.Name = "xrtDateChange"
    Me.xrtDateChange.StylePriority.UseBorders = False
    Me.xrtDateChange.StylePriority.UseFont = False
    Me.xrtDateChange.StylePriority.UseTextAlignment = False
    Me.xrtDateChange.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.xrtDateChange.Weight = 1.1125037807410267R
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 9.0!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 0!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrLabel16
    '
    Me.XrLabel16.BackColor = System.Drawing.Color.White
    Me.XrLabel16.BorderColor = System.Drawing.Color.Black
    Me.XrLabel16.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel16.BorderWidth = 2.0!
    Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.XrLabel16.ForeColor = System.Drawing.Color.Black
    Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 38.54163!)
    Me.XrLabel16.Name = "XrLabel16"
    Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel16.SizeF = New System.Drawing.SizeF(1054.0!, 32.2917!)
    Me.XrLabel16.StylePriority.UseBackColor = False
    Me.XrLabel16.StylePriority.UseBorderColor = False
    Me.XrLabel16.StylePriority.UseBorders = False
    Me.XrLabel16.StylePriority.UseBorderWidth = False
    Me.XrLabel16.StylePriority.UseFont = False
    Me.XrLabel16.StylePriority.UseForeColor = False
    Me.XrLabel16.Text = "CAMBIOS NECESARIOS"
    Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTable6
    '
    Me.XrTable6.BackColor = System.Drawing.Color.Transparent
    Me.XrTable6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable6.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.XrTable6.ForeColor = System.Drawing.Color.Black
    Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 70.83334!)
    Me.XrTable6.Name = "XrTable6"
    Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14})
    Me.XrTable6.SizeF = New System.Drawing.SizeF(1054.0!, 28.79168!)
    Me.XrTable6.StylePriority.UseBackColor = False
    Me.XrTable6.StylePriority.UseBorders = False
    Me.XrTable6.StylePriority.UseFont = False
    Me.XrTable6.StylePriority.UseForeColor = False
    Me.XrTable6.StylePriority.UseTextAlignment = False
    Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow14
    '
    Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell1, Me.XrTableCell4})
    Me.XrTableRow14.Name = "XrTableRow14"
    Me.XrTableRow14.Weight = 1.0R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.StylePriority.UseBorders = False
    Me.XrTableCell2.StylePriority.UseFont = False
    Me.XrTableCell2.StylePriority.UseTextAlignment = False
    Me.XrTableCell2.Text = "DESCRIPCIÓN / PRODUCTO"
    Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell2.Weight = 2.4298432171569231R
    '
    'XrTableCell3
    '
    Me.XrTableCell3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell3.Name = "XrTableCell3"
    Me.XrTableCell3.StylePriority.UseBorders = False
    Me.XrTableCell3.StylePriority.UseFont = False
    Me.XrTableCell3.StylePriority.UseTextAlignment = False
    Me.XrTableCell3.Text = "U/M"
    Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell3.Weight = 0.71498838366374506R
    '
    'XrTableCell5
    '
    Me.XrTableCell5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell5.Name = "XrTableCell5"
    Me.XrTableCell5.StylePriority.UseBorders = False
    Me.XrTableCell5.StylePriority.UseFont = False
    Me.XrTableCell5.StylePriority.UseTextAlignment = False
    Me.XrTableCell5.Text = "CANTIDAD"
    Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell5.Weight = 0.90301164410381818R
    '
    'XrTableCell48
    '
    Me.XrTableCell48.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell48.Name = "XrTableCell48"
    Me.XrTableCell48.StylePriority.UseBorders = False
    Me.XrTableCell48.StylePriority.UseFont = False
    Me.XrTableCell48.StylePriority.UseTextAlignment = False
    Me.XrTableCell48.Text = "ÁREA"
    Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell48.Weight = 1.016313692628241R
    '
    'XrTableCell49
    '
    Me.XrTableCell49.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell49.Name = "XrTableCell49"
    Me.XrTableCell49.StylePriority.UseBorders = False
    Me.XrTableCell49.StylePriority.UseFont = False
    Me.XrTableCell49.StylePriority.UseTextAlignment = False
    Me.XrTableCell49.Text = "CÓDIGO"
    Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell49.Weight = 1.0596304862289536R
    '
    'XrTableCell50
    '
    Me.XrTableCell50.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell50.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell50.Name = "XrTableCell50"
    Me.XrTableCell50.StylePriority.UseBorders = False
    Me.XrTableCell50.StylePriority.UseFont = False
    Me.XrTableCell50.StylePriority.UseTextAlignment = False
    Me.XrTableCell50.Text = "RAZÓN DEL CAMBIO"
    Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell50.Weight = 2.0150563899253404R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.StylePriority.UseBorders = False
    Me.XrTableCell1.StylePriority.UseFont = False
    Me.XrTableCell1.StylePriority.UseTextAlignment = False
    Me.XrTableCell1.Text = "AUTORIZA"
    Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell1.Weight = 2.4980660965549815R
    '
    'XrTableCell4
    '
    Me.XrTableCell4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell4.Name = "XrTableCell4"
    Me.XrTableCell4.StylePriority.UseBorders = False
    Me.XrTableCell4.StylePriority.UseFont = False
    Me.XrTableCell4.StylePriority.UseTextAlignment = False
    Me.XrTableCell4.Text = "FECHA"
    Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell4.Weight = 1.1125044611274995R
    '
    'PageHeader
    '
    Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6, Me.XrLabel16})
    Me.PageHeader.HeightF = 100.0!
    Me.PageHeader.Name = "PageHeader"
    '
    'srepOtherMaterialsChange
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
    Me.Landscape = True
    Me.Margins = New System.Drawing.Printing.Margins(27, 9, 9, 0)
    Me.PageHeight = 850
    Me.PageWidth = 1100
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtMaterialDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtUoM As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtMaterialQuantity As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtAreaID As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtSupplierStockCode As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtComments As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtDateChange As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
End Class
