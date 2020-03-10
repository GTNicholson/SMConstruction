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
    Dim mMatReqOtherTotalCost As Decimal
    Dim mdto As dtoStockItemTransactionLogInfo
    Dim mWhere As String = ""

    Try
      mCurDate = vStartDate
      Do While mCurDate <= vEndDate
        mCD = New clsCompanyDay
        mCD.CompanyDayDate = mCurDate
        rCompanyDays.Add(mCD)
        mCurDate = mCurDate.AddDays(1)
      Loop
      mdto = New dtoStockItemTransactionLogInfo(pDBConn)

      mWhere += "TransactionDate >= '" & vStartDate.ToString("yyyyMMdd") & "' and TransactionDate <= '" & vEndDate.ToString("yyyyMMdd") & "'"
      mWhere += " and TransactionType =2"
      mdto.LoadStockItemTransactionLogInfoCollection(mMatReqOthers, mWhere)

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

    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function


End Class
