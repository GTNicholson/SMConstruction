''Class Definition - PODeliveryItem (to PODeliveryItem)'Generated from Table:PODeliveryItem
Imports RTIS.CommonVB

Public Class dmPODeliveryItem : Inherits dmBase
  Private pPODeliveryItemID As Int32
  Private pPODeliveryID As Int32
  Private pPOCallOffItemAllocationID As Integer
  Private pQtyReceived As Decimal
  Private pQtyRejected As Decimal
  ''Private pQtyInvoiced As Decimal

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
    PODeliveryItemID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPODeliveryItem)
      .PODeliveryItemID = PODeliveryItemID
      .PODeliveryID = PODeliveryID
      '.POCallOffItemID = POCallOffItemID
      .POItemAllocationID = POItemAllocationID
      .SetQtyReceived(QtyReceived)
      .SetQtyRejected(QtyRejected)
      ''.QtyInvoiced = QtyInvoiced
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PODeliveryItemID() As Int32
    Get
      Return pPODeliveryItemID
    End Get
    Set(ByVal value As Int32)
      If pPODeliveryItemID <> value Then IsDirty = True
      pPODeliveryItemID = value
    End Set
  End Property

  Public Property PODeliveryID() As Int32
    Get
      Return pPODeliveryID
    End Get
    Set(ByVal value As Int32)
      If pPODeliveryID <> value Then IsDirty = True
      pPODeliveryID = value
    End Set
  End Property

  'Public Property POCallOffItemID() As Int32
  '  Get
  '    Return pPOCallOffItemID
  '  End Get
  '  Set(ByVal value As Int32)
  '    If pPOCallOffItemID <> value Then IsDirty = True
  '    pPOCallOffItemID = value
  '  End Set
  'End Property

  Public Property POItemAllocationID As Integer
    Get
      Return pPOCallOffItemAllocationID
    End Get
    Set(value As Integer)
      If pPOCallOffItemAllocationID <> value Then IsDirty = True
      pPOCallOffItemAllocationID = value
    End Set
  End Property

  Public Property QtyReceived() As Decimal
    Get
      Return pQtyReceived
    End Get
    Set(value As Decimal)
      pQtyReceived=value
    End Set
  End Property

  Public Sub SetQtyReceived(ByVal vNewValue As Decimal)
    pQtyReceived = vNewValue
  End Sub

  Public ReadOnly Property QtyRejected() As Decimal
    Get
      Return pQtyRejected
    End Get

  End Property

  Public Sub SetQtyRejected(ByVal vNewValue As Decimal)
    pQtyRejected = vNewValue
  End Sub

  ''Public Property QtyInvoiced As Decimal
  ''  Get
  ''    Return pQtyInvoiced
  ''  End Get
  ''  Set(value As Decimal)
  ''    If pQtyInvoiced <> value Then IsDirty = True
  ''    pQtyInvoiced = value
  ''  End Set
  ''End Property

End Class



''Collection Definition - PODeliveryItem (to PODeliveryItem)'Generated from Table:PODeliveryItem

'Private pPODeliveryItems As colPODeliveryItems
'Public Property PODeliveryItems() As colPODeliveryItems
'  Get
'    Return pPODeliveryItems
'  End Get
'  Set(ByVal value As colPODeliveryItems)
'    pPODeliveryItems = value
'  End Set
'End Property

'  pPODeliveryItems = New colPODeliveryItems 'Add to New
'  pPODeliveryItems = Nothing 'Add to Finalize
'  .PODeliveryItems = PODeliveryItems.Clone 'Add to CloneTo
'  PODeliveryItems.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = PODeliveryItems.IsDirty 'Add to IsAnyDirty

Public Class colPODeliveryItems : Inherits colBase(Of dmPODeliveryItem)

  Public Overrides Function IndexFromKey(ByVal vPODeliveryItemID As Integer) As Integer
    Dim mItem As dmPODeliveryItem
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PODeliveryItemID = vPODeliveryItemID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
    TrackDeleted = True
  End Sub

  Public Sub New(ByVal vList As List(Of dmPODeliveryItem))
    MyBase.New(vList)
    TrackDeleted = True
  End Sub

  Public Function TotalQtyReceived() As Decimal
    Dim mRetVal As Decimal

    For Each mItem As dmPODeliveryItem In MyBase.Items
      mRetVal += mItem.QtyReceived
    Next

    Return mRetVal
  End Function

  Public Function ItemByPOCOItemAllocationID(ByVal vPOCOItemAllocationID As Integer) As dmPODeliveryItem
    Dim mRetVal As dmPODeliveryItem

    For Each mItem As dmPODeliveryItem In MyBase.Items
      If mItem.POItemAllocationID = vPOCOItemAllocationID Then
        mRetVal = mItem
        Exit For
      End If
    Next

    Return mRetVal
  End Function

End Class

