﻿

Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoBIPODeliveryItemInfo
  Implements RTIS.BIReport.iDataSourceLoader

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView

  Private pPODeliveryItemInfos As colPODeliveryItemInfos

  Public Sub New(ByRef rDBConn As clsDBConnBase, rRTISGlobal As AppRTISGlobal, rBIReportView As clsBIReportView)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pBIReportView = rBIReportView
  End Sub

  Public Property DataSource As Object Implements iDataSourceLoader.DataSource
    Get
      Return pPODeliveryItemInfos
    End Get
    Set(value As Object)
      pPODeliveryItemInfos = value
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
    Dim mdto As dtoPODeliveryItemInfo
    Dim mSQLWhere1 As String
    Dim mSQLWhere2 As String
    Dim mSQLWhere As String = ""

    Try

      pPODeliveryItemInfos = New colPODeliveryItemInfos

      pDBConn.Connect()
      mdto = New dtoPODeliveryItemInfo(pDBConn)

      mSQLWhere1 = pBIReportView.ConditionSetters(0).FilterSQL
      mSQLWhere2 = pBIReportView.ConditionSetters(1).FilterSQL

      mSQLWhere = mSQLWhere1
      If mSQLWhere <> "" And mSQLWhere2 <> "" Then mSQLWhere = mSQLWhere & " And "
      mSQLWhere = mSQLWhere & mSQLWhere2

      If mSQLWhere <> "" Then mSQLWhere = "(" & mSQLWhere & ") And "
      mSQLWhere = mSQLWhere & "GRNumber <> ''"


      mdto.LoadPODeliveryItemInfoCollectionByWhere(pPODeliveryItemInfos, mSQLWhere)



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Function
End Class



