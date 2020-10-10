﻿Public Class clsSalesOrderPhaseItemInfo
  Private pSalesOrderPhaseItem As dmSalesOrderPhaseItem
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrderItem As dmSalesOrderItem
  Private pCustomer As dmCustomer

  Public Sub New()
    pSalesOrderPhaseItem = New dmSalesOrderPhaseItem
    pSalesOrder = New dmSalesOrder
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrderItem = New dmSalesOrderItem
    pCustomer = New dmCustomer
  End Sub

  Public Property SalesOrderPhaseItem As dmSalesOrderPhaseItem
    Get
      Return pSalesOrderPhaseItem
    End Get
    Set(value As dmSalesOrderPhaseItem)
      pSalesOrderPhaseItem = value
    End Set
  End Property

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
    Set(value As dmSalesOrderItem)
      pSalesOrderItem = value
    End Set
  End Property

  Public Property SalesOrderPhase As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(value As dmSalesOrderPhase)
      pSalesOrderPhase = value
    End Set
  End Property

  Public Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
    Set(value As dmCustomer)
      pCustomer = value
    End Set
  End Property

  Public ReadOnly Property SalesOrderPhaseItemID As Int32
    Get
      Return pSalesOrderPhaseItem.SalesOrderPhaseItemID
    End Get

  End Property

  Public ReadOnly Property Qty As Int32
    Get
      Return pSalesOrderPhaseItem.Qty
    End Get

  End Property


  Public ReadOnly Property SalesOrderID As Integer
    Get
      Return pSalesOrder.SalesOrderID
    End Get
  End Property

  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property


  Public ReadOnly Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
  End Property


  Public ReadOnly Property SalesOrderPhaseID As Integer
    Get
      Return pSalesOrderPhase.SalesOrderPhaseID
    End Get
  End Property

  Public ReadOnly Property DateRequired As Date
    Get
      Return pSalesOrderPhase.DateRequired
    End Get
  End Property



  Public ReadOnly Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property

  Public ReadOnly Property SalesOrderItemID As Int32
    Get
      Return pSalesOrderItem.SalesOrderItemID
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pSalesOrderItem.Description
    End Get
  End Property

End Class


Public Class colSalesOrderPhaseItemInfos : Inherits List(Of clsSalesOrderPhaseItemInfo)

  Public Function IndexFromSOPhaseID(ByVal vSalesOrderPhaseID As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mSOPI As clsSalesOrderPhaseItemInfo In Me
      mIndex += 1
      If mSOPI.SalesOrderPhase.SalesOrderPhaseID = vSalesOrderPhaseID Then
        mRetVal = mIndex
      End If
    Next
    Return mRetVal
  End Function



End Class