Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Public Class frmWoodPalletDetail
  Public FormMode As eFormMode
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pCurrentDetailMode As eCurrentDetailMode
  Private pFormController As fccWoodPallet
  Public ExitMode As Windows.Forms.DialogResult
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
    eMovement = 3
    eDespatch = 4
  End Enum

  Private Enum eDetailButtons
    Edit = 1
    Save = 2
    PickItem = 3
    Movement = 4
    ToProcess = 5
    Despatch = 6
    Consume = 7
    Purge = 8
    AddPredWidth = 9
  End Enum

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vFormMode As eWoodFormMode)
    Dim mfrm As frmWoodPalletDetail = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmWoodPalletDetail
      mfrm.MdiParent = rMDIParent
      mfrm.FormMode = eFormMode.eFMFormModeAdd
      mfrm.pFormController = New fccWoodPallet(rDBConn, rRTISGlobal)
      mfrm.pFormController.FormMode = vFormMode
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmWoodPalletDetail
    Dim mfrmWanted As frmWoodPalletDetail = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWoodPalletDetail
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmWoodPalletDetail Then
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

  Private Sub RefreshAddPalletItemOptions()
    Dim mItem As DevExpress.XtraBars.BarButtonItem

    bbtnAddPallet.ClearLinks()

    For Each mTimberType As clsValueItem In eStockItemTypeTimberWood.GetInstance.ValueItems

      If mTimberType.ItemValue <> eStockItemTypeTimberWood.Otros And mTimberType.ItemValue <> eStockItemTypeTimberWood.Arbol Then

        mItem = New DevExpress.XtraBars.BarButtonItem
        mItem.Caption = "Bulto de " & mTimberType.DisplayValue
        mItem.Tag = mTimberType.ItemValue
        AddHandler mItem.ItemClick, AddressOf AddPalletAddingOptions
        bbtnAddPallet.AddItem(mItem)
      End If
    Next

  End Sub

  Private Sub AddPalletAddingOptions(sender As Object, e As EventArgs)
    Dim mWoodPallet As dmWoodPallet
    Dim mWPI As Integer
    Dim mPalletType As Integer = CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag



    mWoodPallet = pFormController.CreateNewPallet(mPalletType)
    mWoodPallet.LocationID = eLocations.AgroForestal 'frmMovementTransaction.OpenFormI(pFormController.DBConn, mWoodPallet, frmMovementTransaction.eFormMode.None)

    pFormController.CurrentWoodPallet = mWoodPallet
    pFormController.SaveObject()
    RefreshControls()
    CheckSave(False)
    gvWoodPalletInfo.RefreshData()

    mWPI = gvWoodPalletInfo.FindRow(mWoodPallet)

    If mWPI >= 0 Then
      gvWoodPalletInfo.FocusedRowHandle = mWPI
    Else
      pFormController.CurrentWoodPallet = mWoodPallet
      UpdateObjects()

    End If
    SetDetailsControlsReadonly(False) 'False)
    pCurrentDetailMode = eCurrentDetailMode.eEdit
    RefreshDetailButtons()
    SetDetailFocus()


  End Sub

  Private Sub frmWoodPalletDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False
    Try
      pFormController.LoadObject()
      RefreshAddPalletItemOptions()

      grdWoodPalletInfo.DataSource = pFormController.WoodPallets

      LoadCombos()

      RefreshControls()
    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub bbtnAddNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnAddNew.ItemClick
    'Dim mWoodPallet As dmWoodPallet
    'Dim mRH As Integer

    'mWoodPallet = pFormController.AddWoodPallet()

    'gvWoodPalletInfo.RefreshData()

    'mRH = gvWoodPalletInfo.FindRow(mWoodPallet)

    'If mRH >= 0 Then
    '  gvWoodPalletInfo.FocusedRowHandle = mRH
    'Else
    '  pFormController.CurrentWoodPallet = mWoodPallet

    '  RefreshControls()
    'End If
    'SetDetailsControlsReadonly(False) 'False)
    'pCurrentDetailMode = eCurrentDetailMode.eEdit
    'RefreshDetailButtons()
    'SetDetailFocus()

  End Sub

  Private Sub RefreshControls()

    Dim mStartActive As Boolean = pIsActive
    Dim mImage As Image = Nothing

    pIsActive = False

    If pFormController.CurrentWoodPallet IsNot Nothing Then

      HideShowGroupButtons()


      With pFormController.CurrentWoodPallet

        Select Case pFormController.CurrentWoodPallet.PalletType
          Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
            grpWoodPallet.Text = "Detalles de la Rastra : " & pFormController.CurrentWoodPallet.PalletRef
          Case Else
            grpWoodPallet.Text = "Detalles del Bulto : " & pFormController.CurrentWoodPallet.PalletRef
        End Select

        txtWoodRef.Text = .PalletRef
        txtCardNumber.Text = .CardNumber
        'btnSelectOT.Text=
        txtWoodDescription.Text = .Description
        dteDateCreated.EditValue = .CreatedDate
        ckeArchive.Checked = .Archive
        clsDEControlLoading.SetDECombo(cboLocations, .LocationID)
        clsDEControlLoading.SetDECombo(cboWoodPalletType, .PalletType)
        clsDEControlLoading.SetDECombo(cboFarm, .Farm)


        lblWoodPalletID.Text = "ID: " & .WoodPalletID

        If .PalletType = eStockItemTypeTimberWood.Rollo Then
          gcQuantity.Caption = "Cantidad Trozas"
        Else
          gcQuantity.Caption = "Cantidad Pza"
        End If
      End With

    End If

    If pCurrentDetailMode = eCurrentDetailMode.eView Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      SetDetailsControlsReadonly(False)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eMovement Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eDespatch Then
      SetDetailsControlsReadonly(True)
    End If

    ckeArchive.Location = New Point(cboFarm.Location.X, ckeArchive.Location.Y)
    pIsActive = mStartActive
  End Sub

  Private Sub HideShowGroupButtons()


    Select Case pFormController.FormMode
      Case eWoodFormMode.ProductionDespatch
        ''Hide Traslada, Consume and Movement for Roberto's Screen
        grpWoodPallet.CustomHeaderButtons.Item(2).Properties.Visible = False
        grpWoodPallet.CustomHeaderButtons.Item(3).Properties.Visible = False
        grpWoodPallet.CustomHeaderButtons.Item(4).Properties.Visible = False
        grpWoodPallet.CustomHeaderButtons.Item(8).Properties.Visible = False
        bbtnPickWoodPallet.Enabled = False
      Case eWoodFormMode.WoodInventory
        ''Hide Traslada, Consume and Movement for Roberto's Screen
        grpWoodPallet.CustomHeaderButtons.Item(5).Properties.Visible = False
        grpWoodPallet.CustomHeaderButtons.Item(6).Properties.Visible = False
        'grpWoodPallet.CustomHeaderButtons.Item(7).Properties.Visible = False
    End Select
  End Sub

  Private Sub RefreshDetailButtons()
    Select Case pCurrentDetailMode
      Case eCurrentDetailMode.eEdit
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpWoodPallet.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.PickItem Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Movement Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.ToProcess Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Despatch Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Consume Then mBtn.Enabled = True
          bbtnAddPallet.Enabled = False
        Next
      Case eCurrentDetailMode.eView
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpWoodPallet.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.PickItem Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Movement Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Despatch Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Consume Then mBtn.Enabled = True
          bbtnAddPallet.Enabled = True
        Next

      Case eCurrentDetailMode.eDespatch
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpWoodPallet.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.PickItem Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Movement Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Despatch Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Consume Then mBtn.Enabled = True
          bbtnAddPallet.Enabled = True

        Next
    End Select
  End Sub

  Private Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)

    txtCardNumber.ReadOnly = vReadOnly
    'cboWoodPalletType.ReadOnly = vReadOnly
    txtWoodDescription.Enabled = Not vReadOnly
    cboFarm.Properties.ReadOnly = vReadOnly
    ckeArchive.Properties.ReadOnly = vReadOnly
    cboLocations.Properties.ReadOnly = vReadOnly

    If pFormController.CurrentWoodPallet.WoodPalletItems.Count > 0 Then bbtnPickWoodPallet.Enabled = vReadOnly
    repoAddDuplicated.Buttons(0).Enabled = Not vReadOnly
    gvWoodPalletItemInfo.OptionsBehavior.ReadOnly = vReadOnly

  End Sub

  Private Sub SetDetailFocus()
    txtWoodRef.Focus()
  End Sub

  Private Sub grpWoodPallet_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWoodPallet.CustomButtonClick
    Dim mStockItems As New colStockItems
    Dim mPicker As clsPickerStockItem
    Dim mStockItem As dmStockItem
    Dim mNewWoodPalletItem As dmWoodPalletItem
    Dim pWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mSelectedStockItems As colStockItems

    Select Case e.Button.Properties.Tag
      Case eDetailButtons.Edit
        Dim mWoodPallet As dmWoodPallet
        mWoodPallet = gvWoodPalletInfo.GetFocusedRow
        pFormController.LoadWoodPalletDetail()

        pCurrentDetailMode = eCurrentDetailMode.eEdit
        SetDetailsControlsReadonly(False)
        SetDetailFocus()
        RefreshControls()

        RefreshControls()
      Case eDetailButtons.Save
        UpdateObjects()
        If pFormController.CurrentWoodPallet.CardNumber <> "" Then

          pFormController.SaveObject()
          pCurrentDetailMode = eCurrentDetailMode.eView
          gvWoodPalletInfo.RefreshData()
          SetDetailsControlsReadonly(True)
          RefreshControls()
        Else
          MessageBox.Show("Favor de ingresar un número de Tarjeta válido")
        End If
      Case eDetailButtons.PickItem
        Dim mTempSI As dmStockItem
        UpdateObjects()
        pFormController.SaveObject()

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
          mTempSI = TryCast(mItem.Value, dmStockItem)
          If mTempSI IsNot Nothing Then
            If mTempSI.ItemType = pFormController.CurrentWoodPallet.PalletType Then
              mStockItems.Add(mItem.Value)
            End If
          End If

        Next

        mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, pFormController.RTISGlobal)

        For Each mWoodPalletItem As dmWoodPalletItem In pFormController.CurrentWoodPallet.WoodPalletItems
          If mWoodPalletItem.StockItemID > 0 Then
            mStockItem = mStockItems.ItemFromKey(mWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              mPicker.SelectedObjects.Add(mStockItem)
            End If
          End If
        Next

        frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, pFormController.RTISGlobal, True, pFormController.CurrentWoodPallet.PalletType)
        For Each mSelectedItem In mPicker.SelectedObjects
          If mSelectedItem IsNot Nothing Then
            mNewWoodPalletItem = pFormController.CurrentWoodPallet.WoodPalletItems.ItemByStockItemID(mSelectedItem.StockItemID)
            If mNewWoodPalletItem Is Nothing Then
              mNewWoodPalletItem = pFormController.AddWoodPalletItem(pFormController.CurrentWoodPallet)
              mNewWoodPalletItem.StockItemID = mSelectedItem.StockItemID
              mNewWoodPalletItem.Description = mSelectedItem.Description
              mNewWoodPalletItem.StockCode = mSelectedItem.StockCode
              mNewWoodPalletItem.Thickness = mSelectedItem.Thickness

              pWoodPalletItemEditor = New clsWoodPalletItemEditor(mNewWoodPalletItem, mSelectedItem)
              pFormController.WoodPalletItemEditors.Add(pWoodPalletItemEditor)
            End If
          End If
        Next

        mSelectedStockItems = New colStockItems(mPicker.SelectedObjects)

        For mindex As Integer = pFormController.CurrentWoodPallet.WoodPalletItems.Count - 1 To 0 Step -1
          mNewWoodPalletItem = pFormController.CurrentWoodPallet.WoodPalletItems(mindex)
          If mNewWoodPalletItem.StockItemID > 0 Then
            mStockItem = mSelectedStockItems.ItemFromKey(mNewWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              pFormController.CurrentWoodPallet.WoodPalletItems.Remove(mNewWoodPalletItem)
            End If
          End If
        Next


        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        grdWoodPalletItemInfos.DataSource = pFormController.WoodPalletItemEditors''pFormController.CurrentWoodPallet.WoodPalletItems

      Case eDetailButtons.Movement
        pCurrentDetailMode = eCurrentDetailMode.eMovement
        Try
          If pFormController.WoodPallets IsNot Nothing Then
            pFormController.PreviousLocationID = pFormController.CurrentWoodPallet.LocationID
            frmMovementTransaction.OpenFormI(pFormController.DBConn, pFormController.CurrentWoodPallet, frmMovementTransaction.eFormMode.Movement)
            RefreshControls()
            CheckSave(False)
          End If
        Catch ex As Exception
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try

      Case eDetailButtons.ToProcess
        Try

          If pFormController.CurrentWoodPallet IsNot Nothing Then
            gvWoodPalletItemInfo.CloseEditor()
            CheckSave(False)
            'pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)

            pFormController.ToProcessQty(True)
            RefreshControls()
            CheckSave(False)
            pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
            gvWoodPalletItemInfo.RefreshData()


          End If
        Catch ex As Exception
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try

      Case eDetailButtons.Purge
        Try

          If pFormController.CurrentWoodPallet IsNot Nothing Then
            UpdateObjects()
            pFormController.SaveObject()
            pFormController.toPurge()
            RefreshControls()
            pFormController.SaveObject()
            pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
            gvWoodPalletItemInfo.RefreshData()


          End If
        Catch ex As Exception
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try

      Case eDetailButtons.Despatch

        SetDetailsControlsReadonly(True)

        pFormController.CurrentWoodPallet.IntoWIPDate = Now
        pFormController.DespatchWoodPallet()
        CheckSave(False)
        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        gvWoodPalletItemInfo.RefreshData()

      Case eDetailButtons.Consume
        Try

          If pFormController.CurrentWoodPallet IsNot Nothing Then
            UpdateObjects()
            pFormController.SaveObject()
            gvWoodPalletItemInfo.CloseEditor()
            pFormController.ToConsumeQty()
            RefreshControls()
            CheckSave(False)
            pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
            gvWoodPalletItemInfo.RefreshData()


          End If
        Catch ex As Exception
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try


      Case eDetailButtons.AddPredWidth
        pFormController.SaveObject()
        CreateDuplicatedItems(True)
        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        gvWoodPalletItemInfo.RefreshData()


    End Select
    RefreshDetailButtons()
  End Sub



  Private Sub UpdateObjects()

    If pFormController.CurrentWoodPallet IsNot Nothing Then
      With pFormController.CurrentWoodPallet
        .PalletRef = txtWoodRef.Text
        '.RefPalletOutside = txtRefPallet.Text
        .CreatedDate = dteDateCreated.EditValue
        .Archive = ckeArchive.Checked
        .CardNumber = txtCardNumber.Text
        .LocationID = clsDEControlLoading.GetDEComboValue(cboLocations)
        .PalletType = clsDEControlLoading.GetDEComboValue(cboWoodPalletType)
        .Farm = clsDEControlLoading.GetDEComboValue(cboFarm)
        .Description = txtWoodDescription.Text

        If pFormController.CurrentWorkOrderInfo IsNot Nothing Then
          .WorkOrderID = pFormController.CurrentWorkOrderInfo.WorkOrderID
        End If
      End With


    End If

  End Sub

  Private Sub frmWoodPalletDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub



  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboLocations, clsEnumsConstants.EnumToVIs(GetType(eLocations)))
    clsDEControlLoading.FillDEComboVI(cboWoodPalletType, eStockItemTypeTimberWood.GetInstance.ValueItems)
    clsDEControlLoading.FillDEComboVI(cboFarm, clsEnumsConstants.EnumToVIs(GetType(eFarms)))
    clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie))
    clsDEControlLoading.FillDEComboVI(cbothickness, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ThicknessValue))


  End Sub

  Private Sub gvWoodPalletInfo_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvWoodPalletInfo.FocusedRowObjectChanged
    Dim mWoodPallet As dmWoodPallet

    Try
      mWoodPallet = TryCast(e.Row, dmWoodPallet)
      If mWoodPallet IsNot Nothing Then
        pFormController.CurrentWoodPallet = e.Row
        pCurrentDetailMode = eCurrentDetailMode.eView
        pFormController.SetCurrentWoodPalletInfo()
        pFormController.SetCurrentWorkOrder(pFormController.CurrentWoodPallet.WorkOrderID)
        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        grdWoodPalletItemInfos.DataSource = pFormController.WoodPalletItemEditors 'pFormController.CurrentWoodPallet.WoodPalletItems
        RefreshDetailButtons()
        RefreshControls()
        If pFormController.CurrentWoodPallet.PalletType = eStockItemTypeTimberWood.Rollo Then
          gcThickness.Caption = "Diametro"
          gcThickness.OptionsColumn.ReadOnly = False
          gcWidth.Visible = False
          lblFarm.Visible = True
          cboFarm.Visible = True
          gcFarm.Visible = True
        Else
          gcThickness.Caption = "Grosor"
          gcThickness.OptionsColumn.ReadOnly = True
          gcWidth.Visible = True
          lblFarm.Visible = False
          cboFarm.Visible = False
          gcFarm.Visible = False
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.
    If vWithCheck Then
      If CheckSave(True) Then 'Changed from False 20150206 !!!
        CloseForm()
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.No
      CloseForm()
    End If

  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObjects()

    If pFormController.CurrentWoodPallet.WoodPalletID = 0 Or FormMode = eFormMode.eFMFormModeAdd Then
      If pFormController.IsDirty() Then
        If rOption Then
          mResponse = MsgBox("Se han realizado cambios. ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel)
          Select Case mResponse
            Case MsgBoxResult.Yes
              mSaveRequired = True
              mRetVal = False
              ExitMode = Windows.Forms.DialogResult.Yes
            Case MsgBoxResult.No
              mSaveRequired = False
              mRetVal = True
              ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
            Case MsgBoxResult.Cancel
              mSaveRequired = False
              mRetVal = False
          End Select
        Else
          ExitMode = Windows.Forms.DialogResult.Yes
          mSaveRequired = True
          mRetVal = False
        End If
      Else
        ExitMode = Windows.Forms.DialogResult.Ignore
        mSaveRequired = False
        mRetVal = True
      End If
    Else
      ExitMode = Windows.Forms.DialogResult.Ignore
      mSaveRequired = False
      mRetVal = True
    End If
    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then


        pFormController.SaveObject()


        mRetVal = True
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If

    CheckSave = mRetVal
  End Function

  Private Sub repoAddDuplicated_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoAddDuplicated.ButtonClick

    CreateDuplicatedItems(False)


  End Sub

  Public Sub CreateDuplicatedItems(ByVal vPredItems As Boolean)
    Dim mSelectedWoodPalletItem As dmWoodPalletItem
    Dim mDuplicatedWoodPalletItem As dmWoodPalletItem
    Dim mListWidths As New List(Of Integer)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)
    mListWidths.Add(0)

    If vPredItems Then
      Dim mindex As Integer = gvWoodPalletItemInfo.GetFocusedDataSourceRowIndex
      If mindex >= 0 Then



        For Each mWidth In mListWidths


          mSelectedWoodPalletItem = TryCast(gvWoodPalletItemInfo.GetFocusedRow, clsWoodPalletItemEditor).WoodPalletItem

          If mSelectedWoodPalletItem IsNot Nothing Then
            mDuplicatedWoodPalletItem = New dmWoodPalletItem
            mDuplicatedWoodPalletItem.StockItemID = mSelectedWoodPalletItem.StockItemID
            mDuplicatedWoodPalletItem.Width = mWidth
            mDuplicatedWoodPalletItem.Length = 0
            mDuplicatedWoodPalletItem.Quantity = 0
            mDuplicatedWoodPalletItem.QuantityUsed = 0
            mDuplicatedWoodPalletItem.WoodPalletItemID = 0
            mDuplicatedWoodPalletItem.Description = mSelectedWoodPalletItem.Description
            mDuplicatedWoodPalletItem.StockCode = mSelectedWoodPalletItem.StockCode
            mDuplicatedWoodPalletItem.Thickness = mSelectedWoodPalletItem.Thickness
            mDuplicatedWoodPalletItem.WoodPalletID = mSelectedWoodPalletItem.WoodPalletID
            pFormController.CurrentWoodPallet.WoodPalletItems.Add(mDuplicatedWoodPalletItem)
            pFormController.SaveObject()
            pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
            gvWoodPalletInfo.RefreshData()
          End If

        Next

      End If
    Else



      mSelectedWoodPalletItem = TryCast(gvWoodPalletItemInfo.GetFocusedRow, clsWoodPalletItemEditor).WoodPalletItem

      If mSelectedWoodPalletItem IsNot Nothing Then
        mDuplicatedWoodPalletItem = New dmWoodPalletItem
        mDuplicatedWoodPalletItem.StockItemID = mSelectedWoodPalletItem.StockItemID
        mDuplicatedWoodPalletItem.Width = 0
        mDuplicatedWoodPalletItem.Length = 0
        mDuplicatedWoodPalletItem.Quantity = 0
        mDuplicatedWoodPalletItem.QuantityUsed = 0
        mDuplicatedWoodPalletItem.WoodPalletItemID = 0
        mDuplicatedWoodPalletItem.Description = mSelectedWoodPalletItem.Description
        mDuplicatedWoodPalletItem.StockCode = mSelectedWoodPalletItem.StockCode
        mDuplicatedWoodPalletItem.Thickness = mSelectedWoodPalletItem.Thickness
        mDuplicatedWoodPalletItem.WoodPalletID = mSelectedWoodPalletItem.WoodPalletID
        pFormController.CurrentWoodPallet.WoodPalletItems.Add(mDuplicatedWoodPalletItem)
        pFormController.SaveObject()
        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        gvWoodPalletInfo.RefreshData()
      End If
    End If


  End Sub

  Private Sub bbtnPickWoodPallet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnPickWoodPallet.ItemClick
    Dim mQty As Integer

    UpdateObjects()
    pFormController.SaveObject()

    For Each mWP As dmWoodPallet In pFormController.WoodPallets
      If mWP.IsSelected Then
        mQty += 1
      End If
    Next

    If mQty = 0 Then
      frmPickWoodMaterial.OpenAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, 0, pFormController.CurrentWoodPallet, eFormMode.eFMFormModeAdd, False)

    Else
      frmPickWoodMaterial.OpenAsModalSelectedWoodPallets(Me, pFormController.DBConn, pFormController.RTISGlobal, 0, pFormController.WoodPallets, eFormMode.eFMFormModeAdd, True)

    End If

    For Each mWP In pFormController.WoodPallets
      mWP.IsSelected = False
    Next
    pFormController.LoadObject()
    grdWoodPalletInfo.DataSource = pFormController.WoodPallets
    grdWoodPalletInfo.RefreshDataSource()
    RefreshButtonCaption()
  End Sub

  Private Sub RefreshButtonCaption()
    Dim mQty As Integer
    If pFormController.WoodPallets IsNot Nothing Then

      For Each mWP In pFormController.WoodPallets
        If mWP.IsSelected Then
          mQty += 1

        End If
      Next
      If mQty = 0 Then
        bbtnPickWoodPallet.Caption = "Enviar Bulto a Producción"
      Else
        bbtnPickWoodPallet.Caption = String.Format("Enviar {0} Bulto a Producción", mQty)

      End If
    End If

  End Sub

  Private Sub grpWoodPalletGeneral_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWoodPalletGeneral.CustomButtonClick
    Dim mString As String = ""
    Dim mFileName As String = "Lista de Pallet" + ".xlsx"

    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
      gvWoodPalletItemInfo.ExportToXlsx(mFileName)
    End If
  End Sub

  Private Sub bbtnReload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnReload.ItemClick
    pFormController.LoadObject()
    grdWoodPalletInfo.DataSource = pFormController.WoodPallets
  End Sub

  Private Sub grdWoodPalletItemInfos_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles grdWoodPalletItemInfos.EmbeddedNavigator.ButtonClick
    Dim mWoodPalletItem As dmWoodPalletItem
    Dim mOutputPallet As dmOutputPallet
    Dim mIndex As Integer
    Select Case e.Button.ButtonType
      Case NavigatorButtonType.Remove
        Try
          mWoodPalletItem = TryCast(gvWoodPalletItemInfo.GetFocusedRow, clsWoodPalletItemEditor).WoodPalletItem
          If mWoodPalletItem IsNot Nothing Then
            mIndex = pFormController.CurrentWoodPallet.WoodPalletItems.GetIndexByWoodPalletItemID(mWoodPalletItem.WoodPalletItemID)
            If mIndex <> -1 Then
              pFormController.CurrentWoodPallet.WoodPalletItems.RemoveAt(mIndex)
            End If
            CheckSave(False)
          End If
        Catch ex As Exception

        End Try
    End Select
  End Sub

  Private Sub bbtnAddPallet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnAddPallet.ItemClick

  End Sub

  Private Sub ckeArchive_CheckedChanged(sender As Object, e As EventArgs) Handles ckeArchive.CheckedChanged

    If ckeArchive.Checked Then

      For Each mWoodPalletItemEditor As clsWoodPalletItemEditor In pFormController.WoodPalletItemEditors

        If (mWoodPalletItemEditor.WoodPalletItem.Quantity - mWoodPalletItemEditor.WoodPalletItem.QuantityUsed) > 0 Then
          MessageBox.Show("No puedes archivar este Pallet porque hay madera en uso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
          ckeArchive.Checked = False
          Exit Sub
        End If

      Next

    End If

  End Sub

  Private Sub grdWoodPalletItemInfos_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdWoodPalletItemInfos.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvWoodPalletItemInfo.MoveNext()
    End If
  End Sub

  Private Sub gvWoodPalletItemInfo_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvWoodPalletItemInfo.CustomUnboundColumnData

    Dim mWPIE As clsWoodPalletItemEditor
    Dim mFound As Boolean = False

    mWPIE = TryCast(e.Row, clsWoodPalletItemEditor)

    If mWPIE IsNot Nothing Then

      Select Case e.Column.Name
        Case gcM3.Name
          Dim mBF As Decimal




          'If mWPIE.QuantityUI > 0 Then
          If mWPIE.ToProcessQty <> 0 Then
            mBF = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPIE.WoodPalletItem, mWPIE.StockItem, mWPIE.ToProcessQty)
            e.Value = clsWoodPalletSharedFuncs.BoardFeetToM3(mBF)
            mWPIE.VolumeM3 = e.Value
          Else

            mBF = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPIE.WoodPalletItem, mWPIE.StockItem, mWPIE.QuantityUI)
            e.Value = clsWoodPalletSharedFuncs.BoardFeetToM3(mBF)
          End If

        Case gcPT.Name
          Dim mBF As Decimal


          'If mWPIE.QuantityUI > 0 Then
          If mWPIE.ToProcessQty <> 0 Then
            mBF = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPIE.WoodPalletItem, mWPIE.StockItem, mWPIE.ToProcessQty)
            e.Value = mBF

          Else

            mBF = clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPIE.WoodPalletItem, mWPIE.StockItem, mWPIE.QuantityUI)
            e.Value = mBF
          End If



        Case gcToProcessQty.Name
          If e.IsGetData Then

            e.Value = mWPIE.ToProcessQty
            If e.Value = 0 Then
              e.Value = ""
            End If

          End If

          If e.IsSetData Then
            mWPIE.ToProcessQty = e.Value
          End If

        Case gcWidth.Name
          If e.IsGetData Then
            e.Value = mWPIE.WoodPalletItem.Width

            If e.Value = 0 Then
              e.Value = ""
            End If
          End If

          If e.IsSetData Then
            mWPIE.WoodPalletItem.Width = e.Value
          End If


        Case gcLength.Name
          If e.IsGetData Then
            e.Value = mWPIE.WoodPalletItem.Length

            If e.Value = 0 Then
              e.Value = ""
            End If
          End If

          If e.IsSetData Then
            mWPIE.WoodPalletItem.Length = e.Value
          End If
      End Select

    End If



  End Sub

  Private Sub bbtnAdd_Click(sender As Object, e As EventArgs) Handles bbtnAdd.Click
    Dim mSelectedItem As dmStockItem
    Dim mGrosor As Decimal
    Dim mItemType As Integer
    Dim mCategory As Integer
    Dim mNewStockItem As dmStockItem
    Dim mNewWoodPalletItem As dmWoodPalletItem
    Dim pWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mSpecies As Integer
    Dim mThickessID As Integer

    mThickessID = clsDEControlLoading.GetDEComboValue(cbothickness)

    mItemType = pFormController.CurrentWoodPallet.PalletType
    mCategory = eStockItemCategory.Timber
    mSpecies = clsDEControlLoading.GetDEComboValue(cboSpecies)

    If mItemType > 0 And mThickessID > 0 And mSpecies > 0 Then

      mGrosor = Decimal.Parse(AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ThicknessValue).DisplayValueString(mThickessID))

      mSelectedItem = New dmStockItem
      mSelectedItem.Category = mCategory
      mSelectedItem.ItemType = mItemType
      mSelectedItem.Thickness = mGrosor
      mSelectedItem.Species = mSpecies

      mNewStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromSameSpec(mSelectedItem)


      If mNewStockItem Is Nothing Then

        mNewStockItem = New dmStockItem
        mNewStockItem.Category = mCategory
        mNewStockItem.ItemType = mItemType
        mNewStockItem.Thickness = mGrosor
        mNewStockItem.Species = mSpecies

        mNewStockItem.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mNewStockItem)
        mNewStockItem.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mNewStockItem, pFormController.DBConn)
        mNewStockItem.ClearKeys()
        AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mNewStockItem)


      End If

      mNewWoodPalletItem = pFormController.AddWoodPalletItem(pFormController.CurrentWoodPallet)
        mNewWoodPalletItem.StockItemID = mNewStockItem.StockItemID
        mNewWoodPalletItem.Description = mNewStockItem.Description
        mNewWoodPalletItem.StockCode = mNewStockItem.StockCode
        mNewWoodPalletItem.Thickness = mNewStockItem.Thickness

        pWoodPalletItemEditor = New clsWoodPalletItemEditor(mNewWoodPalletItem, mNewStockItem)
        pFormController.WoodPalletItemEditors.Add(pWoodPalletItemEditor)



      pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
      grdWoodPalletItemInfos.DataSource = pFormController.WoodPalletItemEditors ''pFormController.CurrentWoodPallet.WoodPalletItems

    Else
      MessageBox.Show("Se requiere una especie o grosor válido")
    End If
  End Sub

  Private Sub repoQtyAdjust_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoQtyAdjust.ButtonClick
    Dim mVal As Integer
    Dim mInput As String
    Dim mDifference As Integer
    Dim mWoodPalletItemEditor As clsWoodPalletItemEditor

    mInput = InputBox("Valor a Ajustar", "Ajuste de Cantidad")

    If Char.IsDigit(mInput) Then
      mVal = Integer.Parse(mInput)

      mWoodPalletItemEditor = TryCast(gvWoodPalletItemInfo.GetFocusedRow, clsWoodPalletItemEditor)

      If mWoodPalletItemEditor IsNot Nothing Then
        gvWoodPalletItemInfo.CloseEditor()


        mDifference = mVal - mWoodPalletItemEditor.QuantityUI



        mWoodPalletItemEditor.WoodPalletItem.DifferenceTranQty = mDifference
        mWoodPalletItemEditor.WoodPalletItem.Quantity = mVal

        pFormController.CreateAmendmentWoodPalletTransaction(pFormController.CurrentWoodPallet.LocationID, pFormController.CurrentWoodPallet, True)

      End If
    End If

  End Sub




  Private Sub repoSelectWoodPallet_EditValueChanged(sender As Object, e As EventArgs) Handles repoSelectWoodPallet.EditValueChanged
    Dim mQty As Integer = 0
    Try
      gvWoodPalletInfo.CloseEditor()

      For Each mWP In pFormController.WoodPallets
        If mWP.IsSelected Then
          mQty += 1

        End If
      Next
      If mQty = 0 Then
        bbtnPickWoodPallet.Caption = "Enviar Bulto a Producción"
      Else
        bbtnPickWoodPallet.Caption = String.Format("Enviar {0} Bulto a Producción", mQty)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub

  Private Sub cboWoodPalletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWoodPalletType.SelectedIndexChanged
    Dim mItemType As Integer

    If pFormController IsNot Nothing Then

      If pFormController.WoodPalletItemEditors IsNot Nothing Then

        mItemType = clsDEControlLoading.GetDEComboValue(cboWoodPalletType)

        If mItemType > 0 Then

          For Each mWPIE As clsWoodPalletItemEditor In pFormController.WoodPalletItemEditors
            Dim mStockItem As New dmStockItem
            Dim mNewStockItem As dmStockItem

            mStockItem = mWPIE.StockItem.Clone
            mStockItem.ClearKeys()
            mStockItem.ItemType = mItemType

            mNewStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromSameSpec(mStockItem)

            If mNewStockItem Is Nothing Then
              mNewStockItem = mStockItem
              mNewStockItem.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mNewStockItem)
              mNewStockItem.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mNewStockItem, pFormController.DBConn)
              mNewStockItem.ClearKeys()
              AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mNewStockItem)

            End If


            mWPIE.StockItem = mNewStockItem
            mWPIE.WoodPalletItem.StockCode = mNewStockItem.StockCode
            mWPIE.WoodPalletItem.StockItemID = mNewStockItem.StockItemID
            mWPIE.WoodPalletItem.Description = mNewStockItem.Description

          Next
        End If

        grdWoodPalletItemInfos.RefreshDataSource()

      End If

    End If
  End Sub
End Class