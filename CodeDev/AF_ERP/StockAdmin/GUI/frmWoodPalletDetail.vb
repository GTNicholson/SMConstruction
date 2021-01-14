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
  End Enum

  Public Shared Sub OpenAsMDI(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mfrm As frmWoodPalletDetail = Nothing

    mfrm = GetFormIfLoaded()
    If mfrm Is Nothing Then
      mfrm = New frmWoodPalletDetail
      mfrm.MdiParent = rMDIParent
      mfrm.FormMode = eFormMode.eFMFormModeAdd
      mfrm.pFormController = New fccWoodPallet(rDBConn, rRTISGlobal)
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
        mItem.Caption = "Pallet de " & mTimberType.DisplayValue
        mItem.Tag = mTimberType.ItemValue
        AddHandler mItem.ItemClick, AddressOf AddPalletAddingOptions
        bbtnAddPallet.AddItem(mItem)
      End If
    Next

  End Sub

  Private Sub AddPalletAddingOptions(sender As Object, e As EventArgs)
    Dim mWoodPallet As dmWoodPallet
    Dim mRH As Integer
    Dim mPalletType As Integer = CType(e, DevExpress.XtraBars.ItemClickEventArgs).Item.Tag



    mWoodPallet = pFormController.CreateNewPallet(mPalletType)
    frmMovementTransaction.OpenFormI(pFormController.DBConn, mWoodPallet, frmMovementTransaction.eFormMode.None)

    gvWoodPalletInfo.RefreshData()

    mRH = gvWoodPalletInfo.FindRow(mWoodPallet)

    If mRH >= 0 Then
      gvWoodPalletInfo.FocusedRowHandle = mRH
    Else
      pFormController.CurrentWoodPallet = mWoodPallet

      RefreshControls()
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



      With pFormController.CurrentWoodPallet

        Select Case pFormController.CurrentWoodPallet.PalletType
          Case eStockItemTypeTimberWood.Arbol, eStockItemTypeTimberWood.Rollo
            grpWoodPallet.Text = "Detalles de la Rastra : " & pFormController.CurrentWoodPallet.PalletRef
          Case Else
            grpWoodPallet.Text = "Detalles del Bulto : " & pFormController.CurrentWoodPallet.PalletRef
        End Select

        txtWoodRef.Text = .PalletRef
        txtRefPallet.Text = .RefPalletOutside
        txtWoodDescription.Text = .Description
        dteDateCreated.EditValue = .CreatedDate
        clsDEControlLoading.SetDECombo(cboLocations, .LocationID)
        clsDEControlLoading.SetDECombo(cboWoodPalletType, .PalletType)

        lblWoodPalletID.Text = "ID: " & .WoodPalletID

        If .PalletType = eStockItemTypeTimberWood.Rollo Then
          gcQuantity.Caption = "Cantidad M3"
        Else
          gcQuantity.Caption = "Cantidad PT"
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

    pIsActive = mStartActive
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
    txtRefPallet.ReadOnly = vReadOnly
    cboWoodPalletType.ReadOnly = vReadOnly
    txtWoodDescription.Enabled = Not vReadOnly
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
        pFormController.SaveObject()
        pCurrentDetailMode = eCurrentDetailMode.eView
        gvWoodPalletInfo.RefreshData()
        SetDetailsControlsReadonly(True)
        RefreshControls()

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

        If frmPickerStockItem.PickPurchaseOrderItems(mPicker, pFormController.RTISGlobal, True, pFormController.CurrentWoodPallet.PalletType) Then
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
        End If
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

            pFormController.ToProcessQty()
            RefreshControls()
            CheckSave(False)
            pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
            gvWoodPalletItemInfo.RefreshData()


          End If
        Catch ex As Exception
          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try

      Case eDetailButtons.Despatch

        SetDetailsControlsReadonly(True)

        pFormController.CurrentWoodPallet.IntoWIPDate = Now
        CheckSave(False)
        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        gvWoodPalletItemInfo.RefreshData()

      Case eDetailButtons.Consume
        Try

          If pFormController.CurrentWoodPallet IsNot Nothing Then

            CheckSave(False)
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

    End Select
    RefreshDetailButtons()
  End Sub



  Private Sub UpdateObjects()

    If pFormController.CurrentWoodPallet IsNot Nothing Then
      With pFormController.CurrentWoodPallet
        .PalletRef = txtWoodRef.Text
        .RefPalletOutside = txtRefPallet.Text
        .CreatedDate = dteDateCreated.EditValue
        .LocationID = clsDEControlLoading.GetDEComboValue(cboLocations)
        .PalletType = clsDEControlLoading.GetDEComboValue(cboWoodPalletType)

        .Description = txtWoodDescription.Text
      End With
    End If

  End Sub

  Private Sub frmWoodPalletDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub



  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboLocations, clsEnumsConstants.EnumToVIs(GetType(eLocations)))
    clsDEControlLoading.FillDEComboVI(cboWoodPalletType, eStockItemTypeTimberWood.GetInstance.ValueItems)

  End Sub

  Private Sub gvWoodPalletInfo_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvWoodPalletInfo.FocusedRowObjectChanged
    Dim mWoodPallet As dmWoodPallet

    Try
      mWoodPallet = TryCast(e.Row, dmWoodPallet)
      If mWoodPallet IsNot Nothing Then
        pFormController.CurrentWoodPallet = e.Row
        pCurrentDetailMode = eCurrentDetailMode.eView
        pFormController.SetCurrentWoodPalletInfo()
        pFormController.RefreshWoodPalletItemEditor(pFormController.CurrentWoodPallet)
        grdWoodPalletItemInfos.DataSource = pFormController.WoodPalletItemEditors 'pFormController.CurrentWoodPallet.WoodPalletItems
        RefreshDetailButtons()
        RefreshControls()
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
    Dim mSelectedWoodPalletItem As clsWoodPalletItemEditor
    Dim mDuplicatedWoodPalletItem As dmWoodPalletItem

    mSelectedWoodPalletItem = TryCast(gvWoodPalletItemInfo.GetFocusedRow, clsWoodPalletItemEditor)

    If mSelectedWoodPalletItem IsNot Nothing Then
      mDuplicatedWoodPalletItem = New dmWoodPalletItem
      mDuplicatedWoodPalletItem.StockItemID = mSelectedWoodPalletItem.StockItem.StockItemID
      mDuplicatedWoodPalletItem.Width = 0
      mDuplicatedWoodPalletItem.Length = 0
      mDuplicatedWoodPalletItem.Quantity = 0
      mDuplicatedWoodPalletItem.QuantityUsed = 0
      mDuplicatedWoodPalletItem.WoodPalletItemID = 0
      mDuplicatedWoodPalletItem.Description = mSelectedWoodPalletItem.WoodPalletItem.Description
      mDuplicatedWoodPalletItem.StockCode = mSelectedWoodPalletItem.StockItem.StockCode
      mDuplicatedWoodPalletItem.Thickness = mSelectedWoodPalletItem.StockItem.Thickness
      mDuplicatedWoodPalletItem.WoodPalletID = mSelectedWoodPalletItem.WoodPalletItem.WoodPalletID
      pFormController.CurrentWoodPallet.WoodPalletItems.Add(mDuplicatedWoodPalletItem)
      pFormController.SaveObject()
      grdWoodPalletItemInfos.RefreshDataSource()
    End If
  End Sub

  Private Sub bbtnPickWoodPallet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnPickWoodPallet.ItemClick
    UpdateObjects()
    pFormController.SaveObject()
    frmPickWoodMaterial.OpenAsModal(Me, pFormController.DBConn, pFormController.RTISGlobal, 0, pFormController.CurrentWoodPallet, eFormMode.eFMFormModeAdd)

  End Sub

  Private Sub grpWoodPalletList_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpWoodPalletList.CustomButtonClick
    Dim mString As String = ""
    Dim mFileName As String = "Lista de Pallet" + ".xlsx"

    If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName) = DialogResult.OK Then
      gvWoodPalletInfo.ExportToXlsx(mFileName)
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
End Class