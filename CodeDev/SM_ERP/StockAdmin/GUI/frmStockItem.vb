Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base

Public Class frmStockItem

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pCurrentDetailMode As eCurrentDetailMode
  Private pFormController As fccStocktem

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
  End Enum

  Private Enum eDetailButtons
    Edit = 1
    Save = 2
  End Enum

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Private Sub barRGObsoleteItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barRGObsoleteItems.ItemClick

  End Sub

  Private Sub frmStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    pIsActive = False
    pFormController.LoadObject()
    RefreshAddStockItemOptions()
    grdStockItems.DataSource = pFormController.StockItems
    LoadCombos()

    RefreshControls()
    pIsActive = True
  End Sub

  Private Sub RefreshAddStockItemOptions()
    Dim mItem As DevExpress.XtraBars.BarButtonItem

    barbtnAddStockItemCat.ClearLinks()

    For Each mCat As eStockItemCategory In pFormController.Categorys
      mItem = New DevExpress.XtraBars.BarButtonItem
      mItem.Caption = "Agregar " & RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), mCat) & " Stock Item"
      mItem.Tag = mCat
      AddHandler mItem.ItemClick, AddressOf AddStockItemCat
      barbtnAddStockItemCat.AddItem(mItem)
    Next

  End Sub

  Private Sub AddStockItemCat(sender As Object, e As EventArgs)
    Dim mCategory As eStockItemCategory
    Dim mNewStockItem As dmStockItem

    mCategory = CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag
    mNewStockItem = pFormController.AddStockItem(1, mCategory)

    gvStockItems.RefreshData()
    gvStockItems.FindRow(mNewStockItem)
    gvStockItems.FocusedRowHandle = gvStockItems.FindRow(mNewStockItem)
    pCurrentDetailMode = eCurrentDetailMode.eEdit
    RefreshDetailButtons()
    SetDetailFocus()
    SetDetailsControlsReadonly(False)
  End Sub

  Private Sub RefreshDetailButtons()
    Select Case pCurrentDetailMode
      Case eCurrentDetailMode.eEdit
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpCurrentStockItem.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = True
        Next
      Case eCurrentDetailMode.eView
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpCurrentStockItem.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = False
        Next
    End Select
  End Sub

  Private Sub SetDetailFocus()
    txtDescription.Focus()
  End Sub

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vCategorys As List(Of eStockItemCategory))
    Dim mfrm As frmStockItem = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmStockItem
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStocktem(rDBConn, rRTISGlobal)
      mfrm.pFormController.Categorys = vCategorys

      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub
  Private Shared Function GetFormIfLoaded() As frmStockItem
    Dim mfrmWanted As frmStockItem = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmStockItem
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmStockItem Then
        mfrmWanted = mfrm
        mFound = True
        Exit For
      End If
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Private Sub frmStockItem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub


  Private Sub grpCurrentStockItem_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpCurrentStockItem.CustomButtonClick
    Select Case e.Button.Properties.Tag
      Case eDetailButtons.Edit
        Dim mSI As dmStockItem
        mSI = gvStockItems.GetFocusedRow
        pFormController.LoadStockItemExtraDetails()
        ShowHideDetails()
        pCurrentDetailMode = eCurrentDetailMode.eEdit
        SetDetailsControlsReadonly(False)
        SetDetailFocus()
        RefreshCategorySpecificControls()
        RefreshControls()
      Case eDetailButtons.Save
        UpdateObject()
        pFormController.SaveObject()
        pCurrentDetailMode = eCurrentDetailMode.eView
        gvStockItems.RefreshData()
        SetDetailsControlsReadonly(True)
        RefreshControls()
    End Select
    RefreshDetailButtons()
  End Sub

  Private Sub gvStockItems_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvStockItems.FocusedRowObjectChanged
    Dim mSI As dmStockItem
    Try
      mSI = TryCast(e.Row, dmStockItem)
      If mSI IsNot Nothing Then
        pFormController.CurrentStockItem = e.Row
        ShowHideDetails()
        pCurrentDetailMode = eCurrentDetailMode.eView
        RefreshDetailButtons()
        RefreshCategorySpecificControls()
        RefreshControls()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub RefreshControls()

    Dim mStartActive As Boolean = pIsActive

    pIsActive = False

    If pFormController.CurrentStockItem IsNot Nothing Then

      With pFormController.CurrentStockItem
        txtDescription.Text = .Description
        txtStockCode.Text = .StockCode
        spnLength.EditValue = .Length
        spnWidth.EditValue = .Width
        spnThickness.EditValue = .Thickness
        spnQuantity.EditValue = .StockQuantity
        txtDescriptionShort.Text = .ShortDescription
        txtPartNo.Text = .PartNo
        txtColour.Text = .Colour
        lblStockItemID.Text = "ID: " & .StockItemID
        clsDEControlLoading.SetDECombo(cboCategory, .Category)
        clsDEControlLoading.SetDECombo(cboItemType, .ItemType)
        clsDEControlLoading.SetDECombo(cboSpecies, .Species)
        clsDEControlLoading.SetDECombo(cboStockFinanceCategory, .StockFinanceCategoryID)
        clsDEControlLoading.SetDECombo(cboSubitemType, .SubItemType)
        clsDEControlLoading.SetDECombo(cboFinish, .Finish)
        clsDEControlLoading.SetDECombo(cboDefaultSupplier, .DefaultSupplier)
        chkcboActiveCondition.RefreshEditValue()
        clsDEControlLoading.SetDECombo(cboHanding, .Handing)

        If pFormController.CurrentStockItemOpposite IsNot Nothing Then
          btedOppositeItem.Text = pFormController.CurrentStockItemOpposite.StockCode

        Else
          btedOppositeItem.Text = ""
        End If


        If pFormController.CurrentStockItem.InterdenStockItemID <> 0 Then
          bteInterdenStockItem.Text = pFormController.InterdenStockItem.Description

        Else
          bteInterdenStockItem.Text = ""
        End If

        chkIsGeneric.Checked = .IsGeneric
        chkIsObsolete.Checked = .Inactive

      End With
    End If

    If pCurrentDetailMode = eCurrentDetailMode.eView Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      SetDetailsControlsReadonly(False)
    End If

    pIsActive = mStartActive
  End Sub

  Private Sub LoadCombos()

    Dim mVIs As colValueItems

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    For mLoop As Integer = mVIs.Count - 1 To 0 Step -1
      If pFormController.Categorys.Contains(mVIs(mLoop).ItemValue) = False Then
        mVIs.RemoveAt(mLoop)
      End If
    Next
    clsDEControlLoading.FillDEComboVI(cboCategory, mVIs)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItems, gcCategory, mVIs)

  End Sub

  Private Sub UpdateObject()

    If pFormController.CurrentStockItem IsNot Nothing Then
      With pFormController.CurrentStockItem
        .Description = txtDescription.Text
        .StockCode = txtStockCode.Text
        .Length = spnLength.EditValue
        .Width = spnWidth.EditValue
        .Thickness = spnThickness.EditValue
        .StockQuantity = spnQuantity.EditValue
        .ShortDescription = txtDescriptionShort.Text
        .PartNo = txtPartNo.Text
        .Colour = txtColour.Text
        .Category = clsDEControlLoading.GetDEComboValue(cboCategory)
        .ItemType = clsDEControlLoading.GetDEComboValue(cboItemType)
        .SubItemType = clsDEControlLoading.GetDEComboValue(cboSubitemType)
        .Species = clsDEControlLoading.GetDEComboValue(cboSpecies)
        .StockFinanceCategoryID = clsDEControlLoading.GetDEComboValue(cboStockFinanceCategory)
        .Finish = clsDEControlLoading.GetDEComboValue(cboFinish)
        .DefaultSupplier = clsDEControlLoading.GetDEComboValue(cboDefaultSupplier)
        .IsGeneric = chkIsGeneric.Checked
        .Inactive = chkIsObsolete.Checked


      End With
    End If

  End Sub
  Private Sub RefreshCategorySpecificControls()
    Dim mStartActive As Boolean = pIsActive
    ''Dim mcoltemTypes As colSubItemTypes
    ''Dim mcolSubItemTypes2 As colSubItemTypes
    Dim mItem As clsRefListItem
    Dim mVIs As New colValueItems
    pIsActive = False

    If pFormController.CurrentStockItem IsNot Nothing Then

      ''  ''  mcolSubItemTypes = CType(pFormController.RTISGlobal.RefLists(appRefLists.SubItemType).IList, colSubItemTypes)
      ''  ''  If mcolSubItemTypes IsNot Nothing Then
      ''  ''    mcolSubItemTypes2 = mcolSubItemTypes.GetByItemType(pFormController.CurrentStockItem.ItemType)
      ''  ''    If mcolSubItemTypes2.Count > 0 Then
      ''  ''      mItem = New clsRefListItem(999, "Temp", clsRefListItem.eLoadMode.Loaded)
      ''  ''      mItem.IList = mcolSubItemTypes2
      ''  ''      mVIs = mItem.ListAsValueItems
      ''  ''    End If

      ''End If

      ''  clsDEControlLoading.FillDEComboVI(cboSubitemType, mVIs)

      Select Case pFormController.CurrentStockItem.Category

        Case eStockItemCategory.Abrasivos

          Dim mAbrasivosType As clsStockItemTypeAbrasivos
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeAbrasivos.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.EPP
          clsDEControlLoading.FillDEComboVI(cboItemType, Nothing)
          cboSpecies.Enabled = True
          cboItemType.Enabled = False
          cboSubitemType.Enabled = False

        Case eStockItemCategory.Herrajes

          Dim mHerrajesType As clsStockItemTypeHerrajes
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerrajes.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.Herramientas

          clsDEControlLoading.FillDEComboVI(cboItemType, Nothing)
          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.MatElect

          Dim mMatElectrico As clsStockItemTypeMaterialElectrico
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialElectrico.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.MatEmpaque

          Dim mMatEmpaque As clsStockItemTypeMaterialEmpaque
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialEmpaque.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.MatVarios

          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.Metal

          Dim mMetalType As clsStockItemTypeMetales
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMetales.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True


        Case eStockItemCategory.NailsAndBolds

          Dim mNailsAndBoltsType As clsStockItemTypeNailsAndBolts
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeNailsAndBolts.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True


        Case eStockItemCategory.PinturaYQuimico

          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.Plywood

          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.Repuestos

          Dim mRepuestosType As clsStockItemTypeRepuestosYPartes
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeRepuestosYPartes.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.Tapiceria

          Dim mTapiceria As clsStockItemTypeTapiceria
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeTapiceria.GetInstance.ValueItems)


          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case eStockItemCategory.VidrioYEspejo

          Dim mVidrioType As clsStockItemTypeVidrioYEspejo
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeVidrioYEspejo.GetInstance.ValueItems)
          'mVidrioType = eStockItemTypeVidrioYEspejo.GetInstance.ItemFromKey(pFormController.CurrentStockItem.ItemType)
          If mVidrioType IsNot Nothing Then

            clsDEControlLoading.FillDEComboVIi(cboSubitemType, mVidrioType.StockSubItemTypeVidrioYEspejo)
          End If

          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboSubitemType.Enabled = True

        Case Else
          ''cboSpecies.Enabled = False
          ''cboItemType.Enabled = False
          ''cboSubitemType.Enabled = False
      End Select

    End If

    pIsActive = mStartActive
  End Sub

  Private Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)
    txtDescription.ReadOnly = vReadOnly
    txtStockCode.ReadOnly = vReadOnly
    spnLength.ReadOnly = vReadOnly
    spnWidth.ReadOnly = vReadOnly
    spnThickness.ReadOnly = vReadOnly
    cboCategory.ReadOnly = vReadOnly
    cboItemType.ReadOnly = vReadOnly
    cboSubitemType.ReadOnly = vReadOnly
    txtColour.ReadOnly = vReadOnly
    spnQuantity.ReadOnly = vReadOnly
    txtDescriptionShort.ReadOnly = vReadOnly
    txtPartNo.ReadOnly = vReadOnly
    cboSpecies.ReadOnly = vReadOnly
    cboStockFinanceCategory.ReadOnly = vReadOnly
    cboSubitemType.ReadOnly = vReadOnly
    cboFinish.ReadOnly = vReadOnly
    cboDefaultSupplier.ReadOnly = vReadOnly
    cboCNCOpPrimaryLeaf.ReadOnly = vReadOnly
    cboCNCOpSecondaryLeaf.ReadOnly = vReadOnly
    cboCNCOpHangingJamb.ReadOnly = vReadOnly
    cboCNCOpClosingJamb.ReadOnly = vReadOnly
    cboCNCOpHead.ReadOnly = vReadOnly
    chkIsGeneric.Enabled = Not vReadOnly
    cboHanding.ReadOnly = vReadOnly
    btedOppositeItem.ReadOnly = vReadOnly
    spnMinCutLength.ReadOnly = vReadOnly
    spnMinCutWidth.ReadOnly = vReadOnly
    chkIsObsolete.Enabled = Not vReadOnly

    ''    btnedImageFile.ReadOnly = vReadOnly

    ''gvAlternateCodes.OptionsBehavior.ReadOnly = vReadOnly

    ''    gvBOM.OptionsBehavior.ReadOnly = vReadOnly

    ''    grdFixing.DataSource = pFormController.CurrentStockItem.StockItemFixings
  End Sub

  Public Sub ShowHideDetails()
    If pFormController.CurrentStockItem IsNot Nothing Then
      If pFormController.CurrentStockItem.tmpIsFullyLoadedDown = True Then
        tabExtraDetails.Visible = True

        ShowHideTabs()
      Else
        tabExtraDetails.Visible = False

      End If
    End If
  End Sub


  Private Sub ShowHideTabs()
    Dim mCurrentTabPage As DevExpress.XtraTab.XtraTabPage

    mCurrentTabPage = tabExtraDetails.SelectedTabPage

    tabExtraDetails.Visible = False
    For Each mPg As DevExpress.XtraTab.XtraTabPage In tabExtraDetails.TabPages
      mPg.PageVisible = False
    Next
    If pFormController.CurrentStockItem IsNot Nothing Then
      Select Case pFormController.CurrentStockItem.Category
        Case eStockItemCategory.Herrajes
          tabpgIMDetails.PageVisible = True
          tabpgCNCOperations.PageVisible = True
          tabExtraDetails.Visible = True
          ''Case eStockItemCategory.DoorBlank
          ''  tabpgDoorBlankDetails.PageVisible = True
          ''  tabExtraDetails.Visible = True
      End Select
    End If
    If mCurrentTabPage IsNot Nothing Then
      If mCurrentTabPage.PageVisible = True Then
        tabExtraDetails.SelectedTabPage = mCurrentTabPage
      End If
    End If

  End Sub


  Private Sub gvStockItems_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItems.CustomUnboundColumnData
    Dim mRow As dmStockItem
    Dim mVIs As New colValueItems
    ''Dim mSubTypes As colSubItemTypes
    ''Dim mSubType As clsSubItemType
    Dim mSubItemTypes As colStockItemTypes

    Dim mText As String = ""
    ''Dim mSISubItemTypeIron As clsStockSubItemTypeIronmongery
    mRow = TryCast(e.Row, dmStockItem)
    If mRow IsNot Nothing Then
      If e.IsGetData Then
        Select Case e.Column.Name
          Case gcItemType.Name
            Select Case mRow.Category

              Case eStockItemCategory.Abrasivos
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeAbrasivos), CType(mRow.ItemType, eStockItemTypeAbrasivos.eStockItemAbrasivos))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()


              Case eStockItemCategory.Herrajes
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerrajes), CType(mRow.ItemType, eStockItemTypeHerrajes.eStockItemHerrajes))
                e.Value = mText

                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.MatElect
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialElectrico), CType(mRow.ItemType, eStockItemTypeMaterialElectrico.eStockItemMaterialElectrico))
                e.Value = mText

                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.MatEmpaque
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialEmpaque), CType(mRow.ItemType, eStockItemTypeMaterialEmpaque.StockItemMaterialEmpaque))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.NailsAndBolds
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeNailsAndBolts), CType(mRow.ItemType, eStockItemTypeNailsAndBolts.eStockItemNailAndBolts))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.Repuestos
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeRepuestosYPartes), CType(mRow.ItemType, eStockItemTypeRepuestosYPartes.eStockItemRepuestosYPartes))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.Tapiceria
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTapiceria), CType(mRow.ItemType, eStockItemTypeTapiceria.eStockItemTapiceria))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.VidrioYEspejo
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeVidrioYEspejo), CType(mRow.ItemType, eStockItemTypeVidrioYEspejo.eStockItemVidrioYEspejo))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

              Case Else
                e.Value = ""
                SetDetailFocus()
                RefreshCategorySpecificControls()
                RefreshControls()

            End Select


        End Select


      End If
    End If

    RefreshControls()
  End Sub

  Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged

  End Sub

  Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged

  End Sub
End Class

