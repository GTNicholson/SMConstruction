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
    Dim mdtoSOI As dtoSalesOrderItem
    Dim mdtoWO As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSOFiles As dtoFileTracker

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrder(pDBConn)
      mdto.SaveSalesOrder(rSalesOrder)

      mdtoSOI = New dtoSalesOrderItem(pDBConn)
      mdtoSOI.SaveSalesOrderItemCollection(rSalesOrder.SalesOrderItems, rSalesOrder.SalesOrderID)

      For Each mSOI As dmSalesOrderItem In rSalesOrder.SalesOrderItems
        mdtoWO = New dtoWorkOrder(pDBConn)
        mdtoWO.SaveWorkOrderCollection(mSOI.WorkOrders, mSOI.SalesOrderItemID)

        '// Ensure any product details are also saved
        For Each mWO As dmWorkOrder In mSOI.WorkOrders
          If mWO.Product IsNot Nothing Then
            mdtoProduct = dtoProductBase.GetNewInstance(mWO.ProductTypeID, pDBConn)
            mdtoProduct.SaveProduct(mWO.Product)
            Select Case mWO.Product.ItemType
              Case eProductType.ProductFurniture
                mWO.ProductID = CType(mWO.Product, dmProductFurniture).ProductFurnitureID
            End Select
          End If
        Next

        'make sure the product id ends up in the work order
        mdtoWO.SaveWorkOrderCollection(mSOI.WorkOrders, mSOI.SalesOrderItemID)

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

  Public Function LoadSalesOrderDown(ByRef rSalesOrder As dmSalesOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder
    Dim mdtoCust As dtoCustomer
    Dim mdtoCustContacts As dtoCustomerContact
    Dim mdtoWOs As dtoWorkOrder
    Dim mdtoSOIs As dtoSalesOrderItem
    Dim mdtoProduct As dtoProductBase
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSOFiles As dtoFileTracker
    Dim mdtoMaterialRequirement As dtoMaterialRequirement
    Dim mdtoWOFiles As dtoFileTracker
    Dim mProdFurniture As dmProductFurniture
    Dim mdtoComponents As dtoProductFurnitureComponent

    pDBConn.Connect()
    mdto = New dtoSalesOrder(pDBConn)
    mdto.LoadSalesOrder(rSalesOrder, vID)


    mdtoCust = New dtoCustomer(pDBConn)
    mdtoCust.LoadCustomer(rSalesOrder.Customer, rSalesOrder.CustomerID)

    mdtoCustContacts = New dtoCustomerContact(pDBConn)
    If rSalesOrder.Customer IsNot Nothing Then
      mdtoCustContacts.LoadCustomerContactCollection(rSalesOrder.Customer.CustomerContacts, rSalesOrder.Customer.CustomerID)
    End If

    mdtoSOIs = New dtoSalesOrderItem(pDBConn)
    mdtoSOIs.LoadSalesOrderItemCollection(rSalesOrder.SalesOrderItems, rSalesOrder.SalesOrderID)


    For Each mSOI As dmSalesOrderItem In rSalesOrder.SalesOrderItems
      mdtoWOs = New dtoWorkOrder(pDBConn)
      mdtoWOs.LoadWorkOrderCollection(mSOI.WorkOrders, mSOI.SalesOrderItemID)

      For Each mWO As dmWorkOrder In mSOI.WorkOrders
        '// Instantiate and Load up the details for the specific product type
        mWO.Product = clsProductSharedFuncs.NewProductInstance(mWO.ProductTypeID)
        If mWO.Product IsNot Nothing Then
          mdtoProduct = dtoProductBase.GetNewInstance(mWO.ProductTypeID, pDBConn)
          mdtoProduct.LoadProduct(mWO.Product, mWO.ProductID)
          mProdFurniture = TryCast(mWO.Product, dmProductFurniture)
          If mProdFurniture IsNot Nothing Then
            mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
            mdtoMaterialRequirement.LoadMaterialRequirementCollection(mProdFurniture.MaterialRequirments, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.Wood)
            mdtoMaterialRequirement.LoadMaterialRequirementCollection(mProdFurniture.MaterialRequirmentOthers, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.Other)
            mdtoComponents = New dtoProductFurnitureComponent(pDBConn)
            mdtoComponents.LoadProductFurnitureComponentCollection(mProdFurniture.ProductFurnitureComponents, mProdFurniture.ProductFurnitureID)
          End If
          mdtoWOFiles = New dtoFileTracker(pDBConn)
          mdtoWOFiles.LoadFileTrackerCollection(mWO.WOFiles, eObjectType.WorkOrder, mWO.WorkOrderID)
          mdtoOutputDocs = New dtoOutputDocument(pDBConn)
          mdtoOutputDocs.LoadOutputDocumentCollection(mWO.OutputDocuments, mWO.WorkOrderID, eParentType.WorkOrder)

        End If
      Next

    Next

    ''mdtoOutputDocs = New dtoOutputDocument(pDBConn)
    ''mdtoOutputDocs.LoadOutputDocumentCollection(rSalesOrder.OutputDocuments, rSalesOrder.SalesOrderID, eParentType.SalesOrder)

    pDBConn.Disconnect()

    mRetVal = True

    Return mRetVal
  End Function


  Public Function LoadWorkOrderDown(ByRef rWorkOrder As dmWorkOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoMaterialRequirement As dtoMaterialRequirement
    Dim mdtoComponents As dtoProductFurnitureComponent

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
        mdtoProduct.LoadProduct(rWorkOrder.Product, rWorkOrder.ProductID)
        mProdFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
        If mProdFurniture IsNot Nothing Then
          mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
          mdtoMaterialRequirement.LoadMaterialRequirementCollection(mProdFurniture.MaterialRequirments, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.Wood)
          mdtoMaterialRequirement.LoadMaterialRequirementCollection(mProdFurniture.MaterialRequirmentOthers, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.Other)
          mdtoComponents = New dtoProductFurnitureComponent(pDBConn)
          mdtoComponents.LoadProductFurnitureComponentCollection(mProdFurniture.ProductFurnitureComponents, mProdFurniture.ProductFurnitureID)
        End If
        mdtoWOFiles = New dtoFileTracker(pDBConn)
        mdtoWOFiles.LoadFileTrackerCollection(rWorkOrder.WOFiles, eObjectType.WorkOrder, rWorkOrder.WorkOrderID)
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
    Dim mdtoComponents As dtoProductFurnitureComponent

    Try
      pDBConn.Connect()
      mdto = New dtoWorkOrder(pDBConn)
      mdto.SaveWorkOrder(rWorkOrder)

      If rWorkOrder.Product IsNot Nothing Then
        mdtoProduct = dtoProductBase.GetNewInstance(rWorkOrder.ProductTypeID, pDBConn)
        mdtoProduct.SaveProduct(rWorkOrder.Product)

        '// Now record the the productID in the workorder in case it was a new product
        If rWorkOrder.ProductID = 0 Then
          rWorkOrder.ProductID = CType(rWorkOrder.Product, dmProductFurniture).ProductFurnitureID
          mdto.SaveWorkOrder(rWorkOrder)
        End If

        mProductFurniture = TryCast(rWorkOrder.Product, dmProductFurniture)
        If mProductFurniture IsNot Nothing Then
          mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
          mdtoMaterialRequirement.SaveMaterialRequirementCollection(mProductFurniture.MaterialRequirments, eProductType.ProductFurniture, mProductFurniture.ProductFurnitureID, eMaterialRequirementType.Wood)
          mdtoMaterialRequirement.SaveMaterialRequirementCollection(mProductFurniture.MaterialRequirmentOthers, eProductType.ProductFurniture, mProductFurniture.ProductFurnitureID, eMaterialRequirementType.Other)
          mdtoComponents = New dtoProductFurnitureComponent(pDBConn)
          mdtoComponents.SaveProductFurnitureComponentCollection(mProductFurniture.ProductFurnitureComponents, mProductFurniture.ProductFurnitureID)
        End If
        mdtoWOFiles = New dtoFileTracker(pDBConn)
        mdtoWOFiles.SaveFileTrackerCollection(rWorkOrder.WOFiles, eObjectType.WorkOrder, rWorkOrder.WorkOrderID)
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

  Public Function LoadSalesOrderItemWithWOs(ByRef rSalesOrderItem As dmSalesOrderItem, vID As Integer) As Boolean
    Dim mdto As dtoSalesOrderItem
    Dim mdtoWO As dtoWorkOrder

    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderItem(pDBConn)
      mdto.LoadSalesOrderItem(rSalesOrderItem, vID)

      mdtoWO = New dtoWorkOrder(pDBConn)
      mdtoWO.LoadWorkOrderCollection(rSalesOrderItem.WorkOrders, rSalesOrderItem.SalesOrderItemID)


      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function SaveSalesOrderItemWithWOs(ByRef rSalesOrderItem As dmSalesOrderItem) As Boolean
    Dim mdto As dtoSalesOrderItem
    Dim mdtoWO As dtoWorkOrder

    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderItem(pDBConn)
      mdto.SaveSalesOrderItem(rSalesOrderItem)

      mdtoWO = New dtoWorkOrder(pDBConn)
      mdtoWO.SaveWorkOrderCollection(rSalesOrderItem.WorkOrders, rSalesOrderItem.SalesOrderItemID)


      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function


  Public Sub RaiseWorkOrderNo(ByRef rSalesOrderItem As dmSalesOrderItem, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    Dim mWONo As Integer
    Dim mWONostr As String = ""
    Dim mdso As dsoGeneral
    Dim mWONoSuffix As Integer = 0

    '// See if the first Work Order Parent Sales Order Item has 

    If rSalesOrderItem.WorkOrders.Count > 0 Then
      mWONostr = rSalesOrderItem.WorkOrders(0).WorkOrderNo
      If mWONostr Is Nothing Then mWONostr = ""
      If mWONostr.Contains("-") Then
        mWONostr = mWONostr.Substring(0, mWONostr.IndexOf("-"))
      End If
    End If

    If mWONostr = "" Then
      mdso = New dsoGeneral(rDBConn)
      mWONo = mdso.GetNextTallyWorkOrderNo()
      mWONostr = clsConstants.WorkOrderNoPrefix & mWONo.ToString("00000")
    End If

    If rSalesOrderItem.WorkOrders.Count = 1 Then
      rSalesOrderItem.WorkOrders(0).WorkOrderNo = mWONostr
    Else
      For Each mWO As dmWorkOrder In rSalesOrderItem.WorkOrders
        mWONoSuffix += 1
        mWO.WorkOrderNo = mWONostr & "-" & mWONoSuffix
      Next
    End If

  End Sub

  Public Function WorkOrderNoFromID(ByVal vID As Integer) As String
    Dim mRetVal As String = ""
    Dim mSQL As String
    Try

      mSQL = "Select WorkOrderNo From WorkOrder Where WorkOrderID = " & vID
      pDBConn.Connect()
      mRetVal = clsGeneralA.DBValueToString(pDBConn.ExecuteScalar(mSQL))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetSalesOrderIDFromWorkOrderID(ByVal vID As Integer) As Integer
    Dim mRetVal As String = ""
    Dim mSQL As String
    Try

      mSQL = "Select SalesOrderItem.SalesOrderID From WorkOrder Inner Join SalesOrderItem on WorkOrder.SalesOrderItemID = SalesOrderItem.SalesOrderItemID Where WorkOrderID = " & vID
      pDBConn.Connect()
      mRetVal = clsGeneralA.DBValueToString(pDBConn.ExecuteScalar(mSQL))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

End Class
