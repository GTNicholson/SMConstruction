Imports RTIS.CommonVB

Public Class fccPickMaterials

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrder As colWorkOrderInfos
  Private pMaterialRequirementProcessors As colMaterialRequirementInfos
  Private pFormController As fccPickMaterials
  Private pCurrentWorkOrderInfo As clsWorkOrderInfo

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property WorkOrderInfos() As colWorkOrderInfos
    Get
      WorkOrderInfos = pWorkOrder
    End Get
    Set(ByVal value As colWorkOrderInfos)
      pWorkOrder = value
    End Set
  End Property

  Public Property CurrentWorkOrderInfo() As clsWorkOrderInfo
    Get
      CurrentWorkOrderInfo = pCurrentWorkOrderInfo
    End Get
    Set(ByVal value As clsWorkOrderInfo)
      pCurrentWorkOrderInfo = value
    End Set
  End Property

  Public Sub LoadWorkOrderInfos(ByRef rcolWorkOrderInfos As colWorkOrderInfos)

    Dim mdto As dtoWorkOrderInfo

    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(DBConn, 1)
      mdto.LoadWorkOrderInfoCollectionByWhere(rcolWorkOrderInfos, "")


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub



End Class
