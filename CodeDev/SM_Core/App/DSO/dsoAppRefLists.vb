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

      End Select
      mItem = Nothing
    Else
      mOK = False
    End If
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
    Dim mdto As New dtoFurnitureCategory(pDBConn)
    Dim mRetVal As New colFurnitureCategorys

    mdto.LoadFurnitureCategoryCollection(mRetVal)

    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    Dim mRetValSupplier As New colSuppliers
    mdtoSupplier.LoadSupplierCollection(mRetValSupplier)

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


End Class


