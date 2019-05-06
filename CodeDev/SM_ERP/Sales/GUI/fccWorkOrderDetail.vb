Public Class fccWorkOrderDetail
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
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

  Public ReadOnly Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoWorkOrder

    pWorkOrder = New dmWorkOrder

    mdso = New dsoWorkOrder(pDBConn)
    mdso.LoadWorkOrderDown(pWorkOrder, pPrimaryKeyID)
  End Sub

  Public Sub SaveObjects()

  End Sub

End Class
