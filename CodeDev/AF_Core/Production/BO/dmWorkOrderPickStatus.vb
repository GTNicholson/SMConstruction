''Class Definition - WorkOrderPickStatus (to WorkOrderPickStatus)'Generated from Table:WorkOrderPickStatus
Imports RTIS.CommonVB

Public Class dmWorkOrderPickStatus : Inherits dmBase
  Private pWorkOrderPickStatusID As Int32
  Private pWorkOrderID As Int32
  Private pMatReqCategory As Byte
  Private pTargetDate As DateTime
  Private pLastDate As DateTime
  Private pNotes As String
  Private pPickStatus As Byte

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
    WorkOrderPickStatusID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrderPickStatus)
      .WorkOrderPickStatusID = WorkOrderPickStatusID
      .WorkOrderID = WorkOrderID
      .MatReqCategory = MatReqCategory
      .TargetDate = TargetDate
      .LastDate = LastDate
      .Notes = Notes
      .PickStatus = PickStatus
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkOrderPickStatusID() As Int32
    Get
      Return pWorkOrderPickStatusID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderPickStatusID <> value Then IsDirty = True
      pWorkOrderPickStatusID = value
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

  Public Property MatReqCategory() As Byte
    Get
      Return pMatReqCategory
    End Get
    Set(ByVal value As Byte)
      If pMatReqCategory <> value Then IsDirty = True
      pMatReqCategory = value
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

  Public Property LastDate() As DateTime
    Get
      Return pLastDate
    End Get
    Set(ByVal value As DateTime)
      If pLastDate <> value Then IsDirty = True
      pLastDate = value
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

  Public Property PickStatus() As Byte
    Get
      Return pPickStatus
    End Get
    Set(ByVal value As Byte)
      If pPickStatus <> value Then IsDirty = True
      pPickStatus = value
    End Set
  End Property


End Class



''Collection Definition - WorkOrderPickStatus (to WorkOrderPickStatus)'Generated from Table:WorkOrderPickStatus

'Private pWorkOrderPickStatuss As colWorkOrderPickStatuss
'Public Property WorkOrderPickStatuss() As colWorkOrderPickStatuss
'  Get
'    Return pWorkOrderPickStatuss
'  End Get
'  Set(ByVal value As colWorkOrderPickStatuss)
'    pWorkOrderPickStatuss = value
'  End Set
'End Property

'  pWorkOrderPickStatuss = New colWorkOrderPickStatuss 'Add to New
'  pWorkOrderPickStatuss = Nothing 'Add to Finalize
'  .WorkOrderPickStatuss = WorkOrderPickStatuss.Clone 'Add to CloneTo
'  WorkOrderPickStatuss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WorkOrderPickStatuss.IsDirty 'Add to IsAnyDirty

Public Class colWorkOrderPickStatuss : Inherits colBase(Of dmWorkOrderPickStatus)

  Public Overrides Function IndexFromKey(ByVal vWorkOrderPickStatusID As Integer) As Integer
    Dim mItem As dmWorkOrderPickStatus
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderPickStatusID = vWorkOrderPickStatusID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWorkOrderPickStatus))
    MyBase.New(vList)
  End Sub

End Class




