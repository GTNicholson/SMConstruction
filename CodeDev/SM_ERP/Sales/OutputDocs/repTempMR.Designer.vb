<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repTempMR
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
    Me.xrlMatReqDesc = New DevExpress.XtraReports.UI.XRLabel()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlOTNumber = New DevExpress.XtraReports.UI.XRLabel()
    Me.OT = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlMatReqDesc})
    Me.Detail.HeightF = 46.875!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'xrlMatReqDesc
    '
    Me.xrlMatReqDesc.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
    Me.xrlMatReqDesc.Name = "xrlMatReqDesc"
    Me.xrlMatReqDesc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlMatReqDesc.SizeF = New System.Drawing.SizeF(140.625!, 25.0!)
    Me.xrlMatReqDesc.Text = "XrLabel1"
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
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.xrlOTNumber, Me.OT})
    Me.ReportHeader.HeightF = 100.0!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrLabel3
    '
    Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 75.0!)
    Me.XrLabel3.Name = "XrLabel3"
    Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel3.SizeF = New System.Drawing.SizeF(78.12502!, 25.0!)
    Me.XrLabel3.Text = "Material"
    '
    'xrlOTNumber
    '
    Me.xrlOTNumber.LocationFloat = New DevExpress.Utils.PointFloat(114.0625!, 10.00001!)
    Me.xrlOTNumber.Name = "xrlOTNumber"
    Me.xrlOTNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlOTNumber.SizeF = New System.Drawing.SizeF(78.12502!, 25.0!)
    Me.xrlOTNumber.Text = "OT Number"
    '
    'OT
    '
    Me.OT.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
    Me.OT.Name = "OT"
    Me.OT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.OT.SizeF = New System.Drawing.SizeF(78.12502!, 25.0!)
    Me.OT.Text = "OT"
    '
    'repTempMR
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents xrlOTNumber As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents OT As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlMatReqDesc As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
End Class
