Public Class clsPickerSalesOrderPhaseItem : Inherits clsPickerBase(Of clsSalesOrderPhaseItemInfo)

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentProductID As Integer

  Public Sub New(ByVal vDataSource As colSalesOrderPhaseItemInfos, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    MyBase.New
    DataSource = vDataSource
    pDBConn = rDBConn
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property CurrentProductID As Integer
    Get
      Return pCurrentProductID
    End Get
    Set(value As Integer)
      pCurrentProductID = value
    End Set
  End Property


End Class
