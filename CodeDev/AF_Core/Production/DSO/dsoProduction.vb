Imports RTIS.CommonVB

Public Class dsoProduction
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function LoadWorkOrderTrackings(ByRef rWorkOrderTrackings As colWorkOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdto As dtoWorkOrderInfo
    Dim mdtoWOMSS As dtoWorkOrderMilestoneStatus
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, dtoWorkOrderInfo.eMode.WorkOrderTracking)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderTrackings, vWhere)

      mdtoWOMSS = New dtoWorkOrderMilestoneStatus(pDBConn)

      For Each mWOI As clsWorkOrderTracking In rWorkOrderTrackings
        mdtoWOMSS.LoadWorkOrderMilestoneStatusCollection(mWOI.MileStones, mWOI.WorkOrderID)
      Next

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadShifDetails(ByRef rShiftDetails As colShiftDetailss, ByVal vShiftDetailID As Integer) As Boolean
    Dim mdto As dtoShiftDetails
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoShiftDetails(pDBConn)
      mdto.LoadShiftDetailsCollection(rShiftDetails, vShiftDetailID)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function SaveMaintenanceWorkOrder(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoMaintenanceWorkOrder
    Dim mdtoItem As dtoMaintenanceWorkOrderItem
    Try

      mdto = New dtoMaintenanceWorkOrder(pDBConn)
      mdtoItem = New dtoMaintenanceWorkOrderItem(pDBConn)

      If pDBConn.Connect Then
        mRetVal = mdto.SaveMaintenanceWorkOrder(rMaintenanceWorkOrder)

        If mRetVal Then mdtoItem.SaveMaintenanceWorkOrderItemCollection(rMaintenanceWorkOrder.MaitenanceWorkOrderItems, rMaintenanceWorkOrder.MaintenanceWorkOrderID)

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try

    Return mRetVal
  End Function

  Public Sub LoadMachinery(ByRef rMachinery As dmMachinery, ByVal vEquipmentID As Integer)
    Dim mdto As New dtoMachinery(pDBConn)

    Try
      If pDBConn.Connect Then

        mdto.LoadMachinery(rMachinery, vEquipmentID)


      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing

    End Try
  End Sub

  Public Function LoadMaintenanceWorkOrder(ByRef rMaintenanceWorkOrder As dmMaintenanceWorkOrder, ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoMaintenanceWorkOrder
    Dim mdtoItem As dtoMaintenanceWorkOrderItem
    Dim mdtoMachinery As dtoMachinery

    Try
      mdto = New dtoMaintenanceWorkOrder(pDBConn)
      mdtoItem = New dtoMaintenanceWorkOrderItem(pDBConn)
      mdtoMachinery = New dtoMachinery(pDBConn)

      If pDBConn.Connect Then

        mRetVal = mdto.LoadMaintenanceWorkOrder(rMaintenanceWorkOrder, vPrimaryKeyID)


        If mRetVal Then mdtoItem.LoadMaintenanceWorkOrderItemCollection(rMaintenanceWorkOrder.MaitenanceWorkOrderItems, vPrimaryKeyID)

        If mRetVal Then mdtoMachinery.LoadMachinery(rMaintenanceWorkOrder.Machinery, rMaintenanceWorkOrder.EquipmentID)

      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
    Return mRetVal
  End Function

  Public Sub SaveShiftDetails(ByRef rShiftDetails As colShiftDetailss)
    Dim mdto As New dtoShiftDetails(pDBConn)

    Try
      pDBConn.Connect()

      mdto.SaveShiftDetailsCollection(rShiftDetails, 1)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub

  Public Function SaveWorkOrderTracking(ByRef rWorkOrderTracking As dmWorkOrderMilestoneStatus) As Boolean
    Dim mdto As dtoWorkOrderMilestoneStatus
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderMilestoneStatus(pDBConn)
      mdto.SaveWorkOrderMilestoneStatus(rWorkOrderTracking)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function



  Public Function LoadShiftsDownConnected(ByRef rShifts As colShifts) As Boolean
    Dim mdto As dtoShift
    Dim mdtoShifDetail As dtoShiftDetails
    Dim mRetVal As Boolean
    Try
      mdto = New dtoShift(pDBConn)
      mdto.LoadShiftCollection(rShifts)

      mdtoShifDetail = New dtoShiftDetails(pDBConn)

      For Each mShift As dmShift In rShifts
        mdtoShifDetail.LoadShiftDetailsCollection(mShift.ShifDetails, mShift.ShiftID)
      Next

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Function LoadWorkOrderAllocationInfos(ByRef rWorkOrderAllocationInfos As colWorkOrderAllocationInfos, ByVal vwhere As String)
    Dim mdto As dtoWorkOrderAllocationInfo
    Dim mRetVal As Boolean

    Try
      If pDBConn.Connect Then
        mdto = New dtoWorkOrderAllocationInfo(pDBConn, dtoWorkOrderAllocationInfo.eMode.WorkOrderAllocationInfo)

        mRetVal = mdto.LoadWorkOrderAllocationInfoCollectionByWhere(rWorkOrderAllocationInfos, vwhere)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw

    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing
    End Try
    Return mRetVal
  End Function

  Public Sub LoadWorkOrderAllocationInfo(ByRef rWorkOrderAllocationInfo As clsWorkOrderAllocationInfo, ByVal vWhere As String)

    Dim mdto As dtoWorkOrderAllocationInfo
    Dim mRetVal As Boolean
    Dim mWorkOrderAllocationInfos As New colWorkOrderAllocationInfos
    Try
      pDBConn.Connect()
      mdto = New dtoWorkOrderAllocationInfo(pDBConn, dtoWorkOrderAllocationInfo.eMode.WorkOrderAllocationInfo)

      mRetVal = mdto.LoadWorkOrderAllocationInfoCollectionByWhere(mWorkOrderAllocationInfos, vWhere)

      If mWorkOrderAllocationInfos.Count > 0 Then
        rWorkOrderAllocationInfo = mWorkOrderAllocationInfos(0)
      Else
        rWorkOrderAllocationInfo = Nothing
      End If
      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    End Try

  End Sub

  Public Sub LoadTimeSheetInfosByWhere(ByRef rTimeSheetProject As colTimeSheetEntryInfos, ByVal vWhere As String)
    Dim mdto As dtoTimeSheetEntryInfo


    Try

      pDBConn.Connect()
      mdto = New dtoTimeSheetEntryInfo(pDBConn)

      mdto.LoadTimeSheetEntryInfoCollectionByWhere(rTimeSheetProject, vWhere)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub
End Class
