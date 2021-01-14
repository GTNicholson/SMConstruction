Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class fccWorkOrderWoodProcess
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pWorkOrderID As Integer
  Private pWorkOrder As dmWorkOrder
  Private pSourceWoodPalletItem As colWoodPalletItems
  Private pWoodPallets As colWoodPallets
  Private pCurrentOutputWoodPallet As dmWoodPallet
  Private pOutputWoodPalletItem As colWoodPalletItems
  Private pSourceWorkOrderWoodType As Integer
  Private pWoodProcessOption As Integer
  Private pCurrentSourceWoodPallet As dmWoodPallet

  Private pSourceWoodPalletItemEditors As colWoodPalletItemEditors
  Private pOutPutWoodPalletItemEditors As colWoodPalletItemEditors
  Private pWorkOrderTargetWoodType As Integer

  Public Property OutPutWoodPalletItemEditors As colWoodPalletItemEditors
    Get
      Return pOutPutWoodPalletItemEditors
    End Get
    Set(value As colWoodPalletItemEditors)
      pOutPutWoodPalletItemEditors = value
    End Set
  End Property

  Public Property SourceWoodPalletItemEditors As colWoodPalletItemEditors
    Get
      Return pSourceWoodPalletItemEditors
    End Get
    Set(value As colWoodPalletItemEditors)
      pSourceWoodPalletItemEditors = value
    End Set
  End Property
  Public Property CurrentSourceWoodPallet As dmWoodPallet
    Get
      Return pCurrentSourceWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pCurrentSourceWoodPallet = value
    End Set
  End Property
  Public Property CurrentOutputWoodPallet As dmWoodPallet
    Get
      Return pCurrentOutputWoodPallet
    End Get
    Set(value As dmWoodPallet)
      pCurrentOutputWoodPallet = value
    End Set
  End Property
  Public Property CurrentWoodWorkOrder As dmWorkOrder
    Get
      Return pWorkOrder

    End Get
    Set(value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property WoodPallets As colWoodPallets
    Get
      Return pWoodPallets
    End Get
    Set(value As colWoodPallets)
      pWoodPallets = value
    End Set
  End Property

  Public Property DBConn As clsDBConnBase
    Get
      Return pDBConn

    End Get
    Set(value As clsDBConnBase)
      pDBConn = value
    End Set
  End Property


  Public Property SourceWoodPalletItem() As colWoodPalletItems
    Get
      Return pSourceWoodPalletItem
    End Get
    Set(value As colWoodPalletItems)
      pSourceWoodPalletItem = value
    End Set
  End Property


  Public Property OutputWoodPalletItem() As colWoodPalletItems
    Get
      Return pOutputWoodPalletItem
    End Get
    Set(value As colWoodPalletItems)
      pOutputWoodPalletItem = value
    End Set
  End Property

  Public Property WorkOrderTargetWoodType As Integer
    Get
      Return pWorkOrderTargetWoodType
    End Get
    Set(value As Integer)
      pWorkOrderTargetWoodType = value
    End Set
  End Property

  Public Property WorkOrderSourceWoodType As Integer
    Get
      Return pSourceWorkOrderWoodType
    End Get
    Set(value As Integer)
      pSourceWorkOrderWoodType = value
    End Set
  End Property
  Public Property WoodProcessOption As Integer
    Get
      Return pWoodProcessOption
    End Get
    Set(value As Integer)
      pWoodProcessOption = value
    End Set
  End Property

  Public Property WorkOrderID As Integer
    Get
      Return pWorkOrderID
    End Get
    Set(value As Integer)
      pWorkOrderID = value
    End Set
  End Property

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal, ByVal vWorkOrderID As Integer, ByVal vSourceType As Integer, ByVal vTargetType As Integer, ByVal vWoodProcessOption As Integer)
    pDBConn = rDBConn
    pRTISGlobal = rRTISGlobal
    pWorkOrderID = vWorkOrderID
    pSourceWorkOrderWoodType = vSourceType
    pWorkOrderTargetWoodType = vTargetType
    pSourceWoodPalletItem = New colWoodPalletItems
    pWoodPallets = New colWoodPallets
    pCurrentOutputWoodPallet = New dmWoodPallet
    pOutputWoodPalletItem = New colWoodPalletItems
    pWoodProcessOption = vWoodProcessOption
  End Sub


  Public Sub LoadObject()
    Dim mdso As dsoSales



    mdso = New dsoSales(pDBConn)

    If pWorkOrderID = 0 Then
      '// if it is new work order it will be internal - Sales Order Work Orders will be created from the salesorder form
      pWorkOrder = clsWorkOrderHandler.CreateInternalWorkOrder(eProductType.WoodWorkOrder)
      pWorkOrder.WorkOrderWoodType = pSourceWorkOrderWoodType
      pWorkOrder.WorkOrderTargetWoodType = pWorkOrderTargetWoodType
      pWorkOrder.isInternal = True
      pWorkOrder.WorkOrderProcessOption = pWoodProcessOption
      pWorkOrder.PlannedStartDate = Now
    Else
      If pWorkOrder Is Nothing Then '//Not already loaded
        pWorkOrder = New dmWorkOrder

        mdso.LoadWorkOrderDown(pWorkOrder, pWorkOrderID)

        LoadSourceWoodPallet()
        LoadOtputWoodPallet()
      End If

    End If
  End Sub

  Public Sub LoadSourceWoodPallet()
    Dim mdsoWodoPalletItem As New dsoStock(pDBConn)
    Dim mWoodPallet As New dmWoodPallet

    For Each mSourceWoodPallet As dmSourcePallet In pWorkOrder.SourcePallets
      mdsoWodoPalletItem.LoadWoodPalletDown(mWoodPallet, mSourceWoodPallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        For Each mWoodPalletItem As dmWoodPalletItem In mWoodPallet.WoodPalletItems
          SourceWoodPalletItem.Add(mWoodPalletItem)

        Next
      End If
    Next

  End Sub

  Public Sub LoadOtputWoodPallet()
    Dim mdsoWodoPalletItem As New dsoStock(pDBConn)
    Dim mWoodPallet As New dmWoodPallet

    For Each mOutputPallet As dmOutputPallet In pWorkOrder.OutputPallets
      mdsoWodoPalletItem.LoadWoodPalletDown(mWoodPallet, mOutputPallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        For Each mWoodPalletItem As dmWoodPalletItem In mWoodPallet.WoodPalletItems
          OutputWoodPalletItem.Add(mWoodPalletItem)

        Next
      End If
    Next
  End Sub

  Public Function IsDirty() As Boolean
    Dim mRetVal As Boolean = False
    If pWorkOrder.IsAnyDirty Then mRetVal = True
    Return mRetVal
  End Function

  Public Function ValidateObject() As RTIS.CommonVB.clsValWarn
    Dim mRetVal As New clsValWarn
    mRetVal.ValOk = True
    mRetVal.HasWarning = False
    Return mRetVal
  End Function

  Public Function SaveObjects() As Boolean
    Dim mRetVal As Boolean
    Dim mdso As dsoSales
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mWoodPallets As colWoodPallets
    mdso = New dsoSales(pDBConn)

    If pWorkOrder.WorkOrderNo = "" Or pWorkOrder.Description = "" Then


      Select Case pWorkOrder.WorkOrderWoodType
        Case eStockItemTypeTimberWood.Aserrado
        Case eStockItemTypeTimberWood.Rollo
          pWorkOrder.WorkOrderNo = "OT-Rol-" & mdsoGeneral.getNextTally(eTallyIDs.RollWoodOT)

        Case eStockItemTypeTimberWood.MAS
          mWoodPallets = New colWoodPallets
          mWoodPallets = GetWoodPalletSource()
          pWorkOrder.WorkOrderNo = "OT-MAS-" & mdsoGeneral.getNextTally(eTallyIDs.MASWoodOT)
          pWorkOrder.Description = "OT de MAS. Bultos :" & clsWoodPalletSharedFuncs.GetWoodPalletsDescription(mWoodPallets)

        Case eStockItemTypeTimberWood.Clasificado
          pWorkOrder.WorkOrderNo = "OT-CLA-" & mdsoGeneral.getNextTally(eTallyIDs.ClassifiedWoodOT)

        Case eStockItemTypeTimberWood.MAV
          pWorkOrder.WorkOrderNo = "OT-MAV-" & mdsoGeneral.getNextTally(eTallyIDs.MAVWoodOT)
          mWoodPallets = New colWoodPallets
          mWoodPallets = GetWoodPalletSource()
          pWorkOrder.Description = "OT de MAV. Bultos :" & clsWoodPalletSharedFuncs.GetWoodPalletsDescription(mWoodPallets)

      End Select
    End If

    mdso.SaveWorkOrderDown(pWorkOrder)

    mRetVal = True
    Return mRetVal
  End Function

  Public Sub ClearObjects()

    'Me.MainObject = Nothing

  End Sub



  Public Sub SaveWoodPalletDown(ByRef rWoodPallet As dmWoodPallet)
    Dim mdso As New dsoStock(pDBConn)

    mdso.SaveWoodPalletDown(rWoodPallet)

  End Sub

  Public Function GetWoodPalletSource() As colWoodPallets
    Dim mdso As New dsoStock(pDBConn)
    Dim mWoodPallet As dmWoodPallet
    Dim mWoodPallets As New colWoodPallets

    For Each mSourcePallet As dmSourcePallet In pWorkOrder.SourcePallets
      mWoodPallet = New dmWoodPallet

      mdso.LoadWoodPalletDown(mWoodPallet, mSourcePallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        mWoodPallets.Add(mWoodPallet)
      End If
    Next

    Return mWoodPallets
  End Function



  Public Function LoadWoodPalletByWoodPalletID(mWoodPalletID As Integer) As dmWoodPallet
    Dim mdso As New dsoStock(pDBConn)
    Dim mWoodPallets As New colWoodPallets
    Dim mRetVal As dmWoodPallet = Nothing
    Dim mWhere As String
    mWhere = "WoodPalletID = " & mWoodPalletID
    mdso.LoadWoodPalletDownByWhere(mWoodPallets, mWhere)

    If mWoodPallets IsNot Nothing And mWoodPallets.Count > 0 Then
      mRetVal = mWoodPallets(0)
    End If
    Return mRetVal
  End Function

  Public Sub CreateWoodPallet(ByVal vPalletType As Integer)
    Dim mOutputPallet As New dmOutputPallet

    CreateNewWoodPallet(pWorkOrder.WorkOrderTargetWoodType)
    SetCurrentOutputWoodPallet(pWoodPallets.Last)

    If pCurrentOutputWoodPallet IsNot Nothing Then

      mOutputPallet.WoodPalletID = pCurrentOutputWoodPallet.WoodPalletID
      mOutputPallet.WorkOrderID = pWorkOrder.WorkOrderID

      pWorkOrder.OutputPallets.Add(mOutputPallet)
    End If
    SaveObjects()
  End Sub
  Public Sub SetCurrentOutputWoodPallet(ByRef rWoodPallet As dmWoodPallet)
    If rWoodPallet Is Nothing Then
      pCurrentOutputWoodPallet = New dmWoodPallet
    Else

      pCurrentOutputWoodPallet = rWoodPallet

    End If

  End Sub

  Public Sub SetCurrentSourceWoodPallet(ByRef rWoodPallet As dmWoodPallet)
    If rWoodPallet Is Nothing Then
      pCurrentSourceWoodPallet = New dmWoodPallet
    Else

      pCurrentSourceWoodPallet = rWoodPallet

    End If

  End Sub


  Public Sub CreateNewWoodPallet(ByVal vPalletType As Integer)
    Dim mWoodPallet As New dmWoodPallet



    mWoodPallet.PalletType = vPalletType


    mWoodPallet.CreatedDate = Now
    mWoodPallet.LocationID = eLocations.AgroForestal
    pWoodPallets.Add(mWoodPallet)
    clsWoodPalletSharedFuncs.GetNextWoodPalletRef(mWoodPallet, pDBConn)
    SaveWoodPalletDown(mWoodPallet)


  End Sub

  Public Function getWoodPalletFromWoodPalletID(ByVal vWoodPalletID As Integer) As dmWoodPallet
    Dim mRetVal As New dmWoodPallet
    Dim mdso As New dsoStock(pDBConn)


    mdso.LoadWoodPalletDown(mRetVal, vWoodPalletID)
    Return mRetVal

  End Function



  Public Sub DeleteWoodPallets(ByRef rWoodPallet As dmWoodPallet)
    Dim mPos As Integer
    Dim mNewPos As Integer = -1
    If rWoodPallet IsNot Nothing Then
      'Find the position of the item we are going to delete
      mPos = 0
      For Each mWoodPallet As dmWoodPallet In pWoodPallets
        If mWoodPallet Is rWoodPallet Then
          mNewPos = mPos 'This will be the next one in the list a we will take out this position
          Exit For
        End If
        mPos += 1
      Next

      DeleteWoodPallet(rWoodPallet)

      If pWoodPallets.Count = 0 Then
        SetCurrentOutputWoodPallet(Nothing)
      ElseIf mNewPos <= pWoodPallets.Count - 1 Then
        SetCurrentOutputWoodPallet(pWoodPallets(mNewPos))
      Else
        SetCurrentOutputWoodPallet(pWoodPallets.Last)
      End If
    End If
  End Sub

  Public Sub DeleteWoodPallet(ByRef rWoodPallet As dmWoodPallet)
    pWoodPallets.Remove(rWoodPallet)
  End Sub



  Public Sub ProcessDryTransaction(ByRef rSourcePallets As colSourcePallets, ByVal vPalletType As Integer, ByVal vPrevLocationID As Integer)
    Dim mSICollection As colStockItems
    Dim mWoodPallets As New colWoodPallets
    Dim mWoodPallet As dmWoodPallet
    Dim mNewOutputPallet As dmOutputPallet
    Dim mSISpecies As dmStockItem
    Dim mWoodPalletItems As New colWoodPalletItems
    Dim mNewWoodPalletItem As dmWoodPalletItem
    Dim mNewWoodPallet As dmWoodPallet
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mSpecieID As Integer
    mSICollection = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemCollection


    For Each mSourcePallet As dmSourcePallet In rSourcePallets
      mWoodPallet = New dmWoodPallet
      mWoodPallet = getWoodPalletFromWoodPalletID(mSourcePallet.WoodPalletID)

      If mWoodPallet IsNot Nothing Then
        mWoodPallets.Add(mWoodPallet)
      End If
    Next




    For Each mTempWoodPallet As dmWoodPallet In mWoodPallets

      mNewWoodPallet = New dmWoodPallet
      mNewWoodPallet.CreatedDate = Now
      mNewWoodPallet.LocationID = eLocations.AgroForestal
      mNewWoodPallet.PalletType = vPalletType
      clsWoodPalletSharedFuncs.GetNextWoodPalletRef(mNewWoodPallet, pDBConn)
      mdsoStock.SaveWoodPalletDown(mNewWoodPallet)

      mWoodPalletItems = New colWoodPalletItems

      For Each mTempWoodPalletItem As dmWoodPalletItem In mTempWoodPallet.WoodPalletItems
        mSpecieID = mdsoStock.GetStockItemByStockItemID(mTempWoodPalletItem.StockItemID).Species

        mSISpecies = mSICollection.ItemFromSpeciesAndThickness(mSpecieID, mTempWoodPalletItem.Thickness, vPalletType)

        If mSISpecies Is Nothing Then ''Create the SI with the specific thickness and Species
          mSISpecies = New dmStockItem
          CreateNewStockItem(mSISpecies, vPalletType, mTempWoodPalletItem.Thickness, mSpecieID)

        End If

        mNewWoodPalletItem = New dmWoodPalletItem
        mNewWoodPalletItem.StockItemID = mSISpecies.StockItemID
        mNewWoodPalletItem.StockCode = mSISpecies.StockCode
        mNewWoodPalletItem.Description = mSISpecies.Description
        mNewWoodPalletItem.Length = mTempWoodPalletItem.Length
        mNewWoodPalletItem.Quantity = mTempWoodPalletItem.Quantity
        mNewWoodPalletItem.Thickness = mTempWoodPalletItem.Thickness
        mNewWoodPalletItem.Width = mTempWoodPalletItem.Width
        mNewWoodPalletItem.WoodPalletID = mNewWoodPallet.WoodPalletID

        mWoodPalletItems.Add(mNewWoodPalletItem)





      Next

      mNewOutputPallet = New dmOutputPallet
      mNewOutputPallet.WoodPalletID = mNewWoodPallet.WoodPalletID
      mNewOutputPallet.WorkOrderID = pWorkOrder.WorkOrderID
      pWorkOrder.OutputPallets.Add(mNewOutputPallet)

      mNewWoodPallet.WoodPalletItems = mWoodPalletItems
      mdsoStock.SaveWoodPalletDown(mNewWoodPallet)


    Next




  End Sub

  Public Sub CreateSingleWoodOutputTransaction(ByVal vOutputStockItemID As Integer, ByVal vVolume As Decimal, ByVal vTargetLocationID As Integer, ByVal vWoodPallet As dmWoodPallet)
    Dim mSIL As New dmStockItemLocation
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions
    Dim mCost As Decimal
    Dim mdsoCostBook As dsoCostBook
    Dim mVolume As Decimal = 0

    mdsoTran = New dsoStockTransactions(pDBConn)
    mdsoCostBook = New dsoCostBook(pDBConn)
    mdsoStock = New dsoStock(pDBConn)

    mVolume = vVolume
    If mVolume <> 0 Then

      If vOutputStockItemID <> 0 Then
        '//Set the same Cost. Check what to do
        mCost = mdsoCostBook.GetDefaultCostBookValueByStockItemIDUnconnected(vOutputStockItemID)
        mSIL = mdsoStock.GetOrCreateStockItemLocation(vOutputStockItemID, vTargetLocationID)
      Else
        mSIL = Nothing
      End If
      mdsoTran.CreateGeneralOutPutWoodPalletTransaction(mSIL, mVolume, Now, eCurrency.Dollar, mCost, 1, vWoodPallet)

    End If


  End Sub

  Public Sub CreateSingleWoodSourceTransaction(ByVal vSourceStockItemID As Integer, ByVal vVolume As Decimal, ByVal vSourceLocationID As Integer, ByVal vWoodPallet As dmWoodPallet)
    Dim mSIL As New dmStockItemLocation
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions
    Dim mCost As Decimal
    Dim mdsoCostBook As dsoCostBook
    Dim mVolume As Decimal = 0

    mdsoTran = New dsoStockTransactions(pDBConn)
    mdsoCostBook = New dsoCostBook(pDBConn)

    mVolume = vVolume
    mdsoStock = New dsoStock(pDBConn)

    If mVolume <> 0 Then

      If vSourceStockItemID <> 0 Then
        '//Set the same Cost. Check what to do
        mCost = mdsoCostBook.GetDefaultCostBookValueByStockItemIDUnconnected(vSourceStockItemID)
        mSIL = mdsoStock.GetOrCreateStockItemLocation(vSourceStockItemID, vSourceLocationID)
      Else
        mSIL = Nothing
      End If
      mdsoTran.CreateGeneralSourceWoodPalletTransaction(eTransactionType.Movement, mSIL, mVolume, Now, eCurrency.Dollar, mCost, 1, vWoodPallet, eObjectType.WoodPallet)


    End If


  End Sub

  Public Sub CreateSourceTransaction(ByVal vSourcePallets As colSourcePallets)
    Dim mdsoStockTran As New dsoStockTransactions(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mSIL As New dmStockItemLocation
    Dim mWoodPallet As dmWoodPallet
    Dim mdsoTran As dsoStockTransactions


    Try
      mdsoTran = New dsoStockTransactions(pDBConn)

      For Each mSourcePallet In vSourcePallets

        mWoodPallet = New dmWoodPallet
        mdsoStock.LoadWoodPalletDown(mWoodPallet, mSourcePallet.WoodPalletID)
        If mWoodPallet IsNot Nothing Then

          mdsoTran.CreatePrevSourceWoodPalletTransaction(mWoodPallet, mWoodPallet.LocationID, New dmSalesOrder, Now, eCurrency.Dollar, 1)
          UpdateWoodPalletItemQuantityUsed(mWoodPallet)
          mWoodPallet.IsComplete = True
          mdsoStock.SaveWoodPalletDown(mWoodPallet)
        End If
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Private Sub UpdateWoodPalletItemQuantityUsed(ByRef rWoodPallet As dmWoodPallet)
    Dim mWPItems As New colWoodPalletItems


    For Each mWPI In rWoodPallet.WoodPalletItems
      mWPI.QuantityUsed = mWPI.Quantity

    Next


  End Sub

  Public Sub CreateOutputTransaction(ByVal vOutputPallets As colOutputPallets)
    Dim mdsoStockTran As New dsoStockTransactions(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mSIL As New dmStockItemLocation
    Dim mWoodPallet As dmWoodPallet
    Dim mdsoTran As dsoStockTransactions

    Try
      mdsoTran = New dsoStockTransactions(pDBConn)

      For Each mOutputPallet In vOutputPallets

        mWoodPallet = New dmWoodPallet
        mdsoStock.LoadWoodPalletDown(mWoodPallet, mOutputPallet.WoodPalletID)
        If mWoodPallet IsNot Nothing Then

          mdsoTran.CreatePositiveTransaction(eTransactionType.Movement, mWoodPallet, mWoodPallet.LocationID, New dmSalesOrder, Now, eCurrency.Dollar, 1)


        End If
      Next

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub CreateNewStockItem(ByRef rSISpecies As dmStockItem, ByVal vItemType As Integer, ByVal vThickness As Decimal, ByVal vSpecies As Integer)
    Dim mdsoStockitem As New dsoStock(pDBConn)
    Dim mSuffix As Integer
    Dim mDSO As New dsoStock(pDBConn)
    rSISpecies.Category = eStockItemCategory.Timber
    rSISpecies.ItemType = vItemType
    rSISpecies.Species = vSpecies
    rSISpecies.Thickness = vThickness
    rSISpecies.StockCode = clsStockItemSharedFuncs.GetStockCodeStem(rSISpecies)

    mSuffix = mDSO.GetNextStockCodeSuffixNo(rSISpecies.StockCode)
    rSISpecies.StockCode = rSISpecies.StockCode & mSuffix.ToString("000")

    rSISpecies.Description = GetProposedDescription(rSISpecies)

    mdsoStockitem.SaveStockItem(rSISpecies)
    pRTISGlobal.StockItemRegistry.StockItemsDict.Add(rSISpecies.StockItemID, rSISpecies)
  End Sub



  Public Function GetProposedDescription(ByRef rSISpecies As dmStockItem) As String

    Dim mDescription As String
    Dim mRetVal As String = ""
    Dim mInteger As Integer
    Dim mDecimal As Decimal
    mDescription = "Madera " & clsStockItemSharedFuncs.GetStockItemTypeDescription(rSISpecies)

    mDescription &= " de " & clsStockItemSharedFuncs.GetSpeciesDescription(rSISpecies).Trim

    If rSISpecies.ItemType = eStockItemTypeTimberWood.Arbol Or rSISpecies.ItemType = eStockItemTypeTimberWood.Rollo Then
      ''decide what to do with this description
    Else

      mInteger = Int(rSISpecies.Thickness)
      mDecimal = (rSISpecies.Thickness - mInteger) * 10
      If mDecimal = 0 Then
        mDescription &= String.Format(" de {0}", mInteger) & "''"

      Else
        mDescription &= String.Format(" de {0}_{1}", mInteger, mDecimal.ToString("n0")) & "''"

      End If

    End If



    Return mDescription
  End Function

  Public Sub RefreshSourceWoodPalletItemEditors(ByVal vCurrentSourceWoodPallet As dmWoodPallet)
    Dim mWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mStockItem As dmStockItem
    pSourceWoodPalletItemEditors = New colWoodPalletItemEditors

    For Each mWPI As dmWoodPalletItem In vCurrentSourceWoodPallet.WoodPalletItems
      mWoodPalletItemEditor = New clsWoodPalletItemEditor
      mWoodPalletItemEditor.WoodPalletItem = mWPI
      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPI.StockItemID)
      mWoodPalletItemEditor.StockItem = mStockItem
      pSourceWoodPalletItemEditors.Add(mWoodPalletItemEditor)
    Next
  End Sub

  Public Sub RefreshOutPutWoodPalletItemEditors(ByVal vCurrentSourceWoodPallet As dmWoodPallet)
    Dim mWoodPalletItemEditor As clsWoodPalletItemEditor
    Dim mStockItem As dmStockItem
    pOutPutWoodPalletItemEditors = New colWoodPalletItemEditors

    For Each mWPI As dmWoodPalletItem In vCurrentSourceWoodPallet.WoodPalletItems
      mWoodPalletItemEditor = New clsWoodPalletItemEditor
      mWoodPalletItemEditor.WoodPalletItem = mWPI
      mStockItem = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mWPI.StockItemID)
      mWoodPalletItemEditor.StockItem = mStockItem
      pOutPutWoodPalletItemEditors.Add(mWoodPalletItemEditor)
    Next
  End Sub

  Public Sub ProcessSourceQuantity(ByVal vSourceLocation As Integer, ByVal vWoodPalletID As Integer)
    Try
      Dim mdsoTran As dsoStockTransactions
      Dim mdsoStock As dsoStock
      Dim mSIL As New dmStockItemLocation
      Dim mSICollection As colStockItems
      Dim mUpdatedWoodPallets As New colWoodPallets
      Dim mSISpecies As dmStockItem
      Dim mOutPutWoodPalletItems As New colWoodPalletItems
      Dim mSourceWoodPalletItems As New colWoodPalletItems
      Dim mNewWoodPalletItem As dmWoodPalletItem
      Dim mNewWoodPallet As dmWoodPallet
      Dim mSpecieID As Integer
      Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
      Dim mSI As dmStockItem

      mNewWoodPallet = Nothing
      mSICollection = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemCollection


      mdsoTran = New dsoStockTransactions(pDBConn)

      mdsoStock = New dsoStock(pDBConn)


      For Each mWPIE As clsWoodPalletItemEditor In pSourceWoodPalletItemEditors
        If mWPIE.ToProcessQty <> 0 Then

          If mWPIE.StockItem.StockItemID <> 0 Then
            mSpecieID = mdsoStock.GetStockItemByStockItemID(mWPIE.StockItem.StockItemID).Species


            mSISpecies = mSICollection.ItemFromSpeciesAndThickness(mSpecieID, mWPIE.WoodPalletItem.Thickness, pCurrentOutputWoodPallet.PalletType)

            If mSISpecies Is Nothing Then ''Create the SI with the specific thickness and Species
              mSISpecies = New dmStockItem
              CreateNewStockItem(mSISpecies, pCurrentOutputWoodPallet.PalletType, mWPIE.WoodPalletItem.Thickness, mSpecieID)

            End If


            mNewWoodPalletItem = New dmWoodPalletItem
            mNewWoodPalletItem.StockItemID = mSISpecies.StockItemID
            mNewWoodPalletItem.StockCode = mSISpecies.StockCode
            mNewWoodPalletItem.Description = mSISpecies.Description
            mNewWoodPalletItem.Length = mWPIE.WoodPalletItem.Length
            mNewWoodPalletItem.Quantity = mWPIE.ToProcessQty
            mNewWoodPalletItem.Thickness = mWPIE.WoodPalletItem.Thickness
            mNewWoodPalletItem.Width = mWPIE.WoodPalletItem.Width
            mNewWoodPalletItem.WoodPalletID = pCurrentOutputWoodPallet.WoodPalletID

            mOutPutWoodPalletItems.Add(mNewWoodPalletItem)

            'mWPIE.WoodPalletItem.Quantity = (mWPIE.WoodPalletItem.Quantity - mWPIE.ToProcessQty)
            mWPIE.WoodPalletItem.QuantityUsed += mWPIE.ToProcessQty

            mdsoStock.SaveWoodPalletItem(mWPIE.WoodPalletItem)

          Else
            mSIL = Nothing
          End If
          mWPIE.ToProcessQty = 0
        End If

        ''Update Quantities for the current WoodPalletSourceItem




      Next

      SaveObjects()


      CurrentOutputWoodPallet.WoodPalletItems = mOutPutWoodPalletItems
      mdsoStock.SaveWoodPalletDown(CurrentOutputWoodPallet)

      ''//Create transactions for the Source WoodPallets
      mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(pCurrentSourceWoodPallet)

      For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)

        If mSI IsNot Nothing Then

          CreateSingleWoodSourceTransaction(mKVP.Key, mKVP.Value, pCurrentSourceWoodPallet.LocationID, pCurrentSourceWoodPallet)
        End If
      Next

      ''//Create transactions for the Output WoodPallets
      mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(CurrentOutputWoodPallet)

      For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)

        If mSI IsNot Nothing Then

          CreateSingleWoodOutputTransaction(mKVP.Key, mKVP.Value, CurrentOutputWoodPallet.LocationID, CurrentOutputWoodPallet)
        End If
      Next




    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub ProcessSourceAserrado(ByVal vLocationID As Integer, ByVal vWoodPalletID As Integer)

    Dim mdsoStock As dsoStock
    Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
    Dim mTempWoodPalletItem As New dmWoodPalletItem
    Dim mTempWoodPallet As dmWoodPallet = Nothing
    Dim mSI As dmStockItem


    If SourceWoodPalletItemEditors IsNot Nothing Then

      mdsoStock = New dsoStock(pDBConn)
      mTempWoodPallet = pCurrentSourceWoodPallet.Clone
      mTempWoodPallet.WoodPalletItems.Clear()

      For Each mWPIE As clsWoodPalletItemEditor In SourceWoodPalletItemEditors

        If mWPIE.ToProcessQty <> 0 Then
          mTempWoodPalletItem = mWPIE.WoodPalletItem.Clone

          mWPIE.WoodPalletItem.Quantity = mWPIE.WoodPalletItem.Quantity - mWPIE.ToProcessQty
          mWPIE.WoodPalletItem.QuantityUsed = mWPIE.WoodPalletItem.QuantityUsed + mWPIE.ToProcessQty

          ''//Collection to be sent in the transaction
          mTempWoodPalletItem.Quantity = mWPIE.ToProcessQty
          mTempWoodPallet.WoodPalletItems.Add(mTempWoodPalletItem)

          mdsoStock.SaveWoodPalletItem(mWPIE.WoodPalletItem)

        End If


      Next

    End If


    ''//Create transactions for the Source WoodPallets
    If mTempWoodPallet IsNot Nothing Then
      mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(mTempWoodPallet)

      For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)

        If mSI IsNot Nothing Then

          CreateSingleWoodSourceTransaction(mKVP.Key, mKVP.Value, pCurrentSourceWoodPallet.LocationID, pCurrentSourceWoodPallet)
        End If
      Next
    End If


  End Sub

  Public Sub ProcessOutpuAserrio(ByVal vLocationID As Integer, woodPalletID As Integer)


    Dim mCurrentQty As Decimal
    Dim mTempWoodPallet As dmWoodPallet
    Dim mTempWoodPalletItems As New colWoodPalletItems
    Dim mTempWoodPalletItem As dmWoodPalletItem
    Dim mToProcQtyBoardFeet As Decimal

    Try
      mTempWoodPallet = New dmWoodPallet


      mTempWoodPallet.WoodPalletID = pCurrentOutputWoodPallet.WoodPalletID
      mTempWoodPallet.PalletRef = pCurrentOutputWoodPallet.PalletRef

      For Each mWPIE As clsWoodPalletItemEditor In pOutPutWoodPalletItemEditors

        If mWPIE.ToProcessQty <> 0 Then
          mTempWoodPalletItem = New dmWoodPalletItem

          Select Case mWPIE.StockItem.ItemType
            Case eStockItemTypeTimberWood.Rollo, eStockItemTypeTimberWood.Arbol
              mToProcQtyBoardFeet = clsWoodPalletSharedFuncs.M3ToBoardFeet(mWPIE.ToProcessQty)
            Case Else
              mToProcQtyBoardFeet = mWPIE.ToProcessQty
          End Select

          mCurrentQty = pCurrentOutputWoodPallet.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity
          mTempWoodPalletItem.Quantity = mToProcQtyBoardFeet
          pCurrentOutputWoodPallet.WoodPalletItems.ItemFromKey(mWPIE.WoodPalletItem.WoodPalletItemID).Quantity = mCurrentQty + mToProcQtyBoardFeet

          mTempWoodPalletItem.StockItemID = mWPIE.StockItem.StockItemID
          mTempWoodPalletItem.Thickness = mWPIE.StockItem.Thickness
          mTempWoodPalletItem.Width = mWPIE.WoodPalletItem.Width
          mTempWoodPalletItem.Length = mWPIE.WoodPalletItem.Length

          mTempWoodPallet.WoodPalletItems.Add(mTempWoodPalletItem)
        End If
        mWPIE.ToProcessQty = 0

      Next

      SaveObjects()


      If mTempWoodPallet IsNot Nothing Then
        If mTempWoodPallet.WoodPalletItems.Count > 0 Then
          CreateAmendmentWoodPalletTransaction(pCurrentOutputWoodPallet.LocationID, mTempWoodPallet)
        End If
      End If


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub

  Public Sub CreateAmendmentWoodPalletTransaction(ByVal vSourceLocationID As Integer, ByVal vWoodPallet As dmWoodPallet)
    Dim mSIL As New dmStockItemLocation
    Dim mdsoStock As dsoStock
    Dim mdsoTran As dsoStockTransactions

    Dim mdsoCostBook As dsoCostBook


    mdsoTran = New dsoStockTransactions(pDBConn)
    mdsoCostBook = New dsoCostBook(pDBConn)


    mdsoStock = New dsoStock(pDBConn)

    mdsoTran.CreatePositiveTransaction(eTransactionType.WoodAmendment, vWoodPallet, vSourceLocationID, New dmSalesOrder, Now, eCurrency.Dollar, 1)




  End Sub
End Class
