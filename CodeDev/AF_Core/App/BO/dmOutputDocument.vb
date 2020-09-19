''Class Definition - OutputDocument (to OutputDocument)'Generated from Table:OutputDocument
Imports RTIS.CommonVB

Public Class dmOutputDocument : Inherits dmBase
  Private pOutputDocumentID As Int32
  Private pParentID As Integer
  Private pParentTypeID As Byte
  Private pDocumentTypeID As Byte
  Private pFileTypeID As Byte
  Private pFilePath As String
  Private pVersionRef As String
  Private pDateCreated As DateTime

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
    OutputDocumentID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmOutputDocument)
      .OutputDocumentID = OutputDocumentID
      .ParentID = ParentID
      .DocumentTypeID = DocumentTypeID
      .FileTypeID = FileTypeID
      .FilePath = FilePath
      .VersionRef = VersionRef
      .DateCreated = DateCreated
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property OutputDocumentID() As Int32
    Get
      Return pOutputDocumentID
    End Get
    Set(ByVal value As Int32)
      If pOutputDocumentID <> value Then IsDirty = True
      pOutputDocumentID = value
    End Set
  End Property

  Public Property ParentID() As Int32
    Get
      Return pParentID
    End Get
    Set(ByVal value As Int32)
      If pParentID <> value Then IsDirty = True
      pParentID = value
    End Set
  End Property

  Public Property ParentTypeID As Byte
    Get
      Return pParentTypeID
    End Get
    Set(value As Byte)
      If pParentTypeID <> value Then IsDirty = True
      pParentTypeID = value
    End Set
  End Property

  Public Property DocumentTypeID() As Byte
    Get
      Return pDocumentTypeID
    End Get
    Set(ByVal value As Byte)
      If pDocumentTypeID <> value Then IsDirty = True
      pDocumentTypeID = value
    End Set
  End Property

  Public Property FileTypeID() As Byte
    Get
      Return pFileTypeID
    End Get
    Set(ByVal value As Byte)
      If pFileTypeID <> value Then IsDirty = True
      pFileTypeID = value
    End Set
  End Property

  Public Property FilePath() As String
    Get
      Return pFilePath
    End Get
    Set(ByVal value As String)
      If pFilePath <> value Then IsDirty = True
      pFilePath = value
    End Set
  End Property

  Public Property VersionRef() As String
    Get
      Return pVersionRef
    End Get
    Set(ByVal value As String)
      If pVersionRef <> value Then IsDirty = True
      pVersionRef = value
    End Set
  End Property

  Public Property DateCreated() As DateTime
    Get
      Return pDateCreated
    End Get
    Set(ByVal value As DateTime)
      If pDateCreated <> value Then IsDirty = True
      pDateCreated = value
    End Set
  End Property


End Class



''Collection Definition - OutputDocument (to OutputDocument)'Generated from Table:OutputDocument

'Private pOutputDocuments As colOutputDocuments
'Public Property OutputDocuments() As colOutputDocuments
'  Get
'    Return pOutputDocuments
'  End Get
'  Set(ByVal value As colOutputDocuments)
'    pOutputDocuments = value
'  End Set
'End Property

'  pOutputDocuments = New colOutputDocuments 'Add to New
'  pOutputDocuments = Nothing 'Add to Finalize
'  .OutputDocuments = OutputDocuments.Clone 'Add to CloneTo
'  OutputDocuments.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = OutputDocuments.IsDirty 'Add to IsAnyDirty

Public Class colOutputDocuments : Inherits colBase(Of dmOutputDocument)

  Public Overrides Function IndexFromKey(ByVal vID As Integer) As Integer
    Dim mItem As dmOutputDocument
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.OutputDocumentID = vID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
    Me.TrackDeleted = True
  End Sub

  Public Sub New(ByVal vList As List(Of dmOutputDocument))
    MyBase.New(vList)
    TrackDeleted = True
  End Sub

  Public Function ItemFromParentDocFileType(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vFileType As eFileType) As dmOutputDocument
    Dim mRetVal As dmOutputDocument = Nothing

    For Each mItem As dmOutputDocument In MyBase.Items
      If mItem.ParentTypeID = vParentType AndAlso mItem.DocumentTypeID = vDocumentType AndAlso mItem.FileTypeID = vFileType Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function

  Public Function GetOrCreate(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vFileType As eFileType) As dmOutputDocument
    Dim mRetVal As dmOutputDocument

    mRetVal = ItemFromParentDocFileType(vParentType, vDocumentType, vFileType)
    If mRetVal Is Nothing Then
      mRetVal = New dmOutputDocument
      mRetVal.ParentTypeID = vParentType
      mRetVal.DocumentTypeID = vDocumentType
      mRetVal.FileTypeID = vFileType
      mRetVal.DateCreated = Now
      MyBase.Add(mRetVal)
    End If

    Return mRetVal
  End Function

  Public Function GetFilePath(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vFileType As eFileType) As String
    Dim mRetVal As String = String.Empty
    Dim mOutputDoc As dmOutputDocument

    mOutputDoc = ItemFromParentDocFileType(vParentType, vDocumentType, vFileType)
    If mOutputDoc IsNot Nothing Then
      mRetVal = mOutputDoc.FilePath
    End If

    Return mRetVal
  End Function

  Public Sub SetFilePath(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vFileType As eFileType, ByVal vFilePath As String)

    Dim mOutputDoc As dmOutputDocument

    mOutputDoc = GetOrCreate(vParentType, vDocumentType, vFileType)
    If mOutputDoc IsNot Nothing Then
      mOutputDoc.FilePath = vFilePath
    End If

  End Sub

  Public Function DeleteOutputDoc(ByVal vParentType As eParentType, ByVal vDocType As eDocumentType, ByVal vFileType As eFileType) As Boolean
    Dim mOutputDoc As dmOutputDocument
    Dim mDeleted As Boolean

    Try
      mOutputDoc = ItemFromParentDocFileType(vParentType, vDocType, vFileType)
      If mOutputDoc IsNot Nothing Then
        If IO.File.Exists(mOutputDoc.FilePath) Then
          IO.File.Delete(mOutputDoc.FilePath)
          mDeleted = True
          MyBase.Remove(mOutputDoc)
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mDeleted
  End Function

  Public Function GetAllExcept(ByVal vDocType As eDocumentType) As colOutputDocuments
    Dim mRetVal As New colOutputDocuments

    For Each mItem As dmOutputDocument In MyBase.Items
      If mItem.DocumentTypeID <> vDocType Then
        mRetVal.Add(mItem)
      End If
    Next

    Return mRetVal
  End Function

  Public Function GetFileName(ByVal vParentType As eParentType, ByVal vDocumentType As eDocumentType, ByVal vFileType As eFileType) As String
    Dim mRetVal As String = String.Empty

    mRetVal = GetFilePath(vParentType, vDocumentType, vFileType)

    mRetVal = System.IO.Path.GetFileName(mRetVal)

    Return mRetVal
  End Function


End Class

