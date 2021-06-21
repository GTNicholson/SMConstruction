Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB.clsGeneralA
Imports System.Net

Public Class dtoEmailSettings : Inherits dtoBase
  Private pEmailSettings As RTIS.EmailLib.clsEmailSettings
  Private pEmailSettingsID As Integer

  Public Sub New(ByRef rDBSource As clsDBConnBase)
    MyBase.New(rDBSource)
    SetTableDetails()
  End Sub

  Protected Overrides Sub SetTableDetails()
    pTableName = "EmailSettings"
    pKeyFieldName = "EmailSettingsID"
    pUseSoftDelete = False
    pRowVersionColName = "rowversion"
    pConcurrencyType = eConcurrencyType.CompareAllValues
  End Sub

  Public Overrides Property ObjectKeyFieldValue() As Integer
    Get
      ObjectKeyFieldValue = pEmailSettingsID
    End Get
    Set(ByVal value As Integer)
      pEmailSettingsID = value
    End Set
  End Property

  Public Overrides Property IsDirtyValue() As Boolean
    Get
      IsDirtyValue = True
    End Get
    Set(ByVal value As Boolean)
    End Set
  End Property

  Public Overrides Property RowVersionValue() As ULong
    Get
      RowVersionValue = 0
    End Get
    Set(ByVal value As ULong)
    End Set
  End Property

  Public Overrides Sub ObjectToSQLInfo(ByRef rFieldList As String, ByRef rParamList As String, ByRef rParameterValues As System.Data.IDataParameterCollection, ByVal vSetList As Boolean)

  End Sub


  Public Overloads Overrides Function ReaderToObject(ByRef rDataReader As IDataReader) As Boolean
    Dim mOK As Boolean
    Try
      If pEmailSettings Is Nothing Then pEmailSettings = New RTIS.EmailLib.clsEmailSettings
      With pEmailSettings
        .DelMethod = DBReadByte(rDataReader, "DelMethod")
        .Domain = DBReadString(rDataReader, "Domain")
        .Password = DBReadString(rDataReader, "Password")
        .PickupDirectoryLocation = DBReadString(rDataReader, "PickupDirectoryLocation")
        .Port = DBReadInt32(rDataReader, "Port")
        .SMTP = DBReadString(rDataReader, "SMTP")
        .UseDefaultCredentials = DBReadBoolean(rDataReader, "UseDefaultCredentials")
        .UserName = DBReadString(rDataReader, "UserName")
        .EnableSSL = DBReadBoolean(rDataReader, "EnableSSL")
        If DBReadBoolean(rDataReader, "TLS") Then
          ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        End If
      End With
      mOK = True
    Catch Ex As Exception
      If clsErrorHandler.HandleError(Ex, clsErrorHandler.PolicyDataLayer) Then Throw
      mOK = False
    Finally

    End Try
    Return mOK
  End Function

  Protected Overrides Function SetObjectToNew() As Object
    pEmailSettings = New RTIS.EmailLib.clsEmailSettings
    Return pEmailSettings
  End Function

  Public Function LoadEmailSettings(ByRef rEmailSettings As RTIS.EmailLib.clsEmailSettings, ByVal vEmailSettingsID As Integer, Optional ByRef rRetMsg As String = "") As Boolean
    Dim mOK As Boolean
    ObjectKeyFieldValue = vEmailSettingsID

    mOK = LoadObject(vEmailSettingsID)
    If mOK Then
      rEmailSettings = pEmailSettings
    Else
      rEmailSettings = Nothing
    End If
    pEmailSettings = Nothing
    Return mOK
  End Function

End Class
