Imports System.ComponentModel

Public Class clsSalesItemEditor

  Private pSalesOrder As dmSalesOrder
  Private pSalesItemAssembly As dmSalesItemAssembly
  Private pSalesOrderItem As dmSalesOrderItem

  Public Sub New(ByRef rSalesOrder As dmSalesOrder, ByRef rCurrentSalesItemAssembly As dmSalesItemAssembly, ByRef rSalesOrderItem As dmSalesOrderItem)
    pSalesOrder = rSalesOrder
    pSalesItemAssembly = rCurrentSalesItemAssembly
    pSalesOrderItem = rSalesOrderItem

  End Sub

  Public Sub New()
    pSalesOrder = New dmSalesOrder
    pSalesItemAssembly = New dmSalesItemAssembly
    pSalesOrderItem = New dmSalesOrderItem
  End Sub

  Public ReadOnly Property SalesItemAssembly As dmSalesItemAssembly
    Get
      Return pSalesItemAssembly
    End Get
  End Property

  Public ReadOnly Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
  End Property


  Public Property Description As String
    Get
      Return pSalesOrderItem.Description
    End Get
    Set(value As String)
      pSalesOrderItem.Description = value
    End Set
  End Property

End Class

Public Class colSalesItemEditors : Inherits BindingList(Of clsSalesItemEditor)




End Class