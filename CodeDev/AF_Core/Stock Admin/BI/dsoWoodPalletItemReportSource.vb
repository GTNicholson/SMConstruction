Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoWoodPalletItemReportSource

  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView
  Private pWoodPalletItemInfos As colWoodPalletItemInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView

  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pWoodPalletItemInfos
    End Get
    Set(value As Object)
      pWoodPalletItemInfos = value
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
    Dim mdto As dtoWoodPalletItemInfo
    Dim mWhere As String = ""
    Dim mdsoCosting As New dsoCostBook(pDBConn)
    Dim mCostBookID As Integer
    Dim mCostBookEntrys As colCostBookEntrys
    Dim mCostBookEntry As dmCostBookEntry

    Try

      pWoodPalletItemInfos = New colWoodPalletItemInfos

      pDBConn.Connect()

      mdto = New dtoWoodPalletItemInfo(pDBConn)


      mWhere = pBIReportView.ConditionSetters(0).FilterSQL

      If pBIReportView.ConditionSetters(1).FilterSQL <> "" Then
        If mWhere <> "" Then mWhere = mWhere & "And (" & pBIReportView.ConditionSetters(1).FilterSQL & ")"
      End If

      ''If pBIReportView.CurrentReport.BIReportDefID = BIReportViewStockItemTransactionLogInfo.eBIReportDefs.TransferValue Then
      ''  If mWhere <> "" Then mWhere &= " And "
      ''  mWhere &= "TransactionType = " & CInt(eTransactionType.Transfer)
      ''End If

      mdto.LoadWoodPalletItemInfoCollectionByWhere(pWoodPalletItemInfos, mWhere)


      mCostBookID = mdsoCosting.GetDefaultCostBookID
      mCostBookEntrys = New colCostBookEntrys
      mdsoCosting.LoadCostBookEntry(mCostBookEntrys, mCostBookID)



      If pWoodPalletItemInfos IsNot Nothing Then

        For Each mWPII As clsWoodPalletItemInfo In pWoodPalletItemInfos

          mCostBookEntry = mCostBookEntrys.ItemFromStockItemID(mWPII.StockItem.StockItemID)

          If mCostBookEntry IsNot Nothing Then
            mWPII.UnitCost = mCostBookEntry.Cost  'mdsoCosting.GetDefaultCostBookValueByStockItemIDConnected(mWPII.StockItem.StockItemID)

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



End Class
