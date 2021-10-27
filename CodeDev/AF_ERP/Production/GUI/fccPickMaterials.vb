﻿Imports RTIS.CommonVB

Public Class fccPickMaterials

  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pWorkOrder As colWorkOrderInfos
  Private pMaterialRequirementProcessors As colMaterialRequirementProcessors
  Private pFormController As fccPickMaterials
  Private pCurrentWorkOrderInfo As clsWorkOrderInfo
  Private pWhere As String

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase)
    pDBConn = rDBConn
    pMaterialRequirementProcessors = New colMaterialRequirementProcessors
  End Sub

  Public Property WhereSQL() As String
    Get
      WhereSQL = pWhere
    End Get
    Set(value As String)
      pWhere = value
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

  Public Property WorkOrderInfos() As colWorkOrderInfos
    Get
      WorkOrderInfos = pWorkOrder
    End Get
    Set(ByVal value As colWorkOrderInfos)
      pWorkOrder = value
    End Set
  End Property

  Public Property CurrentWorkOrderInfo() As clsWorkOrderInfo
    Get
      CurrentWorkOrderInfo = pCurrentWorkOrderInfo
    End Get
    Set(ByVal value As clsWorkOrderInfo)
      pCurrentWorkOrderInfo = value
    End Set
  End Property

  Public Property MaterialRequirementProcessors() As colMaterialRequirementProcessors
    Get
      MaterialRequirementProcessors = pMaterialRequirementProcessors
    End Get
    Set(ByVal value As colMaterialRequirementProcessors)
      pMaterialRequirementProcessors = value
    End Set
  End Property

  Public Sub LoadWorkOrderInfos(ByRef rcolWorkOrderInfos As colWorkOrderInfos)

    Dim mdto As dtoWorkOrderInfo
    Dim mwhere As String = ""
    mwhere += String.Format("Status in (0,{0},{1},{2})", CInt(eWorkOrderStatus.InProcess), CInt(eWorkOrderStatus.Raised), CInt(eWorkOrderStatus.Complete))
    mwhere &= " and Description<>'' and ProductTypeID<>" & eProductType.WoodWorkOrder
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(DBConn, dtoWorkOrderInfo.eMode.WorkOrderTracking)
      mdto.LoadWorkOrderInfoCollectionByWhere(rcolWorkOrderInfos, mwhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub

  Public Sub GetSITLInfos(ByRef rSITLI As colStockItemTransactionLogInfos)
    Try
      Dim mWhere As String = ""
      Dim mdso As New dsoStockTransactions(pDBConn)

      If pCurrentWorkOrderInfo IsNot Nothing Then
        If pCurrentWorkOrderInfo.WorkOrder IsNot Nothing Then
          mWhere = String.Format("WorkOrderNo = '{0}'", pCurrentWorkOrderInfo.WorkOrder.WorkOrderNo)
          mdso.LoadStockItemTransactionsByWhere(rSITLI, mWhere)
        End If
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub

  Public Sub LoadSalesOrderPhaseInfos(ByRef rSOPInfos As colSalesOrderPhaseInfos)

    Dim mdto As dtoSalesOrderPhaseInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseInfo(DBConn)
      mdto.LoadSOPCollectionByWhere(rSOPInfos, "")


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub

  Public Function LoadWorkOrderInfoDT() As DataTable
    Dim mdso As New dsoSalesOrder(DBConn)
    Dim mDT As DataTable = Nothing
    mdso.LoadWorkOrderDT(mDT, "")
    Return mDT
  End Function

  Public Sub LoadMaterialRequirementProcessorss(ByVal vAreaID As Integer)

    Dim mdto As dtoMaterialRequirementInfo
    Dim mWhere As String = " WorkOrderID =" & pCurrentWorkOrderInfo.WorkOrderID & " and MaterialRequirementType = " & CInt(eMaterialRequirementType.StockItems) & " and  (isnull(Quantity,0)<>0 or IsNull(ReturnQty,0)<>0 or ISNull(PickedQty,0)<>0)"
    pMaterialRequirementProcessors.Clear()
    Try

      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(DBConn, dtoMaterialRequirementInfo.eMode.Processor)

      Select Case vAreaID
        Case 0 '' TODOs
        Case Else
          mWhere = mWhere & " and AreaID = " & vAreaID
      End Select

      mdto.LoadMaterialRequirementProcessorsByWhere(pMaterialRequirementProcessors, mWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Sub ProcessPicks()
    Try
      Dim mdsoTran As dsoStockTransactions
      Dim mExchangeValue As Decimal
      Dim mTranDate As DateTime
      Dim mdsoStock As dsoStock
      Dim mSIL As New dmStockItemLocation
      Dim mRequisaNo As String
      Dim mMatReqProcessorsToRequisa As New colMaterialRequirementProcessors

      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)
      mTranDate = Now
      mRequisaNo = GetRequisaNumber()

      For Each mMRP As clsMaterialRequirementProcessor In pMaterialRequirementProcessors
        If mMRP.ToProcessQty <> 0 Then
          If mMRP.StockItem.StockItemID <> 0 Then
            mSIL = mdsoStock.GetOrCreateStockItemLocation(mMRP.StockItem.StockItemID, 1)
          Else
            mSIL = Nothing
          End If
          mExchangeValue = GetExchangeRate(Now, eCurrency.Cordobas)
          mdsoTran.PickMatReqStockItemLocationQty(mSIL, mMRP.ToProcessQty, mMRP.MaterialRequirement, Now, eCurrency.Cordobas, mMRP.StockItem.AverageCost, mExchangeValue, mRequisaNo)
          mMatReqProcessorsToRequisa.Add(mMRP)
          mMRP.ToProcessQty = 0
        End If

      Next
      PrintRequisaPicking(mMatReqProcessorsToRequisa, mRequisaNo, Now)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub PrintRequisaPicking(ByVal vMatReqProcessorsToRequisa As colMaterialRequirementProcessors, ByVal vRequisaNo As String, ByVal vTranDate As Date)

    Try
      Dim mFileName As String
      Dim mDirectory As String
      Dim mExportFilename As String = ""
      Dim mRep As repRequisaPicking
      Dim mWhere As String = " WorkOrderID =" & pCurrentWorkOrderInfo.WorkOrderID & " and MaterialRequirementType = " & CInt(eMaterialRequirementType.StockItems) & " and  (isnull(Quantity,0)<>0 or IsNull(ReturnQty,0)<>0 or ISNull(PickedQty,0)<>0)"

      Try
        mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.WorkOrderFileFolderSys, clsConstants.OTRequisas, vRequisaNo)
        If System.IO.Directory.Exists(mDirectory) = False Then
          System.IO.Directory.CreateDirectory(mDirectory)
        End If

        mFileName = String.Format("Requisa_{0}_{1}.pdf", vRequisaNo, pCurrentWorkOrderInfo.WorkOrderNo)
        mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)

        pDBConn.Connect()
        mRep = repRequisaPicking.CreateReport(pCurrentWorkOrderInfo, vMatReqProcessorsToRequisa, vRequisaNo, vTranDate)

        mRep.ExportToPdf(mExportFilename)

        If pDBConn.IsConnected Then pDBConn.Disconnect()


      Catch ex As Exception
        If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
      End Try
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw

    End Try

  End Sub

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(DBConn)
    Dim mExchangeRate As Decimal = 0

    mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(vDate, vCurrency)

    Return mExchangeRate
  End Function
  Public Sub CreateAdditionalMatReqs(ByRef rStockItemList As List(Of RTIS.ERPStock.intStockItemDef))
    Dim mMatReqs As New colMaterialRequirements
    Dim mMatReq As dmMaterialRequirement
    Dim mdso As dsoSalesOrder
    Try

      mdso = New dsoSalesOrder(pDBConn)

      For Each mSI As dmStockItem In rStockItemList
        mMatReq = New dmMaterialRequirement
        mMatReq.ObjectType = eObjectType.WorkOrder
        mMatReq.ObjectID = pCurrentWorkOrderInfo.WorkOrderID
        mMatReq.StockItemID = mSI.StockItemID
        mMatReq.MaterialRequirementType = eMaterialRequirementType.StockItems
        mMatReqs.Add(mMatReq)
      Next

      mdso.SaveMaterialRequirementsCollection(mMatReqs, eObjectType.WorkOrder, pCurrentWorkOrderInfo.WorkOrderID, eMaterialRequirementType.StockItems)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub CreateRequisaPicking(ByVal vRequisaNo As String)
    Dim mSILIS As New colStockItemTransactionLogInfos
    Dim mWhere As String
    Dim mdso As New dsoStockTransactions(pDBConn)
    Dim mMRs As New colMaterialRequirementProcessors
    Dim mdsoMR As New dsoSalesOrder(pDBConn)
    Dim mDate As Date
    Try
      mWhere = String.Format("ReferenceNo = '{0}'", vRequisaNo)
      mdso.LoadStockItemTransactionsByWhere(mSILIS, mWhere)


      mWhere = ""
      For Each mSILI In mSILIS
        mDate = mSILI.TransDate
        If mWhere <> "" Then mWhere = mWhere & ","

        mWhere = mWhere & mSILI.RefObjectID
      Next

      mWhere = String.Format("MaterialRequirementID in ({0})", mWhere)

      mdsoMR.LoadPhaseMatReqProcessors(mMRs, mWhere)

      PrintRequisaPicking(mMRs, vRequisaNo, mDate)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub ProcessReturnProduction()
    Try
      Dim mdsoTran As dsoStockTransactions
      Dim mMatReq As dtoMaterialRequirement
      Dim mExchangeValue As Decimal

      Dim mdsoStock As dsoStock
      Dim mSIL As New dmStockItemLocation

      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)

      For Each mMRP As clsMaterialRequirementProcessor In pMaterialRequirementProcessors
        If mMRP.ToProcessQty <> 0 Then
          If mMRP.StockItem.StockItemID <> 0 Then
            mSIL = mdsoStock.GetOrCreateStockItemLocation(mMRP.StockItem.StockItemID, 1)
          Else
            mSIL = Nothing
          End If
          mExchangeValue = GetExchangeRate(Now, eCurrency.Cordobas)
          mdsoTran.ReturnFromProductionMatReqStockItemLocationQty(mSIL, mMRP.ToProcessQty, mMRP.MaterialRequirement, Now, eCurrency.Cordobas, mMRP.StockItem.AverageCost, mExchangeValue)
          mMRP.ToProcessQty = 0
        End If

      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Function CreateRequisaSummary() As String
    Dim mFileName As String
    Dim mDirectory As String
    Dim mExportFilename As String = ""
    Dim mRep As repRequisaWorkOrderSummary
    Dim mAllMaterialRequirements As New colMaterialRequirementProcessors
    Dim mdto As dtoMaterialRequirementInfo
    Dim mWhere As String = " WorkOrderID =" & pCurrentWorkOrderInfo.WorkOrderID & " and MaterialRequirementType = " & CInt(eMaterialRequirementType.StockItems) & " and  (isnull(Quantity,0)<>0 or IsNull(ReturnQty,0)<>0 or ISNull(PickedQty,0)<>0)"

    Try
      mDirectory = System.IO.Path.Combine(AppRTISGlobal.GetInstance.DefaultExportPath, clsConstants.WorkOrderFileFolderSys)
      If System.IO.Directory.Exists(mDirectory) = False Then
        System.IO.Directory.CreateDirectory(mDirectory)
      End If

      mFileName = String.Format("RequisaSummary_{0}.pdf", pCurrentWorkOrderInfo.WorkOrderNo)
      mExportFilename = System.IO.Path.Combine(mDirectory, mFileName)

      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(DBConn, dtoMaterialRequirementInfo.eMode.Processor)

      mdto.LoadMaterialRequirementProcessorsByWhere(mAllMaterialRequirements, mWhere)
      mRep = repRequisaWorkOrderSummary.CreateRequisaSummaryReport(pCurrentWorkOrderInfo, mAllMaterialRequirements)

      mRep.ExportToPdf(mExportFilename)

      If pDBConn.IsConnected Then pDBConn.Disconnect()


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyUserInterface) Then Throw
    End Try

    Return mExportFilename

  End Function

  Private Function GetRequisaNumber() As String
    Dim mdso As New dsoGeneral(pDBConn)
    Dim mRetVal As String = ""

    If pCurrentWorkOrderInfo IsNot Nothing Then

      If pCurrentWorkOrderInfo.WorkOrder.WorkOrderID > 0 Then
        mRetVal = "R-" & mdso.getNextTally(eTallyIDs.RequisaNumber).ToString("D5")

        '  If Not pDBConn.IsConnected Then pDBConn.Connect()

        '  pDBConn.ExecuteNonQuery(String.Format("Update WorkOrder set RequisaNumber = {0} where WorkOrderID = {1}", mRetVal, pCurrentWorkOrderInfo.WorkOrderID))

        '  If pDBConn.IsConnected Then pDBConn.Disconnect()
      End If
    End If

    Return mRetVal

  End Function
End Class
