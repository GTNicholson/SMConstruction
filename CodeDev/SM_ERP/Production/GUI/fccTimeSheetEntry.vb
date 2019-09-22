Imports RTIS.CommonVB

Public Class fccTimeSheetEntry
  Private pDBConn As RTIS.DataLayer.clsDBConnBase
  Private pRTISGlobal As AppRTISGlobal

  Private pWCDate As DateTime
  Private pStartTime As DateTime
  Private pEndTime As DateTime
  Private pEmployee As dmEmployeeSM
  Private pEmployees As RTIS.ERPCore.colEmployees
  Private pWorkCentreID As Integer

  Private pTimeSheetEntryUIs As colTimeSheetEntryUIs
  Private pTimeSheetEntrys As colTimeSheetEntrys '// Master col of time sheet entries to help with saving changes / deleting

  Private pWorkOrderInfos As colWorkOrderInfos

  Public Sub New(ByRef rDBConn As RTIS.DataLayer.clsDBConnBase, ByRef rRTISGlobal As AppRTISGlobal)
    pDBConn = rDBConn
    pTimeSheetEntrys = New colTimeSheetEntrys
    pTimeSheetEntryUIs = New colTimeSheetEntryUIs
    pRTISGlobal = rRTISGlobal
  End Sub

  Public ReadOnly Property RTISGlobal As AppRTISGlobal
    Get
      Return pRTISGlobal
    End Get
  End Property

  Public Sub LoadRefs()
    Dim mdso As dsoSales

    pEmployees = pRTISGlobal.RefLists.RefIList(appRefLists.Employees)

    mdso = New dsoSales(pDBConn)
    pWorkOrderInfos = New colWorkOrderInfos
    mdso.LoadWorkOrderInfos(pWorkOrderInfos, "")
  End Sub

  Public Property WCDate As DateTime
    Get
      Return pWCDate
    End Get
    Set(value As DateTime)
      pWCDate = value
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

  Public Property EndTime As DateTime
    Get
      Return pEndTime
    End Get
    Set(value As DateTime)
      pEndTime = value
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

  Public ReadOnly Property Employees As RTIS.ERPCore.colEmployees
    Get
      Return pEmployees
    End Get
  End Property

  Public Property WorkCentreID As Integer
    Get
      Return pWorkCentreID
    End Get
    Set(value As Integer)
      pWorkCentreID = value
      clsTimeSheetEntryUI.SetCurrentWorkCenterID(pWorkCentreID)
    End Set
  End Property

  Public ReadOnly Property TimeSheetEntryUIs As colTimeSheetEntryUIs
    Get
      Return pTimeSheetEntryUIs
    End Get
  End Property
  Public ReadOnly Property TimeSheetEntrys As colTimeSheetEntrys
    Get
      Return pTimeSheetEntrys
    End Get
  End Property


  Public Sub SetInitialDefaultValues()
    pWCDate = RTIS.CommonVB.libDateTime.MondayOfWeek(Now.Date)
    pStartTime = (New Date).AddHours(6)
    pEndTime = (New Date).AddHours(18)
    pWorkCentreID = eWorkCentre.Optimizacion
    clsTimeSheetEntryUI.SetCurrentWorkCenterID(pWorkCentreID)
  End Sub

  Public Sub SetCurrentEmployee(ByVal vEmployeeID As Integer)
    pEmployee = pEmployees.ItemFromKey(vEmployeeID)
  End Sub

  Public Sub LoadTimeSheetEntrys()
    Dim mdso As dsoHR
    Try

      mdso = New dsoHR(pDBConn)
      If pEmployee IsNot Nothing And pWCDate <> New Date Then
        mdso.LoadTimeSheetEntrysEmpIDWC(pTimeSheetEntrys, pEmployee.EmployeeID, pWCDate)
      End If
    Catch ex As Exception
      If clsErrorHandler.HandleError(ex, clsErrorHandler.PolicyDomainModel) Then Throw
    End Try

  End Sub

  Public Sub LoadTimeSheetEntryUIs()
    Dim mTime As DateTime
    Dim mEntry As clsTimeSheetEntryUI

    mTime = pStartTime
    If pEmployee IsNot Nothing Then
      Do While mTime <= pEndTime
        mEntry = pTimeSheetEntryUIs.ItemFromEmpIDTime(pEmployee.EmployeeID, mTime)
        If mEntry Is Nothing Then
          mEntry = New clsTimeSheetEntryUI(pTimeSheetEntrys, pWorkOrderInfos)
          mEntry.EmployeeID = pEmployee.EmployeeID
          mEntry.WeekCommencing = pWCDate
          mEntry.StartTime = mTime
          pTimeSheetEntryUIs.Add(mEntry)
        End If
          mTime = mTime.AddHours(1)
      Loop
    End If
  End Sub

  Public Sub SaveTimeSheetEntrys()
    Dim mDSO As dsoHR

    If pEmployee IsNot Nothing Then
      mDSO = New dsoHR(pDBConn)
      ''RefreshTimeSheetEntrys

      mDSO.SaveTimeSheetEntrys(pTimeSheetEntrys, pEmployee.EmployeeID)
    End If

  End Sub

  ''Public Sub RefreshTimeSheetEntrys()
  ''  Dim mTSEExisting As dmTimeSheetEntry

  ''  For Each mTSUI As clsTimeSheetEntryUI In pTimeSheetEntryUIs
  ''    For Each mTSE As dmTimeSheetEntry In mTSUI.TimeSheetEntrys
  ''      If mTSE.TimeSheetEntryID = 0 Then
  ''        pTimeSheetEntrys.Add(mTSE)
  ''      Else
  ''        '// Find and Update
  ''        mTSEExisting = pTimeSheetEntrys.ItemFromKey(mTSE.TimeSheetEntryID)
  ''        If mTSEExisting IsNot Nothing Then
  ''          mTSEExisting.WorkOrderID = mTSE.WorkOrderID
  ''          mTSEExisting.StartTime = mTSE.StartTime
  ''          mTSEExisting.EndTime = mTSE.EndTime
  ''          mTSEExisting.TimeSheetEntryTypeID = mTSE.TimeSheetEntryTypeID
  ''          mTSEExisting.Note = mTSE.Note
  ''        End If
  ''      End If
  ''    Next
  ''  Next

  ''  'Now Check for entries that need removed
  ''  For mLoop = pTimeSheetEntrys.Count - 1 To 0 Step -1
  ''    Dim mFound = False
  ''    For Each mTSUI As clsTimeSheetEntryUI In pTimeSheetEntryUIs
  ''      For Each mTSE As dmTimeSheetEntry In mTSUI.TimeSheetEntrys
  ''        If mTSE.TimeSheetEntryID = pTimeSheetEntrys(mLoop).TimeSheetEntryID Then
  ''          mFound = True
  ''          Exit For
  ''        End If
  ''      Next
  ''      If mFound Then Exit For
  ''    Next
  ''    If mFound = False Then
  ''      pTimeSheetEntrys.RemoveAt(mLoop)
  ''    End If
  ''  Next


  ''End Sub

End Class
