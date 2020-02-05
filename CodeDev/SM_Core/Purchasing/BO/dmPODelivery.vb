''Class Definition - PODelivery (to PODelivery)'Generated from Table:PODelivery
Imports RTIS.CommonVB

Public Class dmPODelivery : Inherits dmBase
  Private pPODeliveryID As Int32
  Private pPOCallOffID As Int32
  Private pGRNumber As String
  Private pReceivedDate As DateTime
  Private pComment As String
  Private pIsSupplierReturn As Boolean
  Private pDateCreated As DateTime
  Private pStatus As Byte
  Private pReturnReasonID As Byte
  Private pActionRequiredID As Byte
  Private pFileExport As String
  Private pFullyInvoiced As Boolean
  Private pSupplierDelNo As String
  Private pMKReference As String

  Private pPODeliveryItems As colPODeliveryItems

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pPODeliveryItems = New colPODeliveryItems
  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    pPODeliveryItems = Nothing
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections
      If Not mAnyDirty Then mAnyDirty = PODeliveryItems.IsDirty
      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    PODeliveryID = 0
    PODeliveryItems.ClearKeys()
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmPODelivery)
      .PODeliveryID = PODeliveryID
      .POCallOffID = POCallOffID
      .GRNumber = GRNumber
      .ReceivedDate = ReceivedDate
      .Comment = Comment
      .IsSupplierReturn = IsSupplierReturn

      ''.Status = Status
      .ReturnReasonID = ReturnReasonID
      .ActionRequiredID = ActionRequiredID
      .FileExport = FileExport
      .FullyInvoiced = FullyInvoiced
      .SupplierDelNo = SupplierDelNo
      .MKReference = MKReference

      'Add entries here for each collection and class property
      .PODeliveryItems = PODeliveryItems.Clone
      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property PODeliveryID() As Int32
    Get
      Return pPODeliveryID
    End Get
    Set(ByVal value As Int32)
      If pPODeliveryID <> value Then IsDirty = True
      pPODeliveryID = value
    End Set
  End Property

  Public Property POCallOffID() As Int32
    Get
      Return pPOCallOffID
    End Get
    Set(ByVal value As Int32)
      If pPOCallOffID <> value Then IsDirty = True
      pPOCallOffID = value
    End Set
  End Property

  Public Property GRNumber() As String
    Get
      Return pGRNumber
    End Get
    Set(ByVal value As String)
      If pGRNumber <> value Then IsDirty = True
      pGRNumber = value
    End Set
  End Property

  Public Property ReceivedDate() As DateTime
    Get
      Return pReceivedDate
    End Get
    Set(ByVal value As DateTime)
      If pReceivedDate <> value Then IsDirty = True
      pReceivedDate = value
    End Set
  End Property

  Public Property Comment() As String
    Get
      Return pComment
    End Get
    Set(ByVal value As String)
      If pComment <> value Then IsDirty = True
      pComment = value
    End Set
  End Property

  Public Property PODeliveryItems() As colPODeliveryItems
    Get
      Return pPODeliveryItems
    End Get
    Set(ByVal value As colPODeliveryItems)
      pPODeliveryItems = value
    End Set
  End Property

  Public Property IsSupplierReturn As Boolean
    Get
      Return pIsSupplierReturn
    End Get
    Set(value As Boolean)
      If pIsSupplierReturn <> value Then IsDirty = True
      pIsSupplierReturn = value
    End Set
  End Property

  Public Property DateCreated As DateTime
    Get
      Return pDateCreated
    End Get
    Set(value As DateTime)
      If pDateCreated <> value Then IsDirty = True
      pDateCreated = value
    End Set
  End Property

  ''Public Property Status As Byte
  ''  Get
  ''    Return pStatus
  ''  End Get
  ''  Set(value As Byte)
  ''    If pStatus <> value Then IsDirty = True
  ''    pStatus = value
  ''  End Set
  ''End Property

  Public Property ReturnReasonID As Byte
    Get
      Return pReturnReasonID
    End Get
    Set(value As Byte)
      If pReturnReasonID <> value Then IsDirty = True
      pReturnReasonID = value
    End Set
  End Property

  Public Property ActionRequiredID As Byte
    Get
      Return pActionRequiredID
    End Get
    Set(value As Byte)
      If pActionRequiredID <> value Then IsDirty = True
      pActionRequiredID = value
    End Set
  End Property

  Public Property FileExport As String
    Get
      Return pFileExport
    End Get
    Set(value As String)
      If pFileExport <> value Then IsDirty = True
      pFileExport = value
    End Set
  End Property

  Public Property FullyInvoiced As Boolean
    Get
      Return pFullyInvoiced
    End Get
    Set(value As Boolean)
      If pFullyInvoiced <> value Then IsDirty = True
      pFullyInvoiced = value
    End Set
  End Property

  Public Property SupplierDelNo As String
    Get
      Return pSupplierDelNo
    End Get
    Set(value As String)
      If pSupplierDelNo <> value Then IsDirty = True
      pSupplierDelNo = value
    End Set
  End Property

  Public Property MKReference As String
    Get
      Return pMKReference
    End Get
    Set(value As String)
      If pMKReference <> value Then IsDirty = True
      pMKReference = value
    End Set
  End Property

  Public Shared Function SortPODelivery() As IComparer(Of dmPODelivery)
    Return CType(New clsPODeliverySorter, IComparer(Of dmPODelivery))
  End Function


  Public Class clsPODeliverySorter
    Implements IComparer(Of dmPODelivery)

    Public Function Compare(ByVal mObj1 As dmPODelivery, ByVal mObj2 As dmPODelivery) As Integer Implements IComparer(Of dmPODelivery).Compare
      Dim mRetval As Integer
      If mObj1.ReceivedDate < mObj2.ReceivedDate Then
        mRetval = -1
      ElseIf mObj1.ReceivedDate > mObj2.ReceivedDate Then
        mRetval = 1
      Else
        If mObj1.PODeliveryID < mObj2.PODeliveryID Then
          mRetval = -1
        ElseIf mObj1.PODeliveryID > mObj2.PODeliveryID Then
          mRetval = 1
        Else
          mRetval = 0
        End If
      End If
      Return mRetval
    End Function

  End Class


End Class



Public Class colPODeliverys : Inherits colBase(Of dmPODelivery)

  Public Overrides Function IndexFromKey(ByVal vPODeliveryID As Integer) As Integer
    Dim mItem As dmPODelivery
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.PODeliveryID = vPODeliveryID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmPODelivery))
    MyBase.New(vList)
    TrackDeleted = True
  End Sub

  Public Function AsList() As List(Of dmPODelivery)
    Return Me.Items
  End Function

End Class

