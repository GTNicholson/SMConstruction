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
      mwhere = String.Format("ProductTypeID = {0} and OrderTypeID in ({1},{2}) and OrderStatusENUM not in  ({3},{4}) and Status <> {5}", CInt(eProductType.StructureAF),
                             CInt(eOrderType.Sales), CInt(eOrderType.Interno), CInt(eSalesOrderstatus.Cancelada), CInt(eSalesOrderstatus.Completed), CInt(eWorkOrderStatus.Cancelled))
      If pHideDespatched Then
        mwhere &= ""
      Else
        mwhere &= ""
      End If

      mdso = New dsoProduction(pDBConn)
      pWorkOrderTrackings = New colWorkOrderInfos
      mdso.LoadWorkOrderTrackings(pWorkOrderTrackings, mwhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function GetCurrentInsumosDisplayText(ByVal vWorkOrderID As Integer) As String

  End Function
End Class
