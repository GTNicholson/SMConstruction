Imports RTIS.CommonVB

Public Class fccSalesOrderDetailHouses
  Private pPrimaryKeyID As Integer
  Private pRTISGlobal As AppRTISGlobal

  Private pSalesOrder As dmSalesOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Private pSalesOrderHandler As clsSalesOrderHandler

  Private pSOWorkOrderInfos As colWorkOrderInfos

  Private pSOActionHandler As clsSalesOrderActionsHandler

  Private pInvoices As colInvoices
  Private pCustomerPurchaseOrders As colCustomerPurchaseOrders
  Private pCurrentSalesOrderHouse As dmSalesOrderHouse
  Private pCurrentSalesItemAssembly As dmSalesItemAssembly
  Private pSalesItemEditors As colSalesItemEditors
  Private pProductRequirementProcessors As colProductRequirementProcessors

  Private pIsVAT As Boolean

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pSOWorkOrderInfos = New colWorkOrderInfos
    pRTISGlobal = rRTISGlobal
    pSOActionHandler = New clsSalesOrderActionsHandler(rDBConn.RTISUser, rDBConn)
    pInvoices = New colInvoices
    pCustomerPurchaseOrders = New colCustomerPurchaseOrders
    pCurrentSalesOrderHouse = New dmSalesOrderHouse
    pCurrentSalesItemAssembly = New dmSalesItemAssembly
    pSalesItemEditors = New colSalesItemEditors
    pProductRequirementProcessors = New colProductRequirementProcessors
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public Property IsVAT As Boolean
    Get
      Return pIsVAT
    End Get
    Set(value As Boolean)
      pIsVAT = value
    End Set
  End Property

  Public ReadOnly Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
  End Property

  Public ReadOnly Property SOWorkOrders As colWorkOrderInfos
    Get
      Return pSOWorkOrderInfos
    End Get
  End Property

  Public ReadOnly Property Invoices As colInvoices
    Get
      Return pSalesOrder.Invoices
    End Get
  End Property

  Public ReadOnly Property PaymentAccounts As colPaymentOnAccounts
    Get
      Return pSalesOrder.PaymentAccounts
    End Get
  End Property
  Public ReadOnly Property CustomerPurchaseOrders As colCustomerPurchaseOrders
    Get
      Return pSalesOrder.CustomerPurchaseOrder
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mSalesOrderItemAssembly As dmSalesItemAssembly
    Dim mdso As dsoSalesOrder

    If pPrimaryKeyID = 0 Then
      pSalesOrder = clsSalesOrderHandler.CreateNewSalesOrder
      pSalesOrder.OrderTypeID = eOrderType.Sales
      mSalesOrderItemAssembly = New dmSalesItemAssembly

      mSalesOrderItemAssembly.ParentID = pSalesOrder.SalesOrderID
      SalesOrder.SalesItemAssemblys.Add(mSalesOrderItemAssembly)

      'pSalesOrder.ProductCostBookID = GetDefaultProductCostBook()

      SaveObjects()

    Else
      pSalesOrder = New dmSalesOrder
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadSalesOrderDown(pSalesOrder, pPrimaryKeyID)
      LoadProductRequirement()
    End If
    If pSalesOrder.ProductCostBookID = 0 Then
      pSalesOrder.ProductCostBookID = GetDefaultCostBook()

    End If
    pSalesOrderHandler = New clsSalesOrderHandler(pSalesOrder)
  End Sub

  Public Function GetDefaultCostBook() As Integer
    Dim mdso As dsoSalesOrder

    mdso = New dsoSalesOrder(pDBConn)
    Return mdso.GetDefaultCostBook()
  End Function

  Public Sub SaveObjects()
    Try
      Dim mdso As dsoSalesOrder
      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
      SaveProductRequirement()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Property ProductRequirementProcessors As colProductRequirementProcessors
    Get
      Return pProductRequirementProcessors
    End Get
    Set(value As colProductRequirementProcessors)
      pProductRequirementProcessors = value
    End Set
  End Property

  Public Sub CreateSalesOrderPack(ByRef rReport As DevExpress.XtraReports.UI.XtraReport, ByVal vFilePath As String)
    Dim mExportOptions As DevExpress.XtraPrinting.PdfExportOptions
    Dim mPDFAmalg As New RTIS.PDFUtils.PDFAmal
    Dim mFilePath As String

    mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
    mExportOptions.ConvertImagesToJpeg = False

    rReport.ExportToPdf(vFilePath, mExportOptions)

    ''mPDFAmalg.PDFFileName = vFilePath
    ''mPDFAmalg.CreateNewDocument()

    ''If IO.File.Exists(vFilePath) Then
    ''  mPDFAmalg.ImportPDFDocument(vFilePath)
    ''End If

    ''For Each mFileTracker In pSalesOrder.SOFiles
    ''  If mFileTracker.IncludeInPack Then
    ''    mFilePath = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.SalesOrderFileFolderUsr, pSalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pSalesOrder.SalesOrderID.ToString("00000")), mFileTracker.FileName)

    ''    If IO.File.Exists(mFilePath) Then
    ''      mPDFAmalg.ImportPDFDocument(mFilePath)
    ''    End If
    ''  End If
    ''Next

    ''mPDFAmalg.SavePDFDocument()

  End Sub

  Public Function GetCustomerList() As colCustomers
    Dim mRetVal As New colCustomers
    Dim mdso As dsoSalesOrder
    Try
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadCustomers(mRetVal)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Function GetInvoicesList() As colInvoices
    Dim mRetVal As New colInvoices
    Dim mdso As dsoSalesOrder
    Try
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadInvoices(mRetVal, pSalesOrder.SalesOrderID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub GenerateWorkOrders()
    Dim mVal As clsValWarn
    pSOActionHandler.SalesOrder = pSalesOrder
    pSOActionHandler.InitMainObject()

    mVal = pSOActionHandler.RefreshActionValidation(clsSalesOrderActionsHandler.eSalesOrderAction.GenerateWorkOrders)
    If mVal.ValOk Then
      mVal = pSOActionHandler.RunAction(clsSalesOrderActionsHandler.eSalesOrderAction.GenerateWorkOrders)
    End If
    ''
  End Sub

  Public Sub RecallWorkOrders()
    Dim mVal As clsValWarn
    pSOActionHandler.SalesOrder = pSalesOrder
    pSOActionHandler.InitMainObject()

    mVal = pSOActionHandler.RefreshActionValidation(clsSalesOrderActionsHandler.eSalesOrderAction.RecallWorkOrders)
    If mVal.ValOk Then
      mVal = pSOActionHandler.RunAction(clsSalesOrderActionsHandler.eSalesOrderAction.RecallWorkOrders)
    End If

  End Sub

  Public Sub AddSalesOrderItem(ByVal vProductType As eProductType)
    Dim mdso As dsoSalesOrder
    Dim mSOI As dmSalesOrderItem
    Try
      SaveObjects()
      mSOI = pSalesOrderHandler.AddSalesOrderItem(vProductType)
      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
      CreateSalesOrderPhaseItem(pSalesOrder.SalesOrderPhases(0), SalesOrder.SalesOrderID) ''//Because for the moment AF is using just one phase always
      SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub DeleteSalesOrderItem(ByRef rSOI As dmSalesOrderItem)
    Try
      pSalesOrderHandler.RemoveSalesOrderItem(rSOI)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub AddWorkOrder(ByRef rSOI As dmSalesOrderItem, ByVal vProductType As eProductType)
    Dim mdso As dsoSalesOrder
    Dim mWO As dmWorkOrder
    Try
      SaveObjects()
      mWO = pSalesOrderHandler.AddWorkOrder(rSOI, vProductType)
      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveWorkOrderDown(mWO)
      SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub DeleteWorkOrder(ByRef rWorkOrder As dmWorkOrder)
    Try
      pSalesOrderHandler.RemoveWorkOrder(rWorkOrder)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pSalesOrder.IsAnyDirty

    Return mIsDirty
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function


  Public Sub ReloadCustomer()
    Dim mdso As dsoSalesOrder
    Try
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadCustomerDown(pSalesOrder.Customer, pSalesOrder.CustomerID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub



  Public Function CreateSOItemImageFile(ByRef rSalesOrderItem As dmSalesOrderItem, ByVal vSourceFile As String) As Boolean
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mRetVal As Boolean = False

    Try


      If IO.File.Exists(vSourceFile) Then
        mFileName = "SalesOrderImg" & "_" & pSalesOrder.OrderNo & "_" & rSalesOrderItem.ItemNumber

        mExportDirectory = IO.Path.Combine(pRTISGlobal.DefaultExportPath, clsConstants.SalesOrderFileFolderSys,
                                         pSalesOrder.DateEntered.Year,
                                         clsGeneralA.GetFileSafeName(pSalesOrder.OrderNo))

        mFileName &= IO.Path.GetExtension(vSourceFile)
        mFileName = clsGeneralA.GetFileSafeName(mFileName)

        mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
        If IO.Directory.Exists(mExportDirectory) = False Then
          IO.Directory.CreateDirectory(mExportDirectory)
        End If

        mFilePath = IO.Path.Combine(mExportDirectory, mFileName)

        IO.File.Copy(vSourceFile, mFilePath, True)

        If IO.File.Exists(mFilePath) = True Then
          rSalesOrderItem.ImageFile = IO.Path.GetFileName(mFilePath)
          mRetVal = True
        Else
          rSalesOrderItem.ImageFile = ""
          mRetVal = False
        End If
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mRetVal

  End Function

  Public Function GetHouseModelNameByHouseTypeID(ByVal vHouseTypeID As Integer) As String
    Dim mdso As New dsoProductAdmin(DBConn)
    Dim mHouseType As New dmHouseType

    mdso.LoadHouseType(mHouseType, vHouseTypeID)

    If mHouseType IsNot Nothing Then
      Return mHouseType.ModelName

    Else
      Return ""
    End If
  End Function

  Public Sub RefreshWorkOrderNos(ByRef rSalesOrderItem As dmSalesOrderItem)
    Dim mDSO As dsoSalesOrder
    Dim mWONo As String
    mDSO = New dsoSalesOrder(pDBConn)
    For Each mWO As dmWorkOrder In rSalesOrderItem.WorkOrders
      mWONo = mDSO.WorkOrderNoFromID(mWO.WorkOrderID)
      mWO.WorkOrderNo = mWONo
    Next
  End Sub

  Public Sub CreateSalesOrderPhaseItem(ByRef rSalesOrderPhase As dmSalesOrderPhase, ByVal vSalesOrderID As Integer)
    Dim SOPI As dmSalesOrderPhaseItem
    Dim mFoundSOPI As dmSalesOrderPhaseItem

    ''rSalesOrderPhase.SalesOrderPhaseItems.Clear()

    If rSalesOrderPhase IsNot Nothing And rSalesOrderPhase.SalesOrderPhaseID > 0 Then

      If pSalesItemEditors IsNot Nothing Then

        For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems

          mFoundSOPI = rSalesOrderPhase.SalesOrderPhaseItems.ItemFromSalesItemKey(mSOI.SalesOrderItemID)
          If mFoundSOPI Is Nothing Then
            SOPI = New dmSalesOrderPhaseItem
            SOPI.SalesOrderID = vSalesOrderID
            SOPI.SalesOrderPhaseID = rSalesOrderPhase.SalesOrderPhaseID
            SOPI.SalesItemID = mSOI.SalesOrderItemID

            SOPI.Qty = mSOI.Quantity

            rSalesOrderPhase.SalesOrderPhaseItems.Add(SOPI)

          Else
            ''//Only update qty and ref
            Dim mIndex As Integer = -1

            mIndex = rSalesOrderPhase.SalesOrderPhaseItems.IndexFromKey(mFoundSOPI.SalesOrderPhaseItemID)

            If mIndex > -1 Then
              rSalesOrderPhase.SalesOrderPhaseItems(mIndex).Qty = mSOI.Quantity
              rSalesOrderPhase.SalesOrderPhaseItems(mIndex).SalesItemID = mSOI.SalesOrderItemID
            End If

          End If


        Next
        SaveObjects()
      End If

    End If

  End Sub

  Public Function RemoveSalesOrderHouse(ByRef rSalesOrderHouse As dmSalesOrderHouse) As Boolean
    Dim mOK As Boolean
    Try
      If rSalesOrderHouse IsNot Nothing AndAlso SalesOrder.SalesOrderHouses IsNot Nothing Then
        mOK = SalesOrder.SalesOrderHouses.Remove(rSalesOrderHouse)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function

  Private Sub RemoveSalesItemsBySalesOrderItemAssemblyID(ByVal vSalesItemAssemblyID As Integer)
    Dim mRemovedItems As New colSalesOrderItems
    For Each mSI As dmSalesOrderItem In SalesOrder.SalesOrderItems

      If mSI.SalesItemAssemblyID = vSalesItemAssemblyID Then
        mRemovedItems.Add(mSI)
      End If
    Next

    For Each mSOI As dmSalesOrderItem In mRemovedItems
      SalesOrder.SalesOrderItems.Remove(mSOI)
    Next
  End Sub

  Public ReadOnly Property CurrentSalesOrderHouse As dmSalesOrderHouse
    Get
      Return pCurrentSalesOrderHouse
    End Get
  End Property

  Public ReadOnly Property CurrentSalesItemAssembly() As dmSalesItemAssembly
    Get
      Return pCurrentSalesItemAssembly
    End Get
  End Property

  Public ReadOnly Property SalesItemEditors() As colSalesItemEditors
    Get
      Return pSalesItemEditors
    End Get
  End Property

  ''Public Sub AddNewSalesItemAssembly()
  ''  Try

  ''    If pCurrentSalesItemAssembly IsNot Nothing Then
  ''      Dim mNewSIA As New dmSalesItemAssembly
  ''      Dim mdso As New dsoSales(pDBConn)


  ''      mNewSIA.ParentID = pSalesOrder.SalesOrderID

  ''      pSalesOrder.SalesItemAssemblys.Add(mNewSIA)

  ''      mdso.SaveSalesOrderDown(pSalesOrder)

  ''      mdso = Nothing
  ''    End If

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try
  ''End Sub


  Public Sub SetCurrentSalemOrderHouse(ByRef rSalesOrderHouse As dmSalesOrderHouse)
    pCurrentSalesOrderHouse = rSalesOrderHouse

    '// this is where you need to refresh the CurrentSalesItemAssemblySalesitemEditors
    RefreshCurrentSalesItemEditors()

  End Sub

  Public Sub RefreshCurrentSalesItemEditors()
    Dim mSIAE As clsSalesItemEditor
    Dim mProductInfo As clsProductBaseInfo
    Dim mPIs As colProductBaseInfos
    Dim mSIA As dmSalesItemAssembly

    pSalesItemEditors.Clear()


    If pCurrentSalesOrderHouse IsNot Nothing Then
      mPIs = GetProductInfos()

      For Each mSalesItem As dmSalesOrderItem In pSalesOrder.SalesOrderItems
        If mSalesItem.HouseTypeID = pCurrentSalesOrderHouse.SalesOrderHouseID Then

          mSIA = pSalesOrder.SalesItemAssemblys.ItemFromKey(mSalesItem.SalesItemAssemblyID)

          '// create a new editor based on this salesitem and add to collection
          mProductInfo = mPIs.ItemFromProductTypeAndID(mSalesItem.ProductTypeID, mSalesItem.ProductID)
          mSIAE = New clsSalesItemEditor(pSalesOrder, mSIA, mSalesItem, mProductInfo.Product)
          pSalesItemEditors.Add(mSIAE)

          mSalesItem.Description = mSIAE.Description

        End If
      Next
    End If



  End Sub

  Public Function GetProductInfos() As colProductBaseInfos
    Dim mRetVal As New colProductBaseInfos
    Dim mdso As New dsoProductAdmin(DBConn)
    Dim mWhere As String
    mWhere = "Status <> " & CInt(eProductStatus.Obsolete) & " or status is null"
    mdso.LoadProductInfosByWhere(mRetVal, mWhere)
    Return mRetVal
  End Function

  Public Function GetWorkOrderByWorkOrderOrderAllocationID(ByVal vWorkOrderAllocationID As Integer) As dmWorkOrder
    Dim mdso As New dsoSalesOrder(pDBConn)
    Dim mWorkOrder As dmWorkOrder = Nothing
    Dim mWorkOrderID As Integer = -1
    Dim mSQL As String = ""


    Try
      pDBConn.Connect()

      mSQL &= "Select WorkOrderID from WorkOrderAllocation where WorkOrderAllocationID = " & vWorkOrderAllocationID

      mWorkOrderID = pDBConn.ExecuteScalar(mSQL)

      If mWorkOrderID > 0 Then

        mdso.LoadWorkOrderDown(mWorkOrder, mWorkOrderID)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


    Return mWorkOrder
  End Function

  Public Function CreateSalesItem(ByRef rSalsesOrder As dmSalesOrder) As dmSalesOrderItem
    Dim mRetVal As New dmSalesOrderItem

    With mRetVal
      .SalesOrderID = rSalsesOrder.SalesOrderID
      If CurrentSalesItemAssembly IsNot Nothing Then
        .SalesItemAssemblyID = CurrentSalesItemAssembly.SalesItemAssemblyID
      End If

    End With

    rSalsesOrder.SalesOrderItems.Add(mRetVal)


    Return mRetVal
  End Function

  Public Function GetWorkOrderInfosFilteredByProductID(ByVal vProductID As Integer) As colWorkOrderInfos
    Dim mRetVal As New colWorkOrderInfos
    Dim mdso As New dsoSalesOrder(pDBConn)
    Dim mWhere As String = "ProductID = " & vProductID

    Try
      mdso.LoadInternalWorkOrderInfos(mRetVal, mWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

    Return mRetVal
  End Function

  Public Sub DeleteSalesOrderPhaseItemBySalesOrderIDAndSalesItemID(ByVal vSalesOrderID As Integer, ByVal vSalesOrderItemID As Integer)

    If pSalesOrder.SalesOrderPhases IsNot Nothing Then
      For Each mSOPI In pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems

        If mSOPI.SalesOrderID = vSalesOrderID And mSOPI.SalesItemID = vSalesOrderItemID Then
          pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.Remove(mSOPI)
          Exit For
        End If
      Next
    End If

    SaveObjects()

  End Sub

  Public Sub LoadWorkOrderByWorkOrderID(ByRef rWorkOrder As dmWorkOrder, ByVal vWorkOrderID As Integer)
    Dim mdso As New dsoSalesOrder(pDBConn)
    Try

      mdso.LoadWorkOrderDown(rWorkOrder, vWorkOrderID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub

  Public Sub CreateSalesItemsFromHouseTypeConfig(ByRef rHouseType As dmHouseType, ByVal vProductCostBookID As Integer)
    pCurrentSalesOrderHouse.HouseTypeID = rHouseType.HouseTypeID
    pSalesOrderHandler.CreateSalesItemsFromHouseTypeConfig(pCurrentSalesOrderHouse, rHouseType, pDBConn, vProductCostBookID)

  End Sub

  Public Sub GenerateSequenceBySalesHouse(ByVal vSalesOrderHouseID As Integer)
    Dim mProductTypes As New colProductConstructionTypes
    Dim mProductSubTypes As New colProductConstructionSubTypes
    Dim mRefList As colRefLists = AppRTISGlobal.GetInstance.RefLists
    Dim mMatchingSIs As colSalesOrderItems
    Dim mCount As Integer
    Dim mProduct As dmProductBase
    Dim mProductType As dmProductConstructionType
    Dim mProductSubType As dmProductConstructionSubType

    mProductTypes = CType(mRefList.RefIList(appRefLists.ProductConstructionType), colProductConstructionTypes)
    mProductSubTypes = CType(mRefList.RefIList(appRefLists.ProductConstructionSubType), colProductConstructionSubTypes)


    For Each msi As dmSalesOrderItem In pSalesOrder.SalesOrderItems
      If msi.HouseTypeID = vSalesOrderHouseID Then
        mProduct = pRTISGlobal.ProductRegistry.GetProductFromTypeAndID(msi.ProductTypeID, msi.ProductID)
        mProductType = mProductTypes.ItemFromKey(msi.SalesItemType)
        If mProductType IsNot Nothing Then
          msi.ItemNumber = mProductType.SequenceNo * 10
        End If
        mProductSubType = mProductSubTypes.ItemFromKey(mProduct.SubItemType)
        If mProductSubType IsNot Nothing Then
          msi.ItemNumber = msi.ItemNumber & "." & mProductSubType.SequenceNo
        End If
      End If
    Next


    For Each mPCT As dmProductConstructionType In mProductTypes
      For Each mPCTST As dmProductConstructionSubType In mProductSubTypes
        mMatchingSIs = pSalesOrderHandler.GetProductosFromProductionConstructionTypeSubTypeAndSalesHouseID(mPCT.ProductConstructionTypeID, mPCTST.ProductConstructionSubTypeID, vSalesOrderHouseID)
        If mMatchingSIs.Count > 1 Then
          mCount = 97
          For Each mSI As dmSalesOrderItem In mMatchingSIs
            If mSI.HouseTypeID = vSalesOrderHouseID Then

              mSI.ItemNumber = mSI.ItemNumber & Chr(mCount)
              mCount += 1
              pSalesOrder.SalesOrderItems.ItemFromKey(mSI.SalesOrderItemID).ItemNumber = mSI.ItemNumber
            End If

          Next
        End If
      Next
    Next



  End Sub

  Public Sub CreateWorkOrderAllocation(ByVal vSalesOrderItemID As Integer, ByRef rWorkOrder As dmWorkOrder, ByVal vProductID As Integer, ByVal vQuantity As Decimal)
    Dim mWorkOrderAllocation As New dmWorkOrderAllocation
    Dim mSOPI As dmSalesOrderPhaseItem
    Dim mExistedWOA As dmWorkOrderAllocation

    If SalesOrder.SalesOrderPhases(0) IsNot Nothing Then

      If SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems IsNot Nothing Then
        mSOPI = SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.ItemFromSalesItemKey(vSalesOrderItemID)

        If mSOPI IsNot Nothing Then

          mExistedWOA = rWorkOrder.WorkOrderAllocations.ItemFromSalesOrderPhaseItemID(mSOPI.SalesOrderPhaseItemID)

          If mExistedWOA IsNot Nothing Then ''Exist, then delete it

            mExistedWOA.WorkOrderID = rWorkOrder.WorkOrderID
            mExistedWOA.SalesOrderPhaseItemID = mSOPI.SalesOrderPhaseItemID
            SaveWOAllocationOnly(mExistedWOA)

          Else '' add it to the WO allocations list
            mWorkOrderAllocation.WorkOrderID = rWorkOrder.WorkOrderID
            mWorkOrderAllocation.SalesOrderPhaseItemID = mSOPI.SalesOrderPhaseItemID
            mWorkOrderAllocation.QuantityRequired = vQuantity
            rWorkOrder.WorkOrderAllocations.Add(mWorkOrderAllocation)
            SaveWorkOrder(rWorkOrder)
          End If


        End If
      End If
    End If



  End Sub

  Private Sub SaveWOAllocationOnly(ByRef rExistedWOA As dmWorkOrderAllocation)
    Dim mdto As New dtoWorkOrderAllocation(pDBConn)


    Try
      pDBConn.Connect()

      mdto.SaveWorkOrderAllocation(rExistedWOA)

      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

  End Sub

  Public Sub AddProductWorkOrder(ByVal vSalesOrderItemID As Integer, ByVal vProductType As eProductType, ByVal vProductID As Integer, ByVal vQuantity As Decimal)
    Dim mNewWO As New dmWorkOrder
    Dim mNewWOALL As New dmWorkOrderAllocation
    Dim mSalesOrderPhaseItem As dmSalesOrderPhaseItem
    Dim mdsoGeneral As New dsoGeneral(pDBConn)

    mNewWO.ProductID = vProductID
    mNewWO.DateCreated = Now
    mNewWO.isInternal = True
    mNewWO.ProductTypeID = vProductType
    mNewWO.SalesOrderItemID = vSalesOrderItemID

    mNewWO.WorkOrderNo = "OT-" & mdsoGeneral.GetNextTallyWONo().ToString("00000")
    SaveWorkOrder(mNewWO)

    ''//Creating WOA
    If pSalesOrder.SalesOrderPhases IsNot Nothing Then
      mSalesOrderPhaseItem = SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.ItemFromSalesItemKey(vSalesOrderItemID)

      If mSalesOrderPhaseItem IsNot Nothing Then
        mNewWOALL.WorkOrderID = mNewWO.WorkOrderID
        mNewWOALL.SalesOrderPhaseItemID = mSalesOrderPhaseItem.SalesOrderPhaseItemID
        mNewWOALL.QuantityRequired = vQuantity
        mNewWO.WorkOrderAllocations.Add(mNewWOALL)
      End If
    End If

    SaveWorkOrder(mNewWO)
  End Sub

  Public Sub SaveWorkOrder(ByRef rNewWO As dmWorkOrder)
    Dim mdso As New dsoSalesOrder(pDBConn)

    mdso.SaveWorkOrderDown(rNewWO)

  End Sub

  Public Sub AddProductRequirement(ByRef rProductStructure As dmProductStructure, ByRef rSOI As dmSalesOrderItem)

    Dim mPRP As New clsProductRequirementProcessor()
    Dim mPR As New dmSalesOrderItemProductRequirement
    If rSOI IsNot Nothing Then
      mPRP.Product = rProductStructure
      mPRP.Description = rProductStructure.Description
      mPRP.SalesOrderItemID = rSOI.SalesOrderItemID
      mPRP.ItemNumber = rSOI.ItemNumber
      mPRP.ProductRequirement.AllocatedQty = 1
      mPR.SalesOrderItemID = rSOI.SalesOrderItemID
      mPR.ProductID = rProductStructure.ID
      mPR.AllocatedQty = 1
      SaveProductRequirement(mPR)

      mPRP.ProductRequirement = mPR

      pProductRequirementProcessors.Add(mPRP)
    End If


  End Sub

  Public Sub SaveProductRequirement(ByRef rPR As dmSalesOrderItemProductRequirement)
    Dim mdso As New dsoSalesOrder(pDBConn)

    mdso.SaveProductRequirement(rPR)

  End Sub

  Public Sub SaveProductRequirement()
    Dim mProductRequirementCol As New colSalesOrderItemProductRequirements
    Dim mdso As New dsoSalesOrder(pDBConn)


    mProductRequirementCol = New colSalesOrderItemProductRequirements
    For Each mPRP As clsProductRequirementProcessor In pProductRequirementProcessors

      If mPRP.ProductRequirement IsNot Nothing Then
        mdso.SaveProductRequirement(mPRP.ProductRequirement)
      End If
    Next






  End Sub

  Public Sub LoadProductRequirement()
    Dim mWhere As String = "SalesOrderItemID in ("
    Dim mSOPI As dmSalesOrderPhaseItem
    Dim mCount As Integer = 0
    Dim mdso As New dsoSalesOrder(pDBConn)
    For Each mSalesOrderItem As dmSalesOrderItem In pSalesOrder.SalesOrderItems


      If mSalesOrderItem IsNot Nothing Then
        mWhere &= mSalesOrderItem.SalesOrderItemID & ","
        mCount += 1
      End If

    Next

    If mCount > 0 Then
      mWhere = mWhere.Substring(0, mWhere.Length - 1)
      mWhere &= ")"
      pProductRequirementProcessors.Clear()
      mdso.LoadProductRequirementCollection(pProductRequirementProcessors, mWhere)
    End If
  End Sub

  Public Sub RemoveProductRequirement(ByRef rProductRequirement As dmSalesOrderItemProductRequirement)

    Try
      Dim mSQL As String = ""
      Dim mSOPI As dmSalesOrderPhaseItem

      mSQL &= " Delete from SalesOrderItemProductRequirement where SalesOrderItemProductRequirementID =" & rProductRequirement.SalesOrderItemProductRequirementID
      pDBConn.Connect()

      pDBConn.ExecuteNonQuery(mSQL)

      If pSalesOrder IsNot Nothing Then
        mSOPI = pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.ItemFromSalesItemKey(rProductRequirement.SalesOrderItemID)

        If mSOPI IsNot Nothing Then
          mSQL = "Delete from WorkOrderAllocation where SalesOrderPhaseItemID = " & mSOPI.SalesOrderPhaseItemID
          pDBConn.ExecuteNonQuery(mSQL)

        End If
      End If

      pDBConn.Disconnect()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub

  Public Sub DeleteOldWorkOrderAllocation(ByVal vWorkOrderAllocationID As Integer, ByVal vSalesOrderItemID As Integer)

    Try
      pDBConn.Connect()

      Dim mWhere As String = ""
      Dim mSalesOrderPhaseItem As dmSalesOrderPhaseItem

      mSalesOrderPhaseItem = SalesOrder.SalesOrderPhases(0).SalesOrderPhaseItems.ItemFromSalesItemKey(vSalesOrderItemID)

      If mSalesOrderPhaseItem IsNot Nothing Then
        mWhere = String.Format("DELETE FROM WorkOrderAllocation WHERE WORKORDERALLOCATIONID = {0} and SalesOrderPhaseItemID = {1} ", vWorkOrderAllocationID, mSalesOrderPhaseItem.SalesOrderPhaseItemID)
        pDBConn.ExecuteNonQuery(mWhere)
      End If

      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try


  End Sub
End Class
