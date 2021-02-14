Imports DevExpress.Spreadsheet
Imports RTIS.CommonVB
Imports RTIS.CommonVB.clsGeneralA


Public Class clsExcelExportStockTake
  Private pSpreadSheet As DevExpress.Spreadsheet.Workbook
  Private pStockTake As dmStockTake
  Private pStockTakeItemEditors As colStockTakeItemEditors
  Private pRTISGlobal As AppRTISGlobal
  Private pFileName As String
  Private pTemplateFileName As String
  Private pSummarised As Boolean
  Private pStockTakes As colStockTakes

  Private Const cColPosCount As Integer = 0
  Private Const cColStockCode As Integer = 1
  Private Const cColDescription As Integer = 2
  Private Const cColCategory As Integer = 3
  Private Const cColCurrentInventory As Integer = 3
  Private Const cColStdCost As Integer = 4
  Private Const cColTotalAmount As Integer = 5

  Private pColumnCount As Integer = 5
  Private pHeaderRow As Integer = 5


  Private pCurrentSheet As DevExpress.Spreadsheet.Worksheet

  Private Const cColumnRowPos As Integer = 5

  Private pLastRow As Integer = 0

  Private pFirstRow As Integer = 0

  Public Sub New(ByRef rStockTake As dmStockTake, ByRef rStockTakeItemEditors As colStockTakeItemEditors)
    pStockTake = rStockTake
    pStockTakeItemEditors = rStockTakeItemEditors
  End Sub

  Public Property WorkBook As DevExpress.Spreadsheet.Workbook
    Get
      Return pSpreadSheet
    End Get
    Set(value As DevExpress.Spreadsheet.Workbook)
      pSpreadSheet = value
    End Set
  End Property

  Private Sub AddHeadings(ByVal vRowForTitlesToStartIn As Integer)
    Dim mRange As DevExpress.Spreadsheet.Range
    Dim mCurColPos As Integer
    Dim mIMHead As String


    'Title in
    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(1, 1, pColumnCount, 1)
    mRange.Merge
    mRange.Borders.SetAllBorders(Color.LightSlateGray, BorderLineStyle.Thin)
    mRange.Fill.BackgroundColor = Color.LightSlateGray
    mRange.Value = "Agro Forestal"
    mRange.Font.Size = 24
    mRange.Font.Bold = True
    mRange.Font.Color = Color.Black
    mRange.Font.Name = "Arial"

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(1, 2, pColumnCount, 2)
    mRange.Merge
    mRange.Borders.SetAllBorders(Color.LightSlateGray, BorderLineStyle.Thin)
    mRange.Fill.BackgroundColor = Color.LightSlateGray
    mRange.Value = "Reporte de Toma de Inventario al " & pStockTake.StockTakeDate.ToShortDateString
    mRange.Font.Size = 16
    mRange.Font.Bold = True
    mRange.Font.Color = Color.Black
    mRange.Font.Name = "Arial"

    ''mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(vRowForTitlesToStartIn + 1, cColCurrentInventory, cColTotalAmount, vRowForTitlesToStartIn + 1)
    ''mRange.Borders.SetAllBorders(Color.LightSlateGray, BorderLineStyle.Thick)
    ''mRange.Fill.BackgroundColor = Color.Blue

    'HEADINGS in

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(cColStockCode, vRowForTitlesToStartIn, pColumnCount, vRowForTitlesToStartIn)
    mRange.Fill.BackgroundColor = Color.Lavender
    mRange.Borders.BottomBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Thin
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Alignment.WrapText = True
    mRange.Font.Size = 12
    mRange.ColumnWidthInCharacters = 12
    mRange.Font.Bold = True

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColStockCode).Value = "Código Producto"
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColStockCode).ColumnWidthInCharacters = 20

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColDescription).Value = "Descripción"
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColDescription).ColumnWidthInCharacters = 100

    ''pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColCategory).Value = "Categoría"
    ''pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColCategory).ColumnWidthInCharacters = 30

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColCurrentInventory).Value = "Cantidad"
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColStdCost).Value = "Costo Promedio "
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColTotalAmount).Value = "Monto Total (C$)"
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColTotalAmount).ColumnWidthInCharacters = 30
    ''mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRowForTitlesToStartIn, pColumnCount, vRowForTitlesToStartIn)
    ''mRange.AutoFitColumns

  End Sub

  Public Sub CreateSpreadSheet()
    pSpreadSheet = New DevExpress.Spreadsheet.Workbook
    pCurrentSheet = pSpreadSheet.Worksheets(0)
    AddHeader()
    AddHeadings(cColumnRowPos)
    pFirstRow = cColumnRowPos
    AddItems(eStockItemCategory.NailsAndBolds, pFirstRow)
    AddItems(eStockItemCategory.Abrasivos, pFirstRow)
    AddItems(eStockItemCategory.Herrajes, pFirstRow)
    AddItems(eStockItemCategory.Herramientas, pFirstRow)
    AddItems(eStockItemCategory.PinturaYQuimico, pFirstRow)
    AddItems(eStockItemCategory.MatElect, pFirstRow)
    AddItems(eStockItemCategory.EPP, pFirstRow)
    AddItems(eStockItemCategory.Metal, pFirstRow)
    AddItems(eStockItemCategory.Herramientas, pFirstRow)
    AddItems(eStockItemCategory.VidrioYEspejo, pFirstRow)
    AddItems(eStockItemCategory.Repuestos, pFirstRow)
    AddItems(eStockItemCategory.MatEmpaque, pFirstRow)
    AddItems(eStockItemCategory.Tapiceria, pFirstRow)
    AddItems(eStockItemCategory.MatVarios, pFirstRow)


    AddItems(eStockItemCategory.Laminas, pFirstRow)



    ''CreatePivotTable()
  End Sub

  Private Sub CreatePivotTable()
    Dim sourceWorksheet As Worksheet = WorkBook.Worksheets("Sheet1")
    Dim worksheet As Worksheet = WorkBook.Worksheets.Add()
    Dim mReference As String = ""



    WorkBook.Worksheets.ActiveWorksheet = worksheet

    mReference = "B" & cColumnRowPos + 1
    mReference &= ": G" & pLastRow

    ' Create a pivot table using the cell range "A1:D41" as the data source.
    Dim pivotTable As PivotTable = worksheet.PivotTables.Add(sourceWorksheet(mReference), worksheet("B2"))

    pivotTable.BandedColumns = True
    pivotTable.Style = WorkBook.TableStyles.DefaultPivotStyle
    pivotTable.Layout.SetReportLayout(PivotReportLayout.Tabular)
    ' Add the "Category" field to the row axis area.
    pivotTable.RowFields.Add(pivotTable.Fields("Categoría"))
    ' Add the "Product" field to the row axis area.
    pivotTable.RowFields.Add(pivotTable.Fields("Código Producto"))
    pivotTable.RowFields.Add(pivotTable.Fields("Descripción"))
    ' Add the "Sales" field to the data area.
    ''pivotTable.DataFields.Add(pivotTable.Fields("Monto Total (C$)"))
    Dim dataField As PivotDataField = pivotTable.DataFields.Add(pivotTable.Fields("Monto Total (C$)"))
    ' Specify the number format for the data field.
    dataField.NumberFormat = "C$#,##0.00"

    pivotTable.Layout.ShowRowGrandTotals = False
  End Sub

  Private Sub AddHeader()
    ''pCurrentSheet.Cells(1, 1).SetValue(pStockTake.Description)
    ''pCurrentSheet.Cells(1, 1).SetValue("Hola")

  End Sub


  Private Sub AddItems(ByVal vCategory As eStockItemCategory, ByRef rStartPosition As Integer)
    Dim mStockItemVal As New clsStockTakeItemEditor
    Dim mTotalCounted As Decimal = 0
    Dim mTotalAmount As Decimal = 0

    Dim mRow As Integer
    Dim mRange As DevExpress.Spreadsheet.Range

    mRow = rStartPosition + 1




    pCurrentSheet.Cells(mRow, cColStockCode).SetValue(clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), vCategory))
    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(cColStockCode, mRow, pColumnCount, mRow)
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Font.Color = Color.Black
    mRange.Font.FontStyle = SpreadsheetFontStyle.Bold
    mRange.Font.Size = 14
    mRange.Merge()


    mRow = mRow + 1

    For Each mItem As clsStockTakeItemEditor In pStockTakeItemEditors

      If mItem.IsCounted And mItem.StockItem.Category = vCategory Then

        pCurrentSheet.Cells(mRow, cColStockCode).SetValue(mItem.StockItem.StockCode)

        pCurrentSheet.Cells(mRow, cColDescription).SetValue(mItem.StockItem.Description)


        pCurrentSheet.Cells(mRow, cColCategory).SetValue(mItem.StockItemCategoryDesc)

        pCurrentSheet.Cells(mRow, cColStdCost).SetValue(mItem.AverageCost)

        pCurrentSheet.Cells(mRow, cColCurrentInventory).SetValue(mItem.CountedQty + mItem.WriteOffQuantity)
        mTotalCounted += mItem.CountedQty

        pCurrentSheet.Cells(mRow, cColTotalAmount).SetValue(mItem.CountedValue + mItem.WriteOffValue)
        pCurrentSheet.Cells(mRow, cColTotalAmount).NumberFormat = "C$#,##0.00"
        mTotalAmount += mItem.CountedValue + mItem.WriteOffValue

        mRow = mRow + 1
      End If
    Next
    pLastRow = mRow


    pCurrentSheet.Rows.Group(rStartPosition + 2, mRow - 1, True)
    rStartPosition = pLastRow

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(cColStockCode, mRow, cColCategory + 1, mRow)
    mRange.Merge
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Value = "Valor Total de " & clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(vCategory, eStockItemCategory))
    mRange.Font.Size = 12
    mRange.Font.Bold = True
    mRange.Font.Color = Color.Black

    pCurrentSheet.Cells(mRow, cColCurrentInventory).SetValue(mTotalCounted)
    pCurrentSheet.Cells(mRow, cColCurrentInventory).Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    pCurrentSheet.Cells(mRow, cColCurrentInventory).FillColor = Color.LightGray

    pCurrentSheet.Cells(mRow, cColTotalAmount).SetValue(mTotalAmount)
    pCurrentSheet.Cells(mRow, cColTotalAmount).Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    pCurrentSheet.Cells(mRow, cColTotalAmount).FillColor = Color.LightGray
    pCurrentSheet.Cells(mRow, cColTotalAmount).NumberFormat = "C$#,##0.00"

    pCurrentSheet.Cells(mRow, cColTotalAmount).Font.Size = 12
    pCurrentSheet.Cells(mRow, cColTotalAmount).Font.Bold = True
    pCurrentSheet.Cells(mRow, cColTotalAmount).Font.Color = Color.Black

  End Sub



  Public Property TemplateFileName As String
    Get
      Return pTemplateFileName
    End Get
    Set(value As String)
      pTemplateFileName = value
    End Set
  End Property

  Private Sub New(ByRef rStockTake As dmStockTake, ByRef rWorkBookTemplate As DevExpress.Spreadsheet.Workbook)
    pStockTake = rStockTake
    pStockTakeItemEditors = New colStockTakeItemEditors

    pSpreadSheet = rWorkBookTemplate
    pRTISGlobal = AppRTISGlobal.GetInstance

  End Sub

  Public Sub New(ByRef rProductionBatch As dmStockTake, ByRef rWorkBookTemplate As DevExpress.Spreadsheet.Workbook, ByRef rSummarised As Boolean)
    Me.New(rProductionBatch, rWorkBookTemplate)
    pSummarised = rSummarised
  End Sub



End Class
