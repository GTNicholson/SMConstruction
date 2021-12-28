''Class Definition - SalesOrderPhase (to SalesOrderPhase)'Generated from Table:SalesOrderPhase
Imports RTIS.CommonVB

Public Class dmSalesOrderPhase : Inherits dmBase
  Private pSalesOrderPhaseID As Int32
  Private pSalesOrderID As Int32
  Private pSalesOrderNo As String
  Private pDateCreated As DateTime
  Private pCreatedBy As Int32
  Private pDateRequired As DateTime
  Private pQuantityItems As Int32
  Private pTotalPrice As Decimal
  Private pPhaseNumber As Int32
  Private pScheduleFile As String
  Private pPhaseRef As String
  Private pDespatchStatus As Byte
  Private pSpecificationStatus As Byte
  Private pInvoiceStatus As Byte
  Private pProductionStatus As Byte
  Private pMatReqStatus As Byte
  Private pCommittedBy As Int32
  Private pDateCommitted As DateTime
  Private pJobNo As String
  Private pSalesOrderPhaseItems As colSalesOrderPhaseItems
  Private pPhaseItemComponents As colPhaseItemComponents
  Private pManReqDays As Integer
  Private pOrderReceivedDate As Date

  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here
    pSalesOrderPhaseItems = New colSalesOrderPhaseItems
    pPhaseItemComponents = New colPhaseItemComponents
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
      If mAnyDirty = False Then mAnyDirty = pSalesOrderPhaseItems.IsDirty
      If mAnyDirty = False Then mAnyDirty = pPhaseItemComponents.IsDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    pSalesOrderPhaseItems = Nothing
    pPhaseItemComponents = Nothing
    SalesOrderPhaseID = 0
  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmSalesOrderPhase)
      .SalesOrderPhaseID = SalesOrderPhaseID
      .SalesOrderID = SalesOrderID
      .SalesOrderNo = SalesOrderNo
      .DateCreated = DateCreated
      .CreatedBy = CreatedBy
      .DateRequired = DateRequired
      .QuantityItems = QuantityItems
      .TotalPrice = TotalPrice
      .PhaseNumber = PhaseNumber
      .ScheduleFile = ScheduleFile
      .PhaseRef = PhaseRef
      .DespatchStatus = DespatchStatus
      .SpecificationStatus = SpecificationStatus
      .InvoiceStatus = InvoiceStatus
      .ProductionStatus = ProductionStatus
      .MatReqStatus = MatReqStatus
      .CommittedBy = CommittedBy
      .DateCommitted = DateCommitted
      .JobNo = JobNo
      .SalesOrderPhaseItems = SalesOrderPhaseItems
      .PhaseItemComponents = PhaseItemComponents
      .ManReqDays = ManReqDays
      .OrderReceivedDate = OrderReceivedDate
      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property SalesOrderPhaseID() As Int32
    Get
      Return pSalesOrderPhaseID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderPhaseID <> value Then IsDirty = True
      pSalesOrderPhaseID = value
    End Set
  End Property

  Public Property SalesOrderID() As Int32
    Get
      Return pSalesOrderID
    End Get
    Set(ByVal value As Int32)
      If pSalesOrderID <> value Then IsDirty = True
      pSalesOrderID = value
    End Set
  End Property

  Public Property SalesOrderNo() As String
    Get
      Return pSalesOrderNo
    End Get
    Set(ByVal value As String)
      If pSalesOrderNo <> value Then IsDirty = True
      pSalesOrderNo = value
    End Set
  End Property

  Public Property DateCreated() As DateTime
    Get
      Return pDateCreated
    End Get
    Set(ByVal value As DateTime)
      If pDateCreated <> value Then IsDirty = True
      pDateCreated = value
    End Set
  End Property

  Public Property CreatedBy() As Int32
    Get
      Return pCreatedBy
    End Get
    Set(ByVal value As Int32)
      If pCreatedBy <> value Then IsDirty = True
      pCreatedBy = value
    End Set
  End Property

  Public Property DateRequired() As DateTime
    Get
      Return pDateRequired
    End Get
    Set(ByVal value As DateTime)
      If pDateRequired <> value Then IsDirty = True
      pDateRequired = value
    End Set
  End Property

  Public Property QuantityItems() As Int32
    Get
      Return pQuantityItems
    End Get
    Set(ByVal value As Int32)
      If pQuantityItems <> value Then IsDirty = True
      pQuantityItems = value
    End Set
  End Property

  Public Property TotalPrice() As Decimal
    Get
      Return pTotalPrice
    End Get
    Set(ByVal value As Decimal)
      If pTotalPrice <> value Then IsDirty = True
      pTotalPrice = value
    End Set
  End Property


  Public Property PhaseNumber() As Int32
    Get
      Return pPhaseNumber
    End Get
    Set(ByVal value As Int32)
      If pPhaseNumber <> value Then IsDirty = True
      pPhaseNumber = value
    End Set
  End Property

  Public Property ScheduleFile() As String
    Get
      Return pScheduleFile
    End Get
    Set(ByVal value As String)
      If pScheduleFile <> value Then IsDirty = True
      pScheduleFile = value
    End Set
  End Property

  Public Property PhaseRef() As String
    Get
      Return pPhaseRef
    End Get
    Set(ByVal value As String)
      If pPhaseRef <> value Then IsDirty = True
      pPhaseRef = value
    End Set
  End Property

  Public Property DespatchStatus() As Byte
    Get
      Return pDespatchStatus
    End Get
    Set(ByVal value As Byte)
      If pDespatchStatus <> value Then IsDirty = True
      pDespatchStatus = value
    End Set
  End Property

  Public Property SpecificationStatus() As Byte
    Get
      Return pSpecificationStatus
    End Get
    Set(ByVal value As Byte)
      If pSpecificationStatus <> value Then IsDirty = True
      pSpecificationStatus = value
    End Set
  End Property

  Public Property InvoiceStatus() As Byte
    Get
      Return pInvoiceStatus
    End Get
    Set(ByVal value As Byte)
      If pInvoiceStatus <> value Then IsDirty = True
      pInvoiceStatus = value
    End Set
  End Property

  Public Property ProductionStatus() As Byte
    Get
      Return pProductionStatus
    End Get
    Set(ByVal value As Byte)
      If pProductionStatus <> value Then IsDirty = True
      pProductionStatus = value
    End Set
  End Property

  Public Property MatReqStatus() As Byte
    Get
      Return pMatReqStatus
    End Get
    Set(ByVal value As Byte)
      If pMatReqStatus <> value Then IsDirty = True
      pMatReqStatus = value
    End Set
  End Property

  Public Property CommittedBy() As Int32
    Get
      Return pCommittedBy
    End Get
    Set(ByVal value As Int32)
      If pCommittedBy <> value Then IsDirty = True
      pCommittedBy = value
    End Set
  End Property

  Public Property DateCommitted() As DateTime
    Get
      Return pDateCommitted
    End Get
    Set(ByVal value As DateTime)
      If pDateCommitted <> value Then IsDirty = True
      pDateCommitted = value
    End Set
  End Property

  Public Property JobNo() As String
    Get
      Return pJobNo
    End Get
    Set(ByVal value As String)
      If pJobNo <> value Then IsDirty = True
      pJobNo = value
    End Set
  End Property
  Public Property SalesOrderPhaseItems() As colSalesOrderPhaseItems
    Get
      Return pSalesOrderPhaseItems
    End Get
    Set(ByVal value As colSalesOrderPhaseItems)
      pSalesOrderPhaseItems = value
    End Set
  End Property
  Public Property PhaseItemComponents() As colPhaseItemComponents
    Get
      Return pPhaseItemComponents
    End Get
    Set(ByVal value As colPhaseItemComponents)
      pPhaseItemComponents = value
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

  Public Property OrderReceivedDate As Date
    Get
      Return pOrderReceivedDate
    End Get
    Set(value As Date)
      If pOrderReceivedDate <> value Then IsDirty = True
      pOrderReceivedDate = value
    End Set
  End Property
End Class



''Collection Definition - SalesOrderPhase (to SalesOrderPhase)'Generated from Table:SalesOrderPhase

'Private pSalesOrderPhases As colSalesOrderPhases
'Public Property SalesOrderPhases() As colSalesOrderPhases
'  Get
'    Return pSalesOrderPhases
'  End Get
'  Set(ByVal value As colSalesOrderPhases)
'    pSalesOrderPhases = value
'  End Set
'End Property

'  pSalesOrderPhases = New colSalesOrderPhases 'Add to New
'  pSalesOrderPhases = Nothing 'Add to Finalize
'  .SalesOrderPhases = SalesOrderPhases.Clone 'Add to CloneTo
'  SalesOrderPhases.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = SalesOrderPhases.IsDirty 'Add to IsAnyDirty

Public Class colSalesOrderPhases : Inherits colBase(Of dmSalesOrderPhase)

  Public Overrides Function IndexFromKey(ByVal vSalesOrderPhaseID As Integer) As Integer
    Dim mItem As dmSalesOrderPhase
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.SalesOrderPhaseID = vSalesOrderPhaseID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmSalesOrderPhase))
    MyBase.New(vList)
  End Sub

End Class



