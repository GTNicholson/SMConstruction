﻿Imports RTIS.CommonVB

Public Class fccWorkOrderDetail
  Private pPrimaryKeyID As Integer

  Private pWorkOrder As dmWorkOrder
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderItem As dmSalesOrderItem
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pTimeSheetEntrys As colTimeSheetEntrys
  Private pIsInternal As Boolean

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vIsInternal As Boolean)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pTimeSheetEntrys = New colTimeSheetEntrys
    pIsInternal = vIsInternal

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

  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property


  Public Sub LoadObjects()
    Dim mdso As dsoSalesOrder
    Dim mdsoHR As dsoHR
    Dim mSOID As Integer

    mdso = New dsoSalesOrder(pDBConn)

    If pPrimaryKeyID = 0 Then
      '// if it is new work order it will be internal - Sales Order Work Orders will be created from the salesorder form
      pWorkOrder = clsWorkOrderHandler.CreateInternalWorkOrder(eProductType.ProductFurniture)
    Else
      If pWorkOrder Is Nothing Then '//Not already loaded
        pWorkOrder = New dmWorkOrder
        mdso.LoadWorkOrderDown(pWorkOrder, pPrimaryKeyID)
      End If

      '// if it is a salesorder, check that the remaining details have been loaded and assigned
      If pIsInternal = False Then
        If pSalesOrder Is Nothing Then
          mSOID = mdso.GetSalesOrderIDFromWorkOrderID(pPrimaryKeyID)

          pSalesOrder = New dmSalesOrder
          mdso.LoadSalesOrderDown(pSalesOrder, mSOID)

        End If
        For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems
          For Each mWO As dmWorkOrder In mSOI.WorkOrders
            If mWO.WorkOrderID = pPrimaryKeyID Then
              pWorkOrder = mWO
              pWorkOrder.ParentSalesOrderItem = msoi
              Exit For
            End If
          Next
          If pWorkOrder.ParentSalesOrderItem IsNot Nothing Then Exit For
        Next

        '// WorkOrder and SalesOrder already provided so just need to set the SalesOrderItem
        pSalesOrderItem = pWorkOrder.ParentSalesOrderItem
      End If

      mdsoHR = New dsoHR(pDBConn)
      pTimeSheetEntrys = New colTimeSheetEntrys
      mdsoHR.LoadTimeSheetEntrysWorkOrder(pTimeSheetEntrys, pWorkOrder.WorkOrderID)

    End If
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
    If pWorkOrder.IsAnyDirty Then mRetVal = True
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

  Public Sub GetNextWONumber()
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    pWorkOrder.WorkOrderNo = "S-" & mdsoGeneral.GetNextTallyWONo().ToString("00000")
  End Sub
End Class
