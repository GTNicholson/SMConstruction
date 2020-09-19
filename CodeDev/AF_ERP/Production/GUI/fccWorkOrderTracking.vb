Imports RTIS.CommonVB

Public Class fccWorkOrderTracking
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderTrackings As colWorkOrderInfos
  Private pHideDespatched As Boolean

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn

  End Sub

  Public ReadOnly Property WorkOrderTrackings As colWorkOrderInfos
    Get
      Return pWorkOrderTrackings
    End Get
  End Property

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public Property HideDespatched As Boolean
    Get
      Return pHideDespatched
    End Get
    Set(value As Boolean)
      pHideDespatched = value
    End Set
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoProduction
    Dim mwhere As String
    Try
      If pHideDespatched Then
        mwhere = "WorkOrderID Not In (select Distinct WorkOrderID from WorkOrderMilestoneStatus Where MilestoneENUM = 10 and Status = 3)"
        mwhere += " and (WorkOrderID in (select WorkOrderID from vwWorkOrderInfo) or WorkOrderId in (select WorkOrderID from vwWorkOrderInternalInfo))"
      Else
        mwhere = ""
      End If

      mdso = New dsoProduction(pDBConn)
      pWorkOrderTrackings = New colWorkOrderInfos
      mdso.LoadWorkOrderTrackings(pWorkOrderTrackings, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub
End Class
