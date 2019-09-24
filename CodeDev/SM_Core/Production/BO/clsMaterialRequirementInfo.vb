Public Class clsMaterialRequirementInfo
  Private pMaterialRequirement As dmMaterialRequirement

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    pMaterialRequirement = rMaterialRequirement
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


  Public ReadOnly Property NetWidth As Decimal
    Get
      Return pMaterialRequirement.NetWidth
    End Get
  End Property


  Public ReadOnly Property NetLenght As Decimal
    Get
      Return pMaterialRequirement.NetLenght
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


End Class


Public Class colMaterialRequirementInfos : Inherits List(Of clsMaterialRequirementInfo)

End Class