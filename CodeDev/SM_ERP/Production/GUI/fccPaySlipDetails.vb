Imports RTIS.CommonVB

Public Class fccPaySlipDetails
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pPeriodStartDate As DateTime
  Private pPeriodType As ePayPeriodType
  Private pStandardStartDate As DateTime
  Private pStandardEndDate As DateTime
  Private pOverTimeStartDate As DateTime
  Private pOverTimeEndDate As DateTime
  Private pEmployee As dmEmployeeSM

  Private pTimeSheetEntrys As colTimeSheetEntrys '// Master col of time sheet entries to help with saving changes / deleting
  Private pPaySlipItems As colPaySlipItems


  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pTimeSheetEntrys = New colTimeSheetEntrys
    pPaySlipItems = New colPaySlipItems
    pRTISGlobal = rRTISGlobal
  End Sub

  Public ReadOnly Property DBConn As RTIS.DataLayer.clsDBConnBase
    Get
      Return pDBConn
    End Get
  End Property

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Sub LoadRefs()

  End Sub

  Public Function IsDirty() As Boolean
    Dim mIsDirty As Boolean = True
    mIsDirty = pTimeSheetEntrys.IsDirty
    Return mIsDirty
  End Function

  Public Property PeriodStartDate As DateTime
    Get
      Return pPeriodStartDate
    End Get
    Set(value As DateTime)
      pPeriodStartDate = value
    End Set
  End Property

  Public Property PeriodType As ePayPeriodType
    Get
      Return pPeriodType
    End Get
    Set(value As ePayPeriodType)
      pPeriodType = value
    End Set
  End Property

  Public Property StandardStartDate As DateTime
    Get
      Return pStandardStartDate
    End Get
    Set(value As DateTime)
      pStandardStartDate = value
    End Set
  End Property

  Public Property StandardEndDate As DateTime
    Get
      Return pStandardEndDate
    End Get
    Set(value As DateTime)
      pStandardEndDate = value
    End Set
  End Property

  Public Property OverTimeStartDate As DateTime
    Get
      Return pOverTimeStartDate
    End Get
    Set(value As DateTime)
      pOverTimeStartDate = value
    End Set
  End Property

  Public Property OverTimeEndDate As DateTime
    Get
      Return pOverTimeEndDate
    End Get
    Set(value As DateTime)
      pOverTimeEndDate = value
    End Set
  End Property

  Public Property Employee As dmEmployeeSM
    Get
      Return pEmployee
    End Get
    Set(value As dmEmployeeSM)
      pEmployee = value
    End Set
  End Property


  Public ReadOnly Property PaySlipItems As colPaySlipItems
    Get
      Return pPaySlipItems
    End Get
  End Property

  Public Sub SetCurrentEmployee(ByVal vEmployeeID As Integer)
    Dim mEmps As RTIS.ERPCore.colEmployees
    mEmps = pRTISGlobal.RefLists.RefIList(appRefLists.Employees)
    pEmployee = mEmps.ItemFromKey(vEmployeeID)
  End Sub

  Public Sub LoadPaySlipItems()
    Dim mStartDateLoad As Date
    Dim mEndDateLoad As Date
    Dim mCurDay As Date
    Dim mPSI As clsPaySlipItem

    If RTIS.CommonVB.clsGeneralA.IsBlankDate(pStandardStartDate) = False Then
      mStartDateLoad = pStandardStartDate
    End If
    If RTIS.CommonVB.clsGeneralA.IsBlankDate(pOverTimeStartDate) = False Then
      If pOverTimeStartDate < mStartDateLoad Then
        mStartDateLoad = pOverTimeStartDate
      End If
    End If

    If RTIS.CommonVB.clsGeneralA.IsBlankDate(pStandardEndDate) = False Then
      mEndDateLoad = pStandardEndDate
    End If
    If RTIS.CommonVB.clsGeneralA.IsBlankDate(pOverTimeEndDate) = False Then
      If pOverTimeEndDate > mEndDateLoad Then
        mEndDateLoad = pOverTimeEndDate
      End If
    End If

    pPaySlipItems.Clear()
    If clsGeneralA.IsBlankDate(mStartDateLoad) = False And clsGeneralA.IsBlankDate(mEndDateLoad) = False Then
      mCurDay = mStartDateLoad.Date
      Do While mCurDay <= mEndDateLoad
        mPSI = New clsPaySlipItem
        mPSI.ItemDate = mCurDay
        If mPSI.ItemDate >= pStandardStartDate And mPSI.ItemDate <= pStandardEndDate Then
          mPSI.InStandardRange = True
        End If
        If mPSI.ItemDate >= pOverTimeStartDate And mPSI.ItemDate <= pOverTimeEndDate Then
          mPSI.InOverTimeRange = True
        End If

        pPaySlipItems.Add(mPSI)

        mCurDay = mCurDay.AddDays(1)
      Loop
    End If

    '//Now load the time sheet entries
    LoadTimeSheetEntrys(mStartDateLoad, mEndDateLoad)

    '// Now populate the pay slip items from the time sheet entries
    PopulatePaySlipItemsFromTSEs()

    '//Round the hours entries
    For Each mPSI In pPaySlipItems
      mPSI.StandardHours = Math.Round(mPSI.StandardHours * 4, 0, MidpointRounding.AwayFromZero) / 4
    Next

  End Sub

  Private Sub LoadTimeSheetEntrys(ByVal vStartDateLoad As Date, ByVal vEndDateLoad As Date)
    Dim mdso As dsoHR
    Try
      mdso = New dsoHR(pDBConn)
      pTimeSheetEntrys.Clear()
      If pEmployee IsNot Nothing And clsGeneralA.IsBlankDate(vStartDateLoad) = False And clsGeneralA.IsBlankDate(vEndDateLoad) = False Then
        mdso.LoadTimeSheetEntrysEmpIDDateRange(pTimeSheetEntrys, pEmployee.EmployeeID, vStartDateLoad, vEndDateLoad)
      Else
        pTimeSheetEntrys.IsDirty = False
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub PopulatePaySlipItemsFromTSEs()
    Dim mPSI As clsPaySlipItem
    Dim mStdHrs As Decimal
    Dim mOTHrs As Decimal
    For Each mTSE As dmTimeSheetEntry In pTimeSheetEntrys
      mStdHrs = 0
      mOTHrs = 0
      mPSI = pPaySlipItems.ItemFromDate(mTSE.StartTime.Date)
      If mPSI Is Nothing Then
        mPSI = New clsPaySlipItem
        mPSI.ItemDate = mTSE.StartTime.Date
      End If
      If clsGeneralA.IsBlankDate(mPSI.StartTime) Then
        mPSI.StartTime = mTSE.StartTime
      ElseIf mTSE.StartTime < mPSI.StartTime Then
        mPSI.StartTime = mTSE.StartTime
      End If
      If mTSE.EndTime > mPSI.EndTime Then mPSI.EndTime = mTSE.EndTime
      Select Case mTSE.TimeSheetEntryTypeID
        Case eEmployeeTimeLogType.WorksOrder, eEmployeeTimeLogType.Maintenance
          mStdHrs = Math.Max(0, ((mTSE.Duration * 60) - mTSE.OverTimeMinutes) / 60.0)
          mOTHrs = mTSE.OverTimeMinutes / 60.0
      End Select
      mPSI.StandardHours = mPSI.StandardHours + mStdHrs
      mPSI.OverTimeHours = mPSI.OverTimeHours + mOTHrs
    Next
  End Sub

  Public Sub ResetDefaultDates()
    If clsGeneralA.IsBlankDate(pPeriodStartDate) = False Then
      Select Case pPeriodType
        Case ePayPeriodType.Quincena
          If pPeriodStartDate.Day < 15 Then
            pStandardStartDate = New Date(pPeriodStartDate.Year, pPeriodStartDate.Month, 1)
            pStandardEndDate = pStandardStartDate.AddDays(14)
            pOverTimeStartDate = clsSMSharedFuncs.GetOverTimeCutOffDate(pStandardStartDate).AddDays(1)
            pOverTimeEndDate = clsSMSharedFuncs.GetOverTimeCutOffDate(pStandardStartDate.AddDays(15))
          Else
            pStandardStartDate = New Date(pPeriodStartDate.Year, pPeriodStartDate.Month, 15)
            pStandardEndDate = New Date(pPeriodStartDate.Year, pPeriodStartDate.Month, 1).AddMonths(1).AddDays(-1)
            pOverTimeStartDate = clsSMSharedFuncs.GetOverTimeCutOffDate(pStandardStartDate)
            pOverTimeEndDate = clsSMSharedFuncs.GetOverTimeCutOffDate(New Date(pPeriodStartDate.Year, pPeriodStartDate.Month, 1).AddMonths(1))
          End If
        Case ePayPeriodType.Month
          pStandardStartDate = New Date(pPeriodStartDate.Year, pPeriodStartDate.Month, 1)
          pStandardEndDate = pStandardStartDate.AddMonths(1).AddDays(-1)
          pOverTimeStartDate = clsSMSharedFuncs.GetOverTimeCutOffDate(pStandardStartDate).AddDays(1)
          pOverTimeEndDate = clsSMSharedFuncs.GetOverTimeCutOffDate(pStandardStartDate.AddMonths(1))
      End Select
    End If
  End Sub

End Class
