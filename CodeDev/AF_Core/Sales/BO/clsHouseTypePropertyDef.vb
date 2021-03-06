﻿Imports RTIS.ProductCore

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
    DeckOptions = 5
  End Enum

  Public Sub New()

  End Sub

  Public Sub New(ByRef rHouseType As dmHouseType)
    pHouseType = rHouseType
  End Sub

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
        pPropertyList.AddPropertyDef(ePropertyDefENUM.FoundationOption, "Fundación", GetType(Int32), appRefLists.FoundationOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.FloorOption, "Piso", GetType(Int32), appRefLists.FloorOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.WallOptions, "Paredes", GetType(Int32), appRefLists.WallOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.WindowOptions, "Ventanas", GetType(Int32), appRefLists.WindowOptions, True)
        pPropertyList.AddPropertyDef(ePropertyDefENUM.DeckOptions, "Con Deck", GetType(Boolean), appRefLists.None, True)

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

      Case ePropertyDefENUM.DeckOptions
        mRetVal = pHouseType.TmpWallOptions

    End Select

    Return mRetVal
  End Function
End Class
