''Class Definition - EmailTemplate (to EmailTemplate)'Generated from Table:EmailTemplate
Imports RTIS.CommonVB

Public Class dmEmailTemplate : Inherits dmBase
  Private pEmailTemplateID As Int32
  Private pEmailTemplateEnum As Byte
  Private pDistributionEnum As Byte
  Private pSubject As String
  Private pBody As String

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
    EmailTemplateID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmEmailTemplate)
      .EmailTemplateID = EmailTemplateID
      .EmailTemplateEnum = EmailTemplateEnum
      .DistributionEnum = DistributionEnum
      .Subject = Subject
      .Body = Body
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property EmailTemplateID() As Int32
    Get
      Return pEmailTemplateID
    End Get
    Set(ByVal value As Int32)
      If pEmailTemplateID <> value Then IsDirty = True
      pEmailTemplateID = value
    End Set
  End Property

  Public Property EmailTemplateEnum() As Byte
    Get
      Return pEmailTemplateEnum
    End Get
    Set(ByVal value As Byte)
      If pEmailTemplateEnum <> value Then IsDirty = True
      pEmailTemplateEnum = value
    End Set
  End Property

  Public Property DistributionEnum() As Byte
    Get
      Return pDistributionEnum
    End Get
    Set(ByVal value As Byte)
      If pDistributionEnum <> value Then IsDirty = True
      pDistributionEnum = value
    End Set
  End Property

  Public Property Subject() As String
    Get
      Return pSubject
    End Get
    Set(ByVal value As String)
      If pSubject <> value Then IsDirty = True
      pSubject = value
    End Set
  End Property

  Public Property Body() As String
    Get
      Return pBody
    End Get
    Set(ByVal value As String)
      If pBody <> value Then IsDirty = True
      pBody = value
    End Set
  End Property


End Class



''Collection Definition - EmailTemplate (to EmailTemplate)'Generated from Table:EmailTemplate

'Private pEmailTemplates As colEmailTemplates
'Public Property EmailTemplates() As colEmailTemplates
'  Get
'    Return pEmailTemplates
'  End Get
'  Set(ByVal value As colEmailTemplates)
'    pEmailTemplates = value
'  End Set
'End Property

'  pEmailTemplates = New colEmailTemplates 'Add to New
'  pEmailTemplates = Nothing 'Add to Finalize
'  .EmailTemplates = EmailTemplates.Clone 'Add to CloneTo
'  EmailTemplates.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = EmailTemplates.IsDirty 'Add to IsAnyDirty

Public Class colEmailTemplates : Inherits colBase(Of dmEmailTemplate)

  Public Overrides Function IndexFromKey(ByVal vEmailTemplateID As Integer) As Integer
    Dim mItem As dmEmailTemplate
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.EmailTemplateID = vEmailTemplateID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmEmailTemplate))
    MyBase.New(vList)
    TrackDeleted = True
  End Sub

End Class