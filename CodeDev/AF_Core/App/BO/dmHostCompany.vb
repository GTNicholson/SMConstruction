''Class Definition - HostCompany (to HostCompany)'Generated from Table:HostCompany
Imports RTIS.CommonVB

Public Class dmHostCompany : Inherits dmBase
  Private pHostCompanyID As Int32
  Private pCompanyName As String
  Private pCompanyNumber As String
  Private pVATRegNo As String
  Private pTelNo As String
  Private pFax As String
  Private pEmail As String
  Private pWebURL As String
  Private pAddress1 As String
  Private pAddress2 As String
  Private pAddress3 As String
  Private pTown As String
  Private pCounty As String
  Private pPostCode As String
  Private pCountry As String
  Private pNotes As String
  Private pAbreviation As String

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
    HostCompanyID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmHostCompany)
      .HostCompanyID = HostCompanyID
      .CompanyName = CompanyName
      .CompanyNumber = CompanyNumber
      .VATRegNo = VATRegNo
      .TelNo = TelNo
      .Fax = Fax
      .Email = Email
      .WebURL = WebURL
      .Address1 = Address1
      .Address2 = Address2
      .Address3 = Address3
      .Town = Town
      .County = County
      .PostCode = PostCode
      .Country = Country
      .Notes = Notes
      .Abreviation = Abreviation
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property HostCompanyID() As Int32
    Get
      Return pHostCompanyID
    End Get
    Set(ByVal value As Int32)
      If pHostCompanyID <> value Then IsDirty = True
      pHostCompanyID = value
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

  Public Property CompanyNumber() As String
    Get
      Return pCompanyNumber
    End Get
    Set(ByVal value As String)
      If pCompanyNumber <> value Then IsDirty = True
      pCompanyNumber = value
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

  Public Property Address1() As String
    Get
      Return pAddress1
    End Get
    Set(ByVal value As String)
      If pAddress1 <> value Then IsDirty = True
      pAddress1 = value
    End Set
  End Property

  Public Property Address2() As String
    Get
      Return pAddress2
    End Get
    Set(ByVal value As String)
      If pAddress2 <> value Then IsDirty = True
      pAddress2 = value
    End Set
  End Property

  Public Property Address3() As String
    Get
      Return pAddress3
    End Get
    Set(ByVal value As String)
      If pAddress3 <> value Then IsDirty = True
      pAddress3 = value
    End Set
  End Property

  Public Property Town() As String
    Get
      Return pTown
    End Get
    Set(ByVal value As String)
      If pTown <> value Then IsDirty = True
      pTown = value
    End Set
  End Property

  Public Property County() As String
    Get
      Return pCounty
    End Get
    Set(ByVal value As String)
      If pCounty <> value Then IsDirty = True
      pCounty = value
    End Set
  End Property

  Public Property PostCode() As String
    Get
      Return pPostCode
    End Get
    Set(ByVal value As String)
      If pPostCode <> value Then IsDirty = True
      pPostCode = value
    End Set
  End Property

  Public Property Country() As String
    Get
      Return pCountry
    End Get
    Set(ByVal value As String)
      If pCountry <> value Then IsDirty = True
      pCountry = value
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

  Public Property Abreviation() As String
    Get
      Return pAbreviation
    End Get
    Set(ByVal value As String)
      If pAbreviation <> value Then IsDirty = True
      pAbreviation = value
    End Set
  End Property


End Class



''Collection Definition - HostCompany (to HostCompany)'Generated from Table:HostCompany

'Private pHostCompanys As colHostCompanys
'Public Property HostCompanys() As colHostCompanys
'  Get
'    Return pHostCompanys
'  End Get
'  Set(ByVal value As colHostCompanys)
'    pHostCompanys = value
'  End Set
'End Property

'  pHostCompanys = New colHostCompanys 'Add to New
'  pHostCompanys = Nothing 'Add to Finalize
'  .HostCompanys = HostCompanys.Clone 'Add to CloneTo
'  HostCompanys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = HostCompanys.IsDirty 'Add to IsAnyDirty

Public Class colHostCompanys : Inherits colBase(Of dmHostCompany)

  Public Overrides Function IndexFromKey(ByVal vHostCompanyID As Integer) As Integer
    Dim mItem As dmHostCompany
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.HostCompanyID = vHostCompanyID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmHostCompany))
    MyBase.New(vList)
  End Sub

End Class


