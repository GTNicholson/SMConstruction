''Class Definition - SalesOrderPhaseMilestoneStatus (to SalesOrderPhaseMilestoneStatus)'Generated from Table:SalesOrderPhaseMilestoneStatus
Imports RTIS.CommonVB

Public Class dmWorkOrderMilestoneStatus : Inherits dmBase
  Private pWorkOrderMilestoneStatusID As Int32
  Private pWorkOrderID As Int32
  Private pWorkCenter As Byte
  Private pStatus As Byte
  Private pTargetDate As DateTime
  Private pActualDate As DateTime
  Private pNotes As String

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
    WorkOrderMilestoneStatusID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrderMilestoneStatus)
      .WorkOrderMilestoneStatusID = WorkOrderMilestoneStatusID
      .WorkOrderID = WorkOrderID
      .MilestoneENUM = MilestoneENUM
      .Status = Status
      .TargetDate = TargetDate
      .ActualDate = ActualDate
      .Notes = Notes
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkOrderMilestoneStatusID() As Int32
    Get
      Return pWorkOrderMilestoneStatusID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderMilestoneStatusID <> value Then IsDirty = True
      pWorkOrderMilestoneStatusID = value
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

  Public Property MilestoneENUM() As Byte
    Get
      Return pWorkCenter
    End Get
    Set(ByVal value As Byte)
      If pWorkCenter <> value Then IsDirty = True
      pWorkCenter = value
    End Set
  End Property

  Public Property Status() As Byte
    Get
      Return pStatus
    End Get
    Set(ByVal value As Byte)
      If pStatus <> value Then IsDirty = True
      pStatus = value
    End Set
  End Property

  Public Property TargetDate() As DateTime
    Get
      Return pTargetDate
    End Get
    Set(ByVal value As DateTime)
      If pTargetDate <> value Then IsDirty = True
      pTargetDate = value
    End Set
  End Property

  Public Property ActualDate() As DateTime
    Get
      Return pActualDate
    End Get
    Set(ByVal value As DateTime)
      If pActualDate <> value Then IsDirty = True
      pActualDate = value
    End Set
  End Property

  Public Property Notes() As String
    Get
      Return pNotes
    End Get
    Set(ByVal value As String)
      If pNotes <> value Then IsDirty = True
      pNotes = value
    End Set
  End Property


End Class

Public Class colWorkOrderMilestoneStatuss : Inherits colBase(Of dmWorkOrderMilestoneStatus)

  Public Function ItemFromMilestoneENUM(ByVal vMilestoneENUM As Integer) As dmWorkOrderMilestoneStatus
    Dim mRetVal As dmWorkOrderMilestoneStatus = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromMilestoneENUM(vMilestoneENUM)
    If mIndex <> -1 Then
      mRetVal = Me.Items(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromMilestoneENUM(ByVal vMilestoneENUM As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mItem As dmWorkOrderMilestoneStatus In Me
      mIndex += 1
      If mItem.MilestoneENUM = vMilestoneENUM Then
        mRetVal = mIndex
        Exit For
      End If
    Next
    Return mRetVal
  End Function
  Public Overrides Function IndexFromKey(ByVal vWorkOrderMilestoneStatusID As Integer) As Integer
    Dim mItem As dmWorkOrderMilestoneStatus
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderMilestoneStatusID = vWorkOrderMilestoneStatusID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWorkOrderMilestoneStatus))
    MyBase.New(vList)
  End Sub

End Class

