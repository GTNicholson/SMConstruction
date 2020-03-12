Imports RTIS.BIReport
Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoCompanyDay

  Private pDBConn As clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal
  Private pBIReportView As clsBIReportView
  Private pCompanyDays As colCompanyDays

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn

  End Sub


  Public Function LoadCompanyDays(ByRef rCompanyDays As colCompanyDays, ByVal vStartDate As DateTime, ByVal vEndDate As DateTime) As Boolean
    Dim mOK As Boolean
    Dim mCurDate As DateTime
    Dim mCD As clsCompanyDay
    Dim mMatReqOthers As New colStockItemTransactionLogInfos
    Dim mTSEntrys As New colTimeSheetEntryInfos
    Dim mLabourCostStd As Decimal
    Dim mLabourOverTime As Decimal
    Dim mMatReqOtherTotalCost As Decimal
    Dim mdtoSITL As dtoStockItemTransactionLogInfo
    Dim mdtoTSE As dtoTimeSheetEntryInfo
    Dim mWhereTransactionLog As String = ""
    Dim mWhereTSE As String = ""

    Try
      mCurDate = vStartDate
      Do While mCurDate <= vEndDate
        mCD = New clsCompanyDay
        mCD.CompanyDayDate = mCurDate
        rCompanyDays.Add(mCD)
        mCurDate = mCurDate.AddDays(1)
      Loop
      mdtoSITL = New dtoStockItemTransactionLogInfo(pDBConn)
      mdtoTSE = New dtoTimeSheetEntryInfo(pDBConn)

      mWhereTransactionLog += "TransactionDate >= '" & vStartDate.ToString("yyyyMMdd") & "' and TransactionDate <= '" & vEndDate.ToString("yyyyMMdd") & "'"
      mWhereTransactionLog += " and TransactionType =2"
      mdtoSITL.LoadStockItemTransactionLogInfoCollection(mMatReqOthers, mWhereTransactionLog)

      For Each mSITLI As clsStockItemTransactionLogInfo In mMatReqOthers
        mCD = rCompanyDays.GetItemFromDate(mSITLI.TransDate)
        If mCD IsNot Nothing Then
          mCD.MatOtherCosts.Add(mSITLI)
        End If
      Next

      '// Calculate Summary values
      For Each mCD In rCompanyDays
        mMatReqOtherTotalCost = 0
        For Each mSITLI As clsStockItemTransactionLogInfo In mCD.MatOtherCosts
          mMatReqOtherTotalCost += (mSITLI.StdCost * mSITLI.TransQuantity)
        Next
        mCD.MatOtherCost = mMatReqOtherTotalCost
      Next

      '// Time Sheet Entry Info
      mWhereTSE += "StartTime >= '" & vStartDate.ToString("yyyyMMdd") & "' and StartTime <= '" & vEndDate.ToString("yyyyMMdd") & "'"
      mdtoTSE.LoadTimeSheetEntryInfoCollectionByWhere(mTSEntrys, mWhereTSE)

      For Each mTSELI As clsTimeSheetEntryInfo In mTSEntrys
        mCD = rCompanyDays.GetItemFromDate(mTSELI.StartTime)
        If mCD IsNot Nothing Then
          mCD.TSECosts.Add(mTSELI)
        End If
      Next

      For Each mCD In rCompanyDays
        mLabourCostStd = 0
        For Each mTSEI As clsTimeSheetEntryInfo In mCD.TSECosts
          mLabourCostStd += (mTSEI.Duration * mTSEI.StandardRate)
          mLabourOverTime += (mTSEI.OverTimeMinutes / 60 * mTSEI.OverTimeRate)
        Next
        mCD.LabourCostStd = mLabourCostStd
        mCD.LabourCostOT = mLabourOverTime
      Next





    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function


End Class
