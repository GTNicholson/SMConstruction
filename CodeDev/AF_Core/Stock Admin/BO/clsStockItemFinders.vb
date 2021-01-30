Imports RTIS.ERPStock

Public Class clsStockItemFinders

  Public Shared Function FindTimberRolloCostingItem(ByRef rStockItem As dmStockItem, ByRef rStockItems As colStockItems) As dmStockItem
    Dim mRetVal As dmStockItem = Nothing
    Dim mMatcher As clsStockItemMatchHandler

    '// Ignore Length and Width
    '// find smallest thickness that is greater than current thickness
    mMatcher = New clsStockItemMatchHandler(rStockItems)
    mRetVal = mMatcher.FindBestMatch(rStockItem, New clsStockItemMatcherBiggerThicknessIgnoreLengthWidth, New clsStockItemBestMatchSmallestArea)

    Return mRetVal
  End Function

End Class

Public Class clsStockItemMatcherBiggerThicknessIgnoreLengthWidth : Inherits clsStockItemMatcherBase

  Public Overrides Function IsMatch(ByRef rCurrentItem As intStockItemDef, ByRef rCandidateItem As intStockItemDef) As Boolean
    Dim mRetVal As Boolean = True
    If mRetVal Then mRetVal = MatchCore(rCurrentItem, rCandidateItem)
    If mRetVal Then mRetVal = (rCurrentItem.Thickness < rCandidateItem.Thickness)
    If mRetVal Then mRetVal = (rCurrentItem.AuxCode = rCandidateItem.AuxCode)
    If mRetVal Then mRetVal = (rCurrentItem.AttributeID = rCandidateItem.AttributeID)
    If mRetVal Then mRetVal = (rCurrentItem.AttributeValue = rCandidateItem.AttributeValue)

    Return mRetVal
  End Function

End Class
