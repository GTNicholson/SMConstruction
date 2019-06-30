''Class Definition - Customer (to Customer)'Generated from Table:Customer
Imports RTIS.CommonVB

Public Class dmCustomer : Inherits dmBase
  Private pCustomerID As Int32
  Private pCompanyName As String
  Private pCustomerStatusID As Int32
  Private pCustomerTypeID As Int32
  Private pSalesAreaID As Int32
  Private pAccountRef As String
  Private pTelNo As String
  Private pFax As String
  Private pEmail As String
  Private pWebURL As String
  Private pSalesCreditPosition As Byte
  Private pSalesCreditLimit As Decimal
  Private pSalesOnStop As Boolean
  Private pDateLastSCreditReview As DateTime
  Private pDateSCreditReviewDue As DateTime
  Private pSalesCreditComment As String
  Private pPaymentTermsType As Byte
  Private pPaymentTermsParam As Int32
  Private pVATRegNo As String
  Private pVATRateCode As Int16
  Private pParentCompanyID As Int32
  Private pInvoiceParentCompany As Boolean
  Private pDateEntered As DateTime
  Private pDefaultNominalCode As String
  Private pMainAddress1 As String
  Private pMainAddress2 As String
  Private pMainTown As String
  Private pMainCounty As String
  Private pMainPostCode As String
  Private pMainCountry As String
  Private pCustomerNotes As String
  Private pSalesEmployeeID As Int32
  Private pRucnumber As String

  Private pCustomerContacts As colCustomerContacts
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pCustomerContacts = New colCustomerContacts
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pCustomerContacts = Nothing
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
    CustomerID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmCustomer)
      .CustomerID = CustomerID
      .CompanyName = CompanyName
      .CustomerStatusID = CustomerStatusID
      .CustomerTypeID = CustomerTypeID
      .SalesAreaID = SalesAreaID
      .AccountRef = AccountRef
      .TelNo = TelNo
      .Fax = Fax
      .Email = Email
      .WebURL = WebURL
      .SalesCreditPosition = SalesCreditPosition
      .SalesCreditLimit = SalesCreditLimit
      .SalesOnStop = SalesOnStop
      .DateLastSCreditReview = DateLastSCreditReview
      .DateSCreditReviewDue = DateSCreditReviewDue
      .SalesCreditComment = SalesCreditComment
      .PaymentTermsType = PaymentTermsType
      .PaymentTermsParam = PaymentTermsParam
      .VATRegNo = VATRegNo
      .VATRateCode = VATRateCode
      .ParentCompanyID = ParentCompanyID
      .InvoiceParentCompany = InvoiceParentCompany
      .DateEntered = DateEntered
      .DefaultNominalCode = DefaultNominalCode
      .MainAddress1 = MainAddress1
      .MainAddress2 = MainAddress2
      .MainTown = MainTown
      .MainCounty = MainCounty
      .MainPostCode = MainPostCode
      .MainCountry = MainCountry
      .CustomerNotes = CustomerNotes
      .SalesEmployeeID = SalesEmployeeID
      .Rucnumber = Rucnumber
      'Add entries here for each collection and class property

      'Entries for object management
      .CustomerContacts = CustomerContacts.Clone

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property CustomerID() As Int32
    Get
      Return pCustomerID
    End Get
    Set(ByVal value As Int32)
      If pCustomerID <> value Then IsDirty = True
      pCustomerID = value
    End Set
  End Property

  Public Property CompanyName() As String
    Get
      Return pCompanyName
    End Get
    Set(ByVal value As String)
      If pCompanyName <> value Then IsDirty = True
      pCompanyName = value
    End Set
  End Property

  Public Property CustomerStatusID() As Int32
    Get
      Return pCustomerStatusID
    End Get
    Set(ByVal value As Int32)
      If pCustomerStatusID <> value Then IsDirty = True
      pCustomerStatusID = value
    End Set
  End Property

  Public Property CustomerTypeID() As Int32
    Get
      Return pCustomerTypeID
    End Get
    Set(ByVal value As Int32)
      If pCustomerTypeID <> value Then IsDirty = True
      pCustomerTypeID = value
    End Set
  End Property

  Public Property SalesAreaID() As Int32
    Get
      Return pSalesAreaID
    End Get
    Set(ByVal value As Int32)
      If pSalesAreaID <> value Then IsDirty = True
      pSalesAreaID = value
    End Set
  End Property

  Public Property AccountRef() As String
    Get
      Return pAccountRef
    End Get
    Set(ByVal value As String)
      If pAccountRef <> value Then IsDirty = True
      pAccountRef = value
    End Set
  End Property

  Public Property TelNo() As String
    Get
      Return pTelNo
    End Get
    Set(ByVal value As String)
      If pTelNo <> value Then IsDirty = True
      pTelNo = value
    End Set
  End Property

  Public Property Fax() As String
    Get
      Return pFax
    End Get
    Set(ByVal value As String)
      If pFax <> value Then IsDirty = True
      pFax = value
    End Set
  End Property

  Public Property Email() As String
    Get
      Return pEmail
    End Get
    Set(ByVal value As String)
      If pEmail <> value Then IsDirty = True
      pEmail = value
    End Set
  End Property

  Public Property WebURL() As String
    Get
      Return pWebURL
    End Get
    Set(ByVal value As String)
      If pWebURL <> value Then IsDirty = True
      pWebURL = value
    End Set
  End Property

  Public Property SalesCreditPosition() As Byte
    Get
      Return pSalesCreditPosition
    End Get
    Set(ByVal value As Byte)
      If pSalesCreditPosition <> value Then IsDirty = True
      pSalesCreditPosition = value
    End Set
  End Property

  Public Property SalesCreditLimit() As Decimal
    Get
      Return pSalesCreditLimit
    End Get
    Set(ByVal value As Decimal)
      If pSalesCreditLimit <> value Then IsDirty = True
      pSalesCreditLimit = value
    End Set
  End Property

  Public Property SalesOnStop() As Boolean
    Get
      Return pSalesOnStop
    End Get
    Set(ByVal value As Boolean)
      If pSalesOnStop <> value Then IsDirty = True
      pSalesOnStop = value
    End Set
  End Property

  Public Property DateLastSCreditReview() As DateTime
    Get
      Return pDateLastSCreditReview
    End Get
    Set(ByVal value As DateTime)
      If pDateLastSCreditReview <> value Then IsDirty = True
      pDateLastSCreditReview = value
    End Set
  End Property

  Public Property DateSCreditReviewDue() As DateTime
    Get
      Return pDateSCreditReviewDue
    End Get
    Set(ByVal value As DateTime)
      If pDateSCreditReviewDue <> value Then IsDirty = True
      pDateSCreditReviewDue = value
    End Set
  End Property

  Public Property SalesCreditComment() As String
    Get
      Return pSalesCreditComment
    End Get
    Set(ByVal value As String)
      If pSalesCreditComment <> value Then IsDirty = True
      pSalesCreditComment = value
    End Set
  End Property

  Public Property PaymentTermsType() As Byte
    Get
      Return pPaymentTermsType
    End Get
    Set(ByVal value As Byte)
      If pPaymentTermsType <> value Then IsDirty = True
      pPaymentTermsType = value
    End Set
  End Property

  Public Property PaymentTermsParam() As Int32
    Get
      Return pPaymentTermsParam
    End Get
    Set(ByVal value As Int32)
      If pPaymentTermsParam <> value Then IsDirty = True
      pPaymentTermsParam = value
    End Set
  End Property

  Public Property VATRegNo() As String
    Get
      Return pVATRegNo
    End Get
    Set(ByVal value As String)
      If pVATRegNo <> value Then IsDirty = True
      pVATRegNo = value
    End Set
  End Property

  Public Property VATRateCode() As Int16
    Get
      Return pVATRateCode
    End Get
    Set(ByVal value As Int16)
      If pVATRateCode <> value Then IsDirty = True
      pVATRateCode = value
    End Set
  End Property

  Public Property ParentCompanyID() As Int32
    Get
      Return pParentCompanyID
    End Get
    Set(ByVal value As Int32)
      If pParentCompanyID <> value Then IsDirty = True
      pParentCompanyID = value
    End Set
  End Property

  Public Property InvoiceParentCompany() As Boolean
    Get
      Return pInvoiceParentCompany
    End Get
    Set(ByVal value As Boolean)
      If pInvoiceParentCompany <> value Then IsDirty = True
      pInvoiceParentCompany = value
    End Set
  End Property

  Public Property DateEntered() As DateTime
    Get
      Return pDateEntered
    End Get
    Set(ByVal value As DateTime)
      If pDateEntered <> value Then IsDirty = True
      pDateEntered = value
    End Set
  End Property

  Public Property DefaultNominalCode() As String
    Get
      Return pDefaultNominalCode
    End Get
    Set(ByVal value As String)
      If pDefaultNominalCode <> value Then IsDirty = True
      pDefaultNominalCode = value
    End Set
  End Property

  Public Property MainAddress1() As String
    Get
      Return pMainAddress1
    End Get
    Set(ByVal value As String)
      If pMainAddress1 <> value Then IsDirty = True
      pMainAddress1 = value
    End Set
  End Property

  Public Property MainAddress2() As String
    Get
      Return pMainAddress2
    End Get
    Set(ByVal value As String)
      If pMainAddress2 <> value Then IsDirty = True
      pMainAddress2 = value
    End Set
  End Property

  Public Property MainTown() As String
    Get
      Return pMainTown
    End Get
    Set(ByVal value As String)
      If pMainTown <> value Then IsDirty = True
      pMainTown = value
    End Set
  End Property

  Public Property MainCounty() As String
    Get
      Return pMainCounty
    End Get
    Set(ByVal value As String)
      If pMainCounty <> value Then IsDirty = True
      pMainCounty = value
    End Set
  End Property

  Public Property MainPostCode() As String
    Get
      Return pMainPostCode
    End Get
    Set(ByVal value As String)
      If pMainPostCode <> value Then IsDirty = True
      pMainPostCode = value
    End Set
  End Property

  Public Property MainCountry() As String
    Get
      Return pMainCountry
    End Get
    Set(ByVal value As String)
      If pMainCountry <> value Then IsDirty = True
      pMainCountry = value
    End Set
  End Property

  Public Property CustomerNotes() As String
    Get
      Return pCustomerNotes
    End Get
    Set(ByVal value As String)
      If pCustomerNotes <> value Then IsDirty = True
      pCustomerNotes = value
    End Set
  End Property

  Public Property SalesEmployeeID() As Int32
    Get
      Return pSalesEmployeeID
    End Get
    Set(ByVal value As Int32)
      If pSalesEmployeeID <> value Then IsDirty = True
      pSalesEmployeeID = value
    End Set
  End Property

  Public Property Rucnumber() As String
    Get
      Return pRucnumber
    End Get
    Set(ByVal value As String)
      If pRucnumber <> value Then IsDirty = True
      pRucnumber = value
    End Set
  End Property

  Public Property CustomerContacts As colCustomerContacts
    Get
      Return pCustomerContacts
    End Get
    Set(value As colCustomerContacts)
      pCustomerContacts = value
    End Set
  End Property

End Class



''Collection Definition - Customer (to Customer)'Generated from Table:Customer

'Private pCustomers As colCustomers
'Public Property Customers() As colCustomers
'  Get
'    Return pCustomers
'  End Get
'  Set(ByVal value As colCustomers)
'    pCustomers = value
'  End Set
'End Property

'  pCustomers = New colCustomers 'Add to New
'  pCustomers = Nothing 'Add to Finalize
'  .Customers = Customers.Clone 'Add to CloneTo
'  Customers.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Customers.IsDirty 'Add to IsAnyDirty

Public Class colCustomers : Inherits colBase(Of dmCustomer)

  Public Overrides Function IndexFromKey(ByVal vCustomerID As Integer) As Integer
    Dim mItem As dmCustomer
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.CustomerID = vCustomerID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmCustomer))
    MyBase.New(vList)
  End Sub

End Class





