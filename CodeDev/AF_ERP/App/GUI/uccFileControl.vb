Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RobustUKCore

Public Class uccFileControl
  Private pFileTrackers As colFileTrackers
  Private pDirectory As String
  Private pSyncObject As System.ComponentModel.ISynchronizeInvoke
  Private pUseWatcher As Boolean

  Public Event RequestControlRefresh As EventHandler(Of EventArgs)

  Private WithEvents pFileSystemWatcher As New IO.FileSystemWatcher

  Public Property FileTrackers() As colFileTrackers
    Get
      Return pFileTrackers
    End Get
    Set(value As colFileTrackers)
      pFileTrackers = value
    End Set
  End Property

  Public Property Directory As String
    Get
      Return pDirectory
    End Get
    Set(value As String)
      pDirectory = value

      If pUseWatcher Then ConfigSystemWatcher()

    End Set
  End Property

  Public ReadOnly Property FileSystemWatcher As IO.FileSystemWatcher
    Get
      Return pFileSystemWatcher
    End Get
  End Property

  Public Sub New(ByRef rSyncObject As System.ComponentModel.ISynchronizeInvoke)
    pFileSystemWatcher = New IO.FileSystemWatcher
    pFileSystemWatcher.EnableRaisingEvents = False
    pSyncObject = rSyncObject
    pUseWatcher = True
  End Sub

  Public Sub New()
    pFileSystemWatcher = New IO.FileSystemWatcher
    pFileSystemWatcher.EnableRaisingEvents = False
    pUseWatcher = False
  End Sub

  Public ReadOnly Property FileSystemWatcherEnabled As Boolean
    Get
      Return pFileSystemWatcher.EnableRaisingEvents
    End Get
  End Property

  Private Sub FileSystemWatcher_Created(sender As Object, e As IO.FileSystemEventArgs) Handles pFileSystemWatcher.Created
    OnFSWCreated(e)
  End Sub

  Private Sub FileSystemWatcher_Deleted(sender As Object, e As IO.FileSystemEventArgs) Handles pFileSystemWatcher.Deleted
    OnFSWDeleted(e)
  End Sub

  Private Sub FileSystemWatcher_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles pFileSystemWatcher.Renamed
    OnFSWRenamed(e)
  End Sub

  Private Sub FileSystemWatcher_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles pFileSystemWatcher.Changed
    OnFSWChanged(e)
  End Sub

  Public Overridable Sub OnFSWCreated(ByVal e As IO.FileSystemEventArgs)
    SynchroniseFiles()
  End Sub

  Public Overridable Sub OnFSWDeleted(ByVal e As IO.FileSystemEventArgs)
    SynchroniseFiles()
  End Sub

  Public Overridable Sub OnFSWRenamed(ByVal e As IO.RenamedEventArgs)
    pFileTrackers.RenameFile(e.OldName, e.Name)
    SynchroniseFiles()
  End Sub

  Public Overridable Sub OnFSWChanged(ByVal e As IO.FileSystemEventArgs)
    SynchroniseFiles()
  End Sub

  Public Overridable Sub ConfigSystemWatcher()
    CreateDir()
    pFileSystemWatcher.Path = pDirectory
    pFileSystemWatcher.SynchronizingObject = pSyncObject
    pFileSystemWatcher.IncludeSubdirectories = True
    pFileSystemWatcher.EnableRaisingEvents = True
  End Sub

  Public Overridable Sub SynchroniseFiles()
    If System.IO.Directory.Exists(pDirectory) Then
      Dim mFilesInDirectory As String() = IO.Directory.GetFiles(pDirectory)
      For Each mFilePath As String In mFilesInDirectory
        Dim mFileName As String = IO.Path.GetFileName(mFilePath)

        If Not pFileTrackers.HasFile(mFileName) Then
          AddFile(mFilePath, False)
        End If

      Next

      ValidateFileLocations()
      RaiseEvent RequestControlRefresh(Me, EventArgs.Empty)
    End If
  End Sub

  Protected Overridable Sub CreateDir()
    If Not IO.Directory.Exists(pDirectory) Then
      IO.Directory.CreateDirectory(pDirectory)
    End If
  End Sub

  Protected Overridable Sub ValidateFileLocations()

    For Each mFileTracker As dmFileTracker In pFileTrackers
      Dim mFilePath As String = IO.Path.Combine(pDirectory, mFileTracker.FileName)

      mFileTracker.LocationValidated = IO.File.Exists(mFilePath)

    Next

  End Sub

  Public Overridable Function AddFile(ByVal vFilePath As String, ByVal vWithCopy As Boolean) As clsValidate
    Dim mVal As New clsValidate

    Try

      CreateDir()

      Dim mFileTracker As New dmFileTracker
      Dim mFileName As String = IO.Path.GetFileName(vFilePath)

      If vWithCopy Then
        CopyFile(vFilePath)
      End If

      If Not pFileTrackers.HasFile(mFileName) Then
        mFileTracker.DateReceived = DateTime.Now
        mFileTracker.FileName = mFileName
        mFileTracker.FileType = IO.Path.GetExtension(mFileName)
        pFileTrackers.Add(mFileTracker)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mVal
  End Function

  Public Overridable Function DeleteFile(ByVal vFileName As String) As clsValidate
    Dim mVal As New clsValidate

    Try
      Dim mFileTracker As dmFileTracker = pFileTrackers.ItemFromFileName(vFileName)

      If mFileTracker IsNot Nothing Then
        Dim mFilePath As String = IO.Path.Combine(pDirectory, vFileName)

        If IO.File.Exists(mFilePath) Then
          IO.File.Delete(mFilePath)
        End If
        pFileTrackers.Remove(mFileTracker)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mVal
  End Function

  Public Overridable Function OpenFile(ByVal vFile As String) As clsValidate
    Dim mVal As New clsValidate

    Try
      Dim mFileName As String = IO.Path.Combine(pDirectory, vFile)

      If Not IO.File.Exists(mFileName) Then
        mVal.ValOk = False
        mVal.AddMsgLine("Archivo no encontrado")
      End If

      If mVal.ValOk Then
        Process.Start(mFileName)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mVal
  End Function

  Public Overridable Sub CopyFile(ByVal vFilePath As String)
    Try
      Dim mFileName As String = IO.Path.GetFileName(vFilePath)
      Dim mCopyToFileName As String = IO.Path.Combine(pDirectory, mFileName)

      IO.File.Copy(vFilePath, mCopyToFileName, True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Overridable Function FileAlreadyExists(ByVal vFilePath As String) As Boolean
    Dim mExits As Boolean = False

    Try
      Dim mFileName As String = IO.Path.GetFileName(vFilePath)
      Dim mCopyToFileName As String = IO.Path.Combine(pDirectory, mFileName)

      mExits = IO.File.Exists(mCopyToFileName)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mExits
  End Function

  Public Sub OpenFolder()
    Try
      Dim mFolderName As String = pDirectory

      If IO.Directory.Exists(mFolderName) Then
        Process.Start(mFolderName)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Overridable Sub SearchForNewFiles()
    Try

      SynchroniseFiles()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


End Class
