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

  Private Function GetLastTransactionBeforeConnected(ByVal vDateTime As DateTime, vID As Integer, vExcludeID As Integer) As dmStockItemTransactionLog
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


  Public Function AmendmentSetStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vNewQty As Decimal, ByVal vRefObjectType As eObjectType, ByVal vRefObjectID As Integer, ByVal vTransDate As DateTime, ByRef rAmmendmentLog As dmStockItemLocationAmendmentLog) As Boolean
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

        mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionSet(mPrevValue, vNewQty, eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, eTransactionType.Amendment, pDBConn.RTISUser.UserID, "", vRefObjectType, rAmmendmentLog.StockItemLocationAmendmentLogID)

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


  Public Function AdjustmentSetStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vAdjustQty As Decimal, ByVal vRefObjectType As eObjectType, ByVal vRefObjectID As Integer, ByVal vTransDate As DateTime, ByVal rAmmendmentLog As dmStockItemLocationAmendmentLog, ByVal vReferenceNo As String) As Boolean
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

          mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, vAdjustQty, eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, eTransactionType.Adjustment, pDBConn.RTISUser.UserID, "", vRefObjectType, rAmmendmentLog.StockItemLocationAmendmentLogID, vReferenceNo)
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


  Public Function PickMatReqStockItemLocationQty(ByVal vStockitemLocation As dmStockItemLocation, ByVal vPickedQty As Decimal, ByVal vMatReq As dmMaterialRequirement, ByVal vTransDate As DateTime, ByVal vReferenceNo As String) As Boolean
    Dim mOK As Boolean = True
    Dim mdtoStockitemTranLog As New dtoStockItemTransactionLog(pDBConn)
    Dim mSILTranLog As dmStockItemTransactionLog
    Dim mTranType As eTransactionType
    Dim mPrevTran As dmStockItemTransactionLog
    Dim mPrevValue As Decimal = 0
    Dim mSILTranLogRollForward As New colStockItemTransactionLogs
    Dim mSubsequentStockCheckTran As dmStockItemTransactionLog
    Dim mNewStockLevel As Decimal

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

            mSILTranLog = vStockitemLocation.QtyValueTracker.CreateTransactionAdjust(mPrevValue, (vPickedQty * -1), eObjectType.StockItemLocation, vStockitemLocation.StockItemLocationID, 0, vTransDate, mTranType, pDBConn.RTISUser.UserID, "", eObjectType.MaterialRequirement, vMatReq.MaterialRequirementID, vReferenceNo)


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


End Class
