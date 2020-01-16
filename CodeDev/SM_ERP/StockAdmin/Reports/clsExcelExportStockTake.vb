Public Class clsExcelExportStockTake
  Private pSpreadSheet As DevExpress.Spreadsheet.Workbook
  Private pStockTake As dmStockTake
  Private pStockTakeItemEditors As colStockTakeItemEditors

  Private pCurrentSheet As DevExpress.Spreadsheet.Worksheet

  Private Const cColumnRowPos As Integer = 4

  Private Const cColPosStockCode As Integer = 2

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

  Public Sub CreateSpreadSheet()
    pSpreadSheet = New DevExpress.Spreadsheet.Workbook
    pCurrentSheet = pSpreadSheet.Worksheets(0)
    AddHeader()
    AddColumnHeaders()
    AddItems()
  End Sub

  Private Sub AddHeader()
    pCurrentSheet.Cells(1, 1).SetValue(pStockTake.Description)
  End Sub

  Private Sub AddColumnHeaders()
    pCurrentSheet.Cells(cColumnRowPos, cColPosStockCode).SetValue("Stock Code")

  End Sub

  Private Sub AddItems()
    Dim mRow As Integer

    mRow = cColumnRowPos + 1

    For Each mItem As clsStockTakeItemEditor In pStockTakeItemEditors
      pCurrentSheet.Cells(mRow, cColPosStockCode).SetValue(mItem.StockItem.Description)
      mRow = mRow + 1
    Next
  End Sub

End Class
