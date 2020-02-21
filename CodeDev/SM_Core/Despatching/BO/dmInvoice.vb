''Class Definition - Invoice (to Invoice)'Generated from Table:Invoice
Imports RTIS.CommonVB

Public Class dmInvoice : Inherits dmBase
  Private pInvoiceID As Int32
  Private pSalesOrderID As Int32
  Private pInvoiceDate As DateTime
  Private pCreatedDate As DateTime
  Private pNetValue As Decimal
  Private pTaxValue As Decimal
  Private pInvoiceStatus As Int16
  Private pCustomerPurchaseOrder As String

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    InvoiceID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmInvoice)
      .InvoiceID = InvoiceID
      .SalesOrderID = SalesOrderID
      .InvoiceDate = InvoiceDate
      .CreatedDate = CreatedDate
      .NetValue = NetValue
      .TaxValue = TaxValue
      .InvoiceStatus = InvoiceStatus
      .CustomerPurchaseOrder = CustomerPurchaseOrder
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property InvoiceID() As Int32
    Get
      Return pInvoiceID
    End Get
    Set(ByVal value As Int32)
      If pInvoiceID <> value Then IsDirty = True
      pInvoiceID = value
    End Set
  End Property

  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
    End Set
  End Property

  Public Property InvoiceDate() As DateTime
    Get
      Return pInvoiceDate
    End Get
    Set(ByVal value As DateTime)
      If pInvoiceDate <> value Then IsDirty = True
      pInvoiceDate = value
    End Set
  End Property

  Public Property CreatedDate() As DateTime
    Get
      Return pCreatedDate
    End Get
    Set(ByVal value As DateTime)
      If pCreatedDate <> value Then IsDirty = True
      pCreatedDate = value
    End Set
  End Property

  Public Property NetValue() As Decimal
    Get
      Return pNetValue
    End Get
    Set(ByVal value As Decimal)
      If pNetValue <> value Then IsDirty = True
      pNetValue = value
    End Set
  End Property

  Public Property TaxValue() As Decimal
    Get
      Return pTaxValue
    End Get
    Set(ByVal value As Decimal)
      If pTaxValue <> value Then IsDirty = True
      pTaxValue = value
    End Set
  End Property

  Public Property InvoiceStatus() As Int16
    Get
      Return pInvoiceStatus
    End Get
    Set(ByVal value As Int16)
      If pInvoiceStatus <> value Then IsDirty = True
      pInvoiceStatus = value
    End Set
  End Property

  Public Property CustomerPurchaseOrder() As String
    Get
      Return pCustomerPurchaseOrder
    End Get
    Set(ByVal value As String)
      If pCustomerPurchaseOrder <> value Then IsDirty = True
      pCustomerPurchaseOrder = value
    End Set
  End Property


End Class



''Collection Definition - Invoice (to Invoice)'Generated from Table:Invoice

'Private pInvoices As colInvoices
'Public Property Invoices() As colInvoices
'  Get
'    Return pInvoices
'  End Get
'  Set(ByVal value As colInvoices)
'    pInvoices = value
'  End Set
'End Property

'  pInvoices = New colInvoices 'Add to New
'  pInvoices = Nothing 'Add to Finalize
'  .Invoices = Invoices.Clone 'Add to CloneTo
'  Invoices.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Invoices.IsDirty 'Add to IsAnyDirty

Public Class colInvoices : Inherits colBase(Of dmInvoice)

  Public Overrides Function IndexFromKey(ByVal vInvoiceID As Integer) As Integer
    Dim mItem As dmInvoice
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.InvoiceID = vInvoiceID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmInvoice))
    MyBase.New(vList)
  End Sub

End Class




