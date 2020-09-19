''Class Definition - InvoiceItem (to InvoiceItem)'Generated from Table:InvoiceItem
Imports RTIS.CommonVB

Public Class dmInvoiceItem : Inherits dmBase
  Private pInvoiceItemID As Int32
  Private pInvoiceID As Int32
  Private pSalesItemID As Int32
  Private pDescription As String
  Private pQuantity As Decimal
  Private pUnitPrice As Decimal

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
    InvoiceItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmInvoiceItem)
      .InvoiceItemID = InvoiceItemID
      .InvoiceID = InvoiceID
      .SalesItemID = SalesItemID
      .Description = Description
      .Quantity = Quantity
      .UnitPrice = UnitPrice
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property InvoiceItemID() As Int32
    Get
      Return pInvoiceItemID
    End Get
    Set(ByVal value As Int32)
      If pInvoiceItemID <> value Then IsDirty = True
      pInvoiceItemID = value
    End Set
  End Property

  Public Property InvoiceID() As Int32
    Get
      Return pInvoiceID
    End Get
    Set(ByVal value As Int32)
      If pInvoiceID <> value Then IsDirty = True
      pInvoiceID = value
    End Set
  End Property

  Public Property SalesItemID() As Int32
    Get
      Return pSalesItemID
    End Get
    Set(ByVal value As Int32)
      If pSalesItemID <> value Then IsDirty = True
      pSalesItemID = value
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

  Public Property Quantity() As Decimal
    Get
      Return pQuantity
    End Get
    Set(ByVal value As Decimal)
      If pQuantity <> value Then IsDirty = True
      pQuantity = value
    End Set
  End Property

  Public Property UnitPrice() As Decimal
    Get
      Return pUnitPrice
    End Get
    Set(ByVal value As Decimal)
      If pUnitPrice <> value Then IsDirty = True
      pUnitPrice = value
    End Set
  End Property


End Class



''Collection Definition - InvoiceItem (to InvoiceItem)'Generated from Table:InvoiceItem

'Private pInvoiceItems As colInvoiceItems
'Public Property InvoiceItems() As colInvoiceItems
'  Get
'    Return pInvoiceItems
'  End Get
'  Set(ByVal value As colInvoiceItems)
'    pInvoiceItems = value
'  End Set
'End Property

'  pInvoiceItems = New colInvoiceItems 'Add to New
'  pInvoiceItems = Nothing 'Add to Finalize
'  .InvoiceItems = InvoiceItems.Clone 'Add to CloneTo
'  InvoiceItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = InvoiceItems.IsDirty 'Add to IsAnyDirty

Public Class colInvoiceItems : Inherits colBase(Of dmInvoiceItem)

  Public Overrides Function IndexFromKey(ByVal vInvoiceItemID As Integer) As Integer
    Dim mItem As dmInvoiceItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.InvoiceItemID = vInvoiceItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmInvoiceItem))
    MyBase.New(vList)
  End Sub

End Class



