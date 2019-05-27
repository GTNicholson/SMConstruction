Imports RTIS.DataLayer
Public Class dsoGeneral
  Private pDBConn As clsDBConnBase
  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function GetNextTallyWorkOrderNo() As Integer
    Dim mRetVal As Integer
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(eTallyIDs.WorkOrder)
    Catch ex As Exception
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

End Class
