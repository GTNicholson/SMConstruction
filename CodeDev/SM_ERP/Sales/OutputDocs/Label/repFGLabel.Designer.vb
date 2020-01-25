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
    Me.XrPanel5 = New DevExpress.XtraReports.UI.XRPanel()
    Me.xrlDestination = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPanel4 = New DevExpress.XtraReports.UI.XRPanel()
    Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
    Me.xrlDescription2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlDescription1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
    Me.xrlOTNumber = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
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
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel5, Me.XrPanel4, Me.XrPanel2, Me.XrPanel3, Me.XrPanel1, Me.XrPictureBox1, Me.XrPictureBox3})
    Me.Detail.HeightF = 385.0!
    Me.Detail.KeepTogether = True
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrPanel5
    '
    Me.XrPanel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel5.BorderWidth = 2.0!
    Me.XrPanel5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlDestination, Me.XrLabel6})
    Me.XrPanel5.LocationFloat = New DevExpress.Utils.PointFloat(117.7085!, 247.3196!)
    Me.XrPanel5.Name = "XrPanel5"
    Me.XrPanel5.SizeF = New System.Drawing.SizeF(431.33!, 50.00003!)
    Me.XrPanel5.StylePriority.UseBorders = False
    Me.XrPanel5.StylePriority.UseBorderWidth = False
    '
    'xrlDestination
    '
    Me.xrlDestination.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlDestination.Font = New System.Drawing.Font("Arial", 11.0!)
    Me.xrlDestination.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 33.00002!)
    Me.xrlDestination.Name = "xrlDestination"
    Me.xrlDestination.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDestination.SizeF = New System.Drawing.SizeF(411.33!, 13.64352!)
    Me.xrlDestination.StylePriority.UseBorders = False
    Me.xrlDestination.StylePriority.UseFont = False
    Me.xrlDestination.StylePriority.UseTextAlignment = False
    Me.xrlDestination.Text = "Customer:"
    Me.xrlDestination.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel6
    '
    Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel6.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00013!, 9.99999!)
    Me.XrLabel6.Name = "XrLabel6"
    Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel6.SizeF = New System.Drawing.SizeF(103.6178!, 23.0!)
    Me.XrLabel6.StylePriority.UseBorders = False
    Me.XrLabel6.StylePriority.UseFont = False
    Me.XrLabel6.StylePriority.UseTextAlignment = False
    Me.XrLabel6.Text = "Destination:"
    Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    '
    'XrPanel4
    '
    Me.XrPanel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel4.BorderWidth = 2.0!
    Me.XrPanel4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel3})
    Me.XrPanel4.LocationFloat = New DevExpress.Utils.PointFloat(117.7084!, 185.7455!)
    Me.XrPanel4.Name = "XrPanel4"
    Me.XrPanel4.SizeF = New System.Drawing.SizeF(431.3301!, 61.57411!)
    Me.XrPanel4.StylePriority.UseBorders = False
    Me.XrPanel4.StylePriority.UseBorderWidth = False
    '
    'XrLabel2
    '
    Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel2.Font = New System.Drawing.Font("Arial", 11.0!)
    Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.999996!, 33.00004!)
    Me.XrLabel2.Name = "XrLabel2"
    Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel2.SizeF = New System.Drawing.SizeF(307.1635!, 18.57405!)
    Me.XrLabel2.StylePriority.UseBorders = False
    Me.XrLabel2.StylePriority.UseFont = False
    Me.XrLabel2.StylePriority.UseTextAlignment = False
    Me.XrLabel2.Text = "Nicaragua"
    Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrLabel3
    '
    Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel3.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00023!, 10.00004!)
    Me.XrLabel3.Name = "XrLabel3"
    Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel3.SizeF = New System.Drawing.SizeF(103.618!, 23.0!)
    Me.XrLabel3.StylePriority.UseBorders = False
    Me.XrLabel3.StylePriority.UseFont = False
    Me.XrLabel3.StylePriority.UseTextAlignment = False
    Me.XrLabel3.Text = "Origin:"
    Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'XrPanel2
    '
    Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel2.BorderWidth = 2.0!
    Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlDescription2, Me.xrlDescription1, Me.XrLabel4})
    Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(117.7085!, 109.8751!)
    Me.XrPanel2.Name = "XrPanel2"
    Me.XrPanel2.SizeF = New System.Drawing.SizeF(431.33!, 75.87048!)
    Me.XrPanel2.StylePriority.UseBorders = False
    Me.XrPanel2.StylePriority.UseBorderWidth = False
    '
    'xrlDescription2
    '
    Me.xrlDescription2.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlDescription2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
    Me.xrlDescription2.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 53.50049!)
    Me.xrlDescription2.Name = "xrlDescription2"
    Me.xrlDescription2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDescription2.SizeF = New System.Drawing.SizeF(411.33!, 22.36998!)
    Me.xrlDescription2.StylePriority.UseBorders = False
    Me.xrlDescription2.StylePriority.UseFont = False
    Me.xrlDescription2.StylePriority.UseTextAlignment = False
    Me.xrlDescription2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'xrlDescription1
    '
    Me.xrlDescription1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlDescription1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
    Me.xrlDescription1.LocationFloat = New DevExpress.Utils.PointFloat(9.430726!, 32.99999!)
    Me.xrlDescription1.Name = "xrlDescription1"
    Me.xrlDescription1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDescription1.SizeF = New System.Drawing.SizeF(411.8993!, 20.50052!)
    Me.xrlDescription1.StylePriority.UseBorders = False
    Me.xrlDescription1.StylePriority.UseFont = False
    Me.xrlDescription1.StylePriority.UseTextAlignment = False
    Me.xrlDescription1.Text = "Customer:"
    Me.xrlDescription1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrLabel4
    '
    Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel4.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00013!, 10.00001!)
    Me.XrLabel4.Name = "XrLabel4"
    Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel4.SizeF = New System.Drawing.SizeF(103.6178!, 23.00001!)
    Me.XrLabel4.StylePriority.UseBorders = False
    Me.XrLabel4.StylePriority.UseFont = False
    Me.XrLabel4.StylePriority.UseTextAlignment = False
    Me.XrLabel4.Text = "Description:"
    Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
    '
    'XrPanel3
    '
    Me.XrPanel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrPanel3.BorderWidth = 2.0!
    Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlOTNumber, Me.XrLabel9, Me.XrLabel7, Me.XrLabel8, Me.XrBarCode1})
    Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(117.7083!, 297.3197!)
    Me.XrPanel3.Name = "XrPanel3"
    Me.XrPanel3.SizeF = New System.Drawing.SizeF(431.3302!, 60.11096!)
    Me.XrPanel3.StylePriority.UseBorders = False
    Me.XrPanel3.StylePriority.UseBorderWidth = False
    '
    'xrlOTNumber
    '
    Me.xrlOTNumber.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlOTNumber.Font = New System.Drawing.Font("Arial", 10.0!)
    Me.xrlOTNumber.LocationFloat = New DevExpress.Utils.PointFloat(236.2502!, 32.9998!)
    Me.xrlOTNumber.Name = "xrlOTNumber"
    Me.xrlOTNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlOTNumber.SizeF = New System.Drawing.SizeF(80.9137!, 23.00008!)
    Me.xrlOTNumber.StylePriority.UseBorders = False
    Me.xrlOTNumber.StylePriority.UseFont = False
    Me.xrlOTNumber.StylePriority.UseTextAlignment = False
    Me.xrlOTNumber.Text = "1"
    Me.xrlOTNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'XrLabel9
    '
    Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(236.2502!, 9.999887!)
    Me.XrLabel9.Name = "XrLabel9"
    Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel9.SizeF = New System.Drawing.SizeF(80.91327!, 22.99991!)
    Me.XrLabel9.StylePriority.UseBorders = False
    Me.XrLabel9.StylePriority.UseFont = False
    Me.XrLabel9.StylePriority.UseTextAlignment = False
    Me.XrLabel9.Text = "OT:"
    Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
    Me.XrLabel8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
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
    Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(117.7083!, 59.87504!)
    Me.XrPanel1.Name = "XrPanel1"
    Me.XrPanel1.SizeF = New System.Drawing.SizeF(431.3302!, 50.00003!)
    Me.XrPanel1.StylePriority.UseBorders = False
    Me.XrPanel1.StylePriority.UseBorderWidth = False
    '
    'xrlCustomer
    '
    Me.xrlCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.xrlCustomer.Font = New System.Drawing.Font("Arial", 11.0!)
    Me.xrlCustomer.LocationFloat = New DevExpress.Utils.PointFloat(10.00045!, 22.99999!)
    Me.xrlCustomer.Name = "xrlCustomer"
    Me.xrlCustomer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlCustomer.SizeF = New System.Drawing.SizeF(411.3297!, 23.64348!)
    Me.xrlCustomer.StylePriority.UseBorders = False
    Me.xrlCustomer.StylePriority.UseFont = False
    Me.xrlCustomer.StylePriority.UseTextAlignment = False
    Me.xrlCustomer.Text = "Customer:"
    Me.xrlCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel1
    '
    Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
    Me.XrLabel1.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(28.75032!, 10.00001!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(103.6177!, 12.99998!)
    Me.XrLabel1.StylePriority.UseBorders = False
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.StylePriority.UseTextAlignment = False
    Me.XrLabel1.Text = "Client:"
    Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
    '
    'XrPictureBox1
    '
    Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
    Me.XrPictureBox1.BorderWidth = 2.0!
    Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
    Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(117.7083!, 0!)
    Me.XrPictureBox1.Name = "XrPictureBox1"
    Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(363.2775!, 59.87503!)
    Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    Me.XrPictureBox1.StylePriority.UseBorders = False
    Me.XrPictureBox1.StylePriority.UseBorderWidth = False
    '
    'XrPictureBox3
    '
    Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
    Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(2.416776!, 59.87503!)
    Me.XrPictureBox3.Name = "XrPictureBox3"
    Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(115.2916!, 299.0139!)
    Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
    '
    'TopMargin
    '
    Me.TopMargin.HeightF = 2.91667!
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
    Me.Margins = New System.Drawing.Printing.Margins(10, 0, 3, 5)
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
  Friend WithEvents XrPanel5 As DevExpress.XtraReports.UI.XRPanel
  Friend WithEvents xrlDestination As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrPanel4 As DevExpress.XtraReports.UI.XRPanel
  Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlOTNumber As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
End Class
