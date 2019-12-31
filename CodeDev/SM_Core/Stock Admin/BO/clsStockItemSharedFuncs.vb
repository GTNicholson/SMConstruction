Public Class clsStockItemSharedFuncs

  Public Shared Function GetStockCodeStem(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mstocktype As clsStockItemType
    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos
        mRetVal = "ABR."
        mstocktype = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
      Case eStockItemCategory.NailsAndBolds
        mRetVal = "CYT."
        mstocktype = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
      Case eStockItemCategory.EPP
        mRetVal = "EPP."
      Case eStockItemCategory.Herrajes
        mRetVal = "HRJ."
        mstocktype = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
      Case eStockItemCategory.PinturaYQuimico
        mRetVal = "PYQ."
        mstocktype = eStockItemTypePintura.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
    End Select
    Return mRetVal
  End Function

End Class
