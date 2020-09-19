''Class Definition - StageType (to StageType)'Generated from Table:StageType
Imports RTIS.CommonVB

Public Class dmStageType : Inherits dmBase
  Private pStageTypeID As Int32
  Private pDescription As String

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
    StageTypeID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmStageType)
      .StageTypeID = StageTypeID
      .Description = Description
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property StageTypeID() As Int32
    Get
      Return pStageTypeID
    End Get
    Set(ByVal value As Int32)
      If pStageTypeID <> value Then IsDirty = True
      pStageTypeID = value
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



''Collection Definition - StageType (to StageType)'Generated from Table:StageType

'Private pStageTypes As colStageTypes
'Public Property StageTypes() As colStageTypes
'  Get
'    Return pStageTypes
'  End Get
'  Set(ByVal value As colStageTypes)
'    pStageTypes = value
'  End Set
'End Property

'  pStageTypes = New colStageTypes 'Add to New
'  pStageTypes = Nothing 'Add to Finalize
'  .StageTypes = StageTypes.Clone 'Add to CloneTo
'  StageTypes.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = StageTypes.IsDirty 'Add to IsAnyDirty

Public Class colStageTypes : Inherits colBase(Of dmStageType)

  Public Overrides Function IndexFromKey(ByVal vStageTypeID As Integer) As Integer
    Dim mItem As dmStageType
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.StageTypeID = vStageTypeID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmStageType))
    MyBase.New(vList)
  End Sub

End Class



