<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repWorkOrderDoc
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
    Me.subrepProduct = New DevExpress.XtraReports.UI.XRSubreport()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.xrlWorkOrderNo = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.subrepProduct})
    Me.Detail.HeightF = 311.4583!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'subrepProduct
    '
    Me.subrepProduct.LocationFloat = New DevExpress.Utils.PointFloat(0!, 123.9583!)
    Me.subrepProduct.Name = "subrepProduct"
    Me.subrepProduct.SizeF = New System.Drawing.SizeF(650.0!, 187.5!)
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
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlWorkOrderNo, Me.XrLabel1})
    Me.ReportHeader.HeightF = 48.95833!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'xrlWorkOrderNo
    '
    Me.xrlWorkOrderNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlWorkOrderNo.LocationFloat = New DevExpress.Utils.PointFloat(160.9375!, 0!)
    Me.xrlWorkOrderNo.Name = "xrlWorkOrderNo"
    Me.xrlWorkOrderNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlWorkOrderNo.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.xrlWorkOrderNo.StylePriority.UseFont = False
    Me.xrlWorkOrderNo.Text = "xrlWorkOrdeRNo"
    '
    'XrLabel1
    '
    Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "Orden de Trabajo"
    '
    'repWorkOrderDoc
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.Version = "17.1"
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents subrepProduct As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents xrlWorkOrderNo As DevExpress.XtraReports.UI.XRLabel
End Class
