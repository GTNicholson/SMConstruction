Imports RTIS.CommonVB
Imports RTIS.Elements
Imports RTIS.ERPStock

Public Class frmPickerStockItem

  Private pPickerStockItem As clsPickerStockItem
  Private pRemainOpen As Boolean


  Public Shared Function OpenPickerSingle(ByVal vPickerStockItem As clsPickerStockItem) As intStockItemDef
    Dim mfrm As New frmPickerStockItem
    Dim mRetVal As intStockItemDef = Nothing

    mfrm.pPickerStockItem = vPickerStockItem
    mfrm.ShowDialog()

    If mfrm.pPickerStockItem.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerStockItem.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerStockItem.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Public Shared Function OpenPickerMulti(ByVal vPickerStockItem As clsPickerStockItem, ByVal vRemainOpen As Boolean) As List(Of intStockItemDef)
    Dim mfrm As New frmPickerStockItem
    Dim mRetVal As New List(Of intStockItemDef)

    mfrm.pPickerStockItem = vPickerStockItem
    mfrm.pRemainOpen = vRemainOpen
    mfrm.ShowDialog()

    If mfrm.pPickerStockItem.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerStockItem.SelectedObjects.Count > 0 Then
      For Each mItem As intStockItemDef In mfrm.pPickerStockItem.SelectedObjects
        mRetVal.Add(mItem)
      Next
    End If
    Return mRetVal
  End Function

  Private Sub frmPickerStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '' clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCategory, clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory)))
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcItemType, eStockItemTypeIronmongery.GetInstance.ValueItems)
  End Sub

  Private Sub RefreshControls()
    grdItemList.DataSource = pPickerStockItem.DataSource
    gvItemList.FocusedRowHandle = grdItemList.AutoFilterRowHandle
    gvItemList.FocusedColumn = gcStockCode
    gvItemList.ShowEditor()
  End Sub

  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemSelect.ButtonClick
    Try
      Dim mItem As intStockItemDef
      mItem = TryCast(gvItemList.GetFocusedRow, intStockItemDef)
      If mItem IsNot Nothing Then
        pPickerStockItem.SelectedObjects.Add(mItem)
        If pRemainOpen = False Then Me.Close()
      End If
      gvItemList.CloseEditor()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub repoItemRemove_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemRemove.ButtonClick
    Try
      Dim mItem As intStockItemDef
      mItem = TryCast(gvItemList.GetFocusedRow, intStockItemDef)
      If mItem IsNot Nothing Then
        pPickerStockItem.SelectedObjects.Remove(mItem)
        If pRemainOpen = False Then Me.Close()
      End If
      gvItemList.CloseEditor()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub gvItemList_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gvItemList.CustomUnboundColumnData
    Dim mRow As intStockItemDef
    ''Dim mSIItemTypeIron As clsStockItemTypeIronmongery
    mRow = TryCast(e.Row, intStockItemDef)
    'Dim mSISubItemTypeIron As clsStockSubItemTypeIronmongery

    If mRow IsNot Nothing Then
      If e.IsGetData Then
        If e.Column.Name = gcSubItemType.Name Then
          ''Select Case mRow.Category
          ''  Case eStockItemCategory.Ironmongery
          ''    If mRow.SubItemType <> 0 Then
          ''      mSIItemTypeIron = eStockItemTypeIronmongery.GetInstance.ItemFromKey(mRow.ItemType)
          ''      If mSIItemTypeIron IsNot Nothing Then
          ''        mSISubItemTypeIron = mSIItemTypeIron.StockSubItemTypeIronmongerys.ItemFromKey(mRow.SubItemType)
          ''        If mSISubItemTypeIron IsNot Nothing Then e.Value = mSISubItemTypeIron.Description
          ''      End If
          ''    End If
          ''End Select
        End If
      End If
    End If
  End Sub

  Private Sub gvItemList_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvItemList.CustomRowCellEdit
    Dim mRow As dmStockItem
    mRow = TryCast(gvItemList.GetRow(e.RowHandle), dmStockItem)
    If mRow IsNot Nothing Then

      If e.Column.Name = gcStockCode.Name Then

        If pPickerStockItem.SelectedObjects.Contains(mRow) Then
          e.RepositoryItem = repoItemRemove
        Else
          e.RepositoryItem = repoItemSelect
        End If

      End If

    End If
  End Sub

End Class