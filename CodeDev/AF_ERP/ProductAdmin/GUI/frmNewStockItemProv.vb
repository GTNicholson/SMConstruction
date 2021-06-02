Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmNewStockItemProv
  Private pFormController As fccNewStockItemProv

  Public Function OpenForm(ByRef rDBConn As clsDBConnBase) As dmStockItem
    Dim mfrm As New frmNewStockItemProv

    mfrm.pFormController = New fccNewStockItemProv(rDBConn)

    mfrm.ShowDialog()


    Return mfrm.pFormController.StockItem
  End Function

  Private Sub frmNewStockItemProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadCombos()

  End Sub

  Private Sub LoadCombos()
    Dim mVis As New colValueItems

    mVis = clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))

    clsDEControlLoading.FillDEComboVI(cboCategory, mVis)


    mVis = clsEnumsConstants.EnumToVIs(GetType(eUoM))

    clsDEControlLoading.FillDEComboVI(cboUoM, mVis)
  End Sub

  Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

    Try
      If pFormController.StockItem Is Nothing Then
        pFormController.StockItem = New dmStockItem
      End If
      UpdateControls()
      pFormController.CreateNewProvStockItem()
      If pFormController.StockItem IsNot Nothing Then
        Me.Close()
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw

    End Try

  End Sub

  Private Sub UpdateControls()
    Try

      If pFormController.StockItem IsNot Nothing Then
        With pFormController.StockItem

          .Description = txtDescription.Text
          .Category = clsDEControlLoading.GetDEComboValue(cboCategory)
          .UoM = clsDEControlLoading.GetDEComboValue(cboUoM)

        End With
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw



    End Try
  End Sub

  Private Sub bbtnCancel_Click(sender As Object, e As EventArgs) Handles bbtnCancel.Click
    pFormController.StockItem = Nothing
    Me.Close()
  End Sub

  Private Sub frmNewStockItemProv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If pFormController.StockItem IsNot Nothing Then
      If pFormController.StockItem.Description = "" And pFormController.StockItem.Category = 0 Then
        pFormController.StockItem = Nothing
      End If
    End If
  End Sub
End Class