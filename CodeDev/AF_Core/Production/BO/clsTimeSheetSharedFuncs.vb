﻿Public Class clsTimeSheetSharedFuncs

  Public Shared Function getOverTimeMinutes(ByRef rTimeSheetEntry As dmTimeSheetEntry, ByRef rShift As dmShift, ByVal Optional vOverTime As Decimal = 0) As Integer
    Dim mretVal As Integer
    Dim mSD As dmShiftDetails = Nothing
    Dim mStartMinutes As Int32
    Dim mEndMinutes As Int32
    Dim mTotalMinutes1 As Int32
    Dim mTotalMinutes2 As Int32
    Dim mShiftFound As Boolean
    Dim mBeforeOverTimeSheetCollection As New colTimeSheetEntrys
    Dim mAfterOverTimeSheetCollection As New colTimeSheetEntrys

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
      ''Check first if there's only 1 record entered as OverTime

      mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

      If mStartMinutes = 60 And rTimeSheetEntry.StartTime.TimeOfDay < mSD.StartTime.TimeOfDay Then
        mretVal = mStartMinutes

      ElseIf mStartMinutes > 60 And rTimeSheetEntry.EndTime.TimeOfDay < mSD.StartTime.TimeOfDay Then
        mretVal = mStartMinutes

      ElseIf mStartMinutes > 60 And DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString)) > 0 Then
        mretVal = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))

      End If

      mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

      If mEndMinutes >= 60 And rTimeSheetEntry.StartTime.TimeOfDay >= mSD.EndTime.TimeOfDay Then
        mretVal = mEndMinutes


      End If

      If mretVal = 0 Then

        mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))

        If mStartMinutes > 0 Then

          If rTimeSheetEntry.StartTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" Then
            mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))
            mTotalMinutes1 = mStartMinutes
          ElseIf rTimeSheetEntry.StartTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay < mSD.StartTime.TimeOfDay Then
            mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

            If vOverTime > 0 Then
              mStartMinutes = mStartMinutes
            End If

            mTotalMinutes1 = mStartMinutes
          ElseIf rTimeSheetEntry.StartTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay >= mSD.StartTime.TimeOfDay Then
            mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))

            If vOverTime > 0 Then
              mStartMinutes = mStartMinutes
            End If
            mTotalMinutes1 = mStartMinutes

          ElseIf rTimeSheetEntry.StartTime.TimeOfDay.ToString <> "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay >= mSD.StartTime.TimeOfDay Then
            mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))

            If vOverTime > 0 Then
              mStartMinutes = mStartMinutes
            End If
            mTotalMinutes1 = mStartMinutes

          ElseIf rTimeSheetEntry.StartTime.TimeOfDay.ToString <> "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" Then
            mStartMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(mSD.StartTime.TimeOfDay.ToString))

            mTotalMinutes1 = mStartMinutes

          End If

        Else
          mTotalMinutes1 = 0
        End If

        mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(mSD.EndTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

        If mEndMinutes > 0 Then

          If rTimeSheetEntry.EndTime.TimeOfDay.ToString <> "00:00:00" And rTimeSheetEntry.StartTime.TimeOfDay > mSD.EndTime.TimeOfDay Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

            mTotalMinutes2 = mEndMinutes
          ElseIf rTimeSheetEntry.EndTime.TimeOfDay.ToString <> "00:00:00" And rTimeSheetEntry.StartTime.TimeOfDay < mSD.EndTime.TimeOfDay Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(mSD.EndTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.TimeOfDay.ToString))

            mTotalMinutes2 = mEndMinutes


          End If




        ElseIf mEndMinutes < 0 Then

          If rTimeSheetEntry.StartTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(mSD.EndTime.TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.AddMinutes(-1).TimeOfDay.ToString))
            mTotalMinutes2 = mEndMinutes + 1
          ElseIf rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.StartTime.TimeOfDay >= mSD.EndTime.TimeOfDay Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.AddMinutes(-1).TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.AddMinutes(-1).TimeOfDay.ToString))
            mTotalMinutes2 = mEndMinutes

          ElseIf rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.StartTime.TimeOfDay <= mSD.StartTime.TimeOfDay Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(mSD.EndTime.AddMinutes(-1).TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.AddMinutes(-1).TimeOfDay.ToString))
            mTotalMinutes2 = mEndMinutes

          ElseIf rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" And rTimeSheetEntry.StartTime.TimeOfDay <= mSD.EndTime.TimeOfDay Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(mSD.EndTime.AddMinutes(-1).TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.AddMinutes(-1).TimeOfDay.ToString))
            mTotalMinutes2 = mEndMinutes

          ElseIf rTimeSheetEntry.StartTime.TimeOfDay.ToString <> "00:00:00" And rTimeSheetEntry.EndTime.TimeOfDay.ToString = "00:00:00" Then
            mEndMinutes = DateDiff(DateInterval.Minute, DateTime.Parse(rTimeSheetEntry.StartTime.AddMinutes(-1).TimeOfDay.ToString), DateTime.Parse(rTimeSheetEntry.EndTime.AddMinutes(-1).TimeOfDay.ToString))
            mTotalMinutes2 = mEndMinutes

          End If

        Else
          mTotalMinutes2 = 0
        End If

        mretVal = mTotalMinutes1 + mTotalMinutes2

      End If


    End If



    'get the relevente day start and stop time for the shift
    'see if start time of entry is before the shift start time
    'see if the end time of entry is after the shift end time
    'add up the excess minutes
    Return mretVal
  End Function

End Class
