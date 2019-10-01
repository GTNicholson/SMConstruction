Public Class clsMaterialRequirementInfo
  Private pMaterialRequirement As dmMaterialRequirement
  Private pWorkOrder As dmWorkOrder

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    pMaterialRequirement = rMaterialRequirement
    pWorkOrder = New dmWorkOrder
  End Sub

  Public ReadOnly Property Description As String
    Get
      Return pMaterialRequirement.Description
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
      Return clsSMSharedFuncs.WOTotalPieces(pWorkOrder.Quantity, pMaterialRequirement.UnitPiece)
    End Get
  End Property


End Class


Public Class colMaterialRequirementInfos : Inherits List(Of clsMaterialRequirementInfo)

End Class