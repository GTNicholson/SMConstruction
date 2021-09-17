Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.Data
Imports RTIS.Elements
Imports DevExpress.XtraEditors
Imports RTIS.CommonVB.clsGeneralA
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSalesOrderPhaseItemPickerMulti


  Private pSelectedID As Integer
  Private pSelectedSOID As Integer
  Private pSelectedIDs As Dictionary(Of Integer, Boolean)
  Private pPicker As clsPickerSalesOrderPhaseItem
  Private pRemainOpen As Boolean


  Public Shared Function OpenPickerMulti(ByVal vPickerSalesOrderPhaseItem As clsPickerSalesOrderPhaseItem, ByVal vRemainOpen As Boolean) As colSalesOrderPhaseItemInfos
    Dim mfrm As New frmSalesOrderPhaseItemPickerMulti
    Dim mRetVal As New colSalesOrderPhaseItemInfos

    mfrm.pPicker = vPickerSalesOrderPhaseItem
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPicker.SelectedObjects IsNot Nothing AndAlso mfrm.pPicker.SelectedObjects.Count > 0 Then
      For Each mItem As clsSalesOrderPhaseItemInfo In mfrm.pPicker.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If
    Return mRetVal
  End Function
  Public Shared Function OpenPickerSingle(ByVal vPickerSalesOrderPhaseItem As clsPickerSalesOrderPhaseItem) As clsSalesOrderPhaseItemInfo
    Dim mfrm As New frmSalesOrderPhaseItemPickerMulti


    Dim mRetVal As clsSalesOrderPhaseItemInfo = Nothing
    mfrm.pPicker = vPickerSalesOrderPhaseItem
    mfrm.ShowDialog()

    If mfrm.pPicker.SelectedObjects IsNot Nothing AndAlso mfrm.pPicker.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPicker.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Public Property SelectedIDs() As Dictionary(Of Integer, Boolean)
    Get
      SelectedIDs = pSelectedIDs
    End Get
    Set(ByVal value As Dictionary(Of Integer, Boolean))
      pSelectedIDs = value
    End Set
  End Property



  Private Sub frmSalesOrderPhaseItemPickerMulti_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim mOK As Boolean = True
    Try
      LoadCombos()
      RefreshControls()

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    If Not mOK Then
      'MsgBox("Problem loading the form... Please try again" & vbCrLf & mMsg, vbExclamation)
      MsgBox(String.Format("Problema cargado el formulario... Por favor intente de nuevo{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombos()
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCustomerType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.CustomerTypes))
  End Sub

  Private Sub RefreshControls()

    grdSalesOrderPhaseItemInfo.DataSource = pPicker.DataSource
    gvSalesOrderPhaseItem.FocusedRowHandle = grdSalesOrderPhaseItemInfo.AutoFilterRowHandle
    gvSalesOrderPhaseItem.FocusedColumn = gcItemNumber
    gvSalesOrderPhaseItem.ShowEditor()
  End Sub

  Private Sub gvSalesOrderPhaseItem_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvSalesOrderPhaseItem.CustomDrawCell
    Dim mRow As clsSalesOrderPhaseItemInfo
    Dim mWorkOrderInfo As clsSalesOrderPhaseItemInfo
    mRow = TryCast(gvSalesOrderPhaseItem.GetRow(e.RowHandle), clsSalesOrderPhaseItemInfo)

    If mRow IsNot Nothing Then
      mWorkOrderInfo = Nothing
      If pPicker.SelectedObjects.Contains(mRow) Then
        mWorkOrderInfo = mRow
      End If
      If mWorkOrderInfo IsNot Nothing Then
        e.Appearance.BackColor = Color.LightBlue
      Else
        e.Appearance.BackColor = Nothing
      End If
    End If
  End Sub

  Private Sub gvSalesOrderPhaseItem_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles gvSalesOrderPhaseItem.CustomRowCellEdit
    Dim mRow As clsSalesOrderPhaseItemInfo
    Dim mWorkOrderInfo As clsSalesOrderPhaseItemInfo

    If e.Column.Name = gcItemNumber.Name Then
      mRow = TryCast(gvSalesOrderPhaseItem.GetRow(e.RowHandle), clsSalesOrderPhaseItemInfo)

      If mRow IsNot Nothing Then
        mWorkOrderInfo = Nothing
        If pPicker.SelectedObjects.Contains(mRow) Then
          mWorkOrderInfo = mRow
        End If
        If mWorkOrderInfo IsNot Nothing Then
          e.RepositoryItem = RepoItemButtonEditRemove
        Else
          e.RepositoryItem = repoSelectItem
        End If
      End If
    End If
  End Sub
  Private Sub RepoItemButtonEditRemove_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepoItemButtonEditRemove.ButtonClick
    Try
      Dim mItem As clsSalesOrderPhaseItemInfo

      mItem = TryCast(gvSalesOrderPhaseItem.GetFocusedRow, clsSalesOrderPhaseItemInfo)
      If mItem IsNot Nothing Then

        pPicker.SelectedObjects.Remove(mItem)
        gvSalesOrderPhaseItem.CloseEditor()
        gvSalesOrderPhaseItem.RefreshRow(gvSalesOrderPhaseItem.FocusedRowHandle)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoSelectItem_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoSelectItem.ButtonClick
    Try
      Dim mItem As clsSalesOrderPhaseItemInfo
      mItem = TryCast(gvSalesOrderPhaseItem.GetFocusedRow, clsSalesOrderPhaseItemInfo)
      If mItem IsNot Nothing Then
        pPicker.SelectedObjects.Add(mItem)
        gvSalesOrderPhaseItem.CloseEditor()
        gvSalesOrderPhaseItem.RefreshRow(gvSalesOrderPhaseItem.FocusedRowHandle)
        If pRemainOpen = False Then Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


End Class