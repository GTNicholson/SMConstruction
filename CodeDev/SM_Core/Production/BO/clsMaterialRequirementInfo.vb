Public Class clsMaterialRequirementInfo
  Private pMaterialRequirement As dmMaterialRequirement
  Private pWorkOrder As dmWorkOrder
  Private pSalesOrderItem As dmSalesOrderItem

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    pMaterialRequirement = rMaterialRequirement
    pWorkOrder = New dmWorkOrder
    pSalesOrderItem = New dmSalesOrderItem
  End Sub
  Public Property WorkOrder As dmWorkOrder
    Get
      Return pWorkOrder
    End Get
    Set(ByVal value As dmWorkOrder)
      pWorkOrder = value
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
      Return pMaterialRequirement.Description
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
      Return clsSMSharedFuncs.DecToFraction(clsSMSharedFuncs.CMToQuaterInchesLenght(pMaterialRequirement.NetLenght))
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


  Public ReadOnly Property TotalPieces As Int32
    Get
      Dim mRetVal As Int32

      mRetVal = pMaterialRequirement.UnitPiece * pSalesOrderItem.Quantity


      Return mRetVal

    End Get


  End Property




  Public ReadOnly Property TotalBoardFeetFromCM As Decimal
    Get
      Return Math.Round(clsSMSharedFuncs.BoardFeetFromCM(clsSMSharedFuncs.WoodLengthFeet(pMaterialRequirement.NetLenght),
                                              clsSMSharedFuncs.CMToQuaterInches(pMaterialRequirement.NetWidth),
                                              clsSMSharedFuncs.GrosWoodThickness(pMaterialRequirement.NetThickness)), 3) * UnitPiece * WorkOrderQuantity

    End Get
  End Property

End Class


Public Class colMaterialRequirementInfos : Inherits List(Of clsMaterialRequirementInfo)

End Class