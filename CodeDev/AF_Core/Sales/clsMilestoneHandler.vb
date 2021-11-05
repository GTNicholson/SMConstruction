Imports RTIS.CommonVB

Public Class clsMilestoneHandler

  Public Shared Sub UpdateSalesOrderPhaseMileStones(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vSalesOrderPhaseID As Integer, ByVal rRootSalesOrderPhaseMilesStoneEnum As Integer, ByVal vNewMilestoneTargetDate As Date, ByVal vNumManReqDays As Integer)
    Dim mdso As New dsoSalesOrder(rDBConn)
    Dim mColSalesOrderPhaseMilesStoneStatuss As New colSalesOrderPhaseMilestoneStatuss
    Dim mSalesOrderPhaseMilesStoneStatus As dmSalesOrderPhaseMilestoneStatus
    Dim mRootSalesOrderPhaseMilestone As dmSalesOrderPhaseMilestoneStatus
    Dim mHolidays As New colHolidays
    Dim mdsoAdmin As New dsoGeneral(rDBConn)

    '// Load the sales order phase milestones
    mdso.LoadSalesOrderPhaseMilestoneStatuss_By_Phase(mColSalesOrderPhaseMilesStoneStatuss, vSalesOrderPhaseID)

    '//Load Hollidays
    mdsoAdmin.LoadHolidays(mHolidays)

    '// create any that aren't there

    For Each mValueItem As clsValueItem In eSalesOrderPhaseMileStone.GetInstance.ValueItems
      mSalesOrderPhaseMilesStoneStatus = mColSalesOrderPhaseMilesStoneStatuss.ItemFromMilestoneENUM(mValueItem.ItemValue)
      If mSalesOrderPhaseMilesStoneStatus Is Nothing Then
        mSalesOrderPhaseMilesStoneStatus = New dmSalesOrderPhaseMilestoneStatus
        mSalesOrderPhaseMilesStoneStatus.MilestoneENUM = mValueItem.ItemValue
        mSalesOrderPhaseMilesStoneStatus.SalesOrderPhaseID = vSalesOrderPhaseID
        mSalesOrderPhaseMilesStoneStatus.Status = eMilestoneStatus.Pending
        mColSalesOrderPhaseMilesStoneStatuss.Add(mSalesOrderPhaseMilesStoneStatus)
      End If
    Next
    '// find the due on site one and fill in the vdueonsitedate as the target date

    mRootSalesOrderPhaseMilestone = mColSalesOrderPhaseMilesStoneStatuss.ItemFromMilestoneENUM(rRootSalesOrderPhaseMilesStoneEnum)

    If mRootSalesOrderPhaseMilestone IsNot Nothing Then
      '// special case for Delivery to seite

      mRootSalesOrderPhaseMilestone.TargetDate = vNewMilestoneTargetDate

      '// calle reset planned dates
      ''ResetPlannedDates(mColSalesOrderPhaseMilesStoneStatuss, mRootSalesOrderPhaseMilesStone, mHolidays, vNumApprovedDays)
      CascadeMilestoneDependentDates(mColSalesOrderPhaseMilesStoneStatuss, mRootSalesOrderPhaseMilestone, mHolidays, vNumManReqDays)

    End If
    '// save the updated milestones
    mdso.SaveSalesOrderPhaseMilestoneStatusCollection(mColSalesOrderPhaseMilesStoneStatuss, vSalesOrderPhaseID)

  End Sub

  Public Shared Sub CascadeMilestoneDependentDates(ByRef rMileStones As colSalesOrderPhaseMilestoneStatuss, ByRef rModifiedMilestone As dmSalesOrderPhaseMilestoneStatus, ByRef rHolidays As colHolidays, ByVal vNumManReqDays As Integer)
    Dim mMileStoneDef As clsEnumSalesOrderPhaseMilestone
    Dim mNewPlannedDate As Date
    Dim mDependentOnDate As Date
    Dim mNumDays As Integer
    Dim mNumDaysOffset As Integer
    Dim mDep As clsMilestoneDependentOn

    For Each mSOPMS As dmSalesOrderPhaseMilestoneStatus In rMileStones
      If clsGeneralA.IsBlankDate(mSOPMS.ActualDate) = True Then
        mMileStoneDef = eSalesOrderPhaseMileStone.GetInstance.ItemFromKey(mSOPMS.MilestoneENUM)
        '// check through to see if this milstone is dependent on the changing one
        mDep = mMileStoneDef.DependencyMilestones.ItemFromEnum(rModifiedMilestone.MilestoneENUM)
        If mDep IsNot Nothing Then
          If mDep.OverideOnActual = True And clsGeneralA.IsBlankDate(rModifiedMilestone.ActualDate) = False Then
            mDependentOnDate = rModifiedMilestone.ActualDate
          Else
            mDependentOnDate = rModifiedMilestone.TargetDate
          End If


          If mDep.NumberOfDays <= 0 Then
            mNumDays = mDep.NumberOfDays * -1
            mNumDays = mNumDays + mNumDaysOffset
            mNewPlannedDate = rHolidays.CalcDate(mDependentOnDate, mNumDays, True)
          Else
            mNumDays = mDep.NumberOfDays
            mNumDays = mNumDays - mNumDaysOffset
            mNewPlannedDate = rHolidays.CalcDate(mDependentOnDate, mNumDays, False)
          End If
          mSOPMS.TargetDate = mNewPlannedDate
          CascadeMilestoneDependentDates(rMileStones, mSOPMS, rHolidays, vNumManReqDays)
        End If
      End If
    Next
  End Sub

  Public Shared Sub UpdateSingleSalesOrderPhaseMileStoneFromDependentOns(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByVal vSalesOrderPhaseID As Integer, ByRef rRootSalesOrderPhaseMilesStone As dmSalesOrderPhaseMilestoneStatus, ByVal vNumManReqDays As Integer)
    Dim mdso As New dsoSalesOrder(rDBConn)
    Dim mColSalesOrderPhaseMilesStoneStatuss As New colSalesOrderPhaseMilestoneStatuss
    Dim mSalesOrderPhaseMilesStoneStatus As dmSalesOrderPhaseMilestoneStatus
    Dim mHolidays As New colHolidays
    Dim mdsoAdmin As New dsoGeneral(rDBConn)

    '// Load the sales order phase milestones
    mdso.LoadSalesOrderPhaseMilestoneStatuss_By_Phase(mColSalesOrderPhaseMilesStoneStatuss, vSalesOrderPhaseID)

    '//Load Hollidays
    mdsoAdmin.LoadHolidays(mHolidays)

    '// create any that aren't there

    For Each mValueItem As clsValueItem In eSalesOrderPhaseMileStone.GetInstance.ValueItems
      mSalesOrderPhaseMilesStoneStatus = mColSalesOrderPhaseMilesStoneStatuss.ItemFromMilestoneENUM(mValueItem.ItemValue)
      If mSalesOrderPhaseMilesStoneStatus Is Nothing Then
        mSalesOrderPhaseMilesStoneStatus = New dmSalesOrderPhaseMilestoneStatus
        mSalesOrderPhaseMilesStoneStatus.MilestoneENUM = mValueItem.ItemValue
        mSalesOrderPhaseMilesStoneStatus.SalesOrderPhaseID = vSalesOrderPhaseID
        mSalesOrderPhaseMilesStoneStatus.Status = eMilestoneStatus.Pending
        mColSalesOrderPhaseMilesStoneStatuss.Add(mSalesOrderPhaseMilesStoneStatus)
      End If
    Next
    '// find the due on site one and fill in the vdueonsitedate as the target date

    If rRootSalesOrderPhaseMilesStone IsNot Nothing Then

      '// calle reset planned dates
      RefreshMilestonePlannedDate(mColSalesOrderPhaseMilesStoneStatuss, rRootSalesOrderPhaseMilesStone, mHolidays, vNumManReqDays)
    End If
    '// save the updated milestones
    mdso.SaveSalesOrderPhaseMilestoneStatusCollection(mColSalesOrderPhaseMilesStoneStatuss, vSalesOrderPhaseID)

  End Sub


  Public Shared Sub RefreshMilestonePlannedDate(ByRef rMileStones As colSalesOrderPhaseMilestoneStatuss, ByRef rMileStone As dmSalesOrderPhaseMilestoneStatus, ByRef rHolidays As colHolidays, ByVal vNumManReqDays As Integer)
    Dim mMileStoneDef As clsEnumSalesOrderPhaseMilestone
    Dim mNewPlannedDate As Date
    Dim mDependentOnDate As Date
    Dim mNumDays As Integer
    Dim mNumDaysOffset As Integer
    Dim mDep As clsMilestoneDependentOn
    Dim mDepMS As dmSalesOrderPhaseMilestoneStatus

    If clsGeneralA.IsBlankDate(rMileStone.ActualDate) = True Then
      rMileStone.TargetDate = New Date
      mMileStoneDef = eSalesOrderPhaseMileStone.GetInstance.ItemFromKey(rMileStone.MilestoneENUM)
      For Each mDep In mMileStoneDef.DependencyMilestones
        mDepMS = rMileStones.ItemFromMilestoneENUM(mDep.DependentOnEnum)
        If mDep.OverideOnActual = True And clsGeneralA.IsBlankDate(mDepMS.ActualDate) = False Then
          mDependentOnDate = mDepMS.ActualDate
        Else
          mDependentOnDate = mDepMS.TargetDate
        End If


        If mDep.NumberOfDays <= 0 Then
          mNumDays = mDep.NumberOfDays * -1
          mNumDays = mNumDays + mNumDaysOffset
          mNewPlannedDate = rHolidays.CalcDate(mDependentOnDate, mNumDays, True)
        Else
          mNumDays = mDep.NumberOfDays
          mNumDays = mNumDays - mNumDaysOffset
          mNewPlannedDate = rHolidays.CalcDate(mDependentOnDate, mNumDays, False)
        End If
        If clsGeneralA.IsBlankDate(mNewPlannedDate) = False Then
          If clsGeneralA.IsBlankDate(rMileStone.TargetDate) Then
            rMileStone.TargetDate = mNewPlannedDate
          ElseIf mNewPlannedDate < rMileStone.TargetDate Then
            rMileStone.TargetDate = mNewPlannedDate
          End If
        End If
      Next
    End If

  End Sub


  Public Shared Sub ResetPlannedDates(ByRef rMileStones As colSalesOrderPhaseMilestoneStatuss, ByRef rRootMilestone As dmSalesOrderPhaseMilestoneStatus, ByRef rHollidays As colHolidays, ByVal vNumManReqDays As Integer)
    Dim mResolvedMilestones As New List(Of dmSalesOrderPhaseMilestoneStatus)
    Dim mMileStoneDef As clsEnumSalesOrderPhaseMilestone
    Dim mNewPlannedDate As Date
    Dim mDepMS As dmSalesOrderPhaseMilestoneStatus
    Dim mNumDays As Integer


    mResolvedMilestones.Add(rRootMilestone)

    Do While mResolvedMilestones.Count <> rMileStones.Count
      For Each mSOPMS As dmSalesOrderPhaseMilestoneStatus In rMileStones
        mNewPlannedDate = New Date
        If RTIS.CommonVB.clsGeneralA.IsBlankDate(mSOPMS.ActualDate) = False Then
          mResolvedMilestones.Add(mSOPMS)
        Else
          mMileStoneDef = eSalesOrderPhaseMileStone.GetInstance.ItemFromKey(mSOPMS.MilestoneENUM)
          ''If mMileStoneDef.ItemValue = eSalesOrderPhaseMileStone.DeliveryToSiteDate Then
          ''  mNewPlannedDate = rRootMilestone.TargetDate
          ''  'mSOPMS.TargetDate = 
          ''End If


          For Each mDep As clsMilestoneDependentOn In mMileStoneDef.DependencyMilestones
            '// find the sales order phase milestone
            mDepMS = rMileStones.ItemFromMilestoneENUM(mDep.DependentOnEnum)
            '// check to see that it has already been resolved
            If mResolvedMilestones.Contains(mDepMS) Then
              '// calculate a plan date from the sales order phase milestone plan date or actual date (if it is not blank)
              '// If this Is earlier than the current proposed mnewplanneddate then reset the mnewplanned date


              If mDep.NumberOfDays < 0 Then
                mNumDays = mDep.NumberOfDays * -1
                If clsGeneralA.IsBlankDate(mNewPlannedDate) = True Or mNewPlannedDate > rHollidays.CalcDate(mDepMS.TargetDate, mNumDays, True) Then
                  mNewPlannedDate = rHollidays.CalcDate(mDepMS.TargetDate, mNumDays, True)
                End If


              Else
                mNumDays = mDep.NumberOfDays
                If clsGeneralA.IsBlankDate(mNewPlannedDate) = True Or mNewPlannedDate > rHollidays.CalcDate(mDepMS.TargetDate, mNumDays, True) Then
                  mNewPlannedDate = rHollidays.CalcDate(mDepMS.TargetDate, mNumDays, False)
                End If

              End If



            End If
          Next
          'If Not mSOPMS.MilestoneENUM = eSalesOrderPhaseMileStone.DeliveryToSiteDate Then


          '  mSOPMS.TargetDate = mNewPlannedDate


          '  mResolvedMilestones.Add(mSOPMS)
          'End If



        End If
      Next
    Loop

  End Sub

End Class
