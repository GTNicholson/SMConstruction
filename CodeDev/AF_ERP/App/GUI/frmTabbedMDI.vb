'Imports Microsoft.VisualBasic
'Imports System
'Imports System.Drawing
'Imports System.Collections
'Imports System.ComponentModel
'Imports System.Windows.Forms
'Imports System.Data
'Imports DevExpress.XtraTab
'Imports DevExpress.XtraBars
'Imports DevExpress.XtraEditors
'Imports DevExpress.XtraEditors.Controls
'Imports DevExpress.XtraTabbedMdi
'Imports DevExpress.Utils
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmTabbedMDI
  'Private pDepartments As colValueItems
  Public Sub New()

    DevExpress.UserSkins.BonusSkins.Register()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()


  End Sub

  Private Sub InitWindows()

    BarMdiChildrenListItem1.Enabled = XtraTabbedMdiManager1.Pages.Count > 0
  End Sub

  Private Sub InitComboBoxes()

  End Sub


  Private Sub xtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded

    InitWindows()
    ' e.Page.Image = e.Page.MdiChild.Icon.ToBitmap
    'e.Page.Image = imageList1.Images(xx)  'Could use an image list, or an image on the form
  End Sub

  Private Sub xtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
    InitWindows()

  End Sub

  Private Sub InitStartUpForm()

    Dim mNewConnection As Boolean
    Dim mDBConn As clsDBConnBase
    Try
      mDBConn = My.Application.RTISUserSession.CreateMainDBConn()
      If mDBConn.Connect(mNewConnection) Then
        'LoadMenuOptions(My.Application.MainDB)
        InitmenuOptions(mDBConn)
        If mNewConnection Then mDBConn.Disconnect()
      End If
      BarStaticItem1.Caption = AppRTISGlobal.GetInstance.DataSetName & " (V" & My.Application.Info.Version.ToString() & ")"
      If Debugger.IsAttached Or My.Application.RTISUserSession.UserID = appInit.cDeveloperUserID Then
        Me.Text = My.Application.Info.Title & " (" & My.Application.RTISUserSession.UserName & ") SVR:" & My.Application.RTISUserSession.SessionMainConn.ServerName & " DB:" & My.Application.RTISUserSession.SessionMainConn.DatabaseName & ")"
      Else
        Me.Text = My.Application.Info.Title & " (" & My.Application.RTISUserSession.UserName & ")"
      End If
    Catch ex As Exception
      ''MsgBox(ex.Message)
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub bbtn_About_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtn_About.ItemClick
    Dim mfrm As New frmRTISSplash
    mfrm.ShowDialog()
    mfrm = Nothing
  End Sub

  Private Sub InitmenuOptions(ByRef rDBConn As clsDBConnBase)
    Dim mdso As RTIS.Elements.dsoLookUpTable
    ' Dim mdsoReports As RTIS.ManReportGUI.dsoManReportGUI
    Dim mMenuOptions As RTIS.Elements.clsMenuList
    Dim mAllOK As Boolean = True


    mMenuOptions = New RTIS.Elements.clsMenuList

    'Load up menu options for all Modules
    Try


      Dim mMenuManager As New clsMenuHandler(Me, Me.nbcSideMenu, Me.ImageCollection1, Me.TreeList1, AppRTISGlobal.GetInstance)
      mMenuManager.PopulateNavBarMenu(MenuFactory.BuildMenu)

      mdso = New RTIS.Elements.dsoLookUpTable
      mdso.DBSource = rDBConn
      ''If mdso.LoadMenuOptions(mMenuOptions, New clsGetLookUpExtension) Then
      ''Else
      ''  mAllOK = False

      ''End If

    Catch ex As Exception
      mAllOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try



    '' TODO Get User Reports Menu Group name
    ''mdsoReports = New RTIS.ManReportGUI.dsoManReportGUI
    ''mUserReportsMenuGroupName = "User Reports"
    '' '' TODO Get User Reports Menu Group name
    ''If mdsoReports.LoadMenuOptions(My.Application.MainDB, mMenuOptions, New RTIS.ManReportGUI.clsManReportAddToNavBarMenu(mUserReportsMenuGroupName, NavBarControl1, AddressOf MenuOptionNavBarItem_LinkClicked)) Then
    ''Else
    ''  mAllOK = False
    ''End If
    ''mdsoReports = Nothing

    ''Now load the menu - ?Navbar - possibly tool-bar menu or Ribbon control menu as well
    Try
      RTIS.Elements.clsDEControlLoading.LoadNavBarMenu(nbcSideMenu, mMenuOptions, AddressOf MenuOptionNavBarItem_LinkClicked)

    Catch ex As Exception
      mAllOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mAllOK Then
      '' Log/display problem ??
      mAllOK = False
    End If

    '' Check perissions?
    SetupScreenSizeOptions()

    SetupUserPermissions()
    ''MOved: Me.Text = My.Application.Info.Title & " (" & My.Application.RTISUserSession.UserName & ")"


  End Sub


  Private Sub LoadHomescreen()
    Dim mHSF As clsHomeScreenFactory
    mHSF = New clsHomeScreenFactory(AppRTISGlobal.GetInstance, My.Application.RTISUserSession.CreateMainDBConn)

    mHSF.LoadHomeScreen(Me)

  End Sub

  Private Sub SetupUserPermissions()
    Dim mPermissionLevel As ePermissionCode

    '' Permissions for System ToolBar
    mPermissionLevel = My.Application.RTISUserSession.ActivityPermission(eActivityCode.Configuration)
    Me.bbiLocalConfig.Enabled = (mPermissionLevel = ePermissionCode.ePC_Full)
    Me.bbiServerConfig.Enabled = (mPermissionLevel = ePermissionCode.ePC_Full)

    bbiPCSettings.Visibility = DevExpress.XtraBars.BarItemVisibility.Never 'Use when a separate PC config file is used
    bbiPCSettings.Enabled = (mPermissionLevel = ePermissionCode.ePC_Full)

    mPermissionLevel = My.Application.RTISUserSession.ActivityPermission(eActivityCode.UserConfig)
    Me.bbiUserGroupAdmin.Enabled = (mPermissionLevel = ePermissionCode.ePC_Full)


    '' Permissions for Side Menu
    ''Menu Group/Module One
    ''mPermissionLevel = My.Application.RTISUserSession.ActivityPermissions.GetActivityPermission(eActivityCode.Ventas)
    'nbgModuleOne.Visible = (mPermissionLevel >= ePermissionCode.ePC_View)
    'nbgModuleOne.Expanded = (mPermissionLevel > ePermissionCode.ePC_View)

    ''Menu Group/Module Two
    'mPermisionLevel = My.Application.RTISUserSession.ActivityPermissions.GetActivityPermission(eActivityCode.ModuleTwo)
    'nbgModuleTwo.Visible = (mPermisionLevel >= ePermissionCode.ePC_View)
    'nbgModuleTwo.Expanded = (mPermisionLevel > ePermissionCode.ePC_View)

    'nbgAdministration.Visible
    If My.Application.RTISUserSession.UserID = appInit.cDeveloperUserID Then
      'Me.nbgOrdenTrabajo.Visible = True
      Me.bbtnDevUtilities.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    Else
      'Me.nbgOrdenTrabajo.Visible = False
      Me.bbtnDevUtilities.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End If

      If nbcSideMenu.Groups.GetVisibleGroupCount() > 15 Then
         For Each mGroup As DevExpress.XtraNavBar.NavBarGroup In nbcSideMenu.Groups
            mGroup.Expanded = False
         Next
      End If
   End Sub

  Private Sub MenuOptionNavBarItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) 'Handles NavBarItem1.LinkClicked
    Dim mNavBarItem As DevExpress.XtraNavBar.NavBarItem
    Dim mMenuOption As RTIS.Elements.intMenuOption
    mNavBarItem = CType(sender, DevExpress.XtraNavBar.NavBarItem)
    mMenuOption = mNavBarItem.Tag
    mMenuOption.MenuDelegate().Invoke(mMenuOption, Me, My.Application.RTISUserSession, AppRTISGlobal.GetInstance)
  End Sub


  ''Private Sub bbtnSettings_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSettings.ItemClick
  ''  clsAppInit.CheckSettings(My.Application.RTISGlobal)
  ''  clsAppInit.CheckLocalSettings(My.Application.RTISGlobal)
  ''  appInit.CheckSettingWithPrompt(AppRTISGlobal.GetInstance)
  ''End Sub

  Private Sub frmTabbedMDI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    ' Add any initialization after the InitializeComponent() call.
    InitStartUpForm()
    LoadHomescreen()
    InitWindows()
    InitComboBoxes()
  End Sub

  Private Sub NavBarItem1_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbi_ModuleOneOption01.LinkClicked
    ''frmListForm.OpenListForm(My.Application.RTISUserSession.CreateMainDBConn)

    ''Dim mfrm As frmtestBar
    ''mfrm = New frmtestBar
    ''mfrm.MdiParent = Me 'My.Application.MenuMDIForm
    ''mfrm.Show()
    Dim mConn As clsDBConnBase
    My.Application.RTISUserSession.SessionMainConn.DatabaseName = "Datim_ERP"
    mConn = My.Application.RTISUserSession.CreateAdHocDBConn(My.Application.RTISUserSession.SessionMainConn)
    mConn.Connect()
    If mConn.IsConnected Then
      MsgBox("Conexión OK")
      mConn.Disconnect()
    Else

      MsgBox("NO ESTA CONECTADO", MsgBoxStyle.Exclamation)
    End If
    mConn = Nothing


    'mfrm.ShowDialog()
  End Sub

  Private Sub nbi_UsersLoggedOn_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbi_UsersLoggedOn.LinkClicked
    frmBrowseList.OpenFormAsMDIChild(Me, New brwCurrentUsersLoggedOn(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.CurrentUsersLoggedOn))

  End Sub


  ''Private Sub nbi_UserGroupAdmin_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbi_UserGroupAdmin.LinkClicked
  ''  If My.Application.RTISUserSession.ActivityPermission(eActivityCode.UserConfig) = ePermissionCode.ePC_Full Then
  ''    'frmAdminMDI.OpenAsModel(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, frmAdminMDI.eAdminType.EmployeeUser)
  ''    RTIS.Elements.frmMDIShell.OpenAsModel(New clsMDISystemAdmin(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance))
  ''  End If
  ''End Sub
  'Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
  '  If My.Application.RTISUserSession.ActivityPermission(eActivityCode.UserConfig) = ePermissionCode.ePC_Full Then
  '    appInit.CheckLocalSettings(AppRTISGlobal.GetInstance)
  '  End If
  'End Sub


#Region "SystemToolBar"
  '' Expects a 'System' toolbar with following controls added:
  '' bbiChangePassword as BarButtonItem
  '' bbiCurrentUserLocks as BarButtonItem
  '' bbiUserGroupAdmin  as BarButtonItem
  '' bbiPCSettings as BarButtonItem
  '' bbiLocalConfig as BarButtonItem
  '' bbiServerConfig as BarButtonItem
  '' bsiScreenResolutionTest as BarSubItem


  Private Sub bbiCurrentUserLocks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCurrentUserLocks.ItemClick
    frmBrowseList.OpenFormAsMDIChild(Me, New brwCurrentUserLocks(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.CurrentUserLocks))

  End Sub

  Private Sub bbiUserGroupAdmin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUserGroupAdmin.ItemClick
    If My.Application.RTISUserSession.ActivityPermission(eActivityCode.UserConfig) >= ePermissionCode.ePC_View Then
      RTIS.Elements.frmMDIShell.OpenAsModel(New clsMDISystemAdmin(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance))
    End If
  End Sub

  Private Sub bbiPCSettings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPCSettings.ItemClick

  End Sub



  Private Sub bbiLocalConfig_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLocalConfig.ItemClick
    If My.Application.RTISUserSession.ActivityPermission(eActivityCode.Configuration) = ePermissionCode.ePC_Full Then
      appInit.CheckLocalSettings(AppRTISGlobal.GetInstance)
    End If
  End Sub

  Private Sub bbiServerConfig_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiServerConfig.ItemClick

    If My.Application.RTISUserSession.ActivityPermission(eActivityCode.Configuration) = ePermissionCode.ePC_Full Then
      appInit.CheckServerSettings(AppRTISGlobal.GetInstance)
    End If
  End Sub

  Private Sub bbiChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiChangePassword.ItemClick
    frmChangePassword.DisplayChangePassword(My.Application.RTISUserSession.CreateMainDBConn, My.Application.RTISUserSession, False)

  End Sub

  Private Sub SetupScreenSizeOptions()
    AddScreenSizeOption(1024, 768)
    AddScreenSizeOption(1280, 800)
    AddScreenSizeOption(1280, 1024)
    AddScreenSizeOption(1366, 768)
    AddScreenSizeOption(1440, 900)
    AddScreenSizeOption(1680, 1050)
    AddScreenSizeOption(1920, 1200)
  End Sub

  Public Sub AddScreenSizeOption(ByVal vWidth As Integer, ByVal vHeight As Integer)
    Dim mButtonLink As DevExpress.XtraBars.BarItemLink
    Dim mBtn As DevExpress.XtraBars.BarButtonItem
    mBtn = New DevExpress.XtraBars.BarButtonItem
    mBtn.Caption = vWidth.ToString & " x " & vHeight.ToString
    mBtn.Tag = vWidth.ToString & "x" & vHeight.ToString
    mButtonLink = bsiScreenResolutionTest.AddItem(mBtn)
    bsiScreenResolutionTest.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    AddHandler mButtonLink.Item.ItemClick, AddressOf bbiScreenSizeChange
    mButtonLink = Nothing
    mBtn = Nothing
  End Sub

  Private Sub bbiScreenSizeChange(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    Try
      Dim mParts() As String = CType(e.Item.Tag, String).Split("x")
      If mParts.Length >= 2 Then
        Me.WindowState = FormWindowState.Normal
        Me.Width = CInt(Val(mParts(0)))
        Me.Height = CInt(Val(mParts(1)))
      End If
    Catch ex As Exception
      Me.WindowState = FormWindowState.Maximized
    End Try
  End Sub

#End Region



  ''Private Sub nbiTest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritListaDeOrdeTrabajo.LinkClicked

  ''  ''"C:\RTISProjects\SFL2004\IMS\DocUserGuide"
  ''  ''"C:\RTISProjects\Emcor\Procurement\Docs_User"
  ''  'frmDocView.OpenFormAsModal(Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, "C:\RTISProjects\Emcor\Procurement\Docs_User", eFormMode.eFMFormModeView)

  ''  Dim mBrw As New brwWorkOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, 1)
  ''  frmBrowseList.OpenFormAsMDIChild(Me, mBrw)

  ''End Sub

  ''Private Sub nbiTest2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbi_ModuleTwoOption02.LinkClicked
  ''  'frmDocLibraryView.OpenFormAsModal(Me, AppRTISGlobal.GetInstance, "C:\RTISProjects\Emcor\Procurement\Docs_User", eFormMode.eFMFormModeView)
  ''End Sub

  Private Sub bbtnDevUtilities_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnDevUtilities.ItemClick
    ''TestWrapper.TestTheEnumerator()
    frmTabbedMDI_DevUtil.OpenAsNonModel()
  End Sub


  ''Private Sub nbi_ModuleTwoOption03_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbi_ModuleTwoOption03.LinkClicked
  ''  ''Dim mfrm As New frmRichTextRibbon
  ''  ''mfrm.RichTextCtrlRibbon1()
  ''  ''frmRichTextRibbon.OpenFormModal()

  ''  ''Dim mVI As New colValueItems
  ''  ''mVI.AddNewItem(1, "ITEM-ONE")
  ''  ''mVI.AddNewItem(2, "ITEM-TWO")
  ''  ''mVI.AddNewItem(3, "ITEM-THREE")
  ''  ''RTIS.Elements.frmRichEdit.EditRichTextModal("szf  sdf dsf sd fsdf", "TEST", mVI)

  ''  Dim UDPassword As String
  ''  Dim mrtisEncrypt As rtisEncrypt = New rtisEncrypt("Turning", "DC842E9CD6E46FD4")
  ''  UDPassword = mrtisEncrypt.XMLEncryptString("ActiveBusinessTraining;1/25/2014")
  ''  MsgBox(UDPassword)
  ''End Sub

  Private Sub nbcSideMenu_Click(sender As Object, e As EventArgs) Handles nbcSideMenu.Click

  End Sub

  Private Sub barbtnReloadLists_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnReloadLists.ItemClick
    Try
      ReloadLists()

      MsgBox("LISTA DE REFERENCIAS ACTUALIZADAS")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Public Sub ReloadLists()
    Try
      Dim mDBConn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
      Dim mdsoRefLists As New dsoAppRefLists(mDBConn)

      mdsoRefLists.LoadAllListsConnected(AppRTISGlobal.GetInstance.RefLists)

      mdsoRefLists = Nothing
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub bbiClearAllLocks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClearAllLocks.ItemClick
    Dim mdbconn As clsDBConnBase = Nothing
    Try
      mdbconn = My.Application.RTISUserSession.CreateMainDBConn
      mdbconn.Connect()
      mdbconn.ExecuteNonQuery("Delete from CurrentLock")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    Finally
      If mdbconn.IsConnected Then mdbconn.Disconnect()
    End Try
  End Sub

  ''Private Sub nbiTestBrowse_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTestBrowse.LinkClicked
  ''  'frmBrowseList.OpenFormAsMDIChild(Me, New brwTemplateList(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.Undefined))

  ''End Sub

  ''Private Sub nbi_ModuleTwoOption04_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbi_ModuleTwoOption04.LinkClicked
  ''  Dim mText As String
  ''  Dim mSig As String
  ''  Dim mSigFile As String = ""
  ''  Dim mRTDS As DevExpress.XtraRichEdit.RichEditDocumentServer

  ''  mText = "Dear X" & vbCrLf & vbCrLf & "From Me" & vbCrLf & "{OriginalText}" & vbCrLf & "[EmailSigA]"
  ''  mSigFile = Environ("appdata") & "\Microsoft\Signatures\"
  ''  If Dir(mSigFile, vbDirectory) <> vbNullString Then
  ''    mSigFile = mSigFile & Dir$(mSigFile & "*.rtf")  ' ".htm"
  ''  Else
  ''    mSigFile = ""
  ''  End If
  ''  If Not String.IsNullOrWhiteSpace(mSigFile) Then
  ''    mSig = IO.File.ReadAllText(mSigFile)
  ''    'mSig = "Replaced"
  ''    mText = mSig 'mText.Replace("[EmailSigA]", mSig)
  ''  End If

  ''  If RTIS.Elements.frmRichEdit.EditRichTextModal(mText, "Test Send Email") Then

  ''    mRTDS = New DevExpress.XtraRichEdit.RichEditDocumentServer
  ''    mRTDS.RtfText = mText
  ''    mRTDS.Document.ReplaceAll("{OriginalText}", "UpdatedText", DevExpress.XtraRichEdit.API.Native.SearchOptions.CaseSensitive)
  ''    mText = mRTDS.RtfText
  ''    mRTDS = Nothing
  ''    ''use  mText = RTIS.WorkflowCore.clsDocumentHelper.SearchReplaceRichText(mText, mDictionary)

  ''    If RTIS.WorkflowCore.clsSimpleEmailMessage.SendEmailRichTextAsHTML("johns@rtis.co.uk", "Subject-Test RTF AS HTML", mText) Then
  ''      MsgBox("Sent OK")
  ''    Else
  ''      MsgBox("Not Sent")
  ''    End If
  ''  End If



  ''mText = "Dear X" & vbCrLf & vbCrLf & "From Me" & vbCrLf

  ''Dim mRTDS As New DevExpress.XtraRichEdit.RichEditDocumentServer
  ''mRTDS.Text = mText
  ''mText = mRTDS.HtmlText


  ''mSigFile = Environ("appdata") & "\Microsoft\Signatures\"
  ''If Dir(mSigFile, vbDirectory) <> vbNullString Then
  ''  mSigFile = mSigFile & Dir$(mSigFile & "*.htm")
  ''Else
  ''  mSigFile = ""
  ''End If
  ''If Not String.IsNullOrWhiteSpace(mSigFile) Then
  ''  mSig = IO.File.ReadAllText(mSigFile)
  ''  mText = mText & "<br>" & mSig
  ''End If

  ''If RTIS.Elements.frmRichEdit.EditHTMLTextModal(mText, "Test Send Email") Then

  ''  mRTDS = New DevExpress.XtraRichEdit.RichEditDocumentServer
  ''  mRTDS.Options.Export.Html.EmbedImages = True
  ''  mRTDS.HtmlText = mText
  ''  mText = mRTDS.RtfText
  ''  If RTIS.WorkflowCore.clsSimpleEmailMessage.SendEmailRichTextAsHTML("johns@rtis.co.uk", "Subject-Test HTML", mText) Then
  ''    MsgBox("Sent OK")
  ''  Else
  ''    MsgBox("Not Sent")
  ''  End If
  ''End If



  ''  mText = "Dear X" & vbCrLf & vbCrLf & "From Me" & vbCrLf

  ''  mRTDS = New DevExpress.XtraRichEdit.RichEditDocumentServer
  ''  mRTDS.Text = mText
  ''  mText = mRTDS.HtmlText

  ''  mSigFile = Environ("appdata") & "\Microsoft\Signatures\"
  ''  If Dir(mSigFile, vbDirectory) <> vbNullString Then
  ''    mSigFile = mSigFile & Dir$(mSigFile & "*.htm")
  ''  Else
  ''    mSigFile = ""
  ''  End If
  ''  If Not String.IsNullOrWhiteSpace(mSigFile) Then
  ''    mSig = IO.File.ReadAllText(mSigFile)
  ''    mText = mText & "<br>" & mSig
  ''  End If

  ''  If RTIS.Elements.frmRichEdit.EditHTMLTextModal(mText, "Test Send Email") Then

  ''    ''mRTDS = New DevExpress.XtraRichEdit.RichEditDocumentServer
  ''    ''mRTDS.HtmlText = mText
  ''    ''mRTDS.Document.ReplaceAll("{OriginalText}", "UpdatedText", DevExpress.XtraRichEdit.API.Native.SearchOptions.CaseSensitive)
  ''    ''mText = mRTDS.HtmlText
  ''    ''mRTDS = Nothing

  ''    Dim mDictionary As New Dictionary(Of String, String)
  ''    mDictionary.Add("{OriginalText}", "UpdatedText")
  ''    mText = RTIS.WorkflowCore.clsDocumentHelper.SearchReplaceHTML(mText, mDictionary)


  ''    If RTIS.WorkflowCore.clsSimpleEmailMessage.SendEmailHTML("johns@rtis.co.uk", "Subject-Test HTML", mText) Then
  ''      MsgBox("Sent OK")
  ''    Else
  ''      MsgBox("Not Sent")
  ''    End If
  ''  End If

  ''End Sub

  ''Private Sub navbaritListaDeClientes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritListaDeClientes.LinkClicked
  ''  Dim mBrw As New brwClientes(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, 1)
  ''  frmBrowseList.OpenFormAsMDIChild(Me, mBrw)
  ''End Sub

  ''Private Sub navbaritSalesRegion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritSalesRegion.LinkClicked
  ''  RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(9, Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  ''End Sub

  ''Private Sub navbaritTipoContrato_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritTipoContrato.LinkClicked
  ''  RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(10, Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  ''End Sub

  ''Private Sub navbaritWoodSpecie_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritWoodSpecie.LinkClicked
  ''  RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(11, Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  ''End Sub

  ''Private Sub navbaritPriceBracket_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritPriceBracket.LinkClicked
  ''  RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(12, Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  ''End Sub

  ''Private Sub navbarListaSalesOrder_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarListaSalesOrder.LinkClicked
  ''  Dim mBrw As New brwSalesOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, 1)
  ''  frmBrowseList.OpenFormAsMDIChild(Me, mBrw)
  ''End Sub

  ''Public Function DocTextSearchReplace()
  ''  Dim mRTDS As New DevExpress.XtraRichEdit.RichEditDocumentServer

  ''  mRTDS.Document.ReplaceAll(mOld, mNew)

  ''  ''Dim searchResult As DevExpress.XtraRichEdit.ISearchResult = subdoc.StartSearch("MERGEFIELD", SearchOptions.CaseSensitive, SearchDirection.Forward, subdoc.Range)
  ''  ''Do While searchResult.FindNext()
  ''  ''  searchResult.Replace(String.Empty)
  ''  ''  Dim insertRange As DocumentRange = subdoc.InsertText(searchResult.CurrentResult.Start, "DOCVARIABLE")
  ''  ''Loop

  ''End Function
End Class