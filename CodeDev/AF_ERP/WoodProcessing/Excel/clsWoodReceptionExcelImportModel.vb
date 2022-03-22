
Imports AgroForestal.clsExcelImportModel
Imports DevExpress.Spreadsheet
Imports RTIS.CommonVB
Imports RTIS.Elements
Public Class clsWoodReceptionExcelImportModel : Inherits clsSpreadSheetModelBase
  Protected pHeaderRow As Integer
  Protected pController As fccWoodReception
  Protected pStockItems As colStockItems

  Private pRTISGlobal As AppRTISGlobal
  Private pConversionDT As Data.DataTable


  Public Sub New(ByRef rController As fccWoodReception)
    MyBase.New
    Me.pController = rController
    Me.pHeaderRow = 0
    pRTISGlobal = AppRTISGlobal.GetInstance

    Try
      LoadColumns()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Enum eColumnID
    RastraNumber = 1
    Specie = 2
    Troza = 3
    Diameter = 4
    Length = 5

  End Enum

  Public Sub LoadColumns()
    Dim mMappings As New colExcelMappings

    pSpreadSheetModelColumns = New colSpreadSheetModelColumns

    pSpreadSheetModelColumns.Add(New clsSpreadSheetColumnString(Me, eColumnID.RastraNumber, "# RASTRA"))
    pSpreadSheetModelColumns.Add(New clsSpreadSheetColumnSpecies(Me, eColumnID.Specie, "ESPECIE"))
    pSpreadSheetModelColumns.Add(New clsSpreadSheetColumnString(Me, eColumnID.Troza, "TROZA"))
    pSpreadSheetModelColumns.Add(New clsSpreadSheetColumnNumerical(Me, eColumnID.Diameter, "Diametro promedio", False))
    pSpreadSheetModelColumns.Add(New clsSpreadSheetColumnNumerical(Me, eColumnID.Length, "Longitud  (m)", False))


  End Sub

  Public Overrides ReadOnly Property ModelName As String
    Get
      Return "Importación de Rastra"
    End Get
  End Property

  Public Sub ImportItems()
    Dim mColWoodPallets As New colWoodPallets
    Try


      For Each mRow As clsSpreadSheetModelRowBase In pSpreadSheetModelRows
        Dim mRastraNumber As String = String.Empty
        Dim mSpecies As String = String.Empty
        Dim mDiameter As Decimal = 0
        Dim mLength As Decimal = 0
        Dim mTrozaRef As String = ""

        For Each mCol As clsSpreadSheetModelColumnBase In pSpreadSheetModelColumns
          If mCol.SpreadSheetColumnNo > -1 Then ' And mCol.IsValid Then
            Dim mColVal As String = mRow.GetValue(mCol.ColumnID)

            Select Case mCol.ColumnID
              Case eColumnID.RastraNumber
                mRastraNumber = mColVal
              Case eColumnID.Specie
                mSpecies = mColVal
              Case eColumnID.Troza
                mTrozaRef = mColVal
              Case eColumnID.Diameter
                Decimal.TryParse(mColVal, mDiameter)

              Case eColumnID.Length
                Decimal.TryParse(mColVal, mLength)

            End Select

          End If
        Next


        If mRastraNumber <> "" Then
          Dim mWoodPallet As dmWoodPallet



          mWoodPallet = mColWoodPallets.ItemFromCardNumber(mRastraNumber)

          If mWoodPallet Is Nothing Then '//Create the pallet and the palletitems
            mWoodPallet = New dmWoodPallet
            mWoodPallet.CardNumber = mRastraNumber
            mWoodPallet.PalletType = eStockItemTypeTimberWood.Rollo
            mWoodPallet.Farm = pController.CurrentReception.Farm
            mWoodPallet.CreatedDate = Now
            mWoodPallet.LocationID = eLocations.AgroForestal
            mWoodPallet.ReceptionID = pController.CurrentReception.ReceptionID
            mWoodPallet.Archive = 0

            clsWoodPalletSharedFuncs.GetNextWoodPalletRef(mWoodPallet, pController.DBConn)


            Dim mWoodPalletItem As New dmWoodPalletItem
            mWoodPalletItem.Length = Math.Round(mLength, 5, MidpointRounding.AwayFromZero)
            mWoodPalletItem.Quantity = 1
            mWoodPalletItem.OutstandingQty = 1

            mWoodPalletItem.Thickness = mDiameter
            mWoodPalletItem.TrozaRef = mTrozaRef
            SetStockItemIDIntoWoodPalletItem(mSpecies, mDiameter, mWoodPalletItem)
            mWoodPallet.WoodPalletItems.Add(mWoodPalletItem)
            mColWoodPallets.Add(mWoodPallet)

          Else ''//Add the wood pallet item to the right woodpallet
            Dim mWoodPalletItem As dmWoodPalletItem
            mWoodPalletItem = New dmWoodPalletItem
            mWoodPalletItem.Length = Math.Round(mLength, 5, MidpointRounding.AwayFromZero)
            mWoodPalletItem.Quantity = 1
            mWoodPalletItem.OutstandingQty = 1

            mWoodPalletItem.Thickness = mDiameter
            mWoodPalletItem.TrozaRef = mTrozaRef

            SetStockItemIDIntoWoodPalletItem(mSpecies, mDiameter, mWoodPalletItem)
            mWoodPallet.WoodPalletItems.Add(mWoodPalletItem)
          End If





        End If




      Next
      For Each mWoodPallet In mColWoodPallets
        pController.SaveWoodPalletDown(mWoodPallet)
        pController.CurrentReception.WoodPallets.Add(mWoodPallet)
      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Private Sub SetStockItemIDIntoWoodPalletItem(ByVal vSpecies As String, ByVal vThickness As Decimal, ByRef rWoodPalletItem As dmWoodPalletItem)
    Dim mStockItem As dmStockItem
    Dim mSpeciesID As Integer
    Dim mThicknessInInch As Decimal
    Dim mDigit As Decimal = 0.5
    Try

      mThicknessInInch = (vThickness / clsConstants.CMToInches)
      mThicknessInInch = Math.Round(mThicknessInInch / mDigit, 0, MidpointRounding.AwayFromZero) * mDigit

      For Each mWoodSpecie In CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies)


        If mWoodSpecie.EnglishDescription.Trim.ToUpper = vSpecies.Trim.ToUpper Then
          mSpeciesID = mWoodSpecie.WoodSpecieID
          Exit For
        End If

      Next

      If mSpeciesID > 0 Then
        mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemCollection.ItemFromSpeciesAndThickness(mSpeciesID, mThicknessInInch, eStockItemTypeTimberWood.Rollo)

        If mStockItem Is Nothing Then
          mStockItem = New dmStockItem
          mStockItem.ItemType = eStockItemTypeTimberWood.Rollo
          mStockItem.Species = mSpeciesID
          mStockItem.Thickness = mThicknessInInch
          mStockItem.Category = eStockItemCategory.Timber
          mStockItem.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mStockItem, pController.DBConn)
          mStockItem.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mStockItem)

          AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mStockItem)
          rWoodPalletItem.StockItemID = mStockItem.StockItemID
          rWoodPalletItem.StockCode = mStockItem.StockCode
          rWoodPalletItem.Description = mStockItem.Description
        Else
          rWoodPalletItem.StockItemID = mStockItem.StockItemID
          rWoodPalletItem.StockCode = mStockItem.StockCode
          rWoodPalletItem.Description = mStockItem.Description


        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

  End Sub

  Public Overrides Sub IdentifyColumns()
    Dim mPrevCol As Integer
    For Each mCol As clsSpreadSheetModelColumnBase In pSpreadSheetModelColumns
      mPrevCol = mCol.SpreadSheetColumnNo
      mCol.SpreadSheetColumnNo = -1
      mCol.IdentifyColumn()
      If mCol.SpreadSheetColumnNo = -1 Then mCol.SpreadSheetColumnNo = mPrevCol
      If mPrevCol = -1 And mCol.SpreadSheetColumnNo > -1 Then mCol.Required = True
    Next
  End Sub

  Public Overrides Sub IdentifyRows()
    Dim mDoorRef As String

    Dim mRowPos As Integer
    If pSpreadSheetModelRows IsNot Nothing Then
      For Each mRow As clsSpreadSheetModelRowBase In pSpreadSheetModelRows

        For Each mCol As clsSpreadSheetModelColumnBase In pSpreadSheetModelColumns
          If Not MissingColumns.Contains(mCol) And mCol.SpreadSheetColumnNo > -1 Then
            Select Case WorkSheet.Cells(mRow.CurrentWorkSheetRow, SpreadSheetModelColumn(mCol.ColumnID).SpreadSheetColumnNo).FillColor
              Case Color.LightGreen, Color.LightSalmon, Color.Yellow
                WorkSheet.Cells(mRow.CurrentWorkSheetRow, SpreadSheetModelColumn(mCol.ColumnID).SpreadSheetColumnNo).FillColor = Color.White
            End Select
          End If
        Next

      Next
    End If
    pSpreadSheetModelRows = New colSpreadSheetModelRows
    For mRowPos = pStartRow To pEndRow
      mDoorRef = SpreadSheetModelColumn(eColumnID.RastraNumber).GetCellText(mRowPos)

      If Not String.IsNullOrEmpty(mDoorRef) AndAlso mDoorRef <> SpreadSheetModelColumn(eColumnID.RastraNumber).GetCellText(pHeaderRow) Then
        pSpreadSheetModelRows.Add(New clsQuoteSpreadSheetRow(Me) With {.CurrentWorkSheetRow = mRowPos})
      End If

    Next
  End Sub

  Public Overrides Sub Process(ByRef rrWorkSheet As DevExpress.Spreadsheet.Worksheet)
    Me.ImportItems()

  End Sub

  Public Overrides Sub ValidateSpreadSheet(ByRef rWorkSheet As DevExpress.Spreadsheet.Worksheet)
    Dim mSheetValid As Boolean = True

    Me.WorkSheet = rWorkSheet
    LoadInfo()

    For Each mRow As clsSpreadSheetModelRowBase In pSpreadSheetModelRows
      mRow.IsValid = True
      If mRow.CurrentWorkSheetRow <> pHeaderRow Then

        For Each mCol As clsSpreadSheetModelColumnBase In pSpreadSheetModelColumns
          If Not MissingColumns.Contains(mCol) And mCol.SpreadSheetColumnNo > -1 Then

            Dim mColVal As String = mRow.GetValue(mCol.ColumnID)
            mCol.ValidateCells(mColVal)

            If mCol.IsValid Then
              rWorkSheet.Cells(mRow.CurrentWorkSheetRow, SpreadSheetModelColumn(mCol.ColumnID).SpreadSheetColumnNo).FillColor = Color.LightGreen
            ElseIf SpreadSheetModelColumn(mCol.ColumnID).SpreadSheetColumnNo <> 0 Then
              rWorkSheet.Cells(mRow.CurrentWorkSheetRow, SpreadSheetModelColumn(mCol.ColumnID).SpreadSheetColumnNo).FillColor = Color.LightSalmon
              mRow.IsValid = False
              mSheetValid = False
            End If
          End If
        Next

      End If

    Next

    If Not mSheetValid Then
      MsgBox("Items On the sheet aren't valid")
    End If


  End Sub

  Protected Sub LoadInfo()
    Me.SetRange(pHeaderRow, 0)
    Me.IdentifyColumns()
    Me.IdentifyRows()
    Me.RetrieveValues()
  End Sub

End Class
