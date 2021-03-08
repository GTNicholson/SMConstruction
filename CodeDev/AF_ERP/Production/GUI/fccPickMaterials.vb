Imports RTIS.CommonVB

Public Class fccPickMaterials

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrder As colWorkOrderInfos
  Private pMaterialRequirementProcessors As colMaterialRequirementProcessors
  Private pFormController As fccPickMaterials
  Private pCurrentWorkOrderInfo As clsWorkOrderInfo
  Private pWhere As String

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pMaterialRequirementProcessors = New colMaterialRequirementProcessors
  End Sub

  Public Property WhereSQL() As String
    Get
      WhereSQL = pWhere
    End Get
    Set(value As String)
      pWhere = value
    End Set
  End Property


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

  Public Property MaterialRequirementProcessors() As colMaterialRequirementProcessors
    Get
      MaterialRequirementProcessors = pMaterialRequirementProcessors
    End Get
    Set(ByVal value As colMaterialRequirementProcessors)
      pMaterialRequirementProcessors = value
    End Set
  End Property

  Public Sub LoadWorkOrderInfos(ByRef rcolWorkOrderInfos As colWorkOrderInfos)

    Dim mdto As dtoWorkOrderInfo
    Dim mwhere As String
    mwhere = "WorkOrderID Not In (select Distinct WorkOrderID from WorkOrderMilestoneStatus Where MilestoneENUM = 10 and Status = 3)"
    mwhere += " and ( WorkOrderID in (select WorkOrderID from vwWorkOrderInfo)"
    '' mwhere = "  WorkOrderID In (Select WorkOrderID from vwWorkOrderInfo)" ''borrar todo esto, solo sirve para que se ingrese los datos
    mwhere += " Or WorkOrderId In (Select WorkOrderID from vwWorkOrderInternalInfo))"
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(DBConn, 3)
      mdto.LoadWorkOrderInfoCollectionByWhere(rcolWorkOrderInfos, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub

  Public Sub LoadSalesOrderPhaseInfos(ByRef rSOPInfos As colSalesOrderPhaseInfos)

    Dim mdto As dtoSalesOrderPhaseInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseInfo(DBConn)
      mdto.LoadSOPCollectionByWhere(rSOPInfos, "")


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub

  Public Function LoadWorkOrderInfoDT() As DataTable
    Dim mdso As New dsoSales(DBConn)
    Dim mDT As DataTable = Nothing
    mdso.LoadWorkOrderDT(mDT, "")
    Return mDT
  End Function

  Public Sub LoadMaterialRequirementProcessorss()

    Dim mdto As dtoMaterialRequirementInfo
    Dim mWhere As String = " WorkOrderID =" & pCurrentWorkOrderInfo.WorkOrderID
    pMaterialRequirementProcessors.Clear()
    Try

      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(DBConn, dtoMaterialRequirementInfo.eMode.Processor)

      mdto.LoadMaterialRequirementProcessorsByWhere(pMaterialRequirementProcessors, mWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Sub ProcessPicks()
    Try
      Dim mdsoTran As dsoStockTransactions
      Dim mMatReq As dtoMaterialRequirement

      Dim mdsoStock As dsoStock
      Dim mSIL As New dmStockItemLocation

      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)

      For Each mMRP As clsMaterialRequirementProcessor In pMaterialRequirementProcessors
        If mMRP.ToProcessQty <> 0 Then
          If mMRP.StockItem.StockItemID <> 0 Then
            mSIL = mdsoStock.GetOrCreateStockItemLocation(mMRP.StockItem.StockItemID, 1)
          Else
            mSIL = Nothing
          End If
          mdsoTran.PickMatReqStockItemLocationQty(mSIL, mMRP.ToProcessQty, mMRP.MaterialRequirement, Now, eCurrency.Dollar, mMRP.StockItem.StdCost, 1)
          mMRP.ToProcessQty = 0
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub CreateAdditionalMatReqs(ByRef rStockItemList As List(Of RTIS.ERPStock.intStockItemDef))
    Dim mMatReqs As New colMaterialRequirements
    Dim mMatReq As dmMaterialRequirement
    Dim mdso As dsoSales
    Try

      mdso = New dsoSales(pDBConn)

      For Each mSI As dmStockItem In rStockItemList
        mMatReq = New dmMaterialRequirement
        mMatReq.ObjectType = eObjectType.WorkOrder
        mMatReq.ObjectID = pCurrentWorkOrderInfo.WorkOrderID
        mMatReq.StockItemID = mSI.StockItemID
        mMatReq.MaterialRequirementType = eMaterialRequirementType.StockItems
        mMatReqs.Add(mMatReq)
      Next

      mdso.SaveMaterialRequirementsCollection(mMatReqs, eObjectType.WorkOrder, pCurrentWorkOrderInfo.WorkOrderID, eMaterialRequirementType.StockItems)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub


End Class
