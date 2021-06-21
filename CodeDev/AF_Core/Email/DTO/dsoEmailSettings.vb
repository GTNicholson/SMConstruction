Imports RTIS.DataLayer
Imports RTIS.CommonVB

Public Class dsoEmailSettings

  Private pDBConn As clsDBConnBase

  Public Property DBConn() As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(ByVal value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function LoadEmailSettings(ByVal rEmailSettings As RTIS.EmailLib.clsEmailSettings, ByVal vID As Integer) As Boolean
    Dim mdto As dtoEmailSettings
    Try
      mdto = New dtoEmailSettings(pDBConn)
      pDBConn.Connect()
      mdto.LoadEmailSettings(rEmailSettings, vID)
      pDBConn.Disconnect()
    Catch Ex As Exception
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
    End Try

  End Function


End Class
