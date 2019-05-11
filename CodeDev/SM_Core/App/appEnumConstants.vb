

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

Public Enum eGridViewType
  Grid = 1
  Card = 2
  Layout = 3
End Enum

Public Enum eBrowseList
  Undefined = 0
  CurrentUserLocks = 1
  CurrentUsersLoggedOn = 2

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
End Enum

Public Enum eParentType
  WorkOrder = 1
End Enum

Public Enum eFileType
  Excel = 1
  PDF = 2
  SNX = 3
End Enum

Public Enum eDocumentType
  WorkOrderDoc = 1
End Enum

Public Class clsConstants

  Public Const WorkOrderFileFolder As String = "OTArchivos"

End Class