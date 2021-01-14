﻿
Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoBIMatReqInfo
  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView

  Private pMatReqInfos As colMaterialRequirementInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView
  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pMatReqInfos
    End Get
    Set(value As Object)
      pMatReqInfos = value
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

    Dim mSQLWhere1 As String
    Dim mSQLWhere2 As String
    Dim mSQLWhere As String = ""
    Dim dtoMatReqInfo As New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.Info)




    Try

      pMatReqInfos = New colMaterialRequirementInfos()

      pDBConn.Connect()


      mSQLWhere1 = pBIReportView.ConditionSetters(0).FilterSQL
      mSQLWhere2 = pBIReportView.ConditionSetters(1).FilterSQL

      mSQLWhere = mSQLWhere1
      If mSQLWhere <> "" And mSQLWhere2 <> "" Then mSQLWhere = mSQLWhere & " And "
      mSQLWhere = mSQLWhere & mSQLWhere2

      'If mSQLWhere = "" Then
      '  mSQLWhere = "status <> " & ePurchaseOrderDueDateStatus.Cancelled
      'Else
      '  mSQLWhere = " and status <> " & ePurchaseOrderDueDateStatus.Cancelled

      'End If
      dtoMatReqInfo.LoadMaterialRequirementCollection(pMatReqInfos, mSQLWhere)

      If pMatReqInfos IsNot Nothing Then

        For Each mMatReqInfo As clsMaterialRequirementInfo In pMatReqInfos
          mMatReqInfo.ExchangeRate = GetExchangeRate(mMatReqInfo.TransactionDate, eCurrency.Cordobas)
        Next

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Function

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mExchangeRate As Decimal = 0

    mExchangeRate = mdsoGeneral.GetExchangeRate(vDate, vCurrency)

    Return mExchangeRate
  End Function

End Class
