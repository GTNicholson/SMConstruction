Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements


Public Class fccSalesOrderPhasePicker
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pWhereSQL As String

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal() As AppRTISGlobal
    Get
      RTISGlobal = pRTISGlobal
    End Get
    Set(ByVal value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public Property WhereSQL() As String
    Get
      WhereSQL = pWhereSQL
    End Get
    Set(value As String)
      pWhereSQL = value
    End Set
  End Property


  Public Function LoadSalesOrderPhaseDT() As DataTable
    Dim mdso As New dsoSalesOrder(DBConn)
    Dim mDT As DataTable = Nothing
    mdso.LoadSalesOrderDT(mDT, pWhereSQL)
    Return mDT
  End Function
End Class
