Public Class clsStockItemSharedFuncs

  Public Shared Function GetStockCodeStem(ByRef rStockItem As dmStockItem) As String
    Dim mRetVal As String = ""
    Dim mstocktype As clsStockItemType
    Select Case rStockItem.Category
      Case eStockItemCategory.Abrasivos
        mRetVal = "AB."
        mstocktype = eStockItemTypeAbrasivos.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
      Case eStockItemCategory.NailsAndBolds
        mRetVal = "CT."
        mstocktype = eStockItemTypeNailsAndBolts.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
      Case eStockItemCategory.EPP
        mRetVal = "EP."
      Case eStockItemCategory.Herrajes
        mRetVal = "HJ."
        mstocktype = eStockItemTypeHerrajes.GetInstance.ItemFromKey(rStockItem.ItemType)
        If mstocktype IsNot Nothing Then mRetVal = mRetVal & mstocktype.Abreviation
    End Select
    Return mRetVal
  End Function

End Class
