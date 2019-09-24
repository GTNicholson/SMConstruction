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

End Class

Public Class colMaterialRequirementInfos : Inherits List(Of clsMaterialRequirementInfo)

End Class