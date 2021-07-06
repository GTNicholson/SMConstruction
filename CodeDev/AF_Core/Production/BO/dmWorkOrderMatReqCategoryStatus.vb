''Class Definition - WorkOrderMatReqCategoryStatus (to WorkOrderMatReqCategoryStatus)'Generated from Table:WorkOrderMatReqCategoryStatus
Imports RTIS.CommonVB

Public Class dmWorkOrderMatReqCategoryStatus : Inherits dmBase
  Private pWorkOrderMatReqCategoryStatusID As Int32
  Private pWorkOrderID As Int32
  Private pMatReqCategory As Byte
  Private pStatus As Byte
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
    WorkOrderMatReqCategoryStatusID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmWorkOrderMatReqCategoryStatus)
      .WorkOrderMatReqCategoryStatusID = WorkOrderMatReqCategoryStatusID
      .WorkOrderID = WorkOrderID
      .MatReqCategory = MatReqCategory
      .Status = Status
      .TargetDate = TargetDate
      .LastDate = LastDate
      .Notes = Notes
      .PickStatus = PickStatus
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property WorkOrderMatReqCategoryStatusID() As Int32
    Get
      Return pWorkOrderMatReqCategoryStatusID
    End Get
    Set(ByVal value As Int32)
      If pWorkOrderMatReqCategoryStatusID <> value Then IsDirty = True
      pWorkOrderMatReqCategoryStatusID = value
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



''Collection Definition - WorkOrderMatReqCategoryStatus (to WorkOrderMatReqCategoryStatus)'Generated from Table:WorkOrderMatReqCategoryStatus

'Private pWorkOrderMatReqCategoryStatuss As colWorkOrderMatReqCategoryStatuss
'Public Property WorkOrderMatReqCategoryStatuss() As colWorkOrderMatReqCategoryStatuss
'  Get
'    Return pWorkOrderMatReqCategoryStatuss
'  End Get
'  Set(ByVal value As colWorkOrderMatReqCategoryStatuss)
'    pWorkOrderMatReqCategoryStatuss = value
'  End Set
'End Property

'  pWorkOrderMatReqCategoryStatuss = New colWorkOrderMatReqCategoryStatuss 'Add to New
'  pWorkOrderMatReqCategoryStatuss = Nothing 'Add to Finalize
'  .WorkOrderMatReqCategoryStatuss = WorkOrderMatReqCategoryStatuss.Clone 'Add to CloneTo
'  WorkOrderMatReqCategoryStatuss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = WorkOrderMatReqCategoryStatuss.IsDirty 'Add to IsAnyDirty

Public Class colWorkOrderMatReqCategoryStatuss : Inherits colBase(Of dmWorkOrderMatReqCategoryStatus)

  Public Overrides Function IndexFromKey(ByVal vWorkOrderMatReqCategoryStatusID As Integer) As Integer
    Dim mItem As dmWorkOrderMatReqCategoryStatus
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.WorkOrderMatReqCategoryStatusID = vWorkOrderMatReqCategoryStatusID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmWorkOrderMatReqCategoryStatus))
    MyBase.New(vList)
  End Sub

  Public Function ItemFromCategory(ByVal vCategory As Integer) As dmWorkOrderMatReqCategoryStatus
    Dim mRetVal As dmWorkOrderMatReqCategoryStatus = Nothing
    Dim mIndex As Integer
    mIndex = IndexFromCategory(vCategory)
    If mIndex <> -1 Then
      mRetVal = Me.Items(mIndex)
    End If
    Return mRetVal
  End Function

  Public Function IndexFromCategory(ByVal vCategory As Integer) As Integer
    Dim mRetVal As Integer = -1
    Dim mIndex As Integer = -1
    For Each mItem As dmWorkOrderMatReqCategoryStatus In Me
      mIndex += 1
      If mItem.MatReqCategory = vCategory Then
        mRetVal = mIndex
        Exit For
      End If
    Next
    Return mRetVal
  End Function


End Class


