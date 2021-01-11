
Imports RTIS.CommonVB
Imports RTIS.DataLayer
Imports RTIS.Elements

Public Class MenuFactory
  Public Shared Function BuildMenu() As clsMenuEntries
    Dim mMenuList As New clsMenuEntries
    Dim mLastGroup As clsMenuEntry = Nothing
    Dim mLastItem As clsMenuEntry = Nothing

    mLastGroup = mMenuList.AddNewGroup("Ventas", 0, eActivityCode.SalesGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Clientes", eMenuIconType.Grid, AddressOf clsMenuFunctions.CustomerBrowse, eActivityCode.Customer)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Ventas", eMenuIconType.Grid, AddressOf clsMenuFunctions.SalesOrderBrowse, eActivityCode.SalesOrder)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Progreso de Ventas por OT", eMenuIconType.Grid, AddressOf clsMenuFunctions.SalesOrderProgress, eActivityCode.TrackingSalesOrder)

    mLastGroup = mMenuList.AddNewGroup("Producción", 0, eActivityCode.ProductionGroup, True)
    '' mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Ordenes de Trabajo", eMenuIconType.Grid, AddressOf clsMenuFunctions.WorksOrderBrowse, eActivityCode.WorkOrders)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("OT Estructuras", eMenuIconType.Grid, AddressOf clsMenuFunctions.StructureWorksOrderBrowse, eActivityCode.StructureWorkOrder)
    '' mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Progreso de los O.T.s", eMenuIconType.Grid, AddressOf clsMenuFunctions.WorkOrderTracking, eActivityCode.TrackingWorkOrders)
    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Entrada de Horas Laborales", eMenuIconType.Console, AddressOf clsMenuFunctions.TimeSheetEntry, eActivityCode.TimeSheetEntry)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("OT Instalación", eMenuIconType.Grid, AddressOf clsMenuFunctions.InstallationWorkOrderBrowse, eActivityCode.InstallationWorkOrder)


    'mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Produccion", eMenuIconType.Report, AddressOf clsMenuFunctions.menufuncNULL, eActivityCode.ProductionGroup)
    'mLastItem.ChildGroupMenuEntries.AddNewItem("Ordenes de Trabajo", eMenuIconType.Report, AddressOf clsMenuFunctions.WorkOrderInfoBI, eActivityCode.ProductionReport)
    'mLastItem.ChildGroupMenuEntries.AddNewItem("Hojas de Tiempo", eMenuIconType.Report, AddressOf clsMenuFunctions.TimeSheetEntryInfoBI, eActivityCode.ProductionReport)


    mLastGroup = mMenuList.AddNewGroup("Compras", 0, eActivityCode.PurchasingGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Proveedores", eMenuIconType.Grid, AddressOf clsMenuFunctions.SupplierBrowse, eActivityCode.Suppliers)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Órdenes de Compras", eMenuIconType.Grid, AddressOf clsMenuFunctions.PurchaseOrder, eActivityCode.PurchaseOrder)
    '' mLastGroup.ChildGroupMenuEntries.AddNewItem("Admon. O.C.", eMenuIconType.Grid, AddressOf clsMenuFunctions.PurchaseOrderconsole, eActivityCode.POConsole)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Recepción de Inv. por OC", eMenuIconType.Grid, AddressOf clsMenuFunctions.PickingPurchaseOrder, eActivityCode.PODelivery)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Compras", eMenuIconType.Report, AddressOf clsMenuFunctions.menufuncNULL, eActivityCode.PurchasingGroup)
    mLastItem.ChildGroupMenuEntries.AddNewItem("Órdenes de Compras por Fecha", eMenuIconType.Report, AddressOf clsMenuFunctions.PurchaseOrderInfo, eActivityCode.POReportList)
    mLastItem.ChildGroupMenuEntries.AddNewItem("Órdenes de Compras por Artículo", eMenuIconType.Report, AddressOf clsMenuFunctions.PurchaseOrderItemInfo, eActivityCode.POReportList)
    mLastItem.ChildGroupMenuEntries.AddNewItem("Recepciones Realizadas", eMenuIconType.Report, AddressOf clsMenuFunctions.PODeliveryInfoBI, eActivityCode.PODeliveryReport)
    mLastItem.ChildGroupMenuEntries.AddNewItem("Recepciones de Artículos Realizadas", eMenuIconType.Report, AddressOf clsMenuFunctions.PODeliveryItemInfoBI, eActivityCode.PODeliveryItemReport)


    mLastGroup = mMenuList.AddNewGroup("Recursos Humanos", 0, eActivityCode.HumanResourcesGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Empleados", eMenuIconType.FormProcess, AddressOf clsMenuFunctions.Employees, eActivityCode.Employees)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Hojas de Pago", eMenuIconType.FormProcess, AddressOf clsMenuFunctions.PaySlips, eActivityCode.PaymentSlip)


    mLastGroup = mMenuList.AddNewGroup("Admon. de Inventario", 0, eActivityCode.InventoryGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Elementos de Inv.", eMenuIconType.Grid, AddressOf clsMenuFunctions.InventoryAdmin, eActivityCode.StockItem)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Salida de Prod. por OT", eMenuIconType.Grid, AddressOf clsMenuFunctions.OtherMaterialsConsolidation, eActivityCode.PickingMatReq)
    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Despachos de Productos Realizados", eMenuIconType.Report, AddressOf clsMenuFunctions.PickingReport, eActivityCode.PODeliveryItemReport)

    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Conteo de Inv.", eMenuIconType.Grid, AddressOf clsMenuFunctions.StockTakeBrowse, eActivityCode.StockTake)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Info de Inv. Insumos", eMenuIconType.Console, AddressOf clsMenuFunctions.StockInfos, eActivityCode.StockItemInfos)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Transacciones.", eMenuIconType.Report, AddressOf clsMenuFunctions.StockItemTransactionInfoBI, eActivityCode.TransactionReport)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Transacciones de Madera.", eMenuIconType.Report, AddressOf clsMenuFunctions.WoodStockItemTransactionInfoBI, eActivityCode.TransactionReport)



    mLastGroup = mMenuList.AddNewGroup("Admon. de Madera", 0, eActivityCode.WoodGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Elementos de Madera", eMenuIconType.Grid, AddressOf clsMenuFunctions.WoodInventory, eActivityCode.WoodInventory)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Pallets de Madera", eMenuIconType.Grid, AddressOf clsMenuFunctions.WoodPallets, eActivityCode.WoodPallet)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("OT Proceso de Madera", eMenuIconType.Grid, AddressOf clsMenuFunctions.WorkOrderWoodProcessBrowse, eActivityCode.WorkOrderWoodProcess)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Info de Inv. Madera", eMenuIconType.Console, AddressOf clsMenuFunctions.StockInfosWood, eActivityCode.WoodInventory)

    ''mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Despachos de Productos Realizados", eMenuIconType.Report, AddressOf clsMenuFunctions.PickingReport, eActivityCode.PODeliveryItemReport)



    mLastGroup = mMenuList.AddNewGroup("Admon. de Productos", 0, eActivityCode.ProductionGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Directorio de Productos", eMenuIconType.Grid, AddressOf clsMenuFunctions.ProductAdmin, eActivityCode.ProductAdmin)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Configuracion de Casa", eMenuIconType.Grid, AddressOf clsMenuFunctions.HouseConfig, eActivityCode.ProductAdmin)

    mLastGroup = mMenuList.AddNewGroup("Lista de Costos", 0, eActivityCode.CostingGroup, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Costeo de Productos", eMenuIconType.Grid, AddressOf clsMenuFunctions.ProductCost, eActivityCode.ProductCost)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Costeo de Madera", eMenuIconType.Grid, AddressOf clsMenuFunctions.DoorLeafPriceMatrix, eActivityCode.Configuration)


    'mLastGroup = mMenuList.AddNewGroup("Contabilidad", 0, eActivityCode.AccountsGroup, True)
    'mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Facturas", eMenuIconType.Grid, AddressOf clsMenuFunctions.InvoiceModule, eActivityCode.FBConsumeReport)

    'mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Informes de Contabilidad", eMenuIconType.Report, AddressOf clsMenuFunctions.menufuncNULL, eActivityCode.AccountsGroup)

    'mLastItem.ChildGroupMenuEntries.AddNewItem("Informes de Facturas", eMenuIconType.Report, AddressOf clsMenuFunctions.InvoiceInfoBI, eActivityCode.InvoicesReport)
    'mLastItem.ChildGroupMenuEntries.AddNewItem("Informes del Periodo", eMenuIconType.Report, AddressOf clsMenuFunctions.CompanyDayInfoBI, eActivityCode.CompanyDayReport)
    'mLastItem.ChildGroupMenuEntries.AddNewItem("Informes de Consumo Pies Tablares", eMenuIconType.Report, AddressOf clsMenuFunctions.WoodMatReqInfo, eActivityCode.FBConsumeReport)


    mLastGroup = mMenuList.AddNewGroup("Configuracion", 0, eActivityCode.Configuration, True)
    mLastItem = mLastGroup.ChildGroupMenuEntries.AddNewItem("Tablas de Configuracion", eMenuIconType.Admin, AddressOf clsMenuFunctions.LookUpLists, eActivityCode.Configuration)


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

  Public Shared Sub SalesOrderProgress(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmSalesOrderProgress.OpenFormMDI(rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)

  End Sub
  Public Shared Sub StockInfos(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmStockItemInfo.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, False)
  End Sub
  Public Shared Sub StockInfosWood(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmStockItemInfo.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, True)
  End Sub

  Public Shared Sub WorksOrderBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwWorkOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.WorkOrder)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub WoodInventory(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)
    Dim mCategories As New List(Of eStockItemCategory)
    mCategories.Add(eStockItemCategory.Timber)
    'mCategories.Add(eStockItemCategory.DimensionWood)
    'mCategories.Add(eStockItemCategory.DriedWood)


    frmStockItem.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, mCategories, rRTISGlobal.StockItemRegistry)
  End Sub

  Public Shared Sub WoodPallets(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)
    frmWoodPalletDetail.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub
  Public Shared Sub InventoryAdmin(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)
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

    frmStockItem.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, mCategories, rRTISGlobal.StockItemRegistry)
  End Sub


  Public Shared Sub StockTakeBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwStockTake(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.StockTake)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub


  Public Shared Sub SupplierBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwSupplier(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.Supplier)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub PurchaseOrder(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mfrm As RTIS.Elements.frmBrowseList
    Dim mbrwInt As brwPurchaseOrder

    mbrwInt = New brwPurchaseOrder(rRTISUserSession.CreateMainDBConn, rRTISGlobal, eBrowseList.PurchaseOrder)
    mfrm = RTIS.Elements.frmBrowseList.GetFormIfLoaded(mbrwInt)

    If mfrm Is Nothing Then
      RTIS.Elements.frmBrowseList.OpenFormAsMDIChild(rParentForm, mbrwInt)
    Else
      mfrm.Focus()
    End If
  End Sub
  Public Shared Sub PurchaseOrderconsole(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmPurchaseOrderConsole.OpenFormAsModal(rParentForm, rRTISUserSession.CreateMainDBConn, rRTISGlobal)
  End Sub
  Public Shared Sub PickingPurchaseOrder(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mfrm As RTIS.Elements.frmBrowseList
    Dim mbrwInt As brwPODelivery

    mbrwInt = New brwPODelivery(rRTISUserSession.CreateMainDBConn, rRTISGlobal, eBrowseList.PODelivery)
    mfrm = RTIS.Elements.frmBrowseList.GetFormIfLoaded(mbrwInt)

    If mfrm Is Nothing Then
      RTIS.Elements.frmBrowseList.OpenFormAsMDIChild(rParentForm, mbrwInt)
    Else
      mfrm.Focus()
    End If

  End Sub


  Public Shared Sub OtherMaterialsConsolidation(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmPickMaterials.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub


  Public Shared Sub InstallationWorkOrderBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwInstallationWorkOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.InstallationWorkOrder)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub
  Public Shared Sub StructureWorksOrderBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwStructureWorkOrder(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.StructureWorkOrder)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub WorkOrderWoodProcessBrowse(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwWorkOrderWoodProcess(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.WorkOrderWoodProcess)
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

  Public Shared Sub ProductAdmin(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As AppRTISGlobal)

    Dim mProductTypes As New List(Of eProductType)
    Dim mValueItems As New colValueItems

    mValueItems = clsEnumsConstants.EnumToVIs(GetType(eProductType))

    If mValueItems IsNot Nothing Then

      For Each mValueItem As clsValueItem In mValueItems
        mProductTypes.Add(mValueItem.ItemValue)
      Next
    End If

    frmProductAdmin.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, mProductTypes)
  End Sub

  Public Shared Sub ProductCost(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwProductCostBook(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.ProductCost)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
  End Sub

  Public Shared Sub HouseConfig(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mBrw As New brwHouseType(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.HouseType)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)
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



  Public Shared Sub PurchaseOrderInfo(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewPurchaseOrders.CreateBIReportViewFactoryPurchaseOrder(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub PurchaseOrderItemInfo(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewPurchaseOrderItemInfo.CreateBIReportViewFactoryPurchaseOrderItem(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub
  Public Shared Sub PODeliveryItemInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    Dim mViews As New List(Of RTIS.BIReport.clsBIReportView)
    mViews.Add(BIPODeliveryItemInfo.CreateBIReportViewFactoryPODeliveryItemInfo(rRTISUserSession.CreateMainDBConn, rRTISGlobal))

    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mViews, rParentForm, rRTISGlobal, rRTISUserSession.IsSecurityAllowAll)
  End Sub

  Public Shared Sub PODeliveryInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    Dim mViews As New List(Of RTIS.BIReport.clsBIReportView)

    ''mBIReport = BIReportViewPODelivery.CreateBIReportViewFactoryPODelivery(rRTISUserSession.CreateMainDBConn, rRTISGlobal)

    mViews.Add(BIReportViewPODelivery.CreateBIReportViewFactoryPODelivery(rRTISUserSession.CreateMainDBConn, rRTISGlobal))

    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mViews, rParentForm, rRTISGlobal, rRTISUserSession.IsSecurityAllowAll)
  End Sub


  Public Shared Sub PaySlips(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)

    frmPaySlipDetails.OpenFormMDI(rParentForm, My.Application.RTISUserSession.CreateMainDBConn, rRTISGlobal)

  End Sub

  Public Shared Sub StockItemTransactionInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewStockItemTransactionLogInfo.CreateBIReportViewStockTransactionLog(rRTISUserSession.CreateMainDBConn, rRTISGlobal, False)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub WoodStockItemTransactionInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewStockItemTransactionLogInfo.CreateBIReportViewStockTransactionLog(rRTISUserSession.CreateMainDBConn, rRTISGlobal, True)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub InvoiceInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewInvoice.CreateBIReportViewFactorInvoice(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub InvoiceModule(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mfrm As RTIS.Elements.frmBrowseList
    Dim mbrwInt As brwInvoices

    mbrwInt = New brwInvoices(rRTISUserSession.CreateMainDBConn, rRTISGlobal, eBrowseList.Invoice)
    mfrm = RTIS.Elements.frmBrowseList.GetFormIfLoaded(mbrwInt)

    If mfrm Is Nothing Then
      RTIS.Elements.frmBrowseList.OpenFormAsMDIChild(rParentForm, mbrwInt)
    Else
      mfrm.Focus()
    End If
  End Sub

  Public Shared Sub CompanyDayInfoBI(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewCompanyDay.CreateBIReportViewCompanyDay(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub WoodMatReqInfo(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportWoodReqMatInfo.CreateBIReportViewWoodReqMatInfo(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub

  Public Shared Sub Employees(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    Dim mRoleList As IList = CType(rRTISGlobal, AppRTISGlobal).RefLists.RefIList(appRefLists.Roles)
    frmAdminEmployeeOverride.OpenAsMDI(rParentForm, rRTISUserSession.CreateMainDBConn, rRTISGlobal, ePermissionCode.ePC_Full, mRoleList)
  End Sub

  Public Shared Sub LookUpLists(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)
    frmLookupTableList.OpenForm(rParentForm, My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance)
  End Sub

  Public Shared Sub PickingReport(ByRef rMenuOption As intMenuOption, ByRef rParentForm As Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As clsRTISGlobal)
    Dim mBIReport As New RTIS.BIReport.clsBIReportView
    mBIReport = BIReportViewMaterialRequirementInfo.CreateBIReportViewFactoryMatReqInfo(rRTISUserSession.CreateMainDBConn, rRTISGlobal)
    RTIS.BIReport.frmManReportMain.OpenFormManReportMDI(mBIReport, rParentForm, rRTISGlobal, True)
  End Sub


  Public Shared Sub DoorLeafPriceMatrix(ByRef rMenuOption As RTIS.Elements.intMenuOption, ByRef rParentForm As Windows.Forms.Form, ByRef rRTISUserSession As clsRTISUser, ByRef rRTISGlobal As RTIS.Elements.clsRTISGlobal)

    Dim mBrw As New brwCostBook(My.Application.RTISUserSession.CreateMainDBConn, AppRTISGlobal.GetInstance, eBrowseList.WoodCostBook)
    frmBrowseList.OpenFormAsMDIChild(rParentForm, mBrw)

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

