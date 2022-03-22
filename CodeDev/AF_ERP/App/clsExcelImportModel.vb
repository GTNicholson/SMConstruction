Imports RTIS.CommonVB
Imports RTIS.Elements


Public Class clsExcelImportModel : Inherits clsSpreadSheetModelBase

  Protected pHeaderRow As Integer
  Protected pStockItems As colStockItems
  Private pRTISGlobal As AppRTISGlobal
  Private pConversionDT As Data.DataTable

  Public Sub New()
    MyBase.New
    Me.pHeaderRow = 4
    pRTISGlobal = AppRTISGlobal.GetInstance

    Try
      LoadColumns()
      LoadConversions()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Overrides ReadOnly Property ModelName As String
    Get
    End Get
  End Property

  Public Sub LoadConversions()

  End Sub


  Public Sub LoadColumns()
    Dim mMappings As New colExcelMappings

    pSpreadSheetModelColumns = New colSpreadSheetModelColumns

  End Sub

  Public Overrides Sub IdentifyRows()
  End Sub

  Public Overrides Sub IdentifyColumns()
  End Sub

  Public Overrides Sub ValidateSpreadSheet(ByRef rWorkSheet As DevExpress.Spreadsheet.Worksheet)
  End Sub

  Public Overrides Sub Process(ByRef rrWorkSheet As DevExpress.Spreadsheet.Worksheet)
  End Sub

  Public Class clsSpreadSheetColumnOrdinal : Inherits clsSpreadSheetModelColumnBase
    Private pColumnID As Integer


    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vSpreadSheetColumnNo As Integer)
      MyBase.New(rSpreadSheetModel)
      pColumnID = vColumnID

      pSpreadSheetColumnNo = vSpreadSheetColumnNo
    End Sub

    Public Overrides Sub IdentifyColumn()
      pSpreadSheetModel.ColumnLocateByColumnPos(Me, pSpreadSheetColumnNo)
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      If String.IsNullOrEmpty(vCellValue) Then
        pIsValid = False
      Else
        pIsValid = True
      End If
    End Sub

    Public Overrides ReadOnly Property ColumnID As Integer
      Get
        Return pColumnID
      End Get
    End Property


  End Class

  Public Class clsSpreadSheetColumnColumnName : Inherits clsSpreadSheetModelColumnBase
    Private pColumnID As Integer
    Private pHeaderText As String

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String)
      MyBase.New(rSpreadSheetModel)
      pColumnID = vColumnID
      pHeaderText = vHeaderText
      Me.SpreadSheetColumnNo = -1
    End Sub

    Public Overrides Sub IdentifyColumn()
      pSpreadSheetModel.ColumnLocateByFirstRowCellText(Me, pHeaderText)
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      If String.IsNullOrEmpty(vCellValue) Then
        pIsValid = False
      Else
        pIsValid = True
      End If
    End Sub

    Public Overrides ReadOnly Property ColumnID As Integer
      Get
        Return pColumnID
      End Get
    End Property

    Public ReadOnly Property HeaderText As String
      Get
        Return pHeaderText
      End Get
    End Property

  End Class

  Public Class clsSpreadSheetColumnValueItems : Inherits clsSpreadSheetColumnColumnName
    Private pValueItems As colValueItems
    Private pAllowBlank As Boolean

    Private pMappings As colExcelMappings
    Private pItemValue As Integer
    Private pRefListID As Integer

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByRef rValueItems As colValueItems, ByVal vExcelMappings As colExcelMappings, ByVal vAllowBlank As Boolean, ByVal vRefListID As Int32)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pValueItems = rValueItems
      pAllowBlank = vAllowBlank
      pMappings = vExcelMappings
      pRefListID = vRefListID
    End Sub

    Public ReadOnly Property ValueItems As colValueItems
      Get
        Return pValueItems
      End Get
    End Property

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      Evaluate(vCellValue)
    End Sub

    Public Function DisplayValueToItemValue(ByVal vCellValue As String) As Integer
      Evaluate(vCellValue)
      Return pItemValue
    End Function


    Private Sub Evaluate(ByVal vCellValue As String)
      Dim mID As Integer = -1


      If IsNumeric(vCellValue) Then
        Dim mIndex As Integer = pValueItems.ItemValueIndex(vCellValue)

        If mIndex = -1 Then
          pIsValid = False
        Else
          mID = Val(vCellValue)
          pIsValid = True
        End If

      Else
        Dim mIndex As Integer = pValueItems.DisplayValueIndexCaseInsensitive(vCellValue)

        If mIndex = -1 Then
          If pAllowBlank AndAlso vCellValue = "" Then
            mID = 0
            pIsValid = True
          Else
            Dim mTranslation As String = pMappings.Translate(pRefListID, vCellValue)

            mIndex = pValueItems.DisplayValueIndexCaseInsensitive(mTranslation)

            If mIndex = -1 Then
              pIsValid = False
            Else
              mID = pValueItems(mIndex).ItemValue
              pIsValid = True
            End If

          End If
        Else
          Dim mValueItem As iValueItem = pValueItems(mIndex)

          mID = mValueItem.ItemValue
          pIsValid = True
        End If
      End If



      pItemValue = mID
    End Sub

  End Class

  Public Class clsSpreadSheetColumnValueItemsOrNumbericRef : Inherits clsSpreadSheetColumnColumnName
    Private pValueItems As IList
    Private pAllowBlank As Boolean

    Private pMappings As colExcelMappings
    Private pItemValue As Integer
    Private pRefListID As Integer

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByRef rValueItems As IList, ByVal vExcelMappings As colExcelMappings, ByVal vAllowBlank As Boolean, ByVal vRefListID As Int32)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pValueItems = rValueItems
      pAllowBlank = vAllowBlank
      pMappings = vExcelMappings
      pRefListID = vRefListID
    End Sub

    Public ReadOnly Property ValueItems As colValueItems
      Get
        Return pValueItems
      End Get
    End Property

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      Evaluate(vCellValue)
    End Sub

    Public Function DisplayValueToItemValue(ByVal vCellValue As String) As Integer
      Evaluate(vCellValue)
      Return pItemValue
    End Function


    Private Sub Evaluate(ByVal vCellValue As String)
      Dim mID As Integer = -1


      If IsNumeric(vCellValue) Then

        If Val(vCellValue) > 0 Then
          mID = ItemValueFromExcelRef(vCellValue)

          If mID > 0 Then
            pIsValid = True
          Else
            pIsValid = False
          End If
        Else
          pIsValid = False
        End If

      Else
        Dim mIndex As Integer = DisplayValueIndexCaseInsensitive(vCellValue)

        If mIndex = -1 Then
          If pAllowBlank AndAlso vCellValue = "" Then
            mID = 0
            pIsValid = True
          Else
            Dim mTranslation As String = pMappings.Translate(pRefListID, vCellValue)

            mIndex = DisplayValueIndexCaseInsensitive(mTranslation)

            If mIndex = -1 Then
              pIsValid = False
            Else
              mID = pValueItems(mIndex).ItemValue
              pIsValid = True
            End If

          End If
        Else
          Dim mValueItem As iValueItem = pValueItems(mIndex)

          mID = mValueItem.ItemValue
          pIsValid = True
        End If
      End If

      pItemValue = mID
    End Sub

    Private Function ItemValueFromExcelRef(ByVal vCellValue As String) As Integer
      Dim mRetVal As Integer = -1

      For Each mItem As iValueItem In pValueItems

        If TypeOf mItem Is iExcelNumbericRef Then

          If CType(mItem, iExcelNumbericRef).ExcelRef = Val(vCellValue) Then
            mRetVal = mItem.ItemValue

            Exit For
          End If

        End If

      Next

      Return mRetVal
    End Function

    Private Function DisplayValueIndexCaseInsensitive(ByVal vCellValue As String) As Integer
      Dim mValueItem As iValueItem
      Dim mRetVal As Integer = -1
      Dim mCount As Integer = -1

      If Not String.IsNullOrEmpty(vCellValue) Then
        For Each mValueItem In pValueItems
          mCount += 1
          If mValueItem.DisplayValue.Trim.ToUpper = vCellValue.Trim.ToUpper Then
            mRetVal = mCount
            Exit For
          End If
        Next
      End If

      Return mRetVal
    End Function

  End Class

  Public Class clsSpreadSheetColumnStartingWithValueItems : Inherits clsSpreadSheetColumnColumnName
    Private pValueItems As colValueItems
    Private pAllowBlank As Boolean
    Private pMappings As colExcelMappings
    Private pItemValue As Integer
    Private pRefListID As Integer

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByRef rValueItems As colValueItems, ByVal vMappings As colExcelMappings, ByVal vAllowBlank As Boolean, ByVal vRefListID As Int32)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pValueItems = rValueItems
      pAllowBlank = vAllowBlank
      pMappings = vMappings
      pRefListID = vRefListID
    End Sub

    Public ReadOnly Property ValueItems As colValueItems
      Get
        Return pValueItems
      End Get
    End Property

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      Evaluate(vCellValue)
    End Sub

    Public Function DisplayValueToItemValue(ByVal vCellValue As String) As Integer
      Evaluate(vCellValue)
      Return pItemValue
    End Function

    Private Sub Evaluate(ByVal vCellValue As String)
      Dim mID As Integer = -1

      Dim mIndex As Integer = pValueItems.StartsWithDisplayValueIndexCaseInsensitive(vCellValue)

      If mIndex = -1 Then
        If pAllowBlank AndAlso vCellValue = "" Then
          mID = 0
          pIsValid = True
        Else
          Dim mTranslation As String = pMappings.Translate(pRefListID, vCellValue)

          mIndex = pValueItems.StartsWithDisplayValueIndexCaseInsensitive(mTranslation)

          If mIndex = -1 Then
            pIsValid = False
          Else
            mID = pValueItems(mIndex).ItemValue
            pIsValid = True
          End If

        End If
      Else
        Dim mValueItem As iValueItem = pValueItems(mIndex)

        mID = mValueItem.ItemValue
        pIsValid = True
      End If

      pItemValue = mID
    End Sub

  End Class

  Public Class clsSpreadSheetColumnString : Inherits clsSpreadSheetColumnColumnName

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)

      pIsValid = vCellValue.Length > 0

    End Sub

  End Class

  Public Class clsSpreadSheetColumnStringPair : Inherits clsSpreadSheetColumnColumnName
    Private pAllowBlank As Boolean

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByRef rAllowBlank As Boolean)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pAllowBlank = rAllowBlank
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      If String.IsNullOrWhiteSpace(vCellValue) And pAllowBlank Then
        pIsValid = True
      ElseIf vCellValue = "-" Then
        pIsValid = True
      Else
        pIsValid = vCellValue.Length > 0
      End If
    End Sub

    Public Function GetStringPart(ByVal vCellValue As String, vPart As Integer) As String
      Dim mPart As String = ""


      If vCellValue = "-" Then
        mPart = ""
      ElseIf vCellValue.Contains(";") Then
        Dim mPos As Integer
        mPos = vCellValue.IndexOf(";")
        If vPart = 1 Then
          mPart = vCellValue.Substring(0, mPos).Trim
          If mPart = "-" Then mPart = ""
        Else
          mPart = vCellValue.Substring(mPos + 1).Trim
          If mPart = "-" Then mPart = ""
        End If
      Else
        mPart = vCellValue
      End If

      Return mPart
    End Function

  End Class

  Public Class clsSpreadSheetColumnColourPair : Inherits clsSpreadSheetColumnColumnName
    Private pAllowBlank As Boolean

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByRef rAllowBlank As Boolean)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pAllowBlank = rAllowBlank
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      If String.IsNullOrWhiteSpace(vCellValue) And pAllowBlank Then
        pIsValid = True
      ElseIf vCellValue = "-" Then
        pIsValid = True
      Else
        pIsValid = vCellValue.Length > 0
      End If
    End Sub

    Public Function GetColourPart(ByVal vCellValue As String, vPart As Integer) As String
      Dim mPart As String = ""


      If vCellValue = "-" Then
        mPart = ""
      ElseIf vCellValue.Contains("/") Then
        Dim mPos As Integer
        mPos = vCellValue.IndexOf("/")
        If vPart = 1 Then
          mPart = vCellValue.Substring(0, mPos).Trim
          If mPart = "-" Then mPart = ""
        Else
          mPart = vCellValue.Substring(mPos + 1).Trim
          If mPart = "-" Then mPart = ""
        End If
      ElseIf vCellValue.Contains(";") Then
        Dim mPos As Integer
        mPos = vCellValue.IndexOf(";")
        If vPart = 1 Then
          mPart = vCellValue.Substring(0, mPos).Trim
          If mPart = "-" Then mPart = ""
        Else
          mPart = vCellValue.Substring(mPos + 1).Trim
          If mPart = "-" Then mPart = ""
        End If
      Else
        mPart = vCellValue
      End If

      Return mPart
    End Function

  End Class
  Public Class clsSpreadSheetColumnOptional : Inherits clsSpreadSheetColumnColumnName

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)

      pIsValid = True

    End Sub

  End Class

  Public Class clsSpreadSheetColumnNumerical : Inherits clsSpreadSheetColumnColumnName
    Private pValidRange As Boolean
    Private pAllowBlank As Boolean
    Private pMin As Decimal
    Private pMax As Decimal

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByVal vAllowBlank As Boolean)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pAllowBlank = vAllowBlank
    End Sub

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByVal vAllowBlank As Boolean, ByVal vMin As Decimal, ByVal vMax As Decimal)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pAllowBlank = vAllowBlank
      pValidRange = True
      pMin = vMin
      pMax = vMax
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      pIsValid = False
      If IsNumeric(vCellValue) Then
        If pValidRange = True Then
          If Val(vCellValue) >= pMin And Val(vCellValue) <= pMax Then
            pIsValid = True
          End If
        Else
          pIsValid = True
        End If
      Else
        If pAllowBlank Then
          pIsValid = vCellValue = "-" Or String.IsNullOrWhiteSpace(vCellValue)
        Else
          pIsValid = vCellValue = "-"
        End If
      End If

    End Sub

  End Class

  Public Class clsSpreadSheetColumnSpecies : Inherits clsSpreadSheetColumnColumnName
    Private pListOfSpeciesString As New List(Of String)
    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
    End Sub

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)



      For Each mWoodSpecie In CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies)


        If Not pListOfSpeciesString.Contains(mWoodSpecie.EnglishDescription) Then
          pListOfSpeciesString.Add(mWoodSpecie.EnglishDescription.Trim.ToUpper)
        End If


      Next

      If pListOfSpeciesString.Contains(vCellValue.Trim.ToUpper) Then
        pIsValid = True

      Else
        pIsValid = False

      End If


    End Sub

  End Class


  Public Class clsSpreadSheetColumnExcelMappings : Inherits clsSpreadSheetColumnColumnName
    Private pMappings As colExcelMappings
    Private pAllowBlank As Boolean

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase, ByVal vColumnID As Integer, ByVal vHeaderText As String, ByRef rMappings As colExcelMappings, ByVal vAllowBlank As Boolean)
      MyBase.New(rSpreadSheetModel, vColumnID, vHeaderText)
      pMappings = rMappings
      pAllowBlank = vAllowBlank
    End Sub

    Public ReadOnly Property Mappings As colExcelMappings
      Get
        Return pMappings
      End Get
    End Property

    Public Overrides Sub ValidateCells(ByVal vCellValue As String)
      If vCellValue = "" And pAllowBlank Then
        pIsValid = True
      Else
        pIsValid = (pMappings.IndexFromCellValue(Me.ColumnID, vCellValue) >= 0)
      End If
    End Sub

    Public Function DisplayValueToItemValue(ByVal vCellValue As String) As Integer
      Dim mID As Integer = -1

      Dim mIndex As Integer = pMappings.IndexFromCellValue(Me.ColumnID, vCellValue)

      If mIndex = -1 Then
        If pAllowBlank Then
          If vCellValue = "" Then
            mID = 0
          End If
        End If
      Else
        Dim mValueItem As dmExcelMapping = pMappings(mIndex)

        mID = mValueItem.TranslationValue
      End If
      Return mID
    End Function

  End Class

  Public Class clsQuoteSpreadSheetRow : Inherits clsSpreadSheetModelRowBase

    Public Sub New(ByRef rSpreadSheetModel As clsSpreadSheetModelBase)
      MyBase.New(rSpreadSheetModel)
    End Sub

    Public Overrides Function ValidateRow(ByRef vSpreadSheetRow As clsSpreadSheetModelRowBase) As Object
      Return True
    End Function

    Public Overloads Sub RetreiveValues()
      ReDim pRowValues(pSpreadSheetModel.SpreadSheetModelColumns.Count)
      For Each mCol As clsSpreadSheetModelColumnBase In pSpreadSheetModel.SpreadSheetModelColumns
        If mCol.SpreadSheetColumnNo > -1 Then
          SetValue(mCol.ColumnID, pSpreadSheetModel.WorkSheet.GetCellValue(mCol.SpreadSheetColumnNo, pCurrentWorkSheetRow).ToString)
        End If
      Next
    End Sub

  End Class

End Class





