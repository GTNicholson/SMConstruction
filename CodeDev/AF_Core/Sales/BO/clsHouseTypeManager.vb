﻿Imports RTIS.DataLayer
Imports RTIS.ProductCore

Public Class clsHouseTypeManager
  Private pHouseType As dmHouseType
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rHouseType As dmHouseType, ByRef rDBConn As clsDBConnBase)
    pHouseType = rHouseType
    pDBConn = rDBConn
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
    mSalesItem.ProductConstructionType = rProduct.ItemType
    mSalesItem.HouseTypeSalesItemAssemblyID = rSalesItemAssembly.SalesItemAssemblyID
    mSalesItem.Description = rProduct.Description
    If rProductCostBook IsNot Nothing Then
      mCostBookEntryIndex = rProductCostBook.ProductCostBookEntrys.IndexFromProductID_ItemTypeID(rProduct.ID, rProduct.ProductTypeID)

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

  Public Function GetTotalHTSalesItemInfos(ByRef rProducts As colProductBases, ByRef rProductCostBookEntry As colProductCostBookEntrys) As colHouseTypeSalesItemInfos
    Dim mTmpHTSalesItems As New colHouseTypeSalesItemInfos
    Dim mHTSIInfo As clsHouseTypeSalesItemInfo
    Dim mCBE As dmProductCostBookEntry
    Dim mProductBase As dmProductBase

    Dim mProductConstructionTypes As New colProductConstructionTypes
    Dim mProductConstructionSubTypes As New colProductConstructionSubTypes
    Dim mdso As New dsoProductAdmin(pDBConn)

    mdso.LoadProductConstructionTypesAll(mProductConstructionTypes)
    mdso.LoadProductConstructionSubTypesAll(mProductConstructionSubTypes)

    For Each mHTSI In HouseType.HTSalesItems
      If EvaluateCondition(mHTSI.ConditionString) = True Then

        mProductBase = rProducts.ItemFromProductTypeAndID(mHTSI.ProductTypeID, mHTSI.ProductID)

        If mProductBase IsNot Nothing Then
          mHTSIInfo = New clsHouseTypeSalesItemInfo(mHTSI, mProductBase, HouseType.SalesItemAssemblys.ItemFromKey(mHTSI.HouseTypeSalesItemAssemblyID).Description)
          mCBE = New dmProductCostBookEntry
          mCBE = rProductCostBookEntry.ItemFromProductID_ItemTypeID(mProductBase.ID, mProductBase.ProductTypeID)

          If mCBE IsNot Nothing Then
            mHTSIInfo.Cost = mCBE.Cost
            mHTSIInfo.DirectLabourCost = mCBE.DirectLabourCost
            mHTSIInfo.DirectMaterialCost = mCBE.DirectMaterialCost
            mHTSIInfo.DirectTransportationAndEquipment = mCBE.DirectTransportationAndEquipment
            mHTSIInfo.OutsourcingCost = mCBE.OutsourcingCost

          Else
            mHTSIInfo.Cost = 0
            mHTSIInfo.DirectLabourCost = 0
            mHTSIInfo.DirectMaterialCost = 0
            mHTSIInfo.DirectTransportationAndEquipment = 0
            mHTSIInfo.OutsourcingCost = 0
          End If

          mTmpHTSalesItems.Add(mHTSIInfo)

        End If
      End If
    Next

    Return mTmpHTSalesItems
  End Function

  Public Function EvaluateCondition(ByVal vConditionString As String) As Boolean
    Dim mCond As uctConditionFilter
    Dim mCondition As clsCondition
    Dim mRetVal As Boolean

    ' Initialise the condition
    mCond = New uctConditionFilter
    mCond.SetUp(AppRTISGlobal.GetInstance.RefLists, Nothing)
    mCondition = New clsCondition(eNodeTypes.eNT_Container)
    mCond.RefreshControl(mCondition, New clsHouseTypePropertyDef(pHouseType))
    'IF going to evaluate many instances in a list/collection then best if just instantiate this once for each rule in the class it get used in, for performance reasons, e.g. have a property on the editor class


    'Check the condition
    If Not String.IsNullOrWhiteSpace(vConditionString) Then
      mCond.SetFilterString(vConditionString)
      mCond.GetUpdatedConditionFilter(mCondition)
      If mCondition Is Nothing OrElse mCondition.EvaluateNode(New clsHouseTypePropertyDef(pHouseType), Nothing) Then
        mRetVal = True
      Else
        mRetVal = False
      End If
    Else
      mRetVal = True
    End If

    Return mRetVal

  End Function


  Public Sub RemoveHTSalesOrderItem(rHTSalesItemInfo As clsHouseTypeSalesItemInfo)
    pHouseType.HTSalesItems.Remove(rHTSalesItemInfo.HouseTypeSalesItem)
  End Sub
End Class
