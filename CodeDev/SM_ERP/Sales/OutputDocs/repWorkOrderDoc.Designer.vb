﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.xrlWorkOrderNo = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlCustomerName = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlProjectName = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlProductName = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlCantidad = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrProjectType = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrSalesOrderID = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlDateEntered = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrlDueTime = New DevExpress.XtraReports.UI.XRLabel()
    Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
    Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
    Me.xrNotes = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
    Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
    Me.subrepProduct = New DevExpress.XtraReports.UI.XRSubreport()
    Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
    Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
    CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'Detail
    '
    Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2, Me.subrepProduct, Me.XrLabel12, Me.xrNotes})
    Me.Detail.HeightF = 318.3694!
    Me.Detail.Name = "Detail"
    Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'TopMargin
    '
    Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSalesOrderID, Me.XrLabel9, Me.XrLabel3, Me.XrLabel2})
    Me.TopMargin.HeightF = 64.70834!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 7.291667!
    Me.BottomMargin.Name = "BottomMargin"
    Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'ReportHeader
    '
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel28, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel4, Me.XrLabel1, Me.XrLabel30, Me.XrLabel29, Me.xrlDueTime, Me.xrlDateEntered, Me.xrProjectType, Me.xrlCantidad, Me.xrlProductName, Me.xrlProjectName, Me.XrLabel5, Me.xrlCustomerName, Me.xrlWorkOrderNo})
    Me.ReportHeader.HeightF = 184.125!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'xrlWorkOrderNo
    '
    Me.xrlWorkOrderNo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlWorkOrderNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlWorkOrderNo.LocationFloat = New DevExpress.Utils.PointFloat(376.5625!, 97.50001!)
    Me.xrlWorkOrderNo.Name = "xrlWorkOrderNo"
    Me.xrlWorkOrderNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlWorkOrderNo.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.xrlWorkOrderNo.StylePriority.UseBorders = False
    Me.xrlWorkOrderNo.StylePriority.UseFont = False
    Me.xrlWorkOrderNo.StylePriority.UseTextAlignment = False
    Me.xrlWorkOrderNo.Text = "xrlWorkOrdeRNo"
    Me.xrlWorkOrderNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel2
    '
    Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 16.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel2.ForeColor = System.Drawing.Color.Black
    Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
    Me.XrLabel2.Name = "XrLabel2"
    Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
    Me.XrLabel2.SizeF = New System.Drawing.SizeF(440.5208!, 23.0!)
    Me.XrLabel2.StylePriority.UseFont = False
    Me.XrLabel2.StylePriority.UseForeColor = False
    Me.XrLabel2.Text = "Simplemente Madera MILLWORKS  S.A."
    '
    'XrLabel3
    '
    Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 39.95835!)
    Me.XrLabel3.Name = "XrLabel3"
    Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel3.SizeF = New System.Drawing.SizeF(322.9166!, 23.0!)
    Me.XrLabel3.StylePriority.UseFont = False
    Me.XrLabel3.Text = "Departamento de Planeación y Seguimiento"
    '
    'xrlCustomerName
    '
    Me.xrlCustomerName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlCustomerName.LocationFloat = New DevExpress.Utils.PointFloat(22.3958!, 97.50001!)
    Me.xrlCustomerName.Name = "xrlCustomerName"
    Me.xrlCustomerName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlCustomerName.SizeF = New System.Drawing.SizeF(182.625!, 22.91668!)
    Me.xrlCustomerName.StylePriority.UseBorders = False
    Me.xrlCustomerName.StylePriority.UseFont = False
    Me.xrlCustomerName.StylePriority.UseTextAlignment = False
    Me.xrlCustomerName.Text = "xrlCustomerName"
    Me.xrlCustomerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel5
    '
    Me.XrLabel5.BackColor = System.Drawing.Color.Black
    Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel5.ForeColor = System.Drawing.Color.White
    Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(205.0208!, 74.58334!)
    Me.XrLabel5.Name = "XrLabel5"
    Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel5.SizeF = New System.Drawing.SizeF(171.5417!, 22.91667!)
    Me.XrLabel5.StylePriority.UseBackColor = False
    Me.XrLabel5.StylePriority.UseBorders = False
    Me.XrLabel5.StylePriority.UseFont = False
    Me.XrLabel5.StylePriority.UseForeColor = False
    Me.XrLabel5.StylePriority.UseTextAlignment = False
    Me.XrLabel5.Text = "Proyecto"
    Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'xrlProjectName
    '
    Me.xrlProjectName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlProjectName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlProjectName.LocationFloat = New DevExpress.Utils.PointFloat(205.0208!, 97.50001!)
    Me.xrlProjectName.Name = "xrlProjectName"
    Me.xrlProjectName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlProjectName.SizeF = New System.Drawing.SizeF(171.5417!, 22.91668!)
    Me.xrlProjectName.StylePriority.UseBorders = False
    Me.xrlProjectName.StylePriority.UseFont = False
    Me.xrlProjectName.StylePriority.UseTextAlignment = False
    Me.xrlProjectName.Text = "xrlProjectName"
    Me.xrlProjectName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'xrlProductName
    '
    Me.xrlProductName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlProductName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlProductName.LocationFloat = New DevExpress.Utils.PointFloat(22.39583!, 156.125!)
    Me.xrlProductName.Name = "xrlProductName"
    Me.xrlProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlProductName.SizeF = New System.Drawing.SizeF(182.625!, 22.91667!)
    Me.xrlProductName.StylePriority.UseBorders = False
    Me.xrlProductName.StylePriority.UseFont = False
    Me.xrlProductName.StylePriority.UseTextAlignment = False
    Me.xrlProductName.Text = "xrlProductName"
    Me.xrlProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'xrlCantidad
    '
    Me.xrlCantidad.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlCantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlCantidad.LocationFloat = New DevExpress.Utils.PointFloat(205.0208!, 156.125!)
    Me.xrlCantidad.Name = "xrlCantidad"
    Me.xrlCantidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlCantidad.SizeF = New System.Drawing.SizeF(171.5417!, 22.91667!)
    Me.xrlCantidad.StylePriority.UseBorders = False
    Me.xrlCantidad.StylePriority.UseFont = False
    Me.xrlCantidad.StylePriority.UseTextAlignment = False
    Me.xrlCantidad.Text = "xrlCantidad"
    Me.xrlCantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'xrProjectType
    '
    Me.xrProjectType.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrProjectType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrProjectType.LocationFloat = New DevExpress.Utils.PointFloat(376.5625!, 156.125!)
    Me.xrProjectType.Name = "xrProjectType"
    Me.xrProjectType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrProjectType.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.xrProjectType.StylePriority.UseBorders = False
    Me.xrProjectType.StylePriority.UseFont = False
    Me.xrProjectType.StylePriority.UseTextAlignment = False
    Me.xrProjectType.Text = "xrProjectType"
    Me.xrProjectType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel9
    '
    Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(711.2499!, 10.00001!)
    Me.XrLabel9.Name = "XrLabel9"
    Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel9.SizeF = New System.Drawing.SizeF(106.25!, 23.0!)
    Me.XrLabel9.StylePriority.UseFont = False
    Me.XrLabel9.Text = "# Orden de Venta"
    '
    'xrSalesOrderID
    '
    Me.xrSalesOrderID.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.xrSalesOrderID.LocationFloat = New DevExpress.Utils.PointFloat(711.2499!, 33.00002!)
    Me.xrSalesOrderID.Name = "xrSalesOrderID"
    Me.xrSalesOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrSalesOrderID.SizeF = New System.Drawing.SizeF(106.25!, 23.0!)
    Me.xrSalesOrderID.StylePriority.UseFont = False
    Me.xrSalesOrderID.Text = "xrSalesOrderID"
    '
    'xrlDateEntered
    '
    Me.xrlDateEntered.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlDateEntered.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlDateEntered.LocationFloat = New DevExpress.Utils.PointFloat(541.0416!, 97.49998!)
    Me.xrlDateEntered.Name = "xrlDateEntered"
    Me.xrlDateEntered.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDateEntered.SizeF = New System.Drawing.SizeF(128.1249!, 22.91668!)
    Me.xrlDateEntered.StylePriority.UseBorders = False
    Me.xrlDateEntered.StylePriority.UseFont = False
    Me.xrlDateEntered.StylePriority.UseTextAlignment = False
    Me.xrlDateEntered.Text = "xrlDateEntered"
    Me.xrlDateEntered.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'xrlDueTime
    '
    Me.xrlDueTime.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrlDueTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrlDueTime.LocationFloat = New DevExpress.Utils.PointFloat(669.1664!, 97.49998!)
    Me.xrlDueTime.Name = "xrlDueTime"
    Me.xrlDueTime.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrlDueTime.SizeF = New System.Drawing.SizeF(142.8335!, 22.91667!)
    Me.xrlDueTime.StylePriority.UseBorders = False
    Me.xrlDueTime.StylePriority.UseFont = False
    Me.xrlDueTime.StylePriority.UseTextAlignment = False
    Me.xrlDueTime.Text = "xrlDueTime"
    Me.xrlDueTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'PageFooter
    '
    Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel26, Me.XrLabel25})
    Me.PageFooter.HeightF = 59.375!
    Me.PageFooter.Name = "PageFooter"
    '
    'XrLabel12
    '
    Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(22.3958!, 17.06079!)
    Me.XrLabel12.Name = "XrLabel12"
    Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel12.SizeF = New System.Drawing.SizeF(67.60416!, 22.91667!)
    Me.XrLabel12.StylePriority.UseFont = False
    Me.XrLabel12.Text = "Notas"
    '
    'xrNotes
    '
    Me.xrNotes.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.xrNotes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.xrNotes.LocationFloat = New DevExpress.Utils.PointFloat(105.0208!, 9.999974!)
    Me.xrNotes.Name = "xrNotes"
    Me.xrNotes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.xrNotes.SizeF = New System.Drawing.SizeF(696.979!, 237.2917!)
    Me.xrNotes.StylePriority.UseBorders = False
    Me.xrNotes.StylePriority.UseFont = False
    Me.xrNotes.Text = "xrNotes"
    '
    'XrLabel25
    '
    Me.XrLabel25.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(8.895858!, 9.999974!)
    Me.XrLabel25.Name = "XrLabel25"
    Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel25.SizeF = New System.Drawing.SizeF(152.9792!, 22.91667!)
    Me.XrLabel25.StylePriority.UseFont = False
    Me.XrLabel25.Text = "Reporte Generado el:"
    '
    'XrLabel26
    '
    Me.XrLabel26.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
    Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(166.4375!, 10.20826!)
    Me.XrLabel26.Name = "XrLabel26"
    Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel26.SizeF = New System.Drawing.SizeF(152.9792!, 22.91667!)
    Me.XrLabel26.StylePriority.UseFont = False
    Me.XrLabel26.Text = "dd / mm / yy"
    '
    'XrLine1
    '
    Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(20.72913!, 22.55802!)
    Me.XrLine1.Name = "XrLine1"
    Me.XrLine1.SizeF = New System.Drawing.SizeF(194.2917!, 23.0!)
    '
    'XrLabel13
    '
    Me.XrLabel13.Font = New System.Drawing.Font("Arial", 7.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(20.72913!, 57.01637!)
    Me.XrLabel13.Name = "XrLabel13"
    Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel13.SizeF = New System.Drawing.SizeF(66.66669!, 22.91667!)
    Me.XrLabel13.StylePriority.UseFont = False
    Me.XrLabel13.Text = "Planeación"
    '
    'XrLabel28
    '
    Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel28.ForeColor = System.Drawing.Color.Black
    Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(252.7083!, 10.00001!)
    Me.XrLabel28.Name = "XrLabel28"
    Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel28.SizeF = New System.Drawing.SizeF(289.7084!, 23.0!)
    Me.XrLabel28.StylePriority.UseFont = False
    Me.XrLabel28.StylePriority.UseForeColor = False
    Me.XrLabel28.Text = "ORDEN DE TRABAJO (OT)"
    '
    'XrLabel29
    '
    Me.XrLabel29.BackColor = System.Drawing.Color.Black
    Me.XrLabel29.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel29.ForeColor = System.Drawing.Color.White
    Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(376.5625!, 74.58334!)
    Me.XrLabel29.Name = "XrLabel29"
    Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel29.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.XrLabel29.StylePriority.UseBackColor = False
    Me.XrLabel29.StylePriority.UseBorders = False
    Me.XrLabel29.StylePriority.UseFont = False
    Me.XrLabel29.StylePriority.UseForeColor = False
    Me.XrLabel29.StylePriority.UseTextAlignment = False
    Me.XrLabel29.Text = "# OT"
    Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel30
    '
    Me.XrLabel30.BackColor = System.Drawing.Color.Black
    Me.XrLabel30.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel30.ForeColor = System.Drawing.Color.White
    Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(22.3958!, 74.58334!)
    Me.XrLabel30.Name = "XrLabel30"
    Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel30.SizeF = New System.Drawing.SizeF(182.625!, 22.91667!)
    Me.XrLabel30.StylePriority.UseBackColor = False
    Me.XrLabel30.StylePriority.UseBorders = False
    Me.XrLabel30.StylePriority.UseFont = False
    Me.XrLabel30.StylePriority.UseForeColor = False
    Me.XrLabel30.StylePriority.UseTextAlignment = False
    Me.XrLabel30.Text = "Cliente"
    Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel1
    '
    Me.XrLabel1.BackColor = System.Drawing.Color.Black
    Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel1.ForeColor = System.Drawing.Color.White
    Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(22.39583!, 133.2083!)
    Me.XrLabel1.Name = "XrLabel1"
    Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel1.SizeF = New System.Drawing.SizeF(182.625!, 22.91667!)
    Me.XrLabel1.StylePriority.UseBackColor = False
    Me.XrLabel1.StylePriority.UseBorders = False
    Me.XrLabel1.StylePriority.UseFont = False
    Me.XrLabel1.StylePriority.UseForeColor = False
    Me.XrLabel1.StylePriority.UseTextAlignment = False
    Me.XrLabel1.Text = "Producto"
    Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel4
    '
    Me.XrLabel4.BackColor = System.Drawing.Color.Black
    Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel4.ForeColor = System.Drawing.Color.White
    Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(205.0208!, 133.2083!)
    Me.XrLabel4.Name = "XrLabel4"
    Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel4.SizeF = New System.Drawing.SizeF(171.5416!, 22.91667!)
    Me.XrLabel4.StylePriority.UseBackColor = False
    Me.XrLabel4.StylePriority.UseBorders = False
    Me.XrLabel4.StylePriority.UseFont = False
    Me.XrLabel4.StylePriority.UseForeColor = False
    Me.XrLabel4.StylePriority.UseTextAlignment = False
    Me.XrLabel4.Text = "Cantidad"
    Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel6
    '
    Me.XrLabel6.BackColor = System.Drawing.Color.Black
    Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel6.ForeColor = System.Drawing.Color.White
    Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(376.5625!, 133.2083!)
    Me.XrLabel6.Name = "XrLabel6"
    Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel6.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.XrLabel6.StylePriority.UseBackColor = False
    Me.XrLabel6.StylePriority.UseBorders = False
    Me.XrLabel6.StylePriority.UseFont = False
    Me.XrLabel6.StylePriority.UseForeColor = False
    Me.XrLabel6.StylePriority.UseTextAlignment = False
    Me.XrLabel6.Text = "Cantidad"
    Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel7
    '
    Me.XrLabel7.BackColor = System.Drawing.Color.Black
    Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel7.ForeColor = System.Drawing.Color.White
    Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(541.0415!, 74.58334!)
    Me.XrLabel7.Name = "XrLabel7"
    Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel7.SizeF = New System.Drawing.SizeF(128.125!, 22.91667!)
    Me.XrLabel7.StylePriority.UseBackColor = False
    Me.XrLabel7.StylePriority.UseBorders = False
    Me.XrLabel7.StylePriority.UseFont = False
    Me.XrLabel7.StylePriority.UseForeColor = False
    Me.XrLabel7.StylePriority.UseTextAlignment = False
    Me.XrLabel7.Text = "Fecha Realizado"
    Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel8
    '
    Me.XrLabel8.BackColor = System.Drawing.Color.Black
    Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel8.ForeColor = System.Drawing.Color.White
    Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(669.1665!, 74.58331!)
    Me.XrLabel8.Name = "XrLabel8"
    Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel8.SizeF = New System.Drawing.SizeF(142.8334!, 22.91667!)
    Me.XrLabel8.StylePriority.UseBackColor = False
    Me.XrLabel8.StylePriority.UseBorders = False
    Me.XrLabel8.StylePriority.UseFont = False
    Me.XrLabel8.StylePriority.UseForeColor = False
    Me.XrLabel8.StylePriority.UseTextAlignment = False
    Me.XrLabel8.Text = "Fecha Compromiso"
    Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrLabel10
    '
    Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(90.43748!, 57.01637!)
    Me.XrLabel10.Name = "XrLabel10"
    Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel10.SizeF = New System.Drawing.SizeF(114.5833!, 22.91667!)
    Me.XrLabel10.StylePriority.UseFont = False
    Me.XrLabel10.Text = "___//____//____"
    '
    'XrLabel11
    '
    Me.XrLabel11.Font = New System.Drawing.Font("Arial", 7.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(20.72913!, 144.4111!)
    Me.XrLabel11.Name = "XrLabel11"
    Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel11.SizeF = New System.Drawing.SizeF(66.66669!, 22.91667!)
    Me.XrLabel11.StylePriority.UseFont = False
    Me.XrLabel11.Text = "SAWMILLS"
    '
    'XrLine2
    '
    Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(20.72913!, 109.9528!)
    Me.XrLine2.Name = "XrLine2"
    Me.XrLine2.SizeF = New System.Drawing.SizeF(194.2917!, 23.0!)
    '
    'XrLabel16
    '
    Me.XrLabel16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(90.43748!, 144.4111!)
    Me.XrLabel16.Name = "XrLabel16"
    Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel16.SizeF = New System.Drawing.SizeF(114.5833!, 22.91667!)
    Me.XrLabel16.StylePriority.UseFont = False
    Me.XrLabel16.Text = "___//____//____"
    '
    'XrLabel15
    '
    Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(390.1041!, 57.01631!)
    Me.XrLabel15.Name = "XrLabel15"
    Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel15.SizeF = New System.Drawing.SizeF(114.5833!, 22.91667!)
    Me.XrLabel15.StylePriority.UseFont = False
    Me.XrLabel15.Text = "___//____//____"
    '
    'XrLine3
    '
    Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(320.3958!, 22.55802!)
    Me.XrLine3.Name = "XrLine3"
    Me.XrLine3.SizeF = New System.Drawing.SizeF(194.2917!, 23.0!)
    '
    'XrLabel18
    '
    Me.XrLabel18.Font = New System.Drawing.Font("Arial", 7.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(320.3958!, 57.01631!)
    Me.XrLabel18.Name = "XrLabel18"
    Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel18.SizeF = New System.Drawing.SizeF(66.66669!, 22.91667!)
    Me.XrLabel18.StylePriority.UseFont = False
    Me.XrLabel18.Text = "Producción"
    '
    'XrLabel14
    '
    Me.XrLabel14.Font = New System.Drawing.Font("Arial", 7.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(320.3958!, 144.4111!)
    Me.XrLabel14.Name = "XrLabel14"
    Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel14.SizeF = New System.Drawing.SizeF(66.66669!, 22.91667!)
    Me.XrLabel14.StylePriority.UseFont = False
    Me.XrLabel14.Text = "Metal"
    '
    'XrLine4
    '
    Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(320.3958!, 109.9528!)
    Me.XrLine4.Name = "XrLine4"
    Me.XrLine4.SizeF = New System.Drawing.SizeF(194.2917!, 23.0!)
    '
    'XrLabel19
    '
    Me.XrLabel19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(390.1041!, 144.4111!)
    Me.XrLabel19.Name = "XrLabel19"
    Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel19.SizeF = New System.Drawing.SizeF(114.5833!, 22.91667!)
    Me.XrLabel19.StylePriority.UseFont = False
    Me.XrLabel19.Text = "___//____//____"
    '
    'XrLabel17
    '
    Me.XrLabel17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(687.4166!, 57.01637!)
    Me.XrLabel17.Name = "XrLabel17"
    Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel17.SizeF = New System.Drawing.SizeF(114.5833!, 22.91667!)
    Me.XrLabel17.StylePriority.UseFont = False
    Me.XrLabel17.Text = "___//____//____"
    '
    'XrLine5
    '
    Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(617.7082!, 22.55802!)
    Me.XrLine5.Name = "XrLine5"
    Me.XrLine5.SizeF = New System.Drawing.SizeF(194.2917!, 23.0!)
    '
    'XrLabel21
    '
    Me.XrLabel21.Font = New System.Drawing.Font("Arial", 7.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(617.7082!, 57.01637!)
    Me.XrLabel21.Name = "XrLabel21"
    Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel21.SizeF = New System.Drawing.SizeF(66.66669!, 22.91667!)
    Me.XrLabel21.StylePriority.UseFont = False
    Me.XrLabel21.Text = "Costura"
    '
    'XrLabel22
    '
    Me.XrLabel22.Font = New System.Drawing.Font("Arial", 7.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(617.7082!, 144.4111!)
    Me.XrLabel22.Name = "XrLabel22"
    Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel22.SizeF = New System.Drawing.SizeF(66.66669!, 22.91667!)
    Me.XrLabel22.StylePriority.UseFont = False
    Me.XrLabel22.Text = "Compras"
    '
    'XrLine6
    '
    Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(617.7082!, 109.9528!)
    Me.XrLine6.Name = "XrLine6"
    Me.XrLine6.SizeF = New System.Drawing.SizeF(194.2917!, 23.0!)
    '
    'XrLabel23
    '
    Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
    Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(687.4166!, 144.4111!)
    Me.XrLabel23.Name = "XrLabel23"
    Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLabel23.SizeF = New System.Drawing.SizeF(114.5833!, 22.91667!)
    Me.XrLabel23.StylePriority.UseFont = False
    Me.XrLabel23.Text = "___//____//____"
    '
    'subrepProduct
    '
    Me.subrepProduct.LocationFloat = New DevExpress.Utils.PointFloat(0!, 271.1221!)
    Me.subrepProduct.Name = "subrepProduct"
    Me.subrepProduct.SizeF = New System.Drawing.SizeF(172.9166!, 23.0!)
    '
    'XrSubreport2
    '
    Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 294.1221!)
    Me.XrSubreport2.Name = "XrSubreport2"
    Me.XrSubreport2.SizeF = New System.Drawing.SizeF(172.9166!, 23.0!)
    '
    'ReportFooter
    '
    Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.XrLine6, Me.XrLabel23, Me.XrLabel17, Me.XrLabel21, Me.XrLine5, Me.XrLabel14, Me.XrLine4, Me.XrLabel19, Me.XrLabel15, Me.XrLabel18, Me.XrLine3, Me.XrLabel13, Me.XrLine2, Me.XrLabel16, Me.XrLabel10, Me.XrLabel11, Me.XrLine1})
    Me.ReportFooter.HeightF = 177.5236!
    Me.ReportFooter.Name = "ReportFooter"
    '
    'repWorkOrderDoc
    '
    Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter, Me.ReportFooter})
    Me.Margins = New System.Drawing.Printing.Margins(11, 17, 65, 7)
    Me.Version = "17.1"
    CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents xrlWorkOrderNo As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrProjectType As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlCantidad As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlProductName As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlProjectName As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlCustomerName As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrSalesOrderID As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlDateEntered As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrlDueTime As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents xrNotes As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
  Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents subrepProduct As DevExpress.XtraReports.UI.XRSubreport
  Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
  Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
  Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
