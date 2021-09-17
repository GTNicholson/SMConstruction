Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccWorkOrderSalesItemDetails
  Private pSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
  Private pDBConn As clsDBConnBase
  Private pOptionMaterialesView As eOptionMaterialesView
  Private pMaterialRequirementInfoWoods As colMaterialRequirementInfos
  Private pMaterialRequirementInfoInsumos As colMaterialRequirementInfos
  Private pWorkOrderInfo As clsWorkOrderInfo

  Public Sub New(ByRef rSalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo, ByRef rDBConn As clsDBConnBase, ByVal vOptionMat As eOptionMaterialesView)
    Me.pSalesOrderPhaseItemInfo = rSalesOrderPhaseItemInfo
    Me.pDBConn = rDBConn
    Me.pOptionMaterialesView = vOptionMat
    pMaterialRequirementInfoWoods = New colMaterialRequirementInfos
    pMaterialRequirementInfoInsumos = New colMaterialRequirementInfos
    pWorkOrderInfo = New clsWorkOrderInfo
  End Sub

  Public Property MaterialRequirementInfoInsumos As colMaterialRequirementInfos
    Get
      Return pMaterialRequirementInfoInsumos
    End Get
    Set(value As colMaterialRequirementInfos)
      pMaterialRequirementInfoInsumos = value
    End Set
  End Property

  Public Property MaterialRequirementInfoWoods As colMaterialRequirementInfos
    Get
      Return pMaterialRequirementInfoWoods
    End Get
    Set(value As colMaterialRequirementInfos)
      pMaterialRequirementInfoWoods = value
    End Set
  End Property

  Public Property SalesOrderPhaseItemInfo As clsSalesOrderPhaseItemInfo
    Get
      Return pSalesOrderPhaseItemInfo
    End Get
    Set(value As clsSalesOrderPhaseItemInfo)
      pSalesOrderPhaseItemInfo = value
    End Set
  End Property

  Public Property OptionMaterialesView As eOptionMaterialesView
    Get
      Return pOptionMaterialesView
    End Get
    Set(value As eOptionMaterialesView)
      pOptionMaterialesView = value
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

  Public Sub LoadDataRef()
    Dim mdto As dtoMaterialRequirementInfo
    Dim mdso As dsoSalesOrder
    Dim mWOInfos As New colWorkOrderInfos
    Dim mdsoCostBook As dsoCostBook
    Dim mColCostBookEntries As colCostBookEntrys

    Dim mWhere As String = "SalesOrderPhaseItemID = " & pSalesOrderPhaseItemInfo.SalesOrderPhaseItemID & " and MaterialRequirementType = " & CInt(eMaterialRequirementType.Wood) & " and isnull(Quantity,0)<>0"
    pMaterialRequirementInfoWoods.Clear()
    pMaterialRequirementInfoInsumos.Clear()

    Try

      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.WoodMat)

      mdto.LoadWoodMatReqByWhere(pMaterialRequirementInfoWoods, mWhere)

      mdto = New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.Info)
      mWhere = "SalesOrderPhaseItemID = " & pSalesOrderPhaseItemInfo.SalesOrderPhaseItemID & " and MaterialRequirementType = " & CInt(eMaterialRequirementType.StockItems) & " and isnull(Quantity,0)<>0"
      mdto.LoadMaterialRequirementCollection(pMaterialRequirementInfoInsumos, mWhere)

      mdso = New dsoSalesOrder(pDBConn)

      mdso.LoadInternalWorkOrderInfos(mWOInfos, "WorkOrderID = (Select Distinct WorkOrderID from WorkOrderAllocation where SalesOrderPhaseItemID = " & pSalesOrderPhaseItemInfo.SalesOrderPhaseItemID & ")")

      If mWOInfos.Count > 0 Then
        pWorkOrderInfo = mWOInfos(0)
      End If

      ''//Load CostBookEntries
      mdsoCostBook = New dsoCostBook(pDBConn)
      mColCostBookEntries = New colCostBookEntrys

      mdsoCostBook.LoadCostBookEntryByWhere(mColCostBookEntries, String.Format("CostBookID = (Select distinct ProductCostBookID from SalesOrder where SalesOrderID = {0})", pSalesOrderPhaseItemInfo.SalesOrderID))

      For Each mMRI As clsMaterialRequirementInfo In pMaterialRequirementInfoWoods

        If mColCostBookEntries.ItemFromStockItemID(mMRI.StockItem.StockItemID) IsNot Nothing Then
          mMRI.AverageCost = mColCostBookEntries.ItemFromStockItemID(mMRI.StockItem.StockItemID).Cost
        End If
      Next


      ''Exchange Cordobas for the stockitems

      If pSalesOrderPhaseItemInfo.DateCommitted = Date.MinValue Then
        pSalesOrderPhaseItemInfo.TempDateExchange = pSalesOrderPhaseItemInfo.DateEntered
      Else
        pSalesOrderPhaseItemInfo.TempDateExchange = pSalesOrderPhaseItemInfo.DateCommitted
      End If
      If pSalesOrderPhaseItemInfo.TempDateExchange = Date.MinValue Then pSalesOrderPhaseItemInfo.TempDateExchange = Now
      pSalesOrderPhaseItemInfo.ExchangeRate = GetExchangeRate(pSalesOrderPhaseItemInfo.TempDateExchange, eCurrency.Cordobas)
      If pSalesOrderPhaseItemInfo.ExchangeRate > 0 Then


        For Each mMRInsumos As clsMaterialRequirementInfo In pMaterialRequirementInfoInsumos
          mMRInsumos.ExchangeRate = pSalesOrderPhaseItemInfo.ExchangeRate

        Next

      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


  End Sub

  Public Function GetExchangeRate(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mExchangeRate As Decimal = 0

    If vDate <> Date.MinValue Then
      mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(vDate, vCurrency)

    Else
      mExchangeRate = mdsoGeneral.GetExchangeRateUnconnected(Now, vCurrency)

    End If

    Return mExchangeRate
  End Function

End Class
