Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoSales : Inherits dsoBase
  ''  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Function LoadWorkOrderDT(ByRef rDT As DataTable, Optional ByVal vWhereStr As String = "") As Boolean
    Dim mSQL As String
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mSQL = " select * from workorder"

      If vWhereStr.Length > 0 Then
        mSQL = mSQL & vWhereStr
      End If

      rDT = pDBConn.CreateDataTable(mSQL)
      mOK = True
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LockCustomerDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
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

  Public Function UnlockCustomerDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
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

  Public Function LoadInvoiceDown(ByRef rInvoice As dmInvoice, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoice
    Dim mdtoInvoiceItem As dtoInvoiceItem

    Try

      pDBConn.Connect()
      mdto = New dtoInvoice(pDBConn)
      mdto.LoadInvoice(rInvoice, vID)
      mdtoInvoiceItem = New dtoInvoiceItem(pDBConn)
      mdtoInvoiceItem.LoadInvoiceItemCollection(rInvoice.InvoiceItems, rInvoice.InvoiceID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function



  Public Function LoadSalesOrderProgressInfos(ByRef rSalesOrderProgressInfos As colSalesOrderProgressInfos, ByVal vWhere As String) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderProgressInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderProgressInfo(pDBConn)
      mdto.LoadSalesOrderProgressCollection(rSalesOrderProgressInfos, vWhere)
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

  Public Function LoadInvoices(ByRef rInvoices As colInvoices, ByVal vParentId As Int32) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoice

    Try

      pDBConn.Connect()
      mdto = New dtoInvoice(pDBConn)
      mdto.LoadInvoiceCollection(rInvoices, vParentId)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadInvoiceInfos(ByRef rInvoiceInfos As colInvoiceInfos) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoiceInfo

    Try

      pDBConn.Connect()
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Invoice)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, "")

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadInvoiceInfosGraph(ByRef rInvoiceInfos As colInvoiceInfos) As Boolean
    Dim mdto As dtoInvoiceInfo
    Dim mSQLWhere1 As String
    Dim mSQLWhere2 As String
    Dim mSQLWhere As String = ""
    Dim mMonth As Integer = 0
    Dim mYear As Int32 = 0
    Dim mStartDate As Date
    Dim mEndDate As Date

    mMonth = Now.Month

    If mMonth < 6 Then
      mYear = Now.Year - 1
      mMonth = mMonth + 7 ''the last 6 months

      mStartDate = New Date(mYear, mMonth, 1)


    Else
      mYear = Now.Year
      mMonth = Now.Month - 5

      mStartDate = New Date(mYear, mMonth, 1)

    End If

    mEndDate = New Date(Now.Year, Now.Month, Now.Day)


    Try



      pDBConn.Connect()
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Invoice)

      mSQLWhere1 = "InvoiceDate >= '" & mStartDate.ToString("yyyy/MM/dd") & "'"
      mSQLWhere2 = "InvoiceDate <= '" & mEndDate.ToString("yyyy/MM/dd") & "'"

      mSQLWhere = mSQLWhere1
      If mSQLWhere <> "" And mSQLWhere2 <> "" Then mSQLWhere = mSQLWhere & " And "
      mSQLWhere = mSQLWhere & mSQLWhere2

      If mSQLWhere <> "" Then mSQLWhere = "(" & mSQLWhere & ") And "
      mSQLWhere = mSQLWhere & "InvoiceDate Is Not Null"


      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)

      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Packed)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Engineered)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Pending)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
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

  Public Function SaveInvoiceDown(ByRef rInvoice As dmInvoice) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoice
    Dim mdtoInvoiceItem As dtoInvoiceItem

    Try

      pDBConn.Connect()
      mdto = New dtoInvoice(pDBConn)
      mdto.SaveInvoice(rInvoice)
      mdtoInvoiceItem = New dtoInvoiceItem(pDBConn)
      mdtoInvoiceItem.SaveInvoiceItemCollection(rInvoice.InvoiceItems, rInvoice.InvoiceID)

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
    Dim mdtoInvoices As dtoInvoice
    Dim mdtoCustomerPurchaseOrder As dtoCustomerPurchaseOrder
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSOFiles As dtoFileTracker

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrder(pDBConn)
      mdto.SaveSalesOrder(rSalesOrder)

      mdtoSOI = New dtoSalesOrderItem(pDBConn)
      mdtoSOI.SaveSalesOrderItemCollection(rSalesOrder.SalesOrderItems, rSalesOrder.SalesOrderID)

      mdtoInvoices = New dtoInvoice(pDBConn)
      mdtoInvoices.SaveInvoiceCollection(rSalesOrder.Invoices, rSalesOrder.SalesOrderID)

      mdtoCustomerPurchaseOrder = New dtoCustomerPurchaseOrder(pDBConn)
      mdtoCustomerPurchaseOrder.SaveCustomerPurchaseOrderCollection(rSalesOrder.CustomerPurchaseOrder, rSalesOrder.SalesOrderID)

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
      mdtoOutputDocs = New dtoOutputDocument(pDBConn)
      mdtoOutputDocs.SaveOutputDocumentCollection(rSalesOrder.OutputDocuments, rSalesOrder.SalesOrderID)


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
    Dim mdtoInvoice As dtoInvoice
    Dim mdtoCustomerPurchaseOrder As dtoCustomerPurchaseOrder
    Dim mdtoSOIs As dtoSalesOrderItem
    Dim mdtoProduct As dtoProductBase
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSOFiles As dtoFileTracker
    Dim mdtoMaterialRequirement As dtoMaterialRequirement


    Dim mdtoMaterialRequirementChanges As dtoMaterialRequirement


    Dim mdtoWOFiles As dtoFileTracker
    Dim mProdFurniture As dmProductFurniture
    Dim mdtoComponents As dtoProductFurnitureComponent

    pDBConn.Connect()
    mdto = New dtoSalesOrder(pDBConn)
    mdto.LoadSalesOrder(rSalesOrder, vID)

    mdtoInvoice = New dtoInvoice(pDBConn)
    mdtoInvoice.LoadInvoiceCollection(rSalesOrder.Invoices, rSalesOrder.SalesOrderID)

    mdtoCust = New dtoCustomer(pDBConn)
    mdtoCust.LoadCustomer(rSalesOrder.Customer, rSalesOrder.CustomerID)

    mdtoCustContacts = New dtoCustomerContact(pDBConn)
    If rSalesOrder.Customer IsNot Nothing Then
      mdtoCustContacts.LoadCustomerContactCollection(rSalesOrder.Customer.CustomerContacts, rSalesOrder.Customer.CustomerID)
    End If

    mdtoSOIs = New dtoSalesOrderItem(pDBConn)
    mdtoSOIs.LoadSalesOrderItemCollection(rSalesOrder.SalesOrderItems, rSalesOrder.SalesOrderID)

    mdtoCustomerPurchaseOrder = New dtoCustomerPurchaseOrder(pDBConn)
    mdtoCustomerPurchaseOrder.LoadCustomerPurchaseOrderCollection(rSalesOrder.CustomerPurchaseOrder, rSalesOrder.SalesOrderID)


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

            mdtoMaterialRequirementChanges = New dtoMaterialRequirement(pDBConn)
            mdtoMaterialRequirementChanges.LoadMaterialRequirementCollectionChanges(mProdFurniture.MaterialRequirmentsChanges, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.WoodChanges)
            mdtoMaterialRequirementChanges.LoadMaterialRequirementCollectionChanges(mProdFurniture.MaterialRequirmentOthersChanges, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.OtherChanges)


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

          mdtoMaterialRequirement.LoadMaterialRequirementCollectionChanges(mProdFurniture.MaterialRequirmentsChanges, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.WoodChanges)
          mdtoMaterialRequirement.LoadMaterialRequirementCollectionChanges(mProdFurniture.MaterialRequirmentOthersChanges, eProductType.ProductFurniture, mProdFurniture.ProductFurnitureID, eMaterialRequirementType.OtherChanges)

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

  Public Function LoadWorkOrder(ByRef rWorkOrder As dmWorkOrder, ByVal vWorkOrderID As Integer) As Boolean
    Dim mOk As Boolean

    Try

      If pDBConn.Connect Then
        Dim mdtoWorkOrder As New dtoWorkOrder(pDBConn)

        mOk = mdtoWorkOrder.LoadWorkOrder(rWorkOrder, vWorkOrderID)

        mdtoWorkOrder = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
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

          mdtoMaterialRequirement.SaveMaterialRequirementCollectionChanges(mProductFurniture.MaterialRequirmentsChanges, eProductType.ProductFurniture, mProductFurniture.ProductFurnitureID, eMaterialRequirementType.WoodChanges)
          mdtoMaterialRequirement.SaveMaterialRequirementCollectionChanges(mProductFurniture.MaterialRequirmentOthersChanges, eProductType.ProductFurniture, mProductFurniture.ProductFurnitureID, eMaterialRequirementType.OtherChanges)


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

  Public Function LoadWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String, ByVal vMode As dtoWorkOrderInfo.eMode) As Boolean
    Dim mdto As dtoWorkOrderInfo
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, vMode)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, vWhere)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadInternalWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdto As dtoWorkOrderInfo
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, dtoWorkOrderInfo.eMode.WorkOrderInfoInternal)
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


  Public Sub RaiseWorkOrderNo(ByRef rSalesOrderItem As dmSalesOrderItem, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vSalesOrderNo As String)
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
        mWO.SalesOrderItemWOIndex = mWONoSuffix
        mWO.SOWONumber = vSalesOrderNo & "-" & rSalesOrderItem.ItemNumber & "-" & mWONoSuffix
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
