''Class Definition - FileTracker (to FileTracker)'Generated from Table:FileTracker
Imports RTIS.CommonVB

Public Class dmFileTracker : Inherits dmBase
  Private pFileID As Int32
  Private pFileName As String
  Private pFileType As String
  Private pDateReceived As DateTime
  Private pParentID As Int32
  Private pParentType As Int32
  Private pDescription As String
  Private pIncludeInPack As Boolean

  Public Sub New()
    MyBase.new()
  End Sub

  Public Property LocationValidated As Boolean 'Not Persisted

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    AddSnapshotKey("FileID")
    AddSnapshotKey("ParentID")
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
    FileID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmFileTracker)
      .FileID = FileID
      .FileName = FileName
      .FileType = FileType
      .DateReceived = DateReceived
      .ParentID = ParentID
      .ParentType = ParentType
      .Description = Description
      .IncludeInPack = IncludeInPack
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property FileID() As Int32
    Get
      FileID = pFileID
    End Get
    Set(ByVal value As Int32)
      If pFileID <> value Then IsDirty = True
      pFileID = value
    End Set
  End Property

  Public Property FileName() As String
    Get
      FileName = pFileName
    End Get
    Set(ByVal value As String)
      If pFileName <> value Then IsDirty = True
      pFileName = value
    End Set
  End Property

  Public Property FileType() As String
    Get
      Return pFileType
    End Get
    Set(ByVal value As String)
      If pFileType <> value Then IsDirty = True
      pFileType = value
    End Set
  End Property

  Public Property DateReceived() As DateTime
    Get
      DateReceived = pDateReceived
    End Get
    Set(ByVal value As DateTime)
      If pDateReceived <> value Then IsDirty = True
      pDateReceived = value
    End Set
  End Property

  Public Property ParentID() As Int32
    Get
      ParentID = pParentID
    End Get
    Set(ByVal value As Int32)
      If pParentID <> value Then IsDirty = True
      pParentID = value
    End Set
  End Property

  Public Property ParentType() As Int32
    Get
      ParentType = pParentType
    End Get
    Set(ByVal value As Int32)
      If pParentType <> value Then IsDirty = True
      pParentType = value
    End Set
  End Property

  Public Property Description() As String
    Get
      Description = pDescription
    End Get
    Set(value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property

  Public Property IncludeInPack As Boolean
    Get
      Return pIncludeInPack
    End Get
    Set(value As Boolean)
      If pIncludeInPack <> value Then IsDirty = True
      pIncludeInPack = value
    End Set
  End Property

End Class



''Collection Definition - FileTracker (to FileTracker)'Generated from Table:FileTracker

'Private pFileTrackers As colFileTrackers
'Public Property FileTrackers() As colFileTrackers
'  Get
'    FileTrackers = pFileTrackers
'  End Get
'  Set(ByVal value As colFileTrackers)
'    pFileTrackers = value
'  End Set
'End Property

'  pFileTrackers = New colFileTrackers 'Add to New
'  pFileTrackers = Nothing 'Add to Finalize
'  .FileTrackers = FileTrackers.Clone 'Add to CloneTo
'  FileTrackers.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = FileTrackers.IsDirty 'Add to IsAnyDirty

Public Class colFileTrackers : Inherits colBase(Of dmFileTracker)

  Public Overrides Function IndexFromKey(ByVal vFileID As Integer) As Integer
    Dim mItem As dmFileTracker
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.FileID = vFileID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmFileTracker))
    MyBase.New(vList)
  End Sub

  Public Function HasFile(ByVal vFileName As String)

    For Each mItem As dmFileTracker In MyBase.Items
      If mItem.FileName = vFileName Then Return True
    Next

    Return False
  End Function

  Public Sub RenameFile(ByVal vOldName As String, ByVal vNewName As String)

    For Each mItem As dmFileTracker In MyBase.Items
      If mItem.FileName = vOldName Then
        mItem.FileName = vNewName
        Exit For
      End If
    Next

  End Sub

  Public Function ItemFromFileName(ByVal vFileName As String) As dmFileTracker
    For Each mItem As dmFileTracker In MyBase.Items
      If mItem.FileName = vFileName Then Return mItem
    Next

    Return Nothing
  End Function

End Class




