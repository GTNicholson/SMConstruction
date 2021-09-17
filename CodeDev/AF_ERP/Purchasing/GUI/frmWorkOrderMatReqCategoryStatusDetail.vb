Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmWorkOrderMatReqCategoryStatusDetail
  Private pFormController As fccWorkOrderPhaseMatReqCategoryStatusDetail

  Public ExitMode As Windows.Forms.DialogResult

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pOptionForm As eForm

  Public Enum eForm
    ReadWriteForm = 1
    ReadOnlyForm = 2
  End Enum



  Public Shared Sub OpenForm(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rWorkOrderMatReqCategoryStatus As dmWorkOrderMatReqCategoryStatus, ByVal vWorkOrderID As Integer, ByVal vCategory As eStockItemCategory, ByVal vOptionForm As eForm)
    Dim mfrm As frmWorkOrderMatReqCategoryStatusDetail

    mfrm = New frmWorkOrderMatReqCategoryStatusDetail
    mfrm.StartPosition = FormStartPosition.CenterParent
    mfrm.pOptionForm = vOptionForm
    mfrm.pFormController = New fccWorkOrderPhaseMatReqCategoryStatusDetail(rDBConn, rWorkOrderMatReqCategoryStatus, vWorkOrderID, vCategory)
    mfrm.ShowDialog(rParentForm)


  End Sub

  Private Sub frmWorkOrderMatReqCategoryStatusDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    pIsActive = False
    pLoadError = False

    Try

      pFormController.LoadObjects()

      LoadCombo()

      'If mOK Then LoadExtensionControls()

      grdPOs.DataSource = pFormController.PurchaseOrders

      grdMaterialRequirements.DataSource = pFormController.MaterialRequirementInfos

      If mOK Then RefreshControls()

      If mOK Then SetupUserPermissions()

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

  Public Sub LoadCombo()

    clsDEControlLoading.LoadGridLookUpEditiVI(grdPOs, gcStatus, clsEnumsConstants.EnumToVIs(GetType(ePurchaseOrderDueDateStatus)))
    'clsDEControlLoading.LoadGridLookUpEditiVI(grdPOs, gcCostCategory, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.SalesOrderCostCategory))

  End Sub

  Public Sub RefreshControls()
    Try
      pFormController.RefresStatusInfo()
      lblTitle.Text = String.Format("Req. de Materiales de {0} para {1} - {2} ", RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), pFormController.MaterialCategory), pFormController.WorkOrder.WorkOrderNo, pFormController.WorkOrder.Description)
      radgrpPUStatusSetting.EditValue = CInt(pFormController.WorkOrderMatReqCategoryStatus.Status)

      lblPickStatus.Text = "Estado de Recepción : " & RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStatusNonePartComplete), CType(pFormController.WorkOrderMatReqCategoryStatus.PickStatus, eStatusNonePartComplete))

      '' rgrpPickStatus.EditValue = CInt(pController.WorkOrderMatReqCategoryStatus.PickStatus)

      If RTIS.CommonVB.clsGeneralA.IsBlankDate(pFormController.WorkOrderMatReqCategoryStatus.LastDate) Then
        txtLastDate.Text = ""
      Else
        txtLastDate.Text = pFormController.WorkOrderMatReqCategoryStatus.LastDate.ToString("dd/MM/yyyy")
      End If
      txtNotes.Text = pFormController.WorkOrderMatReqCategoryStatus.Notes
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try


  End Sub

  Public Sub SetupUserPermissions()

    Select Case pOptionForm
      Case eForm.ReadOnlyForm
        radgrpPUStatusSetting.ReadOnly = True
        gvMaterialRequirements.OptionsBehavior.ReadOnly = True
        grpRelatedPurchaseOrders.CustomHeaderButtons.Item(0).Properties.Enabled = False
        grpRelatedPurchaseOrders.CustomHeaderButtons.Item(1).Properties.Enabled = False
        grpRelatedPurchaseOrders.CustomHeaderButtons.Item(2).Properties.Enabled = False
        gvPOs.OptionsBehavior.ReadOnly = True
      Case eForm.ReadWriteForm
        radgrpPUStatusSetting.ReadOnly = False
        gvMaterialRequirements.OptionsBehavior.ReadOnly = False
        grpRelatedPurchaseOrders.CustomHeaderButtons.Item(0).Properties.Enabled = True
        grpRelatedPurchaseOrders.CustomHeaderButtons.Item(1).Properties.Enabled = True
        grpRelatedPurchaseOrders.CustomHeaderButtons.Item(2).Properties.Enabled = True
        gvPOs.OptionsBehavior.ReadOnly = False
    End Select

  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    Me.Close()
  End Sub

  Private Sub UpdateObjects()
    Try
      gvPOs.CloseEditor()
      gvPOs.UpdateCurrentRow()

      With pFormController.WorkOrderMatReqCategoryStatus
        ''.PickStatus = rgrpPickStatus.EditValue
        .Notes = txtNotes.Text
      End With
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub frmWorkOrderMatReqCategoryStatusDetail_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    UpdateObjects()
    'RefreshControls()
    pFormController.SaveObjects()
  End Sub

  Private Sub grpRelatedPurchaseOrders_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpRelatedPurchaseOrders.CustomButtonClick
    Dim mPONewID As Integer
    Dim mDialogResult As DialogResult
    Dim mPurchaseOrderID As Integer
    Dim mPOICount As Integer
    Dim mPODeliveryCounts As Integer
    Dim mPOSelected As dmPurchaseOrder
    Try

      Select Case e.Button.Properties.Tag

        Case 1
          'Add a new Purchase Order
          mPONewID = pFormController.AddNewPurchaseOrder()


          'frmPurchaseOrder.OpenFormAsModal(Me, pFormController.DBConn, AppRTISGlobal.GetInstance, mPONewID, eFormMode.eFMFormModeAdd)
          pFormController.LoadPurchaseOrders()
          grdPOs.DataSource = pFormController.PurchaseOrders
          gvPOs.RefreshData()




        Case 2 ''Receive

          mPOSelected = TryCast(gvPOs.GetFocusedRow, dmPurchaseOrder)

          If mPOSelected IsNot Nothing Then
            mPurchaseOrderID = mPOSelected.PurchaseOrderID

            mPOICount = pFormController.GetPOICount(mPurchaseOrderID)
            mPODeliveryCounts = pFormController.GetPODCount(mPurchaseOrderID)

            If mPOICount > 0 Then

              If mPODeliveryCounts >= 1 Then
                mDialogResult = MessageBox.Show("Esta O.C. ya tiene una recepción, ¿Desea agregar otra recepción?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If mDialogResult = DialogResult.Yes Then
                  frmPODelivery.OpenAsModal(Me, pFormController.DBConn, AppRTISGlobal.GetInstance, 0, mPurchaseOrderID, eFormMode.eFMFormModeAdd)
                End If
              Else

                frmPODelivery.OpenAsModal(Me, pFormController.DBConn, AppRTISGlobal.GetInstance, 0, mPurchaseOrderID, eFormMode.eFMFormModeAdd)

              End If

            Else
              MessageBox.Show("Esta O.C. no tiene ningún ítem para ser recibido")
            End If

          End If

        Case 3 ''Delete
          Dim mPO As dmPurchaseOrder
          mPO = TryCast(gvPOs.GetFocusedRow, dmPurchaseOrder)
          If mPO IsNot Nothing Then
            If MsgBox("Eliminar O.C.?", vbYesNo) = vbYes Then
              pFormController.RemovePurchaseOrder(mPO)
              pFormController.LoadPurchaseOrders()
              grdPOs.DataSource = pFormController.PurchaseOrders
              gvPOs.RefreshData()

            End If
          End If

      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw


    End Try
  End Sub

  Private Sub gvPOs_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvPOs.CustomUnboundColumnData
    Dim mPurchaseOrder As dmPurchaseOrder
    Dim mIndex As Integer
    Dim mSupplierID As Integer
    Dim mSupplierName As String

    Try


      mPurchaseOrder = CType(e.Row, dmPurchaseOrder)
      Select Case e.Column.FieldName
        Case "UBSupplierID"
          If e.IsGetData Then
            If mPurchaseOrder IsNot Nothing Then
              mSupplierID = mPurchaseOrder.SupplierID
              mIndex = pFormController.Suppliers.IndexFromKey(mSupplierID)
              If mIndex > -1 Then
                mSupplierName = pFormController.Suppliers(mIndex).CompanyName
              Else
                mSupplierName = ""
              End If
              e.Value = mSupplierName
            Else
              e.Value = ""
            End If
          End If

      End Select

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repbtnSupplierPicker_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repbtnSupplierPicker.ButtonClick
    Dim mPickerSupplier As clsPickerSupplier
    Dim mSelectedSupplier As dmSupplier
    Dim mPurchaseOrder As dmPurchaseOrder

    Try

      UpdateObjects()

      mPurchaseOrder = gvPOs.GetRow(gvPOs.FocusedRowHandle)

      If mPurchaseOrder IsNot Nothing Then

        mPickerSupplier = New clsPickerSupplier(pFormController.Suppliers, pFormController.DBConn)

        mSelectedSupplier = frmPickSupplier.OpenPickerSingle(mPickerSupplier)

        If mSelectedSupplier IsNot Nothing Then
          mPurchaseOrder.SupplierID = mSelectedSupplier.SupplierID

          pFormController.LoadSuppliers()

          RefreshControls()
        End If

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnExportMG_Click(sender As Object, e As EventArgs) Handles btnExportMG.Click
    Try
      Dim mFilename As String
      clsGeneralA.GetSaveFileName(mFilename, "", "", "Excel Files|*.xlsx")
      If String.IsNullOrEmpty(mFilename) = False Then
        grdMaterialRequirements.ExportToXlsx(mFilename)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvPOs_ShownEditor(sender As Object, e As EventArgs) Handles gvPOs.ShownEditor

    Try

      Dim mView As DevExpress.XtraGrid.Views.Base.ColumnView = CType(sender, DevExpress.XtraGrid.Views.Base.ColumnView)

      ''If TypeOf (mView.ActiveEditor) Is DevExpress.XtraEditors.MemoExEdit Then
      ''  Dim mEdit As DevExpress.XtraEditors.MemoExEdit = CType(mView.ActiveEditor, DevExpress.XtraEditors.MemoExEdit)
      ''  AddHandler mEdit.Popup, AddressOf EditTopMost_Popup
      ''ElseIf TypeOf (mView.ActiveEditor) Is DevExpress.XtraEditors.LookUpEdit Then
      ''  Dim mEdit As DevExpress.XtraEditors.LookUpEdit = CType(mView.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
      ''  AddHandler mEdit.Popup, AddressOf EditTopMost_Popup
      ''ElseIf TypeOf (mView.ActiveEditor) Is DevExpress.XtraEditors.DateEdit Then
      ''  Dim mEdit As DevExpress.XtraEditors.DateEdit = CType(mView.ActiveEditor, DevExpress.XtraEditors.DateEdit)
      ''  AddHandler mEdit.Popup, AddressOf EditTopMost_Popup
      ''End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub EditTopMost_Popup(ByVal sender As Object, ByVal e As EventArgs)
    Dim mIPopupControl As DevExpress.Utils.Win.IPopupControl
    Dim mPopupWindow As Form

    Try

      ''mIPopupControl = TryCast(sender, DevExpress.Utils.Win.IPopupControl)

      ''If mIPopupControl IsNot Nothing Then
      ''  mPopupWindow = TryCast(mIPopupControl.PopupWindow, Form)
      ''End If

      ''If mPopupWindow IsNot Nothing AndAlso mPopupWindow.TopMost = False Then
      ''  mPopupWindow.TopMost = True
      ''End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Private Sub radgrpPUStatusSetting_EditValueChanged(sender As Object, e As EventArgs) Handles radgrpPUStatusSetting.EditValueChanged
    Try
      If pIsActive Then
        pFormController.SetWorkOrderMatCatStatus(radgrpPUStatusSetting.EditValue)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub


  Private Sub gvMaterialRequirements_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvMaterialRequirements.CustomDrawCell
    If gvMaterialRequirements.IsDataRow(e.RowHandle) Then

      If (e.Column.Name = gcComments.Name) Then
        Dim mFocusedRow As clsMaterialRequirementInfo
        Dim mCurrentRow As clsMaterialRequirementInfo
        mFocusedRow = TryCast(gvMaterialRequirements.GetFocusedRow, clsMaterialRequirementInfo)
        mCurrentRow = TryCast(gvMaterialRequirements.GetRow(e.RowHandle), clsMaterialRequirementInfo)
        If mCurrentRow IsNot Nothing AndAlso mFocusedRow IsNot Nothing Then
          If gvMaterialRequirements.FocusedRowHandle <> e.RowHandle Then

            If e.Column.Name = gcComments.Name Then
              If mCurrentRow.Comments <> String.Empty Then
                e.Appearance.BackColor = Color.LightYellow
                e.Appearance.ForeColor = Color.Black
              Else
                e.Appearance.BackColor = Color.Empty
              End If

            End If

          End If



        End If


      End If
    End If
  End Sub

End Class