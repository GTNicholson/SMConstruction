Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmWoodReception
  Private pFormController As fccWoodReception
  Public FormMode As eFormMode
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pCurrentDetailMode As eCurrentDetailMode
  Public ExitMode As Windows.Forms.DialogResult
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Private pAddingOption As eWorkOrderWoodProcess

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
    eMovement = 3
  End Enum

  Private Enum ePalletOptions
    AddPack = 1
    AddWoodItem = 2
    Reception = 3
    Edit = 4
    Save = 5
  End Enum

  Public Sub New()
    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub

  Public Property FormController As fccWoodReception
    Get
      Return pFormController
    End Get
    Set(value As fccWoodReception)
      pFormController = value
    End Set
  End Property
  Public Shared Sub OpenForm(ByRef rMDIForm As frmTabbedMDI, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vReceptionID As Integer)
    Dim mfrm As frmWoodReception = Nothing

    If vReceptionID <> 0 Then
      mfrm = GetFormIfLoaded(vReceptionID)
    End If


    If mfrm Is Nothing Then
      mfrm = New frmWoodReception
      mfrm.pFormController = New fccWoodReception(rDBConn, rRTISGlobal, vReceptionID)

      mfrm.FormMode = eFormMode.eFMFormModeAdd
      mfrm.MdiParent = rMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If



  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmWoodReception
    Dim mfrmWanted As frmWoodReception = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWoodReception
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID Then
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

  Private Sub frmWoodReception_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False

    Try
      pFormController.LoadObject()
      RefreshSourceTabs()

      LoadCombos()

      RefreshControls()

      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
      RefreshDetailButtons()

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


  Private Sub RefreshSourceTabs()
    Dim mPos As Integer = 0
    Dim mPage As DevExpress.XtraTab.XtraTabPage
    Dim mIsActive As Boolean
    Dim mCurrentPage As DevExpress.XtraTab.XtraTabPage = Nothing
    Dim mWoodPallets As New colWoodPallets
    Dim mWoodPallet As dmWoodPallet

    mIsActive = pIsActive
    pIsActive = False

    'First remove excess tabs
    For mloop As Integer = xtabSourcePallet.TabPages.Count - 1 To 1 Step -1 'Note that it only counts down to 1 so it doesn't remove the last tab
      If mloop >= pFormController.CurrentReception.WoodPallets.Count - 1 Then
        xtabSourcePallet.TabPages.RemoveAt(mloop)
      End If
    Next

    'If there are no items then make page 0 invisible
    If pFormController.CurrentReception.WoodPallets.Count = 0 Then
      xtabSourcePallet.TabPages(0).PageVisible = False
      If pFormController.CurrentSourceWoodPallet Is Nothing Then pFormController.CurrentSourceWoodPallet = New dmWoodPallet
    Else
      xtabSourcePallet.TabPages(0).PageVisible = True
    End If

    'Name and Add in tabs
    mPos = 0
    mCurrentPage = Nothing

    For Each mSourcePallet As dmWoodPallet In pFormController.CurrentReception.WoodPallets
      '  mWoodPallet = pFormController.LoadWoodPalletByWoodPalletID(mSourcePallet.WoodPalletID)

      If mSourcePallet IsNot Nothing Then
        mWoodPallets.Add(mSourcePallet)
      End If
    Next

    If mWoodPallets.Count = 1 Then
      pFormController.CurrentSourceWoodPallet = mWoodPallets(0)
    End If
    For Each mWP As dmWoodPallet In mWoodPallets
      If mPos > xtabSourcePallet.TabPages.Count - 1 Then
        xtabSourcePallet.TabPages.Add()
      End If
      mPage = xtabSourcePallet.TabPages(mPos)
      mPage.Tag = mWP
      mPage.Text = String.Format("{0}/{1}", mWP.PalletRef, mWP.CardNumber)

      If pFormController.CurrentSourceWoodPallet Is Nothing Then

        pFormController.CurrentSourceWoodPallet = mWP

      End If

      If mWP Is pFormController.CurrentSourceWoodPallet Then
        mCurrentPage = mPage
      End If
      mPos += 1
    Next

    If mCurrentPage Is Nothing Then
      xtabSourcePallet.SelectedTabPageIndex = 0
      pnlOutputWoodPallet.Parent = xtabSourcePallet.TabPages(0)
    Else
      xtabSourcePallet.SelectedTabPage = mCurrentPage
      pnlOutputWoodPallet.Parent = mCurrentPage
    End If
    'RefreshHouseTypePanel()

    pIsActive = mIsActive

  End Sub
  Private Sub SetDetailsControlsReadonly(ByVal vReadOnly As Boolean)

    repoAddDuplicated.Buttons(0).Enabled = Not vReadOnly
    gvSourceWoodPalletItem.OptionsBehavior.ReadOnly = vReadOnly

  End Sub

  Private Sub repoAddDuplicated_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoAddDuplicated.ButtonClick
    Dim mSelectedWoodPalletItem As clsWoodPalletItemEditor
    Dim mDuplicatedWoodPalletItem As dmWoodPalletItem

    mSelectedWoodPalletItem = TryCast(gvSourceWoodPalletItem.GetFocusedRow, clsWoodPalletItemEditor)

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
      mDuplicatedWoodPalletItem.Thickness = 0
      mDuplicatedWoodPalletItem.WoodPalletID = mSelectedWoodPalletItem.WoodPalletItem.WoodPalletID
      pFormController.CurrentSourceWoodPallet.WoodPalletItems.Add(mDuplicatedWoodPalletItem)
      pFormController.SaveObjects()
      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors ''pFormController.CurrentWoodPallet.WoodPalletItems

      gvSourceWoodPalletItem.RefreshData()
    End If
  End Sub
  Private Sub RefreshDetailButtons()
    Select Case pCurrentDetailMode
      Case eCurrentDetailMode.eEdit
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpSourcePallet.CustomHeaderButtons
          If mBtn.Tag = ePalletOptions.Edit Then mBtn.Enabled = False
          If mBtn.Tag = ePalletOptions.Save Then mBtn.Enabled = True
          If mBtn.Tag = ePalletOptions.AddPack Then mBtn.Enabled = True
          If mBtn.Tag = ePalletOptions.AddWoodItem Then mBtn.Enabled = True


          bbtnAddNew.Enabled = False
        Next
      Case eCurrentDetailMode.eView
        For Each mBtn As DevExpress.XtraEditors.ButtonPanel.BaseButton In grpSourcePallet.CustomHeaderButtons
          If mBtn.Tag = ePalletOptions.Edit Then mBtn.Enabled = True
          If mBtn.Tag = ePalletOptions.Save Then mBtn.Enabled = False
          If mBtn.Tag = ePalletOptions.AddPack Then mBtn.Enabled = False
          If mBtn.Tag = ePalletOptions.AddWoodItem Then mBtn.Enabled = False
          bbtnAddNew.Enabled = True
        Next


    End Select
  End Sub

  Private Sub LoadCombos()
    clsDEControlLoading.FillDEComboVI(cboFarm, clsEnumsConstants.EnumToVIs(GetType(eFarms)))
    clsDEControlLoading.FillDEComboVI(cboWoodType, eStockItemTypeTimberWood.GetInstance.ValueItems)
    dteDateCreated.Properties.NullDate = Date.MinValue
  End Sub


  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub frmWoodReception_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub frmWoodReception_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    pFormController.ClearObjects()
    'FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
    Try

      UpdateObject()
      pFormController.SaveObjects()
      If pFormController.CurrentSourceWoodPallet.PalletType > 0 Then
        pFormController.SaveWoodPalletDown(pFormController.CurrentSourceWoodPallet)

      End If
      RefreshSourceTabs()
      RefreshControls()
      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
      gvSourceWoodPalletItem.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()



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
            ExitMode = Windows.Forms.DialogResult.No
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
    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then
        mRetVal = pFormController.SaveObjects()
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Problema de Validación")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  Private Sub UpdateObject()

    Dim mActiveControl As Control = Me.ActiveControl
    If mActiveControl IsNot Nothing Then
      mActiveControl.Focus()
    End If


    With pFormController.CurrentReception
      .ItemType = clsDEControlLoading.GetDEComboValue(cboWoodType)
      .Farm = clsDEControlLoading.GetDEComboValue(cboFarm)
      .CardNumber = txtCardNumber.Text
      .ReceptionDate = dteDateCreated.EditValue
    End With

    For Each mWP As dmWoodPallet In pFormController.CurrentReception.WoodPallets
      mWP.PalletType = pFormController.CurrentReception.ItemType
      If txtCardNumber.Text = "" Then
        mWP.CardNumber = ""
      Else
        mWP.CardNumber = txtCardNumber.Text

      End If

    Next
  End Sub

  Private Sub RefreshControls()
    Dim mIsActive As Boolean
    mIsActive = pIsActive

    If pFormController.CurrentReception IsNot Nothing Then


      With pFormController.CurrentReception

        dteDateCreated.EditValue = .ReceptionDate
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboFarm, .Farm)
        RTIS.Elements.clsDEControlLoading.SetDECombo(cboWoodType, .ItemType)
        txtCardNumber.Text = .CardNumber
      End With


    End If

    If pCurrentDetailMode = eCurrentDetailMode.eView Then
      SetDetailsControlsReadonly(True)
    ElseIf pCurrentDetailMode = eCurrentDetailMode.eEdit Then
      SetDetailsControlsReadonly(False)

    End If

    pIsActive = mIsActive
  End Sub

  Private Sub grpSourcePallet_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpSourcePallet.CustomButtonClick
    Dim mStockItems As New colStockItems
    Dim mPicker As clsPickerStockItem
    Dim mStockItem As dmStockItem
    Dim mNewWoodPalletItem As dmWoodPalletItem
    Dim mSelectedStockItems As colStockItems
    Dim mListFilteredSpecieID As New List(Of Integer)
    Dim mdsoStock As dsoStock
    Dim mFarm As Integer
    Dim mPalletType As Integer
    Dim pWoodPalletItemEditor As clsWoodPalletItemEditor
    mFarm = clsDEControlLoading.GetDEComboValue(cboWoodType)
    mPalletType = clsDEControlLoading.GetDEComboValue(cboWoodType)


    If pFormController.CurrentReception.WoodPallets IsNot Nothing Then


    End If
    Select Case e.Button.Properties.Tag

      Case ePalletOptions.Edit
        Dim mWoodPallet As dmWoodPallet
        'pFormController.LoadWoodPalletDetail()

        pCurrentDetailMode = eCurrentDetailMode.eEdit
        SetDetailsControlsReadonly(False)
        RefreshControls()
        RefreshDetailButtons()
      Case ePalletOptions.AddPack

        UpdateObject()
        pFormController.SaveObjects()
        pFormController.CreateNewPallet(mPalletType, mFarm, txtCardNumber.Text)
        gvSourceWoodPalletItem.RefreshData()
        pFormController.SaveObjects()

        SetDetailsControlsReadonly(False)
        pCurrentDetailMode = eCurrentDetailMode.eEdit
        RefreshDetailButtons()
        RefreshSourceTabs()
      Case ePalletOptions.AddWoodItem
        Dim mTempSI As dmStockItem
        UpdateObject()
        pFormController.SaveObjects()

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In pFormController.RTISGlobal.StockItemRegistry.StockItemsDict
          mTempSI = TryCast(mItem.Value, dmStockItem)
          If mTempSI IsNot Nothing Then
            If mTempSI.ItemType = pFormController.CurrentReception.ItemType Then
              mStockItems.Add(mItem.Value)
            End If
          End If

        Next

        mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, pFormController.RTISGlobal)

        For Each mWoodPalletItem As dmWoodPalletItem In pFormController.CurrentSourceWoodPallet.WoodPalletItems
          If mWoodPalletItem.StockItemID > 0 Then
            mStockItem = mStockItems.ItemFromKey(mWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              mPicker.SelectedObjects.Add(mStockItem)
            End If
          End If
        Next

        frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, pFormController.RTISGlobal, True, pFormController.CurrentReception.ItemType)
        For Each mSelectedItem In mPicker.SelectedObjects
            If mSelectedItem IsNot Nothing Then
              mNewWoodPalletItem = pFormController.CurrentSourceWoodPallet.WoodPalletItems.ItemByStockItemID(mSelectedItem.StockItemID)
              If mNewWoodPalletItem Is Nothing Then
                mNewWoodPalletItem = pFormController.AddWoodPalletItem(pFormController.CurrentSourceWoodPallet)
                mNewWoodPalletItem.StockItemID = mSelectedItem.StockItemID
                mNewWoodPalletItem.Description = mSelectedItem.Description
                mNewWoodPalletItem.StockCode = mSelectedItem.StockCode
                mNewWoodPalletItem.Thickness = mSelectedItem.Thickness

                pWoodPalletItemEditor = New clsWoodPalletItemEditor(mNewWoodPalletItem, mSelectedItem)
                pFormController.SourceWoodPalletItemEditors.Add(pWoodPalletItemEditor)
              End If
            End If
          Next

          mSelectedStockItems = New colStockItems(mPicker.SelectedObjects)

        For mindex As Integer = pFormController.CurrentSourceWoodPallet.WoodPalletItems.Count - 1 To 0 Step -1
          mNewWoodPalletItem = pFormController.CurrentSourceWoodPallet.WoodPalletItems(mindex)
          If mNewWoodPalletItem.StockItemID > 0 Then
            mStockItem = mSelectedStockItems.ItemFromKey(mNewWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              pFormController.CurrentSourceWoodPallet.WoodPalletItems.Remove(mNewWoodPalletItem)
            End If
          End If
        Next


        pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
        grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors''pFormController.CurrentWoodPallet.WoodPalletItems


      Case ePalletOptions.Reception

        gvSourceWoodPalletItem.CloseEditor()
        pFormController.SaveWoodPalletDown(pFormController.CurrentSourceWoodPallet)
        CheckSave(False)
        ToReceiveWoodPallets()
        UpdateObject()
        pFormController.SaveObjects()
        If pFormController.CurrentSourceWoodPallet.PalletType > 0 Then
          pFormController.SaveWoodPalletDown(pFormController.CurrentSourceWoodPallet)

        End If
        RefreshSourceTabs()
        RefreshControls()
        pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
        grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
        gvSourceWoodPalletItem.RefreshData()


        pCurrentDetailMode = eCurrentDetailMode.eView
        SetDetailsControlsReadonly(True)
        RefreshControls()
        RefreshDetailButtons()
      Case ePalletOptions.Save
        UpdateObject()
        pFormController.SaveObjects()
        pCurrentDetailMode = eCurrentDetailMode.eView
        gvSourceWoodPalletItem.RefreshData()
        SetDetailsControlsReadonly(True)
        RefreshControls()
        RefreshDetailButtons()
    End Select


  End Sub
  Private Sub ToReceiveWoodPallets()

    pFormController.ReceiveWoodPallets()


    CheckSave(False)
    UpdateObject()
    CheckSave(False)

    RefreshSourceTabs()

    RefreshControls()

    pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
    grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
    gvSourceWoodPalletItem.RefreshData()
  End Sub
  Private Sub xtabSourcePallet_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtabSourcePallet.SelectedPageChanged
    Try
      If pIsActive Then
        'UpdateHouseTypePanel()
        If e.Page.Tag IsNot Nothing Then

          pnlOutputWoodPallet.Parent = e.Page
          pFormController.SetCurrentSourceWoodPallet(e.Page.Tag)

        Else
          pFormController.SetCurrentSourceWoodPallet(Nothing)
        End If
      Else
        pFormController.SetCurrentSourceWoodPallet(Nothing)
      End If


      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
      grdSourceWoodPalletItem.RefreshDataSource()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnSaveAndClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub
  Private Sub barbtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Protected Overrides Sub Finalize()
    If FormController IsNot Nothing Then FormController = Nothing
    MyBase.Finalize()
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

  Private Sub gvSourceWoodPalletItem_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvSourceWoodPalletItem.FocusedRowObjectChanged


    Try

      If pFormController.CurrentSourceWoodPallet IsNot Nothing Then

        ''pCurrentDetailMode = eCurrentDetailMode.eView
        'pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
        'grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors 'pFormController.CurrentWoodPallet.WoodPalletItems
        RefreshDetailButtons()
        RefreshControls()
        If pFormController.CurrentSourceWoodPallet.PalletType = eStockItemTypeTimberWood.Rollo Then
          gcThickness.Caption = "Diametro"
          gcThickness.OptionsColumn.ReadOnly = False
          gcQuantity.Caption = "Trozas"
          gcWidth.Visible = False
          lblFarm.Visible = True
          cboFarm.Visible = True
        Else
          gcThickness.Caption = "Grosor"
          gcThickness.OptionsColumn.ReadOnly = True
          gcWidth.Visible = True
          lblFarm.Visible = False
          cboFarm.Visible = False
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub grdSourceWoodPalletItem_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles grdSourceWoodPalletItem.EditorKeyDown
    If e.KeyCode = Keys.Enter Then
      gvSourceWoodPalletItem.MoveNext()

    End If
  End Sub
End Class