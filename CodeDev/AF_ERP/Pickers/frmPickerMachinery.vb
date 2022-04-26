Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmPickerMachinery

  Private pPickerMachinery As clsPickerMachinery


  Public Shared Function OpenPickerSingle(ByVal vPickerMachinery As clsPickerMachinery) As dmMachinery
    Dim mfrm As New frmPickerMachinery


    Dim mRetVal As dmMachinery = Nothing
    mfrm.pPickerMachinery = vPickerMachinery
    mfrm.ShowDialog()

    If mfrm.pPickerMachinery.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerMachinery.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerMachinery.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Private Sub frmPickerStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcMachineryType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.MachineryTypes))
  End Sub

  Private Sub RefreshControls()
    grdItemList.DataSource = pPickerMachinery.DataSource
  End Sub

  Private Sub repItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repItemSelect.ButtonClick
    Try
      Dim mItem As dmMachinery
      mItem = TryCast(gvItemList.GetFocusedRow, dmMachinery)
      If mItem IsNot Nothing Then
        pPickerMachinery.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


End Class