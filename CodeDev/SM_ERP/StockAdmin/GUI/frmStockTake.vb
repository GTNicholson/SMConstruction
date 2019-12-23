Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements



Public Class frmStockTake
  ''  Private pFormController As fccStockTake
  ''  Public FormMode As eFormMode
  ''  Public ExitMode As Windows.Forms.DialogResult

  ''  Private Shared sActiveForms As Collection
  ''  Private Shared sFormIndex As Integer
  ''  Private pMySharedIndex As Integer

  ''  Private pIsActive As Boolean
  ''  Private pLoadError As Boolean
  ''  Private pForceExit As Boolean = False
  ''  Private pSpinEnter As Boolean


  ''  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByRef rUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal, ByVal vPrimaryKeyID As Integer, ByVal vFormMode As eFormMode, ByVal vStockCheckType As eStockCheckType)
  ''    Dim mfrm As frmStockTake = Nothing
  ''    Dim mCreated As Boolean = False
  ''    'Dim mTableName As String

  ''    '' Add code here if need to check if a Detail Form for this ID is already open

  ''    mfrm = GetFormIfLoaded(vPrimaryKeyID, vStockCheckType)

  ''    If mfrm Is Nothing Then
  ''      mfrm = New frmStockTake
  ''      mfrm.FormController = New fccStockTake
  ''      mfrm.FormController.DBConn = rUserSession.CreateMainDBConn
  ''      mfrm.FormController.RTISGlobal = rRTISGlobal
  ''      mfrm.FormController.StockCheckID = vPrimaryKeyID
  ''      mfrm.FormController.StockCheckTypeID = vStockCheckType
  ''      mfrm.FormMode = vFormMode
  ''      ''If vPrimaryKeyID = 0 Then
  ''      ''  mfrm.FormMode = eFormMode.eFMFormModeAdd
  ''      ''Else
  ''      ''  mfrm.FormMode = eFormMode.eFMFormModeEdit
  ''      ''End If

  ''      mfrm.MdiParent = rParentForm 'My.Application.MenuMDIForm
  ''      mfrm.Show()
  ''    Else
  ''      mfrm.Focus()
  ''    End If

  ''  End Sub


  ''  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer, ByVal vStockCheckType As eStockCheckType) As frmStockTake
  ''    Dim mfrmWanted As frmStockTake = Nothing
  ''    Dim mFound As Boolean = False
  ''    Dim mfrm As frmStockTake
  ''    'Check if exisits already
  ''    If sActiveForms Is Nothing Then sActiveForms = New Collection
  ''    For Each mfrm In sActiveForms
  ''      If mfrm.FormController.StockCheckID = vPrimaryKeyID AndAlso mfrm.FormController.StockCheckTypeID = vStockCheckType Then
  ''        mfrmWanted = mfrm
  ''        mFound = True
  ''        Exit For
  ''      End If
  ''    Next
  ''    If Not mFound Then
  ''      mfrmWanted = Nothing
  ''    End If
  ''    Return mfrmWanted
  ''  End Function

  ''  Public Sub New()

  ''    ' This call is required by the Windows Form Designer.
  ''    InitializeComponent()

  ''    ' Add any initialization after the InitializeComponent() call.
  ''    sFormIndex = sFormIndex + 1
  ''    Me.pMySharedIndex = sFormIndex
  ''    If sActiveForms Is Nothing Then sActiveForms = New Collection
  ''    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  ''  End Sub

  ''  Private Sub frmDetailForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

  ''  End Sub

  ''  Private Sub frmDetailForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
  ''    FormController.ClearObjects()
  ''    'FormController = Nothing
  ''    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  ''    Me.Dispose()
  ''  End Sub

  ''  Public Property FormController() As fccStockTake
  ''    Get
  ''      FormController = pFormController
  ''    End Get
  ''    Set(ByVal value As fccStockTake)
  ''      pFormController = value
  ''    End Set
  ''  End Property

  ''  Private Sub frmDetailForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

  ''    If Not pForceExit Then
  ''      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
  ''        e.Cancel = Not CheckSave(True)
  ''      End If
  ''    End If
  ''  End Sub

  ''  Private Sub frmDetailForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

  ''  End Sub

  ''  Private Sub frmDetailForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  ''    Dim mOK As Boolean = True
  ''    Dim mMsg As String = ""
  ''    Dim mErrorDisplayed As Boolean = False

  ''    ''Resize if required

  ''    pIsActive = False
  ''    pLoadError = False

  ''    Try
  ''      If mOK Then mOK = pFormController.LoadObject()

  ''      If mOK Then mOK = pFormController.LoadRefData()

  ''      LoadCombo()
  ''      LoadGrid()

  ''      'If mOK Then LoadExtensionControls()

  ''      If mOK Then RefreshControls()

  ''      If mOK Then SetupUserPermissions()

  ''      If mOK Then


  ''        Me.Text = "Stock Take: " & pFormController.StockCheckID
  ''        grpDetail.Text = clsEnumsConstants.GetEnumDescription(GetType(eStockCheckType), pFormController.StockCheckTypeID)
  ''        grpDetail.Width = grpItemDetail.Width

  ''        bbtnStockValuation.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

  ''        barbtnLoadDespatchedQty.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
  ''        bbtnRefreshWIPItems.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
  ''        bbtnGoodsInInvoiced.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

  ''      End If

  ''    Catch ex As Exception
  ''      mMsg = ex.Message
  ''      mOK = False
  ''      mErrorDisplayed = True
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try

  ''    If Not mOK Then
  ''      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
  ''      pLoadError = True
  ''      ExitMode = Windows.Forms.DialogResult.Abort
  ''      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

  ''    End If

  ''    pIsActive = True

  ''  End Sub

  ''  Private Sub LoadCombo()
  ''    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdStockCheckItem, gcPricingUnit, eUnit.GetInstance().ValueItems)
  ''    If Not String.IsNullOrEmpty(pFormController.StockCheck.RangeStockCodeStart) Then
  ''      gvStockCheckItem.ActiveFilterString = String.Format(" StockCode >= '{0}' AND StockCode <= '{1}'", pFormController.StockCheck.RangeStockCodeStart, pFormController.StockCheck.RangeStockCodeEnd)
  ''    End If

  ''  End Sub

  ''  Private Sub LoadGrid()
  ''    grdStockCheckItem.DataSource = pFormController.StockItemValuations
  ''  End Sub

  ''  Private Sub SetupUserPermissions()
  ''    'Dim mPermisionLevel As ePermissionCode
  ''    'mPermisionLevel = pDBConn.RTISUser.ActivityPermissions.GetActivityPermission(eActivityCode.UserConfig)


  ''  End Sub

  ''  Private Sub CloseForm() 'Needs exit mode set first
  ''    pForceExit = True
  ''    Me.Close()
  ''  End Sub

  ''  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
  ''    Dim mSaveRequired As Boolean
  ''    Dim mResponse As MsgBoxResult
  ''    Dim mRetVal As Boolean

  ''    UpdateObject()

  ''    If pFormController.IsDirty() Then
  ''      If rOption Then
  ''        mResponse = MsgBox("Changes have been made. Do you wish to save them?", MsgBoxStyle.YesNoCancel)
  ''        Select Case mResponse
  ''          Case MsgBoxResult.Yes
  ''            mSaveRequired = True
  ''            mRetVal = False
  ''            ExitMode = Windows.Forms.DialogResult.Yes
  ''          Case MsgBoxResult.No
  ''            mSaveRequired = False
  ''            mRetVal = True
  ''            ExitMode = Windows.Forms.DialogResult.No 'rNoToSave = True
  ''          Case MsgBoxResult.Cancel
  ''            mSaveRequired = False
  ''            mRetVal = False
  ''        End Select
  ''      Else
  ''        ExitMode = Windows.Forms.DialogResult.Yes
  ''        mSaveRequired = True
  ''        mRetVal = False
  ''      End If
  ''    Else
  ''      ExitMode = Windows.Forms.DialogResult.Ignore
  ''      mSaveRequired = False
  ''      mRetVal = True
  ''    End If
  ''    If mSaveRequired Then
  ''      Dim mValidate As clsValidate
  ''      mValidate = pFormController.ValidateObject
  ''      If mValidate.ValOk Then
  ''        mRetVal = pFormController.SaveObject()
  ''        'TODO - If mRetVal then AddHandler InstanceData to  BrowseTracker
  ''      Else
  ''        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
  ''        mRetVal = False
  ''      End If
  ''    End If
  ''    CheckSave = mRetVal
  ''  End Function

  ''  Private Sub RefreshControls()
  ''    ' Check User Permissions here
  ''    Dim mStartActive As Boolean = pIsActive
  ''    'Dim mIntExtender As RTIS.FormExtenderCore.intExtenderControl

  ''    pIsActive = False
  ''    If pFormController.StockCheck IsNot Nothing Then

  ''      With pFormController.StockCheck
  ''        txtStockCheckDesc.Text = .Description
  ''        dateStockCheck.DateTime = .StockCheckDate
  ''        txtRangeStockCodeEnd.Text = .RangeStockCodeEnd
  ''        txtRangeStockCodeStart.Text = .RangeStockCodeStart

  ''        datDateSystemQty.DateTime = .DateSystemQty

  ''        barbtnCommitStockTake.Enabled = clsGeneralA.IsBlankDate(.DateCommitted)

  ''        UIHelper.SetControlsEnabled(PanelControl1, clsGeneralA.IsBlankDate(.DateCommitted))
  ''        UIHelper.SetBarManagerEnabled(BarManager1, clsGeneralA.IsBlankDate(.DateCommitted))
  ''        barbtnClose.Enabled = True

  ''        RefreshSystemQtyButton()

  ''        pceStockTakeSheets.Text = String.Format("{0} Sheet(s)", .StockTakeSheets.Count.ToString())


  ''        If .DateSystemQty > DateTime.MinValue Then
  ''          btnSelectVisible.Enabled = True
  ''          btnDeselectVisible.Enabled = True
  ''          btnDeselectAll.Enabled = True
  ''          txtRangeStockCodeStart.Enabled = True
  ''          txtRangeStockCodeEnd.Enabled = True
  ''          btnAddToNextSheet.Enabled = True
  ''          btnClearRange.Enabled = True
  ''          btnClearSystemQty.Enabled = True
  ''          pceStockTakeSheets.Enabled = True

  ''          barbtnFIFOSystemValue.Enabled = True
  ''          barbtnFIFOCountedValue.Enabled = True

  ''          If Not String.IsNullOrEmpty(.RangeStockCodeStart) AndAlso Not String.IsNullOrEmpty(.RangeStockCodeEnd) Then
  ''            btnApplyRange.Enabled = True
  ''          Else
  ''            btnApplyRange.Enabled = False
  ''          End If

  ''        Else
  ''          btnSelectVisible.Enabled = False
  ''          btnDeselectVisible.Enabled = False
  ''          btnDeselectAll.Enabled = False
  ''          txtRangeStockCodeStart.Enabled = False
  ''          txtRangeStockCodeEnd.Enabled = False
  ''          btnApplyRange.Enabled = False
  ''          btnAddToNextSheet.Enabled = False
  ''          btnClearRange.Enabled = False
  ''          btnClearSystemQty.Enabled = False
  ''          pceStockTakeSheets.Enabled = False

  ''          barbtnFIFOSystemValue.Enabled = False
  ''          barbtnFIFOCountedValue.Enabled = False

  ''        End If

  ''        gvStockCheckItem.RefreshData()
  ''        gvStockTakeSheets.RefreshData()
  ''        gvStockItemValuationHistorys.RefreshData()
  ''      End With

  ''    End If

  ''    pIsActive = mStartActive
  ''  End Sub

  ''  Private Sub UpdateObject()
  ''    ''Read in from controls - update object/record
  ''    'Dim mIntExtender As RTIS.FormExtenderCore.intExtenderControl

  ''    'Make sure all grid controls etc. finished current edit
  ''    Try
  ''      Dim mActiveControl As Control = Me.ActiveControl
  ''      grpDetail.Focus()
  ''      If mActiveControl IsNot Nothing Then
  ''        mActiveControl.Focus()
  ''      End If
  ''    Catch Ex As Exception
  ''      If Debugger.IsAttached Then MsgBox("UpdateObject-Focus: " & Ex.Message)
  ''    End Try

  ''    If pFormController.StockCheck IsNot Nothing Then

  ''      With pFormController.StockCheck
  ''        .Description = txtStockCheckDesc.Text
  ''        .StockCheckDate = dateStockCheck.DateTime
  ''        .RangeStockCodeEnd = txtRangeStockCodeEnd.Text
  ''        .RangeStockCodeStart = txtRangeStockCodeStart.Text
  ''      End With

  ''    End If

  ''  End Sub

  ''  ''Private Sub ControlForceValidateExample()
  ''  ''  '' knock on effects of a property/control change - example event template
  ''  ''  Try
  ''  ''    If pIsActive Then
  ''  ''      UpdateObject()
  ''  ''
  ''  ''      ''Knock-on effects
  ''  ''
  ''  ''      RefreshControls()
  ''  ''    End If
  ''  ''  Catch ex As Exception
  ''  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''  ''  End Try
  ''  ''End Sub

  ''  Private Sub InitiateCloseExit(ByVal vWithCheck As Boolean) 'User initiated request to save - Call from buttons/menu/toolbar etc.
  ''    If vWithCheck Then
  ''      If CheckSave(True) Then 'Changed from False 20150206 !!!
  ''        CloseForm()
  ''      End If
  ''    Else
  ''      ExitMode = Windows.Forms.DialogResult.No
  ''      CloseForm()
  ''    End If

  ''  End Sub

  ''  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

  ''    If CheckSave(False) Then
  ''      CloseForm()
  ''    End If

  ''  End Sub

  ''  Private Sub barbtnSaveExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSaveExit.ItemClick
  ''    Try
  ''      InitiateSaveExit()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub barbutSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSave.ItemClick
  ''    Try
  ''      CheckSave(False)

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub barbtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnClose.ItemClick
  ''    Try
  ''      InitiateCloseExit(True)
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub


  ''  Protected Overrides Sub Finalize()
  ''    If FormController IsNot Nothing Then FormController = Nothing
  ''    MyBase.Finalize()
  ''  End Sub

  ''  Private Sub gvStockCheckItem_BeforeLeaveRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles gvStockCheckItem.BeforeLeaveRow
  ''    Try
  ''      '// Save current row
  ''      gvStockCheckItem.CloseEditor()
  ''      pFormController.SaveCurrentStockCheckItem()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub gvStockCheckItem_FocusedRowObjectChanged(sender As Object, e As FocusedRowObjectChangedEventArgs) Handles gvStockCheckItem.FocusedRowObjectChanged
  ''    Try
  ''      '// Update Current Object
  ''      If gvStockCheckItem.IsDataRow(gvStockCheckItem.FocusedRowHandle) Then
  ''        pFormController.CurrentStockCheckItem = TryCast(gvStockCheckItem.GetFocusedRow, clsStockItemValuation).StockCheckItem
  ''      Else
  ''        pFormController.CurrentStockCheckItem = Nothing
  ''      End If

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub bbtnStockValuation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnStockValuation.ItemClick
  ''    ''Try
  ''    ''  Dim mEndDateTime As DateTime
  ''    ''  UpdateObject()
  ''    ''  Select Case pFormController.Mode
  ''    ''    Case fccStockCheck.eMode.StockTake, fccStockCheck.eMode.StockValuation
  ''    ''      mEndDateTime = pFormController.StockCheck.StockCheckDate
  ''    ''    Case fccStockCheck.eMode.AdhocValuation
  ''    ''      mEndDateTime = Now.AddDays(1)
  ''    ''  End Select

  ''    ''  mEndDateTime = New DateTime(mEndDateTime.Year, mEndDateTime.Month, mEndDateTime.Day)

  ''    ''  pFormController.LoadStockValuationHistory(mEndDateTime)
  ''    ''  gvStockCheckItem.RefreshData()
  ''    ''  RefreshControls()
  ''    ''  Select Case pFormController.Mode
  ''    ''    Case fccStockCheck.eMode.StockTake, fccStockCheck.eMode.StockValuation
  ''    ''      CheckSave(False)
  ''    ''  End Select
  ''    ''Catch ex As Exception
  ''    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    ''End Try

  ''  End Sub

  ''  Private Sub repitPUStockItemValuationHistorys_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles repitPUStockItemValuationHistorys.QueryPopUp
  ''    Dim mItem As clsStockItemValuation

  ''    mItem = TryCast(gvStockCheckItem.GetFocusedRow, clsStockItemValuation)
  ''    If mItem IsNot Nothing Then
  ''      grdStockItemValuationHistorys.DataSource = mItem.StockItemValuationHistorys
  ''      gvStockItemValuationHistorys.RefreshData()
  ''    End If
  ''  End Sub

  ''  Private Sub barbtnLoadDespatchedQty_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnLoadDespatchedQty.ItemClick
  ''    Dim mPhaseIDs As New List(Of Integer)
  ''    Dim mEndDatetime As DateTime
  ''    Try

  ''      For Each mSIV As clsStockItemValuation In pFormController.StockItemValuations
  ''        If mPhaseIDs.Contains(mSIV.SalesOrderPhaseID) = False Then mPhaseIDs.Add(mSIV.SalesOrderPhaseID)
  ''      Next
  ''      UpdateObject()
  ''      Select Case pFormController.Mode
  ''        Case fccStockCheck.eMode.AdhocValuation
  ''          mEndDatetime = Now.AddDays(1)
  ''        Case fccStockCheck.eMode.StockValuation
  ''          mEndDatetime = pFormController.StockCheck.StockCheckDate
  ''      End Select

  ''      mEndDatetime = New DateTime(mEndDatetime.Year, mEndDatetime.Month, mEndDatetime.Day)

  ''      For Each mPhaseID As Integer In mPhaseIDs
  ''        pFormController.UpdateDespatchedQty(mPhaseID, mEndDatetime)
  ''      Next

  ''      gvStockCheckItem.RefreshData()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try

  ''  End Sub



  ''  Private Sub barbtnExcelExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExcelExport.ItemClick
  ''    Try
  ''      Dim mFileName As String = String.Empty
  ''      Dim mTitle As String = Me.Text
  ''      If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName, mTitle, String.Empty, "Excel |*.xls") = DialogResult.OK Then
  ''        grdStockCheckItem.ExportToXls(mFileName)
  ''      End If
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub spn_Enter(sender As Object, e As EventArgs) Handles RepositoryItemSpinEditCounted.Enter
  ''    pSpinEnter = True
  ''  End Sub

  ''  Private Sub spn_MouseUp(sender As Object, e As MouseEventArgs) Handles RepositoryItemSpinEditCounted.MouseUp
  ''    If pSpinEnter Then sender.SelectAll()
  ''    pSpinEnter = False
  ''  End Sub

  ''  Private Sub btnApplyRange_Click(sender As Object, e As EventArgs) Handles btnApplyRange.Click
  ''    Try
  ''      UpdateObject()
  ''      Dim mFilter As String = String.Empty

  ''      radGRNMode.EditValue = CByte(3)

  ''      mFilter = String.Format(" StockCode >= '{0}' AND StockCode <= '{1}'", pFormController.StockCheck.RangeStockCodeStart, pFormController.StockCheck.RangeStockCodeEnd)

  ''      If radGRNMode.EditValue = 3 Then
  ''        mFilter &= " AND gcStockTakeSheet IS NULL"
  ''      End If

  ''      gvStockCheckItem.ActiveFilterString = mFilter

  ''      gvStockCheckItem.RefreshData()

  ''      DeselectAll()
  ''      SelectVisible()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub ClearRange_Click(sender As Object, e As EventArgs) Handles btnClearRange.Click
  ''    Try
  ''      pFormController.SetIsCounted(False)
  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub radGRNMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radGRNMode.SelectedIndexChanged
  ''    Try
  ''      RefreshViewMode()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub RefreshViewMode()
  ''    Dim mFilterString As String = String.Empty
  ''    Select Case radGRNMode.EditValue
  ''      Case 1
  ''        mFilterString = "IsCounted = true"
  ''      Case 2
  ''        mFilterString = String.Empty
  ''      Case 3
  ''        mFilterString = "gcStockTakeSheet IS NULL"
  ''    End Select

  ''    gvStockCheckItem.ActiveFilterString = mFilterString
  ''  End Sub

  ''  Private Sub grpItemDetail_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles grpItemDetail.CustomButtonClick
  ''    Try
  ''      gvStockCheckItem.CloseEditor()
  ''      Select Case e.Button.Properties.Tag
  ''        Case "SelectAll"
  ''          pFormController.SelectAll()
  ''        Case "ClearSelection"
  ''          pFormController.ClearSelection()
  ''      End Select
  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Public Sub RefreshSystemQtyButton()
  ''    Dim mEnable As Boolean

  ''    If pFormController.StockCheck IsNot Nothing Then

  ''      If clsGeneralA.IsBlankDate(pFormController.StockCheck.DateCommitted) Then
  ''        mEnable = Not clsGeneralA.IsBlankDate(pFormController.StockCheck.StockCheckDate)
  ''      Else
  ''        mEnable = False
  ''      End If

  ''      barbtnRefreshSystemQty.Enabled = mEnable
  ''      bbtnStockValuation.Enabled = mEnable
  ''      barbtnCommitStockTake.Enabled = mEnable
  ''      barbtnLoadDespatchedQty.Enabled = mEnable
  ''      bbtnRefreshStockItems.Enabled = mEnable
  ''    End If

  ''  End Sub

  ''  Private Sub dateStockCheck_EditValueChanged(sender As Object, e As EventArgs) Handles dateStockCheck.EditValueChanged
  ''    If pIsActive Then
  ''      UpdateObject()
  ''      RefreshSystemQtyButton()
  ''    End If
  ''  End Sub

  ''  Private Sub btnClearSystemQty_Click(sender As Object, e As EventArgs) Handles btnClearSystemQty.Click
  ''    Try
  ''      For Each mSIV As clsStockItemValuation In pFormController.StockItemValuations
  ''        mSIV.SnapshotQty = 0
  ''      Next

  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  'Public Sub RefreshRangeButtons()
  ''  '  Dim mReadOnly As Boolean

  ''  '  If pFormController.StockCheck IsNot Nothing AndAlso clsGeneralA.IsBlankDate(pFormController.StockCheck.DateCommitted) Then

  ''  '    Select Case pFormController.StockCheckTypeID
  ''  '      Case eStockCheckType.StockTake
  ''  '        mReadOnly = False
  ''  '      Case eStockCheckType.StockValuation, eStockCheckType.WIPValuation
  ''  '        mReadOnly = True
  ''  '    End Select
  ''  '  Else
  ''  '    mReadOnly = True
  ''  '  End If

  ''  '  txtRangeStockCodeEnd.ReadOnly = mReadOnly
  ''  '  txtRangeStockCodeStart.ReadOnly = mReadOnly
  ''  '  btnApplyRange.Enabled = Not mReadOnly
  ''  '  btnClearRange.Enabled = Not mReadOnly
  ''  'End Sub

  ''  Private Sub btnSelectVisibleRows_Click(sender As Object, e As EventArgs)
  ''    Try
  ''      Dim mVisibleRows As List(Of clsStockItemValuation)
  ''      gvStockCheckItem.CloseEditor()
  ''      mVisibleRows = gvStockCheckItem.GetVisibleRows(Of clsStockItemValuation)
  ''      For Each mRow As clsStockItemValuation In mVisibleRows
  ''        mRow.IsCounted = True
  ''      Next
  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub bbtnRefreshWIPItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnRefreshWIPItems.ItemClick
  ''    Try
  ''      pFormController.ClearReceivedQtys()
  ''      Select Case pFormController.Mode
  ''        Case fccStockCheck.eMode.AdhocValuation
  ''          pFormController.LoadWIPStock(Now.Date.AddDays(1))
  ''        Case Else
  ''          pFormController.LoadWIPStock(pFormController.StockCheck.StockCheckDate)
  ''      End Select
  ''      pFormController.CreateWIPStockCheckItems()
  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub bbtnReceivedAndInvoiced_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnGoodsInInvoiced.ItemClick
  ''    Try
  ''      pFormController.ClearInvoicedQtys()
  ''      Select Case pFormController.Mode
  ''        Case fccStockCheck.eMode.AdhocValuation
  ''          pFormController.RefreshGoodsInInvoicedQty(Now.Date.AddDays(1))
  ''        Case Else
  ''          pFormController.RefreshGoodsInInvoicedQty(pFormController.StockCheck.StockCheckDate)
  ''      End Select
  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try

  ''  End Sub

  ''  Private Sub bbtnRefreshStockItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnRefreshStockItems.ItemClick
  ''    Try
  ''      pFormController.AddDefaultItemsNonWIP()

  ''      LoadCombo()

  ''      LoadGrid()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub barbtnRefreshSystemQty_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnRefreshSystemQty.ItemClick
  ''    Try
  ''      UpdateObject()
  ''      pFormController.UpdateSnapQty()
  ''      CheckSave(False)
  ''      gvStockCheckItem.RefreshData()
  ''      RefreshControls()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub barbtnCommitStockTake_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCommitStockTake.ItemClick
  ''    Try

  ''      UpdateObject()

  ''      Dim mCheckCommit As Boolean = CheckCommitPrompt()

  ''      If mCheckCommit Then
  ''        Dim mCount As Integer = 0

  ''        mCount = pFormController.CommitStockCheck()

  ''        MsgBox(mCount & " items updated!")
  ''        gvStockCheckItem.RefreshData()
  ''      End If

  ''      RefreshControls()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub


  ''  Private Function CheckCommitPrompt() As Boolean
  ''    Dim mOk As Boolean = False

  ''    Try
  ''      Dim mMsg As String = String.Empty
  ''      Dim mDict As New Dictionary(Of String, Integer)

  ''      For Each mStockItemVal As clsStockItemValuation In pFormController.StockItemValuations

  ''        If mStockItemVal.IsCounted Then
  ''          Dim mDesc As String = String.Empty

  ''          mDesc = mStockItemVal.StockCategoryDesc

  ''          If Not String.IsNullOrEmpty(mStockItemVal.StockItemTypeDesc) Then
  ''            mDesc &= " - " & mStockItemVal.StockItemTypeDesc
  ''          End If

  ''          If Not mDict.ContainsKey(mDesc) Then
  ''            mDict.Add(mDesc, 0)
  ''          End If

  ''          mDict(mDesc) += 1

  ''        End If

  ''      Next

  ''      mMsg &= "Commit the following categories?" & vbCrLf

  ''      For Each mKeyVal As KeyValuePair(Of String, Integer) In mDict

  ''        mMsg &= String.Format("{0}{1}: {2}", vbCrLf, mKeyVal.Key, mKeyVal.Value.ToString("#"))

  ''      Next


  ''      If MsgBox(mMsg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
  ''        mOk = True
  ''      End If

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try


  ''    Return mOk
  ''  End Function


  ''  Private Function CheckAddToSheetPrompt() As Boolean
  ''    Dim mOk As Boolean = False

  ''    Try
  ''      Dim mMsg As String = String.Empty
  ''      Dim mDict As New Dictionary(Of String, Integer)

  ''      Dim mSelectedRows As New colStockItemValuations

  ''      mSelectedRows = pFormController.StockItemValuations.GetSelectedItems

  ''      For Each mStockItemVal As clsStockItemValuation In mSelectedRows
  ''        Dim mDesc As String = String.Empty

  ''        mDesc = mStockItemVal.StockCategoryDesc

  ''        If Not String.IsNullOrEmpty(mStockItemVal.StockItemTypeDesc) Then
  ''          mDesc &= " - " & mStockItemVal.StockItemTypeDesc
  ''        End If

  ''        If Not mDict.ContainsKey(mDesc) Then
  ''          mDict.Add(mDesc, 0)
  ''        End If

  ''        mDict(mDesc) += 1
  ''      Next

  ''      mMsg &= "Add the following to a sheet?" & vbCrLf

  ''      For Each mKeyVal As KeyValuePair(Of String, Integer) In mDict

  ''        mMsg &= String.Format("{0}{1}: {2}", vbCrLf, mKeyVal.Key, mKeyVal.Value.ToString("#"))

  ''      Next


  ''      If MsgBox(mMsg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
  ''        mOk = True
  ''      End If

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try


  ''    Return mOk
  ''  End Function


  ''  Private Sub barbtnPrintCountSheet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnPrintCountSheet.ItemClick
  ''    Try
  ''      Dim mReport As New DevExpress.XtraReports.UI.XtraReport
  ''      Dim mRepPrintTool As DevExpress.XtraReports.UI.ReportPrintTool

  ''      UpdateObject()
  ''      gvStockCheckItem.CloseEditor()

  ''      For Each mSheet As dmStockTakeSheet In pFormController.StockCheck.StockTakeSheets
  ''        Dim mSheetReport As DevExpress.XtraReports.UI.XtraReport = Nothing
  ''        Dim mValuations As colStockItemValuations
  ''        Dim mSheetText As String = String.Empty

  ''        mSheetText = String.Format("Sheet {0}", mSheet.SheetNo.ToString())

  ''        mValuations = pFormController.GetRowsForSheet(mSheet.StockTakeSheetID)

  ''        mSheetReport = repStockCheck.GetReportSingle(pFormController.StockCheck, mSheetText)
  ''        mSheetReport.DataSource = mValuations.OrderByStockCode
  ''        mSheetReport.CreateDocument()

  ''        mReport.Pages.AddRange(mSheetReport.Pages)
  ''      Next

  ''      mRepPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(mReport)
  ''      mRepPrintTool.ShowPreviewDialog()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub gvStockCheckItem_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockCheckItem.CustomUnboundColumnData
  ''    Try

  ''      Dim mRow As clsStockItemValuation = e.Row

  ''      If mRow IsNot Nothing Then
  ''        If e.IsGetData Then

  ''          Select Case e.Column.Name
  ''            Case gcDiscrepency.Name

  ''              If mRow.IsCounted Then
  ''                e.Value = (mRow.CountedQty - mRow.SnapshotQty)
  ''              Else
  ''                e.Value = 0
  ''              End If


  ''            Case gcCountedQty.Name

  ''              If mRow.IsCounted Then
  ''                e.Value = mRow.CountedQty
  ''              Else
  ''                e.Value = Nothing
  ''              End If

  ''            Case gcStockTakeSheet.Name

  ''              If mRow.StockCheckItem IsNot Nothing AndAlso mRow.StockCheckItem.StockTakeSheetID > 0 Then
  ''                Dim mSheet As dmStockTakeSheet = pFormController.StockCheck.StockTakeSheets.ItemFromKey(mRow.StockCheckItem.StockTakeSheetID)

  ''                If mSheet IsNot Nothing Then
  ''                  e.Value = String.Format("Sheet {0}", mSheet.SheetNo.ToString("D3"))
  ''                Else
  ''                  e.Value = String.Empty
  ''                End If

  ''              End If


  ''          End Select


  ''        End If

  ''        If e.IsSetData Then

  ''          Select Case e.Column.Name
  ''            Case gcCountedQty.Name

  ''              mRow.CountedQty = e.Value

  ''              If e.Value IsNot Nothing Then
  ''                mRow.IsCounted = True
  ''              Else
  ''                mRow.IsCounted = False
  ''              End If
  ''          End Select

  ''        End If
  ''      End If



  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub btnAddToNextSheet_Click(sender As Object, e As EventArgs) Handles btnAddToNextSheet.Click
  ''    Try

  ''      frmStockTakeSheets.OpenAsModal(pFormController.DBConn, pFormController.StockCheck, pFormController.StockItemValuations)

  ''      RefreshControls()

  ''      gvStockCheckItem.RefreshData()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub pceStockTakeSheets_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pceStockTakeSheets.QueryPopUp
  ''    Try
  ''      grdStockTakeSheets.DataSource = pFormController.StockCheck.StockTakeSheets
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub gvStockTakeSheets_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockTakeSheets.CustomUnboundColumnData
  ''    Try
  ''      Dim mRow As dmStockTakeSheet = e.Row

  ''      If mRow IsNot Nothing Then

  ''        If e.IsGetData Then

  ''          If e.Column.Name = gcNoOfItems.Name Then
  ''            e.Value = pFormController.CountItemsForSheet(mRow.StockTakeSheetID)
  ''          End If

  ''        End If

  ''      End If

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub btnSelectVisible_Click(sender As Object, e As EventArgs) Handles btnSelectVisible.Click
  ''    Try
  ''      SelectVisible()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub SelectVisible()
  ''    Dim mVisibleRows As List(Of clsStockItemValuation)

  ''    mVisibleRows = gvStockCheckItem.GetVisibleRows(Of clsStockItemValuation)

  ''    For Each mItem As clsStockItemValuation In mVisibleRows
  ''      mItem.TempSelected = True
  ''    Next

  ''    gvStockCheckItem.RefreshData()
  ''  End Sub

  ''  Private Sub btnDeselectVisible_Click(sender As Object, e As EventArgs) Handles btnDeselectVisible.Click
  ''    Try
  ''      Dim mVisibleRows As List(Of clsStockItemValuation)

  ''      mVisibleRows = gvStockCheckItem.GetVisibleRows(Of clsStockItemValuation)

  ''      For Each mItem As clsStockItemValuation In mVisibleRows
  ''        mItem.TempSelected = False
  ''      Next

  ''      gvStockCheckItem.RefreshData()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub btnDeselectAll_Click(sender As Object, e As EventArgs) Handles btnDeselectAll.Click
  ''    Try
  ''      DeselectAll()
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub DeselectAll()
  ''    For Each mItem As clsStockItemValuation In pFormController.StockItemValuations
  ''      mItem.TempSelected = False
  ''    Next

  ''    gvStockCheckItem.RefreshData()
  ''  End Sub

  ''  Private Sub repbtnViewSheet_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repbtnViewSheet.ButtonClick
  ''    Try
  ''      Dim mRow As dmStockTakeSheet = gvStockTakeSheets.GetFocusedRow

  ''      If mRow IsNot Nothing Then
  ''        Dim mFilter As String = String.Empty

  ''        mFilter = String.Format("gcStockTakeSheet = 'Sheet {0}'", mRow.SheetNo.ToString("D3"))

  ''        gvStockCheckItem.ActiveFilterString = mFilter
  ''      End If

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub txtRangeStockCodeStart_EditValueChanged(sender As Object, e As EventArgs) Handles txtRangeStockCodeStart.EditValueChanged
  ''    Try
  ''      If pIsActive Then
  ''        UpdateObject()
  ''        RefreshControls()
  ''      End If
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub txtRangeStockCodeEnd_EditValueChanged(sender As Object, e As EventArgs) Handles txtRangeStockCodeEnd.EditValueChanged
  ''    Try
  ''      If pIsActive Then
  ''        UpdateObject()
  ''        RefreshControls()
  ''      End If
  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub gvStockCheckItem_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles gvStockCheckItem.ShowingEditor
  ''    Try

  ''      Dim mColumn As DevExpress.XtraGrid.Columns.GridColumn = gvStockCheckItem.FocusedColumn

  ''      If mColumn.Name = gcCountedQty.Name Or mColumn.Name = gcIsCounted.Name Then
  ''        Dim mRow As clsStockItemValuation = gvStockCheckItem.GetFocusedRow

  ''        If mRow IsNot Nothing Then

  ''          If mRow.StockCheckItem.StockTakeSheetID > 0 Then
  ''            Dim mSheet As dmStockTakeSheet = pFormController.StockCheck.StockTakeSheets.ItemFromKey(mRow.StockCheckItem.StockTakeSheetID)

  ''            If mSheet IsNot Nothing Then

  ''              If mSheet.DateProcessed > DateTime.MinValue Then
  ''                e.Cancel = True
  ''              End If

  ''            End If

  ''          End If

  ''        End If
  ''      End If

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub btnAutoCreateSheets_Click(sender As Object, e As EventArgs) Handles btnAutoCreateSheets.Click
  ''    Try
  ''      Dim mContinue As Boolean = True

  ''      If pFormController.StockCheck.StockTakeSheets.Count > 0 Then

  ''        If MsgBox("This will clear existing sheets, would you like to continue?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
  ''          mContinue = False
  ''        End If

  ''      End If

  ''      If mContinue Then

  ''        pFormController.AutoCreateSheets

  ''      End If

  ''      MsgBox(pFormController.StockCheck.StockTakeSheets.Count & " Sheets created")

  ''      gvStockCheckItem.RefreshData()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub barbtnFIFOSystemValue_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFIFOSystemValue.ItemClick
  ''    Try
  ''      Dim mEndDateTime As DateTime
  ''      UpdateObject()

  ''      mEndDateTime = pFormController.StockCheck.StockCheckDate

  ''      pFormController.LoadSystemStockValuationHistory(mEndDateTime)
  ''      gvStockCheckItem.RefreshData()
  ''      RefreshControls()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

  ''  Private Sub barbtnFIFOCountedValue_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnFIFOCountedValue.ItemClick
  ''    Try
  ''      Dim mEndDateTime As DateTime
  ''      UpdateObject()

  ''      mEndDateTime = pFormController.StockCheck.StockCheckDate

  ''      pFormController.LoadCountedStockValuationHistory(mEndDateTime)
  ''      gvStockCheckItem.RefreshData()
  ''      RefreshControls()

  ''    Catch ex As Exception
  ''      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
  ''    End Try
  ''  End Sub

End Class