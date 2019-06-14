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

End Class
