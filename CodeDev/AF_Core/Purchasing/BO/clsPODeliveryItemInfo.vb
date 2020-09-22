﻿Imports RTIS.CommonVB

Public Class clsPODeliveryItemInfo
  Private pPODeliveryItem As dmPODeliveryItem
  Private pPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation
  Private pPODelivery As dmPODelivery
  Private pPurchaseOrder As dmPurchaseOrder
  Private pPurchaseOrderItem As dmPurchaseOrderItem
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrder As dmSalesOrder

  Public Sub New()
    pPODeliveryItem = New dmPODeliveryItem
    pPurchaseOrderItemAllocation = New dmPurchaseOrderItemAllocation
    pPODelivery = New dmPODelivery
    pPurchaseOrder = New dmPurchaseOrder
    pPurchaseOrderItem = New dmPurchaseOrderItem
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrder = New dmSalesOrder
  End Sub

  Public Property PODeliveryItem As dmPODeliveryItem
    Get
      Return pPODeliveryItem
    End Get
    Set(value As dmPODeliveryItem)
      pPODeliveryItem = value
    End Set
  End Property

  Public Property PurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation
    Get
      Return pPurchaseOrderItemAllocation
    End Get
    Set(value As dmPurchaseOrderItemAllocation)
      pPurchaseOrderItemAllocation = value
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

  Public Property PODelivery As dmPODelivery
    Get
      Return pPODelivery
    End Get
    Set(value As dmPODelivery)
      pPODelivery = value
    End Set
  End Property
  Public Property PurchaseOrder As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property

  Public Property PurchaseOrderItem As dmPurchaseOrderItem
    Get
      Return pPurchaseOrderItem
    End Get
    Set(value As dmPurchaseOrderItem)
      pPurchaseOrderItem = value
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
  Public ReadOnly Property PODeliveryItemID As Integer
    Get
      Return pPODeliveryItem.PODeliveryItemID
    End Get

  End Property

  Public ReadOnly Property QtyReceived As Decimal
    Get
      Return pPODeliveryItem.QtyReceived
    End Get

  End Property
  Public ReadOnly Property Description As String
    Get
      Return pPurchaseOrderItem.Description
    End Get

  End Property

  Public ReadOnly Property PartNo As String
    Get
      Return pPurchaseOrderItem.PartNo
    End Get

  End Property

  Public ReadOnly Property StockCode As String
    Get
      Return pPurchaseOrderItem.StockCode
    End Get

  End Property

  Public ReadOnly Property QtyRequired As Decimal
    Get
      Return pPurchaseOrderItem.QtyRequired
    End Get

  End Property

  Public ReadOnly Property UnitPrice As Decimal
    Get


      Return pPurchaseOrderItem.UnitPrice
    End Get

  End Property

  Public ReadOnly Property UnitPriceCordoba As Decimal
    Get
      Dim mRetVal As Decimal = 0


      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = pPurchaseOrderItem.UnitPrice * ExchangeRateValue

        Case eCurrency.Cordobas
          mRetVal = pPurchaseOrderItem.UnitPrice

      End Select

      Return mRetVal

    End Get

  End Property

  Public ReadOnly Property TotalReceivedAmount As Decimal
    Get
      Return pPurchaseOrderItem.UnitPrice * pPODeliveryItem.QtyReceived
    End Get
  End Property

  Public ReadOnly Property TotalReceivedAmountUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalReceivedAmount

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrderItem.UnitPrice * pPODeliveryItem.QtyReceived) / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property


  Public ReadOnly Property DateCreated As Date
    Get
      Return pPODelivery.DateCreated
    End Get

  End Property

  Public ReadOnly Property DateCreatedWC As Date
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pPODelivery.DateCreated)
    End Get
  End Property

  Public ReadOnly Property DateCreatedMC As Date
    Get
      Return New Date(Year(pPODelivery.DateCreated), Month(pPODelivery.DateCreated), 1)
    End Get
  End Property

  Public ReadOnly Property GRNumber As String
    Get
      Return pPODelivery.GRNumber
    End Get

  End Property

  Public ReadOnly Property JobNo As String
    Get
      Return pSalesOrderPhase.JobNo
    End Get

  End Property



  Public ReadOnly Property RefMatType As String
    Get
      Return pPurchaseOrder.RefMatType
    End Get

  End Property

  Public ReadOnly Property PaymentStatus As Integer
    Get
      Return pPurchaseOrder.PaymentStatus
    End Get

  End Property

  Public ReadOnly Property PaymentStatusDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePaymentStatus), CType(pPODelivery.PaymentStatus, ePaymentStatus))
    End Get

  End Property

  Public ReadOnly Property Category As Byte
    Get
      Return pPurchaseOrder.Category
    End Get

  End Property

  Public ReadOnly Property DefaultCurrency As Integer
    Get
      Return pPurchaseOrder.DefaultCurrency
    End Get

  End Property


  Public ReadOnly Property CurrencyDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eCurrency), CType(pPurchaseOrder.DefaultCurrency, eCurrency))
    End Get

  End Property

  Public ReadOnly Property ExchangeRateValue As Decimal
    Get
      Return pPurchaseOrder.ExchangeRateValue
    End Get

  End Property

  Public ReadOnly Property TotalReceivedAmountCordoba As Decimal
    Get
      Dim mRetVal As Decimal = 0

      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = pPurchaseOrderItem.UnitPrice * pPODeliveryItem.QtyReceived

        Case eCurrency.Dollar
          If pPurchaseOrder.ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrderItem.UnitPrice * pPODeliveryItem.QtyReceived) * ExchangeRateValue

          End If

      End Select

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property CategoryDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(pPurchaseOrder.Category, ePurchaseCategories))
    End Get

  End Property

  Public ReadOnly Property PONum As String
    Get
      Return pPurchaseOrder.PONum
    End Get

  End Property

  Public ReadOnly Property ProjectName As String
    Get
      Dim mRetVal As String = pSalesOrder.ProjectName

      If pSalesOrder.ProjectName = "" Then
        mRetVal = "S/P-Inventario"
      End If

      Return mRetVal
    End Get

  End Property



End Class

Public Class colPODeliveryItemInfos : Inherits List(Of clsPODeliveryItemInfo)

End Class

