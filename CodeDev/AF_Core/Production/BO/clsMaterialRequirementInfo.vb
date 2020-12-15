Imports RTIS.CommonVB

Public Class clsMaterialRequirementInfo
  Private pMaterialRequirement As dmMaterialRequirement
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderItem As dmSalesOrderItem
  Private pStockItem As dmStockItem
  Private pProductFurniture As dmProductFurniture
  Private pSalesOrder As dmSalesOrder
  Private pCustomer As dmCustomer
  Private pOSQty As Decimal
  Private pStockItemTransactionLog As dmStockItemTransactionLog
  Private pExchangeRate As Decimal

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    pMaterialRequirement = rMaterialRequirement
    pWorkOrder = New dmWorkOrder
    pSalesOrderItem = New dmSalesOrderItem
    pStockItem = New dmStockItem
    pProductFurniture = New dmProductFurniture
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
    pStockItemTransactionLog = New dmStockItemTransactionLog
  End Sub

  Public Sub New()
    pMaterialRequirement = New dmMaterialRequirement
    pWorkOrder = New dmWorkOrder
    pSalesOrderItem = New dmSalesOrderItem
    pStockItem = New dmStockItem
    pProductFurniture = New dmProductFurniture
    pSalesOrder = New dmSalesOrder
    pCustomer = New dmCustomer
    pStockItemTransactionLog = New dmStockItemTransactionLog
  End Sub

  Public Property MaterialRequirement As dmMaterialRequirement
    Get
      Return pMaterialRequirement
    End Get
    Set(ByVal value As dmMaterialRequirement)
      pMaterialRequirement = value
    End Set
  End Property

  Public Property MaterialRequirementID As Int32
    Get
      Return pMaterialRequirement.MaterialRequirementID
    End Get
    Set(ByVal value As Int32)
      pMaterialRequirement.MaterialRequirementID = value
    End Set
  End Property



  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(ByVal value As dmWorkOrder)
      pWorkOrder = value
    End Set
  End Property

  Public Property WorkOrderNo As String
    Get
      Return pWorkOrder.WorkOrderNo
    End Get
    Set(ByVal value As String)
      pWorkOrder.WorkOrderNo = value
    End Set
  End Property


  Public Property WODescription As String
    Get
      Return pWorkOrder.Description
    End Get
    Set(ByVal value As String)
      pWorkOrder.Description = value
    End Set
  End Property

  Public Property WoodSpecie As Int32
    Get
      Return pWorkOrder.WoodSpecieID
    End Get
    Set(ByVal value As Int32)
      pWorkOrder.WoodSpecieID = value
    End Set
  End Property

  Public Property PlannedStartDate As Date
    Get
      Return pWorkOrder.PlannedStartDate
    End Get
    Set(ByVal value As Date)
      pWorkOrder.PlannedStartDate = value
    End Set
  End Property
  Public Property PlannedDeliverDate As Date
    Get
      Return pWorkOrder.PlannedDeliverDate
    End Get
    Set(ByVal value As Date)
      pWorkOrder.PlannedDeliverDate = value
    End Set
  End Property

  Public Property ProjectName As String
    Get
      Return pSalesOrder.ProjectName
    End Get
    Set(ByVal value As String)
      pSalesOrder.ProjectName = value
    End Set
  End Property

  Public Property ProductFurniture As dmProductFurniture
    Get
      Return pProductFurniture
    End Get
    Set(ByVal value As dmProductFurniture)
      pProductFurniture = value
    End Set
  End Property

  Public Property CompanyName As String
    Get
      Return pCustomer.CompanyName
    End Get
    Set(ByVal value As String)
      pCustomer.CompanyName = value
    End Set
  End Property

  Public Property SalesOrderItem As dmSalesOrderItem
    Get
      Return pSalesOrderItem
    End Get
    Set(ByVal value As dmSalesOrderItem)
      pSalesOrderItem = value
    End Set
  End Property

  Public Property SalesOrder As dmSalesOrder
    Get
      Return pSalesOrder
    End Get
    Set(ByVal value As dmSalesOrder)
      pSalesOrder = value
    End Set
  End Property

  Public Property Customer As dmCustomer
    Get
      Return pCustomer
    End Get
    Set(ByVal value As dmCustomer)
      pCustomer = value
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

  Public Property StdCost As Decimal
    Get

      Dim mRetval As Decimal = 0

      If ExchangeRate > 0 Then
        mRetval = (pStockItem.StdCost) / ExchangeRate

      Else
        mRetVal = 0
      End If

      Return mRetval


    End Get
    Set(value As Decimal)
      pStockItem.StdCost = value
    End Set
  End Property
  Public Property ProductFurnitureID As Int32
    Get
      Return pProductFurniture.ProductFurnitureID
    End Get
    Set(value As Int32)
      pProductFurniture.ProductFurnitureID = value
    End Set
  End Property

  Public ReadOnly Property StockCode As String
    Get
      If StockItem IsNot Nothing Then
        Return pStockItem.StockCode
      End If
      Return ""
    End Get
  End Property

  Public ReadOnly Property TotalAmount As Decimal
    Get
      Dim mRetVal As Decimal
      If pStockItem IsNot Nothing Then
        mRetVal = clsStockItemSharedFuncs.getStockItemValue(pStockItem, Quantity)
      End If
      Return mRetVal
    End Get
  End Property

  Public ReadOnly Property WoodSpecieID As Int32
    Get
      Return pMaterialRequirement.WoodSpecie
    End Get

  End Property


  Public ReadOnly Property PartNo As String
    Get
      If pStockItem IsNot Nothing Then
        Return pStockItem.PartNo
      End If
      Return ""
    End Get

  End Property

  Public ReadOnly Property Quality As Int32
    Get
      Return pMaterialRequirement.QualityType
    End Get

  End Property

  Public ReadOnly Property MaterialRequirementType As Int32
    Get
      Return pMaterialRequirement.MaterialRequirementType
    End Get

  End Property

  Public ReadOnly Property Material As Int32
    Get
      Return pMaterialRequirement.MaterialTypeID
    End Get

  End Property


  Public ReadOnly Property WorkOrderQuantity As Integer
    Get
      Return pWorkOrder.Quantity
    End Get
  End Property

  Public ReadOnly Property Description As String
    Get
      Dim mretValue As String = ""

      If pMaterialRequirement.StockItemID = 0 Then
        mretValue = pMaterialRequirement.Description
      Else
        mretValue = pStockItem.Description
      End If

      Return mretValue
    End Get
  End Property

  Public ReadOnly Property UoM As String
    Get
      Return pMaterialRequirement.UoM
    End Get
  End Property

  Public ReadOnly Property AreaID As Int32
    Get
      Return pMaterialRequirement.AreaID
    End Get
  End Property

  Public ReadOnly Property SupplierStockCode As String
    Get
      Return pMaterialRequirement.SupplierStockCode
    End Get
  End Property

  Public ReadOnly Property Comments As String
    Get
      Return pMaterialRequirement.Comments
    End Get
  End Property

  Public ReadOnly Property NetThickness As Decimal
    Get
      Return pMaterialRequirement.NetThickness
    End Get
  End Property

  Public ReadOnly Property InitialThickness As Decimal
    Get
      Return clsSMSharedFuncs.GrosWoodThickness(pMaterialRequirement.NetThickness)
    End Get
  End Property


  Public ReadOnly Property InitialThicknessFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.GrosWoodThickness(pMaterialRequirement.NetThickness))
    End Get
  End Property



  Public ReadOnly Property NetWidth As Decimal
    Get
      Return pMaterialRequirement.NetWidth
    End Get
  End Property


  Public ReadOnly Property InitialWidth As Decimal
    Get
      Return clsSMSharedFuncs.CMToQuaterInches(pMaterialRequirement.NetWidth)
    End Get
  End Property


  Public ReadOnly Property InitialWidthFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToQuaterInches(pMaterialRequirement.NetWidth))
    End Get
  End Property


  Public ReadOnly Property NetLenght As Decimal
    Get
      Return pMaterialRequirement.NetLenght
    End Get
  End Property


  Public ReadOnly Property InitialLenght As Decimal
    Get
      Return clsSMSharedFuncs.CMToQuaterInches(pMaterialRequirement.NetLenght)
    End Get
  End Property


  Public ReadOnly Property InitialLenghtFraction As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToHalfInchesLength(pMaterialRequirement.NetLenght))
    End Get
  End Property

  Public ReadOnly Property InitialLenghtFractionFeet As String
    Get
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.WoodLengthFeet(pMaterialRequirement.NetLenght))
    End Get
  End Property


  Public ReadOnly Property QualityType As Int32
    Get
      Return pMaterialRequirement.QualityType
    End Get
  End Property


  Public ReadOnly Property MaterialTypeID As Int32
    Get
      Return pMaterialRequirement.MaterialTypeID
    End Get
  End Property

  Public ReadOnly Property UnitPiece As Int32
    Get
      Return pMaterialRequirement.UnitPiece
    End Get
  End Property


  Public ReadOnly Property Quantity As Decimal
    Get
      Return pMaterialRequirement.Quantity
    End Get
  End Property



  Public ReadOnly Property PickedQty As Decimal
    Get
      Return pMaterialRequirement.PickedQty
    End Get

  End Property

  Public ReadOnly Property QtyOS As Decimal
    Get
      Return pMaterialRequirement.Quantity - pMaterialRequirement.PickedQty
    End Get
  End Property


  Public ReadOnly Property DateChange As DateTime
    Get
      Return pMaterialRequirement.DateChange
    End Get
  End Property

  Public ReadOnly Property DateOtherMaterial As DateTime
    Get
      Return pMaterialRequirement.DateOtherMaterial
    End Get
  End Property

  Public ReadOnly Property PiecesPerComponent As Decimal
    Get
      Return pMaterialRequirement.PiecesPerComponent
    End Get
  End Property


  Public ReadOnly Property TotalPieces As Int32
    Get
      Dim mRetVal As Int32

      If pMaterialRequirement.PiecesPerComponent <> 0 Then
        mRetVal = (pMaterialRequirement.UnitPiece * WorkOrder.Quantity) / pMaterialRequirement.PiecesPerComponent
      End If

      Return mRetVal

    End Get

  End Property
  Public ReadOnly Property TotalPieces_SMM As Decimal
    Get
      Return pMaterialRequirement.TotalPieces

    End Get

  End Property

  Public ReadOnly Property Category As Int32
    Get
      Return pStockItem.Category

    End Get

  End Property

  Public Property ExchangeRate As Decimal
    Get
      Return pExchangeRate
    End Get
    Set(value As Decimal)
      pExchangeRate = value
    End Set
  End Property
  Public ReadOnly Property CategoryDesc As String
    Get
      Return clsEnumsConstants.GetEnumDescription(GetType(eStockItemCategory), CType(pStockItem.Category, eStockItemCategory))

    End Get

  End Property

  Public Property OSQty As Decimal
    Get
      Return pOSQty
    End Get
    Set(value As Decimal)
      pOSQty = value
    End Set
  End Property


  Public ReadOnly Property TotalBoardFeetFromCM As Decimal
    Get
      Return Math.Round(clsSMSharedFuncs.BoardFeetFromCMAndQty(TotalPieces, clsSMSharedFuncs.WoodLengthFeet(pMaterialRequirement.NetLenght),
                                              clsSMSharedFuncs.CMToQuaterInches(pMaterialRequirement.NetWidth),
                                              clsSMSharedFuncs.GrosWoodThickness(pMaterialRequirement.NetThickness)), 3) * TotalPieces * UnitPiece

    End Get
  End Property


  Public ReadOnly Property TotalBoardFeetReport As Decimal
    Get
      Return Math.Round(clsSMSharedFuncs.BoardFeetFromCMAndQty(TotalPieces, pMaterialRequirement.NetLenght, pMaterialRequirement.NetWidth, pMaterialRequirement.NetThickness), 3)

    End Get
  End Property

  Public Property StockItemTransactionLog As dmStockItemTransactionLog
    Get
      Return pStockItemTransactionLog
    End Get
    Set(value As dmStockItemTransactionLog)
      pStockItemTransactionLog = value
    End Set
  End Property

  Public ReadOnly Property TransactionDate As Date
    Get
      Return pStockItemTransactionLog.TransactionDate
    End Get
  End Property

  Public ReadOnly Property RequiredDateWC As Date
    Get
      Return RTIS.CommonVB.libDateTime.MondayOfWeek(pStockItemTransactionLog.TransactionDate)
    End Get
  End Property

  Public ReadOnly Property RequiredDateMC As Date
    Get
      Return New Date(Year(pStockItemTransactionLog.TransactionDate), Month(pStockItemTransactionLog.TransactionDate), 1)
    End Get
  End Property

  Public ReadOnly Property TransactionValuationDollar As Decimal
    Get
      Dim mRetval As Decimal = 0

      If ExchangeRate > 0 Then
        mRetval = (pStockItemTransactionLog.TransactionValuationDollar) / ExchangeRate * (-1)
      Else
        mRetVal = 0
      End If

      Return mRetval
    End Get
  End Property
End Class


Public Class colMaterialRequirementInfos : Inherits List(Of clsMaterialRequirementInfo)

End Class