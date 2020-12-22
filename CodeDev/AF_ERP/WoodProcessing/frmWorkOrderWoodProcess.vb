Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls

Public Class frmWorkOrderWoodProcess
  Private pFormController As fccWorkOrderWoodProcess
  Public FormMode As eFormMode
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pCurrentDetailMode As eCurrentDetailMode
  Public ExitMode As Windows.Forms.DialogResult
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False


  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
    eMovement = 3
  End Enum

  Private Enum ePalletOptions
    AddPack = 1
    AddWood = 2
    Process = 3

  End Enum

  Public Shared Sub OpenForm(ByRef rMDIForm As frmTabbedMDI, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWorkOrderID As Integer)
    Dim mfrm As frmWorkOrderWoodProcess

    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderWoodProcess
      mfrm.pFormController = New fccWorkOrderWoodProcess(rDBConn, rRTISGlobal, vWorkOrderID)
      mfrm.FormMode = eFormMode.eFMFormModeAdd
      mfrm.MdiParent = rMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If


  End Sub

  Private Shared Function GetFormIfLoaded() As frmWorkOrderWoodProcess
    Dim mfrmWanted As frmWorkOrderWoodProcess = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWorkOrderWoodProcess
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmWorkOrderWoodProcess Then
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


  Private Sub frmWorkOrderWoodProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False

    Try
      pFormController.LoadObject()
      '// set it to the first WoodPallet
      If pFormController.WoodPallets.Count >= 1 Then
        pFormController.SetCurrentWoodPallet(pFormController.WoodPallets(0))
      End If

      RefreshTabs()

      LoadCombos()

      RefreshControls()


      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItem


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


  Private Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eProductType))
    'clsDEControlLoading.FillDEComboVI(cboProductType, mVIs)

  End Sub
  Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
    Try

      UpdateObject()
      'UpdateHouseTypePanel()
      pFormController.SaveObjects()
      RefreshTabs()
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


    With pFormController.CurrentWoodWorkOrder
      ''.Quantity = txtQuantity.Text
      ''.Description = tx.Text.ToUpper

      '.PlannedStartDate = dtePlannedStartDate.DateTime
      '.PlannedDeliverDate = dtePlannedDeliverDate.DateTime

      '.DrawingDate = dteDrawingDate.DateTime

      '.UnitPrice = Val(txtUnitCost.Text)

      '.FurnitureCategoryID = clsDEControlLoading.GetDEComboValue(cboFurnitureCategory)
      '.EmployeeID = clsDEControlLoading.GetDEComboValue(cboEmployee)

      '.WorkcentreID = getCheckValue()



    End With
    'UpdateProductControls()
  End Sub

  Private Sub RefreshControls()
    Dim mIsActive As Boolean
    mIsActive = pIsActive

    'With pFormController.WorkOrder
    '  lblWorkOrderID.Text = "ID:" & .WorkOrderID.ToString("00000")
    '  If .WorkOrderNo = "" Then
    '    Me.Text = "O.T. Nuevo"
    '  Else
    '    Me.Text = "O.T. " & .WorkOrderNo
    '  End If


    '  txtQtyPerSalesItem.Text = .QtyPerSalesItem

    '  txtQuantity.Text = .Quantity
    '  txtUnitCost.Text = .UnitPrice

    '  btnWorkOrderNumber.EditValue = .WorkOrderNo
    '  txtDescription.Text = .Description

    '  dtePlannedStartDate.DateTime = .PlannedStartDate
    '  dtePlannedDeliverDate.DateTime = .PlannedDeliverDate
    '  dteDrawingDate.DateTime = .DrawingDate


    '  clsDEControlLoading.SetDECombo(cboProductType, .ProductTypeID)
    '  ''clsDEControlLoading.SetDECombo(cboWoodFinish, .WoodFinish)
    '  clsDEControlLoading.SetDECombo(cboFurnitureCategory, .FurnitureCategoryID)
    '  clsDEControlLoading.SetDECombo(cboEmployee, .EmployeeID)


    '  btneWorkOrderDocument.Text = .OutputDocuments.GetFileName(eParentType.WorkOrder, eDocumentType.WorkOrderDoc, eFileType.PDF)

    '  bteImage.Text = .ImageFile

    '  RefreshProductControls()

    '  If pFormController.WorkOrder.isInternal = False Then
    '    UctFileControl1.LoadControls()
    '    UctFileControl1.RefreshControls()
    '    RefreshSalesControls()
    '    With pFormController.SalesOrderItem
    '      txtPrice.Text = .UnitPrice
    '      txtSalesQuantity.Text = .Quantity
    '    End With
    '  End If

    'End With

    pIsActive = mIsActive
  End Sub

  Private Sub grpConsumedWoodPalletItemInfo_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpConsumedWoodPalletItemInfo.CustomButtonClick

    Dim mWoodPallets As New colWoodPallets
    Dim mPicker As clsPickerWoodPallet
    Dim mSelectedWoodPallet As dmWoodPallet
    Dim mListOfWoodPalletsFilterd As New colWoodPallets
    Dim mdso As New dsoStock(pFormController.DBConn)
    Dim mWhere As String = "PalletType = " & CInt(rgWoodPalletType.EditValue)
    Dim mWoodPallet As dmWoodPallet
    Dim mDataSource As New colWoodPalletItems
    Dim mSourceWoodPallet As dmSourcePallet
    Select Case e.Button.Properties.Tag
      Case ePalletOptions.AddPack
        Try


          mdso.LoadWoodPalletDownByWhere(mListOfWoodPalletsFilterd, mWhere)

          For Each mItem As dmWoodPallet In mListOfWoodPalletsFilterd
            mWoodPallets.Add(mItem)
          Next

          mPicker = New clsPickerWoodPallet(mWoodPallets, pFormController.DBConn, rgWoodPalletType.EditValue)


          For Each mSourceWoodPalletTemp As dmSourcePallet In pFormController.CurrentWoodWorkOrder.SourcePallets
            mSelectedWoodPallet = mWoodPallets.ItemFromKey(mSourceWoodPalletTemp.WoodPalletID)
            If mSelectedWoodPallet IsNot Nothing Then
              If mPicker.SelectedObjects.Contains(mSelectedWoodPallet) = False Then
                mPicker.SelectedObjects.Add(mSelectedWoodPallet)
              End If
            End If
          Next

          frmWoodPalletPicker.OpenPickerMulti(mPicker, True, pFormController.DBConn, AppRTISGlobal.GetInstance)

          For Each mWoodPalletTemp In mPicker.SelectedObjects
            If mWoodPalletTemp IsNot Nothing Then

              mWoodPallet = mListOfWoodPalletsFilterd.ItemFromKey(mWoodPalletTemp.WoodPalletID)
              If mWoodPallet IsNot Nothing Then
                mSourceWoodPallet = New dmSourcePallet
                mSourceWoodPallet.WorkOrderID = pFormController.CurrentWoodWorkOrder.WorkOrderID
                mSourceWoodPallet.WoodPalletID = mWoodPalletTemp.WoodPalletID

                pFormController.CurrentWoodWorkOrder.SourcePallets.Add(mSourceWoodPallet)

                For Each mWoodPalletItem As dmWoodPalletItem In mWoodPallet.WoodPalletItems
                  Dim mNewWoodPalletItem As New clsWoodPalletItemEditor
                  mNewWoodPalletItem.Description = mWoodPalletItem.Description
                  mNewWoodPalletItem.Quantity = mWoodPalletItem.Quantity
                  mNewWoodPalletItem.QuantityUsed = mWoodPalletItem.QuantityUsed
                  mNewWoodPalletItem.StockItemID = mWoodPalletItem.StockItemID
                  mNewWoodPalletItem.Thickness = mWoodPalletItem.Thickness
                  mNewWoodPalletItem.WoodPalletID = mWoodPalletItem.WoodPalletID
                  mNewWoodPalletItem.WoodPalletItemID = mWoodPalletItem.WoodPalletItemID
                  mNewWoodPalletItem.StockCode = mWoodPalletItem.StockCode
                  pFormController.SourceWoodPalletItem.Add(mNewWoodPalletItem)
                Next


              End If
            End If
          Next
          grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItem
          pFormController.SaveObjects()
        Catch ex As Exception

          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try




    End Select
  End Sub

  Private Sub grpOutputWood_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpOutputWood.CustomButtonClick
    Dim mStockItems As New colStockItems
    Dim mPicker As clsPickerStockItem
    Dim mStockItem As dmStockItem
    Dim mNewWoodPalletItem As dmWoodPalletItem
    Dim pWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mSelectedStockItems As colStockItems


    Select Case e.Button.Properties.Tag
      Case ePalletOptions.AddPack

        pFormController.CreateWoodPallet(rgWoodPalletType.EditValue)
        'grdOutputWoodPalletItem.DataSource = pFormController.OutputWoodPalletItem
        gvOutputWoodPaleltItem.RefreshData()

      Case ePalletOptions.AddWood
        UpdateObject()
        pFormController.SaveObjects()

        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In AppRTISGlobal.GetInstance.StockItemRegistry.StockItemsDict
          mStockItems.Add(mItem.Value)
        Next

        mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, AppRTISGlobal.GetInstance)

        For Each mWoodPalletItem As dmWoodPalletItem In pFormController.CurrentWoodPallet.WoodPalletItems
          If mWoodPalletItem.StockItemID > 0 Then
            mStockItem = mStockItems.ItemFromKey(mWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              mPicker.SelectedObjects.Add(mStockItem)
            End If
          End If
        Next

        If frmPickerStockItem.PickPurchaseOrderItems(mPicker, AppRTISGlobal.GetInstance, True, pFormController.CurrentWoodPallet.PalletType) Then
          For Each mSelectedItem In mPicker.SelectedObjects
            If mSelectedItem IsNot Nothing Then
              mNewWoodPalletItem = pFormController.CurrentWoodPallet.WoodPalletItems.ItemByStockItemID(mSelectedItem.StockItemID)
              If mNewWoodPalletItem Is Nothing Then
                mNewWoodPalletItem = New dmWoodPalletItem
                mNewWoodPalletItem.WoodPalletID = pFormController.CurrentWoodPallet.WoodPalletID
                mNewWoodPalletItem.StockItemID = mSelectedItem.StockItemID
                mNewWoodPalletItem.Description = mSelectedItem.Description
                mNewWoodPalletItem.StockCode = mSelectedItem.StockCode
                mNewWoodPalletItem.Thickness = mSelectedItem.Thickness
                pFormController.CurrentWoodPallet.WoodPalletItems.Add(mNewWoodPalletItem)
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
        pFormController.WoodPallets.ItemFromKey(pFormController.CurrentWoodPallet.WoodPalletID).WoodPalletItems = pFormController.CurrentWoodPallet.WoodPalletItems


        pFormController.SaveObjects()

        'grdOutputWoodPalletItem.DataSource = pFormController.CurrentWoodPallet.WoodPalletItems

    End Select


    RefreshTabs()
  End Sub

  Private Sub xtabOutputWood_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtabOutputWood.SelectedPageChanged
    Try
      If pIsActive Then
        'UpdateHouseTypePanel()
        If e.Page.Tag IsNot Nothing Then

          pnlOutputWoodPallet.Parent = e.Page
          pFormController.SetCurrentWoodPallet(e.Page.Tag)

        Else
          pFormController.SetCurrentWoodPallet(Nothing)
        End If
      Else
        pFormController.SetCurrentWoodPallet(Nothing)
      End If

      grdOutputWoodPalletItem.DataSource = pFormController.CurrentWoodPallet.WoodPalletItems
      grdOutputWoodPalletItem.RefreshDataSource()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub RefreshTabs()
    Dim mPos As Integer = 0
    Dim mPage As DevExpress.XtraTab.XtraTabPage
    Dim mIsActive As Boolean
    Dim mCurrentPage As DevExpress.XtraTab.XtraTabPage = Nothing
    Dim mWoodPallets As New colWoodPallets
    Dim mWoodPallet As dmWoodPallet

    mIsActive = pIsActive
    pIsActive = False

    'First remove excess tabs
    For mloop As Integer = xtabOutputWood.TabPages.Count - 1 To 1 Step -1 'Note that it only counts down to 1 so it doesn't remove the last tab
      If mloop >= pFormController.CurrentWoodWorkOrder.OutputPallets.Count - 1 Then
        xtabOutputWood.TabPages.RemoveAt(mloop)
      End If
    Next

    'If there are no items then make page 0 invisible
    If pFormController.CurrentWoodWorkOrder.OutputPallets.Count = 0 Then
      xtabOutputWood.TabPages(0).PageVisible = False
      If pFormController.CurrentWoodPallet Is Nothing Then pFormController.CurrentWoodPallet = New dmWoodPallet
    Else
      xtabOutputWood.TabPages(0).PageVisible = True
    End If

    'Name and Add in tabs
    mPos = 0
    mCurrentPage = Nothing

    For Each mOutputWoodPallet As dmOutputPallet In pFormController.CurrentWoodWorkOrder.OutputPallets
      mWoodPallet = pFormController.LoadWoodPalletByWoodPalletID(mOutputWoodPallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        mWoodPallets.Add(mWoodPallet)
      End If
    Next

    For Each mWP As dmWoodPallet In mWoodPallets
      If mPos > xtabOutputWood.TabPages.Count - 1 Then
        xtabOutputWood.TabPages.Add()
      End If
      mPage = xtabOutputWood.TabPages(mPos)
      mPage.Tag = mWP
      mPage.Text = String.Format("{0}/{1}", mWP.PalletRef, mWP.Description)

      If mWP Is pFormController.CurrentWoodPallet Then mCurrentPage = mPage
      mPos += 1
    Next

    If mCurrentPage Is Nothing Then
      xtabOutputWood.SelectedTabPageIndex = 0
      pnlOutputWoodPallet.Parent = xtabOutputWood.TabPages(0)
    Else
      xtabOutputWood.SelectedTabPage = mCurrentPage
      pnlOutputWoodPallet.Parent = mCurrentPage
    End If
    'RefreshHouseTypePanel()

    pIsActive = mIsActive

  End Sub

  Private Sub rgWoodPalletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgWoodPalletType.SelectedIndexChanged
    pFormController.WorkOrderWoodType = rgWoodPalletType.EditValue
  End Sub
End Class