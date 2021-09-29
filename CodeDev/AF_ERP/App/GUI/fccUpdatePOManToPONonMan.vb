Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccUpdatePOManToPONonMan
  Private pDBConn As clsDBConnBase

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property SalesOrderPhaseItemID As Integer
  Public Property PurchaseOrderID As Integer
  Public Property ItemRef As String
  Public Property ItemRef2 As String
  Public Property OptionString As String
  Public Property WorkOrderID As Integer
  Public Property ProjectRef As String

  Public Function LoadSalesOrderPhaseItemInfo(ByRef rSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderPhaseItemInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseItemInfo(pDBConn, dtoSalesOrderPhaseItemInfo.eMode.SalesOrderPhaseItemInfo)
      mdto.LoadSOPICollectionByWhere(rSalesOrderPhaseItemInfos, vWhere)


      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetPurchaseOrderIDByPONum(ByVal vPONum As String) As Integer
    Dim mPurchaseOrderID As Integer
    Dim msql As String = ""
    Try
      msql = String.Format("Select PurchaseOrderID from PurchaseOrder where PONum ='{0}'", vPONum)
      pDBConn.Connect()

      mPurchaseOrderID = pDBConn.ExecuteScalar(msql)



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
    Return mPurchaseOrderID
  End Function

  Public Sub UpdatePurchaseOrderAllocationManToNonMan()
    Dim msql As String = ""

    Try

      pDBConn.Connect()
      msql = String.Format("Update PurchaseOrder set MaterialRequirementTypeID = 3, MaterialRequirementTypeWorkOrderID=0 where PurchaseOrderID = {0} ", PurchaseOrderID)
      pDBConn.ExecuteNonQuery(msql)

      msql = String.Format("Update PurchaseOrderAllocation set WorkOrderID = NULL where PurchaseOrderID = {0} ", PurchaseOrderID)
      pDBConn.ExecuteNonQuery(msql)

      msql = String.Format("Update PurchaseOrderAllocation set SalesOrderPhaseItemID = {0} where PurchaseOrderID = {1} ", SalesOrderPhaseItemID, PurchaseOrderID)
      pDBConn.ExecuteNonQuery(msql)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub

  Public Sub UpdatePurchaseOrderItemAllocationManToNonMan()
    Dim msql As String = ""

    Try
      msql = "Update PurchaseOrderItemAllocation set WorkOrderID = NULL where PurchaseOrderItemAllocationID in ("

      msql &= " Select PurchaseOrderItemAllocationID from PurchaseOrderItemAllocation where PurchaseOrderItemID in ("
      msql &= " select PurchaseOrderItemID from PurchaseOrderItem"
      msql &= String.Format(" where PurchaseOrderID={0} ) )", PurchaseOrderID)

      pDBConn.Connect()

      pDBConn.ExecuteNonQuery(msql)

      msql = String.Format("Update PurchaseOrderItemAllocation set SalesOrderPhaseItemID = {0}, ItemRef='{1}', ItemRef2='{2}', ProjectRef ='{3}' where PurchaseOrderItemAllocationID in (", SalesOrderPhaseItemID, ItemRef, ItemRef2, ProjectRef)

      msql &= " Select PurchaseOrderItemAllocationID from PurchaseOrderItemAllocation where PurchaseOrderItemID in ("
      msql &= " select PurchaseOrderItemID from PurchaseOrderItem"
      msql &= String.Format(" where PurchaseOrderID={0} ) )", PurchaseOrderID)

      pDBConn.ExecuteNonQuery(msql)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try


  End Sub

  Public Sub LoadWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos)

    Dim mdso As New dsoSalesOrder(pDBConn)
    Dim mwhere As String = ""

    mwhere += String.Format("Status not in ({0},{1})", CInt(eWorkOrderStatus.Cancelled), CInt(eWorkOrderStatus.Complete))
    mwhere &= " and Description<>'' and ProductTypeID<>" & eProductType.WoodWorkOrder
    Try

      pDBConn.Connect()
      mdso.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub

  Public Sub UpdatePurchaseOrderAllocationNonManToMan()
    Dim msql As String = ""

    Try

      pDBConn.Connect()
      msql = String.Format("Update PurchaseOrder set MaterialRequirementTypeID = NULL, MaterialRequirementTypeWorkOrderID=3 where PurchaseOrderID = {0} ", PurchaseOrderID)
      pDBConn.ExecuteNonQuery(msql)

      msql = String.Format("Update PurchaseOrderAllocation set SalesOrderPhaseItemID = NULL where PurchaseOrderID = {0} ", PurchaseOrderID)
      pDBConn.ExecuteNonQuery(msql)

      msql = String.Format("Update PurchaseOrderAllocation set WorkOrderID = {0} where PurchaseOrderID = {1} ", WorkOrderID, PurchaseOrderID)
      pDBConn.ExecuteNonQuery(msql)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub

  Public Sub UpdatePurchaseOrderItemAllocationNonManToMan()
    Dim msql As String = ""

    Try
      msql = "Update PurchaseOrderItemAllocation set SalesOrderPhaseItemID = NULL where PurchaseOrderItemAllocationID in ("

      msql &= " Select PurchaseOrderItemAllocationID from PurchaseOrderItemAllocation where PurchaseOrderItemID in ("
      msql &= " select PurchaseOrderItemID from PurchaseOrderItem"
      msql &= String.Format(" where PurchaseOrderID={0} ) )", PurchaseOrderID)

      pDBConn.Connect()

      pDBConn.ExecuteNonQuery(msql)

      msql = String.Format("Update PurchaseOrderItemAllocation set WorkOrderID = {0}, ItemRef='{1}', ItemRef2='{2}', ProjectRef ='{3}' where PurchaseOrderItemAllocationID in (", WorkOrderID, ItemRef, ItemRef2, ProjectRef)

      msql &= " Select PurchaseOrderItemAllocationID from PurchaseOrderItemAllocation where PurchaseOrderItemID in ("
      msql &= " select PurchaseOrderItemID from PurchaseOrderItem"
      msql &= String.Format(" where PurchaseOrderID={0} ) )", PurchaseOrderID)

      pDBConn.ExecuteNonQuery(msql)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub
End Class
