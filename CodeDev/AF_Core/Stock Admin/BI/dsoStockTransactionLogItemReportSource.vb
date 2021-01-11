Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoStockTransactionLogItemReportSource

  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView
  Private pIsWoodReport As Boolean
  Private pStockTransactionLogItems As colStockItemTransactionLogInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView, ByVal vIsWoodReport As Boolean)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView
    pIsWoodReport = vIsWoodReport
  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pStockTransactionLogItems
    End Get
    Set(value As Object)
      pStockTransactionLogItems = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase Implements iDataSourceLoader.DBConn
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property ManReport As clsBIReportView Implements iDataSourceLoader.ManReport
    Get
      Return pBIReportView
    End Get
    Set(value As clsBIReportView)
      pBIReportView = value
    End Set
  End Property

  Public ReadOnly Property RecordCount As Integer Implements iDataSourceLoader.RecordCount
    Get
      Throw New NotImplementedException()
    End Get
  End Property

  Public Function LoadDataSource() As Boolean Implements iDataSourceLoader.LoadDataSource
    Dim mdto As dtoStockItemTransactionLogInfo
    Dim mWhere As String = ""

    Try

      pStockTransactionLogItems = New colStockItemTransactionLogInfos

      pDBConn.Connect()
      If pIsWoodReport Then
        mdto = New dtoStockItemTransactionLogInfo(pDBConn, dtoStockItemTransactionLogInfo.eMode.WoodStockItemTransactionLogInfo)
      Else

        mdto = New dtoStockItemTransactionLogInfo(pDBConn, dtoStockItemTransactionLogInfo.eMode.StockItemTransactionLogInfo)

      End If

      mWhere = pBIReportView.ConditionSetters(0).FilterSQL

      If pBIReportView.ConditionSetters(1).FilterSQL <> "" Then
        If mWhere <> "" Then mWhere = mWhere & "And (" & pBIReportView.ConditionSetters(1).FilterSQL & ")"
      End If

      ''If pBIReportView.CurrentReport.BIReportDefID = BIReportViewStockItemTransactionLogInfo.eBIReportDefs.TransferValue Then
      ''  If mWhere <> "" Then mWhere &= " And "
      ''  mWhere &= "TransactionType = " & CInt(eTransactionType.Transfer)
      ''End If

      mdto.LoadStockItemTransactionLogInfoCollection(pStockTransactionLogItems, mWhere)




      If pStockTransactionLogItems IsNot Nothing Then

        For Each mSTLI As clsStockItemTransactionLogInfo In pStockTransactionLogItems

          If mSTLI.TransType = eTransactionType.Pick Then
            mSTLI.ExchangeRate = GetExchangeRate(mSTLI.TransDate, eCurrency.Cordobas)
            mSTLI.TransactionValuationDollar = mSTLI.TotalValue / mSTLI.ExchangeRate

          End If

        Next

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return True
  End Function

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mExchangeRate As Decimal = 0

    mExchangeRate = mdsoGeneral.GetExchangeRate(vDate, vCurrency)

    Return mExchangeRate
  End Function

End Class
