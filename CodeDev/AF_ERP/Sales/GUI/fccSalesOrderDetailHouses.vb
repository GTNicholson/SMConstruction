﻿Imports RTIS.CommonVB

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
  Private pCurrentSalesItemAssembly As dmSalesItemAssembly
  Private pSalesItemEditors As colSalesItemEditors
  Private pProducts As colProductBases

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pSOWorkOrderInfos = New colWorkOrderInfos
    pRTISGlobal = rRTISGlobal
    pSOActionHandler = New clsSalesOrderActionsHandler(rDBConn.RTISUser, rDBConn)
    pInvoices = New colInvoices
    pCustomerPurchaseOrders = New colCustomerPurchaseOrders
    pCurrentSalesItemAssembly = New dmSalesItemAssembly
    pSalesItemEditors = New colSalesItemEditors
    pProducts = New colProductBases
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

  Public ReadOnly Property Invoices As colInvoices
    Get
      Return pSalesOrder.Invoices
    End Get
  End Property

  Public ReadOnly Property CustomerPurchaseOrders As colCustomerPurchaseOrders
    Get
      Return pSalesOrder.CustomerPurchaseOrder
    End Get
  End Property

  Public ReadOnly Property Products As colProductBases
    Get
      Return pProducts
    End Get
  End Property

  Public Sub LoadObjects()
    Dim mdso As dsoSales
    Dim mSalesOrderItemAssembly As dmSalesItemAssembly

    If pPrimaryKeyID = 0 Then
      pSalesOrder = clsSalesOrderHandler.CreateNewSalesOrder

      mSalesOrderItemAssembly = New dmSalesItemAssembly
      mSalesOrderItemAssembly.ParentID = pSalesOrder.SalesOrderID
      SalesOrder.SalesItemAssemblys.Add(mSalesOrderItemAssembly)

      SaveObjects()

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

  Public Function GetInvoicesList() As colInvoices
    Dim mRetVal As New colInvoices
    Dim mdso As dsoSales
    Try
      mdso = New dsoSales(pDBConn)
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



  Public Sub RefreshWorkOrderNos(ByRef rSalesOrderItem As dmSalesOrderItem)
    Dim mDSO As dsoSales
    Dim mWONo As String
    mDSO = New dsoSales(pDBConn)
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

  Public Function RemoveSalesOrderItemAssembly(ByVal vSalesItemAssembly As dmSalesItemAssembly) As Boolean
    Dim mOK As Boolean
    Try
      If vSalesItemAssembly IsNot Nothing AndAlso SalesOrder.SalesItemAssemblys IsNot Nothing Then
        mOK = SalesOrder.SalesItemAssemblys.Remove(vSalesItemAssembly)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function

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

  Public Sub AddNewSalesItemAssembly()
    Try

      If pCurrentSalesItemAssembly IsNot Nothing Then
        Dim mNewSIA As New dmSalesItemAssembly
        Dim mdso As New dsoSales(pDBConn)


        mNewSIA.ParentID = pSalesOrder.SalesOrderID

        pSalesOrder.SalesItemAssemblys.Add(mNewSIA)

        mdso.SaveSalesOrderDown(pSalesOrder)

        mdso = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Sub SetCurrentSalemItemAssembly(ByRef rSalesItemAssembly As dmSalesItemAssembly)
    pCurrentSalesItemAssembly = rSalesItemAssembly

    '// this is where you need to refresh the CurrentSalesItemAssemblySalesitemEditors
    RefreshCurrentSalesItemEditors()

  End Sub

  Public Sub RefreshCurrentSalesItemEditors()
    Dim mSIAE As clsSalesItemEditor
    pSalesItemEditors.Clear()

    If pCurrentSalesItemAssembly IsNot Nothing Then
      For Each mSalesItem As dmSalesOrderItem In pSalesOrder.SalesOrderItems
        If mSalesItem.SalesItemAssemblyID = pCurrentSalesItemAssembly.SalesItemAssemblyID Then

          '// create a new editor based on this salesitem and add to collection
          mSIAE = New clsSalesItemEditor(pSalesOrder, pCurrentSalesItemAssembly, mSalesItem)
          pSalesItemEditors.Add(mSIAE)

          mSalesItem.Description = mSIAE.Description
        End If
      Next
    End If



  End Sub

  Public Function GetProductInfos() As colProductBaseInfos
    Dim mRetVal As New colProductBaseInfos
    Dim mdso As New dsoProductAdmin(DBConn)
    mdso.LoadProductInfosByWhere(mRetVal, "")
    Return mRetVal
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
End Class
