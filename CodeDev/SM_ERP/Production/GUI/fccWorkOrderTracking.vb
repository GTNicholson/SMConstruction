Imports RTIS.CommonVB

Public Class fccWorkOrderTracking
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrderTrackings As colWorkOrderInfos

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



  Public Sub LoadObjects()
    Dim mdso As dsoProduction
    Try
      mdso = New dsoProduction(pDBConn)
      pWorkOrderTrackings = New colWorkOrderInfos
      mdso.LoadWorkOrderTrackings(pWorkOrderTrackings, "")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub
End Class
