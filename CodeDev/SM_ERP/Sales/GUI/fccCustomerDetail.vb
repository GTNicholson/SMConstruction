Public Class fccCustomerDetail
  Private pPrimaryKeyID As Integer

  Private pCustomer As dmCustomer
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

  Public ReadOnly Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSales

    pCustomer = New dmCustomer

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSales(pDBConn)
      mdso.LoadCustomerDown(pCustomer, pPrimaryKeyID)
    End If

  End Sub

  Public Sub SaveObjects()
    Dim mdso As dsoSales
    mdso = New dsoSales(pDBConn)
    mdso.SaveCustomerDown(pCustomer)
  End Sub

End Class
