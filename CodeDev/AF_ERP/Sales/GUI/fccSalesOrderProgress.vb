Imports RTIS.CommonVB

Public Class fccSalesOrderProgress
  Private pPrimaryKeyID As Integer

  Private pSalesOrderProgressInfos As colSalesOrderProgressInfos
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pSalesOrderProgressInfos = New colSalesOrderProgressInfos
    pRTISGlobal = rRTISGlobal

  End Sub


  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property


  Public ReadOnly Property SalesOrderProgressInfos As colSalesOrderProgressInfos
    Get
      Return pSalesOrderProgressInfos
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoSales

    pSalesOrderProgressInfos.Clear()


    mdso = New dsoSales(pDBConn)
    mdso.LoadSalesOrderProgressInfos(pSalesOrderProgressInfos, "")


  End Sub


End Class
