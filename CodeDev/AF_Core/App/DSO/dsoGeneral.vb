Imports RTIS.CommonVB
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
  Public Function getNextTally(ByVal vTallyNumber As Integer) As Integer
    Dim mRetVal As Int32 = 0

    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(vTallyNumber)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetNextTallyPONo() As Integer
    Dim mRetVal As Integer
    Try
      pDBConn.Connect()
      mRetVal = pDBConn.NextTally(eTallyIDs.PurchaseOrderNo)
    Catch ex As Exception
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function
  Public Function LoadHostCompanys(ByRef rHostCompanys As colHostCompanys) As Boolean
    Dim mdto As dtoHostCompany
    Dim mOK As Boolean
    Try

      mdto = New dtoHostCompany(pDBConn)

      mOK = mdto.LoadHostCompanyCollection(rHostCompanys)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

End Class
