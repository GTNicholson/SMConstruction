Public Class clsProductSharedFuncs
  Public Shared Function NewProductInstance(ByVal vProductType As eProductType) As RTIS.ERPCore.intItemSpecCore
    Dim mRetVal As RTIS.ERPCore.intItemSpecCore = Nothing
    Select Case vProductType
      Case eProductType.ProductFurniture
        mRetVal = New dmProductFurniture
    End Select
    Return mRetVal
  End Function

End Class
