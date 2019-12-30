Public Class clsMaterialRequirementProcessor : Inherits clsMaterialRequirementInfo
  Private pToProcess As Decimal

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    MyBase.New(rMaterialRequirement)
  End Sub

End Class


