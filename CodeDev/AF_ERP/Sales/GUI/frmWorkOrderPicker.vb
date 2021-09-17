Imports RTIS.DataLayer
Imports RTIS.CommonVB
Imports System.Data
Imports RTIS.Elements
Imports DevExpress.XtraEditors
Imports RTIS.CommonVB.clsGeneralA
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmWorkOrderPicker


  Private pSelectedID As Integer
  Private pSelectedSOID As Integer
  Private pSelectedIDs As Dictionary(Of Integer, Boolean)
  Private pFormController As fccPickMaterials


  Private pPickerWO As clsPickerWorkOrder
  Private pRemainOpen As Boolean

  Public Property FormController As fccPickMaterials
    Get
      Return pFormController
    End Get
    Set(value As fccPickMaterials)
      pFormController = value
    End Set
  End Property
  Public Shared Function OpenPickerMulti(ByVal vPickerWorkOrder As clsPickerWorkOrder, ByVal vRemainOpen As Boolean) As colWorkOrderInfos
    Dim mfrm As New frmWorkOrderPicker
    Dim mRetVal As New colWorkOrderInfos

    mfrm.pPickerWO = vPickerWorkOrder
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPickerWO.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerWO.SelectedObjects.Count > 0 Then
      For Each mItem As clsWorkOrderInfo In mfrm.pPickerWO.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If
    Return mRetVal
  End Function
  Public Shared Function OpenPickerSingle(ByVal vPickerWO As clsPickerWorkOrder) As clsWorkOrderInfo
    Dim mfrm As New frmWorkOrderPicker


    Dim mRetVal As clsWorkOrderInfo = Nothing
    mfrm.pPickerWO = vPickerWO
    mfrm.ShowDialog()

    If mfrm.pPickerWO.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerWO.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerWO.SelectedObjects(0)
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



  Private Sub frmWorkOrderPicker_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    grdWorkOrder.DataSource = pPickerWO.DataSource
    gvWorkOrder.FocusedRowHandle = grdWorkOrder.AutoFilterRowHandle
    gvWorkOrder.FocusedColumn = gcWorkOrderID
    gvWorkOrder.ShowEditor()
  End Sub

  Private Sub gvWorkOrder_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvWorkOrder.CustomDrawCell
    Dim mRow As clsWorkOrderInfo
    Dim mWorkOrderInfo As clsWorkOrderInfo
    mRow = TryCast(gvWorkOrder.GetRow(e.RowHandle), clsWorkOrderInfo)

    If mRow IsNot Nothing Then
      mWorkOrderInfo = Nothing
      If pPickerWO.SelectedObjects.Contains(mRow) Then
        mWorkOrderInfo = mRow
      End If
      If mWorkOrderInfo IsNot Nothing Then
        e.Appearance.BackColor = Color.LightBlue
      Else
        e.Appearance.BackColor = Nothing
      End If
    End If
  End Sub

  Private Sub gvWorkOrder_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles gvWorkOrder.CustomRowCellEdit
    Dim mRow As clsWorkOrderInfo
    Dim mWorkOrderInfo As clsWorkOrderInfo

    If e.Column.Name = gcWorkOrderID.Name Then
      mRow = TryCast(gvWorkOrder.GetRow(e.RowHandle), clsWorkOrderInfo)

      If mRow IsNot Nothing Then
        mWorkOrderInfo = Nothing
        If pPickerWO.SelectedObjects.Contains(mRow) Then
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
      Dim mItem As clsWorkOrderInfo

      mItem = TryCast(gvWorkOrder.GetFocusedRow, clsWorkOrderInfo)
      If mItem IsNot Nothing Then

        pPickerWO.SelectedObjects.Remove(mItem)
        gvWorkOrder.CloseEditor()
        gvWorkOrder.RefreshRow(gvWorkOrder.FocusedRowHandle)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoSelectItem_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles repoSelectItem.ButtonClick
    Try
      Dim mItem As clsWorkOrderInfo
      mItem = TryCast(gvWorkOrder.GetFocusedRow, clsWorkOrderInfo)
      If mItem IsNot Nothing Then
        pPickerWO.SelectedObjects.Add(mItem)
        gvWorkOrder.CloseEditor()
        gvWorkOrder.RefreshRow(gvWorkOrder.FocusedRowHandle)
        If pRemainOpen = False Then Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class