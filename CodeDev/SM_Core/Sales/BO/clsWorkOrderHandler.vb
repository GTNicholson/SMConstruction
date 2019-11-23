Imports RTIS.CommonVB

Public Class clsWorkOrderHandler
  Private pWorkOrder As dmWorkOrder

  Public Sub New(ByRef rWorkOrder As dmWorkOrder)
    pWorkOrder = rWorkOrder
  End Sub

  Public Shared Function CreateInternalWorkOrder(ByVal vProductType As eProductType) As dmWorkOrder
    Dim mRetVal As dmWorkOrder
    mRetVal = New dmWorkOrder
    mRetVal.isInternal = True
    mRetVal.ProductTypeID = vProductType
    mRetVal.DateCreated = Now.Date
    mRetVal.Product = clsProductSharedFuncs.NewProductInstance(mRetVal.ProductTypeID)

    Return mRetVal
  End Function

End Class
