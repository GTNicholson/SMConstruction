Imports RTIS.CommonVB

Public Class fccWorkOrderPhaseMatReqCategoryStatusDetail
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderID As Integer
  Private pMaterialCategory As eStockItemCategory
  Private pWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus

  Private pWorkOrder As dmWorkOrder

  Private pPurchaseOrders As colPurchaseOrders
  Private pMaterialRequirementInfos As colMaterialRequirementInfos
  Private pSuppliers As colSuppliers

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus, ByVal vWorkOrderID As Integer, ByVal vMaterialCategory As eStockItemCategory)
    pDBConn = rDBConn
    pWorkOrderID = vWorkOrderID
    pMaterialCategory = vMaterialCategory
    pWorkOrderMatReqCategoryStatus = rWorkOrderMatReqCategoryStatus
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public Property WorkOrderID As Integer
    Get
      Return pWorkOrderID
    End Get
    Set(value As Integer)
      pWorkOrderID = value
    End Set
  End Property

  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property MaterialCategory As eStockItemCategory
    Get
      Return pMaterialCategory
    End Get
    Set(value As eStockItemCategory)
      pMaterialCategory = value
    End Set
  End Property

  Public Property WorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus
    Get
      Return pWorkOrderMatReqCategoryStatus
    End Get
    Set(value As dmWorkOrderMatReqCategoryStatus)
      pWorkOrderMatReqCategoryStatus = value
    End Set
  End Property

  Public ReadOnly Property PurchaseOrders As colPurchaseOrders
    Get
      Return pPurchaseOrders
    End Get
  End Property

  Public ReadOnly Property MaterialRequirementInfos As colMaterialRequirementInfos
    Get
      Return pMaterialRequirementInfos
    End Get
  End Property
  Public Property Suppliers As colSuppliers
    Get
      Return pSuppliers
    End Get
    Set(value As colSuppliers)
      pSuppliers = value
    End Set
  End Property

  Public Sub LoadObjects()
    Try

      LoadWorkOrder()
      LoadPurchaseOrders()
      LoadMaterialRequirementInfos()
      LoadSuppliers()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub LoadWorkOrder()
    Dim mdso As dsoSalesOrder
    pWorkOrder = New dmWorkOrder
    mdso = New dsoSalesOrder(pDBConn)
    mdso.LoadWorkOrderDown(pWorkOrder, pWorkOrderID)
  End Sub

  Public Sub LoadSuppliers()
    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    Dim mOK As Boolean


    pSuppliers = New colSuppliers

    If pDBConn.Connect Then
      mOK = mdtoSupplier.LoadSupplierCollection(pSuppliers)

    End If

  End Sub

  Public Sub SaveObjects()
    Try
      Dim mdso As dsoPurchasing
      mdso = New dsoPurchasing(pDBConn)
      mdso.SaveWorkOrderPhaseMatReqCategoryStatus(pWorkOrderMatReqCategoryStatus)
      For Each mPO As dmPurchaseOrder In pPurchaseOrders
        mdso.SavePurchaseOrderDownNEW(mPO)
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub LoadPurchaseOrders()
    Dim mdso As dsoPurchasing

    mdso = New dsoPurchasing(pDBConn)
    pPurchaseOrders = New colPurchaseOrders

    mdso.LoadWorkOrderPurchaseOrdersDownByWorkOrderIDAndCategory(pPurchaseOrders, pWorkOrderID, pMaterialCategory)

  End Sub

  Public Sub LoadMaterialRequirementInfos()
    Dim mdso As dsoSalesOrder
    Dim mWhere As String

    mWhere = "WorkOrderID = " & pWorkOrderID & " And Category = " & CInt(pWorkOrderMatReqCategoryStatus.MatReqCategory)
    mdso = New dsoSalesOrder(pDBConn)
    pMaterialRequirementInfos = New colMaterialRequirementInfos
    mdso.LoadWorkOrderMatReqInfosByWhere(pMaterialRequirementInfos, mWhere)

  End Sub

  Public Function AddNewPurchaseOrder() As Integer
    Dim mHandler As clsPurchaseHandler
    Dim mPO As dmPurchaseOrder
    Dim mdso As dsoPurchasing
    Dim mSalesOrderPhaseID As Integer
    Dim mRetVal As Integer = -1

    mHandler = New clsPurchaseHandler()

    mSalesOrderPhaseID = GetSalesOrderPhaseIDByWorkOrderID(pWorkOrderID)
    If mSalesOrderPhaseID > 0 Then




      mPO = mHandler.CreateSOPMatReqCatDefaultPO(mSalesOrderPhaseID, 0, pWorkOrderMatReqCategoryStatus.MatReqCategory)
      GetNextPONo(mPO)

      mdso = New dsoPurchasing(pDBConn)
      mdso.SavePurchaseOrderDownNEW(mPO)

      pPurchaseOrders.Add(mPO)
      mRetVal = mPO.PurchaseOrderID
    End If

    Return mRetVal
  End Function

  Public Sub GetNextPONo(ByRef rPO As dmPurchaseOrder)
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    If rPO.PONum = "" Then
      rPO.PONum = mdsoGeneral.GetNextTallyPONo().ToString("00000")
    End If
  End Sub

  Private Function GetSalesOrderPhaseIDByWorkOrderID(ByVal vWorkOrderID As Integer) As Integer
    Dim mRetVal As Integer = 0
    Dim mWhere As String = ""
    Try
      pDBConn.Connect()

      mWhere = "select distinct("
      mWhere &= "SOPI.SalesOrderPhaseID) "
      mWhere &= "from SalesOrderPhaseItem SOPI "
      mWhere &= "inner join WorkOrderAllocation WOA on WOA.SalesOrderPhaseItemID=SOPI.SalesOrderPhaseItemID "
      mWhere &= "where WorkOrderID = " & vWorkOrderID
      mRetVal = pDBConn.ExecuteScalar(mWhere)

      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
      mRetVal = 0
    End Try

    Return mRetVal
  End Function

  Public Sub RemovePurchaseOrder(ByRef rPO As dmPurchaseOrder)
    Dim mdso As dsoPurchasing
    pPurchaseOrders.Remove(rPO)
    mdso = New dsoPurchasing(pDBConn)
    mdso.DeletePuchaseOrder(rPO)

  End Sub

  Public Sub RefresStatusInfo()
    Dim mHandler As clsPurchaseHandler

    mHandler = New clsPurchaseHandler

    mHandler.RefreshWorkOrderMatRecCategoryStatusInfo(pWorkOrderMatReqCategoryStatus, pPurchaseOrders)
  End Sub


  Public Sub SetWorkOrderMatCatStatus(ByVal vNewStatus As Int32)
    Dim mdso As dsoPurchasing
    Dim mPrevStatus As eMatReqCategoryStatus

    mPrevStatus = pWorkOrderMatReqCategoryStatus.Status
    pWorkOrderMatReqCategoryStatus.Status = vNewStatus

    mdso = New dsoPurchasing(pDBConn)
    mdso.UpdateWorkOrderPickStatusNotRequireds(WorkOrderMatReqCategoryStatus.WorkOrderID, WorkOrderMatReqCategoryStatus.MatReqCategory, vNewStatus)

  End Sub

  Public Function GetPOICount(ByVal vPurchaseOrderID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mWhere As String
    Try
      pDBConn.Connect()
      mWhere = "Select count(*) from PurchaseOrderItem where PurchaseOrderID = " & vPurchaseOrderID
      mRetVal = pDBConn.ExecuteScalar(mWhere)
      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
      mRetVal = -1

    End Try

    Return mRetVal
  End Function

  Public Function GetPODCount(ByVal vPurchaseOrderID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mWhere As String
    Try
      pDBConn.Connect()
      mWhere = "Select count(*) from PODelivery where PurchaseOrderID = " & vPurchaseOrderID

      mRetVal = pDBConn.ExecuteScalar(mWhere)
      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
      mRetVal = -1

    End Try

    Return mRetVal

  End Function
End Class
