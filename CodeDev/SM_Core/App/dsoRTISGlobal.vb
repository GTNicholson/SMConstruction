Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB

Public Class dsoRTISGlobal
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New()
    pDBConn = rDBConn
  End Sub

  Public Property DBConn() As clsDBConnBase
    Get
      DBConn = pDBConn

    End Get
    Set(ByVal value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Function LoadEmailSettings(ByRef vEmailSettings As RTIS.EmailLib.clsEmailSettings, ByVal vEmailSettingsID As Integer) As Boolean
    Dim mIsNewConnection As Boolean
    Dim mdto As New RTIS.WorkflowCore.dtoEmailSettings(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect(mIsNewConnection) Then

        mOK = mdto.LoadEmailSettings(vEmailSettings, vEmailSettingsID)
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mIsNewConnection Then
        pDBConn.Disconnect()
      End If
      mdto = Nothing
    End Try

    Return mOK
  End Function

  Public Function LoadGlobalDefaults(ByRef rRTISGlobal As AppRTISGlobal) As Boolean
    Dim mIsNewConnection As Boolean
    Dim mReader As IDataReader = Nothing
    Dim mSQL As String
    Dim mTempRead As String
    Dim mReadOK As Boolean = False
    ''TODO - Extend to load different defaults for different datasets, e.g. LIVE, UAT, TRAINING, STANDBY, DEVELOPMENT
    Try
      If pDBConn.Connect(mIsNewConnection) Then
        mSQL = "Select DefaultExportPath, AuxFilePath, SharedUserFilePath, ErrorLogPath, VersionLogFile,PodioPath,EmailSettingsID FROM RTISGlobal Where RTISGlobalID = " & rRTISGlobal.SessionDataSet
        mReader = pDBConn.LoadReader(mSQL)
        If mReader.Read Then
          mTempRead = clsDBConnBase.DBReadString(mReader, "DefaultExportPath")
          ''If mTempRead.Length > 0 Then rRTISGlobal.DefaultExportPath = mTempRead.Trim
          UpdateStandardFolder(rRTISGlobal, rRTISGlobal.DefaultExportPath, mTempRead)

          mTempRead = clsDBConnBase.DBReadString(mReader, "AuxFilePath")
          ''If mTempRead.Length > 0 Then rRTISGlobal.AuxFilePath = mTempRead.Trim
          UpdateStandardFolder(rRTISGlobal, rRTISGlobal.AuxFilePath, mTempRead)

          mTempRead = clsDBConnBase.DBReadString(mReader, "SharedUserFilePath")
          'If mTempRead.Length > 0 Then rRTISGlobal.SharedUserFilePath = mTempRead.Trim
          UpdateStandardFolder(rRTISGlobal, rRTISGlobal.SharedUserFilePath, mTempRead)

          mTempRead = clsDBConnBase.DBReadString(mReader, "ErrorLogPath")
          'If mTempRead.Length > 0 Then rRTISGlobal.SharedUserFilePath = mTempRead.Trim
          UpdateStandardFolder(rRTISGlobal, rRTISGlobal.ErrorLogPath, mTempRead)

          rRTISGlobal.VersionLogFile = clsDBConnBase.DBReadString(mReader, "VersionLogFile")

          rRTISGlobal.EmailSettingsID = clsDBConnBase.DBReadInt32(mReader, "EmailSettingsID")

          mTempRead = clsDBConnBase.DBReadString(mReader, "PodioPath")
          ''If mTempRead.Length > 0 Then rRTISGlobal.DefaultExportPath = mTempRead.Trim
          rRTISGlobal.PodioPath = mTempRead

          mReadOK = True
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw

    Finally
      If Not mReader Is Nothing Then
        mReader.Close()
        mReader = Nothing
      End If

      If mIsNewConnection Then
        pDBConn.Disconnect()
      End If
    End Try
    Return mReadOK
  End Function

  Private Sub UpdateStandardFolder(ByRef rRTISGlobal As AppRTISGlobal, ByRef rPathToSet As String, ByVal rUpdateString As String)
    If rUpdateString.Trim.Length > 0 Then
      Select Case rUpdateString.Trim.ToLower
        Case "localsettingsfolder"
          rPathToSet = rRTISGlobal.LocalSettingsPath
        Case "serversettingsfolder"
          rPathToSet = rRTISGlobal.AppSettingsPath
        Case "applicationexefolder"
          rPathToSet = System.AppDomain.CurrentDomain.BaseDirectory()  ''System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
        Case Else
          rPathToSet = rUpdateString.Trim
      End Select
    End If
  End Sub

  Public Function LoadEmailTemplate(ByRef vEmailTemplate As dmEmailTemplate, ByVal vTemplate As eEmailTemplate) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As New dtoEmailTemplate(pDBConn)
    Try
      If pDBConn.Connect() Then
        mRetVal = mdto.LoadEmailTemplate(vEmailTemplate, vTemplate)
      Else
        mRetVal = False
      End If
    Catch ex As Exception
      mRetVal = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally

      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing
    End Try

    Return mRetVal
  End Function


  ''Public Function LoadInMemoryCollections() As Boolean
  ''  Dim mIsNewConnection As Boolean
  ''  ''Dim mReader As IDataReader
  ''  ''Dim mSQL As String
  ''  Dim mReadOK As Boolean = False

  ''  Try
  ''    If pDBConn.Connect(mIsNewConnection) Then

  ''      mReadOK = True

  ''    End If
  ''  Catch ex As Exception
  ''  Finally
  ''    If mIsNewConnection Then
  ''      pDBConn.Disconnect()
  ''    End If
  ''  End Try
  ''  Return mReadOK
  ''End Function

End Class


