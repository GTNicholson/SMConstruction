Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.DeveloperUtilities

Imports System.IO
Imports System.Environment
Imports DevExpress.XtraNavBar

Public Class frmTabbedMDI_DevUtil
  '' Private pDepartments As colValueItems

  Public Shared Function OpenAsModel() As DialogResult
    Dim mfrm As New frmTabbedMDI_DevUtil
    Return mfrm.ShowDialog
  End Function


  Public Shared Function OpenAsNonModel()
    Dim mfrm As New frmTabbedMDI_DevUtil
    mfrm.Show()
  End Function


  Public Sub New()


    ' This call is required by the Windows Form Designer.
    DevExpress.UserSkins.BonusSkins.Register()
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitStartUpForm()
    InitWindows()
    InitComboBoxes()
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
    Dim mDBConn As clsDBConnBase = Nothing
    Try
      mDBConn = My.Application.RTISUserSession.CreateMainDBConn()
      If mDBConn.Connect(mNewConnection) Then
        'LoadMenuOptions(My.Application.MainDB)
        InitmenuOptions(mDBConn)
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    Finally
      If mNewConnection Then mDBConn.Disconnect()

    End Try


    BarStaticItem1.Caption = AppRTISGlobal.GetInstance.DataSetName & " (V" & My.Application.Info.Version.ToString() & ")"

    ''      BarStaticItem1.Caption = My.Application.RTISGlobal.DataSetName & " (V" & My.Application.Info.Version.ToString() & ")"


  End Sub


  Private Sub InitmenuOptions(ByRef rDBConn As clsDBConnBase)

    ''AddManReportMenuOptions

  End Sub

  ''Private Sub AddManReportMenuOptions(ByRef rDBConn As clsDBConnBase)
  ''  Dim mdsoReports As RTIS.ManReportGUI.dsoManReportGUI
  ''  Dim mMenuOptions As New RTIS.Elements.clsMenuList
  ''  Dim mUserReportsMenuGroupName As String
  ''  Dim mAllOK As Boolean

  ''  mdsoReports = New RTIS.ManReportGUI.dsoManReportGUI
  ''  mUserReportsMenuGroupName = "User Reports"
  ''  '' TODO Get User Reports Menu Group name
  ''  If mdsoReports.LoadMenuOptions(rDBConn, mMenuOptions, New RTIS.ManReportGUI.clsManReportAddToNavBarMenu(mUserReportsMenuGroupName, NavBarControl1, AddressOf MenuOptionNavBarItem_LinkClicked)) Then
  ''  Else
  ''    mAllOK = False
  ''  End If
  ''  RTIS.Elements.clsDEControlLoading.LoadNavBarMenu(NavBarControl1, mMenuOptions, AddressOf MenuOptionNavBarItem_LinkClicked)

  ''  mdsoReports = Nothing
  ''End Sub


  Private Sub MenuOptionNavBarItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    Dim mNavBarItem As DevExpress.XtraNavBar.NavBarItem
    Dim mMenuOption As RTIS.Elements.intMenuOption
    mNavBarItem = CType(sender, DevExpress.XtraNavBar.NavBarItem)
    mMenuOption = mNavBarItem.Tag
    mMenuOption.MenuDelegate().Invoke(mMenuOption, Me, My.Application.RTISUserSession, AppRTISGlobal.GetInstance)
  End Sub


  Private Sub NavBarItem_ManReportDesigner_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem_ManReportDesigner.LinkClicked
    RTIS.DeveloperUtilities.frmGridDesigner.OpenFormAsMDIChild(Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub

  Private Sub NavBarItem_CodeGenerator_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem_CodeGenerator.LinkClicked
    RTIS.DeveloperUtilities.frmCodeGenerator.DataTableCodeGenerator(My.Application.RTISUserSession.CreateMainDBConn)

  End Sub

  Private Sub bbtn_About_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtn_About.ItemClick
    ''Dim mfrm As New frmRTISSplash
    ''mfrm.ShowDialog()
    ''mfrm = Nothing
    MsgBox("realtime Developer Utilities: " & My.Application.Info.Version.ToString)
  End Sub

  Private Sub navbarUpdateManifest_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarUpdateManifest.LinkClicked
    RTIS.DeveloperUtilities.frmUpdateManifestEditor.OpenFormAsMDIChild(Me)
  End Sub

  Private Sub navbarEmailTest_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarEmailTest.LinkClicked
    Dim mEMM As New RTIS.EmailLib.clsEmailManager
    Dim mfrm As New RTIS.EmailLib.frmEmailProps(mEMM)
    mEMM.EmailSettings = New RTIS.EmailLib.clsEmailSettings
    mfrm.EmailSettings = mEMM.EmailSettings

    mfrm.MdiParent = Me
    mfrm.Show()

    ' mfrm.ShowDialog(Me)

  End Sub

  Private Sub navbaritemCodeGendmBase_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritemCodeGendmBase.LinkClicked
    RTIS.DeveloperUtilities.frmCodeGenerator.DataTableCodeGeneratorDM(My.Application.RTISUserSession.CreateMainDBConn)

  End Sub

  Private Sub navbarDataTransferUtility_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarDataTransferUtility.LinkClicked
    Dim mRTISSettingFile As New clsRTISAppSettings
    mRTISSettingFile = New clsRTISAppSettings
    mRTISSettingFile.ReadDetails(AppRTISGlobal.GetInstance.ConnInfoFileName)
    RTIS.DeveloperUtilities.frmDataSchema.DisplayAsModal(mRTISSettingFile.MainConn)
    mRTISSettingFile = Nothing
  End Sub

  Private Sub navbarSerialComTest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarSerialComTest.LinkClicked
    Dim mfrm As New RTIS.DeveloperUtilities.frmSerialCommChat
    mfrm.MdiParent = Me
    mfrm.Show()
  End Sub

  Private Sub frmTabbedMDI_DevUtil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    For Each mForm As Form In Me.MdiChildren
      mForm.Close()
    Next
  End Sub

  Private Sub navbarSQLiteUtil_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarSQLiteUtil.LinkClicked
    ''Dim mfrm As New frmSQLiteDB
    ''mfrm.MdiParent = Me
    ''mfrm.Show()
  End Sub

  Private Sub navbarConnLockTest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarConnLockTest.LinkClicked
    'Dim mfrm As New frmTestConn
    'mfrm.MdiParent = Me
    'mfrm.Show()
  End Sub

  Private Sub NavBarDataCompare_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDataCompare.LinkClicked
    Dim mRTISSettingFile As New clsRTISAppSettings
    mRTISSettingFile = New clsRTISAppSettings
    mRTISSettingFile.ReadDetails(AppRTISGlobal.GetInstance.ConnInfoFileName)
    RTIS.DeveloperUtilities.frmDataCompareTest.DisplayAsModal(mRTISSettingFile.MainConn)
    mRTISSettingFile = Nothing
  End Sub

  Private Sub navbaritLookUpConfig_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritLookUpConfig.LinkClicked
    RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(3, Me, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, New clsGetLookUpExtension)
  End Sub

  Private Sub frmTabbedMDI_DevUtil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub navbarPodioTest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarPodioTest.LinkClicked
    Dim mSourceFile As String = ""
    Dim mTargetFile As String = ""
    Dim mTargetPath As String = ""

    Try

      Dim menum As Integer


      RTIS.CommonVB.clsGeneralA.GetOpenFileName(mSourceFile, "SourceFile")
      mTargetPath = IO.Path.Combine(Environment.GetFolderPath(SpecialFolder.UserProfile), "Dropbox", "MADE")
      mTargetFile = IO.Path.GetFileName(mSourceFile)
      RTIS.CommonVB.clsGeneralA.GetSaveFileName(mTargetFile, "TargetFile", mTargetPath)

      IO.File.Copy(mSourceFile, mTargetFile)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub navbarPrinterTest_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbarPrinterTest.LinkClicked
    Dim mlabelDef As New clsLabelDefinition
    Dim mDso As New dsoLabelDefinition(My.Application.RTISUserSession.CreateMainDBConn())
    Dim mWO As New dmWorkOrder
    Dim mSO As New dmSalesOrder

    mlabelDef.LabelDefinitionID = 1
    mDso.LoadLabelDefinition(mlabelDef)

    repFGLabel.PrintWorkOrderLabels(mWO, mSO, mlabelDef)
  End Sub

  Private Sub navbaritBackDateOverTime_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navbaritBackDateOverTime.LinkClicked
    Dim mTSE As dmTimeSheetEntry
    Dim mTSEs As New colTimeSheetEntrys
    Dim mdso As dsoHR
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mOTMins As Integer
    Dim mShift As dmShift

    mDBConn = My.Application.RTISUserSession.CreateMainDBConn

    mShift = AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Shift).Item(0)

    mdso = New dsoHR(mDBConn)
    mdso.LoadTimeSheetEntrysByWhere(mTSEs, "")

    For Each mTSE In mTSEs
      mOTMins = clsTimeSheetSharedFuncs.getOverTimeMinutes(mTSE, mShift)
    Next

  End Sub

  Private Sub navbaritAssignStockCodes_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navbaritAssignStockCodes.LinkClicked
    Dim mStockItems As colStockItems
    Dim mdtoSI As dtoStockItem
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mSICode As String
    Dim mdsoStock As dsoStock

    Try

      mDBConn = My.Application.RTISUserSession.CreateMainDBConn
      mDBConn.Connect()
      mdsoStock = New dsoStock(mDBConn)
      mdtoSI = New dtoStockItem(mDBConn)

      mStockItems = New colStockItems
      mdtoSI.LoadStockItemsByWhere(mStockItems, "StockCode is null")

      For Each mSI As dmStockItem In mStockItems
        mSICode = clsStockItemSharedFuncs.GetStockCodeStem(mSI)
        mSICode = mSICode & mdsoStock.GetNextStockCodeSuffixNoConnected(mSICode).ToString("000")
        mSI.StockCode = mSICode
        mdtoSI.SaveStockItem(mSI)
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try
  End Sub
End Class