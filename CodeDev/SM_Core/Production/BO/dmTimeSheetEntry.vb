''Class Definition - TimeSheetEntry (to TimeSheetEntry)'Generated from Table:TimeSheetEntry
Imports RTIS.CommonVB

Public Class dmTimeSheetEntry : Inherits dmBase
  Private pTimeSheetEntryID As Int32
  Private pTimeSheetEntryTypeID As Int32
  Private pEmployeeID As Int32
  Private pWorkOrderID As Int32
  Private pWorkCentreID As Int32
  Private pStartTime As DateTime
  Private pEndTime As DateTime
  Private pNote As String

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
    TimeSheetEntryID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmTimeSheetEntry)
      .TimeSheetEntryID = TimeSheetEntryID
      .TimeSheetEntryTypeID = TimeSheetEntryTypeID
      .EmployeeID = EmployeeID
      .WorkOrderID = WorkOrderID
      .StartTime = StartTime
      .EndTime = EndTime
      .Note = Note
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property TimeSheetEntryID() As Int32
    Get
      Return pTimeSheetEntryID
    End Get
    Set(ByVal value As Int32)
      If pTimeSheetEntryID <> value Then IsDirty = True
      pTimeSheetEntryID = value
    End Set
  End Property

  Public Property TimeSheetEntryTypeID() As Int32
    Get
      Return pTimeSheetEntryTypeID
    End Get
    Set(ByVal value As Int32)
      If pTimeSheetEntryTypeID <> value Then IsDirty = True
      pTimeSheetEntryTypeID = value
    End Set
  End Property

  Public Property EmployeeID() As Int32
    Get
      Return pEmployeeID
    End Get
    Set(ByVal value As Int32)
      If pEmployeeID <> value Then IsDirty = True
      pEmployeeID = value
    End Set
  End Property

  Public Property WorkOrderID() As Int32
    Get
      Return pWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderID <> value Then IsDirty = True
      pWorkOrderID = value
    End Set
  End Property

  Public Property WorkCentreID() As Int32
    Get
      Return pWorkCentreID
    End Get
    Set(ByVal value As Int32)
      If pWorkCentreID <> value Then IsDirty = True
      pWorkCentreID = value
    End Set
  End Property

  Public Property StartTime() As DateTime
    Get
      Return pStartTime
    End Get
    Set(ByVal value As DateTime)
      If pStartTime <> value Then IsDirty = True
      pStartTime = value
    End Set
  End Property

  Public Property EndTime() As DateTime
    Get
      Return pEndTime
    End Get
    Set(ByVal value As DateTime)
      If pEndTime <> value Then IsDirty = True
      pEndTime = value
    End Set
  End Property

  Public ReadOnly Property Duration As Decimal
    Get
      Dim mRetVal As Decimal = 0
      If pStartTime <> New Date And pEndTime <> New Date Then
        mRetVal = Math.Round(DateDiff(DateInterval.Minute, pStartTime, pEndTime) / 60, 1)
      End If
      Return mRetVal
    End Get
  End Property

  Public Property Note() As String
    Get
      Return pNote
    End Get
    Set(ByVal value As String)
      If pNote <> value Then IsDirty = True
      pNote = value
    End Set
  End Property


End Class



''Collection Definition - TimeSheetEntry (to TimeSheetEntry)'Generated from Table:TimeSheetEntry

'Private pTimeSheetEntrys As colTimeSheetEntrys
'Public Property TimeSheetEntrys() As colTimeSheetEntrys
'  Get
'    Return pTimeSheetEntrys
'  End Get
'  Set(ByVal value As colTimeSheetEntrys)
'    pTimeSheetEntrys = value
'  End Set
'End Property

'  pTimeSheetEntrys = New colTimeSheetEntrys 'Add to New
'  pTimeSheetEntrys = Nothing 'Add to Finalize
'  .TimeSheetEntrys = TimeSheetEntrys.Clone 'Add to CloneTo
'  TimeSheetEntrys.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = TimeSheetEntrys.IsDirty 'Add to IsAnyDirty

Public Class colTimeSheetEntrys : Inherits colBase(Of dmTimeSheetEntry)

  Public Overrides Function IndexFromKey(ByVal vTimeSheetEntryID As Integer) As Integer
    Dim mItem As dmTimeSheetEntry
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.TimeSheetEntryID = vTimeSheetEntryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function IndexFromStartDateTime(ByVal vDateTime As Date) As Integer
    Dim mItem As dmTimeSheetEntry
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StartTime <= vDateTime And mItem.EndTime > vDateTime Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Function ItemEarlierSameDay(ByVal vDateTime As Date) As dmTimeSheetEntry
    Dim mRetVal As dmTimeSheetEntry = Nothing
    For Each mItem In MyBase.Items
      If mItem.EndTime.Date = vDateTime.Date Then
        If mItem.EndTime < vDateTime Then
          If mRetVal Is Nothing Then
            mRetVal = mItem
          Else
            If mItem.EndTime > mRetVal.EndTime Then
              mRetVal = mItem
            End If
          End If
        End If
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemLaterSameDay(ByVal vDateTime As Date) As dmTimeSheetEntry
    Dim mRetVal As dmTimeSheetEntry = Nothing
    For Each mItem In MyBase.Items
      If mItem.EndTime.Date = vDateTime.Date Then
        If mItem.StartTime > vDateTime Then
          If mRetVal Is Nothing Then
            mRetVal = mItem
          Else
            If mItem.EndTime < mRetVal.EndTime Then
              mRetVal = mItem
            End If
          End If
        End If
      End If
    Next
    Return mRetVal
  End Function

  Public Function ItemFromStartDateTime(ByVal vDateTime As Date) As dmTimeSheetEntry
    Dim mRetVal As dmTimeSheetEntry = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromStartDateTime(vDateTime)
    If mIndex <> -1 Then
      mRetVal = Me.Items(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function ItemSpanning(ByVal vDateTime As Date) As dmTimeSheetEntry
    Dim mRetVal As dmTimeSheetEntry = Nothing
    For Each mItem In MyBase.Items
      If mItem.StartTime.Date = vDateTime.Date Then
        If mItem.StartTime <= vDateTime And mItem.EndTime >= vDateTime Then
          mRetVal = mItem
          Exit For
        End If
      End If
    Next
    Return mRetVal
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmTimeSheetEntry))
    MyBase.New(vList)
  End Sub

End Class

