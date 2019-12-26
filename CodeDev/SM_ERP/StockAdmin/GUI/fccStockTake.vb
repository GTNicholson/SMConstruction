Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class fccStockTake
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pStockTakeID As Integer
  Private pStockTake As dmStockTake
  ''Private pStockItemValuations As colStockItemValuations
  Public Property Mode As eMode

  Public Enum eMode
    StockTake = 0
    StockValuation = 1
    AdhocValuation = 2
  End Enum

  Public Property DBConn() As RTIS.DataLayer.clsDBConnBase
    Get
      DBConn = pDBConn
    End Get
    Set(ByVal value As RTIS.DataLayer.clsDBConnBase)
      pDBConn = value
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

  ''Public ReadOnly Property StockItemValuations As colStockItemValuations
  ''  Get
  ''    Return pStockItemValuations
  ''  End Get
  ''End Property

  Public Property StockTakeID() As Integer
    Get
      StockTakeID = pStockTakeID
    End Get
    Set(ByVal value As Integer)
      pStockTakeID = value

    End Set
  End Property

  Public Property CurrentStockCheckItem As dmStockTakeItem

  Public Property StockCheck() As dmStockTake
    Get
      StockCheck = pStockTake
    End Get
    Set(ByVal value As dmStockTake)
      pStockTake = value
    End Set
  End Property


  Public Function LoadRefData() As Boolean
    Dim mOK As Boolean
    Try

      mOK = True

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
    Return mOK
  End Function


  Public Function LoadObject() As Boolean
    ''Dim mdsoStock As New dsoStock(DBConn)
    Dim mOK As Boolean
    Dim mStockItemIDs As New List(Of Integer)
    Dim mStockItems As colStockItems
    Try


      Select Case Mode

        Case eMode.StockTake, eMode.StockValuation
          '// Stock Check
          If pStockTakeID = 0 Then
            mOK = True
            '// New
            pStockTake = New dmStockTake
            pStockTake.SnapshotDateTime = Now
            ''pStockTake.StockTakeTypeID = StockTakeTypeID

          Else
            '// Load
            ''mOK = mdsoStock.LoadStockCheckDown(pStockTake, pStockTakeID)
            ''StockCheckTypeID = pStockTake.StockCheckTypeID
          End If


          ''For Each mSCItem As dmStockTakeItem In pStockTake.StockTakeItems
          ''        If mStockItemIDs.Contains(mSCItem.StockItemID) = False Then mStockItemIDs.Add(mSCItem.StockItemID)
          ''        Next

          ''        If mStockItemIDs.Count <> 0 Then
          ''          mStockItems = New colStockItems
          ''          mdsoStock.LoadStockItems(mStockItems, String.Format("StockItemID IN ({0})", String.Join(",", mStockItemIDs.ToArray)))

          ''          For Each mSCItem As dmStockCheckItem In pStockTake.StockCheckItems
          ''            mSCItem.StockItem = mStockItems.ItemFromKey(mSCItem.StockItemID)
          ''          Next
          ''        End If

          ''        CreateStockItemValuations()

          ''        If (Mode = eMode.StockTake Or Mode = eMode.StockValuation) AndAlso pStockTakeID = 0 Then
          ''          SaveObject()
          ''        End If

          ''      Case eMode.AdhocValuation
          ''        '// Valuation

          ''        Select Case StockCheckTypeID
          ''          Case eStockCheckType.StockValuation
          ''            LoadCurrentStock()
          ''            mOK = True
          ''          Case eStockCheckType.WIPValuation
          ''            pStockItemValuations = New colStockItemValuations
          ''            LoadWIPStock(Now.Date.AddDays(1))
          ''            CreateWIPStockCheckItems()
          ''            mOK = True
          ''        End Select

      End Select

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    Finally
      ''mdsoStock = Nothing
    End Try
    Return mOK
  End Function

  ''Public Sub CreateStockItemValuations()
  ''  Dim mSIV As clsStockItemValuation

  ''  pStockItemValuations = New colStockItemValuations

  ''  For Each mSCItem As dmStockCheckItem In pStockTake.StockCheckItems
  ''    mSIV = New clsStockItemValuation(mSCItem.StockItem)
  ''    mSIV.StockCheckItem = mSCItem
  ''    StockItemValuations.Add(mSIV)
  ''  Next

  ''End Sub

  ''Public Sub AddDefaultItemsNonWIP()
  ''  Dim mdsoStock As New dsoStock(pDBConn)
  ''  Dim mProposedStockCheckItems As New colStockCheckItems
  ''  Dim mStockItemLocationInfos As colStockItemLocationInfos
  ''  Dim mStockItemLocationInfosExtras As colStockItemLocationInfos

  ''  Dim mStockCheckItem As dmStockCheckItem
  ''  Dim mWhere As String = String.Empty
  ''  Dim mExtra As String = String.Empty

  ''  mStockItemLocationInfos = New colStockItemLocationInfos


  ''  ''mWhere = String.Format("Category IN({0},{1}) AND Qty <> 0", CByte(eStockItemCategory.Ironmongery), CByte(eStockItemCategory.IntumescentStripSeals))
  ''  mWhere = String.Format("Category IN({0},{1}) AND Qty <> 0", CByte(eStockItemCategory.Ironmongery), CByte(eStockItemCategory.IntumescentStripSeals))

  ''  mdsoStock.LoadStockItemLocationInfosByWhere(mStockItemLocationInfos, mWhere)


  ''  '// mExtra to get the sotckitems that have moved since the date in question
  ''  mExtra = "select StockItemID from"
  ''  mExtra = mExtra & " stockitemtransactionlog"
  ''  mExtra = mExtra & " Inner Join StockItemLocation on ObjectID = StockItemLocationID"
  ''  mExtra = mExtra & " Where ObjectType = 7 and TransactionDate >= '" & pStockTake.StockCheckDate.ToString("yyyy/MM/dd") & "'"

  ''  mWhere = String.Format("Category IN({0},{1}) And qty = 0 And StockItemID in ({2})", CByte(eStockItemCategory.Ironmongery), CByte(eStockItemCategory.IntumescentStripSeals), mExtra)

  ''  mStockItemLocationInfosExtras = New colStockItemLocationInfos

  ''  mdsoStock.LoadStockItemLocationInfosByWhere(mStockItemLocationInfosExtras, mWhere)

  ''  For Each mSIVIExtra As clsStockItemLocationInfo In mStockItemLocationInfosExtras
  ''    If mStockItemLocationInfos.ItemFromStockItemIDLocationID(mSIVIExtra.StockItemID, mSIVIExtra.LocationID) Is Nothing Then
  ''      mStockItemLocationInfos.Add(mSIVIExtra)
  ''    End If
  ''  Next

  ''  For Each mSILocationInfo As clsStockItemLocationInfo In mStockItemLocationInfos
  ''    mStockCheckItem = mProposedStockCheckItems.ItemFromStockItemIDLocationIDPhaseID(mSILocationInfo.StockItemID, mSILocationInfo.LocationID, 0)
  ''    If mStockCheckItem Is Nothing Then
  ''      '// Add
  ''      mStockCheckItem = New dmStockCheckItem
  ''      mStockCheckItem.LocationID = mSILocationInfo.LocationID
  ''      mStockCheckItem.StockItemID = mSILocationInfo.StockItemID
  ''      '  mStockCheckItem.SnapshotQty = mSILocationInfo.Quantity
  ''      mStockCheckItem.StockCheckID = pStockTake.StockCheckID
  ''      mProposedStockCheckItems.Add(mStockCheckItem)
  ''    End If
  ''  Next

  ''  For Each mStockCheckItem In mProposedStockCheckItems
  ''    If pStockTake.StockCheckItems.ItemFromStockItemIDLocationIDPhaseID(mStockCheckItem.StockItemID, mStockCheckItem.LocationID, mStockCheckItem.SalesOrderPhaseID) Is Nothing Then pStockTake.StockCheckItems.Add(mStockCheckItem)
  ''  Next

  ''  SaveObject()
  ''  LoadObject()

  ''End Sub



  ''Public Function IsDirty() As Boolean
  ''  Dim mIsDirty As Boolean = True
  ''  If Not pStockTake Is Nothing Then
  ''    mIsDirty = pStockTake.IsAnyDirty
  ''  Else
  ''    mIsDirty = False
  ''  End If
  ''  Return mIsDirty
  ''End Function

  ''Public Function ValidateObject() As clsValidate
  ''  Dim mValidate As New clsValidate
  ''  mValidate.ValOk = True
  ''  If False Then '' Change to perform validation checks
  ''    mValidate.ValOk = False
  ''    mValidate.AddMsgLine("Check failed details")
  ''  End If
  ''  Return mValidate
  ''End Function

  ''Public Function SaveObject() As Boolean
  ''  Dim mOK As Boolean = False
  ''  Dim mdsoStock As New dsoStock(DBConn)

  ''  Try

  ''    mOK = mdsoStock.SaveStockCheck(pStockTake)

  ''    If pStockTakeID = 0 Then
  ''      pStockTakeID = pStockTake.StockCheckID
  ''    End If

  ''    If mOK Then mOK = SaveStockCheckItems(pStockTake.StockCheckItems)


  ''  Catch ex As Exception
  ''    mOK = False
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  Finally
  ''    mdsoStock = Nothing
  ''  End Try

  ''  Return mOK
  ''End Function


  ''Public Function SaveCurrentStockCheckItem() As Boolean
  ''  Dim mOK As Boolean = False
  ''  Dim mdsoStock As New dsoStock(DBConn)
  ''  Dim mStockCheckItems As New colStockCheckItems

  ''  Try
  ''    If CurrentStockCheckItem IsNot Nothing Then

  ''      If pStockTake IsNot Nothing Then

  ''        If pStockTake.StockCheckID = 0 Then
  ''          SaveObject()
  ''        End If

  ''        mStockCheckItems.Add(CurrentStockCheckItem)

  ''        mOK = mdsoStock.SaveStockCheckItems(mStockCheckItems, pStockTakeID)
  ''      End If
  ''    End If
  ''  Catch ex As Exception
  ''    mOK = False
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  Finally
  ''    mdsoStock = Nothing
  ''  End Try

  ''  Return mOK
  ''End Function

  ''Public Function SaveStockCheckItems(ByVal vStockCheckItems As colStockCheckItems) As Boolean
  ''  Dim mOK As Boolean = False
  ''  Dim mdsoStock As New dsoStock(DBConn)

  ''  Try
  ''    mOK = mdsoStock.SaveStockCheckItems(vStockCheckItems, pStockTakeID)

  ''  Catch ex As Exception
  ''    mOK = False
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  Finally
  ''    mdsoStock = Nothing
  ''  End Try

  ''  Return mOK
  ''End Function

  ''Public Sub ClearObjects()

  ''  pStockTake = Nothing

  ''End Sub

  ''''Public Sub LoadStockValuationHistory(ByVal vEndTimeDate As DateTime)
  ''''  Dim mdso As New dsoStock(pDBConn)
  ''''  Dim mQty As Decimal

  ''''  Try
  ''''    If pDBConn.Connect() Then
  ''''      For Each mSIV As clsStockItemValuation In StockItemValuations
  ''''        mQty = 0
  ''''        Select Case Mode
  ''''          Case eMode.StockTake
  ''''            If mSIV.IsCounted Then
  ''''              mQty = mSIV.CountedQty
  ''''            Else
  ''''              mQty = mSIV.SnapshotQty
  ''''            End If

  ''''          Case eMode.AdhocValuation
  ''''            Select Case StockCheckTypeID
  ''''              Case eStockCheckType.StockValuation
  ''''                mQty = mSIV.StockQty
  ''''              Case eStockCheckType.StockValuationWIP
  ''''                mQty = mSIV.BalanceQty
  ''''            End Select

  ''''          Case eMode.StockValuation
  ''''            mQty = mSIV.SnapshotQty
  ''''        End Select

  ''''        mdso.LoadStockItemValueHistoryConnected(mSIV.StockItemValuationHistorys, mSIV.StockItem.StockItemID, mQty, mSIV.SalesOrderPhaseID, vEndTimeDate)

  ''''        Select Case Mode
  ''''          Case eMode.StockValuation
  ''''            mSIV.SnapShotUnitCost = mSIV.TotalValue
  ''''            mSIV.TotalValue = mSIV.StockItemValuationsTotal
  ''''        End Select

  ''''      Next
  ''''    End If
  ''''  Catch ex As Exception
  ''''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''''  Finally
  ''''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''''  End Try

  ''''End Sub

  ''Public Function LoadSalesOrderDown(ByRef vSalesOrder As dmSalesOrder, ByVal vSalesOrderID As Integer) As Boolean
  ''  Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
  ''  Dim mOK As Boolean
  ''  Try
  ''    mOK = mdsoSalesOrder.LoadSalesOrderDown(vSalesOrder, vSalesOrderID)
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  End Try
  ''  Return mOK
  ''End Function

  ''Public Function LoadPhaseDespatchedWIP(ByVal vSalesOrder As dmSalesOrder, ByVal vSalesOrderPhaseID As Integer, ByVal vStockItems As colStockItems) As colMaterialRequirements
  ''  Dim mSalesOrderPhase As dmSalesOrderPhase
  ''  Dim mSIRParts As colSalesItemRefParts
  ''  Dim mManProcSession As clsManufacturingProcessSession
  ''  Dim mMatReqs As New colMaterialRequirements

  ''  mSalesOrderPhase = vSalesOrder.SalesOrderPhases.ItemFromKey(vSalesOrderPhaseID)

  ''  mSIRParts = New colSalesItemRefParts

  ''  For Each mPallet As dmPallet In mSalesOrderPhase.Pallets
  ''    If mPallet.DespatchID <> 0 Then
  ''      For Each mPalletItem As dmPalletItem In mPallet.PalletItems
  ''        If mPalletItem.ItemType <> eSalesItemPartType.esiptLoose Then
  ''          mSIRParts.Add(mSalesOrderPhase.SalesOrderPhaseItems.GetSalesItemRefParts.ItemFromSalesItemRefIDPartType(mPalletItem.ItemID, mPalletItem.ItemType))
  ''        End If
  ''      Next
  ''    End If
  ''  Next

  ''  If mSIRParts.Count > 0 Then
  ''    Dim mScheduleManager As New clsScheduleManager(vSalesOrder)
  ''    mScheduleManager.RefreshAllSalesItems()


  ''    mManProcSession = New clsManufacturingProcessSession(vSalesOrder, mSIRParts, pDBConn, vStockItems, Nothing, Nothing, clsManufacturingProcessSession.eBulkMode.SourceNone) '// NO sundires?
  ''    mManProcSession.CreateAllProcessItemIOs()


  ''    Dim mMatReqHandler As New clsMaterialRequirementHandler(mManProcSession, False)
  ''    mMatReqs = mMatReqHandler.GenerateAllMatReq(False)
  ''  End If



  ''  Return mMatReqs
  ''End Function

  ''Public Function LoadPhaseInvoicedWIP(ByVal vSalesOrder As dmSalesOrder, ByVal vSalesOrderPhaseID As Integer, ByVal vStockItems As colStockItems) As colMaterialRequirements
  ''  Dim mSalesOrderPhase As dmSalesOrderPhase
  ''  Dim mSIRParts As colSalesItemRefParts
  ''  Dim mManProcSession As clsManufacturingProcessSession
  ''  Dim mMatReqs As New colMaterialRequirements


  ''  mSalesOrderPhase = vSalesOrder.SalesOrderPhases.ItemFromKey(vSalesOrderPhaseID)

  ''  mSIRParts = New colSalesItemRefParts

  ''  For Each mDespatch As dmDespatch In mSalesOrderPhase.Despatches
  ''    If mDespatch.InvoiceID <> 0 Then
  ''      For Each mPallet As dmPallet In mSalesOrderPhase.Pallets.PalletsByDespatchID(mDespatch.DespatchID)
  ''        For Each mPalletItem As dmPalletItem In mPallet.PalletItems
  ''          If mPalletItem.ItemType <> eSalesItemPartType.esiptLoose Then
  ''            mSIRParts.Add(mSalesOrderPhase.SalesOrderPhaseItems.GetSalesItemRefParts.ItemFromSalesItemRefIDPartType(mPalletItem.ItemID, mPalletItem.ItemType))
  ''          End If
  ''        Next
  ''      Next
  ''    End If
  ''  Next

  ''  If mSIRParts.Count > 0 Then
  ''    Dim mScheduleManager As New clsScheduleManager(vSalesOrder)
  ''    mScheduleManager.RefreshAllSalesItems()

  ''    ''LoadStockItems()
  ''    mManProcSession = New clsManufacturingProcessSession(vSalesOrder, mSIRParts, pDBConn, vStockItems, Nothing, Nothing, clsManufacturingProcessSession.eBulkMode.SourceNone) '// NO sundires?
  ''    mManProcSession.CreateAllProcessItemIOs()


  ''    Dim mMatReqHandler As New clsMaterialRequirementHandler(mManProcSession, False)
  ''    mMatReqs = mMatReqHandler.GenerateAllMatReq(False)
  ''  End If



  ''  Return mMatReqs
  ''End Function

  ''Public Function GetStockItemsForSalesOrder(ByRef rSalesOrder As dmSalesOrder)
  ''  Dim mdsoStock As New dsoStock(pDBConn)
  ''  Dim mRetVal As New colStockItems

  ''  Try
  ''    If pDBConn.Connect Then
  ''      ''mdsoStock.LoadStockItems(mRetVal, "")
  ''      mdsoStock.LoadStockItemRegistryForSalesOrder(mRetVal, rSalesOrder)
  ''    End If

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''    mdsoStock = Nothing
  ''  End Try
  ''  Return mRetVal
  ''End Function

  ''Public Sub UpdateDespatchedQty(ByVal vSalesOrderPhaseID As Integer, ByVal vEndDateTime As DateTime)
  ''  Dim mMatReqs As colMaterialRequirements
  ''  Dim mMatReq As dmMaterialRequirement
  ''  Dim mSalesOrder As dmSalesOrder
  ''  Dim mdsoSalesOrder As New dsoSalesOrder(pDBConn)
  ''  Dim mSalesOrderID As Integer
  ''  Dim mSalesOrderPhase As dmSalesOrderPhase
  ''  Dim mDespatchedLooseDic As New Dictionary(Of Integer, Integer)
  ''  Dim mInvoicedLooseDic As New Dictionary(Of Integer, Integer)
  ''  Dim mLooseItem As dmLooseItem
  ''  Dim mDespatch As dmDespatch
  ''  Dim mInvoice As dmInvoice
  ''  Dim mStockItems As colStockItems
  ''  Dim mSomeDespatched As Boolean = False
  ''  Dim mSomeInvoiced As Boolean = False

  ''  mSalesOrderID = mdsoSalesOrder.GetSalesOrderIDFromSalesOrderPhaseID(vSalesOrderPhaseID)

  ''  If mSalesOrderID <> 0 Then
  ''    mSalesOrder = New dmSalesOrder
  ''    If LoadSalesOrderDown(mSalesOrder, mSalesOrderID) Then

  ''      mSalesOrderPhase = mSalesOrder.SalesOrderPhases.ItemFromKey(vSalesOrderPhaseID)


  ''      For Each mPallet As dmPallet In mSalesOrderPhase.Pallets
  ''        If mPallet.DespatchID <> 0 Then
  ''          mSomeDespatched = True
  ''          mDespatch = mSalesOrderPhase.Despatches.ItemFromKey(mPallet.DespatchID)
  ''          If mDespatch IsNot Nothing Then
  ''            If mDespatch.DespatchDate <= vEndDateTime Then

  ''              For Each mPalletItem As dmPalletItem In mPallet.PalletItems
  ''                If mPalletItem.ItemType = eSalesItemPartType.esiptLoose Then
  ''                  mLooseItem = mSalesOrderPhase.LooseItems.ItemFromKey(mPalletItem.ItemID)
  ''                  If mLooseItem IsNot Nothing Then
  ''                    If mDespatchedLooseDic.ContainsKey(mLooseItem.StockItemID) = False Then
  ''                      mDespatchedLooseDic.Add(mLooseItem.StockItemID, mPalletItem.Quantity)
  ''                    Else
  ''                      mDespatchedLooseDic.Item(mLooseItem.StockItemID) += mPalletItem.Quantity
  ''                    End If
  ''                  End If

  ''                End If
  ''              Next
  ''            End If
  ''          End If
  ''        End If
  ''      Next

  ''      For Each mDespatch In mSalesOrderPhase.Despatches
  ''        If mDespatch.InvoiceID <> 0 Then
  ''          mSomeInvoiced = True
  ''          mInvoice = mSalesOrderPhase.Invoices.ItemFromKey(mDespatch.InvoiceID)
  ''          If mInvoice IsNot Nothing Then
  ''            If mInvoice.DateInvoiced <= vEndDateTime Then
  ''              For Each mPallet In mSalesOrderPhase.Pallets.PalletsByDespatchID(mDespatch.DespatchID)
  ''                For Each mPalletItem As dmPalletItem In mPallet.PalletItems
  ''                  If mPalletItem.ItemType = eSalesItemPartType.esiptLoose Then
  ''                    mLooseItem = mSalesOrderPhase.LooseItems.ItemFromKey(mPalletItem.ItemID)
  ''                    If mLooseItem IsNot Nothing Then
  ''                      If mInvoicedLooseDic.ContainsKey(mLooseItem.StockItemID) = False Then
  ''                        mInvoicedLooseDic.Add(mLooseItem.StockItemID, mPalletItem.Quantity)
  ''                      Else
  ''                        mInvoicedLooseDic.Item(mLooseItem.StockItemID) += mPalletItem.Quantity
  ''                      End If
  ''                    End If

  ''                  End If
  ''                Next
  ''              Next
  ''            End If
  ''          End If
  ''        End If
  ''      Next


  ''      '// Load the stockitems that we need for this order
  ''      If mSomeDespatched Or mSomeInvoiced Then
  ''        mStockItems = GetStockItemsForSalesOrder(mSalesOrder)

  ''        mMatReqs = LoadPhaseDespatchedWIP(mSalesOrder, vSalesOrderPhaseID, mStockItems)

  ''        For Each mSIV As clsStockItemValuation In StockItemValuations
  ''          If mSIV.SalesOrderPhaseID = vSalesOrderPhaseID Then
  ''            If mMatReqs IsNot Nothing Then
  ''              mMatReq = mMatReqs.ItemFromStockItemID(mSIV.StockItemID)
  ''              If mMatReq IsNot Nothing Then
  ''                mSIV.DespatchedQty = mMatReq.Quantity
  ''              End If
  ''            End If
  ''            If mDespatchedLooseDic.ContainsKey(mSIV.StockItemID) Then mSIV.DespatchedQty = mDespatchedLooseDic.Item(mSIV.StockItemID)
  ''          End If
  ''        Next

  ''        mMatReqs = LoadPhaseInvoicedWIP(mSalesOrder, vSalesOrderPhaseID, mStockItems)

  ''        For Each mSIV As clsStockItemValuation In StockItemValuations
  ''          If mSIV.SalesOrderPhaseID = vSalesOrderPhaseID Then
  ''            If mMatReqs IsNot Nothing Then
  ''              mMatReq = mMatReqs.ItemFromStockItemID(mSIV.StockItemID)
  ''              If mMatReq IsNot Nothing Then
  ''                mSIV.InvoicedQty = mMatReq.Quantity
  ''              End If
  ''            End If
  ''            If mInvoicedLooseDic.ContainsKey(mSIV.StockItemID) Then mSIV.InvoicedQty = mInvoicedLooseDic.Item(mSIV.StockItemID)
  ''          End If
  ''        Next
  ''      End If

  ''    End If
  ''  End If

  ''End Sub

  ''Public Sub LoadCurrentStock()
  ''  'Dim mdso As dsoStock
  ''  'Dim mSIs As New colStockItems
  ''  'Dim mSILs As New colStockItemLocations
  ''  Dim mSIV As clsStockItemValuation
  ''  'Dim mDict As New Dictionary(Of Integer, clsStockItemValuation)

  ''  'StockItemValuations = New colStockItemValuations

  ''  'mdso = New dsoStock(pDBConn)
  ''  'mdso.LoadStockItems(mSIs, "IsManagedStock = 1")

  ''  'For Each mSI As dmStockItem In mSIs
  ''  '  mSIV = New clsStockItemValuation(mSI)
  ''  '  StockItemValuations.Add(mSIV)
  ''  '  mDict.Add(mSI.StockItemID, mSIV)
  ''  'Next

  ''  'mdso.LoadStockItemLocationsByWhere(mSILs, "Qty <> 0")

  ''  'For Each mSIL As dmStockItemLocation In mSILs
  ''  '  If mDict.ContainsKey(mSIL.StockItemID) Then mDict.Item(mSIL.StockItemID).StockQty += mSIL.Quantity
  ''  'Next


  ''  Dim mdsoStock As New dsoStock(pDBConn)
  ''  Dim mStockItemLocationInfos As colStockItemLocationInfos
  ''  Dim mWhere As String = String.Empty

  ''  mStockItemLocationInfos = New colStockItemLocationInfos
  ''  pStockItemValuations = New colStockItemValuations


  ''  ''mWhere = String.Format("Category IN({0},{1}) AND Qty <> 0", CByte(eStockItemCategory.Ironmongery), CByte(eStockItemCategory.IntumescentStripSeals))

  ''  mWhere = String.Format("Category IN({0},{1}) And Qty <> 0", CByte(eStockItemCategory.Ironmongery), CByte(eStockItemCategory.IntumescentStripSeals))
  ''  mdsoStock.LoadStockItemLocationInfosByWhere(mStockItemLocationInfos, mWhere)


  ''  For Each mSILocationInfo As clsStockItemLocationInfo In mStockItemLocationInfos
  ''    mSIV = New clsStockItemValuation(mSILocationInfo.StockItem)
  ''    If mSIV.StockItem.PricingUnit = eUnit.PerCostingQty AndAlso mSIV.StockItem.CostingQuantity > 0 Then
  ''      mSIV.StockQty = mSILocationInfo.Quantity / mSIV.StockItem.CostingQuantity
  ''    Else
  ''      mSIV.StockQty = mSILocationInfo.Quantity
  ''    End If

  ''    mSIV.SnapShotStockQty = mSILocationInfo.Quantity

  ''    StockItemValuations.Add(mSIV)
  ''  Next

  ''End Sub

  ''Public Sub LoadWIPStock(ByVal vDate As DateTime)
  ''  Dim mdso As dsoStock
  ''  Dim mDT As Data.DataTable
  ''  Dim mSIV As clsStockItemValuation
  ''  Dim mSIVExisting As clsStockItemValuation
  ''  Dim mSI As dmStockItem

  ''  mdso = New dsoStock(pDBConn)
  ''  mDT = mdso.GetSalesOrderPhaseMatReqsReceivedDT(vDate)

  ''  For Each mRow As Data.DataRow In mDT.Rows
  ''    ''If mCurMatReqID <> RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("MaterialRequirementID")) Then
  ''    mSI = New dmStockItem
  ''    mSI.StockItemID = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("StockItemID"))
  ''    mSI.StockCode = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("StockCode"))
  ''    mSI.Description = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("Description"))
  ''    mSI.Category = RTIS.CommonVB.clsGeneralA.DBValueToByte(mRow.Item("Category"))
  ''    mSI.ItemType = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("ItemType"))
  ''    mSI.SubItemType = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("SubItemType"))

  ''    mSIV = New clsStockItemValuation(mSI)
  ''    mSIV.OrderNo = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("OrderNo"))
  ''    mSIV.PhaseNo = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("PhaseNumber"))
  ''    mSIV.ProjectName = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("ProjectRef"))
  ''    mSIV.SalesOrderPhaseID = RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("SalesOrderPhaseID"))


  ''    '\\Try to find existing Item, If not add it in
  ''    mSIVExisting = pStockItemValuations.ItemFromStockItemIDLocationIDSOPhaseID(mSI.StockItemID, 0, mSIV.SalesOrderPhaseID)
  ''    If mSIVExisting Is Nothing Then
  ''      mSIV.ReceivedQty = RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("QtyReceived"))
  ''      pStockItemValuations.Add(mSIV)
  ''    Else
  ''      mSIVExisting.ReceivedQty = mSIVExisting.ReceivedQty + RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("QtyReceived"))
  ''    End If
  ''    ''Else
  ''    'Just add to the current receivedqty
  ''    ''End If
  ''    'add a history
  ''  Next

  ''  mDT = mdso.GetProductionBatchMatReqPickedDT(vDate)
  ''  For Each mRow As Data.DataRow In mDT.Rows
  ''    mSI = New dmStockItem
  ''    mSI.StockItemID = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("StockItemID"))
  ''    mSI.StockCode = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("StockCode"))
  ''    mSI.Description = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("Description"))
  ''    mSI.Category = RTIS.CommonVB.clsGeneralA.DBValueToByte(mRow.Item("Category"))
  ''    mSI.ItemType = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("ItemType"))
  ''    mSI.SubItemType = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("SubItemType"))

  ''    mSIV = New clsStockItemValuation(mSI)
  ''    mSIV.OrderNo = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("OrderNo"))
  ''    mSIV.PhaseNo = RTIS.CommonVB.clsGeneralA.DBValueToInteger(mRow.Item("PhaseNumber"))
  ''    mSIV.ProjectName = RTIS.CommonVB.clsGeneralA.DBValueToString(mRow.Item("ProjectRef"))
  ''    mSIV.SalesOrderPhaseID = RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("SalesOrderPhaseID"))


  ''    '\\Try to find existing Item, If not add it in
  ''    mSIVExisting = pStockItemValuations.ItemFromStockItemIDLocationIDSOPhaseID(mSI.StockItemID, 0, mSIV.SalesOrderPhaseID)
  ''    If mSIVExisting Is Nothing Then
  ''      mSIV.ReceivedQty = (-1 * RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("TranValue")))
  ''      pStockItemValuations.Add(mSIV)
  ''    Else
  ''      mSIVExisting.ReceivedQty = mSIVExisting.ReceivedQty + (-1 * RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("TranValue")))
  ''    End If

  ''  Next

  ''End Sub

  ''Public Sub ClearReceivedQtys()
  ''  For Each mSIV As clsStockItemValuation In pStockItemValuations
  ''    mSIV.ReceivedQty = 0
  ''  Next
  ''End Sub

  ''Public Function GetRowsForSheet(ByVal vStockTakeSheetID As Integer) As colStockItemValuations
  ''  Dim mValuations As New colStockItemValuations

  ''  Try

  ''    For Each mItem As clsStockItemValuation In pStockItemValuations

  ''      If mItem.StockCheckItem IsNot Nothing Then

  ''        If mItem.StockCheckItem.StockTakeSheetID = vStockTakeSheetID Then
  ''          mValuations.Add(mItem)
  ''        End If

  ''      End If

  ''    Next

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try

  ''  Return mValuations
  ''End Function

  ''Public Sub ClearInvoicedQtys()
  ''  For Each mSIV As clsStockItemValuation In pStockItemValuations
  ''    mSIV.GoodsInInvoicedQty = 0
  ''  Next
  ''End Sub

  ''Public Sub CreateWIPStockCheckItems()
  ''  Dim mStockCheckItem As dmStockCheckItem = Nothing
  ''  For Each mSIV As clsStockItemValuation In StockItemValuations
  ''    If mSIV.StockCheckItem Is Nothing Then
  ''      Select Case Mode
  ''        Case eMode.StockValuation
  ''          mStockCheckItem = pStockTake.StockCheckItems.ItemFromStockItemIDLocationIDPhaseID(mSIV.StockItemID, mSIV.LocationID, mSIV.SalesOrderPhaseID)
  ''        Case eMode.AdhocValuation
  ''          mStockCheckItem = Nothing
  ''      End Select
  ''      If mStockCheckItem Is Nothing Then
  ''        mStockCheckItem = New dmStockCheckItem
  ''        mStockCheckItem.LocationID = mSIV.LocationID
  ''        mStockCheckItem.StockItemID = mSIV.StockItemID
  ''        '  mStockCheckItem.SnapshotQty = mSIV.StockQty
  ''        mStockCheckItem.SalesOrderPhaseID = mSIV.SalesOrderPhaseID
  ''        Select Case Mode
  ''          Case eMode.StockValuation
  ''            mStockCheckItem.StockCheckID = pStockTake.StockCheckID
  ''            pStockTake.StockCheckItems.Add(mStockCheckItem)
  ''        End Select
  ''      End If
  ''      mSIV.StockCheckItem = mStockCheckItem
  ''      mSIV.IsCounted = True
  ''    End If
  ''  Next
  ''End Sub


  ''Public Function CommitStockCheck() As Integer
  ''  Dim mCount As Integer = 0

  ''  Try
  ''    Dim mdsoStock As New dsoStock(pDBConn)

  ''    For Each mSIV As clsStockItemValuation In StockItemValuations
  ''      If mSIV.IsCounted Then
  ''        Dim mStockItemLocations As New colStockItemLocations
  ''        Dim mStockItemLocation As dmStockItemLocation = Nothing

  ''        mdsoStock.LoadStockItemLocationsByWhere(mStockItemLocations, "StockItemID =" & mSIV.StockItemID & " And LocationID =" & mSIV.LocationID)

  ''        If mStockItemLocations.Count > 0 Then
  ''          mStockItemLocation = mStockItemLocations(0)
  ''        Else
  ''          mStockItemLocation = New dmStockItemLocation
  ''          mStockItemLocation.StockItemID = mSIV.StockItemID
  ''          mStockItemLocation.LocationID = 1 '// NEEDS CONSIDERING
  ''          mStockItemLocations.Add(mStockItemLocation)
  ''          mdsoStock.SaveStockItemLocations(mStockItemLocations)
  ''        End If

  ''        If mStockItemLocation IsNot Nothing Then
  ''          Dim mOk As Boolean = False

  ''          mOk = mdsoStock.StockCheckSetStockItemLocationQty(mStockItemLocation, mSIV.CountedQty, eDTMObjectType.StockTakeSheet, mSIV.StockCheckItem.StockTakeSheetID, pStockTake.StockCheckDate)

  ''          If mOk Then
  ''            mCount += 1
  ''          End If

  ''        End If

  ''      End If
  ''    Next

  ''    If mCount > 0 Then
  ''      pStockTake.DateCommitted = Now
  ''      SaveObject()
  ''    End If

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try

  ''  Return mCount
  ''End Function

  ''Public Sub AddToNextSheet()
  ''  Try
  ''    Dim mNewSheet As New dmStockTakeSheet
  ''    Dim mSelectedItems As New colStockItemValuations

  ''    mNewSheet.DateCreated = DateTime.Now
  ''    mNewSheet.CreatedBy = pDBConn.RTISUser.UserID
  ''    mNewSheet.SheetNo = pStockTake.StockTakeSheets.GetNextNumber

  ''    pStockTake.StockTakeSheets.Add(mNewSheet)

  ''    '// get all ids etc
  ''    SaveObject()

  ''    mSelectedItems = pStockItemValuations.GetSelectedItems

  ''    For Each mItem As clsStockItemValuation In mSelectedItems
  ''      mItem.StockCheckItem.StockTakeSheetID = mNewSheet.StockTakeSheetID
  ''    Next

  ''    '// commit items to sheet
  ''    SaveObject()

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try
  ''End Sub

  ''''Public Sub SetCountedQtyFromSnap(ByVal vStockItemValuations As colStockItemValuations)

  ''''  For Each mSIV As clsStockItemValuation In vStockItemValuations
  ''''    mSIV.CountedQty = mSIV.SnapshotQty
  ''''  Next

  ''''End Sub

  ''Public Sub SelectAll()
  ''  For Each mSIV As clsStockItemValuation In StockItemValuations
  ''    mSIV.TempSelected = True
  ''  Next
  ''End Sub

  ''Public Sub ClearSelection()
  ''  For Each mSIV As clsStockItemValuation In StockItemValuations
  ''    mSIV.TempSelected = False
  ''  Next
  ''End Sub
  ''Public Sub UpdateSnapQty()

  ''  Try
  ''    Dim mSIL As dmStockItemLocation
  ''    Dim mStockItemLocations As colStockItemLocations
  ''    Dim mdsoStock As New dsoStock(pDBConn)

  ''    For Each mSIV As clsStockItemValuation In StockItemValuations
  ''      'If mSIV.StockItemID > 98000 Then
  ''      '  MsgBox(mSIV.StockItemID)
  ''      'End If
  ''      mSIL = New dmStockItemLocation
  ''      mStockItemLocations = New colStockItemLocations
  ''      mdsoStock.LoadStockItemLocationsByWhere(mStockItemLocations, "StockItemID =" & mSIV.StockItemID & " And LocationID =" & mSIV.LocationID)

  ''      mSIV.SnapshotQty = 0
  ''      mSIV.SnapShotStockQty = 0


  ''      'If mSIV.StockItem.NotTracked = False Then

  ''      If mStockItemLocations.Count = 1 Then
  ''        mSIL = mStockItemLocations(0)
  ''        Dim mPreviousTransaction As dmStockItemTransactionLog = mdsoStock.GetLastTransactionBefore(pStockTake.StockCheckDate, mSIL.StockItemLocationID)


  ''        If mPreviousTransaction IsNot Nothing Then
  ''          mSIV.SnapshotQty = mPreviousTransaction.NewValue
  ''          mSIV.SnapShotStockQty = mPreviousTransaction.NewValue
  ''        End If
  ''      End If
  ''      ' End If

  ''    Next

  ''    pStockTake.DateSystemQty = DateTime.Now
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try

  ''End Sub

  ''Public Function CountItemsForSheet(ByVal vStockTakeSheetID As Integer) As Integer
  ''  Dim mCount As Integer = 0

  ''  For Each mItem As clsStockItemValuation In pStockItemValuations

  ''    If mItem.StockCheckItem IsNot Nothing Then

  ''      If mItem.StockCheckItem.StockTakeSheetID = vStockTakeSheetID Then
  ''        mCount += 1
  ''      End If

  ''    End If

  ''  Next

  ''  Return mCount
  ''End Function

  ''Public Sub SetRangeByStockCode(ByVal vRangeStockCodeStart As String, ByVal vRangeStockCodeEnd As String)

  ''  For Each mItem As clsStockItemValuation In StockItemValuations
  ''    If mItem.StockCode >= vRangeStockCodeStart AndAlso mItem.StockCode <= vRangeStockCodeEnd Then
  ''      mItem.IsCounted = True
  ''    End If
  ''  Next

  ''End Sub

  ''Public Sub SetIsCounted(ByVal vIsCounted As Boolean)

  ''  Try


  ''    For Each mItem As clsStockItemValuation In StockItemValuations
  ''      Dim mSheet As dmStockTakeSheet = pStockTake.StockTakeSheets.ItemFromKey(mItem.StockCheckItem.StockTakeSheetID)

  ''      If mSheet IsNot Nothing Then

  ''        If mSheet.DateProcessed = DateTime.MinValue Then
  ''          mItem.IsCounted = vIsCounted
  ''        End If

  ''      Else
  ''        mItem.IsCounted = vIsCounted
  ''      End If

  ''    Next


  ''  Catch ex As Exception

  ''  End Try

  ''End Sub

  ''Public Sub RemoveFromSheet()
  ''  Try

  ''    Dim mSelectedItems As New colStockItemValuations

  ''    mSelectedItems = pStockItemValuations.GetSelectedItems

  ''    For Each mItem As clsStockItemValuation In mSelectedItems
  ''      mItem.StockCheckItem.StockTakeSheetID = 0
  ''    Next

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try
  ''End Sub

  ''Public Sub RefreshGoodsInInvoicedQty(ByVal vEndDateTime As Date)

  ''  Dim mdso As dsoStock
  ''  Dim mDT As Data.DataTable
  ''  Dim mSIV As clsStockItemValuation

  ''  For Each mSIV In pStockItemValuations
  ''    mSIV.GoodsInInvoicedQty = 0
  ''  Next

  ''  mdso = New dsoStock(pDBConn)
  ''  mDT = mdso.GetSalesOrderPhaseMatReqsInvoicedDT(vEndDateTime)

  ''  For Each mRow As Data.DataRow In mDT.Rows

  ''    mSIV = StockItemValuations.ItemFromStockItemIDLocationIDSOPhaseID(clsGeneralA.DBValueToInteger(mRow.Item("StockItemID")), 0, clsGeneralA.DBValueToDecimal(mRow.Item("SalesOrderPhaseID")))

  ''    If mSIV IsNot Nothing Then
  ''      mSIV.GoodsInInvoicedQty = mSIV.GoodsInInvoicedQty + RTIS.CommonVB.clsGeneralA.DBValueToDecimal(mRow.Item("Quantity"))
  ''    End If

  ''  Next

  ''End Sub

  ''Public Sub AutoCreateSheets()
  ''  Try
  ''    Dim mCurrentBucket As Integer = 1
  ''    Dim mDictonary As New Dictionary(Of Integer, colStockItemValuations)
  ''    Dim mValuations As New colStockItemValuations

  ''    mValuations = pStockItemValuations.OrderByStockCode()

  ''    For Each mItem As clsStockItemValuation In mValuations
  ''      If mItem.TempSelected = True Then

  ''        If Not mDictonary.ContainsKey(mCurrentBucket) Then
  ''          mDictonary.Add(mCurrentBucket, New colStockItemValuations)
  ''        End If

  ''        mDictonary(mCurrentBucket).Add(mItem)

  ''        If mDictonary(mCurrentBucket).Count = 48 Then
  ''          mCurrentBucket += 1
  ''        End If
  ''      End If
  ''    Next

  ''    pStockTake.StockTakeSheets.Clear()

  ''    For Each mKeyValuePair As KeyValuePair(Of Integer, colStockItemValuations) In mDictonary
  ''      Dim mNewSheet As New dmStockTakeSheet

  ''      mNewSheet.DateCreated = DateTime.Now
  ''      mNewSheet.CreatedBy = pDBConn.RTISUser.UserID
  ''      mNewSheet.SheetNo = pStockTake.StockTakeSheets.GetNextNumber
  ''      mNewSheet.Description = "Sheet: " & mNewSheet.SheetNo.ToString("D3")

  ''      pStockTake.StockTakeSheets.Add(mNewSheet)

  ''      '// get all ids etc
  ''      SaveObject()

  ''      For Each mItem As clsStockItemValuation In mKeyValuePair.Value
  ''        mItem.StockCheckItem.StockTakeSheetID = mNewSheet.StockTakeSheetID
  ''      Next

  ''      '// commit items to sheet
  ''      SaveObject()
  ''    Next

  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
  ''  End Try
  ''End Sub

  ''Public Sub LoadSystemStockValuationHistory(ByVal vEndTimeDate As DateTime)
  ''  Dim mdso As New dsoStock(pDBConn)
  ''  Dim mQty As Decimal

  ''  Try
  ''    If pDBConn.Connect() Then
  ''      For Each mSIV As clsStockItemValuation In StockItemValuations
  ''        mSIV.StockItemValuationHistorys.Clear()

  ''        mQty = mSIV.SnapshotQty

  ''        mdso.LoadStockItemValueHistoryConnected(mSIV.StockItemValuationHistorys, mSIV.StockItem, mQty, mSIV.SalesOrderPhaseID, vEndTimeDate)

  ''        mSIV.SystemTotalValue = mSIV.StockItemValuationsTotal

  ''      Next
  ''    End If
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try

  ''End Sub

  ''Public Sub LoadCountedStockValuationHistory(ByVal vEndTimeDate As DateTime)
  ''  Dim mdso As New dsoStock(pDBConn)
  ''  Dim mQty As Decimal

  ''  Try
  ''    If pDBConn.Connect() Then
  ''      For Each mSIV As clsStockItemValuation In StockItemValuations
  ''        mSIV.StockItemValuationHistorys.Clear()

  ''        mQty = mSIV.CountedQty

  ''        mdso.LoadStockItemValueHistoryConnected(mSIV.StockItemValuationHistorys, mSIV.StockItem, mQty, mSIV.SalesOrderPhaseID, vEndTimeDate)

  ''        mSIV.CountedTotalValue = mSIV.StockItemValuationsTotal

  ''      Next
  ''    End If
  ''  Catch ex As Exception
  ''    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  ''  Finally
  ''    If pDBConn.IsConnected Then pDBConn.Disconnect()
  ''  End Try

  ''End Sub

End Class

