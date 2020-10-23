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

  Public Property HouseTypeID As Int32
    Get
      Return pHouseType.HouseTypeID
    End Get
    Set(value As Int32)
      pHouseType.HouseTypeID = value
    End Set
  End Property

  Public Property ModelName As String
    Get
      Return pHouseType.ModelName
    End Get
    Set(value As String)
      pHouseType.ModelName = value
    End Set
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


  Public ReadOnly Property Area As Decimal
    Get
      Return pHouseType.Area
    End Get
  End Property

End Class

Public Class colHouseTypeInfos : Inherits List(Of clsHouseTypeInfo)

  Public Function ItemFromKey(ByVal vhouseTypeID As Integer) As clsHouseTypeInfo
    Dim mRetVal As clsHouseTypeInfo = Nothing
    Dim mIndex As Integer

    mIndex = IndexFromHouseTypeID(vhouseTypeID)
    If mIndex <> -1 Then
      mRetVal = Me.Item(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromHouseTypeID(vhouseTypeID As Integer) As Integer
    Dim mItem As clsHouseTypeInfo
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In Me
      mCount += 1
      If mItem.HouseType IsNot Nothing Then
        If mItem.HouseType.HouseTypeID = vhouseTypeID Then
          mIndex = mCount
          Exit For
        End If
      End If
    Next
    Return mIndex
  End Function

End Class