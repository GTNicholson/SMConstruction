Imports System.Environment
Imports DevExpress.XtraNavBar
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.ERPCore

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
    Dim mThicknessInteger As Integer
    Dim mThicknessDecimal As Decimal
    Try

      mDBConn = My.Application.RTISUserSession.CreateMainDBConn
      mDBConn.Connect()
      mdsoStock = New dsoStock(mDBConn)
      mdtoSI = New dtoStockItem(mDBConn)

      mStockItems = New colStockItems
      mdtoSI.LoadStockItemsByWhere(mStockItems, "StockCode is null or stockcode =''")

      For Each mSI As dmStockItem In mStockItems

        mSICode = clsStockItemSharedFuncs.GetStockCodeStem_New(mSI, mDBConn)

        If mSI.Category = eStockItemCategory.Timber Then
          mSI.StockCode = mSICode
          'If mSICode <> "" Then
          '  mThicknessDecimal = mSI.Thickness ' mDSO.GetNextStockCodeSuffixNo(mStem)
          '  mSI.StockCode = mSICode
          '  If mThicknessDecimal <> 0 Then
          '    mThicknessInteger = CInt(mThicknessDecimal)

          '    mThicknessDecimal = Math.Abs(mThicknessDecimal - mThicknessInteger)
          '    mThicknessInteger = mSI.Thickness - mThicknessDecimal
          '    If mThicknessDecimal > 0 Then
          '      mThicknessDecimal = mThicknessDecimal * 10
          '      mSI.StockCode = mSICode & "_" & mThicknessInteger.ToString() & "." & mThicknessDecimal.ToString("n0")

          '    Else
          '      mSI.StockCode = mSICode & "_" & mThicknessInteger.ToString("n1")

          '    End If

          '  End If
          'End If

        Else
          mSICode = mSICode & mdsoStock.GetNextStockCodeSuffixNoConnected(mSICode).ToString("000")
          mSI.StockCode = mSICode
        End If


        mdtoSI.SaveStockItem(mSI)
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try
  End Sub

  Private Sub btnGeneratePalletRefs_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnGeneratePalletRefs.LinkClicked
    Dim mWoodPallets As colWoodPallets
    Dim mdtoWoodPallet As dtoWoodPallet
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mWoodPalletRef As String
    Dim mdsoGeneral As dsoGeneral
    mDBConn = My.Application.RTISUserSession.CreateMainDBConn
    Try
      mDBConn.Connect()

      mdsoGeneral = New dsoGeneral(mDBConn)
      mdtoWoodPallet = New dtoWoodPallet(mDBConn)

      mWoodPallets = New colWoodPallets
      mdtoWoodPallet.LoadWoodPalletCollection(mWoodPallets)


      For Each mWP As dmWoodPallet In mWoodPallets
        '//Do it for all Pallets
        clsWoodPalletSharedFuncs.GetNextWoodPalletRef(mWP, mDBConn)

        mdtoWoodPallet.SaveWoodPalletDisconnected(mWP)


      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try
  End Sub

  Private Sub btnGenerateWoodDesc_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnGenerateWoodDesc.LinkClicked
    Dim mWoodPallets As New colWoodPallets
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mWoodPalletDescription As String

    Dim mdsoStock As dsoStock
    mDBConn = My.Application.RTISUserSession.CreateMainDBConn
    Try
      mDBConn.Connect()

      mdsoStock = New dsoStock(mDBConn)
      mdsoStock.LoadWoodPalletsDownByWhere(mWoodPallets, "")



      For Each mWP As dmWoodPallet In mWoodPallets

        mWoodPalletDescription = clsWoodPalletSharedFuncs.GetWoodPalletContentDescription(mWP.WoodPalletItems)
        mWP.Description = mWoodPalletDescription
        mdsoStock.SaveWoodPalletDown(mWP)


      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try
  End Sub

  Private Sub btnSIWoodDesc_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnSIWoodDesc.LinkClicked
    Dim mStockItems As New colStockItems
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mStockItemDesc As String

    Dim mdsoStock As dsoStock
    mDBConn = My.Application.RTISUserSession.CreateMainDBConn
    Try
      mDBConn.Connect()

      mdsoStock = New dsoStock(mDBConn)
      mdsoStock.LoadStockItemsByWhere(mStockItems, "isnull(IsTracked,0)<>1")



      For Each mSI As dmStockItem In mStockItems

        If mSI.Category = eStockItemCategory.Timber Then
          mStockItemDesc = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mSI)
          mSI.Description = mStockItemDesc
          mdsoStock.SaveStockItem(mSI)
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try
  End Sub

  Private Sub btnGenerateStockTransaction_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnGenerateStockTransaction.LinkClicked
    Dim mWhere As String = ""
    Dim mWoodPallets As New colWoodPallets
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions

    mWhere = "" '"PalletType<>" & eStockItemTypeTimberWood.Rollo
    mDBConn = My.Application.RTISUserSession.CreateMainDBConn
    Try
      mDBConn.Connect()

      mdsoStock = New dsoStock(mDBConn)
      mdsoStock.LoadWoodPalletsDownByWhere(mWoodPallets, mWhere)
      mdsoTran = New dsoStockTransactions(mDBConn)


      For Each mWP As dmWoodPallet In mWoodPallets


        mdsoTran.CreatePositiveTransaction(eTransactionType.WoodAmendment, mWP, eLocations.AgroForestal, Now, eCurrency.Dollar, 1, False)


      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try




  End Sub

  Private Sub nbiUpdateStockItemLocationMonetaryValue_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nbiUpdateStockItemLocationMonetaryValue.LinkClicked
    Dim mSI As dmStockItem
    Dim mSIL As dmStockItemLocation
    Dim mSILs As New colStockItemLocations
    Dim mPicker As New clsPickerStockItem(AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemCollection, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
    Dim mCostingPricing As clsStockCostingPricing
    Dim mCB = New dmCostBook
    Dim mDSO As dsoCostBook
    Dim mDSOStock As dsoStock
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase

    mDSO = New dsoCostBook(My.Application.RTISUserSession.CreateMainDBConn)
    mDSO.LoadCostBookDown(mCB, 1)

    mSI = frmPickerStockItem.OpenPickerSingle(mPicker, False)
    If mSI IsNot Nothing Then
      mDSOStock = New dsoStock(My.Application.RTISUserSession.CreateMainDBConn)
      mDSOStock.LoadStockItemLocationsByStockItemID(mSILs, mSI.StockItemID)
      If mSILs.Count <> 0 Then
        mSIL = mSILs(0)
        '// need to connect here as the following function uses a pre connected dso       
        mDBConn = My.Application.RTISUserSession.CreateMainDBConn
        mDBConn.Connect()
        mCostingPricing = New clsStockCostingPricing(mDBConn, AppRTISGlobal.GetInstance.StockItemRegistry, mCB)
        mCostingPricing.GetStockItemLocationMoneytaryValue(mSI, mSIL)
        mDBConn.Disconnect()
      End If
    End If
  End Sub

  Private Sub btnResetTransactionValuation_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnResetTransactionValuation.LinkClicked
    Dim mSI As dmStockItem
    Dim mStockItemsCollection As New colStockItems
    Dim mDSOStockTransactions As dsoStockTransactions
    Dim mdsoStockItem As dsoStock
    Dim mWhere As String = ""
    Dim mDBConn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn

    mDBConn.Connect()


    ''//Load stockItems except Timber
    mdsoStockItem = New dsoStock(mDBConn)
    mWhere = String.Format("Category not in ({0}) ", CInt(eStockItemCategory.Timber))

    mdsoStockItem.LoadStockItemsByWhere(mStockItemsCollection, mWhere)

    If mStockItemsCollection IsNot Nothing And mStockItemsCollection.Count > 0 Then

      mDSOStockTransactions = New dsoStockTransactions(mDBConn)

      For Each mSI In mStockItemsCollection


        mDSOStockTransactions.ResetStockTransactionValuations(mSI.StockItemID, 0, mSI.StdCost)

      Next



    End If


    If mDBConn.IsConnected Then mDBConn.Disconnect()
  End Sub

  Private Sub nbiSalesOrderReview_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nbiSalesOrderReview.LinkClicked
    'frmSalesOrderReview.OpenModal()
  End Sub

  Private Sub bbtnDeleteSI_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnDeleteSI.LinkClicked
    Dim mDBConn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
    Dim mdtoSIL As New dtoStockItemLocation(mDBConn)
    Dim mdtoMR As New dtoMaterialRequirement(mDBConn)
    Dim mdtoPB As New dtoProductBOM(mDBConn)
    Dim mdtoPOI As New dtoPurchaseOrderItem(mDBConn)
    Dim mdtoStockTakeIte As New dtoStockTakeItem(mDBConn)

    Dim mSILs As New colStockItemLocations
    Dim mMRs As New colMaterialRequirements
    Dim mPBs As New colProductBOMs
    Dim mPOIs As New colPurchaseOrderItems(New dmPurchaseOrder)
    Dim mSTIs As New colStockTakeItems
    Dim mListIDs As New List(Of Int32)

    mDBConn.Connect()


    mdtoSIL.LoadStockItemLocationCollectionByWhere(mSILs, "")
    mdtoMR.LoadMaterialRequirementCollectionByWhere(mMRs, "")
    mdtoPB.LoadProductBOMAllCollectionByWhere(mPBs, "")
    mdtoStockTakeIte.LoadStockTakeItemAllCollectionByWhere(mSTIs, "")
    mdtoPOI.LoadPurchaseOrderItemAllCollectionByWhere(mPOIs, "")


    For Each mSIL In mSILs

      If mSIL.StockItemID > 0 Then

        If mListIDs.Contains(mSIL.StockItemID) = False Then
          mListIDs.Add(mSIL.StockItemID)
        End If
      End If
    Next

    For Each mMR In mMRs

      If mMR.StockItemID > 0 Then

        If mListIDs.Contains(mMR.StockItemID) = False Then
          mListIDs.Add(mMR.StockItemID)
        End If
      End If
    Next

    For Each mPB In mPBs

      If mPB.StockItemID > 0 Then

        If mListIDs.Contains(mPB.StockItemID) = False Then
          mListIDs.Add(mPB.StockItemID)
        End If
      End If
    Next


    For Each mPOI In mPOIs

      If mPOI.StockItemID > 0 Then

        If mListIDs.Contains(mPOI.StockItemID) = False Then
          mListIDs.Add(mPOI.StockItemID)
        End If
      End If
    Next

    Dim mWhere As String = ""

    For Each myID In mListIDs

      If mWhere <> "" Then mWhere &= ","
      mWhere &= myID
    Next


    mWhere = String.Format("Delete from StockItem where StockItemID not in ({0}) and category<>{1}", mWhere, CInt(eStockItemCategory.Timber))
    mDBConn.ExecuteNonQuery(mWhere)
    mDBConn.Disconnect()

  End Sub

  Private Sub bbtnDecToFrac_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnDecToFrac.LinkClicked

    Dim mString As String = InputBox("Valor decimal")
    Dim mDec As Decimal

    mDec = Decimal.Parse(mString)


    Dim mFract As String

    mFract = clsSMSharedFuncs.FractStrFromDec(mDec)

    MessageBox.Show(mFract)
  End Sub

  Private Sub bbtnStringToDec_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnStringToDec.LinkClicked
    Dim mString As String = InputBox("Valor Fracción string")
    Dim mFract As Decimal

    mFract = clsSMSharedFuncs.DecFromFractString(mString)

    MessageBox.Show(mFract)
  End Sub

  Private Sub bbtnImportWoodPalletFromTemplate_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnImportWoodPalletFromTemplate.LinkClicked
    Dim mWhere As String = ""
    Dim mWoodPallets As New colWoodPallets
    Dim mDBConn As RTIS.DataLayer.clsDBConnBase
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions
    Dim mTempPallets As New colTempPallets
    Dim mListBultos As New List(Of String)
    Dim mNewListWoodPallet As New colWoodPallets

    mWhere = "PalletType=" & CInt(eStockItemTypeTimberWood.Primera)
    mDBConn = My.Application.RTISUserSession.CreateMainDBConn
    Try
      mDBConn.Connect()

      mdsoStock = New dsoStock(mDBConn)

      mdsoStock.LoadTempPallets(mTempPallets, "")

      For Each mTP In mTempPallets

        If mListBultos.Contains(mTP.Bulto) = False Then
          Dim mNewWoodPallet As New dmWoodPallet
          mNewWoodPallet.CardNumber = mTP.Bulto
          mNewWoodPallet.CreatedDate = Now
          mNewWoodPallet.LocationID = mTP.LocationID
          mNewWoodPallet.PalletType = eStockItemTypeTimberWood.Primera
          mListBultos.Add(mTP.Bulto)
          mNewListWoodPallet.Add(mNewWoodPallet)

        End If

      Next



      For Each mWP In mNewListWoodPallet

        For Each mTemPallet In mTempPallets

          If mWP.CardNumber = mTemPallet.Bulto Then
            Dim mNewWPI As New dmWoodPalletItem
            Dim mStockItem As New dmStockItem
            Dim mFoundSI As dmStockItem

            mStockItem.Species = mTemPallet.SpeciesID
            mStockItem.Category = eStockItemCategory.Timber
            mStockItem.Thickness = mTemPallet.Grosor
            mStockItem.ItemType = eStockItemTypeTimberWood.Primera
            mStockItem.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mStockItem, mDBConn)
            mStockItem.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mStockItem)

            mFoundSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromSameSpec(mStockItem)

            If mFoundSI IsNot Nothing Then
            Else
              mFoundSI = mStockItem.Clone
              mFoundSI.ClearKeys()

              AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mFoundSI)
            End If
            mNewWPI.Description = mFoundSI.Description
            mNewWPI.Length = mTemPallet.Largo
            mNewWPI.Thickness = mTemPallet.Grosor
            mNewWPI.Width = mTemPallet.Ancho
            mNewWPI.StockItemID = mFoundSI.StockItemID
            mNewWPI.StockCode = mFoundSI.StockCode
            mNewWPI.Quantity = mTemPallet.Cantidad
            mNewWPI.QuantityUsed = 0
            mNewWPI.OutstandingQty = mNewWPI.Quantity - mNewWPI.QuantityUsed
            mWP.WoodPalletItems.Add(mNewWPI)

          End If

        Next

      Next

      mdsoStock.SaveWoodPalletCollectionDown(mNewListWoodPallet)


      mdsoTran = New dsoStockTransactions(mDBConn)


      For Each mWP As dmWoodPallet In mNewListWoodPallet


        mdsoTran.CreatePositiveTransaction(eTransactionType.WoodAmendment, mWP, mWP.LocationID, Now, eCurrency.Dollar, 1, False)


      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mDBConn.IsConnected Then mDBConn.Disconnect()
    End Try
  End Sub

  Private Sub bbtnUpdatePONetValue_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnUpdatePONetValue.LinkClicked
    Dim mDBConn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
    Dim mdso As New dsoPurchasing(mDBConn)
    Dim mColPOs As New colPurchaseOrders


    mDBConn.Connect()

    mdso.LoadPurchaseOrderCollectionDown(mColPOs, "")

    For Each mPO As dmPurchaseOrder In mColPOs

      mPO.TotalNetValue = mPO.CalculateNetValue
      mdso.SavePurchaseOrderDownNEW(mPO)
    Next


  End Sub

  Private Sub bbtnNewEmail_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnNewEmail.LinkClicked

    Try
      Dim mEmail As New RTIS.EmailLib.clsEmailManager
      Dim mSubject As String = "Testing axel"
      Dim mEmployees As New colEmployees
      Dim mdbconn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
      Dim mdso As New dsoAdminEmployee(mdbconn)

      mdso.LoadEmployees(mEmployees)

      mEmail.EmailSettings.DelMethod = AppRTISGlobal.GetInstance.EmailSettings.DelMethod
      mEmail.EmailSettings.Domain = AppRTISGlobal.GetInstance.EmailSettings.Domain
      mEmail.EmailSettings.Password = AppRTISGlobal.GetInstance.EmailSettings.Password
      mEmail.EmailSettings.Port = AppRTISGlobal.GetInstance.EmailSettings.Port
      mEmail.EmailSettings.SMTP = AppRTISGlobal.GetInstance.EmailSettings.SMTP
      mEmail.EmailSettings.UseDefaultCredentials = AppRTISGlobal.GetInstance.EmailSettings.UseDefaultCredentials
      mEmail.EmailSettings.UserName = AppRTISGlobal.GetInstance.EmailSettings.UserName
      mEmail.EmailSettings.EnableSSL = AppRTISGlobal.GetInstance.EmailSettings.EnableSSL


      mEmail.EmailMessage.SendFrom = "testing@agroforestal.co"


      mEmail.EmailMessage.SendTo = "axelroman1992@gmail.com"

      mSubject = "testing agroforestal subject"

      mEmail.EmailMessage.Subject = mSubject

      mEmail.EmailMessage.BodyHtml = "<p>Nuew body</>"
      mEmail.EmailMessage.IsBodyHtml = True

      Dim mfrm As New frmRichTextEmail(mEmail, mdbconn, AppRTISGlobal.GetInstance)

      mfrm.Employees = mEmployees

      mfrm.EmailSettings = mEmail.EmailSettings

      mfrm.PopulateMail()

      If mfrm.ShowDialog() = DialogResult.OK OrElse mdbconn.RTISUser.IsSecurityAllowAll Then

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub SetPOAllocationWorkOrderIDs()
    Dim mdso As dsoPurchasing
    Dim mdbconn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
    Dim mPOIAs As New colPurchaseOrderItemAllocations
    Dim mPOAs As New colPurchaseOrderAllocations
    Dim mPOStageID As Integer
    Dim mWorkOrderID As Integer
    Dim mFilterDesc As String = ""
    Dim mWhere As String = ""


    Try

      mdso = New dsoPurchasing(mdbconn)
      mWhere = "IsNull(WorkOrderID,0)=0"
      mdso.LoadPurchaseOrderItemAllocationsByWheres(mPOIAs, mWhere)
      mdso.LoadPurchaseOrderAllocationsByWhere(mPOAs, mWhere)


      For Each mPOIA As dmPurchaseOrderItemAllocation In mPOIAs
        mWorkOrderID = 0
        mPOStageID = 0
        If Not mdbconn.IsConnected Then mdbconn.Connect()


        mPOStageID = mdbconn.ExecuteScalar(String.Format("Select IsNull(POStage,0) from PurchaseOrder where PurchaseOrderID in (select PurchaseOrderID from PurchaseOrderItem where PurchaseOrderItemID={0})", mPOIA.PurchaseOrderItemID))


        mWhere = "Select IsNull(WOA.WorkOrderID,0) from WorkOrderAllocation WOA"
        mWhere &= " inner join WorkOrder WO ON WO.WorkOrderID=WOA.WorkOrderID"
        mWhere &= " INNER JOIN SalesOrderPhaseItem SOPI ON sopi.SalesOrderPhaseItemID = WOA.SalesOrderPhaseItemID"

        Select Case mPOStageID
          Case ePOStage.Fundaciones
            mFilterDesc = "%funda%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Bathroom
            mFilterDesc = "%bathrom%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.CieloRaso
            mFilterDesc = "%cielo%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.InstalacionesElectricas
            mFilterDesc = "%electrica%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Paredes
            mFilterDesc = "%parede%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Pisos
            mFilterDesc = "%piso%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.PuertasVentanas
            mFilterDesc = "%puerta%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Techo
            mFilterDesc = "%techo%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOIA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

        End Select


        If mWorkOrderID > 0 Then ''WO found
          mWhere = String.Format("Update PurchaseOrderItemAllocation set WorkOrderID = {0} where PurchaseOrderItemAllocationID = {1} ", mWorkOrderID, mPOIA.PurchaseOrderItemAllocationID)
          mdbconn.ExecuteNonQuery(mWhere)





        End If

      Next



      For Each mPOA As dmPurchaseOrderAllocation In mPOAs
        mWorkOrderID = 0
        mPOStageID = 0
        If Not mdbconn.IsConnected Then mdbconn.Connect()


        mPOStageID = mdbconn.ExecuteScalar(String.Format("Select IsNull(POStage,0) from PurchaseOrder where PurchaseOrderID ={0}", mPOA.PurchaseOrderID))


        mWhere = "Select IsNull(WOA.WorkOrderID,0) from WorkOrderAllocation WOA"
        mWhere &= " inner join WorkOrder WO ON WO.WorkOrderID=WOA.WorkOrderID"
        mWhere &= " INNER JOIN SalesOrderPhaseItem SOPI ON sopi.SalesOrderPhaseItemID = WOA.SalesOrderPhaseItemID"

        Select Case mPOStageID
          Case ePOStage.Fundaciones
            mFilterDesc = "%funda%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Bathroom
            mFilterDesc = "%bathrom%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.CieloRaso
            mFilterDesc = "%cielo%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.InstalacionesElectricas
            mFilterDesc = "%electrica%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Paredes
            mFilterDesc = "%parede%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Pisos
            mFilterDesc = "%piso%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.PuertasVentanas
            mFilterDesc = "%puerta%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

          Case ePOStage.Techo
            mFilterDesc = "%techo%"
            mWhere &= String.Format(" Where Wo.Description like '{0}' and SOPI.SalesOrderPhaseID={1}", mFilterDesc, mPOA.CallOffID)

            mWorkOrderID = mdbconn.ExecuteScalar(mWhere)

        End Select


        If mWorkOrderID > 0 Then ''WO found
          mWhere = String.Format("Update PurchaseOrderAllocation set WorkOrderID = {0} where PurchaseOrderAllocationID = {1} ", mWorkOrderID, mPOA.PurchaseOrderAllocationID)
          mdbconn.ExecuteNonQuery(mWhere)

          mWhere = String.Format("Update PurchaseOrder set MaterialRequirementTypeWorkOrderID = 3,MaterialRequirementTypeID=null where PurchaseOrderID = {0} ", mPOA.PurchaseOrderID)
          mdbconn.ExecuteNonQuery(mWhere)

        Else ''Create a WO,WOA
        End If

      Next


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If mdbconn.IsConnected Then mdbconn.Disconnect()
      mdso = Nothing
    End Try
    '// Get a list of the PurchaseOrderItemAllocations with a 0 in WorkOrderID

    '// For each POIA
    '// Find the POStage for the PurchaseOrder
    '// mPOStage =  pdbconn.ExecuteScaler("Select POStage form urchaseOrder where purchaseorderid = )
    '// return the workdorderid from a suitable Workorderallocation inner join workorder inner join salesrderphaseitem by a like '%Fund%' and a SOPI.SalesOrderPhaseID = POA CallOffID

    '// if we find a workorderid
    '// pbconn.executenonquery("Update")

    '// else
    '// If we didn't find a salesorderphaseitem then we need to create a new worksorder with workorderallocation and use that ID


  End Sub

  Private Function CreateWOA(ByRef rdbconn As clsDBConnBase, ByVal vPOIA As dmPurchaseOrderItemAllocation) As dmWorkOrderAllocation
    Dim mWOA As New dmWorkOrderAllocation

    mWOA.QuantityRequired = 1

    If vPOIA.CallOffID > 0 Then




    End If

    mWOA.SalesOrderPhaseItemID = 1

    Return mWOA
  End Function

  Private Function CreateWorkOrder(ByRef rdbconn As clsDBConnBase, ByVal vPOIA As dmPurchaseOrderItemAllocation, ByVal vPOStageID As Integer) As dmWorkOrder
    Dim mdsoGeneral As dsoGeneral
    Dim mWO As New dmWorkOrder

    mdsoGeneral = New dsoGeneral(rdbconn)
    mWO.WorkOrderNo = "OT-" & mdsoGeneral.GetNextTallyWONo().ToString("00000")


    mWO.DateCreated = Now
    mWO.ProductTypeID = eProductType.StructureAF
    mWO.Quantity = 1
    mWO.ProductID = 61 ''Global Product
    mWO.PlannedStartDate = Now
    mWO.Description = GetDescriptionOT(rdbconn, vPOIA, vPOStageID)
    mWO.isInternal = True
    mWO.Status = eWorkOrderStatus.InProcess

    Return mWO
  End Function

  Private Function GetDescriptionOT(ByRef rDBConn As clsDBConnBase, ByVal vPOIA As dmPurchaseOrderItemAllocation, vPOStageID As Integer) As String
    Dim mWhere As String = ""
    Dim mProjectRef As String = ""

    If vPOIA.CallOffID > 0 Then ''//Not To Stock
      mWhere = "select Distinct ProjectName from SalesOrder"
      mWhere &= String.Format(" where SalesOrderID in (select salesorderid from SalesOrderPhase where SalesOrderPhaseID={0})", vPOIA.CallOffID)

      mProjectRef = rDBConn.ExecuteScalar(mWhere)

      If mProjectRef <> "" Then
        mProjectRef = clsEnumsConstants.GetEnumDescription(GetType(ePOStage), CType(vPOStageID, ePOStage)) & " - " & mProjectRef

      Else
        mProjectRef = clsEnumsConstants.GetEnumDescription(GetType(ePOStage), CType(vPOStageID, ePOStage))
      End If
    End If

    Return mProjectRef

  End Function

  Private Sub bbtnUpdatePOIA_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnUpdatePOIA.LinkClicked
    SetPOAllocationWorkOrderIDs()
  End Sub

  Private Sub btnUpdateWoodTransaction_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnUpdateWoodTransaction.LinkClicked
    Dim mdsoCostBook As dsoCostBook
    Dim mdsoTransactions As dsoStockTransactions
    Dim mdbconn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
    Dim mCOEntrys As New colCostBookEntrys
    Dim mStockItemTransactionLogInfos As New colStockItemTransactionLogInfos
    Dim mCostBookEntryFound As dmCostBookEntry
    Dim mWhere As String
    Dim mNewTransactionValue As Decimal

    Try
      mdsoTransactions = New dsoStockTransactions(mdbconn)
      mdsoCostBook = New dsoCostBook(mdbconn)
      mWhere = " RefObjectID in (select WoodPalletID from WoodPallet where WorkOrderID>0)"

      mdsoTransactions.LoadStockItemTransactionsWoodByWhere(mStockItemTransactionLogInfos, mWhere)

      mWhere = " StockItemID in (select StockItemID from StockItemLocation where StockItemLocationID in (select ObjectID from StockItemTransactionLog"
      mWhere &= " where RefObjectID in (select WoodPalletID from WoodPallet where WorkOrderID>0)))"

      mdsoCostBook.LoadCostBookEntryByWhere(mCOEntrys, mWhere)
      For Each mSITLI As clsStockItemTransactionLogInfo In mStockItemTransactionLogInfos
        mWhere = ""
        If mSITLI.TransactionValuation = 0 Then

          If Not mdbconn.IsConnected Then mdbconn.Connect()
          If mSITLI.CurrentStockItem IsNot Nothing Then

            If mSITLI.CurrentStockItem.StockItemID > 0 Then
              mCostBookEntryFound = mCOEntrys.ItemFromStockItemID(mSITLI.CurrentStockItem.StockItemID)

              If mCostBookEntryFound IsNot Nothing Then
                mNewTransactionValue = mSITLI.TransQuantity * mCostBookEntryFound.Cost

                mWhere = String.Format("Update StockItemTransactionLog set TransactionValuation ={0}, TransactionValuationDollar ={0} where StockItemTransactionLogID={1}", mNewTransactionValue, mSITLI.StockItemTransactionLogID)

                mdbconn.ExecuteScalar(mWhere)

              End If

            End If

          End If

        End If

      Next
      If mdbconn.IsConnected Then mdbconn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If mdbconn.IsConnected Then mdbconn.Disconnect()
      mdsoCostBook = Nothing
      mdsoTransactions = Nothing

    End Try
  End Sub

  Private Sub btnUpdatePOItemSOPI_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles btnUpdatePOItemSOPI.LinkClicked
    Dim mdbconn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn
    Dim mDataTable As New DataTable
    Dim mSQL As String = ""
    Dim mRow As DataRow
    Dim mPurchaseOrderAllocationID As Object
    Dim mCallOffID As Object
    Dim mPOStage As Object
    Dim mSalesOrderPhaseItemID As Object
    Dim mPurchaseOrderItemAllocationID As Object
    Dim mPurchaseOrderID As Object

    Try
      mdbconn.Connect()
      mSQL = "Select PurchaseOrderAllocationID, IsNull(CallOffID,0) CallOffID,IsNull(POStage,0) POStage,PO.PurchaseOrderID "
      mSQL &= " from PurchaseOrderAllocation POA"
      mSQL &= " INNER JOIN PurchaseOrder PO ON PO.PurchaseOrderID=POA.PurchaseOrderID"
      mSQL &= " where POA.WorkOrderID=0"

      mDataTable = mdbconn.CreateDataTable(mSQL)

      For Each mRow In mDataTable.Rows
        mSQL = ""
        mPurchaseOrderAllocationID = mRow("PurchaseOrderAllocationID")
        mCallOffID = mRow("CallOffID")
        mPOStage = mRow("POStage")
        mPurchaseOrderID = mRow("PurchaseOrderID")
        If mCallOffID IsNot Nothing And mPOStage IsNot Nothing Then
          mSQL = "select SalesOrderPhaseItemID from SalesOrderPhaseItem SOPI "
          mSQL &= " inner join SalesOrderItem SOI on SOI.SalesOrderItemID=SOPI.SalesItemID "

          mSQL &= String.Format(" where SalesOrderPhaseID={0} and SOPIStep={1}", mCallOffID, mPOStage)
          mSalesOrderPhaseItemID = mdbconn.ExecuteScalar(mSQL)

          If mSalesOrderPhaseItemID IsNot Nothing And mPurchaseOrderAllocationID IsNot Nothing Then
            mSQL = "Update PurchaseOrderAllocation"
            mSQL &= String.Format(" set SalesorderPhaseItemID = {0} where PurchaseOrderAllocationID= {1}", mSalesOrderPhaseItemID, mPurchaseOrderAllocationID)
            mdbconn.ExecuteNonQuery(mSQL)

            If mPurchaseOrderID IsNot Nothing Then
              mSQL = String.Format("Update PurchaseOrder set MaterialRequirementTypeWorkOrderID = null,MaterialRequirementTypeID=3 where PurchaseOrderID = {0} ", mPurchaseOrderID)
              mdbconn.ExecuteNonQuery(mSQL)

            End If
          Else
              If mCallOffID IsNot Nothing Then
              mSQL = "select top 1 SalesOrderPhaseItemID from SalesOrderPhaseItem SOPI "
              mSQL &= " inner join SalesOrderItem SOI on SOI.SalesOrderItemID = SOPI.SALESITEMID"
              mSQL &= String.Format(" where SalesOrderPhaseID={0}", mCallOffID)

              mSalesOrderPhaseItemID = mdbconn.ExecuteScalar(mSQL)
              If mSalesOrderPhaseItemID IsNot Nothing Then
                mSQL = "Update PurchaseOrderAllocation"
                mSQL &= String.Format(" set SalesorderPhaseItemID = {0} where PurchaseOrderAllocationID= {1}", mSalesOrderPhaseItemID, mPurchaseOrderAllocationID)
                mdbconn.ExecuteNonQuery(mSQL)

                If mPurchaseOrderID IsNot Nothing Then
                  mSQL = String.Format("Update PurchaseOrder set MaterialRequirementTypeWorkOrderID = null,MaterialRequirementTypeID=3 where PurchaseOrderID = {0} ", mPurchaseOrderID)
                  mdbconn.ExecuteNonQuery(mSQL)

                End If

              End If
            End If


          End If

          End If

      Next



      ''Update PurchaseOrderItemAllocatoin

      mSQL = "Select PurchaseOrderItemAllocationID, IsNull(CallOffID,0) CallOffID,IsNull(POStage,0) POStage "
      mSQL &= " from PurchaseOrderItemAllocation POIA"
      mSQL &= " INNER JOIN PurchaseOrderItem POI ON POI.PurchaseOrderItemID=POIA.PurchaseOrderItemID"
      mSQL &= " INNER JOIN PurchaseOrder PO ON PO.PurchaseOrderID=POI.PurchaseOrderID"
      mSQL &= " where POIA.WorkOrderID=0 "

      mDataTable = New DataTable
      mDataTable = mdbconn.CreateDataTable(mSQL)

      For Each mRow In mDataTable.Rows
        mSQL = ""
        mPurchaseOrderItemAllocationID = mRow("PurchaseOrderItemAllocationID")
        mCallOffID = mRow("CallOffID")
        mPOStage = mRow("POStage")

        If mCallOffID IsNot Nothing And mPOStage IsNot Nothing Then
          mSQL = "select SalesOrderPhaseItemID from SalesOrderPhaseItem SOPI "
          mSQL &= " inner join SalesOrderItem SOI on SOI.SalesOrderItemID=SOPI.SalesItemID "

          mSQL &= String.Format(" where SalesOrderPhaseID={0} and SOPIStep={1}", mCallOffID, mPOStage)
          mSalesOrderPhaseItemID = mdbconn.ExecuteScalar(mSQL)

          If mSalesOrderPhaseItemID IsNot Nothing And mPurchaseOrderItemAllocationID IsNot Nothing Then
            mSQL = "Update PurchaseOrderItemAllocation"
            mSQL &= String.Format(" set SalesorderPhaseItemID = {0} where PurchaseOrderItemAllocationID= {1}", mSalesOrderPhaseItemID, mPurchaseOrderItemAllocationID)
            mdbconn.ExecuteNonQuery(mSQL)

          Else
            If mCallOffID IsNot Nothing Then
              mSQL = "select top 1 SalesOrderPhaseItemID from SalesOrderPhaseItem SOPI "
              mSQL &= " inner join SalesOrderItem SOI on SOI.SalesOrderItemID = SOPI.SALESITEMID"
              mSQL &= String.Format(" where SalesOrderPhaseID={0}", mCallOffID)

              mSalesOrderPhaseItemID = mdbconn.ExecuteScalar(mSQL)
              If mSalesOrderPhaseItemID IsNot Nothing Then
                mSQL = "Update PurchaseOrderItemAllocation"
                mSQL &= String.Format(" set SalesorderPhaseItemID = {0} where PurchaseOrderItemAllocationID= {1}", mSalesOrderPhaseItemID, mPurchaseOrderItemAllocationID)
                mdbconn.ExecuteNonQuery(mSQL)
              End If
            End If


          End If

        End If

      Next

      mdbconn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub

  Private Sub bbtnUpdatePOManToNoMan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnUpdatePOManToNoMan.LinkClicked
    Dim mdbconn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn


    frmUpdatePOManToPONonMan.OpenModal(mdbconn, "ToNonMan")
  End Sub

  Private Sub bbtnUpdatePONonManToMan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles bbtnUpdatePONonManToMan.LinkClicked
    Dim mdbconn As clsDBConnBase = My.Application.RTISUserSession.CreateMainDBConn


    frmUpdatePOManToPONonMan.OpenModal(mdbconn, "ToMan")
  End Sub
End Class
