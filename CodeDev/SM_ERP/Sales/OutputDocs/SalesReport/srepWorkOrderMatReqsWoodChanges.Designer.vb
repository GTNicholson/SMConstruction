<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class srepWorkOrderMatReqsWoodChanges
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
    Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xrtcChangeReason = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtcDate = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtComponentDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtUnitPiece = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtcTotalPieces = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtNetThickness = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtNetWidth = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtNetLenght = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtGrossLenghtFeet = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtBoardFeet = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtMaterialTypeID = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtWoodSpecieID = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xrtQualityType = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.xrlTotalBoardFeet = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.Detail.HeightF = 35.02604!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrTable1
    '
    Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
    Me.XrTable1.BackColor = System.Drawing.Color.White
    Me.XrTable1.BorderColor = System.Drawing.Color.Black
    Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.XrTable1.ForeColor = System.Drawing.Color.Black
    Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrTable1.Name = "XrTable1"
    Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
    Me.XrTable1.SizeF = New System.Drawing.SizeF(1026.0!, 35.02604!)
    Me.XrTable1.StylePriority.UseBackColor = False
    Me.XrTable1.StylePriority.UseBorderColor = False
    Me.XrTable1.StylePriority.UseBorders = False
    Me.XrTable1.StylePriority.UseFont = False
    Me.XrTable1.StylePriority.UseForeColor = False
    Me.XrTable1.StylePriority.UseTextAlignment = False
    Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow2
    '
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtcChangeReason, Me.xrtcDate, Me.xrtComponentDescription, Me.xrtUnitPiece, Me.xrtcTotalPieces, Me.xrtNetThickness, Me.xrtNetWidth, Me.xrtNetLenght, Me.xrtGrossLenghtFeet, Me.xrtBoardFeet, Me.xrtMaterialTypeID, Me.xrtWoodSpecieID, Me.xrtQualityType, Me.XrTableCell2})
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Weight = 1.0R
    '
    'xrtcChangeReason
    '
    Me.xrtcChangeReason.CanGrow = False
    Me.xrtcChangeReason.Name = "xrtcChangeReason"
    Me.xrtcChangeReason.Weight = 1.1660356187192102R
    '
    'xrtcDate
    '
    Me.xrtcDate.CanGrow = False
    Me.xrtcDate.Name = "xrtcDate"
    Me.xrtcDate.Weight = 0.5119814517420247R
    '
    'xrtComponentDescription
    '
    Me.xrtComponentDescription.CanGrow = False
    Me.xrtComponentDescription.Name = "xrtComponentDescription"
    Me.xrtComponentDescription.Weight = 0.91672770937679959R
    '
    'xrtUnitPiece
    '
    Me.xrtUnitPiece.CanGrow = False
    Me.xrtUnitPiece.Name = "xrtUnitPiece"
    Me.xrtUnitPiece.Weight = 0.44017833610490065R
    '
    'xrtcTotalPieces
    '
    Me.xrtcTotalPieces.CanGrow = False
    Me.xrtcTotalPieces.Name = "xrtcTotalPieces"
    Me.xrtcTotalPieces.Weight = 0.52003110498549443R
    '
    'xrtNetThickness
    '
    Me.xrtNetThickness.CanGrow = False
    Me.xrtNetThickness.Name = "xrtNetThickness"
    Me.xrtNetThickness.Weight = 0.39129001227839427R
    '
    'xrtNetWidth
    '
    Me.xrtNetWidth.CanGrow = False
    Me.xrtNetWidth.Name = "xrtNetWidth"
    Me.xrtNetWidth.Weight = 0.45992655125449627R
    '
    'xrtNetLenght
    '
    Me.xrtNetLenght.CanGrow = False
    Me.xrtNetLenght.Name = "xrtNetLenght"
    Me.xrtNetLenght.Weight = 0.35484517720718067R
    '
    'xrtGrossLenghtFeet
    '
    Me.xrtGrossLenghtFeet.CanGrow = False
    Me.xrtGrossLenghtFeet.Name = "xrtGrossLenghtFeet"
    Me.xrtGrossLenghtFeet.Weight = 0.434741087306193R
    '
    'xrtBoardFeet
    '
    Me.xrtBoardFeet.CanGrow = False
    Me.xrtBoardFeet.Name = "xrtBoardFeet"
    Me.xrtBoardFeet.Weight = 0.61469908525127714R
    '
    'xrtMaterialTypeID
    '
    Me.xrtMaterialTypeID.CanGrow = False
    Me.xrtMaterialTypeID.Name = "xrtMaterialTypeID"
    Me.xrtMaterialTypeID.Weight = 0.58215037829088545R
    '
    'xrtWoodSpecieID
    '
    Me.xrtWoodSpecieID.CanGrow = False
    Me.xrtWoodSpecieID.Name = "xrtWoodSpecieID"
    Me.xrtWoodSpecieID.Weight = 0.55612508368459268R
    '
    'xrtQualityType
    '
    Me.xrtQualityType.CanGrow = False
    Me.xrtQualityType.Name = "xrtQualityType"
    Me.xrtQualityType.Weight = 0.49382825719924806R
    '
    'XrTableCell2
    '
    Me.XrTableCell2.CanGrow = False
    Me.XrTableCell2.Name = "XrTableCell2"
    Me.XrTableCell2.Weight = 0.74881362789057559R
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 9.375!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 10.04973!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'xrlTotalBoardFeet
    '
    Me.xrlTotalBoardFeet.BackColor = System.Drawing.Color.Black
    Me.xrlTotalBoardFeet.BorderColor = System.Drawing.Color.Black
    Me.xrlTotalBoardFeet.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlTotalBoardFeet.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.xrlTotalBoardFeet.ForeColor = System.Drawing.Color.White
    Me.xrlTotalBoardFeet.LocationFloat = New DevExpress.Utils.PointFloat(650.7878!, 0.00003405979!)
    Me.xrlTotalBoardFeet.Name = "xrlTotalBoardFeet"
    Me.xrlTotalBoardFeet.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlTotalBoardFeet.SizeF = New System.Drawing.SizeF(76.99329!, 32.29167!)
    Me.xrlTotalBoardFeet.StylePriority.UseBackColor = False
    Me.xrlTotalBoardFeet.StylePriority.UseBorderColor = False
    Me.xrlTotalBoardFeet.StylePriority.UseBorders = False
    Me.xrlTotalBoardFeet.StylePriority.UseFont = False
    Me.xrlTotalBoardFeet.StylePriority.UseForeColor = False
    XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
    Me.xrlTotalBoardFeet.Summary = XrSummary1
    Me.xrlTotalBoardFeet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel12
    '
    Me.XrLabel12.BackColor = System.Drawing.Color.White
    Me.XrLabel12.BorderColor = System.Drawing.Color.Black
    Me.XrLabel12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.XrLabel12.ForeColor = System.Drawing.Color.Black
    Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrLabel12.Name = "XrLabel12"
    Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel12.SizeF = New System.Drawing.SizeF(650.7879!, 32.2917!)
    Me.XrLabel12.StylePriority.UseBackColor = False
    Me.XrLabel12.StylePriority.UseBorderColor = False
    Me.XrLabel12.StylePriority.UseBorders = False
    Me.XrLabel12.StylePriority.UseFont = False
    Me.XrLabel12.StylePriority.UseForeColor = False
    Me.XrLabel12.Text = "CAMBIOS NECESARIOS"
    Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTable5
    '
    Me.XrTable5.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
    Me.XrTable5.BackColor = System.Drawing.Color.White
    Me.XrTable5.BorderColor = System.Drawing.Color.Black
    Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrTable5.ForeColor = System.Drawing.Color.Black
    Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 32.60789!)
    Me.XrTable5.Name = "XrTable5"
    Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
    Me.XrTable5.SizeF = New System.Drawing.SizeF(1026.0!, 35.02604!)
    Me.XrTable5.StylePriority.UseBackColor = False
    Me.XrTable5.StylePriority.UseBorderColor = False
    Me.XrTable5.StylePriority.UseBorders = False
    Me.XrTable5.StylePriority.UseFont = False
    Me.XrTable5.StylePriority.UseForeColor = False
    Me.XrTable5.StylePriority.UseTextAlignment = False
    Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow5
    '
    Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell33, Me.XrTableCell35, Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell1})
    Me.XrTableRow5.Name = "XrTableRow5"
    Me.XrTableRow5.Weight = 1.0R
    '
    'XrTableCell27
    '
    Me.XrTableCell27.CanGrow = False
    Me.XrTableCell27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell27.Name = "XrTableCell27"
    Me.XrTableCell27.StylePriority.UseFont = False
    Me.XrTableCell27.Text = "Razón de cambio"
    Me.XrTableCell27.Weight = 1.1660355040620274R
    '
    'XrTableCell28
    '
    Me.XrTableCell28.CanGrow = False
    Me.XrTableCell28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell28.Name = "XrTableCell28"
    Me.XrTableCell28.StylePriority.UseFont = False
    Me.XrTableCell28.Text = "Fecha"
    Me.XrTableCell28.Weight = 0.51198139293810818R
    '
    'XrTableCell29
    '
    Me.XrTableCell29.CanGrow = False
    Me.XrTableCell29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell29.Name = "XrTableCell29"
    Me.XrTableCell29.StylePriority.UseFont = False
    Me.XrTableCell29.Text = "Componente"
    Me.XrTableCell29.Weight = 0.91672751439803835R
    '
    'XrTableCell30
    '
    Me.XrTableCell30.CanGrow = False
    Me.XrTableCell30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell30.Name = "XrTableCell30"
    Me.XrTableCell30.StylePriority.UseFont = False
    Me.XrTableCell30.Text = "Piezas Unit"
    Me.XrTableCell30.Weight = 0.44017851414199677R
    '
    'XrTableCell31
    '
    Me.XrTableCell31.CanGrow = False
    Me.XrTableCell31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell31.Name = "XrTableCell31"
    Me.XrTableCell31.StylePriority.UseFont = False
    Me.XrTableCell31.Text = "Total piezas"
    Me.XrTableCell31.Weight = 0.520031104909125R
    '
    'XrTableCell33
    '
    Me.XrTableCell33.CanGrow = False
    Me.XrTableCell33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell33.Name = "XrTableCell33"
    Me.XrTableCell33.StylePriority.UseFont = False
    Me.XrTableCell33.Text = "Grosor cm"
    Me.XrTableCell33.Weight = 0.3912899828205107R
    '
    'XrTableCell35
    '
    Me.XrTableCell35.CanGrow = False
    Me.XrTableCell35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell35.Name = "XrTableCell35"
    Me.XrTableCell35.StylePriority.UseFont = False
    Me.XrTableCell35.Text = "Ancho cm"
    Me.XrTableCell35.Weight = 0.459926004392978R
    '
    'XrTableCell37
    '
    Me.XrTableCell37.CanGrow = False
    Me.XrTableCell37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell37.Name = "XrTableCell37"
    Me.XrTableCell37.StylePriority.UseFont = False
    Me.XrTableCell37.Text = "Largo cm"
    Me.XrTableCell37.Weight = 0.35484563475820197R
    '
    'XrTableCell38
    '
    Me.XrTableCell38.CanGrow = False
    Me.XrTableCell38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell38.Name = "XrTableCell38"
    Me.XrTableCell38.StylePriority.UseFont = False
    Me.XrTableCell38.Text = "Bruto pies"
    Me.XrTableCell38.Weight = 0.43474157750391473R
    '
    'XrTableCell39
    '
    Me.XrTableCell39.CanGrow = False
    Me.XrTableCell39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell39.Name = "XrTableCell39"
    Me.XrTableCell39.StylePriority.UseFont = False
    Me.XrTableCell39.Text = "PT Bruto"
    Me.XrTableCell39.Weight = 0.61469810275005321R
    '
    'XrTableCell40
    '
    Me.XrTableCell40.CanGrow = False
    Me.XrTableCell40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell40.Name = "XrTableCell40"
    Me.XrTableCell40.StylePriority.UseFont = False
    Me.XrTableCell40.Text = "Material"
    Me.XrTableCell40.Weight = 0.58215086004333882R
    '
    'XrTableCell41
    '
    Me.XrTableCell41.CanGrow = False
    Me.XrTableCell41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell41.Name = "XrTableCell41"
    Me.XrTableCell41.StylePriority.UseFont = False
    Me.XrTableCell41.Text = "Especie"
    Me.XrTableCell41.Weight = 0.55612507868629091R
    '
    'XrTableCell42
    '
    Me.XrTableCell42.CanGrow = False
    Me.XrTableCell42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell42.Name = "XrTableCell42"
    Me.XrTableCell42.StylePriority.UseFont = False
    Me.XrTableCell42.Text = "Calidad"
    Me.XrTableCell42.Weight = 0.49382819695039915R
    '
    'XrTableCell1
    '
    Me.XrTableCell1.CanGrow = False
    Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableCell1.Name = "XrTableCell1"
    Me.XrTableCell1.StylePriority.UseFont = False
    Me.XrTableCell1.Text = "Autoriza"
    Me.XrTableCell1.Weight = 0.74881355333501731R
    '
    'PageHeader
    '
    Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.xrlTotalBoardFeet, Me.XrTable5})
    Me.PageHeader.HeightF = 67.63394!
    Me.PageHeader.Name = "PageHeader"
    '
    'srepWorkOrderMatReqsWoodChanges
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
    Me.Landscape = True
    Me.Margins = New System.Drawing.Printing.Margins(36, 28, 9, 10)
    Me.PageHeight = 850
    Me.PageWidth = 1100
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xrtcChangeReason As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtcDate As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtComponentDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtUnitPiece As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtcTotalPieces As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtNetThickness As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtNetWidth As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtNetLenght As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtGrossLenghtFeet As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtBoardFeet As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtMaterialTypeID As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtWoodSpecieID As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrtQualityType As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents xrlTotalBoardFeet As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
End Class
