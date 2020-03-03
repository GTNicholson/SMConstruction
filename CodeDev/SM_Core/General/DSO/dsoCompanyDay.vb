Imports RTIS.CommonVB
Imports RTIS.DataLayer

Public Class dsoCompanyDay
  Private pDBConn As clsDBConnBase

  Public Sub New(ByRef rDBConn As clsDBConnBase)
    pDBConn = rDBConn
  End Sub

  Public Function LoadCompanyDays(ByRef rCompanyDays As colCompanyDays, ByVal vStartDate As DateTime, ByVal vEndDate As DateTime) As Boolean
    Dim mOK As Boolean
    Dim mCurDate As DateTime
    Dim mCD As clsCompanyDay

    Try
      mCurDate = vStartDate.Date
      Do While mCurDate <= vEndDate
        mCD = New clsCompanyDay
        mCD.CompanyDayDate = mCurDate
        rCompanyDays.Add(mCD)
        mCurDate.AddDays(1)
      Loop
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDataLayer) Then Throw
    Finally
      If pDBConn.IsConnected Then pDBConn.Disconnect()
    End Try
    Return mOK
  End Function

End Class
