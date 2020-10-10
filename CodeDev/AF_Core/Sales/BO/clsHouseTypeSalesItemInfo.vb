Public Class clsHouseTypeSalesItemInfo
  Private pHouseTypeSalesItem As dmHouseTypeSalesItem
  Private pProduct As dmProductBase

  Private Shared sProductConstructionTypes As RTIS.CommonVB.colValueItems

  Public Sub New(ByRef rHouseTypeSalesItem As dmHouseTypeSalesItem, ByRef rProduct As dmProductBase)
    pHouseTypeSalesItem = rHouseTypeSalesItem
    pProduct = rProduct
    If sProductConstructionTypes Is Nothing Then
      sProductConstructionTypes = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ProductConstructionType)
    End If
  End Sub


  Public Property Product As dmProductBase
    Get
      Return pProduct
    End Get
    Set(value As dmProductBase)
      pProduct = value
    End Set
  End Property
  Public Property HouseTypeSalesItem As dmHouseTypeSalesItem
    Get
      Return pHouseTypeSalesItem
    End Get
    Set(value As dmHouseTypeSalesItem)
      pHouseTypeSalesItem = value
    End Set
  End Property
  Public ReadOnly Property Description As String
    Get
      Return pHouseTypeSalesItem.Description
    End Get
  End Property

  Public ReadOnly Property ProductCode As String
    Get
      Return pProduct.Code
    End Get
  End Property

  Public ReadOnly Property ProductConstructionTypeDesc As String
    Get
      Dim mRetVal As String
      mRetVal = sProductConstructionTypes.ItemValueToDisplayValue(pProduct.ItemType)
      Return mRetVal
    End Get
  End Property

  Public Property Quantity As Integer
    Get
      Return pHouseTypeSalesItem.Quantity
    End Get
    Set(value As Integer)
      pHouseTypeSalesItem.Quantity = value
    End Set
  End Property
End Class

Public Class colHouseTypeSalesItemInfos : Inherits List(Of clsHouseTypeSalesItemInfo)

End Class
