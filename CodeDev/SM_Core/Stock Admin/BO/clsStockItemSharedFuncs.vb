Public Class clsStockItemSharedFuncs

  Public Shared Function GetStockItemType(ByRef rStockItem As dmStockItem) As clsStockItemType
    Dim mRetVal As clsStockItemType = Nothing
    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos
        mRetVal = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.NailsAndBolds
        mRetVal = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.EPP
      Case eStockItemCategory.Herrajes
        mRetVal = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.MatElect
        mRetVal = eStockItemTypeMaterialElectrico.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.MatEmpaque
        mRetVal = eStockItemTypeMaterialEmpaque.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.MatVarios
      Case eStockItemCategory.Metal
        mRetVal = eStockItemTypeMetales.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.PinturaYQuimico
        mRetVal = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.Laminas
        mRetVal = eStockItemTypeLamina.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.Repuestos
        mRetVal = eStockItemTypeRepuestosYPartes.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.Tapiceria
        mRetVal = eStockItemTypeTapiceria.GetInstance.ItemFromKey(rStockItem.ItemType)
      Case eStockItemCategory.VidrioYEspejo
        mRetVal = eStockItemTypeVidrioYEspejo.GetInstance.ItemFromKey(rStockItem.ItemType)
    End Select
    Return mRetVal
  End Function

  Public Shared Function GetStockCodeStem(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mstocktype As clsStockItemType
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
    End Select
    mstocktype = GetStockItemType(rStockItem)
    If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation & "."
    Return mRetVal
  End Function

  Public Shared Function getStockItemValue(ByRef rStockItem As dmStockItem, ByVal vQty As Decimal) As Decimal
    Dim mRetval As Decimal
    mRetval = (rStockItem.StdCost + rStockItem.StdImportCost) * vQty
    Return mRetval
  End Function


End Class
