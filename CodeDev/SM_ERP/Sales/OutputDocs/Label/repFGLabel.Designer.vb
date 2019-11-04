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
    Dim Code39ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repFGLabel))
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.xrpImage = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
    Me.xrlDescription2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlDescription1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
    Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
    Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
    Me.xrlCustomer = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrpImage, Me.XrPanel2, Me.XrPanel3, Me.XrPanel1, Me.XrPictureBox1, Me.XrPictureBox3})
    Me.Detail.HeightF = 385.0!
    Me.Detail.KeepTogether = True
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'xrpImage
    '
    Me.xrpImage.LocationFloat = New DevExpress.Utils.PointFloat(370.9133!, 88.00002!)
    Me.xrpImage.Name = "xrpImage"
    Me.xrpImage.SizeF = New System.Drawing.SizeF(209.0866!, 272.2083!)
    Me.xrpImage.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    '
    'XrPanel2
    '
    Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel2.BorderWidth = 2.0!
    Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlDescription2, Me.xrlDescription1, Me.XrLabel4})
    Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(117.7083!, 175.1528!)
    Me.XrPanel2.Name = "XrPanel2"
    Me.XrPanel2.SizeF = New System.Drawing.SizeF(246.2501!, 113.4862!)
    Me.XrPanel2.StylePriority.UseBorders = False
    Me.XrPanel2.StylePriority.UseBorderWidth = False
    '
    'xrlDescription2
    '
    Me.xrlDescription2.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlDescription2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.xrlDescription2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 80.81534!)
    Me.xrlDescription2.Name = "xrlDescription2"
    Me.xrlDescription2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDescription2.SizeF = New System.Drawing.SizeF(222.9998!, 32.67085!)
    Me.xrlDescription2.StylePriority.UseBorders = False
    Me.xrlDescription2.StylePriority.UseFont = False
    Me.xrlDescription2.Text = "Customer:"
    '
    'xrlDescription1
    '
    Me.xrlDescription1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlDescription1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.xrlDescription1.LocationFloat = New DevExpress.Utils.PointFloat(9.430726!, 33.00002!)
    Me.xrlDescription1.Name = "xrlDescription1"
    Me.xrlDescription1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDescription1.SizeF = New System.Drawing.SizeF(223.5691!, 47.81532!)
    Me.xrlDescription1.StylePriority.UseBorders = False
    Me.xrlDescription1.StylePriority.UseFont = False
    Me.xrlDescription1.Text = "Customer:"
    '
    'XrLabel4
    '
    Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel4.Font = New System.Drawing.Font("Arial", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00003!)
    Me.XrLabel4.Name = "XrLabel4"
    Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel4.SizeF = New System.Drawing.SizeF(135.2538!, 22.99999!)
    Me.XrLabel4.StylePriority.UseBorders = False
    Me.XrLabel4.StylePriority.UseFont = False
    Me.XrLabel4.Text = "Description:"
    '
    'XrPanel3
    '
    Me.XrPanel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel3.BorderWidth = 2.0!
    Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel8, Me.XrBarCode1})
    Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(117.7082!, 288.639!)
    Me.XrPanel3.Name = "XrPanel3"
    Me.XrPanel3.SizeF = New System.Drawing.SizeF(246.2502!, 71.56931!)
    Me.XrPanel3.StylePriority.UseBorders = False
    Me.XrPanel3.StylePriority.UseBorderWidth = False
    '
    'XrLabel7
    '
    Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel7.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(57.19553!, 9.999887!)
    Me.XrLabel7.Name = "XrLabel7"
    Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel7.SizeF = New System.Drawing.SizeF(18.66196!, 23.00008!)
    Me.XrLabel7.StylePriority.UseBorders = False
    Me.XrLabel7.StylePriority.UseFont = False
    Me.XrLabel7.Text = "1"
    '
    'XrLabel8
    '
    Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 10.00001!)
    Me.XrLabel8.Name = "XrLabel8"
    Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel8.SizeF = New System.Drawing.SizeF(47.19555!, 22.99992!)
    Me.XrLabel8.StylePriority.UseBorders = False
    Me.XrLabel8.StylePriority.UseFont = False
    Me.XrLabel8.Text = "QTY:"
    '
    'XrBarCode1
    '
    Me.XrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrBarCode1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold)
    Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(75.8575!, 9.999887!)
    Me.XrBarCode1.Module = 1.07!
    Me.XrBarCode1.Name = "XrBarCode1"
    Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
    Me.XrBarCode1.SizeF = New System.Drawing.SizeF(160.3927!, 51.56939!)
    Me.XrBarCode1.StylePriority.UseBorders = False
    Me.XrBarCode1.StylePriority.UseFont = False
    Code39ExtendedGenerator1.CalcCheckSum = False
    Code39ExtendedGenerator1.WideNarrowRatio = 2.0!
    Me.XrBarCode1.Symbology = Code39ExtendedGenerator1
    Me.XrBarCode1.Text = "FG000001"
    '
    'XrPanel1
    '
    Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel1.BorderWidth = 2.0!
    Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlCustomer, Me.XrLabel1})
    Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(117.7083!, 88.00005!)
    Me.XrPanel1.Name = "XrPanel1"
    Me.XrPanel1.SizeF = New System.Drawing.SizeF(246.2501!, 87.1528!)
    Me.XrPanel1.StylePriority.UseBorders = False
    Me.XrPanel1.StylePriority.UseBorderWidth = False
    '
    'xrlCustomer
    '
    Me.xrlCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlCustomer.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlCustomer.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 33.00002!)
    Me.xrlCustomer.Name = "xrlCustomer"
    Me.xrlCustomer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlCustomer.SizeF = New System.Drawing.SizeF(222.9998!, 54.15273!)
    Me.xrlCustomer.StylePriority.UseBorders = False
    Me.xrlCustomer.StylePriority.UseFont = False
    Me.xrlCustomer.Text = "Customer:"
    '
    'XrLabel1
    '
    Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel1.Font = New System.Drawing.Font("Arial", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00002!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(111.2153!, 22.99999!)
    Me.XrLabel1.StylePriority.UseBorders = False
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.Text = "Client:"
    '
    'XrPictureBox1
    '
    Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.XrPictureBox1.BorderWidth = 2.0!
    Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
    Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(117.7083!, 9.999996!)
    Me.XrPictureBox1.Name = "XrPictureBox1"
    Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(246.2501!, 56.74997!)
    Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    Me.XrPictureBox1.StylePriority.UseBorders = False
    Me.XrPictureBox1.StylePriority.UseBorderWidth = False
    '
    'XrPictureBox3
    '
    Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
    Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(2.41669!, 88.00005!)
    Me.XrPictureBox3.Name = "XrPictureBox3"
    Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(115.2916!, 272.2083!)
    Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 5.0!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 5.0!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'repFGLabel
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
    Me.Landscape = True
    Me.Margins = New System.Drawing.Printing.Margins(10, 0, 5, 5)
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
  Friend WithEvents xrlCustomer As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
  Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
  Friend WithEvents xrlDescription2 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlDescription1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
  Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
  Friend WithEvents xrpImage As DevExpress.XtraReports.UI.XRPictureBox
End Class
