''Class Definition - EmployeeRateOfPay (to EmployeeRateOfPay)'Generated from Table:EmployeeRateOfPay
Imports RTIS.CommonVB

Public Class dmEmployeeRateOfPay : Inherits dmBase
  Private pEmployeeRateOfPayID As Int32
  Private pEmployeeID As Int32
  Private pPayType As Byte
  Private pStartDate As DateTime
  Private pStandardRate As Decimal
  Private pOverTimeRate As Decimal

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
    EmployeeRateOfPayID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmEmployeeRateOfPay)
      .EmployeeRateOfPayID = EmployeeRateOfPayID
      .EmployeeID = EmployeeID
      .PayType = PayType
      .StartDate = StartDate
      .StandardRate = StandardRate
      .OverTimeRate = OverTimeRate
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property EmployeeRateOfPayID() As Int32
    Get
      Return pEmployeeRateOfPayID
    End Get
    Set(ByVal value As Int32)
      If pEmployeeRateOfPayID <> value Then IsDirty = True
      pEmployeeRateOfPayID = value
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

  Public Property PayType() As Byte
    Get
      Return pPayType
    End Get
    Set(ByVal value As Byte)
      If pPayType <> value Then IsDirty = True
      pPayType = value
    End Set
  End Property

  Public Property StartDate() As DateTime
    Get
      Return pStartDate
    End Get
    Set(ByVal value As DateTime)
      If pStartDate <> value Then IsDirty = True
      pStartDate = value
    End Set
  End Property

  Public Property StandardRate() As Decimal
    Get
      Return pStandardRate
    End Get
    Set(ByVal value As Decimal)
      If pStandardRate <> value Then IsDirty = True
      pStandardRate = value
    End Set
  End Property

  Public Property OverTimeRate As Decimal
    Get
      Return pOverTimeRate
    End Get
    Set(value As Decimal)
      If pOverTimeRate <> value Then IsDirty = True
      pOverTimeRate = value
    End Set
  End Property
End Class



''Collection Definition - EmployeeRateOfPay (to EmployeeRateOfPay)'Generated from Table:EmployeeRateOfPay

'Private pEmployeeRateOfPays As colEmployeeRateOfPays
'Public Property EmployeeRateOfPays() As colEmployeeRateOfPays
'  Get
'    Return pEmployeeRateOfPays
'  End Get
'  Set(ByVal value As colEmployeeRateOfPays)
'    pEmployeeRateOfPays = value
'  End Set
'End Property

'  pEmployeeRateOfPays = New colEmployeeRateOfPays 'Add to New
'  pEmployeeRateOfPays = Nothing 'Add to Finalize
'  .EmployeeRateOfPays = EmployeeRateOfPays.Clone 'Add to CloneTo
'  EmployeeRateOfPays.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = EmployeeRateOfPays.IsDirty 'Add to IsAnyDirty

Public Class colEmployeeRateOfPays : Inherits colBase(Of dmEmployeeRateOfPay)

  Public Overrides Function IndexFromKey(ByVal vEmployeeRateOfPayID As Integer) As Integer
    Dim mItem As dmEmployeeRateOfPay
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.EmployeeRateOfPayID = vEmployeeRateOfPayID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmEmployeeRateOfPay))
    MyBase.New(vList)
  End Sub

End Class

