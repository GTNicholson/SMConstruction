Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoSales
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub


  Public Function LoadCustomerDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer
    Dim mdtoCC As dtoCustomerContact

    Try

      pDBConn.Connect()
      mdto = New dtoCustomer(pDBConn)
      mdto.LoadCustomer(rCustomer, vID)
      mdtoCC = New dtoCustomerContact(pDBConn)
      mdtoCC.LoadCustomerContactCollection(rCustomer.CustomerContacts, rCustomer.CustomerID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SaveCustomerDown(ByRef rCustomer As dmCustomer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer
    Dim mdtoCC As dtoCustomerContact

    Try

      pDBConn.Connect()
      mdto = New dtoCustomer(pDBConn)
      mdto.SaveCustomer(rCustomer)
      mdtoCC = New dtoCustomerContact(pDBConn)
      mdtoCC.SaveCustomerContactCollection(rCustomer.CustomerContacts, rCustomer.CustomerID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadSalesOrderDown(ByRef rSalesOrder As dmSalesOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder

    pDBConn.Connect()
    mdto = New dtoSalesOrder(pDBConn)
    mdto.LoadSalesOrder(rSalesOrder, vID)

    pDBConn.Disconnect()
    mRetVal = True

    Return mRetVal
  End Function
  Public Function LoadSalesOrderDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
    'Dim mRetVal As Boolean
    'Dim mdto As dtoCustomer

    'pDBConn.Connect()
    'mdto = New dtoCustomer(pDBConn)
    'mdto.LoadCustomer(rCustomer, vID)

    'pDBConn.Disconnect()
    'mRetVal = True

    'Return mRetVal
  End Function


  Public Function LoadWorkOrderDown(ByRef rWorkOrder As dmWorkOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoMaterialRequirement As dtoMaterialRequirement
    Dim mProdFurniture As dmProductFurniture
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrder(pDBConn)
      mdto.LoadWorkOrder(rWorkOrder, vID)

      '// Instantiate and Load up the details for the specific product type
      rWorkOrder.Product = clsProductSharedFuncs.NewProductInstance(rWorkOrder.ProductTypeID)
      If rWorkOrder.Product IsNot Nothing Then
        mdtoProduct = dtoProductBase.GetNewInstance(rWorkOrder.ProductTypeID, pDBConn)
        mdtoProduct.LoadProduct(rWorkOrder.Product, rWorkOrder.ProductTypeID)
        mProdFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
        If mProdFurniture IsNot Nothing Then
          mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
          mdtoMaterialRequirement.LoadMaterialRequirementCollection(mProdFurniture.MaterialRequirments, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID)
        End If

      End If

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Function SaveWorkOrderDown(ByRef rWorkOrder As dmWorkOrder) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoMaterialRequirement As dtoMaterialRequirement
    Dim mProductFurniture As dmProductFurniture

    Try
      pDBConn.Connect()
      mdto = New dtoWorkOrder(pDBConn)
      mdto.SaveWorkOrder(rWorkOrder)

      If rWorkOrder.Product IsNot Nothing Then
        mdtoProduct = dtoProductBase.GetNewInstance(rWorkOrder.ProductTypeID, pDBConn)
        mdtoProduct.SaveProduct(rWorkOrder.Product)
        mProductFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
        If mProductFurniture IsNot Nothing Then
          mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
          mdtoMaterialRequirement.SaveMaterialRequirementCollection(mProductFurniture.MaterialRequirments, eProductType.ProductFurniture, mProductFurniture.ProductFurnitureID)
        End If
      End If

      pDBConn.Disconnect()
      mRetVal = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Function

  Public Function LoadWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdto As dtoWorkOrderInfo
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, dtoWorkOrderInfo.eMode.WorkOrderInfo)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, vWhere)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function



End Class
