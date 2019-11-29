''Class Definition - Shift (to Shift)'Generated from Table:Shift
Imports RTIS.CommonVB

Public Class dmShift : Inherits dmBase
  Private pShiftID As Int32
  Private pDescription As String
  Private pShiftDetails As colShiftDetailss

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pShiftDetails = New colShiftDetailss

  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    pShiftDetails = Nothing

    MyBase.Finalize()

  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If mAnyDirty = False Then
        mAnyDirty = pShiftDetails.IsDirty

      End If

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    ShiftID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmShift)
      .ShiftID = ShiftID
      .Description = Description
      'Add entries here for each collection and class property
      .ShifDetails = pShiftDetails.Clone

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property ShiftID() As Int32
    Get
      Return pShiftID
    End Get
    Set(ByVal value As Int32)
      If pShiftID <> value Then IsDirty = True
      pShiftID = value
    End Set
  End Property

  Public Property ShifDetails() As colShiftDetailss
    Get
      Return pShiftDetails
    End Get
    Set(ByVal value As colShiftDetailss)
      pShiftDetails = value
    End Set
  End Property




  Public Property Description() As String
    Get
      Return pDescription
    End Get
    Set(ByVal value As String)
      If pDescription <> value Then IsDirty = True
      pDescription = value
    End Set
  End Property


End Class



''Collection Definition - Shift (to Shift)'Generated from Table:Shift

'Private pShifts As colShifts
'Public Property Shifts() As colShifts
'  Get
'    Return pShifts
'  End Get
'  Set(ByVal value As colShifts)
'    pShifts = value
'  End Set
'End Property

'  pShifts = New colShifts 'Add to New
'  pShifts = Nothing 'Add to Finalize
'  .Shifts = Shifts.Clone 'Add to CloneTo
'  Shifts.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = Shifts.IsDirty 'Add to IsAnyDirty

Public Class colShifts : Inherits colBase(Of dmShift)

  Public Overrides Function IndexFromKey(ByVal vShiftID As Integer) As Integer
    Dim mItem As dmShift
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ShiftID = vShiftID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmShift))
    MyBase.New(vList)
  End Sub

End Class

