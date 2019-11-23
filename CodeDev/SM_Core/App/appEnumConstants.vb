Imports System.ComponentModel

Public Enum eActivityCode
  Undefined = 0            'RTIS Project Start Standard
  Configuration = 1        'RTIS Project Start Standard
  UserConfig = 2           'RTIS Project Start Standard
  OverideUserPassword = 3  'RTIS Project Start Standard
  ForceLockRemoval = 4     'RTIS Project Start Standard

  Sales = 100

  Production = 200

  HumanResources = 300
  EmployeeSalaries = 301

End Enum

Public Enum eObjectType
  SalesOrder = 1
  WorkOrder = 2
End Enum

Public Enum eEmployeeRole
  <Description("Ventas")> Sales = 1
  <Description("Ingeneria")> Engineering = 2
  <Description("Production")> Production = 3
  <Description("Administracion")> Admin = 4
End Enum

Public Enum eCustomerStatus
  <Description("Activo")> Active = 1
  <Description("Inactivo")> Inactive = 0
End Enum

Public Enum eGridViewType
  Grid = 1
  Card = 2
  Layout = 3
End Enum

Public Enum eBrowseList
  Undefined = 0
  CurrentUserLocks = 1
  CurrentUsersLoggedOn = 2
  Customer = 3
  SalesOrders = 4
  WorkOrder = 5
  InternalWorkOrder = 6

End Enum


Public Enum eSalesOrderstatus
  <Description("Abierto")> Abierto = 0
  <Description("En Progreso")> EnProgreso = 1
  <Description("Completada")> Completed = 2
  <Description("Cancelada")> Cancelada = 3
End Enum

Public Enum eOTstatus
  <Description("Abierto")> Abierto = 0
  <Description("En Progreso")> EnProgreso = 1
  <Description("Completada")> Completed = 2
  <Description("Cancelada")> Cancelada = 3
End Enum

Public Enum eEmployeeTimeLogType
  WorksOrder = 1
  Maintenance = 2
  Holiday = 3
  Absent = 4
  Other = 5
End Enum

Public Enum eReportSource
  WorkOrder = 1
  TimeSheet = 2
End Enum

Public Enum eParentType
  WorkOrder = 1
  SalesOrder = 2
End Enum

Public Enum eFileType
  Excel = 1
  PDF = 2
  SNX = 3
End Enum

Public Enum eDocumentType
  WorkOrderDoc = 1
  SalesOrder = 2
End Enum

Public Enum eTallyIDs
  WorkOrder = 1
End Enum

Public Enum eWorkCentre
  <Description("Sin Def.")> Undefined = 0
  <Description("Ingeniería")> Engineering = 12
  <Description("Selección")> Selection = 13
  <Description("Dimensionado")> Dimensionado = 1
  <Description("Maquinado")> Machining = 2
  <Description("Ensamble")> Assembly = 3
  <Description("Lija")> Sanding = 4
  <Description("Acabado")> Painting = 5
  <Description("Metal")> MetalWork = 6
  <Description("Tapizado")> Upholstery = 7
  <Description("SubContratación")> SubContract = 8
  <Description("Empaque")> Packaing = 9
  <Description("Despacho")> Dispatching = 10
  <Description("Instalación")> Installing = 11

End Enum

Public Enum eProductType
  <Description("Mueble")> ProductFurniture = 1
  <Description("Estructura")> Strucutre = 2
End Enum

Public Enum eOrderType
  <Description("Venta")> Sales = 2
  <Description("Consumo Interno")> Interno = 1
  <Description("Pre Venta")> PreSale = 3
  <Description("Muestra de Acabado")> Sample = 4
  <Description("Proyecto")> Project = 5
  <Description("Mueble")> Furniture = 6


End Enum


Public Enum eMaterialRequirementType
  Wood = 1
  Other = 2
  WoodChanges = 3
  OtherChanges = 4
End Enum

Public Enum eMilestoneStatus
  Pending = 0
  NotRequired = 1
  PartComplete = 2
  Complete = 3

End Enum

''Public Enum eWorkOrderMilestone
''  Engineering = 1
''  Dimensioning = 2
''  Machining = 3
''  Assembly = 4
''  Sanding = 5
''  Painting = 6
''  MetalWork = 7
''  Upholstery = 8

''End Enum

Public Enum eIVAType
  Aplica = 1
  NoAplica = 2
End Enum

Public Class colTimeSheetCodes : Inherits RTIS.ERPCore.colPropertyENUMOfT(Of clsTimeSheetCode)
  Private Shared sTimeSheetCodes As colTimeSheetCodes

  Private Sub New()
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cUnDefined, "Sin Def", " ", System.Drawing.Color.White))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cWorkOrder, "OT", "", System.Drawing.Color.Green))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cAbsent, "Ausencia", "A", System.Drawing.Color.Gray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cHoliday, "Vacaciones", "V", System.Drawing.Color.Gray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cMaintenance, "Mantenimiento", "M", System.Drawing.Color.Tomato))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cSick, "Enfermo", "E", System.Drawing.Color.Gray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cCleaning, "Limpieza", "L", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cStop, "Demora", "D", System.Drawing.Color.Tomato))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cWorkAllowance, "Subsidio", "S", System.Drawing.Color.Gray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cMaterialTransportation, "Traslado", "T", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cInventory, "Inventario", "I", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cPrototype, "Prototipo", "P", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cPermission, "Consentiiento", "C", System.Drawing.Color.Gray))


  End Sub

  Public Shared ReadOnly Property GetInstance As colTimeSheetCodes
    Get
      If sTimeSheetCodes Is Nothing Then
        sTimeSheetCodes = New colTimeSheetCodes
      End If
      Return sTimeSheetCodes
    End Get
  End Property

  Public Function ItemFromKeyCode(ByVal vKeyCode As String) As clsTimeSheetCode
    Dim mRetval As clsTimeSheetCode = Nothing
    For Each mTSC As clsTimeSheetCode In Me.Items
      If mTSC.KeyCode = vKeyCode Then
        mRetval = mTSC
      End If
    Next
    Return mRetval
  End Function

End Class

Public Class clsTimeSheetCode : Inherits RTIS.ERPCore.clsPropertyENUM
  Private pKeyCode As String
  Private pColour As System.Drawing.Color

  Public Const cUnDefined = 0
  Public Const cWorkOrder = 1
  Public Const cAbsent = 2
  Public Const cHoliday = 3
  Public Const cMaintenance = 4
  Public Const cSick = 5
  Public Const cCleaning = 6
  Public Const cStop = 7
  Public Const cWorkAllowance = 8
  Public Const cMaterialTransportation = 9
  Public Const cInventory = 10
  Public Const cPrototype = 11
  Public Const cPermission = 12

  Public Sub New(ByVal vID As Integer, vDescription As String, vKeyCode As String, vColour As System.Drawing.Color)
    MyBase.New(vID, vDescription)
    pKeyCode = vKeyCode
    pColour = vColour
  End Sub



  Public ReadOnly Property KeyCode As String
    Get
      Return pKeyCode
    End Get
  End Property

  Public ReadOnly Property Colour As System.Drawing.Color
    Get
      Return pColour
    End Get
  End Property

End Class

Public Class clsConstants

  Public Const WorkOrderFileFolderSys As String = "OTArchivosSys"
  Public Const WorkOrderFileFolderUsr As String = "OTArchivosUsr"

  Public Const SalesOrderFileFolderSys As String = "SOArchivosSys"
  Public Const SalesOrderFileFolderUsr As String = "SOArchivosUsr"

  Public Const WorkOrderNoPrefix = "OT"
  Public Const SalesOrderPrefix = "SO"
  Public Const SampleOrderPrexi = "IN"


  Public Const TaxRate = 0.15

End Class