Imports System.ComponentModel

Public Class clsSalesItemEditor

  Private pSalesOrder As dmSalesOrder
  Private pSalesItemAssembly As dmSalesItemAssembly
  Private pSalesOrderItem As dmSalesOrderItem
  Private Shared sProductConstructionTypes As RTIS.CommonVB.colValueItems

  Public Sub New(ByRef rSalesOrder As dmSalesOrder, ByRef rSalesOrderItem As dmSalesOrderItem)
    pSalesOrder = rSalesOrder

    pSalesOrderItem = rSalesOrderItem

  End Sub

  Public Sub New()
    pSalesOrder = New dmSalesOrder
    pSalesItemAssembly = New dmSalesItemAssembly
    pSalesOrderItem = New dmSalesOrderItem

    If sProductConstructionTypes Is Nothing Then
      sProductConstructionTypes = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ProductConstructionType)
    End If


  End Sub



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
      Return pSalesOrderItem.SalesHouseID
    End Get
    Set(value As Int32)
      pSalesOrderItem.SalesHouseID = value
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

  Public Property ManpowerCost As Decimal
    Get
      Return pSalesOrderItem.ManpowerCost
    End Get
    Set(value As Decimal)
      pSalesOrderItem.ManpowerCost = value
    End Set
  End Property
  Public Property MaterialCost As Decimal
    Get
      Dim mRetVal As Decimal

      If WoodCost = 0 And StockItemCost = 0 Then
        mRetVal = pSalesOrderItem.MaterialCost ''return the previous value

      ElseIf pSalesOrderItem.MaterialCost = 0 Then
        mRetVal = WoodCost + StockItemCost ''return the estimated material cost
      Else
        mRetVal = pSalesOrderItem.MaterialCost
      End If

      Return mRetVal
    End Get
    Set(value As Decimal)
      pSalesOrderItem.MaterialCost = value
    End Set
  End Property

  Public Property TransportationCost As Decimal
    Get
      Return pSalesOrderItem.TransportationCost
    End Get
    Set(value As Decimal)
      pSalesOrderItem.TransportationCost = value
    End Set
  End Property

  Public Property SubContractCost As Decimal
    Get
      Return pSalesOrderItem.SubContractCost
    End Get
    Set(value As Decimal)
      pSalesOrderItem.SubContractCost = value
    End Set
  End Property

  Public Property Comments As String
    Get
      Return pSalesOrderItem.Comments
    End Get
    Set(value As String)
      pSalesOrderItem.Comments = value
    End Set
  End Property

  Public Property ImageFile As String
    Get
      Return pSalesOrderItem.ImageFile
    End Get
    Set(value As String)
      pSalesOrderItem.ImageFile = value
    End Set
  End Property


  Public Property UnitPrice As Decimal
    Get
      Return pSalesOrderItem.UnitPrice
    End Get
    Set(value As Decimal)
      pSalesOrderItem.UnitPrice = value
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

  Public ReadOnly Property UoMDesc As String
    Get
      Return RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(UoM, eUoM))
    End Get
  End Property

  Public Property UoM As Integer
    Get
      Return pSalesOrderItem.UoM
    End Get
    Set(value As Integer)
      pSalesOrderItem.UoM = value
    End Set
  End Property

  Public ReadOnly Property SalesItemTypeSequence As Integer
    Get
      Dim mProductTypes As New colProductConstructionTypes
      Dim mRetVal As Integer
      Dim mProductType As dmProductConstructionType

      mProductTypes = CType(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.ProductConstructionType), colProductConstructionTypes)

      mProductType = mProductTypes.ItemFromKey(pSalesOrderItem.SalesItemType)

      If mProductType IsNot Nothing Then
        mRetVal = mProductType.SequenceNo
      Else
        mRetVal = -1
      End If

      Return mRetVal
    End Get
  End Property
  Public ReadOnly Property TotalAmount() As Decimal
    Get
      Return UnitPrice * Quantity
    End Get
  End Property
  Public Property WoodCost As Decimal
    Get
      Return pSalesOrderItem.WoodCost
    End Get
    Set(value As Decimal)
      pSalesOrderItem.WoodCost = value
    End Set
  End Property


  Public Property StockItemCost As Decimal
    Get
      Return pSalesOrderItem.StockItemCost
    End Get
    Set(value As Decimal)
      pSalesOrderItem.StockItemCost = value
    End Set
  End Property


End Class

Public Class colSalesItemEditors : Inherits BindingList(Of clsSalesItemEditor)




End Class