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


  Public ReadOnly Property ProductTypeID As eProductType
    Get
      Return pProduct.ProductTypeID
    End Get
  End Property

  Public ReadOnly Property CategoryDesc As String
    Get
      Return RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eProductType), CType(pProduct.ProductTypeID, eProductType))
    End Get
  End Property

  Public ReadOnly Property DrawingFileName As String
    Get
      Return pProduct.DrawingFileName
    End Get
  End Property

  Public ReadOnly Property ID As Integer
    Get
      Return pProduct.ID
    End Get
  End Property
  Public ReadOnly Property IsGeneric As Boolean
    Get
      Return pProduct.IsGeneric
    End Get
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

  Public ReadOnly Property ItemType As Int32
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
      Return AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ProductConstructionType).DisplayValueString(pProduct.ItemType)
    End Get
  End Property

  Public ReadOnly Property SubItemTypeDesc As String
    Get
      Return AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.ProductConstructionSubType).DisplayValueString(pProduct.SubItemType)
    End Get
  End Property


  Public ReadOnly Property FullyDefined As Boolean
    Get
      Return pProduct.FullyDefined
    End Get
  End Property


  Public ReadOnly Property SalesOrderID As Int32
    Get
      Return pProduct.SalesOrderID
    End Get
  End Property
End Class

Public Class colProductBaseInfos : Inherits List(Of clsProductBaseInfo)

  Public Function ItemFromProductTypeAndID(ByVal vProductType As eProductType, ByVal vID As Integer) As clsProductBaseInfo
    Dim mItem As clsProductBaseInfo
    Dim mRetVal As clsProductBaseInfo = Nothing


    For Each mItem In Me

      If mItem.ID = vID And mItem.ProductTypeID = vProductType Then
        mRetVal = mItem
        Exit For
      End If
    Next
    Return mRetVal
  End Function

End Class