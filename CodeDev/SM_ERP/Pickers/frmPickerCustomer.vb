Imports RTIS.CommonVB
Imports RTIS.Elements

Public Class frmPickerCustomer

  Private pPickerCustomer As clsPickerCustomer


  Public Shared Function OpenPickerSingle(ByVal vPickerCustomer As clsPickerCustomer) As dmCustomer
    Dim mfrm As New frmPickerCustomer


    Dim mRetVal As dmCustomer = Nothing
    mfrm.pPickerCustomer = vPickerCustomer
    mfrm.ShowDialog()

    If mfrm.pPickerCustomer.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerCustomer.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerCustomer.SelectedObjects(0)
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
      MsgBox(String.Format("Problem loading the form... Please try again{0}{1}", vbCrLf, ""), vbExclamation)
    End If
  End Sub

  Private Sub LoadCombos()
    ''clsDEControlLoading.LoadGridLookUpEditiVI(grdItemList, gcCustomerType, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.CustomerTypes))
  End Sub

  Private Sub RefreshControls()
    grdItemList.DataSource = pPickerCustomer.DataSource
  End Sub

  Private Sub repItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repItemSelect.ButtonClick
    Try
      Dim mItem As dmCustomer
      mItem = TryCast(gvItemList.GetFocusedRow, dmCustomer)
      If mItem IsNot Nothing Then
        pPickerCustomer.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub bbtnNewCustomer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnNewCustomer.ItemClick
    Dim mRetVal As dmCustomer

    Try
      mRetVal = frmCustomerDetail.GetNewcustomer(pPickerCustomer.DBConn)
      If mRetVal IsNot Nothing Then
        pPickerCustomer.SelectedObjects.Add(mRetVal)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub
End Class