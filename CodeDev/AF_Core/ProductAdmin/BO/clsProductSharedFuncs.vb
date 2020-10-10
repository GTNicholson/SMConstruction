Public Class clsProductSharedFuncs
  Public Shared Function NewProductInstance(ByVal vProductType As eProductType) As RTIS.ERPCore.intItemSpecCore
    Dim mRetVal As RTIS.ERPCore.intItemSpecCore = Nothing
    Select Case vProductType
      Case eProductType.ProductFurniture
        mRetVal = New dmProductFurniture

      Case eProductType.ProductInstallation
        mRetVal = New dmProductInstallation

      Case eProductType.StructureAF
        mRetVal = New dmProductStructure

    End Select
    Return mRetVal
  End Function

  Public Shared Function GetProductCode(ByRef rProductBase As dmProductBase) As String
    Dim mRetVal As String = ""
    Dim mRefLists As RTIS.CommonVB.colRefLists
    Dim mPCItemType As New dmProductConstructionType
    Dim mPCSubItemType As New dmProductConstructionSubType


    mRefLists = AppRTISGlobal.GetInstance.RefLists

    mPCItemType = CType(mRefLists.RefIList(appRefLists.ProductConstructionType), colProductConstructionTypes).ItemFromKey(rProductBase.ItemType)

    If mPCItemType IsNot Nothing Then

      mRetVal &= mPCItemType.Abbreviation

      mPCSubItemType = CType(mRefLists.RefIList(appRefLists.ProductConstructionSubType), colProductConstructionSubTypes).ItemFromKey(rProductBase.SubItemType)

      If mPCSubItemType IsNot Nothing Then
        mRetVal &= "-" & mPCSubItemType.Abbreviation & "."
      End If

    End If

    Return mRetVal
  End Function

End Class
