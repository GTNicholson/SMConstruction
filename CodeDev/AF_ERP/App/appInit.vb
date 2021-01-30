Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.CommonVB
Imports System.IO
Imports System.Environment
Imports RTIS.ERPCore

Public Class appInit
  '' New App Checklist - search for: TO CHECK, 
  Public Const cCLP_AppSuffix As String = "AppSuffix"   ' Add  AppSuffix=InitNameSuffix
  Public Const cCLP_DispayAllErrors As String = "DispayAllErrors"
  Public Const cDeveloperUserID As Integer = 1 ' or -1

  Shared Function StartApp(ByRef rRTISGlobal As AppRTISGlobal, ByRef rRTISUserSession As clsRTISUser) As Boolean
    Dim mDBConn As clsDBConnBase
    Dim mIsLoggedOn As Boolean = False
    Dim mErrorLogFile As String
    Dim mInitOK As Boolean
    Dim mCmdLineParam As String = ""
    Dim mCLParamDisplayErrors As String = ""
    Try
      '1. Initialise Error Handler
      clsErrorHandler.InitErrorHandler(False, "", My.Application.Info.ProductName, My.Application.Info.Version.ToString)
      clsErrorHandler.GetInstance.DisplayExceptionDelegate = AddressOf frmDisplayError.DisplayErrorDetails
      '2. Set Global default settings
      rRTISGlobal.SetDefaultAppProperties() 'Coded defaults, before possible overrides by ini settings file and/or database

      '3. Check command line parameter (Clean in case relauched from autoupdate)
      If My.Application.CommandLineArgs.Count >= 1 Then

        ''mCmdLineParam = RTIS.CommonVB.clsRTISVersionUpdate.CleanCommandLineParam(My.Application.CommandLineArgs(0))
        mCmdLineParam = RTIS.CommonVB.clsRTISVersionUpdate.GetCommandLineParam(My.Application.CommandLineArgs, cCLP_AppSuffix)
        mCLParamDisplayErrors = RTIS.CommonVB.clsRTISVersionUpdate.GetCommandLineParam(My.Application.CommandLineArgs, cCLP_DispayAllErrors)
        If RTIS.CommonVB.clsGeneralA.StringLength(mCLParamDisplayErrors & "") > 0 Then
          mCLParamDisplayErrors = Left(mCLParamDisplayErrors, 1).ToUpper
          If mCLParamDisplayErrors = "T" Or mCLParamDisplayErrors = "Y" Then
            clsErrorHandler.GetInstance.DebugErrorDisplay = True
          Else
            clsErrorHandler.GetInstance.DebugErrorDisplay = False
          End If
        End If


      End If

      '4. ReadInitFile
      mInitOK = CheckInitFile(rRTISGlobal, rRTISUserSession, mCmdLineParam, True)

      '5. CheckForUpdate
      If mInitOK Then
        '' For full Auto-Update:
        mInitOK = CheckForAppUpdate(rRTISGlobal.UpdateManifestFilePath) 'Returns false if needs to shut-down because update app being launched
        '' For updating of Aux files only call after have logged on

      End If

      '6. App overrides and extensions: LoadAppExtensionDLL
      If mInitOK Then
        'TO CHECK
        'rRTISUserSession.SetCreatedsoUserSessionDelegate(AddressOf dsoRTISUserSessionOR.CreatedsoRTISUserSession)

        'If using a compiled-in dll, e.g. 
        'rRTISGlobal.AppExtFactory = New RTIS.AppCustomise.clsAppCustomiseFactory
        'rRTISUserSession.SetCreatedsoUserSessionDelegate(rRTISGlobal.AppExtFactory.GetDelegate_CreatedsoRTISUserSession())

        'If using an external dll (e.g. as used in RTIS BI):
        ''InitAppExtensionDLL(rRTISGlobal, rRTISUserSession)
      End If

      '7. Connect
      If mInitOK Then
        mDBConn = InitDBConnection(rRTISUserSession)

        If Not mDBConn Is Nothing Then
          If mDBConn.IsConnected Then
            '8. Logon
            'ebug.Print("Logon Start")

            If appInit.UserLogon(rRTISGlobal, mDBConn) Then
              mIsLoggedOn = True

              '9. Get any global variables that are loaded from the database
              LoadGlobalDefaults(rRTISGlobal, mDBConn)

              '9b
              If CheckRefreshPin(rRTISGlobal, mDBConn, rRTISUserSession.UserID) Then
                frmRefreshPin.OpenAsModel(mDBConn, rRTISGlobal, rRTISUserSession.UserID, eRefreshPinFormMode.User)
              End If

              If rRTISUserSession.UserID = cDeveloperUserID Then
                rRTISUserSession.IsSecurityAllowAll = True
              End If
            End If
            mDBConn.Disconnect()

          End If
          mDBConn = Nothing
        End If
      End If

      ''If mInitOK Then
      ''  Dim mConn As clsDBConnBase
      ''  Dim mConnInfo As New clsConnInfo
      ''  With My.Application.RTISUserSession.SessionMainConn
      ''    mConnInfo.ConnName = "TESTAdHoc"
      ''    mConnInfo.DatabaseName = "Datim_ERP"
      ''    mConnInfo.Password = .Password
      ''    mConnInfo.Protocol = .Protocol
      ''    mConnInfo.ServerName = .ServerName
      ''    mConnInfo.UserName = .UserName
      ''  End With

      ''  mConn = My.Application.RTISUserSession.CreateAdHocDBConn(mConnInfo)
      ''  mConn.Connect()
      ''  If mConn.IsConnected Then
      ''    MsgBox("Connection OK")
      ''    mConn.Disconnect()
      ''  Else

      ''    MsgBox("NOT CONNECTED", MsgBoxStyle.Exclamation)
      ''  End If
      ''  mConn = Nothing
      ''End If

      If mIsLoggedOn Then
        '10. Reset error log path based on Global details loaded
        My.User.InitializeWithWindowsUser() 'This could already have been done in the logon user routine
        mErrorLogFile = "ErrLog_" & My.Application.Info.ProductName & "_" & My.User.Name.Replace("\", "-") & "_" & My.Computer.Name & ".txt"
        mErrorLogFile = RTIS.CommonVB.clsGeneralA.GetFileSafeName(mErrorLogFile)
        If clsGeneralA.StringLength(rRTISGlobal.ErrorLogPath) > 0 Then
          mErrorLogFile = Path.Combine(rRTISGlobal.ErrorLogPath, mErrorLogFile)
        Else
          mErrorLogFile = Path.Combine(rRTISGlobal.LocalSettingsPath, mErrorLogFile)
        End If
        clsErrorHandler.InitErrorHandler(True, mErrorLogFile, My.Application.Info.Title, My.Application.Info.Version.ToString)

        ''11. CheckForAuxFileUpdates
        CheckForAuxFileUpdates(rRTISGlobal) 'Delay to here so have any AuxFile location from the database


        Dim mESettings As New RTIS.EmailLib.clsEmailSettings

        mESettings.DelMethod = 0
        mESettings.Domain = ""
        mESettings.Password = "M6jrYk#23"
        mESettings.Port = "25"
        mESettings.SMTP = "smtp.123-reg.co.uk"
        mESettings.UseDefaultCredentials = False
        mESettings.UserName = "support@activeview.co.uk"
        mESettings.EnableSSL = False
        mESettings.SecurityProtocol = 0
        mESettings.DefaultToSpooler = False
        mESettings.SendAllToTest = True
        mESettings.AlwaysSendAsPlainText = False
        mESettings.DefaultEmailFromAddress = "support@activeview.co.uk"

        Dim mTestSendTo As String = "grahamn@rtis.co.uk"

        ''If rRTISGlobal.SessionDataSet = AppRTISGlobal.eSessionDataSet.Live Then
        ''  RTIS.WorkflowCore.clsMessageHandler.InitNoticiationHandler(rRTISGlobal.EmailSettings, rRTISUserSession, False, "DefaultTestEmail@Domain.co.uk")
        ''Else
        RTIS.WorkflowCore.clsMessageHandler.InitNoticiationHandler(mESettings, rRTISUserSession, True, "johns@rtis.co.uk")
        ''End If
        ''If rRTISUserSession.EmployeeID <> 0 Then
        ''  '' Look-up current users email address
        ''  Dim mCurrentUserEmail As String
        ''  ''TODO

        ''  RTIS.WorkflowCore.clsMessageHandler.TestSendTo = mCurrentUserEmail
        ''End If
        Select Case rRTISGlobal.SessionDataSet
          Case AppRTISGlobal.eSessionDataSet.Live

            If rRTISUserSession.EmployeeID <> 0 Then '' Set Test email address etc.
              '//Look-up current users email address
              Dim mCurrentUser As dmEmployee
              mCurrentUser = CType(rRTISGlobal.RefLists.RefIList(appRefLists.Employees), RTIS.ERPCore.colEmployees).ItemFromKey(rRTISUserSession.EmployeeID)
              If mCurrentUser IsNot Nothing Then
                rRTISGlobal.EmailSettings.DefaultEmailFromAddress = mCurrentUser.Email
                mTestSendTo = mCurrentUser.Email


              End If
            End If

            RTIS.WorkflowCore.clsMessageHandler.InitNoticiationHandler(rRTISGlobal.EmailSettings, rRTISUserSession, False, mTestSendTo)
          Case Else

            If rRTISUserSession.EmployeeID <> 0 Then '' Set Test email address etc.
              '//Look-up current users email address
              Dim mCurrentUser As dmEmployee
              mCurrentUser = CType(rRTISGlobal.RefLists.RefIList(appRefLists.Employees), RTIS.ERPCore.colEmployees).ItemFromKey(rRTISUserSession.EmployeeID)
              If mCurrentUser IsNot Nothing Then
                rRTISGlobal.EmailSettings.DefaultEmailFromAddress = mCurrentUser.Email
                mTestSendTo = mCurrentUser.Email


              End If
            End If

            RTIS.WorkflowCore.clsMessageHandler.InitNoticiationHandler(rRTISGlobal.EmailSettings, rRTISUserSession, True, mTestSendTo)
        End Select

      End If
    Catch ex As Exception
      mIsLoggedOn = False
      MsgBox("No se pudo iniciar la aplicación." & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "Error en la rutina de Start-Up")
    End Try
    Return mIsLoggedOn
  End Function

  Shared Function InitDBConnection(ByRef rRTISUserSession As clsRTISUser) As clsDBConnBase
    Dim mIsConnected As Boolean
    Dim mDBConn As clsDBConnBase
    Try

      mDBConn = rRTISUserSession.CreateMainDBConn()

      If mDBConn Is Nothing Then
        mIsConnected = False
      Else
        Try
          mIsConnected = mDBConn.Connect
        Catch Ex As Exception
                    mIsConnected = False
                    If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try

        If Not mIsConnected Then
          mDBConn = Nothing
        End If
      End If

    Catch Ex As Exception
      mIsConnected = False
      mDBConn = Nothing
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
    Return mDBConn
  End Function

  Shared Function CheckForAppUpdate(ByVal vManifestPath As String) As Boolean
    Dim mUpdatedRequired As Boolean
    'If Not mLauchedFromAutoUpdate Then
    ''mReadOK = CheckForUpdatedApplicationExe(mRTISSettingFile.UpdateManifestFilePath)
    If vManifestPath Is Nothing Or String.IsNullOrEmpty(vManifestPath) Then
      vManifestPath = "NONE"
    End If
    If Debugger.IsAttached Or vManifestPath.ToUpper = "NONE" Then
      '' e.g. from IDE - don't run the update routine
      mUpdatedRequired = False
    Else
      Dim mCmdLine As String = ""
      mUpdatedRequired = clsRTISVersionUpdate.CheckUpdate(Application.ExecutablePath, Application.ProductVersion, vManifestPath, mCmdLine)

    End If
    Return Not mUpdatedRequired
  End Function

  Shared Sub InitAppExtensionDLL(ByRef rRTISGlobal As AppRTISGlobal, ByRef rRTISUserSession As clsRTISUser)
    'TO CHECK
    ''If need to define extensions as an external dll, add rRTISGlobal.AppExtensionDLLFile property
    ''If RTIS.CommonVB.clsGeneralA.StringLength(rRTISGlobal.AppExtensionDLLFile) > 0 Then
    ''  Dim mAppExtFactory As clsAppExtensionFactory
    ''  mAppExtFactory = clsAppExtensionFactory.GetAppExtensionFactory(rRTISGlobal.AppExtensionDLLFile, AppRTISGlobal.cAppExtensionClassName)
    ''  If Not mAppExtFactory Is Nothing Then
    ''    rRTISUserSession.SetCreatedsoUserSessionDelegate(mAppExtFactory.GetDelegate_CreatedsoRTISUserSession())
    ''    ''TODO - Get LookUpList ??
    ''    Dim mRefList As colRefLists
    ''    mRefList = mAppExtFactory.GetRefLists
    ''    If Not mRefList Is Nothing Then
    ''      'AppRTISGlobal.ref
    ''      rRTISGlobal.SetRefLists(mRefList)
    ''    End If
    ''  End If
    ''End If
  End Sub

  Shared Function CheckInitFile(ByRef rRTISGlobal As AppRTISGlobal, ByRef rRTISUserSession As clsRTISUser, ByVal vCLOption As String, ByVal vAllowSetupForNewLocalFile As Boolean) As Boolean
    Dim mRTISSettingFile As New clsRTISAppSettings
    Dim mIsConnected As Boolean
    Dim mPath As String
    Dim mLocalSettings As Boolean
    Dim mReadOK As Boolean
    Dim mConnInfoFile As String
    Dim mServerFileFoundOK As Boolean = False
    Try

      mConnInfoFile = My.Settings.ConnInfoFile.Trim 'Application Settings entry required

      If RTIS.CommonVB.clsGeneralA.StringLength(vCLOption) > 0 Then
        rRTISGlobal.AppTitle = My.Application.Info.Title & " (" & vCLOption.Trim & ")"
        mConnInfoFile = mConnInfoFile.Replace(".xml", "_" & vCLOption.Trim & ".xml")
      Else
        rRTISGlobal.AppTitle = My.Application.Info.Title
      End If

      rRTISGlobal.SetAppSettingsPathToLocal(My.Application.Info.ProductName) 'Could use an alternative name here
      rRTISGlobal.ConnInfoFileName = mConnInfoFile

      If InStr(Microsoft.VisualBasic.Command() & "", "##!!EditInit!!##") > 0 Then
        ''mRTISSettingFile.FileName = Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName)
        ''mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName))
        ''rRTISGlobal.ConfigureSettingsFile(mRTISSettingFile)
        ''If mRTISSettingFile.ServerSettingsPath.SettingValue = "" Then mRTISSettingFile.ServerSettingsPath.SettingValue = "local"
        ''If Not mRTISSettingFile.AreSettingsLocal Then
        ''  'mRTISSettingFile.ServerSettingsPath.SettingValue

        ''End If
        CheckSettingWithPrompt(rRTISGlobal)
      End If

      If mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName)) Then


        ''rRTISGlobal.ConfigureSettingsFile(mRTISSettingFile)

        If mRTISSettingFile.ServerSettingsPath.SettingValue = "" Then mRTISSettingFile.ServerSettingsPath.SettingValue = "local"
        If Not mRTISSettingFile.AreSettingsLocal Then

          '' check file can be found ??
          If Not System.IO.File.Exists(Path.Combine(mRTISSettingFile.ServerSettingsPath.SettingValue, rRTISGlobal.ConnInfoFileName)) Then
            mPath = "" 'InputBox("Please enter server settings path (or 'local')", "RTIS_BI Set-Up")
            If MsgBox("El archivo de configuración no puede ser abierto - ¿Le gustaría cambiar las configuraciones del servidor que se está utilizando?" & vbCrLf & "(Nota:
Únicamente se debe de hacer esto si estás seguro que las configuraciones del servidor han cambiado, de lo contrario, por favor cancele y verifique que estás conectado a la red.)", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
              ''If MsgBox("Change to local settings?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
              ''  mRTISSettingFile.ServerSettingsPath.SettingValue = "local"
              ''  mRTISSettingFile.WriteDetails()
              ''Else
              If RTIS.CommonVB.clsGeneralA.GetFolderName(mPath, "Por favor, seleccione la carpeta de las configuraciones del servidor", "C:\") = DialogResult.OK Then
                'If mPath.Length > 0 Then

                If System.IO.File.Exists(Path.Combine(mPath, rRTISGlobal.ConnInfoFileName)) Then
                  mRTISSettingFile.ServerSettingsPath.SettingValue = mPath
                  mServerFileFoundOK = True
                  ''If mPath.Trim.ToLower <> "local" Then
                  rRTISGlobal.AppSettingsPath = mPath
                  ''Else
                  ''  ''?? Add defaults ??
                  ''  mLocalSettings = True
                  ''End If
                  mRTISSettingFile.FileName = Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName)
                  mRTISSettingFile.WriteDetails()
                Else
                  '' will have to try again
                  mServerFileFoundOK = False
                End If
              Else
                '' will have to try again
                mServerFileFoundOK = False
              End If
              ''End If
            Else
              mServerFileFoundOK = False
            End If
          Else
            rRTISGlobal.AppSettingsPath = mRTISSettingFile.ServerSettingsPath.SettingValue
            mServerFileFoundOK = True
          End If
        Else
          mLocalSettings = True
        End If
      Else
        '' New Local Settings File
        mRTISSettingFile.ServerSettingsPath.SettingValue = "\\SERVER\RTIS\RTIS_BI\SETTINGS"
        If MsgBox("¿Le gustaría enlazar una configuración existente? (Yes)" & vbCrLf & "(Ingrese 'No' Si esta es una nueva instalación o es local/prueba.)", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
          mPath = "" ' InputBox("Please enter server settings path (or 'local')", "RTIS_BI Set-Up")
          'If mPath.Length > 0 Then
          If RTIS.CommonVB.clsGeneralA.GetFolderName(mPath, "Por favor, ingrese la ruta de las configuraciones del servidor (o 'local')", "C:\") = DialogResult.OK Then
            If System.IO.File.Exists(Path.Combine(mPath, rRTISGlobal.ConnInfoFileName)) Then
              mRTISSettingFile.ServerSettingsPath.SettingValue = mPath
              If mPath.Trim.ToLower <> "local" Then
                rRTISGlobal.AppSettingsPath = mPath
              End If
              mRTISSettingFile.FileName = Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName)
              mRTISSettingFile.WriteDetails()
            Else
              mServerFileFoundOK = False
            End If

          Else
            mPath = ""
            mServerFileFoundOK = False
          End If
        Else
          mPath = "local"
          mRTISSettingFile.ServerSettingsPath.SettingValue = mPath
          mRTISSettingFile.FileName = Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName)
          mRTISSettingFile.WriteDetails()
        End If
      End If

      If mRTISSettingFile.AreSettingsLocal Then
        'Local
        mLocalSettings = True
        If mRTISSettingFile.AreSettingsLoaded Then
          mReadOK = True
        Else
          '' New local, set any defaults here
          mRTISSettingFile.SetDefaultConnectionDetails()
          If vAllowSetupForNewLocalFile Then
            If rRTISGlobal.ConfigureSettingsFile(mRTISSettingFile) Then
              mReadOK = True
            End If
          Else
            If mRTISSettingFile.AreSettingsLoaded Then
              mRTISSettingFile.WriteDetails()
              mReadOK = True
            End If
          End If
        End If
      Else
        mRTISSettingFile = New clsRTISAppSettings
        If mServerFileFoundOK AndAlso mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.AppSettingsPath, rRTISGlobal.ConnInfoFileName)) Then
          ''OK
          If mRTISSettingFile.AreSettingsLoaded Then
            mReadOK = True
          Else
            mReadOK = False
            '' TODO - prompt to check the server path ??
            MsgBox("Incapar de leer los detalles de conexión del archivo de conexión del servidor.", MsgBoxStyle.Exclamation, "Error en la rutina de inicialización")
          End If
        Else
          mRTISSettingFile.ServerSettingsPath.SettingValue = "(Server Details)"
          mReadOK = False
          '' TODO - prompt to check the server path ??
          MsgBox("Incapaz de leer el archivo de conexión del servidor, por favor, verifique que se encuentra conectado en red.", MsgBoxStyle.Exclamation, "Error en la rutina de inicialización")

        End If
      End If
    Catch Ex As Exception
      ''MsgBox(Ex.ToString, MsgBoxStyle.Exclamation, "Error in initialisation routine")
      mIsConnected = False
      ''MsgBox(Ex.ToString, MsgBoxStyle.Exclamation, "Error in initialisation DBConnect routine")
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


    If mReadOK = True Then
      rRTISUserSession.SessionMainConn = mRTISSettingFile.MainConn

      '' TO CHECK - If add any other Global settings to the ini file, copy to RTISGLobal here

      rRTISGlobal.UpdateManifestFilePath = mRTISSettingFile.UpdateManifestFilePath.SettingValue

      ''rRTISGlobal.AppExtensionDLLFile = mRTISSettingFile.AppExtensionDLL.SettingValue

      If mRTISSettingFile.DatasetName.SettingValue.Trim.Length = 0 Then
        rRTISGlobal.DataSetName = mRTISSettingFile.MainConn.DatabaseName 'Could give this another name
      Else
        rRTISGlobal.DataSetName = mRTISSettingFile.DatasetName.SettingValue.Trim
      End If

      If mRTISSettingFile.DataSetID.SettingValue <> 0 Then
        rRTISGlobal.SessionDataSet = mRTISSettingFile.DataSetID.SettingValue
      End If

    End If
    If Not mRTISSettingFile Is Nothing Then mRTISSettingFile = Nothing
    Return mReadOK
  End Function


  Shared Function UserLogon(ByRef rRTISGlobal As AppRTISGlobal, ByRef rDBConn As clsDBConnBase)
    Dim mIsLoggedOn As Boolean
    Try
      If rDBConn.IsConnected Then

        rDBConn.RTISUser.IsSecurityAllowAll = False 'True 'While testing
        rDBConn.RTISUser.UserName = My.Settings.LastUserName

        My.User.InitializeWithWindowsUser()
        rDBConn.RTISUser.NTName = My.User.Name
        rDBConn.RTISUser.PCName = My.Computer.Name
        rDBConn.RTISUser.HostApplication = My.Application.Info.AssemblyName
        rDBConn.RTISUser.HostVersion = My.Application.Info.Version.ToString()

        If rRTISGlobal.AppExtFactory IsNot Nothing Then
          mIsLoggedOn = rRTISGlobal.AppExtFactory.DisplayLoginUser(rDBConn, rRTISGlobal.AppTitle)
        Else
          mIsLoggedOn = RTIS.Elements.frmLogin.DisplayLoginUser(rDBConn, rRTISGlobal.AppTitle) ' True ' TODO pMainDB.RTISUser.LoginUserPrompt
        End If

        If mIsLoggedOn Then
          '' ?? Checks based on SessionDataSet and permissions !

          My.Settings.LastUserName = rDBConn.RTISUser.UserName
          My.Settings.Save()

        Else
          mIsLoggedOn = False
        End If
      Else
        mIsLoggedOn = False
      End If
    Catch Ex As Exception
      ''MsgBox(Ex.ToString, MsgBoxStyle.Exclamation, "Error in initialisation DBConnect routine")
      mIsLoggedOn = False
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    Return mIsLoggedOn
  End Function

  Shared Function LoadGlobalDefaults(ByRef rRTISGlobal As AppRTISGlobal, ByRef rMainDB As clsDBConnBase) As Boolean
    Dim mdsoGlobal As New dsoRTISGlobal(rMainDB)
    Dim mdsoAppRefLists As New dsoAppRefLists(rMainDB)
    Dim mdsoCostBook As New dsoCostBook(rMainDB)
    Dim mCB As New dmCostBook
    Dim mAllOK As Boolean

    mAllOK = mdsoGlobal.LoadGlobalDefaults(rRTISGlobal)
    ''mAllOK = mdsoGlobal.LoadInMemoryCollections(rRTISGlobal) And mAllOK

    mAllOK = mdsoAppRefLists.LoadAllLists(rRTISGlobal.RefLists) And mAllOK


    rRTISGlobal.StockItemRegistry.LoadInitial()

    rRTISGlobal.ProductRegistry.LoadInitial()

    rRTISGlobal.EmailSettings = New RTIS.EmailLib.clsEmailSettings
    mAllOK = mdsoGlobal.LoadEmailSettings(rRTISGlobal.EmailSettings, rRTISGlobal.EmailSettingsID)

    mdsoCostBook.LoadDefaultCostBookDown(mCB)
    rRTISGlobal.DefaultCostBook = mCB

    mdsoGlobal = Nothing
    mdsoAppRefLists = Nothing

    Return mAllOK
  End Function

  Shared Sub CheckSettingWithPrompt(ByRef rRTISGlobal As AppRTISGlobal)
    Dim mRTISSettingFile As New clsRTISAppSettings
    Dim mResult As MsgBoxResult
    Dim mView As Boolean = True
    mRTISSettingFile = New clsRTISAppSettings
    mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName))
    If Not mRTISSettingFile.AreSettingsLocal Then
      If My.Application.RTISUserSession.ActivityPermission(eActivityCode.Configuration) >= ePermissionCode.ePC_Full Then
        mResult = MsgBox("Ver/editar arhivo local (Y) o Archivo de Servidor (N)?", MsgBoxStyle.YesNoCancel)
        If mResult = MsgBoxResult.No Then
          '' TODO - Check credential or prompt for a password

          mRTISSettingFile = New clsRTISAppSettings
          mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.AppSettingsPath, rRTISGlobal.ConnInfoFileName))
          mView = True
        ElseIf mResult = MsgBoxResult.Yes Then
          mView = True
        Else
          mView = False
        End If
      End If
    End If
    If mView Then
      If frmRTISSettings.DisplayAsModal(mRTISSettingFile, rRTISGlobal.DataSetName) = Windows.Forms.DialogResult.Yes Then
        mRTISSettingFile.WriteDetails()
      End If
    End If
    mRTISSettingFile = Nothing
  End Sub

  Shared Sub CheckSettings(ByRef rRTISGlobal As AppRTISGlobal)
    Dim mRTISSettingFile As New clsRTISAppSettings
    mRTISSettingFile = New clsRTISAppSettings
    mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.AppSettingsPath, rRTISGlobal.ConnInfoFileName))
    If frmRTISSettings.DisplayAsModal(mRTISSettingFile, rRTISGlobal.DataSetName) Then
      mRTISSettingFile.WriteDetails()
    End If
    mRTISSettingFile = Nothing
  End Sub

  Shared Sub CheckServerSettings(ByRef rRTISGlobal As AppRTISGlobal)
    Dim mRTISSettingFile As New clsRTISAppSettings
    mRTISSettingFile = New clsRTISAppSettings
    mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName))
    If Not mRTISSettingFile.AreSettingsLocal Then
      mRTISSettingFile = New clsRTISAppSettings
      mRTISSettingFile.ReadDetails(System.IO.Path.Combine(AppRTISGlobal.GetInstance.AppSettingsPath, AppRTISGlobal.GetInstance.ConnInfoFileName))
      If frmRTISSettings.DisplayAsModal(mRTISSettingFile, rRTISGlobal.DataSetName) Then
        mRTISSettingFile.WriteDetails()
      End If
    Else
      MsgBox("Las configuraciones están configuradas localmente")
    End If
    mRTISSettingFile = Nothing
  End Sub


  Shared Sub CheckLocalSettings(ByRef rRTISGlobal As AppRTISGlobal)
    Dim mRTISSettingFile As New clsRTISAppSettings
    mRTISSettingFile = New clsRTISAppSettings
    mRTISSettingFile.ReadDetails(Path.Combine(rRTISGlobal.LocalSettingsPath, rRTISGlobal.ConnInfoFileName))
    If frmRTISSettings.DisplayAsModal(mRTISSettingFile) = DialogResult.Yes Then
      mRTISSettingFile.WriteDetails()
    End If
    mRTISSettingFile = Nothing
  End Sub

  Shared Sub CheckForAuxFileUpdates(ByRef rRTISGlobal As AppRTISGlobal) 'Use this if not doing a full Auto-Update, but just want to update AuxFiles
    Dim mUpdateFiles As New RTIS.CommonVB.clsUpdateFiles
    Try
      If rRTISGlobal.UpdateManifestFilePath.Trim.Length > 0 Then
        If IO.File.Exists(rRTISGlobal.UpdateManifestFilePath) Then
          mUpdateFiles.ManifestFile = rRTISGlobal.UpdateManifestFilePath
          mUpdateFiles.UpdateDestinationPath = rRTISGlobal.AuxFilePath ' "C:\RTIS\TestUpdate\DestinationFolder"
          mUpdateFiles.DisplayDebugMessages = clsRTISVersionUpdate.CheckCommandLineForDisplayMessages(Microsoft.VisualBasic.Command() & "")
          mUpdateFiles.UpdateFileGroup(RTIS.CommonVB.clsUpdateFiles.cAuxFilesNode)
        End If
      End If
    Catch Ex As Exception
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Public Shared Function CheckRefreshPin(ByRef rRTISGlobal As AppRTISGlobal, ByRef rDBConn As clsDBConnBase, ByVal vUserID As Integer) As Boolean
    Dim mRefresh As Boolean = False
    Dim mdsoAdminUSer As New dsoAdminUser(rDBConn, rRTISGlobal)
    mRefresh = mdsoAdminUSer.CheckRefreshPin(vUserID)
    mdsoAdminUSer = Nothing
    Return mRefresh
  End Function

  ''Shared Sub LogonTimedOut()
  ''  Dim mIsLoggedOn As Boolean = False
  ''  Dim mDBConn As clsDBConnBase
  ''  Try
  ''    If MsgBox("Inactive time has expired - please login again (no to close the application)", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
  ''      mDBConn = My.Application.RTISUserSession.CreateMainDBConn

  ''      If Not mDBConn Is Nothing Then
  ''        If mDBConn.Connect Then
  ''          If appInit.UserLogon(AppRTISGlobal.GetInstance, mDBConn) Then
  ''            If My.Application.RTISUserSession.ActivityPermission(eActivityCode.UserConfig) = ePermissionCode.ePC_Full Then
  ''              mIsLoggedOn = True
  ''            Else
  ''              If My.Application.RTISUserSession.ActivityPermission(eActivityCode.Configuration) = ePermissionCode.ePC_Full Then
  ''                mIsLoggedOn = True
  ''              Else
  ''                mIsLoggedOn = False
  ''                MsgBox("This application is not available for your user group profile - the application will now close", MsgBoxStyle.Information, Application.ProductName)
  ''              End If
  ''            End If
  ''          End If
  ''        End If
  ''      End If
  ''    End If
  ''  Catch Ex As Exception
  ''    MsgBox(Ex.Message)
  ''    mIsLoggedOn = False
  ''  Finally
  ''    If Not mDBConn Is Nothing Then
  ''      If mDBConn.IsConnected Then mDBConn.Disconnect()
  ''      mDBConn = Nothing
  ''    End If
  ''  End Try

  ''  If mIsLoggedOn Then
  ''    'Need to resume
  ''    'TODO - Check if a different user!
  ''    clsInactiveTimeout.GetInstance.StartIdleCheck()
  ''  Else
  ''    'My.Application.CloseUserOnApplicationShutdown()

  ''    Application.OpenForms("frmTabbedMDI").Close()

  ''    'End
  ''  End If
  ''End Sub

End Class
