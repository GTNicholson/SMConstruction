Imports RTIS.CommonVB

Public Class clsProductBaseInfo
  Private pProduct As dmProductBase

  Public Property Product As dmProductBase
    Get
      Return pProduct
    End Get
    Set(value As dmProductBase)
      pProduct = value
    End Set
  End Property

  Public ReadOnly Property Code As String
    Get
      Return pProduct.Code
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Return pProduct.Description
    End Get
  End Property

  Public ReadOnly Property ItemType As eProductType
    Get
      Return pProduct.ItemType
    End Get
  End Property

  Public ReadOnly Property SubItemType As Int32
    Get
      Return pProduct.SubItemType
    End Get
  End Property
  Public ReadOnly Property ItemTypeDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eProductType), CType(pProduct.ItemType, eProductType))
    End Get
  End Property
End Class

Public Class colProductBaseInfos : Inherits List(Of clsProductBaseInfo)

End Class