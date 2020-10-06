Imports RTIS.Elements
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class AppRTISGlobal : Inherits RTIS.Elements.clsRTISGlobal
  'Extend for generalisations using interfaces
  Implements RTIS.CommonVB.iRefListHolder
  ''Public Const cAppExtensionClassName As String = "RTIS.AppCustomise.clsAppCustomiseFactory" 'Must inherit from clsAppExtensionFactory, or one of it's sub-classes
  Const cEncryptionKey As String = "C1TYUTdw34P987WDR" 'Make unique for project?
  Const cEncryptionIV As String = "RTISGLOBALSTART"    'Make unique for project?

  Private Shared mInstance As AppRTISGlobal
  Private pEmailSettings As RTIS.EmailLib.clsEmailSettings
  Private pEmailSettingsID As Integer

  Private pSessionDataSet As eSessionDataSet

  Private pPodioPath As String

  ''Private pAppExtensionDLLFile As String
  Private pAppExtFactory As clsAppExtensionFactory
  Private pRefLists As RTIS.CommonVB.colRefLists
  Private pHostCompanys As colHostCompanys

  Private pClipBoard As clsClipBoard

  ''Private pHostCompaiys As host
  Private newPropertyValue As String

  Private pStockItemRegistry As clsStockItemRegistryBase


  Public Sub ProcessUnhandledException(ByRef rException As Exception, ByVal rLogError As Boolean, ByVal rDisplayError As Boolean)
    If rDisplayError Then
      clsErrorHandler.HandleError(rException, clsErrorHandler.PolicyUserInterface, "RTISGLobal- ProcessUnhandledException: ")
    ElseIf rLogError Then
      clsErrorHandler.HandleError(rException, clsErrorHandler.PolicyAppService, "RTISGLobal- ProcessUnhandledException: ")
    End If
  End Sub

  Public Enum eSessionDataSet
    Live = 1
    UAT = 2
    Training = 3
    Standby = 4
    DeveloperA = 5

  End Enum

  Public Shared Function CreateInstance() As AppRTISGlobal
    If mInstance Is Nothing Then
      mInstance = New AppRTISGlobal
    End If
    Return mInstance
  End Function

  Public Shared Sub KillInstance()
    If mInstance IsNot Nothing Then
      mInstance = Nothing
    End If
  End Sub

  Public Shared Function GetInstance() As AppRTISGlobal
    Return mInstance
  End Function

  Private Sub New()
    MyBase.New()
    pRefLists = New appRefLists 'Need project sub class defined
    pSessionDataSet = eSessionDataSet.Live
    pClipBoard = New clsClipBoard
  End Sub

  Public Property SessionDataSet() As eSessionDataSet
    Get
      SessionDataSet = pSessionDataSet
    End Get
    Set(ByVal value As eSessionDataSet)
      pSessionDataSet = value
    End Set
  End Property

  Public ReadOnly Property HostCompanys As colHostCompanys
    Get
      Return pHostCompanys
    End Get
  End Property

  Public Sub StockItemRegistryInitialise(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pStockItemRegistry = New clsStockItemRegistryComp(rDBConn)
  End Sub

  Public ReadOnly Property StockItemRegistry As clsStockItemRegistryComp
    Get
      Return pStockItemRegistry
    End Get
  End Property


  Public Property EmailSettings As RTIS.EmailLib.clsEmailSettings
    Get
      Return pEmailSettings
    End Get
    Set(value As RTIS.EmailLib.clsEmailSettings)
      pEmailSettings = value
    End Set
  End Property

  Public Property EmailSettingsID As Integer
    Get
      Return pEmailSettingsID
    End Get
    Set(value As Integer)
      pEmailSettingsID = value
    End Set
  End Property


  Public Property PodioPath() As String
    Get
      Return pPodioPath
    End Get
    Set(ByVal value As String)
      pPodioPath = value
    End Set
  End Property

  Public ReadOnly Property RefLists() As RTIS.CommonVB.colRefLists Implements RTIS.CommonVB.iRefListHolder.RefLists
    Get
      RefLists = pRefLists
    End Get
  End Property

  Public Sub SetRefLists(ByRef rRefList As RTIS.CommonVB.colRefLists)
    pRefLists = rRefList
  End Sub

  Public ReadOnly Property ClipBoard As clsClipBoard
    Get
      Return pClipBoard
    End Get
  End Property

  ''Public Property AppExtensionDLLFile() As String
  ''  Get
  ''    AppExtensionDLLFile = pAppExtensionDLLFile
  ''  End Get
  ''  Set(ByVal value As String)
  ''    pAppExtensionDLLFile = value
  ''  End Set
  ''End Property

  Public Property AppExtFactory() As clsAppExtensionFactory
    Get
      AppExtFactory = pAppExtFactory
    End Get
    Set(ByVal value As clsAppExtensionFactory)
      pAppExtFactory = value
    End Set
  End Property

  Public Overrides ReadOnly Property ReportFooterText(Optional ByVal vReportTitle As String = "") As String
    Get
      Return My.Application.Info.ProductName & ": " & Me.DataSetName & " " & Format(Date.Now, "dd/MM/yyyy HH:mm:ss") & Space(5) & vReportTitle
    End Get

  End Property

  Public Overrides Function EncryptString(ByVal vPlainText As String) As String
    Dim mrtisEncrypt As New rtisEncrypt(cEncryptionKey, cEncryptionIV)
    EncryptString = mrtisEncrypt.EncryptString(vPlainText)
    mrtisEncrypt = Nothing
  End Function

  Public Overrides Function DecrpytString(ByVal vCodedText As String) As String
    Dim mrtisEncrypt As New rtisEncrypt(cEncryptionKey, cEncryptionIV)
    DecrpytString = mrtisEncrypt.DecryptString(vCodedText)
    mrtisEncrypt = Nothing
  End Function


End Class


''Public Class clsAppRefList : Inherits clsRefList  'What about default Values ?? - For RTIS BI need a way of importing this from a main application dll or exe
''  Public Enum eRefListENUM
''    None = 0
''    RefList = 1

''  End Enum

''  Public Sub New()
''    MyBase.new()
''  End Sub

''  Public Overrides Function RefListVI(ByRef rDBConn As clsDBConnBase, ByVal vRefListID As Integer) As colValueItems
''    Dim mRetVI As colValueItems
''    'Return New clsLookUpRowValidation
''    'vLookupTable.LookUpRowValidation = New clsLookUpRowValidation
''    Select Case vRefListID
''      Case eRefListENUM.None
''        mRetVI = Nothing
''      Case eRefListENUM.RefList
''        mRetVI = clsEnumsConstants.EnumToVIs(GetType(eRefListENUM))
''      Case Else
''        mRetVI = Nothing
''    End Select
''    Return mRetVI
''  End Function

''  Public Overrides Function RefDateList() As Boolean
''    Return False
''  End Function


''End Class

'' Set-up for common ref data table pop-up lists/combos etc.

''Public Class clsPartListSearch : Inherits clsListSearchBase

''  Public Sub New(ByRef rDBSource As clsDBConnBase)
''    MyBase.New(rDBSource)
''  End Sub

''  Protected Overrides Sub SetListDetails()
''    pDataField = "Product"
''    pDisplayField = "Product"
''    pAux1Field = "Warehouse"
''    'pFormWidth = -1
''    'pFormHeight = -1

''  End Sub

''  Protected Overrides Function LoadListTable() As DataTable
''    Dim mDT As DataTable
''    Dim mOK As Boolean
''    mOK = pDBSource.dsoKFRefData.ProductTable(mDT)

''    Return mDT
''  End Function


''  Protected Overrides Function LookUpDisplayFromValue(ByVal vDataValue As Object) As String
''    Dim mRet As String
''    mRet = vDataValue.ToString
''    Return mRet
''  End Function
''End Class

''Public Class clsSupplierListSearch : Inherits clsListSearchBase

''  Public Sub New(ByRef rDBSource As conRTISApp)
''    MyBase.New(rDBSource)
''  End Sub

''  Protected Overrides Sub SetListDetails()
''    pDataField = "SupplierNo"
''    pDisplayField = "SupplierName"
''    pAux1Field = ""
''    'pFormWidth = -1
''    'pFormHeight = -1

''  End Sub

''  Protected Overrides Function LoadListTable() As DataTable
''    Dim mDT As DataTable
''    Dim mOK As Boolean
''    mOK = pDBSource.dsoKFRefData.SupplierTable(mDT)

''    Return mDT
''  End Function


''  Protected Overrides Function LookUpDisplayFromValue(ByVal vDataValue As Object) As String
''    Dim mRet As String
''    mRet = pDBSource.dsoKFRefData.SupplierNameFromNo(vDataValue)
''    Return mRet
''  End Function
''End Class
