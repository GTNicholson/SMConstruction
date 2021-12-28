''Class Definition - Holiday (to Holiday)'Generated from Table:Holiday
Imports RTIS.CommonVB
Imports RTIS.CommonVB.clsGeneralA


Public Class dmHoliday : Inherits dmBase
  Private pHolidayID As Int32
  Private pHolidayDate As DateTime

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    HolidayID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmHoliday)
      .HolidayID = HolidayID
      .HolidayDate = HolidayDate
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property HolidayID() As Int32
    Get
      Return pHolidayID
    End Get
    Set(ByVal value As Int32)
      If pHolidayID <> value Then IsDirty = True
      pHolidayID = value
    End Set
  End Property

  Public Property HolidayDate() As DateTime
    Get
      Return pHolidayDate
    End Get
    Set(ByVal value As DateTime)
      If pHolidayDate <> value Then IsDirty = True
      pHolidayDate = value
    End Set
  End Property


End Class



''Collection Definition - Holiday (to Holiday)'Generated from Table:Holiday

'Private pHolidays As colHolidays
'Public Property Holidays() As colHolidays
'  Get
'    Return pHolidays
'  End Get
'  Set(ByVal value As colHolidays)
'    pHolidays = value
'  End Set
'End Property

'  pHolidays = New colHolidays 'Add to New
'  pHolidays = Nothing 'Add to Finalize
'  .Holidays = Holidays.Clone 'Add to CloneTo
'  Holidays.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Holidays.IsDirty 'Add to IsAnyDirty

Public Class colHolidays : Inherits colBase(Of dmHoliday)

  Public Overrides Function IndexFromKey(ByVal vHolidayID As Integer) As Integer
    Dim mItem As dmHoliday
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.HolidayID = vHolidayID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmHoliday))
    MyBase.New(vList)
  End Sub

  Public Function IndexFromDate(ByVal vHolidayDate As Date) As Integer
    Dim mItem As dmHoliday
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1

    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.HolidayDate.Date = vHolidayDate.Date Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function WorkHoursDiff(ByVal vStartDate As Date, ByVal vEndDate As Date) As Single
    Dim mHolDay As Integer
    Dim mTimeStart As TimeSpan
    Dim mTimeEnd As TimeSpan
    Dim mStartBeginTime As TimeSpan
    Dim mEndBeginTime As TimeSpan
    Dim mStartFinishTime As TimeSpan
    Dim mEndFinishTime As TimeSpan
    Dim mNormalHol As Integer
    Dim mFridayHol As Integer
    Dim mNormalDays As Integer
    Dim mFridays As Integer
    Dim mNormalWorkHours As Single
    Dim mFridayWorkHours As Single


    If Not IsBlankDate(vStartDate) And Not IsBlankDate(vEndDate) Then
      Select Case Weekday(vStartDate)
        Case vbSaturday, vbSunday
          mStartBeginTime = TimeSpan.Zero
          mStartFinishTime = TimeSpan.Zero
        Case vbFriday
          mStartBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeFri) ' CSng(CDate("07:00:00"))
          mStartFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeFri) 'CSng(CDate("15:00:00"))
        Case Else
          mStartBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeMT) ' CSng(CDate("07:00:00"))
          mStartFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeMT) 'CSng(CDate("18:00:00"))
      End Select
      Select Case Weekday(vEndDate)
        Case vbSaturday, vbSunday
          mEndBeginTime = TimeSpan.Zero
          mEndFinishTime = TimeSpan.Zero
        Case vbFriday
          mEndBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeFri) ' CSng(CDate("07:00:00"))
          mEndFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeFri) ' CSng(CDate("15:00:00"))
        Case Else
          mEndBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeMT) 'CSng(CDate("07:00:00"))
          mEndFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeMT) ' CSng(CDate("18:00:00"))
      End Select
      mNormalWorkHours = 11
      mFridayWorkHours = 8
      ''Limit the week days to be only measureable from 07:00 hrs until 18:00 hrs
      ''Ensure that the window between Friday 15:00 hrs and Monday 07:00 hrs is being excluded from the calculations for teh traffic lighting to reflect the true aspect of the delay being measures.

      'Check time element
      'If Time is before 07:00 then count a 7:00
      'If Time is after 18:00 hrs then count as 18:00 hrs
      ''mTimeStart = CSng(vStartDate) - Int(vStartDate)
      mTimeStart = vStartDate.TimeOfDay
      If mTimeStart < mStartBeginTime Then mTimeStart = mStartBeginTime
      If mTimeStart > mStartFinishTime Then mTimeStart = mStartFinishTime

      '' mTimeEnd = CSng(vEndDate - Int(vEndDate))
      mTimeEnd = vEndDate.TimeOfDay
      If mTimeEnd < mEndBeginTime Then mTimeEnd = mEndBeginTime
      If mTimeEnd > mEndFinishTime Then mTimeEnd = mEndFinishTime

      'If vStartDate is same day as vEndDate then just comare the hours
      If vStartDate.Date = vEndDate.Date Then
        WorkHoursDiff = (mTimeEnd - mTimeStart).TotalHours
      Else
        'Assume that either start or end date is not a holiday
        ''mHolDay = rFixedHolidays.DaysHolidayInRange(vStartDate + 1, vEndDate)
        ''WorkDayDiff = WeekDayDiff(vStartDate, vEndDate) - mHolDay
        If vEndDate.AddDays(-1) >= vStartDate.AddDays(1) Then
          Me.DayTypeHolidayInRange(vStartDate.AddDays(1), vEndDate.AddDays(-1), mNormalHol, mFridayHol)
        End If
        'Add on time remaining today and subtract time not included on last day

        WeekDayTypeDiff(vStartDate, vEndDate.AddDays(-1), mNormalDays, mFridays)  'Returns complete days

        WorkHoursDiff = ((mNormalDays - mNormalHol) * mNormalWorkHours) + ((mFridays - mFridayHol) * mFridayWorkHours) + (mStartFinishTime - mTimeStart).TotalHours + (mTimeEnd - mEndBeginTime).TotalHours
        ''Debug.Print "N:" & mNormalDays & " F:" & mFridays

      End If
    Else
      WorkHoursDiff = 0
    End If
    Return WorkHoursDiff
  End Function

  Public Sub DayTypeHolidayInRange(ByVal vDate1 As Date, ByVal vDate2 As Date, ByRef rNormalDay As Integer, ByRef rFriday As Integer)
    '' Relies on the Holidays being on order!
    Dim mHol As dmHoliday
    Dim mStartDate As Date
    Dim mEndDate As Date
    Dim mNormal As Integer
    Dim mFriday As Integer

    If vDate1 < vDate2 Then
      mStartDate = vDate1
      mEndDate = vDate2
    Else
      mStartDate = vDate2
      mEndDate = vDate1
    End If
    For Each mHol In Me
      If mHol.HolidayDate >= mStartDate Then
        If mHol.HolidayDate <= mEndDate Then
          Select Case Weekday(mHol.HolidayDate)
            Case vbSaturday, vbSunday

            Case vbFriday
              mFriday = mFriday + 1
            Case Else
              mNormal = mNormal + 1
          End Select
        Else
          Exit For
        End If
      End If
    Next

    rNormalDay = mNormal
    rFriday = mFriday
  End Sub

  Public Sub WeekDayTypeDiff(ByVal vStartDate As Date, ByVal vEndDate As Date, ByRef rNormalDays As Integer, ByRef rFridays As Integer)
    Dim mWeeks As Integer
    Dim mDays As Integer
    Dim mNewDate As Date
    Dim mOffsetStart As Integer
    Dim mOffsetEnd As Integer

    Dim mNOSStart As Integer
    Dim mNOSEnd As Integer
    Dim mFOSStart As Integer
    Dim mFOSEnd As Integer

    If Not IsBlankDate(vStartDate) And Not IsBlankDate(vEndDate) Then
      Select Case Weekday(vStartDate)
        Case vbSaturday
          vStartDate = vStartDate.AddDays(-1)
          mOffsetStart = 5
          mNOSStart = 4
          mFOSStart = 1
        Case vbSunday
          vStartDate = vStartDate.AddDays(-2)
          mOffsetStart = 5
          mNOSStart = 4
          mFOSStart = 1
        Case vbMonday
          mOffsetStart = 1
          mNOSStart = 1
          mFOSStart = 0

        Case vbTuesday
          mOffsetStart = 2
          mNOSStart = 2
          mFOSStart = 0
        Case vbWednesday
          mOffsetStart = 3
          mNOSStart = 3
          mFOSStart = 0

        Case vbThursday
          mOffsetStart = 4
          mNOSStart = 4
          mFOSStart = 0

        Case vbFriday
          mOffsetStart = 5
          mNOSStart = 4
          mFOSStart = 1

      End Select
      Select Case Weekday(vEndDate)
        Case vbSaturday
          vEndDate = vEndDate.AddDays(-1)
          mOffsetEnd = 5
          mNOSEnd = 4
          mFOSEnd = 1
        Case vbSunday
          vEndDate = vEndDate.AddDays(-2)
          mOffsetEnd = 5
          mNOSEnd = 4
          mFOSEnd = 1
        Case vbMonday
          mOffsetEnd = 1
          mNOSEnd = 1
          mFOSEnd = 0
        Case vbTuesday
          mOffsetEnd = 2
          mNOSEnd = 2
          mFOSEnd = 0
        Case vbWednesday
          mOffsetEnd = 3
          mNOSEnd = 3
          mFOSEnd = 0
        Case vbThursday
          mOffsetEnd = 4
          mNOSEnd = 4
          mFOSEnd = 0
        Case vbFriday
          mOffsetEnd = 5
          mNOSEnd = 4
          mFOSEnd = 1
      End Select
      mWeeks = DateDiff(DateInterval.WeekOfYear, vStartDate.Date, vEndDate.Date, FirstDayOfWeek.Monday)
      ''mDays = DateDiff("d", vStartDate, vEndDate, vbMonday)
      ''WeekDayDiff = mWeeks * 5 + mOffsetEnd - mOffsetStart

      rNormalDays = mWeeks * 4 + mNOSEnd - mNOSStart
      rFridays = mWeeks + mFOSEnd - mFOSStart

    Else
      rNormalDays = 0
      rFridays = 0
    End If

  End Sub

  Public Function WorkDaysDiff(ByVal vStartDate As Date, ByVal vEndDate As Date) As Single
    Dim mHolDay As Integer
    Dim mTimeStart As TimeSpan
    Dim mTimeEnd As TimeSpan
    Dim mStartBeginTime As TimeSpan
    Dim mEndBeginTime As TimeSpan
    Dim mStartFinishTime As TimeSpan
    Dim mEndFinishTime As TimeSpan
    Dim mNormalHol As Integer
    Dim mFridayHol As Integer
    Dim mNormalDays As Integer
    Dim mFridays As Integer
    Dim mNormalWorkHours As Single
    Dim mFridayWorkHours As Single

    If Not IsBlankDate(vStartDate) And Not IsBlankDate(vEndDate) Then
      Select Case Weekday(vStartDate)
        Case vbSaturday, vbSunday
          mStartBeginTime = TimeSpan.Zero
          mStartFinishTime = TimeSpan.Zero
        Case vbFriday
          mStartBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeFri) ' CSng(CDate("07:00:00"))
          mStartFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeFri) ' CSng(CDate("15:00:00"))
        Case Else
          mStartBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeMT) 'CSng(CDate("07:00:00"))
          mStartFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeMT) ' CSng(CDate("17:00:00"))
      End Select
      Select Case Weekday(vEndDate)
        Case vbSaturday, vbSunday
          mEndBeginTime = TimeSpan.Zero
          mEndFinishTime = TimeSpan.Zero
        Case vbFriday
          mEndBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeFri) 'CSng(CDate("07:00:00"))
          mEndFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeFri) ' CSng(CDate("15:00:00"))
        Case Else
          mEndBeginTime = TimeSpan.Parse(clsConstants.cWorkBeginTimeMT) 'CSng(CDate("07:00:00"))
          mEndFinishTime = TimeSpan.Parse(clsConstants.cWorkEndTimeMT) 'CSng(CDate("17:00:00"))
      End Select
      mNormalWorkHours = 10
      mFridayWorkHours = 8
      ''Limit the week days to be only measureable from 07:00 hrs until 18:00 hrs
      ''Ensure that the window between Friday 15:00 hrs and Monday 07:00 hrs is being excluded from the calculations for teh traffic lighting to reflect the true aspect of the delay being measures.

      'Check time element
      'If Time is before 07:00 then count a 7:00
      'If Time is after 18:00 hrs then count as 18:00 hrs
      ''mTimeStart = CSng(vStartDate - Int(vStartDate))
      mTimeStart = vStartDate.TimeOfDay
      If mTimeStart < mStartBeginTime Then mTimeStart = mStartBeginTime
      If mTimeStart > mStartFinishTime Then mTimeStart = mStartFinishTime

      ''mTimeEnd = CSng(vEndDate - Int(vEndDate))
      mTimeEnd = vEndDate.TimeOfDay
      If mTimeEnd < mEndBeginTime Then mTimeEnd = mEndBeginTime
      If mTimeEnd > mEndFinishTime Then mTimeEnd = mEndFinishTime

      'If vStartDate is same day as vEndDate then just comare the hours
      If vStartDate.Date = vEndDate.Date Then
        WorkDaysDiff = (mTimeEnd - mTimeStart).TotalHours / 10
      Else
        'Assume that either start or end date is not a holiday
        ''mHolDay = rFixedHolidays.DaysHolidayInRange(vStartDate + 1, vEndDate)
        ''WorkDayDiff = WeekDayDiff(vStartDate, vEndDate) - mHolDay
        If vEndDate.AddDays(-1) >= vStartDate.AddDays(+1) Then
          Me.DayTypeHolidayInRange(vStartDate.AddDays(+1), vEndDate.AddDays(-1), mNormalHol, mFridayHol)
        End If
        'Add on time remaining today and subtract time not included on last day

        WeekDayTypeDiff(vStartDate, vEndDate.AddDays(-1), mNormalDays, mFridays)  'Returns complete days

        WorkDaysDiff = ((mNormalDays - mNormalHol)) + ((mFridays - mFridayHol)) + ((2.4 * (mStartFinishTime - mTimeStart).TotalHours + 2.4 * (mTimeEnd - mEndBeginTime).TotalHours) / 24)
        ''Debug.Print "N:" & mNormalDays & " F:" & mFridays

      End If
    Else
      WorkDaysDiff = 0
    End If
    Return WorkDaysDiff
  End Function
  Public Function DateAddWorkDays(rStartDate As Date, rPlanDays As Integer) As Date
    Dim mHolidays As colHolidays
    Dim mRetVal As Date
    Dim mCount As Long
    Dim mDate As Long
    Dim mTime As Long
    Dim mHours As Integer

    mRetVal = rStartDate
    For mCount = 1 To rPlanDays
      mRetVal = mRetVal.AddDays(+1)
      Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or Me.DateExists(mRetVal) <> 0
        mRetVal = mRetVal.AddDays(+1)
      Loop
    Next

    DateAddWorkDays = mRetVal
    Return DateAddWorkDays
  End Function

  Public Function DateAddWorkDaysDec(rStartDate As Date, rPlanDays As Decimal) As Date
    Dim mHolidays As colHolidays
    Dim mRetVal As Date
    Dim mCount As Long
    Dim mDate As Long
    Dim mTime As Long
    Dim mHours As Integer
    Dim mWholeDays As Integer
    Dim mPartDay As Single
    Dim mInitialTime As TimeSpan
    Dim mTimeToAddOn As TimeSpan
    Dim mAddADay As Boolean
    Dim mReqTime As TimeSpan
    Dim mDayStart As TimeSpan
    Dim mDayFinish As TimeSpan
    'Dim mTimeToAddOn As Single
    mWholeDays = Int(rPlanDays)
    mPartDay = rPlanDays - mWholeDays
    mRetVal = rStartDate
    For mCount = 1 To mWholeDays
      mRetVal = mRetVal.AddDays(1)
      Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or Me.DateExists(mRetVal) <> 0
        mRetVal = mRetVal.AddDays(1)
      Loop
    Next
    mInitialTime = rStartDate.TimeOfDay
    'If mPartDay > 0 Then
    mAddADay = False
    mTimeToAddOn = New TimeSpan(0, 0, Math.Round(mPartDay * 8 * 60 * 60, 0, MidpointRounding.AwayFromZero))
    If Weekday(mRetVal) = vbFriday Then 'Check what day
      mDayStart = TimeSpan.Parse(clsConstants.cWorkBeginTimeFri)
      mDayFinish = TimeSpan.Parse(clsConstants.cWorkEndTimeFri)
    Else
      mDayStart = TimeSpan.Parse(clsConstants.cWorkBeginTimeMT)
      mDayFinish = TimeSpan.Parse(clsConstants.cWorkEndTimeMT)
    End If
    If mInitialTime < mDayStart Then
      mReqTime = mDayStart.Add(mTimeToAddOn)
      If mReqTime > mDayFinish Then 'could happen on a Friday
        mAddADay = True
        mTimeToAddOn = mReqTime - mDayFinish
      End If
    ElseIf mInitialTime >= mDayFinish Then
      ''mInitialTime = mDayStart
      mAddADay = True
    ElseIf (mInitialTime + mTimeToAddOn) >= mDayFinish Then
      mAddADay = True
      ''mReqTime = mDayStart + mTimeToAddOn - mDayFinish + mInitialTime
      mTimeToAddOn = mTimeToAddOn - mDayFinish + mInitialTime
    Else
      mReqTime = mInitialTime + mTimeToAddOn
    End If
    If mAddADay Then
      Do While True
        mRetVal = mRetVal.AddDays(1)
        Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or Me.DateExists(mRetVal) <> 0
          mRetVal = mRetVal.AddDays(1)
        Loop
        If Weekday(mRetVal) = vbFriday Then 'Check what day
          mDayStart = TimeSpan.Parse(clsConstants.cWorkBeginTimeFri)
          mDayFinish = TimeSpan.Parse(clsConstants.cWorkEndTimeFri)
        Else
          mDayStart = TimeSpan.Parse(clsConstants.cWorkBeginTimeMT)
          mDayFinish = TimeSpan.Parse(clsConstants.cWorkEndTimeMT)
        End If
        mReqTime = (mDayStart + mTimeToAddOn)
        If mReqTime >= mDayFinish Then
          mTimeToAddOn = mReqTime - mDayFinish
        Else
          Exit Do
        End If
      Loop
    End If
    'Else
    '  mReqTime = mInitialTime
    'End If
    DateAddWorkDaysDec = (mRetVal.Date + mReqTime)
    Return DateAddWorkDaysDec

  End Function

  Public Function DateExists(rDate As Date) As Integer
    Dim mHoliday As dmHoliday
    Dim mRetVal As Boolean
    Dim mCount As Integer
    Dim mCompareDate As Date
    Dim mDate As Date

    mRetVal = False

    For Each mHoliday In Me
      mCount = mCount + 1
      mDate = Format(CDate(rDate), "dd/MM/yyyy")
      mCompareDate = Format(CDate(mHoliday.HolidayDate), "dd/MM/yyyy")
      If mCompareDate = mDate Then
        mRetVal = True
        Exit For
      End If
    Next
    If mRetVal = False Then
      mCount = 0
    End If
    DateExists = mCount
  End Function

  Public Function GetWorkingDays(rStartDate As Date, rEndDate As Date) As Integer
    Dim mRetVal As Integer
    Dim mDate As Date
    Dim mLoop As Integer
    Dim mDaysDifference As Integer

    If rStartDate <= rEndDate Then
      mDaysDifference = (rEndDate.Date - rStartDate.Date).Days
      For mLoop = 0 To mDaysDifference
        mDate = rStartDate.AddDays(mLoop)
        Debug.Print("GetWorkingDays " & mDate)
        If mDate.DayOfWeek = DayOfWeek.Sunday Or mDate.DayOfWeek = DayOfWeek.Saturday Or DateExists(mDate) <> 0 Then
          mRetVal = mRetVal
        Else
          mRetVal = mRetVal + 1
        End If
      Next
    Else
      mDaysDifference = (rStartDate.Date - rEndDate.Date).Days
      For mLoop = 0 To mDaysDifference
        mDate = rEndDate.AddDays(mLoop)
        If mDate.DayOfWeek = DayOfWeek.Sunday Or mDate.DayOfWeek = DayOfWeek.Saturday Or DateExists(mDate) <> 0 Then
          mRetVal = mRetVal
        Else
          mRetVal = mRetVal + 1
        End If
      Next
    End If

    GetWorkingDays = mRetVal

  End Function

  Public Function CalcDate(rStartDate As Date, rPlanDays As Long, Optional rBackward As Boolean = False) As Date
    Dim mHolidays As colHolidays
    Dim mRetVal As Date
    Dim mCount As Long
    Dim mDate As Long
    Dim mTime As Long
    Dim mHours As Integer



    mRetVal = rStartDate
    If rBackward Then
      For mCount = rPlanDays To 1 Step -1
        mRetVal = mRetVal.AddDays(-1)
        Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or DateExists(mRetVal) <> 0
          mRetVal = mRetVal.AddDays(-1)
        Loop
      Next
    Else
      For mCount = 1 To rPlanDays
        mRetVal = mRetVal.AddDays(1)
        Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or DateExists(mRetVal) <> 0
          mRetVal = mRetVal.AddDays(1)
        Loop
      Next
    End If

    CalcDate = mRetVal

  End Function

  Public Function CalcDate(rStartDate As Date, rPlanDays As Decimal, Optional rBackward As Boolean = False) As Date
    Dim mHolidays As colHolidays
    Dim mRetVal As Date
    Dim mCount As Long
    Dim mDate As Long
    Dim mTime As Long
    Dim mHours As Integer
    Dim mDaysRem As Decimal

    mDaysRem = rPlanDays

    mRetVal = rStartDate
    If rBackward Then

      Do While mDaysRem > 0
        If mDaysRem >= 1 Then
          mRetVal = mRetVal.AddDays(-1)
        Else
          mRetVal = mRetVal.AddDays(-mDaysRem)
        End If

        Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or DateExists(mRetVal) <> 0
          mRetVal = mRetVal.AddDays(-1)
        Loop
        mDaysRem = mDaysRem - 1
      Loop
    Else
      Do While mDaysRem > 0
        If mDaysRem >= 1 Then
          mRetVal = mRetVal.AddDays(1)
        Else
          mRetVal = mRetVal.AddDays(mDaysRem)
        End If

        Do While Weekday(mRetVal) = vbSunday Or Weekday(mRetVal) = vbSaturday Or DateExists(mRetVal) <> 0
          mRetVal = mRetVal.AddDays(1)
        Loop
        mDaysRem = mDaysRem - 1
      Loop
    End If

    CalcDate = mRetVal

  End Function


  Public Function GetHolidayText(rDate As Date) As String
    Dim mHolidayText As String = ""

    'New Year's Day
    If rDate.Day = 1 AndAlso rDate.Month = 1 Then
      mHolidayText = "New Year's Day"
    End If

    'Christmas
    If rDate.Day = 25 AndAlso rDate.Month = 12 Then
      mHolidayText = "Christmas Day"
    End If

    Return mHolidayText

  End Function
End Class

