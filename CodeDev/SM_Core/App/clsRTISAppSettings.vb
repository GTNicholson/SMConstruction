Imports System.ComponentModel
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class clsRTISAppSettings : Inherits rtisSettingsFile
  Const cEncryptionKey As String = "TestEncryptionKey" 'Make unique for project?
  Const cEncryptionIV As String = "RTISPROJECTCODE"    'Make unique for project?
  Private pMainConn As clsConnInfo
  'Private pTestConn As clsConnInfo
  Private pServerSettingsPath As clsStringSetting
  Private pDatasetName As clsStringSetting
  Private pDefaultErrorLogPath As clsStringSetting
  Private pUpdateManifestFilePath As clsStringSetting
  ''Private pAppExtensionDLL As clsStringSetting
  Private pDataSetID As clsIntegerSetting

  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
  Public Property MainConn() As clsConnInfo
    Get
      MainConn = pMainConn
    End Get
    Set(ByVal value As clsConnInfo)
      pMainConn = value
    End Set
  End Property

  ''<[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
  ''Public Property TestConn() As clsConnInfo
  ''  Get
  ''    TestConn = pTestConn
  ''  End Get
  ''  Set(ByVal value As clsConnInfo)
  ''    pTestConn = value
  ''  End Set
  ''End Property

  ''  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
  ''Public Property AppExtensionDLL() As clsStringSetting
  ''    Get
  ''      AppExtensionDLL = pAppExtensionDLL
  ''    End Get
  ''    Set(ByVal value As clsStringSetting)
  ''      pAppExtensionDLL = value
  ''    End Set
  ''  End Property


  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
Public Property UpdateManifestFilePath() As clsStringSetting
    Get
      UpdateManifestFilePath = pUpdateManifestFilePath
    End Get
    Set(ByVal value As clsStringSetting)
      pUpdateManifestFilePath = value
    End Set
  End Property

  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
  Public Property DefaultErrorLogPath() As clsStringSetting
    Get
      DefaultErrorLogPath = pDefaultErrorLogPath
    End Get
    Set(ByVal value As clsStringSetting)
      pDefaultErrorLogPath = value
    End Set
  End Property

  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
  Public Property ServerSettingsPath() As clsStringSetting
    Get
      ServerSettingsPath = pServerSettingsPath
    End Get
    Set(ByVal value As clsStringSetting)
      pServerSettingsPath = value
    End Set
  End Property

  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
  Public Property DatasetName() As clsStringSetting
    Get
      DatasetName = pDatasetName
    End Get
    Set(ByVal value As clsStringSetting)
      pDatasetName = value
    End Set
  End Property

  <[Browsable](True)> <[ReadOnly](False)> <[Category]("Edit")> _
   Public Property DataSetID() As clsIntegerSetting
    Get
      DataSetID = pDataSetID
    End Get
    Set(ByVal value As clsIntegerSetting)
      pDataSetID = value
    End Set
  End Property

  Public Sub New()
    MyBase.New()
    MainConn = New clsConnInfo("MainConn")
    ''TestConn = New clsConnInfo("TestConn")
    DatasetName = New clsStringSetting("DatasetName")
    DefaultErrorLogPath = New clsStringSetting("DefaultErrorLogPath")
    ServerSettingsPath = New clsStringSetting("ServerSettingsPath")
    UpdateManifestFilePath = New clsStringSetting("UpdateManifestFilePath")
    ''AppExtensionDLL = New clsStringSetting("AppExtensionDLL")
    DataSetID = New clsIntegerSetting("DataSetID")
    MyBase.AddSettingClass(CType(MainConn, rtisSetting))
    MyBase.AddSettingClass(CType(DatasetName, rtisSetting))
    MyBase.AddSettingClass(CType(DataSetID, rtisSetting))
  End Sub


  Public Overrides Function ReadDetails(Optional ByVal vFilename As String = "") As Boolean
    Dim mrtisEncrypt As rtisEncrypt
    Dim mOK As Boolean
    Dim mAllOK As Boolean = True


    If System.IO.File.Exists(vFilename) Then

      If MyBase.OpenFile(vFilename) Then

        mrtisEncrypt = New rtisEncrypt(cEncryptionKey, cEncryptionIV)

        mOK = MyBase.ReadObjectDetails(CType(MainConn, rtisSetting), mrtisEncrypt)
        If Not mOK Then mAllOK = False
        ''mOK = MyBase.ReadObjectDetails(CType(TestConn, rtisSetting), mrtisEncrypt)
        ''If Not mOK Then mAllOK = False
        mOK = MyBase.ReadObjectDetails(CType(DatasetName, rtisSetting), mrtisEncrypt)
        If Not mOK Then mAllOK = False
        mOK = MyBase.ReadObjectDetails(CType(DefaultErrorLogPath, rtisSetting), mrtisEncrypt)
        If Not mOK Then mAllOK = False
        mOK = MyBase.ReadObjectDetails(CType(ServerSettingsPath, rtisSetting), mrtisEncrypt)
        If Not mOK Then mAllOK = False
        mOK = MyBase.ReadObjectDetails(CType(UpdateManifestFilePath, rtisSetting), mrtisEncrypt)
        If Not mOK Then mAllOK = False
        ''mOK = MyBase.ReadObjectDetails(CType(AppExtensionDLL, rtisSetting), mrtisEncrypt)
        ''If Not mOK Then mAllOK = False
        mOK = MyBase.ReadObjectDetails(CType(DataSetID, rtisSetting), mrtisEncrypt)
        If Not mOK Then mAllOK = False

        mrtisEncrypt = Nothing
      Else
        mOK = False
      End If
    Else
      'Set defaults
      'MainConn.ServerName = 

      'Save as is
      'mAllOK = WriteDetails(vFilename)
      mAllOK = False
    End If
      Return mAllOK
  End Function

  Public Overrides Function WriteDetails(Optional ByVal vFilename As String = "") As Boolean
    Dim mrtisEncrypt As rtisEncrypt
    Dim mOK As Boolean
    Dim mAllOK As Boolean = True
    mrtisEncrypt = New rtisEncrypt(cEncryptionKey, cEncryptionIV)

    mOK = MyBase.WriteObjectDetails(CType(MainConn, rtisSetting), mrtisEncrypt)
    If Not mOK Then mAllOK = False
    ''mOK = MyBase.WriteObjectDetails(CType(TestConn, rtisSetting), mrtisEncrypt)
    ''If Not mOK Then mAllOK = False
    mOK = MyBase.WriteObjectDetails(CType(DatasetName, rtisSetting), mrtisEncrypt)
    If Not mOK Then mAllOK = False
    mOK = MyBase.WriteObjectDetails(CType(DefaultErrorLogPath, rtisSetting), mrtisEncrypt)
    If Not mOK Then mAllOK = False
    mOK = MyBase.WriteObjectDetails(CType(ServerSettingsPath, rtisSetting), mrtisEncrypt)
    If Not mOK Then mAllOK = False
    mOK = MyBase.WriteObjectDetails(CType(UpdateManifestFilePath, rtisSetting), mrtisEncrypt)
    If Not mOK Then mAllOK = False
    ''mOK = MyBase.WriteObjectDetails(CType(AppExtensionDLL, rtisSetting), mrtisEncrypt)
    ''If Not mOK Then mAllOK = False
    mOK = MyBase.WriteObjectDetails(CType(DataSetID, rtisSetting), mrtisEncrypt)
    If Not mOK Then mAllOK = False

    If mAllOK Then mAllOK = MyBase.SaveToFile(vFilename)

    mrtisEncrypt = Nothing
    Return mAllOK
  End Function

  Public Function AreSettingsLoaded() As Boolean
    Dim mOK As Boolean
    If Me.FileName Is Nothing Then
      mOK = False
    ElseIf Me.FileName.Length = 0 Then
      mOK = False
    ElseIf MainConn Is Nothing Then
      mOK = False
    ElseIf MainConn.DatabaseName Is Nothing Then
      mOK = False
    ElseIf MainConn.DatabaseName.Length = 0 Then
      mOK = False
    Else
      mOK = True
    End If
    Return mOK
  End Function

  Public Function AreSettingsLocal() As Boolean
    Dim mOK As Boolean
    If Me.FileName Is Nothing Then
      mOK = False
    ElseIf Me.FileName.Length = 0 Then
      mOK = False
    ElseIf ServerSettingsPath Is Nothing Then
      mOK = False
    ElseIf ServerSettingsPath.SettingValue.Length = 0 Then
      mOK = False
    ElseIf ServerSettingsPath.SettingValue.ToLower = "local" Then
      mOK = True
    ElseIf ServerSettingsPath.SettingValue.ToLower = "server" Then
      mOK = False
    Else
      mOK = False
    End If
    Return mOK
  End Function

  Public Sub SetDefaultConnectionDetails()
    '' Optionally can use to initialise the connection details for new Local init files
    MainConn.ServerName = "DefaultServer"
    MainConn.UserName = "DefaultUser"
    MainConn.Password = "password"
    MainConn.DatabaseName = "DefaultDatabase"
    MainConn.Protocol = ConnProtocols.SQL2000
  End Sub


  Public Function EncryptString(ByVal vPlainText As String) As String
    Dim mrtisEncrypt As New rtisEncrypt(cEncryptionKey, cEncryptionIV)
    EncryptString = mrtisEncrypt.EncryptString(vPlainText)
    mrtisEncrypt = Nothing
  End Function

  ''Public Function DecrpytString(ByVal vCodedText As String) As String
  ''  Dim mrtisEncrypt As New rtisEncrypt(cEncryptionKey, cEncryptionIV)
  ''  DecrpytString = mrtisEncrypt.DecryptString(vCodedText)
  ''  mrtisEncrypt = Nothing
  ''End Function
End Class
