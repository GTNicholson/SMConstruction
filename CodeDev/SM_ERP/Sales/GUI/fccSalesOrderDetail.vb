Imports RTIS.CommonVB

Public Class fccSalesOrderDetail
  Private pPrimaryKeyID As Integer
  Private pRTISGlobal As AppRTISGlobal

  Private pSalesOrder As dmSalesOrder
  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Private pSalesOrderHandler As clsSalesOrderHandler

  Private pSOWorkOrderInfos As colWorkOrderInfos

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pSOWorkOrderInfos = New colWorkOrderInfos
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


  Public Sub LoadObjects()
    Dim mdso As dsoSales


    If pPrimaryKeyID = 0 Then
      pSalesOrder = New dmSalesOrder
    Else
      pSalesOrder = New dmSalesOrder
      mdso = New dsoSales(pDBConn)
      mdso.LoadSalesOrderDown(pSalesOrder, pPrimaryKeyID)
    End If
    pSalesOrderHandler = New clsSalesOrderHandler(pSalesOrder)
    RefreshSOWorkOrders()
  End Sub

  Public Sub SaveObjects()
    Try
      Dim mdso As dsoSales
      mdso = New dsoSales(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Sub CreateSalesOrderPack(ByRef rReport As repSalesOrder, ByVal vFilePath As String)
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
    Dim mdso As dsoSales
    Try
      mdso = New dsoSales(pDBConn)
      mdso.LoadCustomers(mRetVal)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub AddSalesOrderItem(ByVal vProductType As eProductType)
    Dim mdso As dsoSales
    Dim mSOI As dmSalesOrderItem
    Try
      SaveObjects()
      mSOI = pSalesOrderHandler.AddSalesOrderItem(vProductType)
      mdso = New dsoSales(pDBConn)
      mdso.SaveSalesOrderDown(pSalesOrder)
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
    Dim mdso As dsoSales
    Dim mWO As dmWorkOrder
    Try
      SaveObjects()
      mWO = pSalesOrderHandler.AddWorkOrder(rSOI, vProductType)
      mdso = New dsoSales(pDBConn)
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
    Dim mdso As dsoSales
    Try
      mdso = New dsoSales(pDBConn)
      mdso.LoadCustomerDown(pSalesOrder.Customer, pSalesOrder.CustomerID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub RefreshSOWorkOrders()
    Dim mWOI As clsWorkOrderInfo
    pSOWorkOrderInfos.Clear()
    For Each mSOI As dmSalesOrderItem In pSalesOrder.SalesOrderItems
      For Each mWO As dmWorkOrder In mSOI.WorkOrders
        mWOI = New clsWorkOrderInfo
        mWOI.WorkOrder = mWO
        mWOI.SalesOrder = pSalesOrder
        mWOI.Customer = pSalesOrder.Customer
        pSOWorkOrderInfos.Add(mWOI)
      Next
    Next
  End Sub


  Public Sub RefreshWorkOrderNos(ByRef rSalesOrderItem As dmSalesOrderItem)
    Dim mDSO As dsoSales
    Dim mWONo As String
    mDSO = New dsoSales(pDBConn)
    For Each mWO As dmWorkOrder In rSalesOrderItem.WorkOrders
      mWONo = mDSO.WorkOrderNoFromID(mWO.WorkOrderID)
      mWO.WorkOrderNo = mWONo
    Next
  End Sub


End Class
