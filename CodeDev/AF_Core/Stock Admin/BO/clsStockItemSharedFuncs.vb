Public Class clsStockItemSharedFuncs

  Public Shared Function GetStockItemTypeDescription(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mRefLists As RTIS.CommonVB.colRefLists
    mRefLists = AppRTISGlobal.GetInstance.RefLists

    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos
        mRetVal = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.NailsAndBolds
        mRetVal = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.EPP
        mRetVal = eStockItemTypeEPP.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.Herrajes
        mRetVal = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.Herramientas
        mRetVal = eStockItemTypeHerramientas.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.MatElect
        mRetVal = eStockItemTypeMaterialElectrico.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.MatEmpaque
        mRetVal = eStockItemTypeMaterialEmpaque.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.MatVarios
        mRetVal = eStockItemTypeMatVarios.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.Metal
        mRetVal = eStockItemTypeMetales.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.PinturaYQuimico
        mRetVal = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.Laminas
        mRetVal = eStockItemTypeLamina.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.Repuestos
        mRetVal = eStockItemTypeRepuestosYPartes.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.Tapiceria
        mRetVal = eStockItemTypeTapiceria.GetInstance.ItemFromKey(rStockItem.ItemType).Description
      Case eStockItemCategory.VidrioYEspejo
        mRetVal = eStockItemTypeVidrioYEspejo.GetInstance.ItemFromKey(rStockItem.ItemType).Description


      Case eStockItemCategory.Timber, eStockItemCategory.DimensionWood, eStockItemCategory.DriedWood
        Dim mSpecies As dmWoodSpecie
        mSpecies = CType(mRefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies).ItemFromKey(rStockItem.Species)
        If mSpecies IsNot Nothing Then
          mRetVal = mSpecies.EnglishDescription

        End If

    End Select
    Return mRetVal
  End Function


  Public Shared Function GetStockItemTypeAbbreviation(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mRefLists As RTIS.CommonVB.colRefLists
    mRefLists = AppRTISGlobal.GetInstance.RefLists

    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos
        mRetVal = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.NailsAndBolds
        mRetVal = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.EPP
        mRetVal = eStockItemTypeEPP.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.Herrajes
        mRetVal = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.Herramientas
        mRetVal = eStockItemTypeHerramientas.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.MatElect
        mRetVal = eStockItemTypeMaterialElectrico.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.MatEmpaque
        mRetVal = eStockItemTypeMaterialEmpaque.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.MatVarios
        mRetVal = eStockItemTypeMatVarios.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.Metal
        mRetVal = eStockItemTypeMetales.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.PinturaYQuimico
        mRetVal = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.Laminas
        mRetVal = eStockItemTypeLamina.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.Repuestos
        mRetVal = eStockItemTypeRepuestosYPartes.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.Tapiceria
        mRetVal = eStockItemTypeTapiceria.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation
      Case eStockItemCategory.VidrioYEspejo
        mRetVal = eStockItemTypeVidrioYEspejo.GetInstance.ItemFromKey(rStockItem.ItemType).Abreviation

      Case eStockItemCategory.Timber, eStockItemCategory.DimensionWood, eStockItemCategory.DriedWood
        Dim mSpecies As dmWoodSpecie
        mSpecies = CType(mRefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies).ItemFromKey(rStockItem.Species)
        If mSpecies IsNot Nothing Then
          mRetVal = mSpecies.Abbreviation

        End If

    End Select
    Return mRetVal
  End Function

  Public Shared Function GetStockCodeStem(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mValid As Boolean = True
    Dim mstocktypeAbbreviation As String = ""
    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos
        mRetVal = "ABR."
      Case eStockItemCategory.NailsAndBolds
        mRetVal = "CYT."
      Case eStockItemCategory.EPP
        mRetVal = "EPP."
      Case eStockItemCategory.Herrajes
        mRetVal = "HRJ."
      Case eStockItemCategory.Herramientas
        mRetVal = "HRM."
      Case eStockItemCategory.MatElect
        mRetVal = "ELC."
      Case eStockItemCategory.MatEmpaque
        mRetVal = "EMP."
      Case eStockItemCategory.MatVarios
        mRetVal = "VAR."
      Case eStockItemCategory.Metal
        mRetVal = "MET."
      Case eStockItemCategory.PinturaYQuimico
        mRetVal = "PYQ."
      Case eStockItemCategory.Laminas
        mRetVal = "LAM."
      Case eStockItemCategory.Repuestos
        mRetVal = "RYP."
      Case eStockItemCategory.Tapiceria
        mRetVal = "TAP."
      Case eStockItemCategory.VidrioYEspejo
        mRetVal = "VYE."
      Case eStockItemCategory.Timber
        mRetVal = "TMB."
      Case eStockItemCategory.DimensionWood
        mRetVal = "WDI."
      Case eStockItemCategory.DriedWood
        mRetVal = "WDY."
      Case Else
        mValid = False
    End Select
    mstocktypeAbbreviation = GetStockItemTypeAbbreviation(rStockItem)
    If mstocktypeAbbreviation <> "" Then
      mRetVal = mRetVal & mstocktypeAbbreviation & "."
    Else
      mValid = False
    End If
    If mValid = False Then mRetVal = ""
    Return mRetVal
  End Function

  Public Shared Function getStockItemValue(ByRef rStockItem As dmStockItem, ByVal vQty As Decimal) As Decimal
    Dim mRetval As Decimal
    mRetval = (rStockItem.StdCost + rStockItem.StdImportCost) * vQty
    Return mRetval
  End Function


End Class
