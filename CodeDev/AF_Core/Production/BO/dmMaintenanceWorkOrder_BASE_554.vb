''Class Definition - MaintenanceWorkOrder (to MaintenanceWorkOrder)'Generated from Table:MaintenanceWorkOrder
Imports RTIS.CommonVB

Public Class dmMaintenanceWorkOrder : Inherits dmBase
  Private pMaintenanceWorkOrderID As Int32
  Private pMaintenanceWorkOrderNo As String
  Private pDescription As String
  Private pWorkCentreID As Byte
  Private pMaintenanceType As Byte
  Private pEquipmentID As Int32
  Private pEmployeeID As Int32
  Private pPriority As Int32
  Private pPlannedDate As DateTime
  Private pStatus As Byte
  Private pDuration As Decimal
  Private pNotes As String
  Private pMaintenanceWorkOrderDocument As String

  Private pMaitenanceWorkOrderItems As colMaintenanceWorkOrderItems
  Private pMachinery As dmMachinery
  Public Sub New()
    MyBase.New()
  End Sub

  Protected Overrides Sub NewSetup()
    ''Add object/collection instantiations here

    pMaitenanceWorkOrderItems = New colMaintenanceWorkOrderItems
    pMachinery = New dmMachinery

  End Sub

  Protected Overrides Sub AddSnapshotKeys()
    ''Add PrimaryKey, Rowversion and ParentKeys properties here:
    ''AddSnapshotKey("PropertyName")
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    pMaitenanceWorkOrderItems = Nothing
    pMachinery = Nothing
  End Sub

  Public Overrides ReadOnly Property IsAnyDirty() As Boolean
    Get
      Dim mAnyDirty = IsDirty
      '' Check Objects and Collections

      If mAnyDirty = False Then mAnyDirty = pMaitenanceWorkOrderItems.IsDirty

      If mAnyDirty = False Then mAnyDirty = pMachinery.IsAnyDirty

      IsAnyDirty = mAnyDirty
    End Get
  End Property

  Public Overrides Sub ClearKeys()
    'Set Key Values = 0
    MaintenanceWorkOrderID = 0
    pMaitenanceWorkOrderItems.ClearKeys()

  End Sub

  Public Overrides Sub CloneTo(ByRef rNewItem As dmBase)
    With CType(rNewItem, dmMaintenanceWorkOrder)
      .MaintenanceWorkOrderID = MaintenanceWorkOrderID
      .MaintenanceWorkOrderNo = MaintenanceWorkOrderNo
      .Description = Description
      .WorkCentreID = WorkCentreID
      .MaintenanceType = MaintenanceType
      .EquipmentID = EquipmentID
      .EmployeeID = EmployeeID
      .Priority = Priority
      .PlannedDate = PlannedDate
      .Status = Status
      .Duration = Duration
      .Notes = Notes
      .MaintenanceWorkOrderDocument = MaintenanceWorkOrderDocument
      .MaitenanceWorkOrderItems = MaitenanceWorkOrderItems
      .Machinery = Machinery

      'Add entries here for each collection and class property

      'Entries for object management

      .IsDirty = IsDirty
    End With

  End Sub

  Public Property MaintenanceWorkOrderID() As Int32
    Get
      Return pMaintenanceWorkOrderID
    End Get
    Set(ByVal value As Int32)
      If pMaintenanceWorkOrderID <> value Then IsDirty = True
      pMaintenanceWorkOrderID = value
    End Set
  End Property

  Public Property MaintenanceWorkOrderNo() As String
    Get
      Return pMaintenanceWorkOrderNo
    End Get
    Set(ByVal value As String)
      If pMaintenanceWorkOrderNo <> value Then IsDirty = True
      pMaintenanceWorkOrderNo = value
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

  Public Property WorkCentreID() As Byte
    Get
      Return pWorkCentreID
    End Get
    Set(ByVal value As Byte)
      If pWorkCentreID <> value Then IsDirty = True
      pWorkCentreID = value
    End Set
  End Property

  Public Property MaintenanceType() As Byte
    Get
      Return pMaintenanceType
    End Get
    Set(ByVal value As Byte)
      If pMaintenanceType <> value Then IsDirty = True
      pMaintenanceType = value
    End Set
  End Property

  Public Property EquipmentID() As Int32
    Get
      Return pEquipmentID
    End Get
    Set(ByVal value As Int32)
      If pEquipmentID <> value Then IsDirty = True
      pEquipmentID = value
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

  Public Property Priority() As Int32
    Get
      Return pPriority
    End Get
    Set(ByVal value As Int32)
      If pPriority <> value Then IsDirty = True
      pPriority = value
    End Set
  End Property

  Public Property PlannedDate() As DateTime
    Get
      Return pPlannedDate
    End Get
    Set(ByVal value As DateTime)
      If pPlannedDate <> value Then IsDirty = True
      pPlannedDate = value
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

  Public Property Duration() As Decimal
    Get
      Return pDuration
    End Get
    Set(ByVal value As Decimal)
      If pDuration <> value Then IsDirty = True
      pDuration = value
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

  Public Property MaintenanceWorkOrderDocument() As String
    Get
      Return pMaintenanceWorkOrderDocument
    End Get
    Set(ByVal value As String)
      If pMaintenanceWorkOrderDocument <> value Then IsDirty = True
      pMaintenanceWorkOrderDocument = value
    End Set
  End Property

  Public Property MaitenanceWorkOrderItems As colMaintenanceWorkOrderItems
    Get
      Return pMaitenanceWorkOrderItems
    End Get
    Set(value As colMaintenanceWorkOrderItems)
      pMaitenanceWorkOrderItems = value
    End Set
  End Property

  Public Property Machinery As dmMachinery
    Get
      Return pMachinery
    End Get
    Set(value As dmMachinery)
      pMachinery = value
    End Set
  End Property
End Class



''Collection Definition - MaintenanceWorkOrder (to MaintenanceWorkOrder)'Generated from Table:MaintenanceWorkOrder

'Private pMaintenanceWorkOrders As colMaintenanceWorkOrders
'Public Property MaintenanceWorkOrders() As colMaintenanceWorkOrders
'  Get
'    Return pMaintenanceWorkOrders
'  End Get
'  Set(ByVal value As colMaintenanceWorkOrders)
'    pMaintenanceWorkOrders = value
'  End Set
'End Property

'  pMaintenanceWorkOrders = New colMaintenanceWorkOrders 'Add to New
'  pMaintenanceWorkOrders = Nothing 'Add to Finalize
'  .MaintenanceWorkOrders = MaintenanceWorkOrders.Clone 'Add to CloneTo
'  MaintenanceWorkOrders.ClearKeys 'Add to ClearKeys
'    If Not mAnyDirty Then mAnyDirty = MaintenanceWorkOrders.IsDirty 'Add to IsAnyDirty

Public Class colMaintenanceWorkOrders : Inherits colBase(Of dmMaintenanceWorkOrder)

  Public Overrides Function IndexFromKey(ByVal vMaintenanceWorkOrderID As Integer) As Integer
    Dim mItem As dmMaintenanceWorkOrder
    Dim mIndex As Integer = -1
    Dim mCount As Integer = -1
    For Each mItem In MyBase.Items
      mCount += 1
      If mItem.MaintenanceWorkOrderID = vMaintenanceWorkOrderID Then
        mIndex = mCount
        Exit For
      End If
    Next
    Return mIndex
  End Function

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub New(ByVal vList As List(Of dmMaintenanceWorkOrder))
    MyBase.New(vList)
  End Sub

End Class


