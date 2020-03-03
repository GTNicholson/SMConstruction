Public Class clsInvoiceInfo
  Private pInvoice As dmInvoice
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer

  Private pInvoicePredictedType As eInvoicePredictedType

  Public Enum eInvoicePredictedType
    Invoice = 1
    Packed = 2
    Engineered = 3
    Pending = 4
  End Enum

  Public Sub New()
    pInvoice = New dmInvoice
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
  End Sub

  Public Property Invoice As dmInvoice
    Get
      Return pInvoice
    End Get
    Set(value As dmInvoice)
      pInvoice = value
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

  Public Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
    Set(value As dmCustomer)
      pCustomer = value
    End Set
  End Property

  Public Property InvoicePredictedType As Integer
    Get
      Return pInvoicePredictedType
    End Get
    Set(value As Integer)
      pInvoicePredictedType = value
    End Set
  End Property

  Public ReadOnly Property InvoiceID As Integer
    Get
      Return pInvoice.InvoiceID
    End Get
  End Property

  Public ReadOnly Property InvoiceNo As String
    Get
      Return pInvoice.InvoiceNo
    End Get
  End Property

  Public ReadOnly Property InvoiceDate As DateTime
    Get
      Return pInvoice.InvoiceDate
    End Get
  End Property

  Public ReadOnly Property InvoiceDateMC As DateTime
    Get
      Return New Date(Year(pInvoice.InvoiceDate), Month(pInvoice.InvoiceDate), 1)
    End Get
  End Property

  Public ReadOnly Property NetValue As Decimal
    Get
      Return pInvoice.NetValue
    End Get
  End Property

  Public ReadOnly Property InvoiceStatus As Short
    Get
      Return pInvoice.InvoiceStatus
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

  Public ReadOnly Property FinishDate As DateTime
    Get
      Return pSalesOrder.FinishDate
    End Get
  End Property

  Public ReadOnly Property FinishDateMC As DateTime
    Get
      Return New Date(Year(pSalesOrder.FinishDate), Month(pSalesOrder.FinishDate), 1)
    End Get
  End Property

  Public ReadOnly Property DueTime As DateTime
    Get
      Return pSalesOrder.DueTime
    End Get
  End Property

  Public ReadOnly Property DueTimeMC As DateTime
    Get
      Return New Date(Year(pSalesOrder.DueTime), Month(pSalesOrder.DueTime), 1)
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
  End Property

End Class

Public Class colInvoiceInfos : Inherits List(Of clsInvoiceInfo)

End Class