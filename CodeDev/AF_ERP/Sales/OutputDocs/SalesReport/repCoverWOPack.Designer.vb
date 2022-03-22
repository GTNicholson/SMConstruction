<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repCoverWOPack
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
    Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xtcDescription = New DevExpress.XtraReports.UI.XRTableCell()
    Me.xtcQuantity = New DevExpress.XtraReports.UI.XRTableCell()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
    Me.txtProjectName = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
    Me.Detail.HeightF = 15.02604!
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
    Me.XrTable1.SizeF = New System.Drawing.SizeF(813.0001!, 15.02604!)
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
    Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcDescription, Me.xtcQuantity})
    Me.XrTableRow2.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
    Me.XrTableRow2.Name = "XrTableRow2"
    Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0!)
    Me.XrTableRow2.StylePriority.UseFont = False
    Me.XrTableRow2.StylePriority.UsePadding = False
    Me.XrTableRow2.Weight = 1.0R
    '
    'xtcDescription
    '
    Me.xtcDescription.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xtcDescription.BorderWidth = 1.0!
    Me.xtcDescription.CanGrow = False
    Me.xtcDescription.Font = New System.Drawing.Font("Arial", 7.0!)
    Me.xtcDescription.Name = "xtcDescription"
    Me.xtcDescription.StylePriority.UseBorders = False
    Me.xtcDescription.StylePriority.UseBorderWidth = False
    Me.xtcDescription.StylePriority.UseFont = False
    Me.xtcDescription.StylePriority.UseTextAlignment = False
    Me.xtcDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    Me.xtcDescription.Weight = 3.0805518161418148R
    '
    'xtcQuantity
    '
    Me.xtcQuantity.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xtcQuantity.BorderWidth = 1.0!
    Me.xtcQuantity.CanGrow = False
    Me.xtcQuantity.Font = New System.Drawing.Font("Arial", 7.0!)
    Me.xtcQuantity.Name = "xtcQuantity"
    Me.xtcQuantity.StylePriority.UseBorders = False
    Me.xtcQuantity.StylePriority.UseBorderWidth = False
    Me.xtcQuantity.StylePriority.UseFont = False
    Me.xtcQuantity.StylePriority.UseTextAlignment = False
    Me.xtcQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    Me.xtcQuantity.Weight = 6.7162982041655788R
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
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtProjectName, Me.XrLabel3, Me.XrLine1})
    Me.ReportHeader.HeightF = 78.90279!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrLabel3
    '
    Me.XrLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 54.02772!)
    Me.XrLabel3.Name = "XrLabel3"
    Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel3.SizeF = New System.Drawing.SizeF(813.0!, 24.87507!)
    Me.XrLabel3.StylePriority.UseFont = False
    Me.XrLabel3.StylePriority.UseTextAlignment = False
    Me.XrLabel3.Text = "Lista de Ordenes de Trabajo"
    Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLine1
    '
    Me.XrLine1.BackColor = System.Drawing.Color.LightGray
    Me.XrLine1.BorderColor = System.Drawing.Color.LightGray
    Me.XrLine1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLine1.BorderWidth = 3.0!
    Me.XrLine1.ForeColor = System.Drawing.Color.LightGray
    Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrLine1.Name = "XrLine1"
    Me.XrLine1.SizeF = New System.Drawing.SizeF(813.0!, 9.111116!)
    Me.XrLine1.StylePriority.UseBackColor = False
    Me.XrLine1.StylePriority.UseBorderColor = False
    Me.XrLine1.StylePriority.UseBorders = False
    Me.XrLine1.StylePriority.UseBorderWidth = False
    Me.XrLine1.StylePriority.UseForeColor = False
    '
    'txtProjectName
    '
    Me.txtProjectName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.txtProjectName.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
    Me.txtProjectName.Name = "txtProjectName"
    Me.txtProjectName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.txtProjectName.SizeF = New System.Drawing.SizeF(813.0001!, 24.87507!)
    Me.txtProjectName.StylePriority.UseFont = False
    Me.txtProjectName.StylePriority.UseTextAlignment = False
    Me.txtProjectName.Text = "Proyecto"
    Me.txtProjectName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'repCoverWOPack
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Margins = New System.Drawing.Printing.Margins(7, 30, 9, 0)
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xtcDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents xtcQuantity As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents txtProjectName As DevExpress.XtraReports.UI.XRLabel
End Class
