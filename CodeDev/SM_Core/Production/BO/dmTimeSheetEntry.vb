''Class Definition - TimeSheetEntry (to TimeSheetEntry)'Generated from Table:TimeSheetEntry
Imports RTIS.CommonVB

Public Class dmTimeSheetEntry : Inherits dmBase
  Private pTimeSheetEntryID As Int32
  Private pTimeSheetEntryTypeID As Int32
  Private pEmployeeID As Int32
  Private pWorkOrderID As Int32
  Private pStartTime As DateTime
  Private pEndTime As DateTime

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

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmTimeSheetEntry))
    MyBase.New(vList)
  End Sub

End Class

