Public Class clsMaintenanceWorkOrderInfo

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

  Public Property MaintenanceWorkOrderID As Int32
    Get
      Return pMaintenanceWorkOrderID
    End Get
    Set(value As Int32)
      pMaintenanceWorkOrderID = value
    End Set
  End Property

  Public Property MaintenanceWorkOrderNo As String
    Get
      Return pMaintenanceWorkOrderNo
    End Get
    Set(value As String)
      pMaintenanceWorkOrderNo = value
    End Set
  End Property

  Public Property Description As String
    Get
      Return pDescription
    End Get
    Set(value As String)
      pDescription = value
    End Set
  End Property

  Public Property WorkCentreID As Byte
    Get
      Return pWorkCentreID
    End Get
    Set(value As Byte)
      pWorkCentreID = value
    End Set
  End Property

  Public Property MaintenanceType As Byte
    Get
      Return pMaintenanceType
    End Get
    Set(value As Byte)
      pMaintenanceType = value
    End Set
  End Property

  Public Property EquipmentID As Int32
    Get
      Return pEquipmentID
    End Get
    Set(value As Int32)
      pEquipmentID = value
    End Set
  End Property

  Public Property EmployeeID As Int32
    Get
      Return pEmployeeID
    End Get
    Set(value As Int32)
      pEmployeeID = value
    End Set
  End Property

  Public Property Priority As Int32
    Get
      Return pPriority
    End Get
    Set(value As Int32)
      pPriority = value
    End Set
  End Property

  Public Property PlannedDate As DateTime
    Get
      Return pPlannedDate
    End Get
    Set(value As DateTime)
      pPlannedDate = value
    End Set
  End Property

  Public Property Status As Byte
    Get
      Return pStatus
    End Get
    Set(value As Byte)
      pStatus = value
    End Set
  End Property

  Public Property Duration As Decimal
    Get
      Return pDuration
    End Get
    Set(value As Decimal)
      pDuration = value
    End Set
  End Property

  Public Property Notes As String
    Get
      Return pNotes
    End Get
    Set(value As String)
      pNotes = value
    End Set
  End Property

  Public Property MaintenanceWorkOrderDocument As String
    Get
      Return pMaintenanceWorkOrderDocument
    End Get
    Set(value As String)
      pMaintenanceWorkOrderDocument = value
    End Set
  End Property

End Class
