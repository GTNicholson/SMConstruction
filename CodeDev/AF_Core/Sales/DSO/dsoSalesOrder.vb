Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoSalesOrder : Inherits dsoBase
  ''  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    MyBase.New(rDBConn)
  End Sub

  Public Function LoadSalesOrderPhaseItemDT(ByRef rDT As DataTable, ByVal vWhereStr As String) As Boolean
    Dim mSQL As String
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mSQL = " select * from vwSalesOrderPhaseItemInfo where "

      If vWhereStr.Length > 0 Then
        mSQL = mSQL & vWhereStr
      End If

      rDT = pDBConn.CreateDataTable(mSQL)
      mOK = True
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LoadSalesOrderPhaseMilestoneStatuss_By_Phase(ByRef rSalesOrderPhaseMilestoneStatuss As colSalesOrderPhaseMilestoneStatuss, ByVal vSalesOrderPhaseID As Int32) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderPhaseMilestoneStatus
    Try
      mdto = New dtoSalesOrderPhaseMilestoneStatus(pDBConn)
      pDBConn.Connect()
      mdto.LoadSalesOrderPhaseMilestoneStatusCollection(rSalesOrderPhaseMilestoneStatuss, vSalesOrderPhaseID)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function



  Public Sub LoadSalesOrderPhaseInfoWithMilestones(ByRef rSalesOrderPhases As colSalesOrderPhaseInfos, ByVal vWhere As String, ByVal Optional vWhere3 As String = "")
    Dim mdtoSalesOrderPhaseInfo As New dtoSalesOrderPhaseInfo(pDBConn)
    Dim mdtoSalesOrderPhaseMilestoneStatus As New dtoSalesOrderPhaseMilestoneStatus(pDBConn)
    Dim mSOPMRCSs As New colSalesOrderPhaseMilestoneStatuss
    Dim mWhere2 As String
    Dim mSOPI As clsSalesOrderPhaseInfo
    Dim mWhereContractManagerID As String
    Try

      If pDBConn.Connect Then
        If vWhere3 <> "" Then
          mWhereContractManagerID = String.Concat(vWhere, vWhere3)

          mdtoSalesOrderPhaseInfo.LoadSOPCollectionByWhere(rSalesOrderPhases, mWhereContractManagerID)

        Else
          mdtoSalesOrderPhaseInfo.LoadSOPCollectionByWhere(rSalesOrderPhases, vWhere)

        End If
        If vWhere <> "" Then
          mWhere2 = "SalesOrderPhaseID in (Select SalesOrderPhaseID from vwSalesOrderPhaseInfo where " & vWhere & ")"
        Else
          mWhere2 = ""
        End If

        mdtoSalesOrderPhaseMilestoneStatus.LoadSalesOrderPhaseMilestoneStatusCollectionByWhere(mSOPMRCSs, mWhere2)

        For Each mSOPMRCS As dmSalesOrderPhaseMilestoneStatus In mSOPMRCSs
          mSOPI = rSalesOrderPhases.ItemBySalesOrderPhaseID(mSOPMRCS.SalesOrderPhaseID)
          If mSOPI IsNot Nothing Then
            mSOPI.SalesOrderPhaseMilestoneStatuss.Add(mSOPMRCS)
          End If
        Next


      End If

      mdtoSalesOrderPhaseInfo = Nothing
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadSalesOrderPhaseInfoMilestones(ByRef rSalesOrderPhaseInfo As clsSalesOrderPhaseInfo)
    Dim mdtoSalesOrderPhaseMilestoneStatus As New dtoSalesOrderPhaseMilestoneStatus(pDBConn)
    Dim mSOPMRCSs As New colSalesOrderPhaseMilestoneStatuss

    Try

      If pDBConn.Connect Then
        mdtoSalesOrderPhaseMilestoneStatus.LoadSalesOrderPhaseMilestoneStatusCollectionByWhere(rSalesOrderPhaseInfo.SalesOrderPhaseMilestoneStatuss, "SalesOrderPhaseID = " & rSalesOrderPhaseInfo.SalesOrderPhaseID)

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadSalesOrdersCollectionByWhere(ByRef rSalesOrders As colSalesOrders, ByVal vWhere As String)
    Dim mdtoSalesOrder As New dtoSalesOrder(pDBConn)

    Try
      If pDBConn.Connect Then

        mdtoSalesOrder.LoadSalesOrderCollectionByWhere(rSalesOrders, vWhere)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()

    End Try
  End Sub

  Public Function UpdateOrderReceivedDate(ByVal vSalesOrderPhaseID As Integer, ByVal vOrderReceivedDate As Date) As Boolean
    Dim mOK As Boolean
    Dim mParams As New Hashtable
    Try
      pDBConn.Connect()
      mParams.Add("@OrderReceivedDate", vOrderReceivedDate)
      mParams.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)

      mOK = pDBConn.ExecuteCommand("UPDATE SalesOrderPhase SET OrderReceivedDate = @OrderReceivedDate WHERE SalesOrderPhaseID =  @SalesOrderPhaseID", mParams)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK

  End Function

  Public Function LoadSalesOrderDT(ByRef rDT As DataTable, ByVal vWhereStr As String) As Boolean
    Dim mSQL As String
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mSQL = " select * from vwSalesOrderPhaseInfo where "

      If vWhereStr.Length > 0 Then
        mSQL = mSQL & vWhereStr
      End If

      rDT = pDBConn.CreateDataTable(mSQL)
      mOK = True
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LoadWorkOrderDT(ByRef rDT As DataTable, Optional ByVal vWhereStr As String = "") As Boolean
    Dim mSQL As String
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mSQL = " select * from vwWorkOrderTracking"
      mSQL &= " where WorkOrderID Not In (select Distinct WorkOrderID from WorkOrderMilestoneStatus Where MilestoneENUM = 10 and Status = 3)"
      mSQL &= " and (WorkOrderID in (select WorkOrderID from vwWorkOrderInfo) or WorkOrderId in (select WorkOrderID from vwWorkOrderInternalInfo))"


      If vWhereStr.Length > 0 Then
        mSQL = mSQL & vWhereStr
      End If

      rDT = pDBConn.CreateDataTable(mSQL)
      mOK = True
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function SaveSalesOrderPhaseMilestoneStatusCollection(ByRef rSalesOrderPhaseMilestoneStatuss As colSalesOrderPhaseMilestoneStatuss, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderPhaseMilestoneStatus
    Try
      mdto = New dtoSalesOrderPhaseMilestoneStatus(pDBConn)
      pDBConn.Connect()
      mdto.SaveSalesOrderPhaseMilestoneStatusCollection(rSalesOrderPhaseMilestoneStatuss, vSalesOrderPhaseID)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetSalesOrderIDFromSalesOrderPhaseID(ByVal vSalesOrderPhaseID) As Integer
    Dim mRetVal As Integer = -1
    Dim mSQL As String
    Try
      pDBConn.Connect()
      mSQL = "Select SalesOrderID from SalesOrderPhase where SalesOrderPhaseID = " & vSalesOrderPhaseID
      mRetVal = pDBConn.ExecuteScalar(mSQL)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function SaveSalesOrderPhaseMilestoneStatus(ByRef rSalesOrderPhaseMilestoneStatus As dmSalesOrderPhaseMilestoneStatus) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderPhaseMilestoneStatus
    Try
      mdto = New dtoSalesOrderPhaseMilestoneStatus(pDBConn)
      pDBConn.Connect()
      mdto.SaveSalesOrderPhaseMilestoneStatus(rSalesOrderPhaseMilestoneStatus)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function UpdateDateRequiredSOPSQL(ByVal vDateRequired As Date, ByVal vSOPID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mSQL As String

    Try
      pDBConn.Connect()
      mSQL = String.Format("Update SalesOrderPhase set DateRequired = '{0}' where SalesOrderPhaseID = {1}", Format(vDateRequired.Date, "yyyyMMdd"), vSOPID)
      mRetVal = pDBConn.ExecuteNonQuery(mSQL)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadPhaseMatReqProcessors(ByVal vMatReqInfos As colMaterialRequirementProcessors, ByVal vWhere As String) As Boolean
    Dim mOK As Boolean


    Try
      If pDBConn.Connect() Then
        Dim mdto As New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.Processor)

        Dim mWhere As String = String.Empty

        mOK = mdto.LoadMaterialRequirementProcessorsByWhere(vMatReqInfos, vWhere)


      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadWorkOrderAllocationsByWhere(ByRef rWOAs As colWorkOrderAllocations, ByVal vWhere As String) As Boolean
    Dim mOK As Boolean
    Dim mdto As dtoWorkOrderAllocation
    Try
      If pDBConn.Connect Then
        mdto = New dtoWorkOrderAllocation(pDBConn)
        mdto.LoadWorkOrderAllocationCollectionByWhere(rWOAs, vWhere)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK

  End Function

  Public Function LockCustomerDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.LockTableRecord(appLockEntitys.cCustomer, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Function LoadWorkOrderMatReqInfosByWhere(ByRef rMatReqInfos As colMaterialRequirementInfos, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean = True
    Dim mdto As dtoMaterialRequirementInfo
    Try
      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.Info)
      mdto.LoadWorkOrderPhaseMatReqInfosByWhere(rMatReqInfos, vWhere)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function


  Public Function GetDefaultCostBook() As Integer
    Dim mRetval As Integer
    Dim mWhere As String = "Select CostBookID from CostBook where IsDefault = 1"
    Try
      If pDBConn.Connect Then
        mRetval = Convert.ToInt32(pDBConn.ExecuteScalar(mWhere))

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetval
  End Function

  Public Function LockCostBook(ByVal vCostBookID As Integer) As Boolean
    Dim mRetVal As Boolean
    Try
      If pDBConn.Connect() Then
        mRetVal = MyBase.LockTableRecord("CostBook", vCostBookID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function UpdateMaterialRequirementFromStockQty(ByRef rMaterRequirement As dmMaterialRequirement) As Boolean
    Dim mSQL As String
    Dim mRetVal As Integer
    Try
      If pDBConn.Connect() Then
        mSQL = "UPDATE dbo.MaterialRequirement"
        mSQL &= " SET FromStockQty = " & rMaterRequirement.FromStockQty
        mSQL &= " WHERE MaterialRequirementID = " & rMaterRequirement.MaterialRequirementID
        mRetVal = pDBConn.ExecuteNonQuery(mSQL)
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadWorkOrderInfo(ByRef rWorkOrderInfo As clsWorkOrderInfo, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean = True
    Dim mdto As dtoWorkOrderInfo
    Dim mWorkOrderInfos As New colWorkOrderInfos
    Try
      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, dtoWorkOrderInfo.eMode.WorkOrderInfoInternal)
      mRetVal = mdto.LoadWorkOrderInfoCollectionByWhere(mWorkOrderInfos, vWhere)

      If mWorkOrderInfos.Count > 0 Then
        rWorkOrderInfo = mWorkOrderInfos(0)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing
    End Try
    Return mRetVal
  End Function

  Public Function LoadSalesOrderPhaseItem(ByRef SalesOrderPhaseItem As dmSalesOrderPhaseItem, ByVal vSalesorderPhaseItemID As Integer) As Boolean
    Dim mRetVal As Boolean = True
    Dim mdto As dtoSalesOrderPhaseItem


    Try
      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseItem(pDBConn)
      mRetVal = mdto.LoadSalesOrderPhaseItem(SalesOrderPhaseItem, vSalesorderPhaseItemID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing

    End Try
    Return mRetVal

  End Function

  Public Function UnlockCustomerDisconnected(ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.UnlockTableRecord(appLockEntitys.cCustomer, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function


  Public Function LoadCustomerDown(ByRef rCustomer As dmCustomer, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer
    Dim mdtoCC As dtoCustomerContact

    Try

      pDBConn.Connect()
      mdto = New dtoCustomer(pDBConn)
      mdto.LoadCustomer(rCustomer, vID)
      mdtoCC = New dtoCustomerContact(pDBConn)
      mdtoCC.LoadCustomerContactCollection(rCustomer.CustomerContacts, rCustomer.CustomerID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Sub LoadCostBook(pCostBook As dmCostBook, pCostBookID As Integer)
    Throw New NotImplementedException()
  End Sub

  Public Function LockFromTableRecord(ByVal vTableName As String, ByVal vPrimaryKeyID As Integer) As Boolean
    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.LockTableRecord(vTableName, vPrimaryKeyID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

  Public Sub LoadProductCostBook(ByRef rProductCostBook As dmProductCostBook, ByVal vProductCostBookID As Integer)
    Dim mdtoProductCostBook As New dtoProductCostBook(pDBConn)
    Try
      If pDBConn.Connect() Then
        mdtoProductCostBook.LoadProductCostBook(rProductCostBook, vProductCostBookID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Sub LoadProductCostBookEntry(ByRef rProductCostBookEntrys As colProductCostBookEntrys, ByVal vProductCostBookID As Integer)
    Dim mdtoProductCostBookEntry As dtoProductCostBookEntry = New dtoProductCostBookEntry(pDBConn)
    Try
      If pDBConn.Connect() Then
        mdtoProductCostBookEntry.LoadProductCostBookEntryCollection(rProductCostBookEntrys, vProductCostBookID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function SaveProductCostBookEntryCollection(ByRef rProductCostBookEntrys As colProductCostBookEntrys, ByVal vProductCostBookID As Integer) As Boolean
    Dim mdto As New dtoProductCostBookEntry(pDBConn)
    Dim mOK As Boolean
    Try
      If pDBConn.Connect() Then
        mOK = mdto.SaveProductCostBookEntryCollection(rProductCostBookEntrys, vProductCostBookID)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function UnlockCostBook(ByVal vCostBookID As Integer) As Boolean
    Return MyBase.UnlockTableRecord("CostBook", vCostBookID)
  End Function

  Public Function SaveProductCostBook(ByRef rProductCostBook As dmProductCostBook) As Boolean
    Dim mdtoProductCostBook As New dtoProductCostBook(pDBConn)
    Dim mOK As Boolean = False
    Try
      If pDBConn.Connect() Then

        mOK = mdtoProductCostBook.SaveProductCostBook(rProductCostBook)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadPaymentAccount(ByRef rPaymentAccount As dmPaymentOnAccount, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoPaymentOnAccount

    Try

      pDBConn.Connect()
      mdto = New dtoPaymentOnAccount(pDBConn)
      mdto.LoadPaymentOnAccount(rPaymentAccount, vID)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Function LoadInvoiceDown(ByRef rInvoice As dmInvoice, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoice
    Dim mdtoInvoiceItem As dtoInvoiceItem

    Try

      pDBConn.Connect()
      mdto = New dtoInvoice(pDBConn)
      mdto.LoadInvoice(rInvoice, vID)
      mdtoInvoiceItem = New dtoInvoiceItem(pDBConn)
      mdtoInvoiceItem.LoadInvoiceItemCollection(rInvoice.InvoiceItems, rInvoice.InvoiceID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function UnlockProductCostBook(ByVal vTableName As String, ByVal vCostBookID As Integer) As Boolean

    Dim mOK As Boolean
    Try
      pDBConn.Connect()
      mOK = MyBase.UnlockTableRecord(vTableName, vCostBookID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK


  End Function

  Public Function LoadSalesOrderProgressInfos(ByRef rSalesOrderProgressInfos As colSalesOrderProgressInfos, ByVal vWhere As String) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrderProgressInfo

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderProgressInfo(pDBConn)
      mdto.LoadSalesOrderProgressCollection(rSalesOrderProgressInfos, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function



  Public Function LoadCustomers(ByRef rCustomers As colCustomers) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer

    Try

      pDBConn.Connect()
      mdto = New dtoCustomer(pDBConn)
      mdto.LoadCustomerCollection(rCustomers)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadInvoices(ByRef rInvoices As colInvoices, ByVal vParentId As Int32) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoice

    Try

      pDBConn.Connect()
      mdto = New dtoInvoice(pDBConn)
      mdto.LoadInvoiceCollection(rInvoices, vParentId)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Sub SetDefaultProductCostBook(ByVal vProductCostBookID As Integer)
    Dim mWhere As String = "Update ProductCostBook set IsDefault = " & vbFalse & " where ProductCostBookID <> " & vProductCostBookID
    ''call a dso to set true to the actual costbookid
    Try
      If pDBConn.Connect Then
        pDBConn.ExecuteNonQuery(mWhere)

        mWhere = "Update ProductCostBook set IsDefault = " & vbTrue & " where ProductCostBookID = " & vProductCostBookID
        pDBConn.ExecuteNonQuery(mWhere)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function LoadInvoiceInfos(ByRef rInvoiceInfos As colInvoiceInfos) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoiceInfo

    Try

      pDBConn.Connect()
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Invoice)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, "")

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Sub SetDefaultCostBook(ByVal vCostBookID As Integer)
    Dim mWhere As String = "Update CostBook set IsDefault = " & vbFalse & " where CostBookID <> " & vCostBookID
    ''call a dso to set true to the actual costbookid
    Try
      If pDBConn.Connect Then
        pDBConn.ExecuteNonQuery(mWhere)

        mWhere = "Update CostBook set IsDefault = " & vbTrue & " where CostBookID = " & vCostBookID
        pDBConn.ExecuteNonQuery(mWhere)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub
  Public Function LoadInvoiceInfosGraph(ByRef rInvoiceInfos As colInvoiceInfos) As Boolean
    Dim mdto As dtoInvoiceInfo
    Dim mSQLWhere1 As String
    Dim mSQLWhere2 As String
    Dim mSQLWhere As String = ""
    Dim mMonth As Integer = 0
    Dim mYear As Int32 = 0
    Dim mStartDate As Date
    Dim mEndDate As Date

    mMonth = Now.Month

    If mMonth < 6 Then
      mYear = Now.Year - 1
      mMonth = mMonth + 7 ''the last 6 months

      mStartDate = New Date(mYear, mMonth, 1)


    Else
      mYear = Now.Year
      mMonth = Now.Month - 5

      mStartDate = New Date(mYear, mMonth, 1)

    End If

    mEndDate = New Date(Now.Year, Now.Month, Now.Day)


    Try



      pDBConn.Connect()
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Invoice)

      mSQLWhere1 = "InvoiceDate >= '" & mStartDate.ToString("yyyyMMdd") & "'"
      mSQLWhere2 = "InvoiceDate <= '" & mEndDate.ToString("yyyyMMdd") & "'"

      mSQLWhere = mSQLWhere1
      If mSQLWhere <> "" And mSQLWhere2 <> "" Then mSQLWhere = mSQLWhere & " And "
      mSQLWhere = mSQLWhere & mSQLWhere2

      If mSQLWhere <> "" Then mSQLWhere = "(" & mSQLWhere & ") And "
      mSQLWhere = mSQLWhere & "InvoiceDate Is Not Null"


      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)

      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Packed)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Engineered)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)
      mdto = New dtoInvoiceInfo(pDBConn, clsInvoiceInfo.eInvoicePredictedType.Pending)
      mdto.LoadInvoiceCollectionByWhere(rInvoiceInfos, mSQLWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Function

  Public Function GetSalesOrderIDBySalesOrderPhaseItemID(ByVal vSalesOrderPhaseItemID As Integer) As Integer
    Dim mRetVal As Integer
    Dim mSQL As String = ""
    Try
      If pDBConn.Connect Then

        mSQL = "select distinct SalesOrderID from SalesOrderPhaseItem where SalesOrderPhaseItemID=" & vSalesOrderPhaseItemID

        mRetVal = pDBConn.ExecuteScalar(mSQL)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SaveCustomerDown(ByRef rCustomer As dmCustomer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoCustomer
    Dim mdtoCC As dtoCustomerContact

    Try

      pDBConn.Connect()
      mdto = New dtoCustomer(pDBConn)
      mdto.SaveCustomer(rCustomer)
      mdtoCC = New dtoCustomerContact(pDBConn)
      mdtoCC.SaveCustomerContactCollection(rCustomer.CustomerContacts, rCustomer.CustomerID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SavePaymentAccount(ByRef rPaymentAccount As dmPaymentOnAccount) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoPaymentOnAccount

    Try

      pDBConn.Connect()
      mdto = New dtoPaymentOnAccount(pDBConn)
      mdto.SavePaymentOnAccount(rPaymentAccount)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Function SaveInvoiceDown(ByRef rInvoice As dmInvoice) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoInvoice
    Dim mdtoInvoiceItem As dtoInvoiceItem

    Try

      pDBConn.Connect()
      mdto = New dtoInvoice(pDBConn)
      mdto.SaveInvoice(rInvoice)
      mdtoInvoiceItem = New dtoInvoiceItem(pDBConn)
      mdtoInvoiceItem.SaveInvoiceItemCollection(rInvoice.InvoiceItems, rInvoice.InvoiceID)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Function SaveSalesOrderDown(ByRef rSalesOrder As dmSalesOrder) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder
    Dim mdtoSOI As dtoSalesOrderItem
    Dim mdtoWO As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoInvoices As dtoInvoice
    Dim mdtoCustomerPurchaseOrder As dtoCustomerPurchaseOrder
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoSalesOrderPhase As dtoSalesOrderPhase
    Dim mdtoSalesOrderPhaseItem As dtoSalesOrderPhaseItem
    Dim mdtoPhaseItemComponent As dtoPhaseItemComponent
    Dim mdtoSalesOrderHouse As dtoSalesOrderHouse
    Dim mdtodtoSalesItemAssembly As dtoSalesItemAssembly
    Dim mdtoSalesOrderStage As dtoSalesOrderStage
    Dim mdtoPaymentAccount As dtoPaymentOnAccount
    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrder(pDBConn)
      mdto.SaveSalesOrder(rSalesOrder)

      mdtoSOI = New dtoSalesOrderItem(pDBConn)
      mdtoSOI.SaveSalesOrderItemCollection(rSalesOrder.SalesOrderItems, rSalesOrder.SalesOrderID)

      mdtoInvoices = New dtoInvoice(pDBConn)
      mdtoInvoices.SaveInvoiceCollection(rSalesOrder.Invoices, rSalesOrder.SalesOrderID)

      mdtoPaymentAccount = New dtoPaymentOnAccount(pDBConn)
      mdtoPaymentAccount.SavePaymentOnAccountCollection(rSalesOrder.PaymentAccounts, rSalesOrder.SalesOrderID)

      mdtoSalesOrderStage = New dtoSalesOrderStage(pDBConn)
      mdtoSalesOrderStage.SaveSalesOrderStageCollection(rSalesOrder.SalesOrderStages, rSalesOrder.SalesOrderID)

      mdtoCustomerPurchaseOrder = New dtoCustomerPurchaseOrder(pDBConn)
      mdtoCustomerPurchaseOrder.SaveCustomerPurchaseOrderCollection(rSalesOrder.CustomerPurchaseOrder, rSalesOrder.SalesOrderID)

      mdtoSalesOrderPhase = New dtoSalesOrderPhase(pDBConn)
      mdtoSalesOrderPhase.SaveSalesOrderPhaseCollection(rSalesOrder.SalesOrderPhases, rSalesOrder.SalesOrderID)

      If rSalesOrder.SalesOrderPhases IsNot Nothing Then
        mdtoSalesOrderPhaseItem = New dtoSalesOrderPhaseItem(pDBConn)
        mdtoPhaseItemComponent = New dtoPhaseItemComponent(pDBConn)
        For Each mSOP As dmSalesOrderPhase In rSalesOrder.SalesOrderPhases

          mdtoSalesOrderPhaseItem.SaveSalesOrderPhaseItemCollection(mSOP.SalesOrderPhaseItems, mSOP.SalesOrderPhaseID)


          mdtoPhaseItemComponent.SavePhaseItemComponentCollection(mSOP.PhaseItemComponents, mSOP.SalesOrderPhaseID)
        Next

      End If

      mdtoSalesOrderHouse = New dtoSalesOrderHouse(pDBConn)
      mdtoSalesOrderHouse.SaveSalesOrderHouseCollection(rSalesOrder.SalesOrderHouses, rSalesOrder.SalesOrderID)

      ''Save the documents for each salesorderhouses

      For Each mSOH As dmSalesOrderHouse In rSalesOrder.SalesOrderHouses

        mdtoOutputDocs = New dtoOutputDocument(pDBConn)
        mdtoOutputDocs.SaveOutputDocumentCollection(mSOH.OutputDocuments, mSOH.SalesOrderHouseID)

      Next


      mdtodtoSalesItemAssembly = New dtoSalesItemAssembly(pDBConn, dtoSalesItemAssembly.eMode.SalesOrderItemAssembly)
      mdtodtoSalesItemAssembly.SaveSalesItemAssemblyCollection(rSalesOrder.SalesItemAssemblys, rSalesOrder.SalesOrderID)

      For Each mSOI As dmSalesOrderItem In rSalesOrder.SalesOrderItems
        mdtoWO = New dtoWorkOrder(pDBConn)
        mdtoWO.SaveWorkOrderCollection(mSOI.WorkOrders, mSOI.SalesOrderItemID)

        '// Ensure any product details are also saved
        For Each mWO As dmWorkOrder In mSOI.WorkOrders
          If mWO.Product IsNot Nothing Then
            mdtoProduct = dtoProductBase.GetNewInstance(mWO.ProductTypeID, pDBConn)
            mdtoProduct.SaveProduct(mWO.Product)

            Select Case mWO.Product.ItemType
              Case eProductType.ProductFurniture
                mWO.ProductID = CType(mWO.Product, dmProductFurniture).ProductFurnitureID
            End Select


          End If
        Next

        'make sure the product id ends up in the work order
        mdtoWO.SaveWorkOrderCollection(mSOI.WorkOrders, mSOI.SalesOrderItemID)

      Next


      ''mdtoSOFiles = New dtoFileTracker(pDBConn)
      ''mdtoSOFiles.SaveFileTrackerCollection(rSalesOrder.SOFiles, eObjectType.SalesOrder, rSalesOrder.SalesOrderID)



      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetSalesOrderIDBySalesOrderItemID(ByVal vsalesOrderItemID As Integer) As Integer
    Dim mRetVal As Integer
    Dim mSQL As String = ""
    Try
      If pDBConn.Connect Then

        mSQL = "select distinct SalesOrderID from SalesOrderItem where SalesOrderItemID=" & vsalesOrderItemID

        mRetVal = pDBConn.ExecuteScalar(mSQL)

      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Sub SaveProductRequirement(ByRef rPR As dmSalesOrderItemProductRequirement)
    Dim mdto As dtoSalesOrderItemProductRequirement
    pDBConn.Connect()
    mdto = New dtoSalesOrderItemProductRequirement(pDBConn)
    mdto.SaveSalesOrderItemProductRequirement(rPR)
    pDBConn.Disconnect()
  End Sub

  Public Sub SaveProductRequirementCollection(ByRef rProductRequirementCol As colSalesOrderItemProductRequirements, ByVal vSalesOrderPhaseItemID As Integer)
    Dim mdto As dtoSalesOrderItemProductRequirement
    pDBConn.Connect()
    mdto = New dtoSalesOrderItemProductRequirement(pDBConn)
    mdto.SaveSalesOrderItemProductRequirementCollection(rProductRequirementCol, vSalesOrderPhaseItemID)
    pDBConn.Disconnect()
  End Sub

  Public Function LoadStandardProducts(ByRef rProducts As colProductBases) As Boolean
    Dim mRet As Boolean = False
    Dim mdtoInstallation As New dtoProductInstallation(DBConn)
    Dim mdtoStructure As New dtoProductStructure(DBConn)
    Dim mProductInstallations As New colProductInstallations
    Dim mProductStructures As New colProductStructures

    ''//Connect both dtos
    Try

      pDBConn.Connect()
      mdtoInstallation.LoadProductInstallationCollection(mProductInstallations)

      For Each mProduct As dmProductBase In mProductInstallations
        rProducts.Add(mProduct)
      Next
      mdtoStructure.LoadProductStructureCollection(mProductStructures)
      For Each mProduct As dmProductBase In mProductStructures
        rProducts.Add(mProduct)
      Next
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Function

  Public Sub LoadProductRequirementCollection(pProductRequirementProcessors As colProductRequirementProcessors, ByVal vWhere As String)
    Dim mdto As New dtoSalesOrderItemProductMaterialRequirementInfo(pDBConn, dtoSalesOrderItemProductMaterialRequirementInfo.eMode.Processor)

    pDBConn.Connect()

    mdto.LoadProductRequirementProcessorsByWhere(pProductRequirementProcessors, vWhere)

    pDBConn.Disconnect()

    If pProductRequirementProcessors IsNot Nothing Then
      For Each mProductReqProc As clsProductRequirementProcessor In pProductRequirementProcessors
        LoadProductRequirementInfoExtraFields(mProductReqProc, mProductReqProc.ProductRequirement.SalesOrderItemID, mProductReqProc.ProductRequirement.ProductID)

      Next
    End If

  End Sub

  Private Sub LoadProductRequirementInfoExtraFields(ByRef rProdReqProc As clsProductRequirementProcessor, ByVal vSalesItemID As Integer, vProductID As Integer)
    Dim mReader As IDataReader
    Try

      Dim mSQL As String = "Select  Workorderno, WorkOrderAllocationID from SalesOrderItemProductRequirement"

      mSQL &= " Inner Join SalesOrderPhaseItem on SalesOrderPhaseItem.SalesItemID = SalesOrderItemProductRequirement.SalesOrderItemID "
      mSQL &= " inner Join WorkOrderAllocation on WorkOrderAllocation.SalesOrderPhaseItemID = SalesOrderPhaseItem.SalesOrderPhaseItemID"
      mSQL &= " left Join WorkOrder on WorkOrder.WorkOrderID = WorkOrderAllocation.WorkOrderID And WorkOrder.ProductID = SalesOrderItemProductRequirement.ProductID"


      mSQL &= " Where SalesOrderPhaseItem.SalesItemID = " & vSalesItemID
      mSQL &= " And WorkOrder.ProductID = " & rProdReqProc.ProductRequirement.ProductID

      pDBConn.Connect()
      mReader = pDBConn.LoadReader(mSQL)

      Do While mReader.Read
        rProdReqProc.Workorderno = clsDBConnBase.DBReadString(mReader, "Workorderno")
        rProdReqProc.WorkOrderAllocationID = clsDBConnBase.DBReadInt32(mReader, "WorkOrderAllocationID")

      Loop

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Function LoadSalesOrderDown(ByRef rSalesOrder As dmSalesOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoSalesOrder
    Dim mdtoCust As dtoCustomer
    Dim mdtoCustContacts As dtoCustomerContact
    Dim mdtoWOs As dtoWorkOrder
    Dim mdtoInvoice As dtoInvoice
    Dim mdtoCustomerPurchaseOrder As dtoCustomerPurchaseOrder
    Dim mdtoSOIs As dtoSalesOrderItem
    Dim mdtoProduct As dtoProductBase
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtodtoProductBOM As dtoProductBOM
    Dim mdtoSalesOrderPhase As dtoSalesOrderPhase
    Dim mdtoSalesOrderPhaseItem As dtoSalesOrderPhaseItem
    Dim mdtoPhaseItemComponent As dtoPhaseItemComponent
    Dim mdtoMaterialRequirementChanges As dtoMaterialRequirement
    Dim mdtoSalesOrderHouse As dtoSalesOrderHouse
    Dim mdtodtoSalesItemAssembly As dtoSalesItemAssembly

    Dim mdtoWOFiles As dtoFileTracker
    Dim mProductStructure As dmProductStructure
    Dim mdtoComponents As dtoProductFurnitureComponent
    Dim mdtoSalesOrderStage As dtoSalesOrderStage
    Dim mdtoPaymentAccount As dtoPaymentOnAccount


    pDBConn.Connect()
    mdto = New dtoSalesOrder(pDBConn)
    mdto.LoadSalesOrder(rSalesOrder, vID)

    If rSalesOrder IsNot Nothing Then
      mdtoInvoice = New dtoInvoice(pDBConn)
      mdtoInvoice.LoadInvoiceCollection(rSalesOrder.Invoices, rSalesOrder.SalesOrderID)

      mdtoPaymentAccount = New dtoPaymentOnAccount(pDBConn)
      mdtoPaymentAccount.LoadPaymentOnAccountCollection(rSalesOrder.PaymentAccounts, rSalesOrder.SalesOrderID)

      mdtoCust = New dtoCustomer(pDBConn)
      mdtoCust.LoadCustomer(rSalesOrder.Customer, rSalesOrder.CustomerID)

      mdtoCustContacts = New dtoCustomerContact(pDBConn)
      If rSalesOrder.Customer IsNot Nothing Then
        mdtoCustContacts.LoadCustomerContactCollection(rSalesOrder.Customer.CustomerContacts, rSalesOrder.Customer.CustomerID)
      End If

      mdtoSOIs = New dtoSalesOrderItem(pDBConn)
      mdtoSOIs.LoadSalesOrderItemCollection(rSalesOrder.SalesOrderItems, rSalesOrder.SalesOrderID)

      mdtoCustomerPurchaseOrder = New dtoCustomerPurchaseOrder(pDBConn)
      mdtoCustomerPurchaseOrder.LoadCustomerPurchaseOrderCollection(rSalesOrder.CustomerPurchaseOrder, rSalesOrder.SalesOrderID)

      mdtoSalesOrderPhase = New dtoSalesOrderPhase(pDBConn)
      mdtoSalesOrderPhase.LoadSalesOrderPhaseCollection(rSalesOrder.SalesOrderPhases, rSalesOrder.SalesOrderID)

      mdtoSalesOrderStage = New dtoSalesOrderStage(pDBConn)
      mdtoSalesOrderStage.LoadSalesOrderStageCollection(rSalesOrder.SalesOrderStages, rSalesOrder.SalesOrderID)

      If rSalesOrder.SalesOrderPhases IsNot Nothing Then
        mdtoSalesOrderPhaseItem = New dtoSalesOrderPhaseItem(pDBConn)
        mdtoPhaseItemComponent = New dtoPhaseItemComponent(pDBConn)


        For Each mSOP As dmSalesOrderPhase In rSalesOrder.SalesOrderPhases
          mdtoSalesOrderPhaseItem.LoadSalesOrderPhaseItemCollection(mSOP.SalesOrderPhaseItems, mSOP.SalesOrderPhaseID)



          mdtoPhaseItemComponent.LoadPhaseItemComponentCollection(mSOP.PhaseItemComponents, mSOP.SalesOrderPhaseID)
        Next

      End If

      mdtoSalesOrderHouse = New dtoSalesOrderHouse(pDBConn)
      mdtoSalesOrderHouse.LoadSalesOrderHouseCollection(rSalesOrder.SalesOrderHouses, rSalesOrder.SalesOrderID)

      ''load all salesorderhouses
      For Each mSOH As dmSalesOrderHouse In rSalesOrder.SalesOrderHouses
        mdtoOutputDocs = New dtoOutputDocument(pDBConn)
        mdtoOutputDocs.LoadOutputDocumentCollection(mSOH.OutputDocuments, mSOH.SalesOrderHouseID, eParentType.SalesOrder)

      Next

      mdtodtoSalesItemAssembly = New dtoSalesItemAssembly(pDBConn, dtoSalesItemAssembly.eMode.SalesOrderItemAssembly)
      mdtodtoSalesItemAssembly.LoadSalesItemAssemblyCollection(rSalesOrder.SalesItemAssemblys, rSalesOrder.SalesOrderID)

      For Each mSOI As dmSalesOrderItem In rSalesOrder.SalesOrderItems
        mdtoWOs = New dtoWorkOrder(pDBConn)
        mdtoWOs.LoadWorkOrderCollection(mSOI.WorkOrders, mSOI.SalesOrderItemID)



        For Each mWO As dmWorkOrder In mSOI.WorkOrders
          '// Instantiate and Load up the details for the specific product type
          mWO.Product = clsProductSharedFuncs.NewProductInstance(mWO.ProductTypeID)
          If mWO.Product IsNot Nothing Then
            mdtoProduct = dtoProductBase.GetNewInstance(mWO.ProductTypeID, pDBConn)
            mdtoProduct.LoadProduct(mWO.Product, mWO.ProductID)
            mProductStructure = TryCast(mWO.Product, dmProductStructure)
            If mProductStructure IsNot Nothing Then
              mdtodtoProductBOM = New dtoProductBOM(pDBConn)
              mdtodtoProductBOM.LoadProductBOMCollection(mProductStructure.ProductStockItemBOMs, mProductStructure.ID, eProductBOMObjectType.StockItems)
              mdtodtoProductBOM.LoadProductBOMCollection(mProductStructure.ProductWoodBOMs, mProductStructure.ID, eProductBOMObjectType.Wood)
            End If
            mdtoWOFiles = New dtoFileTracker(pDBConn)
            mdtoWOFiles.LoadFileTrackerCollection(mWO.WOFiles, eObjectType.WorkOrder, mWO.WorkOrderID)
            mdtoOutputDocs = New dtoOutputDocument(pDBConn)
            mdtoOutputDocs.LoadOutputDocumentCollection(mWO.OutputDocuments, mWO.WorkOrderID, eParentType.WorkOrder)

          End If
        Next

      Next




    End If
    pDBConn.Disconnect()

    mRetVal = True

    Return mRetVal
  End Function

  Public Sub LoadWorkOrderInfoCollectionByWhere(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String)
    Dim mdto As dtoWorkOrderInfo
    Dim mWorkOrderTracking As New colWorkOrderInfos
    Dim mWOI As clsWorkOrderInfo
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(DBConn, dtoWorkOrderInfo.eMode.WorkOrderInfoInternal)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, vWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
      mdto = Nothing
    End Try

  End Sub

  Public Function LoadWorkOrderDown(ByRef rWorkOrder As dmWorkOrder, ByVal vID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder
    Dim mdtoProduct As dtoProductBase
    Dim mdtoMaterialRequirement As dtoMaterialRequirement
    Dim mdtoComponents As dtoProductFurnitureComponent

    Dim mdtoWOFiles As dtoFileTracker
    Dim mProductStructure As dmProductStructure
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoWorkOrderAllocation As dtoWorkOrderAllocation

    Dim mdtoSourcePallet As dtoSourcePallet
    Dim mdtoOutputPallet As dtoOutputPallet

    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrder(pDBConn)
      mdto.LoadWorkOrder(rWorkOrder, vID)
      mdtoSourcePallet = New dtoSourcePallet(pDBConn)
      mdtoOutputPallet = New dtoOutputPallet(pDBConn)

      mdtoSourcePallet.LoadSourcePalletCollection(rWorkOrder.SourcePallets, rWorkOrder.WorkOrderID)
      mdtoOutputPallet.LoadOutputPalletCollection(rWorkOrder.OutputPallets, rWorkOrder.WorkOrderID)
      '// Instantiate and Load up the details for the specific product type


      mdtoWOFiles = New dtoFileTracker(pDBConn)
      mdtoWOFiles.LoadFileTrackerCollection(rWorkOrder.WOFiles, eObjectType.WorkOrder, rWorkOrder.WorkOrderID)
      mdtoOutputDocs = New dtoOutputDocument(pDBConn)
      mdtoOutputDocs.LoadOutputDocumentCollection(rWorkOrder.OutputDocuments, rWorkOrder.WorkOrderID, eParentType.WorkOrder)

      mdtoWorkOrderAllocation = New dtoWorkOrderAllocation(pDBConn)
      mdtoWorkOrderAllocation.LoadWorkOrderAllocationCollection(rWorkOrder.WorkOrderAllocations, rWorkOrder.WorkOrderID)

      mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
      mdtoMaterialRequirement.LoadMaterialRequirementCollection(rWorkOrder.WoodMaterialRequirements, eObjectType.WorkOrder, rWorkOrder.WorkOrderID, eMaterialRequirementType.Wood)
      mdtoMaterialRequirement.LoadMaterialRequirementCollection(rWorkOrder.StockItemMaterialRequirements, eObjectType.WorkOrder, rWorkOrder.WorkOrderID, eMaterialRequirementType.StockItems)

      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function


  Public Function LoadSalesOrderPhaseItemsMatReqByWhere(ByRef rSalesOrderPhaseItems As colSalesOrderPhaseItemInfos, ByVal vWhere As String) As Boolean
    Dim mOk As Boolean
    Dim mProd As dmProductBase
    Try

      If pDBConn.Connect Then
        Dim mdto As New dtoSalesOrderPhaseItemInfo(pDBConn, dtoSalesOrderPhaseItemInfo.eMode.SalesOrderPhaseItemTracking)

        mOk = mdto.LoadSOPICollectionByWhere(rSalesOrderPhaseItems, vWhere)

        ''// Attach Products
        'For Each mSOPII As clsSalesOrderPhaseItemInfo In rSalesOrderPhaseItems
        '  mProd = AppRTISGlobal.GetInstance.ProductRegistry.GetProductFromTypeAndID(mSOPII.SalesOrderItem.ProductTypeID, mSOPII.SalesOrderItem.ProductID)
        '  mSOPII.Product = mProd
        'Next

        mdto = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Sub LoadSalesOrderPhaseItemInfoWoodCosts(ByRef rSalesOrderPhaseItemInfos As colSalesOrderPhaseItemInfos, ByRef rCostBookEntries As colCostBookEntrys, ByVal vCostingMethod As Boolean)
    Dim mWOAs As colWorkOrderAllocations
    Dim mWOs As New colWorkOrders
    Dim mWO As dmWorkOrder
    Dim mMRs As colMaterialRequirements
    Dim mSOPIIIDList As String = ""
    Dim mWOIDList As String = ""
    Dim mTotalWoodCost As Decimal
    Dim mCBEntry As dmCostBookEntry
    Dim mQty As Decimal
    Dim mWhere As String
    Dim mWoodPalletItemInfos As colWoodPalletItemInfos
    Dim mTotalPickedWoodCost As Decimal
    Dim mStockItem As dmStockItem

    For Each mSOPII As clsSalesOrderPhaseItemInfo In rSalesOrderPhaseItemInfos
      If mSOPIIIDList <> "" Then mSOPIIIDList = mSOPIIIDList & ", "
      mSOPIIIDList = mSOPIIIDList & mSOPII.SalesOrderPhaseItemID
    Next

    '// load mWOAs by where using salesorderphaseitemid in (mSOPIIIDList)
    mWOAs = New colWorkOrderAllocations
    mWhere = "SalesOrderPhaseItemID in (" & mSOPIIIDList & ")"
    If mWhere <> "SalesOrderPhaseItemID in ()" Then
      LoadWorkOrderAllocationsByWhere(mWOAs, mWhere)
    Else
      'LoadWorkOrderAllocationsByWhere(mWOAs, "")

    End If

    '// Now get the list of Work Orders that we are going to need
    For Each mWOA As dmWorkOrderAllocation In mWOAs
      If mWOIDList <> "" Then mWOIDList = mWOIDList & ", "
      mWOIDList = mWOIDList & mWOA.WorkOrderID
    Next

    '// Load mWOS by where using WorkOrderID in (mwoidlist)
    mWhere = "WorkOrderID in (" & mWOIDList & ")"

    If mWOIDList = "" Then
      mWhere = ""
    End If
    LoadWorkOrderByWhere(mWOs, mWhere)


    '// Load the mMRs by where using ObjectID in (mwoidlist) and objecttype = 2 and MaterialType = Wood
    mMRs = New colMaterialRequirements
    If mWOIDList <> "" Then
      mWhere = String.Format("ObjectID in ({0}) and ObjectType = {1} and MaterialRequirementType = {2}", mWOIDList, CInt(eObjectType.WorkOrder), CInt(eMaterialRequirementType.Wood))
      LoadMaterialRequirementByWhere(mMRs, mWhere)
    End If
    '// Now calculated the total cost for each SalesOrderPhaseItemInfo
    For Each mSOPII In rSalesOrderPhaseItemInfos
      mTotalWoodCost = 0
      For Each mWOA As dmWorkOrderAllocation In mWOAs
        If mWOA.SalesOrderPhaseItemID = mSOPII.SalesOrderPhaseItemID Then
          For Each mMR As dmMaterialRequirement In mMRs
            mQty = 0
            If mMR.ObjectID = mWOA.WorkOrderID Then
              '// Need to allocated the quantity based on proportion of Work Order in this allocation
              mWO = mWOs.ItemFromKey(mWOA.WorkOrderID)
              If mWO.Quantity > 0 Then
                mQty = mMR.Quantity * (mWOA.QuantityRequired / mWO.Quantity)
                mCBEntry = rCostBookEntries.ItemFromStockItemID(mMR.StockItemID)
                If mCBEntry IsNot Nothing Then

                  If vCostingMethod Then
                    mTotalWoodCost = mTotalWoodCost + (mCBEntry.CostIncludeRecovery * mMR.BoardFeetPerLine)

                  Else
                    mTotalWoodCost = mTotalWoodCost + (mCBEntry.Cost * mMR.BoardFeetPerLine)

                  End If

                End If
              End If

            End If
          Next
        End If
      Next
      mSOPII.SpecifiedWoodCost = mTotalWoodCost
    Next



    '// Load the Pallets by where using ObjectID in (mwoidlist)
    mWoodPalletItemInfos = New colWoodPalletItemInfos
    If mWOIDList <> "" Then
      mWhere = String.Format("WorkOrderID in ({0})", mWOIDList)
      LoadWoodPalletItemInfos(mWoodPalletItemInfos, mWhere)
    End If
    '// Now calculated the total cost for each SalesOrderPhaseItemInfo
    For Each mSOPII In rSalesOrderPhaseItemInfos
      mTotalPickedWoodCost = 0
      For Each mWOA As dmWorkOrderAllocation In mWOAs
        If mWOA.SalesOrderPhaseItemID = mSOPII.SalesOrderPhaseItemID Then
          For Each mWPII As clsWoodPalletItemInfo In mWoodPalletItemInfos
            mQty = 0
            If mWPII.WorkOrderID = mWOA.WorkOrderID Then
              '// Need to allocated the quantity based on proportion of Work Order in this allocation
              mWO = mWOs.ItemFromKey(mWOA.WorkOrderID)
              If mWO.Quantity > 0 Then
                mQty = mWPII.Quantity * (mWOA.QuantityRequired / mWO.Quantity)
                mCBEntry = rCostBookEntries.ItemFromStockItemID(mWPII.WoodPalletItem.StockItemID)
                If mCBEntry IsNot Nothing Then
                  mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPII.WoodPalletItem.StockItemID)
                  If mStockItem IsNot Nothing Then


                    If vCostingMethod Then
                      mTotalPickedWoodCost = mTotalPickedWoodCost + (mCBEntry.CostIncludeRecovery * clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPII.WoodPalletItem, mStockItem))

                    Else
                      mTotalPickedWoodCost = mTotalPickedWoodCost + (mCBEntry.Cost * clsWoodPalletSharedFuncs.GetWoodPalletItemVolumeBoardFeet(mWPII.WoodPalletItem, mStockItem))

                    End If


                  End If
                End If
              End If

            End If
          Next
        End If
      Next
      mSOPII.PickedWoodCost = mTotalPickedWoodCost
    Next
  End Sub

  Private Function LoadWoodPalletItemInfos(ByRef rWoodPalletItemInfos As colWoodPalletItemInfos, ByVal vWhere As String) As Boolean
    Dim mOk As Boolean

    Try

      If pDBConn.Connect Then
        Dim mdto As New dtoWoodPalletItemInfo(pDBConn)

        mOk = mdto.LoadWoodPalletItemInfoCollectionByWhere(rWoodPalletItemInfos, vWhere)

        mdto = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
      mOk = False
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Function LoadMaterialRequirementByWhere(ByRef rMRs As colMaterialRequirements, ByVal vWhere As String) As Boolean
    Dim mOk As Boolean

    Try

      If pDBConn.Connect Then
        Dim mdto As New dtoMaterialRequirement(pDBConn)

        mOk = mdto.LoadMaterialRequirementCollectionByWhere(rMRs, vWhere)

        mdto = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk

  End Function

  Public Function LoadWorkOrderByWhere(ByRef rWorkOrders As colWorkOrders, ByVal vWhere As String) As Boolean
    Dim mOk As Boolean
    Dim mWOs As New colWorkOrders
    Try

      If pDBConn.Connect Then
        Dim mdto As New dtoWorkOrder(pDBConn)

        mOk = mdto.LoadWorkOrderCollectionByWhere(mWOs, vWhere)


        For Each mWO As dmWorkOrder In mWOs
          LoadWorkOrderDown(mWO, mWO.WorkOrderID)
          rWorkOrders.Add(mWO)
        Next
        mdto = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Function LoadSalesOrderPhase(ByRef rSalesOrderPhase As dmSalesOrderPhase, ByVal vSalesOrderPhaseID As Integer) As Boolean
    Dim mOk As Boolean

    Try

      If pDBConn.Connect Then
        Dim mdtoSOP As New dtoSalesOrderPhase(pDBConn)

        mOk = mdtoSOP.LoadSalesOrderPhase(rSalesOrderPhase, vSalesOrderPhaseID)

        mdtoSOP = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function

  Public Function SaveWorkOrderDown(ByRef rWorkOrder As dmWorkOrder) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As dtoWorkOrder
    Dim mdtoMaterialRequirement As dtoMaterialRequirement
    Dim mdtoWOFiles As dtoFileTracker
    Dim mdtoOutputDocs As dtoOutputDocument
    Dim mdtoWorkOrderAllocation As dtoWorkOrderAllocation

    Dim mdtoOutputPallet As dtoOutputPallet
    Dim mdtoSourcePallet As dtoSourcePallet

    Try
      pDBConn.Connect()
      mdto = New dtoWorkOrder(pDBConn)
      mdto.SaveWorkOrder(rWorkOrder)


      mdtoWOFiles = New dtoFileTracker(pDBConn)
      mdtoWOFiles.SaveFileTrackerCollection(rWorkOrder.WOFiles, eObjectType.WorkOrder, rWorkOrder.WorkOrderID)
      mdtoOutputDocs = New dtoOutputDocument(pDBConn)
      mdtoOutputDocs.SaveOutputDocumentCollection(rWorkOrder.OutputDocuments, rWorkOrder.WorkOrderID)

      mdtoWorkOrderAllocation = New dtoWorkOrderAllocation(pDBConn)
      mdtoWorkOrderAllocation.SaveWorkOrderAllocationCollection(rWorkOrder.WorkOrderAllocations, rWorkOrder.WorkOrderID)



      mdtoSourcePallet = New dtoSourcePallet(pDBConn)
      mdtoOutputPallet = New dtoOutputPallet(pDBConn)

      mdtoSourcePallet.SaveSourcePalletCollection(rWorkOrder.SourcePallets, rWorkOrder.WorkOrderID)
      mdtoOutputPallet.SaveOutputPalletCollection(rWorkOrder.OutputPallets, rWorkOrder.WorkOrderID)

      mdtoMaterialRequirement = New dtoMaterialRequirement(pDBConn)
      mdtoMaterialRequirement.SaveMaterialRequirementCollection(rWorkOrder.WoodMaterialRequirements, eObjectType.WorkOrder, rWorkOrder.WorkOrderID, eMaterialRequirementType.Wood)
      mdtoMaterialRequirement.SaveMaterialRequirementCollection(rWorkOrder.StockItemMaterialRequirements, eObjectType.WorkOrder, rWorkOrder.WorkOrderID, eMaterialRequirementType.StockItems)


      pDBConn.Disconnect()
      mRetVal = True

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Function
  Public Function LoadSalesOrderPhaseItemsInfosByWhere(ByRef rSalesOrderPhaseItems As colSalesOrderPhaseItemInfos, ByVal vWhere As String) As Boolean
    Dim mOk As Boolean

    Try

      If pDBConn.Connect Then
        Dim mdto As New dtoSalesOrderPhaseItemInfo(pDBConn, dtoSalesOrderPhaseItemInfo.eMode.SalesOrderPhaseItemInfo)

        mOk = mdto.LoadSOPICollectionByWhere(rSalesOrderPhaseItems, vWhere)


        mdto = Nothing
      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOk
  End Function
  Public Function LoadWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String, ByVal vMode As dtoWorkOrderInfo.eMode) As Boolean
    Dim mdto As dtoWorkOrderInfo
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, vMode)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, vWhere)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function


  Public Function LoadSalesOrderPhaseInfos(ByRef rSalesOrderPhaseInfos As colSalesOrderPhaseInfos, ByVal vWhere As String) As Boolean
    Dim mdto As dtoSalesOrderPhaseInfo
    Dim mRetVal As Boolean

    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseInfo(pDBConn)
      mdto.LoadSOPCollectionByWhere(rSalesOrderPhaseInfos, vWhere)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadSalesOrderPhaseInfo(ByRef rSalesOrderPhaseInfo As clsSalesOrderPhaseInfo, ByVal vWhere As String) As Boolean
    Dim mdto As dtoSalesOrderPhaseInfo
    Dim mRetVal As Boolean
    Dim mSOPInfos As New colSalesOrderPhaseInfos
    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderPhaseInfo(pDBConn)
      mdto.LoadSOPCollectionByWhere(mSOPInfos, vWhere)
      If mSOPInfos IsNot Nothing And mSOPInfos.Count > 0 Then
        rSalesOrderPhaseInfo = mSOPInfos(0)
      End If
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadInternalWorkOrderInfos(ByRef rWorkOrderInfos As colWorkOrderInfos, ByVal vWhere As String) As Boolean
    Dim mdto As dtoWorkOrderInfo
    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoWorkOrderInfo(pDBConn, dtoWorkOrderInfo.eMode.WorkOrderInfoInternal)
      mdto.LoadWorkOrderInfoCollectionByWhere(rWorkOrderInfos, vWhere)
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function


  Public Function SaveSalesOrderItemWithWOs(ByRef rSalesOrderItem As dmSalesOrderItem) As Boolean
    Dim mdto As dtoSalesOrderItem
    Dim mdtoWO As dtoWorkOrder

    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoSalesOrderItem(pDBConn)
      mdto.SaveSalesOrderItem(rSalesOrderItem)

      mdtoWO = New dtoWorkOrder(pDBConn)
      mdtoWO.SaveWorkOrderCollection(rSalesOrderItem.WorkOrders, rSalesOrderItem.SalesOrderItemID)


      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function


  Public Sub RaiseWorkOrderNo(ByRef rSalesOrderItem As dmSalesOrderItem, ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vSalesOrderNo As String)
    Dim mWONo As Integer
    Dim mWONostr As String = ""
    Dim mdso As dsoGeneral
    Dim mWONoSuffix As Integer = 0


    '// See if the first Work Order Parent Sales Order Item has 

    If rSalesOrderItem.WorkOrders.Count > 0 Then
      mWONostr = rSalesOrderItem.WorkOrders(0).WorkOrderNo
      If mWONostr Is Nothing Then mWONostr = ""
      If mWONostr.Contains("-") Then
        mWONostr = mWONostr.Substring(0, mWONostr.IndexOf("-"))
      End If
    End If

    If mWONostr = "" Then
      mdso = New dsoGeneral(rDBConn)
      mWONo = mdso.GetNextTallyWorkOrderNo()
      mWONostr = clsConstants.WorkOrderNoPrefix & mWONo.ToString("00000")
    End If

    If rSalesOrderItem.WorkOrders.Count = 1 Then
      rSalesOrderItem.WorkOrders(0).WorkOrderNo = mWONostr
    Else
      For Each mWO As dmWorkOrder In rSalesOrderItem.WorkOrders
        mWONoSuffix += 1
        mWO.WorkOrderNo = mWONostr & "-" & mWONoSuffix
        mWO.SalesOrderItemWOIndex = mWONoSuffix
        mWO.SOWONumber = vSalesOrderNo & "-" & rSalesOrderItem.ItemNumber & "-" & mWONoSuffix
      Next
    End If

  End Sub

  Friend Sub SynchroniseWOMatReqPickedConnected(ByVal vStockItemID As Integer, ByVal vWorkOrderID As Integer)
    'Dim mSQL As String
    'Dim mSQLUpdate As String
    'Dim mPickedQty As Decimal

    'mSQL = "Select SUM(PickedQty) as PickedQty"
    'mSQL = mSQL & " from MaterialRequirement MR"
    'mSQL = mSQL & " Inner Join WorkOrder WO on WO.WorkOrderID = MR.ObjectID"
    'mSQL = mSQL & " Where StockItemID = " & vStockItemID & " And Wo.WorkOrderID = " & vWorkOrderID


    'mPickedQty = pDBConn.ExecuteScalar(mSQL)

    'mSQLUpdate = "Update MaterialRequirement Set PickedQty = " & mPickedQty
    'mSQLUpdate = mSQLUpdate & " Where StockItemID = " & vStockItemID & " And ObjectID = " & vWorkOrderID

    'pDBConn.ExecuteNonQuery(mSQLUpdate)
  End Sub


  Friend Sub SynchroniseWOMatReqReturnedConnected(ByVal vStockItemID As Integer, ByVal vWorkOrderID As Integer)
    Dim mSQL As String
    Dim mSQLUpdate As String
    Dim mReturnQty As Decimal

    mSQL = "Select SUM(ReturnQty) as ReturnQty"
    mSQL = mSQL & " from MaterialRequirement MR"
    mSQL = mSQL & " Inner Join WorkOrder WO on WO.WorkOrderID = MR.ObjectID"
    mSQL = mSQL & " Where StockItemID = " & vStockItemID & " And Wo.WorkOrderID = " & vWorkOrderID


    mReturnQty = pDBConn.ExecuteScalar(mSQL)

    mSQLUpdate = "Update MaterialRequirement Set ReturnQty = " & mReturnQty
    mSQLUpdate = mSQLUpdate & " Where StockItemID = " & vStockItemID & " And ObjectID = " & vWorkOrderID

    pDBConn.ExecuteNonQuery(mSQLUpdate)
  End Sub
  Public Function WorkOrderNoFromID(ByVal vID As Integer) As String
    Dim mRetVal As String = ""
    Dim mSQL As String
    Try

      mSQL = "Select WorkOrderNo From WorkOrder Where WorkOrderID = " & vID
      pDBConn.Connect()
      mRetVal = clsGeneralA.DBValueToString(pDBConn.ExecuteScalar(mSQL))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function GetSalesOrderIDFromWorkOrderID(ByVal vID As Integer) As Integer
    Dim mRetVal As String = ""
    Dim mSQL As String
    Try

      mSQL = "Select SalesOrderItem.SalesOrderID From WorkOrder Inner Join SalesOrderItem on WorkOrder.SalesOrderItemID = SalesOrderItem.SalesOrderItemID Where WorkOrderID = " & vID
      pDBConn.Connect()
      mRetVal = clsGeneralA.DBValueToString(pDBConn.ExecuteScalar(mSQL))

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SaveMaterialRequirementsCollection(ByRef rMaterialRequirents As colMaterialRequirements, ByVal vObjectType As eObjectType, ByVal vObjectID As Integer, ByVal vMatReqType As eMaterialRequirementType) As Boolean
    Dim mdto As dtoMaterialRequirement

    Dim mRetVal As Boolean
    Try

      pDBConn.Connect()
      mdto = New dtoMaterialRequirement(pDBConn)
      mdto.SaveMaterialRequirementCollection(rMaterialRequirents, vObjectType, vObjectID, vMatReqType)

      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

End Class
