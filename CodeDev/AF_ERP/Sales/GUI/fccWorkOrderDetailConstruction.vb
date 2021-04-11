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

  Public Property SalesOrderPhaseItems As colSalesOrderPhaseItems
    Get
      Return pSalesOrderPhaseItems
    End Get
    Set(value As colSalesOrderPhaseItems)
      pSalesOrderPhaseItems = value
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

  Public Sub CreateWorkOrderPack(ByRef rReport As DevExpress.XtraReports.UI.XtraReport, ByVal vFilePath As String)
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



    'For Each mFileTracker In pWorkOrder.WOFiles
    '  If mFileTracker.IncludeInPack Then
    '    mFilePath = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderUsr, pSalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pWorkOrder.WorkOrderID.ToString("00000")), mFileTracker.FileName)

    '    If IO.File.Exists(mFilePath) Then
    '      mPDFAmalg.ImportPDFDocument(mFilePath)
    '    End If
    '  End If
    'Next

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
    Dim mSOPI As clsSalesOrderPhaseInfo
    Dim mWhere As String = ""
    Dim mSOID As Integer

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
              mSOID = mdsoSales.GetSalesOrderIDBySalesOrderItemID(pWorkOrder.SalesOrderItemID)

              mdsoSales.LoadSalesOrderDown(pSalesOrder, mSOID)
            End If
            mWhere = "SalesOrderPhaseID = " & pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseID


            mdsoSales.LoadSalesOrderPhaseInfos(mSOPs, mWhere)


            For Each mWorkOrderAllocationEditor As clsWorkOrderAllocationEditor In pWorkOrderAllocationEditors
              mSOPI = mSOPs.ItemFromSalesOrderPhaseID(pSalesOrder.SalesOrderPhases(0).SalesOrderPhaseID)
              mWorkOrderAllocationEditor.PopulateSalesOrderPhaseItemInfo(mSOPI)
            Next
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

    If rProductStructure IsNot Nothing Then

      ''//Create Wood MatReq from WoodBOM

      mWoodProductBOMs = rProductStructure.ProductWoodBOMs
      mStockItemProductBOMs = rProductStructure.ProductStockItemBOMs

      pWorkOrder.WoodMaterialRequirements.Clear()
      pWorkOrder.StockItemMaterialRequirements.Clear()

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

        pWorkOrder.WoodMaterialRequirements.Add(mNewMatReq)
      Next



      For Each mPBOM As dmProductBOM In mStockItemProductBOMs


        mNewMatReq = New dmMaterialRequirement
          mNewMatReq.Description = mPBOM.Description
          mNewMatReq.ComponentDescription = mPBOM.ComponentDescription
          mNewMatReq.MaterialRequirementType = eMaterialRequirementType.StockItems
          mNewMatReq.MaterialTypeID = mPBOM.MaterialTypeID
          mNewMatReq.NetLenght = mPBOM.NetLenght
          mNewMatReq.NetThickness = mPBOM.NetThickness
          mNewMatReq.NetWidth = mPBOM.NetWidth
          mNewMatReq.ObjectID = pWorkOrder.WorkOrderID
          mNewMatReq.ObjectType = eObjectType.WorkOrder
          mNewMatReq.Quantity = mPBOM.Quantity * pWorkOrder.Quantity
          mNewMatReq.StockCode = mPBOM.StockCode
          mNewMatReq.StockItemID = mPBOM.StockItemID
          mNewMatReq.SupplierStockCode = mPBOM.SupplierStockCode
          mNewMatReq.TotalPieces = mPBOM.TotalPieces
          mNewMatReq.UoM = mPBOM.UoM
          mNewMatReq.WoodSpecie = mPBOM.WoodSpecie
        mNewMatReq.Comments = mPBOM.Comments

        pWorkOrder.StockItemMaterialRequirements.Add(mNewMatReq)

      Next


    End If





  End Sub

  Public Sub LoadWoodStockItemsForPicker(ByRef rStockItemsForPickers As colStockItems)
    Dim mdso As New dsoStock(pDBConn)
    Dim mWhere As String



    Try
      mWhere = "Category = " & eStockItemCategory.Timber
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


End Class
