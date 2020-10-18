Imports RTIS.CommonVB

Public Class clsHouseTypeInfo
  Private pHouseType As dmHouseType
  Private pSalesOrderItems As colSalesOrderItems



  Public Sub New()
    pHouseType = New dmHouseType
    pSalesOrderItems = New colSalesOrderItems

  End Sub

  Public ReadOnly Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
  End Property


  Public Property SalesOrderItems As colSalesOrderItems
    Get
      Return pSalesOrderItems
    End Get
    Set(value As colSalesOrderItems)
      pSalesOrderItems = value
    End Set
  End Property

  Public ReadOnly Property HouseTypeID As Int32
    Get
      Return pHouseType.HouseTypeID
    End Get
  End Property

  Public ReadOnly Property Name As String
    Get
      Return pHouseType.ModelName
    End Get
  End Property


  Public Property GroupID As Int32
    Get
      Return pHouseType.GroupID
    End Get
    Set(value As Int32)
      pHouseType.GroupID = value
    End Set
  End Property

  Public ReadOnly Property GroupDesc As String
    Get
      Dim mValueItems As colValueItems

      mValueItems = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.GroupType)

      Return mValueItems.DisplayValueString(pHouseType.GroupID)
    End Get
  End Property

  Public Property ModelID As Int32
    Get
      Return pHouseType.ModelID
    End Get
    Set(value As Int32)
      pHouseType.ModelID = value
    End Set

  End Property

  Public ReadOnly Property ModelDesc As String
    Get
      Dim mValueItems As colValueItems

      mValueItems = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.Model)

      Return mValueItems.DisplayValueString(pHouseType.ModelID)
    End Get
  End Property

  Public ReadOnly Property Area As Decimal
    Get
      Return pHouseType.Area
    End Get
  End Property

End Class

Public Class colHouseTypeInfos : Inherits List(Of clsHouseTypeInfo)

End Class