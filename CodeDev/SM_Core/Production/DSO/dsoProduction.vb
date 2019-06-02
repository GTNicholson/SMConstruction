Imports RTIS.CommonVB

Public Class dsoProduction
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function LoadWorkOrderTrackings(ByRef rWorkOrderTrackings As colWorkOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdto As dtoWorkOrderInfo
    ''Dim mWorkOrderInfos As New colWorkOrderTrackings
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderTrackings, vWhere)

      ''For Each mWOI As clsWorkOrderInfo In mWorkOrderInfos
      ''  rWorkOrderTrackings.Add(New clsWorkOrderTracking())
      ''Next

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

End Class
