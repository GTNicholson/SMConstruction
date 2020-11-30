﻿Imports RTIS.CommonVB

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

  Public Function SavePickWoodMaterialRequirement(ByRef rPickWoodMaterialRequirement As dmPickWoodMaterialRequirement) As Boolean
    Dim mdto As dtoPickWoodMaterialRequirement
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoPickWoodMaterialRequirement(pDBConn)
      mdto.SavePickWoodMaterialRequirement(rPickWoodMaterialRequirement)

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

  Public Sub LoadPickWoodMaterialItemProcessorss(ByRef rPOItemProcessors As colPickWoodMaterialItemProcessors, ByVal vPickWoodMaterialRequirementID As Integer)

    Dim mdto As dtoPurchaseOrderItemAllocationInfo
    Dim mdtoPODI As dtoPODeliveryItem
    Dim mPODIs As colPODeliveryItems
    Dim mPOIA As clsPurchaseOrderItemAllocationProcessor
    Dim mWhere As String

    Try
      mdto = New dtoPurchaseOrderItemAllocationInfo(pDBConn, dtoPurchaseOrderItemAllocationInfo.eMode.Processor)

      pDBConn.Connect()

      mWhere = "PurchaseOrderID = " & vPurchaseOrderID
      mdto.LoadPurchaseOrderItemAllocationProcessorsByWhere(rPOItemAllocationProcessors, mWhere)

      mdtoPODI = New dtoPODeliveryItem(pDBConn)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub
End Class
