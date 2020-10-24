Imports System.ComponentModel

Public Class clsSalesItemEditor

  Private pSalesOrder As dmSalesOrder
  Private pSalesItemAssembly As dmSalesItemAssembly
  Private pSalesOrderItem As dmSalesOrderItem
  Private pProduct As dmProductBase

  Public Sub New(ByRef rSalesOrder As dmSalesOrder, ByRef rCurrentSalesItemAssembly As dmSalesItemAssembly, ByRef rSalesOrderItem As dmSalesOrderItem, ByRef rProductBase As dmProductBase)
    pSalesOrder = rSalesOrder
    pSalesItemAssembly = rCurrentSalesItemAssembly
    pSalesOrderItem = rSalesOrderItem
    pProduct = rProductBase
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


  Public ReadOnly Property AssemblyDescription As String
    Get
      Dim mRetVal As String = ""
      If pSalesItemAssembly IsNot Nothing Then
        mRetVal = pSalesItemAssembly.Description
      End If
      Return mRetVal
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

  Public Property SalesOrderID As Int32
    Get
      Return pSalesOrderItem.SalesOrderID
    End Get
    Set(value As Int32)
      pSalesOrderItem.SalesOrderID = value
    End Set
  End Property

  Public Property ProductID As Int32
    Get
      Return pSalesOrderItem.ProductID
    End Get
    Set(value As Int32)
      pSalesOrderItem.ProductID = value
    End Set
  End Property

  Public Property HouseTypeID As Int32
    Get
      Return pSalesOrderItem.HouseTypeID
    End Get
    Set(value As Int32)
      pSalesOrderItem.HouseTypeID = value
    End Set
  End Property

  Public Property SalesItemType As Int32
    Get
      Return pSalesOrderItem.SalesItemType
    End Get
    Set(value As Int32)
      pSalesOrderItem.SalesItemType = value
    End Set
  End Property
  Public Property SalesSubItemType As Int32
    Get
      Return pSalesOrderItem.SalesSubItemType
    End Get
    Set(value As Int32)
      pSalesOrderItem.SalesSubItemType = value
    End Set
  End Property

  Public Property Quantity As Decimal
    Get
      Return pSalesOrderItem.Quantity
    End Get
    Set(value As Decimal)
      pSalesOrderItem.Quantity = value
    End Set
  End Property

  Public Property ItemNumber As String
    Get
      Return pSalesOrderItem.ItemNumber
    End Get
    Set(value As String)
      pSalesOrderItem.ItemNumber = value
    End Set
  End Property

  Public ReadOnly Property ProductTypeDesc As String
    Get
      Dim mRetVal As String
      mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eProductType), CType(pProduct.ProductTypeID, eProductType))
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property ProductCode As String
    Get
      Return pProduct.Code
    End Get
  End Property

End Class

Public Class colSalesItemEditors : Inherits BindingList(Of clsSalesItemEditor)




End Class