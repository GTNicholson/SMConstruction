Imports DevExpress.CodeParser
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements
Imports RTIS.ERPCore

Public Class fccPurchaseOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pPrimaryKeyID As Integer
  Private pPurchaseOrder As dmPurchaseOrder
  Private pSuppliers As colSuppliers

  Private pUsedItems As List(Of Integer)
  Private pBrowseRefreshTracker As clsBasicBrowseRefreshTracker
  Private pPODeliveryInfos As colPODeliveryInfos
  Private pSalesOrderPhases As colSalesOrderPhases
  Private pPOIEditor As clsPOItemEditor
  Private pcolPOIEditor As colPOItemEditors
  Private pSalesOrderPhaseInfo As clsSalesOrderPhaseInfo
  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pPurchaseOrder = New dmPurchaseOrder
    pRTISGlobal = rRTISGlobal
    pSalesOrderPhases = New colSalesOrderPhases
    pUsedItems = New List(Of Integer)
    pSuppliers = New colSuppliers
    pPOIEditor = New clsPOItemEditor
    pcolPOIEditor = New colPOItemEditors
    pPODeliveryInfos = New colPODeliveryInfos
    pSalesOrderPhaseInfo = New clsSalesOrderPhaseInfo
  End Sub

  Public Property SalesOrderPhaseInfo() As clsSalesOrderPhaseInfo
    Get
      Return pSalesOrderPhaseInfo
    End Get
    Set(value As clsSalesOrderPhaseInfo)
      pSalesOrderPhaseInfo = value
    End Set
  End Property

  Public Property PODeliveryInfos As colPODeliveryInfos
    Get
      Return pPODeliveryInfos
    End Get
    Set(value As colPODeliveryInfos)
      pPODeliveryInfos = value
    End Set
  End Property

  Public Property RTISGlobal() As AppRTISGlobal
    Get
      RTISGlobal = pRTISGlobal
    End Get
    Set(ByVal value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public Property SalesOrderPhases As colSalesOrderPhases
    Get
      Return pSalesOrderPhases
    End Get
    Set(value As colSalesOrderPhases)
      pSalesOrderPhases = value
    End Set
  End Property

  Public Property POIEditor As clsPOItemEditor
    Get
      Return pPOIEditor
    End Get
    Set(value As clsPOItemEditor)
      pPOIEditor = value
    End Set
  End Property

  Public Property POIEditors As colPOItemEditors
    Get
      Return pcolPOIEditor
    End Get
    Set(value As colPOItemEditors)
      pcolPOIEditor = value
    End Set
  End Property
  Public Property PrimaryKeyID() As Integer
    Get
      PrimaryKeyID = pPrimaryKeyID
    End Get
    Set(ByVal value As Integer)
      pPrimaryKeyID = value

    End Set
  End Property


  Public Property PurchaseOrder As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property
  Public Sub ReloadSupplier()
    Dim mdso As dsoPurchasing
    Try
      mdso = New dsoPurchasing(pDBConn)
      mdso.LoadSupplierDown(pPurchaseOrder.Supplier, pPurchaseOrder.SupplierID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub
  Public Sub LoadPODeliveryInfos()
    Dim mdso As dsoPurchasing
    Dim mWhere As String = ""
    Try
      mdso = New dsoPurchasing(pDBConn)

      mWhere = "PurchaseOrderID = " & PurchaseOrder.PurchaseOrderID & " and GRNumber<>'' and Status<>" & ePODelivery.Cancelled
      mdso.LoadPODeliveryInfoByWhere(pPODeliveryInfos, mWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Property Suppliers As colSuppliers
    Get
      Return pSuppliers
    End Get
    Set(value As colSuppliers)
      pSuppliers = value
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

  Public Property BrowseRefreshTracker As clsBasicBrowseRefreshTracker
    Get
      Return pBrowseRefreshTracker
    End Get
    Set(value As clsBasicBrowseRefreshTracker)
      pBrowseRefreshTracker = value
    End Set
  End Property


  Public Function LoadRefData() As Boolean

    Dim mOK As Boolean
    Dim mdsoSales As New dsoSales(pDBConn)
    Dim mSalesOrderPhase As dmSalesOrderPhase
    Try

      mOK = True
      pSalesOrderPhases = New colSalesOrderPhases

      For Each mPOAllocation As dmPurchaseOrderAllocation In pPurchaseOrder.PurchaseOrderAllocations
        If pSalesOrderPhases.IndexFromKey(mPOAllocation.CallOffID) = -1 Then
          mSalesOrderPhase = New dmSalesOrderPhase
          mdsoSales.LoadSalesOrderPhase(mSalesOrderPhase, mPOAllocation.CallOffID)
          pSalesOrderPhases.Add(mSalesOrderPhase)
        End If

        If pUsedItems.Contains(mPOAllocation.CallOffID) = False Then
          pUsedItems.Add(mPOAllocation.CallOffID)
        End If
      Next

      If pPurchaseOrder.PurchaseOrderAllocations.Count > 0 Then

        If pPurchaseOrder.PurchaseOrderAllocations.Count = 1 Then
          mdsoSales.LoadSalesOrderPhaseInfo(Me.SalesOrderPhaseInfo, "SalesOrderPhaseID = " & pPurchaseOrder.PurchaseOrderAllocations(0).CallOffID)

        End If

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function


  Public Sub LoadSuppliers()
    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    pSuppliers = New colSuppliers

    If pDBConn.Connect Then
      mdtoSupplier.LoadSupplierCollection(pSuppliers)

    End If
    pDBConn.Disconnect()
  End Sub
  Public Sub ReloadPODeliveryInfos()
    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)
    PODeliveryInfos.Clear()
    Dim mWhere As String = "PurchaseOrderID = " & pPurchaseOrder.PurchaseOrderID & " and GRNumber<>'' and Status<>" & ePODelivery.Cancelled

    mdsoPurchaseOrder.LoadPODeliveryInfoByWhere(PODeliveryInfos, mWhere)

  End Sub

  Public Function LoadObject() As Boolean

    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)
    Dim mOK As Boolean
    Try

      mOK = True
      pPurchaseOrder = New dmPurchaseOrder

      pUsedItems = New List(Of Integer)
      If pPrimaryKeyID > 0 Then


        mOK = mdsoPurchaseOrder.LoadPurchaseOrderDown(Me.PurchaseOrder, Me.PrimaryKeyID)


      Else
        pPurchaseOrder.SubmissionDate = Today
        pPurchaseOrder.DefaultCurrency = pPurchaseOrder.Supplier.DefaultCurrency
        pPurchaseOrder.ExchangeRateValue = GetExchangeRate(Today, eCurrency.Cordobas)
        pPurchaseOrder.Status = ePurchaseOrderDueDateStatus.Confirmed
        GetNextPONo()
        SaveObject()
        mOK = True
      End If
      ''mdsoPurchaseOrder = Nothing
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoPurchaseOrder = Nothing
    End Try
    Return mOK

  End Function

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    If Not PurchaseOrder Is Nothing Then
      mIsDirty = PurchaseOrder.IsAnyDirty
    Else
      mIsDirty = False
    End If
    Return mIsDirty
  End Function

  Public Function ValidateObject() As clsValidate
    Dim mValidate As New clsValidate
    mValidate.ValOk = True
    If False Then '' Change to perform validation checks
      mValidate.ValOk = False
      mValidate.AddMsgLine("Falló la verificación de detalles")
    End If
    Return mValidate
  End Function

  Public Function SaveObject() As Boolean
    Dim mOK As Boolean = False
    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)


    Try

      mOK = mdsoPurchaseOrder.SavePurchaseOrderDownNEW(Me.PurchaseOrder)

      If pPrimaryKeyID = 0 Then
        pPrimaryKeyID = PurchaseOrder.PurchaseOrderID
      End If
      If pBrowseRefreshTracker IsNot Nothing Then pBrowseRefreshTracker.RefreshAll = True

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoPurchaseOrder = Nothing
    End Try

    Return mOK
  End Function


  Public Sub CreatePurchaseOrderPack(ByRef rReport As repPurchaseOrder, ByVal vFilePath As String)
    Dim mExportOptions As DevExpress.XtraPrinting.PdfExportOptions
    Dim mPDFAmalg As New RTIS.PDFUtils.PDFAmal
    Dim mFilePath As String

    mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
    mExportOptions.ConvertImagesToJpeg = False

    rReport.ExportToPdf(vFilePath, mExportOptions)


  End Sub
  Public Function UpdateCOMOs() As Boolean
    Dim mOK As Boolean = False
    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)

    Return mOK
  End Function

  Public Sub ClearObjects()

    Me.PurchaseOrder = Nothing

  End Sub



  Public Function LoadStockItemsForPicker() As colStockItems
    Dim mStockITems As New colStockItems
    Dim mRetVal As New List(Of dmStockItem)


    Return mStockITems
  End Function
  Public Function GetSupplierList() As colSuppliers
    Dim mRetVal As New colSuppliers
    Dim mdso As dsoPurchasing
    Try
      mdso = New dsoPurchasing(pDBConn)
      mdso.LoadSuppliersByWhere(mRetVal, "CompanyName is not null")
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub GetNextPONo()
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    pPurchaseOrder.PONum = mdsoGeneral.GetNextTallyPONo().ToString("00000")
  End Sub

  Public Sub CreatePurchaseOrderPDF(ByVal vCurrency As eCurrency, ByVal vAccountOption As Int32, ByVal vIsPaymentOrder As Boolean)
    Dim mPOInfo As New clsPurchaseOrderInfo
    Dim mPOItemInfos As New colPOItemInfos
    Dim mBuyer As dmEmployee
    Dim mEmployees As colEmployees
    Dim mRep As repPurchaseOrder
    Dim mFileName As String
    Dim mDirectory As String
    Dim mExportFilename As String
    Dim mPaymentReportPath As String
    Try
      mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.PurchaseOrderFileFolderSys)
      If System.IO.Directory.Exists(mDirectory) = False Then
        System.IO.Directory.CreateDirectory(mDirectory)
      End If


      mFileName = String.Format("PurchaseOrder_{0}_{1}.pdf", pPurchaseOrder.PONum, Today.ToString("yyyyMMdd_HHmm"))
      mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)

      mPOInfo.PurchaseOrder = pPurchaseOrder
      For Each mPOItem As dmPurchaseOrderItem In pPurchaseOrder.PurchaseOrderItems
        If String.IsNullOrEmpty(mPOItem.Description) = False Then
          mPOItemInfos.Add(New clsPOItemInfo(mPOItem, Nothing))
        End If
      Next
      mPOInfo.POItemInfos = mPOItemInfos
      mEmployees = pRTISGlobal.RefLists.RefIList(appRefLists.Employees)
      mBuyer = mEmployees.ItemFromKey(pPurchaseOrder.BuyerID)

      mRep = repPurchaseOrder.CreateReport(mPOInfo, mBuyer, False, vCurrency)

      mRep.ExportToPdf(mExportFilename)

      Dim mProjectName As String = ""
      If pSalesOrderPhaseInfo IsNot Nothing Then
        If pSalesOrderPhaseInfo.ProjectName <> "" Then
          mProjectName = pSalesOrderPhaseInfo.ProjectName
        Else
          mProjectName = "Consumo Interno"
        End If
      Else
        mProjectName = "Consumo Interno"

      End If

      If vIsPaymentOrder Then

        Select Case vAccountOption
          Case eSupplirPrintOption.MainAccount
            mPaymentReportPath = CreatePaymetReport(mPOInfo, mBuyer, vCurrency, mProjectName, pPurchaseOrder.Supplier.AccountCode)

          Case eSupplirPrintOption.SecondaryAccount
            mPaymentReportPath = CreatePaymetReport(mPOInfo, mBuyer, vCurrency, mProjectName, pPurchaseOrder.Supplier.AccountSecondaryNumber)

          Case Else
            mPaymentReportPath = CreatePaymetReport(mPOInfo, mBuyer, vCurrency, mProjectName, pPurchaseOrder.Supplier.AccountCode)

        End Select
        pPurchaseOrder.FileName = mExportFilename
        ImportPDFs(mExportFilename, mPaymentReportPath)

      End If

      SaveObject()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub

  Private Sub ImportPDFs(ByVal vFilePath As String, ByVal vFilePathPayment As String)
    Dim mPDFAmalg As New RTIS.PDFUtils.PDFAmal
    Dim mFilePath As String

    mPDFAmalg.PDFFileName = vFilePath
    mPDFAmalg.CreateNewDocument()

    If IO.File.Exists(vFilePath) Then
      mPDFAmalg.ImportPDFDocument(vFilePath)
    End If

    mFilePath = IO.Path.Combine(RTISGlobal.DefaultExportPath, clsConstants.PurchaseOrderFileFolderSys, pPurchaseOrder.SubmissionDate.Year, clsGeneralA.GetFileSafeName(pPurchaseOrder.PurchaseOrderID.ToString("00000")), vFilePathPayment)

    If IO.File.Exists(mFilePath) Then
          mPDFAmalg.ImportPDFDocument(mFilePath)

    End If


    mPDFAmalg.SavePDFDocument()

  End Sub

  Public Function CreatePaymetReport(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vCurrency As eCurrency, ByVal vProjectName As String, ByVal vAccountCode As String) As String

    Dim mFileName As String
    Dim mDirectory As String
    Dim mExportFilename As String
    Dim mRep As repCheckPaymentOrder

    Try
      mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.PurchaseOrderFileFolderSys)
      If System.IO.Directory.Exists(mDirectory) = False Then
        System.IO.Directory.CreateDirectory(mDirectory)
      End If
      mFileName = String.Format("PaymentCheckOrder_{0}_{1}.pdf", pPurchaseOrder.PONum, Today.ToString("yyyyMMdd_HHmm"))
      mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)

      mRep = repCheckPaymentOrder.CreateReport(rPOInfo, rBuyer, False, vCurrency, vProjectName, vAccountCode)

      mRep.ExportToPdf(mExportFilename)

      Return mExportFilename
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Function

  Public ReadOnly Property PlaceHolders As Dictionary(Of String, String)
    Get
      Dim mRetVal As New Dictionary(Of String, String)
      Dim mPrefix As String = "{"
      Dim mSuffix As String = "}"

      mRetVal.Add(mPrefix & "CompanyName" & mSuffix, pSuppliers(0).CompanyName)
      mRetVal.Add(mPrefix & "PO" & mSuffix, pPurchaseOrder.PONum)
      mRetVal.Add(mPrefix & "CalculateNetValue" & mSuffix, pPurchaseOrder.CalculateNetValue.ToString("N2"))
      mRetVal.Add(mPrefix & "RequiredDate" & mSuffix, Me.pPurchaseOrder.RequiredDate)


      Return mRetVal
    End Get
  End Property

  Public Function GetTotalNetValue() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mPOI As dmPurchaseOrderItem In PurchaseOrder.PurchaseOrderItems
      mRetVal += mPOI.NetAmount
    Next

    Return mRetVal
  End Function


  Public Function LoadSalesOrderPhaseInfo(ByRef rSalesOrderPhaseInfos As colSalesOrderPhaseInfos, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderPhaseInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseInfo(pDBConn)
      mdto.LoadSOPCollectionByWhere(rSalesOrderPhaseInfos, vWhere)


      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Sub CreateUpdatePOItemAllocation(ByRef rPOItem As dmPurchaseOrderItem)
    Dim mPOIA As dmPurchaseOrderItemAllocation

    If rPOItem.PurchaseOrderItemAllocations.Count <= 1 Then
      '//Check that the POItem has one and only one poItemAllocation
      If rPOItem.PurchaseOrderItemAllocations.Count = 0 Then
        '// Create one
        mPOIA = New dmPurchaseOrderItemAllocation
        mPOIA.PurchaseOrderItemID = rPOItem.PurchaseOrderItemID




        rPOItem.PurchaseOrderItemAllocations.Add(mPOIA)
      End If
      '// if 0 then create one for Stock, or for the only phase that is in 
      rPOItem.PurchaseOrderItemAllocations(0).Quantity = rPOItem.QtyRequired
      If pSalesOrderPhaseInfo IsNot Nothing Then
        rPOItem.PurchaseOrderItemAllocations(0).CallOffID = pSalesOrderPhaseInfo.SalesOrderPhaseID
        rPOItem.PurchaseOrderItemAllocations(0).JobNoTmp = pSalesOrderPhaseInfo.SOPJobNo
      Else
        rPOItem.PurchaseOrderItemAllocations(0).CallOffID = 0
        rPOItem.PurchaseOrderItemAllocations(0).JobNoTmp = "A Inventario"
      End If
      '// Update the qty ot the neew value
    End If
  End Sub

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(DBConn)
    Dim mExchangeRate As Decimal = 0

    mExchangeRate = mdsoGeneral.GetExchangeRate(vDate, vCurrency)

    Return mExchangeRate
  End Function

  Public Sub ReloadPOItems()
    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)
    Dim mOK As Boolean = True


    PurchaseOrder.PurchaseOrderItems.Clear()

    If mOK Then mOK = mdsoPurchaseOrder.ReloadPurchaseOrderItems(pPurchaseOrder.PurchaseOrderItems, pPurchaseOrder.PurchaseOrderID)
  End Sub
End Class
