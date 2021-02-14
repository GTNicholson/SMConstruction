Imports RTIS.DataLayer

Public Class clsStockItemSharedFuncs

  Public Shared Function GetStockItemTypeDescription(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mRefLists As RTIS.CommonVB.colRefLists
    Dim mStockItemType As clsStockItemType
    mRefLists = AppRTISGlobal.GetInstance.RefLists

    Select Case rStockItem.Category

      Case eStockItemCategory.Abrasivos
        mStockItemType = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If
      Case eStockItemCategory.NailsAndBolds
        mStockItemType = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If
      Case eStockItemCategory.EPP
        mStockItemType = eStockItemTypeEPP.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.Herrajes
        mStockItemType = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.Herramientas
        mStockItemType = eStockItemTypeHerramientas.GetInstance.ItemFromKey(rStockItem.ItemType)


        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.MatElect
        mStockItemType = eStockItemTypeMaterialElectrico.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.MatEmpaque
        mStockItemType = eStockItemTypeMaterialEmpaque.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.MatVarios
        mStockItemType = eStockItemTypeMatVarios.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.Metal
        mStockItemType = eStockItemTypeMetales.GetInstance.ItemFromKey(rStockItem.ItemType)


        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.PinturaYQuimico
        mStockItemType = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.Laminas
        mStockItemType = eStockItemTypeLamina.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If


      Case eStockItemCategory.Repuestos
        mStockItemType = eStockItemTypeRepuestosYPartes.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If
      Case eStockItemCategory.Tapiceria
        mStockItemType = eStockItemTypeTapiceria.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If


      Case eStockItemCategory.VidrioYEspejo
        mStockItemType = eStockItemTypeVidrioYEspejo.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

      Case eStockItemCategory.Timber
        'Dim mSpecies As dmWoodSpecie
        'mSpecies = CType(mRefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies).ItemFromKey(rStockItem.Species)
        'If mSpecies IsNot Nothing Then
        '  mRetVal = mSpecies.EnglishDescription

        'End If
        mStockItemType = eStockItemTypeTimberWood.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Description

        End If

    End Select
    Return mRetVal
  End Function


  Public Shared Function GetStockItemTypeAbbreviation(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mRefLists As RTIS.CommonVB.colRefLists
    Dim mStockItemType As clsStockItemType
    mRefLists = AppRTISGlobal.GetInstance.RefLists

    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos

        mStockItemType = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If
      Case eStockItemCategory.NailsAndBolds
        mStockItemType = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.EPP
        mStockItemType = eStockItemTypeEPP.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.Herrajes
        mStockItemType = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If
      Case eStockItemCategory.Herramientas
        mStockItemType = eStockItemTypeHerramientas.GetInstance.ItemFromKey(rStockItem.ItemType)


        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.MatElect
        mStockItemType = eStockItemTypeMaterialElectrico.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.MatEmpaque
        mStockItemType = eStockItemTypeMaterialEmpaque.GetInstance.ItemFromKey(rStockItem.ItemType)


        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.MatVarios
        mStockItemType = eStockItemTypeMatVarios.GetInstance.ItemFromKey(rStockItem.ItemType)


        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If


      Case eStockItemCategory.Metal
        mStockItemType = eStockItemTypeMetales.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If


      Case eStockItemCategory.PinturaYQuimico
        mStockItemType = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If


      Case eStockItemCategory.Laminas
        mStockItemType = eStockItemTypeLamina.GetInstance.ItemFromKey(rStockItem.ItemType)


        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If



      Case eStockItemCategory.Repuestos
        mStockItemType = eStockItemTypeRepuestosYPartes.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.Tapiceria
        mStockItemType = eStockItemTypeTapiceria.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.VidrioYEspejo
        mStockItemType = eStockItemTypeVidrioYEspejo.GetInstance.ItemFromKey(rStockItem.ItemType)

        If mStockItemType IsNot Nothing Then
          mRetVal = mStockItemType.Abreviation
        End If

      Case eStockItemCategory.Timber
        Dim mSpecies As dmWoodSpecie
        mSpecies = CType(mRefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies).ItemFromKey(rStockItem.Species)
        If mSpecies IsNot Nothing Then
          mRetVal = mSpecies.Abbreviation

          mStockItemType = eStockItemTypeTimberWood.GetInstance.ItemFromKey(rStockItem.ItemType)

          If mStockItemType IsNot Nothing Then
            mRetVal &= "." & mStockItemType.Abreviation
          End If

        End If

    End Select
    Return mRetVal
  End Function

  Public Shared Function GetWoodStockItemProposedDescription(ByRef rStockItem As dmStockItem)

    Dim mDescription As String
    Dim mRetVal As String = ""
    Dim mInteger As Integer
    Dim mDecimal As Decimal
    mDescription = "Madera " & GetStockItemTypeDescription(rStockItem)

    mDescription &= " de " & GetSpeciesDescription(rStockItem).Trim

    If rStockItem.ItemType = eStockItemTypeTimberWood.Arbol Or rStockItem.ItemType = eStockItemTypeTimberWood.Rollo Then
      ''decide what to do with this description
      ' mDescription &= " de Diametro de " & rStockItem.Thickness.ToString("n2")
    Else

      mInteger = Int(rStockItem.Thickness)
      mDecimal = (rStockItem.Thickness - mInteger) * 10
      If mDecimal = 0 Then
        mDescription &= String.Format(" de {0}", mInteger) & "''"

      Else
        mDescription &= String.Format(" de {0}_{1}", mInteger, mDecimal.ToString("n0")) & "''"

      End If

    End If



    Return mDescription
  End Function

  Public Shared Function GetSpeciesDescription(ByRef rStockItem As dmStockItem) As String
    Dim mSpecies As dmWoodSpecie
    Dim mRetVal As String = ""
    Dim mRefLists As RTIS.CommonVB.colRefLists

    mRefLists = AppRTISGlobal.GetInstance.RefLists

    mSpecies = CType(mRefLists.RefIList(appRefLists.WoodSpecie), colWoodSpecies).ItemFromKey(rStockItem.Species)
    If mSpecies IsNot Nothing Then
      mRetVal = mSpecies.SpanishDescription
      If mRetVal = "" Then mRetVal = mSpecies.EnglishDescription
    End If
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
        'Case eStockItemCategory.DimensionWood
        '  mRetVal = "WDI."
        'Case eStockItemCategory.DriedWood
        '  mRetVal = "WDY."
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
    If rStockItem.AverageCost = 0 Then
      mRetval = (rStockItem.StdCost + rStockItem.StdImportCost) * vQty

    Else
      mRetval = (rStockItem.AverageCost + rStockItem.StdImportCost) * vQty

    End If
    Return mRetval
  End Function

  Public Shared Function GetStockCodeStem_New(ByRef rStockItem As dmStockItem, ByRef rDBConn As clsDBConnBase) As String
    Dim mSICode As String = ""
    Dim mThicknessDecimal As Decimal
    Dim mThicknessInteger As Integer
    Dim mdsoStock As dsoStock
    mSICode = clsStockItemSharedFuncs.GetStockCodeStem(rStockItem)

    If rStockItem.Category = eStockItemCategory.Timber Then

      If mSICode <> "" Then
        mThicknessDecimal = rStockItem.Thickness ' mDSO.GetNextStockCodeSuffixNo(mStem)

        If mThicknessDecimal <> 0 Then
          mThicknessInteger = CInt(mThicknessDecimal)

          mThicknessDecimal = mThicknessDecimal - mThicknessInteger

          If mThicknessDecimal > 0 Then
            mThicknessDecimal = mThicknessDecimal * 10
            mSICode = mSICode & "_" & mThicknessInteger.ToString() & "." & mThicknessDecimal.ToString("n0")

          Else
            mSICode = mSICode & "_" & mThicknessInteger.ToString("n1")

          End If

        End If
      End If

    Else
      mdsoStock = New dsoStock(rDBConn)

      mSICode = mSICode & mdsoStock.GetNextStockCodeSuffixNo(mSICode).ToString("000")
      rStockItem.StockCode = mSICode


    End If

    Return mSICode
  End Function
End Class
