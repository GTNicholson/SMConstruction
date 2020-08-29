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

  Private pUsedWorkOrder As List(Of Integer)
  Private pBrowseRefreshTracker As clsBasicBrowseRefreshTracker
  Private pPODelivery As dmPODelivery
  Private pWorkOrders As colWorkOrders
  Private pPOIEditor As clsPOItemEditor
  Private pcolPOIEditor As colPOItemEditors

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
    pWorkOrders = New colWorkOrders
    pUsedWorkOrder = New List(Of Integer)
    pSuppliers = New colSuppliers
    pPOIEditor = New clsPOItemEditor
    pcolPOIEditor = New colPOItemEditors

  End Sub


  Public Property RTISGlobal() As AppRTISGlobal
    Get
      RTISGlobal = pRTISGlobal
    End Get
    Set(ByVal value As AppRTISGlobal)
      pRTISGlobal = value
    End Set
  End Property

  Public Property WorkOrders As colWorkOrders
    Get
      Return pWorkOrders
    End Get
    Set(value As colWorkOrders)
      pWorkOrders = value
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


  Public Property Suppliers As colSuppliers
    Get
      Return pSuppliers
    End Get
    Set(value As colSuppliers)
      pSuppliers = value
    End Set
  End Property


  Public Property UsedWorkOrders As List(Of Integer)
    Get
      Return pUsedWorkOrder
    End Get
    Set(value As List(Of Integer))
      pUsedWorkOrder = value
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
    Dim mWorkOrders As dmWorkOrder
    Try

      mOK = True
      pWorkOrders = New colWorkOrders

      For Each mPOAllocation As dmPurchaseOrderAllocation In pPurchaseOrder.PurchaseOrderAllocations
        If pWorkOrders.IndexFromKey(mPOAllocation.WorkOrderID) = -1 Then
          mWorkOrders = New dmWorkOrder
          mdsoSales.LoadWorkOrder(mWorkOrders, mPOAllocation.WorkOrderID)
          pWorkOrders.Add(mWorkOrders)
        End If

        If pUsedWorkOrder.Contains(mPOAllocation.WorkOrderID) = False Then
          pUsedWorkOrder.Add(mPOAllocation.WorkOrderID)
        End If
      Next


    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function


  Public Sub LoadSuppliers()
    Dim mdtoSupplier As New dtoSupplier(pDBConn)
    Dim mOK As Boolean


    pSuppliers = New colSuppliers

    If pDBConn.Connect Then
      mOK = mdtoSupplier.LoadSupplierCollection(pSuppliers)

    End If

  End Sub


  Public Function LoadObject() As Boolean
    Dim mdsoPurchaseOrder As New dsoPurchasing(DBConn)
    Dim mOK As Boolean
    Try

      mOK = True
      pPurchaseOrder = New dmPurchaseOrder
      pUsedWorkOrder = New List(Of Integer)
      If pPrimaryKeyID > 0 Then

        mOK = mdsoPurchaseOrder.LoadPurchaseOrderDown(Me.PurchaseOrder, Me.PrimaryKeyID)
      Else
        pPurchaseOrder.SubmissionDate = Today

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
      mdso.LoadSuppliers(mRetVal)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Sub GetNextPONo()
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    pPurchaseOrder.PONum = "O.C. " & mdsoGeneral.GetNextTallyPONo().ToString("00000")
  End Sub
End Class
