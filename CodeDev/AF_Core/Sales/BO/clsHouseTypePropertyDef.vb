Imports RTIS.ProductCore

Public Class clsHouseTypePropertyDef
  Implements RTIS.ProductCore.intObjectProperties

  Private pHouseType As dmHouseType
  Shared pPropertyList As colPropertyDef

  Public Enum ePropertyDefENUM
    None = 0
    FoundationOption = 1
    FloorOption = 2
    WallOptions = 3
    WindowOptions = 4
  End Enum

  Public ReadOnly Property ObjectType As Integer Implements intObjectProperties.ObjectType
    Get
      Throw New NotImplementedException()
    End Get
  End Property

  Public Property Description As String Implements intObjectProperties.Description
    Get
      Throw New NotImplementedException()
    End Get
    Set(value As String)
      Throw New NotImplementedException()
    End Set
  End Property

  Public ReadOnly Property PropertyList As colPropertyDef Implements intObjectProperties.PropertyList
    Get
      If pPropertyList Is Nothing Then

        pPropertyList = New colPropertyDef
        pPropertyList.AddPropertyDef(ePropertyDefENUM.None, "None", GetType(Integer), appRefLists.None, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.FoundationOption, "Fundación", GetType(Byte), appRefLists.FoundationOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.FloorOption, "Piso", GetType(Byte), appRefLists.FloorOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.WallOptions, "Paredes", GetType(Byte), appRefLists.WallOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.WindowOptions, "Ventanas", GetType(Byte), appRefLists.WindowOptions, True)
      End If

      Return pPropertyList
    End Get
  End Property

  Public ReadOnly Property MultiplierList As colPropertyDef Implements intObjectProperties.MultiplierList
    Get
      Throw New NotImplementedException()
    End Get
  End Property

  Public Function PropertyValue(rPropertyIndex As Integer) As Object Implements intObjectProperties.PropertyValue
    Dim mRetVal As Object = Nothing


    Select Case rPropertyIndex
      Case ePropertyDefENUM.None
        mRetVal = 0
      Case ePropertyDefENUM.FoundationOption
        mRetVal = pHouseType.TmpFoundationOption

      Case ePropertyDefENUM.FloorOption
        mRetVal = pHouseType.TmpFloorOptions

      Case ePropertyDefENUM.WindowOptions
        mRetVal = pHouseType.TmpWindowOptions

      Case ePropertyDefENUM.WallOptions
        mRetVal = pHouseType.TmpWallOptions
    End Select

    Return mRetVal
  End Function
End Class
