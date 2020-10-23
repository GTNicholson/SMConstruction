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
    mSalesItemAssembly.Area = 0
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

  Public Sub AddProducts(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProducts As List(Of clsProductBaseInfo), ByRef rProductCostBook As dmProductCostBook)

    For Each mProduct As clsProductBaseInfo In rProducts
      AddProduct(rSalesItemAssembly, mProduct, rProductCostBook)
    Next

  End Sub

  Public Sub AddProduct(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProduct As clsProductBaseInfo, ByRef rProductCostBook As dmProductCostBook)
    Dim mSalesItem As dmHouseTypeSalesItem
    Dim mCostBookEntryIndex As Integer = -1

    mSalesItem = New dmHouseTypeSalesItem
    mSalesItem.HouseTypeID = pHouseType.HouseTypeID
    mSalesItem.ProductID = rProduct.ID
    mSalesItem.ProductTypeID = rProduct.ProductTypeID
    mSalesItem.HouseTypeSalesItemAssemblyID = rSalesItemAssembly.SalesItemAssemblyID
    mSalesItem.Description = rProduct.Description

    If rProductCostBook IsNot Nothing Then
      mCostBookEntryIndex = rProductCostBook.ProductCostBookEntrys.IndexFromProductID_ItemTypeID(rProduct.ID, rProduct.ItemType)

      If mCostBookEntryIndex <> -1 Then
        mSalesItem.Cost = rProductCostBook.ProductCostBookEntrys(mCostBookEntryIndex).Cost

        mSalesItem.DirectLabourCost = rProductCostBook.ProductCostBookEntrys(mCostBookEntryIndex).DirectLabourCost
        mSalesItem.DirectMaterialCost = rProductCostBook.ProductCostBookEntrys(mCostBookEntryIndex).DirectMaterialCost
        mSalesItem.OutsourcingCost = rProductCostBook.ProductCostBookEntrys(mCostBookEntryIndex).OutsourcingCost
        mSalesItem.DirectTransportationAndEquipment = rProductCostBook.ProductCostBookEntrys(mCostBookEntryIndex).DirectTransportationAndEquipment

      End If

    End If
    pHouseType.HTSalesItems.Add(mSalesItem)


  End Sub


  Public Function GetHTItemInfosForAssembly(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProducts As colProductBases) As colHouseTypeSalesItemInfos
    Dim mRetVal As New colHouseTypeSalesItemInfos
    Dim mHTSII As clsHouseTypeSalesItemInfo
    Dim mProduct As dmProductBase

    If rSalesItemAssembly IsNot Nothing Then
      For Each mHTSI As dmHouseTypeSalesItem In pHouseType.HTSalesItems
        If mHTSI.HouseTypeSalesItemAssemblyID = rSalesItemAssembly.SalesItemAssemblyID Then
          mProduct = rProducts.ItemFromProductTypeAndID(mHTSI.ProductTypeID, mHTSI.ProductID)
          mHTSII = New clsHouseTypeSalesItemInfo(mHTSI, mProduct, rSalesItemAssembly.Description)
          mRetVal.Add(mHTSII)
        End If
      Next

    End If
    Return mRetVal
  End Function

  Public Function GetTotalHTSalesItemInfos(ByRef rProducts As colProductBases) As colHouseTypeSalesItemInfos
    Dim mTmpHTSalesItems As New colHouseTypeSalesItemInfos
    Dim mHTSIInfo As clsHouseTypeSalesItemInfo

    For Each mHTSI In HouseType.HTSalesItems
      mHTSIInfo = New clsHouseTypeSalesItemInfo(mHTSI, rProducts.ItemFromProductTypeAndID(mHTSI.ProductTypeID, mHTSI.ProductID), HouseType.SalesItemAssemblys.ItemFromKey(mHTSI.HouseTypeSalesItemAssemblyID).Description)
      mTmpHTSalesItems.Add(mHTSIInfo)
    Next

    Return mTmpHTSalesItems
  End Function

  Public Sub RemoveHTSalesOrderItem(rHTSalesItemInfo As clsHouseTypeSalesItemInfo)
    pHouseType.HTSalesItems.Remove(rHTSalesItemInfo.HouseTypeSalesItem)
  End Sub
End Class
