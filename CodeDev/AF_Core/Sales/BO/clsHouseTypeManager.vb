Public Class clsHouseTypeManager
  Private pHouseType As dmHouseType

  Public Sub New(ByRef rHouseType As dmHouseType)
    pHouseType = rHouseType
  End Sub

  Public ReadOnly Property HouseType As dmHouseType
    Get
      Return pHouseType
    End Get
  End Property

  Public Sub AddSalesItemAssembly()
    Dim mSalesItemAssembly As New dmSalesItemAssembly

    mSalesItemAssembly.Ref = GetDefaultNextAreaRef()
    mSalesItemAssembly.Description = mSalesItemAssembly.Ref

    mSalesItemAssembly.ParentID = pHouseType.HouseTypeID
    pHouseType.SalesItemAssemblys.Add(mSalesItemAssembly)
  End Sub

  Public Sub DeleteSalesItemAssembly(ByRef rSalesItemAssembly As dmSalesItemAssembly)
    pHouseType.SalesItemAssemblys.Remove(rSalesItemAssembly)
  End Sub

  Public Function GetDefaultNextAreaRef() As String
    Dim mPrefix As String
    Dim mMaxNo As Integer = 0
    Dim mRetVal As String

    mPrefix = "Area:"
    For Each mHTA As dmSalesItemAssembly In pHouseType.SalesItemAssemblys
      If mHTA.Ref.Length >= 5 Then
        If mHTA.Ref.Substring(0, 5).ToUpper = mPrefix.ToUpper Then
          If CInt(Val(mHTA.Ref.Substring(5))) >= mMaxNo Then
            mMaxNo = CInt(Val(mHTA.Ref.Substring(5)))
          End If
        End If
      End If
    Next

    mMaxNo = mMaxNo + 1

    mRetVal = mPrefix & mMaxNo.ToString("#")
    Return mRetVal
  End Function

  Public Sub AddProducts(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProducts As List(Of dmProductBase))
    Dim mSalesItem As dmHouseTypeSalesItems
    For Each mProduct As dmProductBase In rProducts
      mSalesItem = New dmHouseTypeSalesItems
      mSalesItem.HouseTypeID = pHouseType.HouseTypeID
      mSalesItem.HouseTypeAssemblyID = rSalesItemAssembly.SalesItemAssemblyID
      pHouseType.HTSalesItems.Add(mSalesItem)
    Next

  End Sub


End Class
