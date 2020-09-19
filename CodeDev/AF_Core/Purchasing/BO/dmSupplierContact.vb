''Class Definition - SupplierContact (to SupplierContact)'Generated from Table:SupplierContact
Imports RTIS.CommonVB

Public Class dmSupplierContact : Inherits dmBase
  Private pSupplierContactID As Int32
  Private pSupplierID As Int32
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
    SupplierContactID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSupplierContact)
      .SupplierContactID = SupplierContactID
      .SupplierID = SupplierID
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

  Public Property SupplierContactID() As Int32
    Get
      Return pSupplierContactID
    End Get
    Set(ByVal value As Int32)
      If pSupplierContactID <> value Then IsDirty = True
      pSupplierContactID = value
    End Set
  End Property

  Public Property SupplierID() As Int32
    Get
      Return pSupplierID
    End Get
    Set(ByVal value As Int32)
      If pSupplierID <> value Then IsDirty = True
      pSupplierID = value
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



''Collection Definition - SupplierContact (to SupplierContact)'Generated from Table:SupplierContact

'Private pSupplierContacts As colSupplierContacts
'Public Property SupplierContacts() As colSupplierContacts
'  Get
'    Return pSupplierContacts
'  End Get
'  Set(ByVal value As colSupplierContacts)
'    pSupplierContacts = value
'  End Set
'End Property

'  pSupplierContacts = New colSupplierContacts 'Add to New
'  pSupplierContacts = Nothing 'Add to Finalize
'  .SupplierContacts = SupplierContacts.Clone 'Add to CloneTo
'  SupplierContacts.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SupplierContacts.IsDirty 'Add to IsAnyDirty

Public Class colSupplierContacts : Inherits colBase(Of dmSupplierContact)

  Public Overrides Function IndexFromKey(ByVal vSupplierContactID As Integer) As Integer
    Dim mItem As dmSupplierContact
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SupplierContactID = vSupplierContactID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSupplierContact))
    MyBase.New(vList)
  End Sub

End Class



