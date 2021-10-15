﻿Imports RTIS.CommonVB

Public Class fccPurchaseManagement
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderInfos As colWorkOrderInfos
  Private pIncludeRecentlyCompleted As Boolean
  Private pPurchaseOrderInfos As colPurchaseOrderInfos

  Public ReadOnly Property WorkOrderInfos As colWorkOrderInfos
    Get
      Return pWorkOrderInfos
    End Get
  End Property

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pWorkOrderInfos = New colWorkOrderInfos
    pPurchaseOrderInfos = New colPurchaseOrderInfos
  End Sub


  Public Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property IncludeRecentlyCompleted As Boolean
    Get
      Return pIncludeRecentlyCompleted
    End Get
    Set(value As Boolean)
      pIncludeRecentlyCompleted = value
    End Set
  End Property

  Public Sub LoadObject()
    Try
      Dim mdtoWorkOrderInfo As New dtoWorkOrderInfo(pDBConn, dtoWorkOrderInfo.eMode.WorkOrderTracking)
      Dim mdtoWorkOrderMatReqCategoryStatus As New dtoWorkOrderMatReqCategoryStatus(pDBConn)
      Dim mSOPMRCSs As New colWorkOrderMatReqCategoryStatuss
      Dim mWhere As String
      Dim mWhere2 As String
      Dim mWorkOrderInfo As clsWorkOrderInfo
      Dim mDataTable As DataTable
      Dim mWorkOrderID As Int32
      Dim mDatePlanned As Date
      Dim mCutOffDate As Date
      Dim mdso As dsoPurchasing
      pWorkOrderInfos = New colWorkOrderInfos

      If pIncludeRecentlyCompleted = True Then
        mCutOffDate = Now.Date.AddDays(-90)
      Else
        mCutOffDate = Now.Date.AddDays(-90) 'Now.Date.AddDays(-2)
      End If


      mWhere = String.Format("Status in (0,{0},{1})", CInt(eWorkOrderStatus.InProcess), CInt(eWorkOrderStatus.Raised))
      mWhere &= " and Description<>'' and ProductTypeID<>" & eProductType.WoodWorkOrder

      If pDBConn.Connect Then
        mdtoWorkOrderInfo.LoadWorkOrderInfoCollectionByWhere(pWorkOrderInfos, mWhere)

        'mWhere = String.Format("OrderTypeID = {4} and (IsNull(SalesOrderID,0)<>0 and PlannedStartDate Is Null Or PlannedStartDate > '{0}') And IsNull(Status,0)  not in ({1}) And isnull(OrderStatusENUM,0) not in ( {2},{5} ) and Isnull(ProductTypeID,0)={3}", mCutOffDate.ToString("yyyyMMdd"), CInt(eWorkOrderStatus.Cancelled), CInt(eSalesOrderstatus.Cancelada), CInt(eProductType.StructureAF), CInt(eOrderType.Sales), CInt(eSalesOrderstatus.Completed))

        mWhere2 = "WorkOrderID in (Select WorkOrderID from vwWorkOrderTracking where " & mWhere & ")"
        mdtoWorkOrderMatReqCategoryStatus.LoadWorkOrderMatReqCategoryStatusCollectionByWhere(mSOPMRCSs, mWhere2)

        For Each mSOPMRCS As dmWorkOrderMatReqCategoryStatus In mSOPMRCSs
          mWorkOrderInfo = pWorkOrderInfos.ItemFromWorkOrderID(mSOPMRCS.WorkOrderID)
          mWorkOrderInfo.WorkOrder.WorkOrderMatReqCategoryStatuss.Add(mSOPMRCS)
        Next

        mDataTable = pDBConn.CreateDataTable("Select * From vwWorkOrderDatePlanned")
        If mDataTable IsNot Nothing AndAlso mDataTable.Rows.Count > 0 Then
          For Each mDataRow As DataRow In mDataTable.Rows
            mWorkOrderID = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mDataRow.Item("WorkOrderID"))
            mDatePlanned = RTIS.CommonVB.clsGeneralA.DBValueToDate(mDataRow.Item("PhaseDatePlanned"))
            mWorkOrderInfo = pWorkOrderInfos.ItemFromWorkOrderID(mWorkOrderID)
            If mWorkOrderInfo IsNot Nothing Then
              mWorkOrderInfo.DatePlanned = mDatePlanned
            End If
          Next
        End If


      End If

      If DBConn.IsConnected Then
        DBConn.Disconnect()
      End If

      mdtoWorkOrderInfo = Nothing
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Function SaveObject() As Boolean
    Dim mOk As Boolean

    Try


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mOk
  End Function

  Public Function GetSOPMatReqCategoryStatus(ByVal vWorkOrderID As Integer, ByVal vCategory As Byte) As dmWorkOrderMatReqCategoryStatus
    Dim mOk As Boolean
    Dim mdtoWorkOrderMatReqCategoryStatus As New dtoWorkOrderMatReqCategoryStatus(pDBConn)
    Dim mWorkOrderMatReqCategoryStatuss As New colWorkOrderMatReqCategoryStatuss
    Dim mWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus = Nothing
    Dim mWhere As String

    Try

      mWorkOrderMatReqCategoryStatus = New dmWorkOrderMatReqCategoryStatus

      mWhere = String.Format("WorkOrderID = {0} And MatReqCategory = {1}", vWorkOrderID, vCategory)
      If pDBConn.Connect Then
        mdtoWorkOrderMatReqCategoryStatus.LoadWorkOrderMatReqCategoryStatusCollectionByWhere(mWorkOrderMatReqCategoryStatuss, mWhere)
      End If


      If mWorkOrderMatReqCategoryStatuss.Count = 0 Then
        mWorkOrderMatReqCategoryStatus = New dmWorkOrderMatReqCategoryStatus
      Else
        mWorkOrderMatReqCategoryStatus = mWorkOrderMatReqCategoryStatuss(0)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mWorkOrderMatReqCategoryStatus
  End Function



End Class