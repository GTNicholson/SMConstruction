Imports System.ComponentModel
Imports RTIS.CommonVB

Public Enum eActivityCode
  Undefined = 0            'RTIS Project Start Standard
  Configuration = 1        'RTIS Project Start Standard
  UserConfig = 2           'RTIS Project Start Standard
  OverideUserPassword = 3  'RTIS Project Start Standard
  ForceLockRemoval = 4     'RTIS Project Start Standard




  SalesGroup = 100
  Customer = 101
  SalesOrder = 102
  TrackingSalesOrder = 103
  WoodSalesOrder = 104
  WoodSalesOrderBI = 105
  FurnitureSalesOrder = 106

  ProductionGroup = 200
  WorkOrders = 201
  StructureWorkOrder = 202
  TrackingWorkOrders = 203
  TimeSheetEntry = 204
  ProductionReport = 205
  InstallationWorkOrder = 206
  WoodPicking = 207


  HumanResourcesGroup = 300
  EmployeeSalaries = 301
  Employees = 302
  PaymentSlip = 303

  PurchasingGroup = 400
  Suppliers = 401
  PurchaseOrder = 402
  POConsole = 403
  PODelivery = 404
  POReportList = 405
  PODeliveryReport = 405
  PODeliveryItemReport = 405
  PurchasingBalance = 406
  SetFromStockQty = 407
  PurchasingManagement = 408 ''DO this activities
  ValidateConsole = 409
  ProcessConsola = 410

  InventoryGroup = 500
  StockItem = 501
  PickingMatReq = 502
  StockTake = 503
  TransactionReport = 504
  StockItemInfos = 505

  AccountsGroup = 600
  InvoicesReport = 601
  CompanyDayReport = 602
  FBConsumeReport = 603
  InvoiceModule = 604


  ProductsGroup = 700
  ProductAdmin = 701

  CostingGroup = 800
  ProductCost = 801
  WoodCosting = 802

  WoodGroup = 900
  WoodInventory = 901 '// was 506
  WoodPallet = 902 '// was 507
  WorkOrderWoodProcess = 903.0F
  WoodPalletItemReport = 904
  WoodReception = 905


End Enum

Public Enum eHomeScreen
  Management = 1
  Sales = 2
  Purchasing = 3
  Production = 4
  WoodManagement = 5
End Enum

Public Enum ePOStage
  <Description("Ninguno")> None = 0
  <Description("Preliminares")> Preliminares = 1
  <Description("Movimiento de Tierras")> MovTierra = 2
  <Description("Fundaciones")> Fundaciones = 3
  <Description("Pisos")> Pisos = 4
  <Description("Estructura Principal")> EstructuraPrincipal = 5
  <Description("Paredes")> Paredes = 6
  <Description("Techo")> Techo = 7
  <Description("Cielo Raso")> CieloRaso = 8
  <Description("Puertas y Ventanas")> PuertasVentanas = 9
  <Description("Instalaciones Electricas")> InstalacionesElectricas = 10
  <Description("Climatización")> Climatizacion = 11
  <Description("Limpieza Final y Entrega")> LimpiezaEntrega = 12
  <Description("Baños")> Bathroom = 13
  <Description("Hidrosanitaria")> Hidrosanitaria = 14
  <Description("Diseño Conceptual")> DisenoConceptual = 15
  <Description("Visualización")> Visualizacion = 16
  <Description("Proyecto Arquitectónico")> ProyectoArquitectonico = 17
  <Description("Diseño Especializado")> DisenoEspecializado = 18
  <Description("Tramitología")> Tramitilogia = 19
  <Description("Landscaping")> Landscaping = 20
  <Description("Administración - Gerencia Proyecto")> AdmonProyecto = 21
  <Description("Logística y Transporte")> LogisticaTransporte = 22
  <Description("Honorarios")> Honorarios = 23
  <Description("DB MAN")> DBMan = 24
  <Description("Muebles")> Furniture = 25
  <Description("Pergolas")> Pergolas = 26

End Enum
Public Enum eMode
  StockItemAdmin = 1
  StockItemInfos = 2
  StockItemProcessor = 3
End Enum

Public Enum eSupplirPrintOption
  MainAccount = 1
  SecondaryAccount = 2
End Enum

Public Enum eValuationMode
  <Description("Por Adelantado")> ForAdvanced = 0
  <Description("En Recepción")> BookIn = 1
  <Description("Al Pagar Factura")> InPayment = 2
End Enum



Public Enum eFarms
  <Description("Ninguno")> None = 0
  <Description("Cumplida")> Cumplida = 1
  <Description("Eden")> Eden = 2
  <Description("Ecoforestal")> Equiforest = 3

End Enum
Public Enum eLocations
  <Description("Ninguno")> None = 0
  <Description("WIP")> WIP = 1
  <Description("AgroForestal")> AgroForestal = 2
  <Description("MillWorks")> MillWorks = 3
  <Description("SawMills")> SawMills = 4
  <Description("NicaFrance-AgroForestal")> NicaFranceAgro = 5
  <Description("NicaFrance-SMM")> NicaFranceSMM = 6
End Enum

Public Enum eTaxRate
  <Description("Ninguno")> None = 0
  <Description("IVA")> IVA = 1

End Enum

Public Enum eBankName
  <Description("BAC")> BAC = 1
  <Description("BANCENTRO")> BANCENTRO = 2
  <Description("BANPRO")> BANPRO = 3
  <Description("BDF")> BDF = 4
  <Description("FICOSA")> FICOSA = 5
  <Description("LAFISE")> LAFISE = 6
  <Description("INTERBANCO GUATEMALA")> INTERBANCOGUATEMALA = 7
  <Description("KEYBANK NATIONAL ASSOCIATION")> KEYBANKNATIONALASSOCIATION = 8

End Enum
Public Enum ePaymentMethod
  <Description("Caja Chica")> None = 0
  <Description("Efectivo")> Cash = 1
  <Description("Cheque")> Check = 2
  <Description("Transferencia Nac.")> BankTransfer = 3
  <Description("Transferencia Int.")> BankInterTransfer = 4
End Enum

Public Enum eCOCType
  <Description("None")> None = 0
  <Description("FSC")> FSC = 1
  <Description("PEFC")> PEFC = 2
  <Description("Sin Certificado")> Uncertified = 3
End Enum

Public Enum eInvoiceStatus
  <Description("En Proceso")> InProcess = 1
  <Description("Generada")> Raised = 2
  <Description("Cancelada")> Cancelled = 3
End Enum
Public Enum ePODelivery
  <Description("Recibido")> Received = 1
  <Description("Pendiente")> Pending = 2
  <Description("Anulado")> Cancelled = 3
End Enum

Public Enum ePurchaseOrderDueDateStatus
  <Description("Ninguna")> None = 0
  <Description("Estimado")> Estimated = 1
  <Description("Confirmado")> Confirmed = 2
  <Description("Revisado")> Revised = 3
  <Description("Recibido")> Received = 4
  <Description("Entrega Parcial")> PartDelivered = 5
  <Description("Anulado")> Cancelled = 6
  <Description("En Proceso")> InProcess = 7
End Enum

Public Enum ePurchaseCategories
  <Description("Ninguna")> None = 0
  <Description("Madera")> Madera = 1
  <Description("Insumos Producción")> InsumosProduccion = 2
  <Description("Consumible Producción")> ConsumibleProduccion = 3
  <Description("Compra Administrativa")> CompraAdmon = 4
  <Description("Compra de Ingeniería")> CompraIngenieria = 5
  <Description("Mantenimiento")> Mantenimiento = 6
  <Description("Patio Y Aserrío")> PatioYAserrio = 7
  <Description("Inversión Herramienta")> InversionHerramienta = 8
  <Description("Seguridad")> Seguridad = 9
  <Description("Mejora de Edificio")> MejoraEdificio = 10
  <Description("Papelería de Oficinas")> Papeleria = 11
  <Description("Caja Chica")> CajaChica = 12
  <Description("Atención a Proyectos")> AtencionProyectos = 13
  <Description("EcoForestal")> EcoForestal = 14
  <Description("Finca El Edén")> FincaEden = 15
  <Description("Mano de Obra")> ManoObra = 16

  <Description("Otras")> Otro = 99
End Enum

Public Enum eObjectType
  SalesOrder = 1
  WorkOrder = 2
  StockItemLocation = 3
  StockTake = 4
  StockItemAmmendmentLog = 5
  MaterialRequirement = 6
  PODeliveryItem = 7
  PurchaseOrder = 8
  WoodPallet = 9
  ProductStructure = 10

End Enum

Public Enum eEmployeeRole
  <Description("Ventas")> Sales = 1
  <Description("Ingeniería")> Engineering = 2
  <Description("Producción")> Production = 3
  <Description("Administración")> Admin = 4
End Enum

Public Enum eCustomerType
  <Description("Normal")> Normal = 1
  <Description("Detallista")> Detallista = 2
End Enum

Public Enum eCustomerStatus
  <Description("Activo")> Active = 1
  <Description("Inactivo")> Inactive = 0
End Enum

Public Enum eSupplierStatus
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
  InstallationWorkOrder = 6
  Inventory = 7
  PurchaseOrder = 8
  StockTake = 9
  Supplier = 10
  Invoice = 11
  PODelivery = 12
  HouseType = 13
  ProductCost = 14
  StructureWorkOrder = 15
  WorkOrderWoodProcess = 16
  WoodCostBook = 17
  WoodReception = 18
  FurnitureSalesOrders = 19
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
  UnDefined = 0
  WorkOrder = 1
  Absent = 2
  Holiday = 3
  Maintenance = 4
  Sick = 5
  Cleaning = 6
  cStop = 7
  WorkAllowance = 8
  MaterialTransportation = 9
  Inventory = 10
  Prototype = 11
  Permission = 12
End Enum

Public Enum eReportSource
  WorkOrder = 1
  TimeSheet = 2
  StockItemTransactions = 3
  Invoice = 4
  WoodReqMatInfo = 5
  PurchaseOrder = 6
  PODelivery = 7
  PODeliveryItem = 8
  PurchaseOrderItem = 9
  WoodPalletItemInfo = 10
  MaterialRequirement = 11
End Enum

Public Enum eParentType
  WorkOrder = 1
  SalesOrder = 2
  InternalWorkOrder = 3
  StockItem = 4
  PurchaseOrder = 5
  Invoice = 6
End Enum

Public Enum eFileType
  Excel = 1
  PDF = 2
  SNX = 3
  JPG = 4
  PNG = 5
End Enum

Public Enum eDocumentType
  WorkOrderDoc = 1
  SalesOrder = 2
  InternalWorkOrder = 3
  PurchaseOrder = 4
  StockItem = 5
  Invoice = 6
End Enum
Public Enum eEmailTemplate
  None = 0
  PurchaseOrder = 1
End Enum
Public Enum eTallyIDs
  WorkOrder = 1
  StructureWO = 2
  PurchaseOrderNo = 3
  GRNNumber = 1002
  WoodPallet = 1003
  RollWoodOT = 1004
  MAVWoodOT = 1005
  MASWoodOT = 1006
  AserradoWoodOT = 1007
  ClassifiedWoodOT = 1008
  WoodReception = 1009
  RequisaNumber = 1010
End Enum

Public Enum ePaymentStatus
  <Description("Pendiente")> Pending = 1
  <Description("Aprobado")> Approved = 2
  <Description("Pagado")> Paid = 3
End Enum
Public Enum eWorkOrderWoodProcess

  <Description("A Aserrío")> Aserrio = 1
  <Description("A Horno")> Horno = 2
  <Description("A Clasificación")> Clasificar = 3
  <Description("A Cepillado")> Cepillado = 4
  <Description("A Devolución")> Devolucion = 5
  <Description("A Rechazo")> Rechazo = 6
End Enum


Public Enum eCurrency
  <Description("Dólar (USD)")> Dollar = 0
  <Description("Córdobas")> Cordobas = 1
End Enum
Public Enum eWorkCentre
  <Description("Sin Def.")> Undefined = 0
  <Description("Madera")> Wood = 1
  <Description("Insumos")> Insumos = 2
  <Description("Ingeniería")> Engineering = 3
  <Description("Compras")> Purchasing = 4
  <Description("Selección")> Selection = 5
  <Description("Dimensionado")> Dimensionado = 6
  <Description("Carpintería")> Maquinado = 7
  <Description("Lija")> Sanding = 8
  <Description("Acabado")> Finishing = 9
  <Description("Metales")> MetalWork = 10
  <Description("Acabado Metal")> MetalFinising = 11
  <Description("Empaque")> Packaging = 12
  <Description("Despacho")> Despatch = 13
  '<Description("Laminado")> Laminated = 14
  '<Description("Ensamble")> Assembly = 15
  '<Description("Tapizado")> Upholstery = 16
  '<Description("Carga Contenedor")> ChargeContainer = 17
  <Description("Tapizado")> Tapizado = 18
  <Description("Tejido")> Tejido = 19

End Enum

Public Enum eProductType
  <Description("Mueble")> ProductFurniture = 1
  <Description("Estructura")> StructureAF = 2
  <Description("Instalación")> ProductInstallation = 3
  <Description("WooodWorkOrder")> WoodWorkOrder = 4
  <Description("WoodSalesOrder")> WoodSalesOrder = 5

End Enum

Public Enum eOrderType
  <Description("Venta de Casas")> Sales = 2
  <Description("Consumo Interno")> Interno = 1
  <Description("Madera")> WoodSales = 3
  <Description("Muebles")> Furnitures = 4
  <Description("Consumo Interno Muebles")> InternalFurniture = 5


End Enum



Public Enum eStockItemCategory
  <Description("Ninguno")> None = 0
  <Description("Abrasivos")> Abrasivos = 1
  <Description("Sistemas de Fijación")> Fixings = 2
  <Description("Equipos de Proteccion")> EPP = 3
  <Description("Herrajes")> Herrajes = 4
  <Description("Herramientas")> Herramientas = 5
  <Description("Materiales Electricos")> MatElect = 6
  <Description("Material Empaque")> MatEmpaque = 7
  <Description("Materiales Varios")> MatVarios = 8
  <Description("Metales")> Metal = 9
  <Description("Pinturas y Quimicos")> PinturaYQuimico = 10
  <Description("Laminas")> Laminas = 11
  <Description("Repuestos y Partes")> Repuestos = 12
  <Description("Tapiceria")> Tapiceria = 13
  <Description("Vidrios y Espejos")> VidrioYEspejo = 14
  <Description("Madera en Timber")> Timber = 15
  <Description("Plomería")> Plumbing = 16
  <Description("Albañilería")> BrickWork = 17
  ' <Description("Madera Dimensionada")> DimensionWood = 16
  '<Description("Madera Secada")> DriedWood = 17
End Enum

Public Enum eMaterialRequirementType
  Wood = 1
  StockItems = 2
  WoodChanges = 3
  OtherChanges = 4
End Enum

Public Enum eProductStatus
  Active = 0
  Obsolete = 1
End Enum

Public Enum eWorkOrderStatus
  <Description("En Proceso")> InProcess = 1
  <Description("Dibujos Liberados")> Raised = 4
  <Description("Completado")> Complete = 2
  <Description("Cancelada")> Cancelled = 3

End Enum
Public Enum eProductBOMObjectType
  Wood = 1
  StockItems = 2
  WoodChanges = 3
  OtherChanges = 4
End Enum


Public Enum ePOMaterialRequirementType
  <Description("Inventario")> Inventario = 1
  <Description("Sencillo")> Sencillo = 2
  <Description("Multiple")> Multiple = 3
End Enum

Public Enum eMilestoneStatus
  Pending = 0
  NotRequired = 1
  PartComplete = 2
  Complete = 3

End Enum

Public Enum eUoM
  <Description("Ninguno")> None = 0
  <Description("mt")> mt = 1
  <Description("cm")> Cm = 2
  <Description("mm")> mm = 3
  <Description("yd")> yd = 4
  <Description("in")> pul = 5
  <Description("ft")> ft = 6




  <Description("lt")> lt = 7
  <Description("ml")> ml = 8
  <Description("mm3")> mm3 = 9
  <Description("cm3")> cm3 = 10
  <Description("gln")> gal = 11

  <Description("und")> und = 12
  <Description("cja")> cja = 13

  <Description("mt2")> Metros2 = 14
  <Description("cm2")> cmm2 = 15

  <Description("PT")> PT = 16
  <Description("kg")> KG = 17

  <Description("mt3")> MT3 = 18
  <Description("GLB")> GLB = 19

  <Description("Lb")> Lb = 20
  <Description("Bls")> BLS = 21

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

Public Class colTimeSheetCodes : Inherits RTIS.CommonVB.colPropertyENUMOfT(Of clsTimeSheetCode)
  Private Shared sTimeSheetCodes As colTimeSheetCodes

  Private Sub New()
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cUnDefined, "Sin Def", " ", System.Drawing.Color.White))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cWorkOrder, "OT", "", System.Drawing.Color.PaleGreen))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cAbsent, "Ausencia", "A", System.Drawing.Color.DarkGray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cHoliday, "Vacaciones", "V", System.Drawing.Color.Tomato))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cMaintenance, "Mantenimiento", "M", System.Drawing.Color.Yellow))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cSick, "Enfermo", "E", System.Drawing.Color.DimGray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cCleaning, "Limpieza", "L", System.Drawing.Color.LightSalmon))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cStop, "Demora", "D", System.Drawing.Color.Red))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cWorkAllowance, "Subsidio", "S", System.Drawing.Color.LightGray))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cMaterialTransportation, "Traslado", "T", System.Drawing.Color.PowderBlue))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cInventory, "Inventario", "I", System.Drawing.Color.SkyBlue))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cPrototype, "Prototipo", "P", System.Drawing.Color.DodgerBlue))
    Me.Items.Add(New clsTimeSheetCode(clsTimeSheetCode.cPermission, "Consentimiento", "C", System.Drawing.Color.Gainsboro))


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

Public Class clsTimeSheetCode : Inherits RTIS.CommonVB.clsPropertyENUM
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
  Public Const OTRequisas As String = "OTRequisas"

  Public Const StockItemFileFolderSys As String = "SIArchivosSys"
  Public Const ProductFileFolderSys As String = "ProductArchivosSys"

  Public Const SalesOrderFileFolderSys As String = "SOArchivosSys"
  Public Const InvoiceOrderFileFolderSys As String = "InvoiceArchivosSys"
  Public Const PurchaseOrderFileFolderSys As String = "POArchivosSys"
  Public Const PODeliveryFileFolderSys As String = "PODeliveryArchivosSys"
  Public Const SalesOrderFileFolderUsr As String = "SOArchivosUsr"
  Public Const cProductFiles As String = "ProductFiles"

  Public Const WorkOrderNoPrefix = "OT"
  Public Const SalesOrderPrefix = "SO"
  Public Const SampleOrderPrexi = "IN"


  Public Const VATRATE = 0.15

  Public Const BoardFeetPerM3 = 423.776

  Public Const CMToInches = 2.54


  Public Const cWorkBeginTimeMT As String = "07:00:00"  ' CSng(CDate("07:00:00"))
  Public Const cWorkEndTimeMT As String = "17:00:00" 'CSng(CDate("15:15:00"))
  Public Const cWorkBeginTimeFri As String = "07:00:00" 'CSng(CDate("07:00:00"))
  Public Const cWorkEndTimeFri As String = "17:00:00" 'CSng(CDate("13:00:00"))



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

Public Class clsStockItemType : Inherits clsPropertyENUM
  Private pAbreviation As String

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vAbreviation As String)
    MyBase.New(vPropertyENUM, vDescription)
    pAbreviation = vAbreviation
  End Sub

  Public ReadOnly Property Abreviation As String
    Get
      Return pAbreviation
    End Get
  End Property


End Class

Public Class colStockSubItemTypeAbrasivos : Inherits List(Of clsStockItemType)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockItemType
    For Each mItem As clsStockItemType In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeAbrasivos : Inherits colPropertyENUMOfT(Of clsStockItemType)

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

    Dim mEsponjaYPaste As New clsStockItemType(EsponjasYPastes, "Esponjas y Pastes", "EP")
    MyBase.Add(mEsponjaYPaste)

    Dim mLijaBanda As New clsStockItemType(LijaBanda, "Lija Banda", "LB")
    MyBase.Add(mLijaBanda)

    Dim mLijaDisco As New clsStockItemType(LijaDisco, "Lija Disco", "LD")
    MyBase.Add(mLijaDisco)


    Dim mLijaPliego As New clsStockItemType(LijaPliego, "Lija Pliego", "LP")
    MyBase.Add(mLijaPliego)

    Dim mLijaRollo As New clsStockItemType(LijaRollo, "Lija Rollo", "LR")
    MyBase.Add(mLijaRollo)

    Dim mOtros As New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mOtros)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeAbrasivos
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeAbrasivos
    End If
    Return mSharedInstance
  End Function

End Class

Public Class clsStockItemTypeFixings : Inherits clsPropertyENUM
  Private pStockSubItemTypeFixings As colStockSubItemTypeFixings
  Private pStockCodeStr As String
  Public Property StockSubItemTypeFixings As colStockSubItemTypeFixings
    Get
      Return pStockSubItemTypeFixings
    End Get
    Set(value As colStockSubItemTypeFixings)
      pStockSubItemTypeFixings = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeFixings = New colStockSubItemTypeFixings
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypeFixings : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class colStockSubItemTypeFixings : Inherits List(Of clsStockSubItemTypeFixings)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeFixings
    For Each mItem As clsStockSubItemTypeFixings In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeFixings : Inherits colPropertyENUMOfT(Of clsStockItemTypeFixings)

  Public Const Clavos = 1
  Public Const Tornillos = 2
  Public Const Pernos = 3
  Public Const Golosos = 4
  Public Const Tuercas = 5
  Public Const Arandelas = 6
  Public Const Tachuelas = 7
  Public Const Espiches = 8
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeFixings

  Public Sub New()
    MyBase.New()
    Dim mFixingType As clsStockItemTypeFixings

    mFixingType = New clsStockItemTypeFixings(Clavos, "Clavos", "CL")
    MyBase.Add(mFixingType)
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.PuntaFina, "Punta Fina", "P/F"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.Estandar, "Estándar", "STD"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.Pistolas, "Para Pistolas", "PTL"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.Presion, "Para Presión", "PRS"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.SinCabeza, "Sin Cabeza", "PRS"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.Techo, "Para Techo", "TCH"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eNailsType.Other, "Otros", "OTR"))



    mFixingType = New clsStockItemTypeFixings(Tornillos, "Tornillos", "TN")
    MyBase.Add(mFixingType)
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eScrewTypes.Wood, "Madera", "TDM"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eScrewTypes.Gypsum, "Gypsum", "TDG"))


    mFixingType = New clsStockItemTypeFixings(Pernos, "Pernos", "PE")
    MyBase.Add(mFixingType)
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eCapScrewType.Hexagonal, "Perno Hexagonal", "PHX"))


    mFixingType = New clsStockItemTypeFixings(Golosos, "Golosos", "GO")
    MyBase.Add(mFixingType)
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eGolososType.Estandar, "Estándar", "STD"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eGolososType.Hexagonal, "Hexagonal", "HXG"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eGolososType.HexagonalPuntaFina, "Hexagonal Punta Fina", "HPF"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eGolososType.PuntaFina, "Punta Fina", "P/F"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eGolososType.Other, "Otros", "OTR"))



    mFixingType = New clsStockItemTypeFixings(Tuercas, "Tuercas", "TUE")
    MyBase.Add(mFixingType)

    mFixingType = New clsStockItemTypeFixings(Espiches, "Espiches", "ESP")
    MyBase.Add(mFixingType)

    mFixingType = New clsStockItemTypeFixings(Tachuelas, "Tachuelas", "TAC")
    MyBase.Add(mFixingType)


    mFixingType = New clsStockItemTypeFixings(Arandelas, "Arandelas", "AR")
    MyBase.Add(mFixingType)
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eWhasherType.Presion, "Presión", "PRS"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eWhasherType.Plana, "Plana", "PLN"))

    mFixingType = New clsStockItemTypeFixings(Otros, "Los demás", "OTR")
    MyBase.Add(mFixingType)
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eFixingsOther.Grapas, "Grapas", "GRP"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eFixingsOther.Alcayata, "Alcayata", "ACT"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eFixingsOther.VarillaRoscada, "Varilla Roscada", "VRR"))
    mFixingType.StockSubItemTypeFixings.Add(New clsStockSubItemTypeFixings(eFixingsOther.Other, "Otros", "OTR"))

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeFixings
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeFixings
    End If
    Return mSharedInstance
  End Function

End Class

Public Enum eCapScrewType
  Hexagonal = 1
  Other = 99
End Enum

Public Enum eScrewTypes
  Wood = 1
  Gypsum
  Other = 99
End Enum
Public Enum eNailsType
  PuntaFina = 1
  Pistolas = 2
  Presion = 3
  Estandar = 4
  SinCabeza = 5
  Techo = 6
  Other = 99
End Enum
Public Enum eHeadType
  <Description("Cabeza Plana")> CabezaPlana = 1
  <Description("Phillips")> Phillips = 2
  <Description("Hexagonal")> Hexagonal = 3
  <Description("Allen")> Allen = 4
  <Description("Cuadrado")> Cuadrado = 5
  <Description("Cap")> Cap = 6
  <Description("Seguridad")> Seguridad = 7


End Enum
Public Enum eFixingsOther
  Grapas = 1
  VarillaRoscada = 2
  Alcayata = 3
  Other = 99
End Enum
Public Enum eWhasherType
  Presion = 1
  Plana = 2
End Enum
Public Enum eGolososType
  PuntaFina = 1
  Hexagonal = 2
  HexagonalPuntaFina = 3
  Estandar = 4
  Other = 99
End Enum



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

Public Class eStockItemTypeMaterialElectrico : Inherits colPropertyENUMOfT(Of clsStockItemType)

  Public Enum eStockItemMaterialElectrico
    General = 1
    Otros = 99
  End Enum

  Public Const General = 1
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeMaterialElectrico

  Public Sub New()
    MyBase.New()

    Dim mGeneral As New clsStockItemType(General, "General", "GN")
    MyBase.Add(mGeneral)


    Dim mOther As New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mOther)
  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMaterialElectrico
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMaterialElectrico
    End If
    Return mSharedInstance
  End Function

End Class







''termino aca


''Termino acá
Public Class clsStockItemTypeHerramientas : Inherits clsPropertyENUM
  Private pStockSubItemTypeHerramientas As colStockSubItemTypeHerramientas

  Public Property StockSubItemTypeHerramientas As colStockSubItemTypeHerramientas
    Get
      Return pStockSubItemTypeHerramientas
    End Get
    Set(value As colStockSubItemTypeHerramientas)
      pStockSubItemTypeHerramientas = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeHerramientas = New colStockSubItemTypeHerramientas
  End Sub

End Class

Public Class clsStockSubItemTypeHerramientas : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeHerramientas : Inherits List(Of clsStockSubItemTypeHerramientas)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeHerramientas
    For Each mItem As clsStockSubItemTypeHerramientas In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeHerramientas : Inherits colPropertyENUMOfT(Of clsStockItemType)

  Public Enum eStockItemMaterialHerramientas
    General = 1
    Otros = 99
  End Enum

  Public Const General = 1
  Public Const Other = 99

  Private Shared mSharedInstance As eStockItemTypeHerramientas

  Public Sub New()
    MyBase.New()

    Dim mGeneral As New clsStockItemType(General, "General", "GN")
    MyBase.Add(mGeneral)


    Dim mOther As New clsStockItemType(Other, "Los demás", "OTR")
    MyBase.Add(mOther)
  End Sub

  Public Shared Function GetInstance() As eStockItemTypeHerramientas
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeHerramientas
    End If
    Return mSharedInstance
  End Function

End Class
''termino aca

Public Class clsStockItemTypeTimberWood : Inherits clsPropertyENUM
  Private pStockSubItemTypeTimberWood As colStockSubItemTypeTimberWood

  Public Property StockSubItemTypeTimberWood As colStockSubItemTypeTimberWood
    Get
      Return pStockSubItemTypeTimberWood
    End Get
    Set(value As colStockSubItemTypeTimberWood)
      pStockSubItemTypeTimberWood = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeTimberWood = New colStockSubItemTypeTimberWood
  End Sub

End Class

Public Class clsStockSubItemTypeTimberWood : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeTimberWood : Inherits List(Of clsStockSubItemTypeTimberWood)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeTimberWood
    For Each mItem As clsStockSubItemTypeTimberWood In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeTimberWood : Inherits colPropertyENUMOfT(Of clsStockItemType)

  Public Enum eStockItemTimberWood
    Arbol = 1
    Rollo = 2
    Aserrado = 3
    MAS = 4
    MAV = 6
    Primera = 7
    Segunda = 8
    Tercera = 9
    ClasificadoZ = 10
    CepilladoPrimera = 11
    CepilladoSegunda = 12
    CepilladoTercera = 13
    MASSegunda = 14

    Otros = 99




  End Enum

  Public Const Arbol = 1
  Public Const Rollo = 2
  Public Const Aserrado = 3
  Public Const MAS = 4
  Public Const MAV = 6
  Public Const Primera = 7
  Public Const Segunda = 8
  Public Const Tercera = 9
  Public Const ClasificadoZ = 10
  Public Const CepilladoPrimera = 11
  Public Const CepilladoSegunda = 12
  Public Const CepilladoTercera = 13
  Public Const MASSegunda = 14
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeTimberWood

  Public Sub New()
    MyBase.New()

    Dim mTree As New clsStockItemType(Arbol, "Árbol", "ARB")
    MyBase.Add(mTree)

    Dim mRoll As New clsStockItemType(Rollo, "Rollo", "ROL")
    MyBase.Add(mRoll)

    'Dim mSaw As New clsStockItemType(Aserrado, "ASE", "ASE")
    'MyBase.Add(mSaw)

    Dim mMAS As New clsStockItemType(MAS, "MAS", "MAS")
    MyBase.Add(mMAS)

    Dim mMASSegunda As New clsStockItemType(MASSegunda, "MAS Segunda", "MAS2")
    MyBase.Add(mMASSegunda)

    Dim mMAV As New clsStockItemType(MAV, "MAV", "MAV")
    MyBase.Add(mMAV)

    Dim mClasificadoA As New clsStockItemType(Primera, "Primera", "PRI")
    MyBase.Add(mClasificadoA)

    Dim mClasificadoB As New clsStockItemType(Segunda, "Segunda", "SEG")
    MyBase.Add(mClasificadoB)

    Dim mClasificadoC As New clsStockItemType(Tercera, "Tercera", "TER")
    MyBase.Add(mClasificadoC)

    Dim mClasificadoZ As New clsStockItemType(ClasificadoZ, "Clasificado Z", "CLZ")
    MyBase.Add(mClasificadoZ)

    Dim mCepillado As New clsStockItemType(CepilladoPrimera, "Cepillado Primera", "CPR")
    MyBase.Add(mCepillado)

    Dim mCepilladoSegunda As New clsStockItemType(CepilladoSegunda, "Cepillado Segunda", "CSE")
    MyBase.Add(mCepilladoSegunda)


    Dim mCepilladoTercera As New clsStockItemType(CepilladoTercera, "Cepillado Tercera", "CTE")
    MyBase.Add(mCepilladoTercera)

    Dim mOther As New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mOther)
  End Sub

  Public Shared Function GetInstance() As eStockItemTypeTimberWood
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeTimberWood
    End If
    Return mSharedInstance
  End Function

End Class


''termino aca

''termino aca
Public Class clsStockItemTypeEPP : Inherits clsPropertyENUM
  Private pStockSubItemTypeEPP As colStockSubItemTypeEPP

  Public Property StockSubItemTypeEPP As colStockSubItemTypeEPP
    Get
      Return pStockSubItemTypeEPP
    End Get
    Set(value As colStockSubItemTypeEPP)
      pStockSubItemTypeEPP = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeEPP = New colStockSubItemTypeEPP
  End Sub

End Class

Public Class clsStockSubItemTypeEPP : Inherits clsPropertyENUM

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
  End Sub

End Class

Public Class colStockSubItemTypeEPP : Inherits List(Of clsStockSubItemTypeEPP)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeEPP
    For Each mItem As clsStockSubItemTypeEPP In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeEPP : Inherits colPropertyENUMOfT(Of clsStockItemType)

  Public Enum eStockItemMaterialEPP
    EPP = 1
    Otros = 99
  End Enum

  Public Const EPP = 1
  Public Const Other = 99

  Private Shared mSharedInstance As eStockItemTypeEPP

  Public Sub New()
    MyBase.New()

    Dim mGeneral As New clsStockItemType(EPP, "General", "GN")
    MyBase.Add(mGeneral)


    Dim mOther As New clsStockItemType(Other, "Los demás", "OTR")
    MyBase.Add(mOther)
  End Sub

  Public Shared Function GetInstance() As eStockItemTypeEPP
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeEPP
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

Public Class eStockItemTypeMaterialEmpaque : Inherits colPropertyENUMOfT(Of clsStockItemType)

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

    Dim mPlasticos As New clsStockItemType(Plasticos, "Plasticos", "PL")
    MyBase.Add(mPlasticos)

    Dim mGrapas As New clsStockItemType(Grapas, "Grapas", "GR")
    MyBase.Add(mGrapas)

    Dim mOtros As New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mOtros)


  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMaterialEmpaque
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMaterialEmpaque
    End If
    Return mSharedInstance
  End Function

End Class

''Public Class clsStockItemTypeMetales : Inherits clsPropertyENUM
''  Private pStockSubItemTypeMetales As colStockSubItemTypeMetales

''  Public Property StockSubItemTypeMetales As colStockSubItemTypeMetales
''    Get
''      Return pStockSubItemTypeMetales
''    End Get
''    Set(value As colStockSubItemTypeMetales)
''      pStockSubItemTypeMetales = value
''    End Set
''  End Property

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''    pStockSubItemTypeMetales = New colStockSubItemTypeMetales
''  End Sub

''End Class

''Public Class clsStockSubItemTypeMetales : Inherits clsPropertyENUM

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''  End Sub

''End Class

''Public Class colStockSubItemTypeMetales : Inherits List(Of clsStockSubItemTypeMetales)

''  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeMetales
''    For Each mItem As clsStockSubItemTypeMetales In Me
''      If mItem.PropertyENUM = vKey Then
''        Return mItem
''      End If
''    Next

''    Return Nothing
''  End Function

''End Class

Public Class eStockItemTypeMetales : Inherits colPropertyENUMOfT(Of clsStockItemType)

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

    Dim mAluminio As New clsStockItemType(Aluminio, "Aluminio", "AL")
    MyBase.Add(mAluminio)

    Dim mPlatinas As New clsStockItemType(Platinas, "Platinas", "PL")
    MyBase.Add(mPlatinas)

    Dim mTubos As New clsStockItemType(Tubos, "Tubos", "TB")
    MyBase.Add(mTubos)

    Dim mVarillas As New clsStockItemType(Varillas, "Varillas", "VA")
    MyBase.Add(mVarillas)

    Dim mOtros As New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mOtros)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMetales
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMetales
    End If
    Return mSharedInstance
  End Function

End Class

''Public Class clsStockItemTypeRepuestosYPartes : Inherits clsPropertyENUM
''  Private pStockSubItemTypeRepuestosYPartes As colStockSubItemTypeRepuestosYPartes

''  Public Property StockSubItemTypeRepuestosYPartes As colStockSubItemTypeRepuestosYPartes
''    Get
''      Return pStockSubItemTypeRepuestosYPartes
''    End Get
''    Set(value As colStockSubItemTypeRepuestosYPartes)
''      pStockSubItemTypeRepuestosYPartes = value
''    End Set
''  End Property

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''    pStockSubItemTypeRepuestosYPartes = New colStockSubItemTypeRepuestosYPartes
''  End Sub

''End Class

''Public Class clsStockSubItemTypeRepuestosYPartes : Inherits clsPropertyENUM

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''  End Sub

''End Class

''Public Class colStockSubItemTypeRepuestosYPartes : Inherits List(Of clsStockSubItemTypeRepuestosYPartes)

''  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeRepuestosYPartes
''    For Each mItem As clsStockSubItemTypeRepuestosYPartes In Me
''      If mItem.PropertyENUM = vKey Then
''        Return mItem
''      End If
''    Next

''    Return Nothing
''  End Function

''End Class


''Public Class clsStockItemTypeTapiceria : Inherits clsPropertyENUM
''  Private pStockSubItemTypeTapiceria As colStockSubItemTypeTapiceria

''  Public Property StockSubItemTypeTapiceria As colStockSubItemTypeTapiceria
''    Get
''      Return pStockSubItemTypeTapiceria
''    End Get
''    Set(value As colStockSubItemTypeTapiceria)
''      pStockSubItemTypeTapiceria = value
''    End Set
''  End Property

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''    pStockSubItemTypeTapiceria = New colStockSubItemTypeTapiceria
''  End Sub

''End Class

''Public Class clsStockSubItemTypeTapiceria : Inherits clsPropertyENUM

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''  End Sub

''End Class

''Public Class colStockSubItemTypeTapiceria : Inherits List(Of clsStockSubItemTypeTapiceria)

''  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeTapiceria
''    For Each mItem As clsStockSubItemTypeTapiceria In Me
''      If mItem.PropertyENUM = vKey Then
''        Return mItem
''      End If
''    Next

''    Return Nothing
''  End Function

''End Class

Public Class eStockItemTypeTapiceria : Inherits colPropertyENUMOfT(Of clsStockItemType)

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

    Dim mTachuelas As New clsStockItemType(Tachuelas, "Tachuelas", "TC")
    MyBase.Add(mTachuelas)

    Dim mNylons As New clsStockItemType(Nylons, "Nylons", "NY")
    MyBase.Add(mNylons)

    Dim mOtros As New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mOtros)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeTapiceria
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeTapiceria
    End If
    Return mSharedInstance
  End Function

End Class



''Public Class clsStockSubItemTypeVidrioYEspejo : Inherits clsPropertyENUM

''  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
''    MyBase.New(vPropertyENUM, vDescription)
''  End Sub

''End Class

''Public Class colStockSubItemTypeVidrioYEspejo : Inherits List(Of clsStockSubItemTypeVidrioYEspejo)

''  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeVidrioYEspejo
''    For Each mItem As clsStockSubItemTypeVidrioYEspejo In Me
''      If mItem.PropertyENUM = vKey Then
''        Return mItem
''      End If
''    Next

''    Return Nothing
''  End Function

''End Class


'aca

'aca

Public Class eStockItemTypeLamina : Inherits colPropertyENUMOfT(Of clsStockItemType)

  Public Const Plywood = 1
  Public Const Poroplast = 2
  Public Const Plycem = 3
  Public Const Otros = 99

  Public Enum eStockItemLamina
    Plywood = 1
    Poroplast = 2
    Plycem = 3
    Otros = 99

  End Enum
  Private Shared mSharedInstance As eStockItemTypeLamina

  Public Sub New()
    MyBase.New()
    Dim mType As clsStockItemType

    mType = New clsStockItemType(Plywood, "Plywood", "PW")
    MyBase.Add(mType)
    mType = New clsStockItemType(Poroplast, "Poroplast", "PP")
    MyBase.Add(mType)
    mType = New clsStockItemType(Plycem, "Plycem", "PC")
    MyBase.Add(mType)
    mType = New clsStockItemType(Otros, "Los demás", "OTR")
    MyBase.Add(mType)


  End Sub

  Public Shared Function GetInstance() As eStockItemTypeLamina
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeLamina
    End If
    Return mSharedInstance
  End Function

End Class

Public Enum eTransactionType
  <Description("Ingreso a Bodega")> GoodsIn = 1
  <Description("Salida de Bodega")> Pick = 2
  <Description("Reconteo")> Restock = 3
  <Description("Corrección de Inv.")> Amendment = 4
  <Description("Conteo de Inv.")> StockCheck = 5
  <Description("Transferencia")> Transfer = 6
  <Description("Devol. Proveedor")> SupplierReturn = 7
  <Description("Devol. Cliente")> CustomerReturn = 8
  <Description("Ajuste")> Adjustment = 9
  <Description("Palletise SIR")> PalletiseSIR = 10
  <Description("Palletise LI")> PalletiseLI = 11
  <Description("Movimiento de Bodega")> Movement = 12
  <Description("Corrección de Inv. Madera")> WoodAmendment = 13
  <Description("Picking de Madera")> WoodPicking = 14
  <Description("Recepción de Madera")> WoodReception = 15
  <Description("Movimiento por Aserrado de Madera")> AserradoMovement = 16
  <Description("Movimiento por Clasificación de Madera")> ClasificationMovement = 17
  <Description("Movimiento por Entrada a Horno")> KilnMovementStart = 18
  <Description("Movimiento por Salida de Horno")> KilnMovementEnd = 19
  <Description("Movimiento de MAV")> MAVMovement = 20
  <Description("Despacho Madera a Producción")> IntoWIP = 21
  <Description("Venta de Madera")> WoodSalesOrder = 22
  <Description("Devolución de Producción")> ProductionReturn = 23



End Enum

Public Enum ePayPeriodType
  Month = 1
  Quincena = 2
End Enum

Public Enum eOrderPhaseType
  <Description("Sencillo")> SinglePhase = 1
  <Description("Multiple ")> MultiPhase = 2
End Enum

Public Enum eKilns
  <Description("Horno 1")> KilnOne = 1
  <Description("Horno 2")> KilnTwo = 2
  <Description("Horno 3")> KilnThree = 3
End Enum

Public Enum eWoodFormMode
  WoodInventory = 1
  ProductionDespatch = 2
End Enum



Public Class clsStockItemTypePlumbings : Inherits clsPropertyENUM
  Private pStockSubItemTypePlumbings As colStockSubItemTypePlumbings
  Private pStockCodeStr As String
  Public Property StockSubItemTypePlumbings As colStockSubItemTypePlumbings
    Get
      Return pStockSubItemTypePlumbings
    End Get
    Set(value As colStockSubItemTypePlumbings)
      pStockSubItemTypePlumbings = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypePlumbings = New colStockSubItemTypePlumbings
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypePlumbings : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class colStockSubItemTypePlumbings : Inherits List(Of clsStockSubItemTypePlumbings)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypePlumbings
    For Each mItem As clsStockSubItemTypePlumbings In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypePlumbings : Inherits colPropertyENUMOfT(Of clsStockItemTypePlumbings)

  Public Const Tubos = 1
  Public Const Uniones = 2
  Public Const Codos = 3
  Public Const Conectores = 4
  Public Const Inodoros = 5
  Public Const Lavamanos = 6
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypePlumbings

  Public Sub New()
    MyBase.New()
    Dim mPlumbingType As clsStockItemTypePlumbings

    mPlumbingType = New clsStockItemTypePlumbings(Tubos, "Tubos", "TUB")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypePlumbings(Uniones, "Uniones", "UNI")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypePlumbings(Conectores, "Conectores", "CON")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypePlumbings(Codos, "Codos", "COD")
    MyBase.Add(mPlumbingType)


    mPlumbingType = New clsStockItemTypePlumbings(Inodoros, "Inodores", "IND")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypePlumbings(Lavamanos, "Lavamanos", "LVM")
    MyBase.Add(mPlumbingType)



    mPlumbingType = New clsStockItemTypePlumbings(Otros, "Los demás", "OTR")
    MyBase.Add(mPlumbingType)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypePlumbings
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypePlumbings
    End If
    Return mSharedInstance
  End Function

End Class


Public Class clsStockItemTypeMatVarios : Inherits clsPropertyENUM
  Private pStockSubItemMatVarioss As colStockSubItemMatVarioss
  Private pStockCodeStr As String
  Public Property StockSubItemMatVarioss As colStockSubItemMatVarioss
    Get
      Return pStockSubItemMatVarioss
    End Get
    Set(value As colStockSubItemMatVarioss)
      pStockSubItemMatVarioss = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemMatVarioss = New colStockSubItemMatVarioss
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemMatVarios : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class colStockSubItemMatVarioss : Inherits List(Of clsStockSubItemMatVarios)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemMatVarios
    For Each mItem As clsStockSubItemMatVarios In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class

Public Class eStockItemTypeMatVarioss : Inherits colPropertyENUMOfT(Of clsStockItemTypeMatVarios)

  Public Const General = 1
  Public Const CleaningAccesories = 2
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeMatVarioss

  Public Sub New()
    MyBase.New()
    Dim mStockItemTypeMatVarios As clsStockItemTypeMatVarios

    mStockItemTypeMatVarios = New clsStockItemTypeMatVarios(General, "General", "GEN")
    MyBase.Add(mStockItemTypeMatVarios)


    mStockItemTypeMatVarios = New clsStockItemTypeMatVarios(CleaningAccesories, "Accesorios de Limpieza", "ADL")
    MyBase.Add(mStockItemTypeMatVarios)



    mStockItemTypeMatVarios = New clsStockItemTypeMatVarios(Otros, "Los demás", "OTR")
    MyBase.Add(mStockItemTypeMatVarios)
  End Sub

  Public Shared Function GetInstance() As eStockItemTypeMatVarioss
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeMatVarioss
    End If
    Return mSharedInstance
  End Function
End Class


Public Class clsStockItemTypeBrickWork : Inherits clsPropertyENUM
  Private pStockSubItemTypeBrickWork As colStockSubItemTypeBrickWork
  Private pStockCodeStr As String
  Public Property StockSubItemTypeBrickWork As colStockSubItemTypeBrickWork
    Get
      Return pStockSubItemTypeBrickWork
    End Get
    Set(value As colStockSubItemTypeBrickWork)
      pStockSubItemTypeBrickWork = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeBrickWork = New colStockSubItemTypeBrickWork
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypeBrickWork : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class colStockSubItemTypeBrickWork : Inherits List(Of clsStockSubItemTypeBrickWork)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypeBrickWork
    For Each mItem As clsStockSubItemTypeBrickWork In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class


Public Class eStockItemTypeBrickWork : Inherits colPropertyENUMOfT(Of clsStockItemTypeBrickWork)

  Public Const Piedrin = 1
  Public Const Arena = 2
  Public Const Cemento = 3
  Public Const LadrilloYBloque = 4
  Public Const Hormigon = 5
  Public Const Cal = 6
  Public Const Alambre = 7

  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeBrickWork

  Public Sub New()
    MyBase.New()
    Dim mPlumbingType As clsStockItemTypeBrickWork

    mPlumbingType = New clsStockItemTypeBrickWork(Piedrin, "Piedrin", "PIE")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeBrickWork(Arena, "Arena", "ARE")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeBrickWork(Cemento, "Cemento", "CEM")
    MyBase.Add(mPlumbingType)


    mPlumbingType = New clsStockItemTypeBrickWork(LadrilloYBloque, "Ladrillos y Bloque", "LYB")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeBrickWork(Hormigon, "Hormigón", "HOR")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeBrickWork(Cal, "Cal", "CAL")
    MyBase.Add(mPlumbingType)


    mPlumbingType = New clsStockItemTypeBrickWork(Alambre, "Alambre", "ALA")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeBrickWork(Otros, "Los demás", "OTR")
    MyBase.Add(mPlumbingType)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeBrickWork
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeBrickWork
    End If
    Return mSharedInstance
  End Function

End Class


Public Class clsStockItemTypeRepuestosYPartes : Inherits clsPropertyENUM
  Private pStockSubItemTypeRepuestosYPartes As colStockSubItemTypeRepuestosYPartes
  Private pStockCodeStr As String
  Public Property StockSubItemTypeRepuestosYPartes As colStockSubItemTypeRepuestosYPartes
    Get
      Return pStockSubItemTypeRepuestosYPartes
    End Get
    Set(value As colStockSubItemTypeRepuestosYPartes)
      pStockSubItemTypeRepuestosYPartes = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeRepuestosYPartes = New colStockSubItemTypeRepuestosYPartes
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypeRepuestosYPartes : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
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

  Public Const CuchillosYCabezales = 1
  Public Const Bandas = 2
  Public Const Balinera = 3
  Public Const BrocasYFresas = 4


  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeRepuestosYPartes

  Public Sub New()
    MyBase.New()
    Dim mPlumbingType As clsStockItemTypeRepuestosYPartes

    mPlumbingType = New clsStockItemTypeRepuestosYPartes(CuchillosYCabezales, "Cuchillos y Cabezales", "CYC")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeRepuestosYPartes(Bandas, "Bandas", "BAN")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeRepuestosYPartes(Balinera, "Balineras", "BAL")
    MyBase.Add(mPlumbingType)


    mPlumbingType = New clsStockItemTypeRepuestosYPartes(BrocasYFresas, "Brocas y Fresas", "BYF")
    MyBase.Add(mPlumbingType)


    mPlumbingType = New clsStockItemTypeRepuestosYPartes(Otros, "Los demás", "OTR")
    MyBase.Add(mPlumbingType)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeRepuestosYPartes
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeRepuestosYPartes
    End If
    Return mSharedInstance
  End Function

End Class


Public Class clsStockItemTypePintura : Inherits clsPropertyENUM
  Private pStockSubItemTypePintura As colStockSubItemTypePintura
  Private pStockCodeStr As String
  Public Property StockSubItemTypePintura As colStockSubItemTypePintura
    Get
      Return pStockSubItemTypePintura
    End Get
    Set(value As colStockSubItemTypePintura)
      pStockSubItemTypePintura = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypePintura = New colStockSubItemTypePintura
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypePintura : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class colStockSubItemTypePintura : Inherits List(Of clsStockSubItemTypePintura)

  Public Function ItemFromKey(ByVal vKey As Integer) As clsStockSubItemTypePintura
    For Each mItem As clsStockSubItemTypePintura In Me
      If mItem.PropertyENUM = vKey Then
        Return mItem
      End If
    Next

    Return Nothing
  End Function

End Class


Public Class eStockItemTypePintura : Inherits colPropertyENUMOfT(Of clsStockItemTypePintura)

  Public Const Recubrimiento = 1
  Public Const Diluyente = 2
  Public Const Barniz = 3
  Public Const Componentes = 4
  Public Const Tintes = 5
  Public Const Combustibles = 6
  Public Const Pegamento = 7
  Public Const AccesoriosPintura = 8

  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypePintura

  Public Sub New()
    MyBase.New()
    Dim mType As clsStockItemTypePintura

    mType = New clsStockItemTypePintura(Recubrimiento, "Recubrimiento para Madera", "RMA")
    MyBase.Add(mType)

    mType = New clsStockItemTypePintura(Diluyente, "Diluyente", "DIL")
    MyBase.Add(mType)

    mType = New clsStockItemTypePintura(Barniz, "Barniz", "BAR")
    MyBase.Add(mType)


    mType = New clsStockItemTypePintura(Componentes, "Componentes", "COM")
    MyBase.Add(mType)

    mType = New clsStockItemTypePintura(Tintes, "Tintes", "TIN")
    MyBase.Add(mType)

    mType = New clsStockItemTypePintura(Combustibles, "Combustibles", "COM")
    MyBase.Add(mType)


    mType = New clsStockItemTypePintura(Pegamento, "Pegamento para Madera", "PEG")
    MyBase.Add(mType)

    mType = New clsStockItemTypePintura(AccesoriosPintura, "Accesorios para Pintar", "ACP")
    MyBase.Add(mType)

    mType = New clsStockItemTypePintura(Otros, "Los demás", "OTR")
    MyBase.Add(mType)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypePintura
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypePintura
    End If
    Return mSharedInstance
  End Function

End Class



Public Class clsStockItemTypeHerrajes : Inherits clsPropertyENUM
  Private pStockSubItemTypeHerrajes As colStockSubItemTypeHerrajes
  Private pStockCodeStr As String
  Public Property StockSubItemTypeHerrajes As colStockSubItemTypeHerrajes
    Get
      Return pStockSubItemTypeHerrajes
    End Get
    Set(value As colStockSubItemTypeHerrajes)
      pStockSubItemTypeHerrajes = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeHerrajes = New colStockSubItemTypeHerrajes
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypeHerrajes : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
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

  Public Const Riel = 1
  Public Const Bisagras = 4
  Public Const ResbalonesYNiveladores = 5
  Public Const Rodos = 6
  Public Const Jaladeras = 7
  Public Const Portatiles = 8
  Public Const Cerraduras = 9
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeHerrajes

  Public Sub New()
    MyBase.New()
    Dim mType As clsStockItemTypeHerrajes

    mType = New clsStockItemTypeHerrajes(Riel, "Riel", "RIE")
    MyBase.Add(mType)

    mType = New clsStockItemTypeHerrajes(Bisagras, "Bisagras", "BIS")
    MyBase.Add(mType)

    mType = New clsStockItemTypeHerrajes(ResbalonesYNiveladores, "Resbalones y Niveladores", "RYN")
    MyBase.Add(mType)


    mType = New clsStockItemTypeHerrajes(Rodos, "Rodos", "ROD")
    MyBase.Add(mType)

    mType = New clsStockItemTypeHerrajes(Jaladeras, "Jaladeras", "JAL")
    MyBase.Add(mType)

    mType = New clsStockItemTypeHerrajes(Cerraduras, "Cerraduras", "CER")
    MyBase.Add(mType)

    mType = New clsStockItemTypeHerrajes(Otros, "Los demás", "OTR")
    MyBase.Add(mType)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeHerrajes
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeHerrajes
    End If
    Return mSharedInstance
  End Function

End Class



Public Class clsStockItemTypeVidrioYEspejo : Inherits clsPropertyENUM
  Private pStockSubItemTypeVidrioYEspejo As colStockSubItemTypeVidrioYEspejo
  Private pStockCodeStr As String
  Public Property StockSubItemTypeVidrioYEspejo As colStockSubItemTypeVidrioYEspejo
    Get
      Return pStockSubItemTypeVidrioYEspejo
    End Get
    Set(value As colStockSubItemTypeVidrioYEspejo)
      pStockSubItemTypeVidrioYEspejo = value
    End Set
  End Property
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockSubItemTypeVidrioYEspejo = New colStockSubItemTypeVidrioYEspejo
    pStockCodeStr = vStockCodeStr
  End Sub

End Class

Public Class clsStockSubItemTypeVidrioYEspejo : Inherits clsPropertyENUM
  Private pStockCodeStr As String
  Public Property StockCodeStr As String
    Get
      Return pStockCodeStr
    End Get
    Set(value As String)
      pStockCodeStr = value
    End Set
  End Property
  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String, ByVal vStockCodeStr As String)
    MyBase.New(vPropertyENUM, vDescription)
    pStockCodeStr = vStockCodeStr
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

  Public Const Vidrios = 1
  Public Const Espejos = 2
  Public Const Accesorios = 3
  Public Const Otros = 99

  Private Shared mSharedInstance As eStockItemTypeVidrioYEspejo

  Public Sub New()
    MyBase.New()
    Dim mPlumbingType As clsStockItemTypeVidrioYEspejo

    mPlumbingType = New clsStockItemTypeVidrioYEspejo(Vidrios, "Vidrios", "VID")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeVidrioYEspejo(Espejos, "Espejos", "ESP")
    MyBase.Add(mPlumbingType)

    mPlumbingType = New clsStockItemTypeVidrioYEspejo(Accesorios, "Accesorios", "ACC")
    MyBase.Add(mPlumbingType)


    mPlumbingType = New clsStockItemTypeVidrioYEspejo(Otros, "Los demás", "OTR")
    MyBase.Add(mPlumbingType)

  End Sub

  Public Shared Function GetInstance() As eStockItemTypeVidrioYEspejo
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eStockItemTypeVidrioYEspejo
    End If
    Return mSharedInstance
  End Function

End Class

Public Enum eReceivedEmailStatus
  Pending = 1
  Downloaded = 2
  Classified = 3
  Ignored = 4
End Enum

Public Enum eMatReqCategoryStatus
  Pending = 0
  NotRequired = 1
  Stock = 2
  ToPlace = 3
  Ordered = 4
  Received = 5
End Enum

Public Enum eStatusNonePartComplete
  None = 0
  Part = 1
  Complete = 2
  NotRequired = 3
End Enum

Public Enum eOptionMaterialesView
  InsumosSpecified = 1
  InsumosActual = 2
  MatEstimado = 3
  WoodSpecified = 4
  WoodActual = 5
End Enum

Public Enum ePODetailOption
  ManPO = 1
  NonManPO = 2
  General = 3
End Enum

Public Enum ePOConsoleOption
  Housing = 1
  Furniture = 2
End Enum

Public Class clsEnumSalesOrderPhaseMilestone : Inherits clsPropertyENUM

  Private pDependencyMilestones As colMilestoneDependentOns

  Public Sub New(ByVal vPropertyENUM As Integer, ByVal vDescription As String)
    MyBase.New(vPropertyENUM, vDescription)
    pDependencyMilestones = New colMilestoneDependentOns
  End Sub

  Public Property DependencyMilestones As colMilestoneDependentOns
    Get
      Return pDependencyMilestones
    End Get
    Set(value As colMilestoneDependentOns)
      pDependencyMilestones = value
    End Set
  End Property
End Class



Public Class eSalesOrderPhaseMileStone : Inherits colPropertyENUMOfT(Of clsEnumSalesOrderPhaseMilestone)
  'Public Const DeliveryToSiteDate = 1
  Public Const ConfirmationOrder = 2
  Public Const Handover = 3
  Public Const Engineering = 4
  Public Const Compras = 5
  Public Const Carpinteria = 6
  Public Const Metales = 7
  Public Const Tapizado = 8
  Public Const Empaque = 9

  Private Shared mSharedInstance As eSalesOrderPhaseMileStone

  Public Sub New()
    MyBase.New()
    Dim mMileStone As clsEnumSalesOrderPhaseMilestone


    'mMileStone = New clsEnumSalesOrderPhaseMilestone(DeliveryToSiteDate, "FechaEntrega")
    'MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(ConfirmationOrder, "ConfirmationOrder")
    ' mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(DeliveryToSiteDate, 0, False))
    MyBase.Add(mMileStone)


    mMileStone = New clsEnumSalesOrderPhaseMilestone(Handover, "Handover")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(ConfirmationOrder, 2, True))
    MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(Engineering, "Engineering")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(ConfirmationOrder, 1, True))
    MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(Compras, "Engineering")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(ConfirmationOrder, 1, True))
    MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(Carpinteria, "Carpinteria")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(ConfirmationOrder, 1, True))
    MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(Metales, "Carpinteria")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(Metales, 1, True))
    MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(Tapizado, "Tapizado")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(Metales, 1, True))
    MyBase.Add(mMileStone)

    mMileStone = New clsEnumSalesOrderPhaseMilestone(Empaque, "Tapizado")
    mMileStone.DependencyMilestones.Add(New clsMilestoneDependentOn(Metales, 1, True))
    MyBase.Add(mMileStone)

  End Sub
  Public Shared Function GetInstance() As eSalesOrderPhaseMileStone
    If mSharedInstance Is Nothing Then
      mSharedInstance = New eSalesOrderPhaseMileStone
    End If
    Return mSharedInstance
  End Function

End Class
