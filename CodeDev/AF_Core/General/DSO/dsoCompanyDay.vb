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
    'Dim mOK As Boolean

    'Try
    '  pDBConn.Connect()
    '  mOK = LoadCompanyDaysWoodInventoryConnected(rCompanyDays, vStartDate, vEndDate)

    'Catch ex As Exception
    '  If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    'Finally
    '  If pDBConn.IsConnected Then pDBConn.Disconnect()
    'End Try
    'Return mOK
  End Function


  'Public Function LoadCompanyDaysConnected(ByRef rCompanyDays As colCompanyDays, ByVal vStartDate As DateTime, ByVal vEndDate As DateTime) As Boolean
  '  Dim mOK As Boolean
  '  Dim mCurDate As DateTime
  '  Dim mCD As clsCompanyDay
  '  Dim mMatReqOthers As New colStockItemTransactionLogInfos
  '  Dim mTSEntrys As New colTimeSheetEntryInfos
  '  Dim mMatWoodReqInfos As New colMaterialRequirementInfos
  '  Dim mLabourCostStd As Decimal
  '  Dim mLabourOverTime As Decimal
  '  Dim mMatReqOtherTotalCost As Decimal
  '  Dim mWoodMatReqCost As Decimal
  '  Dim mdtoSITL As dtoStockItemTransactionLogInfo
  '  Dim mdtoTSE As dtoTimeSheetEntryInfo
  '  Dim mdtoMaterialRequirementInfo As dtoMaterialRequirementInfo
  '  Dim mWhereTransactionLog As String = ""
  '  Dim mWhereTSE As String = ""
  '  Dim mWhereMatReq As String = ""

  '  Try
  '    mCurDate = vStartDate
  '    Do While mCurDate <= vEndDate
  '      mCD = New clsCompanyDay
  '      mCD.CompanyDayDate = mCurDate
  '      rCompanyDays.Add(mCD)
  '      mCurDate = mCurDate.AddDays(1)
  '    Loop
  '    mdtoSITL = New dtoStockItemTransactionLogInfo(pDBConn, dtoStockItemTransactionLogInfo.eMode.StockItemTransactionLogInfo)
  '    mdtoTSE = New dtoTimeSheetEntryInfo(pDBConn)
  '    mdtoMaterialRequirementInfo = New dtoMaterialRequirementInfo(pDBConn, dtoMaterialRequirementInfo.eMode.WoodMat)

  '    mWhereTransactionLog += "TransactionDate >= '" & vStartDate.ToString("yyyyMMdd") & "' and TransactionDate <= '" & vEndDate.ToString("yyyyMMdd") & "'"
  '    mWhereTransactionLog += " and TransactionType =2"
  '    mdtoSITL.LoadStockItemTransactionLogInfoCollection(mMatReqOthers, mWhereTransactionLog)

  '    For Each mSITLI As clsStockItemTransactionLogInfo In mMatReqOthers
  '      mCD = rCompanyDays.GetItemFromDate(mSITLI.TransDate)
  '      If mCD IsNot Nothing Then
  '        mCD.MatOtherCosts.Add(mSITLI)
  '      End If
  '    Next

  '    '// Calculate Summary values
  '    For Each mCD In rCompanyDays
  '      mMatReqOtherTotalCost = 0
  '      For Each mSITLI As clsStockItemTransactionLogInfo In mCD.MatOtherCosts
  '        '' mMatReqOtherTotalCost += (mSITLI.StdCost * mSITLI.TransQuantity)
  '        mMatReqOtherTotalCost += mSITLI.TransactionValuationDollar
  '      Next
  '      mCD.MatOtherCost = mMatReqOtherTotalCost
  '    Next

  '    '// Time Sheet Entry Info
  '    mWhereTSE = "StartTime >= '" & vStartDate.ToString("yyyyMMdd") & "' and StartTime <= '" & vEndDate.ToString("yyyyMMdd") & "'"

  '    '' mWhereTSE = "StartTime >= '" & vStartDate.ToString("yyyyMMdd") & "'"
  '    mdtoTSE.LoadTimeSheetEntryInfoCollectionByWhere(mTSEntrys, mWhereTSE)

  '    For Each mTSELI As clsTimeSheetEntryInfo In mTSEntrys
  '      mCD = rCompanyDays.GetItemFromDate(mTSELI.StartTime)
  '      If mCD IsNot Nothing Then
  '        mCD.TSECosts.Add(mTSELI)
  '      End If
  '    Next

  '    For Each mCD In rCompanyDays
  '      mLabourCostStd = 0
  '      mLabourOverTime = 0
  '      For Each mTSEI As clsTimeSheetEntryInfo In mCD.TSECosts
  '        mLabourCostStd += (mTSEI.Duration * mTSEI.StandardRate) / 34
  '        mLabourOverTime += (mTSEI.OverTimeMinutes / 60 * mTSEI.OverTimeRate) / 34
  '      Next
  '      mCD.LabourCostStd = mLabourCostStd
  '      mCD.LabourCostOT = mLabourOverTime
  '    Next


  '    ''wood

  '    mWhereMatReq = "PlannedStartDate >= '" & vStartDate.ToString("yyyyMMdd") & "' and PlannedStartDate <= '" & vEndDate.ToString("yyyyMMdd") & "'"
  '    mdtoMaterialRequirementInfo.LoadWoodMatReqByWhere(mMatWoodReqInfos, mWhereMatReq)

  '    For Each mSITLI As clsMaterialRequirementInfo In mMatWoodReqInfos
  '      mCD = rCompanyDays.GetItemFromDate(mSITLI.PlannedStartDate)
  '      If mCD IsNot Nothing Then
  '        mCD.MaterialRequirementInfo.Add(mSITLI)
  '      End If
  '    Next

  '    '// Calculate Summary values
  '    For Each mCD In rCompanyDays
  '      mWoodMatReqCost = 0
  '      For Each mSITLI As clsMaterialRequirementInfo In mCD.MaterialRequirementInfo
  '        mWoodMatReqCost += clsSMSharedFuncs.BoardFeetFromCMAndQty(mSITLI.WorkOrderQuantity, mSITLI.NetLenght, mSITLI.NetWidth, mSITLI.NetThickness) * 1.5
  '      Next
  '      mCD.WoodMatReqCost = mWoodMatReqCost
  '    Next


  '  Catch ex As Exception
  '    If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
  '  End Try
  '  Return mOK
  'End Function

End Class
