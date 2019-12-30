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
        mPrevTran = GetLastTransactionBeforeConnected(vTransDate, vStockitemLocation.StockItemLocationID)
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
    mWhere = mWhere & String.Format(" And TransactionDate > '{0}'", vDateTime.ToString("yyyy/MM/dd HH:mm:ss"))
    mdto.LoadStockItemTransactionLogTOP1ByWhere(mSITLs, mWhere, False)

    If mSITLs.Count <> 0 Then
      mRetVal = mSITLs(0)
    End If
    Return mRetVal
  End Function

  Private Function GetLastTransactionBeforeConnected(ByVal vDateTime As DateTime, vID As Integer) As dmStockItemTransactionLog
    Dim mdto As dtoStockItemTransactionLog
    Dim mWhere As String
    Dim mSITLs As New colStockItemTransactionLogs
    Dim mRetVal As dmStockItemTransactionLog = Nothing

    mdto = New dtoStockItemTransactionLog(pDBConn)
    mWhere = String.Format("ObjectType = {0} AND ObjectID IN ({1})", CByte(eObjectType.StockItemLocation), vID)
    mWhere = mWhere & String.Format(" And TransactionDate <= '{0}'", vDateTime.ToString("yyyy/MM/dd HH:mm:ss:fff"))
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
    mWhere = mWhere & String.Format(" And TransactionDate > '{0}'", vStartDateTime.ToString("yyyy/MM/dd HH:mm:ss"))
    mWhere = mWhere & String.Format(" And TransactionDate < '{0}'", vEndDateTime.ToString("yyyy/MM/dd HH:mm:ss"))
    mdto.LoadStockItemTransactionLogCollectionByWhere(mRetVal, mWhere)

    Return mRetVal
  End Function


End Class
