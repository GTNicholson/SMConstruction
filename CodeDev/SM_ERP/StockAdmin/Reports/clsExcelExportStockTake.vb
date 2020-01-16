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
  Private Const cColItemType As Integer = 4
  Private Const cColPartNumber As Integer = 5
  Private Const cColCurrentInventory As Integer = 6
  Private Const cColRequiredInventory As Integer = 7
  Private Const cColOrderedQty As Integer = 8
  Private Const cColBalance As Integer = 9

  Private pColumnCount As Integer = 9
  Private pHeaderRow As Integer = 3


  Public Property WorkBook As DevExpress.Spreadsheet.Workbook
    Get
      Return pSpreadSheet
    End Get
    Set(value As DevExpress.Spreadsheet.Workbook)
      pSpreadSheet = value
    End Set
  End Property

  Private Sub AddHeadings(ByVal vRowForTitlesToStartIn As Integer, Optional ByVal vIsSummarised As Boolean = False)
    Dim mRange As DevExpress.Spreadsheet.Range
    Dim mCurColPos As Integer
    Dim mIMHead As String

    'Title in
    pSpreadSheet.Worksheets(0).Cells(1, 1).Value = "Reporte"
    pSpreadSheet.Worksheets(0).Cells(1, 1).Font.Size = 15
    pSpreadSheet.Worksheets(0).Cells(1, 1).Font.Bold = True


    'HEADINGS in
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColPosCount).Value = "Cnt "

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColStockCode).Value = "Código Producto "

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColDescription).Value = "Descripción "

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColCategory).Value = "Categoría "

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColItemType).Value = "Sub Categoria "
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColPartNumber).Value = "Número de Parte "

    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColCurrentInventory).Value = "Inventario Actual "
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColOrderedQty).Value = "Cantidad Pedida "
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColRequiredInventory).Value = "Cantidad Requerida "
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColOrderedQty).Value = "Cantidad Pedidas "
    pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, cColBalance).Value = "Saldo "

    mCurColPos = cColBalance - 1
    For Each mStockTakes As dmStockTake In pStockTakes

      mCurColPos += 1
      pSpreadSheet.Worksheets(0).Cells(vRowForTitlesToStartIn, mCurColPos).Value = mStockTakes.StockTakeID

    Next

    pColumnCount = mCurColPos

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRowForTitlesToStartIn, pColumnCount, vRowForTitlesToStartIn)
    mRange.Fill.BackgroundColor = Color.Lavender
    mRange.Borders.BottomBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Thick
    mRange.Alignment.WrapText = True
    mRange.Alignment.RotationAngle = 90
    mRange.Font.Bold = True

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(cColDescription, pHeaderRow - 1, cColCategory, pHeaderRow - 1)

    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.Lavender
    mRange.Borders.SetAllBorders(Color.DarkSlateGray, DevExpress.Spreadsheet.BorderLineStyle.Thin)
    mRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
    pSpreadSheet.Worksheets(0).Cells(pHeaderRow - 1, cColDescription).Value = "Frame"




  End Sub

  Public Sub CreateSpreadSheet()
    Dim mRowPos As Integer = 0
    Dim mNoteRange As DevExpress.Spreadsheet.Range
    Dim mSumStartRow As Integer
    Dim mColumnHeading As String
    Dim mDeliveryRowAdded As Integer

    pSpreadSheet = New DevExpress.Spreadsheet.Workbook

      pSpreadSheet.LoadDocument(pTemplateFileName)

      mRowPos += 16

      AddHeadings(pHeaderRow, False)

      mSumStartRow = mRowPos + 1



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
