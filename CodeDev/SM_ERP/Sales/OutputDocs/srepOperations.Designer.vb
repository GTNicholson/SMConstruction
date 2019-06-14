<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class srepOperations
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
    components = New System.ComponentModel.Container
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Detail.Name = "Detail"
    Me.TopMargin.Height = 100
    Me.TopMargin.Name = "TopMargin"
    Me.BottomMargin.Height = 100
    Me.BottomMargin.Name = "BottomMargin"
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
End Class
