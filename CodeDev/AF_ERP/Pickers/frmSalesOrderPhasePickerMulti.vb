Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.Data
Imports RTIS.Elements
Imports DevExpress.XtraEditors
Imports RTIS.CommonVB.clsGeneralA
Imports DevExpress.XtraGrid.Views.Base

Public Class frmSalesOrderPhasePickerMulti
  Private pFormController As fccSalesOrderPhasePicker
  Private Shared sActiveForms As Collection
  'Private pSalesOrder As dmSalesOrder
  Private pSelectedIDs As Dictionary(Of Integer, Boolean)

  Public Property FormController() As fccSalesOrderPhasePicker
    Get
      FormController = pFormController
    End Get
    Set(ByVal value As fccSalesOrderPhasePicker)
      pFormController = value
    End Set
  End Property

  Public Property SelectedIDs() As Dictionary(Of Integer, Boolean)
    Get
      SelectedIDs = pSelectedIDs
    End Get
    Set(ByVal value As Dictionary(Of Integer, Boolean))
      pSelectedIDs = value
    End Set
  End Property

  Public Function GetSelectedIDs(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rSelectedIDs As Dictionary(Of Integer, Boolean)) As DialogResult
    Dim mfrm As New frmSalesOrderPhasePickerMulti
    Dim mSelectedIDs As New List(Of Integer)
    Dim mDialogResult As DialogResult
    mfrm.FormController = New fccSalesOrderPhasePicker
    mfrm.FormController.DBConn = rDBConn
    mfrm.Owner = rParentForm
    mfrm.SelectedIDs = rSelectedIDs
    mDialogResult = mfrm.ShowDialog()
    If mDialogResult = DialogResult.OK Then
      rSelectedIDs = mfrm.SelectedIDs


    End If
    mfrm.Owner = Nothing
    mfrm.Dispose()
    mfrm = Nothing
    Return mDialogResult
  End Function

  Private Shared Function GetFormIfLoaded() As frmSalesOrderPhasePickerMulti
    Dim mfrmWanted As frmSalesOrderPhasePickerMulti = Nothing
    Dim mFound As Boolean = False
    Dim mfrm As frmSalesOrderPhasePickerMulti
    '  Check if exisits already
    If sActiveForms Is Nothing Then sActiveForms = New Collection
    For Each mfrm In sActiveForms
      mfrmWanted = mfrm
      mFound = True
      Exit For
    Next
    If Not mFound Then
      mfrmWanted = Nothing
    End If
    Return mfrmWanted
  End Function

  Private Sub frmProdBatchPicker_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Try

      ' LoadCombo()

      If mOK Then RefreshControls()
      '' clsDEControlLoading.LoadGridLookUpEdit(grdWorkOrder, gvWorkOrder.Columns("DespatchStatus"), clsEnumsConstants.EnumToVIs(GetType(eDespatchStatus)))
      ' pSelectedIDs = New List(Of Integer)
    Catch ex As Exception
      mOK = False
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema cargando el formulario... Por favor intente nuevamente{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub RefreshControls()
    pFormController.WhereSQL = " DateCreated is not null"
    Me.grdWorkOrder.DataSource = pFormController.LoadSalesOrderPhaseDT
  End Sub

  Private Sub LoadCombo()
    ''clsDEControlLoading.LoadGridLookUpEditiVI(Me.grdWorkOrder, gvWorkOrder.Columns("DespatchStatus"), RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eDespatchStatus)))
  End Sub

  Private Sub RepbtnSelect_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepbtnSelect.ButtonClick
    Dim mDRow As DataRow
    If Not gvWorkOrder.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
      mDRow = Me.gvWorkOrder.GetFocusedDataRow
      pSelectedIDs.Add(mDRow.Item("SalesOrderPhaseID"), True)

    End If
    gvWorkOrder.CloseEditor()
  End Sub



  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvWorkOrder.CustomRowCellEdit
    Dim mRow As DataRow
    mRow = gvWorkOrder.GetDataRow(e.RowHandle)
    If mRow IsNot Nothing Then

      If e.Column.Name = gcCallOffNo.Name Then

        If pSelectedIDs.ContainsKey(mRow.Item("SalesOrderPhaseID")) Then
          If pSelectedIDs(mRow.Item("SalesOrderPhaseID")) Then
            e.RepositoryItem = repbtnUnSelect
          Else
            e.RepositoryItem = repitTextOnly

          End If
        Else
          e.RepositoryItem = RepbtnSelect
        End If

      End If

    End If
  End Sub

  Private Sub RepoItemButtonEditRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repbtnUnSelect.ButtonClick
    Try
      Dim mItem As DataRow
      If Not gvWorkOrder.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then

        mItem = gvWorkOrder.GetFocusedDataRow
        If mItem IsNot Nothing Then
          pSelectedIDs.Remove(mItem.Item("SalesOrderPhaseID"))
        End If
        gvWorkOrder.CloseEditor()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub btnConfirmSelection_Click(sender As Object, e As EventArgs) Handles btnConfirmSelection.Click
    Me.DialogResult = DialogResult.OK
    Me.Close()
  End Sub

  Private Sub gvSalesOrder_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvWorkOrder.CustomDrawCell
    Dim mRow As DataRow
    mRow = gvWorkOrder.GetDataRow(e.RowHandle)
    If mRow IsNot Nothing Then
      If pSelectedIDs.ContainsKey(mRow.Item("SalesOrderPhaseID")) Then
        e.Appearance.BackColor = Color.DodgerBlue
        e.Appearance.ForeColor = Color.Black
      Else
        e.Appearance.BackColor = Color.White
        e.Appearance.ForeColor = Color.Black
      End If
    End If
  End Sub
End Class