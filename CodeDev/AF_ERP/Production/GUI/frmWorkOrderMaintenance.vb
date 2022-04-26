Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmWorkOrderMaintenance
  Private pFormController As fccWorkOrderMaintenance
  Private pIsActive As Boolean
  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Public ExitMode As Windows.Forms.DialogResult
  Private pForceExit As Boolean = False


  Private Sub frmWorkOrderMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False
    Dim mProductInfo As New clsProductBaseInfo

    pIsActive = False

    Try

      pFormController.LoadObjects()

      LoadCombos()

      RefreshControls()


      grdMaitenanceItems.DataSource = pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems

      If mOK Then RefreshControls()

      ''If mOK Then SetupUserPermissions()
    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True


  End Sub
  Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)
  End Sub

  Private Sub LoadCombos()
    Dim mVIs As colValueItems



    clsDEControlLoading.FillDEComboVI(cboWorkCentreID, clsEnumsConstants.EnumToVIs(GetType(eWorkCentre)))

    clsDEControlLoading.FillDEComboVI(cboMaintenanceType, clsEnumsConstants.EnumToVIs(GetType(eMaintenanceType)))

    clsDEControlLoading.FillDEComboVI(cboPriority, clsEnumsConstants.EnumToVIs(GetType(eMaintenancePriority)))

    mVIs = New colValueItems
    For Each mEmployee As RTIS.ERPCore.dmEmployee In TryCast(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Employees), RTIS.ERPCore.colEmployees)

      If mEmployee.MainRoleID = eEmployeeRole.Production Then
        Dim mValueItem As New clsValueItem
        mValueItem.DisplayValue = mEmployee.FullName
        mValueItem.ItemValue = mEmployee.EmployeeID
        mVIs.Add(mValueItem)
      End If

    Next
    clsDEControlLoading.FillDEComboVI(cboEmployeeID, mVIs)
    clsDEControlLoading.FillDEComboVI(cboStatus, clsEnumsConstants.EnumToVIs(GetType(eMaintenanceWorkOrderStatus)))



  End Sub
  Public Shared Sub OpenFormMDI(ByVal vPrimaryKeyID As Integer, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rParentMDI As frmTabbedMDI)
    Dim mfrm As frmWorkOrderMaintenance = Nothing


    If vPrimaryKeyID <> 0 Then
      mfrm = GetFormIfLoaded(vPrimaryKeyID)
    End If
    If mfrm Is Nothing Then
      mfrm = New frmWorkOrderMaintenance
      mfrm.pFormController = New fccWorkOrderMaintenance(rDBConn)
      mfrm.pFormController.PrimaryKeyID = vPrimaryKeyID
      mfrm.MdiParent = rParentMDI
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub
  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmWorkOrderMaintenance
    Dim mfrmWanted As frmWorkOrderMaintenance = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmWorkOrderMaintenance
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
  Private Sub RefreshControls()
    Dim mIsActive As Boolean
    mIsActive = pIsActive

    If pFormController.MaintenanceWorkOrder IsNot Nothing Then
      With pFormController.MaintenanceWorkOrder
        If .MaintenanceWorkOrderNo = "" Then
          Me.Text = "Nueva O.T. de Mantenimiento"
        Else
          Me.Text = "O.T. " & .MaintenanceWorkOrderNo
        End If

        btnMaintOrderNo.Text = .MaintenanceWorkOrderNo
        txtDescription.Text = .Description
        clsDEControlLoading.SetDECombo(cboWorkCentreID, .WorkCentreID)
        clsDEControlLoading.SetDECombo(cboMaintenanceType, .MaintenanceType)

        btnEquipmentID.Text = .EquipmentID
        clsDEControlLoading.SetDECombo(cboEmployeeID, .EmployeeID)
        clsDEControlLoading.SetDECombo(cboPriority, .Priority)
        dtePlannedDate.DateTime = .PlannedDate
        clsDEControlLoading.SetDECombo(cboStatus, .Status)
        txtDuration.EditValue = .Duration
        txtNotes.Text = .Notes
        btnMaintenanceWorkOrderDocument.Text = .MaintenanceWorkOrderDocument

        btnEquipmentID.Text = .Machinery.Description

      End With

    End If

    pIsActive = mIsActive
  End Sub



  Private Sub UpdateObject()


    If pFormController.MaintenanceWorkOrder IsNot Nothing Then
      With pFormController.MaintenanceWorkOrder

        .Description = txtDescription.Text
        .WorkCentreID = clsDEControlLoading.GetDEComboValue(cboWorkCentreID)
        .MaintenanceType = clsDEControlLoading.GetDEComboValue(cboMaintenanceType)
        .EmployeeID = clsDEControlLoading.GetDEComboValue(cboEmployeeID)
        .Priority = clsDEControlLoading.GetDEComboValue(cboPriority)
        .PlannedDate = dtePlannedDate.DateTime
        .Status = clsDEControlLoading.GetDEComboValue(cboStatus)
        .Duration = txtDuration.EditValue
        .Notes = txtNotes.Text
        .MaintenanceWorkOrderDocument = btnMaintenanceWorkOrderDocument.Text
      End With

    End If

  End Sub


  Private Sub btnMaintOrderNo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnMaintOrderNo.ButtonClick
    Dim mNewWO As String


    Try
      Select Case e.Button.Kind
        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Undo

          UpdateObject()
          mNewWO = pFormController.MaintenanceWorkOrder.MaintenanceWorkOrderNo
          mNewWO = InputBox("Modificar el Numero de OT",, mNewWO)
          If mNewWO <> "" Then
            pFormController.MaintenanceWorkOrder.MaintenanceWorkOrderNo = mNewWO
          End If
          pFormController.SaveObjects()
          RefreshControls()

        Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
          If pFormController.MaintenanceWorkOrder.MaintenanceWorkOrderNo = "" Then
            pFormController.GetNextWONumber()
          End If

          RefreshControls()
      End Select
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

  Private Sub bbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnSave.ItemClick
    Try
      UpdateObject()
      CheckSave(False)
      RefreshControls()
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

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
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

  Private Sub frmWorkOrderMaintenance_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub
  Private Sub frmWorkOrderDetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    ''FormController.ClearObjects()
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Private Sub grpMaintenanceItems_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles grpMaintenanceItems.CustomButtonClick

    Dim mSelectedItem As dmStockItem
    Dim mPOItem As dmMaintenanceWorkOrderItem

    Dim mTest As New colPOItemEditors

    Dim mPicker As clsPickerStockItem
    Dim mStockItems As New colStockItems
    Dim mStockItem As dmStockItem
    Dim mSelectedStockItems As colStockItems
    Dim mExchangeRate As Decimal = 0
    Try
      UpdateObject()
      gvMaintenanceItems.CloseEditor()

      Select Case e.Button.Properties.Tag
        Case "AddItems"


          For Each mItem As KeyValuePair(Of Integer, RTIS.ERPStock.intStockItemDef) In AppRTISGlobal.GetInstance.StockItemRegistry.StockItemsDict

            If TryCast(mItem.Value, dmStockItem).Inactive = False Then
              mStockItems.Add(mItem.Value)
            End If

          Next



          mPicker = New clsPickerStockItem(mStockItems, pFormController.DBConn, AppRTISGlobal.GetInstance)

          For Each mPOItem In pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems
            If mPOItem.StockItemID > 0 Then
              mStockItem = mStockItems.ItemFromKey(mPOItem.StockItemID)

              If Not mPicker.SelectedObjects.Contains(mStockItem) Then

                mPicker.SelectedObjects.Add(mStockItem)

              End If
            End If
          Next

          frmPickerStockItem.OpenPickerMulti(mPicker, True, pFormController.DBConn, AppRTISGlobal.GetInstance, False, -1)
          For Each mSelectedItem In mPicker.SelectedObjects
            If mSelectedItem IsNot Nothing Then
              mPOItem = pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems.ItemByStockItemID(mSelectedItem.StockItemID)
              If mPOItem Is Nothing Then
                mPOItem = New dmMaintenanceWorkOrderItem
                mPOItem.StockItemID = mSelectedItem.StockItemID
                mPOItem.Quantity = 1
                mPOItem.UnitCost = mSelectedItem.AverageCost


                pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems.Add(mPOItem)
              End If
            End If
          Next

          mSelectedStockItems = New colStockItems(mPicker.SelectedObjects)

          For mindex As Integer = pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems.Count - 1 To 0 Step -1
            mPOItem = pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems(mindex)
            If mPOItem.StockItemID > 0 Then
              mStockItem = mSelectedStockItems.ItemFromKey(mPOItem.StockItemID)

              If Not mPicker.SelectedObjects.Contains(mStockItem) Then
                pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems.Remove(mPOItem)
              End If
            End If
          Next


          pFormController.SaveObjects()
          grdMaitenanceItems.DataSource = pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems

        Case "DeleteItem"

          mPOItem = gvMaintenanceItems.GetFocusedRow
          If mPOItem IsNot Nothing Then
            If MsgBox("¿Está seguro que desea eliminar este ítem de la Orden de Mantenmiento?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Artículo") Then
              UpdateObject()

              pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems.Remove(mPOItem)
              grdMaitenanceItems.DataSource = pFormController.MaintenanceWorkOrder.MaitenanceWorkOrderItems

            End If
          End If



      End Select



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

  End Sub

  Private Sub btnEquipmentID_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnEquipmentID.ButtonClick
    Try
      Select Case e.Button.Kind
        Case ButtonPredefines.Down
          Dim mMachineryPicker As clsPickerMachinery
          Dim mMachinery As dmMachinery
          Dim mListMachinerys As colMachinerys = TryCast(AppRTISGlobal.GetInstance.RefLists.RefIList(appRefLists.Machinery), colMachinerys)

          If mListMachinerys IsNot Nothing Then
            UpdateObject()
            mMachineryPicker = New clsPickerMachinery(mListMachinerys, pFormController.DBConn)
            mMachinery = frmPickerMachinery.OpenPickerSingle(mMachineryPicker)
            If mMachinery IsNot Nothing Then
              pFormController.MaintenanceWorkOrder.EquipmentID = mMachinery.MachineryID
              pFormController.MaintenanceWorkOrder.Machinery = mMachinery
              pFormController.ReloadMachinery()
            End If
            RefreshControls()

          End If
      End Select

      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnMaintenanceWorkOrderDocument_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnMaintenanceWorkOrderDocument.ButtonClick
    Dim mRep As repWorkOrderMaintenanceDoc
    Dim mDirectory As String = ""
    Dim mFileName As String = ""
    Dim mExportFilename As String = ""

    Try
      UpdateObject()

      mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.WorkOrderMaintenance)
      If System.IO.Directory.Exists(mDirectory) = False Then
        System.IO.Directory.CreateDirectory(mDirectory)
      End If


      mFileName = String.Format("WorkOrderMaintenance_{0}_{1}.pdf", pFormController.MaintenanceWorkOrder.MaintenanceWorkOrderNo, "-" & pFormController.MaintenanceWorkOrder.MaintenanceWorkOrderID)
      mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)


      mRep = repWorkOrderMaintenanceDoc.CreateReport(pFormController.MaintenanceWorkOrder)



      mRep.ExportToPdf(mExportFilename)



      pFormController.MaintenanceWorkOrder.MaintenanceWorkOrderDocument = mExportFilename

      RefreshControls()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try
  End Sub
End Class