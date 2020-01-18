Public Class clsMaterialRequirementInfo
  Private pMaterialRequirement As dmMaterialRequirement
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderItem As dmSalesOrderItem
  Private pStockItem As dmStockItem
  Private pProductFurniture As dmProductFurniture

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    pMaterialRequirement = rMaterialRequirement
    pWorkOrder = New dmWorkOrder
    pSalesOrderItem = New dmSalesOrderItem
    pStockItem = New dmStockItem
    pProductFurniture = New dmProductFurniture
  End Sub

  Public Sub New()
    pMaterialRequirement = New dmMaterialRequirement
    pWorkOrder = New dmWorkOrder
    pSalesOrderItem = New dmSalesOrderItem
    pStockItem = New dmStockItem
    pProductFurniture = New dmProductFurniture
  End Sub

  Public Property MaterialRequirement As dmMaterialRequirement
    Get
      Return pMaterialRequirement
    End Get
    Set(ByVal value As dmMaterialRequirement)
      pMaterialRequirement = value
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

  Public Property ProductFurniture As dmProductFurniture
    Get
      Return pProductFurniture
    End Get
    Set(ByVal value As dmProductFurniture)
      pProductFurniture = value
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

  Public Property StockItem As dmStockItem
    Get
      Return pStockItem
    End Get
    Set(value As dmStockItem)
      pStockItem = value
    End Set
  End Property

  Public ReadOnly Property WoodSpecieID As Int32
    Get
      Return pMaterialRequirement.WoodSpecie
    End Get

  End Property

  Public ReadOnly Property Quality As Int32
    Get
      Return pMaterialRequirement.QualityType
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


End Class


Public Class colMaterialRequirementInfos : Inherits List(Of clsMaterialRequirementInfo)

End Class