''Class Definition - ReceivedEmail (to ReceivedEmail)'Generated from Table:ReceivedEmail
Imports OpenPop
Imports RTIS.CommonVB

Public Class dmReceivedEmail : Inherits dmBase
  Private pReceivedEmailID As Int32
  Private pEmailSettingsID As Int32
  Private pDateDownloaded As DateTime
  Private pEmailServiceType As Int32
  Private pLocation As String
  Private pStatus As Int32
  Private pServerUID As String
  Private pRetryCount As Int32

  Public Property EmailMessage As RTIS.EmailLib.clsEmailMessage
  Public Property RawMessage As Mime.Message

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    Me.pDateDownloaded = DateTime.Now
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
    ReceivedEmailID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmReceivedEmail)
      .ReceivedEmailID = ReceivedEmailID
      .EmailSettingsID = EmailSettingsID
      .DateDownloaded = DateDownloaded
      .EmailServiceType = EmailServiceType
      .Location = Location
      .Status = Status
      .ServerUID = ServerUID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ReceivedEmailID() As Int32
    Get
      ReceivedEmailID = pReceivedEmailID
    End Get
    Set(ByVal value As Int32)
      If pReceivedEmailID <> value Then IsDirty = True
      pReceivedEmailID = value
    End Set
  End Property

  Public Property EmailSettingsID() As Int32
    Get
      EmailSettingsID = pEmailSettingsID
    End Get
    Set(ByVal value As Int32)
      If pEmailSettingsID <> value Then IsDirty = True
      pEmailSettingsID = value
    End Set
  End Property

  Public Property DateDownloaded() As DateTime
    Get
      DateDownloaded = pDateDownloaded
    End Get
    Set(ByVal value As DateTime)
      If pDateDownloaded <> value Then IsDirty = True
      pDateDownloaded = value
    End Set
  End Property

  Public Property EmailServiceType() As Int32
    Get
      EmailServiceType = pEmailServiceType
    End Get
    Set(ByVal value As Int32)
      If pEmailServiceType <> value Then IsDirty = True
      pEmailServiceType = value
    End Set
  End Property

  Public Property Location() As String
    Get
      Location = pLocation
    End Get
    Set(ByVal value As String)
      If pLocation <> value Then IsDirty = True
      pLocation = value
    End Set
  End Property

  Public Property Status() As Int32
    Get
      Status = pStatus
    End Get
    Set(ByVal value As Int32)
      If pStatus <> value Then IsDirty = True
      pStatus = value
    End Set
  End Property

  Public Property ServerUID As String
    Get
      Return pServerUID
    End Get
    Set(value As String)
      If pServerUID <> value Then IsDirty = True
      pServerUID = value
    End Set
  End Property

  Public Property RetryCount As Int32
    Get
      Return pRetryCount
    End Get
    Set(value As Int32)
      If pRetryCount <> value Then IsDirty = True
      pRetryCount = value
    End Set
  End Property

  Public ReadOnly Property FileName() As String
    Get
      Dim mFileName As String = String.Format("{0}-MailMessage.eml", pReceivedEmailID)

      Return mFileName
    End Get
  End Property

End Class



''Collection Definition - ReceivedEmail (to ReceivedEmail)'Generated from Table:ReceivedEmail

'Private pReceivedEmails As colReceivedEmails
'Public Property ReceivedEmails() As colReceivedEmails
'  Get
'    ReceivedEmails = pReceivedEmails
'  End Get
'  Set(ByVal value As colReceivedEmails)
'    pReceivedEmails = value
'  End Set
'End Property

'  pReceivedEmails = New colReceivedEmails 'Add to New
'  pReceivedEmails = Nothing 'Add to Finalize
'  .ReceivedEmails = ReceivedEmails.Clone 'Add to CloneTo
'  ReceivedEmails.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ReceivedEmails.IsDirty 'Add to IsAnyDirty

Public Class colReceivedEmails : Inherits colBase(Of dmReceivedEmail)

  Public Overrides Function IndexFromKey(ByVal vReceivedEmailID As Integer) As Integer
    Dim mItem As dmReceivedEmail
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ReceivedEmailID = vReceivedEmailID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmReceivedEmail))
    MyBase.New(vList)
  End Sub

  Public Function HasPending() As Boolean
    For Each mItem As dmReceivedEmail In MyBase.Items
      If mItem.Status = eReceivedEmailStatus.Pending Then
        Return True
      End If
    Next

    Return False
  End Function

  Public Function ItemFromServerUID(ByVal vServerUID As String) As dmReceivedEmail
    For Each mItem As dmReceivedEmail In MyBase.Items
      If mItem.ServerUID = vServerUID Then Return mItem
    Next

    Return Nothing
  End Function

End Class