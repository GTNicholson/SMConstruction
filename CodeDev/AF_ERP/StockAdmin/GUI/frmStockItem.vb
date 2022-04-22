Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

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

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vCategorys As List(Of eStockItemCategory), ByRef rRegistry As clsStockItemRegistryBase)
    Dim mfrm As frmStockItem = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmStockItem()
      mfrm.MdiParent = rMDIParent
      mfrm.pFormController = New fccStocktem(rDBConn, rRTISGlobal, rRegistry)
      mfrm.pFormController.Categorys = vCategorys
      mfrm.Show()
    Else
      mfrm.Focus()
    End If
  End Sub

  Public Shared Function OpenAsModalGetID(ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vCategorys As List(Of eStockItemCategory), ByRef rRegistry As clsStockItemRegistryBase) As Integer
    Dim mfrm As frmStockItem = Nothing
    Dim mRetVal As Integer = -1

    mfrm = New frmStockItem
    mfrm.pFormController = New fccStocktem(rDBConn, rRTISGlobal, rRegistry)
    mfrm.pFormController.Categorys = vCategorys
    mfrm.ShowDialog()
    If mfrm.pFormController.CurrentStockItem IsNot Nothing Then
      mRetVal = mfrm.pFormController.CurrentStockItem.StockItemID
    End If
    Return mRetVal
  End Function


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

  Public ReadOnly Property FormController As fccStocktem
    Get
      Return pFormController
    End Get
  End Property

  Private Sub frmStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False
    Try
      pFormController.LoadObject()
      RefreshAddStockItemOptions()
      grdStockItems.DataSource = pFormController.StockItems
      LoadCombos()

      RefreshControls()
    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    pIsActive = True
  End Sub



  Private Sub RefreshAddStockItemOptions()
    Dim mItem As DevExpress.XtraBars.BarButtonItem

    barbtnAddStockItemCat.ClearLinks()

    For Each mCat As eStockItemCategory In pFormController.Categorys
      mItem = New DevExpress.XtraBars.BarButtonItem
      mItem.Caption = "Artículo de " & RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), mCat)
      mItem.Tag = mCat
      AddHandler mItem.ItemClick, AddressOf AddStockItemCat
      barbtnAddStockItemCat.AddItem(mItem)
    Next

  End Sub

  Private Sub AddStockItemCat(sender As Object, e As EventArgs)
    Dim mCategory As eStockItemCategory
    Dim mNewStockItem As dmStockItem
    Dim mRH As Integer
    mCategory = CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag
    mNewStockItem = pFormController.AddStockItem(1, mCategory)

    gvStockItems.RefreshData()

    mRH = gvStockItems.FindRow(mNewStockItem)

    If mRH >= 0 Then
      gvStockItems.FocusedRowHandle = mRH
    Else
      pFormController.CurrentStockItem = mNewStockItem
      ShowHideDetails()
      RefreshCategorySpecificControls()
      RefreshControls()
    End If
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
        RefreshControls()
        RefreshCategorySpecificControls()
        RefreshControls()
      Case eDetailButtons.Save
        UpdateObjects()
        'CheckStockCode()
        CheckDescriptionTimber()
        pFormController.SaveObject()
        pCurrentDetailMode = eCurrentDetailMode.eView
        gvStockItems.RefreshData()
        SetDetailsControlsReadonly(True)
        RefreshControls()
    End Select
    RefreshDetailButtons()
  End Sub

  Private Function CheckDescriptionTimber() As Boolean
    Dim mRetval As Boolean
    Dim mProposedDescription As String
    If pFormController.CurrentStockItem.Description = "" And pFormController.CurrentStockItem.Category = eStockItemCategory.Timber Then
      mProposedDescription = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(pFormController.CurrentStockItem)
      If mProposedDescription <> "" Then

        pFormController.CurrentStockItem.Description = mProposedDescription

      End If
    End If
    Return mRetval
  End Function

  Private Function CheckStockCode() As Boolean
    Dim mRetval As Boolean
    Dim mProposedCode As String
    If pFormController.CurrentStockItem.StockCode = "" Then
      mProposedCode = pFormController.GetProposedCode
      If mProposedCode <> "" Then
        If MsgBox("¿Crear el código de artículo : " & mProposedCode & "?", vbYesNo) = vbYes Then
          pFormController.CurrentStockItem.StockCode = mProposedCode
        End If
      End If
    End If
    Return mRetval
  End Function

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
    Dim mImage As Image = Nothing

    pIsActive = False

    If pFormController.CurrentStockItem IsNot Nothing Then
      rgbStockItemOptions.EditValue = CType(pFormController.ShowItemsMode, System.Int32)



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
        clsDEControlLoading.SetDECombo(cboHeadType, .HeadTypeID)


        clsDEControlLoading.SetDECombo(cboUoM, .UoM)
        clsDEControlLoading.SetDECombo(cboCostUoM, .CostUoM)
        clsDEControlLoading.SetDECombo(cboItemSubType, .SubItemType)

        clsDEControlLoading.SetDECombo(cboSupplierUoM, .SupplierUoM)
        clsDEControlLoading.SetDECombo(cboDefaultManufacturer, .DefaultManufacturerID)

        clsDEControlLoading.SetDECombo(cboSupplier, .DefaultSupplier)
        txtAverageCost.EditValue = .AverageCost
        txtImportCost.EditValue = .StdImportCost
        bteImage.Text = .ImageFile
        chkIsGeneric.Checked = .IsGeneric
        chkIsTracked.Checked = .IsTracked
        chkIsObsolete.Checked = .Inactive
        txtQuantity.EditValue = .StockQuantity
        ckbIsCostingOnly.Checked = .IsCostingOnly
        txtAuxCode.Text = .AuxCode
      End With

      Dim mFileName As String
      If Not String.IsNullOrEmpty(pFormController.CurrentStockItem.ImageFile) Then

        mFileName = clsSMSharedFuncs.GetStockItemImageFileName(pFormController.CurrentStockItem)
        If IO.File.Exists(mFileName) Then
          mImage = Image.FromStream(New IO.MemoryStream(IO.File.ReadAllBytes(mFileName)))
          ''  mImage = Drawing.Image.FromFile(mFileName)

        Else
          mImage = Nothing

        End If

      End If


    End If

    If pCurrentDetailMode = eCurrentDetailMode.eView Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      SetDetailsControlsReadonly(False)
    End If


    peImage.Image = mImage
    pIsActive = mStartActive
  End Sub

  Private Sub FillSupplierDetail()

    ''Try
    ''  With pFormController.CurrentStockItem
    ''    cboSupplier.Text = .Supplier.CompanyName
    ''  End With

    ''Catch ex As Exception
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    ''End Try

  End Sub

  Private Sub LoadCombos()

    Dim mVIs As colValueItems
    Dim mSuppliers As colSuppliers

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    For mLoop As Integer = mVIs.Count - 1 To 0 Step -1
      If pFormController.Categorys.Contains(mVIs(mLoop).ItemValue) = False Then
        mVIs.RemoveAt(mLoop)
      End If
    Next
    clsDEControlLoading.FillDEComboVI(cboCategory, mVIs)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdStockItems, gcCategory, mVIs)
    clsDEControlLoading.FillDEComboVI(cboUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))
    clsDEControlLoading.FillDEComboVI(cboSupplierUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))
    clsDEControlLoading.FillDEComboVI(cboCostUoM, clsEnumsConstants.EnumToVIs(GetType(eUoM)))


    mSuppliers = pFormController.RTISGlobal.RefLists.RefIList(appRefLists.Supplier)
    clsDEControlLoading.FillDEComboVIi(cboSupplier, mSuppliers)

    clsDEControlLoading.FillDEComboVIi(cboDefaultManufacturer, pFormController.RTISGlobal.RefLists.RefIList(appRefLists.StockItemManufacturer))


  End Sub

  Private Sub UpdateObjects()

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
        .SubItemType = clsDEControlLoading.GetDEComboValue(cboItemSubType)
        .Category = clsDEControlLoading.GetDEComboValue(cboCategory)
        .ItemType = clsDEControlLoading.GetDEComboValue(cboItemType)
        .Species = clsDEControlLoading.GetDEComboValue(cboSpecies)
        .HeadTypeID = clsDEControlLoading.GetDEComboValue(cboHeadType)
        .UoM = clsDEControlLoading.GetDEComboValue(cboUoM)
        .SupplierUoM = clsDEControlLoading.GetDEComboValue(cboSupplierUoM)
        .DefaultManufacturerID = clsDEControlLoading.GetDEComboValue(cboDefaultManufacturer)
        .IsGeneric = chkIsGeneric.Checked
        .IsTracked = chkIsTracked.Checked
        .Inactive = chkIsObsolete.Checked
        .IsCostingOnly = ckbIsCostingOnly.Checked
        .AverageCost = txtAverageCost.Text
        .StdImportCost = txtImportCost.Text
        .DefaultSupplier = clsDEControlLoading.GetDEComboValue(cboSupplier)
        .AuxCode = txtAuxCode.Text
        .CostUoM = clsDEControlLoading.GetDEComboValue(cboCostUoM)

        If Val(spnQuantity.EditValue) > 0 Then
          .CostQty = Val(txtAverageCost.Text) / Val(spnQuantity.EditValue)
        Else
          .CostQty = 0
        End If
      End With
    End If

  End Sub

  Private Sub cboItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemType.SelectedIndexChanged
    If pIsActive Then
      UpdateObjects()
      RefreshCategorySpecificControls()
      RefreshControls()
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


      Select Case pFormController.CurrentStockItem.Category

        Case eStockItemCategory.Abrasivos

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeAbrasivos.GetInstance.ValueItems)
          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False
        Case eStockItemCategory.Fixings
          Dim mSITNandB As clsStockItemTypeFixings

          cboItemType.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeFixings.GetInstance.ValueItems)
          cboSpecies.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies))
          cboHeadType.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboHeadType, clsEnumsConstants.EnumToVIs(GetType(eHeadType)))
          cboItemSubType.Enabled = True

          mSITNandB = eStockItemTypeFixings.GetInstance.ItemFromKey(clsDEControlLoading.GetDEComboValue(cboItemType))

          If mSITNandB IsNot Nothing Then
            clsDEControlLoading.FillDEComboVIi(cboItemSubType, mSITNandB.StockSubItemTypeFixings)

          End If



        Case eStockItemCategory.EPP
          Dim mEPP As clsStockItemTypeEPP
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeEPP.GetInstance.ValueItems)
          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False

        Case eStockItemCategory.Herrajes

          Dim mHerrajesType As clsStockItemTypeHerrajes
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerrajes.GetInstance.ValueItems)


          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False

        Case eStockItemCategory.Herramientas


          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerramientas.GetInstance.ValueItems)

          cboItemType.Enabled = True
          cboSpecies.Enabled = False
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False

        Case eStockItemCategory.MatElect

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialElectrico.GetInstance.ValueItems)


          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False

        Case eStockItemCategory.MatEmpaque

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialEmpaque.GetInstance.ValueItems)


          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False

        Case eStockItemCategory.BrickWork

          cboItemType.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeBrickWork.GetInstance.ValueItems)
          cboSpecies.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies))
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.MatVarios

          cboItemType.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMatVarioss.GetInstance.ValueItems)


          cboSpecies.Enabled = False
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.Plumbing

          cboItemType.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypePlumbings.GetInstance.ValueItems)
          cboSpecies.Enabled = True
          clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies))

          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.Metal

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMetales.GetInstance.ValueItems)


          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False

        Case eStockItemCategory.PinturaYQuimico
          Dim mItemType As clsStockItemTypePintura

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypePintura.GetInstance.ValueItems)

          mItemType = eStockItemTypePintura.GetInstance.ItemFromKey(pFormController.CurrentStockItem.ItemType)


          If mItemType IsNot Nothing Then


            Select Case mItemType.ItemValue
              Case eStockItemTypePintura.Pintura, eStockItemTypePintura.Acabado
                clsDEControlLoading.FillDEComboVI(cboItemSubType, mItemType.StockSubItemTypePinturas.SortedValueItems)
                cboItemSubType.Enabled = True

              Case Else
                clsDEControlLoading.FillDEComboVI(cboItemSubType, New colValueItems)
                cboItemSubType.Enabled = False
            End Select

          End If

          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False

        Case eStockItemCategory.Laminas

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeLamina.GetInstance.ValueItems)

          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.Repuestos

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeRepuestosYPartes.GetInstance.ValueItems)

          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.Tapiceria

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeTapiceria.GetInstance.ValueItems)

          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.VidrioYEspejo

          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeVidrioYEspejo.GetInstance.ValueItems)

          cboSpecies.Enabled = False
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False


        Case eStockItemCategory.Timber

          clsDEControlLoading.FillDEComboVI(cboSpecies, pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.WoodSpecie))
          clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeTimberWood.GetInstance.ValueItems)
          gcSpecies.Visible = True
          cboSpecies.Enabled = True
          cboItemType.Enabled = True
          cboHeadType.Enabled = False
          cboItemSubType.Enabled = False



      End Select

    End If

    pIsActive = mStartActive
  End Sub

  Public Sub RefreshTypeSpecificControls()
    Dim mVIs As New colValueItems
    Dim mVI As clsValueItem
    Select Case pFormController.CurrentStockItem.Category
      Case eStockItemCategory.Fixings
        Dim mSITNandB As clsStockItemTypeFixings
        mSITNandB = eStockItemTypeFixings.GetInstance.ItemFromKey(clsDEControlLoading.GetDEComboValue(cboItemType))
        For Each mItem As clsStockSubItemTypeFixings In mSITNandB.StockSubItemTypeFixings
          mVI = New clsValueItem
          mVI.ItemValue = mItem.ItemValue
          mVI.DisplayValue = mItem.DisplayValue
          mVIs.Add(mVI)
        Next
        clsDEControlLoading.FillDEComboVIi(cboItemSubType, mSITNandB.StockSubItemTypeFixings)
    End Select
  End Sub

  Private Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)
    txtDescription.ReadOnly = vReadOnly
    txtStockCode.ReadOnly = vReadOnly
    spnLength.ReadOnly = vReadOnly
    spnWidth.ReadOnly = vReadOnly
    spnThickness.ReadOnly = vReadOnly
    cboCategory.ReadOnly = vReadOnly
    cboItemType.ReadOnly = vReadOnly
    txtColour.ReadOnly = vReadOnly
    spnQuantity.ReadOnly = vReadOnly
    txtDescriptionShort.ReadOnly = vReadOnly
    txtPartNo.ReadOnly = vReadOnly
    cboSpecies.ReadOnly = vReadOnly
    cboHeadType.ReadOnly = vReadOnly
    cboUoM.ReadOnly = vReadOnly
    cboSupplierUoM.ReadOnly = vReadOnly
    txtImportCost.ReadOnly = vReadOnly
    txtAverageCost.ReadOnly = vReadOnly
    chkIsGeneric.Enabled = Not vReadOnly
    ckbIsCostingOnly.Enabled = Not vReadOnly
    chkIsObsolete.Enabled = Not vReadOnly
    bteImage.Enabled = Not vReadOnly
    cboSupplier.Enabled = Not vReadOnly
    txtAuxCode.ReadOnly = vReadOnly
    cboCostUoM.ReadOnly = vReadOnly
    cboItemSubType.ReadOnly = vReadOnly
    txtThicknessFrac.ReadOnly = vReadOnly
    txtWidthFrac.ReadOnly = vReadOnly
    txtLengthFrac.ReadOnly = vReadOnly
    cboDefaultManufacturer.ReadOnly = vReadOnly

    ''    btnedImageFile.ReadOnly = vReadOnly

    ''gvAlternateCodes.OptionsBehavior.ReadOnly = vReadOnly

    ''    gvBOM.OptionsBehavior.ReadOnly = vReadOnly

    ''    grdFixing.DataSource = pFormController.CurrentStockItem.StockItemFixings
  End Sub

  Public Sub ShowHideDetails()
    If pFormController.CurrentStockItem IsNot Nothing Then
      If pFormController.CurrentStockItem.tmpIsFullyLoadedDown = True Then

        ShowHideTabs()
      Else
      End If
    End If
  End Sub


  Private Sub ShowHideTabs()


  End Sub


  Private Sub gvStockItems_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockItems.CustomUnboundColumnData


    Dim mRow As dmStockItem
    Dim mVIs As New colValueItems
    ''Dim mSubTypes As colSubItemTypes
    ''Dim mSubType As clsSubItemType
    ''Dim mSubItemTypes As colStockItemType

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


              Case eStockItemCategory.Fixings
                mText = eStockItemTypeFixings.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText


              Case eStockItemCategory.EPP
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeEPP), CType(mRow.ItemType, eStockItemTypeEPP.eStockItemMaterialEPP))
                e.Value = mText

              Case eStockItemCategory.Herrajes
                mText = eStockItemTypeHerrajes.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText


              Case eStockItemCategory.Herramientas
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerramientas), CType(mRow.ItemType, eStockItemTypeHerramientas.eStockItemMaterialHerramientas))
                e.Value = mText

              Case eStockItemCategory.MatElect
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialElectrico), CType(mRow.ItemType, eStockItemTypeMaterialElectrico.eStockItemMaterialElectrico))
                e.Value = mText


              Case eStockItemCategory.MatEmpaque
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialEmpaque), CType(mRow.ItemType, eStockItemTypeMaterialEmpaque.StockItemMaterialEmpaque))
                e.Value = mText

              Case eStockItemCategory.BrickWork
                mText = eStockItemTypeBrickWork.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText


              Case eStockItemCategory.Plumbing
                mText = eStockItemTypePlumbings.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.MatVarios
                mText = eStockItemTypeMatVarioss.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Metal
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(mRow.ItemType, eStockItemTypeMetales.eStockItemMetales))
                e.Value = mText


              Case eStockItemCategory.PinturaYQuimico
                mText = eStockItemTypePintura.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Laminas
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeLamina), CType(mRow.ItemType, eStockItemTypeLamina.eStockItemLamina))
                e.Value = mText


              Case eStockItemCategory.Repuestos
                mText = eStockItemTypeRepuestosYPartes.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText

              Case eStockItemCategory.Tapiceria
                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTapiceria), CType(mRow.ItemType, eStockItemTypeTapiceria.eStockItemTapiceria))
                e.Value = mText

              Case eStockItemCategory.VidrioYEspejo

                mText = eStockItemTypeVidrioYEspejo.GetInstance.DisplayValueFromKey(mRow.ItemType)
                e.Value = mText


              Case eStockItemCategory.Timber

                mText = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTimberWood), CType(mRow.ItemType, eStockItemTypeTimberWood.eStockItemTimberWood))
                e.Value = mText

              Case Else
                e.Value = ""

            End Select


        End Select


      End If
    End If

    ''RefreshControls()

  End Sub

  Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged

  End Sub

  Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
    If pIsActive Then
      UpdateObjects()
      RefreshCategorySpecificControls()
    End If
  End Sub

  Private Sub gvStockItems_ColumnChanged(sender As Object, e As EventArgs) Handles gvStockItems.ColumnChanged

  End Sub

  Private Sub bteImage_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles bteImage.ButtonClick
    Try
      UpdateObjects()
      Dim mFileName As String = ""
      If RTIS.CommonVB.clsGeneralA.GetOpenFileName(mFileName, "Selecionar Imagen") = DialogResult.OK Then

        ''// make sure that we clear the current image first so that it can be overwritten
        peImage.Image = Nothing
        peImage.Refresh()

        If pFormController.CreateSIImageFile(mFileName) = False Then

        End If
      End If
      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnedSupplier_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    Try
      Select Case e.Button.Kind
        Case ButtonPredefines.Combo
          Dim mSupplierPicker As clsPickerSupplier
          Dim mSupplier As dmSupplier
          UpdateObjects()
          mSupplierPicker = New clsPickerSupplier(pFormController.GetSupplierList, pFormController.DBConn)
          mSupplier = frmPickSupplier.OpenPickerSingle(mSupplierPicker)
          If mSupplier IsNot Nothing Then
            pFormController.CurrentStockItem.DefaultSupplier = mSupplier.SupplierID
            pFormController.CurrentStockItem.Supplier = mSupplier
            pFormController.ReloadSupplier()
            FillSupplierDetail()

          End If
          RefreshControls()
        Case ButtonPredefines.Ellipsis
          frmSupplierDetail.OpenFormModal(pFormController.StockItem.DefaultSupplier, pFormController.DBConn)
          If pFormController.StockItem.DefaultSupplier <> 0 Then
            pFormController.ReloadSupplier()
            FillSupplierDetail()

          End If
          RefreshControls()
      End Select

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub cboSupplierUoM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplierUoM.SelectedIndexChanged
    ''  pFormController.StockItem.SupplierUoM = clsDEControlLoading.GetDEComboValue(cboSubitemType)
  End Sub

  Private Sub grpGroupF8_Paint(sender As Object, e As PaintEventArgs) Handles grpGroupF8.Paint

  End Sub

  Private Sub txtDescription_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtDescription.ButtonClick
    UpdateObjects()
    txtDescription.Text = GenerateDescription(pFormController.CurrentStockItem)

  End Sub

  Private Function GenerateDescription(ByRef rStockItem As dmStockItem) As String
    Dim mRetval As String = ""
    Dim mVal As clsValidate

    Dim mStockItemCategory As clsStockItemCategoryBase = eStockItemCategoryEnums.GetInstance.ItemFromCategory(rStockItem.Category)

    mVal = clsStockItemSharedFuncs.IsStockCodeSpecValid(pFormController.CurrentStockItem)

    If mVal.ValOk Then
      mRetval = mStockItemCategory.GetDescription(rStockItem) 'clsStockItemSharedFuncs.DeriveDescription(False, rStockItem)

    Else
      If MsgBox("La información no es suficiente para generar la descripción del artículo de inventario" & vbCrLf & mVal.Msg & vbCrLf & "¿Desea guardar de igual forma?", vbYesNo) = vbYes Then
        If pFormController.SaveObject() Then
          'If pFormController.IsSaveByRecord Then '' Save each item as you go
          '  pFormController.ReleaseCurrentLock()
          'End If
          pCurrentDetailMode = eCurrentDetailMode.eView
        End If
      End If

    End If


    ''End If

    Return mRetval
  End Function


  Private Sub spnLength_EditValueChanged(sender As Object, e As EventArgs) Handles spnLength.EditValueChanged

    Try
      Dim mFracString As String = ""
      Dim mDec As Decimal

      If pFormController IsNot Nothing Then
        mDec = spnLength.EditValue

        mFracString = clsSMSharedFuncs.FractStrFromDec(mDec)
        txtLengthFrac.Text = mFracString
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub txtLengthFrac_EditValueChanged(sender As Object, e As EventArgs) Handles txtLengthFrac.EditValueChanged
    Try
      Dim mDec As Decimal = 0


      If pFormController IsNot Nothing Then
        mDec = spnLength.EditValue

        mDec = clsSMSharedFuncs.DecFromFractString(txtLengthFrac.Text)
        spnLength.EditValue = mDec
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub txtWidthFrac_EditValueChanged(sender As Object, e As EventArgs) Handles txtWidthFrac.EditValueChanged
    Try
      Dim mDec As Decimal = 0


      If pFormController IsNot Nothing Then
        mDec = spnWidth.EditValue

        mDec = clsSMSharedFuncs.DecFromFractString(txtWidthFrac.Text)
        spnWidth.EditValue = mDec
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub spnWidth_EditValueChanged(sender As Object, e As EventArgs) Handles spnWidth.EditValueChanged

    Try
      Dim mFracString As String = ""
      Dim mDec As Decimal

      If pFormController IsNot Nothing Then
        mDec = spnWidth.EditValue

        mFracString = clsSMSharedFuncs.FractStrFromDec(mDec)
        txtWidthFrac.Text = mFracString
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub spnThickness_EditValueChanged(sender As Object, e As EventArgs) Handles spnThickness.EditValueChanged

    Try
      Dim mFracString As String = ""
      Dim mDec As Decimal

      If pFormController IsNot Nothing Then
        mDec = spnThickness.EditValue

        mFracString = clsSMSharedFuncs.FractStrFromDec(mDec)
        txtThicknessFrac.Text = mFracString
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub txtThicknessFrac_EditValueChanged(sender As Object, e As EventArgs) Handles txtThicknessFrac.EditValueChanged
    Try
      Dim mDec As Decimal = 0


      If pFormController IsNot Nothing Then
        mDec = spnThickness.EditValue

        mDec = clsSMSharedFuncs.DecFromFractString(txtThicknessFrac.Text)
        spnThickness.EditValue = mDec
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub bbtnChangeCategory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnChangeCategory.ItemClick

    Try
      UpdateObjects()

      frmGlobalStockItemChanges.OpenFormAsModal(Me, pFormController.DBConn, AppRTISGlobal.GetInstance, pFormController.StockItems, eFormMode.eFMFormModeEdit, pFormController.SelectedItems.Count)

      ''CheckSave(False)

      pFormController.StockItems.Clear()
      pFormController.LoadObject()

      grdStockItems.DataSource = pFormController.StockItems
      grdStockItems.RefreshDataSource()
      RefreshControls()
      pFormController.SelectedItems.Clear()
      RefreshSelectedItemButtons()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub repoStockItemOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles repoStockItemOption.SelectedIndexChanged
    Dim mIndex As Integer
    Dim mItem As RadioGroup = TryCast(sender, RadioGroup)
    Dim mWhere As String = ""

    If pIsActive Then
      pFormController.ShowItemsMode = mItem.EditValue

      Select Case repoStockItemOption.Items.Item(mItem.SelectedIndex).Tag
        Case "All"
          If pFormController.CurrentCategory = eStockItemCategory.None Then
            pFormController.LoadMainCollectionByStockOptionFilter("")
          Else
            mWhere = "Category =" & pFormController.CurrentCategory
            pFormController.LoadMainCollectionByStockOptionFilter(mWhere)
          End If
        Case "Active"
          If pFormController.CurrentCategory = eStockItemCategory.None Then
            mWhere = "IsNull(Inactive,0) = 0 "
            pFormController.LoadMainCollectionByStockOptionFilter(mWhere)
          Else
            mWhere = "IsNull(Inactive,0) = 0  and Category =" & pFormController.CurrentCategory
            pFormController.LoadMainCollectionByStockOptionFilter(mWhere)

          End If

        Case "Obsolete"

          If pFormController.CurrentCategory = eStockItemCategory.None Then

            mWhere = "IsNull(Inactive,0) = 1"
            pFormController.LoadMainCollectionByStockOptionFilter(mWhere)

          Else
            mWhere = "IsNull(Inactive,0) = 1  and Category =" & pFormController.CurrentCategory
            pFormController.LoadMainCollectionByStockOptionFilter(mWhere)

          End If


      End Select
      grdStockItems.DataSource = pFormController.StockItems
      grdStockItems.RefreshDataSource()
    End If
  End Sub


  Private Sub txtStockCode_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtStockCode.ButtonClick
    UpdateObjects()

    If pFormController.CurrentStockItem.StockCode = "" Then
      CheckCreateStockCodeSave()
      ' pCurrentDetailMode = eCurrentDetailMode.eEdit

      RefreshControls()

    Else
      MsgBox("No disponible hasta que se limpie el código del producto actual")
    End If
  End Sub

  Private Sub CheckCreateStockCodeSave()
    Dim mStockCodeStem As String
    Dim mVal As clsValidate
    Dim mOK As Boolean = True

    UpdateObjects()

    Try

      mVal = clsStockItemSharedFuncs.IsStockCodeSpecValid(pFormController.CurrentStockItem)

      If mVal.ValOk Then

        mStockCodeStem = eStockItemCategoryEnums.GetInstance.ItemFromCategory(pFormController.CurrentStockItem.Category).GetStockCode(pFormController.CurrentStockItem)

        If pFormController.CurrentStockItem.PartNo = "" Then
          mStockCodeStem = mStockCodeStem & "." & pFormController.GetNextStockCodeSuffix(mStockCodeStem)
        End If


        If pFormController.CheckStockCodeExists(mStockCodeStem) Then
            If MsgBox("El Código " & mStockCodeStem & " ya existe. Por favor revisar " & vbCrLf & mVal.Msg & vbCrLf & "¿Desea guardar de cualquier forma?", vbYesNo) = vbYes Then

              If pFormController.SaveCurrentItemGenerateCode(mStockCodeStem) Then
              'If pFormController.IsSaveByRecord Then '' Save each item as you go
              '  pFormController.ReleaseCurrentLock()
              'End If
              '  pCurrentDetailMode = eCurrentDetailMode.eView
            End If
            Else
              If pFormController.SaveObject Then
              'If pFormController.IsSaveByRecord Then '' Save each item as you go
              '  pFormController.ReleaseCurrentLock()
              'End If
              '   pCurrentDetailMode = eCurrentDetailMode.eView
            End If

            End If

          ElseIf MsgBox("El código de este artículo será registrado de la siguiente forma: " & vbCrLf & mStockCodeStem & "###" & vbCrLf & "¿Desea continuar y guardar el artículo?", vbYesNo) = vbYes Then
            If pFormController.SaveCurrentItemGenerateCode(mStockCodeStem) Then
            'If pFormController.IsSaveByRecord Then '' Save each item as you go
            '  pFormController.ReleaseCurrentLock()
            'End If
            '  pCurrentDetailMode = eCurrentDetailMode.eView
          End If
          End If

        Else
          If MsgBox("La información no es suficiente para generar un código de inventario" & vbCrLf & mVal.Msg & vbCrLf & "¿Desea guardar de igual forma?", vbYesNo) = vbYes Then
          '' pFormController.SaveObject(False, "")
          If pFormController.SaveCurrentItemGenerateCode(mStockCodeStem) Then
            'If pFormController.IsSaveByRecord Then '' Save each item as you go
            '  pFormController.ReleaseCurrentLock()
            'End If
            ' pCurrentDetailMode = eCurrentDetailMode.eView
          End If
        End If

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    RefreshControls()

  End Sub

  Private Sub repoSelectedItem_CheckedChanged(sender As Object, e As EventArgs) Handles repoSelectedItem.CheckedChanged
    gvStockItems.CloseEditor()
    RefreshSelectedItemButtons()
  End Sub
  Private Sub RefreshSelectedItemButtons()
    Dim mSelectedItemCount As Integer
    Dim mItem As dmStockItem
    Dim mCount As Integer = 0

    pFormController.SelectedItems.Clear()

    For Each mItem In pFormController.StockItems

      If mItem.IsSelected = True Then
        mCount += 1
        pFormController.SelectedItems.Add(mItem)
      End If
    Next

    mSelectedItemCount = mCount

    'If mSelectedItemCount = 0 Then
    '  btnGenerateDescriptionItem.Caption = "Generate Item"
    '  btnGenerateDescriptionItem.Enabled = False
    'Else
    '  btnGenerateDescriptionItem.Enabled = True
    '  btnGenerateDescriptionItem.Caption = String.Format("Generate ({0}) Item(s) Description", mSelectedItemCount)

    'End If

  End Sub

End Class

