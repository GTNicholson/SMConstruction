Imports System.ComponentModel

Public Enum eActivityCode
  Undefined = 0            'RTIS Project Start Standard
  Configuration = 1        'RTIS Project Start Standard
  UserConfig = 2           'RTIS Project Start Standard
  OverideUserPassword = 3  'RTIS Project Start Standard
  ForceLockRemoval = 4     'RTIS Project Start Standard

  Sales = 100

  Production = 200

End Enum

Public Enum eObjectType
  SalesOrder = 1
  WorkOrder = 2
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
  <Description("Optimización")> Optimizacion = 1
  <Description("Maquinado")> Maquinado = 2
  <Description("Ensamble")> Ensamble = 3
  <Description("Lija")> Lija = 4
  <Description("Metal")> Metal = 5
  <Description("Tapizado")> Tapizado = 6
  <Description("Pintura")> Pintura = 7
  <Description("Empaque")> Empaque = 8
  <Description("Despacho")> Despacho = 9

End Enum

Public Enum eProductType
  <Description("Mueble")> ProductFurniture = 1
  <Description("Estructura")> Strucutre = 2
End Enum

Public Enum eMilestoneStatus
  Pending = 0
  NotRequired = 1
  PartComplete = 2
  Complete = 3

End Enum

Public Enum eWorkOrderMilestone
  Design = 1
  Specification = 2
  MaterialPurchasing = 3
  WoodPurchasing = 4
End Enum

Public Enum eIVAType
  Aplica = 1
  NoAplica = 2
End Enum

Public Class colTimeSheetCodes : Inherits RTIS.ERPCore.colPropertyENUMOfT(Of clsTimeSheetCode)
  Private Shared sTimeSheetCodes As colTimeSheetCodes

  Private Sub New()
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cUnDefined, "Sin Def", " ", System.Drawing.Color.White))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cWorkOrder, "OT", "", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cAbsent, "Absencia", "A", System.Drawing.Color.Lavender))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cHoliday, "Vaccacion", "V", System.Drawing.Color.Lavender))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cMaintenance, "Mantenamiento", "M", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cSick, "Enfremo", "E", System.Drawing.Color.Lavender))
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

End Class