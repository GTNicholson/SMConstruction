Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccShiftDetails
  Private pShiftDetails As colShiftDetailss
  Private pDBConn As clsDBConnBase

  Public Property ShiftDetails As colShiftDetailss
    Get
      Return pShiftDetails
    End Get
    Set(value As colShiftDetailss)
      pShiftDetails = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Sub New(ByRef rDBConnBase As clsDBConnBase)
    pShiftDetails = New colShiftDetailss
    pDBConn = rDBConnBase
  End Sub

  Public Sub LoadObject()
    Dim mdso As New dsoProduction(pDBConn)
    Try
      pShiftDetails = New colShiftDetailss
      pDBConn.Connect()

      mdso.LoadShifDetails(pShiftDetails, 1)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub

  Public Sub SaveObjects()
    Dim mdso As New dsoProduction(pDBConn)
    Try

      pDBConn.Connect()

      mdso.SaveShiftDetails(pShiftDetails)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub
End Class
