
Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoBIInvoice
  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView

  Private pInvoiceInfos As colInvoiceInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView
  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pInvoiceInfos
    End Get
    Set(value As Object)
      pInvoiceInfos = value
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
    Dim mdto As dtoInvoiceInfo
    Dim mSQLWhere1 As String
    Dim mSQLWhere2 As String
    Dim mSQLWhere As String = ""

    Try

      pInvoiceInfos = New colInvoiceInfos

      pDBConn.Connect()
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Invoice)

      mSQLWhere1 = pBIReportView.ConditionSetters(0).FilterSQL
      mSQLWhere2 = pBIReportView.ConditionSetters(1).FilterSQL

      mSQLWhere = mSQLWhere1
      If mSQLWhere <> "" And mSQLWhere2 <> "" Then mSQLWhere = mSQLWhere & " And "
      mSQLWhere = mSQLWhere & mSQLWhere2

      If mSQLWhere <> "" Then mSQLWhere = "(" & mSQLWhere & ") And "
      mSQLWhere = mSQLWhere & "InvoiceDate Is Not Null"


      mdto.LoadInvoiceCollectionByWhere(pInvoiceInfos, mSQLWhere)

      If pBIReportView.BIReportSource.ColManRepParameter.ItemFromKey(3).FilterValue = 1 Then
        mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Packed)
        mdto.LoadInvoiceCollectionByWhere(pInvoiceInfos, mSQLWhere)
        mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Engineered)
        mdto.LoadInvoiceCollectionByWhere(pInvoiceInfos, mSQLWhere)
        mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Pending)
        mdto.LoadInvoiceCollectionByWhere(pInvoiceInfos, mSQLWhere)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Function
End Class

