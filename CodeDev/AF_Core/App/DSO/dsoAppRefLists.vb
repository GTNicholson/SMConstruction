Imports RTIS.DataLayer
Imports RTIS.DataLayer.clsDBConnBase
Imports RTIS.CommonVB
Imports RTIS.ERPCore

Public Class dsoAppRefLists
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New()
    pDBConn = rDBConn
  End Sub

  Public Property DBConn() As clsDBConnBase
    Get
      DBConn = pDBConn

    End Get
    Set(ByVal value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Function LoadAllLists(ByRef rRefLists As appRefLists) As Boolean
    Dim mAllOK As Boolean = True
    Dim mItem As clsRefListItem
    Dim mIsNewConnection As Boolean
    Try
      If pDBConn.Connect(mIsNewConnection) Then
        For Each mItem In rRefLists
          mAllOK = LoadAList(rRefLists, mItem.RefListType)
        Next

        'Load the Stock Item Regestry
        AppRTISGlobal.GetInstance.StockItemRegistryInitialise(pDBConn)

        'Load the Product Registry
        AppRTISGlobal.GetInstance.ProductRegistryInitialise(pDBConn)

      Else
        mAllOK = False
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mIsNewConnection Then
        pDBConn.Disconnect()
      End If
    End Try
    Return rRefLists.AllListsLoaded

  End Function

  Public Function LoadAList(ByRef rRefLists As appRefLists, ByVal vRefListType As Integer) As Boolean
    Dim mItem As clsRefListItem
    Dim mOK As Boolean = False
    Dim mValueItems As colValueItems
    ''Dim mRefListItem As clsRefListItem
    mItem = rRefLists.ItemFromKey(vRefListType)
    If Not mItem Is Nothing Then
      Select Case vRefListType
        Case appRefLists.None
          mItem.IList = Nothing
        Case appRefLists.RefList
          mItem.IList = rRefLists
          ''or
          ''mValueItems = New colValueItems
          ''For Each mRefListItem In rRefLists
          ''  mValueItems.AddNewItem(mRefListItem.RefListType, mRefListItem.Description)
          ''Next
          ''mItem.IList = mValueItems
          ''mValueItems = Nothing
        Case appRefLists.YesNo
          mValueItems = New colValueItems
          mValueItems.AddNewItem(0, "No")
          mValueItems.AddNewItem(1, "Yes")
          mItem.IList = mValueItems
          mValueItems = Nothing
          mOK = True

        Case appRefLists.VATRateCodes
          ''mItem.IList = LoadVATList()
          mOK = True

        Case appRefLists.Employees
          mItem.IList = LoadEmployees()
          mOK = True

        Case appRefLists.Roles
          mValueItems = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eEmployeeRole))
          mItem.IList = mValueItems
          mOK = True
        Case appRefLists.Country
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 1", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.BankList
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 2009", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.OrderType
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 2", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.PaymentTermsType
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 4", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.WorkOrderType
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 5", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.WoodSpecie
          mItem.IList = LoadWoodSpecie()
          mOK = True

        Case appRefLists.WoodFinish
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 6", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.SalesTermType
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 7", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.Material
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 8", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.Quality
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 9", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.FurnitureCategory
          mItem.IList = LoadFurnitureCategory()
          mOK = True
        Case appRefLists.Shift
          Dim mDso As dsoProduction
          Dim mShifts As New colShifts
          mDso = New dsoProduction(pDBConn)
          mDso.LoadShiftsDownConnected(mShifts)
          mItem.IList = mShifts

        Case appRefLists.PurchaseTermType
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select Description, value from ValueItem Where ValueItemListID = 10", "Value", "Description")
          mItem.IList = mValueItems

        Case appRefLists.Supplier
          mItem.IList = LoadSupplier()
          mOK = True

        Case appRefLists.ExchangeRate
          mItem.IList = LoadExchangeRate()
          mOK = True

        Case appRefLists.WoodValue
          mItem.IList = LoadWoodValue()
          mOK = True

        Case appRefLists.VATRate
          mItem.IList = LoadVATList()
          mOK = True

        Case appRefLists.HouseType
          mItem.IList = LoadHouseType()
          mOK = True

        Case appRefLists.ProductConstructionSubType
          mItem.IList = LoadProductConstructionSubType()
          mOK = True

        Case appRefLists.ProductConstructionType
          mItem.IList = LoadProductConstructionType()
          mOK = True


        Case appRefLists.Model
          mItem.IList = LoadModelType()
          mOK = True

        Case appRefLists.GroupType
          mItem.IList = LoadGroupType()
          mOK = True

        Case appRefLists.FloorOptions
          mItem.IList = LoadFloorOptions()
          mOK = True

        Case appRefLists.FoundationOptions
          mItem.IList = LoadFoundationOptions()
          mOK = True

        Case appRefLists.WallOptions
          mItem.IList = LoadWallOptions()
          mOK = True

        Case appRefLists.WindowOptions
          mItem.IList = LoadWindowOptions()
          mOK = True

        Case appRefLists.ProductCostBook
          mItem.IList = LoadProductCostBook()
          mOK = True

        Case appRefLists.PurchaseStatus
          mValueItems = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(ePurchaseOrderDueDateStatus))
          mItem.IList = mValueItems
          mOK = True

        Case appRefLists.TransactionType
          mValueItems = RTIS.CommonVB.clsEnumsConstants.EnumToVIs(GetType(eTransactionType))
          mItem.IList = mValueItems
          mOK = True

        Case appRefLists.CostBook

          mItem.IList = LoadCostBook()
          mOK = True

        Case appRefLists.StockItemType
          mValueItems = eStockItemTypeTimberWood.GetInstance.ValueItems
          mItem.IList = mValueItems
          mOK = True

        Case appRefLists.StockItemCategory
          mValueItems = clsEnumsConstants.EnumToVIs(GetType(eStockItemCategory))
          mItem.IList = mValueItems
          mOK = True

        Case appRefLists.AccoutingCategory
          mItem.IList = LoadAccoutingCategory()
          mOK = True

        Case appRefLists.ThicknessValue
          mItem.IList = LoadThicknessValue()
          mOK = True

        Case appRefLists.WoodTypeValue
          mItem.IList = LoadWoodTypeValue()
          mOK = True

        Case appRefLists.FixingSpecies
          mValueItems = New colValueItems
          mOK = pDBConn.LoadValueItems(mValueItems, "Select SpanishDescription, FixingSpeciesID from FixingSpecies Order By DisplayOrder", "FixingSpeciesID", "SpanishDescription")
          mItem.IList = mValueItems

      End Select
      mItem = Nothing
    Else
      mOK = False
    End If
  End Function

  Private Function LoadWoodTypeValue() As IList
    Dim mdto As New dtoWoodTypeValue(pDBConn)
    Dim mRetVal As New colWoodTypeValues

    mdto.LoadWoodTypeValueCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadThicknessValue() As IList
    Dim mdto As New dtoThicknessValue(pDBConn)
    Dim mRetVal As New colThicknessValues

    mdto.LoadThicknessValueCollection(mRetVal)

    Return mRetVal

  End Function

  Private Function LoadAccoutingCategory() As IList
    Dim mdto As New dtoAccoutingCategory(pDBConn)
    Dim mRetVal As New colAccoutingCategorys

    mdto.LoadAccoutingCategoryCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadProductCostBook() As IList
    Dim mdto As New dtoProductCostBook(pDBConn)
    Dim mRetVal As New colProductCostBooks

    mdto.LoadProductCostBookCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadWindowOptions() As IList
    Dim mdto As New dtoWindowOptions(pDBConn)
    Dim mRetVal As New colWindowOptionss

    mdto.LoadWindowOptionsCollection(mRetVal)

    Return mRetVal
  End Function


  Private Function LoadWallOptions() As IList
    Dim mdto As New dtoWallOptions(pDBConn)
    Dim mRetVal As New colWallOptionss

    mdto.LoadWallOptionsCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadFoundationOptions() As IList
    Dim mdto As New dtoFoundationOptions(pDBConn)
    Dim mRetVal As New colFoundationOptionss

    mdto.LoadFoundationOptionsCollection(mRetVal)

    Return mRetVal
  End Function


  Private Function LoadFloorOptions() As IList
    Dim mdto As New dtoFloorOptions(pDBConn)
    Dim mRetVal As New colFloorOptionss

    mdto.LoadFloorOptionsCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadProductConstructionSubType() As IList
    Dim mdto As New dtoProductConstructionSubType(pDBConn)
    Dim mRetVal As New colProductConstructionSubTypes

    mdto.LoadAllProductConstructionSubTypeCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadProductConstructionType() As IList
    Dim mdto As New dtoProductConstructionType(pDBConn)
    Dim mRetVal As New colProductConstructionTypes

    mdto.LoadProductConstructionTypeCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadGroupType() As IList
    Dim mdto As New dtoGroupType(pDBConn)
    Dim mRetVal As New colGroupTypes

    mdto.LoadGroupTypeCollection(mRetVal)

    Return mRetVal
  End Function


  Private Function LoadModelType() As IList
    Dim mdto As New dtoModel(pDBConn)
    Dim mRetVal As New colModels

    mdto.LoadModelCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadHouseType() As IList
    Dim mdto As New dtoHouseType(pDBConn)
    Dim mRetVal As New colHouseTypes

    mdto.LoadHouseTypeCollection(mRetVal)

    Return mRetVal
  End Function

  Public Function LoadEmployees() As IList
    Dim mdtoEmployees As New dtoEmployeeSM(pDBConn)
    Dim mEmployees As New RTIS.ERPCore.colEmployees
    ''Dim mdtoEmployeeSERoles As New dtoEmployeeSERole(pDBConn)

    mdtoEmployees.LoadEmployeeCollection(mEmployees)

    ''For Each mEmployee As RTIS.ERPCore.dmEmployee In mEmployees
    ''  mdtoEmployeeSERoles.LoadEmployeeSERoles(mEmployee.Roles, mEmployee.EmployeeID)
    ''Next

    Return mEmployees
  End Function


  Public Function LoadExchangeRate() As IList
    Dim mdto As New dtoExchangeRate(pDBConn)
    Dim mRetVal As New colExchangeRates

    mdto.LoadExchangeRateCollection(mRetVal)

    Return mRetVal
  End Function

  Public Function LoadWoodValue() As IList
    Dim mdto As New dtoWoodValue(pDBConn)
    Dim mRetVal As New colWoodValues

    mdto.LoadWoodValueCollectionRefList(mRetVal)

    Return mRetVal
  End Function

  Public Function LoadWoodSpecie() As IList
    Dim mdto As New dtoWoodSpecie(pDBConn)
    Dim mRetVal As New colWoodSpecies

    mdto.LoadWoodSpecieCollection(mRetVal)

    Return mRetVal
  End Function

  Public Function LoadSupplier() As IList
    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    Dim mRetValSupplier As New colSuppliers
    mdtoSupplier.LoadSupplierCollectionByWhere(mRetValSupplier, "CompanyName<>''")

    Return mRetValSupplier
  End Function

  Public Function LoadFurnitureCategory() As IList
    Dim mdto As New dtoFurnitureCategory(pDBConn)
    Dim mRetVal As New colFurnitureCategorys

    mdto.LoadFurnitureCategoryCollection(mRetVal)

    Return mRetVal
  End Function

  Private Function LoadVATList() As IList
    Dim mdto As New dtoVATRate(pDBConn)
    Dim mRetVal As New colVATRates

    mdto.LoadVATRateCollection(mRetVal)

    Return mRetVal
  End Function


  Public Function LoadAllListsConnected(ByRef rRefLists As appRefLists) As Boolean
    Dim mAllOK As Boolean = True
    Dim mItem As clsRefListItem

    Try

      If pDBConn.Connect Then
        For Each mItem In rRefLists
          mAllOK = LoadAList(rRefLists, mItem.RefListType)
        Next
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return rRefLists.AllListsLoaded
  End Function

  Public Function LoadCostBook() As IList
    Dim mdto As New dtoCostBook(pDBConn)
    Dim mCol As New colCostBooks

    mdto.LoadCostBookCollection(mCol)

    Return mCol
  End Function

End Class


