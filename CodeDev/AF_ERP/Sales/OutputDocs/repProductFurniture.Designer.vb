<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repProductFurniture
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
    Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
    Me.subrepMaterials = New DevExpress.XtraReports.UI.XRSubreport()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2, Me.subrepMaterials})
    Me.Detail.HeightF = 39.58333!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrSubreport2
    '
    Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(334.7917!, 0!)
    Me.XrSubreport2.Name = "XrSubreport2"
    Me.XrSubreport2.SizeF = New System.Drawing.SizeF(305.2083!, 37.5!)
    '
    'subrepMaterials
    '
    Me.subrepMaterials.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.subrepMaterials.Name = "subrepMaterials"
    Me.subrepMaterials.SizeF = New System.Drawing.SizeF(305.2083!, 37.5!)
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
    Me.BottomMargin.HeightF = 2.0!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel28})
    Me.ReportHeader.HeightF = 36.4583!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrLabel28
    '
    Me.XrLabel28.BackColor = System.Drawing.Color.Black
    Me.XrLabel28.BorderColor = System.Drawing.Color.Black
    Me.XrLabel28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel28.ForeColor = System.Drawing.Color.White
    Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
    Me.XrLabel28.Name = "XrLabel28"
    Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel28.SizeF = New System.Drawing.SizeF(817.0001!, 23.0!)
    Me.XrLabel28.StylePriority.UseBackColor = False
    Me.XrLabel28.StylePriority.UseBorderColor = False
    Me.XrLabel28.StylePriority.UseBorders = False
    Me.XrLabel28.StylePriority.UseFont = False
    Me.XrLabel28.StylePriority.UseForeColor = False
    Me.XrLabel28.StylePriority.UseTextAlignment = False
    Me.XrLabel28.Text = "LISTA DE MADERA"
    Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'repProductFurniture
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Margins = New System.Drawing.Printing.Margins(0, 31, 6, 2)
    Me.Version = "17.1"
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents subrepMaterials As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
End Class
