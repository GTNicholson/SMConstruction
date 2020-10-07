Public Class clsHouseTypeInfo
  Private pHouseType As dmHouseType



  Public Sub New()
    pHouseType = New dmHouseType


  End Sub

  Public ReadOnly Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
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


  Public ReadOnly Property GroupID As Int32
    Get
      Return pHouseType.GroupID
    End Get
  End Property

  Public ReadOnly Property ModelID As Int32
    Get
      Return pHouseType.ModelID
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