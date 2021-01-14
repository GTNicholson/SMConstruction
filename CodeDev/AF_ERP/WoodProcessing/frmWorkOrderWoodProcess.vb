Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports RTIS.Elements
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

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

  Private pSourceItemType As Integer
  Private pTargetItemType As Integer

  Private Enum eCurrentDetailMode
    eView = 1
    eEdit = 2
    eMovement = 3
  End Enum

  Private Enum ePalletOptions
    AddPack = 1
    AddWoodItem = 2
    Process = 3

  End Enum

  Private pAddingOption As eWorkOrderWoodProcess

  Public Sub New()
    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub
  Public Shared Sub OpenForm(ByRef rMDIForm As frmTabbedMDI, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWorkOrderID As Integer, ByVal vSourceItemType As Integer, ByVal vTargetItemType As Integer, ByVal vAddingOption As eWorkOrderWoodProcess)
    Dim mfrm As frmWorkOrderWoodProcess = Nothing

    If vWorkOrderID <> 0 Then
      mfrm = GetFormIfLoaded(vWorkOrderID)
    End If


    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderWoodProcess
      mfrm.pFormController = New fccWorkOrderWoodProcess(rDBConn, rRTISGlobal, vWorkOrderID, vSourceItemType, vTargetItemType, vAddingOption)

      mfrm.FormMode = eFormMode.eFMFormModeAdd
      mfrm.MdiParent = rMDIForm
      mfrm.pSourceItemType = vSourceItemType
      mfrm.pTargetItemType = vTargetItemType
      mfrm.pAddingOption = vAddingOption
      mfrm.Show()
    Else
      mfrm.Focus()
    End If



  End Sub

  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmWorkOrderWoodProcess
    Dim mfrmWanted As frmWorkOrderWoodProcess = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWorkOrderWoodProcess
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.pFormController.WorkOrderID = vPrimaryKeyID Then
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
        pFormController.SetCurrentOutputWoodPallet(pFormController.WoodPallets(0))
      End If
      RefreshSourceTabs()
      RefreshOutputTabs()

      LoadCombos()

      RefreshControls()

      SetupTabOptionControls()

      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors


      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
      grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors

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

  Private Sub SetupTabOptionControls()

    Select Case pFormController.CurrentWoodWorkOrder.WorkOrderProcessOption
      Case eWorkOrderWoodProcess.Horno
        xtcProcessOptions.TabPages(0).PageVisible = True
        xtpKiln.Visible = True
        grpGeneralInformation.Text = "Detalles de Registro para el Horno"
        grpOutputWood.CustomHeaderButtons(0).Properties.Visible = False
        grpOutputWood.CustomHeaderButtons(1).Properties.Visible = False
        grpOutputWood.CustomHeaderButtons(2).Properties.Visible = False
        gvSourceWoodPalletItem.Columns.Item("ToProcessQty").Visible = False

        grpConsumedWoodPalletItemInfo.CustomHeaderButtons(1).Properties.Visible = False




      Case eWorkOrderWoodProcess.Clasificar

        xtcProcessOptions.TabPages(0).PageVisible = False
        grpGeneralInformation.Text = "Detalles de Registro para el Clasificado"
        grpOutputWood.CustomHeaderButtons(0).Properties.Visible = True
        grpOutputWood.CustomHeaderButtons(1).Properties.Visible = True
        grpOutputWood.CustomHeaderButtons(2).Properties.Visible = False
        gvSourceWoodPalletItem.Columns("ToProcessQty").Visible = True

        grpConsumedWoodPalletItemInfo.CustomHeaderButtons(1).Properties.Visible = True


      Case eWorkOrderWoodProcess.Aserrio
        xtcProcessOptions.TabPages(0).PageVisible = False

        grpGeneralInformation.Text = "Detalles de Registro para el Aserrío"
        grpOutputWood.CustomHeaderButtons(0).Properties.Visible = True
        grpOutputWood.CustomHeaderButtons(1).Properties.Visible = True
        grpOutputWood.CustomHeaderButtons(2).Properties.Visible = True

        gvSourceWoodPalletItem.Columns("ToProcessQty").Visible = True
        gvOutputWoodPaleltItem.Columns("ToProcessQty").Visible = True

        grpConsumedWoodPalletItemInfo.CustomHeaderButtons(1).Properties.Visible = True

    End Select

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub frmWorkOrderWoodProcess_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub frmWorkOrderWoodProcess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    pFormController.ClearObjects()
    'FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eProductType))
    'clsDEControlLoading.FillDEComboVI(cboProductType, mVIs)

  End Sub
  Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
    Try

      UpdateObject()
      UpdateWoodPalletRef()
      'UpdateHouseTypePanel()
      UpdateOutputWoodPalletItems()
      pFormController.SaveObjects()
      If pFormController.CurrentOutputWoodPallet.PalletType > 0 Then
        pFormController.SaveWoodPalletDown(pFormController.CurrentSourceWoodPallet)

      End If
      If pFormController.CurrentOutputWoodPallet.PalletType > 0 Then
        pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)

      End If

      RefreshSourceTabs()
      RefreshOutputTabs()
      RefreshControls()
      pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
      grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
      gvSourceWoodPalletItem.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub UpdateOutputWoodPalletItems()

    Dim mWPI As dmWoodPalletItem
    Dim mToUpdateListWPI As New colWoodPalletItems
    If grdOutputWoodPalletItem.DataSource IsNot Nothing Then
      For Each mItem In grdOutputWoodPalletItem.DataSource

        mWPI = TryCast(mItem, clsWoodPalletItemEditor).WoodPalletItem

        If mWPI IsNot Nothing Then
          mToUpdateListWPI.Add(mWPI)
        End If

      Next



      If mToUpdateListWPI.Count > 0 Then

        For Each mOutputWPI In pFormController.CurrentOutputWoodPallet.WoodPalletItems

          If mToUpdateListWPI.IndexFromKey(mOutputWPI.WoodPalletItemID) <> -1 Then
            mOutputWPI.Width = mToUpdateListWPI.ItemFromKey(mOutputWPI.WoodPalletItemID).Width
            mOutputWPI.Thickness = mToUpdateListWPI.ItemFromKey(mOutputWPI.WoodPalletItemID).Thickness
            mOutputWPI.Length = mToUpdateListWPI.ItemFromKey(mOutputWPI.WoodPalletItemID).Length
            mOutputWPI.Quantity = mToUpdateListWPI.ItemFromKey(mOutputWPI.WoodPalletItemID).Quantity

          End If


        Next


      End If

    End If
  End Sub

  Private Sub UpdateWoodPalletRef()
    Dim mWoodPallets As colWoodPallets

    mWoodPallets = pFormController.GetWoodPalletSource()

    For Each mWoodPallet As dmWoodPallet In mWoodPallets
      mWoodPallet.KilnEndDate = dteKilnEndDate.EditValue
      mWoodPallet.KilnStartDate = dteKilnStartDate.EditValue

      pFormController.SaveWoodPalletDown(mWoodPallet)
    Next

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
      .DateCreated = dteDateCreated.EditValue

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
    Dim mWoodPallet As dmWoodPallet

    mIsActive = pIsActive

    If pFormController.CurrentWoodWorkOrder IsNot Nothing Then


      With pFormController.CurrentWoodWorkOrder

        dteDateCreated.EditValue = .PlannedStartDate

        If .SourcePallets IsNot Nothing And .SourcePallets.Count > 0 Then
          mWoodPallet = New dmWoodPallet
          mWoodPallet = pFormController.getWoodPalletFromWoodPalletID(.SourcePallets(0).WoodPalletID)


          If mWoodPallet IsNot Nothing Then
            dteKilnEndDate.EditValue = mWoodPallet.KilnEndDate
            dteKilnStartDate.EditValue = mWoodPallet.KilnStartDate


            If mWoodPallet.KilnStartDate = Date.MinValue Then
              btnEndKiln.Enabled = False
              btnStartKiln.Enabled = True
            Else
              If mWoodPallet.KilnEndDate = Date.MinValue Then
                btnStartKiln.Enabled = False
                btnEndKiln.Enabled = True
              Else
                btnStartKiln.Enabled = False
                btnEndKiln.Enabled = False
                grpConsumedWoodPalletItemInfo.CustomHeaderButtons.Item(0).Properties.Visible = False
              End If

            End If
          End If

        End If

      End With


    End If

    pIsActive = mIsActive
  End Sub



  Private Sub grpConsumedWoodPalletItemInfo_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpConsumedWoodPalletItemInfo.CustomButtonClick

    Dim mWoodPallets As New colWoodPallets
    Dim mPicker As clsPickerWoodPallet
    Dim mSelectedWoodPallet As dmWoodPallet
    Dim mListOfWoodPalletsFilterd As New colWoodPallets
    Dim mdso As New dsoStock(pFormController.DBConn)
    Dim mWhere As String = "PalletType = " & pFormController.CurrentWoodWorkOrder.WorkOrderWoodType & " and LocationID<>0 AND IsComplete<>1"
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



          mPicker = New clsPickerWoodPallet(mWoodPallets, pFormController.DBConn, pFormController.CurrentWoodWorkOrder.WorkOrderWoodType)


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

                If pFormController.SourceWoodPalletItem.ItemFromWoodPalletItem(mWoodPallet.WoodPalletID) Is Nothing Then
                  mSourceWoodPallet = New dmSourcePallet
                  mSourceWoodPallet.WorkOrderID = pFormController.CurrentWoodWorkOrder.WorkOrderID
                  mSourceWoodPallet.WoodPalletID = mWoodPalletTemp.WoodPalletID

                  pFormController.CurrentWoodWorkOrder.SourcePallets.Add(mSourceWoodPallet)

                  For Each mWoodPalletItem As dmWoodPalletItem In mWoodPallet.WoodPalletItems
                    Dim mNewWoodPalletItem As New clsWoodPalletItemEditor
                    'mNewWoodPalletItem.Description = mWoodPalletItem.Description
                    'mNewWoodPalletItem.Quantity = mWoodPalletItem.Quantity
                    'mNewWoodPalletItem.QuantityUsed = mWoodPalletItem.QuantityUsed
                    'mNewWoodPalletItem.StockItemID = mWoodPalletItem.StockItemID
                    'mNewWoodPalletItem.Thickness = mWoodPalletItem.Thickness
                    'mNewWoodPalletItem.Width = mWoodPalletItem.Width
                    'mNewWoodPalletItem.Length = mWoodPalletItem.Length
                    'mNewWoodPalletItem.WoodPalletID = mWoodPalletItem.WoodPalletID
                    'mNewWoodPalletItem.WoodPalletItemID = mWoodPalletItem.WoodPalletItemID
                    'mNewWoodPalletItem.StockCode = mWoodPalletItem.StockCode
                    'mNewWoodPalletItem.WoodPalletItem = mNewWoodPalletItem.WoodPalletItem
                    'mNewWoodPalletItem.StockItem = mNewWoodPalletItem.StockItem
                    Dim mSI As dmStockItem
                    mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWoodPalletItem.StockItemID)

                    mNewWoodPalletItem.WoodPalletItem = mWoodPalletItem

                    mNewWoodPalletItem.StockItem = mSI

                    pFormController.SourceWoodPalletItemEditors.Add(mNewWoodPalletItem)
                    pFormController.SourceWoodPalletItem.Add(mNewWoodPalletItem)
                  Next
                End If



              End If
            End If
          Next
          pFormController.SaveObjects()
          RefreshSourceTabs()
          RefreshOutputTabs()
          pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
          grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
          gvSourceWoodPalletItem.RefreshData()


          'grdSourceWoodPalletItem.DataSource = pFormController.CurrentSourceWoodPallet.WoodPalletItems
          'gvSourceWoodPalletItem.RefreshData()
        Catch ex As Exception

          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
        End Try


      Case ePalletOptions.Process

        Select Case pFormController.CurrentWoodWorkOrder.WorkOrderProcessOption

          Case eWorkOrderWoodProcess.Aserrio
            CheckSave(False)
            gvSourceWoodPalletItem.CloseEditor()
            ProcessAserrio()
            CheckSave(False)
          Case eWorkOrderWoodProcess.Clasificar
            CheckSave(False)
            gvSourceWoodPalletItem.CloseEditor()

            ProcessClasificar()
            CheckSave(False)
        End Select

    End Select
  End Sub

  Private Sub ProcessOutputAserrio()

    pFormController.ProcessOutpuAserrio(pFormController.CurrentOutputWoodPallet.LocationID, pFormController.CurrentOutputWoodPallet.WoodPalletID)


    CheckSave(False)




    pFormController.LoadOtputWoodPallet()
    pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
    grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors
    grdOutputWoodPalletItem.RefreshDataSource()
    gvOutputWoodPaleltItem.RefreshData()
  End Sub

  Private Sub ProcesssAserrio()
    pFormController.ProcessSourceAserrado(pFormController.CurrentSourceWoodPallet.LocationID, pFormController.CurrentOutputWoodPallet.WoodPalletID)


    CheckSave(False)
    RefreshSourceTabs()
    RefreshOutputTabs()

    RefreshControls()

    pFormController.LoadSourceWoodPallet()
    pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
    grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
    gvSourceWoodPalletItem.RefreshData()
  End Sub

  Private Sub grpOutputWood_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpOutputWood.CustomButtonClick
    Dim mStockItems As New colStockItems
    Dim mPicker As clsPickerStockItem
    Dim mStockItem As dmStockItem
    Dim mNewWoodPalletItem As dmWoodPalletItem
    Dim pWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mSelectedStockItems As colStockItems
    Dim mSourceWoodPallet As dmWoodPallet
    Dim mListFilteredSpecieID As New List(Of Integer)
    Dim mdsoStock As dsoStock
    If pFormController.CurrentWoodWorkOrder.SourcePallets IsNot Nothing Then

      If pFormController.CurrentWoodWorkOrder.SourcePallets.Count > 0 Then
        mSourceWoodPallet = pFormController.getWoodPalletFromWoodPalletID(pFormController.CurrentWoodWorkOrder.SourcePallets(0).WoodPalletID)

        If mSourceWoodPallet IsNot Nothing Then
          pFormController.WorkOrderSourceWoodType = mSourceWoodPallet.PalletType
        End If
      End If
    End If
    Select Case e.Button.Properties.Tag

      Case ePalletOptions.AddPack

        Select Case pFormController.CurrentWoodWorkOrder.WorkOrderProcessOption
          Case eWorkOrderWoodProcess.Clasificar
            If pFormController.WorkOrderSourceWoodType = pSourceItemType Then
              pTargetItemType = frmMovementClassified.OpenFormI(pFormController.DBConn)
            End If
        End Select


        pFormController.CreateWoodPallet(pTargetItemType)
        'grdOutputWoodPalletItem.DataSource = pFormController.OutputWoodPalletItem
        gvOutputWoodPaleltItem.RefreshData()



      Case ePalletOptions.AddWoodItem
        mListFilteredSpecieID = clsWoodPalletSharedFuncs.GetSpeciesQty(pFormController.GetWoodPalletSource())

        UpdateObject()
        pFormController.SaveObjects()

        ''//Get the different species


        For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In AppRTISGlobal.GetInstance.StockItemRegistry.StockItemsDict
          Dim mSI As dmStockItem

          mSI = TryCast(mItem.Value, dmStockItem)

          If mSI IsNot Nothing Then

            If mSI.Category = eStockItemCategory.Timber And mSI.ItemType = pFormController.CurrentWoodWorkOrder.WorkOrderTargetWoodType And mListFilteredSpecieID.Contains(mSI.Species) Then
              mStockItems.Add(mItem.Value)

            End If

          End If

        Next

        mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, AppRTISGlobal.GetInstance)

        For Each mWoodPalletItem As dmWoodPalletItem In pFormController.CurrentOutputWoodPallet.WoodPalletItems
          If mWoodPalletItem.StockItemID > 0 Then
            mStockItem = mStockItems.ItemFromKey(mWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              mPicker.SelectedObjects.Add(mStockItem)
            End If
          End If
        Next

        If frmPickerStockItem.PickPurchaseOrderItems(mPicker, AppRTISGlobal.GetInstance, True, pFormController.CurrentOutputWoodPallet.PalletType) Then
          mdsoStock = New dsoStock(pFormController.DBConn)
          For Each mSelectedItem In mPicker.SelectedObjects
            Dim mWoodPalletItemEditor As New clsWoodPalletItemEditor
            If mSelectedItem IsNot Nothing Then
              mNewWoodPalletItem = pFormController.CurrentOutputWoodPallet.WoodPalletItems.ItemByStockItemID(mSelectedItem.StockItemID)
              If mNewWoodPalletItem Is Nothing Then
                mNewWoodPalletItem = New dmWoodPalletItem
                mNewWoodPalletItem.WoodPalletID = pFormController.CurrentOutputWoodPallet.WoodPalletID
                mNewWoodPalletItem.StockItemID = mSelectedItem.StockItemID
                mNewWoodPalletItem.Description = mSelectedItem.Description
                mNewWoodPalletItem.StockCode = mSelectedItem.StockCode
                mNewWoodPalletItem.Thickness = mSelectedItem.Thickness

                mWoodPalletItemEditor.StockItem = mSelectedItem
                mWoodPalletItemEditor.WoodPalletItem = mNewWoodPalletItem

                pFormController.CurrentOutputWoodPallet.WoodPalletItems.Add(mNewWoodPalletItem)
                pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)

                pFormController.OutPutWoodPalletItemEditors.Add(mWoodPalletItemEditor)
              End If
            End If
          Next
        End If
        mSelectedStockItems = New colStockItems(mPicker.SelectedObjects)

        For mindex As Integer = pFormController.CurrentOutputWoodPallet.WoodPalletItems.Count - 1 To 0 Step -1
          mNewWoodPalletItem = pFormController.CurrentOutputWoodPallet.WoodPalletItems(mindex)
          If mNewWoodPalletItem.StockItemID > 0 Then
            mStockItem = mSelectedStockItems.ItemFromKey(mNewWoodPalletItem.StockItemID)

            If Not mPicker.SelectedObjects.Contains(mStockItem) Then
              pFormController.CurrentOutputWoodPallet.WoodPalletItems.Remove(mNewWoodPalletItem)
            End If
          End If
        Next

        pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)
        pFormController.SaveObjects()

        pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
        grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors


      Case ePalletOptions.Process

        Select Case pFormController.CurrentWoodWorkOrder.WorkOrderProcessOption

          Case eWorkOrderWoodProcess.Aserrio
            gvOutputWoodPaleltItem.CloseEditor()
            pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)
            CheckSave(False)
            ProcessOutputAserrio()

          Case eWorkOrderWoodProcess.Clasificar

        End Select
    End Select

    RefreshSourceTabs()
    RefreshOutputTabs()
  End Sub

  Private Sub xtabSourcePallet_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtabSourcePallet.SelectedPageChanged
    Try
      If pIsActive Then
        'UpdateHouseTypePanel()
        If e.Page.Tag IsNot Nothing Then

          pnlSourcePallets.Parent = e.Page
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

  Private Sub xtabOutputWood_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtabOutputWood.SelectedPageChanged
    Try
      If pIsActive Then
        'UpdateHouseTypePanel()
        If e.Page.Tag IsNot Nothing Then

          pnlOutputWoodPallet.Parent = e.Page
          pFormController.SetCurrentOutputWoodPallet(e.Page.Tag)

        Else
          pFormController.SetCurrentOutputWoodPallet(Nothing)
        End If
      Else
        pFormController.SetCurrentOutputWoodPallet(Nothing)
      End If

      pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
      grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors
      grdOutputWoodPalletItem.RefreshDataSource()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
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
      If mloop >= pFormController.CurrentWoodWorkOrder.SourcePallets.Count - 1 Then
        xtabSourcePallet.TabPages.RemoveAt(mloop)
      End If
    Next

    'If there are no items then make page 0 invisible
    If pFormController.CurrentWoodWorkOrder.SourcePallets.Count = 0 Then
      xtabSourcePallet.TabPages(0).PageVisible = False
      If pFormController.CurrentSourceWoodPallet Is Nothing Then pFormController.CurrentSourceWoodPallet = New dmWoodPallet
    Else
      xtabSourcePallet.TabPages(0).PageVisible = True
    End If

    'Name and Add in tabs
    mPos = 0
    mCurrentPage = Nothing

    For Each mSourcePallet As dmSourcePallet In pFormController.CurrentWoodWorkOrder.SourcePallets
      mWoodPallet = pFormController.LoadWoodPalletByWoodPalletID(mSourcePallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        mWoodPallets.Add(mWoodPallet)
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
      mPage.Text = String.Format("{0}", mWP.PalletRef)

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
      pnlSourcePallets.Parent = xtabSourcePallet.TabPages(0)
    Else
      xtabSourcePallet.SelectedTabPage = mCurrentPage
      pnlSourcePallets.Parent = mCurrentPage
    End If
    'RefreshHouseTypePanel()

    pIsActive = mIsActive

  End Sub

  Private Sub RefreshOutputTabs()
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
      If pFormController.CurrentOutputWoodPallet Is Nothing Then pFormController.CurrentOutputWoodPallet = New dmWoodPallet
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

    If mWoodPallets.Count = 1 Then
      pFormController.CurrentOutputWoodPallet = mWoodPallets(0)
    End If
    For Each mWP As dmWoodPallet In mWoodPallets
      If mPos > xtabOutputWood.TabPages.Count - 1 Then
        xtabOutputWood.TabPages.Add()
      End If
      mPage = xtabOutputWood.TabPages(mPos)
      mPage.Tag = mWP
      mPage.Text = String.Format("{0}", mWP.PalletRef)

      If pFormController.CurrentOutputWoodPallet Is Nothing Then

        pFormController.CurrentOutputWoodPallet = mWP

      End If

      If mWP Is pFormController.CurrentOutputWoodPallet Then
        mCurrentPage = mPage
      End If
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

  Private Sub rgWoodPalletType_SelectedIndexChanged(sender As Object, e As EventArgs)
    pFormController.WorkOrderSourceWoodType = pTargetItemType
  End Sub

  Private Sub btnStartKiln_Click(sender As Object, e As EventArgs) Handles btnStartKiln.Click
    dteKilnStartDate.EditValue = Now
    btnStartKiln.Enabled = False
    UpdateWoodPalletRef()
    CheckSave(False)
    RefreshControls()
  End Sub

  Private Sub btnEndKiln_Click(sender As Object, e As EventArgs) Handles btnEndKiln.Click
    dteKilnEndDate.EditValue = Now
    pFormController.ProcessDryTransaction(pFormController.CurrentWoodWorkOrder.SourcePallets, eStockItemTypeTimberWood.MAS, pFormController.CurrentSourceWoodPallet.LocationID)

    pFormController.CreateSourceTransaction(pFormController.CurrentWoodWorkOrder.SourcePallets)
    pFormController.CreateOutputTransaction(pFormController.CurrentWoodWorkOrder.OutputPallets)
    btnEndKiln.Enabled = False

    CheckSave(False)
    UpdateWoodPalletRef()
    UpdateObject()
    CheckSave(False)

    RefreshSourceTabs()
    RefreshOutputTabs()

    RefreshControls()

    gvOutputWoodPaleltItem.RefreshData()

    pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
    grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors

    pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
    grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors

    gvSourceWoodPalletItem.RefreshData()
    btnEndKiln.Enabled = False
  End Sub

  Private Sub ProcessAserrio()

    pFormController.ProcessSourceAserrado(pFormController.CurrentOutputWoodPallet.LocationID, pFormController.CurrentOutputWoodPallet.WoodPalletID)


    CheckSave(False)
    UpdateWoodPalletRef()
    UpdateObject()
    CheckSave(False)

    RefreshSourceTabs()
    RefreshOutputTabs()

    RefreshControls()

    gvOutputWoodPaleltItem.RefreshData()

    pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
    grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors

    pFormController.LoadSourceWoodPallet()
    pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
    grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
    gvSourceWoodPalletItem.RefreshData()
  End Sub

  Private Sub ProcessClasificar()

    pFormController.ProcessSourceQuantity(pFormController.CurrentSourceWoodPallet.LocationID, pFormController.CurrentOutputWoodPallet.WoodPalletID)


    CheckSave(False)
    UpdateWoodPalletRef()
    UpdateObject()
    CheckSave(False)

    RefreshSourceTabs()
    RefreshOutputTabs()

    RefreshControls()

    gvOutputWoodPaleltItem.RefreshData()
    pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
    grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors

    pFormController.LoadSourceWoodPallet()
    pFormController.RefreshSourceWoodPalletItemEditors(pFormController.CurrentSourceWoodPallet)
    grdSourceWoodPalletItem.DataSource = pFormController.SourceWoodPalletItemEditors
    gvSourceWoodPalletItem.RefreshData()
  End Sub

  Private Sub bbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnClose.ItemClick
    Try
      InitiateCloseExit(True)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

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

  Private Sub btnProcessAserrado_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub xtabOutputWood_SelectedPageChanging(sender As Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles xtabOutputWood.SelectedPageChanging
    If pFormController IsNot Nothing Then
      UpdateOutputWoodPalletItems()
      pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)
    End If
  End Sub

  Private Sub repoAddDuplicated_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoOutputAddButton.ButtonClick
    Dim mSelectedWoodPalletItem As dmWoodPalletItem
    Dim mDuplicatedWoodPalletItem As dmWoodPalletItem

    mSelectedWoodPalletItem = TryCast(gvOutputWoodPaleltItem.GetFocusedRow, clsWoodPalletItemEditor).WoodPalletItem

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
      pFormController.CurrentOutputWoodPallet.WoodPalletItems.Add(mDuplicatedWoodPalletItem)
      pFormController.SaveObjects()
      UpdateOutputWoodPalletItems()
      pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)

      pFormController.RefreshOutPutWoodPalletItemEditors(pFormController.CurrentOutputWoodPallet)
      grdOutputWoodPalletItem.DataSource = pFormController.OutPutWoodPalletItemEditors
      grdOutputWoodPalletItem.RefreshDataSource()
    End If
  End Sub

  Private Sub grdOutputWoodPalletItem_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles grdOutputWoodPalletItem.EmbeddedNavigator.ButtonClick
    Dim mWoodPalletItem As dmWoodPalletItem
    Dim mOutputPallet As dmOutputPallet
    Dim mIndex As Integer
    Select Case e.Button.ButtonType
      Case NavigatorButtonType.Remove
        Try
          mWoodPalletItem = TryCast(gvOutputWoodPaleltItem.GetFocusedRow, clsWoodPalletItemEditor).WoodPalletItem
          If mWoodPalletItem IsNot Nothing Then
            mIndex = pFormController.CurrentOutputWoodPallet.WoodPalletItems.GetIndexByWoodPalletItemID(mWoodPalletItem.WoodPalletItemID)
            If mIndex > 0 Then
              pFormController.CurrentOutputWoodPallet.WoodPalletItems.RemoveAt(mIndex)
            End If
            pFormController.SaveWoodPalletDown(pFormController.CurrentOutputWoodPallet)
          End If
        Catch ex As Exception

        End Try
    End Select

  End Sub
End Class