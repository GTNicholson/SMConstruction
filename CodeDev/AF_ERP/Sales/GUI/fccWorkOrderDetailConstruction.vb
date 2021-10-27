Imports RTIS.CommonVB

Public Class fccWorkOrderDetailConstruction
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderItem As dmSalesOrderItem
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pTimeSheetEntrys As colTimeSheetEntrys
  Private pCurrentProduct As dmProductStructure
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
  Private pUsedItems As List(Of Integer)
  Private pSalesOrderPhaseItems As colSalesOrderPhaseItems
  Private pWorkOrderAllocationEditors As colWorkOrderAllocationEditors
  Private pProductType As eProductType
  Private pSalesOrderPhaseInfos As colSalesOrderPhaseInfos


  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pTimeSheetEntrys = New colTimeSheetEntrys
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
    pUsedItems = New List(Of Integer)
    pSalesOrderPhaseItems = New colSalesOrderPhaseItems
    pWorkOrderAllocationEditors = New colWorkOrderAllocationEditors
    pSalesOrderPhaseInfos = New colSalesOrderPhaseInfos()
    pCurrentProduct = clsProductSharedFuncs.NewProductInstance(eProductType.StructureAF)
  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

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
  Public Property ProductType As eProductType
    Get
      Return pProductType
    End Get
    Set(value As eProductType)
      pProductType = value
    End Set
  End Property
  Public Property WorkOrderAllocationEditors() As colWorkOrderAllocationEditors
    Get
      Return pWorkOrderAllocationEditors
    End Get
    Set(value As colWorkOrderAllocationEditors)
      pWorkOrderAllocationEditors = value
    End Set
  End Property




  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property IsInternal As Boolean
    Get
      Return WorkOrder.isInternal
    End Get
    Set(value As Boolean)
      WorkOrder.isInternal = value
    End Set
  End Property

  Public Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
    Set(value As dmSalesOrderItem)
      pSalesOrderItem = value
    End Set
  End Property
  Public Property UsedItems As List(Of Integer)
    Get
      Return pUsedItems
    End Get
    Set(value As List(Of Integer))
      pUsedItems = value
    End Set
  End Property
  Public Property SalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
    Get
      Return pSalesOrderPhaseItemInfos
    End Get
    Set(value As colSalesOrderPhaseItemInfos)
      pSalesOrderPhaseItemInfos = value
    End Set
  End Property

  Public Property SalesOrderPhaseInfos As colSalesOrderPhaseInfos
    Get
      Return pSalesOrderPhaseInfos
    End Get
    Set(value As colSalesOrderPhaseInfos)
      pSalesOrderPhaseInfos = value
    End Set
  End Property
  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property

  Public Property CurrentProduct As dmProductStructure
    Get
      Return pCurrentProduct
    End Get
    Set(value As dmProductStructure)
      pCurrentProduct = value
    End Set
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoSalesOrder
    Dim mdsoHR As dsoHR
    Dim mSOID As Integer

    mdso = New dsoSalesOrder(pDBConn)

    If pPrimaryKeyID = 0 Then
      '// if it is new work order it will be internal - Sales Order Work Orders will be created from the salesorder form
      pWorkOrder = clsWorkOrderHandler.CreateInternalWorkOrder(pProductType)
    Else
      If pWorkOrder Is Nothing Then '//Not already loaded
        pWorkOrder = New dmWorkOrder
        mdso.LoadWorkOrderDown(pWorkOrder, pPrimaryKeyID)


      End If

      '// if it is a salesorder, check that the remaining details have been loaded and assigned
      'If pSalesOrder Is Nothing Then
      '  mSOID = mdso.GetSalesOrderIDFromWorkOrderID(pPrimaryKeyID)

      '  pSalesOrder = New dmSalesOrder
      '  mdso.LoadSalesOrderDown(pSalesOrder, mSOID)

      'End If
      'For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems
      '    For Each mWO As dmWorkOrder In mSOI.WorkOrders
      '      If mWO.WorkOrderID = pPrimaryKeyID Then
      '        pWorkOrder = mWO
      '        pWorkOrder.ParentSalesOrderItem = mSOI
      '        Exit For
      '      End If
      '    Next
      '    If pWorkOrder.ParentSalesOrderItem IsNot Nothing Then Exit For
      '  Next

      '  '// WorkOrder and SalesOrder already provided so just need to set the SalesOrderItem
      '  pSalesOrderItem = pWorkOrder.ParentSalesOrderItem

      'mdsoHR = New dsoHR(pDBConn)
      'pTimeSheetEntrys = New colTimeSheetEntrys
      'mdsoHR.LoadTimeSheetEntrysWorkOrder(pTimeSheetEntrys, pWorkOrder.WorkOrderID)

    End If
  End Sub

  Public Sub CreateFromSalesOrderPhaseItems(ByRef rSalesOrderPhaseItemInfos As List(Of clsSalesOrderPhaseItemInfo), ByVal vProductType As eProductType)
    pWorkOrder = clsWorkOrderHandler.CreateFromSalesOrderPhaseItems(rSalesOrderPhaseItemInfos, vProductType)
  End Sub

  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    Dim mdso As dsoSalesOrder

    mdso = New dsoSalesOrder(pDBConn)
    mdso.SaveWorkOrderDown(pWorkOrder)

    mRetVal = True
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pWorkOrder IsNot Nothing Then
      If pWorkOrder.IsAnyDirty Then mRetVal = True

    End If
    Return mRetVal
  End Function



  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  ''Public Sub RaiseWorkOrderNo()
  ''  Dim mSOI As New dmSalesOrderItem
  ''  Dim mDSO As New dsoSales(pDBConn)
  ''  Dim mWO As dmWorkOrder

  ''  '// because we can relate Work Orders across a sales order item, we need to load the Sales Order Item and the related work orders 
  ''  mDSO.LoadSalesOrderItemWithWOs(mSOI, pWorkOrder.SalesOrderItemID)
  ''  mDSO.RaiseWorkOrderNo(mSOI, pDBConn)
  ''  mDSO.SaveSalesOrderItemWithWOs(mSOI)


  ''  '// Retreive this wo's number to refresh in this form
  ''  mWO = mSOI.WorkOrders.ItemFromKey(pWorkOrder.WorkOrderID)
  ''  pWorkOrder.WorkOrderNo = mWO.WorkOrderNo


  ''End Sub

  Public Sub SetProductType(ByVal vNewProductType As Integer)
    Try
      If vNewProductType <> pWorkOrder.ProductTypeID Then
        pWorkOrder.ProductTypeID = vNewProductType
        pWorkOrder.Product = clsProductSharedFuncs.NewProductInstance(vNewProductType)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub CreateWorkOrderPack(ByRef rReport As DevExpress.XtraReports.UI.XtraReport, ByVal vFilePath As String, ByRef rFilesTrackers As colFileTrackers)
    Dim mExportOptions As DevExpress.XtraPrinting.PdfExportOptions
    Dim mPDFAmalg As New RTIS.PDFUtils.PDFAmal
    Dim mFilePath As String
    Dim mProduct As dmProductBase
    mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
    mExportOptions.ConvertImagesToJpeg = False

    rReport.ExportToPdf(vFilePath, mExportOptions)

    mPDFAmalg.PDFFileName = vFilePath
    mPDFAmalg.CreateNewDocument()

    If IO.File.Exists(vFilePath) Then
      mPDFAmalg.ImportPDFDocument(vFilePath)
    End If


    If rFilesTrackers IsNot Nothing Then
      For Each mFileTracker In rFilesTrackers
        If mFileTracker.IncludeInPack Then

          mFilePath = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.cProductFiles, clsGeneralA.GetFileSafeName(pWorkOrder.ProductID.ToString("00000")), mFileTracker.FileName)


          If IO.File.Exists(mFilePath) Then
            mPDFAmalg.ImportPDFDocument(mFilePath)
          End If
        End If
      Next

    End If

    mPDFAmalg.SavePDFDocument()

  End Sub

  Public Function GetMaterialRequirementInfos() As colMaterialRequirementInfos
    Dim mMatReqInfos As New colMaterialRequirementInfos
    Dim mMRI As clsMaterialRequirementInfo
    Dim mPF As dmProductFurniture

    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)

    If mPF IsNot Nothing Then
      For Each mMR As dmMaterialRequirement In mPF.MaterialRequirments
        mMRI = New clsMaterialRequirementInfo(mMR)
        mMRI.WorkOrder = pWorkOrder
        mMRI.StockItem = pRTISGlobal.StockItemRegistry.GetStockItemFromID(mMRI.MaterialRequirement.StockItemID)
        mMatReqInfos.Add(mMRI)
      Next
    End If

    Return mMatReqInfos
  End Function

  Public Function GetMaterialRequirementInfosChanges() As colMaterialRequirementInfos
    Dim mMatReqInfos As New colMaterialRequirementInfos
    Dim mMRI As clsMaterialRequirementInfo
    Dim mPF As dmProductFurniture

    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)

    If mPF IsNot Nothing Then
      For Each mMR As dmMaterialRequirement In mPF.MaterialRequirmentsChanges
        mMRI = New clsMaterialRequirementInfo(mMR)
        mMRI.WorkOrder = pWorkOrder
        mMRI.StockItem = pRTISGlobal.StockItemRegistry.GetStockItemFromID(mMRI.MaterialRequirement.StockItemID)
        mMatReqInfos.Add(mMRI)
      Next
    End If

    Return mMatReqInfos
  End Function

  Public Function GetMaterialRequirementOtherInfos() As colMaterialRequirementInfos
    Dim mMatReqInfos As New colMaterialRequirementInfos
    Dim mMRI As clsMaterialRequirementInfo
    Dim mPF As dmProductFurniture

    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)

    If mPF IsNot Nothing Then
      For Each mMR As dmMaterialRequirement In mPF.MaterialRequirmentOthers
        mMRI = New clsMaterialRequirementInfo(mMR)
        mMRI.WorkOrder = pWorkOrder
        mMRI.StockItem = pRTISGlobal.StockItemRegistry.GetStockItemFromID(mMRI.MaterialRequirement.StockItemID)
        mMatReqInfos.Add(mMRI)
      Next
    End If

    Return mMatReqInfos
  End Function

  Public Function GetMaterialOtherMaterialChanges() As colMaterialRequirementInfos
    Dim mMatReqInfos As New colMaterialRequirementInfos
    Dim mMRI As clsMaterialRequirementInfo
    Dim mPF As dmProductFurniture

    mPF = TryCast(pWorkOrder.Product, dmProductFurniture)

    If mPF IsNot Nothing Then
      For Each mMR As dmMaterialRequirement In mPF.MaterialRequirmentOthersChanges
        mMRI = New clsMaterialRequirementInfo(mMR)
        mMRI.WorkOrder = pWorkOrder
        mMRI.StockItem = pRTISGlobal.StockItemRegistry.GetStockItemFromID(mMRI.MaterialRequirement.StockItemID)
        mMatReqInfos.Add(mMRI)
      Next
    End If

    Return mMatReqInfos
  End Function

  Public Function CreateWOImageFile(ByVal vSourceFile As String) As Boolean
    Dim mFilePath As String
    Dim mFileName As String
    Dim mExportDirectory As String = String.Empty
    Dim mRetVal As Boolean = False

    Try
      If IO.File.Exists(vSourceFile) Then
        mFileName = "WorkOrderImg" & "_" & WorkOrder.WorkOrderID

        If pWorkOrder.isInternal Then
          mExportDirectory = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, pWorkOrder.PlannedDeliverDate.Year, clsGeneralA.GetFileSafeName(WorkOrder.WorkOrderID.ToString("00000")))
        Else
          mExportDirectory = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, SalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(WorkOrder.WorkOrderID.ToString("00000")))

        End If

        mFileName &= IO.Path.GetExtension(vSourceFile)
        mFileName = clsGeneralA.GetFileSafeName(mFileName)

        mExportDirectory = clsGeneralA.GetDirectorySafeString(mExportDirectory)
        If IO.Directory.Exists(mExportDirectory) = False Then
          IO.Directory.CreateDirectory(mExportDirectory)
        End If

        mFilePath = IO.Path.Combine(mExportDirectory, mFileName)

        IO.File.Copy(vSourceFile, mFilePath, True)

        If IO.File.Exists(mFilePath) = True Then
          pWorkOrder.ImageFile = IO.Path.GetFileName(mFilePath)
          mRetVal = True
        Else
          pWorkOrder.ImageFile = ""
          mRetVal = False
        End If
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

    Return mRetVal
  End Function

  Public Sub UpdateWorkOrderQtyPerSalesItem(ByVal vNewValue As Integer)

    If pWorkOrder.isInternal = False Then
      pWorkOrder.QtyPerSalesItem = vNewValue
      pWorkOrder.Quantity = pWorkOrder.QtyPerSalesItem * pWorkOrder.ParentSalesOrderItem.Quantity
    Else
      pWorkOrder.QtyPerSalesItem = vNewValue
      pWorkOrder.Quantity = pWorkOrder.QtyPerSalesItem
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

  Public Function LoadRefData() As Boolean

    ''Dim mOK As Boolean
    ''Dim mdsoSales As New dsoSales(pDBConn)
    ''Dim mSalesOrderPhaseItem As dmSalesOrderPhaseItem
    ''Try

    ''  mOK = True
    ''  pSalesOrderPhaseItems = New colSalesOrderPhaseItems

    ''  For Each mWOAllocation As dmWorkOrderAllocation In pWorkOrder.WorkOrderAllocations
    ''    If pSalesOrderPhaseItems.IndexFromKey(mWOAllocation.SalesOrderPhaseItemID) = -1 Then
    ''      mSalesOrderPhaseItem = New dmSalesOrderPhaseItem
    ''      mdsoSales.LoadSalesOrderPhaseItem(mSalesOrderPhaseItem, mWOAllocation.SalesOrderPhaseItemID)
    ''      pSalesOrderPhaseItems.Add(mSalesOrderPhaseItem)
    ''    End If

    ''    If pUsedItems.Contains(mWOAllocation.SalesOrderPhaseItemID) = False Then
    ''      pUsedItems.Add(mWOAllocation.SalesOrderPhaseItemID)
    ''    End If
    ''  Next

    ''  If pWorkOrder.WorkOrderAllocations.Count > 0 Then

    ''    If pWorkOrder.WorkOrderAllocations.Count = 1 Then
    ''      mdsoSales.LoadSalesOrderPhaseItemInfos(Me.SalesOrderPhaseItemInfos, "SalesOrderPhaseID = " & pWorkOrder.WorkOrderAllocations(0).SalesOrderPhaseItemID)

    ''    End If

    ''  End If

    ''Catch ex As Exception
    ''  mOK = False
    ''  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    ''End Try
    ''Return mOK
  End Function

  Public Sub LoadSalesOrderPhaseByWhere(ByRef rSalesOrderPhaseItemInfos As colSalesOrderPhaseInfos, ByVal vWhere As String)

    Dim mdso As New dsoSalesOrder(DBConn)

    mdso.LoadSalesOrderPhaseInfos(rSalesOrderPhaseItemInfos, vWhere)

  End Sub



  Friend Function CreateWorkOrderAllocation(ByRef rWorkOrder As dmWorkOrder, ByVal vPhaseItemComponentID As Integer) As dmWorkOrderAllocation
    Dim mRetVal As New dmWorkOrderAllocation

    With mRetVal
      .WorkOrderID = rWorkOrder.WorkOrderID
      .SalesOrderPhaseItemID = vPhaseItemComponentID
    End With

    rWorkOrder.WorkOrderAllocations.Add(mRetVal)


    Return mRetVal
  End Function

  Public Sub RefreshCurrentWorkOrderAllocationEditors()
    Dim mWOAE As clsWorkOrderAllocationEditor
    Dim mdsoSales As dsoSalesOrder
    Dim mSOPs As New colSalesOrderPhaseInfos
    Dim mSOPIInfos As colSalesOrderPhaseItemInfos
    Dim mWhere As String = ""
    Dim mSOID As Integer
    Dim mSOPIInfo As clsSalesOrderPhaseItemInfo
    If pWorkOrder IsNot Nothing Then
      If pWorkOrder.WorkOrderAllocations IsNot Nothing Then 'And pWorkOrder.WorkOrderAllocations.Count
        mdsoSales = New dsoSalesOrder(pDBConn)



        pWorkOrderAllocationEditors.Clear()

        If pWorkOrder.WorkOrderAllocations.Count > 0 Then
          For Each mWorkOrderAllocation As dmWorkOrderAllocation In pWorkOrder.WorkOrderAllocations
            '// create a new editor based on this salesitem and add to collection
            mWOAE = New clsWorkOrderAllocationEditor(pWorkOrder, mWorkOrderAllocation)
            pWorkOrderAllocationEditors.Add(mWOAE)
            mWorkOrderAllocation.QuantityDone = mWOAE.QuantityDone
          Next

          If pSalesOrder Is Nothing Then
            mSOID = mdsoSales.GetSalesOrderIDBySalesOrderPhaseItemID(pWorkOrder.WorkOrderAllocations(0).SalesOrderPhaseItemID)

            If mSOID = 0 Then
              If pWorkOrderAllocationEditors IsNot Nothing Then
                If pWorkOrderAllocationEditors.Count > 0 Then
                  Dim mSOPIID As Integer

                  mSOPIID = pWorkOrderAllocationEditors(0).SalesOrderPhaseItemID
                  mSOID = mdsoSales.GetSalesOrderIDBySalesOrderPhaseItemID(mSOPIID)
                  mdsoSales.LoadSalesOrderDown(pSalesOrder, mSOID)

                End If
              End If
            Else
              mdsoSales.LoadSalesOrderDown(pSalesOrder, mSOID)

            End If
          End If
          If pSalesOrder IsNot Nothing Then
            mWhere = "SalesOrderPhaseID = " & pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseID

            mSOPIInfos = New colSalesOrderPhaseItemInfos
            mdsoSales.LoadSalesOrderPhaseItemsInfosByWhere(mSOPIInfos, mWhere)


            For Each mWorkOrderAllocationEditor As clsWorkOrderAllocationEditor In pWorkOrderAllocationEditors
              mSOPIInfo = mSOPIInfos.ItemFromKey(mWorkOrderAllocationEditor.SalesOrderPhaseItemID)
              If mSOPIInfo IsNot Nothing Then
                mWorkOrderAllocationEditor.PopulateSalesOrderPhaseItemInfo(mSOPIInfo)
              End If
            Next
          End If
        End If
      End If


    End If



  End Sub

  Public Function GetCurrentProduct() As dmProductStructure
    Dim mRetVal As dmProductStructure
    Dim mdso As New dsoProductAdmin(pDBConn)

    mdso.LoadProductStructureDown(mRetVal, WorkOrder.ProductID)

    Return mRetVal

  End Function

  Public Sub GetNextWONumber()
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    pWorkOrder.WorkOrderNo = "OT-" & mdsoGeneral.GetNextTallyWONo().ToString("00000")
  End Sub

  Public Sub SaveProduct()

    Dim mdto As dtoProductBase
    Dim mdtoProductBOM As dtoProductBOM
    Dim mdtoPOFiles As dtoFileTracker

    If pCurrentProduct IsNot Nothing Then
      pDBConn.Connect()
      mdto = dtoProductBase.GetNewInstance(eProductType.StructureAF, pDBConn)

      mdto.SaveProduct(pCurrentProduct)

      mdtoProductBOM = New dtoProductBOM(pDBConn)
      mdtoProductBOM.SaveProductBOMCollection(pCurrentProduct.ProductStockItemBOMs, pCurrentProduct.ID, eProductBOMObjectType.StockItems)
      mdtoProductBOM.SaveProductBOMCollection(pCurrentProduct.ProductWoodBOMs, pCurrentProduct.ID, eProductBOMObjectType.Wood)


      mdtoPOFiles = New dtoFileTracker(pDBConn)
      mdtoPOFiles.SaveFileTrackerCollection(pCurrentProduct.POFiles, eObjectType.ProductStructure, pCurrentProduct.ID)


      pDBConn.Disconnect()
    End If


  End Sub

  Public Sub GenerateMatReq(ByRef rProductStructure As dmProductStructure)
    Dim mNewMatReq As dmMaterialRequirement
    Dim mWoodProductBOMs As colProductBOMs
    Dim mStockItemProductBOMs As colProductBOMs
    Dim mOldWorkOrderStockItemBOMs As colMaterialRequirements
    Dim mOldWorkOrderWoodBOMs As colMaterialRequirements

    Dim mQty As Decimal
    Dim mFoundMR As dmMaterialRequirement

    If pWorkOrder.Quantity > 0 Then

      If rProductStructure IsNot Nothing Then

        ''//Create Wood MatReq from WoodBOM

        mWoodProductBOMs = rProductStructure.ProductWoodBOMs
        mStockItemProductBOMs = rProductStructure.ProductStockItemBOMs


        pWorkOrder.WoodMaterialRequirements.Clear()
        'pWorkOrder.StockItemMaterialRequirements.Clear()

        ' pWorkOrder.WoodMaterialRequirements.SetQuantitysToZero()
        pWorkOrder.StockItemMaterialRequirements.SetQuantitysToZero()
        pWorkOrder.StockItemMaterialRequirements.IsAlreadyUsedFalse()

        For Each mPBOM As dmProductBOM In mWoodProductBOMs


          mNewMatReq = New dmMaterialRequirement
          mNewMatReq.Description = mPBOM.Description
          mNewMatReq.ComponentDescription = mPBOM.ComponentDescription
          mNewMatReq.MaterialRequirementType = eMaterialRequirementType.Wood
          mNewMatReq.MaterialTypeID = mPBOM.MaterialTypeID
          mNewMatReq.NetLenght = mPBOM.NetLenght
          mNewMatReq.NetThickness = mPBOM.NetThickness
          mNewMatReq.NetWidth = mPBOM.NetWidth
          mNewMatReq.ObjectID = pWorkOrder.WorkOrderID
          mNewMatReq.ObjectType = eObjectType.WorkOrder
          mNewMatReq.UnitPiece = mPBOM.UnitPiece * pWorkOrder.Quantity
          mNewMatReq.StockCode = mPBOM.StockCode
          mNewMatReq.StockItemID = mPBOM.StockItemID
          mNewMatReq.SupplierStockCode = mPBOM.SupplierStockCode
          mNewMatReq.TotalPieces = mPBOM.TotalPieces
          mNewMatReq.UoM = mPBOM.UoM
          mNewMatReq.WoodSpecie = mPBOM.WoodSpecie
          mNewMatReq.Comments = mPBOM.Comments
          mNewMatReq.AreaID = mPBOM.AreaID

          mNewMatReq.Quantity = clsSMSharedFuncs.BoardFeetFromCMAndQty(mNewMatReq.UnitPiece, mNewMatReq.NetLenght, mNewMatReq.NetWidth, mNewMatReq.NetThickness)
          pWorkOrder.WoodMaterialRequirements.Add(mNewMatReq)
        Next



        For Each mPBOM As dmProductBOM In mStockItemProductBOMs
          Dim mProductStockItemFound As dmMaterialRequirement

          mProductStockItemFound = pWorkOrder.StockItemMaterialRequirements.ItemFromStockItemIDAndAreaID(mPBOM.StockItemID, mPBOM.AreaID)

          If mProductStockItemFound Is Nothing Then
            mProductStockItemFound = pWorkOrder.StockItemMaterialRequirements.ItemFromStockItemIDProcess(mPBOM.StockItemID)
          End If

          If mProductStockItemFound Is Nothing Then
            mNewMatReq = New dmMaterialRequirement
            mNewMatReq.Description = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPBOM.StockItemID).Description
            mNewMatReq.ComponentDescription = mPBOM.ComponentDescription
            mNewMatReq.MaterialRequirementType = eMaterialRequirementType.StockItems
            mNewMatReq.MaterialTypeID = mPBOM.MaterialTypeID
            mNewMatReq.NetLenght = mPBOM.NetLenght
            mNewMatReq.NetThickness = mPBOM.NetThickness
            mNewMatReq.NetWidth = mPBOM.NetWidth
            mNewMatReq.ObjectID = pWorkOrder.WorkOrderID
            mNewMatReq.ObjectType = eObjectType.WorkOrder
            mNewMatReq.Quantity = mPBOM.Quantity * pWorkOrder.Quantity
            mNewMatReq.StockCode = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPBOM.StockItemID).StockCode
            mNewMatReq.StockItemID = mPBOM.StockItemID
            mNewMatReq.SupplierStockCode = mPBOM.SupplierStockCode
            mNewMatReq.TotalPieces = mPBOM.TotalPieces
            mNewMatReq.UoM = mPBOM.UoM
            mNewMatReq.WoodSpecie = mPBOM.WoodSpecie
            mNewMatReq.Comments = mPBOM.Comments
            mNewMatReq.FromStockQty = 0
            mNewMatReq.GeneratedQty = mPBOM.Quantity * pWorkOrder.Quantity
            mNewMatReq.AreaID = mPBOM.AreaID
            mNewMatReq.SetPickedQty(0)
            mNewMatReq.SetReturndQty(0)
            mNewMatReq.IsAlreadyUsed = True
            pWorkOrder.StockItemMaterialRequirements.Add(mNewMatReq)
          Else
            mProductStockItemFound.Quantity = mPBOM.Quantity * pWorkOrder.Quantity
            mProductStockItemFound.Comments = mPBOM.Comments
            mProductStockItemFound.Description = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mPBOM.StockItemID).Description
            mProductStockItemFound.GeneratedQty = mPBOM.Quantity * pWorkOrder.Quantity
            mProductStockItemFound.AreaID = mPBOM.AreaID
            mProductStockItemFound.IsAlreadyUsed = True
          End If

        Next


      End If


      DeleteNoRequiredMatReqs()

    Else
      MessageBox.Show("La cantidad de la O.T. es 0, revise las cantidades en la distribución de la O.T.")
    End If

  End Sub

  Private Sub DeleteNoRequiredMatReqs()
    Dim mIndex As Integer = 0
    Dim mCount As Integer = pWorkOrder.StockItemMaterialRequirements.Count
    Dim mListIndexCollection As New List(Of Tuple(Of Integer, Integer))
    Dim mRequiredQty As Decimal
    Dim mPickedQty As Decimal
    Dim mReturnQty As Decimal
    Dim mTuple As Tuple(Of Integer, Integer)
    Dim mMaterialRequirementID As Integer
    Dim mStockItemID As Integer
    Dim mMaterialRequirement As dmMaterialRequirement

    While mIndex < mCount - 1
      mRequiredQty = pWorkOrder.StockItemMaterialRequirements(mIndex).Quantity
      mPickedQty = pWorkOrder.StockItemMaterialRequirements(mIndex).PickedQty
      mReturnQty = pWorkOrder.StockItemMaterialRequirements(mIndex).ReturnQty
      mMaterialRequirementID = pWorkOrder.StockItemMaterialRequirements(mIndex).MaterialRequirementID
      mStockItemID = pWorkOrder.StockItemMaterialRequirements(mIndex).StockItemID

      If mRequiredQty = 0 And mPickedQty = 0 And mReturnQty = 0 Then
        mTuple = New Tuple(Of Integer, Integer)(mMaterialRequirementID, mStockItemID)
        mListIndexCollection.Add(mTuple)
      End If
      mIndex = mIndex + 1
    End While


    For mListIndex As Integer = 0 To mListIndexCollection.Count - 1 Step 1

      mMaterialRequirement = pWorkOrder.StockItemMaterialRequirements.GetItemByIDAndStockItemID(mListIndexCollection(mListIndex).Item1, mListIndexCollection(mListIndex).Item2)
      pWorkOrder.StockItemMaterialRequirements.Remove(mMaterialRequirement)
    Next

  End Sub

  Public Sub LoadWoodStockItemsForPicker(ByRef rStockItemsForPickers As colStockItems)
    Dim mdso As New dsoStock(pDBConn)
    Dim mWhere As String



    Try
      mWhere = " Category = " & eStockItemCategory.Timber
      mWhere &= " and ItemType in ("

      For Each mItemTypeID As clsValueItem In eStockItemTypeTimberWood.GetInstance.ValueItems

        Select Case mItemTypeID.ItemValue
          Case eStockItemTypeTimberWood.MAS, eStockItemTypeTimberWood.Primera, eStockItemTypeTimberWood.Segunda, eStockItemTypeTimberWood.Tercera, eStockItemTypeTimberWood.CepilladoPrimera,
               eStockItemTypeTimberWood.CepilladoSegunda, eStockItemTypeTimberWood.CepilladoTercera
            mWhere &= mItemTypeID.ItemValue & ","
        End Select

      Next

      mWhere = mWhere.Substring(0, mWhere.Length - 1)

      mWhere &= ")"
      mdso.LoadStockItemsByWhere(rStockItemsForPickers, mWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

  End Sub

  Public Sub LoadSalesOrderDown(ByVal vSalesOrderID As Integer)

    Dim mdso As New dsoSalesOrder(pDBConn)
    Try
      mdso.LoadSalesOrderDown(pSalesOrder, vSalesOrderID)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

  End Sub

  Public Function GetNewStockitemMatReq(ByVal vStockitem As dmStockItem) As dmMaterialRequirement
    Dim mRetVal As dmMaterialRequirement

    mRetVal = New dmMaterialRequirement

    mRetVal.ObjectID = pWorkOrder.WorkOrderID
    mRetVal.StockItemID = vStockitem.StockItemID
    mRetVal.DateChange = Now
    mRetVal.Description = vStockitem.Description
    mRetVal.NetLenght = vStockitem.Length
    mRetVal.NetWidth = vStockitem.Width
    mRetVal.NetThickness = vStockitem.Thickness
    mRetVal.ObjectType = eObjectType.WorkOrder
    mRetVal.StockCode = vStockitem.StockCode
    mRetVal.UoM = vStockitem.UoM
    mRetVal.WoodSpecie = vStockitem.Species
    mRetVal.MaterialRequirementType = eMaterialRequirementType.StockItems
    mRetVal.GeneratedQty = 0
    Return mRetVal
  End Function
End Class
