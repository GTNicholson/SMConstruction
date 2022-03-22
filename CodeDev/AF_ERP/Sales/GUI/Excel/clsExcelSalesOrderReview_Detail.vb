Imports DevExpress.Charts.Model
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports RTIS.CommonVB


Public Class clsExcelSalesOrderReview_Detail

  Private pSalesOrder As dmSalesOrder
  Private pFileName As String
  Private pSpreadSheet As DevExpress.Spreadsheet.Workbook
  Private pTemplateFileName As String

  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos

  Private pWoodPalletItemInfosPicked As colWoodPalletItemInfos
  Private pMaterialsByCategories As colMaterialRequirementInfos 'colPurchaseOrderItemAllocationInfos
  Private pTimeSheetProjects As New colTimeSheetEntryInfos



  'ColumnPositions
  Private Const cColPosCount As Integer = 0
  Private Const cLastPosCount As Integer = 29
  Private Const cImageStart As Integer = 23
  Private Const cImageEnd As Integer = 29


  Public Sub New(ByRef rSalesOrder As dmSalesOrder, ByRef rSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos, ByVal vWoodPalletItemInfosPicked As colWoodPalletItemInfos, ByVal vMaterialsRequirementInfos As colMaterialRequirementInfos, ByVal vTimeSheetInfos As colTimeSheetEntryInfos)
    pSalesOrder = rSalesOrder
    pSpreadSheet = New Workbook
    pSalesOrderPhaseItemInfos = rSalesOrderPhaseItemInfos
    pWoodPalletItemInfosPicked = vWoodPalletItemInfosPicked
    pMaterialsByCategories = vMaterialsRequirementInfos
    pTimeSheetProjects = vTimeSheetInfos

  End Sub

  Public Property WorkBook As DevExpress.Spreadsheet.Workbook
    Get
      Return pSpreadSheet
    End Get
    Set(value As DevExpress.Spreadsheet.Workbook)
      pSpreadSheet = value
    End Set
  End Property

  Public Property TemplateFileName As String
    Get
      Return pTemplateFileName
    End Get
    Set(value As String)
      pTemplateFileName = value
    End Set
  End Property



  Private Sub AddLines(ByVal vRowForTitlesToStartIn As Integer, ByVal vLastRow As Integer)
    Dim mRange As DevExpress.Spreadsheet.CellRange
    Dim Rangeformatting As DevExpress.Spreadsheet.Formatting
    mRange = pSpreadSheet.Worksheets(0).Range("a" & vRowForTitlesToStartIn + 1 & ":av" & vLastRow + 1)
    Rangeformatting = mRange.BeginUpdateFormatting()
    Rangeformatting.Borders.SetAllBorders(Color.Black, DevExpress.Spreadsheet.BorderLineStyle.Thin)

  End Sub



  Public Function GetFileName() As String
    Dim mFileName As String = ""

    Return mFileName
  End Function

  Public Function CreateSummarisedExport() As System.IO.MemoryStream

    Dim mTemplateFile As String = ""
    Dim mStream As New IO.MemoryStream
    Try
      mTemplateFile = IO.Path.Combine(AppRTISGlobal.GetInstance.AuxFilePath, "Sales Project Review.xls")
      TemplateFileName = mTemplateFile

      CreateReviewSpreadSheet()
      WorkBook.SaveDocument(mStream, DevExpress.Spreadsheet.DocumentFormat.Xls)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
    Return mStream
  End Function

  Private Sub CreateReviewSpreadSheet()
    Dim mRange As CellRange
    Dim mCurrentRow As Integer


    ApplyFormat()

    mCurrentRow = 1
    CreateLogo(mCurrentRow)
    AddGeneralDetailsSalesProject(mCurrentRow)

    mCurrentRow = 6
    AddGeneralCostSalesProject(mCurrentRow)

    pSpreadSheet.Worksheets.Add().Name = "Data"

    mCurrentRow = 12

    If pWoodPalletItemInfosPicked.Count > 0 Then PopulateDataForPivotGridExcelWoodPallet(mCurrentRow)
    If pTimeSheetProjects.Count > 0 Then PopulateDataForPivotGridExcelManPower(mCurrentRow)
    If pMaterialsByCategories.Count > 0 Then PopulateDataForPivotGridExcelMaterials(mCurrentRow)

    mCurrentRow = GetLastRowUsed()

    If pWoodPalletItemInfosPicked.Count > 0 Then CreateWoodPivotChart(mCurrentRow + 1, "")
    If pTimeSheetProjects.Count > 0 Then CreateManPowerPivotChart(mCurrentRow + 1)
    If pMaterialsByCategories.Count > 0 Then CreateMaterialsPivotChart(mCurrentRow + 1)

  End Sub

  Private Sub CreateMaterialsPivotChart(ByVal vRow As Integer)
    Dim mchart As DevExpress.Spreadsheet.Charts.Chart
    Dim mIndex As Integer = 0
    Dim mDictionary As Dictionary(Of String, Decimal)
    mDictionary = New Dictionary(Of String, Decimal)
    Dim mRow As Integer = 0


    For Each mItem In pMaterialsByCategories

      If mDictionary.ContainsKey(mItem.CategoryDesc) = False Then

        mDictionary.Add(mItem.CategoryDesc, mItem.TotalCostPickingUSD)

      Else

        mDictionary(mItem.CategoryDesc) = mDictionary(mItem.CategoryDesc) + mItem.TotalCostPickingUSD

      End If


    Next

    mRow = 1
    pSpreadSheet.Worksheets("Data").Cells(0, 24).Value = "Categoría"
    pSpreadSheet.Worksheets("Data").Cells(0, 25).Value = "Valor Neto"

    For Each mItem In mDictionary
      pSpreadSheet.Worksheets("Data").Cells(mRow, 24).Value = mItem.Key
      pSpreadSheet.Worksheets("Data").Cells(mRow, 25).Value = mItem.Value


      mRow = mRow + 1
    Next

    Dim mRef As String = "Y1:" & "Z" & mRow
    mchart = pSpreadSheet.Worksheets(0).Charts.Add(ChartType.ColumnStacked, pSpreadSheet.Worksheets(1)(mRef))

    mchart.TopLeftCell = pSpreadSheet.Worksheets(0).Cells(vRow + 1, 12)
    mchart.Height = 900
    mchart.Width = 2900

  End Sub

  Private Sub PopulateDataForPivotGridExcelMaterials(ByVal vRow As Integer)
    ''6 Columns for PT Consumidos
    'from 13 to 14
    Dim mCategoria As Integer = 21
    Dim mTotalValue As Integer = 22


    Dim mRange As CellRange
    Dim mRow As Integer = 0
    pSpreadSheet.Worksheets("Data").Cells(mRow, mCategoria).Value = "Categoría"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mTotalValue).Value = "Valor Neto"


    For Each mItem In pMaterialsByCategories

      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mCategoria).Value = mItem.CategoryDesc
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mTotalValue).Value = mItem.TotalCostPickingUSD

      mRow = mRow + 1

    Next



    Dim sourceWorksheet As Worksheet = WorkBook.Worksheets("Data")
    Dim worksheet As Worksheet = pSpreadSheet.Worksheets(0)
    Dim mWoodReferenceSource As String
    Dim mWoodReferenceTarget As String = "M" & vRow + 2

    pSpreadSheet.Worksheets.ActiveWorksheet = worksheet

    ' Create a pivot table using the cell Range "A1:D41" as the data source.
    mWoodReferenceSource = "V1:W" & mRow + 1

    Dim pivotTable As PivotTable = worksheet.PivotTables.Add(sourceWorksheet(mWoodReferenceSource), worksheet(mWoodReferenceTarget))

    ' Add the "Category" field to the row axis area.
    pivotTable.RowFields.Add(pivotTable.Fields("Categoría"))
    ' Add the "Product" field to the row axis area.
    pivotTable.DataFields.Add(pivotTable.Fields("Valor Neto"))


    pivotTable.Fields("Categoría").SetSubtotal(PivotSubtotalFunctions.Sum)
    pivotTable.Fields("Valor Neto").SetSubtotal(PivotSubtotalFunctions.Sum)


    pivotTable.Layout.SetReportLayout(PivotReportLayout.Tabular)
    pivotTable.Fields("Categoría").Layout.Outline = True


    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(12, vRow, 13, vRow)
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Alignment.WrapText = True
    mRange.Font.Bold = True

    mRange.Value = "Detalle de Consumo de Materiales"
    mRange.Font.Bold = True
    mRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
    mRange.Font.Color = Color.FromArgb(166, 18, 18)
    mRange.Merge
    mRange.Font.Size = 12
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)


    mRow = GetLastRowUsed()

  End Sub

  Private Sub PopulateDataForPivotGridExcelManPower(ByVal vRow As Integer)
    ''6 Columns for PT Consumidos
    'from 7 to 12
    Dim mWODescription As Integer = 9
    Dim mDuration As Integer = 10
    Dim mOverTime As Integer = 11
    Dim mCostStd As Integer = 12
    Dim mOvertTimeCost As Integer = 13
    Dim mTotalCost As Integer = 14

    Dim mRange As CellRange
    Dim mRow As Integer = 0



    pSpreadSheet.Worksheets("Data").Cells(mRow, mWODescription).Value = "Descripción"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mDuration).Value = "Duración (hr)"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mOverTime).Value = "Tiempo Extra (hr)"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mCostStd).Value = "Costo Stand."
    pSpreadSheet.Worksheets("Data").Cells(mRow, mOvertTimeCost).Value = "Costo Hr Extra"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mTotalCost).Value = "Costo Total"


    For Each mTSE In pTimeSheetProjects

      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mWODescription).Value = mTSE.WODescriptionRef
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mDuration).Value = mTSE.Duration
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mOverTime).Value = mTSE.OverTimeHour
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mCostStd).Value = mTSE.TotalStandardValue
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mOvertTimeCost).Value = mTSE.TotalOverTimeValue
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mTotalCost).Value = mTSE.TotalStandardValueIncludingOverTimeCost

      mRow = mRow + 1

    Next



    Dim sourceWorksheet As Worksheet = WorkBook.Worksheets("Data")
    Dim worksheet As Worksheet = pSpreadSheet.Worksheets(0)
    Dim mWoodReferenceSource As String
    Dim mWoodReferenceTarget As String = "F" & vRow + 2


    pSpreadSheet.Worksheets.ActiveWorksheet = worksheet

    ' Create a pivot table using the cell Range "A1:D41" as the data source.
    mWoodReferenceSource = "J1:O" & mRow + 1

    Dim pivotTable As PivotTable = worksheet.PivotTables.Add(sourceWorksheet(mWoodReferenceSource), worksheet(mWoodReferenceTarget))

    ' Add the "Category" field to the row axis area.
    pivotTable.RowFields.Add(pivotTable.Fields("Descripción"))
    ' Add the "Product" field to the row axis area.
    pivotTable.DataFields.Add(pivotTable.Fields("Duración (hr)"))
    ' Add the "Sales" field to the data area.
    pivotTable.DataFields.Add(pivotTable.Fields("Tiempo Extra (hr)"))
    pivotTable.DataFields.Add(pivotTable.Fields("Costo Stand."))
    pivotTable.DataFields.Add(pivotTable.Fields("Costo Hr Extra"))

    pivotTable.Fields("Duración (hr)").SetSubtotal(PivotSubtotalFunctions.Sum)
    pivotTable.Fields("Tiempo Extra (hr)").SetSubtotal(PivotSubtotalFunctions.Sum)


    pivotTable.Layout.SetReportLayout(PivotReportLayout.Tabular)
    pivotTable.Fields("Descripción").Layout.Outline = True


    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(5, vRow, 9, vRow)
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Alignment.WrapText = True
    mRange.Font.Bold = True

    mRange.Value = "Detalle de Mano de Obra por OT"
    mRange.Font.Bold = True
    mRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
    mRange.Font.Color = Color.FromArgb(166, 18, 18)
    mRange.Merge
    mRange.Font.Size = 12
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)



  End Sub

  Private Sub CreateManPowerPivotChart(ByVal vRow As Integer)
    Dim mchart As DevExpress.Spreadsheet.Charts.Chart
    Dim mIndex As Integer = 0
    Dim mDictionary As Dictionary(Of String, Decimal)
    mDictionary = New Dictionary(Of String, Decimal)
    Dim mRow As Integer = 0


    For Each mItem In pTimeSheetProjects

      If mDictionary.ContainsKey(mItem.WorkOrderNo) = False Then

        mDictionary.Add(mItem.WorkOrderNo, mItem.TotalOverTimeValue)

      Else

        mDictionary(mItem.WorkOrderNo) = mDictionary(mItem.WorkOrderNo) + mItem.TotalOverTimeValue

      End If


    Next

    mRow = 1
    pSpreadSheet.Worksheets("Data").Cells(0, 16).Value = "# O.T."
    pSpreadSheet.Worksheets("Data").Cells(0, 17).Value = "Costo Std."
    pSpreadSheet.Worksheets("Data").Cells(0, 18).Value = "Costo Hora Ext"

    For Each mItem In mDictionary
      pSpreadSheet.Worksheets("Data").Cells(mRow, 16).Value = mItem.Key
      pSpreadSheet.Worksheets("Data").Cells(mRow, 18).Value = mItem.Value
      mRow = mRow + 1
    Next

    mDictionary = New Dictionary(Of String, Decimal)
    For Each mItem In pTimeSheetProjects

      If mDictionary.ContainsKey(mItem.WorkOrderNo) = False Then

        mDictionary.Add(mItem.WorkOrderNo, mItem.TotalStandardValue)

      Else

        mDictionary(mItem.WorkOrderNo) = mDictionary(mItem.WorkOrderNo) + mItem.TotalStandardValue

      End If


    Next
    mRow = 1
    For Each mItem In mDictionary
      pSpreadSheet.Worksheets("Data").Cells(mRow, 17).Value = mItem.Value
      mRow = mRow + 1
    Next



    Dim mRef As String = "Q1:" & "S" & mRow
    mchart = pSpreadSheet.Worksheets(0).Charts.Add(ChartType.ColumnFullStacked, pSpreadSheet.Worksheets(1)(mRef))

    mchart.TopLeftCell = pSpreadSheet.Worksheets(0).Cells(vRow + 1, 5)
    mchart.Height = 900
    mchart.Width = 2900

  End Sub

  Private Sub CreateWoodPivotChart(ByVal vRow As Integer, ByVal vRefSource As String)
    Dim mchart As DevExpress.Spreadsheet.Charts.Chart
    Dim mIndex As Integer = 0
    Dim mDictionary As Dictionary(Of String, Decimal)
    mDictionary = New Dictionary(Of String, Decimal)
    Dim mRow As Integer = 0


    For Each mItem In pWoodPalletItemInfosPicked

      If mDictionary.ContainsKey(mItem.SpeciesDesc) = False Then

        mDictionary.Add(mItem.SpeciesDesc, mItem.TotalCostBoardFeet)

      Else

        mDictionary(mItem.SpeciesDesc) = mDictionary(mItem.SpeciesDesc) + mItem.TotalCostBoardFeet

      End If


    Next

    mRow = 1
    pSpreadSheet.Worksheets("Data").Cells(0, 5).Value = "Especie"
    pSpreadSheet.Worksheets("Data").Cells(0, 6).Value = "Costo PT"

    For Each mItem In mDictionary
      pSpreadSheet.Worksheets("Data").Cells(mRow, 5).Value = mItem.Key
      pSpreadSheet.Worksheets("Data").Cells(mRow, 6).Value = mItem.Value


      mRow = mRow + 1
    Next

    Dim mRef As String = "F1:" & "G" & mRow
    mchart = pSpreadSheet.Worksheets(0).Charts.Add(ChartType.ColumnStacked, pSpreadSheet.Worksheets(1)(mRef))

    mchart.TopLeftCell = pSpreadSheet.Worksheets(0).Cells(vRow + 1, 0)
    mchart.Height = 900
    mchart.Width = 2000

  End Sub

  Private Function GetLastRowUsed() As Integer
    Dim mRetVal As Integer
    Dim mUsedRange As CellRange
    mUsedRange = pSpreadSheet.Worksheets(0).GetDataRange

    mRetVal = mUsedRange.BottomRowIndex
    Return mRetVal
  End Function

  Private Sub PopulateDataForPivotGridExcelWoodPallet(ByVal vRow As Integer)
    ''4 Columns for PT Consumidos
    'from 0 to 3
    Dim mWoodDescriptionColumn As Integer = 0
    Dim mWoodSpecieColumn As Integer = 1
    Dim mBoardFeetColumn As Integer = 2
    Dim mWoodTotalCost As Integer = 3
    Dim mRange As CellRange
    Dim mRow As Integer = 0
    pSpreadSheet.Worksheets("Data").Cells(mRow, mWoodDescriptionColumn).Value = "Descripción"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mWoodSpecieColumn).Value = "Especie"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mBoardFeetColumn).Value = "PT"
    pSpreadSheet.Worksheets("Data").Cells(mRow, mWoodTotalCost).Value = "Costo Total"


    For Each mWPI In pWoodPalletItemInfosPicked

      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mWoodDescriptionColumn).Value = mWPI.WODescriptionRef
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mWoodSpecieColumn).Value = mWPI.SpeciesDesc
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mBoardFeetColumn).Value = mWPI.TotalBoardFeet
      pSpreadSheet.Worksheets("Data").Cells(mRow + 1, mWoodTotalCost).Value = mWPI.TotalCostBoardFeet
      mRow = mRow + 1

    Next



    Dim sourceWorksheet As Worksheet = WorkBook.Worksheets("Data")
    Dim worksheet As Worksheet = pSpreadSheet.Worksheets(0)
    Dim mWoodReferenceSource As String
    Dim mWoodReferenceTarget As String = "A" & vRow + 2

    pSpreadSheet.Worksheets.ActiveWorksheet = worksheet

    ' Create a pivot table using the cell Range "A1:D41" as the data source.
    mWoodReferenceSource = "A1:D" & mRow + 1

    Dim pivotTable As PivotTable = worksheet.PivotTables.Add(sourceWorksheet(mWoodReferenceSource), worksheet(mWoodReferenceTarget))

    ' Add the "Category" field to the row axis area.
    pivotTable.RowFields.Add(pivotTable.Fields("Descripción"))
    ' Add the "Product" field to the row axis area.
    pivotTable.RowFields.Add(pivotTable.Fields("Especie"))
    ' Add the "Sales" field to the data area.
    pivotTable.DataFields.Add(pivotTable.Fields("PT"))
    pivotTable.DataFields.Add(pivotTable.Fields("Costo Total"))

    pivotTable.Fields("PT").SetSubtotal(PivotSubtotalFunctions.Sum)
    pivotTable.Fields("Costo Total").SetSubtotal(PivotSubtotalFunctions.Sum)


    pivotTable.Layout.SetReportLayout(PivotReportLayout.Tabular)
    pivotTable.Fields("Descripción").Layout.Outline = True


    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRow, 3, vRow)
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Alignment.WrapText = True
    mRange.Font.Bold = True

    mRange.Value = "Detalle de PT Consumido por OT"
    mRange.Font.Bold = True
    mRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
    mRange.Font.Color = Color.FromArgb(166, 18, 18)
    mRange.Merge
    mRange.Font.Size = 12
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)




  End Sub

  Private Sub AddGeneralCostSalesProject(ByVal vRow As Integer)
    Dim mRange As CellRange
    Dim mTotalValueSalesOrderLabel As Integer = 0
    Dim mTotalValueSalesOrderValue As Integer = 1
    Dim mInsumosEstimadosLabel As Integer = 4
    Dim mInsumosEstimadoValue As Integer = 5
    Dim mMaderaEstimadaLabel As Integer = 8
    Dim mMaderaEstimadaValue As Integer = 9
    Dim mTotalMaterialsLabel As Integer = 12
    Dim mTotalMaterialsValue As Integer = 13

    Dim mOutsourcingLabel As Integer = 16
    Dim mOutsourcingValue As Integer = 17

    Dim mManPowerEst As Integer = 20
    Dim mManPowerValue As Integer = 21

    Dim mCIFLabel As Integer = 24
    Dim mCIFValue As Integer = 25

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRow, cLastPosCount, vRow)
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Alignment.WrapText = True
    mRange.Font.Bold = True

    mRange.Value = "Resumen de Costos"
    mRange.Font.Bold = True
    mRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
    mRange.Font.Color = Color.FromArgb(166, 18, 18)
    mRange.Merge
    mRange.Font.Size = 12
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRow + 1, cLastPosCount, vRow + 5)
    mRange.Fill.BackgroundColor = Color.White

    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mTotalValueSalesOrderLabel).Value = "Valor Total Venta"
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mTotalValueSalesOrderLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mTotalValueSalesOrderLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mTotalValueSalesOrderValue, vRow + 1, mTotalValueSalesOrderValue + 1, vRow + 1)

    mRange.Value = pSalesOrder.GetTotalValueWithCarriage
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge

    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mTotalValueSalesOrderLabel).Value = "Costo Total"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mTotalValueSalesOrderLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mTotalValueSalesOrderLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mTotalValueSalesOrderValue, vRow + 2, mTotalValueSalesOrderValue + 1, vRow + 2)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pSalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pSalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue + pSalesOrder.CIFValue + pSalesOrderPhaseItemInfos.GetTotalActualManPowerValue
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mInsumosEstimadosLabel).Value = "Insumos Est."
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mInsumosEstimadosLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mInsumosEstimadosLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mInsumosEstimadoValue, vRow + 1, mInsumosEstimadoValue + 1, vRow + 1)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalStockItemEstimatedValue
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mInsumosEstimadosLabel).Value = "Insumos Actuales"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mInsumosEstimadosLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mInsumosEstimadosLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mInsumosEstimadoValue, vRow + 2, mInsumosEstimadoValue + 1, vRow + 2)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mMaderaEstimadaLabel).Value = "Madera Est."
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mMaderaEstimadaLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mMaderaEstimadaLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mMaderaEstimadaValue, vRow + 1, mMaderaEstimadaValue + 1, vRow + 1)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalWoodStockItemEstimatedValue
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mMaderaEstimadaLabel).Value = "Madera Actual"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mMaderaEstimadaLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mMaderaEstimadaLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mMaderaEstimadaValue, vRow + 2, mMaderaEstimadaValue + 1, vRow + 2)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mTotalMaterialsLabel).Value = "Total Materiales Est."
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mTotalMaterialsLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mTotalMaterialsLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mTotalMaterialsValue, vRow + 1, mTotalMaterialsValue + 1, vRow + 1)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalStimatedValue
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mTotalMaterialsLabel).Value = "Total Materiales Actual"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mTotalMaterialsLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mTotalMaterialsLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mTotalMaterialsValue, vRow + 2, mTotalMaterialsValue + 1, vRow + 2)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalMaterialPickReal
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge



    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mOutsourcingLabel).Value = "Subcont Est."
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mOutsourcingLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mOutsourcingLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mOutsourcingValue, vRow + 1, mOutsourcingValue + 1, vRow + 1)

    mRange.Value = pSalesOrder.SalesOrderItems.GetTotalOutsourcingBudget
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mOutsourcingLabel).Value = "Subcont Actual"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mOutsourcingLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mOutsourcingLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mOutsourcingValue, vRow + 2, mOutsourcingValue + 1, vRow + 2)

    mRange.Value = pSalesOrderPhaseItemInfos.GetTotalSubconValue
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge



    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mManPowerEst).Value = "M.O. Est."
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mManPowerEst).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mManPowerEst).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mManPowerValue, vRow + 1, mManPowerValue + 1, vRow + 1)

    mRange.Value = pSalesOrder.SalesOrderItems.GetTotalMOBudget
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mManPowerEst).Value = "M.O. Actual"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mManPowerEst).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mManPowerEst).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mManPowerValue, vRow + 2, mManPowerValue + 1, vRow + 2)

    mRange.Value = pSalesOrderPhaseItemInfos.GetActualMOSOPI
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge

    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mCIFLabel).Value = "CIF"
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mCIFLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mCIFLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mCIFValue, vRow + 1, mCIFValue + 1, vRow + 1)

    mRange.Value = pSalesOrder.CIFValue
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge

    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mCIFLabel).Value = "Utilidad"
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mCIFLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 2, mCIFLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mCIFValue, vRow + 2, mCIFValue + 1, vRow + 2)


    mRange.Value = pSalesOrder.GetTotalValueWithCarriage - (pSalesOrderPhaseItemInfos.GetTotalStockItemMatReqPickReal + pSalesOrderPhaseItemInfos.GetTotalWoodMatReqPicked + pSalesOrderPhaseItemInfos.GetTotalOutsourcingRealValue + pSalesOrder.CIFValue + +pSalesOrderPhaseItemInfos.GetTotalActualManPowerValue)
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge




    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRow, cImageEnd, vRow + 4)
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)
    mRange.Borders.InsideHorizontalBorders.Color = Color.White
    mRange.Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.None
    mRange.Borders.InsideVerticalBorders.Color = Color.White
    mRange.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.None


  End Sub

  Private Sub AddGeneralDetailsSalesProject(ByVal vRow As Integer)
    Dim mRange As CellRange
    Dim mOrderNumberLabel As Integer = 0
    Dim mOrderNumberValue As Integer = 2
    Dim mProyectoLabel As Integer = 8
    Dim mProyectoValue As Integer = 10
    Dim mDateColumn As Integer = 16
    Dim mDateColumnValue As Integer = 18
    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, 0, cLastPosCount, 0)
    mRange.Fill.BackgroundColor = Color.LightGray
    mRange.Alignment.WrapText = True
    mRange.Font.Bold = True

    mRange.Value = "Detalle General de la Venta"
    mRange.Font.Bold = True
    mRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
    mRange.Font.Color = Color.FromArgb(166, 18, 18)
    mRange.Merge
    mRange.Font.Size = 12
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, 1, cLastPosCount, 3)
    mRange.Fill.BackgroundColor = Color.White

    pSpreadSheet.Worksheets(0).Cells(vRow, mOrderNumberLabel).Value = "#Venta"
    pSpreadSheet.Worksheets(0).Cells(vRow, mOrderNumberLabel).Font.Bold = True

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mOrderNumberValue, vRow, mOrderNumberValue + 3, vRow)

    mRange.Value = pSalesOrder.OrderNo
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge

    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mOrderNumberLabel).Value = "Encargado del Proyecto"
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mOrderNumberLabel).Font.Bold = True
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mOrderNumberLabel).ColumnWidthInCharacters = 28

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mOrderNumberValue, vRow + 1, mOrderNumberValue + 3, vRow + 1)

    mRange.Value = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Employees).ItemValueToDisplayValue(pSalesOrder.ContractManagerID)

    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge



    pSpreadSheet.Worksheets(0).Cells(vRow, mProyectoLabel).Value = "Proyecto"
    pSpreadSheet.Worksheets(0).Cells(vRow, mProyectoLabel).Font.Bold = True

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mProyectoValue, vRow, mProyectoValue + 3, vRow)

    mRange.Value = pSalesOrder.ProjectName
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge


    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mProyectoLabel).Value = "Cliente"
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mProyectoLabel).Font.Bold = True

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mProyectoValue, vRow + 1, mProyectoValue + 3, vRow + 1)

    If pSalesOrder.Customer IsNot Nothing Then
      mRange.Value = pSalesOrder.Customer.CompanyName

    Else

    End If
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge



    pSpreadSheet.Worksheets(0).Cells(vRow, mDateColumn).Value = "Fecha Ingreso"
    pSpreadSheet.Worksheets(0).Cells(vRow, mDateColumn).Font.Bold = True

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mDateColumnValue, vRow, mDateColumnValue + 3, vRow)

    mRange.Value = pSalesOrder.DateEntered
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge

    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mDateColumn).Value = "Fecha Requerida"
    pSpreadSheet.Worksheets(0).Cells(vRow + 1, mDateColumn).Font.Bold = True

    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(mDateColumnValue, vRow + 1, mDateColumnValue + 3, vRow + 1)

    mRange.Value = pSalesOrder.SalesOrderPhases(0).DateRequired
    mRange.Font.Bold = True
    mRange.Fill.BackgroundColor = Color.WhiteSmoke
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin)
    mRange.Merge




    mRange = pSpreadSheet.Worksheets(0).Range.FromLTRB(0, vRow, cImageEnd, vRow + 3)
    mRange.Borders.SetAllBorders(Color.Black, BorderLineStyle.Medium)
    mRange.Borders.InsideHorizontalBorders.Color = Color.White
    mRange.Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.None
    mRange.Borders.InsideVerticalBorders.Color = Color.White
    mRange.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.None

  End Sub

  Private Sub ApplyFormat()
    pSpreadSheet.Worksheets(0).ActiveView.ShowGridlines = False


  End Sub

  Private Sub CreateLogo(ByVal vRowStart As Integer)
    Dim pic As Picture = pSpreadSheet.Worksheets(0).Pictures.AddPicture(My.Resources.Logo2AF, pSpreadSheet.Worksheets(0).Range.FromLTRB(cImageStart, vRowStart, cImageEnd, vRowStart + 2), False)
    pic.BorderWidth = 1
    pic.BorderColor = Color.White
    pic.LockAspectRatio = True






  End Sub
End Class

