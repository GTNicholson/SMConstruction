Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public MustInherit Class dtoProductBase : Inherits dtoBase
  Public pProductType As eProductType

  Protected pProduct As RTIS.ERPCore.intItemSpecCore
  Protected pProductID As Integer

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Shared Function GetNewInstance(ByVal vProductType As eProductType, ByRef rDBConn As clsDBConnBase) As dtoProductBase
    Dim mRetVal As dtoProductBase = Nothing
    Select Case vProductType
      Case eProductType.ProductFurniture
        mRetVal = New dtoProductFurniture(rDBConn)
        mRetVal.pProductType = vProductType
    End Select
    Return mRetVal
  End Function


  Protected Overrides Function SetObjectToNew() As Object

    Dim mRetVal As dtoProductBase = Nothing
    Select Case pProductType
      Case eProductType.ProductFurniture
        pProduct = New dmProductFurniture ' Or .NewBlankProductFurniture
    End Select

    Return pProduct

  End Function

  Public Property ProductID As Integer
    Get
      Return pProductID
    End Get
    Set(value As Integer)
      pProductID = value
    End Set
  End Property

  Public Function LoadProduct(ByRef rProduct As RTIS.ERPCore.intItemSpecCore, ByVal vProductID As Integer) As Boolean
    Dim mOK As Boolean
    mOK = LoadObject(vProductID)
    If mOK Then
      rProduct = pProduct
    Else
      rProduct = Nothing
    End If
    pProduct = Nothing
    Return mOK
  End Function



  Public Function SaveProduct(ByRef rProduct As RTIS.ERPCore.intItemSpecCore) As Boolean
    Dim mOK As Boolean
    pProduct = rProduct
    mOK = SaveObject()
    pProduct = Nothing
    Return mOK
  End Function


End Class
