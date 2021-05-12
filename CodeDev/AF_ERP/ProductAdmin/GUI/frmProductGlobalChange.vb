Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmProductGlobalChange
  Private pFormController As fccProductGlobalChange
  Public Shared Function OpenForm(ByRef rDBConn As clsDBConnBase, ByRef rSelectedItems As colProductBOMs) As Boolean
    Dim mfrm As New frmProductGlobalChange

    mfrm.pFormController = New fccProductGlobalChange(rDBConn, rSelectedItems)

    mfrm.ShowDialog()

    Return mfrm.pFormController.OKVal
  End Function

  Private Sub frmProductGlobalChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    LoadCombos()
  End Sub
  Public Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.WoodSpecie)
    clsDEControlLoading.FillDEComboVI(cboSpecies, mVIs)


  End Sub

  Public Sub UpdateObject()


  End Sub

  Private Sub bbtnApplyChanges_Click(sender As Object, e As EventArgs) Handles bbtnApplyChanges.Click
    Dim mSpeciesID As Integer

    mSpeciesID = clsDEControlLoading.GetDEComboValue(cboSpecies)

    pFormController.ChangeSpeciesForSelectedWoodItems(mSpeciesID)

    MessageBox.Show("Se ha cambiado la especie a los artículos seleccionados")
    Me.Close()
  End Sub
End Class