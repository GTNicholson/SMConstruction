''Class Definition - CustomerContact (to CustomerContact)'Generated from Table:CustomerContact
Imports RTIS.CommonVB

Public Class dmCustomerContact : Inherits dmBase
  Private pCustomerContactID As Int32
  Private pCustomerID As Int32
  Private pTitle As String
  Private pFirstName As String
  Private pLastName As String
  Private pTelNo As String
  Private pEmail As String
  Private pMobile As String
  Private pContactType As Int32
  Private pContactOptions As Int32
  Private pIsActive As Boolean
  Private pDateStart As DateTime
  Private pDateEnd As DateTime
  Private pPosition As String

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
    CustomerContactID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmCustomerContact)
      .CustomerContactID = CustomerContactID
      .CustomerID = CustomerID
      .Title = Title
      .FirstName = FirstName
      .LastName = LastName
      .TelNo = TelNo
      .Email = Email
      .Mobile = Mobile
      .ContactType = ContactType
      .ContactOptions = ContactOptions
      .IsActive = IsActive
      .DateStart = DateStart
      .DateEnd = DateEnd
      .Position = Position
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property CustomerContactID() As Int32
    Get
      Return pCustomerContactID
    End Get
    Set(ByVal value As Int32)
      If pCustomerContactID <> value Then IsDirty = True
      pCustomerContactID = value
    End Set
  End Property

  Public Property CustomerID() As Int32
    Get
      Return pCustomerID
    End Get
    Set(ByVal value As Int32)
      If pCustomerID <> value Then IsDirty = True
      pCustomerID = value
    End Set
  End Property

  Public Property Title() As String
    Get
      Return pTitle
    End Get
    Set(ByVal value As String)
      If pTitle <> value Then IsDirty = True
      pTitle = value
    End Set
  End Property

  Public Property FirstName() As String
    Get
      Return pFirstName
    End Get
    Set(ByVal value As String)
      If pFirstName <> value Then IsDirty = True
      pFirstName = value
    End Set
  End Property

  Public Property LastName() As String
    Get
      Return pLastName
    End Get
    Set(ByVal value As String)
      If pLastName <> value Then IsDirty = True
      pLastName = value
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

  Public Property Email() As String
    Get
      Return pEmail
    End Get
    Set(ByVal value As String)
      If pEmail <> value Then IsDirty = True
      pEmail = value
    End Set
  End Property

  Public Property Mobile() As String
    Get
      Return pMobile
    End Get
    Set(ByVal value As String)
      If pMobile <> value Then IsDirty = True
      pMobile = value
    End Set
  End Property

  Public Property ContactType() As Int32
    Get
      Return pContactType
    End Get
    Set(ByVal value As Int32)
      If pContactType <> value Then IsDirty = True
      pContactType = value
    End Set
  End Property

  Public Property ContactOptions() As Int32
    Get
      Return pContactOptions
    End Get
    Set(ByVal value As Int32)
      If pContactOptions <> value Then IsDirty = True
      pContactOptions = value
    End Set
  End Property

  Public Property IsActive() As Boolean
    Get
      Return pIsActive
    End Get
    Set(ByVal value As Boolean)
      If pIsActive <> value Then IsDirty = True
      pIsActive = value
    End Set
  End Property

  Public Property DateStart() As DateTime
    Get
      Return pDateStart
    End Get
    Set(ByVal value As DateTime)
      If pDateStart <> value Then IsDirty = True
      pDateStart = value
    End Set
  End Property

  Public Property DateEnd() As DateTime
    Get
      Return pDateEnd
    End Get
    Set(ByVal value As DateTime)
      If pDateEnd <> value Then IsDirty = True
      pDateEnd = value
    End Set
  End Property

  Public Property Position() As String
    Get
      Return pPosition
    End Get
    Set(ByVal value As String)
      If pPosition <> value Then IsDirty = True
      pPosition = value
    End Set
  End Property


End Class



''Collection Definition - CustomerContact (to CustomerContact)'Generated from Table:CustomerContact

'Private pCustomerContacts As colCustomerContacts
'Public Property CustomerContacts() As colCustomerContacts
'  Get
'    Return pCustomerContacts
'  End Get
'  Set(ByVal value As colCustomerContacts)
'    pCustomerContacts = value
'  End Set
'End Property

'  pCustomerContacts = New colCustomerContacts 'Add to New
'  pCustomerContacts = Nothing 'Add to Finalize
'  .CustomerContacts = CustomerContacts.Clone 'Add to CloneTo
'  CustomerContacts.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = CustomerContacts.IsDirty 'Add to IsAnyDirty

Public Class colCustomerContacts : Inherits colBase(Of dmCustomerContact)

  Public Overrides Function IndexFromKey(ByVal vCustomerContactID As Integer) As Integer
    Dim mItem As dmCustomerContact
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.CustomerContactID = vCustomerContactID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmCustomerContact))
    MyBase.New(vList)
  End Sub

End Class


