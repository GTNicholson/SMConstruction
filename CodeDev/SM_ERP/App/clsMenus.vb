
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class MenuFactory
  Public Shared Function BuildMenu() As clsMenuEntries
    Dim mMenuList As New clsMenuEntries
    Dim mLastGroup As clsMenuEntry = Nothing
    Dim mLastItem As clsMenuEntry = Nothing

    mLastGroup = mMenuList.AddNewGroup("Ventas", 0, eActivityCode.Sales, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Clientes", eMenuIconType.Grid, AddressOf clsMenuFunctions.CustomerBrowse, eActivityCode.Sales)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Ventas", eMenuIconType.Grid, AddressOf clsMenuFunctions.SalesOrderBrowse, eActivityCode.Sales)
    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Ventas", eMenuIconType.Report, AddressOf clsMenuFunctions.WorkOrderInfoBI, eActivityCode.Sales)

    mLastGroup = mMenuList.AddNewGroup("Producción", 0, eActivityCode.Production, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Ordenes de Trabajo", eMenuIconType.Grid, AddressOf clsMenuFunctions.WorksOrderBrowse, eActivityCode.Production)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("OT Internas", eMenuIconType.Grid, AddressOf clsMenuFunctions.InternalWorksOrderBrowse, eActivityCode.Production)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Progreso de los O.T.s", eMenuIconType.Grid, AddressOf clsMenuFunctions.WorkOrderTracking, eActivityCode.Production)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Entrada de Horas Laborales", eMenuIconType.Console, AddressOf clsMenuFunctions.TimeSheetEntry, eActivityCode.Production)


    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Produccion", eMenuIconType.Report, AddressOf clsMenuFunctions.menufuncNULL, eActivityCode.Production)
    mLastItem.ChildGroupMenuEntries.AddNewItem("Ordenes de Trabajo", eMenuIconType.Report, AddressOf clsMenuFunctions.WorkOrderInfoBI, eActivityCode.Production)
    mLastItem.ChildGroupMenuEntries.AddNewItem("Hojas de Tiempo", eMenuIconType.Report, AddressOf clsMenuFunctions.TimeSheetEntryInfoBI, eActivityCode.Production)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Reporte de Hora Extra", eMenuIconType.FormProcess, AddressOf clsMenuFunctions.OvertTimeByEmployee, eActivityCode.Production)


    mLastGroup = mMenuList.AddNewGroup("Compras", 0, eActivityCode.Purchasing, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Proveedores", eMenuIconType.Grid, AddressOf clsMenuFunctions.SupplierBrowse, eActivityCode.Purchasing)


    mLastGroup = mMenuList.AddNewGroup("Admon. de Inventario", 0, eActivityCode.Inventory, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Elementos de Inv.", eMenuIconType.Grid, AddressOf clsMenuFunctions.InventoryAdmin, eActivityCode.Inventory)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Picking de Insumos por OT", eMenuIconType.Grid, AddressOf clsMenuFunctions.OtherMaterialsConsolidation, eActivityCode.Purchasing)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Conteo de Inv.", eMenuIconType.Grid, AddressOf clsMenuFunctions.StockTakeBrowse, eActivityCode.Inventory)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Stock Infos.", eMenuIconType.Console, AddressOf clsMenuFunctions.StockInfos, eActivityCode.Inventory)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Transacciones.", eMenuIconType.Report, AddressOf clsMenuFunctions.StockItemTransactionInfoBI, eActivityCode.Inventory)


    mLastGroup = mMenuList.AddNewGroup("Configuracion", 0, eActivityCode.Configuration, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Empleados", eMenuIconType.FormProcess, AddressOf clsMenuFunctions.Employees, eActivityCode.Configuration)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Tablas de Configuracion", eMenuIconType.Admin, AddressOf clsMenuFunctions.LookUpLists, eActivityCode.Configuration)

    ''mLastGroup = mMenuList.AddNewGroup("Contract Management", 0, eActivityCode.ContractManagement, True)
    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Contracts / Orders", eMenuIconType.Grid, AddressOf clsMenuFunctions.SalesOrderBrowse, eActivityCode.ContractManagement_ContractsOrders)
    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Sales Order Phases", eMenuIconType.Grid, AddressOf clsMenuFunctions.SalesPhaseBrowse, eActivityCode.ContractManagement_ContractsOrders)
    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("BI: Sales Orders", eMenuIconType.Report, AddressOf clsMenuFunctions.menufuncNULL, eActivityCode.ContractManagement_ContractsOrders)
    ''mLastItem.ChildGroupMenuEntries.AddNewItem("Sales Order Phases", eMenuIconType.Report, AddressOf clsMenuFunctions.SalesOrdersBI, eActivityCode.ContractManagement_ContractsOrders)
    ''mLastItem.ChildGroupMenuEntries.AddNewItem("Sales Order Items", eMenuIconType.Report, AddressOf clsMenuFunctions.SalesOrderItemsBI, eActivityCode.ContractManagement_ContractsOrders)


    Return mMenuList
  End Function
End Class


Class clsMenuFunctions

  Public Shared Sub menufuncNULL(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)

  End Sub

  Public Shared Sub CustomerBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwClientes(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.Customer)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub SalesOrderBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwSalesOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.SalesOrders)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub WorksOrderBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwWorkOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.WorkOrder)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub InventoryAdmin(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mCategories As New List(Of eStockItemCategory)
    mCategories.Add(eStockItemCategory.Abrasivos)
    mCategories.Add(eStockItemCategory.NailsAndBolds)
    mCategories.Add(eStockItemCategory.EPP)
    mCategories.Add(eStockItemCategory.Herramientas)
    mCategories.Add(eStockItemCategory.MatElect)
    mCategories.Add(eStockItemCategory.MatEmpaque)
    mCategories.Add(eStockItemCategory.MatVarios)
    mCategories.Add(eStockItemCategory.Metal)
    mCategories.Add(eStockItemCategory.PinturaYQuimico)
    mCategories.Add(eStockItemCategory.Laminas)
    mCategories.Add(eStockItemCategory.Repuestos)
    mCategories.Add(eStockItemCategory.Tapiceria)
    mCategories.Add(eStockItemCategory.VidrioYEspejo)
    mCategories.Add(eStockItemCategory.Herrajes)

    frmStockItem.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, mCategories)
  End Sub

  Public Shared Sub StockTakeBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwStockTake(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.StockTake)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub StockInfos(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmStockItemInfo.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub

  Public Shared Sub SupplierBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwSupplier(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.Supplier)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub OtherMaterialsConsolidation(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmPickMaterials.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub



  Public Shared Sub InternalWorksOrderBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwInternalWorkOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.InternalWorkOrder)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub WorkOrderTracking(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmWorkOrderTracking.OpenFormMDI(rParentForm, My.Application.RTISUserSession.CreateMainDBConn)
  End Sub

  Public Shared Sub TimeSheetEntry(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmTimeSheetEntry.OpenFormModal(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub

  Public Shared Sub SalesRegion(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(9, rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  End Sub

  Public Shared Sub ContractType(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(10, rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  End Sub

  Public Shared Sub WoodSpecies(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(11, rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  End Sub

  Public Shared Sub PriceBracket(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    RTIS.Elements.frmRTISLookUpTable.OpenLookUpTableDialogue(12, rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, Nothing)
  End Sub

  Public Shared Sub WorkOrderInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewWorkOrder.CreateBIReportViewFactoryWorkOrder(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub TimeSheetEntryInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewTimeSheet.CreateBIReportViewFactoryTimeSheet(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub


  Public Shared Sub OvertTimeByEmployee(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)

    frmOverTime.OpenFormMDI(rParentForm, My.Application.RTISUserSession.CreateMainDBConn, rRTISGlobal)

  End Sub

  Public Shared Sub StockItemTransactionInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewStockItemTransactionLogInfo.CreateBIReportViewStockTransactionLog(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub Employees(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mRoleList As IList = CType(rRTISGlobal, AppRTISGlobal).RefLists.RefIList(appRefLists.Roles)
    frmAdminEmployeeOverride.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, rRTISGlobal, ePermissionCode.ePC_Full, mRoleList)
  End Sub

  Public Shared Sub LookUpLists(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmLookupTableList.OpenForm(rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub

End Class


Public Class clsMenuEntries : Inherits List(Of clsMenuEntry)

  Public Sub New()
    MyBase.New()
  End Sub

  Public Sub AddItem(ByRef vMenuItem As clsMenuEntry)
    MyBase.Add(vMenuItem)
  End Sub

  Public Function AddNewGroup(ByVal vMenuGroup As String, ByVal vIconType As Byte, ByVal vActivityCode As Int32, ByVal vStartExpaned As Boolean, Optional ByVal vTooltip As String = "") As clsMenuEntry
    Dim mNew As New clsMenuEntry
    MyBase.Add(mNew)
    With mNew
      .MenuType = 0
      .MenuGroup = vMenuGroup
      .IconType = vIconType
      .ActivityCode = vActivityCode
      .StartExpaned = vStartExpaned
      .Tooltip = vTooltip
    End With
    Return mNew
  End Function

  Public Function AddNewItem(ByVal vMenuCaption As String, ByVal vIconType As Byte, ByRef rMenuDelegate As RTIS.Elements.intMenuOption.dgMenuLinkClicked, ByVal vActivityCode As Int32, Optional ByVal vTooltip As String = "", Optional ByVal vMenuOptionExtension As Object = Nothing)
    Dim mNew As New clsMenuEntry
    If My.Application.RTISUserSession.ActivityPermission(vActivityCode) <> ePermissionCode.ePC_None Then
      MyBase.Add(mNew)
      With mNew
        .MenuType = 1
        .ChildGroupMenuEntries = New clsMenuEntries
        .MenuCaption = vMenuCaption
        .IconType = vIconType
        .ActivityCode = vActivityCode
        .MenuDelegate = rMenuDelegate
        .Tooltip = vTooltip
        .MenuOptionExtension = vMenuOptionExtension
      End With
    End If
    Return mNew
  End Function
End Class

Public Class clsMenuEntry : Inherits RTIS.Elements.clsMenuOption
  '  Implements intMenuOption

  '  Private pMenuGroup As String
  '  ''Private pMenuGroupName As String
  '  Private pMenuCaption As String
  '  Private pActivityCode As Int32
  '  Private pTag As Object
  '  Private pMenuType As Byte
  '  Private pMenuDelegate As intMenuOption.dgMenuLinkClicked
  '  Private pMenuOptionExtension As Object

  Public Property MenuEntryID As Integer
  Public Property ChildGroupMenuEntries As clsMenuEntries
  Public Property IconType As Integer
  Public Property StartExpaned As Boolean
  Public Property Tooltip As String

  Public Property UserPermission As ePermissionCode
  Public Property HideIfNotAvailable As Boolean

  Public Sub New()
    MyBase.New()
    ChildGroupMenuEntries = New clsMenuEntries
  End Sub
End Class

Public Enum eMenuIconType
  FolderClosed = 0
  FolderOpen = 1
  Grid = 2
  Pivot
  Report
  Console
  FormProcess
  Admin
  ExportToFile
  Find
  Print
  Preview
  Selected
  AddRecord
End Enum

