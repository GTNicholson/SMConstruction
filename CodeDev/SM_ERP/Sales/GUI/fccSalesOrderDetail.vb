Imports RTIS.CommonVB

Public Class fccSalesOrderDetail
  Private pPrimaryKeyID As Integer

  Private pSalesOrder As dmSalesOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Private pSalesOrderHandler As clsSalesOrderHandler

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSales


    If pPrimaryKeyID = 0 Then
      pSalesOrder = New dmSalesOrder
    Else
      pSalesOrder = New dmSalesOrder
      mdso = New dsoSales(pDBConn)
      mdso.LoadSalesOrderAndCustomer(pSalesOrder, pPrimaryKeyID)
    End If
    pSalesOrderHandler = New clsSalesOrderHandler(pSalesOrder)
  End Sub

  Public Sub SaveObjects()
    Try
      Dim mdso As dsoSales
      mdso = New dsoSales(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Function GetCustomerList() As colCustomers
    Dim mRetVal As New colCustomers
    Dim mdso As dsoSales
    Try
      mdso = New dsoSales(pDBConn)
      mdso.LoadCustomers(mRetVal)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub AddWorkOrder(ByVal vProductType As eProductType)
    Try
      pSalesOrderHandler.AddWorkOrder(vProductType)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub DeleteWorkOrder(ByRef rWorkOrder As dmWorkOrder)
    Try
      pSalesOrderHandler.RemoveWorkOrder(rWorkOrder)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

End Class
