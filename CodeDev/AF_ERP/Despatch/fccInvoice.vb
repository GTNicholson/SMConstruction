Imports RTIS.CommonVB

Public Class fccInvoice
  Private pPrimaryKeyID As Integer

  Private pInvoice As dmInvoice
  Private pSalesOrder As dmSalesOrder
  Private pSalesOrderHandler As clsSalesOrderHandler

  Private pDBConn As RTIS.DataLayer.clsDBConnBase

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pSalesOrder = New dmSalesOrder

  End Sub

  Public Property PrimaryKeyID As Integer
    Get
      Return pPrimaryKeyID
    End Get
    Set(value As Integer)
      pPrimaryKeyID = value
    End Set
  End Property

  Public ReadOnly Property Invoice As dmInvoice
    Get
      Return pInvoice
    End Get
  End Property

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
    End Set
  End Property
  Public Sub AddInvoiceSalesOrderItem()
    Dim mdso As dsoSalesOrder
    Dim mSOI As dmInvoiceItem
    Try
      SaveObjects()
      mSOI = pSalesOrderHandler.AddInvoiceSalesOrderItem
      mdso = New dsoSalesOrder(pDBConn)
      mdso.SaveInvoiceDown(pInvoice)
      SaveObjects()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub DeleteInvoiceSalesOrderItem(ByRef rInvoiceSOI As dmInvoiceItem)
    Try
      pSalesOrderHandler.RemoveInvoiceSalesOrderItem(rInvoiceSOI)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub LoadSalesOrders(ByRef rcolSalesOrders As colSalesOrders)

    Dim mdto As dtoSalesOrder
    Dim mwhere As String = ""

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrder(pDBConn)
      mdto.LoadSalesOrderInfo(rcolSalesOrders, "")


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Sub LoadObjects()
    Dim mdso As dsoSalesOrder

    pInvoice = New dmInvoice

    If pPrimaryKeyID <> 0 Then
      mdso = New dsoSalesOrder(pDBConn)
      mdso.LoadInvoiceDown(pInvoice, pPrimaryKeyID)
      mdso.LoadSalesOrderDown(pInvoice.SalesOrder, pInvoice.SalesOrderID)

    End If
    pSalesOrderHandler = New clsSalesOrderHandler(pInvoice)
  End Sub

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property



  Public Sub SaveObjects()
    Dim mdso As dsoSalesOrder
    mdso = New dsoSalesOrder(pDBConn)
    mdso.SaveInvoiceDown(pInvoice)
  End Sub
  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pInvoice.IsAnyDirty
    Return mIsDirty
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub

  Public Sub CreateInvoiceOrderPack(ByRef rReport As repInvoice, ByVal vFilePath As String)
    Dim mExportOptions As DevExpress.XtraPrinting.PdfExportOptions
    Dim mPDFAmalg As New RTIS.PDFUtils.PDFAmal

    mExportOptions = New DevExpress.XtraPrinting.PdfExportOptions
    mExportOptions.ConvertImagesToJpeg = False

    rReport.ExportToPdf(vFilePath, mExportOptions)


  End Sub

End Class
