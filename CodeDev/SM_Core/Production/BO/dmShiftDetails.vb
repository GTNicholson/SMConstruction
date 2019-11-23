''Class Definition - ShiftDetails (to ShiftDetails)'Generated from Table:ShiftDetails
Imports RTIS.CommonVB

Public Class dmShiftDetails : Inherits dmBase
  Private pShiftDetailID As Int32
  Private pShiftID As Int32
  Private pDayOfWeek As Byte
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
    ShiftDetailID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmShiftDetails)
      .ShiftDetailID = ShiftDetailID
      .ShiftID = ShiftID
      .DayOfWeek = DayOfWeek
      .StartTime = StartTime
      .EndTime = EndTime
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ShiftDetailID() As Int32
    Get
      Return pShiftDetailID
    End Get
    Set(ByVal value As Int32)
      If pShiftDetailID <> value Then IsDirty = True
      pShiftDetailID = value
    End Set
  End Property

  Public Property ShiftID() As Int32
    Get
      Return pShiftID
    End Get
    Set(ByVal value As Int32)
      If pShiftID <> value Then IsDirty = True
      pShiftID = value
    End Set
  End Property

  Public Property DayOfWeek() As Byte
    Get
      Return pDayOfWeek
    End Get
    Set(ByVal value As Byte)
      If pDayOfWeek <> value Then IsDirty = True
      pDayOfWeek = value
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



''Collection Definition - ShiftDetails (to ShiftDetails)'Generated from Table:ShiftDetails

'Private pShiftDetailss As colShiftDetailss
'Public Property ShiftDetailss() As colShiftDetailss
'  Get
'    Return pShiftDetailss
'  End Get
'  Set(ByVal value As colShiftDetailss)
'    pShiftDetailss = value
'  End Set
'End Property

'  pShiftDetailss = New colShiftDetailss 'Add to New
'  pShiftDetailss = Nothing 'Add to Finalize
'  .ShiftDetailss = ShiftDetailss.Clone 'Add to CloneTo
'  ShiftDetailss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ShiftDetailss.IsDirty 'Add to IsAnyDirty

Public Class colShiftDetailss : Inherits colBase(Of dmShiftDetails)

  Public Overrides Function IndexFromKey(ByVal vShiftDetailID As Integer) As Integer
    Dim mItem As dmShiftDetails
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ShiftDetailID = vShiftDetailID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmShiftDetails))
    MyBase.New(vList)
  End Sub

End Class
