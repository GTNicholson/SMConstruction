''Class Definition - ExchangeRate (to ExchangeRate)'Generated from Table:ExchangeRate
Imports RTIS.CommonVB

Public Class dmExchangeRate : Inherits dmBase
  Private pExchangeRateID As Int32
  Private pExchangeRateDate As DateTime
  Private pExchangeRateValue As Decimal
  Private pCurrency As Byte
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
    ExchangeRateID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmExchangeRate)
      .ExchangeRateID = ExchangeRateID
      .ExchangeRateDate = ExchangeRateDate
      .ExchangeRateValue = ExchangeRateValue
      .Currency = Currency
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub


  Public Property Currency() As Byte
    Get
      Return pCurrency
    End Get
    Set(ByVal value As Byte)
      If pCurrency <> value Then IsDirty = True
      pCurrency = value
    End Set
  End Property

  Public Property ExchangeRateID() As Int32
    Get
      Return pExchangeRateID
    End Get
    Set(ByVal value As Int32)
      If pExchangeRateID <> value Then IsDirty = True
      pExchangeRateID = value
    End Set
  End Property

  Public Property ExchangeRateDate() As DateTime
    Get
      Return pExchangeRateDate
    End Get
    Set(ByVal value As DateTime)
      If pExchangeRateDate <> value Then IsDirty = True
      pExchangeRateDate = value
    End Set
  End Property

  Public Property ExchangeRateValue() As Decimal
    Get
      Return pExchangeRateValue
    End Get
    Set(ByVal value As Decimal)
      If pExchangeRateValue <> value Then IsDirty = True
      pExchangeRateValue = value
    End Set
  End Property


End Class



''Collection Definition - ExchangeRate (to ExchangeRate)'Generated from Table:ExchangeRate

'Private pExchangeRates As colExchangeRates
'Public Property ExchangeRates() As colExchangeRates
'  Get
'    Return pExchangeRates
'  End Get
'  Set(ByVal value As colExchangeRates)
'    pExchangeRates = value
'  End Set
'End Property

'  pExchangeRates = New colExchangeRates 'Add to New
'  pExchangeRates = Nothing 'Add to Finalize
'  .ExchangeRates = ExchangeRates.Clone 'Add to CloneTo
'  ExchangeRates.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = ExchangeRates.IsDirty 'Add to IsAnyDirty

Public Class colExchangeRates : Inherits colBase(Of dmExchangeRate)

  Public Overrides Function IndexFromKey(ByVal vExchangeRateID As Integer) As Integer
    Dim mItem As dmExchangeRate
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.ExchangeRateID = vExchangeRateID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmExchangeRate))
    MyBase.New(vList)
  End Sub

End Class




