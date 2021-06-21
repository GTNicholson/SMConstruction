
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class frmGlobalStockItemChanges

  Private pFormController As fccGlobalStockItemChange
  Public Sub OpenForm(ByRef rDBConn As clsDBConnBase, ByRef rSelectedItems As colStockItems)
    Dim mfrm As New frmGlobalStockItemChanges

    mfrm.pFormController = New fccGlobalStockItemChange(rDBConn, rSelectedItems)

    mfrm.ShowDialog()


  End Sub

  Private Sub frmGlobalStockItemChanges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    LoadCombos()
  End Sub
  Public Sub LoadCombos()
    Dim mVIs As colValueItems

    mVIs = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies)
    clsDEControlLoading.FillDEComboVI(cboSpecies, mVIs)

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
    clsDEControlLoading.FillDEComboVI(cboCategory, mVIs)

    mVIs = clsEnumsConstants.EnumToVIs(GetType(eUoM))
    clsDEControlLoading.FillDEComboVI(cboUoM, mVIs)
  End Sub

  Private Sub bbtnApplyChanges_Click(sender As Object, e As EventArgs) Handles bbtnApplyChanges.Click
    Dim mSpeciesID As Integer
    Dim mCategory As Integer
    Dim mUoM As Integer
    Dim mItemType As Integer

    mSpeciesID = clsDEControlLoading.GetDEComboValue(cboSpecies)
    mCategory = clsDEControlLoading.GetDEComboValue(cbocategory)
    mUoM = clsDEControlLoading.GetDEComboValue(cboUoM)


    mItemType = clsDEControlLoading.GetDEComboValue(cboItemType)


    pFormController.ApplyGlobalChanges(mCategory, mSpeciesID, mUoM, mItemType)

    MessageBox.Show("Se ha realizado los cambios seleccionados")
    Me.Close()
  End Sub

  Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
    Dim mCategory As Integer

    If pFormController IsNot Nothing Then

      mCategory = clsDEControlLoading.GetDEComboValue(cboCategory)

      If mCategory > 0 Then
        Select Case mCategory

          Case eStockItemCategory.Abrasivos

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeAbrasivos.GetInstance.ValueItems)
            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False
          Case eStockItemCategory.Fixings

            cboItemType.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeFixings.GetInstance.ValueItems)
            cboSpecies.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies))
            'cboHeadType.Enabled = True
            'clsDEControlLoading.FillDEComboVI(cboHeadType, clsEnumsConstants.EnumToVIs(GetType(eHeadType)))

          Case eStockItemCategory.EPP
            Dim mEPP As clsStockItemTypeEPP
            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeEPP.GetInstance.ValueItems)
            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.Herrajes

            Dim mHerrajesType As clsStockItemTypeHerrajes
            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerrajes.GetInstance.ValueItems)


            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.Herramientas


            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeHerramientas.GetInstance.ValueItems)

            cboItemType.Enabled = True
            cboSpecies.Enabled = False
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.MatElect

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialElectrico.GetInstance.ValueItems)


            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.MatEmpaque

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMaterialEmpaque.GetInstance.ValueItems)


            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.BrickWork

            cboItemType.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeBrickWork.GetInstance.ValueItems)
            cboSpecies.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies))
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


          Case eStockItemCategory.MatVarios

            cboItemType.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMatVarioss.GetInstance.ValueItems)


            cboSpecies.Enabled = False
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


          Case eStockItemCategory.Plumbing

            cboItemType.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypePlumbings.GetInstance.ValueItems)
            cboSpecies.Enabled = True
            clsDEControlLoading.FillDEComboVI(cboSpecies, AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.FixingSpecies))

            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


          Case eStockItemCategory.Metal

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeMetales.GetInstance.ValueItems)


            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.PinturaYQuimico

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypePintura.GetInstance.ValueItems)

            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False

          Case eStockItemCategory.Laminas

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeLamina.GetInstance.ValueItems)

            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


          Case eStockItemCategory.Repuestos

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeRepuestosYPartes.GetInstance.ValueItems)

            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


          Case eStockItemCategory.Tapiceria

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeTapiceria.GetInstance.ValueItems)

            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


          Case eStockItemCategory.VidrioYEspejo

            clsDEControlLoading.FillDEComboVI(cboItemType, eStockItemTypeVidrioYEspejo.GetInstance.ValueItems)

            cboSpecies.Enabled = False
            cboItemType.Enabled = True
            'cboHeadType.Enabled = False
            'cboItemSubType.Enabled = False


        End Select


      End If
    End If

  End Sub
End Class