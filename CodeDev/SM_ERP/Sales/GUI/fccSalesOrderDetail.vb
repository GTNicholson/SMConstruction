Public Class fccSalesOrderDetail
  Private pPrimaryKeyID As Integer

  Private pSalesOrder As dmSalesOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
  End Sub

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

    pSalesOrder = New dmSalesOrder

    mdso = New dsoSales(pDBConn)
    mdso.LoadSalesOrderDown(pSalesOrder, pPrimaryKeyID)
  End Sub

  Public Sub SaveObjects()

  End Sub

End Class
