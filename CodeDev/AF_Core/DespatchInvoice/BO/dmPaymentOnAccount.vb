''Class Definition - PaymentOnAccount (to PaymentOnAccount)'Generated from Table:PaymentOnAccount
Imports RTIS.CommonVB

Public Class dmPaymentOnAccount : Inherits dmBase
  Private pPaymentOnAccountID As Int32
  Private pRequestDate As DateTime
  Private pRequestValue As Decimal
  Private pReceivedValue As Decimal
  Private pAllocatedValue As Decimal
  Private pSalesOrderID As Integer
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
    PaymentOnAccountID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPaymentOnAccount)
      .PaymentOnAccountID = PaymentOnAccountID
      .RequestDate = RequestDate
      .RequestValue = RequestValue
      .ReceivedValue = ReceivedValue
      .AllocatedValue = AllocatedValue
      .SalesOrderID = SalesOrderID
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PaymentOnAccountID() As Int32
    Get
      Return pPaymentOnAccountID
    End Get
    Set(ByVal value As Int32)
      If pPaymentOnAccountID <> value Then IsDirty = True
      pPaymentOnAccountID = value
    End Set
  End Property

  Public Property SalesOrderID As Integer
    Get
      Return pSalesOrderID
    End Get
    Set(value As Integer)
      If pSalesOrderID <> value Then IsDirty = True

      pSalesOrderID = value
    End Set
  End Property
  Public Property RequestDate() As DateTime
    Get
      Return pRequestDate
    End Get
    Set(ByVal value As DateTime)
      If pRequestDate <> value Then IsDirty = True
      pRequestDate = value
    End Set
  End Property

  Public Property RequestValue() As Decimal
    Get
      Return pRequestValue
    End Get
    Set(ByVal value As Decimal)
      If pRequestValue <> value Then IsDirty = True
      pRequestValue = value
    End Set
  End Property

  Public Property ReceivedValue() As Decimal
    Get
      Return pReceivedValue
    End Get
    Set(ByVal value As Decimal)
      If pReceivedValue <> value Then IsDirty = True
      pReceivedValue = value
    End Set
  End Property

  Public Property AllocatedValue() As Decimal
    Get
      Return pAllocatedValue
    End Get
    Set(ByVal value As Decimal)
      If pAllocatedValue <> value Then IsDirty = True
      pAllocatedValue = value
    End Set
  End Property


End Class



''Collection Definition - PaymentOnAccount (to PaymentOnAccount)'Generated from Table:PaymentOnAccount

'Private pPaymentOnAccounts As colPaymentOnAccounts
'Public Property PaymentOnAccounts() As colPaymentOnAccounts
'  Get
'    Return pPaymentOnAccounts
'  End Get
'  Set(ByVal value As colPaymentOnAccounts)
'    pPaymentOnAccounts = value
'  End Set
'End Property

'  pPaymentOnAccounts = New colPaymentOnAccounts 'Add to New
'  pPaymentOnAccounts = Nothing 'Add to Finalize
'  .PaymentOnAccounts = PaymentOnAccounts.Clone 'Add to CloneTo
'  PaymentOnAccounts.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PaymentOnAccounts.IsDirty 'Add to IsAnyDirty

Public Class colPaymentOnAccounts : Inherits colBase(Of dmPaymentOnAccount)

  Public Overrides Function IndexFromKey(ByVal vPaymentOnAccountID As Integer) As Integer
    Dim mItem As dmPaymentOnAccount
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PaymentOnAccountID = vPaymentOnAccountID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPaymentOnAccount))
    MyBase.New(vList)
  End Sub

End Class


''DTO Definition - PaymentOnAccount (to PaymentOnAccount)'Generated from Table:PaymentOnAccount



