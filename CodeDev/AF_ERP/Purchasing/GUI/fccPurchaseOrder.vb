Imports DevExpress.CodeParser
Imports DevExpress.Pdf
Imports DevExpress.XtraPrinting.Drawing
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
  Private pUsedItemsWO As List(Of Integer)
  Private pPOOption As ePODetailOption
  Private pBrowseRefreshTracker As clsBasicBrowseRefreshTracker
  Private pPODeliveryInfos As colPODeliveryInfos
  Private pPOIEditor As clsPOItemEditor
  Private pcolPOIEditor As colPOItemEditors
  Private pSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
  Private pCurrentDefaultCurrency As eCurrency
  Private pSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos
  Private pWorkOrderInfo As clsWorkOrderInfo
  Private pWorkOrderInfos As colWorkOrderInfos

  Public Property CompanyOption As repPurchaseOrder.eCompanyOption

  Public Property POOption As ePODetailOption
    Get
      Return pPOOption
    End Get
    Set(value As ePODetailOption)
      pPOOption = value
    End Set
  End Property


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
    pUsedItems = New List(Of Integer)
    pUsedItemsWO = New List(Of Integer)

    pSuppliers = New colSuppliers
    pPOIEditor = New clsPOItemEditor
    pcolPOIEditor = New colPOItemEditors
    pPODeliveryInfos = New colPODeliveryInfos
    pSalesOrderPhaseItemInfo = New clsSalesOrderPhaseItemInfo
    pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
    pWorkOrderInfos = New colWorkOrderInfos
  End Sub

  Public Property SalesOrderPhaseItemInfo() As clsSalesOrderPhaseItemInfo
    Get
      Return pSalesOrderPhaseItemInfo
    End Get
    Set(value As clsSalesOrderPhaseItemInfo)
      pSalesOrderPhaseItemInfo = value
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
  Public Property WorkOrderInfos As colWorkOrderInfos
    Get
      Return pWorkOrderInfos
    End Get
    Set(value As colWorkOrderInfos)
      pWorkOrderInfos = value
    End Set
  End Property

  Public Property WorkOrderInfo As clsWorkOrderInfo
    Get
      Return pWorkOrderInfo
    End Get
    Set(value As clsWorkOrderInfo)
      pWorkOrderInfo = value
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

  Public Property UsedItemsWO As List(Of Integer)
    Get
      Return pUsedItemsWO
    End Get
    Set(value As List(Of Integer))
      pUsedItemsWO = value
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
    Dim mdsoSales As New dsoSalesOrder(pDBConn)
    Dim mSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
    Dim mWorkOrderInfo As clsWorkOrderInfo
    Dim mSalesOrderPhaseItemInfos As New colSalesOrderPhaseItemInfos
    Dim mWhere As String

    Try

      mOK = True
      pSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
      pWorkOrderInfos = New colWorkOrderInfos

      Select Case pPOOption
        Case ePODetailOption.ManPO

          For Each mPOAllocation As dmPurchaseOrderAllocation In pPurchaseOrder.PurchaseOrderAllocations
            If pWorkOrderInfos.IndexFromWorkOrderID(mPOAllocation.WorkOrderID) = -1 Then
              mWorkOrderInfo = New clsWorkOrderInfo
              mdsoSales.LoadWorkOrderInfo(mWorkOrderInfo, "WorkOrderID=" & mPOAllocation.WorkOrderID)
              pWorkOrderInfos.Add(mWorkOrderInfo)
            End If

            If pUsedItemsWO.Contains(mPOAllocation.WorkOrderID) = False Then
              pUsedItemsWO.Add(mPOAllocation.WorkOrderID)
            End If
          Next



        Case ePODetailOption.NonManPO
          For Each mPOAllocation As dmPurchaseOrderAllocation In pPurchaseOrder.PurchaseOrderAllocations
            If pSalesOrderPhaseItemInfos.IndexFromSOPhaseItemID(mPOAllocation.SalesorderPhaseItemID) = -1 Then
              mSalesOrderPhaseItemInfo = New clsSalesOrderPhaseItemInfo
              mSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos

              mWhere = String.Format("DateRequired is not null AND OrderStatusENUM not in ({0})", CInt(eSalesOrderstatus.Cancelada), CInt(eSalesOrderstatus.Completed))

              mWhere &= " and SalesOrderPhaseItemID = " & mPOAllocation.SalesorderPhaseItemID

              mdsoSales.LoadSalesOrderPhaseItemsInfosByWhere(mSalesOrderPhaseItemInfos, mWhere)

              If mSalesOrderPhaseItemInfos.Count > 0 Then
                mSalesOrderPhaseItemInfo = mSalesOrderPhaseItemInfos(0)
                pSalesOrderPhaseItemInfos.Add(mSalesOrderPhaseItemInfo)

              End If

            End If


            If pUsedItems.Contains(mPOAllocation.SalesorderPhaseItemID) = False Then
              pUsedItems.Add(mPOAllocation.SalesorderPhaseItemID)
            End If

            If pUsedItemsWO.Contains(mPOAllocation.WorkOrderID) = False Then
              pUsedItemsWO.Add(mPOAllocation.WorkOrderID)
            End If
          Next

      End Select


      If pPurchaseOrder.PurchaseOrderAllocations.Count > 0 Then

        If pPurchaseOrder.PurchaseOrderAllocations.Count = 1 Then
          mWhere = String.Format("DateRequired is not null AND OrderStatusENUM not in ({0})", CInt(eSalesOrderstatus.Cancelada), CInt(eSalesOrderstatus.Completed))

          mWhere &= " and SalesOrderPhaseItemID = " & pPurchaseOrder.PurchaseOrderAllocations(0).SalesorderPhaseItemID
          mSalesOrderPhaseItemInfos = New colSalesOrderPhaseItemInfos
          mdsoSales.LoadSalesOrderPhaseItemsInfosByWhere(mSalesOrderPhaseItemInfos, mWhere)
          If mSalesOrderPhaseItemInfos.Count > 0 Then
            Me.SalesOrderPhaseItemInfo = mSalesOrderPhaseItemInfos(0)
            ''This is new for the WOAllocation
          End If
          mdsoSales.LoadWorkOrderInfo(Me.pWorkOrderInfo, "WorkOrderID = " & pPurchaseOrder.PurchaseOrderAllocations(0).WorkOrderID)

        End If

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      mdsoSales = Nothing
    End Try
    Return mOK
  End Function


  Public Sub LoadSuppliers()
    Dim mdso As New dsoPurchasing(pDBConn)
    pSuppliers = New colSuppliers

    If pDBConn.Connect Then
      mdso.LoadSuppliersByWhere(pSuppliers, "SupplierStatusID <>" & CInt(eSupplierStatus.Inactive))


    End If
    If pDBConn.IsConnected Then pDBConn.Disconnect()
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
      pUsedItemsWO = New List(Of Integer)

      If pPrimaryKeyID > 0 Then


        mOK = mdsoPurchaseOrder.LoadPurchaseOrderDown(Me.PurchaseOrder, Me.PrimaryKeyID)

      Else
        pPurchaseOrder.SubmissionDate = Today
        pPurchaseOrder.DefaultCurrency = pPurchaseOrder.Supplier.DefaultCurrency
        pPurchaseOrder.ExchangeRateValue = GetExchangeRate(Today, eCurrency.Cordobas)

        Select Case pPOOption
          Case ePODetailOption.ManPO
            pPurchaseOrder.MaterialRequirementTypeWorkOrderID = ePOMaterialRequirementType.Inventario

          Case ePODetailOption.NonManPO
            pPurchaseOrder.MaterialRequirementTypeID = ePOMaterialRequirementType.Sencillo

          Case ePODetailOption.General
            pPurchaseOrder.MaterialRequirementTypeID = 0
            pPurchaseOrder.MaterialRequirementTypeWorkOrderID = 0


        End Select

        pPurchaseOrder.Status = ePurchaseOrderDueDateStatus.Confirmed
        pPurchaseOrder.ValuationMode = eValuationMode.ForAdvanced
        pPurchaseOrder.BuyerID = 1


        GetNextPONo()
        SaveObject()
        mOK = True
      End If
      pCurrentDefaultCurrency = pPurchaseOrder.DefaultCurrency
      'pWorkOrderAllocationInfos = GetWorkOrderAllocationInfos()
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
      If pPurchaseOrder.SupplierID > 0 Then

        For Each mPOI As dmPurchaseOrderItem In pPurchaseOrder.PurchaseOrderItems
          CreateUpdatePOItemAllocation(mPOI, False)
        Next
        mOK = mdsoPurchaseOrder.SavePurchaseOrderDownNEW(Me.PurchaseOrder)

      End If


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
    If pPurchaseOrder.PONum = "" Then
      pPurchaseOrder.PONum = mdsoGeneral.GetNextTallyPONo().ToString("00000")
    End If
  End Sub

  Public Sub CreatePurchaseOrderPDF(ByVal vCurrency As eCurrency, ByVal vAccountOption As Int32, ByVal vIsPaymentOrder As Boolean, ByVal vCompanyOption As repPurchaseOrder.eCompanyOption)
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

      mRep = repPurchaseOrder.CreateReport(mPOInfo, mBuyer, False, vCurrency, vCompanyOption)



      mRep.ExportToPdf(mExportFilename)


      If vIsPaymentOrder Then

        Select Case vAccountOption
          Case eSupplirPrintOption.MainAccount
            mPaymentReportPath = CreatePaymetReport(mPOInfo, mBuyer, vCurrency, "", pPurchaseOrder.Supplier.AccountCode, CompanyOption)

          Case eSupplirPrintOption.SecondaryAccount
            mPaymentReportPath = CreatePaymetReport(mPOInfo, mBuyer, vCurrency, "", pPurchaseOrder.Supplier.AccountSecondaryNumber, CompanyOption)

          Case Else
            mPaymentReportPath = CreatePaymetReport(mPOInfo, mBuyer, vCurrency, "", pPurchaseOrder.Supplier.AccountCode, CompanyOption)

        End Select

        If pPurchaseOrder.Status = ePurchaseOrderDueDateStatus.Cancelled Then
          SetTextWatermark("Documento Anulado", mExportFilename, mExportFilename)
          SetTextWatermark("Documento Anulado", mPaymentReportPath, mPaymentReportPath)
        End If

        pPurchaseOrder.FileName = mExportFilename
        ImportPDFs(mExportFilename, mPaymentReportPath)

      End If

      SaveObject()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try
  End Sub


  Public Sub SetTextWatermark(ByVal vWatermarkText As String, ByVal vSourceFileName As String, ByVal vDestFileName As String)
    Using documentProcessor As New PdfDocumentProcessor()
      Dim fontName As String = "Arial Black"
      Dim fontSize As Integer = 60
      Dim stringFormat As PdfStringFormat = PdfStringFormat.GenericTypographic
      stringFormat.Alignment = PdfStringAlignment.Center
      stringFormat.LineAlignment = PdfStringAlignment.Center
      documentProcessor.LoadDocument(vSourceFileName)
      Using brush As New SolidBrush(Color.FromArgb(63, Color.Black))
        Using font As New Font(fontName, fontSize)
          For Each page In documentProcessor.Document.Pages
            Dim watermarkSize = page.CropBox.Width * 0.99
            Using graphics As DevExpress.Pdf.PdfGraphics = documentProcessor.CreateGraphics()
              Dim stringSize As SizeF = graphics.MeasureString(vWatermarkText, font)
              Dim scale As Single = watermarkSize / stringSize.Width
              graphics.TranslateTransform(page.CropBox.Width * 0.5, page.CropBox.Height * 0.5)
              graphics.RotateTransform(-45.0)
              graphics.TranslateTransform(-stringSize.Width * scale * 0.5, -stringSize.Height * scale * 0.5)
              Using actualFont As Font = New Font(fontName, fontSize * scale)
                Dim rect As RectangleF = New RectangleF(0, 0, stringSize.Width * scale, stringSize.Height * scale)
                graphics.DrawString(vWatermarkText, actualFont, brush, rect, stringFormat)
              End Using
              graphics.AddToPageForeground(page, 72, 72)
            End Using
          Next
        End Using
      End Using
      documentProcessor.SaveDocument(vDestFileName)
    End Using
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

  Public Function CreatePaymetReport(ByRef rPOInfo As clsPurchaseOrderInfo, ByRef rBuyer As dmEmployee, ByVal vCurrency As eCurrency, ByVal vProjectName As String, ByVal vAccountCode As String, ByVal vCompanyOption As repPurchaseOrder.eCompanyOption) As String

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

      mRep = repCheckPaymentOrder.CreateReport(rPOInfo, rBuyer, False, vCurrency, vProjectName, vAccountCode, pDBConn, vCompanyOption)

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

  Public Property CurrentDefaultCurrency As eCurrency
    Get
      Return pCurrentDefaultCurrency
    End Get
    Set(value As eCurrency)
      pCurrentDefaultCurrency = value
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



  Public Function GetTotalNetValue() As Decimal
    Dim mRetVal As Decimal = 0

    For Each mPOI As dmPurchaseOrderItem In PurchaseOrder.PurchaseOrderItems
      mRetVal += mPOI.NetAmount
    Next

    Return mRetVal
  End Function

  Public Function LoadSalesOrderPhaseItemInfo(ByRef rSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderPhaseItemInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseItemInfo(pDBConn, dtoSalesOrderPhaseItemInfo.eMode.SalesOrderPhaseItemInfo)
      mdto.LoadSOPICollectionByWhere(rSalesOrderPhaseItemInfos, vWhere)


      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Sub CreateUpdatePOItemAllocation(ByRef rPOItem As dmPurchaseOrderItem, ByVal vWithSaving As Boolean)
    Dim mPOIA As dmPurchaseOrderItemAllocation
    Dim mdso As New dsoSalesOrder(pDBConn)

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

      Select Case pPOOption

        Case ePODetailOption.General
          If rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID = 0 And rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = 0 Then
            rPOItem.PurchaseOrderItemAllocations(0).ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(PurchaseOrder.Category, ePurchaseCategories))
            rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).ItemValueToDisplayValue(PurchaseOrder.AccoutingCategoryID)


          End If
          If pPurchaseOrder.DefaultCurrency = eCurrency.Cordobas Then
            rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("C$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

          Else
            rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

          End If

        Case ePODetailOption.ManPO

          mdso.LoadWorkOrderInfo(pWorkOrderInfo, "WorkOrderID=" & rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID)


          If pWorkOrderInfo IsNot Nothing Then
            rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = pWorkOrderInfo.WorkOrderID
            rPOItem.PurchaseOrderItemAllocations(0).JobNoTmp = String.Format("{0}", pWorkOrderInfo.Description)
            rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = pWorkOrderInfo.WorkOrderID 'pSalesOrderPhaseInfo.SalesOrderPhaseID

            rPOItem.PurchaseOrderItemAllocations(0).ItemRef = pWorkOrderInfo.WorkOrder.WorkOrderNo
            rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = pWorkOrderInfo.WorkOrder.Description
            rPOItem.PurchaseOrderItemAllocations(0).ProjectRef = pWorkOrderInfo.ProjectNameAndCustomer

            If rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID = 0 And rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = 0 Then
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(PurchaseOrder.Category, ePurchaseCategories))
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).ItemValueToDisplayValue(PurchaseOrder.AccoutingCategoryID)


            End If


            If pPurchaseOrder.DefaultCurrency = eCurrency.Cordobas Then
              rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("C$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

            Else
              rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

            End If

          Else
            If rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID = 0 And rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = 0 Then
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(PurchaseOrder.Category, ePurchaseCategories))
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).ItemValueToDisplayValue(PurchaseOrder.AccoutingCategoryID)


            End If

            If pPurchaseOrder.DefaultCurrency = eCurrency.Cordobas Then
              rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("C$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

            Else
              rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

            End If

          End If

        Case ePODetailOption.NonManPO
          Dim mSalesOrderPhaseItemInfos As New colSalesOrderPhaseItemInfos
          mdso.LoadSalesOrderPhaseItemsInfosByWhere(mSalesOrderPhaseItemInfos, "SalesorderPhaseItemID=" & rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID)
          pSalesOrderPhaseItemInfo = Nothing

          If mSalesOrderPhaseItemInfos IsNot Nothing Then
            If mSalesOrderPhaseItemInfos.Count > 0 Then
              pSalesOrderPhaseItemInfo = mSalesOrderPhaseItemInfos(0)
            End If
          End If

          If pSalesOrderPhaseItemInfo IsNot Nothing Then
            rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID = pSalesOrderPhaseItemInfo.SalesOrderPhaseItemID
            rPOItem.PurchaseOrderItemAllocations(0).JobNoTmp = pSalesOrderPhaseItemInfo.ProjectName
            rPOItem.PurchaseOrderItemAllocations(0).ItemRef = pSalesOrderPhaseItemInfo.ItemNumberRef
            rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = pSalesOrderPhaseItemInfo.Description

            If rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID = 0 And rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = 0 Then
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(PurchaseOrder.Category, ePurchaseCategories))
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).ItemValueToDisplayValue(PurchaseOrder.AccoutingCategoryID)


            End If

            rPOItem.PurchaseOrderItemAllocations(0).ProjectRef = pSalesOrderPhaseItemInfo.ProjectName



            If pPurchaseOrder.DefaultCurrency = eCurrency.Cordobas Then
              rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("C$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

            Else
              rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

            End If

          Else
            If rPOItem.PurchaseOrderItemAllocations(0).SalesorderPhaseItemID = 0 And rPOItem.PurchaseOrderItemAllocations(0).WorkOrderID = 0 Then
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(PurchaseOrder.Category, ePurchaseCategories))
              rPOItem.PurchaseOrderItemAllocations(0).ItemRef2 = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).ItemValueToDisplayValue(PurchaseOrder.AccoutingCategoryID)

              If pPurchaseOrder.DefaultCurrency = eCurrency.Cordobas Then
                rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("C$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

              Else
                rPOItem.PurchaseOrderItemAllocations(0).TempTotalValue = String.Format("$ {0}", Math.Round(rPOItem.PurchaseOrderItemAllocations(0).Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

              End If

            End If



          End If
      End Select


      '''//Done for the new wo allocation changes


      If vWithSaving Then
        '// Update the qty ot the neew value
        SaveObject()
      End If

    Else
      ''Just update the value display for the report
      If rPOItem IsNot Nothing Then

        For Each mPOIA In rPOItem.PurchaseOrderItemAllocations

          ''Update itemref
          If mPOIA.WorkOrderID = 0 And mPOIA.SalesorderPhaseItemID = 0 Then
            mPOIA.ItemRef = clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(PurchaseOrder.Category, ePurchaseCategories))
            mPOIA.ItemRef = AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).ItemValueToDisplayValue(PurchaseOrder.AccoutingCategoryID)

          End If

          If PurchaseOrder.DefaultCurrency = eCurrency.Cordobas Then
            mPOIA.TempTotalValue = String.Format("C$ {0}", Math.Round(mPOIA.Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))

          ElseIf PurchaseOrder.DefaultCurrency = eCurrency.Dollar Then
            mPOIA.TempTotalValue = String.Format("$ {0}", Math.Round(mPOIA.Quantity * rPOItem.UnitPrice, 2, MidpointRounding.AwayFromZero))


          End If

        Next

      End If

    End If
  End Sub

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(DBConn)
    Dim mExchangeRate As Decimal = 0

    mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(vDate, vCurrency)

    Return mExchangeRate
  End Function

  Public Sub ReloadPOItems()
    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)
    Dim mOK As Boolean = True


    PurchaseOrder.PurchaseOrderItems.Clear()

    If mOK Then mOK = mdsoPurchaseOrder.ReloadPurchaseOrderItems(pPurchaseOrder.PurchaseOrderItems, pPurchaseOrder.PurchaseOrderID)
  End Sub

  Public Sub UpdatePercentageValue(ByVal vRetentionPercentage As Decimal)

    For Each mPOI As dmPurchaseOrderItem In pPurchaseOrder.PurchaseOrderItems


      mPOI.TempPercentageRetention = vRetentionPercentage

    Next


  End Sub

  Public Function ProcessManualItem() As Boolean
    Dim mRetVal As Boolean

    Dim mdsoTran As dsoStockTransactions
    Dim mDeliveryItem As dmPODeliveryItem
    Dim mReceivedValue As Decimal

    Dim mdsoStock As dsoStock
    Dim mDialogResult As DialogResult
    Dim mExchangeRate As Decimal = 0
    Dim mdsoGeneral As dsoGeneral
    Dim mNewPODeliveryManualItem As dmPODelivery = Nothing
    Dim mSupplierDocRef As String = ""

    Try

      mdsoTran = New dsoStockTransactions(pDBConn)
      mdsoGeneral = New dsoGeneral(pDBConn)
      mdsoStock = New dsoStock(pDBConn)

      mSupplierDocRef = InputBox("Ingrese el número de factura")

      If mSupplierDocRef <> "" Then


        For Each mPOI As dmPurchaseOrderItem In pPurchaseOrder.PurchaseOrderItems
          CreateUpdatePOItemAllocation(mPOI, True)

          For Each mPOIA As dmPurchaseOrderItemAllocation In mPOI.PurchaseOrderItemAllocations

            If mPOI.QtyRequired <> 0 Then

              If (mPOIA.Quantity - mPOIA.ReceivedQty) <= 0 Or mPOIA.ReceivedQty > mPOIA.Quantity Then

                mDialogResult = MessageBox.Show("La cantidad a procesar es mayor a la cantidad pedida, ¿Desea continuar?", "Información de Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                If mDialogResult = DialogResult.No Then
                  mRetVal = False
                  Return mRetVal
                End If
              End If

              If mPOI.StockItemID = 0 Then

                ''//Create PODeliveryItem in the first item
                If mNewPODeliveryManualItem Is Nothing Then

                  CreatePODelivery(mNewPODeliveryManualItem, mPOIA.PurchaseOrderItemAllocationID, mSupplierDocRef)

                  mDeliveryItem = New dmPODeliveryItem
                  mDeliveryItem.PODeliveryID = mNewPODeliveryManualItem.PODeliveryID
                  mDeliveryItem.POItemAllocationID = mPOIA.PurchaseOrderItemAllocationID
                Else
                  mDeliveryItem = New dmPODeliveryItem
                  mDeliveryItem.PODeliveryID = mNewPODeliveryManualItem.PODeliveryID
                  mDeliveryItem.POItemAllocationID = mPOIA.PurchaseOrderItemAllocationID

                End If

                mNewPODeliveryManualItem.PODeliveryItems.Add(mDeliveryItem)

                '// Work out the value of the received qty of the item for Average Stock Value purposes
                mReceivedValue = mPOI.UnitPrice * mPOI.QtyRequired '// Todo include logic for pricing unit

                ''//Check the valuation mode
                If pPurchaseOrder.ValuationMode = eValuationMode.ForAdvanced Then
                  If pPurchaseOrder.ExchangeRateValue = 0 Then
                    mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, eCurrency.Cordobas)
                  Else
                    mExchangeRate = pPurchaseOrder.ExchangeRateValue
                  End If
                  mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOI.StockItemID, 1, mPOI.QtyRequired, mReceivedValue, 1, mDeliveryItem, Now, mPOIA, mPOIA.ItemRef, False, pPurchaseOrder.DefaultCurrency, mPOI.UnitPrice, mExchangeRate)

                ElseIf pPurchaseOrder.ValuationMode = eValuationMode.BookIn Then
                  mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, eCurrency.Cordobas)
                  If mExchangeRate > 0 Then
                    mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOI.StockItemID, 1, mPOI.QtyRequired, mReceivedValue, 1, mDeliveryItem, Now, mPOIA, mPOIA.ItemRef, False, pPurchaseOrder.DefaultCurrency, mPOI.UnitPrice, mExchangeRate)

                  End If

                Else ''//Decide how to do if the business can get credit from their suppliers
                  mRetVal = mdsoTran.UpdateDeliveryStockItemLocationQty(mPOI.StockItemID, 1, mPOI.QtyRequired, mReceivedValue, 1, mDeliveryItem, Now, mPOIA, mPOIA.ItemRef, False, pPurchaseOrder.DefaultCurrency, mPOI.UnitPrice, pPurchaseOrder.ExchangeRateValue)


                End If

              End If
            End If
          Next
        Next

      Else
        MessageBox.Show("Por favor ingrese un número de factura válido")
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Function

  Public Sub CreatePODelivery(ByRef rNewPODeliveryManualItem As dmPODelivery, ByVal vPurchaseOrderItemAllocationID As Integer, ByVal vSupplierDocRef As String)
    Dim mdso As New dsoGeneral(pDBConn)
    Dim mdsoPurchasing As New dsoPurchasing(pDBConn)
    rNewPODeliveryManualItem = New dmPODelivery

    rNewPODeliveryManualItem.PurchaseOrderID = pPurchaseOrder.PurchaseOrderID
    rNewPODeliveryManualItem.ReceivedDate = Now
    rNewPODeliveryManualItem.RefSupplierDoc = vSupplierDocRef
    rNewPODeliveryManualItem.GRNumber = mdso.getNextTally(eTallyIDs.GRNNumber)
    rNewPODeliveryManualItem.Status = ePODelivery.Received

    mdsoPurchasing.SavePODelivery(rNewPODeliveryManualItem)

  End Sub


  Public Sub LoadWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos)

    Dim mdso As New dsoSalesOrder(pDBConn)
    Dim mwhere As String = ""

    mwhere += String.Format("Status not in ({0},{1})", CInt(eWorkOrderStatus.Cancelled), CInt(eWorkOrderStatus.Complete))
    mwhere &= " and Description<>'' and ProductTypeID<>" & eProductType.WoodWorkOrder
    Try

      pDBConn.Connect()
      mdso.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub



  Public Function GetTotalAllocatedQty(ByVal vPurchaseOrderItemID As Integer) As Object
    Dim mRetVal As Decimal
    Dim mPOI As dmPurchaseOrderItem
    Try
      mPOI = PurchaseOrder.PurchaseOrderItems.ItemFromKey(vPurchaseOrderItemID)

      If mPOI IsNot Nothing Then

        mRetVal = mPOI.PurchaseOrderItemAllocations.TotalQuantityAllocated

      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

    Return mRetVal
  End Function
End Class
