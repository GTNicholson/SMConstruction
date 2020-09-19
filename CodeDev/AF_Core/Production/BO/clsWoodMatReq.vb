Public Class clsWoodMatReq : Inherits clsMaterialRequirementInfo

  Public Sub New(ByRef rMaterialRequirement As dmMaterialRequirement)
    MyBase.New(rMaterialRequirement)
  End Sub


End Class

Public Class colWoodMatReqs : Inherits List(Of clsWoodMatReq)

End Class


