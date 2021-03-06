﻿Imports RTIS.CommonVB

Public Class clsPODeliveryInfo
  Private pPODelivery As dmPODelivery
  Private pPurchaseOrder As dmPurchaseOrder
  Private pSupplier As dmSupplier

  Public Sub New()
    pPODelivery = New dmPODelivery
    pPurchaseOrder = New dmPurchaseOrder
    pSupplier = New dmSupplier
  End Sub

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

  Public Property Supplier As dmSupplier
    Get
      Return pSupplier
    End Get
    Set(value As dmSupplier)
      pSupplier = value
    End Set
  End Property


  Public ReadOnly Property PODeliveryID As Integer
    Get
      Return pPODelivery.PODeliveryID
    End Get
  End Property


  Public ReadOnly Property PODeliveryValue As Decimal
    Get
      Return pPODelivery.PODeliveryValue
    End Get
  End Property

  Public ReadOnly Property GRNumber As String
    Get
      Return pPODelivery.GRNumber
    End Get
  End Property

  Public ReadOnly Property ReceivedDate As Date
    Get
      Return pPODelivery.ReceivedDate
    End Get
  End Property

  Public ReadOnly Property Comment As String
    Get
      Return pPODelivery.Comment
    End Get
  End Property

  Public ReadOnly Property PaymentStatus As Int32
    Get
      Return pPODelivery.PaymentStatus
    End Get
  End Property

  Public ReadOnly Property Status As Int32
    Get
      Return pPODelivery.Status
    End Get
  End Property

  Public ReadOnly Property PaymentStatusDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePaymentStatus), CType(pPODelivery.PaymentStatus, ePaymentStatus))
    End Get

  End Property
  Public ReadOnly Property PODeliveryStatusDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePODelivery), CType(pPODelivery.Status, ePODelivery))
    End Get

  End Property
  Public ReadOnly Property DateCreated As DateTime
    Get
      Return pPODelivery.DateCreated
    End Get
  End Property


  Public ReadOnly Property FileExport As String
    Get
      Return pPODelivery.FileExport
    End Get
  End Property

  Public ReadOnly Property DateCreatedMC As DateTime
    Get
      Return New Date(Year(pPODelivery.DateCreated), Month(pPODelivery.DateCreated), 1)
    End Get
  End Property

  Public ReadOnly Property PurchaseCategory As Byte
    Get
      Return pPurchaseOrder.PurchaseCategory
    End Get
  End Property

  Public ReadOnly Property PONum As String
    Get
      Return pPurchaseOrder.PONum
    End Get
  End Property

  Public ReadOnly Property RequiredDate As Date
    Get
      Return pPurchaseOrder.RequiredDate
    End Get
  End Property

  Public ReadOnly Property RequiredDateMC As DateTime
    Get
      Return New Date(Year(pPurchaseOrder.RequiredDate), Month(pPurchaseOrder.RequiredDate), 1)
    End Get
  End Property

  Public ReadOnly Property DeliveryAddress1 As String
    Get
      Return pPurchaseOrder.DeliveryAddress.FullAddress
    End Get
  End Property

  Public ReadOnly Property Comments As String
    Get
      Return pPurchaseOrder.Comments
    End Get
  End Property

  Public ReadOnly Property SupplierID As Integer
    Get
      Return pSupplier.SupplierID
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pSupplier.CompanyName
    End Get
  End Property

  Public ReadOnly Property AccountCode As String
    Get
      Return pSupplier.AccountCode
    End Get
  End Property

  Public ReadOnly Property TelNo As String
    Get
      Return pSupplier.TelNo
    End Get
  End Property

  Public ReadOnly Property MainAddress1 As String
    Get
      Return pSupplier.MainAddress1
    End Get
  End Property

  Public ReadOnly Property ExchangeRateValue As Decimal
    Get
      Return pPurchaseOrder.ExchangeRateValue
    End Get
  End Property


  Public ReadOnly Property DefaultCurrency As Integer
    Get
      Return pPurchaseOrder.DefaultCurrency
    End Get
  End Property

  Public ReadOnly Property TotalNetValue As Decimal
    Get

      Return pPurchaseOrder.TotalNetValue
    End Get
  End Property

  Public ReadOnly Property AccoutingCategoryID As Integer
    Get
      Return pPurchaseOrder.AccoutingCategoryID
    End Get
  End Property

  Public ReadOnly Property POStage As Integer
    Get
      Return pPurchaseOrder.POStage
    End Get
  End Property

  Public ReadOnly Property TotalReceivedAmountCordoba As Decimal
    Get
      Dim mRetVal As Decimal = 0

      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = pPurchaseOrder.TotalNetValue

        Case eCurrency.Dollar
          If pPurchaseOrder.ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrder.TotalNetValue) * ExchangeRateValue

          End If

      End Select

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property TotalReceivedAmountUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = pPurchaseOrder.TotalNetValue

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrder.TotalNetValue) / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property
End Class

Public Class colPODeliveryInfos : Inherits List(Of clsPODeliveryInfo)

End Class

