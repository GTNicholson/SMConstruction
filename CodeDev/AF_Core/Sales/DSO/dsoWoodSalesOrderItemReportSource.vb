Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoWoodSalesOrderItemReportSource

  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView
  Private pSalesOrderInfos As colSalesOrderInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView
  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pSalesOrderInfos
    End Get
    Set(value As Object)
      pSalesOrderInfos = value
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
    Dim mdto As dtoSalesOrderInfo
    Dim mWhere As String = ""

    Try

      pSalesOrderInfos = New colSalesOrderInfos

      pDBConn.Connect()


      mdto = New dtoSalesOrderInfo(pDBConn)


      mWhere = "OrderTypeID=" & CInt(eOrderType.WoodSales) & " and IsDepatch=1"

      If pBIReportView.ConditionSetters(0).FilterSQL <> "" Then
        mWhere &= " and " & pBIReportView.ConditionSetters(0).FilterSQL
      Else

      End If


      If pBIReportView.ConditionSetters(1).FilterSQL <> "" Then
        If mWhere <> "" Then mWhere = mWhere & "And (" & pBIReportView.ConditionSetters(1).FilterSQL & ")"
      End If

      ''If pBIReportView.CurrentReport.BIReportDefID = BIReportViewSalesOrderInfo.eBIReportDefs.TransferValue Then
      ''  If mWhere <> "" Then mWhere &= " And "
      ''  mWhere &= "TransactionType = " & CInt(eTransactionType.Transfer)
      ''End If

      mdto.LoadSalesOrderInfoInfoCollectionByWhere(pSalesOrderInfos, mWhere)





    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return True
  End Function



End Class
