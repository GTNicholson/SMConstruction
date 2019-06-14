<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repProductFurniture
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
    Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
    Me.subrepMaterials = New DevExpress.XtraReports.UI.XRSubreport()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.xrlNotes = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2, Me.subrepMaterials})
    Me.Detail.HeightF = 100.0!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrSubreport2
    '
    Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(334.7917!, 34.375!)
    Me.XrSubreport2.Name = "XrSubreport2"
    Me.XrSubreport2.SizeF = New System.Drawing.SizeF(305.2083!, 37.5!)
    '
    'subrepMaterials
    '
    Me.subrepMaterials.LocationFloat = New DevExpress.Utils.PointFloat(4.791673!, 34.375!)
    Me.subrepMaterials.Name = "subrepMaterials"
    Me.subrepMaterials.SizeF = New System.Drawing.SizeF(305.2083!, 37.5!)
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 100.0!
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
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlNotes, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
    Me.ReportHeader.HeightF = 133.3333!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'xrlNotes
    '
    Me.xrlNotes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.xrlNotes.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 73.95834!)
    Me.xrlNotes.Name = "xrlNotes"
    Me.xrlNotes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlNotes.SizeF = New System.Drawing.SizeF(629.9999!, 49.37499!)
    Me.xrlNotes.StylePriority.UseFont = False
    Me.xrlNotes.Text = "XrLabel2"
    '
    'XrLabel3
    '
    Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(141.6667!, 41.66667!)
    Me.XrLabel3.Name = "XrLabel3"
    Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel3.SizeF = New System.Drawing.SizeF(115.625!, 22.91667!)
    Me.XrLabel3.StylePriority.UseFont = False
    Me.XrLabel3.Text = "XrLabel2"
    '
    'XrLabel2
    '
    Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 41.66667!)
    Me.XrLabel2.Name = "XrLabel2"
    Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel2.SizeF = New System.Drawing.SizeF(115.625!, 22.91667!)
    Me.XrLabel2.StylePriority.UseFont = False
    Me.XrLabel2.Text = "XrLabel2"
    '
    'XrLabel1
    '
    Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(115.625!, 22.91666!)
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "Producto: Mueble"
    '
    'repProductFurniture
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Version = "17.1"
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents subrepMaterials As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlNotes As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
