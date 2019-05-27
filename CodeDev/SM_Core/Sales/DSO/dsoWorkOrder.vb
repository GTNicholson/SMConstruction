Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoWorkOrder
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub


  Public Function LoadWorkOrderDown(ByRef rWorkOrder As dmWorkOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder

    pDBConn.Connect()
    mdto = New dtoWorkOrder(pDBConn)
    mdto.LoadWorkOrder(rWorkOrder, vID)

    pDBConn.Disconnect()
    mRetVal = True

    Return mRetVal
  End Function


  Public Function LoadWorkOrderDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
    'Dim mRetVal As Boolean
    'Dim mdto As dtoCustomer

    'pDBConn.Connect()
    'mdto = New dtoCustomer(pDBConn)
    'mdto.LoadCustomer(rCustomer, vID)

    'pDBConn.Disconnect()
    'mRetVal = True

    'Return mRetVal
  End Function

  Public Function LoadWorksOrderDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
    'Dim mRetVal As Boolean
    'Dim mdto As dtoCustomer

    'pDBConn.Connect()
    'mdto = New dtoCustomer(pDBConn)
    'mdto.LoadCustomer(rCustomer, vID)

    'pDBConn.Disconnect()
    'mRetVal = True

    'Return mRetVal
  End Function

  Public Function LoadWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrderInfo

    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, "")

      mRetVal = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

End Class
