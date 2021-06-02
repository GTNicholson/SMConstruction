Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class uccProductBaseDetail
  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pCurrentProductInfo As clsProductBaseInfo
  Private pProductBOMInfos As colProductBOMInfos

  Public Sub New()
    pCurrentProductInfo = New clsProductBaseInfo
    pProductBOMInfos = New colProductBOMInfos
    pCurrentProductInfo.Product = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
  End Sub
  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn
    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
    Set(value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public Property CurrentProductInfo() As clsProductBaseInfo
    Get
      Return pCurrentProductInfo
    End Get
    Set(value As clsProductBaseInfo)
      pCurrentProductInfo = value
    End Set
  End Property

  Public Property ProductBOMInfos As colProductBOMInfos
    Get
      Return pProductBOMInfos
    End Get
    Set(value As colProductBOMInfos)
      pProductBOMInfos = value
    End Set
  End Property

  Public Function SetProductBase(ByRef rProductBase) As Boolean

    Dim mRetVal As Boolean = False
    rProductBase = pCurrentProductInfo.Product

    If rProductBase IsNot Nothing Then

      mRetVal = True
    End If

    Return mRetVal
  End Function

  Public Function CheckCreateStockCodeSave() As Boolean
    Dim mRetval As Boolean
    Dim mProposedCode As String
    If pCurrentProductInfo.Product.Code = "" Then
      mProposedCode = GetProposedCode()

      If mProposedCode <> "" Then
        If MsgBox("¿Crear el código de producto : " & mProposedCode & "?", vbYesNo) = vbYes Then
          pCurrentProductInfo.Product.Code = mProposedCode
        End If
      End If
    End If
    Return mRetval
  End Function

  Public Function GetProposedCode()
    Dim mDSO As dsoProductAdmin
    Dim mStem As String
    Dim mSuffix As Integer
    Dim mRetVal As String = ""

    mStem = clsProductSharedFuncs.GetProductCode(pCurrentProductInfo.Product)
    mDSO = New dsoProductAdmin(pDBConn)
    If mStem <> "" Then
      mSuffix = mDSO.GetNextProductConstructionCodeNo(mStem, pCurrentProductInfo.Product.ProductTypeID)

      mRetVal = mStem & mSuffix.ToString("000")
    End If
    Return mRetVal
  End Function

  Public Sub LoadProductBOMInfos(ByRef rProductBOMInfos As colProductBOMInfos, ByVal vParentID As Integer)
    Dim mdso As New dsoProductAdmin(pDBConn)
    Dim mWhere As String
    mWhere = "ParentID =" & vParentID
    rProductBOMInfos.Clear()
    mdso.LoadProductBOMS(rProductBOMInfos, mWhere)

  End Sub

  Public Sub CreateWoodProductBOM(ByRef rStockItems As List(Of dmStockItem))
    Dim mProductBOM As dmProductBOM
    Dim mProductStructure As dmProductStructure
    Dim mFound As Boolean

    mProductStructure = TryCast(pCurrentProductInfo.Product, dmProductStructure)

    If mProductStructure IsNot Nothing Then

      For Each mSI As dmStockItem In rStockItems
        If mProductStructure.ProductWoodBOMs.IndexFromStockItemID(mSI.StockItemID) = -1 Then
          mProductBOM = New dmProductBOM

          mProductBOM.ObjectType = eProductBOMObjectType.Wood
          mProductBOM.StockItemID = mSI.StockItemID
          mProductBOM.MaterialTypeID = 1
          mProductBOM.UoM = mSI.UoM
          mProductBOM.WoodSpecie = mSI.Species
          mProductBOM.StockCode = mSI.StockCode
          mProductBOM.NetLenght = mSI.Length
          mProductBOM.NetWidth = mSI.Width
          mProductBOM.NetThickness = mSI.Thickness * clsConstants.CMToInches
          mProductBOM.DateChange = Now
          mProductBOM.SupplierStockCode = mSI.PartNo
          mProductBOM.WoodItemType = eStockItemTypeTimberWood.Primera
          mProductStructure.ProductWoodBOMs.Add(mProductBOM)
        End If
      Next

      For mLoop As Integer = mProductStructure.ProductWoodBOMs.Count - 1 To 0 Step -1
        mFound = False
        mProductBOM = mProductStructure.ProductWoodBOMs(mLoop)
        If mProductBOM.StockItemID <> 0 Then '// this leaves the manual ones alone
          For Each mSI As dmStockItem In rStockItems
            If mProductBOM.StockItemID = mSI.StockItemID Then
              mFound = True
              Exit For
            End If
          Next
          If mFound = False Then
            mProductStructure.ProductWoodBOMs.RemoveAt(mLoop)
          End If
        End If
      Next

    End If
  End Sub
  Public Sub CreateStockItemProductBoMProvisional(ByRef rStockItem As dmStockItem)
    Dim mProductBOM As dmProductBOM
    Dim mProductStructure As dmProductStructure
    Dim mFound As Boolean

    mProductStructure = TryCast(pCurrentProductInfo.Product, dmProductStructure)

    If mProductStructure IsNot Nothing Then

      If mProductStructure.ProductStockItemBOMs.IndexFromStockItemID(rStockItem.StockItemID) = -1 Then
        mProductBOM = New dmProductBOM
        mProductBOM.ObjectType = eProductBOMObjectType.StockItems

        mProductBOM.StockItemID = rStockItem.StockItemID
        mProductBOM.Description = rStockItem.Description
        mProductBOM.UoM = rStockItem.UoM
        mProductBOM.WoodSpecie = rStockItem.Species
        mProductBOM.StockCode = rStockItem.StockCode
        mProductBOM.NetLenght = rStockItem.Length
        mProductBOM.NetWidth = rStockItem.Width
        mProductBOM.NetThickness = rStockItem.Thickness
        mProductBOM.DateChange = Now
        mProductBOM.SupplierStockCode = rStockItem.PartNo
        mProductStructure.ProductStockItemBOMs.Add(mProductBOM)
      End If

    End If
  End Sub

  Public Sub CreateStockItemProductBoM(ByRef rStockItems As List(Of dmStockItem))
    Dim mProductBOM As dmProductBOM
    Dim mProductStructure As dmProductStructure
    Dim mFound As Boolean

    mProductStructure = TryCast(pCurrentProductInfo.Product, dmProductStructure)

    If mProductStructure IsNot Nothing Then

      For Each mSI As dmStockItem In rStockItems
        If mProductStructure.ProductStockItemBOMs.IndexFromStockItemID(mSI.StockItemID) = -1 Then
          mProductBOM = New dmProductBOM
          mProductBOM.ObjectType = eProductBOMObjectType.StockItems

          mProductBOM.StockItemID = mSI.StockItemID
          mProductBOM.Description = mSI.Description
          mProductBOM.UoM = mSI.UoM
          mProductBOM.WoodSpecie = mSI.Species
          mProductBOM.StockCode = mSI.StockCode
          mProductBOM.NetLenght = mSI.Length
          mProductBOM.NetWidth = mSI.Width
          mProductBOM.NetThickness = mSI.Thickness
          mProductBOM.DateChange = Now
          mProductBOM.SupplierStockCode = mSI.PartNo
          mProductStructure.ProductStockItemBOMs.Add(mProductBOM)
        End If
      Next

      For mLoop As Integer = mProductStructure.ProductStockItemBOMs.Count - 1 To 0 Step -1
        mFound = False
        mProductBOM = mProductStructure.ProductStockItemBOMs(mLoop)
        If mProductBOM.StockItemID <> 0 Then '// this leaves the manual ones alone
          For Each mSI As dmStockItem In rStockItems
            If mProductBOM.StockItemID = mSI.StockItemID Then
              mFound = True
              Exit For
            End If
          Next
          If mFound = False Then
            mProductStructure.ProductStockItemBOMs.RemoveAt(mLoop)
          End If
        End If
      Next

    End If
  End Sub

  Public Sub ReloadProduct(ByVal vProductID As Integer)
    Dim mdso As dsoProductAdmin
    Try
      mdso = New dsoProductAdmin(pDBConn)
      mdso.LoadProductStructureDown(pCurrentProductInfo.Product, vProductID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Function GetWoodProductBOM() As colProductBOMs
    Dim mProductStructure As dmProductStructure
    Dim mRetVal As New colProductBOMs

    mProductStructure = TryCast(pCurrentProductInfo.Product, dmProductStructure)

    If mProductStructure IsNot Nothing Then

      For Each mPWBOM As dmProductBOM In mProductStructure.ProductWoodBOMs

        If mPWBOM IsNot Nothing Then
          mRetVal.Add(mPWBOM)
        End If
      Next

    End If

    Return mRetVal
  End Function

  Public Function GetStockItemProductBOM() As colProductBOMs
    Dim mProductStructure As dmProductStructure
    Dim mRetVal As New colProductBOMs

    mProductStructure = TryCast(pCurrentProductInfo.Product, dmProductStructure)

    If mProductStructure IsNot Nothing Then

      For Each mPWBOM As dmProductBOM In mProductStructure.ProductStockItemBOMs

        If mPWBOM IsNot Nothing Then
          mRetVal.Add(mPWBOM)
        End If
      Next

    End If

    Return mRetVal
  End Function

  Public Sub ChangeSpeciesForSelectedWoodItems(ByVal vNewSpecies As Integer, ByVal vThickness As Decimal, ByRef rProductBOM As dmProductBOM, ByVal vWoodItemType As Integer)
    Dim mSIOrig As dmStockItem
    Dim mSITemp As dmStockItem
    Dim mSINew As dmStockItem

    mSIOrig = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(rProductBOM.StockItemID)
    mSITemp = mSIOrig.Clone
    mSITemp.Species = vNewSpecies
    mSITemp.Thickness = vThickness
    mSITemp.ItemType = vWoodItemType

    mSINew = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromSameSpec(mSITemp)


    If mSINew Is Nothing Then
      mSINew = mSITemp
      mSINew.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mSINew)
      mSINew.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mSINew, DBConn)
      mSINew.ClearKeys()
      AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mSINew)

    End If

    rProductBOM.StockItemID = mSINew.StockItemID
    rProductBOM.StockCode = mSINew.StockCode
    rProductBOM.WoodSpecie = mSINew.Species
    rProductBOM.WoodItemType = vWoodItemType
    rProductBOM.NetThickness = rProductBOM.NetThickness
    rProductBOM.UoM = mSINew.UoM


  End Sub

  Public Sub ChangeWoodTypeForSelectedWoodItems(ByVal vNewItemType As Integer, ByVal vThickness As Decimal, ByRef rProductBOM As dmProductBOM)
    Dim mSIOrig As dmStockItem
    Dim mSITemp As dmStockItem
    Dim mSINew As dmStockItem

    mSIOrig = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(rProductBOM.StockItemID)
    mSITemp = mSIOrig.Clone
    mSITemp.ItemType = vNewItemType
    mSITemp.Thickness = vThickness

    mSINew = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromSameSpec(mSITemp)


    If mSINew Is Nothing Then
      mSINew = mSITemp
      mSINew.Description = clsStockItemSharedFuncs.GetWoodStockItemProposedDescription(mSINew)
      mSINew.StockCode = clsStockItemSharedFuncs.GetStockCodeStem_New(mSINew, DBConn)
      mSINew.ClearKeys()
      AppRTISGlobal.GetInstance.StockItemRegistry.CreateNewStockItem(mSINew)

    End If

    rProductBOM.StockItemID = mSINew.StockItemID
    rProductBOM.StockCode = mSINew.StockCode
    rProductBOM.WoodSpecie = mSINew.Species
    rProductBOM.WoodItemType = vNewItemType
    rProductBOM.NetThickness = Math.Round(vThickness / clsConstants.CMToInches, 0, MidpointRounding.AwayFromZero)
    rProductBOM.UoM = mSINew.UoM


  End Sub
End Class
