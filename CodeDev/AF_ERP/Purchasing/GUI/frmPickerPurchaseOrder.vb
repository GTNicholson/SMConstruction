Imports RTIS.CommonVB

Public Class frmPickerPurchaseOrder

  Private pPickerPurchaseOrder As clsPickerPurchaseOrder


  Public Shared Function OpenPickerSingle(ByVal vPickerPurchaseOrder As clsPickerPurchaseOrder) As clsPurchaseOrderInfo
    Dim mfrm As New frmPickerPurchaseOrder
    ''Dim mRetVal As dmPurchaseOrder = Nothing
    Dim mRetVal As clsPurchaseOrderInfo

    mfrm.pPickerPurchaseOrder = vPickerPurchaseOrder
    mfrm.ShowDialog()

    If mfrm.pPickerPurchaseOrder.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerPurchaseOrder.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerPurchaseOrder.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  ''AR: Adapted for a clsPurchaseOrderInfo returnig
  Public Shared Function OpenPickerSinglePurchaseOrderInfo(ByVal vPickerPurchaseOrder As clsPickerPurchaseOrder) As clsPurchaseOrderInfo
    Dim mfrm As New frmPickerPurchaseOrder
    Dim mRetVal As clsPurchaseOrderInfo = Nothing

    mfrm.pPickerPurchaseOrder = vPickerPurchaseOrder
    mfrm.ShowDialog()

    If mfrm.pPickerPurchaseOrder.SelectedObjects IsNot Nothing AndAlso mfrm.pPickerPurchaseOrder.SelectedObjects.Count > 0 Then
      mRetVal = mfrm.pPickerPurchaseOrder.SelectedObjects(0)
    End If

    Return mRetVal
  End Function

  Private Sub frmPickerStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim mOK As Boolean = True
    Try

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

  Private Sub RefreshControls()
    grdItemList.DataSource = pPickerPurchaseOrder.DataSource
  End Sub

  Private Sub repoItemSelect_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repoItemSelect.ButtonClick
    Try
      Dim mItem As clsPurchaseOrderInfo
      mItem = TryCast(gvItemList.GetFocusedRow, clsPurchaseOrderInfo)
      If mItem IsNot Nothing Then
        pPickerPurchaseOrder.SelectedObjects.Add(mItem)
        Me.Close()
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


End Class