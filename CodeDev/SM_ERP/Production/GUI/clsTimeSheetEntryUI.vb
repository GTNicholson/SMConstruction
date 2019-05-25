Imports System.ComponentModel

Public Class clsTimeSheetEntryUI
  Private Shared pCurrentWorkCentreID As Integer

  Private pEmployeeID As Integer
  Private pWeekCommencing As DateTime
  Private pStartTime As DateTime
  Private pTimeSheetEntrys As colTimeSheetEntrys
  Private pWorkOrderInfos As colWorkOrderInfos

  Public Sub New(ByRef rTimeSheetEntrys As colTimeSheetEntrys, ByRef rWorkOrderInfos As colWorkOrderInfos)
    pTimeSheetEntrys = rTimeSheetEntrys
    pWorkOrderInfos = rWorkOrderInfos
  End Sub

  Public Shared Sub SetCurrentWorkCenterID(ByVal vWorkCentreID As Integer)
    pCurrentWorkCentreID = vWorkCentreID
  End Sub

  Public Property WeekCommencing As DateTime
    Get
      Return pWeekCommencing
    End Get
    Set(value As DateTime)
      pWeekCommencing = value
    End Set
  End Property

  Public Property StartTime As DateTime
    Get
      Return pStartTime
    End Get
    Set(value As DateTime)
      pStartTime = value
    End Set
  End Property

  Public Property EmployeeID As Integer
    Get
      Return pEmployeeID
    End Get
    Set(value As Integer)
      pEmployeeID = value
    End Set
  End Property

  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property

  Public Property Monday As String
    Get
      Return GetTimeSheetEntryStr(0)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(0, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Property Tuesday As String
    Get
      Return GetTimeSheetEntryStr(1)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(1, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Property Wednesday As String
    Get
      Return GetTimeSheetEntryStr(2)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(2, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Property Thursday As String
    Get
      Return GetTimeSheetEntryStr(3)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(3, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Property Friday As String
    Get
      Return GetTimeSheetEntryStr(4)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(4, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Property Saturday As String
    Get
      Return GetTimeSheetEntryStr(5)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(5, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Property Sunday As String
    Get
      Return GetTimeSheetEntryStr(6)
    End Get
    Set(value As String)
      SetTimeSheetEntryStr(6, value, pCurrentWorkCentreID)
    End Set
  End Property

  Public Function GetTimeSheetEntryCode(ByVal vDaysOffSet As Byte) As clsTimeSheetCode
    Dim mRetVal As clsTimeSheetCode = Nothing
    Dim mTimeSheetEntry As dmTimeSheetEntry
    Dim mStartTime As Date

    mStartTime = pWeekCommencing.Date.AddDays(vDaysOffSet) + pStartTime.TimeOfDay
    mTimeSheetEntry = pTimeSheetEntrys.ItemFromStartDateTime(mStartTime)

    If mTimeSheetEntry IsNot Nothing Then
      mRetVal = colTimeSheetCodes.GetInstance.ItemFromKey(mTimeSheetEntry.TimeSheetEntryTypeID)
    End If
    Return mRetVal
  End Function


  Private Function GetTimeSheetEntryStr(ByVal vDaysOffSet As Byte) As String
    Dim mRetVal As String = ""
    Dim mTimeSheetEntry As dmTimeSheetEntry
    Dim mStartTime As Date

    mStartTime = pWeekCommencing.Date.AddDays(vDaysOffSet) + pStartTime.TimeOfDay
    mTimeSheetEntry = pTimeSheetEntrys.ItemFromStartDateTime(mStartTime)

    If mTimeSheetEntry IsNot Nothing Then
      Select Case mTimeSheetEntry.TimeSheetEntryTypeID
        Case clsTimeSheetCode.cUnDefined
        Case clsTimeSheetCode.cWorkOrder
          Dim mWOI As clsWorkOrderInfo
          mWOI = pWorkOrderInfos.ItemFromWorkOrderID(mTimeSheetEntry.WorkOrderID)
          If mWOI IsNot Nothing Then
            mRetVal = mWOI.WorkOrder.WorkOrderNo
            mRetVal = mRetVal & "-" & RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eWorkCentre), CType(mTimeSheetEntry.WorkCentreID, eWorkCentre)).Substring(0, 1)
            mRetVal = mRetVal & vbCrLf & mWOI.WorkOrder.Description.Substring(0, Math.Min(10, Len(mWOI.WorkOrder.Description)))
          Else
            mRetVal = String.Format("O.T. {0} No Existe", mTimeSheetEntry.Note)
          End If
        Case Else
          Dim mCode As clsTimeSheetCode
          mCode = colTimeSheetCodes.GetInstance.ItemFromKey(mTimeSheetEntry.TimeSheetEntryTypeID)
          If mCode IsNot Nothing Then
            mRetVal = mCode.Description
          Else
            mRetVal = "Error"
          End If
      End Select
    End If
    Return mRetVal
  End Function

  Private Sub SetTimeSheetEntryStr(ByVal vDaysOffSet As Byte, ByVal vEnteredString As String, ByVal vWorkCentreID As Integer)
    Dim mExistingTSEntry As dmTimeSheetEntry
    Dim mNewTSEntry As dmTimeSheetEntry
    Dim mStartTime As Date


    '//Create a new proposed one to resolve the detail
    mStartTime = pWeekCommencing.Date.AddDays(vDaysOffSet) + pStartTime.TimeOfDay
    mNewTSEntry = New dmTimeSheetEntry
    mNewTSEntry.StartTime = mStartTime
    mNewTSEntry.EndTime = mStartTime.AddHours(1)
    mNewTSEntry.WorkCentreID = vWorkCentreID
    If IsNumeric(vEnteredString) Then
      EditTSEntryWorkOrder(mNewTSEntry, vEnteredString)
    Else
      EditTSEntryNonWorkOrder(mNewTSEntry, vEnteredString)
    End If

    '//now see if we should be editting existing and/or adding new

    mExistingTSEntry = pTimeSheetEntrys.ItemFromStartDateTime(mStartTime)


    If mExistingTSEntry Is Nothing Then
      '// if no match then check for previous in same day and if it is the same OT / type then extend previous Otherwise extend previous till this start and add new
      mExistingTSEntry = pTimeSheetEntrys.ItemEarlierSameDay(mStartTime)

      If mExistingTSEntry Is Nothing Then
        '//Check if the next one on the same day is the same type
        mExistingTSEntry = pTimeSheetEntrys.ItemLaterSameDay(mStartTime)
        If mExistingTSEntry Is Nothing Then
          '// just add new entry for this hour
          pTimeSheetEntrys.Add(mNewTSEntry)
        Else
          '//We have one later inthe day 
          If mExistingTSEntry.TimeSheetEntryTypeID = mNewTSEntry.TimeSheetEntryTypeID And mExistingTSEntry.WorkOrderID = mNewTSEntry.WorkOrderID Then
            '// if types and workorderid match then extend existing
            mExistingTSEntry.EndTime = mNewTSEntry.EndTime
          Else
            mExistingTSEntry.EndTime = mNewTSEntry.StartTime
            pTimeSheetEntrys.Add(mNewTSEntry)
          End If
        End If
      Else
          '//We have one ealier in the day 
          If mExistingTSEntry.TimeSheetEntryTypeID = mNewTSEntry.TimeSheetEntryTypeID And mExistingTSEntry.WorkOrderID = mNewTSEntry.WorkOrderID Then
          '// if types and workorderid match then extend existing
          mExistingTSEntry.EndTime = mNewTSEntry.EndTime
        Else
          mExistingTSEntry.EndTime = mNewTSEntry.StartTime
          pTimeSheetEntrys.Add(mNewTSEntry)
        End If
      End If
    Else
      If mExistingTSEntry.StartTime = mNewTSEntry.StartTime Then
        '// if this is the initial time sheet entry (start times equal) then set this one to the new OT /  type
        mExistingTSEntry.TimeSheetEntryTypeID = mNewTSEntry.TimeSheetEntryTypeID
        mExistingTSEntry.WorkOrderID = mNewTSEntry.WorkOrderID
        mExistingTSEntry.Note = mNewTSEntry.Note
      Else
        '// if this is not the first entry (this time is later than the timesheet entry) we need to curtail the timesheet entry and add a new one till the end of it
        mExistingTSEntry.EndTime = mNewTSEntry.StartTime
        pTimeSheetEntrys.Add(mNewTSEntry)
      End If
    End If


  End Sub

  Private Sub EditTSEntryWorkOrder(ByRef rTimeSheetEntry As dmTimeSheetEntry, ByVal vEnteredString As String)
    Dim mWOI As clsWorkOrderInfo

    rTimeSheetEntry.TimeSheetEntryTypeID = clsTimeSheetCode.cWorkOrder
    mWOI = pWorkOrderInfos.ItemFromWorkOrderNo(vEnteredString)
    If mWOI IsNot Nothing Then
      rTimeSheetEntry.WorkOrderID = mWOI.WorkOrderID
    Else
      rTimeSheetEntry.Note = vEnteredString
    End If

  End Sub
  Private Sub EditTSEntryNonWorkOrder(ByRef rTimeSheetEntry As dmTimeSheetEntry, ByVal vEnteredString As String)
    Dim mCode As clsTimeSheetCode

    mCode = colTimeSheetCodes.GetInstance.ItemFromKeyCode(vEnteredString.ToUpper)
    If mCode IsNot Nothing Then
      rTimeSheetEntry.TimeSheetEntryTypeID = mCode.PropertyENUM
    End If
  End Sub

End Class




Public Class colTimeSheetEntryUIs : Inherits BindingList(Of clsTimeSheetEntryUI)

  Public Function IndexFromEmpIDTime(ByVal vEmployeeID As Integer, ByVal vTime As DateTime) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1

    For Each mTE As clsTimeSheetEntryUI In Me.Items
      mIndex += 1
      If mTE.EmployeeID = vEmployeeID And mTE.StartTime = vTime Then
        mRetVal = mIndex
        Exit For
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromEmpIDTime(ByVal vEmployeeID As Integer, ByVal vTime As DateTime) As clsTimeSheetEntryUI
    Dim mRetVal As clsTimeSheetEntryUI = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromEmpIDTime(vEmployeeID, vTime)
    If mIndex <> -1 Then
      mRetVal = Me.Items(mIndex)
    End If
    Return mRetVal
  End Function

End Class