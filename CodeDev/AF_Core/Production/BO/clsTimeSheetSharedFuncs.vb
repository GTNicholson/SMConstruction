Public Class clsTimeSheetSharedFuncs

  Public Shared Function getOverTimeMinutes(ByRef rTimeSheetEntry As dmTimeSheetEntry, ByRef rShift As dmShift) As Integer
    Dim mretVal As Integer
    Dim mSD As dmShiftDetails = Nothing
    Dim mStartMinutes As Int32
    Dim mEndMinutes As Int32
    Dim mTotalMinutes1 As Int32
    Dim mTotalMinutes2 As Int32
    Dim mShiftFound As Boolean

    For Each mSDtem As dmShiftDetails In rShift.ShifDetails

      If mSDtem.DayOfWeek = rTimeSheetEntry.StartTime.DayOfWeek Or mSDtem.DayOfWeek = rTimeSheetEntry.EndTime.DayOfWeek Then
        mSD = mSDtem
        mShiftFound = True
        Exit For
      End If

    Next

    If mSD IsNot Nothing Then
      If mSD.StartTime = New Date And mSD.EndTime = New Date Then
        mShiftFound = False
      End If
    End If

    If mShiftFound = False Then
      mretVal = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString)) ''- 60

      If mretVal < 0 Then
        mretVal = 0

      End If

    Else
      mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))

      If mStartMinutes > 0 Then
        mTotalMinutes1 = mStartMinutes
      ElseIf mStartMinutes < 0 Then
        mTotalMinutes1 = Math.Abs(mStartMinutes)
      Else
        mTotalMinutes1 = 0
      End If

      mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(mSD.EndTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

      If mEndMinutes > 0 Then
        mTotalMinutes2 = mEndMinutes
      ElseIf mEndMinutes < 0 Then
        mTotalMinutes2 = Math.Abs(mEndMinutes)
      Else
        mTotalMinutes2 = 0
      End If

      mretVal = mTotalMinutes1 + mTotalMinutes2
    End If



    'get the relevente day start and stop time for the shift
    'see if start time of entry is before the shift start time
    'see if the end time of entry is after the shift end time
    'add up the excess minutes
    Return mretVal
  End Function

End Class
