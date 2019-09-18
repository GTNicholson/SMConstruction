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

  Public Function LoadCustomers(ByRef rCustomers As colCustomers) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer

    Try

      pDBConn.Connect()
      mdto = New dtoCustomer(pDBConn)
      mdto.LoadCustomerCollection(rCustomers)

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


  Public Function SaveSalesOrderDown(ByRef rSalesOrder As dmSalesOrder) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder
    Dim mdtoWO As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSOFiles As dtoFileTracker

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrder(pDBConn)
      mdto.SaveSalesOrder(rSalesOrder)

      mdtoWO = New dtoWorkOrder(pDBConn)
      mdtoWO.SaveWorkOrderCollection(rSalesOrder.WorkOrders, rSalesOrder.SalesOrderID)

      '// Ensure any product details are also saved
      For Each mWO As dmWorkOrder In rSalesOrder.WorkOrders
        If mWO.Product IsNot Nothing Then
          mdtoProduct = dtoProductBase.GetNewInstance(mWO.ProductTypeID, pDBConn)
          mdtoProduct.SaveProduct(mWO.Product)

        End If
      Next

      ''mdtoSOFiles = New dtoFileTracker(pDBConn)
      ''mdtoSOFiles.SaveFileTrackerCollection(rSalesOrder.SOFiles, eObjectType.SalesOrder, rSalesOrder.SalesOrderID)
      ''mdtoOutputDocs = New dtoOutputDocument(pDBConn)
      ''mdtoOutputDocs.SaveOutputDocumentCollection(rSalesOrder.OutputDocuments, rSalesOrder.SalesOrderID)


      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadSalesOrderAndCustomer(ByRef rSalesOrder As dmSalesOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder
    Dim mdtoCust As dtoCustomer
    Dim mdtoCustContacts As dtoCustomerContact
    Dim mdtoWOs As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSOFiles As dtoFileTracker

    pDBConn.Connect()
    mdto = New dtoSalesOrder(pDBConn)
    mdto.LoadSalesOrder(rSalesOrder, vID)


    mdtoCust = New dtoCustomer(pDBConn)
    mdtoCust.LoadCustomer(rSalesOrder.Customer, rSalesOrder.CustomerID)

    mdtoCustContacts = New dtoCustomerContact(pDBConn)
    mdtoCustContacts.LoadCustomerContactCollection(rSalesOrder.Customer.CustomerContacts, rSalesOrder.Customer.CustomerID)

    mdtoWOs = New dtoWorkOrder(pDBConn)
    mdtoWOs.LoadWorkOrderCollection(rSalesOrder.WorkOrders, rSalesOrder.SalesOrderID)

    For Each mWO As dmWorkOrder In rSalesOrder.WorkOrders
      '// Instantiate and Load up the details for the specific product type
      mWO.Product = clsProductSharedFuncs.NewProductInstance(mWO.ProductTypeID)
      If mWO.Product IsNot Nothing Then
        mdtoProduct = dtoProductBase.GetNewInstance(mWO.ProductTypeID, pDBConn)
        mdtoProduct.LoadProduct(mWO.Product, mWO.ProductTypeID)
        ''mdtoSOFiles = New dtoFileTracker(pDBConn)
        ''mdtoSOFiles.LoadFileTrackerCollection(rSalesOrder.SOFiles, eObjectType.SalesOrder, rSalesOrder.SalesOrderID)


      End If
    Next

    mdtoOutputDocs = New dtoOutputDocument(pDBConn)
    mdtoOutputDocs.LoadOutputDocumentCollection(rSalesOrder.OutputDocuments, rSalesOrder.SalesOrderID, eParentType.SalesOrder)

    pDBConn.Disconnect()

    mRetVal = True

    Return mRetVal
  End Function


  Public Function LoadWorkOrderDown(ByRef rWorkOrder As dmWorkOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoMaterialRequirement As dtoMaterialRequirement

    Dim mdtoWOFiles As dtoFileTracker
    Dim mProdFurniture As dmProductFurniture
    Dim mdtoOutputDocs As dtoOutputDocument
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





          mdtoWOFiles = New dtoFileTracker(pDBConn)
          mdtoWOFiles.LoadFileTrackerCollection(rWorkOrder.WOFiles, eObjectType.WorkOrder, rWorkOrder.WorkOrderID)
        End If
        mdtoOutputDocs = New dtoOutputDocument(pDBConn)
        mdtoOutputDocs.LoadOutputDocumentCollection(rWorkOrder.OutputDocuments, rWorkOrder.WorkOrderID, eParentType.WorkOrder)
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
    Dim mdtoWOFiles As dtoFileTracker
    Dim mdtoOutputDocs As dtoOutputDocument

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
          mdtoWOFiles = New dtoFileTracker(pDBConn)
          mdtoWOFiles.SaveFileTrackerCollection(rWorkOrder.WOFiles, eObjectType.WorkOrder, rWorkOrder.WorkOrderID)
        End If
        mdtoOutputDocs = New dtoOutputDocument(pDBConn)
        mdtoOutputDocs.SaveOutputDocumentCollection(rWorkOrder.OutputDocuments, rWorkOrder.WorkOrderID)
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
