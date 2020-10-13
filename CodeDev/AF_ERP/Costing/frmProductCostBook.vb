Imports DevExpress.XtraBars
Imports DevExpress.XtraPivotGrid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmProductCostBook
  Private pFormController As fccProductCostBook
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    sFormIndex = sFormIndex + 1
    Me.pMySharedIndex = sFormIndex
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    sActiveForms.Add(Me, Me.pMySharedIndex.ToString)

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
      mRetVal = pFormController.SaveObject()

    End If

    CheckSave = mRetVal
  End Function

  Public Shared Sub OpenAsMDIChild(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByVal vProductCostBookID As Integer)
    Dim mfrm As frmProductCostBook = Nothing

    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmProductCostBook
      mfrm.pFormController = New fccProductCostBook(rDBConn)
      mfrm.pFormController.ProductCostBookID = vProductCostBookID
      mfrm.MdiParent = rMDIParent

      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub
  Private Shared Function GetFormIfLoaded() As frmProductCostBook
    Dim mfrmWanted As frmProductCostBook = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmProductCostBook
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmProductCostBook Then
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
  Private Sub frmProductCostBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False
    Dim mProceed As Boolean = True

    pIsActive = False
    pLoadError = False

    If pFormController.ProductCostBookID <> 0 Then
      If pFormController.LockOrder = False Then
        If MsgBox("¿Deseas abrir el formulario en modo de Lectura?", vbYesNo) = vbNo Then
          mProceed = False
        End If
      End If
    End If


    If mProceed = True Then

      mOK = pFormController.LoadObject()

      LoadCombos()
      LoadGrids()
      RefreshControls()

      If txtCostBookName.Text <> "" Then
        Me.Text = "Entrada del Costeo : " & txtCostBookName.Text
      End If

      If Not mOK Then
        If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor, intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
        pLoadError = True
        ExitMode = Windows.Forms.DialogResult.Abort
        BeginInvoke(New MethodInvoker(AddressOf CloseForm))

      End If

      pIsActive = True
    Else
      ExitMode = Windows.Forms.DialogResult.Abort
      BeginInvoke(New MethodInvoker(AddressOf CloseForm))
    End If
  End Sub

  Private Sub LoadGrids()

    grdProductCostInstalationEditor.DataSource = pFormController.ProductInstallationCostBookEntryEditors
    grdProductStructureCostBookEntry.DataSource = pFormController.ProductStructureCostBookEntryEditors
  End Sub

  Private Sub CloseForm() 'Needs exit mode set first
    pFormController.ClearObjects()
    pForceExit = True
    Me.Close()
  End Sub

  Private Sub frmPriceRuleEditor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    pFormController.ClearObjects()

    sActiveForms.Remove(Me.pMySharedIndex.ToString)
  End Sub


  Private Sub LoadCombos()

    ''Dim mVIs As colValueItems
    ''mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.CostBook)

    ''clsDEControlLoading.FillDERepComboVI(repoCostBook, mVIs)
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdCostBookEntry, gcCostUnit, clsEnumsConstants.EnumToVIs(GetType(eCostUnitMeasure)))


  End Sub
  Private Sub RefreshControls()
    Dim mStartActive As Boolean = pIsActive
    pIsActive = False

    If pFormController.ProductCostBook IsNot Nothing Then
      With pFormController.ProductCostBook
        txtCostBookName.Text = .CostBookName
        dteDate.EditValue = .CostBookDate
        cboIsDefault.Checked = .IsDefault

        If cboIsDefault.Checked Then
          cboIsDefault.ReadOnly = True
        Else
          cboIsDefault.ReadOnly = False
        End If
      End With
    End If

  End Sub
  Private Sub UpdateObject()

    Try
      If pFormController.ProductCostBook IsNot Nothing Then
        With pFormController.ProductCostBook
          .CostBookName = txtCostBookName.Text
          .CostBookDate = dteDate.EditValue
        End With
        '' pgrdDoorLeafMatrix.Update()
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub barbt_Save_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbt_Save.ItemClick
    Try
      CheckSave(False)

      pFormController.ProductCostBookID = pFormController.ProductCostBook.ProductCostBookID
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub barbt_Exit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbt_Exit.ItemClick

    CheckSave(True)
    Me.Close()

  End Sub

  Private Sub frmProductCostBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not pForceExit Then
      If e.CloseReason = System.Windows.Forms.CloseReason.FormOwnerClosing Or e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Or e.CloseReason = System.Windows.Forms.CloseReason.MdiFormClosing Then
        pFormController.ClearObjects()
        e.Cancel = Not CheckSave(True)
      End If
    End If
  End Sub
  Private Sub barbtnSaveExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbtnSaveExit.ItemClick
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


  Private Sub cboIsDefault_EditValueChanged(sender As Object, e As EventArgs) Handles cboIsDefault.EditValueChanged
    Dim mdso As dsoSales

    If pIsActive Then
      UpdateObject()
      CheckSave(False)

      If cboIsDefault.Checked Then
        mdso = New dsoSales(pFormController.DBConn)
        mdso.SetDefaultProductCostBook(pFormController.ProductCostBookID)

        pFormController.ProductCostBook = New dmProductCostBook
        pFormController.InstallationProductCostBookEntrys = New colProductCostBookEntrys
        pFormController.StructureProductCostBookEntrys = New colProductCostBookEntrys

        pFormController.LoadCostBookAndCostBookEntry()
      End If


    End If

  End Sub

  Private Sub btnLoadStockItem_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

  End Sub
End Class