''Class Definition - Supplier (to Supplier)'Generated from Table:Supplier
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dmSupplier : Inherits dmBase
  Implements iValueItem

  Private pSupplierID As Int32
  Private pCompanyName As String
  Private pSupplierStatusID As Int32
  Private pSupplierTypeID As Int32
  Private pParentSupplierID As Int32
  Private pAccountCode As String
  Private pTelNo As String
  Private pFax As String
  Private pEmail As String
  Private pWebURL As String
  Private pSalesAreaID As Int32
  Private pPaymentTermsType As Byte
  Private pPaymentTermsParam As Int32
  Private pVATRefNo As String
  Private pNotes As String
  Private pDateEntered As DateTime
  Private pDateAmended As DateTime
  Private pEnteredByUserID As Int32
  Private pAmendedByUserID As Int32
  Private pDefaultAddressID As Int32
  Private pDefaultContactID As Int32
  Private pInvoiceParentCompany As Boolean
  Private pRazonSocial As String
  Private pBancoIntermediario As String
  Private pNumero_SWIFT As String
  Private pNumero_ABA As String
  Private pRucnumber As String
  Private pSupplierReferenceID As String
  Private pPurchasingTermsType As Int32
  Private pMainAddress1 As String
  Private pMainAddress2 As String
  Private pMainTown As String
  Private pMainCounty As String
  Private pMainCountry As String
  Private pDefaultCurrency As Integer
  Protected pMainAddress As dmPostalAddress
  Private pBankName As String

  Private pSupplierContacts As colSupplierContacts
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    pSupplierContacts = New colSupplierContacts
    pMainAddress = New dmPostalAddress
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pSupplierContacts = Nothing
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then mAnyDirty = pMainAddress.IsAnyDirty
      If mAnyDirty = False Then mAnyDirty = pSupplierContacts.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    SupplierID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSupplier)
      .SupplierID = SupplierID
      .CompanyName = CompanyName
      .SupplierStatusID = SupplierStatusID
      .SupplierTypeID = SupplierTypeID
      .ParentSupplierID = ParentSupplierID
      .AccountCode = AccountCode
      .TelNo = TelNo
      .Fax = Fax
      .Email = Email
      .WebURL = WebURL
      .SalesAreaID = SalesAreaID
      .PaymentTermsType = PaymentTermsType
      .PaymentTermsParam = PaymentTermsParam
      .VATRefNo = VATRefNo
      .Notes = Notes
      .DateEntered = DateEntered
      .DateAmended = DateAmended
      .EnteredByUserID = EnteredByUserID
      .AmendedByUserID = AmendedByUserID
      .DefaultAddressID = DefaultAddressID
      .DefaultContactID = DefaultContactID
      .InvoiceParentCompany = InvoiceParentCompany
      .RazonSocial = RazonSocial
      .BancoIntermediario = BancoIntermediario
      .Numero_SWIFT = Numero_SWIFT
      .Numero_ABA = Numero_ABA
      .Rucnumber = Rucnumber
      .SupplierReferenceID = SupplierReferenceID
      .PurchasingTermsType = PurchasingTermsType
      ''.MainAddress1 = MainAddress1
      ''.MainAddress2 = MainAddress2
      ''.MainTown = MainTown
      ''.MainCounty = MainCounty
      ''.MainCountry = MainCountry
      .DefaultCurrency = DefaultCurrency
      .BankName = BankName

      'Add entries here for each collection and class property
      .SupplierContacts = SupplierContacts.Clone
      'Entries for object management
      .MainAddress = MainAddress.Clone
      .IsDirty = IsDirty
    End With

  End Sub





  Public Property DefaultCurrency() As Int32
    Get
      Return pDefaultCurrency
    End Get
    Set(ByVal value As Int32)
      If pDefaultCurrency <> value Then IsDirty = True
      pDefaultCurrency = value
    End Set
  End Property

  Public Property SupplierID() As Int32 Implements iValueItem.ItemValue
    Get
      Return pSupplierID
    End Get
    Set(ByVal value As Int32)
      If pSupplierID <> value Then IsDirty = True
      pSupplierID = value
    End Set
  End Property

  Public Property SupplierContacts() As colSupplierContacts
    Get
      Return pSupplierContacts
    End Get

    Set(value As colSupplierContacts)
      pSupplierContacts = value
    End Set

  End Property

  Public Property CompanyName() As String Implements iValueItem.DisplayValue
    Get
      Return pCompanyName
    End Get
    Set(ByVal value As String)
      If pCompanyName <> value Then IsDirty = True
      pCompanyName = value
    End Set
  End Property


  Public Property BankName() As String
    Get
      Return pBankName
    End Get
    Set(ByVal value As String)
      If pBankName <> value Then IsDirty = True
      pBankName = value
    End Set
  End Property
  Public Property SupplierStatusID() As Int32
    Get
      Return pSupplierStatusID
    End Get
    Set(ByVal value As Int32)
      If pSupplierStatusID <> value Then IsDirty = True
      pSupplierStatusID = value
    End Set
  End Property

  Public Property SupplierTypeID() As Int32
    Get
      Return pSupplierTypeID
    End Get
    Set(ByVal value As Int32)
      If pSupplierTypeID <> value Then IsDirty = True
      pSupplierTypeID = value
    End Set
  End Property

  Public Property ParentSupplierID() As Int32
    Get
      Return pParentSupplierID
    End Get
    Set(ByVal value As Int32)
      If pParentSupplierID <> value Then IsDirty = True
      pParentSupplierID = value
    End Set
  End Property

  Public Property AccountCode() As String
    Get
      Return pAccountCode
    End Get
    Set(ByVal value As String)
      If pAccountCode <> value Then IsDirty = True
      pAccountCode = value
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

  Public Property SalesAreaID() As Int32
    Get
      Return pSalesAreaID
    End Get
    Set(ByVal value As Int32)
      If pSalesAreaID <> value Then IsDirty = True
      pSalesAreaID = value
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

  Public Property VATRefNo() As String
    Get
      Return pVATRefNo
    End Get
    Set(ByVal value As String)
      If pVATRefNo <> value Then IsDirty = True
      pVATRefNo = value
    End Set
  End Property

  Public Property Notes() As String
    Get
      Return pNotes
    End Get
    Set(ByVal value As String)
      If pNotes <> value Then IsDirty = True
      pNotes = value
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

  Public Property DateAmended() As DateTime
    Get
      Return pDateAmended
    End Get
    Set(ByVal value As DateTime)
      If pDateAmended <> value Then IsDirty = True
      pDateAmended = value
    End Set
  End Property

  Public Property EnteredByUserID() As Int32
    Get
      Return pEnteredByUserID
    End Get
    Set(ByVal value As Int32)
      If pEnteredByUserID <> value Then IsDirty = True
      pEnteredByUserID = value
    End Set
  End Property

  Public Property AmendedByUserID() As Int32
    Get
      Return pAmendedByUserID
    End Get
    Set(ByVal value As Int32)
      If pAmendedByUserID <> value Then IsDirty = True
      pAmendedByUserID = value
    End Set
  End Property

  Public Property DefaultAddressID() As Int32
    Get
      Return pDefaultAddressID
    End Get
    Set(ByVal value As Int32)
      If pDefaultAddressID <> value Then IsDirty = True
      pDefaultAddressID = value
    End Set
  End Property

  Public Property DefaultContactID() As Int32
    Get
      Return pDefaultContactID
    End Get
    Set(ByVal value As Int32)
      If pDefaultContactID <> value Then IsDirty = True
      pDefaultContactID = value
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

  Public Property RazonSocial() As String
    Get
      Return pRazonSocial
    End Get
    Set(ByVal value As String)
      If pRazonSocial <> value Then IsDirty = True
      pRazonSocial = value
    End Set
  End Property

  Public Property BancoIntermediario() As String
    Get
      Return pBancoIntermediario
    End Get
    Set(ByVal value As String)
      If pBancoIntermediario <> value Then IsDirty = True
      pBancoIntermediario = value
    End Set
  End Property

  Public Property Numero_SWIFT() As String
    Get
      Return pNumero_SWIFT
    End Get
    Set(ByVal value As String)
      If pNumero_SWIFT <> value Then IsDirty = True
      pNumero_SWIFT = value
    End Set
  End Property
  Public Property MainAddress() As dmPostalAddress
    Get
      Return pMainAddress
    End Get
    Set(value As dmPostalAddress)
      pMainAddress = value
    End Set
  End Property
  Public Property Numero_ABA() As String
    Get
      Return pNumero_ABA
    End Get
    Set(ByVal value As String)
      If pNumero_ABA <> value Then IsDirty = True
      pNumero_ABA = value
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

  Public Property SupplierReferenceID() As String
    Get
      Return pSupplierReferenceID
    End Get
    Set(ByVal value As String)
      If pSupplierReferenceID <> value Then IsDirty = True
      pSupplierReferenceID = value
    End Set
  End Property

  Public Property PurchasingTermsType() As Int32
    Get
      Return pPurchasingTermsType
    End Get
    Set(ByVal value As Int32)
      If pPurchasingTermsType <> value Then IsDirty = True
      pPurchasingTermsType = value
    End Set
  End Property

  Public ReadOnly Property MainAddress1() As String
    Get
      If pMainAddress IsNot Nothing Then
        Return pMainAddress.Address1

      End If
    End Get
    ''Set(ByVal value As String)
    ''  If pMainAddress1 <> value Then IsDirty = True
    ''  pMainAddress1 = value
    ''End Set
  End Property

  Public ReadOnly Property MainAddress2() As String
    Get
      If pMainAddress IsNot Nothing Then
        Return pMainAddress.Address2

      End If
    End Get
    ''Set(ByVal value As String)
    ''  If pMainAddress2 <> value Then IsDirty = True
    ''  pMainAddress2 = value
    ''End Set
  End Property

  Public ReadOnly Property MainTown() As String
    Get
      If pMainAddress IsNot Nothing Then
        Return pMainAddress.Town

      End If

    End Get
    ''Set(ByVal value As String)
    ''  If pMainTown <> value Then IsDirty = True
    ''  pMainTown = value
    ''End Set
  End Property

  Public ReadOnly Property MainCounty() As String
    Get
      If pMainAddress IsNot Nothing Then
        Return pMainAddress.County

      End If

    End Get
    ''Set(ByVal value As String)
    ''  If pMainCounty <> value Then IsDirty = True
    ''  pMainCounty = value
    ''End Set
  End Property

  Public ReadOnly Property MainCountry() As String
    Get
      If pMainAddress IsNot Nothing Then
        Return pMainAddress.Country

      End If

    End Get
    ''Set(ByVal value As String)
    ''  If pMainCountry <> value Then IsDirty = True
    ''  pMainCountry = value
    ''End Set
  End Property

  Public Property ArchiveOnly As Boolean Implements iValueItem.ArchiveOnly
    Get
      ''Throw New NotImplementedException()
    End Get
    Set(value As Boolean)
      ''Throw New NotImplementedException()
    End Set
  End Property
End Class



''Collection Definition - Supplier (to Supplier)'Generated from Table:Supplier

'Private pSuppliers As colSuppliers
'Public Property Suppliers() As colSuppliers
'  Get
'    Return pSuppliers
'  End Get
'  Set(ByVal value As colSuppliers)
'    pSuppliers = value
'  End Set
'End Property

'  pSuppliers = New colSuppliers 'Add to New
'  pSuppliers = Nothing 'Add to Finalize
'  .Suppliers = Suppliers.Clone 'Add to CloneTo
'  Suppliers.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Suppliers.IsDirty 'Add to IsAnyDirty

Public Class colSuppliers : Inherits colBase(Of dmSupplier)

  Public Overrides Function IndexFromKey(ByVal vSupplierID As Integer) As Integer
    Dim mItem As dmSupplier
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SupplierID = vSupplierID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSupplier))
    MyBase.New(vList)
  End Sub

End Class


''DTO Definition - Supplier (to Supplier)'Generated from Table:Supplier




