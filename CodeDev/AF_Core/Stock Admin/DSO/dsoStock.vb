Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoStock
  Private pDBConn As clsDBConnBase
  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function GetOrCreateStockItemLocation(ByVal vStockItemID As Integer, vLocationID As Integer) As dmStockItemLocation
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemLocation As dmStockItemLocation = Nothing

    LoadStockItemLocationsByWhere(mStockItemLocations, "StockItemID =" & vStockItemID & " AND LocationID =" & vLocationID)

    If mStockItemLocations.Count > 0 Then
      mStockItemLocation = mStockItemLocations(0)
    Else
      mStockItemLocation = New dmStockItemLocation
      mStockItemLocation.StockItemID = vStockItemID
      mStockItemLocation.LocationID = vLocationID
      mStockItemLocations.Add(mStockItemLocation)
      SaveStockItemLocations(mStockItemLocations)
    End If
    Return mStockItemLocation
  End Function

  Public Function LoadWoodPalletsDownByWhere(ByRef rWoodPallets As colWoodPallets, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean
    Dim mdtoWoodPallet As dtoWoodPallet
    Dim mdtoWoodPalletItem As dtoWoodPalletItem

    Try

      pDBConn.Connect()
      mdtoWoodPallet = New dtoWoodPallet(pDBConn)
      mRetVal = mdtoWoodPallet.LoadWoodPalletByWhere(rWoodPallets, vWhere)



      If rWoodPallets IsNot Nothing Then
        mdtoWoodPalletItem = New dtoWoodPalletItem(pDBConn)

        For Each mWoodPallet In rWoodPallets

          mRetVal = mdtoWoodPalletItem.LoadWoodPalletItemCollection(mWoodPallet.WoodPalletItems, mWoodPallet.WoodPalletID)

        Next




      End If
      pDBConn.Disconnect()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal

  End Function

  Public Sub LoadstockItemsByCategory(ByRef rStockItems As colStockItems, ByVal vWhere As String)
    Dim dtoStockItem As New dtoStockItem(pDBConn)

    Try
      If pDBConn.Connect() Then
        dtoStockItem.LoadStockItemCollectionByWhere(rStockItems, vWhere)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function LoadWoodPalletDown(ByRef rWoodPallet As dmWoodPallet, ByVal vWoodPalletID As Integer) As Boolean
    Dim mRetVal As Boolean
    Dim mdtoWoodPallet As dtoWoodPallet
    Dim mdtoWoodPalletItem As dtoWoodPalletItem

    Try

      pDBConn.Connect()
      mdtoWoodPallet = New dtoWoodPallet(pDBConn)
      mRetVal = mdtoWoodPallet.LoadWoodPallet(rWoodPallet, vWoodPalletID)

      If rWoodPallet IsNot Nothing Then
        mdtoWoodPalletItem = New dtoWoodPalletItem(pDBConn)

        mRetVal = mdtoWoodPalletItem.LoadWoodPalletItemCollection(rWoodPallet.WoodPalletItems, rWoodPallet.WoodPalletID)


      End If
      pDBConn.Disconnect()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal

  End Function



  Public Function SaveWoodPalletDown(ByRef rWoodPallet As dmWoodPallet) As Boolean
    Dim mRetVal As Boolean
    Dim mdtoWoodPallet As dtoWoodPallet
    Dim mdtoWoodPalletItem As dtoWoodPalletItem
    Dim mStockItem As dmStockItem
    Try

      pDBConn.Connect()

      If rWoodPallet IsNot Nothing Then

        mdtoWoodPallet = New dtoWoodPallet(pDBConn)

        rWoodPallet.Description = clsWoodPalletSharedFuncs.GetWoodPalletContentDescription(rWoodPallet.WoodPalletItems)
        clsWoodPalletSharedFuncs.GetNextWoodPalletRefConnected(rWoodPallet, pDBConn)

        rWoodPallet.TotalVolume = clsWoodPalletSharedFuncs.GetTotalBoardFeet(rWoodPallet)

        mRetVal = mdtoWoodPallet.SaveWoodPallet(rWoodPallet)

        mdtoWoodPalletItem = New dtoWoodPalletItem(pDBConn)

        mRetVal = mdtoWoodPalletItem.SaveWoodPalletItemCollection(rWoodPallet.WoodPalletItems, rWoodPallet.WoodPalletID)


      End If
      pDBConn.Disconnect()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal

  End Function

  Public Function GetPhaseMatReqPickedQtyConnected(ByVal vSalesOrderPhaseID As Integer, ByVal vStockItemID As Integer) As Decimal
    Dim mRetVal As Decimal = 0
    Dim mHT As New Hashtable
    Try
      pDBConn.Connect()
      'mSQL = String.Format("Select Sum(PickedQty) as TotalPicked from ProductionBatchMatReq PBMR Inner Join ProductionBatch PB on PBMR.ProductionBatchID = PB.ProductionBatchID Where SalesOrderPhaseID = {0} And StockItemID = {1}", vSalesOrderPhaseID, vStockItemID)
      'mRetVal = DBValueToDecimal(pDBConn.ExecuteScalar(mSQL))
      mHT.Add("@SalesOrderPhaseID", vSalesOrderPhaseID)
      mHT.Add("@StockItemID", vStockItemID)

      Dim mReader As IDataReader = pDBConn.LoadReaderSP("spPhaseMatReqPickedSum", mHT)
      If mReader.Read Then
        mRetVal = clsDBConnBase.DBReadDecimal(mReader, "TotalPicked")
      End If

      mReader.Close()
      mReader = Nothing
      pDBConn.Disconnect()
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    End Try
    Return mRetVal
  End Function

  Public Function SaveWoodPalletCollectionDown(ByRef rWoodPallets As colWoodPallets) As Boolean
    Dim mRetVal As Boolean
    Dim mdtoWoodPallet As dtoWoodPallet
    Dim mdtoWoodPalletItem As dtoWoodPalletItem

    Try

      pDBConn.Connect()
      mdtoWoodPallet = New dtoWoodPallet(pDBConn)
      mRetVal = mdtoWoodPallet.SaveWoodPalletCollection(rWoodPallets)

      If rWoodPallets IsNot Nothing Then
        For Each mWP In rWoodPallets
          mdtoWoodPalletItem = New dtoWoodPalletItem(pDBConn)

          mRetVal = mdtoWoodPalletItem.SaveWoodPalletItemCollection(mWP.WoodPalletItems, mWP.WoodPalletID)


        Next




      End If
      pDBConn.Disconnect()

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal

  End Function
  Public Function LoadStockItemProcessors(ByRef rStockItemProcessors As colStockItemProcessors, ByVal vWhere As String, ByVal vMode As dtoStockItemInfo.eMode) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoStockItemInfo


    Try

      pDBConn.Connect()
      mdto = New dtoStockItemInfo(pDBConn, vMode)
      mdto.LoadStockItemProcessorCollection(rStockItemProcessors, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function

  Public Function GetPickedMaterialRequirementByWorkOrderAndStockItemID(ByVal vWorkOrderID As Integer, ByVal vStockItemID As Integer) As clsMaterialRequirementInfo
    Dim mRetVal As clsMaterialRequirementInfo = Nothing
    Dim mdto As dtoMaterialRequirementInfo
    Dim mWoodMatReq As New clsMaterialRequirementInfo
    Dim mCollection As New colMaterialRequirementInfos

    Dim mWhere As String = ""

    Try

      pDBConn.Connect()
      mWhere = String.Format("ObjectID ={0} and StockItemID = {1}", vWorkOrderID, vStockItemID)
      mdto = New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.WoodMat)
      mdto.LoadWoodMatReqByWhere(mCollection, mWhere)

      If mCollection IsNot Nothing And mCollection.Count > 0 Then
        mWoodMatReq = mCollection(0)

        mRetVal = mWoodMatReq

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function LoadWoodPalletItemContentByWhere(ByRef rWoodPalletItemContents As colWoodPalletItemContents, ByVal vWhere As String) As Boolean
    Dim mRetVal As Boolean
    Dim mdto As New dtoWoodPalletItemContent(pDBConn)
    Try

      pDBConn.Connect()
      mRetVal = mdto.LoadWoodPalletContentInfoCollectionByWhere(rWoodPalletItemContents, vWhere)


    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function LoadWoodMaterialRequirementInfosByWhere(ByRef rWoodMatReq As colMaterialRequirementInfos, ByVal vWhere As String, ByVal vMode As dtoMaterialRequirementInfo.eMode) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoMaterialRequirementInfo


    Try

      pDBConn.Connect()
      mdto = New dtoMaterialRequirementInfo(pDBConn, vMode)
      mdto.LoadWoodMatReqByWhere(rWoodMatReq, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function

  Public Sub LoadStockItemsByWhere(ByRef rStockItems As colStockItems, ByVal vWhere As String)
    Dim mdto As dtoStockItem
    Try
      pDBConn.Connect()
      mdto = New dtoStockItem(pDBConn)
      mdto.LoadStockItemsByWhere(rStockItems, vWhere)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function GetStockItemByStockItemID(ByVal vStockItemID As Integer) As dmStockItem
    Dim mdto As dtoStockItem
    Dim mStockItem As New dmStockItem
    Try
      pDBConn.Connect()
      mdto = New dtoStockItem(pDBConn)
      mdto.LoadStockItem(mStockItem, vStockItemID)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mStockItem
  End Function

  Public Sub LoadStockItemByStockItemID(ByRef rStockItem As dmStockItem, ByVal vStockItemID As Integer)
    Dim mdto As dtoStockItem
    Try
      pDBConn.Connect()
      mdto = New dtoStockItem(pDBConn)
      mdto.LoadStockItem(rStockItem, vStockItemID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
  End Sub

  Public Function SaveStockItem(ByRef rStockItem As dmStockItem) As Boolean
    Dim mdto As dtoStockItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockItem(pDBConn)
      mOK = mdto.SaveStockItem(rStockItem)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function


  Public Function LoadWoodPalletItemInfosByWhere(ByRef rWoodPalletItemInfos As colWoodPalletItemInfos, ByVal vWhere As String) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoWoodPalletItemInfo


    Try

      pDBConn.Connect()
      mdto = New dtoWoodPalletItemInfo(pDBConn)
      mdto.LoadWoodPalletItemInfoCollectionByWhere(rWoodPalletItemInfos, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function


  Public Function LoadStockTakeDown(ByRef rStockTake As dmStockTake, ByVal vStockTakeID As Integer) As Boolean
    Dim mdto As dtoStockTake
    Dim mdtoSTI As dtoStockTakeItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockTake(pDBConn)
      mOK = mdto.LoadStockTake(rStockTake, vStockTakeID)
      mdtoSTI = New dtoStockTakeItem(pDBConn)
      If mOK Then mOK = mdtoSTI.LoadStockTakeItemCollection(rStockTake.StockTakeItems, rStockTake.StockTakeID)

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function


  Public Function SaveStockTakeDown(ByRef rStockTake As dmStockTake) As Boolean
    Dim mdto As dtoStockTake
    Dim mdtoSTI As dtoStockTakeItem
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockTake(pDBConn)
      mOK = mdto.SaveStockTake(rStockTake)
      mdtoSTI = New dtoStockTakeItem(pDBConn)
      If mOK Then mOK = mdtoSTI.SaveStockTakeItemCollection(rStockTake.StockTakeItems, rStockTake.StockTakeID)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function LoadStockItemLocationsByStockItemID(ByRef rStockItemLocations As colStockItemLocations, ByVal vStockItemID As Integer) As Boolean
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then

        mOK = mdtoSILocation.LoadStockItemLocationCollectionByStockItemID(rStockItemLocations, vStockItemID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetStockItemLocationByStockItemIDLocationID(ByVal vStockItemID As Integer, ByVal vLocationID As Integer) As dmStockItemLocation
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mRetVal As dmStockItemLocation = Nothing

    Try
      If pDBConn.Connect() Then
        mRetVal = mdtoSILocation.LoadStockItemLocationByStockItemIDLocationID(vStockItemID, vLocationID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal
  End Function

  Public Function SaveStockItemLocation(ByRef rStockItemLocation As dmStockItemLocation) As Boolean
    Dim mdto As dtoStockItemLocation
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mdto = New dtoStockItemLocation(pDBConn)
      mOK = mdto.SaveStockItemLocation(rStockItemLocation)
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetNextStockCodeSuffixNo(ByVal vStockCodeStem As String) As Integer
    Dim mRetVal As Integer

    Try

      pDBConn.Connect()
      mRetVal = GetNextStockCodeSuffixNoConnected(vStockCodeStem)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function GetNextStockCodeSuffixNoConnected(ByVal vStockCodeStem As String) As Integer
    Dim mReader As IDataReader
    Dim mSQL As String
    Dim mRetVal As Integer
    Dim mExistingCode As String
    Dim mLastDotPos As Integer
    Try


      mSQL = "Select Top 1 StockCode from StockItem where StockCode Like '" & vStockCodeStem & "%' Order By StockCode Desc"
      mReader = pDBConn.LoadReader(mSQL)
      If mReader.Read Then
        mExistingCode = RTIS.DataLayer.clsDBConnBase.DBReadString(mReader, "StockCode")
        mLastDotPos = mExistingCode.LastIndexOf(".")
        If mLastDotPos <> -1 And mExistingCode.Length >= mLastDotPos + 1 Then
          mRetVal = Val(mExistingCode.Substring(mLastDotPos + 1)) + 1
        Else
          '// invalid code
          mRetVal = -1
        End If
      Else
        mRetVal = 1
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mReader IsNot Nothing Then
        If mReader.IsClosed = False Then mReader.Close()
        mReader.Dispose()
        mReader = Nothing
      End If
    End Try
    Return mRetVal
  End Function

  Public Function LoadStockItemInfos(ByRef rStockItemInfos As colStockItemInfos, ByVal vWhere As String, ByVal vMode As dtoStockItemInfo.eMode) As Boolean

    Dim mRetVal As Boolean
    Dim mdto As dtoStockItemInfo


    Try

      pDBConn.Connect()
      mdto = New dtoStockItemInfo(pDBConn, vMode)
      mdto.LoadStockItemCollection(rStockItemInfos, vWhere)
      pDBConn.Disconnect()
      mRetVal = True
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mRetVal


  End Function

  Public Function LoadStockItemLocationsByWhere(ByVal vStockItemLocations As colStockItemLocations, ByVal vWhere As String) As Boolean
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    Try
      pDBConn.Connect()
      mOK = mdtoSILocation.LoadStockItemLocationCollectionByWhere(vStockItemLocations, vWhere)

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


    Return mOK
  End Function

  Public Function LoadWoodPalletItemsByStockItemIDLocationID(ByRef rWoodPalletItems As colWoodPalletItems, ByVal vStockItemID As Integer, ByVal vLocationID As Integer) As Boolean
    Dim mdtoWPI As New dtoWoodPalletItem(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        mOK = LoadWoodPalletItemsByStockItemIDLocationIDConnected(rWoodPalletItems, vStockItemID, vLocationID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try


    Return mOK
  End Function

  Public Function LoadWoodPalletItemsByStockItemIDLocationIDConnected(ByRef rWoodPalletItems As colWoodPalletItems, ByVal vStockItemID As Integer, ByVal vLocationID As Integer) As Boolean
    Dim mdtoWPI As New dtoWoodPalletItem(pDBConn)
    Dim mOK As Boolean

    Try
      mOK = mdtoWPI.LoadWoodPalletItemCollectionByStockItemIDLocationID(rWoodPalletItems, vStockItemID, vLocationID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    End Try

    Return mOK
  End Function

  Public Function SaveStockItemLocations(ByVal vSILocations As colStockItemLocations) As Boolean
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        mOK = mdtoSILocation.SaveStockItemLocationCollection(vSILocations)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function GetCurrentInventory(ByVal vStockItemID As Integer) As Decimal
    Dim mSQL As String
    Dim mRetVal As Decimal = 0
    Try
      pDBConn.Connect()
      mSQL = "Select Sum(Qty) from StockItemLocation Where StockItemID = " & vStockItemID
      mRetVal = pDBConn.ExecuteScalar(mSQL)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mRetVal
  End Function

  Public Function GetOrCreateStockItemLocationConnected(ByVal vStockItemID As Integer, vLocationID As Integer, ByVal vBatchID As Integer) As dmStockItemLocation
    Dim mStockItemLocations As New colStockItemLocations
    Dim mStockItemLocation As dmStockItemLocation = Nothing
    Dim mdtoSILocation As New dtoStockItemLocation(pDBConn)
    Dim mOK As Boolean

    mOK = mdtoSILocation.LoadStockItemLocationCollectionByWhere(mStockItemLocations, "StockItemID =" & vStockItemID & " AND LocationID =" & vLocationID & " AND BatchID =" & vBatchID)


    If mStockItemLocations.Count > 0 Then
      mStockItemLocation = mStockItemLocations(0)
    Else
      mStockItemLocation = New dmStockItemLocation
      mStockItemLocation.StockItemID = vStockItemID
      mStockItemLocation.LocationID = vLocationID

      ''mStockItemLocation.BatchID = vBatchID

      mStockItemLocations.Add(mStockItemLocation)
      mOK = mdtoSILocation.SaveStockItemLocationCollection(mStockItemLocations)
    End If
    Return mStockItemLocation
  End Function

  Public Function SaveWoodPalletItemCollection(ByRef rSourceWoodPalletItems As colWoodPalletItems, ByVal vWoodPalletID As Integer) As Boolean
    Dim mdtoWoodPalletItem As New dtoWoodPalletItem(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        mOK = mdtoWoodPalletItem.SaveWoodPalletItemCollection(rSourceWoodPalletItems, vWoodPalletID)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function SaveWoodPalletItem(ByRef rWoodPalletItem As dmWoodPalletItem) As Boolean
    Dim mdtoWoodPalletItem As New dtoWoodPalletItem(pDBConn)
    Dim mOK As Boolean

    Try
      If pDBConn.Connect() Then
        mOK = mdtoWoodPalletItem.SaveWoodPalletItem(rWoodPalletItem)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Sub LoadTempPallets(ByRef rTempPallets As colTempPallets, ByVal vWhere As String)
    Dim mdto As New dtoTempPallet(pDBConn)
    Try
      If pDBConn.Connect() Then
        mdto.LoadTempPalletCollectionByWhere(rTempPallets, vWhere)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try



  End Sub

  Public Sub UpdateStockItemAverageCost(ByVal vStockItemID As Integer, ByVal vReceivedQty As Decimal, ByVal vReceivedValue As Decimal, ByVal vStockItemTransactionLogID As Integer)
    Dim mExistingQty As Decimal
    Dim mCurrentAverageCost As Decimal
    Dim mNewAverageCost As Decimal
    Dim mNewTotalQty As Decimal

    Dim mSQL As String
    Dim mStockValuation As Decimal
    Try
      If pDBConn.Connect() Then
        '// The Qty has already been updated so the current total qty in stock item locations includes the recently arrived.
        mSQL = String.Format("Select Sum(Qty) as TotalQty From StockItemLocation Where StockItemID = {0}", vStockItemID)
        mNewTotalQty = pDBConn.ExecuteScalar(mSQL)
        mExistingQty = mNewTotalQty - vReceivedQty

        '// Retreive the current average cost
        mSQL = String.Format("Select IsNull(AverageCost,0) From StockItem Where StockItemID = {0}", vStockItemID)
        mCurrentAverageCost = pDBConn.ExecuteScalar(mSQL)

        mNewAverageCost = ((mExistingQty * mCurrentAverageCost) + vReceivedValue) / mNewTotalQty

        '// Set the new value
        mSQL = String.Format("Update StockItem Set AverageCost = {0} Where StockItemID = {1}", mNewAverageCost, vStockItemID)
        pDBConn.ExecuteNonQuery(mSQL)

        '//Update the Cost Valuation in the Transaction Log
        mStockValuation = mNewAverageCost * mNewTotalQty
        mStockValuation = Math.Round(mStockValuation, 4, MidpointRounding.AwayFromZero)
        mSQL = String.Format("Update StockItemTransactionLog Set StockValuation = {0} Where StockItemTransactionLogID = {1}", mStockValuation, vStockItemTransactionLogID)
        pDBConn.ExecuteNonQuery(mSQL)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally

    End Try
  End Sub




End Class
