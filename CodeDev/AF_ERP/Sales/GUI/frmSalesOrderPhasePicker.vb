Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB


Public Class frmSalesOrderPhasePicker

  Private pPicker As clsPickerSalesOrderPhase
  Private pRemainOpen As Boolean
  Private pSalesOrderPhaseInfo As clsSalesOrderPhaseInfo
  Private pActive As Boolean
  Private pMode As ePickerMode

  Public Enum ePickerMode
    SinglePick = 1
    MultiPick = 2
  End Enum

  Public Shared Function OpenPickerSingle(ByVal vSalesOrderPhasePicker As clsPickerSalesOrderPhase) As clsSalesOrderPhaseInfo
    Dim mfrm As New frmSalesOrderPhasePicker
    Dim mRetVal As clsSalesOrderPhaseInfo = Nothing

    mfrm.pPicker = vSalesOrderPhasePicker
    mfrm.pRemainOpen = False
    mfrm.pMode = ePickerMode.SinglePick

    mfrm.ShowDialog()

    If mfrm.pPicker.SelectedObjects IsNot Nothing AndAlso mfrm.pPicker.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPicker.SelectedObjects(0)
    End If

    mfrm.Dispose()
    mfrm = Nothing

    Return mRetVal
  End Function

  Public Shared Function OpenPickerMulti(ByVal vPickerSalesOrderPhase As clsPickerSalesOrderPhase, ByVal vRemainOpen As Boolean) As colSalesOrderPhaseInfos
    Dim mfrm As New frmSalesOrderPhasePicker
    Dim mRetVal As New colSalesOrderPhaseInfos

    mfrm.pPicker = vPickerSalesOrderPhase
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPicker.SelectedObjects IsNot Nothing AndAlso mfrm.pPicker.SelectedObjects.Count > 0 Then
      For Each mSOPI As clsSalesOrderPhaseInfo In mfrm.pPicker.SelectedObjects
        mRetVal.Add(mSOPI)
      Next
    End If
    Return mRetVal
  End Function

  Private Sub frmPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try

      RefreshControls()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema cargando el formulario... Por favor, intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub RefreshControls()
    grdSalesOrderPhases.DataSource = pPicker.DataSource
  End Sub

  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepbtnSelect.ButtonClick
    'Try
    '  Dim mSOPI As clsSalesOrderPhaseInfo

    '  Select Case pMode
    '    Case ePickerMode.SinglePick
    '      mSOPI = TryCast(gvSalesOrderPhase.GetFocusedRow, clsSalesOrderPhaseInfo)
    '      If mSOPI IsNot Nothing Then
    '        pPicker.SelectedObjects.Add(mSOPI)
    '        Me.Close()
    '      End If

    '    Case ePickerMode.MultiPick
    '      mSOPI = TryCast(gvSalesOrderPhase.GetFocusedRow, clsSalesOrderPhaseInfo)
    '      If mSOPI IsNot Nothing Then
    '        pPicker.SelectedObjects.Add(mSOPI)
    '        If pRemainOpen = False Then Me.Close()
    '      End If

    '  End Select


    'Catch ex As Exception
    '  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    'End Try

    Try
      Dim mSOPI As clsSalesOrderPhaseInfo
      mSOPI = TryCast(gvSalesOrderPhase.GetFocusedRow, clsSalesOrderPhaseInfo)
      If mSOPI IsNot Nothing Then
        pPicker.SelectedObjects.Add(mSOPI)
        gvSalesOrderPhase.CloseEditor()
        gvSalesOrderPhase.RefreshRow(gvSalesOrderPhase.FocusedRowHandle)
        If pRemainOpen = False Then Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoItemRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoRemove.ButtonClick
    Try
      Dim mSOPI As clsSalesOrderPhaseInfo

      mSOPI = TryCast(gvSalesOrderPhase.GetFocusedRow, clsSalesOrderPhaseInfo)
      If mSOPI IsNot Nothing Then

        pPicker.SelectedObjects.Remove(mSOPI)

        gvSalesOrderPhase.CloseEditor()
        gvSalesOrderPhase.RefreshRow(gvSalesOrderPhase.FocusedRowHandle)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvSalesOrderPhase_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles gvSalesOrderPhase.CustomRowCellEdit
    Dim mRow As clsSalesOrderPhaseInfo
    Dim mSOPI As clsSalesOrderPhaseInfo

    If e.Column.Name = gcRef.Name Then
      mRow = TryCast(gvSalesOrderPhase.GetRow(e.RowHandle), clsSalesOrderPhaseInfo)

      If mRow IsNot Nothing Then
        mSOPI = Nothing
        If pPicker.SelectedObjects.Contains(mRow) Then
          mSOPI = mRow
        End If
        If mSOPI IsNot Nothing Then
          e.RepositoryItem = repoRemove
        Else
          e.RepositoryItem = RepbtnSelect
        End If
      End If
    End If
  End Sub

  Private Sub gvSalesOrderPhase_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvSalesOrderPhase.CustomDrawCell
    Dim mRow As clsSalesOrderPhaseInfo
    Dim mStockItem As clsSalesOrderPhaseInfo

    mRow = TryCast(gvSalesOrderPhase.GetRow(e.RowHandle), clsSalesOrderPhaseInfo)

    If mRow IsNot Nothing Then
      mStockItem = Nothing
      If pPicker.SelectedObjects.Contains(mRow) Then
        mStockItem = mRow
      End If
      If mStockItem IsNot Nothing Then
        e.Appearance.BackColor = Color.LightBlue
      Else
        e.Appearance.BackColor = Nothing
      End If
    End If
  End Sub
End Class