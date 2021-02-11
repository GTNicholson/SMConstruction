Imports RTIS.CommonVB

Public Class clsPurchaseOrderItemInfo

  Private pPurchaseOrderItem As dmPurchaseOrderItem
  Private pPurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation
  Private pPurchaseOrder As dmPurchaseOrder
  Private pStockItem As dmStockItem
  Private pSalesOrderPhase As dmSalesOrderPhase
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer


  Public Sub New()
    pPurchaseOrderItem = New dmPurchaseOrderItem
    pPurchaseOrderItemAllocation = New dmPurchaseOrderItemAllocation
    pPurchaseOrder = New dmPurchaseOrder
    pStockItem = New dmStockItem
    pSalesOrderPhase = New dmSalesOrderPhase
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
  End Sub

  Public Property PurchaseOrderItem As dmPurchaseOrderItem
    Get
      Return pPurchaseOrderItem
    End Get
    Set(value As dmPurchaseOrderItem)
      pPurchaseOrderItem = value
    End Set
  End Property

  Public Property PurchaseOrderItemAllocation As dmPurchaseOrderItemAllocation
    Get
      Return pPurchaseOrderItemAllocation
    End Get
    Set(value As dmPurchaseOrderItemAllocation)
      pPurchaseOrderItemAllocation = value
    End Set
  End Property

  Public Property PurchaseOrder As dmPurchaseOrder
    Get
      Return pPurchaseOrder
    End Get
    Set(value As dmPurchaseOrder)
      pPurchaseOrder = value
    End Set
  End Property

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property




  Public Property SalesOrderPhase As dmSalesOrderPhase
    Get
      Return pSalesOrderPhase
    End Get
    Set(value As dmSalesOrderPhase)
      pSalesOrderPhase = value
    End Set
  End Property

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
    Set(value As dmCustomer)
      pCustomer = value
    End Set
  End Property


  Public ReadOnly Property PurchaseOrderItemID As Int32
    Get
      Return pPurchaseOrderItem.PurchaseOrderItemID
    End Get

  End Property

  Public ReadOnly Property Description As String
    Get
      Return pPurchaseOrderItem.Description
    End Get

  End Property

  Public ReadOnly Property PartNo As String
    Get
      Return pPurchaseOrderItem.PartNo
    End Get

  End Property

  Public ReadOnly Property UoM As Integer
    Get
      Return pPurchaseOrderItem.UoM
    End Get

  End Property
  Public ReadOnly Property UoMDesc() As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eUoM), CType(pPurchaseOrderItem.UoM, eUoM))
    End Get

  End Property
  Public ReadOnly Property StockCode As String
    Get
      Return pPurchaseOrderItem.StockCode
    End Get

  End Property

  Public ReadOnly Property QtyRequired As Decimal
    Get
      Return pPurchaseOrderItem.QtyRequired
    End Get

  End Property

  Public ReadOnly Property UnitPrice As Decimal
    Get


      Return pPurchaseOrderItem.UnitPrice
    End Get

  End Property

  Public ReadOnly Property UnitPriceCordoba As Decimal
    Get
      Dim mRetVal As Decimal = 0


      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = pPurchaseOrderItem.UnitPrice * ExchangeRateValue

        Case eCurrency.Cordobas
          mRetVal = pPurchaseOrderItem.UnitPrice

      End Select

      Return mRetVal

    End Get

  End Property


  Public ReadOnly Property PurchaseOrderItemAllocationID As Int32
    Get
      Return pPurchaseOrderItemAllocation.PurchaseOrderItemAllocationID
    End Get

  End Property

  Public ReadOnly Property ReceivedQty As Decimal
    Get
      Return pPurchaseOrderItemAllocation.ReceivedQty
    End Get

  End Property
  Public ReadOnly Property POStage As Integer
    Get
      Return pPurchaseOrder.POStage
    End Get

  End Property

  Public ReadOnly Property POStageDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePOStage), CType(pPurchaseOrder.POStage, ePOStage))
    End Get

  End Property
  Public ReadOnly Property PurchaseOrderID As Integer
    Get
      Return pPurchaseOrder.PurchaseOrderID
    End Get

  End Property

  Public ReadOnly Property PurchaseCategory As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(pPurchaseOrder.Category, ePurchaseCategories))
    End Get

  End Property

  Public ReadOnly Property CategoryDesc As String
    Get

      Return clsEnumsConstants.GetEnumDescription(GetType(ePurchaseCategories), CType(pPurchaseOrder.Category, ePurchaseCategories))


    End Get

  End Property

  Public ReadOnly Property Carriage As Decimal
    Get
      Return pPurchaseOrder.Carriage
    End Get

  End Property

  Public ReadOnly Property DefaultCurrency As Integer
    Get
      Return pPurchaseOrder.DefaultCurrency
    End Get

  End Property


  Public ReadOnly Property CurrencyDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eCurrency), CType(pPurchaseOrder.DefaultCurrency, eCurrency))
    End Get

  End Property


  Public ReadOnly Property ExchangeRateValue As Decimal
    Get
      Return pPurchaseOrder.ExchangeRateValue
    End Get

  End Property
  Public ReadOnly Property MaterialRequirementTypeID As Integer
    Get
      Return pPurchaseOrder.MaterialRequirementTypeID
    End Get

  End Property
  Public ReadOnly Property RefMatType As String
    Get
      Return pPurchaseOrder.RefMatType
    End Get

  End Property

  Public ReadOnly Property RequiredDate As Date
    Get
      Return pPurchaseOrder.RequiredDate
    End Get

  End Property

  Public ReadOnly Property RequiredDateWC As Date
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pPurchaseOrder.RequiredDate)
    End Get
  End Property

  Public ReadOnly Property RequiredDateMC As Date
    Get
      Return New Date(Year(pPurchaseOrder.RequiredDate), Month(pPurchaseOrder.RequiredDate), 1)
    End Get
  End Property

  Public ReadOnly Property Status As Byte
    Get
      Return pPurchaseOrder.Status
    End Get

  End Property

  Public ReadOnly Property SubmissionDate As Date
    Get
      Return pPurchaseOrder.RequiredDate
    End Get

  End Property

  Public ReadOnly Property SubmissionDateWC As Date
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pPurchaseOrder.SubmissionDate)
    End Get
  End Property

  Public ReadOnly Property SubmissionDateMC As Date
    Get
      Return New Date(Year(pPurchaseOrder.SubmissionDate), Month(pPurchaseOrder.SubmissionDate), 1)
    End Get
  End Property


  Public ReadOnly Property PONum As String
    Get
      Return pPurchaseOrder.PONum
    End Get

  End Property

  Public ReadOnly Property AccoutingCategoryID As Int32
    Get
      Return pPurchaseOrder.AccoutingCategoryID
    End Get

  End Property
  Public ReadOnly Property AccoutingCategoryDesc() As String
    Get
      Return AppRTISGlobal.GetInstance.RefLists.RefListVI(appRefLists.AccoutingCategory).DisplayValueString(pPurchaseOrder.AccoutingCategoryID)
    End Get

  End Property

  Public ReadOnly Property PaymentStatus As Integer
    Get
      Return pPurchaseOrder.PaymentStatus
    End Get

  End Property


  Public ReadOnly Property StockItemID As Int32
    Get
      Return pStockItem.StockItemID
    End Get

  End Property

  Public ReadOnly Property Category As Int32
    Get
      Return pStockItem.Category
    End Get

  End Property

  Public ReadOnly Property StockitemCategoryDesc As String
    Get
      If pStockItem.Category = eStockItemCategory.None Then
        Return "Administrativo"
      Else
        Return clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pStockItem.Category, eStockItemCategory))

      End If
    End Get

  End Property

  Public ReadOnly Property ItemType As Int32
    Get
      Return pStockItem.ItemType
    End Get
  End Property

  Public ReadOnly Property StockItemTypeDesc As String
    Get
      Dim mRetVal = ""
      Select Case pStockItem.Category
        Case eStockItemCategory.Abrasivos
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeAbrasivos), CType(pStockItem.ItemType, eStockItemTypeAbrasivos.eStockItemAbrasivos))


        Case eStockItemCategory.NailsAndBolds
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeNailsAndBolts), CType(pStockItem.ItemType, eStockItemTypeNailsAndBolts.eStockItemNailAndBolts))

        Case eStockItemCategory.EPP
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeEPP), CType(pStockItem.ItemType, eStockItemTypeEPP.eStockItemMaterialEPP))


        Case eStockItemCategory.Herrajes
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerrajes), CType(pStockItem.ItemType, eStockItemTypeHerrajes.eStockItemHerrajes))


        Case eStockItemCategory.Herramientas
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeHerramientas), CType(pStockItem.ItemType, eStockItemTypeHerramientas.eStockItemMaterialHerramientas))


        Case eStockItemCategory.MatElect
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialElectrico), CType(pStockItem.ItemType, eStockItemTypeMaterialElectrico.eStockItemMaterialElectrico))



        Case eStockItemCategory.MatEmpaque
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMaterialEmpaque), CType(pStockItem.ItemType, eStockItemTypeMaterialEmpaque.StockItemMaterialEmpaque))


        Case eStockItemCategory.MatVarios
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMatVarios), CType(pStockItem.ItemType, eStockItemTypeMatVarios.eStockItemMaterialMatVarios))



        Case eStockItemCategory.Metal
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeMetales), CType(pStockItem.ItemType, eStockItemTypeMetales.eStockItemMetales))



        Case eStockItemCategory.PinturaYQuimico
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypePintura), CType(pStockItem.ItemType, eStockItemTypePintura.eStockItemPintura))


        Case eStockItemCategory.Laminas
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeLamina), CType(pStockItem.ItemType, eStockItemTypeLamina.eStockItemLamina))



        Case eStockItemCategory.Repuestos
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeRepuestosYPartes), CType(pStockItem.ItemType, eStockItemTypeRepuestosYPartes.eStockItemRepuestosYPartes))


        Case eStockItemCategory.Tapiceria
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeTapiceria), CType(pStockItem.ItemType, eStockItemTypeTapiceria.eStockItemTapiceria))


        Case eStockItemCategory.VidrioYEspejo
          mRetVal = RTIS.CommonVB.clsEnumsConstants.GetEnumDescription(GetType(eStockItemTypeVidrioYEspejo), CType(pStockItem.ItemType, eStockItemTypeVidrioYEspejo.eStockItemVidrioYEspejo))

      End Select

      Return mRetVal
    End Get
  End Property


  Public ReadOnly Property SalesOrderPhaseID As Int32
    Get
      Return pSalesOrderPhase.SalesOrderPhaseID
    End Get
  End Property


  Public ReadOnly Property SalesOrderID As Int32
    Get
      Return pSalesOrder.SalesOrderID
    End Get
  End Property


  Public ReadOnly Property ProjectName As String
    Get
      Dim mRetVal As String = pSalesOrder.ProjectName

      If pSalesOrder.ProjectName = "" Then
        mRetVal = "S/P-Inventario"
      End If

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property OrderNo As String
    Get
      Return pSalesOrder.OrderNo
    End Get
  End Property

  Public ReadOnly Property CustomerID As Int32
    Get
      Return pCustomer.CustomerID
    End Get
  End Property

  Public ReadOnly Property CompanyName As String
    Get
      Return pSalesOrder.CompanyName
    End Get
  End Property

  Public ReadOnly Property TotalReceivedAmountCordoba As Decimal
    Get
      Dim mRetVal As Decimal = 0

      Select Case DefaultCurrency
        Case eCurrency.Cordobas

          mRetVal = pPurchaseOrderItem.UnitPrice * pPurchaseOrderItemAllocation.ReceivedQty

        Case eCurrency.Dollar
          If pPurchaseOrder.ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrderItem.UnitPrice * pPurchaseOrderItemAllocation.ReceivedQty) * ExchangeRateValue

          End If

      End Select

      Return mRetVal
    End Get

  End Property

  Public ReadOnly Property TotalPurchaseOrderItem As Decimal
    Get
      Return pPurchaseOrderItem.UnitPrice * pPurchaseOrderItem.QtyRequired
    End Get
  End Property

  Public ReadOnly Property TotalReceivedAmount As Decimal
    Get
      Return pPurchaseOrderItem.UnitPrice * pPurchaseOrderItemAllocation.ReceivedQty
    End Get
  End Property

  Public ReadOnly Property TotalReceivedAmountUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalReceivedAmount

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrderItem.UnitPrice * pPurchaseOrderItemAllocation.ReceivedQty) / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property



  Public ReadOnly Property TotalPurchaseOrderItemAmountUSD As Decimal
    Get
      Dim mRetVal As Decimal = 0
      Select Case DefaultCurrency
        Case eCurrency.Dollar

          mRetVal = TotalPurchaseOrderItem

        Case eCurrency.Cordobas
          If ExchangeRateValue > 0 Then
            mRetVal = (pPurchaseOrderItem.UnitPrice * pPurchaseOrderItem.QtyRequired) / ExchangeRateValue
          Else
            mRetVal = 0
          End If

      End Select

      Return mRetVal
    End Get

  End Property


End Class

Public Class colPurchaseOrderItemInfos : Inherits List(Of clsPurchaseOrderItemInfo)

End Class

