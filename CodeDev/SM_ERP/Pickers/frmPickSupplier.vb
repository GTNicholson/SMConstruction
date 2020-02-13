Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmPickSupplier

  Private pPickerSupplier As clsPickerSupplier


  Public Shared Function OpenPickerSingle(ByVal vPickerSupplier As clsPickerSupplier) As dmSupplier
    Dim mfrm As New frmPickSupplier


    Dim mRetVal As dmSupplier = Nothing
    mfrm.pPickerSupplier = vPickerSupplier
    mfrm.ShowDialog()

    If mfrm.pPickerSupplier.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerSupplier.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerSupplier.SelectedObjects(0)
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
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCustomerType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.CustomerTypes))
  End Sub

  Private Sub RefreshControls()
    grdItemList.DataSource = pPickerSupplier.DataSource
  End Sub

  Private Sub repItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repItemSelect.ButtonClick
    Try
      Dim mItem As dmSupplier
      mItem = TryCast(gvItemList.GetFocusedRow, dmSupplier)
      If mItem IsNot Nothing Then
        pPickerSupplier.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbtnNewSupplier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnNewSupplier.ItemClick
    Dim mRetVal As dmSupplier

    Try
      mRetVal = frmSupplierDetail.GetNewSupplier(pPickerSupplier.DBConn)
      If mRetVal IsNot Nothing Then
        pPickerSupplier.SelectedObjects.Add(mRetVal)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class