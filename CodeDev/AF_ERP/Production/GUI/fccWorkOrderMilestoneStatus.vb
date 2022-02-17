Imports RTIS.CommonVB

Public Class fccWorkOrderMilestoneStatus
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus)
    pDBConn = rDBConn
    pWorkOrderMilestoneStatus = rWorkOrderMilestoneStatus
  End Sub

  Public ReadOnly Property WorkOrderMilestoneStatus As dmWorkOrderMilestoneStatus
    Get
      Return pWorkOrderMilestoneStatus
    End Get
  End Property

  Public Sub SaveObject()
    Dim mdso As dsoProduction
    mdso = New dsoProduction(pDBConn)
    mdso.SaveWorkOrderTracking(pWorkOrderMilestoneStatus)
  End Sub

  Public Sub UpdateWorkOrderStatus()
    Try
      Dim mWhere As String = ""
      If pWorkOrderMilestoneStatus IsNot Nothing Then
        Select Case pWorkOrderMilestoneStatus.MilestoneENUM
          Case eWorkCentre.Installation
            If pWorkOrderMilestoneStatus.Status = eMilestoneStatus.Complete Then

              mWhere = String.Format("Update WorkOrder set Status = {0} where WorkOrderID = {1} ", CInt(eWorkOrderStatus.Complete), pWorkOrderMilestoneStatus.WorkOrderID)

              If pDBConn.Connect Then
                pDBConn.ExecuteNonQuery(mWhere)
              End If
            End If
        End Select
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw

    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub
End Class
