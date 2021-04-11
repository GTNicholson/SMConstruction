Imports RTIS.CommonVB
Imports RTIS.Elements
Imports RTIS.DataLayer
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraBars
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Automation

Public Class frmCostBook
  Private pFormController As fccCostBook
  Public ExitMode As Windows.Forms.DialogResult

  Private Shared sActiveForms As Collection
  Private Shared sFormIndex As Integer
  Private pMySharedIndex As Integer
  Private pIsActive As Boolean
  Private pLoadError As Boolean
  Private pForceExit As Boolean = False

  Public Enum eMaterialCategoryOptions
    RefreshCategory = 1
  End Enum
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

  Public Shared Sub OpenAsMDIChild(ByRef rMDIParent As Form, ByRef rDBConn As clsDBConnBase, ByVal vCostBookID As Integer)
    Dim mfrm As frmCostBook = Nothing

    mfrm = GetFormIfLoaded()

    If mfrm Is Nothing Then
      mfrm = New frmCostBook
      mfrm.pFormController = New fccCostBook(rDBConn)
      mfrm.pFormController.CostBookID = vCostBookID
      mfrm.MdiParent = rMDIParent

      mfrm.Show()
    Else
      mfrm.Focus()
    End If

  End Sub

  Private Shared Function GetFormIfLoaded() As frmCostBook
    Dim mfrmWanted As frmCostBook = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmCostBook
    'Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      If TypeOf mfrm Is frmCostBook Then
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

  Private Sub frmValidationRuleEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Dim mMsg As String = ""
    Dim mErrorDisplayed As Boolean = False
    Dim mProceed As Boolean = True

    pIsActive = False
    pLoadError = False

    If pFormController.CostBookID <> 0 Then
      If pFormController.LockOrder = False Then
        If MsgBox("¿Desea abrir en Modo de Solo Lectura?", vbYesNo) = vbNo Then
          mProceed = False
        End If
      End If
    End If


    If mProceed = True Then

      mOK = pFormController.LoadObject()




      LoadCombos()
      LoadGrids()
      ''  pFormController.CostBookID = repoCostBook.


      RefreshControls()

      If txtCostBookName.Text <> "" Then
        Me.Text = "Entrada de Libro de Costo : " & txtCostBookName.Text
      End If

      If Not mOK Then
        If Not mErrorDisplayed Then MsgBox(String.Format("Problema cargando el formulario... Por favor, Intente de nuevo{0}{1}", vbCrLf, mMsg), vbExclamation)
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

  Public Sub LoadGrids()

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

    Dim mVIs As colValueItems
    mVIs = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.CostBook)

    clsDEControlLoading.FillDERepComboVI(repoCostBook, mVIs)
    clsDEControlLoading.LoadGridLookUpEditiVI(grdCostBookEntry, gcCostUnit, clsEnumsConstants.EnumToVIs(GetType(eUoM)))


    clsDEControlLoading.FillDEComboVI(cboStockItemType, eStockItemTypeTimberWood.GetInstance.ValueItems)



  End Sub



  Private Sub RefreshControls()
    Dim mStartActive As Boolean = pIsActive
    pIsActive = False

    If pFormController.CostBook IsNot Nothing Then
      With pFormController.CostBook
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
      If pFormController.CostBook IsNot Nothing Then
        With pFormController.CostBook
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

      pFormController.CostBookID = pFormController.CostBook.CostBookID


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub barbt_Exit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barbt_Exit.ItemClick

    CheckSave(True)
    Me.Close()

  End Sub

  Private Sub pgrdDoorLeafMatrix_EditValueChanged(sender As Object, e As EditValueChangedEventArgs)
    pFormController.ChangeDataValue(e)
  End Sub

  Private Sub pgrdDoorLeafMatrix_CustomFieldSort(sender As Object, e As PivotGridCustomFieldSortEventArgs)

    'If e.Field.FieldName = "DoorFacingBand" Then
    '  If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
    '    Return
    '  End If

    '  e.Handled = True
    '  Dim s1 As String = e.Value1.ToString().Replace("Result ", String.Empty)
    '  Dim s2 As String = e.Value2.ToString().Replace("Result ", String.Empty)
    '  If Convert.ToInt32(s1) > Convert.ToInt32(s2) Then
    '    e.Result = 1
    '  Else
    '    If Convert.ToInt32(s1) = Convert.ToInt32(s2) Then
    '      e.Result = Comparer(Of Int32).Default.Compare(Convert.ToInt32(s1),
    '        Convert.ToInt32(s2))
    '    Else
    '      e.Result = -1
    '    End If
    '  End If
    'End If

  End Sub

  Private Sub repoCostBook_Validating(sender As Object, e As CancelEventArgs) Handles repoCostBook.Validating
    If CheckSave(True) = False Then
      e.Cancel = True
    End If
  End Sub

  Private Sub frmDoorLeafMatrix_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

  Private Sub btnLoadStockItem_Click(sender As Object, e As EventArgs) Handles btnLoadStockItem.Click
    Dim mItemType As Integer

    mItemType = clsDEControlLoading.GetDEComboValue(cboStockItemType)

    pFormController.RefreshStockItemColecctions(mItemType)
    grdCostBookEntry.RefreshDataSource()
    grdCostBookEntry.DataSource = pFormController.CostBookEntryEditors


  End Sub

  Private Sub gvCostBookEntry_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gvCostBookEntry.CustomUnboundColumnData
    ''Dim mRow As clsCostBookEntryEditor
    ''Dim mValueItems As colValueItems


    ''mRow = TryCast(e.Row, clsCostBookEntryEditor)
    ''If mRow IsNot Nothing Then
    ''  If e.IsGetData Then

    ''    If e.Column.Name = gcSpecies.Name Then
    ''      Select Case mRow.CategoryID
    ''        Case eStockItemCategory.FrameComponent
    ''          Select Case mRow.ItemType
    ''            Case eFCCategoryCDM.Architrave, eFCCategoryCDM.ExtensionLining, eFCCategoryCDM.FrameComponent, eFCCategoryCDM.Stops
    ''              mValueItems = pFormController.RTISGlobal.RefLists.RefListVI(appRefLists.FCRoleType)

    ''              If mValueItems IsNot Nothing Then
    ''                e.Value = mValueItems(mRow.Species)
    ''              End If
    ''          End Select

    ''      End Select
    ''    End If
    ''  End If
    ''End If
  End Sub




  ''Private Sub BtnRefreshCategory_Click(sender As Object, e As EventArgs) Handles btnRefreshCategory.Click
  ''  pFormController.RefreshCostStockCategory()

  ''  LoadGrids()
  ''End Sub

  Private Sub cboIsDefault_EditValueChanged(sender As Object, e As EventArgs) Handles cboIsDefault.EditValueChanged
    Dim mdso As dsoSalesOrder

    If pIsActive Then
      UpdateObject()
      CheckSave(False)

      If cboIsDefault.Checked Then
        mdso = New dsoSalesOrder(pFormController.DBConn)
        mdso.SetDefaultCostBook(pFormController.CostBookID)

        pFormController.CostBook = New dmCostBook
        pFormController.CostBookEntrys = New colCostBookEntrys
        pFormController.LoadCostBookAndCostBookEntry()
      End If

      ''call the dsoFunction to set default (only if checkstate = true)
      ''in the refresh control disable the cboisdefaut if it's true
      ''reload the costbook
      ''the loadobject in the fcc must load only the costbook (header) and the costbookentrys
      ''create another method to load the rest of the collections
    End If

  End Sub




  Private Sub RefreshGridAndKeepSelectedRow(ByVal vGridView As DevExpress.XtraGrid.Views.Grid.GridView)
    Dim mIndex As Integer = vGridView.GetDataSourceRowIndex(vGridView.FocusedRowHandle)
    vGridView.RefreshData()
    Dim rowHandle As Integer = vGridView.GetRowHandle(mIndex)
    vGridView.FocusedRowHandle = rowHandle
  End Sub





  Private Sub gcMaterialCategory_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs)

    Select Case e.Button.Properties.Tag
      Case eMaterialCategoryOptions.RefreshCategory

        LoadGrids()
    End Select

  End Sub
End Class