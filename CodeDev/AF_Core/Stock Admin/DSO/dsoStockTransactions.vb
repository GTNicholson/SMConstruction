Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoStockTransactions
  Private pDBConn As clsDBConnBase
  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function StockTakeSetStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vNewValue As Decimal, ByVal vRefObjectType As eObjectType, ByVal vRefObjectID As Integer, ByVal vTransDate As DateTime) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog

    Dim mAdjustmentQty As Decimal
    Dim mNewStockLevel As Decimal

    Try

      If vStockitemLocation IsNot Nothing Then

        pDBConn.Connect()

        pDBConn.ConnectionBeginTrans()

        '// Get the previous Transaction
        mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID, 0)
        If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

        mAdjustmentQty = vNewValue - mPrevValue

        '// Get any stock check after the insert date
        mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vStockitemLocation.StockItemLocationID)

        '// Get transactions after this date that need to have their prev and new changed
        If mSubsequentStockCheckTran IsNot Nothing Then
          mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vStockitemLocation.StockItemLocationID)
        Else
          mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vStockitemLocation.StockItemLocationID)
        End If

        mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionStockCheck(vNewValue, mPrevValue, eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, pDBConn.RTISUser.UserID, "", vRefObjectType, vRefObjectID)
        mNewStockLevel = vNewValue

        For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
          Select Case mTran.TransactionType
            Case eTransactionType.StockCheck, eTransactionType.Amendment
              '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
              mTran.PrevValue += mAdjustmentQty
            Case Else
              mTran.PrevValue += mAdjustmentQty
              mTran.NewValue += mAdjustmentQty
              mNewStockLevel = mTran.NewValue
          End Select
        Next

        If mSubsequentStockCheckTran Is Nothing Then
          If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & vStockitemLocation.StockItemLocationID) > 0 Then
          Else
            mOK = False
          End If
        Else
          '//Change the PrevValue of the Stock Check Transaction
          mSubsequentStockCheckTran.PrevValue += mAdjustmentQty
          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
        End If

        If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)

        If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally

      If pDBConn.IsConnected Then
        If mOK Then
          pDBConn.ConnectionCommitTrans()
        Else
          pDBConn.ConnectionRollBackTrans()
        End If

        pDBConn.Disconnect()
      End If
    End Try

    Return mOK
  End Function


  Private Function GetFirstStockCheckTransactionAfterConnected(ByVal vDateTime As DateTime, vID As Integer) As dmStockItemTransactionLog
    Dim mdto As dtoStockItemTransactionLog
    Dim mWhere As String
    Dim mSITLs As New colStockItemTransactionLogs
    Dim mRetVal As dmStockItemTransactionLog = Nothing

    mdto = New dtoStockItemTransactionLog(pDBConn)
    mWhere = String.Format("ObjectType = {0} AND ObjectID IN ({1})", CByte(eObjectType.StockItemLocation), vID)
    mWhere = mWhere & String.Format(" And TransactionType in ({0},{1})", CInt(eTransactionType.StockCheck), CInt(eTransactionType.Amendment))
    mWhere = mWhere & String.Format(" And TransactionDate > '{0}'", vDateTime.ToString("yyyyMMdd HH:mm:ss"))
    mdto.LoadStockItemTransactionLogTOP1ByWhere(mSITLs, mWhere, False)

    If mSITLs.Count <> 0 Then
      mRetVal = mSITLs(0)
    End If
    Return mRetVal
  End Function

  Public Function GetLastTransactionBeforeConnected(ByVal vDateTime As DateTime, vID As Integer, vExcludeID As Integer) As dmStockItemTransactionLog
    Dim mdto As dtoStockItemTransactionLog
    Dim mWhere As String
    Dim mSITLs As New colStockItemTransactionLogs
    Dim mRetVal As dmStockItemTransactionLog = Nothing

    mdto = New dtoStockItemTransactionLog(pDBConn)
    mWhere = String.Format("ObjectType = {0} AND ObjectID IN ({1})", CByte(eObjectType.StockItemLocation), vID)
    mWhere = mWhere & String.Format(" And TransactionDate <= '{0}'", vDateTime.ToString("yyyyMMdd HH:mm:ss:fff"))
    mWhere = mWhere & String.Format(" And StockItemTransactionLogID <> {0}", vExcludeID)
    mdto.LoadStockItemTransactionLogTOP1ByWhere(mSITLs, mWhere, True)

    If mSITLs.Count <> 0 Then
      mRetVal = mSITLs(0)
    End If
    Return mRetVal
  End Function


  Private Function GetTransctionsBetweenExcludingConnected(ByVal vStartDateTime As DateTime, ByVal vEndDateTime As DateTime, vID As Integer) As colStockItemTransactionLogs
    Dim mdto As dtoStockItemTransactionLog
    Dim mWhere As String
    Dim mRetVal As New colStockItemTransactionLogs

    mdto = New dtoStockItemTransactionLog(pDBConn)
    mWhere = String.Format("ObjectType = {0} AND ObjectID IN ({1})", CByte(eObjectType.StockItemLocation), vID)
    mWhere = mWhere & String.Format(" And TransactionDate > '{0}'", vStartDateTime.ToString("yyyyMMdd HH:mm:ss"))
    mWhere = mWhere & String.Format(" And TransactionDate < '{0}'", vEndDateTime.ToString("yyyyMMdd HH:mm:ss"))
    mdto.LoadStockItemTransactionLogCollectionByWhere(mRetVal, mWhere)

    Return mRetVal
  End Function


  Public Function AmendmentSetStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vNewQty As Decimal, ByVal vRefObjectType As eObjectType, ByVal vRefObjectID As Integer, ByVal vTransDate As DateTime, ByRef rAmmendmentLog As dmStockItemLocationAmendmentLog, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mdtoStockItemLocationAmendmentLog As New dtoStockItemLocationAmendmentLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog

    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog

    Dim mAdjustmentQty As Decimal
    Dim mNewStockLevel As Decimal

    Try

      If vStockitemLocation IsNot Nothing Then

        pDBConn.Connect()

        pDBConn.ConnectionBeginTrans()

        '// Get the previous Transaction
        mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID, 0)
        If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

        mAdjustmentQty = vNewQty - mPrevValue

        '// Get any stock check after the insert date
        mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vStockitemLocation.StockItemLocationID)

        '// Get transactions after this date that need to have their prev and new changed
        If mSubsequentStockCheckTran IsNot Nothing Then
          mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vStockitemLocation.StockItemLocationID)
        Else
          mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vStockitemLocation.StockItemLocationID)
        End If

        '//Save the ammentmentlog first to get an ID
        mOK = mdtoStockItemLocationAmendmentLog.SaveStockItemLocationAmendmentLog(rAmmendmentLog)

        mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionSet(mPrevValue, vNewQty, eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, eTransactionType.Amendment, pDBConn.RTISUser.UserID, "", vRefObjectType, rAmmendmentLog.StockItemLocationAmendmentLogID, vDefaultCurrency, vUnitCost, vExchangeRate)

        mNewStockLevel = vNewQty

        For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
          Select Case mTran.TransactionType
            Case eTransactionType.StockCheck, eTransactionType.Amendment
              '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
              mTran.PrevValue += mAdjustmentQty
            Case Else
              mTran.PrevValue += mAdjustmentQty
              mTran.NewValue += mAdjustmentQty
              mNewStockLevel = mTran.NewValue
          End Select
        Next

        If mSubsequentStockCheckTran Is Nothing Then
          If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty = " & mNewStockLevel & " WHERE StockItemLocationID =" & vStockitemLocation.StockItemLocationID) > 0 Then
          Else
            mOK = False
          End If
        Else
          '//Change the PrevValue of the Stock Check Transaction
          mSubsequentStockCheckTran.PrevValue += mAdjustmentQty
          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
        End If

        If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)

        If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)


      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally

      If pDBConn.IsConnected Then
        If mOK Then
          pDBConn.ConnectionCommitTrans()
        Else
          pDBConn.ConnectionRollBackTrans()
        End If

        pDBConn.Disconnect()
      End If
    End Try

    Return mOK
  End Function

  Public Function UpdateDeliveryStockItemLocationQty(ByVal vStockItemID As Integer, ByVal vLocationID As Integer, ByVal vRecievedQty As Decimal, ByVal vPOItemRecievedValue As Decimal, ByVal vPackQuantity As Decimal, ByVal vDeliveryItem As dmPODeliveryItem, ByVal vTransDate As DateTime, ByVal vPOItemAllocation As dmPurchaseOrderItemAllocation, ByVal vItemRef As String, ByVal vCreateTimberPack As Boolean, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, vExchangeRate As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog

    Dim mStockItem As dmStockItem
    Dim mdtoStockItem As dtoStockItem
    Dim mdtoPODI As dtoPODeliveryItem
    Dim mdsoStock As dsoStock


    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal

    Dim mSIL As dmStockItemLocation
    Dim mSILBatchID As Integer = 0
    '' Dim mTimberPack As dmTimberPack

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()

      mStockItem = New dmStockItem
      mdtoStockItem = New dtoStockItem(pDBConn)
      mdtoStockItem.LoadStockItem(mStockItem, vStockItemID)

      mdsoStock = New dsoStock(pDBConn)
      ''If vCreateTimberPack = True Then
      ''  mTimberPack = mdsoStock.CreateTimberPackConnected(vDeliveryItem.PODeliveryID, mStockItem.Species, vRecievedQty, mStockItem.Thickness, mStockItem.StockItemID, vItemRef)
      ''  mSILBatchID = mTimberPack.TimberPackID
      ''Else
      ''  mSILBatchID = 0
      ''End If

      '// get or create the stockitemlocation
      mSIL = mdsoStock.GetOrCreateStockItemLocationConnected(vStockItemID, vLocationID, mSILBatchID)

      If vDeliveryItem IsNot Nothing AndAlso mSIL IsNot Nothing Then

        If vRecievedQty <> 0 Then

          Dim mItemQuantity As Decimal = vRecievedQty

          '//First make sure the delivery item has been persisted
          If vDeliveryItem.PODeliveryItemID = 0 Then
            mdtoPODI = New dtoPODeliveryItem(pDBConn)
            mdtoPODI.SavePODeliveryItem(vDeliveryItem)
          End If

          mStockItem = New dmStockItem
          mdtoStockItem = New dtoStockItem(pDBConn)
          mdtoStockItem.LoadStockItem(mStockItem, vStockItemID)

          If vPackQuantity > 0 Then
            mItemQuantity = mItemQuantity * vPackQuantity
          End If

          '// Get the previous Transaction
          mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mSIL.StockItemLocationID, 0)
          If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

          '// Get any stock check after the insert date
          mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vLocationID)

          '// Get transactions after this date that need to have their prev and new changed
          If mSubsequentStockCheckTran IsNot Nothing Then
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vLocationID)
          Else
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vLocationID)
          End If

          mSILTranLog = mSIL.QtyValueTracker.CreateTransactionAdjust(mPrevValue, mItemQuantity, eObjectType.StockItemLocation, mSIL.StockItemLocationID, mSILBatchID, vTransDate, eTransactionType.GoodsIn, pDBConn.RTISUser.UserID, "", eObjectType.PODeliveryItem, vDeliveryItem.PODeliveryItemID, mSILBatchID, vDefaultCurrency, vUnitCost, vExchangeRate)

          mNewStockLevel = mPrevValue + mItemQuantity



          For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
            Select Case mTran.TransactionType
              Case eTransactionType.StockCheck, eTransactionType.Amendment
                '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                mTran.PrevValue += mItemQuantity
              Case Else
                mTran.PrevValue += mItemQuantity
                mTran.NewValue += mItemQuantity
                mNewStockLevel = mTran.NewValue
            End Select
          Next

          If mSubsequentStockCheckTran Is Nothing Then
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & mSIL.StockItemLocationID) > 0 Then
            Else
              mOK = False
            End If
          Else
            '//Change the PrevValue of the Stock Check Transaction
            mSubsequentStockCheckTran.PrevValue += mItemQuantity
            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
          End If

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

          '// podeliveryitem qty via sql statement.
          If mOK Then If pDBConn.ExecuteCommand("UPDATE dbo.PODeliveryItem SET QtyReceived=" & vDeliveryItem.QtyReceived + vRecievedQty & " WHERE PODeliveryItemID =" & vDeliveryItem.PODeliveryItemID) > 0 Then mOK = True
          '// Update the POCO allocation
          If mOK Then If pDBConn.ExecuteCommand("UPDATE dbo.PurchaseOrderItemAllocation SET ReceivedQty=" & vPOItemAllocation.ReceivedQty + vRecievedQty & " WHERE PurchaseOrderItemAllocationID =" & vPOItemAllocation.PurchaseOrderItemAllocationID) > 0 Then mOK = True

          If mOK Then
            vDeliveryItem.SetQtyReceived(vDeliveryItem.QtyReceived + vRecievedQty)
            vPOItemAllocation.SetReceivedQty(vPOItemAllocation.ReceivedQty + vRecievedQty)
            '// If it is not Timber category then update the Average Cost of the Stock Item
            Select Case mStockItem.Category
              Case eStockItemCategory.Timber
              Case Else

                ''//Update AverageCost in Cordobas currency
                If vDefaultCurrency = eCurrency.Dollar Then

                  vPOItemRecievedValue = vPOItemRecievedValue * vExchangeRate

                End If
                mdsoStock.UpdateStockItemAverageCost(mStockItem.StockItemID, vRecievedQty, vPOItemRecievedValue)

            End Select
          End If


        End If
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK

  End Function


  Public Sub CreateGeneralAmendmentWoodPalletTransaction(ByVal vStockItemID As Integer, ByVal vLocationID As Byte, ByVal vTransactionType As eTransactionType, ByVal vTranQty As Decimal, ByVal vAdjustDate As DateTime, ByVal vNotes As String, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal)
    Dim mdsoStockTran As New dsoStockTransactions(pDBConn)
    Dim mdsoStock As New dsoStock(pDBConn)
    Dim mStockItemLocation As dmStockItemLocation

    Try

      mStockItemLocation = mdsoStock.GetOrCreateStockItemLocation(vStockItemID, vLocationID)

      If mStockItemLocation IsNot Nothing Then
        Dim mLocationAmendment As New dmStockItemLocationAmendmentLog

        With mLocationAmendment
          .SystemDate = DateTime.Now
          .AmendmentDate = vAdjustDate
          .ChangeDetails = vNotes
          .UserID = pDBConn.RTISUser.UserID
          .StockItemLocationID = mStockItemLocation.StockItemLocationID
        End With

        ''If mdsoStock.SaveStockItemLocationAmendmentLog(mLocationAmendment) Then
        Select Case vTransactionType
          Case eTransactionType.Adjustment
            mdsoStockTran.AdjustmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, eCurrency.Dollar, vUnitCost, vExchangeRate)
          Case eTransactionType.Amendment, eTransactionType.WoodAmendment
            mdsoStockTran.AmendmentSetStockItemLocationQty(mStockItemLocation, vTranQty, eObjectType.StockItemAmmendmentLog, mLocationAmendment.StockItemLocationAmendmentLogID, vAdjustDate, mLocationAmendment, eCurrency.Dollar, vUnitCost, vExchangeRate)
        End Select

      End If

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try
  End Sub


  Public Function CreateGeneralOutPutWoodPalletTransaction(ByVal vStockitemLocation As dmStockItemLocation, ByVal vPickedQty As Decimal, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal, ByVal vWoodPallet As dmWoodPallet) As Boolean

    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoSales
    Dim mProductID As Integer

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()



      If vPickedQty <> 0 Then
        If vStockitemLocation IsNot Nothing Then
          mTranType = eTransactionType.Movement

          '// Get the previous Transaction
          mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID, 0)
          If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

          '// Get any stock check after the insert date
          mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vStockitemLocation.StockItemLocationID)

          '// Get transactions after this date that need to have their prev and new changed
          If mSubsequentStockCheckTran IsNot Nothing Then
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vStockitemLocation.StockItemLocationID)
          Else
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vStockitemLocation.StockItemLocationID)
          End If

          mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (vPickedQty), eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, vStockitemLocation.LocationID, vTransDate, mTranType, pDBConn.RTISUser.UserID, vWoodPallet.PalletRef, eObjectType.WoodPallet, vWoodPallet.WoodPalletID, vWoodPallet.WoodPalletID, vDefaultCurrency, vUnitCost, vExchangeRate)


          mNewStockLevel = mPrevValue + vPickedQty

          For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
            Select Case mTran.TransactionType
              Case eTransactionType.StockCheck, eTransactionType.Amendment
                '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                mTran.PrevValue += vPickedQty
              Case Else
                mTran.PrevValue += vPickedQty
                mTran.NewValue += vPickedQty
                mNewStockLevel = mTran.NewValue
            End Select
          Next

          If mSubsequentStockCheckTran Is Nothing Then
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & vStockitemLocation.StockItemLocationID) > 0 Then
            Else
              mOK = False
            End If
          Else
            '//Change the PrevValue of the Stock Check Transaction
            mSubsequentStockCheckTran.PrevValue += vPickedQty
            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
          End If

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
          If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & vStockitemLocation.StockItemID) > 0 Then
          Else
            mOK = False
          End If

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

        End If


      End If


    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function CreateGeneralSourceWoodPalletTransaction(ByVal vTransactionType As eTransactionType, ByVal vStockitemLocation As dmStockItemLocation, ByVal vPickedQty As Decimal, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vExchangeRate As Decimal, ByVal vWoodPallet As dmWoodPallet, ByVal vObjectType As eObjectType) As Boolean

    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoStock
    Dim mSI As dmStockItem
    Dim mStockItemLocation As dmStockItemLocation
    Dim mMonetaryValue As Decimal
    Dim mUnitCost As Decimal
    Dim mdsoCosting As New dsoCostBook(pDBConn)

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()



      If vPickedQty <> 0 Then
        If vStockitemLocation IsNot Nothing Then
          mTranType = vTransactionType

          mPrevValue = 0
          '// Get current cost - this should probably be outside here - think through with John
          mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(vStockitemLocation.StockItemID)
          If mSI IsNot Nothing Then
            mUnitCost = mdsoCosting.GetDefaultCostBookValueByStockItemIDConnected(mSI.StockItemID) 'mSI.StdCost


            '// Get the previous Transaction
            mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID, 0)
            If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

            '// Get any stock check after the insert date
            mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vStockitemLocation.StockItemLocationID)

            '// Get transactions after this date that need to have their prev and new changed
            If mSubsequentStockCheckTran IsNot Nothing Then
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vStockitemLocation.StockItemLocationID)
            Else
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vStockitemLocation.StockItemLocationID)
            End If

            mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (vPickedQty * -1), eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, vStockitemLocation.LocationID, vTransDate, mTranType, pDBConn.RTISUser.UserID, vWoodPallet.PalletRef, vObjectType, vWoodPallet.WoodPalletID, vWoodPallet.WoodPalletID, vDefaultCurrency, mUnitCost, vExchangeRate)


            mNewStockLevel = mPrevValue - vPickedQty

            For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
              Select Case mTran.TransactionType
                Case eTransactionType.StockCheck, eTransactionType.Amendment, eTransactionType.WoodAmendment
                  '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                  mTran.PrevValue -= vPickedQty
                Case Else
                  mTran.PrevValue -= vPickedQty
                  mTran.NewValue -= vPickedQty
                  mNewStockLevel = mTran.NewValue
              End Select
            Next

            '// Update the current Monetary Value at this location
            mMonetaryValue = GetStockItemLocationMonetaryValue(mSI, vStockitemLocation)

            If mSubsequentStockCheckTran Is Nothing Then
              If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " ,MonetaryValue = " & mMonetaryValue & " WHERE StockItemLocationID =" & vStockitemLocation.StockItemLocationID) > 0 Then
              Else
                mOK = False
              End If
            Else
              '//Change the PrevValue of the Stock Check Transaction
              mSubsequentStockCheckTran.PrevValue -= vPickedQty
              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & vStockitemLocation.StockItemID) > 0 Then
            Else
              mOK = False
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

          End If


        End If
      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function UpdateWoodPalletItemTransactionQty(ByVal vStockItemID As Integer, ByVal vLocationID As Integer, ByVal vItemQuantity As Decimal, ByVal vPackQuantity As Decimal, ByVal vWoodPalletItem As dmWoodPalletItem, ByVal vTransDate As DateTime, ByVal vUnitCost As Decimal, vExchangeRate As Decimal, ByVal vMatReq As clsMaterialRequirementInfo, ByVal vToProcessQty As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog

    Dim mStockItem As dmStockItem
    Dim mdtoStockItem As dtoStockItem
    Dim mdsoStock As dsoStock


    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal

    Dim mSIL As dmStockItemLocation
    Dim mSILBatchID As Integer = 0
    Dim mBoardFeet As Decimal = 0
    '' Dim mTimberPack As dmTimberPack

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()

      mStockItem = New dmStockItem
      mdtoStockItem = New dtoStockItem(pDBConn)
      mdtoStockItem.LoadStockItem(mStockItem, vStockItemID)

      mdsoStock = New dsoStock(pDBConn)
      ''If vCreateTimberPack = True Then
      ''  mTimberPack = mdsoStock.CreateTimberPackConnected(vDeliveryItem.PODeliveryID, mStockItem.Species, vRecievedQty, mStockItem.Thickness, mStockItem.StockItemID, vItemRef)
      ''  mSILBatchID = mTimberPack.TimberPackID
      ''Else
      ''  mSILBatchID = 0
      ''End If

      '// get or create the stockitemlocation
      mSIL = mdsoStock.GetOrCreateStockItemLocationConnected(vStockItemID, vLocationID, mSILBatchID)

      If vWoodPalletItem IsNot Nothing AndAlso mSIL IsNot Nothing Then

        If vItemQuantity <> 0 Then

          Dim mItemQuantity As Decimal = vItemQuantity



          mStockItem = New dmStockItem
          mdtoStockItem = New dtoStockItem(pDBConn)
          mdtoStockItem.LoadStockItem(mStockItem, vStockItemID)

          If vPackQuantity > 0 Then
            mItemQuantity = mItemQuantity * vPackQuantity
          End If

          '// Get the previous Transaction
          mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mSIL.StockItemLocationID, 0)
          If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

          '// Get any stock check after the insert date
          mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vLocationID)

          '// Get transactions after this date that need to have their prev and new changed
          If mSubsequentStockCheckTran IsNot Nothing Then
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vLocationID)
          Else
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vLocationID)
          End If

          ''//Get the right PiesTablares for the woodpalletitem


          mSILTranLog = mSIL.QtyValueTracker.CreateTransactionAdjust(mPrevValue, mItemQuantity, eObjectType.StockItemLocation, mSIL.StockItemLocationID, mSILBatchID, vTransDate, eTransactionType.Pick, pDBConn.RTISUser.UserID, vWoodPalletItem.WoodPalletID, eObjectType.WoodPallet, vWoodPalletItem.WoodPalletItemID, mSILBatchID, eCurrency.Dollar, vUnitCost, vExchangeRate)

          mNewStockLevel = mPrevValue + mItemQuantity



          For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
            Select Case mTran.TransactionType
              Case eTransactionType.StockCheck, eTransactionType.Amendment
                '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                mTran.PrevValue += mItemQuantity
              Case Else
                mTran.PrevValue += mItemQuantity
                mTran.NewValue += mItemQuantity
                mNewStockLevel = mTran.NewValue
            End Select
          Next

          If mSubsequentStockCheckTran Is Nothing Then
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & mSIL.StockItemLocationID) > 0 Then
            Else
              mOK = False
            End If
          Else
            '//Change the PrevValue of the Stock Check Transaction
            mSubsequentStockCheckTran.PrevValue += mItemQuantity
            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
          End If

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

          '// podeliveryitem qty via sql statement.
          If mOK Then If pDBConn.ExecuteCommand("UPDATE dbo.WoodPalletItem SET QuantityUsed=" & (vWoodPalletItem.QuantityUsed) & " WHERE WoodPalletItemID =" & vWoodPalletItem.WoodPalletItemID) > 0 Then mOK = True
          '// Update the POCO allocation
          ''If mOK Then If pDBConn.ExecuteCommand("UPDATE dbo.PurchaseOrderItemAllocation SET ReceivedQty=" & vPOItemAllocation.ReceivedQty + vRecievedQty & " WHERE PurchaseOrderItemAllocationID =" & vPOItemAllocation.PurchaseOrderItemAllocationID) > 0 Then mOK = True

          If mOK Then
            vWoodPalletItem.SetQtyUsed(vWoodPalletItem.QuantityUsed)
            '' vPOItemAllocation.SetReceivedQty(vPOItemAllocation.ReceivedQty + vQuantityUsed)
          End If

          If pDBConn.ExecuteCommand("UPDATE dbo.MaterialRequirement SET PickedQty=" & vMatReq.PickedQty + vItemQuantity & "WHERE MaterialRequirementID =" & vMatReq.MaterialRequirementID) > 0 Then
            mOK = True
          Else
            mOK = False
          End If

        End If
      End If
    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK

  End Function

  Public Function GetLastTransactionBefore(ByVal vDateTime As DateTime, vID As Integer, vExcludeID As Integer) As dmStockItemTransactionLog
    Dim mRetVal As New dmStockItemTransactionLog

    Try
      pDBConn.Connect()
      mRetVal = GetLastTransactionBeforeConnected(vDateTime, vID, vExcludeID)
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally

      If pDBConn.IsConnected Then
        pDBConn.Disconnect()
      End If
    End Try
    Return mRetVal
  End Function

  Public Function AdjustmentSetStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vAdjustQty As Decimal, ByVal vRefObjectType As eObjectType, ByVal vRefObjectID As Integer, ByVal vTransDate As DateTime, ByVal rAmmendmentLog As dmStockItemLocationAmendmentLog, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mdtoStockItemLocationAmendmentLog As New dtoStockItemLocationAmendmentLog(pDBConn)

    Dim mNewStockLevel As Decimal

    Try

      If vStockitemLocation IsNot Nothing Then


        If vAdjustQty <> 0 Then

          pDBConn.Connect()

          pDBConn.ConnectionBeginTrans()

          '// Get the previous Transaction
          mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID, 0)
          If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

          '// Get any stock check after the insert date
          mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vStockitemLocation.StockItemLocationID)

          '// Get transactions after this date that need to have their prev and new changed
          If mSubsequentStockCheckTran IsNot Nothing Then
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vStockitemLocation.StockItemLocationID)
          Else
            mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vStockitemLocation.StockItemLocationID)
          End If

          '//Save the ammentmentlog first to get an ID
          mOK = mdtoStockItemLocationAmendmentLog.SaveStockItemLocationAmendmentLog(rAmmendmentLog)

          mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, vAdjustQty, eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, eTransactionType.Adjustment, pDBConn.RTISUser.UserID, "", vRefObjectType, rAmmendmentLog.StockItemLocationAmendmentLogID, 0, vDefaultCurrency, vUnitCost, vExchangeRate)
          mNewStockLevel = mPrevValue + vAdjustQty

          For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
            Select Case mTran.TransactionType
              Case eTransactionType.StockCheck, eTransactionType.Amendment
                '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                mTran.PrevValue += vAdjustQty
              Case Else
                mTran.PrevValue += vAdjustQty
                mTran.NewValue += vAdjustQty
                mNewStockLevel = mTran.NewValue
            End Select
          Next

          If mSubsequentStockCheckTran Is Nothing Then
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & vStockitemLocation.StockItemLocationID) > 0 Then
            Else
              mOK = False
            End If
          Else
            '//Change the PrevValue of the Stock Check Transaction
            mSubsequentStockCheckTran.PrevValue += vAdjustQty
            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
          End If

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)

          If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

        End If
      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally

      If pDBConn.IsConnected Then
        If mOK Then
          pDBConn.ConnectionCommitTrans()
        Else
          pDBConn.ConnectionRollBackTrans()
        End If

        pDBConn.Disconnect()
      End If
    End Try

    Return mOK
  End Function


  Public Function PickMatReqStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vPickedQty As Decimal, ByVal vMatReq As dmMaterialRequirement, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vUnitCost As Decimal, ByVal vExchangeRate As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoSales
    Dim mProductID As Integer

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()

      If vMatReq IsNot Nothing Then

        If vPickedQty <> 0 Then
          If vStockitemLocation IsNot Nothing Then
            mTranType = eTransactionType.Pick

            '// Get the previous Transaction
            mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID, 0)
            If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

            '// Get any stock check after the insert date
            mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, vStockitemLocation.StockItemLocationID)

            '// Get transactions after this date that need to have their prev and new changed
            If mSubsequentStockCheckTran IsNot Nothing Then
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, vStockitemLocation.StockItemLocationID)
            Else
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, vStockitemLocation.StockItemLocationID)
            End If

            mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (vPickedQty * -1), eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, mTranType, pDBConn.RTISUser.UserID, "", eObjectType.MaterialRequirement, vMatReq.MaterialRequirementID, 0, vDefaultCurrency, vUnitCost, vExchangeRate)


            mNewStockLevel = mPrevValue - vPickedQty

            For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
              Select Case mTran.TransactionType
                Case eTransactionType.StockCheck, eTransactionType.Amendment
                  '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                  mTran.PrevValue -= vPickedQty
                Case Else
                  mTran.PrevValue -= vPickedQty
                  mTran.NewValue -= vPickedQty
                  mNewStockLevel = mTran.NewValue
              End Select
            Next

            If mSubsequentStockCheckTran Is Nothing Then
              If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & vStockitemLocation.StockItemLocationID) > 0 Then
              Else
                mOK = False
              End If
            Else
              '//Change the PrevValue of the Stock Check Transaction
              mSubsequentStockCheckTran.PrevValue -= vPickedQty
              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & vStockitemLocation.StockItemID) > 0 Then
            Else
              mOK = False
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

          End If

          '// even if there is no StockItem, we still need to update the material requirement picked qty
          If mOK Then
            If pDBConn.ExecuteCommand("UPDATE dbo.MaterialRequirement SET PickedQty=" & vMatReq.PickedQty + vPickedQty & "WHERE MaterialRequirementID =" & vMatReq.MaterialRequirementID) > 0 Then
              mOK = True
            Else
              mOK = False
            End If
          End If
          If mOK = True Then vMatReq.SetPickedQty(vMatReq.PickedQty + vPickedQty)

          If mOK = True Then
            '//Update the denormalised vale in the CallOff
            mdso = New dsoSales(pDBConn)
            mProductID = mdso.GetProductIDIByObjectIDConnected(vMatReq.ObjectID)
            mdso.SynchroniseWOMatReqPickedConnected(vStockitemLocation.StockItemID, mProductID)

          End If

        End If
      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function

  Public Function CreatePrevSourceWoodPalletTransaction(ByRef rWoodPallet As dmWoodPallet, ByVal vTargetLocation As Integer, ByRef rObject As Object, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vExchangeRate As Decimal, ByVal vTransactionType As eTransactionType) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoStock
    Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
    Dim mStockItemLocation As dmStockItemLocation
    Dim mUnitCost As Decimal
    Dim mSI As dmStockItem
    Dim mSQL As String
    Dim mdsoCosting As New dsoCostBook(pDBConn)
    Dim mMonetaryValue As Decimal = 0

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()


      mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(rWoodPallet)
      mdso = New dsoStock(pDBConn)
      For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
        '// Get current cost - this should probably be outside here - think through with John
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)
        If mSI IsNot Nothing Then
          mUnitCost = mdsoCosting.GetDefaultCostBookValueByStockItemIDConnected(mSI.StockItemID) 'mSI.StdCost
          '// Start with Movements out of current location
          mStockItemLocation = mdso.GetOrCreateStockItemLocationConnected(mKVP.Key, vTargetLocation, 0)
          If mStockItemLocation IsNot Nothing Then
            mTranType = vTransactionType
            '// Get the previous Transaction
            mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mStockItemLocation.StockItemLocationID, 0)
            If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

            '// Get any stock check after the insert date
            mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, mStockItemLocation.StockItemLocationID)

            '// Get transactions after this date that need to have their prev and new changed
            If mSubsequentStockCheckTran IsNot Nothing Then
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, mStockItemLocation.StockItemLocationID)
            Else
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, mStockItemLocation.StockItemLocationID)
            End If

            Dim mWorkOrderInfo As clsWorkOrderInfo
            mWorkOrderInfo = TryCast(rObject, clsWorkOrderInfo)
            If mWorkOrderInfo IsNot Nothing Then
              mSILTranLog = mStockItemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (-1 * mKVP.Value), eObjectType.StockItemLocation, mStockItemLocation.StockItemLocationID, vTargetLocation, vTransDate, mTranType, pDBConn.RTISUser.UserID, mWorkOrderInfo.Description, eObjectType.WorkOrder, mWorkOrderInfo.WorkOrderID, rWoodPallet.WoodPalletID, vDefaultCurrency, mUnitCost, vExchangeRate)

            Else
              mSILTranLog = mStockItemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (-1 * mKVP.Value), eObjectType.StockItemLocation, mStockItemLocation.StockItemLocationID, vTargetLocation, vTransDate, mTranType, pDBConn.RTISUser.UserID, rWoodPallet.LocationID, eObjectType.WoodPallet, rWoodPallet.WoodPalletID, rWoodPallet.WoodPalletID, vDefaultCurrency, mUnitCost, vExchangeRate)

            End If


            '// Update the current Monetary Value at this location
            mMonetaryValue = GetStockItemLocationMonetaryValue(mSI, mStockItemLocation)


            mNewStockLevel = mPrevValue - mKVP.Value

            For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
              Select Case mTran.TransactionType
                Case eTransactionType.StockCheck, eTransactionType.Amendment
                  '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                  mTran.PrevValue -= mKVP.Value
                Case Else
                  mTran.PrevValue -= mKVP.Value
                  mTran.NewValue -= mKVP.Value
                  mNewStockLevel = mTran.NewValue
              End Select
            Next

            If mSubsequentStockCheckTran Is Nothing Then
              If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " ,MonetaryValue = " & mMonetaryValue & " WHERE StockItemLocationID =" & mStockItemLocation.StockItemLocationID) > 0 Then
              Else
                mOK = False
              End If
            Else
              '//Change the PrevValue of the Stock Check Transaction
              mSubsequentStockCheckTran.PrevValue -= mKVP.Value
              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & mStockItemLocation.StockItemID) > 0 Then
            Else
              mOK = False
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)



          End If
        End If
      Next






    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK

  End Function


  Public Function CreatePositiveTransaction(ByVal vTransactionType As eTransactionType, ByRef rWoodPallet As dmWoodPallet, ByVal vTargetLocation As Integer, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vExchangeRate As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoStock
    Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
    Dim mStockItemLocation As dmStockItemLocation
    Dim mUnitCost As Decimal
    Dim mSI As dmStockItem
    Dim mSQL As String
    Dim mdsoCosting As New dsoCostBook(pDBConn)
    Dim mMonetaryValue As Decimal
    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()



      mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(rWoodPallet)
      mdso = New dsoStock(pDBConn)
      For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
        mPrevValue = 0
        '// Get current cost - this should probably be outside here - think through with John
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)
        If mSI IsNot Nothing Then
          mUnitCost = mdsoCosting.GetDefaultCostBookValueByStockItemIDConnected(mSI.StockItemID) 'mSI.StdCost
          '// Start with Movements out of current location
          '// Now the Movements into the target location
          mStockItemLocation = mdso.GetOrCreateStockItemLocationConnected(mKVP.Key, vTargetLocation, 0)
          If mStockItemLocation IsNot Nothing Then
            mTranType = vTransactionType
            '// Get the previous Transaction
            mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mStockItemLocation.StockItemLocationID, 0)
            If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

            '// Get any stock check after the insert date
            mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, mStockItemLocation.StockItemLocationID)

            '// Get transactions after this date that need to have their prev and new changed
            If mSubsequentStockCheckTran IsNot Nothing Then
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, mStockItemLocation.StockItemLocationID)
            Else
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, mStockItemLocation.StockItemLocationID)
            End If

            mSILTranLog = mStockItemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, mKVP.Value, eObjectType.StockItemLocation, mStockItemLocation.StockItemLocationID, rWoodPallet.LocationID, vTransDate, mTranType, pDBConn.RTISUser.UserID, rWoodPallet.PalletRef, eObjectType.WoodPallet, rWoodPallet.WoodPalletID, rWoodPallet.WoodPalletID, vDefaultCurrency, mUnitCost, vExchangeRate)

            '// Update the current Monetary Value at this location
            mMonetaryValue = GetStockItemLocationMonetaryValue(mSI, mStockItemLocation)

            mNewStockLevel = mPrevValue + mKVP.Value

            For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
              Select Case mTran.TransactionType
                Case eTransactionType.StockCheck, eTransactionType.Amendment
                  '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                  mTran.PrevValue += mKVP.Value
                Case Else
                  mTran.PrevValue += mKVP.Value
                  mTran.NewValue += mKVP.Value
                  mNewStockLevel = mTran.NewValue
              End Select
            Next

            If mSubsequentStockCheckTran Is Nothing Then
              If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " ,MonetaryValue = " & mMonetaryValue & " WHERE StockItemLocationID =" & mStockItemLocation.StockItemLocationID) > 0 Then
              Else
                mOK = False
              End If
            Else
              '//Change the PrevValue of the Stock Check Transaction
              mSubsequentStockCheckTran.PrevValue += mKVP.Value
              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & mStockItemLocation.StockItemID) > 0 Then
            Else
              mOK = False
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

          End If

        End If
      Next


      '// Update the Pallet Location

      If mOK = True Then
        '//Update the denormalised vale in the CallOff
        rWoodPallet.LocationID = vTargetLocation
        mSQL = String.Format("Update WoodPallet Set LocationID = {0} Where WoodPalletID = {1}", vTargetLocation, rWoodPallet.WoodPalletID)
        pDBConn.ExecuteNonQuery(mSQL)
      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function


  Private Function GetStockItemLocationMonetaryValue(ByRef rStockItem As dmStockItem, ByRef rStockItemLocation As dmStockItemLocation) As Decimal
    Dim mStockCostingPricing As clsStockCostingPricing
    Dim mRetVal As Decimal = 0
    mStockCostingPricing = New clsStockCostingPricing(pDBConn, AppRTISGlobal.GetInstance.StockItemRegistry, AppRTISGlobal.GetInstance.DefaultCostBook)
    mRetVal = mStockCostingPricing.GetStockItemLocationMoneytaryValue(rStockItem, rStockItemLocation)

    Return mRetVal
  End Function

  Public Function CreateNegativeTransaction(ByVal vTransactionType As eTransactionType, ByRef rWoodPallet As dmWoodPallet, ByVal vTargetLocation As Integer, ByRef rSalesOrder As dmSalesOrder, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vExchangeRate As Decimal, ByVal vObjectType As eObjectType) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoStock
    Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
    Dim mStockItemLocation As dmStockItemLocation
    Dim mUnitCost As Decimal
    Dim mSI As dmStockItem
    Dim mSQL As String
    Dim mdsoCosting As New dsoCostBook(pDBConn)

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()



      mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(rWoodPallet)
      mdso = New dsoStock(pDBConn)
      For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
        mPrevValue = 0
        '// Get current cost - this should probably be outside here - think through with John
        mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)
        If mSI IsNot Nothing Then
          mUnitCost = mdsoCosting.GetDefaultCostBookValueByStockItemIDConnected(mSI.StockItemID) 'mSI.StdCost
          '// Start with Movements out of current location
          '// Now the Movements into the target location
          mStockItemLocation = mdso.GetOrCreateStockItemLocationConnected(mKVP.Key, vTargetLocation, 0)
          If mStockItemLocation IsNot Nothing Then
            mTranType = vTransactionType
            '// Get the previous Transaction
            mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mStockItemLocation.StockItemLocationID, 0)
            If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

            '// Get any stock check after the insert date
            mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, mStockItemLocation.StockItemLocationID)

            '// Get transactions after this date that need to have their prev and new changed
            If mSubsequentStockCheckTran IsNot Nothing Then
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, mStockItemLocation.StockItemLocationID)
            Else
              mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, mStockItemLocation.StockItemLocationID)
            End If

            mSILTranLog = mStockItemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (mKVP.Value * -1), eObjectType.StockItemLocation, mStockItemLocation.StockItemLocationID, rWoodPallet.LocationID, vTransDate, mTranType, pDBConn.RTISUser.UserID, rWoodPallet.PalletRef, vObjectType, rWoodPallet.WoodPalletID, rWoodPallet.WoodPalletID, vDefaultCurrency, mUnitCost, vExchangeRate)

            mNewStockLevel = mPrevValue - mKVP.Value

            For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
              Select Case mTran.TransactionType
                Case eTransactionType.StockCheck, eTransactionType.Amendment
                  '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                  mTran.PrevValue += mKVP.Value
                Case Else
                  mTran.PrevValue += mKVP.Value
                  mTran.NewValue += mKVP.Value
                  mNewStockLevel = mTran.NewValue
              End Select
            Next

            If mSubsequentStockCheckTran Is Nothing Then
              If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & mStockItemLocation.StockItemLocationID) > 0 Then
              Else
                mOK = False
              End If
            Else
              '//Change the PrevValue of the Stock Check Transaction
              mSubsequentStockCheckTran.PrevValue -= mKVP.Value
              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
            If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & mStockItemLocation.StockItemID) > 0 Then
            Else
              mOK = False
            End If

            If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

          End If

        End If
      Next


      '// Update the Pallet Location

      If mOK = True Then
        '//Update the denormalised vale in the CallOff
        rWoodPallet.LocationID = vTargetLocation
        mSQL = String.Format("Update WoodPallet Set LocationID = {0} Where WoodPalletID = {1}", vTargetLocation, rWoodPallet.WoodPalletID)
        pDBConn.ExecuteNonQuery(mSQL)
      End If



    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function
  Public Function MoveWoodPallet(ByRef rWoodPallet As dmWoodPallet, ByVal vTargetLocation As Integer, ByRef rSalesOrder As dmSalesOrder, ByVal vTransDate As DateTime, ByVal vDefaultCurrency As Integer, ByVal vExchangeRate As Decimal) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal
    Dim mdso As dsoStock
    Dim mStockItemQtys As Dictionary(Of Integer, Decimal)
    Dim mStockItemLocation As dmStockItemLocation
    Dim mUnitCost As Decimal
    Dim mSI As dmStockItem
    Dim mSQL As String
    Dim mdsoCosting As New dsoCostBook(pDBConn)

    Try
      pDBConn.Connect()

      pDBConn.ConnectionBeginTrans()


      If rWoodPallet.LocationID <> vTargetLocation Then
        mStockItemQtys = clsWoodPalletSharedFuncs.GetStockItemQtys(rWoodPallet)
        mdso = New dsoStock(pDBConn)
        For Each mKVP As KeyValuePair(Of Integer, Decimal) In mStockItemQtys
          '// Get current cost - this should probably be outside here - think through with John
          mSI = AppRTISGlobal.GetInstance.StockItemRegistry.GetStockItemFromID(mKVP.Key)
          If mSI IsNot Nothing Then
            mUnitCost = mdsoCosting.GetDefaultCostBookValueByStockItemIDConnected(mSI.StockItemID) 'mSI.StdCost
            '// Start with Movements out of current location
            mStockItemLocation = mdso.GetOrCreateStockItemLocationConnected(mKVP.Key, rWoodPallet.LocationID, 0)
            If mStockItemLocation IsNot Nothing Then
              mTranType = eTransactionType.Movement
              '// Get the previous Transaction
              mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mStockItemLocation.StockItemLocationID, 0)
              If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

              '// Get any stock check after the insert date
              mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, mStockItemLocation.StockItemLocationID)

              '// Get transactions after this date that need to have their prev and new changed
              If mSubsequentStockCheckTran IsNot Nothing Then
                mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, mStockItemLocation.StockItemLocationID)
              Else
                mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, mStockItemLocation.StockItemLocationID)
              End If

              mSILTranLog = mStockItemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (-1 * mKVP.Value), eObjectType.StockItemLocation, mStockItemLocation.StockItemLocationID, mStockItemLocation.LocationID, vTransDate, mTranType, pDBConn.RTISUser.UserID, rWoodPallet.PalletRef, eObjectType.WoodPallet, rWoodPallet.WoodPalletID, rWoodPallet.LocationID, vDefaultCurrency, mUnitCost, vExchangeRate)

              mNewStockLevel = mPrevValue - mKVP.Value

              For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
                Select Case mTran.TransactionType
                  Case eTransactionType.StockCheck, eTransactionType.Amendment
                    '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                    mTran.PrevValue -= mKVP.Value
                  Case Else
                    mTran.PrevValue -= mKVP.Value
                    mTran.NewValue -= mKVP.Value
                    mNewStockLevel = mTran.NewValue
                End Select
              Next

              If mSubsequentStockCheckTran Is Nothing Then
                If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & mStockItemLocation.StockItemLocationID) > 0 Then
                Else
                  mOK = False
                End If
              Else
                '//Change the PrevValue of the Stock Check Transaction
                mSubsequentStockCheckTran.PrevValue -= mKVP.Value
                If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
              End If

              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
              If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & mStockItemLocation.StockItemID) > 0 Then
              Else
                mOK = False
              End If

              If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

              '// Now the Movements into the target location
              mPrevValue = 0
              mStockItemLocation = mdso.GetOrCreateStockItemLocationConnected(mKVP.Key, vTargetLocation, 0)
              If mStockItemLocation IsNot Nothing Then
                mTranType = eTransactionType.Movement
                '// Get the previous Transaction
                mPrevTran = GetLastTransactionBeforeConnected(vTransDate, mStockItemLocation.StockItemLocationID, 0)
                If mPrevTran IsNot Nothing Then mPrevValue = mPrevTran.NewValue

                '// Get any stock check after the insert date
                mSubsequentStockCheckTran = GetFirstStockCheckTransactionAfterConnected(vTransDate, mStockItemLocation.StockItemLocationID)

                '// Get transactions after this date that need to have their prev and new changed
                If mSubsequentStockCheckTran IsNot Nothing Then
                  mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, mSubsequentStockCheckTran.TransactionDate, mStockItemLocation.StockItemLocationID)
                Else
                  mSILTranLogRollForward = GetTransctionsBetweenExcludingConnected(vTransDate, Now, mStockItemLocation.StockItemLocationID)
                End If

                mSILTranLog = mStockItemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, mKVP.Value, eObjectType.StockItemLocation, mStockItemLocation.StockItemLocationID, vTargetLocation, vTransDate, mTranType, pDBConn.RTISUser.UserID, rWoodPallet.PalletRef, eObjectType.WoodPallet, rWoodPallet.WoodPalletID, rWoodPallet.WoodPalletID, vDefaultCurrency, mUnitCost, vExchangeRate)

                mNewStockLevel = mPrevValue + mKVP.Value

                For Each mTran As dmStockItemTransactionLog In mSILTranLogRollForward
                  Select Case mTran.TransactionType
                    Case eTransactionType.StockCheck, eTransactionType.Amendment
                      '//This should not happen as we have the subsequent stock check transaction as a seperate transaction
                      mTran.PrevValue += mKVP.Value
                    Case Else
                      mTran.PrevValue += mKVP.Value
                      mTran.NewValue += mKVP.Value
                      mNewStockLevel = mTran.NewValue
                  End Select
                Next

                If mSubsequentStockCheckTran Is Nothing Then
                  If pDBConn.ExecuteCommand("UPDATE dbo.StockItemLocation SET Qty=" & mNewStockLevel & " WHERE StockItemLocationID =" & mStockItemLocation.StockItemLocationID) > 0 Then
                  Else
                    mOK = False
                  End If
                Else
                  '//Change the PrevValue of the Stock Check Transaction
                  mSubsequentStockCheckTran.PrevValue += mKVP.Value
                  If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSubsequentStockCheckTran)
                End If

                If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLog(mSILTranLog)
                If pDBConn.ExecuteCommand("UPDATE dbo.StockItem SET LastUsedDate = '" & Format(vTransDate, "yyyyMMdd HH:mm:ss") & "' WHERE StockItemID =" & mStockItemLocation.StockItemID) > 0 Then
                Else
                  mOK = False
                End If

                If mOK Then mOK = mdtoStockitemTranLog.SaveStockItemTransactionLogCollection(mSILTranLogRollForward)

              End If
            End If
          End If
        Next


        '// Update the Pallet Location

        If mOK = True Then
          '//Update the denormalised vale in the CallOff
          rWoodPallet.LocationID = vTargetLocation
          mSQL = String.Format("Update WoodPallet Set LocationID = {0} Where WoodPalletID = {1}", vTargetLocation, rWoodPallet.WoodPalletID)
          pDBConn.ExecuteNonQuery(mSQL)
        End If

      End If

    Catch ex As Exception
      mOK = False
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If mOK Then
        pDBConn.ConnectionCommitTrans()
      Else
        pDBConn.ConnectionRollBackTrans()
      End If
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

    Return mOK
  End Function


  Public Sub ResetStockTransactionValuations(ByVal vStockItemID As Integer, ByVal vStartingQty As Decimal, ByVal vStartingUnitCost As Decimal)
    Dim mSQL As String
    Dim mTranLogs As colStockItemTransactionLogInfos
    Dim mdto As dtoStockItemTransactionLogInfo
    Dim mCurrentUnitCost As Decimal
    Dim mCurrentTotalQty As Decimal
    Dim mCurrentTotalValue As Decimal
    Dim mPODeliveryUnitCost As Decimal
    Dim mExchangeRate As Decimal
    Dim mDefaultCurrencty As Integer
    Dim mAverageCost As Decimal

    Try
      If pDBConn.Connect() Then
        mTranLogs = New colStockItemTransactionLogInfos
        mdto = New dtoStockItemTransactionLogInfo(pDBConn, dtoStockItemTransactionLogInfo.eMode.StockItemTransactionLogInfo)
        mdto.LoadStockItemTransactionLogInfoCollection(mTranLogs, "StockItemID = " & vStockItemID)

        '// Current qty and unit cost set to starting value
        mCurrentTotalQty = vStartingQty
        mCurrentUnitCost = vStartingUnitCost

        For Each mTran As clsStockItemTransactionLogInfo In mTranLogs




          Select Case mTran.TransType
            Case eTransactionType.GoodsIn, eTransactionType.SupplierReturn
              '// get the purchase order item value
              mSQL = "Select UnitPrice From vwPODeliveryItemInfo Where PODeliveryItemID = " & mTran.RefObjectID
              mPODeliveryUnitCost = pDBConn.ExecuteScalar(mSQL)

              ''//Get the defaultcurrency from the PODelivery in order to update the right transaction valuation in USD
              mSQL = "Select DefaultCurrency From vwPODeliveryItemInfo Where PODeliveryItemID = " & mTran.RefObjectID
              mDefaultCurrencty = pDBConn.ExecuteScalar(mSQL)

              ''//Exhange from Cordobas to USD
              mExchangeRate = GetExchangeRateConnected(mTran.TransDate, eCurrency.Cordobas)

              If mExchangeRate > 0 Then ''//avoid division by 0

                If mDefaultCurrencty = eCurrency.Cordobas Then



                  mTran.TransactionValuationDollar = mTran.TransQuantity * (mPODeliveryUnitCost / mExchangeRate)



                  '// Now modify the Current Unit Cost
                  mCurrentTotalQty = mCurrentTotalQty + mTran.TransQuantity
                  mCurrentTotalValue = mCurrentTotalValue + (mTran.TransQuantity * mPODeliveryUnitCost) 'mTran.TransactionValuationDollar
                  If mCurrentTotalQty > 0 Then
                    mCurrentUnitCost = mCurrentTotalValue / mCurrentTotalQty
                  End If


                Else ''If is USD
                  mTran.TransactionValuationDollar = mTran.TransQuantity * mPODeliveryUnitCost

                  '// Now modify the Current Unit Cost
                  mCurrentTotalQty = mCurrentTotalQty + mTran.TransQuantity
                  mCurrentTotalValue = mCurrentTotalValue + mTran.TransactionValuationDollar

                  If mCurrentTotalQty > 0 Then
                    mCurrentUnitCost = (mCurrentTotalValue / mCurrentTotalQty) * mExchangeRate
                  End If

                End If
                mSQL = String.Format("Update StockItem Set AverageCost = {0} Where StockItemID = {1}", mCurrentUnitCost, vStockItemID)
                pDBConn.ExecuteNonQuery(mSQL)
              End If




            Case Else

              ''//the rest of transaction types are in Cordobas because it's getting the value from StdCost in StockItem table

              mSQL = String.Format("Select IsNull(AverageCost,0) from StockItem Where StockItemID = {0}", vStockItemID)

              mAverageCost = pDBConn.ExecuteScalar(mSQL)

              ''//This will update the transactions for the Picking with the AverageCost instead of StdCost
              If mAverageCost > 0 Then
                mCurrentUnitCost = mAverageCost
              End If

              mExchangeRate = GetExchangeRateConnected(mTran.TransDate, eCurrency.Cordobas)

                If mExchangeRate > 0 Then ''//avoid division by 0
                  mCurrentUnitCost = mCurrentUnitCost / mExchangeRate
                End If


              mTran.TransactionValuationDollar = mTran.TransQuantity * mCurrentUnitCost
              mCurrentTotalQty = mCurrentTotalQty + mTran.TransQuantity
              mCurrentTotalValue = mCurrentTotalQty * (mCurrentUnitCost * mExchangeRate)


          End Select

          ''//Update the current StockItemTransactionLog, I dont like this way but in the Table we dont have a stockitemid, it's only in the info class
          mSQL = String.Format("Update StockItemTransactionLog Set TransactionValuationDollar = {0} Where StockItemTransactionLogID = {1}", mTran.TransactionValuationDollar, mTran.StockItemTransactionLogID)
          pDBConn.ExecuteNonQuery(mSQL)




        Next

        'mdto.SaveStockItemTransactionLogCollection(mTranLogs)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try

  End Sub

  Public Function GetExchangeRateConnected(ByVal vDate As Date, vCurrency As Integer) As Decimal
    Dim mdsoGeneral As New dsoGeneral(pDBConn)
    Dim mExchangeRate As Decimal = 0

    mExchangeRate = mdsoGeneral.GetExchangeRateCoonected(vDate, vCurrency)

    Return mExchangeRate
  End Function

End Class
