Imports RTIS.CommonVB

Public Class fccWorkOrderDetailConstruction
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderItem As dmSalesOrderItem
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pTimeSheetEntrys As colTimeSheetEntrys
  Private pCurrentProduct As dmProductBase
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
  Private pUsedItems As List(Of Integer)
  Private pSalesOrderPhaseItems As colSalesOrderPhaseItems
  Private pWorkOrderAllocationEditors As colWorkOrderAllocationEditors
  Private pProductType As eProductType

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pTimeSheetEntrys = New colTimeSheetEntrys
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
    pUsedItems = New List(Of Integer)
    pSalesOrderPhaseItems = New colSalesOrderPhaseItems
    pWorkOrderAllocationEditors = New colWorkOrderAllocationEditors
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

  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property

  Public Property CurrentProduct As dmProductBase
    Get
      Return pCurrentProduct
    End Get
    Set(value As dmProductBase)
      pCurrentProduct = value
    End Set
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoSales
    Dim mdsoHR As dsoHR
    Dim mSOID As Integer

    mdso = New dsoSales(pDBConn)

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
    Dim mdso As dsoSales

    mdso = New dsoSales(pDBConn)
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


  Public Sub syncronizedMaterialRequirment(ByRef rStockItems As List(Of dmStockItem))
    Dim mMat As dmMaterialRequirement
    Dim mFurniture As dmProductFurniture
    Dim mFound As Boolean

    mFurniture = pWorkOrder.Product

    For Each mSI As dmStockItem In rStockItems
      If mFurniture.MaterialRequirmentOthers.IndexFromStockItemID(mSI.StockItemID) = -1 Then
        mMat = New dmMaterialRequirement

        mMat.ObjectID = pWorkOrder.WorkOrderID
        mMat.ObjectType = eObjectType.WorkOrder
        mMat.StockItemID = mSI.StockItemID
        mFurniture.MaterialRequirmentOthers.Add(mMat)
      End If
    Next

    For mLoop As Integer = mFurniture.MaterialRequirmentOthers.Count - 1 To 0 Step -1
      mFound = False
      mMat = mFurniture.MaterialRequirmentOthers(mLoop)
      If mMat.StockItemID <> 0 Then '// this leaves the manual ones alone
        For Each mSI As dmStockItem In rStockItems
          If mMat.StockItemID = mSI.StockItemID Then
            mFound = True
            Exit For
          End If
        Next
        If mFound = False Then
          mFurniture.MaterialRequirmentOthers.RemoveAt(mLoop)
        End If
      End If
    Next


  End Sub

  Public Sub syncronizedMaterialRequirmentChanges(ByRef rStockItems As List(Of dmStockItem))
    Dim mMat As dmMaterialRequirement
    Dim mFurniture As dmProductFurniture
    Dim mFound As Boolean

    mFurniture = pWorkOrder.Product

    For Each mSI As dmStockItem In rStockItems
      If mFurniture.MaterialRequirmentOthersChanges.IndexFromStockItemID(mSI.StockItemID) = -1 Then
        mMat = New dmMaterialRequirement

        mMat.ObjectID = pWorkOrder.WorkOrderID
        mMat.ObjectType = eObjectType.WorkOrder
        mMat.StockItemID = mSI.StockItemID
        mFurniture.MaterialRequirmentOthersChanges.Add(mMat)
      End If
    Next

    For mLoop As Integer = mFurniture.MaterialRequirmentOthersChanges.Count - 1 To 0 Step -1
      mFound = False
      mMat = mFurniture.MaterialRequirmentOthersChanges(mLoop)
      If mMat.StockItemID <> 0 Then '// this leaves the manual ones alone
        For Each mSI As dmStockItem In rStockItems
          If mMat.StockItemID = mSI.StockItemID Then
            mFound = True
            Exit For
          End If
        Next
        If mFound = False Then
          mFurniture.MaterialRequirmentOthersChanges.RemoveAt(mLoop)
        End If
      End If
    Next

  End Sub
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

    mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
    mExportOptions.ConvertImagesToJpeg = False

    rReport.ExportToPdf(vFilePath, mExportOptions)

    mPDFAmalg.PDFFileName = vFilePath
    mPDFAmalg.CreateNewDocument()

    If IO.File.Exists(vFilePath) Then
      mPDFAmalg.ImportPDFDocument(vFilePath)
    End If

    For Each mFileTracker In pWorkOrder.WOFiles
      If mFileTracker.IncludeInPack Then
        mFilePath = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.WorkOrderFileFolderUsr, pSalesOrder.DateEntered.Year, clsGeneralA.GetFileSafeName(pWorkOrder.WorkOrderID.ToString("00000")), mFileTracker.FileName)

        If IO.File.Exists(mFilePath) Then
          mPDFAmalg.ImportPDFDocument(mFilePath)
        End If
      End If
    Next

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
    mdso.LoadProductInfosByWhere(mRetVal, "")
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

  Public Sub LoadSalesOrderPhaseItemsByWhere(ByRef rSalesOrderPhaseItemInfo As colSalesOrderPhaseItemInfos, ByVal vWhere As String)

    Dim mdso As New dsoSales(DBConn)

    mdso.LoadSalesOrderPhaseItemsByWhere(rSalesOrderPhaseItemInfo, vWhere)

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
    Dim mdsoSales As dsoSales
    Dim mSOPIs As New colSalesOrderPhaseItemInfos
    Dim mSOPI As clsSalesOrderPhaseItemInfo
    Dim mWhere As String = ""

    If pWorkOrder IsNot Nothing Then
      If pWorkOrder.WorkOrderAllocations IsNot Nothing And pWorkOrder.WorkOrderAllocations.Count > 0 Then

        pWorkOrderAllocationEditors.Clear()
        For Each mWorkOrderAllocation As dmWorkOrderAllocation In pWorkOrder.WorkOrderAllocations
          '// create a new editor based on this salesitem and add to collection
          mWOAE = New clsWorkOrderAllocationEditor(pWorkOrder, mWorkOrderAllocation)
          pWorkOrderAllocationEditors.Add(mWOAE)
          mWorkOrderAllocation.QuantityDone = mWOAE.QuantityDone
          If mWhere <> "" Then mWhere &= ","
          mWhere = mWhere & mWorkOrderAllocation.SalesOrderPhaseItemID
        Next

        mWhere = "SalesOrderPhaseItemID In (" & mWhere & ")"

        mdsoSales = New dsoSales(pDBConn)
        mdsoSales.LoadSalesOrderPhaseItemInfos(mSOPIs, mWhere, AppRTISGlobal.GetInstance.ProductRegistry)

        For Each mWorkOrderAllocationEditor As clsWorkOrderAllocationEditor In pWorkOrderAllocationEditors
          mSOPI = mSOPIs.ItemFromKey(mWorkOrderAllocationEditor.SalesOrderPhaseItemID)
          mWorkOrderAllocationEditor.PopulateSalesOrderPhaseItemInfo(mSOPI)
        Next

      End If
    End If



  End Sub

  Public Sub GetNextWONumber()
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    pWorkOrder.WorkOrderNo = "S-" & mdsoGeneral.GetNextTallyWONo().ToString("00000")
  End Sub
End Class
