Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoProductAdmin : Inherits dsoBase

  ''  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Function LoadProductConstructionTypesAll(ByRef rProductConstructionTypes As colProductConstructionTypes) As Boolean
    Dim mdto As dtoProductConstructionType


    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoProductConstructionType(pDBConn)
      mdto.LoadProductConstructionTypeCollection(rProductConstructionTypes)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadProductConstructionSubTypesAll(ByRef rProductConstructionSubTypes As colProductConstructionSubTypes) As Boolean
    Dim mdto As dtoProductConstructionSubType


    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoProductConstructionSubType(pDBConn)
      mdto.LoadAllProductConstructionSubTypeCollection(rProductConstructionSubTypes)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadProductConstructionSubTypesByTypeID(ByRef rProductConstructionSubTypes As colProductConstructionSubTypes, ByVal vProductConstructionItemType As Integer) As Boolean
    Dim mdto As dtoProductConstructionSubType


    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoProductConstructionSubType(pDBConn)
      mdto.LoadProductConstructionSubTypeCollectionByItemTypeID(rProductConstructionSubTypes, vProductConstructionItemType)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
  End Function


  Public Function LoadHouseTypeDown(ByRef rHouseType As dmHouseType, ByVal vHouseTypeID As Integer) As Boolean
    Dim mdto As dtoHouseType
    Dim mdtoSIA As dtoSalesItemAssembly
    Dim mdtoHouseTypeSalesItems As dtoHouseTypeSalesItem

    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoHouseType(pDBConn)
      mdto.LoadHouseType(rHouseType, vHouseTypeID)

      mdtoSIA = New dtoSalesItemAssembly(pDBConn, dtoSalesItemAssembly.eMode.HouseTypeSalesItemAssembly)
      mdtoSIA.LoadSalesItemAssemblyCollection(rHouseType.SalesItemAssemblys, rHouseType.HouseTypeID)

      mdtoHouseTypeSalesItems = New dtoHouseTypeSalesItem(pDBConn)
      mdtoHouseTypeSalesItems.LoadHouseTypeSalesItemsCollection(rHouseType.HTSalesItems, rHouseType.HouseTypeID)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
  End Function

  Public Function SaveHouseTypeDown(ByRef rHouseType As dmHouseType) As Boolean
    Dim mdto As dtoHouseType
    Dim mdtoSIA As dtoSalesItemAssembly
    Dim mdtoHouseTypeSalesItems As dtoHouseTypeSalesItem
    Dim mRetVal As Boolean = False
    Try
      pDBConn.Connect()
      mdto = New dtoHouseType(pDBConn)
      mdto.SaveHouseType(rHouseType)

      mdtoSIA = New dtoSalesItemAssembly(pDBConn, dtoSalesItemAssembly.eMode.HouseTypeSalesItemAssembly)
      mdtoSIA.SaveSalesItemAssemblyCollection(rHouseType.SalesItemAssemblys, rHouseType.HouseTypeID)

      mdtoHouseTypeSalesItems = New dtoHouseTypeSalesItem(pDBConn)

      mdtoHouseTypeSalesItems.SaveHouseTypeSalesItemsCollection(rHouseType.HTSalesItems, rHouseType.HouseTypeID)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Connect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadHouseTypeInfos(ByRef rHouseTypeInfos As colHouseTypeInfos) As Boolean
    Dim mdto As dtoHouseTypeInfo
    Dim mRetval As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoHouseTypeInfo(pDBConn)
      mdto.LoadHouseTypeInfoCollectionByWhere(rHouseTypeInfos, "")

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetval
  End Function


  Public Function LockHouseTypeDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.LockTableRecord(appLockEntitys.cCustomer, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function UnlockHouseTypeDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.UnlockTableRecord(appLockEntitys.cCustomer, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function
  Public Function GetNextProductConstructionCodeNo(ByVal vProductCode As String, ByVal vProductType As Integer) As Integer
    Dim mRetVal As Integer

    Try

      pDBConn.Connect()
      mRetVal = GetNextProductCodeNoConnected(vProductCode, vProductType)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Sub LoadHouseTypes(ByRef rHouseTypes As colHouseTypes)
    Try
      Dim mdto As New dtoHouseType(pDBConn)
      pDBConn.Connect()
      mdto.LoadHouseTypeCollection(rHouseTypes)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Function SaveProductBase(ByRef rProductBase As clsProductBaseInfo) As Boolean
    Dim mdtoProductBase As dtoProductBase
    Dim mdtoStockItemBOM As dtoStockItemBOM
    Dim mdtoProductBOM As dtoProductBOM
    Try
      pDBConn.Connect()

      If rProductBase.Product IsNot Nothing Then
        mdtoProductBase = dtoProductBase.GetNewInstance(rProductBase.Product.ProductTypeID, pDBConn)

        mdtoStockItemBOM = New dtoStockItemBOM(pDBConn)


        mdtoProductBase.SaveProduct(rProductBase.Product)

        If rProductBase.Product IsNot Nothing Then
          mdtoProductBOM = New dtoProductBOM(pDBConn)
          mdtoProductBOM.SaveProductBOMCollection(rProductBase.Product.ProductBOMs, rProductBase.Product.ID)

        End If
        mdtoStockItemBOM.SaveStockItemBOMCollection(rProductBase.Product.StockItemBOMs, rProductBase.Product.ID)
      End If



    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Function

  Public Sub LoadProductInfosByWhere(ByRef rProductInfos As colProductBaseInfos, ByVal vWhere As String)
    Dim mdto As dtoProductInfo
    Try
      pDBConn.Connect()

      mdto = New dtoProductInfo(pDBConn, dtoProductInfo.eMode.Installation)
      mdto.LoadProductInfosCollection(rProductInfos)

      mdto = New dtoProductInfo(pDBConn, dtoProductInfo.eMode.AFStructure)
      mdto.LoadProductInfosCollection(rProductInfos)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadProductInfosStructureOnly(ByRef rProductInfos As colProductBaseInfos)
    Dim mdto As dtoProductInfo
    Try
      pDBConn.Connect()

      mdto = New dtoProductInfo(pDBConn, dtoProductInfo.eMode.AFStructure)
      mdto.LoadProductInfosCollection(rProductInfos)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub
  Public Sub LoadProductInstallations(ByRef rProducts As colProductBases)
    Dim mdtoInstallation As dtoProductInstallation
    Dim mProductInstallations As New colProductInstallations
    Try
      pDBConn.Connect()

      mdtoInstallation = New dtoProductInstallation(pDBConn)
      mdtoInstallation.LoadProductInstallationCollection(mProductInstallations)

      For Each mProduct As dmProductBase In mProductInstallations
        rProducts.Add(mProduct)
      Next


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadProductStructures(ByRef rProducts As colProductBases)
    Dim mdtoProductStructure As dtoProductStructure
    Dim mProductStructures As New colProductStructures
    Try
      pDBConn.Connect()

      mdtoProductStructure = New dtoProductStructure(pDBConn)
      mdtoProductStructure.LoadProductStructureCollection(mProductStructures)

      For Each mProduct As dmProductBase In mProductStructures
        rProducts.Add(mProduct)
      Next


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadProductBOMS(ByRef rProductBOMInfos As colProductBOMInfos, ByVal vWhere As String)
    Dim mdto As dtoProductBOMInfo
    Try
      pDBConn.Connect()

      mdto = New dtoProductBOMInfo(pDBConn)
      mdto.LoadProductBOMInfoCollectionByWhere(rProductBOMInfos, vWhere)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function GetNextProductCodeNoConnected(ByVal vProductCode As String, ByVal vProductType As Integer) As Integer
    Dim mReader As IDataReader
    Dim mSQL As String = ""
    Dim mRetVal As Integer = -1
    Dim mExistingCode As String
    Dim mLastDotPos As Integer
    Try

      Select Case vProductType
        Case eProductType.ProductInstallation
          mSQL = "Select Top 1 Code from ProductInstallation where Code Like '" & vProductCode & "%' Order By Code Desc"

        Case eProductType.StructureAF
          mSQL = "Select Top 1 Code from ProductStructure where Code Like '" & vProductCode & "%' Order By Code Desc"

      End Select

      If mSQL <> "" Then
        mReader = pDBConn.LoadReader(mSQL)
        If mReader.Read Then
          mExistingCode = RTIS.DataLayer.clsDBConnBase.DBReadString(mReader, "Code")
          mLastDotPos = mExistingCode.LastIndexOf(".")
          If mLastDotPos <> -1 And mExistingCode.Length >= mLastDotPos + 1 Then
            mRetVal = Val(mExistingCode.Substring(mLastDotPos + 1)) + 1
          Else
            '// invalid code
            mRetVal = -1
          End If
        Else
          mRetVal = 1
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mReader IsNot Nothing Then
        If mReader.IsClosed = False Then mReader.Close()
        mReader.Dispose()
        mReader = Nothing
      End If
    End Try
    Return mRetVal
  End Function

  Public Sub LoadProductCostDown(ByRef rProductCostBook As dmProductCostBook, ByVal vProductCostBookID As Integer)
    Dim mdtoProductCostBook As dtoProductCostBook
    Dim mdtoProductCostBookEntry As dtoProductCostBookEntry
    Try

      pDBConn.Connect()
      mdtoProductCostBook = New dtoProductCostBook(pDBConn)

      mdtoProductCostBook.LoadProductCostBook(rProductCostBook, vProductCostBookID)

      If rProductCostBook IsNot Nothing Then

        mdtoProductCostBookEntry = New dtoProductCostBookEntry(pDBConn)

        mdtoProductCostBookEntry.LoadProductCostBookEntryCollection(rProductCostBook.ProductCostBookEntrys, vProductCostBookID)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Function LoadHouseType(ByRef rHouseType As dmHouseType, ByVal vHouseTypeID As Integer) As Boolean
    Dim mdto As New dtoHouseType(DBConn)
    Dim mOK As Boolean
    Try
      pDBConn.Connect()

      mOK = mdto.LoadHouseType(rHouseType, vHouseTypeID)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LoadStockItemBOM(ByRef rStockItemBOMs As colStockItemBOMs, ByVal vProductID As Integer) As Boolean
    Dim mdto As New dtoStockItemBOM(DBConn)
    Dim mOK As Boolean
    Try
      pDBConn.Connect()

      mOK = mdto.LoadStockItemBOMCollection(rStockItemBOMs, vProductID)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function
End Class
