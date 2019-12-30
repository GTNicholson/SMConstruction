Imports System.ComponentModel
Imports RTIS.ERPCore

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

  Purchasing = 400

  Inventory = 500

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
  Inventory = 7
  Supplier = 8
  StockTake = 9
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
  InternalWorkOrder = 3
End Enum

Public Enum eFileType
  Excel = 1
  PDF = 2
  SNX = 3
End Enum

Public Enum eDocumentType
  WorkOrderDoc = 1
  SalesOrder = 2
  InternalWorkOrder = 3
End Enum

Public Enum eTallyIDs
  WorkOrder = 1
  InternalWorkOrder = 2
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

Public Enum eStockItemCategory
  <Description("Ninguno")> None = 0
  <Description("Abrasivos")> Abrasivos = 1
  <Description("Clavos y Tornillos")> NailsAndBolds = 2
  <Description("Equipos de Proteccion")> EPP = 3
  <Description("Herrajes")> Herrajes = 4
  <Description("Herramientas")> Herramientas = 5
  <Description("Materiales Electricos")> MatElect = 6
  <Description("Material Empaque")> MatEmpaque = 7
  <Description("Materiales Varios")> MatVarios = 8
  <Description("Metales")> Metal = 9
  <Description("Pinturas y Quimicos")> PinturaYQuimico = 10
  <Description("Plywood")> Plywood = 11
  <Description("Repuestos y Partes")> Repuestos = 12
  <Description("Tapiceria")> Tapiceria = 13
  <Description("Vidrios y Espejos")> VidrioYEspejo = 14
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
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cPermission, "Consentimiento", "C", System.Drawing.Color.Gray))


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

Public Class clsStockItemTypeAbrasivos : Inherits clsPropertyENUM
  Private pStockSubItemTypeAbrasivos As colStockSubItemTypeAbrasivos

  Public Property StockSubItemTypeAbrasivos As colStockSubItemTypeAbrasivos
    Get
      Return pStockSubItemTypeAbrasivos
    End Get
    Set(value As colStockSubItemTypeAbrasivos)
      pStockSubItemTypeAbrasivos = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeAbrasivos = New colStockSubItemTypeAbrasivos
  End Sub

End Class

Public Class clsStockSubItemTypeAbrasivos : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeAbrasivos : Inherits List(Of clsStockSubItemTypeAbrasivos)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeAbrasivos
    For Each mItem As clsStockSubItemTypeAbrasivos In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeAbrasivos : Inherits colPropertyENUMOfT(Of clsStockItemTypeAbrasivos)

  Enum eStockItemAbrasivos
    EsponjasYPastes = 1
    LijaBanda = 2
    LijaDisco = 3
    LijaPliego = 4
    LijaRollo = 5
    Otros = 99
  End Enum


  Public Const EsponjasYPastes = 1
  Public Const LijaBanda = 2
  Public Const LijaDisco = 3
  Public Const LijaPliego = 4
  Public Const LijaRollo = 5
  Public Const Otros = 99


  Private Shared mSharedInstance As eStockItemTypeAbrasivos

  Public Sub New()
    MyBase.New()

    Dim mEsponjaYPaste As New clsStockItemTypeAbrasivos(EsponjasYPastes, "Esponjas y Pastes")
    MyBase.Add(mEsponjaYPaste)

    Dim mLijaBanda As New clsStockItemTypeAbrasivos(LijaBanda, "Lija Banda")
    MyBase.Add(mLijaBanda)

    Dim mLijaPliego As New clsStockItemTypeAbrasivos(LijaPliego, "Lija Pliego")
    MyBase.Add(mLijaPliego)

    Dim mLijaRollo As New clsStockItemTypeAbrasivos(LijaRollo, "Lija Rollo")
    MyBase.Add(mLijaRollo)

    Dim mOtros As New clsStockItemTypeAbrasivos(Otros, "Los demás")
    MyBase.Add(mOtros)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeAbrasivos
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeAbrasivos
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeNailsAndBolts : Inherits clsPropertyENUM
  Private pStockSubItemTypeNailsAndBolts As colStockSubItemTypeNailsAndBolts

  Public Property StockSubItemTypeNailsAndBolts As colStockSubItemTypeNailsAndBolts
    Get
      Return pStockSubItemTypeNailsAndBolts
    End Get
    Set(value As colStockSubItemTypeNailsAndBolts)
      pStockSubItemTypeNailsAndBolts = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeNailsAndBolts = New colStockSubItemTypeNailsAndBolts
  End Sub

End Class

Public Class clsStockSubItemTypeNailsAndBolts : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeNailsAndBolts : Inherits List(Of clsStockSubItemTypeNailsAndBolts)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeNailsAndBolts
    For Each mItem As clsStockSubItemTypeNailsAndBolts In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeNailsAndBolts : Inherits colPropertyENUMOfT(Of clsStockItemTypeNailsAndBolts)

  Public Enum eStockItemNailAndBolts
    Clavos = 1
    Tornillos = 2
    Pernos = 3
    Golosos = 4
  End Enum

  Public Const Clavos = 1
  Public Const Tornillos = 2
  Public Const Pernos = 3
  Public Const Golosos = 4

  Private Shared mSharedInstance As eStockItemTypeNailsAndBolts

  Public Sub New()
    MyBase.New()

    Dim mClavos As New clsStockItemTypeNailsAndBolts(Clavos, "Clavos")
    MyBase.Add(mClavos)

    Dim mTornillos As New clsStockItemTypeNailsAndBolts(Tornillos, "Tornillos")
    MyBase.Add(mTornillos)

    Dim mPernos As New clsStockItemTypeNailsAndBolts(Pernos, "Pernos")
    MyBase.Add(mPernos)

    Dim mGolosos As New clsStockItemTypeNailsAndBolts(Golosos, "Golosos")
    MyBase.Add(mGolosos)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeNailsAndBolts
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeNailsAndBolts
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeHerrajes : Inherits clsPropertyENUM
  Private pStockSubItemTypeHerrajes As colStockSubItemTypeHerrajes

  Public Property StockSubItemTypeHerrajes As colStockSubItemTypeHerrajes
    Get
      Return pStockSubItemTypeHerrajes
    End Get
    Set(value As colStockSubItemTypeHerrajes)
      pStockSubItemTypeHerrajes = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeHerrajes = New colStockSubItemTypeHerrajes
  End Sub

End Class

Public Class clsStockSubItemTypeHerrajes : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeHerrajes : Inherits List(Of clsStockSubItemTypeHerrajes)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeHerrajes
    For Each mItem As clsStockSubItemTypeHerrajes In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeHerrajes : Inherits colPropertyENUMOfT(Of clsStockItemTypeHerrajes)

  Public Enum eStockItemHerrajes
    Riel = 1
    Tuercas = 2
    Arandelas = 3
    Bisagras = 4
    ResbalonesYNiveladores = 5
    Rodos = 6
    HerrajesEspeciales = 7
    Portatiles = 8
    Otros = 99
  End Enum

  Public Const Riel = 1
  Public Const Tuercas = 2
  Public Const Arandelas = 3
  Public Const Bisagras = 4
  Public Const ResbalonesYNiveladores = 5
  Public Const Rodos = 6
  Public Const HerrajesEspeciales = 7
  Public Const Portatiles = 8
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeHerrajes

  Public Sub New()
    MyBase.New()

    Dim mRiel As New clsStockItemTypeHerrajes(Riel, "Riel")
    MyBase.Add(mRiel)

    Dim mTuercas As New clsStockItemTypeHerrajes(Tuercas, "Tuercas")
    MyBase.Add(mTuercas)

    Dim mArandelas As New clsStockItemTypeHerrajes(Arandelas, "Arandelas")
    MyBase.Add(mArandelas)

    Dim mBisagras As New clsStockItemTypeHerrajes(Bisagras, "Bisagras")
    MyBase.Add(mBisagras)

    Dim mResbYNiv As New clsStockItemTypeHerrajes(ResbalonesYNiveladores, "Bisagras")
    MyBase.Add(mResbYNiv)

    Dim mRodos As New clsStockItemTypeHerrajes(Rodos, "Rodos")
    MyBase.Add(mRodos)

    Dim mHerrajesEspeciales As New clsStockItemTypeHerrajes(HerrajesEspeciales, "Herrajes Especiales")
    MyBase.Add(mHerrajesEspeciales)

    Dim mPortatiles As New clsStockItemTypeHerrajes(Portatiles, "Portatiles")
    MyBase.Add(mPortatiles)

    Dim mOtros As New clsStockItemTypeHerrajes(Otros, "Los Demás")
    MyBase.Add(mOtros)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeHerrajes
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeHerrajes
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeMaterialElectrico : Inherits clsPropertyENUM
  Private pStockSubItemTypeMaterialElectrico As colStockSubItemTypeMaterialElectrico

  Public Property StockSubItemTypeMaterialElectrico As colStockSubItemTypeMaterialElectrico
    Get
      Return pStockSubItemTypeMaterialElectrico
    End Get
    Set(value As colStockSubItemTypeMaterialElectrico)
      pStockSubItemTypeMaterialElectrico = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeMaterialElectrico = New colStockSubItemTypeMaterialElectrico
  End Sub

End Class

Public Class clsStockSubItemTypeMaterialElectrico : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeMaterialElectrico : Inherits List(Of clsStockSubItemTypeMaterialElectrico)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeMaterialElectrico
    For Each mItem As clsStockSubItemTypeMaterialElectrico In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeMaterialElectrico : Inherits colPropertyENUMOfT(Of clsStockItemTypeMaterialElectrico)

  Public Enum eStockItemMaterialElectrico
    General = 1
  End Enum

  Public Const General = 1

  Private Shared mSharedInstance As eStockItemTypeMaterialElectrico

  Public Sub New()
    MyBase.New()

    Dim mGeneral As New clsStockItemTypeMaterialElectrico(General, "General")
    MyBase.Add(mGeneral)


  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMaterialElectrico
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMaterialElectrico
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeMaterialEmpaque : Inherits clsPropertyENUM
  Private pStockSubItemTypeMaterialEmpaque As colStockSubItemTypeMaterialEmpaque

  Public Property StockSubItemTypeMaterialEmpaque As colStockSubItemTypeMaterialEmpaque
    Get
      Return pStockSubItemTypeMaterialEmpaque
    End Get
    Set(value As colStockSubItemTypeMaterialEmpaque)
      pStockSubItemTypeMaterialEmpaque = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeMaterialEmpaque = New colStockSubItemTypeMaterialEmpaque
  End Sub

End Class

Public Class clsStockSubItemTypeMaterialEmpaque : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeMaterialEmpaque : Inherits List(Of clsStockSubItemTypeMaterialEmpaque)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeMaterialEmpaque
    For Each mItem As clsStockSubItemTypeMaterialEmpaque In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeMaterialEmpaque : Inherits colPropertyENUMOfT(Of clsStockItemTypeMaterialEmpaque)

  Public Enum StockItemMaterialEmpaque
    Plasticos = 1
    Grapas = 2
    Otros = 99
  End Enum

  Public Const Plasticos = 1
  Public Const Grapas = 2
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeMaterialEmpaque

  Public Sub New()
    MyBase.New()

    Dim mPlasticos As New clsStockItemTypeMaterialEmpaque(Plasticos, "Plasticos")
    MyBase.Add(mPlasticos)

    Dim mGrapas As New clsStockItemTypeMaterialEmpaque(Grapas, "Grapas")
    MyBase.Add(mGrapas)

    Dim mOtros As New clsStockItemTypeMaterialEmpaque(Otros, "Los demás")
    MyBase.Add(mOtros)


  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMaterialEmpaque
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMaterialEmpaque
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeMetales : Inherits clsPropertyENUM
  Private pStockSubItemTypeMetales As colStockSubItemTypeMetales

  Public Property StockSubItemTypeMetales As colStockSubItemTypeMetales
    Get
      Return pStockSubItemTypeMetales
    End Get
    Set(value As colStockSubItemTypeMetales)
      pStockSubItemTypeMetales = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeMetales = New colStockSubItemTypeMetales
  End Sub

End Class

Public Class clsStockSubItemTypeMetales : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeMetales : Inherits List(Of clsStockSubItemTypeMetales)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeMetales
    For Each mItem As clsStockSubItemTypeMetales In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeMetales : Inherits colPropertyENUMOfT(Of clsStockItemTypeMetales)

  Public Enum eStockItemMetales
    Aluminio = 1
    Platinas = 2
    Tubos = 3
    Varillas = 4
    Otros = 99
  End Enum
  Public Const Aluminio = 1
  Public Const Platinas = 2
  Public Const Tubos = 3
  Public Const Varillas = 4
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeMetales

  Public Sub New()
    MyBase.New()

    Dim mAluminio As New clsStockItemTypeMetales(Aluminio, "Aluminio")
    MyBase.Add(mAluminio)

    Dim mPlatinas As New clsStockItemTypeMetales(Platinas, "Platinas")
    MyBase.Add(mPlatinas)

    Dim mTubos As New clsStockItemTypeMetales(Tubos, "Tubos")
    MyBase.Add(mTubos)

    Dim mVarillas As New clsStockItemTypeMetales(Varillas, "Varillas")
    MyBase.Add(mVarillas)

    Dim mOtros As New clsStockItemTypeMetales(Tubos, "Los demás")
    MyBase.Add(mOtros)




  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMetales
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMetales
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeRepuestosYPartes : Inherits clsPropertyENUM
  Private pStockSubItemTypeRepuestosYPartes As colStockSubItemTypeRepuestosYPartes

  Public Property StockSubItemTypeRepuestosYPartes As colStockSubItemTypeRepuestosYPartes
    Get
      Return pStockSubItemTypeRepuestosYPartes
    End Get
    Set(value As colStockSubItemTypeRepuestosYPartes)
      pStockSubItemTypeRepuestosYPartes = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeRepuestosYPartes = New colStockSubItemTypeRepuestosYPartes
  End Sub

End Class

Public Class clsStockSubItemTypeRepuestosYPartes : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeRepuestosYPartes : Inherits List(Of clsStockSubItemTypeRepuestosYPartes)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeRepuestosYPartes
    For Each mItem As clsStockSubItemTypeRepuestosYPartes In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeRepuestosYPartes : Inherits colPropertyENUMOfT(Of clsStockItemTypeRepuestosYPartes)

  Public Enum eStockItemRepuestosYPartes
    CuchillosYCabezales = 1
    Bandas = 2
    Balinera = 3
    BrocasYFresas = 4
    Otros = 99
  End Enum

  Public Const CuchillosYCabezales = 1
  Public Const Bandas = 2
  Public Const Balinera = 3
  Public Const BrocasYFresas = 4
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeRepuestosYPartes

  Public Sub New()
    MyBase.New()

    Dim mCuchillosYCabezales As New clsStockItemTypeRepuestosYPartes(CuchillosYCabezales, "Cuchillos y Cabezales")
    MyBase.Add(mCuchillosYCabezales)

    Dim mBandas As New clsStockItemTypeRepuestosYPartes(Bandas, "Bandas")
    MyBase.Add(mBandas)

    Dim mBalinera As New clsStockItemTypeRepuestosYPartes(Balinera, "Balinera")
    MyBase.Add(mBalinera)

    Dim mBrocayFresas As New clsStockItemTypeRepuestosYPartes(BrocasYFresas, "Brocas y Fresas")
    MyBase.Add(mBrocayFresas)

    Dim mOtros As New clsStockItemTypeRepuestosYPartes(Otros, "Los demás")
    MyBase.Add(mOtros)




  End Sub

  Public Shared Function GetInstance() As eStockItemTypeRepuestosYPartes
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeRepuestosYPartes
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeTapiceria : Inherits clsPropertyENUM
  Private pStockSubItemTypeTapiceria As colStockSubItemTypeTapiceria

  Public Property StockSubItemTypeTapiceria As colStockSubItemTypeTapiceria
    Get
      Return pStockSubItemTypeTapiceria
    End Get
    Set(value As colStockSubItemTypeTapiceria)
      pStockSubItemTypeTapiceria = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeTapiceria = New colStockSubItemTypeTapiceria
  End Sub

End Class

Public Class clsStockSubItemTypeTapiceria : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeTapiceria : Inherits List(Of clsStockSubItemTypeTapiceria)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeTapiceria
    For Each mItem As clsStockSubItemTypeTapiceria In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeTapiceria : Inherits colPropertyENUMOfT(Of clsStockItemTypeTapiceria)

  Public Enum eStockItemTapiceria
    Tachuelas = 1
    Nylons = 2
    Otros = 99
  End Enum


  Public Const Tachuelas = 1
  Public Const Nylons = 2
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeTapiceria

  Public Sub New()
    MyBase.New()

    Dim mTachuelas As New clsStockItemTypeTapiceria(Tachuelas, "Tachuelas")
    MyBase.Add(mTachuelas)

    Dim mNylons As New clsStockItemTypeTapiceria(Nylons, "Nylons")
    MyBase.Add(mNylons)

    Dim mOtros As New clsStockItemTypeTapiceria(Otros, "Los demás")
    MyBase.Add(mOtros)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeTapiceria
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeTapiceria
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeVidrioYEspejo : Inherits clsPropertyENUM
  Private pStockSubItemTypeVidrioYEspejo As colStockSubItemTypeVidrioYEspejo

  Public Property StockSubItemTypeVidrioYEspejo As colStockSubItemTypeVidrioYEspejo
    Get
      Return pStockSubItemTypeVidrioYEspejo
    End Get
    Set(value As colStockSubItemTypeVidrioYEspejo)
      pStockSubItemTypeVidrioYEspejo = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeVidrioYEspejo = New colStockSubItemTypeVidrioYEspejo
  End Sub

End Class

Public Class clsStockSubItemTypeVidrioYEspejo : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeVidrioYEspejo : Inherits List(Of clsStockSubItemTypeVidrioYEspejo)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeVidrioYEspejo
    For Each mItem As clsStockSubItemTypeVidrioYEspejo In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeVidrioYEspejo : Inherits colPropertyENUMOfT(Of clsStockItemTypeVidrioYEspejo)

  Public Enum eStockItemVidrioYEspejo
    Espejos = 1
    Vidrios = 2

  End Enum

  Public Const Espejos = 1
  Public Const Vidrios = 2


  Private Shared mSharedInstance As eStockItemTypeVidrioYEspejo

  Public Sub New()
    MyBase.New()

    Dim mEspejos As New clsStockItemTypeVidrioYEspejo(Espejos, "Espejos")
    MyBase.Add(mEspejos)

    Dim mVidrios As New clsStockItemTypeVidrioYEspejo(Vidrios, "Vidrios")
    MyBase.Add(mVidrios)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeVidrioYEspejo
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeVidrioYEspejo
    End If
    Return mSharedInstance
  End Function

End Class