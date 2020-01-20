﻿Imports DevExpress.Spreadsheet
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

  Private Sub AddHeadings(ByVal vRowForTitlesToStartIn As Integer)
    Dim mRange As DevExpress.Spreadsheet.Range
    Dim mCurColPos As Integer
    Dim mIMHead As String


    'Title in


    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(1, 1, pColumnCount, 1)
    mRange.Merge
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Fill.BackgroundColor = Color.Lavender
    mRange.Value = "Reporte de Toma de Inventario"
    mRange.Font.Size = 20
    mRange.Font.Bold = True
    mRange.Font.Color = Color.DimGray
    mRange.Font.Name = "Arial"

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(10, 1, 15, 1)
    mRange.Merge
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Fill.BackgroundColor = Color.Lavender
    mRange.Value = "Fecha " + pStockTake.StockTakeDate
    mRange.Font.Size = 20
    mRange.Font.Bold = True
    mRange.Font.Color = Color.DimGray
    mRange.Font.Name = "Arial"


    'HEADINGS in

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRowForTitlesToStartIn, pColumnCount, vRowForTitlesToStartIn)
    mRange.Fill.BackgroundColor = Color.Lavender
    mRange.Borders.BottomBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Thin
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Alignment.WrapText = True
    mRange.Font.Size = 12
    mRange.ColumnWidthInCharacters = 12
    mRange.Font.Bold = True

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


    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRowForTitlesToStartIn, pColumnCount, vRowForTitlesToStartIn)
    mRange.AutoFitColumns

  End Sub

  Public Sub CreateSpreadSheet()
    pSpreadSheet = New DevExpress.Spreadsheet.Workbook
    pCurrentSheet = pSpreadSheet.Worksheets(0)
    AddHeader()
    AddHeadings(cColumnRowPos)
    AddItems()
  End Sub

  Private Sub AddHeader()
    ''pCurrentSheet.Cells(1, 1).SetValue(pStockTake.Description)
    ''pCurrentSheet.Cells(1, 1).SetValue("Hola")

  End Sub


  Private Sub AddItems()
    Dim mRow As Integer
    Dim mRange As DevExpress.Spreadsheet.Range

    mRow = cColumnRowPos + 1

    For Each mItem As clsStockTakeItemEditor In pStockTakeItemEditors

      mRange = pCurrentSheet.Range.FromLTRB(0, mRow, pColumnCount, mRow + 1)

      mRange.Fill.BackgroundColor = Color.White
      mRange.Borders.BottomBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Thin
      mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
      mRange.AutoFitColumns
      mRange.AutoFitRows

      pCurrentSheet.Cells(mRow, cColPosStockCode).SetValue(mItem.StockItem.StockCode)
      pCurrentSheet.Cells(mRow, cColDescription).SetValue(mItem.StockItem.Description)
      pCurrentSheet.Cells(mRow, cColCategory).SetValue(mItem.StockItem.Category)

      pCurrentSheet.Cells(mRow, cColCategory).SetValue(mItem.StockItem.ItemType)
      pCurrentSheet.Cells(mRow, cColCategory).SetValue(mItem.StockItem.PartNo)
      pCurrentSheet.Cells(mRow, cColCategory).SetValue(mItem.CountedQty)


      mRow = mRow + 1
    Next
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