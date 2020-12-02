Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls

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
  End Enum

  Private Enum eDetailButtons
    Edit = 1
    Save = 2
    PickItem = 3
    Movement = 4
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

  Private Sub frmWoodPalletDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False
    Try
      pFormController.LoadObject()
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
    Dim mWoodPallet As dmWoodPallet
    Dim mRH As Integer

    mWoodPallet = pFormController.AddWoodPallet()

    gvWoodPalletInfo.RefreshData()

    mRH = gvWoodPalletInfo.FindRow(mWoodPallet)

    If mRH >= 0 Then
      gvWoodPalletInfo.FocusedRowHandle = mRH
    Else
      pFormController.CurrentWoodPallet = mWoodPallet

      RefreshControls()
    End If

    pCurrentDetailMode = eCurrentDetailMode.eEdit
    RefreshDetailButtons()
    SetDetailFocus()
    SetDetailsControlsReadonly(True) 'False)
  End Sub

  Private Sub RefreshControls()

    Dim mStartActive As Boolean = pIsActive
    Dim mImage As Image = Nothing

    pIsActive = False

    If pFormController.CurrentWoodPallet IsNot Nothing Then



      With pFormController.CurrentWoodPallet
        txtWoodRef.Text = .PalletRef
        txtWoodDescription.Text = .Description
        dteDateCreated.EditValue = .CreatedDate
        clsDEControlLoading.SetDECombo(cboLocations, .LocationID)
        lblWoodPalletID.Text = "ID: " & .WoodPalletID
      End With

    End If

    If pCurrentDetailMode = eCurrentDetailMode.eView Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      SetDetailsControlsReadonly(False)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eMovement Then
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
          bbtnAddNew.Enabled = False
        Next
      Case eCurrentDetailMode.eView
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpWoodPallet.CustomHeaderButtons
          If mBtn.Tag = eDetailButtons.Edit Then mBtn.Enabled = True
          If mBtn.Tag = eDetailButtons.Save Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.PickItem Then mBtn.Enabled = False
          If mBtn.Tag = eDetailButtons.Movement Then mBtn.Enabled = True
          bbtnAddNew.Enabled = True
        Next
    End Select
  End Sub

  Private Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)
    'txtWoodRef.ReadOnly = vReadOnly
    'dteDateCreated.ReadOnly = vReadOnly
    ' cboLocations.ReadOnly = vReadOnly
    'bbtnAddNew.Enabled = vReadOnly
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

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
          mStockItems.Add(mItem.Value)
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

        If frmPickerStockItem.PickPurchaseOrderItems(mPicker, pFormController.RTISGlobal, True) Then
          For Each mSelectedItem In mPicker.SelectedObjects
            If mSelectedItem IsNot Nothing Then
              mNewWoodPalletItem = pFormController.CurrentWoodPallet.WoodPalletItems.ItemByStockItemID(mSelectedItem.StockItemID)
              If mNewWoodPalletItem Is Nothing Then
                mNewWoodPalletItem = pFormController.AddWoodPalletItem(pFormController.CurrentWoodPallet)
                mNewWoodPalletItem.StockItemID = mSelectedItem.StockItemID
                mNewWoodPalletItem.Description = mSelectedItem.Description
                mNewWoodPalletItem.StockCode = mSelectedItem.StockCode
                mNewWoodPalletItem.Thickness = mSelectedItem.Thickness

                pWoodPalletItemEditor = New clsWoodPalletItemEditor(pFormController.CurrentWoodPallet, mNewWoodPalletItem)
                ' pFormController.WoodPalletItemEditors.Add(pWoodPalletItemEditor)
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



        grdWoodPalletItemInfos.DataSource = pFormController.CurrentWoodPallet.WoodPalletItems

      Case eDetailButtons.Movement
        pCurrentDetailMode = eCurrentDetailMode.eMovement
        Try
          If pFormController.WoodPallets IsNot Nothing Then

            frmMovementTransaction.OpenFormI(pFormController.DBConn, pFormController.WoodPalletItemEditors)
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
        .CreatedDate = dteDateCreated.EditValue
        .LocationID = clsDEControlLoading.GetDEComboValue(cboLocations)
        .Description = txtWoodDescription.Text
      End With
    End If

  End Sub

  Private Sub frmWoodPalletDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub



  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboLocations, clsEnumsConstants.EnumToVIs(GetType(eLocations)))

  End Sub

  Private Sub gvWoodPalletInfo_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvWoodPalletInfo.FocusedRowObjectChanged
    Dim mWoodPallet As dmWoodPallet
    Try
      mWoodPallet = TryCast(e.Row, dmWoodPallet)
      If mWoodPallet IsNot Nothing Then
        pFormController.CurrentWoodPallet = e.Row
        pCurrentDetailMode = eCurrentDetailMode.eView
        pFormController.SetCurrentStockItemCollection()
        grdWoodPalletItemInfos.DataSource = pFormController.CurrentWoodPallet.WoodPalletItems
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
    Dim mSelectedWoodPalletItem As dmWoodPalletItem
    Dim mDuplicatedWoodPalletItem As dmWoodPalletItem

    mSelectedWoodPalletItem = TryCast(gvWoodPalletItemInfo.GetFocusedRow, dmWoodPalletItem)

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
End Class