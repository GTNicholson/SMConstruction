Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class clsSalesOrderHandler
  Private pSalesOrder As dmSalesOrder
  Private pInvoice As dmInvoice
  Private pDBConn As clsDBConnBase

  Public Shared Function CreateNewSalesOrder() As dmSalesOrder
    Dim mSO As dmSalesOrder
    Dim mSOP As dmSalesOrderPhase

    mSO = New dmSalesOrder
    mSO.OrderPhaseType = eOrderPhaseType.SinglePhase
    mSO.DateEntered = Now
    mSOP = New dmSalesOrderPhase
    mSO.SalesOrderPhases.Add(mSOP)
    Return mSO
  End Function



  Public Sub New(ByRef rSalesOrder As dmSalesOrder)
    pSalesOrder = rSalesOrder

  End Sub

  Public Sub New(ByRef rInvoice As dmInvoice)
    pInvoice = rInvoice

  End Sub

  Public Function AddInvoiceSalesOrderItem() As dmInvoiceItem
    Dim mNewInvoiceSOI As dmInvoiceItem = Nothing
    Try
      mNewInvoiceSOI = New dmInvoiceItem
      mNewInvoiceSOI.InvoiceID = pInvoice.InvoiceID


      ''mNewSOI.ItemNumber = pSalesOrder.SalesOrderItems.GetNextItemNumber
      pInvoice.InvoiceItems.Add(mNewInvoiceSOI)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewInvoiceSOI
  End Function

  Public Function AddSalesOrderItem(ByVal vProductType As eProductType) As dmSalesOrderItem
    Dim mNewSOI As dmSalesOrderItem = Nothing
    Try
      mNewSOI = New dmSalesOrderItem
      mNewSOI.SalesOrderID = pSalesOrder.SalesOrderID
      mNewSOI.UoM = eUoM.GLB
      ''mNewSOI.ItemNumber = pSalesOrder.SalesOrderItems.GetNextItemNumber

      'AddWorkOrder(mNewSOI, vProductType)

      pSalesOrder.SalesOrderItems.Add(mNewSOI)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewSOI
  End Function

  Public Function AddWorkOrder(ByRef rSOI As dmSalesOrderItem, ByVal vProductType As eProductType) As dmWorkOrder
    Dim mNewWO As dmWorkOrder = Nothing
    Dim mWOHandler As clsWorkOrderHandler

    Try
      mNewWO = New dmWorkOrder
      mNewWO.SalesOrderID = pSalesOrder.SalesOrderID
      mNewWO.ProductTypeID = vProductType
      mNewWO.DateCreated = Now.Date
      mNewWO.Product = clsProductSharedFuncs.NewProductInstance(mNewWO.ProductTypeID)

      rSOI.WorkOrders.Add(mNewWO)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mNewWO
  End Function

  Public Sub RemoveWorkOrder(ByRef rWorkOrder As dmWorkOrder)
    Try
      For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems
        If mSOI.WorkOrders.Contains(rWorkOrder) Then
          mSOI.WorkOrders.Remove(rWorkOrder)
        End If
      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub RemoveSalesOrderItem(ByRef rSalesOrderItem As dmSalesOrderItem)
    Try
      pSalesOrder.SalesOrderItems.Remove(rSalesOrderItem)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub RemoveInvoiceSalesOrderItem(ByRef rInvoiceSalesOrderItem As dmInvoiceItem)
    Try
      pInvoice.InvoiceItems.Remove(rInvoiceSalesOrderItem)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Function GetTotalValue() As Decimal
    Dim mRetVal As Decimal
    For Each mSalesOrderOrderItem In pSalesOrder.SalesOrderItems
      mRetVal = mRetVal + (mSalesOrderOrderItem.Quantity * mSalesOrderOrderItem.UnitPrice)

    Next
    Return mRetVal
  End Function

  Public Function GetCostShipping() As Decimal
    Return pSalesOrder.ShippingCost
  End Function


  Public Sub AddProducts(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProducts As List(Of clsProductBaseInfo))
    For Each mProduct As clsProductBaseInfo In rProducts
      AddProduct(rSalesItemAssembly, mProduct)
    Next

  End Sub

  Public Sub AddProduct(ByRef rSalesItemAssembly As dmSalesItemAssembly, ByRef rProduct As clsProductBaseInfo)
    Dim mSalesItem As dmSalesOrderItem
    mSalesItem = New dmSalesOrderItem
    mSalesItem.SalesOrderID = pSalesOrder.SalesOrderID
    mSalesItem.ProductID = rProduct.ID
    mSalesItem.ProductTypeID = rProduct.ProductTypeID
    mSalesItem.SalesItemAssemblyID = rSalesItemAssembly.SalesItemAssemblyID
    mSalesItem.Description = rProduct.Description
    pSalesOrder.SalesOrderItems.Add(mSalesItem)

  End Sub


  Public Sub CreateSalesItemsFromHouseTypeConfig(ByRef rTargetSalesOrderHouse As dmSalesOrderHouse, ByRef rConfiguredHouseType As dmHouseType, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vProductCostBookID As Integer)
    Dim mDict As New Dictionary(Of Integer, dmSalesItemAssembly)
    Dim mSOSIA As dmSalesItemAssembly
    Dim mdso As dsoSales
    Dim mProducts As colProductBases
    Dim mHTSIIs As colHouseTypeSalesItemInfos
    Dim mSalesItem As dmSalesOrderItem
    Dim mHouseTypeManager As clsHouseTypeManager
    Dim mProductCost As New dmProductCostBook
    Dim mdsoCB As New dsoProductAdmin(rDBConn)
    Dim mSOPI As dmSalesOrderPhaseItem

    pSalesOrder.ProductCostBookID = vProductCostBookID
    mdsoCB.LoadProductCostDown(mProductCost, pSalesOrder.ProductCostBookID)

    mdso = New dsoSales(rDBConn)

    '// Create the SalesItemAssembleys first
    '// and Make a dictionary of oldID to new SalesItem
    For Each mSIA As dmSalesItemAssembly In rConfiguredHouseType.SalesItemAssemblys
      mSOSIA = mSIA.Clone
      mSOSIA.ClearKeys()
      mSOSIA.ParentID = pSalesOrder.SalesOrderID
      mDict.Add(mSIA.SalesItemAssemblyID, mSOSIA)
      pSalesOrder.SalesItemAssemblys.Add(mSOSIA)
    Next

    mProducts = New colProductBases
    mdso.LoadStandardProducts(mProducts)

    mdso.SaveSalesOrderDown(pSalesOrder)

    '// Now create the SalesItems and move the salesitemassembley to the new version

    mHouseTypeManager = New clsHouseTypeManager(rConfiguredHouseType, rDBConn)
    mHTSIIs = mHouseTypeManager.GetTotalHTSalesItemInfos(mProducts, mProductCost.ProductCostBookEntrys)

    For Each mHouseTypeSalesItem As clsHouseTypeSalesItemInfo In mHTSIIs

      mSalesItem = New dmSalesOrderItem
      mSalesItem.Description = mHouseTypeSalesItem.Description
      mSalesItem.HouseTypeID = rTargetSalesOrderHouse.SalesOrderHouseID
      mSalesItem.ProductID = mHouseTypeSalesItem.HouseTypeSalesItem.ProductID
      mSalesItem.ProductTypeID = mHouseTypeSalesItem.HouseTypeSalesItem.ProductTypeID
      mSalesItem.Quantity = mHouseTypeSalesItem.Quantity
      mSalesItem.SalesOrderID = pSalesOrder.SalesOrderID
      mSalesItem.SalesItemType = mHouseTypeSalesItem.ProductConstructionType
      mSalesItem.SalesSubItemType = mHouseTypeSalesItem.SubItemType

      mSOSIA = mDict(mHouseTypeSalesItem.HouseTypeSalesItem.HouseTypeSalesItemAssemblyID)
      mSalesItem.SalesItemAssemblyID = mSOSIA.SalesItemAssemblyID



      pSalesOrder.SalesOrderItems.Add(mSalesItem)

    Next

    mdso.SaveSalesOrderDown(pSalesOrder)
    ''//Creating the salesorderphaseitems if it's a single phase

    For Each mSalesOrderItem As dmSalesOrderItem In pSalesOrder.SalesOrderItems

      If mSalesOrderItem.HouseTypeID = rTargetSalesOrderHouse.SalesOrderHouseID Then
        mSOPI = New dmSalesOrderPhaseItem

        mSOPI.Qty = mSalesOrderItem.Quantity
        mSOPI.SalesItemID = mSalesOrderItem.SalesOrderItemID
        mSOPI.SalesOrderID = mSalesOrderItem.SalesOrderID

        If pSalesOrder.SalesOrderPhases IsNot Nothing And pSalesOrder.SalesOrderPhases.Count > 0 Then
          mSOPI.SalesOrderPhaseID = pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseID
          pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.Add(mSOPI)
        End If
      End If

    Next

    mdso.SaveSalesOrderDown(pSalesOrder)

  End Sub



  Public Function GetProductosFromProductionConstructionTypeSubTypeAndSalesHouseID(ByVal vPCT As Integer, ByVal vPCTST As Integer, ByVal vSalesOrderHouseID As Integer) As colSalesOrderItems
    Dim mRetVal As New colSalesOrderItems

    For Each mSI As dmSalesOrderItem In pSalesOrder.SalesOrderItems

      If mSI.HouseTypeID = vSalesOrderHouseID Then
        If mSI.SalesItemType = vPCT And mSI.SalesSubItemType = vPCTST Then

          mRetVal.Add(mSI)
        End If
      End If



    Next
    Return mRetVal
  End Function
End Class
