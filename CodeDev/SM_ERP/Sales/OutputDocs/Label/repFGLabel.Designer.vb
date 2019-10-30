<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repFGLabel
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repFGLabel))
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
    Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrPictureBox3})
    Me.Detail.HeightF = 400.0!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 0!
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
    'XrPictureBox1
    '
    Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.XrPictureBox1.BorderWidth = 2.0!
    Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
    Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
    Me.XrPictureBox1.Name = "XrPictureBox1"
    Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(414.2361!, 83.41665!)
    Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    Me.XrPictureBox1.StylePriority.UseBorders = False
    Me.XrPictureBox1.StylePriority.UseBorderWidth = False
    '
    'XrPictureBox2
    '
    Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
    Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(424.2362!, 0!)
    Me.XrPictureBox2.Name = "XrPictureBox2"
    Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(175.7639!, 97.30554!)
    Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    '
    'XrPictureBox3
    '
    Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
    Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 120.7917!)
    Me.XrPictureBox3.Name = "XrPictureBox3"
    Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(203.125!, 269.2083!)
    Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    '
    'XrLabel1
    '
    Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999997!, 10.00002!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
    Me.XrLabel1.StylePriority.UseBorders = False
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "Customer:"
    '
    'XrPanel1
    '
    Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel1.BorderWidth = 2.0!
    Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
    Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(203.125!, 120.7917!)
    Me.XrPanel1.Name = "XrPanel1"
    Me.XrPanel1.SizeF = New System.Drawing.SizeF(386.8751!, 98.61112!)
    Me.XrPanel1.StylePriority.UseBorders = False
    Me.XrPanel1.StylePriority.UseBorderWidth = False
    '
    'XrLabel2
    '
    Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(121.2153!, 10.00002!)
    Me.XrLabel2.Name = "XrLabel2"
    Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel2.SizeF = New System.Drawing.SizeF(255.6597!, 43.88882!)
    Me.XrLabel2.StylePriority.UseBorders = False
    Me.XrLabel2.StylePriority.UseFont = False
    Me.XrLabel2.Text = "Customer:"
    '
    'repFGLabel
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
    Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
    Me.PageHeight = 400
    Me.PageWidth = 600
    Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
    Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
    Me.Version = "17.1"
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
  Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
End Class
