''Class Definition - SalesOrderPhaseMilestoneStatus (to SalesOrderPhaseMilestoneStatus)'Generated from Table:SalesOrderPhaseMilestoneStatus
Imports RTIS.CommonVB

Public Class dmSalesOrderPhaseMilestoneStatus : Inherits dmBase
  Private pSalesOrderPhaseMilestoneStatusID As Int32
  Private pSalesOrderPhaseID As Int32
  Private pMilestoneENUM As Byte
  Private pStatus As Byte
  Private pTargetDate As DateTime
  Private pActualDate As DateTime
  Private pNotes As String
  Private pStartDate As Date
  Private pManReqDays As Integer
  Private pTempSkip As Boolean

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
    SalesOrderPhaseMilestoneStatusID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderPhaseMilestoneStatus)
      .SalesOrderPhaseMilestoneStatusID = SalesOrderPhaseMilestoneStatusID
      .SalesOrderPhaseID = SalesOrderPhaseID
      .MilestoneENUM = MilestoneENUM
      .Status = Status
      .TargetDate = TargetDate
      .ActualDate = ActualDate
      .Notes = Notes
      .StartDate = StartDate
      .ManReqDays = ManReqDays
      .TempSkip = TempSkip
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderPhaseMilestoneStatusID() As Int32
    Get
      Return pSalesOrderPhaseMilestoneStatusID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseMilestoneStatusID <> value Then IsDirty = True
      pSalesOrderPhaseMilestoneStatusID = value
    End Set
  End Property

  Public Property SalesOrderPhaseID() As Int32
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseID <> value Then IsDirty = True
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property MilestoneENUM() As Byte
    Get
      Return pMilestoneENUM
    End Get
    Set(ByVal value As Byte)
      If pMilestoneENUM <> value Then IsDirty = True
      pMilestoneENUM = value
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

  Public Property StartDate As Date
    Get
      Return pStartDate
    End Get
    Set(value As Date)
      If pStartDate <> value Then IsDirty = True
      pStartDate = value
    End Set
  End Property

  Public Property ManReqDays As Integer
    Get
      Return pManReqDays
    End Get
    Set(value As Integer)
      If pManReqDays <> value Then IsDirty = True
      pManReqDays = value
    End Set
  End Property

  Public Property TempSkip As Boolean
    Get
      Return pTempSkip
    End Get
    Set(value As Boolean)
      pTempSkip = value
    End Set
  End Property
End Class



''Collection Definition - SalesOrderPhaseMilestoneStatus (to SalesOrderPhaseMilestoneStatus)'Generated from Table:SalesOrderPhaseMilestoneStatus

'Private pSalesOrderPhaseMilestoneStatuss As colSalesOrderPhaseMilestoneStatuss
'Public Property SalesOrderPhaseMilestoneStatuss() As colSalesOrderPhaseMilestoneStatuss
'  Get
'    Return pSalesOrderPhaseMilestoneStatuss
'  End Get
'  Set(ByVal value As colSalesOrderPhaseMilestoneStatuss)
'    pSalesOrderPhaseMilestoneStatuss = value
'  End Set
'End Property

'  pSalesOrderPhaseMilestoneStatuss = New colSalesOrderPhaseMilestoneStatuss 'Add to New
'  pSalesOrderPhaseMilestoneStatuss = Nothing 'Add to Finalize
'  .SalesOrderPhaseMilestoneStatuss = SalesOrderPhaseMilestoneStatuss.Clone 'Add to CloneTo
'  SalesOrderPhaseMilestoneStatuss.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderPhaseMilestoneStatuss.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderPhaseMilestoneStatuss : Inherits colBase(Of dmSalesOrderPhaseMilestoneStatus)

  Public Function ItemFromMilestoneENUM(ByVal vMilestoneENUM As Integer) As dmSalesOrderPhaseMilestoneStatus
    Dim mRetVal As dmSalesOrderPhaseMilestoneStatus = Nothing
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
    For Each mItem As dmSalesOrderPhaseMilestoneStatus In Me
      mIndex += 1
      If mItem.MilestoneENUM = vMilestoneENUM Then
        mRetVal = mIndex
        Exit For
      End If
    Next
    Return mRetVal
  End Function
  Public Overrides Function IndexFromKey(ByVal vSalesOrderPhaseMilestoneStatusID As Integer) As Integer
    Dim mItem As dmSalesOrderPhaseMilestoneStatus
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderPhaseMilestoneStatusID = vSalesOrderPhaseMilestoneStatusID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderPhaseMilestoneStatus))
    MyBase.New(vList)
  End Sub

  Public Function GetAdvancePercentage() As Decimal
    Dim mTotalItemsMinusRequired As Integer
    Dim mWeightMilestone As Decimal
    Dim mRetVal As Decimal

    For Each mItem In Me.Items

      If mItem.Status = eMilestoneStatus.NotRequired Then
        mTotalItemsMinusRequired = mTotalItemsMinusRequired + 1
        mItem.TempSkip = True
      End If
    Next

    mWeightMilestone = Math.Round(100 / (8 - mTotalItemsMinusRequired), 2, MidpointRounding.AwayFromZero)


    For Each mItem In Me.Items

      If mItem.TempSkip = False Then

        Select Case mItem.Status
          Case eMilestoneStatus.Complete
            mRetVal = mRetVal + mWeightMilestone

          Case eMilestoneStatus.PartComplete
            mRetVal = mRetVal + (mWeightMilestone / 2)


        End Select

      End If

    Next


    Return Math.Round(mRetVal / 100, 2, MidpointRounding.AwayFromZero)
  End Function
End Class