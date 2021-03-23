<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class repWorkOrderStockItemMaterialRequirement
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
    Me.XrTable9 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xtcComments = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xtcCurrentInventory = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.xtcQuantity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xtcCurrentQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xtcUoM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xtcDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable9, Me.XrTable8, Me.XrTable4, Me.XrTable1})
        Me.Detail.HeightF = 15.02604!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable9
        '
        Me.XrTable9.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable9.BackColor = System.Drawing.Color.White
        Me.XrTable9.BorderColor = System.Drawing.Color.Black
        Me.XrTable9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable9.ForeColor = System.Drawing.Color.Black
        Me.XrTable9.LocationFloat = New DevExpress.Utils.PointFloat(646.093!, 0!)
        Me.XrTable9.Name = "XrTable9"
        Me.XrTable9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTable9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
        Me.XrTable9.SizeF = New System.Drawing.SizeF(164.907!, 15.02604!)
        Me.XrTable9.StylePriority.UseBackColor = False
        Me.XrTable9.StylePriority.UseBorderColor = False
        Me.XrTable9.StylePriority.UseBorders = False
        Me.XrTable9.StylePriority.UseFont = False
        Me.XrTable9.StylePriority.UseForeColor = False
        Me.XrTable9.StylePriority.UsePadding = False
        Me.XrTable9.StylePriority.UseTextAlignment = False
        Me.XrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcComments})
        Me.XrTableRow9.Font = New System.Drawing.Font("Cambria", 7.0!)
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow9.StylePriority.UseFont = False
        Me.XrTableRow9.StylePriority.UsePadding = False
        Me.XrTableRow9.Weight = 1.0R
        '
        'xtcComments
        '
        Me.xtcComments.CanGrow = False
        Me.xtcComments.Name = "xtcComments"
        Me.xtcComments.Weight = 0.46086824427345063R
        '
        'XrTable8
        '
        Me.XrTable8.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable8.BackColor = System.Drawing.Color.White
        Me.XrTable8.BorderColor = System.Drawing.Color.Black
        Me.XrTable8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable8.ForeColor = System.Drawing.Color.Black
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(578.4011!, 0!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(56.46057!, 15.02604!)
        Me.XrTable8.StylePriority.UseBackColor = False
        Me.XrTable8.StylePriority.UseBorderColor = False
        Me.XrTable8.StylePriority.UseBorders = False
        Me.XrTable8.StylePriority.UseFont = False
        Me.XrTable8.StylePriority.UseForeColor = False
        Me.XrTable8.StylePriority.UseTextAlignment = False
        Me.XrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcCurrentInventory})
        Me.XrTableRow8.Font = New System.Drawing.Font("Cambria", 7.0!)
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow8.StylePriority.UseFont = False
        Me.XrTableRow8.StylePriority.UsePadding = False
        Me.XrTableRow8.Weight = 1.0R
        '
        'xtcCurrentInventory
        '
        Me.xtcCurrentInventory.CanGrow = False
        Me.xtcCurrentInventory.Name = "xtcCurrentInventory"
        Me.xtcCurrentInventory.Weight = 0.46086824427345063R
        '
        'XrTable4
        '
        Me.XrTable4.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable4.BackColor = System.Drawing.Color.White
        Me.XrTable4.BorderColor = System.Drawing.Color.Black
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable4.ForeColor = System.Drawing.Color.Black
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(396.9489!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(170.6591!, 15.02604!)
        Me.XrTable4.StylePriority.UseBackColor = False
        Me.XrTable4.StylePriority.UseBorderColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseForeColor = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcQuantity, Me.xtcCurrentQty, Me.xtcUoM})
        Me.XrTableRow4.Font = New System.Drawing.Font("Cambria", 7.0!)
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow4.StylePriority.UseFont = False
        Me.XrTableRow4.StylePriority.UsePadding = False
        Me.XrTableRow4.Weight = 1.0R
        '
        'xtcQuantity
        '
        Me.xtcQuantity.CanGrow = False
        Me.xtcQuantity.Name = "xtcQuantity"
        Me.xtcQuantity.Weight = 0.46086824427345063R
        '
        'xtcCurrentQty
        '
        Me.xtcCurrentQty.CanGrow = False
        Me.xtcCurrentQty.Name = "xtcCurrentQty"
        Me.xtcCurrentQty.Weight = 0.46086824427345063R
        '
        'xtcUoM
        '
        Me.xtcUoM.CanGrow = False
        Me.xtcUoM.Name = "xtcUoM"
        Me.xtcUoM.Weight = 0.440771344240368R
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
        Me.XrTable1.SizeF = New System.Drawing.SizeF(385.8506!, 15.02604!)
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
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xtcDescription})
        Me.XrTableRow2.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0!)
        Me.XrTableRow2.StylePriority.UseFont = False
        Me.XrTableRow2.StylePriority.UsePadding = False
        Me.XrTableRow2.Weight = 1.0R
        '
        'xtcDescription
        '
        Me.xtcDescription.CanGrow = False
        Me.xtcDescription.Name = "xtcDescription"
        Me.xtcDescription.StylePriority.UseTextAlignment = False
        Me.xtcDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xtcDescription.Weight = 3.0805518161418148R
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
        Me.BottomMargin.HeightF = 9.432284!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.ReportHeader.HeightF = 9.111116!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable2
        '
        Me.XrTable2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable2.BackColor = System.Drawing.Color.White
        Me.XrTable2.BorderColor = System.Drawing.Color.Black
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.ForeColor = System.Drawing.Color.Black
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 28.81433!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(385.8506!, 18.58152!)
        Me.XrTable2.StylePriority.UseBackColor = False
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseForeColor = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1})
        Me.XrTableRow1.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0!)
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.StylePriority.UsePadding = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Descripción de Material"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 3.0805516721897708R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6, Me.XrTable5, Me.XrTable3, Me.XrLabel3, Me.XrTable2})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SalesItemType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 47.39585!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable6
        '
        Me.XrTable6.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable6.BackColor = System.Drawing.Color.White
        Me.XrTable6.BorderColor = System.Drawing.Color.Black
        Me.XrTable6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable6.ForeColor = System.Drawing.Color.Black
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(646.093!, 28.81433!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(164.907!, 18.58152!)
        Me.XrTable6.StylePriority.UseBackColor = False
        Me.XrTable6.StylePriority.UseBorderColor = False
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseForeColor = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9})
        Me.XrTableRow6.Font = New System.Drawing.Font("Cambria", 7.0!)
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow6.StylePriority.UseFont = False
        Me.XrTableRow6.StylePriority.UsePadding = False
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell9.CanGrow = False
        Me.XrTableCell9.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.Text = "Observaciones"
        Me.XrTableCell9.Weight = 0.46086860375767408R
        '
        'XrTable5
        '
        Me.XrTable5.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable5.BackColor = System.Drawing.Color.White
        Me.XrTable5.BorderColor = System.Drawing.Color.Black
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable5.ForeColor = System.Drawing.Color.Black
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(578.4012!, 28.81433!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(56.46057!, 18.58152!)
        Me.XrTable5.StylePriority.UseBackColor = False
        Me.XrTable5.StylePriority.UseBorderColor = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseForeColor = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7})
        Me.XrTableRow5.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow5.StylePriority.UseFont = False
        Me.XrTableRow5.StylePriority.UsePadding = False
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.Text = "Existencias"
        Me.XrTableCell7.Weight = 0.46086860375767408R
        '
        'XrTable3
        '
        Me.XrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable3.BackColor = System.Drawing.Color.White
        Me.XrTable3.BorderColor = System.Drawing.Color.Black
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.ForeColor = System.Drawing.Color.Black
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(396.9489!, 28.81434!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(169.357!, 18.5815!)
        Me.XrTable3.StylePriority.UseBackColor = False
        Me.XrTable3.StylePriority.UseBorderColor = False
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseForeColor = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell4})
        Me.XrTableRow3.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow3.StylePriority.UseFont = False
        Me.XrTableRow3.StylePriority.UsePadding = False
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.Text = "Cant. Original"
        Me.XrTableCell3.Weight = 0.46441179039801095R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell5.CanGrow = False
        Me.XrTableCell5.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UseForeColor = False
        Me.XrTableCell5.Text = "Cant. Actual"
        Me.XrTableCell5.Weight = 0.45732541711733721R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell4.CanGrow = False
        Me.XrTableCell4.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.StylePriority.UseForeColor = False
        Me.XrTableCell4.Text = "UdM"
        Me.XrTableCell4.Weight = 0.4407720732614161R
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(811.0001!, 24.87507!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "MATERIALES ESTIMADOS REQUERIDOS"
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
        Me.XrLine1.SizeF = New System.Drawing.SizeF(811.0001!, 9.111116!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorders = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'repWorkOrderStockItemMaterialRequirement
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(7, 32, 9, 9)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents xtcDescription As DevExpress.XtraReports.UI.XRTableCell
  Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
  Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
  Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable9 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xtcComments As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xtcCurrentInventory As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xtcQuantity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtcUoM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xtcCurrentQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
