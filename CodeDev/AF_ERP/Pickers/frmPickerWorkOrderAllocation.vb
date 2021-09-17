Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmPickerWorkOrderAllocation

  Private pPikcerWorkOrderAllocation As clsPickerWorkOrderAllocation
  Private pRemainOpen As Boolean
  Public Property SelectedIDs As Dictionary(Of Integer, Boolean)
  Public Function GetSelectedIDs(ByRef rParentForm As Windows.Forms.Form, ByRef rDBConn As clsDBConnBase, ByRef rSelectedIDs As Dictionary(Of Integer, Boolean)) As DialogResult
    Dim mfrm As New frmPickerWorkOrderAllocation
    Dim mSelectedIDs As New List(Of Integer)
    Dim mDialogResult As DialogResult
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
  Public Shared Function OpenPickerSingle(ByVal vPickerWorkOrderAllocation As clsPickerWorkOrderAllocation) As clsWorkOrderAllocationInfo
    Dim mfrm As New frmPickerWorkOrderAllocation
    Dim mRetVal As clsWorkOrderAllocationInfo = Nothing

    mfrm.pPikcerWorkOrderAllocation = vPickerWorkOrderAllocation
    mfrm.ShowDialog()

    If mfrm.pPikcerWorkOrderAllocation.SelectedObjects IsNot Nothing AndAlso mfrm.pPikcerWorkOrderAllocation.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPikcerWorkOrderAllocation.SelectedObjects(0)
    End If
    mfrm.Dispose()
    mfrm = Nothing
    Return mRetVal
  End Function

  Public Shared Function OpenPickerMulti(ByVal vPickerStockItem As clsPickerWorkOrderAllocation, ByVal vRemainOpen As Boolean) As colWorkOrderAllocationInfos
    Dim mfrm As New frmPickerWorkOrderAllocation
    Dim mRetVal As New colWorkOrderAllocationInfos

    mfrm.pPikcerWorkOrderAllocation = vPickerStockItem
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPikcerWorkOrderAllocation.SelectedObjects IsNot Nothing AndAlso mfrm.pPikcerWorkOrderAllocation.SelectedObjects.Count > 0 Then
      For Each mItem As clsWorkOrderAllocationInfo In mfrm.pPikcerWorkOrderAllocation.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If
    Return mRetVal
  End Function

  Private Sub frmPickerWorkOrderAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try


      ''  mOK = pFormController.LoadObject()

      LoadCombo()



      RefreshControls()


    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombo()

  End Sub

  Private Sub RefreshControls()
    grdWorkOrderAllocation.DataSource = pPikcerWorkOrderAllocation.DataSource
    gvWorkOrderAllocation.FocusedRowHandle = grdWorkOrderAllocation.AutoFilterRowHandle
    gvWorkOrderAllocation.FocusedColumn = gcWorkOrderNo
    gvWorkOrderAllocation.ShowEditor()
  End Sub

  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemSelect.ButtonClick
    Try
      Dim mItem As clsWorkOrderAllocationInfo
      mItem = TryCast(gvWorkOrderAllocation.GetFocusedRow, clsWorkOrderAllocationInfo)
      If mItem IsNot Nothing Then
        pPikcerWorkOrderAllocation.SelectedObjects.Add(mItem)
        gvWorkOrderAllocation.CloseEditor()
        gvWorkOrderAllocation.RefreshRow(gvWorkOrderAllocation.FocusedRowHandle)
        If pRemainOpen = False Then Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub



  Private Sub gvItemList_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvWorkOrderAllocation.CustomDrawCell
    Dim mRow As clsWorkOrderAllocationInfo
    Dim mWorkOrderAllocationInfo As clsWorkOrderAllocationInfo


    mRow = TryCast(gvWorkOrderAllocation.GetRow(e.RowHandle), clsWorkOrderAllocationInfo)

    If mRow IsNot Nothing Then
      mWorkOrderAllocationInfo = Nothing
      If pPikcerWorkOrderAllocation.SelectedObjects.Contains(mRow) Then
        mWorkOrderAllocationInfo = mRow
      End If
      If mWorkOrderAllocationInfo IsNot Nothing Then
        e.Appearance.BackColor = Color.LightBlue
      Else
        e.Appearance.BackColor = Nothing
      End If
    End If
  End Sub

  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles gvWorkOrderAllocation.CustomRowCellEdit
    Dim mRow As clsWorkOrderAllocationInfo
    Dim mStockItem As clsWorkOrderAllocationInfo

    If e.Column.Name = gcWorkOrderNo.Name Then
      mRow = TryCast(gvWorkOrderAllocation.GetRow(e.RowHandle), clsWorkOrderAllocationInfo)

      If mRow IsNot Nothing Then
        mStockItem = Nothing
        If pPikcerWorkOrderAllocation.SelectedObjects.Contains(mRow) Then
          mStockItem = mRow
        End If
        If mStockItem IsNot Nothing Then
          e.RepositoryItem = RepoItemButtonEditRemove
        Else
          e.RepositoryItem = repoItemSelect
        End If
      End If
    End If
  End Sub

  Private Sub RepoItemButtonEditRemove_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepoItemButtonEditRemove.ButtonClick
    Try
      Dim mItem As clsWorkOrderAllocationInfo

      mItem = TryCast(gvWorkOrderAllocation.GetFocusedRow, clsWorkOrderAllocationInfo)
      If mItem IsNot Nothing Then

        pPikcerWorkOrderAllocation.SelectedObjects.Remove(mItem)

        gvWorkOrderAllocation.CloseEditor()
        gvWorkOrderAllocation.RefreshRow(gvWorkOrderAllocation.FocusedRowHandle)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


End Class