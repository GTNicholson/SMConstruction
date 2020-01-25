Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements



Public Class frmStockTake
  Private pFormController As fccStockTake

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer

  Public FormMode As eFormMode
  Public ExitMode As Windows.Forms.DialogResult

  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False
  ''  Private pSpinEnter As Boolean
  Private Enum eStockTakeOptions
    SelectVisible = 1
    DeselectVisible = 2

  End Enum

  Private Sub btnSelectVisible_Click(sender As Object, e As EventArgs)

    Try

      SelectVisible()

    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try

  End Sub



  Private Sub SelectVisible()
    Dim mVisibleRows As New colStockTakeItemEditors
    Dim mItem As clsStockTakeItemEditor

    For mLoop = 0 To gvStockCheckItem.DataRowCount - 1
      mItem = gvStockCheckItem.GetRow(mLoop)
      mVisibleRows.Add(mItem)
    Next



    For Each mItem In mVisibleRows

      mItem.TempSelected = True

    Next




    gvStockCheckItem.RefreshData()

  End Sub

  Private Sub DeSelectVisible()
    Dim mVisibleRows As New colStockTakeItemEditors
    Dim mItem As clsStockTakeItemEditor

    For mLoop = 0 To gvStockCheckItem.DataRowCount - 1
      mItem = gvStockCheckItem.GetRow(mLoop)
      mVisibleRows.Add(mItem)
    Next



    For Each mItem In mVisibleRows

      mItem.TempSelected = False

    Next

    gvStockCheckItem.RefreshData()

  End Sub




  Private Sub btnDeselectVisible_Click(sender As Object, e As EventArgs)

    Try

      Dim mVisibleRows As New colStockTakeItemEditors
      Dim mItem As clsStockTakeItemEditor

      For mLoop = 0 To gvStockCheckItem.DataRowCount - 1
        mItem = gvStockCheckItem.GetRow(mLoop)
        mVisibleRows.Add(mItem)
      Next



      For Each mItem In mVisibleRows

        mItem.TempSelected = False

      Next


      gvStockCheckItem.RefreshData()

    Catch ex As Exception

      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try

  End Sub
  Public Shared Sub OpenFormAsMDIChild(ByRef rParentForm As Windows.Forms.Form, ByRef rUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal, ByVal vPrimaryKeyID As Integer, ByVal vFormMode As eFormMode)
    Dim mfrm As frmStockTake = Nothing
    Dim mCreated As Boolean = False
    'Dim mTableName As String

    '' Add code here if need to check if a Detail Form for this ID is already open

    mfrm = GetFormIfLoaded(vPrimaryKeyID)

    If mfrm Is Nothing Then
      mfrm = New frmStockTake
      mfrm.FormController = New fccStockTake
      mfrm.FormController.DBConn = rUserSession.CreateMainDBConn
      mfrm.FormController.RTISGlobal = rRTISGlobal
      mfrm.FormController.StockTakeID = vPrimaryKeyID
      If vPrimaryKeyID = 0 Then
        mfrm.FormMode = eFormMode.eFMFormModeAdd
      Else
        mfrm.FormMode = eFormMode.eFMFormModeEdit
      End If

      mfrm.MdiParent = rParentForm 'My.Application.MenuMDIForm
      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub


  Private Shared Function GetFormIfLoaded(ByVal vPrimaryKeyID As Integer) As frmStockTake
    Dim mfrmWanted As frmStockTake = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmStockTake
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If mfrm.FormController.StockTakeID = vPrimaryKeyID Then
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

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

  End Sub


  Private Sub frmDetailForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    ''FormController.ClearObjects()
    FormController = Nothing
    sActiveForms.Remove(Me.pMySharedIndex.ToString)
    Me.Dispose()
  End Sub

  Public Property FormController() As fccStockTake
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccStockTake)
      pFormController = value
    End Set
  End Property

  Private Sub frmDetailForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub

  Private Sub frmDetailForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False

    ''Resize if required

    pIsActive = False
    pLoadError = False

    Try
      If mOK Then mOK = pFormController.LoadObject()

      If mOK Then mOK = pFormController.LoadRefData()

      LoadCombo()
      LoadGrid()

      ''      'If mOK Then LoadExtensionControls()

      If mOK Then RefreshControls()

      ''      If mOK Then SetupUserPermissions()

      If mOK Then

        Me.Text = "Stock Take: " & pFormController.StockTakeID
        grpDetail.Width = grpItemDetail.Width

        bbtnStockValuation.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        barbtnLoadDespatchedQty.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbtnRefreshWIPItems.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbtnGoodsInInvoiced.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

      End If

    Catch ex As Exception
      mMsg = ex.Message
      mOK = False
      mErrorDisplayed = True
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      If Not mErrorDisplayed Then MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, mMsg), vbExclamation)
      pLoadError = True
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))

    End If

    pIsActive = True

  End Sub

  Private Sub LoadCombo()
    ''    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdStockCheckItem, gcPricingUnit, eUnit.GetInstance().ValueItems)
    ''    If Not String.IsNullOrEmpty(pFormController.StockCheck.RangeStockCodeStart) Then
    ''      gvStockCheckItem.ActiveFilterString = String.Format(" StockCode >= '{0}' AND StockCode <= '{1}'", pFormController.StockCheck.RangeStockCodeStart, pFormController.StockCheck.RangeStockCodeEnd)
    ''End If

  End Sub

  Private Sub LoadGrid()
    grdStockCheckItem.DataSource = pFormController.StockTakeItemEditors
    gvStockCheckItem.RefreshData()
  End Sub


  Private Sub CloseForm() 'Needs exit mode set first
    pForceExit = True
    Me.Close()
  End Sub

  Private Function CheckSave(ByVal rOption As Boolean) As Boolean
    Dim mSaveRequired As Boolean
    Dim mResponse As MsgBoxResult
    Dim mRetVal As Boolean

    UpdateObject()

    If pFormController.IsDirty() Then
      If rOption Then
        mResponse = MsgBox("Changes have been made. Do you wish to save them?", MsgBoxStyle.YesNoCancel)
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
    If mSaveRequired Then
      Dim mValidate As clsValidate
      mValidate = pFormController.ValidateObject
      If mValidate.ValOk Then
        mRetVal = pFormController.SaveObject()
        'TODO - If mRetVal then AddHandler InstanceData to  BrowseTracker
      Else
        MsgBox(mValidate.Msg, MsgBoxStyle.Exclamation, "Validation Issue")
        mRetVal = False
      End If
    End If
    CheckSave = mRetVal
  End Function

  Private Sub RefreshControls()
    ' Check User Permissions here
    Dim mStartActive As Boolean = pIsActive
    'Dim mIntExtender As RTIS.FormExtenderCore.intExtenderControl

    pIsActive = False
    If pFormController.StockTake IsNot Nothing Then

      With pFormController.StockTake

        If Not clsGeneralA.IsBlankDate(.DateCommitted) Then
          grpItemDetail.Enabled = False
        Else
          grpItemDetail.Enabled = True
        End If
        txtStockCheckDesc.Text = .Description
        dateStockCheck.DateTime = .StockTakeDate

        datDateSystemQty.DateTime = .DateSystemQty

        bbtnAplicarCantidadesContado.Enabled = clsGeneralA.IsBlankDate(.DateCommitted)


        ''UIHelper.SetControlsEnabled(PanelControl1, clsGeneralA.IsBlankDate(.DateCommitted))
        ''UIHelper.SetBarManagerEnabled(BarManager1, clsGeneralA.IsBlankDate(.DateCommitted))
        barbtnClose.Enabled = True

        ''RefreshSystemQtyButton()

        ''pceStockTakeSheets.Text = String.Format("{0} Sheet(s)", .StockTakeSheets.Count.ToString())


        If .DateSystemQty > DateTime.MinValue Then

          btnClearRange.Enabled = True
          btnClearSystemQty.Enabled = True


          barbtnFIFOSystemValue.Enabled = True
          barbtnFIFOCountedValue.Enabled = True



        Else

          btnClearRange.Enabled = False
          btnClearSystemQty.Enabled = False


          barbtnFIFOSystemValue.Enabled = False
          barbtnFIFOCountedValue.Enabled = False

        End If

        gvStockCheckItem.RefreshData()

        gvStockItemValuationHistorys.RefreshData()
      End With

    End If


    pIsActive = mStartActive
  End Sub

  Private Sub UpdateObject()
    ''Read in from controls - update object/record
    ''    'Dim mIntExtender As RTIS.FormExtenderCore.intExtenderControl

    'Make sure all grid controls etc. finished current edit
    Try
      Dim mActiveControl As Control = Me.ActiveControl
      grpDetail.Focus()
      If mActiveControl IsNot Nothing Then
        mActiveControl.Focus()
      End If
    Catch Ex As Exception
      If Debugger.IsAttached Then MsgBox("UpdateObject-Focus: " & Ex.Message)
    End Try

    If pFormController.StockTake IsNot Nothing Then

      With pFormController.StockTake
        .Description = txtStockCheckDesc.Text
        .StockTakeDate = dateStockCheck.DateTime

      End With

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

  Private Sub InitiateSaveExit() 'User initiated request to save - Call from buttons/menu/toolbar etc.

    If CheckSave(False) Then
      CloseForm()
    End If

  End Sub

  Private Sub barbtnSaveExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSaveExit.ItemClick
    Try
      InitiateSaveExit()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbutSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSave.ItemClick
    Try
      CheckSave(False)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnClose.ItemClick
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

  Private Sub barbtnExcelExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExcelExport.ItemClick
    Try

      Dim mFileName As String = String.Empty
      Dim mTitle As String = Me.Text
      Dim mExcel As clsExcelExportStockTake
      If RTIS.CommonVB.clsGeneralA.GetSaveFileName(mFileName, mTitle, String.Empty, "Excel |*.xls") = DialogResult.OK Then
        ''grdStockCheckItem.ExportToXls(mFileName)
        mExcel = New clsExcelExportStockTake(pFormController.StockTake, pFormController.StockTakeItemEditors)
        mExcel.CreateSpreadSheet()
        mExcel.WorkBook.SaveDocument(mFileName)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

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


  Private Sub bbtnRefreshStockItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnRefreshStockItems.ItemClick
    Try
      pFormController.AddDefaultItems()

      LoadCombo()

      LoadGrid()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

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

  Private Sub gvStockCheckItem_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles gvStockCheckItem.CustomUnboundColumnData
    Try

      Dim mRow As clsStockTakeItemEditor = e.Row

      If mRow IsNot Nothing Then
        If e.IsGetData Then

          Select Case e.Column.Name
            Case gcDiscrepency.Name

              If mRow.IsCounted Then
                e.Value = ((mRow.CountedQty + mRow.WriteOffQuantity) - mRow.SnapshotQty)
              Else
                e.Value = 0
              End If


            Case gcCountedQty.Name

              If mRow.IsCounted Then
                e.Value = mRow.CountedQty
              Else
                e.Value = Nothing
              End If

            Case gcWriteOffQuantity.Name

              If mRow.IsCounted Then
                e.Value = mRow.WriteOffQuantity
              Else
                e.Value = Nothing
              End If


          End Select


        End If

        If e.IsSetData Then

          Select Case e.Column.Name
            Case gcCountedQty.Name

              mRow.CountedQty = e.Value

              If e.Value IsNot Nothing Then
                mRow.IsCounted = True
              Else
                mRow.WriteOffQuantity = 0
                mRow.IsCounted = False
              End If
            Case gcWriteOffQuantity.Name

              If mRow.IsCounted Then
                mRow.WriteOffQuantity = e.Value
              End If

          End Select

        End If
      End If



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub barbtnCommitStockTake_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbtnCommitStockTake.ItemClick

  End Sub

  Private Sub bbtnAplicarCantidadesContado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnAplicarCantidadesContado.ItemClick
    Try
      pFormController.CommitStockTakeSheet()


      RefreshControls()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repitbtStockItemRefresh_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repitbtStockItemRefresh.ButtonClick
    Dim mCurrentSTIE As clsStockTakeItemEditor
    Try
      mCurrentSTIE = gvStockCheckItem.GetFocusedRow
      mCurrentSTIE.StockItem = pFormController.RTISGlobal.StockItemRegistry.GetStockItemFromID(mCurrentSTIE.StockItem.StockItemID)
      gvStockCheckItem.RefreshData()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvStockCheckItem_ShowingEditor(sender As Object, e As CancelEventArgs) Handles gvStockCheckItem.ShowingEditor
    Dim mCurrentSTIE As clsStockTakeItemEditor
    Try
      Select Case gvStockCheckItem.FocusedColumn.Name
        Case gcWriteOffQuantity.Name
          mCurrentSTIE = gvStockCheckItem.GetFocusedRow
          If mCurrentSTIE.IsCounted = False Then
            e.Cancel = True
          End If
      End Select
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

  End Sub

  Private Sub grpItemDetail_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles grpItemDetail.CustomButtonClick

    Select Case e.Button.Properties.Tag
      Case eStockTakeOptions.SelectVisible

        Try

          SelectVisible()

        Catch ex As Exception

          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

        End Try

      Case eStockTakeOptions.DeselectVisible

        Try

          DeSelectVisible()

        Catch ex As Exception

          If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw


        End Try


    End Select



  End Sub

  Private Function PrintSelectedItems() As colStockTakeItemEditors
    Dim mDataSource As New colStockTakeItemEditors

    For Each mSTIE In pFormController.StockTakeItemEditors
      If mSTIE.TempSelected = True Then
        mDataSource.Add(mSTIE)
      End If
    Next

    ''crear metodo para el reporte psando mdatasource al reporte
    Return mDataSource
  End Function

  Private Sub bbtnPrintVisibleItems_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbtnPrintVisibleItems.ItemClick
    Dim mReport As repSelectedItems
    Dim mRepTools As DevExpress.XtraReports.UI.ReportPrintTool



    CheckSave(False)

    mReport = GetReport()
    mRepTools = New DevExpress.XtraReports.UI.ReportPrintTool(mReport)
    mRepTools.ShowPreviewDialog()

    ''CreateReportPDF(True, mReport)

    CheckSave(False)
    RefreshControls()

    mReport.Dispose()

  End Sub

  Public Sub CreateReportPDF(ByVal vOverride As Boolean, ByRef vReport As DevExpress.XtraReports.UI.XtraReport)
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty

    If vReport IsNot Nothing Then

      pFormController.CreateSelectedItemsReport(vReport, "")
      frmPDFViewer.OpenFormAsModal(Me.ParentForm, "C:\Users\Administrator\Downloads\axel.pdf")
      vReport.Dispose()

    End If

  End Sub

  Public Function GetReport() As DevExpress.XtraReports.UI.XtraReport
    Dim mRetVal As DevExpress.XtraReports.UI.XtraReport = Nothing
    Dim mDataSource As New colStockTakeItemEditors

    For Each mSTIE In pFormController.StockTakeItemEditors
      If mSTIE.TempSelected = True Then
        mDataSource.Add(mSTIE)
      End If
    Next

    mRetVal = repSelectedItems.GenerateReport(mDataSource)


    Return mRetVal
  End Function


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