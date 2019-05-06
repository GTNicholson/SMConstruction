Imports RTIS.DataLayer

Public Class dsoSales
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub


  Public Function LoadCustomerDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer

    pDBConn.Connect()
    mdto = New dtoCustomer(pDBConn)
    mdto.LoadCustomer(rCustomer, vID)

    pDBConn.Disconnect()
    mRetVal = True

    Return mRetVal
  End Function

  Public Function SaveCustomerDown(ByRef rCustomer As dmCustomer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer

    pDBConn.Connect()
    mdto = New dtoCustomer(pDBConn)
    mdto.SaveCustomer(rCustomer)

    pDBConn.Disconnect()
    mRetVal = True

    Return mRetVal
  End Function

  Public Function LoadSalesOrderDown(ByRef rSalesOrder As dmSalesOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder

    pDBConn.Connect()
    mdto = New dtoSalesOrder(pDBConn)
    mdto.LoadSalesOrder(rSalesOrder, vID)

    pDBConn.Disconnect()
    mRetVal = True

    Return mRetVal
  End Function
  Public Function LoadSalesOrderDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
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

End Class
